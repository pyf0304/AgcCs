
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCmProjectAppRelaDA
 表名:vCmProjectAppRela(00050634)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:26:39
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
 /// vCmProjectAppRela(vCmProjectAppRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvCmProjectAppRelaDA : clsCommBase4DA
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
 return clsvCmProjectAppRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvCmProjectAppRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCmProjectAppRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvCmProjectAppRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvCmProjectAppRelaEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvCmProjectAppRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCmProjectAppRelaDA.GetSpecSQLObj();
strSQL = "Select * from vCmProjectAppRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vCmProjectAppRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvCmProjectAppRelaDA: GetDataTable_vCmProjectAppRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCmProjectAppRelaDA.GetSpecSQLObj();
strSQL = "Select * from vCmProjectAppRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvCmProjectAppRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCmProjectAppRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvCmProjectAppRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCmProjectAppRelaDA.GetSpecSQLObj();
strSQL = "Select * from vCmProjectAppRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvCmProjectAppRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCmProjectAppRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvCmProjectAppRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCmProjectAppRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCmProjectAppRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCmProjectAppRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvCmProjectAppRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCmProjectAppRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vCmProjectAppRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvCmProjectAppRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCmProjectAppRelaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vCmProjectAppRela.* " + 
$"from vCmProjectAppRela " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vCmProjectAppRela.CMProjectAppRelaId not in " + 
$"(Select top {intTop_In} vCmProjectAppRela.CMProjectAppRelaId from vCmProjectAppRela " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCmProjectAppRela where {1} and CMProjectAppRelaId not in (Select top {2} CMProjectAppRelaId from vCmProjectAppRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCmProjectAppRela where {1} and CMProjectAppRelaId not in (Select top {3} CMProjectAppRelaId from vCmProjectAppRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvCmProjectAppRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCmProjectAppRelaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vCmProjectAppRela.* " + 
$"from vCmProjectAppRela " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vCmProjectAppRela.CMProjectAppRelaId not in " + 
$"(Select top {intTop_In} vCmProjectAppRela.CMProjectAppRelaId from vCmProjectAppRela " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCmProjectAppRela where {1} and CMProjectAppRelaId not in (Select top {2} CMProjectAppRelaId from vCmProjectAppRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCmProjectAppRela where {1} and CMProjectAppRelaId not in (Select top {3} CMProjectAppRelaId from vCmProjectAppRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvCmProjectAppRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvCmProjectAppRelaDA:GetObjLst)", objException.Message));
}
List<clsvCmProjectAppRelaEN> arrObjLst = new List<clsvCmProjectAppRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCmProjectAppRelaDA.GetSpecSQLObj();
strSQL = "Select * from vCmProjectAppRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCmProjectAppRelaEN objvCmProjectAppRelaEN = new clsvCmProjectAppRelaEN();
try
{
objvCmProjectAppRelaEN.CMProjectAppRelaId = TransNullToInt(objRow[convCmProjectAppRela.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objvCmProjectAppRelaEN.PrjId = objRow[convCmProjectAppRela.PrjId].ToString().Trim(); //工程Id
objvCmProjectAppRelaEN.PrjName = objRow[convCmProjectAppRela.PrjName].ToString().Trim(); //工程名称
objvCmProjectAppRelaEN.Memo = objRow[convCmProjectAppRela.Memo] == DBNull.Value ? null : objRow[convCmProjectAppRela.Memo].ToString().Trim(); //说明
objvCmProjectAppRelaEN.UpdDate = objRow[convCmProjectAppRela.UpdDate] == DBNull.Value ? null : objRow[convCmProjectAppRela.UpdDate].ToString().Trim(); //修改日期
objvCmProjectAppRelaEN.ApplicationTypeName = objRow[convCmProjectAppRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvCmProjectAppRelaEN.ApplicationTypeENName = objRow[convCmProjectAppRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvCmProjectAppRelaEN.ApplicationTypeSimName = objRow[convCmProjectAppRela.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCmProjectAppRela.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCmProjectAppRelaEN.CmPrjName = objRow[convCmProjectAppRela.CmPrjName] == DBNull.Value ? null : objRow[convCmProjectAppRela.CmPrjName].ToString().Trim(); //CM工程名
objvCmProjectAppRelaEN.ApplicationTypeId = TransNullToInt(objRow[convCmProjectAppRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCmProjectAppRelaEN.CmPrjId = objRow[convCmProjectAppRela.CmPrjId].ToString().Trim(); //Cm工程Id
objvCmProjectAppRelaEN.UpdUser = objRow[convCmProjectAppRela.UpdUser] == DBNull.Value ? null : objRow[convCmProjectAppRela.UpdUser].ToString().Trim(); //修改者
objvCmProjectAppRelaEN.OrderNum = TransNullToInt(objRow[convCmProjectAppRela.OrderNum].ToString().Trim()); //序号
objvCmProjectAppRelaEN.AppOrderNum = objRow[convCmProjectAppRela.AppOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCmProjectAppRela.AppOrderNum].ToString().Trim()); //AppOrderNum
objvCmProjectAppRelaEN.AppIsVisible = TransNullToBool(objRow[convCmProjectAppRela.AppIsVisible].ToString().Trim()); //AppIsVisible
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCmProjectAppRelaDA: GetObjLst)", objException.Message));
}
objvCmProjectAppRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCmProjectAppRelaEN);
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
public List<clsvCmProjectAppRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvCmProjectAppRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsvCmProjectAppRelaEN> arrObjLst = new List<clsvCmProjectAppRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCmProjectAppRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCmProjectAppRelaEN objvCmProjectAppRelaEN = new clsvCmProjectAppRelaEN();
try
{
objvCmProjectAppRelaEN.CMProjectAppRelaId = TransNullToInt(objRow[convCmProjectAppRela.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objvCmProjectAppRelaEN.PrjId = objRow[convCmProjectAppRela.PrjId].ToString().Trim(); //工程Id
objvCmProjectAppRelaEN.PrjName = objRow[convCmProjectAppRela.PrjName].ToString().Trim(); //工程名称
objvCmProjectAppRelaEN.Memo = objRow[convCmProjectAppRela.Memo] == DBNull.Value ? null : objRow[convCmProjectAppRela.Memo].ToString().Trim(); //说明
objvCmProjectAppRelaEN.UpdDate = objRow[convCmProjectAppRela.UpdDate] == DBNull.Value ? null : objRow[convCmProjectAppRela.UpdDate].ToString().Trim(); //修改日期
objvCmProjectAppRelaEN.ApplicationTypeName = objRow[convCmProjectAppRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvCmProjectAppRelaEN.ApplicationTypeENName = objRow[convCmProjectAppRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvCmProjectAppRelaEN.ApplicationTypeSimName = objRow[convCmProjectAppRela.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCmProjectAppRela.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCmProjectAppRelaEN.CmPrjName = objRow[convCmProjectAppRela.CmPrjName] == DBNull.Value ? null : objRow[convCmProjectAppRela.CmPrjName].ToString().Trim(); //CM工程名
objvCmProjectAppRelaEN.ApplicationTypeId = TransNullToInt(objRow[convCmProjectAppRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCmProjectAppRelaEN.CmPrjId = objRow[convCmProjectAppRela.CmPrjId].ToString().Trim(); //Cm工程Id
objvCmProjectAppRelaEN.UpdUser = objRow[convCmProjectAppRela.UpdUser] == DBNull.Value ? null : objRow[convCmProjectAppRela.UpdUser].ToString().Trim(); //修改者
objvCmProjectAppRelaEN.OrderNum = TransNullToInt(objRow[convCmProjectAppRela.OrderNum].ToString().Trim()); //序号
objvCmProjectAppRelaEN.AppOrderNum = objRow[convCmProjectAppRela.AppOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCmProjectAppRela.AppOrderNum].ToString().Trim()); //AppOrderNum
objvCmProjectAppRelaEN.AppIsVisible = TransNullToBool(objRow[convCmProjectAppRela.AppIsVisible].ToString().Trim()); //AppIsVisible
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCmProjectAppRelaDA: GetObjLst)", objException.Message));
}
objvCmProjectAppRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCmProjectAppRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvCmProjectAppRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvCmProjectAppRela(ref clsvCmProjectAppRelaEN objvCmProjectAppRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCmProjectAppRelaDA.GetSpecSQLObj();
strSQL = "Select * from vCmProjectAppRela where CMProjectAppRelaId = " + ""+ objvCmProjectAppRelaEN.CMProjectAppRelaId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvCmProjectAppRelaEN.CMProjectAppRelaId = TransNullToInt(objDT.Rows[0][convCmProjectAppRela.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id(字段类型:bigint,字段长度:8,是否可空:False)
 objvCmProjectAppRelaEN.PrjId = objDT.Rows[0][convCmProjectAppRela.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvCmProjectAppRelaEN.PrjName = objDT.Rows[0][convCmProjectAppRela.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCmProjectAppRelaEN.Memo = objDT.Rows[0][convCmProjectAppRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCmProjectAppRelaEN.UpdDate = objDT.Rows[0][convCmProjectAppRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCmProjectAppRelaEN.ApplicationTypeName = objDT.Rows[0][convCmProjectAppRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCmProjectAppRelaEN.ApplicationTypeENName = objDT.Rows[0][convCmProjectAppRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名(字段类型:varchar,字段长度:30,是否可空:False)
 objvCmProjectAppRelaEN.ApplicationTypeSimName = objDT.Rows[0][convCmProjectAppRela.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvCmProjectAppRelaEN.CmPrjName = objDT.Rows[0][convCmProjectAppRela.CmPrjName].ToString().Trim(); //CM工程名(字段类型:varchar,字段长度:50,是否可空:True)
 objvCmProjectAppRelaEN.ApplicationTypeId = TransNullToInt(objDT.Rows[0][convCmProjectAppRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objvCmProjectAppRelaEN.CmPrjId = objDT.Rows[0][convCmProjectAppRela.CmPrjId].ToString().Trim(); //Cm工程Id(字段类型:char,字段长度:6,是否可空:False)
 objvCmProjectAppRelaEN.UpdUser = objDT.Rows[0][convCmProjectAppRela.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvCmProjectAppRelaEN.OrderNum = TransNullToInt(objDT.Rows[0][convCmProjectAppRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvCmProjectAppRelaEN.AppOrderNum = TransNullToInt(objDT.Rows[0][convCmProjectAppRela.AppOrderNum].ToString().Trim()); //AppOrderNum(字段类型:int,字段长度:4,是否可空:True)
 objvCmProjectAppRelaEN.AppIsVisible = TransNullToBool(objDT.Rows[0][convCmProjectAppRela.AppIsVisible].ToString().Trim()); //AppIsVisible(字段类型:bit,字段长度:1,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvCmProjectAppRelaDA: GetvCmProjectAppRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngCMProjectAppRelaId">表关键字</param>
 /// <returns>表对象</returns>
public clsvCmProjectAppRelaEN GetObjByCMProjectAppRelaId(long lngCMProjectAppRelaId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCmProjectAppRelaDA.GetSpecSQLObj();
strSQL = "Select * from vCmProjectAppRela where CMProjectAppRelaId = " + ""+ lngCMProjectAppRelaId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvCmProjectAppRelaEN objvCmProjectAppRelaEN = new clsvCmProjectAppRelaEN();
try
{
 objvCmProjectAppRelaEN.CMProjectAppRelaId = Int32.Parse(objRow[convCmProjectAppRela.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id(字段类型:bigint,字段长度:8,是否可空:False)
 objvCmProjectAppRelaEN.PrjId = objRow[convCmProjectAppRela.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvCmProjectAppRelaEN.PrjName = objRow[convCmProjectAppRela.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCmProjectAppRelaEN.Memo = objRow[convCmProjectAppRela.Memo] == DBNull.Value ? null : objRow[convCmProjectAppRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCmProjectAppRelaEN.UpdDate = objRow[convCmProjectAppRela.UpdDate] == DBNull.Value ? null : objRow[convCmProjectAppRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCmProjectAppRelaEN.ApplicationTypeName = objRow[convCmProjectAppRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCmProjectAppRelaEN.ApplicationTypeENName = objRow[convCmProjectAppRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名(字段类型:varchar,字段长度:30,是否可空:False)
 objvCmProjectAppRelaEN.ApplicationTypeSimName = objRow[convCmProjectAppRela.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCmProjectAppRela.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvCmProjectAppRelaEN.CmPrjName = objRow[convCmProjectAppRela.CmPrjName] == DBNull.Value ? null : objRow[convCmProjectAppRela.CmPrjName].ToString().Trim(); //CM工程名(字段类型:varchar,字段长度:50,是否可空:True)
 objvCmProjectAppRelaEN.ApplicationTypeId = Int32.Parse(objRow[convCmProjectAppRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objvCmProjectAppRelaEN.CmPrjId = objRow[convCmProjectAppRela.CmPrjId].ToString().Trim(); //Cm工程Id(字段类型:char,字段长度:6,是否可空:False)
 objvCmProjectAppRelaEN.UpdUser = objRow[convCmProjectAppRela.UpdUser] == DBNull.Value ? null : objRow[convCmProjectAppRela.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvCmProjectAppRelaEN.OrderNum = Int32.Parse(objRow[convCmProjectAppRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvCmProjectAppRelaEN.AppOrderNum = objRow[convCmProjectAppRela.AppOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCmProjectAppRela.AppOrderNum].ToString().Trim()); //AppOrderNum(字段类型:int,字段长度:4,是否可空:True)
 objvCmProjectAppRelaEN.AppIsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCmProjectAppRela.AppIsVisible].ToString().Trim()); //AppIsVisible(字段类型:bit,字段长度:1,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvCmProjectAppRelaDA: GetObjByCMProjectAppRelaId)", objException.Message));
}
return objvCmProjectAppRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvCmProjectAppRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvCmProjectAppRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCmProjectAppRelaDA.GetSpecSQLObj();
strSQL = "Select * from vCmProjectAppRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvCmProjectAppRelaEN objvCmProjectAppRelaEN = new clsvCmProjectAppRelaEN()
{
CMProjectAppRelaId = TransNullToInt(objRow[convCmProjectAppRela.CMProjectAppRelaId].ToString().Trim()), //Cm工程应用关系Id
PrjId = objRow[convCmProjectAppRela.PrjId].ToString().Trim(), //工程Id
PrjName = objRow[convCmProjectAppRela.PrjName].ToString().Trim(), //工程名称
Memo = objRow[convCmProjectAppRela.Memo] == DBNull.Value ? null : objRow[convCmProjectAppRela.Memo].ToString().Trim(), //说明
UpdDate = objRow[convCmProjectAppRela.UpdDate] == DBNull.Value ? null : objRow[convCmProjectAppRela.UpdDate].ToString().Trim(), //修改日期
ApplicationTypeName = objRow[convCmProjectAppRela.ApplicationTypeName].ToString().Trim(), //应用程序类型名称
ApplicationTypeENName = objRow[convCmProjectAppRela.ApplicationTypeENName].ToString().Trim(), //应用类型英文名
ApplicationTypeSimName = objRow[convCmProjectAppRela.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCmProjectAppRela.ApplicationTypeSimName].ToString().Trim(), //应用程序类型简称
CmPrjName = objRow[convCmProjectAppRela.CmPrjName] == DBNull.Value ? null : objRow[convCmProjectAppRela.CmPrjName].ToString().Trim(), //CM工程名
ApplicationTypeId = TransNullToInt(objRow[convCmProjectAppRela.ApplicationTypeId].ToString().Trim()), //应用程序类型ID
CmPrjId = objRow[convCmProjectAppRela.CmPrjId].ToString().Trim(), //Cm工程Id
UpdUser = objRow[convCmProjectAppRela.UpdUser] == DBNull.Value ? null : objRow[convCmProjectAppRela.UpdUser].ToString().Trim(), //修改者
OrderNum = TransNullToInt(objRow[convCmProjectAppRela.OrderNum].ToString().Trim()), //序号
AppOrderNum = objRow[convCmProjectAppRela.AppOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCmProjectAppRela.AppOrderNum].ToString().Trim()), //AppOrderNum
AppIsVisible = TransNullToBool(objRow[convCmProjectAppRela.AppIsVisible].ToString().Trim()) //AppIsVisible
};
objvCmProjectAppRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCmProjectAppRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvCmProjectAppRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvCmProjectAppRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCmProjectAppRelaEN objvCmProjectAppRelaEN = new clsvCmProjectAppRelaEN();
try
{
objvCmProjectAppRelaEN.CMProjectAppRelaId = TransNullToInt(objRow[convCmProjectAppRela.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objvCmProjectAppRelaEN.PrjId = objRow[convCmProjectAppRela.PrjId].ToString().Trim(); //工程Id
objvCmProjectAppRelaEN.PrjName = objRow[convCmProjectAppRela.PrjName].ToString().Trim(); //工程名称
objvCmProjectAppRelaEN.Memo = objRow[convCmProjectAppRela.Memo] == DBNull.Value ? null : objRow[convCmProjectAppRela.Memo].ToString().Trim(); //说明
objvCmProjectAppRelaEN.UpdDate = objRow[convCmProjectAppRela.UpdDate] == DBNull.Value ? null : objRow[convCmProjectAppRela.UpdDate].ToString().Trim(); //修改日期
objvCmProjectAppRelaEN.ApplicationTypeName = objRow[convCmProjectAppRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvCmProjectAppRelaEN.ApplicationTypeENName = objRow[convCmProjectAppRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvCmProjectAppRelaEN.ApplicationTypeSimName = objRow[convCmProjectAppRela.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCmProjectAppRela.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCmProjectAppRelaEN.CmPrjName = objRow[convCmProjectAppRela.CmPrjName] == DBNull.Value ? null : objRow[convCmProjectAppRela.CmPrjName].ToString().Trim(); //CM工程名
objvCmProjectAppRelaEN.ApplicationTypeId = TransNullToInt(objRow[convCmProjectAppRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCmProjectAppRelaEN.CmPrjId = objRow[convCmProjectAppRela.CmPrjId].ToString().Trim(); //Cm工程Id
objvCmProjectAppRelaEN.UpdUser = objRow[convCmProjectAppRela.UpdUser] == DBNull.Value ? null : objRow[convCmProjectAppRela.UpdUser].ToString().Trim(); //修改者
objvCmProjectAppRelaEN.OrderNum = TransNullToInt(objRow[convCmProjectAppRela.OrderNum].ToString().Trim()); //序号
objvCmProjectAppRelaEN.AppOrderNum = objRow[convCmProjectAppRela.AppOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCmProjectAppRela.AppOrderNum].ToString().Trim()); //AppOrderNum
objvCmProjectAppRelaEN.AppIsVisible = TransNullToBool(objRow[convCmProjectAppRela.AppIsVisible].ToString().Trim()); //AppIsVisible
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvCmProjectAppRelaDA: GetObjByDataRowvCmProjectAppRela)", objException.Message));
}
objvCmProjectAppRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCmProjectAppRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvCmProjectAppRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCmProjectAppRelaEN objvCmProjectAppRelaEN = new clsvCmProjectAppRelaEN();
try
{
objvCmProjectAppRelaEN.CMProjectAppRelaId = TransNullToInt(objRow[convCmProjectAppRela.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objvCmProjectAppRelaEN.PrjId = objRow[convCmProjectAppRela.PrjId].ToString().Trim(); //工程Id
objvCmProjectAppRelaEN.PrjName = objRow[convCmProjectAppRela.PrjName].ToString().Trim(); //工程名称
objvCmProjectAppRelaEN.Memo = objRow[convCmProjectAppRela.Memo] == DBNull.Value ? null : objRow[convCmProjectAppRela.Memo].ToString().Trim(); //说明
objvCmProjectAppRelaEN.UpdDate = objRow[convCmProjectAppRela.UpdDate] == DBNull.Value ? null : objRow[convCmProjectAppRela.UpdDate].ToString().Trim(); //修改日期
objvCmProjectAppRelaEN.ApplicationTypeName = objRow[convCmProjectAppRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvCmProjectAppRelaEN.ApplicationTypeENName = objRow[convCmProjectAppRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvCmProjectAppRelaEN.ApplicationTypeSimName = objRow[convCmProjectAppRela.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCmProjectAppRela.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCmProjectAppRelaEN.CmPrjName = objRow[convCmProjectAppRela.CmPrjName] == DBNull.Value ? null : objRow[convCmProjectAppRela.CmPrjName].ToString().Trim(); //CM工程名
objvCmProjectAppRelaEN.ApplicationTypeId = TransNullToInt(objRow[convCmProjectAppRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCmProjectAppRelaEN.CmPrjId = objRow[convCmProjectAppRela.CmPrjId].ToString().Trim(); //Cm工程Id
objvCmProjectAppRelaEN.UpdUser = objRow[convCmProjectAppRela.UpdUser] == DBNull.Value ? null : objRow[convCmProjectAppRela.UpdUser].ToString().Trim(); //修改者
objvCmProjectAppRelaEN.OrderNum = TransNullToInt(objRow[convCmProjectAppRela.OrderNum].ToString().Trim()); //序号
objvCmProjectAppRelaEN.AppOrderNum = objRow[convCmProjectAppRela.AppOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCmProjectAppRela.AppOrderNum].ToString().Trim()); //AppOrderNum
objvCmProjectAppRelaEN.AppIsVisible = TransNullToBool(objRow[convCmProjectAppRela.AppIsVisible].ToString().Trim()); //AppIsVisible
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvCmProjectAppRelaDA: GetObjByDataRow)", objException.Message));
}
objvCmProjectAppRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCmProjectAppRelaEN;
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
objSQL = clsvCmProjectAppRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCmProjectAppRelaEN._CurrTabName, convCmProjectAppRela.CMProjectAppRelaId, 8, "");
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
objSQL = clsvCmProjectAppRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCmProjectAppRelaEN._CurrTabName, convCmProjectAppRela.CMProjectAppRelaId, 8, strPrefix);
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
 objSQL = clsvCmProjectAppRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select CMProjectAppRelaId from vCmProjectAppRela where " + strCondition;
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
 objSQL = clsvCmProjectAppRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select CMProjectAppRelaId from vCmProjectAppRela where " + strCondition;
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
 /// <param name = "lngCMProjectAppRelaId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngCMProjectAppRelaId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCmProjectAppRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCmProjectAppRela", "CMProjectAppRelaId = " + ""+ lngCMProjectAppRelaId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvCmProjectAppRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCmProjectAppRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCmProjectAppRela", strCondition))
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
objSQL = clsvCmProjectAppRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vCmProjectAppRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvCmProjectAppRelaENS">源对象</param>
 /// <param name = "objvCmProjectAppRelaENT">目标对象</param>
public void CopyTo(clsvCmProjectAppRelaEN objvCmProjectAppRelaENS, clsvCmProjectAppRelaEN objvCmProjectAppRelaENT)
{
objvCmProjectAppRelaENT.CMProjectAppRelaId = objvCmProjectAppRelaENS.CMProjectAppRelaId; //Cm工程应用关系Id
objvCmProjectAppRelaENT.PrjId = objvCmProjectAppRelaENS.PrjId; //工程Id
objvCmProjectAppRelaENT.PrjName = objvCmProjectAppRelaENS.PrjName; //工程名称
objvCmProjectAppRelaENT.Memo = objvCmProjectAppRelaENS.Memo; //说明
objvCmProjectAppRelaENT.UpdDate = objvCmProjectAppRelaENS.UpdDate; //修改日期
objvCmProjectAppRelaENT.ApplicationTypeName = objvCmProjectAppRelaENS.ApplicationTypeName; //应用程序类型名称
objvCmProjectAppRelaENT.ApplicationTypeENName = objvCmProjectAppRelaENS.ApplicationTypeENName; //应用类型英文名
objvCmProjectAppRelaENT.ApplicationTypeSimName = objvCmProjectAppRelaENS.ApplicationTypeSimName; //应用程序类型简称
objvCmProjectAppRelaENT.CmPrjName = objvCmProjectAppRelaENS.CmPrjName; //CM工程名
objvCmProjectAppRelaENT.ApplicationTypeId = objvCmProjectAppRelaENS.ApplicationTypeId; //应用程序类型ID
objvCmProjectAppRelaENT.CmPrjId = objvCmProjectAppRelaENS.CmPrjId; //Cm工程Id
objvCmProjectAppRelaENT.UpdUser = objvCmProjectAppRelaENS.UpdUser; //修改者
objvCmProjectAppRelaENT.OrderNum = objvCmProjectAppRelaENS.OrderNum; //序号
objvCmProjectAppRelaENT.AppOrderNum = objvCmProjectAppRelaENS.AppOrderNum; //AppOrderNum
objvCmProjectAppRelaENT.AppIsVisible = objvCmProjectAppRelaENS.AppIsVisible; //AppIsVisible
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvCmProjectAppRelaEN objvCmProjectAppRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvCmProjectAppRelaEN.PrjId, 4, convCmProjectAppRela.PrjId);
clsCheckSql.CheckFieldLen(objvCmProjectAppRelaEN.PrjName, 30, convCmProjectAppRela.PrjName);
clsCheckSql.CheckFieldLen(objvCmProjectAppRelaEN.Memo, 1000, convCmProjectAppRela.Memo);
clsCheckSql.CheckFieldLen(objvCmProjectAppRelaEN.UpdDate, 20, convCmProjectAppRela.UpdDate);
clsCheckSql.CheckFieldLen(objvCmProjectAppRelaEN.ApplicationTypeName, 30, convCmProjectAppRela.ApplicationTypeName);
clsCheckSql.CheckFieldLen(objvCmProjectAppRelaEN.ApplicationTypeENName, 30, convCmProjectAppRela.ApplicationTypeENName);
clsCheckSql.CheckFieldLen(objvCmProjectAppRelaEN.ApplicationTypeSimName, 30, convCmProjectAppRela.ApplicationTypeSimName);
clsCheckSql.CheckFieldLen(objvCmProjectAppRelaEN.CmPrjName, 50, convCmProjectAppRela.CmPrjName);
clsCheckSql.CheckFieldLen(objvCmProjectAppRelaEN.CmPrjId, 6, convCmProjectAppRela.CmPrjId);
clsCheckSql.CheckFieldLen(objvCmProjectAppRelaEN.UpdUser, 20, convCmProjectAppRela.UpdUser);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvCmProjectAppRelaEN.PrjId, convCmProjectAppRela.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvCmProjectAppRelaEN.PrjName, convCmProjectAppRela.PrjName);
clsCheckSql.CheckSqlInjection4Field(objvCmProjectAppRelaEN.Memo, convCmProjectAppRela.Memo);
clsCheckSql.CheckSqlInjection4Field(objvCmProjectAppRelaEN.UpdDate, convCmProjectAppRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvCmProjectAppRelaEN.ApplicationTypeName, convCmProjectAppRela.ApplicationTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCmProjectAppRelaEN.ApplicationTypeENName, convCmProjectAppRela.ApplicationTypeENName);
clsCheckSql.CheckSqlInjection4Field(objvCmProjectAppRelaEN.ApplicationTypeSimName, convCmProjectAppRela.ApplicationTypeSimName);
clsCheckSql.CheckSqlInjection4Field(objvCmProjectAppRelaEN.CmPrjName, convCmProjectAppRela.CmPrjName);
clsCheckSql.CheckSqlInjection4Field(objvCmProjectAppRelaEN.CmPrjId, convCmProjectAppRela.CmPrjId);
clsCheckSql.CheckSqlInjection4Field(objvCmProjectAppRelaEN.UpdUser, convCmProjectAppRela.UpdUser);
//检查外键字段长度
 objvCmProjectAppRelaEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--vCmProjectAppRela(vCmProjectAppRela),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objvCmProjectAppRelaEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsvCmProjectAppRelaEN objvCmProjectAppRelaEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objvCmProjectAppRelaEN.ApplicationTypeId);
 sbCondition.AppendFormat(" and CmPrjId = '{0}'", objvCmProjectAppRelaEN.CmPrjId);
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
 objSQL = clsvCmProjectAppRelaDA.GetSpecSQLObj();
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
 objSQL = clsvCmProjectAppRelaDA.GetSpecSQLObj();
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
 objSQL = clsvCmProjectAppRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCmProjectAppRelaEN._CurrTabName);
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
 objSQL = clsvCmProjectAppRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCmProjectAppRelaEN._CurrTabName, strCondition);
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
 objSQL = clsvCmProjectAppRelaDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}