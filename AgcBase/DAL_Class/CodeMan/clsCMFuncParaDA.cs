
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCMFuncParaDA
 表名:CMFuncPara(00050503)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:08:47
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
 /// CM函数参数(CMFuncPara)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsCMFuncParaDA : clsCommBase4DA
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
 return clsCMFuncParaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsCMFuncParaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCMFuncParaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsCMFuncParaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsCMFuncParaEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:CMFuncPara中,检查关键字,长度不正确!(clsCMFuncParaDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strCmFuncParaId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:CMFuncPara中,关键字不能为空 或 null!(clsCMFuncParaDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCmFuncParaId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsCMFuncParaDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsCMFuncParaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFuncParaDA.GetSpecSQLObj();
strSQL = "Select * from CMFuncPara where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_CMFuncPara(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsCMFuncParaDA: GetDataTable_CMFuncPara)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFuncParaDA.GetSpecSQLObj();
strSQL = "Select * from CMFuncPara where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsCMFuncParaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFuncParaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsCMFuncParaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFuncParaDA.GetSpecSQLObj();
strSQL = "Select * from CMFuncPara where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsCMFuncParaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFuncParaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsCMFuncParaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFuncParaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CMFuncPara where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CMFuncPara where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsCMFuncParaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFuncParaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from CMFuncPara where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsCMFuncParaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFuncParaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} CMFuncPara.* " + 
$"from CMFuncPara " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and CMFuncPara.CmFuncParaId not in " + 
$"(Select top {intTop_In} CMFuncPara.CmFuncParaId from CMFuncPara " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CMFuncPara where {1} and CmFuncParaId not in (Select top {2} CmFuncParaId from CMFuncPara where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CMFuncPara where {1} and CmFuncParaId not in (Select top {3} CmFuncParaId from CMFuncPara where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsCMFuncParaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFuncParaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} CMFuncPara.* " + 
$"from CMFuncPara " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and CMFuncPara.CmFuncParaId not in " + 
$"(Select top {intTop_In} CMFuncPara.CmFuncParaId from CMFuncPara " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CMFuncPara where {1} and CmFuncParaId not in (Select top {2} CmFuncParaId from CMFuncPara where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CMFuncPara where {1} and CmFuncParaId not in (Select top {3} CmFuncParaId from CMFuncPara where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsCMFuncParaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsCMFuncParaDA:GetObjLst)", objException.Message));
}
List<clsCMFuncParaEN> arrObjLst = new List<clsCMFuncParaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFuncParaDA.GetSpecSQLObj();
strSQL = "Select * from CMFuncPara where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMFuncParaEN objCMFuncParaEN = new clsCMFuncParaEN();
try
{
objCMFuncParaEN.CmFuncParaId = objRow[conCMFuncPara.CmFuncParaId].ToString().Trim(); //函数参数Id
objCMFuncParaEN.ParaName = objRow[conCMFuncPara.ParaName].ToString().Trim(); //参数名
objCMFuncParaEN.ParaComments = objRow[conCMFuncPara.ParaComments] == DBNull.Value ? null : objRow[conCMFuncPara.ParaComments].ToString().Trim(); //参数注释
objCMFuncParaEN.ParameterType = objRow[conCMFuncPara.ParameterType].ToString().Trim(); //参数类型
objCMFuncParaEN.DataTypeId = objRow[conCMFuncPara.DataTypeId].ToString().Trim(); //数据类型Id
objCMFuncParaEN.ParameterTypeFullName = objRow[conCMFuncPara.ParameterTypeFullName] == DBNull.Value ? null : objRow[conCMFuncPara.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objCMFuncParaEN.IsByRef = TransNullToBool(objRow[conCMFuncPara.IsByRef].ToString().Trim()); //是否引用型参数
objCMFuncParaEN.ParaCnName = objRow[conCMFuncPara.ParaCnName].ToString().Trim(); //参数中文名
objCMFuncParaEN.IsKnownType = TransNullToBool(objRow[conCMFuncPara.IsKnownType].ToString().Trim()); //是否已知类型
objCMFuncParaEN.PrjId = objRow[conCMFuncPara.PrjId].ToString().Trim(); //工程Id
objCMFuncParaEN.UpdDate = objRow[conCMFuncPara.UpdDate] == DBNull.Value ? null : objRow[conCMFuncPara.UpdDate].ToString().Trim(); //修改日期
objCMFuncParaEN.UpdUser = objRow[conCMFuncPara.UpdUser] == DBNull.Value ? null : objRow[conCMFuncPara.UpdUser].ToString().Trim(); //修改者
objCMFuncParaEN.Memo = objRow[conCMFuncPara.Memo] == DBNull.Value ? null : objRow[conCMFuncPara.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCMFuncParaDA: GetObjLst)", objException.Message));
}
objCMFuncParaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCMFuncParaEN);
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
public List<clsCMFuncParaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsCMFuncParaDA:GetObjLstByTabName)", objException.Message));
}
List<clsCMFuncParaEN> arrObjLst = new List<clsCMFuncParaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFuncParaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMFuncParaEN objCMFuncParaEN = new clsCMFuncParaEN();
try
{
objCMFuncParaEN.CmFuncParaId = objRow[conCMFuncPara.CmFuncParaId].ToString().Trim(); //函数参数Id
objCMFuncParaEN.ParaName = objRow[conCMFuncPara.ParaName].ToString().Trim(); //参数名
objCMFuncParaEN.ParaComments = objRow[conCMFuncPara.ParaComments] == DBNull.Value ? null : objRow[conCMFuncPara.ParaComments].ToString().Trim(); //参数注释
objCMFuncParaEN.ParameterType = objRow[conCMFuncPara.ParameterType].ToString().Trim(); //参数类型
objCMFuncParaEN.DataTypeId = objRow[conCMFuncPara.DataTypeId].ToString().Trim(); //数据类型Id
objCMFuncParaEN.ParameterTypeFullName = objRow[conCMFuncPara.ParameterTypeFullName] == DBNull.Value ? null : objRow[conCMFuncPara.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objCMFuncParaEN.IsByRef = TransNullToBool(objRow[conCMFuncPara.IsByRef].ToString().Trim()); //是否引用型参数
objCMFuncParaEN.ParaCnName = objRow[conCMFuncPara.ParaCnName].ToString().Trim(); //参数中文名
objCMFuncParaEN.IsKnownType = TransNullToBool(objRow[conCMFuncPara.IsKnownType].ToString().Trim()); //是否已知类型
objCMFuncParaEN.PrjId = objRow[conCMFuncPara.PrjId].ToString().Trim(); //工程Id
objCMFuncParaEN.UpdDate = objRow[conCMFuncPara.UpdDate] == DBNull.Value ? null : objRow[conCMFuncPara.UpdDate].ToString().Trim(); //修改日期
objCMFuncParaEN.UpdUser = objRow[conCMFuncPara.UpdUser] == DBNull.Value ? null : objRow[conCMFuncPara.UpdUser].ToString().Trim(); //修改者
objCMFuncParaEN.Memo = objRow[conCMFuncPara.Memo] == DBNull.Value ? null : objRow[conCMFuncPara.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCMFuncParaDA: GetObjLst)", objException.Message));
}
objCMFuncParaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCMFuncParaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objCMFuncParaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetCMFuncPara(ref clsCMFuncParaEN objCMFuncParaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFuncParaDA.GetSpecSQLObj();
strSQL = "Select * from CMFuncPara where CmFuncParaId = " + "'"+ objCMFuncParaEN.CmFuncParaId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objCMFuncParaEN.CmFuncParaId = objDT.Rows[0][conCMFuncPara.CmFuncParaId].ToString().Trim(); //函数参数Id(字段类型:char,字段长度:8,是否可空:False)
 objCMFuncParaEN.ParaName = objDT.Rows[0][conCMFuncPara.ParaName].ToString().Trim(); //参数名(字段类型:varchar,字段长度:50,是否可空:False)
 objCMFuncParaEN.ParaComments = objDT.Rows[0][conCMFuncPara.ParaComments].ToString().Trim(); //参数注释(字段类型:varchar,字段长度:500,是否可空:True)
 objCMFuncParaEN.ParameterType = objDT.Rows[0][conCMFuncPara.ParameterType].ToString().Trim(); //参数类型(字段类型:varchar,字段长度:100,是否可空:True)
 objCMFuncParaEN.DataTypeId = objDT.Rows[0][conCMFuncPara.DataTypeId].ToString().Trim(); //数据类型Id(字段类型:char,字段长度:2,是否可空:False)
 objCMFuncParaEN.ParameterTypeFullName = objDT.Rows[0][conCMFuncPara.ParameterTypeFullName].ToString().Trim(); //参数类型全名(字段类型:varchar,字段长度:500,是否可空:True)
 objCMFuncParaEN.IsByRef = TransNullToBool(objDT.Rows[0][conCMFuncPara.IsByRef].ToString().Trim()); //是否引用型参数(字段类型:bit,字段长度:1,是否可空:True)
 objCMFuncParaEN.ParaCnName = objDT.Rows[0][conCMFuncPara.ParaCnName].ToString().Trim(); //参数中文名(字段类型:varchar,字段长度:50,是否可空:False)
 objCMFuncParaEN.IsKnownType = TransNullToBool(objDT.Rows[0][conCMFuncPara.IsKnownType].ToString().Trim()); //是否已知类型(字段类型:bit,字段长度:1,是否可空:True)
 objCMFuncParaEN.PrjId = objDT.Rows[0][conCMFuncPara.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objCMFuncParaEN.UpdDate = objDT.Rows[0][conCMFuncPara.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCMFuncParaEN.UpdUser = objDT.Rows[0][conCMFuncPara.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objCMFuncParaEN.Memo = objDT.Rows[0][conCMFuncPara.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsCMFuncParaDA: GetCMFuncPara)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCmFuncParaId">表关键字</param>
 /// <returns>表对象</returns>
public clsCMFuncParaEN GetObjByCmFuncParaId(string strCmFuncParaId)
{
CheckPrimaryKey(strCmFuncParaId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFuncParaDA.GetSpecSQLObj();
strSQL = "Select * from CMFuncPara where CmFuncParaId = " + "'"+ strCmFuncParaId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsCMFuncParaEN objCMFuncParaEN = new clsCMFuncParaEN();
try
{
 objCMFuncParaEN.CmFuncParaId = objRow[conCMFuncPara.CmFuncParaId].ToString().Trim(); //函数参数Id(字段类型:char,字段长度:8,是否可空:False)
 objCMFuncParaEN.ParaName = objRow[conCMFuncPara.ParaName].ToString().Trim(); //参数名(字段类型:varchar,字段长度:50,是否可空:False)
 objCMFuncParaEN.ParaComments = objRow[conCMFuncPara.ParaComments] == DBNull.Value ? null : objRow[conCMFuncPara.ParaComments].ToString().Trim(); //参数注释(字段类型:varchar,字段长度:500,是否可空:True)
 objCMFuncParaEN.ParameterType = objRow[conCMFuncPara.ParameterType].ToString().Trim(); //参数类型(字段类型:varchar,字段长度:100,是否可空:True)
 objCMFuncParaEN.DataTypeId = objRow[conCMFuncPara.DataTypeId].ToString().Trim(); //数据类型Id(字段类型:char,字段长度:2,是否可空:False)
 objCMFuncParaEN.ParameterTypeFullName = objRow[conCMFuncPara.ParameterTypeFullName] == DBNull.Value ? null : objRow[conCMFuncPara.ParameterTypeFullName].ToString().Trim(); //参数类型全名(字段类型:varchar,字段长度:500,是否可空:True)
 objCMFuncParaEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[conCMFuncPara.IsByRef].ToString().Trim()); //是否引用型参数(字段类型:bit,字段长度:1,是否可空:True)
 objCMFuncParaEN.ParaCnName = objRow[conCMFuncPara.ParaCnName].ToString().Trim(); //参数中文名(字段类型:varchar,字段长度:50,是否可空:False)
 objCMFuncParaEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[conCMFuncPara.IsKnownType].ToString().Trim()); //是否已知类型(字段类型:bit,字段长度:1,是否可空:True)
 objCMFuncParaEN.PrjId = objRow[conCMFuncPara.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objCMFuncParaEN.UpdDate = objRow[conCMFuncPara.UpdDate] == DBNull.Value ? null : objRow[conCMFuncPara.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCMFuncParaEN.UpdUser = objRow[conCMFuncPara.UpdUser] == DBNull.Value ? null : objRow[conCMFuncPara.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objCMFuncParaEN.Memo = objRow[conCMFuncPara.Memo] == DBNull.Value ? null : objRow[conCMFuncPara.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsCMFuncParaDA: GetObjByCmFuncParaId)", objException.Message));
}
return objCMFuncParaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsCMFuncParaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsCMFuncParaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFuncParaDA.GetSpecSQLObj();
strSQL = "Select * from CMFuncPara where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsCMFuncParaEN objCMFuncParaEN = new clsCMFuncParaEN()
{
CmFuncParaId = objRow[conCMFuncPara.CmFuncParaId].ToString().Trim(), //函数参数Id
ParaName = objRow[conCMFuncPara.ParaName].ToString().Trim(), //参数名
ParaComments = objRow[conCMFuncPara.ParaComments] == DBNull.Value ? null : objRow[conCMFuncPara.ParaComments].ToString().Trim(), //参数注释
ParameterType = objRow[conCMFuncPara.ParameterType].ToString().Trim(), //参数类型
DataTypeId = objRow[conCMFuncPara.DataTypeId].ToString().Trim(), //数据类型Id
ParameterTypeFullName = objRow[conCMFuncPara.ParameterTypeFullName] == DBNull.Value ? null : objRow[conCMFuncPara.ParameterTypeFullName].ToString().Trim(), //参数类型全名
IsByRef = TransNullToBool(objRow[conCMFuncPara.IsByRef].ToString().Trim()), //是否引用型参数
ParaCnName = objRow[conCMFuncPara.ParaCnName].ToString().Trim(), //参数中文名
IsKnownType = TransNullToBool(objRow[conCMFuncPara.IsKnownType].ToString().Trim()), //是否已知类型
PrjId = objRow[conCMFuncPara.PrjId].ToString().Trim(), //工程Id
UpdDate = objRow[conCMFuncPara.UpdDate] == DBNull.Value ? null : objRow[conCMFuncPara.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conCMFuncPara.UpdUser] == DBNull.Value ? null : objRow[conCMFuncPara.UpdUser].ToString().Trim(), //修改者
Memo = objRow[conCMFuncPara.Memo] == DBNull.Value ? null : objRow[conCMFuncPara.Memo].ToString().Trim() //说明
};
objCMFuncParaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCMFuncParaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsCMFuncParaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsCMFuncParaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCMFuncParaEN objCMFuncParaEN = new clsCMFuncParaEN();
try
{
objCMFuncParaEN.CmFuncParaId = objRow[conCMFuncPara.CmFuncParaId].ToString().Trim(); //函数参数Id
objCMFuncParaEN.ParaName = objRow[conCMFuncPara.ParaName].ToString().Trim(); //参数名
objCMFuncParaEN.ParaComments = objRow[conCMFuncPara.ParaComments] == DBNull.Value ? null : objRow[conCMFuncPara.ParaComments].ToString().Trim(); //参数注释
objCMFuncParaEN.ParameterType = objRow[conCMFuncPara.ParameterType].ToString().Trim(); //参数类型
objCMFuncParaEN.DataTypeId = objRow[conCMFuncPara.DataTypeId].ToString().Trim(); //数据类型Id
objCMFuncParaEN.ParameterTypeFullName = objRow[conCMFuncPara.ParameterTypeFullName] == DBNull.Value ? null : objRow[conCMFuncPara.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objCMFuncParaEN.IsByRef = TransNullToBool(objRow[conCMFuncPara.IsByRef].ToString().Trim()); //是否引用型参数
objCMFuncParaEN.ParaCnName = objRow[conCMFuncPara.ParaCnName].ToString().Trim(); //参数中文名
objCMFuncParaEN.IsKnownType = TransNullToBool(objRow[conCMFuncPara.IsKnownType].ToString().Trim()); //是否已知类型
objCMFuncParaEN.PrjId = objRow[conCMFuncPara.PrjId].ToString().Trim(); //工程Id
objCMFuncParaEN.UpdDate = objRow[conCMFuncPara.UpdDate] == DBNull.Value ? null : objRow[conCMFuncPara.UpdDate].ToString().Trim(); //修改日期
objCMFuncParaEN.UpdUser = objRow[conCMFuncPara.UpdUser] == DBNull.Value ? null : objRow[conCMFuncPara.UpdUser].ToString().Trim(); //修改者
objCMFuncParaEN.Memo = objRow[conCMFuncPara.Memo] == DBNull.Value ? null : objRow[conCMFuncPara.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsCMFuncParaDA: GetObjByDataRowCMFuncPara)", objException.Message));
}
objCMFuncParaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCMFuncParaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsCMFuncParaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCMFuncParaEN objCMFuncParaEN = new clsCMFuncParaEN();
try
{
objCMFuncParaEN.CmFuncParaId = objRow[conCMFuncPara.CmFuncParaId].ToString().Trim(); //函数参数Id
objCMFuncParaEN.ParaName = objRow[conCMFuncPara.ParaName].ToString().Trim(); //参数名
objCMFuncParaEN.ParaComments = objRow[conCMFuncPara.ParaComments] == DBNull.Value ? null : objRow[conCMFuncPara.ParaComments].ToString().Trim(); //参数注释
objCMFuncParaEN.ParameterType = objRow[conCMFuncPara.ParameterType].ToString().Trim(); //参数类型
objCMFuncParaEN.DataTypeId = objRow[conCMFuncPara.DataTypeId].ToString().Trim(); //数据类型Id
objCMFuncParaEN.ParameterTypeFullName = objRow[conCMFuncPara.ParameterTypeFullName] == DBNull.Value ? null : objRow[conCMFuncPara.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objCMFuncParaEN.IsByRef = TransNullToBool(objRow[conCMFuncPara.IsByRef].ToString().Trim()); //是否引用型参数
objCMFuncParaEN.ParaCnName = objRow[conCMFuncPara.ParaCnName].ToString().Trim(); //参数中文名
objCMFuncParaEN.IsKnownType = TransNullToBool(objRow[conCMFuncPara.IsKnownType].ToString().Trim()); //是否已知类型
objCMFuncParaEN.PrjId = objRow[conCMFuncPara.PrjId].ToString().Trim(); //工程Id
objCMFuncParaEN.UpdDate = objRow[conCMFuncPara.UpdDate] == DBNull.Value ? null : objRow[conCMFuncPara.UpdDate].ToString().Trim(); //修改日期
objCMFuncParaEN.UpdUser = objRow[conCMFuncPara.UpdUser] == DBNull.Value ? null : objRow[conCMFuncPara.UpdUser].ToString().Trim(); //修改者
objCMFuncParaEN.Memo = objRow[conCMFuncPara.Memo] == DBNull.Value ? null : objRow[conCMFuncPara.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsCMFuncParaDA: GetObjByDataRow)", objException.Message));
}
objCMFuncParaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCMFuncParaEN;
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
objSQL = clsCMFuncParaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCMFuncParaEN._CurrTabName, conCMFuncPara.CmFuncParaId, 8, "");
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
objSQL = clsCMFuncParaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCMFuncParaEN._CurrTabName, conCMFuncPara.CmFuncParaId, 8, strPrefix);
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
 objSQL = clsCMFuncParaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select CmFuncParaId from CMFuncPara where " + strCondition;
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
 objSQL = clsCMFuncParaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select CmFuncParaId from CMFuncPara where " + strCondition;
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
 objSQL = clsCMFuncParaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CMFuncPara", "CmFuncParaId = " + "'"+ strCmFuncParaId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsCMFuncParaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFuncParaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CMFuncPara", strCondition))
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
objSQL = clsCMFuncParaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("CMFuncPara");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsCMFuncParaEN objCMFuncParaEN)
 {
 objCMFuncParaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMFuncParaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCMFuncParaEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFuncParaDA.GetSpecSQLObj();
strSQL = "Select * from CMFuncPara where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CMFuncPara");
objRow = objDS.Tables["CMFuncPara"].NewRow();
objRow[conCMFuncPara.CmFuncParaId] = objCMFuncParaEN.CmFuncParaId; //函数参数Id
objRow[conCMFuncPara.ParaName] = objCMFuncParaEN.ParaName; //参数名
 if (objCMFuncParaEN.ParaComments !=  "")
 {
objRow[conCMFuncPara.ParaComments] = objCMFuncParaEN.ParaComments; //参数注释
 }
objRow[conCMFuncPara.ParameterType] = objCMFuncParaEN.ParameterType; //参数类型
objRow[conCMFuncPara.DataTypeId] = objCMFuncParaEN.DataTypeId; //数据类型Id
 if (objCMFuncParaEN.ParameterTypeFullName !=  "")
 {
objRow[conCMFuncPara.ParameterTypeFullName] = objCMFuncParaEN.ParameterTypeFullName; //参数类型全名
 }
objRow[conCMFuncPara.IsByRef] = objCMFuncParaEN.IsByRef; //是否引用型参数
objRow[conCMFuncPara.ParaCnName] = objCMFuncParaEN.ParaCnName; //参数中文名
objRow[conCMFuncPara.IsKnownType] = objCMFuncParaEN.IsKnownType; //是否已知类型
objRow[conCMFuncPara.PrjId] = objCMFuncParaEN.PrjId; //工程Id
 if (objCMFuncParaEN.UpdDate !=  "")
 {
objRow[conCMFuncPara.UpdDate] = objCMFuncParaEN.UpdDate; //修改日期
 }
 if (objCMFuncParaEN.UpdUser !=  "")
 {
objRow[conCMFuncPara.UpdUser] = objCMFuncParaEN.UpdUser; //修改者
 }
 if (objCMFuncParaEN.Memo !=  "")
 {
objRow[conCMFuncPara.Memo] = objCMFuncParaEN.Memo; //说明
 }
objDS.Tables[clsCMFuncParaEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsCMFuncParaEN._CurrTabName);
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
 /// <param name = "objCMFuncParaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCMFuncParaEN objCMFuncParaEN)
{
 objCMFuncParaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMFuncParaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCMFuncParaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCMFuncParaEN.CmFuncParaId !=  null)
 {
 arrFieldListForInsert.Add(conCMFuncPara.CmFuncParaId);
 var strCmFuncParaId = objCMFuncParaEN.CmFuncParaId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmFuncParaId + "'");
 }
 
 if (objCMFuncParaEN.ParaName !=  null)
 {
 arrFieldListForInsert.Add(conCMFuncPara.ParaName);
 var strParaName = objCMFuncParaEN.ParaName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParaName + "'");
 }
 
 if (objCMFuncParaEN.ParaComments !=  null)
 {
 arrFieldListForInsert.Add(conCMFuncPara.ParaComments);
 var strParaComments = objCMFuncParaEN.ParaComments.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParaComments + "'");
 }
 
 if (objCMFuncParaEN.ParameterType !=  null)
 {
 arrFieldListForInsert.Add(conCMFuncPara.ParameterType);
 var strParameterType = objCMFuncParaEN.ParameterType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParameterType + "'");
 }
 
 if (objCMFuncParaEN.DataTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCMFuncPara.DataTypeId);
 var strDataTypeId = objCMFuncParaEN.DataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataTypeId + "'");
 }
 
 if (objCMFuncParaEN.ParameterTypeFullName !=  null)
 {
 arrFieldListForInsert.Add(conCMFuncPara.ParameterTypeFullName);
 var strParameterTypeFullName = objCMFuncParaEN.ParameterTypeFullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParameterTypeFullName + "'");
 }
 
 arrFieldListForInsert.Add(conCMFuncPara.IsByRef);
 arrValueListForInsert.Add("'" + (objCMFuncParaEN.IsByRef  ==  false ? "0" : "1") + "'");
 
 if (objCMFuncParaEN.ParaCnName !=  null)
 {
 arrFieldListForInsert.Add(conCMFuncPara.ParaCnName);
 var strParaCnName = objCMFuncParaEN.ParaCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParaCnName + "'");
 }
 
 arrFieldListForInsert.Add(conCMFuncPara.IsKnownType);
 arrValueListForInsert.Add("'" + (objCMFuncParaEN.IsKnownType  ==  false ? "0" : "1") + "'");
 
 if (objCMFuncParaEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conCMFuncPara.PrjId);
 var strPrjId = objCMFuncParaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objCMFuncParaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCMFuncPara.UpdDate);
 var strUpdDate = objCMFuncParaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCMFuncParaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCMFuncPara.UpdUser);
 var strUpdUser = objCMFuncParaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objCMFuncParaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCMFuncPara.Memo);
 var strMemo = objCMFuncParaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CMFuncPara");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFuncParaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objCMFuncParaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCMFuncParaEN objCMFuncParaEN)
{
 objCMFuncParaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMFuncParaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCMFuncParaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCMFuncParaEN.CmFuncParaId !=  null)
 {
 arrFieldListForInsert.Add(conCMFuncPara.CmFuncParaId);
 var strCmFuncParaId = objCMFuncParaEN.CmFuncParaId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmFuncParaId + "'");
 }
 
 if (objCMFuncParaEN.ParaName !=  null)
 {
 arrFieldListForInsert.Add(conCMFuncPara.ParaName);
 var strParaName = objCMFuncParaEN.ParaName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParaName + "'");
 }
 
 if (objCMFuncParaEN.ParaComments !=  null)
 {
 arrFieldListForInsert.Add(conCMFuncPara.ParaComments);
 var strParaComments = objCMFuncParaEN.ParaComments.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParaComments + "'");
 }
 
 if (objCMFuncParaEN.ParameterType !=  null)
 {
 arrFieldListForInsert.Add(conCMFuncPara.ParameterType);
 var strParameterType = objCMFuncParaEN.ParameterType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParameterType + "'");
 }
 
 if (objCMFuncParaEN.DataTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCMFuncPara.DataTypeId);
 var strDataTypeId = objCMFuncParaEN.DataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataTypeId + "'");
 }
 
 if (objCMFuncParaEN.ParameterTypeFullName !=  null)
 {
 arrFieldListForInsert.Add(conCMFuncPara.ParameterTypeFullName);
 var strParameterTypeFullName = objCMFuncParaEN.ParameterTypeFullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParameterTypeFullName + "'");
 }
 
 arrFieldListForInsert.Add(conCMFuncPara.IsByRef);
 arrValueListForInsert.Add("'" + (objCMFuncParaEN.IsByRef  ==  false ? "0" : "1") + "'");
 
 if (objCMFuncParaEN.ParaCnName !=  null)
 {
 arrFieldListForInsert.Add(conCMFuncPara.ParaCnName);
 var strParaCnName = objCMFuncParaEN.ParaCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParaCnName + "'");
 }
 
 arrFieldListForInsert.Add(conCMFuncPara.IsKnownType);
 arrValueListForInsert.Add("'" + (objCMFuncParaEN.IsKnownType  ==  false ? "0" : "1") + "'");
 
 if (objCMFuncParaEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conCMFuncPara.PrjId);
 var strPrjId = objCMFuncParaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objCMFuncParaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCMFuncPara.UpdDate);
 var strUpdDate = objCMFuncParaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCMFuncParaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCMFuncPara.UpdUser);
 var strUpdUser = objCMFuncParaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objCMFuncParaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCMFuncPara.Memo);
 var strMemo = objCMFuncParaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CMFuncPara");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFuncParaDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objCMFuncParaEN.CmFuncParaId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objCMFuncParaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCMFuncParaEN objCMFuncParaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objCMFuncParaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMFuncParaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCMFuncParaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCMFuncParaEN.CmFuncParaId !=  null)
 {
 arrFieldListForInsert.Add(conCMFuncPara.CmFuncParaId);
 var strCmFuncParaId = objCMFuncParaEN.CmFuncParaId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmFuncParaId + "'");
 }
 
 if (objCMFuncParaEN.ParaName !=  null)
 {
 arrFieldListForInsert.Add(conCMFuncPara.ParaName);
 var strParaName = objCMFuncParaEN.ParaName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParaName + "'");
 }
 
 if (objCMFuncParaEN.ParaComments !=  null)
 {
 arrFieldListForInsert.Add(conCMFuncPara.ParaComments);
 var strParaComments = objCMFuncParaEN.ParaComments.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParaComments + "'");
 }
 
 if (objCMFuncParaEN.ParameterType !=  null)
 {
 arrFieldListForInsert.Add(conCMFuncPara.ParameterType);
 var strParameterType = objCMFuncParaEN.ParameterType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParameterType + "'");
 }
 
 if (objCMFuncParaEN.DataTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCMFuncPara.DataTypeId);
 var strDataTypeId = objCMFuncParaEN.DataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataTypeId + "'");
 }
 
 if (objCMFuncParaEN.ParameterTypeFullName !=  null)
 {
 arrFieldListForInsert.Add(conCMFuncPara.ParameterTypeFullName);
 var strParameterTypeFullName = objCMFuncParaEN.ParameterTypeFullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParameterTypeFullName + "'");
 }
 
 arrFieldListForInsert.Add(conCMFuncPara.IsByRef);
 arrValueListForInsert.Add("'" + (objCMFuncParaEN.IsByRef  ==  false ? "0" : "1") + "'");
 
 if (objCMFuncParaEN.ParaCnName !=  null)
 {
 arrFieldListForInsert.Add(conCMFuncPara.ParaCnName);
 var strParaCnName = objCMFuncParaEN.ParaCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParaCnName + "'");
 }
 
 arrFieldListForInsert.Add(conCMFuncPara.IsKnownType);
 arrValueListForInsert.Add("'" + (objCMFuncParaEN.IsKnownType  ==  false ? "0" : "1") + "'");
 
 if (objCMFuncParaEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conCMFuncPara.PrjId);
 var strPrjId = objCMFuncParaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objCMFuncParaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCMFuncPara.UpdDate);
 var strUpdDate = objCMFuncParaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCMFuncParaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCMFuncPara.UpdUser);
 var strUpdUser = objCMFuncParaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objCMFuncParaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCMFuncPara.Memo);
 var strMemo = objCMFuncParaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CMFuncPara");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFuncParaDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objCMFuncParaEN.CmFuncParaId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objCMFuncParaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCMFuncParaEN objCMFuncParaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objCMFuncParaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMFuncParaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCMFuncParaEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCMFuncParaEN.CmFuncParaId !=  null)
 {
 arrFieldListForInsert.Add(conCMFuncPara.CmFuncParaId);
 var strCmFuncParaId = objCMFuncParaEN.CmFuncParaId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmFuncParaId + "'");
 }
 
 if (objCMFuncParaEN.ParaName !=  null)
 {
 arrFieldListForInsert.Add(conCMFuncPara.ParaName);
 var strParaName = objCMFuncParaEN.ParaName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParaName + "'");
 }
 
 if (objCMFuncParaEN.ParaComments !=  null)
 {
 arrFieldListForInsert.Add(conCMFuncPara.ParaComments);
 var strParaComments = objCMFuncParaEN.ParaComments.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParaComments + "'");
 }
 
 if (objCMFuncParaEN.ParameterType !=  null)
 {
 arrFieldListForInsert.Add(conCMFuncPara.ParameterType);
 var strParameterType = objCMFuncParaEN.ParameterType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParameterType + "'");
 }
 
 if (objCMFuncParaEN.DataTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCMFuncPara.DataTypeId);
 var strDataTypeId = objCMFuncParaEN.DataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataTypeId + "'");
 }
 
 if (objCMFuncParaEN.ParameterTypeFullName !=  null)
 {
 arrFieldListForInsert.Add(conCMFuncPara.ParameterTypeFullName);
 var strParameterTypeFullName = objCMFuncParaEN.ParameterTypeFullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParameterTypeFullName + "'");
 }
 
 arrFieldListForInsert.Add(conCMFuncPara.IsByRef);
 arrValueListForInsert.Add("'" + (objCMFuncParaEN.IsByRef  ==  false ? "0" : "1") + "'");
 
 if (objCMFuncParaEN.ParaCnName !=  null)
 {
 arrFieldListForInsert.Add(conCMFuncPara.ParaCnName);
 var strParaCnName = objCMFuncParaEN.ParaCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParaCnName + "'");
 }
 
 arrFieldListForInsert.Add(conCMFuncPara.IsKnownType);
 arrValueListForInsert.Add("'" + (objCMFuncParaEN.IsKnownType  ==  false ? "0" : "1") + "'");
 
 if (objCMFuncParaEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conCMFuncPara.PrjId);
 var strPrjId = objCMFuncParaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objCMFuncParaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCMFuncPara.UpdDate);
 var strUpdDate = objCMFuncParaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCMFuncParaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCMFuncPara.UpdUser);
 var strUpdUser = objCMFuncParaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objCMFuncParaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCMFuncPara.Memo);
 var strMemo = objCMFuncParaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CMFuncPara");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFuncParaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewCMFuncParas(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFuncParaDA.GetSpecSQLObj();
