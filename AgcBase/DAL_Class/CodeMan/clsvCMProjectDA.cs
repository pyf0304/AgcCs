
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCMProjectDA
 表名:vCMProject(00050513)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:24:44
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
 /// vCM项目(vCMProject)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvCMProjectDA : clsCommBase4DA
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
 return clsvCMProjectEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvCMProjectEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCMProjectEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvCMProjectEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvCMProjectEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vCMProject中,检查关键字,长度不正确!(clsvCMProjectDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strCmPrjId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vCMProject中,关键字不能为空 或 null!(clsvCMProjectDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCmPrjId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvCMProjectDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvCMProjectDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMProjectDA.GetSpecSQLObj();
strSQL = "Select * from vCMProject where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vCMProject(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvCMProjectDA: GetDataTable_vCMProject)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMProjectDA.GetSpecSQLObj();
strSQL = "Select * from vCMProject where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvCMProjectDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMProjectDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvCMProjectDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMProjectDA.GetSpecSQLObj();
strSQL = "Select * from vCMProject where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvCMProjectDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMProjectDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvCMProjectDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMProjectDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCMProject where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCMProject where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvCMProjectDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMProjectDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vCMProject where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvCMProjectDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMProjectDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vCMProject.* " + 
$"from vCMProject " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vCMProject.CmPrjId not in " + 
$"(Select top {intTop_In} vCMProject.CmPrjId from vCMProject " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCMProject where {1} and CmPrjId not in (Select top {2} CmPrjId from vCMProject where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCMProject where {1} and CmPrjId not in (Select top {3} CmPrjId from vCMProject where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvCMProjectDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMProjectDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vCMProject.* " + 
$"from vCMProject " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vCMProject.CmPrjId not in " + 
$"(Select top {intTop_In} vCMProject.CmPrjId from vCMProject " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCMProject where {1} and CmPrjId not in (Select top {2} CmPrjId from vCMProject where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCMProject where {1} and CmPrjId not in (Select top {3} CmPrjId from vCMProject where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvCMProjectEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvCMProjectDA:GetObjLst)", objException.Message));
}
List<clsvCMProjectEN> arrObjLst = new List<clsvCMProjectEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMProjectDA.GetSpecSQLObj();
strSQL = "Select * from vCMProject where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMProjectEN objvCMProjectEN = new clsvCMProjectEN();
try
{
objvCMProjectEN.CmPrjId = objRow[convCMProject.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMProjectEN.CmPrjName = objRow[convCMProject.CmPrjName] == DBNull.Value ? null : objRow[convCMProject.CmPrjName].ToString().Trim(); //CM工程名
objvCMProjectEN.PrjId = objRow[convCMProject.PrjId].ToString().Trim(); //工程Id
objvCMProjectEN.PrjName = objRow[convCMProject.PrjName].ToString().Trim(); //工程名称
objvCMProjectEN.ApplicationTypeId = TransNullToInt(objRow[convCMProject.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMProjectEN.ApplicationTypeSimName = objRow[convCMProject.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMProject.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMProjectEN.ProjectFileName = objRow[convCMProject.ProjectFileName] == DBNull.Value ? null : objRow[convCMProject.ProjectFileName].ToString().Trim(); //工程文件名
objvCMProjectEN.UseStateId = objRow[convCMProject.UseStateId] == DBNull.Value ? null : objRow[convCMProject.UseStateId].ToString().Trim(); //使用状态Id
objvCMProjectEN.UseStateName = objRow[convCMProject.UseStateName] == DBNull.Value ? null : objRow[convCMProject.UseStateName].ToString().Trim(); //使用状态名称
objvCMProjectEN.IsRefresh4RelaView = TransNullToBool(objRow[convCMProject.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图
objvCMProjectEN.UpdDate = objRow[convCMProject.UpdDate] == DBNull.Value ? null : objRow[convCMProject.UpdDate].ToString().Trim(); //修改日期
objvCMProjectEN.UpdUserId = objRow[convCMProject.UpdUserId] == DBNull.Value ? null : objRow[convCMProject.UpdUserId].ToString().Trim(); //修改用户Id
objvCMProjectEN.Memo = objRow[convCMProject.Memo] == DBNull.Value ? null : objRow[convCMProject.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCMProjectDA: GetObjLst)", objException.Message));
}
objvCMProjectEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCMProjectEN);
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
public List<clsvCMProjectEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvCMProjectDA:GetObjLstByTabName)", objException.Message));
}
List<clsvCMProjectEN> arrObjLst = new List<clsvCMProjectEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMProjectDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMProjectEN objvCMProjectEN = new clsvCMProjectEN();
try
{
objvCMProjectEN.CmPrjId = objRow[convCMProject.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMProjectEN.CmPrjName = objRow[convCMProject.CmPrjName] == DBNull.Value ? null : objRow[convCMProject.CmPrjName].ToString().Trim(); //CM工程名
objvCMProjectEN.PrjId = objRow[convCMProject.PrjId].ToString().Trim(); //工程Id
objvCMProjectEN.PrjName = objRow[convCMProject.PrjName].ToString().Trim(); //工程名称
objvCMProjectEN.ApplicationTypeId = TransNullToInt(objRow[convCMProject.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMProjectEN.ApplicationTypeSimName = objRow[convCMProject.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMProject.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMProjectEN.ProjectFileName = objRow[convCMProject.ProjectFileName] == DBNull.Value ? null : objRow[convCMProject.ProjectFileName].ToString().Trim(); //工程文件名
objvCMProjectEN.UseStateId = objRow[convCMProject.UseStateId] == DBNull.Value ? null : objRow[convCMProject.UseStateId].ToString().Trim(); //使用状态Id
objvCMProjectEN.UseStateName = objRow[convCMProject.UseStateName] == DBNull.Value ? null : objRow[convCMProject.UseStateName].ToString().Trim(); //使用状态名称
objvCMProjectEN.IsRefresh4RelaView = TransNullToBool(objRow[convCMProject.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图
objvCMProjectEN.UpdDate = objRow[convCMProject.UpdDate] == DBNull.Value ? null : objRow[convCMProject.UpdDate].ToString().Trim(); //修改日期
objvCMProjectEN.UpdUserId = objRow[convCMProject.UpdUserId] == DBNull.Value ? null : objRow[convCMProject.UpdUserId].ToString().Trim(); //修改用户Id
objvCMProjectEN.Memo = objRow[convCMProject.Memo] == DBNull.Value ? null : objRow[convCMProject.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCMProjectDA: GetObjLst)", objException.Message));
}
objvCMProjectEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCMProjectEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvCMProjectEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvCMProject(ref clsvCMProjectEN objvCMProjectEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMProjectDA.GetSpecSQLObj();
strSQL = "Select * from vCMProject where CmPrjId = " + "'"+ objvCMProjectEN.CmPrjId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvCMProjectEN.CmPrjId = objDT.Rows[0][convCMProject.CmPrjId].ToString().Trim(); //Cm工程Id(字段类型:char,字段长度:6,是否可空:False)
 objvCMProjectEN.CmPrjName = objDT.Rows[0][convCMProject.CmPrjName].ToString().Trim(); //CM工程名(字段类型:varchar,字段长度:50,是否可空:True)
 objvCMProjectEN.PrjId = objDT.Rows[0][convCMProject.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvCMProjectEN.PrjName = objDT.Rows[0][convCMProject.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCMProjectEN.ApplicationTypeId = TransNullToInt(objDT.Rows[0][convCMProject.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objvCMProjectEN.ApplicationTypeSimName = objDT.Rows[0][convCMProject.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvCMProjectEN.ProjectFileName = objDT.Rows[0][convCMProject.ProjectFileName].ToString().Trim(); //工程文件名(字段类型:varchar,字段长度:200,是否可空:False)
 objvCMProjectEN.UseStateId = objDT.Rows[0][convCMProject.UseStateId].ToString().Trim(); //使用状态Id(字段类型:char,字段长度:4,是否可空:False)
 objvCMProjectEN.UseStateName = objDT.Rows[0][convCMProject.UseStateName].ToString().Trim(); //使用状态名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCMProjectEN.IsRefresh4RelaView = TransNullToBool(objDT.Rows[0][convCMProject.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图(字段类型:bit,字段长度:1,是否可空:True)
 objvCMProjectEN.UpdDate = objDT.Rows[0][convCMProject.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCMProjectEN.UpdUserId = objDT.Rows[0][convCMProject.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvCMProjectEN.Memo = objDT.Rows[0][convCMProject.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvCMProjectDA: GetvCMProject)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCmPrjId">表关键字</param>
 /// <returns>表对象</returns>
public clsvCMProjectEN GetObjByCmPrjId(string strCmPrjId)
{
CheckPrimaryKey(strCmPrjId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMProjectDA.GetSpecSQLObj();
strSQL = "Select * from vCMProject where CmPrjId = " + "'"+ strCmPrjId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvCMProjectEN objvCMProjectEN = new clsvCMProjectEN();
try
{
 objvCMProjectEN.CmPrjId = objRow[convCMProject.CmPrjId].ToString().Trim(); //Cm工程Id(字段类型:char,字段长度:6,是否可空:False)
 objvCMProjectEN.CmPrjName = objRow[convCMProject.CmPrjName] == DBNull.Value ? null : objRow[convCMProject.CmPrjName].ToString().Trim(); //CM工程名(字段类型:varchar,字段长度:50,是否可空:True)
 objvCMProjectEN.PrjId = objRow[convCMProject.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvCMProjectEN.PrjName = objRow[convCMProject.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCMProjectEN.ApplicationTypeId = Int32.Parse(objRow[convCMProject.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objvCMProjectEN.ApplicationTypeSimName = objRow[convCMProject.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMProject.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvCMProjectEN.ProjectFileName = objRow[convCMProject.ProjectFileName] == DBNull.Value ? null : objRow[convCMProject.ProjectFileName].ToString().Trim(); //工程文件名(字段类型:varchar,字段长度:200,是否可空:False)
 objvCMProjectEN.UseStateId = objRow[convCMProject.UseStateId] == DBNull.Value ? null : objRow[convCMProject.UseStateId].ToString().Trim(); //使用状态Id(字段类型:char,字段长度:4,是否可空:False)
 objvCMProjectEN.UseStateName = objRow[convCMProject.UseStateName] == DBNull.Value ? null : objRow[convCMProject.UseStateName].ToString().Trim(); //使用状态名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCMProjectEN.IsRefresh4RelaView = clsEntityBase2.TransNullToBool_S(objRow[convCMProject.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图(字段类型:bit,字段长度:1,是否可空:True)
 objvCMProjectEN.UpdDate = objRow[convCMProject.UpdDate] == DBNull.Value ? null : objRow[convCMProject.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCMProjectEN.UpdUserId = objRow[convCMProject.UpdUserId] == DBNull.Value ? null : objRow[convCMProject.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvCMProjectEN.Memo = objRow[convCMProject.Memo] == DBNull.Value ? null : objRow[convCMProject.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvCMProjectDA: GetObjByCmPrjId)", objException.Message));
}
return objvCMProjectEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvCMProjectEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvCMProjectDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMProjectDA.GetSpecSQLObj();
strSQL = "Select * from vCMProject where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvCMProjectEN objvCMProjectEN = new clsvCMProjectEN()
{
CmPrjId = objRow[convCMProject.CmPrjId].ToString().Trim(), //Cm工程Id
CmPrjName = objRow[convCMProject.CmPrjName] == DBNull.Value ? null : objRow[convCMProject.CmPrjName].ToString().Trim(), //CM工程名
PrjId = objRow[convCMProject.PrjId].ToString().Trim(), //工程Id
PrjName = objRow[convCMProject.PrjName].ToString().Trim(), //工程名称
ApplicationTypeId = TransNullToInt(objRow[convCMProject.ApplicationTypeId].ToString().Trim()), //应用程序类型ID
ApplicationTypeSimName = objRow[convCMProject.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMProject.ApplicationTypeSimName].ToString().Trim(), //应用程序类型简称
ProjectFileName = objRow[convCMProject.ProjectFileName] == DBNull.Value ? null : objRow[convCMProject.ProjectFileName].ToString().Trim(), //工程文件名
UseStateId = objRow[convCMProject.UseStateId] == DBNull.Value ? null : objRow[convCMProject.UseStateId].ToString().Trim(), //使用状态Id
UseStateName = objRow[convCMProject.UseStateName] == DBNull.Value ? null : objRow[convCMProject.UseStateName].ToString().Trim(), //使用状态名称
IsRefresh4RelaView = TransNullToBool(objRow[convCMProject.IsRefresh4RelaView].ToString().Trim()), //是否刷新相关视图
UpdDate = objRow[convCMProject.UpdDate] == DBNull.Value ? null : objRow[convCMProject.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[convCMProject.UpdUserId] == DBNull.Value ? null : objRow[convCMProject.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[convCMProject.Memo] == DBNull.Value ? null : objRow[convCMProject.Memo].ToString().Trim() //说明
};
objvCMProjectEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCMProjectEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvCMProjectDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvCMProjectEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCMProjectEN objvCMProjectEN = new clsvCMProjectEN();
try
{
objvCMProjectEN.CmPrjId = objRow[convCMProject.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMProjectEN.CmPrjName = objRow[convCMProject.CmPrjName] == DBNull.Value ? null : objRow[convCMProject.CmPrjName].ToString().Trim(); //CM工程名
objvCMProjectEN.PrjId = objRow[convCMProject.PrjId].ToString().Trim(); //工程Id
objvCMProjectEN.PrjName = objRow[convCMProject.PrjName].ToString().Trim(); //工程名称
objvCMProjectEN.ApplicationTypeId = TransNullToInt(objRow[convCMProject.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMProjectEN.ApplicationTypeSimName = objRow[convCMProject.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMProject.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMProjectEN.ProjectFileName = objRow[convCMProject.ProjectFileName] == DBNull.Value ? null : objRow[convCMProject.ProjectFileName].ToString().Trim(); //工程文件名
objvCMProjectEN.UseStateId = objRow[convCMProject.UseStateId] == DBNull.Value ? null : objRow[convCMProject.UseStateId].ToString().Trim(); //使用状态Id
objvCMProjectEN.UseStateName = objRow[convCMProject.UseStateName] == DBNull.Value ? null : objRow[convCMProject.UseStateName].ToString().Trim(); //使用状态名称
objvCMProjectEN.IsRefresh4RelaView = TransNullToBool(objRow[convCMProject.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图
objvCMProjectEN.UpdDate = objRow[convCMProject.UpdDate] == DBNull.Value ? null : objRow[convCMProject.UpdDate].ToString().Trim(); //修改日期
objvCMProjectEN.UpdUserId = objRow[convCMProject.UpdUserId] == DBNull.Value ? null : objRow[convCMProject.UpdUserId].ToString().Trim(); //修改用户Id
objvCMProjectEN.Memo = objRow[convCMProject.Memo] == DBNull.Value ? null : objRow[convCMProject.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvCMProjectDA: GetObjByDataRowvCMProject)", objException.Message));
}
objvCMProjectEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCMProjectEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvCMProjectEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCMProjectEN objvCMProjectEN = new clsvCMProjectEN();
try
{
objvCMProjectEN.CmPrjId = objRow[convCMProject.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMProjectEN.CmPrjName = objRow[convCMProject.CmPrjName] == DBNull.Value ? null : objRow[convCMProject.CmPrjName].ToString().Trim(); //CM工程名
objvCMProjectEN.PrjId = objRow[convCMProject.PrjId].ToString().Trim(); //工程Id
objvCMProjectEN.PrjName = objRow[convCMProject.PrjName].ToString().Trim(); //工程名称
objvCMProjectEN.ApplicationTypeId = TransNullToInt(objRow[convCMProject.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMProjectEN.ApplicationTypeSimName = objRow[convCMProject.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMProject.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMProjectEN.ProjectFileName = objRow[convCMProject.ProjectFileName] == DBNull.Value ? null : objRow[convCMProject.ProjectFileName].ToString().Trim(); //工程文件名
objvCMProjectEN.UseStateId = objRow[convCMProject.UseStateId] == DBNull.Value ? null : objRow[convCMProject.UseStateId].ToString().Trim(); //使用状态Id
objvCMProjectEN.UseStateName = objRow[convCMProject.UseStateName] == DBNull.Value ? null : objRow[convCMProject.UseStateName].ToString().Trim(); //使用状态名称
objvCMProjectEN.IsRefresh4RelaView = TransNullToBool(objRow[convCMProject.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图
objvCMProjectEN.UpdDate = objRow[convCMProject.UpdDate] == DBNull.Value ? null : objRow[convCMProject.UpdDate].ToString().Trim(); //修改日期
objvCMProjectEN.UpdUserId = objRow[convCMProject.UpdUserId] == DBNull.Value ? null : objRow[convCMProject.UpdUserId].ToString().Trim(); //修改用户Id
objvCMProjectEN.Memo = objRow[convCMProject.Memo] == DBNull.Value ? null : objRow[convCMProject.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvCMProjectDA: GetObjByDataRow)", objException.Message));
}
objvCMProjectEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCMProjectEN;
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
objSQL = clsvCMProjectDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCMProjectEN._CurrTabName, convCMProject.CmPrjId, 6, "");
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
objSQL = clsvCMProjectDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCMProjectEN._CurrTabName, convCMProject.CmPrjId, 6, strPrefix);
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
 objSQL = clsvCMProjectDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select CmPrjId from vCMProject where " + strCondition;
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
 objSQL = clsvCMProjectDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select CmPrjId from vCMProject where " + strCondition;
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
 objSQL = clsvCMProjectDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCMProject", "CmPrjId = " + "'"+ strCmPrjId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvCMProjectDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMProjectDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCMProject", strCondition))
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
objSQL = clsvCMProjectDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vCMProject");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvCMProjectENS">源对象</param>
 /// <param name = "objvCMProjectENT">目标对象</param>
public void CopyTo(clsvCMProjectEN objvCMProjectENS, clsvCMProjectEN objvCMProjectENT)
{
objvCMProjectENT.CmPrjId = objvCMProjectENS.CmPrjId; //Cm工程Id
objvCMProjectENT.CmPrjName = objvCMProjectENS.CmPrjName; //CM工程名
objvCMProjectENT.PrjId = objvCMProjectENS.PrjId; //工程Id
objvCMProjectENT.PrjName = objvCMProjectENS.PrjName; //工程名称
objvCMProjectENT.ApplicationTypeId = objvCMProjectENS.ApplicationTypeId; //应用程序类型ID
objvCMProjectENT.ApplicationTypeSimName = objvCMProjectENS.ApplicationTypeSimName; //应用程序类型简称
objvCMProjectENT.ProjectFileName = objvCMProjectENS.ProjectFileName; //工程文件名
objvCMProjectENT.UseStateId = objvCMProjectENS.UseStateId; //使用状态Id
objvCMProjectENT.UseStateName = objvCMProjectENS.UseStateName; //使用状态名称
objvCMProjectENT.IsRefresh4RelaView = objvCMProjectENS.IsRefresh4RelaView; //是否刷新相关视图
objvCMProjectENT.UpdDate = objvCMProjectENS.UpdDate; //修改日期
objvCMProjectENT.UpdUserId = objvCMProjectENS.UpdUserId; //修改用户Id
objvCMProjectENT.Memo = objvCMProjectENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvCMProjectEN objvCMProjectEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvCMProjectEN.CmPrjId, 6, convCMProject.CmPrjId);
clsCheckSql.CheckFieldLen(objvCMProjectEN.CmPrjName, 50, convCMProject.CmPrjName);
clsCheckSql.CheckFieldLen(objvCMProjectEN.PrjId, 4, convCMProject.PrjId);
clsCheckSql.CheckFieldLen(objvCMProjectEN.PrjName, 30, convCMProject.PrjName);
clsCheckSql.CheckFieldLen(objvCMProjectEN.ApplicationTypeSimName, 30, convCMProject.ApplicationTypeSimName);
clsCheckSql.CheckFieldLen(objvCMProjectEN.ProjectFileName, 200, convCMProject.ProjectFileName);
clsCheckSql.CheckFieldLen(objvCMProjectEN.UseStateId, 4, convCMProject.UseStateId);
clsCheckSql.CheckFieldLen(objvCMProjectEN.UseStateName, 30, convCMProject.UseStateName);
clsCheckSql.CheckFieldLen(objvCMProjectEN.UpdDate, 20, convCMProject.UpdDate);
clsCheckSql.CheckFieldLen(objvCMProjectEN.UpdUserId, 20, convCMProject.UpdUserId);
clsCheckSql.CheckFieldLen(objvCMProjectEN.Memo, 1000, convCMProject.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvCMProjectEN.CmPrjId, convCMProject.CmPrjId);
clsCheckSql.CheckSqlInjection4Field(objvCMProjectEN.CmPrjName, convCMProject.CmPrjName);
clsCheckSql.CheckSqlInjection4Field(objvCMProjectEN.PrjId, convCMProject.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvCMProjectEN.PrjName, convCMProject.PrjName);
clsCheckSql.CheckSqlInjection4Field(objvCMProjectEN.ApplicationTypeSimName, convCMProject.ApplicationTypeSimName);
clsCheckSql.CheckSqlInjection4Field(objvCMProjectEN.ProjectFileName, convCMProject.ProjectFileName);
clsCheckSql.CheckSqlInjection4Field(objvCMProjectEN.UseStateId, convCMProject.UseStateId);
clsCheckSql.CheckSqlInjection4Field(objvCMProjectEN.UseStateName, convCMProject.UseStateName);
clsCheckSql.CheckSqlInjection4Field(objvCMProjectEN.UpdDate, convCMProject.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvCMProjectEN.UpdUserId, convCMProject.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objvCMProjectEN.Memo, convCMProject.Memo);
//检查外键字段长度
 objvCMProjectEN._IsCheckProperty = true;
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
string strSQL = "select CmPrjId, CmPrjName from vCMProject ";
 clsSpecSQLforSql mySql = clsvCMProjectDA.GetSpecSQLObj();
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
 objSQL = clsvCMProjectDA.GetSpecSQLObj();
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
 objSQL = clsvCMProjectDA.GetSpecSQLObj();
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
 objSQL = clsvCMProjectDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCMProjectEN._CurrTabName);
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
 objSQL = clsvCMProjectDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCMProjectEN._CurrTabName, strCondition);
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
 objSQL = clsvCMProjectDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}