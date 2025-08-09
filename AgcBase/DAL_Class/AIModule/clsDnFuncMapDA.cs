
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDnFuncMapDA
 表名:DnFuncMap(00050549)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:00:54
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
 /// 结点函数映射(DnFuncMap)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsDnFuncMapDA : clsCommBase4DA
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
 return clsDnFuncMapEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsDnFuncMapEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsDnFuncMapEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsDnFuncMapEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsDnFuncMapEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strDnFuncMapId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strDnFuncMapId)
{
strDnFuncMapId = strDnFuncMapId.Replace("'", "''");
if (strDnFuncMapId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:DnFuncMap中,检查关键字,长度不正确!(clsDnFuncMapDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strDnFuncMapId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:DnFuncMap中,关键字不能为空 或 null!(clsDnFuncMapDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strDnFuncMapId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsDnFuncMapDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsDnFuncMapDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapDA.GetSpecSQLObj();
strSQL = "Select * from DnFuncMap where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_DnFuncMap(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsDnFuncMapDA: GetDataTable_DnFuncMap)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapDA.GetSpecSQLObj();
strSQL = "Select * from DnFuncMap where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsDnFuncMapDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsDnFuncMapDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapDA.GetSpecSQLObj();
strSQL = "Select * from DnFuncMap where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsDnFuncMapDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsDnFuncMapDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from DnFuncMap where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from DnFuncMap where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsDnFuncMapDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from DnFuncMap where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsDnFuncMapDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} DnFuncMap.* " + 
$"from DnFuncMap " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and DnFuncMap.DnFuncMapId not in " + 
$"(Select top {intTop_In} DnFuncMap.DnFuncMapId from DnFuncMap " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from DnFuncMap where {1} and DnFuncMapId not in (Select top {2} DnFuncMapId from DnFuncMap where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from DnFuncMap where {1} and DnFuncMapId not in (Select top {3} DnFuncMapId from DnFuncMap where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsDnFuncMapDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} DnFuncMap.* " + 
$"from DnFuncMap " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and DnFuncMap.DnFuncMapId not in " + 
$"(Select top {intTop_In} DnFuncMap.DnFuncMapId from DnFuncMap " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from DnFuncMap where {1} and DnFuncMapId not in (Select top {2} DnFuncMapId from DnFuncMap where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from DnFuncMap where {1} and DnFuncMapId not in (Select top {3} DnFuncMapId from DnFuncMap where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsDnFuncMapEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsDnFuncMapDA:GetObjLst)", objException.Message));
}
List<clsDnFuncMapEN> arrObjLst = new List<clsDnFuncMapEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapDA.GetSpecSQLObj();
strSQL = "Select * from DnFuncMap where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDnFuncMapEN objDnFuncMapEN = new clsDnFuncMapEN();
try
{
objDnFuncMapEN.DnFuncMapId = objRow[conDnFuncMap.DnFuncMapId].ToString().Trim(); //函数映射Id
objDnFuncMapEN.InDataNodeId = TransNullToInt(objRow[conDnFuncMap.InDataNodeId].ToString().Trim()); //In数据结点Id
objDnFuncMapEN.OutDataNodeId = TransNullToInt(objRow[conDnFuncMap.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objDnFuncMapEN.AssociationMappingId = objRow[conDnFuncMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objDnFuncMapEN.FuncMapModeId = objRow[conDnFuncMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objDnFuncMapEN.TabId = objRow[conDnFuncMap.TabId] == DBNull.Value ? null : objRow[conDnFuncMap.TabId].ToString().Trim(); //表ID
objDnFuncMapEN.DnFunctionId = objRow[conDnFuncMap.DnFunctionId] == DBNull.Value ? null : objRow[conDnFuncMap.DnFunctionId].ToString().Trim(); //DN函数Id
objDnFuncMapEN.ErrMsg = objRow[conDnFuncMap.ErrMsg] == DBNull.Value ? null : objRow[conDnFuncMap.ErrMsg].ToString().Trim(); //错误信息
objDnFuncMapEN.PrjId = objRow[conDnFuncMap.PrjId].ToString().Trim(); //工程Id
objDnFuncMapEN.UsedTimes = objRow[conDnFuncMap.UsedTimes] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDnFuncMap.UsedTimes].ToString().Trim()); //使用次数
objDnFuncMapEN.UpdDate = objRow[conDnFuncMap.UpdDate] == DBNull.Value ? null : objRow[conDnFuncMap.UpdDate].ToString().Trim(); //修改日期
objDnFuncMapEN.UpdUser = objRow[conDnFuncMap.UpdUser] == DBNull.Value ? null : objRow[conDnFuncMap.UpdUser].ToString().Trim(); //修改者
objDnFuncMapEN.Memo = objRow[conDnFuncMap.Memo] == DBNull.Value ? null : objRow[conDnFuncMap.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsDnFuncMapDA: GetObjLst)", objException.Message));
}
objDnFuncMapEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objDnFuncMapEN);
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
public List<clsDnFuncMapEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsDnFuncMapDA:GetObjLstByTabName)", objException.Message));
}
List<clsDnFuncMapEN> arrObjLst = new List<clsDnFuncMapEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDnFuncMapEN objDnFuncMapEN = new clsDnFuncMapEN();
try
{
objDnFuncMapEN.DnFuncMapId = objRow[conDnFuncMap.DnFuncMapId].ToString().Trim(); //函数映射Id
objDnFuncMapEN.InDataNodeId = TransNullToInt(objRow[conDnFuncMap.InDataNodeId].ToString().Trim()); //In数据结点Id
objDnFuncMapEN.OutDataNodeId = TransNullToInt(objRow[conDnFuncMap.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objDnFuncMapEN.AssociationMappingId = objRow[conDnFuncMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objDnFuncMapEN.FuncMapModeId = objRow[conDnFuncMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objDnFuncMapEN.TabId = objRow[conDnFuncMap.TabId] == DBNull.Value ? null : objRow[conDnFuncMap.TabId].ToString().Trim(); //表ID
objDnFuncMapEN.DnFunctionId = objRow[conDnFuncMap.DnFunctionId] == DBNull.Value ? null : objRow[conDnFuncMap.DnFunctionId].ToString().Trim(); //DN函数Id
objDnFuncMapEN.ErrMsg = objRow[conDnFuncMap.ErrMsg] == DBNull.Value ? null : objRow[conDnFuncMap.ErrMsg].ToString().Trim(); //错误信息
objDnFuncMapEN.PrjId = objRow[conDnFuncMap.PrjId].ToString().Trim(); //工程Id
objDnFuncMapEN.UsedTimes = objRow[conDnFuncMap.UsedTimes] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDnFuncMap.UsedTimes].ToString().Trim()); //使用次数
objDnFuncMapEN.UpdDate = objRow[conDnFuncMap.UpdDate] == DBNull.Value ? null : objRow[conDnFuncMap.UpdDate].ToString().Trim(); //修改日期
objDnFuncMapEN.UpdUser = objRow[conDnFuncMap.UpdUser] == DBNull.Value ? null : objRow[conDnFuncMap.UpdUser].ToString().Trim(); //修改者
objDnFuncMapEN.Memo = objRow[conDnFuncMap.Memo] == DBNull.Value ? null : objRow[conDnFuncMap.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsDnFuncMapDA: GetObjLst)", objException.Message));
}
objDnFuncMapEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objDnFuncMapEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objDnFuncMapEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetDnFuncMap(ref clsDnFuncMapEN objDnFuncMapEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapDA.GetSpecSQLObj();
strSQL = "Select * from DnFuncMap where DnFuncMapId = " + "'"+ objDnFuncMapEN.DnFuncMapId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objDnFuncMapEN.DnFuncMapId = objDT.Rows[0][conDnFuncMap.DnFuncMapId].ToString().Trim(); //函数映射Id(字段类型:char,字段长度:8,是否可空:False)
 objDnFuncMapEN.InDataNodeId = TransNullToInt(objDT.Rows[0][conDnFuncMap.InDataNodeId].ToString().Trim()); //In数据结点Id(字段类型:bigint,字段长度:8,是否可空:True)
 objDnFuncMapEN.OutDataNodeId = TransNullToInt(objDT.Rows[0][conDnFuncMap.OutDataNodeId].ToString().Trim()); //Out数据结点Id(字段类型:bigint,字段长度:8,是否可空:True)
 objDnFuncMapEN.AssociationMappingId = objDT.Rows[0][conDnFuncMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id(字段类型:char,字段长度:2,是否可空:True)
 objDnFuncMapEN.FuncMapModeId = objDT.Rows[0][conDnFuncMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id(字段类型:char,字段长度:2,是否可空:True)
 objDnFuncMapEN.TabId = objDT.Rows[0][conDnFuncMap.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objDnFuncMapEN.DnFunctionId = objDT.Rows[0][conDnFuncMap.DnFunctionId].ToString().Trim(); //DN函数Id(字段类型:char,字段长度:8,是否可空:True)
 objDnFuncMapEN.ErrMsg = objDT.Rows[0][conDnFuncMap.ErrMsg].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:2000,是否可空:True)
 objDnFuncMapEN.PrjId = objDT.Rows[0][conDnFuncMap.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objDnFuncMapEN.UsedTimes = TransNullToInt(objDT.Rows[0][conDnFuncMap.UsedTimes].ToString().Trim()); //使用次数(字段类型:int,字段长度:4,是否可空:True)
 objDnFuncMapEN.UpdDate = objDT.Rows[0][conDnFuncMap.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objDnFuncMapEN.UpdUser = objDT.Rows[0][conDnFuncMap.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objDnFuncMapEN.Memo = objDT.Rows[0][conDnFuncMap.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsDnFuncMapDA: GetDnFuncMap)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strDnFuncMapId">表关键字</param>
 /// <returns>表对象</returns>
public clsDnFuncMapEN GetObjByDnFuncMapId(string strDnFuncMapId)
{
CheckPrimaryKey(strDnFuncMapId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapDA.GetSpecSQLObj();
strSQL = "Select * from DnFuncMap where DnFuncMapId = " + "'"+ strDnFuncMapId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsDnFuncMapEN objDnFuncMapEN = new clsDnFuncMapEN();
try
{
 objDnFuncMapEN.DnFuncMapId = objRow[conDnFuncMap.DnFuncMapId].ToString().Trim(); //函数映射Id(字段类型:char,字段长度:8,是否可空:False)
 objDnFuncMapEN.InDataNodeId = Int32.Parse(objRow[conDnFuncMap.InDataNodeId].ToString().Trim()); //In数据结点Id(字段类型:bigint,字段长度:8,是否可空:True)
 objDnFuncMapEN.OutDataNodeId = Int32.Parse(objRow[conDnFuncMap.OutDataNodeId].ToString().Trim()); //Out数据结点Id(字段类型:bigint,字段长度:8,是否可空:True)
 objDnFuncMapEN.AssociationMappingId = objRow[conDnFuncMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id(字段类型:char,字段长度:2,是否可空:True)
 objDnFuncMapEN.FuncMapModeId = objRow[conDnFuncMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id(字段类型:char,字段长度:2,是否可空:True)
 objDnFuncMapEN.TabId = objRow[conDnFuncMap.TabId] == DBNull.Value ? null : objRow[conDnFuncMap.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objDnFuncMapEN.DnFunctionId = objRow[conDnFuncMap.DnFunctionId] == DBNull.Value ? null : objRow[conDnFuncMap.DnFunctionId].ToString().Trim(); //DN函数Id(字段类型:char,字段长度:8,是否可空:True)
 objDnFuncMapEN.ErrMsg = objRow[conDnFuncMap.ErrMsg] == DBNull.Value ? null : objRow[conDnFuncMap.ErrMsg].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:2000,是否可空:True)
 objDnFuncMapEN.PrjId = objRow[conDnFuncMap.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objDnFuncMapEN.UsedTimes = objRow[conDnFuncMap.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDnFuncMap.UsedTimes].ToString().Trim()); //使用次数(字段类型:int,字段长度:4,是否可空:True)
 objDnFuncMapEN.UpdDate = objRow[conDnFuncMap.UpdDate] == DBNull.Value ? null : objRow[conDnFuncMap.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objDnFuncMapEN.UpdUser = objRow[conDnFuncMap.UpdUser] == DBNull.Value ? null : objRow[conDnFuncMap.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objDnFuncMapEN.Memo = objRow[conDnFuncMap.Memo] == DBNull.Value ? null : objRow[conDnFuncMap.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsDnFuncMapDA: GetObjByDnFuncMapId)", objException.Message));
}
return objDnFuncMapEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsDnFuncMapEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsDnFuncMapDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapDA.GetSpecSQLObj();
strSQL = "Select * from DnFuncMap where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsDnFuncMapEN objDnFuncMapEN = new clsDnFuncMapEN()
{
DnFuncMapId = objRow[conDnFuncMap.DnFuncMapId].ToString().Trim(), //函数映射Id
InDataNodeId = TransNullToInt(objRow[conDnFuncMap.InDataNodeId].ToString().Trim()), //In数据结点Id
OutDataNodeId = TransNullToInt(objRow[conDnFuncMap.OutDataNodeId].ToString().Trim()), //Out数据结点Id
AssociationMappingId = objRow[conDnFuncMap.AssociationMappingId].ToString().Trim(), //关联关系映射Id
FuncMapModeId = objRow[conDnFuncMap.FuncMapModeId].ToString().Trim(), //函数映射模式Id
TabId = objRow[conDnFuncMap.TabId] == DBNull.Value ? null : objRow[conDnFuncMap.TabId].ToString().Trim(), //表ID
DnFunctionId = objRow[conDnFuncMap.DnFunctionId] == DBNull.Value ? null : objRow[conDnFuncMap.DnFunctionId].ToString().Trim(), //DN函数Id
ErrMsg = objRow[conDnFuncMap.ErrMsg] == DBNull.Value ? null : objRow[conDnFuncMap.ErrMsg].ToString().Trim(), //错误信息
PrjId = objRow[conDnFuncMap.PrjId].ToString().Trim(), //工程Id
UsedTimes = objRow[conDnFuncMap.UsedTimes] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDnFuncMap.UsedTimes].ToString().Trim()), //使用次数
UpdDate = objRow[conDnFuncMap.UpdDate] == DBNull.Value ? null : objRow[conDnFuncMap.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conDnFuncMap.UpdUser] == DBNull.Value ? null : objRow[conDnFuncMap.UpdUser].ToString().Trim(), //修改者
Memo = objRow[conDnFuncMap.Memo] == DBNull.Value ? null : objRow[conDnFuncMap.Memo].ToString().Trim() //说明
};
objDnFuncMapEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objDnFuncMapEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsDnFuncMapDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsDnFuncMapEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsDnFuncMapEN objDnFuncMapEN = new clsDnFuncMapEN();
try
{
objDnFuncMapEN.DnFuncMapId = objRow[conDnFuncMap.DnFuncMapId].ToString().Trim(); //函数映射Id
objDnFuncMapEN.InDataNodeId = TransNullToInt(objRow[conDnFuncMap.InDataNodeId].ToString().Trim()); //In数据结点Id
objDnFuncMapEN.OutDataNodeId = TransNullToInt(objRow[conDnFuncMap.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objDnFuncMapEN.AssociationMappingId = objRow[conDnFuncMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objDnFuncMapEN.FuncMapModeId = objRow[conDnFuncMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objDnFuncMapEN.TabId = objRow[conDnFuncMap.TabId] == DBNull.Value ? null : objRow[conDnFuncMap.TabId].ToString().Trim(); //表ID
objDnFuncMapEN.DnFunctionId = objRow[conDnFuncMap.DnFunctionId] == DBNull.Value ? null : objRow[conDnFuncMap.DnFunctionId].ToString().Trim(); //DN函数Id
objDnFuncMapEN.ErrMsg = objRow[conDnFuncMap.ErrMsg] == DBNull.Value ? null : objRow[conDnFuncMap.ErrMsg].ToString().Trim(); //错误信息
objDnFuncMapEN.PrjId = objRow[conDnFuncMap.PrjId].ToString().Trim(); //工程Id
objDnFuncMapEN.UsedTimes = objRow[conDnFuncMap.UsedTimes] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDnFuncMap.UsedTimes].ToString().Trim()); //使用次数
objDnFuncMapEN.UpdDate = objRow[conDnFuncMap.UpdDate] == DBNull.Value ? null : objRow[conDnFuncMap.UpdDate].ToString().Trim(); //修改日期
objDnFuncMapEN.UpdUser = objRow[conDnFuncMap.UpdUser] == DBNull.Value ? null : objRow[conDnFuncMap.UpdUser].ToString().Trim(); //修改者
objDnFuncMapEN.Memo = objRow[conDnFuncMap.Memo] == DBNull.Value ? null : objRow[conDnFuncMap.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsDnFuncMapDA: GetObjByDataRowDnFuncMap)", objException.Message));
}
objDnFuncMapEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objDnFuncMapEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsDnFuncMapEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsDnFuncMapEN objDnFuncMapEN = new clsDnFuncMapEN();
try
{
objDnFuncMapEN.DnFuncMapId = objRow[conDnFuncMap.DnFuncMapId].ToString().Trim(); //函数映射Id
objDnFuncMapEN.InDataNodeId = TransNullToInt(objRow[conDnFuncMap.InDataNodeId].ToString().Trim()); //In数据结点Id
objDnFuncMapEN.OutDataNodeId = TransNullToInt(objRow[conDnFuncMap.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objDnFuncMapEN.AssociationMappingId = objRow[conDnFuncMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objDnFuncMapEN.FuncMapModeId = objRow[conDnFuncMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objDnFuncMapEN.TabId = objRow[conDnFuncMap.TabId] == DBNull.Value ? null : objRow[conDnFuncMap.TabId].ToString().Trim(); //表ID
objDnFuncMapEN.DnFunctionId = objRow[conDnFuncMap.DnFunctionId] == DBNull.Value ? null : objRow[conDnFuncMap.DnFunctionId].ToString().Trim(); //DN函数Id
objDnFuncMapEN.ErrMsg = objRow[conDnFuncMap.ErrMsg] == DBNull.Value ? null : objRow[conDnFuncMap.ErrMsg].ToString().Trim(); //错误信息
objDnFuncMapEN.PrjId = objRow[conDnFuncMap.PrjId].ToString().Trim(); //工程Id
objDnFuncMapEN.UsedTimes = objRow[conDnFuncMap.UsedTimes] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDnFuncMap.UsedTimes].ToString().Trim()); //使用次数
objDnFuncMapEN.UpdDate = objRow[conDnFuncMap.UpdDate] == DBNull.Value ? null : objRow[conDnFuncMap.UpdDate].ToString().Trim(); //修改日期
objDnFuncMapEN.UpdUser = objRow[conDnFuncMap.UpdUser] == DBNull.Value ? null : objRow[conDnFuncMap.UpdUser].ToString().Trim(); //修改者
objDnFuncMapEN.Memo = objRow[conDnFuncMap.Memo] == DBNull.Value ? null : objRow[conDnFuncMap.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsDnFuncMapDA: GetObjByDataRow)", objException.Message));
}
objDnFuncMapEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objDnFuncMapEN;
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
objSQL = clsDnFuncMapDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsDnFuncMapEN._CurrTabName, conDnFuncMap.DnFuncMapId, 8, "");
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
objSQL = clsDnFuncMapDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsDnFuncMapEN._CurrTabName, conDnFuncMap.DnFuncMapId, 8, strPrefix);
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
 objSQL = clsDnFuncMapDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select DnFuncMapId from DnFuncMap where " + strCondition;
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
 objSQL = clsDnFuncMapDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select DnFuncMapId from DnFuncMap where " + strCondition;
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
 /// <param name = "strDnFuncMapId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strDnFuncMapId)
{
CheckPrimaryKey(strDnFuncMapId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("DnFuncMap", "DnFuncMapId = " + "'"+ strDnFuncMapId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsDnFuncMapDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("DnFuncMap", strCondition))
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
objSQL = clsDnFuncMapDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("DnFuncMap");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsDnFuncMapEN objDnFuncMapEN)
 {
 objDnFuncMapEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDnFuncMapEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDnFuncMapEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapDA.GetSpecSQLObj();
strSQL = "Select * from DnFuncMap where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "DnFuncMap");
objRow = objDS.Tables["DnFuncMap"].NewRow();
objRow[conDnFuncMap.DnFuncMapId] = objDnFuncMapEN.DnFuncMapId; //函数映射Id
objRow[conDnFuncMap.InDataNodeId] = objDnFuncMapEN.InDataNodeId; //In数据结点Id
objRow[conDnFuncMap.OutDataNodeId] = objDnFuncMapEN.OutDataNodeId; //Out数据结点Id
objRow[conDnFuncMap.AssociationMappingId] = objDnFuncMapEN.AssociationMappingId; //关联关系映射Id
objRow[conDnFuncMap.FuncMapModeId] = objDnFuncMapEN.FuncMapModeId; //函数映射模式Id
 if (objDnFuncMapEN.TabId !=  "")
 {
objRow[conDnFuncMap.TabId] = objDnFuncMapEN.TabId; //表ID
 }
 if (objDnFuncMapEN.DnFunctionId !=  "")
 {
objRow[conDnFuncMap.DnFunctionId] = objDnFuncMapEN.DnFunctionId; //DN函数Id
 }
 if (objDnFuncMapEN.ErrMsg !=  "")
 {
objRow[conDnFuncMap.ErrMsg] = objDnFuncMapEN.ErrMsg; //错误信息
 }
objRow[conDnFuncMap.PrjId] = objDnFuncMapEN.PrjId; //工程Id
objRow[conDnFuncMap.UsedTimes] = objDnFuncMapEN.UsedTimes; //使用次数
 if (objDnFuncMapEN.UpdDate !=  "")
 {
objRow[conDnFuncMap.UpdDate] = objDnFuncMapEN.UpdDate; //修改日期
 }
 if (objDnFuncMapEN.UpdUser !=  "")
 {
objRow[conDnFuncMap.UpdUser] = objDnFuncMapEN.UpdUser; //修改者
 }
 if (objDnFuncMapEN.Memo !=  "")
 {
objRow[conDnFuncMap.Memo] = objDnFuncMapEN.Memo; //说明
 }
objDS.Tables[clsDnFuncMapEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsDnFuncMapEN._CurrTabName);
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
 /// <param name = "objDnFuncMapEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsDnFuncMapEN objDnFuncMapEN)
{
 objDnFuncMapEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDnFuncMapEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDnFuncMapEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objDnFuncMapEN.DnFuncMapId !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMap.DnFuncMapId);
 var strDnFuncMapId = objDnFuncMapEN.DnFuncMapId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDnFuncMapId + "'");
 }
 
 arrFieldListForInsert.Add(conDnFuncMap.InDataNodeId);
 arrValueListForInsert.Add(objDnFuncMapEN.InDataNodeId.ToString());
 
 arrFieldListForInsert.Add(conDnFuncMap.OutDataNodeId);
 arrValueListForInsert.Add(objDnFuncMapEN.OutDataNodeId.ToString());
 
 if (objDnFuncMapEN.AssociationMappingId !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMap.AssociationMappingId);
 var strAssociationMappingId = objDnFuncMapEN.AssociationMappingId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAssociationMappingId + "'");
 }
 
 if (objDnFuncMapEN.FuncMapModeId !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMap.FuncMapModeId);
 var strFuncMapModeId = objDnFuncMapEN.FuncMapModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncMapModeId + "'");
 }
 
 if (objDnFuncMapEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMap.TabId);
 var strTabId = objDnFuncMapEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objDnFuncMapEN.DnFunctionId !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMap.DnFunctionId);
 var strDnFunctionId = objDnFuncMapEN.DnFunctionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDnFunctionId + "'");
 }
 
 if (objDnFuncMapEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMap.ErrMsg);
 var strErrMsg = objDnFuncMapEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objDnFuncMapEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMap.PrjId);
 var strPrjId = objDnFuncMapEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objDnFuncMapEN.UsedTimes !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMap.UsedTimes);
 arrValueListForInsert.Add(objDnFuncMapEN.UsedTimes.ToString());
 }
 
 if (objDnFuncMapEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMap.UpdDate);
 var strUpdDate = objDnFuncMapEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objDnFuncMapEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMap.UpdUser);
 var strUpdUser = objDnFuncMapEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objDnFuncMapEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMap.Memo);
 var strMemo = objDnFuncMapEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DnFuncMap");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objDnFuncMapEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsDnFuncMapEN objDnFuncMapEN)
{
 objDnFuncMapEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDnFuncMapEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDnFuncMapEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objDnFuncMapEN.DnFuncMapId !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMap.DnFuncMapId);
 var strDnFuncMapId = objDnFuncMapEN.DnFuncMapId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDnFuncMapId + "'");
 }
 
 arrFieldListForInsert.Add(conDnFuncMap.InDataNodeId);
 arrValueListForInsert.Add(objDnFuncMapEN.InDataNodeId.ToString());
 
 arrFieldListForInsert.Add(conDnFuncMap.OutDataNodeId);
 arrValueListForInsert.Add(objDnFuncMapEN.OutDataNodeId.ToString());
 
 if (objDnFuncMapEN.AssociationMappingId !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMap.AssociationMappingId);
 var strAssociationMappingId = objDnFuncMapEN.AssociationMappingId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAssociationMappingId + "'");
 }
 
 if (objDnFuncMapEN.FuncMapModeId !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMap.FuncMapModeId);
 var strFuncMapModeId = objDnFuncMapEN.FuncMapModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncMapModeId + "'");
 }
 
 if (objDnFuncMapEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMap.TabId);
 var strTabId = objDnFuncMapEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objDnFuncMapEN.DnFunctionId !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMap.DnFunctionId);
 var strDnFunctionId = objDnFuncMapEN.DnFunctionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDnFunctionId + "'");
 }
 
 if (objDnFuncMapEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMap.ErrMsg);
 var strErrMsg = objDnFuncMapEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objDnFuncMapEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMap.PrjId);
 var strPrjId = objDnFuncMapEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objDnFuncMapEN.UsedTimes !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMap.UsedTimes);
 arrValueListForInsert.Add(objDnFuncMapEN.UsedTimes.ToString());
 }
 
 if (objDnFuncMapEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMap.UpdDate);
 var strUpdDate = objDnFuncMapEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objDnFuncMapEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMap.UpdUser);
 var strUpdUser = objDnFuncMapEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objDnFuncMapEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMap.Memo);
 var strMemo = objDnFuncMapEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DnFuncMap");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objDnFuncMapEN.DnFuncMapId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objDnFuncMapEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsDnFuncMapEN objDnFuncMapEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objDnFuncMapEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDnFuncMapEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDnFuncMapEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objDnFuncMapEN.DnFuncMapId !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMap.DnFuncMapId);
 var strDnFuncMapId = objDnFuncMapEN.DnFuncMapId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDnFuncMapId + "'");
 }
 
 arrFieldListForInsert.Add(conDnFuncMap.InDataNodeId);
 arrValueListForInsert.Add(objDnFuncMapEN.InDataNodeId.ToString());
 
 arrFieldListForInsert.Add(conDnFuncMap.OutDataNodeId);
 arrValueListForInsert.Add(objDnFuncMapEN.OutDataNodeId.ToString());
 
 if (objDnFuncMapEN.AssociationMappingId !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMap.AssociationMappingId);
 var strAssociationMappingId = objDnFuncMapEN.AssociationMappingId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAssociationMappingId + "'");
 }
 
 if (objDnFuncMapEN.FuncMapModeId !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMap.FuncMapModeId);
 var strFuncMapModeId = objDnFuncMapEN.FuncMapModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncMapModeId + "'");
 }
 
 if (objDnFuncMapEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMap.TabId);
 var strTabId = objDnFuncMapEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objDnFuncMapEN.DnFunctionId !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMap.DnFunctionId);
 var strDnFunctionId = objDnFuncMapEN.DnFunctionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDnFunctionId + "'");
 }
 
 if (objDnFuncMapEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMap.ErrMsg);
 var strErrMsg = objDnFuncMapEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objDnFuncMapEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMap.PrjId);
 var strPrjId = objDnFuncMapEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objDnFuncMapEN.UsedTimes !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMap.UsedTimes);
 arrValueListForInsert.Add(objDnFuncMapEN.UsedTimes.ToString());
 }
 
 if (objDnFuncMapEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMap.UpdDate);
 var strUpdDate = objDnFuncMapEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objDnFuncMapEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMap.UpdUser);
 var strUpdUser = objDnFuncMapEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objDnFuncMapEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMap.Memo);
 var strMemo = objDnFuncMapEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DnFuncMap");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objDnFuncMapEN.DnFuncMapId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objDnFuncMapEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsDnFuncMapEN objDnFuncMapEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objDnFuncMapEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDnFuncMapEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDnFuncMapEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objDnFuncMapEN.DnFuncMapId !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMap.DnFuncMapId);
 var strDnFuncMapId = objDnFuncMapEN.DnFuncMapId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDnFuncMapId + "'");
 }
 
 arrFieldListForInsert.Add(conDnFuncMap.InDataNodeId);
 arrValueListForInsert.Add(objDnFuncMapEN.InDataNodeId.ToString());
 
 arrFieldListForInsert.Add(conDnFuncMap.OutDataNodeId);
 arrValueListForInsert.Add(objDnFuncMapEN.OutDataNodeId.ToString());
 
 if (objDnFuncMapEN.AssociationMappingId !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMap.AssociationMappingId);
 var strAssociationMappingId = objDnFuncMapEN.AssociationMappingId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAssociationMappingId + "'");
 }
 
 if (objDnFuncMapEN.FuncMapModeId !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMap.FuncMapModeId);
 var strFuncMapModeId = objDnFuncMapEN.FuncMapModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncMapModeId + "'");
 }
 
 if (objDnFuncMapEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMap.TabId);
 var strTabId = objDnFuncMapEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objDnFuncMapEN.DnFunctionId !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMap.DnFunctionId);
 var strDnFunctionId = objDnFuncMapEN.DnFunctionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDnFunctionId + "'");
 }
 
 if (objDnFuncMapEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMap.ErrMsg);
 var strErrMsg = objDnFuncMapEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objDnFuncMapEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMap.PrjId);
 var strPrjId = objDnFuncMapEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objDnFuncMapEN.UsedTimes !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMap.UsedTimes);
 arrValueListForInsert.Add(objDnFuncMapEN.UsedTimes.ToString());
 }
 
 if (objDnFuncMapEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMap.UpdDate);
 var strUpdDate = objDnFuncMapEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objDnFuncMapEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMap.UpdUser);
 var strUpdUser = objDnFuncMapEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objDnFuncMapEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMap.Memo);
 var strMemo = objDnFuncMapEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DnFuncMap");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewDnFuncMaps(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapDA.GetSpecSQLObj();
