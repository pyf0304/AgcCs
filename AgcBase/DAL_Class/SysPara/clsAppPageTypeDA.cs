
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsAppPageTypeDA
 表名:AppPageType(00050382)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:35:08
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
 /// App页面类型(AppPageType)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsAppPageTypeDA : clsCommBase4DA
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
 return clsAppPageTypeEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsAppPageTypeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsAppPageTypeEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsAppPageTypeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsAppPageTypeEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strAppPageTypeId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strAppPageTypeId)
{
strAppPageTypeId = strAppPageTypeId.Replace("'", "''");
if (strAppPageTypeId.Length > 4)
{
throw new Exception("(errid:Data000001)在表:AppPageType中,检查关键字,长度不正确!(clsAppPageTypeDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strAppPageTypeId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:AppPageType中,关键字不能为空 或 null!(clsAppPageTypeDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strAppPageTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsAppPageTypeDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsAppPageTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppPageTypeDA.GetSpecSQLObj();
strSQL = "Select * from AppPageType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_AppPageType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsAppPageTypeDA: GetDataTable_AppPageType)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppPageTypeDA.GetSpecSQLObj();
strSQL = "Select * from AppPageType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsAppPageTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppPageTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsAppPageTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppPageTypeDA.GetSpecSQLObj();
strSQL = "Select * from AppPageType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsAppPageTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppPageTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsAppPageTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppPageTypeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from AppPageType where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from AppPageType where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsAppPageTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppPageTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from AppPageType where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsAppPageTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppPageTypeDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} AppPageType.* " + 
$"from AppPageType " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and AppPageType.AppPageTypeId not in " + 
$"(Select top {intTop_In} AppPageType.AppPageTypeId from AppPageType " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from AppPageType where {1} and AppPageTypeId not in (Select top {2} AppPageTypeId from AppPageType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from AppPageType where {1} and AppPageTypeId not in (Select top {3} AppPageTypeId from AppPageType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsAppPageTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppPageTypeDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} AppPageType.* " + 
$"from AppPageType " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and AppPageType.AppPageTypeId not in " + 
$"(Select top {intTop_In} AppPageType.AppPageTypeId from AppPageType " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from AppPageType where {1} and AppPageTypeId not in (Select top {2} AppPageTypeId from AppPageType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from AppPageType where {1} and AppPageTypeId not in (Select top {3} AppPageTypeId from AppPageType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsAppPageTypeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsAppPageTypeDA:GetObjLst)", objException.Message));
}
List<clsAppPageTypeEN> arrObjLst = new List<clsAppPageTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppPageTypeDA.GetSpecSQLObj();
strSQL = "Select * from AppPageType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAppPageTypeEN objAppPageTypeEN = new clsAppPageTypeEN();
try
{
objAppPageTypeEN.AppPageTypeId = objRow[conAppPageType.AppPageTypeId].ToString().Trim(); //App页面类型Id
objAppPageTypeEN.AppPageTypeName = objRow[conAppPageType.AppPageTypeName].ToString().Trim(); //App页面类型名
objAppPageTypeEN.AppPageTypeENName = objRow[conAppPageType.AppPageTypeENName].ToString().Trim(); //App页面类型英文名
objAppPageTypeEN.UpdDate = objRow[conAppPageType.UpdDate] == DBNull.Value ? null : objRow[conAppPageType.UpdDate].ToString().Trim(); //修改日期
objAppPageTypeEN.UpdUser = objRow[conAppPageType.UpdUser] == DBNull.Value ? null : objRow[conAppPageType.UpdUser].ToString().Trim(); //修改者
objAppPageTypeEN.Memo = objRow[conAppPageType.Memo] == DBNull.Value ? null : objRow[conAppPageType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsAppPageTypeDA: GetObjLst)", objException.Message));
}
objAppPageTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objAppPageTypeEN);
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
public List<clsAppPageTypeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsAppPageTypeDA:GetObjLstByTabName)", objException.Message));
}
List<clsAppPageTypeEN> arrObjLst = new List<clsAppPageTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppPageTypeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAppPageTypeEN objAppPageTypeEN = new clsAppPageTypeEN();
try
{
objAppPageTypeEN.AppPageTypeId = objRow[conAppPageType.AppPageTypeId].ToString().Trim(); //App页面类型Id
objAppPageTypeEN.AppPageTypeName = objRow[conAppPageType.AppPageTypeName].ToString().Trim(); //App页面类型名
objAppPageTypeEN.AppPageTypeENName = objRow[conAppPageType.AppPageTypeENName].ToString().Trim(); //App页面类型英文名
objAppPageTypeEN.UpdDate = objRow[conAppPageType.UpdDate] == DBNull.Value ? null : objRow[conAppPageType.UpdDate].ToString().Trim(); //修改日期
objAppPageTypeEN.UpdUser = objRow[conAppPageType.UpdUser] == DBNull.Value ? null : objRow[conAppPageType.UpdUser].ToString().Trim(); //修改者
objAppPageTypeEN.Memo = objRow[conAppPageType.Memo] == DBNull.Value ? null : objRow[conAppPageType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsAppPageTypeDA: GetObjLst)", objException.Message));
}
objAppPageTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objAppPageTypeEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objAppPageTypeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetAppPageType(ref clsAppPageTypeEN objAppPageTypeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppPageTypeDA.GetSpecSQLObj();
strSQL = "Select * from AppPageType where AppPageTypeId = " + "'"+ objAppPageTypeEN.AppPageTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objAppPageTypeEN.AppPageTypeId = objDT.Rows[0][conAppPageType.AppPageTypeId].ToString().Trim(); //App页面类型Id(字段类型:char,字段长度:4,是否可空:True)
 objAppPageTypeEN.AppPageTypeName = objDT.Rows[0][conAppPageType.AppPageTypeName].ToString().Trim(); //App页面类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objAppPageTypeEN.AppPageTypeENName = objDT.Rows[0][conAppPageType.AppPageTypeENName].ToString().Trim(); //App页面类型英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objAppPageTypeEN.UpdDate = objDT.Rows[0][conAppPageType.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objAppPageTypeEN.UpdUser = objDT.Rows[0][conAppPageType.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objAppPageTypeEN.Memo = objDT.Rows[0][conAppPageType.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsAppPageTypeDA: GetAppPageType)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strAppPageTypeId">表关键字</param>
 /// <returns>表对象</returns>
public clsAppPageTypeEN GetObjByAppPageTypeId(string strAppPageTypeId)
{
CheckPrimaryKey(strAppPageTypeId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppPageTypeDA.GetSpecSQLObj();
strSQL = "Select * from AppPageType where AppPageTypeId = " + "'"+ strAppPageTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsAppPageTypeEN objAppPageTypeEN = new clsAppPageTypeEN();
try
{
 objAppPageTypeEN.AppPageTypeId = objRow[conAppPageType.AppPageTypeId].ToString().Trim(); //App页面类型Id(字段类型:char,字段长度:4,是否可空:True)
 objAppPageTypeEN.AppPageTypeName = objRow[conAppPageType.AppPageTypeName].ToString().Trim(); //App页面类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objAppPageTypeEN.AppPageTypeENName = objRow[conAppPageType.AppPageTypeENName].ToString().Trim(); //App页面类型英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objAppPageTypeEN.UpdDate = objRow[conAppPageType.UpdDate] == DBNull.Value ? null : objRow[conAppPageType.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objAppPageTypeEN.UpdUser = objRow[conAppPageType.UpdUser] == DBNull.Value ? null : objRow[conAppPageType.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objAppPageTypeEN.Memo = objRow[conAppPageType.Memo] == DBNull.Value ? null : objRow[conAppPageType.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsAppPageTypeDA: GetObjByAppPageTypeId)", objException.Message));
}
return objAppPageTypeEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsAppPageTypeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsAppPageTypeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppPageTypeDA.GetSpecSQLObj();
strSQL = "Select * from AppPageType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsAppPageTypeEN objAppPageTypeEN = new clsAppPageTypeEN()
{
AppPageTypeId = objRow[conAppPageType.AppPageTypeId].ToString().Trim(), //App页面类型Id
AppPageTypeName = objRow[conAppPageType.AppPageTypeName].ToString().Trim(), //App页面类型名
AppPageTypeENName = objRow[conAppPageType.AppPageTypeENName].ToString().Trim(), //App页面类型英文名
UpdDate = objRow[conAppPageType.UpdDate] == DBNull.Value ? null : objRow[conAppPageType.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conAppPageType.UpdUser] == DBNull.Value ? null : objRow[conAppPageType.UpdUser].ToString().Trim(), //修改者
Memo = objRow[conAppPageType.Memo] == DBNull.Value ? null : objRow[conAppPageType.Memo].ToString().Trim() //说明
};
objAppPageTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objAppPageTypeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsAppPageTypeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsAppPageTypeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsAppPageTypeEN objAppPageTypeEN = new clsAppPageTypeEN();
try
{
objAppPageTypeEN.AppPageTypeId = objRow[conAppPageType.AppPageTypeId].ToString().Trim(); //App页面类型Id
objAppPageTypeEN.AppPageTypeName = objRow[conAppPageType.AppPageTypeName].ToString().Trim(); //App页面类型名
objAppPageTypeEN.AppPageTypeENName = objRow[conAppPageType.AppPageTypeENName].ToString().Trim(); //App页面类型英文名
objAppPageTypeEN.UpdDate = objRow[conAppPageType.UpdDate] == DBNull.Value ? null : objRow[conAppPageType.UpdDate].ToString().Trim(); //修改日期
objAppPageTypeEN.UpdUser = objRow[conAppPageType.UpdUser] == DBNull.Value ? null : objRow[conAppPageType.UpdUser].ToString().Trim(); //修改者
objAppPageTypeEN.Memo = objRow[conAppPageType.Memo] == DBNull.Value ? null : objRow[conAppPageType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsAppPageTypeDA: GetObjByDataRowAppPageType)", objException.Message));
}
objAppPageTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objAppPageTypeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsAppPageTypeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsAppPageTypeEN objAppPageTypeEN = new clsAppPageTypeEN();
try
{
objAppPageTypeEN.AppPageTypeId = objRow[conAppPageType.AppPageTypeId].ToString().Trim(); //App页面类型Id
objAppPageTypeEN.AppPageTypeName = objRow[conAppPageType.AppPageTypeName].ToString().Trim(); //App页面类型名
objAppPageTypeEN.AppPageTypeENName = objRow[conAppPageType.AppPageTypeENName].ToString().Trim(); //App页面类型英文名
objAppPageTypeEN.UpdDate = objRow[conAppPageType.UpdDate] == DBNull.Value ? null : objRow[conAppPageType.UpdDate].ToString().Trim(); //修改日期
objAppPageTypeEN.UpdUser = objRow[conAppPageType.UpdUser] == DBNull.Value ? null : objRow[conAppPageType.UpdUser].ToString().Trim(); //修改者
objAppPageTypeEN.Memo = objRow[conAppPageType.Memo] == DBNull.Value ? null : objRow[conAppPageType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsAppPageTypeDA: GetObjByDataRow)", objException.Message));
}
objAppPageTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objAppPageTypeEN;
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
objSQL = clsAppPageTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsAppPageTypeEN._CurrTabName, conAppPageType.AppPageTypeId, 4, "");
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
objSQL = clsAppPageTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsAppPageTypeEN._CurrTabName, conAppPageType.AppPageTypeId, 4, strPrefix);
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
 objSQL = clsAppPageTypeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select AppPageTypeId from AppPageType where " + strCondition;
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
 objSQL = clsAppPageTypeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select AppPageTypeId from AppPageType where " + strCondition;
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
 /// <param name = "strAppPageTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strAppPageTypeId)
{
CheckPrimaryKey(strAppPageTypeId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppPageTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("AppPageType", "AppPageTypeId = " + "'"+ strAppPageTypeId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsAppPageTypeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppPageTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("AppPageType", strCondition))
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
objSQL = clsAppPageTypeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("AppPageType");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsAppPageTypeEN objAppPageTypeEN)
 {
 objAppPageTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objAppPageTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objAppPageTypeEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppPageTypeDA.GetSpecSQLObj();
strSQL = "Select * from AppPageType where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "AppPageType");
objRow = objDS.Tables["AppPageType"].NewRow();
objRow[conAppPageType.AppPageTypeId] = objAppPageTypeEN.AppPageTypeId; //App页面类型Id
objRow[conAppPageType.AppPageTypeName] = objAppPageTypeEN.AppPageTypeName; //App页面类型名
objRow[conAppPageType.AppPageTypeENName] = objAppPageTypeEN.AppPageTypeENName; //App页面类型英文名
 if (objAppPageTypeEN.UpdDate !=  "")
 {
objRow[conAppPageType.UpdDate] = objAppPageTypeEN.UpdDate; //修改日期
 }
 if (objAppPageTypeEN.UpdUser !=  "")
 {
objRow[conAppPageType.UpdUser] = objAppPageTypeEN.UpdUser; //修改者
 }
 if (objAppPageTypeEN.Memo !=  "")
 {
objRow[conAppPageType.Memo] = objAppPageTypeEN.Memo; //说明
 }
objDS.Tables[clsAppPageTypeEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsAppPageTypeEN._CurrTabName);
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
 /// <param name = "objAppPageTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsAppPageTypeEN objAppPageTypeEN)
{
 objAppPageTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objAppPageTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objAppPageTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objAppPageTypeEN.AppPageTypeId !=  null)
 {
 arrFieldListForInsert.Add(conAppPageType.AppPageTypeId);
 var strAppPageTypeId = objAppPageTypeEN.AppPageTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAppPageTypeId + "'");
 }
 
 if (objAppPageTypeEN.AppPageTypeName !=  null)
 {
 arrFieldListForInsert.Add(conAppPageType.AppPageTypeName);
 var strAppPageTypeName = objAppPageTypeEN.AppPageTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAppPageTypeName + "'");
 }
 
 if (objAppPageTypeEN.AppPageTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conAppPageType.AppPageTypeENName);
 var strAppPageTypeENName = objAppPageTypeEN.AppPageTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAppPageTypeENName + "'");
 }
 
 if (objAppPageTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conAppPageType.UpdDate);
 var strUpdDate = objAppPageTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objAppPageTypeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conAppPageType.UpdUser);
 var strUpdUser = objAppPageTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objAppPageTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conAppPageType.Memo);
 var strMemo = objAppPageTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into AppPageType");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppPageTypeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objAppPageTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsAppPageTypeEN objAppPageTypeEN)
{
 objAppPageTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objAppPageTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objAppPageTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objAppPageTypeEN.AppPageTypeId !=  null)
 {
 arrFieldListForInsert.Add(conAppPageType.AppPageTypeId);
 var strAppPageTypeId = objAppPageTypeEN.AppPageTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAppPageTypeId + "'");
 }
 
 if (objAppPageTypeEN.AppPageTypeName !=  null)
 {
 arrFieldListForInsert.Add(conAppPageType.AppPageTypeName);
 var strAppPageTypeName = objAppPageTypeEN.AppPageTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAppPageTypeName + "'");
 }
 
 if (objAppPageTypeEN.AppPageTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conAppPageType.AppPageTypeENName);
 var strAppPageTypeENName = objAppPageTypeEN.AppPageTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAppPageTypeENName + "'");
 }
 
 if (objAppPageTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conAppPageType.UpdDate);
 var strUpdDate = objAppPageTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objAppPageTypeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conAppPageType.UpdUser);
 var strUpdUser = objAppPageTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objAppPageTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conAppPageType.Memo);
 var strMemo = objAppPageTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into AppPageType");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppPageTypeDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objAppPageTypeEN.AppPageTypeId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objAppPageTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsAppPageTypeEN objAppPageTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objAppPageTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objAppPageTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objAppPageTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objAppPageTypeEN.AppPageTypeId !=  null)
 {
 arrFieldListForInsert.Add(conAppPageType.AppPageTypeId);
 var strAppPageTypeId = objAppPageTypeEN.AppPageTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAppPageTypeId + "'");
 }
 
 if (objAppPageTypeEN.AppPageTypeName !=  null)
 {
 arrFieldListForInsert.Add(conAppPageType.AppPageTypeName);
 var strAppPageTypeName = objAppPageTypeEN.AppPageTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAppPageTypeName + "'");
 }
 
 if (objAppPageTypeEN.AppPageTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conAppPageType.AppPageTypeENName);
 var strAppPageTypeENName = objAppPageTypeEN.AppPageTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAppPageTypeENName + "'");
 }
 
 if (objAppPageTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conAppPageType.UpdDate);
 var strUpdDate = objAppPageTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objAppPageTypeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conAppPageType.UpdUser);
 var strUpdUser = objAppPageTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objAppPageTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conAppPageType.Memo);
 var strMemo = objAppPageTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into AppPageType");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppPageTypeDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objAppPageTypeEN.AppPageTypeId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objAppPageTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsAppPageTypeEN objAppPageTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objAppPageTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objAppPageTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objAppPageTypeEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objAppPageTypeEN.AppPageTypeId !=  null)
 {
 arrFieldListForInsert.Add(conAppPageType.AppPageTypeId);
 var strAppPageTypeId = objAppPageTypeEN.AppPageTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAppPageTypeId + "'");
 }
 
 if (objAppPageTypeEN.AppPageTypeName !=  null)
 {
 arrFieldListForInsert.Add(conAppPageType.AppPageTypeName);
 var strAppPageTypeName = objAppPageTypeEN.AppPageTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAppPageTypeName + "'");
 }
 
 if (objAppPageTypeEN.AppPageTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conAppPageType.AppPageTypeENName);
 var strAppPageTypeENName = objAppPageTypeEN.AppPageTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAppPageTypeENName + "'");
 }
 
 if (objAppPageTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conAppPageType.UpdDate);
 var strUpdDate = objAppPageTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objAppPageTypeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conAppPageType.UpdUser);
 var strUpdUser = objAppPageTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objAppPageTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conAppPageType.Memo);
 var strMemo = objAppPageTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into AppPageType");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppPageTypeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewAppPageTypes(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppPageTypeDA.GetSpecSQLObj();
