
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUserCodePathDA
 表名:UserCodePath(00050204)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:26:53
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统设置(SystemSet)
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
 /// 用户生成路径(UserCodePath)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsUserCodePathDA : clsCommBase4DA
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
 return clsUserCodePathEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsUserCodePathEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsUserCodePathEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsUserCodePathEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsUserCodePathEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsUserCodePathDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePathDA.GetSpecSQLObj();
strSQL = "Select * from UserCodePath where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_UserCodePath(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsUserCodePathDA: GetDataTable_UserCodePath)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePathDA.GetSpecSQLObj();
strSQL = "Select * from UserCodePath where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsUserCodePathDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePathDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsUserCodePathDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePathDA.GetSpecSQLObj();
strSQL = "Select * from UserCodePath where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsUserCodePathDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePathDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsUserCodePathDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePathDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from UserCodePath where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from UserCodePath where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsUserCodePathDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePathDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from UserCodePath where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsUserCodePathDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePathDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} UserCodePath.* " + 
$"from UserCodePath " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and UserCodePath.mId not in " + 
$"(Select top {intTop_In} UserCodePath.mId from UserCodePath " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from UserCodePath where {1} and mId not in (Select top {2} mId from UserCodePath where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from UserCodePath where {1} and mId not in (Select top {3} mId from UserCodePath where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsUserCodePathDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePathDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} UserCodePath.* " + 
$"from UserCodePath " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and UserCodePath.mId not in " + 
$"(Select top {intTop_In} UserCodePath.mId from UserCodePath " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from UserCodePath where {1} and mId not in (Select top {2} mId from UserCodePath where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from UserCodePath where {1} and mId not in (Select top {3} mId from UserCodePath where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsUserCodePathEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsUserCodePathDA:GetObjLst)", objException.Message));
}
List<clsUserCodePathEN> arrObjLst = new List<clsUserCodePathEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePathDA.GetSpecSQLObj();
strSQL = "Select * from UserCodePath where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserCodePathEN objUserCodePathEN = new clsUserCodePathEN();
try
{
objUserCodePathEN.mId = TransNullToInt(objRow[conUserCodePath.mId].ToString().Trim()); //mId
objUserCodePathEN.CMProjectAppRelaId = TransNullToInt(objRow[conUserCodePath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objUserCodePathEN.CodeTypeId = objRow[conUserCodePath.CodeTypeId].ToString().Trim(); //代码类型Id
objUserCodePathEN.TabMainTypeId = objRow[conUserCodePath.TabMainTypeId] == DBNull.Value ? null : objRow[conUserCodePath.TabMainTypeId].ToString().Trim(); //表主类型Id
objUserCodePathEN.IsGeneCode = TransNullToBool(objRow[conUserCodePath.IsGeneCode].ToString().Trim()); //是否生成代码
objUserCodePathEN.ProjectFileName = objRow[conUserCodePath.ProjectFileName] == DBNull.Value ? null : objRow[conUserCodePath.ProjectFileName].ToString().Trim(); //工程文件名
objUserCodePathEN.ProjectPath = objRow[conUserCodePath.ProjectPath] == DBNull.Value ? null : objRow[conUserCodePath.ProjectPath].ToString().Trim(); //工程路径
objUserCodePathEN.PrjFileStateId = objRow[conUserCodePath.PrjFileStateId] == DBNull.Value ? null : objRow[conUserCodePath.PrjFileStateId].ToString().Trim(); //工程文件状态Id
objUserCodePathEN.CodePath = objRow[conUserCodePath.CodePath].ToString().Trim(); //代码路径
objUserCodePathEN.GcPathId = objRow[conUserCodePath.GcPathId] == DBNull.Value ? null : objRow[conUserCodePath.GcPathId].ToString().Trim(); //GC路径Id
objUserCodePathEN.CodePathBackup = objRow[conUserCodePath.CodePathBackup].ToString().Trim(); //备份代码路径
objUserCodePathEN.SuffixPath = objRow[conUserCodePath.SuffixPath] == DBNull.Value ? null : objRow[conUserCodePath.SuffixPath].ToString().Trim(); //后缀路径
objUserCodePathEN.IsTemplate = TransNullToBool(objRow[conUserCodePath.IsTemplate].ToString().Trim()); //是否模板
objUserCodePathEN.IsExistCodePath = TransNullToBool(objRow[conUserCodePath.IsExistCodePath].ToString().Trim()); //是否存在代码路径
objUserCodePathEN.IsExistCodePathBackup = TransNullToBool(objRow[conUserCodePath.IsExistCodePathBackup].ToString().Trim()); //是否存在备份路径
objUserCodePathEN.PrjId = objRow[conUserCodePath.PrjId].ToString().Trim(); //工程Id
objUserCodePathEN.UpdDate = objRow[conUserCodePath.UpdDate] == DBNull.Value ? null : objRow[conUserCodePath.UpdDate].ToString().Trim(); //修改日期
objUserCodePathEN.UpdUserId = objRow[conUserCodePath.UpdUserId] == DBNull.Value ? null : objRow[conUserCodePath.UpdUserId].ToString().Trim(); //修改用户Id
objUserCodePathEN.Memo = objRow[conUserCodePath.Memo] == DBNull.Value ? null : objRow[conUserCodePath.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsUserCodePathDA: GetObjLst)", objException.Message));
}
objUserCodePathEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objUserCodePathEN);
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
public List<clsUserCodePathEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsUserCodePathDA:GetObjLstByTabName)", objException.Message));
}
List<clsUserCodePathEN> arrObjLst = new List<clsUserCodePathEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePathDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserCodePathEN objUserCodePathEN = new clsUserCodePathEN();
try
{
objUserCodePathEN.mId = TransNullToInt(objRow[conUserCodePath.mId].ToString().Trim()); //mId
objUserCodePathEN.CMProjectAppRelaId = TransNullToInt(objRow[conUserCodePath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objUserCodePathEN.CodeTypeId = objRow[conUserCodePath.CodeTypeId].ToString().Trim(); //代码类型Id
objUserCodePathEN.TabMainTypeId = objRow[conUserCodePath.TabMainTypeId] == DBNull.Value ? null : objRow[conUserCodePath.TabMainTypeId].ToString().Trim(); //表主类型Id
objUserCodePathEN.IsGeneCode = TransNullToBool(objRow[conUserCodePath.IsGeneCode].ToString().Trim()); //是否生成代码
objUserCodePathEN.ProjectFileName = objRow[conUserCodePath.ProjectFileName] == DBNull.Value ? null : objRow[conUserCodePath.ProjectFileName].ToString().Trim(); //工程文件名
objUserCodePathEN.ProjectPath = objRow[conUserCodePath.ProjectPath] == DBNull.Value ? null : objRow[conUserCodePath.ProjectPath].ToString().Trim(); //工程路径
objUserCodePathEN.PrjFileStateId = objRow[conUserCodePath.PrjFileStateId] == DBNull.Value ? null : objRow[conUserCodePath.PrjFileStateId].ToString().Trim(); //工程文件状态Id
objUserCodePathEN.CodePath = objRow[conUserCodePath.CodePath].ToString().Trim(); //代码路径
objUserCodePathEN.GcPathId = objRow[conUserCodePath.GcPathId] == DBNull.Value ? null : objRow[conUserCodePath.GcPathId].ToString().Trim(); //GC路径Id
objUserCodePathEN.CodePathBackup = objRow[conUserCodePath.CodePathBackup].ToString().Trim(); //备份代码路径
objUserCodePathEN.SuffixPath = objRow[conUserCodePath.SuffixPath] == DBNull.Value ? null : objRow[conUserCodePath.SuffixPath].ToString().Trim(); //后缀路径
objUserCodePathEN.IsTemplate = TransNullToBool(objRow[conUserCodePath.IsTemplate].ToString().Trim()); //是否模板
objUserCodePathEN.IsExistCodePath = TransNullToBool(objRow[conUserCodePath.IsExistCodePath].ToString().Trim()); //是否存在代码路径
objUserCodePathEN.IsExistCodePathBackup = TransNullToBool(objRow[conUserCodePath.IsExistCodePathBackup].ToString().Trim()); //是否存在备份路径
objUserCodePathEN.PrjId = objRow[conUserCodePath.PrjId].ToString().Trim(); //工程Id
objUserCodePathEN.UpdDate = objRow[conUserCodePath.UpdDate] == DBNull.Value ? null : objRow[conUserCodePath.UpdDate].ToString().Trim(); //修改日期
objUserCodePathEN.UpdUserId = objRow[conUserCodePath.UpdUserId] == DBNull.Value ? null : objRow[conUserCodePath.UpdUserId].ToString().Trim(); //修改用户Id
objUserCodePathEN.Memo = objRow[conUserCodePath.Memo] == DBNull.Value ? null : objRow[conUserCodePath.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsUserCodePathDA: GetObjLst)", objException.Message));
}
objUserCodePathEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objUserCodePathEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objUserCodePathEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetUserCodePath(ref clsUserCodePathEN objUserCodePathEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePathDA.GetSpecSQLObj();
strSQL = "Select * from UserCodePath where mId = " + ""+ objUserCodePathEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objUserCodePathEN.mId = TransNullToInt(objDT.Rows[0][conUserCodePath.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objUserCodePathEN.CMProjectAppRelaId = TransNullToInt(objDT.Rows[0][conUserCodePath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id(字段类型:bigint,字段长度:8,是否可空:False)
 objUserCodePathEN.CodeTypeId = objDT.Rows[0][conUserCodePath.CodeTypeId].ToString().Trim(); //代码类型Id(字段类型:char,字段长度:4,是否可空:False)
 objUserCodePathEN.TabMainTypeId = objDT.Rows[0][conUserCodePath.TabMainTypeId].ToString().Trim(); //表主类型Id(字段类型:char,字段长度:4,是否可空:True)
 objUserCodePathEN.IsGeneCode = TransNullToBool(objDT.Rows[0][conUserCodePath.IsGeneCode].ToString().Trim()); //是否生成代码(字段类型:bit,字段长度:1,是否可空:True)
 objUserCodePathEN.ProjectFileName = objDT.Rows[0][conUserCodePath.ProjectFileName].ToString().Trim(); //工程文件名(字段类型:varchar,字段长度:200,是否可空:False)
 objUserCodePathEN.ProjectPath = objDT.Rows[0][conUserCodePath.ProjectPath].ToString().Trim(); //工程路径(字段类型:varchar,字段长度:500,是否可空:False)
 objUserCodePathEN.PrjFileStateId = objDT.Rows[0][conUserCodePath.PrjFileStateId].ToString().Trim(); //工程文件状态Id(字段类型:char,字段长度:2,是否可空:False)
 objUserCodePathEN.CodePath = objDT.Rows[0][conUserCodePath.CodePath].ToString().Trim(); //代码路径(字段类型:varchar,字段长度:200,是否可空:False)
 objUserCodePathEN.GcPathId = objDT.Rows[0][conUserCodePath.GcPathId].ToString().Trim(); //GC路径Id(字段类型:char,字段长度:8,是否可空:True)
 objUserCodePathEN.CodePathBackup = objDT.Rows[0][conUserCodePath.CodePathBackup].ToString().Trim(); //备份代码路径(字段类型:varchar,字段长度:200,是否可空:False)
 objUserCodePathEN.SuffixPath = objDT.Rows[0][conUserCodePath.SuffixPath].ToString().Trim(); //后缀路径(字段类型:varchar,字段长度:50,是否可空:True)
 objUserCodePathEN.IsTemplate = TransNullToBool(objDT.Rows[0][conUserCodePath.IsTemplate].ToString().Trim()); //是否模板(字段类型:bit,字段长度:1,是否可空:False)
 objUserCodePathEN.IsExistCodePath = TransNullToBool(objDT.Rows[0][conUserCodePath.IsExistCodePath].ToString().Trim()); //是否存在代码路径(字段类型:bit,字段长度:1,是否可空:True)
 objUserCodePathEN.IsExistCodePathBackup = TransNullToBool(objDT.Rows[0][conUserCodePath.IsExistCodePathBackup].ToString().Trim()); //是否存在备份路径(字段类型:bit,字段长度:1,是否可空:True)
 objUserCodePathEN.PrjId = objDT.Rows[0][conUserCodePath.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objUserCodePathEN.UpdDate = objDT.Rows[0][conUserCodePath.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objUserCodePathEN.UpdUserId = objDT.Rows[0][conUserCodePath.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objUserCodePathEN.Memo = objDT.Rows[0][conUserCodePath.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsUserCodePathDA: GetUserCodePath)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsUserCodePathEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePathDA.GetSpecSQLObj();
strSQL = "Select * from UserCodePath where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsUserCodePathEN objUserCodePathEN = new clsUserCodePathEN();
try
{
 objUserCodePathEN.mId = Int32.Parse(objRow[conUserCodePath.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objUserCodePathEN.CMProjectAppRelaId = Int32.Parse(objRow[conUserCodePath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id(字段类型:bigint,字段长度:8,是否可空:False)
 objUserCodePathEN.CodeTypeId = objRow[conUserCodePath.CodeTypeId].ToString().Trim(); //代码类型Id(字段类型:char,字段长度:4,是否可空:False)
 objUserCodePathEN.TabMainTypeId = objRow[conUserCodePath.TabMainTypeId] == DBNull.Value ? null : objRow[conUserCodePath.TabMainTypeId].ToString().Trim(); //表主类型Id(字段类型:char,字段长度:4,是否可空:True)
 objUserCodePathEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePath.IsGeneCode].ToString().Trim()); //是否生成代码(字段类型:bit,字段长度:1,是否可空:True)
 objUserCodePathEN.ProjectFileName = objRow[conUserCodePath.ProjectFileName] == DBNull.Value ? null : objRow[conUserCodePath.ProjectFileName].ToString().Trim(); //工程文件名(字段类型:varchar,字段长度:200,是否可空:False)
 objUserCodePathEN.ProjectPath = objRow[conUserCodePath.ProjectPath] == DBNull.Value ? null : objRow[conUserCodePath.ProjectPath].ToString().Trim(); //工程路径(字段类型:varchar,字段长度:500,是否可空:False)
 objUserCodePathEN.PrjFileStateId = objRow[conUserCodePath.PrjFileStateId] == DBNull.Value ? null : objRow[conUserCodePath.PrjFileStateId].ToString().Trim(); //工程文件状态Id(字段类型:char,字段长度:2,是否可空:False)
 objUserCodePathEN.CodePath = objRow[conUserCodePath.CodePath].ToString().Trim(); //代码路径(字段类型:varchar,字段长度:200,是否可空:False)
 objUserCodePathEN.GcPathId = objRow[conUserCodePath.GcPathId] == DBNull.Value ? null : objRow[conUserCodePath.GcPathId].ToString().Trim(); //GC路径Id(字段类型:char,字段长度:8,是否可空:True)
 objUserCodePathEN.CodePathBackup = objRow[conUserCodePath.CodePathBackup].ToString().Trim(); //备份代码路径(字段类型:varchar,字段长度:200,是否可空:False)
 objUserCodePathEN.SuffixPath = objRow[conUserCodePath.SuffixPath] == DBNull.Value ? null : objRow[conUserCodePath.SuffixPath].ToString().Trim(); //后缀路径(字段类型:varchar,字段长度:50,是否可空:True)
 objUserCodePathEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePath.IsTemplate].ToString().Trim()); //是否模板(字段类型:bit,字段长度:1,是否可空:False)
 objUserCodePathEN.IsExistCodePath = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePath.IsExistCodePath].ToString().Trim()); //是否存在代码路径(字段类型:bit,字段长度:1,是否可空:True)
 objUserCodePathEN.IsExistCodePathBackup = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePath.IsExistCodePathBackup].ToString().Trim()); //是否存在备份路径(字段类型:bit,字段长度:1,是否可空:True)
 objUserCodePathEN.PrjId = objRow[conUserCodePath.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objUserCodePathEN.UpdDate = objRow[conUserCodePath.UpdDate] == DBNull.Value ? null : objRow[conUserCodePath.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objUserCodePathEN.UpdUserId = objRow[conUserCodePath.UpdUserId] == DBNull.Value ? null : objRow[conUserCodePath.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objUserCodePathEN.Memo = objRow[conUserCodePath.Memo] == DBNull.Value ? null : objRow[conUserCodePath.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsUserCodePathDA: GetObjBymId)", objException.Message));
}
return objUserCodePathEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsUserCodePathEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsUserCodePathDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePathDA.GetSpecSQLObj();
strSQL = "Select * from UserCodePath where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsUserCodePathEN objUserCodePathEN = new clsUserCodePathEN()
{
mId = TransNullToInt(objRow[conUserCodePath.mId].ToString().Trim()), //mId
CMProjectAppRelaId = TransNullToInt(objRow[conUserCodePath.CMProjectAppRelaId].ToString().Trim()), //Cm工程应用关系Id
CodeTypeId = objRow[conUserCodePath.CodeTypeId].ToString().Trim(), //代码类型Id
TabMainTypeId = objRow[conUserCodePath.TabMainTypeId] == DBNull.Value ? null : objRow[conUserCodePath.TabMainTypeId].ToString().Trim(), //表主类型Id
IsGeneCode = TransNullToBool(objRow[conUserCodePath.IsGeneCode].ToString().Trim()), //是否生成代码
ProjectFileName = objRow[conUserCodePath.ProjectFileName] == DBNull.Value ? null : objRow[conUserCodePath.ProjectFileName].ToString().Trim(), //工程文件名
ProjectPath = objRow[conUserCodePath.ProjectPath] == DBNull.Value ? null : objRow[conUserCodePath.ProjectPath].ToString().Trim(), //工程路径
PrjFileStateId = objRow[conUserCodePath.PrjFileStateId] == DBNull.Value ? null : objRow[conUserCodePath.PrjFileStateId].ToString().Trim(), //工程文件状态Id
CodePath = objRow[conUserCodePath.CodePath].ToString().Trim(), //代码路径
GcPathId = objRow[conUserCodePath.GcPathId] == DBNull.Value ? null : objRow[conUserCodePath.GcPathId].ToString().Trim(), //GC路径Id
CodePathBackup = objRow[conUserCodePath.CodePathBackup].ToString().Trim(), //备份代码路径
SuffixPath = objRow[conUserCodePath.SuffixPath] == DBNull.Value ? null : objRow[conUserCodePath.SuffixPath].ToString().Trim(), //后缀路径
IsTemplate = TransNullToBool(objRow[conUserCodePath.IsTemplate].ToString().Trim()), //是否模板
IsExistCodePath = TransNullToBool(objRow[conUserCodePath.IsExistCodePath].ToString().Trim()), //是否存在代码路径
IsExistCodePathBackup = TransNullToBool(objRow[conUserCodePath.IsExistCodePathBackup].ToString().Trim()), //是否存在备份路径
PrjId = objRow[conUserCodePath.PrjId].ToString().Trim(), //工程Id
UpdDate = objRow[conUserCodePath.UpdDate] == DBNull.Value ? null : objRow[conUserCodePath.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conUserCodePath.UpdUserId] == DBNull.Value ? null : objRow[conUserCodePath.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conUserCodePath.Memo] == DBNull.Value ? null : objRow[conUserCodePath.Memo].ToString().Trim() //说明
};
objUserCodePathEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objUserCodePathEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsUserCodePathDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsUserCodePathEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsUserCodePathEN objUserCodePathEN = new clsUserCodePathEN();
try
{
objUserCodePathEN.mId = TransNullToInt(objRow[conUserCodePath.mId].ToString().Trim()); //mId
objUserCodePathEN.CMProjectAppRelaId = TransNullToInt(objRow[conUserCodePath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objUserCodePathEN.CodeTypeId = objRow[conUserCodePath.CodeTypeId].ToString().Trim(); //代码类型Id
objUserCodePathEN.TabMainTypeId = objRow[conUserCodePath.TabMainTypeId] == DBNull.Value ? null : objRow[conUserCodePath.TabMainTypeId].ToString().Trim(); //表主类型Id
objUserCodePathEN.IsGeneCode = TransNullToBool(objRow[conUserCodePath.IsGeneCode].ToString().Trim()); //是否生成代码
objUserCodePathEN.ProjectFileName = objRow[conUserCodePath.ProjectFileName] == DBNull.Value ? null : objRow[conUserCodePath.ProjectFileName].ToString().Trim(); //工程文件名
objUserCodePathEN.ProjectPath = objRow[conUserCodePath.ProjectPath] == DBNull.Value ? null : objRow[conUserCodePath.ProjectPath].ToString().Trim(); //工程路径
objUserCodePathEN.PrjFileStateId = objRow[conUserCodePath.PrjFileStateId] == DBNull.Value ? null : objRow[conUserCodePath.PrjFileStateId].ToString().Trim(); //工程文件状态Id
objUserCodePathEN.CodePath = objRow[conUserCodePath.CodePath].ToString().Trim(); //代码路径
objUserCodePathEN.GcPathId = objRow[conUserCodePath.GcPathId] == DBNull.Value ? null : objRow[conUserCodePath.GcPathId].ToString().Trim(); //GC路径Id
objUserCodePathEN.CodePathBackup = objRow[conUserCodePath.CodePathBackup].ToString().Trim(); //备份代码路径
objUserCodePathEN.SuffixPath = objRow[conUserCodePath.SuffixPath] == DBNull.Value ? null : objRow[conUserCodePath.SuffixPath].ToString().Trim(); //后缀路径
objUserCodePathEN.IsTemplate = TransNullToBool(objRow[conUserCodePath.IsTemplate].ToString().Trim()); //是否模板
objUserCodePathEN.IsExistCodePath = TransNullToBool(objRow[conUserCodePath.IsExistCodePath].ToString().Trim()); //是否存在代码路径
objUserCodePathEN.IsExistCodePathBackup = TransNullToBool(objRow[conUserCodePath.IsExistCodePathBackup].ToString().Trim()); //是否存在备份路径
objUserCodePathEN.PrjId = objRow[conUserCodePath.PrjId].ToString().Trim(); //工程Id
objUserCodePathEN.UpdDate = objRow[conUserCodePath.UpdDate] == DBNull.Value ? null : objRow[conUserCodePath.UpdDate].ToString().Trim(); //修改日期
objUserCodePathEN.UpdUserId = objRow[conUserCodePath.UpdUserId] == DBNull.Value ? null : objRow[conUserCodePath.UpdUserId].ToString().Trim(); //修改用户Id
objUserCodePathEN.Memo = objRow[conUserCodePath.Memo] == DBNull.Value ? null : objRow[conUserCodePath.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsUserCodePathDA: GetObjByDataRowUserCodePath)", objException.Message));
}
objUserCodePathEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objUserCodePathEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsUserCodePathEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsUserCodePathEN objUserCodePathEN = new clsUserCodePathEN();
try
{
objUserCodePathEN.mId = TransNullToInt(objRow[conUserCodePath.mId].ToString().Trim()); //mId
objUserCodePathEN.CMProjectAppRelaId = TransNullToInt(objRow[conUserCodePath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objUserCodePathEN.CodeTypeId = objRow[conUserCodePath.CodeTypeId].ToString().Trim(); //代码类型Id
objUserCodePathEN.TabMainTypeId = objRow[conUserCodePath.TabMainTypeId] == DBNull.Value ? null : objRow[conUserCodePath.TabMainTypeId].ToString().Trim(); //表主类型Id
objUserCodePathEN.IsGeneCode = TransNullToBool(objRow[conUserCodePath.IsGeneCode].ToString().Trim()); //是否生成代码
objUserCodePathEN.ProjectFileName = objRow[conUserCodePath.ProjectFileName] == DBNull.Value ? null : objRow[conUserCodePath.ProjectFileName].ToString().Trim(); //工程文件名
objUserCodePathEN.ProjectPath = objRow[conUserCodePath.ProjectPath] == DBNull.Value ? null : objRow[conUserCodePath.ProjectPath].ToString().Trim(); //工程路径
objUserCodePathEN.PrjFileStateId = objRow[conUserCodePath.PrjFileStateId] == DBNull.Value ? null : objRow[conUserCodePath.PrjFileStateId].ToString().Trim(); //工程文件状态Id
objUserCodePathEN.CodePath = objRow[conUserCodePath.CodePath].ToString().Trim(); //代码路径
objUserCodePathEN.GcPathId = objRow[conUserCodePath.GcPathId] == DBNull.Value ? null : objRow[conUserCodePath.GcPathId].ToString().Trim(); //GC路径Id
objUserCodePathEN.CodePathBackup = objRow[conUserCodePath.CodePathBackup].ToString().Trim(); //备份代码路径
objUserCodePathEN.SuffixPath = objRow[conUserCodePath.SuffixPath] == DBNull.Value ? null : objRow[conUserCodePath.SuffixPath].ToString().Trim(); //后缀路径
objUserCodePathEN.IsTemplate = TransNullToBool(objRow[conUserCodePath.IsTemplate].ToString().Trim()); //是否模板
objUserCodePathEN.IsExistCodePath = TransNullToBool(objRow[conUserCodePath.IsExistCodePath].ToString().Trim()); //是否存在代码路径
objUserCodePathEN.IsExistCodePathBackup = TransNullToBool(objRow[conUserCodePath.IsExistCodePathBackup].ToString().Trim()); //是否存在备份路径
objUserCodePathEN.PrjId = objRow[conUserCodePath.PrjId].ToString().Trim(); //工程Id
objUserCodePathEN.UpdDate = objRow[conUserCodePath.UpdDate] == DBNull.Value ? null : objRow[conUserCodePath.UpdDate].ToString().Trim(); //修改日期
objUserCodePathEN.UpdUserId = objRow[conUserCodePath.UpdUserId] == DBNull.Value ? null : objRow[conUserCodePath.UpdUserId].ToString().Trim(); //修改用户Id
objUserCodePathEN.Memo = objRow[conUserCodePath.Memo] == DBNull.Value ? null : objRow[conUserCodePath.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsUserCodePathDA: GetObjByDataRow)", objException.Message));
}
objUserCodePathEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objUserCodePathEN;
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
objSQL = clsUserCodePathDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsUserCodePathEN._CurrTabName, conUserCodePath.mId, 8, "");
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
objSQL = clsUserCodePathDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsUserCodePathEN._CurrTabName, conUserCodePath.mId, 8, strPrefix);
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
 objSQL = clsUserCodePathDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from UserCodePath where " + strCondition;
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
 objSQL = clsUserCodePathDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from UserCodePath where " + strCondition;
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
 objSQL = clsUserCodePathDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("UserCodePath", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsUserCodePathDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePathDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("UserCodePath", strCondition))
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
objSQL = clsUserCodePathDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("UserCodePath");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsUserCodePathEN objUserCodePathEN)
 {
 objUserCodePathEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserCodePathEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUserCodePathEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePathDA.GetSpecSQLObj();
strSQL = "Select * from UserCodePath where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "UserCodePath");
objRow = objDS.Tables["UserCodePath"].NewRow();
objRow[conUserCodePath.CMProjectAppRelaId] = objUserCodePathEN.CMProjectAppRelaId; //Cm工程应用关系Id
objRow[conUserCodePath.CodeTypeId] = objUserCodePathEN.CodeTypeId; //代码类型Id
 if (objUserCodePathEN.TabMainTypeId !=  "")
 {
objRow[conUserCodePath.TabMainTypeId] = objUserCodePathEN.TabMainTypeId; //表主类型Id
 }
objRow[conUserCodePath.IsGeneCode] = objUserCodePathEN.IsGeneCode; //是否生成代码
 if (objUserCodePathEN.ProjectFileName !=  "")
 {
objRow[conUserCodePath.ProjectFileName] = objUserCodePathEN.ProjectFileName; //工程文件名
 }
 if (objUserCodePathEN.ProjectPath !=  "")
 {
objRow[conUserCodePath.ProjectPath] = objUserCodePathEN.ProjectPath; //工程路径
 }
 if (objUserCodePathEN.PrjFileStateId !=  "")
 {
objRow[conUserCodePath.PrjFileStateId] = objUserCodePathEN.PrjFileStateId; //工程文件状态Id
 }
objRow[conUserCodePath.CodePath] = objUserCodePathEN.CodePath; //代码路径
 if (objUserCodePathEN.GcPathId !=  "")
 {
objRow[conUserCodePath.GcPathId] = objUserCodePathEN.GcPathId; //GC路径Id
 }
objRow[conUserCodePath.CodePathBackup] = objUserCodePathEN.CodePathBackup; //备份代码路径
 if (objUserCodePathEN.SuffixPath !=  "")
 {
objRow[conUserCodePath.SuffixPath] = objUserCodePathEN.SuffixPath; //后缀路径
 }
objRow[conUserCodePath.IsTemplate] = objUserCodePathEN.IsTemplate; //是否模板
objRow[conUserCodePath.IsExistCodePath] = objUserCodePathEN.IsExistCodePath; //是否存在代码路径
objRow[conUserCodePath.IsExistCodePathBackup] = objUserCodePathEN.IsExistCodePathBackup; //是否存在备份路径
objRow[conUserCodePath.PrjId] = objUserCodePathEN.PrjId; //工程Id
 if (objUserCodePathEN.UpdDate !=  "")
 {
objRow[conUserCodePath.UpdDate] = objUserCodePathEN.UpdDate; //修改日期
 }
 if (objUserCodePathEN.UpdUserId !=  "")
 {
objRow[conUserCodePath.UpdUserId] = objUserCodePathEN.UpdUserId; //修改用户Id
 }
 if (objUserCodePathEN.Memo !=  "")
 {
objRow[conUserCodePath.Memo] = objUserCodePathEN.Memo; //说明
 }
objDS.Tables[clsUserCodePathEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsUserCodePathEN._CurrTabName);
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
 /// <param name = "objUserCodePathEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsUserCodePathEN objUserCodePathEN)
{
 objUserCodePathEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserCodePathEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUserCodePathEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(conUserCodePath.CMProjectAppRelaId);
 arrValueListForInsert.Add(objUserCodePathEN.CMProjectAppRelaId.ToString());
 
 if (objUserCodePathEN.CodeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePath.CodeTypeId);
 var strCodeTypeId = objUserCodePathEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTypeId + "'");
 }
 
 if (objUserCodePathEN.TabMainTypeId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePath.TabMainTypeId);
 var strTabMainTypeId = objUserCodePathEN.TabMainTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabMainTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conUserCodePath.IsGeneCode);
 arrValueListForInsert.Add("'" + (objUserCodePathEN.IsGeneCode  ==  false ? "0" : "1") + "'");
 
 if (objUserCodePathEN.ProjectFileName !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePath.ProjectFileName);
 var strProjectFileName = objUserCodePathEN.ProjectFileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProjectFileName + "'");
 }
 
 if (objUserCodePathEN.ProjectPath !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePath.ProjectPath);
 var strProjectPath = objUserCodePathEN.ProjectPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProjectPath + "'");
 }
 
 if (objUserCodePathEN.PrjFileStateId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePath.PrjFileStateId);
 var strPrjFileStateId = objUserCodePathEN.PrjFileStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjFileStateId + "'");
 }
 
 if (objUserCodePathEN.CodePath !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePath.CodePath);
 var strCodePath = objUserCodePathEN.CodePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodePath + "'");
 }
 
 if (objUserCodePathEN.GcPathId  ==  "")
 {
 objUserCodePathEN.GcPathId = null;
 }
 if (objUserCodePathEN.GcPathId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePath.GcPathId);
 var strGcPathId = objUserCodePathEN.GcPathId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGcPathId + "'");
 }
 
 if (objUserCodePathEN.CodePathBackup !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePath.CodePathBackup);
 var strCodePathBackup = objUserCodePathEN.CodePathBackup.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodePathBackup + "'");
 }
 
 if (objUserCodePathEN.SuffixPath !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePath.SuffixPath);
 var strSuffixPath = objUserCodePathEN.SuffixPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSuffixPath + "'");
 }
 
 arrFieldListForInsert.Add(conUserCodePath.IsTemplate);
 arrValueListForInsert.Add("'" + (objUserCodePathEN.IsTemplate  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conUserCodePath.IsExistCodePath);
 arrValueListForInsert.Add("'" + (objUserCodePathEN.IsExistCodePath  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conUserCodePath.IsExistCodePathBackup);
 arrValueListForInsert.Add("'" + (objUserCodePathEN.IsExistCodePathBackup  ==  false ? "0" : "1") + "'");
 
 if (objUserCodePathEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePath.PrjId);
 var strPrjId = objUserCodePathEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objUserCodePathEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePath.UpdDate);
 var strUpdDate = objUserCodePathEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objUserCodePathEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePath.UpdUserId);
 var strUpdUserId = objUserCodePathEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objUserCodePathEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePath.Memo);
 var strMemo = objUserCodePathEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into UserCodePath");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePathDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objUserCodePathEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsUserCodePathEN objUserCodePathEN)
{
 objUserCodePathEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserCodePathEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUserCodePathEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(conUserCodePath.CMProjectAppRelaId);
 arrValueListForInsert.Add(objUserCodePathEN.CMProjectAppRelaId.ToString());
 
 if (objUserCodePathEN.CodeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePath.CodeTypeId);
 var strCodeTypeId = objUserCodePathEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTypeId + "'");
 }
 
 if (objUserCodePathEN.TabMainTypeId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePath.TabMainTypeId);
 var strTabMainTypeId = objUserCodePathEN.TabMainTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabMainTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conUserCodePath.IsGeneCode);
 arrValueListForInsert.Add("'" + (objUserCodePathEN.IsGeneCode  ==  false ? "0" : "1") + "'");
 
 if (objUserCodePathEN.ProjectFileName !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePath.ProjectFileName);
 var strProjectFileName = objUserCodePathEN.ProjectFileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProjectFileName + "'");
 }
 
 if (objUserCodePathEN.ProjectPath !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePath.ProjectPath);
 var strProjectPath = objUserCodePathEN.ProjectPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProjectPath + "'");
 }
 
 if (objUserCodePathEN.PrjFileStateId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePath.PrjFileStateId);
 var strPrjFileStateId = objUserCodePathEN.PrjFileStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjFileStateId + "'");
 }
 
 if (objUserCodePathEN.CodePath !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePath.CodePath);
 var strCodePath = objUserCodePathEN.CodePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodePath + "'");
 }
 
 if (objUserCodePathEN.GcPathId  ==  "")
 {
 objUserCodePathEN.GcPathId = null;
 }
 if (objUserCodePathEN.GcPathId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePath.GcPathId);
 var strGcPathId = objUserCodePathEN.GcPathId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGcPathId + "'");
 }
 
 if (objUserCodePathEN.CodePathBackup !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePath.CodePathBackup);
 var strCodePathBackup = objUserCodePathEN.CodePathBackup.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodePathBackup + "'");
 }
 
 if (objUserCodePathEN.SuffixPath !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePath.SuffixPath);
 var strSuffixPath = objUserCodePathEN.SuffixPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSuffixPath + "'");
 }
 
 arrFieldListForInsert.Add(conUserCodePath.IsTemplate);
 arrValueListForInsert.Add("'" + (objUserCodePathEN.IsTemplate  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conUserCodePath.IsExistCodePath);
 arrValueListForInsert.Add("'" + (objUserCodePathEN.IsExistCodePath  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conUserCodePath.IsExistCodePathBackup);
 arrValueListForInsert.Add("'" + (objUserCodePathEN.IsExistCodePathBackup  ==  false ? "0" : "1") + "'");
 
 if (objUserCodePathEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePath.PrjId);
 var strPrjId = objUserCodePathEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objUserCodePathEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePath.UpdDate);
 var strUpdDate = objUserCodePathEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objUserCodePathEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePath.UpdUserId);
 var strUpdUserId = objUserCodePathEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objUserCodePathEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePath.Memo);
 var strMemo = objUserCodePathEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into UserCodePath");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePathDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objUserCodePathEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsUserCodePathEN objUserCodePathEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objUserCodePathEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserCodePathEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUserCodePathEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(conUserCodePath.CMProjectAppRelaId);
 arrValueListForInsert.Add(objUserCodePathEN.CMProjectAppRelaId.ToString());
 
 if (objUserCodePathEN.CodeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePath.CodeTypeId);
 var strCodeTypeId = objUserCodePathEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTypeId + "'");
 }
 
 if (objUserCodePathEN.TabMainTypeId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePath.TabMainTypeId);
 var strTabMainTypeId = objUserCodePathEN.TabMainTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabMainTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conUserCodePath.IsGeneCode);
 arrValueListForInsert.Add("'" + (objUserCodePathEN.IsGeneCode  ==  false ? "0" : "1") + "'");
 
 if (objUserCodePathEN.ProjectFileName !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePath.ProjectFileName);
 var strProjectFileName = objUserCodePathEN.ProjectFileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProjectFileName + "'");
 }
 
 if (objUserCodePathEN.ProjectPath !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePath.ProjectPath);
 var strProjectPath = objUserCodePathEN.ProjectPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProjectPath + "'");
 }
 
 if (objUserCodePathEN.PrjFileStateId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePath.PrjFileStateId);
 var strPrjFileStateId = objUserCodePathEN.PrjFileStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjFileStateId + "'");
 }
 
 if (objUserCodePathEN.CodePath !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePath.CodePath);
 var strCodePath = objUserCodePathEN.CodePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodePath + "'");
 }
 
 if (objUserCodePathEN.GcPathId  ==  "")
 {
 objUserCodePathEN.GcPathId = null;
 }
 if (objUserCodePathEN.GcPathId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePath.GcPathId);
 var strGcPathId = objUserCodePathEN.GcPathId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGcPathId + "'");
 }
 
 if (objUserCodePathEN.CodePathBackup !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePath.CodePathBackup);
 var strCodePathBackup = objUserCodePathEN.CodePathBackup.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodePathBackup + "'");
 }
 
 if (objUserCodePathEN.SuffixPath !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePath.SuffixPath);
 var strSuffixPath = objUserCodePathEN.SuffixPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSuffixPath + "'");
 }
 
 arrFieldListForInsert.Add(conUserCodePath.IsTemplate);
 arrValueListForInsert.Add("'" + (objUserCodePathEN.IsTemplate  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conUserCodePath.IsExistCodePath);
 arrValueListForInsert.Add("'" + (objUserCodePathEN.IsExistCodePath  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conUserCodePath.IsExistCodePathBackup);
 arrValueListForInsert.Add("'" + (objUserCodePathEN.IsExistCodePathBackup  ==  false ? "0" : "1") + "'");
 
 if (objUserCodePathEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePath.PrjId);
 var strPrjId = objUserCodePathEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objUserCodePathEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePath.UpdDate);
 var strUpdDate = objUserCodePathEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objUserCodePathEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePath.UpdUserId);
 var strUpdUserId = objUserCodePathEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objUserCodePathEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePath.Memo);
 var strMemo = objUserCodePathEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into UserCodePath");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePathDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objUserCodePathEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsUserCodePathEN objUserCodePathEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objUserCodePathEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserCodePathEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUserCodePathEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(conUserCodePath.CMProjectAppRelaId);
 arrValueListForInsert.Add(objUserCodePathEN.CMProjectAppRelaId.ToString());
 
 if (objUserCodePathEN.CodeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePath.CodeTypeId);
 var strCodeTypeId = objUserCodePathEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTypeId + "'");
 }
 
 if (objUserCodePathEN.TabMainTypeId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePath.TabMainTypeId);
 var strTabMainTypeId = objUserCodePathEN.TabMainTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabMainTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conUserCodePath.IsGeneCode);
 arrValueListForInsert.Add("'" + (objUserCodePathEN.IsGeneCode  ==  false ? "0" : "1") + "'");
 
 if (objUserCodePathEN.ProjectFileName !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePath.ProjectFileName);
 var strProjectFileName = objUserCodePathEN.ProjectFileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProjectFileName + "'");
 }
 
 if (objUserCodePathEN.ProjectPath !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePath.ProjectPath);
 var strProjectPath = objUserCodePathEN.ProjectPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProjectPath + "'");
 }
 
 if (objUserCodePathEN.PrjFileStateId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePath.PrjFileStateId);
 var strPrjFileStateId = objUserCodePathEN.PrjFileStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjFileStateId + "'");
 }
 
 if (objUserCodePathEN.CodePath !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePath.CodePath);
 var strCodePath = objUserCodePathEN.CodePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodePath + "'");
 }
 
 if (objUserCodePathEN.GcPathId  ==  "")
 {
 objUserCodePathEN.GcPathId = null;
 }
 if (objUserCodePathEN.GcPathId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePath.GcPathId);
 var strGcPathId = objUserCodePathEN.GcPathId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGcPathId + "'");
 }
 
 if (objUserCodePathEN.CodePathBackup !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePath.CodePathBackup);
 var strCodePathBackup = objUserCodePathEN.CodePathBackup.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodePathBackup + "'");
 }
 
 if (objUserCodePathEN.SuffixPath !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePath.SuffixPath);
 var strSuffixPath = objUserCodePathEN.SuffixPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSuffixPath + "'");
 }
 
 arrFieldListForInsert.Add(conUserCodePath.IsTemplate);
 arrValueListForInsert.Add("'" + (objUserCodePathEN.IsTemplate  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conUserCodePath.IsExistCodePath);
 arrValueListForInsert.Add("'" + (objUserCodePathEN.IsExistCodePath  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conUserCodePath.IsExistCodePathBackup);
 arrValueListForInsert.Add("'" + (objUserCodePathEN.IsExistCodePathBackup  ==  false ? "0" : "1") + "'");
 
 if (objUserCodePathEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePath.PrjId);
 var strPrjId = objUserCodePathEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objUserCodePathEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePath.UpdDate);
 var strUpdDate = objUserCodePathEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objUserCodePathEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePath.UpdUserId);
 var strUpdUserId = objUserCodePathEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objUserCodePathEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePath.Memo);
 var strMemo = objUserCodePathEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into UserCodePath");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePathDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewUserCodePaths(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePathDA.GetSpecSQLObj();
