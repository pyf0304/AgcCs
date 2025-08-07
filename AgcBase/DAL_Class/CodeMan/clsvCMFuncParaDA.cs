
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCMFuncParaDA
 表名:vCMFuncPara(00050508)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:36:36
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
 /// vCM函数参数(vCMFuncPara)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvCMFuncParaDA : clsCommBase4DA
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
 return clsvCMFuncParaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvCMFuncParaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCMFuncParaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvCMFuncParaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvCMFuncParaEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strCmFuncParaId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strCmFuncParaId)
{
strCmFuncParaId = strCmFuncParaId.Replace("'", "''");
if (strCmFuncParaId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vCMFuncPara中,检查关键字,长度不正确!(clsvCMFuncParaDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strCmFuncParaId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vCMFuncPara中,关键字不能为空 或 null!(clsvCMFuncParaDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCmFuncParaId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvCMFuncParaDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvCMFuncParaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFuncParaDA.GetSpecSQLObj();
strSQL = "Select * from vCMFuncPara where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vCMFuncPara(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvCMFuncParaDA: GetDataTable_vCMFuncPara)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFuncParaDA.GetSpecSQLObj();
strSQL = "Select * from vCMFuncPara where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvCMFuncParaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFuncParaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvCMFuncParaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFuncParaDA.GetSpecSQLObj();
strSQL = "Select * from vCMFuncPara where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvCMFuncParaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFuncParaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvCMFuncParaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFuncParaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCMFuncPara where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCMFuncPara where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvCMFuncParaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFuncParaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vCMFuncPara where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvCMFuncParaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFuncParaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vCMFuncPara.* " + 
$"from vCMFuncPara " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vCMFuncPara.CmFuncParaId not in " + 
$"(Select top {intTop_In} vCMFuncPara.CmFuncParaId from vCMFuncPara " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCMFuncPara where {1} and CmFuncParaId not in (Select top {2} CmFuncParaId from vCMFuncPara where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCMFuncPara where {1} and CmFuncParaId not in (Select top {3} CmFuncParaId from vCMFuncPara where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvCMFuncParaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFuncParaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vCMFuncPara.* " + 
$"from vCMFuncPara " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vCMFuncPara.CmFuncParaId not in " + 
$"(Select top {intTop_In} vCMFuncPara.CmFuncParaId from vCMFuncPara " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCMFuncPara where {1} and CmFuncParaId not in (Select top {2} CmFuncParaId from vCMFuncPara where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCMFuncPara where {1} and CmFuncParaId not in (Select top {3} CmFuncParaId from vCMFuncPara where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvCMFuncParaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvCMFuncParaDA:GetObjLst)", objException.Message));
}
List<clsvCMFuncParaEN> arrObjLst = new List<clsvCMFuncParaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFuncParaDA.GetSpecSQLObj();
strSQL = "Select * from vCMFuncPara where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFuncParaEN objvCMFuncParaEN = new clsvCMFuncParaEN();
try
{
objvCMFuncParaEN.CmFuncParaId = objRow[convCMFuncPara.CmFuncParaId].ToString().Trim(); //函数参数Id
objvCMFuncParaEN.ParaName = objRow[convCMFuncPara.ParaName].ToString().Trim(); //参数名
objvCMFuncParaEN.ParaComments = objRow[convCMFuncPara.ParaComments] == DBNull.Value ? null : objRow[convCMFuncPara.ParaComments].ToString().Trim(); //参数注释
objvCMFuncParaEN.ParameterType = objRow[convCMFuncPara.ParameterType] == DBNull.Value ? null : objRow[convCMFuncPara.ParameterType].ToString().Trim(); //参数类型
objvCMFuncParaEN.DataTypeId = objRow[convCMFuncPara.DataTypeId].ToString().Trim(); //数据类型Id
objvCMFuncParaEN.DataTypeName = objRow[convCMFuncPara.DataTypeName] == DBNull.Value ? null : objRow[convCMFuncPara.DataTypeName].ToString().Trim(); //数据类型名称
objvCMFuncParaEN.DataCnName = objRow[convCMFuncPara.DataCnName].ToString().Trim(); //数据类型中文名称
objvCMFuncParaEN.CsType = objRow[convCMFuncPara.CsType].ToString().Trim(); //CS类型
objvCMFuncParaEN.JavaType = objRow[convCMFuncPara.JavaType].ToString().Trim(); //JAVA类型
objvCMFuncParaEN.JavaObjType = objRow[convCMFuncPara.JavaObjType] == DBNull.Value ? null : objRow[convCMFuncPara.JavaObjType].ToString().Trim(); //JAVA对象类型
objvCMFuncParaEN.SwiftType = objRow[convCMFuncPara.SwiftType] == DBNull.Value ? null : objRow[convCMFuncPara.SwiftType].ToString().Trim(); //SwiftType
objvCMFuncParaEN.IsNeedQuote = TransNullToBool(objRow[convCMFuncPara.IsNeedQuote].ToString().Trim()); //是否需要引号
objvCMFuncParaEN.OraDbType = objRow[convCMFuncPara.OraDbType].ToString().Trim(); //Ora数据类型
objvCMFuncParaEN.MySqlType = objRow[convCMFuncPara.MySqlType] == DBNull.Value ? null : objRow[convCMFuncPara.MySqlType].ToString().Trim(); //MySqlType
objvCMFuncParaEN.ParameterTypeFullName = objRow[convCMFuncPara.ParameterTypeFullName] == DBNull.Value ? null : objRow[convCMFuncPara.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvCMFuncParaEN.IsByRef = TransNullToBool(objRow[convCMFuncPara.IsByRef].ToString().Trim()); //是否引用型参数
objvCMFuncParaEN.ParaCnName = objRow[convCMFuncPara.ParaCnName].ToString().Trim(); //参数中文名
objvCMFuncParaEN.PrjId = objRow[convCMFuncPara.PrjId].ToString().Trim(); //工程Id
objvCMFuncParaEN.UpdDate = objRow[convCMFuncPara.UpdDate] == DBNull.Value ? null : objRow[convCMFuncPara.UpdDate].ToString().Trim(); //修改日期
objvCMFuncParaEN.UpdUser = objRow[convCMFuncPara.UpdUser] == DBNull.Value ? null : objRow[convCMFuncPara.UpdUser].ToString().Trim(); //修改者
objvCMFuncParaEN.Memo = objRow[convCMFuncPara.Memo] == DBNull.Value ? null : objRow[convCMFuncPara.Memo].ToString().Trim(); //说明
objvCMFuncParaEN.FuncCount = objRow[convCMFuncPara.FuncCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCMFuncPara.FuncCount].ToString().Trim()); //函数数目
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCMFuncParaDA: GetObjLst)", objException.Message));
}
objvCMFuncParaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCMFuncParaEN);
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
public List<clsvCMFuncParaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvCMFuncParaDA:GetObjLstByTabName)", objException.Message));
}
List<clsvCMFuncParaEN> arrObjLst = new List<clsvCMFuncParaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFuncParaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFuncParaEN objvCMFuncParaEN = new clsvCMFuncParaEN();
try
{
objvCMFuncParaEN.CmFuncParaId = objRow[convCMFuncPara.CmFuncParaId].ToString().Trim(); //函数参数Id
objvCMFuncParaEN.ParaName = objRow[convCMFuncPara.ParaName].ToString().Trim(); //参数名
objvCMFuncParaEN.ParaComments = objRow[convCMFuncPara.ParaComments] == DBNull.Value ? null : objRow[convCMFuncPara.ParaComments].ToString().Trim(); //参数注释
objvCMFuncParaEN.ParameterType = objRow[convCMFuncPara.ParameterType] == DBNull.Value ? null : objRow[convCMFuncPara.ParameterType].ToString().Trim(); //参数类型
objvCMFuncParaEN.DataTypeId = objRow[convCMFuncPara.DataTypeId].ToString().Trim(); //数据类型Id
objvCMFuncParaEN.DataTypeName = objRow[convCMFuncPara.DataTypeName] == DBNull.Value ? null : objRow[convCMFuncPara.DataTypeName].ToString().Trim(); //数据类型名称
objvCMFuncParaEN.DataCnName = objRow[convCMFuncPara.DataCnName].ToString().Trim(); //数据类型中文名称
objvCMFuncParaEN.CsType = objRow[convCMFuncPara.CsType].ToString().Trim(); //CS类型
objvCMFuncParaEN.JavaType = objRow[convCMFuncPara.JavaType].ToString().Trim(); //JAVA类型
objvCMFuncParaEN.JavaObjType = objRow[convCMFuncPara.JavaObjType] == DBNull.Value ? null : objRow[convCMFuncPara.JavaObjType].ToString().Trim(); //JAVA对象类型
objvCMFuncParaEN.SwiftType = objRow[convCMFuncPara.SwiftType] == DBNull.Value ? null : objRow[convCMFuncPara.SwiftType].ToString().Trim(); //SwiftType
objvCMFuncParaEN.IsNeedQuote = TransNullToBool(objRow[convCMFuncPara.IsNeedQuote].ToString().Trim()); //是否需要引号
objvCMFuncParaEN.OraDbType = objRow[convCMFuncPara.OraDbType].ToString().Trim(); //Ora数据类型
objvCMFuncParaEN.MySqlType = objRow[convCMFuncPara.MySqlType] == DBNull.Value ? null : objRow[convCMFuncPara.MySqlType].ToString().Trim(); //MySqlType
objvCMFuncParaEN.ParameterTypeFullName = objRow[convCMFuncPara.ParameterTypeFullName] == DBNull.Value ? null : objRow[convCMFuncPara.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvCMFuncParaEN.IsByRef = TransNullToBool(objRow[convCMFuncPara.IsByRef].ToString().Trim()); //是否引用型参数
objvCMFuncParaEN.ParaCnName = objRow[convCMFuncPara.ParaCnName].ToString().Trim(); //参数中文名
objvCMFuncParaEN.PrjId = objRow[convCMFuncPara.PrjId].ToString().Trim(); //工程Id
objvCMFuncParaEN.UpdDate = objRow[convCMFuncPara.UpdDate] == DBNull.Value ? null : objRow[convCMFuncPara.UpdDate].ToString().Trim(); //修改日期
objvCMFuncParaEN.UpdUser = objRow[convCMFuncPara.UpdUser] == DBNull.Value ? null : objRow[convCMFuncPara.UpdUser].ToString().Trim(); //修改者
objvCMFuncParaEN.Memo = objRow[convCMFuncPara.Memo] == DBNull.Value ? null : objRow[convCMFuncPara.Memo].ToString().Trim(); //说明
objvCMFuncParaEN.FuncCount = objRow[convCMFuncPara.FuncCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCMFuncPara.FuncCount].ToString().Trim()); //函数数目
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCMFuncParaDA: GetObjLst)", objException.Message));
}
objvCMFuncParaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCMFuncParaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvCMFuncParaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvCMFuncPara(ref clsvCMFuncParaEN objvCMFuncParaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFuncParaDA.GetSpecSQLObj();
strSQL = "Select * from vCMFuncPara where CmFuncParaId = " + "'"+ objvCMFuncParaEN.CmFuncParaId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvCMFuncParaEN.CmFuncParaId = objDT.Rows[0][convCMFuncPara.CmFuncParaId].ToString().Trim(); //函数参数Id(字段类型:char,字段长度:8,是否可空:False)
 objvCMFuncParaEN.ParaName = objDT.Rows[0][convCMFuncPara.ParaName].ToString().Trim(); //参数名(字段类型:varchar,字段长度:50,是否可空:False)
 objvCMFuncParaEN.ParaComments = objDT.Rows[0][convCMFuncPara.ParaComments].ToString().Trim(); //参数注释(字段类型:varchar,字段长度:500,是否可空:True)
 objvCMFuncParaEN.ParameterType = objDT.Rows[0][convCMFuncPara.ParameterType].ToString().Trim(); //参数类型(字段类型:varchar,字段长度:100,是否可空:True)
 objvCMFuncParaEN.DataTypeId = objDT.Rows[0][convCMFuncPara.DataTypeId].ToString().Trim(); //数据类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvCMFuncParaEN.DataTypeName = objDT.Rows[0][convCMFuncPara.DataTypeName].ToString().Trim(); //数据类型名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCMFuncParaEN.DataCnName = objDT.Rows[0][convCMFuncPara.DataCnName].ToString().Trim(); //数据类型中文名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCMFuncParaEN.CsType = objDT.Rows[0][convCMFuncPara.CsType].ToString().Trim(); //CS类型(字段类型:varchar,字段长度:100,是否可空:False)
 objvCMFuncParaEN.JavaType = objDT.Rows[0][convCMFuncPara.JavaType].ToString().Trim(); //JAVA类型(字段类型:varchar,字段长度:100,是否可空:False)
 objvCMFuncParaEN.JavaObjType = objDT.Rows[0][convCMFuncPara.JavaObjType].ToString().Trim(); //JAVA对象类型(字段类型:varchar,字段长度:100,是否可空:True)
 objvCMFuncParaEN.SwiftType = objDT.Rows[0][convCMFuncPara.SwiftType].ToString().Trim(); //SwiftType(字段类型:varchar,字段长度:100,是否可空:True)
 objvCMFuncParaEN.IsNeedQuote = TransNullToBool(objDT.Rows[0][convCMFuncPara.IsNeedQuote].ToString().Trim()); //是否需要引号(字段类型:bit,字段长度:1,是否可空:False)
 objvCMFuncParaEN.OraDbType = objDT.Rows[0][convCMFuncPara.OraDbType].ToString().Trim(); //Ora数据类型(字段类型:varchar,字段长度:100,是否可空:False)
 objvCMFuncParaEN.MySqlType = objDT.Rows[0][convCMFuncPara.MySqlType].ToString().Trim(); //MySqlType(字段类型:varchar,字段长度:100,是否可空:True)
 objvCMFuncParaEN.ParameterTypeFullName = objDT.Rows[0][convCMFuncPara.ParameterTypeFullName].ToString().Trim(); //参数类型全名(字段类型:varchar,字段长度:500,是否可空:True)
 objvCMFuncParaEN.IsByRef = TransNullToBool(objDT.Rows[0][convCMFuncPara.IsByRef].ToString().Trim()); //是否引用型参数(字段类型:bit,字段长度:1,是否可空:True)
 objvCMFuncParaEN.ParaCnName = objDT.Rows[0][convCMFuncPara.ParaCnName].ToString().Trim(); //参数中文名(字段类型:varchar,字段长度:50,是否可空:False)
 objvCMFuncParaEN.PrjId = objDT.Rows[0][convCMFuncPara.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvCMFuncParaEN.UpdDate = objDT.Rows[0][convCMFuncPara.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCMFuncParaEN.UpdUser = objDT.Rows[0][convCMFuncPara.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvCMFuncParaEN.Memo = objDT.Rows[0][convCMFuncPara.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCMFuncParaEN.FuncCount = TransNullToInt(objDT.Rows[0][convCMFuncPara.FuncCount].ToString().Trim()); //函数数目(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvCMFuncParaDA: GetvCMFuncPara)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCmFuncParaId">表关键字</param>
 /// <returns>表对象</returns>
public clsvCMFuncParaEN GetObjByCmFuncParaId(string strCmFuncParaId)
{
CheckPrimaryKey(strCmFuncParaId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFuncParaDA.GetSpecSQLObj();
strSQL = "Select * from vCMFuncPara where CmFuncParaId = " + "'"+ strCmFuncParaId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvCMFuncParaEN objvCMFuncParaEN = new clsvCMFuncParaEN();
try
{
 objvCMFuncParaEN.CmFuncParaId = objRow[convCMFuncPara.CmFuncParaId].ToString().Trim(); //函数参数Id(字段类型:char,字段长度:8,是否可空:False)
 objvCMFuncParaEN.ParaName = objRow[convCMFuncPara.ParaName].ToString().Trim(); //参数名(字段类型:varchar,字段长度:50,是否可空:False)
 objvCMFuncParaEN.ParaComments = objRow[convCMFuncPara.ParaComments] == DBNull.Value ? null : objRow[convCMFuncPara.ParaComments].ToString().Trim(); //参数注释(字段类型:varchar,字段长度:500,是否可空:True)
 objvCMFuncParaEN.ParameterType = objRow[convCMFuncPara.ParameterType] == DBNull.Value ? null : objRow[convCMFuncPara.ParameterType].ToString().Trim(); //参数类型(字段类型:varchar,字段长度:100,是否可空:True)
 objvCMFuncParaEN.DataTypeId = objRow[convCMFuncPara.DataTypeId].ToString().Trim(); //数据类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvCMFuncParaEN.DataTypeName = objRow[convCMFuncPara.DataTypeName] == DBNull.Value ? null : objRow[convCMFuncPara.DataTypeName].ToString().Trim(); //数据类型名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCMFuncParaEN.DataCnName = objRow[convCMFuncPara.DataCnName].ToString().Trim(); //数据类型中文名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCMFuncParaEN.CsType = objRow[convCMFuncPara.CsType].ToString().Trim(); //CS类型(字段类型:varchar,字段长度:100,是否可空:False)
 objvCMFuncParaEN.JavaType = objRow[convCMFuncPara.JavaType].ToString().Trim(); //JAVA类型(字段类型:varchar,字段长度:100,是否可空:False)
 objvCMFuncParaEN.JavaObjType = objRow[convCMFuncPara.JavaObjType] == DBNull.Value ? null : objRow[convCMFuncPara.JavaObjType].ToString().Trim(); //JAVA对象类型(字段类型:varchar,字段长度:100,是否可空:True)
 objvCMFuncParaEN.SwiftType = objRow[convCMFuncPara.SwiftType] == DBNull.Value ? null : objRow[convCMFuncPara.SwiftType].ToString().Trim(); //SwiftType(字段类型:varchar,字段长度:100,是否可空:True)
 objvCMFuncParaEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convCMFuncPara.IsNeedQuote].ToString().Trim()); //是否需要引号(字段类型:bit,字段长度:1,是否可空:False)
 objvCMFuncParaEN.OraDbType = objRow[convCMFuncPara.OraDbType].ToString().Trim(); //Ora数据类型(字段类型:varchar,字段长度:100,是否可空:False)
 objvCMFuncParaEN.MySqlType = objRow[convCMFuncPara.MySqlType] == DBNull.Value ? null : objRow[convCMFuncPara.MySqlType].ToString().Trim(); //MySqlType(字段类型:varchar,字段长度:100,是否可空:True)
 objvCMFuncParaEN.ParameterTypeFullName = objRow[convCMFuncPara.ParameterTypeFullName] == DBNull.Value ? null : objRow[convCMFuncPara.ParameterTypeFullName].ToString().Trim(); //参数类型全名(字段类型:varchar,字段长度:500,是否可空:True)
 objvCMFuncParaEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[convCMFuncPara.IsByRef].ToString().Trim()); //是否引用型参数(字段类型:bit,字段长度:1,是否可空:True)
 objvCMFuncParaEN.ParaCnName = objRow[convCMFuncPara.ParaCnName].ToString().Trim(); //参数中文名(字段类型:varchar,字段长度:50,是否可空:False)
 objvCMFuncParaEN.PrjId = objRow[convCMFuncPara.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvCMFuncParaEN.UpdDate = objRow[convCMFuncPara.UpdDate] == DBNull.Value ? null : objRow[convCMFuncPara.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCMFuncParaEN.UpdUser = objRow[convCMFuncPara.UpdUser] == DBNull.Value ? null : objRow[convCMFuncPara.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvCMFuncParaEN.Memo = objRow[convCMFuncPara.Memo] == DBNull.Value ? null : objRow[convCMFuncPara.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCMFuncParaEN.FuncCount = objRow[convCMFuncPara.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMFuncPara.FuncCount].ToString().Trim()); //函数数目(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvCMFuncParaDA: GetObjByCmFuncParaId)", objException.Message));
}
return objvCMFuncParaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvCMFuncParaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvCMFuncParaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFuncParaDA.GetSpecSQLObj();
strSQL = "Select * from vCMFuncPara where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvCMFuncParaEN objvCMFuncParaEN = new clsvCMFuncParaEN()
{
CmFuncParaId = objRow[convCMFuncPara.CmFuncParaId].ToString().Trim(), //函数参数Id
ParaName = objRow[convCMFuncPara.ParaName].ToString().Trim(), //参数名
ParaComments = objRow[convCMFuncPara.ParaComments] == DBNull.Value ? null : objRow[convCMFuncPara.ParaComments].ToString().Trim(), //参数注释
ParameterType = objRow[convCMFuncPara.ParameterType] == DBNull.Value ? null : objRow[convCMFuncPara.ParameterType].ToString().Trim(), //参数类型
DataTypeId = objRow[convCMFuncPara.DataTypeId].ToString().Trim(), //数据类型Id
DataTypeName = objRow[convCMFuncPara.DataTypeName] == DBNull.Value ? null : objRow[convCMFuncPara.DataTypeName].ToString().Trim(), //数据类型名称
DataCnName = objRow[convCMFuncPara.DataCnName].ToString().Trim(), //数据类型中文名称
CsType = objRow[convCMFuncPara.CsType].ToString().Trim(), //CS类型
JavaType = objRow[convCMFuncPara.JavaType].ToString().Trim(), //JAVA类型
JavaObjType = objRow[convCMFuncPara.JavaObjType] == DBNull.Value ? null : objRow[convCMFuncPara.JavaObjType].ToString().Trim(), //JAVA对象类型
SwiftType = objRow[convCMFuncPara.SwiftType] == DBNull.Value ? null : objRow[convCMFuncPara.SwiftType].ToString().Trim(), //SwiftType
IsNeedQuote = TransNullToBool(objRow[convCMFuncPara.IsNeedQuote].ToString().Trim()), //是否需要引号
OraDbType = objRow[convCMFuncPara.OraDbType].ToString().Trim(), //Ora数据类型
MySqlType = objRow[convCMFuncPara.MySqlType] == DBNull.Value ? null : objRow[convCMFuncPara.MySqlType].ToString().Trim(), //MySqlType
ParameterTypeFullName = objRow[convCMFuncPara.ParameterTypeFullName] == DBNull.Value ? null : objRow[convCMFuncPara.ParameterTypeFullName].ToString().Trim(), //参数类型全名
IsByRef = TransNullToBool(objRow[convCMFuncPara.IsByRef].ToString().Trim()), //是否引用型参数
ParaCnName = objRow[convCMFuncPara.ParaCnName].ToString().Trim(), //参数中文名
PrjId = objRow[convCMFuncPara.PrjId].ToString().Trim(), //工程Id
UpdDate = objRow[convCMFuncPara.UpdDate] == DBNull.Value ? null : objRow[convCMFuncPara.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convCMFuncPara.UpdUser] == DBNull.Value ? null : objRow[convCMFuncPara.UpdUser].ToString().Trim(), //修改者
Memo = objRow[convCMFuncPara.Memo] == DBNull.Value ? null : objRow[convCMFuncPara.Memo].ToString().Trim(), //说明
FuncCount = objRow[convCMFuncPara.FuncCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCMFuncPara.FuncCount].ToString().Trim()) //函数数目
};
objvCMFuncParaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCMFuncParaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvCMFuncParaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvCMFuncParaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCMFuncParaEN objvCMFuncParaEN = new clsvCMFuncParaEN();
try
{
objvCMFuncParaEN.CmFuncParaId = objRow[convCMFuncPara.CmFuncParaId].ToString().Trim(); //函数参数Id
objvCMFuncParaEN.ParaName = objRow[convCMFuncPara.ParaName].ToString().Trim(); //参数名
objvCMFuncParaEN.ParaComments = objRow[convCMFuncPara.ParaComments] == DBNull.Value ? null : objRow[convCMFuncPara.ParaComments].ToString().Trim(); //参数注释
objvCMFuncParaEN.ParameterType = objRow[convCMFuncPara.ParameterType] == DBNull.Value ? null : objRow[convCMFuncPara.ParameterType].ToString().Trim(); //参数类型
objvCMFuncParaEN.DataTypeId = objRow[convCMFuncPara.DataTypeId].ToString().Trim(); //数据类型Id
objvCMFuncParaEN.DataTypeName = objRow[convCMFuncPara.DataTypeName] == DBNull.Value ? null : objRow[convCMFuncPara.DataTypeName].ToString().Trim(); //数据类型名称
objvCMFuncParaEN.DataCnName = objRow[convCMFuncPara.DataCnName].ToString().Trim(); //数据类型中文名称
objvCMFuncParaEN.CsType = objRow[convCMFuncPara.CsType].ToString().Trim(); //CS类型
objvCMFuncParaEN.JavaType = objRow[convCMFuncPara.JavaType].ToString().Trim(); //JAVA类型
objvCMFuncParaEN.JavaObjType = objRow[convCMFuncPara.JavaObjType] == DBNull.Value ? null : objRow[convCMFuncPara.JavaObjType].ToString().Trim(); //JAVA对象类型
objvCMFuncParaEN.SwiftType = objRow[convCMFuncPara.SwiftType] == DBNull.Value ? null : objRow[convCMFuncPara.SwiftType].ToString().Trim(); //SwiftType
objvCMFuncParaEN.IsNeedQuote = TransNullToBool(objRow[convCMFuncPara.IsNeedQuote].ToString().Trim()); //是否需要引号
objvCMFuncParaEN.OraDbType = objRow[convCMFuncPara.OraDbType].ToString().Trim(); //Ora数据类型
objvCMFuncParaEN.MySqlType = objRow[convCMFuncPara.MySqlType] == DBNull.Value ? null : objRow[convCMFuncPara.MySqlType].ToString().Trim(); //MySqlType
objvCMFuncParaEN.ParameterTypeFullName = objRow[convCMFuncPara.ParameterTypeFullName] == DBNull.Value ? null : objRow[convCMFuncPara.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvCMFuncParaEN.IsByRef = TransNullToBool(objRow[convCMFuncPara.IsByRef].ToString().Trim()); //是否引用型参数
objvCMFuncParaEN.ParaCnName = objRow[convCMFuncPara.ParaCnName].ToString().Trim(); //参数中文名
objvCMFuncParaEN.PrjId = objRow[convCMFuncPara.PrjId].ToString().Trim(); //工程Id
objvCMFuncParaEN.UpdDate = objRow[convCMFuncPara.UpdDate] == DBNull.Value ? null : objRow[convCMFuncPara.UpdDate].ToString().Trim(); //修改日期
objvCMFuncParaEN.UpdUser = objRow[convCMFuncPara.UpdUser] == DBNull.Value ? null : objRow[convCMFuncPara.UpdUser].ToString().Trim(); //修改者
objvCMFuncParaEN.Memo = objRow[convCMFuncPara.Memo] == DBNull.Value ? null : objRow[convCMFuncPara.Memo].ToString().Trim(); //说明
objvCMFuncParaEN.FuncCount = objRow[convCMFuncPara.FuncCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCMFuncPara.FuncCount].ToString().Trim()); //函数数目
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvCMFuncParaDA: GetObjByDataRowvCMFuncPara)", objException.Message));
}
objvCMFuncParaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCMFuncParaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvCMFuncParaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCMFuncParaEN objvCMFuncParaEN = new clsvCMFuncParaEN();
try
{
objvCMFuncParaEN.CmFuncParaId = objRow[convCMFuncPara.CmFuncParaId].ToString().Trim(); //函数参数Id
objvCMFuncParaEN.ParaName = objRow[convCMFuncPara.ParaName].ToString().Trim(); //参数名
objvCMFuncParaEN.ParaComments = objRow[convCMFuncPara.ParaComments] == DBNull.Value ? null : objRow[convCMFuncPara.ParaComments].ToString().Trim(); //参数注释
objvCMFuncParaEN.ParameterType = objRow[convCMFuncPara.ParameterType] == DBNull.Value ? null : objRow[convCMFuncPara.ParameterType].ToString().Trim(); //参数类型
objvCMFuncParaEN.DataTypeId = objRow[convCMFuncPara.DataTypeId].ToString().Trim(); //数据类型Id
objvCMFuncParaEN.DataTypeName = objRow[convCMFuncPara.DataTypeName] == DBNull.Value ? null : objRow[convCMFuncPara.DataTypeName].ToString().Trim(); //数据类型名称
objvCMFuncParaEN.DataCnName = objRow[convCMFuncPara.DataCnName].ToString().Trim(); //数据类型中文名称
objvCMFuncParaEN.CsType = objRow[convCMFuncPara.CsType].ToString().Trim(); //CS类型
objvCMFuncParaEN.JavaType = objRow[convCMFuncPara.JavaType].ToString().Trim(); //JAVA类型
objvCMFuncParaEN.JavaObjType = objRow[convCMFuncPara.JavaObjType] == DBNull.Value ? null : objRow[convCMFuncPara.JavaObjType].ToString().Trim(); //JAVA对象类型
objvCMFuncParaEN.SwiftType = objRow[convCMFuncPara.SwiftType] == DBNull.Value ? null : objRow[convCMFuncPara.SwiftType].ToString().Trim(); //SwiftType
objvCMFuncParaEN.IsNeedQuote = TransNullToBool(objRow[convCMFuncPara.IsNeedQuote].ToString().Trim()); //是否需要引号
objvCMFuncParaEN.OraDbType = objRow[convCMFuncPara.OraDbType].ToString().Trim(); //Ora数据类型
objvCMFuncParaEN.MySqlType = objRow[convCMFuncPara.MySqlType] == DBNull.Value ? null : objRow[convCMFuncPara.MySqlType].ToString().Trim(); //MySqlType
objvCMFuncParaEN.ParameterTypeFullName = objRow[convCMFuncPara.ParameterTypeFullName] == DBNull.Value ? null : objRow[convCMFuncPara.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvCMFuncParaEN.IsByRef = TransNullToBool(objRow[convCMFuncPara.IsByRef].ToString().Trim()); //是否引用型参数
objvCMFuncParaEN.ParaCnName = objRow[convCMFuncPara.ParaCnName].ToString().Trim(); //参数中文名
objvCMFuncParaEN.PrjId = objRow[convCMFuncPara.PrjId].ToString().Trim(); //工程Id
objvCMFuncParaEN.UpdDate = objRow[convCMFuncPara.UpdDate] == DBNull.Value ? null : objRow[convCMFuncPara.UpdDate].ToString().Trim(); //修改日期
objvCMFuncParaEN.UpdUser = objRow[convCMFuncPara.UpdUser] == DBNull.Value ? null : objRow[convCMFuncPara.UpdUser].ToString().Trim(); //修改者
objvCMFuncParaEN.Memo = objRow[convCMFuncPara.Memo] == DBNull.Value ? null : objRow[convCMFuncPara.Memo].ToString().Trim(); //说明
objvCMFuncParaEN.FuncCount = objRow[convCMFuncPara.FuncCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCMFuncPara.FuncCount].ToString().Trim()); //函数数目
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvCMFuncParaDA: GetObjByDataRow)", objException.Message));
}
objvCMFuncParaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCMFuncParaEN;
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
objSQL = clsvCMFuncParaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCMFuncParaEN._CurrTabName, convCMFuncPara.CmFuncParaId, 8, "");
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
objSQL = clsvCMFuncParaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCMFuncParaEN._CurrTabName, convCMFuncPara.CmFuncParaId, 8, strPrefix);
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
 objSQL = clsvCMFuncParaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select CmFuncParaId from vCMFuncPara where " + strCondition;
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
 objSQL = clsvCMFuncParaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select CmFuncParaId from vCMFuncPara where " + strCondition;
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
 /// <param name = "strCmFuncParaId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strCmFuncParaId)
{
CheckPrimaryKey(strCmFuncParaId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFuncParaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCMFuncPara", "CmFuncParaId = " + "'"+ strCmFuncParaId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvCMFuncParaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFuncParaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCMFuncPara", strCondition))
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
objSQL = clsvCMFuncParaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vCMFuncPara");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvCMFuncParaENS">源对象</param>
 /// <param name = "objvCMFuncParaENT">目标对象</param>
public void CopyTo(clsvCMFuncParaEN objvCMFuncParaENS, clsvCMFuncParaEN objvCMFuncParaENT)
{
objvCMFuncParaENT.CmFuncParaId = objvCMFuncParaENS.CmFuncParaId; //函数参数Id
objvCMFuncParaENT.ParaName = objvCMFuncParaENS.ParaName; //参数名
objvCMFuncParaENT.ParaComments = objvCMFuncParaENS.ParaComments; //参数注释
objvCMFuncParaENT.ParameterType = objvCMFuncParaENS.ParameterType; //参数类型
objvCMFuncParaENT.DataTypeId = objvCMFuncParaENS.DataTypeId; //数据类型Id
objvCMFuncParaENT.DataTypeName = objvCMFuncParaENS.DataTypeName; //数据类型名称
objvCMFuncParaENT.DataCnName = objvCMFuncParaENS.DataCnName; //数据类型中文名称
objvCMFuncParaENT.CsType = objvCMFuncParaENS.CsType; //CS类型
objvCMFuncParaENT.JavaType = objvCMFuncParaENS.JavaType; //JAVA类型
objvCMFuncParaENT.JavaObjType = objvCMFuncParaENS.JavaObjType; //JAVA对象类型
objvCMFuncParaENT.SwiftType = objvCMFuncParaENS.SwiftType; //SwiftType
objvCMFuncParaENT.IsNeedQuote = objvCMFuncParaENS.IsNeedQuote; //是否需要引号
objvCMFuncParaENT.OraDbType = objvCMFuncParaENS.OraDbType; //Ora数据类型
objvCMFuncParaENT.MySqlType = objvCMFuncParaENS.MySqlType; //MySqlType
objvCMFuncParaENT.ParameterTypeFullName = objvCMFuncParaENS.ParameterTypeFullName; //参数类型全名
objvCMFuncParaENT.IsByRef = objvCMFuncParaENS.IsByRef; //是否引用型参数
objvCMFuncParaENT.ParaCnName = objvCMFuncParaENS.ParaCnName; //参数中文名
objvCMFuncParaENT.PrjId = objvCMFuncParaENS.PrjId; //工程Id
objvCMFuncParaENT.UpdDate = objvCMFuncParaENS.UpdDate; //修改日期
objvCMFuncParaENT.UpdUser = objvCMFuncParaENS.UpdUser; //修改者
objvCMFuncParaENT.Memo = objvCMFuncParaENS.Memo; //说明
objvCMFuncParaENT.FuncCount = objvCMFuncParaENS.FuncCount; //函数数目
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvCMFuncParaEN objvCMFuncParaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvCMFuncParaEN.CmFuncParaId, 8, convCMFuncPara.CmFuncParaId);
clsCheckSql.CheckFieldLen(objvCMFuncParaEN.ParaName, 50, convCMFuncPara.ParaName);
clsCheckSql.CheckFieldLen(objvCMFuncParaEN.ParaComments, 500, convCMFuncPara.ParaComments);
clsCheckSql.CheckFieldLen(objvCMFuncParaEN.ParameterType, 100, convCMFuncPara.ParameterType);
clsCheckSql.CheckFieldLen(objvCMFuncParaEN.DataTypeId, 2, convCMFuncPara.DataTypeId);
clsCheckSql.CheckFieldLen(objvCMFuncParaEN.DataTypeName, 100, convCMFuncPara.DataTypeName);
clsCheckSql.CheckFieldLen(objvCMFuncParaEN.DataCnName, 100, convCMFuncPara.DataCnName);
clsCheckSql.CheckFieldLen(objvCMFuncParaEN.CsType, 100, convCMFuncPara.CsType);
clsCheckSql.CheckFieldLen(objvCMFuncParaEN.JavaType, 100, convCMFuncPara.JavaType);
clsCheckSql.CheckFieldLen(objvCMFuncParaEN.JavaObjType, 100, convCMFuncPara.JavaObjType);
clsCheckSql.CheckFieldLen(objvCMFuncParaEN.SwiftType, 100, convCMFuncPara.SwiftType);
clsCheckSql.CheckFieldLen(objvCMFuncParaEN.OraDbType, 100, convCMFuncPara.OraDbType);
clsCheckSql.CheckFieldLen(objvCMFuncParaEN.MySqlType, 100, convCMFuncPara.MySqlType);
clsCheckSql.CheckFieldLen(objvCMFuncParaEN.ParameterTypeFullName, 500, convCMFuncPara.ParameterTypeFullName);
clsCheckSql.CheckFieldLen(objvCMFuncParaEN.ParaCnName, 50, convCMFuncPara.ParaCnName);
clsCheckSql.CheckFieldLen(objvCMFuncParaEN.PrjId, 4, convCMFuncPara.PrjId);
clsCheckSql.CheckFieldLen(objvCMFuncParaEN.UpdDate, 20, convCMFuncPara.UpdDate);
clsCheckSql.CheckFieldLen(objvCMFuncParaEN.UpdUser, 20, convCMFuncPara.UpdUser);
clsCheckSql.CheckFieldLen(objvCMFuncParaEN.Memo, 1000, convCMFuncPara.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvCMFuncParaEN.CmFuncParaId, convCMFuncPara.CmFuncParaId);
clsCheckSql.CheckSqlInjection4Field(objvCMFuncParaEN.ParaName, convCMFuncPara.ParaName);
clsCheckSql.CheckSqlInjection4Field(objvCMFuncParaEN.ParaComments, convCMFuncPara.ParaComments);
clsCheckSql.CheckSqlInjection4Field(objvCMFuncParaEN.ParameterType, convCMFuncPara.ParameterType);
clsCheckSql.CheckSqlInjection4Field(objvCMFuncParaEN.DataTypeId, convCMFuncPara.DataTypeId);
clsCheckSql.CheckSqlInjection4Field(objvCMFuncParaEN.DataTypeName, convCMFuncPara.DataTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCMFuncParaEN.DataCnName, convCMFuncPara.DataCnName);
clsCheckSql.CheckSqlInjection4Field(objvCMFuncParaEN.CsType, convCMFuncPara.CsType);
clsCheckSql.CheckSqlInjection4Field(objvCMFuncParaEN.JavaType, convCMFuncPara.JavaType);
clsCheckSql.CheckSqlInjection4Field(objvCMFuncParaEN.JavaObjType, convCMFuncPara.JavaObjType);
clsCheckSql.CheckSqlInjection4Field(objvCMFuncParaEN.SwiftType, convCMFuncPara.SwiftType);
clsCheckSql.CheckSqlInjection4Field(objvCMFuncParaEN.OraDbType, convCMFuncPara.OraDbType);
clsCheckSql.CheckSqlInjection4Field(objvCMFuncParaEN.MySqlType, convCMFuncPara.MySqlType);
clsCheckSql.CheckSqlInjection4Field(objvCMFuncParaEN.ParameterTypeFullName, convCMFuncPara.ParameterTypeFullName);
clsCheckSql.CheckSqlInjection4Field(objvCMFuncParaEN.ParaCnName, convCMFuncPara.ParaCnName);
clsCheckSql.CheckSqlInjection4Field(objvCMFuncParaEN.PrjId, convCMFuncPara.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvCMFuncParaEN.UpdDate, convCMFuncPara.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvCMFuncParaEN.UpdUser, convCMFuncPara.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvCMFuncParaEN.Memo, convCMFuncPara.Memo);
//检查外键字段长度
 objvCMFuncParaEN._IsCheckProperty = true;
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
 objSQL = clsvCMFuncParaDA.GetSpecSQLObj();
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
 objSQL = clsvCMFuncParaDA.GetSpecSQLObj();
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
 objSQL = clsvCMFuncParaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCMFuncParaEN._CurrTabName);
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
 objSQL = clsvCMFuncParaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCMFuncParaEN._CurrTabName, strCondition);
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
 objSQL = clsvCMFuncParaDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}