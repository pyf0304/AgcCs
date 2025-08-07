
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCMFuncParaRelaDA
 表名:vCMFuncParaRela(00050509)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:36:37
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
 /// vCM函数参数关系(vCMFuncParaRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvCMFuncParaRelaDA : clsCommBase4DA
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
 return clsvCMFuncParaRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvCMFuncParaRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCMFuncParaRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvCMFuncParaRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvCMFuncParaRelaEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvCMFuncParaRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFuncParaRelaDA.GetSpecSQLObj();
strSQL = "Select * from vCMFuncParaRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vCMFuncParaRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvCMFuncParaRelaDA: GetDataTable_vCMFuncParaRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFuncParaRelaDA.GetSpecSQLObj();
strSQL = "Select * from vCMFuncParaRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvCMFuncParaRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFuncParaRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvCMFuncParaRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFuncParaRelaDA.GetSpecSQLObj();
strSQL = "Select * from vCMFuncParaRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvCMFuncParaRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFuncParaRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvCMFuncParaRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFuncParaRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCMFuncParaRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCMFuncParaRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvCMFuncParaRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFuncParaRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vCMFuncParaRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvCMFuncParaRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFuncParaRelaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vCMFuncParaRela.* " + 
$"from vCMFuncParaRela " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vCMFuncParaRela.mId not in " + 
$"(Select top {intTop_In} vCMFuncParaRela.mId from vCMFuncParaRela " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCMFuncParaRela where {1} and mId not in (Select top {2} mId from vCMFuncParaRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCMFuncParaRela where {1} and mId not in (Select top {3} mId from vCMFuncParaRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvCMFuncParaRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFuncParaRelaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vCMFuncParaRela.* " + 
$"from vCMFuncParaRela " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vCMFuncParaRela.mId not in " + 
$"(Select top {intTop_In} vCMFuncParaRela.mId from vCMFuncParaRela " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCMFuncParaRela where {1} and mId not in (Select top {2} mId from vCMFuncParaRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCMFuncParaRela where {1} and mId not in (Select top {3} mId from vCMFuncParaRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvCMFuncParaRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvCMFuncParaRelaDA:GetObjLst)", objException.Message));
}
List<clsvCMFuncParaRelaEN> arrObjLst = new List<clsvCMFuncParaRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFuncParaRelaDA.GetSpecSQLObj();
strSQL = "Select * from vCMFuncParaRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFuncParaRelaEN objvCMFuncParaRelaEN = new clsvCMFuncParaRelaEN();
try
{
objvCMFuncParaRelaEN.mId = TransNullToInt(objRow[convCMFuncParaRela.mId].ToString().Trim()); //mId
objvCMFuncParaRelaEN.CmFuncParaId = objRow[convCMFuncParaRela.CmFuncParaId].ToString().Trim(); //函数参数Id
objvCMFuncParaRelaEN.ParaName = objRow[convCMFuncParaRela.ParaName].ToString().Trim(); //参数名
objvCMFuncParaRelaEN.ParaComments = objRow[convCMFuncParaRela.ParaComments] == DBNull.Value ? null : objRow[convCMFuncParaRela.ParaComments].ToString().Trim(); //参数注释
objvCMFuncParaRelaEN.ParameterType = objRow[convCMFuncParaRela.ParameterType] == DBNull.Value ? null : objRow[convCMFuncParaRela.ParameterType].ToString().Trim(); //参数类型
objvCMFuncParaRelaEN.DataTypeId = objRow[convCMFuncParaRela.DataTypeId].ToString().Trim(); //数据类型Id
objvCMFuncParaRelaEN.DataTypeName = objRow[convCMFuncParaRela.DataTypeName] == DBNull.Value ? null : objRow[convCMFuncParaRela.DataTypeName].ToString().Trim(); //数据类型名称
objvCMFuncParaRelaEN.CsType = objRow[convCMFuncParaRela.CsType] == DBNull.Value ? null : objRow[convCMFuncParaRela.CsType].ToString().Trim(); //CS类型
objvCMFuncParaRelaEN.JavaType = objRow[convCMFuncParaRela.JavaType] == DBNull.Value ? null : objRow[convCMFuncParaRela.JavaType].ToString().Trim(); //JAVA类型
objvCMFuncParaRelaEN.IsNeedQuote = TransNullToBool(objRow[convCMFuncParaRela.IsNeedQuote].ToString().Trim()); //是否需要引号
objvCMFuncParaRelaEN.ParameterTypeFullName = objRow[convCMFuncParaRela.ParameterTypeFullName] == DBNull.Value ? null : objRow[convCMFuncParaRela.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvCMFuncParaRelaEN.IsByRef = TransNullToBool(objRow[convCMFuncParaRela.IsByRef].ToString().Trim()); //是否引用型参数
objvCMFuncParaRelaEN.ParaCnName = objRow[convCMFuncParaRela.ParaCnName].ToString().Trim(); //参数中文名
objvCMFuncParaRelaEN.CmFunctionId = objRow[convCMFuncParaRela.CmFunctionId].ToString().Trim(); //函数Id
objvCMFuncParaRelaEN.FunctionName = objRow[convCMFuncParaRela.FunctionName] == DBNull.Value ? null : objRow[convCMFuncParaRela.FunctionName].ToString().Trim(); //功能名称
objvCMFuncParaRelaEN.FunctionSignature = objRow[convCMFuncParaRela.FunctionSignature].ToString().Trim(); //函数签名
objvCMFuncParaRelaEN.OrderNum = TransNullToInt(objRow[convCMFuncParaRela.OrderNum].ToString().Trim()); //序号
objvCMFuncParaRelaEN.PrjId = objRow[convCMFuncParaRela.PrjId].ToString().Trim(); //工程Id
objvCMFuncParaRelaEN.UpdDate = objRow[convCMFuncParaRela.UpdDate] == DBNull.Value ? null : objRow[convCMFuncParaRela.UpdDate].ToString().Trim(); //修改日期
objvCMFuncParaRelaEN.UpdUser = objRow[convCMFuncParaRela.UpdUser] == DBNull.Value ? null : objRow[convCMFuncParaRela.UpdUser].ToString().Trim(); //修改者
objvCMFuncParaRelaEN.Memo = objRow[convCMFuncParaRela.Memo] == DBNull.Value ? null : objRow[convCMFuncParaRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCMFuncParaRelaDA: GetObjLst)", objException.Message));
}
objvCMFuncParaRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCMFuncParaRelaEN);
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
public List<clsvCMFuncParaRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvCMFuncParaRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsvCMFuncParaRelaEN> arrObjLst = new List<clsvCMFuncParaRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFuncParaRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFuncParaRelaEN objvCMFuncParaRelaEN = new clsvCMFuncParaRelaEN();
try
{
objvCMFuncParaRelaEN.mId = TransNullToInt(objRow[convCMFuncParaRela.mId].ToString().Trim()); //mId
objvCMFuncParaRelaEN.CmFuncParaId = objRow[convCMFuncParaRela.CmFuncParaId].ToString().Trim(); //函数参数Id
objvCMFuncParaRelaEN.ParaName = objRow[convCMFuncParaRela.ParaName].ToString().Trim(); //参数名
objvCMFuncParaRelaEN.ParaComments = objRow[convCMFuncParaRela.ParaComments] == DBNull.Value ? null : objRow[convCMFuncParaRela.ParaComments].ToString().Trim(); //参数注释
objvCMFuncParaRelaEN.ParameterType = objRow[convCMFuncParaRela.ParameterType] == DBNull.Value ? null : objRow[convCMFuncParaRela.ParameterType].ToString().Trim(); //参数类型
objvCMFuncParaRelaEN.DataTypeId = objRow[convCMFuncParaRela.DataTypeId].ToString().Trim(); //数据类型Id
objvCMFuncParaRelaEN.DataTypeName = objRow[convCMFuncParaRela.DataTypeName] == DBNull.Value ? null : objRow[convCMFuncParaRela.DataTypeName].ToString().Trim(); //数据类型名称
objvCMFuncParaRelaEN.CsType = objRow[convCMFuncParaRela.CsType] == DBNull.Value ? null : objRow[convCMFuncParaRela.CsType].ToString().Trim(); //CS类型
objvCMFuncParaRelaEN.JavaType = objRow[convCMFuncParaRela.JavaType] == DBNull.Value ? null : objRow[convCMFuncParaRela.JavaType].ToString().Trim(); //JAVA类型
objvCMFuncParaRelaEN.IsNeedQuote = TransNullToBool(objRow[convCMFuncParaRela.IsNeedQuote].ToString().Trim()); //是否需要引号
objvCMFuncParaRelaEN.ParameterTypeFullName = objRow[convCMFuncParaRela.ParameterTypeFullName] == DBNull.Value ? null : objRow[convCMFuncParaRela.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvCMFuncParaRelaEN.IsByRef = TransNullToBool(objRow[convCMFuncParaRela.IsByRef].ToString().Trim()); //是否引用型参数
objvCMFuncParaRelaEN.ParaCnName = objRow[convCMFuncParaRela.ParaCnName].ToString().Trim(); //参数中文名
objvCMFuncParaRelaEN.CmFunctionId = objRow[convCMFuncParaRela.CmFunctionId].ToString().Trim(); //函数Id
objvCMFuncParaRelaEN.FunctionName = objRow[convCMFuncParaRela.FunctionName] == DBNull.Value ? null : objRow[convCMFuncParaRela.FunctionName].ToString().Trim(); //功能名称
objvCMFuncParaRelaEN.FunctionSignature = objRow[convCMFuncParaRela.FunctionSignature].ToString().Trim(); //函数签名
objvCMFuncParaRelaEN.OrderNum = TransNullToInt(objRow[convCMFuncParaRela.OrderNum].ToString().Trim()); //序号
objvCMFuncParaRelaEN.PrjId = objRow[convCMFuncParaRela.PrjId].ToString().Trim(); //工程Id
objvCMFuncParaRelaEN.UpdDate = objRow[convCMFuncParaRela.UpdDate] == DBNull.Value ? null : objRow[convCMFuncParaRela.UpdDate].ToString().Trim(); //修改日期
objvCMFuncParaRelaEN.UpdUser = objRow[convCMFuncParaRela.UpdUser] == DBNull.Value ? null : objRow[convCMFuncParaRela.UpdUser].ToString().Trim(); //修改者
objvCMFuncParaRelaEN.Memo = objRow[convCMFuncParaRela.Memo] == DBNull.Value ? null : objRow[convCMFuncParaRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCMFuncParaRelaDA: GetObjLst)", objException.Message));
}
objvCMFuncParaRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCMFuncParaRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvCMFuncParaRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvCMFuncParaRela(ref clsvCMFuncParaRelaEN objvCMFuncParaRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFuncParaRelaDA.GetSpecSQLObj();
strSQL = "Select * from vCMFuncParaRela where mId = " + ""+ objvCMFuncParaRelaEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvCMFuncParaRelaEN.mId = TransNullToInt(objDT.Rows[0][convCMFuncParaRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvCMFuncParaRelaEN.CmFuncParaId = objDT.Rows[0][convCMFuncParaRela.CmFuncParaId].ToString().Trim(); //函数参数Id(字段类型:char,字段长度:8,是否可空:False)
 objvCMFuncParaRelaEN.ParaName = objDT.Rows[0][convCMFuncParaRela.ParaName].ToString().Trim(); //参数名(字段类型:varchar,字段长度:50,是否可空:False)
 objvCMFuncParaRelaEN.ParaComments = objDT.Rows[0][convCMFuncParaRela.ParaComments].ToString().Trim(); //参数注释(字段类型:varchar,字段长度:500,是否可空:True)
 objvCMFuncParaRelaEN.ParameterType = objDT.Rows[0][convCMFuncParaRela.ParameterType].ToString().Trim(); //参数类型(字段类型:varchar,字段长度:100,是否可空:True)
 objvCMFuncParaRelaEN.DataTypeId = objDT.Rows[0][convCMFuncParaRela.DataTypeId].ToString().Trim(); //数据类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvCMFuncParaRelaEN.DataTypeName = objDT.Rows[0][convCMFuncParaRela.DataTypeName].ToString().Trim(); //数据类型名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCMFuncParaRelaEN.CsType = objDT.Rows[0][convCMFuncParaRela.CsType].ToString().Trim(); //CS类型(字段类型:varchar,字段长度:100,是否可空:False)
 objvCMFuncParaRelaEN.JavaType = objDT.Rows[0][convCMFuncParaRela.JavaType].ToString().Trim(); //JAVA类型(字段类型:varchar,字段长度:100,是否可空:False)
 objvCMFuncParaRelaEN.IsNeedQuote = TransNullToBool(objDT.Rows[0][convCMFuncParaRela.IsNeedQuote].ToString().Trim()); //是否需要引号(字段类型:bit,字段长度:1,是否可空:False)
 objvCMFuncParaRelaEN.ParameterTypeFullName = objDT.Rows[0][convCMFuncParaRela.ParameterTypeFullName].ToString().Trim(); //参数类型全名(字段类型:varchar,字段长度:500,是否可空:True)
 objvCMFuncParaRelaEN.IsByRef = TransNullToBool(objDT.Rows[0][convCMFuncParaRela.IsByRef].ToString().Trim()); //是否引用型参数(字段类型:bit,字段长度:1,是否可空:True)
 objvCMFuncParaRelaEN.ParaCnName = objDT.Rows[0][convCMFuncParaRela.ParaCnName].ToString().Trim(); //参数中文名(字段类型:varchar,字段长度:50,是否可空:False)
 objvCMFuncParaRelaEN.CmFunctionId = objDT.Rows[0][convCMFuncParaRela.CmFunctionId].ToString().Trim(); //函数Id(字段类型:char,字段长度:8,是否可空:False)
 objvCMFuncParaRelaEN.FunctionName = objDT.Rows[0][convCMFuncParaRela.FunctionName].ToString().Trim(); //功能名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvCMFuncParaRelaEN.FunctionSignature = objDT.Rows[0][convCMFuncParaRela.FunctionSignature].ToString().Trim(); //函数签名(字段类型:varchar,字段长度:500,是否可空:False)
 objvCMFuncParaRelaEN.OrderNum = TransNullToInt(objDT.Rows[0][convCMFuncParaRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvCMFuncParaRelaEN.PrjId = objDT.Rows[0][convCMFuncParaRela.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvCMFuncParaRelaEN.UpdDate = objDT.Rows[0][convCMFuncParaRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCMFuncParaRelaEN.UpdUser = objDT.Rows[0][convCMFuncParaRela.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvCMFuncParaRelaEN.Memo = objDT.Rows[0][convCMFuncParaRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvCMFuncParaRelaDA: GetvCMFuncParaRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvCMFuncParaRelaEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFuncParaRelaDA.GetSpecSQLObj();
strSQL = "Select * from vCMFuncParaRela where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvCMFuncParaRelaEN objvCMFuncParaRelaEN = new clsvCMFuncParaRelaEN();
try
{
 objvCMFuncParaRelaEN.mId = Int32.Parse(objRow[convCMFuncParaRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvCMFuncParaRelaEN.CmFuncParaId = objRow[convCMFuncParaRela.CmFuncParaId].ToString().Trim(); //函数参数Id(字段类型:char,字段长度:8,是否可空:False)
 objvCMFuncParaRelaEN.ParaName = objRow[convCMFuncParaRela.ParaName].ToString().Trim(); //参数名(字段类型:varchar,字段长度:50,是否可空:False)
 objvCMFuncParaRelaEN.ParaComments = objRow[convCMFuncParaRela.ParaComments] == DBNull.Value ? null : objRow[convCMFuncParaRela.ParaComments].ToString().Trim(); //参数注释(字段类型:varchar,字段长度:500,是否可空:True)
 objvCMFuncParaRelaEN.ParameterType = objRow[convCMFuncParaRela.ParameterType] == DBNull.Value ? null : objRow[convCMFuncParaRela.ParameterType].ToString().Trim(); //参数类型(字段类型:varchar,字段长度:100,是否可空:True)
 objvCMFuncParaRelaEN.DataTypeId = objRow[convCMFuncParaRela.DataTypeId].ToString().Trim(); //数据类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvCMFuncParaRelaEN.DataTypeName = objRow[convCMFuncParaRela.DataTypeName] == DBNull.Value ? null : objRow[convCMFuncParaRela.DataTypeName].ToString().Trim(); //数据类型名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCMFuncParaRelaEN.CsType = objRow[convCMFuncParaRela.CsType] == DBNull.Value ? null : objRow[convCMFuncParaRela.CsType].ToString().Trim(); //CS类型(字段类型:varchar,字段长度:100,是否可空:False)
 objvCMFuncParaRelaEN.JavaType = objRow[convCMFuncParaRela.JavaType] == DBNull.Value ? null : objRow[convCMFuncParaRela.JavaType].ToString().Trim(); //JAVA类型(字段类型:varchar,字段长度:100,是否可空:False)
 objvCMFuncParaRelaEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convCMFuncParaRela.IsNeedQuote].ToString().Trim()); //是否需要引号(字段类型:bit,字段长度:1,是否可空:False)
 objvCMFuncParaRelaEN.ParameterTypeFullName = objRow[convCMFuncParaRela.ParameterTypeFullName] == DBNull.Value ? null : objRow[convCMFuncParaRela.ParameterTypeFullName].ToString().Trim(); //参数类型全名(字段类型:varchar,字段长度:500,是否可空:True)
 objvCMFuncParaRelaEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[convCMFuncParaRela.IsByRef].ToString().Trim()); //是否引用型参数(字段类型:bit,字段长度:1,是否可空:True)
 objvCMFuncParaRelaEN.ParaCnName = objRow[convCMFuncParaRela.ParaCnName].ToString().Trim(); //参数中文名(字段类型:varchar,字段长度:50,是否可空:False)
 objvCMFuncParaRelaEN.CmFunctionId = objRow[convCMFuncParaRela.CmFunctionId].ToString().Trim(); //函数Id(字段类型:char,字段长度:8,是否可空:False)
 objvCMFuncParaRelaEN.FunctionName = objRow[convCMFuncParaRela.FunctionName] == DBNull.Value ? null : objRow[convCMFuncParaRela.FunctionName].ToString().Trim(); //功能名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvCMFuncParaRelaEN.FunctionSignature = objRow[convCMFuncParaRela.FunctionSignature].ToString().Trim(); //函数签名(字段类型:varchar,字段长度:500,是否可空:False)
 objvCMFuncParaRelaEN.OrderNum = Int32.Parse(objRow[convCMFuncParaRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvCMFuncParaRelaEN.PrjId = objRow[convCMFuncParaRela.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvCMFuncParaRelaEN.UpdDate = objRow[convCMFuncParaRela.UpdDate] == DBNull.Value ? null : objRow[convCMFuncParaRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCMFuncParaRelaEN.UpdUser = objRow[convCMFuncParaRela.UpdUser] == DBNull.Value ? null : objRow[convCMFuncParaRela.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvCMFuncParaRelaEN.Memo = objRow[convCMFuncParaRela.Memo] == DBNull.Value ? null : objRow[convCMFuncParaRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvCMFuncParaRelaDA: GetObjBymId)", objException.Message));
}
return objvCMFuncParaRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvCMFuncParaRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvCMFuncParaRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFuncParaRelaDA.GetSpecSQLObj();
strSQL = "Select * from vCMFuncParaRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvCMFuncParaRelaEN objvCMFuncParaRelaEN = new clsvCMFuncParaRelaEN()
{
mId = TransNullToInt(objRow[convCMFuncParaRela.mId].ToString().Trim()), //mId
CmFuncParaId = objRow[convCMFuncParaRela.CmFuncParaId].ToString().Trim(), //函数参数Id
ParaName = objRow[convCMFuncParaRela.ParaName].ToString().Trim(), //参数名
ParaComments = objRow[convCMFuncParaRela.ParaComments] == DBNull.Value ? null : objRow[convCMFuncParaRela.ParaComments].ToString().Trim(), //参数注释
ParameterType = objRow[convCMFuncParaRela.ParameterType] == DBNull.Value ? null : objRow[convCMFuncParaRela.ParameterType].ToString().Trim(), //参数类型
DataTypeId = objRow[convCMFuncParaRela.DataTypeId].ToString().Trim(), //数据类型Id
DataTypeName = objRow[convCMFuncParaRela.DataTypeName] == DBNull.Value ? null : objRow[convCMFuncParaRela.DataTypeName].ToString().Trim(), //数据类型名称
CsType = objRow[convCMFuncParaRela.CsType] == DBNull.Value ? null : objRow[convCMFuncParaRela.CsType].ToString().Trim(), //CS类型
JavaType = objRow[convCMFuncParaRela.JavaType] == DBNull.Value ? null : objRow[convCMFuncParaRela.JavaType].ToString().Trim(), //JAVA类型
IsNeedQuote = TransNullToBool(objRow[convCMFuncParaRela.IsNeedQuote].ToString().Trim()), //是否需要引号
ParameterTypeFullName = objRow[convCMFuncParaRela.ParameterTypeFullName] == DBNull.Value ? null : objRow[convCMFuncParaRela.ParameterTypeFullName].ToString().Trim(), //参数类型全名
IsByRef = TransNullToBool(objRow[convCMFuncParaRela.IsByRef].ToString().Trim()), //是否引用型参数
ParaCnName = objRow[convCMFuncParaRela.ParaCnName].ToString().Trim(), //参数中文名
CmFunctionId = objRow[convCMFuncParaRela.CmFunctionId].ToString().Trim(), //函数Id
FunctionName = objRow[convCMFuncParaRela.FunctionName] == DBNull.Value ? null : objRow[convCMFuncParaRela.FunctionName].ToString().Trim(), //功能名称
FunctionSignature = objRow[convCMFuncParaRela.FunctionSignature].ToString().Trim(), //函数签名
OrderNum = TransNullToInt(objRow[convCMFuncParaRela.OrderNum].ToString().Trim()), //序号
PrjId = objRow[convCMFuncParaRela.PrjId].ToString().Trim(), //工程Id
UpdDate = objRow[convCMFuncParaRela.UpdDate] == DBNull.Value ? null : objRow[convCMFuncParaRela.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convCMFuncParaRela.UpdUser] == DBNull.Value ? null : objRow[convCMFuncParaRela.UpdUser].ToString().Trim(), //修改者
Memo = objRow[convCMFuncParaRela.Memo] == DBNull.Value ? null : objRow[convCMFuncParaRela.Memo].ToString().Trim() //说明
};
objvCMFuncParaRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCMFuncParaRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvCMFuncParaRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvCMFuncParaRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCMFuncParaRelaEN objvCMFuncParaRelaEN = new clsvCMFuncParaRelaEN();
try
{
objvCMFuncParaRelaEN.mId = TransNullToInt(objRow[convCMFuncParaRela.mId].ToString().Trim()); //mId
objvCMFuncParaRelaEN.CmFuncParaId = objRow[convCMFuncParaRela.CmFuncParaId].ToString().Trim(); //函数参数Id
objvCMFuncParaRelaEN.ParaName = objRow[convCMFuncParaRela.ParaName].ToString().Trim(); //参数名
objvCMFuncParaRelaEN.ParaComments = objRow[convCMFuncParaRela.ParaComments] == DBNull.Value ? null : objRow[convCMFuncParaRela.ParaComments].ToString().Trim(); //参数注释
objvCMFuncParaRelaEN.ParameterType = objRow[convCMFuncParaRela.ParameterType] == DBNull.Value ? null : objRow[convCMFuncParaRela.ParameterType].ToString().Trim(); //参数类型
objvCMFuncParaRelaEN.DataTypeId = objRow[convCMFuncParaRela.DataTypeId].ToString().Trim(); //数据类型Id
objvCMFuncParaRelaEN.DataTypeName = objRow[convCMFuncParaRela.DataTypeName] == DBNull.Value ? null : objRow[convCMFuncParaRela.DataTypeName].ToString().Trim(); //数据类型名称
objvCMFuncParaRelaEN.CsType = objRow[convCMFuncParaRela.CsType] == DBNull.Value ? null : objRow[convCMFuncParaRela.CsType].ToString().Trim(); //CS类型
objvCMFuncParaRelaEN.JavaType = objRow[convCMFuncParaRela.JavaType] == DBNull.Value ? null : objRow[convCMFuncParaRela.JavaType].ToString().Trim(); //JAVA类型
objvCMFuncParaRelaEN.IsNeedQuote = TransNullToBool(objRow[convCMFuncParaRela.IsNeedQuote].ToString().Trim()); //是否需要引号
objvCMFuncParaRelaEN.ParameterTypeFullName = objRow[convCMFuncParaRela.ParameterTypeFullName] == DBNull.Value ? null : objRow[convCMFuncParaRela.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvCMFuncParaRelaEN.IsByRef = TransNullToBool(objRow[convCMFuncParaRela.IsByRef].ToString().Trim()); //是否引用型参数
objvCMFuncParaRelaEN.ParaCnName = objRow[convCMFuncParaRela.ParaCnName].ToString().Trim(); //参数中文名
objvCMFuncParaRelaEN.CmFunctionId = objRow[convCMFuncParaRela.CmFunctionId].ToString().Trim(); //函数Id
objvCMFuncParaRelaEN.FunctionName = objRow[convCMFuncParaRela.FunctionName] == DBNull.Value ? null : objRow[convCMFuncParaRela.FunctionName].ToString().Trim(); //功能名称
objvCMFuncParaRelaEN.FunctionSignature = objRow[convCMFuncParaRela.FunctionSignature].ToString().Trim(); //函数签名
objvCMFuncParaRelaEN.OrderNum = TransNullToInt(objRow[convCMFuncParaRela.OrderNum].ToString().Trim()); //序号
objvCMFuncParaRelaEN.PrjId = objRow[convCMFuncParaRela.PrjId].ToString().Trim(); //工程Id
objvCMFuncParaRelaEN.UpdDate = objRow[convCMFuncParaRela.UpdDate] == DBNull.Value ? null : objRow[convCMFuncParaRela.UpdDate].ToString().Trim(); //修改日期
objvCMFuncParaRelaEN.UpdUser = objRow[convCMFuncParaRela.UpdUser] == DBNull.Value ? null : objRow[convCMFuncParaRela.UpdUser].ToString().Trim(); //修改者
objvCMFuncParaRelaEN.Memo = objRow[convCMFuncParaRela.Memo] == DBNull.Value ? null : objRow[convCMFuncParaRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvCMFuncParaRelaDA: GetObjByDataRowvCMFuncParaRela)", objException.Message));
}
objvCMFuncParaRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCMFuncParaRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvCMFuncParaRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCMFuncParaRelaEN objvCMFuncParaRelaEN = new clsvCMFuncParaRelaEN();
try
{
objvCMFuncParaRelaEN.mId = TransNullToInt(objRow[convCMFuncParaRela.mId].ToString().Trim()); //mId
objvCMFuncParaRelaEN.CmFuncParaId = objRow[convCMFuncParaRela.CmFuncParaId].ToString().Trim(); //函数参数Id
objvCMFuncParaRelaEN.ParaName = objRow[convCMFuncParaRela.ParaName].ToString().Trim(); //参数名
objvCMFuncParaRelaEN.ParaComments = objRow[convCMFuncParaRela.ParaComments] == DBNull.Value ? null : objRow[convCMFuncParaRela.ParaComments].ToString().Trim(); //参数注释
objvCMFuncParaRelaEN.ParameterType = objRow[convCMFuncParaRela.ParameterType] == DBNull.Value ? null : objRow[convCMFuncParaRela.ParameterType].ToString().Trim(); //参数类型
objvCMFuncParaRelaEN.DataTypeId = objRow[convCMFuncParaRela.DataTypeId].ToString().Trim(); //数据类型Id
objvCMFuncParaRelaEN.DataTypeName = objRow[convCMFuncParaRela.DataTypeName] == DBNull.Value ? null : objRow[convCMFuncParaRela.DataTypeName].ToString().Trim(); //数据类型名称
objvCMFuncParaRelaEN.CsType = objRow[convCMFuncParaRela.CsType] == DBNull.Value ? null : objRow[convCMFuncParaRela.CsType].ToString().Trim(); //CS类型
objvCMFuncParaRelaEN.JavaType = objRow[convCMFuncParaRela.JavaType] == DBNull.Value ? null : objRow[convCMFuncParaRela.JavaType].ToString().Trim(); //JAVA类型
objvCMFuncParaRelaEN.IsNeedQuote = TransNullToBool(objRow[convCMFuncParaRela.IsNeedQuote].ToString().Trim()); //是否需要引号
objvCMFuncParaRelaEN.ParameterTypeFullName = objRow[convCMFuncParaRela.ParameterTypeFullName] == DBNull.Value ? null : objRow[convCMFuncParaRela.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvCMFuncParaRelaEN.IsByRef = TransNullToBool(objRow[convCMFuncParaRela.IsByRef].ToString().Trim()); //是否引用型参数
objvCMFuncParaRelaEN.ParaCnName = objRow[convCMFuncParaRela.ParaCnName].ToString().Trim(); //参数中文名
objvCMFuncParaRelaEN.CmFunctionId = objRow[convCMFuncParaRela.CmFunctionId].ToString().Trim(); //函数Id
objvCMFuncParaRelaEN.FunctionName = objRow[convCMFuncParaRela.FunctionName] == DBNull.Value ? null : objRow[convCMFuncParaRela.FunctionName].ToString().Trim(); //功能名称
objvCMFuncParaRelaEN.FunctionSignature = objRow[convCMFuncParaRela.FunctionSignature].ToString().Trim(); //函数签名
objvCMFuncParaRelaEN.OrderNum = TransNullToInt(objRow[convCMFuncParaRela.OrderNum].ToString().Trim()); //序号
objvCMFuncParaRelaEN.PrjId = objRow[convCMFuncParaRela.PrjId].ToString().Trim(); //工程Id
objvCMFuncParaRelaEN.UpdDate = objRow[convCMFuncParaRela.UpdDate] == DBNull.Value ? null : objRow[convCMFuncParaRela.UpdDate].ToString().Trim(); //修改日期
objvCMFuncParaRelaEN.UpdUser = objRow[convCMFuncParaRela.UpdUser] == DBNull.Value ? null : objRow[convCMFuncParaRela.UpdUser].ToString().Trim(); //修改者
objvCMFuncParaRelaEN.Memo = objRow[convCMFuncParaRela.Memo] == DBNull.Value ? null : objRow[convCMFuncParaRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvCMFuncParaRelaDA: GetObjByDataRow)", objException.Message));
}
objvCMFuncParaRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCMFuncParaRelaEN;
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
objSQL = clsvCMFuncParaRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCMFuncParaRelaEN._CurrTabName, convCMFuncParaRela.mId, 8, "");
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
objSQL = clsvCMFuncParaRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCMFuncParaRelaEN._CurrTabName, convCMFuncParaRela.mId, 8, strPrefix);
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
 objSQL = clsvCMFuncParaRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vCMFuncParaRela where " + strCondition;
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
 objSQL = clsvCMFuncParaRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vCMFuncParaRela where " + strCondition;
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
 objSQL = clsvCMFuncParaRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCMFuncParaRela", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvCMFuncParaRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFuncParaRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCMFuncParaRela", strCondition))
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
objSQL = clsvCMFuncParaRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vCMFuncParaRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvCMFuncParaRelaENS">源对象</param>
 /// <param name = "objvCMFuncParaRelaENT">目标对象</param>
public void CopyTo(clsvCMFuncParaRelaEN objvCMFuncParaRelaENS, clsvCMFuncParaRelaEN objvCMFuncParaRelaENT)
{
objvCMFuncParaRelaENT.mId = objvCMFuncParaRelaENS.mId; //mId
objvCMFuncParaRelaENT.CmFuncParaId = objvCMFuncParaRelaENS.CmFuncParaId; //函数参数Id
objvCMFuncParaRelaENT.ParaName = objvCMFuncParaRelaENS.ParaName; //参数名
objvCMFuncParaRelaENT.ParaComments = objvCMFuncParaRelaENS.ParaComments; //参数注释
objvCMFuncParaRelaENT.ParameterType = objvCMFuncParaRelaENS.ParameterType; //参数类型
objvCMFuncParaRelaENT.DataTypeId = objvCMFuncParaRelaENS.DataTypeId; //数据类型Id
objvCMFuncParaRelaENT.DataTypeName = objvCMFuncParaRelaENS.DataTypeName; //数据类型名称
objvCMFuncParaRelaENT.CsType = objvCMFuncParaRelaENS.CsType; //CS类型
objvCMFuncParaRelaENT.JavaType = objvCMFuncParaRelaENS.JavaType; //JAVA类型
objvCMFuncParaRelaENT.IsNeedQuote = objvCMFuncParaRelaENS.IsNeedQuote; //是否需要引号
objvCMFuncParaRelaENT.ParameterTypeFullName = objvCMFuncParaRelaENS.ParameterTypeFullName; //参数类型全名
objvCMFuncParaRelaENT.IsByRef = objvCMFuncParaRelaENS.IsByRef; //是否引用型参数
objvCMFuncParaRelaENT.ParaCnName = objvCMFuncParaRelaENS.ParaCnName; //参数中文名
objvCMFuncParaRelaENT.CmFunctionId = objvCMFuncParaRelaENS.CmFunctionId; //函数Id
objvCMFuncParaRelaENT.FunctionName = objvCMFuncParaRelaENS.FunctionName; //功能名称
objvCMFuncParaRelaENT.FunctionSignature = objvCMFuncParaRelaENS.FunctionSignature; //函数签名
objvCMFuncParaRelaENT.OrderNum = objvCMFuncParaRelaENS.OrderNum; //序号
objvCMFuncParaRelaENT.PrjId = objvCMFuncParaRelaENS.PrjId; //工程Id
objvCMFuncParaRelaENT.UpdDate = objvCMFuncParaRelaENS.UpdDate; //修改日期
objvCMFuncParaRelaENT.UpdUser = objvCMFuncParaRelaENS.UpdUser; //修改者
objvCMFuncParaRelaENT.Memo = objvCMFuncParaRelaENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvCMFuncParaRelaEN objvCMFuncParaRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvCMFuncParaRelaEN.CmFuncParaId, 8, convCMFuncParaRela.CmFuncParaId);
clsCheckSql.CheckFieldLen(objvCMFuncParaRelaEN.ParaName, 50, convCMFuncParaRela.ParaName);
clsCheckSql.CheckFieldLen(objvCMFuncParaRelaEN.ParaComments, 500, convCMFuncParaRela.ParaComments);
clsCheckSql.CheckFieldLen(objvCMFuncParaRelaEN.ParameterType, 100, convCMFuncParaRela.ParameterType);
clsCheckSql.CheckFieldLen(objvCMFuncParaRelaEN.DataTypeId, 2, convCMFuncParaRela.DataTypeId);
clsCheckSql.CheckFieldLen(objvCMFuncParaRelaEN.DataTypeName, 100, convCMFuncParaRela.DataTypeName);
clsCheckSql.CheckFieldLen(objvCMFuncParaRelaEN.CsType, 100, convCMFuncParaRela.CsType);
clsCheckSql.CheckFieldLen(objvCMFuncParaRelaEN.JavaType, 100, convCMFuncParaRela.JavaType);
clsCheckSql.CheckFieldLen(objvCMFuncParaRelaEN.ParameterTypeFullName, 500, convCMFuncParaRela.ParameterTypeFullName);
clsCheckSql.CheckFieldLen(objvCMFuncParaRelaEN.ParaCnName, 50, convCMFuncParaRela.ParaCnName);
clsCheckSql.CheckFieldLen(objvCMFuncParaRelaEN.CmFunctionId, 8, convCMFuncParaRela.CmFunctionId);
clsCheckSql.CheckFieldLen(objvCMFuncParaRelaEN.FunctionName, 200, convCMFuncParaRela.FunctionName);
clsCheckSql.CheckFieldLen(objvCMFuncParaRelaEN.FunctionSignature, 500, convCMFuncParaRela.FunctionSignature);
clsCheckSql.CheckFieldLen(objvCMFuncParaRelaEN.PrjId, 4, convCMFuncParaRela.PrjId);
clsCheckSql.CheckFieldLen(objvCMFuncParaRelaEN.UpdDate, 20, convCMFuncParaRela.UpdDate);
clsCheckSql.CheckFieldLen(objvCMFuncParaRelaEN.UpdUser, 20, convCMFuncParaRela.UpdUser);
clsCheckSql.CheckFieldLen(objvCMFuncParaRelaEN.Memo, 1000, convCMFuncParaRela.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvCMFuncParaRelaEN.CmFuncParaId, convCMFuncParaRela.CmFuncParaId);
clsCheckSql.CheckSqlInjection4Field(objvCMFuncParaRelaEN.ParaName, convCMFuncParaRela.ParaName);
clsCheckSql.CheckSqlInjection4Field(objvCMFuncParaRelaEN.ParaComments, convCMFuncParaRela.ParaComments);
clsCheckSql.CheckSqlInjection4Field(objvCMFuncParaRelaEN.ParameterType, convCMFuncParaRela.ParameterType);
clsCheckSql.CheckSqlInjection4Field(objvCMFuncParaRelaEN.DataTypeId, convCMFuncParaRela.DataTypeId);
clsCheckSql.CheckSqlInjection4Field(objvCMFuncParaRelaEN.DataTypeName, convCMFuncParaRela.DataTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCMFuncParaRelaEN.CsType, convCMFuncParaRela.CsType);
clsCheckSql.CheckSqlInjection4Field(objvCMFuncParaRelaEN.JavaType, convCMFuncParaRela.JavaType);
clsCheckSql.CheckSqlInjection4Field(objvCMFuncParaRelaEN.ParameterTypeFullName, convCMFuncParaRela.ParameterTypeFullName);
clsCheckSql.CheckSqlInjection4Field(objvCMFuncParaRelaEN.ParaCnName, convCMFuncParaRela.ParaCnName);
clsCheckSql.CheckSqlInjection4Field(objvCMFuncParaRelaEN.CmFunctionId, convCMFuncParaRela.CmFunctionId);
clsCheckSql.CheckSqlInjection4Field(objvCMFuncParaRelaEN.FunctionName, convCMFuncParaRela.FunctionName);
clsCheckSql.CheckSqlInjection4Field(objvCMFuncParaRelaEN.FunctionSignature, convCMFuncParaRela.FunctionSignature);
clsCheckSql.CheckSqlInjection4Field(objvCMFuncParaRelaEN.PrjId, convCMFuncParaRela.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvCMFuncParaRelaEN.UpdDate, convCMFuncParaRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvCMFuncParaRelaEN.UpdUser, convCMFuncParaRela.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvCMFuncParaRelaEN.Memo, convCMFuncParaRela.Memo);
//检查外键字段长度
 objvCMFuncParaRelaEN._IsCheckProperty = true;
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
 objSQL = clsvCMFuncParaRelaDA.GetSpecSQLObj();
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
 objSQL = clsvCMFuncParaRelaDA.GetSpecSQLObj();
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
 objSQL = clsvCMFuncParaRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCMFuncParaRelaEN._CurrTabName);
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
 objSQL = clsvCMFuncParaRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCMFuncParaRelaEN._CurrTabName, strCondition);
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
 objSQL = clsvCMFuncParaRelaDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}