
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrimaryTypeDA
 表名:PrimaryType(00050020)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:01:52
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
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
 /// 主键类型(PrimaryType)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsPrimaryTypeDA : clsCommBase4DA
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
 return clsPrimaryTypeEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsPrimaryTypeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsPrimaryTypeEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsPrimaryTypeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsPrimaryTypeEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strPrimaryTypeId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strPrimaryTypeId)
{
strPrimaryTypeId = strPrimaryTypeId.Replace("'", "''");
if (strPrimaryTypeId.Length > 2)
{
throw new Exception("(errid:Data000001)在表:PrimaryType中,检查关键字,长度不正确!(clsPrimaryTypeDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strPrimaryTypeId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:PrimaryType中,关键字不能为空 或 null!(clsPrimaryTypeDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPrimaryTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsPrimaryTypeDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsPrimaryTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrimaryTypeDA.GetSpecSQLObj();
strSQL = "Select * from PrimaryType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_PrimaryType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsPrimaryTypeDA: GetDataTable_PrimaryType)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrimaryTypeDA.GetSpecSQLObj();
strSQL = "Select * from PrimaryType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsPrimaryTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrimaryTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsPrimaryTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrimaryTypeDA.GetSpecSQLObj();
strSQL = "Select * from PrimaryType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsPrimaryTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrimaryTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsPrimaryTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrimaryTypeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PrimaryType where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PrimaryType where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsPrimaryTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrimaryTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from PrimaryType where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsPrimaryTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrimaryTypeDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} PrimaryType.* " + 
$"from PrimaryType " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and PrimaryType.PrimaryTypeId not in " + 
$"(Select top {intTop_In} PrimaryType.PrimaryTypeId from PrimaryType " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PrimaryType where {1} and PrimaryTypeId not in (Select top {2} PrimaryTypeId from PrimaryType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PrimaryType where {1} and PrimaryTypeId not in (Select top {3} PrimaryTypeId from PrimaryType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsPrimaryTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrimaryTypeDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} PrimaryType.* " + 
$"from PrimaryType " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and PrimaryType.PrimaryTypeId not in " + 
$"(Select top {intTop_In} PrimaryType.PrimaryTypeId from PrimaryType " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PrimaryType where {1} and PrimaryTypeId not in (Select top {2} PrimaryTypeId from PrimaryType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PrimaryType where {1} and PrimaryTypeId not in (Select top {3} PrimaryTypeId from PrimaryType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsPrimaryTypeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsPrimaryTypeDA:GetObjLst)", objException.Message));
}
List<clsPrimaryTypeEN> arrObjLst = new List<clsPrimaryTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrimaryTypeDA.GetSpecSQLObj();
strSQL = "Select * from PrimaryType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrimaryTypeEN objPrimaryTypeEN = new clsPrimaryTypeEN();
try
{
objPrimaryTypeEN.PrimaryTypeId = objRow[conPrimaryType.PrimaryTypeId].ToString().Trim(); //主键类型ID
objPrimaryTypeEN.PrimaryTypeName = objRow[conPrimaryType.PrimaryTypeName].ToString().Trim(); //主键类型名
objPrimaryTypeEN.PrimaryTypeENName = objRow[conPrimaryType.PrimaryTypeENName] == DBNull.Value ? null : objRow[conPrimaryType.PrimaryTypeENName].ToString().Trim(); //主键类型英文名
objPrimaryTypeEN.OrderNum = objRow[conPrimaryType.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPrimaryType.OrderNum].ToString().Trim()); //序号
objPrimaryTypeEN.Memo = objRow[conPrimaryType.Memo] == DBNull.Value ? null : objRow[conPrimaryType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsPrimaryTypeDA: GetObjLst)", objException.Message));
}
objPrimaryTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objPrimaryTypeEN);
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
public List<clsPrimaryTypeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsPrimaryTypeDA:GetObjLstByTabName)", objException.Message));
}
List<clsPrimaryTypeEN> arrObjLst = new List<clsPrimaryTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrimaryTypeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrimaryTypeEN objPrimaryTypeEN = new clsPrimaryTypeEN();
try
{
objPrimaryTypeEN.PrimaryTypeId = objRow[conPrimaryType.PrimaryTypeId].ToString().Trim(); //主键类型ID
objPrimaryTypeEN.PrimaryTypeName = objRow[conPrimaryType.PrimaryTypeName].ToString().Trim(); //主键类型名
objPrimaryTypeEN.PrimaryTypeENName = objRow[conPrimaryType.PrimaryTypeENName] == DBNull.Value ? null : objRow[conPrimaryType.PrimaryTypeENName].ToString().Trim(); //主键类型英文名
objPrimaryTypeEN.OrderNum = objRow[conPrimaryType.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPrimaryType.OrderNum].ToString().Trim()); //序号
objPrimaryTypeEN.Memo = objRow[conPrimaryType.Memo] == DBNull.Value ? null : objRow[conPrimaryType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsPrimaryTypeDA: GetObjLst)", objException.Message));
}
objPrimaryTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objPrimaryTypeEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objPrimaryTypeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetPrimaryType(ref clsPrimaryTypeEN objPrimaryTypeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrimaryTypeDA.GetSpecSQLObj();
strSQL = "Select * from PrimaryType where PrimaryTypeId = " + "'"+ objPrimaryTypeEN.PrimaryTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objPrimaryTypeEN.PrimaryTypeId = objDT.Rows[0][conPrimaryType.PrimaryTypeId].ToString().Trim(); //主键类型ID(字段类型:char,字段长度:2,是否可空:False)
 objPrimaryTypeEN.PrimaryTypeName = objDT.Rows[0][conPrimaryType.PrimaryTypeName].ToString().Trim(); //主键类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objPrimaryTypeEN.PrimaryTypeENName = objDT.Rows[0][conPrimaryType.PrimaryTypeENName].ToString().Trim(); //主键类型英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objPrimaryTypeEN.OrderNum = TransNullToInt(objDT.Rows[0][conPrimaryType.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objPrimaryTypeEN.Memo = objDT.Rows[0][conPrimaryType.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsPrimaryTypeDA: GetPrimaryType)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strPrimaryTypeId">表关键字</param>
 /// <returns>表对象</returns>
public clsPrimaryTypeEN GetObjByPrimaryTypeId(string strPrimaryTypeId)
{
CheckPrimaryKey(strPrimaryTypeId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrimaryTypeDA.GetSpecSQLObj();
strSQL = "Select * from PrimaryType where PrimaryTypeId = " + "'"+ strPrimaryTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsPrimaryTypeEN objPrimaryTypeEN = new clsPrimaryTypeEN();
try
{
 objPrimaryTypeEN.PrimaryTypeId = objRow[conPrimaryType.PrimaryTypeId].ToString().Trim(); //主键类型ID(字段类型:char,字段长度:2,是否可空:False)
 objPrimaryTypeEN.PrimaryTypeName = objRow[conPrimaryType.PrimaryTypeName].ToString().Trim(); //主键类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objPrimaryTypeEN.PrimaryTypeENName = objRow[conPrimaryType.PrimaryTypeENName] == DBNull.Value ? null : objRow[conPrimaryType.PrimaryTypeENName].ToString().Trim(); //主键类型英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objPrimaryTypeEN.OrderNum = objRow[conPrimaryType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPrimaryType.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objPrimaryTypeEN.Memo = objRow[conPrimaryType.Memo] == DBNull.Value ? null : objRow[conPrimaryType.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsPrimaryTypeDA: GetObjByPrimaryTypeId)", objException.Message));
}
return objPrimaryTypeEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsPrimaryTypeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsPrimaryTypeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrimaryTypeDA.GetSpecSQLObj();
strSQL = "Select * from PrimaryType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsPrimaryTypeEN objPrimaryTypeEN = new clsPrimaryTypeEN()
{
PrimaryTypeId = objRow[conPrimaryType.PrimaryTypeId].ToString().Trim(), //主键类型ID
PrimaryTypeName = objRow[conPrimaryType.PrimaryTypeName].ToString().Trim(), //主键类型名
PrimaryTypeENName = objRow[conPrimaryType.PrimaryTypeENName] == DBNull.Value ? null : objRow[conPrimaryType.PrimaryTypeENName].ToString().Trim(), //主键类型英文名
OrderNum = objRow[conPrimaryType.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPrimaryType.OrderNum].ToString().Trim()), //序号
Memo = objRow[conPrimaryType.Memo] == DBNull.Value ? null : objRow[conPrimaryType.Memo].ToString().Trim() //说明
};
objPrimaryTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPrimaryTypeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsPrimaryTypeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsPrimaryTypeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsPrimaryTypeEN objPrimaryTypeEN = new clsPrimaryTypeEN();
try
{
objPrimaryTypeEN.PrimaryTypeId = objRow[conPrimaryType.PrimaryTypeId].ToString().Trim(); //主键类型ID
objPrimaryTypeEN.PrimaryTypeName = objRow[conPrimaryType.PrimaryTypeName].ToString().Trim(); //主键类型名
objPrimaryTypeEN.PrimaryTypeENName = objRow[conPrimaryType.PrimaryTypeENName] == DBNull.Value ? null : objRow[conPrimaryType.PrimaryTypeENName].ToString().Trim(); //主键类型英文名
objPrimaryTypeEN.OrderNum = objRow[conPrimaryType.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPrimaryType.OrderNum].ToString().Trim()); //序号
objPrimaryTypeEN.Memo = objRow[conPrimaryType.Memo] == DBNull.Value ? null : objRow[conPrimaryType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsPrimaryTypeDA: GetObjByDataRowPrimaryType)", objException.Message));
}
objPrimaryTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPrimaryTypeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsPrimaryTypeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsPrimaryTypeEN objPrimaryTypeEN = new clsPrimaryTypeEN();
try
{
objPrimaryTypeEN.PrimaryTypeId = objRow[conPrimaryType.PrimaryTypeId].ToString().Trim(); //主键类型ID
objPrimaryTypeEN.PrimaryTypeName = objRow[conPrimaryType.PrimaryTypeName].ToString().Trim(); //主键类型名
objPrimaryTypeEN.PrimaryTypeENName = objRow[conPrimaryType.PrimaryTypeENName] == DBNull.Value ? null : objRow[conPrimaryType.PrimaryTypeENName].ToString().Trim(); //主键类型英文名
objPrimaryTypeEN.OrderNum = objRow[conPrimaryType.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPrimaryType.OrderNum].ToString().Trim()); //序号
objPrimaryTypeEN.Memo = objRow[conPrimaryType.Memo] == DBNull.Value ? null : objRow[conPrimaryType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsPrimaryTypeDA: GetObjByDataRow)", objException.Message));
}
objPrimaryTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPrimaryTypeEN;
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
objSQL = clsPrimaryTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsPrimaryTypeEN._CurrTabName, conPrimaryType.PrimaryTypeId, 2, "");
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
objSQL = clsPrimaryTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsPrimaryTypeEN._CurrTabName, conPrimaryType.PrimaryTypeId, 2, strPrefix);
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
 objSQL = clsPrimaryTypeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select PrimaryTypeId from PrimaryType where " + strCondition;
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
 objSQL = clsPrimaryTypeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select PrimaryTypeId from PrimaryType where " + strCondition;
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
 /// <param name = "strPrimaryTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strPrimaryTypeId)
{
CheckPrimaryKey(strPrimaryTypeId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrimaryTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("PrimaryType", "PrimaryTypeId = " + "'"+ strPrimaryTypeId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsPrimaryTypeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrimaryTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("PrimaryType", strCondition))
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
objSQL = clsPrimaryTypeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("PrimaryType");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsPrimaryTypeEN objPrimaryTypeEN)
 {
 if (objPrimaryTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPrimaryTypeEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrimaryTypeDA.GetSpecSQLObj();
strSQL = "Select * from PrimaryType where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "PrimaryType");
objRow = objDS.Tables["PrimaryType"].NewRow();
objRow[conPrimaryType.PrimaryTypeId] = objPrimaryTypeEN.PrimaryTypeId; //主键类型ID
objRow[conPrimaryType.PrimaryTypeName] = objPrimaryTypeEN.PrimaryTypeName; //主键类型名
 if (objPrimaryTypeEN.PrimaryTypeENName !=  "")
 {
objRow[conPrimaryType.PrimaryTypeENName] = objPrimaryTypeEN.PrimaryTypeENName; //主键类型英文名
 }
objRow[conPrimaryType.OrderNum] = objPrimaryTypeEN.OrderNum; //序号
 if (objPrimaryTypeEN.Memo !=  "")
 {
objRow[conPrimaryType.Memo] = objPrimaryTypeEN.Memo; //说明
 }
objDS.Tables[clsPrimaryTypeEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsPrimaryTypeEN._CurrTabName);
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
 /// <param name = "objPrimaryTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsPrimaryTypeEN objPrimaryTypeEN)
{
 if (objPrimaryTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPrimaryTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objPrimaryTypeEN.PrimaryTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrimaryType.PrimaryTypeId);
 var strPrimaryTypeId = objPrimaryTypeEN.PrimaryTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrimaryTypeId + "'");
 }
 
 if (objPrimaryTypeEN.PrimaryTypeName !=  null)
 {
 arrFieldListForInsert.Add(conPrimaryType.PrimaryTypeName);
 var strPrimaryTypeName = objPrimaryTypeEN.PrimaryTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrimaryTypeName + "'");
 }
 
 if (objPrimaryTypeEN.PrimaryTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conPrimaryType.PrimaryTypeENName);
 var strPrimaryTypeENName = objPrimaryTypeEN.PrimaryTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrimaryTypeENName + "'");
 }
 
 if (objPrimaryTypeEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conPrimaryType.OrderNum);
 arrValueListForInsert.Add(objPrimaryTypeEN.OrderNum.ToString());
 }
 
 if (objPrimaryTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPrimaryType.Memo);
 var strMemo = objPrimaryTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PrimaryType");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrimaryTypeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objPrimaryTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsPrimaryTypeEN objPrimaryTypeEN)
{
 if (objPrimaryTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPrimaryTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objPrimaryTypeEN.PrimaryTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrimaryType.PrimaryTypeId);
 var strPrimaryTypeId = objPrimaryTypeEN.PrimaryTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrimaryTypeId + "'");
 }
 
 if (objPrimaryTypeEN.PrimaryTypeName !=  null)
 {
 arrFieldListForInsert.Add(conPrimaryType.PrimaryTypeName);
 var strPrimaryTypeName = objPrimaryTypeEN.PrimaryTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrimaryTypeName + "'");
 }
 
 if (objPrimaryTypeEN.PrimaryTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conPrimaryType.PrimaryTypeENName);
 var strPrimaryTypeENName = objPrimaryTypeEN.PrimaryTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrimaryTypeENName + "'");
 }
 
 if (objPrimaryTypeEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conPrimaryType.OrderNum);
 arrValueListForInsert.Add(objPrimaryTypeEN.OrderNum.ToString());
 }
 
 if (objPrimaryTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPrimaryType.Memo);
 var strMemo = objPrimaryTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PrimaryType");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrimaryTypeDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objPrimaryTypeEN.PrimaryTypeId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objPrimaryTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsPrimaryTypeEN objPrimaryTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objPrimaryTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPrimaryTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objPrimaryTypeEN.PrimaryTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrimaryType.PrimaryTypeId);
 var strPrimaryTypeId = objPrimaryTypeEN.PrimaryTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrimaryTypeId + "'");
 }
 
 if (objPrimaryTypeEN.PrimaryTypeName !=  null)
 {
 arrFieldListForInsert.Add(conPrimaryType.PrimaryTypeName);
 var strPrimaryTypeName = objPrimaryTypeEN.PrimaryTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrimaryTypeName + "'");
 }
 
 if (objPrimaryTypeEN.PrimaryTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conPrimaryType.PrimaryTypeENName);
 var strPrimaryTypeENName = objPrimaryTypeEN.PrimaryTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrimaryTypeENName + "'");
 }
 
 if (objPrimaryTypeEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conPrimaryType.OrderNum);
 arrValueListForInsert.Add(objPrimaryTypeEN.OrderNum.ToString());
 }
 
 if (objPrimaryTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPrimaryType.Memo);
 var strMemo = objPrimaryTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PrimaryType");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrimaryTypeDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objPrimaryTypeEN.PrimaryTypeId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objPrimaryTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsPrimaryTypeEN objPrimaryTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objPrimaryTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPrimaryTypeEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objPrimaryTypeEN.PrimaryTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrimaryType.PrimaryTypeId);
 var strPrimaryTypeId = objPrimaryTypeEN.PrimaryTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrimaryTypeId + "'");
 }
 
 if (objPrimaryTypeEN.PrimaryTypeName !=  null)
 {
 arrFieldListForInsert.Add(conPrimaryType.PrimaryTypeName);
 var strPrimaryTypeName = objPrimaryTypeEN.PrimaryTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrimaryTypeName + "'");
 }
 
 if (objPrimaryTypeEN.PrimaryTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conPrimaryType.PrimaryTypeENName);
 var strPrimaryTypeENName = objPrimaryTypeEN.PrimaryTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrimaryTypeENName + "'");
 }
 
 if (objPrimaryTypeEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conPrimaryType.OrderNum);
 arrValueListForInsert.Add(objPrimaryTypeEN.OrderNum.ToString());
 }
 
 if (objPrimaryTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPrimaryType.Memo);
 var strMemo = objPrimaryTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PrimaryType");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrimaryTypeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewPrimaryTypes(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrimaryTypeDA.GetSpecSQLObj();
