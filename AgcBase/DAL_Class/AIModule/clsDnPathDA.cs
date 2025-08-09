
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDnPathDA
 表名:DnPath(00050591)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:00:52
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:AI模块(AIModule)
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
 /// 数据结点路径(DnPath)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsDnPathDA : clsCommBase4DA
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
 return clsDnPathEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsDnPathEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsDnPathEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsDnPathEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsDnPathEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strDnPathId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strDnPathId)
{
strDnPathId = strDnPathId.Replace("'", "''");
if (strDnPathId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:DnPath中,检查关键字,长度不正确!(clsDnPathDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strDnPathId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:DnPath中,关键字不能为空 或 null!(clsDnPathDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strDnPathId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsDnPathDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsDnPathDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnPathDA.GetSpecSQLObj();
strSQL = "Select * from DnPath where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_DnPath(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsDnPathDA: GetDataTable_DnPath)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnPathDA.GetSpecSQLObj();
strSQL = "Select * from DnPath where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsDnPathDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnPathDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsDnPathDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnPathDA.GetSpecSQLObj();
strSQL = "Select * from DnPath where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsDnPathDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnPathDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsDnPathDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnPathDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from DnPath where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from DnPath where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsDnPathDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnPathDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from DnPath where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsDnPathDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnPathDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} DnPath.* " + 
$"from DnPath " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and DnPath.DnPathId not in " + 
$"(Select top {intTop_In} DnPath.DnPathId from DnPath " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from DnPath where {1} and DnPathId not in (Select top {2} DnPathId from DnPath where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from DnPath where {1} and DnPathId not in (Select top {3} DnPathId from DnPath where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsDnPathDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnPathDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} DnPath.* " + 
$"from DnPath " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and DnPath.DnPathId not in " + 
$"(Select top {intTop_In} DnPath.DnPathId from DnPath " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from DnPath where {1} and DnPathId not in (Select top {2} DnPathId from DnPath where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from DnPath where {1} and DnPathId not in (Select top {3} DnPathId from DnPath where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsDnPathEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsDnPathDA:GetObjLst)", objException.Message));
}
List<clsDnPathEN> arrObjLst = new List<clsDnPathEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnPathDA.GetSpecSQLObj();
strSQL = "Select * from DnPath where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDnPathEN objDnPathEN = new clsDnPathEN();
try
{
objDnPathEN.DnPathId = objRow[conDnPath.DnPathId].ToString().Trim(); //DN路径Id
objDnPathEN.DnPathName = objRow[conDnPath.DnPathName].ToString().Trim(); //DN路径名
objDnPathEN.InDataNodeId = TransNullToInt(objRow[conDnPath.InDataNodeId].ToString().Trim()); //In数据结点Id
objDnPathEN.OutDataNodeId = TransNullToInt(objRow[conDnPath.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objDnPathEN.DnPathNodeLst = objRow[conDnPath.DnPathNodeLst].ToString().Trim(); //路径结点列表
objDnPathEN.DnPathNodeLstV2 = objRow[conDnPath.DnPathNodeLstV2] == DBNull.Value ? null : objRow[conDnPath.DnPathNodeLstV2].ToString().Trim(); //路径结点列表V2
objDnPathEN.AssociationMappingId = objRow[conDnPath.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objDnPathEN.IsHasErr = TransNullToBool(objRow[conDnPath.IsHasErr].ToString().Trim()); //是否有错
objDnPathEN.EdgeNum = objRow[conDnPath.EdgeNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDnPath.EdgeNum].ToString().Trim()); //边数
objDnPathEN.ErrMsg = objRow[conDnPath.ErrMsg] == DBNull.Value ? null : objRow[conDnPath.ErrMsg].ToString().Trim(); //错误信息
objDnPathEN.InUse = TransNullToBool(objRow[conDnPath.InUse].ToString().Trim()); //是否在用
objDnPathEN.IsExistPath = TransNullToBool(objRow[conDnPath.IsExistPath].ToString().Trim()); //是否存在路径
objDnPathEN.PrjId = objRow[conDnPath.PrjId].ToString().Trim(); //工程Id
objDnPathEN.UpdDate = objRow[conDnPath.UpdDate] == DBNull.Value ? null : objRow[conDnPath.UpdDate].ToString().Trim(); //修改日期
objDnPathEN.UpdUser = objRow[conDnPath.UpdUser] == DBNull.Value ? null : objRow[conDnPath.UpdUser].ToString().Trim(); //修改者
objDnPathEN.Memo = objRow[conDnPath.Memo] == DBNull.Value ? null : objRow[conDnPath.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsDnPathDA: GetObjLst)", objException.Message));
}
objDnPathEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objDnPathEN);
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
public List<clsDnPathEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsDnPathDA:GetObjLstByTabName)", objException.Message));
}
List<clsDnPathEN> arrObjLst = new List<clsDnPathEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnPathDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDnPathEN objDnPathEN = new clsDnPathEN();
try
{
objDnPathEN.DnPathId = objRow[conDnPath.DnPathId].ToString().Trim(); //DN路径Id
objDnPathEN.DnPathName = objRow[conDnPath.DnPathName].ToString().Trim(); //DN路径名
objDnPathEN.InDataNodeId = TransNullToInt(objRow[conDnPath.InDataNodeId].ToString().Trim()); //In数据结点Id
objDnPathEN.OutDataNodeId = TransNullToInt(objRow[conDnPath.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objDnPathEN.DnPathNodeLst = objRow[conDnPath.DnPathNodeLst].ToString().Trim(); //路径结点列表
objDnPathEN.DnPathNodeLstV2 = objRow[conDnPath.DnPathNodeLstV2] == DBNull.Value ? null : objRow[conDnPath.DnPathNodeLstV2].ToString().Trim(); //路径结点列表V2
objDnPathEN.AssociationMappingId = objRow[conDnPath.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objDnPathEN.IsHasErr = TransNullToBool(objRow[conDnPath.IsHasErr].ToString().Trim()); //是否有错
objDnPathEN.EdgeNum = objRow[conDnPath.EdgeNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDnPath.EdgeNum].ToString().Trim()); //边数
objDnPathEN.ErrMsg = objRow[conDnPath.ErrMsg] == DBNull.Value ? null : objRow[conDnPath.ErrMsg].ToString().Trim(); //错误信息
objDnPathEN.InUse = TransNullToBool(objRow[conDnPath.InUse].ToString().Trim()); //是否在用
objDnPathEN.IsExistPath = TransNullToBool(objRow[conDnPath.IsExistPath].ToString().Trim()); //是否存在路径
objDnPathEN.PrjId = objRow[conDnPath.PrjId].ToString().Trim(); //工程Id
objDnPathEN.UpdDate = objRow[conDnPath.UpdDate] == DBNull.Value ? null : objRow[conDnPath.UpdDate].ToString().Trim(); //修改日期
objDnPathEN.UpdUser = objRow[conDnPath.UpdUser] == DBNull.Value ? null : objRow[conDnPath.UpdUser].ToString().Trim(); //修改者
objDnPathEN.Memo = objRow[conDnPath.Memo] == DBNull.Value ? null : objRow[conDnPath.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsDnPathDA: GetObjLst)", objException.Message));
}
objDnPathEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objDnPathEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objDnPathEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetDnPath(ref clsDnPathEN objDnPathEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnPathDA.GetSpecSQLObj();
strSQL = "Select * from DnPath where DnPathId = " + "'"+ objDnPathEN.DnPathId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objDnPathEN.DnPathId = objDT.Rows[0][conDnPath.DnPathId].ToString().Trim(); //DN路径Id(字段类型:char,字段长度:8,是否可空:False)
 objDnPathEN.DnPathName = objDT.Rows[0][conDnPath.DnPathName].ToString().Trim(); //DN路径名(字段类型:varchar,字段长度:100,是否可空:False)
 objDnPathEN.InDataNodeId = TransNullToInt(objDT.Rows[0][conDnPath.InDataNodeId].ToString().Trim()); //In数据结点Id(字段类型:bigint,字段长度:8,是否可空:True)
 objDnPathEN.OutDataNodeId = TransNullToInt(objDT.Rows[0][conDnPath.OutDataNodeId].ToString().Trim()); //Out数据结点Id(字段类型:bigint,字段长度:8,是否可空:True)
 objDnPathEN.DnPathNodeLst = objDT.Rows[0][conDnPath.DnPathNodeLst].ToString().Trim(); //路径结点列表(字段类型:varchar,字段长度:500,是否可空:False)
 objDnPathEN.DnPathNodeLstV2 = objDT.Rows[0][conDnPath.DnPathNodeLstV2].ToString().Trim(); //路径结点列表V2(字段类型:varchar,字段长度:500,是否可空:False)
 objDnPathEN.AssociationMappingId = objDT.Rows[0][conDnPath.AssociationMappingId].ToString().Trim(); //关联关系映射Id(字段类型:char,字段长度:2,是否可空:True)
 objDnPathEN.IsHasErr = TransNullToBool(objDT.Rows[0][conDnPath.IsHasErr].ToString().Trim()); //是否有错(字段类型:bit,字段长度:1,是否可空:True)
 objDnPathEN.EdgeNum = TransNullToInt(objDT.Rows[0][conDnPath.EdgeNum].ToString().Trim()); //边数(字段类型:int,字段长度:4,是否可空:True)
 objDnPathEN.ErrMsg = objDT.Rows[0][conDnPath.ErrMsg].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:2000,是否可空:True)
 objDnPathEN.InUse = TransNullToBool(objDT.Rows[0][conDnPath.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objDnPathEN.IsExistPath = TransNullToBool(objDT.Rows[0][conDnPath.IsExistPath].ToString().Trim()); //是否存在路径(字段类型:bit,字段长度:1,是否可空:False)
 objDnPathEN.PrjId = objDT.Rows[0][conDnPath.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objDnPathEN.UpdDate = objDT.Rows[0][conDnPath.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objDnPathEN.UpdUser = objDT.Rows[0][conDnPath.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objDnPathEN.Memo = objDT.Rows[0][conDnPath.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsDnPathDA: GetDnPath)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strDnPathId">表关键字</param>
 /// <returns>表对象</returns>
public clsDnPathEN GetObjByDnPathId(string strDnPathId)
{
CheckPrimaryKey(strDnPathId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnPathDA.GetSpecSQLObj();
strSQL = "Select * from DnPath where DnPathId = " + "'"+ strDnPathId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsDnPathEN objDnPathEN = new clsDnPathEN();
try
{
 objDnPathEN.DnPathId = objRow[conDnPath.DnPathId].ToString().Trim(); //DN路径Id(字段类型:char,字段长度:8,是否可空:False)
 objDnPathEN.DnPathName = objRow[conDnPath.DnPathName].ToString().Trim(); //DN路径名(字段类型:varchar,字段长度:100,是否可空:False)
 objDnPathEN.InDataNodeId = Int32.Parse(objRow[conDnPath.InDataNodeId].ToString().Trim()); //In数据结点Id(字段类型:bigint,字段长度:8,是否可空:True)
 objDnPathEN.OutDataNodeId = Int32.Parse(objRow[conDnPath.OutDataNodeId].ToString().Trim()); //Out数据结点Id(字段类型:bigint,字段长度:8,是否可空:True)
 objDnPathEN.DnPathNodeLst = objRow[conDnPath.DnPathNodeLst].ToString().Trim(); //路径结点列表(字段类型:varchar,字段长度:500,是否可空:False)
 objDnPathEN.DnPathNodeLstV2 = objRow[conDnPath.DnPathNodeLstV2] == DBNull.Value ? null : objRow[conDnPath.DnPathNodeLstV2].ToString().Trim(); //路径结点列表V2(字段类型:varchar,字段长度:500,是否可空:False)
 objDnPathEN.AssociationMappingId = objRow[conDnPath.AssociationMappingId].ToString().Trim(); //关联关系映射Id(字段类型:char,字段长度:2,是否可空:True)
 objDnPathEN.IsHasErr = clsEntityBase2.TransNullToBool_S(objRow[conDnPath.IsHasErr].ToString().Trim()); //是否有错(字段类型:bit,字段长度:1,是否可空:True)
 objDnPathEN.EdgeNum = objRow[conDnPath.EdgeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDnPath.EdgeNum].ToString().Trim()); //边数(字段类型:int,字段长度:4,是否可空:True)
 objDnPathEN.ErrMsg = objRow[conDnPath.ErrMsg] == DBNull.Value ? null : objRow[conDnPath.ErrMsg].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:2000,是否可空:True)
 objDnPathEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conDnPath.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objDnPathEN.IsExistPath = clsEntityBase2.TransNullToBool_S(objRow[conDnPath.IsExistPath].ToString().Trim()); //是否存在路径(字段类型:bit,字段长度:1,是否可空:False)
 objDnPathEN.PrjId = objRow[conDnPath.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objDnPathEN.UpdDate = objRow[conDnPath.UpdDate] == DBNull.Value ? null : objRow[conDnPath.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objDnPathEN.UpdUser = objRow[conDnPath.UpdUser] == DBNull.Value ? null : objRow[conDnPath.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objDnPathEN.Memo = objRow[conDnPath.Memo] == DBNull.Value ? null : objRow[conDnPath.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsDnPathDA: GetObjByDnPathId)", objException.Message));
}
return objDnPathEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsDnPathEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsDnPathDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnPathDA.GetSpecSQLObj();
strSQL = "Select * from DnPath where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsDnPathEN objDnPathEN = new clsDnPathEN()
{
DnPathId = objRow[conDnPath.DnPathId].ToString().Trim(), //DN路径Id
DnPathName = objRow[conDnPath.DnPathName].ToString().Trim(), //DN路径名
InDataNodeId = TransNullToInt(objRow[conDnPath.InDataNodeId].ToString().Trim()), //In数据结点Id
OutDataNodeId = TransNullToInt(objRow[conDnPath.OutDataNodeId].ToString().Trim()), //Out数据结点Id
DnPathNodeLst = objRow[conDnPath.DnPathNodeLst].ToString().Trim(), //路径结点列表
DnPathNodeLstV2 = objRow[conDnPath.DnPathNodeLstV2] == DBNull.Value ? null : objRow[conDnPath.DnPathNodeLstV2].ToString().Trim(), //路径结点列表V2
AssociationMappingId = objRow[conDnPath.AssociationMappingId].ToString().Trim(), //关联关系映射Id
IsHasErr = TransNullToBool(objRow[conDnPath.IsHasErr].ToString().Trim()), //是否有错
EdgeNum = objRow[conDnPath.EdgeNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDnPath.EdgeNum].ToString().Trim()), //边数
ErrMsg = objRow[conDnPath.ErrMsg] == DBNull.Value ? null : objRow[conDnPath.ErrMsg].ToString().Trim(), //错误信息
InUse = TransNullToBool(objRow[conDnPath.InUse].ToString().Trim()), //是否在用
IsExistPath = TransNullToBool(objRow[conDnPath.IsExistPath].ToString().Trim()), //是否存在路径
PrjId = objRow[conDnPath.PrjId].ToString().Trim(), //工程Id
UpdDate = objRow[conDnPath.UpdDate] == DBNull.Value ? null : objRow[conDnPath.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conDnPath.UpdUser] == DBNull.Value ? null : objRow[conDnPath.UpdUser].ToString().Trim(), //修改者
Memo = objRow[conDnPath.Memo] == DBNull.Value ? null : objRow[conDnPath.Memo].ToString().Trim() //说明
};
objDnPathEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objDnPathEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsDnPathDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsDnPathEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsDnPathEN objDnPathEN = new clsDnPathEN();
try
{
objDnPathEN.DnPathId = objRow[conDnPath.DnPathId].ToString().Trim(); //DN路径Id
objDnPathEN.DnPathName = objRow[conDnPath.DnPathName].ToString().Trim(); //DN路径名
objDnPathEN.InDataNodeId = TransNullToInt(objRow[conDnPath.InDataNodeId].ToString().Trim()); //In数据结点Id
objDnPathEN.OutDataNodeId = TransNullToInt(objRow[conDnPath.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objDnPathEN.DnPathNodeLst = objRow[conDnPath.DnPathNodeLst].ToString().Trim(); //路径结点列表
objDnPathEN.DnPathNodeLstV2 = objRow[conDnPath.DnPathNodeLstV2] == DBNull.Value ? null : objRow[conDnPath.DnPathNodeLstV2].ToString().Trim(); //路径结点列表V2
objDnPathEN.AssociationMappingId = objRow[conDnPath.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objDnPathEN.IsHasErr = TransNullToBool(objRow[conDnPath.IsHasErr].ToString().Trim()); //是否有错
objDnPathEN.EdgeNum = objRow[conDnPath.EdgeNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDnPath.EdgeNum].ToString().Trim()); //边数
objDnPathEN.ErrMsg = objRow[conDnPath.ErrMsg] == DBNull.Value ? null : objRow[conDnPath.ErrMsg].ToString().Trim(); //错误信息
objDnPathEN.InUse = TransNullToBool(objRow[conDnPath.InUse].ToString().Trim()); //是否在用
objDnPathEN.IsExistPath = TransNullToBool(objRow[conDnPath.IsExistPath].ToString().Trim()); //是否存在路径
objDnPathEN.PrjId = objRow[conDnPath.PrjId].ToString().Trim(); //工程Id
objDnPathEN.UpdDate = objRow[conDnPath.UpdDate] == DBNull.Value ? null : objRow[conDnPath.UpdDate].ToString().Trim(); //修改日期
objDnPathEN.UpdUser = objRow[conDnPath.UpdUser] == DBNull.Value ? null : objRow[conDnPath.UpdUser].ToString().Trim(); //修改者
objDnPathEN.Memo = objRow[conDnPath.Memo] == DBNull.Value ? null : objRow[conDnPath.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsDnPathDA: GetObjByDataRowDnPath)", objException.Message));
}
objDnPathEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objDnPathEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsDnPathEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsDnPathEN objDnPathEN = new clsDnPathEN();
try
{
objDnPathEN.DnPathId = objRow[conDnPath.DnPathId].ToString().Trim(); //DN路径Id
objDnPathEN.DnPathName = objRow[conDnPath.DnPathName].ToString().Trim(); //DN路径名
objDnPathEN.InDataNodeId = TransNullToInt(objRow[conDnPath.InDataNodeId].ToString().Trim()); //In数据结点Id
objDnPathEN.OutDataNodeId = TransNullToInt(objRow[conDnPath.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objDnPathEN.DnPathNodeLst = objRow[conDnPath.DnPathNodeLst].ToString().Trim(); //路径结点列表
objDnPathEN.DnPathNodeLstV2 = objRow[conDnPath.DnPathNodeLstV2] == DBNull.Value ? null : objRow[conDnPath.DnPathNodeLstV2].ToString().Trim(); //路径结点列表V2
objDnPathEN.AssociationMappingId = objRow[conDnPath.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objDnPathEN.IsHasErr = TransNullToBool(objRow[conDnPath.IsHasErr].ToString().Trim()); //是否有错
objDnPathEN.EdgeNum = objRow[conDnPath.EdgeNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDnPath.EdgeNum].ToString().Trim()); //边数
objDnPathEN.ErrMsg = objRow[conDnPath.ErrMsg] == DBNull.Value ? null : objRow[conDnPath.ErrMsg].ToString().Trim(); //错误信息
objDnPathEN.InUse = TransNullToBool(objRow[conDnPath.InUse].ToString().Trim()); //是否在用
objDnPathEN.IsExistPath = TransNullToBool(objRow[conDnPath.IsExistPath].ToString().Trim()); //是否存在路径
objDnPathEN.PrjId = objRow[conDnPath.PrjId].ToString().Trim(); //工程Id
objDnPathEN.UpdDate = objRow[conDnPath.UpdDate] == DBNull.Value ? null : objRow[conDnPath.UpdDate].ToString().Trim(); //修改日期
objDnPathEN.UpdUser = objRow[conDnPath.UpdUser] == DBNull.Value ? null : objRow[conDnPath.UpdUser].ToString().Trim(); //修改者
objDnPathEN.Memo = objRow[conDnPath.Memo] == DBNull.Value ? null : objRow[conDnPath.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsDnPathDA: GetObjByDataRow)", objException.Message));
}
objDnPathEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objDnPathEN;
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
objSQL = clsDnPathDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsDnPathEN._CurrTabName, conDnPath.DnPathId, 8, "");
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
objSQL = clsDnPathDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsDnPathEN._CurrTabName, conDnPath.DnPathId, 8, strPrefix);
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
 objSQL = clsDnPathDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select DnPathId from DnPath where " + strCondition;
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
 objSQL = clsDnPathDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select DnPathId from DnPath where " + strCondition;
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
 /// <param name = "strDnPathId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strDnPathId)
{
CheckPrimaryKey(strDnPathId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnPathDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("DnPath", "DnPathId = " + "'"+ strDnPathId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsDnPathDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnPathDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("DnPath", strCondition))
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
objSQL = clsDnPathDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("DnPath");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsDnPathEN objDnPathEN)
 {
 objDnPathEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDnPathEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDnPathEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnPathDA.GetSpecSQLObj();
strSQL = "Select * from DnPath where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "DnPath");
objRow = objDS.Tables["DnPath"].NewRow();
objRow[conDnPath.DnPathId] = objDnPathEN.DnPathId; //DN路径Id
objRow[conDnPath.DnPathName] = objDnPathEN.DnPathName; //DN路径名
objRow[conDnPath.InDataNodeId] = objDnPathEN.InDataNodeId; //In数据结点Id
objRow[conDnPath.OutDataNodeId] = objDnPathEN.OutDataNodeId; //Out数据结点Id
objRow[conDnPath.DnPathNodeLst] = objDnPathEN.DnPathNodeLst; //路径结点列表
 if (objDnPathEN.DnPathNodeLstV2 !=  "")
 {
objRow[conDnPath.DnPathNodeLstV2] = objDnPathEN.DnPathNodeLstV2; //路径结点列表V2
 }
objRow[conDnPath.AssociationMappingId] = objDnPathEN.AssociationMappingId; //关联关系映射Id
objRow[conDnPath.IsHasErr] = objDnPathEN.IsHasErr; //是否有错
objRow[conDnPath.EdgeNum] = objDnPathEN.EdgeNum; //边数
 if (objDnPathEN.ErrMsg !=  "")
 {
objRow[conDnPath.ErrMsg] = objDnPathEN.ErrMsg; //错误信息
 }
objRow[conDnPath.InUse] = objDnPathEN.InUse; //是否在用
objRow[conDnPath.IsExistPath] = objDnPathEN.IsExistPath; //是否存在路径
objRow[conDnPath.PrjId] = objDnPathEN.PrjId; //工程Id
 if (objDnPathEN.UpdDate !=  "")
 {
objRow[conDnPath.UpdDate] = objDnPathEN.UpdDate; //修改日期
 }
 if (objDnPathEN.UpdUser !=  "")
 {
objRow[conDnPath.UpdUser] = objDnPathEN.UpdUser; //修改者
 }
 if (objDnPathEN.Memo !=  "")
 {
objRow[conDnPath.Memo] = objDnPathEN.Memo; //说明
 }
objDS.Tables[clsDnPathEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsDnPathEN._CurrTabName);
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
 /// <param name = "objDnPathEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsDnPathEN objDnPathEN)
{
 objDnPathEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDnPathEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDnPathEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objDnPathEN.DnPathId !=  null)
 {
 arrFieldListForInsert.Add(conDnPath.DnPathId);
 var strDnPathId = objDnPathEN.DnPathId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDnPathId + "'");
 }
 
 if (objDnPathEN.DnPathName !=  null)
 {
 arrFieldListForInsert.Add(conDnPath.DnPathName);
 var strDnPathName = objDnPathEN.DnPathName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDnPathName + "'");
 }
 
 arrFieldListForInsert.Add(conDnPath.InDataNodeId);
 arrValueListForInsert.Add(objDnPathEN.InDataNodeId.ToString());
 
 arrFieldListForInsert.Add(conDnPath.OutDataNodeId);
 arrValueListForInsert.Add(objDnPathEN.OutDataNodeId.ToString());
 
 if (objDnPathEN.DnPathNodeLst !=  null)
 {
 arrFieldListForInsert.Add(conDnPath.DnPathNodeLst);
 var strDnPathNodeLst = objDnPathEN.DnPathNodeLst.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDnPathNodeLst + "'");
 }
 
 if (objDnPathEN.DnPathNodeLstV2 !=  null)
 {
 arrFieldListForInsert.Add(conDnPath.DnPathNodeLstV2);
 var strDnPathNodeLstV2 = objDnPathEN.DnPathNodeLstV2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDnPathNodeLstV2 + "'");
 }
 
 if (objDnPathEN.AssociationMappingId !=  null)
 {
 arrFieldListForInsert.Add(conDnPath.AssociationMappingId);
 var strAssociationMappingId = objDnPathEN.AssociationMappingId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAssociationMappingId + "'");
 }
 
 arrFieldListForInsert.Add(conDnPath.IsHasErr);
 arrValueListForInsert.Add("'" + (objDnPathEN.IsHasErr  ==  false ? "0" : "1") + "'");
 
 if (objDnPathEN.EdgeNum !=  null)
 {
 arrFieldListForInsert.Add(conDnPath.EdgeNum);
 arrValueListForInsert.Add(objDnPathEN.EdgeNum.ToString());
 }
 
 if (objDnPathEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conDnPath.ErrMsg);
 var strErrMsg = objDnPathEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 arrFieldListForInsert.Add(conDnPath.InUse);
 arrValueListForInsert.Add("'" + (objDnPathEN.InUse  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDnPath.IsExistPath);
 arrValueListForInsert.Add("'" + (objDnPathEN.IsExistPath  ==  false ? "0" : "1") + "'");
 
 if (objDnPathEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conDnPath.PrjId);
 var strPrjId = objDnPathEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objDnPathEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conDnPath.UpdDate);
 var strUpdDate = objDnPathEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objDnPathEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conDnPath.UpdUser);
 var strUpdUser = objDnPathEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objDnPathEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDnPath.Memo);
 var strMemo = objDnPathEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DnPath");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnPathDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objDnPathEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsDnPathEN objDnPathEN)
{
 objDnPathEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDnPathEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDnPathEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objDnPathEN.DnPathId !=  null)
 {
 arrFieldListForInsert.Add(conDnPath.DnPathId);
 var strDnPathId = objDnPathEN.DnPathId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDnPathId + "'");
 }
 
 if (objDnPathEN.DnPathName !=  null)
 {
 arrFieldListForInsert.Add(conDnPath.DnPathName);
 var strDnPathName = objDnPathEN.DnPathName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDnPathName + "'");
 }
 
 arrFieldListForInsert.Add(conDnPath.InDataNodeId);
 arrValueListForInsert.Add(objDnPathEN.InDataNodeId.ToString());
 
 arrFieldListForInsert.Add(conDnPath.OutDataNodeId);
 arrValueListForInsert.Add(objDnPathEN.OutDataNodeId.ToString());
 
 if (objDnPathEN.DnPathNodeLst !=  null)
 {
 arrFieldListForInsert.Add(conDnPath.DnPathNodeLst);
 var strDnPathNodeLst = objDnPathEN.DnPathNodeLst.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDnPathNodeLst + "'");
 }
 
 if (objDnPathEN.DnPathNodeLstV2 !=  null)
 {
 arrFieldListForInsert.Add(conDnPath.DnPathNodeLstV2);
 var strDnPathNodeLstV2 = objDnPathEN.DnPathNodeLstV2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDnPathNodeLstV2 + "'");
 }
 
 if (objDnPathEN.AssociationMappingId !=  null)
 {
 arrFieldListForInsert.Add(conDnPath.AssociationMappingId);
 var strAssociationMappingId = objDnPathEN.AssociationMappingId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAssociationMappingId + "'");
 }
 
 arrFieldListForInsert.Add(conDnPath.IsHasErr);
 arrValueListForInsert.Add("'" + (objDnPathEN.IsHasErr  ==  false ? "0" : "1") + "'");
 
 if (objDnPathEN.EdgeNum !=  null)
 {
 arrFieldListForInsert.Add(conDnPath.EdgeNum);
 arrValueListForInsert.Add(objDnPathEN.EdgeNum.ToString());
 }
 
 if (objDnPathEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conDnPath.ErrMsg);
 var strErrMsg = objDnPathEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 arrFieldListForInsert.Add(conDnPath.InUse);
 arrValueListForInsert.Add("'" + (objDnPathEN.InUse  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDnPath.IsExistPath);
 arrValueListForInsert.Add("'" + (objDnPathEN.IsExistPath  ==  false ? "0" : "1") + "'");
 
 if (objDnPathEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conDnPath.PrjId);
 var strPrjId = objDnPathEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objDnPathEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conDnPath.UpdDate);
 var strUpdDate = objDnPathEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objDnPathEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conDnPath.UpdUser);
 var strUpdUser = objDnPathEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objDnPathEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDnPath.Memo);
 var strMemo = objDnPathEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DnPath");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnPathDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objDnPathEN.DnPathId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objDnPathEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsDnPathEN objDnPathEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objDnPathEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDnPathEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDnPathEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objDnPathEN.DnPathId !=  null)
 {
 arrFieldListForInsert.Add(conDnPath.DnPathId);
 var strDnPathId = objDnPathEN.DnPathId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDnPathId + "'");
 }
 
 if (objDnPathEN.DnPathName !=  null)
 {
 arrFieldListForInsert.Add(conDnPath.DnPathName);
 var strDnPathName = objDnPathEN.DnPathName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDnPathName + "'");
 }
 
 arrFieldListForInsert.Add(conDnPath.InDataNodeId);
 arrValueListForInsert.Add(objDnPathEN.InDataNodeId.ToString());
 
 arrFieldListForInsert.Add(conDnPath.OutDataNodeId);
 arrValueListForInsert.Add(objDnPathEN.OutDataNodeId.ToString());
 
 if (objDnPathEN.DnPathNodeLst !=  null)
 {
 arrFieldListForInsert.Add(conDnPath.DnPathNodeLst);
 var strDnPathNodeLst = objDnPathEN.DnPathNodeLst.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDnPathNodeLst + "'");
 }
 
 if (objDnPathEN.DnPathNodeLstV2 !=  null)
 {
 arrFieldListForInsert.Add(conDnPath.DnPathNodeLstV2);
 var strDnPathNodeLstV2 = objDnPathEN.DnPathNodeLstV2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDnPathNodeLstV2 + "'");
 }
 
 if (objDnPathEN.AssociationMappingId !=  null)
 {
 arrFieldListForInsert.Add(conDnPath.AssociationMappingId);
 var strAssociationMappingId = objDnPathEN.AssociationMappingId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAssociationMappingId + "'");
 }
 
 arrFieldListForInsert.Add(conDnPath.IsHasErr);
 arrValueListForInsert.Add("'" + (objDnPathEN.IsHasErr  ==  false ? "0" : "1") + "'");
 
 if (objDnPathEN.EdgeNum !=  null)
 {
 arrFieldListForInsert.Add(conDnPath.EdgeNum);
 arrValueListForInsert.Add(objDnPathEN.EdgeNum.ToString());
 }
 
 if (objDnPathEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conDnPath.ErrMsg);
 var strErrMsg = objDnPathEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 arrFieldListForInsert.Add(conDnPath.InUse);
 arrValueListForInsert.Add("'" + (objDnPathEN.InUse  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDnPath.IsExistPath);
 arrValueListForInsert.Add("'" + (objDnPathEN.IsExistPath  ==  false ? "0" : "1") + "'");
 
 if (objDnPathEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conDnPath.PrjId);
 var strPrjId = objDnPathEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objDnPathEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conDnPath.UpdDate);
 var strUpdDate = objDnPathEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objDnPathEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conDnPath.UpdUser);
 var strUpdUser = objDnPathEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objDnPathEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDnPath.Memo);
 var strMemo = objDnPathEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DnPath");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnPathDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objDnPathEN.DnPathId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objDnPathEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsDnPathEN objDnPathEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objDnPathEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDnPathEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDnPathEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objDnPathEN.DnPathId !=  null)
 {
 arrFieldListForInsert.Add(conDnPath.DnPathId);
 var strDnPathId = objDnPathEN.DnPathId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDnPathId + "'");
 }
 
 if (objDnPathEN.DnPathName !=  null)
 {
 arrFieldListForInsert.Add(conDnPath.DnPathName);
 var strDnPathName = objDnPathEN.DnPathName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDnPathName + "'");
 }
 
 arrFieldListForInsert.Add(conDnPath.InDataNodeId);
 arrValueListForInsert.Add(objDnPathEN.InDataNodeId.ToString());
 
 arrFieldListForInsert.Add(conDnPath.OutDataNodeId);
 arrValueListForInsert.Add(objDnPathEN.OutDataNodeId.ToString());
 
 if (objDnPathEN.DnPathNodeLst !=  null)
 {
 arrFieldListForInsert.Add(conDnPath.DnPathNodeLst);
 var strDnPathNodeLst = objDnPathEN.DnPathNodeLst.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDnPathNodeLst + "'");
 }
 
 if (objDnPathEN.DnPathNodeLstV2 !=  null)
 {
 arrFieldListForInsert.Add(conDnPath.DnPathNodeLstV2);
 var strDnPathNodeLstV2 = objDnPathEN.DnPathNodeLstV2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDnPathNodeLstV2 + "'");
 }
 
 if (objDnPathEN.AssociationMappingId !=  null)
 {
 arrFieldListForInsert.Add(conDnPath.AssociationMappingId);
 var strAssociationMappingId = objDnPathEN.AssociationMappingId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAssociationMappingId + "'");
 }
 
 arrFieldListForInsert.Add(conDnPath.IsHasErr);
 arrValueListForInsert.Add("'" + (objDnPathEN.IsHasErr  ==  false ? "0" : "1") + "'");
 
 if (objDnPathEN.EdgeNum !=  null)
 {
 arrFieldListForInsert.Add(conDnPath.EdgeNum);
 arrValueListForInsert.Add(objDnPathEN.EdgeNum.ToString());
 }
 
 if (objDnPathEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conDnPath.ErrMsg);
 var strErrMsg = objDnPathEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 arrFieldListForInsert.Add(conDnPath.InUse);
 arrValueListForInsert.Add("'" + (objDnPathEN.InUse  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDnPath.IsExistPath);
 arrValueListForInsert.Add("'" + (objDnPathEN.IsExistPath  ==  false ? "0" : "1") + "'");
 
 if (objDnPathEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conDnPath.PrjId);
 var strPrjId = objDnPathEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objDnPathEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conDnPath.UpdDate);
 var strUpdDate = objDnPathEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objDnPathEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conDnPath.UpdUser);
 var strUpdUser = objDnPathEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objDnPathEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDnPath.Memo);
 var strMemo = objDnPathEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DnPath");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnPathDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewDnPaths(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnPathDA.GetSpecSQLObj();
