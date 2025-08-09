
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDataTypeAbbrDA
 表名:DataTypeAbbr(00050023)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:09:43
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统参数(SysPara)
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
 /// 数据类型(DataTypeAbbr)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsDataTypeAbbrDA : clsCommBase4DA
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
 return clsDataTypeAbbrEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsDataTypeAbbrEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsDataTypeAbbrEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsDataTypeAbbrEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsDataTypeAbbrEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strDataTypeId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strDataTypeId)
{
strDataTypeId = strDataTypeId.Replace("'", "''");
if (strDataTypeId.Length > 2)
{
throw new Exception("(errid:Data000001)在表:DataTypeAbbr中,检查关键字,长度不正确!(clsDataTypeAbbrDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strDataTypeId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:DataTypeAbbr中,关键字不能为空 或 null!(clsDataTypeAbbrDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strDataTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsDataTypeAbbrDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsDataTypeAbbrDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataTypeAbbrDA.GetSpecSQLObj();
strSQL = "Select * from DataTypeAbbr where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_DataTypeAbbr(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsDataTypeAbbrDA: GetDataTable_DataTypeAbbr)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataTypeAbbrDA.GetSpecSQLObj();
strSQL = "Select * from DataTypeAbbr where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsDataTypeAbbrDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataTypeAbbrDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsDataTypeAbbrDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataTypeAbbrDA.GetSpecSQLObj();
strSQL = "Select * from DataTypeAbbr where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsDataTypeAbbrDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataTypeAbbrDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsDataTypeAbbrDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataTypeAbbrDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from DataTypeAbbr where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from DataTypeAbbr where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsDataTypeAbbrDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataTypeAbbrDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from DataTypeAbbr where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsDataTypeAbbrDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataTypeAbbrDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} DataTypeAbbr.* " + 
$"from DataTypeAbbr " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and DataTypeAbbr.DataTypeId not in " + 
$"(Select top {intTop_In} DataTypeAbbr.DataTypeId from DataTypeAbbr " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from DataTypeAbbr where {1} and DataTypeId not in (Select top {2} DataTypeId from DataTypeAbbr where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from DataTypeAbbr where {1} and DataTypeId not in (Select top {3} DataTypeId from DataTypeAbbr where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsDataTypeAbbrDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataTypeAbbrDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} DataTypeAbbr.* " + 
$"from DataTypeAbbr " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and DataTypeAbbr.DataTypeId not in " + 
$"(Select top {intTop_In} DataTypeAbbr.DataTypeId from DataTypeAbbr " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from DataTypeAbbr where {1} and DataTypeId not in (Select top {2} DataTypeId from DataTypeAbbr where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from DataTypeAbbr where {1} and DataTypeId not in (Select top {3} DataTypeId from DataTypeAbbr where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsDataTypeAbbrEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsDataTypeAbbrDA:GetObjLst)", objException.Message));
}
List<clsDataTypeAbbrEN> arrObjLst = new List<clsDataTypeAbbrEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataTypeAbbrDA.GetSpecSQLObj();
strSQL = "Select * from DataTypeAbbr where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataTypeAbbrEN objDataTypeAbbrEN = new clsDataTypeAbbrEN();
try
{
objDataTypeAbbrEN.DataTypeId = objRow[conDataTypeAbbr.DataTypeId].ToString().Trim(); //数据类型Id
objDataTypeAbbrEN.DataTypeName = objRow[conDataTypeAbbr.DataTypeName].ToString().Trim(); //数据类型名称
objDataTypeAbbrEN.DataTypeENName = objRow[conDataTypeAbbr.DataTypeENName] == DBNull.Value ? null : objRow[conDataTypeAbbr.DataTypeENName].ToString().Trim(); //DataTypeENName
objDataTypeAbbrEN.DataCnName = objRow[conDataTypeAbbr.DataCnName].ToString().Trim(); //数据类型中文名称
objDataTypeAbbrEN.DataTypeAbbr = objRow[conDataTypeAbbr.DataTypeAbbr].ToString().Trim(); //数据类型缩写
objDataTypeAbbrEN.NetSysType = objRow[conDataTypeAbbr.NetSysType].ToString().Trim(); //NET系统类型
objDataTypeAbbrEN.VbNetType = objRow[conDataTypeAbbr.VbNetType].ToString().Trim(); //VBNET类型
objDataTypeAbbrEN.CsType = objRow[conDataTypeAbbr.CsType].ToString().Trim(); //CS类型
objDataTypeAbbrEN.JavaType = objRow[conDataTypeAbbr.JavaType].ToString().Trim(); //JAVA类型
objDataTypeAbbrEN.TypeScriptType = objRow[conDataTypeAbbr.TypeScriptType] == DBNull.Value ? null : objRow[conDataTypeAbbr.TypeScriptType].ToString().Trim(); //TypeScript类型
objDataTypeAbbrEN.JavaObjType = objRow[conDataTypeAbbr.JavaObjType] == DBNull.Value ? null : objRow[conDataTypeAbbr.JavaObjType].ToString().Trim(); //JAVA对象类型
objDataTypeAbbrEN.SwiftType = objRow[conDataTypeAbbr.SwiftType] == DBNull.Value ? null : objRow[conDataTypeAbbr.SwiftType].ToString().Trim(); //SwiftType
objDataTypeAbbrEN.IsNeedQuote = TransNullToBool(objRow[conDataTypeAbbr.IsNeedQuote].ToString().Trim()); //是否需要引号
objDataTypeAbbrEN.OraDbType = objRow[conDataTypeAbbr.OraDbType] == DBNull.Value ? null : objRow[conDataTypeAbbr.OraDbType].ToString().Trim(); //Ora数据类型
objDataTypeAbbrEN.IsReturnType = TransNullToBool(objRow[conDataTypeAbbr.IsReturnType].ToString().Trim()); //是否可作返回类型
objDataTypeAbbrEN.SqlParaType = objRow[conDataTypeAbbr.SqlParaType] == DBNull.Value ? null : objRow[conDataTypeAbbr.SqlParaType].ToString().Trim(); //SQL参数类型
objDataTypeAbbrEN.MySqlType = objRow[conDataTypeAbbr.MySqlType] == DBNull.Value ? null : objRow[conDataTypeAbbr.MySqlType].ToString().Trim(); //MySqlType
objDataTypeAbbrEN.DefaFldLength = objRow[conDataTypeAbbr.DefaFldLength] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDataTypeAbbr.DefaFldLength].ToString().Trim()); //默认长度
objDataTypeAbbrEN.DefaFldPrecision = objRow[conDataTypeAbbr.DefaFldPrecision] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDataTypeAbbr.DefaFldPrecision].ToString().Trim()); //默认小数位数
objDataTypeAbbrEN.Memo = objRow[conDataTypeAbbr.Memo] == DBNull.Value ? null : objRow[conDataTypeAbbr.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsDataTypeAbbrDA: GetObjLst)", objException.Message));
}
objDataTypeAbbrEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objDataTypeAbbrEN);
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
public List<clsDataTypeAbbrEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsDataTypeAbbrDA:GetObjLstByTabName)", objException.Message));
}
List<clsDataTypeAbbrEN> arrObjLst = new List<clsDataTypeAbbrEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataTypeAbbrDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataTypeAbbrEN objDataTypeAbbrEN = new clsDataTypeAbbrEN();
try
{
objDataTypeAbbrEN.DataTypeId = objRow[conDataTypeAbbr.DataTypeId].ToString().Trim(); //数据类型Id
objDataTypeAbbrEN.DataTypeName = objRow[conDataTypeAbbr.DataTypeName].ToString().Trim(); //数据类型名称
objDataTypeAbbrEN.DataTypeENName = objRow[conDataTypeAbbr.DataTypeENName] == DBNull.Value ? null : objRow[conDataTypeAbbr.DataTypeENName].ToString().Trim(); //DataTypeENName
objDataTypeAbbrEN.DataCnName = objRow[conDataTypeAbbr.DataCnName].ToString().Trim(); //数据类型中文名称
objDataTypeAbbrEN.DataTypeAbbr = objRow[conDataTypeAbbr.DataTypeAbbr].ToString().Trim(); //数据类型缩写
objDataTypeAbbrEN.NetSysType = objRow[conDataTypeAbbr.NetSysType].ToString().Trim(); //NET系统类型
objDataTypeAbbrEN.VbNetType = objRow[conDataTypeAbbr.VbNetType].ToString().Trim(); //VBNET类型
objDataTypeAbbrEN.CsType = objRow[conDataTypeAbbr.CsType].ToString().Trim(); //CS类型
objDataTypeAbbrEN.JavaType = objRow[conDataTypeAbbr.JavaType].ToString().Trim(); //JAVA类型
objDataTypeAbbrEN.TypeScriptType = objRow[conDataTypeAbbr.TypeScriptType] == DBNull.Value ? null : objRow[conDataTypeAbbr.TypeScriptType].ToString().Trim(); //TypeScript类型
objDataTypeAbbrEN.JavaObjType = objRow[conDataTypeAbbr.JavaObjType] == DBNull.Value ? null : objRow[conDataTypeAbbr.JavaObjType].ToString().Trim(); //JAVA对象类型
objDataTypeAbbrEN.SwiftType = objRow[conDataTypeAbbr.SwiftType] == DBNull.Value ? null : objRow[conDataTypeAbbr.SwiftType].ToString().Trim(); //SwiftType
objDataTypeAbbrEN.IsNeedQuote = TransNullToBool(objRow[conDataTypeAbbr.IsNeedQuote].ToString().Trim()); //是否需要引号
objDataTypeAbbrEN.OraDbType = objRow[conDataTypeAbbr.OraDbType] == DBNull.Value ? null : objRow[conDataTypeAbbr.OraDbType].ToString().Trim(); //Ora数据类型
objDataTypeAbbrEN.IsReturnType = TransNullToBool(objRow[conDataTypeAbbr.IsReturnType].ToString().Trim()); //是否可作返回类型
objDataTypeAbbrEN.SqlParaType = objRow[conDataTypeAbbr.SqlParaType] == DBNull.Value ? null : objRow[conDataTypeAbbr.SqlParaType].ToString().Trim(); //SQL参数类型
objDataTypeAbbrEN.MySqlType = objRow[conDataTypeAbbr.MySqlType] == DBNull.Value ? null : objRow[conDataTypeAbbr.MySqlType].ToString().Trim(); //MySqlType
objDataTypeAbbrEN.DefaFldLength = objRow[conDataTypeAbbr.DefaFldLength] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDataTypeAbbr.DefaFldLength].ToString().Trim()); //默认长度
objDataTypeAbbrEN.DefaFldPrecision = objRow[conDataTypeAbbr.DefaFldPrecision] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDataTypeAbbr.DefaFldPrecision].ToString().Trim()); //默认小数位数
objDataTypeAbbrEN.Memo = objRow[conDataTypeAbbr.Memo] == DBNull.Value ? null : objRow[conDataTypeAbbr.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsDataTypeAbbrDA: GetObjLst)", objException.Message));
}
objDataTypeAbbrEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objDataTypeAbbrEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objDataTypeAbbrEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetDataTypeAbbr(ref clsDataTypeAbbrEN objDataTypeAbbrEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataTypeAbbrDA.GetSpecSQLObj();
strSQL = "Select * from DataTypeAbbr where DataTypeId = " + "'"+ objDataTypeAbbrEN.DataTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objDataTypeAbbrEN.DataTypeId = objDT.Rows[0][conDataTypeAbbr.DataTypeId].ToString().Trim(); //数据类型Id(字段类型:char,字段长度:2,是否可空:False)
 objDataTypeAbbrEN.DataTypeName = objDT.Rows[0][conDataTypeAbbr.DataTypeName].ToString().Trim(); //数据类型名称(字段类型:varchar,字段长度:100,是否可空:True)
 objDataTypeAbbrEN.DataTypeENName = objDT.Rows[0][conDataTypeAbbr.DataTypeENName].ToString().Trim(); //DataTypeENName(字段类型:varchar,字段长度:100,是否可空:True)
 objDataTypeAbbrEN.DataCnName = objDT.Rows[0][conDataTypeAbbr.DataCnName].ToString().Trim(); //数据类型中文名称(字段类型:varchar,字段长度:100,是否可空:False)
 objDataTypeAbbrEN.DataTypeAbbr = objDT.Rows[0][conDataTypeAbbr.DataTypeAbbr].ToString().Trim(); //数据类型缩写(字段类型:varchar,字段长度:5,是否可空:False)
 objDataTypeAbbrEN.NetSysType = objDT.Rows[0][conDataTypeAbbr.NetSysType].ToString().Trim(); //NET系统类型(字段类型:varchar,字段长度:20,是否可空:False)
 objDataTypeAbbrEN.VbNetType = objDT.Rows[0][conDataTypeAbbr.VbNetType].ToString().Trim(); //VBNET类型(字段类型:varchar,字段长度:100,是否可空:False)
 objDataTypeAbbrEN.CsType = objDT.Rows[0][conDataTypeAbbr.CsType].ToString().Trim(); //CS类型(字段类型:varchar,字段长度:100,是否可空:False)
 objDataTypeAbbrEN.JavaType = objDT.Rows[0][conDataTypeAbbr.JavaType].ToString().Trim(); //JAVA类型(字段类型:varchar,字段长度:100,是否可空:False)
 objDataTypeAbbrEN.TypeScriptType = objDT.Rows[0][conDataTypeAbbr.TypeScriptType].ToString().Trim(); //TypeScript类型(字段类型:varchar,字段长度:100,是否可空:True)
 objDataTypeAbbrEN.JavaObjType = objDT.Rows[0][conDataTypeAbbr.JavaObjType].ToString().Trim(); //JAVA对象类型(字段类型:varchar,字段长度:100,是否可空:True)
 objDataTypeAbbrEN.SwiftType = objDT.Rows[0][conDataTypeAbbr.SwiftType].ToString().Trim(); //SwiftType(字段类型:varchar,字段长度:100,是否可空:True)
 objDataTypeAbbrEN.IsNeedQuote = TransNullToBool(objDT.Rows[0][conDataTypeAbbr.IsNeedQuote].ToString().Trim()); //是否需要引号(字段类型:bit,字段长度:1,是否可空:False)
 objDataTypeAbbrEN.OraDbType = objDT.Rows[0][conDataTypeAbbr.OraDbType].ToString().Trim(); //Ora数据类型(字段类型:varchar,字段长度:100,是否可空:False)
 objDataTypeAbbrEN.IsReturnType = TransNullToBool(objDT.Rows[0][conDataTypeAbbr.IsReturnType].ToString().Trim()); //是否可作返回类型(字段类型:bit,字段长度:1,是否可空:True)
 objDataTypeAbbrEN.SqlParaType = objDT.Rows[0][conDataTypeAbbr.SqlParaType].ToString().Trim(); //SQL参数类型(字段类型:varchar,字段长度:100,是否可空:True)
 objDataTypeAbbrEN.MySqlType = objDT.Rows[0][conDataTypeAbbr.MySqlType].ToString().Trim(); //MySqlType(字段类型:varchar,字段长度:100,是否可空:True)
 objDataTypeAbbrEN.DefaFldLength = TransNullToInt(objDT.Rows[0][conDataTypeAbbr.DefaFldLength].ToString().Trim()); //默认长度(字段类型:int,字段长度:4,是否可空:True)
 objDataTypeAbbrEN.DefaFldPrecision = TransNullToInt(objDT.Rows[0][conDataTypeAbbr.DefaFldPrecision].ToString().Trim()); //默认小数位数(字段类型:int,字段长度:4,是否可空:True)
 objDataTypeAbbrEN.Memo = objDT.Rows[0][conDataTypeAbbr.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsDataTypeAbbrDA: GetDataTypeAbbr)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strDataTypeId">表关键字</param>
 /// <returns>表对象</returns>
public clsDataTypeAbbrEN GetObjByDataTypeId(string strDataTypeId)
{
CheckPrimaryKey(strDataTypeId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataTypeAbbrDA.GetSpecSQLObj();
strSQL = "Select * from DataTypeAbbr where DataTypeId = " + "'"+ strDataTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsDataTypeAbbrEN objDataTypeAbbrEN = new clsDataTypeAbbrEN();
try
{
 objDataTypeAbbrEN.DataTypeId = objRow[conDataTypeAbbr.DataTypeId].ToString().Trim(); //数据类型Id(字段类型:char,字段长度:2,是否可空:False)
 objDataTypeAbbrEN.DataTypeName = objRow[conDataTypeAbbr.DataTypeName].ToString().Trim(); //数据类型名称(字段类型:varchar,字段长度:100,是否可空:True)
 objDataTypeAbbrEN.DataTypeENName = objRow[conDataTypeAbbr.DataTypeENName] == DBNull.Value ? null : objRow[conDataTypeAbbr.DataTypeENName].ToString().Trim(); //DataTypeENName(字段类型:varchar,字段长度:100,是否可空:True)
 objDataTypeAbbrEN.DataCnName = objRow[conDataTypeAbbr.DataCnName].ToString().Trim(); //数据类型中文名称(字段类型:varchar,字段长度:100,是否可空:False)
 objDataTypeAbbrEN.DataTypeAbbr = objRow[conDataTypeAbbr.DataTypeAbbr].ToString().Trim(); //数据类型缩写(字段类型:varchar,字段长度:5,是否可空:False)
 objDataTypeAbbrEN.NetSysType = objRow[conDataTypeAbbr.NetSysType].ToString().Trim(); //NET系统类型(字段类型:varchar,字段长度:20,是否可空:False)
 objDataTypeAbbrEN.VbNetType = objRow[conDataTypeAbbr.VbNetType].ToString().Trim(); //VBNET类型(字段类型:varchar,字段长度:100,是否可空:False)
 objDataTypeAbbrEN.CsType = objRow[conDataTypeAbbr.CsType].ToString().Trim(); //CS类型(字段类型:varchar,字段长度:100,是否可空:False)
 objDataTypeAbbrEN.JavaType = objRow[conDataTypeAbbr.JavaType].ToString().Trim(); //JAVA类型(字段类型:varchar,字段长度:100,是否可空:False)
 objDataTypeAbbrEN.TypeScriptType = objRow[conDataTypeAbbr.TypeScriptType] == DBNull.Value ? null : objRow[conDataTypeAbbr.TypeScriptType].ToString().Trim(); //TypeScript类型(字段类型:varchar,字段长度:100,是否可空:True)
 objDataTypeAbbrEN.JavaObjType = objRow[conDataTypeAbbr.JavaObjType] == DBNull.Value ? null : objRow[conDataTypeAbbr.JavaObjType].ToString().Trim(); //JAVA对象类型(字段类型:varchar,字段长度:100,是否可空:True)
 objDataTypeAbbrEN.SwiftType = objRow[conDataTypeAbbr.SwiftType] == DBNull.Value ? null : objRow[conDataTypeAbbr.SwiftType].ToString().Trim(); //SwiftType(字段类型:varchar,字段长度:100,是否可空:True)
 objDataTypeAbbrEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[conDataTypeAbbr.IsNeedQuote].ToString().Trim()); //是否需要引号(字段类型:bit,字段长度:1,是否可空:False)
 objDataTypeAbbrEN.OraDbType = objRow[conDataTypeAbbr.OraDbType] == DBNull.Value ? null : objRow[conDataTypeAbbr.OraDbType].ToString().Trim(); //Ora数据类型(字段类型:varchar,字段长度:100,是否可空:False)
 objDataTypeAbbrEN.IsReturnType = clsEntityBase2.TransNullToBool_S(objRow[conDataTypeAbbr.IsReturnType].ToString().Trim()); //是否可作返回类型(字段类型:bit,字段长度:1,是否可空:True)
 objDataTypeAbbrEN.SqlParaType = objRow[conDataTypeAbbr.SqlParaType] == DBNull.Value ? null : objRow[conDataTypeAbbr.SqlParaType].ToString().Trim(); //SQL参数类型(字段类型:varchar,字段长度:100,是否可空:True)
 objDataTypeAbbrEN.MySqlType = objRow[conDataTypeAbbr.MySqlType] == DBNull.Value ? null : objRow[conDataTypeAbbr.MySqlType].ToString().Trim(); //MySqlType(字段类型:varchar,字段长度:100,是否可空:True)
 objDataTypeAbbrEN.DefaFldLength = objRow[conDataTypeAbbr.DefaFldLength] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataTypeAbbr.DefaFldLength].ToString().Trim()); //默认长度(字段类型:int,字段长度:4,是否可空:True)
 objDataTypeAbbrEN.DefaFldPrecision = objRow[conDataTypeAbbr.DefaFldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataTypeAbbr.DefaFldPrecision].ToString().Trim()); //默认小数位数(字段类型:int,字段长度:4,是否可空:True)
 objDataTypeAbbrEN.Memo = objRow[conDataTypeAbbr.Memo] == DBNull.Value ? null : objRow[conDataTypeAbbr.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsDataTypeAbbrDA: GetObjByDataTypeId)", objException.Message));
}
return objDataTypeAbbrEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsDataTypeAbbrEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsDataTypeAbbrDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataTypeAbbrDA.GetSpecSQLObj();
strSQL = "Select * from DataTypeAbbr where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsDataTypeAbbrEN objDataTypeAbbrEN = new clsDataTypeAbbrEN()
{
DataTypeId = objRow[conDataTypeAbbr.DataTypeId].ToString().Trim(), //数据类型Id
DataTypeName = objRow[conDataTypeAbbr.DataTypeName].ToString().Trim(), //数据类型名称
DataTypeENName = objRow[conDataTypeAbbr.DataTypeENName] == DBNull.Value ? null : objRow[conDataTypeAbbr.DataTypeENName].ToString().Trim(), //DataTypeENName
DataCnName = objRow[conDataTypeAbbr.DataCnName].ToString().Trim(), //数据类型中文名称
DataTypeAbbr = objRow[conDataTypeAbbr.DataTypeAbbr].ToString().Trim(), //数据类型缩写
NetSysType = objRow[conDataTypeAbbr.NetSysType].ToString().Trim(), //NET系统类型
VbNetType = objRow[conDataTypeAbbr.VbNetType].ToString().Trim(), //VBNET类型
CsType = objRow[conDataTypeAbbr.CsType].ToString().Trim(), //CS类型
JavaType = objRow[conDataTypeAbbr.JavaType].ToString().Trim(), //JAVA类型
TypeScriptType = objRow[conDataTypeAbbr.TypeScriptType] == DBNull.Value ? null : objRow[conDataTypeAbbr.TypeScriptType].ToString().Trim(), //TypeScript类型
JavaObjType = objRow[conDataTypeAbbr.JavaObjType] == DBNull.Value ? null : objRow[conDataTypeAbbr.JavaObjType].ToString().Trim(), //JAVA对象类型
SwiftType = objRow[conDataTypeAbbr.SwiftType] == DBNull.Value ? null : objRow[conDataTypeAbbr.SwiftType].ToString().Trim(), //SwiftType
IsNeedQuote = TransNullToBool(objRow[conDataTypeAbbr.IsNeedQuote].ToString().Trim()), //是否需要引号
OraDbType = objRow[conDataTypeAbbr.OraDbType] == DBNull.Value ? null : objRow[conDataTypeAbbr.OraDbType].ToString().Trim(), //Ora数据类型
IsReturnType = TransNullToBool(objRow[conDataTypeAbbr.IsReturnType].ToString().Trim()), //是否可作返回类型
SqlParaType = objRow[conDataTypeAbbr.SqlParaType] == DBNull.Value ? null : objRow[conDataTypeAbbr.SqlParaType].ToString().Trim(), //SQL参数类型
MySqlType = objRow[conDataTypeAbbr.MySqlType] == DBNull.Value ? null : objRow[conDataTypeAbbr.MySqlType].ToString().Trim(), //MySqlType
DefaFldLength = objRow[conDataTypeAbbr.DefaFldLength] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDataTypeAbbr.DefaFldLength].ToString().Trim()), //默认长度
DefaFldPrecision = objRow[conDataTypeAbbr.DefaFldPrecision] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDataTypeAbbr.DefaFldPrecision].ToString().Trim()), //默认小数位数
Memo = objRow[conDataTypeAbbr.Memo] == DBNull.Value ? null : objRow[conDataTypeAbbr.Memo].ToString().Trim() //说明
};
objDataTypeAbbrEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objDataTypeAbbrEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsDataTypeAbbrDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsDataTypeAbbrEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsDataTypeAbbrEN objDataTypeAbbrEN = new clsDataTypeAbbrEN();
try
{
objDataTypeAbbrEN.DataTypeId = objRow[conDataTypeAbbr.DataTypeId].ToString().Trim(); //数据类型Id
objDataTypeAbbrEN.DataTypeName = objRow[conDataTypeAbbr.DataTypeName].ToString().Trim(); //数据类型名称
objDataTypeAbbrEN.DataTypeENName = objRow[conDataTypeAbbr.DataTypeENName] == DBNull.Value ? null : objRow[conDataTypeAbbr.DataTypeENName].ToString().Trim(); //DataTypeENName
objDataTypeAbbrEN.DataCnName = objRow[conDataTypeAbbr.DataCnName].ToString().Trim(); //数据类型中文名称
objDataTypeAbbrEN.DataTypeAbbr = objRow[conDataTypeAbbr.DataTypeAbbr].ToString().Trim(); //数据类型缩写
objDataTypeAbbrEN.NetSysType = objRow[conDataTypeAbbr.NetSysType].ToString().Trim(); //NET系统类型
objDataTypeAbbrEN.VbNetType = objRow[conDataTypeAbbr.VbNetType].ToString().Trim(); //VBNET类型
objDataTypeAbbrEN.CsType = objRow[conDataTypeAbbr.CsType].ToString().Trim(); //CS类型
objDataTypeAbbrEN.JavaType = objRow[conDataTypeAbbr.JavaType].ToString().Trim(); //JAVA类型
objDataTypeAbbrEN.TypeScriptType = objRow[conDataTypeAbbr.TypeScriptType] == DBNull.Value ? null : objRow[conDataTypeAbbr.TypeScriptType].ToString().Trim(); //TypeScript类型
objDataTypeAbbrEN.JavaObjType = objRow[conDataTypeAbbr.JavaObjType] == DBNull.Value ? null : objRow[conDataTypeAbbr.JavaObjType].ToString().Trim(); //JAVA对象类型
objDataTypeAbbrEN.SwiftType = objRow[conDataTypeAbbr.SwiftType] == DBNull.Value ? null : objRow[conDataTypeAbbr.SwiftType].ToString().Trim(); //SwiftType
objDataTypeAbbrEN.IsNeedQuote = TransNullToBool(objRow[conDataTypeAbbr.IsNeedQuote].ToString().Trim()); //是否需要引号
objDataTypeAbbrEN.OraDbType = objRow[conDataTypeAbbr.OraDbType] == DBNull.Value ? null : objRow[conDataTypeAbbr.OraDbType].ToString().Trim(); //Ora数据类型
objDataTypeAbbrEN.IsReturnType = TransNullToBool(objRow[conDataTypeAbbr.IsReturnType].ToString().Trim()); //是否可作返回类型
objDataTypeAbbrEN.SqlParaType = objRow[conDataTypeAbbr.SqlParaType] == DBNull.Value ? null : objRow[conDataTypeAbbr.SqlParaType].ToString().Trim(); //SQL参数类型
objDataTypeAbbrEN.MySqlType = objRow[conDataTypeAbbr.MySqlType] == DBNull.Value ? null : objRow[conDataTypeAbbr.MySqlType].ToString().Trim(); //MySqlType
objDataTypeAbbrEN.DefaFldLength = objRow[conDataTypeAbbr.DefaFldLength] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDataTypeAbbr.DefaFldLength].ToString().Trim()); //默认长度
objDataTypeAbbrEN.DefaFldPrecision = objRow[conDataTypeAbbr.DefaFldPrecision] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDataTypeAbbr.DefaFldPrecision].ToString().Trim()); //默认小数位数
objDataTypeAbbrEN.Memo = objRow[conDataTypeAbbr.Memo] == DBNull.Value ? null : objRow[conDataTypeAbbr.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsDataTypeAbbrDA: GetObjByDataRowDataTypeAbbr)", objException.Message));
}
objDataTypeAbbrEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objDataTypeAbbrEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsDataTypeAbbrEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsDataTypeAbbrEN objDataTypeAbbrEN = new clsDataTypeAbbrEN();
try
{
objDataTypeAbbrEN.DataTypeId = objRow[conDataTypeAbbr.DataTypeId].ToString().Trim(); //数据类型Id
objDataTypeAbbrEN.DataTypeName = objRow[conDataTypeAbbr.DataTypeName].ToString().Trim(); //数据类型名称
objDataTypeAbbrEN.DataTypeENName = objRow[conDataTypeAbbr.DataTypeENName] == DBNull.Value ? null : objRow[conDataTypeAbbr.DataTypeENName].ToString().Trim(); //DataTypeENName
objDataTypeAbbrEN.DataCnName = objRow[conDataTypeAbbr.DataCnName].ToString().Trim(); //数据类型中文名称
objDataTypeAbbrEN.DataTypeAbbr = objRow[conDataTypeAbbr.DataTypeAbbr].ToString().Trim(); //数据类型缩写
objDataTypeAbbrEN.NetSysType = objRow[conDataTypeAbbr.NetSysType].ToString().Trim(); //NET系统类型
objDataTypeAbbrEN.VbNetType = objRow[conDataTypeAbbr.VbNetType].ToString().Trim(); //VBNET类型
objDataTypeAbbrEN.CsType = objRow[conDataTypeAbbr.CsType].ToString().Trim(); //CS类型
objDataTypeAbbrEN.JavaType = objRow[conDataTypeAbbr.JavaType].ToString().Trim(); //JAVA类型
objDataTypeAbbrEN.TypeScriptType = objRow[conDataTypeAbbr.TypeScriptType] == DBNull.Value ? null : objRow[conDataTypeAbbr.TypeScriptType].ToString().Trim(); //TypeScript类型
objDataTypeAbbrEN.JavaObjType = objRow[conDataTypeAbbr.JavaObjType] == DBNull.Value ? null : objRow[conDataTypeAbbr.JavaObjType].ToString().Trim(); //JAVA对象类型
objDataTypeAbbrEN.SwiftType = objRow[conDataTypeAbbr.SwiftType] == DBNull.Value ? null : objRow[conDataTypeAbbr.SwiftType].ToString().Trim(); //SwiftType
objDataTypeAbbrEN.IsNeedQuote = TransNullToBool(objRow[conDataTypeAbbr.IsNeedQuote].ToString().Trim()); //是否需要引号
objDataTypeAbbrEN.OraDbType = objRow[conDataTypeAbbr.OraDbType] == DBNull.Value ? null : objRow[conDataTypeAbbr.OraDbType].ToString().Trim(); //Ora数据类型
objDataTypeAbbrEN.IsReturnType = TransNullToBool(objRow[conDataTypeAbbr.IsReturnType].ToString().Trim()); //是否可作返回类型
objDataTypeAbbrEN.SqlParaType = objRow[conDataTypeAbbr.SqlParaType] == DBNull.Value ? null : objRow[conDataTypeAbbr.SqlParaType].ToString().Trim(); //SQL参数类型
objDataTypeAbbrEN.MySqlType = objRow[conDataTypeAbbr.MySqlType] == DBNull.Value ? null : objRow[conDataTypeAbbr.MySqlType].ToString().Trim(); //MySqlType
objDataTypeAbbrEN.DefaFldLength = objRow[conDataTypeAbbr.DefaFldLength] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDataTypeAbbr.DefaFldLength].ToString().Trim()); //默认长度
objDataTypeAbbrEN.DefaFldPrecision = objRow[conDataTypeAbbr.DefaFldPrecision] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDataTypeAbbr.DefaFldPrecision].ToString().Trim()); //默认小数位数
objDataTypeAbbrEN.Memo = objRow[conDataTypeAbbr.Memo] == DBNull.Value ? null : objRow[conDataTypeAbbr.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsDataTypeAbbrDA: GetObjByDataRow)", objException.Message));
}
objDataTypeAbbrEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objDataTypeAbbrEN;
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
objSQL = clsDataTypeAbbrDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsDataTypeAbbrEN._CurrTabName, conDataTypeAbbr.DataTypeId, 2, "");
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
objSQL = clsDataTypeAbbrDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsDataTypeAbbrEN._CurrTabName, conDataTypeAbbr.DataTypeId, 2, strPrefix);
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
 objSQL = clsDataTypeAbbrDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select DataTypeId from DataTypeAbbr where " + strCondition;
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
 objSQL = clsDataTypeAbbrDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select DataTypeId from DataTypeAbbr where " + strCondition;
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
 /// <param name = "strDataTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strDataTypeId)
{
CheckPrimaryKey(strDataTypeId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataTypeAbbrDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("DataTypeAbbr", "DataTypeId = " + "'"+ strDataTypeId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsDataTypeAbbrDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataTypeAbbrDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("DataTypeAbbr", strCondition))
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
objSQL = clsDataTypeAbbrDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("DataTypeAbbr");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsDataTypeAbbrEN objDataTypeAbbrEN)
 {
 if (objDataTypeAbbrEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDataTypeAbbrEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataTypeAbbrDA.GetSpecSQLObj();
strSQL = "Select * from DataTypeAbbr where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "DataTypeAbbr");
objRow = objDS.Tables["DataTypeAbbr"].NewRow();
objRow[conDataTypeAbbr.DataTypeId] = objDataTypeAbbrEN.DataTypeId; //数据类型Id
objRow[conDataTypeAbbr.DataTypeName] = objDataTypeAbbrEN.DataTypeName; //数据类型名称
 if (objDataTypeAbbrEN.DataTypeENName !=  "")
 {
objRow[conDataTypeAbbr.DataTypeENName] = objDataTypeAbbrEN.DataTypeENName; //DataTypeENName
 }
objRow[conDataTypeAbbr.DataCnName] = objDataTypeAbbrEN.DataCnName; //数据类型中文名称
objRow[conDataTypeAbbr.DataTypeAbbr] = objDataTypeAbbrEN.DataTypeAbbr; //数据类型缩写
objRow[conDataTypeAbbr.NetSysType] = objDataTypeAbbrEN.NetSysType; //NET系统类型
objRow[conDataTypeAbbr.VbNetType] = objDataTypeAbbrEN.VbNetType; //VBNET类型
objRow[conDataTypeAbbr.CsType] = objDataTypeAbbrEN.CsType; //CS类型
objRow[conDataTypeAbbr.JavaType] = objDataTypeAbbrEN.JavaType; //JAVA类型
 if (objDataTypeAbbrEN.TypeScriptType !=  "")
 {
objRow[conDataTypeAbbr.TypeScriptType] = objDataTypeAbbrEN.TypeScriptType; //TypeScript类型
 }
 if (objDataTypeAbbrEN.JavaObjType !=  "")
 {
objRow[conDataTypeAbbr.JavaObjType] = objDataTypeAbbrEN.JavaObjType; //JAVA对象类型
 }
 if (objDataTypeAbbrEN.SwiftType !=  "")
 {
objRow[conDataTypeAbbr.SwiftType] = objDataTypeAbbrEN.SwiftType; //SwiftType
 }
objRow[conDataTypeAbbr.IsNeedQuote] = objDataTypeAbbrEN.IsNeedQuote; //是否需要引号
 if (objDataTypeAbbrEN.OraDbType !=  "")
 {
objRow[conDataTypeAbbr.OraDbType] = objDataTypeAbbrEN.OraDbType; //Ora数据类型
 }
objRow[conDataTypeAbbr.IsReturnType] = objDataTypeAbbrEN.IsReturnType; //是否可作返回类型
 if (objDataTypeAbbrEN.SqlParaType !=  "")
 {
objRow[conDataTypeAbbr.SqlParaType] = objDataTypeAbbrEN.SqlParaType; //SQL参数类型
 }
 if (objDataTypeAbbrEN.MySqlType !=  "")
 {
objRow[conDataTypeAbbr.MySqlType] = objDataTypeAbbrEN.MySqlType; //MySqlType
 }
objRow[conDataTypeAbbr.DefaFldLength] = objDataTypeAbbrEN.DefaFldLength; //默认长度
objRow[conDataTypeAbbr.DefaFldPrecision] = objDataTypeAbbrEN.DefaFldPrecision; //默认小数位数
 if (objDataTypeAbbrEN.Memo !=  "")
 {
objRow[conDataTypeAbbr.Memo] = objDataTypeAbbrEN.Memo; //说明
 }
objDS.Tables[clsDataTypeAbbrEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsDataTypeAbbrEN._CurrTabName);
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
 /// <param name = "objDataTypeAbbrEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsDataTypeAbbrEN objDataTypeAbbrEN)
{
 if (objDataTypeAbbrEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDataTypeAbbrEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objDataTypeAbbrEN.DataTypeId !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.DataTypeId);
 var strDataTypeId = objDataTypeAbbrEN.DataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataTypeId + "'");
 }
 
 if (objDataTypeAbbrEN.DataTypeName !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.DataTypeName);
 var strDataTypeName = objDataTypeAbbrEN.DataTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataTypeName + "'");
 }
 
 if (objDataTypeAbbrEN.DataTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.DataTypeENName);
 var strDataTypeENName = objDataTypeAbbrEN.DataTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataTypeENName + "'");
 }
 
 if (objDataTypeAbbrEN.DataCnName !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.DataCnName);
 var strDataCnName = objDataTypeAbbrEN.DataCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataCnName + "'");
 }
 
 if (objDataTypeAbbrEN.DataTypeAbbr !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.DataTypeAbbr);
 var strDataTypeAbbr = objDataTypeAbbrEN.DataTypeAbbr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataTypeAbbr + "'");
 }
 
 if (objDataTypeAbbrEN.NetSysType !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.NetSysType);
 var strNetSysType = objDataTypeAbbrEN.NetSysType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNetSysType + "'");
 }
 
 if (objDataTypeAbbrEN.VbNetType !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.VbNetType);
 var strVbNetType = objDataTypeAbbrEN.VbNetType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVbNetType + "'");
 }
 
 if (objDataTypeAbbrEN.CsType !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.CsType);
 var strCsType = objDataTypeAbbrEN.CsType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCsType + "'");
 }
 
 if (objDataTypeAbbrEN.JavaType !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.JavaType);
 var strJavaType = objDataTypeAbbrEN.JavaType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strJavaType + "'");
 }
 
 if (objDataTypeAbbrEN.TypeScriptType !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.TypeScriptType);
 var strTypeScriptType = objDataTypeAbbrEN.TypeScriptType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTypeScriptType + "'");
 }
 
 if (objDataTypeAbbrEN.JavaObjType !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.JavaObjType);
 var strJavaObjType = objDataTypeAbbrEN.JavaObjType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strJavaObjType + "'");
 }
 
 if (objDataTypeAbbrEN.SwiftType !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.SwiftType);
 var strSwiftType = objDataTypeAbbrEN.SwiftType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSwiftType + "'");
 }
 
 arrFieldListForInsert.Add(conDataTypeAbbr.IsNeedQuote);
 arrValueListForInsert.Add("'" + (objDataTypeAbbrEN.IsNeedQuote  ==  false ? "0" : "1") + "'");
 
 if (objDataTypeAbbrEN.OraDbType !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.OraDbType);
 var strOraDbType = objDataTypeAbbrEN.OraDbType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOraDbType + "'");
 }
 
 arrFieldListForInsert.Add(conDataTypeAbbr.IsReturnType);
 arrValueListForInsert.Add("'" + (objDataTypeAbbrEN.IsReturnType  ==  false ? "0" : "1") + "'");
 
 if (objDataTypeAbbrEN.SqlParaType !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.SqlParaType);
 var strSqlParaType = objDataTypeAbbrEN.SqlParaType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSqlParaType + "'");
 }
 
 if (objDataTypeAbbrEN.MySqlType !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.MySqlType);
 var strMySqlType = objDataTypeAbbrEN.MySqlType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMySqlType + "'");
 }
 
 if (objDataTypeAbbrEN.DefaFldLength !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.DefaFldLength);
 arrValueListForInsert.Add(objDataTypeAbbrEN.DefaFldLength.ToString());
 }
 
 if (objDataTypeAbbrEN.DefaFldPrecision !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.DefaFldPrecision);
 arrValueListForInsert.Add(objDataTypeAbbrEN.DefaFldPrecision.ToString());
 }
 
 if (objDataTypeAbbrEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.Memo);
 var strMemo = objDataTypeAbbrEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DataTypeAbbr");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataTypeAbbrDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objDataTypeAbbrEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsDataTypeAbbrEN objDataTypeAbbrEN)
{
 if (objDataTypeAbbrEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDataTypeAbbrEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objDataTypeAbbrEN.DataTypeId !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.DataTypeId);
 var strDataTypeId = objDataTypeAbbrEN.DataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataTypeId + "'");
 }
 
 if (objDataTypeAbbrEN.DataTypeName !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.DataTypeName);
 var strDataTypeName = objDataTypeAbbrEN.DataTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataTypeName + "'");
 }
 
 if (objDataTypeAbbrEN.DataTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.DataTypeENName);
 var strDataTypeENName = objDataTypeAbbrEN.DataTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataTypeENName + "'");
 }
 
 if (objDataTypeAbbrEN.DataCnName !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.DataCnName);
 var strDataCnName = objDataTypeAbbrEN.DataCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataCnName + "'");
 }
 
 if (objDataTypeAbbrEN.DataTypeAbbr !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.DataTypeAbbr);
 var strDataTypeAbbr = objDataTypeAbbrEN.DataTypeAbbr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataTypeAbbr + "'");
 }
 
 if (objDataTypeAbbrEN.NetSysType !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.NetSysType);
 var strNetSysType = objDataTypeAbbrEN.NetSysType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNetSysType + "'");
 }
 
 if (objDataTypeAbbrEN.VbNetType !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.VbNetType);
 var strVbNetType = objDataTypeAbbrEN.VbNetType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVbNetType + "'");
 }
 
 if (objDataTypeAbbrEN.CsType !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.CsType);
 var strCsType = objDataTypeAbbrEN.CsType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCsType + "'");
 }
 
 if (objDataTypeAbbrEN.JavaType !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.JavaType);
 var strJavaType = objDataTypeAbbrEN.JavaType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strJavaType + "'");
 }
 
 if (objDataTypeAbbrEN.TypeScriptType !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.TypeScriptType);
 var strTypeScriptType = objDataTypeAbbrEN.TypeScriptType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTypeScriptType + "'");
 }
 
 if (objDataTypeAbbrEN.JavaObjType !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.JavaObjType);
 var strJavaObjType = objDataTypeAbbrEN.JavaObjType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strJavaObjType + "'");
 }
 
 if (objDataTypeAbbrEN.SwiftType !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.SwiftType);
 var strSwiftType = objDataTypeAbbrEN.SwiftType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSwiftType + "'");
 }
 
 arrFieldListForInsert.Add(conDataTypeAbbr.IsNeedQuote);
 arrValueListForInsert.Add("'" + (objDataTypeAbbrEN.IsNeedQuote  ==  false ? "0" : "1") + "'");
 
 if (objDataTypeAbbrEN.OraDbType !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.OraDbType);
 var strOraDbType = objDataTypeAbbrEN.OraDbType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOraDbType + "'");
 }
 
 arrFieldListForInsert.Add(conDataTypeAbbr.IsReturnType);
 arrValueListForInsert.Add("'" + (objDataTypeAbbrEN.IsReturnType  ==  false ? "0" : "1") + "'");
 
 if (objDataTypeAbbrEN.SqlParaType !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.SqlParaType);
 var strSqlParaType = objDataTypeAbbrEN.SqlParaType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSqlParaType + "'");
 }
 
 if (objDataTypeAbbrEN.MySqlType !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.MySqlType);
 var strMySqlType = objDataTypeAbbrEN.MySqlType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMySqlType + "'");
 }
 
 if (objDataTypeAbbrEN.DefaFldLength !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.DefaFldLength);
 arrValueListForInsert.Add(objDataTypeAbbrEN.DefaFldLength.ToString());
 }
 
 if (objDataTypeAbbrEN.DefaFldPrecision !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.DefaFldPrecision);
 arrValueListForInsert.Add(objDataTypeAbbrEN.DefaFldPrecision.ToString());
 }
 
 if (objDataTypeAbbrEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.Memo);
 var strMemo = objDataTypeAbbrEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DataTypeAbbr");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataTypeAbbrDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objDataTypeAbbrEN.DataTypeId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objDataTypeAbbrEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsDataTypeAbbrEN objDataTypeAbbrEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objDataTypeAbbrEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDataTypeAbbrEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objDataTypeAbbrEN.DataTypeId !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.DataTypeId);
 var strDataTypeId = objDataTypeAbbrEN.DataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataTypeId + "'");
 }
 
 if (objDataTypeAbbrEN.DataTypeName !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.DataTypeName);
 var strDataTypeName = objDataTypeAbbrEN.DataTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataTypeName + "'");
 }
 
 if (objDataTypeAbbrEN.DataTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.DataTypeENName);
 var strDataTypeENName = objDataTypeAbbrEN.DataTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataTypeENName + "'");
 }
 
 if (objDataTypeAbbrEN.DataCnName !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.DataCnName);
 var strDataCnName = objDataTypeAbbrEN.DataCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataCnName + "'");
 }
 
 if (objDataTypeAbbrEN.DataTypeAbbr !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.DataTypeAbbr);
 var strDataTypeAbbr = objDataTypeAbbrEN.DataTypeAbbr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataTypeAbbr + "'");
 }
 
 if (objDataTypeAbbrEN.NetSysType !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.NetSysType);
 var strNetSysType = objDataTypeAbbrEN.NetSysType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNetSysType + "'");
 }
 
 if (objDataTypeAbbrEN.VbNetType !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.VbNetType);
 var strVbNetType = objDataTypeAbbrEN.VbNetType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVbNetType + "'");
 }
 
 if (objDataTypeAbbrEN.CsType !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.CsType);
 var strCsType = objDataTypeAbbrEN.CsType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCsType + "'");
 }
 
 if (objDataTypeAbbrEN.JavaType !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.JavaType);
 var strJavaType = objDataTypeAbbrEN.JavaType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strJavaType + "'");
 }
 
 if (objDataTypeAbbrEN.TypeScriptType !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.TypeScriptType);
 var strTypeScriptType = objDataTypeAbbrEN.TypeScriptType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTypeScriptType + "'");
 }
 
 if (objDataTypeAbbrEN.JavaObjType !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.JavaObjType);
 var strJavaObjType = objDataTypeAbbrEN.JavaObjType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strJavaObjType + "'");
 }
 
 if (objDataTypeAbbrEN.SwiftType !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.SwiftType);
 var strSwiftType = objDataTypeAbbrEN.SwiftType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSwiftType + "'");
 }
 
 arrFieldListForInsert.Add(conDataTypeAbbr.IsNeedQuote);
 arrValueListForInsert.Add("'" + (objDataTypeAbbrEN.IsNeedQuote  ==  false ? "0" : "1") + "'");
 
 if (objDataTypeAbbrEN.OraDbType !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.OraDbType);
 var strOraDbType = objDataTypeAbbrEN.OraDbType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOraDbType + "'");
 }
 
 arrFieldListForInsert.Add(conDataTypeAbbr.IsReturnType);
 arrValueListForInsert.Add("'" + (objDataTypeAbbrEN.IsReturnType  ==  false ? "0" : "1") + "'");
 
 if (objDataTypeAbbrEN.SqlParaType !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.SqlParaType);
 var strSqlParaType = objDataTypeAbbrEN.SqlParaType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSqlParaType + "'");
 }
 
 if (objDataTypeAbbrEN.MySqlType !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.MySqlType);
 var strMySqlType = objDataTypeAbbrEN.MySqlType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMySqlType + "'");
 }
 
 if (objDataTypeAbbrEN.DefaFldLength !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.DefaFldLength);
 arrValueListForInsert.Add(objDataTypeAbbrEN.DefaFldLength.ToString());
 }
 
 if (objDataTypeAbbrEN.DefaFldPrecision !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.DefaFldPrecision);
 arrValueListForInsert.Add(objDataTypeAbbrEN.DefaFldPrecision.ToString());
 }
 
 if (objDataTypeAbbrEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.Memo);
 var strMemo = objDataTypeAbbrEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DataTypeAbbr");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataTypeAbbrDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objDataTypeAbbrEN.DataTypeId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objDataTypeAbbrEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsDataTypeAbbrEN objDataTypeAbbrEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objDataTypeAbbrEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDataTypeAbbrEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objDataTypeAbbrEN.DataTypeId !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.DataTypeId);
 var strDataTypeId = objDataTypeAbbrEN.DataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataTypeId + "'");
 }
 
 if (objDataTypeAbbrEN.DataTypeName !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.DataTypeName);
 var strDataTypeName = objDataTypeAbbrEN.DataTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataTypeName + "'");
 }
 
 if (objDataTypeAbbrEN.DataTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.DataTypeENName);
 var strDataTypeENName = objDataTypeAbbrEN.DataTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataTypeENName + "'");
 }
 
 if (objDataTypeAbbrEN.DataCnName !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.DataCnName);
 var strDataCnName = objDataTypeAbbrEN.DataCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataCnName + "'");
 }
 
 if (objDataTypeAbbrEN.DataTypeAbbr !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.DataTypeAbbr);
 var strDataTypeAbbr = objDataTypeAbbrEN.DataTypeAbbr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataTypeAbbr + "'");
 }
 
 if (objDataTypeAbbrEN.NetSysType !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.NetSysType);
 var strNetSysType = objDataTypeAbbrEN.NetSysType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNetSysType + "'");
 }
 
 if (objDataTypeAbbrEN.VbNetType !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.VbNetType);
 var strVbNetType = objDataTypeAbbrEN.VbNetType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVbNetType + "'");
 }
 
 if (objDataTypeAbbrEN.CsType !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.CsType);
 var strCsType = objDataTypeAbbrEN.CsType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCsType + "'");
 }
 
 if (objDataTypeAbbrEN.JavaType !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.JavaType);
 var strJavaType = objDataTypeAbbrEN.JavaType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strJavaType + "'");
 }
 
 if (objDataTypeAbbrEN.TypeScriptType !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.TypeScriptType);
 var strTypeScriptType = objDataTypeAbbrEN.TypeScriptType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTypeScriptType + "'");
 }
 
 if (objDataTypeAbbrEN.JavaObjType !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.JavaObjType);
 var strJavaObjType = objDataTypeAbbrEN.JavaObjType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strJavaObjType + "'");
 }
 
 if (objDataTypeAbbrEN.SwiftType !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.SwiftType);
 var strSwiftType = objDataTypeAbbrEN.SwiftType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSwiftType + "'");
 }
 
 arrFieldListForInsert.Add(conDataTypeAbbr.IsNeedQuote);
 arrValueListForInsert.Add("'" + (objDataTypeAbbrEN.IsNeedQuote  ==  false ? "0" : "1") + "'");
 
 if (objDataTypeAbbrEN.OraDbType !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.OraDbType);
 var strOraDbType = objDataTypeAbbrEN.OraDbType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOraDbType + "'");
 }
 
 arrFieldListForInsert.Add(conDataTypeAbbr.IsReturnType);
 arrValueListForInsert.Add("'" + (objDataTypeAbbrEN.IsReturnType  ==  false ? "0" : "1") + "'");
 
 if (objDataTypeAbbrEN.SqlParaType !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.SqlParaType);
 var strSqlParaType = objDataTypeAbbrEN.SqlParaType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSqlParaType + "'");
 }
 
 if (objDataTypeAbbrEN.MySqlType !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.MySqlType);
 var strMySqlType = objDataTypeAbbrEN.MySqlType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMySqlType + "'");
 }
 
 if (objDataTypeAbbrEN.DefaFldLength !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.DefaFldLength);
 arrValueListForInsert.Add(objDataTypeAbbrEN.DefaFldLength.ToString());
 }
 
 if (objDataTypeAbbrEN.DefaFldPrecision !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.DefaFldPrecision);
 arrValueListForInsert.Add(objDataTypeAbbrEN.DefaFldPrecision.ToString());
 }
 
 if (objDataTypeAbbrEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDataTypeAbbr.Memo);
 var strMemo = objDataTypeAbbrEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DataTypeAbbr");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataTypeAbbrDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewDataTypeAbbrs(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataTypeAbbrDA.GetSpecSQLObj();
