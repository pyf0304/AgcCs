
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsWebSrvClassDA
 表名:WebSrvClass(00050344)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:32:44
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
 /// WebSrv类(WebSrvClass)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsWebSrvClassDA : clsCommBase4DA
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
 return clsWebSrvClassEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsWebSrvClassEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsWebSrvClassEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsWebSrvClassEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsWebSrvClassEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strWebSrvClassId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strWebSrvClassId)
{
strWebSrvClassId = strWebSrvClassId.Replace("'", "''");
if (strWebSrvClassId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:WebSrvClass中,检查关键字,长度不正确!(clsWebSrvClassDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strWebSrvClassId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:WebSrvClass中,关键字不能为空 或 null!(clsWebSrvClassDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strWebSrvClassId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsWebSrvClassDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsWebSrvClassDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvClassDA.GetSpecSQLObj();
strSQL = "Select * from WebSrvClass where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_WebSrvClass(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsWebSrvClassDA: GetDataTable_WebSrvClass)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvClassDA.GetSpecSQLObj();
strSQL = "Select * from WebSrvClass where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsWebSrvClassDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvClassDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsWebSrvClassDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvClassDA.GetSpecSQLObj();
strSQL = "Select * from WebSrvClass where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsWebSrvClassDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvClassDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsWebSrvClassDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvClassDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from WebSrvClass where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from WebSrvClass where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsWebSrvClassDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvClassDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from WebSrvClass where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsWebSrvClassDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvClassDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} WebSrvClass.* " + 
$"from WebSrvClass " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and WebSrvClass.WebSrvClassId not in " + 
$"(Select top {intTop_In} WebSrvClass.WebSrvClassId from WebSrvClass " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from WebSrvClass where {1} and WebSrvClassId not in (Select top {2} WebSrvClassId from WebSrvClass where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from WebSrvClass where {1} and WebSrvClassId not in (Select top {3} WebSrvClassId from WebSrvClass where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsWebSrvClassDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvClassDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} WebSrvClass.* " + 
$"from WebSrvClass " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and WebSrvClass.WebSrvClassId not in " + 
$"(Select top {intTop_In} WebSrvClass.WebSrvClassId from WebSrvClass " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from WebSrvClass where {1} and WebSrvClassId not in (Select top {2} WebSrvClassId from WebSrvClass where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from WebSrvClass where {1} and WebSrvClassId not in (Select top {3} WebSrvClassId from WebSrvClass where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsWebSrvClassEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsWebSrvClassDA:GetObjLst)", objException.Message));
}
List<clsWebSrvClassEN> arrObjLst = new List<clsWebSrvClassEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvClassDA.GetSpecSQLObj();
strSQL = "Select * from WebSrvClass where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsWebSrvClassEN objWebSrvClassEN = new clsWebSrvClassEN();
try
{
objWebSrvClassEN.WebSrvClassId = objRow[conWebSrvClass.WebSrvClassId].ToString().Trim(); //类Id
objWebSrvClassEN.NameSpace = objRow[conWebSrvClass.NameSpace] == DBNull.Value ? null : objRow[conWebSrvClass.NameSpace].ToString().Trim(); //域名
objWebSrvClassEN.WebSrvUrl = objRow[conWebSrvClass.WebSrvUrl].ToString().Trim(); //WebSrv地址
objWebSrvClassEN.PageName = objRow[conWebSrvClass.PageName].ToString().Trim(); //页面名称
objWebSrvClassEN.FuncModuleAgcId = objRow[conWebSrvClass.FuncModuleAgcId] == DBNull.Value ? null : objRow[conWebSrvClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objWebSrvClassEN.IsNeedGene = TransNullToBool(objRow[conWebSrvClass.IsNeedGene].ToString().Trim()); //是否需要生成
objWebSrvClassEN.PrjId = objRow[conWebSrvClass.PrjId].ToString().Trim(); //工程Id
objWebSrvClassEN.UpdDate = objRow[conWebSrvClass.UpdDate] == DBNull.Value ? null : objRow[conWebSrvClass.UpdDate].ToString().Trim(); //修改日期
objWebSrvClassEN.UpdUser = objRow[conWebSrvClass.UpdUser] == DBNull.Value ? null : objRow[conWebSrvClass.UpdUser].ToString().Trim(); //修改者
objWebSrvClassEN.Memo = objRow[conWebSrvClass.Memo] == DBNull.Value ? null : objRow[conWebSrvClass.Memo].ToString().Trim(); //说明
objWebSrvClassEN.CodeTypeId = objRow[conWebSrvClass.CodeTypeId].ToString().Trim(); //代码类型Id
objWebSrvClassEN.ClsName = objRow[conWebSrvClass.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsWebSrvClassDA: GetObjLst)", objException.Message));
}
objWebSrvClassEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objWebSrvClassEN);
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
public List<clsWebSrvClassEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsWebSrvClassDA:GetObjLstByTabName)", objException.Message));
}
List<clsWebSrvClassEN> arrObjLst = new List<clsWebSrvClassEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvClassDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsWebSrvClassEN objWebSrvClassEN = new clsWebSrvClassEN();
try
{
objWebSrvClassEN.WebSrvClassId = objRow[conWebSrvClass.WebSrvClassId].ToString().Trim(); //类Id
objWebSrvClassEN.NameSpace = objRow[conWebSrvClass.NameSpace] == DBNull.Value ? null : objRow[conWebSrvClass.NameSpace].ToString().Trim(); //域名
objWebSrvClassEN.WebSrvUrl = objRow[conWebSrvClass.WebSrvUrl].ToString().Trim(); //WebSrv地址
objWebSrvClassEN.PageName = objRow[conWebSrvClass.PageName].ToString().Trim(); //页面名称
objWebSrvClassEN.FuncModuleAgcId = objRow[conWebSrvClass.FuncModuleAgcId] == DBNull.Value ? null : objRow[conWebSrvClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objWebSrvClassEN.IsNeedGene = TransNullToBool(objRow[conWebSrvClass.IsNeedGene].ToString().Trim()); //是否需要生成
objWebSrvClassEN.PrjId = objRow[conWebSrvClass.PrjId].ToString().Trim(); //工程Id
objWebSrvClassEN.UpdDate = objRow[conWebSrvClass.UpdDate] == DBNull.Value ? null : objRow[conWebSrvClass.UpdDate].ToString().Trim(); //修改日期
objWebSrvClassEN.UpdUser = objRow[conWebSrvClass.UpdUser] == DBNull.Value ? null : objRow[conWebSrvClass.UpdUser].ToString().Trim(); //修改者
objWebSrvClassEN.Memo = objRow[conWebSrvClass.Memo] == DBNull.Value ? null : objRow[conWebSrvClass.Memo].ToString().Trim(); //说明
objWebSrvClassEN.CodeTypeId = objRow[conWebSrvClass.CodeTypeId].ToString().Trim(); //代码类型Id
objWebSrvClassEN.ClsName = objRow[conWebSrvClass.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsWebSrvClassDA: GetObjLst)", objException.Message));
}
objWebSrvClassEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objWebSrvClassEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objWebSrvClassEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetWebSrvClass(ref clsWebSrvClassEN objWebSrvClassEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvClassDA.GetSpecSQLObj();
strSQL = "Select * from WebSrvClass where WebSrvClassId = " + "'"+ objWebSrvClassEN.WebSrvClassId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objWebSrvClassEN.WebSrvClassId = objDT.Rows[0][conWebSrvClass.WebSrvClassId].ToString().Trim(); //类Id(字段类型:char,字段长度:8,是否可空:False)
 objWebSrvClassEN.NameSpace = objDT.Rows[0][conWebSrvClass.NameSpace].ToString().Trim(); //域名(字段类型:varchar,字段长度:50,是否可空:True)
 objWebSrvClassEN.WebSrvUrl = objDT.Rows[0][conWebSrvClass.WebSrvUrl].ToString().Trim(); //WebSrv地址(字段类型:varchar,字段长度:300,是否可空:False)
 objWebSrvClassEN.PageName = objDT.Rows[0][conWebSrvClass.PageName].ToString().Trim(); //页面名称(字段类型:varchar,字段长度:100,是否可空:True)
 objWebSrvClassEN.FuncModuleAgcId = objDT.Rows[0][conWebSrvClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objWebSrvClassEN.IsNeedGene = TransNullToBool(objDT.Rows[0][conWebSrvClass.IsNeedGene].ToString().Trim()); //是否需要生成(字段类型:bit,字段长度:1,是否可空:True)
 objWebSrvClassEN.PrjId = objDT.Rows[0][conWebSrvClass.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objWebSrvClassEN.UpdDate = objDT.Rows[0][conWebSrvClass.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objWebSrvClassEN.UpdUser = objDT.Rows[0][conWebSrvClass.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objWebSrvClassEN.Memo = objDT.Rows[0][conWebSrvClass.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objWebSrvClassEN.CodeTypeId = objDT.Rows[0][conWebSrvClass.CodeTypeId].ToString().Trim(); //代码类型Id(字段类型:char,字段长度:4,是否可空:False)
 objWebSrvClassEN.ClsName = objDT.Rows[0][conWebSrvClass.ClsName].ToString().Trim(); //类名(字段类型:varchar,字段长度:100,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsWebSrvClassDA: GetWebSrvClass)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strWebSrvClassId">表关键字</param>
 /// <returns>表对象</returns>
public clsWebSrvClassEN GetObjByWebSrvClassId(string strWebSrvClassId)
{
CheckPrimaryKey(strWebSrvClassId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvClassDA.GetSpecSQLObj();
strSQL = "Select * from WebSrvClass where WebSrvClassId = " + "'"+ strWebSrvClassId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsWebSrvClassEN objWebSrvClassEN = new clsWebSrvClassEN();
try
{
 objWebSrvClassEN.WebSrvClassId = objRow[conWebSrvClass.WebSrvClassId].ToString().Trim(); //类Id(字段类型:char,字段长度:8,是否可空:False)
 objWebSrvClassEN.NameSpace = objRow[conWebSrvClass.NameSpace] == DBNull.Value ? null : objRow[conWebSrvClass.NameSpace].ToString().Trim(); //域名(字段类型:varchar,字段长度:50,是否可空:True)
 objWebSrvClassEN.WebSrvUrl = objRow[conWebSrvClass.WebSrvUrl].ToString().Trim(); //WebSrv地址(字段类型:varchar,字段长度:300,是否可空:False)
 objWebSrvClassEN.PageName = objRow[conWebSrvClass.PageName].ToString().Trim(); //页面名称(字段类型:varchar,字段长度:100,是否可空:True)
 objWebSrvClassEN.FuncModuleAgcId = objRow[conWebSrvClass.FuncModuleAgcId] == DBNull.Value ? null : objRow[conWebSrvClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objWebSrvClassEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[conWebSrvClass.IsNeedGene].ToString().Trim()); //是否需要生成(字段类型:bit,字段长度:1,是否可空:True)
 objWebSrvClassEN.PrjId = objRow[conWebSrvClass.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objWebSrvClassEN.UpdDate = objRow[conWebSrvClass.UpdDate] == DBNull.Value ? null : objRow[conWebSrvClass.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objWebSrvClassEN.UpdUser = objRow[conWebSrvClass.UpdUser] == DBNull.Value ? null : objRow[conWebSrvClass.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objWebSrvClassEN.Memo = objRow[conWebSrvClass.Memo] == DBNull.Value ? null : objRow[conWebSrvClass.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objWebSrvClassEN.CodeTypeId = objRow[conWebSrvClass.CodeTypeId].ToString().Trim(); //代码类型Id(字段类型:char,字段长度:4,是否可空:False)
 objWebSrvClassEN.ClsName = objRow[conWebSrvClass.ClsName].ToString().Trim(); //类名(字段类型:varchar,字段长度:100,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsWebSrvClassDA: GetObjByWebSrvClassId)", objException.Message));
}
return objWebSrvClassEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsWebSrvClassEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsWebSrvClassDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvClassDA.GetSpecSQLObj();
strSQL = "Select * from WebSrvClass where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsWebSrvClassEN objWebSrvClassEN = new clsWebSrvClassEN()
{
WebSrvClassId = objRow[conWebSrvClass.WebSrvClassId].ToString().Trim(), //类Id
NameSpace = objRow[conWebSrvClass.NameSpace] == DBNull.Value ? null : objRow[conWebSrvClass.NameSpace].ToString().Trim(), //域名
WebSrvUrl = objRow[conWebSrvClass.WebSrvUrl].ToString().Trim(), //WebSrv地址
PageName = objRow[conWebSrvClass.PageName].ToString().Trim(), //页面名称
FuncModuleAgcId = objRow[conWebSrvClass.FuncModuleAgcId] == DBNull.Value ? null : objRow[conWebSrvClass.FuncModuleAgcId].ToString().Trim(), //功能模块Id
IsNeedGene = TransNullToBool(objRow[conWebSrvClass.IsNeedGene].ToString().Trim()), //是否需要生成
PrjId = objRow[conWebSrvClass.PrjId].ToString().Trim(), //工程Id
UpdDate = objRow[conWebSrvClass.UpdDate] == DBNull.Value ? null : objRow[conWebSrvClass.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conWebSrvClass.UpdUser] == DBNull.Value ? null : objRow[conWebSrvClass.UpdUser].ToString().Trim(), //修改者
Memo = objRow[conWebSrvClass.Memo] == DBNull.Value ? null : objRow[conWebSrvClass.Memo].ToString().Trim(), //说明
CodeTypeId = objRow[conWebSrvClass.CodeTypeId].ToString().Trim(), //代码类型Id
ClsName = objRow[conWebSrvClass.ClsName].ToString().Trim() //类名
};
objWebSrvClassEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objWebSrvClassEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsWebSrvClassDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsWebSrvClassEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsWebSrvClassEN objWebSrvClassEN = new clsWebSrvClassEN();
try
{
objWebSrvClassEN.WebSrvClassId = objRow[conWebSrvClass.WebSrvClassId].ToString().Trim(); //类Id
objWebSrvClassEN.NameSpace = objRow[conWebSrvClass.NameSpace] == DBNull.Value ? null : objRow[conWebSrvClass.NameSpace].ToString().Trim(); //域名
objWebSrvClassEN.WebSrvUrl = objRow[conWebSrvClass.WebSrvUrl].ToString().Trim(); //WebSrv地址
objWebSrvClassEN.PageName = objRow[conWebSrvClass.PageName].ToString().Trim(); //页面名称
objWebSrvClassEN.FuncModuleAgcId = objRow[conWebSrvClass.FuncModuleAgcId] == DBNull.Value ? null : objRow[conWebSrvClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objWebSrvClassEN.IsNeedGene = TransNullToBool(objRow[conWebSrvClass.IsNeedGene].ToString().Trim()); //是否需要生成
objWebSrvClassEN.PrjId = objRow[conWebSrvClass.PrjId].ToString().Trim(); //工程Id
objWebSrvClassEN.UpdDate = objRow[conWebSrvClass.UpdDate] == DBNull.Value ? null : objRow[conWebSrvClass.UpdDate].ToString().Trim(); //修改日期
objWebSrvClassEN.UpdUser = objRow[conWebSrvClass.UpdUser] == DBNull.Value ? null : objRow[conWebSrvClass.UpdUser].ToString().Trim(); //修改者
objWebSrvClassEN.Memo = objRow[conWebSrvClass.Memo] == DBNull.Value ? null : objRow[conWebSrvClass.Memo].ToString().Trim(); //说明
objWebSrvClassEN.CodeTypeId = objRow[conWebSrvClass.CodeTypeId].ToString().Trim(); //代码类型Id
objWebSrvClassEN.ClsName = objRow[conWebSrvClass.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsWebSrvClassDA: GetObjByDataRowWebSrvClass)", objException.Message));
}
objWebSrvClassEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objWebSrvClassEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsWebSrvClassEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsWebSrvClassEN objWebSrvClassEN = new clsWebSrvClassEN();
try
{
objWebSrvClassEN.WebSrvClassId = objRow[conWebSrvClass.WebSrvClassId].ToString().Trim(); //类Id
objWebSrvClassEN.NameSpace = objRow[conWebSrvClass.NameSpace] == DBNull.Value ? null : objRow[conWebSrvClass.NameSpace].ToString().Trim(); //域名
objWebSrvClassEN.WebSrvUrl = objRow[conWebSrvClass.WebSrvUrl].ToString().Trim(); //WebSrv地址
objWebSrvClassEN.PageName = objRow[conWebSrvClass.PageName].ToString().Trim(); //页面名称
objWebSrvClassEN.FuncModuleAgcId = objRow[conWebSrvClass.FuncModuleAgcId] == DBNull.Value ? null : objRow[conWebSrvClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objWebSrvClassEN.IsNeedGene = TransNullToBool(objRow[conWebSrvClass.IsNeedGene].ToString().Trim()); //是否需要生成
objWebSrvClassEN.PrjId = objRow[conWebSrvClass.PrjId].ToString().Trim(); //工程Id
objWebSrvClassEN.UpdDate = objRow[conWebSrvClass.UpdDate] == DBNull.Value ? null : objRow[conWebSrvClass.UpdDate].ToString().Trim(); //修改日期
objWebSrvClassEN.UpdUser = objRow[conWebSrvClass.UpdUser] == DBNull.Value ? null : objRow[conWebSrvClass.UpdUser].ToString().Trim(); //修改者
objWebSrvClassEN.Memo = objRow[conWebSrvClass.Memo] == DBNull.Value ? null : objRow[conWebSrvClass.Memo].ToString().Trim(); //说明
objWebSrvClassEN.CodeTypeId = objRow[conWebSrvClass.CodeTypeId].ToString().Trim(); //代码类型Id
objWebSrvClassEN.ClsName = objRow[conWebSrvClass.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsWebSrvClassDA: GetObjByDataRow)", objException.Message));
}
objWebSrvClassEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objWebSrvClassEN;
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
objSQL = clsWebSrvClassDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsWebSrvClassEN._CurrTabName, conWebSrvClass.WebSrvClassId, 8, "");
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
objSQL = clsWebSrvClassDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsWebSrvClassEN._CurrTabName, conWebSrvClass.WebSrvClassId, 8, strPrefix);
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
 objSQL = clsWebSrvClassDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select WebSrvClassId from WebSrvClass where " + strCondition;
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
 objSQL = clsWebSrvClassDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select WebSrvClassId from WebSrvClass where " + strCondition;
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
 /// <param name = "strWebSrvClassId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strWebSrvClassId)
{
CheckPrimaryKey(strWebSrvClassId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvClassDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("WebSrvClass", "WebSrvClassId = " + "'"+ strWebSrvClassId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsWebSrvClassDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvClassDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("WebSrvClass", strCondition))
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
objSQL = clsWebSrvClassDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("WebSrvClass");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsWebSrvClassEN objWebSrvClassEN)
 {
 objWebSrvClassEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objWebSrvClassEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objWebSrvClassEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvClassDA.GetSpecSQLObj();
strSQL = "Select * from WebSrvClass where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "WebSrvClass");
objRow = objDS.Tables["WebSrvClass"].NewRow();
objRow[conWebSrvClass.WebSrvClassId] = objWebSrvClassEN.WebSrvClassId; //类Id
 if (objWebSrvClassEN.NameSpace !=  "")
 {
objRow[conWebSrvClass.NameSpace] = objWebSrvClassEN.NameSpace; //域名
 }
objRow[conWebSrvClass.WebSrvUrl] = objWebSrvClassEN.WebSrvUrl; //WebSrv地址
objRow[conWebSrvClass.PageName] = objWebSrvClassEN.PageName; //页面名称
 if (objWebSrvClassEN.FuncModuleAgcId !=  "")
 {
objRow[conWebSrvClass.FuncModuleAgcId] = objWebSrvClassEN.FuncModuleAgcId; //功能模块Id
 }
objRow[conWebSrvClass.IsNeedGene] = objWebSrvClassEN.IsNeedGene; //是否需要生成
objRow[conWebSrvClass.PrjId] = objWebSrvClassEN.PrjId; //工程Id
 if (objWebSrvClassEN.UpdDate !=  "")
 {
objRow[conWebSrvClass.UpdDate] = objWebSrvClassEN.UpdDate; //修改日期
 }
 if (objWebSrvClassEN.UpdUser !=  "")
 {
objRow[conWebSrvClass.UpdUser] = objWebSrvClassEN.UpdUser; //修改者
 }
 if (objWebSrvClassEN.Memo !=  "")
 {
objRow[conWebSrvClass.Memo] = objWebSrvClassEN.Memo; //说明
 }
objRow[conWebSrvClass.CodeTypeId] = objWebSrvClassEN.CodeTypeId; //代码类型Id
objRow[conWebSrvClass.ClsName] = objWebSrvClassEN.ClsName; //类名
objDS.Tables[clsWebSrvClassEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsWebSrvClassEN._CurrTabName);
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
 /// <param name = "objWebSrvClassEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsWebSrvClassEN objWebSrvClassEN)
{
 objWebSrvClassEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objWebSrvClassEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objWebSrvClassEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objWebSrvClassEN.WebSrvClassId !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvClass.WebSrvClassId);
 var strWebSrvClassId = objWebSrvClassEN.WebSrvClassId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWebSrvClassId + "'");
 }
 
 if (objWebSrvClassEN.NameSpace !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvClass.NameSpace);
 var strNameSpace = objWebSrvClassEN.NameSpace.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNameSpace + "'");
 }
 
 if (objWebSrvClassEN.WebSrvUrl !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvClass.WebSrvUrl);
 var strWebSrvUrl = objWebSrvClassEN.WebSrvUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWebSrvUrl + "'");
 }
 
 if (objWebSrvClassEN.PageName !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvClass.PageName);
 var strPageName = objWebSrvClassEN.PageName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPageName + "'");
 }
 
 if (objWebSrvClassEN.FuncModuleAgcId !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvClass.FuncModuleAgcId);
 var strFuncModuleAgcId = objWebSrvClassEN.FuncModuleAgcId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleAgcId + "'");
 }
 
 arrFieldListForInsert.Add(conWebSrvClass.IsNeedGene);
 arrValueListForInsert.Add("'" + (objWebSrvClassEN.IsNeedGene  ==  false ? "0" : "1") + "'");
 
 if (objWebSrvClassEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvClass.PrjId);
 var strPrjId = objWebSrvClassEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objWebSrvClassEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvClass.UpdDate);
 var strUpdDate = objWebSrvClassEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objWebSrvClassEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvClass.UpdUser);
 var strUpdUser = objWebSrvClassEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objWebSrvClassEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvClass.Memo);
 var strMemo = objWebSrvClassEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objWebSrvClassEN.CodeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvClass.CodeTypeId);
 var strCodeTypeId = objWebSrvClassEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTypeId + "'");
 }
 
 if (objWebSrvClassEN.ClsName !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvClass.ClsName);
 var strClsName = objWebSrvClassEN.ClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClsName + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into WebSrvClass");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvClassDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objWebSrvClassEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsWebSrvClassEN objWebSrvClassEN)
{
 objWebSrvClassEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objWebSrvClassEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objWebSrvClassEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objWebSrvClassEN.WebSrvClassId !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvClass.WebSrvClassId);
 var strWebSrvClassId = objWebSrvClassEN.WebSrvClassId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWebSrvClassId + "'");
 }
 
 if (objWebSrvClassEN.NameSpace !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvClass.NameSpace);
 var strNameSpace = objWebSrvClassEN.NameSpace.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNameSpace + "'");
 }
 
 if (objWebSrvClassEN.WebSrvUrl !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvClass.WebSrvUrl);
 var strWebSrvUrl = objWebSrvClassEN.WebSrvUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWebSrvUrl + "'");
 }
 
 if (objWebSrvClassEN.PageName !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvClass.PageName);
 var strPageName = objWebSrvClassEN.PageName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPageName + "'");
 }
 
 if (objWebSrvClassEN.FuncModuleAgcId !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvClass.FuncModuleAgcId);
 var strFuncModuleAgcId = objWebSrvClassEN.FuncModuleAgcId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleAgcId + "'");
 }
 
 arrFieldListForInsert.Add(conWebSrvClass.IsNeedGene);
 arrValueListForInsert.Add("'" + (objWebSrvClassEN.IsNeedGene  ==  false ? "0" : "1") + "'");
 
 if (objWebSrvClassEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvClass.PrjId);
 var strPrjId = objWebSrvClassEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objWebSrvClassEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvClass.UpdDate);
 var strUpdDate = objWebSrvClassEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objWebSrvClassEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvClass.UpdUser);
 var strUpdUser = objWebSrvClassEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objWebSrvClassEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvClass.Memo);
 var strMemo = objWebSrvClassEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objWebSrvClassEN.CodeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvClass.CodeTypeId);
 var strCodeTypeId = objWebSrvClassEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTypeId + "'");
 }
 
 if (objWebSrvClassEN.ClsName !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvClass.ClsName);
 var strClsName = objWebSrvClassEN.ClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClsName + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into WebSrvClass");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvClassDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objWebSrvClassEN.WebSrvClassId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objWebSrvClassEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsWebSrvClassEN objWebSrvClassEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objWebSrvClassEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objWebSrvClassEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objWebSrvClassEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objWebSrvClassEN.WebSrvClassId !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvClass.WebSrvClassId);
 var strWebSrvClassId = objWebSrvClassEN.WebSrvClassId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWebSrvClassId + "'");
 }
 
 if (objWebSrvClassEN.NameSpace !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvClass.NameSpace);
 var strNameSpace = objWebSrvClassEN.NameSpace.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNameSpace + "'");
 }
 
 if (objWebSrvClassEN.WebSrvUrl !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvClass.WebSrvUrl);
 var strWebSrvUrl = objWebSrvClassEN.WebSrvUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWebSrvUrl + "'");
 }
 
 if (objWebSrvClassEN.PageName !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvClass.PageName);
 var strPageName = objWebSrvClassEN.PageName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPageName + "'");
 }
 
 if (objWebSrvClassEN.FuncModuleAgcId !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvClass.FuncModuleAgcId);
 var strFuncModuleAgcId = objWebSrvClassEN.FuncModuleAgcId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleAgcId + "'");
 }
 
 arrFieldListForInsert.Add(conWebSrvClass.IsNeedGene);
 arrValueListForInsert.Add("'" + (objWebSrvClassEN.IsNeedGene  ==  false ? "0" : "1") + "'");
 
 if (objWebSrvClassEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvClass.PrjId);
 var strPrjId = objWebSrvClassEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objWebSrvClassEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvClass.UpdDate);
 var strUpdDate = objWebSrvClassEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objWebSrvClassEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvClass.UpdUser);
 var strUpdUser = objWebSrvClassEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objWebSrvClassEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvClass.Memo);
 var strMemo = objWebSrvClassEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objWebSrvClassEN.CodeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvClass.CodeTypeId);
 var strCodeTypeId = objWebSrvClassEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTypeId + "'");
 }
 
 if (objWebSrvClassEN.ClsName !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvClass.ClsName);
 var strClsName = objWebSrvClassEN.ClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClsName + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into WebSrvClass");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvClassDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objWebSrvClassEN.WebSrvClassId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objWebSrvClassEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsWebSrvClassEN objWebSrvClassEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objWebSrvClassEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objWebSrvClassEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objWebSrvClassEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objWebSrvClassEN.WebSrvClassId !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvClass.WebSrvClassId);
 var strWebSrvClassId = objWebSrvClassEN.WebSrvClassId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWebSrvClassId + "'");
 }
 
 if (objWebSrvClassEN.NameSpace !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvClass.NameSpace);
 var strNameSpace = objWebSrvClassEN.NameSpace.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNameSpace + "'");
 }
 
 if (objWebSrvClassEN.WebSrvUrl !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvClass.WebSrvUrl);
 var strWebSrvUrl = objWebSrvClassEN.WebSrvUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWebSrvUrl + "'");
 }
 
 if (objWebSrvClassEN.PageName !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvClass.PageName);
 var strPageName = objWebSrvClassEN.PageName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPageName + "'");
 }
 
 if (objWebSrvClassEN.FuncModuleAgcId !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvClass.FuncModuleAgcId);
 var strFuncModuleAgcId = objWebSrvClassEN.FuncModuleAgcId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleAgcId + "'");
 }
 
 arrFieldListForInsert.Add(conWebSrvClass.IsNeedGene);
 arrValueListForInsert.Add("'" + (objWebSrvClassEN.IsNeedGene  ==  false ? "0" : "1") + "'");
 
 if (objWebSrvClassEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvClass.PrjId);
 var strPrjId = objWebSrvClassEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objWebSrvClassEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvClass.UpdDate);
 var strUpdDate = objWebSrvClassEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objWebSrvClassEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvClass.UpdUser);
 var strUpdUser = objWebSrvClassEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objWebSrvClassEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvClass.Memo);
 var strMemo = objWebSrvClassEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objWebSrvClassEN.CodeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvClass.CodeTypeId);
 var strCodeTypeId = objWebSrvClassEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTypeId + "'");
 }
 
 if (objWebSrvClassEN.ClsName !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvClass.ClsName);
 var strClsName = objWebSrvClassEN.ClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClsName + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into WebSrvClass");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvClassDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewWebSrvClasss(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvClassDA.GetSpecSQLObj();