strSQL = "Select * from UserCodePath where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "UserCodePath");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngmId = TransNullToInt(oRow[conUserCodePath.mId].ToString().Trim());
if (IsExist(lngmId))
{
 string strResult = "关键字变量值为:" + string.Format("mId = {0}", lngmId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsUserCodePathEN._CurrTabName ].NewRow();
objRow[conUserCodePath.CMProjectAppRelaId] = oRow[conUserCodePath.CMProjectAppRelaId].ToString().Trim(); //Cm工程应用关系Id
objRow[conUserCodePath.CodeTypeId] = oRow[conUserCodePath.CodeTypeId].ToString().Trim(); //代码类型Id
objRow[conUserCodePath.TabMainTypeId] = oRow[conUserCodePath.TabMainTypeId].ToString().Trim(); //表主类型Id
objRow[conUserCodePath.IsGeneCode] = oRow[conUserCodePath.IsGeneCode].ToString().Trim(); //是否生成代码
objRow[conUserCodePath.ProjectFileName] = oRow[conUserCodePath.ProjectFileName].ToString().Trim(); //工程文件名
objRow[conUserCodePath.ProjectPath] = oRow[conUserCodePath.ProjectPath].ToString().Trim(); //工程路径
objRow[conUserCodePath.PrjFileStateId] = oRow[conUserCodePath.PrjFileStateId].ToString().Trim(); //工程文件状态Id
objRow[conUserCodePath.CodePath] = oRow[conUserCodePath.CodePath].ToString().Trim(); //代码路径
objRow[conUserCodePath.GcPathId] = oRow[conUserCodePath.GcPathId].ToString().Trim(); //GC路径Id
objRow[conUserCodePath.CodePathBackup] = oRow[conUserCodePath.CodePathBackup].ToString().Trim(); //备份代码路径
objRow[conUserCodePath.SuffixPath] = oRow[conUserCodePath.SuffixPath].ToString().Trim(); //后缀路径
objRow[conUserCodePath.IsTemplate] = oRow[conUserCodePath.IsTemplate].ToString().Trim(); //是否模板
objRow[conUserCodePath.IsExistCodePath] = oRow[conUserCodePath.IsExistCodePath].ToString().Trim(); //是否存在代码路径
objRow[conUserCodePath.IsExistCodePathBackup] = oRow[conUserCodePath.IsExistCodePathBackup].ToString().Trim(); //是否存在备份路径
objRow[conUserCodePath.PrjId] = oRow[conUserCodePath.PrjId].ToString().Trim(); //工程Id
objRow[conUserCodePath.UpdDate] = oRow[conUserCodePath.UpdDate].ToString().Trim(); //修改日期
objRow[conUserCodePath.UpdUserId] = oRow[conUserCodePath.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conUserCodePath.Memo] = oRow[conUserCodePath.Memo].ToString().Trim(); //说明
 objDS.Tables[clsUserCodePathEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsUserCodePathEN._CurrTabName);
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
 /// <param name = "objUserCodePathEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsUserCodePathEN objUserCodePathEN)
{
 objUserCodePathEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserCodePathEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUserCodePathEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePathDA.GetSpecSQLObj();
strSQL = "Select * from UserCodePath where mId = " + ""+ objUserCodePathEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsUserCodePathEN._CurrTabName);
if (objDS.Tables[clsUserCodePathEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objUserCodePathEN.mId+"");
return false;
}
objRow = objDS.Tables[clsUserCodePathEN._CurrTabName].Rows[0];
 if (objUserCodePathEN.IsUpdated(conUserCodePath.CMProjectAppRelaId))
 {
objRow[conUserCodePath.CMProjectAppRelaId] = objUserCodePathEN.CMProjectAppRelaId; //Cm工程应用关系Id
 }
 if (objUserCodePathEN.IsUpdated(conUserCodePath.CodeTypeId))
 {
objRow[conUserCodePath.CodeTypeId] = objUserCodePathEN.CodeTypeId; //代码类型Id
 }
 if (objUserCodePathEN.IsUpdated(conUserCodePath.TabMainTypeId))
 {
objRow[conUserCodePath.TabMainTypeId] = objUserCodePathEN.TabMainTypeId; //表主类型Id
 }
 if (objUserCodePathEN.IsUpdated(conUserCodePath.IsGeneCode))
 {
objRow[conUserCodePath.IsGeneCode] = objUserCodePathEN.IsGeneCode; //是否生成代码
 }
 if (objUserCodePathEN.IsUpdated(conUserCodePath.ProjectFileName))
 {
objRow[conUserCodePath.ProjectFileName] = objUserCodePathEN.ProjectFileName; //工程文件名
 }
 if (objUserCodePathEN.IsUpdated(conUserCodePath.ProjectPath))
 {
objRow[conUserCodePath.ProjectPath] = objUserCodePathEN.ProjectPath; //工程路径
 }
 if (objUserCodePathEN.IsUpdated(conUserCodePath.PrjFileStateId))
 {
objRow[conUserCodePath.PrjFileStateId] = objUserCodePathEN.PrjFileStateId; //工程文件状态Id
 }
 if (objUserCodePathEN.IsUpdated(conUserCodePath.CodePath))
 {
objRow[conUserCodePath.CodePath] = objUserCodePathEN.CodePath; //代码路径
 }
 if (objUserCodePathEN.IsUpdated(conUserCodePath.GcPathId))
 {
objRow[conUserCodePath.GcPathId] = objUserCodePathEN.GcPathId; //GC路径Id
 }
 if (objUserCodePathEN.IsUpdated(conUserCodePath.CodePathBackup))
 {
objRow[conUserCodePath.CodePathBackup] = objUserCodePathEN.CodePathBackup; //备份代码路径
 }
 if (objUserCodePathEN.IsUpdated(conUserCodePath.SuffixPath))
 {
objRow[conUserCodePath.SuffixPath] = objUserCodePathEN.SuffixPath; //后缀路径
 }
 if (objUserCodePathEN.IsUpdated(conUserCodePath.IsTemplate))
 {
objRow[conUserCodePath.IsTemplate] = objUserCodePathEN.IsTemplate; //是否模板
 }
 if (objUserCodePathEN.IsUpdated(conUserCodePath.IsExistCodePath))
 {
objRow[conUserCodePath.IsExistCodePath] = objUserCodePathEN.IsExistCodePath; //是否存在代码路径
 }
 if (objUserCodePathEN.IsUpdated(conUserCodePath.IsExistCodePathBackup))
 {
objRow[conUserCodePath.IsExistCodePathBackup] = objUserCodePathEN.IsExistCodePathBackup; //是否存在备份路径
 }
 if (objUserCodePathEN.IsUpdated(conUserCodePath.PrjId))
 {
objRow[conUserCodePath.PrjId] = objUserCodePathEN.PrjId; //工程Id
 }
 if (objUserCodePathEN.IsUpdated(conUserCodePath.UpdDate))
 {
objRow[conUserCodePath.UpdDate] = objUserCodePathEN.UpdDate; //修改日期
 }
 if (objUserCodePathEN.IsUpdated(conUserCodePath.UpdUserId))
 {
objRow[conUserCodePath.UpdUserId] = objUserCodePathEN.UpdUserId; //修改用户Id
 }
 if (objUserCodePathEN.IsUpdated(conUserCodePath.Memo))
 {
objRow[conUserCodePath.Memo] = objUserCodePathEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsUserCodePathEN._CurrTabName);
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
 /// <param name = "objUserCodePathEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsUserCodePathEN objUserCodePathEN)
{
 objUserCodePathEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserCodePathEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUserCodePathEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePathDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update UserCodePath Set ");
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.CMProjectAppRelaId))
 {
 sbSQL.AppendFormat("{1} = {0},",objUserCodePathEN.CMProjectAppRelaId, conUserCodePath.CMProjectAppRelaId); //Cm工程应用关系Id
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.CodeTypeId))
 {
 if (objUserCodePathEN.CodeTypeId !=  null)
 {
 var strCodeTypeId = objUserCodePathEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCodeTypeId, conUserCodePath.CodeTypeId); //代码类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserCodePath.CodeTypeId); //代码类型Id
 }
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.TabMainTypeId))
 {
 if (objUserCodePathEN.TabMainTypeId !=  null)
 {
 var strTabMainTypeId = objUserCodePathEN.TabMainTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabMainTypeId, conUserCodePath.TabMainTypeId); //表主类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserCodePath.TabMainTypeId); //表主类型Id
 }
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.IsGeneCode))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objUserCodePathEN.IsGeneCode == true?"1":"0", conUserCodePath.IsGeneCode); //是否生成代码
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.ProjectFileName))
 {
 if (objUserCodePathEN.ProjectFileName !=  null)
 {
 var strProjectFileName = objUserCodePathEN.ProjectFileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProjectFileName, conUserCodePath.ProjectFileName); //工程文件名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserCodePath.ProjectFileName); //工程文件名
 }
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.ProjectPath))
 {
 if (objUserCodePathEN.ProjectPath !=  null)
 {
 var strProjectPath = objUserCodePathEN.ProjectPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProjectPath, conUserCodePath.ProjectPath); //工程路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserCodePath.ProjectPath); //工程路径
 }
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.PrjFileStateId))
 {
 if (objUserCodePathEN.PrjFileStateId !=  null)
 {
 var strPrjFileStateId = objUserCodePathEN.PrjFileStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjFileStateId, conUserCodePath.PrjFileStateId); //工程文件状态Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserCodePath.PrjFileStateId); //工程文件状态Id
 }
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.CodePath))
 {
 if (objUserCodePathEN.CodePath !=  null)
 {
 var strCodePath = objUserCodePathEN.CodePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCodePath, conUserCodePath.CodePath); //代码路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserCodePath.CodePath); //代码路径
 }
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.GcPathId))
 {
 if (objUserCodePathEN.GcPathId  ==  "")
 {
 objUserCodePathEN.GcPathId = null;
 }
 if (objUserCodePathEN.GcPathId !=  null)
 {
 var strGcPathId = objUserCodePathEN.GcPathId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGcPathId, conUserCodePath.GcPathId); //GC路径Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserCodePath.GcPathId); //GC路径Id
 }
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.CodePathBackup))
 {
 if (objUserCodePathEN.CodePathBackup !=  null)
 {
 var strCodePathBackup = objUserCodePathEN.CodePathBackup.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCodePathBackup, conUserCodePath.CodePathBackup); //备份代码路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserCodePath.CodePathBackup); //备份代码路径
 }
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.SuffixPath))
 {
 if (objUserCodePathEN.SuffixPath !=  null)
 {
 var strSuffixPath = objUserCodePathEN.SuffixPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSuffixPath, conUserCodePath.SuffixPath); //后缀路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserCodePath.SuffixPath); //后缀路径
 }
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.IsTemplate))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objUserCodePathEN.IsTemplate == true?"1":"0", conUserCodePath.IsTemplate); //是否模板
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.IsExistCodePath))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objUserCodePathEN.IsExistCodePath == true?"1":"0", conUserCodePath.IsExistCodePath); //是否存在代码路径
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.IsExistCodePathBackup))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objUserCodePathEN.IsExistCodePathBackup == true?"1":"0", conUserCodePath.IsExistCodePathBackup); //是否存在备份路径
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.PrjId))
 {
 if (objUserCodePathEN.PrjId !=  null)
 {
 var strPrjId = objUserCodePathEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conUserCodePath.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserCodePath.PrjId); //工程Id
 }
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.UpdDate))
 {
 if (objUserCodePathEN.UpdDate !=  null)
 {
 var strUpdDate = objUserCodePathEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conUserCodePath.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserCodePath.UpdDate); //修改日期
 }
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.UpdUserId))
 {
 if (objUserCodePathEN.UpdUserId !=  null)
 {
 var strUpdUserId = objUserCodePathEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conUserCodePath.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserCodePath.UpdUserId); //修改用户Id
 }
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.Memo))
 {
 if (objUserCodePathEN.Memo !=  null)
 {
 var strMemo = objUserCodePathEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conUserCodePath.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserCodePath.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objUserCodePathEN.mId); 
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
 /// <param name = "objUserCodePathEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsUserCodePathEN objUserCodePathEN, string strCondition)
{
 objUserCodePathEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserCodePathEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUserCodePathEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePathDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update UserCodePath Set ");
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.CMProjectAppRelaId))
 {
 sbSQL.AppendFormat(" CMProjectAppRelaId = {0},", objUserCodePathEN.CMProjectAppRelaId); //Cm工程应用关系Id
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.CodeTypeId))
 {
 if (objUserCodePathEN.CodeTypeId !=  null)
 {
 var strCodeTypeId = objUserCodePathEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodeTypeId = '{0}',", strCodeTypeId); //代码类型Id
 }
 else
 {
 sbSQL.Append(" CodeTypeId = null,"); //代码类型Id
 }
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.TabMainTypeId))
 {
 if (objUserCodePathEN.TabMainTypeId !=  null)
 {
 var strTabMainTypeId = objUserCodePathEN.TabMainTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabMainTypeId = '{0}',", strTabMainTypeId); //表主类型Id
 }
 else
 {
 sbSQL.Append(" TabMainTypeId = null,"); //表主类型Id
 }
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.IsGeneCode))
 {
 sbSQL.AppendFormat(" IsGeneCode = '{0}',", objUserCodePathEN.IsGeneCode == true?"1":"0"); //是否生成代码
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.ProjectFileName))
 {
 if (objUserCodePathEN.ProjectFileName !=  null)
 {
 var strProjectFileName = objUserCodePathEN.ProjectFileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProjectFileName = '{0}',", strProjectFileName); //工程文件名
 }
 else
 {
 sbSQL.Append(" ProjectFileName = null,"); //工程文件名
 }
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.ProjectPath))
 {
 if (objUserCodePathEN.ProjectPath !=  null)
 {
 var strProjectPath = objUserCodePathEN.ProjectPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProjectPath = '{0}',", strProjectPath); //工程路径
 }
 else
 {
 sbSQL.Append(" ProjectPath = null,"); //工程路径
 }
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.PrjFileStateId))
 {
 if (objUserCodePathEN.PrjFileStateId !=  null)
 {
 var strPrjFileStateId = objUserCodePathEN.PrjFileStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjFileStateId = '{0}',", strPrjFileStateId); //工程文件状态Id
 }
 else
 {
 sbSQL.Append(" PrjFileStateId = null,"); //工程文件状态Id
 }
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.CodePath))
 {
 if (objUserCodePathEN.CodePath !=  null)
 {
 var strCodePath = objUserCodePathEN.CodePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodePath = '{0}',", strCodePath); //代码路径
 }
 else
 {
 sbSQL.Append(" CodePath = null,"); //代码路径
 }
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.GcPathId))
 {
 if (objUserCodePathEN.GcPathId  ==  "")
 {
 objUserCodePathEN.GcPathId = null;
 }
 if (objUserCodePathEN.GcPathId !=  null)
 {
 var strGcPathId = objUserCodePathEN.GcPathId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GcPathId = '{0}',", strGcPathId); //GC路径Id
 }
 else
 {
 sbSQL.Append(" GcPathId = null,"); //GC路径Id
 }
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.CodePathBackup))
 {
 if (objUserCodePathEN.CodePathBackup !=  null)
 {
 var strCodePathBackup = objUserCodePathEN.CodePathBackup.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodePathBackup = '{0}',", strCodePathBackup); //备份代码路径
 }
 else
 {
 sbSQL.Append(" CodePathBackup = null,"); //备份代码路径
 }
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.SuffixPath))
 {
 if (objUserCodePathEN.SuffixPath !=  null)
 {
 var strSuffixPath = objUserCodePathEN.SuffixPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SuffixPath = '{0}',", strSuffixPath); //后缀路径
 }
 else
 {
 sbSQL.Append(" SuffixPath = null,"); //后缀路径
 }
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.IsTemplate))
 {
 sbSQL.AppendFormat(" IsTemplate = '{0}',", objUserCodePathEN.IsTemplate == true?"1":"0"); //是否模板
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.IsExistCodePath))
 {
 sbSQL.AppendFormat(" IsExistCodePath = '{0}',", objUserCodePathEN.IsExistCodePath == true?"1":"0"); //是否存在代码路径
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.IsExistCodePathBackup))
 {
 sbSQL.AppendFormat(" IsExistCodePathBackup = '{0}',", objUserCodePathEN.IsExistCodePathBackup == true?"1":"0"); //是否存在备份路径
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.PrjId))
 {
 if (objUserCodePathEN.PrjId !=  null)
 {
 var strPrjId = objUserCodePathEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.UpdDate))
 {
 if (objUserCodePathEN.UpdDate !=  null)
 {
 var strUpdDate = objUserCodePathEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.UpdUserId))
 {
 if (objUserCodePathEN.UpdUserId !=  null)
 {
 var strUpdUserId = objUserCodePathEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.Memo))
 {
 if (objUserCodePathEN.Memo !=  null)
 {
 var strMemo = objUserCodePathEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objUserCodePathEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsUserCodePathEN objUserCodePathEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objUserCodePathEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserCodePathEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUserCodePathEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePathDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update UserCodePath Set ");
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.CMProjectAppRelaId))
 {
 sbSQL.AppendFormat(" CMProjectAppRelaId = {0},", objUserCodePathEN.CMProjectAppRelaId); //Cm工程应用关系Id
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.CodeTypeId))
 {
 if (objUserCodePathEN.CodeTypeId !=  null)
 {
 var strCodeTypeId = objUserCodePathEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodeTypeId = '{0}',", strCodeTypeId); //代码类型Id
 }
 else
 {
 sbSQL.Append(" CodeTypeId = null,"); //代码类型Id
 }
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.TabMainTypeId))
 {
 if (objUserCodePathEN.TabMainTypeId !=  null)
 {
 var strTabMainTypeId = objUserCodePathEN.TabMainTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabMainTypeId = '{0}',", strTabMainTypeId); //表主类型Id
 }
 else
 {
 sbSQL.Append(" TabMainTypeId = null,"); //表主类型Id
 }
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.IsGeneCode))
 {
 sbSQL.AppendFormat(" IsGeneCode = '{0}',", objUserCodePathEN.IsGeneCode == true?"1":"0"); //是否生成代码
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.ProjectFileName))
 {
 if (objUserCodePathEN.ProjectFileName !=  null)
 {
 var strProjectFileName = objUserCodePathEN.ProjectFileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProjectFileName = '{0}',", strProjectFileName); //工程文件名
 }
 else
 {
 sbSQL.Append(" ProjectFileName = null,"); //工程文件名
 }
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.ProjectPath))
 {
 if (objUserCodePathEN.ProjectPath !=  null)
 {
 var strProjectPath = objUserCodePathEN.ProjectPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProjectPath = '{0}',", strProjectPath); //工程路径
 }
 else
 {
 sbSQL.Append(" ProjectPath = null,"); //工程路径
 }
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.PrjFileStateId))
 {
 if (objUserCodePathEN.PrjFileStateId !=  null)
 {
 var strPrjFileStateId = objUserCodePathEN.PrjFileStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjFileStateId = '{0}',", strPrjFileStateId); //工程文件状态Id
 }
 else
 {
 sbSQL.Append(" PrjFileStateId = null,"); //工程文件状态Id
 }
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.CodePath))
 {
 if (objUserCodePathEN.CodePath !=  null)
 {
 var strCodePath = objUserCodePathEN.CodePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodePath = '{0}',", strCodePath); //代码路径
 }
 else
 {
 sbSQL.Append(" CodePath = null,"); //代码路径
 }
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.GcPathId))
 {
 if (objUserCodePathEN.GcPathId  ==  "")
 {
 objUserCodePathEN.GcPathId = null;
 }
 if (objUserCodePathEN.GcPathId !=  null)
 {
 var strGcPathId = objUserCodePathEN.GcPathId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GcPathId = '{0}',", strGcPathId); //GC路径Id
 }
 else
 {
 sbSQL.Append(" GcPathId = null,"); //GC路径Id
 }
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.CodePathBackup))
 {
 if (objUserCodePathEN.CodePathBackup !=  null)
 {
 var strCodePathBackup = objUserCodePathEN.CodePathBackup.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodePathBackup = '{0}',", strCodePathBackup); //备份代码路径
 }
 else
 {
 sbSQL.Append(" CodePathBackup = null,"); //备份代码路径
 }
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.SuffixPath))
 {
 if (objUserCodePathEN.SuffixPath !=  null)
 {
 var strSuffixPath = objUserCodePathEN.SuffixPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SuffixPath = '{0}',", strSuffixPath); //后缀路径
 }
 else
 {
 sbSQL.Append(" SuffixPath = null,"); //后缀路径
 }
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.IsTemplate))
 {
 sbSQL.AppendFormat(" IsTemplate = '{0}',", objUserCodePathEN.IsTemplate == true?"1":"0"); //是否模板
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.IsExistCodePath))
 {
 sbSQL.AppendFormat(" IsExistCodePath = '{0}',", objUserCodePathEN.IsExistCodePath == true?"1":"0"); //是否存在代码路径
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.IsExistCodePathBackup))
 {
 sbSQL.AppendFormat(" IsExistCodePathBackup = '{0}',", objUserCodePathEN.IsExistCodePathBackup == true?"1":"0"); //是否存在备份路径
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.PrjId))
 {
 if (objUserCodePathEN.PrjId !=  null)
 {
 var strPrjId = objUserCodePathEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.UpdDate))
 {
 if (objUserCodePathEN.UpdDate !=  null)
 {
 var strUpdDate = objUserCodePathEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.UpdUserId))
 {
 if (objUserCodePathEN.UpdUserId !=  null)
 {
 var strUpdUserId = objUserCodePathEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.Memo))
 {
 if (objUserCodePathEN.Memo !=  null)
 {
 var strMemo = objUserCodePathEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objUserCodePathEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsUserCodePathEN objUserCodePathEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objUserCodePathEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserCodePathEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUserCodePathEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePathDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update UserCodePath Set ");
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.CMProjectAppRelaId))
 {
 sbSQL.AppendFormat("{1} = {0},",objUserCodePathEN.CMProjectAppRelaId, conUserCodePath.CMProjectAppRelaId); //Cm工程应用关系Id
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.CodeTypeId))
 {
 if (objUserCodePathEN.CodeTypeId !=  null)
 {
 var strCodeTypeId = objUserCodePathEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCodeTypeId, conUserCodePath.CodeTypeId); //代码类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserCodePath.CodeTypeId); //代码类型Id
 }
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.TabMainTypeId))
 {
 if (objUserCodePathEN.TabMainTypeId !=  null)
 {
 var strTabMainTypeId = objUserCodePathEN.TabMainTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabMainTypeId, conUserCodePath.TabMainTypeId); //表主类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserCodePath.TabMainTypeId); //表主类型Id
 }
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.IsGeneCode))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objUserCodePathEN.IsGeneCode == true?"1":"0", conUserCodePath.IsGeneCode); //是否生成代码
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.ProjectFileName))
 {
 if (objUserCodePathEN.ProjectFileName !=  null)
 {
 var strProjectFileName = objUserCodePathEN.ProjectFileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProjectFileName, conUserCodePath.ProjectFileName); //工程文件名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserCodePath.ProjectFileName); //工程文件名
 }
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.ProjectPath))
 {
 if (objUserCodePathEN.ProjectPath !=  null)
 {
 var strProjectPath = objUserCodePathEN.ProjectPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProjectPath, conUserCodePath.ProjectPath); //工程路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserCodePath.ProjectPath); //工程路径
 }
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.PrjFileStateId))
 {
 if (objUserCodePathEN.PrjFileStateId !=  null)
 {
 var strPrjFileStateId = objUserCodePathEN.PrjFileStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjFileStateId, conUserCodePath.PrjFileStateId); //工程文件状态Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserCodePath.PrjFileStateId); //工程文件状态Id
 }
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.CodePath))
 {
 if (objUserCodePathEN.CodePath !=  null)
 {
 var strCodePath = objUserCodePathEN.CodePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCodePath, conUserCodePath.CodePath); //代码路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserCodePath.CodePath); //代码路径
 }
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.GcPathId))
 {
 if (objUserCodePathEN.GcPathId  ==  "")
 {
 objUserCodePathEN.GcPathId = null;
 }
 if (objUserCodePathEN.GcPathId !=  null)
 {
 var strGcPathId = objUserCodePathEN.GcPathId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGcPathId, conUserCodePath.GcPathId); //GC路径Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserCodePath.GcPathId); //GC路径Id
 }
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.CodePathBackup))
 {
 if (objUserCodePathEN.CodePathBackup !=  null)
 {
 var strCodePathBackup = objUserCodePathEN.CodePathBackup.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCodePathBackup, conUserCodePath.CodePathBackup); //备份代码路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserCodePath.CodePathBackup); //备份代码路径
 }
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.SuffixPath))
 {
 if (objUserCodePathEN.SuffixPath !=  null)
 {
 var strSuffixPath = objUserCodePathEN.SuffixPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSuffixPath, conUserCodePath.SuffixPath); //后缀路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserCodePath.SuffixPath); //后缀路径
 }
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.IsTemplate))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objUserCodePathEN.IsTemplate == true?"1":"0", conUserCodePath.IsTemplate); //是否模板
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.IsExistCodePath))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objUserCodePathEN.IsExistCodePath == true?"1":"0", conUserCodePath.IsExistCodePath); //是否存在代码路径
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.IsExistCodePathBackup))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objUserCodePathEN.IsExistCodePathBackup == true?"1":"0", conUserCodePath.IsExistCodePathBackup); //是否存在备份路径
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.PrjId))
 {
 if (objUserCodePathEN.PrjId !=  null)
 {
 var strPrjId = objUserCodePathEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conUserCodePath.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserCodePath.PrjId); //工程Id
 }
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.UpdDate))
 {
 if (objUserCodePathEN.UpdDate !=  null)
 {
 var strUpdDate = objUserCodePathEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conUserCodePath.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserCodePath.UpdDate); //修改日期
 }
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.UpdUserId))
 {
 if (objUserCodePathEN.UpdUserId !=  null)
 {
 var strUpdUserId = objUserCodePathEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conUserCodePath.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserCodePath.UpdUserId); //修改用户Id
 }
 }
 
 if (objUserCodePathEN.IsUpdated(conUserCodePath.Memo))
 {
 if (objUserCodePathEN.Memo !=  null)
 {
 var strMemo = objUserCodePathEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conUserCodePath.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserCodePath.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objUserCodePathEN.mId); 
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
 objSQL = clsUserCodePathDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("UserCodePath_Delete", values);
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
 objSQL = clsUserCodePathDA.GetSpecSQLObj();
//删除UserCodePath本表中与当前对象有关的记录
strSQL = strSQL + "Delete from UserCodePath where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelUserCodePath(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePathDA.GetSpecSQLObj();
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
//删除UserCodePath本表中与当前对象有关的记录
strSQL = strSQL + "Delete from UserCodePath where mId in (" + strKeyList + ")";
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
 objSQL = clsUserCodePathDA.GetSpecSQLObj();
//删除UserCodePath本表中与当前对象有关的记录
strSQL = strSQL + "Delete from UserCodePath where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelUserCodePath(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsUserCodePathDA: DelUserCodePath)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePathDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from UserCodePath where " + strCondition ;
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
public bool DelUserCodePathWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsUserCodePathDA: DelUserCodePathWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePathDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from UserCodePath where " + strCondition ;
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
 /// <param name = "objUserCodePathENS">源对象</param>
 /// <param name = "objUserCodePathENT">目标对象</param>
public void CopyTo(clsUserCodePathEN objUserCodePathENS, clsUserCodePathEN objUserCodePathENT)
{
objUserCodePathENT.mId = objUserCodePathENS.mId; //mId
objUserCodePathENT.CMProjectAppRelaId = objUserCodePathENS.CMProjectAppRelaId; //Cm工程应用关系Id
objUserCodePathENT.CodeTypeId = objUserCodePathENS.CodeTypeId; //代码类型Id
objUserCodePathENT.TabMainTypeId = objUserCodePathENS.TabMainTypeId; //表主类型Id
objUserCodePathENT.IsGeneCode = objUserCodePathENS.IsGeneCode; //是否生成代码
objUserCodePathENT.ProjectFileName = objUserCodePathENS.ProjectFileName; //工程文件名
objUserCodePathENT.ProjectPath = objUserCodePathENS.ProjectPath; //工程路径
objUserCodePathENT.PrjFileStateId = objUserCodePathENS.PrjFileStateId; //工程文件状态Id
objUserCodePathENT.CodePath = objUserCodePathENS.CodePath; //代码路径
objUserCodePathENT.GcPathId = objUserCodePathENS.GcPathId; //GC路径Id
objUserCodePathENT.CodePathBackup = objUserCodePathENS.CodePathBackup; //备份代码路径
objUserCodePathENT.SuffixPath = objUserCodePathENS.SuffixPath; //后缀路径
objUserCodePathENT.IsTemplate = objUserCodePathENS.IsTemplate; //是否模板
objUserCodePathENT.IsExistCodePath = objUserCodePathENS.IsExistCodePath; //是否存在代码路径
objUserCodePathENT.IsExistCodePathBackup = objUserCodePathENS.IsExistCodePathBackup; //是否存在备份路径
objUserCodePathENT.PrjId = objUserCodePathENS.PrjId; //工程Id
objUserCodePathENT.UpdDate = objUserCodePathENS.UpdDate; //修改日期
objUserCodePathENT.UpdUserId = objUserCodePathENS.UpdUserId; //修改用户Id
objUserCodePathENT.Memo = objUserCodePathENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsUserCodePathEN objUserCodePathEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objUserCodePathEN.CMProjectAppRelaId, conUserCodePath.CMProjectAppRelaId);
clsCheckSql.CheckFieldNotNull(objUserCodePathEN.CodeTypeId, conUserCodePath.CodeTypeId);
clsCheckSql.CheckFieldNotNull(objUserCodePathEN.CodePath, conUserCodePath.CodePath);
clsCheckSql.CheckFieldNotNull(objUserCodePathEN.CodePathBackup, conUserCodePath.CodePathBackup);
clsCheckSql.CheckFieldNotNull(objUserCodePathEN.IsTemplate, conUserCodePath.IsTemplate);
clsCheckSql.CheckFieldNotNull(objUserCodePathEN.PrjId, conUserCodePath.PrjId);
//检查字段长度
clsCheckSql.CheckFieldLen(objUserCodePathEN.CodeTypeId, 4, conUserCodePath.CodeTypeId);
clsCheckSql.CheckFieldLen(objUserCodePathEN.TabMainTypeId, 4, conUserCodePath.TabMainTypeId);
clsCheckSql.CheckFieldLen(objUserCodePathEN.ProjectFileName, 200, conUserCodePath.ProjectFileName);
clsCheckSql.CheckFieldLen(objUserCodePathEN.ProjectPath, 500, conUserCodePath.ProjectPath);
clsCheckSql.CheckFieldLen(objUserCodePathEN.PrjFileStateId, 2, conUserCodePath.PrjFileStateId);
clsCheckSql.CheckFieldLen(objUserCodePathEN.CodePath, 200, conUserCodePath.CodePath);
clsCheckSql.CheckFieldLen(objUserCodePathEN.GcPathId, 8, conUserCodePath.GcPathId);
clsCheckSql.CheckFieldLen(objUserCodePathEN.CodePathBackup, 200, conUserCodePath.CodePathBackup);
clsCheckSql.CheckFieldLen(objUserCodePathEN.SuffixPath, 50, conUserCodePath.SuffixPath);
clsCheckSql.CheckFieldLen(objUserCodePathEN.PrjId, 4, conUserCodePath.PrjId);
clsCheckSql.CheckFieldLen(objUserCodePathEN.UpdDate, 20, conUserCodePath.UpdDate);
clsCheckSql.CheckFieldLen(objUserCodePathEN.UpdUserId, 20, conUserCodePath.UpdUserId);
clsCheckSql.CheckFieldLen(objUserCodePathEN.Memo, 1000, conUserCodePath.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objUserCodePathEN.GcPathId, 8, conUserCodePath.GcPathId);
 objUserCodePathEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsUserCodePathEN objUserCodePathEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objUserCodePathEN.CodeTypeId, 4, conUserCodePath.CodeTypeId);
