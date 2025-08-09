
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFeatureFuncRelaDA
 表名:vFeatureFuncRela(00050398)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:14:01
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:函数管理(PrjFunction)
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
 /// v功能函数关系(vFeatureFuncRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvFeatureFuncRelaDA : clsCommBase4DA
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
 return clsvFeatureFuncRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvFeatureFuncRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvFeatureFuncRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvFeatureFuncRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvFeatureFuncRelaEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvFeatureFuncRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureFuncRelaDA.GetSpecSQLObj();
strSQL = "Select * from vFeatureFuncRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vFeatureFuncRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvFeatureFuncRelaDA: GetDataTable_vFeatureFuncRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureFuncRelaDA.GetSpecSQLObj();
strSQL = "Select * from vFeatureFuncRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvFeatureFuncRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureFuncRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvFeatureFuncRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureFuncRelaDA.GetSpecSQLObj();
strSQL = "Select * from vFeatureFuncRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvFeatureFuncRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureFuncRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvFeatureFuncRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureFuncRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFeatureFuncRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFeatureFuncRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvFeatureFuncRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureFuncRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vFeatureFuncRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvFeatureFuncRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureFuncRelaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vFeatureFuncRela.* " + 
$"from vFeatureFuncRela " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vFeatureFuncRela.mId not in " + 
$"(Select top {intTop_In} vFeatureFuncRela.mId from vFeatureFuncRela " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFeatureFuncRela where {1} and mId not in (Select top {2} mId from vFeatureFuncRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFeatureFuncRela where {1} and mId not in (Select top {3} mId from vFeatureFuncRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvFeatureFuncRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureFuncRelaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vFeatureFuncRela.* " + 
$"from vFeatureFuncRela " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vFeatureFuncRela.mId not in " + 
$"(Select top {intTop_In} vFeatureFuncRela.mId from vFeatureFuncRela " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFeatureFuncRela where {1} and mId not in (Select top {2} mId from vFeatureFuncRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFeatureFuncRela where {1} and mId not in (Select top {3} mId from vFeatureFuncRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvFeatureFuncRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvFeatureFuncRelaDA:GetObjLst)", objException.Message));
}
List<clsvFeatureFuncRelaEN> arrObjLst = new List<clsvFeatureFuncRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureFuncRelaDA.GetSpecSQLObj();
strSQL = "Select * from vFeatureFuncRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureFuncRelaEN objvFeatureFuncRelaEN = new clsvFeatureFuncRelaEN();
try
{
objvFeatureFuncRelaEN.mId = TransNullToInt(objRow[convFeatureFuncRela.mId].ToString().Trim()); //mId
objvFeatureFuncRelaEN.ApplicationTypeId = TransNullToInt(objRow[convFeatureFuncRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFeatureFuncRelaEN.ApplicationTypeName = objRow[convFeatureFuncRela.ApplicationTypeName] == DBNull.Value ? null : objRow[convFeatureFuncRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvFeatureFuncRelaEN.ProgLangTypeName = objRow[convFeatureFuncRela.ProgLangTypeName] == DBNull.Value ? null : objRow[convFeatureFuncRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFeatureFuncRelaEN.FeatureId = objRow[convFeatureFuncRela.FeatureId].ToString().Trim(); //功能Id
objvFeatureFuncRelaEN.FeatureName = objRow[convFeatureFuncRela.FeatureName].ToString().Trim(); //功能名称
objvFeatureFuncRelaEN.KeyWords = objRow[convFeatureFuncRela.KeyWords] == DBNull.Value ? null : objRow[convFeatureFuncRela.KeyWords].ToString().Trim(); //关键字
objvFeatureFuncRelaEN.FeatureTypeId = objRow[convFeatureFuncRela.FeatureTypeId].ToString().Trim(); //功能类型Id
objvFeatureFuncRelaEN.FeatureTypeName = objRow[convFeatureFuncRela.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureFuncRelaEN.FeatureName2 = objRow[convFeatureFuncRela.FeatureName2] == DBNull.Value ? null : objRow[convFeatureFuncRela.FeatureName2].ToString().Trim(); //功能名-FuncCount
objvFeatureFuncRelaEN.FuncId4GC = objRow[convFeatureFuncRela.FuncId4GC] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncId4GC].ToString().Trim(); //函数ID
objvFeatureFuncRelaEN.FuncName = objRow[convFeatureFuncRela.FuncName] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncName].ToString().Trim(); //函数名
objvFeatureFuncRelaEN.FuncId4Code = objRow[convFeatureFuncRela.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFeatureFuncRelaEN.FuncName4Code = objRow[convFeatureFuncRela.FuncName4Code].ToString().Trim(); //函数名4Code
objvFeatureFuncRelaEN.FunctionSignature = objRow[convFeatureFuncRela.FunctionSignature].ToString().Trim(); //函数签名
objvFeatureFuncRelaEN.OrderNum = objRow[convFeatureFuncRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFeatureFuncRela.OrderNum].ToString().Trim()); //序号
objvFeatureFuncRelaEN.UpdDate = objRow[convFeatureFuncRela.UpdDate] == DBNull.Value ? null : objRow[convFeatureFuncRela.UpdDate].ToString().Trim(); //修改日期
objvFeatureFuncRelaEN.UpdUser = objRow[convFeatureFuncRela.UpdUser] == DBNull.Value ? null : objRow[convFeatureFuncRela.UpdUser].ToString().Trim(); //修改者
objvFeatureFuncRelaEN.Memo = objRow[convFeatureFuncRela.Memo] == DBNull.Value ? null : objRow[convFeatureFuncRela.Memo].ToString().Trim(); //说明
objvFeatureFuncRelaEN.FuncCodeTypeENName = objRow[convFeatureFuncRela.FuncCodeTypeENName] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncCodeTypeENName].ToString().Trim(); //FuncCodeTypeENName
objvFeatureFuncRelaEN.FuncCodeTypeId = objRow[convFeatureFuncRela.FuncCodeTypeId] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objvFeatureFuncRelaEN.FuncCodeTypeName = objRow[convFeatureFuncRela.FuncCodeTypeName] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncCodeTypeName].ToString().Trim(); //FuncCodeTypeName
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvFeatureFuncRelaDA: GetObjLst)", objException.Message));
}
objvFeatureFuncRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvFeatureFuncRelaEN);
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
public List<clsvFeatureFuncRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvFeatureFuncRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsvFeatureFuncRelaEN> arrObjLst = new List<clsvFeatureFuncRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureFuncRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureFuncRelaEN objvFeatureFuncRelaEN = new clsvFeatureFuncRelaEN();
try
{
objvFeatureFuncRelaEN.mId = TransNullToInt(objRow[convFeatureFuncRela.mId].ToString().Trim()); //mId
objvFeatureFuncRelaEN.ApplicationTypeId = TransNullToInt(objRow[convFeatureFuncRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFeatureFuncRelaEN.ApplicationTypeName = objRow[convFeatureFuncRela.ApplicationTypeName] == DBNull.Value ? null : objRow[convFeatureFuncRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvFeatureFuncRelaEN.ProgLangTypeName = objRow[convFeatureFuncRela.ProgLangTypeName] == DBNull.Value ? null : objRow[convFeatureFuncRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFeatureFuncRelaEN.FeatureId = objRow[convFeatureFuncRela.FeatureId].ToString().Trim(); //功能Id
objvFeatureFuncRelaEN.FeatureName = objRow[convFeatureFuncRela.FeatureName].ToString().Trim(); //功能名称
objvFeatureFuncRelaEN.KeyWords = objRow[convFeatureFuncRela.KeyWords] == DBNull.Value ? null : objRow[convFeatureFuncRela.KeyWords].ToString().Trim(); //关键字
objvFeatureFuncRelaEN.FeatureTypeId = objRow[convFeatureFuncRela.FeatureTypeId].ToString().Trim(); //功能类型Id
objvFeatureFuncRelaEN.FeatureTypeName = objRow[convFeatureFuncRela.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureFuncRelaEN.FeatureName2 = objRow[convFeatureFuncRela.FeatureName2] == DBNull.Value ? null : objRow[convFeatureFuncRela.FeatureName2].ToString().Trim(); //功能名-FuncCount
objvFeatureFuncRelaEN.FuncId4GC = objRow[convFeatureFuncRela.FuncId4GC] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncId4GC].ToString().Trim(); //函数ID
objvFeatureFuncRelaEN.FuncName = objRow[convFeatureFuncRela.FuncName] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncName].ToString().Trim(); //函数名
objvFeatureFuncRelaEN.FuncId4Code = objRow[convFeatureFuncRela.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFeatureFuncRelaEN.FuncName4Code = objRow[convFeatureFuncRela.FuncName4Code].ToString().Trim(); //函数名4Code
objvFeatureFuncRelaEN.FunctionSignature = objRow[convFeatureFuncRela.FunctionSignature].ToString().Trim(); //函数签名
objvFeatureFuncRelaEN.OrderNum = objRow[convFeatureFuncRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFeatureFuncRela.OrderNum].ToString().Trim()); //序号
objvFeatureFuncRelaEN.UpdDate = objRow[convFeatureFuncRela.UpdDate] == DBNull.Value ? null : objRow[convFeatureFuncRela.UpdDate].ToString().Trim(); //修改日期
objvFeatureFuncRelaEN.UpdUser = objRow[convFeatureFuncRela.UpdUser] == DBNull.Value ? null : objRow[convFeatureFuncRela.UpdUser].ToString().Trim(); //修改者
objvFeatureFuncRelaEN.Memo = objRow[convFeatureFuncRela.Memo] == DBNull.Value ? null : objRow[convFeatureFuncRela.Memo].ToString().Trim(); //说明
objvFeatureFuncRelaEN.FuncCodeTypeENName = objRow[convFeatureFuncRela.FuncCodeTypeENName] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncCodeTypeENName].ToString().Trim(); //FuncCodeTypeENName
objvFeatureFuncRelaEN.FuncCodeTypeId = objRow[convFeatureFuncRela.FuncCodeTypeId] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objvFeatureFuncRelaEN.FuncCodeTypeName = objRow[convFeatureFuncRela.FuncCodeTypeName] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncCodeTypeName].ToString().Trim(); //FuncCodeTypeName
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvFeatureFuncRelaDA: GetObjLst)", objException.Message));
}
objvFeatureFuncRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvFeatureFuncRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvFeatureFuncRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvFeatureFuncRela(ref clsvFeatureFuncRelaEN objvFeatureFuncRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureFuncRelaDA.GetSpecSQLObj();
strSQL = "Select * from vFeatureFuncRela where mId = " + ""+ objvFeatureFuncRelaEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvFeatureFuncRelaEN.mId = TransNullToInt(objDT.Rows[0][convFeatureFuncRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvFeatureFuncRelaEN.ApplicationTypeId = TransNullToInt(objDT.Rows[0][convFeatureFuncRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objvFeatureFuncRelaEN.ApplicationTypeName = objDT.Rows[0][convFeatureFuncRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvFeatureFuncRelaEN.ProgLangTypeName = objDT.Rows[0][convFeatureFuncRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvFeatureFuncRelaEN.FeatureId = objDT.Rows[0][convFeatureFuncRela.FeatureId].ToString().Trim(); //功能Id(字段类型:char,字段长度:4,是否可空:False)
 objvFeatureFuncRelaEN.FeatureName = objDT.Rows[0][convFeatureFuncRela.FeatureName].ToString().Trim(); //功能名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvFeatureFuncRelaEN.KeyWords = objDT.Rows[0][convFeatureFuncRela.KeyWords].ToString().Trim(); //关键字(字段类型:varchar,字段长度:500,是否可空:True)
 objvFeatureFuncRelaEN.FeatureTypeId = objDT.Rows[0][convFeatureFuncRela.FeatureTypeId].ToString().Trim(); //功能类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvFeatureFuncRelaEN.FeatureTypeName = objDT.Rows[0][convFeatureFuncRela.FeatureTypeName].ToString().Trim(); //功能类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvFeatureFuncRelaEN.FeatureName2 = objDT.Rows[0][convFeatureFuncRela.FeatureName2].ToString().Trim(); //功能名-FuncCount(字段类型:varchar,字段长度:112,是否可空:True)
 objvFeatureFuncRelaEN.FuncId4GC = objDT.Rows[0][convFeatureFuncRela.FuncId4GC].ToString().Trim(); //函数ID(字段类型:char,字段长度:10,是否可空:False)
 objvFeatureFuncRelaEN.FuncName = objDT.Rows[0][convFeatureFuncRela.FuncName].ToString().Trim(); //函数名(字段类型:varchar,字段长度:100,是否可空:False)
 objvFeatureFuncRelaEN.FuncId4Code = objDT.Rows[0][convFeatureFuncRela.FuncId4Code].ToString().Trim(); //函数Id4Code(字段类型:char,字段长度:8,是否可空:False)
 objvFeatureFuncRelaEN.FuncName4Code = objDT.Rows[0][convFeatureFuncRela.FuncName4Code].ToString().Trim(); //函数名4Code(字段类型:varchar,字段长度:100,是否可空:False)
 objvFeatureFuncRelaEN.FunctionSignature = objDT.Rows[0][convFeatureFuncRela.FunctionSignature].ToString().Trim(); //函数签名(字段类型:varchar,字段长度:500,是否可空:False)
 objvFeatureFuncRelaEN.OrderNum = TransNullToInt(objDT.Rows[0][convFeatureFuncRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvFeatureFuncRelaEN.UpdDate = objDT.Rows[0][convFeatureFuncRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvFeatureFuncRelaEN.UpdUser = objDT.Rows[0][convFeatureFuncRela.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvFeatureFuncRelaEN.Memo = objDT.Rows[0][convFeatureFuncRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvFeatureFuncRelaEN.FuncCodeTypeENName = objDT.Rows[0][convFeatureFuncRela.FuncCodeTypeENName].ToString().Trim(); //FuncCodeTypeENName(字段类型:varchar,字段长度:50,是否可空:True)
 objvFeatureFuncRelaEN.FuncCodeTypeId = objDT.Rows[0][convFeatureFuncRela.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvFeatureFuncRelaEN.FuncCodeTypeName = objDT.Rows[0][convFeatureFuncRela.FuncCodeTypeName].ToString().Trim(); //FuncCodeTypeName(字段类型:varchar,字段长度:50,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvFeatureFuncRelaDA: GetvFeatureFuncRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvFeatureFuncRelaEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureFuncRelaDA.GetSpecSQLObj();
strSQL = "Select * from vFeatureFuncRela where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvFeatureFuncRelaEN objvFeatureFuncRelaEN = new clsvFeatureFuncRelaEN();
try
{
 objvFeatureFuncRelaEN.mId = Int32.Parse(objRow[convFeatureFuncRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvFeatureFuncRelaEN.ApplicationTypeId = Int32.Parse(objRow[convFeatureFuncRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objvFeatureFuncRelaEN.ApplicationTypeName = objRow[convFeatureFuncRela.ApplicationTypeName] == DBNull.Value ? null : objRow[convFeatureFuncRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvFeatureFuncRelaEN.ProgLangTypeName = objRow[convFeatureFuncRela.ProgLangTypeName] == DBNull.Value ? null : objRow[convFeatureFuncRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvFeatureFuncRelaEN.FeatureId = objRow[convFeatureFuncRela.FeatureId].ToString().Trim(); //功能Id(字段类型:char,字段长度:4,是否可空:False)
 objvFeatureFuncRelaEN.FeatureName = objRow[convFeatureFuncRela.FeatureName].ToString().Trim(); //功能名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvFeatureFuncRelaEN.KeyWords = objRow[convFeatureFuncRela.KeyWords] == DBNull.Value ? null : objRow[convFeatureFuncRela.KeyWords].ToString().Trim(); //关键字(字段类型:varchar,字段长度:500,是否可空:True)
 objvFeatureFuncRelaEN.FeatureTypeId = objRow[convFeatureFuncRela.FeatureTypeId].ToString().Trim(); //功能类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvFeatureFuncRelaEN.FeatureTypeName = objRow[convFeatureFuncRela.FeatureTypeName].ToString().Trim(); //功能类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvFeatureFuncRelaEN.FeatureName2 = objRow[convFeatureFuncRela.FeatureName2] == DBNull.Value ? null : objRow[convFeatureFuncRela.FeatureName2].ToString().Trim(); //功能名-FuncCount(字段类型:varchar,字段长度:112,是否可空:True)
 objvFeatureFuncRelaEN.FuncId4GC = objRow[convFeatureFuncRela.FuncId4GC] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncId4GC].ToString().Trim(); //函数ID(字段类型:char,字段长度:10,是否可空:False)
 objvFeatureFuncRelaEN.FuncName = objRow[convFeatureFuncRela.FuncName] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncName].ToString().Trim(); //函数名(字段类型:varchar,字段长度:100,是否可空:False)
 objvFeatureFuncRelaEN.FuncId4Code = objRow[convFeatureFuncRela.FuncId4Code].ToString().Trim(); //函数Id4Code(字段类型:char,字段长度:8,是否可空:False)
 objvFeatureFuncRelaEN.FuncName4Code = objRow[convFeatureFuncRela.FuncName4Code].ToString().Trim(); //函数名4Code(字段类型:varchar,字段长度:100,是否可空:False)
 objvFeatureFuncRelaEN.FunctionSignature = objRow[convFeatureFuncRela.FunctionSignature].ToString().Trim(); //函数签名(字段类型:varchar,字段长度:500,是否可空:False)
 objvFeatureFuncRelaEN.OrderNum = objRow[convFeatureFuncRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureFuncRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvFeatureFuncRelaEN.UpdDate = objRow[convFeatureFuncRela.UpdDate] == DBNull.Value ? null : objRow[convFeatureFuncRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvFeatureFuncRelaEN.UpdUser = objRow[convFeatureFuncRela.UpdUser] == DBNull.Value ? null : objRow[convFeatureFuncRela.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvFeatureFuncRelaEN.Memo = objRow[convFeatureFuncRela.Memo] == DBNull.Value ? null : objRow[convFeatureFuncRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvFeatureFuncRelaEN.FuncCodeTypeENName = objRow[convFeatureFuncRela.FuncCodeTypeENName] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncCodeTypeENName].ToString().Trim(); //FuncCodeTypeENName(字段类型:varchar,字段长度:50,是否可空:True)
 objvFeatureFuncRelaEN.FuncCodeTypeId = objRow[convFeatureFuncRela.FuncCodeTypeId] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvFeatureFuncRelaEN.FuncCodeTypeName = objRow[convFeatureFuncRela.FuncCodeTypeName] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncCodeTypeName].ToString().Trim(); //FuncCodeTypeName(字段类型:varchar,字段长度:50,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvFeatureFuncRelaDA: GetObjBymId)", objException.Message));
}
return objvFeatureFuncRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvFeatureFuncRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvFeatureFuncRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureFuncRelaDA.GetSpecSQLObj();
strSQL = "Select * from vFeatureFuncRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvFeatureFuncRelaEN objvFeatureFuncRelaEN = new clsvFeatureFuncRelaEN()
{
mId = TransNullToInt(objRow[convFeatureFuncRela.mId].ToString().Trim()), //mId
ApplicationTypeId = TransNullToInt(objRow[convFeatureFuncRela.ApplicationTypeId].ToString().Trim()), //应用程序类型ID
ApplicationTypeName = objRow[convFeatureFuncRela.ApplicationTypeName] == DBNull.Value ? null : objRow[convFeatureFuncRela.ApplicationTypeName].ToString().Trim(), //应用程序类型名称
ProgLangTypeName = objRow[convFeatureFuncRela.ProgLangTypeName] == DBNull.Value ? null : objRow[convFeatureFuncRela.ProgLangTypeName].ToString().Trim(), //编程语言类型名
FeatureId = objRow[convFeatureFuncRela.FeatureId].ToString().Trim(), //功能Id
FeatureName = objRow[convFeatureFuncRela.FeatureName].ToString().Trim(), //功能名称
KeyWords = objRow[convFeatureFuncRela.KeyWords] == DBNull.Value ? null : objRow[convFeatureFuncRela.KeyWords].ToString().Trim(), //关键字
FeatureTypeId = objRow[convFeatureFuncRela.FeatureTypeId].ToString().Trim(), //功能类型Id
FeatureTypeName = objRow[convFeatureFuncRela.FeatureTypeName].ToString().Trim(), //功能类型名称
FeatureName2 = objRow[convFeatureFuncRela.FeatureName2] == DBNull.Value ? null : objRow[convFeatureFuncRela.FeatureName2].ToString().Trim(), //功能名-FuncCount
FuncId4GC = objRow[convFeatureFuncRela.FuncId4GC] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncId4GC].ToString().Trim(), //函数ID
FuncName = objRow[convFeatureFuncRela.FuncName] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncName].ToString().Trim(), //函数名
FuncId4Code = objRow[convFeatureFuncRela.FuncId4Code].ToString().Trim(), //函数Id4Code
FuncName4Code = objRow[convFeatureFuncRela.FuncName4Code].ToString().Trim(), //函数名4Code
FunctionSignature = objRow[convFeatureFuncRela.FunctionSignature].ToString().Trim(), //函数签名
OrderNum = objRow[convFeatureFuncRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFeatureFuncRela.OrderNum].ToString().Trim()), //序号
UpdDate = objRow[convFeatureFuncRela.UpdDate] == DBNull.Value ? null : objRow[convFeatureFuncRela.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convFeatureFuncRela.UpdUser] == DBNull.Value ? null : objRow[convFeatureFuncRela.UpdUser].ToString().Trim(), //修改者
Memo = objRow[convFeatureFuncRela.Memo] == DBNull.Value ? null : objRow[convFeatureFuncRela.Memo].ToString().Trim(), //说明
FuncCodeTypeENName = objRow[convFeatureFuncRela.FuncCodeTypeENName] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncCodeTypeENName].ToString().Trim(), //FuncCodeTypeENName
FuncCodeTypeId = objRow[convFeatureFuncRela.FuncCodeTypeId] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncCodeTypeId].ToString().Trim(), //函数代码类型Id
FuncCodeTypeName = objRow[convFeatureFuncRela.FuncCodeTypeName] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncCodeTypeName].ToString().Trim() //FuncCodeTypeName
};
objvFeatureFuncRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFeatureFuncRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvFeatureFuncRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvFeatureFuncRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvFeatureFuncRelaEN objvFeatureFuncRelaEN = new clsvFeatureFuncRelaEN();
try
{
objvFeatureFuncRelaEN.mId = TransNullToInt(objRow[convFeatureFuncRela.mId].ToString().Trim()); //mId
objvFeatureFuncRelaEN.ApplicationTypeId = TransNullToInt(objRow[convFeatureFuncRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFeatureFuncRelaEN.ApplicationTypeName = objRow[convFeatureFuncRela.ApplicationTypeName] == DBNull.Value ? null : objRow[convFeatureFuncRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvFeatureFuncRelaEN.ProgLangTypeName = objRow[convFeatureFuncRela.ProgLangTypeName] == DBNull.Value ? null : objRow[convFeatureFuncRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFeatureFuncRelaEN.FeatureId = objRow[convFeatureFuncRela.FeatureId].ToString().Trim(); //功能Id
objvFeatureFuncRelaEN.FeatureName = objRow[convFeatureFuncRela.FeatureName].ToString().Trim(); //功能名称
objvFeatureFuncRelaEN.KeyWords = objRow[convFeatureFuncRela.KeyWords] == DBNull.Value ? null : objRow[convFeatureFuncRela.KeyWords].ToString().Trim(); //关键字
objvFeatureFuncRelaEN.FeatureTypeId = objRow[convFeatureFuncRela.FeatureTypeId].ToString().Trim(); //功能类型Id
objvFeatureFuncRelaEN.FeatureTypeName = objRow[convFeatureFuncRela.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureFuncRelaEN.FeatureName2 = objRow[convFeatureFuncRela.FeatureName2] == DBNull.Value ? null : objRow[convFeatureFuncRela.FeatureName2].ToString().Trim(); //功能名-FuncCount
objvFeatureFuncRelaEN.FuncId4GC = objRow[convFeatureFuncRela.FuncId4GC] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncId4GC].ToString().Trim(); //函数ID
objvFeatureFuncRelaEN.FuncName = objRow[convFeatureFuncRela.FuncName] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncName].ToString().Trim(); //函数名
objvFeatureFuncRelaEN.FuncId4Code = objRow[convFeatureFuncRela.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFeatureFuncRelaEN.FuncName4Code = objRow[convFeatureFuncRela.FuncName4Code].ToString().Trim(); //函数名4Code
objvFeatureFuncRelaEN.FunctionSignature = objRow[convFeatureFuncRela.FunctionSignature].ToString().Trim(); //函数签名
objvFeatureFuncRelaEN.OrderNum = objRow[convFeatureFuncRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFeatureFuncRela.OrderNum].ToString().Trim()); //序号
objvFeatureFuncRelaEN.UpdDate = objRow[convFeatureFuncRela.UpdDate] == DBNull.Value ? null : objRow[convFeatureFuncRela.UpdDate].ToString().Trim(); //修改日期
objvFeatureFuncRelaEN.UpdUser = objRow[convFeatureFuncRela.UpdUser] == DBNull.Value ? null : objRow[convFeatureFuncRela.UpdUser].ToString().Trim(); //修改者
objvFeatureFuncRelaEN.Memo = objRow[convFeatureFuncRela.Memo] == DBNull.Value ? null : objRow[convFeatureFuncRela.Memo].ToString().Trim(); //说明
objvFeatureFuncRelaEN.FuncCodeTypeENName = objRow[convFeatureFuncRela.FuncCodeTypeENName] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncCodeTypeENName].ToString().Trim(); //FuncCodeTypeENName
objvFeatureFuncRelaEN.FuncCodeTypeId = objRow[convFeatureFuncRela.FuncCodeTypeId] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objvFeatureFuncRelaEN.FuncCodeTypeName = objRow[convFeatureFuncRela.FuncCodeTypeName] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncCodeTypeName].ToString().Trim(); //FuncCodeTypeName
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvFeatureFuncRelaDA: GetObjByDataRowvFeatureFuncRela)", objException.Message));
}
objvFeatureFuncRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFeatureFuncRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvFeatureFuncRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvFeatureFuncRelaEN objvFeatureFuncRelaEN = new clsvFeatureFuncRelaEN();
try
{
objvFeatureFuncRelaEN.mId = TransNullToInt(objRow[convFeatureFuncRela.mId].ToString().Trim()); //mId
objvFeatureFuncRelaEN.ApplicationTypeId = TransNullToInt(objRow[convFeatureFuncRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFeatureFuncRelaEN.ApplicationTypeName = objRow[convFeatureFuncRela.ApplicationTypeName] == DBNull.Value ? null : objRow[convFeatureFuncRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvFeatureFuncRelaEN.ProgLangTypeName = objRow[convFeatureFuncRela.ProgLangTypeName] == DBNull.Value ? null : objRow[convFeatureFuncRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFeatureFuncRelaEN.FeatureId = objRow[convFeatureFuncRela.FeatureId].ToString().Trim(); //功能Id
objvFeatureFuncRelaEN.FeatureName = objRow[convFeatureFuncRela.FeatureName].ToString().Trim(); //功能名称
objvFeatureFuncRelaEN.KeyWords = objRow[convFeatureFuncRela.KeyWords] == DBNull.Value ? null : objRow[convFeatureFuncRela.KeyWords].ToString().Trim(); //关键字
objvFeatureFuncRelaEN.FeatureTypeId = objRow[convFeatureFuncRela.FeatureTypeId].ToString().Trim(); //功能类型Id
objvFeatureFuncRelaEN.FeatureTypeName = objRow[convFeatureFuncRela.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureFuncRelaEN.FeatureName2 = objRow[convFeatureFuncRela.FeatureName2] == DBNull.Value ? null : objRow[convFeatureFuncRela.FeatureName2].ToString().Trim(); //功能名-FuncCount
objvFeatureFuncRelaEN.FuncId4GC = objRow[convFeatureFuncRela.FuncId4GC] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncId4GC].ToString().Trim(); //函数ID
objvFeatureFuncRelaEN.FuncName = objRow[convFeatureFuncRela.FuncName] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncName].ToString().Trim(); //函数名
objvFeatureFuncRelaEN.FuncId4Code = objRow[convFeatureFuncRela.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFeatureFuncRelaEN.FuncName4Code = objRow[convFeatureFuncRela.FuncName4Code].ToString().Trim(); //函数名4Code
objvFeatureFuncRelaEN.FunctionSignature = objRow[convFeatureFuncRela.FunctionSignature].ToString().Trim(); //函数签名
objvFeatureFuncRelaEN.OrderNum = objRow[convFeatureFuncRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFeatureFuncRela.OrderNum].ToString().Trim()); //序号
objvFeatureFuncRelaEN.UpdDate = objRow[convFeatureFuncRela.UpdDate] == DBNull.Value ? null : objRow[convFeatureFuncRela.UpdDate].ToString().Trim(); //修改日期
objvFeatureFuncRelaEN.UpdUser = objRow[convFeatureFuncRela.UpdUser] == DBNull.Value ? null : objRow[convFeatureFuncRela.UpdUser].ToString().Trim(); //修改者
objvFeatureFuncRelaEN.Memo = objRow[convFeatureFuncRela.Memo] == DBNull.Value ? null : objRow[convFeatureFuncRela.Memo].ToString().Trim(); //说明
objvFeatureFuncRelaEN.FuncCodeTypeENName = objRow[convFeatureFuncRela.FuncCodeTypeENName] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncCodeTypeENName].ToString().Trim(); //FuncCodeTypeENName
objvFeatureFuncRelaEN.FuncCodeTypeId = objRow[convFeatureFuncRela.FuncCodeTypeId] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objvFeatureFuncRelaEN.FuncCodeTypeName = objRow[convFeatureFuncRela.FuncCodeTypeName] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncCodeTypeName].ToString().Trim(); //FuncCodeTypeName
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvFeatureFuncRelaDA: GetObjByDataRow)", objException.Message));
}
objvFeatureFuncRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFeatureFuncRelaEN;
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
objSQL = clsvFeatureFuncRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvFeatureFuncRelaEN._CurrTabName, convFeatureFuncRela.mId, 8, "");
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
objSQL = clsvFeatureFuncRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvFeatureFuncRelaEN._CurrTabName, convFeatureFuncRela.mId, 8, strPrefix);
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
 objSQL = clsvFeatureFuncRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vFeatureFuncRela where " + strCondition;
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
 objSQL = clsvFeatureFuncRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vFeatureFuncRela where " + strCondition;
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
 objSQL = clsvFeatureFuncRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vFeatureFuncRela", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvFeatureFuncRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureFuncRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vFeatureFuncRela", strCondition))
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
objSQL = clsvFeatureFuncRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vFeatureFuncRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvFeatureFuncRelaENS">源对象</param>
 /// <param name = "objvFeatureFuncRelaENT">目标对象</param>
public void CopyTo(clsvFeatureFuncRelaEN objvFeatureFuncRelaENS, clsvFeatureFuncRelaEN objvFeatureFuncRelaENT)
{
objvFeatureFuncRelaENT.mId = objvFeatureFuncRelaENS.mId; //mId
objvFeatureFuncRelaENT.ApplicationTypeId = objvFeatureFuncRelaENS.ApplicationTypeId; //应用程序类型ID
objvFeatureFuncRelaENT.ApplicationTypeName = objvFeatureFuncRelaENS.ApplicationTypeName; //应用程序类型名称
objvFeatureFuncRelaENT.ProgLangTypeName = objvFeatureFuncRelaENS.ProgLangTypeName; //编程语言类型名
objvFeatureFuncRelaENT.FeatureId = objvFeatureFuncRelaENS.FeatureId; //功能Id
objvFeatureFuncRelaENT.FeatureName = objvFeatureFuncRelaENS.FeatureName; //功能名称
objvFeatureFuncRelaENT.KeyWords = objvFeatureFuncRelaENS.KeyWords; //关键字
objvFeatureFuncRelaENT.FeatureTypeId = objvFeatureFuncRelaENS.FeatureTypeId; //功能类型Id
objvFeatureFuncRelaENT.FeatureTypeName = objvFeatureFuncRelaENS.FeatureTypeName; //功能类型名称
objvFeatureFuncRelaENT.FeatureName2 = objvFeatureFuncRelaENS.FeatureName2; //功能名-FuncCount
objvFeatureFuncRelaENT.FuncId4GC = objvFeatureFuncRelaENS.FuncId4GC; //函数ID
objvFeatureFuncRelaENT.FuncName = objvFeatureFuncRelaENS.FuncName; //函数名
objvFeatureFuncRelaENT.FuncId4Code = objvFeatureFuncRelaENS.FuncId4Code; //函数Id4Code
objvFeatureFuncRelaENT.FuncName4Code = objvFeatureFuncRelaENS.FuncName4Code; //函数名4Code
objvFeatureFuncRelaENT.FunctionSignature = objvFeatureFuncRelaENS.FunctionSignature; //函数签名
objvFeatureFuncRelaENT.OrderNum = objvFeatureFuncRelaENS.OrderNum; //序号
objvFeatureFuncRelaENT.UpdDate = objvFeatureFuncRelaENS.UpdDate; //修改日期
objvFeatureFuncRelaENT.UpdUser = objvFeatureFuncRelaENS.UpdUser; //修改者
objvFeatureFuncRelaENT.Memo = objvFeatureFuncRelaENS.Memo; //说明
objvFeatureFuncRelaENT.FuncCodeTypeENName = objvFeatureFuncRelaENS.FuncCodeTypeENName; //FuncCodeTypeENName
objvFeatureFuncRelaENT.FuncCodeTypeId = objvFeatureFuncRelaENS.FuncCodeTypeId; //函数代码类型Id
objvFeatureFuncRelaENT.FuncCodeTypeName = objvFeatureFuncRelaENS.FuncCodeTypeName; //FuncCodeTypeName
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvFeatureFuncRelaEN objvFeatureFuncRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvFeatureFuncRelaEN.ApplicationTypeName, 30, convFeatureFuncRela.ApplicationTypeName);
clsCheckSql.CheckFieldLen(objvFeatureFuncRelaEN.ProgLangTypeName, 30, convFeatureFuncRela.ProgLangTypeName);
clsCheckSql.CheckFieldLen(objvFeatureFuncRelaEN.FeatureId, 4, convFeatureFuncRela.FeatureId);
clsCheckSql.CheckFieldLen(objvFeatureFuncRelaEN.FeatureName, 100, convFeatureFuncRela.FeatureName);
clsCheckSql.CheckFieldLen(objvFeatureFuncRelaEN.KeyWords, 500, convFeatureFuncRela.KeyWords);
clsCheckSql.CheckFieldLen(objvFeatureFuncRelaEN.FeatureTypeId, 2, convFeatureFuncRela.FeatureTypeId);
clsCheckSql.CheckFieldLen(objvFeatureFuncRelaEN.FeatureTypeName, 30, convFeatureFuncRela.FeatureTypeName);
clsCheckSql.CheckFieldLen(objvFeatureFuncRelaEN.FeatureName2, 112, convFeatureFuncRela.FeatureName2);
clsCheckSql.CheckFieldLen(objvFeatureFuncRelaEN.FuncId4GC, 10, convFeatureFuncRela.FuncId4GC);
clsCheckSql.CheckFieldLen(objvFeatureFuncRelaEN.FuncName, 100, convFeatureFuncRela.FuncName);
clsCheckSql.CheckFieldLen(objvFeatureFuncRelaEN.FuncId4Code, 8, convFeatureFuncRela.FuncId4Code);
clsCheckSql.CheckFieldLen(objvFeatureFuncRelaEN.FuncName4Code, 100, convFeatureFuncRela.FuncName4Code);
clsCheckSql.CheckFieldLen(objvFeatureFuncRelaEN.FunctionSignature, 500, convFeatureFuncRela.FunctionSignature);
clsCheckSql.CheckFieldLen(objvFeatureFuncRelaEN.UpdDate, 20, convFeatureFuncRela.UpdDate);
clsCheckSql.CheckFieldLen(objvFeatureFuncRelaEN.UpdUser, 20, convFeatureFuncRela.UpdUser);
clsCheckSql.CheckFieldLen(objvFeatureFuncRelaEN.Memo, 1000, convFeatureFuncRela.Memo);
clsCheckSql.CheckFieldLen(objvFeatureFuncRelaEN.FuncCodeTypeENName, 50, convFeatureFuncRela.FuncCodeTypeENName);
clsCheckSql.CheckFieldLen(objvFeatureFuncRelaEN.FuncCodeTypeId, 4, convFeatureFuncRela.FuncCodeTypeId);
clsCheckSql.CheckFieldLen(objvFeatureFuncRelaEN.FuncCodeTypeName, 50, convFeatureFuncRela.FuncCodeTypeName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvFeatureFuncRelaEN.ApplicationTypeName, convFeatureFuncRela.ApplicationTypeName);
clsCheckSql.CheckSqlInjection4Field(objvFeatureFuncRelaEN.ProgLangTypeName, convFeatureFuncRela.ProgLangTypeName);
clsCheckSql.CheckSqlInjection4Field(objvFeatureFuncRelaEN.FeatureId, convFeatureFuncRela.FeatureId);
clsCheckSql.CheckSqlInjection4Field(objvFeatureFuncRelaEN.FeatureName, convFeatureFuncRela.FeatureName);
clsCheckSql.CheckSqlInjection4Field(objvFeatureFuncRelaEN.KeyWords, convFeatureFuncRela.KeyWords);
clsCheckSql.CheckSqlInjection4Field(objvFeatureFuncRelaEN.FeatureTypeId, convFeatureFuncRela.FeatureTypeId);
clsCheckSql.CheckSqlInjection4Field(objvFeatureFuncRelaEN.FeatureTypeName, convFeatureFuncRela.FeatureTypeName);
clsCheckSql.CheckSqlInjection4Field(objvFeatureFuncRelaEN.FeatureName2, convFeatureFuncRela.FeatureName2);
clsCheckSql.CheckSqlInjection4Field(objvFeatureFuncRelaEN.FuncId4GC, convFeatureFuncRela.FuncId4GC);
clsCheckSql.CheckSqlInjection4Field(objvFeatureFuncRelaEN.FuncName, convFeatureFuncRela.FuncName);
clsCheckSql.CheckSqlInjection4Field(objvFeatureFuncRelaEN.FuncId4Code, convFeatureFuncRela.FuncId4Code);
clsCheckSql.CheckSqlInjection4Field(objvFeatureFuncRelaEN.FuncName4Code, convFeatureFuncRela.FuncName4Code);
clsCheckSql.CheckSqlInjection4Field(objvFeatureFuncRelaEN.FunctionSignature, convFeatureFuncRela.FunctionSignature);
clsCheckSql.CheckSqlInjection4Field(objvFeatureFuncRelaEN.UpdDate, convFeatureFuncRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvFeatureFuncRelaEN.UpdUser, convFeatureFuncRela.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvFeatureFuncRelaEN.Memo, convFeatureFuncRela.Memo);
clsCheckSql.CheckSqlInjection4Field(objvFeatureFuncRelaEN.FuncCodeTypeENName, convFeatureFuncRela.FuncCodeTypeENName);
clsCheckSql.CheckSqlInjection4Field(objvFeatureFuncRelaEN.FuncCodeTypeId, convFeatureFuncRela.FuncCodeTypeId);
clsCheckSql.CheckSqlInjection4Field(objvFeatureFuncRelaEN.FuncCodeTypeName, convFeatureFuncRela.FuncCodeTypeName);
//检查外键字段长度
 objvFeatureFuncRelaEN._IsCheckProperty = true;
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
 objSQL = clsvFeatureFuncRelaDA.GetSpecSQLObj();
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
 objSQL = clsvFeatureFuncRelaDA.GetSpecSQLObj();
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
 objSQL = clsvFeatureFuncRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvFeatureFuncRelaEN._CurrTabName);
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
 objSQL = clsvFeatureFuncRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvFeatureFuncRelaEN._CurrTabName, strCondition);
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
 objSQL = clsvFeatureFuncRelaDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}