strSQL = "Select * from WebSrvClass where WebSrvClassId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "WebSrvClass");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strWebSrvClassId = oRow[conWebSrvClass.WebSrvClassId].ToString().Trim();
if (IsExist(strWebSrvClassId))
{
 string strResult = "关键字变量值为:" + string.Format("WebSrvClassId = {0}", strWebSrvClassId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsWebSrvClassEN._CurrTabName ].NewRow();
objRow[conWebSrvClass.WebSrvClassId] = oRow[conWebSrvClass.WebSrvClassId].ToString().Trim(); //类Id
objRow[conWebSrvClass.NameSpace] = oRow[conWebSrvClass.NameSpace].ToString().Trim(); //域名
objRow[conWebSrvClass.WebSrvUrl] = oRow[conWebSrvClass.WebSrvUrl].ToString().Trim(); //WebSrv地址
objRow[conWebSrvClass.PageName] = oRow[conWebSrvClass.PageName].ToString().Trim(); //页面名称
objRow[conWebSrvClass.FuncModuleAgcId] = oRow[conWebSrvClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objRow[conWebSrvClass.IsNeedGene] = oRow[conWebSrvClass.IsNeedGene].ToString().Trim(); //是否需要生成
objRow[conWebSrvClass.PrjId] = oRow[conWebSrvClass.PrjId].ToString().Trim(); //工程Id
objRow[conWebSrvClass.UpdDate] = oRow[conWebSrvClass.UpdDate].ToString().Trim(); //修改日期
objRow[conWebSrvClass.UpdUser] = oRow[conWebSrvClass.UpdUser].ToString().Trim(); //修改者
objRow[conWebSrvClass.Memo] = oRow[conWebSrvClass.Memo].ToString().Trim(); //说明
objRow[conWebSrvClass.CodeTypeId] = oRow[conWebSrvClass.CodeTypeId].ToString().Trim(); //代码类型Id
objRow[conWebSrvClass.ClsName] = oRow[conWebSrvClass.ClsName].ToString().Trim(); //类名
 objDS.Tables[clsWebSrvClassEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsWebSrvClassEN._CurrTabName);
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
 /// <param name = "objWebSrvClassEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsWebSrvClassEN objWebSrvClassEN)
{
 objWebSrvClassEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objWebSrvClassEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objWebSrvClassEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvClassDA.GetSpecSQLObj();
strSQL = "Select * from WebSrvClass where WebSrvClassId = " + "'"+ objWebSrvClassEN.WebSrvClassId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsWebSrvClassEN._CurrTabName);
if (objDS.Tables[clsWebSrvClassEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:WebSrvClassId = " + "'"+ objWebSrvClassEN.WebSrvClassId+"'");
return false;
}
objRow = objDS.Tables[clsWebSrvClassEN._CurrTabName].Rows[0];
 if (objWebSrvClassEN.IsUpdated(conWebSrvClass.WebSrvClassId))
 {
objRow[conWebSrvClass.WebSrvClassId] = objWebSrvClassEN.WebSrvClassId; //类Id
 }
 if (objWebSrvClassEN.IsUpdated(conWebSrvClass.NameSpace))
 {
objRow[conWebSrvClass.NameSpace] = objWebSrvClassEN.NameSpace; //域名
 }
 if (objWebSrvClassEN.IsUpdated(conWebSrvClass.WebSrvUrl))
 {
objRow[conWebSrvClass.WebSrvUrl] = objWebSrvClassEN.WebSrvUrl; //WebSrv地址
 }
 if (objWebSrvClassEN.IsUpdated(conWebSrvClass.PageName))
 {
objRow[conWebSrvClass.PageName] = objWebSrvClassEN.PageName; //页面名称
 }
 if (objWebSrvClassEN.IsUpdated(conWebSrvClass.FuncModuleAgcId))
 {
objRow[conWebSrvClass.FuncModuleAgcId] = objWebSrvClassEN.FuncModuleAgcId; //功能模块Id
 }
 if (objWebSrvClassEN.IsUpdated(conWebSrvClass.IsNeedGene))
 {
objRow[conWebSrvClass.IsNeedGene] = objWebSrvClassEN.IsNeedGene; //是否需要生成
 }
 if (objWebSrvClassEN.IsUpdated(conWebSrvClass.PrjId))
 {
objRow[conWebSrvClass.PrjId] = objWebSrvClassEN.PrjId; //工程Id
 }
 if (objWebSrvClassEN.IsUpdated(conWebSrvClass.UpdDate))
 {
objRow[conWebSrvClass.UpdDate] = objWebSrvClassEN.UpdDate; //修改日期
 }
 if (objWebSrvClassEN.IsUpdated(conWebSrvClass.UpdUser))
 {
objRow[conWebSrvClass.UpdUser] = objWebSrvClassEN.UpdUser; //修改者
 }
 if (objWebSrvClassEN.IsUpdated(conWebSrvClass.Memo))
 {
objRow[conWebSrvClass.Memo] = objWebSrvClassEN.Memo; //说明
 }
 if (objWebSrvClassEN.IsUpdated(conWebSrvClass.CodeTypeId))
 {
objRow[conWebSrvClass.CodeTypeId] = objWebSrvClassEN.CodeTypeId; //代码类型Id
 }
 if (objWebSrvClassEN.IsUpdated(conWebSrvClass.ClsName))
 {
objRow[conWebSrvClass.ClsName] = objWebSrvClassEN.ClsName; //类名
 }
try
{
objDA.Update(objDS, clsWebSrvClassEN._CurrTabName);
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
 /// <param name = "objWebSrvClassEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsWebSrvClassEN objWebSrvClassEN)
{
 objWebSrvClassEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objWebSrvClassEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objWebSrvClassEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvClassDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update WebSrvClass Set ");
 
 if (objWebSrvClassEN.IsUpdated(conWebSrvClass.NameSpace))
 {
 if (objWebSrvClassEN.NameSpace !=  null)
 {
 var strNameSpace = objWebSrvClassEN.NameSpace.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strNameSpace, conWebSrvClass.NameSpace); //域名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvClass.NameSpace); //域名
 }
 }
 
 if (objWebSrvClassEN.IsUpdated(conWebSrvClass.WebSrvUrl))
 {
 if (objWebSrvClassEN.WebSrvUrl !=  null)
 {
 var strWebSrvUrl = objWebSrvClassEN.WebSrvUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWebSrvUrl, conWebSrvClass.WebSrvUrl); //WebSrv地址
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvClass.WebSrvUrl); //WebSrv地址
 }
 }
 
 if (objWebSrvClassEN.IsUpdated(conWebSrvClass.PageName))
 {
 if (objWebSrvClassEN.PageName !=  null)
 {
 var strPageName = objWebSrvClassEN.PageName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPageName, conWebSrvClass.PageName); //页面名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvClass.PageName); //页面名称
 }
 }
 
 if (objWebSrvClassEN.IsUpdated(conWebSrvClass.FuncModuleAgcId))
 {
 if (objWebSrvClassEN.FuncModuleAgcId !=  null)
 {
 var strFuncModuleAgcId = objWebSrvClassEN.FuncModuleAgcId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleAgcId, conWebSrvClass.FuncModuleAgcId); //功能模块Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvClass.FuncModuleAgcId); //功能模块Id
 }
 }
 
 if (objWebSrvClassEN.IsUpdated(conWebSrvClass.IsNeedGene))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objWebSrvClassEN.IsNeedGene == true?"1":"0", conWebSrvClass.IsNeedGene); //是否需要生成
 }
 
 if (objWebSrvClassEN.IsUpdated(conWebSrvClass.PrjId))
 {
 if (objWebSrvClassEN.PrjId !=  null)
 {
 var strPrjId = objWebSrvClassEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conWebSrvClass.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvClass.PrjId); //工程Id
 }
 }
 
 if (objWebSrvClassEN.IsUpdated(conWebSrvClass.UpdDate))
 {
 if (objWebSrvClassEN.UpdDate !=  null)
 {
 var strUpdDate = objWebSrvClassEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conWebSrvClass.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvClass.UpdDate); //修改日期
 }
 }
 
 if (objWebSrvClassEN.IsUpdated(conWebSrvClass.UpdUser))
 {
 if (objWebSrvClassEN.UpdUser !=  null)
 {
 var strUpdUser = objWebSrvClassEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conWebSrvClass.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvClass.UpdUser); //修改者
 }
 }
 
 if (objWebSrvClassEN.IsUpdated(conWebSrvClass.Memo))
 {
 if (objWebSrvClassEN.Memo !=  null)
 {
 var strMemo = objWebSrvClassEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conWebSrvClass.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvClass.Memo); //说明
 }
 }
 
 if (objWebSrvClassEN.IsUpdated(conWebSrvClass.CodeTypeId))
 {
 if (objWebSrvClassEN.CodeTypeId !=  null)
 {
 var strCodeTypeId = objWebSrvClassEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCodeTypeId, conWebSrvClass.CodeTypeId); //代码类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvClass.CodeTypeId); //代码类型Id
 }
 }
 
 if (objWebSrvClassEN.IsUpdated(conWebSrvClass.ClsName))
 {
 if (objWebSrvClassEN.ClsName !=  null)
 {
 var strClsName = objWebSrvClassEN.ClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClsName, conWebSrvClass.ClsName); //类名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvClass.ClsName); //类名
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where WebSrvClassId = '{0}'", objWebSrvClassEN.WebSrvClassId); 
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
 /// <param name = "objWebSrvClassEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsWebSrvClassEN objWebSrvClassEN, string strCondition)
{
 objWebSrvClassEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objWebSrvClassEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objWebSrvClassEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvClassDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update WebSrvClass Set ");
 
 if (objWebSrvClassEN.IsUpdated(conWebSrvClass.NameSpace))
 {
 if (objWebSrvClassEN.NameSpace !=  null)
 {
 var strNameSpace = objWebSrvClassEN.NameSpace.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" NameSpace = '{0}',", strNameSpace); //域名
 }
 else
 {
 sbSQL.Append(" NameSpace = null,"); //域名
 }
 }
 
 if (objWebSrvClassEN.IsUpdated(conWebSrvClass.WebSrvUrl))
 {
 if (objWebSrvClassEN.WebSrvUrl !=  null)
 {
 var strWebSrvUrl = objWebSrvClassEN.WebSrvUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WebSrvUrl = '{0}',", strWebSrvUrl); //WebSrv地址
 }
 else
 {
 sbSQL.Append(" WebSrvUrl = null,"); //WebSrv地址
 }
 }
 
 if (objWebSrvClassEN.IsUpdated(conWebSrvClass.PageName))
 {
 if (objWebSrvClassEN.PageName !=  null)
 {
 var strPageName = objWebSrvClassEN.PageName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PageName = '{0}',", strPageName); //页面名称
 }
 else
 {
 sbSQL.Append(" PageName = null,"); //页面名称
 }
 }
 
 if (objWebSrvClassEN.IsUpdated(conWebSrvClass.FuncModuleAgcId))
 {
 if (objWebSrvClassEN.FuncModuleAgcId !=  null)
 {
 var strFuncModuleAgcId = objWebSrvClassEN.FuncModuleAgcId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleAgcId = '{0}',", strFuncModuleAgcId); //功能模块Id
 }
 else
 {
 sbSQL.Append(" FuncModuleAgcId = null,"); //功能模块Id
 }
 }
 
 if (objWebSrvClassEN.IsUpdated(conWebSrvClass.IsNeedGene))
 {
 sbSQL.AppendFormat(" IsNeedGene = '{0}',", objWebSrvClassEN.IsNeedGene == true?"1":"0"); //是否需要生成
 }
 
 if (objWebSrvClassEN.IsUpdated(conWebSrvClass.PrjId))
 {
 if (objWebSrvClassEN.PrjId !=  null)
 {
 var strPrjId = objWebSrvClassEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objWebSrvClassEN.IsUpdated(conWebSrvClass.UpdDate))
 {
 if (objWebSrvClassEN.UpdDate !=  null)
 {
 var strUpdDate = objWebSrvClassEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objWebSrvClassEN.IsUpdated(conWebSrvClass.UpdUser))
 {
 if (objWebSrvClassEN.UpdUser !=  null)
 {
 var strUpdUser = objWebSrvClassEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objWebSrvClassEN.IsUpdated(conWebSrvClass.Memo))
 {
 if (objWebSrvClassEN.Memo !=  null)
 {
 var strMemo = objWebSrvClassEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //说明
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //说明
 }
 }
 
 if (objWebSrvClassEN.IsUpdated(conWebSrvClass.CodeTypeId))
 {
 if (objWebSrvClassEN.CodeTypeId !=  null)
 {
 var strCodeTypeId = objWebSrvClassEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodeTypeId = '{0}',", strCodeTypeId); //代码类型Id
 }
 else
 {
 sbSQL.Append(" CodeTypeId = null,"); //代码类型Id
 }
 }
 
 if (objWebSrvClassEN.IsUpdated(conWebSrvClass.ClsName))
 {
 if (objWebSrvClassEN.ClsName !=  null)
 {
 var strClsName = objWebSrvClassEN.ClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClsName = '{0}',", strClsName); //类名
 }
 else
 {
 sbSQL.Append(" ClsName = null,"); //类名
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
 /// <param name = "objWebSrvClassEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsWebSrvClassEN objWebSrvClassEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objWebSrvClassEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objWebSrvClassEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objWebSrvClassEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvClassDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update WebSrvClass Set ");
 
 if (objWebSrvClassEN.IsUpdated(conWebSrvClass.NameSpace))
 {
 if (objWebSrvClassEN.NameSpace !=  null)
 {
 var strNameSpace = objWebSrvClassEN.NameSpace.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" NameSpace = '{0}',", strNameSpace); //域名
 }
 else
 {
 sbSQL.Append(" NameSpace = null,"); //域名
 }
 }
 
 if (objWebSrvClassEN.IsUpdated(conWebSrvClass.WebSrvUrl))
 {
 if (objWebSrvClassEN.WebSrvUrl !=  null)
 {
 var strWebSrvUrl = objWebSrvClassEN.WebSrvUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WebSrvUrl = '{0}',", strWebSrvUrl); //WebSrv地址
 }
 else
 {
 sbSQL.Append(" WebSrvUrl = null,"); //WebSrv地址
 }
 }
 
 if (objWebSrvClassEN.IsUpdated(conWebSrvClass.PageName))
 {
 if (objWebSrvClassEN.PageName !=  null)
 {
 var strPageName = objWebSrvClassEN.PageName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PageName = '{0}',", strPageName); //页面名称
 }
 else
 {
 sbSQL.Append(" PageName = null,"); //页面名称
 }
 }
 
 if (objWebSrvClassEN.IsUpdated(conWebSrvClass.FuncModuleAgcId))
 {
 if (objWebSrvClassEN.FuncModuleAgcId !=  null)
 {
 var strFuncModuleAgcId = objWebSrvClassEN.FuncModuleAgcId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleAgcId = '{0}',", strFuncModuleAgcId); //功能模块Id
 }
 else
 {
 sbSQL.Append(" FuncModuleAgcId = null,"); //功能模块Id
 }
 }
 
 if (objWebSrvClassEN.IsUpdated(conWebSrvClass.IsNeedGene))
 {
 sbSQL.AppendFormat(" IsNeedGene = '{0}',", objWebSrvClassEN.IsNeedGene == true?"1":"0"); //是否需要生成
 }
 
 if (objWebSrvClassEN.IsUpdated(conWebSrvClass.PrjId))
 {
 if (objWebSrvClassEN.PrjId !=  null)
 {
 var strPrjId = objWebSrvClassEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objWebSrvClassEN.IsUpdated(conWebSrvClass.UpdDate))
 {
 if (objWebSrvClassEN.UpdDate !=  null)
 {
 var strUpdDate = objWebSrvClassEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objWebSrvClassEN.IsUpdated(conWebSrvClass.UpdUser))
 {
 if (objWebSrvClassEN.UpdUser !=  null)
 {
 var strUpdUser = objWebSrvClassEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objWebSrvClassEN.IsUpdated(conWebSrvClass.Memo))
 {
 if (objWebSrvClassEN.Memo !=  null)
 {
 var strMemo = objWebSrvClassEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //说明
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //说明
 }
 }
 
 if (objWebSrvClassEN.IsUpdated(conWebSrvClass.CodeTypeId))
 {
 if (objWebSrvClassEN.CodeTypeId !=  null)
 {
 var strCodeTypeId = objWebSrvClassEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodeTypeId = '{0}',", strCodeTypeId); //代码类型Id
 }
 else
 {
 sbSQL.Append(" CodeTypeId = null,"); //代码类型Id
 }
 }
 
 if (objWebSrvClassEN.IsUpdated(conWebSrvClass.ClsName))
 {
 if (objWebSrvClassEN.ClsName !=  null)
 {
 var strClsName = objWebSrvClassEN.ClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClsName = '{0}',", strClsName); //类名
 }
 else
 {
 sbSQL.Append(" ClsName = null,"); //类名
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
 /// <param name = "objWebSrvClassEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsWebSrvClassEN objWebSrvClassEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objWebSrvClassEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objWebSrvClassEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objWebSrvClassEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvClassDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update WebSrvClass Set ");
 
 if (objWebSrvClassEN.IsUpdated(conWebSrvClass.NameSpace))
 {
 if (objWebSrvClassEN.NameSpace !=  null)
 {
 var strNameSpace = objWebSrvClassEN.NameSpace.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strNameSpace, conWebSrvClass.NameSpace); //域名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvClass.NameSpace); //域名
 }
 }
 
 if (objWebSrvClassEN.IsUpdated(conWebSrvClass.WebSrvUrl))
 {
 if (objWebSrvClassEN.WebSrvUrl !=  null)
 {
 var strWebSrvUrl = objWebSrvClassEN.WebSrvUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWebSrvUrl, conWebSrvClass.WebSrvUrl); //WebSrv地址
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvClass.WebSrvUrl); //WebSrv地址
 }
 }
 
 if (objWebSrvClassEN.IsUpdated(conWebSrvClass.PageName))
 {
 if (objWebSrvClassEN.PageName !=  null)
 {
 var strPageName = objWebSrvClassEN.PageName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPageName, conWebSrvClass.PageName); //页面名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvClass.PageName); //页面名称
 }
 }
 
 if (objWebSrvClassEN.IsUpdated(conWebSrvClass.FuncModuleAgcId))
 {
 if (objWebSrvClassEN.FuncModuleAgcId !=  null)
 {
 var strFuncModuleAgcId = objWebSrvClassEN.FuncModuleAgcId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleAgcId, conWebSrvClass.FuncModuleAgcId); //功能模块Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvClass.FuncModuleAgcId); //功能模块Id
 }
 }
 
 if (objWebSrvClassEN.IsUpdated(conWebSrvClass.IsNeedGene))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objWebSrvClassEN.IsNeedGene == true?"1":"0", conWebSrvClass.IsNeedGene); //是否需要生成
 }
 
 if (objWebSrvClassEN.IsUpdated(conWebSrvClass.PrjId))
 {
 if (objWebSrvClassEN.PrjId !=  null)
 {
 var strPrjId = objWebSrvClassEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conWebSrvClass.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvClass.PrjId); //工程Id
 }
 }
 
 if (objWebSrvClassEN.IsUpdated(conWebSrvClass.UpdDate))
 {
 if (objWebSrvClassEN.UpdDate !=  null)
 {
 var strUpdDate = objWebSrvClassEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conWebSrvClass.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvClass.UpdDate); //修改日期
 }
 }
 
 if (objWebSrvClassEN.IsUpdated(conWebSrvClass.UpdUser))
 {
 if (objWebSrvClassEN.UpdUser !=  null)
 {
 var strUpdUser = objWebSrvClassEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conWebSrvClass.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvClass.UpdUser); //修改者
 }
 }
 
 if (objWebSrvClassEN.IsUpdated(conWebSrvClass.Memo))
 {
 if (objWebSrvClassEN.Memo !=  null)
 {
 var strMemo = objWebSrvClassEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conWebSrvClass.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvClass.Memo); //说明
 }
 }
 
 if (objWebSrvClassEN.IsUpdated(conWebSrvClass.CodeTypeId))
 {
 if (objWebSrvClassEN.CodeTypeId !=  null)
 {
 var strCodeTypeId = objWebSrvClassEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCodeTypeId, conWebSrvClass.CodeTypeId); //代码类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvClass.CodeTypeId); //代码类型Id
 }
 }
 
 if (objWebSrvClassEN.IsUpdated(conWebSrvClass.ClsName))
 {
 if (objWebSrvClassEN.ClsName !=  null)
 {
 var strClsName = objWebSrvClassEN.ClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClsName, conWebSrvClass.ClsName); //类名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvClass.ClsName); //类名
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where WebSrvClassId = '{0}'", objWebSrvClassEN.WebSrvClassId); 
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
 /// <param name = "strWebSrvClassId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strWebSrvClassId) 
{
CheckPrimaryKey(strWebSrvClassId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvClassDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strWebSrvClassId,
};
 objSQL.ExecSP("WebSrvClass_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strWebSrvClassId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strWebSrvClassId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strWebSrvClassId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvClassDA.GetSpecSQLObj();
//删除WebSrvClass本表中与当前对象有关的记录
strSQL = strSQL + "Delete from WebSrvClass where WebSrvClassId = " + "'"+ strWebSrvClassId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelWebSrvClass(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvClassDA.GetSpecSQLObj();
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
//删除WebSrvClass本表中与当前对象有关的记录
strSQL = strSQL + "Delete from WebSrvClass where WebSrvClassId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strWebSrvClassId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strWebSrvClassId) 
{
CheckPrimaryKey(strWebSrvClassId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvClassDA.GetSpecSQLObj();
//删除WebSrvClass本表中与当前对象有关的记录
strSQL = strSQL + "Delete from WebSrvClass where WebSrvClassId = " + "'"+ strWebSrvClassId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelWebSrvClass(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsWebSrvClassDA: DelWebSrvClass)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvClassDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from WebSrvClass where " + strCondition ;
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
public bool DelWebSrvClassWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsWebSrvClassDA: DelWebSrvClassWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvClassDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from WebSrvClass where " + strCondition ;
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
 /// <param name = "objWebSrvClassENS">源对象</param>
 /// <param name = "objWebSrvClassENT">目标对象</param>
public void CopyTo(clsWebSrvClassEN objWebSrvClassENS, clsWebSrvClassEN objWebSrvClassENT)
{
objWebSrvClassENT.WebSrvClassId = objWebSrvClassENS.WebSrvClassId; //类Id
objWebSrvClassENT.NameSpace = objWebSrvClassENS.NameSpace; //域名
objWebSrvClassENT.WebSrvUrl = objWebSrvClassENS.WebSrvUrl; //WebSrv地址
objWebSrvClassENT.PageName = objWebSrvClassENS.PageName; //页面名称
objWebSrvClassENT.FuncModuleAgcId = objWebSrvClassENS.FuncModuleAgcId; //功能模块Id
objWebSrvClassENT.IsNeedGene = objWebSrvClassENS.IsNeedGene; //是否需要生成
objWebSrvClassENT.PrjId = objWebSrvClassENS.PrjId; //工程Id
objWebSrvClassENT.UpdDate = objWebSrvClassENS.UpdDate; //修改日期
objWebSrvClassENT.UpdUser = objWebSrvClassENS.UpdUser; //修改者
objWebSrvClassENT.Memo = objWebSrvClassENS.Memo; //说明
objWebSrvClassENT.CodeTypeId = objWebSrvClassENS.CodeTypeId; //代码类型Id
objWebSrvClassENT.ClsName = objWebSrvClassENS.ClsName; //类名
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsWebSrvClassEN objWebSrvClassEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objWebSrvClassEN.WebSrvUrl, conWebSrvClass.WebSrvUrl);
clsCheckSql.CheckFieldNotNull(objWebSrvClassEN.PageName, conWebSrvClass.PageName);
clsCheckSql.CheckFieldNotNull(objWebSrvClassEN.PrjId, conWebSrvClass.PrjId);
clsCheckSql.CheckFieldNotNull(objWebSrvClassEN.CodeTypeId, conWebSrvClass.CodeTypeId);
clsCheckSql.CheckFieldNotNull(objWebSrvClassEN.ClsName, conWebSrvClass.ClsName);
//检查字段长度
clsCheckSql.CheckFieldLen(objWebSrvClassEN.WebSrvClassId, 8, conWebSrvClass.WebSrvClassId);
clsCheckSql.CheckFieldLen(objWebSrvClassEN.NameSpace, 50, conWebSrvClass.NameSpace);
clsCheckSql.CheckFieldLen(objWebSrvClassEN.WebSrvUrl, 300, conWebSrvClass.WebSrvUrl);
clsCheckSql.CheckFieldLen(objWebSrvClassEN.PageName, 100, conWebSrvClass.PageName);
clsCheckSql.CheckFieldLen(objWebSrvClassEN.FuncModuleAgcId, 8, conWebSrvClass.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(objWebSrvClassEN.PrjId, 4, conWebSrvClass.PrjId);
clsCheckSql.CheckFieldLen(objWebSrvClassEN.UpdDate, 20, conWebSrvClass.UpdDate);
clsCheckSql.CheckFieldLen(objWebSrvClassEN.UpdUser, 20, conWebSrvClass.UpdUser);
clsCheckSql.CheckFieldLen(objWebSrvClassEN.Memo, 1000, conWebSrvClass.Memo);
clsCheckSql.CheckFieldLen(objWebSrvClassEN.CodeTypeId, 4, conWebSrvClass.CodeTypeId);
clsCheckSql.CheckFieldLen(objWebSrvClassEN.ClsName, 100, conWebSrvClass.ClsName);
//检查字段外键固定长度
 objWebSrvClassEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsWebSrvClassEN objWebSrvClassEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objWebSrvClassEN.NameSpace, 50, conWebSrvClass.NameSpace);
clsCheckSql.CheckFieldLen(objWebSrvClassEN.WebSrvUrl, 300, conWebSrvClass.WebSrvUrl);
clsCheckSql.CheckFieldLen(objWebSrvClassEN.PageName, 100, conWebSrvClass.PageName);
clsCheckSql.CheckFieldLen(objWebSrvClassEN.FuncModuleAgcId, 8, conWebSrvClass.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(objWebSrvClassEN.PrjId, 4, conWebSrvClass.PrjId);
clsCheckSql.CheckFieldLen(objWebSrvClassEN.UpdDate, 20, conWebSrvClass.UpdDate);
clsCheckSql.CheckFieldLen(objWebSrvClassEN.UpdUser, 20, conWebSrvClass.UpdUser);
clsCheckSql.CheckFieldLen(objWebSrvClassEN.Memo, 1000, conWebSrvClass.Memo);
clsCheckSql.CheckFieldLen(objWebSrvClassEN.CodeTypeId, 4, conWebSrvClass.CodeTypeId);
clsCheckSql.CheckFieldLen(objWebSrvClassEN.ClsName, 100, conWebSrvClass.ClsName);
//检查外键字段长度
 objWebSrvClassEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsWebSrvClassEN objWebSrvClassEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objWebSrvClassEN.WebSrvClassId, 8, conWebSrvClass.WebSrvClassId);
clsCheckSql.CheckFieldLen(objWebSrvClassEN.NameSpace, 50, conWebSrvClass.NameSpace);
clsCheckSql.CheckFieldLen(objWebSrvClassEN.WebSrvUrl, 300, conWebSrvClass.WebSrvUrl);
clsCheckSql.CheckFieldLen(objWebSrvClassEN.PageName, 100, conWebSrvClass.PageName);
clsCheckSql.CheckFieldLen(objWebSrvClassEN.FuncModuleAgcId, 8, conWebSrvClass.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(objWebSrvClassEN.PrjId, 4, conWebSrvClass.PrjId);
clsCheckSql.CheckFieldLen(objWebSrvClassEN.UpdDate, 20, conWebSrvClass.UpdDate);
clsCheckSql.CheckFieldLen(objWebSrvClassEN.UpdUser, 20, conWebSrvClass.UpdUser);
clsCheckSql.CheckFieldLen(objWebSrvClassEN.Memo, 1000, conWebSrvClass.Memo);
clsCheckSql.CheckFieldLen(objWebSrvClassEN.CodeTypeId, 4, conWebSrvClass.CodeTypeId);
clsCheckSql.CheckFieldLen(objWebSrvClassEN.ClsName, 100, conWebSrvClass.ClsName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objWebSrvClassEN.WebSrvClassId, conWebSrvClass.WebSrvClassId);
clsCheckSql.CheckSqlInjection4Field(objWebSrvClassEN.NameSpace, conWebSrvClass.NameSpace);
clsCheckSql.CheckSqlInjection4Field(objWebSrvClassEN.WebSrvUrl, conWebSrvClass.WebSrvUrl);
clsCheckSql.CheckSqlInjection4Field(objWebSrvClassEN.PageName, conWebSrvClass.PageName);
clsCheckSql.CheckSqlInjection4Field(objWebSrvClassEN.FuncModuleAgcId, conWebSrvClass.FuncModuleAgcId);
clsCheckSql.CheckSqlInjection4Field(objWebSrvClassEN.PrjId, conWebSrvClass.PrjId);
clsCheckSql.CheckSqlInjection4Field(objWebSrvClassEN.UpdDate, conWebSrvClass.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objWebSrvClassEN.UpdUser, conWebSrvClass.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objWebSrvClassEN.Memo, conWebSrvClass.Memo);
clsCheckSql.CheckSqlInjection4Field(objWebSrvClassEN.CodeTypeId, conWebSrvClass.CodeTypeId);
clsCheckSql.CheckSqlInjection4Field(objWebSrvClassEN.ClsName, conWebSrvClass.ClsName);
//检查外键字段长度
 objWebSrvClassEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--WebSrvClass(WebSrv类),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objWebSrvClassEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsWebSrvClassEN objWebSrvClassEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ClsName = '{0}'", objWebSrvClassEN.ClsName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objWebSrvClassEN.PrjId);
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
 objSQL = clsWebSrvClassDA.GetSpecSQLObj();
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
 objSQL = clsWebSrvClassDA.GetSpecSQLObj();
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
 objSQL = clsWebSrvClassDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsWebSrvClassEN._CurrTabName);
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
 objSQL = clsWebSrvClassDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsWebSrvClassEN._CurrTabName, strCondition);
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
 objSQL = clsWebSrvClassDA.GetSpecSQLObj();
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
 objSQL = clsWebSrvClassDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}