
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCMRequirementDA
 表名:vCMRequirement(00050260)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:11:38
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
 /// vCM需求(vCMRequirement)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvCMRequirementDA : clsCommBase4DA
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
 return clsvCMRequirementEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvCMRequirementEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCMRequirementEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvCMRequirementEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvCMRequirementEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vCMRequirement中,检查关键字,长度不正确!(clsvCMRequirementDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strReqId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vCMRequirement中,关键字不能为空 或 null!(clsvCMRequirementDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strReqId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvCMRequirementDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvCMRequirementDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMRequirementDA.GetSpecSQLObj();
strSQL = "Select * from vCMRequirement where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vCMRequirement(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvCMRequirementDA: GetDataTable_vCMRequirement)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMRequirementDA.GetSpecSQLObj();
strSQL = "Select * from vCMRequirement where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvCMRequirementDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMRequirementDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvCMRequirementDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMRequirementDA.GetSpecSQLObj();
strSQL = "Select * from vCMRequirement where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvCMRequirementDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMRequirementDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvCMRequirementDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMRequirementDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCMRequirement where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCMRequirement where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvCMRequirementDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMRequirementDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vCMRequirement where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvCMRequirementDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMRequirementDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vCMRequirement.* " + 
$"from vCMRequirement " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vCMRequirement.ReqId not in " + 
$"(Select top {intTop_In} vCMRequirement.ReqId from vCMRequirement " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCMRequirement where {1} and ReqId not in (Select top {2} ReqId from vCMRequirement where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCMRequirement where {1} and ReqId not in (Select top {3} ReqId from vCMRequirement where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvCMRequirementDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMRequirementDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vCMRequirement.* " + 
$"from vCMRequirement " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vCMRequirement.ReqId not in " + 
$"(Select top {intTop_In} vCMRequirement.ReqId from vCMRequirement " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCMRequirement where {1} and ReqId not in (Select top {2} ReqId from vCMRequirement where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCMRequirement where {1} and ReqId not in (Select top {3} ReqId from vCMRequirement where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvCMRequirementEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvCMRequirementDA:GetObjLst)", objException.Message));
}
List<clsvCMRequirementEN> arrObjLst = new List<clsvCMRequirementEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMRequirementDA.GetSpecSQLObj();
strSQL = "Select * from vCMRequirement where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMRequirementEN objvCMRequirementEN = new clsvCMRequirementEN();
try
{
objvCMRequirementEN.ReqId = objRow[convCMRequirement.ReqId].ToString().Trim(); //需求Id
objvCMRequirementEN.RequirementName = objRow[convCMRequirement.RequirementName].ToString().Trim(); //需求名称
objvCMRequirementEN.FuncModuleAgcId = objRow[convCMRequirement.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCMRequirement.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMRequirementEN.FuncModuleName = objRow[convCMRequirement.FuncModuleName] == DBNull.Value ? null : objRow[convCMRequirement.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMRequirementEN.ReqContent = objRow[convCMRequirement.ReqContent].ToString().Trim(); //需求内容
objvCMRequirementEN.UpReqId = objRow[convCMRequirement.UpReqId].ToString().Trim(); //上级需求Id
objvCMRequirementEN.RequirementTypeId = objRow[convCMRequirement.RequirementTypeId].ToString().Trim(); //需求类型Id
objvCMRequirementEN.RequirementTypeName = objRow[convCMRequirement.RequirementTypeName] == DBNull.Value ? null : objRow[convCMRequirement.RequirementTypeName].ToString().Trim(); //需求类型名
objvCMRequirementEN.IsFinished = TransNullToBool(objRow[convCMRequirement.IsFinished].ToString().Trim()); //是否完成
objvCMRequirementEN.CmPrjId = objRow[convCMRequirement.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMRequirementEN.CmPrjName = objRow[convCMRequirement.CmPrjName] == DBNull.Value ? null : objRow[convCMRequirement.CmPrjName].ToString().Trim(); //CM工程名
objvCMRequirementEN.PrjId = objRow[convCMRequirement.PrjId] == DBNull.Value ? null : objRow[convCMRequirement.PrjId].ToString().Trim(); //工程Id
objvCMRequirementEN.PrjName = objRow[convCMRequirement.PrjName] == DBNull.Value ? null : objRow[convCMRequirement.PrjName].ToString().Trim(); //工程名称
objvCMRequirementEN.ApplicationTypeId = objRow[convCMRequirement.ApplicationTypeId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCMRequirement.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMRequirementEN.ApplicationTypeSimName = objRow[convCMRequirement.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMRequirement.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMRequirementEN.ProjectFileName = objRow[convCMRequirement.ProjectFileName] == DBNull.Value ? null : objRow[convCMRequirement.ProjectFileName].ToString().Trim(); //工程文件名
objvCMRequirementEN.UpdUser = objRow[convCMRequirement.UpdUser] == DBNull.Value ? null : objRow[convCMRequirement.UpdUser].ToString().Trim(); //修改者
objvCMRequirementEN.UpdDate = objRow[convCMRequirement.UpdDate] == DBNull.Value ? null : objRow[convCMRequirement.UpdDate].ToString().Trim(); //修改日期
objvCMRequirementEN.Memo = objRow[convCMRequirement.Memo] == DBNull.Value ? null : objRow[convCMRequirement.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCMRequirementDA: GetObjLst)", objException.Message));
}
objvCMRequirementEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCMRequirementEN);
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
public List<clsvCMRequirementEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvCMRequirementDA:GetObjLstByTabName)", objException.Message));
}
List<clsvCMRequirementEN> arrObjLst = new List<clsvCMRequirementEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMRequirementDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMRequirementEN objvCMRequirementEN = new clsvCMRequirementEN();
try
{
objvCMRequirementEN.ReqId = objRow[convCMRequirement.ReqId].ToString().Trim(); //需求Id
objvCMRequirementEN.RequirementName = objRow[convCMRequirement.RequirementName].ToString().Trim(); //需求名称
objvCMRequirementEN.FuncModuleAgcId = objRow[convCMRequirement.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCMRequirement.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMRequirementEN.FuncModuleName = objRow[convCMRequirement.FuncModuleName] == DBNull.Value ? null : objRow[convCMRequirement.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMRequirementEN.ReqContent = objRow[convCMRequirement.ReqContent].ToString().Trim(); //需求内容
objvCMRequirementEN.UpReqId = objRow[convCMRequirement.UpReqId].ToString().Trim(); //上级需求Id
objvCMRequirementEN.RequirementTypeId = objRow[convCMRequirement.RequirementTypeId].ToString().Trim(); //需求类型Id
objvCMRequirementEN.RequirementTypeName = objRow[convCMRequirement.RequirementTypeName] == DBNull.Value ? null : objRow[convCMRequirement.RequirementTypeName].ToString().Trim(); //需求类型名
objvCMRequirementEN.IsFinished = TransNullToBool(objRow[convCMRequirement.IsFinished].ToString().Trim()); //是否完成
objvCMRequirementEN.CmPrjId = objRow[convCMRequirement.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMRequirementEN.CmPrjName = objRow[convCMRequirement.CmPrjName] == DBNull.Value ? null : objRow[convCMRequirement.CmPrjName].ToString().Trim(); //CM工程名
objvCMRequirementEN.PrjId = objRow[convCMRequirement.PrjId] == DBNull.Value ? null : objRow[convCMRequirement.PrjId].ToString().Trim(); //工程Id
objvCMRequirementEN.PrjName = objRow[convCMRequirement.PrjName] == DBNull.Value ? null : objRow[convCMRequirement.PrjName].ToString().Trim(); //工程名称
objvCMRequirementEN.ApplicationTypeId = objRow[convCMRequirement.ApplicationTypeId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCMRequirement.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMRequirementEN.ApplicationTypeSimName = objRow[convCMRequirement.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMRequirement.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMRequirementEN.ProjectFileName = objRow[convCMRequirement.ProjectFileName] == DBNull.Value ? null : objRow[convCMRequirement.ProjectFileName].ToString().Trim(); //工程文件名
objvCMRequirementEN.UpdUser = objRow[convCMRequirement.UpdUser] == DBNull.Value ? null : objRow[convCMRequirement.UpdUser].ToString().Trim(); //修改者
objvCMRequirementEN.UpdDate = objRow[convCMRequirement.UpdDate] == DBNull.Value ? null : objRow[convCMRequirement.UpdDate].ToString().Trim(); //修改日期
objvCMRequirementEN.Memo = objRow[convCMRequirement.Memo] == DBNull.Value ? null : objRow[convCMRequirement.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCMRequirementDA: GetObjLst)", objException.Message));
}
objvCMRequirementEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCMRequirementEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvCMRequirementEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvCMRequirement(ref clsvCMRequirementEN objvCMRequirementEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMRequirementDA.GetSpecSQLObj();
strSQL = "Select * from vCMRequirement where ReqId = " + "'"+ objvCMRequirementEN.ReqId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvCMRequirementEN.ReqId = objDT.Rows[0][convCMRequirement.ReqId].ToString().Trim(); //需求Id(字段类型:char,字段长度:8,是否可空:False)
 objvCMRequirementEN.RequirementName = objDT.Rows[0][convCMRequirement.RequirementName].ToString().Trim(); //需求名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCMRequirementEN.FuncModuleAgcId = objDT.Rows[0][convCMRequirement.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvCMRequirementEN.FuncModuleName = objDT.Rows[0][convCMRequirement.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCMRequirementEN.ReqContent = objDT.Rows[0][convCMRequirement.ReqContent].ToString().Trim(); //需求内容(字段类型:varchar,字段长度:4000,是否可空:False)
 objvCMRequirementEN.UpReqId = objDT.Rows[0][convCMRequirement.UpReqId].ToString().Trim(); //上级需求Id(字段类型:char,字段长度:8,是否可空:False)
 objvCMRequirementEN.RequirementTypeId = objDT.Rows[0][convCMRequirement.RequirementTypeId].ToString().Trim(); //需求类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvCMRequirementEN.RequirementTypeName = objDT.Rows[0][convCMRequirement.RequirementTypeName].ToString().Trim(); //需求类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvCMRequirementEN.IsFinished = TransNullToBool(objDT.Rows[0][convCMRequirement.IsFinished].ToString().Trim()); //是否完成(字段类型:bit,字段长度:1,是否可空:True)
 objvCMRequirementEN.CmPrjId = objDT.Rows[0][convCMRequirement.CmPrjId].ToString().Trim(); //Cm工程Id(字段类型:char,字段长度:6,是否可空:False)
 objvCMRequirementEN.CmPrjName = objDT.Rows[0][convCMRequirement.CmPrjName].ToString().Trim(); //CM工程名(字段类型:varchar,字段长度:50,是否可空:True)
 objvCMRequirementEN.PrjId = objDT.Rows[0][convCMRequirement.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvCMRequirementEN.PrjName = objDT.Rows[0][convCMRequirement.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCMRequirementEN.ApplicationTypeId = TransNullToInt(objDT.Rows[0][convCMRequirement.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objvCMRequirementEN.ApplicationTypeSimName = objDT.Rows[0][convCMRequirement.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvCMRequirementEN.ProjectFileName = objDT.Rows[0][convCMRequirement.ProjectFileName].ToString().Trim(); //工程文件名(字段类型:varchar,字段长度:200,是否可空:False)
 objvCMRequirementEN.UpdUser = objDT.Rows[0][convCMRequirement.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvCMRequirementEN.UpdDate = objDT.Rows[0][convCMRequirement.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCMRequirementEN.Memo = objDT.Rows[0][convCMRequirement.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvCMRequirementDA: GetvCMRequirement)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strReqId">表关键字</param>
 /// <returns>表对象</returns>
public clsvCMRequirementEN GetObjByReqId(string strReqId)
{
CheckPrimaryKey(strReqId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMRequirementDA.GetSpecSQLObj();
strSQL = "Select * from vCMRequirement where ReqId = " + "'"+ strReqId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvCMRequirementEN objvCMRequirementEN = new clsvCMRequirementEN();
try
{
 objvCMRequirementEN.ReqId = objRow[convCMRequirement.ReqId].ToString().Trim(); //需求Id(字段类型:char,字段长度:8,是否可空:False)
 objvCMRequirementEN.RequirementName = objRow[convCMRequirement.RequirementName].ToString().Trim(); //需求名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCMRequirementEN.FuncModuleAgcId = objRow[convCMRequirement.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCMRequirement.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvCMRequirementEN.FuncModuleName = objRow[convCMRequirement.FuncModuleName] == DBNull.Value ? null : objRow[convCMRequirement.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCMRequirementEN.ReqContent = objRow[convCMRequirement.ReqContent].ToString().Trim(); //需求内容(字段类型:varchar,字段长度:4000,是否可空:False)
 objvCMRequirementEN.UpReqId = objRow[convCMRequirement.UpReqId].ToString().Trim(); //上级需求Id(字段类型:char,字段长度:8,是否可空:False)
 objvCMRequirementEN.RequirementTypeId = objRow[convCMRequirement.RequirementTypeId].ToString().Trim(); //需求类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvCMRequirementEN.RequirementTypeName = objRow[convCMRequirement.RequirementTypeName] == DBNull.Value ? null : objRow[convCMRequirement.RequirementTypeName].ToString().Trim(); //需求类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvCMRequirementEN.IsFinished = clsEntityBase2.TransNullToBool_S(objRow[convCMRequirement.IsFinished].ToString().Trim()); //是否完成(字段类型:bit,字段长度:1,是否可空:True)
 objvCMRequirementEN.CmPrjId = objRow[convCMRequirement.CmPrjId].ToString().Trim(); //Cm工程Id(字段类型:char,字段长度:6,是否可空:False)
 objvCMRequirementEN.CmPrjName = objRow[convCMRequirement.CmPrjName] == DBNull.Value ? null : objRow[convCMRequirement.CmPrjName].ToString().Trim(); //CM工程名(字段类型:varchar,字段长度:50,是否可空:True)
 objvCMRequirementEN.PrjId = objRow[convCMRequirement.PrjId] == DBNull.Value ? null : objRow[convCMRequirement.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvCMRequirementEN.PrjName = objRow[convCMRequirement.PrjName] == DBNull.Value ? null : objRow[convCMRequirement.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCMRequirementEN.ApplicationTypeId = objRow[convCMRequirement.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMRequirement.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objvCMRequirementEN.ApplicationTypeSimName = objRow[convCMRequirement.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMRequirement.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvCMRequirementEN.ProjectFileName = objRow[convCMRequirement.ProjectFileName] == DBNull.Value ? null : objRow[convCMRequirement.ProjectFileName].ToString().Trim(); //工程文件名(字段类型:varchar,字段长度:200,是否可空:False)
 objvCMRequirementEN.UpdUser = objRow[convCMRequirement.UpdUser] == DBNull.Value ? null : objRow[convCMRequirement.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvCMRequirementEN.UpdDate = objRow[convCMRequirement.UpdDate] == DBNull.Value ? null : objRow[convCMRequirement.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCMRequirementEN.Memo = objRow[convCMRequirement.Memo] == DBNull.Value ? null : objRow[convCMRequirement.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvCMRequirementDA: GetObjByReqId)", objException.Message));
}
return objvCMRequirementEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvCMRequirementEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvCMRequirementDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMRequirementDA.GetSpecSQLObj();
strSQL = "Select * from vCMRequirement where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvCMRequirementEN objvCMRequirementEN = new clsvCMRequirementEN()
{
ReqId = objRow[convCMRequirement.ReqId].ToString().Trim(), //需求Id
RequirementName = objRow[convCMRequirement.RequirementName].ToString().Trim(), //需求名称
FuncModuleAgcId = objRow[convCMRequirement.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCMRequirement.FuncModuleAgcId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convCMRequirement.FuncModuleName] == DBNull.Value ? null : objRow[convCMRequirement.FuncModuleName].ToString().Trim(), //功能模块名称
ReqContent = objRow[convCMRequirement.ReqContent].ToString().Trim(), //需求内容
UpReqId = objRow[convCMRequirement.UpReqId].ToString().Trim(), //上级需求Id
RequirementTypeId = objRow[convCMRequirement.RequirementTypeId].ToString().Trim(), //需求类型Id
RequirementTypeName = objRow[convCMRequirement.RequirementTypeName] == DBNull.Value ? null : objRow[convCMRequirement.RequirementTypeName].ToString().Trim(), //需求类型名
IsFinished = TransNullToBool(objRow[convCMRequirement.IsFinished].ToString().Trim()), //是否完成
CmPrjId = objRow[convCMRequirement.CmPrjId].ToString().Trim(), //Cm工程Id
CmPrjName = objRow[convCMRequirement.CmPrjName] == DBNull.Value ? null : objRow[convCMRequirement.CmPrjName].ToString().Trim(), //CM工程名
PrjId = objRow[convCMRequirement.PrjId] == DBNull.Value ? null : objRow[convCMRequirement.PrjId].ToString().Trim(), //工程Id
PrjName = objRow[convCMRequirement.PrjName] == DBNull.Value ? null : objRow[convCMRequirement.PrjName].ToString().Trim(), //工程名称
ApplicationTypeId = objRow[convCMRequirement.ApplicationTypeId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCMRequirement.ApplicationTypeId].ToString().Trim()), //应用程序类型ID
ApplicationTypeSimName = objRow[convCMRequirement.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMRequirement.ApplicationTypeSimName].ToString().Trim(), //应用程序类型简称
ProjectFileName = objRow[convCMRequirement.ProjectFileName] == DBNull.Value ? null : objRow[convCMRequirement.ProjectFileName].ToString().Trim(), //工程文件名
UpdUser = objRow[convCMRequirement.UpdUser] == DBNull.Value ? null : objRow[convCMRequirement.UpdUser].ToString().Trim(), //修改者
UpdDate = objRow[convCMRequirement.UpdDate] == DBNull.Value ? null : objRow[convCMRequirement.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convCMRequirement.Memo] == DBNull.Value ? null : objRow[convCMRequirement.Memo].ToString().Trim() //说明
};
objvCMRequirementEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCMRequirementEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvCMRequirementDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvCMRequirementEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCMRequirementEN objvCMRequirementEN = new clsvCMRequirementEN();
try
{
objvCMRequirementEN.ReqId = objRow[convCMRequirement.ReqId].ToString().Trim(); //需求Id
objvCMRequirementEN.RequirementName = objRow[convCMRequirement.RequirementName].ToString().Trim(); //需求名称
objvCMRequirementEN.FuncModuleAgcId = objRow[convCMRequirement.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCMRequirement.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMRequirementEN.FuncModuleName = objRow[convCMRequirement.FuncModuleName] == DBNull.Value ? null : objRow[convCMRequirement.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMRequirementEN.ReqContent = objRow[convCMRequirement.ReqContent].ToString().Trim(); //需求内容
objvCMRequirementEN.UpReqId = objRow[convCMRequirement.UpReqId].ToString().Trim(); //上级需求Id
objvCMRequirementEN.RequirementTypeId = objRow[convCMRequirement.RequirementTypeId].ToString().Trim(); //需求类型Id
objvCMRequirementEN.RequirementTypeName = objRow[convCMRequirement.RequirementTypeName] == DBNull.Value ? null : objRow[convCMRequirement.RequirementTypeName].ToString().Trim(); //需求类型名
objvCMRequirementEN.IsFinished = TransNullToBool(objRow[convCMRequirement.IsFinished].ToString().Trim()); //是否完成
objvCMRequirementEN.CmPrjId = objRow[convCMRequirement.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMRequirementEN.CmPrjName = objRow[convCMRequirement.CmPrjName] == DBNull.Value ? null : objRow[convCMRequirement.CmPrjName].ToString().Trim(); //CM工程名
objvCMRequirementEN.PrjId = objRow[convCMRequirement.PrjId] == DBNull.Value ? null : objRow[convCMRequirement.PrjId].ToString().Trim(); //工程Id
objvCMRequirementEN.PrjName = objRow[convCMRequirement.PrjName] == DBNull.Value ? null : objRow[convCMRequirement.PrjName].ToString().Trim(); //工程名称
objvCMRequirementEN.ApplicationTypeId = objRow[convCMRequirement.ApplicationTypeId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCMRequirement.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMRequirementEN.ApplicationTypeSimName = objRow[convCMRequirement.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMRequirement.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMRequirementEN.ProjectFileName = objRow[convCMRequirement.ProjectFileName] == DBNull.Value ? null : objRow[convCMRequirement.ProjectFileName].ToString().Trim(); //工程文件名
objvCMRequirementEN.UpdUser = objRow[convCMRequirement.UpdUser] == DBNull.Value ? null : objRow[convCMRequirement.UpdUser].ToString().Trim(); //修改者
objvCMRequirementEN.UpdDate = objRow[convCMRequirement.UpdDate] == DBNull.Value ? null : objRow[convCMRequirement.UpdDate].ToString().Trim(); //修改日期
objvCMRequirementEN.Memo = objRow[convCMRequirement.Memo] == DBNull.Value ? null : objRow[convCMRequirement.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvCMRequirementDA: GetObjByDataRowvCMRequirement)", objException.Message));
}
objvCMRequirementEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCMRequirementEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvCMRequirementEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCMRequirementEN objvCMRequirementEN = new clsvCMRequirementEN();
try
{
objvCMRequirementEN.ReqId = objRow[convCMRequirement.ReqId].ToString().Trim(); //需求Id
objvCMRequirementEN.RequirementName = objRow[convCMRequirement.RequirementName].ToString().Trim(); //需求名称
objvCMRequirementEN.FuncModuleAgcId = objRow[convCMRequirement.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCMRequirement.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMRequirementEN.FuncModuleName = objRow[convCMRequirement.FuncModuleName] == DBNull.Value ? null : objRow[convCMRequirement.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMRequirementEN.ReqContent = objRow[convCMRequirement.ReqContent].ToString().Trim(); //需求内容
objvCMRequirementEN.UpReqId = objRow[convCMRequirement.UpReqId].ToString().Trim(); //上级需求Id
objvCMRequirementEN.RequirementTypeId = objRow[convCMRequirement.RequirementTypeId].ToString().Trim(); //需求类型Id
objvCMRequirementEN.RequirementTypeName = objRow[convCMRequirement.RequirementTypeName] == DBNull.Value ? null : objRow[convCMRequirement.RequirementTypeName].ToString().Trim(); //需求类型名
objvCMRequirementEN.IsFinished = TransNullToBool(objRow[convCMRequirement.IsFinished].ToString().Trim()); //是否完成
objvCMRequirementEN.CmPrjId = objRow[convCMRequirement.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMRequirementEN.CmPrjName = objRow[convCMRequirement.CmPrjName] == DBNull.Value ? null : objRow[convCMRequirement.CmPrjName].ToString().Trim(); //CM工程名
objvCMRequirementEN.PrjId = objRow[convCMRequirement.PrjId] == DBNull.Value ? null : objRow[convCMRequirement.PrjId].ToString().Trim(); //工程Id
objvCMRequirementEN.PrjName = objRow[convCMRequirement.PrjName] == DBNull.Value ? null : objRow[convCMRequirement.PrjName].ToString().Trim(); //工程名称
objvCMRequirementEN.ApplicationTypeId = objRow[convCMRequirement.ApplicationTypeId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCMRequirement.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMRequirementEN.ApplicationTypeSimName = objRow[convCMRequirement.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMRequirement.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMRequirementEN.ProjectFileName = objRow[convCMRequirement.ProjectFileName] == DBNull.Value ? null : objRow[convCMRequirement.ProjectFileName].ToString().Trim(); //工程文件名
objvCMRequirementEN.UpdUser = objRow[convCMRequirement.UpdUser] == DBNull.Value ? null : objRow[convCMRequirement.UpdUser].ToString().Trim(); //修改者
objvCMRequirementEN.UpdDate = objRow[convCMRequirement.UpdDate] == DBNull.Value ? null : objRow[convCMRequirement.UpdDate].ToString().Trim(); //修改日期
objvCMRequirementEN.Memo = objRow[convCMRequirement.Memo] == DBNull.Value ? null : objRow[convCMRequirement.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvCMRequirementDA: GetObjByDataRow)", objException.Message));
}
objvCMRequirementEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCMRequirementEN;
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
objSQL = clsvCMRequirementDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCMRequirementEN._CurrTabName, convCMRequirement.ReqId, 8, "");
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
objSQL = clsvCMRequirementDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCMRequirementEN._CurrTabName, convCMRequirement.ReqId, 8, strPrefix);
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
 objSQL = clsvCMRequirementDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ReqId from vCMRequirement where " + strCondition;
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
 objSQL = clsvCMRequirementDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ReqId from vCMRequirement where " + strCondition;
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
 objSQL = clsvCMRequirementDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCMRequirement", "ReqId = " + "'"+ strReqId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvCMRequirementDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMRequirementDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCMRequirement", strCondition))
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
objSQL = clsvCMRequirementDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vCMRequirement");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvCMRequirementENS">源对象</param>
 /// <param name = "objvCMRequirementENT">目标对象</param>
public void CopyTo(clsvCMRequirementEN objvCMRequirementENS, clsvCMRequirementEN objvCMRequirementENT)
{
objvCMRequirementENT.ReqId = objvCMRequirementENS.ReqId; //需求Id
objvCMRequirementENT.RequirementName = objvCMRequirementENS.RequirementName; //需求名称
objvCMRequirementENT.FuncModuleAgcId = objvCMRequirementENS.FuncModuleAgcId; //功能模块Id
objvCMRequirementENT.FuncModuleName = objvCMRequirementENS.FuncModuleName; //功能模块名称
objvCMRequirementENT.ReqContent = objvCMRequirementENS.ReqContent; //需求内容
objvCMRequirementENT.UpReqId = objvCMRequirementENS.UpReqId; //上级需求Id
objvCMRequirementENT.RequirementTypeId = objvCMRequirementENS.RequirementTypeId; //需求类型Id
objvCMRequirementENT.RequirementTypeName = objvCMRequirementENS.RequirementTypeName; //需求类型名
objvCMRequirementENT.IsFinished = objvCMRequirementENS.IsFinished; //是否完成
objvCMRequirementENT.CmPrjId = objvCMRequirementENS.CmPrjId; //Cm工程Id
objvCMRequirementENT.CmPrjName = objvCMRequirementENS.CmPrjName; //CM工程名
objvCMRequirementENT.PrjId = objvCMRequirementENS.PrjId; //工程Id
objvCMRequirementENT.PrjName = objvCMRequirementENS.PrjName; //工程名称
objvCMRequirementENT.ApplicationTypeId = objvCMRequirementENS.ApplicationTypeId; //应用程序类型ID
objvCMRequirementENT.ApplicationTypeSimName = objvCMRequirementENS.ApplicationTypeSimName; //应用程序类型简称
objvCMRequirementENT.ProjectFileName = objvCMRequirementENS.ProjectFileName; //工程文件名
objvCMRequirementENT.UpdUser = objvCMRequirementENS.UpdUser; //修改者
objvCMRequirementENT.UpdDate = objvCMRequirementENS.UpdDate; //修改日期
objvCMRequirementENT.Memo = objvCMRequirementENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvCMRequirementEN objvCMRequirementEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvCMRequirementEN.ReqId, 8, convCMRequirement.ReqId);
clsCheckSql.CheckFieldLen(objvCMRequirementEN.RequirementName, 50, convCMRequirement.RequirementName);
clsCheckSql.CheckFieldLen(objvCMRequirementEN.FuncModuleAgcId, 8, convCMRequirement.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(objvCMRequirementEN.FuncModuleName, 30, convCMRequirement.FuncModuleName);
clsCheckSql.CheckFieldLen(objvCMRequirementEN.ReqContent, 4000, convCMRequirement.ReqContent);
clsCheckSql.CheckFieldLen(objvCMRequirementEN.UpReqId, 8, convCMRequirement.UpReqId);
clsCheckSql.CheckFieldLen(objvCMRequirementEN.RequirementTypeId, 4, convCMRequirement.RequirementTypeId);
clsCheckSql.CheckFieldLen(objvCMRequirementEN.RequirementTypeName, 30, convCMRequirement.RequirementTypeName);
clsCheckSql.CheckFieldLen(objvCMRequirementEN.CmPrjId, 6, convCMRequirement.CmPrjId);
clsCheckSql.CheckFieldLen(objvCMRequirementEN.CmPrjName, 50, convCMRequirement.CmPrjName);
clsCheckSql.CheckFieldLen(objvCMRequirementEN.PrjId, 4, convCMRequirement.PrjId);
clsCheckSql.CheckFieldLen(objvCMRequirementEN.PrjName, 30, convCMRequirement.PrjName);
clsCheckSql.CheckFieldLen(objvCMRequirementEN.ApplicationTypeSimName, 30, convCMRequirement.ApplicationTypeSimName);
clsCheckSql.CheckFieldLen(objvCMRequirementEN.ProjectFileName, 200, convCMRequirement.ProjectFileName);
clsCheckSql.CheckFieldLen(objvCMRequirementEN.UpdUser, 20, convCMRequirement.UpdUser);
clsCheckSql.CheckFieldLen(objvCMRequirementEN.UpdDate, 20, convCMRequirement.UpdDate);
clsCheckSql.CheckFieldLen(objvCMRequirementEN.Memo, 1000, convCMRequirement.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvCMRequirementEN.ReqId, convCMRequirement.ReqId);
clsCheckSql.CheckSqlInjection4Field(objvCMRequirementEN.RequirementName, convCMRequirement.RequirementName);
clsCheckSql.CheckSqlInjection4Field(objvCMRequirementEN.FuncModuleAgcId, convCMRequirement.FuncModuleAgcId);
clsCheckSql.CheckSqlInjection4Field(objvCMRequirementEN.FuncModuleName, convCMRequirement.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvCMRequirementEN.ReqContent, convCMRequirement.ReqContent);
clsCheckSql.CheckSqlInjection4Field(objvCMRequirementEN.UpReqId, convCMRequirement.UpReqId);
clsCheckSql.CheckSqlInjection4Field(objvCMRequirementEN.RequirementTypeId, convCMRequirement.RequirementTypeId);
clsCheckSql.CheckSqlInjection4Field(objvCMRequirementEN.RequirementTypeName, convCMRequirement.RequirementTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCMRequirementEN.CmPrjId, convCMRequirement.CmPrjId);
clsCheckSql.CheckSqlInjection4Field(objvCMRequirementEN.CmPrjName, convCMRequirement.CmPrjName);
clsCheckSql.CheckSqlInjection4Field(objvCMRequirementEN.PrjId, convCMRequirement.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvCMRequirementEN.PrjName, convCMRequirement.PrjName);
clsCheckSql.CheckSqlInjection4Field(objvCMRequirementEN.ApplicationTypeSimName, convCMRequirement.ApplicationTypeSimName);
clsCheckSql.CheckSqlInjection4Field(objvCMRequirementEN.ProjectFileName, convCMRequirement.ProjectFileName);
clsCheckSql.CheckSqlInjection4Field(objvCMRequirementEN.UpdUser, convCMRequirement.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvCMRequirementEN.UpdDate, convCMRequirement.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvCMRequirementEN.Memo, convCMRequirement.Memo);
//检查外键字段长度
 objvCMRequirementEN._IsCheckProperty = true;
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
 objSQL = clsvCMRequirementDA.GetSpecSQLObj();
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
 objSQL = clsvCMRequirementDA.GetSpecSQLObj();
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
 objSQL = clsvCMRequirementDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCMRequirementEN._CurrTabName);
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
 objSQL = clsvCMRequirementDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCMRequirementEN._CurrTabName, strCondition);
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
 objSQL = clsvCMRequirementDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}