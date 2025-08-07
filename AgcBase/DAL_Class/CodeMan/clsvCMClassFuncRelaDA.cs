
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCMClassFuncRelaDA
 表名:vCMClassFuncRela(00050510)
 * 版本:2025.08.02.1(服务器:PYF-MINI)
 日期:2025/08/03 18:46:18
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
 /// vCM类函数关系(vCMClassFuncRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvCMClassFuncRelaDA : clsCommBase4DA
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
 return clsvCMClassFuncRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvCMClassFuncRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCMClassFuncRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvCMClassFuncRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvCMClassFuncRelaEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvCMClassFuncRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMClassFuncRelaDA.GetSpecSQLObj();
strSQL = "Select * from vCMClassFuncRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vCMClassFuncRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvCMClassFuncRelaDA: GetDataTable_vCMClassFuncRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMClassFuncRelaDA.GetSpecSQLObj();
strSQL = "Select * from vCMClassFuncRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvCMClassFuncRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMClassFuncRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvCMClassFuncRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMClassFuncRelaDA.GetSpecSQLObj();
strSQL = "Select * from vCMClassFuncRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvCMClassFuncRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMClassFuncRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvCMClassFuncRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMClassFuncRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCMClassFuncRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCMClassFuncRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvCMClassFuncRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMClassFuncRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vCMClassFuncRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvCMClassFuncRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMClassFuncRelaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vCMClassFuncRela.* " + 
$"from vCMClassFuncRela " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vCMClassFuncRela.mId not in " + 
$"(Select top {intTop_In} vCMClassFuncRela.mId from vCMClassFuncRela " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCMClassFuncRela where {1} and mId not in (Select top {2} mId from vCMClassFuncRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCMClassFuncRela where {1} and mId not in (Select top {3} mId from vCMClassFuncRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvCMClassFuncRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMClassFuncRelaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vCMClassFuncRela.* " + 
$"from vCMClassFuncRela " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vCMClassFuncRela.mId not in " + 
$"(Select top {intTop_In} vCMClassFuncRela.mId from vCMClassFuncRela " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCMClassFuncRela where {1} and mId not in (Select top {2} mId from vCMClassFuncRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCMClassFuncRela where {1} and mId not in (Select top {3} mId from vCMClassFuncRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvCMClassFuncRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvCMClassFuncRelaDA:GetObjLst)", objException.Message));
}
List<clsvCMClassFuncRelaEN> arrObjLst = new List<clsvCMClassFuncRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMClassFuncRelaDA.GetSpecSQLObj();
strSQL = "Select * from vCMClassFuncRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMClassFuncRelaEN objvCMClassFuncRelaEN = new clsvCMClassFuncRelaEN();
try
{
objvCMClassFuncRelaEN.mId = TransNullToInt(objRow[convCMClassFuncRela.mId].ToString().Trim()); //mId
objvCMClassFuncRelaEN.CmClassId = objRow[convCMClassFuncRela.CmClassId].ToString().Trim(); //类Id
objvCMClassFuncRelaEN.ApplicationTypeId = objRow[convCMClassFuncRela.ApplicationTypeId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCMClassFuncRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMClassFuncRelaEN.ProgLangTypeId = objRow[convCMClassFuncRela.ProgLangTypeId] == DBNull.Value ? null : objRow[convCMClassFuncRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCMClassFuncRelaEN.PrjId = objRow[convCMClassFuncRela.PrjId] == DBNull.Value ? null : objRow[convCMClassFuncRela.PrjId].ToString().Trim(); //工程Id
objvCMClassFuncRelaEN.CmFunctionId = objRow[convCMClassFuncRela.CmFunctionId].ToString().Trim(); //函数Id
objvCMClassFuncRelaEN.FunctionName = objRow[convCMClassFuncRela.FunctionName] == DBNull.Value ? null : objRow[convCMClassFuncRela.FunctionName].ToString().Trim(); //功能名称
objvCMClassFuncRelaEN.OrderNum = TransNullToInt(objRow[convCMClassFuncRela.OrderNum].ToString().Trim()); //序号
objvCMClassFuncRelaEN.UpdDate = objRow[convCMClassFuncRela.UpdDate] == DBNull.Value ? null : objRow[convCMClassFuncRela.UpdDate].ToString().Trim(); //修改日期
objvCMClassFuncRelaEN.UpdUser = objRow[convCMClassFuncRela.UpdUser] == DBNull.Value ? null : objRow[convCMClassFuncRela.UpdUser].ToString().Trim(); //修改者
objvCMClassFuncRelaEN.Memo = objRow[convCMClassFuncRela.Memo] == DBNull.Value ? null : objRow[convCMClassFuncRela.Memo].ToString().Trim(); //说明
objvCMClassFuncRelaEN.ClsName = objRow[convCMClassFuncRela.ClsName] == DBNull.Value ? null : objRow[convCMClassFuncRela.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCMClassFuncRelaDA: GetObjLst)", objException.Message));
}
objvCMClassFuncRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCMClassFuncRelaEN);
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
public List<clsvCMClassFuncRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvCMClassFuncRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsvCMClassFuncRelaEN> arrObjLst = new List<clsvCMClassFuncRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMClassFuncRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMClassFuncRelaEN objvCMClassFuncRelaEN = new clsvCMClassFuncRelaEN();
try
{
objvCMClassFuncRelaEN.mId = TransNullToInt(objRow[convCMClassFuncRela.mId].ToString().Trim()); //mId
objvCMClassFuncRelaEN.CmClassId = objRow[convCMClassFuncRela.CmClassId].ToString().Trim(); //类Id
objvCMClassFuncRelaEN.ApplicationTypeId = objRow[convCMClassFuncRela.ApplicationTypeId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCMClassFuncRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMClassFuncRelaEN.ProgLangTypeId = objRow[convCMClassFuncRela.ProgLangTypeId] == DBNull.Value ? null : objRow[convCMClassFuncRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCMClassFuncRelaEN.PrjId = objRow[convCMClassFuncRela.PrjId] == DBNull.Value ? null : objRow[convCMClassFuncRela.PrjId].ToString().Trim(); //工程Id
objvCMClassFuncRelaEN.CmFunctionId = objRow[convCMClassFuncRela.CmFunctionId].ToString().Trim(); //函数Id
objvCMClassFuncRelaEN.FunctionName = objRow[convCMClassFuncRela.FunctionName] == DBNull.Value ? null : objRow[convCMClassFuncRela.FunctionName].ToString().Trim(); //功能名称
objvCMClassFuncRelaEN.OrderNum = TransNullToInt(objRow[convCMClassFuncRela.OrderNum].ToString().Trim()); //序号
objvCMClassFuncRelaEN.UpdDate = objRow[convCMClassFuncRela.UpdDate] == DBNull.Value ? null : objRow[convCMClassFuncRela.UpdDate].ToString().Trim(); //修改日期
objvCMClassFuncRelaEN.UpdUser = objRow[convCMClassFuncRela.UpdUser] == DBNull.Value ? null : objRow[convCMClassFuncRela.UpdUser].ToString().Trim(); //修改者
objvCMClassFuncRelaEN.Memo = objRow[convCMClassFuncRela.Memo] == DBNull.Value ? null : objRow[convCMClassFuncRela.Memo].ToString().Trim(); //说明
objvCMClassFuncRelaEN.ClsName = objRow[convCMClassFuncRela.ClsName] == DBNull.Value ? null : objRow[convCMClassFuncRela.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCMClassFuncRelaDA: GetObjLst)", objException.Message));
}
objvCMClassFuncRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCMClassFuncRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvCMClassFuncRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvCMClassFuncRela(ref clsvCMClassFuncRelaEN objvCMClassFuncRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMClassFuncRelaDA.GetSpecSQLObj();
strSQL = "Select * from vCMClassFuncRela where mId = " + ""+ objvCMClassFuncRelaEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvCMClassFuncRelaEN.mId = TransNullToInt(objDT.Rows[0][convCMClassFuncRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvCMClassFuncRelaEN.CmClassId = objDT.Rows[0][convCMClassFuncRela.CmClassId].ToString().Trim(); //类Id(字段类型:char,字段长度:8,是否可空:False)
 objvCMClassFuncRelaEN.ApplicationTypeId = TransNullToInt(objDT.Rows[0][convCMClassFuncRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objvCMClassFuncRelaEN.ProgLangTypeId = objDT.Rows[0][convCMClassFuncRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvCMClassFuncRelaEN.PrjId = objDT.Rows[0][convCMClassFuncRela.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvCMClassFuncRelaEN.CmFunctionId = objDT.Rows[0][convCMClassFuncRela.CmFunctionId].ToString().Trim(); //函数Id(字段类型:char,字段长度:8,是否可空:False)
 objvCMClassFuncRelaEN.FunctionName = objDT.Rows[0][convCMClassFuncRela.FunctionName].ToString().Trim(); //功能名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvCMClassFuncRelaEN.OrderNum = TransNullToInt(objDT.Rows[0][convCMClassFuncRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvCMClassFuncRelaEN.UpdDate = objDT.Rows[0][convCMClassFuncRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCMClassFuncRelaEN.UpdUser = objDT.Rows[0][convCMClassFuncRela.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvCMClassFuncRelaEN.Memo = objDT.Rows[0][convCMClassFuncRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCMClassFuncRelaEN.ClsName = objDT.Rows[0][convCMClassFuncRela.ClsName].ToString().Trim(); //类名(字段类型:varchar,字段长度:100,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvCMClassFuncRelaDA: GetvCMClassFuncRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvCMClassFuncRelaEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMClassFuncRelaDA.GetSpecSQLObj();
strSQL = "Select * from vCMClassFuncRela where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvCMClassFuncRelaEN objvCMClassFuncRelaEN = new clsvCMClassFuncRelaEN();
try
{
 objvCMClassFuncRelaEN.mId = Int32.Parse(objRow[convCMClassFuncRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvCMClassFuncRelaEN.CmClassId = objRow[convCMClassFuncRela.CmClassId].ToString().Trim(); //类Id(字段类型:char,字段长度:8,是否可空:False)
 objvCMClassFuncRelaEN.ApplicationTypeId = objRow[convCMClassFuncRela.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMClassFuncRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objvCMClassFuncRelaEN.ProgLangTypeId = objRow[convCMClassFuncRela.ProgLangTypeId] == DBNull.Value ? null : objRow[convCMClassFuncRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvCMClassFuncRelaEN.PrjId = objRow[convCMClassFuncRela.PrjId] == DBNull.Value ? null : objRow[convCMClassFuncRela.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvCMClassFuncRelaEN.CmFunctionId = objRow[convCMClassFuncRela.CmFunctionId].ToString().Trim(); //函数Id(字段类型:char,字段长度:8,是否可空:False)
 objvCMClassFuncRelaEN.FunctionName = objRow[convCMClassFuncRela.FunctionName] == DBNull.Value ? null : objRow[convCMClassFuncRela.FunctionName].ToString().Trim(); //功能名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvCMClassFuncRelaEN.OrderNum = Int32.Parse(objRow[convCMClassFuncRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvCMClassFuncRelaEN.UpdDate = objRow[convCMClassFuncRela.UpdDate] == DBNull.Value ? null : objRow[convCMClassFuncRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCMClassFuncRelaEN.UpdUser = objRow[convCMClassFuncRela.UpdUser] == DBNull.Value ? null : objRow[convCMClassFuncRela.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvCMClassFuncRelaEN.Memo = objRow[convCMClassFuncRela.Memo] == DBNull.Value ? null : objRow[convCMClassFuncRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCMClassFuncRelaEN.ClsName = objRow[convCMClassFuncRela.ClsName] == DBNull.Value ? null : objRow[convCMClassFuncRela.ClsName].ToString().Trim(); //类名(字段类型:varchar,字段长度:100,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvCMClassFuncRelaDA: GetObjBymId)", objException.Message));
}
return objvCMClassFuncRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvCMClassFuncRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvCMClassFuncRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMClassFuncRelaDA.GetSpecSQLObj();
strSQL = "Select * from vCMClassFuncRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvCMClassFuncRelaEN objvCMClassFuncRelaEN = new clsvCMClassFuncRelaEN()
{
mId = TransNullToInt(objRow[convCMClassFuncRela.mId].ToString().Trim()), //mId
CmClassId = objRow[convCMClassFuncRela.CmClassId].ToString().Trim(), //类Id
ApplicationTypeId = objRow[convCMClassFuncRela.ApplicationTypeId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCMClassFuncRela.ApplicationTypeId].ToString().Trim()), //应用程序类型ID
ProgLangTypeId = objRow[convCMClassFuncRela.ProgLangTypeId] == DBNull.Value ? null : objRow[convCMClassFuncRela.ProgLangTypeId].ToString().Trim(), //编程语言类型Id
PrjId = objRow[convCMClassFuncRela.PrjId] == DBNull.Value ? null : objRow[convCMClassFuncRela.PrjId].ToString().Trim(), //工程Id
CmFunctionId = objRow[convCMClassFuncRela.CmFunctionId].ToString().Trim(), //函数Id
FunctionName = objRow[convCMClassFuncRela.FunctionName] == DBNull.Value ? null : objRow[convCMClassFuncRela.FunctionName].ToString().Trim(), //功能名称
OrderNum = TransNullToInt(objRow[convCMClassFuncRela.OrderNum].ToString().Trim()), //序号
UpdDate = objRow[convCMClassFuncRela.UpdDate] == DBNull.Value ? null : objRow[convCMClassFuncRela.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convCMClassFuncRela.UpdUser] == DBNull.Value ? null : objRow[convCMClassFuncRela.UpdUser].ToString().Trim(), //修改者
Memo = objRow[convCMClassFuncRela.Memo] == DBNull.Value ? null : objRow[convCMClassFuncRela.Memo].ToString().Trim(), //说明
ClsName = objRow[convCMClassFuncRela.ClsName] == DBNull.Value ? null : objRow[convCMClassFuncRela.ClsName].ToString().Trim() //类名
};
objvCMClassFuncRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCMClassFuncRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvCMClassFuncRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvCMClassFuncRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCMClassFuncRelaEN objvCMClassFuncRelaEN = new clsvCMClassFuncRelaEN();
try
{
objvCMClassFuncRelaEN.mId = TransNullToInt(objRow[convCMClassFuncRela.mId].ToString().Trim()); //mId
objvCMClassFuncRelaEN.CmClassId = objRow[convCMClassFuncRela.CmClassId].ToString().Trim(); //类Id
objvCMClassFuncRelaEN.ApplicationTypeId = objRow[convCMClassFuncRela.ApplicationTypeId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCMClassFuncRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMClassFuncRelaEN.ProgLangTypeId = objRow[convCMClassFuncRela.ProgLangTypeId] == DBNull.Value ? null : objRow[convCMClassFuncRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCMClassFuncRelaEN.PrjId = objRow[convCMClassFuncRela.PrjId] == DBNull.Value ? null : objRow[convCMClassFuncRela.PrjId].ToString().Trim(); //工程Id
objvCMClassFuncRelaEN.CmFunctionId = objRow[convCMClassFuncRela.CmFunctionId].ToString().Trim(); //函数Id
objvCMClassFuncRelaEN.FunctionName = objRow[convCMClassFuncRela.FunctionName] == DBNull.Value ? null : objRow[convCMClassFuncRela.FunctionName].ToString().Trim(); //功能名称
objvCMClassFuncRelaEN.OrderNum = TransNullToInt(objRow[convCMClassFuncRela.OrderNum].ToString().Trim()); //序号
objvCMClassFuncRelaEN.UpdDate = objRow[convCMClassFuncRela.UpdDate] == DBNull.Value ? null : objRow[convCMClassFuncRela.UpdDate].ToString().Trim(); //修改日期
objvCMClassFuncRelaEN.UpdUser = objRow[convCMClassFuncRela.UpdUser] == DBNull.Value ? null : objRow[convCMClassFuncRela.UpdUser].ToString().Trim(); //修改者
objvCMClassFuncRelaEN.Memo = objRow[convCMClassFuncRela.Memo] == DBNull.Value ? null : objRow[convCMClassFuncRela.Memo].ToString().Trim(); //说明
objvCMClassFuncRelaEN.ClsName = objRow[convCMClassFuncRela.ClsName] == DBNull.Value ? null : objRow[convCMClassFuncRela.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvCMClassFuncRelaDA: GetObjByDataRowvCMClassFuncRela)", objException.Message));
}
objvCMClassFuncRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCMClassFuncRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvCMClassFuncRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCMClassFuncRelaEN objvCMClassFuncRelaEN = new clsvCMClassFuncRelaEN();
try
{
objvCMClassFuncRelaEN.mId = TransNullToInt(objRow[convCMClassFuncRela.mId].ToString().Trim()); //mId
objvCMClassFuncRelaEN.CmClassId = objRow[convCMClassFuncRela.CmClassId].ToString().Trim(); //类Id
objvCMClassFuncRelaEN.ApplicationTypeId = objRow[convCMClassFuncRela.ApplicationTypeId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCMClassFuncRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMClassFuncRelaEN.ProgLangTypeId = objRow[convCMClassFuncRela.ProgLangTypeId] == DBNull.Value ? null : objRow[convCMClassFuncRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCMClassFuncRelaEN.PrjId = objRow[convCMClassFuncRela.PrjId] == DBNull.Value ? null : objRow[convCMClassFuncRela.PrjId].ToString().Trim(); //工程Id
objvCMClassFuncRelaEN.CmFunctionId = objRow[convCMClassFuncRela.CmFunctionId].ToString().Trim(); //函数Id
objvCMClassFuncRelaEN.FunctionName = objRow[convCMClassFuncRela.FunctionName] == DBNull.Value ? null : objRow[convCMClassFuncRela.FunctionName].ToString().Trim(); //功能名称
objvCMClassFuncRelaEN.OrderNum = TransNullToInt(objRow[convCMClassFuncRela.OrderNum].ToString().Trim()); //序号
objvCMClassFuncRelaEN.UpdDate = objRow[convCMClassFuncRela.UpdDate] == DBNull.Value ? null : objRow[convCMClassFuncRela.UpdDate].ToString().Trim(); //修改日期
objvCMClassFuncRelaEN.UpdUser = objRow[convCMClassFuncRela.UpdUser] == DBNull.Value ? null : objRow[convCMClassFuncRela.UpdUser].ToString().Trim(); //修改者
objvCMClassFuncRelaEN.Memo = objRow[convCMClassFuncRela.Memo] == DBNull.Value ? null : objRow[convCMClassFuncRela.Memo].ToString().Trim(); //说明
objvCMClassFuncRelaEN.ClsName = objRow[convCMClassFuncRela.ClsName] == DBNull.Value ? null : objRow[convCMClassFuncRela.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvCMClassFuncRelaDA: GetObjByDataRow)", objException.Message));
}
objvCMClassFuncRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCMClassFuncRelaEN;
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
objSQL = clsvCMClassFuncRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCMClassFuncRelaEN._CurrTabName, convCMClassFuncRela.mId, 8, "");
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
objSQL = clsvCMClassFuncRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCMClassFuncRelaEN._CurrTabName, convCMClassFuncRela.mId, 8, strPrefix);
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
 objSQL = clsvCMClassFuncRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vCMClassFuncRela where " + strCondition;
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
 objSQL = clsvCMClassFuncRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vCMClassFuncRela where " + strCondition;
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
 objSQL = clsvCMClassFuncRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCMClassFuncRela", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvCMClassFuncRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMClassFuncRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCMClassFuncRela", strCondition))
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
objSQL = clsvCMClassFuncRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vCMClassFuncRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvCMClassFuncRelaENS">源对象</param>
 /// <param name = "objvCMClassFuncRelaENT">目标对象</param>
public void CopyTo(clsvCMClassFuncRelaEN objvCMClassFuncRelaENS, clsvCMClassFuncRelaEN objvCMClassFuncRelaENT)
{
objvCMClassFuncRelaENT.mId = objvCMClassFuncRelaENS.mId; //mId
objvCMClassFuncRelaENT.CmClassId = objvCMClassFuncRelaENS.CmClassId; //类Id
objvCMClassFuncRelaENT.ApplicationTypeId = objvCMClassFuncRelaENS.ApplicationTypeId; //应用程序类型ID
objvCMClassFuncRelaENT.ProgLangTypeId = objvCMClassFuncRelaENS.ProgLangTypeId; //编程语言类型Id
objvCMClassFuncRelaENT.PrjId = objvCMClassFuncRelaENS.PrjId; //工程Id
objvCMClassFuncRelaENT.CmFunctionId = objvCMClassFuncRelaENS.CmFunctionId; //函数Id
objvCMClassFuncRelaENT.FunctionName = objvCMClassFuncRelaENS.FunctionName; //功能名称
objvCMClassFuncRelaENT.OrderNum = objvCMClassFuncRelaENS.OrderNum; //序号
objvCMClassFuncRelaENT.UpdDate = objvCMClassFuncRelaENS.UpdDate; //修改日期
objvCMClassFuncRelaENT.UpdUser = objvCMClassFuncRelaENS.UpdUser; //修改者
objvCMClassFuncRelaENT.Memo = objvCMClassFuncRelaENS.Memo; //说明
objvCMClassFuncRelaENT.ClsName = objvCMClassFuncRelaENS.ClsName; //类名
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvCMClassFuncRelaEN objvCMClassFuncRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvCMClassFuncRelaEN.CmClassId, 8, convCMClassFuncRela.CmClassId);
clsCheckSql.CheckFieldLen(objvCMClassFuncRelaEN.ProgLangTypeId, 2, convCMClassFuncRela.ProgLangTypeId);
clsCheckSql.CheckFieldLen(objvCMClassFuncRelaEN.PrjId, 4, convCMClassFuncRela.PrjId);
clsCheckSql.CheckFieldLen(objvCMClassFuncRelaEN.CmFunctionId, 8, convCMClassFuncRela.CmFunctionId);
clsCheckSql.CheckFieldLen(objvCMClassFuncRelaEN.FunctionName, 200, convCMClassFuncRela.FunctionName);
clsCheckSql.CheckFieldLen(objvCMClassFuncRelaEN.UpdDate, 20, convCMClassFuncRela.UpdDate);
clsCheckSql.CheckFieldLen(objvCMClassFuncRelaEN.UpdUser, 20, convCMClassFuncRela.UpdUser);
clsCheckSql.CheckFieldLen(objvCMClassFuncRelaEN.Memo, 1000, convCMClassFuncRela.Memo);
clsCheckSql.CheckFieldLen(objvCMClassFuncRelaEN.ClsName, 100, convCMClassFuncRela.ClsName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvCMClassFuncRelaEN.CmClassId, convCMClassFuncRela.CmClassId);
clsCheckSql.CheckSqlInjection4Field(objvCMClassFuncRelaEN.ProgLangTypeId, convCMClassFuncRela.ProgLangTypeId);
clsCheckSql.CheckSqlInjection4Field(objvCMClassFuncRelaEN.PrjId, convCMClassFuncRela.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvCMClassFuncRelaEN.CmFunctionId, convCMClassFuncRela.CmFunctionId);
clsCheckSql.CheckSqlInjection4Field(objvCMClassFuncRelaEN.FunctionName, convCMClassFuncRela.FunctionName);
clsCheckSql.CheckSqlInjection4Field(objvCMClassFuncRelaEN.UpdDate, convCMClassFuncRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvCMClassFuncRelaEN.UpdUser, convCMClassFuncRela.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvCMClassFuncRelaEN.Memo, convCMClassFuncRela.Memo);
clsCheckSql.CheckSqlInjection4Field(objvCMClassFuncRelaEN.ClsName, convCMClassFuncRela.ClsName);
//检查外键字段长度
 objvCMClassFuncRelaEN._IsCheckProperty = true;
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
 objSQL = clsvCMClassFuncRelaDA.GetSpecSQLObj();
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
 objSQL = clsvCMClassFuncRelaDA.GetSpecSQLObj();
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
 objSQL = clsvCMClassFuncRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCMClassFuncRelaEN._CurrTabName);
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
 objSQL = clsvCMClassFuncRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCMClassFuncRelaEN._CurrTabName, strCondition);
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
 objSQL = clsvCMClassFuncRelaDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}