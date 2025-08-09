
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsGCVersionDA
 表名:GCVersion(00050500)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:08:03
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统参数(SysPara)
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
 /// 生成代码版本(GCVersion)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsGCVersionDA : clsCommBase4DA
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
 return clsGCVersionEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsGCVersionEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsGCVersionEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsGCVersionEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsGCVersionEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strGcVersionId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strGcVersionId)
{
strGcVersionId = strGcVersionId.Replace("'", "''");
if (strGcVersionId.Length > 4)
{
throw new Exception("(errid:Data000001)在表:GCVersion中,检查关键字,长度不正确!(clsGCVersionDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strGcVersionId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:GCVersion中,关键字不能为空 或 null!(clsGCVersionDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strGcVersionId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsGCVersionDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsGCVersionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVersionDA.GetSpecSQLObj();
strSQL = "Select * from GCVersion where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_GCVersion(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsGCVersionDA: GetDataTable_GCVersion)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVersionDA.GetSpecSQLObj();
strSQL = "Select * from GCVersion where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsGCVersionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVersionDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsGCVersionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVersionDA.GetSpecSQLObj();
strSQL = "Select * from GCVersion where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsGCVersionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVersionDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsGCVersionDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVersionDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from GCVersion where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from GCVersion where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsGCVersionDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVersionDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from GCVersion where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsGCVersionDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVersionDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} GCVersion.* " + 
$"from GCVersion " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and GCVersion.GcVersionId not in " + 
$"(Select top {intTop_In} GCVersion.GcVersionId from GCVersion " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from GCVersion where {1} and GcVersionId not in (Select top {2} GcVersionId from GCVersion where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from GCVersion where {1} and GcVersionId not in (Select top {3} GcVersionId from GCVersion where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsGCVersionDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVersionDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} GCVersion.* " + 
$"from GCVersion " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and GCVersion.GcVersionId not in " + 
$"(Select top {intTop_In} GCVersion.GcVersionId from GCVersion " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from GCVersion where {1} and GcVersionId not in (Select top {2} GcVersionId from GCVersion where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from GCVersion where {1} and GcVersionId not in (Select top {3} GcVersionId from GCVersion where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsGCVersionEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsGCVersionDA:GetObjLst)", objException.Message));
}
List<clsGCVersionEN> arrObjLst = new List<clsGCVersionEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVersionDA.GetSpecSQLObj();
strSQL = "Select * from GCVersion where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCVersionEN objGCVersionEN = new clsGCVersionEN();
try
{
objGCVersionEN.GcVersionId = objRow[conGCVersion.GcVersionId].ToString().Trim(); //生成代码版本Id
objGCVersionEN.GcVersionDescription = objRow[conGCVersion.GcVersionDescription] == DBNull.Value ? null : objRow[conGCVersion.GcVersionDescription].ToString().Trim(); //版本说明
objGCVersionEN.VersionNumber = objRow[conGCVersion.VersionNumber].ToString().Trim(); //版本号
objGCVersionEN.VersionCode = objRow[conGCVersion.VersionCode] == DBNull.Value ? null : objRow[conGCVersion.VersionCode].ToString().Trim(); //版本代码
objGCVersionEN.PublishDate = objRow[conGCVersion.PublishDate].ToString().Trim(); //发布日期
objGCVersionEN.VersionState = TransNullToBool(objRow[conGCVersion.VersionState].ToString().Trim()); //版本状态
objGCVersionEN.VersionUrl = objRow[conGCVersion.VersionUrl] == DBNull.Value ? null : objRow[conGCVersion.VersionUrl].ToString().Trim(); //版本文件
objGCVersionEN.PrjId = objRow[conGCVersion.PrjId] == DBNull.Value ? null : objRow[conGCVersion.PrjId].ToString().Trim(); //工程Id
objGCVersionEN.UpdDate = objRow[conGCVersion.UpdDate] == DBNull.Value ? null : objRow[conGCVersion.UpdDate].ToString().Trim(); //修改日期
objGCVersionEN.UpdUser = objRow[conGCVersion.UpdUser] == DBNull.Value ? null : objRow[conGCVersion.UpdUser].ToString().Trim(); //修改者
objGCVersionEN.Memo = objRow[conGCVersion.Memo] == DBNull.Value ? null : objRow[conGCVersion.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsGCVersionDA: GetObjLst)", objException.Message));
}
objGCVersionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objGCVersionEN);
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
public List<clsGCVersionEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsGCVersionDA:GetObjLstByTabName)", objException.Message));
}
List<clsGCVersionEN> arrObjLst = new List<clsGCVersionEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVersionDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCVersionEN objGCVersionEN = new clsGCVersionEN();
try
{
objGCVersionEN.GcVersionId = objRow[conGCVersion.GcVersionId].ToString().Trim(); //生成代码版本Id
objGCVersionEN.GcVersionDescription = objRow[conGCVersion.GcVersionDescription] == DBNull.Value ? null : objRow[conGCVersion.GcVersionDescription].ToString().Trim(); //版本说明
objGCVersionEN.VersionNumber = objRow[conGCVersion.VersionNumber].ToString().Trim(); //版本号
objGCVersionEN.VersionCode = objRow[conGCVersion.VersionCode] == DBNull.Value ? null : objRow[conGCVersion.VersionCode].ToString().Trim(); //版本代码
objGCVersionEN.PublishDate = objRow[conGCVersion.PublishDate].ToString().Trim(); //发布日期
objGCVersionEN.VersionState = TransNullToBool(objRow[conGCVersion.VersionState].ToString().Trim()); //版本状态
objGCVersionEN.VersionUrl = objRow[conGCVersion.VersionUrl] == DBNull.Value ? null : objRow[conGCVersion.VersionUrl].ToString().Trim(); //版本文件
objGCVersionEN.PrjId = objRow[conGCVersion.PrjId] == DBNull.Value ? null : objRow[conGCVersion.PrjId].ToString().Trim(); //工程Id
objGCVersionEN.UpdDate = objRow[conGCVersion.UpdDate] == DBNull.Value ? null : objRow[conGCVersion.UpdDate].ToString().Trim(); //修改日期
objGCVersionEN.UpdUser = objRow[conGCVersion.UpdUser] == DBNull.Value ? null : objRow[conGCVersion.UpdUser].ToString().Trim(); //修改者
objGCVersionEN.Memo = objRow[conGCVersion.Memo] == DBNull.Value ? null : objRow[conGCVersion.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsGCVersionDA: GetObjLst)", objException.Message));
}
objGCVersionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objGCVersionEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objGCVersionEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetGCVersion(ref clsGCVersionEN objGCVersionEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVersionDA.GetSpecSQLObj();
strSQL = "Select * from GCVersion where GcVersionId = " + "'"+ objGCVersionEN.GcVersionId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objGCVersionEN.GcVersionId = objDT.Rows[0][conGCVersion.GcVersionId].ToString().Trim(); //生成代码版本Id(字段类型:char,字段长度:4,是否可空:False)
 objGCVersionEN.GcVersionDescription = objDT.Rows[0][conGCVersion.GcVersionDescription].ToString().Trim(); //版本说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objGCVersionEN.VersionNumber = objDT.Rows[0][conGCVersion.VersionNumber].ToString().Trim(); //版本号(字段类型:varchar,字段长度:50,是否可空:False)
 objGCVersionEN.VersionCode = objDT.Rows[0][conGCVersion.VersionCode].ToString().Trim(); //版本代码(字段类型:varchar,字段长度:50,是否可空:False)
 objGCVersionEN.PublishDate = objDT.Rows[0][conGCVersion.PublishDate].ToString().Trim(); //发布日期(字段类型:varchar,字段长度:20,是否可空:True)
 objGCVersionEN.VersionState = TransNullToBool(objDT.Rows[0][conGCVersion.VersionState].ToString().Trim()); //版本状态(字段类型:bit,字段长度:1,是否可空:True)
 objGCVersionEN.VersionUrl = objDT.Rows[0][conGCVersion.VersionUrl].ToString().Trim(); //版本文件(字段类型:varchar,字段长度:500,是否可空:False)
 objGCVersionEN.PrjId = objDT.Rows[0][conGCVersion.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objGCVersionEN.UpdDate = objDT.Rows[0][conGCVersion.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objGCVersionEN.UpdUser = objDT.Rows[0][conGCVersion.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objGCVersionEN.Memo = objDT.Rows[0][conGCVersion.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsGCVersionDA: GetGCVersion)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strGcVersionId">表关键字</param>
 /// <returns>表对象</returns>
public clsGCVersionEN GetObjByGcVersionId(string strGcVersionId)
{
CheckPrimaryKey(strGcVersionId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVersionDA.GetSpecSQLObj();
strSQL = "Select * from GCVersion where GcVersionId = " + "'"+ strGcVersionId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsGCVersionEN objGCVersionEN = new clsGCVersionEN();
try
{
 objGCVersionEN.GcVersionId = objRow[conGCVersion.GcVersionId].ToString().Trim(); //生成代码版本Id(字段类型:char,字段长度:4,是否可空:False)
 objGCVersionEN.GcVersionDescription = objRow[conGCVersion.GcVersionDescription] == DBNull.Value ? null : objRow[conGCVersion.GcVersionDescription].ToString().Trim(); //版本说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objGCVersionEN.VersionNumber = objRow[conGCVersion.VersionNumber].ToString().Trim(); //版本号(字段类型:varchar,字段长度:50,是否可空:False)
 objGCVersionEN.VersionCode = objRow[conGCVersion.VersionCode] == DBNull.Value ? null : objRow[conGCVersion.VersionCode].ToString().Trim(); //版本代码(字段类型:varchar,字段长度:50,是否可空:False)
 objGCVersionEN.PublishDate = objRow[conGCVersion.PublishDate].ToString().Trim(); //发布日期(字段类型:varchar,字段长度:20,是否可空:True)
 objGCVersionEN.VersionState = clsEntityBase2.TransNullToBool_S(objRow[conGCVersion.VersionState].ToString().Trim()); //版本状态(字段类型:bit,字段长度:1,是否可空:True)
 objGCVersionEN.VersionUrl = objRow[conGCVersion.VersionUrl] == DBNull.Value ? null : objRow[conGCVersion.VersionUrl].ToString().Trim(); //版本文件(字段类型:varchar,字段长度:500,是否可空:False)
 objGCVersionEN.PrjId = objRow[conGCVersion.PrjId] == DBNull.Value ? null : objRow[conGCVersion.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objGCVersionEN.UpdDate = objRow[conGCVersion.UpdDate] == DBNull.Value ? null : objRow[conGCVersion.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objGCVersionEN.UpdUser = objRow[conGCVersion.UpdUser] == DBNull.Value ? null : objRow[conGCVersion.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objGCVersionEN.Memo = objRow[conGCVersion.Memo] == DBNull.Value ? null : objRow[conGCVersion.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsGCVersionDA: GetObjByGcVersionId)", objException.Message));
}
return objGCVersionEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsGCVersionEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsGCVersionDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVersionDA.GetSpecSQLObj();
strSQL = "Select * from GCVersion where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsGCVersionEN objGCVersionEN = new clsGCVersionEN()
{
GcVersionId = objRow[conGCVersion.GcVersionId].ToString().Trim(), //生成代码版本Id
GcVersionDescription = objRow[conGCVersion.GcVersionDescription] == DBNull.Value ? null : objRow[conGCVersion.GcVersionDescription].ToString().Trim(), //版本说明
VersionNumber = objRow[conGCVersion.VersionNumber].ToString().Trim(), //版本号
VersionCode = objRow[conGCVersion.VersionCode] == DBNull.Value ? null : objRow[conGCVersion.VersionCode].ToString().Trim(), //版本代码
PublishDate = objRow[conGCVersion.PublishDate].ToString().Trim(), //发布日期
VersionState = TransNullToBool(objRow[conGCVersion.VersionState].ToString().Trim()), //版本状态
VersionUrl = objRow[conGCVersion.VersionUrl] == DBNull.Value ? null : objRow[conGCVersion.VersionUrl].ToString().Trim(), //版本文件
PrjId = objRow[conGCVersion.PrjId] == DBNull.Value ? null : objRow[conGCVersion.PrjId].ToString().Trim(), //工程Id
UpdDate = objRow[conGCVersion.UpdDate] == DBNull.Value ? null : objRow[conGCVersion.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conGCVersion.UpdUser] == DBNull.Value ? null : objRow[conGCVersion.UpdUser].ToString().Trim(), //修改者
Memo = objRow[conGCVersion.Memo] == DBNull.Value ? null : objRow[conGCVersion.Memo].ToString().Trim() //说明
};
objGCVersionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objGCVersionEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsGCVersionDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsGCVersionEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsGCVersionEN objGCVersionEN = new clsGCVersionEN();
try
{
objGCVersionEN.GcVersionId = objRow[conGCVersion.GcVersionId].ToString().Trim(); //生成代码版本Id
objGCVersionEN.GcVersionDescription = objRow[conGCVersion.GcVersionDescription] == DBNull.Value ? null : objRow[conGCVersion.GcVersionDescription].ToString().Trim(); //版本说明
objGCVersionEN.VersionNumber = objRow[conGCVersion.VersionNumber].ToString().Trim(); //版本号
objGCVersionEN.VersionCode = objRow[conGCVersion.VersionCode] == DBNull.Value ? null : objRow[conGCVersion.VersionCode].ToString().Trim(); //版本代码
objGCVersionEN.PublishDate = objRow[conGCVersion.PublishDate].ToString().Trim(); //发布日期
objGCVersionEN.VersionState = TransNullToBool(objRow[conGCVersion.VersionState].ToString().Trim()); //版本状态
objGCVersionEN.VersionUrl = objRow[conGCVersion.VersionUrl] == DBNull.Value ? null : objRow[conGCVersion.VersionUrl].ToString().Trim(); //版本文件
objGCVersionEN.PrjId = objRow[conGCVersion.PrjId] == DBNull.Value ? null : objRow[conGCVersion.PrjId].ToString().Trim(); //工程Id
objGCVersionEN.UpdDate = objRow[conGCVersion.UpdDate] == DBNull.Value ? null : objRow[conGCVersion.UpdDate].ToString().Trim(); //修改日期
objGCVersionEN.UpdUser = objRow[conGCVersion.UpdUser] == DBNull.Value ? null : objRow[conGCVersion.UpdUser].ToString().Trim(); //修改者
objGCVersionEN.Memo = objRow[conGCVersion.Memo] == DBNull.Value ? null : objRow[conGCVersion.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsGCVersionDA: GetObjByDataRowGCVersion)", objException.Message));
}
objGCVersionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objGCVersionEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsGCVersionEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsGCVersionEN objGCVersionEN = new clsGCVersionEN();
try
{
objGCVersionEN.GcVersionId = objRow[conGCVersion.GcVersionId].ToString().Trim(); //生成代码版本Id
objGCVersionEN.GcVersionDescription = objRow[conGCVersion.GcVersionDescription] == DBNull.Value ? null : objRow[conGCVersion.GcVersionDescription].ToString().Trim(); //版本说明
objGCVersionEN.VersionNumber = objRow[conGCVersion.VersionNumber].ToString().Trim(); //版本号
objGCVersionEN.VersionCode = objRow[conGCVersion.VersionCode] == DBNull.Value ? null : objRow[conGCVersion.VersionCode].ToString().Trim(); //版本代码
objGCVersionEN.PublishDate = objRow[conGCVersion.PublishDate].ToString().Trim(); //发布日期
objGCVersionEN.VersionState = TransNullToBool(objRow[conGCVersion.VersionState].ToString().Trim()); //版本状态
objGCVersionEN.VersionUrl = objRow[conGCVersion.VersionUrl] == DBNull.Value ? null : objRow[conGCVersion.VersionUrl].ToString().Trim(); //版本文件
objGCVersionEN.PrjId = objRow[conGCVersion.PrjId] == DBNull.Value ? null : objRow[conGCVersion.PrjId].ToString().Trim(); //工程Id
objGCVersionEN.UpdDate = objRow[conGCVersion.UpdDate] == DBNull.Value ? null : objRow[conGCVersion.UpdDate].ToString().Trim(); //修改日期
objGCVersionEN.UpdUser = objRow[conGCVersion.UpdUser] == DBNull.Value ? null : objRow[conGCVersion.UpdUser].ToString().Trim(); //修改者
objGCVersionEN.Memo = objRow[conGCVersion.Memo] == DBNull.Value ? null : objRow[conGCVersion.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsGCVersionDA: GetObjByDataRow)", objException.Message));
}
objGCVersionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objGCVersionEN;
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
objSQL = clsGCVersionDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsGCVersionEN._CurrTabName, conGCVersion.GcVersionId, 4, "");
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
objSQL = clsGCVersionDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsGCVersionEN._CurrTabName, conGCVersion.GcVersionId, 4, strPrefix);
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
 objSQL = clsGCVersionDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select GcVersionId from GCVersion where " + strCondition;
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
 objSQL = clsGCVersionDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select GcVersionId from GCVersion where " + strCondition;
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
 /// <param name = "strGcVersionId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strGcVersionId)
{
CheckPrimaryKey(strGcVersionId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVersionDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("GCVersion", "GcVersionId = " + "'"+ strGcVersionId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsGCVersionDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVersionDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("GCVersion", strCondition))
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
objSQL = clsGCVersionDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("GCVersion");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsGCVersionEN objGCVersionEN)
 {
 objGCVersionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objGCVersionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objGCVersionEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVersionDA.GetSpecSQLObj();
strSQL = "Select * from GCVersion where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "GCVersion");
objRow = objDS.Tables["GCVersion"].NewRow();
objRow[conGCVersion.GcVersionId] = objGCVersionEN.GcVersionId; //生成代码版本Id
 if (objGCVersionEN.GcVersionDescription !=  "")
 {
objRow[conGCVersion.GcVersionDescription] = objGCVersionEN.GcVersionDescription; //版本说明
 }
objRow[conGCVersion.VersionNumber] = objGCVersionEN.VersionNumber; //版本号
 if (objGCVersionEN.VersionCode !=  "")
 {
objRow[conGCVersion.VersionCode] = objGCVersionEN.VersionCode; //版本代码
 }
objRow[conGCVersion.PublishDate] = objGCVersionEN.PublishDate; //发布日期
objRow[conGCVersion.VersionState] = objGCVersionEN.VersionState; //版本状态
 if (objGCVersionEN.VersionUrl !=  "")
 {
objRow[conGCVersion.VersionUrl] = objGCVersionEN.VersionUrl; //版本文件
 }
 if (objGCVersionEN.PrjId !=  "")
 {
objRow[conGCVersion.PrjId] = objGCVersionEN.PrjId; //工程Id
 }
 if (objGCVersionEN.UpdDate !=  "")
 {
objRow[conGCVersion.UpdDate] = objGCVersionEN.UpdDate; //修改日期
 }
 if (objGCVersionEN.UpdUser !=  "")
 {
objRow[conGCVersion.UpdUser] = objGCVersionEN.UpdUser; //修改者
 }
 if (objGCVersionEN.Memo !=  "")
 {
objRow[conGCVersion.Memo] = objGCVersionEN.Memo; //说明
 }
objDS.Tables[clsGCVersionEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsGCVersionEN._CurrTabName);
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
 /// <param name = "objGCVersionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsGCVersionEN objGCVersionEN)
{
 objGCVersionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objGCVersionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objGCVersionEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objGCVersionEN.GcVersionId !=  null)
 {
 arrFieldListForInsert.Add(conGCVersion.GcVersionId);
 var strGcVersionId = objGCVersionEN.GcVersionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGcVersionId + "'");
 }
 
 if (objGCVersionEN.GcVersionDescription !=  null)
 {
 arrFieldListForInsert.Add(conGCVersion.GcVersionDescription);
 var strGcVersionDescription = objGCVersionEN.GcVersionDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGcVersionDescription + "'");
 }
 
 if (objGCVersionEN.VersionNumber !=  null)
 {
 arrFieldListForInsert.Add(conGCVersion.VersionNumber);
 var strVersionNumber = objGCVersionEN.VersionNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVersionNumber + "'");
 }
 
 if (objGCVersionEN.VersionCode !=  null)
 {
 arrFieldListForInsert.Add(conGCVersion.VersionCode);
 var strVersionCode = objGCVersionEN.VersionCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVersionCode + "'");
 }
 
 if (objGCVersionEN.PublishDate !=  null)
 {
 arrFieldListForInsert.Add(conGCVersion.PublishDate);
 var strPublishDate = objGCVersionEN.PublishDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPublishDate + "'");
 }
 
 arrFieldListForInsert.Add(conGCVersion.VersionState);
 arrValueListForInsert.Add("'" + (objGCVersionEN.VersionState  ==  false ? "0" : "1") + "'");
 
 if (objGCVersionEN.VersionUrl !=  null)
 {
 arrFieldListForInsert.Add(conGCVersion.VersionUrl);
 var strVersionUrl = objGCVersionEN.VersionUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVersionUrl + "'");
 }
 
 if (objGCVersionEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conGCVersion.PrjId);
 var strPrjId = objGCVersionEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objGCVersionEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conGCVersion.UpdDate);
 var strUpdDate = objGCVersionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objGCVersionEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conGCVersion.UpdUser);
 var strUpdUser = objGCVersionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objGCVersionEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conGCVersion.Memo);
 var strMemo = objGCVersionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into GCVersion");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVersionDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objGCVersionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsGCVersionEN objGCVersionEN)
{
 objGCVersionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objGCVersionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objGCVersionEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objGCVersionEN.GcVersionId !=  null)
 {
 arrFieldListForInsert.Add(conGCVersion.GcVersionId);
 var strGcVersionId = objGCVersionEN.GcVersionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGcVersionId + "'");
 }
 
 if (objGCVersionEN.GcVersionDescription !=  null)
 {
 arrFieldListForInsert.Add(conGCVersion.GcVersionDescription);
 var strGcVersionDescription = objGCVersionEN.GcVersionDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGcVersionDescription + "'");
 }
 
 if (objGCVersionEN.VersionNumber !=  null)
 {
 arrFieldListForInsert.Add(conGCVersion.VersionNumber);
 var strVersionNumber = objGCVersionEN.VersionNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVersionNumber + "'");
 }
 
 if (objGCVersionEN.VersionCode !=  null)
 {
 arrFieldListForInsert.Add(conGCVersion.VersionCode);
 var strVersionCode = objGCVersionEN.VersionCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVersionCode + "'");
 }
 
 if (objGCVersionEN.PublishDate !=  null)
 {
 arrFieldListForInsert.Add(conGCVersion.PublishDate);
 var strPublishDate = objGCVersionEN.PublishDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPublishDate + "'");
 }
 
 arrFieldListForInsert.Add(conGCVersion.VersionState);
 arrValueListForInsert.Add("'" + (objGCVersionEN.VersionState  ==  false ? "0" : "1") + "'");
 
 if (objGCVersionEN.VersionUrl !=  null)
 {
 arrFieldListForInsert.Add(conGCVersion.VersionUrl);
 var strVersionUrl = objGCVersionEN.VersionUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVersionUrl + "'");
 }
 
 if (objGCVersionEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conGCVersion.PrjId);
 var strPrjId = objGCVersionEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objGCVersionEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conGCVersion.UpdDate);
 var strUpdDate = objGCVersionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objGCVersionEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conGCVersion.UpdUser);
 var strUpdUser = objGCVersionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objGCVersionEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conGCVersion.Memo);
 var strMemo = objGCVersionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into GCVersion");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVersionDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objGCVersionEN.GcVersionId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objGCVersionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsGCVersionEN objGCVersionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objGCVersionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objGCVersionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objGCVersionEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objGCVersionEN.GcVersionId !=  null)
 {
 arrFieldListForInsert.Add(conGCVersion.GcVersionId);
 var strGcVersionId = objGCVersionEN.GcVersionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGcVersionId + "'");
 }
 
 if (objGCVersionEN.GcVersionDescription !=  null)
 {
 arrFieldListForInsert.Add(conGCVersion.GcVersionDescription);
 var strGcVersionDescription = objGCVersionEN.GcVersionDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGcVersionDescription + "'");
 }
 
 if (objGCVersionEN.VersionNumber !=  null)
 {
 arrFieldListForInsert.Add(conGCVersion.VersionNumber);
 var strVersionNumber = objGCVersionEN.VersionNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVersionNumber + "'");
 }
 
 if (objGCVersionEN.VersionCode !=  null)
 {
 arrFieldListForInsert.Add(conGCVersion.VersionCode);
 var strVersionCode = objGCVersionEN.VersionCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVersionCode + "'");
 }
 
 if (objGCVersionEN.PublishDate !=  null)
 {
 arrFieldListForInsert.Add(conGCVersion.PublishDate);
 var strPublishDate = objGCVersionEN.PublishDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPublishDate + "'");
 }
 
 arrFieldListForInsert.Add(conGCVersion.VersionState);
 arrValueListForInsert.Add("'" + (objGCVersionEN.VersionState  ==  false ? "0" : "1") + "'");
 
 if (objGCVersionEN.VersionUrl !=  null)
 {
 arrFieldListForInsert.Add(conGCVersion.VersionUrl);
 var strVersionUrl = objGCVersionEN.VersionUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVersionUrl + "'");
 }
 
 if (objGCVersionEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conGCVersion.PrjId);
 var strPrjId = objGCVersionEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objGCVersionEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conGCVersion.UpdDate);
 var strUpdDate = objGCVersionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objGCVersionEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conGCVersion.UpdUser);
 var strUpdUser = objGCVersionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objGCVersionEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conGCVersion.Memo);
 var strMemo = objGCVersionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into GCVersion");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVersionDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objGCVersionEN.GcVersionId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objGCVersionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsGCVersionEN objGCVersionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objGCVersionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objGCVersionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objGCVersionEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objGCVersionEN.GcVersionId !=  null)
 {
 arrFieldListForInsert.Add(conGCVersion.GcVersionId);
 var strGcVersionId = objGCVersionEN.GcVersionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGcVersionId + "'");
 }
 
 if (objGCVersionEN.GcVersionDescription !=  null)
 {
 arrFieldListForInsert.Add(conGCVersion.GcVersionDescription);
 var strGcVersionDescription = objGCVersionEN.GcVersionDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGcVersionDescription + "'");
 }
 
 if (objGCVersionEN.VersionNumber !=  null)
 {
 arrFieldListForInsert.Add(conGCVersion.VersionNumber);
 var strVersionNumber = objGCVersionEN.VersionNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVersionNumber + "'");
 }
 
 if (objGCVersionEN.VersionCode !=  null)
 {
 arrFieldListForInsert.Add(conGCVersion.VersionCode);
 var strVersionCode = objGCVersionEN.VersionCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVersionCode + "'");
 }
 
 if (objGCVersionEN.PublishDate !=  null)
 {
 arrFieldListForInsert.Add(conGCVersion.PublishDate);
 var strPublishDate = objGCVersionEN.PublishDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPublishDate + "'");
 }
 
 arrFieldListForInsert.Add(conGCVersion.VersionState);
 arrValueListForInsert.Add("'" + (objGCVersionEN.VersionState  ==  false ? "0" : "1") + "'");
 
 if (objGCVersionEN.VersionUrl !=  null)
 {
 arrFieldListForInsert.Add(conGCVersion.VersionUrl);
 var strVersionUrl = objGCVersionEN.VersionUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVersionUrl + "'");
 }
 
 if (objGCVersionEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conGCVersion.PrjId);
 var strPrjId = objGCVersionEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objGCVersionEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conGCVersion.UpdDate);
 var strUpdDate = objGCVersionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objGCVersionEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conGCVersion.UpdUser);
 var strUpdUser = objGCVersionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objGCVersionEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conGCVersion.Memo);
 var strMemo = objGCVersionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into GCVersion");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVersionDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewGCVersions(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVersionDA.GetSpecSQLObj();