strSQL = "Select * from DnPath where DnPathId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "DnPath");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strDnPathId = oRow[conDnPath.DnPathId].ToString().Trim();
if (IsExist(strDnPathId))
{
 string strResult = "关键字变量值为:" + string.Format("DnPathId = {0}", strDnPathId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsDnPathEN._CurrTabName ].NewRow();
objRow[conDnPath.DnPathId] = oRow[conDnPath.DnPathId].ToString().Trim(); //DN路径Id
objRow[conDnPath.DnPathName] = oRow[conDnPath.DnPathName].ToString().Trim(); //DN路径名
objRow[conDnPath.InDataNodeId] = oRow[conDnPath.InDataNodeId].ToString().Trim(); //In数据结点Id
objRow[conDnPath.OutDataNodeId] = oRow[conDnPath.OutDataNodeId].ToString().Trim(); //Out数据结点Id
objRow[conDnPath.DnPathNodeLst] = oRow[conDnPath.DnPathNodeLst].ToString().Trim(); //路径结点列表
objRow[conDnPath.DnPathNodeLstV2] = oRow[conDnPath.DnPathNodeLstV2].ToString().Trim(); //路径结点列表V2
objRow[conDnPath.AssociationMappingId] = oRow[conDnPath.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objRow[conDnPath.IsHasErr] = oRow[conDnPath.IsHasErr].ToString().Trim(); //是否有错
objRow[conDnPath.EdgeNum] = oRow[conDnPath.EdgeNum].ToString().Trim(); //边数
objRow[conDnPath.ErrMsg] = oRow[conDnPath.ErrMsg].ToString().Trim(); //错误信息
objRow[conDnPath.InUse] = oRow[conDnPath.InUse].ToString().Trim(); //是否在用
objRow[conDnPath.IsExistPath] = oRow[conDnPath.IsExistPath].ToString().Trim(); //是否存在路径
objRow[conDnPath.PrjId] = oRow[conDnPath.PrjId].ToString().Trim(); //工程Id
objRow[conDnPath.UpdDate] = oRow[conDnPath.UpdDate].ToString().Trim(); //修改日期
objRow[conDnPath.UpdUser] = oRow[conDnPath.UpdUser].ToString().Trim(); //修改者
objRow[conDnPath.Memo] = oRow[conDnPath.Memo].ToString().Trim(); //说明
 objDS.Tables[clsDnPathEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsDnPathEN._CurrTabName);
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
 /// <param name = "objDnPathEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsDnPathEN objDnPathEN)
{
 objDnPathEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDnPathEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDnPathEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnPathDA.GetSpecSQLObj();
strSQL = "Select * from DnPath where DnPathId = " + "'"+ objDnPathEN.DnPathId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsDnPathEN._CurrTabName);
if (objDS.Tables[clsDnPathEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:DnPathId = " + "'"+ objDnPathEN.DnPathId+"'");
return false;
}
objRow = objDS.Tables[clsDnPathEN._CurrTabName].Rows[0];
 if (objDnPathEN.IsUpdated(conDnPath.DnPathId))
 {
objRow[conDnPath.DnPathId] = objDnPathEN.DnPathId; //DN路径Id
 }
 if (objDnPathEN.IsUpdated(conDnPath.DnPathName))
 {
objRow[conDnPath.DnPathName] = objDnPathEN.DnPathName; //DN路径名
 }
 if (objDnPathEN.IsUpdated(conDnPath.InDataNodeId))
 {
objRow[conDnPath.InDataNodeId] = objDnPathEN.InDataNodeId; //In数据结点Id
 }
 if (objDnPathEN.IsUpdated(conDnPath.OutDataNodeId))
 {
objRow[conDnPath.OutDataNodeId] = objDnPathEN.OutDataNodeId; //Out数据结点Id
 }
 if (objDnPathEN.IsUpdated(conDnPath.DnPathNodeLst))
 {
objRow[conDnPath.DnPathNodeLst] = objDnPathEN.DnPathNodeLst; //路径结点列表
 }
 if (objDnPathEN.IsUpdated(conDnPath.DnPathNodeLstV2))
 {
objRow[conDnPath.DnPathNodeLstV2] = objDnPathEN.DnPathNodeLstV2; //路径结点列表V2
 }
 if (objDnPathEN.IsUpdated(conDnPath.AssociationMappingId))
 {
objRow[conDnPath.AssociationMappingId] = objDnPathEN.AssociationMappingId; //关联关系映射Id
 }
 if (objDnPathEN.IsUpdated(conDnPath.IsHasErr))
 {
objRow[conDnPath.IsHasErr] = objDnPathEN.IsHasErr; //是否有错
 }
 if (objDnPathEN.IsUpdated(conDnPath.EdgeNum))
 {
objRow[conDnPath.EdgeNum] = objDnPathEN.EdgeNum; //边数
 }
 if (objDnPathEN.IsUpdated(conDnPath.ErrMsg))
 {
objRow[conDnPath.ErrMsg] = objDnPathEN.ErrMsg; //错误信息
 }
 if (objDnPathEN.IsUpdated(conDnPath.InUse))
 {
objRow[conDnPath.InUse] = objDnPathEN.InUse; //是否在用
 }
 if (objDnPathEN.IsUpdated(conDnPath.IsExistPath))
 {
objRow[conDnPath.IsExistPath] = objDnPathEN.IsExistPath; //是否存在路径
 }
 if (objDnPathEN.IsUpdated(conDnPath.PrjId))
 {
objRow[conDnPath.PrjId] = objDnPathEN.PrjId; //工程Id
 }
 if (objDnPathEN.IsUpdated(conDnPath.UpdDate))
 {
objRow[conDnPath.UpdDate] = objDnPathEN.UpdDate; //修改日期
 }
 if (objDnPathEN.IsUpdated(conDnPath.UpdUser))
 {
objRow[conDnPath.UpdUser] = objDnPathEN.UpdUser; //修改者
 }
 if (objDnPathEN.IsUpdated(conDnPath.Memo))
 {
objRow[conDnPath.Memo] = objDnPathEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsDnPathEN._CurrTabName);
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
 /// <param name = "objDnPathEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsDnPathEN objDnPathEN)
{
 objDnPathEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDnPathEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDnPathEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnPathDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update DnPath Set ");
 
 if (objDnPathEN.IsUpdated(conDnPath.DnPathName))
 {
 if (objDnPathEN.DnPathName !=  null)
 {
 var strDnPathName = objDnPathEN.DnPathName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDnPathName, conDnPath.DnPathName); //DN路径名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnPath.DnPathName); //DN路径名
 }
 }
 
 if (objDnPathEN.IsUpdated(conDnPath.InDataNodeId))
 {
 sbSQL.AppendFormat("{1} = {0},",objDnPathEN.InDataNodeId, conDnPath.InDataNodeId); //In数据结点Id
 }
 
 if (objDnPathEN.IsUpdated(conDnPath.OutDataNodeId))
 {
 sbSQL.AppendFormat("{1} = {0},",objDnPathEN.OutDataNodeId, conDnPath.OutDataNodeId); //Out数据结点Id
 }
 
 if (objDnPathEN.IsUpdated(conDnPath.DnPathNodeLst))
 {
 if (objDnPathEN.DnPathNodeLst !=  null)
 {
 var strDnPathNodeLst = objDnPathEN.DnPathNodeLst.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDnPathNodeLst, conDnPath.DnPathNodeLst); //路径结点列表
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnPath.DnPathNodeLst); //路径结点列表
 }
 }
 
 if (objDnPathEN.IsUpdated(conDnPath.DnPathNodeLstV2))
 {
 if (objDnPathEN.DnPathNodeLstV2 !=  null)
 {
 var strDnPathNodeLstV2 = objDnPathEN.DnPathNodeLstV2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDnPathNodeLstV2, conDnPath.DnPathNodeLstV2); //路径结点列表V2
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnPath.DnPathNodeLstV2); //路径结点列表V2
 }
 }
 
 if (objDnPathEN.IsUpdated(conDnPath.AssociationMappingId))
 {
 if (objDnPathEN.AssociationMappingId !=  null)
 {
 var strAssociationMappingId = objDnPathEN.AssociationMappingId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAssociationMappingId, conDnPath.AssociationMappingId); //关联关系映射Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnPath.AssociationMappingId); //关联关系映射Id
 }
 }
 
 if (objDnPathEN.IsUpdated(conDnPath.IsHasErr))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDnPathEN.IsHasErr == true?"1":"0", conDnPath.IsHasErr); //是否有错
 }
 
 if (objDnPathEN.IsUpdated(conDnPath.EdgeNum))
 {
 if (objDnPathEN.EdgeNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDnPathEN.EdgeNum, conDnPath.EdgeNum); //边数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnPath.EdgeNum); //边数
 }
 }
 
 if (objDnPathEN.IsUpdated(conDnPath.ErrMsg))
 {
 if (objDnPathEN.ErrMsg !=  null)
 {
 var strErrMsg = objDnPathEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strErrMsg, conDnPath.ErrMsg); //错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnPath.ErrMsg); //错误信息
 }
 }
 
 if (objDnPathEN.IsUpdated(conDnPath.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDnPathEN.InUse == true?"1":"0", conDnPath.InUse); //是否在用
 }
 
 if (objDnPathEN.IsUpdated(conDnPath.IsExistPath))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDnPathEN.IsExistPath == true?"1":"0", conDnPath.IsExistPath); //是否存在路径
 }
 
 if (objDnPathEN.IsUpdated(conDnPath.PrjId))
 {
 if (objDnPathEN.PrjId !=  null)
 {
 var strPrjId = objDnPathEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conDnPath.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnPath.PrjId); //工程Id
 }
 }
 
 if (objDnPathEN.IsUpdated(conDnPath.UpdDate))
 {
 if (objDnPathEN.UpdDate !=  null)
 {
 var strUpdDate = objDnPathEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conDnPath.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnPath.UpdDate); //修改日期
 }
 }
 
 if (objDnPathEN.IsUpdated(conDnPath.UpdUser))
 {
 if (objDnPathEN.UpdUser !=  null)
 {
 var strUpdUser = objDnPathEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conDnPath.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnPath.UpdUser); //修改者
 }
 }
 
 if (objDnPathEN.IsUpdated(conDnPath.Memo))
 {
 if (objDnPathEN.Memo !=  null)
 {
 var strMemo = objDnPathEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conDnPath.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnPath.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where DnPathId = '{0}'", objDnPathEN.DnPathId); 
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
 /// <param name = "objDnPathEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsDnPathEN objDnPathEN, string strCondition)
{
 objDnPathEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDnPathEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDnPathEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnPathDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update DnPath Set ");
 
 if (objDnPathEN.IsUpdated(conDnPath.DnPathName))
 {
 if (objDnPathEN.DnPathName !=  null)
 {
 var strDnPathName = objDnPathEN.DnPathName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DnPathName = '{0}',", strDnPathName); //DN路径名
 }
 else
 {
 sbSQL.Append(" DnPathName = null,"); //DN路径名
 }
 }
 
 if (objDnPathEN.IsUpdated(conDnPath.InDataNodeId))
 {
 sbSQL.AppendFormat(" InDataNodeId = {0},", objDnPathEN.InDataNodeId); //In数据结点Id
 }
 
 if (objDnPathEN.IsUpdated(conDnPath.OutDataNodeId))
 {
 sbSQL.AppendFormat(" OutDataNodeId = {0},", objDnPathEN.OutDataNodeId); //Out数据结点Id
 }
 
 if (objDnPathEN.IsUpdated(conDnPath.DnPathNodeLst))
 {
 if (objDnPathEN.DnPathNodeLst !=  null)
 {
 var strDnPathNodeLst = objDnPathEN.DnPathNodeLst.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DnPathNodeLst = '{0}',", strDnPathNodeLst); //路径结点列表
 }
 else
 {
 sbSQL.Append(" DnPathNodeLst = null,"); //路径结点列表
 }
 }
 
 if (objDnPathEN.IsUpdated(conDnPath.DnPathNodeLstV2))
 {
 if (objDnPathEN.DnPathNodeLstV2 !=  null)
 {
 var strDnPathNodeLstV2 = objDnPathEN.DnPathNodeLstV2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DnPathNodeLstV2 = '{0}',", strDnPathNodeLstV2); //路径结点列表V2
 }
 else
 {
 sbSQL.Append(" DnPathNodeLstV2 = null,"); //路径结点列表V2
 }
 }
 
 if (objDnPathEN.IsUpdated(conDnPath.AssociationMappingId))
 {
 if (objDnPathEN.AssociationMappingId !=  null)
 {
 var strAssociationMappingId = objDnPathEN.AssociationMappingId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AssociationMappingId = '{0}',", strAssociationMappingId); //关联关系映射Id
 }
 else
 {
 sbSQL.Append(" AssociationMappingId = null,"); //关联关系映射Id
 }
 }
 
 if (objDnPathEN.IsUpdated(conDnPath.IsHasErr))
 {
 sbSQL.AppendFormat(" IsHasErr = '{0}',", objDnPathEN.IsHasErr == true?"1":"0"); //是否有错
 }
 
 if (objDnPathEN.IsUpdated(conDnPath.EdgeNum))
 {
 if (objDnPathEN.EdgeNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDnPathEN.EdgeNum, conDnPath.EdgeNum); //边数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnPath.EdgeNum); //边数
 }
 }
 
 if (objDnPathEN.IsUpdated(conDnPath.ErrMsg))
 {
 if (objDnPathEN.ErrMsg !=  null)
 {
 var strErrMsg = objDnPathEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ErrMsg = '{0}',", strErrMsg); //错误信息
 }
 else
 {
 sbSQL.Append(" ErrMsg = null,"); //错误信息
 }
 }
 
 if (objDnPathEN.IsUpdated(conDnPath.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objDnPathEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objDnPathEN.IsUpdated(conDnPath.IsExistPath))
 {
 sbSQL.AppendFormat(" IsExistPath = '{0}',", objDnPathEN.IsExistPath == true?"1":"0"); //是否存在路径
 }
 
 if (objDnPathEN.IsUpdated(conDnPath.PrjId))
 {
 if (objDnPathEN.PrjId !=  null)
 {
 var strPrjId = objDnPathEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objDnPathEN.IsUpdated(conDnPath.UpdDate))
 {
 if (objDnPathEN.UpdDate !=  null)
 {
 var strUpdDate = objDnPathEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objDnPathEN.IsUpdated(conDnPath.UpdUser))
 {
 if (objDnPathEN.UpdUser !=  null)
 {
 var strUpdUser = objDnPathEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objDnPathEN.IsUpdated(conDnPath.Memo))
 {
 if (objDnPathEN.Memo !=  null)
 {
 var strMemo = objDnPathEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objDnPathEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsDnPathEN objDnPathEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objDnPathEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDnPathEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDnPathEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnPathDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update DnPath Set ");
 
 if (objDnPathEN.IsUpdated(conDnPath.DnPathName))
 {
 if (objDnPathEN.DnPathName !=  null)
 {
 var strDnPathName = objDnPathEN.DnPathName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DnPathName = '{0}',", strDnPathName); //DN路径名
 }
 else
 {
 sbSQL.Append(" DnPathName = null,"); //DN路径名
 }
 }
 
 if (objDnPathEN.IsUpdated(conDnPath.InDataNodeId))
 {
 sbSQL.AppendFormat(" InDataNodeId = {0},", objDnPathEN.InDataNodeId); //In数据结点Id
 }
 
 if (objDnPathEN.IsUpdated(conDnPath.OutDataNodeId))
 {
 sbSQL.AppendFormat(" OutDataNodeId = {0},", objDnPathEN.OutDataNodeId); //Out数据结点Id
 }
 
 if (objDnPathEN.IsUpdated(conDnPath.DnPathNodeLst))
 {
 if (objDnPathEN.DnPathNodeLst !=  null)
 {
 var strDnPathNodeLst = objDnPathEN.DnPathNodeLst.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DnPathNodeLst = '{0}',", strDnPathNodeLst); //路径结点列表
 }
 else
 {
 sbSQL.Append(" DnPathNodeLst = null,"); //路径结点列表
 }
 }
 
 if (objDnPathEN.IsUpdated(conDnPath.DnPathNodeLstV2))
 {
 if (objDnPathEN.DnPathNodeLstV2 !=  null)
 {
 var strDnPathNodeLstV2 = objDnPathEN.DnPathNodeLstV2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DnPathNodeLstV2 = '{0}',", strDnPathNodeLstV2); //路径结点列表V2
 }
 else
 {
 sbSQL.Append(" DnPathNodeLstV2 = null,"); //路径结点列表V2
 }
 }
 
 if (objDnPathEN.IsUpdated(conDnPath.AssociationMappingId))
 {
 if (objDnPathEN.AssociationMappingId !=  null)
 {
 var strAssociationMappingId = objDnPathEN.AssociationMappingId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AssociationMappingId = '{0}',", strAssociationMappingId); //关联关系映射Id
 }
 else
 {
 sbSQL.Append(" AssociationMappingId = null,"); //关联关系映射Id
 }
 }
 
 if (objDnPathEN.IsUpdated(conDnPath.IsHasErr))
 {
 sbSQL.AppendFormat(" IsHasErr = '{0}',", objDnPathEN.IsHasErr == true?"1":"0"); //是否有错
 }
 
 if (objDnPathEN.IsUpdated(conDnPath.EdgeNum))
 {
 if (objDnPathEN.EdgeNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDnPathEN.EdgeNum, conDnPath.EdgeNum); //边数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnPath.EdgeNum); //边数
 }
 }
 
 if (objDnPathEN.IsUpdated(conDnPath.ErrMsg))
 {
 if (objDnPathEN.ErrMsg !=  null)
 {
 var strErrMsg = objDnPathEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ErrMsg = '{0}',", strErrMsg); //错误信息
 }
 else
 {
 sbSQL.Append(" ErrMsg = null,"); //错误信息
 }
 }
 
 if (objDnPathEN.IsUpdated(conDnPath.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objDnPathEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objDnPathEN.IsUpdated(conDnPath.IsExistPath))
 {
 sbSQL.AppendFormat(" IsExistPath = '{0}',", objDnPathEN.IsExistPath == true?"1":"0"); //是否存在路径
 }
 
 if (objDnPathEN.IsUpdated(conDnPath.PrjId))
 {
 if (objDnPathEN.PrjId !=  null)
 {
 var strPrjId = objDnPathEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objDnPathEN.IsUpdated(conDnPath.UpdDate))
 {
 if (objDnPathEN.UpdDate !=  null)
 {
 var strUpdDate = objDnPathEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objDnPathEN.IsUpdated(conDnPath.UpdUser))
 {
 if (objDnPathEN.UpdUser !=  null)
 {
 var strUpdUser = objDnPathEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objDnPathEN.IsUpdated(conDnPath.Memo))
 {
 if (objDnPathEN.Memo !=  null)
 {
 var strMemo = objDnPathEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objDnPathEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsDnPathEN objDnPathEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objDnPathEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDnPathEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDnPathEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnPathDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update DnPath Set ");
 
 if (objDnPathEN.IsUpdated(conDnPath.DnPathName))
 {
 if (objDnPathEN.DnPathName !=  null)
 {
 var strDnPathName = objDnPathEN.DnPathName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDnPathName, conDnPath.DnPathName); //DN路径名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnPath.DnPathName); //DN路径名
 }
 }
 
 if (objDnPathEN.IsUpdated(conDnPath.InDataNodeId))
 {
 sbSQL.AppendFormat("{1} = {0},",objDnPathEN.InDataNodeId, conDnPath.InDataNodeId); //In数据结点Id
 }
 
 if (objDnPathEN.IsUpdated(conDnPath.OutDataNodeId))
 {
 sbSQL.AppendFormat("{1} = {0},",objDnPathEN.OutDataNodeId, conDnPath.OutDataNodeId); //Out数据结点Id
 }
 
 if (objDnPathEN.IsUpdated(conDnPath.DnPathNodeLst))
 {
 if (objDnPathEN.DnPathNodeLst !=  null)
 {
 var strDnPathNodeLst = objDnPathEN.DnPathNodeLst.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDnPathNodeLst, conDnPath.DnPathNodeLst); //路径结点列表
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnPath.DnPathNodeLst); //路径结点列表
 }
 }
 
 if (objDnPathEN.IsUpdated(conDnPath.DnPathNodeLstV2))
 {
 if (objDnPathEN.DnPathNodeLstV2 !=  null)
 {
 var strDnPathNodeLstV2 = objDnPathEN.DnPathNodeLstV2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDnPathNodeLstV2, conDnPath.DnPathNodeLstV2); //路径结点列表V2
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnPath.DnPathNodeLstV2); //路径结点列表V2
 }
 }
 
 if (objDnPathEN.IsUpdated(conDnPath.AssociationMappingId))
 {
 if (objDnPathEN.AssociationMappingId !=  null)
 {
 var strAssociationMappingId = objDnPathEN.AssociationMappingId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAssociationMappingId, conDnPath.AssociationMappingId); //关联关系映射Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnPath.AssociationMappingId); //关联关系映射Id
 }
 }
 
 if (objDnPathEN.IsUpdated(conDnPath.IsHasErr))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDnPathEN.IsHasErr == true?"1":"0", conDnPath.IsHasErr); //是否有错
 }
 
 if (objDnPathEN.IsUpdated(conDnPath.EdgeNum))
 {
 if (objDnPathEN.EdgeNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDnPathEN.EdgeNum, conDnPath.EdgeNum); //边数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnPath.EdgeNum); //边数
 }
 }
 
 if (objDnPathEN.IsUpdated(conDnPath.ErrMsg))
 {
 if (objDnPathEN.ErrMsg !=  null)
 {
 var strErrMsg = objDnPathEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strErrMsg, conDnPath.ErrMsg); //错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnPath.ErrMsg); //错误信息
 }
 }
 
 if (objDnPathEN.IsUpdated(conDnPath.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDnPathEN.InUse == true?"1":"0", conDnPath.InUse); //是否在用
 }
 
 if (objDnPathEN.IsUpdated(conDnPath.IsExistPath))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDnPathEN.IsExistPath == true?"1":"0", conDnPath.IsExistPath); //是否存在路径
 }
 
 if (objDnPathEN.IsUpdated(conDnPath.PrjId))
 {
 if (objDnPathEN.PrjId !=  null)
 {
 var strPrjId = objDnPathEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conDnPath.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnPath.PrjId); //工程Id
 }
 }
 
 if (objDnPathEN.IsUpdated(conDnPath.UpdDate))
 {
 if (objDnPathEN.UpdDate !=  null)
 {
 var strUpdDate = objDnPathEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conDnPath.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnPath.UpdDate); //修改日期
 }
 }
 
 if (objDnPathEN.IsUpdated(conDnPath.UpdUser))
 {
 if (objDnPathEN.UpdUser !=  null)
 {
 var strUpdUser = objDnPathEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conDnPath.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnPath.UpdUser); //修改者
 }
 }
 
 if (objDnPathEN.IsUpdated(conDnPath.Memo))
 {
 if (objDnPathEN.Memo !=  null)
 {
 var strMemo = objDnPathEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conDnPath.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnPath.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where DnPathId = '{0}'", objDnPathEN.DnPathId); 
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
 /// <param name = "strDnPathId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strDnPathId) 
{
CheckPrimaryKey(strDnPathId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnPathDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strDnPathId,
};
 objSQL.ExecSP("DnPath_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strDnPathId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strDnPathId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strDnPathId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnPathDA.GetSpecSQLObj();
//删除DnPath本表中与当前对象有关的记录
strSQL = strSQL + "Delete from DnPath where DnPathId = " + "'"+ strDnPathId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelDnPath(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnPathDA.GetSpecSQLObj();
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
//删除DnPath本表中与当前对象有关的记录
strSQL = strSQL + "Delete from DnPath where DnPathId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strDnPathId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strDnPathId) 
{
CheckPrimaryKey(strDnPathId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnPathDA.GetSpecSQLObj();
//删除DnPath本表中与当前对象有关的记录
strSQL = strSQL + "Delete from DnPath where DnPathId = " + "'"+ strDnPathId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelDnPath(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsDnPathDA: DelDnPath)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnPathDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from DnPath where " + strCondition ;
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
public bool DelDnPathWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsDnPathDA: DelDnPathWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnPathDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from DnPath where " + strCondition ;
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
 /// <param name = "objDnPathENS">源对象</param>
 /// <param name = "objDnPathENT">目标对象</param>
public void CopyTo(clsDnPathEN objDnPathENS, clsDnPathEN objDnPathENT)
{
objDnPathENT.DnPathId = objDnPathENS.DnPathId; //DN路径Id
objDnPathENT.DnPathName = objDnPathENS.DnPathName; //DN路径名
objDnPathENT.InDataNodeId = objDnPathENS.InDataNodeId; //In数据结点Id
objDnPathENT.OutDataNodeId = objDnPathENS.OutDataNodeId; //Out数据结点Id
objDnPathENT.DnPathNodeLst = objDnPathENS.DnPathNodeLst; //路径结点列表
objDnPathENT.DnPathNodeLstV2 = objDnPathENS.DnPathNodeLstV2; //路径结点列表V2
objDnPathENT.AssociationMappingId = objDnPathENS.AssociationMappingId; //关联关系映射Id
objDnPathENT.IsHasErr = objDnPathENS.IsHasErr; //是否有错
objDnPathENT.EdgeNum = objDnPathENS.EdgeNum; //边数
objDnPathENT.ErrMsg = objDnPathENS.ErrMsg; //错误信息
objDnPathENT.InUse = objDnPathENS.InUse; //是否在用
objDnPathENT.IsExistPath = objDnPathENS.IsExistPath; //是否存在路径
objDnPathENT.PrjId = objDnPathENS.PrjId; //工程Id
objDnPathENT.UpdDate = objDnPathENS.UpdDate; //修改日期
objDnPathENT.UpdUser = objDnPathENS.UpdUser; //修改者
objDnPathENT.Memo = objDnPathENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsDnPathEN objDnPathEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objDnPathEN.DnPathName, conDnPath.DnPathName);
clsCheckSql.CheckFieldNotNull(objDnPathEN.InDataNodeId, conDnPath.InDataNodeId);
clsCheckSql.CheckFieldNotNull(objDnPathEN.OutDataNodeId, conDnPath.OutDataNodeId);
clsCheckSql.CheckFieldNotNull(objDnPathEN.DnPathNodeLst, conDnPath.DnPathNodeLst);
clsCheckSql.CheckFieldNotNull(objDnPathEN.AssociationMappingId, conDnPath.AssociationMappingId);
clsCheckSql.CheckFieldNotNull(objDnPathEN.PrjId, conDnPath.PrjId);
//检查字段长度
clsCheckSql.CheckFieldLen(objDnPathEN.DnPathId, 8, conDnPath.DnPathId);
clsCheckSql.CheckFieldLen(objDnPathEN.DnPathName, 100, conDnPath.DnPathName);
clsCheckSql.CheckFieldLen(objDnPathEN.DnPathNodeLst, 500, conDnPath.DnPathNodeLst);
clsCheckSql.CheckFieldLen(objDnPathEN.DnPathNodeLstV2, 500, conDnPath.DnPathNodeLstV2);
clsCheckSql.CheckFieldLen(objDnPathEN.AssociationMappingId, 2, conDnPath.AssociationMappingId);
clsCheckSql.CheckFieldLen(objDnPathEN.ErrMsg, 2000, conDnPath.ErrMsg);
clsCheckSql.CheckFieldLen(objDnPathEN.PrjId, 4, conDnPath.PrjId);
clsCheckSql.CheckFieldLen(objDnPathEN.UpdDate, 20, conDnPath.UpdDate);
clsCheckSql.CheckFieldLen(objDnPathEN.UpdUser, 20, conDnPath.UpdUser);
clsCheckSql.CheckFieldLen(objDnPathEN.Memo, 1000, conDnPath.Memo);
//检查字段外键固定长度
 objDnPathEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsDnPathEN objDnPathEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objDnPathEN.DnPathName, 100, conDnPath.DnPathName);
clsCheckSql.CheckFieldLen(objDnPathEN.DnPathNodeLst, 500, conDnPath.DnPathNodeLst);
clsCheckSql.CheckFieldLen(objDnPathEN.DnPathNodeLstV2, 500, conDnPath.DnPathNodeLstV2);
clsCheckSql.CheckFieldLen(objDnPathEN.AssociationMappingId, 2, conDnPath.AssociationMappingId);
clsCheckSql.CheckFieldLen(objDnPathEN.ErrMsg, 2000, conDnPath.ErrMsg);
clsCheckSql.CheckFieldLen(objDnPathEN.PrjId, 4, conDnPath.PrjId);
clsCheckSql.CheckFieldLen(objDnPathEN.UpdDate, 20, conDnPath.UpdDate);
clsCheckSql.CheckFieldLen(objDnPathEN.UpdUser, 20, conDnPath.UpdUser);
clsCheckSql.CheckFieldLen(objDnPathEN.Memo, 1000, conDnPath.Memo);
//检查外键字段长度
 objDnPathEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsDnPathEN objDnPathEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objDnPathEN.DnPathId, 8, conDnPath.DnPathId);
clsCheckSql.CheckFieldLen(objDnPathEN.DnPathName, 100, conDnPath.DnPathName);
clsCheckSql.CheckFieldLen(objDnPathEN.DnPathNodeLst, 500, conDnPath.DnPathNodeLst);
clsCheckSql.CheckFieldLen(objDnPathEN.DnPathNodeLstV2, 500, conDnPath.DnPathNodeLstV2);
clsCheckSql.CheckFieldLen(objDnPathEN.AssociationMappingId, 2, conDnPath.AssociationMappingId);
clsCheckSql.CheckFieldLen(objDnPathEN.ErrMsg, 2000, conDnPath.ErrMsg);
clsCheckSql.CheckFieldLen(objDnPathEN.PrjId, 4, conDnPath.PrjId);
clsCheckSql.CheckFieldLen(objDnPathEN.UpdDate, 20, conDnPath.UpdDate);
clsCheckSql.CheckFieldLen(objDnPathEN.UpdUser, 20, conDnPath.UpdUser);
clsCheckSql.CheckFieldLen(objDnPathEN.Memo, 1000, conDnPath.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objDnPathEN.DnPathId, conDnPath.DnPathId);
clsCheckSql.CheckSqlInjection4Field(objDnPathEN.DnPathName, conDnPath.DnPathName);
clsCheckSql.CheckSqlInjection4Field(objDnPathEN.DnPathNodeLst, conDnPath.DnPathNodeLst);
clsCheckSql.CheckSqlInjection4Field(objDnPathEN.DnPathNodeLstV2, conDnPath.DnPathNodeLstV2);
clsCheckSql.CheckSqlInjection4Field(objDnPathEN.AssociationMappingId, conDnPath.AssociationMappingId);
clsCheckSql.CheckSqlInjection4Field(objDnPathEN.ErrMsg, conDnPath.ErrMsg);
clsCheckSql.CheckSqlInjection4Field(objDnPathEN.PrjId, conDnPath.PrjId);
clsCheckSql.CheckSqlInjection4Field(objDnPathEN.UpdDate, conDnPath.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objDnPathEN.UpdUser, conDnPath.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objDnPathEN.Memo, conDnPath.Memo);
//检查外键字段长度
 objDnPathEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetDnPathId()
{
//获取某学院所有专业信息
string strSQL = "select DnPathId, DnPathName from DnPath ";
 clsSpecSQLforSql mySql = clsDnPathDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--DnPath(数据结点路径),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objDnPathEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsDnPathEN objDnPathEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and DnPathName = '{0}'", objDnPathEN.DnPathName);
 sbCondition.AppendFormat(" and DnPathNodeLst = '{0}'", objDnPathEN.DnPathNodeLst);
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
 objSQL = clsDnPathDA.GetSpecSQLObj();
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
 objSQL = clsDnPathDA.GetSpecSQLObj();
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
 objSQL = clsDnPathDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsDnPathEN._CurrTabName);
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
 objSQL = clsDnPathDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsDnPathEN._CurrTabName, strCondition);
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
 objSQL = clsDnPathDA.GetSpecSQLObj();
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
 objSQL = clsDnPathDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}