
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDnFunctionDA
 表名:DnFunction(00050552)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:27:37
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
 /// 数据结点函数(DnFunction)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsDnFunctionDA : clsCommBase4DA
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
 return clsDnFunctionEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsDnFunctionEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsDnFunctionEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsDnFunctionEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsDnFunctionEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strDnFunctionId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strDnFunctionId)
{
strDnFunctionId = strDnFunctionId.Replace("'", "''");
if (strDnFunctionId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:DnFunction中,检查关键字,长度不正确!(clsDnFunctionDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strDnFunctionId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:DnFunction中,关键字不能为空 或 null!(clsDnFunctionDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strDnFunctionId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsDnFunctionDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsDnFunctionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFunctionDA.GetSpecSQLObj();
strSQL = "Select * from DnFunction where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_DnFunction(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsDnFunctionDA: GetDataTable_DnFunction)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFunctionDA.GetSpecSQLObj();
strSQL = "Select * from DnFunction where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsDnFunctionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFunctionDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsDnFunctionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFunctionDA.GetSpecSQLObj();
strSQL = "Select * from DnFunction where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsDnFunctionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFunctionDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsDnFunctionDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFunctionDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from DnFunction where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from DnFunction where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsDnFunctionDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFunctionDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from DnFunction where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsDnFunctionDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFunctionDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} DnFunction.* " + 
$"from DnFunction " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and DnFunction.DnFunctionId not in " + 
$"(Select top {intTop_In} DnFunction.DnFunctionId from DnFunction " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from DnFunction where {1} and DnFunctionId not in (Select top {2} DnFunctionId from DnFunction where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from DnFunction where {1} and DnFunctionId not in (Select top {3} DnFunctionId from DnFunction where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsDnFunctionDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFunctionDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} DnFunction.* " + 
$"from DnFunction " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and DnFunction.DnFunctionId not in " + 
$"(Select top {intTop_In} DnFunction.DnFunctionId from DnFunction " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from DnFunction where {1} and DnFunctionId not in (Select top {2} DnFunctionId from DnFunction where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from DnFunction where {1} and DnFunctionId not in (Select top {3} DnFunctionId from DnFunction where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsDnFunctionEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsDnFunctionDA:GetObjLst)", objException.Message));
}
List<clsDnFunctionEN> arrObjLst = new List<clsDnFunctionEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFunctionDA.GetSpecSQLObj();
strSQL = "Select * from DnFunction where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDnFunctionEN objDnFunctionEN = new clsDnFunctionEN();
try
{
objDnFunctionEN.DnFunctionId = objRow[conDnFunction.DnFunctionId].ToString().Trim(); //DN函数Id
objDnFunctionEN.DnFunctionName = objRow[conDnFunction.DnFunctionName] == DBNull.Value ? null : objRow[conDnFunction.DnFunctionName].ToString().Trim(); //DN函数
objDnFunctionEN.AssociationMappingId = objRow[conDnFunction.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objDnFunctionEN.ImportClass = objRow[conDnFunction.ImportClass] == DBNull.Value ? null : objRow[conDnFunction.ImportClass].ToString().Trim(); //导入类
objDnFunctionEN.ImportPath = objRow[conDnFunction.ImportPath] == DBNull.Value ? null : objRow[conDnFunction.ImportPath].ToString().Trim(); //导入路径
objDnFunctionEN.PrjId = objRow[conDnFunction.PrjId].ToString().Trim(); //工程Id
objDnFunctionEN.UpdDate = objRow[conDnFunction.UpdDate] == DBNull.Value ? null : objRow[conDnFunction.UpdDate].ToString().Trim(); //修改日期
objDnFunctionEN.UpdUser = objRow[conDnFunction.UpdUser] == DBNull.Value ? null : objRow[conDnFunction.UpdUser].ToString().Trim(); //修改者
objDnFunctionEN.Memo = objRow[conDnFunction.Memo] == DBNull.Value ? null : objRow[conDnFunction.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsDnFunctionDA: GetObjLst)", objException.Message));
}
objDnFunctionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objDnFunctionEN);
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
public List<clsDnFunctionEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsDnFunctionDA:GetObjLstByTabName)", objException.Message));
}
List<clsDnFunctionEN> arrObjLst = new List<clsDnFunctionEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFunctionDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDnFunctionEN objDnFunctionEN = new clsDnFunctionEN();
try
{
objDnFunctionEN.DnFunctionId = objRow[conDnFunction.DnFunctionId].ToString().Trim(); //DN函数Id
objDnFunctionEN.DnFunctionName = objRow[conDnFunction.DnFunctionName] == DBNull.Value ? null : objRow[conDnFunction.DnFunctionName].ToString().Trim(); //DN函数
objDnFunctionEN.AssociationMappingId = objRow[conDnFunction.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objDnFunctionEN.ImportClass = objRow[conDnFunction.ImportClass] == DBNull.Value ? null : objRow[conDnFunction.ImportClass].ToString().Trim(); //导入类
objDnFunctionEN.ImportPath = objRow[conDnFunction.ImportPath] == DBNull.Value ? null : objRow[conDnFunction.ImportPath].ToString().Trim(); //导入路径
objDnFunctionEN.PrjId = objRow[conDnFunction.PrjId].ToString().Trim(); //工程Id
objDnFunctionEN.UpdDate = objRow[conDnFunction.UpdDate] == DBNull.Value ? null : objRow[conDnFunction.UpdDate].ToString().Trim(); //修改日期
objDnFunctionEN.UpdUser = objRow[conDnFunction.UpdUser] == DBNull.Value ? null : objRow[conDnFunction.UpdUser].ToString().Trim(); //修改者
objDnFunctionEN.Memo = objRow[conDnFunction.Memo] == DBNull.Value ? null : objRow[conDnFunction.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsDnFunctionDA: GetObjLst)", objException.Message));
}
objDnFunctionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objDnFunctionEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objDnFunctionEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetDnFunction(ref clsDnFunctionEN objDnFunctionEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFunctionDA.GetSpecSQLObj();
strSQL = "Select * from DnFunction where DnFunctionId = " + "'"+ objDnFunctionEN.DnFunctionId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objDnFunctionEN.DnFunctionId = objDT.Rows[0][conDnFunction.DnFunctionId].ToString().Trim(); //DN函数Id(字段类型:char,字段长度:8,是否可空:True)
 objDnFunctionEN.DnFunctionName = objDT.Rows[0][conDnFunction.DnFunctionName].ToString().Trim(); //DN函数(字段类型:varchar,字段长度:50,是否可空:True)
 objDnFunctionEN.AssociationMappingId = objDT.Rows[0][conDnFunction.AssociationMappingId].ToString().Trim(); //关联关系映射Id(字段类型:char,字段长度:2,是否可空:True)
 objDnFunctionEN.ImportClass = objDT.Rows[0][conDnFunction.ImportClass].ToString().Trim(); //导入类(字段类型:varchar,字段长度:50,是否可空:True)
 objDnFunctionEN.ImportPath = objDT.Rows[0][conDnFunction.ImportPath].ToString().Trim(); //导入路径(字段类型:varchar,字段长度:100,是否可空:True)
 objDnFunctionEN.PrjId = objDT.Rows[0][conDnFunction.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objDnFunctionEN.UpdDate = objDT.Rows[0][conDnFunction.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objDnFunctionEN.UpdUser = objDT.Rows[0][conDnFunction.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objDnFunctionEN.Memo = objDT.Rows[0][conDnFunction.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsDnFunctionDA: GetDnFunction)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strDnFunctionId">表关键字</param>
 /// <returns>表对象</returns>
public clsDnFunctionEN GetObjByDnFunctionId(string strDnFunctionId)
{
CheckPrimaryKey(strDnFunctionId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFunctionDA.GetSpecSQLObj();
strSQL = "Select * from DnFunction where DnFunctionId = " + "'"+ strDnFunctionId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsDnFunctionEN objDnFunctionEN = new clsDnFunctionEN();
try
{
 objDnFunctionEN.DnFunctionId = objRow[conDnFunction.DnFunctionId].ToString().Trim(); //DN函数Id(字段类型:char,字段长度:8,是否可空:True)
 objDnFunctionEN.DnFunctionName = objRow[conDnFunction.DnFunctionName] == DBNull.Value ? null : objRow[conDnFunction.DnFunctionName].ToString().Trim(); //DN函数(字段类型:varchar,字段长度:50,是否可空:True)
 objDnFunctionEN.AssociationMappingId = objRow[conDnFunction.AssociationMappingId].ToString().Trim(); //关联关系映射Id(字段类型:char,字段长度:2,是否可空:True)
 objDnFunctionEN.ImportClass = objRow[conDnFunction.ImportClass] == DBNull.Value ? null : objRow[conDnFunction.ImportClass].ToString().Trim(); //导入类(字段类型:varchar,字段长度:50,是否可空:True)
 objDnFunctionEN.ImportPath = objRow[conDnFunction.ImportPath] == DBNull.Value ? null : objRow[conDnFunction.ImportPath].ToString().Trim(); //导入路径(字段类型:varchar,字段长度:100,是否可空:True)
 objDnFunctionEN.PrjId = objRow[conDnFunction.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objDnFunctionEN.UpdDate = objRow[conDnFunction.UpdDate] == DBNull.Value ? null : objRow[conDnFunction.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objDnFunctionEN.UpdUser = objRow[conDnFunction.UpdUser] == DBNull.Value ? null : objRow[conDnFunction.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objDnFunctionEN.Memo = objRow[conDnFunction.Memo] == DBNull.Value ? null : objRow[conDnFunction.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsDnFunctionDA: GetObjByDnFunctionId)", objException.Message));
}
return objDnFunctionEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsDnFunctionEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsDnFunctionDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFunctionDA.GetSpecSQLObj();
strSQL = "Select * from DnFunction where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsDnFunctionEN objDnFunctionEN = new clsDnFunctionEN()
{
DnFunctionId = objRow[conDnFunction.DnFunctionId].ToString().Trim(), //DN函数Id
DnFunctionName = objRow[conDnFunction.DnFunctionName] == DBNull.Value ? null : objRow[conDnFunction.DnFunctionName].ToString().Trim(), //DN函数
AssociationMappingId = objRow[conDnFunction.AssociationMappingId].ToString().Trim(), //关联关系映射Id
ImportClass = objRow[conDnFunction.ImportClass] == DBNull.Value ? null : objRow[conDnFunction.ImportClass].ToString().Trim(), //导入类
ImportPath = objRow[conDnFunction.ImportPath] == DBNull.Value ? null : objRow[conDnFunction.ImportPath].ToString().Trim(), //导入路径
PrjId = objRow[conDnFunction.PrjId].ToString().Trim(), //工程Id
UpdDate = objRow[conDnFunction.UpdDate] == DBNull.Value ? null : objRow[conDnFunction.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conDnFunction.UpdUser] == DBNull.Value ? null : objRow[conDnFunction.UpdUser].ToString().Trim(), //修改者
Memo = objRow[conDnFunction.Memo] == DBNull.Value ? null : objRow[conDnFunction.Memo].ToString().Trim() //说明
};
objDnFunctionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objDnFunctionEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsDnFunctionDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsDnFunctionEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsDnFunctionEN objDnFunctionEN = new clsDnFunctionEN();
try
{
objDnFunctionEN.DnFunctionId = objRow[conDnFunction.DnFunctionId].ToString().Trim(); //DN函数Id
objDnFunctionEN.DnFunctionName = objRow[conDnFunction.DnFunctionName] == DBNull.Value ? null : objRow[conDnFunction.DnFunctionName].ToString().Trim(); //DN函数
objDnFunctionEN.AssociationMappingId = objRow[conDnFunction.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objDnFunctionEN.ImportClass = objRow[conDnFunction.ImportClass] == DBNull.Value ? null : objRow[conDnFunction.ImportClass].ToString().Trim(); //导入类
objDnFunctionEN.ImportPath = objRow[conDnFunction.ImportPath] == DBNull.Value ? null : objRow[conDnFunction.ImportPath].ToString().Trim(); //导入路径
objDnFunctionEN.PrjId = objRow[conDnFunction.PrjId].ToString().Trim(); //工程Id
objDnFunctionEN.UpdDate = objRow[conDnFunction.UpdDate] == DBNull.Value ? null : objRow[conDnFunction.UpdDate].ToString().Trim(); //修改日期
objDnFunctionEN.UpdUser = objRow[conDnFunction.UpdUser] == DBNull.Value ? null : objRow[conDnFunction.UpdUser].ToString().Trim(); //修改者
objDnFunctionEN.Memo = objRow[conDnFunction.Memo] == DBNull.Value ? null : objRow[conDnFunction.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsDnFunctionDA: GetObjByDataRowDnFunction)", objException.Message));
}
objDnFunctionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objDnFunctionEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsDnFunctionEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsDnFunctionEN objDnFunctionEN = new clsDnFunctionEN();
try
{
objDnFunctionEN.DnFunctionId = objRow[conDnFunction.DnFunctionId].ToString().Trim(); //DN函数Id
objDnFunctionEN.DnFunctionName = objRow[conDnFunction.DnFunctionName] == DBNull.Value ? null : objRow[conDnFunction.DnFunctionName].ToString().Trim(); //DN函数
objDnFunctionEN.AssociationMappingId = objRow[conDnFunction.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objDnFunctionEN.ImportClass = objRow[conDnFunction.ImportClass] == DBNull.Value ? null : objRow[conDnFunction.ImportClass].ToString().Trim(); //导入类
objDnFunctionEN.ImportPath = objRow[conDnFunction.ImportPath] == DBNull.Value ? null : objRow[conDnFunction.ImportPath].ToString().Trim(); //导入路径
objDnFunctionEN.PrjId = objRow[conDnFunction.PrjId].ToString().Trim(); //工程Id
objDnFunctionEN.UpdDate = objRow[conDnFunction.UpdDate] == DBNull.Value ? null : objRow[conDnFunction.UpdDate].ToString().Trim(); //修改日期
objDnFunctionEN.UpdUser = objRow[conDnFunction.UpdUser] == DBNull.Value ? null : objRow[conDnFunction.UpdUser].ToString().Trim(); //修改者
objDnFunctionEN.Memo = objRow[conDnFunction.Memo] == DBNull.Value ? null : objRow[conDnFunction.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsDnFunctionDA: GetObjByDataRow)", objException.Message));
}
objDnFunctionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objDnFunctionEN;
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
objSQL = clsDnFunctionDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsDnFunctionEN._CurrTabName, conDnFunction.DnFunctionId, 8, "");
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
objSQL = clsDnFunctionDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsDnFunctionEN._CurrTabName, conDnFunction.DnFunctionId, 8, strPrefix);
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
 objSQL = clsDnFunctionDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select DnFunctionId from DnFunction where " + strCondition;
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
 objSQL = clsDnFunctionDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select DnFunctionId from DnFunction where " + strCondition;
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
 /// <param name = "strDnFunctionId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strDnFunctionId)
{
CheckPrimaryKey(strDnFunctionId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFunctionDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("DnFunction", "DnFunctionId = " + "'"+ strDnFunctionId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsDnFunctionDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFunctionDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("DnFunction", strCondition))
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
objSQL = clsDnFunctionDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("DnFunction");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsDnFunctionEN objDnFunctionEN)
 {
 objDnFunctionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDnFunctionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDnFunctionEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFunctionDA.GetSpecSQLObj();
strSQL = "Select * from DnFunction where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "DnFunction");
objRow = objDS.Tables["DnFunction"].NewRow();
objRow[conDnFunction.DnFunctionId] = objDnFunctionEN.DnFunctionId; //DN函数Id
 if (objDnFunctionEN.DnFunctionName !=  "")
 {
objRow[conDnFunction.DnFunctionName] = objDnFunctionEN.DnFunctionName; //DN函数
 }
objRow[conDnFunction.AssociationMappingId] = objDnFunctionEN.AssociationMappingId; //关联关系映射Id
 if (objDnFunctionEN.ImportClass !=  "")
 {
objRow[conDnFunction.ImportClass] = objDnFunctionEN.ImportClass; //导入类
 }
 if (objDnFunctionEN.ImportPath !=  "")
 {
objRow[conDnFunction.ImportPath] = objDnFunctionEN.ImportPath; //导入路径
 }
objRow[conDnFunction.PrjId] = objDnFunctionEN.PrjId; //工程Id
 if (objDnFunctionEN.UpdDate !=  "")
 {
objRow[conDnFunction.UpdDate] = objDnFunctionEN.UpdDate; //修改日期
 }
 if (objDnFunctionEN.UpdUser !=  "")
 {
objRow[conDnFunction.UpdUser] = objDnFunctionEN.UpdUser; //修改者
 }
 if (objDnFunctionEN.Memo !=  "")
 {
objRow[conDnFunction.Memo] = objDnFunctionEN.Memo; //说明
 }
objDS.Tables[clsDnFunctionEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsDnFunctionEN._CurrTabName);
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
 /// <param name = "objDnFunctionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsDnFunctionEN objDnFunctionEN)
{
 objDnFunctionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDnFunctionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDnFunctionEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objDnFunctionEN.DnFunctionId !=  null)
 {
 arrFieldListForInsert.Add(conDnFunction.DnFunctionId);
 var strDnFunctionId = objDnFunctionEN.DnFunctionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDnFunctionId + "'");
 }
 
 if (objDnFunctionEN.DnFunctionName !=  null)
 {
 arrFieldListForInsert.Add(conDnFunction.DnFunctionName);
 var strDnFunctionName = objDnFunctionEN.DnFunctionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDnFunctionName + "'");
 }
 
 if (objDnFunctionEN.AssociationMappingId !=  null)
 {
 arrFieldListForInsert.Add(conDnFunction.AssociationMappingId);
 var strAssociationMappingId = objDnFunctionEN.AssociationMappingId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAssociationMappingId + "'");
 }
 
 if (objDnFunctionEN.ImportClass !=  null)
 {
 arrFieldListForInsert.Add(conDnFunction.ImportClass);
 var strImportClass = objDnFunctionEN.ImportClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strImportClass + "'");
 }
 
 if (objDnFunctionEN.ImportPath !=  null)
 {
 arrFieldListForInsert.Add(conDnFunction.ImportPath);
 var strImportPath = objDnFunctionEN.ImportPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strImportPath + "'");
 }
 
 if (objDnFunctionEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conDnFunction.PrjId);
 var strPrjId = objDnFunctionEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objDnFunctionEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conDnFunction.UpdDate);
 var strUpdDate = objDnFunctionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objDnFunctionEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conDnFunction.UpdUser);
 var strUpdUser = objDnFunctionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objDnFunctionEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDnFunction.Memo);
 var strMemo = objDnFunctionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DnFunction");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFunctionDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objDnFunctionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsDnFunctionEN objDnFunctionEN)
{
 objDnFunctionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDnFunctionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDnFunctionEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objDnFunctionEN.DnFunctionId !=  null)
 {
 arrFieldListForInsert.Add(conDnFunction.DnFunctionId);
 var strDnFunctionId = objDnFunctionEN.DnFunctionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDnFunctionId + "'");
 }
 
 if (objDnFunctionEN.DnFunctionName !=  null)
 {
 arrFieldListForInsert.Add(conDnFunction.DnFunctionName);
 var strDnFunctionName = objDnFunctionEN.DnFunctionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDnFunctionName + "'");
 }
 
 if (objDnFunctionEN.AssociationMappingId !=  null)
 {
 arrFieldListForInsert.Add(conDnFunction.AssociationMappingId);
 var strAssociationMappingId = objDnFunctionEN.AssociationMappingId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAssociationMappingId + "'");
 }
 
 if (objDnFunctionEN.ImportClass !=  null)
 {
 arrFieldListForInsert.Add(conDnFunction.ImportClass);
 var strImportClass = objDnFunctionEN.ImportClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strImportClass + "'");
 }
 
 if (objDnFunctionEN.ImportPath !=  null)
 {
 arrFieldListForInsert.Add(conDnFunction.ImportPath);
 var strImportPath = objDnFunctionEN.ImportPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strImportPath + "'");
 }
 
 if (objDnFunctionEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conDnFunction.PrjId);
 var strPrjId = objDnFunctionEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objDnFunctionEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conDnFunction.UpdDate);
 var strUpdDate = objDnFunctionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objDnFunctionEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conDnFunction.UpdUser);
 var strUpdUser = objDnFunctionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objDnFunctionEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDnFunction.Memo);
 var strMemo = objDnFunctionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DnFunction");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFunctionDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objDnFunctionEN.DnFunctionId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objDnFunctionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsDnFunctionEN objDnFunctionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objDnFunctionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDnFunctionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDnFunctionEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objDnFunctionEN.DnFunctionId !=  null)
 {
 arrFieldListForInsert.Add(conDnFunction.DnFunctionId);
 var strDnFunctionId = objDnFunctionEN.DnFunctionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDnFunctionId + "'");
 }
 
 if (objDnFunctionEN.DnFunctionName !=  null)
 {
 arrFieldListForInsert.Add(conDnFunction.DnFunctionName);
 var strDnFunctionName = objDnFunctionEN.DnFunctionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDnFunctionName + "'");
 }
 
 if (objDnFunctionEN.AssociationMappingId !=  null)
 {
 arrFieldListForInsert.Add(conDnFunction.AssociationMappingId);
 var strAssociationMappingId = objDnFunctionEN.AssociationMappingId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAssociationMappingId + "'");
 }
 
 if (objDnFunctionEN.ImportClass !=  null)
 {
 arrFieldListForInsert.Add(conDnFunction.ImportClass);
 var strImportClass = objDnFunctionEN.ImportClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strImportClass + "'");
 }
 
 if (objDnFunctionEN.ImportPath !=  null)
 {
 arrFieldListForInsert.Add(conDnFunction.ImportPath);
 var strImportPath = objDnFunctionEN.ImportPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strImportPath + "'");
 }
 
 if (objDnFunctionEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conDnFunction.PrjId);
 var strPrjId = objDnFunctionEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objDnFunctionEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conDnFunction.UpdDate);
 var strUpdDate = objDnFunctionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objDnFunctionEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conDnFunction.UpdUser);
 var strUpdUser = objDnFunctionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objDnFunctionEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDnFunction.Memo);
 var strMemo = objDnFunctionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DnFunction");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFunctionDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objDnFunctionEN.DnFunctionId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objDnFunctionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsDnFunctionEN objDnFunctionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objDnFunctionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDnFunctionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDnFunctionEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objDnFunctionEN.DnFunctionId !=  null)
 {
 arrFieldListForInsert.Add(conDnFunction.DnFunctionId);
 var strDnFunctionId = objDnFunctionEN.DnFunctionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDnFunctionId + "'");
 }
 
 if (objDnFunctionEN.DnFunctionName !=  null)
 {
 arrFieldListForInsert.Add(conDnFunction.DnFunctionName);
 var strDnFunctionName = objDnFunctionEN.DnFunctionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDnFunctionName + "'");
 }
 
 if (objDnFunctionEN.AssociationMappingId !=  null)
 {
 arrFieldListForInsert.Add(conDnFunction.AssociationMappingId);
 var strAssociationMappingId = objDnFunctionEN.AssociationMappingId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAssociationMappingId + "'");
 }
 
 if (objDnFunctionEN.ImportClass !=  null)
 {
 arrFieldListForInsert.Add(conDnFunction.ImportClass);
 var strImportClass = objDnFunctionEN.ImportClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strImportClass + "'");
 }
 
 if (objDnFunctionEN.ImportPath !=  null)
 {
 arrFieldListForInsert.Add(conDnFunction.ImportPath);
 var strImportPath = objDnFunctionEN.ImportPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strImportPath + "'");
 }
 
 if (objDnFunctionEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conDnFunction.PrjId);
 var strPrjId = objDnFunctionEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objDnFunctionEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conDnFunction.UpdDate);
 var strUpdDate = objDnFunctionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objDnFunctionEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conDnFunction.UpdUser);
 var strUpdUser = objDnFunctionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objDnFunctionEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDnFunction.Memo);
 var strMemo = objDnFunctionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DnFunction");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFunctionDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewDnFunctions(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFunctionDA.GetSpecSQLObj();