strSQL = "Select * from DnFuncMap where DnFuncMapId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "DnFuncMap");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strDnFuncMapId = oRow[conDnFuncMap.DnFuncMapId].ToString().Trim();
if (IsExist(strDnFuncMapId))
{
 string strResult = "关键字变量值为:" + string.Format("DnFuncMapId = {0}", strDnFuncMapId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsDnFuncMapEN._CurrTabName ].NewRow();
objRow[conDnFuncMap.DnFuncMapId] = oRow[conDnFuncMap.DnFuncMapId].ToString().Trim(); //函数映射Id
objRow[conDnFuncMap.InDataNodeId] = oRow[conDnFuncMap.InDataNodeId].ToString().Trim(); //In数据结点Id
objRow[conDnFuncMap.OutDataNodeId] = oRow[conDnFuncMap.OutDataNodeId].ToString().Trim(); //Out数据结点Id
objRow[conDnFuncMap.AssociationMappingId] = oRow[conDnFuncMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objRow[conDnFuncMap.FuncMapModeId] = oRow[conDnFuncMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objRow[conDnFuncMap.TabId] = oRow[conDnFuncMap.TabId].ToString().Trim(); //表ID
objRow[conDnFuncMap.DnFunctionId] = oRow[conDnFuncMap.DnFunctionId].ToString().Trim(); //DN函数Id
objRow[conDnFuncMap.ErrMsg] = oRow[conDnFuncMap.ErrMsg].ToString().Trim(); //错误信息
objRow[conDnFuncMap.PrjId] = oRow[conDnFuncMap.PrjId].ToString().Trim(); //工程Id
objRow[conDnFuncMap.UsedTimes] = oRow[conDnFuncMap.UsedTimes].ToString().Trim(); //使用次数
objRow[conDnFuncMap.UpdDate] = oRow[conDnFuncMap.UpdDate].ToString().Trim(); //修改日期
objRow[conDnFuncMap.UpdUser] = oRow[conDnFuncMap.UpdUser].ToString().Trim(); //修改者
objRow[conDnFuncMap.Memo] = oRow[conDnFuncMap.Memo].ToString().Trim(); //说明
 objDS.Tables[clsDnFuncMapEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsDnFuncMapEN._CurrTabName);
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
 /// <param name = "objDnFuncMapEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsDnFuncMapEN objDnFuncMapEN)
{
 objDnFuncMapEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDnFuncMapEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDnFuncMapEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapDA.GetSpecSQLObj();
strSQL = "Select * from DnFuncMap where DnFuncMapId = " + "'"+ objDnFuncMapEN.DnFuncMapId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsDnFuncMapEN._CurrTabName);
if (objDS.Tables[clsDnFuncMapEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:DnFuncMapId = " + "'"+ objDnFuncMapEN.DnFuncMapId+"'");
return false;
}
objRow = objDS.Tables[clsDnFuncMapEN._CurrTabName].Rows[0];
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.DnFuncMapId))
 {
objRow[conDnFuncMap.DnFuncMapId] = objDnFuncMapEN.DnFuncMapId; //函数映射Id
 }
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.InDataNodeId))
 {
objRow[conDnFuncMap.InDataNodeId] = objDnFuncMapEN.InDataNodeId; //In数据结点Id
 }
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.OutDataNodeId))
 {
objRow[conDnFuncMap.OutDataNodeId] = objDnFuncMapEN.OutDataNodeId; //Out数据结点Id
 }
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.AssociationMappingId))
 {
objRow[conDnFuncMap.AssociationMappingId] = objDnFuncMapEN.AssociationMappingId; //关联关系映射Id
 }
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.FuncMapModeId))
 {
objRow[conDnFuncMap.FuncMapModeId] = objDnFuncMapEN.FuncMapModeId; //函数映射模式Id
 }
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.TabId))
 {
objRow[conDnFuncMap.TabId] = objDnFuncMapEN.TabId; //表ID
 }
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.DnFunctionId))
 {
objRow[conDnFuncMap.DnFunctionId] = objDnFuncMapEN.DnFunctionId; //DN函数Id
 }
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.ErrMsg))
 {
objRow[conDnFuncMap.ErrMsg] = objDnFuncMapEN.ErrMsg; //错误信息
 }
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.PrjId))
 {
objRow[conDnFuncMap.PrjId] = objDnFuncMapEN.PrjId; //工程Id
 }
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.UsedTimes))
 {
objRow[conDnFuncMap.UsedTimes] = objDnFuncMapEN.UsedTimes; //使用次数
 }
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.UpdDate))
 {
objRow[conDnFuncMap.UpdDate] = objDnFuncMapEN.UpdDate; //修改日期
 }
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.UpdUser))
 {
objRow[conDnFuncMap.UpdUser] = objDnFuncMapEN.UpdUser; //修改者
 }
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.Memo))
 {
objRow[conDnFuncMap.Memo] = objDnFuncMapEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsDnFuncMapEN._CurrTabName);
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
 /// <param name = "objDnFuncMapEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsDnFuncMapEN objDnFuncMapEN)
{
 objDnFuncMapEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDnFuncMapEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDnFuncMapEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update DnFuncMap Set ");
 
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.InDataNodeId))
 {
 sbSQL.AppendFormat("{1} = {0},",objDnFuncMapEN.InDataNodeId, conDnFuncMap.InDataNodeId); //In数据结点Id
 }
 
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.OutDataNodeId))
 {
 sbSQL.AppendFormat("{1} = {0},",objDnFuncMapEN.OutDataNodeId, conDnFuncMap.OutDataNodeId); //Out数据结点Id
 }
 
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.AssociationMappingId))
 {
 if (objDnFuncMapEN.AssociationMappingId !=  null)
 {
 var strAssociationMappingId = objDnFuncMapEN.AssociationMappingId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAssociationMappingId, conDnFuncMap.AssociationMappingId); //关联关系映射Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnFuncMap.AssociationMappingId); //关联关系映射Id
 }
 }
 
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.FuncMapModeId))
 {
 if (objDnFuncMapEN.FuncMapModeId !=  null)
 {
 var strFuncMapModeId = objDnFuncMapEN.FuncMapModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncMapModeId, conDnFuncMap.FuncMapModeId); //函数映射模式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnFuncMap.FuncMapModeId); //函数映射模式Id
 }
 }
 
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.TabId))
 {
 if (objDnFuncMapEN.TabId !=  null)
 {
 var strTabId = objDnFuncMapEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabId, conDnFuncMap.TabId); //表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnFuncMap.TabId); //表ID
 }
 }
 
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.DnFunctionId))
 {
 if (objDnFuncMapEN.DnFunctionId !=  null)
 {
 var strDnFunctionId = objDnFuncMapEN.DnFunctionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDnFunctionId, conDnFuncMap.DnFunctionId); //DN函数Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnFuncMap.DnFunctionId); //DN函数Id
 }
 }
 
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.ErrMsg))
 {
 if (objDnFuncMapEN.ErrMsg !=  null)
 {
 var strErrMsg = objDnFuncMapEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strErrMsg, conDnFuncMap.ErrMsg); //错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnFuncMap.ErrMsg); //错误信息
 }
 }
 
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.PrjId))
 {
 if (objDnFuncMapEN.PrjId !=  null)
 {
 var strPrjId = objDnFuncMapEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conDnFuncMap.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnFuncMap.PrjId); //工程Id
 }
 }
 
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.UsedTimes))
 {
 if (objDnFuncMapEN.UsedTimes !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDnFuncMapEN.UsedTimes, conDnFuncMap.UsedTimes); //使用次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnFuncMap.UsedTimes); //使用次数
 }
 }
 
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.UpdDate))
 {
 if (objDnFuncMapEN.UpdDate !=  null)
 {
 var strUpdDate = objDnFuncMapEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conDnFuncMap.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnFuncMap.UpdDate); //修改日期
 }
 }
 
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.UpdUser))
 {
 if (objDnFuncMapEN.UpdUser !=  null)
 {
 var strUpdUser = objDnFuncMapEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conDnFuncMap.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnFuncMap.UpdUser); //修改者
 }
 }
 
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.Memo))
 {
 if (objDnFuncMapEN.Memo !=  null)
 {
 var strMemo = objDnFuncMapEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conDnFuncMap.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnFuncMap.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where DnFuncMapId = '{0}'", objDnFuncMapEN.DnFuncMapId); 
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
 /// <param name = "objDnFuncMapEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsDnFuncMapEN objDnFuncMapEN, string strCondition)
{
 objDnFuncMapEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDnFuncMapEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDnFuncMapEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update DnFuncMap Set ");
 
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.InDataNodeId))
 {
 sbSQL.AppendFormat(" InDataNodeId = {0},", objDnFuncMapEN.InDataNodeId); //In数据结点Id
 }
 
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.OutDataNodeId))
 {
 sbSQL.AppendFormat(" OutDataNodeId = {0},", objDnFuncMapEN.OutDataNodeId); //Out数据结点Id
 }
 
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.AssociationMappingId))
 {
 if (objDnFuncMapEN.AssociationMappingId !=  null)
 {
 var strAssociationMappingId = objDnFuncMapEN.AssociationMappingId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AssociationMappingId = '{0}',", strAssociationMappingId); //关联关系映射Id
 }
 else
 {
 sbSQL.Append(" AssociationMappingId = null,"); //关联关系映射Id
 }
 }
 
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.FuncMapModeId))
 {
 if (objDnFuncMapEN.FuncMapModeId !=  null)
 {
 var strFuncMapModeId = objDnFuncMapEN.FuncMapModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncMapModeId = '{0}',", strFuncMapModeId); //函数映射模式Id
 }
 else
 {
 sbSQL.Append(" FuncMapModeId = null,"); //函数映射模式Id
 }
 }
 
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.TabId))
 {
 if (objDnFuncMapEN.TabId !=  null)
 {
 var strTabId = objDnFuncMapEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabId = '{0}',", strTabId); //表ID
 }
 else
 {
 sbSQL.Append(" TabId = null,"); //表ID
 }
 }
 
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.DnFunctionId))
 {
 if (objDnFuncMapEN.DnFunctionId !=  null)
 {
 var strDnFunctionId = objDnFuncMapEN.DnFunctionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DnFunctionId = '{0}',", strDnFunctionId); //DN函数Id
 }
 else
 {
 sbSQL.Append(" DnFunctionId = null,"); //DN函数Id
 }
 }
 
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.ErrMsg))
 {
 if (objDnFuncMapEN.ErrMsg !=  null)
 {
 var strErrMsg = objDnFuncMapEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ErrMsg = '{0}',", strErrMsg); //错误信息
 }
 else
 {
 sbSQL.Append(" ErrMsg = null,"); //错误信息
 }
 }
 
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.PrjId))
 {
 if (objDnFuncMapEN.PrjId !=  null)
 {
 var strPrjId = objDnFuncMapEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.UsedTimes))
 {
 if (objDnFuncMapEN.UsedTimes !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDnFuncMapEN.UsedTimes, conDnFuncMap.UsedTimes); //使用次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnFuncMap.UsedTimes); //使用次数
 }
 }
 
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.UpdDate))
 {
 if (objDnFuncMapEN.UpdDate !=  null)
 {
 var strUpdDate = objDnFuncMapEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.UpdUser))
 {
 if (objDnFuncMapEN.UpdUser !=  null)
 {
 var strUpdUser = objDnFuncMapEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.Memo))
 {
 if (objDnFuncMapEN.Memo !=  null)
 {
 var strMemo = objDnFuncMapEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objDnFuncMapEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsDnFuncMapEN objDnFuncMapEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objDnFuncMapEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDnFuncMapEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDnFuncMapEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update DnFuncMap Set ");
 
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.InDataNodeId))
 {
 sbSQL.AppendFormat(" InDataNodeId = {0},", objDnFuncMapEN.InDataNodeId); //In数据结点Id
 }
 
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.OutDataNodeId))
 {
 sbSQL.AppendFormat(" OutDataNodeId = {0},", objDnFuncMapEN.OutDataNodeId); //Out数据结点Id
 }
 
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.AssociationMappingId))
 {
 if (objDnFuncMapEN.AssociationMappingId !=  null)
 {
 var strAssociationMappingId = objDnFuncMapEN.AssociationMappingId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AssociationMappingId = '{0}',", strAssociationMappingId); //关联关系映射Id
 }
 else
 {
 sbSQL.Append(" AssociationMappingId = null,"); //关联关系映射Id
 }
 }
 
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.FuncMapModeId))
 {
 if (objDnFuncMapEN.FuncMapModeId !=  null)
 {
 var strFuncMapModeId = objDnFuncMapEN.FuncMapModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncMapModeId = '{0}',", strFuncMapModeId); //函数映射模式Id
 }
 else
 {
 sbSQL.Append(" FuncMapModeId = null,"); //函数映射模式Id
 }
 }
 
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.TabId))
 {
 if (objDnFuncMapEN.TabId !=  null)
 {
 var strTabId = objDnFuncMapEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabId = '{0}',", strTabId); //表ID
 }
 else
 {
 sbSQL.Append(" TabId = null,"); //表ID
 }
 }
 
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.DnFunctionId))
 {
 if (objDnFuncMapEN.DnFunctionId !=  null)
 {
 var strDnFunctionId = objDnFuncMapEN.DnFunctionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DnFunctionId = '{0}',", strDnFunctionId); //DN函数Id
 }
 else
 {
 sbSQL.Append(" DnFunctionId = null,"); //DN函数Id
 }
 }
 
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.ErrMsg))
 {
 if (objDnFuncMapEN.ErrMsg !=  null)
 {
 var strErrMsg = objDnFuncMapEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ErrMsg = '{0}',", strErrMsg); //错误信息
 }
 else
 {
 sbSQL.Append(" ErrMsg = null,"); //错误信息
 }
 }
 
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.PrjId))
 {
 if (objDnFuncMapEN.PrjId !=  null)
 {
 var strPrjId = objDnFuncMapEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.UsedTimes))
 {
 if (objDnFuncMapEN.UsedTimes !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDnFuncMapEN.UsedTimes, conDnFuncMap.UsedTimes); //使用次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnFuncMap.UsedTimes); //使用次数
 }
 }
 
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.UpdDate))
 {
 if (objDnFuncMapEN.UpdDate !=  null)
 {
 var strUpdDate = objDnFuncMapEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.UpdUser))
 {
 if (objDnFuncMapEN.UpdUser !=  null)
 {
 var strUpdUser = objDnFuncMapEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.Memo))
 {
 if (objDnFuncMapEN.Memo !=  null)
 {
 var strMemo = objDnFuncMapEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objDnFuncMapEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsDnFuncMapEN objDnFuncMapEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objDnFuncMapEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDnFuncMapEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDnFuncMapEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update DnFuncMap Set ");
 
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.InDataNodeId))
 {
 sbSQL.AppendFormat("{1} = {0},",objDnFuncMapEN.InDataNodeId, conDnFuncMap.InDataNodeId); //In数据结点Id
 }
 
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.OutDataNodeId))
 {
 sbSQL.AppendFormat("{1} = {0},",objDnFuncMapEN.OutDataNodeId, conDnFuncMap.OutDataNodeId); //Out数据结点Id
 }
 
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.AssociationMappingId))
 {
 if (objDnFuncMapEN.AssociationMappingId !=  null)
 {
 var strAssociationMappingId = objDnFuncMapEN.AssociationMappingId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAssociationMappingId, conDnFuncMap.AssociationMappingId); //关联关系映射Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnFuncMap.AssociationMappingId); //关联关系映射Id
 }
 }
 
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.FuncMapModeId))
 {
 if (objDnFuncMapEN.FuncMapModeId !=  null)
 {
 var strFuncMapModeId = objDnFuncMapEN.FuncMapModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncMapModeId, conDnFuncMap.FuncMapModeId); //函数映射模式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnFuncMap.FuncMapModeId); //函数映射模式Id
 }
 }
 
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.TabId))
 {
 if (objDnFuncMapEN.TabId !=  null)
 {
 var strTabId = objDnFuncMapEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabId, conDnFuncMap.TabId); //表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnFuncMap.TabId); //表ID
 }
 }
 
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.DnFunctionId))
 {
 if (objDnFuncMapEN.DnFunctionId !=  null)
 {
 var strDnFunctionId = objDnFuncMapEN.DnFunctionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDnFunctionId, conDnFuncMap.DnFunctionId); //DN函数Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnFuncMap.DnFunctionId); //DN函数Id
 }
 }
 
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.ErrMsg))
 {
 if (objDnFuncMapEN.ErrMsg !=  null)
 {
 var strErrMsg = objDnFuncMapEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strErrMsg, conDnFuncMap.ErrMsg); //错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnFuncMap.ErrMsg); //错误信息
 }
 }
 
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.PrjId))
 {
 if (objDnFuncMapEN.PrjId !=  null)
 {
 var strPrjId = objDnFuncMapEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conDnFuncMap.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnFuncMap.PrjId); //工程Id
 }
 }
 
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.UsedTimes))
 {
 if (objDnFuncMapEN.UsedTimes !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDnFuncMapEN.UsedTimes, conDnFuncMap.UsedTimes); //使用次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnFuncMap.UsedTimes); //使用次数
 }
 }
 
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.UpdDate))
 {
 if (objDnFuncMapEN.UpdDate !=  null)
 {
 var strUpdDate = objDnFuncMapEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conDnFuncMap.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnFuncMap.UpdDate); //修改日期
 }
 }
 
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.UpdUser))
 {
 if (objDnFuncMapEN.UpdUser !=  null)
 {
 var strUpdUser = objDnFuncMapEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conDnFuncMap.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnFuncMap.UpdUser); //修改者
 }
 }
 
 if (objDnFuncMapEN.IsUpdated(conDnFuncMap.Memo))
 {
 if (objDnFuncMapEN.Memo !=  null)
 {
 var strMemo = objDnFuncMapEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conDnFuncMap.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnFuncMap.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where DnFuncMapId = '{0}'", objDnFuncMapEN.DnFuncMapId); 
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
 /// <param name = "strDnFuncMapId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strDnFuncMapId) 
{
CheckPrimaryKey(strDnFuncMapId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strDnFuncMapId,
};
 objSQL.ExecSP("DnFuncMap_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strDnFuncMapId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strDnFuncMapId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strDnFuncMapId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapDA.GetSpecSQLObj();
//删除DnFuncMap本表中与当前对象有关的记录
strSQL = strSQL + "Delete from DnFuncMap where DnFuncMapId = " + "'"+ strDnFuncMapId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelDnFuncMap(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapDA.GetSpecSQLObj();
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
//删除DnFuncMap本表中与当前对象有关的记录
strSQL = strSQL + "Delete from DnFuncMap where DnFuncMapId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strDnFuncMapId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strDnFuncMapId) 
{
CheckPrimaryKey(strDnFuncMapId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapDA.GetSpecSQLObj();
//删除DnFuncMap本表中与当前对象有关的记录
strSQL = strSQL + "Delete from DnFuncMap where DnFuncMapId = " + "'"+ strDnFuncMapId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelDnFuncMap(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsDnFuncMapDA: DelDnFuncMap)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from DnFuncMap where " + strCondition ;
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
public bool DelDnFuncMapWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsDnFuncMapDA: DelDnFuncMapWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from DnFuncMap where " + strCondition ;
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
 /// <param name = "objDnFuncMapENS">源对象</param>
 /// <param name = "objDnFuncMapENT">目标对象</param>
public void CopyTo(clsDnFuncMapEN objDnFuncMapENS, clsDnFuncMapEN objDnFuncMapENT)
{
objDnFuncMapENT.DnFuncMapId = objDnFuncMapENS.DnFuncMapId; //函数映射Id
objDnFuncMapENT.InDataNodeId = objDnFuncMapENS.InDataNodeId; //In数据结点Id
objDnFuncMapENT.OutDataNodeId = objDnFuncMapENS.OutDataNodeId; //Out数据结点Id
objDnFuncMapENT.AssociationMappingId = objDnFuncMapENS.AssociationMappingId; //关联关系映射Id
objDnFuncMapENT.FuncMapModeId = objDnFuncMapENS.FuncMapModeId; //函数映射模式Id
objDnFuncMapENT.TabId = objDnFuncMapENS.TabId; //表ID
objDnFuncMapENT.DnFunctionId = objDnFuncMapENS.DnFunctionId; //DN函数Id
objDnFuncMapENT.ErrMsg = objDnFuncMapENS.ErrMsg; //错误信息
objDnFuncMapENT.PrjId = objDnFuncMapENS.PrjId; //工程Id
objDnFuncMapENT.UsedTimes = objDnFuncMapENS.UsedTimes; //使用次数
objDnFuncMapENT.UpdDate = objDnFuncMapENS.UpdDate; //修改日期
objDnFuncMapENT.UpdUser = objDnFuncMapENS.UpdUser; //修改者
objDnFuncMapENT.Memo = objDnFuncMapENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsDnFuncMapEN objDnFuncMapEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objDnFuncMapEN.InDataNodeId, conDnFuncMap.InDataNodeId);
clsCheckSql.CheckFieldNotNull(objDnFuncMapEN.OutDataNodeId, conDnFuncMap.OutDataNodeId);
clsCheckSql.CheckFieldNotNull(objDnFuncMapEN.AssociationMappingId, conDnFuncMap.AssociationMappingId);
clsCheckSql.CheckFieldNotNull(objDnFuncMapEN.FuncMapModeId, conDnFuncMap.FuncMapModeId);
clsCheckSql.CheckFieldNotNull(objDnFuncMapEN.PrjId, conDnFuncMap.PrjId);
//检查字段长度
clsCheckSql.CheckFieldLen(objDnFuncMapEN.DnFuncMapId, 8, conDnFuncMap.DnFuncMapId);
clsCheckSql.CheckFieldLen(objDnFuncMapEN.AssociationMappingId, 2, conDnFuncMap.AssociationMappingId);
clsCheckSql.CheckFieldLen(objDnFuncMapEN.FuncMapModeId, 2, conDnFuncMap.FuncMapModeId);
clsCheckSql.CheckFieldLen(objDnFuncMapEN.TabId, 8, conDnFuncMap.TabId);
clsCheckSql.CheckFieldLen(objDnFuncMapEN.DnFunctionId, 8, conDnFuncMap.DnFunctionId);
clsCheckSql.CheckFieldLen(objDnFuncMapEN.ErrMsg, 2000, conDnFuncMap.ErrMsg);
clsCheckSql.CheckFieldLen(objDnFuncMapEN.PrjId, 4, conDnFuncMap.PrjId);
clsCheckSql.CheckFieldLen(objDnFuncMapEN.UpdDate, 20, conDnFuncMap.UpdDate);
clsCheckSql.CheckFieldLen(objDnFuncMapEN.UpdUser, 20, conDnFuncMap.UpdUser);
clsCheckSql.CheckFieldLen(objDnFuncMapEN.Memo, 1000, conDnFuncMap.Memo);
//检查字段外键固定长度
 objDnFuncMapEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsDnFuncMapEN objDnFuncMapEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objDnFuncMapEN.AssociationMappingId, 2, conDnFuncMap.AssociationMappingId);
clsCheckSql.CheckFieldLen(objDnFuncMapEN.FuncMapModeId, 2, conDnFuncMap.FuncMapModeId);
clsCheckSql.CheckFieldLen(objDnFuncMapEN.TabId, 8, conDnFuncMap.TabId);
clsCheckSql.CheckFieldLen(objDnFuncMapEN.DnFunctionId, 8, conDnFuncMap.DnFunctionId);
clsCheckSql.CheckFieldLen(objDnFuncMapEN.ErrMsg, 2000, conDnFuncMap.ErrMsg);
clsCheckSql.CheckFieldLen(objDnFuncMapEN.PrjId, 4, conDnFuncMap.PrjId);
clsCheckSql.CheckFieldLen(objDnFuncMapEN.UpdDate, 20, conDnFuncMap.UpdDate);
clsCheckSql.CheckFieldLen(objDnFuncMapEN.UpdUser, 20, conDnFuncMap.UpdUser);
clsCheckSql.CheckFieldLen(objDnFuncMapEN.Memo, 1000, conDnFuncMap.Memo);
//检查外键字段长度
 objDnFuncMapEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsDnFuncMapEN objDnFuncMapEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objDnFuncMapEN.DnFuncMapId, 8, conDnFuncMap.DnFuncMapId);
clsCheckSql.CheckFieldLen(objDnFuncMapEN.AssociationMappingId, 2, conDnFuncMap.AssociationMappingId);
clsCheckSql.CheckFieldLen(objDnFuncMapEN.FuncMapModeId, 2, conDnFuncMap.FuncMapModeId);
clsCheckSql.CheckFieldLen(objDnFuncMapEN.TabId, 8, conDnFuncMap.TabId);
clsCheckSql.CheckFieldLen(objDnFuncMapEN.DnFunctionId, 8, conDnFuncMap.DnFunctionId);
clsCheckSql.CheckFieldLen(objDnFuncMapEN.ErrMsg, 2000, conDnFuncMap.ErrMsg);
clsCheckSql.CheckFieldLen(objDnFuncMapEN.PrjId, 4, conDnFuncMap.PrjId);
clsCheckSql.CheckFieldLen(objDnFuncMapEN.UpdDate, 20, conDnFuncMap.UpdDate);
clsCheckSql.CheckFieldLen(objDnFuncMapEN.UpdUser, 20, conDnFuncMap.UpdUser);
clsCheckSql.CheckFieldLen(objDnFuncMapEN.Memo, 1000, conDnFuncMap.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objDnFuncMapEN.DnFuncMapId, conDnFuncMap.DnFuncMapId);
clsCheckSql.CheckSqlInjection4Field(objDnFuncMapEN.AssociationMappingId, conDnFuncMap.AssociationMappingId);
clsCheckSql.CheckSqlInjection4Field(objDnFuncMapEN.FuncMapModeId, conDnFuncMap.FuncMapModeId);
clsCheckSql.CheckSqlInjection4Field(objDnFuncMapEN.TabId, conDnFuncMap.TabId);
clsCheckSql.CheckSqlInjection4Field(objDnFuncMapEN.DnFunctionId, conDnFuncMap.DnFunctionId);
clsCheckSql.CheckSqlInjection4Field(objDnFuncMapEN.ErrMsg, conDnFuncMap.ErrMsg);
clsCheckSql.CheckSqlInjection4Field(objDnFuncMapEN.PrjId, conDnFuncMap.PrjId);
clsCheckSql.CheckSqlInjection4Field(objDnFuncMapEN.UpdDate, conDnFuncMap.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objDnFuncMapEN.UpdUser, conDnFuncMap.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objDnFuncMapEN.Memo, conDnFuncMap.Memo);
//检查外键字段长度
 objDnFuncMapEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--DnFuncMap(结点函数映射),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objDnFuncMapEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsDnFuncMapEN objDnFuncMapEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and InDataNodeId = '{0}'", objDnFuncMapEN.InDataNodeId);
 sbCondition.AppendFormat(" and OutDataNodeId = '{0}'", objDnFuncMapEN.OutDataNodeId);
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
 objSQL = clsDnFuncMapDA.GetSpecSQLObj();
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
 objSQL = clsDnFuncMapDA.GetSpecSQLObj();
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
 objSQL = clsDnFuncMapDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsDnFuncMapEN._CurrTabName);
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
 objSQL = clsDnFuncMapDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsDnFuncMapEN._CurrTabName, strCondition);
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
 objSQL = clsDnFuncMapDA.GetSpecSQLObj();
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
 objSQL = clsDnFuncMapDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}