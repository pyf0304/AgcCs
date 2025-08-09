
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFunctionRelaDA
 表名:vFunctionRela(00050321)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:12:22
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
 /// v函数与函数关系(vFunctionRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvFunctionRelaDA : clsCommBase4DA
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
 return clsvFunctionRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvFunctionRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvFunctionRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvFunctionRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvFunctionRelaEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvFunctionRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunctionRelaDA.GetSpecSQLObj();
strSQL = "Select * from vFunctionRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vFunctionRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvFunctionRelaDA: GetDataTable_vFunctionRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunctionRelaDA.GetSpecSQLObj();
strSQL = "Select * from vFunctionRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvFunctionRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunctionRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvFunctionRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunctionRelaDA.GetSpecSQLObj();
strSQL = "Select * from vFunctionRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvFunctionRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunctionRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvFunctionRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunctionRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFunctionRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFunctionRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvFunctionRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunctionRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vFunctionRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvFunctionRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunctionRelaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vFunctionRela.* " + 
$"from vFunctionRela " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vFunctionRela.mId not in " + 
$"(Select top {intTop_In} vFunctionRela.mId from vFunctionRela " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFunctionRela where {1} and mId not in (Select top {2} mId from vFunctionRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFunctionRela where {1} and mId not in (Select top {3} mId from vFunctionRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvFunctionRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunctionRelaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vFunctionRela.* " + 
$"from vFunctionRela " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vFunctionRela.mId not in " + 
$"(Select top {intTop_In} vFunctionRela.mId from vFunctionRela " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFunctionRela where {1} and mId not in (Select top {2} mId from vFunctionRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFunctionRela where {1} and mId not in (Select top {3} mId from vFunctionRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvFunctionRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvFunctionRelaDA:GetObjLst)", objException.Message));
}
List<clsvFunctionRelaEN> arrObjLst = new List<clsvFunctionRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunctionRelaDA.GetSpecSQLObj();
strSQL = "Select * from vFunctionRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionRelaEN objvFunctionRelaEN = new clsvFunctionRelaEN();
try
{
objvFunctionRelaEN.mId = TransNullToInt(objRow[convFunctionRela.mId].ToString().Trim()); //mId
objvFunctionRelaEN.FuncAId = objRow[convFunctionRela.FuncAId].ToString().Trim(); //函数AId
objvFunctionRelaEN.FeatureName = objRow[convFunctionRela.FeatureName] == DBNull.Value ? null : objRow[convFunctionRela.FeatureName].ToString().Trim(); //功能名称
objvFunctionRelaEN.OrderNum = objRow[convFunctionRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFunctionRela.OrderNum].ToString().Trim()); //序号
objvFunctionRelaEN.Order4FeatureNum = objRow[convFunctionRela.Order4FeatureNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFunctionRela.Order4FeatureNum].ToString().Trim()); //Order4FeatureNum
objvFunctionRelaEN.FuncBId = objRow[convFunctionRela.FuncBId].ToString().Trim(); //函数BId
objvFunctionRelaEN.FunctionRelaTypeId = objRow[convFunctionRela.FunctionRelaTypeId].ToString().Trim(); //函数关系类型Id
objvFunctionRelaEN.FunctionRelaTypeName = objRow[convFunctionRela.FunctionRelaTypeName] == DBNull.Value ? null : objRow[convFunctionRela.FunctionRelaTypeName].ToString().Trim(); //函数关系类型名称
objvFunctionRelaEN.UpdDate = objRow[convFunctionRela.UpdDate] == DBNull.Value ? null : objRow[convFunctionRela.UpdDate].ToString().Trim(); //修改日期
objvFunctionRelaEN.UpdUser = objRow[convFunctionRela.UpdUser] == DBNull.Value ? null : objRow[convFunctionRela.UpdUser].ToString().Trim(); //修改者
objvFunctionRelaEN.Memo = objRow[convFunctionRela.Memo] == DBNull.Value ? null : objRow[convFunctionRela.Memo].ToString().Trim(); //说明
objvFunctionRelaEN.FuncAName = objRow[convFunctionRela.FuncAName] == DBNull.Value ? null : objRow[convFunctionRela.FuncAName].ToString().Trim(); //FuncAName
objvFunctionRelaEN.ProgLangTypeIdA = objRow[convFunctionRela.ProgLangTypeIdA] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeIdA].ToString().Trim(); //ProgLangTypeIdA
objvFunctionRelaEN.ProgLangTypeNameA = objRow[convFunctionRela.ProgLangTypeNameA] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeNameA].ToString().Trim(); //ProgLangTypeNameA
objvFunctionRelaEN.FuncBName = objRow[convFunctionRela.FuncBName] == DBNull.Value ? null : objRow[convFunctionRela.FuncBName].ToString().Trim(); //FuncBName
objvFunctionRelaEN.ProgLangTypeIdB = objRow[convFunctionRela.ProgLangTypeIdB] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeIdB].ToString().Trim(); //ProgLangTypeIdB
objvFunctionRelaEN.ProgLangTypeNameB = objRow[convFunctionRela.ProgLangTypeNameB] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeNameB].ToString().Trim(); //ProgLangTypeNameB
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvFunctionRelaDA: GetObjLst)", objException.Message));
}
objvFunctionRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvFunctionRelaEN);
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
public List<clsvFunctionRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvFunctionRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsvFunctionRelaEN> arrObjLst = new List<clsvFunctionRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunctionRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionRelaEN objvFunctionRelaEN = new clsvFunctionRelaEN();
try
{
objvFunctionRelaEN.mId = TransNullToInt(objRow[convFunctionRela.mId].ToString().Trim()); //mId
objvFunctionRelaEN.FuncAId = objRow[convFunctionRela.FuncAId].ToString().Trim(); //函数AId
objvFunctionRelaEN.FeatureName = objRow[convFunctionRela.FeatureName] == DBNull.Value ? null : objRow[convFunctionRela.FeatureName].ToString().Trim(); //功能名称
objvFunctionRelaEN.OrderNum = objRow[convFunctionRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFunctionRela.OrderNum].ToString().Trim()); //序号
objvFunctionRelaEN.Order4FeatureNum = objRow[convFunctionRela.Order4FeatureNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFunctionRela.Order4FeatureNum].ToString().Trim()); //Order4FeatureNum
objvFunctionRelaEN.FuncBId = objRow[convFunctionRela.FuncBId].ToString().Trim(); //函数BId
objvFunctionRelaEN.FunctionRelaTypeId = objRow[convFunctionRela.FunctionRelaTypeId].ToString().Trim(); //函数关系类型Id
objvFunctionRelaEN.FunctionRelaTypeName = objRow[convFunctionRela.FunctionRelaTypeName] == DBNull.Value ? null : objRow[convFunctionRela.FunctionRelaTypeName].ToString().Trim(); //函数关系类型名称
objvFunctionRelaEN.UpdDate = objRow[convFunctionRela.UpdDate] == DBNull.Value ? null : objRow[convFunctionRela.UpdDate].ToString().Trim(); //修改日期
objvFunctionRelaEN.UpdUser = objRow[convFunctionRela.UpdUser] == DBNull.Value ? null : objRow[convFunctionRela.UpdUser].ToString().Trim(); //修改者
objvFunctionRelaEN.Memo = objRow[convFunctionRela.Memo] == DBNull.Value ? null : objRow[convFunctionRela.Memo].ToString().Trim(); //说明
objvFunctionRelaEN.FuncAName = objRow[convFunctionRela.FuncAName] == DBNull.Value ? null : objRow[convFunctionRela.FuncAName].ToString().Trim(); //FuncAName
objvFunctionRelaEN.ProgLangTypeIdA = objRow[convFunctionRela.ProgLangTypeIdA] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeIdA].ToString().Trim(); //ProgLangTypeIdA
objvFunctionRelaEN.ProgLangTypeNameA = objRow[convFunctionRela.ProgLangTypeNameA] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeNameA].ToString().Trim(); //ProgLangTypeNameA
objvFunctionRelaEN.FuncBName = objRow[convFunctionRela.FuncBName] == DBNull.Value ? null : objRow[convFunctionRela.FuncBName].ToString().Trim(); //FuncBName
objvFunctionRelaEN.ProgLangTypeIdB = objRow[convFunctionRela.ProgLangTypeIdB] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeIdB].ToString().Trim(); //ProgLangTypeIdB
objvFunctionRelaEN.ProgLangTypeNameB = objRow[convFunctionRela.ProgLangTypeNameB] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeNameB].ToString().Trim(); //ProgLangTypeNameB
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvFunctionRelaDA: GetObjLst)", objException.Message));
}
objvFunctionRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvFunctionRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvFunctionRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvFunctionRela(ref clsvFunctionRelaEN objvFunctionRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunctionRelaDA.GetSpecSQLObj();
strSQL = "Select * from vFunctionRela where mId = " + ""+ objvFunctionRelaEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvFunctionRelaEN.mId = TransNullToInt(objDT.Rows[0][convFunctionRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvFunctionRelaEN.FuncAId = objDT.Rows[0][convFunctionRela.FuncAId].ToString().Trim(); //函数AId(字段类型:char,字段长度:10,是否可空:False)
 objvFunctionRelaEN.FeatureName = objDT.Rows[0][convFunctionRela.FeatureName].ToString().Trim(); //功能名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvFunctionRelaEN.OrderNum = TransNullToInt(objDT.Rows[0][convFunctionRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvFunctionRelaEN.Order4FeatureNum = TransNullToInt(objDT.Rows[0][convFunctionRela.Order4FeatureNum].ToString().Trim()); //Order4FeatureNum(字段类型:int,字段长度:4,是否可空:True)
 objvFunctionRelaEN.FuncBId = objDT.Rows[0][convFunctionRela.FuncBId].ToString().Trim(); //函数BId(字段类型:char,字段长度:10,是否可空:False)
 objvFunctionRelaEN.FunctionRelaTypeId = objDT.Rows[0][convFunctionRela.FunctionRelaTypeId].ToString().Trim(); //函数关系类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvFunctionRelaEN.FunctionRelaTypeName = objDT.Rows[0][convFunctionRela.FunctionRelaTypeName].ToString().Trim(); //函数关系类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvFunctionRelaEN.UpdDate = objDT.Rows[0][convFunctionRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvFunctionRelaEN.UpdUser = objDT.Rows[0][convFunctionRela.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvFunctionRelaEN.Memo = objDT.Rows[0][convFunctionRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvFunctionRelaEN.FuncAName = objDT.Rows[0][convFunctionRela.FuncAName].ToString().Trim(); //FuncAName(字段类型:varchar,字段长度:100,是否可空:True)
 objvFunctionRelaEN.ProgLangTypeIdA = objDT.Rows[0][convFunctionRela.ProgLangTypeIdA].ToString().Trim(); //ProgLangTypeIdA(字段类型:char,字段长度:2,是否可空:True)
 objvFunctionRelaEN.ProgLangTypeNameA = objDT.Rows[0][convFunctionRela.ProgLangTypeNameA].ToString().Trim(); //ProgLangTypeNameA(字段类型:varchar,字段长度:30,是否可空:True)
 objvFunctionRelaEN.FuncBName = objDT.Rows[0][convFunctionRela.FuncBName].ToString().Trim(); //FuncBName(字段类型:varchar,字段长度:100,是否可空:True)
 objvFunctionRelaEN.ProgLangTypeIdB = objDT.Rows[0][convFunctionRela.ProgLangTypeIdB].ToString().Trim(); //ProgLangTypeIdB(字段类型:char,字段长度:2,是否可空:True)
 objvFunctionRelaEN.ProgLangTypeNameB = objDT.Rows[0][convFunctionRela.ProgLangTypeNameB].ToString().Trim(); //ProgLangTypeNameB(字段类型:varchar,字段长度:30,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvFunctionRelaDA: GetvFunctionRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvFunctionRelaEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunctionRelaDA.GetSpecSQLObj();
strSQL = "Select * from vFunctionRela where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvFunctionRelaEN objvFunctionRelaEN = new clsvFunctionRelaEN();
try
{
 objvFunctionRelaEN.mId = Int32.Parse(objRow[convFunctionRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvFunctionRelaEN.FuncAId = objRow[convFunctionRela.FuncAId].ToString().Trim(); //函数AId(字段类型:char,字段长度:10,是否可空:False)
 objvFunctionRelaEN.FeatureName = objRow[convFunctionRela.FeatureName] == DBNull.Value ? null : objRow[convFunctionRela.FeatureName].ToString().Trim(); //功能名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvFunctionRelaEN.OrderNum = objRow[convFunctionRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunctionRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvFunctionRelaEN.Order4FeatureNum = objRow[convFunctionRela.Order4FeatureNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunctionRela.Order4FeatureNum].ToString().Trim()); //Order4FeatureNum(字段类型:int,字段长度:4,是否可空:True)
 objvFunctionRelaEN.FuncBId = objRow[convFunctionRela.FuncBId].ToString().Trim(); //函数BId(字段类型:char,字段长度:10,是否可空:False)
 objvFunctionRelaEN.FunctionRelaTypeId = objRow[convFunctionRela.FunctionRelaTypeId].ToString().Trim(); //函数关系类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvFunctionRelaEN.FunctionRelaTypeName = objRow[convFunctionRela.FunctionRelaTypeName] == DBNull.Value ? null : objRow[convFunctionRela.FunctionRelaTypeName].ToString().Trim(); //函数关系类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvFunctionRelaEN.UpdDate = objRow[convFunctionRela.UpdDate] == DBNull.Value ? null : objRow[convFunctionRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvFunctionRelaEN.UpdUser = objRow[convFunctionRela.UpdUser] == DBNull.Value ? null : objRow[convFunctionRela.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvFunctionRelaEN.Memo = objRow[convFunctionRela.Memo] == DBNull.Value ? null : objRow[convFunctionRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvFunctionRelaEN.FuncAName = objRow[convFunctionRela.FuncAName] == DBNull.Value ? null : objRow[convFunctionRela.FuncAName].ToString().Trim(); //FuncAName(字段类型:varchar,字段长度:100,是否可空:True)
 objvFunctionRelaEN.ProgLangTypeIdA = objRow[convFunctionRela.ProgLangTypeIdA] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeIdA].ToString().Trim(); //ProgLangTypeIdA(字段类型:char,字段长度:2,是否可空:True)
 objvFunctionRelaEN.ProgLangTypeNameA = objRow[convFunctionRela.ProgLangTypeNameA] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeNameA].ToString().Trim(); //ProgLangTypeNameA(字段类型:varchar,字段长度:30,是否可空:True)
 objvFunctionRelaEN.FuncBName = objRow[convFunctionRela.FuncBName] == DBNull.Value ? null : objRow[convFunctionRela.FuncBName].ToString().Trim(); //FuncBName(字段类型:varchar,字段长度:100,是否可空:True)
 objvFunctionRelaEN.ProgLangTypeIdB = objRow[convFunctionRela.ProgLangTypeIdB] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeIdB].ToString().Trim(); //ProgLangTypeIdB(字段类型:char,字段长度:2,是否可空:True)
 objvFunctionRelaEN.ProgLangTypeNameB = objRow[convFunctionRela.ProgLangTypeNameB] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeNameB].ToString().Trim(); //ProgLangTypeNameB(字段类型:varchar,字段长度:30,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvFunctionRelaDA: GetObjBymId)", objException.Message));
}
return objvFunctionRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvFunctionRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvFunctionRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunctionRelaDA.GetSpecSQLObj();
strSQL = "Select * from vFunctionRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvFunctionRelaEN objvFunctionRelaEN = new clsvFunctionRelaEN()
{
mId = TransNullToInt(objRow[convFunctionRela.mId].ToString().Trim()), //mId
FuncAId = objRow[convFunctionRela.FuncAId].ToString().Trim(), //函数AId
FeatureName = objRow[convFunctionRela.FeatureName] == DBNull.Value ? null : objRow[convFunctionRela.FeatureName].ToString().Trim(), //功能名称
OrderNum = objRow[convFunctionRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFunctionRela.OrderNum].ToString().Trim()), //序号
Order4FeatureNum = objRow[convFunctionRela.Order4FeatureNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFunctionRela.Order4FeatureNum].ToString().Trim()), //Order4FeatureNum
FuncBId = objRow[convFunctionRela.FuncBId].ToString().Trim(), //函数BId
FunctionRelaTypeId = objRow[convFunctionRela.FunctionRelaTypeId].ToString().Trim(), //函数关系类型Id
FunctionRelaTypeName = objRow[convFunctionRela.FunctionRelaTypeName] == DBNull.Value ? null : objRow[convFunctionRela.FunctionRelaTypeName].ToString().Trim(), //函数关系类型名称
UpdDate = objRow[convFunctionRela.UpdDate] == DBNull.Value ? null : objRow[convFunctionRela.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convFunctionRela.UpdUser] == DBNull.Value ? null : objRow[convFunctionRela.UpdUser].ToString().Trim(), //修改者
Memo = objRow[convFunctionRela.Memo] == DBNull.Value ? null : objRow[convFunctionRela.Memo].ToString().Trim(), //说明
FuncAName = objRow[convFunctionRela.FuncAName] == DBNull.Value ? null : objRow[convFunctionRela.FuncAName].ToString().Trim(), //FuncAName
ProgLangTypeIdA = objRow[convFunctionRela.ProgLangTypeIdA] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeIdA].ToString().Trim(), //ProgLangTypeIdA
ProgLangTypeNameA = objRow[convFunctionRela.ProgLangTypeNameA] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeNameA].ToString().Trim(), //ProgLangTypeNameA
FuncBName = objRow[convFunctionRela.FuncBName] == DBNull.Value ? null : objRow[convFunctionRela.FuncBName].ToString().Trim(), //FuncBName
ProgLangTypeIdB = objRow[convFunctionRela.ProgLangTypeIdB] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeIdB].ToString().Trim(), //ProgLangTypeIdB
ProgLangTypeNameB = objRow[convFunctionRela.ProgLangTypeNameB] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeNameB].ToString().Trim() //ProgLangTypeNameB
};
objvFunctionRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFunctionRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvFunctionRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvFunctionRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvFunctionRelaEN objvFunctionRelaEN = new clsvFunctionRelaEN();
try
{
objvFunctionRelaEN.mId = TransNullToInt(objRow[convFunctionRela.mId].ToString().Trim()); //mId
objvFunctionRelaEN.FuncAId = objRow[convFunctionRela.FuncAId].ToString().Trim(); //函数AId
objvFunctionRelaEN.FeatureName = objRow[convFunctionRela.FeatureName] == DBNull.Value ? null : objRow[convFunctionRela.FeatureName].ToString().Trim(); //功能名称
objvFunctionRelaEN.OrderNum = objRow[convFunctionRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFunctionRela.OrderNum].ToString().Trim()); //序号
objvFunctionRelaEN.Order4FeatureNum = objRow[convFunctionRela.Order4FeatureNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFunctionRela.Order4FeatureNum].ToString().Trim()); //Order4FeatureNum
objvFunctionRelaEN.FuncBId = objRow[convFunctionRela.FuncBId].ToString().Trim(); //函数BId
objvFunctionRelaEN.FunctionRelaTypeId = objRow[convFunctionRela.FunctionRelaTypeId].ToString().Trim(); //函数关系类型Id
objvFunctionRelaEN.FunctionRelaTypeName = objRow[convFunctionRela.FunctionRelaTypeName] == DBNull.Value ? null : objRow[convFunctionRela.FunctionRelaTypeName].ToString().Trim(); //函数关系类型名称
objvFunctionRelaEN.UpdDate = objRow[convFunctionRela.UpdDate] == DBNull.Value ? null : objRow[convFunctionRela.UpdDate].ToString().Trim(); //修改日期
objvFunctionRelaEN.UpdUser = objRow[convFunctionRela.UpdUser] == DBNull.Value ? null : objRow[convFunctionRela.UpdUser].ToString().Trim(); //修改者
objvFunctionRelaEN.Memo = objRow[convFunctionRela.Memo] == DBNull.Value ? null : objRow[convFunctionRela.Memo].ToString().Trim(); //说明
objvFunctionRelaEN.FuncAName = objRow[convFunctionRela.FuncAName] == DBNull.Value ? null : objRow[convFunctionRela.FuncAName].ToString().Trim(); //FuncAName
objvFunctionRelaEN.ProgLangTypeIdA = objRow[convFunctionRela.ProgLangTypeIdA] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeIdA].ToString().Trim(); //ProgLangTypeIdA
objvFunctionRelaEN.ProgLangTypeNameA = objRow[convFunctionRela.ProgLangTypeNameA] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeNameA].ToString().Trim(); //ProgLangTypeNameA
objvFunctionRelaEN.FuncBName = objRow[convFunctionRela.FuncBName] == DBNull.Value ? null : objRow[convFunctionRela.FuncBName].ToString().Trim(); //FuncBName
objvFunctionRelaEN.ProgLangTypeIdB = objRow[convFunctionRela.ProgLangTypeIdB] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeIdB].ToString().Trim(); //ProgLangTypeIdB
objvFunctionRelaEN.ProgLangTypeNameB = objRow[convFunctionRela.ProgLangTypeNameB] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeNameB].ToString().Trim(); //ProgLangTypeNameB
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvFunctionRelaDA: GetObjByDataRowvFunctionRela)", objException.Message));
}
objvFunctionRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFunctionRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvFunctionRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvFunctionRelaEN objvFunctionRelaEN = new clsvFunctionRelaEN();
try
{
objvFunctionRelaEN.mId = TransNullToInt(objRow[convFunctionRela.mId].ToString().Trim()); //mId
objvFunctionRelaEN.FuncAId = objRow[convFunctionRela.FuncAId].ToString().Trim(); //函数AId
objvFunctionRelaEN.FeatureName = objRow[convFunctionRela.FeatureName] == DBNull.Value ? null : objRow[convFunctionRela.FeatureName].ToString().Trim(); //功能名称
objvFunctionRelaEN.OrderNum = objRow[convFunctionRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFunctionRela.OrderNum].ToString().Trim()); //序号
objvFunctionRelaEN.Order4FeatureNum = objRow[convFunctionRela.Order4FeatureNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFunctionRela.Order4FeatureNum].ToString().Trim()); //Order4FeatureNum
objvFunctionRelaEN.FuncBId = objRow[convFunctionRela.FuncBId].ToString().Trim(); //函数BId
objvFunctionRelaEN.FunctionRelaTypeId = objRow[convFunctionRela.FunctionRelaTypeId].ToString().Trim(); //函数关系类型Id
objvFunctionRelaEN.FunctionRelaTypeName = objRow[convFunctionRela.FunctionRelaTypeName] == DBNull.Value ? null : objRow[convFunctionRela.FunctionRelaTypeName].ToString().Trim(); //函数关系类型名称
objvFunctionRelaEN.UpdDate = objRow[convFunctionRela.UpdDate] == DBNull.Value ? null : objRow[convFunctionRela.UpdDate].ToString().Trim(); //修改日期
objvFunctionRelaEN.UpdUser = objRow[convFunctionRela.UpdUser] == DBNull.Value ? null : objRow[convFunctionRela.UpdUser].ToString().Trim(); //修改者
objvFunctionRelaEN.Memo = objRow[convFunctionRela.Memo] == DBNull.Value ? null : objRow[convFunctionRela.Memo].ToString().Trim(); //说明
objvFunctionRelaEN.FuncAName = objRow[convFunctionRela.FuncAName] == DBNull.Value ? null : objRow[convFunctionRela.FuncAName].ToString().Trim(); //FuncAName
objvFunctionRelaEN.ProgLangTypeIdA = objRow[convFunctionRela.ProgLangTypeIdA] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeIdA].ToString().Trim(); //ProgLangTypeIdA
objvFunctionRelaEN.ProgLangTypeNameA = objRow[convFunctionRela.ProgLangTypeNameA] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeNameA].ToString().Trim(); //ProgLangTypeNameA
objvFunctionRelaEN.FuncBName = objRow[convFunctionRela.FuncBName] == DBNull.Value ? null : objRow[convFunctionRela.FuncBName].ToString().Trim(); //FuncBName
objvFunctionRelaEN.ProgLangTypeIdB = objRow[convFunctionRela.ProgLangTypeIdB] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeIdB].ToString().Trim(); //ProgLangTypeIdB
objvFunctionRelaEN.ProgLangTypeNameB = objRow[convFunctionRela.ProgLangTypeNameB] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeNameB].ToString().Trim(); //ProgLangTypeNameB
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvFunctionRelaDA: GetObjByDataRow)", objException.Message));
}
objvFunctionRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFunctionRelaEN;
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
objSQL = clsvFunctionRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvFunctionRelaEN._CurrTabName, convFunctionRela.mId, 8, "");
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
objSQL = clsvFunctionRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvFunctionRelaEN._CurrTabName, convFunctionRela.mId, 8, strPrefix);
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
 objSQL = clsvFunctionRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vFunctionRela where " + strCondition;
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
 objSQL = clsvFunctionRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vFunctionRela where " + strCondition;
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
 objSQL = clsvFunctionRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vFunctionRela", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvFunctionRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunctionRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vFunctionRela", strCondition))
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
objSQL = clsvFunctionRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vFunctionRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvFunctionRelaENS">源对象</param>
 /// <param name = "objvFunctionRelaENT">目标对象</param>