strSQL = "Select * from DnFunction where DnFunctionId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "DnFunction");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strDnFunctionId = oRow[conDnFunction.DnFunctionId].ToString().Trim();
if (IsExist(strDnFunctionId))
{
 string strResult = "关键字变量值为:" + string.Format("DnFunctionId = {0}", strDnFunctionId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsDnFunctionEN._CurrTabName ].NewRow();
objRow[conDnFunction.DnFunctionId] = oRow[conDnFunction.DnFunctionId].ToString().Trim(); //DN函数Id
objRow[conDnFunction.DnFunctionName] = oRow[conDnFunction.DnFunctionName].ToString().Trim(); //DN函数
objRow[conDnFunction.AssociationMappingId] = oRow[conDnFunction.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objRow[conDnFunction.ImportClass] = oRow[conDnFunction.ImportClass].ToString().Trim(); //导入类
objRow[conDnFunction.ImportPath] = oRow[conDnFunction.ImportPath].ToString().Trim(); //导入路径
objRow[conDnFunction.PrjId] = oRow[conDnFunction.PrjId].ToString().Trim(); //工程Id
objRow[conDnFunction.UpdDate] = oRow[conDnFunction.UpdDate].ToString().Trim(); //修改日期
objRow[conDnFunction.UpdUser] = oRow[conDnFunction.UpdUser].ToString().Trim(); //修改者
objRow[conDnFunction.Memo] = oRow[conDnFunction.Memo].ToString().Trim(); //说明
 objDS.Tables[clsDnFunctionEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsDnFunctionEN._CurrTabName);
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
 /// <param name = "objDnFunctionEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsDnFunctionEN objDnFunctionEN)
{
 objDnFunctionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDnFunctionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDnFunctionEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFunctionDA.GetSpecSQLObj();
strSQL = "Select * from DnFunction where DnFunctionId = " + "'"+ objDnFunctionEN.DnFunctionId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsDnFunctionEN._CurrTabName);
if (objDS.Tables[clsDnFunctionEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:DnFunctionId = " + "'"+ objDnFunctionEN.DnFunctionId+"'");
return false;
}
objRow = objDS.Tables[clsDnFunctionEN._CurrTabName].Rows[0];
 if (objDnFunctionEN.IsUpdated(conDnFunction.DnFunctionId))
 {
objRow[conDnFunction.DnFunctionId] = objDnFunctionEN.DnFunctionId; //DN函数Id
 }
 if (objDnFunctionEN.IsUpdated(conDnFunction.DnFunctionName))
 {
objRow[conDnFunction.DnFunctionName] = objDnFunctionEN.DnFunctionName; //DN函数
 }
 if (objDnFunctionEN.IsUpdated(conDnFunction.AssociationMappingId))
 {
objRow[conDnFunction.AssociationMappingId] = objDnFunctionEN.AssociationMappingId; //关联关系映射Id
 }
 if (objDnFunctionEN.IsUpdated(conDnFunction.ImportClass))
 {
objRow[conDnFunction.ImportClass] = objDnFunctionEN.ImportClass; //导入类
 }
 if (objDnFunctionEN.IsUpdated(conDnFunction.ImportPath))
 {
objRow[conDnFunction.ImportPath] = objDnFunctionEN.ImportPath; //导入路径
 }
 if (objDnFunctionEN.IsUpdated(conDnFunction.PrjId))
 {
objRow[conDnFunction.PrjId] = objDnFunctionEN.PrjId; //工程Id
 }
 if (objDnFunctionEN.IsUpdated(conDnFunction.UpdDate))
 {
objRow[conDnFunction.UpdDate] = objDnFunctionEN.UpdDate; //修改日期
 }
 if (objDnFunctionEN.IsUpdated(conDnFunction.UpdUser))
 {
objRow[conDnFunction.UpdUser] = objDnFunctionEN.UpdUser; //修改者
 }
 if (objDnFunctionEN.IsUpdated(conDnFunction.Memo))
 {
objRow[conDnFunction.Memo] = objDnFunctionEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsDnFunctionEN._CurrTabName);
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
 /// <param name = "objDnFunctionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsDnFunctionEN objDnFunctionEN)
{
 objDnFunctionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDnFunctionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDnFunctionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFunctionDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update DnFunction Set ");
 
 if (objDnFunctionEN.IsUpdated(conDnFunction.DnFunctionName))
 {
 if (objDnFunctionEN.DnFunctionName !=  null)
 {
 var strDnFunctionName = objDnFunctionEN.DnFunctionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDnFunctionName, conDnFunction.DnFunctionName); //DN函数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnFunction.DnFunctionName); //DN函数
 }
 }
 
 if (objDnFunctionEN.IsUpdated(conDnFunction.AssociationMappingId))
 {
 if (objDnFunctionEN.AssociationMappingId !=  null)
 {
 var strAssociationMappingId = objDnFunctionEN.AssociationMappingId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAssociationMappingId, conDnFunction.AssociationMappingId); //关联关系映射Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnFunction.AssociationMappingId); //关联关系映射Id
 }
 }
 
 if (objDnFunctionEN.IsUpdated(conDnFunction.ImportClass))
 {
 if (objDnFunctionEN.ImportClass !=  null)
 {
 var strImportClass = objDnFunctionEN.ImportClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strImportClass, conDnFunction.ImportClass); //导入类
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnFunction.ImportClass); //导入类
 }
 }
 
 if (objDnFunctionEN.IsUpdated(conDnFunction.ImportPath))
 {
 if (objDnFunctionEN.ImportPath !=  null)
 {
 var strImportPath = objDnFunctionEN.ImportPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strImportPath, conDnFunction.ImportPath); //导入路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnFunction.ImportPath); //导入路径
 }
 }
 
 if (objDnFunctionEN.IsUpdated(conDnFunction.PrjId))
 {
 if (objDnFunctionEN.PrjId !=  null)
 {
 var strPrjId = objDnFunctionEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conDnFunction.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnFunction.PrjId); //工程Id
 }
 }
 
 if (objDnFunctionEN.IsUpdated(conDnFunction.UpdDate))
 {
 if (objDnFunctionEN.UpdDate !=  null)
 {
 var strUpdDate = objDnFunctionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conDnFunction.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnFunction.UpdDate); //修改日期
 }
 }
 
 if (objDnFunctionEN.IsUpdated(conDnFunction.UpdUser))
 {
 if (objDnFunctionEN.UpdUser !=  null)
 {
 var strUpdUser = objDnFunctionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conDnFunction.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnFunction.UpdUser); //修改者
 }
 }
 
 if (objDnFunctionEN.IsUpdated(conDnFunction.Memo))
 {
 if (objDnFunctionEN.Memo !=  null)
 {
 var strMemo = objDnFunctionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conDnFunction.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnFunction.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where DnFunctionId = '{0}'", objDnFunctionEN.DnFunctionId); 
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
 /// <param name = "objDnFunctionEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsDnFunctionEN objDnFunctionEN, string strCondition)
{
 objDnFunctionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDnFunctionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDnFunctionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFunctionDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update DnFunction Set ");
 
 if (objDnFunctionEN.IsUpdated(conDnFunction.DnFunctionName))
 {
 if (objDnFunctionEN.DnFunctionName !=  null)
 {
 var strDnFunctionName = objDnFunctionEN.DnFunctionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DnFunctionName = '{0}',", strDnFunctionName); //DN函数
 }
 else
 {
 sbSQL.Append(" DnFunctionName = null,"); //DN函数
 }
 }
 
 if (objDnFunctionEN.IsUpdated(conDnFunction.AssociationMappingId))
 {
 if (objDnFunctionEN.AssociationMappingId !=  null)
 {
 var strAssociationMappingId = objDnFunctionEN.AssociationMappingId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AssociationMappingId = '{0}',", strAssociationMappingId); //关联关系映射Id
 }
 else
 {
 sbSQL.Append(" AssociationMappingId = null,"); //关联关系映射Id
 }
 }
 
 if (objDnFunctionEN.IsUpdated(conDnFunction.ImportClass))
 {
 if (objDnFunctionEN.ImportClass !=  null)
 {
 var strImportClass = objDnFunctionEN.ImportClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ImportClass = '{0}',", strImportClass); //导入类
 }
 else
 {
 sbSQL.Append(" ImportClass = null,"); //导入类
 }
 }
 
 if (objDnFunctionEN.IsUpdated(conDnFunction.ImportPath))
 {
 if (objDnFunctionEN.ImportPath !=  null)
 {
 var strImportPath = objDnFunctionEN.ImportPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ImportPath = '{0}',", strImportPath); //导入路径
 }
 else
 {
 sbSQL.Append(" ImportPath = null,"); //导入路径
 }
 }
 
 if (objDnFunctionEN.IsUpdated(conDnFunction.PrjId))
 {
 if (objDnFunctionEN.PrjId !=  null)
 {
 var strPrjId = objDnFunctionEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objDnFunctionEN.IsUpdated(conDnFunction.UpdDate))
 {
 if (objDnFunctionEN.UpdDate !=  null)
 {
 var strUpdDate = objDnFunctionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objDnFunctionEN.IsUpdated(conDnFunction.UpdUser))
 {
 if (objDnFunctionEN.UpdUser !=  null)
 {
 var strUpdUser = objDnFunctionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objDnFunctionEN.IsUpdated(conDnFunction.Memo))
 {
 if (objDnFunctionEN.Memo !=  null)
 {
 var strMemo = objDnFunctionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objDnFunctionEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsDnFunctionEN objDnFunctionEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objDnFunctionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDnFunctionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDnFunctionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFunctionDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update DnFunction Set ");
 
 if (objDnFunctionEN.IsUpdated(conDnFunction.DnFunctionName))
 {
 if (objDnFunctionEN.DnFunctionName !=  null)
 {
 var strDnFunctionName = objDnFunctionEN.DnFunctionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DnFunctionName = '{0}',", strDnFunctionName); //DN函数
 }
 else
 {
 sbSQL.Append(" DnFunctionName = null,"); //DN函数
 }
 }
 
 if (objDnFunctionEN.IsUpdated(conDnFunction.AssociationMappingId))
 {
 if (objDnFunctionEN.AssociationMappingId !=  null)
 {
 var strAssociationMappingId = objDnFunctionEN.AssociationMappingId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AssociationMappingId = '{0}',", strAssociationMappingId); //关联关系映射Id
 }
 else
 {
 sbSQL.Append(" AssociationMappingId = null,"); //关联关系映射Id
 }
 }
 
 if (objDnFunctionEN.IsUpdated(conDnFunction.ImportClass))
 {
 if (objDnFunctionEN.ImportClass !=  null)
 {
 var strImportClass = objDnFunctionEN.ImportClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ImportClass = '{0}',", strImportClass); //导入类
 }
 else
 {
 sbSQL.Append(" ImportClass = null,"); //导入类
 }
 }
 
 if (objDnFunctionEN.IsUpdated(conDnFunction.ImportPath))
 {
 if (objDnFunctionEN.ImportPath !=  null)
 {
 var strImportPath = objDnFunctionEN.ImportPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ImportPath = '{0}',", strImportPath); //导入路径
 }
 else
 {
 sbSQL.Append(" ImportPath = null,"); //导入路径
 }
 }
 
 if (objDnFunctionEN.IsUpdated(conDnFunction.PrjId))
 {
 if (objDnFunctionEN.PrjId !=  null)
 {
 var strPrjId = objDnFunctionEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objDnFunctionEN.IsUpdated(conDnFunction.UpdDate))
 {
 if (objDnFunctionEN.UpdDate !=  null)
 {
 var strUpdDate = objDnFunctionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objDnFunctionEN.IsUpdated(conDnFunction.UpdUser))
 {
 if (objDnFunctionEN.UpdUser !=  null)
 {
 var strUpdUser = objDnFunctionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objDnFunctionEN.IsUpdated(conDnFunction.Memo))
 {
 if (objDnFunctionEN.Memo !=  null)
 {
 var strMemo = objDnFunctionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objDnFunctionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsDnFunctionEN objDnFunctionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objDnFunctionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDnFunctionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDnFunctionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFunctionDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update DnFunction Set ");
 
 if (objDnFunctionEN.IsUpdated(conDnFunction.DnFunctionName))
 {
 if (objDnFunctionEN.DnFunctionName !=  null)
 {
 var strDnFunctionName = objDnFunctionEN.DnFunctionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDnFunctionName, conDnFunction.DnFunctionName); //DN函数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnFunction.DnFunctionName); //DN函数
 }
 }
 
 if (objDnFunctionEN.IsUpdated(conDnFunction.AssociationMappingId))
 {
 if (objDnFunctionEN.AssociationMappingId !=  null)
 {
 var strAssociationMappingId = objDnFunctionEN.AssociationMappingId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAssociationMappingId, conDnFunction.AssociationMappingId); //关联关系映射Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnFunction.AssociationMappingId); //关联关系映射Id
 }
 }
 
 if (objDnFunctionEN.IsUpdated(conDnFunction.ImportClass))
 {
 if (objDnFunctionEN.ImportClass !=  null)
 {
 var strImportClass = objDnFunctionEN.ImportClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strImportClass, conDnFunction.ImportClass); //导入类
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnFunction.ImportClass); //导入类
 }
 }
 
 if (objDnFunctionEN.IsUpdated(conDnFunction.ImportPath))
 {
 if (objDnFunctionEN.ImportPath !=  null)
 {
 var strImportPath = objDnFunctionEN.ImportPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strImportPath, conDnFunction.ImportPath); //导入路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnFunction.ImportPath); //导入路径
 }
 }
 
 if (objDnFunctionEN.IsUpdated(conDnFunction.PrjId))
 {
 if (objDnFunctionEN.PrjId !=  null)
 {
 var strPrjId = objDnFunctionEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conDnFunction.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnFunction.PrjId); //工程Id
 }
 }
 
 if (objDnFunctionEN.IsUpdated(conDnFunction.UpdDate))
 {
 if (objDnFunctionEN.UpdDate !=  null)
 {
 var strUpdDate = objDnFunctionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conDnFunction.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnFunction.UpdDate); //修改日期
 }
 }
 
 if (objDnFunctionEN.IsUpdated(conDnFunction.UpdUser))
 {
 if (objDnFunctionEN.UpdUser !=  null)
 {
 var strUpdUser = objDnFunctionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conDnFunction.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnFunction.UpdUser); //修改者
 }
 }
 
 if (objDnFunctionEN.IsUpdated(conDnFunction.Memo))
 {
 if (objDnFunctionEN.Memo !=  null)
 {
 var strMemo = objDnFunctionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conDnFunction.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnFunction.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where DnFunctionId = '{0}'", objDnFunctionEN.DnFunctionId); 
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
 /// <param name = "strDnFunctionId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strDnFunctionId) 
{
CheckPrimaryKey(strDnFunctionId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFunctionDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strDnFunctionId,
};
 objSQL.ExecSP("DnFunction_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strDnFunctionId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strDnFunctionId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strDnFunctionId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFunctionDA.GetSpecSQLObj();
//删除DnFunction本表中与当前对象有关的记录
strSQL = strSQL + "Delete from DnFunction where DnFunctionId = " + "'"+ strDnFunctionId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelDnFunction(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFunctionDA.GetSpecSQLObj();
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
//删除DnFunction本表中与当前对象有关的记录
strSQL = strSQL + "Delete from DnFunction where DnFunctionId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strDnFunctionId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strDnFunctionId) 
{
CheckPrimaryKey(strDnFunctionId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFunctionDA.GetSpecSQLObj();
//删除DnFunction本表中与当前对象有关的记录
strSQL = strSQL + "Delete from DnFunction where DnFunctionId = " + "'"+ strDnFunctionId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelDnFunction(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsDnFunctionDA: DelDnFunction)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFunctionDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from DnFunction where " + strCondition ;
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
public bool DelDnFunctionWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsDnFunctionDA: DelDnFunctionWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFunctionDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from DnFunction where " + strCondition ;
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
 /// <param name = "objDnFunctionENS">源对象</param>
 /// <param name = "objDnFunctionENT">目标对象</param>
public void CopyTo(clsDnFunctionEN objDnFunctionENS, clsDnFunctionEN objDnFunctionENT)
{
objDnFunctionENT.DnFunctionId = objDnFunctionENS.DnFunctionId; //DN函数Id
objDnFunctionENT.DnFunctionName = objDnFunctionENS.DnFunctionName; //DN函数
objDnFunctionENT.AssociationMappingId = objDnFunctionENS.AssociationMappingId; //关联关系映射Id
objDnFunctionENT.ImportClass = objDnFunctionENS.ImportClass; //导入类
objDnFunctionENT.ImportPath = objDnFunctionENS.ImportPath; //导入路径
objDnFunctionENT.PrjId = objDnFunctionENS.PrjId; //工程Id
objDnFunctionENT.UpdDate = objDnFunctionENS.UpdDate; //修改日期
objDnFunctionENT.UpdUser = objDnFunctionENS.UpdUser; //修改者
objDnFunctionENT.Memo = objDnFunctionENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsDnFunctionEN objDnFunctionEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objDnFunctionEN.AssociationMappingId, conDnFunction.AssociationMappingId);
clsCheckSql.CheckFieldNotNull(objDnFunctionEN.PrjId, conDnFunction.PrjId);
//检查字段长度
clsCheckSql.CheckFieldLen(objDnFunctionEN.DnFunctionId, 8, conDnFunction.DnFunctionId);
clsCheckSql.CheckFieldLen(objDnFunctionEN.DnFunctionName, 50, conDnFunction.DnFunctionName);
clsCheckSql.CheckFieldLen(objDnFunctionEN.AssociationMappingId, 2, conDnFunction.AssociationMappingId);
clsCheckSql.CheckFieldLen(objDnFunctionEN.ImportClass, 50, conDnFunction.ImportClass);
clsCheckSql.CheckFieldLen(objDnFunctionEN.ImportPath, 100, conDnFunction.ImportPath);
clsCheckSql.CheckFieldLen(objDnFunctionEN.PrjId, 4, conDnFunction.PrjId);
clsCheckSql.CheckFieldLen(objDnFunctionEN.UpdDate, 20, conDnFunction.UpdDate);
clsCheckSql.CheckFieldLen(objDnFunctionEN.UpdUser, 20, conDnFunction.UpdUser);
clsCheckSql.CheckFieldLen(objDnFunctionEN.Memo, 1000, conDnFunction.Memo);
//检查字段外键固定长度
 objDnFunctionEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsDnFunctionEN objDnFunctionEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objDnFunctionEN.DnFunctionName, 50, conDnFunction.DnFunctionName);
clsCheckSql.CheckFieldLen(objDnFunctionEN.AssociationMappingId, 2, conDnFunction.AssociationMappingId);
clsCheckSql.CheckFieldLen(objDnFunctionEN.ImportClass, 50, conDnFunction.ImportClass);
clsCheckSql.CheckFieldLen(objDnFunctionEN.ImportPath, 100, conDnFunction.ImportPath);
clsCheckSql.CheckFieldLen(objDnFunctionEN.PrjId, 4, conDnFunction.PrjId);
clsCheckSql.CheckFieldLen(objDnFunctionEN.UpdDate, 20, conDnFunction.UpdDate);
clsCheckSql.CheckFieldLen(objDnFunctionEN.UpdUser, 20, conDnFunction.UpdUser);
clsCheckSql.CheckFieldLen(objDnFunctionEN.Memo, 1000, conDnFunction.Memo);
//检查外键字段长度
 objDnFunctionEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsDnFunctionEN objDnFunctionEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objDnFunctionEN.DnFunctionId, 8, conDnFunction.DnFunctionId);
clsCheckSql.CheckFieldLen(objDnFunctionEN.DnFunctionName, 50, conDnFunction.DnFunctionName);
clsCheckSql.CheckFieldLen(objDnFunctionEN.AssociationMappingId, 2, conDnFunction.AssociationMappingId);
clsCheckSql.CheckFieldLen(objDnFunctionEN.ImportClass, 50, conDnFunction.ImportClass);
clsCheckSql.CheckFieldLen(objDnFunctionEN.ImportPath, 100, conDnFunction.ImportPath);
clsCheckSql.CheckFieldLen(objDnFunctionEN.PrjId, 4, conDnFunction.PrjId);
clsCheckSql.CheckFieldLen(objDnFunctionEN.UpdDate, 20, conDnFunction.UpdDate);
clsCheckSql.CheckFieldLen(objDnFunctionEN.UpdUser, 20, conDnFunction.UpdUser);
clsCheckSql.CheckFieldLen(objDnFunctionEN.Memo, 1000, conDnFunction.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objDnFunctionEN.DnFunctionId, conDnFunction.DnFunctionId);
clsCheckSql.CheckSqlInjection4Field(objDnFunctionEN.DnFunctionName, conDnFunction.DnFunctionName);
clsCheckSql.CheckSqlInjection4Field(objDnFunctionEN.AssociationMappingId, conDnFunction.AssociationMappingId);
clsCheckSql.CheckSqlInjection4Field(objDnFunctionEN.ImportClass, conDnFunction.ImportClass);
clsCheckSql.CheckSqlInjection4Field(objDnFunctionEN.ImportPath, conDnFunction.ImportPath);
clsCheckSql.CheckSqlInjection4Field(objDnFunctionEN.PrjId, conDnFunction.PrjId);
clsCheckSql.CheckSqlInjection4Field(objDnFunctionEN.UpdDate, conDnFunction.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objDnFunctionEN.UpdUser, conDnFunction.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objDnFunctionEN.Memo, conDnFunction.Memo);
//检查外键字段长度
 objDnFunctionEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetDnFunctionId()
{
//获取某学院所有专业信息
string strSQL = "select DnFunctionId, DnFunctionName from DnFunction ";
 clsSpecSQLforSql mySql = clsDnFunctionDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--DnFunction(数据结点函数),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objDnFunctionEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsDnFunctionEN objDnFunctionEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objDnFunctionEN.DnFunctionName == null)
{
 sbCondition.AppendFormat(" and DnFunctionName is null");
}
else
{
 sbCondition.AppendFormat(" and DnFunctionName = '{0}'", objDnFunctionEN.DnFunctionName);
}
 sbCondition.AppendFormat(" and PrjId = '{0}'", objDnFunctionEN.PrjId);
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
 objSQL = clsDnFunctionDA.GetSpecSQLObj();
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
 objSQL = clsDnFunctionDA.GetSpecSQLObj();
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
 objSQL = clsDnFunctionDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsDnFunctionEN._CurrTabName);
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
 objSQL = clsDnFunctionDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsDnFunctionEN._CurrTabName, strCondition);
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
 objSQL = clsDnFunctionDA.GetSpecSQLObj();
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
 objSQL = clsDnFunctionDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}