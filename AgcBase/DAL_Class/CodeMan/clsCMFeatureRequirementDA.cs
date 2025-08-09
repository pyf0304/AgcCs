
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCMFeatureRequirementDA
 表名:CMFeatureRequirement(00050520)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:09:02
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
 /// CM功能需求关系(CMFeatureRequirement)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsCMFeatureRequirementDA : clsCommBase4DA
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
 return clsCMFeatureRequirementEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsCMFeatureRequirementEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCMFeatureRequirementEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsCMFeatureRequirementEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsCMFeatureRequirementEN._ConnectString);
 }
 return objSQL;
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsCMFeatureRequirementDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureRequirementDA.GetSpecSQLObj();
strSQL = "Select * from CMFeatureRequirement where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_CMFeatureRequirement(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsCMFeatureRequirementDA: GetDataTable_CMFeatureRequirement)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureRequirementDA.GetSpecSQLObj();
strSQL = "Select * from CMFeatureRequirement where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsCMFeatureRequirementDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureRequirementDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsCMFeatureRequirementDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureRequirementDA.GetSpecSQLObj();
strSQL = "Select * from CMFeatureRequirement where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsCMFeatureRequirementDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureRequirementDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsCMFeatureRequirementDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureRequirementDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CMFeatureRequirement where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CMFeatureRequirement where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsCMFeatureRequirementDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureRequirementDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from CMFeatureRequirement where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsCMFeatureRequirementDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureRequirementDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} CMFeatureRequirement.* " + 
$"from CMFeatureRequirement " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and CMFeatureRequirement.mId not in " + 
$"(Select top {intTop_In} CMFeatureRequirement.mId from CMFeatureRequirement " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CMFeatureRequirement where {1} and mId not in (Select top {2} mId from CMFeatureRequirement where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CMFeatureRequirement where {1} and mId not in (Select top {3} mId from CMFeatureRequirement where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsCMFeatureRequirementDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureRequirementDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} CMFeatureRequirement.* " + 
$"from CMFeatureRequirement " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and CMFeatureRequirement.mId not in " + 
$"(Select top {intTop_In} CMFeatureRequirement.mId from CMFeatureRequirement " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CMFeatureRequirement where {1} and mId not in (Select top {2} mId from CMFeatureRequirement where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CMFeatureRequirement where {1} and mId not in (Select top {3} mId from CMFeatureRequirement where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsCMFeatureRequirementEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsCMFeatureRequirementDA:GetObjLst)", objException.Message));
}
List<clsCMFeatureRequirementEN> arrObjLst = new List<clsCMFeatureRequirementEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureRequirementDA.GetSpecSQLObj();
strSQL = "Select * from CMFeatureRequirement where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMFeatureRequirementEN objCMFeatureRequirementEN = new clsCMFeatureRequirementEN();
try
{
objCMFeatureRequirementEN.mId = TransNullToInt(objRow[conCMFeatureRequirement.mId].ToString().Trim()); //mId
objCMFeatureRequirementEN.CmFeatureId = objRow[conCMFeatureRequirement.CmFeatureId].ToString().Trim(); //功能Id
objCMFeatureRequirementEN.ReqId = objRow[conCMFeatureRequirement.ReqId].ToString().Trim(); //需求Id
objCMFeatureRequirementEN.OrderNum = TransNullToInt(objRow[conCMFeatureRequirement.OrderNum].ToString().Trim()); //序号
objCMFeatureRequirementEN.PrjId = objRow[conCMFeatureRequirement.PrjId].ToString().Trim(); //工程Id
objCMFeatureRequirementEN.UpdDate = objRow[conCMFeatureRequirement.UpdDate] == DBNull.Value ? null : objRow[conCMFeatureRequirement.UpdDate].ToString().Trim(); //修改日期
objCMFeatureRequirementEN.UpdUser = objRow[conCMFeatureRequirement.UpdUser] == DBNull.Value ? null : objRow[conCMFeatureRequirement.UpdUser].ToString().Trim(); //修改者
objCMFeatureRequirementEN.Memo = objRow[conCMFeatureRequirement.Memo] == DBNull.Value ? null : objRow[conCMFeatureRequirement.Memo].ToString().Trim(); //说明
objCMFeatureRequirementEN.IsSynchToServer = TransNullToBool(objRow[conCMFeatureRequirement.IsSynchToServer].ToString().Trim()); //是否同步到Server
objCMFeatureRequirementEN.SynchToServerDate = objRow[conCMFeatureRequirement.SynchToServerDate] == DBNull.Value ? null : objRow[conCMFeatureRequirement.SynchToServerDate].ToString().Trim(); //同步到Server日期
objCMFeatureRequirementEN.SynchToServerUser = objRow[conCMFeatureRequirement.SynchToServerUser] == DBNull.Value ? null : objRow[conCMFeatureRequirement.SynchToServerUser].ToString().Trim(); //同步到Server用户
objCMFeatureRequirementEN.IsSynchToClient = TransNullToBool(objRow[conCMFeatureRequirement.IsSynchToClient].ToString().Trim()); //是否同步到Client
objCMFeatureRequirementEN.SynchToClientDate = objRow[conCMFeatureRequirement.SynchToClientDate] == DBNull.Value ? null : objRow[conCMFeatureRequirement.SynchToClientDate].ToString().Trim(); //同步到Client库日期
objCMFeatureRequirementEN.SynchToClientUser = objRow[conCMFeatureRequirement.SynchToClientUser] == DBNull.Value ? null : objRow[conCMFeatureRequirement.SynchToClientUser].ToString().Trim(); //同步到Client库用户
objCMFeatureRequirementEN.SynSource = objRow[conCMFeatureRequirement.SynSource] == DBNull.Value ? null : objRow[conCMFeatureRequirement.SynSource].ToString().Trim(); //同步来源
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCMFeatureRequirementDA: GetObjLst)", objException.Message));
}
objCMFeatureRequirementEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCMFeatureRequirementEN);
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
public List<clsCMFeatureRequirementEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsCMFeatureRequirementDA:GetObjLstByTabName)", objException.Message));
}
List<clsCMFeatureRequirementEN> arrObjLst = new List<clsCMFeatureRequirementEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureRequirementDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMFeatureRequirementEN objCMFeatureRequirementEN = new clsCMFeatureRequirementEN();
try
{
objCMFeatureRequirementEN.mId = TransNullToInt(objRow[conCMFeatureRequirement.mId].ToString().Trim()); //mId
objCMFeatureRequirementEN.CmFeatureId = objRow[conCMFeatureRequirement.CmFeatureId].ToString().Trim(); //功能Id
objCMFeatureRequirementEN.ReqId = objRow[conCMFeatureRequirement.ReqId].ToString().Trim(); //需求Id
objCMFeatureRequirementEN.OrderNum = TransNullToInt(objRow[conCMFeatureRequirement.OrderNum].ToString().Trim()); //序号
objCMFeatureRequirementEN.PrjId = objRow[conCMFeatureRequirement.PrjId].ToString().Trim(); //工程Id
objCMFeatureRequirementEN.UpdDate = objRow[conCMFeatureRequirement.UpdDate] == DBNull.Value ? null : objRow[conCMFeatureRequirement.UpdDate].ToString().Trim(); //修改日期
objCMFeatureRequirementEN.UpdUser = objRow[conCMFeatureRequirement.UpdUser] == DBNull.Value ? null : objRow[conCMFeatureRequirement.UpdUser].ToString().Trim(); //修改者
objCMFeatureRequirementEN.Memo = objRow[conCMFeatureRequirement.Memo] == DBNull.Value ? null : objRow[conCMFeatureRequirement.Memo].ToString().Trim(); //说明
objCMFeatureRequirementEN.IsSynchToServer = TransNullToBool(objRow[conCMFeatureRequirement.IsSynchToServer].ToString().Trim()); //是否同步到Server
objCMFeatureRequirementEN.SynchToServerDate = objRow[conCMFeatureRequirement.SynchToServerDate] == DBNull.Value ? null : objRow[conCMFeatureRequirement.SynchToServerDate].ToString().Trim(); //同步到Server日期
objCMFeatureRequirementEN.SynchToServerUser = objRow[conCMFeatureRequirement.SynchToServerUser] == DBNull.Value ? null : objRow[conCMFeatureRequirement.SynchToServerUser].ToString().Trim(); //同步到Server用户
objCMFeatureRequirementEN.IsSynchToClient = TransNullToBool(objRow[conCMFeatureRequirement.IsSynchToClient].ToString().Trim()); //是否同步到Client
objCMFeatureRequirementEN.SynchToClientDate = objRow[conCMFeatureRequirement.SynchToClientDate] == DBNull.Value ? null : objRow[conCMFeatureRequirement.SynchToClientDate].ToString().Trim(); //同步到Client库日期
objCMFeatureRequirementEN.SynchToClientUser = objRow[conCMFeatureRequirement.SynchToClientUser] == DBNull.Value ? null : objRow[conCMFeatureRequirement.SynchToClientUser].ToString().Trim(); //同步到Client库用户
objCMFeatureRequirementEN.SynSource = objRow[conCMFeatureRequirement.SynSource] == DBNull.Value ? null : objRow[conCMFeatureRequirement.SynSource].ToString().Trim(); //同步来源
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCMFeatureRequirementDA: GetObjLst)", objException.Message));
}
objCMFeatureRequirementEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCMFeatureRequirementEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objCMFeatureRequirementEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetCMFeatureRequirement(ref clsCMFeatureRequirementEN objCMFeatureRequirementEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureRequirementDA.GetSpecSQLObj();
strSQL = "Select * from CMFeatureRequirement where mId = " + ""+ objCMFeatureRequirementEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objCMFeatureRequirementEN.mId = TransNullToInt(objDT.Rows[0][conCMFeatureRequirement.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objCMFeatureRequirementEN.CmFeatureId = objDT.Rows[0][conCMFeatureRequirement.CmFeatureId].ToString().Trim(); //功能Id(字段类型:char,字段长度:8,是否可空:False)
 objCMFeatureRequirementEN.ReqId = objDT.Rows[0][conCMFeatureRequirement.ReqId].ToString().Trim(); //需求Id(字段类型:char,字段长度:8,是否可空:False)
 objCMFeatureRequirementEN.OrderNum = TransNullToInt(objDT.Rows[0][conCMFeatureRequirement.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objCMFeatureRequirementEN.PrjId = objDT.Rows[0][conCMFeatureRequirement.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objCMFeatureRequirementEN.UpdDate = objDT.Rows[0][conCMFeatureRequirement.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCMFeatureRequirementEN.UpdUser = objDT.Rows[0][conCMFeatureRequirement.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objCMFeatureRequirementEN.Memo = objDT.Rows[0][conCMFeatureRequirement.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objCMFeatureRequirementEN.IsSynchToServer = TransNullToBool(objDT.Rows[0][conCMFeatureRequirement.IsSynchToServer].ToString().Trim()); //是否同步到Server(字段类型:bit,字段长度:1,是否可空:True)
 objCMFeatureRequirementEN.SynchToServerDate = objDT.Rows[0][conCMFeatureRequirement.SynchToServerDate].ToString().Trim(); //同步到Server日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCMFeatureRequirementEN.SynchToServerUser = objDT.Rows[0][conCMFeatureRequirement.SynchToServerUser].ToString().Trim(); //同步到Server用户(字段类型:varchar,字段长度:20,是否可空:True)
 objCMFeatureRequirementEN.IsSynchToClient = TransNullToBool(objDT.Rows[0][conCMFeatureRequirement.IsSynchToClient].ToString().Trim()); //是否同步到Client(字段类型:bit,字段长度:1,是否可空:True)
 objCMFeatureRequirementEN.SynchToClientDate = objDT.Rows[0][conCMFeatureRequirement.SynchToClientDate].ToString().Trim(); //同步到Client库日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCMFeatureRequirementEN.SynchToClientUser = objDT.Rows[0][conCMFeatureRequirement.SynchToClientUser].ToString().Trim(); //同步到Client库用户(字段类型:varchar,字段长度:20,是否可空:True)
 objCMFeatureRequirementEN.SynSource = objDT.Rows[0][conCMFeatureRequirement.SynSource].ToString().Trim(); //同步来源(字段类型:varchar,字段长度:50,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsCMFeatureRequirementDA: GetCMFeatureRequirement)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsCMFeatureRequirementEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureRequirementDA.GetSpecSQLObj();
strSQL = "Select * from CMFeatureRequirement where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsCMFeatureRequirementEN objCMFeatureRequirementEN = new clsCMFeatureRequirementEN();
try
{
 objCMFeatureRequirementEN.mId = Int32.Parse(objRow[conCMFeatureRequirement.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objCMFeatureRequirementEN.CmFeatureId = objRow[conCMFeatureRequirement.CmFeatureId].ToString().Trim(); //功能Id(字段类型:char,字段长度:8,是否可空:False)
 objCMFeatureRequirementEN.ReqId = objRow[conCMFeatureRequirement.ReqId].ToString().Trim(); //需求Id(字段类型:char,字段长度:8,是否可空:False)
 objCMFeatureRequirementEN.OrderNum = Int32.Parse(objRow[conCMFeatureRequirement.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objCMFeatureRequirementEN.PrjId = objRow[conCMFeatureRequirement.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objCMFeatureRequirementEN.UpdDate = objRow[conCMFeatureRequirement.UpdDate] == DBNull.Value ? null : objRow[conCMFeatureRequirement.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCMFeatureRequirementEN.UpdUser = objRow[conCMFeatureRequirement.UpdUser] == DBNull.Value ? null : objRow[conCMFeatureRequirement.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objCMFeatureRequirementEN.Memo = objRow[conCMFeatureRequirement.Memo] == DBNull.Value ? null : objRow[conCMFeatureRequirement.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objCMFeatureRequirementEN.IsSynchToServer = clsEntityBase2.TransNullToBool_S(objRow[conCMFeatureRequirement.IsSynchToServer].ToString().Trim()); //是否同步到Server(字段类型:bit,字段长度:1,是否可空:True)
 objCMFeatureRequirementEN.SynchToServerDate = objRow[conCMFeatureRequirement.SynchToServerDate] == DBNull.Value ? null : objRow[conCMFeatureRequirement.SynchToServerDate].ToString().Trim(); //同步到Server日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCMFeatureRequirementEN.SynchToServerUser = objRow[conCMFeatureRequirement.SynchToServerUser] == DBNull.Value ? null : objRow[conCMFeatureRequirement.SynchToServerUser].ToString().Trim(); //同步到Server用户(字段类型:varchar,字段长度:20,是否可空:True)
 objCMFeatureRequirementEN.IsSynchToClient = clsEntityBase2.TransNullToBool_S(objRow[conCMFeatureRequirement.IsSynchToClient].ToString().Trim()); //是否同步到Client(字段类型:bit,字段长度:1,是否可空:True)
 objCMFeatureRequirementEN.SynchToClientDate = objRow[conCMFeatureRequirement.SynchToClientDate] == DBNull.Value ? null : objRow[conCMFeatureRequirement.SynchToClientDate].ToString().Trim(); //同步到Client库日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCMFeatureRequirementEN.SynchToClientUser = objRow[conCMFeatureRequirement.SynchToClientUser] == DBNull.Value ? null : objRow[conCMFeatureRequirement.SynchToClientUser].ToString().Trim(); //同步到Client库用户(字段类型:varchar,字段长度:20,是否可空:True)
 objCMFeatureRequirementEN.SynSource = objRow[conCMFeatureRequirement.SynSource] == DBNull.Value ? null : objRow[conCMFeatureRequirement.SynSource].ToString().Trim(); //同步来源(字段类型:varchar,字段长度:50,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsCMFeatureRequirementDA: GetObjBymId)", objException.Message));
}
return objCMFeatureRequirementEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsCMFeatureRequirementEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsCMFeatureRequirementDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureRequirementDA.GetSpecSQLObj();
strSQL = "Select * from CMFeatureRequirement where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsCMFeatureRequirementEN objCMFeatureRequirementEN = new clsCMFeatureRequirementEN()
{
mId = TransNullToInt(objRow[conCMFeatureRequirement.mId].ToString().Trim()), //mId
CmFeatureId = objRow[conCMFeatureRequirement.CmFeatureId].ToString().Trim(), //功能Id
ReqId = objRow[conCMFeatureRequirement.ReqId].ToString().Trim(), //需求Id
OrderNum = TransNullToInt(objRow[conCMFeatureRequirement.OrderNum].ToString().Trim()), //序号
PrjId = objRow[conCMFeatureRequirement.PrjId].ToString().Trim(), //工程Id
UpdDate = objRow[conCMFeatureRequirement.UpdDate] == DBNull.Value ? null : objRow[conCMFeatureRequirement.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conCMFeatureRequirement.UpdUser] == DBNull.Value ? null : objRow[conCMFeatureRequirement.UpdUser].ToString().Trim(), //修改者
Memo = objRow[conCMFeatureRequirement.Memo] == DBNull.Value ? null : objRow[conCMFeatureRequirement.Memo].ToString().Trim(), //说明
IsSynchToServer = TransNullToBool(objRow[conCMFeatureRequirement.IsSynchToServer].ToString().Trim()), //是否同步到Server
SynchToServerDate = objRow[conCMFeatureRequirement.SynchToServerDate] == DBNull.Value ? null : objRow[conCMFeatureRequirement.SynchToServerDate].ToString().Trim(), //同步到Server日期
SynchToServerUser = objRow[conCMFeatureRequirement.SynchToServerUser] == DBNull.Value ? null : objRow[conCMFeatureRequirement.SynchToServerUser].ToString().Trim(), //同步到Server用户
IsSynchToClient = TransNullToBool(objRow[conCMFeatureRequirement.IsSynchToClient].ToString().Trim()), //是否同步到Client
SynchToClientDate = objRow[conCMFeatureRequirement.SynchToClientDate] == DBNull.Value ? null : objRow[conCMFeatureRequirement.SynchToClientDate].ToString().Trim(), //同步到Client库日期
SynchToClientUser = objRow[conCMFeatureRequirement.SynchToClientUser] == DBNull.Value ? null : objRow[conCMFeatureRequirement.SynchToClientUser].ToString().Trim(), //同步到Client库用户
SynSource = objRow[conCMFeatureRequirement.SynSource] == DBNull.Value ? null : objRow[conCMFeatureRequirement.SynSource].ToString().Trim() //同步来源
};
objCMFeatureRequirementEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCMFeatureRequirementEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsCMFeatureRequirementDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsCMFeatureRequirementEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCMFeatureRequirementEN objCMFeatureRequirementEN = new clsCMFeatureRequirementEN();
try
{
objCMFeatureRequirementEN.mId = TransNullToInt(objRow[conCMFeatureRequirement.mId].ToString().Trim()); //mId
objCMFeatureRequirementEN.CmFeatureId = objRow[conCMFeatureRequirement.CmFeatureId].ToString().Trim(); //功能Id
objCMFeatureRequirementEN.ReqId = objRow[conCMFeatureRequirement.ReqId].ToString().Trim(); //需求Id
objCMFeatureRequirementEN.OrderNum = TransNullToInt(objRow[conCMFeatureRequirement.OrderNum].ToString().Trim()); //序号
objCMFeatureRequirementEN.PrjId = objRow[conCMFeatureRequirement.PrjId].ToString().Trim(); //工程Id
objCMFeatureRequirementEN.UpdDate = objRow[conCMFeatureRequirement.UpdDate] == DBNull.Value ? null : objRow[conCMFeatureRequirement.UpdDate].ToString().Trim(); //修改日期
objCMFeatureRequirementEN.UpdUser = objRow[conCMFeatureRequirement.UpdUser] == DBNull.Value ? null : objRow[conCMFeatureRequirement.UpdUser].ToString().Trim(); //修改者
objCMFeatureRequirementEN.Memo = objRow[conCMFeatureRequirement.Memo] == DBNull.Value ? null : objRow[conCMFeatureRequirement.Memo].ToString().Trim(); //说明
objCMFeatureRequirementEN.IsSynchToServer = TransNullToBool(objRow[conCMFeatureRequirement.IsSynchToServer].ToString().Trim()); //是否同步到Server
objCMFeatureRequirementEN.SynchToServerDate = objRow[conCMFeatureRequirement.SynchToServerDate] == DBNull.Value ? null : objRow[conCMFeatureRequirement.SynchToServerDate].ToString().Trim(); //同步到Server日期
objCMFeatureRequirementEN.SynchToServerUser = objRow[conCMFeatureRequirement.SynchToServerUser] == DBNull.Value ? null : objRow[conCMFeatureRequirement.SynchToServerUser].ToString().Trim(); //同步到Server用户
objCMFeatureRequirementEN.IsSynchToClient = TransNullToBool(objRow[conCMFeatureRequirement.IsSynchToClient].ToString().Trim()); //是否同步到Client
objCMFeatureRequirementEN.SynchToClientDate = objRow[conCMFeatureRequirement.SynchToClientDate] == DBNull.Value ? null : objRow[conCMFeatureRequirement.SynchToClientDate].ToString().Trim(); //同步到Client库日期
objCMFeatureRequirementEN.SynchToClientUser = objRow[conCMFeatureRequirement.SynchToClientUser] == DBNull.Value ? null : objRow[conCMFeatureRequirement.SynchToClientUser].ToString().Trim(); //同步到Client库用户
objCMFeatureRequirementEN.SynSource = objRow[conCMFeatureRequirement.SynSource] == DBNull.Value ? null : objRow[conCMFeatureRequirement.SynSource].ToString().Trim(); //同步来源
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsCMFeatureRequirementDA: GetObjByDataRowCMFeatureRequirement)", objException.Message));
}
objCMFeatureRequirementEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCMFeatureRequirementEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsCMFeatureRequirementEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCMFeatureRequirementEN objCMFeatureRequirementEN = new clsCMFeatureRequirementEN();
try
{
objCMFeatureRequirementEN.mId = TransNullToInt(objRow[conCMFeatureRequirement.mId].ToString().Trim()); //mId
objCMFeatureRequirementEN.CmFeatureId = objRow[conCMFeatureRequirement.CmFeatureId].ToString().Trim(); //功能Id
objCMFeatureRequirementEN.ReqId = objRow[conCMFeatureRequirement.ReqId].ToString().Trim(); //需求Id
objCMFeatureRequirementEN.OrderNum = TransNullToInt(objRow[conCMFeatureRequirement.OrderNum].ToString().Trim()); //序号
objCMFeatureRequirementEN.PrjId = objRow[conCMFeatureRequirement.PrjId].ToString().Trim(); //工程Id
objCMFeatureRequirementEN.UpdDate = objRow[conCMFeatureRequirement.UpdDate] == DBNull.Value ? null : objRow[conCMFeatureRequirement.UpdDate].ToString().Trim(); //修改日期
objCMFeatureRequirementEN.UpdUser = objRow[conCMFeatureRequirement.UpdUser] == DBNull.Value ? null : objRow[conCMFeatureRequirement.UpdUser].ToString().Trim(); //修改者
objCMFeatureRequirementEN.Memo = objRow[conCMFeatureRequirement.Memo] == DBNull.Value ? null : objRow[conCMFeatureRequirement.Memo].ToString().Trim(); //说明
objCMFeatureRequirementEN.IsSynchToServer = TransNullToBool(objRow[conCMFeatureRequirement.IsSynchToServer].ToString().Trim()); //是否同步到Server
objCMFeatureRequirementEN.SynchToServerDate = objRow[conCMFeatureRequirement.SynchToServerDate] == DBNull.Value ? null : objRow[conCMFeatureRequirement.SynchToServerDate].ToString().Trim(); //同步到Server日期
objCMFeatureRequirementEN.SynchToServerUser = objRow[conCMFeatureRequirement.SynchToServerUser] == DBNull.Value ? null : objRow[conCMFeatureRequirement.SynchToServerUser].ToString().Trim(); //同步到Server用户
objCMFeatureRequirementEN.IsSynchToClient = TransNullToBool(objRow[conCMFeatureRequirement.IsSynchToClient].ToString().Trim()); //是否同步到Client
objCMFeatureRequirementEN.SynchToClientDate = objRow[conCMFeatureRequirement.SynchToClientDate] == DBNull.Value ? null : objRow[conCMFeatureRequirement.SynchToClientDate].ToString().Trim(); //同步到Client库日期
objCMFeatureRequirementEN.SynchToClientUser = objRow[conCMFeatureRequirement.SynchToClientUser] == DBNull.Value ? null : objRow[conCMFeatureRequirement.SynchToClientUser].ToString().Trim(); //同步到Client库用户
objCMFeatureRequirementEN.SynSource = objRow[conCMFeatureRequirement.SynSource] == DBNull.Value ? null : objRow[conCMFeatureRequirement.SynSource].ToString().Trim(); //同步来源
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsCMFeatureRequirementDA: GetObjByDataRow)", objException.Message));
}
objCMFeatureRequirementEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCMFeatureRequirementEN;
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
objSQL = clsCMFeatureRequirementDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCMFeatureRequirementEN._CurrTabName, conCMFeatureRequirement.mId, 8, "");
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
objSQL = clsCMFeatureRequirementDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCMFeatureRequirementEN._CurrTabName, conCMFeatureRequirement.mId, 8, strPrefix);
return strMaxValue;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public long GetFirstID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureRequirementDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from CMFeatureRequirement where " + strCondition;
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
return 0;
}
strKeyValue = objDT.Rows[0][0].ToString();
return long.Parse(strKeyValue);
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
 objSQL = clsCMFeatureRequirementDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from CMFeatureRequirement where " + strCondition;
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngmId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureRequirementDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CMFeatureRequirement", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsCMFeatureRequirementDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureRequirementDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CMFeatureRequirement", strCondition))
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
objSQL = clsCMFeatureRequirementDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("CMFeatureRequirement");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsCMFeatureRequirementEN objCMFeatureRequirementEN)
 {
 objCMFeatureRequirementEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMFeatureRequirementEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCMFeatureRequirementEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureRequirementDA.GetSpecSQLObj();
strSQL = "Select * from CMFeatureRequirement where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CMFeatureRequirement");
objRow = objDS.Tables["CMFeatureRequirement"].NewRow();
objRow[conCMFeatureRequirement.CmFeatureId] = objCMFeatureRequirementEN.CmFeatureId; //功能Id
objRow[conCMFeatureRequirement.ReqId] = objCMFeatureRequirementEN.ReqId; //需求Id
objRow[conCMFeatureRequirement.OrderNum] = objCMFeatureRequirementEN.OrderNum; //序号
objRow[conCMFeatureRequirement.PrjId] = objCMFeatureRequirementEN.PrjId; //工程Id
 if (objCMFeatureRequirementEN.UpdDate !=  "")
 {
objRow[conCMFeatureRequirement.UpdDate] = objCMFeatureRequirementEN.UpdDate; //修改日期
 }
 if (objCMFeatureRequirementEN.UpdUser !=  "")
 {
objRow[conCMFeatureRequirement.UpdUser] = objCMFeatureRequirementEN.UpdUser; //修改者
 }
 if (objCMFeatureRequirementEN.Memo !=  "")
 {
objRow[conCMFeatureRequirement.Memo] = objCMFeatureRequirementEN.Memo; //说明
 }
objRow[conCMFeatureRequirement.IsSynchToServer] = objCMFeatureRequirementEN.IsSynchToServer; //是否同步到Server
 if (objCMFeatureRequirementEN.SynchToServerDate !=  "")
 {
objRow[conCMFeatureRequirement.SynchToServerDate] = objCMFeatureRequirementEN.SynchToServerDate; //同步到Server日期
 }
 if (objCMFeatureRequirementEN.SynchToServerUser !=  "")
 {
objRow[conCMFeatureRequirement.SynchToServerUser] = objCMFeatureRequirementEN.SynchToServerUser; //同步到Server用户
 }
objRow[conCMFeatureRequirement.IsSynchToClient] = objCMFeatureRequirementEN.IsSynchToClient; //是否同步到Client
 if (objCMFeatureRequirementEN.SynchToClientDate !=  "")
 {
objRow[conCMFeatureRequirement.SynchToClientDate] = objCMFeatureRequirementEN.SynchToClientDate; //同步到Client库日期
 }
 if (objCMFeatureRequirementEN.SynchToClientUser !=  "")
 {
objRow[conCMFeatureRequirement.SynchToClientUser] = objCMFeatureRequirementEN.SynchToClientUser; //同步到Client库用户
 }
 if (objCMFeatureRequirementEN.SynSource !=  "")
 {
objRow[conCMFeatureRequirement.SynSource] = objCMFeatureRequirementEN.SynSource; //同步来源
 }
objDS.Tables[clsCMFeatureRequirementEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsCMFeatureRequirementEN._CurrTabName);
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
 /// <param name = "objCMFeatureRequirementEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCMFeatureRequirementEN objCMFeatureRequirementEN)
{
 objCMFeatureRequirementEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMFeatureRequirementEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCMFeatureRequirementEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objCMFeatureRequirementEN.CmFeatureId !=  null)
 {
 arrFieldListForInsert.Add(conCMFeatureRequirement.CmFeatureId);
 var strCmFeatureId = objCMFeatureRequirementEN.CmFeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmFeatureId + "'");
 }
 
 if (objCMFeatureRequirementEN.ReqId !=  null)
 {
 arrFieldListForInsert.Add(conCMFeatureRequirement.ReqId);
 var strReqId = objCMFeatureRequirementEN.ReqId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReqId + "'");
 }
 
 arrFieldListForInsert.Add(conCMFeatureRequirement.OrderNum);
 arrValueListForInsert.Add(objCMFeatureRequirementEN.OrderNum.ToString());
 
 if (objCMFeatureRequirementEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conCMFeatureRequirement.PrjId);
 var strPrjId = objCMFeatureRequirementEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objCMFeatureRequirementEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCMFeatureRequirement.UpdDate);
 var strUpdDate = objCMFeatureRequirementEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCMFeatureRequirementEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCMFeatureRequirement.UpdUser);
 var strUpdUser = objCMFeatureRequirementEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objCMFeatureRequirementEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCMFeatureRequirement.Memo);
 var strMemo = objCMFeatureRequirementEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 arrFieldListForInsert.Add(conCMFeatureRequirement.IsSynchToServer);
 arrValueListForInsert.Add("'" + (objCMFeatureRequirementEN.IsSynchToServer  ==  false ? "0" : "1") + "'");
 
 if (objCMFeatureRequirementEN.SynchToServerDate !=  null)
 {
 arrFieldListForInsert.Add(conCMFeatureRequirement.SynchToServerDate);
 var strSynchToServerDate = objCMFeatureRequirementEN.SynchToServerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToServerDate + "'");
 }
 
 if (objCMFeatureRequirementEN.SynchToServerUser !=  null)
 {
 arrFieldListForInsert.Add(conCMFeatureRequirement.SynchToServerUser);
 var strSynchToServerUser = objCMFeatureRequirementEN.SynchToServerUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToServerUser + "'");
 }
 
 arrFieldListForInsert.Add(conCMFeatureRequirement.IsSynchToClient);
 arrValueListForInsert.Add("'" + (objCMFeatureRequirementEN.IsSynchToClient  ==  false ? "0" : "1") + "'");
 
 if (objCMFeatureRequirementEN.SynchToClientDate !=  null)
 {
 arrFieldListForInsert.Add(conCMFeatureRequirement.SynchToClientDate);
 var strSynchToClientDate = objCMFeatureRequirementEN.SynchToClientDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToClientDate + "'");
 }
 
 if (objCMFeatureRequirementEN.SynchToClientUser !=  null)
 {
 arrFieldListForInsert.Add(conCMFeatureRequirement.SynchToClientUser);
 var strSynchToClientUser = objCMFeatureRequirementEN.SynchToClientUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToClientUser + "'");
 }
 
 if (objCMFeatureRequirementEN.SynSource !=  null)
 {
 arrFieldListForInsert.Add(conCMFeatureRequirement.SynSource);
 var strSynSource = objCMFeatureRequirementEN.SynSource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynSource + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CMFeatureRequirement");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureRequirementDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objCMFeatureRequirementEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCMFeatureRequirementEN objCMFeatureRequirementEN)
{
 objCMFeatureRequirementEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMFeatureRequirementEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCMFeatureRequirementEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objCMFeatureRequirementEN.CmFeatureId !=  null)
 {
 arrFieldListForInsert.Add(conCMFeatureRequirement.CmFeatureId);
 var strCmFeatureId = objCMFeatureRequirementEN.CmFeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmFeatureId + "'");
 }
 
 if (objCMFeatureRequirementEN.ReqId !=  null)
 {
 arrFieldListForInsert.Add(conCMFeatureRequirement.ReqId);
 var strReqId = objCMFeatureRequirementEN.ReqId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReqId + "'");
 }
 
 arrFieldListForInsert.Add(conCMFeatureRequirement.OrderNum);
 arrValueListForInsert.Add(objCMFeatureRequirementEN.OrderNum.ToString());
 
 if (objCMFeatureRequirementEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conCMFeatureRequirement.PrjId);
 var strPrjId = objCMFeatureRequirementEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objCMFeatureRequirementEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCMFeatureRequirement.UpdDate);
 var strUpdDate = objCMFeatureRequirementEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCMFeatureRequirementEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCMFeatureRequirement.UpdUser);
 var strUpdUser = objCMFeatureRequirementEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objCMFeatureRequirementEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCMFeatureRequirement.Memo);
 var strMemo = objCMFeatureRequirementEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 arrFieldListForInsert.Add(conCMFeatureRequirement.IsSynchToServer);
 arrValueListForInsert.Add("'" + (objCMFeatureRequirementEN.IsSynchToServer  ==  false ? "0" : "1") + "'");
 
 if (objCMFeatureRequirementEN.SynchToServerDate !=  null)
 {
 arrFieldListForInsert.Add(conCMFeatureRequirement.SynchToServerDate);
 var strSynchToServerDate = objCMFeatureRequirementEN.SynchToServerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToServerDate + "'");
 }
 
 if (objCMFeatureRequirementEN.SynchToServerUser !=  null)
 {
 arrFieldListForInsert.Add(conCMFeatureRequirement.SynchToServerUser);
 var strSynchToServerUser = objCMFeatureRequirementEN.SynchToServerUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToServerUser + "'");
 }
 
 arrFieldListForInsert.Add(conCMFeatureRequirement.IsSynchToClient);
 arrValueListForInsert.Add("'" + (objCMFeatureRequirementEN.IsSynchToClient  ==  false ? "0" : "1") + "'");
 
 if (objCMFeatureRequirementEN.SynchToClientDate !=  null)
 {
 arrFieldListForInsert.Add(conCMFeatureRequirement.SynchToClientDate);
 var strSynchToClientDate = objCMFeatureRequirementEN.SynchToClientDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToClientDate + "'");
 }
 
 if (objCMFeatureRequirementEN.SynchToClientUser !=  null)
 {
 arrFieldListForInsert.Add(conCMFeatureRequirement.SynchToClientUser);
 var strSynchToClientUser = objCMFeatureRequirementEN.SynchToClientUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToClientUser + "'");
 }
 
 if (objCMFeatureRequirementEN.SynSource !=  null)
 {
 arrFieldListForInsert.Add(conCMFeatureRequirement.SynSource);
 var strSynSource = objCMFeatureRequirementEN.SynSource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynSource + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CMFeatureRequirement");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureRequirementDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objCMFeatureRequirementEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCMFeatureRequirementEN objCMFeatureRequirementEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objCMFeatureRequirementEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMFeatureRequirementEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCMFeatureRequirementEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objCMFeatureRequirementEN.CmFeatureId !=  null)
 {
 arrFieldListForInsert.Add(conCMFeatureRequirement.CmFeatureId);
 var strCmFeatureId = objCMFeatureRequirementEN.CmFeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmFeatureId + "'");
 }
 
 if (objCMFeatureRequirementEN.ReqId !=  null)
 {
 arrFieldListForInsert.Add(conCMFeatureRequirement.ReqId);
 var strReqId = objCMFeatureRequirementEN.ReqId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReqId + "'");
 }
 
 arrFieldListForInsert.Add(conCMFeatureRequirement.OrderNum);
 arrValueListForInsert.Add(objCMFeatureRequirementEN.OrderNum.ToString());
 
 if (objCMFeatureRequirementEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conCMFeatureRequirement.PrjId);
 var strPrjId = objCMFeatureRequirementEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objCMFeatureRequirementEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCMFeatureRequirement.UpdDate);
 var strUpdDate = objCMFeatureRequirementEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCMFeatureRequirementEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCMFeatureRequirement.UpdUser);
 var strUpdUser = objCMFeatureRequirementEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objCMFeatureRequirementEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCMFeatureRequirement.Memo);
 var strMemo = objCMFeatureRequirementEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 arrFieldListForInsert.Add(conCMFeatureRequirement.IsSynchToServer);
 arrValueListForInsert.Add("'" + (objCMFeatureRequirementEN.IsSynchToServer  ==  false ? "0" : "1") + "'");
 
 if (objCMFeatureRequirementEN.SynchToServerDate !=  null)
 {
 arrFieldListForInsert.Add(conCMFeatureRequirement.SynchToServerDate);
 var strSynchToServerDate = objCMFeatureRequirementEN.SynchToServerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToServerDate + "'");
 }
 
 if (objCMFeatureRequirementEN.SynchToServerUser !=  null)
 {
 arrFieldListForInsert.Add(conCMFeatureRequirement.SynchToServerUser);
 var strSynchToServerUser = objCMFeatureRequirementEN.SynchToServerUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToServerUser + "'");
 }
 
 arrFieldListForInsert.Add(conCMFeatureRequirement.IsSynchToClient);
 arrValueListForInsert.Add("'" + (objCMFeatureRequirementEN.IsSynchToClient  ==  false ? "0" : "1") + "'");
 
 if (objCMFeatureRequirementEN.SynchToClientDate !=  null)
 {
 arrFieldListForInsert.Add(conCMFeatureRequirement.SynchToClientDate);
 var strSynchToClientDate = objCMFeatureRequirementEN.SynchToClientDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToClientDate + "'");
 }
 
 if (objCMFeatureRequirementEN.SynchToClientUser !=  null)
 {
 arrFieldListForInsert.Add(conCMFeatureRequirement.SynchToClientUser);
 var strSynchToClientUser = objCMFeatureRequirementEN.SynchToClientUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToClientUser + "'");
 }
 
 if (objCMFeatureRequirementEN.SynSource !=  null)
 {
 arrFieldListForInsert.Add(conCMFeatureRequirement.SynSource);
 var strSynSource = objCMFeatureRequirementEN.SynSource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynSource + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CMFeatureRequirement");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureRequirementDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objCMFeatureRequirementEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCMFeatureRequirementEN objCMFeatureRequirementEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objCMFeatureRequirementEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMFeatureRequirementEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCMFeatureRequirementEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objCMFeatureRequirementEN.CmFeatureId !=  null)
 {
 arrFieldListForInsert.Add(conCMFeatureRequirement.CmFeatureId);
 var strCmFeatureId = objCMFeatureRequirementEN.CmFeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmFeatureId + "'");
 }
 
 if (objCMFeatureRequirementEN.ReqId !=  null)
 {
 arrFieldListForInsert.Add(conCMFeatureRequirement.ReqId);
 var strReqId = objCMFeatureRequirementEN.ReqId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReqId + "'");
 }
 
 arrFieldListForInsert.Add(conCMFeatureRequirement.OrderNum);
 arrValueListForInsert.Add(objCMFeatureRequirementEN.OrderNum.ToString());
 
 if (objCMFeatureRequirementEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conCMFeatureRequirement.PrjId);
 var strPrjId = objCMFeatureRequirementEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objCMFeatureRequirementEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCMFeatureRequirement.UpdDate);
 var strUpdDate = objCMFeatureRequirementEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCMFeatureRequirementEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCMFeatureRequirement.UpdUser);
 var strUpdUser = objCMFeatureRequirementEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objCMFeatureRequirementEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCMFeatureRequirement.Memo);
 var strMemo = objCMFeatureRequirementEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 arrFieldListForInsert.Add(conCMFeatureRequirement.IsSynchToServer);
 arrValueListForInsert.Add("'" + (objCMFeatureRequirementEN.IsSynchToServer  ==  false ? "0" : "1") + "'");
 
 if (objCMFeatureRequirementEN.SynchToServerDate !=  null)
 {
 arrFieldListForInsert.Add(conCMFeatureRequirement.SynchToServerDate);
 var strSynchToServerDate = objCMFeatureRequirementEN.SynchToServerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToServerDate + "'");
 }
 
 if (objCMFeatureRequirementEN.SynchToServerUser !=  null)
 {
 arrFieldListForInsert.Add(conCMFeatureRequirement.SynchToServerUser);
 var strSynchToServerUser = objCMFeatureRequirementEN.SynchToServerUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToServerUser + "'");
 }
 
 arrFieldListForInsert.Add(conCMFeatureRequirement.IsSynchToClient);
 arrValueListForInsert.Add("'" + (objCMFeatureRequirementEN.IsSynchToClient  ==  false ? "0" : "1") + "'");
 
 if (objCMFeatureRequirementEN.SynchToClientDate !=  null)
 {
 arrFieldListForInsert.Add(conCMFeatureRequirement.SynchToClientDate);
 var strSynchToClientDate = objCMFeatureRequirementEN.SynchToClientDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToClientDate + "'");
 }
 
 if (objCMFeatureRequirementEN.SynchToClientUser !=  null)
 {
 arrFieldListForInsert.Add(conCMFeatureRequirement.SynchToClientUser);
 var strSynchToClientUser = objCMFeatureRequirementEN.SynchToClientUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToClientUser + "'");
 }
 
 if (objCMFeatureRequirementEN.SynSource !=  null)
 {
 arrFieldListForInsert.Add(conCMFeatureRequirement.SynSource);
 var strSynSource = objCMFeatureRequirementEN.SynSource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynSource + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CMFeatureRequirement");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureRequirementDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewCMFeatureRequirements(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureRequirementDA.GetSpecSQLObj();
strSQL = "Select * from CMFeatureRequirement where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CMFeatureRequirement");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngmId = TransNullToInt(oRow[conCMFeatureRequirement.mId].ToString().Trim());
if (IsExist(lngmId))
{
 string strResult = "关键字变量值为:" + string.Format("mId = {0}", lngmId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsCMFeatureRequirementEN._CurrTabName ].NewRow();
objRow[conCMFeatureRequirement.CmFeatureId] = oRow[conCMFeatureRequirement.CmFeatureId].ToString().Trim(); //功能Id
objRow[conCMFeatureRequirement.ReqId] = oRow[conCMFeatureRequirement.ReqId].ToString().Trim(); //需求Id
objRow[conCMFeatureRequirement.OrderNum] = oRow[conCMFeatureRequirement.OrderNum].ToString().Trim(); //序号
objRow[conCMFeatureRequirement.PrjId] = oRow[conCMFeatureRequirement.PrjId].ToString().Trim(); //工程Id
objRow[conCMFeatureRequirement.UpdDate] = oRow[conCMFeatureRequirement.UpdDate].ToString().Trim(); //修改日期
objRow[conCMFeatureRequirement.UpdUser] = oRow[conCMFeatureRequirement.UpdUser].ToString().Trim(); //修改者
objRow[conCMFeatureRequirement.Memo] = oRow[conCMFeatureRequirement.Memo].ToString().Trim(); //说明
objRow[conCMFeatureRequirement.IsSynchToServer] = oRow[conCMFeatureRequirement.IsSynchToServer].ToString().Trim(); //是否同步到Server
objRow[conCMFeatureRequirement.SynchToServerDate] = oRow[conCMFeatureRequirement.SynchToServerDate].ToString().Trim(); //同步到Server日期
objRow[conCMFeatureRequirement.SynchToServerUser] = oRow[conCMFeatureRequirement.SynchToServerUser].ToString().Trim(); //同步到Server用户
objRow[conCMFeatureRequirement.IsSynchToClient] = oRow[conCMFeatureRequirement.IsSynchToClient].ToString().Trim(); //是否同步到Client
objRow[conCMFeatureRequirement.SynchToClientDate] = oRow[conCMFeatureRequirement.SynchToClientDate].ToString().Trim(); //同步到Client库日期
objRow[conCMFeatureRequirement.SynchToClientUser] = oRow[conCMFeatureRequirement.SynchToClientUser].ToString().Trim(); //同步到Client库用户
objRow[conCMFeatureRequirement.SynSource] = oRow[conCMFeatureRequirement.SynSource].ToString().Trim(); //同步来源
 objDS.Tables[clsCMFeatureRequirementEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsCMFeatureRequirementEN._CurrTabName);
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
 /// <param name = "objCMFeatureRequirementEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsCMFeatureRequirementEN objCMFeatureRequirementEN)
{
 objCMFeatureRequirementEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMFeatureRequirementEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCMFeatureRequirementEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureRequirementDA.GetSpecSQLObj();
strSQL = "Select * from CMFeatureRequirement where mId = " + ""+ objCMFeatureRequirementEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsCMFeatureRequirementEN._CurrTabName);
if (objDS.Tables[clsCMFeatureRequirementEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objCMFeatureRequirementEN.mId+"");
return false;
}
objRow = objDS.Tables[clsCMFeatureRequirementEN._CurrTabName].Rows[0];
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.CmFeatureId))
 {
objRow[conCMFeatureRequirement.CmFeatureId] = objCMFeatureRequirementEN.CmFeatureId; //功能Id
 }
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.ReqId))
 {
objRow[conCMFeatureRequirement.ReqId] = objCMFeatureRequirementEN.ReqId; //需求Id
 }
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.OrderNum))
 {
objRow[conCMFeatureRequirement.OrderNum] = objCMFeatureRequirementEN.OrderNum; //序号
 }
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.PrjId))
 {
objRow[conCMFeatureRequirement.PrjId] = objCMFeatureRequirementEN.PrjId; //工程Id
 }
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.UpdDate))
 {
objRow[conCMFeatureRequirement.UpdDate] = objCMFeatureRequirementEN.UpdDate; //修改日期
 }
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.UpdUser))
 {
objRow[conCMFeatureRequirement.UpdUser] = objCMFeatureRequirementEN.UpdUser; //修改者
 }
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.Memo))
 {
objRow[conCMFeatureRequirement.Memo] = objCMFeatureRequirementEN.Memo; //说明
 }
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.IsSynchToServer))
 {
objRow[conCMFeatureRequirement.IsSynchToServer] = objCMFeatureRequirementEN.IsSynchToServer; //是否同步到Server
 }
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.SynchToServerDate))
 {
objRow[conCMFeatureRequirement.SynchToServerDate] = objCMFeatureRequirementEN.SynchToServerDate; //同步到Server日期
 }
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.SynchToServerUser))
 {
objRow[conCMFeatureRequirement.SynchToServerUser] = objCMFeatureRequirementEN.SynchToServerUser; //同步到Server用户
 }
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.IsSynchToClient))
 {
objRow[conCMFeatureRequirement.IsSynchToClient] = objCMFeatureRequirementEN.IsSynchToClient; //是否同步到Client
 }
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.SynchToClientDate))
 {
objRow[conCMFeatureRequirement.SynchToClientDate] = objCMFeatureRequirementEN.SynchToClientDate; //同步到Client库日期
 }
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.SynchToClientUser))
 {
objRow[conCMFeatureRequirement.SynchToClientUser] = objCMFeatureRequirementEN.SynchToClientUser; //同步到Client库用户
 }
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.SynSource))
 {
objRow[conCMFeatureRequirement.SynSource] = objCMFeatureRequirementEN.SynSource; //同步来源
 }