clsCheckSql.CheckFieldLen(objUserCodePathEN.TabMainTypeId, 4, conUserCodePath.TabMainTypeId);
clsCheckSql.CheckFieldLen(objUserCodePathEN.ProjectFileName, 200, conUserCodePath.ProjectFileName);
clsCheckSql.CheckFieldLen(objUserCodePathEN.ProjectPath, 500, conUserCodePath.ProjectPath);
clsCheckSql.CheckFieldLen(objUserCodePathEN.PrjFileStateId, 2, conUserCodePath.PrjFileStateId);
clsCheckSql.CheckFieldLen(objUserCodePathEN.CodePath, 200, conUserCodePath.CodePath);
clsCheckSql.CheckFieldLen(objUserCodePathEN.GcPathId, 8, conUserCodePath.GcPathId);
clsCheckSql.CheckFieldLen(objUserCodePathEN.CodePathBackup, 200, conUserCodePath.CodePathBackup);
clsCheckSql.CheckFieldLen(objUserCodePathEN.SuffixPath, 50, conUserCodePath.SuffixPath);
clsCheckSql.CheckFieldLen(objUserCodePathEN.PrjId, 4, conUserCodePath.PrjId);
clsCheckSql.CheckFieldLen(objUserCodePathEN.UpdDate, 20, conUserCodePath.UpdDate);
clsCheckSql.CheckFieldLen(objUserCodePathEN.UpdUserId, 20, conUserCodePath.UpdUserId);
clsCheckSql.CheckFieldLen(objUserCodePathEN.Memo, 1000, conUserCodePath.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objUserCodePathEN.GcPathId, 8, conUserCodePath.GcPathId);
 objUserCodePathEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsUserCodePathEN objUserCodePathEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objUserCodePathEN.CodeTypeId, 4, conUserCodePath.CodeTypeId);