strSQL = "Select * from DataTypeAbbr where DataTypeId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "DataTypeAbbr");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strDataTypeId = oRow[conDataTypeAbbr.DataTypeId].ToString().Trim();
if (IsExist(strDataTypeId))
{
 string strResult = "关键字变量值为:" + string.Format("DataTypeId = {0}", strDataTypeId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsDataTypeAbbrEN._CurrTabName ].NewRow();
objRow[conDataTypeAbbr.DataTypeId] = oRow[conDataTypeAbbr.DataTypeId].ToString().Trim(); //数据类型Id
objRow[conDataTypeAbbr.DataTypeName] = oRow[conDataTypeAbbr.DataTypeName].ToString().Trim(); //数据类型名称
objRow[conDataTypeAbbr.DataTypeENName] = oRow[conDataTypeAbbr.DataTypeENName].ToString().Trim(); //DataTypeENName
objRow[conDataTypeAbbr.DataCnName] = oRow[conDataTypeAbbr.DataCnName].ToString().Trim(); //数据类型中文名称
objRow[conDataTypeAbbr.DataTypeAbbr] = oRow[conDataTypeAbbr.DataTypeAbbr].ToString().Trim(); //数据类型缩写
objRow[conDataTypeAbbr.NetSysType] = oRow[conDataTypeAbbr.NetSysType].ToString().Trim(); //NET系统类型
objRow[conDataTypeAbbr.VbNetType] = oRow[conDataTypeAbbr.VbNetType].ToString().Trim(); //VBNET类型
objRow[conDataTypeAbbr.CsType] = oRow[conDataTypeAbbr.CsType].ToString().Trim(); //CS类型
objRow[conDataTypeAbbr.JavaType] = oRow[conDataTypeAbbr.JavaType].ToString().Trim(); //JAVA类型
objRow[conDataTypeAbbr.TypeScriptType] = oRow[conDataTypeAbbr.TypeScriptType].ToString().Trim(); //TypeScript类型
objRow[conDataTypeAbbr.JavaObjType] = oRow[conDataTypeAbbr.JavaObjType].ToString().Trim(); //JAVA对象类型
objRow[conDataTypeAbbr.SwiftType] = oRow[conDataTypeAbbr.SwiftType].ToString().Trim(); //SwiftType
objRow[conDataTypeAbbr.IsNeedQuote] = oRow[conDataTypeAbbr.IsNeedQuote].ToString().Trim(); //是否需要引号
objRow[conDataTypeAbbr.OraDbType] = oRow[conDataTypeAbbr.OraDbType].ToString().Trim(); //Ora数据类型
objRow[conDataTypeAbbr.IsReturnType] = oRow[conDataTypeAbbr.IsReturnType].ToString().Trim(); //是否可作返回类型
objRow[conDataTypeAbbr.SqlParaType] = oRow[conDataTypeAbbr.SqlParaType].ToString().Trim(); //SQL参数类型
objRow[conDataTypeAbbr.MySqlType] = oRow[conDataTypeAbbr.MySqlType].ToString().Trim(); //MySqlType
objRow[conDataTypeAbbr.DefaFldLength] = oRow[conDataTypeAbbr.DefaFldLength].ToString().Trim(); //默认长度
objRow[conDataTypeAbbr.DefaFldPrecision] = oRow[conDataTypeAbbr.DefaFldPrecision].ToString().Trim(); //默认小数位数
objRow[conDataTypeAbbr.Memo] = oRow[conDataTypeAbbr.Memo].ToString().Trim(); //说明
 objDS.Tables[clsDataTypeAbbrEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsDataTypeAbbrEN._CurrTabName);
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
 /// <param name = "objDataTypeAbbrEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsDataTypeAbbrEN objDataTypeAbbrEN)
{
 if (objDataTypeAbbrEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDataTypeAbbrEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataTypeAbbrDA.GetSpecSQLObj();
strSQL = "Select * from DataTypeAbbr where DataTypeId = " + "'"+ objDataTypeAbbrEN.DataTypeId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsDataTypeAbbrEN._CurrTabName);
if (objDS.Tables[clsDataTypeAbbrEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:DataTypeId = " + "'"+ objDataTypeAbbrEN.DataTypeId+"'");
return false;
}
objRow = objDS.Tables[clsDataTypeAbbrEN._CurrTabName].Rows[0];
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.DataTypeId))
 {
objRow[conDataTypeAbbr.DataTypeId] = objDataTypeAbbrEN.DataTypeId; //数据类型Id
 }
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.DataTypeName))
 {
objRow[conDataTypeAbbr.DataTypeName] = objDataTypeAbbrEN.DataTypeName; //数据类型名称
 }
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.DataTypeENName))
 {
objRow[conDataTypeAbbr.DataTypeENName] = objDataTypeAbbrEN.DataTypeENName; //DataTypeENName
 }
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.DataCnName))
 {
objRow[conDataTypeAbbr.DataCnName] = objDataTypeAbbrEN.DataCnName; //数据类型中文名称
 }
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.DataTypeAbbr))
 {
objRow[conDataTypeAbbr.DataTypeAbbr] = objDataTypeAbbrEN.DataTypeAbbr; //数据类型缩写
 }
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.NetSysType))
 {
objRow[conDataTypeAbbr.NetSysType] = objDataTypeAbbrEN.NetSysType; //NET系统类型
 }
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.VbNetType))
 {
objRow[conDataTypeAbbr.VbNetType] = objDataTypeAbbrEN.VbNetType; //VBNET类型
 }
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.CsType))
 {
objRow[conDataTypeAbbr.CsType] = objDataTypeAbbrEN.CsType; //CS类型
 }
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.JavaType))
 {
objRow[conDataTypeAbbr.JavaType] = objDataTypeAbbrEN.JavaType; //JAVA类型
 }
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.TypeScriptType))
 {
objRow[conDataTypeAbbr.TypeScriptType] = objDataTypeAbbrEN.TypeScriptType; //TypeScript类型
 }
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.JavaObjType))
 {
objRow[conDataTypeAbbr.JavaObjType] = objDataTypeAbbrEN.JavaObjType; //JAVA对象类型
 }
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.SwiftType))
 {
objRow[conDataTypeAbbr.SwiftType] = objDataTypeAbbrEN.SwiftType; //SwiftType
 }
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.IsNeedQuote))
 {
objRow[conDataTypeAbbr.IsNeedQuote] = objDataTypeAbbrEN.IsNeedQuote; //是否需要引号
 }
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.OraDbType))
 {
objRow[conDataTypeAbbr.OraDbType] = objDataTypeAbbrEN.OraDbType; //Ora数据类型
 }
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.IsReturnType))
 {
objRow[conDataTypeAbbr.IsReturnType] = objDataTypeAbbrEN.IsReturnType; //是否可作返回类型
 }
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.SqlParaType))
 {
objRow[conDataTypeAbbr.SqlParaType] = objDataTypeAbbrEN.SqlParaType; //SQL参数类型
 }
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.MySqlType))
 {
objRow[conDataTypeAbbr.MySqlType] = objDataTypeAbbrEN.MySqlType; //MySqlType
 }
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.DefaFldLength))
 {
objRow[conDataTypeAbbr.DefaFldLength] = objDataTypeAbbrEN.DefaFldLength; //默认长度
 }
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.DefaFldPrecision))
 {
objRow[conDataTypeAbbr.DefaFldPrecision] = objDataTypeAbbrEN.DefaFldPrecision; //默认小数位数
 }
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.Memo))
 {
objRow[conDataTypeAbbr.Memo] = objDataTypeAbbrEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsDataTypeAbbrEN._CurrTabName);
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
 /// <param name = "objDataTypeAbbrEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsDataTypeAbbrEN objDataTypeAbbrEN)
{
 if (objDataTypeAbbrEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDataTypeAbbrEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataTypeAbbrDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update DataTypeAbbr Set ");
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.DataTypeName))
 {
 if (objDataTypeAbbrEN.DataTypeName !=  null)
 {
 var strDataTypeName = objDataTypeAbbrEN.DataTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataTypeName, conDataTypeAbbr.DataTypeName); //数据类型名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataTypeAbbr.DataTypeName); //数据类型名称
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.DataTypeENName))
 {
 if (objDataTypeAbbrEN.DataTypeENName !=  null)
 {
 var strDataTypeENName = objDataTypeAbbrEN.DataTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataTypeENName, conDataTypeAbbr.DataTypeENName); //DataTypeENName
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataTypeAbbr.DataTypeENName); //DataTypeENName
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.DataCnName))
 {
 if (objDataTypeAbbrEN.DataCnName !=  null)
 {
 var strDataCnName = objDataTypeAbbrEN.DataCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataCnName, conDataTypeAbbr.DataCnName); //数据类型中文名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataTypeAbbr.DataCnName); //数据类型中文名称
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.DataTypeAbbr))
 {
 if (objDataTypeAbbrEN.DataTypeAbbr !=  null)
 {
 var strDataTypeAbbr = objDataTypeAbbrEN.DataTypeAbbr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataTypeAbbr, conDataTypeAbbr.DataTypeAbbr); //数据类型缩写
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataTypeAbbr.DataTypeAbbr); //数据类型缩写
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.NetSysType))
 {
 if (objDataTypeAbbrEN.NetSysType !=  null)
 {
 var strNetSysType = objDataTypeAbbrEN.NetSysType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strNetSysType, conDataTypeAbbr.NetSysType); //NET系统类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataTypeAbbr.NetSysType); //NET系统类型
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.VbNetType))
 {
 if (objDataTypeAbbrEN.VbNetType !=  null)
 {
 var strVbNetType = objDataTypeAbbrEN.VbNetType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVbNetType, conDataTypeAbbr.VbNetType); //VBNET类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataTypeAbbr.VbNetType); //VBNET类型
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.CsType))
 {
 if (objDataTypeAbbrEN.CsType !=  null)
 {
 var strCsType = objDataTypeAbbrEN.CsType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCsType, conDataTypeAbbr.CsType); //CS类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataTypeAbbr.CsType); //CS类型
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.JavaType))
 {
 if (objDataTypeAbbrEN.JavaType !=  null)
 {
 var strJavaType = objDataTypeAbbrEN.JavaType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strJavaType, conDataTypeAbbr.JavaType); //JAVA类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataTypeAbbr.JavaType); //JAVA类型
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.TypeScriptType))
 {
 if (objDataTypeAbbrEN.TypeScriptType !=  null)
 {
 var strTypeScriptType = objDataTypeAbbrEN.TypeScriptType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTypeScriptType, conDataTypeAbbr.TypeScriptType); //TypeScript类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataTypeAbbr.TypeScriptType); //TypeScript类型
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.JavaObjType))
 {
 if (objDataTypeAbbrEN.JavaObjType !=  null)
 {
 var strJavaObjType = objDataTypeAbbrEN.JavaObjType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strJavaObjType, conDataTypeAbbr.JavaObjType); //JAVA对象类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataTypeAbbr.JavaObjType); //JAVA对象类型
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.SwiftType))
 {
 if (objDataTypeAbbrEN.SwiftType !=  null)
 {
 var strSwiftType = objDataTypeAbbrEN.SwiftType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSwiftType, conDataTypeAbbr.SwiftType); //SwiftType
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataTypeAbbr.SwiftType); //SwiftType
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.IsNeedQuote))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDataTypeAbbrEN.IsNeedQuote == true?"1":"0", conDataTypeAbbr.IsNeedQuote); //是否需要引号
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.OraDbType))
 {
 if (objDataTypeAbbrEN.OraDbType !=  null)
 {
 var strOraDbType = objDataTypeAbbrEN.OraDbType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOraDbType, conDataTypeAbbr.OraDbType); //Ora数据类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataTypeAbbr.OraDbType); //Ora数据类型
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.IsReturnType))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDataTypeAbbrEN.IsReturnType == true?"1":"0", conDataTypeAbbr.IsReturnType); //是否可作返回类型
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.SqlParaType))
 {
 if (objDataTypeAbbrEN.SqlParaType !=  null)
 {
 var strSqlParaType = objDataTypeAbbrEN.SqlParaType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSqlParaType, conDataTypeAbbr.SqlParaType); //SQL参数类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataTypeAbbr.SqlParaType); //SQL参数类型
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.MySqlType))
 {
 if (objDataTypeAbbrEN.MySqlType !=  null)
 {
 var strMySqlType = objDataTypeAbbrEN.MySqlType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMySqlType, conDataTypeAbbr.MySqlType); //MySqlType
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataTypeAbbr.MySqlType); //MySqlType
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.DefaFldLength))
 {
 if (objDataTypeAbbrEN.DefaFldLength !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDataTypeAbbrEN.DefaFldLength, conDataTypeAbbr.DefaFldLength); //默认长度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataTypeAbbr.DefaFldLength); //默认长度
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.DefaFldPrecision))
 {
 if (objDataTypeAbbrEN.DefaFldPrecision !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDataTypeAbbrEN.DefaFldPrecision, conDataTypeAbbr.DefaFldPrecision); //默认小数位数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataTypeAbbr.DefaFldPrecision); //默认小数位数
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.Memo))
 {
 if (objDataTypeAbbrEN.Memo !=  null)
 {
 var strMemo = objDataTypeAbbrEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conDataTypeAbbr.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataTypeAbbr.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where DataTypeId = '{0}'", objDataTypeAbbrEN.DataTypeId); 
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
 /// <param name = "objDataTypeAbbrEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsDataTypeAbbrEN objDataTypeAbbrEN, string strCondition)
{
 if (objDataTypeAbbrEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDataTypeAbbrEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataTypeAbbrDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update DataTypeAbbr Set ");
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.DataTypeName))
 {
 if (objDataTypeAbbrEN.DataTypeName !=  null)
 {
 var strDataTypeName = objDataTypeAbbrEN.DataTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataTypeName = '{0}',", strDataTypeName); //数据类型名称
 }
 else
 {
 sbSQL.Append(" DataTypeName = null,"); //数据类型名称
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.DataTypeENName))
 {
 if (objDataTypeAbbrEN.DataTypeENName !=  null)
 {
 var strDataTypeENName = objDataTypeAbbrEN.DataTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataTypeENName = '{0}',", strDataTypeENName); //DataTypeENName
 }
 else
 {
 sbSQL.Append(" DataTypeENName = null,"); //DataTypeENName
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.DataCnName))
 {
 if (objDataTypeAbbrEN.DataCnName !=  null)
 {
 var strDataCnName = objDataTypeAbbrEN.DataCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataCnName = '{0}',", strDataCnName); //数据类型中文名称
 }
 else
 {
 sbSQL.Append(" DataCnName = null,"); //数据类型中文名称
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.DataTypeAbbr))
 {
 if (objDataTypeAbbrEN.DataTypeAbbr !=  null)
 {
 var strDataTypeAbbr = objDataTypeAbbrEN.DataTypeAbbr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataTypeAbbr = '{0}',", strDataTypeAbbr); //数据类型缩写
 }
 else
 {
 sbSQL.Append(" DataTypeAbbr = null,"); //数据类型缩写
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.NetSysType))
 {
 if (objDataTypeAbbrEN.NetSysType !=  null)
 {
 var strNetSysType = objDataTypeAbbrEN.NetSysType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" NetSysType = '{0}',", strNetSysType); //NET系统类型
 }
 else
 {
 sbSQL.Append(" NetSysType = null,"); //NET系统类型
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.VbNetType))
 {
 if (objDataTypeAbbrEN.VbNetType !=  null)
 {
 var strVbNetType = objDataTypeAbbrEN.VbNetType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VbNetType = '{0}',", strVbNetType); //VBNET类型
 }
 else
 {
 sbSQL.Append(" VbNetType = null,"); //VBNET类型
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.CsType))
 {
 if (objDataTypeAbbrEN.CsType !=  null)
 {
 var strCsType = objDataTypeAbbrEN.CsType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CsType = '{0}',", strCsType); //CS类型
 }
 else
 {
 sbSQL.Append(" CsType = null,"); //CS类型
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.JavaType))
 {
 if (objDataTypeAbbrEN.JavaType !=  null)
 {
 var strJavaType = objDataTypeAbbrEN.JavaType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" JavaType = '{0}',", strJavaType); //JAVA类型
 }
 else
 {
 sbSQL.Append(" JavaType = null,"); //JAVA类型
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.TypeScriptType))
 {
 if (objDataTypeAbbrEN.TypeScriptType !=  null)
 {
 var strTypeScriptType = objDataTypeAbbrEN.TypeScriptType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TypeScriptType = '{0}',", strTypeScriptType); //TypeScript类型
 }
 else
 {
 sbSQL.Append(" TypeScriptType = null,"); //TypeScript类型
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.JavaObjType))
 {
 if (objDataTypeAbbrEN.JavaObjType !=  null)
 {
 var strJavaObjType = objDataTypeAbbrEN.JavaObjType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" JavaObjType = '{0}',", strJavaObjType); //JAVA对象类型
 }
 else
 {
 sbSQL.Append(" JavaObjType = null,"); //JAVA对象类型
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.SwiftType))
 {
 if (objDataTypeAbbrEN.SwiftType !=  null)
 {
 var strSwiftType = objDataTypeAbbrEN.SwiftType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SwiftType = '{0}',", strSwiftType); //SwiftType
 }
 else
 {
 sbSQL.Append(" SwiftType = null,"); //SwiftType
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.IsNeedQuote))
 {
 sbSQL.AppendFormat(" IsNeedQuote = '{0}',", objDataTypeAbbrEN.IsNeedQuote == true?"1":"0"); //是否需要引号
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.OraDbType))
 {
 if (objDataTypeAbbrEN.OraDbType !=  null)
 {
 var strOraDbType = objDataTypeAbbrEN.OraDbType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OraDbType = '{0}',", strOraDbType); //Ora数据类型
 }
 else
 {
 sbSQL.Append(" OraDbType = null,"); //Ora数据类型
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.IsReturnType))
 {
 sbSQL.AppendFormat(" IsReturnType = '{0}',", objDataTypeAbbrEN.IsReturnType == true?"1":"0"); //是否可作返回类型
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.SqlParaType))
 {
 if (objDataTypeAbbrEN.SqlParaType !=  null)
 {
 var strSqlParaType = objDataTypeAbbrEN.SqlParaType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SqlParaType = '{0}',", strSqlParaType); //SQL参数类型
 }
 else
 {
 sbSQL.Append(" SqlParaType = null,"); //SQL参数类型
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.MySqlType))
 {
 if (objDataTypeAbbrEN.MySqlType !=  null)
 {
 var strMySqlType = objDataTypeAbbrEN.MySqlType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MySqlType = '{0}',", strMySqlType); //MySqlType
 }
 else
 {
 sbSQL.Append(" MySqlType = null,"); //MySqlType
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.DefaFldLength))
 {
 if (objDataTypeAbbrEN.DefaFldLength !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDataTypeAbbrEN.DefaFldLength, conDataTypeAbbr.DefaFldLength); //默认长度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataTypeAbbr.DefaFldLength); //默认长度
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.DefaFldPrecision))
 {
 if (objDataTypeAbbrEN.DefaFldPrecision !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDataTypeAbbrEN.DefaFldPrecision, conDataTypeAbbr.DefaFldPrecision); //默认小数位数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataTypeAbbr.DefaFldPrecision); //默认小数位数
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.Memo))
 {
 if (objDataTypeAbbrEN.Memo !=  null)
 {
 var strMemo = objDataTypeAbbrEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objDataTypeAbbrEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsDataTypeAbbrEN objDataTypeAbbrEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objDataTypeAbbrEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDataTypeAbbrEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataTypeAbbrDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update DataTypeAbbr Set ");
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.DataTypeName))
 {
 if (objDataTypeAbbrEN.DataTypeName !=  null)
 {
 var strDataTypeName = objDataTypeAbbrEN.DataTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataTypeName = '{0}',", strDataTypeName); //数据类型名称
 }
 else
 {
 sbSQL.Append(" DataTypeName = null,"); //数据类型名称
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.DataTypeENName))
 {
 if (objDataTypeAbbrEN.DataTypeENName !=  null)
 {
 var strDataTypeENName = objDataTypeAbbrEN.DataTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataTypeENName = '{0}',", strDataTypeENName); //DataTypeENName
 }
 else
 {
 sbSQL.Append(" DataTypeENName = null,"); //DataTypeENName
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.DataCnName))
 {
 if (objDataTypeAbbrEN.DataCnName !=  null)
 {
 var strDataCnName = objDataTypeAbbrEN.DataCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataCnName = '{0}',", strDataCnName); //数据类型中文名称
 }
 else
 {
 sbSQL.Append(" DataCnName = null,"); //数据类型中文名称
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.DataTypeAbbr))
 {
 if (objDataTypeAbbrEN.DataTypeAbbr !=  null)
 {
 var strDataTypeAbbr = objDataTypeAbbrEN.DataTypeAbbr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataTypeAbbr = '{0}',", strDataTypeAbbr); //数据类型缩写
 }
 else
 {
 sbSQL.Append(" DataTypeAbbr = null,"); //数据类型缩写
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.NetSysType))
 {
 if (objDataTypeAbbrEN.NetSysType !=  null)
 {
 var strNetSysType = objDataTypeAbbrEN.NetSysType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" NetSysType = '{0}',", strNetSysType); //NET系统类型
 }
 else
 {
 sbSQL.Append(" NetSysType = null,"); //NET系统类型
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.VbNetType))
 {
 if (objDataTypeAbbrEN.VbNetType !=  null)
 {
 var strVbNetType = objDataTypeAbbrEN.VbNetType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VbNetType = '{0}',", strVbNetType); //VBNET类型
 }
 else
 {
 sbSQL.Append(" VbNetType = null,"); //VBNET类型
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.CsType))
 {
 if (objDataTypeAbbrEN.CsType !=  null)
 {
 var strCsType = objDataTypeAbbrEN.CsType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CsType = '{0}',", strCsType); //CS类型
 }
 else
 {
 sbSQL.Append(" CsType = null,"); //CS类型
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.JavaType))
 {
 if (objDataTypeAbbrEN.JavaType !=  null)
 {
 var strJavaType = objDataTypeAbbrEN.JavaType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" JavaType = '{0}',", strJavaType); //JAVA类型
 }
 else
 {
 sbSQL.Append(" JavaType = null,"); //JAVA类型
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.TypeScriptType))
 {
 if (objDataTypeAbbrEN.TypeScriptType !=  null)
 {
 var strTypeScriptType = objDataTypeAbbrEN.TypeScriptType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TypeScriptType = '{0}',", strTypeScriptType); //TypeScript类型
 }
 else
 {
 sbSQL.Append(" TypeScriptType = null,"); //TypeScript类型
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.JavaObjType))
 {
 if (objDataTypeAbbrEN.JavaObjType !=  null)
 {
 var strJavaObjType = objDataTypeAbbrEN.JavaObjType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" JavaObjType = '{0}',", strJavaObjType); //JAVA对象类型
 }
 else
 {
 sbSQL.Append(" JavaObjType = null,"); //JAVA对象类型
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.SwiftType))
 {
 if (objDataTypeAbbrEN.SwiftType !=  null)
 {
 var strSwiftType = objDataTypeAbbrEN.SwiftType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SwiftType = '{0}',", strSwiftType); //SwiftType
 }
 else
 {
 sbSQL.Append(" SwiftType = null,"); //SwiftType
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.IsNeedQuote))
 {
 sbSQL.AppendFormat(" IsNeedQuote = '{0}',", objDataTypeAbbrEN.IsNeedQuote == true?"1":"0"); //是否需要引号
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.OraDbType))
 {
 if (objDataTypeAbbrEN.OraDbType !=  null)
 {
 var strOraDbType = objDataTypeAbbrEN.OraDbType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OraDbType = '{0}',", strOraDbType); //Ora数据类型
 }
 else
 {
 sbSQL.Append(" OraDbType = null,"); //Ora数据类型
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.IsReturnType))
 {
 sbSQL.AppendFormat(" IsReturnType = '{0}',", objDataTypeAbbrEN.IsReturnType == true?"1":"0"); //是否可作返回类型
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.SqlParaType))
 {
 if (objDataTypeAbbrEN.SqlParaType !=  null)
 {
 var strSqlParaType = objDataTypeAbbrEN.SqlParaType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SqlParaType = '{0}',", strSqlParaType); //SQL参数类型
 }
 else
 {
 sbSQL.Append(" SqlParaType = null,"); //SQL参数类型
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.MySqlType))
 {
 if (objDataTypeAbbrEN.MySqlType !=  null)
 {
 var strMySqlType = objDataTypeAbbrEN.MySqlType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MySqlType = '{0}',", strMySqlType); //MySqlType
 }
 else
 {
 sbSQL.Append(" MySqlType = null,"); //MySqlType
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.DefaFldLength))
 {
 if (objDataTypeAbbrEN.DefaFldLength !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDataTypeAbbrEN.DefaFldLength, conDataTypeAbbr.DefaFldLength); //默认长度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataTypeAbbr.DefaFldLength); //默认长度
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.DefaFldPrecision))
 {
 if (objDataTypeAbbrEN.DefaFldPrecision !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDataTypeAbbrEN.DefaFldPrecision, conDataTypeAbbr.DefaFldPrecision); //默认小数位数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataTypeAbbr.DefaFldPrecision); //默认小数位数
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.Memo))
 {
 if (objDataTypeAbbrEN.Memo !=  null)
 {
 var strMemo = objDataTypeAbbrEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objDataTypeAbbrEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsDataTypeAbbrEN objDataTypeAbbrEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objDataTypeAbbrEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDataTypeAbbrEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataTypeAbbrDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update DataTypeAbbr Set ");
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.DataTypeName))
 {
 if (objDataTypeAbbrEN.DataTypeName !=  null)
 {
 var strDataTypeName = objDataTypeAbbrEN.DataTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataTypeName, conDataTypeAbbr.DataTypeName); //数据类型名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataTypeAbbr.DataTypeName); //数据类型名称
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.DataTypeENName))
 {
 if (objDataTypeAbbrEN.DataTypeENName !=  null)
 {
 var strDataTypeENName = objDataTypeAbbrEN.DataTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataTypeENName, conDataTypeAbbr.DataTypeENName); //DataTypeENName
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataTypeAbbr.DataTypeENName); //DataTypeENName
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.DataCnName))
 {
 if (objDataTypeAbbrEN.DataCnName !=  null)
 {
 var strDataCnName = objDataTypeAbbrEN.DataCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataCnName, conDataTypeAbbr.DataCnName); //数据类型中文名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataTypeAbbr.DataCnName); //数据类型中文名称
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.DataTypeAbbr))
 {
 if (objDataTypeAbbrEN.DataTypeAbbr !=  null)
 {
 var strDataTypeAbbr = objDataTypeAbbrEN.DataTypeAbbr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataTypeAbbr, conDataTypeAbbr.DataTypeAbbr); //数据类型缩写
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataTypeAbbr.DataTypeAbbr); //数据类型缩写
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.NetSysType))
 {
 if (objDataTypeAbbrEN.NetSysType !=  null)
 {
 var strNetSysType = objDataTypeAbbrEN.NetSysType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strNetSysType, conDataTypeAbbr.NetSysType); //NET系统类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataTypeAbbr.NetSysType); //NET系统类型
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.VbNetType))
 {
 if (objDataTypeAbbrEN.VbNetType !=  null)
 {
 var strVbNetType = objDataTypeAbbrEN.VbNetType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVbNetType, conDataTypeAbbr.VbNetType); //VBNET类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataTypeAbbr.VbNetType); //VBNET类型
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.CsType))
 {
 if (objDataTypeAbbrEN.CsType !=  null)
 {
 var strCsType = objDataTypeAbbrEN.CsType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCsType, conDataTypeAbbr.CsType); //CS类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataTypeAbbr.CsType); //CS类型
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.JavaType))
 {
 if (objDataTypeAbbrEN.JavaType !=  null)
 {
 var strJavaType = objDataTypeAbbrEN.JavaType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strJavaType, conDataTypeAbbr.JavaType); //JAVA类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataTypeAbbr.JavaType); //JAVA类型
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.TypeScriptType))
 {
 if (objDataTypeAbbrEN.TypeScriptType !=  null)
 {
 var strTypeScriptType = objDataTypeAbbrEN.TypeScriptType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTypeScriptType, conDataTypeAbbr.TypeScriptType); //TypeScript类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataTypeAbbr.TypeScriptType); //TypeScript类型
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.JavaObjType))
 {
 if (objDataTypeAbbrEN.JavaObjType !=  null)
 {
 var strJavaObjType = objDataTypeAbbrEN.JavaObjType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strJavaObjType, conDataTypeAbbr.JavaObjType); //JAVA对象类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataTypeAbbr.JavaObjType); //JAVA对象类型
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.SwiftType))
 {
 if (objDataTypeAbbrEN.SwiftType !=  null)
 {
 var strSwiftType = objDataTypeAbbrEN.SwiftType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSwiftType, conDataTypeAbbr.SwiftType); //SwiftType
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataTypeAbbr.SwiftType); //SwiftType
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.IsNeedQuote))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDataTypeAbbrEN.IsNeedQuote == true?"1":"0", conDataTypeAbbr.IsNeedQuote); //是否需要引号
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.OraDbType))
 {
 if (objDataTypeAbbrEN.OraDbType !=  null)
 {
 var strOraDbType = objDataTypeAbbrEN.OraDbType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOraDbType, conDataTypeAbbr.OraDbType); //Ora数据类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataTypeAbbr.OraDbType); //Ora数据类型
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.IsReturnType))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDataTypeAbbrEN.IsReturnType == true?"1":"0", conDataTypeAbbr.IsReturnType); //是否可作返回类型
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.SqlParaType))
 {
 if (objDataTypeAbbrEN.SqlParaType !=  null)
 {
 var strSqlParaType = objDataTypeAbbrEN.SqlParaType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSqlParaType, conDataTypeAbbr.SqlParaType); //SQL参数类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataTypeAbbr.SqlParaType); //SQL参数类型
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.MySqlType))
 {
 if (objDataTypeAbbrEN.MySqlType !=  null)
 {
 var strMySqlType = objDataTypeAbbrEN.MySqlType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMySqlType, conDataTypeAbbr.MySqlType); //MySqlType
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataTypeAbbr.MySqlType); //MySqlType
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.DefaFldLength))
 {
 if (objDataTypeAbbrEN.DefaFldLength !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDataTypeAbbrEN.DefaFldLength, conDataTypeAbbr.DefaFldLength); //默认长度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataTypeAbbr.DefaFldLength); //默认长度
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.DefaFldPrecision))
 {
 if (objDataTypeAbbrEN.DefaFldPrecision !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDataTypeAbbrEN.DefaFldPrecision, conDataTypeAbbr.DefaFldPrecision); //默认小数位数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataTypeAbbr.DefaFldPrecision); //默认小数位数
 }
 }
 
 if (objDataTypeAbbrEN.IsUpdated(conDataTypeAbbr.Memo))
 {
 if (objDataTypeAbbrEN.Memo !=  null)
 {
 var strMemo = objDataTypeAbbrEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conDataTypeAbbr.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataTypeAbbr.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where DataTypeId = '{0}'", objDataTypeAbbrEN.DataTypeId); 
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
 /// <param name = "strDataTypeId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strDataTypeId) 
{
CheckPrimaryKey(strDataTypeId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataTypeAbbrDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strDataTypeId,
};
 objSQL.ExecSP("DataTypeAbbr_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strDataTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strDataTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strDataTypeId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataTypeAbbrDA.GetSpecSQLObj();
//删除DataTypeAbbr本表中与当前对象有关的记录
strSQL = strSQL + "Delete from DataTypeAbbr where DataTypeId = " + "'"+ strDataTypeId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelDataTypeAbbr(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataTypeAbbrDA.GetSpecSQLObj();
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
//删除DataTypeAbbr本表中与当前对象有关的记录
strSQL = strSQL + "Delete from DataTypeAbbr where DataTypeId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strDataTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strDataTypeId) 
{
CheckPrimaryKey(strDataTypeId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataTypeAbbrDA.GetSpecSQLObj();
//删除DataTypeAbbr本表中与当前对象有关的记录
strSQL = strSQL + "Delete from DataTypeAbbr where DataTypeId = " + "'"+ strDataTypeId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelDataTypeAbbr(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsDataTypeAbbrDA: DelDataTypeAbbr)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataTypeAbbrDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from DataTypeAbbr where " + strCondition ;
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
public bool DelDataTypeAbbrWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsDataTypeAbbrDA: DelDataTypeAbbrWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataTypeAbbrDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from DataTypeAbbr where " + strCondition ;
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
 /// <param name = "objDataTypeAbbrENS">源对象</param>
 /// <param name = "objDataTypeAbbrENT">目标对象</param>
public void CopyTo(clsDataTypeAbbrEN objDataTypeAbbrENS, clsDataTypeAbbrEN objDataTypeAbbrENT)
{
objDataTypeAbbrENT.DataTypeId = objDataTypeAbbrENS.DataTypeId; //数据类型Id
objDataTypeAbbrENT.DataTypeName = objDataTypeAbbrENS.DataTypeName; //数据类型名称
objDataTypeAbbrENT.DataTypeENName = objDataTypeAbbrENS.DataTypeENName; //DataTypeENName
objDataTypeAbbrENT.DataCnName = objDataTypeAbbrENS.DataCnName; //数据类型中文名称
objDataTypeAbbrENT.DataTypeAbbr = objDataTypeAbbrENS.DataTypeAbbr; //数据类型缩写
objDataTypeAbbrENT.NetSysType = objDataTypeAbbrENS.NetSysType; //NET系统类型
objDataTypeAbbrENT.VbNetType = objDataTypeAbbrENS.VbNetType; //VBNET类型
objDataTypeAbbrENT.CsType = objDataTypeAbbrENS.CsType; //CS类型
objDataTypeAbbrENT.JavaType = objDataTypeAbbrENS.JavaType; //JAVA类型
objDataTypeAbbrENT.TypeScriptType = objDataTypeAbbrENS.TypeScriptType; //TypeScript类型
objDataTypeAbbrENT.JavaObjType = objDataTypeAbbrENS.JavaObjType; //JAVA对象类型
objDataTypeAbbrENT.SwiftType = objDataTypeAbbrENS.SwiftType; //SwiftType
objDataTypeAbbrENT.IsNeedQuote = objDataTypeAbbrENS.IsNeedQuote; //是否需要引号
objDataTypeAbbrENT.OraDbType = objDataTypeAbbrENS.OraDbType; //Ora数据类型
objDataTypeAbbrENT.IsReturnType = objDataTypeAbbrENS.IsReturnType; //是否可作返回类型
objDataTypeAbbrENT.SqlParaType = objDataTypeAbbrENS.SqlParaType; //SQL参数类型
objDataTypeAbbrENT.MySqlType = objDataTypeAbbrENS.MySqlType; //MySqlType
objDataTypeAbbrENT.DefaFldLength = objDataTypeAbbrENS.DefaFldLength; //默认长度
objDataTypeAbbrENT.DefaFldPrecision = objDataTypeAbbrENS.DefaFldPrecision; //默认小数位数
objDataTypeAbbrENT.Memo = objDataTypeAbbrENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsDataTypeAbbrEN objDataTypeAbbrEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objDataTypeAbbrEN.DataTypeName, conDataTypeAbbr.DataTypeName);
clsCheckSql.CheckFieldNotNull(objDataTypeAbbrEN.DataCnName, conDataTypeAbbr.DataCnName);
clsCheckSql.CheckFieldNotNull(objDataTypeAbbrEN.DataTypeAbbr, conDataTypeAbbr.DataTypeAbbr);
clsCheckSql.CheckFieldNotNull(objDataTypeAbbrEN.NetSysType, conDataTypeAbbr.NetSysType);
clsCheckSql.CheckFieldNotNull(objDataTypeAbbrEN.VbNetType, conDataTypeAbbr.VbNetType);
clsCheckSql.CheckFieldNotNull(objDataTypeAbbrEN.CsType, conDataTypeAbbr.CsType);
clsCheckSql.CheckFieldNotNull(objDataTypeAbbrEN.JavaType, conDataTypeAbbr.JavaType);
clsCheckSql.CheckFieldNotNull(objDataTypeAbbrEN.IsNeedQuote, conDataTypeAbbr.IsNeedQuote);
//检查字段长度
clsCheckSql.CheckFieldLen(objDataTypeAbbrEN.DataTypeId, 2, conDataTypeAbbr.DataTypeId);
clsCheckSql.CheckFieldLen(objDataTypeAbbrEN.DataTypeName, 100, conDataTypeAbbr.DataTypeName);
clsCheckSql.CheckFieldLen(objDataTypeAbbrEN.DataTypeENName, 100, conDataTypeAbbr.DataTypeENName);
clsCheckSql.CheckFieldLen(objDataTypeAbbrEN.DataCnName, 100, conDataTypeAbbr.DataCnName);
clsCheckSql.CheckFieldLen(objDataTypeAbbrEN.DataTypeAbbr, 5, conDataTypeAbbr.DataTypeAbbr);
clsCheckSql.CheckFieldLen(objDataTypeAbbrEN.NetSysType, 20, conDataTypeAbbr.NetSysType);
clsCheckSql.CheckFieldLen(objDataTypeAbbrEN.VbNetType, 100, conDataTypeAbbr.VbNetType);
clsCheckSql.CheckFieldLen(objDataTypeAbbrEN.CsType, 100, conDataTypeAbbr.CsType);
clsCheckSql.CheckFieldLen(objDataTypeAbbrEN.JavaType, 100, conDataTypeAbbr.JavaType);
clsCheckSql.CheckFieldLen(objDataTypeAbbrEN.TypeScriptType, 100, conDataTypeAbbr.TypeScriptType);
clsCheckSql.CheckFieldLen(objDataTypeAbbrEN.JavaObjType, 100, conDataTypeAbbr.JavaObjType);
clsCheckSql.CheckFieldLen(objDataTypeAbbrEN.SwiftType, 100, conDataTypeAbbr.SwiftType);
clsCheckSql.CheckFieldLen(objDataTypeAbbrEN.OraDbType, 100, conDataTypeAbbr.OraDbType);
clsCheckSql.CheckFieldLen(objDataTypeAbbrEN.SqlParaType, 100, conDataTypeAbbr.SqlParaType);
clsCheckSql.CheckFieldLen(objDataTypeAbbrEN.MySqlType, 100, conDataTypeAbbr.MySqlType);
clsCheckSql.CheckFieldLen(objDataTypeAbbrEN.Memo, 1000, conDataTypeAbbr.Memo);
//检查字段外键固定长度
 objDataTypeAbbrEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsDataTypeAbbrEN objDataTypeAbbrEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objDataTypeAbbrEN.DataTypeName, 100, conDataTypeAbbr.DataTypeName);
clsCheckSql.CheckFieldLen(objDataTypeAbbrEN.DataTypeENName, 100, conDataTypeAbbr.DataTypeENName);
clsCheckSql.CheckFieldLen(objDataTypeAbbrEN.DataCnName, 100, conDataTypeAbbr.DataCnName);
clsCheckSql.CheckFieldLen(objDataTypeAbbrEN.DataTypeAbbr, 5, conDataTypeAbbr.DataTypeAbbr);
clsCheckSql.CheckFieldLen(objDataTypeAbbrEN.NetSysType, 20, conDataTypeAbbr.NetSysType);
clsCheckSql.CheckFieldLen(objDataTypeAbbrEN.VbNetType, 100, conDataTypeAbbr.VbNetType);
clsCheckSql.CheckFieldLen(objDataTypeAbbrEN.CsType, 100, conDataTypeAbbr.CsType);
clsCheckSql.CheckFieldLen(objDataTypeAbbrEN.JavaType, 100, conDataTypeAbbr.JavaType);
clsCheckSql.CheckFieldLen(objDataTypeAbbrEN.TypeScriptType, 100, conDataTypeAbbr.TypeScriptType);
clsCheckSql.CheckFieldLen(objDataTypeAbbrEN.JavaObjType, 100, conDataTypeAbbr.JavaObjType);
clsCheckSql.CheckFieldLen(objDataTypeAbbrEN.SwiftType, 100, conDataTypeAbbr.SwiftType);
clsCheckSql.CheckFieldLen(objDataTypeAbbrEN.OraDbType, 100, conDataTypeAbbr.OraDbType);
clsCheckSql.CheckFieldLen(objDataTypeAbbrEN.SqlParaType, 100, conDataTypeAbbr.SqlParaType);
clsCheckSql.CheckFieldLen(objDataTypeAbbrEN.MySqlType, 100, conDataTypeAbbr.MySqlType);
clsCheckSql.CheckFieldLen(objDataTypeAbbrEN.Memo, 1000, conDataTypeAbbr.Memo);
//检查外键字段长度
 objDataTypeAbbrEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsDataTypeAbbrEN objDataTypeAbbrEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objDataTypeAbbrEN.DataTypeId, 2, conDataTypeAbbr.DataTypeId);
clsCheckSql.CheckFieldLen(objDataTypeAbbrEN.DataTypeName, 100, conDataTypeAbbr.DataTypeName);
clsCheckSql.CheckFieldLen(objDataTypeAbbrEN.DataTypeENName, 100, conDataTypeAbbr.DataTypeENName);
clsCheckSql.CheckFieldLen(objDataTypeAbbrEN.DataCnName, 100, conDataTypeAbbr.DataCnName);
clsCheckSql.CheckFieldLen(objDataTypeAbbrEN.DataTypeAbbr, 5, conDataTypeAbbr.DataTypeAbbr);
clsCheckSql.CheckFieldLen(objDataTypeAbbrEN.NetSysType, 20, conDataTypeAbbr.NetSysType);
clsCheckSql.CheckFieldLen(objDataTypeAbbrEN.VbNetType, 100, conDataTypeAbbr.VbNetType);
clsCheckSql.CheckFieldLen(objDataTypeAbbrEN.CsType, 100, conDataTypeAbbr.CsType);
clsCheckSql.CheckFieldLen(objDataTypeAbbrEN.JavaType, 100, conDataTypeAbbr.JavaType);
clsCheckSql.CheckFieldLen(objDataTypeAbbrEN.TypeScriptType, 100, conDataTypeAbbr.TypeScriptType);
clsCheckSql.CheckFieldLen(objDataTypeAbbrEN.JavaObjType, 100, conDataTypeAbbr.JavaObjType);
clsCheckSql.CheckFieldLen(objDataTypeAbbrEN.SwiftType, 100, conDataTypeAbbr.SwiftType);
clsCheckSql.CheckFieldLen(objDataTypeAbbrEN.OraDbType, 100, conDataTypeAbbr.OraDbType);
clsCheckSql.CheckFieldLen(objDataTypeAbbrEN.SqlParaType, 100, conDataTypeAbbr.SqlParaType);
clsCheckSql.CheckFieldLen(objDataTypeAbbrEN.MySqlType, 100, conDataTypeAbbr.MySqlType);
clsCheckSql.CheckFieldLen(objDataTypeAbbrEN.Memo, 1000, conDataTypeAbbr.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objDataTypeAbbrEN.DataTypeId, conDataTypeAbbr.DataTypeId);
clsCheckSql.CheckSqlInjection4Field(objDataTypeAbbrEN.DataTypeName, conDataTypeAbbr.DataTypeName);
clsCheckSql.CheckSqlInjection4Field(objDataTypeAbbrEN.DataTypeENName, conDataTypeAbbr.DataTypeENName);
clsCheckSql.CheckSqlInjection4Field(objDataTypeAbbrEN.DataCnName, conDataTypeAbbr.DataCnName);
clsCheckSql.CheckSqlInjection4Field(objDataTypeAbbrEN.DataTypeAbbr, conDataTypeAbbr.DataTypeAbbr);
clsCheckSql.CheckSqlInjection4Field(objDataTypeAbbrEN.NetSysType, conDataTypeAbbr.NetSysType);
clsCheckSql.CheckSqlInjection4Field(objDataTypeAbbrEN.VbNetType, conDataTypeAbbr.VbNetType);
clsCheckSql.CheckSqlInjection4Field(objDataTypeAbbrEN.CsType, conDataTypeAbbr.CsType);
clsCheckSql.CheckSqlInjection4Field(objDataTypeAbbrEN.JavaType, conDataTypeAbbr.JavaType);
clsCheckSql.CheckSqlInjection4Field(objDataTypeAbbrEN.TypeScriptType, conDataTypeAbbr.TypeScriptType);
clsCheckSql.CheckSqlInjection4Field(objDataTypeAbbrEN.JavaObjType, conDataTypeAbbr.JavaObjType);
clsCheckSql.CheckSqlInjection4Field(objDataTypeAbbrEN.SwiftType, conDataTypeAbbr.SwiftType);
clsCheckSql.CheckSqlInjection4Field(objDataTypeAbbrEN.OraDbType, conDataTypeAbbr.OraDbType);
clsCheckSql.CheckSqlInjection4Field(objDataTypeAbbrEN.SqlParaType, conDataTypeAbbr.SqlParaType);
clsCheckSql.CheckSqlInjection4Field(objDataTypeAbbrEN.MySqlType, conDataTypeAbbr.MySqlType);
clsCheckSql.CheckSqlInjection4Field(objDataTypeAbbrEN.Memo, conDataTypeAbbr.Memo);
//检查外键字段长度
 objDataTypeAbbrEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetDataTypeId()
{
//获取某学院所有专业信息
string strSQL = "select DataTypeId, DataTypeName from DataTypeAbbr ";
 clsSpecSQLforSql mySql = clsDataTypeAbbrDA.GetSpecSQLObj();
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
 objSQL = clsDataTypeAbbrDA.GetSpecSQLObj();
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
 objSQL = clsDataTypeAbbrDA.GetSpecSQLObj();
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
 objSQL = clsDataTypeAbbrDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsDataTypeAbbrEN._CurrTabName);
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
 objSQL = clsDataTypeAbbrDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsDataTypeAbbrEN._CurrTabName, strCondition);
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
 objSQL = clsDataTypeAbbrDA.GetSpecSQLObj();
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
 objSQL = clsDataTypeAbbrDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}