strSQL = "Select * from AppPageType where AppPageTypeId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "AppPageType");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strAppPageTypeId = oRow[conAppPageType.AppPageTypeId].ToString().Trim();
if (IsExist(strAppPageTypeId))
{
 string strResult = "关键字变量值为:" + string.Format("AppPageTypeId = {0}", strAppPageTypeId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsAppPageTypeEN._CurrTabName ].NewRow();
objRow[conAppPageType.AppPageTypeId] = oRow[conAppPageType.AppPageTypeId].ToString().Trim(); //App页面类型Id
objRow[conAppPageType.AppPageTypeName] = oRow[conAppPageType.AppPageTypeName].ToString().Trim(); //App页面类型名
objRow[conAppPageType.AppPageTypeENName] = oRow[conAppPageType.AppPageTypeENName].ToString().Trim(); //App页面类型英文名
objRow[conAppPageType.UpdDate] = oRow[conAppPageType.UpdDate].ToString().Trim(); //修改日期
objRow[conAppPageType.UpdUser] = oRow[conAppPageType.UpdUser].ToString().Trim(); //修改者
objRow[conAppPageType.Memo] = oRow[conAppPageType.Memo].ToString().Trim(); //说明
 objDS.Tables[clsAppPageTypeEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsAppPageTypeEN._CurrTabName);
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
 /// <param name = "objAppPageTypeEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsAppPageTypeEN objAppPageTypeEN)
{
 objAppPageTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objAppPageTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objAppPageTypeEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppPageTypeDA.GetSpecSQLObj();
strSQL = "Select * from AppPageType where AppPageTypeId = " + "'"+ objAppPageTypeEN.AppPageTypeId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsAppPageTypeEN._CurrTabName);
if (objDS.Tables[clsAppPageTypeEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:AppPageTypeId = " + "'"+ objAppPageTypeEN.AppPageTypeId+"'");
return false;
}
objRow = objDS.Tables[clsAppPageTypeEN._CurrTabName].Rows[0];
 if (objAppPageTypeEN.IsUpdated(conAppPageType.AppPageTypeId))
 {
objRow[conAppPageType.AppPageTypeId] = objAppPageTypeEN.AppPageTypeId; //App页面类型Id
 }
 if (objAppPageTypeEN.IsUpdated(conAppPageType.AppPageTypeName))
 {
objRow[conAppPageType.AppPageTypeName] = objAppPageTypeEN.AppPageTypeName; //App页面类型名
 }
 if (objAppPageTypeEN.IsUpdated(conAppPageType.AppPageTypeENName))
 {
objRow[conAppPageType.AppPageTypeENName] = objAppPageTypeEN.AppPageTypeENName; //App页面类型英文名
 }
 if (objAppPageTypeEN.IsUpdated(conAppPageType.UpdDate))
 {
objRow[conAppPageType.UpdDate] = objAppPageTypeEN.UpdDate; //修改日期
 }
 if (objAppPageTypeEN.IsUpdated(conAppPageType.UpdUser))
 {
objRow[conAppPageType.UpdUser] = objAppPageTypeEN.UpdUser; //修改者
 }
 if (objAppPageTypeEN.IsUpdated(conAppPageType.Memo))
 {
objRow[conAppPageType.Memo] = objAppPageTypeEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsAppPageTypeEN._CurrTabName);
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
 /// <param name = "objAppPageTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsAppPageTypeEN objAppPageTypeEN)
{
 objAppPageTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objAppPageTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objAppPageTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppPageTypeDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update AppPageType Set ");
 
 if (objAppPageTypeEN.IsUpdated(conAppPageType.AppPageTypeName))
 {
 if (objAppPageTypeEN.AppPageTypeName !=  null)
 {
 var strAppPageTypeName = objAppPageTypeEN.AppPageTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAppPageTypeName, conAppPageType.AppPageTypeName); //App页面类型名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAppPageType.AppPageTypeName); //App页面类型名
 }
 }
 
 if (objAppPageTypeEN.IsUpdated(conAppPageType.AppPageTypeENName))
 {
 if (objAppPageTypeEN.AppPageTypeENName !=  null)
 {
 var strAppPageTypeENName = objAppPageTypeEN.AppPageTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAppPageTypeENName, conAppPageType.AppPageTypeENName); //App页面类型英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAppPageType.AppPageTypeENName); //App页面类型英文名
 }
 }
 
 if (objAppPageTypeEN.IsUpdated(conAppPageType.UpdDate))
 {
 if (objAppPageTypeEN.UpdDate !=  null)
 {
 var strUpdDate = objAppPageTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conAppPageType.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAppPageType.UpdDate); //修改日期
 }
 }
 
 if (objAppPageTypeEN.IsUpdated(conAppPageType.UpdUser))
 {
 if (objAppPageTypeEN.UpdUser !=  null)
 {
 var strUpdUser = objAppPageTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conAppPageType.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAppPageType.UpdUser); //修改者
 }
 }
 
 if (objAppPageTypeEN.IsUpdated(conAppPageType.Memo))
 {
 if (objAppPageTypeEN.Memo !=  null)
 {
 var strMemo = objAppPageTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conAppPageType.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAppPageType.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where AppPageTypeId = '{0}'", objAppPageTypeEN.AppPageTypeId); 
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
 /// <param name = "objAppPageTypeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsAppPageTypeEN objAppPageTypeEN, string strCondition)
{
 objAppPageTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objAppPageTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objAppPageTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppPageTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update AppPageType Set ");
 
 if (objAppPageTypeEN.IsUpdated(conAppPageType.AppPageTypeName))
 {
 if (objAppPageTypeEN.AppPageTypeName !=  null)
 {
 var strAppPageTypeName = objAppPageTypeEN.AppPageTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AppPageTypeName = '{0}',", strAppPageTypeName); //App页面类型名
 }
 else
 {
 sbSQL.Append(" AppPageTypeName = null,"); //App页面类型名
 }
 }
 
 if (objAppPageTypeEN.IsUpdated(conAppPageType.AppPageTypeENName))
 {
 if (objAppPageTypeEN.AppPageTypeENName !=  null)
 {
 var strAppPageTypeENName = objAppPageTypeEN.AppPageTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AppPageTypeENName = '{0}',", strAppPageTypeENName); //App页面类型英文名
 }
 else
 {
 sbSQL.Append(" AppPageTypeENName = null,"); //App页面类型英文名
 }
 }
 
 if (objAppPageTypeEN.IsUpdated(conAppPageType.UpdDate))
 {
 if (objAppPageTypeEN.UpdDate !=  null)
 {
 var strUpdDate = objAppPageTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objAppPageTypeEN.IsUpdated(conAppPageType.UpdUser))
 {
 if (objAppPageTypeEN.UpdUser !=  null)
 {
 var strUpdUser = objAppPageTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objAppPageTypeEN.IsUpdated(conAppPageType.Memo))
 {
 if (objAppPageTypeEN.Memo !=  null)
 {
 var strMemo = objAppPageTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objAppPageTypeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsAppPageTypeEN objAppPageTypeEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objAppPageTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objAppPageTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objAppPageTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppPageTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update AppPageType Set ");
 
 if (objAppPageTypeEN.IsUpdated(conAppPageType.AppPageTypeName))
 {
 if (objAppPageTypeEN.AppPageTypeName !=  null)
 {
 var strAppPageTypeName = objAppPageTypeEN.AppPageTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AppPageTypeName = '{0}',", strAppPageTypeName); //App页面类型名
 }
 else
 {
 sbSQL.Append(" AppPageTypeName = null,"); //App页面类型名
 }
 }
 
 if (objAppPageTypeEN.IsUpdated(conAppPageType.AppPageTypeENName))
 {
 if (objAppPageTypeEN.AppPageTypeENName !=  null)
 {
 var strAppPageTypeENName = objAppPageTypeEN.AppPageTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AppPageTypeENName = '{0}',", strAppPageTypeENName); //App页面类型英文名
 }
 else
 {
 sbSQL.Append(" AppPageTypeENName = null,"); //App页面类型英文名
 }
 }
 
 if (objAppPageTypeEN.IsUpdated(conAppPageType.UpdDate))
 {
 if (objAppPageTypeEN.UpdDate !=  null)
 {
 var strUpdDate = objAppPageTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objAppPageTypeEN.IsUpdated(conAppPageType.UpdUser))
 {
 if (objAppPageTypeEN.UpdUser !=  null)
 {
 var strUpdUser = objAppPageTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objAppPageTypeEN.IsUpdated(conAppPageType.Memo))
 {
 if (objAppPageTypeEN.Memo !=  null)
 {
 var strMemo = objAppPageTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objAppPageTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsAppPageTypeEN objAppPageTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objAppPageTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objAppPageTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objAppPageTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppPageTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update AppPageType Set ");
 
 if (objAppPageTypeEN.IsUpdated(conAppPageType.AppPageTypeName))
 {
 if (objAppPageTypeEN.AppPageTypeName !=  null)
 {
 var strAppPageTypeName = objAppPageTypeEN.AppPageTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAppPageTypeName, conAppPageType.AppPageTypeName); //App页面类型名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAppPageType.AppPageTypeName); //App页面类型名
 }
 }
 
 if (objAppPageTypeEN.IsUpdated(conAppPageType.AppPageTypeENName))
 {
 if (objAppPageTypeEN.AppPageTypeENName !=  null)
 {
 var strAppPageTypeENName = objAppPageTypeEN.AppPageTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAppPageTypeENName, conAppPageType.AppPageTypeENName); //App页面类型英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAppPageType.AppPageTypeENName); //App页面类型英文名
 }
 }
 
 if (objAppPageTypeEN.IsUpdated(conAppPageType.UpdDate))
 {
 if (objAppPageTypeEN.UpdDate !=  null)
 {
 var strUpdDate = objAppPageTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conAppPageType.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAppPageType.UpdDate); //修改日期
 }
 }
 
 if (objAppPageTypeEN.IsUpdated(conAppPageType.UpdUser))
 {
 if (objAppPageTypeEN.UpdUser !=  null)
 {
 var strUpdUser = objAppPageTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conAppPageType.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAppPageType.UpdUser); //修改者
 }
 }
 
 if (objAppPageTypeEN.IsUpdated(conAppPageType.Memo))
 {
 if (objAppPageTypeEN.Memo !=  null)
 {
 var strMemo = objAppPageTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conAppPageType.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAppPageType.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where AppPageTypeId = '{0}'", objAppPageTypeEN.AppPageTypeId); 
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
 /// <param name = "strAppPageTypeId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strAppPageTypeId) 
{
CheckPrimaryKey(strAppPageTypeId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppPageTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strAppPageTypeId,
};
 objSQL.ExecSP("AppPageType_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strAppPageTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strAppPageTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strAppPageTypeId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppPageTypeDA.GetSpecSQLObj();
//删除AppPageType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from AppPageType where AppPageTypeId = " + "'"+ strAppPageTypeId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelAppPageType(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppPageTypeDA.GetSpecSQLObj();
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
//删除AppPageType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from AppPageType where AppPageTypeId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strAppPageTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strAppPageTypeId) 
{
CheckPrimaryKey(strAppPageTypeId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppPageTypeDA.GetSpecSQLObj();
//删除AppPageType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from AppPageType where AppPageTypeId = " + "'"+ strAppPageTypeId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelAppPageType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsAppPageTypeDA: DelAppPageType)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppPageTypeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from AppPageType where " + strCondition ;
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
public bool DelAppPageTypeWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsAppPageTypeDA: DelAppPageTypeWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppPageTypeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from AppPageType where " + strCondition ;
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
 /// <param name = "objAppPageTypeENS">源对象</param>
 /// <param name = "objAppPageTypeENT">目标对象</param>
public void CopyTo(clsAppPageTypeEN objAppPageTypeENS, clsAppPageTypeEN objAppPageTypeENT)
{
objAppPageTypeENT.AppPageTypeId = objAppPageTypeENS.AppPageTypeId; //App页面类型Id
objAppPageTypeENT.AppPageTypeName = objAppPageTypeENS.AppPageTypeName; //App页面类型名
objAppPageTypeENT.AppPageTypeENName = objAppPageTypeENS.AppPageTypeENName; //App页面类型英文名
objAppPageTypeENT.UpdDate = objAppPageTypeENS.UpdDate; //修改日期
objAppPageTypeENT.UpdUser = objAppPageTypeENS.UpdUser; //修改者
objAppPageTypeENT.Memo = objAppPageTypeENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsAppPageTypeEN objAppPageTypeEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objAppPageTypeEN.AppPageTypeName, conAppPageType.AppPageTypeName);
clsCheckSql.CheckFieldNotNull(objAppPageTypeEN.AppPageTypeENName, conAppPageType.AppPageTypeENName);
//检查字段长度
clsCheckSql.CheckFieldLen(objAppPageTypeEN.AppPageTypeId, 4, conAppPageType.AppPageTypeId);
clsCheckSql.CheckFieldLen(objAppPageTypeEN.AppPageTypeName, 50, conAppPageType.AppPageTypeName);
clsCheckSql.CheckFieldLen(objAppPageTypeEN.AppPageTypeENName, 50, conAppPageType.AppPageTypeENName);
clsCheckSql.CheckFieldLen(objAppPageTypeEN.UpdDate, 20, conAppPageType.UpdDate);
clsCheckSql.CheckFieldLen(objAppPageTypeEN.UpdUser, 20, conAppPageType.UpdUser);
clsCheckSql.CheckFieldLen(objAppPageTypeEN.Memo, 1000, conAppPageType.Memo);
//检查字段外键固定长度
 objAppPageTypeEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsAppPageTypeEN objAppPageTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objAppPageTypeEN.AppPageTypeName, 50, conAppPageType.AppPageTypeName);
clsCheckSql.CheckFieldLen(objAppPageTypeEN.AppPageTypeENName, 50, conAppPageType.AppPageTypeENName);
clsCheckSql.CheckFieldLen(objAppPageTypeEN.UpdDate, 20, conAppPageType.UpdDate);
clsCheckSql.CheckFieldLen(objAppPageTypeEN.UpdUser, 20, conAppPageType.UpdUser);
clsCheckSql.CheckFieldLen(objAppPageTypeEN.Memo, 1000, conAppPageType.Memo);
//检查外键字段长度
 objAppPageTypeEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsAppPageTypeEN objAppPageTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objAppPageTypeEN.AppPageTypeId, 4, conAppPageType.AppPageTypeId);
clsCheckSql.CheckFieldLen(objAppPageTypeEN.AppPageTypeName, 50, conAppPageType.AppPageTypeName);
clsCheckSql.CheckFieldLen(objAppPageTypeEN.AppPageTypeENName, 50, conAppPageType.AppPageTypeENName);
clsCheckSql.CheckFieldLen(objAppPageTypeEN.UpdDate, 20, conAppPageType.UpdDate);
clsCheckSql.CheckFieldLen(objAppPageTypeEN.UpdUser, 20, conAppPageType.UpdUser);
clsCheckSql.CheckFieldLen(objAppPageTypeEN.Memo, 1000, conAppPageType.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objAppPageTypeEN.AppPageTypeId, conAppPageType.AppPageTypeId);
clsCheckSql.CheckSqlInjection4Field(objAppPageTypeEN.AppPageTypeName, conAppPageType.AppPageTypeName);
clsCheckSql.CheckSqlInjection4Field(objAppPageTypeEN.AppPageTypeENName, conAppPageType.AppPageTypeENName);
clsCheckSql.CheckSqlInjection4Field(objAppPageTypeEN.UpdDate, conAppPageType.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objAppPageTypeEN.UpdUser, conAppPageType.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objAppPageTypeEN.Memo, conAppPageType.Memo);
//检查外键字段长度
 objAppPageTypeEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetAppPageTypeId()
{
//获取某学院所有专业信息
string strSQL = "select AppPageTypeId, AppPageTypeName from AppPageType ";
 clsSpecSQLforSql mySql = clsAppPageTypeDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--AppPageType(App页面类型),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objAppPageTypeEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsAppPageTypeEN objAppPageTypeEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and AppPageTypeName = '{0}'", objAppPageTypeEN.AppPageTypeName);
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
 objSQL = clsAppPageTypeDA.GetSpecSQLObj();
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
 objSQL = clsAppPageTypeDA.GetSpecSQLObj();
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
 objSQL = clsAppPageTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsAppPageTypeEN._CurrTabName);
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
 objSQL = clsAppPageTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsAppPageTypeEN._CurrTabName, strCondition);
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
 objSQL = clsAppPageTypeDA.GetSpecSQLObj();
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
 objSQL = clsAppPageTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}