strSQL = "Select * from PrimaryType where PrimaryTypeId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "PrimaryType");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strPrimaryTypeId = oRow[conPrimaryType.PrimaryTypeId].ToString().Trim();
if (IsExist(strPrimaryTypeId))
{
 string strResult = "关键字变量值为:" + string.Format("PrimaryTypeId = {0}", strPrimaryTypeId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsPrimaryTypeEN._CurrTabName ].NewRow();
objRow[conPrimaryType.PrimaryTypeId] = oRow[conPrimaryType.PrimaryTypeId].ToString().Trim(); //主键类型ID
objRow[conPrimaryType.PrimaryTypeName] = oRow[conPrimaryType.PrimaryTypeName].ToString().Trim(); //主键类型名
objRow[conPrimaryType.PrimaryTypeENName] = oRow[conPrimaryType.PrimaryTypeENName].ToString().Trim(); //主键类型英文名
objRow[conPrimaryType.OrderNum] = oRow[conPrimaryType.OrderNum].ToString().Trim(); //序号
objRow[conPrimaryType.Memo] = oRow[conPrimaryType.Memo].ToString().Trim(); //说明
 objDS.Tables[clsPrimaryTypeEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsPrimaryTypeEN._CurrTabName);
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
 /// <param name = "objPrimaryTypeEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsPrimaryTypeEN objPrimaryTypeEN)
{
 if (objPrimaryTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrimaryTypeEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrimaryTypeDA.GetSpecSQLObj();
strSQL = "Select * from PrimaryType where PrimaryTypeId = " + "'"+ objPrimaryTypeEN.PrimaryTypeId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsPrimaryTypeEN._CurrTabName);
if (objDS.Tables[clsPrimaryTypeEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:PrimaryTypeId = " + "'"+ objPrimaryTypeEN.PrimaryTypeId+"'");
return false;
}
objRow = objDS.Tables[clsPrimaryTypeEN._CurrTabName].Rows[0];
 if (objPrimaryTypeEN.IsUpdated(conPrimaryType.PrimaryTypeId))
 {
objRow[conPrimaryType.PrimaryTypeId] = objPrimaryTypeEN.PrimaryTypeId; //主键类型ID
 }
 if (objPrimaryTypeEN.IsUpdated(conPrimaryType.PrimaryTypeName))
 {
objRow[conPrimaryType.PrimaryTypeName] = objPrimaryTypeEN.PrimaryTypeName; //主键类型名
 }
 if (objPrimaryTypeEN.IsUpdated(conPrimaryType.PrimaryTypeENName))
 {
objRow[conPrimaryType.PrimaryTypeENName] = objPrimaryTypeEN.PrimaryTypeENName; //主键类型英文名
 }
 if (objPrimaryTypeEN.IsUpdated(conPrimaryType.OrderNum))
 {
objRow[conPrimaryType.OrderNum] = objPrimaryTypeEN.OrderNum; //序号
 }
 if (objPrimaryTypeEN.IsUpdated(conPrimaryType.Memo))
 {
objRow[conPrimaryType.Memo] = objPrimaryTypeEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsPrimaryTypeEN._CurrTabName);
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
 /// <param name = "objPrimaryTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsPrimaryTypeEN objPrimaryTypeEN)
{
 if (objPrimaryTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrimaryTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrimaryTypeDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update PrimaryType Set ");
 
 if (objPrimaryTypeEN.IsUpdated(conPrimaryType.PrimaryTypeName))
 {
 if (objPrimaryTypeEN.PrimaryTypeName !=  null)
 {
 var strPrimaryTypeName = objPrimaryTypeEN.PrimaryTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrimaryTypeName, conPrimaryType.PrimaryTypeName); //主键类型名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrimaryType.PrimaryTypeName); //主键类型名
 }
 }
 
 if (objPrimaryTypeEN.IsUpdated(conPrimaryType.PrimaryTypeENName))
 {
 if (objPrimaryTypeEN.PrimaryTypeENName !=  null)
 {
 var strPrimaryTypeENName = objPrimaryTypeEN.PrimaryTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrimaryTypeENName, conPrimaryType.PrimaryTypeENName); //主键类型英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrimaryType.PrimaryTypeENName); //主键类型英文名
 }
 }
 
 if (objPrimaryTypeEN.IsUpdated(conPrimaryType.OrderNum))
 {
 if (objPrimaryTypeEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPrimaryTypeEN.OrderNum, conPrimaryType.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrimaryType.OrderNum); //序号
 }
 }
 
 if (objPrimaryTypeEN.IsUpdated(conPrimaryType.Memo))
 {
 if (objPrimaryTypeEN.Memo !=  null)
 {
 var strMemo = objPrimaryTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conPrimaryType.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrimaryType.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where PrimaryTypeId = '{0}'", objPrimaryTypeEN.PrimaryTypeId); 
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
 /// <param name = "objPrimaryTypeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsPrimaryTypeEN objPrimaryTypeEN, string strCondition)
{
 if (objPrimaryTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrimaryTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrimaryTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PrimaryType Set ");
 
 if (objPrimaryTypeEN.IsUpdated(conPrimaryType.PrimaryTypeName))
 {
 if (objPrimaryTypeEN.PrimaryTypeName !=  null)
 {
 var strPrimaryTypeName = objPrimaryTypeEN.PrimaryTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrimaryTypeName = '{0}',", strPrimaryTypeName); //主键类型名
 }
 else
 {
 sbSQL.Append(" PrimaryTypeName = null,"); //主键类型名
 }
 }
 
 if (objPrimaryTypeEN.IsUpdated(conPrimaryType.PrimaryTypeENName))
 {
 if (objPrimaryTypeEN.PrimaryTypeENName !=  null)
 {
 var strPrimaryTypeENName = objPrimaryTypeEN.PrimaryTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrimaryTypeENName = '{0}',", strPrimaryTypeENName); //主键类型英文名
 }
 else
 {
 sbSQL.Append(" PrimaryTypeENName = null,"); //主键类型英文名
 }
 }
 
 if (objPrimaryTypeEN.IsUpdated(conPrimaryType.OrderNum))
 {
 if (objPrimaryTypeEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPrimaryTypeEN.OrderNum, conPrimaryType.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrimaryType.OrderNum); //序号
 }
 }
 
 if (objPrimaryTypeEN.IsUpdated(conPrimaryType.Memo))
 {
 if (objPrimaryTypeEN.Memo !=  null)
 {
 var strMemo = objPrimaryTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objPrimaryTypeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsPrimaryTypeEN objPrimaryTypeEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objPrimaryTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrimaryTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrimaryTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PrimaryType Set ");
 
 if (objPrimaryTypeEN.IsUpdated(conPrimaryType.PrimaryTypeName))
 {
 if (objPrimaryTypeEN.PrimaryTypeName !=  null)
 {
 var strPrimaryTypeName = objPrimaryTypeEN.PrimaryTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrimaryTypeName = '{0}',", strPrimaryTypeName); //主键类型名
 }
 else
 {
 sbSQL.Append(" PrimaryTypeName = null,"); //主键类型名
 }
 }
 
 if (objPrimaryTypeEN.IsUpdated(conPrimaryType.PrimaryTypeENName))
 {
 if (objPrimaryTypeEN.PrimaryTypeENName !=  null)
 {
 var strPrimaryTypeENName = objPrimaryTypeEN.PrimaryTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrimaryTypeENName = '{0}',", strPrimaryTypeENName); //主键类型英文名
 }
 else
 {
 sbSQL.Append(" PrimaryTypeENName = null,"); //主键类型英文名
 }
 }
 
 if (objPrimaryTypeEN.IsUpdated(conPrimaryType.OrderNum))
 {
 if (objPrimaryTypeEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPrimaryTypeEN.OrderNum, conPrimaryType.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrimaryType.OrderNum); //序号
 }
 }
 
 if (objPrimaryTypeEN.IsUpdated(conPrimaryType.Memo))
 {
 if (objPrimaryTypeEN.Memo !=  null)
 {
 var strMemo = objPrimaryTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objPrimaryTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsPrimaryTypeEN objPrimaryTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objPrimaryTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrimaryTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrimaryTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PrimaryType Set ");
 
 if (objPrimaryTypeEN.IsUpdated(conPrimaryType.PrimaryTypeName))
 {
 if (objPrimaryTypeEN.PrimaryTypeName !=  null)
 {
 var strPrimaryTypeName = objPrimaryTypeEN.PrimaryTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrimaryTypeName, conPrimaryType.PrimaryTypeName); //主键类型名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrimaryType.PrimaryTypeName); //主键类型名
 }
 }
 
 if (objPrimaryTypeEN.IsUpdated(conPrimaryType.PrimaryTypeENName))
 {
 if (objPrimaryTypeEN.PrimaryTypeENName !=  null)
 {
 var strPrimaryTypeENName = objPrimaryTypeEN.PrimaryTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrimaryTypeENName, conPrimaryType.PrimaryTypeENName); //主键类型英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrimaryType.PrimaryTypeENName); //主键类型英文名
 }
 }
 
 if (objPrimaryTypeEN.IsUpdated(conPrimaryType.OrderNum))
 {
 if (objPrimaryTypeEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPrimaryTypeEN.OrderNum, conPrimaryType.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrimaryType.OrderNum); //序号
 }
 }
 
 if (objPrimaryTypeEN.IsUpdated(conPrimaryType.Memo))
 {
 if (objPrimaryTypeEN.Memo !=  null)
 {
 var strMemo = objPrimaryTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conPrimaryType.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrimaryType.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where PrimaryTypeId = '{0}'", objPrimaryTypeEN.PrimaryTypeId); 
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
 /// <param name = "strPrimaryTypeId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strPrimaryTypeId) 
{
CheckPrimaryKey(strPrimaryTypeId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrimaryTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strPrimaryTypeId,
};
 objSQL.ExecSP("PrimaryType_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strPrimaryTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strPrimaryTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strPrimaryTypeId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrimaryTypeDA.GetSpecSQLObj();
//删除PrimaryType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PrimaryType where PrimaryTypeId = " + "'"+ strPrimaryTypeId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelPrimaryType(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrimaryTypeDA.GetSpecSQLObj();
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
//删除PrimaryType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PrimaryType where PrimaryTypeId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strPrimaryTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strPrimaryTypeId) 
{
CheckPrimaryKey(strPrimaryTypeId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrimaryTypeDA.GetSpecSQLObj();
//删除PrimaryType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PrimaryType where PrimaryTypeId = " + "'"+ strPrimaryTypeId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelPrimaryType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsPrimaryTypeDA: DelPrimaryType)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrimaryTypeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from PrimaryType where " + strCondition ;
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
public bool DelPrimaryTypeWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsPrimaryTypeDA: DelPrimaryTypeWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrimaryTypeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from PrimaryType where " + strCondition ;
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
 /// <param name = "objPrimaryTypeENS">源对象</param>
 /// <param name = "objPrimaryTypeENT">目标对象</param>
public void CopyTo(clsPrimaryTypeEN objPrimaryTypeENS, clsPrimaryTypeEN objPrimaryTypeENT)
{
objPrimaryTypeENT.PrimaryTypeId = objPrimaryTypeENS.PrimaryTypeId; //主键类型ID
objPrimaryTypeENT.PrimaryTypeName = objPrimaryTypeENS.PrimaryTypeName; //主键类型名
objPrimaryTypeENT.PrimaryTypeENName = objPrimaryTypeENS.PrimaryTypeENName; //主键类型英文名
objPrimaryTypeENT.OrderNum = objPrimaryTypeENS.OrderNum; //序号
objPrimaryTypeENT.Memo = objPrimaryTypeENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsPrimaryTypeEN objPrimaryTypeEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objPrimaryTypeEN.PrimaryTypeName, conPrimaryType.PrimaryTypeName);
//检查字段长度
clsCheckSql.CheckFieldLen(objPrimaryTypeEN.PrimaryTypeId, 2, conPrimaryType.PrimaryTypeId);
clsCheckSql.CheckFieldLen(objPrimaryTypeEN.PrimaryTypeName, 30, conPrimaryType.PrimaryTypeName);
clsCheckSql.CheckFieldLen(objPrimaryTypeEN.PrimaryTypeENName, 50, conPrimaryType.PrimaryTypeENName);
clsCheckSql.CheckFieldLen(objPrimaryTypeEN.Memo, 1000, conPrimaryType.Memo);
//检查字段外键固定长度
 objPrimaryTypeEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsPrimaryTypeEN objPrimaryTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objPrimaryTypeEN.PrimaryTypeName, 30, conPrimaryType.PrimaryTypeName);
clsCheckSql.CheckFieldLen(objPrimaryTypeEN.PrimaryTypeENName, 50, conPrimaryType.PrimaryTypeENName);
clsCheckSql.CheckFieldLen(objPrimaryTypeEN.Memo, 1000, conPrimaryType.Memo);
//检查外键字段长度
 objPrimaryTypeEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsPrimaryTypeEN objPrimaryTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objPrimaryTypeEN.PrimaryTypeId, 2, conPrimaryType.PrimaryTypeId);
clsCheckSql.CheckFieldLen(objPrimaryTypeEN.PrimaryTypeName, 30, conPrimaryType.PrimaryTypeName);
clsCheckSql.CheckFieldLen(objPrimaryTypeEN.PrimaryTypeENName, 50, conPrimaryType.PrimaryTypeENName);
clsCheckSql.CheckFieldLen(objPrimaryTypeEN.Memo, 1000, conPrimaryType.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objPrimaryTypeEN.PrimaryTypeId, conPrimaryType.PrimaryTypeId);
clsCheckSql.CheckSqlInjection4Field(objPrimaryTypeEN.PrimaryTypeName, conPrimaryType.PrimaryTypeName);
clsCheckSql.CheckSqlInjection4Field(objPrimaryTypeEN.PrimaryTypeENName, conPrimaryType.PrimaryTypeENName);
clsCheckSql.CheckSqlInjection4Field(objPrimaryTypeEN.Memo, conPrimaryType.Memo);
//检查外键字段长度
 objPrimaryTypeEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetPrimaryTypeId()
{
//获取某学院所有专业信息
string strSQL = "select PrimaryTypeId, PrimaryTypeName from PrimaryType ";
 clsSpecSQLforSql mySql = clsPrimaryTypeDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

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
 objSQL = clsPrimaryTypeDA.GetSpecSQLObj();
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
 objSQL = clsPrimaryTypeDA.GetSpecSQLObj();
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
 objSQL = clsPrimaryTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsPrimaryTypeEN._CurrTabName);
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
 objSQL = clsPrimaryTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsPrimaryTypeEN._CurrTabName, strCondition);
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
 objSQL = clsPrimaryTypeDA.GetSpecSQLObj();
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
 objSQL = clsPrimaryTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}