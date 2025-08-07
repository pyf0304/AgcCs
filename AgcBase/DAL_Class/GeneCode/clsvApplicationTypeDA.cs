
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvApplicationTypeDA
 表名:vApplicationType(00050403)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:48:26
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
 /// v应用程序类型(vApplicationType)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvApplicationTypeDA : clsCommBase4DA
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
 return clsvApplicationTypeEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvApplicationTypeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvApplicationTypeEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvApplicationTypeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvApplicationTypeEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvApplicationTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvApplicationTypeDA.GetSpecSQLObj();
strSQL = "Select * from vApplicationType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vApplicationType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvApplicationTypeDA: GetDataTable_vApplicationType)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvApplicationTypeDA.GetSpecSQLObj();
strSQL = "Select * from vApplicationType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvApplicationTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvApplicationTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvApplicationTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvApplicationTypeDA.GetSpecSQLObj();
strSQL = "Select * from vApplicationType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvApplicationTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvApplicationTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvApplicationTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvApplicationTypeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vApplicationType where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vApplicationType where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvApplicationTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvApplicationTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vApplicationType where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvApplicationTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvApplicationTypeDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vApplicationType.* " + 
$"from vApplicationType " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vApplicationType.ApplicationTypeId not in " + 
$"(Select top {intTop_In} vApplicationType.ApplicationTypeId from vApplicationType " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vApplicationType where {1} and ApplicationTypeId not in (Select top {2} ApplicationTypeId from vApplicationType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vApplicationType where {1} and ApplicationTypeId not in (Select top {3} ApplicationTypeId from vApplicationType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvApplicationTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvApplicationTypeDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vApplicationType.* " + 
$"from vApplicationType " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vApplicationType.ApplicationTypeId not in " + 
$"(Select top {intTop_In} vApplicationType.ApplicationTypeId from vApplicationType " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vApplicationType where {1} and ApplicationTypeId not in (Select top {2} ApplicationTypeId from vApplicationType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vApplicationType where {1} and ApplicationTypeId not in (Select top {3} ApplicationTypeId from vApplicationType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvApplicationTypeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvApplicationTypeDA:GetObjLst)", objException.Message));
}
List<clsvApplicationTypeEN> arrObjLst = new List<clsvApplicationTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvApplicationTypeDA.GetSpecSQLObj();
strSQL = "Select * from vApplicationType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvApplicationTypeEN objvApplicationTypeEN = new clsvApplicationTypeEN();
try
{
objvApplicationTypeEN.ApplicationTypeId = TransNullToInt(objRow[convApplicationType.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvApplicationTypeEN.ApplicationTypeName = objRow[convApplicationType.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvApplicationTypeEN.ApplicationTypeSimName = objRow[convApplicationType.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convApplicationType.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvApplicationTypeEN.ApplicationTypeENName = objRow[convApplicationType.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvApplicationTypeEN.ProgLangTypeId = objRow[convApplicationType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvApplicationTypeEN.ProgLangTypeName = objRow[convApplicationType.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvApplicationTypeEN.ProgLangTypeENName = objRow[convApplicationType.ProgLangTypeENName] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeENName].ToString().Trim(); //编程语言类型英文名
objvApplicationTypeEN.CharEncodingId = objRow[convApplicationType.CharEncodingId].ToString().Trim(); //字符编码
objvApplicationTypeEN.CharEncodingName = objRow[convApplicationType.CharEncodingName] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName].ToString().Trim(); //字符编码名称
objvApplicationTypeEN.ProgLangTypeId2 = objRow[convApplicationType.ProgLangTypeId2] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId2].ToString().Trim(); //编程语言类型Id2
objvApplicationTypeEN.ProgLangTypeId3 = objRow[convApplicationType.ProgLangTypeId3] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId3].ToString().Trim(); //编程语言类型Id3
objvApplicationTypeEN.ProgLangTypeId4 = objRow[convApplicationType.ProgLangTypeId4] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId4].ToString().Trim(); //编程语言类型Id4
objvApplicationTypeEN.ProgLangTypeId5 = objRow[convApplicationType.ProgLangTypeId5] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId5].ToString().Trim(); //编程语言类型Id5
objvApplicationTypeEN.IsVisible = TransNullToBool(objRow[convApplicationType.IsVisible].ToString().Trim()); //是否显示
objvApplicationTypeEN.OrderNum = TransNullToInt(objRow[convApplicationType.OrderNum].ToString().Trim()); //序号
objvApplicationTypeEN.Memo = objRow[convApplicationType.Memo] == DBNull.Value ? null : objRow[convApplicationType.Memo].ToString().Trim(); //说明
objvApplicationTypeEN.CharEncodingId2 = objRow[convApplicationType.CharEncodingId2] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId2].ToString().Trim(); //CharEncodingId2
objvApplicationTypeEN.CharEncodingId3 = objRow[convApplicationType.CharEncodingId3] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId3].ToString().Trim(); //CharEncodingId3
objvApplicationTypeEN.CharEncodingName2 = objRow[convApplicationType.CharEncodingName2] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName2].ToString().Trim(); //CharEncodingName2
objvApplicationTypeEN.CharEncodingName3 = objRow[convApplicationType.CharEncodingName3] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName3].ToString().Trim(); //CharEncodingName3
objvApplicationTypeEN.ProgLangTypeName2 = objRow[convApplicationType.ProgLangTypeName2] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName2].ToString().Trim(); //ProgLangTypeName2
objvApplicationTypeEN.ProgLangTypeName3 = objRow[convApplicationType.ProgLangTypeName3] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName3].ToString().Trim(); //ProgLangTypeName3
objvApplicationTypeEN.ProgLangTypeName5 = objRow[convApplicationType.ProgLangTypeName5] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName5].ToString().Trim(); //ProgLangTypeName5
objvApplicationTypeEN.CodeTypeCount = objRow[convApplicationType.CodeTypeCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convApplicationType.CodeTypeCount].ToString().Trim()); //代码类型数
objvApplicationTypeEN.CharEncodingId4 = objRow[convApplicationType.CharEncodingId4] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId4].ToString().Trim(); //CharEncodingId4
objvApplicationTypeEN.CharEncodingName4 = objRow[convApplicationType.CharEncodingName4] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName4].ToString().Trim(); //CharEncodingName4
objvApplicationTypeEN.ProgLangTypeName4 = objRow[convApplicationType.ProgLangTypeName4] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName4].ToString().Trim(); //ProgLangTypeName4
objvApplicationTypeEN.CharEncodingId5 = objRow[convApplicationType.CharEncodingId5] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId5].ToString().Trim(); //CharEncodingId5
objvApplicationTypeEN.CharEncodingName5 = objRow[convApplicationType.CharEncodingName5] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName5].ToString().Trim(); //CharEncodingName5
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvApplicationTypeDA: GetObjLst)", objException.Message));
}
objvApplicationTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvApplicationTypeEN);
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
public List<clsvApplicationTypeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvApplicationTypeDA:GetObjLstByTabName)", objException.Message));
}
List<clsvApplicationTypeEN> arrObjLst = new List<clsvApplicationTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvApplicationTypeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvApplicationTypeEN objvApplicationTypeEN = new clsvApplicationTypeEN();
try
{
objvApplicationTypeEN.ApplicationTypeId = TransNullToInt(objRow[convApplicationType.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvApplicationTypeEN.ApplicationTypeName = objRow[convApplicationType.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvApplicationTypeEN.ApplicationTypeSimName = objRow[convApplicationType.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convApplicationType.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvApplicationTypeEN.ApplicationTypeENName = objRow[convApplicationType.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvApplicationTypeEN.ProgLangTypeId = objRow[convApplicationType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvApplicationTypeEN.ProgLangTypeName = objRow[convApplicationType.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvApplicationTypeEN.ProgLangTypeENName = objRow[convApplicationType.ProgLangTypeENName] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeENName].ToString().Trim(); //编程语言类型英文名
objvApplicationTypeEN.CharEncodingId = objRow[convApplicationType.CharEncodingId].ToString().Trim(); //字符编码
objvApplicationTypeEN.CharEncodingName = objRow[convApplicationType.CharEncodingName] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName].ToString().Trim(); //字符编码名称
objvApplicationTypeEN.ProgLangTypeId2 = objRow[convApplicationType.ProgLangTypeId2] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId2].ToString().Trim(); //编程语言类型Id2
objvApplicationTypeEN.ProgLangTypeId3 = objRow[convApplicationType.ProgLangTypeId3] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId3].ToString().Trim(); //编程语言类型Id3
objvApplicationTypeEN.ProgLangTypeId4 = objRow[convApplicationType.ProgLangTypeId4] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId4].ToString().Trim(); //编程语言类型Id4
objvApplicationTypeEN.ProgLangTypeId5 = objRow[convApplicationType.ProgLangTypeId5] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId5].ToString().Trim(); //编程语言类型Id5
objvApplicationTypeEN.IsVisible = TransNullToBool(objRow[convApplicationType.IsVisible].ToString().Trim()); //是否显示
objvApplicationTypeEN.OrderNum = TransNullToInt(objRow[convApplicationType.OrderNum].ToString().Trim()); //序号
objvApplicationTypeEN.Memo = objRow[convApplicationType.Memo] == DBNull.Value ? null : objRow[convApplicationType.Memo].ToString().Trim(); //说明
objvApplicationTypeEN.CharEncodingId2 = objRow[convApplicationType.CharEncodingId2] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId2].ToString().Trim(); //CharEncodingId2
objvApplicationTypeEN.CharEncodingId3 = objRow[convApplicationType.CharEncodingId3] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId3].ToString().Trim(); //CharEncodingId3
objvApplicationTypeEN.CharEncodingName2 = objRow[convApplicationType.CharEncodingName2] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName2].ToString().Trim(); //CharEncodingName2
objvApplicationTypeEN.CharEncodingName3 = objRow[convApplicationType.CharEncodingName3] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName3].ToString().Trim(); //CharEncodingName3
objvApplicationTypeEN.ProgLangTypeName2 = objRow[convApplicationType.ProgLangTypeName2] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName2].ToString().Trim(); //ProgLangTypeName2
objvApplicationTypeEN.ProgLangTypeName3 = objRow[convApplicationType.ProgLangTypeName3] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName3].ToString().Trim(); //ProgLangTypeName3
objvApplicationTypeEN.ProgLangTypeName5 = objRow[convApplicationType.ProgLangTypeName5] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName5].ToString().Trim(); //ProgLangTypeName5
objvApplicationTypeEN.CodeTypeCount = objRow[convApplicationType.CodeTypeCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convApplicationType.CodeTypeCount].ToString().Trim()); //代码类型数
objvApplicationTypeEN.CharEncodingId4 = objRow[convApplicationType.CharEncodingId4] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId4].ToString().Trim(); //CharEncodingId4
objvApplicationTypeEN.CharEncodingName4 = objRow[convApplicationType.CharEncodingName4] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName4].ToString().Trim(); //CharEncodingName4
objvApplicationTypeEN.ProgLangTypeName4 = objRow[convApplicationType.ProgLangTypeName4] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName4].ToString().Trim(); //ProgLangTypeName4
objvApplicationTypeEN.CharEncodingId5 = objRow[convApplicationType.CharEncodingId5] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId5].ToString().Trim(); //CharEncodingId5
objvApplicationTypeEN.CharEncodingName5 = objRow[convApplicationType.CharEncodingName5] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName5].ToString().Trim(); //CharEncodingName5
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvApplicationTypeDA: GetObjLst)", objException.Message));
}
objvApplicationTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvApplicationTypeEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvApplicationType(ref clsvApplicationTypeEN objvApplicationTypeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvApplicationTypeDA.GetSpecSQLObj();
strSQL = "Select * from vApplicationType where ApplicationTypeId = " + ""+ objvApplicationTypeEN.ApplicationTypeId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvApplicationTypeEN.ApplicationTypeId = TransNullToInt(objDT.Rows[0][convApplicationType.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objvApplicationTypeEN.ApplicationTypeName = objDT.Rows[0][convApplicationType.ApplicationTypeName].ToString().Trim(); //应用程序类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvApplicationTypeEN.ApplicationTypeSimName = objDT.Rows[0][convApplicationType.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvApplicationTypeEN.ApplicationTypeENName = objDT.Rows[0][convApplicationType.ApplicationTypeENName].ToString().Trim(); //应用类型英文名(字段类型:varchar,字段长度:30,是否可空:False)
 objvApplicationTypeEN.ProgLangTypeId = objDT.Rows[0][convApplicationType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvApplicationTypeEN.ProgLangTypeName = objDT.Rows[0][convApplicationType.ProgLangTypeName].ToString().Trim(); //编程语言类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvApplicationTypeEN.ProgLangTypeENName = objDT.Rows[0][convApplicationType.ProgLangTypeENName].ToString().Trim(); //编程语言类型英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objvApplicationTypeEN.CharEncodingId = objDT.Rows[0][convApplicationType.CharEncodingId].ToString().Trim(); //字符编码(字段类型:varchar,字段长度:20,是否可空:False)
 objvApplicationTypeEN.CharEncodingName = objDT.Rows[0][convApplicationType.CharEncodingName].ToString().Trim(); //字符编码名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvApplicationTypeEN.ProgLangTypeId2 = objDT.Rows[0][convApplicationType.ProgLangTypeId2].ToString().Trim(); //编程语言类型Id2(字段类型:char,字段长度:2,是否可空:True)
 objvApplicationTypeEN.ProgLangTypeId3 = objDT.Rows[0][convApplicationType.ProgLangTypeId3].ToString().Trim(); //编程语言类型Id3(字段类型:char,字段长度:2,是否可空:True)
 objvApplicationTypeEN.ProgLangTypeId4 = objDT.Rows[0][convApplicationType.ProgLangTypeId4].ToString().Trim(); //编程语言类型Id4(字段类型:char,字段长度:2,是否可空:True)
 objvApplicationTypeEN.ProgLangTypeId5 = objDT.Rows[0][convApplicationType.ProgLangTypeId5].ToString().Trim(); //编程语言类型Id5(字段类型:char,字段长度:2,是否可空:True)
 objvApplicationTypeEN.IsVisible = TransNullToBool(objDT.Rows[0][convApplicationType.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvApplicationTypeEN.OrderNum = TransNullToInt(objDT.Rows[0][convApplicationType.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvApplicationTypeEN.Memo = objDT.Rows[0][convApplicationType.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvApplicationTypeEN.CharEncodingId2 = objDT.Rows[0][convApplicationType.CharEncodingId2].ToString().Trim(); //CharEncodingId2(字段类型:varchar,字段长度:20,是否可空:True)
 objvApplicationTypeEN.CharEncodingId3 = objDT.Rows[0][convApplicationType.CharEncodingId3].ToString().Trim(); //CharEncodingId3(字段类型:varchar,字段长度:20,是否可空:True)
 objvApplicationTypeEN.CharEncodingName2 = objDT.Rows[0][convApplicationType.CharEncodingName2].ToString().Trim(); //CharEncodingName2(字段类型:varchar,字段长度:100,是否可空:True)
 objvApplicationTypeEN.CharEncodingName3 = objDT.Rows[0][convApplicationType.CharEncodingName3].ToString().Trim(); //CharEncodingName3(字段类型:varchar,字段长度:100,是否可空:True)
 objvApplicationTypeEN.ProgLangTypeName2 = objDT.Rows[0][convApplicationType.ProgLangTypeName2].ToString().Trim(); //ProgLangTypeName2(字段类型:varchar,字段长度:30,是否可空:True)
 objvApplicationTypeEN.ProgLangTypeName3 = objDT.Rows[0][convApplicationType.ProgLangTypeName3].ToString().Trim(); //ProgLangTypeName3(字段类型:varchar,字段长度:30,是否可空:True)
 objvApplicationTypeEN.ProgLangTypeName5 = objDT.Rows[0][convApplicationType.ProgLangTypeName5].ToString().Trim(); //ProgLangTypeName5(字段类型:varchar,字段长度:30,是否可空:True)
 objvApplicationTypeEN.CodeTypeCount = TransNullToInt(objDT.Rows[0][convApplicationType.CodeTypeCount].ToString().Trim()); //代码类型数(字段类型:int,字段长度:4,是否可空:True)
 objvApplicationTypeEN.CharEncodingId4 = objDT.Rows[0][convApplicationType.CharEncodingId4].ToString().Trim(); //CharEncodingId4(字段类型:varchar,字段长度:20,是否可空:True)
 objvApplicationTypeEN.CharEncodingName4 = objDT.Rows[0][convApplicationType.CharEncodingName4].ToString().Trim(); //CharEncodingName4(字段类型:varchar,字段长度:100,是否可空:True)
 objvApplicationTypeEN.ProgLangTypeName4 = objDT.Rows[0][convApplicationType.ProgLangTypeName4].ToString().Trim(); //ProgLangTypeName4(字段类型:varchar,字段长度:30,是否可空:True)
 objvApplicationTypeEN.CharEncodingId5 = objDT.Rows[0][convApplicationType.CharEncodingId5].ToString().Trim(); //CharEncodingId5(字段类型:varchar,字段长度:20,是否可空:True)
 objvApplicationTypeEN.CharEncodingName5 = objDT.Rows[0][convApplicationType.CharEncodingName5].ToString().Trim(); //CharEncodingName5(字段类型:varchar,字段长度:100,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvApplicationTypeDA: GetvApplicationType)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "intApplicationTypeId">表关键字</param>
 /// <returns>表对象</returns>
public clsvApplicationTypeEN GetObjByApplicationTypeId(int intApplicationTypeId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvApplicationTypeDA.GetSpecSQLObj();
strSQL = "Select * from vApplicationType where ApplicationTypeId = " + ""+ intApplicationTypeId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvApplicationTypeEN objvApplicationTypeEN = new clsvApplicationTypeEN();
try
{
 objvApplicationTypeEN.ApplicationTypeId = Int32.Parse(objRow[convApplicationType.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objvApplicationTypeEN.ApplicationTypeName = objRow[convApplicationType.ApplicationTypeName].ToString().Trim(); //应用程序类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvApplicationTypeEN.ApplicationTypeSimName = objRow[convApplicationType.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convApplicationType.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvApplicationTypeEN.ApplicationTypeENName = objRow[convApplicationType.ApplicationTypeENName].ToString().Trim(); //应用类型英文名(字段类型:varchar,字段长度:30,是否可空:False)
 objvApplicationTypeEN.ProgLangTypeId = objRow[convApplicationType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvApplicationTypeEN.ProgLangTypeName = objRow[convApplicationType.ProgLangTypeName].ToString().Trim(); //编程语言类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvApplicationTypeEN.ProgLangTypeENName = objRow[convApplicationType.ProgLangTypeENName] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeENName].ToString().Trim(); //编程语言类型英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objvApplicationTypeEN.CharEncodingId = objRow[convApplicationType.CharEncodingId].ToString().Trim(); //字符编码(字段类型:varchar,字段长度:20,是否可空:False)
 objvApplicationTypeEN.CharEncodingName = objRow[convApplicationType.CharEncodingName] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName].ToString().Trim(); //字符编码名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvApplicationTypeEN.ProgLangTypeId2 = objRow[convApplicationType.ProgLangTypeId2] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId2].ToString().Trim(); //编程语言类型Id2(字段类型:char,字段长度:2,是否可空:True)
 objvApplicationTypeEN.ProgLangTypeId3 = objRow[convApplicationType.ProgLangTypeId3] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId3].ToString().Trim(); //编程语言类型Id3(字段类型:char,字段长度:2,是否可空:True)
 objvApplicationTypeEN.ProgLangTypeId4 = objRow[convApplicationType.ProgLangTypeId4] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId4].ToString().Trim(); //编程语言类型Id4(字段类型:char,字段长度:2,是否可空:True)
 objvApplicationTypeEN.ProgLangTypeId5 = objRow[convApplicationType.ProgLangTypeId5] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId5].ToString().Trim(); //编程语言类型Id5(字段类型:char,字段长度:2,是否可空:True)
 objvApplicationTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convApplicationType.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvApplicationTypeEN.OrderNum = Int32.Parse(objRow[convApplicationType.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvApplicationTypeEN.Memo = objRow[convApplicationType.Memo] == DBNull.Value ? null : objRow[convApplicationType.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvApplicationTypeEN.CharEncodingId2 = objRow[convApplicationType.CharEncodingId2] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId2].ToString().Trim(); //CharEncodingId2(字段类型:varchar,字段长度:20,是否可空:True)
 objvApplicationTypeEN.CharEncodingId3 = objRow[convApplicationType.CharEncodingId3] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId3].ToString().Trim(); //CharEncodingId3(字段类型:varchar,字段长度:20,是否可空:True)
 objvApplicationTypeEN.CharEncodingName2 = objRow[convApplicationType.CharEncodingName2] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName2].ToString().Trim(); //CharEncodingName2(字段类型:varchar,字段长度:100,是否可空:True)
 objvApplicationTypeEN.CharEncodingName3 = objRow[convApplicationType.CharEncodingName3] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName3].ToString().Trim(); //CharEncodingName3(字段类型:varchar,字段长度:100,是否可空:True)
 objvApplicationTypeEN.ProgLangTypeName2 = objRow[convApplicationType.ProgLangTypeName2] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName2].ToString().Trim(); //ProgLangTypeName2(字段类型:varchar,字段长度:30,是否可空:True)
 objvApplicationTypeEN.ProgLangTypeName3 = objRow[convApplicationType.ProgLangTypeName3] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName3].ToString().Trim(); //ProgLangTypeName3(字段类型:varchar,字段长度:30,是否可空:True)
 objvApplicationTypeEN.ProgLangTypeName5 = objRow[convApplicationType.ProgLangTypeName5] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName5].ToString().Trim(); //ProgLangTypeName5(字段类型:varchar,字段长度:30,是否可空:True)
 objvApplicationTypeEN.CodeTypeCount = objRow[convApplicationType.CodeTypeCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convApplicationType.CodeTypeCount].ToString().Trim()); //代码类型数(字段类型:int,字段长度:4,是否可空:True)
 objvApplicationTypeEN.CharEncodingId4 = objRow[convApplicationType.CharEncodingId4] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId4].ToString().Trim(); //CharEncodingId4(字段类型:varchar,字段长度:20,是否可空:True)
 objvApplicationTypeEN.CharEncodingName4 = objRow[convApplicationType.CharEncodingName4] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName4].ToString().Trim(); //CharEncodingName4(字段类型:varchar,字段长度:100,是否可空:True)
 objvApplicationTypeEN.ProgLangTypeName4 = objRow[convApplicationType.ProgLangTypeName4] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName4].ToString().Trim(); //ProgLangTypeName4(字段类型:varchar,字段长度:30,是否可空:True)
 objvApplicationTypeEN.CharEncodingId5 = objRow[convApplicationType.CharEncodingId5] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId5].ToString().Trim(); //CharEncodingId5(字段类型:varchar,字段长度:20,是否可空:True)
 objvApplicationTypeEN.CharEncodingName5 = objRow[convApplicationType.CharEncodingName5] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName5].ToString().Trim(); //CharEncodingName5(字段类型:varchar,字段长度:100,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvApplicationTypeDA: GetObjByApplicationTypeId)", objException.Message));
}
return objvApplicationTypeEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvApplicationTypeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvApplicationTypeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvApplicationTypeDA.GetSpecSQLObj();
strSQL = "Select * from vApplicationType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvApplicationTypeEN objvApplicationTypeEN = new clsvApplicationTypeEN()
{
ApplicationTypeId = TransNullToInt(objRow[convApplicationType.ApplicationTypeId].ToString().Trim()), //应用程序类型ID
ApplicationTypeName = objRow[convApplicationType.ApplicationTypeName].ToString().Trim(), //应用程序类型名称
ApplicationTypeSimName = objRow[convApplicationType.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convApplicationType.ApplicationTypeSimName].ToString().Trim(), //应用程序类型简称
ApplicationTypeENName = objRow[convApplicationType.ApplicationTypeENName].ToString().Trim(), //应用类型英文名
ProgLangTypeId = objRow[convApplicationType.ProgLangTypeId].ToString().Trim(), //编程语言类型Id
ProgLangTypeName = objRow[convApplicationType.ProgLangTypeName].ToString().Trim(), //编程语言类型名
ProgLangTypeENName = objRow[convApplicationType.ProgLangTypeENName] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeENName].ToString().Trim(), //编程语言类型英文名
CharEncodingId = objRow[convApplicationType.CharEncodingId].ToString().Trim(), //字符编码
CharEncodingName = objRow[convApplicationType.CharEncodingName] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName].ToString().Trim(), //字符编码名称
ProgLangTypeId2 = objRow[convApplicationType.ProgLangTypeId2] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId2].ToString().Trim(), //编程语言类型Id2
ProgLangTypeId3 = objRow[convApplicationType.ProgLangTypeId3] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId3].ToString().Trim(), //编程语言类型Id3
ProgLangTypeId4 = objRow[convApplicationType.ProgLangTypeId4] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId4].ToString().Trim(), //编程语言类型Id4
ProgLangTypeId5 = objRow[convApplicationType.ProgLangTypeId5] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId5].ToString().Trim(), //编程语言类型Id5
IsVisible = TransNullToBool(objRow[convApplicationType.IsVisible].ToString().Trim()), //是否显示
OrderNum = TransNullToInt(objRow[convApplicationType.OrderNum].ToString().Trim()), //序号
Memo = objRow[convApplicationType.Memo] == DBNull.Value ? null : objRow[convApplicationType.Memo].ToString().Trim(), //说明
CharEncodingId2 = objRow[convApplicationType.CharEncodingId2] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId2].ToString().Trim(), //CharEncodingId2
CharEncodingId3 = objRow[convApplicationType.CharEncodingId3] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId3].ToString().Trim(), //CharEncodingId3
CharEncodingName2 = objRow[convApplicationType.CharEncodingName2] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName2].ToString().Trim(), //CharEncodingName2
CharEncodingName3 = objRow[convApplicationType.CharEncodingName3] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName3].ToString().Trim(), //CharEncodingName3
ProgLangTypeName2 = objRow[convApplicationType.ProgLangTypeName2] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName2].ToString().Trim(), //ProgLangTypeName2
ProgLangTypeName3 = objRow[convApplicationType.ProgLangTypeName3] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName3].ToString().Trim(), //ProgLangTypeName3
ProgLangTypeName5 = objRow[convApplicationType.ProgLangTypeName5] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName5].ToString().Trim(), //ProgLangTypeName5
CodeTypeCount = objRow[convApplicationType.CodeTypeCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convApplicationType.CodeTypeCount].ToString().Trim()), //代码类型数
CharEncodingId4 = objRow[convApplicationType.CharEncodingId4] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId4].ToString().Trim(), //CharEncodingId4
CharEncodingName4 = objRow[convApplicationType.CharEncodingName4] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName4].ToString().Trim(), //CharEncodingName4
ProgLangTypeName4 = objRow[convApplicationType.ProgLangTypeName4] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName4].ToString().Trim(), //ProgLangTypeName4
CharEncodingId5 = objRow[convApplicationType.CharEncodingId5] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId5].ToString().Trim(), //CharEncodingId5
CharEncodingName5 = objRow[convApplicationType.CharEncodingName5] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName5].ToString().Trim() //CharEncodingName5
};
objvApplicationTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvApplicationTypeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvApplicationTypeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvApplicationTypeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvApplicationTypeEN objvApplicationTypeEN = new clsvApplicationTypeEN();
try
{
objvApplicationTypeEN.ApplicationTypeId = TransNullToInt(objRow[convApplicationType.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvApplicationTypeEN.ApplicationTypeName = objRow[convApplicationType.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvApplicationTypeEN.ApplicationTypeSimName = objRow[convApplicationType.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convApplicationType.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvApplicationTypeEN.ApplicationTypeENName = objRow[convApplicationType.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvApplicationTypeEN.ProgLangTypeId = objRow[convApplicationType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvApplicationTypeEN.ProgLangTypeName = objRow[convApplicationType.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvApplicationTypeEN.ProgLangTypeENName = objRow[convApplicationType.ProgLangTypeENName] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeENName].ToString().Trim(); //编程语言类型英文名
objvApplicationTypeEN.CharEncodingId = objRow[convApplicationType.CharEncodingId].ToString().Trim(); //字符编码
objvApplicationTypeEN.CharEncodingName = objRow[convApplicationType.CharEncodingName] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName].ToString().Trim(); //字符编码名称
objvApplicationTypeEN.ProgLangTypeId2 = objRow[convApplicationType.ProgLangTypeId2] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId2].ToString().Trim(); //编程语言类型Id2
objvApplicationTypeEN.ProgLangTypeId3 = objRow[convApplicationType.ProgLangTypeId3] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId3].ToString().Trim(); //编程语言类型Id3
objvApplicationTypeEN.ProgLangTypeId4 = objRow[convApplicationType.ProgLangTypeId4] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId4].ToString().Trim(); //编程语言类型Id4
objvApplicationTypeEN.ProgLangTypeId5 = objRow[convApplicationType.ProgLangTypeId5] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId5].ToString().Trim(); //编程语言类型Id5
objvApplicationTypeEN.IsVisible = TransNullToBool(objRow[convApplicationType.IsVisible].ToString().Trim()); //是否显示
objvApplicationTypeEN.OrderNum = TransNullToInt(objRow[convApplicationType.OrderNum].ToString().Trim()); //序号
objvApplicationTypeEN.Memo = objRow[convApplicationType.Memo] == DBNull.Value ? null : objRow[convApplicationType.Memo].ToString().Trim(); //说明
objvApplicationTypeEN.CharEncodingId2 = objRow[convApplicationType.CharEncodingId2] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId2].ToString().Trim(); //CharEncodingId2
objvApplicationTypeEN.CharEncodingId3 = objRow[convApplicationType.CharEncodingId3] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId3].ToString().Trim(); //CharEncodingId3
objvApplicationTypeEN.CharEncodingName2 = objRow[convApplicationType.CharEncodingName2] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName2].ToString().Trim(); //CharEncodingName2
objvApplicationTypeEN.CharEncodingName3 = objRow[convApplicationType.CharEncodingName3] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName3].ToString().Trim(); //CharEncodingName3
objvApplicationTypeEN.ProgLangTypeName2 = objRow[convApplicationType.ProgLangTypeName2] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName2].ToString().Trim(); //ProgLangTypeName2
objvApplicationTypeEN.ProgLangTypeName3 = objRow[convApplicationType.ProgLangTypeName3] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName3].ToString().Trim(); //ProgLangTypeName3
objvApplicationTypeEN.ProgLangTypeName5 = objRow[convApplicationType.ProgLangTypeName5] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName5].ToString().Trim(); //ProgLangTypeName5
objvApplicationTypeEN.CodeTypeCount = objRow[convApplicationType.CodeTypeCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convApplicationType.CodeTypeCount].ToString().Trim()); //代码类型数
objvApplicationTypeEN.CharEncodingId4 = objRow[convApplicationType.CharEncodingId4] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId4].ToString().Trim(); //CharEncodingId4
objvApplicationTypeEN.CharEncodingName4 = objRow[convApplicationType.CharEncodingName4] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName4].ToString().Trim(); //CharEncodingName4
objvApplicationTypeEN.ProgLangTypeName4 = objRow[convApplicationType.ProgLangTypeName4] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName4].ToString().Trim(); //ProgLangTypeName4
objvApplicationTypeEN.CharEncodingId5 = objRow[convApplicationType.CharEncodingId5] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId5].ToString().Trim(); //CharEncodingId5
objvApplicationTypeEN.CharEncodingName5 = objRow[convApplicationType.CharEncodingName5] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName5].ToString().Trim(); //CharEncodingName5
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvApplicationTypeDA: GetObjByDataRowvApplicationType)", objException.Message));
}
objvApplicationTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvApplicationTypeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvApplicationTypeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvApplicationTypeEN objvApplicationTypeEN = new clsvApplicationTypeEN();
try
{
objvApplicationTypeEN.ApplicationTypeId = TransNullToInt(objRow[convApplicationType.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvApplicationTypeEN.ApplicationTypeName = objRow[convApplicationType.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvApplicationTypeEN.ApplicationTypeSimName = objRow[convApplicationType.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convApplicationType.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvApplicationTypeEN.ApplicationTypeENName = objRow[convApplicationType.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvApplicationTypeEN.ProgLangTypeId = objRow[convApplicationType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvApplicationTypeEN.ProgLangTypeName = objRow[convApplicationType.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvApplicationTypeEN.ProgLangTypeENName = objRow[convApplicationType.ProgLangTypeENName] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeENName].ToString().Trim(); //编程语言类型英文名
objvApplicationTypeEN.CharEncodingId = objRow[convApplicationType.CharEncodingId].ToString().Trim(); //字符编码
objvApplicationTypeEN.CharEncodingName = objRow[convApplicationType.CharEncodingName] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName].ToString().Trim(); //字符编码名称
objvApplicationTypeEN.ProgLangTypeId2 = objRow[convApplicationType.ProgLangTypeId2] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId2].ToString().Trim(); //编程语言类型Id2
objvApplicationTypeEN.ProgLangTypeId3 = objRow[convApplicationType.ProgLangTypeId3] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId3].ToString().Trim(); //编程语言类型Id3
objvApplicationTypeEN.ProgLangTypeId4 = objRow[convApplicationType.ProgLangTypeId4] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId4].ToString().Trim(); //编程语言类型Id4
objvApplicationTypeEN.ProgLangTypeId5 = objRow[convApplicationType.ProgLangTypeId5] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId5].ToString().Trim(); //编程语言类型Id5
objvApplicationTypeEN.IsVisible = TransNullToBool(objRow[convApplicationType.IsVisible].ToString().Trim()); //是否显示
objvApplicationTypeEN.OrderNum = TransNullToInt(objRow[convApplicationType.OrderNum].ToString().Trim()); //序号
objvApplicationTypeEN.Memo = objRow[convApplicationType.Memo] == DBNull.Value ? null : objRow[convApplicationType.Memo].ToString().Trim(); //说明
objvApplicationTypeEN.CharEncodingId2 = objRow[convApplicationType.CharEncodingId2] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId2].ToString().Trim(); //CharEncodingId2
objvApplicationTypeEN.CharEncodingId3 = objRow[convApplicationType.CharEncodingId3] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId3].ToString().Trim(); //CharEncodingId3
objvApplicationTypeEN.CharEncodingName2 = objRow[convApplicationType.CharEncodingName2] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName2].ToString().Trim(); //CharEncodingName2
objvApplicationTypeEN.CharEncodingName3 = objRow[convApplicationType.CharEncodingName3] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName3].ToString().Trim(); //CharEncodingName3
objvApplicationTypeEN.ProgLangTypeName2 = objRow[convApplicationType.ProgLangTypeName2] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName2].ToString().Trim(); //ProgLangTypeName2
objvApplicationTypeEN.ProgLangTypeName3 = objRow[convApplicationType.ProgLangTypeName3] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName3].ToString().Trim(); //ProgLangTypeName3
objvApplicationTypeEN.ProgLangTypeName5 = objRow[convApplicationType.ProgLangTypeName5] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName5].ToString().Trim(); //ProgLangTypeName5
objvApplicationTypeEN.CodeTypeCount = objRow[convApplicationType.CodeTypeCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convApplicationType.CodeTypeCount].ToString().Trim()); //代码类型数
objvApplicationTypeEN.CharEncodingId4 = objRow[convApplicationType.CharEncodingId4] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId4].ToString().Trim(); //CharEncodingId4
objvApplicationTypeEN.CharEncodingName4 = objRow[convApplicationType.CharEncodingName4] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName4].ToString().Trim(); //CharEncodingName4
objvApplicationTypeEN.ProgLangTypeName4 = objRow[convApplicationType.ProgLangTypeName4] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName4].ToString().Trim(); //ProgLangTypeName4
objvApplicationTypeEN.CharEncodingId5 = objRow[convApplicationType.CharEncodingId5] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId5].ToString().Trim(); //CharEncodingId5
objvApplicationTypeEN.CharEncodingName5 = objRow[convApplicationType.CharEncodingName5] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName5].ToString().Trim(); //CharEncodingName5
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvApplicationTypeDA: GetObjByDataRow)", objException.Message));
}
objvApplicationTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvApplicationTypeEN;
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
objSQL = clsvApplicationTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvApplicationTypeEN._CurrTabName, convApplicationType.ApplicationTypeId, 4, "");
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
objSQL = clsvApplicationTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvApplicationTypeEN._CurrTabName, convApplicationType.ApplicationTypeId, 4, strPrefix);
return strMaxValue;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public int GetFirstID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvApplicationTypeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ApplicationTypeId from vApplicationType where " + strCondition;
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
return int.Parse(strKeyValue);
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
 objSQL = clsvApplicationTypeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ApplicationTypeId from vApplicationType where " + strCondition;
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
 /// <param name = "intApplicationTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(int intApplicationTypeId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvApplicationTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vApplicationType", "ApplicationTypeId = " + ""+ intApplicationTypeId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvApplicationTypeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvApplicationTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vApplicationType", strCondition))
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
objSQL = clsvApplicationTypeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vApplicationType");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvApplicationTypeENS">源对象</param>
 /// <param name = "objvApplicationTypeENT">目标对象</param>