clsCheckSql.CheckFieldLen(objUserCodePathEN.TabMainTypeId, 4, conUserCodePath.TabMainTypeId);
clsCheckSql.CheckFieldLen(objUserCodePathEN.ProjectFileName, 200, conUserCodePath.ProjectFileName);
clsCheckSql.CheckFieldLen(objUserCodePathEN.ProjectPath, 500, conUserCodePath.ProjectPath);
clsCheckSql.CheckFieldLen(objUserCodePathEN.PrjFileStateId, 2, conUserCodePath.PrjFileStateId);
clsCheckSql.CheckFieldLen(objUserCodePathEN.CodePath, 200, conUserCodePath.CodePath);
clsCheckSql.CheckFieldLen(objUserCodePathEN.GcPathId, 8, conUserCodePath.GcPathId);
clsCheckSql.CheckFieldLen(objUserCodePathEN.CodePathBackup, 200, conUserCodePath.CodePathBackup);
clsCheckSql.CheckFieldLen(objUserCodePathEN.SuffixPath, 50, conUserCodePath.SuffixPath);
clsCheckSql.CheckFieldLen(objUserCodePathEN.PrjId, 4, conUserCodePath.PrjId);
clsCheckSql.CheckFieldLen(objUserCodePathEN.UpdDate, 20, conUserCodePath.UpdDate);
clsCheckSql.CheckFieldLen(objUserCodePathEN.UpdUserId, 20, conUserCodePath.UpdUserId);
clsCheckSql.CheckFieldLen(objUserCodePathEN.Memo, 1000, conUserCodePath.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objUserCodePathEN.CodeTypeId, conUserCodePath.CodeTypeId);
clsCheckSql.CheckSqlInjection4Field(objUserCodePathEN.TabMainTypeId, conUserCodePath.TabMainTypeId);
clsCheckSql.CheckSqlInjection4Field(objUserCodePathEN.ProjectFileName, conUserCodePath.ProjectFileName);
clsCheckSql.CheckSqlInjection4Field(objUserCodePathEN.ProjectPath, conUserCodePath.ProjectPath);
clsCheckSql.CheckSqlInjection4Field(objUserCodePathEN.PrjFileStateId, conUserCodePath.PrjFileStateId);
clsCheckSql.CheckSqlInjection4Field(objUserCodePathEN.CodePath, conUserCodePath.CodePath);
clsCheckSql.CheckSqlInjection4Field(objUserCodePathEN.GcPathId, conUserCodePath.GcPathId);
clsCheckSql.CheckSqlInjection4Field(objUserCodePathEN.CodePathBackup, conUserCodePath.CodePathBackup);
clsCheckSql.CheckSqlInjection4Field(objUserCodePathEN.SuffixPath, conUserCodePath.SuffixPath);
clsCheckSql.CheckSqlInjection4Field(objUserCodePathEN.PrjId, conUserCodePath.PrjId);
clsCheckSql.CheckSqlInjection4Field(objUserCodePathEN.UpdDate, conUserCodePath.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objUserCodePathEN.UpdUserId, conUserCodePath.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objUserCodePathEN.Memo, conUserCodePath.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objUserCodePathEN.GcPathId, 8, conUserCodePath.GcPathId);
 objUserCodePathEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--UserCodePath(用户生成路径),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objUserCodePathEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsUserCodePathEN objUserCodePathEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CodeTypeId = '{0}'", objUserCodePathEN.CodeTypeId);
 sbCondition.AppendFormat(" and CMProjectAppRelaId = '{0}'", objUserCodePathEN.CMProjectAppRelaId);
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
 objSQL = clsUserCodePathDA.GetSpecSQLObj();
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
 objSQL = clsUserCodePathDA.GetSpecSQLObj();
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
 objSQL = clsUserCodePathDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsUserCodePathEN._CurrTabName);
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
 objSQL = clsUserCodePathDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsUserCodePathEN._CurrTabName, strCondition);
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
 objSQL = clsUserCodePathDA.GetSpecSQLObj();
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
 objSQL = clsUserCodePathDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}