try
{
objDA.Update(objDS, clsCMFeatureRequirementEN._CurrTabName);
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
 /// <param name = "objCMFeatureRequirementEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCMFeatureRequirementEN objCMFeatureRequirementEN)
{
 objCMFeatureRequirementEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMFeatureRequirementEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCMFeatureRequirementEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureRequirementDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update CMFeatureRequirement Set ");
 
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.CmFeatureId))
 {
 if (objCMFeatureRequirementEN.CmFeatureId !=  null)
 {
 var strCmFeatureId = objCMFeatureRequirementEN.CmFeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCmFeatureId, conCMFeatureRequirement.CmFeatureId); //功能Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFeatureRequirement.CmFeatureId); //功能Id
 }
 }
 
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.ReqId))
 {
 if (objCMFeatureRequirementEN.ReqId !=  null)
 {
 var strReqId = objCMFeatureRequirementEN.ReqId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReqId, conCMFeatureRequirement.ReqId); //需求Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFeatureRequirement.ReqId); //需求Id
 }
 }
 
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objCMFeatureRequirementEN.OrderNum, conCMFeatureRequirement.OrderNum); //序号
 }
 
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.PrjId))
 {
 if (objCMFeatureRequirementEN.PrjId !=  null)
 {
 var strPrjId = objCMFeatureRequirementEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conCMFeatureRequirement.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFeatureRequirement.PrjId); //工程Id
 }
 }
 
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.UpdDate))
 {
 if (objCMFeatureRequirementEN.UpdDate !=  null)
 {
 var strUpdDate = objCMFeatureRequirementEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conCMFeatureRequirement.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFeatureRequirement.UpdDate); //修改日期
 }
 }
 
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.UpdUser))
 {
 if (objCMFeatureRequirementEN.UpdUser !=  null)
 {
 var strUpdUser = objCMFeatureRequirementEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conCMFeatureRequirement.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFeatureRequirement.UpdUser); //修改者
 }
 }
 
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.Memo))
 {
 if (objCMFeatureRequirementEN.Memo !=  null)
 {
 var strMemo = objCMFeatureRequirementEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCMFeatureRequirement.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFeatureRequirement.Memo); //说明
 }
 }
 
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.IsSynchToServer))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCMFeatureRequirementEN.IsSynchToServer == true?"1":"0", conCMFeatureRequirement.IsSynchToServer); //是否同步到Server
 }
 
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.SynchToServerDate))
 {
 if (objCMFeatureRequirementEN.SynchToServerDate !=  null)
 {
 var strSynchToServerDate = objCMFeatureRequirementEN.SynchToServerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSynchToServerDate, conCMFeatureRequirement.SynchToServerDate); //同步到Server日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFeatureRequirement.SynchToServerDate); //同步到Server日期
 }
 }
 
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.SynchToServerUser))
 {
 if (objCMFeatureRequirementEN.SynchToServerUser !=  null)
 {
 var strSynchToServerUser = objCMFeatureRequirementEN.SynchToServerUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSynchToServerUser, conCMFeatureRequirement.SynchToServerUser); //同步到Server用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFeatureRequirement.SynchToServerUser); //同步到Server用户
 }
 }
 
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.IsSynchToClient))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCMFeatureRequirementEN.IsSynchToClient == true?"1":"0", conCMFeatureRequirement.IsSynchToClient); //是否同步到Client
 }
 
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.SynchToClientDate))
 {
 if (objCMFeatureRequirementEN.SynchToClientDate !=  null)
 {
 var strSynchToClientDate = objCMFeatureRequirementEN.SynchToClientDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSynchToClientDate, conCMFeatureRequirement.SynchToClientDate); //同步到Client库日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFeatureRequirement.SynchToClientDate); //同步到Client库日期
 }
 }
 
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.SynchToClientUser))
 {
 if (objCMFeatureRequirementEN.SynchToClientUser !=  null)
 {
 var strSynchToClientUser = objCMFeatureRequirementEN.SynchToClientUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSynchToClientUser, conCMFeatureRequirement.SynchToClientUser); //同步到Client库用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFeatureRequirement.SynchToClientUser); //同步到Client库用户
 }
 }
 
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.SynSource))
 {
 if (objCMFeatureRequirementEN.SynSource !=  null)
 {
 var strSynSource = objCMFeatureRequirementEN.SynSource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSynSource, conCMFeatureRequirement.SynSource); //同步来源
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFeatureRequirement.SynSource); //同步来源
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objCMFeatureRequirementEN.mId); 
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
 /// <param name = "objCMFeatureRequirementEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsCMFeatureRequirementEN objCMFeatureRequirementEN, string strCondition)
{
 objCMFeatureRequirementEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMFeatureRequirementEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCMFeatureRequirementEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureRequirementDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CMFeatureRequirement Set ");
 
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.CmFeatureId))
 {
 if (objCMFeatureRequirementEN.CmFeatureId !=  null)
 {
 var strCmFeatureId = objCMFeatureRequirementEN.CmFeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CmFeatureId = '{0}',", strCmFeatureId); //功能Id
 }
 else
 {
 sbSQL.Append(" CmFeatureId = null,"); //功能Id
 }
 }
 
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.ReqId))
 {
 if (objCMFeatureRequirementEN.ReqId !=  null)
 {
 var strReqId = objCMFeatureRequirementEN.ReqId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReqId = '{0}',", strReqId); //需求Id
 }
 else
 {
 sbSQL.Append(" ReqId = null,"); //需求Id
 }
 }
 
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objCMFeatureRequirementEN.OrderNum); //序号
 }
 
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.PrjId))
 {
 if (objCMFeatureRequirementEN.PrjId !=  null)
 {
 var strPrjId = objCMFeatureRequirementEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.UpdDate))
 {
 if (objCMFeatureRequirementEN.UpdDate !=  null)
 {
 var strUpdDate = objCMFeatureRequirementEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.UpdUser))
 {
 if (objCMFeatureRequirementEN.UpdUser !=  null)
 {
 var strUpdUser = objCMFeatureRequirementEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.Memo))
 {
 if (objCMFeatureRequirementEN.Memo !=  null)
 {
 var strMemo = objCMFeatureRequirementEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //说明
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //说明
 }
 }
 
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.IsSynchToServer))
 {
 sbSQL.AppendFormat(" IsSynchToServer = '{0}',", objCMFeatureRequirementEN.IsSynchToServer == true?"1":"0"); //是否同步到Server
 }
 
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.SynchToServerDate))
 {
 if (objCMFeatureRequirementEN.SynchToServerDate !=  null)
 {
 var strSynchToServerDate = objCMFeatureRequirementEN.SynchToServerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynchToServerDate = '{0}',", strSynchToServerDate); //同步到Server日期
 }
 else
 {
 sbSQL.Append(" SynchToServerDate = null,"); //同步到Server日期
 }
 }
 
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.SynchToServerUser))
 {
 if (objCMFeatureRequirementEN.SynchToServerUser !=  null)
 {
 var strSynchToServerUser = objCMFeatureRequirementEN.SynchToServerUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynchToServerUser = '{0}',", strSynchToServerUser); //同步到Server用户
 }
 else
 {
 sbSQL.Append(" SynchToServerUser = null,"); //同步到Server用户
 }
 }
 
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.IsSynchToClient))
 {
 sbSQL.AppendFormat(" IsSynchToClient = '{0}',", objCMFeatureRequirementEN.IsSynchToClient == true?"1":"0"); //是否同步到Client
 }
 
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.SynchToClientDate))
 {
 if (objCMFeatureRequirementEN.SynchToClientDate !=  null)
 {
 var strSynchToClientDate = objCMFeatureRequirementEN.SynchToClientDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynchToClientDate = '{0}',", strSynchToClientDate); //同步到Client库日期
 }
 else
 {
 sbSQL.Append(" SynchToClientDate = null,"); //同步到Client库日期
 }
 }
 
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.SynchToClientUser))
 {
 if (objCMFeatureRequirementEN.SynchToClientUser !=  null)
 {
 var strSynchToClientUser = objCMFeatureRequirementEN.SynchToClientUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynchToClientUser = '{0}',", strSynchToClientUser); //同步到Client库用户
 }
 else
 {
 sbSQL.Append(" SynchToClientUser = null,"); //同步到Client库用户
 }
 }
 
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.SynSource))
 {
 if (objCMFeatureRequirementEN.SynSource !=  null)
 {
 var strSynSource = objCMFeatureRequirementEN.SynSource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objCMFeatureRequirementEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsCMFeatureRequirementEN objCMFeatureRequirementEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objCMFeatureRequirementEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMFeatureRequirementEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCMFeatureRequirementEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureRequirementDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CMFeatureRequirement Set ");
 
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.CmFeatureId))
 {
 if (objCMFeatureRequirementEN.CmFeatureId !=  null)
 {
 var strCmFeatureId = objCMFeatureRequirementEN.CmFeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CmFeatureId = '{0}',", strCmFeatureId); //功能Id
 }
 else
 {
 sbSQL.Append(" CmFeatureId = null,"); //功能Id
 }
 }
 
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.ReqId))
 {
 if (objCMFeatureRequirementEN.ReqId !=  null)
 {
 var strReqId = objCMFeatureRequirementEN.ReqId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReqId = '{0}',", strReqId); //需求Id
 }
 else
 {
 sbSQL.Append(" ReqId = null,"); //需求Id
 }
 }
 
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objCMFeatureRequirementEN.OrderNum); //序号
 }
 
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.PrjId))
 {
 if (objCMFeatureRequirementEN.PrjId !=  null)
 {
 var strPrjId = objCMFeatureRequirementEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.UpdDate))
 {
 if (objCMFeatureRequirementEN.UpdDate !=  null)
 {
 var strUpdDate = objCMFeatureRequirementEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.UpdUser))
 {
 if (objCMFeatureRequirementEN.UpdUser !=  null)
 {
 var strUpdUser = objCMFeatureRequirementEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.Memo))
 {
 if (objCMFeatureRequirementEN.Memo !=  null)
 {
 var strMemo = objCMFeatureRequirementEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //说明
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //说明
 }
 }
 
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.IsSynchToServer))
 {
 sbSQL.AppendFormat(" IsSynchToServer = '{0}',", objCMFeatureRequirementEN.IsSynchToServer == true?"1":"0"); //是否同步到Server
 }
 
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.SynchToServerDate))
 {
 if (objCMFeatureRequirementEN.SynchToServerDate !=  null)
 {
 var strSynchToServerDate = objCMFeatureRequirementEN.SynchToServerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynchToServerDate = '{0}',", strSynchToServerDate); //同步到Server日期
 }
 else
 {
 sbSQL.Append(" SynchToServerDate = null,"); //同步到Server日期
 }
 }
 
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.SynchToServerUser))
 {
 if (objCMFeatureRequirementEN.SynchToServerUser !=  null)
 {
 var strSynchToServerUser = objCMFeatureRequirementEN.SynchToServerUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynchToServerUser = '{0}',", strSynchToServerUser); //同步到Server用户
 }
 else
 {
 sbSQL.Append(" SynchToServerUser = null,"); //同步到Server用户
 }
 }
 
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.IsSynchToClient))
 {
 sbSQL.AppendFormat(" IsSynchToClient = '{0}',", objCMFeatureRequirementEN.IsSynchToClient == true?"1":"0"); //是否同步到Client
 }
 
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.SynchToClientDate))
 {
 if (objCMFeatureRequirementEN.SynchToClientDate !=  null)
 {
 var strSynchToClientDate = objCMFeatureRequirementEN.SynchToClientDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynchToClientDate = '{0}',", strSynchToClientDate); //同步到Client库日期
 }
 else
 {
 sbSQL.Append(" SynchToClientDate = null,"); //同步到Client库日期
 }
 }
 
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.SynchToClientUser))
 {
 if (objCMFeatureRequirementEN.SynchToClientUser !=  null)
 {
 var strSynchToClientUser = objCMFeatureRequirementEN.SynchToClientUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynchToClientUser = '{0}',", strSynchToClientUser); //同步到Client库用户
 }
 else
 {
 sbSQL.Append(" SynchToClientUser = null,"); //同步到Client库用户
 }
 }
 
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.SynSource))
 {
 if (objCMFeatureRequirementEN.SynSource !=  null)
 {
 var strSynSource = objCMFeatureRequirementEN.SynSource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objCMFeatureRequirementEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCMFeatureRequirementEN objCMFeatureRequirementEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objCMFeatureRequirementEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMFeatureRequirementEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCMFeatureRequirementEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureRequirementDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CMFeatureRequirement Set ");
 
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.CmFeatureId))
 {
 if (objCMFeatureRequirementEN.CmFeatureId !=  null)
 {
 var strCmFeatureId = objCMFeatureRequirementEN.CmFeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCmFeatureId, conCMFeatureRequirement.CmFeatureId); //功能Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFeatureRequirement.CmFeatureId); //功能Id
 }
 }
 
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.ReqId))
 {
 if (objCMFeatureRequirementEN.ReqId !=  null)
 {
 var strReqId = objCMFeatureRequirementEN.ReqId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReqId, conCMFeatureRequirement.ReqId); //需求Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFeatureRequirement.ReqId); //需求Id
 }
 }
 
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objCMFeatureRequirementEN.OrderNum, conCMFeatureRequirement.OrderNum); //序号
 }
 
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.PrjId))
 {
 if (objCMFeatureRequirementEN.PrjId !=  null)
 {
 var strPrjId = objCMFeatureRequirementEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conCMFeatureRequirement.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFeatureRequirement.PrjId); //工程Id
 }
 }
 
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.UpdDate))
 {
 if (objCMFeatureRequirementEN.UpdDate !=  null)
 {
 var strUpdDate = objCMFeatureRequirementEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conCMFeatureRequirement.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFeatureRequirement.UpdDate); //修改日期
 }
 }
 
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.UpdUser))
 {
 if (objCMFeatureRequirementEN.UpdUser !=  null)
 {
 var strUpdUser = objCMFeatureRequirementEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conCMFeatureRequirement.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFeatureRequirement.UpdUser); //修改者
 }
 }
 
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.Memo))
 {
 if (objCMFeatureRequirementEN.Memo !=  null)
 {
 var strMemo = objCMFeatureRequirementEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCMFeatureRequirement.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFeatureRequirement.Memo); //说明
 }
 }
 
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.IsSynchToServer))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCMFeatureRequirementEN.IsSynchToServer == true?"1":"0", conCMFeatureRequirement.IsSynchToServer); //是否同步到Server
 }
 
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.SynchToServerDate))
 {
 if (objCMFeatureRequirementEN.SynchToServerDate !=  null)
 {
 var strSynchToServerDate = objCMFeatureRequirementEN.SynchToServerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSynchToServerDate, conCMFeatureRequirement.SynchToServerDate); //同步到Server日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFeatureRequirement.SynchToServerDate); //同步到Server日期
 }
 }
 
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.SynchToServerUser))
 {
 if (objCMFeatureRequirementEN.SynchToServerUser !=  null)
 {
 var strSynchToServerUser = objCMFeatureRequirementEN.SynchToServerUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSynchToServerUser, conCMFeatureRequirement.SynchToServerUser); //同步到Server用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFeatureRequirement.SynchToServerUser); //同步到Server用户
 }
 }
 
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.IsSynchToClient))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCMFeatureRequirementEN.IsSynchToClient == true?"1":"0", conCMFeatureRequirement.IsSynchToClient); //是否同步到Client
 }
 
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.SynchToClientDate))
 {
 if (objCMFeatureRequirementEN.SynchToClientDate !=  null)
 {
 var strSynchToClientDate = objCMFeatureRequirementEN.SynchToClientDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSynchToClientDate, conCMFeatureRequirement.SynchToClientDate); //同步到Client库日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFeatureRequirement.SynchToClientDate); //同步到Client库日期
 }
 }
 
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.SynchToClientUser))
 {
 if (objCMFeatureRequirementEN.SynchToClientUser !=  null)
 {
 var strSynchToClientUser = objCMFeatureRequirementEN.SynchToClientUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSynchToClientUser, conCMFeatureRequirement.SynchToClientUser); //同步到Client库用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFeatureRequirement.SynchToClientUser); //同步到Client库用户
 }
 }
 
 if (objCMFeatureRequirementEN.IsUpdated(conCMFeatureRequirement.SynSource))
 {
 if (objCMFeatureRequirementEN.SynSource !=  null)
 {
 var strSynSource = objCMFeatureRequirementEN.SynSource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSynSource, conCMFeatureRequirement.SynSource); //同步来源
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFeatureRequirement.SynSource); //同步来源
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objCMFeatureRequirementEN.mId); 
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngmId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureRequirementDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("CMFeatureRequirement_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngmId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureRequirementDA.GetSpecSQLObj();
//删除CMFeatureRequirement本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CMFeatureRequirement where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelCMFeatureRequirement(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureRequirementDA.GetSpecSQLObj();
string strSQL;
string strKeyList;
if (lstKey.Count  == 0) return 0;
strKeyList = "";
for (int i = 0; i<lstKey.Count; i++)
{
if (i == 0) strKeyList = strKeyList + "" + lstKey[i].ToString() + "";
else strKeyList +=  "," + "" + lstKey[i].ToString() + "";
}
strSQL = "";
//删除CMFeatureRequirement本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CMFeatureRequirement where mId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngmId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureRequirementDA.GetSpecSQLObj();
//删除CMFeatureRequirement本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CMFeatureRequirement where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelCMFeatureRequirement(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsCMFeatureRequirementDA: DelCMFeatureRequirement)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureRequirementDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CMFeatureRequirement where " + strCondition ;
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
public bool DelCMFeatureRequirementWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsCMFeatureRequirementDA: DelCMFeatureRequirementWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureRequirementDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CMFeatureRequirement where " + strCondition ;
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
 /// <param name = "objCMFeatureRequirementENS">源对象</param>
 /// <param name = "objCMFeatureRequirementENT">目标对象</param>
public void CopyTo(clsCMFeatureRequirementEN objCMFeatureRequirementENS, clsCMFeatureRequirementEN objCMFeatureRequirementENT)
{
objCMFeatureRequirementENT.mId = objCMFeatureRequirementENS.mId; //mId
objCMFeatureRequirementENT.CmFeatureId = objCMFeatureRequirementENS.CmFeatureId; //功能Id
objCMFeatureRequirementENT.ReqId = objCMFeatureRequirementENS.ReqId; //需求Id
objCMFeatureRequirementENT.OrderNum = objCMFeatureRequirementENS.OrderNum; //序号
objCMFeatureRequirementENT.PrjId = objCMFeatureRequirementENS.PrjId; //工程Id
objCMFeatureRequirementENT.UpdDate = objCMFeatureRequirementENS.UpdDate; //修改日期
objCMFeatureRequirementENT.UpdUser = objCMFeatureRequirementENS.UpdUser; //修改者
objCMFeatureRequirementENT.Memo = objCMFeatureRequirementENS.Memo; //说明
objCMFeatureRequirementENT.IsSynchToServer = objCMFeatureRequirementENS.IsSynchToServer; //是否同步到Server
objCMFeatureRequirementENT.SynchToServerDate = objCMFeatureRequirementENS.SynchToServerDate; //同步到Server日期
objCMFeatureRequirementENT.SynchToServerUser = objCMFeatureRequirementENS.SynchToServerUser; //同步到Server用户
objCMFeatureRequirementENT.IsSynchToClient = objCMFeatureRequirementENS.IsSynchToClient; //是否同步到Client
objCMFeatureRequirementENT.SynchToClientDate = objCMFeatureRequirementENS.SynchToClientDate; //同步到Client库日期
objCMFeatureRequirementENT.SynchToClientUser = objCMFeatureRequirementENS.SynchToClientUser; //同步到Client库用户
objCMFeatureRequirementENT.SynSource = objCMFeatureRequirementENS.SynSource; //同步来源
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsCMFeatureRequirementEN objCMFeatureRequirementEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objCMFeatureRequirementEN.CmFeatureId, conCMFeatureRequirement.CmFeatureId);
clsCheckSql.CheckFieldNotNull(objCMFeatureRequirementEN.ReqId, conCMFeatureRequirement.ReqId);
clsCheckSql.CheckFieldNotNull(objCMFeatureRequirementEN.OrderNum, conCMFeatureRequirement.OrderNum);
clsCheckSql.CheckFieldNotNull(objCMFeatureRequirementEN.PrjId, conCMFeatureRequirement.PrjId);
//检查字段长度
clsCheckSql.CheckFieldLen(objCMFeatureRequirementEN.CmFeatureId, 8, conCMFeatureRequirement.CmFeatureId);
clsCheckSql.CheckFieldLen(objCMFeatureRequirementEN.ReqId, 8, conCMFeatureRequirement.ReqId);
clsCheckSql.CheckFieldLen(objCMFeatureRequirementEN.PrjId, 4, conCMFeatureRequirement.PrjId);
clsCheckSql.CheckFieldLen(objCMFeatureRequirementEN.UpdDate, 20, conCMFeatureRequirement.UpdDate);
clsCheckSql.CheckFieldLen(objCMFeatureRequirementEN.UpdUser, 20, conCMFeatureRequirement.UpdUser);
clsCheckSql.CheckFieldLen(objCMFeatureRequirementEN.Memo, 1000, conCMFeatureRequirement.Memo);
clsCheckSql.CheckFieldLen(objCMFeatureRequirementEN.SynchToServerDate, 20, conCMFeatureRequirement.SynchToServerDate);
clsCheckSql.CheckFieldLen(objCMFeatureRequirementEN.SynchToServerUser, 20, conCMFeatureRequirement.SynchToServerUser);
clsCheckSql.CheckFieldLen(objCMFeatureRequirementEN.SynchToClientDate, 20, conCMFeatureRequirement.SynchToClientDate);
clsCheckSql.CheckFieldLen(objCMFeatureRequirementEN.SynchToClientUser, 20, conCMFeatureRequirement.SynchToClientUser);
clsCheckSql.CheckFieldLen(objCMFeatureRequirementEN.SynSource, 50, conCMFeatureRequirement.SynSource);
//检查字段外键固定长度
 objCMFeatureRequirementEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsCMFeatureRequirementEN objCMFeatureRequirementEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCMFeatureRequirementEN.CmFeatureId, 8, conCMFeatureRequirement.CmFeatureId);
