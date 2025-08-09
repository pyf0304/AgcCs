
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSelfDefDataTypeDA
 表名:SelfDefDataType(00050350)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:09:54
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码(GeneCode)
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
 /// 自定义数据类型(SelfDefDataType)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsSelfDefDataTypeDA : clsCommBase4DA
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
 return clsSelfDefDataTypeEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsSelfDefDataTypeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsSelfDefDataTypeEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsSelfDefDataTypeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsSelfDefDataTypeEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strSdDataTypeId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strSdDataTypeId)
{
strSdDataTypeId = strSdDataTypeId.Replace("'", "''");
if (strSdDataTypeId.Length > 4)
{
throw new Exception("(errid:Data000001)在表:SelfDefDataType中,检查关键字,长度不正确!(clsSelfDefDataTypeDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strSdDataTypeId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:SelfDefDataType中,关键字不能为空 或 null!(clsSelfDefDataTypeDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strSdDataTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsSelfDefDataTypeDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsSelfDefDataTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSelfDefDataTypeDA.GetSpecSQLObj();
strSQL = "Select * from SelfDefDataType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_SelfDefDataType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsSelfDefDataTypeDA: GetDataTable_SelfDefDataType)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSelfDefDataTypeDA.GetSpecSQLObj();
strSQL = "Select * from SelfDefDataType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsSelfDefDataTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSelfDefDataTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsSelfDefDataTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSelfDefDataTypeDA.GetSpecSQLObj();
strSQL = "Select * from SelfDefDataType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsSelfDefDataTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSelfDefDataTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsSelfDefDataTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSelfDefDataTypeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SelfDefDataType where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SelfDefDataType where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsSelfDefDataTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSelfDefDataTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from SelfDefDataType where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsSelfDefDataTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSelfDefDataTypeDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} SelfDefDataType.* " + 
$"from SelfDefDataType " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and SelfDefDataType.SdDataTypeId not in " + 
$"(Select top {intTop_In} SelfDefDataType.SdDataTypeId from SelfDefDataType " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SelfDefDataType where {1} and SdDataTypeId not in (Select top {2} SdDataTypeId from SelfDefDataType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SelfDefDataType where {1} and SdDataTypeId not in (Select top {3} SdDataTypeId from SelfDefDataType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsSelfDefDataTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSelfDefDataTypeDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} SelfDefDataType.* " + 
$"from SelfDefDataType " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and SelfDefDataType.SdDataTypeId not in " + 
$"(Select top {intTop_In} SelfDefDataType.SdDataTypeId from SelfDefDataType " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SelfDefDataType where {1} and SdDataTypeId not in (Select top {2} SdDataTypeId from SelfDefDataType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SelfDefDataType where {1} and SdDataTypeId not in (Select top {3} SdDataTypeId from SelfDefDataType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsSelfDefDataTypeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsSelfDefDataTypeDA:GetObjLst)", objException.Message));
}
List<clsSelfDefDataTypeEN> arrObjLst = new List<clsSelfDefDataTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSelfDefDataTypeDA.GetSpecSQLObj();
strSQL = "Select * from SelfDefDataType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSelfDefDataTypeEN objSelfDefDataTypeEN = new clsSelfDefDataTypeEN();
try
{
objSelfDefDataTypeEN.SdDataTypeId = objRow[conSelfDefDataType.SdDataTypeId].ToString().Trim(); //自定义数据类型Id
objSelfDefDataTypeEN.DataTypeName = objRow[conSelfDefDataType.DataTypeName].ToString().Trim(); //数据类型名称
objSelfDefDataTypeEN.IsObject = TransNullToBool(objRow[conSelfDefDataType.IsObject].ToString().Trim()); //是否对象
objSelfDefDataTypeEN.DefaVarName = objRow[conSelfDefDataType.DefaVarName] == DBNull.Value ? null : objRow[conSelfDefDataType.DefaVarName].ToString().Trim(); //默认变量名
objSelfDefDataTypeEN.DataCnName = objRow[conSelfDefDataType.DataCnName] == DBNull.Value ? null : objRow[conSelfDefDataType.DataCnName].ToString().Trim(); //数据类型中文名称
objSelfDefDataTypeEN.DataTypeAbbr = objRow[conSelfDefDataType.DataTypeAbbr] == DBNull.Value ? null : objRow[conSelfDefDataType.DataTypeAbbr].ToString().Trim(); //数据类型缩写
objSelfDefDataTypeEN.VbNetType = objRow[conSelfDefDataType.VbNetType] == DBNull.Value ? null : objRow[conSelfDefDataType.VbNetType].ToString().Trim(); //VBNET类型
objSelfDefDataTypeEN.CsType = objRow[conSelfDefDataType.CsType].ToString().Trim(); //CS类型
objSelfDefDataTypeEN.JavaType = objRow[conSelfDefDataType.JavaType] == DBNull.Value ? null : objRow[conSelfDefDataType.JavaType].ToString().Trim(); //JAVA类型
objSelfDefDataTypeEN.JavaObjType = objRow[conSelfDefDataType.JavaObjType] == DBNull.Value ? null : objRow[conSelfDefDataType.JavaObjType].ToString().Trim(); //JAVA对象类型
objSelfDefDataTypeEN.SwiftType = objRow[conSelfDefDataType.SwiftType] == DBNull.Value ? null : objRow[conSelfDefDataType.SwiftType].ToString().Trim(); //SwiftType
objSelfDefDataTypeEN.IsNeedQuote = TransNullToBool(objRow[conSelfDefDataType.IsNeedQuote].ToString().Trim()); //是否需要引号
objSelfDefDataTypeEN.OraDbType = objRow[conSelfDefDataType.OraDbType] == DBNull.Value ? null : objRow[conSelfDefDataType.OraDbType].ToString().Trim(); //Ora数据类型
objSelfDefDataTypeEN.IsReturnType = TransNullToBool(objRow[conSelfDefDataType.IsReturnType].ToString().Trim()); //是否可作返回类型
objSelfDefDataTypeEN.SqlParaType = objRow[conSelfDefDataType.SqlParaType] == DBNull.Value ? null : objRow[conSelfDefDataType.SqlParaType].ToString().Trim(); //SQL参数类型
objSelfDefDataTypeEN.MySqlType = objRow[conSelfDefDataType.MySqlType] == DBNull.Value ? null : objRow[conSelfDefDataType.MySqlType].ToString().Trim(); //MySqlType
objSelfDefDataTypeEN.DefaFldLength = objRow[conSelfDefDataType.DefaFldLength] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSelfDefDataType.DefaFldLength].ToString().Trim()); //默认长度
objSelfDefDataTypeEN.DefaFldPrecision = TransNullToInt(objRow[conSelfDefDataType.DefaFldPrecision].ToString().Trim()); //默认小数位数
objSelfDefDataTypeEN.PrjId = objRow[conSelfDefDataType.PrjId] == DBNull.Value ? null : objRow[conSelfDefDataType.PrjId].ToString().Trim(); //工程Id
objSelfDefDataTypeEN.UpdDate = objRow[conSelfDefDataType.UpdDate] == DBNull.Value ? null : objRow[conSelfDefDataType.UpdDate].ToString().Trim(); //修改日期
objSelfDefDataTypeEN.UpdUser = objRow[conSelfDefDataType.UpdUser] == DBNull.Value ? null : objRow[conSelfDefDataType.UpdUser].ToString().Trim(); //修改者
objSelfDefDataTypeEN.Memo = objRow[conSelfDefDataType.Memo] == DBNull.Value ? null : objRow[conSelfDefDataType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsSelfDefDataTypeDA: GetObjLst)", objException.Message));
}
objSelfDefDataTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objSelfDefDataTypeEN);
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
public List<clsSelfDefDataTypeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsSelfDefDataTypeDA:GetObjLstByTabName)", objException.Message));
}
List<clsSelfDefDataTypeEN> arrObjLst = new List<clsSelfDefDataTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSelfDefDataTypeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSelfDefDataTypeEN objSelfDefDataTypeEN = new clsSelfDefDataTypeEN();
try
{
objSelfDefDataTypeEN.SdDataTypeId = objRow[conSelfDefDataType.SdDataTypeId].ToString().Trim(); //自定义数据类型Id
objSelfDefDataTypeEN.DataTypeName = objRow[conSelfDefDataType.DataTypeName].ToString().Trim(); //数据类型名称
objSelfDefDataTypeEN.IsObject = TransNullToBool(objRow[conSelfDefDataType.IsObject].ToString().Trim()); //是否对象
objSelfDefDataTypeEN.DefaVarName = objRow[conSelfDefDataType.DefaVarName] == DBNull.Value ? null : objRow[conSelfDefDataType.DefaVarName].ToString().Trim(); //默认变量名
objSelfDefDataTypeEN.DataCnName = objRow[conSelfDefDataType.DataCnName] == DBNull.Value ? null : objRow[conSelfDefDataType.DataCnName].ToString().Trim(); //数据类型中文名称
objSelfDefDataTypeEN.DataTypeAbbr = objRow[conSelfDefDataType.DataTypeAbbr] == DBNull.Value ? null : objRow[conSelfDefDataType.DataTypeAbbr].ToString().Trim(); //数据类型缩写
objSelfDefDataTypeEN.VbNetType = objRow[conSelfDefDataType.VbNetType] == DBNull.Value ? null : objRow[conSelfDefDataType.VbNetType].ToString().Trim(); //VBNET类型
objSelfDefDataTypeEN.CsType = objRow[conSelfDefDataType.CsType].ToString().Trim(); //CS类型
objSelfDefDataTypeEN.JavaType = objRow[conSelfDefDataType.JavaType] == DBNull.Value ? null : objRow[conSelfDefDataType.JavaType].ToString().Trim(); //JAVA类型
objSelfDefDataTypeEN.JavaObjType = objRow[conSelfDefDataType.JavaObjType] == DBNull.Value ? null : objRow[conSelfDefDataType.JavaObjType].ToString().Trim(); //JAVA对象类型
objSelfDefDataTypeEN.SwiftType = objRow[conSelfDefDataType.SwiftType] == DBNull.Value ? null : objRow[conSelfDefDataType.SwiftType].ToString().Trim(); //SwiftType
objSelfDefDataTypeEN.IsNeedQuote = TransNullToBool(objRow[conSelfDefDataType.IsNeedQuote].ToString().Trim()); //是否需要引号
objSelfDefDataTypeEN.OraDbType = objRow[conSelfDefDataType.OraDbType] == DBNull.Value ? null : objRow[conSelfDefDataType.OraDbType].ToString().Trim(); //Ora数据类型
objSelfDefDataTypeEN.IsReturnType = TransNullToBool(objRow[conSelfDefDataType.IsReturnType].ToString().Trim()); //是否可作返回类型
objSelfDefDataTypeEN.SqlParaType = objRow[conSelfDefDataType.SqlParaType] == DBNull.Value ? null : objRow[conSelfDefDataType.SqlParaType].ToString().Trim(); //SQL参数类型
objSelfDefDataTypeEN.MySqlType = objRow[conSelfDefDataType.MySqlType] == DBNull.Value ? null : objRow[conSelfDefDataType.MySqlType].ToString().Trim(); //MySqlType
objSelfDefDataTypeEN.DefaFldLength = objRow[conSelfDefDataType.DefaFldLength] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSelfDefDataType.DefaFldLength].ToString().Trim()); //默认长度
objSelfDefDataTypeEN.DefaFldPrecision = TransNullToInt(objRow[conSelfDefDataType.DefaFldPrecision].ToString().Trim()); //默认小数位数
objSelfDefDataTypeEN.PrjId = objRow[conSelfDefDataType.PrjId] == DBNull.Value ? null : objRow[conSelfDefDataType.PrjId].ToString().Trim(); //工程Id
objSelfDefDataTypeEN.UpdDate = objRow[conSelfDefDataType.UpdDate] == DBNull.Value ? null : objRow[conSelfDefDataType.UpdDate].ToString().Trim(); //修改日期
objSelfDefDataTypeEN.UpdUser = objRow[conSelfDefDataType.UpdUser] == DBNull.Value ? null : objRow[conSelfDefDataType.UpdUser].ToString().Trim(); //修改者
objSelfDefDataTypeEN.Memo = objRow[conSelfDefDataType.Memo] == DBNull.Value ? null : objRow[conSelfDefDataType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsSelfDefDataTypeDA: GetObjLst)", objException.Message));
}
objSelfDefDataTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objSelfDefDataTypeEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objSelfDefDataTypeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetSelfDefDataType(ref clsSelfDefDataTypeEN objSelfDefDataTypeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSelfDefDataTypeDA.GetSpecSQLObj();
strSQL = "Select * from SelfDefDataType where SdDataTypeId = " + "'"+ objSelfDefDataTypeEN.SdDataTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objSelfDefDataTypeEN.SdDataTypeId = objDT.Rows[0][conSelfDefDataType.SdDataTypeId].ToString().Trim(); //自定义数据类型Id(字段类型:char,字段长度:4,是否可空:False)
 objSelfDefDataTypeEN.DataTypeName = objDT.Rows[0][conSelfDefDataType.DataTypeName].ToString().Trim(); //数据类型名称(字段类型:varchar,字段长度:100,是否可空:True)
 objSelfDefDataTypeEN.IsObject = TransNullToBool(objDT.Rows[0][conSelfDefDataType.IsObject].ToString().Trim()); //是否对象(字段类型:bit,字段长度:1,是否可空:True)
 objSelfDefDataTypeEN.DefaVarName = objDT.Rows[0][conSelfDefDataType.DefaVarName].ToString().Trim(); //默认变量名(字段类型:varchar,字段长度:50,是否可空:True)
 objSelfDefDataTypeEN.DataCnName = objDT.Rows[0][conSelfDefDataType.DataCnName].ToString().Trim(); //数据类型中文名称(字段类型:varchar,字段长度:100,是否可空:False)
 objSelfDefDataTypeEN.DataTypeAbbr = objDT.Rows[0][conSelfDefDataType.DataTypeAbbr].ToString().Trim(); //数据类型缩写(字段类型:varchar,字段长度:5,是否可空:False)
 objSelfDefDataTypeEN.VbNetType = objDT.Rows[0][conSelfDefDataType.VbNetType].ToString().Trim(); //VBNET类型(字段类型:varchar,字段长度:100,是否可空:False)
 objSelfDefDataTypeEN.CsType = objDT.Rows[0][conSelfDefDataType.CsType].ToString().Trim(); //CS类型(字段类型:varchar,字段长度:100,是否可空:False)
 objSelfDefDataTypeEN.JavaType = objDT.Rows[0][conSelfDefDataType.JavaType].ToString().Trim(); //JAVA类型(字段类型:varchar,字段长度:100,是否可空:False)
 objSelfDefDataTypeEN.JavaObjType = objDT.Rows[0][conSelfDefDataType.JavaObjType].ToString().Trim(); //JAVA对象类型(字段类型:varchar,字段长度:100,是否可空:True)
 objSelfDefDataTypeEN.SwiftType = objDT.Rows[0][conSelfDefDataType.SwiftType].ToString().Trim(); //SwiftType(字段类型:varchar,字段长度:100,是否可空:True)
 objSelfDefDataTypeEN.IsNeedQuote = TransNullToBool(objDT.Rows[0][conSelfDefDataType.IsNeedQuote].ToString().Trim()); //是否需要引号(字段类型:bit,字段长度:1,是否可空:False)
 objSelfDefDataTypeEN.OraDbType = objDT.Rows[0][conSelfDefDataType.OraDbType].ToString().Trim(); //Ora数据类型(字段类型:varchar,字段长度:100,是否可空:False)
 objSelfDefDataTypeEN.IsReturnType = TransNullToBool(objDT.Rows[0][conSelfDefDataType.IsReturnType].ToString().Trim()); //是否可作返回类型(字段类型:bit,字段长度:1,是否可空:True)
 objSelfDefDataTypeEN.SqlParaType = objDT.Rows[0][conSelfDefDataType.SqlParaType].ToString().Trim(); //SQL参数类型(字段类型:varchar,字段长度:100,是否可空:True)
 objSelfDefDataTypeEN.MySqlType = objDT.Rows[0][conSelfDefDataType.MySqlType].ToString().Trim(); //MySqlType(字段类型:varchar,字段长度:100,是否可空:True)
 objSelfDefDataTypeEN.DefaFldLength = TransNullToInt(objDT.Rows[0][conSelfDefDataType.DefaFldLength].ToString().Trim()); //默认长度(字段类型:int,字段长度:4,是否可空:True)
 objSelfDefDataTypeEN.DefaFldPrecision = TransNullToInt(objDT.Rows[0][conSelfDefDataType.DefaFldPrecision].ToString().Trim()); //默认小数位数(字段类型:int,字段长度:4,是否可空:True)
 objSelfDefDataTypeEN.PrjId = objDT.Rows[0][conSelfDefDataType.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objSelfDefDataTypeEN.UpdDate = objDT.Rows[0][conSelfDefDataType.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objSelfDefDataTypeEN.UpdUser = objDT.Rows[0][conSelfDefDataType.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objSelfDefDataTypeEN.Memo = objDT.Rows[0][conSelfDefDataType.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsSelfDefDataTypeDA: GetSelfDefDataType)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strSdDataTypeId">表关键字</param>
 /// <returns>表对象</returns>
public clsSelfDefDataTypeEN GetObjBySdDataTypeId(string strSdDataTypeId)
{
CheckPrimaryKey(strSdDataTypeId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSelfDefDataTypeDA.GetSpecSQLObj();
strSQL = "Select * from SelfDefDataType where SdDataTypeId = " + "'"+ strSdDataTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsSelfDefDataTypeEN objSelfDefDataTypeEN = new clsSelfDefDataTypeEN();
try
{
 objSelfDefDataTypeEN.SdDataTypeId = objRow[conSelfDefDataType.SdDataTypeId].ToString().Trim(); //自定义数据类型Id(字段类型:char,字段长度:4,是否可空:False)
 objSelfDefDataTypeEN.DataTypeName = objRow[conSelfDefDataType.DataTypeName].ToString().Trim(); //数据类型名称(字段类型:varchar,字段长度:100,是否可空:True)
 objSelfDefDataTypeEN.IsObject = clsEntityBase2.TransNullToBool_S(objRow[conSelfDefDataType.IsObject].ToString().Trim()); //是否对象(字段类型:bit,字段长度:1,是否可空:True)
 objSelfDefDataTypeEN.DefaVarName = objRow[conSelfDefDataType.DefaVarName] == DBNull.Value ? null : objRow[conSelfDefDataType.DefaVarName].ToString().Trim(); //默认变量名(字段类型:varchar,字段长度:50,是否可空:True)
 objSelfDefDataTypeEN.DataCnName = objRow[conSelfDefDataType.DataCnName] == DBNull.Value ? null : objRow[conSelfDefDataType.DataCnName].ToString().Trim(); //数据类型中文名称(字段类型:varchar,字段长度:100,是否可空:False)
 objSelfDefDataTypeEN.DataTypeAbbr = objRow[conSelfDefDataType.DataTypeAbbr] == DBNull.Value ? null : objRow[conSelfDefDataType.DataTypeAbbr].ToString().Trim(); //数据类型缩写(字段类型:varchar,字段长度:5,是否可空:False)
 objSelfDefDataTypeEN.VbNetType = objRow[conSelfDefDataType.VbNetType] == DBNull.Value ? null : objRow[conSelfDefDataType.VbNetType].ToString().Trim(); //VBNET类型(字段类型:varchar,字段长度:100,是否可空:False)
 objSelfDefDataTypeEN.CsType = objRow[conSelfDefDataType.CsType].ToString().Trim(); //CS类型(字段类型:varchar,字段长度:100,是否可空:False)
 objSelfDefDataTypeEN.JavaType = objRow[conSelfDefDataType.JavaType] == DBNull.Value ? null : objRow[conSelfDefDataType.JavaType].ToString().Trim(); //JAVA类型(字段类型:varchar,字段长度:100,是否可空:False)
 objSelfDefDataTypeEN.JavaObjType = objRow[conSelfDefDataType.JavaObjType] == DBNull.Value ? null : objRow[conSelfDefDataType.JavaObjType].ToString().Trim(); //JAVA对象类型(字段类型:varchar,字段长度:100,是否可空:True)
 objSelfDefDataTypeEN.SwiftType = objRow[conSelfDefDataType.SwiftType] == DBNull.Value ? null : objRow[conSelfDefDataType.SwiftType].ToString().Trim(); //SwiftType(字段类型:varchar,字段长度:100,是否可空:True)
 objSelfDefDataTypeEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[conSelfDefDataType.IsNeedQuote].ToString().Trim()); //是否需要引号(字段类型:bit,字段长度:1,是否可空:False)
 objSelfDefDataTypeEN.OraDbType = objRow[conSelfDefDataType.OraDbType] == DBNull.Value ? null : objRow[conSelfDefDataType.OraDbType].ToString().Trim(); //Ora数据类型(字段类型:varchar,字段长度:100,是否可空:False)
 objSelfDefDataTypeEN.IsReturnType = clsEntityBase2.TransNullToBool_S(objRow[conSelfDefDataType.IsReturnType].ToString().Trim()); //是否可作返回类型(字段类型:bit,字段长度:1,是否可空:True)
 objSelfDefDataTypeEN.SqlParaType = objRow[conSelfDefDataType.SqlParaType] == DBNull.Value ? null : objRow[conSelfDefDataType.SqlParaType].ToString().Trim(); //SQL参数类型(字段类型:varchar,字段长度:100,是否可空:True)
 objSelfDefDataTypeEN.MySqlType = objRow[conSelfDefDataType.MySqlType] == DBNull.Value ? null : objRow[conSelfDefDataType.MySqlType].ToString().Trim(); //MySqlType(字段类型:varchar,字段长度:100,是否可空:True)
 objSelfDefDataTypeEN.DefaFldLength = objRow[conSelfDefDataType.DefaFldLength] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSelfDefDataType.DefaFldLength].ToString().Trim()); //默认长度(字段类型:int,字段长度:4,是否可空:True)
 objSelfDefDataTypeEN.DefaFldPrecision = Int32.Parse(objRow[conSelfDefDataType.DefaFldPrecision].ToString().Trim()); //默认小数位数(字段类型:int,字段长度:4,是否可空:True)
 objSelfDefDataTypeEN.PrjId = objRow[conSelfDefDataType.PrjId] == DBNull.Value ? null : objRow[conSelfDefDataType.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objSelfDefDataTypeEN.UpdDate = objRow[conSelfDefDataType.UpdDate] == DBNull.Value ? null : objRow[conSelfDefDataType.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objSelfDefDataTypeEN.UpdUser = objRow[conSelfDefDataType.UpdUser] == DBNull.Value ? null : objRow[conSelfDefDataType.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objSelfDefDataTypeEN.Memo = objRow[conSelfDefDataType.Memo] == DBNull.Value ? null : objRow[conSelfDefDataType.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsSelfDefDataTypeDA: GetObjBySdDataTypeId)", objException.Message));
}
return objSelfDefDataTypeEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsSelfDefDataTypeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsSelfDefDataTypeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSelfDefDataTypeDA.GetSpecSQLObj();
strSQL = "Select * from SelfDefDataType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsSelfDefDataTypeEN objSelfDefDataTypeEN = new clsSelfDefDataTypeEN()
{
SdDataTypeId = objRow[conSelfDefDataType.SdDataTypeId].ToString().Trim(), //自定义数据类型Id
DataTypeName = objRow[conSelfDefDataType.DataTypeName].ToString().Trim(), //数据类型名称
IsObject = TransNullToBool(objRow[conSelfDefDataType.IsObject].ToString().Trim()), //是否对象
DefaVarName = objRow[conSelfDefDataType.DefaVarName] == DBNull.Value ? null : objRow[conSelfDefDataType.DefaVarName].ToString().Trim(), //默认变量名
DataCnName = objRow[conSelfDefDataType.DataCnName] == DBNull.Value ? null : objRow[conSelfDefDataType.DataCnName].ToString().Trim(), //数据类型中文名称
DataTypeAbbr = objRow[conSelfDefDataType.DataTypeAbbr] == DBNull.Value ? null : objRow[conSelfDefDataType.DataTypeAbbr].ToString().Trim(), //数据类型缩写
VbNetType = objRow[conSelfDefDataType.VbNetType] == DBNull.Value ? null : objRow[conSelfDefDataType.VbNetType].ToString().Trim(), //VBNET类型
CsType = objRow[conSelfDefDataType.CsType].ToString().Trim(), //CS类型
JavaType = objRow[conSelfDefDataType.JavaType] == DBNull.Value ? null : objRow[conSelfDefDataType.JavaType].ToString().Trim(), //JAVA类型
JavaObjType = objRow[conSelfDefDataType.JavaObjType] == DBNull.Value ? null : objRow[conSelfDefDataType.JavaObjType].ToString().Trim(), //JAVA对象类型
SwiftType = objRow[conSelfDefDataType.SwiftType] == DBNull.Value ? null : objRow[conSelfDefDataType.SwiftType].ToString().Trim(), //SwiftType
IsNeedQuote = TransNullToBool(objRow[conSelfDefDataType.IsNeedQuote].ToString().Trim()), //是否需要引号
OraDbType = objRow[conSelfDefDataType.OraDbType] == DBNull.Value ? null : objRow[conSelfDefDataType.OraDbType].ToString().Trim(), //Ora数据类型
IsReturnType = TransNullToBool(objRow[conSelfDefDataType.IsReturnType].ToString().Trim()), //是否可作返回类型
SqlParaType = objRow[conSelfDefDataType.SqlParaType] == DBNull.Value ? null : objRow[conSelfDefDataType.SqlParaType].ToString().Trim(), //SQL参数类型
MySqlType = objRow[conSelfDefDataType.MySqlType] == DBNull.Value ? null : objRow[conSelfDefDataType.MySqlType].ToString().Trim(), //MySqlType
DefaFldLength = objRow[conSelfDefDataType.DefaFldLength] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSelfDefDataType.DefaFldLength].ToString().Trim()), //默认长度
DefaFldPrecision = TransNullToInt(objRow[conSelfDefDataType.DefaFldPrecision].ToString().Trim()), //默认小数位数
PrjId = objRow[conSelfDefDataType.PrjId] == DBNull.Value ? null : objRow[conSelfDefDataType.PrjId].ToString().Trim(), //工程Id
UpdDate = objRow[conSelfDefDataType.UpdDate] == DBNull.Value ? null : objRow[conSelfDefDataType.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conSelfDefDataType.UpdUser] == DBNull.Value ? null : objRow[conSelfDefDataType.UpdUser].ToString().Trim(), //修改者
Memo = objRow[conSelfDefDataType.Memo] == DBNull.Value ? null : objRow[conSelfDefDataType.Memo].ToString().Trim() //说明
};
objSelfDefDataTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSelfDefDataTypeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsSelfDefDataTypeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsSelfDefDataTypeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsSelfDefDataTypeEN objSelfDefDataTypeEN = new clsSelfDefDataTypeEN();
try
{
objSelfDefDataTypeEN.SdDataTypeId = objRow[conSelfDefDataType.SdDataTypeId].ToString().Trim(); //自定义数据类型Id
objSelfDefDataTypeEN.DataTypeName = objRow[conSelfDefDataType.DataTypeName].ToString().Trim(); //数据类型名称
objSelfDefDataTypeEN.IsObject = TransNullToBool(objRow[conSelfDefDataType.IsObject].ToString().Trim()); //是否对象
objSelfDefDataTypeEN.DefaVarName = objRow[conSelfDefDataType.DefaVarName] == DBNull.Value ? null : objRow[conSelfDefDataType.DefaVarName].ToString().Trim(); //默认变量名
objSelfDefDataTypeEN.DataCnName = objRow[conSelfDefDataType.DataCnName] == DBNull.Value ? null : objRow[conSelfDefDataType.DataCnName].ToString().Trim(); //数据类型中文名称
objSelfDefDataTypeEN.DataTypeAbbr = objRow[conSelfDefDataType.DataTypeAbbr] == DBNull.Value ? null : objRow[conSelfDefDataType.DataTypeAbbr].ToString().Trim(); //数据类型缩写
objSelfDefDataTypeEN.VbNetType = objRow[conSelfDefDataType.VbNetType] == DBNull.Value ? null : objRow[conSelfDefDataType.VbNetType].ToString().Trim(); //VBNET类型
objSelfDefDataTypeEN.CsType = objRow[conSelfDefDataType.CsType].ToString().Trim(); //CS类型
objSelfDefDataTypeEN.JavaType = objRow[conSelfDefDataType.JavaType] == DBNull.Value ? null : objRow[conSelfDefDataType.JavaType].ToString().Trim(); //JAVA类型
objSelfDefDataTypeEN.JavaObjType = objRow[conSelfDefDataType.JavaObjType] == DBNull.Value ? null : objRow[conSelfDefDataType.JavaObjType].ToString().Trim(); //JAVA对象类型
objSelfDefDataTypeEN.SwiftType = objRow[conSelfDefDataType.SwiftType] == DBNull.Value ? null : objRow[conSelfDefDataType.SwiftType].ToString().Trim(); //SwiftType
objSelfDefDataTypeEN.IsNeedQuote = TransNullToBool(objRow[conSelfDefDataType.IsNeedQuote].ToString().Trim()); //是否需要引号
objSelfDefDataTypeEN.OraDbType = objRow[conSelfDefDataType.OraDbType] == DBNull.Value ? null : objRow[conSelfDefDataType.OraDbType].ToString().Trim(); //Ora数据类型
objSelfDefDataTypeEN.IsReturnType = TransNullToBool(objRow[conSelfDefDataType.IsReturnType].ToString().Trim()); //是否可作返回类型
objSelfDefDataTypeEN.SqlParaType = objRow[conSelfDefDataType.SqlParaType] == DBNull.Value ? null : objRow[conSelfDefDataType.SqlParaType].ToString().Trim(); //SQL参数类型
objSelfDefDataTypeEN.MySqlType = objRow[conSelfDefDataType.MySqlType] == DBNull.Value ? null : objRow[conSelfDefDataType.MySqlType].ToString().Trim(); //MySqlType
objSelfDefDataTypeEN.DefaFldLength = objRow[conSelfDefDataType.DefaFldLength] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSelfDefDataType.DefaFldLength].ToString().Trim()); //默认长度
objSelfDefDataTypeEN.DefaFldPrecision = TransNullToInt(objRow[conSelfDefDataType.DefaFldPrecision].ToString().Trim()); //默认小数位数
objSelfDefDataTypeEN.PrjId = objRow[conSelfDefDataType.PrjId] == DBNull.Value ? null : objRow[conSelfDefDataType.PrjId].ToString().Trim(); //工程Id
objSelfDefDataTypeEN.UpdDate = objRow[conSelfDefDataType.UpdDate] == DBNull.Value ? null : objRow[conSelfDefDataType.UpdDate].ToString().Trim(); //修改日期
objSelfDefDataTypeEN.UpdUser = objRow[conSelfDefDataType.UpdUser] == DBNull.Value ? null : objRow[conSelfDefDataType.UpdUser].ToString().Trim(); //修改者
objSelfDefDataTypeEN.Memo = objRow[conSelfDefDataType.Memo] == DBNull.Value ? null : objRow[conSelfDefDataType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsSelfDefDataTypeDA: GetObjByDataRowSelfDefDataType)", objException.Message));
}
objSelfDefDataTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSelfDefDataTypeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsSelfDefDataTypeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsSelfDefDataTypeEN objSelfDefDataTypeEN = new clsSelfDefDataTypeEN();
try
{
objSelfDefDataTypeEN.SdDataTypeId = objRow[conSelfDefDataType.SdDataTypeId].ToString().Trim(); //自定义数据类型Id
objSelfDefDataTypeEN.DataTypeName = objRow[conSelfDefDataType.DataTypeName].ToString().Trim(); //数据类型名称
objSelfDefDataTypeEN.IsObject = TransNullToBool(objRow[conSelfDefDataType.IsObject].ToString().Trim()); //是否对象
objSelfDefDataTypeEN.DefaVarName = objRow[conSelfDefDataType.DefaVarName] == DBNull.Value ? null : objRow[conSelfDefDataType.DefaVarName].ToString().Trim(); //默认变量名
objSelfDefDataTypeEN.DataCnName = objRow[conSelfDefDataType.DataCnName] == DBNull.Value ? null : objRow[conSelfDefDataType.DataCnName].ToString().Trim(); //数据类型中文名称
objSelfDefDataTypeEN.DataTypeAbbr = objRow[conSelfDefDataType.DataTypeAbbr] == DBNull.Value ? null : objRow[conSelfDefDataType.DataTypeAbbr].ToString().Trim(); //数据类型缩写
objSelfDefDataTypeEN.VbNetType = objRow[conSelfDefDataType.VbNetType] == DBNull.Value ? null : objRow[conSelfDefDataType.VbNetType].ToString().Trim(); //VBNET类型
objSelfDefDataTypeEN.CsType = objRow[conSelfDefDataType.CsType].ToString().Trim(); //CS类型
objSelfDefDataTypeEN.JavaType = objRow[conSelfDefDataType.JavaType] == DBNull.Value ? null : objRow[conSelfDefDataType.JavaType].ToString().Trim(); //JAVA类型
objSelfDefDataTypeEN.JavaObjType = objRow[conSelfDefDataType.JavaObjType] == DBNull.Value ? null : objRow[conSelfDefDataType.JavaObjType].ToString().Trim(); //JAVA对象类型
objSelfDefDataTypeEN.SwiftType = objRow[conSelfDefDataType.SwiftType] == DBNull.Value ? null : objRow[conSelfDefDataType.SwiftType].ToString().Trim(); //SwiftType
objSelfDefDataTypeEN.IsNeedQuote = TransNullToBool(objRow[conSelfDefDataType.IsNeedQuote].ToString().Trim()); //是否需要引号
objSelfDefDataTypeEN.OraDbType = objRow[conSelfDefDataType.OraDbType] == DBNull.Value ? null : objRow[conSelfDefDataType.OraDbType].ToString().Trim(); //Ora数据类型
objSelfDefDataTypeEN.IsReturnType = TransNullToBool(objRow[conSelfDefDataType.IsReturnType].ToString().Trim()); //是否可作返回类型
objSelfDefDataTypeEN.SqlParaType = objRow[conSelfDefDataType.SqlParaType] == DBNull.Value ? null : objRow[conSelfDefDataType.SqlParaType].ToString().Trim(); //SQL参数类型
objSelfDefDataTypeEN.MySqlType = objRow[conSelfDefDataType.MySqlType] == DBNull.Value ? null : objRow[conSelfDefDataType.MySqlType].ToString().Trim(); //MySqlType
objSelfDefDataTypeEN.DefaFldLength = objRow[conSelfDefDataType.DefaFldLength] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSelfDefDataType.DefaFldLength].ToString().Trim()); //默认长度
objSelfDefDataTypeEN.DefaFldPrecision = TransNullToInt(objRow[conSelfDefDataType.DefaFldPrecision].ToString().Trim()); //默认小数位数
objSelfDefDataTypeEN.PrjId = objRow[conSelfDefDataType.PrjId] == DBNull.Value ? null : objRow[conSelfDefDataType.PrjId].ToString().Trim(); //工程Id
objSelfDefDataTypeEN.UpdDate = objRow[conSelfDefDataType.UpdDate] == DBNull.Value ? null : objRow[conSelfDefDataType.UpdDate].ToString().Trim(); //修改日期
objSelfDefDataTypeEN.UpdUser = objRow[conSelfDefDataType.UpdUser] == DBNull.Value ? null : objRow[conSelfDefDataType.UpdUser].ToString().Trim(); //修改者
objSelfDefDataTypeEN.Memo = objRow[conSelfDefDataType.Memo] == DBNull.Value ? null : objRow[conSelfDefDataType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsSelfDefDataTypeDA: GetObjByDataRow)", objException.Message));
}
objSelfDefDataTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSelfDefDataTypeEN;
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
objSQL = clsSelfDefDataTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsSelfDefDataTypeEN._CurrTabName, conSelfDefDataType.SdDataTypeId, 4, "");
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
objSQL = clsSelfDefDataTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsSelfDefDataTypeEN._CurrTabName, conSelfDefDataType.SdDataTypeId, 4, strPrefix);
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
 objSQL = clsSelfDefDataTypeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select SdDataTypeId from SelfDefDataType where " + strCondition;
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
 objSQL = clsSelfDefDataTypeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select SdDataTypeId from SelfDefDataType where " + strCondition;
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
 /// <param name = "strSdDataTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strSdDataTypeId)
{
CheckPrimaryKey(strSdDataTypeId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSelfDefDataTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("SelfDefDataType", "SdDataTypeId = " + "'"+ strSdDataTypeId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsSelfDefDataTypeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSelfDefDataTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("SelfDefDataType", strCondition))
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
objSQL = clsSelfDefDataTypeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("SelfDefDataType");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsSelfDefDataTypeEN objSelfDefDataTypeEN)
 {
 objSelfDefDataTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSelfDefDataTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSelfDefDataTypeEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSelfDefDataTypeDA.GetSpecSQLObj();
strSQL = "Select * from SelfDefDataType where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "SelfDefDataType");
objRow = objDS.Tables["SelfDefDataType"].NewRow();
objRow[conSelfDefDataType.SdDataTypeId] = objSelfDefDataTypeEN.SdDataTypeId; //自定义数据类型Id
objRow[conSelfDefDataType.DataTypeName] = objSelfDefDataTypeEN.DataTypeName; //数据类型名称
objRow[conSelfDefDataType.IsObject] = objSelfDefDataTypeEN.IsObject; //是否对象
 if (objSelfDefDataTypeEN.DefaVarName !=  "")
 {
objRow[conSelfDefDataType.DefaVarName] = objSelfDefDataTypeEN.DefaVarName; //默认变量名
 }
 if (objSelfDefDataTypeEN.DataCnName !=  "")
 {
objRow[conSelfDefDataType.DataCnName] = objSelfDefDataTypeEN.DataCnName; //数据类型中文名称
 }
 if (objSelfDefDataTypeEN.DataTypeAbbr !=  "")
 {
objRow[conSelfDefDataType.DataTypeAbbr] = objSelfDefDataTypeEN.DataTypeAbbr; //数据类型缩写
 }
 if (objSelfDefDataTypeEN.VbNetType !=  "")
 {
objRow[conSelfDefDataType.VbNetType] = objSelfDefDataTypeEN.VbNetType; //VBNET类型
 }
objRow[conSelfDefDataType.CsType] = objSelfDefDataTypeEN.CsType; //CS类型
 if (objSelfDefDataTypeEN.JavaType !=  "")
 {
objRow[conSelfDefDataType.JavaType] = objSelfDefDataTypeEN.JavaType; //JAVA类型
 }
 if (objSelfDefDataTypeEN.JavaObjType !=  "")
 {
objRow[conSelfDefDataType.JavaObjType] = objSelfDefDataTypeEN.JavaObjType; //JAVA对象类型
 }
 if (objSelfDefDataTypeEN.SwiftType !=  "")
 {
objRow[conSelfDefDataType.SwiftType] = objSelfDefDataTypeEN.SwiftType; //SwiftType
 }
objRow[conSelfDefDataType.IsNeedQuote] = objSelfDefDataTypeEN.IsNeedQuote; //是否需要引号
 if (objSelfDefDataTypeEN.OraDbType !=  "")
 {
objRow[conSelfDefDataType.OraDbType] = objSelfDefDataTypeEN.OraDbType; //Ora数据类型
 }
objRow[conSelfDefDataType.IsReturnType] = objSelfDefDataTypeEN.IsReturnType; //是否可作返回类型
 if (objSelfDefDataTypeEN.SqlParaType !=  "")
 {
objRow[conSelfDefDataType.SqlParaType] = objSelfDefDataTypeEN.SqlParaType; //SQL参数类型
 }
 if (objSelfDefDataTypeEN.MySqlType !=  "")
 {
objRow[conSelfDefDataType.MySqlType] = objSelfDefDataTypeEN.MySqlType; //MySqlType
 }
objRow[conSelfDefDataType.DefaFldLength] = objSelfDefDataTypeEN.DefaFldLength; //默认长度
objRow[conSelfDefDataType.DefaFldPrecision] = objSelfDefDataTypeEN.DefaFldPrecision; //默认小数位数
 if (objSelfDefDataTypeEN.PrjId !=  "")
 {
objRow[conSelfDefDataType.PrjId] = objSelfDefDataTypeEN.PrjId; //工程Id
 }
 if (objSelfDefDataTypeEN.UpdDate !=  "")
 {
objRow[conSelfDefDataType.UpdDate] = objSelfDefDataTypeEN.UpdDate; //修改日期
 }
 if (objSelfDefDataTypeEN.UpdUser !=  "")
 {
objRow[conSelfDefDataType.UpdUser] = objSelfDefDataTypeEN.UpdUser; //修改者
 }
 if (objSelfDefDataTypeEN.Memo !=  "")
 {
objRow[conSelfDefDataType.Memo] = objSelfDefDataTypeEN.Memo; //说明
 }
objDS.Tables[clsSelfDefDataTypeEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsSelfDefDataTypeEN._CurrTabName);
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
 /// <param name = "objSelfDefDataTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsSelfDefDataTypeEN objSelfDefDataTypeEN)
{
 objSelfDefDataTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSelfDefDataTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSelfDefDataTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSelfDefDataTypeEN.SdDataTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.SdDataTypeId);
 var strSdDataTypeId = objSelfDefDataTypeEN.SdDataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSdDataTypeId + "'");
 }
 
 if (objSelfDefDataTypeEN.DataTypeName !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.DataTypeName);
 var strDataTypeName = objSelfDefDataTypeEN.DataTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataTypeName + "'");
 }
 
 arrFieldListForInsert.Add(conSelfDefDataType.IsObject);
 arrValueListForInsert.Add("'" + (objSelfDefDataTypeEN.IsObject  ==  false ? "0" : "1") + "'");
 
 if (objSelfDefDataTypeEN.DefaVarName !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.DefaVarName);
 var strDefaVarName = objSelfDefDataTypeEN.DefaVarName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDefaVarName + "'");
 }
 
 if (objSelfDefDataTypeEN.DataCnName !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.DataCnName);
 var strDataCnName = objSelfDefDataTypeEN.DataCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataCnName + "'");
 }
 
 if (objSelfDefDataTypeEN.DataTypeAbbr !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.DataTypeAbbr);
 var strDataTypeAbbr = objSelfDefDataTypeEN.DataTypeAbbr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataTypeAbbr + "'");
 }
 
 if (objSelfDefDataTypeEN.VbNetType !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.VbNetType);
 var strVbNetType = objSelfDefDataTypeEN.VbNetType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVbNetType + "'");
 }
 
 if (objSelfDefDataTypeEN.CsType !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.CsType);
 var strCsType = objSelfDefDataTypeEN.CsType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCsType + "'");
 }
 
 if (objSelfDefDataTypeEN.JavaType !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.JavaType);
 var strJavaType = objSelfDefDataTypeEN.JavaType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strJavaType + "'");
 }
 
 if (objSelfDefDataTypeEN.JavaObjType !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.JavaObjType);
 var strJavaObjType = objSelfDefDataTypeEN.JavaObjType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strJavaObjType + "'");
 }
 
 if (objSelfDefDataTypeEN.SwiftType !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.SwiftType);
 var strSwiftType = objSelfDefDataTypeEN.SwiftType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSwiftType + "'");
 }
 
 arrFieldListForInsert.Add(conSelfDefDataType.IsNeedQuote);
 arrValueListForInsert.Add("'" + (objSelfDefDataTypeEN.IsNeedQuote  ==  false ? "0" : "1") + "'");
 
 if (objSelfDefDataTypeEN.OraDbType !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.OraDbType);
 var strOraDbType = objSelfDefDataTypeEN.OraDbType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOraDbType + "'");
 }
 
 arrFieldListForInsert.Add(conSelfDefDataType.IsReturnType);
 arrValueListForInsert.Add("'" + (objSelfDefDataTypeEN.IsReturnType  ==  false ? "0" : "1") + "'");
 
 if (objSelfDefDataTypeEN.SqlParaType !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.SqlParaType);
 var strSqlParaType = objSelfDefDataTypeEN.SqlParaType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSqlParaType + "'");
 }
 
 if (objSelfDefDataTypeEN.MySqlType !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.MySqlType);
 var strMySqlType = objSelfDefDataTypeEN.MySqlType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMySqlType + "'");
 }
 
 if (objSelfDefDataTypeEN.DefaFldLength !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.DefaFldLength);
 arrValueListForInsert.Add(objSelfDefDataTypeEN.DefaFldLength.ToString());
 }
 
 arrFieldListForInsert.Add(conSelfDefDataType.DefaFldPrecision);
 arrValueListForInsert.Add(objSelfDefDataTypeEN.DefaFldPrecision.ToString());
 
 if (objSelfDefDataTypeEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.PrjId);
 var strPrjId = objSelfDefDataTypeEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objSelfDefDataTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.UpdDate);
 var strUpdDate = objSelfDefDataTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objSelfDefDataTypeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.UpdUser);
 var strUpdUser = objSelfDefDataTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objSelfDefDataTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.Memo);
 var strMemo = objSelfDefDataTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SelfDefDataType");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSelfDefDataTypeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objSelfDefDataTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsSelfDefDataTypeEN objSelfDefDataTypeEN)
{
 objSelfDefDataTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSelfDefDataTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSelfDefDataTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSelfDefDataTypeEN.SdDataTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.SdDataTypeId);
 var strSdDataTypeId = objSelfDefDataTypeEN.SdDataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSdDataTypeId + "'");
 }
 
 if (objSelfDefDataTypeEN.DataTypeName !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.DataTypeName);
 var strDataTypeName = objSelfDefDataTypeEN.DataTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataTypeName + "'");
 }
 
 arrFieldListForInsert.Add(conSelfDefDataType.IsObject);
 arrValueListForInsert.Add("'" + (objSelfDefDataTypeEN.IsObject  ==  false ? "0" : "1") + "'");
 
 if (objSelfDefDataTypeEN.DefaVarName !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.DefaVarName);
 var strDefaVarName = objSelfDefDataTypeEN.DefaVarName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDefaVarName + "'");
 }
 
 if (objSelfDefDataTypeEN.DataCnName !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.DataCnName);
 var strDataCnName = objSelfDefDataTypeEN.DataCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataCnName + "'");
 }
 
 if (objSelfDefDataTypeEN.DataTypeAbbr !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.DataTypeAbbr);
 var strDataTypeAbbr = objSelfDefDataTypeEN.DataTypeAbbr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataTypeAbbr + "'");
 }
 
 if (objSelfDefDataTypeEN.VbNetType !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.VbNetType);
 var strVbNetType = objSelfDefDataTypeEN.VbNetType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVbNetType + "'");
 }
 
 if (objSelfDefDataTypeEN.CsType !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.CsType);
 var strCsType = objSelfDefDataTypeEN.CsType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCsType + "'");
 }
 
 if (objSelfDefDataTypeEN.JavaType !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.JavaType);
 var strJavaType = objSelfDefDataTypeEN.JavaType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strJavaType + "'");
 }
 
 if (objSelfDefDataTypeEN.JavaObjType !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.JavaObjType);
 var strJavaObjType = objSelfDefDataTypeEN.JavaObjType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strJavaObjType + "'");
 }
 
 if (objSelfDefDataTypeEN.SwiftType !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.SwiftType);
 var strSwiftType = objSelfDefDataTypeEN.SwiftType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSwiftType + "'");
 }
 
 arrFieldListForInsert.Add(conSelfDefDataType.IsNeedQuote);
 arrValueListForInsert.Add("'" + (objSelfDefDataTypeEN.IsNeedQuote  ==  false ? "0" : "1") + "'");
 
 if (objSelfDefDataTypeEN.OraDbType !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.OraDbType);
 var strOraDbType = objSelfDefDataTypeEN.OraDbType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOraDbType + "'");
 }
 
 arrFieldListForInsert.Add(conSelfDefDataType.IsReturnType);
 arrValueListForInsert.Add("'" + (objSelfDefDataTypeEN.IsReturnType  ==  false ? "0" : "1") + "'");
 
 if (objSelfDefDataTypeEN.SqlParaType !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.SqlParaType);
 var strSqlParaType = objSelfDefDataTypeEN.SqlParaType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSqlParaType + "'");
 }
 
 if (objSelfDefDataTypeEN.MySqlType !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.MySqlType);
 var strMySqlType = objSelfDefDataTypeEN.MySqlType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMySqlType + "'");
 }
 
 if (objSelfDefDataTypeEN.DefaFldLength !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.DefaFldLength);
 arrValueListForInsert.Add(objSelfDefDataTypeEN.DefaFldLength.ToString());
 }
 
 arrFieldListForInsert.Add(conSelfDefDataType.DefaFldPrecision);
 arrValueListForInsert.Add(objSelfDefDataTypeEN.DefaFldPrecision.ToString());
 
 if (objSelfDefDataTypeEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.PrjId);
 var strPrjId = objSelfDefDataTypeEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objSelfDefDataTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.UpdDate);
 var strUpdDate = objSelfDefDataTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objSelfDefDataTypeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.UpdUser);
 var strUpdUser = objSelfDefDataTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objSelfDefDataTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.Memo);
 var strMemo = objSelfDefDataTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SelfDefDataType");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSelfDefDataTypeDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objSelfDefDataTypeEN.SdDataTypeId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objSelfDefDataTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsSelfDefDataTypeEN objSelfDefDataTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objSelfDefDataTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSelfDefDataTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSelfDefDataTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSelfDefDataTypeEN.SdDataTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.SdDataTypeId);
 var strSdDataTypeId = objSelfDefDataTypeEN.SdDataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSdDataTypeId + "'");
 }
 
 if (objSelfDefDataTypeEN.DataTypeName !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.DataTypeName);
 var strDataTypeName = objSelfDefDataTypeEN.DataTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataTypeName + "'");
 }
 
 arrFieldListForInsert.Add(conSelfDefDataType.IsObject);
 arrValueListForInsert.Add("'" + (objSelfDefDataTypeEN.IsObject  ==  false ? "0" : "1") + "'");
 
 if (objSelfDefDataTypeEN.DefaVarName !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.DefaVarName);
 var strDefaVarName = objSelfDefDataTypeEN.DefaVarName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDefaVarName + "'");
 }
 
 if (objSelfDefDataTypeEN.DataCnName !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.DataCnName);
 var strDataCnName = objSelfDefDataTypeEN.DataCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataCnName + "'");
 }
 
 if (objSelfDefDataTypeEN.DataTypeAbbr !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.DataTypeAbbr);
 var strDataTypeAbbr = objSelfDefDataTypeEN.DataTypeAbbr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataTypeAbbr + "'");
 }
 
 if (objSelfDefDataTypeEN.VbNetType !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.VbNetType);
 var strVbNetType = objSelfDefDataTypeEN.VbNetType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVbNetType + "'");
 }
 
 if (objSelfDefDataTypeEN.CsType !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.CsType);
 var strCsType = objSelfDefDataTypeEN.CsType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCsType + "'");
 }
 
 if (objSelfDefDataTypeEN.JavaType !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.JavaType);
 var strJavaType = objSelfDefDataTypeEN.JavaType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strJavaType + "'");
 }
 
 if (objSelfDefDataTypeEN.JavaObjType !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.JavaObjType);
 var strJavaObjType = objSelfDefDataTypeEN.JavaObjType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strJavaObjType + "'");
 }
 
 if (objSelfDefDataTypeEN.SwiftType !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.SwiftType);
 var strSwiftType = objSelfDefDataTypeEN.SwiftType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSwiftType + "'");
 }
 
 arrFieldListForInsert.Add(conSelfDefDataType.IsNeedQuote);
 arrValueListForInsert.Add("'" + (objSelfDefDataTypeEN.IsNeedQuote  ==  false ? "0" : "1") + "'");
 
 if (objSelfDefDataTypeEN.OraDbType !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.OraDbType);
 var strOraDbType = objSelfDefDataTypeEN.OraDbType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOraDbType + "'");
 }
 
 arrFieldListForInsert.Add(conSelfDefDataType.IsReturnType);
 arrValueListForInsert.Add("'" + (objSelfDefDataTypeEN.IsReturnType  ==  false ? "0" : "1") + "'");
 
 if (objSelfDefDataTypeEN.SqlParaType !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.SqlParaType);
 var strSqlParaType = objSelfDefDataTypeEN.SqlParaType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSqlParaType + "'");
 }
 
 if (objSelfDefDataTypeEN.MySqlType !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.MySqlType);
 var strMySqlType = objSelfDefDataTypeEN.MySqlType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMySqlType + "'");
 }
 
 if (objSelfDefDataTypeEN.DefaFldLength !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.DefaFldLength);
 arrValueListForInsert.Add(objSelfDefDataTypeEN.DefaFldLength.ToString());
 }
 
 arrFieldListForInsert.Add(conSelfDefDataType.DefaFldPrecision);
 arrValueListForInsert.Add(objSelfDefDataTypeEN.DefaFldPrecision.ToString());
 
 if (objSelfDefDataTypeEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.PrjId);
 var strPrjId = objSelfDefDataTypeEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objSelfDefDataTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.UpdDate);
 var strUpdDate = objSelfDefDataTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objSelfDefDataTypeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.UpdUser);
 var strUpdUser = objSelfDefDataTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objSelfDefDataTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.Memo);
 var strMemo = objSelfDefDataTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SelfDefDataType");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSelfDefDataTypeDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objSelfDefDataTypeEN.SdDataTypeId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objSelfDefDataTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsSelfDefDataTypeEN objSelfDefDataTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objSelfDefDataTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSelfDefDataTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSelfDefDataTypeEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSelfDefDataTypeEN.SdDataTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.SdDataTypeId);
 var strSdDataTypeId = objSelfDefDataTypeEN.SdDataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSdDataTypeId + "'");
 }
 
 if (objSelfDefDataTypeEN.DataTypeName !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.DataTypeName);
 var strDataTypeName = objSelfDefDataTypeEN.DataTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataTypeName + "'");
 }
 
 arrFieldListForInsert.Add(conSelfDefDataType.IsObject);
 arrValueListForInsert.Add("'" + (objSelfDefDataTypeEN.IsObject  ==  false ? "0" : "1") + "'");
 
 if (objSelfDefDataTypeEN.DefaVarName !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.DefaVarName);
 var strDefaVarName = objSelfDefDataTypeEN.DefaVarName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDefaVarName + "'");
 }
 
 if (objSelfDefDataTypeEN.DataCnName !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.DataCnName);
 var strDataCnName = objSelfDefDataTypeEN.DataCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataCnName + "'");
 }
 
 if (objSelfDefDataTypeEN.DataTypeAbbr !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.DataTypeAbbr);
 var strDataTypeAbbr = objSelfDefDataTypeEN.DataTypeAbbr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataTypeAbbr + "'");
 }
 
 if (objSelfDefDataTypeEN.VbNetType !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.VbNetType);
 var strVbNetType = objSelfDefDataTypeEN.VbNetType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVbNetType + "'");
 }
 
 if (objSelfDefDataTypeEN.CsType !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.CsType);
 var strCsType = objSelfDefDataTypeEN.CsType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCsType + "'");
 }
 
 if (objSelfDefDataTypeEN.JavaType !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.JavaType);
 var strJavaType = objSelfDefDataTypeEN.JavaType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strJavaType + "'");
 }
 
 if (objSelfDefDataTypeEN.JavaObjType !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.JavaObjType);
 var strJavaObjType = objSelfDefDataTypeEN.JavaObjType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strJavaObjType + "'");
 }
 
 if (objSelfDefDataTypeEN.SwiftType !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.SwiftType);
 var strSwiftType = objSelfDefDataTypeEN.SwiftType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSwiftType + "'");
 }
 
 arrFieldListForInsert.Add(conSelfDefDataType.IsNeedQuote);
 arrValueListForInsert.Add("'" + (objSelfDefDataTypeEN.IsNeedQuote  ==  false ? "0" : "1") + "'");
 
 if (objSelfDefDataTypeEN.OraDbType !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.OraDbType);
 var strOraDbType = objSelfDefDataTypeEN.OraDbType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOraDbType + "'");
 }
 
 arrFieldListForInsert.Add(conSelfDefDataType.IsReturnType);
 arrValueListForInsert.Add("'" + (objSelfDefDataTypeEN.IsReturnType  ==  false ? "0" : "1") + "'");
 
 if (objSelfDefDataTypeEN.SqlParaType !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.SqlParaType);
 var strSqlParaType = objSelfDefDataTypeEN.SqlParaType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSqlParaType + "'");
 }
 
 if (objSelfDefDataTypeEN.MySqlType !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.MySqlType);
 var strMySqlType = objSelfDefDataTypeEN.MySqlType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMySqlType + "'");
 }
 
 if (objSelfDefDataTypeEN.DefaFldLength !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.DefaFldLength);
 arrValueListForInsert.Add(objSelfDefDataTypeEN.DefaFldLength.ToString());
 }
 
 arrFieldListForInsert.Add(conSelfDefDataType.DefaFldPrecision);
 arrValueListForInsert.Add(objSelfDefDataTypeEN.DefaFldPrecision.ToString());
 
 if (objSelfDefDataTypeEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.PrjId);
 var strPrjId = objSelfDefDataTypeEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objSelfDefDataTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.UpdDate);
 var strUpdDate = objSelfDefDataTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objSelfDefDataTypeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.UpdUser);
 var strUpdUser = objSelfDefDataTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objSelfDefDataTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSelfDefDataType.Memo);
 var strMemo = objSelfDefDataTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SelfDefDataType");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSelfDefDataTypeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewSelfDefDataTypes(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSelfDefDataTypeDA.GetSpecSQLObj();
