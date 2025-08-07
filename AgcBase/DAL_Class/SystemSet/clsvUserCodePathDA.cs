
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvUserCodePathDA
 表名:vUserCodePath(00050205)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:48:32
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
 /// v用户生成路径(vUserCodePath)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvUserCodePathDA : clsCommBase4DA
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
 return clsvUserCodePathEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvUserCodePathEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvUserCodePathEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvUserCodePathEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvUserCodePathEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvUserCodePathDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserCodePathDA.GetSpecSQLObj();
strSQL = "Select * from vUserCodePath where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vUserCodePath(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvUserCodePathDA: GetDataTable_vUserCodePath)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserCodePathDA.GetSpecSQLObj();
strSQL = "Select * from vUserCodePath where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvUserCodePathDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserCodePathDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvUserCodePathDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserCodePathDA.GetSpecSQLObj();
strSQL = "Select * from vUserCodePath where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvUserCodePathDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserCodePathDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvUserCodePathDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserCodePathDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vUserCodePath where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vUserCodePath where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvUserCodePathDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserCodePathDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vUserCodePath where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvUserCodePathDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserCodePathDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vUserCodePath.* " + 
$"from vUserCodePath " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vUserCodePath.mId not in " + 
$"(Select top {intTop_In} vUserCodePath.mId from vUserCodePath " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vUserCodePath where {1} and mId not in (Select top {2} mId from vUserCodePath where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vUserCodePath where {1} and mId not in (Select top {3} mId from vUserCodePath where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvUserCodePathDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserCodePathDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vUserCodePath.* " + 
$"from vUserCodePath " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vUserCodePath.mId not in " + 
$"(Select top {intTop_In} vUserCodePath.mId from vUserCodePath " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vUserCodePath where {1} and mId not in (Select top {2} mId from vUserCodePath where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vUserCodePath where {1} and mId not in (Select top {3} mId from vUserCodePath where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvUserCodePathEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvUserCodePathDA:GetObjLst)", objException.Message));
}
List<clsvUserCodePathEN> arrObjLst = new List<clsvUserCodePathEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserCodePathDA.GetSpecSQLObj();
strSQL = "Select * from vUserCodePath where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserCodePathEN objvUserCodePathEN = new clsvUserCodePathEN();
try
{
objvUserCodePathEN.mId = TransNullToInt(objRow[convUserCodePath.mId].ToString().Trim()); //mId
objvUserCodePathEN.CMProjectAppRelaId = TransNullToInt(objRow[convUserCodePath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objvUserCodePathEN.CodeTypeId = objRow[convUserCodePath.CodeTypeId].ToString().Trim(); //代码类型Id
objvUserCodePathEN.ProgLangTypeId = objRow[convUserCodePath.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvUserCodePathEN.ProgLangTypeName = objRow[convUserCodePath.ProgLangTypeName] == DBNull.Value ? null : objRow[convUserCodePath.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvUserCodePathEN.CmPrjId = objRow[convUserCodePath.CmPrjId] == DBNull.Value ? null : objRow[convUserCodePath.CmPrjId].ToString().Trim(); //Cm工程Id
objvUserCodePathEN.ApplicationTypeName = objRow[convUserCodePath.ApplicationTypeName] == DBNull.Value ? null : objRow[convUserCodePath.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvUserCodePathEN.ApplicationTypeENName = objRow[convUserCodePath.ApplicationTypeENName] == DBNull.Value ? null : objRow[convUserCodePath.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvUserCodePathEN.PrjFileStateName = objRow[convUserCodePath.PrjFileStateName] == DBNull.Value ? null : objRow[convUserCodePath.PrjFileStateName].ToString().Trim(); //工程文件状态名
objvUserCodePathEN.AppOrderNum = objRow[convUserCodePath.AppOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convUserCodePath.AppOrderNum].ToString().Trim()); //AppOrderNum
objvUserCodePathEN.NewCodePath = objRow[convUserCodePath.NewCodePath].ToString().Trim(); //NewCodePath
objvUserCodePathEN.NewCodePathBackup = objRow[convUserCodePath.NewCodePathBackup].ToString().Trim(); //新备份目录
objvUserCodePathEN.CodeTypeName = objRow[convUserCodePath.CodeTypeName].ToString().Trim(); //代码类型名
objvUserCodePathEN.CodeTypeENName = objRow[convUserCodePath.CodeTypeENName] == DBNull.Value ? null : objRow[convUserCodePath.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvUserCodePathEN.OrderNum = objRow[convUserCodePath.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convUserCodePath.OrderNum].ToString().Trim()); //序号
objvUserCodePathEN.ApplicationTypeId = TransNullToInt(objRow[convUserCodePath.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvUserCodePathEN.TabMainTypeId = objRow[convUserCodePath.TabMainTypeId] == DBNull.Value ? null : objRow[convUserCodePath.TabMainTypeId].ToString().Trim(); //表主类型Id
objvUserCodePathEN.IsGeneCode = TransNullToBool(objRow[convUserCodePath.IsGeneCode].ToString().Trim()); //是否生成代码
objvUserCodePathEN.ProjectFileName = objRow[convUserCodePath.ProjectFileName].ToString().Trim(); //工程文件名
objvUserCodePathEN.ProjectPath = objRow[convUserCodePath.ProjectPath].ToString().Trim(); //工程路径
objvUserCodePathEN.PrjFileStateId = objRow[convUserCodePath.PrjFileStateId] == DBNull.Value ? null : objRow[convUserCodePath.PrjFileStateId].ToString().Trim(); //工程文件状态Id
objvUserCodePathEN.CodePath = objRow[convUserCodePath.CodePath].ToString().Trim(); //代码路径
objvUserCodePathEN.CodePathBackup = objRow[convUserCodePath.CodePathBackup].ToString().Trim(); //备份代码路径
objvUserCodePathEN.SuffixPath = objRow[convUserCodePath.SuffixPath] == DBNull.Value ? null : objRow[convUserCodePath.SuffixPath].ToString().Trim(); //后缀路径
objvUserCodePathEN.IsTemplate = TransNullToBool(objRow[convUserCodePath.IsTemplate].ToString().Trim()); //是否模板
objvUserCodePathEN.IsExistCodePath = TransNullToBool(objRow[convUserCodePath.IsExistCodePath].ToString().Trim()); //是否存在代码路径
objvUserCodePathEN.IsExistCodePathBackup = TransNullToBool(objRow[convUserCodePath.IsExistCodePathBackup].ToString().Trim()); //是否存在备份路径
objvUserCodePathEN.PrjId = objRow[convUserCodePath.PrjId].ToString().Trim(); //工程Id
objvUserCodePathEN.UpdDate = objRow[convUserCodePath.UpdDate] == DBNull.Value ? null : objRow[convUserCodePath.UpdDate].ToString().Trim(); //修改日期
objvUserCodePathEN.UpdUserId = objRow[convUserCodePath.UpdUserId] == DBNull.Value ? null : objRow[convUserCodePath.UpdUserId].ToString().Trim(); //修改用户Id
objvUserCodePathEN.Memo = objRow[convUserCodePath.Memo] == DBNull.Value ? null : objRow[convUserCodePath.Memo].ToString().Trim(); //说明
objvUserCodePathEN.ProgLangTypeSimName = objRow[convUserCodePath.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convUserCodePath.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvUserCodePathEN.ApplicationTypeSimName = objRow[convUserCodePath.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convUserCodePath.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvUserCodePathEN.CmPrjName = objRow[convUserCodePath.CmPrjName] == DBNull.Value ? null : objRow[convUserCodePath.CmPrjName].ToString().Trim(); //CM工程名
objvUserCodePathEN.TabMainTypeName = objRow[convUserCodePath.TabMainTypeName] == DBNull.Value ? null : objRow[convUserCodePath.TabMainTypeName].ToString().Trim(); //表主类型名
objvUserCodePathEN.CodeTypeSimName = objRow[convUserCodePath.CodeTypeSimName] == DBNull.Value ? null : objRow[convUserCodePath.CodeTypeSimName].ToString().Trim(); //简称
objvUserCodePathEN.IsExistCodePathP = TransNullToBool(objRow[convUserCodePath.IsExistCodePathP].ToString().Trim()); //是否存在代码目录P
objvUserCodePathEN.IsExistCodePathBackupP = TransNullToBool(objRow[convUserCodePath.IsExistCodePathBackupP].ToString().Trim()); //是否存在备份目录P
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvUserCodePathDA: GetObjLst)", objException.Message));
}
objvUserCodePathEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvUserCodePathEN);
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
public List<clsvUserCodePathEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvUserCodePathDA:GetObjLstByTabName)", objException.Message));
}
List<clsvUserCodePathEN> arrObjLst = new List<clsvUserCodePathEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserCodePathDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserCodePathEN objvUserCodePathEN = new clsvUserCodePathEN();
try
{
objvUserCodePathEN.mId = TransNullToInt(objRow[convUserCodePath.mId].ToString().Trim()); //mId
objvUserCodePathEN.CMProjectAppRelaId = TransNullToInt(objRow[convUserCodePath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objvUserCodePathEN.CodeTypeId = objRow[convUserCodePath.CodeTypeId].ToString().Trim(); //代码类型Id
objvUserCodePathEN.ProgLangTypeId = objRow[convUserCodePath.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvUserCodePathEN.ProgLangTypeName = objRow[convUserCodePath.ProgLangTypeName] == DBNull.Value ? null : objRow[convUserCodePath.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvUserCodePathEN.CmPrjId = objRow[convUserCodePath.CmPrjId] == DBNull.Value ? null : objRow[convUserCodePath.CmPrjId].ToString().Trim(); //Cm工程Id
objvUserCodePathEN.ApplicationTypeName = objRow[convUserCodePath.ApplicationTypeName] == DBNull.Value ? null : objRow[convUserCodePath.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvUserCodePathEN.ApplicationTypeENName = objRow[convUserCodePath.ApplicationTypeENName] == DBNull.Value ? null : objRow[convUserCodePath.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvUserCodePathEN.PrjFileStateName = objRow[convUserCodePath.PrjFileStateName] == DBNull.Value ? null : objRow[convUserCodePath.PrjFileStateName].ToString().Trim(); //工程文件状态名
objvUserCodePathEN.AppOrderNum = objRow[convUserCodePath.AppOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convUserCodePath.AppOrderNum].ToString().Trim()); //AppOrderNum
objvUserCodePathEN.NewCodePath = objRow[convUserCodePath.NewCodePath].ToString().Trim(); //NewCodePath
objvUserCodePathEN.NewCodePathBackup = objRow[convUserCodePath.NewCodePathBackup].ToString().Trim(); //新备份目录
objvUserCodePathEN.CodeTypeName = objRow[convUserCodePath.CodeTypeName].ToString().Trim(); //代码类型名
objvUserCodePathEN.CodeTypeENName = objRow[convUserCodePath.CodeTypeENName] == DBNull.Value ? null : objRow[convUserCodePath.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvUserCodePathEN.OrderNum = objRow[convUserCodePath.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convUserCodePath.OrderNum].ToString().Trim()); //序号
objvUserCodePathEN.ApplicationTypeId = TransNullToInt(objRow[convUserCodePath.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvUserCodePathEN.TabMainTypeId = objRow[convUserCodePath.TabMainTypeId] == DBNull.Value ? null : objRow[convUserCodePath.TabMainTypeId].ToString().Trim(); //表主类型Id
objvUserCodePathEN.IsGeneCode = TransNullToBool(objRow[convUserCodePath.IsGeneCode].ToString().Trim()); //是否生成代码
objvUserCodePathEN.ProjectFileName = objRow[convUserCodePath.ProjectFileName].ToString().Trim(); //工程文件名
objvUserCodePathEN.ProjectPath = objRow[convUserCodePath.ProjectPath].ToString().Trim(); //工程路径
objvUserCodePathEN.PrjFileStateId = objRow[convUserCodePath.PrjFileStateId] == DBNull.Value ? null : objRow[convUserCodePath.PrjFileStateId].ToString().Trim(); //工程文件状态Id
objvUserCodePathEN.CodePath = objRow[convUserCodePath.CodePath].ToString().Trim(); //代码路径
objvUserCodePathEN.CodePathBackup = objRow[convUserCodePath.CodePathBackup].ToString().Trim(); //备份代码路径
objvUserCodePathEN.SuffixPath = objRow[convUserCodePath.SuffixPath] == DBNull.Value ? null : objRow[convUserCodePath.SuffixPath].ToString().Trim(); //后缀路径
objvUserCodePathEN.IsTemplate = TransNullToBool(objRow[convUserCodePath.IsTemplate].ToString().Trim()); //是否模板
objvUserCodePathEN.IsExistCodePath = TransNullToBool(objRow[convUserCodePath.IsExistCodePath].ToString().Trim()); //是否存在代码路径
objvUserCodePathEN.IsExistCodePathBackup = TransNullToBool(objRow[convUserCodePath.IsExistCodePathBackup].ToString().Trim()); //是否存在备份路径
objvUserCodePathEN.PrjId = objRow[convUserCodePath.PrjId].ToString().Trim(); //工程Id
objvUserCodePathEN.UpdDate = objRow[convUserCodePath.UpdDate] == DBNull.Value ? null : objRow[convUserCodePath.UpdDate].ToString().Trim(); //修改日期
objvUserCodePathEN.UpdUserId = objRow[convUserCodePath.UpdUserId] == DBNull.Value ? null : objRow[convUserCodePath.UpdUserId].ToString().Trim(); //修改用户Id
objvUserCodePathEN.Memo = objRow[convUserCodePath.Memo] == DBNull.Value ? null : objRow[convUserCodePath.Memo].ToString().Trim(); //说明
objvUserCodePathEN.ProgLangTypeSimName = objRow[convUserCodePath.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convUserCodePath.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvUserCodePathEN.ApplicationTypeSimName = objRow[convUserCodePath.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convUserCodePath.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvUserCodePathEN.CmPrjName = objRow[convUserCodePath.CmPrjName] == DBNull.Value ? null : objRow[convUserCodePath.CmPrjName].ToString().Trim(); //CM工程名
objvUserCodePathEN.TabMainTypeName = objRow[convUserCodePath.TabMainTypeName] == DBNull.Value ? null : objRow[convUserCodePath.TabMainTypeName].ToString().Trim(); //表主类型名
objvUserCodePathEN.CodeTypeSimName = objRow[convUserCodePath.CodeTypeSimName] == DBNull.Value ? null : objRow[convUserCodePath.CodeTypeSimName].ToString().Trim(); //简称
objvUserCodePathEN.IsExistCodePathP = TransNullToBool(objRow[convUserCodePath.IsExistCodePathP].ToString().Trim()); //是否存在代码目录P
objvUserCodePathEN.IsExistCodePathBackupP = TransNullToBool(objRow[convUserCodePath.IsExistCodePathBackupP].ToString().Trim()); //是否存在备份目录P
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvUserCodePathDA: GetObjLst)", objException.Message));
}
objvUserCodePathEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvUserCodePathEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvUserCodePath(ref clsvUserCodePathEN objvUserCodePathEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserCodePathDA.GetSpecSQLObj();
strSQL = "Select * from vUserCodePath where mId = " + ""+ objvUserCodePathEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvUserCodePathEN.mId = TransNullToInt(objDT.Rows[0][convUserCodePath.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvUserCodePathEN.CMProjectAppRelaId = TransNullToInt(objDT.Rows[0][convUserCodePath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id(字段类型:bigint,字段长度:8,是否可空:False)
 objvUserCodePathEN.CodeTypeId = objDT.Rows[0][convUserCodePath.CodeTypeId].ToString().Trim(); //代码类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvUserCodePathEN.ProgLangTypeId = objDT.Rows[0][convUserCodePath.ProgLangTypeId].ToString().Trim(); //编程语言类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvUserCodePathEN.ProgLangTypeName = objDT.Rows[0][convUserCodePath.ProgLangTypeName].ToString().Trim(); //编程语言类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvUserCodePathEN.CmPrjId = objDT.Rows[0][convUserCodePath.CmPrjId].ToString().Trim(); //Cm工程Id(字段类型:char,字段长度:6,是否可空:False)
 objvUserCodePathEN.ApplicationTypeName = objDT.Rows[0][convUserCodePath.ApplicationTypeName].ToString().Trim(); //应用程序类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvUserCodePathEN.ApplicationTypeENName = objDT.Rows[0][convUserCodePath.ApplicationTypeENName].ToString().Trim(); //应用类型英文名(字段类型:varchar,字段长度:30,是否可空:False)
 objvUserCodePathEN.PrjFileStateName = objDT.Rows[0][convUserCodePath.PrjFileStateName].ToString().Trim(); //工程文件状态名(字段类型:varchar,字段长度:30,是否可空:False)
 objvUserCodePathEN.AppOrderNum = TransNullToInt(objDT.Rows[0][convUserCodePath.AppOrderNum].ToString().Trim()); //AppOrderNum(字段类型:int,字段长度:4,是否可空:True)
 objvUserCodePathEN.NewCodePath = objDT.Rows[0][convUserCodePath.NewCodePath].ToString().Trim(); //NewCodePath(字段类型:varchar,字段长度:2,是否可空:False)
 objvUserCodePathEN.NewCodePathBackup = objDT.Rows[0][convUserCodePath.NewCodePathBackup].ToString().Trim(); //新备份目录(字段类型:varchar,字段长度:2,是否可空:False)
 objvUserCodePathEN.CodeTypeName = objDT.Rows[0][convUserCodePath.CodeTypeName].ToString().Trim(); //代码类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvUserCodePathEN.CodeTypeENName = objDT.Rows[0][convUserCodePath.CodeTypeENName].ToString().Trim(); //代码类型英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objvUserCodePathEN.OrderNum = TransNullToInt(objDT.Rows[0][convUserCodePath.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvUserCodePathEN.ApplicationTypeId = TransNullToInt(objDT.Rows[0][convUserCodePath.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objvUserCodePathEN.TabMainTypeId = objDT.Rows[0][convUserCodePath.TabMainTypeId].ToString().Trim(); //表主类型Id(字段类型:char,字段长度:4,是否可空:True)
 objvUserCodePathEN.IsGeneCode = TransNullToBool(objDT.Rows[0][convUserCodePath.IsGeneCode].ToString().Trim()); //是否生成代码(字段类型:bit,字段长度:1,是否可空:True)
 objvUserCodePathEN.ProjectFileName = objDT.Rows[0][convUserCodePath.ProjectFileName].ToString().Trim(); //工程文件名(字段类型:varchar,字段长度:200,是否可空:False)
 objvUserCodePathEN.ProjectPath = objDT.Rows[0][convUserCodePath.ProjectPath].ToString().Trim(); //工程路径(字段类型:varchar,字段长度:500,是否可空:False)
 objvUserCodePathEN.PrjFileStateId = objDT.Rows[0][convUserCodePath.PrjFileStateId].ToString().Trim(); //工程文件状态Id(字段类型:char,字段长度:2,是否可空:False)
 objvUserCodePathEN.CodePath = objDT.Rows[0][convUserCodePath.CodePath].ToString().Trim(); //代码路径(字段类型:varchar,字段长度:200,是否可空:False)
 objvUserCodePathEN.CodePathBackup = objDT.Rows[0][convUserCodePath.CodePathBackup].ToString().Trim(); //备份代码路径(字段类型:varchar,字段长度:200,是否可空:False)
 objvUserCodePathEN.SuffixPath = objDT.Rows[0][convUserCodePath.SuffixPath].ToString().Trim(); //后缀路径(字段类型:varchar,字段长度:50,是否可空:True)
 objvUserCodePathEN.IsTemplate = TransNullToBool(objDT.Rows[0][convUserCodePath.IsTemplate].ToString().Trim()); //是否模板(字段类型:bit,字段长度:1,是否可空:False)
 objvUserCodePathEN.IsExistCodePath = TransNullToBool(objDT.Rows[0][convUserCodePath.IsExistCodePath].ToString().Trim()); //是否存在代码路径(字段类型:bit,字段长度:1,是否可空:True)
 objvUserCodePathEN.IsExistCodePathBackup = TransNullToBool(objDT.Rows[0][convUserCodePath.IsExistCodePathBackup].ToString().Trim()); //是否存在备份路径(字段类型:bit,字段长度:1,是否可空:True)
 objvUserCodePathEN.PrjId = objDT.Rows[0][convUserCodePath.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvUserCodePathEN.UpdDate = objDT.Rows[0][convUserCodePath.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvUserCodePathEN.UpdUserId = objDT.Rows[0][convUserCodePath.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvUserCodePathEN.Memo = objDT.Rows[0][convUserCodePath.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvUserCodePathEN.ProgLangTypeSimName = objDT.Rows[0][convUserCodePath.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvUserCodePathEN.ApplicationTypeSimName = objDT.Rows[0][convUserCodePath.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvUserCodePathEN.CmPrjName = objDT.Rows[0][convUserCodePath.CmPrjName].ToString().Trim(); //CM工程名(字段类型:varchar,字段长度:50,是否可空:True)
 objvUserCodePathEN.TabMainTypeName = objDT.Rows[0][convUserCodePath.TabMainTypeName].ToString().Trim(); //表主类型名(字段类型:varchar,字段长度:30,是否可空:True)
 objvUserCodePathEN.CodeTypeSimName = objDT.Rows[0][convUserCodePath.CodeTypeSimName].ToString().Trim(); //简称(字段类型:varchar,字段长度:50,是否可空:False)
 objvUserCodePathEN.IsExistCodePathP = TransNullToBool(objDT.Rows[0][convUserCodePath.IsExistCodePathP].ToString().Trim()); //是否存在代码目录P(字段类型:bit,字段长度:1,是否可空:True)
 objvUserCodePathEN.IsExistCodePathBackupP = TransNullToBool(objDT.Rows[0][convUserCodePath.IsExistCodePathBackupP].ToString().Trim()); //是否存在备份目录P(字段类型:bit,字段长度:1,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvUserCodePathDA: GetvUserCodePath)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvUserCodePathEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserCodePathDA.GetSpecSQLObj();
strSQL = "Select * from vUserCodePath where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvUserCodePathEN objvUserCodePathEN = new clsvUserCodePathEN();
try
{
 objvUserCodePathEN.mId = Int32.Parse(objRow[convUserCodePath.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvUserCodePathEN.CMProjectAppRelaId = Int32.Parse(objRow[convUserCodePath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id(字段类型:bigint,字段长度:8,是否可空:False)
 objvUserCodePathEN.CodeTypeId = objRow[convUserCodePath.CodeTypeId].ToString().Trim(); //代码类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvUserCodePathEN.ProgLangTypeId = objRow[convUserCodePath.ProgLangTypeId].ToString().Trim(); //编程语言类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvUserCodePathEN.ProgLangTypeName = objRow[convUserCodePath.ProgLangTypeName] == DBNull.Value ? null : objRow[convUserCodePath.ProgLangTypeName].ToString().Trim(); //编程语言类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvUserCodePathEN.CmPrjId = objRow[convUserCodePath.CmPrjId] == DBNull.Value ? null : objRow[convUserCodePath.CmPrjId].ToString().Trim(); //Cm工程Id(字段类型:char,字段长度:6,是否可空:False)
 objvUserCodePathEN.ApplicationTypeName = objRow[convUserCodePath.ApplicationTypeName] == DBNull.Value ? null : objRow[convUserCodePath.ApplicationTypeName].ToString().Trim(); //应用程序类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvUserCodePathEN.ApplicationTypeENName = objRow[convUserCodePath.ApplicationTypeENName] == DBNull.Value ? null : objRow[convUserCodePath.ApplicationTypeENName].ToString().Trim(); //应用类型英文名(字段类型:varchar,字段长度:30,是否可空:False)
 objvUserCodePathEN.PrjFileStateName = objRow[convUserCodePath.PrjFileStateName] == DBNull.Value ? null : objRow[convUserCodePath.PrjFileStateName].ToString().Trim(); //工程文件状态名(字段类型:varchar,字段长度:30,是否可空:False)
 objvUserCodePathEN.AppOrderNum = objRow[convUserCodePath.AppOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserCodePath.AppOrderNum].ToString().Trim()); //AppOrderNum(字段类型:int,字段长度:4,是否可空:True)
 objvUserCodePathEN.NewCodePath = objRow[convUserCodePath.NewCodePath].ToString().Trim(); //NewCodePath(字段类型:varchar,字段长度:2,是否可空:False)
 objvUserCodePathEN.NewCodePathBackup = objRow[convUserCodePath.NewCodePathBackup].ToString().Trim(); //新备份目录(字段类型:varchar,字段长度:2,是否可空:False)
 objvUserCodePathEN.CodeTypeName = objRow[convUserCodePath.CodeTypeName].ToString().Trim(); //代码类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvUserCodePathEN.CodeTypeENName = objRow[convUserCodePath.CodeTypeENName] == DBNull.Value ? null : objRow[convUserCodePath.CodeTypeENName].ToString().Trim(); //代码类型英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objvUserCodePathEN.OrderNum = objRow[convUserCodePath.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserCodePath.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvUserCodePathEN.ApplicationTypeId = Int32.Parse(objRow[convUserCodePath.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objvUserCodePathEN.TabMainTypeId = objRow[convUserCodePath.TabMainTypeId] == DBNull.Value ? null : objRow[convUserCodePath.TabMainTypeId].ToString().Trim(); //表主类型Id(字段类型:char,字段长度:4,是否可空:True)
 objvUserCodePathEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsGeneCode].ToString().Trim()); //是否生成代码(字段类型:bit,字段长度:1,是否可空:True)
 objvUserCodePathEN.ProjectFileName = objRow[convUserCodePath.ProjectFileName].ToString().Trim(); //工程文件名(字段类型:varchar,字段长度:200,是否可空:False)
 objvUserCodePathEN.ProjectPath = objRow[convUserCodePath.ProjectPath].ToString().Trim(); //工程路径(字段类型:varchar,字段长度:500,是否可空:False)
 objvUserCodePathEN.PrjFileStateId = objRow[convUserCodePath.PrjFileStateId] == DBNull.Value ? null : objRow[convUserCodePath.PrjFileStateId].ToString().Trim(); //工程文件状态Id(字段类型:char,字段长度:2,是否可空:False)
 objvUserCodePathEN.CodePath = objRow[convUserCodePath.CodePath].ToString().Trim(); //代码路径(字段类型:varchar,字段长度:200,是否可空:False)
 objvUserCodePathEN.CodePathBackup = objRow[convUserCodePath.CodePathBackup].ToString().Trim(); //备份代码路径(字段类型:varchar,字段长度:200,是否可空:False)
 objvUserCodePathEN.SuffixPath = objRow[convUserCodePath.SuffixPath] == DBNull.Value ? null : objRow[convUserCodePath.SuffixPath].ToString().Trim(); //后缀路径(字段类型:varchar,字段长度:50,是否可空:True)
 objvUserCodePathEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsTemplate].ToString().Trim()); //是否模板(字段类型:bit,字段长度:1,是否可空:False)
 objvUserCodePathEN.IsExistCodePath = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsExistCodePath].ToString().Trim()); //是否存在代码路径(字段类型:bit,字段长度:1,是否可空:True)
 objvUserCodePathEN.IsExistCodePathBackup = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsExistCodePathBackup].ToString().Trim()); //是否存在备份路径(字段类型:bit,字段长度:1,是否可空:True)
 objvUserCodePathEN.PrjId = objRow[convUserCodePath.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvUserCodePathEN.UpdDate = objRow[convUserCodePath.UpdDate] == DBNull.Value ? null : objRow[convUserCodePath.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvUserCodePathEN.UpdUserId = objRow[convUserCodePath.UpdUserId] == DBNull.Value ? null : objRow[convUserCodePath.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvUserCodePathEN.Memo = objRow[convUserCodePath.Memo] == DBNull.Value ? null : objRow[convUserCodePath.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvUserCodePathEN.ProgLangTypeSimName = objRow[convUserCodePath.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convUserCodePath.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvUserCodePathEN.ApplicationTypeSimName = objRow[convUserCodePath.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convUserCodePath.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvUserCodePathEN.CmPrjName = objRow[convUserCodePath.CmPrjName] == DBNull.Value ? null : objRow[convUserCodePath.CmPrjName].ToString().Trim(); //CM工程名(字段类型:varchar,字段长度:50,是否可空:True)
 objvUserCodePathEN.TabMainTypeName = objRow[convUserCodePath.TabMainTypeName] == DBNull.Value ? null : objRow[convUserCodePath.TabMainTypeName].ToString().Trim(); //表主类型名(字段类型:varchar,字段长度:30,是否可空:True)
 objvUserCodePathEN.CodeTypeSimName = objRow[convUserCodePath.CodeTypeSimName] == DBNull.Value ? null : objRow[convUserCodePath.CodeTypeSimName].ToString().Trim(); //简称(字段类型:varchar,字段长度:50,是否可空:False)
 objvUserCodePathEN.IsExistCodePathP = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsExistCodePathP].ToString().Trim()); //是否存在代码目录P(字段类型:bit,字段长度:1,是否可空:True)
 objvUserCodePathEN.IsExistCodePathBackupP = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsExistCodePathBackupP].ToString().Trim()); //是否存在备份目录P(字段类型:bit,字段长度:1,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvUserCodePathDA: GetObjBymId)", objException.Message));
}
return objvUserCodePathEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvUserCodePathEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvUserCodePathDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserCodePathDA.GetSpecSQLObj();
strSQL = "Select * from vUserCodePath where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvUserCodePathEN objvUserCodePathEN = new clsvUserCodePathEN()
{
mId = TransNullToInt(objRow[convUserCodePath.mId].ToString().Trim()), //mId
CMProjectAppRelaId = TransNullToInt(objRow[convUserCodePath.CMProjectAppRelaId].ToString().Trim()), //Cm工程应用关系Id
CodeTypeId = objRow[convUserCodePath.CodeTypeId].ToString().Trim(), //代码类型Id
ProgLangTypeId = objRow[convUserCodePath.ProgLangTypeId].ToString().Trim(), //编程语言类型Id
ProgLangTypeName = objRow[convUserCodePath.ProgLangTypeName] == DBNull.Value ? null : objRow[convUserCodePath.ProgLangTypeName].ToString().Trim(), //编程语言类型名
CmPrjId = objRow[convUserCodePath.CmPrjId] == DBNull.Value ? null : objRow[convUserCodePath.CmPrjId].ToString().Trim(), //Cm工程Id
ApplicationTypeName = objRow[convUserCodePath.ApplicationTypeName] == DBNull.Value ? null : objRow[convUserCodePath.ApplicationTypeName].ToString().Trim(), //应用程序类型名称
ApplicationTypeENName = objRow[convUserCodePath.ApplicationTypeENName] == DBNull.Value ? null : objRow[convUserCodePath.ApplicationTypeENName].ToString().Trim(), //应用类型英文名
PrjFileStateName = objRow[convUserCodePath.PrjFileStateName] == DBNull.Value ? null : objRow[convUserCodePath.PrjFileStateName].ToString().Trim(), //工程文件状态名
AppOrderNum = objRow[convUserCodePath.AppOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convUserCodePath.AppOrderNum].ToString().Trim()), //AppOrderNum
NewCodePath = objRow[convUserCodePath.NewCodePath].ToString().Trim(), //NewCodePath
NewCodePathBackup = objRow[convUserCodePath.NewCodePathBackup].ToString().Trim(), //新备份目录
CodeTypeName = objRow[convUserCodePath.CodeTypeName].ToString().Trim(), //代码类型名
CodeTypeENName = objRow[convUserCodePath.CodeTypeENName] == DBNull.Value ? null : objRow[convUserCodePath.CodeTypeENName].ToString().Trim(), //代码类型英文名
OrderNum = objRow[convUserCodePath.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convUserCodePath.OrderNum].ToString().Trim()), //序号
ApplicationTypeId = TransNullToInt(objRow[convUserCodePath.ApplicationTypeId].ToString().Trim()), //应用程序类型ID
TabMainTypeId = objRow[convUserCodePath.TabMainTypeId] == DBNull.Value ? null : objRow[convUserCodePath.TabMainTypeId].ToString().Trim(), //表主类型Id
IsGeneCode = TransNullToBool(objRow[convUserCodePath.IsGeneCode].ToString().Trim()), //是否生成代码
ProjectFileName = objRow[convUserCodePath.ProjectFileName].ToString().Trim(), //工程文件名
ProjectPath = objRow[convUserCodePath.ProjectPath].ToString().Trim(), //工程路径
PrjFileStateId = objRow[convUserCodePath.PrjFileStateId] == DBNull.Value ? null : objRow[convUserCodePath.PrjFileStateId].ToString().Trim(), //工程文件状态Id
CodePath = objRow[convUserCodePath.CodePath].ToString().Trim(), //代码路径
CodePathBackup = objRow[convUserCodePath.CodePathBackup].ToString().Trim(), //备份代码路径
SuffixPath = objRow[convUserCodePath.SuffixPath] == DBNull.Value ? null : objRow[convUserCodePath.SuffixPath].ToString().Trim(), //后缀路径
IsTemplate = TransNullToBool(objRow[convUserCodePath.IsTemplate].ToString().Trim()), //是否模板
IsExistCodePath = TransNullToBool(objRow[convUserCodePath.IsExistCodePath].ToString().Trim()), //是否存在代码路径
IsExistCodePathBackup = TransNullToBool(objRow[convUserCodePath.IsExistCodePathBackup].ToString().Trim()), //是否存在备份路径
PrjId = objRow[convUserCodePath.PrjId].ToString().Trim(), //工程Id
UpdDate = objRow[convUserCodePath.UpdDate] == DBNull.Value ? null : objRow[convUserCodePath.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[convUserCodePath.UpdUserId] == DBNull.Value ? null : objRow[convUserCodePath.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[convUserCodePath.Memo] == DBNull.Value ? null : objRow[convUserCodePath.Memo].ToString().Trim(), //说明
ProgLangTypeSimName = objRow[convUserCodePath.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convUserCodePath.ProgLangTypeSimName].ToString().Trim(), //编程语言类型简称
ApplicationTypeSimName = objRow[convUserCodePath.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convUserCodePath.ApplicationTypeSimName].ToString().Trim(), //应用程序类型简称
CmPrjName = objRow[convUserCodePath.CmPrjName] == DBNull.Value ? null : objRow[convUserCodePath.CmPrjName].ToString().Trim(), //CM工程名
TabMainTypeName = objRow[convUserCodePath.TabMainTypeName] == DBNull.Value ? null : objRow[convUserCodePath.TabMainTypeName].ToString().Trim(), //表主类型名
CodeTypeSimName = objRow[convUserCodePath.CodeTypeSimName] == DBNull.Value ? null : objRow[convUserCodePath.CodeTypeSimName].ToString().Trim(), //简称
IsExistCodePathP = TransNullToBool(objRow[convUserCodePath.IsExistCodePathP].ToString().Trim()), //是否存在代码目录P
IsExistCodePathBackupP = TransNullToBool(objRow[convUserCodePath.IsExistCodePathBackupP].ToString().Trim()) //是否存在备份目录P
};
objvUserCodePathEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvUserCodePathEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvUserCodePathDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvUserCodePathEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvUserCodePathEN objvUserCodePathEN = new clsvUserCodePathEN();
try
{
objvUserCodePathEN.mId = TransNullToInt(objRow[convUserCodePath.mId].ToString().Trim()); //mId
objvUserCodePathEN.CMProjectAppRelaId = TransNullToInt(objRow[convUserCodePath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objvUserCodePathEN.CodeTypeId = objRow[convUserCodePath.CodeTypeId].ToString().Trim(); //代码类型Id
objvUserCodePathEN.ProgLangTypeId = objRow[convUserCodePath.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvUserCodePathEN.ProgLangTypeName = objRow[convUserCodePath.ProgLangTypeName] == DBNull.Value ? null : objRow[convUserCodePath.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvUserCodePathEN.CmPrjId = objRow[convUserCodePath.CmPrjId] == DBNull.Value ? null : objRow[convUserCodePath.CmPrjId].ToString().Trim(); //Cm工程Id
objvUserCodePathEN.ApplicationTypeName = objRow[convUserCodePath.ApplicationTypeName] == DBNull.Value ? null : objRow[convUserCodePath.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvUserCodePathEN.ApplicationTypeENName = objRow[convUserCodePath.ApplicationTypeENName] == DBNull.Value ? null : objRow[convUserCodePath.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvUserCodePathEN.PrjFileStateName = objRow[convUserCodePath.PrjFileStateName] == DBNull.Value ? null : objRow[convUserCodePath.PrjFileStateName].ToString().Trim(); //工程文件状态名
objvUserCodePathEN.AppOrderNum = objRow[convUserCodePath.AppOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convUserCodePath.AppOrderNum].ToString().Trim()); //AppOrderNum
objvUserCodePathEN.NewCodePath = objRow[convUserCodePath.NewCodePath].ToString().Trim(); //NewCodePath
objvUserCodePathEN.NewCodePathBackup = objRow[convUserCodePath.NewCodePathBackup].ToString().Trim(); //新备份目录
objvUserCodePathEN.CodeTypeName = objRow[convUserCodePath.CodeTypeName].ToString().Trim(); //代码类型名
objvUserCodePathEN.CodeTypeENName = objRow[convUserCodePath.CodeTypeENName] == DBNull.Value ? null : objRow[convUserCodePath.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvUserCodePathEN.OrderNum = objRow[convUserCodePath.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convUserCodePath.OrderNum].ToString().Trim()); //序号
objvUserCodePathEN.ApplicationTypeId = TransNullToInt(objRow[convUserCodePath.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvUserCodePathEN.TabMainTypeId = objRow[convUserCodePath.TabMainTypeId] == DBNull.Value ? null : objRow[convUserCodePath.TabMainTypeId].ToString().Trim(); //表主类型Id
objvUserCodePathEN.IsGeneCode = TransNullToBool(objRow[convUserCodePath.IsGeneCode].ToString().Trim()); //是否生成代码
objvUserCodePathEN.ProjectFileName = objRow[convUserCodePath.ProjectFileName].ToString().Trim(); //工程文件名
objvUserCodePathEN.ProjectPath = objRow[convUserCodePath.ProjectPath].ToString().Trim(); //工程路径
objvUserCodePathEN.PrjFileStateId = objRow[convUserCodePath.PrjFileStateId] == DBNull.Value ? null : objRow[convUserCodePath.PrjFileStateId].ToString().Trim(); //工程文件状态Id
objvUserCodePathEN.CodePath = objRow[convUserCodePath.CodePath].ToString().Trim(); //代码路径
objvUserCodePathEN.CodePathBackup = objRow[convUserCodePath.CodePathBackup].ToString().Trim(); //备份代码路径
objvUserCodePathEN.SuffixPath = objRow[convUserCodePath.SuffixPath] == DBNull.Value ? null : objRow[convUserCodePath.SuffixPath].ToString().Trim(); //后缀路径
objvUserCodePathEN.IsTemplate = TransNullToBool(objRow[convUserCodePath.IsTemplate].ToString().Trim()); //是否模板
objvUserCodePathEN.IsExistCodePath = TransNullToBool(objRow[convUserCodePath.IsExistCodePath].ToString().Trim()); //是否存在代码路径
objvUserCodePathEN.IsExistCodePathBackup = TransNullToBool(objRow[convUserCodePath.IsExistCodePathBackup].ToString().Trim()); //是否存在备份路径
objvUserCodePathEN.PrjId = objRow[convUserCodePath.PrjId].ToString().Trim(); //工程Id
objvUserCodePathEN.UpdDate = objRow[convUserCodePath.UpdDate] == DBNull.Value ? null : objRow[convUserCodePath.UpdDate].ToString().Trim(); //修改日期
objvUserCodePathEN.UpdUserId = objRow[convUserCodePath.UpdUserId] == DBNull.Value ? null : objRow[convUserCodePath.UpdUserId].ToString().Trim(); //修改用户Id
objvUserCodePathEN.Memo = objRow[convUserCodePath.Memo] == DBNull.Value ? null : objRow[convUserCodePath.Memo].ToString().Trim(); //说明
objvUserCodePathEN.ProgLangTypeSimName = objRow[convUserCodePath.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convUserCodePath.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvUserCodePathEN.ApplicationTypeSimName = objRow[convUserCodePath.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convUserCodePath.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvUserCodePathEN.CmPrjName = objRow[convUserCodePath.CmPrjName] == DBNull.Value ? null : objRow[convUserCodePath.CmPrjName].ToString().Trim(); //CM工程名
objvUserCodePathEN.TabMainTypeName = objRow[convUserCodePath.TabMainTypeName] == DBNull.Value ? null : objRow[convUserCodePath.TabMainTypeName].ToString().Trim(); //表主类型名
objvUserCodePathEN.CodeTypeSimName = objRow[convUserCodePath.CodeTypeSimName] == DBNull.Value ? null : objRow[convUserCodePath.CodeTypeSimName].ToString().Trim(); //简称
objvUserCodePathEN.IsExistCodePathP = TransNullToBool(objRow[convUserCodePath.IsExistCodePathP].ToString().Trim()); //是否存在代码目录P
objvUserCodePathEN.IsExistCodePathBackupP = TransNullToBool(objRow[convUserCodePath.IsExistCodePathBackupP].ToString().Trim()); //是否存在备份目录P
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvUserCodePathDA: GetObjByDataRowvUserCodePath)", objException.Message));
}
objvUserCodePathEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvUserCodePathEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvUserCodePathEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvUserCodePathEN objvUserCodePathEN = new clsvUserCodePathEN();
try
{
objvUserCodePathEN.mId = TransNullToInt(objRow[convUserCodePath.mId].ToString().Trim()); //mId
objvUserCodePathEN.CMProjectAppRelaId = TransNullToInt(objRow[convUserCodePath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objvUserCodePathEN.CodeTypeId = objRow[convUserCodePath.CodeTypeId].ToString().Trim(); //代码类型Id
objvUserCodePathEN.ProgLangTypeId = objRow[convUserCodePath.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvUserCodePathEN.ProgLangTypeName = objRow[convUserCodePath.ProgLangTypeName] == DBNull.Value ? null : objRow[convUserCodePath.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvUserCodePathEN.CmPrjId = objRow[convUserCodePath.CmPrjId] == DBNull.Value ? null : objRow[convUserCodePath.CmPrjId].ToString().Trim(); //Cm工程Id
objvUserCodePathEN.ApplicationTypeName = objRow[convUserCodePath.ApplicationTypeName] == DBNull.Value ? null : objRow[convUserCodePath.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvUserCodePathEN.ApplicationTypeENName = objRow[convUserCodePath.ApplicationTypeENName] == DBNull.Value ? null : objRow[convUserCodePath.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvUserCodePathEN.PrjFileStateName = objRow[convUserCodePath.PrjFileStateName] == DBNull.Value ? null : objRow[convUserCodePath.PrjFileStateName].ToString().Trim(); //工程文件状态名
objvUserCodePathEN.AppOrderNum = objRow[convUserCodePath.AppOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convUserCodePath.AppOrderNum].ToString().Trim()); //AppOrderNum
objvUserCodePathEN.NewCodePath = objRow[convUserCodePath.NewCodePath].ToString().Trim(); //NewCodePath
objvUserCodePathEN.NewCodePathBackup = objRow[convUserCodePath.NewCodePathBackup].ToString().Trim(); //新备份目录
objvUserCodePathEN.CodeTypeName = objRow[convUserCodePath.CodeTypeName].ToString().Trim(); //代码类型名
objvUserCodePathEN.CodeTypeENName = objRow[convUserCodePath.CodeTypeENName] == DBNull.Value ? null : objRow[convUserCodePath.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvUserCodePathEN.OrderNum = objRow[convUserCodePath.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convUserCodePath.OrderNum].ToString().Trim()); //序号
objvUserCodePathEN.ApplicationTypeId = TransNullToInt(objRow[convUserCodePath.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvUserCodePathEN.TabMainTypeId = objRow[convUserCodePath.TabMainTypeId] == DBNull.Value ? null : objRow[convUserCodePath.TabMainTypeId].ToString().Trim(); //表主类型Id
objvUserCodePathEN.IsGeneCode = TransNullToBool(objRow[convUserCodePath.IsGeneCode].ToString().Trim()); //是否生成代码
objvUserCodePathEN.ProjectFileName = objRow[convUserCodePath.ProjectFileName].ToString().Trim(); //工程文件名
objvUserCodePathEN.ProjectPath = objRow[convUserCodePath.ProjectPath].ToString().Trim(); //工程路径
objvUserCodePathEN.PrjFileStateId = objRow[convUserCodePath.PrjFileStateId] == DBNull.Value ? null : objRow[convUserCodePath.PrjFileStateId].ToString().Trim(); //工程文件状态Id
objvUserCodePathEN.CodePath = objRow[convUserCodePath.CodePath].ToString().Trim(); //代码路径
objvUserCodePathEN.CodePathBackup = objRow[convUserCodePath.CodePathBackup].ToString().Trim(); //备份代码路径
objvUserCodePathEN.SuffixPath = objRow[convUserCodePath.SuffixPath] == DBNull.Value ? null : objRow[convUserCodePath.SuffixPath].ToString().Trim(); //后缀路径
objvUserCodePathEN.IsTemplate = TransNullToBool(objRow[convUserCodePath.IsTemplate].ToString().Trim()); //是否模板
objvUserCodePathEN.IsExistCodePath = TransNullToBool(objRow[convUserCodePath.IsExistCodePath].ToString().Trim()); //是否存在代码路径
objvUserCodePathEN.IsExistCodePathBackup = TransNullToBool(objRow[convUserCodePath.IsExistCodePathBackup].ToString().Trim()); //是否存在备份路径
objvUserCodePathEN.PrjId = objRow[convUserCodePath.PrjId].ToString().Trim(); //工程Id
objvUserCodePathEN.UpdDate = objRow[convUserCodePath.UpdDate] == DBNull.Value ? null : objRow[convUserCodePath.UpdDate].ToString().Trim(); //修改日期
objvUserCodePathEN.UpdUserId = objRow[convUserCodePath.UpdUserId] == DBNull.Value ? null : objRow[convUserCodePath.UpdUserId].ToString().Trim(); //修改用户Id
objvUserCodePathEN.Memo = objRow[convUserCodePath.Memo] == DBNull.Value ? null : objRow[convUserCodePath.Memo].ToString().Trim(); //说明
objvUserCodePathEN.ProgLangTypeSimName = objRow[convUserCodePath.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convUserCodePath.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvUserCodePathEN.ApplicationTypeSimName = objRow[convUserCodePath.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convUserCodePath.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvUserCodePathEN.CmPrjName = objRow[convUserCodePath.CmPrjName] == DBNull.Value ? null : objRow[convUserCodePath.CmPrjName].ToString().Trim(); //CM工程名
objvUserCodePathEN.TabMainTypeName = objRow[convUserCodePath.TabMainTypeName] == DBNull.Value ? null : objRow[convUserCodePath.TabMainTypeName].ToString().Trim(); //表主类型名
objvUserCodePathEN.CodeTypeSimName = objRow[convUserCodePath.CodeTypeSimName] == DBNull.Value ? null : objRow[convUserCodePath.CodeTypeSimName].ToString().Trim(); //简称
objvUserCodePathEN.IsExistCodePathP = TransNullToBool(objRow[convUserCodePath.IsExistCodePathP].ToString().Trim()); //是否存在代码目录P
objvUserCodePathEN.IsExistCodePathBackupP = TransNullToBool(objRow[convUserCodePath.IsExistCodePathBackupP].ToString().Trim()); //是否存在备份目录P
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvUserCodePathDA: GetObjByDataRow)", objException.Message));
}
objvUserCodePathEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvUserCodePathEN;
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
objSQL = clsvUserCodePathDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvUserCodePathEN._CurrTabName, convUserCodePath.mId, 8, "");
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
objSQL = clsvUserCodePathDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvUserCodePathEN._CurrTabName, convUserCodePath.mId, 8, strPrefix);
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
 objSQL = clsvUserCodePathDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vUserCodePath where " + strCondition;
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
 objSQL = clsvUserCodePathDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vUserCodePath where " + strCondition;
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
 objSQL = clsvUserCodePathDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vUserCodePath", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvUserCodePathDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserCodePathDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vUserCodePath", strCondition))
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
objSQL = clsvUserCodePathDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vUserCodePath");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvUserCodePathENS">源对象</param>
 /// <param name = "objvUserCodePathENT">目标对象</param>
public void CopyTo(clsvUserCodePathEN objvUserCodePathENS, clsvUserCodePathEN objvUserCodePathENT)
{
objvUserCodePathENT.mId = objvUserCodePathENS.mId; //mId
objvUserCodePathENT.CMProjectAppRelaId = objvUserCodePathENS.CMProjectAppRelaId; //Cm工程应用关系Id
objvUserCodePathENT.CodeTypeId = objvUserCodePathENS.CodeTypeId; //代码类型Id
objvUserCodePathENT.ProgLangTypeId = objvUserCodePathENS.ProgLangTypeId; //编程语言类型Id
objvUserCodePathENT.ProgLangTypeName = objvUserCodePathENS.ProgLangTypeName; //编程语言类型名
objvUserCodePathENT.CmPrjId = objvUserCodePathENS.CmPrjId; //Cm工程Id
objvUserCodePathENT.ApplicationTypeName = objvUserCodePathENS.ApplicationTypeName; //应用程序类型名称
objvUserCodePathENT.ApplicationTypeENName = objvUserCodePathENS.ApplicationTypeENName; //应用类型英文名
objvUserCodePathENT.PrjFileStateName = objvUserCodePathENS.PrjFileStateName; //工程文件状态名
objvUserCodePathENT.AppOrderNum = objvUserCodePathENS.AppOrderNum; //AppOrderNum
objvUserCodePathENT.NewCodePath = objvUserCodePathENS.NewCodePath; //NewCodePath
objvUserCodePathENT.NewCodePathBackup = objvUserCodePathENS.NewCodePathBackup; //新备份目录
objvUserCodePathENT.CodeTypeName = objvUserCodePathENS.CodeTypeName; //代码类型名
objvUserCodePathENT.CodeTypeENName = objvUserCodePathENS.CodeTypeENName; //代码类型英文名
objvUserCodePathENT.OrderNum = objvUserCodePathENS.OrderNum; //序号
objvUserCodePathENT.ApplicationTypeId = objvUserCodePathENS.ApplicationTypeId; //应用程序类型ID
objvUserCodePathENT.TabMainTypeId = objvUserCodePathENS.TabMainTypeId; //表主类型Id
objvUserCodePathENT.IsGeneCode = objvUserCodePathENS.IsGeneCode; //是否生成代码
objvUserCodePathENT.ProjectFileName = objvUserCodePathENS.ProjectFileName; //工程文件名
objvUserCodePathENT.ProjectPath = objvUserCodePathENS.ProjectPath; //工程路径
objvUserCodePathENT.PrjFileStateId = objvUserCodePathENS.PrjFileStateId; //工程文件状态Id
objvUserCodePathENT.CodePath = objvUserCodePathENS.CodePath; //代码路径
objvUserCodePathENT.CodePathBackup = objvUserCodePathENS.CodePathBackup; //备份代码路径
objvUserCodePathENT.SuffixPath = objvUserCodePathENS.SuffixPath; //后缀路径
objvUserCodePathENT.IsTemplate = objvUserCodePathENS.IsTemplate; //是否模板
objvUserCodePathENT.IsExistCodePath = objvUserCodePathENS.IsExistCodePath; //是否存在代码路径
objvUserCodePathENT.IsExistCodePathBackup = objvUserCodePathENS.IsExistCodePathBackup; //是否存在备份路径
objvUserCodePathENT.PrjId = objvUserCodePathENS.PrjId; //工程Id
objvUserCodePathENT.UpdDate = objvUserCodePathENS.UpdDate; //修改日期
objvUserCodePathENT.UpdUserId = objvUserCodePathENS.UpdUserId; //修改用户Id
objvUserCodePathENT.Memo = objvUserCodePathENS.Memo; //说明
objvUserCodePathENT.ProgLangTypeSimName = objvUserCodePathENS.ProgLangTypeSimName; //编程语言类型简称
objvUserCodePathENT.ApplicationTypeSimName = objvUserCodePathENS.ApplicationTypeSimName; //应用程序类型简称
objvUserCodePathENT.CmPrjName = objvUserCodePathENS.CmPrjName; //CM工程名
objvUserCodePathENT.TabMainTypeName = objvUserCodePathENS.TabMainTypeName; //表主类型名
objvUserCodePathENT.CodeTypeSimName = objvUserCodePathENS.CodeTypeSimName; //简称
objvUserCodePathENT.IsExistCodePathP = objvUserCodePathENS.IsExistCodePathP; //是否存在代码目录P
objvUserCodePathENT.IsExistCodePathBackupP = objvUserCodePathENS.IsExistCodePathBackupP; //是否存在备份目录P
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvUserCodePathEN objvUserCodePathEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvUserCodePathEN.CodeTypeId, 4, convUserCodePath.CodeTypeId);
clsCheckSql.CheckFieldLen(objvUserCodePathEN.ProgLangTypeId, 2, convUserCodePath.ProgLangTypeId);
clsCheckSql.CheckFieldLen(objvUserCodePathEN.ProgLangTypeName, 30, convUserCodePath.ProgLangTypeName);
clsCheckSql.CheckFieldLen(objvUserCodePathEN.CmPrjId, 6, convUserCodePath.CmPrjId);
clsCheckSql.CheckFieldLen(objvUserCodePathEN.ApplicationTypeName, 30, convUserCodePath.ApplicationTypeName);
clsCheckSql.CheckFieldLen(objvUserCodePathEN.ApplicationTypeENName, 30, convUserCodePath.ApplicationTypeENName);
clsCheckSql.CheckFieldLen(objvUserCodePathEN.PrjFileStateName, 30, convUserCodePath.PrjFileStateName);
clsCheckSql.CheckFieldLen(objvUserCodePathEN.NewCodePath, 2, convUserCodePath.NewCodePath);
clsCheckSql.CheckFieldLen(objvUserCodePathEN.NewCodePathBackup, 2, convUserCodePath.NewCodePathBackup);
clsCheckSql.CheckFieldLen(objvUserCodePathEN.CodeTypeName, 50, convUserCodePath.CodeTypeName);
clsCheckSql.CheckFieldLen(objvUserCodePathEN.CodeTypeENName, 50, convUserCodePath.CodeTypeENName);
clsCheckSql.CheckFieldLen(objvUserCodePathEN.TabMainTypeId, 4, convUserCodePath.TabMainTypeId);
clsCheckSql.CheckFieldLen(objvUserCodePathEN.ProjectFileName, 200, convUserCodePath.ProjectFileName);
clsCheckSql.CheckFieldLen(objvUserCodePathEN.ProjectPath, 500, convUserCodePath.ProjectPath);
clsCheckSql.CheckFieldLen(objvUserCodePathEN.PrjFileStateId, 2, convUserCodePath.PrjFileStateId);
clsCheckSql.CheckFieldLen(objvUserCodePathEN.CodePath, 200, convUserCodePath.CodePath);
clsCheckSql.CheckFieldLen(objvUserCodePathEN.CodePathBackup, 200, convUserCodePath.CodePathBackup);
clsCheckSql.CheckFieldLen(objvUserCodePathEN.SuffixPath, 50, convUserCodePath.SuffixPath);
clsCheckSql.CheckFieldLen(objvUserCodePathEN.PrjId, 4, convUserCodePath.PrjId);
clsCheckSql.CheckFieldLen(objvUserCodePathEN.UpdDate, 20, convUserCodePath.UpdDate);
clsCheckSql.CheckFieldLen(objvUserCodePathEN.UpdUserId, 20, convUserCodePath.UpdUserId);
clsCheckSql.CheckFieldLen(objvUserCodePathEN.Memo, 1000, convUserCodePath.Memo);
clsCheckSql.CheckFieldLen(objvUserCodePathEN.ProgLangTypeSimName, 30, convUserCodePath.ProgLangTypeSimName);
clsCheckSql.CheckFieldLen(objvUserCodePathEN.ApplicationTypeSimName, 30, convUserCodePath.ApplicationTypeSimName);
clsCheckSql.CheckFieldLen(objvUserCodePathEN.CmPrjName, 50, convUserCodePath.CmPrjName);
clsCheckSql.CheckFieldLen(objvUserCodePathEN.TabMainTypeName, 30, convUserCodePath.TabMainTypeName);
clsCheckSql.CheckFieldLen(objvUserCodePathEN.CodeTypeSimName, 50, convUserCodePath.CodeTypeSimName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvUserCodePathEN.CodeTypeId, convUserCodePath.CodeTypeId);
clsCheckSql.CheckSqlInjection4Field(objvUserCodePathEN.ProgLangTypeId, convUserCodePath.ProgLangTypeId);
clsCheckSql.CheckSqlInjection4Field(objvUserCodePathEN.ProgLangTypeName, convUserCodePath.ProgLangTypeName);
clsCheckSql.CheckSqlInjection4Field(objvUserCodePathEN.CmPrjId, convUserCodePath.CmPrjId);
clsCheckSql.CheckSqlInjection4Field(objvUserCodePathEN.ApplicationTypeName, convUserCodePath.ApplicationTypeName);
clsCheckSql.CheckSqlInjection4Field(objvUserCodePathEN.ApplicationTypeENName, convUserCodePath.ApplicationTypeENName);
clsCheckSql.CheckSqlInjection4Field(objvUserCodePathEN.PrjFileStateName, convUserCodePath.PrjFileStateName);
clsCheckSql.CheckSqlInjection4Field(objvUserCodePathEN.NewCodePath, convUserCodePath.NewCodePath);
clsCheckSql.CheckSqlInjection4Field(objvUserCodePathEN.NewCodePathBackup, convUserCodePath.NewCodePathBackup);
clsCheckSql.CheckSqlInjection4Field(objvUserCodePathEN.CodeTypeName, convUserCodePath.CodeTypeName);
clsCheckSql.CheckSqlInjection4Field(objvUserCodePathEN.CodeTypeENName, convUserCodePath.CodeTypeENName);
clsCheckSql.CheckSqlInjection4Field(objvUserCodePathEN.TabMainTypeId, convUserCodePath.TabMainTypeId);
clsCheckSql.CheckSqlInjection4Field(objvUserCodePathEN.ProjectFileName, convUserCodePath.ProjectFileName);
clsCheckSql.CheckSqlInjection4Field(objvUserCodePathEN.ProjectPath, convUserCodePath.ProjectPath);
clsCheckSql.CheckSqlInjection4Field(objvUserCodePathEN.PrjFileStateId, convUserCodePath.PrjFileStateId);
clsCheckSql.CheckSqlInjection4Field(objvUserCodePathEN.CodePath, convUserCodePath.CodePath);
clsCheckSql.CheckSqlInjection4Field(objvUserCodePathEN.CodePathBackup, convUserCodePath.CodePathBackup);
clsCheckSql.CheckSqlInjection4Field(objvUserCodePathEN.SuffixPath, convUserCodePath.SuffixPath);
clsCheckSql.CheckSqlInjection4Field(objvUserCodePathEN.PrjId, convUserCodePath.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvUserCodePathEN.UpdDate, convUserCodePath.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvUserCodePathEN.UpdUserId, convUserCodePath.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objvUserCodePathEN.Memo, convUserCodePath.Memo);
clsCheckSql.CheckSqlInjection4Field(objvUserCodePathEN.ProgLangTypeSimName, convUserCodePath.ProgLangTypeSimName);
clsCheckSql.CheckSqlInjection4Field(objvUserCodePathEN.ApplicationTypeSimName, convUserCodePath.ApplicationTypeSimName);
clsCheckSql.CheckSqlInjection4Field(objvUserCodePathEN.CmPrjName, convUserCodePath.CmPrjName);
clsCheckSql.CheckSqlInjection4Field(objvUserCodePathEN.TabMainTypeName, convUserCodePath.TabMainTypeName);
clsCheckSql.CheckSqlInjection4Field(objvUserCodePathEN.CodeTypeSimName, convUserCodePath.CodeTypeSimName);
//检查外键字段长度
 objvUserCodePathEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--vUserCodePath(v用户生成路径),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objvUserCodePathEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsvUserCodePathEN objvUserCodePathEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CMProjectAppRelaId = '{0}'", objvUserCodePathEN.CMProjectAppRelaId);
 sbCondition.AppendFormat(" and CodeTypeId = '{0}'", objvUserCodePathEN.CodeTypeId);
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
 objSQL = clsvUserCodePathDA.GetSpecSQLObj();
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
 objSQL = clsvUserCodePathDA.GetSpecSQLObj();
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
 objSQL = clsvUserCodePathDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvUserCodePathEN._CurrTabName);
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
 objSQL = clsvUserCodePathDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvUserCodePathEN._CurrTabName, strCondition);
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
 objSQL = clsvUserCodePathDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}