clsCheckSql.CheckFieldLen(objCMFeatureRequirementEN.ReqId, 8, conCMFeatureRequirement.ReqId);
clsCheckSql.CheckFieldLen(objCMFeatureRequirementEN.PrjId, 4, conCMFeatureRequirement.PrjId);
clsCheckSql.CheckFieldLen(objCMFeatureRequirementEN.UpdDate, 20, conCMFeatureRequirement.UpdDate);
clsCheckSql.CheckFieldLen(objCMFeatureRequirementEN.UpdUser, 20, conCMFeatureRequirement.UpdUser);
clsCheckSql.CheckFieldLen(objCMFeatureRequirementEN.Memo, 1000, conCMFeatureRequirement.Memo);
clsCheckSql.CheckFieldLen(objCMFeatureRequirementEN.SynchToServerDate, 20, conCMFeatureRequirement.SynchToServerDate);
clsCheckSql.CheckFieldLen(objCMFeatureRequirementEN.SynchToServerUser, 20, conCMFeatureRequirement.SynchToServerUser);
clsCheckSql.CheckFieldLen(objCMFeatureRequirementEN.SynchToClientDate, 20, conCMFeatureRequirement.SynchToClientDate);
clsCheckSql.CheckFieldLen(objCMFeatureRequirementEN.SynchToClientUser, 20, conCMFeatureRequirement.SynchToClientUser);
clsCheckSql.CheckFieldLen(objCMFeatureRequirementEN.SynSource, 50, conCMFeatureRequirement.SynSource);
//检查外键字段长度
 objCMFeatureRequirementEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsCMFeatureRequirementEN objCMFeatureRequirementEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCMFeatureRequirementEN.CmFeatureId, 8, conCMFeatureRequirement.CmFeatureId);