public void CopyTo(clsvApplicationTypeEN objvApplicationTypeENS, clsvApplicationTypeEN objvApplicationTypeENT)
{
objvApplicationTypeENT.ApplicationTypeId = objvApplicationTypeENS.ApplicationTypeId; //应用程序类型ID
objvApplicationTypeENT.ApplicationTypeName = objvApplicationTypeENS.ApplicationTypeName; //应用程序类型名称
objvApplicationTypeENT.ApplicationTypeSimName = objvApplicationTypeENS.ApplicationTypeSimName; //应用程序类型简称
objvApplicationTypeENT.ApplicationTypeENName = objvApplicationTypeENS.ApplicationTypeENName; //应用类型英文名
objvApplicationTypeENT.ProgLangTypeId = objvApplicationTypeENS.ProgLangTypeId; //编程语言类型Id
objvApplicationTypeENT.ProgLangTypeName = objvApplicationTypeENS.ProgLangTypeName; //编程语言类型名
objvApplicationTypeENT.ProgLangTypeENName = objvApplicationTypeENS.ProgLangTypeENName; //编程语言类型英文名
objvApplicationTypeENT.CharEncodingId = objvApplicationTypeENS.CharEncodingId; //字符编码
objvApplicationTypeENT.CharEncodingName = objvApplicationTypeENS.CharEncodingName; //字符编码名称
objvApplicationTypeENT.ProgLangTypeId2 = objvApplicationTypeENS.ProgLangTypeId2; //编程语言类型Id2
objvApplicationTypeENT.ProgLangTypeId3 = objvApplicationTypeENS.ProgLangTypeId3; //编程语言类型Id3
objvApplicationTypeENT.ProgLangTypeId4 = objvApplicationTypeENS.ProgLangTypeId4; //编程语言类型Id4
objvApplicationTypeENT.ProgLangTypeId5 = objvApplicationTypeENS.ProgLangTypeId5; //编程语言类型Id5
objvApplicationTypeENT.IsVisible = objvApplicationTypeENS.IsVisible; //是否显示
objvApplicationTypeENT.OrderNum = objvApplicationTypeENS.OrderNum; //序号
objvApplicationTypeENT.Memo = objvApplicationTypeENS.Memo; //说明
objvApplicationTypeENT.CharEncodingId2 = objvApplicationTypeENS.CharEncodingId2; //CharEncodingId2
objvApplicationTypeENT.CharEncodingId3 = objvApplicationTypeENS.CharEncodingId3; //CharEncodingId3
objvApplicationTypeENT.CharEncodingName2 = objvApplicationTypeENS.CharEncodingName2; //CharEncodingName2
objvApplicationTypeENT.CharEncodingName3 = objvApplicationTypeENS.CharEncodingName3; //CharEncodingName3
objvApplicationTypeENT.ProgLangTypeName2 = objvApplicationTypeENS.ProgLangTypeName2; //ProgLangTypeName2
objvApplicationTypeENT.ProgLangTypeName3 = objvApplicationTypeENS.ProgLangTypeName3; //ProgLangTypeName3
objvApplicationTypeENT.ProgLangTypeName5 = objvApplicationTypeENS.ProgLangTypeName5; //ProgLangTypeName5
objvApplicationTypeENT.CodeTypeCount = objvApplicationTypeENS.CodeTypeCount; //代码类型数
objvApplicationTypeENT.CharEncodingId4 = objvApplicationTypeENS.CharEncodingId4; //CharEncodingId4
objvApplicationTypeENT.CharEncodingName4 = objvApplicationTypeENS.CharEncodingName4; //CharEncodingName4
objvApplicationTypeENT.ProgLangTypeName4 = objvApplicationTypeENS.ProgLangTypeName4; //ProgLangTypeName4
objvApplicationTypeENT.CharEncodingId5 = objvApplicationTypeENS.CharEncodingId5; //CharEncodingId5
objvApplicationTypeENT.CharEncodingName5 = objvApplicationTypeENS.CharEncodingName5; //CharEncodingName5
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvApplicationTypeEN objvApplicationTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvApplicationTypeEN.ApplicationTypeName, 30, convApplicationType.ApplicationTypeName);
clsCheckSql.CheckFieldLen(objvApplicationTypeEN.ApplicationTypeSimName, 30, convApplicationType.ApplicationTypeSimName);
clsCheckSql.CheckFieldLen(objvApplicationTypeEN.ApplicationTypeENName, 30, convApplicationType.ApplicationTypeENName);
clsCheckSql.CheckFieldLen(objvApplicationTypeEN.ProgLangTypeId, 2, convApplicationType.ProgLangTypeId);
clsCheckSql.CheckFieldLen(objvApplicationTypeEN.ProgLangTypeName, 30, convApplicationType.ProgLangTypeName);
clsCheckSql.CheckFieldLen(objvApplicationTypeEN.ProgLangTypeENName, 50, convApplicationType.ProgLangTypeENName);
clsCheckSql.CheckFieldLen(objvApplicationTypeEN.CharEncodingId, 20, convApplicationType.CharEncodingId);
clsCheckSql.CheckFieldLen(objvApplicationTypeEN.CharEncodingName, 100, convApplicationType.CharEncodingName);
clsCheckSql.CheckFieldLen(objvApplicationTypeEN.ProgLangTypeId2, 2, convApplicationType.ProgLangTypeId2);
clsCheckSql.CheckFieldLen(objvApplicationTypeEN.ProgLangTypeId3, 2, convApplicationType.ProgLangTypeId3);
clsCheckSql.CheckFieldLen(objvApplicationTypeEN.ProgLangTypeId4, 2, convApplicationType.ProgLangTypeId4);
clsCheckSql.CheckFieldLen(objvApplicationTypeEN.ProgLangTypeId5, 2, convApplicationType.ProgLangTypeId5);
clsCheckSql.CheckFieldLen(objvApplicationTypeEN.Memo, 1000, convApplicationType.Memo);
clsCheckSql.CheckFieldLen(objvApplicationTypeEN.CharEncodingId2, 20, convApplicationType.CharEncodingId2);
clsCheckSql.CheckFieldLen(objvApplicationTypeEN.CharEncodingId3, 20, convApplicationType.CharEncodingId3);
clsCheckSql.CheckFieldLen(objvApplicationTypeEN.CharEncodingName2, 100, convApplicationType.CharEncodingName2);
clsCheckSql.CheckFieldLen(objvApplicationTypeEN.CharEncodingName3, 100, convApplicationType.CharEncodingName3);
clsCheckSql.CheckFieldLen(objvApplicationTypeEN.ProgLangTypeName2, 30, convApplicationType.ProgLangTypeName2);
clsCheckSql.CheckFieldLen(objvApplicationTypeEN.ProgLangTypeName3, 30, convApplicationType.ProgLangTypeName3);
clsCheckSql.CheckFieldLen(objvApplicationTypeEN.ProgLangTypeName5, 30, convApplicationType.ProgLangTypeName5);
clsCheckSql.CheckFieldLen(objvApplicationTypeEN.CharEncodingId4, 20, convApplicationType.CharEncodingId4);
clsCheckSql.CheckFieldLen(objvApplicationTypeEN.CharEncodingName4, 100, convApplicationType.CharEncodingName4);
clsCheckSql.CheckFieldLen(objvApplicationTypeEN.ProgLangTypeName4, 30, convApplicationType.ProgLangTypeName4);
clsCheckSql.CheckFieldLen(objvApplicationTypeEN.CharEncodingId5, 20, convApplicationType.CharEncodingId5);
clsCheckSql.CheckFieldLen(objvApplicationTypeEN.CharEncodingName5, 100, convApplicationType.CharEncodingName5);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvApplicationTypeEN.ApplicationTypeName, convApplicationType.ApplicationTypeName);
clsCheckSql.CheckSqlInjection4Field(objvApplicationTypeEN.ApplicationTypeSimName, convApplicationType.ApplicationTypeSimName);
clsCheckSql.CheckSqlInjection4Field(objvApplicationTypeEN.ApplicationTypeENName, convApplicationType.ApplicationTypeENName);
clsCheckSql.CheckSqlInjection4Field(objvApplicationTypeEN.ProgLangTypeId, convApplicationType.ProgLangTypeId);
clsCheckSql.CheckSqlInjection4Field(objvApplicationTypeEN.ProgLangTypeName, convApplicationType.ProgLangTypeName);
clsCheckSql.CheckSqlInjection4Field(objvApplicationTypeEN.ProgLangTypeENName, convApplicationType.ProgLangTypeENName);
clsCheckSql.CheckSqlInjection4Field(objvApplicationTypeEN.CharEncodingId, convApplicationType.CharEncodingId);
clsCheckSql.CheckSqlInjection4Field(objvApplicationTypeEN.CharEncodingName, convApplicationType.CharEncodingName);
clsCheckSql.CheckSqlInjection4Field(objvApplicationTypeEN.ProgLangTypeId2, convApplicationType.ProgLangTypeId2);
clsCheckSql.CheckSqlInjection4Field(objvApplicationTypeEN.ProgLangTypeId3, convApplicationType.ProgLangTypeId3);
clsCheckSql.CheckSqlInjection4Field(objvApplicationTypeEN.ProgLangTypeId4, convApplicationType.ProgLangTypeId4);
clsCheckSql.CheckSqlInjection4Field(objvApplicationTypeEN.ProgLangTypeId5, convApplicationType.ProgLangTypeId5);
clsCheckSql.CheckSqlInjection4Field(objvApplicationTypeEN.Memo, convApplicationType.Memo);
clsCheckSql.CheckSqlInjection4Field(objvApplicationTypeEN.CharEncodingId2, convApplicationType.CharEncodingId2);
clsCheckSql.CheckSqlInjection4Field(objvApplicationTypeEN.CharEncodingId3, convApplicationType.CharEncodingId3);
clsCheckSql.CheckSqlInjection4Field(objvApplicationTypeEN.CharEncodingName2, convApplicationType.CharEncodingName2);
clsCheckSql.CheckSqlInjection4Field(objvApplicationTypeEN.CharEncodingName3, convApplicationType.CharEncodingName3);
clsCheckSql.CheckSqlInjection4Field(objvApplicationTypeEN.ProgLangTypeName2, convApplicationType.ProgLangTypeName2);
clsCheckSql.CheckSqlInjection4Field(objvApplicationTypeEN.ProgLangTypeName3, convApplicationType.ProgLangTypeName3);
clsCheckSql.CheckSqlInjection4Field(objvApplicationTypeEN.ProgLangTypeName5, convApplicationType.ProgLangTypeName5);
clsCheckSql.CheckSqlInjection4Field(objvApplicationTypeEN.CharEncodingId4, convApplicationType.CharEncodingId4);
clsCheckSql.CheckSqlInjection4Field(objvApplicationTypeEN.CharEncodingName4, convApplicationType.CharEncodingName4);
clsCheckSql.CheckSqlInjection4Field(objvApplicationTypeEN.ProgLangTypeName4, convApplicationType.ProgLangTypeName4);
clsCheckSql.CheckSqlInjection4Field(objvApplicationTypeEN.CharEncodingId5, convApplicationType.CharEncodingId5);
clsCheckSql.CheckSqlInjection4Field(objvApplicationTypeEN.CharEncodingName5, convApplicationType.CharEncodingName5);
//检查外键字段长度
 objvApplicationTypeEN._IsCheckProperty = true;
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
 objSQL = clsvApplicationTypeDA.GetSpecSQLObj();
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
 objSQL = clsvApplicationTypeDA.GetSpecSQLObj();
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
 objSQL = clsvApplicationTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvApplicationTypeEN._CurrTabName);
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
 objSQL = clsvApplicationTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvApplicationTypeEN._CurrTabName, strCondition);
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
 objSQL = clsvApplicationTypeDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}