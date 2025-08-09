
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCMFunctionDA
 表名:vCMFunction(00050507)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:04:03
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
 /// vCM函数(vCMFunction)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvCMFunctionDA : clsCommBase4DA
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
 return clsvCMFunctionEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvCMFunctionEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCMFunctionEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvCMFunctionEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvCMFunctionEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strCmFunctionId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strCmFunctionId)
{
strCmFunctionId = strCmFunctionId.Replace("'", "''");
if (strCmFunctionId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vCMFunction中,检查关键字,长度不正确!(clsvCMFunctionDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strCmFunctionId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vCMFunction中,关键字不能为空 或 null!(clsvCMFunctionDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCmFunctionId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvCMFunctionDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvCMFunctionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFunctionDA.GetSpecSQLObj();
strSQL = "Select * from vCMFunction where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vCMFunction(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvCMFunctionDA: GetDataTable_vCMFunction)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFunctionDA.GetSpecSQLObj();
strSQL = "Select * from vCMFunction where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvCMFunctionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFunctionDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvCMFunctionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFunctionDA.GetSpecSQLObj();
strSQL = "Select * from vCMFunction where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvCMFunctionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFunctionDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvCMFunctionDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFunctionDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCMFunction where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCMFunction where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvCMFunctionDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFunctionDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vCMFunction where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvCMFunctionDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFunctionDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vCMFunction.* " + 
$"from vCMFunction " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vCMFunction.CmFunctionId not in " + 
$"(Select top {intTop_In} vCMFunction.CmFunctionId from vCMFunction " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCMFunction where {1} and CmFunctionId not in (Select top {2} CmFunctionId from vCMFunction where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCMFunction where {1} and CmFunctionId not in (Select top {3} CmFunctionId from vCMFunction where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvCMFunctionDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFunctionDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vCMFunction.* " + 
$"from vCMFunction " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vCMFunction.CmFunctionId not in " + 
$"(Select top {intTop_In} vCMFunction.CmFunctionId from vCMFunction " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCMFunction where {1} and CmFunctionId not in (Select top {2} CmFunctionId from vCMFunction where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCMFunction where {1} and CmFunctionId not in (Select top {3} CmFunctionId from vCMFunction where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvCMFunctionEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvCMFunctionDA:GetObjLst)", objException.Message));
}
List<clsvCMFunctionEN> arrObjLst = new List<clsvCMFunctionEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFunctionDA.GetSpecSQLObj();
strSQL = "Select * from vCMFunction where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFunctionEN objvCMFunctionEN = new clsvCMFunctionEN();
try
{
objvCMFunctionEN.CmFunctionId = objRow[convCMFunction.CmFunctionId].ToString().Trim(); //函数Id
objvCMFunctionEN.CmClassId = objRow[convCMFunction.CmClassId].ToString().Trim(); //类Id
objvCMFunctionEN.ApplicationTypeId = objRow[convCMFunction.ApplicationTypeId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCMFunction.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMFunctionEN.ProgLangTypeId = objRow[convCMFunction.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCMFunctionEN.ProgLangTypeName = objRow[convCMFunction.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvCMFunctionEN.ProgLangTypeSimName = objRow[convCMFunction.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCMFunction.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvCMFunctionEN.NameSpace = objRow[convCMFunction.NameSpace] == DBNull.Value ? null : objRow[convCMFunction.NameSpace].ToString().Trim(); //域名
objvCMFunctionEN.ProjectPath = objRow[convCMFunction.ProjectPath] == DBNull.Value ? null : objRow[convCMFunction.ProjectPath].ToString().Trim(); //工程路径
objvCMFunctionEN.FilePath = objRow[convCMFunction.FilePath] == DBNull.Value ? null : objRow[convCMFunction.FilePath].ToString().Trim(); //文件路径
objvCMFunctionEN.FileName = objRow[convCMFunction.FileName] == DBNull.Value ? null : objRow[convCMFunction.FileName].ToString().Trim(); //文件名
objvCMFunctionEN.CodeTypeId = objRow[convCMFunction.CodeTypeId] == DBNull.Value ? null : objRow[convCMFunction.CodeTypeId].ToString().Trim(); //代码类型Id
objvCMFunctionEN.UserId = objRow[convCMFunction.UserId] == DBNull.Value ? null : objRow[convCMFunction.UserId].ToString().Trim(); //用户Id
objvCMFunctionEN.PrjId = objRow[convCMFunction.PrjId] == DBNull.Value ? null : objRow[convCMFunction.PrjId].ToString().Trim(); //工程Id
objvCMFunctionEN.PrjName = objRow[convCMFunction.PrjName] == DBNull.Value ? null : objRow[convCMFunction.PrjName].ToString().Trim(); //工程名称
objvCMFunctionEN.FunctionName = objRow[convCMFunction.FunctionName] == DBNull.Value ? null : objRow[convCMFunction.FunctionName].ToString().Trim(); //功能名称
objvCMFunctionEN.FuncContent = objRow[convCMFunction.FuncContent] == DBNull.Value ? null : objRow[convCMFunction.FuncContent].ToString().Trim(); //函数内容
objvCMFunctionEN.KeyWords = objRow[convCMFunction.KeyWords] == DBNull.Value ? null : objRow[convCMFunction.KeyWords].ToString().Trim(); //关键字
objvCMFunctionEN.FuncParaLst = objRow[convCMFunction.FuncParaLst] == DBNull.Value ? null : objRow[convCMFunction.FuncParaLst].ToString().Trim(); //函数参数列表
objvCMFunctionEN.FuncComments = objRow[convCMFunction.FuncComments] == DBNull.Value ? null : objRow[convCMFunction.FuncComments].ToString().Trim(); //函数注释
objvCMFunctionEN.FunctionSignature = objRow[convCMFunction.FunctionSignature].ToString().Trim(); //函数签名
objvCMFunctionEN.ReturnType = objRow[convCMFunction.ReturnType].ToString().Trim(); //返回类型
objvCMFunctionEN.IsKnownType = TransNullToBool(objRow[convCMFunction.IsKnownType].ToString().Trim()); //是否已知类型
objvCMFunctionEN.ReturnTypeId = objRow[convCMFunction.ReturnTypeId] == DBNull.Value ? null : objRow[convCMFunction.ReturnTypeId].ToString().Trim(); //返回类型ID
objvCMFunctionEN.ClassNameLst = objRow[convCMFunction.ClassNameLst] == DBNull.Value ? null : objRow[convCMFunction.ClassNameLst].ToString().Trim(); //类名列表
objvCMFunctionEN.UpdDate = objRow[convCMFunction.UpdDate] == DBNull.Value ? null : objRow[convCMFunction.UpdDate].ToString().Trim(); //修改日期
objvCMFunctionEN.UpdUser = objRow[convCMFunction.UpdUser] == DBNull.Value ? null : objRow[convCMFunction.UpdUser].ToString().Trim(); //修改者
objvCMFunctionEN.Memo = objRow[convCMFunction.Memo] == DBNull.Value ? null : objRow[convCMFunction.Memo].ToString().Trim(); //说明
objvCMFunctionEN.ParaNum = objRow[convCMFunction.ParaNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCMFunction.ParaNum].ToString().Trim()); //参数个数
objvCMFunctionEN.ClsName = objRow[convCMFunction.ClsName] == DBNull.Value ? null : objRow[convCMFunction.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCMFunctionDA: GetObjLst)", objException.Message));
}
objvCMFunctionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCMFunctionEN);
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
public List<clsvCMFunctionEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvCMFunctionDA:GetObjLstByTabName)", objException.Message));
}
List<clsvCMFunctionEN> arrObjLst = new List<clsvCMFunctionEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFunctionDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFunctionEN objvCMFunctionEN = new clsvCMFunctionEN();
try
{
objvCMFunctionEN.CmFunctionId = objRow[convCMFunction.CmFunctionId].ToString().Trim(); //函数Id
objvCMFunctionEN.CmClassId = objRow[convCMFunction.CmClassId].ToString().Trim(); //类Id
objvCMFunctionEN.ApplicationTypeId = objRow[convCMFunction.ApplicationTypeId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCMFunction.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMFunctionEN.ProgLangTypeId = objRow[convCMFunction.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCMFunctionEN.ProgLangTypeName = objRow[convCMFunction.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvCMFunctionEN.ProgLangTypeSimName = objRow[convCMFunction.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCMFunction.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvCMFunctionEN.NameSpace = objRow[convCMFunction.NameSpace] == DBNull.Value ? null : objRow[convCMFunction.NameSpace].ToString().Trim(); //域名
objvCMFunctionEN.ProjectPath = objRow[convCMFunction.ProjectPath] == DBNull.Value ? null : objRow[convCMFunction.ProjectPath].ToString().Trim(); //工程路径
objvCMFunctionEN.FilePath = objRow[convCMFunction.FilePath] == DBNull.Value ? null : objRow[convCMFunction.FilePath].ToString().Trim(); //文件路径
objvCMFunctionEN.FileName = objRow[convCMFunction.FileName] == DBNull.Value ? null : objRow[convCMFunction.FileName].ToString().Trim(); //文件名
objvCMFunctionEN.CodeTypeId = objRow[convCMFunction.CodeTypeId] == DBNull.Value ? null : objRow[convCMFunction.CodeTypeId].ToString().Trim(); //代码类型Id
objvCMFunctionEN.UserId = objRow[convCMFunction.UserId] == DBNull.Value ? null : objRow[convCMFunction.UserId].ToString().Trim(); //用户Id
objvCMFunctionEN.PrjId = objRow[convCMFunction.PrjId] == DBNull.Value ? null : objRow[convCMFunction.PrjId].ToString().Trim(); //工程Id
objvCMFunctionEN.PrjName = objRow[convCMFunction.PrjName] == DBNull.Value ? null : objRow[convCMFunction.PrjName].ToString().Trim(); //工程名称
objvCMFunctionEN.FunctionName = objRow[convCMFunction.FunctionName] == DBNull.Value ? null : objRow[convCMFunction.FunctionName].ToString().Trim(); //功能名称
objvCMFunctionEN.FuncContent = objRow[convCMFunction.FuncContent] == DBNull.Value ? null : objRow[convCMFunction.FuncContent].ToString().Trim(); //函数内容
objvCMFunctionEN.KeyWords = objRow[convCMFunction.KeyWords] == DBNull.Value ? null : objRow[convCMFunction.KeyWords].ToString().Trim(); //关键字
objvCMFunctionEN.FuncParaLst = objRow[convCMFunction.FuncParaLst] == DBNull.Value ? null : objRow[convCMFunction.FuncParaLst].ToString().Trim(); //函数参数列表
objvCMFunctionEN.FuncComments = objRow[convCMFunction.FuncComments] == DBNull.Value ? null : objRow[convCMFunction.FuncComments].ToString().Trim(); //函数注释
objvCMFunctionEN.FunctionSignature = objRow[convCMFunction.FunctionSignature].ToString().Trim(); //函数签名
objvCMFunctionEN.ReturnType = objRow[convCMFunction.ReturnType].ToString().Trim(); //返回类型
objvCMFunctionEN.IsKnownType = TransNullToBool(objRow[convCMFunction.IsKnownType].ToString().Trim()); //是否已知类型
objvCMFunctionEN.ReturnTypeId = objRow[convCMFunction.ReturnTypeId] == DBNull.Value ? null : objRow[convCMFunction.ReturnTypeId].ToString().Trim(); //返回类型ID
objvCMFunctionEN.ClassNameLst = objRow[convCMFunction.ClassNameLst] == DBNull.Value ? null : objRow[convCMFunction.ClassNameLst].ToString().Trim(); //类名列表
objvCMFunctionEN.UpdDate = objRow[convCMFunction.UpdDate] == DBNull.Value ? null : objRow[convCMFunction.UpdDate].ToString().Trim(); //修改日期
objvCMFunctionEN.UpdUser = objRow[convCMFunction.UpdUser] == DBNull.Value ? null : objRow[convCMFunction.UpdUser].ToString().Trim(); //修改者
objvCMFunctionEN.Memo = objRow[convCMFunction.Memo] == DBNull.Value ? null : objRow[convCMFunction.Memo].ToString().Trim(); //说明
objvCMFunctionEN.ParaNum = objRow[convCMFunction.ParaNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCMFunction.ParaNum].ToString().Trim()); //参数个数
objvCMFunctionEN.ClsName = objRow[convCMFunction.ClsName] == DBNull.Value ? null : objRow[convCMFunction.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCMFunctionDA: GetObjLst)", objException.Message));
}
objvCMFunctionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCMFunctionEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvCMFunction(ref clsvCMFunctionEN objvCMFunctionEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFunctionDA.GetSpecSQLObj();
strSQL = "Select * from vCMFunction where CmFunctionId = " + "'"+ objvCMFunctionEN.CmFunctionId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvCMFunctionEN.CmFunctionId = objDT.Rows[0][convCMFunction.CmFunctionId].ToString().Trim(); //函数Id(字段类型:char,字段长度:8,是否可空:False)
 objvCMFunctionEN.CmClassId = objDT.Rows[0][convCMFunction.CmClassId].ToString().Trim(); //类Id(字段类型:char,字段长度:8,是否可空:False)
 objvCMFunctionEN.ApplicationTypeId = TransNullToInt(objDT.Rows[0][convCMFunction.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objvCMFunctionEN.ProgLangTypeId = objDT.Rows[0][convCMFunction.ProgLangTypeId].ToString().Trim(); //编程语言类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvCMFunctionEN.ProgLangTypeName = objDT.Rows[0][convCMFunction.ProgLangTypeName].ToString().Trim(); //编程语言类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvCMFunctionEN.ProgLangTypeSimName = objDT.Rows[0][convCMFunction.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvCMFunctionEN.NameSpace = objDT.Rows[0][convCMFunction.NameSpace].ToString().Trim(); //域名(字段类型:varchar,字段长度:50,是否可空:True)
 objvCMFunctionEN.ProjectPath = objDT.Rows[0][convCMFunction.ProjectPath].ToString().Trim(); //工程路径(字段类型:varchar,字段长度:500,是否可空:False)
 objvCMFunctionEN.FilePath = objDT.Rows[0][convCMFunction.FilePath].ToString().Trim(); //文件路径(字段类型:varchar,字段长度:500,是否可空:False)
 objvCMFunctionEN.FileName = objDT.Rows[0][convCMFunction.FileName].ToString().Trim(); //文件名(字段类型:varchar,字段长度:150,是否可空:False)
 objvCMFunctionEN.CodeTypeId = objDT.Rows[0][convCMFunction.CodeTypeId].ToString().Trim(); //代码类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvCMFunctionEN.UserId = objDT.Rows[0][convCMFunction.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objvCMFunctionEN.PrjId = objDT.Rows[0][convCMFunction.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvCMFunctionEN.PrjName = objDT.Rows[0][convCMFunction.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCMFunctionEN.FunctionName = objDT.Rows[0][convCMFunction.FunctionName].ToString().Trim(); //功能名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvCMFunctionEN.FuncContent = objDT.Rows[0][convCMFunction.FuncContent].ToString().Trim(); //函数内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvCMFunctionEN.KeyWords = objDT.Rows[0][convCMFunction.KeyWords].ToString().Trim(); //关键字(字段类型:varchar,字段长度:500,是否可空:True)
 objvCMFunctionEN.FuncParaLst = objDT.Rows[0][convCMFunction.FuncParaLst].ToString().Trim(); //函数参数列表(字段类型:varchar,字段长度:500,是否可空:True)
 objvCMFunctionEN.FuncComments = objDT.Rows[0][convCMFunction.FuncComments].ToString().Trim(); //函数注释(字段类型:text,字段长度:5000,是否可空:True)
 objvCMFunctionEN.FunctionSignature = objDT.Rows[0][convCMFunction.FunctionSignature].ToString().Trim(); //函数签名(字段类型:varchar,字段长度:500,是否可空:False)
 objvCMFunctionEN.ReturnType = objDT.Rows[0][convCMFunction.ReturnType].ToString().Trim(); //返回类型(字段类型:varchar,字段长度:500,是否可空:False)
 objvCMFunctionEN.IsKnownType = TransNullToBool(objDT.Rows[0][convCMFunction.IsKnownType].ToString().Trim()); //是否已知类型(字段类型:bit,字段长度:1,是否可空:True)
 objvCMFunctionEN.ReturnTypeId = objDT.Rows[0][convCMFunction.ReturnTypeId].ToString().Trim(); //返回类型ID(字段类型:char,字段长度:2,是否可空:True)
 objvCMFunctionEN.ClassNameLst = objDT.Rows[0][convCMFunction.ClassNameLst].ToString().Trim(); //类名列表(字段类型:varchar,字段长度:500,是否可空:True)
 objvCMFunctionEN.UpdDate = objDT.Rows[0][convCMFunction.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCMFunctionEN.UpdUser = objDT.Rows[0][convCMFunction.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvCMFunctionEN.Memo = objDT.Rows[0][convCMFunction.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCMFunctionEN.ParaNum = TransNullToInt(objDT.Rows[0][convCMFunction.ParaNum].ToString().Trim()); //参数个数(字段类型:int,字段长度:4,是否可空:True)
 objvCMFunctionEN.ClsName = objDT.Rows[0][convCMFunction.ClsName].ToString().Trim(); //类名(字段类型:varchar,字段长度:100,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvCMFunctionDA: GetvCMFunction)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCmFunctionId">表关键字</param>
 /// <returns>表对象</returns>
public clsvCMFunctionEN GetObjByCmFunctionId(string strCmFunctionId)
{
CheckPrimaryKey(strCmFunctionId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFunctionDA.GetSpecSQLObj();
strSQL = "Select * from vCMFunction where CmFunctionId = " + "'"+ strCmFunctionId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvCMFunctionEN objvCMFunctionEN = new clsvCMFunctionEN();
try
{
 objvCMFunctionEN.CmFunctionId = objRow[convCMFunction.CmFunctionId].ToString().Trim(); //函数Id(字段类型:char,字段长度:8,是否可空:False)
 objvCMFunctionEN.CmClassId = objRow[convCMFunction.CmClassId].ToString().Trim(); //类Id(字段类型:char,字段长度:8,是否可空:False)
 objvCMFunctionEN.ApplicationTypeId = objRow[convCMFunction.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMFunction.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objvCMFunctionEN.ProgLangTypeId = objRow[convCMFunction.ProgLangTypeId].ToString().Trim(); //编程语言类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvCMFunctionEN.ProgLangTypeName = objRow[convCMFunction.ProgLangTypeName].ToString().Trim(); //编程语言类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvCMFunctionEN.ProgLangTypeSimName = objRow[convCMFunction.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCMFunction.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvCMFunctionEN.NameSpace = objRow[convCMFunction.NameSpace] == DBNull.Value ? null : objRow[convCMFunction.NameSpace].ToString().Trim(); //域名(字段类型:varchar,字段长度:50,是否可空:True)
 objvCMFunctionEN.ProjectPath = objRow[convCMFunction.ProjectPath] == DBNull.Value ? null : objRow[convCMFunction.ProjectPath].ToString().Trim(); //工程路径(字段类型:varchar,字段长度:500,是否可空:False)
 objvCMFunctionEN.FilePath = objRow[convCMFunction.FilePath] == DBNull.Value ? null : objRow[convCMFunction.FilePath].ToString().Trim(); //文件路径(字段类型:varchar,字段长度:500,是否可空:False)
 objvCMFunctionEN.FileName = objRow[convCMFunction.FileName] == DBNull.Value ? null : objRow[convCMFunction.FileName].ToString().Trim(); //文件名(字段类型:varchar,字段长度:150,是否可空:False)
 objvCMFunctionEN.CodeTypeId = objRow[convCMFunction.CodeTypeId] == DBNull.Value ? null : objRow[convCMFunction.CodeTypeId].ToString().Trim(); //代码类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvCMFunctionEN.UserId = objRow[convCMFunction.UserId] == DBNull.Value ? null : objRow[convCMFunction.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objvCMFunctionEN.PrjId = objRow[convCMFunction.PrjId] == DBNull.Value ? null : objRow[convCMFunction.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvCMFunctionEN.PrjName = objRow[convCMFunction.PrjName] == DBNull.Value ? null : objRow[convCMFunction.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCMFunctionEN.FunctionName = objRow[convCMFunction.FunctionName] == DBNull.Value ? null : objRow[convCMFunction.FunctionName].ToString().Trim(); //功能名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvCMFunctionEN.FuncContent = objRow[convCMFunction.FuncContent] == DBNull.Value ? null : objRow[convCMFunction.FuncContent].ToString().Trim(); //函数内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvCMFunctionEN.KeyWords = objRow[convCMFunction.KeyWords] == DBNull.Value ? null : objRow[convCMFunction.KeyWords].ToString().Trim(); //关键字(字段类型:varchar,字段长度:500,是否可空:True)
 objvCMFunctionEN.FuncParaLst = objRow[convCMFunction.FuncParaLst] == DBNull.Value ? null : objRow[convCMFunction.FuncParaLst].ToString().Trim(); //函数参数列表(字段类型:varchar,字段长度:500,是否可空:True)
 objvCMFunctionEN.FuncComments = objRow[convCMFunction.FuncComments] == DBNull.Value ? null : objRow[convCMFunction.FuncComments].ToString().Trim(); //函数注释(字段类型:text,字段长度:5000,是否可空:True)
 objvCMFunctionEN.FunctionSignature = objRow[convCMFunction.FunctionSignature].ToString().Trim(); //函数签名(字段类型:varchar,字段长度:500,是否可空:False)
 objvCMFunctionEN.ReturnType = objRow[convCMFunction.ReturnType].ToString().Trim(); //返回类型(字段类型:varchar,字段长度:500,是否可空:False)
 objvCMFunctionEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[convCMFunction.IsKnownType].ToString().Trim()); //是否已知类型(字段类型:bit,字段长度:1,是否可空:True)
 objvCMFunctionEN.ReturnTypeId = objRow[convCMFunction.ReturnTypeId] == DBNull.Value ? null : objRow[convCMFunction.ReturnTypeId].ToString().Trim(); //返回类型ID(字段类型:char,字段长度:2,是否可空:True)
 objvCMFunctionEN.ClassNameLst = objRow[convCMFunction.ClassNameLst] == DBNull.Value ? null : objRow[convCMFunction.ClassNameLst].ToString().Trim(); //类名列表(字段类型:varchar,字段长度:500,是否可空:True)
 objvCMFunctionEN.UpdDate = objRow[convCMFunction.UpdDate] == DBNull.Value ? null : objRow[convCMFunction.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCMFunctionEN.UpdUser = objRow[convCMFunction.UpdUser] == DBNull.Value ? null : objRow[convCMFunction.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvCMFunctionEN.Memo = objRow[convCMFunction.Memo] == DBNull.Value ? null : objRow[convCMFunction.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCMFunctionEN.ParaNum = objRow[convCMFunction.ParaNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMFunction.ParaNum].ToString().Trim()); //参数个数(字段类型:int,字段长度:4,是否可空:True)
 objvCMFunctionEN.ClsName = objRow[convCMFunction.ClsName] == DBNull.Value ? null : objRow[convCMFunction.ClsName].ToString().Trim(); //类名(字段类型:varchar,字段长度:100,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvCMFunctionDA: GetObjByCmFunctionId)", objException.Message));
}
return objvCMFunctionEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvCMFunctionEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvCMFunctionDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFunctionDA.GetSpecSQLObj();
strSQL = "Select * from vCMFunction where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvCMFunctionEN objvCMFunctionEN = new clsvCMFunctionEN()
{
CmFunctionId = objRow[convCMFunction.CmFunctionId].ToString().Trim(), //函数Id
CmClassId = objRow[convCMFunction.CmClassId].ToString().Trim(), //类Id
ApplicationTypeId = objRow[convCMFunction.ApplicationTypeId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCMFunction.ApplicationTypeId].ToString().Trim()), //应用程序类型ID
ProgLangTypeId = objRow[convCMFunction.ProgLangTypeId].ToString().Trim(), //编程语言类型Id
ProgLangTypeName = objRow[convCMFunction.ProgLangTypeName].ToString().Trim(), //编程语言类型名
ProgLangTypeSimName = objRow[convCMFunction.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCMFunction.ProgLangTypeSimName].ToString().Trim(), //编程语言类型简称
NameSpace = objRow[convCMFunction.NameSpace] == DBNull.Value ? null : objRow[convCMFunction.NameSpace].ToString().Trim(), //域名
ProjectPath = objRow[convCMFunction.ProjectPath] == DBNull.Value ? null : objRow[convCMFunction.ProjectPath].ToString().Trim(), //工程路径
FilePath = objRow[convCMFunction.FilePath] == DBNull.Value ? null : objRow[convCMFunction.FilePath].ToString().Trim(), //文件路径
FileName = objRow[convCMFunction.FileName] == DBNull.Value ? null : objRow[convCMFunction.FileName].ToString().Trim(), //文件名
CodeTypeId = objRow[convCMFunction.CodeTypeId] == DBNull.Value ? null : objRow[convCMFunction.CodeTypeId].ToString().Trim(), //代码类型Id
UserId = objRow[convCMFunction.UserId] == DBNull.Value ? null : objRow[convCMFunction.UserId].ToString().Trim(), //用户Id
PrjId = objRow[convCMFunction.PrjId] == DBNull.Value ? null : objRow[convCMFunction.PrjId].ToString().Trim(), //工程Id
PrjName = objRow[convCMFunction.PrjName] == DBNull.Value ? null : objRow[convCMFunction.PrjName].ToString().Trim(), //工程名称
FunctionName = objRow[convCMFunction.FunctionName] == DBNull.Value ? null : objRow[convCMFunction.FunctionName].ToString().Trim(), //功能名称
FuncContent = objRow[convCMFunction.FuncContent] == DBNull.Value ? null : objRow[convCMFunction.FuncContent].ToString().Trim(), //函数内容
KeyWords = objRow[convCMFunction.KeyWords] == DBNull.Value ? null : objRow[convCMFunction.KeyWords].ToString().Trim(), //关键字
FuncParaLst = objRow[convCMFunction.FuncParaLst] == DBNull.Value ? null : objRow[convCMFunction.FuncParaLst].ToString().Trim(), //函数参数列表
FuncComments = objRow[convCMFunction.FuncComments] == DBNull.Value ? null : objRow[convCMFunction.FuncComments].ToString().Trim(), //函数注释
FunctionSignature = objRow[convCMFunction.FunctionSignature].ToString().Trim(), //函数签名
ReturnType = objRow[convCMFunction.ReturnType].ToString().Trim(), //返回类型
IsKnownType = TransNullToBool(objRow[convCMFunction.IsKnownType].ToString().Trim()), //是否已知类型
ReturnTypeId = objRow[convCMFunction.ReturnTypeId] == DBNull.Value ? null : objRow[convCMFunction.ReturnTypeId].ToString().Trim(), //返回类型ID
ClassNameLst = objRow[convCMFunction.ClassNameLst] == DBNull.Value ? null : objRow[convCMFunction.ClassNameLst].ToString().Trim(), //类名列表
UpdDate = objRow[convCMFunction.UpdDate] == DBNull.Value ? null : objRow[convCMFunction.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convCMFunction.UpdUser] == DBNull.Value ? null : objRow[convCMFunction.UpdUser].ToString().Trim(), //修改者
Memo = objRow[convCMFunction.Memo] == DBNull.Value ? null : objRow[convCMFunction.Memo].ToString().Trim(), //说明
ParaNum = objRow[convCMFunction.ParaNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCMFunction.ParaNum].ToString().Trim()), //参数个数
ClsName = objRow[convCMFunction.ClsName] == DBNull.Value ? null : objRow[convCMFunction.ClsName].ToString().Trim() //类名
};
objvCMFunctionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCMFunctionEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvCMFunctionDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvCMFunctionEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCMFunctionEN objvCMFunctionEN = new clsvCMFunctionEN();
try
{
objvCMFunctionEN.CmFunctionId = objRow[convCMFunction.CmFunctionId].ToString().Trim(); //函数Id
objvCMFunctionEN.CmClassId = objRow[convCMFunction.CmClassId].ToString().Trim(); //类Id
objvCMFunctionEN.ApplicationTypeId = objRow[convCMFunction.ApplicationTypeId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCMFunction.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMFunctionEN.ProgLangTypeId = objRow[convCMFunction.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCMFunctionEN.ProgLangTypeName = objRow[convCMFunction.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvCMFunctionEN.ProgLangTypeSimName = objRow[convCMFunction.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCMFunction.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvCMFunctionEN.NameSpace = objRow[convCMFunction.NameSpace] == DBNull.Value ? null : objRow[convCMFunction.NameSpace].ToString().Trim(); //域名
objvCMFunctionEN.ProjectPath = objRow[convCMFunction.ProjectPath] == DBNull.Value ? null : objRow[convCMFunction.ProjectPath].ToString().Trim(); //工程路径
objvCMFunctionEN.FilePath = objRow[convCMFunction.FilePath] == DBNull.Value ? null : objRow[convCMFunction.FilePath].ToString().Trim(); //文件路径
objvCMFunctionEN.FileName = objRow[convCMFunction.FileName] == DBNull.Value ? null : objRow[convCMFunction.FileName].ToString().Trim(); //文件名
objvCMFunctionEN.CodeTypeId = objRow[convCMFunction.CodeTypeId] == DBNull.Value ? null : objRow[convCMFunction.CodeTypeId].ToString().Trim(); //代码类型Id
objvCMFunctionEN.UserId = objRow[convCMFunction.UserId] == DBNull.Value ? null : objRow[convCMFunction.UserId].ToString().Trim(); //用户Id
objvCMFunctionEN.PrjId = objRow[convCMFunction.PrjId] == DBNull.Value ? null : objRow[convCMFunction.PrjId].ToString().Trim(); //工程Id
objvCMFunctionEN.PrjName = objRow[convCMFunction.PrjName] == DBNull.Value ? null : objRow[convCMFunction.PrjName].ToString().Trim(); //工程名称
objvCMFunctionEN.FunctionName = objRow[convCMFunction.FunctionName] == DBNull.Value ? null : objRow[convCMFunction.FunctionName].ToString().Trim(); //功能名称
objvCMFunctionEN.FuncContent = objRow[convCMFunction.FuncContent] == DBNull.Value ? null : objRow[convCMFunction.FuncContent].ToString().Trim(); //函数内容
objvCMFunctionEN.KeyWords = objRow[convCMFunction.KeyWords] == DBNull.Value ? null : objRow[convCMFunction.KeyWords].ToString().Trim(); //关键字
objvCMFunctionEN.FuncParaLst = objRow[convCMFunction.FuncParaLst] == DBNull.Value ? null : objRow[convCMFunction.FuncParaLst].ToString().Trim(); //函数参数列表
objvCMFunctionEN.FuncComments = objRow[convCMFunction.FuncComments] == DBNull.Value ? null : objRow[convCMFunction.FuncComments].ToString().Trim(); //函数注释
objvCMFunctionEN.FunctionSignature = objRow[convCMFunction.FunctionSignature].ToString().Trim(); //函数签名
objvCMFunctionEN.ReturnType = objRow[convCMFunction.ReturnType].ToString().Trim(); //返回类型
objvCMFunctionEN.IsKnownType = TransNullToBool(objRow[convCMFunction.IsKnownType].ToString().Trim()); //是否已知类型
objvCMFunctionEN.ReturnTypeId = objRow[convCMFunction.ReturnTypeId] == DBNull.Value ? null : objRow[convCMFunction.ReturnTypeId].ToString().Trim(); //返回类型ID
objvCMFunctionEN.ClassNameLst = objRow[convCMFunction.ClassNameLst] == DBNull.Value ? null : objRow[convCMFunction.ClassNameLst].ToString().Trim(); //类名列表
objvCMFunctionEN.UpdDate = objRow[convCMFunction.UpdDate] == DBNull.Value ? null : objRow[convCMFunction.UpdDate].ToString().Trim(); //修改日期
objvCMFunctionEN.UpdUser = objRow[convCMFunction.UpdUser] == DBNull.Value ? null : objRow[convCMFunction.UpdUser].ToString().Trim(); //修改者
objvCMFunctionEN.Memo = objRow[convCMFunction.Memo] == DBNull.Value ? null : objRow[convCMFunction.Memo].ToString().Trim(); //说明
objvCMFunctionEN.ParaNum = objRow[convCMFunction.ParaNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCMFunction.ParaNum].ToString().Trim()); //参数个数
objvCMFunctionEN.ClsName = objRow[convCMFunction.ClsName] == DBNull.Value ? null : objRow[convCMFunction.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvCMFunctionDA: GetObjByDataRowvCMFunction)", objException.Message));
}
objvCMFunctionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCMFunctionEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvCMFunctionEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCMFunctionEN objvCMFunctionEN = new clsvCMFunctionEN();
try
{
objvCMFunctionEN.CmFunctionId = objRow[convCMFunction.CmFunctionId].ToString().Trim(); //函数Id
objvCMFunctionEN.CmClassId = objRow[convCMFunction.CmClassId].ToString().Trim(); //类Id
objvCMFunctionEN.ApplicationTypeId = objRow[convCMFunction.ApplicationTypeId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCMFunction.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMFunctionEN.ProgLangTypeId = objRow[convCMFunction.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCMFunctionEN.ProgLangTypeName = objRow[convCMFunction.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvCMFunctionEN.ProgLangTypeSimName = objRow[convCMFunction.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCMFunction.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvCMFunctionEN.NameSpace = objRow[convCMFunction.NameSpace] == DBNull.Value ? null : objRow[convCMFunction.NameSpace].ToString().Trim(); //域名
objvCMFunctionEN.ProjectPath = objRow[convCMFunction.ProjectPath] == DBNull.Value ? null : objRow[convCMFunction.ProjectPath].ToString().Trim(); //工程路径
objvCMFunctionEN.FilePath = objRow[convCMFunction.FilePath] == DBNull.Value ? null : objRow[convCMFunction.FilePath].ToString().Trim(); //文件路径
objvCMFunctionEN.FileName = objRow[convCMFunction.FileName] == DBNull.Value ? null : objRow[convCMFunction.FileName].ToString().Trim(); //文件名
objvCMFunctionEN.CodeTypeId = objRow[convCMFunction.CodeTypeId] == DBNull.Value ? null : objRow[convCMFunction.CodeTypeId].ToString().Trim(); //代码类型Id
objvCMFunctionEN.UserId = objRow[convCMFunction.UserId] == DBNull.Value ? null : objRow[convCMFunction.UserId].ToString().Trim(); //用户Id
objvCMFunctionEN.PrjId = objRow[convCMFunction.PrjId] == DBNull.Value ? null : objRow[convCMFunction.PrjId].ToString().Trim(); //工程Id
objvCMFunctionEN.PrjName = objRow[convCMFunction.PrjName] == DBNull.Value ? null : objRow[convCMFunction.PrjName].ToString().Trim(); //工程名称
objvCMFunctionEN.FunctionName = objRow[convCMFunction.FunctionName] == DBNull.Value ? null : objRow[convCMFunction.FunctionName].ToString().Trim(); //功能名称
objvCMFunctionEN.FuncContent = objRow[convCMFunction.FuncContent] == DBNull.Value ? null : objRow[convCMFunction.FuncContent].ToString().Trim(); //函数内容
objvCMFunctionEN.KeyWords = objRow[convCMFunction.KeyWords] == DBNull.Value ? null : objRow[convCMFunction.KeyWords].ToString().Trim(); //关键字
objvCMFunctionEN.FuncParaLst = objRow[convCMFunction.FuncParaLst] == DBNull.Value ? null : objRow[convCMFunction.FuncParaLst].ToString().Trim(); //函数参数列表
objvCMFunctionEN.FuncComments = objRow[convCMFunction.FuncComments] == DBNull.Value ? null : objRow[convCMFunction.FuncComments].ToString().Trim(); //函数注释
objvCMFunctionEN.FunctionSignature = objRow[convCMFunction.FunctionSignature].ToString().Trim(); //函数签名
objvCMFunctionEN.ReturnType = objRow[convCMFunction.ReturnType].ToString().Trim(); //返回类型
objvCMFunctionEN.IsKnownType = TransNullToBool(objRow[convCMFunction.IsKnownType].ToString().Trim()); //是否已知类型
objvCMFunctionEN.ReturnTypeId = objRow[convCMFunction.ReturnTypeId] == DBNull.Value ? null : objRow[convCMFunction.ReturnTypeId].ToString().Trim(); //返回类型ID
objvCMFunctionEN.ClassNameLst = objRow[convCMFunction.ClassNameLst] == DBNull.Value ? null : objRow[convCMFunction.ClassNameLst].ToString().Trim(); //类名列表
objvCMFunctionEN.UpdDate = objRow[convCMFunction.UpdDate] == DBNull.Value ? null : objRow[convCMFunction.UpdDate].ToString().Trim(); //修改日期
objvCMFunctionEN.UpdUser = objRow[convCMFunction.UpdUser] == DBNull.Value ? null : objRow[convCMFunction.UpdUser].ToString().Trim(); //修改者
objvCMFunctionEN.Memo = objRow[convCMFunction.Memo] == DBNull.Value ? null : objRow[convCMFunction.Memo].ToString().Trim(); //说明
objvCMFunctionEN.ParaNum = objRow[convCMFunction.ParaNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCMFunction.ParaNum].ToString().Trim()); //参数个数
objvCMFunctionEN.ClsName = objRow[convCMFunction.ClsName] == DBNull.Value ? null : objRow[convCMFunction.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvCMFunctionDA: GetObjByDataRow)", objException.Message));
}
objvCMFunctionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCMFunctionEN;
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
objSQL = clsvCMFunctionDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCMFunctionEN._CurrTabName, convCMFunction.CmFunctionId, 8, "");
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
objSQL = clsvCMFunctionDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCMFunctionEN._CurrTabName, convCMFunction.CmFunctionId, 8, strPrefix);
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
 objSQL = clsvCMFunctionDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select CmFunctionId from vCMFunction where " + strCondition;
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
 objSQL = clsvCMFunctionDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select CmFunctionId from vCMFunction where " + strCondition;
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
 /// <param name = "strCmFunctionId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strCmFunctionId)
{
CheckPrimaryKey(strCmFunctionId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFunctionDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCMFunction", "CmFunctionId = " + "'"+ strCmFunctionId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvCMFunctionDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFunctionDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCMFunction", strCondition))
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
objSQL = clsvCMFunctionDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vCMFunction");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvCMFunctionENS">源对象</param>
 /// <param name = "objvCMFunctionENT">目标对象</param>
public void CopyTo(clsvCMFunctionEN objvCMFunctionENS, clsvCMFunctionEN objvCMFunctionENT)
{
objvCMFunctionENT.CmFunctionId = objvCMFunctionENS.CmFunctionId; //函数Id
objvCMFunctionENT.CmClassId = objvCMFunctionENS.CmClassId; //类Id
objvCMFunctionENT.ApplicationTypeId = objvCMFunctionENS.ApplicationTypeId; //应用程序类型ID
objvCMFunctionENT.ProgLangTypeId = objvCMFunctionENS.ProgLangTypeId; //编程语言类型Id
objvCMFunctionENT.ProgLangTypeName = objvCMFunctionENS.ProgLangTypeName; //编程语言类型名
objvCMFunctionENT.ProgLangTypeSimName = objvCMFunctionENS.ProgLangTypeSimName; //编程语言类型简称
objvCMFunctionENT.NameSpace = objvCMFunctionENS.NameSpace; //域名
objvCMFunctionENT.ProjectPath = objvCMFunctionENS.ProjectPath; //工程路径
objvCMFunctionENT.FilePath = objvCMFunctionENS.FilePath; //文件路径
objvCMFunctionENT.FileName = objvCMFunctionENS.FileName; //文件名
objvCMFunctionENT.CodeTypeId = objvCMFunctionENS.CodeTypeId; //代码类型Id
objvCMFunctionENT.UserId = objvCMFunctionENS.UserId; //用户Id
objvCMFunctionENT.PrjId = objvCMFunctionENS.PrjId; //工程Id
objvCMFunctionENT.PrjName = objvCMFunctionENS.PrjName; //工程名称
objvCMFunctionENT.FunctionName = objvCMFunctionENS.FunctionName; //功能名称
objvCMFunctionENT.FuncContent = objvCMFunctionENS.FuncContent; //函数内容
objvCMFunctionENT.KeyWords = objvCMFunctionENS.KeyWords; //关键字
objvCMFunctionENT.FuncParaLst = objvCMFunctionENS.FuncParaLst; //函数参数列表
objvCMFunctionENT.FuncComments = objvCMFunctionENS.FuncComments; //函数注释
objvCMFunctionENT.FunctionSignature = objvCMFunctionENS.FunctionSignature; //函数签名
objvCMFunctionENT.ReturnType = objvCMFunctionENS.ReturnType; //返回类型
objvCMFunctionENT.IsKnownType = objvCMFunctionENS.IsKnownType; //是否已知类型
objvCMFunctionENT.ReturnTypeId = objvCMFunctionENS.ReturnTypeId; //返回类型ID
objvCMFunctionENT.ClassNameLst = objvCMFunctionENS.ClassNameLst; //类名列表
objvCMFunctionENT.UpdDate = objvCMFunctionENS.UpdDate; //修改日期
objvCMFunctionENT.UpdUser = objvCMFunctionENS.UpdUser; //修改者
objvCMFunctionENT.Memo = objvCMFunctionENS.Memo; //说明
objvCMFunctionENT.ParaNum = objvCMFunctionENS.ParaNum; //参数个数
objvCMFunctionENT.ClsName = objvCMFunctionENS.ClsName; //类名
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvCMFunctionEN objvCMFunctionEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvCMFunctionEN.CmFunctionId, 8, convCMFunction.CmFunctionId);
clsCheckSql.CheckFieldLen(objvCMFunctionEN.CmClassId, 8, convCMFunction.CmClassId);
clsCheckSql.CheckFieldLen(objvCMFunctionEN.ProgLangTypeId, 2, convCMFunction.ProgLangTypeId);
clsCheckSql.CheckFieldLen(objvCMFunctionEN.ProgLangTypeName, 30, convCMFunction.ProgLangTypeName);
clsCheckSql.CheckFieldLen(objvCMFunctionEN.ProgLangTypeSimName, 30, convCMFunction.ProgLangTypeSimName);
clsCheckSql.CheckFieldLen(objvCMFunctionEN.NameSpace, 50, convCMFunction.NameSpace);
clsCheckSql.CheckFieldLen(objvCMFunctionEN.ProjectPath, 500, convCMFunction.ProjectPath);
clsCheckSql.CheckFieldLen(objvCMFunctionEN.FilePath, 500, convCMFunction.FilePath);
clsCheckSql.CheckFieldLen(objvCMFunctionEN.FileName, 150, convCMFunction.FileName);
clsCheckSql.CheckFieldLen(objvCMFunctionEN.CodeTypeId, 4, convCMFunction.CodeTypeId);
clsCheckSql.CheckFieldLen(objvCMFunctionEN.UserId, 18, convCMFunction.UserId);
clsCheckSql.CheckFieldLen(objvCMFunctionEN.PrjId, 4, convCMFunction.PrjId);
clsCheckSql.CheckFieldLen(objvCMFunctionEN.PrjName, 30, convCMFunction.PrjName);
clsCheckSql.CheckFieldLen(objvCMFunctionEN.FunctionName, 200, convCMFunction.FunctionName);
clsCheckSql.CheckFieldLen(objvCMFunctionEN.KeyWords, 500, convCMFunction.KeyWords);
clsCheckSql.CheckFieldLen(objvCMFunctionEN.FuncParaLst, 500, convCMFunction.FuncParaLst);
clsCheckSql.CheckFieldLen(objvCMFunctionEN.FunctionSignature, 500, convCMFunction.FunctionSignature);
clsCheckSql.CheckFieldLen(objvCMFunctionEN.ReturnType, 500, convCMFunction.ReturnType);
clsCheckSql.CheckFieldLen(objvCMFunctionEN.ReturnTypeId, 2, convCMFunction.ReturnTypeId);
clsCheckSql.CheckFieldLen(objvCMFunctionEN.ClassNameLst, 500, convCMFunction.ClassNameLst);
clsCheckSql.CheckFieldLen(objvCMFunctionEN.UpdDate, 20, convCMFunction.UpdDate);
clsCheckSql.CheckFieldLen(objvCMFunctionEN.UpdUser, 20, convCMFunction.UpdUser);
clsCheckSql.CheckFieldLen(objvCMFunctionEN.Memo, 1000, convCMFunction.Memo);
clsCheckSql.CheckFieldLen(objvCMFunctionEN.ClsName, 100, convCMFunction.ClsName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvCMFunctionEN.CmFunctionId, convCMFunction.CmFunctionId);
clsCheckSql.CheckSqlInjection4Field(objvCMFunctionEN.CmClassId, convCMFunction.CmClassId);
clsCheckSql.CheckSqlInjection4Field(objvCMFunctionEN.ProgLangTypeId, convCMFunction.ProgLangTypeId);
clsCheckSql.CheckSqlInjection4Field(objvCMFunctionEN.ProgLangTypeName, convCMFunction.ProgLangTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCMFunctionEN.ProgLangTypeSimName, convCMFunction.ProgLangTypeSimName);
clsCheckSql.CheckSqlInjection4Field(objvCMFunctionEN.NameSpace, convCMFunction.NameSpace);
clsCheckSql.CheckSqlInjection4Field(objvCMFunctionEN.ProjectPath, convCMFunction.ProjectPath);
clsCheckSql.CheckSqlInjection4Field(objvCMFunctionEN.FilePath, convCMFunction.FilePath);
clsCheckSql.CheckSqlInjection4Field(objvCMFunctionEN.FileName, convCMFunction.FileName);
clsCheckSql.CheckSqlInjection4Field(objvCMFunctionEN.CodeTypeId, convCMFunction.CodeTypeId);
clsCheckSql.CheckSqlInjection4Field(objvCMFunctionEN.UserId, convCMFunction.UserId);
clsCheckSql.CheckSqlInjection4Field(objvCMFunctionEN.PrjId, convCMFunction.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvCMFunctionEN.PrjName, convCMFunction.PrjName);
clsCheckSql.CheckSqlInjection4Field(objvCMFunctionEN.FunctionName, convCMFunction.FunctionName);
clsCheckSql.CheckSqlInjection4Field(objvCMFunctionEN.KeyWords, convCMFunction.KeyWords);
clsCheckSql.CheckSqlInjection4Field(objvCMFunctionEN.FuncParaLst, convCMFunction.FuncParaLst);
clsCheckSql.CheckSqlInjection4Field(objvCMFunctionEN.FunctionSignature, convCMFunction.FunctionSignature);
clsCheckSql.CheckSqlInjection4Field(objvCMFunctionEN.ReturnType, convCMFunction.ReturnType);
clsCheckSql.CheckSqlInjection4Field(objvCMFunctionEN.ReturnTypeId, convCMFunction.ReturnTypeId);
clsCheckSql.CheckSqlInjection4Field(objvCMFunctionEN.ClassNameLst, convCMFunction.ClassNameLst);
clsCheckSql.CheckSqlInjection4Field(objvCMFunctionEN.UpdDate, convCMFunction.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvCMFunctionEN.UpdUser, convCMFunction.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvCMFunctionEN.Memo, convCMFunction.Memo);
clsCheckSql.CheckSqlInjection4Field(objvCMFunctionEN.ClsName, convCMFunction.ClsName);
//检查外键字段长度
 objvCMFunctionEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetCmFunctionId()
{
//获取某学院所有专业信息
string strSQL = "select CmFunctionId, UserId from vCMFunction ";
 clsSpecSQLforSql mySql = clsvCMFunctionDA.GetSpecSQLObj();
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
 objSQL = clsvCMFunctionDA.GetSpecSQLObj();
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
 objSQL = clsvCMFunctionDA.GetSpecSQLObj();
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
 objSQL = clsvCMFunctionDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCMFunctionEN._CurrTabName);
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
 objSQL = clsvCMFunctionDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCMFunctionEN._CurrTabName, strCondition);
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
 objSQL = clsvCMFunctionDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}