strSQL = "Select * from GCVersion where GcVersionId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "GCVersion");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strGcVersionId = oRow[conGCVersion.GcVersionId].ToString().Trim();
if (IsExist(strGcVersionId))
{
 string strResult = "关键字变量值为:" + string.Format("GcVersionId = {0}", strGcVersionId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsGCVersionEN._CurrTabName ].NewRow();
objRow[conGCVersion.GcVersionId] = oRow[conGCVersion.GcVersionId].ToString().Trim(); //生成代码版本Id
objRow[conGCVersion.GcVersionDescription] = oRow[conGCVersion.GcVersionDescription].ToString().Trim(); //版本说明
objRow[conGCVersion.VersionNumber] = oRow[conGCVersion.VersionNumber].ToString().Trim(); //版本号
objRow[conGCVersion.VersionCode] = oRow[conGCVersion.VersionCode].ToString().Trim(); //版本代码
objRow[conGCVersion.PublishDate] = oRow[conGCVersion.PublishDate].ToString().Trim(); //发布日期
objRow[conGCVersion.VersionState] = oRow[conGCVersion.VersionState].ToString().Trim(); //版本状态
objRow[conGCVersion.VersionUrl] = oRow[conGCVersion.VersionUrl].ToString().Trim(); //版本文件
objRow[conGCVersion.PrjId] = oRow[conGCVersion.PrjId].ToString().Trim(); //工程Id
objRow[conGCVersion.UpdDate] = oRow[conGCVersion.UpdDate].ToString().Trim(); //修改日期
objRow[conGCVersion.UpdUser] = oRow[conGCVersion.UpdUser].ToString().Trim(); //修改者
objRow[conGCVersion.Memo] = oRow[conGCVersion.Memo].ToString().Trim(); //说明
 objDS.Tables[clsGCVersionEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsGCVersionEN._CurrTabName);
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
 /// <param name = "objGCVersionEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsGCVersionEN objGCVersionEN)
{
 objGCVersionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objGCVersionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objGCVersionEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVersionDA.GetSpecSQLObj();
strSQL = "Select * from GCVersion where GcVersionId = " + "'"+ objGCVersionEN.GcVersionId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsGCVersionEN._CurrTabName);
if (objDS.Tables[clsGCVersionEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:GcVersionId = " + "'"+ objGCVersionEN.GcVersionId+"'");
return false;
}
objRow = objDS.Tables[clsGCVersionEN._CurrTabName].Rows[0];
 if (objGCVersionEN.IsUpdated(conGCVersion.GcVersionId))
 {
objRow[conGCVersion.GcVersionId] = objGCVersionEN.GcVersionId; //生成代码版本Id
 }
 if (objGCVersionEN.IsUpdated(conGCVersion.GcVersionDescription))
 {
objRow[conGCVersion.GcVersionDescription] = objGCVersionEN.GcVersionDescription; //版本说明
 }
 if (objGCVersionEN.IsUpdated(conGCVersion.VersionNumber))
 {
objRow[conGCVersion.VersionNumber] = objGCVersionEN.VersionNumber; //版本号
 }
 if (objGCVersionEN.IsUpdated(conGCVersion.VersionCode))
 {
objRow[conGCVersion.VersionCode] = objGCVersionEN.VersionCode; //版本代码
 }
 if (objGCVersionEN.IsUpdated(conGCVersion.PublishDate))
 {
objRow[conGCVersion.PublishDate] = objGCVersionEN.PublishDate; //发布日期
 }
 if (objGCVersionEN.IsUpdated(conGCVersion.VersionState))
 {
objRow[conGCVersion.VersionState] = objGCVersionEN.VersionState; //版本状态
 }
 if (objGCVersionEN.IsUpdated(conGCVersion.VersionUrl))
 {
objRow[conGCVersion.VersionUrl] = objGCVersionEN.VersionUrl; //版本文件
 }
 if (objGCVersionEN.IsUpdated(conGCVersion.PrjId))
 {
objRow[conGCVersion.PrjId] = objGCVersionEN.PrjId; //工程Id
 }
 if (objGCVersionEN.IsUpdated(conGCVersion.UpdDate))
 {
objRow[conGCVersion.UpdDate] = objGCVersionEN.UpdDate; //修改日期
 }
 if (objGCVersionEN.IsUpdated(conGCVersion.UpdUser))
 {
objRow[conGCVersion.UpdUser] = objGCVersionEN.UpdUser; //修改者
 }
 if (objGCVersionEN.IsUpdated(conGCVersion.Memo))
 {
objRow[conGCVersion.Memo] = objGCVersionEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsGCVersionEN._CurrTabName);
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
 /// <param name = "objGCVersionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsGCVersionEN objGCVersionEN)
{
 objGCVersionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objGCVersionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objGCVersionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVersionDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update GCVersion Set ");
 
 if (objGCVersionEN.IsUpdated(conGCVersion.GcVersionDescription))
 {
 if (objGCVersionEN.GcVersionDescription !=  null)
 {
 var strGcVersionDescription = objGCVersionEN.GcVersionDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGcVersionDescription, conGCVersion.GcVersionDescription); //版本说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCVersion.GcVersionDescription); //版本说明
 }
 }
 
 if (objGCVersionEN.IsUpdated(conGCVersion.VersionNumber))
 {
 if (objGCVersionEN.VersionNumber !=  null)
 {
 var strVersionNumber = objGCVersionEN.VersionNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVersionNumber, conGCVersion.VersionNumber); //版本号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCVersion.VersionNumber); //版本号
 }
 }
 
 if (objGCVersionEN.IsUpdated(conGCVersion.VersionCode))
 {
 if (objGCVersionEN.VersionCode !=  null)
 {
 var strVersionCode = objGCVersionEN.VersionCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVersionCode, conGCVersion.VersionCode); //版本代码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCVersion.VersionCode); //版本代码
 }
 }
 
 if (objGCVersionEN.IsUpdated(conGCVersion.PublishDate))
 {
 if (objGCVersionEN.PublishDate !=  null)
 {
 var strPublishDate = objGCVersionEN.PublishDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPublishDate, conGCVersion.PublishDate); //发布日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCVersion.PublishDate); //发布日期
 }
 }
 
 if (objGCVersionEN.IsUpdated(conGCVersion.VersionState))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objGCVersionEN.VersionState == true?"1":"0", conGCVersion.VersionState); //版本状态
 }
 
 if (objGCVersionEN.IsUpdated(conGCVersion.VersionUrl))
 {
 if (objGCVersionEN.VersionUrl !=  null)
 {
 var strVersionUrl = objGCVersionEN.VersionUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVersionUrl, conGCVersion.VersionUrl); //版本文件
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCVersion.VersionUrl); //版本文件
 }
 }
 
 if (objGCVersionEN.IsUpdated(conGCVersion.PrjId))
 {
 if (objGCVersionEN.PrjId !=  null)
 {
 var strPrjId = objGCVersionEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conGCVersion.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCVersion.PrjId); //工程Id
 }
 }
 
 if (objGCVersionEN.IsUpdated(conGCVersion.UpdDate))
 {
 if (objGCVersionEN.UpdDate !=  null)
 {
 var strUpdDate = objGCVersionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conGCVersion.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCVersion.UpdDate); //修改日期
 }
 }
 
 if (objGCVersionEN.IsUpdated(conGCVersion.UpdUser))
 {
 if (objGCVersionEN.UpdUser !=  null)
 {
 var strUpdUser = objGCVersionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conGCVersion.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCVersion.UpdUser); //修改者
 }
 }
 
 if (objGCVersionEN.IsUpdated(conGCVersion.Memo))
 {
 if (objGCVersionEN.Memo !=  null)
 {
 var strMemo = objGCVersionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conGCVersion.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCVersion.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where GcVersionId = '{0}'", objGCVersionEN.GcVersionId); 
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
 /// <param name = "objGCVersionEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsGCVersionEN objGCVersionEN, string strCondition)
{
 objGCVersionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objGCVersionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objGCVersionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVersionDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update GCVersion Set ");
 
 if (objGCVersionEN.IsUpdated(conGCVersion.GcVersionDescription))
 {
 if (objGCVersionEN.GcVersionDescription !=  null)
 {
 var strGcVersionDescription = objGCVersionEN.GcVersionDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GcVersionDescription = '{0}',", strGcVersionDescription); //版本说明
 }
 else
 {
 sbSQL.Append(" GcVersionDescription = null,"); //版本说明
 }
 }
 
 if (objGCVersionEN.IsUpdated(conGCVersion.VersionNumber))
 {
 if (objGCVersionEN.VersionNumber !=  null)
 {
 var strVersionNumber = objGCVersionEN.VersionNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VersionNumber = '{0}',", strVersionNumber); //版本号
 }
 else
 {
 sbSQL.Append(" VersionNumber = null,"); //版本号
 }
 }
 
 if (objGCVersionEN.IsUpdated(conGCVersion.VersionCode))
 {
 if (objGCVersionEN.VersionCode !=  null)
 {
 var strVersionCode = objGCVersionEN.VersionCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VersionCode = '{0}',", strVersionCode); //版本代码
 }
 else
 {
 sbSQL.Append(" VersionCode = null,"); //版本代码
 }
 }
 
 if (objGCVersionEN.IsUpdated(conGCVersion.PublishDate))
 {
 if (objGCVersionEN.PublishDate !=  null)
 {
 var strPublishDate = objGCVersionEN.PublishDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PublishDate = '{0}',", strPublishDate); //发布日期
 }
 else
 {
 sbSQL.Append(" PublishDate = null,"); //发布日期
 }
 }
 
 if (objGCVersionEN.IsUpdated(conGCVersion.VersionState))
 {
 sbSQL.AppendFormat(" VersionState = '{0}',", objGCVersionEN.VersionState == true?"1":"0"); //版本状态
 }
 
 if (objGCVersionEN.IsUpdated(conGCVersion.VersionUrl))
 {
 if (objGCVersionEN.VersionUrl !=  null)
 {
 var strVersionUrl = objGCVersionEN.VersionUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VersionUrl = '{0}',", strVersionUrl); //版本文件
 }
 else
 {
 sbSQL.Append(" VersionUrl = null,"); //版本文件
 }
 }
 
 if (objGCVersionEN.IsUpdated(conGCVersion.PrjId))
 {
 if (objGCVersionEN.PrjId !=  null)
 {
 var strPrjId = objGCVersionEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objGCVersionEN.IsUpdated(conGCVersion.UpdDate))
 {
 if (objGCVersionEN.UpdDate !=  null)
 {
 var strUpdDate = objGCVersionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objGCVersionEN.IsUpdated(conGCVersion.UpdUser))
 {
 if (objGCVersionEN.UpdUser !=  null)
 {
 var strUpdUser = objGCVersionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objGCVersionEN.IsUpdated(conGCVersion.Memo))
 {
 if (objGCVersionEN.Memo !=  null)
 {
 var strMemo = objGCVersionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objGCVersionEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsGCVersionEN objGCVersionEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objGCVersionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objGCVersionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objGCVersionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVersionDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update GCVersion Set ");
 
 if (objGCVersionEN.IsUpdated(conGCVersion.GcVersionDescription))
 {
 if (objGCVersionEN.GcVersionDescription !=  null)
 {
 var strGcVersionDescription = objGCVersionEN.GcVersionDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GcVersionDescription = '{0}',", strGcVersionDescription); //版本说明
 }
 else
 {
 sbSQL.Append(" GcVersionDescription = null,"); //版本说明
 }
 }
 
 if (objGCVersionEN.IsUpdated(conGCVersion.VersionNumber))
 {
 if (objGCVersionEN.VersionNumber !=  null)
 {
 var strVersionNumber = objGCVersionEN.VersionNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VersionNumber = '{0}',", strVersionNumber); //版本号
 }
 else
 {
 sbSQL.Append(" VersionNumber = null,"); //版本号
 }
 }
 
 if (objGCVersionEN.IsUpdated(conGCVersion.VersionCode))
 {
 if (objGCVersionEN.VersionCode !=  null)
 {
 var strVersionCode = objGCVersionEN.VersionCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VersionCode = '{0}',", strVersionCode); //版本代码
 }
 else
 {
 sbSQL.Append(" VersionCode = null,"); //版本代码
 }
 }
 
 if (objGCVersionEN.IsUpdated(conGCVersion.PublishDate))
 {
 if (objGCVersionEN.PublishDate !=  null)
 {
 var strPublishDate = objGCVersionEN.PublishDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PublishDate = '{0}',", strPublishDate); //发布日期
 }
 else
 {
 sbSQL.Append(" PublishDate = null,"); //发布日期
 }
 }
 
 if (objGCVersionEN.IsUpdated(conGCVersion.VersionState))
 {
 sbSQL.AppendFormat(" VersionState = '{0}',", objGCVersionEN.VersionState == true?"1":"0"); //版本状态
 }
 
 if (objGCVersionEN.IsUpdated(conGCVersion.VersionUrl))
 {
 if (objGCVersionEN.VersionUrl !=  null)
 {
 var strVersionUrl = objGCVersionEN.VersionUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VersionUrl = '{0}',", strVersionUrl); //版本文件
 }
 else
 {
 sbSQL.Append(" VersionUrl = null,"); //版本文件
 }
 }
 
 if (objGCVersionEN.IsUpdated(conGCVersion.PrjId))
 {
 if (objGCVersionEN.PrjId !=  null)
 {
 var strPrjId = objGCVersionEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objGCVersionEN.IsUpdated(conGCVersion.UpdDate))
 {
 if (objGCVersionEN.UpdDate !=  null)
 {
 var strUpdDate = objGCVersionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objGCVersionEN.IsUpdated(conGCVersion.UpdUser))
 {
 if (objGCVersionEN.UpdUser !=  null)
 {
 var strUpdUser = objGCVersionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objGCVersionEN.IsUpdated(conGCVersion.Memo))
 {
 if (objGCVersionEN.Memo !=  null)
 {
 var strMemo = objGCVersionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objGCVersionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsGCVersionEN objGCVersionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objGCVersionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objGCVersionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objGCVersionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVersionDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update GCVersion Set ");
 
 if (objGCVersionEN.IsUpdated(conGCVersion.GcVersionDescription))
 {
 if (objGCVersionEN.GcVersionDescription !=  null)
 {
 var strGcVersionDescription = objGCVersionEN.GcVersionDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGcVersionDescription, conGCVersion.GcVersionDescription); //版本说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCVersion.GcVersionDescription); //版本说明
 }
 }
 
 if (objGCVersionEN.IsUpdated(conGCVersion.VersionNumber))
 {
 if (objGCVersionEN.VersionNumber !=  null)
 {
 var strVersionNumber = objGCVersionEN.VersionNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVersionNumber, conGCVersion.VersionNumber); //版本号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCVersion.VersionNumber); //版本号
 }
 }
 
 if (objGCVersionEN.IsUpdated(conGCVersion.VersionCode))
 {
 if (objGCVersionEN.VersionCode !=  null)
 {
 var strVersionCode = objGCVersionEN.VersionCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVersionCode, conGCVersion.VersionCode); //版本代码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCVersion.VersionCode); //版本代码
 }
 }
 
 if (objGCVersionEN.IsUpdated(conGCVersion.PublishDate))
 {
 if (objGCVersionEN.PublishDate !=  null)
 {
 var strPublishDate = objGCVersionEN.PublishDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPublishDate, conGCVersion.PublishDate); //发布日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCVersion.PublishDate); //发布日期
 }
 }
 
 if (objGCVersionEN.IsUpdated(conGCVersion.VersionState))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objGCVersionEN.VersionState == true?"1":"0", conGCVersion.VersionState); //版本状态
 }
 
 if (objGCVersionEN.IsUpdated(conGCVersion.VersionUrl))
 {
 if (objGCVersionEN.VersionUrl !=  null)
 {
 var strVersionUrl = objGCVersionEN.VersionUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVersionUrl, conGCVersion.VersionUrl); //版本文件
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCVersion.VersionUrl); //版本文件
 }
 }
 
 if (objGCVersionEN.IsUpdated(conGCVersion.PrjId))
 {
 if (objGCVersionEN.PrjId !=  null)
 {
 var strPrjId = objGCVersionEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conGCVersion.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCVersion.PrjId); //工程Id
 }
 }
 
 if (objGCVersionEN.IsUpdated(conGCVersion.UpdDate))
 {
 if (objGCVersionEN.UpdDate !=  null)
 {
 var strUpdDate = objGCVersionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conGCVersion.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCVersion.UpdDate); //修改日期
 }
 }
 
 if (objGCVersionEN.IsUpdated(conGCVersion.UpdUser))
 {
 if (objGCVersionEN.UpdUser !=  null)
 {
 var strUpdUser = objGCVersionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conGCVersion.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCVersion.UpdUser); //修改者
 }
 }
 
 if (objGCVersionEN.IsUpdated(conGCVersion.Memo))
 {
 if (objGCVersionEN.Memo !=  null)
 {
 var strMemo = objGCVersionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conGCVersion.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCVersion.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where GcVersionId = '{0}'", objGCVersionEN.GcVersionId); 
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
 /// <param name = "strGcVersionId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strGcVersionId) 
{
CheckPrimaryKey(strGcVersionId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVersionDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strGcVersionId,
};
 objSQL.ExecSP("GCVersion_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strGcVersionId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strGcVersionId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strGcVersionId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVersionDA.GetSpecSQLObj();
//删除GCVersion本表中与当前对象有关的记录
strSQL = strSQL + "Delete from GCVersion where GcVersionId = " + "'"+ strGcVersionId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelGCVersion(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVersionDA.GetSpecSQLObj();
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
//删除GCVersion本表中与当前对象有关的记录
strSQL = strSQL + "Delete from GCVersion where GcVersionId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strGcVersionId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strGcVersionId) 
{
CheckPrimaryKey(strGcVersionId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVersionDA.GetSpecSQLObj();
//删除GCVersion本表中与当前对象有关的记录
strSQL = strSQL + "Delete from GCVersion where GcVersionId = " + "'"+ strGcVersionId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelGCVersion(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsGCVersionDA: DelGCVersion)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVersionDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from GCVersion where " + strCondition ;
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
public bool DelGCVersionWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsGCVersionDA: DelGCVersionWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVersionDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from GCVersion where " + strCondition ;
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
 /// <param name = "objGCVersionENS">源对象</param>
 /// <param name = "objGCVersionENT">目标对象</param>
public void CopyTo(clsGCVersionEN objGCVersionENS, clsGCVersionEN objGCVersionENT)
{
objGCVersionENT.GcVersionId = objGCVersionENS.GcVersionId; //生成代码版本Id
objGCVersionENT.GcVersionDescription = objGCVersionENS.GcVersionDescription; //版本说明
objGCVersionENT.VersionNumber = objGCVersionENS.VersionNumber; //版本号
objGCVersionENT.VersionCode = objGCVersionENS.VersionCode; //版本代码
objGCVersionENT.PublishDate = objGCVersionENS.PublishDate; //发布日期
objGCVersionENT.VersionState = objGCVersionENS.VersionState; //版本状态
objGCVersionENT.VersionUrl = objGCVersionENS.VersionUrl; //版本文件
objGCVersionENT.PrjId = objGCVersionENS.PrjId; //工程Id
objGCVersionENT.UpdDate = objGCVersionENS.UpdDate; //修改日期
objGCVersionENT.UpdUser = objGCVersionENS.UpdUser; //修改者
objGCVersionENT.Memo = objGCVersionENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsGCVersionEN objGCVersionEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objGCVersionEN.VersionNumber, conGCVersion.VersionNumber);
clsCheckSql.CheckFieldNotNull(objGCVersionEN.PublishDate, conGCVersion.PublishDate);
//检查字段长度
clsCheckSql.CheckFieldLen(objGCVersionEN.GcVersionId, 4, conGCVersion.GcVersionId);
clsCheckSql.CheckFieldLen(objGCVersionEN.GcVersionDescription, 1000, conGCVersion.GcVersionDescription);
clsCheckSql.CheckFieldLen(objGCVersionEN.VersionNumber, 50, conGCVersion.VersionNumber);
clsCheckSql.CheckFieldLen(objGCVersionEN.VersionCode, 50, conGCVersion.VersionCode);
clsCheckSql.CheckFieldLen(objGCVersionEN.PublishDate, 20, conGCVersion.PublishDate);
clsCheckSql.CheckFieldLen(objGCVersionEN.VersionUrl, 500, conGCVersion.VersionUrl);
clsCheckSql.CheckFieldLen(objGCVersionEN.PrjId, 4, conGCVersion.PrjId);
clsCheckSql.CheckFieldLen(objGCVersionEN.UpdDate, 20, conGCVersion.UpdDate);
clsCheckSql.CheckFieldLen(objGCVersionEN.UpdUser, 20, conGCVersion.UpdUser);
clsCheckSql.CheckFieldLen(objGCVersionEN.Memo, 1000, conGCVersion.Memo);
//检查字段外键固定长度
 objGCVersionEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsGCVersionEN objGCVersionEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objGCVersionEN.GcVersionDescription, 1000, conGCVersion.GcVersionDescription);
clsCheckSql.CheckFieldLen(objGCVersionEN.VersionNumber, 50, conGCVersion.VersionNumber);
clsCheckSql.CheckFieldLen(objGCVersionEN.VersionCode, 50, conGCVersion.VersionCode);
clsCheckSql.CheckFieldLen(objGCVersionEN.PublishDate, 20, conGCVersion.PublishDate);
clsCheckSql.CheckFieldLen(objGCVersionEN.VersionUrl, 500, conGCVersion.VersionUrl);
clsCheckSql.CheckFieldLen(objGCVersionEN.PrjId, 4, conGCVersion.PrjId);
clsCheckSql.CheckFieldLen(objGCVersionEN.UpdDate, 20, conGCVersion.UpdDate);
clsCheckSql.CheckFieldLen(objGCVersionEN.UpdUser, 20, conGCVersion.UpdUser);
clsCheckSql.CheckFieldLen(objGCVersionEN.Memo, 1000, conGCVersion.Memo);
//检查外键字段长度
 objGCVersionEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsGCVersionEN objGCVersionEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objGCVersionEN.GcVersionId, 4, conGCVersion.GcVersionId);
clsCheckSql.CheckFieldLen(objGCVersionEN.GcVersionDescription, 1000, conGCVersion.GcVersionDescription);
clsCheckSql.CheckFieldLen(objGCVersionEN.VersionNumber, 50, conGCVersion.VersionNumber);
clsCheckSql.CheckFieldLen(objGCVersionEN.VersionCode, 50, conGCVersion.VersionCode);
clsCheckSql.CheckFieldLen(objGCVersionEN.PublishDate, 20, conGCVersion.PublishDate);
clsCheckSql.CheckFieldLen(objGCVersionEN.VersionUrl, 500, conGCVersion.VersionUrl);
clsCheckSql.CheckFieldLen(objGCVersionEN.PrjId, 4, conGCVersion.PrjId);
clsCheckSql.CheckFieldLen(objGCVersionEN.UpdDate, 20, conGCVersion.UpdDate);
clsCheckSql.CheckFieldLen(objGCVersionEN.UpdUser, 20, conGCVersion.UpdUser);
clsCheckSql.CheckFieldLen(objGCVersionEN.Memo, 1000, conGCVersion.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objGCVersionEN.GcVersionId, conGCVersion.GcVersionId);
clsCheckSql.CheckSqlInjection4Field(objGCVersionEN.GcVersionDescription, conGCVersion.GcVersionDescription);
clsCheckSql.CheckSqlInjection4Field(objGCVersionEN.VersionNumber, conGCVersion.VersionNumber);
clsCheckSql.CheckSqlInjection4Field(objGCVersionEN.VersionCode, conGCVersion.VersionCode);
clsCheckSql.CheckSqlInjection4Field(objGCVersionEN.PublishDate, conGCVersion.PublishDate);
clsCheckSql.CheckSqlInjection4Field(objGCVersionEN.VersionUrl, conGCVersion.VersionUrl);
clsCheckSql.CheckSqlInjection4Field(objGCVersionEN.PrjId, conGCVersion.PrjId);
clsCheckSql.CheckSqlInjection4Field(objGCVersionEN.UpdDate, conGCVersion.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objGCVersionEN.UpdUser, conGCVersion.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objGCVersionEN.Memo, conGCVersion.Memo);
//检查外键字段长度
 objGCVersionEN._IsCheckProperty = true;
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
 objSQL = clsGCVersionDA.GetSpecSQLObj();
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
 objSQL = clsGCVersionDA.GetSpecSQLObj();
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
 objSQL = clsGCVersionDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsGCVersionEN._CurrTabName);
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
 objSQL = clsGCVersionDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsGCVersionEN._CurrTabName, strCondition);
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
 objSQL = clsGCVersionDA.GetSpecSQLObj();
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
 objSQL = clsGCVersionDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}