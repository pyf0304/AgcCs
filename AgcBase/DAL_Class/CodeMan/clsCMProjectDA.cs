
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCMProjectDA
 表名:CMProject(00050512)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:31:44
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
 /// CM项目(CMProject)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsCMProjectDA : clsCommBase4DA
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
 return clsCMProjectEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsCMProjectEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCMProjectEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsCMProjectEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsCMProjectEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strCmPrjId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strCmPrjId)
{
strCmPrjId = strCmPrjId.Replace("'", "''");
if (strCmPrjId.Length > 6)
{
throw new Exception("(errid:Data000001)在表:CMProject中,检查关键字,长度不正确!(clsCMProjectDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strCmPrjId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:CMProject中,关键字不能为空 或 null!(clsCMProjectDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCmPrjId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsCMProjectDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsCMProjectDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectDA.GetSpecSQLObj();
strSQL = "Select * from CMProject where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_CMProject(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsCMProjectDA: GetDataTable_CMProject)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectDA.GetSpecSQLObj();
strSQL = "Select * from CMProject where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsCMProjectDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsCMProjectDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectDA.GetSpecSQLObj();
strSQL = "Select * from CMProject where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsCMProjectDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsCMProjectDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CMProject where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CMProject where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsCMProjectDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from CMProject where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsCMProjectDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} CMProject.* " + 
$"from CMProject " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and CMProject.CmPrjId not in " + 
$"(Select top {intTop_In} CMProject.CmPrjId from CMProject " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CMProject where {1} and CmPrjId not in (Select top {2} CmPrjId from CMProject where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CMProject where {1} and CmPrjId not in (Select top {3} CmPrjId from CMProject where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsCMProjectDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} CMProject.* " + 
$"from CMProject " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and CMProject.CmPrjId not in " + 
$"(Select top {intTop_In} CMProject.CmPrjId from CMProject " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CMProject where {1} and CmPrjId not in (Select top {2} CmPrjId from CMProject where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CMProject where {1} and CmPrjId not in (Select top {3} CmPrjId from CMProject where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsCMProjectEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsCMProjectDA:GetObjLst)", objException.Message));
}
List<clsCMProjectEN> arrObjLst = new List<clsCMProjectEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectDA.GetSpecSQLObj();
strSQL = "Select * from CMProject where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMProjectEN objCMProjectEN = new clsCMProjectEN();
try
{
objCMProjectEN.CmPrjId = objRow[conCMProject.CmPrjId].ToString().Trim(); //Cm工程Id
objCMProjectEN.CmPrjName = objRow[conCMProject.CmPrjName].ToString().Trim(); //CM工程名
objCMProjectEN.PrjId = objRow[conCMProject.PrjId].ToString().Trim(); //工程Id
objCMProjectEN.ApplicationTypeId = TransNullToInt(objRow[conCMProject.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objCMProjectEN.FunctionTemplateId = objRow[conCMProject.FunctionTemplateId] == DBNull.Value ? null : objRow[conCMProject.FunctionTemplateId].ToString().Trim(); //函数模板Id
objCMProjectEN.VueDesignSysId = objRow[conCMProject.VueDesignSysId] == DBNull.Value ? null : objRow[conCMProject.VueDesignSysId].ToString().Trim(); //Vue控件设计体系Id
objCMProjectEN.IsFstLcase = TransNullToBool(objRow[conCMProject.IsFstLcase].ToString().Trim()); //是否首字母小写
objCMProjectEN.IsCamelCase = TransNullToBool(objRow[conCMProject.IsCamelCase].ToString().Trim()); //是否使用CamelCase
objCMProjectEN.ProjectFileName = objRow[conCMProject.ProjectFileName] == DBNull.Value ? null : objRow[conCMProject.ProjectFileName].ToString().Trim(); //工程文件名
objCMProjectEN.UseStateId = objRow[conCMProject.UseStateId] == DBNull.Value ? null : objRow[conCMProject.UseStateId].ToString().Trim(); //使用状态Id
objCMProjectEN.IsRefresh4RelaView = TransNullToBool(objRow[conCMProject.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图
objCMProjectEN.UpdDate = objRow[conCMProject.UpdDate] == DBNull.Value ? null : objRow[conCMProject.UpdDate].ToString().Trim(); //修改日期
objCMProjectEN.UpdUserId = objRow[conCMProject.UpdUserId] == DBNull.Value ? null : objRow[conCMProject.UpdUserId].ToString().Trim(); //修改用户Id
objCMProjectEN.Memo = objRow[conCMProject.Memo] == DBNull.Value ? null : objRow[conCMProject.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCMProjectDA: GetObjLst)", objException.Message));
}
objCMProjectEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCMProjectEN);
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
public List<clsCMProjectEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsCMProjectDA:GetObjLstByTabName)", objException.Message));
}
List<clsCMProjectEN> arrObjLst = new List<clsCMProjectEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMProjectEN objCMProjectEN = new clsCMProjectEN();
try
{
objCMProjectEN.CmPrjId = objRow[conCMProject.CmPrjId].ToString().Trim(); //Cm工程Id
objCMProjectEN.CmPrjName = objRow[conCMProject.CmPrjName].ToString().Trim(); //CM工程名
objCMProjectEN.PrjId = objRow[conCMProject.PrjId].ToString().Trim(); //工程Id
objCMProjectEN.ApplicationTypeId = TransNullToInt(objRow[conCMProject.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objCMProjectEN.FunctionTemplateId = objRow[conCMProject.FunctionTemplateId] == DBNull.Value ? null : objRow[conCMProject.FunctionTemplateId].ToString().Trim(); //函数模板Id
objCMProjectEN.VueDesignSysId = objRow[conCMProject.VueDesignSysId] == DBNull.Value ? null : objRow[conCMProject.VueDesignSysId].ToString().Trim(); //Vue控件设计体系Id
objCMProjectEN.IsFstLcase = TransNullToBool(objRow[conCMProject.IsFstLcase].ToString().Trim()); //是否首字母小写
objCMProjectEN.IsCamelCase = TransNullToBool(objRow[conCMProject.IsCamelCase].ToString().Trim()); //是否使用CamelCase
objCMProjectEN.ProjectFileName = objRow[conCMProject.ProjectFileName] == DBNull.Value ? null : objRow[conCMProject.ProjectFileName].ToString().Trim(); //工程文件名
objCMProjectEN.UseStateId = objRow[conCMProject.UseStateId] == DBNull.Value ? null : objRow[conCMProject.UseStateId].ToString().Trim(); //使用状态Id
objCMProjectEN.IsRefresh4RelaView = TransNullToBool(objRow[conCMProject.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图
objCMProjectEN.UpdDate = objRow[conCMProject.UpdDate] == DBNull.Value ? null : objRow[conCMProject.UpdDate].ToString().Trim(); //修改日期
objCMProjectEN.UpdUserId = objRow[conCMProject.UpdUserId] == DBNull.Value ? null : objRow[conCMProject.UpdUserId].ToString().Trim(); //修改用户Id
objCMProjectEN.Memo = objRow[conCMProject.Memo] == DBNull.Value ? null : objRow[conCMProject.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCMProjectDA: GetObjLst)", objException.Message));
}
objCMProjectEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCMProjectEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objCMProjectEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetCMProject(ref clsCMProjectEN objCMProjectEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectDA.GetSpecSQLObj();
strSQL = "Select * from CMProject where CmPrjId = " + "'"+ objCMProjectEN.CmPrjId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objCMProjectEN.CmPrjId = objDT.Rows[0][conCMProject.CmPrjId].ToString().Trim(); //Cm工程Id(字段类型:char,字段长度:6,是否可空:False)
 objCMProjectEN.CmPrjName = objDT.Rows[0][conCMProject.CmPrjName].ToString().Trim(); //CM工程名(字段类型:varchar,字段长度:50,是否可空:True)
 objCMProjectEN.PrjId = objDT.Rows[0][conCMProject.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objCMProjectEN.ApplicationTypeId = TransNullToInt(objDT.Rows[0][conCMProject.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objCMProjectEN.FunctionTemplateId = objDT.Rows[0][conCMProject.FunctionTemplateId].ToString().Trim(); //函数模板Id(字段类型:char,字段长度:4,是否可空:False)
 objCMProjectEN.VueDesignSysId = objDT.Rows[0][conCMProject.VueDesignSysId].ToString().Trim(); //Vue控件设计体系Id(字段类型:char,字段长度:2,是否可空:False)
 objCMProjectEN.IsFstLcase = TransNullToBool(objDT.Rows[0][conCMProject.IsFstLcase].ToString().Trim()); //是否首字母小写(字段类型:bit,字段长度:1,是否可空:True)
 objCMProjectEN.IsCamelCase = TransNullToBool(objDT.Rows[0][conCMProject.IsCamelCase].ToString().Trim()); //是否使用CamelCase(字段类型:bit,字段长度:1,是否可空:True)
 objCMProjectEN.ProjectFileName = objDT.Rows[0][conCMProject.ProjectFileName].ToString().Trim(); //工程文件名(字段类型:varchar,字段长度:200,是否可空:False)
 objCMProjectEN.UseStateId = objDT.Rows[0][conCMProject.UseStateId].ToString().Trim(); //使用状态Id(字段类型:char,字段长度:4,是否可空:False)
 objCMProjectEN.IsRefresh4RelaView = TransNullToBool(objDT.Rows[0][conCMProject.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图(字段类型:bit,字段长度:1,是否可空:True)
 objCMProjectEN.UpdDate = objDT.Rows[0][conCMProject.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCMProjectEN.UpdUserId = objDT.Rows[0][conCMProject.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objCMProjectEN.Memo = objDT.Rows[0][conCMProject.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsCMProjectDA: GetCMProject)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCmPrjId">表关键字</param>
 /// <returns>表对象</returns>
public clsCMProjectEN GetObjByCmPrjId(string strCmPrjId)
{
CheckPrimaryKey(strCmPrjId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectDA.GetSpecSQLObj();
strSQL = "Select * from CMProject where CmPrjId = " + "'"+ strCmPrjId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsCMProjectEN objCMProjectEN = new clsCMProjectEN();
try
{
 objCMProjectEN.CmPrjId = objRow[conCMProject.CmPrjId].ToString().Trim(); //Cm工程Id(字段类型:char,字段长度:6,是否可空:False)
 objCMProjectEN.CmPrjName = objRow[conCMProject.CmPrjName].ToString().Trim(); //CM工程名(字段类型:varchar,字段长度:50,是否可空:True)
 objCMProjectEN.PrjId = objRow[conCMProject.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objCMProjectEN.ApplicationTypeId = Int32.Parse(objRow[conCMProject.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objCMProjectEN.FunctionTemplateId = objRow[conCMProject.FunctionTemplateId] == DBNull.Value ? null : objRow[conCMProject.FunctionTemplateId].ToString().Trim(); //函数模板Id(字段类型:char,字段长度:4,是否可空:False)
 objCMProjectEN.VueDesignSysId = objRow[conCMProject.VueDesignSysId] == DBNull.Value ? null : objRow[conCMProject.VueDesignSysId].ToString().Trim(); //Vue控件设计体系Id(字段类型:char,字段长度:2,是否可空:False)
 objCMProjectEN.IsFstLcase = clsEntityBase2.TransNullToBool_S(objRow[conCMProject.IsFstLcase].ToString().Trim()); //是否首字母小写(字段类型:bit,字段长度:1,是否可空:True)
 objCMProjectEN.IsCamelCase = clsEntityBase2.TransNullToBool_S(objRow[conCMProject.IsCamelCase].ToString().Trim()); //是否使用CamelCase(字段类型:bit,字段长度:1,是否可空:True)
 objCMProjectEN.ProjectFileName = objRow[conCMProject.ProjectFileName] == DBNull.Value ? null : objRow[conCMProject.ProjectFileName].ToString().Trim(); //工程文件名(字段类型:varchar,字段长度:200,是否可空:False)
 objCMProjectEN.UseStateId = objRow[conCMProject.UseStateId] == DBNull.Value ? null : objRow[conCMProject.UseStateId].ToString().Trim(); //使用状态Id(字段类型:char,字段长度:4,是否可空:False)
 objCMProjectEN.IsRefresh4RelaView = clsEntityBase2.TransNullToBool_S(objRow[conCMProject.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图(字段类型:bit,字段长度:1,是否可空:True)
 objCMProjectEN.UpdDate = objRow[conCMProject.UpdDate] == DBNull.Value ? null : objRow[conCMProject.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCMProjectEN.UpdUserId = objRow[conCMProject.UpdUserId] == DBNull.Value ? null : objRow[conCMProject.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objCMProjectEN.Memo = objRow[conCMProject.Memo] == DBNull.Value ? null : objRow[conCMProject.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsCMProjectDA: GetObjByCmPrjId)", objException.Message));
}
return objCMProjectEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsCMProjectEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsCMProjectDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectDA.GetSpecSQLObj();
strSQL = "Select * from CMProject where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsCMProjectEN objCMProjectEN = new clsCMProjectEN()
{
CmPrjId = objRow[conCMProject.CmPrjId].ToString().Trim(), //Cm工程Id
CmPrjName = objRow[conCMProject.CmPrjName].ToString().Trim(), //CM工程名
PrjId = objRow[conCMProject.PrjId].ToString().Trim(), //工程Id
ApplicationTypeId = TransNullToInt(objRow[conCMProject.ApplicationTypeId].ToString().Trim()), //应用程序类型ID
FunctionTemplateId = objRow[conCMProject.FunctionTemplateId] == DBNull.Value ? null : objRow[conCMProject.FunctionTemplateId].ToString().Trim(), //函数模板Id
VueDesignSysId = objRow[conCMProject.VueDesignSysId] == DBNull.Value ? null : objRow[conCMProject.VueDesignSysId].ToString().Trim(), //Vue控件设计体系Id
IsFstLcase = TransNullToBool(objRow[conCMProject.IsFstLcase].ToString().Trim()), //是否首字母小写
IsCamelCase = TransNullToBool(objRow[conCMProject.IsCamelCase].ToString().Trim()), //是否使用CamelCase
ProjectFileName = objRow[conCMProject.ProjectFileName] == DBNull.Value ? null : objRow[conCMProject.ProjectFileName].ToString().Trim(), //工程文件名
UseStateId = objRow[conCMProject.UseStateId] == DBNull.Value ? null : objRow[conCMProject.UseStateId].ToString().Trim(), //使用状态Id
IsRefresh4RelaView = TransNullToBool(objRow[conCMProject.IsRefresh4RelaView].ToString().Trim()), //是否刷新相关视图
UpdDate = objRow[conCMProject.UpdDate] == DBNull.Value ? null : objRow[conCMProject.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conCMProject.UpdUserId] == DBNull.Value ? null : objRow[conCMProject.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conCMProject.Memo] == DBNull.Value ? null : objRow[conCMProject.Memo].ToString().Trim() //说明
};
objCMProjectEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCMProjectEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsCMProjectDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsCMProjectEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCMProjectEN objCMProjectEN = new clsCMProjectEN();
try
{
objCMProjectEN.CmPrjId = objRow[conCMProject.CmPrjId].ToString().Trim(); //Cm工程Id
objCMProjectEN.CmPrjName = objRow[conCMProject.CmPrjName].ToString().Trim(); //CM工程名
objCMProjectEN.PrjId = objRow[conCMProject.PrjId].ToString().Trim(); //工程Id
objCMProjectEN.ApplicationTypeId = TransNullToInt(objRow[conCMProject.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objCMProjectEN.FunctionTemplateId = objRow[conCMProject.FunctionTemplateId] == DBNull.Value ? null : objRow[conCMProject.FunctionTemplateId].ToString().Trim(); //函数模板Id
objCMProjectEN.VueDesignSysId = objRow[conCMProject.VueDesignSysId] == DBNull.Value ? null : objRow[conCMProject.VueDesignSysId].ToString().Trim(); //Vue控件设计体系Id
objCMProjectEN.IsFstLcase = TransNullToBool(objRow[conCMProject.IsFstLcase].ToString().Trim()); //是否首字母小写
objCMProjectEN.IsCamelCase = TransNullToBool(objRow[conCMProject.IsCamelCase].ToString().Trim()); //是否使用CamelCase
objCMProjectEN.ProjectFileName = objRow[conCMProject.ProjectFileName] == DBNull.Value ? null : objRow[conCMProject.ProjectFileName].ToString().Trim(); //工程文件名
objCMProjectEN.UseStateId = objRow[conCMProject.UseStateId] == DBNull.Value ? null : objRow[conCMProject.UseStateId].ToString().Trim(); //使用状态Id
objCMProjectEN.IsRefresh4RelaView = TransNullToBool(objRow[conCMProject.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图
objCMProjectEN.UpdDate = objRow[conCMProject.UpdDate] == DBNull.Value ? null : objRow[conCMProject.UpdDate].ToString().Trim(); //修改日期
objCMProjectEN.UpdUserId = objRow[conCMProject.UpdUserId] == DBNull.Value ? null : objRow[conCMProject.UpdUserId].ToString().Trim(); //修改用户Id
objCMProjectEN.Memo = objRow[conCMProject.Memo] == DBNull.Value ? null : objRow[conCMProject.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsCMProjectDA: GetObjByDataRowCMProject)", objException.Message));
}
objCMProjectEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCMProjectEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsCMProjectEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCMProjectEN objCMProjectEN = new clsCMProjectEN();
try
{
objCMProjectEN.CmPrjId = objRow[conCMProject.CmPrjId].ToString().Trim(); //Cm工程Id
objCMProjectEN.CmPrjName = objRow[conCMProject.CmPrjName].ToString().Trim(); //CM工程名
objCMProjectEN.PrjId = objRow[conCMProject.PrjId].ToString().Trim(); //工程Id
objCMProjectEN.ApplicationTypeId = TransNullToInt(objRow[conCMProject.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objCMProjectEN.FunctionTemplateId = objRow[conCMProject.FunctionTemplateId] == DBNull.Value ? null : objRow[conCMProject.FunctionTemplateId].ToString().Trim(); //函数模板Id
objCMProjectEN.VueDesignSysId = objRow[conCMProject.VueDesignSysId] == DBNull.Value ? null : objRow[conCMProject.VueDesignSysId].ToString().Trim(); //Vue控件设计体系Id
objCMProjectEN.IsFstLcase = TransNullToBool(objRow[conCMProject.IsFstLcase].ToString().Trim()); //是否首字母小写
objCMProjectEN.IsCamelCase = TransNullToBool(objRow[conCMProject.IsCamelCase].ToString().Trim()); //是否使用CamelCase
objCMProjectEN.ProjectFileName = objRow[conCMProject.ProjectFileName] == DBNull.Value ? null : objRow[conCMProject.ProjectFileName].ToString().Trim(); //工程文件名
objCMProjectEN.UseStateId = objRow[conCMProject.UseStateId] == DBNull.Value ? null : objRow[conCMProject.UseStateId].ToString().Trim(); //使用状态Id
objCMProjectEN.IsRefresh4RelaView = TransNullToBool(objRow[conCMProject.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图
objCMProjectEN.UpdDate = objRow[conCMProject.UpdDate] == DBNull.Value ? null : objRow[conCMProject.UpdDate].ToString().Trim(); //修改日期
objCMProjectEN.UpdUserId = objRow[conCMProject.UpdUserId] == DBNull.Value ? null : objRow[conCMProject.UpdUserId].ToString().Trim(); //修改用户Id
objCMProjectEN.Memo = objRow[conCMProject.Memo] == DBNull.Value ? null : objRow[conCMProject.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsCMProjectDA: GetObjByDataRow)", objException.Message));
}
objCMProjectEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCMProjectEN;
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
objSQL = clsCMProjectDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCMProjectEN._CurrTabName, conCMProject.CmPrjId, 6, "");
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
objSQL = clsCMProjectDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCMProjectEN._CurrTabName, conCMProject.CmPrjId, 6, strPrefix);
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
 objSQL = clsCMProjectDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select CmPrjId from CMProject where " + strCondition;
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
 objSQL = clsCMProjectDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select CmPrjId from CMProject where " + strCondition;
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
 /// <param name = "strCmPrjId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strCmPrjId)
{
CheckPrimaryKey(strCmPrjId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CMProject", "CmPrjId = " + "'"+ strCmPrjId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsCMProjectDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CMProject", strCondition))
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
objSQL = clsCMProjectDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("CMProject");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsCMProjectEN objCMProjectEN)
 {
 objCMProjectEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMProjectEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCMProjectEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectDA.GetSpecSQLObj();
strSQL = "Select * from CMProject where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CMProject");
objRow = objDS.Tables["CMProject"].NewRow();
objRow[conCMProject.CmPrjId] = objCMProjectEN.CmPrjId; //Cm工程Id
objRow[conCMProject.CmPrjName] = objCMProjectEN.CmPrjName; //CM工程名
objRow[conCMProject.PrjId] = objCMProjectEN.PrjId; //工程Id
objRow[conCMProject.ApplicationTypeId] = objCMProjectEN.ApplicationTypeId; //应用程序类型ID
 if (objCMProjectEN.FunctionTemplateId !=  "")
 {
objRow[conCMProject.FunctionTemplateId] = objCMProjectEN.FunctionTemplateId; //函数模板Id
 }
 if (objCMProjectEN.VueDesignSysId !=  "")
 {
objRow[conCMProject.VueDesignSysId] = objCMProjectEN.VueDesignSysId; //Vue控件设计体系Id
 }
objRow[conCMProject.IsFstLcase] = objCMProjectEN.IsFstLcase; //是否首字母小写
objRow[conCMProject.IsCamelCase] = objCMProjectEN.IsCamelCase; //是否使用CamelCase
 if (objCMProjectEN.ProjectFileName !=  "")
 {
objRow[conCMProject.ProjectFileName] = objCMProjectEN.ProjectFileName; //工程文件名
 }
 if (objCMProjectEN.UseStateId !=  "")
 {
objRow[conCMProject.UseStateId] = objCMProjectEN.UseStateId; //使用状态Id
 }
objRow[conCMProject.IsRefresh4RelaView] = objCMProjectEN.IsRefresh4RelaView; //是否刷新相关视图
 if (objCMProjectEN.UpdDate !=  "")
 {
objRow[conCMProject.UpdDate] = objCMProjectEN.UpdDate; //修改日期
 }
 if (objCMProjectEN.UpdUserId !=  "")
 {
objRow[conCMProject.UpdUserId] = objCMProjectEN.UpdUserId; //修改用户Id
 }
 if (objCMProjectEN.Memo !=  "")
 {
objRow[conCMProject.Memo] = objCMProjectEN.Memo; //说明
 }
objDS.Tables[clsCMProjectEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsCMProjectEN._CurrTabName);
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
 /// <param name = "objCMProjectEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCMProjectEN objCMProjectEN)
{
 objCMProjectEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMProjectEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCMProjectEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCMProjectEN.CmPrjId !=  null)
 {
 arrFieldListForInsert.Add(conCMProject.CmPrjId);
 var strCmPrjId = objCMProjectEN.CmPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmPrjId + "'");
 }
 
 if (objCMProjectEN.CmPrjName !=  null)
 {
 arrFieldListForInsert.Add(conCMProject.CmPrjName);
 var strCmPrjName = objCMProjectEN.CmPrjName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmPrjName + "'");
 }
 
 if (objCMProjectEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conCMProject.PrjId);
 var strPrjId = objCMProjectEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 arrFieldListForInsert.Add(conCMProject.ApplicationTypeId);
 arrValueListForInsert.Add(objCMProjectEN.ApplicationTypeId.ToString());
 
 if (objCMProjectEN.FunctionTemplateId !=  null)
 {
 arrFieldListForInsert.Add(conCMProject.FunctionTemplateId);
 var strFunctionTemplateId = objCMProjectEN.FunctionTemplateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionTemplateId + "'");
 }
 
 if (objCMProjectEN.VueDesignSysId !=  null)
 {
 arrFieldListForInsert.Add(conCMProject.VueDesignSysId);
 var strVueDesignSysId = objCMProjectEN.VueDesignSysId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVueDesignSysId + "'");
 }
 
 arrFieldListForInsert.Add(conCMProject.IsFstLcase);
 arrValueListForInsert.Add("'" + (objCMProjectEN.IsFstLcase  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCMProject.IsCamelCase);
 arrValueListForInsert.Add("'" + (objCMProjectEN.IsCamelCase  ==  false ? "0" : "1") + "'");
 
 if (objCMProjectEN.ProjectFileName !=  null)
 {
 arrFieldListForInsert.Add(conCMProject.ProjectFileName);
 var strProjectFileName = objCMProjectEN.ProjectFileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProjectFileName + "'");
 }
 
 if (objCMProjectEN.UseStateId !=  null)
 {
 arrFieldListForInsert.Add(conCMProject.UseStateId);
 var strUseStateId = objCMProjectEN.UseStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUseStateId + "'");
 }
 
 arrFieldListForInsert.Add(conCMProject.IsRefresh4RelaView);
 arrValueListForInsert.Add("'" + (objCMProjectEN.IsRefresh4RelaView  ==  false ? "0" : "1") + "'");
 
 if (objCMProjectEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCMProject.UpdDate);
 var strUpdDate = objCMProjectEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCMProjectEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conCMProject.UpdUserId);
 var strUpdUserId = objCMProjectEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objCMProjectEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCMProject.Memo);
 var strMemo = objCMProjectEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CMProject");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objCMProjectEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCMProjectEN objCMProjectEN)
{
 objCMProjectEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMProjectEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCMProjectEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCMProjectEN.CmPrjId !=  null)
 {
 arrFieldListForInsert.Add(conCMProject.CmPrjId);
 var strCmPrjId = objCMProjectEN.CmPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmPrjId + "'");
 }
 
 if (objCMProjectEN.CmPrjName !=  null)
 {
 arrFieldListForInsert.Add(conCMProject.CmPrjName);
 var strCmPrjName = objCMProjectEN.CmPrjName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmPrjName + "'");
 }
 
 if (objCMProjectEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conCMProject.PrjId);
 var strPrjId = objCMProjectEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 arrFieldListForInsert.Add(conCMProject.ApplicationTypeId);
 arrValueListForInsert.Add(objCMProjectEN.ApplicationTypeId.ToString());
 
 if (objCMProjectEN.FunctionTemplateId !=  null)
 {
 arrFieldListForInsert.Add(conCMProject.FunctionTemplateId);
 var strFunctionTemplateId = objCMProjectEN.FunctionTemplateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionTemplateId + "'");
 }
 
 if (objCMProjectEN.VueDesignSysId !=  null)
 {
 arrFieldListForInsert.Add(conCMProject.VueDesignSysId);
 var strVueDesignSysId = objCMProjectEN.VueDesignSysId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVueDesignSysId + "'");
 }
 
 arrFieldListForInsert.Add(conCMProject.IsFstLcase);
 arrValueListForInsert.Add("'" + (objCMProjectEN.IsFstLcase  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCMProject.IsCamelCase);
 arrValueListForInsert.Add("'" + (objCMProjectEN.IsCamelCase  ==  false ? "0" : "1") + "'");
 
 if (objCMProjectEN.ProjectFileName !=  null)
 {
 arrFieldListForInsert.Add(conCMProject.ProjectFileName);
 var strProjectFileName = objCMProjectEN.ProjectFileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProjectFileName + "'");
 }
 
 if (objCMProjectEN.UseStateId !=  null)
 {
 arrFieldListForInsert.Add(conCMProject.UseStateId);
 var strUseStateId = objCMProjectEN.UseStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUseStateId + "'");
 }
 
 arrFieldListForInsert.Add(conCMProject.IsRefresh4RelaView);
 arrValueListForInsert.Add("'" + (objCMProjectEN.IsRefresh4RelaView  ==  false ? "0" : "1") + "'");
 
 if (objCMProjectEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCMProject.UpdDate);
 var strUpdDate = objCMProjectEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCMProjectEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conCMProject.UpdUserId);
 var strUpdUserId = objCMProjectEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objCMProjectEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCMProject.Memo);
 var strMemo = objCMProjectEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CMProject");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objCMProjectEN.CmPrjId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objCMProjectEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCMProjectEN objCMProjectEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objCMProjectEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMProjectEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCMProjectEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCMProjectEN.CmPrjId !=  null)
 {
 arrFieldListForInsert.Add(conCMProject.CmPrjId);
 var strCmPrjId = objCMProjectEN.CmPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmPrjId + "'");
 }
 
 if (objCMProjectEN.CmPrjName !=  null)
 {
 arrFieldListForInsert.Add(conCMProject.CmPrjName);
 var strCmPrjName = objCMProjectEN.CmPrjName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmPrjName + "'");
 }
 
 if (objCMProjectEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conCMProject.PrjId);
 var strPrjId = objCMProjectEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 arrFieldListForInsert.Add(conCMProject.ApplicationTypeId);
 arrValueListForInsert.Add(objCMProjectEN.ApplicationTypeId.ToString());
 
 if (objCMProjectEN.FunctionTemplateId !=  null)
 {
 arrFieldListForInsert.Add(conCMProject.FunctionTemplateId);
 var strFunctionTemplateId = objCMProjectEN.FunctionTemplateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionTemplateId + "'");
 }
 
 if (objCMProjectEN.VueDesignSysId !=  null)
 {
 arrFieldListForInsert.Add(conCMProject.VueDesignSysId);
 var strVueDesignSysId = objCMProjectEN.VueDesignSysId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVueDesignSysId + "'");
 }
 
 arrFieldListForInsert.Add(conCMProject.IsFstLcase);
 arrValueListForInsert.Add("'" + (objCMProjectEN.IsFstLcase  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCMProject.IsCamelCase);
 arrValueListForInsert.Add("'" + (objCMProjectEN.IsCamelCase  ==  false ? "0" : "1") + "'");
 
 if (objCMProjectEN.ProjectFileName !=  null)
 {
 arrFieldListForInsert.Add(conCMProject.ProjectFileName);
 var strProjectFileName = objCMProjectEN.ProjectFileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProjectFileName + "'");
 }
 
 if (objCMProjectEN.UseStateId !=  null)
 {
 arrFieldListForInsert.Add(conCMProject.UseStateId);
 var strUseStateId = objCMProjectEN.UseStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUseStateId + "'");
 }
 
 arrFieldListForInsert.Add(conCMProject.IsRefresh4RelaView);
 arrValueListForInsert.Add("'" + (objCMProjectEN.IsRefresh4RelaView  ==  false ? "0" : "1") + "'");
 
 if (objCMProjectEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCMProject.UpdDate);
 var strUpdDate = objCMProjectEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCMProjectEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conCMProject.UpdUserId);
 var strUpdUserId = objCMProjectEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objCMProjectEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCMProject.Memo);
 var strMemo = objCMProjectEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CMProject");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objCMProjectEN.CmPrjId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objCMProjectEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCMProjectEN objCMProjectEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objCMProjectEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMProjectEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCMProjectEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCMProjectEN.CmPrjId !=  null)
 {
 arrFieldListForInsert.Add(conCMProject.CmPrjId);
 var strCmPrjId = objCMProjectEN.CmPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmPrjId + "'");
 }
 
 if (objCMProjectEN.CmPrjName !=  null)
 {
 arrFieldListForInsert.Add(conCMProject.CmPrjName);
 var strCmPrjName = objCMProjectEN.CmPrjName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmPrjName + "'");
 }
 
 if (objCMProjectEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conCMProject.PrjId);
 var strPrjId = objCMProjectEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 arrFieldListForInsert.Add(conCMProject.ApplicationTypeId);
 arrValueListForInsert.Add(objCMProjectEN.ApplicationTypeId.ToString());
 
 if (objCMProjectEN.FunctionTemplateId !=  null)
 {
 arrFieldListForInsert.Add(conCMProject.FunctionTemplateId);
 var strFunctionTemplateId = objCMProjectEN.FunctionTemplateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionTemplateId + "'");
 }
 
 if (objCMProjectEN.VueDesignSysId !=  null)
 {
 arrFieldListForInsert.Add(conCMProject.VueDesignSysId);
 var strVueDesignSysId = objCMProjectEN.VueDesignSysId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVueDesignSysId + "'");
 }
 
 arrFieldListForInsert.Add(conCMProject.IsFstLcase);
 arrValueListForInsert.Add("'" + (objCMProjectEN.IsFstLcase  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCMProject.IsCamelCase);
 arrValueListForInsert.Add("'" + (objCMProjectEN.IsCamelCase  ==  false ? "0" : "1") + "'");
 
 if (objCMProjectEN.ProjectFileName !=  null)
 {
 arrFieldListForInsert.Add(conCMProject.ProjectFileName);
 var strProjectFileName = objCMProjectEN.ProjectFileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProjectFileName + "'");
 }
 
 if (objCMProjectEN.UseStateId !=  null)
 {
 arrFieldListForInsert.Add(conCMProject.UseStateId);
 var strUseStateId = objCMProjectEN.UseStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUseStateId + "'");
 }
 
 arrFieldListForInsert.Add(conCMProject.IsRefresh4RelaView);
 arrValueListForInsert.Add("'" + (objCMProjectEN.IsRefresh4RelaView  ==  false ? "0" : "1") + "'");
 
 if (objCMProjectEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCMProject.UpdDate);
 var strUpdDate = objCMProjectEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCMProjectEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conCMProject.UpdUserId);
 var strUpdUserId = objCMProjectEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objCMProjectEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCMProject.Memo);
 var strMemo = objCMProjectEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CMProject");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewCMProjects(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectDA.GetSpecSQLObj();
strSQL = "Select * from CMProject where CmPrjId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CMProject");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strCmPrjId = oRow[conCMProject.CmPrjId].ToString().Trim();
if (IsExist(strCmPrjId))
{
 string strResult = "关键字变量值为:" + string.Format("CmPrjId = {0}", strCmPrjId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsCMProjectEN._CurrTabName ].NewRow();
objRow[conCMProject.CmPrjId] = oRow[conCMProject.CmPrjId].ToString().Trim(); //Cm工程Id
objRow[conCMProject.CmPrjName] = oRow[conCMProject.CmPrjName].ToString().Trim(); //CM工程名
objRow[conCMProject.PrjId] = oRow[conCMProject.PrjId].ToString().Trim(); //工程Id
objRow[conCMProject.ApplicationTypeId] = oRow[conCMProject.ApplicationTypeId].ToString().Trim(); //应用程序类型ID
objRow[conCMProject.FunctionTemplateId] = oRow[conCMProject.FunctionTemplateId].ToString().Trim(); //函数模板Id
objRow[conCMProject.VueDesignSysId] = oRow[conCMProject.VueDesignSysId].ToString().Trim(); //Vue控件设计体系Id
objRow[conCMProject.IsFstLcase] = oRow[conCMProject.IsFstLcase].ToString().Trim(); //是否首字母小写
objRow[conCMProject.IsCamelCase] = oRow[conCMProject.IsCamelCase].ToString().Trim(); //是否使用CamelCase
objRow[conCMProject.ProjectFileName] = oRow[conCMProject.ProjectFileName].ToString().Trim(); //工程文件名
objRow[conCMProject.UseStateId] = oRow[conCMProject.UseStateId].ToString().Trim(); //使用状态Id
objRow[conCMProject.IsRefresh4RelaView] = oRow[conCMProject.IsRefresh4RelaView].ToString().Trim(); //是否刷新相关视图
objRow[conCMProject.UpdDate] = oRow[conCMProject.UpdDate].ToString().Trim(); //修改日期
objRow[conCMProject.UpdUserId] = oRow[conCMProject.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conCMProject.Memo] = oRow[conCMProject.Memo].ToString().Trim(); //说明
 objDS.Tables[clsCMProjectEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsCMProjectEN._CurrTabName);
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
 /// <param name = "objCMProjectEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsCMProjectEN objCMProjectEN)
{
 objCMProjectEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMProjectEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCMProjectEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectDA.GetSpecSQLObj();
strSQL = "Select * from CMProject where CmPrjId = " + "'"+ objCMProjectEN.CmPrjId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsCMProjectEN._CurrTabName);
if (objDS.Tables[clsCMProjectEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:CmPrjId = " + "'"+ objCMProjectEN.CmPrjId+"'");
return false;
}
objRow = objDS.Tables[clsCMProjectEN._CurrTabName].Rows[0];
 if (objCMProjectEN.IsUpdated(conCMProject.CmPrjId))
 {
objRow[conCMProject.CmPrjId] = objCMProjectEN.CmPrjId; //Cm工程Id
 }
 if (objCMProjectEN.IsUpdated(conCMProject.CmPrjName))
 {
objRow[conCMProject.CmPrjName] = objCMProjectEN.CmPrjName; //CM工程名
 }
 if (objCMProjectEN.IsUpdated(conCMProject.PrjId))
 {
objRow[conCMProject.PrjId] = objCMProjectEN.PrjId; //工程Id
 }
 if (objCMProjectEN.IsUpdated(conCMProject.ApplicationTypeId))
 {
objRow[conCMProject.ApplicationTypeId] = objCMProjectEN.ApplicationTypeId; //应用程序类型ID
 }
 if (objCMProjectEN.IsUpdated(conCMProject.FunctionTemplateId))
 {
objRow[conCMProject.FunctionTemplateId] = objCMProjectEN.FunctionTemplateId; //函数模板Id
 }
 if (objCMProjectEN.IsUpdated(conCMProject.VueDesignSysId))
 {
objRow[conCMProject.VueDesignSysId] = objCMProjectEN.VueDesignSysId; //Vue控件设计体系Id
 }
 if (objCMProjectEN.IsUpdated(conCMProject.IsFstLcase))
 {
objRow[conCMProject.IsFstLcase] = objCMProjectEN.IsFstLcase; //是否首字母小写
 }
 if (objCMProjectEN.IsUpdated(conCMProject.IsCamelCase))
 {
objRow[conCMProject.IsCamelCase] = objCMProjectEN.IsCamelCase; //是否使用CamelCase
 }
 if (objCMProjectEN.IsUpdated(conCMProject.ProjectFileName))
 {
objRow[conCMProject.ProjectFileName] = objCMProjectEN.ProjectFileName; //工程文件名
 }
 if (objCMProjectEN.IsUpdated(conCMProject.UseStateId))
 {
objRow[conCMProject.UseStateId] = objCMProjectEN.UseStateId; //使用状态Id
 }
 if (objCMProjectEN.IsUpdated(conCMProject.IsRefresh4RelaView))
 {
objRow[conCMProject.IsRefresh4RelaView] = objCMProjectEN.IsRefresh4RelaView; //是否刷新相关视图
 }
 if (objCMProjectEN.IsUpdated(conCMProject.UpdDate))
 {
objRow[conCMProject.UpdDate] = objCMProjectEN.UpdDate; //修改日期
 }
 if (objCMProjectEN.IsUpdated(conCMProject.UpdUserId))
 {
objRow[conCMProject.UpdUserId] = objCMProjectEN.UpdUserId; //修改用户Id
 }
 if (objCMProjectEN.IsUpdated(conCMProject.Memo))
 {
objRow[conCMProject.Memo] = objCMProjectEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsCMProjectEN._CurrTabName);
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
 /// <param name = "objCMProjectEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCMProjectEN objCMProjectEN)
{
 objCMProjectEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMProjectEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCMProjectEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update CMProject Set ");
 
 if (objCMProjectEN.IsUpdated(conCMProject.CmPrjName))
 {
 if (objCMProjectEN.CmPrjName !=  null)
 {
 var strCmPrjName = objCMProjectEN.CmPrjName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCmPrjName, conCMProject.CmPrjName); //CM工程名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMProject.CmPrjName); //CM工程名
 }
 }
 
 if (objCMProjectEN.IsUpdated(conCMProject.PrjId))
 {
 if (objCMProjectEN.PrjId !=  null)
 {
 var strPrjId = objCMProjectEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conCMProject.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMProject.PrjId); //工程Id
 }
 }
 
 if (objCMProjectEN.IsUpdated(conCMProject.ApplicationTypeId))
 {
 sbSQL.AppendFormat("{1} = {0},",objCMProjectEN.ApplicationTypeId, conCMProject.ApplicationTypeId); //应用程序类型ID
 }
 
 if (objCMProjectEN.IsUpdated(conCMProject.FunctionTemplateId))
 {
 if (objCMProjectEN.FunctionTemplateId !=  null)
 {
 var strFunctionTemplateId = objCMProjectEN.FunctionTemplateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFunctionTemplateId, conCMProject.FunctionTemplateId); //函数模板Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMProject.FunctionTemplateId); //函数模板Id
 }
 }
 
 if (objCMProjectEN.IsUpdated(conCMProject.VueDesignSysId))
 {
 if (objCMProjectEN.VueDesignSysId !=  null)
 {
 var strVueDesignSysId = objCMProjectEN.VueDesignSysId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVueDesignSysId, conCMProject.VueDesignSysId); //Vue控件设计体系Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMProject.VueDesignSysId); //Vue控件设计体系Id
 }
 }
 
 if (objCMProjectEN.IsUpdated(conCMProject.IsFstLcase))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCMProjectEN.IsFstLcase == true?"1":"0", conCMProject.IsFstLcase); //是否首字母小写
 }
 
 if (objCMProjectEN.IsUpdated(conCMProject.IsCamelCase))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCMProjectEN.IsCamelCase == true?"1":"0", conCMProject.IsCamelCase); //是否使用CamelCase
 }
 
 if (objCMProjectEN.IsUpdated(conCMProject.ProjectFileName))
 {
 if (objCMProjectEN.ProjectFileName !=  null)
 {
 var strProjectFileName = objCMProjectEN.ProjectFileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProjectFileName, conCMProject.ProjectFileName); //工程文件名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMProject.ProjectFileName); //工程文件名
 }
 }
 
 if (objCMProjectEN.IsUpdated(conCMProject.UseStateId))
 {
 if (objCMProjectEN.UseStateId !=  null)
 {
 var strUseStateId = objCMProjectEN.UseStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUseStateId, conCMProject.UseStateId); //使用状态Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMProject.UseStateId); //使用状态Id
 }
 }
 
 if (objCMProjectEN.IsUpdated(conCMProject.IsRefresh4RelaView))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCMProjectEN.IsRefresh4RelaView == true?"1":"0", conCMProject.IsRefresh4RelaView); //是否刷新相关视图
 }
 
 if (objCMProjectEN.IsUpdated(conCMProject.UpdDate))
 {
 if (objCMProjectEN.UpdDate !=  null)
 {
 var strUpdDate = objCMProjectEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conCMProject.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMProject.UpdDate); //修改日期
 }
 }
 
 if (objCMProjectEN.IsUpdated(conCMProject.UpdUserId))
 {
 if (objCMProjectEN.UpdUserId !=  null)
 {
 var strUpdUserId = objCMProjectEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conCMProject.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMProject.UpdUserId); //修改用户Id
 }
 }
 
 if (objCMProjectEN.IsUpdated(conCMProject.Memo))
 {
 if (objCMProjectEN.Memo !=  null)
 {
 var strMemo = objCMProjectEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCMProject.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMProject.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where CmPrjId = '{0}'", objCMProjectEN.CmPrjId); 
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
 /// <param name = "objCMProjectEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsCMProjectEN objCMProjectEN, string strCondition)
{
 objCMProjectEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMProjectEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCMProjectEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CMProject Set ");
 
 if (objCMProjectEN.IsUpdated(conCMProject.CmPrjName))
 {
 if (objCMProjectEN.CmPrjName !=  null)
 {
 var strCmPrjName = objCMProjectEN.CmPrjName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CmPrjName = '{0}',", strCmPrjName); //CM工程名
 }
 else
 {
 sbSQL.Append(" CmPrjName = null,"); //CM工程名
 }
 }
 
 if (objCMProjectEN.IsUpdated(conCMProject.PrjId))
 {
 if (objCMProjectEN.PrjId !=  null)
 {
 var strPrjId = objCMProjectEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objCMProjectEN.IsUpdated(conCMProject.ApplicationTypeId))
 {
 sbSQL.AppendFormat(" ApplicationTypeId = {0},", objCMProjectEN.ApplicationTypeId); //应用程序类型ID
 }
 
 if (objCMProjectEN.IsUpdated(conCMProject.FunctionTemplateId))
 {
 if (objCMProjectEN.FunctionTemplateId !=  null)
 {
 var strFunctionTemplateId = objCMProjectEN.FunctionTemplateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FunctionTemplateId = '{0}',", strFunctionTemplateId); //函数模板Id
 }
 else
 {
 sbSQL.Append(" FunctionTemplateId = null,"); //函数模板Id
 }
 }
 
 if (objCMProjectEN.IsUpdated(conCMProject.VueDesignSysId))
 {
 if (objCMProjectEN.VueDesignSysId !=  null)
 {
 var strVueDesignSysId = objCMProjectEN.VueDesignSysId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VueDesignSysId = '{0}',", strVueDesignSysId); //Vue控件设计体系Id
 }
 else
 {
 sbSQL.Append(" VueDesignSysId = null,"); //Vue控件设计体系Id
 }
 }
 
 if (objCMProjectEN.IsUpdated(conCMProject.IsFstLcase))
 {
 sbSQL.AppendFormat(" IsFstLcase = '{0}',", objCMProjectEN.IsFstLcase == true?"1":"0"); //是否首字母小写
 }
 
 if (objCMProjectEN.IsUpdated(conCMProject.IsCamelCase))
 {
 sbSQL.AppendFormat(" IsCamelCase = '{0}',", objCMProjectEN.IsCamelCase == true?"1":"0"); //是否使用CamelCase
 }
 
 if (objCMProjectEN.IsUpdated(conCMProject.ProjectFileName))
 {
 if (objCMProjectEN.ProjectFileName !=  null)
 {
 var strProjectFileName = objCMProjectEN.ProjectFileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProjectFileName = '{0}',", strProjectFileName); //工程文件名
 }
 else
 {
 sbSQL.Append(" ProjectFileName = null,"); //工程文件名
 }
 }
 
 if (objCMProjectEN.IsUpdated(conCMProject.UseStateId))
 {
 if (objCMProjectEN.UseStateId !=  null)
 {
 var strUseStateId = objCMProjectEN.UseStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UseStateId = '{0}',", strUseStateId); //使用状态Id
 }
 else
 {
 sbSQL.Append(" UseStateId = null,"); //使用状态Id
 }
 }
 
 if (objCMProjectEN.IsUpdated(conCMProject.IsRefresh4RelaView))
 {
 sbSQL.AppendFormat(" IsRefresh4RelaView = '{0}',", objCMProjectEN.IsRefresh4RelaView == true?"1":"0"); //是否刷新相关视图
 }
 
 if (objCMProjectEN.IsUpdated(conCMProject.UpdDate))
 {
 if (objCMProjectEN.UpdDate !=  null)
 {
 var strUpdDate = objCMProjectEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objCMProjectEN.IsUpdated(conCMProject.UpdUserId))
 {
 if (objCMProjectEN.UpdUserId !=  null)
 {
 var strUpdUserId = objCMProjectEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objCMProjectEN.IsUpdated(conCMProject.Memo))
 {
 if (objCMProjectEN.Memo !=  null)
 {
 var strMemo = objCMProjectEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objCMProjectEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsCMProjectEN objCMProjectEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objCMProjectEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMProjectEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCMProjectEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CMProject Set ");
 
 if (objCMProjectEN.IsUpdated(conCMProject.CmPrjName))
 {
 if (objCMProjectEN.CmPrjName !=  null)
 {
 var strCmPrjName = objCMProjectEN.CmPrjName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CmPrjName = '{0}',", strCmPrjName); //CM工程名
 }
 else
 {
 sbSQL.Append(" CmPrjName = null,"); //CM工程名
 }
 }
 
 if (objCMProjectEN.IsUpdated(conCMProject.PrjId))
 {
 if (objCMProjectEN.PrjId !=  null)
 {
 var strPrjId = objCMProjectEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objCMProjectEN.IsUpdated(conCMProject.ApplicationTypeId))
 {
 sbSQL.AppendFormat(" ApplicationTypeId = {0},", objCMProjectEN.ApplicationTypeId); //应用程序类型ID
 }
 
 if (objCMProjectEN.IsUpdated(conCMProject.FunctionTemplateId))
 {
 if (objCMProjectEN.FunctionTemplateId !=  null)
 {
 var strFunctionTemplateId = objCMProjectEN.FunctionTemplateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FunctionTemplateId = '{0}',", strFunctionTemplateId); //函数模板Id
 }
 else
 {
 sbSQL.Append(" FunctionTemplateId = null,"); //函数模板Id
 }
 }
 
 if (objCMProjectEN.IsUpdated(conCMProject.VueDesignSysId))
 {
 if (objCMProjectEN.VueDesignSysId !=  null)
 {
 var strVueDesignSysId = objCMProjectEN.VueDesignSysId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VueDesignSysId = '{0}',", strVueDesignSysId); //Vue控件设计体系Id
 }
 else
 {
 sbSQL.Append(" VueDesignSysId = null,"); //Vue控件设计体系Id
 }
 }
 
 if (objCMProjectEN.IsUpdated(conCMProject.IsFstLcase))
 {
 sbSQL.AppendFormat(" IsFstLcase = '{0}',", objCMProjectEN.IsFstLcase == true?"1":"0"); //是否首字母小写
 }
 
 if (objCMProjectEN.IsUpdated(conCMProject.IsCamelCase))
 {
 sbSQL.AppendFormat(" IsCamelCase = '{0}',", objCMProjectEN.IsCamelCase == true?"1":"0"); //是否使用CamelCase
 }
 
 if (objCMProjectEN.IsUpdated(conCMProject.ProjectFileName))
 {
 if (objCMProjectEN.ProjectFileName !=  null)
 {
 var strProjectFileName = objCMProjectEN.ProjectFileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProjectFileName = '{0}',", strProjectFileName); //工程文件名
 }
 else
 {
 sbSQL.Append(" ProjectFileName = null,"); //工程文件名
 }
 }
 
 if (objCMProjectEN.IsUpdated(conCMProject.UseStateId))
 {
 if (objCMProjectEN.UseStateId !=  null)
 {
 var strUseStateId = objCMProjectEN.UseStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UseStateId = '{0}',", strUseStateId); //使用状态Id
 }
 else
 {
 sbSQL.Append(" UseStateId = null,"); //使用状态Id
 }
 }
 
 if (objCMProjectEN.IsUpdated(conCMProject.IsRefresh4RelaView))
 {
 sbSQL.AppendFormat(" IsRefresh4RelaView = '{0}',", objCMProjectEN.IsRefresh4RelaView == true?"1":"0"); //是否刷新相关视图
 }
 
 if (objCMProjectEN.IsUpdated(conCMProject.UpdDate))
 {
 if (objCMProjectEN.UpdDate !=  null)
 {
 var strUpdDate = objCMProjectEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objCMProjectEN.IsUpdated(conCMProject.UpdUserId))
 {
 if (objCMProjectEN.UpdUserId !=  null)
 {
 var strUpdUserId = objCMProjectEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objCMProjectEN.IsUpdated(conCMProject.Memo))
 {
 if (objCMProjectEN.Memo !=  null)
 {
 var strMemo = objCMProjectEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objCMProjectEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCMProjectEN objCMProjectEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objCMProjectEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMProjectEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCMProjectEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CMProject Set ");
 
 if (objCMProjectEN.IsUpdated(conCMProject.CmPrjName))
 {
 if (objCMProjectEN.CmPrjName !=  null)
 {
 var strCmPrjName = objCMProjectEN.CmPrjName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCmPrjName, conCMProject.CmPrjName); //CM工程名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMProject.CmPrjName); //CM工程名
 }
 }
 
 if (objCMProjectEN.IsUpdated(conCMProject.PrjId))
 {
 if (objCMProjectEN.PrjId !=  null)
 {
 var strPrjId = objCMProjectEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conCMProject.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMProject.PrjId); //工程Id
 }
 }
 
 if (objCMProjectEN.IsUpdated(conCMProject.ApplicationTypeId))
 {
 sbSQL.AppendFormat("{1} = {0},",objCMProjectEN.ApplicationTypeId, conCMProject.ApplicationTypeId); //应用程序类型ID
 }
 
 if (objCMProjectEN.IsUpdated(conCMProject.FunctionTemplateId))
 {
 if (objCMProjectEN.FunctionTemplateId !=  null)
 {
 var strFunctionTemplateId = objCMProjectEN.FunctionTemplateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFunctionTemplateId, conCMProject.FunctionTemplateId); //函数模板Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMProject.FunctionTemplateId); //函数模板Id
 }
 }
 
 if (objCMProjectEN.IsUpdated(conCMProject.VueDesignSysId))
 {
 if (objCMProjectEN.VueDesignSysId !=  null)
 {
 var strVueDesignSysId = objCMProjectEN.VueDesignSysId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVueDesignSysId, conCMProject.VueDesignSysId); //Vue控件设计体系Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMProject.VueDesignSysId); //Vue控件设计体系Id
 }
 }
 
 if (objCMProjectEN.IsUpdated(conCMProject.IsFstLcase))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCMProjectEN.IsFstLcase == true?"1":"0", conCMProject.IsFstLcase); //是否首字母小写
 }
 
 if (objCMProjectEN.IsUpdated(conCMProject.IsCamelCase))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCMProjectEN.IsCamelCase == true?"1":"0", conCMProject.IsCamelCase); //是否使用CamelCase
 }
 
 if (objCMProjectEN.IsUpdated(conCMProject.ProjectFileName))
 {
 if (objCMProjectEN.ProjectFileName !=  null)
 {
 var strProjectFileName = objCMProjectEN.ProjectFileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProjectFileName, conCMProject.ProjectFileName); //工程文件名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMProject.ProjectFileName); //工程文件名
 }
 }
 
 if (objCMProjectEN.IsUpdated(conCMProject.UseStateId))
 {
 if (objCMProjectEN.UseStateId !=  null)
 {
 var strUseStateId = objCMProjectEN.UseStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUseStateId, conCMProject.UseStateId); //使用状态Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMProject.UseStateId); //使用状态Id
 }
 }
 
 if (objCMProjectEN.IsUpdated(conCMProject.IsRefresh4RelaView))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCMProjectEN.IsRefresh4RelaView == true?"1":"0", conCMProject.IsRefresh4RelaView); //是否刷新相关视图
 }
 
 if (objCMProjectEN.IsUpdated(conCMProject.UpdDate))
 {
 if (objCMProjectEN.UpdDate !=  null)
 {
 var strUpdDate = objCMProjectEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conCMProject.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMProject.UpdDate); //修改日期
 }
 }
 
 if (objCMProjectEN.IsUpdated(conCMProject.UpdUserId))
 {
 if (objCMProjectEN.UpdUserId !=  null)
 {
 var strUpdUserId = objCMProjectEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conCMProject.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMProject.UpdUserId); //修改用户Id
 }
 }
 
 if (objCMProjectEN.IsUpdated(conCMProject.Memo))
 {
 if (objCMProjectEN.Memo !=  null)
 {
 var strMemo = objCMProjectEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCMProject.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMProject.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where CmPrjId = '{0}'", objCMProjectEN.CmPrjId); 
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
 /// <param name = "strCmPrjId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strCmPrjId) 
{
CheckPrimaryKey(strCmPrjId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strCmPrjId,
};
 objSQL.ExecSP("CMProject_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strCmPrjId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strCmPrjId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strCmPrjId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectDA.GetSpecSQLObj();
//删除CMProject本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CMProject where CmPrjId = " + "'"+ strCmPrjId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelCMProject(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectDA.GetSpecSQLObj();
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
//删除CMProject本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CMProject where CmPrjId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strCmPrjId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strCmPrjId) 
{
CheckPrimaryKey(strCmPrjId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectDA.GetSpecSQLObj();
//删除CMProject本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CMProject where CmPrjId = " + "'"+ strCmPrjId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelCMProject(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsCMProjectDA: DelCMProject)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CMProject where " + strCondition ;
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
public bool DelCMProjectWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsCMProjectDA: DelCMProjectWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CMProject where " + strCondition ;
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
 /// <param name = "objCMProjectENS">源对象</param>
 /// <param name = "objCMProjectENT">目标对象</param>
public void CopyTo(clsCMProjectEN objCMProjectENS, clsCMProjectEN objCMProjectENT)
{
objCMProjectENT.CmPrjId = objCMProjectENS.CmPrjId; //Cm工程Id
objCMProjectENT.CmPrjName = objCMProjectENS.CmPrjName; //CM工程名
objCMProjectENT.PrjId = objCMProjectENS.PrjId; //工程Id
objCMProjectENT.ApplicationTypeId = objCMProjectENS.ApplicationTypeId; //应用程序类型ID
objCMProjectENT.FunctionTemplateId = objCMProjectENS.FunctionTemplateId; //函数模板Id
objCMProjectENT.VueDesignSysId = objCMProjectENS.VueDesignSysId; //Vue控件设计体系Id
objCMProjectENT.IsFstLcase = objCMProjectENS.IsFstLcase; //是否首字母小写
objCMProjectENT.IsCamelCase = objCMProjectENS.IsCamelCase; //是否使用CamelCase
objCMProjectENT.ProjectFileName = objCMProjectENS.ProjectFileName; //工程文件名
objCMProjectENT.UseStateId = objCMProjectENS.UseStateId; //使用状态Id
objCMProjectENT.IsRefresh4RelaView = objCMProjectENS.IsRefresh4RelaView; //是否刷新相关视图
objCMProjectENT.UpdDate = objCMProjectENS.UpdDate; //修改日期
objCMProjectENT.UpdUserId = objCMProjectENS.UpdUserId; //修改用户Id
objCMProjectENT.Memo = objCMProjectENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsCMProjectEN objCMProjectEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objCMProjectEN.CmPrjName, conCMProject.CmPrjName);
clsCheckSql.CheckFieldNotNull(objCMProjectEN.PrjId, conCMProject.PrjId);
clsCheckSql.CheckFieldNotNull(objCMProjectEN.ApplicationTypeId, conCMProject.ApplicationTypeId);
//检查字段长度
clsCheckSql.CheckFieldLen(objCMProjectEN.CmPrjId, 6, conCMProject.CmPrjId);
clsCheckSql.CheckFieldLen(objCMProjectEN.CmPrjName, 50, conCMProject.CmPrjName);
clsCheckSql.CheckFieldLen(objCMProjectEN.PrjId, 4, conCMProject.PrjId);
clsCheckSql.CheckFieldLen(objCMProjectEN.FunctionTemplateId, 4, conCMProject.FunctionTemplateId);
clsCheckSql.CheckFieldLen(objCMProjectEN.VueDesignSysId, 2, conCMProject.VueDesignSysId);
clsCheckSql.CheckFieldLen(objCMProjectEN.ProjectFileName, 200, conCMProject.ProjectFileName);
clsCheckSql.CheckFieldLen(objCMProjectEN.UseStateId, 4, conCMProject.UseStateId);
clsCheckSql.CheckFieldLen(objCMProjectEN.UpdDate, 20, conCMProject.UpdDate);
clsCheckSql.CheckFieldLen(objCMProjectEN.UpdUserId, 20, conCMProject.UpdUserId);
clsCheckSql.CheckFieldLen(objCMProjectEN.Memo, 1000, conCMProject.Memo);
//检查字段外键固定长度
 objCMProjectEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsCMProjectEN objCMProjectEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCMProjectEN.CmPrjName, 50, conCMProject.CmPrjName);
clsCheckSql.CheckFieldLen(objCMProjectEN.PrjId, 4, conCMProject.PrjId);
clsCheckSql.CheckFieldLen(objCMProjectEN.FunctionTemplateId, 4, conCMProject.FunctionTemplateId);
clsCheckSql.CheckFieldLen(objCMProjectEN.VueDesignSysId, 2, conCMProject.VueDesignSysId);
clsCheckSql.CheckFieldLen(objCMProjectEN.ProjectFileName, 200, conCMProject.ProjectFileName);
clsCheckSql.CheckFieldLen(objCMProjectEN.UseStateId, 4, conCMProject.UseStateId);
clsCheckSql.CheckFieldLen(objCMProjectEN.UpdDate, 20, conCMProject.UpdDate);
clsCheckSql.CheckFieldLen(objCMProjectEN.UpdUserId, 20, conCMProject.UpdUserId);
clsCheckSql.CheckFieldLen(objCMProjectEN.Memo, 1000, conCMProject.Memo);
//检查外键字段长度
 objCMProjectEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsCMProjectEN objCMProjectEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCMProjectEN.CmPrjId, 6, conCMProject.CmPrjId);
clsCheckSql.CheckFieldLen(objCMProjectEN.CmPrjName, 50, conCMProject.CmPrjName);
clsCheckSql.CheckFieldLen(objCMProjectEN.PrjId, 4, conCMProject.PrjId);
clsCheckSql.CheckFieldLen(objCMProjectEN.FunctionTemplateId, 4, conCMProject.FunctionTemplateId);
clsCheckSql.CheckFieldLen(objCMProjectEN.VueDesignSysId, 2, conCMProject.VueDesignSysId);
clsCheckSql.CheckFieldLen(objCMProjectEN.ProjectFileName, 200, conCMProject.ProjectFileName);
clsCheckSql.CheckFieldLen(objCMProjectEN.UseStateId, 4, conCMProject.UseStateId);
clsCheckSql.CheckFieldLen(objCMProjectEN.UpdDate, 20, conCMProject.UpdDate);
clsCheckSql.CheckFieldLen(objCMProjectEN.UpdUserId, 20, conCMProject.UpdUserId);
clsCheckSql.CheckFieldLen(objCMProjectEN.Memo, 1000, conCMProject.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objCMProjectEN.CmPrjId, conCMProject.CmPrjId);
clsCheckSql.CheckSqlInjection4Field(objCMProjectEN.CmPrjName, conCMProject.CmPrjName);
clsCheckSql.CheckSqlInjection4Field(objCMProjectEN.PrjId, conCMProject.PrjId);
clsCheckSql.CheckSqlInjection4Field(objCMProjectEN.FunctionTemplateId, conCMProject.FunctionTemplateId);
clsCheckSql.CheckSqlInjection4Field(objCMProjectEN.VueDesignSysId, conCMProject.VueDesignSysId);
clsCheckSql.CheckSqlInjection4Field(objCMProjectEN.ProjectFileName, conCMProject.ProjectFileName);
clsCheckSql.CheckSqlInjection4Field(objCMProjectEN.UseStateId, conCMProject.UseStateId);
clsCheckSql.CheckSqlInjection4Field(objCMProjectEN.UpdDate, conCMProject.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objCMProjectEN.UpdUserId, conCMProject.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objCMProjectEN.Memo, conCMProject.Memo);
//检查外键字段长度
 objCMProjectEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetCmPrjId()
{
//获取某学院所有专业信息
string strSQL = "select CmPrjId, CmPrjName from CMProject ";
 clsSpecSQLforSql mySql = clsCMProjectDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--CMProject(CM项目),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objCMProjectEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsCMProjectEN objCMProjectEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CmPrjName = '{0}'", objCMProjectEN.CmPrjName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objCMProjectEN.PrjId);
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
 objSQL = clsCMProjectDA.GetSpecSQLObj();
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
 objSQL = clsCMProjectDA.GetSpecSQLObj();
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
 objSQL = clsCMProjectDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCMProjectEN._CurrTabName);
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
 objSQL = clsCMProjectDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCMProjectEN._CurrTabName, strCondition);
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
 objSQL = clsCMProjectDA.GetSpecSQLObj();
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
 objSQL = clsCMProjectDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}