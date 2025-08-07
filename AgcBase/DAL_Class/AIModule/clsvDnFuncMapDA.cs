
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvDnFuncMapDA
 表名:vDnFuncMap(00050554)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:27:30
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
 /// v结点函数映射(vDnFuncMap)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvDnFuncMapDA : clsCommBase4DA
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
 return clsvDnFuncMapEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvDnFuncMapEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvDnFuncMapEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvDnFuncMapEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvDnFuncMapEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vDnFuncMap中,检查关键字,长度不正确!(clsvDnFuncMapDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strDnFuncMapId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vDnFuncMap中,关键字不能为空 或 null!(clsvDnFuncMapDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strDnFuncMapId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvDnFuncMapDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvDnFuncMapDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDnFuncMapDA.GetSpecSQLObj();
strSQL = "Select * from vDnFuncMap where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vDnFuncMap(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvDnFuncMapDA: GetDataTable_vDnFuncMap)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDnFuncMapDA.GetSpecSQLObj();
strSQL = "Select * from vDnFuncMap where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvDnFuncMapDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDnFuncMapDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvDnFuncMapDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDnFuncMapDA.GetSpecSQLObj();
strSQL = "Select * from vDnFuncMap where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvDnFuncMapDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDnFuncMapDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvDnFuncMapDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDnFuncMapDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vDnFuncMap where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vDnFuncMap where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvDnFuncMapDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDnFuncMapDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vDnFuncMap where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvDnFuncMapDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDnFuncMapDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vDnFuncMap.* " + 
$"from vDnFuncMap " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vDnFuncMap.DnFuncMapId not in " + 
$"(Select top {intTop_In} vDnFuncMap.DnFuncMapId from vDnFuncMap " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vDnFuncMap where {1} and DnFuncMapId not in (Select top {2} DnFuncMapId from vDnFuncMap where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vDnFuncMap where {1} and DnFuncMapId not in (Select top {3} DnFuncMapId from vDnFuncMap where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvDnFuncMapDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDnFuncMapDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vDnFuncMap.* " + 
$"from vDnFuncMap " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vDnFuncMap.DnFuncMapId not in " + 
$"(Select top {intTop_In} vDnFuncMap.DnFuncMapId from vDnFuncMap " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vDnFuncMap where {1} and DnFuncMapId not in (Select top {2} DnFuncMapId from vDnFuncMap where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vDnFuncMap where {1} and DnFuncMapId not in (Select top {3} DnFuncMapId from vDnFuncMap where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvDnFuncMapEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvDnFuncMapDA:GetObjLst)", objException.Message));
}
List<clsvDnFuncMapEN> arrObjLst = new List<clsvDnFuncMapEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDnFuncMapDA.GetSpecSQLObj();
strSQL = "Select * from vDnFuncMap where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDnFuncMapEN objvDnFuncMapEN = new clsvDnFuncMapEN();
try
{
objvDnFuncMapEN.DnFuncMapId = objRow[convDnFuncMap.DnFuncMapId].ToString().Trim(); //函数映射Id
objvDnFuncMapEN.InDataNodeId = objRow[convDnFuncMap.InDataNodeId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convDnFuncMap.InDataNodeId].ToString().Trim()); //In数据结点Id
objvDnFuncMapEN.OutDataNodeId = objRow[convDnFuncMap.OutDataNodeId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convDnFuncMap.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objvDnFuncMapEN.AssociationMappingId = objRow[convDnFuncMap.AssociationMappingId] == DBNull.Value ? null : objRow[convDnFuncMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objvDnFuncMapEN.AssociationMappingName = objRow[convDnFuncMap.AssociationMappingName] == DBNull.Value ? null : objRow[convDnFuncMap.AssociationMappingName].ToString().Trim(); //关联关系映射名
objvDnFuncMapEN.FuncMapModeId = objRow[convDnFuncMap.FuncMapModeId] == DBNull.Value ? null : objRow[convDnFuncMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objvDnFuncMapEN.FuncMapModeName = objRow[convDnFuncMap.FuncMapModeName] == DBNull.Value ? null : objRow[convDnFuncMap.FuncMapModeName].ToString().Trim(); //函数映射模式名
objvDnFuncMapEN.TabId = objRow[convDnFuncMap.TabId].ToString().Trim(); //表ID
objvDnFuncMapEN.DnFunctionId = objRow[convDnFuncMap.DnFunctionId] == DBNull.Value ? null : objRow[convDnFuncMap.DnFunctionId].ToString().Trim(); //DN函数Id
objvDnFuncMapEN.PrjId = objRow[convDnFuncMap.PrjId].ToString().Trim(); //工程Id
objvDnFuncMapEN.UpdDate = objRow[convDnFuncMap.UpdDate] == DBNull.Value ? null : objRow[convDnFuncMap.UpdDate].ToString().Trim(); //修改日期
objvDnFuncMapEN.UpdUser = objRow[convDnFuncMap.UpdUser] == DBNull.Value ? null : objRow[convDnFuncMap.UpdUser].ToString().Trim(); //修改者
objvDnFuncMapEN.Memo = objRow[convDnFuncMap.Memo] == DBNull.Value ? null : objRow[convDnFuncMap.Memo].ToString().Trim(); //说明
objvDnFuncMapEN.InDataNodeName = objRow[convDnFuncMap.InDataNodeName] == DBNull.Value ? null : objRow[convDnFuncMap.InDataNodeName].ToString().Trim(); //In数据结点名
objvDnFuncMapEN.OutDataNodeName = objRow[convDnFuncMap.OutDataNodeName] == DBNull.Value ? null : objRow[convDnFuncMap.OutDataNodeName].ToString().Trim(); //Out数据结点名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvDnFuncMapDA: GetObjLst)", objException.Message));
}
objvDnFuncMapEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvDnFuncMapEN);
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
public List<clsvDnFuncMapEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvDnFuncMapDA:GetObjLstByTabName)", objException.Message));
}
List<clsvDnFuncMapEN> arrObjLst = new List<clsvDnFuncMapEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDnFuncMapDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDnFuncMapEN objvDnFuncMapEN = new clsvDnFuncMapEN();
try
{
objvDnFuncMapEN.DnFuncMapId = objRow[convDnFuncMap.DnFuncMapId].ToString().Trim(); //函数映射Id
objvDnFuncMapEN.InDataNodeId = objRow[convDnFuncMap.InDataNodeId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convDnFuncMap.InDataNodeId].ToString().Trim()); //In数据结点Id
objvDnFuncMapEN.OutDataNodeId = objRow[convDnFuncMap.OutDataNodeId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convDnFuncMap.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objvDnFuncMapEN.AssociationMappingId = objRow[convDnFuncMap.AssociationMappingId] == DBNull.Value ? null : objRow[convDnFuncMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objvDnFuncMapEN.AssociationMappingName = objRow[convDnFuncMap.AssociationMappingName] == DBNull.Value ? null : objRow[convDnFuncMap.AssociationMappingName].ToString().Trim(); //关联关系映射名
objvDnFuncMapEN.FuncMapModeId = objRow[convDnFuncMap.FuncMapModeId] == DBNull.Value ? null : objRow[convDnFuncMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objvDnFuncMapEN.FuncMapModeName = objRow[convDnFuncMap.FuncMapModeName] == DBNull.Value ? null : objRow[convDnFuncMap.FuncMapModeName].ToString().Trim(); //函数映射模式名
objvDnFuncMapEN.TabId = objRow[convDnFuncMap.TabId].ToString().Trim(); //表ID
objvDnFuncMapEN.DnFunctionId = objRow[convDnFuncMap.DnFunctionId] == DBNull.Value ? null : objRow[convDnFuncMap.DnFunctionId].ToString().Trim(); //DN函数Id
objvDnFuncMapEN.PrjId = objRow[convDnFuncMap.PrjId].ToString().Trim(); //工程Id
objvDnFuncMapEN.UpdDate = objRow[convDnFuncMap.UpdDate] == DBNull.Value ? null : objRow[convDnFuncMap.UpdDate].ToString().Trim(); //修改日期
objvDnFuncMapEN.UpdUser = objRow[convDnFuncMap.UpdUser] == DBNull.Value ? null : objRow[convDnFuncMap.UpdUser].ToString().Trim(); //修改者
objvDnFuncMapEN.Memo = objRow[convDnFuncMap.Memo] == DBNull.Value ? null : objRow[convDnFuncMap.Memo].ToString().Trim(); //说明
objvDnFuncMapEN.InDataNodeName = objRow[convDnFuncMap.InDataNodeName] == DBNull.Value ? null : objRow[convDnFuncMap.InDataNodeName].ToString().Trim(); //In数据结点名
objvDnFuncMapEN.OutDataNodeName = objRow[convDnFuncMap.OutDataNodeName] == DBNull.Value ? null : objRow[convDnFuncMap.OutDataNodeName].ToString().Trim(); //Out数据结点名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvDnFuncMapDA: GetObjLst)", objException.Message));
}
objvDnFuncMapEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvDnFuncMapEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvDnFuncMapEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvDnFuncMap(ref clsvDnFuncMapEN objvDnFuncMapEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDnFuncMapDA.GetSpecSQLObj();
strSQL = "Select * from vDnFuncMap where DnFuncMapId = " + "'"+ objvDnFuncMapEN.DnFuncMapId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvDnFuncMapEN.DnFuncMapId = objDT.Rows[0][convDnFuncMap.DnFuncMapId].ToString().Trim(); //函数映射Id(字段类型:char,字段长度:8,是否可空:False)
 objvDnFuncMapEN.InDataNodeId = TransNullToInt(objDT.Rows[0][convDnFuncMap.InDataNodeId].ToString().Trim()); //In数据结点Id(字段类型:bigint,字段长度:8,是否可空:True)
 objvDnFuncMapEN.OutDataNodeId = TransNullToInt(objDT.Rows[0][convDnFuncMap.OutDataNodeId].ToString().Trim()); //Out数据结点Id(字段类型:bigint,字段长度:8,是否可空:True)
 objvDnFuncMapEN.AssociationMappingId = objDT.Rows[0][convDnFuncMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id(字段类型:char,字段长度:2,是否可空:True)
 objvDnFuncMapEN.AssociationMappingName = objDT.Rows[0][convDnFuncMap.AssociationMappingName].ToString().Trim(); //关联关系映射名(字段类型:varchar,字段长度:50,是否可空:True)
 objvDnFuncMapEN.FuncMapModeId = objDT.Rows[0][convDnFuncMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id(字段类型:char,字段长度:2,是否可空:True)
 objvDnFuncMapEN.FuncMapModeName = objDT.Rows[0][convDnFuncMap.FuncMapModeName].ToString().Trim(); //函数映射模式名(字段类型:varchar,字段长度:50,是否可空:True)
 objvDnFuncMapEN.TabId = objDT.Rows[0][convDnFuncMap.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvDnFuncMapEN.DnFunctionId = objDT.Rows[0][convDnFuncMap.DnFunctionId].ToString().Trim(); //DN函数Id(字段类型:char,字段长度:8,是否可空:True)
 objvDnFuncMapEN.PrjId = objDT.Rows[0][convDnFuncMap.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvDnFuncMapEN.UpdDate = objDT.Rows[0][convDnFuncMap.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvDnFuncMapEN.UpdUser = objDT.Rows[0][convDnFuncMap.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvDnFuncMapEN.Memo = objDT.Rows[0][convDnFuncMap.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvDnFuncMapEN.InDataNodeName = objDT.Rows[0][convDnFuncMap.InDataNodeName].ToString().Trim(); //In数据结点名(字段类型:varchar,字段长度:100,是否可空:True)
 objvDnFuncMapEN.OutDataNodeName = objDT.Rows[0][convDnFuncMap.OutDataNodeName].ToString().Trim(); //Out数据结点名(字段类型:varchar,字段长度:100,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvDnFuncMapDA: GetvDnFuncMap)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strDnFuncMapId">表关键字</param>
 /// <returns>表对象</returns>
public clsvDnFuncMapEN GetObjByDnFuncMapId(string strDnFuncMapId)
{
CheckPrimaryKey(strDnFuncMapId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDnFuncMapDA.GetSpecSQLObj();
strSQL = "Select * from vDnFuncMap where DnFuncMapId = " + "'"+ strDnFuncMapId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvDnFuncMapEN objvDnFuncMapEN = new clsvDnFuncMapEN();
try
{
 objvDnFuncMapEN.DnFuncMapId = objRow[convDnFuncMap.DnFuncMapId].ToString().Trim(); //函数映射Id(字段类型:char,字段长度:8,是否可空:False)
 objvDnFuncMapEN.InDataNodeId = objRow[convDnFuncMap.InDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convDnFuncMap.InDataNodeId].ToString().Trim()); //In数据结点Id(字段类型:bigint,字段长度:8,是否可空:True)
 objvDnFuncMapEN.OutDataNodeId = objRow[convDnFuncMap.OutDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convDnFuncMap.OutDataNodeId].ToString().Trim()); //Out数据结点Id(字段类型:bigint,字段长度:8,是否可空:True)
 objvDnFuncMapEN.AssociationMappingId = objRow[convDnFuncMap.AssociationMappingId] == DBNull.Value ? null : objRow[convDnFuncMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id(字段类型:char,字段长度:2,是否可空:True)
 objvDnFuncMapEN.AssociationMappingName = objRow[convDnFuncMap.AssociationMappingName] == DBNull.Value ? null : objRow[convDnFuncMap.AssociationMappingName].ToString().Trim(); //关联关系映射名(字段类型:varchar,字段长度:50,是否可空:True)
 objvDnFuncMapEN.FuncMapModeId = objRow[convDnFuncMap.FuncMapModeId] == DBNull.Value ? null : objRow[convDnFuncMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id(字段类型:char,字段长度:2,是否可空:True)
 objvDnFuncMapEN.FuncMapModeName = objRow[convDnFuncMap.FuncMapModeName] == DBNull.Value ? null : objRow[convDnFuncMap.FuncMapModeName].ToString().Trim(); //函数映射模式名(字段类型:varchar,字段长度:50,是否可空:True)
 objvDnFuncMapEN.TabId = objRow[convDnFuncMap.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvDnFuncMapEN.DnFunctionId = objRow[convDnFuncMap.DnFunctionId] == DBNull.Value ? null : objRow[convDnFuncMap.DnFunctionId].ToString().Trim(); //DN函数Id(字段类型:char,字段长度:8,是否可空:True)
 objvDnFuncMapEN.PrjId = objRow[convDnFuncMap.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvDnFuncMapEN.UpdDate = objRow[convDnFuncMap.UpdDate] == DBNull.Value ? null : objRow[convDnFuncMap.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvDnFuncMapEN.UpdUser = objRow[convDnFuncMap.UpdUser] == DBNull.Value ? null : objRow[convDnFuncMap.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvDnFuncMapEN.Memo = objRow[convDnFuncMap.Memo] == DBNull.Value ? null : objRow[convDnFuncMap.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvDnFuncMapEN.InDataNodeName = objRow[convDnFuncMap.InDataNodeName] == DBNull.Value ? null : objRow[convDnFuncMap.InDataNodeName].ToString().Trim(); //In数据结点名(字段类型:varchar,字段长度:100,是否可空:True)
 objvDnFuncMapEN.OutDataNodeName = objRow[convDnFuncMap.OutDataNodeName] == DBNull.Value ? null : objRow[convDnFuncMap.OutDataNodeName].ToString().Trim(); //Out数据结点名(字段类型:varchar,字段长度:100,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvDnFuncMapDA: GetObjByDnFuncMapId)", objException.Message));
}
return objvDnFuncMapEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvDnFuncMapEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvDnFuncMapDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDnFuncMapDA.GetSpecSQLObj();
strSQL = "Select * from vDnFuncMap where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvDnFuncMapEN objvDnFuncMapEN = new clsvDnFuncMapEN()
{
DnFuncMapId = objRow[convDnFuncMap.DnFuncMapId].ToString().Trim(), //函数映射Id
InDataNodeId = objRow[convDnFuncMap.InDataNodeId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convDnFuncMap.InDataNodeId].ToString().Trim()), //In数据结点Id
OutDataNodeId = objRow[convDnFuncMap.OutDataNodeId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convDnFuncMap.OutDataNodeId].ToString().Trim()), //Out数据结点Id
AssociationMappingId = objRow[convDnFuncMap.AssociationMappingId] == DBNull.Value ? null : objRow[convDnFuncMap.AssociationMappingId].ToString().Trim(), //关联关系映射Id
AssociationMappingName = objRow[convDnFuncMap.AssociationMappingName] == DBNull.Value ? null : objRow[convDnFuncMap.AssociationMappingName].ToString().Trim(), //关联关系映射名
FuncMapModeId = objRow[convDnFuncMap.FuncMapModeId] == DBNull.Value ? null : objRow[convDnFuncMap.FuncMapModeId].ToString().Trim(), //函数映射模式Id
FuncMapModeName = objRow[convDnFuncMap.FuncMapModeName] == DBNull.Value ? null : objRow[convDnFuncMap.FuncMapModeName].ToString().Trim(), //函数映射模式名
TabId = objRow[convDnFuncMap.TabId].ToString().Trim(), //表ID
DnFunctionId = objRow[convDnFuncMap.DnFunctionId] == DBNull.Value ? null : objRow[convDnFuncMap.DnFunctionId].ToString().Trim(), //DN函数Id
PrjId = objRow[convDnFuncMap.PrjId].ToString().Trim(), //工程Id
UpdDate = objRow[convDnFuncMap.UpdDate] == DBNull.Value ? null : objRow[convDnFuncMap.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convDnFuncMap.UpdUser] == DBNull.Value ? null : objRow[convDnFuncMap.UpdUser].ToString().Trim(), //修改者
Memo = objRow[convDnFuncMap.Memo] == DBNull.Value ? null : objRow[convDnFuncMap.Memo].ToString().Trim(), //说明
InDataNodeName = objRow[convDnFuncMap.InDataNodeName] == DBNull.Value ? null : objRow[convDnFuncMap.InDataNodeName].ToString().Trim(), //In数据结点名
OutDataNodeName = objRow[convDnFuncMap.OutDataNodeName] == DBNull.Value ? null : objRow[convDnFuncMap.OutDataNodeName].ToString().Trim() //Out数据结点名
};
objvDnFuncMapEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvDnFuncMapEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvDnFuncMapDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvDnFuncMapEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvDnFuncMapEN objvDnFuncMapEN = new clsvDnFuncMapEN();
try
{
objvDnFuncMapEN.DnFuncMapId = objRow[convDnFuncMap.DnFuncMapId].ToString().Trim(); //函数映射Id
objvDnFuncMapEN.InDataNodeId = objRow[convDnFuncMap.InDataNodeId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convDnFuncMap.InDataNodeId].ToString().Trim()); //In数据结点Id
objvDnFuncMapEN.OutDataNodeId = objRow[convDnFuncMap.OutDataNodeId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convDnFuncMap.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objvDnFuncMapEN.AssociationMappingId = objRow[convDnFuncMap.AssociationMappingId] == DBNull.Value ? null : objRow[convDnFuncMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objvDnFuncMapEN.AssociationMappingName = objRow[convDnFuncMap.AssociationMappingName] == DBNull.Value ? null : objRow[convDnFuncMap.AssociationMappingName].ToString().Trim(); //关联关系映射名
objvDnFuncMapEN.FuncMapModeId = objRow[convDnFuncMap.FuncMapModeId] == DBNull.Value ? null : objRow[convDnFuncMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objvDnFuncMapEN.FuncMapModeName = objRow[convDnFuncMap.FuncMapModeName] == DBNull.Value ? null : objRow[convDnFuncMap.FuncMapModeName].ToString().Trim(); //函数映射模式名
objvDnFuncMapEN.TabId = objRow[convDnFuncMap.TabId].ToString().Trim(); //表ID
objvDnFuncMapEN.DnFunctionId = objRow[convDnFuncMap.DnFunctionId] == DBNull.Value ? null : objRow[convDnFuncMap.DnFunctionId].ToString().Trim(); //DN函数Id
objvDnFuncMapEN.PrjId = objRow[convDnFuncMap.PrjId].ToString().Trim(); //工程Id
objvDnFuncMapEN.UpdDate = objRow[convDnFuncMap.UpdDate] == DBNull.Value ? null : objRow[convDnFuncMap.UpdDate].ToString().Trim(); //修改日期
objvDnFuncMapEN.UpdUser = objRow[convDnFuncMap.UpdUser] == DBNull.Value ? null : objRow[convDnFuncMap.UpdUser].ToString().Trim(); //修改者
objvDnFuncMapEN.Memo = objRow[convDnFuncMap.Memo] == DBNull.Value ? null : objRow[convDnFuncMap.Memo].ToString().Trim(); //说明
objvDnFuncMapEN.InDataNodeName = objRow[convDnFuncMap.InDataNodeName] == DBNull.Value ? null : objRow[convDnFuncMap.InDataNodeName].ToString().Trim(); //In数据结点名
objvDnFuncMapEN.OutDataNodeName = objRow[convDnFuncMap.OutDataNodeName] == DBNull.Value ? null : objRow[convDnFuncMap.OutDataNodeName].ToString().Trim(); //Out数据结点名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvDnFuncMapDA: GetObjByDataRowvDnFuncMap)", objException.Message));
}
objvDnFuncMapEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvDnFuncMapEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvDnFuncMapEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvDnFuncMapEN objvDnFuncMapEN = new clsvDnFuncMapEN();
try
{
objvDnFuncMapEN.DnFuncMapId = objRow[convDnFuncMap.DnFuncMapId].ToString().Trim(); //函数映射Id
objvDnFuncMapEN.InDataNodeId = objRow[convDnFuncMap.InDataNodeId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convDnFuncMap.InDataNodeId].ToString().Trim()); //In数据结点Id
objvDnFuncMapEN.OutDataNodeId = objRow[convDnFuncMap.OutDataNodeId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convDnFuncMap.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objvDnFuncMapEN.AssociationMappingId = objRow[convDnFuncMap.AssociationMappingId] == DBNull.Value ? null : objRow[convDnFuncMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objvDnFuncMapEN.AssociationMappingName = objRow[convDnFuncMap.AssociationMappingName] == DBNull.Value ? null : objRow[convDnFuncMap.AssociationMappingName].ToString().Trim(); //关联关系映射名
objvDnFuncMapEN.FuncMapModeId = objRow[convDnFuncMap.FuncMapModeId] == DBNull.Value ? null : objRow[convDnFuncMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objvDnFuncMapEN.FuncMapModeName = objRow[convDnFuncMap.FuncMapModeName] == DBNull.Value ? null : objRow[convDnFuncMap.FuncMapModeName].ToString().Trim(); //函数映射模式名
objvDnFuncMapEN.TabId = objRow[convDnFuncMap.TabId].ToString().Trim(); //表ID
objvDnFuncMapEN.DnFunctionId = objRow[convDnFuncMap.DnFunctionId] == DBNull.Value ? null : objRow[convDnFuncMap.DnFunctionId].ToString().Trim(); //DN函数Id
objvDnFuncMapEN.PrjId = objRow[convDnFuncMap.PrjId].ToString().Trim(); //工程Id
objvDnFuncMapEN.UpdDate = objRow[convDnFuncMap.UpdDate] == DBNull.Value ? null : objRow[convDnFuncMap.UpdDate].ToString().Trim(); //修改日期
objvDnFuncMapEN.UpdUser = objRow[convDnFuncMap.UpdUser] == DBNull.Value ? null : objRow[convDnFuncMap.UpdUser].ToString().Trim(); //修改者
objvDnFuncMapEN.Memo = objRow[convDnFuncMap.Memo] == DBNull.Value ? null : objRow[convDnFuncMap.Memo].ToString().Trim(); //说明
objvDnFuncMapEN.InDataNodeName = objRow[convDnFuncMap.InDataNodeName] == DBNull.Value ? null : objRow[convDnFuncMap.InDataNodeName].ToString().Trim(); //In数据结点名
objvDnFuncMapEN.OutDataNodeName = objRow[convDnFuncMap.OutDataNodeName] == DBNull.Value ? null : objRow[convDnFuncMap.OutDataNodeName].ToString().Trim(); //Out数据结点名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvDnFuncMapDA: GetObjByDataRow)", objException.Message));
}
objvDnFuncMapEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvDnFuncMapEN;
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
objSQL = clsvDnFuncMapDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvDnFuncMapEN._CurrTabName, convDnFuncMap.DnFuncMapId, 8, "");
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
objSQL = clsvDnFuncMapDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvDnFuncMapEN._CurrTabName, convDnFuncMap.DnFuncMapId, 8, strPrefix);
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
 objSQL = clsvDnFuncMapDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select DnFuncMapId from vDnFuncMap where " + strCondition;
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
 objSQL = clsvDnFuncMapDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select DnFuncMapId from vDnFuncMap where " + strCondition;
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
 objSQL = clsvDnFuncMapDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vDnFuncMap", "DnFuncMapId = " + "'"+ strDnFuncMapId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvDnFuncMapDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDnFuncMapDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vDnFuncMap", strCondition))
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
objSQL = clsvDnFuncMapDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vDnFuncMap");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvDnFuncMapENS">源对象</param>
 /// <param name = "objvDnFuncMapENT">目标对象</param>
public void CopyTo(clsvDnFuncMapEN objvDnFuncMapENS, clsvDnFuncMapEN objvDnFuncMapENT)
{
objvDnFuncMapENT.DnFuncMapId = objvDnFuncMapENS.DnFuncMapId; //函数映射Id
objvDnFuncMapENT.InDataNodeId = objvDnFuncMapENS.InDataNodeId; //In数据结点Id
objvDnFuncMapENT.OutDataNodeId = objvDnFuncMapENS.OutDataNodeId; //Out数据结点Id
objvDnFuncMapENT.AssociationMappingId = objvDnFuncMapENS.AssociationMappingId; //关联关系映射Id
objvDnFuncMapENT.AssociationMappingName = objvDnFuncMapENS.AssociationMappingName; //关联关系映射名
objvDnFuncMapENT.FuncMapModeId = objvDnFuncMapENS.FuncMapModeId; //函数映射模式Id
objvDnFuncMapENT.FuncMapModeName = objvDnFuncMapENS.FuncMapModeName; //函数映射模式名
objvDnFuncMapENT.TabId = objvDnFuncMapENS.TabId; //表ID
objvDnFuncMapENT.DnFunctionId = objvDnFuncMapENS.DnFunctionId; //DN函数Id
objvDnFuncMapENT.PrjId = objvDnFuncMapENS.PrjId; //工程Id
objvDnFuncMapENT.UpdDate = objvDnFuncMapENS.UpdDate; //修改日期
objvDnFuncMapENT.UpdUser = objvDnFuncMapENS.UpdUser; //修改者
objvDnFuncMapENT.Memo = objvDnFuncMapENS.Memo; //说明
objvDnFuncMapENT.InDataNodeName = objvDnFuncMapENS.InDataNodeName; //In数据结点名
objvDnFuncMapENT.OutDataNodeName = objvDnFuncMapENS.OutDataNodeName; //Out数据结点名
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvDnFuncMapEN objvDnFuncMapEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvDnFuncMapEN.DnFuncMapId, 8, convDnFuncMap.DnFuncMapId);
clsCheckSql.CheckFieldLen(objvDnFuncMapEN.AssociationMappingId, 2, convDnFuncMap.AssociationMappingId);
clsCheckSql.CheckFieldLen(objvDnFuncMapEN.AssociationMappingName, 50, convDnFuncMap.AssociationMappingName);
clsCheckSql.CheckFieldLen(objvDnFuncMapEN.FuncMapModeId, 2, convDnFuncMap.FuncMapModeId);
clsCheckSql.CheckFieldLen(objvDnFuncMapEN.FuncMapModeName, 50, convDnFuncMap.FuncMapModeName);
clsCheckSql.CheckFieldLen(objvDnFuncMapEN.TabId, 8, convDnFuncMap.TabId);
clsCheckSql.CheckFieldLen(objvDnFuncMapEN.DnFunctionId, 8, convDnFuncMap.DnFunctionId);
clsCheckSql.CheckFieldLen(objvDnFuncMapEN.PrjId, 4, convDnFuncMap.PrjId);
clsCheckSql.CheckFieldLen(objvDnFuncMapEN.UpdDate, 20, convDnFuncMap.UpdDate);
clsCheckSql.CheckFieldLen(objvDnFuncMapEN.UpdUser, 20, convDnFuncMap.UpdUser);
clsCheckSql.CheckFieldLen(objvDnFuncMapEN.Memo, 1000, convDnFuncMap.Memo);
clsCheckSql.CheckFieldLen(objvDnFuncMapEN.InDataNodeName, 100, convDnFuncMap.InDataNodeName);
clsCheckSql.CheckFieldLen(objvDnFuncMapEN.OutDataNodeName, 100, convDnFuncMap.OutDataNodeName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvDnFuncMapEN.DnFuncMapId, convDnFuncMap.DnFuncMapId);
clsCheckSql.CheckSqlInjection4Field(objvDnFuncMapEN.AssociationMappingId, convDnFuncMap.AssociationMappingId);
clsCheckSql.CheckSqlInjection4Field(objvDnFuncMapEN.AssociationMappingName, convDnFuncMap.AssociationMappingName);
clsCheckSql.CheckSqlInjection4Field(objvDnFuncMapEN.FuncMapModeId, convDnFuncMap.FuncMapModeId);
clsCheckSql.CheckSqlInjection4Field(objvDnFuncMapEN.FuncMapModeName, convDnFuncMap.FuncMapModeName);
clsCheckSql.CheckSqlInjection4Field(objvDnFuncMapEN.TabId, convDnFuncMap.TabId);
clsCheckSql.CheckSqlInjection4Field(objvDnFuncMapEN.DnFunctionId, convDnFuncMap.DnFunctionId);
clsCheckSql.CheckSqlInjection4Field(objvDnFuncMapEN.PrjId, convDnFuncMap.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvDnFuncMapEN.UpdDate, convDnFuncMap.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvDnFuncMapEN.UpdUser, convDnFuncMap.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvDnFuncMapEN.Memo, convDnFuncMap.Memo);
clsCheckSql.CheckSqlInjection4Field(objvDnFuncMapEN.InDataNodeName, convDnFuncMap.InDataNodeName);
clsCheckSql.CheckSqlInjection4Field(objvDnFuncMapEN.OutDataNodeName, convDnFuncMap.OutDataNodeName);
//检查外键字段长度
 objvDnFuncMapEN._IsCheckProperty = true;
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
 objSQL = clsvDnFuncMapDA.GetSpecSQLObj();
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
 objSQL = clsvDnFuncMapDA.GetSpecSQLObj();
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
 objSQL = clsvDnFuncMapDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvDnFuncMapEN._CurrTabName);
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
 objSQL = clsvDnFuncMapDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvDnFuncMapEN._CurrTabName, strCondition);
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
 objSQL = clsvDnFuncMapDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}