clsCheckSql.CheckFieldLen(objCMFeatureRequirementEN.ReqId, 8, conCMFeatureRequirement.ReqId);
clsCheckSql.CheckFieldLen(objCMFeatureRequirementEN.PrjId, 4, conCMFeatureRequirement.PrjId);
clsCheckSql.CheckFieldLen(objCMFeatureRequirementEN.UpdDate, 20, conCMFeatureRequirement.UpdDate);
clsCheckSql.CheckFieldLen(objCMFeatureRequirementEN.UpdUser, 20, conCMFeatureRequirement.UpdUser);
clsCheckSql.CheckFieldLen(objCMFeatureRequirementEN.Memo, 1000, conCMFeatureRequirement.Memo);
clsCheckSql.CheckFieldLen(objCMFeatureRequirementEN.SynchToServerDate, 20, conCMFeatureRequirement.SynchToServerDate);
clsCheckSql.CheckFieldLen(objCMFeatureRequirementEN.SynchToServerUser, 20, conCMFeatureRequirement.SynchToServerUser);
clsCheckSql.CheckFieldLen(objCMFeatureRequirementEN.SynchToClientDate, 20, conCMFeatureRequirement.SynchToClientDate);
clsCheckSql.CheckFieldLen(objCMFeatureRequirementEN.SynchToClientUser, 20, conCMFeatureRequirement.SynchToClientUser);
clsCheckSql.CheckFieldLen(objCMFeatureRequirementEN.SynSource, 50, conCMFeatureRequirement.SynSource);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objCMFeatureRequirementEN.CmFeatureId, conCMFeatureRequirement.CmFeatureId);
clsCheckSql.CheckSqlInjection4Field(objCMFeatureRequirementEN.ReqId, conCMFeatureRequirement.ReqId);
clsCheckSql.CheckSqlInjection4Field(objCMFeatureRequirementEN.PrjId, conCMFeatureRequirement.PrjId);
clsCheckSql.CheckSqlInjection4Field(objCMFeatureRequirementEN.UpdDate, conCMFeatureRequirement.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objCMFeatureRequirementEN.UpdUser, conCMFeatureRequirement.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objCMFeatureRequirementEN.Memo, conCMFeatureRequirement.Memo);
clsCheckSql.CheckSqlInjection4Field(objCMFeatureRequirementEN.SynchToServerDate, conCMFeatureRequirement.SynchToServerDate);
clsCheckSql.CheckSqlInjection4Field(objCMFeatureRequirementEN.SynchToServerUser, conCMFeatureRequirement.SynchToServerUser);
clsCheckSql.CheckSqlInjection4Field(objCMFeatureRequirementEN.SynchToClientDate, conCMFeatureRequirement.SynchToClientDate);
clsCheckSql.CheckSqlInjection4Field(objCMFeatureRequirementEN.SynchToClientUser, conCMFeatureRequirement.SynchToClientUser);
clsCheckSql.CheckSqlInjection4Field(objCMFeatureRequirementEN.SynSource, conCMFeatureRequirement.SynSource);
//检查外键字段长度
 objCMFeatureRequirementEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--CMFeatureRequirement(CM功能需求关系),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objCMFeatureRequirementEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsCMFeatureRequirementEN objCMFeatureRequirementEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CmFeatureId = '{0}'", objCMFeatureRequirementEN.CmFeatureId);
 sbCondition.AppendFormat(" and ReqId = '{0}'", objCMFeatureRequirementEN.ReqId);
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
 objSQL = clsCMFeatureRequirementDA.GetSpecSQLObj();
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
 objSQL = clsCMFeatureRequirementDA.GetSpecSQLObj();
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
 objSQL = clsCMFeatureRequirementDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCMFeatureRequirementEN._CurrTabName);
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
 objSQL = clsCMFeatureRequirementDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCMFeatureRequirementEN._CurrTabName, strCondition);
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
 objSQL = clsCMFeatureRequirementDA.GetSpecSQLObj();
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
 objSQL = clsCMFeatureRequirementDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}