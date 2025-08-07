
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCMProjectAppRelaDA
 表名:CMProjectAppRela(00050600)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:26:51
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
 /// CM项目应用关系(CMProjectAppRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsCMProjectAppRelaDA : clsCommBase4DA
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
 return clsCMProjectAppRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsCMProjectAppRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCMProjectAppRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsCMProjectAppRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsCMProjectAppRelaEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsCMProjectAppRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectAppRelaDA.GetSpecSQLObj();
strSQL = "Select * from CMProjectAppRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_CMProjectAppRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsCMProjectAppRelaDA: GetDataTable_CMProjectAppRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectAppRelaDA.GetSpecSQLObj();
strSQL = "Select * from CMProjectAppRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsCMProjectAppRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectAppRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsCMProjectAppRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectAppRelaDA.GetSpecSQLObj();
strSQL = "Select * from CMProjectAppRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsCMProjectAppRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectAppRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsCMProjectAppRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectAppRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CMProjectAppRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CMProjectAppRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsCMProjectAppRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectAppRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from CMProjectAppRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsCMProjectAppRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectAppRelaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} CMProjectAppRela.* " + 
$"from CMProjectAppRela " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and CMProjectAppRela.CMProjectAppRelaId not in " + 
$"(Select top {intTop_In} CMProjectAppRela.CMProjectAppRelaId from CMProjectAppRela " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CMProjectAppRela where {1} and CMProjectAppRelaId not in (Select top {2} CMProjectAppRelaId from CMProjectAppRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CMProjectAppRela where {1} and CMProjectAppRelaId not in (Select top {3} CMProjectAppRelaId from CMProjectAppRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsCMProjectAppRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectAppRelaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} CMProjectAppRela.* " + 
$"from CMProjectAppRela " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and CMProjectAppRela.CMProjectAppRelaId not in " + 
$"(Select top {intTop_In} CMProjectAppRela.CMProjectAppRelaId from CMProjectAppRela " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CMProjectAppRela where {1} and CMProjectAppRelaId not in (Select top {2} CMProjectAppRelaId from CMProjectAppRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CMProjectAppRela where {1} and CMProjectAppRelaId not in (Select top {3} CMProjectAppRelaId from CMProjectAppRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsCMProjectAppRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsCMProjectAppRelaDA:GetObjLst)", objException.Message));
}
List<clsCMProjectAppRelaEN> arrObjLst = new List<clsCMProjectAppRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectAppRelaDA.GetSpecSQLObj();
strSQL = "Select * from CMProjectAppRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMProjectAppRelaEN objCMProjectAppRelaEN = new clsCMProjectAppRelaEN();
try
{
objCMProjectAppRelaEN.CMProjectAppRelaId = TransNullToInt(objRow[conCMProjectAppRela.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objCMProjectAppRelaEN.CmPrjId = objRow[conCMProjectAppRela.CmPrjId].ToString().Trim(); //Cm工程Id
objCMProjectAppRelaEN.ApplicationTypeId = TransNullToInt(objRow[conCMProjectAppRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objCMProjectAppRelaEN.OrderNum = TransNullToInt(objRow[conCMProjectAppRela.OrderNum].ToString().Trim()); //序号
objCMProjectAppRelaEN.PrjId = objRow[conCMProjectAppRela.PrjId].ToString().Trim(); //工程Id
objCMProjectAppRelaEN.UpdDate = objRow[conCMProjectAppRela.UpdDate] == DBNull.Value ? null : objRow[conCMProjectAppRela.UpdDate].ToString().Trim(); //修改日期
objCMProjectAppRelaEN.UpdUser = objRow[conCMProjectAppRela.UpdUser] == DBNull.Value ? null : objRow[conCMProjectAppRela.UpdUser].ToString().Trim(); //修改者
objCMProjectAppRelaEN.Memo = objRow[conCMProjectAppRela.Memo] == DBNull.Value ? null : objRow[conCMProjectAppRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCMProjectAppRelaDA: GetObjLst)", objException.Message));
}
objCMProjectAppRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCMProjectAppRelaEN);
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
public List<clsCMProjectAppRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsCMProjectAppRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsCMProjectAppRelaEN> arrObjLst = new List<clsCMProjectAppRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectAppRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMProjectAppRelaEN objCMProjectAppRelaEN = new clsCMProjectAppRelaEN();
try
{
objCMProjectAppRelaEN.CMProjectAppRelaId = TransNullToInt(objRow[conCMProjectAppRela.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objCMProjectAppRelaEN.CmPrjId = objRow[conCMProjectAppRela.CmPrjId].ToString().Trim(); //Cm工程Id
objCMProjectAppRelaEN.ApplicationTypeId = TransNullToInt(objRow[conCMProjectAppRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objCMProjectAppRelaEN.OrderNum = TransNullToInt(objRow[conCMProjectAppRela.OrderNum].ToString().Trim()); //序号
objCMProjectAppRelaEN.PrjId = objRow[conCMProjectAppRela.PrjId].ToString().Trim(); //工程Id
objCMProjectAppRelaEN.UpdDate = objRow[conCMProjectAppRela.UpdDate] == DBNull.Value ? null : objRow[conCMProjectAppRela.UpdDate].ToString().Trim(); //修改日期
objCMProjectAppRelaEN.UpdUser = objRow[conCMProjectAppRela.UpdUser] == DBNull.Value ? null : objRow[conCMProjectAppRela.UpdUser].ToString().Trim(); //修改者
objCMProjectAppRelaEN.Memo = objRow[conCMProjectAppRela.Memo] == DBNull.Value ? null : objRow[conCMProjectAppRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCMProjectAppRelaDA: GetObjLst)", objException.Message));
}
objCMProjectAppRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCMProjectAppRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objCMProjectAppRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetCMProjectAppRela(ref clsCMProjectAppRelaEN objCMProjectAppRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectAppRelaDA.GetSpecSQLObj();
strSQL = "Select * from CMProjectAppRela where CMProjectAppRelaId = " + ""+ objCMProjectAppRelaEN.CMProjectAppRelaId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objCMProjectAppRelaEN.CMProjectAppRelaId = TransNullToInt(objDT.Rows[0][conCMProjectAppRela.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id(字段类型:bigint,字段长度:8,是否可空:False)
 objCMProjectAppRelaEN.CmPrjId = objDT.Rows[0][conCMProjectAppRela.CmPrjId].ToString().Trim(); //Cm工程Id(字段类型:char,字段长度:6,是否可空:False)
 objCMProjectAppRelaEN.ApplicationTypeId = TransNullToInt(objDT.Rows[0][conCMProjectAppRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objCMProjectAppRelaEN.OrderNum = TransNullToInt(objDT.Rows[0][conCMProjectAppRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objCMProjectAppRelaEN.PrjId = objDT.Rows[0][conCMProjectAppRela.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objCMProjectAppRelaEN.UpdDate = objDT.Rows[0][conCMProjectAppRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCMProjectAppRelaEN.UpdUser = objDT.Rows[0][conCMProjectAppRela.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objCMProjectAppRelaEN.Memo = objDT.Rows[0][conCMProjectAppRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsCMProjectAppRelaDA: GetCMProjectAppRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngCMProjectAppRelaId">表关键字</param>
 /// <returns>表对象</returns>
public clsCMProjectAppRelaEN GetObjByCMProjectAppRelaId(long lngCMProjectAppRelaId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectAppRelaDA.GetSpecSQLObj();
strSQL = "Select * from CMProjectAppRela where CMProjectAppRelaId = " + ""+ lngCMProjectAppRelaId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsCMProjectAppRelaEN objCMProjectAppRelaEN = new clsCMProjectAppRelaEN();
try
{
 objCMProjectAppRelaEN.CMProjectAppRelaId = Int32.Parse(objRow[conCMProjectAppRela.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id(字段类型:bigint,字段长度:8,是否可空:False)
 objCMProjectAppRelaEN.CmPrjId = objRow[conCMProjectAppRela.CmPrjId].ToString().Trim(); //Cm工程Id(字段类型:char,字段长度:6,是否可空:False)
 objCMProjectAppRelaEN.ApplicationTypeId = Int32.Parse(objRow[conCMProjectAppRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objCMProjectAppRelaEN.OrderNum = Int32.Parse(objRow[conCMProjectAppRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objCMProjectAppRelaEN.PrjId = objRow[conCMProjectAppRela.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objCMProjectAppRelaEN.UpdDate = objRow[conCMProjectAppRela.UpdDate] == DBNull.Value ? null : objRow[conCMProjectAppRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCMProjectAppRelaEN.UpdUser = objRow[conCMProjectAppRela.UpdUser] == DBNull.Value ? null : objRow[conCMProjectAppRela.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objCMProjectAppRelaEN.Memo = objRow[conCMProjectAppRela.Memo] == DBNull.Value ? null : objRow[conCMProjectAppRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsCMProjectAppRelaDA: GetObjByCMProjectAppRelaId)", objException.Message));
}
return objCMProjectAppRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsCMProjectAppRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsCMProjectAppRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectAppRelaDA.GetSpecSQLObj();
strSQL = "Select * from CMProjectAppRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsCMProjectAppRelaEN objCMProjectAppRelaEN = new clsCMProjectAppRelaEN()
{
CMProjectAppRelaId = TransNullToInt(objRow[conCMProjectAppRela.CMProjectAppRelaId].ToString().Trim()), //Cm工程应用关系Id
CmPrjId = objRow[conCMProjectAppRela.CmPrjId].ToString().Trim(), //Cm工程Id
ApplicationTypeId = TransNullToInt(objRow[conCMProjectAppRela.ApplicationTypeId].ToString().Trim()), //应用程序类型ID
OrderNum = TransNullToInt(objRow[conCMProjectAppRela.OrderNum].ToString().Trim()), //序号
PrjId = objRow[conCMProjectAppRela.PrjId].ToString().Trim(), //工程Id
UpdDate = objRow[conCMProjectAppRela.UpdDate] == DBNull.Value ? null : objRow[conCMProjectAppRela.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conCMProjectAppRela.UpdUser] == DBNull.Value ? null : objRow[conCMProjectAppRela.UpdUser].ToString().Trim(), //修改者
Memo = objRow[conCMProjectAppRela.Memo] == DBNull.Value ? null : objRow[conCMProjectAppRela.Memo].ToString().Trim() //说明
};
objCMProjectAppRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCMProjectAppRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsCMProjectAppRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsCMProjectAppRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCMProjectAppRelaEN objCMProjectAppRelaEN = new clsCMProjectAppRelaEN();
try
{
objCMProjectAppRelaEN.CMProjectAppRelaId = TransNullToInt(objRow[conCMProjectAppRela.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objCMProjectAppRelaEN.CmPrjId = objRow[conCMProjectAppRela.CmPrjId].ToString().Trim(); //Cm工程Id
objCMProjectAppRelaEN.ApplicationTypeId = TransNullToInt(objRow[conCMProjectAppRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objCMProjectAppRelaEN.OrderNum = TransNullToInt(objRow[conCMProjectAppRela.OrderNum].ToString().Trim()); //序号
objCMProjectAppRelaEN.PrjId = objRow[conCMProjectAppRela.PrjId].ToString().Trim(); //工程Id
objCMProjectAppRelaEN.UpdDate = objRow[conCMProjectAppRela.UpdDate] == DBNull.Value ? null : objRow[conCMProjectAppRela.UpdDate].ToString().Trim(); //修改日期
objCMProjectAppRelaEN.UpdUser = objRow[conCMProjectAppRela.UpdUser] == DBNull.Value ? null : objRow[conCMProjectAppRela.UpdUser].ToString().Trim(); //修改者
objCMProjectAppRelaEN.Memo = objRow[conCMProjectAppRela.Memo] == DBNull.Value ? null : objRow[conCMProjectAppRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsCMProjectAppRelaDA: GetObjByDataRowCMProjectAppRela)", objException.Message));
}
objCMProjectAppRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCMProjectAppRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsCMProjectAppRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCMProjectAppRelaEN objCMProjectAppRelaEN = new clsCMProjectAppRelaEN();
try
{
objCMProjectAppRelaEN.CMProjectAppRelaId = TransNullToInt(objRow[conCMProjectAppRela.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objCMProjectAppRelaEN.CmPrjId = objRow[conCMProjectAppRela.CmPrjId].ToString().Trim(); //Cm工程Id
objCMProjectAppRelaEN.ApplicationTypeId = TransNullToInt(objRow[conCMProjectAppRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objCMProjectAppRelaEN.OrderNum = TransNullToInt(objRow[conCMProjectAppRela.OrderNum].ToString().Trim()); //序号
objCMProjectAppRelaEN.PrjId = objRow[conCMProjectAppRela.PrjId].ToString().Trim(); //工程Id
objCMProjectAppRelaEN.UpdDate = objRow[conCMProjectAppRela.UpdDate] == DBNull.Value ? null : objRow[conCMProjectAppRela.UpdDate].ToString().Trim(); //修改日期
objCMProjectAppRelaEN.UpdUser = objRow[conCMProjectAppRela.UpdUser] == DBNull.Value ? null : objRow[conCMProjectAppRela.UpdUser].ToString().Trim(); //修改者
objCMProjectAppRelaEN.Memo = objRow[conCMProjectAppRela.Memo] == DBNull.Value ? null : objRow[conCMProjectAppRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsCMProjectAppRelaDA: GetObjByDataRow)", objException.Message));
}
objCMProjectAppRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCMProjectAppRelaEN;
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
objSQL = clsCMProjectAppRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCMProjectAppRelaEN._CurrTabName, conCMProjectAppRela.CMProjectAppRelaId, 8, "");
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
objSQL = clsCMProjectAppRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCMProjectAppRelaEN._CurrTabName, conCMProjectAppRela.CMProjectAppRelaId, 8, strPrefix);
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
 objSQL = clsCMProjectAppRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select CMProjectAppRelaId from CMProjectAppRela where " + strCondition;
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
 objSQL = clsCMProjectAppRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select CMProjectAppRelaId from CMProjectAppRela where " + strCondition;
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
 objSQL = clsCMProjectAppRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CMProjectAppRela", "CMProjectAppRelaId = " + ""+ lngCMProjectAppRelaId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsCMProjectAppRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectAppRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CMProjectAppRela", strCondition))
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
objSQL = clsCMProjectAppRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("CMProjectAppRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsCMProjectAppRelaEN objCMProjectAppRelaEN)
 {
 objCMProjectAppRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMProjectAppRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCMProjectAppRelaEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectAppRelaDA.GetSpecSQLObj();
strSQL = "Select * from CMProjectAppRela where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CMProjectAppRela");
objRow = objDS.Tables["CMProjectAppRela"].NewRow();
objRow[conCMProjectAppRela.CmPrjId] = objCMProjectAppRelaEN.CmPrjId; //Cm工程Id
objRow[conCMProjectAppRela.ApplicationTypeId] = objCMProjectAppRelaEN.ApplicationTypeId; //应用程序类型ID
objRow[conCMProjectAppRela.OrderNum] = objCMProjectAppRelaEN.OrderNum; //序号
objRow[conCMProjectAppRela.PrjId] = objCMProjectAppRelaEN.PrjId; //工程Id
 if (objCMProjectAppRelaEN.UpdDate !=  "")
 {
objRow[conCMProjectAppRela.UpdDate] = objCMProjectAppRelaEN.UpdDate; //修改日期
 }
 if (objCMProjectAppRelaEN.UpdUser !=  "")
 {
objRow[conCMProjectAppRela.UpdUser] = objCMProjectAppRelaEN.UpdUser; //修改者
 }
 if (objCMProjectAppRelaEN.Memo !=  "")
 {
objRow[conCMProjectAppRela.Memo] = objCMProjectAppRelaEN.Memo; //说明
 }
objDS.Tables[clsCMProjectAppRelaEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsCMProjectAppRelaEN._CurrTabName);
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
 /// <param name = "objCMProjectAppRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCMProjectAppRelaEN objCMProjectAppRelaEN)
{
 objCMProjectAppRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMProjectAppRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCMProjectAppRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objCMProjectAppRelaEN.CmPrjId !=  null)
 {
 arrFieldListForInsert.Add(conCMProjectAppRela.CmPrjId);
 var strCmPrjId = objCMProjectAppRelaEN.CmPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmPrjId + "'");
 }
 
 arrFieldListForInsert.Add(conCMProjectAppRela.ApplicationTypeId);
 arrValueListForInsert.Add(objCMProjectAppRelaEN.ApplicationTypeId.ToString());
 
 arrFieldListForInsert.Add(conCMProjectAppRela.OrderNum);
 arrValueListForInsert.Add(objCMProjectAppRelaEN.OrderNum.ToString());
 
 if (objCMProjectAppRelaEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conCMProjectAppRela.PrjId);
 var strPrjId = objCMProjectAppRelaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objCMProjectAppRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCMProjectAppRela.UpdDate);
 var strUpdDate = objCMProjectAppRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCMProjectAppRelaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCMProjectAppRela.UpdUser);
 var strUpdUser = objCMProjectAppRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objCMProjectAppRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCMProjectAppRela.Memo);
 var strMemo = objCMProjectAppRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CMProjectAppRela");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectAppRelaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objCMProjectAppRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCMProjectAppRelaEN objCMProjectAppRelaEN)
{
 objCMProjectAppRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMProjectAppRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCMProjectAppRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objCMProjectAppRelaEN.CmPrjId !=  null)
 {
 arrFieldListForInsert.Add(conCMProjectAppRela.CmPrjId);
 var strCmPrjId = objCMProjectAppRelaEN.CmPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmPrjId + "'");
 }
 
 arrFieldListForInsert.Add(conCMProjectAppRela.ApplicationTypeId);
 arrValueListForInsert.Add(objCMProjectAppRelaEN.ApplicationTypeId.ToString());
 
 arrFieldListForInsert.Add(conCMProjectAppRela.OrderNum);
 arrValueListForInsert.Add(objCMProjectAppRelaEN.OrderNum.ToString());
 
 if (objCMProjectAppRelaEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conCMProjectAppRela.PrjId);
 var strPrjId = objCMProjectAppRelaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objCMProjectAppRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCMProjectAppRela.UpdDate);
 var strUpdDate = objCMProjectAppRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCMProjectAppRelaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCMProjectAppRela.UpdUser);
 var strUpdUser = objCMProjectAppRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objCMProjectAppRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCMProjectAppRela.Memo);
 var strMemo = objCMProjectAppRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CMProjectAppRela");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectAppRelaDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objCMProjectAppRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCMProjectAppRelaEN objCMProjectAppRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objCMProjectAppRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMProjectAppRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCMProjectAppRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objCMProjectAppRelaEN.CmPrjId !=  null)
 {
 arrFieldListForInsert.Add(conCMProjectAppRela.CmPrjId);
 var strCmPrjId = objCMProjectAppRelaEN.CmPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmPrjId + "'");
 }
 
 arrFieldListForInsert.Add(conCMProjectAppRela.ApplicationTypeId);
 arrValueListForInsert.Add(objCMProjectAppRelaEN.ApplicationTypeId.ToString());
 
 arrFieldListForInsert.Add(conCMProjectAppRela.OrderNum);
 arrValueListForInsert.Add(objCMProjectAppRelaEN.OrderNum.ToString());
 
 if (objCMProjectAppRelaEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conCMProjectAppRela.PrjId);
 var strPrjId = objCMProjectAppRelaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objCMProjectAppRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCMProjectAppRela.UpdDate);
 var strUpdDate = objCMProjectAppRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCMProjectAppRelaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCMProjectAppRela.UpdUser);
 var strUpdUser = objCMProjectAppRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objCMProjectAppRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCMProjectAppRela.Memo);
 var strMemo = objCMProjectAppRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CMProjectAppRela");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectAppRelaDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objCMProjectAppRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCMProjectAppRelaEN objCMProjectAppRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objCMProjectAppRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMProjectAppRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCMProjectAppRelaEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objCMProjectAppRelaEN.CmPrjId !=  null)
 {
 arrFieldListForInsert.Add(conCMProjectAppRela.CmPrjId);
 var strCmPrjId = objCMProjectAppRelaEN.CmPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmPrjId + "'");
 }
 
 arrFieldListForInsert.Add(conCMProjectAppRela.ApplicationTypeId);
 arrValueListForInsert.Add(objCMProjectAppRelaEN.ApplicationTypeId.ToString());
 
 arrFieldListForInsert.Add(conCMProjectAppRela.OrderNum);
 arrValueListForInsert.Add(objCMProjectAppRelaEN.OrderNum.ToString());
 
 if (objCMProjectAppRelaEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conCMProjectAppRela.PrjId);
 var strPrjId = objCMProjectAppRelaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objCMProjectAppRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCMProjectAppRela.UpdDate);
 var strUpdDate = objCMProjectAppRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCMProjectAppRelaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCMProjectAppRela.UpdUser);
 var strUpdUser = objCMProjectAppRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objCMProjectAppRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCMProjectAppRela.Memo);
 var strMemo = objCMProjectAppRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CMProjectAppRela");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectAppRelaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewCMProjectAppRelas(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectAppRelaDA.GetSpecSQLObj();
strSQL = "Select * from CMProjectAppRela where CMProjectAppRelaId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CMProjectAppRela");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngCMProjectAppRelaId = TransNullToInt(oRow[conCMProjectAppRela.CMProjectAppRelaId].ToString().Trim());
if (IsExist(lngCMProjectAppRelaId))
{
 string strResult = "关键字变量值为:" + string.Format("CMProjectAppRelaId = {0}", lngCMProjectAppRelaId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsCMProjectAppRelaEN._CurrTabName ].NewRow();
objRow[conCMProjectAppRela.CmPrjId] = oRow[conCMProjectAppRela.CmPrjId].ToString().Trim(); //Cm工程Id
objRow[conCMProjectAppRela.ApplicationTypeId] = oRow[conCMProjectAppRela.ApplicationTypeId].ToString().Trim(); //应用程序类型ID
objRow[conCMProjectAppRela.OrderNum] = oRow[conCMProjectAppRela.OrderNum].ToString().Trim(); //序号
objRow[conCMProjectAppRela.PrjId] = oRow[conCMProjectAppRela.PrjId].ToString().Trim(); //工程Id
objRow[conCMProjectAppRela.UpdDate] = oRow[conCMProjectAppRela.UpdDate].ToString().Trim(); //修改日期
objRow[conCMProjectAppRela.UpdUser] = oRow[conCMProjectAppRela.UpdUser].ToString().Trim(); //修改者
objRow[conCMProjectAppRela.Memo] = oRow[conCMProjectAppRela.Memo].ToString().Trim(); //说明
 objDS.Tables[clsCMProjectAppRelaEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsCMProjectAppRelaEN._CurrTabName);
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
 /// <param name = "objCMProjectAppRelaEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsCMProjectAppRelaEN objCMProjectAppRelaEN)
{
 objCMProjectAppRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMProjectAppRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCMProjectAppRelaEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectAppRelaDA.GetSpecSQLObj();
strSQL = "Select * from CMProjectAppRela where CMProjectAppRelaId = " + ""+ objCMProjectAppRelaEN.CMProjectAppRelaId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsCMProjectAppRelaEN._CurrTabName);
if (objDS.Tables[clsCMProjectAppRelaEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:CMProjectAppRelaId = " + ""+ objCMProjectAppRelaEN.CMProjectAppRelaId+"");
return false;
}
objRow = objDS.Tables[clsCMProjectAppRelaEN._CurrTabName].Rows[0];
 if (objCMProjectAppRelaEN.IsUpdated(conCMProjectAppRela.CmPrjId))
 {
objRow[conCMProjectAppRela.CmPrjId] = objCMProjectAppRelaEN.CmPrjId; //Cm工程Id
 }
 if (objCMProjectAppRelaEN.IsUpdated(conCMProjectAppRela.ApplicationTypeId))
 {
objRow[conCMProjectAppRela.ApplicationTypeId] = objCMProjectAppRelaEN.ApplicationTypeId; //应用程序类型ID
 }
 if (objCMProjectAppRelaEN.IsUpdated(conCMProjectAppRela.OrderNum))
 {
objRow[conCMProjectAppRela.OrderNum] = objCMProjectAppRelaEN.OrderNum; //序号
 }
 if (objCMProjectAppRelaEN.IsUpdated(conCMProjectAppRela.PrjId))
 {
objRow[conCMProjectAppRela.PrjId] = objCMProjectAppRelaEN.PrjId; //工程Id
 }
 if (objCMProjectAppRelaEN.IsUpdated(conCMProjectAppRela.UpdDate))
 {
objRow[conCMProjectAppRela.UpdDate] = objCMProjectAppRelaEN.UpdDate; //修改日期
 }
 if (objCMProjectAppRelaEN.IsUpdated(conCMProjectAppRela.UpdUser))
 {
objRow[conCMProjectAppRela.UpdUser] = objCMProjectAppRelaEN.UpdUser; //修改者
 }
 if (objCMProjectAppRelaEN.IsUpdated(conCMProjectAppRela.Memo))
 {
objRow[conCMProjectAppRela.Memo] = objCMProjectAppRelaEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsCMProjectAppRelaEN._CurrTabName);
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
 /// <param name = "objCMProjectAppRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCMProjectAppRelaEN objCMProjectAppRelaEN)
{
 objCMProjectAppRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMProjectAppRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCMProjectAppRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectAppRelaDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update CMProjectAppRela Set ");
 
 if (objCMProjectAppRelaEN.IsUpdated(conCMProjectAppRela.CmPrjId))
 {
 if (objCMProjectAppRelaEN.CmPrjId !=  null)
 {
 var strCmPrjId = objCMProjectAppRelaEN.CmPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCmPrjId, conCMProjectAppRela.CmPrjId); //Cm工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMProjectAppRela.CmPrjId); //Cm工程Id
 }
 }
 
 if (objCMProjectAppRelaEN.IsUpdated(conCMProjectAppRela.ApplicationTypeId))
 {
 sbSQL.AppendFormat("{1} = {0},",objCMProjectAppRelaEN.ApplicationTypeId, conCMProjectAppRela.ApplicationTypeId); //应用程序类型ID
 }
 
 if (objCMProjectAppRelaEN.IsUpdated(conCMProjectAppRela.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objCMProjectAppRelaEN.OrderNum, conCMProjectAppRela.OrderNum); //序号
 }
 
 if (objCMProjectAppRelaEN.IsUpdated(conCMProjectAppRela.PrjId))
 {
 if (objCMProjectAppRelaEN.PrjId !=  null)
 {
 var strPrjId = objCMProjectAppRelaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conCMProjectAppRela.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMProjectAppRela.PrjId); //工程Id
 }
 }
 
 if (objCMProjectAppRelaEN.IsUpdated(conCMProjectAppRela.UpdDate))
 {
 if (objCMProjectAppRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objCMProjectAppRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conCMProjectAppRela.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMProjectAppRela.UpdDate); //修改日期
 }
 }
 
 if (objCMProjectAppRelaEN.IsUpdated(conCMProjectAppRela.UpdUser))
 {
 if (objCMProjectAppRelaEN.UpdUser !=  null)
 {
 var strUpdUser = objCMProjectAppRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conCMProjectAppRela.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMProjectAppRela.UpdUser); //修改者
 }
 }
 
 if (objCMProjectAppRelaEN.IsUpdated(conCMProjectAppRela.Memo))
 {
 if (objCMProjectAppRelaEN.Memo !=  null)
 {
 var strMemo = objCMProjectAppRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCMProjectAppRela.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMProjectAppRela.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where CMProjectAppRelaId = {0}", objCMProjectAppRelaEN.CMProjectAppRelaId); 
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
 /// <param name = "objCMProjectAppRelaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsCMProjectAppRelaEN objCMProjectAppRelaEN, string strCondition)
{
 objCMProjectAppRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMProjectAppRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCMProjectAppRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectAppRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CMProjectAppRela Set ");
 
 if (objCMProjectAppRelaEN.IsUpdated(conCMProjectAppRela.CmPrjId))
 {
 if (objCMProjectAppRelaEN.CmPrjId !=  null)
 {
 var strCmPrjId = objCMProjectAppRelaEN.CmPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CmPrjId = '{0}',", strCmPrjId); //Cm工程Id
 }
 else
 {
 sbSQL.Append(" CmPrjId = null,"); //Cm工程Id
 }
 }
 
 if (objCMProjectAppRelaEN.IsUpdated(conCMProjectAppRela.ApplicationTypeId))
 {
 sbSQL.AppendFormat(" ApplicationTypeId = {0},", objCMProjectAppRelaEN.ApplicationTypeId); //应用程序类型ID
 }
 
 if (objCMProjectAppRelaEN.IsUpdated(conCMProjectAppRela.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objCMProjectAppRelaEN.OrderNum); //序号
 }
 
 if (objCMProjectAppRelaEN.IsUpdated(conCMProjectAppRela.PrjId))
 {
 if (objCMProjectAppRelaEN.PrjId !=  null)
 {
 var strPrjId = objCMProjectAppRelaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objCMProjectAppRelaEN.IsUpdated(conCMProjectAppRela.UpdDate))
 {
 if (objCMProjectAppRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objCMProjectAppRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objCMProjectAppRelaEN.IsUpdated(conCMProjectAppRela.UpdUser))
 {
 if (objCMProjectAppRelaEN.UpdUser !=  null)
 {
 var strUpdUser = objCMProjectAppRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objCMProjectAppRelaEN.IsUpdated(conCMProjectAppRela.Memo))
 {
 if (objCMProjectAppRelaEN.Memo !=  null)
 {
 var strMemo = objCMProjectAppRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objCMProjectAppRelaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsCMProjectAppRelaEN objCMProjectAppRelaEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objCMProjectAppRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMProjectAppRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCMProjectAppRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectAppRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CMProjectAppRela Set ");
 
 if (objCMProjectAppRelaEN.IsUpdated(conCMProjectAppRela.CmPrjId))
 {
 if (objCMProjectAppRelaEN.CmPrjId !=  null)
 {
 var strCmPrjId = objCMProjectAppRelaEN.CmPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CmPrjId = '{0}',", strCmPrjId); //Cm工程Id
 }
 else
 {
 sbSQL.Append(" CmPrjId = null,"); //Cm工程Id
 }
 }
 
 if (objCMProjectAppRelaEN.IsUpdated(conCMProjectAppRela.ApplicationTypeId))
 {
 sbSQL.AppendFormat(" ApplicationTypeId = {0},", objCMProjectAppRelaEN.ApplicationTypeId); //应用程序类型ID
 }
 
 if (objCMProjectAppRelaEN.IsUpdated(conCMProjectAppRela.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objCMProjectAppRelaEN.OrderNum); //序号
 }
 
 if (objCMProjectAppRelaEN.IsUpdated(conCMProjectAppRela.PrjId))
 {
 if (objCMProjectAppRelaEN.PrjId !=  null)
 {
 var strPrjId = objCMProjectAppRelaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objCMProjectAppRelaEN.IsUpdated(conCMProjectAppRela.UpdDate))
 {
 if (objCMProjectAppRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objCMProjectAppRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objCMProjectAppRelaEN.IsUpdated(conCMProjectAppRela.UpdUser))
 {
 if (objCMProjectAppRelaEN.UpdUser !=  null)
 {
 var strUpdUser = objCMProjectAppRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objCMProjectAppRelaEN.IsUpdated(conCMProjectAppRela.Memo))
 {
 if (objCMProjectAppRelaEN.Memo !=  null)
 {
 var strMemo = objCMProjectAppRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objCMProjectAppRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCMProjectAppRelaEN objCMProjectAppRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objCMProjectAppRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMProjectAppRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCMProjectAppRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectAppRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CMProjectAppRela Set ");
 
 if (objCMProjectAppRelaEN.IsUpdated(conCMProjectAppRela.CmPrjId))
 {
 if (objCMProjectAppRelaEN.CmPrjId !=  null)
 {
 var strCmPrjId = objCMProjectAppRelaEN.CmPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCmPrjId, conCMProjectAppRela.CmPrjId); //Cm工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMProjectAppRela.CmPrjId); //Cm工程Id
 }
 }
 
 if (objCMProjectAppRelaEN.IsUpdated(conCMProjectAppRela.ApplicationTypeId))
 {
 sbSQL.AppendFormat("{1} = {0},",objCMProjectAppRelaEN.ApplicationTypeId, conCMProjectAppRela.ApplicationTypeId); //应用程序类型ID
 }
 
 if (objCMProjectAppRelaEN.IsUpdated(conCMProjectAppRela.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objCMProjectAppRelaEN.OrderNum, conCMProjectAppRela.OrderNum); //序号
 }
 
 if (objCMProjectAppRelaEN.IsUpdated(conCMProjectAppRela.PrjId))
 {
 if (objCMProjectAppRelaEN.PrjId !=  null)
 {
 var strPrjId = objCMProjectAppRelaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conCMProjectAppRela.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMProjectAppRela.PrjId); //工程Id
 }
 }
 
 if (objCMProjectAppRelaEN.IsUpdated(conCMProjectAppRela.UpdDate))
 {
 if (objCMProjectAppRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objCMProjectAppRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conCMProjectAppRela.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMProjectAppRela.UpdDate); //修改日期
 }
 }
 
 if (objCMProjectAppRelaEN.IsUpdated(conCMProjectAppRela.UpdUser))
 {
 if (objCMProjectAppRelaEN.UpdUser !=  null)
 {
 var strUpdUser = objCMProjectAppRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conCMProjectAppRela.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMProjectAppRela.UpdUser); //修改者
 }
 }
 
 if (objCMProjectAppRelaEN.IsUpdated(conCMProjectAppRela.Memo))
 {
 if (objCMProjectAppRelaEN.Memo !=  null)
 {
 var strMemo = objCMProjectAppRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCMProjectAppRela.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMProjectAppRela.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where CMProjectAppRelaId = {0}", objCMProjectAppRelaEN.CMProjectAppRelaId); 
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
 /// <param name = "lngCMProjectAppRelaId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngCMProjectAppRelaId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectAppRelaDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngCMProjectAppRelaId,
};
 objSQL.ExecSP("CMProjectAppRela_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngCMProjectAppRelaId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngCMProjectAppRelaId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectAppRelaDA.GetSpecSQLObj();
//删除CMProjectAppRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CMProjectAppRela where CMProjectAppRelaId = " + ""+ lngCMProjectAppRelaId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelCMProjectAppRela(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectAppRelaDA.GetSpecSQLObj();
string strSQL;
string strKeyList;
if (lstKey.Count  == 0) return 0;
strKeyList = "";
for (int i = 0; i<lstKey.Count; i++)
{
if (i == 0) strKeyList = strKeyList + "" + lstKey[i].ToString() + "";
else strKeyList +=  "," + "" + lstKey[i].ToString() + "";
}
strSQL = "";
//删除CMProjectAppRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CMProjectAppRela where CMProjectAppRelaId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngCMProjectAppRelaId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngCMProjectAppRelaId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectAppRelaDA.GetSpecSQLObj();
//删除CMProjectAppRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CMProjectAppRela where CMProjectAppRelaId = " + ""+ lngCMProjectAppRelaId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelCMProjectAppRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsCMProjectAppRelaDA: DelCMProjectAppRela)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectAppRelaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CMProjectAppRela where " + strCondition ;
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
public bool DelCMProjectAppRelaWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsCMProjectAppRelaDA: DelCMProjectAppRelaWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMProjectAppRelaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CMProjectAppRela where " + strCondition ;
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
 /// <param name = "objCMProjectAppRelaENS">源对象</param>
 /// <param name = "objCMProjectAppRelaENT">目标对象</param>
public void CopyTo(clsCMProjectAppRelaEN objCMProjectAppRelaENS, clsCMProjectAppRelaEN objCMProjectAppRelaENT)
{
objCMProjectAppRelaENT.CMProjectAppRelaId = objCMProjectAppRelaENS.CMProjectAppRelaId; //Cm工程应用关系Id
objCMProjectAppRelaENT.CmPrjId = objCMProjectAppRelaENS.CmPrjId; //Cm工程Id
objCMProjectAppRelaENT.ApplicationTypeId = objCMProjectAppRelaENS.ApplicationTypeId; //应用程序类型ID
objCMProjectAppRelaENT.OrderNum = objCMProjectAppRelaENS.OrderNum; //序号
objCMProjectAppRelaENT.PrjId = objCMProjectAppRelaENS.PrjId; //工程Id
objCMProjectAppRelaENT.UpdDate = objCMProjectAppRelaENS.UpdDate; //修改日期
objCMProjectAppRelaENT.UpdUser = objCMProjectAppRelaENS.UpdUser; //修改者
objCMProjectAppRelaENT.Memo = objCMProjectAppRelaENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsCMProjectAppRelaEN objCMProjectAppRelaEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objCMProjectAppRelaEN.CmPrjId, conCMProjectAppRela.CmPrjId);
clsCheckSql.CheckFieldNotNull(objCMProjectAppRelaEN.ApplicationTypeId, conCMProjectAppRela.ApplicationTypeId);
clsCheckSql.CheckFieldNotNull(objCMProjectAppRelaEN.OrderNum, conCMProjectAppRela.OrderNum);
clsCheckSql.CheckFieldNotNull(objCMProjectAppRelaEN.PrjId, conCMProjectAppRela.PrjId);
//检查字段长度
clsCheckSql.CheckFieldLen(objCMProjectAppRelaEN.CmPrjId, 6, conCMProjectAppRela.CmPrjId);
clsCheckSql.CheckFieldLen(objCMProjectAppRelaEN.PrjId, 4, conCMProjectAppRela.PrjId);
clsCheckSql.CheckFieldLen(objCMProjectAppRelaEN.UpdDate, 20, conCMProjectAppRela.UpdDate);
clsCheckSql.CheckFieldLen(objCMProjectAppRelaEN.UpdUser, 20, conCMProjectAppRela.UpdUser);
clsCheckSql.CheckFieldLen(objCMProjectAppRelaEN.Memo, 1000, conCMProjectAppRela.Memo);
//检查字段外键固定长度
 objCMProjectAppRelaEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsCMProjectAppRelaEN objCMProjectAppRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCMProjectAppRelaEN.CmPrjId, 6, conCMProjectAppRela.CmPrjId);
clsCheckSql.CheckFieldLen(objCMProjectAppRelaEN.PrjId, 4, conCMProjectAppRela.PrjId);
clsCheckSql.CheckFieldLen(objCMProjectAppRelaEN.UpdDate, 20, conCMProjectAppRela.UpdDate);
clsCheckSql.CheckFieldLen(objCMProjectAppRelaEN.UpdUser, 20, conCMProjectAppRela.UpdUser);
clsCheckSql.CheckFieldLen(objCMProjectAppRelaEN.Memo, 1000, conCMProjectAppRela.Memo);
//检查外键字段长度
 objCMProjectAppRelaEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsCMProjectAppRelaEN objCMProjectAppRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCMProjectAppRelaEN.CmPrjId, 6, conCMProjectAppRela.CmPrjId);
clsCheckSql.CheckFieldLen(objCMProjectAppRelaEN.PrjId, 4, conCMProjectAppRela.PrjId);
clsCheckSql.CheckFieldLen(objCMProjectAppRelaEN.UpdDate, 20, conCMProjectAppRela.UpdDate);
clsCheckSql.CheckFieldLen(objCMProjectAppRelaEN.UpdUser, 20, conCMProjectAppRela.UpdUser);
clsCheckSql.CheckFieldLen(objCMProjectAppRelaEN.Memo, 1000, conCMProjectAppRela.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objCMProjectAppRelaEN.CmPrjId, conCMProjectAppRela.CmPrjId);
clsCheckSql.CheckSqlInjection4Field(objCMProjectAppRelaEN.PrjId, conCMProjectAppRela.PrjId);
clsCheckSql.CheckSqlInjection4Field(objCMProjectAppRelaEN.UpdDate, conCMProjectAppRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objCMProjectAppRelaEN.UpdUser, conCMProjectAppRela.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objCMProjectAppRelaEN.Memo, conCMProjectAppRela.Memo);
//检查外键字段长度
 objCMProjectAppRelaEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--CMProjectAppRela(CM项目应用关系),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objCMProjectAppRelaEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsCMProjectAppRelaEN objCMProjectAppRelaEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CmPrjId = '{0}'", objCMProjectAppRelaEN.CmPrjId);
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objCMProjectAppRelaEN.ApplicationTypeId);
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
 objSQL = clsCMProjectAppRelaDA.GetSpecSQLObj();
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
 objSQL = clsCMProjectAppRelaDA.GetSpecSQLObj();
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
 objSQL = clsCMProjectAppRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCMProjectAppRelaEN._CurrTabName);
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
 objSQL = clsCMProjectAppRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCMProjectAppRelaEN._CurrTabName, strCondition);
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
 objSQL = clsCMProjectAppRelaDA.GetSpecSQLObj();
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
 objSQL = clsCMProjectAppRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}