public void CopyTo(clsvFunctionRelaEN objvFunctionRelaENS, clsvFunctionRelaEN objvFunctionRelaENT)
{
objvFunctionRelaENT.mId = objvFunctionRelaENS.mId; //mId
objvFunctionRelaENT.FuncAId = objvFunctionRelaENS.FuncAId; //函数AId
objvFunctionRelaENT.FeatureName = objvFunctionRelaENS.FeatureName; //功能名称
objvFunctionRelaENT.OrderNum = objvFunctionRelaENS.OrderNum; //序号
objvFunctionRelaENT.Order4FeatureNum = objvFunctionRelaENS.Order4FeatureNum; //Order4FeatureNum
objvFunctionRelaENT.FuncBId = objvFunctionRelaENS.FuncBId; //函数BId
objvFunctionRelaENT.FunctionRelaTypeId = objvFunctionRelaENS.FunctionRelaTypeId; //函数关系类型Id
objvFunctionRelaENT.FunctionRelaTypeName = objvFunctionRelaENS.FunctionRelaTypeName; //函数关系类型名称
objvFunctionRelaENT.UpdDate = objvFunctionRelaENS.UpdDate; //修改日期
objvFunctionRelaENT.UpdUser = objvFunctionRelaENS.UpdUser; //修改者
objvFunctionRelaENT.Memo = objvFunctionRelaENS.Memo; //说明
objvFunctionRelaENT.FuncAName = objvFunctionRelaENS.FuncAName; //FuncAName
objvFunctionRelaENT.ProgLangTypeIdA = objvFunctionRelaENS.ProgLangTypeIdA; //ProgLangTypeIdA
objvFunctionRelaENT.ProgLangTypeNameA = objvFunctionRelaENS.ProgLangTypeNameA; //ProgLangTypeNameA
objvFunctionRelaENT.FuncBName = objvFunctionRelaENS.FuncBName; //FuncBName
objvFunctionRelaENT.ProgLangTypeIdB = objvFunctionRelaENS.ProgLangTypeIdB; //ProgLangTypeIdB
objvFunctionRelaENT.ProgLangTypeNameB = objvFunctionRelaENS.ProgLangTypeNameB; //ProgLangTypeNameB
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvFunctionRelaEN objvFunctionRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvFunctionRelaEN.FuncAId, 10, convFunctionRela.FuncAId);
clsCheckSql.CheckFieldLen(objvFunctionRelaEN.FeatureName, 100, convFunctionRela.FeatureName);
clsCheckSql.CheckFieldLen(objvFunctionRelaEN.FuncBId, 10, convFunctionRela.FuncBId);
clsCheckSql.CheckFieldLen(objvFunctionRelaEN.FunctionRelaTypeId, 2, convFunctionRela.FunctionRelaTypeId);
clsCheckSql.CheckFieldLen(objvFunctionRelaEN.FunctionRelaTypeName, 30, convFunctionRela.FunctionRelaTypeName);
clsCheckSql.CheckFieldLen(objvFunctionRelaEN.UpdDate, 20, convFunctionRela.UpdDate);
clsCheckSql.CheckFieldLen(objvFunctionRelaEN.UpdUser, 20, convFunctionRela.UpdUser);
clsCheckSql.CheckFieldLen(objvFunctionRelaEN.Memo, 1000, convFunctionRela.Memo);
clsCheckSql.CheckFieldLen(objvFunctionRelaEN.FuncAName, 100, convFunctionRela.FuncAName);
clsCheckSql.CheckFieldLen(objvFunctionRelaEN.ProgLangTypeIdA, 2, convFunctionRela.ProgLangTypeIdA);
clsCheckSql.CheckFieldLen(objvFunctionRelaEN.ProgLangTypeNameA, 30, convFunctionRela.ProgLangTypeNameA);
clsCheckSql.CheckFieldLen(objvFunctionRelaEN.FuncBName, 100, convFunctionRela.FuncBName);
clsCheckSql.CheckFieldLen(objvFunctionRelaEN.ProgLangTypeIdB, 2, convFunctionRela.ProgLangTypeIdB);
clsCheckSql.CheckFieldLen(objvFunctionRelaEN.ProgLangTypeNameB, 30, convFunctionRela.ProgLangTypeNameB);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvFunctionRelaEN.FuncAId, convFunctionRela.FuncAId);
clsCheckSql.CheckSqlInjection4Field(objvFunctionRelaEN.FeatureName, convFunctionRela.FeatureName);
clsCheckSql.CheckSqlInjection4Field(objvFunctionRelaEN.FuncBId, convFunctionRela.FuncBId);
clsCheckSql.CheckSqlInjection4Field(objvFunctionRelaEN.FunctionRelaTypeId, convFunctionRela.FunctionRelaTypeId);
clsCheckSql.CheckSqlInjection4Field(objvFunctionRelaEN.FunctionRelaTypeName, convFunctionRela.FunctionRelaTypeName);
clsCheckSql.CheckSqlInjection4Field(objvFunctionRelaEN.UpdDate, convFunctionRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvFunctionRelaEN.UpdUser, convFunctionRela.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvFunctionRelaEN.Memo, convFunctionRela.Memo);
clsCheckSql.CheckSqlInjection4Field(objvFunctionRelaEN.FuncAName, convFunctionRela.FuncAName);
clsCheckSql.CheckSqlInjection4Field(objvFunctionRelaEN.ProgLangTypeIdA, convFunctionRela.ProgLangTypeIdA);
clsCheckSql.CheckSqlInjection4Field(objvFunctionRelaEN.ProgLangTypeNameA, convFunctionRela.ProgLangTypeNameA);
clsCheckSql.CheckSqlInjection4Field(objvFunctionRelaEN.FuncBName, convFunctionRela.FuncBName);
clsCheckSql.CheckSqlInjection4Field(objvFunctionRelaEN.ProgLangTypeIdB, convFunctionRela.ProgLangTypeIdB);
clsCheckSql.CheckSqlInjection4Field(objvFunctionRelaEN.ProgLangTypeNameB, convFunctionRela.ProgLangTypeNameB);
//检查外键字段长度
 objvFunctionRelaEN._IsCheckProperty = true;
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
 objSQL = clsvFunctionRelaDA.GetSpecSQLObj();
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
 objSQL = clsvFunctionRelaDA.GetSpecSQLObj();
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
 objSQL = clsvFunctionRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvFunctionRelaEN._CurrTabName);
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
 objSQL = clsvFunctionRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvFunctionRelaEN._CurrTabName, strCondition);
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
 objSQL = clsvFunctionRelaDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}