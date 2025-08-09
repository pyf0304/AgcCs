
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCMRequirementDA
 表名:CMRequirement(00050075)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:03:43
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
 /// 项目需求(CMRequirement)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsCMRequirementDA : clsCommBase4DA
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
 return clsCMRequirementEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsCMRequirementEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCMRequirementEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsCMRequirementEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsCMRequirementEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strReqId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strReqId)
{
strReqId = strReqId.Replace("'", "''");
if (strReqId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:CMRequirement中,检查关键字,长度不正确!(clsCMRequirementDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strReqId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:CMRequirement中,关键字不能为空 或 null!(clsCMRequirementDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strReqId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsCMRequirementDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsCMRequirementDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMRequirementDA.GetSpecSQLObj();
strSQL = "Select * from CMRequirement where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_CMRequirement(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsCMRequirementDA: GetDataTable_CMRequirement)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMRequirementDA.GetSpecSQLObj();
strSQL = "Select * from CMRequirement where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsCMRequirementDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMRequirementDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsCMRequirementDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMRequirementDA.GetSpecSQLObj();
strSQL = "Select * from CMRequirement where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsCMRequirementDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMRequirementDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsCMRequirementDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMRequirementDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CMRequirement where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CMRequirement where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsCMRequirementDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMRequirementDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from CMRequirement where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsCMRequirementDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMRequirementDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} CMRequirement.* " + 
$"from CMRequirement " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and CMRequirement.ReqId not in " + 
$"(Select top {intTop_In} CMRequirement.ReqId from CMRequirement " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CMRequirement where {1} and ReqId not in (Select top {2} ReqId from CMRequirement where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CMRequirement where {1} and ReqId not in (Select top {3} ReqId from CMRequirement where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsCMRequirementDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMRequirementDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} CMRequirement.* " + 
$"from CMRequirement " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and CMRequirement.ReqId not in " + 
$"(Select top {intTop_In} CMRequirement.ReqId from CMRequirement " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CMRequirement where {1} and ReqId not in (Select top {2} ReqId from CMRequirement where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CMRequirement where {1} and ReqId not in (Select top {3} ReqId from CMRequirement where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsCMRequirementEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsCMRequirementDA:GetObjLst)", objException.Message));
}
List<clsCMRequirementEN> arrObjLst = new List<clsCMRequirementEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMRequirementDA.GetSpecSQLObj();
strSQL = "Select * from CMRequirement where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMRequirementEN objCMRequirementEN = new clsCMRequirementEN();
try
{
objCMRequirementEN.ReqId = objRow[conCMRequirement.ReqId].ToString().Trim(); //需求Id
objCMRequirementEN.RequirementName = objRow[conCMRequirement.RequirementName].ToString().Trim(); //需求名称
objCMRequirementEN.RequirementTypeId = objRow[conCMRequirement.RequirementTypeId].ToString().Trim(); //需求类型Id
objCMRequirementEN.ReqContent = objRow[conCMRequirement.ReqContent].ToString().Trim(); //需求内容
objCMRequirementEN.UpReqId = objRow[conCMRequirement.UpReqId] == DBNull.Value ? null : objRow[conCMRequirement.UpReqId].ToString().Trim(); //上级需求Id
objCMRequirementEN.IsFinished = TransNullToBool(objRow[conCMRequirement.IsFinished].ToString().Trim()); //是否完成
objCMRequirementEN.CmPrjId = objRow[conCMRequirement.CmPrjId].ToString().Trim(); //Cm工程Id
objCMRequirementEN.FuncModuleAgcId = objRow[conCMRequirement.FuncModuleAgcId] == DBNull.Value ? null : objRow[conCMRequirement.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objCMRequirementEN.PrjId = objRow[conCMRequirement.PrjId].ToString().Trim(); //工程Id
objCMRequirementEN.UpdUser = objRow[conCMRequirement.UpdUser] == DBNull.Value ? null : objRow[conCMRequirement.UpdUser].ToString().Trim(); //修改者
objCMRequirementEN.UpdDate = objRow[conCMRequirement.UpdDate] == DBNull.Value ? null : objRow[conCMRequirement.UpdDate].ToString().Trim(); //修改日期
objCMRequirementEN.Memo = objRow[conCMRequirement.Memo] == DBNull.Value ? null : objRow[conCMRequirement.Memo].ToString().Trim(); //说明
objCMRequirementEN.IsSynchToServer = TransNullToBool(objRow[conCMRequirement.IsSynchToServer].ToString().Trim()); //是否同步到Server
objCMRequirementEN.SynchToServerDate = objRow[conCMRequirement.SynchToServerDate] == DBNull.Value ? null : objRow[conCMRequirement.SynchToServerDate].ToString().Trim(); //同步到Server日期
objCMRequirementEN.SynchToServerUser = objRow[conCMRequirement.SynchToServerUser] == DBNull.Value ? null : objRow[conCMRequirement.SynchToServerUser].ToString().Trim(); //同步到Server用户
objCMRequirementEN.IsSynchToClient = TransNullToBool(objRow[conCMRequirement.IsSynchToClient].ToString().Trim()); //是否同步到Client
objCMRequirementEN.SynchToClientDate = objRow[conCMRequirement.SynchToClientDate] == DBNull.Value ? null : objRow[conCMRequirement.SynchToClientDate].ToString().Trim(); //同步到Client库日期
objCMRequirementEN.SynchToClientUser = objRow[conCMRequirement.SynchToClientUser] == DBNull.Value ? null : objRow[conCMRequirement.SynchToClientUser].ToString().Trim(); //同步到Client库用户
objCMRequirementEN.SynSource = objRow[conCMRequirement.SynSource] == DBNull.Value ? null : objRow[conCMRequirement.SynSource].ToString().Trim(); //同步来源
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCMRequirementDA: GetObjLst)", objException.Message));
}
objCMRequirementEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCMRequirementEN);
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
public List<clsCMRequirementEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsCMRequirementDA:GetObjLstByTabName)", objException.Message));
}
List<clsCMRequirementEN> arrObjLst = new List<clsCMRequirementEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMRequirementDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMRequirementEN objCMRequirementEN = new clsCMRequirementEN();
try
{
objCMRequirementEN.ReqId = objRow[conCMRequirement.ReqId].ToString().Trim(); //需求Id
objCMRequirementEN.RequirementName = objRow[conCMRequirement.RequirementName].ToString().Trim(); //需求名称
objCMRequirementEN.RequirementTypeId = objRow[conCMRequirement.RequirementTypeId].ToString().Trim(); //需求类型Id
objCMRequirementEN.ReqContent = objRow[conCMRequirement.ReqContent].ToString().Trim(); //需求内容
objCMRequirementEN.UpReqId = objRow[conCMRequirement.UpReqId] == DBNull.Value ? null : objRow[conCMRequirement.UpReqId].ToString().Trim(); //上级需求Id
objCMRequirementEN.IsFinished = TransNullToBool(objRow[conCMRequirement.IsFinished].ToString().Trim()); //是否完成
objCMRequirementEN.CmPrjId = objRow[conCMRequirement.CmPrjId].ToString().Trim(); //Cm工程Id
objCMRequirementEN.FuncModuleAgcId = objRow[conCMRequirement.FuncModuleAgcId] == DBNull.Value ? null : objRow[conCMRequirement.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objCMRequirementEN.PrjId = objRow[conCMRequirement.PrjId].ToString().Trim(); //工程Id
objCMRequirementEN.UpdUser = objRow[conCMRequirement.UpdUser] == DBNull.Value ? null : objRow[conCMRequirement.UpdUser].ToString().Trim(); //修改者
objCMRequirementEN.UpdDate = objRow[conCMRequirement.UpdDate] == DBNull.Value ? null : objRow[conCMRequirement.UpdDate].ToString().Trim(); //修改日期
objCMRequirementEN.Memo = objRow[conCMRequirement.Memo] == DBNull.Value ? null : objRow[conCMRequirement.Memo].ToString().Trim(); //说明
objCMRequirementEN.IsSynchToServer = TransNullToBool(objRow[conCMRequirement.IsSynchToServer].ToString().Trim()); //是否同步到Server
objCMRequirementEN.SynchToServerDate = objRow[conCMRequirement.SynchToServerDate] == DBNull.Value ? null : objRow[conCMRequirement.SynchToServerDate].ToString().Trim(); //同步到Server日期
objCMRequirementEN.SynchToServerUser = objRow[conCMRequirement.SynchToServerUser] == DBNull.Value ? null : objRow[conCMRequirement.SynchToServerUser].ToString().Trim(); //同步到Server用户
objCMRequirementEN.IsSynchToClient = TransNullToBool(objRow[conCMRequirement.IsSynchToClient].ToString().Trim()); //是否同步到Client
objCMRequirementEN.SynchToClientDate = objRow[conCMRequirement.SynchToClientDate] == DBNull.Value ? null : objRow[conCMRequirement.SynchToClientDate].ToString().Trim(); //同步到Client库日期
objCMRequirementEN.SynchToClientUser = objRow[conCMRequirement.SynchToClientUser] == DBNull.Value ? null : objRow[conCMRequirement.SynchToClientUser].ToString().Trim(); //同步到Client库用户
objCMRequirementEN.SynSource = objRow[conCMRequirement.SynSource] == DBNull.Value ? null : objRow[conCMRequirement.SynSource].ToString().Trim(); //同步来源
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCMRequirementDA: GetObjLst)", objException.Message));
}
objCMRequirementEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCMRequirementEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objCMRequirementEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetCMRequirement(ref clsCMRequirementEN objCMRequirementEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMRequirementDA.GetSpecSQLObj();
strSQL = "Select * from CMRequirement where ReqId = " + "'"+ objCMRequirementEN.ReqId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objCMRequirementEN.ReqId = objDT.Rows[0][conCMRequirement.ReqId].ToString().Trim(); //需求Id(字段类型:char,字段长度:8,是否可空:False)
 objCMRequirementEN.RequirementName = objDT.Rows[0][conCMRequirement.RequirementName].ToString().Trim(); //需求名称(字段类型:varchar,字段长度:50,是否可空:False)
 objCMRequirementEN.RequirementTypeId = objDT.Rows[0][conCMRequirement.RequirementTypeId].ToString().Trim(); //需求类型Id(字段类型:char,字段长度:4,是否可空:False)
 objCMRequirementEN.ReqContent = objDT.Rows[0][conCMRequirement.ReqContent].ToString().Trim(); //需求内容(字段类型:varchar,字段长度:4000,是否可空:False)
 objCMRequirementEN.UpReqId = objDT.Rows[0][conCMRequirement.UpReqId].ToString().Trim(); //上级需求Id(字段类型:char,字段长度:8,是否可空:False)
 objCMRequirementEN.IsFinished = TransNullToBool(objDT.Rows[0][conCMRequirement.IsFinished].ToString().Trim()); //是否完成(字段类型:bit,字段长度:1,是否可空:True)
 objCMRequirementEN.CmPrjId = objDT.Rows[0][conCMRequirement.CmPrjId].ToString().Trim(); //Cm工程Id(字段类型:char,字段长度:6,是否可空:False)
 objCMRequirementEN.FuncModuleAgcId = objDT.Rows[0][conCMRequirement.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objCMRequirementEN.PrjId = objDT.Rows[0][conCMRequirement.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objCMRequirementEN.UpdUser = objDT.Rows[0][conCMRequirement.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objCMRequirementEN.UpdDate = objDT.Rows[0][conCMRequirement.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCMRequirementEN.Memo = objDT.Rows[0][conCMRequirement.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objCMRequirementEN.IsSynchToServer = TransNullToBool(objDT.Rows[0][conCMRequirement.IsSynchToServer].ToString().Trim()); //是否同步到Server(字段类型:bit,字段长度:1,是否可空:True)
 objCMRequirementEN.SynchToServerDate = objDT.Rows[0][conCMRequirement.SynchToServerDate].ToString().Trim(); //同步到Server日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCMRequirementEN.SynchToServerUser = objDT.Rows[0][conCMRequirement.SynchToServerUser].ToString().Trim(); //同步到Server用户(字段类型:varchar,字段长度:20,是否可空:True)
 objCMRequirementEN.IsSynchToClient = TransNullToBool(objDT.Rows[0][conCMRequirement.IsSynchToClient].ToString().Trim()); //是否同步到Client(字段类型:bit,字段长度:1,是否可空:True)
 objCMRequirementEN.SynchToClientDate = objDT.Rows[0][conCMRequirement.SynchToClientDate].ToString().Trim(); //同步到Client库日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCMRequirementEN.SynchToClientUser = objDT.Rows[0][conCMRequirement.SynchToClientUser].ToString().Trim(); //同步到Client库用户(字段类型:varchar,字段长度:20,是否可空:True)
 objCMRequirementEN.SynSource = objDT.Rows[0][conCMRequirement.SynSource].ToString().Trim(); //同步来源(字段类型:varchar,字段长度:50,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsCMRequirementDA: GetCMRequirement)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strReqId">表关键字</param>
 /// <returns>表对象</returns>
public clsCMRequirementEN GetObjByReqId(string strReqId)
{
CheckPrimaryKey(strReqId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMRequirementDA.GetSpecSQLObj();
strSQL = "Select * from CMRequirement where ReqId = " + "'"+ strReqId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsCMRequirementEN objCMRequirementEN = new clsCMRequirementEN();
try
{
 objCMRequirementEN.ReqId = objRow[conCMRequirement.ReqId].ToString().Trim(); //需求Id(字段类型:char,字段长度:8,是否可空:False)
 objCMRequirementEN.RequirementName = objRow[conCMRequirement.RequirementName].ToString().Trim(); //需求名称(字段类型:varchar,字段长度:50,是否可空:False)
 objCMRequirementEN.RequirementTypeId = objRow[conCMRequirement.RequirementTypeId].ToString().Trim(); //需求类型Id(字段类型:char,字段长度:4,是否可空:False)
 objCMRequirementEN.ReqContent = objRow[conCMRequirement.ReqContent].ToString().Trim(); //需求内容(字段类型:varchar,字段长度:4000,是否可空:False)
 objCMRequirementEN.UpReqId = objRow[conCMRequirement.UpReqId] == DBNull.Value ? null : objRow[conCMRequirement.UpReqId].ToString().Trim(); //上级需求Id(字段类型:char,字段长度:8,是否可空:False)
 objCMRequirementEN.IsFinished = clsEntityBase2.TransNullToBool_S(objRow[conCMRequirement.IsFinished].ToString().Trim()); //是否完成(字段类型:bit,字段长度:1,是否可空:True)
 objCMRequirementEN.CmPrjId = objRow[conCMRequirement.CmPrjId].ToString().Trim(); //Cm工程Id(字段类型:char,字段长度:6,是否可空:False)
 objCMRequirementEN.FuncModuleAgcId = objRow[conCMRequirement.FuncModuleAgcId] == DBNull.Value ? null : objRow[conCMRequirement.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objCMRequirementEN.PrjId = objRow[conCMRequirement.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objCMRequirementEN.UpdUser = objRow[conCMRequirement.UpdUser] == DBNull.Value ? null : objRow[conCMRequirement.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objCMRequirementEN.UpdDate = objRow[conCMRequirement.UpdDate] == DBNull.Value ? null : objRow[conCMRequirement.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCMRequirementEN.Memo = objRow[conCMRequirement.Memo] == DBNull.Value ? null : objRow[conCMRequirement.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objCMRequirementEN.IsSynchToServer = clsEntityBase2.TransNullToBool_S(objRow[conCMRequirement.IsSynchToServer].ToString().Trim()); //是否同步到Server(字段类型:bit,字段长度:1,是否可空:True)
 objCMRequirementEN.SynchToServerDate = objRow[conCMRequirement.SynchToServerDate] == DBNull.Value ? null : objRow[conCMRequirement.SynchToServerDate].ToString().Trim(); //同步到Server日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCMRequirementEN.SynchToServerUser = objRow[conCMRequirement.SynchToServerUser] == DBNull.Value ? null : objRow[conCMRequirement.SynchToServerUser].ToString().Trim(); //同步到Server用户(字段类型:varchar,字段长度:20,是否可空:True)
 objCMRequirementEN.IsSynchToClient = clsEntityBase2.TransNullToBool_S(objRow[conCMRequirement.IsSynchToClient].ToString().Trim()); //是否同步到Client(字段类型:bit,字段长度:1,是否可空:True)
 objCMRequirementEN.SynchToClientDate = objRow[conCMRequirement.SynchToClientDate] == DBNull.Value ? null : objRow[conCMRequirement.SynchToClientDate].ToString().Trim(); //同步到Client库日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCMRequirementEN.SynchToClientUser = objRow[conCMRequirement.SynchToClientUser] == DBNull.Value ? null : objRow[conCMRequirement.SynchToClientUser].ToString().Trim(); //同步到Client库用户(字段类型:varchar,字段长度:20,是否可空:True)
 objCMRequirementEN.SynSource = objRow[conCMRequirement.SynSource] == DBNull.Value ? null : objRow[conCMRequirement.SynSource].ToString().Trim(); //同步来源(字段类型:varchar,字段长度:50,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsCMRequirementDA: GetObjByReqId)", objException.Message));
}
return objCMRequirementEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsCMRequirementEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsCMRequirementDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMRequirementDA.GetSpecSQLObj();
strSQL = "Select * from CMRequirement where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsCMRequirementEN objCMRequirementEN = new clsCMRequirementEN()
{
ReqId = objRow[conCMRequirement.ReqId].ToString().Trim(), //需求Id
RequirementName = objRow[conCMRequirement.RequirementName].ToString().Trim(), //需求名称
RequirementTypeId = objRow[conCMRequirement.RequirementTypeId].ToString().Trim(), //需求类型Id
ReqContent = objRow[conCMRequirement.ReqContent].ToString().Trim(), //需求内容
UpReqId = objRow[conCMRequirement.UpReqId] == DBNull.Value ? null : objRow[conCMRequirement.UpReqId].ToString().Trim(), //上级需求Id
IsFinished = TransNullToBool(objRow[conCMRequirement.IsFinished].ToString().Trim()), //是否完成
CmPrjId = objRow[conCMRequirement.CmPrjId].ToString().Trim(), //Cm工程Id
FuncModuleAgcId = objRow[conCMRequirement.FuncModuleAgcId] == DBNull.Value ? null : objRow[conCMRequirement.FuncModuleAgcId].ToString().Trim(), //功能模块Id
PrjId = objRow[conCMRequirement.PrjId].ToString().Trim(), //工程Id
UpdUser = objRow[conCMRequirement.UpdUser] == DBNull.Value ? null : objRow[conCMRequirement.UpdUser].ToString().Trim(), //修改者
UpdDate = objRow[conCMRequirement.UpdDate] == DBNull.Value ? null : objRow[conCMRequirement.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[conCMRequirement.Memo] == DBNull.Value ? null : objRow[conCMRequirement.Memo].ToString().Trim(), //说明
IsSynchToServer = TransNullToBool(objRow[conCMRequirement.IsSynchToServer].ToString().Trim()), //是否同步到Server
SynchToServerDate = objRow[conCMRequirement.SynchToServerDate] == DBNull.Value ? null : objRow[conCMRequirement.SynchToServerDate].ToString().Trim(), //同步到Server日期
SynchToServerUser = objRow[conCMRequirement.SynchToServerUser] == DBNull.Value ? null : objRow[conCMRequirement.SynchToServerUser].ToString().Trim(), //同步到Server用户
IsSynchToClient = TransNullToBool(objRow[conCMRequirement.IsSynchToClient].ToString().Trim()), //是否同步到Client
SynchToClientDate = objRow[conCMRequirement.SynchToClientDate] == DBNull.Value ? null : objRow[conCMRequirement.SynchToClientDate].ToString().Trim(), //同步到Client库日期
SynchToClientUser = objRow[conCMRequirement.SynchToClientUser] == DBNull.Value ? null : objRow[conCMRequirement.SynchToClientUser].ToString().Trim(), //同步到Client库用户
SynSource = objRow[conCMRequirement.SynSource] == DBNull.Value ? null : objRow[conCMRequirement.SynSource].ToString().Trim() //同步来源
};
objCMRequirementEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCMRequirementEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsCMRequirementDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsCMRequirementEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCMRequirementEN objCMRequirementEN = new clsCMRequirementEN();
try
{
objCMRequirementEN.ReqId = objRow[conCMRequirement.ReqId].ToString().Trim(); //需求Id
objCMRequirementEN.RequirementName = objRow[conCMRequirement.RequirementName].ToString().Trim(); //需求名称
objCMRequirementEN.RequirementTypeId = objRow[conCMRequirement.RequirementTypeId].ToString().Trim(); //需求类型Id
objCMRequirementEN.ReqContent = objRow[conCMRequirement.ReqContent].ToString().Trim(); //需求内容
objCMRequirementEN.UpReqId = objRow[conCMRequirement.UpReqId] == DBNull.Value ? null : objRow[conCMRequirement.UpReqId].ToString().Trim(); //上级需求Id
objCMRequirementEN.IsFinished = TransNullToBool(objRow[conCMRequirement.IsFinished].ToString().Trim()); //是否完成
objCMRequirementEN.CmPrjId = objRow[conCMRequirement.CmPrjId].ToString().Trim(); //Cm工程Id
objCMRequirementEN.FuncModuleAgcId = objRow[conCMRequirement.FuncModuleAgcId] == DBNull.Value ? null : objRow[conCMRequirement.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objCMRequirementEN.PrjId = objRow[conCMRequirement.PrjId].ToString().Trim(); //工程Id
objCMRequirementEN.UpdUser = objRow[conCMRequirement.UpdUser] == DBNull.Value ? null : objRow[conCMRequirement.UpdUser].ToString().Trim(); //修改者
objCMRequirementEN.UpdDate = objRow[conCMRequirement.UpdDate] == DBNull.Value ? null : objRow[conCMRequirement.UpdDate].ToString().Trim(); //修改日期
objCMRequirementEN.Memo = objRow[conCMRequirement.Memo] == DBNull.Value ? null : objRow[conCMRequirement.Memo].ToString().Trim(); //说明
objCMRequirementEN.IsSynchToServer = TransNullToBool(objRow[conCMRequirement.IsSynchToServer].ToString().Trim()); //是否同步到Server
objCMRequirementEN.SynchToServerDate = objRow[conCMRequirement.SynchToServerDate] == DBNull.Value ? null : objRow[conCMRequirement.SynchToServerDate].ToString().Trim(); //同步到Server日期
objCMRequirementEN.SynchToServerUser = objRow[conCMRequirement.SynchToServerUser] == DBNull.Value ? null : objRow[conCMRequirement.SynchToServerUser].ToString().Trim(); //同步到Server用户
objCMRequirementEN.IsSynchToClient = TransNullToBool(objRow[conCMRequirement.IsSynchToClient].ToString().Trim()); //是否同步到Client
objCMRequirementEN.SynchToClientDate = objRow[conCMRequirement.SynchToClientDate] == DBNull.Value ? null : objRow[conCMRequirement.SynchToClientDate].ToString().Trim(); //同步到Client库日期
objCMRequirementEN.SynchToClientUser = objRow[conCMRequirement.SynchToClientUser] == DBNull.Value ? null : objRow[conCMRequirement.SynchToClientUser].ToString().Trim(); //同步到Client库用户
objCMRequirementEN.SynSource = objRow[conCMRequirement.SynSource] == DBNull.Value ? null : objRow[conCMRequirement.SynSource].ToString().Trim(); //同步来源
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsCMRequirementDA: GetObjByDataRowCMRequirement)", objException.Message));
}
objCMRequirementEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCMRequirementEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsCMRequirementEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCMRequirementEN objCMRequirementEN = new clsCMRequirementEN();
try
{
objCMRequirementEN.ReqId = objRow[conCMRequirement.ReqId].ToString().Trim(); //需求Id
objCMRequirementEN.RequirementName = objRow[conCMRequirement.RequirementName].ToString().Trim(); //需求名称
objCMRequirementEN.RequirementTypeId = objRow[conCMRequirement.RequirementTypeId].ToString().Trim(); //需求类型Id
objCMRequirementEN.ReqContent = objRow[conCMRequirement.ReqContent].ToString().Trim(); //需求内容
objCMRequirementEN.UpReqId = objRow[conCMRequirement.UpReqId] == DBNull.Value ? null : objRow[conCMRequirement.UpReqId].ToString().Trim(); //上级需求Id
objCMRequirementEN.IsFinished = TransNullToBool(objRow[conCMRequirement.IsFinished].ToString().Trim()); //是否完成
objCMRequirementEN.CmPrjId = objRow[conCMRequirement.CmPrjId].ToString().Trim(); //Cm工程Id
objCMRequirementEN.FuncModuleAgcId = objRow[conCMRequirement.FuncModuleAgcId] == DBNull.Value ? null : objRow[conCMRequirement.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objCMRequirementEN.PrjId = objRow[conCMRequirement.PrjId].ToString().Trim(); //工程Id
objCMRequirementEN.UpdUser = objRow[conCMRequirement.UpdUser] == DBNull.Value ? null : objRow[conCMRequirement.UpdUser].ToString().Trim(); //修改者
objCMRequirementEN.UpdDate = objRow[conCMRequirement.UpdDate] == DBNull.Value ? null : objRow[conCMRequirement.UpdDate].ToString().Trim(); //修改日期
objCMRequirementEN.Memo = objRow[conCMRequirement.Memo] == DBNull.Value ? null : objRow[conCMRequirement.Memo].ToString().Trim(); //说明
objCMRequirementEN.IsSynchToServer = TransNullToBool(objRow[conCMRequirement.IsSynchToServer].ToString().Trim()); //是否同步到Server
objCMRequirementEN.SynchToServerDate = objRow[conCMRequirement.SynchToServerDate] == DBNull.Value ? null : objRow[conCMRequirement.SynchToServerDate].ToString().Trim(); //同步到Server日期
objCMRequirementEN.SynchToServerUser = objRow[conCMRequirement.SynchToServerUser] == DBNull.Value ? null : objRow[conCMRequirement.SynchToServerUser].ToString().Trim(); //同步到Server用户
objCMRequirementEN.IsSynchToClient = TransNullToBool(objRow[conCMRequirement.IsSynchToClient].ToString().Trim()); //是否同步到Client
objCMRequirementEN.SynchToClientDate = objRow[conCMRequirement.SynchToClientDate] == DBNull.Value ? null : objRow[conCMRequirement.SynchToClientDate].ToString().Trim(); //同步到Client库日期
objCMRequirementEN.SynchToClientUser = objRow[conCMRequirement.SynchToClientUser] == DBNull.Value ? null : objRow[conCMRequirement.SynchToClientUser].ToString().Trim(); //同步到Client库用户
objCMRequirementEN.SynSource = objRow[conCMRequirement.SynSource] == DBNull.Value ? null : objRow[conCMRequirement.SynSource].ToString().Trim(); //同步来源
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsCMRequirementDA: GetObjByDataRow)", objException.Message));
}
objCMRequirementEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCMRequirementEN;
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
objSQL = clsCMRequirementDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCMRequirementEN._CurrTabName, conCMRequirement.ReqId, 8, "");
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
objSQL = clsCMRequirementDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCMRequirementEN._CurrTabName, conCMRequirement.ReqId, 8, strPrefix);
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
 objSQL = clsCMRequirementDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ReqId from CMRequirement where " + strCondition;
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
 objSQL = clsCMRequirementDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ReqId from CMRequirement where " + strCondition;
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
 /// <param name = "strReqId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strReqId)
{
CheckPrimaryKey(strReqId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMRequirementDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CMRequirement", "ReqId = " + "'"+ strReqId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsCMRequirementDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMRequirementDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CMRequirement", strCondition))
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
objSQL = clsCMRequirementDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("CMRequirement");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsCMRequirementEN objCMRequirementEN)
 {
 objCMRequirementEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMRequirementEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCMRequirementEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMRequirementDA.GetSpecSQLObj();
strSQL = "Select * from CMRequirement where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CMRequirement");
objRow = objDS.Tables["CMRequirement"].NewRow();
objRow[conCMRequirement.ReqId] = objCMRequirementEN.ReqId; //需求Id
objRow[conCMRequirement.RequirementName] = objCMRequirementEN.RequirementName; //需求名称
objRow[conCMRequirement.RequirementTypeId] = objCMRequirementEN.RequirementTypeId; //需求类型Id
objRow[conCMRequirement.ReqContent] = objCMRequirementEN.ReqContent; //需求内容
 if (objCMRequirementEN.UpReqId !=  "")
 {
objRow[conCMRequirement.UpReqId] = objCMRequirementEN.UpReqId; //上级需求Id
 }
objRow[conCMRequirement.IsFinished] = objCMRequirementEN.IsFinished; //是否完成
objRow[conCMRequirement.CmPrjId] = objCMRequirementEN.CmPrjId; //Cm工程Id
 if (objCMRequirementEN.FuncModuleAgcId !=  "")
 {
objRow[conCMRequirement.FuncModuleAgcId] = objCMRequirementEN.FuncModuleAgcId; //功能模块Id
 }
objRow[conCMRequirement.PrjId] = objCMRequirementEN.PrjId; //工程Id
 if (objCMRequirementEN.UpdUser !=  "")
 {
objRow[conCMRequirement.UpdUser] = objCMRequirementEN.UpdUser; //修改者
 }
 if (objCMRequirementEN.UpdDate !=  "")
 {
objRow[conCMRequirement.UpdDate] = objCMRequirementEN.UpdDate; //修改日期
 }
 if (objCMRequirementEN.Memo !=  "")
 {
objRow[conCMRequirement.Memo] = objCMRequirementEN.Memo; //说明
 }
objRow[conCMRequirement.IsSynchToServer] = objCMRequirementEN.IsSynchToServer; //是否同步到Server
 if (objCMRequirementEN.SynchToServerDate !=  "")
 {
objRow[conCMRequirement.SynchToServerDate] = objCMRequirementEN.SynchToServerDate; //同步到Server日期
 }
 if (objCMRequirementEN.SynchToServerUser !=  "")
 {
objRow[conCMRequirement.SynchToServerUser] = objCMRequirementEN.SynchToServerUser; //同步到Server用户
 }
objRow[conCMRequirement.IsSynchToClient] = objCMRequirementEN.IsSynchToClient; //是否同步到Client
 if (objCMRequirementEN.SynchToClientDate !=  "")
 {
objRow[conCMRequirement.SynchToClientDate] = objCMRequirementEN.SynchToClientDate; //同步到Client库日期
 }
 if (objCMRequirementEN.SynchToClientUser !=  "")
 {
objRow[conCMRequirement.SynchToClientUser] = objCMRequirementEN.SynchToClientUser; //同步到Client库用户
 }
 if (objCMRequirementEN.SynSource !=  "")
 {
objRow[conCMRequirement.SynSource] = objCMRequirementEN.SynSource; //同步来源
 }
objDS.Tables[clsCMRequirementEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsCMRequirementEN._CurrTabName);
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
 /// <param name = "objCMRequirementEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCMRequirementEN objCMRequirementEN)
{
 objCMRequirementEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMRequirementEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCMRequirementEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCMRequirementEN.ReqId !=  null)
 {
 arrFieldListForInsert.Add(conCMRequirement.ReqId);
 var strReqId = objCMRequirementEN.ReqId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReqId + "'");
 }
 
 if (objCMRequirementEN.RequirementName !=  null)
 {
 arrFieldListForInsert.Add(conCMRequirement.RequirementName);
 var strRequirementName = objCMRequirementEN.RequirementName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRequirementName + "'");
 }
 
 if (objCMRequirementEN.RequirementTypeId  ==  "")
 {
 objCMRequirementEN.RequirementTypeId = null;
 }
 if (objCMRequirementEN.RequirementTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCMRequirement.RequirementTypeId);
 var strRequirementTypeId = objCMRequirementEN.RequirementTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRequirementTypeId + "'");
 }
 
 if (objCMRequirementEN.ReqContent !=  null)
 {
 arrFieldListForInsert.Add(conCMRequirement.ReqContent);
 var strReqContent = objCMRequirementEN.ReqContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReqContent + "'");
 }
 
 if (objCMRequirementEN.UpReqId  ==  "")
 {
 objCMRequirementEN.UpReqId = null;
 }
 if (objCMRequirementEN.UpReqId !=  null)
 {
 arrFieldListForInsert.Add(conCMRequirement.UpReqId);
 var strUpReqId = objCMRequirementEN.UpReqId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpReqId + "'");
 }
 
 arrFieldListForInsert.Add(conCMRequirement.IsFinished);
 arrValueListForInsert.Add("'" + (objCMRequirementEN.IsFinished  ==  false ? "0" : "1") + "'");
 
 if (objCMRequirementEN.CmPrjId !=  null)
 {
 arrFieldListForInsert.Add(conCMRequirement.CmPrjId);
 var strCmPrjId = objCMRequirementEN.CmPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmPrjId + "'");
 }
 
 if (objCMRequirementEN.FuncModuleAgcId !=  null)
 {
 arrFieldListForInsert.Add(conCMRequirement.FuncModuleAgcId);
 var strFuncModuleAgcId = objCMRequirementEN.FuncModuleAgcId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleAgcId + "'");
 }
 
 if (objCMRequirementEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conCMRequirement.PrjId);
 var strPrjId = objCMRequirementEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objCMRequirementEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCMRequirement.UpdUser);
 var strUpdUser = objCMRequirementEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objCMRequirementEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCMRequirement.UpdDate);
 var strUpdDate = objCMRequirementEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCMRequirementEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCMRequirement.Memo);
 var strMemo = objCMRequirementEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 arrFieldListForInsert.Add(conCMRequirement.IsSynchToServer);
 arrValueListForInsert.Add("'" + (objCMRequirementEN.IsSynchToServer  ==  false ? "0" : "1") + "'");
 
 if (objCMRequirementEN.SynchToServerDate !=  null)
 {
 arrFieldListForInsert.Add(conCMRequirement.SynchToServerDate);
 var strSynchToServerDate = objCMRequirementEN.SynchToServerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToServerDate + "'");
 }
 
 if (objCMRequirementEN.SynchToServerUser !=  null)
 {
 arrFieldListForInsert.Add(conCMRequirement.SynchToServerUser);
 var strSynchToServerUser = objCMRequirementEN.SynchToServerUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToServerUser + "'");
 }
 
 arrFieldListForInsert.Add(conCMRequirement.IsSynchToClient);
 arrValueListForInsert.Add("'" + (objCMRequirementEN.IsSynchToClient  ==  false ? "0" : "1") + "'");
 
 if (objCMRequirementEN.SynchToClientDate !=  null)
 {
 arrFieldListForInsert.Add(conCMRequirement.SynchToClientDate);
 var strSynchToClientDate = objCMRequirementEN.SynchToClientDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToClientDate + "'");
 }
 
 if (objCMRequirementEN.SynchToClientUser !=  null)
 {
 arrFieldListForInsert.Add(conCMRequirement.SynchToClientUser);
 var strSynchToClientUser = objCMRequirementEN.SynchToClientUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToClientUser + "'");
 }
 
 if (objCMRequirementEN.SynSource !=  null)
 {
 arrFieldListForInsert.Add(conCMRequirement.SynSource);
 var strSynSource = objCMRequirementEN.SynSource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynSource + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CMRequirement");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMRequirementDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objCMRequirementEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCMRequirementEN objCMRequirementEN)
{
 objCMRequirementEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMRequirementEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCMRequirementEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCMRequirementEN.ReqId !=  null)
 {
 arrFieldListForInsert.Add(conCMRequirement.ReqId);
 var strReqId = objCMRequirementEN.ReqId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReqId + "'");
 }
 
 if (objCMRequirementEN.RequirementName !=  null)
 {
 arrFieldListForInsert.Add(conCMRequirement.RequirementName);
 var strRequirementName = objCMRequirementEN.RequirementName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRequirementName + "'");
 }
 
 if (objCMRequirementEN.RequirementTypeId  ==  "")
 {
 objCMRequirementEN.RequirementTypeId = null;
 }
 if (objCMRequirementEN.RequirementTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCMRequirement.RequirementTypeId);
 var strRequirementTypeId = objCMRequirementEN.RequirementTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRequirementTypeId + "'");
 }
 
 if (objCMRequirementEN.ReqContent !=  null)
 {
 arrFieldListForInsert.Add(conCMRequirement.ReqContent);
 var strReqContent = objCMRequirementEN.ReqContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReqContent + "'");
 }
 
 if (objCMRequirementEN.UpReqId  ==  "")
 {
 objCMRequirementEN.UpReqId = null;
 }
 if (objCMRequirementEN.UpReqId !=  null)
 {
 arrFieldListForInsert.Add(conCMRequirement.UpReqId);
 var strUpReqId = objCMRequirementEN.UpReqId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpReqId + "'");
 }
 
 arrFieldListForInsert.Add(conCMRequirement.IsFinished);
 arrValueListForInsert.Add("'" + (objCMRequirementEN.IsFinished  ==  false ? "0" : "1") + "'");
 
 if (objCMRequirementEN.CmPrjId !=  null)
 {
 arrFieldListForInsert.Add(conCMRequirement.CmPrjId);
 var strCmPrjId = objCMRequirementEN.CmPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmPrjId + "'");
 }
 
 if (objCMRequirementEN.FuncModuleAgcId !=  null)
 {
 arrFieldListForInsert.Add(conCMRequirement.FuncModuleAgcId);
 var strFuncModuleAgcId = objCMRequirementEN.FuncModuleAgcId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleAgcId + "'");
 }
 
 if (objCMRequirementEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conCMRequirement.PrjId);
 var strPrjId = objCMRequirementEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objCMRequirementEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCMRequirement.UpdUser);
 var strUpdUser = objCMRequirementEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objCMRequirementEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCMRequirement.UpdDate);
 var strUpdDate = objCMRequirementEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCMRequirementEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCMRequirement.Memo);
 var strMemo = objCMRequirementEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 arrFieldListForInsert.Add(conCMRequirement.IsSynchToServer);
 arrValueListForInsert.Add("'" + (objCMRequirementEN.IsSynchToServer  ==  false ? "0" : "1") + "'");
 
 if (objCMRequirementEN.SynchToServerDate !=  null)
 {
 arrFieldListForInsert.Add(conCMRequirement.SynchToServerDate);
 var strSynchToServerDate = objCMRequirementEN.SynchToServerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToServerDate + "'");
 }
 
 if (objCMRequirementEN.SynchToServerUser !=  null)
 {
 arrFieldListForInsert.Add(conCMRequirement.SynchToServerUser);
 var strSynchToServerUser = objCMRequirementEN.SynchToServerUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToServerUser + "'");
 }
 
 arrFieldListForInsert.Add(conCMRequirement.IsSynchToClient);
 arrValueListForInsert.Add("'" + (objCMRequirementEN.IsSynchToClient  ==  false ? "0" : "1") + "'");
 
 if (objCMRequirementEN.SynchToClientDate !=  null)
 {
 arrFieldListForInsert.Add(conCMRequirement.SynchToClientDate);
 var strSynchToClientDate = objCMRequirementEN.SynchToClientDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToClientDate + "'");
 }
 
 if (objCMRequirementEN.SynchToClientUser !=  null)
 {
 arrFieldListForInsert.Add(conCMRequirement.SynchToClientUser);
 var strSynchToClientUser = objCMRequirementEN.SynchToClientUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToClientUser + "'");
 }
 
 if (objCMRequirementEN.SynSource !=  null)
 {
 arrFieldListForInsert.Add(conCMRequirement.SynSource);
 var strSynSource = objCMRequirementEN.SynSource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynSource + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CMRequirement");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMRequirementDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objCMRequirementEN.ReqId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objCMRequirementEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCMRequirementEN objCMRequirementEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objCMRequirementEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMRequirementEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCMRequirementEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCMRequirementEN.ReqId !=  null)
 {
 arrFieldListForInsert.Add(conCMRequirement.ReqId);
 var strReqId = objCMRequirementEN.ReqId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReqId + "'");
 }
 
 if (objCMRequirementEN.RequirementName !=  null)
 {
 arrFieldListForInsert.Add(conCMRequirement.RequirementName);
 var strRequirementName = objCMRequirementEN.RequirementName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRequirementName + "'");
 }
 
 if (objCMRequirementEN.RequirementTypeId  ==  "")
 {
 objCMRequirementEN.RequirementTypeId = null;
 }
 if (objCMRequirementEN.RequirementTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCMRequirement.RequirementTypeId);
 var strRequirementTypeId = objCMRequirementEN.RequirementTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRequirementTypeId + "'");
 }
 
 if (objCMRequirementEN.ReqContent !=  null)
 {
 arrFieldListForInsert.Add(conCMRequirement.ReqContent);
 var strReqContent = objCMRequirementEN.ReqContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReqContent + "'");
 }
 
 if (objCMRequirementEN.UpReqId  ==  "")
 {
 objCMRequirementEN.UpReqId = null;
 }
 if (objCMRequirementEN.UpReqId !=  null)
 {
 arrFieldListForInsert.Add(conCMRequirement.UpReqId);
 var strUpReqId = objCMRequirementEN.UpReqId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpReqId + "'");
 }
 
 arrFieldListForInsert.Add(conCMRequirement.IsFinished);
 arrValueListForInsert.Add("'" + (objCMRequirementEN.IsFinished  ==  false ? "0" : "1") + "'");
 
 if (objCMRequirementEN.CmPrjId !=  null)
 {
 arrFieldListForInsert.Add(conCMRequirement.CmPrjId);
 var strCmPrjId = objCMRequirementEN.CmPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmPrjId + "'");
 }
 
 if (objCMRequirementEN.FuncModuleAgcId !=  null)
 {
 arrFieldListForInsert.Add(conCMRequirement.FuncModuleAgcId);
 var strFuncModuleAgcId = objCMRequirementEN.FuncModuleAgcId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleAgcId + "'");
 }
 
 if (objCMRequirementEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conCMRequirement.PrjId);
 var strPrjId = objCMRequirementEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objCMRequirementEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCMRequirement.UpdUser);
 var strUpdUser = objCMRequirementEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objCMRequirementEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCMRequirement.UpdDate);
 var strUpdDate = objCMRequirementEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCMRequirementEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCMRequirement.Memo);
 var strMemo = objCMRequirementEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 arrFieldListForInsert.Add(conCMRequirement.IsSynchToServer);
 arrValueListForInsert.Add("'" + (objCMRequirementEN.IsSynchToServer  ==  false ? "0" : "1") + "'");
 
 if (objCMRequirementEN.SynchToServerDate !=  null)
 {
 arrFieldListForInsert.Add(conCMRequirement.SynchToServerDate);
 var strSynchToServerDate = objCMRequirementEN.SynchToServerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToServerDate + "'");
 }
 
 if (objCMRequirementEN.SynchToServerUser !=  null)
 {
 arrFieldListForInsert.Add(conCMRequirement.SynchToServerUser);
 var strSynchToServerUser = objCMRequirementEN.SynchToServerUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToServerUser + "'");
 }
 
 arrFieldListForInsert.Add(conCMRequirement.IsSynchToClient);
 arrValueListForInsert.Add("'" + (objCMRequirementEN.IsSynchToClient  ==  false ? "0" : "1") + "'");
 
 if (objCMRequirementEN.SynchToClientDate !=  null)
 {
 arrFieldListForInsert.Add(conCMRequirement.SynchToClientDate);
 var strSynchToClientDate = objCMRequirementEN.SynchToClientDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToClientDate + "'");
 }
 
 if (objCMRequirementEN.SynchToClientUser !=  null)
 {
 arrFieldListForInsert.Add(conCMRequirement.SynchToClientUser);
 var strSynchToClientUser = objCMRequirementEN.SynchToClientUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToClientUser + "'");
 }
 
 if (objCMRequirementEN.SynSource !=  null)
 {
 arrFieldListForInsert.Add(conCMRequirement.SynSource);
 var strSynSource = objCMRequirementEN.SynSource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynSource + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CMRequirement");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMRequirementDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewCMRequirements(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMRequirementDA.GetSpecSQLObj();
strSQL = "Select * from CMRequirement where ReqId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CMRequirement");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strReqId = oRow[conCMRequirement.ReqId].ToString().Trim();
if (IsExist(strReqId))
{
 string strResult = "关键字变量值为:" + string.Format("ReqId = {0}", strReqId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsCMRequirementEN._CurrTabName ].NewRow();
objRow[conCMRequirement.ReqId] = oRow[conCMRequirement.ReqId].ToString().Trim(); //需求Id
objRow[conCMRequirement.RequirementName] = oRow[conCMRequirement.RequirementName].ToString().Trim(); //需求名称
objRow[conCMRequirement.RequirementTypeId] = oRow[conCMRequirement.RequirementTypeId].ToString().Trim(); //需求类型Id
objRow[conCMRequirement.ReqContent] = oRow[conCMRequirement.ReqContent].ToString().Trim(); //需求内容
objRow[conCMRequirement.UpReqId] = oRow[conCMRequirement.UpReqId].ToString().Trim(); //上级需求Id
objRow[conCMRequirement.IsFinished] = oRow[conCMRequirement.IsFinished].ToString().Trim(); //是否完成
objRow[conCMRequirement.CmPrjId] = oRow[conCMRequirement.CmPrjId].ToString().Trim(); //Cm工程Id
objRow[conCMRequirement.FuncModuleAgcId] = oRow[conCMRequirement.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objRow[conCMRequirement.PrjId] = oRow[conCMRequirement.PrjId].ToString().Trim(); //工程Id
objRow[conCMRequirement.UpdUser] = oRow[conCMRequirement.UpdUser].ToString().Trim(); //修改者
objRow[conCMRequirement.UpdDate] = oRow[conCMRequirement.UpdDate].ToString().Trim(); //修改日期
objRow[conCMRequirement.Memo] = oRow[conCMRequirement.Memo].ToString().Trim(); //说明
objRow[conCMRequirement.IsSynchToServer] = oRow[conCMRequirement.IsSynchToServer].ToString().Trim(); //是否同步到Server
objRow[conCMRequirement.SynchToServerDate] = oRow[conCMRequirement.SynchToServerDate].ToString().Trim(); //同步到Server日期
objRow[conCMRequirement.SynchToServerUser] = oRow[conCMRequirement.SynchToServerUser].ToString().Trim(); //同步到Server用户
objRow[conCMRequirement.IsSynchToClient] = oRow[conCMRequirement.IsSynchToClient].ToString().Trim(); //是否同步到Client
objRow[conCMRequirement.SynchToClientDate] = oRow[conCMRequirement.SynchToClientDate].ToString().Trim(); //同步到Client库日期
objRow[conCMRequirement.SynchToClientUser] = oRow[conCMRequirement.SynchToClientUser].ToString().Trim(); //同步到Client库用户
objRow[conCMRequirement.SynSource] = oRow[conCMRequirement.SynSource].ToString().Trim(); //同步来源
 objDS.Tables[clsCMRequirementEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsCMRequirementEN._CurrTabName);
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
 /// <param name = "objCMRequirementEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsCMRequirementEN objCMRequirementEN)
{
 objCMRequirementEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMRequirementEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCMRequirementEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMRequirementDA.GetSpecSQLObj();
strSQL = "Select * from CMRequirement where ReqId = " + "'"+ objCMRequirementEN.ReqId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsCMRequirementEN._CurrTabName);
if (objDS.Tables[clsCMRequirementEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:ReqId = " + "'"+ objCMRequirementEN.ReqId+"'");
return false;
}
objRow = objDS.Tables[clsCMRequirementEN._CurrTabName].Rows[0];
 if (objCMRequirementEN.IsUpdated(conCMRequirement.ReqId))
 {
objRow[conCMRequirement.ReqId] = objCMRequirementEN.ReqId; //需求Id
 }
 if (objCMRequirementEN.IsUpdated(conCMRequirement.RequirementName))
 {
objRow[conCMRequirement.RequirementName] = objCMRequirementEN.RequirementName; //需求名称
 }
 if (objCMRequirementEN.IsUpdated(conCMRequirement.RequirementTypeId))
 {
objRow[conCMRequirement.RequirementTypeId] = objCMRequirementEN.RequirementTypeId; //需求类型Id
 }
 if (objCMRequirementEN.IsUpdated(conCMRequirement.ReqContent))
 {
objRow[conCMRequirement.ReqContent] = objCMRequirementEN.ReqContent; //需求内容
 }
 if (objCMRequirementEN.IsUpdated(conCMRequirement.UpReqId))
 {
objRow[conCMRequirement.UpReqId] = objCMRequirementEN.UpReqId; //上级需求Id
 }
 if (objCMRequirementEN.IsUpdated(conCMRequirement.IsFinished))
 {
objRow[conCMRequirement.IsFinished] = objCMRequirementEN.IsFinished; //是否完成
 }
 if (objCMRequirementEN.IsUpdated(conCMRequirement.CmPrjId))
 {
objRow[conCMRequirement.CmPrjId] = objCMRequirementEN.CmPrjId; //Cm工程Id
 }
 if (objCMRequirementEN.IsUpdated(conCMRequirement.FuncModuleAgcId))
 {
objRow[conCMRequirement.FuncModuleAgcId] = objCMRequirementEN.FuncModuleAgcId; //功能模块Id
 }
 if (objCMRequirementEN.IsUpdated(conCMRequirement.PrjId))
 {
objRow[conCMRequirement.PrjId] = objCMRequirementEN.PrjId; //工程Id
 }
 if (objCMRequirementEN.IsUpdated(conCMRequirement.UpdUser))
 {
objRow[conCMRequirement.UpdUser] = objCMRequirementEN.UpdUser; //修改者
 }
 if (objCMRequirementEN.IsUpdated(conCMRequirement.UpdDate))
 {
objRow[conCMRequirement.UpdDate] = objCMRequirementEN.UpdDate; //修改日期
 }
 if (objCMRequirementEN.IsUpdated(conCMRequirement.Memo))
 {
objRow[conCMRequirement.Memo] = objCMRequirementEN.Memo; //说明
 }
 if (objCMRequirementEN.IsUpdated(conCMRequirement.IsSynchToServer))
 {
objRow[conCMRequirement.IsSynchToServer] = objCMRequirementEN.IsSynchToServer; //是否同步到Server
 }
 if (objCMRequirementEN.IsUpdated(conCMRequirement.SynchToServerDate))
 {
objRow[conCMRequirement.SynchToServerDate] = objCMRequirementEN.SynchToServerDate; //同步到Server日期
 }
 if (objCMRequirementEN.IsUpdated(conCMRequirement.SynchToServerUser))
 {
objRow[conCMRequirement.SynchToServerUser] = objCMRequirementEN.SynchToServerUser; //同步到Server用户
 }
 if (objCMRequirementEN.IsUpdated(conCMRequirement.IsSynchToClient))
 {
objRow[conCMRequirement.IsSynchToClient] = objCMRequirementEN.IsSynchToClient; //是否同步到Client
 }
 if (objCMRequirementEN.IsUpdated(conCMRequirement.SynchToClientDate))
 {
objRow[conCMRequirement.SynchToClientDate] = objCMRequirementEN.SynchToClientDate; //同步到Client库日期
 }
 if (objCMRequirementEN.IsUpdated(conCMRequirement.SynchToClientUser))
 {
objRow[conCMRequirement.SynchToClientUser] = objCMRequirementEN.SynchToClientUser; //同步到Client库用户
 }
 if (objCMRequirementEN.IsUpdated(conCMRequirement.SynSource))
 {
objRow[conCMRequirement.SynSource] = objCMRequirementEN.SynSource; //同步来源
 }
try
{
objDA.Update(objDS, clsCMRequirementEN._CurrTabName);
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
 /// <param name = "objCMRequirementEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCMRequirementEN objCMRequirementEN)
{
 objCMRequirementEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMRequirementEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCMRequirementEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMRequirementDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update CMRequirement Set ");
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.RequirementName))
 {
 if (objCMRequirementEN.RequirementName !=  null)
 {
 var strRequirementName = objCMRequirementEN.RequirementName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRequirementName, conCMRequirement.RequirementName); //需求名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMRequirement.RequirementName); //需求名称
 }
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.RequirementTypeId))
 {
 if (objCMRequirementEN.RequirementTypeId  ==  "")
 {
 objCMRequirementEN.RequirementTypeId = null;
 }
 if (objCMRequirementEN.RequirementTypeId !=  null)
 {
 var strRequirementTypeId = objCMRequirementEN.RequirementTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRequirementTypeId, conCMRequirement.RequirementTypeId); //需求类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMRequirement.RequirementTypeId); //需求类型Id
 }
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.ReqContent))
 {
 if (objCMRequirementEN.ReqContent !=  null)
 {
 var strReqContent = objCMRequirementEN.ReqContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReqContent, conCMRequirement.ReqContent); //需求内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMRequirement.ReqContent); //需求内容
 }
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.UpReqId))
 {
 if (objCMRequirementEN.UpReqId  ==  "")
 {
 objCMRequirementEN.UpReqId = null;
 }
 if (objCMRequirementEN.UpReqId !=  null)
 {
 var strUpReqId = objCMRequirementEN.UpReqId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpReqId, conCMRequirement.UpReqId); //上级需求Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMRequirement.UpReqId); //上级需求Id
 }
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.IsFinished))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCMRequirementEN.IsFinished == true?"1":"0", conCMRequirement.IsFinished); //是否完成
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.CmPrjId))
 {
 if (objCMRequirementEN.CmPrjId !=  null)
 {
 var strCmPrjId = objCMRequirementEN.CmPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCmPrjId, conCMRequirement.CmPrjId); //Cm工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMRequirement.CmPrjId); //Cm工程Id
 }
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.FuncModuleAgcId))
 {
 if (objCMRequirementEN.FuncModuleAgcId !=  null)
 {
 var strFuncModuleAgcId = objCMRequirementEN.FuncModuleAgcId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleAgcId, conCMRequirement.FuncModuleAgcId); //功能模块Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMRequirement.FuncModuleAgcId); //功能模块Id
 }
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.PrjId))
 {
 if (objCMRequirementEN.PrjId !=  null)
 {
 var strPrjId = objCMRequirementEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conCMRequirement.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMRequirement.PrjId); //工程Id
 }
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.UpdUser))
 {
 if (objCMRequirementEN.UpdUser !=  null)
 {
 var strUpdUser = objCMRequirementEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conCMRequirement.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMRequirement.UpdUser); //修改者
 }
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.UpdDate))
 {
 if (objCMRequirementEN.UpdDate !=  null)
 {
 var strUpdDate = objCMRequirementEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conCMRequirement.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMRequirement.UpdDate); //修改日期
 }
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.Memo))
 {
 if (objCMRequirementEN.Memo !=  null)
 {
 var strMemo = objCMRequirementEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCMRequirement.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMRequirement.Memo); //说明
 }
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.IsSynchToServer))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCMRequirementEN.IsSynchToServer == true?"1":"0", conCMRequirement.IsSynchToServer); //是否同步到Server
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.SynchToServerDate))
 {
 if (objCMRequirementEN.SynchToServerDate !=  null)
 {
 var strSynchToServerDate = objCMRequirementEN.SynchToServerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSynchToServerDate, conCMRequirement.SynchToServerDate); //同步到Server日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMRequirement.SynchToServerDate); //同步到Server日期
 }
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.SynchToServerUser))
 {
 if (objCMRequirementEN.SynchToServerUser !=  null)
 {
 var strSynchToServerUser = objCMRequirementEN.SynchToServerUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSynchToServerUser, conCMRequirement.SynchToServerUser); //同步到Server用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMRequirement.SynchToServerUser); //同步到Server用户
 }
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.IsSynchToClient))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCMRequirementEN.IsSynchToClient == true?"1":"0", conCMRequirement.IsSynchToClient); //是否同步到Client
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.SynchToClientDate))
 {
 if (objCMRequirementEN.SynchToClientDate !=  null)
 {
 var strSynchToClientDate = objCMRequirementEN.SynchToClientDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSynchToClientDate, conCMRequirement.SynchToClientDate); //同步到Client库日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMRequirement.SynchToClientDate); //同步到Client库日期
 }
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.SynchToClientUser))
 {
 if (objCMRequirementEN.SynchToClientUser !=  null)
 {
 var strSynchToClientUser = objCMRequirementEN.SynchToClientUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSynchToClientUser, conCMRequirement.SynchToClientUser); //同步到Client库用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMRequirement.SynchToClientUser); //同步到Client库用户
 }
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.SynSource))
 {
 if (objCMRequirementEN.SynSource !=  null)
 {
 var strSynSource = objCMRequirementEN.SynSource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSynSource, conCMRequirement.SynSource); //同步来源
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMRequirement.SynSource); //同步来源
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ReqId = '{0}'", objCMRequirementEN.ReqId); 
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
 /// <param name = "objCMRequirementEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsCMRequirementEN objCMRequirementEN, string strCondition)
{
 objCMRequirementEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMRequirementEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCMRequirementEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMRequirementDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CMRequirement Set ");
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.RequirementName))
 {
 if (objCMRequirementEN.RequirementName !=  null)
 {
 var strRequirementName = objCMRequirementEN.RequirementName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RequirementName = '{0}',", strRequirementName); //需求名称
 }
 else
 {
 sbSQL.Append(" RequirementName = null,"); //需求名称
 }
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.RequirementTypeId))
 {
 if (objCMRequirementEN.RequirementTypeId  ==  "")
 {
 objCMRequirementEN.RequirementTypeId = null;
 }
 if (objCMRequirementEN.RequirementTypeId !=  null)
 {
 var strRequirementTypeId = objCMRequirementEN.RequirementTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RequirementTypeId = '{0}',", strRequirementTypeId); //需求类型Id
 }
 else
 {
 sbSQL.Append(" RequirementTypeId = null,"); //需求类型Id
 }
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.ReqContent))
 {
 if (objCMRequirementEN.ReqContent !=  null)
 {
 var strReqContent = objCMRequirementEN.ReqContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReqContent = '{0}',", strReqContent); //需求内容
 }
 else
 {
 sbSQL.Append(" ReqContent = null,"); //需求内容
 }
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.UpReqId))
 {
 if (objCMRequirementEN.UpReqId  ==  "")
 {
 objCMRequirementEN.UpReqId = null;
 }
 if (objCMRequirementEN.UpReqId !=  null)
 {
 var strUpReqId = objCMRequirementEN.UpReqId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpReqId = '{0}',", strUpReqId); //上级需求Id
 }
 else
 {
 sbSQL.Append(" UpReqId = null,"); //上级需求Id
 }
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.IsFinished))
 {
 sbSQL.AppendFormat(" IsFinished = '{0}',", objCMRequirementEN.IsFinished == true?"1":"0"); //是否完成
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.CmPrjId))
 {
 if (objCMRequirementEN.CmPrjId !=  null)
 {
 var strCmPrjId = objCMRequirementEN.CmPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CmPrjId = '{0}',", strCmPrjId); //Cm工程Id
 }
 else
 {
 sbSQL.Append(" CmPrjId = null,"); //Cm工程Id
 }
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.FuncModuleAgcId))
 {
 if (objCMRequirementEN.FuncModuleAgcId !=  null)
 {
 var strFuncModuleAgcId = objCMRequirementEN.FuncModuleAgcId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleAgcId = '{0}',", strFuncModuleAgcId); //功能模块Id
 }
 else
 {
 sbSQL.Append(" FuncModuleAgcId = null,"); //功能模块Id
 }
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.PrjId))
 {
 if (objCMRequirementEN.PrjId !=  null)
 {
 var strPrjId = objCMRequirementEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.UpdUser))
 {
 if (objCMRequirementEN.UpdUser !=  null)
 {
 var strUpdUser = objCMRequirementEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.UpdDate))
 {
 if (objCMRequirementEN.UpdDate !=  null)
 {
 var strUpdDate = objCMRequirementEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.Memo))
 {
 if (objCMRequirementEN.Memo !=  null)
 {
 var strMemo = objCMRequirementEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //说明
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //说明
 }
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.IsSynchToServer))
 {
 sbSQL.AppendFormat(" IsSynchToServer = '{0}',", objCMRequirementEN.IsSynchToServer == true?"1":"0"); //是否同步到Server
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.SynchToServerDate))
 {
 if (objCMRequirementEN.SynchToServerDate !=  null)
 {
 var strSynchToServerDate = objCMRequirementEN.SynchToServerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynchToServerDate = '{0}',", strSynchToServerDate); //同步到Server日期
 }
 else
 {
 sbSQL.Append(" SynchToServerDate = null,"); //同步到Server日期
 }
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.SynchToServerUser))
 {
 if (objCMRequirementEN.SynchToServerUser !=  null)
 {
 var strSynchToServerUser = objCMRequirementEN.SynchToServerUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynchToServerUser = '{0}',", strSynchToServerUser); //同步到Server用户
 }
 else
 {
 sbSQL.Append(" SynchToServerUser = null,"); //同步到Server用户
 }
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.IsSynchToClient))
 {
 sbSQL.AppendFormat(" IsSynchToClient = '{0}',", objCMRequirementEN.IsSynchToClient == true?"1":"0"); //是否同步到Client
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.SynchToClientDate))
 {
 if (objCMRequirementEN.SynchToClientDate !=  null)
 {
 var strSynchToClientDate = objCMRequirementEN.SynchToClientDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynchToClientDate = '{0}',", strSynchToClientDate); //同步到Client库日期
 }
 else
 {
 sbSQL.Append(" SynchToClientDate = null,"); //同步到Client库日期
 }
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.SynchToClientUser))
 {
 if (objCMRequirementEN.SynchToClientUser !=  null)
 {
 var strSynchToClientUser = objCMRequirementEN.SynchToClientUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynchToClientUser = '{0}',", strSynchToClientUser); //同步到Client库用户
 }
 else
 {
 sbSQL.Append(" SynchToClientUser = null,"); //同步到Client库用户
 }
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.SynSource))
 {
 if (objCMRequirementEN.SynSource !=  null)
 {
 var strSynSource = objCMRequirementEN.SynSource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynSource = '{0}',", strSynSource); //同步来源
 }
 else
 {
 sbSQL.Append(" SynSource = null,"); //同步来源
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
 /// <param name = "objCMRequirementEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsCMRequirementEN objCMRequirementEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objCMRequirementEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMRequirementEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCMRequirementEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMRequirementDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CMRequirement Set ");
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.RequirementName))
 {
 if (objCMRequirementEN.RequirementName !=  null)
 {
 var strRequirementName = objCMRequirementEN.RequirementName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RequirementName = '{0}',", strRequirementName); //需求名称
 }
 else
 {
 sbSQL.Append(" RequirementName = null,"); //需求名称
 }
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.RequirementTypeId))
 {
 if (objCMRequirementEN.RequirementTypeId  ==  "")
 {
 objCMRequirementEN.RequirementTypeId = null;
 }
 if (objCMRequirementEN.RequirementTypeId !=  null)
 {
 var strRequirementTypeId = objCMRequirementEN.RequirementTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RequirementTypeId = '{0}',", strRequirementTypeId); //需求类型Id
 }
 else
 {
 sbSQL.Append(" RequirementTypeId = null,"); //需求类型Id
 }
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.ReqContent))
 {
 if (objCMRequirementEN.ReqContent !=  null)
 {
 var strReqContent = objCMRequirementEN.ReqContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReqContent = '{0}',", strReqContent); //需求内容
 }
 else
 {
 sbSQL.Append(" ReqContent = null,"); //需求内容
 }
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.UpReqId))
 {
 if (objCMRequirementEN.UpReqId  ==  "")
 {
 objCMRequirementEN.UpReqId = null;
 }
 if (objCMRequirementEN.UpReqId !=  null)
 {
 var strUpReqId = objCMRequirementEN.UpReqId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpReqId = '{0}',", strUpReqId); //上级需求Id
 }
 else
 {
 sbSQL.Append(" UpReqId = null,"); //上级需求Id
 }
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.IsFinished))
 {
 sbSQL.AppendFormat(" IsFinished = '{0}',", objCMRequirementEN.IsFinished == true?"1":"0"); //是否完成
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.CmPrjId))
 {
 if (objCMRequirementEN.CmPrjId !=  null)
 {
 var strCmPrjId = objCMRequirementEN.CmPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CmPrjId = '{0}',", strCmPrjId); //Cm工程Id
 }
 else
 {
 sbSQL.Append(" CmPrjId = null,"); //Cm工程Id
 }
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.FuncModuleAgcId))
 {
 if (objCMRequirementEN.FuncModuleAgcId !=  null)
 {
 var strFuncModuleAgcId = objCMRequirementEN.FuncModuleAgcId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleAgcId = '{0}',", strFuncModuleAgcId); //功能模块Id
 }
 else
 {
 sbSQL.Append(" FuncModuleAgcId = null,"); //功能模块Id
 }
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.PrjId))
 {
 if (objCMRequirementEN.PrjId !=  null)
 {
 var strPrjId = objCMRequirementEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.UpdUser))
 {
 if (objCMRequirementEN.UpdUser !=  null)
 {
 var strUpdUser = objCMRequirementEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.UpdDate))
 {
 if (objCMRequirementEN.UpdDate !=  null)
 {
 var strUpdDate = objCMRequirementEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.Memo))
 {
 if (objCMRequirementEN.Memo !=  null)
 {
 var strMemo = objCMRequirementEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //说明
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //说明
 }
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.IsSynchToServer))
 {
 sbSQL.AppendFormat(" IsSynchToServer = '{0}',", objCMRequirementEN.IsSynchToServer == true?"1":"0"); //是否同步到Server
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.SynchToServerDate))
 {
 if (objCMRequirementEN.SynchToServerDate !=  null)
 {
 var strSynchToServerDate = objCMRequirementEN.SynchToServerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynchToServerDate = '{0}',", strSynchToServerDate); //同步到Server日期
 }
 else
 {
 sbSQL.Append(" SynchToServerDate = null,"); //同步到Server日期
 }
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.SynchToServerUser))
 {
 if (objCMRequirementEN.SynchToServerUser !=  null)
 {
 var strSynchToServerUser = objCMRequirementEN.SynchToServerUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynchToServerUser = '{0}',", strSynchToServerUser); //同步到Server用户
 }
 else
 {
 sbSQL.Append(" SynchToServerUser = null,"); //同步到Server用户
 }
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.IsSynchToClient))
 {
 sbSQL.AppendFormat(" IsSynchToClient = '{0}',", objCMRequirementEN.IsSynchToClient == true?"1":"0"); //是否同步到Client
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.SynchToClientDate))
 {
 if (objCMRequirementEN.SynchToClientDate !=  null)
 {
 var strSynchToClientDate = objCMRequirementEN.SynchToClientDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynchToClientDate = '{0}',", strSynchToClientDate); //同步到Client库日期
 }
 else
 {
 sbSQL.Append(" SynchToClientDate = null,"); //同步到Client库日期
 }
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.SynchToClientUser))
 {
 if (objCMRequirementEN.SynchToClientUser !=  null)
 {
 var strSynchToClientUser = objCMRequirementEN.SynchToClientUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynchToClientUser = '{0}',", strSynchToClientUser); //同步到Client库用户
 }
 else
 {
 sbSQL.Append(" SynchToClientUser = null,"); //同步到Client库用户
 }
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.SynSource))
 {
 if (objCMRequirementEN.SynSource !=  null)
 {
 var strSynSource = objCMRequirementEN.SynSource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynSource = '{0}',", strSynSource); //同步来源
 }
 else
 {
 sbSQL.Append(" SynSource = null,"); //同步来源
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
 /// <param name = "objCMRequirementEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCMRequirementEN objCMRequirementEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objCMRequirementEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMRequirementEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCMRequirementEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMRequirementDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CMRequirement Set ");
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.RequirementName))
 {
 if (objCMRequirementEN.RequirementName !=  null)
 {
 var strRequirementName = objCMRequirementEN.RequirementName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRequirementName, conCMRequirement.RequirementName); //需求名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMRequirement.RequirementName); //需求名称
 }
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.RequirementTypeId))
 {
 if (objCMRequirementEN.RequirementTypeId  ==  "")
 {
 objCMRequirementEN.RequirementTypeId = null;
 }
 if (objCMRequirementEN.RequirementTypeId !=  null)
 {
 var strRequirementTypeId = objCMRequirementEN.RequirementTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRequirementTypeId, conCMRequirement.RequirementTypeId); //需求类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMRequirement.RequirementTypeId); //需求类型Id
 }
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.ReqContent))
 {
 if (objCMRequirementEN.ReqContent !=  null)
 {
 var strReqContent = objCMRequirementEN.ReqContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReqContent, conCMRequirement.ReqContent); //需求内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMRequirement.ReqContent); //需求内容
 }
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.UpReqId))
 {
 if (objCMRequirementEN.UpReqId  ==  "")
 {
 objCMRequirementEN.UpReqId = null;
 }
 if (objCMRequirementEN.UpReqId !=  null)
 {
 var strUpReqId = objCMRequirementEN.UpReqId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpReqId, conCMRequirement.UpReqId); //上级需求Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMRequirement.UpReqId); //上级需求Id
 }
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.IsFinished))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCMRequirementEN.IsFinished == true?"1":"0", conCMRequirement.IsFinished); //是否完成
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.CmPrjId))
 {
 if (objCMRequirementEN.CmPrjId !=  null)
 {
 var strCmPrjId = objCMRequirementEN.CmPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCmPrjId, conCMRequirement.CmPrjId); //Cm工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMRequirement.CmPrjId); //Cm工程Id
 }
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.FuncModuleAgcId))
 {
 if (objCMRequirementEN.FuncModuleAgcId !=  null)
 {
 var strFuncModuleAgcId = objCMRequirementEN.FuncModuleAgcId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleAgcId, conCMRequirement.FuncModuleAgcId); //功能模块Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMRequirement.FuncModuleAgcId); //功能模块Id
 }
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.PrjId))
 {
 if (objCMRequirementEN.PrjId !=  null)
 {
 var strPrjId = objCMRequirementEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conCMRequirement.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMRequirement.PrjId); //工程Id
 }
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.UpdUser))
 {
 if (objCMRequirementEN.UpdUser !=  null)
 {
 var strUpdUser = objCMRequirementEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conCMRequirement.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMRequirement.UpdUser); //修改者
 }
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.UpdDate))
 {
 if (objCMRequirementEN.UpdDate !=  null)
 {
 var strUpdDate = objCMRequirementEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conCMRequirement.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMRequirement.UpdDate); //修改日期
 }
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.Memo))
 {
 if (objCMRequirementEN.Memo !=  null)
 {
 var strMemo = objCMRequirementEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCMRequirement.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMRequirement.Memo); //说明
 }
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.IsSynchToServer))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCMRequirementEN.IsSynchToServer == true?"1":"0", conCMRequirement.IsSynchToServer); //是否同步到Server
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.SynchToServerDate))
 {
 if (objCMRequirementEN.SynchToServerDate !=  null)
 {
 var strSynchToServerDate = objCMRequirementEN.SynchToServerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSynchToServerDate, conCMRequirement.SynchToServerDate); //同步到Server日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMRequirement.SynchToServerDate); //同步到Server日期
 }
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.SynchToServerUser))
 {
 if (objCMRequirementEN.SynchToServerUser !=  null)
 {
 var strSynchToServerUser = objCMRequirementEN.SynchToServerUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSynchToServerUser, conCMRequirement.SynchToServerUser); //同步到Server用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMRequirement.SynchToServerUser); //同步到Server用户
 }
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.IsSynchToClient))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCMRequirementEN.IsSynchToClient == true?"1":"0", conCMRequirement.IsSynchToClient); //是否同步到Client
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.SynchToClientDate))
 {
 if (objCMRequirementEN.SynchToClientDate !=  null)
 {
 var strSynchToClientDate = objCMRequirementEN.SynchToClientDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSynchToClientDate, conCMRequirement.SynchToClientDate); //同步到Client库日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMRequirement.SynchToClientDate); //同步到Client库日期
 }
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.SynchToClientUser))
 {
 if (objCMRequirementEN.SynchToClientUser !=  null)
 {
 var strSynchToClientUser = objCMRequirementEN.SynchToClientUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSynchToClientUser, conCMRequirement.SynchToClientUser); //同步到Client库用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMRequirement.SynchToClientUser); //同步到Client库用户
 }
 }
 
 if (objCMRequirementEN.IsUpdated(conCMRequirement.SynSource))
 {
 if (objCMRequirementEN.SynSource !=  null)
 {
 var strSynSource = objCMRequirementEN.SynSource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSynSource, conCMRequirement.SynSource); //同步来源
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMRequirement.SynSource); //同步来源
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ReqId = '{0}'", objCMRequirementEN.ReqId); 
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
 /// <param name = "strReqId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strReqId) 
{
CheckPrimaryKey(strReqId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMRequirementDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strReqId,
};
 objSQL.ExecSP("CMRequirement_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strReqId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strReqId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strReqId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMRequirementDA.GetSpecSQLObj();
//删除CMRequirement本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CMRequirement where ReqId = " + "'"+ strReqId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelCMRequirement(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMRequirementDA.GetSpecSQLObj();
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
//删除CMRequirement本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CMRequirement where ReqId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strReqId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strReqId) 
{
CheckPrimaryKey(strReqId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMRequirementDA.GetSpecSQLObj();
//删除CMRequirement本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CMRequirement where ReqId = " + "'"+ strReqId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelCMRequirement(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsCMRequirementDA: DelCMRequirement)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMRequirementDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CMRequirement where " + strCondition ;
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
public bool DelCMRequirementWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsCMRequirementDA: DelCMRequirementWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMRequirementDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CMRequirement where " + strCondition ;
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
 /// <param name = "objCMRequirementENS">源对象</param>
 /// <param name = "objCMRequirementENT">目标对象</param>
public void CopyTo(clsCMRequirementEN objCMRequirementENS, clsCMRequirementEN objCMRequirementENT)
{
objCMRequirementENT.ReqId = objCMRequirementENS.ReqId; //需求Id
objCMRequirementENT.RequirementName = objCMRequirementENS.RequirementName; //需求名称
objCMRequirementENT.RequirementTypeId = objCMRequirementENS.RequirementTypeId; //需求类型Id
objCMRequirementENT.ReqContent = objCMRequirementENS.ReqContent; //需求内容
objCMRequirementENT.UpReqId = objCMRequirementENS.UpReqId; //上级需求Id
objCMRequirementENT.IsFinished = objCMRequirementENS.IsFinished; //是否完成
objCMRequirementENT.CmPrjId = objCMRequirementENS.CmPrjId; //Cm工程Id
objCMRequirementENT.FuncModuleAgcId = objCMRequirementENS.FuncModuleAgcId; //功能模块Id
objCMRequirementENT.PrjId = objCMRequirementENS.PrjId; //工程Id
objCMRequirementENT.UpdUser = objCMRequirementENS.UpdUser; //修改者
objCMRequirementENT.UpdDate = objCMRequirementENS.UpdDate; //修改日期
objCMRequirementENT.Memo = objCMRequirementENS.Memo; //说明
objCMRequirementENT.IsSynchToServer = objCMRequirementENS.IsSynchToServer; //是否同步到Server
objCMRequirementENT.SynchToServerDate = objCMRequirementENS.SynchToServerDate; //同步到Server日期
objCMRequirementENT.SynchToServerUser = objCMRequirementENS.SynchToServerUser; //同步到Server用户
objCMRequirementENT.IsSynchToClient = objCMRequirementENS.IsSynchToClient; //是否同步到Client
objCMRequirementENT.SynchToClientDate = objCMRequirementENS.SynchToClientDate; //同步到Client库日期
objCMRequirementENT.SynchToClientUser = objCMRequirementENS.SynchToClientUser; //同步到Client库用户
objCMRequirementENT.SynSource = objCMRequirementENS.SynSource; //同步来源
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsCMRequirementEN objCMRequirementEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objCMRequirementEN.RequirementName, conCMRequirement.RequirementName);
clsCheckSql.CheckFieldNotNull(objCMRequirementEN.RequirementTypeId, conCMRequirement.RequirementTypeId);
clsCheckSql.CheckFieldNotNull(objCMRequirementEN.ReqContent, conCMRequirement.ReqContent);
clsCheckSql.CheckFieldNotNull(objCMRequirementEN.IsFinished, conCMRequirement.IsFinished);
clsCheckSql.CheckFieldNotNull(objCMRequirementEN.CmPrjId, conCMRequirement.CmPrjId);
clsCheckSql.CheckFieldNotNull(objCMRequirementEN.PrjId, conCMRequirement.PrjId);
//检查字段长度
clsCheckSql.CheckFieldLen(objCMRequirementEN.ReqId, 8, conCMRequirement.ReqId);
clsCheckSql.CheckFieldLen(objCMRequirementEN.RequirementName, 50, conCMRequirement.RequirementName);
clsCheckSql.CheckFieldLen(objCMRequirementEN.RequirementTypeId, 4, conCMRequirement.RequirementTypeId);
clsCheckSql.CheckFieldLen(objCMRequirementEN.ReqContent, 4000, conCMRequirement.ReqContent);
clsCheckSql.CheckFieldLen(objCMRequirementEN.UpReqId, 8, conCMRequirement.UpReqId);
clsCheckSql.CheckFieldLen(objCMRequirementEN.CmPrjId, 6, conCMRequirement.CmPrjId);
clsCheckSql.CheckFieldLen(objCMRequirementEN.FuncModuleAgcId, 8, conCMRequirement.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(objCMRequirementEN.PrjId, 4, conCMRequirement.PrjId);
clsCheckSql.CheckFieldLen(objCMRequirementEN.UpdUser, 20, conCMRequirement.UpdUser);
clsCheckSql.CheckFieldLen(objCMRequirementEN.UpdDate, 20, conCMRequirement.UpdDate);
clsCheckSql.CheckFieldLen(objCMRequirementEN.Memo, 1000, conCMRequirement.Memo);
clsCheckSql.CheckFieldLen(objCMRequirementEN.SynchToServerDate, 20, conCMRequirement.SynchToServerDate);
clsCheckSql.CheckFieldLen(objCMRequirementEN.SynchToServerUser, 20, conCMRequirement.SynchToServerUser);
clsCheckSql.CheckFieldLen(objCMRequirementEN.SynchToClientDate, 20, conCMRequirement.SynchToClientDate);
clsCheckSql.CheckFieldLen(objCMRequirementEN.SynchToClientUser, 20, conCMRequirement.SynchToClientUser);
clsCheckSql.CheckFieldLen(objCMRequirementEN.SynSource, 50, conCMRequirement.SynSource);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objCMRequirementEN.RequirementTypeId, 4, conCMRequirement.RequirementTypeId);
clsCheckSql.CheckFieldForeignKey(objCMRequirementEN.UpReqId, 8, conCMRequirement.UpReqId);
 objCMRequirementEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsCMRequirementEN objCMRequirementEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCMRequirementEN.RequirementName, 50, conCMRequirement.RequirementName);
clsCheckSql.CheckFieldLen(objCMRequirementEN.RequirementTypeId, 4, conCMRequirement.RequirementTypeId);
clsCheckSql.CheckFieldLen(objCMRequirementEN.ReqContent, 4000, conCMRequirement.ReqContent);
clsCheckSql.CheckFieldLen(objCMRequirementEN.UpReqId, 8, conCMRequirement.UpReqId);
clsCheckSql.CheckFieldLen(objCMRequirementEN.CmPrjId, 6, conCMRequirement.CmPrjId);
clsCheckSql.CheckFieldLen(objCMRequirementEN.FuncModuleAgcId, 8, conCMRequirement.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(objCMRequirementEN.PrjId, 4, conCMRequirement.PrjId);
clsCheckSql.CheckFieldLen(objCMRequirementEN.UpdUser, 20, conCMRequirement.UpdUser);
clsCheckSql.CheckFieldLen(objCMRequirementEN.UpdDate, 20, conCMRequirement.UpdDate);
clsCheckSql.CheckFieldLen(objCMRequirementEN.Memo, 1000, conCMRequirement.Memo);
clsCheckSql.CheckFieldLen(objCMRequirementEN.SynchToServerDate, 20, conCMRequirement.SynchToServerDate);
clsCheckSql.CheckFieldLen(objCMRequirementEN.SynchToServerUser, 20, conCMRequirement.SynchToServerUser);
clsCheckSql.CheckFieldLen(objCMRequirementEN.SynchToClientDate, 20, conCMRequirement.SynchToClientDate);
clsCheckSql.CheckFieldLen(objCMRequirementEN.SynchToClientUser, 20, conCMRequirement.SynchToClientUser);
clsCheckSql.CheckFieldLen(objCMRequirementEN.SynSource, 50, conCMRequirement.SynSource);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objCMRequirementEN.RequirementTypeId, 4, conCMRequirement.RequirementTypeId);
clsCheckSql.CheckFieldForeignKey(objCMRequirementEN.UpReqId, 8, conCMRequirement.UpReqId);
 objCMRequirementEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsCMRequirementEN objCMRequirementEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCMRequirementEN.ReqId, 8, conCMRequirement.ReqId);
clsCheckSql.CheckFieldLen(objCMRequirementEN.RequirementName, 50, conCMRequirement.RequirementName);
clsCheckSql.CheckFieldLen(objCMRequirementEN.RequirementTypeId, 4, conCMRequirement.RequirementTypeId);
clsCheckSql.CheckFieldLen(objCMRequirementEN.ReqContent, 4000, conCMRequirement.ReqContent);
clsCheckSql.CheckFieldLen(objCMRequirementEN.UpReqId, 8, conCMRequirement.UpReqId);
clsCheckSql.CheckFieldLen(objCMRequirementEN.CmPrjId, 6, conCMRequirement.CmPrjId);
clsCheckSql.CheckFieldLen(objCMRequirementEN.FuncModuleAgcId, 8, conCMRequirement.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(objCMRequirementEN.PrjId, 4, conCMRequirement.PrjId);
clsCheckSql.CheckFieldLen(objCMRequirementEN.UpdUser, 20, conCMRequirement.UpdUser);
clsCheckSql.CheckFieldLen(objCMRequirementEN.UpdDate, 20, conCMRequirement.UpdDate);
clsCheckSql.CheckFieldLen(objCMRequirementEN.Memo, 1000, conCMRequirement.Memo);
clsCheckSql.CheckFieldLen(objCMRequirementEN.SynchToServerDate, 20, conCMRequirement.SynchToServerDate);
clsCheckSql.CheckFieldLen(objCMRequirementEN.SynchToServerUser, 20, conCMRequirement.SynchToServerUser);
clsCheckSql.CheckFieldLen(objCMRequirementEN.SynchToClientDate, 20, conCMRequirement.SynchToClientDate);
clsCheckSql.CheckFieldLen(objCMRequirementEN.SynchToClientUser, 20, conCMRequirement.SynchToClientUser);
clsCheckSql.CheckFieldLen(objCMRequirementEN.SynSource, 50, conCMRequirement.SynSource);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objCMRequirementEN.ReqId, conCMRequirement.ReqId);
clsCheckSql.CheckSqlInjection4Field(objCMRequirementEN.RequirementName, conCMRequirement.RequirementName);
clsCheckSql.CheckSqlInjection4Field(objCMRequirementEN.RequirementTypeId, conCMRequirement.RequirementTypeId);
clsCheckSql.CheckSqlInjection4Field(objCMRequirementEN.ReqContent, conCMRequirement.ReqContent);
clsCheckSql.CheckSqlInjection4Field(objCMRequirementEN.UpReqId, conCMRequirement.UpReqId);
clsCheckSql.CheckSqlInjection4Field(objCMRequirementEN.CmPrjId, conCMRequirement.CmPrjId);
clsCheckSql.CheckSqlInjection4Field(objCMRequirementEN.FuncModuleAgcId, conCMRequirement.FuncModuleAgcId);
clsCheckSql.CheckSqlInjection4Field(objCMRequirementEN.PrjId, conCMRequirement.PrjId);
clsCheckSql.CheckSqlInjection4Field(objCMRequirementEN.UpdUser, conCMRequirement.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objCMRequirementEN.UpdDate, conCMRequirement.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objCMRequirementEN.Memo, conCMRequirement.Memo);
clsCheckSql.CheckSqlInjection4Field(objCMRequirementEN.SynchToServerDate, conCMRequirement.SynchToServerDate);
clsCheckSql.CheckSqlInjection4Field(objCMRequirementEN.SynchToServerUser, conCMRequirement.SynchToServerUser);
clsCheckSql.CheckSqlInjection4Field(objCMRequirementEN.SynchToClientDate, conCMRequirement.SynchToClientDate);
clsCheckSql.CheckSqlInjection4Field(objCMRequirementEN.SynchToClientUser, conCMRequirement.SynchToClientUser);
clsCheckSql.CheckSqlInjection4Field(objCMRequirementEN.SynSource, conCMRequirement.SynSource);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objCMRequirementEN.RequirementTypeId, 4, conCMRequirement.RequirementTypeId);
clsCheckSql.CheckFieldForeignKey(objCMRequirementEN.UpReqId, 8, conCMRequirement.UpReqId);
 objCMRequirementEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--CMRequirement(项目需求),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objCMRequirementEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsCMRequirementEN objCMRequirementEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CmPrjId = '{0}'", objCMRequirementEN.CmPrjId);
 sbCondition.AppendFormat(" and RequirementName = '{0}'", objCMRequirementEN.RequirementName);
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
 objSQL = clsCMRequirementDA.GetSpecSQLObj();
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
 objSQL = clsCMRequirementDA.GetSpecSQLObj();
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
 objSQL = clsCMRequirementDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCMRequirementEN._CurrTabName);
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
 objSQL = clsCMRequirementDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCMRequirementEN._CurrTabName, strCondition);
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
 objSQL = clsCMRequirementDA.GetSpecSQLObj();
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
 objSQL = clsCMRequirementDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}