strSQL = "Select * from CMFuncPara where CmFuncParaId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CMFuncPara");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strCmFuncParaId = oRow[conCMFuncPara.CmFuncParaId].ToString().Trim();
if (IsExist(strCmFuncParaId))
{
 string strResult = "关键字变量值为:" + string.Format("CmFuncParaId = {0}", strCmFuncParaId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsCMFuncParaEN._CurrTabName ].NewRow();
objRow[conCMFuncPara.CmFuncParaId] = oRow[conCMFuncPara.CmFuncParaId].ToString().Trim(); //函数参数Id
objRow[conCMFuncPara.ParaName] = oRow[conCMFuncPara.ParaName].ToString().Trim(); //参数名
objRow[conCMFuncPara.ParaComments] = oRow[conCMFuncPara.ParaComments].ToString().Trim(); //参数注释
objRow[conCMFuncPara.ParameterType] = oRow[conCMFuncPara.ParameterType].ToString().Trim(); //参数类型
objRow[conCMFuncPara.DataTypeId] = oRow[conCMFuncPara.DataTypeId].ToString().Trim(); //数据类型Id
objRow[conCMFuncPara.ParameterTypeFullName] = oRow[conCMFuncPara.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objRow[conCMFuncPara.IsByRef] = oRow[conCMFuncPara.IsByRef].ToString().Trim(); //是否引用型参数
objRow[conCMFuncPara.ParaCnName] = oRow[conCMFuncPara.ParaCnName].ToString().Trim(); //参数中文名
objRow[conCMFuncPara.IsKnownType] = oRow[conCMFuncPara.IsKnownType].ToString().Trim(); //是否已知类型
objRow[conCMFuncPara.PrjId] = oRow[conCMFuncPara.PrjId].ToString().Trim(); //工程Id
objRow[conCMFuncPara.UpdDate] = oRow[conCMFuncPara.UpdDate].ToString().Trim(); //修改日期
objRow[conCMFuncPara.UpdUser] = oRow[conCMFuncPara.UpdUser].ToString().Trim(); //修改者
objRow[conCMFuncPara.Memo] = oRow[conCMFuncPara.Memo].ToString().Trim(); //说明
 objDS.Tables[clsCMFuncParaEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsCMFuncParaEN._CurrTabName);
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
 /// <param name = "objCMFuncParaEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsCMFuncParaEN objCMFuncParaEN)
{
 objCMFuncParaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMFuncParaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCMFuncParaEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFuncParaDA.GetSpecSQLObj();
strSQL = "Select * from CMFuncPara where CmFuncParaId = " + "'"+ objCMFuncParaEN.CmFuncParaId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsCMFuncParaEN._CurrTabName);
if (objDS.Tables[clsCMFuncParaEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:CmFuncParaId = " + "'"+ objCMFuncParaEN.CmFuncParaId+"'");
return false;
}
objRow = objDS.Tables[clsCMFuncParaEN._CurrTabName].Rows[0];
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.CmFuncParaId))
 {
objRow[conCMFuncPara.CmFuncParaId] = objCMFuncParaEN.CmFuncParaId; //函数参数Id
 }
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.ParaName))
 {
objRow[conCMFuncPara.ParaName] = objCMFuncParaEN.ParaName; //参数名
 }
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.ParaComments))
 {
objRow[conCMFuncPara.ParaComments] = objCMFuncParaEN.ParaComments; //参数注释
 }
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.ParameterType))
 {
objRow[conCMFuncPara.ParameterType] = objCMFuncParaEN.ParameterType; //参数类型
 }
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.DataTypeId))
 {
objRow[conCMFuncPara.DataTypeId] = objCMFuncParaEN.DataTypeId; //数据类型Id
 }
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.ParameterTypeFullName))
 {
objRow[conCMFuncPara.ParameterTypeFullName] = objCMFuncParaEN.ParameterTypeFullName; //参数类型全名
 }
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.IsByRef))
 {
objRow[conCMFuncPara.IsByRef] = objCMFuncParaEN.IsByRef; //是否引用型参数
 }
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.ParaCnName))
 {
objRow[conCMFuncPara.ParaCnName] = objCMFuncParaEN.ParaCnName; //参数中文名
 }
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.IsKnownType))
 {
objRow[conCMFuncPara.IsKnownType] = objCMFuncParaEN.IsKnownType; //是否已知类型
 }
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.PrjId))
 {
objRow[conCMFuncPara.PrjId] = objCMFuncParaEN.PrjId; //工程Id
 }
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.UpdDate))
 {
objRow[conCMFuncPara.UpdDate] = objCMFuncParaEN.UpdDate; //修改日期
 }
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.UpdUser))
 {
objRow[conCMFuncPara.UpdUser] = objCMFuncParaEN.UpdUser; //修改者
 }
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.Memo))
 {
objRow[conCMFuncPara.Memo] = objCMFuncParaEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsCMFuncParaEN._CurrTabName);
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
 /// <param name = "objCMFuncParaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCMFuncParaEN objCMFuncParaEN)
{
 objCMFuncParaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMFuncParaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCMFuncParaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFuncParaDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update CMFuncPara Set ");
 
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.ParaName))
 {
 if (objCMFuncParaEN.ParaName !=  null)
 {
 var strParaName = objCMFuncParaEN.ParaName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParaName, conCMFuncPara.ParaName); //参数名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFuncPara.ParaName); //参数名
 }
 }
 
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.ParaComments))
 {
 if (objCMFuncParaEN.ParaComments !=  null)
 {
 var strParaComments = objCMFuncParaEN.ParaComments.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParaComments, conCMFuncPara.ParaComments); //参数注释
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFuncPara.ParaComments); //参数注释
 }
 }
 
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.ParameterType))
 {
 if (objCMFuncParaEN.ParameterType !=  null)
 {
 var strParameterType = objCMFuncParaEN.ParameterType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParameterType, conCMFuncPara.ParameterType); //参数类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFuncPara.ParameterType); //参数类型
 }
 }
 
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.DataTypeId))
 {
 if (objCMFuncParaEN.DataTypeId !=  null)
 {
 var strDataTypeId = objCMFuncParaEN.DataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataTypeId, conCMFuncPara.DataTypeId); //数据类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFuncPara.DataTypeId); //数据类型Id
 }
 }
 
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.ParameterTypeFullName))
 {
 if (objCMFuncParaEN.ParameterTypeFullName !=  null)
 {
 var strParameterTypeFullName = objCMFuncParaEN.ParameterTypeFullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParameterTypeFullName, conCMFuncPara.ParameterTypeFullName); //参数类型全名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFuncPara.ParameterTypeFullName); //参数类型全名
 }
 }
 
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.IsByRef))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCMFuncParaEN.IsByRef == true?"1":"0", conCMFuncPara.IsByRef); //是否引用型参数
 }
 
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.ParaCnName))
 {
 if (objCMFuncParaEN.ParaCnName !=  null)
 {
 var strParaCnName = objCMFuncParaEN.ParaCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParaCnName, conCMFuncPara.ParaCnName); //参数中文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFuncPara.ParaCnName); //参数中文名
 }
 }
 
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.IsKnownType))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCMFuncParaEN.IsKnownType == true?"1":"0", conCMFuncPara.IsKnownType); //是否已知类型
 }
 
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.PrjId))
 {
 if (objCMFuncParaEN.PrjId !=  null)
 {
 var strPrjId = objCMFuncParaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conCMFuncPara.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFuncPara.PrjId); //工程Id
 }
 }
 
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.UpdDate))
 {
 if (objCMFuncParaEN.UpdDate !=  null)
 {
 var strUpdDate = objCMFuncParaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conCMFuncPara.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFuncPara.UpdDate); //修改日期
 }
 }
 
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.UpdUser))
 {
 if (objCMFuncParaEN.UpdUser !=  null)
 {
 var strUpdUser = objCMFuncParaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conCMFuncPara.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFuncPara.UpdUser); //修改者
 }
 }
 
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.Memo))
 {
 if (objCMFuncParaEN.Memo !=  null)
 {
 var strMemo = objCMFuncParaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCMFuncPara.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFuncPara.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where CmFuncParaId = '{0}'", objCMFuncParaEN.CmFuncParaId); 
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
 /// <param name = "objCMFuncParaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsCMFuncParaEN objCMFuncParaEN, string strCondition)
{
 objCMFuncParaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMFuncParaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCMFuncParaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFuncParaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CMFuncPara Set ");
 
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.ParaName))
 {
 if (objCMFuncParaEN.ParaName !=  null)
 {
 var strParaName = objCMFuncParaEN.ParaName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParaName = '{0}',", strParaName); //参数名
 }
 else
 {
 sbSQL.Append(" ParaName = null,"); //参数名
 }
 }
 
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.ParaComments))
 {
 if (objCMFuncParaEN.ParaComments !=  null)
 {
 var strParaComments = objCMFuncParaEN.ParaComments.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParaComments = '{0}',", strParaComments); //参数注释
 }
 else
 {
 sbSQL.Append(" ParaComments = null,"); //参数注释
 }
 }
 
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.ParameterType))
 {
 if (objCMFuncParaEN.ParameterType !=  null)
 {
 var strParameterType = objCMFuncParaEN.ParameterType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParameterType = '{0}',", strParameterType); //参数类型
 }
 else
 {
 sbSQL.Append(" ParameterType = null,"); //参数类型
 }
 }
 
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.DataTypeId))
 {
 if (objCMFuncParaEN.DataTypeId !=  null)
 {
 var strDataTypeId = objCMFuncParaEN.DataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataTypeId = '{0}',", strDataTypeId); //数据类型Id
 }
 else
 {
 sbSQL.Append(" DataTypeId = null,"); //数据类型Id
 }
 }
 
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.ParameterTypeFullName))
 {
 if (objCMFuncParaEN.ParameterTypeFullName !=  null)
 {
 var strParameterTypeFullName = objCMFuncParaEN.ParameterTypeFullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParameterTypeFullName = '{0}',", strParameterTypeFullName); //参数类型全名
 }
 else
 {
 sbSQL.Append(" ParameterTypeFullName = null,"); //参数类型全名
 }
 }
 
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.IsByRef))
 {
 sbSQL.AppendFormat(" IsByRef = '{0}',", objCMFuncParaEN.IsByRef == true?"1":"0"); //是否引用型参数
 }
 
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.ParaCnName))
 {
 if (objCMFuncParaEN.ParaCnName !=  null)
 {
 var strParaCnName = objCMFuncParaEN.ParaCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParaCnName = '{0}',", strParaCnName); //参数中文名
 }
 else
 {
 sbSQL.Append(" ParaCnName = null,"); //参数中文名
 }
 }
 
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.IsKnownType))
 {
 sbSQL.AppendFormat(" IsKnownType = '{0}',", objCMFuncParaEN.IsKnownType == true?"1":"0"); //是否已知类型
 }
 
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.PrjId))
 {
 if (objCMFuncParaEN.PrjId !=  null)
 {
 var strPrjId = objCMFuncParaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.UpdDate))
 {
 if (objCMFuncParaEN.UpdDate !=  null)
 {
 var strUpdDate = objCMFuncParaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.UpdUser))
 {
 if (objCMFuncParaEN.UpdUser !=  null)
 {
 var strUpdUser = objCMFuncParaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.Memo))
 {
 if (objCMFuncParaEN.Memo !=  null)
 {
 var strMemo = objCMFuncParaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objCMFuncParaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsCMFuncParaEN objCMFuncParaEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objCMFuncParaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMFuncParaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCMFuncParaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFuncParaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CMFuncPara Set ");
 
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.ParaName))
 {
 if (objCMFuncParaEN.ParaName !=  null)
 {
 var strParaName = objCMFuncParaEN.ParaName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParaName = '{0}',", strParaName); //参数名
 }
 else
 {
 sbSQL.Append(" ParaName = null,"); //参数名
 }
 }
 
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.ParaComments))
 {
 if (objCMFuncParaEN.ParaComments !=  null)
 {
 var strParaComments = objCMFuncParaEN.ParaComments.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParaComments = '{0}',", strParaComments); //参数注释
 }
 else
 {
 sbSQL.Append(" ParaComments = null,"); //参数注释
 }
 }
 
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.ParameterType))
 {
 if (objCMFuncParaEN.ParameterType !=  null)
 {
 var strParameterType = objCMFuncParaEN.ParameterType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParameterType = '{0}',", strParameterType); //参数类型
 }
 else
 {
 sbSQL.Append(" ParameterType = null,"); //参数类型
 }
 }
 
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.DataTypeId))
 {
 if (objCMFuncParaEN.DataTypeId !=  null)
 {
 var strDataTypeId = objCMFuncParaEN.DataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataTypeId = '{0}',", strDataTypeId); //数据类型Id
 }
 else
 {
 sbSQL.Append(" DataTypeId = null,"); //数据类型Id
 }
 }
 
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.ParameterTypeFullName))
 {
 if (objCMFuncParaEN.ParameterTypeFullName !=  null)
 {
 var strParameterTypeFullName = objCMFuncParaEN.ParameterTypeFullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParameterTypeFullName = '{0}',", strParameterTypeFullName); //参数类型全名
 }
 else
 {
 sbSQL.Append(" ParameterTypeFullName = null,"); //参数类型全名
 }
 }
 
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.IsByRef))
 {
 sbSQL.AppendFormat(" IsByRef = '{0}',", objCMFuncParaEN.IsByRef == true?"1":"0"); //是否引用型参数
 }
 
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.ParaCnName))
 {
 if (objCMFuncParaEN.ParaCnName !=  null)
 {
 var strParaCnName = objCMFuncParaEN.ParaCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParaCnName = '{0}',", strParaCnName); //参数中文名
 }
 else
 {
 sbSQL.Append(" ParaCnName = null,"); //参数中文名
 }
 }
 
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.IsKnownType))
 {
 sbSQL.AppendFormat(" IsKnownType = '{0}',", objCMFuncParaEN.IsKnownType == true?"1":"0"); //是否已知类型
 }
 
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.PrjId))
 {
 if (objCMFuncParaEN.PrjId !=  null)
 {
 var strPrjId = objCMFuncParaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.UpdDate))
 {
 if (objCMFuncParaEN.UpdDate !=  null)
 {
 var strUpdDate = objCMFuncParaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.UpdUser))
 {
 if (objCMFuncParaEN.UpdUser !=  null)
 {
 var strUpdUser = objCMFuncParaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.Memo))
 {
 if (objCMFuncParaEN.Memo !=  null)
 {
 var strMemo = objCMFuncParaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objCMFuncParaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCMFuncParaEN objCMFuncParaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objCMFuncParaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMFuncParaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCMFuncParaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFuncParaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CMFuncPara Set ");
 
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.ParaName))
 {
 if (objCMFuncParaEN.ParaName !=  null)
 {
 var strParaName = objCMFuncParaEN.ParaName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParaName, conCMFuncPara.ParaName); //参数名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFuncPara.ParaName); //参数名
 }
 }
 
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.ParaComments))
 {
 if (objCMFuncParaEN.ParaComments !=  null)
 {
 var strParaComments = objCMFuncParaEN.ParaComments.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParaComments, conCMFuncPara.ParaComments); //参数注释
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFuncPara.ParaComments); //参数注释
 }
 }
 
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.ParameterType))
 {
 if (objCMFuncParaEN.ParameterType !=  null)
 {
 var strParameterType = objCMFuncParaEN.ParameterType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParameterType, conCMFuncPara.ParameterType); //参数类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFuncPara.ParameterType); //参数类型
 }
 }
 
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.DataTypeId))
 {
 if (objCMFuncParaEN.DataTypeId !=  null)
 {
 var strDataTypeId = objCMFuncParaEN.DataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataTypeId, conCMFuncPara.DataTypeId); //数据类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFuncPara.DataTypeId); //数据类型Id
 }
 }
 
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.ParameterTypeFullName))
 {
 if (objCMFuncParaEN.ParameterTypeFullName !=  null)
 {
 var strParameterTypeFullName = objCMFuncParaEN.ParameterTypeFullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParameterTypeFullName, conCMFuncPara.ParameterTypeFullName); //参数类型全名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFuncPara.ParameterTypeFullName); //参数类型全名
 }
 }
 
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.IsByRef))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCMFuncParaEN.IsByRef == true?"1":"0", conCMFuncPara.IsByRef); //是否引用型参数
 }
 
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.ParaCnName))
 {
 if (objCMFuncParaEN.ParaCnName !=  null)
 {
 var strParaCnName = objCMFuncParaEN.ParaCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParaCnName, conCMFuncPara.ParaCnName); //参数中文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFuncPara.ParaCnName); //参数中文名
 }
 }
 
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.IsKnownType))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCMFuncParaEN.IsKnownType == true?"1":"0", conCMFuncPara.IsKnownType); //是否已知类型
 }
 
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.PrjId))
 {
 if (objCMFuncParaEN.PrjId !=  null)
 {
 var strPrjId = objCMFuncParaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conCMFuncPara.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFuncPara.PrjId); //工程Id
 }
 }
 
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.UpdDate))
 {
 if (objCMFuncParaEN.UpdDate !=  null)
 {
 var strUpdDate = objCMFuncParaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conCMFuncPara.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFuncPara.UpdDate); //修改日期
 }
 }
 
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.UpdUser))
 {
 if (objCMFuncParaEN.UpdUser !=  null)
 {
 var strUpdUser = objCMFuncParaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conCMFuncPara.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFuncPara.UpdUser); //修改者
 }
 }
 
 if (objCMFuncParaEN.IsUpdated(conCMFuncPara.Memo))
 {
 if (objCMFuncParaEN.Memo !=  null)
 {
 var strMemo = objCMFuncParaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCMFuncPara.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFuncPara.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where CmFuncParaId = '{0}'", objCMFuncParaEN.CmFuncParaId); 
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
 /// <param name = "strCmFuncParaId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strCmFuncParaId) 
{
CheckPrimaryKey(strCmFuncParaId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFuncParaDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strCmFuncParaId,
};
 objSQL.ExecSP("CMFuncPara_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strCmFuncParaId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strCmFuncParaId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strCmFuncParaId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFuncParaDA.GetSpecSQLObj();
//删除CMFuncPara本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CMFuncPara where CmFuncParaId = " + "'"+ strCmFuncParaId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelCMFuncPara(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFuncParaDA.GetSpecSQLObj();
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
//删除CMFuncPara本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CMFuncPara where CmFuncParaId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strCmFuncParaId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strCmFuncParaId) 
{
CheckPrimaryKey(strCmFuncParaId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFuncParaDA.GetSpecSQLObj();
//删除CMFuncPara本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CMFuncPara where CmFuncParaId = " + "'"+ strCmFuncParaId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelCMFuncPara(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsCMFuncParaDA: DelCMFuncPara)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFuncParaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CMFuncPara where " + strCondition ;
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
public bool DelCMFuncParaWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsCMFuncParaDA: DelCMFuncParaWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFuncParaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CMFuncPara where " + strCondition ;
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
 /// <param name = "objCMFuncParaENS">源对象</param>
 /// <param name = "objCMFuncParaENT">目标对象</param>
public void CopyTo(clsCMFuncParaEN objCMFuncParaENS, clsCMFuncParaEN objCMFuncParaENT)
{
objCMFuncParaENT.CmFuncParaId = objCMFuncParaENS.CmFuncParaId; //函数参数Id
objCMFuncParaENT.ParaName = objCMFuncParaENS.ParaName; //参数名
objCMFuncParaENT.ParaComments = objCMFuncParaENS.ParaComments; //参数注释
objCMFuncParaENT.ParameterType = objCMFuncParaENS.ParameterType; //参数类型
objCMFuncParaENT.DataTypeId = objCMFuncParaENS.DataTypeId; //数据类型Id
objCMFuncParaENT.ParameterTypeFullName = objCMFuncParaENS.ParameterTypeFullName; //参数类型全名
objCMFuncParaENT.IsByRef = objCMFuncParaENS.IsByRef; //是否引用型参数
objCMFuncParaENT.ParaCnName = objCMFuncParaENS.ParaCnName; //参数中文名
objCMFuncParaENT.IsKnownType = objCMFuncParaENS.IsKnownType; //是否已知类型
objCMFuncParaENT.PrjId = objCMFuncParaENS.PrjId; //工程Id
objCMFuncParaENT.UpdDate = objCMFuncParaENS.UpdDate; //修改日期
objCMFuncParaENT.UpdUser = objCMFuncParaENS.UpdUser; //修改者
objCMFuncParaENT.Memo = objCMFuncParaENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsCMFuncParaEN objCMFuncParaEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objCMFuncParaEN.ParaName, conCMFuncPara.ParaName);
clsCheckSql.CheckFieldNotNull(objCMFuncParaEN.ParameterType, conCMFuncPara.ParameterType);
clsCheckSql.CheckFieldNotNull(objCMFuncParaEN.DataTypeId, conCMFuncPara.DataTypeId);
clsCheckSql.CheckFieldNotNull(objCMFuncParaEN.IsByRef, conCMFuncPara.IsByRef);
clsCheckSql.CheckFieldNotNull(objCMFuncParaEN.ParaCnName, conCMFuncPara.ParaCnName);
clsCheckSql.CheckFieldNotNull(objCMFuncParaEN.PrjId, conCMFuncPara.PrjId);
//检查字段长度
clsCheckSql.CheckFieldLen(objCMFuncParaEN.CmFuncParaId, 8, conCMFuncPara.CmFuncParaId);
clsCheckSql.CheckFieldLen(objCMFuncParaEN.ParaName, 50, conCMFuncPara.ParaName);
clsCheckSql.CheckFieldLen(objCMFuncParaEN.ParaComments, 500, conCMFuncPara.ParaComments);
clsCheckSql.CheckFieldLen(objCMFuncParaEN.ParameterType, 100, conCMFuncPara.ParameterType);
clsCheckSql.CheckFieldLen(objCMFuncParaEN.DataTypeId, 2, conCMFuncPara.DataTypeId);
clsCheckSql.CheckFieldLen(objCMFuncParaEN.ParameterTypeFullName, 500, conCMFuncPara.ParameterTypeFullName);
clsCheckSql.CheckFieldLen(objCMFuncParaEN.ParaCnName, 50, conCMFuncPara.ParaCnName);
clsCheckSql.CheckFieldLen(objCMFuncParaEN.PrjId, 4, conCMFuncPara.PrjId);
clsCheckSql.CheckFieldLen(objCMFuncParaEN.UpdDate, 20, conCMFuncPara.UpdDate);
clsCheckSql.CheckFieldLen(objCMFuncParaEN.UpdUser, 20, conCMFuncPara.UpdUser);
clsCheckSql.CheckFieldLen(objCMFuncParaEN.Memo, 1000, conCMFuncPara.Memo);
//检查字段外键固定长度
 objCMFuncParaEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsCMFuncParaEN objCMFuncParaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCMFuncParaEN.ParaName, 50, conCMFuncPara.ParaName);
clsCheckSql.CheckFieldLen(objCMFuncParaEN.ParaComments, 500, conCMFuncPara.ParaComments);
clsCheckSql.CheckFieldLen(objCMFuncParaEN.ParameterType, 100, conCMFuncPara.ParameterType);
clsCheckSql.CheckFieldLen(objCMFuncParaEN.DataTypeId, 2, conCMFuncPara.DataTypeId);
clsCheckSql.CheckFieldLen(objCMFuncParaEN.ParameterTypeFullName, 500, conCMFuncPara.ParameterTypeFullName);
clsCheckSql.CheckFieldLen(objCMFuncParaEN.ParaCnName, 50, conCMFuncPara.ParaCnName);
clsCheckSql.CheckFieldLen(objCMFuncParaEN.PrjId, 4, conCMFuncPara.PrjId);
clsCheckSql.CheckFieldLen(objCMFuncParaEN.UpdDate, 20, conCMFuncPara.UpdDate);
clsCheckSql.CheckFieldLen(objCMFuncParaEN.UpdUser, 20, conCMFuncPara.UpdUser);
clsCheckSql.CheckFieldLen(objCMFuncParaEN.Memo, 1000, conCMFuncPara.Memo);
//检查外键字段长度
 objCMFuncParaEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsCMFuncParaEN objCMFuncParaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCMFuncParaEN.CmFuncParaId, 8, conCMFuncPara.CmFuncParaId);
clsCheckSql.CheckFieldLen(objCMFuncParaEN.ParaName, 50, conCMFuncPara.ParaName);
clsCheckSql.CheckFieldLen(objCMFuncParaEN.ParaComments, 500, conCMFuncPara.ParaComments);
clsCheckSql.CheckFieldLen(objCMFuncParaEN.ParameterType, 100, conCMFuncPara.ParameterType);
clsCheckSql.CheckFieldLen(objCMFuncParaEN.DataTypeId, 2, conCMFuncPara.DataTypeId);
clsCheckSql.CheckFieldLen(objCMFuncParaEN.ParameterTypeFullName, 500, conCMFuncPara.ParameterTypeFullName);
clsCheckSql.CheckFieldLen(objCMFuncParaEN.ParaCnName, 50, conCMFuncPara.ParaCnName);
clsCheckSql.CheckFieldLen(objCMFuncParaEN.PrjId, 4, conCMFuncPara.PrjId);
clsCheckSql.CheckFieldLen(objCMFuncParaEN.UpdDate, 20, conCMFuncPara.UpdDate);
clsCheckSql.CheckFieldLen(objCMFuncParaEN.UpdUser, 20, conCMFuncPara.UpdUser);
clsCheckSql.CheckFieldLen(objCMFuncParaEN.Memo, 1000, conCMFuncPara.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objCMFuncParaEN.CmFuncParaId, conCMFuncPara.CmFuncParaId);
clsCheckSql.CheckSqlInjection4Field(objCMFuncParaEN.ParaName, conCMFuncPara.ParaName);
clsCheckSql.CheckSqlInjection4Field(objCMFuncParaEN.ParaComments, conCMFuncPara.ParaComments);
clsCheckSql.CheckSqlInjection4Field(objCMFuncParaEN.ParameterType, conCMFuncPara.ParameterType);
clsCheckSql.CheckSqlInjection4Field(objCMFuncParaEN.DataTypeId, conCMFuncPara.DataTypeId);
clsCheckSql.CheckSqlInjection4Field(objCMFuncParaEN.ParameterTypeFullName, conCMFuncPara.ParameterTypeFullName);
clsCheckSql.CheckSqlInjection4Field(objCMFuncParaEN.ParaCnName, conCMFuncPara.ParaCnName);
clsCheckSql.CheckSqlInjection4Field(objCMFuncParaEN.PrjId, conCMFuncPara.PrjId);
clsCheckSql.CheckSqlInjection4Field(objCMFuncParaEN.UpdDate, conCMFuncPara.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objCMFuncParaEN.UpdUser, conCMFuncPara.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objCMFuncParaEN.Memo, conCMFuncPara.Memo);
//检查外键字段长度
 objCMFuncParaEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--CMFuncPara(CM函数参数),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objCMFuncParaEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsCMFuncParaEN objCMFuncParaEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ParaName = '{0}'", objCMFuncParaEN.ParaName);
 sbCondition.AppendFormat(" and DataTypeId = '{0}'", objCMFuncParaEN.DataTypeId);
 sbCondition.AppendFormat(" and ParameterType = '{0}'", objCMFuncParaEN.ParameterType);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objCMFuncParaEN.PrjId);
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
 objSQL = clsCMFuncParaDA.GetSpecSQLObj();
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
 objSQL = clsCMFuncParaDA.GetSpecSQLObj();
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
 objSQL = clsCMFuncParaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCMFuncParaEN._CurrTabName);
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
 objSQL = clsCMFuncParaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCMFuncParaEN._CurrTabName, strCondition);
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
 objSQL = clsCMFuncParaDA.GetSpecSQLObj();
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
 objSQL = clsCMFuncParaDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}