strSQL = "Select * from SelfDefDataType where SdDataTypeId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "SelfDefDataType");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strSdDataTypeId = oRow[conSelfDefDataType.SdDataTypeId].ToString().Trim();
if (IsExist(strSdDataTypeId))
{
 string strResult = "关键字变量值为:" + string.Format("SdDataTypeId = {0}", strSdDataTypeId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsSelfDefDataTypeEN._CurrTabName ].NewRow();
objRow[conSelfDefDataType.SdDataTypeId] = oRow[conSelfDefDataType.SdDataTypeId].ToString().Trim(); //自定义数据类型Id
objRow[conSelfDefDataType.DataTypeName] = oRow[conSelfDefDataType.DataTypeName].ToString().Trim(); //数据类型名称
objRow[conSelfDefDataType.IsObject] = oRow[conSelfDefDataType.IsObject].ToString().Trim(); //是否对象
objRow[conSelfDefDataType.DefaVarName] = oRow[conSelfDefDataType.DefaVarName].ToString().Trim(); //默认变量名
objRow[conSelfDefDataType.DataCnName] = oRow[conSelfDefDataType.DataCnName].ToString().Trim(); //数据类型中文名称
objRow[conSelfDefDataType.DataTypeAbbr] = oRow[conSelfDefDataType.DataTypeAbbr].ToString().Trim(); //数据类型缩写
objRow[conSelfDefDataType.VbNetType] = oRow[conSelfDefDataType.VbNetType].ToString().Trim(); //VBNET类型
objRow[conSelfDefDataType.CsType] = oRow[conSelfDefDataType.CsType].ToString().Trim(); //CS类型
objRow[conSelfDefDataType.JavaType] = oRow[conSelfDefDataType.JavaType].ToString().Trim(); //JAVA类型
objRow[conSelfDefDataType.JavaObjType] = oRow[conSelfDefDataType.JavaObjType].ToString().Trim(); //JAVA对象类型
objRow[conSelfDefDataType.SwiftType] = oRow[conSelfDefDataType.SwiftType].ToString().Trim(); //SwiftType
objRow[conSelfDefDataType.IsNeedQuote] = oRow[conSelfDefDataType.IsNeedQuote].ToString().Trim(); //是否需要引号
objRow[conSelfDefDataType.OraDbType] = oRow[conSelfDefDataType.OraDbType].ToString().Trim(); //Ora数据类型
objRow[conSelfDefDataType.IsReturnType] = oRow[conSelfDefDataType.IsReturnType].ToString().Trim(); //是否可作返回类型
objRow[conSelfDefDataType.SqlParaType] = oRow[conSelfDefDataType.SqlParaType].ToString().Trim(); //SQL参数类型
objRow[conSelfDefDataType.MySqlType] = oRow[conSelfDefDataType.MySqlType].ToString().Trim(); //MySqlType
objRow[conSelfDefDataType.DefaFldLength] = oRow[conSelfDefDataType.DefaFldLength].ToString().Trim(); //默认长度
objRow[conSelfDefDataType.DefaFldPrecision] = oRow[conSelfDefDataType.DefaFldPrecision].ToString().Trim(); //默认小数位数
objRow[conSelfDefDataType.PrjId] = oRow[conSelfDefDataType.PrjId].ToString().Trim(); //工程Id
objRow[conSelfDefDataType.UpdDate] = oRow[conSelfDefDataType.UpdDate].ToString().Trim(); //修改日期
objRow[conSelfDefDataType.UpdUser] = oRow[conSelfDefDataType.UpdUser].ToString().Trim(); //修改者
objRow[conSelfDefDataType.Memo] = oRow[conSelfDefDataType.Memo].ToString().Trim(); //说明
 objDS.Tables[clsSelfDefDataTypeEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsSelfDefDataTypeEN._CurrTabName);
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
 /// <param name = "objSelfDefDataTypeEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsSelfDefDataTypeEN objSelfDefDataTypeEN)
{
 objSelfDefDataTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSelfDefDataTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSelfDefDataTypeEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSelfDefDataTypeDA.GetSpecSQLObj();
strSQL = "Select * from SelfDefDataType where SdDataTypeId = " + "'"+ objSelfDefDataTypeEN.SdDataTypeId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsSelfDefDataTypeEN._CurrTabName);
if (objDS.Tables[clsSelfDefDataTypeEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:SdDataTypeId = " + "'"+ objSelfDefDataTypeEN.SdDataTypeId+"'");
return false;
}
objRow = objDS.Tables[clsSelfDefDataTypeEN._CurrTabName].Rows[0];
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.SdDataTypeId))
 {
objRow[conSelfDefDataType.SdDataTypeId] = objSelfDefDataTypeEN.SdDataTypeId; //自定义数据类型Id
 }
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.DataTypeName))
 {
objRow[conSelfDefDataType.DataTypeName] = objSelfDefDataTypeEN.DataTypeName; //数据类型名称
 }
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.IsObject))
 {
objRow[conSelfDefDataType.IsObject] = objSelfDefDataTypeEN.IsObject; //是否对象
 }
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.DefaVarName))
 {
objRow[conSelfDefDataType.DefaVarName] = objSelfDefDataTypeEN.DefaVarName; //默认变量名
 }
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.DataCnName))
 {
objRow[conSelfDefDataType.DataCnName] = objSelfDefDataTypeEN.DataCnName; //数据类型中文名称
 }
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.DataTypeAbbr))
 {
objRow[conSelfDefDataType.DataTypeAbbr] = objSelfDefDataTypeEN.DataTypeAbbr; //数据类型缩写
 }
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.VbNetType))
 {
objRow[conSelfDefDataType.VbNetType] = objSelfDefDataTypeEN.VbNetType; //VBNET类型
 }
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.CsType))
 {
objRow[conSelfDefDataType.CsType] = objSelfDefDataTypeEN.CsType; //CS类型
 }
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.JavaType))
 {
objRow[conSelfDefDataType.JavaType] = objSelfDefDataTypeEN.JavaType; //JAVA类型
 }
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.JavaObjType))
 {
objRow[conSelfDefDataType.JavaObjType] = objSelfDefDataTypeEN.JavaObjType; //JAVA对象类型
 }
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.SwiftType))
 {
objRow[conSelfDefDataType.SwiftType] = objSelfDefDataTypeEN.SwiftType; //SwiftType
 }
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.IsNeedQuote))
 {
objRow[conSelfDefDataType.IsNeedQuote] = objSelfDefDataTypeEN.IsNeedQuote; //是否需要引号
 }
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.OraDbType))
 {
objRow[conSelfDefDataType.OraDbType] = objSelfDefDataTypeEN.OraDbType; //Ora数据类型
 }
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.IsReturnType))
 {
objRow[conSelfDefDataType.IsReturnType] = objSelfDefDataTypeEN.IsReturnType; //是否可作返回类型
 }
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.SqlParaType))
 {
objRow[conSelfDefDataType.SqlParaType] = objSelfDefDataTypeEN.SqlParaType; //SQL参数类型
 }
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.MySqlType))
 {
objRow[conSelfDefDataType.MySqlType] = objSelfDefDataTypeEN.MySqlType; //MySqlType
 }
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.DefaFldLength))
 {
objRow[conSelfDefDataType.DefaFldLength] = objSelfDefDataTypeEN.DefaFldLength; //默认长度
 }
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.DefaFldPrecision))
 {
objRow[conSelfDefDataType.DefaFldPrecision] = objSelfDefDataTypeEN.DefaFldPrecision; //默认小数位数
 }
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.PrjId))
 {
objRow[conSelfDefDataType.PrjId] = objSelfDefDataTypeEN.PrjId; //工程Id
 }
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.UpdDate))
 {
objRow[conSelfDefDataType.UpdDate] = objSelfDefDataTypeEN.UpdDate; //修改日期
 }
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.UpdUser))
 {
objRow[conSelfDefDataType.UpdUser] = objSelfDefDataTypeEN.UpdUser; //修改者
 }
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.Memo))
 {
objRow[conSelfDefDataType.Memo] = objSelfDefDataTypeEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsSelfDefDataTypeEN._CurrTabName);
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
 /// <param name = "objSelfDefDataTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsSelfDefDataTypeEN objSelfDefDataTypeEN)
{
 objSelfDefDataTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSelfDefDataTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSelfDefDataTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSelfDefDataTypeDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update SelfDefDataType Set ");
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.DataTypeName))
 {
 if (objSelfDefDataTypeEN.DataTypeName !=  null)
 {
 var strDataTypeName = objSelfDefDataTypeEN.DataTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataTypeName, conSelfDefDataType.DataTypeName); //数据类型名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSelfDefDataType.DataTypeName); //数据类型名称
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.IsObject))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objSelfDefDataTypeEN.IsObject == true?"1":"0", conSelfDefDataType.IsObject); //是否对象
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.DefaVarName))
 {
 if (objSelfDefDataTypeEN.DefaVarName !=  null)
 {
 var strDefaVarName = objSelfDefDataTypeEN.DefaVarName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDefaVarName, conSelfDefDataType.DefaVarName); //默认变量名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSelfDefDataType.DefaVarName); //默认变量名
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.DataCnName))
 {
 if (objSelfDefDataTypeEN.DataCnName !=  null)
 {
 var strDataCnName = objSelfDefDataTypeEN.DataCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataCnName, conSelfDefDataType.DataCnName); //数据类型中文名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSelfDefDataType.DataCnName); //数据类型中文名称
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.DataTypeAbbr))
 {
 if (objSelfDefDataTypeEN.DataTypeAbbr !=  null)
 {
 var strDataTypeAbbr = objSelfDefDataTypeEN.DataTypeAbbr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataTypeAbbr, conSelfDefDataType.DataTypeAbbr); //数据类型缩写
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSelfDefDataType.DataTypeAbbr); //数据类型缩写
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.VbNetType))
 {
 if (objSelfDefDataTypeEN.VbNetType !=  null)
 {
 var strVbNetType = objSelfDefDataTypeEN.VbNetType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVbNetType, conSelfDefDataType.VbNetType); //VBNET类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSelfDefDataType.VbNetType); //VBNET类型
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.CsType))
 {
 if (objSelfDefDataTypeEN.CsType !=  null)
 {
 var strCsType = objSelfDefDataTypeEN.CsType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCsType, conSelfDefDataType.CsType); //CS类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSelfDefDataType.CsType); //CS类型
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.JavaType))
 {
 if (objSelfDefDataTypeEN.JavaType !=  null)
 {
 var strJavaType = objSelfDefDataTypeEN.JavaType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strJavaType, conSelfDefDataType.JavaType); //JAVA类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSelfDefDataType.JavaType); //JAVA类型
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.JavaObjType))
 {
 if (objSelfDefDataTypeEN.JavaObjType !=  null)
 {
 var strJavaObjType = objSelfDefDataTypeEN.JavaObjType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strJavaObjType, conSelfDefDataType.JavaObjType); //JAVA对象类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSelfDefDataType.JavaObjType); //JAVA对象类型
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.SwiftType))
 {
 if (objSelfDefDataTypeEN.SwiftType !=  null)
 {
 var strSwiftType = objSelfDefDataTypeEN.SwiftType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSwiftType, conSelfDefDataType.SwiftType); //SwiftType
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSelfDefDataType.SwiftType); //SwiftType
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.IsNeedQuote))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objSelfDefDataTypeEN.IsNeedQuote == true?"1":"0", conSelfDefDataType.IsNeedQuote); //是否需要引号
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.OraDbType))
 {
 if (objSelfDefDataTypeEN.OraDbType !=  null)
 {
 var strOraDbType = objSelfDefDataTypeEN.OraDbType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOraDbType, conSelfDefDataType.OraDbType); //Ora数据类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSelfDefDataType.OraDbType); //Ora数据类型
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.IsReturnType))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objSelfDefDataTypeEN.IsReturnType == true?"1":"0", conSelfDefDataType.IsReturnType); //是否可作返回类型
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.SqlParaType))
 {
 if (objSelfDefDataTypeEN.SqlParaType !=  null)
 {
 var strSqlParaType = objSelfDefDataTypeEN.SqlParaType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSqlParaType, conSelfDefDataType.SqlParaType); //SQL参数类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSelfDefDataType.SqlParaType); //SQL参数类型
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.MySqlType))
 {
 if (objSelfDefDataTypeEN.MySqlType !=  null)
 {
 var strMySqlType = objSelfDefDataTypeEN.MySqlType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMySqlType, conSelfDefDataType.MySqlType); //MySqlType
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSelfDefDataType.MySqlType); //MySqlType
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.DefaFldLength))
 {
 if (objSelfDefDataTypeEN.DefaFldLength !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSelfDefDataTypeEN.DefaFldLength, conSelfDefDataType.DefaFldLength); //默认长度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSelfDefDataType.DefaFldLength); //默认长度
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.DefaFldPrecision))
 {
 sbSQL.AppendFormat("{1} = {0},",objSelfDefDataTypeEN.DefaFldPrecision, conSelfDefDataType.DefaFldPrecision); //默认小数位数
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.PrjId))
 {
 if (objSelfDefDataTypeEN.PrjId !=  null)
 {
 var strPrjId = objSelfDefDataTypeEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conSelfDefDataType.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSelfDefDataType.PrjId); //工程Id
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.UpdDate))
 {
 if (objSelfDefDataTypeEN.UpdDate !=  null)
 {
 var strUpdDate = objSelfDefDataTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conSelfDefDataType.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSelfDefDataType.UpdDate); //修改日期
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.UpdUser))
 {
 if (objSelfDefDataTypeEN.UpdUser !=  null)
 {
 var strUpdUser = objSelfDefDataTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conSelfDefDataType.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSelfDefDataType.UpdUser); //修改者
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.Memo))
 {
 if (objSelfDefDataTypeEN.Memo !=  null)
 {
 var strMemo = objSelfDefDataTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conSelfDefDataType.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSelfDefDataType.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where SdDataTypeId = '{0}'", objSelfDefDataTypeEN.SdDataTypeId); 
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
 /// <param name = "objSelfDefDataTypeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsSelfDefDataTypeEN objSelfDefDataTypeEN, string strCondition)
{
 objSelfDefDataTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSelfDefDataTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSelfDefDataTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSelfDefDataTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SelfDefDataType Set ");
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.DataTypeName))
 {
 if (objSelfDefDataTypeEN.DataTypeName !=  null)
 {
 var strDataTypeName = objSelfDefDataTypeEN.DataTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataTypeName = '{0}',", strDataTypeName); //数据类型名称
 }
 else
 {
 sbSQL.Append(" DataTypeName = null,"); //数据类型名称
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.IsObject))
 {
 sbSQL.AppendFormat(" IsObject = '{0}',", objSelfDefDataTypeEN.IsObject == true?"1":"0"); //是否对象
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.DefaVarName))
 {
 if (objSelfDefDataTypeEN.DefaVarName !=  null)
 {
 var strDefaVarName = objSelfDefDataTypeEN.DefaVarName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DefaVarName = '{0}',", strDefaVarName); //默认变量名
 }
 else
 {
 sbSQL.Append(" DefaVarName = null,"); //默认变量名
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.DataCnName))
 {
 if (objSelfDefDataTypeEN.DataCnName !=  null)
 {
 var strDataCnName = objSelfDefDataTypeEN.DataCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataCnName = '{0}',", strDataCnName); //数据类型中文名称
 }
 else
 {
 sbSQL.Append(" DataCnName = null,"); //数据类型中文名称
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.DataTypeAbbr))
 {
 if (objSelfDefDataTypeEN.DataTypeAbbr !=  null)
 {
 var strDataTypeAbbr = objSelfDefDataTypeEN.DataTypeAbbr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataTypeAbbr = '{0}',", strDataTypeAbbr); //数据类型缩写
 }
 else
 {
 sbSQL.Append(" DataTypeAbbr = null,"); //数据类型缩写
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.VbNetType))
 {
 if (objSelfDefDataTypeEN.VbNetType !=  null)
 {
 var strVbNetType = objSelfDefDataTypeEN.VbNetType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VbNetType = '{0}',", strVbNetType); //VBNET类型
 }
 else
 {
 sbSQL.Append(" VbNetType = null,"); //VBNET类型
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.CsType))
 {
 if (objSelfDefDataTypeEN.CsType !=  null)
 {
 var strCsType = objSelfDefDataTypeEN.CsType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CsType = '{0}',", strCsType); //CS类型
 }
 else
 {
 sbSQL.Append(" CsType = null,"); //CS类型
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.JavaType))
 {
 if (objSelfDefDataTypeEN.JavaType !=  null)
 {
 var strJavaType = objSelfDefDataTypeEN.JavaType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" JavaType = '{0}',", strJavaType); //JAVA类型
 }
 else
 {
 sbSQL.Append(" JavaType = null,"); //JAVA类型
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.JavaObjType))
 {
 if (objSelfDefDataTypeEN.JavaObjType !=  null)
 {
 var strJavaObjType = objSelfDefDataTypeEN.JavaObjType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" JavaObjType = '{0}',", strJavaObjType); //JAVA对象类型
 }
 else
 {
 sbSQL.Append(" JavaObjType = null,"); //JAVA对象类型
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.SwiftType))
 {
 if (objSelfDefDataTypeEN.SwiftType !=  null)
 {
 var strSwiftType = objSelfDefDataTypeEN.SwiftType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SwiftType = '{0}',", strSwiftType); //SwiftType
 }
 else
 {
 sbSQL.Append(" SwiftType = null,"); //SwiftType
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.IsNeedQuote))
 {
 sbSQL.AppendFormat(" IsNeedQuote = '{0}',", objSelfDefDataTypeEN.IsNeedQuote == true?"1":"0"); //是否需要引号
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.OraDbType))
 {
 if (objSelfDefDataTypeEN.OraDbType !=  null)
 {
 var strOraDbType = objSelfDefDataTypeEN.OraDbType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OraDbType = '{0}',", strOraDbType); //Ora数据类型
 }
 else
 {
 sbSQL.Append(" OraDbType = null,"); //Ora数据类型
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.IsReturnType))
 {
 sbSQL.AppendFormat(" IsReturnType = '{0}',", objSelfDefDataTypeEN.IsReturnType == true?"1":"0"); //是否可作返回类型
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.SqlParaType))
 {
 if (objSelfDefDataTypeEN.SqlParaType !=  null)
 {
 var strSqlParaType = objSelfDefDataTypeEN.SqlParaType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SqlParaType = '{0}',", strSqlParaType); //SQL参数类型
 }
 else
 {
 sbSQL.Append(" SqlParaType = null,"); //SQL参数类型
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.MySqlType))
 {
 if (objSelfDefDataTypeEN.MySqlType !=  null)
 {
 var strMySqlType = objSelfDefDataTypeEN.MySqlType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MySqlType = '{0}',", strMySqlType); //MySqlType
 }
 else
 {
 sbSQL.Append(" MySqlType = null,"); //MySqlType
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.DefaFldLength))
 {
 if (objSelfDefDataTypeEN.DefaFldLength !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSelfDefDataTypeEN.DefaFldLength, conSelfDefDataType.DefaFldLength); //默认长度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSelfDefDataType.DefaFldLength); //默认长度
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.DefaFldPrecision))
 {
 sbSQL.AppendFormat(" DefaFldPrecision = {0},", objSelfDefDataTypeEN.DefaFldPrecision); //默认小数位数
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.PrjId))
 {
 if (objSelfDefDataTypeEN.PrjId !=  null)
 {
 var strPrjId = objSelfDefDataTypeEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.UpdDate))
 {
 if (objSelfDefDataTypeEN.UpdDate !=  null)
 {
 var strUpdDate = objSelfDefDataTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.UpdUser))
 {
 if (objSelfDefDataTypeEN.UpdUser !=  null)
 {
 var strUpdUser = objSelfDefDataTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.Memo))
 {
 if (objSelfDefDataTypeEN.Memo !=  null)
 {
 var strMemo = objSelfDefDataTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objSelfDefDataTypeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsSelfDefDataTypeEN objSelfDefDataTypeEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objSelfDefDataTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSelfDefDataTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSelfDefDataTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSelfDefDataTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SelfDefDataType Set ");
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.DataTypeName))
 {
 if (objSelfDefDataTypeEN.DataTypeName !=  null)
 {
 var strDataTypeName = objSelfDefDataTypeEN.DataTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataTypeName = '{0}',", strDataTypeName); //数据类型名称
 }
 else
 {
 sbSQL.Append(" DataTypeName = null,"); //数据类型名称
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.IsObject))
 {
 sbSQL.AppendFormat(" IsObject = '{0}',", objSelfDefDataTypeEN.IsObject == true?"1":"0"); //是否对象
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.DefaVarName))
 {
 if (objSelfDefDataTypeEN.DefaVarName !=  null)
 {
 var strDefaVarName = objSelfDefDataTypeEN.DefaVarName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DefaVarName = '{0}',", strDefaVarName); //默认变量名
 }
 else
 {
 sbSQL.Append(" DefaVarName = null,"); //默认变量名
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.DataCnName))
 {
 if (objSelfDefDataTypeEN.DataCnName !=  null)
 {
 var strDataCnName = objSelfDefDataTypeEN.DataCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataCnName = '{0}',", strDataCnName); //数据类型中文名称
 }
 else
 {
 sbSQL.Append(" DataCnName = null,"); //数据类型中文名称
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.DataTypeAbbr))
 {
 if (objSelfDefDataTypeEN.DataTypeAbbr !=  null)
 {
 var strDataTypeAbbr = objSelfDefDataTypeEN.DataTypeAbbr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataTypeAbbr = '{0}',", strDataTypeAbbr); //数据类型缩写
 }
 else
 {
 sbSQL.Append(" DataTypeAbbr = null,"); //数据类型缩写
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.VbNetType))
 {
 if (objSelfDefDataTypeEN.VbNetType !=  null)
 {
 var strVbNetType = objSelfDefDataTypeEN.VbNetType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VbNetType = '{0}',", strVbNetType); //VBNET类型
 }
 else
 {
 sbSQL.Append(" VbNetType = null,"); //VBNET类型
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.CsType))
 {
 if (objSelfDefDataTypeEN.CsType !=  null)
 {
 var strCsType = objSelfDefDataTypeEN.CsType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CsType = '{0}',", strCsType); //CS类型
 }
 else
 {
 sbSQL.Append(" CsType = null,"); //CS类型
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.JavaType))
 {
 if (objSelfDefDataTypeEN.JavaType !=  null)
 {
 var strJavaType = objSelfDefDataTypeEN.JavaType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" JavaType = '{0}',", strJavaType); //JAVA类型
 }
 else
 {
 sbSQL.Append(" JavaType = null,"); //JAVA类型
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.JavaObjType))
 {
 if (objSelfDefDataTypeEN.JavaObjType !=  null)
 {
 var strJavaObjType = objSelfDefDataTypeEN.JavaObjType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" JavaObjType = '{0}',", strJavaObjType); //JAVA对象类型
 }
 else
 {
 sbSQL.Append(" JavaObjType = null,"); //JAVA对象类型
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.SwiftType))
 {
 if (objSelfDefDataTypeEN.SwiftType !=  null)
 {
 var strSwiftType = objSelfDefDataTypeEN.SwiftType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SwiftType = '{0}',", strSwiftType); //SwiftType
 }
 else
 {
 sbSQL.Append(" SwiftType = null,"); //SwiftType
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.IsNeedQuote))
 {
 sbSQL.AppendFormat(" IsNeedQuote = '{0}',", objSelfDefDataTypeEN.IsNeedQuote == true?"1":"0"); //是否需要引号
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.OraDbType))
 {
 if (objSelfDefDataTypeEN.OraDbType !=  null)
 {
 var strOraDbType = objSelfDefDataTypeEN.OraDbType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OraDbType = '{0}',", strOraDbType); //Ora数据类型
 }
 else
 {
 sbSQL.Append(" OraDbType = null,"); //Ora数据类型
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.IsReturnType))
 {
 sbSQL.AppendFormat(" IsReturnType = '{0}',", objSelfDefDataTypeEN.IsReturnType == true?"1":"0"); //是否可作返回类型
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.SqlParaType))
 {
 if (objSelfDefDataTypeEN.SqlParaType !=  null)
 {
 var strSqlParaType = objSelfDefDataTypeEN.SqlParaType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SqlParaType = '{0}',", strSqlParaType); //SQL参数类型
 }
 else
 {
 sbSQL.Append(" SqlParaType = null,"); //SQL参数类型
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.MySqlType))
 {
 if (objSelfDefDataTypeEN.MySqlType !=  null)
 {
 var strMySqlType = objSelfDefDataTypeEN.MySqlType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MySqlType = '{0}',", strMySqlType); //MySqlType
 }
 else
 {
 sbSQL.Append(" MySqlType = null,"); //MySqlType
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.DefaFldLength))
 {
 if (objSelfDefDataTypeEN.DefaFldLength !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSelfDefDataTypeEN.DefaFldLength, conSelfDefDataType.DefaFldLength); //默认长度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSelfDefDataType.DefaFldLength); //默认长度
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.DefaFldPrecision))
 {
 sbSQL.AppendFormat(" DefaFldPrecision = {0},", objSelfDefDataTypeEN.DefaFldPrecision); //默认小数位数
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.PrjId))
 {
 if (objSelfDefDataTypeEN.PrjId !=  null)
 {
 var strPrjId = objSelfDefDataTypeEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.UpdDate))
 {
 if (objSelfDefDataTypeEN.UpdDate !=  null)
 {
 var strUpdDate = objSelfDefDataTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.UpdUser))
 {
 if (objSelfDefDataTypeEN.UpdUser !=  null)
 {
 var strUpdUser = objSelfDefDataTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.Memo))
 {
 if (objSelfDefDataTypeEN.Memo !=  null)
 {
 var strMemo = objSelfDefDataTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objSelfDefDataTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsSelfDefDataTypeEN objSelfDefDataTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objSelfDefDataTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSelfDefDataTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSelfDefDataTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSelfDefDataTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SelfDefDataType Set ");
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.DataTypeName))
 {
 if (objSelfDefDataTypeEN.DataTypeName !=  null)
 {
 var strDataTypeName = objSelfDefDataTypeEN.DataTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataTypeName, conSelfDefDataType.DataTypeName); //数据类型名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSelfDefDataType.DataTypeName); //数据类型名称
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.IsObject))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objSelfDefDataTypeEN.IsObject == true?"1":"0", conSelfDefDataType.IsObject); //是否对象
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.DefaVarName))
 {
 if (objSelfDefDataTypeEN.DefaVarName !=  null)
 {
 var strDefaVarName = objSelfDefDataTypeEN.DefaVarName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDefaVarName, conSelfDefDataType.DefaVarName); //默认变量名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSelfDefDataType.DefaVarName); //默认变量名
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.DataCnName))
 {
 if (objSelfDefDataTypeEN.DataCnName !=  null)
 {
 var strDataCnName = objSelfDefDataTypeEN.DataCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataCnName, conSelfDefDataType.DataCnName); //数据类型中文名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSelfDefDataType.DataCnName); //数据类型中文名称
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.DataTypeAbbr))
 {
 if (objSelfDefDataTypeEN.DataTypeAbbr !=  null)
 {
 var strDataTypeAbbr = objSelfDefDataTypeEN.DataTypeAbbr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataTypeAbbr, conSelfDefDataType.DataTypeAbbr); //数据类型缩写
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSelfDefDataType.DataTypeAbbr); //数据类型缩写
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.VbNetType))
 {
 if (objSelfDefDataTypeEN.VbNetType !=  null)
 {
 var strVbNetType = objSelfDefDataTypeEN.VbNetType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVbNetType, conSelfDefDataType.VbNetType); //VBNET类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSelfDefDataType.VbNetType); //VBNET类型
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.CsType))
 {
 if (objSelfDefDataTypeEN.CsType !=  null)
 {
 var strCsType = objSelfDefDataTypeEN.CsType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCsType, conSelfDefDataType.CsType); //CS类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSelfDefDataType.CsType); //CS类型
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.JavaType))
 {
 if (objSelfDefDataTypeEN.JavaType !=  null)
 {
 var strJavaType = objSelfDefDataTypeEN.JavaType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strJavaType, conSelfDefDataType.JavaType); //JAVA类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSelfDefDataType.JavaType); //JAVA类型
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.JavaObjType))
 {
 if (objSelfDefDataTypeEN.JavaObjType !=  null)
 {
 var strJavaObjType = objSelfDefDataTypeEN.JavaObjType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strJavaObjType, conSelfDefDataType.JavaObjType); //JAVA对象类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSelfDefDataType.JavaObjType); //JAVA对象类型
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.SwiftType))
 {
 if (objSelfDefDataTypeEN.SwiftType !=  null)
 {
 var strSwiftType = objSelfDefDataTypeEN.SwiftType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSwiftType, conSelfDefDataType.SwiftType); //SwiftType
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSelfDefDataType.SwiftType); //SwiftType
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.IsNeedQuote))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objSelfDefDataTypeEN.IsNeedQuote == true?"1":"0", conSelfDefDataType.IsNeedQuote); //是否需要引号
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.OraDbType))
 {
 if (objSelfDefDataTypeEN.OraDbType !=  null)
 {
 var strOraDbType = objSelfDefDataTypeEN.OraDbType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOraDbType, conSelfDefDataType.OraDbType); //Ora数据类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSelfDefDataType.OraDbType); //Ora数据类型
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.IsReturnType))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objSelfDefDataTypeEN.IsReturnType == true?"1":"0", conSelfDefDataType.IsReturnType); //是否可作返回类型
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.SqlParaType))
 {
 if (objSelfDefDataTypeEN.SqlParaType !=  null)
 {
 var strSqlParaType = objSelfDefDataTypeEN.SqlParaType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSqlParaType, conSelfDefDataType.SqlParaType); //SQL参数类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSelfDefDataType.SqlParaType); //SQL参数类型
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.MySqlType))
 {
 if (objSelfDefDataTypeEN.MySqlType !=  null)
 {
 var strMySqlType = objSelfDefDataTypeEN.MySqlType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMySqlType, conSelfDefDataType.MySqlType); //MySqlType
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSelfDefDataType.MySqlType); //MySqlType
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.DefaFldLength))
 {
 if (objSelfDefDataTypeEN.DefaFldLength !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSelfDefDataTypeEN.DefaFldLength, conSelfDefDataType.DefaFldLength); //默认长度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSelfDefDataType.DefaFldLength); //默认长度
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.DefaFldPrecision))
 {
 sbSQL.AppendFormat("{1} = {0},",objSelfDefDataTypeEN.DefaFldPrecision, conSelfDefDataType.DefaFldPrecision); //默认小数位数
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.PrjId))
 {
 if (objSelfDefDataTypeEN.PrjId !=  null)
 {
 var strPrjId = objSelfDefDataTypeEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conSelfDefDataType.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSelfDefDataType.PrjId); //工程Id
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.UpdDate))
 {
 if (objSelfDefDataTypeEN.UpdDate !=  null)
 {
 var strUpdDate = objSelfDefDataTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conSelfDefDataType.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSelfDefDataType.UpdDate); //修改日期
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.UpdUser))
 {
 if (objSelfDefDataTypeEN.UpdUser !=  null)
 {
 var strUpdUser = objSelfDefDataTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conSelfDefDataType.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSelfDefDataType.UpdUser); //修改者
 }
 }
 
 if (objSelfDefDataTypeEN.IsUpdated(conSelfDefDataType.Memo))
 {
 if (objSelfDefDataTypeEN.Memo !=  null)
 {
 var strMemo = objSelfDefDataTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conSelfDefDataType.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSelfDefDataType.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where SdDataTypeId = '{0}'", objSelfDefDataTypeEN.SdDataTypeId); 
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
 /// <param name = "strSdDataTypeId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strSdDataTypeId) 
{
CheckPrimaryKey(strSdDataTypeId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSelfDefDataTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strSdDataTypeId,
};
 objSQL.ExecSP("SelfDefDataType_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strSdDataTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strSdDataTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strSdDataTypeId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSelfDefDataTypeDA.GetSpecSQLObj();
//删除SelfDefDataType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SelfDefDataType where SdDataTypeId = " + "'"+ strSdDataTypeId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelSelfDefDataType(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSelfDefDataTypeDA.GetSpecSQLObj();
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
//删除SelfDefDataType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SelfDefDataType where SdDataTypeId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strSdDataTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strSdDataTypeId) 
{
CheckPrimaryKey(strSdDataTypeId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSelfDefDataTypeDA.GetSpecSQLObj();
//删除SelfDefDataType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SelfDefDataType where SdDataTypeId = " + "'"+ strSdDataTypeId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelSelfDefDataType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsSelfDefDataTypeDA: DelSelfDefDataType)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSelfDefDataTypeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from SelfDefDataType where " + strCondition ;
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
public bool DelSelfDefDataTypeWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsSelfDefDataTypeDA: DelSelfDefDataTypeWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSelfDefDataTypeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from SelfDefDataType where " + strCondition ;
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
 /// <param name = "objSelfDefDataTypeENS">源对象</param>
 /// <param name = "objSelfDefDataTypeENT">目标对象</param>
public void CopyTo(clsSelfDefDataTypeEN objSelfDefDataTypeENS, clsSelfDefDataTypeEN objSelfDefDataTypeENT)
{
objSelfDefDataTypeENT.SdDataTypeId = objSelfDefDataTypeENS.SdDataTypeId; //自定义数据类型Id
objSelfDefDataTypeENT.DataTypeName = objSelfDefDataTypeENS.DataTypeName; //数据类型名称
objSelfDefDataTypeENT.IsObject = objSelfDefDataTypeENS.IsObject; //是否对象
objSelfDefDataTypeENT.DefaVarName = objSelfDefDataTypeENS.DefaVarName; //默认变量名
objSelfDefDataTypeENT.DataCnName = objSelfDefDataTypeENS.DataCnName; //数据类型中文名称
objSelfDefDataTypeENT.DataTypeAbbr = objSelfDefDataTypeENS.DataTypeAbbr; //数据类型缩写
objSelfDefDataTypeENT.VbNetType = objSelfDefDataTypeENS.VbNetType; //VBNET类型
objSelfDefDataTypeENT.CsType = objSelfDefDataTypeENS.CsType; //CS类型
objSelfDefDataTypeENT.JavaType = objSelfDefDataTypeENS.JavaType; //JAVA类型
objSelfDefDataTypeENT.JavaObjType = objSelfDefDataTypeENS.JavaObjType; //JAVA对象类型
objSelfDefDataTypeENT.SwiftType = objSelfDefDataTypeENS.SwiftType; //SwiftType
objSelfDefDataTypeENT.IsNeedQuote = objSelfDefDataTypeENS.IsNeedQuote; //是否需要引号
objSelfDefDataTypeENT.OraDbType = objSelfDefDataTypeENS.OraDbType; //Ora数据类型
objSelfDefDataTypeENT.IsReturnType = objSelfDefDataTypeENS.IsReturnType; //是否可作返回类型
objSelfDefDataTypeENT.SqlParaType = objSelfDefDataTypeENS.SqlParaType; //SQL参数类型
objSelfDefDataTypeENT.MySqlType = objSelfDefDataTypeENS.MySqlType; //MySqlType
objSelfDefDataTypeENT.DefaFldLength = objSelfDefDataTypeENS.DefaFldLength; //默认长度
objSelfDefDataTypeENT.DefaFldPrecision = objSelfDefDataTypeENS.DefaFldPrecision; //默认小数位数
objSelfDefDataTypeENT.PrjId = objSelfDefDataTypeENS.PrjId; //工程Id
objSelfDefDataTypeENT.UpdDate = objSelfDefDataTypeENS.UpdDate; //修改日期
objSelfDefDataTypeENT.UpdUser = objSelfDefDataTypeENS.UpdUser; //修改者
objSelfDefDataTypeENT.Memo = objSelfDefDataTypeENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsSelfDefDataTypeEN objSelfDefDataTypeEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objSelfDefDataTypeEN.DataTypeName, conSelfDefDataType.DataTypeName);
clsCheckSql.CheckFieldNotNull(objSelfDefDataTypeEN.CsType, conSelfDefDataType.CsType);
clsCheckSql.CheckFieldNotNull(objSelfDefDataTypeEN.IsNeedQuote, conSelfDefDataType.IsNeedQuote);
clsCheckSql.CheckFieldNotNull(objSelfDefDataTypeEN.DefaFldPrecision, conSelfDefDataType.DefaFldPrecision);
//检查字段长度
clsCheckSql.CheckFieldLen(objSelfDefDataTypeEN.SdDataTypeId, 4, conSelfDefDataType.SdDataTypeId);
clsCheckSql.CheckFieldLen(objSelfDefDataTypeEN.DataTypeName, 100, conSelfDefDataType.DataTypeName);
clsCheckSql.CheckFieldLen(objSelfDefDataTypeEN.DefaVarName, 50, conSelfDefDataType.DefaVarName);
clsCheckSql.CheckFieldLen(objSelfDefDataTypeEN.DataCnName, 100, conSelfDefDataType.DataCnName);
clsCheckSql.CheckFieldLen(objSelfDefDataTypeEN.DataTypeAbbr, 5, conSelfDefDataType.DataTypeAbbr);
clsCheckSql.CheckFieldLen(objSelfDefDataTypeEN.VbNetType, 100, conSelfDefDataType.VbNetType);
clsCheckSql.CheckFieldLen(objSelfDefDataTypeEN.CsType, 100, conSelfDefDataType.CsType);
clsCheckSql.CheckFieldLen(objSelfDefDataTypeEN.JavaType, 100, conSelfDefDataType.JavaType);
clsCheckSql.CheckFieldLen(objSelfDefDataTypeEN.JavaObjType, 100, conSelfDefDataType.JavaObjType);
clsCheckSql.CheckFieldLen(objSelfDefDataTypeEN.SwiftType, 100, conSelfDefDataType.SwiftType);
clsCheckSql.CheckFieldLen(objSelfDefDataTypeEN.OraDbType, 100, conSelfDefDataType.OraDbType);
clsCheckSql.CheckFieldLen(objSelfDefDataTypeEN.SqlParaType, 100, conSelfDefDataType.SqlParaType);
clsCheckSql.CheckFieldLen(objSelfDefDataTypeEN.MySqlType, 100, conSelfDefDataType.MySqlType);
clsCheckSql.CheckFieldLen(objSelfDefDataTypeEN.PrjId, 4, conSelfDefDataType.PrjId);
clsCheckSql.CheckFieldLen(objSelfDefDataTypeEN.UpdDate, 20, conSelfDefDataType.UpdDate);
clsCheckSql.CheckFieldLen(objSelfDefDataTypeEN.UpdUser, 20, conSelfDefDataType.UpdUser);
clsCheckSql.CheckFieldLen(objSelfDefDataTypeEN.Memo, 1000, conSelfDefDataType.Memo);
//检查字段外键固定长度
 objSelfDefDataTypeEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsSelfDefDataTypeEN objSelfDefDataTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objSelfDefDataTypeEN.DataTypeName, 100, conSelfDefDataType.DataTypeName);
clsCheckSql.CheckFieldLen(objSelfDefDataTypeEN.DefaVarName, 50, conSelfDefDataType.DefaVarName);
clsCheckSql.CheckFieldLen(objSelfDefDataTypeEN.DataCnName, 100, conSelfDefDataType.DataCnName);
clsCheckSql.CheckFieldLen(objSelfDefDataTypeEN.DataTypeAbbr, 5, conSelfDefDataType.DataTypeAbbr);
clsCheckSql.CheckFieldLen(objSelfDefDataTypeEN.VbNetType, 100, conSelfDefDataType.VbNetType);
clsCheckSql.CheckFieldLen(objSelfDefDataTypeEN.CsType, 100, conSelfDefDataType.CsType);
clsCheckSql.CheckFieldLen(objSelfDefDataTypeEN.JavaType, 100, conSelfDefDataType.JavaType);
clsCheckSql.CheckFieldLen(objSelfDefDataTypeEN.JavaObjType, 100, conSelfDefDataType.JavaObjType);
clsCheckSql.CheckFieldLen(objSelfDefDataTypeEN.SwiftType, 100, conSelfDefDataType.SwiftType);
clsCheckSql.CheckFieldLen(objSelfDefDataTypeEN.OraDbType, 100, conSelfDefDataType.OraDbType);
clsCheckSql.CheckFieldLen(objSelfDefDataTypeEN.SqlParaType, 100, conSelfDefDataType.SqlParaType);
clsCheckSql.CheckFieldLen(objSelfDefDataTypeEN.MySqlType, 100, conSelfDefDataType.MySqlType);
clsCheckSql.CheckFieldLen(objSelfDefDataTypeEN.PrjId, 4, conSelfDefDataType.PrjId);
clsCheckSql.CheckFieldLen(objSelfDefDataTypeEN.UpdDate, 20, conSelfDefDataType.UpdDate);
clsCheckSql.CheckFieldLen(objSelfDefDataTypeEN.UpdUser, 20, conSelfDefDataType.UpdUser);
clsCheckSql.CheckFieldLen(objSelfDefDataTypeEN.Memo, 1000, conSelfDefDataType.Memo);
//检查外键字段长度
 objSelfDefDataTypeEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsSelfDefDataTypeEN objSelfDefDataTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objSelfDefDataTypeEN.SdDataTypeId, 4, conSelfDefDataType.SdDataTypeId);
clsCheckSql.CheckFieldLen(objSelfDefDataTypeEN.DataTypeName, 100, conSelfDefDataType.DataTypeName);
clsCheckSql.CheckFieldLen(objSelfDefDataTypeEN.DefaVarName, 50, conSelfDefDataType.DefaVarName);
clsCheckSql.CheckFieldLen(objSelfDefDataTypeEN.DataCnName, 100, conSelfDefDataType.DataCnName);
clsCheckSql.CheckFieldLen(objSelfDefDataTypeEN.DataTypeAbbr, 5, conSelfDefDataType.DataTypeAbbr);
clsCheckSql.CheckFieldLen(objSelfDefDataTypeEN.VbNetType, 100, conSelfDefDataType.VbNetType);
clsCheckSql.CheckFieldLen(objSelfDefDataTypeEN.CsType, 100, conSelfDefDataType.CsType);
clsCheckSql.CheckFieldLen(objSelfDefDataTypeEN.JavaType, 100, conSelfDefDataType.JavaType);
clsCheckSql.CheckFieldLen(objSelfDefDataTypeEN.JavaObjType, 100, conSelfDefDataType.JavaObjType);
clsCheckSql.CheckFieldLen(objSelfDefDataTypeEN.SwiftType, 100, conSelfDefDataType.SwiftType);
clsCheckSql.CheckFieldLen(objSelfDefDataTypeEN.OraDbType, 100, conSelfDefDataType.OraDbType);
clsCheckSql.CheckFieldLen(objSelfDefDataTypeEN.SqlParaType, 100, conSelfDefDataType.SqlParaType);
clsCheckSql.CheckFieldLen(objSelfDefDataTypeEN.MySqlType, 100, conSelfDefDataType.MySqlType);
clsCheckSql.CheckFieldLen(objSelfDefDataTypeEN.PrjId, 4, conSelfDefDataType.PrjId);
clsCheckSql.CheckFieldLen(objSelfDefDataTypeEN.UpdDate, 20, conSelfDefDataType.UpdDate);
clsCheckSql.CheckFieldLen(objSelfDefDataTypeEN.UpdUser, 20, conSelfDefDataType.UpdUser);
clsCheckSql.CheckFieldLen(objSelfDefDataTypeEN.Memo, 1000, conSelfDefDataType.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objSelfDefDataTypeEN.SdDataTypeId, conSelfDefDataType.SdDataTypeId);
clsCheckSql.CheckSqlInjection4Field(objSelfDefDataTypeEN.DataTypeName, conSelfDefDataType.DataTypeName);
clsCheckSql.CheckSqlInjection4Field(objSelfDefDataTypeEN.DefaVarName, conSelfDefDataType.DefaVarName);
clsCheckSql.CheckSqlInjection4Field(objSelfDefDataTypeEN.DataCnName, conSelfDefDataType.DataCnName);
clsCheckSql.CheckSqlInjection4Field(objSelfDefDataTypeEN.DataTypeAbbr, conSelfDefDataType.DataTypeAbbr);
clsCheckSql.CheckSqlInjection4Field(objSelfDefDataTypeEN.VbNetType, conSelfDefDataType.VbNetType);
clsCheckSql.CheckSqlInjection4Field(objSelfDefDataTypeEN.CsType, conSelfDefDataType.CsType);
clsCheckSql.CheckSqlInjection4Field(objSelfDefDataTypeEN.JavaType, conSelfDefDataType.JavaType);
clsCheckSql.CheckSqlInjection4Field(objSelfDefDataTypeEN.JavaObjType, conSelfDefDataType.JavaObjType);
clsCheckSql.CheckSqlInjection4Field(objSelfDefDataTypeEN.SwiftType, conSelfDefDataType.SwiftType);
clsCheckSql.CheckSqlInjection4Field(objSelfDefDataTypeEN.OraDbType, conSelfDefDataType.OraDbType);
clsCheckSql.CheckSqlInjection4Field(objSelfDefDataTypeEN.SqlParaType, conSelfDefDataType.SqlParaType);
clsCheckSql.CheckSqlInjection4Field(objSelfDefDataTypeEN.MySqlType, conSelfDefDataType.MySqlType);
clsCheckSql.CheckSqlInjection4Field(objSelfDefDataTypeEN.PrjId, conSelfDefDataType.PrjId);
clsCheckSql.CheckSqlInjection4Field(objSelfDefDataTypeEN.UpdDate, conSelfDefDataType.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objSelfDefDataTypeEN.UpdUser, conSelfDefDataType.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objSelfDefDataTypeEN.Memo, conSelfDefDataType.Memo);
//检查外键字段长度
 objSelfDefDataTypeEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetSdDataTypeId()
{
//获取某学院所有专业信息
string strSQL = "select SdDataTypeId, DataTypeName from SelfDefDataType ";
 clsSpecSQLforSql mySql = clsSelfDefDataTypeDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--SelfDefDataType(自定义数据类型),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objSelfDefDataTypeEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsSelfDefDataTypeEN objSelfDefDataTypeEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and DataTypeName = '{0}'", objSelfDefDataTypeEN.DataTypeName);
 if (objSelfDefDataTypeEN.PrjId == null)
{
 sbCondition.AppendFormat(" and PrjId is null");
}
else
{
 sbCondition.AppendFormat(" and PrjId = '{0}'", objSelfDefDataTypeEN.PrjId);
}
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
 objSQL = clsSelfDefDataTypeDA.GetSpecSQLObj();
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
 objSQL = clsSelfDefDataTypeDA.GetSpecSQLObj();
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
 objSQL = clsSelfDefDataTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsSelfDefDataTypeEN._CurrTabName);
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
 objSQL = clsSelfDefDataTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsSelfDefDataTypeEN._CurrTabName, strCondition);
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
 objSQL = clsSelfDefDataTypeDA.GetSpecSQLObj();
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
 objSQL = clsSelfDefDataTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}