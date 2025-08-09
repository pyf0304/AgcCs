
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFunctionTemplateDA
 表名:FunctionTemplate(00050312)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:06:16
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
 /// 函数模板(FunctionTemplate)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsFunctionTemplateDA : clsCommBase4DA
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
 return clsFunctionTemplateEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsFunctionTemplateEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsFunctionTemplateEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsFunctionTemplateEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsFunctionTemplateEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strFunctionTemplateId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strFunctionTemplateId)
{
strFunctionTemplateId = strFunctionTemplateId.Replace("'", "''");
if (strFunctionTemplateId.Length > 4)
{
throw new Exception("(errid:Data000001)在表:FunctionTemplate中,检查关键字,长度不正确!(clsFunctionTemplateDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strFunctionTemplateId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:FunctionTemplate中,关键字不能为空 或 null!(clsFunctionTemplateDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFunctionTemplateId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsFunctionTemplateDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsFunctionTemplateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTemplateDA.GetSpecSQLObj();
strSQL = "Select * from FunctionTemplate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_FunctionTemplate(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsFunctionTemplateDA: GetDataTable_FunctionTemplate)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTemplateDA.GetSpecSQLObj();
strSQL = "Select * from FunctionTemplate where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsFunctionTemplateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTemplateDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsFunctionTemplateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTemplateDA.GetSpecSQLObj();
strSQL = "Select * from FunctionTemplate where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsFunctionTemplateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTemplateDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsFunctionTemplateDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTemplateDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FunctionTemplate where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FunctionTemplate where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsFunctionTemplateDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTemplateDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from FunctionTemplate where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsFunctionTemplateDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTemplateDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} FunctionTemplate.* " + 
$"from FunctionTemplate " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and FunctionTemplate.FunctionTemplateId not in " + 
$"(Select top {intTop_In} FunctionTemplate.FunctionTemplateId from FunctionTemplate " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FunctionTemplate where {1} and FunctionTemplateId not in (Select top {2} FunctionTemplateId from FunctionTemplate where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FunctionTemplate where {1} and FunctionTemplateId not in (Select top {3} FunctionTemplateId from FunctionTemplate where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsFunctionTemplateDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTemplateDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} FunctionTemplate.* " + 
$"from FunctionTemplate " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and FunctionTemplate.FunctionTemplateId not in " + 
$"(Select top {intTop_In} FunctionTemplate.FunctionTemplateId from FunctionTemplate " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FunctionTemplate where {1} and FunctionTemplateId not in (Select top {2} FunctionTemplateId from FunctionTemplate where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FunctionTemplate where {1} and FunctionTemplateId not in (Select top {3} FunctionTemplateId from FunctionTemplate where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsFunctionTemplateEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsFunctionTemplateDA:GetObjLst)", objException.Message));
}
List<clsFunctionTemplateEN> arrObjLst = new List<clsFunctionTemplateEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTemplateDA.GetSpecSQLObj();
strSQL = "Select * from FunctionTemplate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionTemplateEN objFunctionTemplateEN = new clsFunctionTemplateEN();
try
{
objFunctionTemplateEN.FunctionTemplateId = objRow[conFunctionTemplate.FunctionTemplateId].ToString().Trim(); //函数模板Id
objFunctionTemplateEN.FunctionTemplateName = objRow[conFunctionTemplate.FunctionTemplateName].ToString().Trim(); //函数模板名
objFunctionTemplateEN.FunctionTemplateENName = objRow[conFunctionTemplate.FunctionTemplateENName].ToString().Trim(); //函数模板英文名
objFunctionTemplateEN.ProgLangTypeId = objRow[conFunctionTemplate.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objFunctionTemplateEN.CreateUserId = objRow[conFunctionTemplate.CreateUserId].ToString().Trim(); //建立用户Id
objFunctionTemplateEN.UpdDate = objRow[conFunctionTemplate.UpdDate] == DBNull.Value ? null : objRow[conFunctionTemplate.UpdDate].ToString().Trim(); //修改日期
objFunctionTemplateEN.UpdUser = objRow[conFunctionTemplate.UpdUser] == DBNull.Value ? null : objRow[conFunctionTemplate.UpdUser].ToString().Trim(); //修改者
objFunctionTemplateEN.Memo = objRow[conFunctionTemplate.Memo] == DBNull.Value ? null : objRow[conFunctionTemplate.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsFunctionTemplateDA: GetObjLst)", objException.Message));
}
objFunctionTemplateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objFunctionTemplateEN);
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
public List<clsFunctionTemplateEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsFunctionTemplateDA:GetObjLstByTabName)", objException.Message));
}
List<clsFunctionTemplateEN> arrObjLst = new List<clsFunctionTemplateEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTemplateDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionTemplateEN objFunctionTemplateEN = new clsFunctionTemplateEN();
try
{
objFunctionTemplateEN.FunctionTemplateId = objRow[conFunctionTemplate.FunctionTemplateId].ToString().Trim(); //函数模板Id
objFunctionTemplateEN.FunctionTemplateName = objRow[conFunctionTemplate.FunctionTemplateName].ToString().Trim(); //函数模板名
objFunctionTemplateEN.FunctionTemplateENName = objRow[conFunctionTemplate.FunctionTemplateENName].ToString().Trim(); //函数模板英文名
objFunctionTemplateEN.ProgLangTypeId = objRow[conFunctionTemplate.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objFunctionTemplateEN.CreateUserId = objRow[conFunctionTemplate.CreateUserId].ToString().Trim(); //建立用户Id
objFunctionTemplateEN.UpdDate = objRow[conFunctionTemplate.UpdDate] == DBNull.Value ? null : objRow[conFunctionTemplate.UpdDate].ToString().Trim(); //修改日期
objFunctionTemplateEN.UpdUser = objRow[conFunctionTemplate.UpdUser] == DBNull.Value ? null : objRow[conFunctionTemplate.UpdUser].ToString().Trim(); //修改者
objFunctionTemplateEN.Memo = objRow[conFunctionTemplate.Memo] == DBNull.Value ? null : objRow[conFunctionTemplate.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsFunctionTemplateDA: GetObjLst)", objException.Message));
}
objFunctionTemplateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objFunctionTemplateEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objFunctionTemplateEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetFunctionTemplate(ref clsFunctionTemplateEN objFunctionTemplateEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTemplateDA.GetSpecSQLObj();
strSQL = "Select * from FunctionTemplate where FunctionTemplateId = " + "'"+ objFunctionTemplateEN.FunctionTemplateId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objFunctionTemplateEN.FunctionTemplateId = objDT.Rows[0][conFunctionTemplate.FunctionTemplateId].ToString().Trim(); //函数模板Id(字段类型:char,字段长度:4,是否可空:False)
 objFunctionTemplateEN.FunctionTemplateName = objDT.Rows[0][conFunctionTemplate.FunctionTemplateName].ToString().Trim(); //函数模板名(字段类型:varchar,字段长度:50,是否可空:False)
 objFunctionTemplateEN.FunctionTemplateENName = objDT.Rows[0][conFunctionTemplate.FunctionTemplateENName].ToString().Trim(); //函数模板英文名(字段类型:varchar,字段长度:50,是否可空:False)
 objFunctionTemplateEN.ProgLangTypeId = objDT.Rows[0][conFunctionTemplate.ProgLangTypeId].ToString().Trim(); //编程语言类型Id(字段类型:char,字段长度:2,是否可空:False)
 objFunctionTemplateEN.CreateUserId = objDT.Rows[0][conFunctionTemplate.CreateUserId].ToString().Trim(); //建立用户Id(字段类型:varchar,字段长度:18,是否可空:False)
 objFunctionTemplateEN.UpdDate = objDT.Rows[0][conFunctionTemplate.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objFunctionTemplateEN.UpdUser = objDT.Rows[0][conFunctionTemplate.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objFunctionTemplateEN.Memo = objDT.Rows[0][conFunctionTemplate.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsFunctionTemplateDA: GetFunctionTemplate)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFunctionTemplateId">表关键字</param>
 /// <returns>表对象</returns>
public clsFunctionTemplateEN GetObjByFunctionTemplateId(string strFunctionTemplateId)
{
CheckPrimaryKey(strFunctionTemplateId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTemplateDA.GetSpecSQLObj();
strSQL = "Select * from FunctionTemplate where FunctionTemplateId = " + "'"+ strFunctionTemplateId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsFunctionTemplateEN objFunctionTemplateEN = new clsFunctionTemplateEN();
try
{
 objFunctionTemplateEN.FunctionTemplateId = objRow[conFunctionTemplate.FunctionTemplateId].ToString().Trim(); //函数模板Id(字段类型:char,字段长度:4,是否可空:False)
 objFunctionTemplateEN.FunctionTemplateName = objRow[conFunctionTemplate.FunctionTemplateName].ToString().Trim(); //函数模板名(字段类型:varchar,字段长度:50,是否可空:False)
 objFunctionTemplateEN.FunctionTemplateENName = objRow[conFunctionTemplate.FunctionTemplateENName].ToString().Trim(); //函数模板英文名(字段类型:varchar,字段长度:50,是否可空:False)
 objFunctionTemplateEN.ProgLangTypeId = objRow[conFunctionTemplate.ProgLangTypeId].ToString().Trim(); //编程语言类型Id(字段类型:char,字段长度:2,是否可空:False)
 objFunctionTemplateEN.CreateUserId = objRow[conFunctionTemplate.CreateUserId].ToString().Trim(); //建立用户Id(字段类型:varchar,字段长度:18,是否可空:False)
 objFunctionTemplateEN.UpdDate = objRow[conFunctionTemplate.UpdDate] == DBNull.Value ? null : objRow[conFunctionTemplate.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objFunctionTemplateEN.UpdUser = objRow[conFunctionTemplate.UpdUser] == DBNull.Value ? null : objRow[conFunctionTemplate.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objFunctionTemplateEN.Memo = objRow[conFunctionTemplate.Memo] == DBNull.Value ? null : objRow[conFunctionTemplate.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsFunctionTemplateDA: GetObjByFunctionTemplateId)", objException.Message));
}
return objFunctionTemplateEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsFunctionTemplateEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsFunctionTemplateDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTemplateDA.GetSpecSQLObj();
strSQL = "Select * from FunctionTemplate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsFunctionTemplateEN objFunctionTemplateEN = new clsFunctionTemplateEN()
{
FunctionTemplateId = objRow[conFunctionTemplate.FunctionTemplateId].ToString().Trim(), //函数模板Id
FunctionTemplateName = objRow[conFunctionTemplate.FunctionTemplateName].ToString().Trim(), //函数模板名
FunctionTemplateENName = objRow[conFunctionTemplate.FunctionTemplateENName].ToString().Trim(), //函数模板英文名
ProgLangTypeId = objRow[conFunctionTemplate.ProgLangTypeId].ToString().Trim(), //编程语言类型Id
CreateUserId = objRow[conFunctionTemplate.CreateUserId].ToString().Trim(), //建立用户Id
UpdDate = objRow[conFunctionTemplate.UpdDate] == DBNull.Value ? null : objRow[conFunctionTemplate.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conFunctionTemplate.UpdUser] == DBNull.Value ? null : objRow[conFunctionTemplate.UpdUser].ToString().Trim(), //修改者
Memo = objRow[conFunctionTemplate.Memo] == DBNull.Value ? null : objRow[conFunctionTemplate.Memo].ToString().Trim() //说明
};
objFunctionTemplateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFunctionTemplateEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsFunctionTemplateDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsFunctionTemplateEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsFunctionTemplateEN objFunctionTemplateEN = new clsFunctionTemplateEN();
try
{
objFunctionTemplateEN.FunctionTemplateId = objRow[conFunctionTemplate.FunctionTemplateId].ToString().Trim(); //函数模板Id
objFunctionTemplateEN.FunctionTemplateName = objRow[conFunctionTemplate.FunctionTemplateName].ToString().Trim(); //函数模板名
objFunctionTemplateEN.FunctionTemplateENName = objRow[conFunctionTemplate.FunctionTemplateENName].ToString().Trim(); //函数模板英文名
objFunctionTemplateEN.ProgLangTypeId = objRow[conFunctionTemplate.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objFunctionTemplateEN.CreateUserId = objRow[conFunctionTemplate.CreateUserId].ToString().Trim(); //建立用户Id
objFunctionTemplateEN.UpdDate = objRow[conFunctionTemplate.UpdDate] == DBNull.Value ? null : objRow[conFunctionTemplate.UpdDate].ToString().Trim(); //修改日期
objFunctionTemplateEN.UpdUser = objRow[conFunctionTemplate.UpdUser] == DBNull.Value ? null : objRow[conFunctionTemplate.UpdUser].ToString().Trim(); //修改者
objFunctionTemplateEN.Memo = objRow[conFunctionTemplate.Memo] == DBNull.Value ? null : objRow[conFunctionTemplate.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsFunctionTemplateDA: GetObjByDataRowFunctionTemplate)", objException.Message));
}
objFunctionTemplateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFunctionTemplateEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsFunctionTemplateEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsFunctionTemplateEN objFunctionTemplateEN = new clsFunctionTemplateEN();
try
{
objFunctionTemplateEN.FunctionTemplateId = objRow[conFunctionTemplate.FunctionTemplateId].ToString().Trim(); //函数模板Id
objFunctionTemplateEN.FunctionTemplateName = objRow[conFunctionTemplate.FunctionTemplateName].ToString().Trim(); //函数模板名
objFunctionTemplateEN.FunctionTemplateENName = objRow[conFunctionTemplate.FunctionTemplateENName].ToString().Trim(); //函数模板英文名
objFunctionTemplateEN.ProgLangTypeId = objRow[conFunctionTemplate.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objFunctionTemplateEN.CreateUserId = objRow[conFunctionTemplate.CreateUserId].ToString().Trim(); //建立用户Id
objFunctionTemplateEN.UpdDate = objRow[conFunctionTemplate.UpdDate] == DBNull.Value ? null : objRow[conFunctionTemplate.UpdDate].ToString().Trim(); //修改日期
objFunctionTemplateEN.UpdUser = objRow[conFunctionTemplate.UpdUser] == DBNull.Value ? null : objRow[conFunctionTemplate.UpdUser].ToString().Trim(); //修改者
objFunctionTemplateEN.Memo = objRow[conFunctionTemplate.Memo] == DBNull.Value ? null : objRow[conFunctionTemplate.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsFunctionTemplateDA: GetObjByDataRow)", objException.Message));
}
objFunctionTemplateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFunctionTemplateEN;
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
objSQL = clsFunctionTemplateDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsFunctionTemplateEN._CurrTabName, conFunctionTemplate.FunctionTemplateId, 4, "");
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
objSQL = clsFunctionTemplateDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsFunctionTemplateEN._CurrTabName, conFunctionTemplate.FunctionTemplateId, 4, strPrefix);
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
 objSQL = clsFunctionTemplateDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select FunctionTemplateId from FunctionTemplate where " + strCondition;
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
 objSQL = clsFunctionTemplateDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select FunctionTemplateId from FunctionTemplate where " + strCondition;
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
 /// <param name = "strFunctionTemplateId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strFunctionTemplateId)
{
CheckPrimaryKey(strFunctionTemplateId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTemplateDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("FunctionTemplate", "FunctionTemplateId = " + "'"+ strFunctionTemplateId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsFunctionTemplateDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTemplateDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("FunctionTemplate", strCondition))
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
objSQL = clsFunctionTemplateDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("FunctionTemplate");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsFunctionTemplateEN objFunctionTemplateEN)
 {
 objFunctionTemplateEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunctionTemplateEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFunctionTemplateEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTemplateDA.GetSpecSQLObj();
strSQL = "Select * from FunctionTemplate where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "FunctionTemplate");
objRow = objDS.Tables["FunctionTemplate"].NewRow();
objRow[conFunctionTemplate.FunctionTemplateId] = objFunctionTemplateEN.FunctionTemplateId; //函数模板Id
objRow[conFunctionTemplate.FunctionTemplateName] = objFunctionTemplateEN.FunctionTemplateName; //函数模板名
objRow[conFunctionTemplate.FunctionTemplateENName] = objFunctionTemplateEN.FunctionTemplateENName; //函数模板英文名
objRow[conFunctionTemplate.ProgLangTypeId] = objFunctionTemplateEN.ProgLangTypeId; //编程语言类型Id
objRow[conFunctionTemplate.CreateUserId] = objFunctionTemplateEN.CreateUserId; //建立用户Id
 if (objFunctionTemplateEN.UpdDate !=  "")
 {
objRow[conFunctionTemplate.UpdDate] = objFunctionTemplateEN.UpdDate; //修改日期
 }
 if (objFunctionTemplateEN.UpdUser !=  "")
 {
objRow[conFunctionTemplate.UpdUser] = objFunctionTemplateEN.UpdUser; //修改者
 }
 if (objFunctionTemplateEN.Memo !=  "")
 {
objRow[conFunctionTemplate.Memo] = objFunctionTemplateEN.Memo; //说明
 }
objDS.Tables[clsFunctionTemplateEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsFunctionTemplateEN._CurrTabName);
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
 /// <param name = "objFunctionTemplateEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsFunctionTemplateEN objFunctionTemplateEN)
{
 objFunctionTemplateEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunctionTemplateEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFunctionTemplateEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFunctionTemplateEN.FunctionTemplateId !=  null)
 {
 arrFieldListForInsert.Add(conFunctionTemplate.FunctionTemplateId);
 var strFunctionTemplateId = objFunctionTemplateEN.FunctionTemplateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionTemplateId + "'");
 }
 
 if (objFunctionTemplateEN.FunctionTemplateName !=  null)
 {
 arrFieldListForInsert.Add(conFunctionTemplate.FunctionTemplateName);
 var strFunctionTemplateName = objFunctionTemplateEN.FunctionTemplateName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionTemplateName + "'");
 }
 
 if (objFunctionTemplateEN.FunctionTemplateENName !=  null)
 {
 arrFieldListForInsert.Add(conFunctionTemplate.FunctionTemplateENName);
 var strFunctionTemplateENName = objFunctionTemplateEN.FunctionTemplateENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionTemplateENName + "'");
 }
 
 if (objFunctionTemplateEN.ProgLangTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFunctionTemplate.ProgLangTypeId);
 var strProgLangTypeId = objFunctionTemplateEN.ProgLangTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLangTypeId + "'");
 }
 
 if (objFunctionTemplateEN.CreateUserId !=  null)
 {
 arrFieldListForInsert.Add(conFunctionTemplate.CreateUserId);
 var strCreateUserId = objFunctionTemplateEN.CreateUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateUserId + "'");
 }
 
 if (objFunctionTemplateEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFunctionTemplate.UpdDate);
 var strUpdDate = objFunctionTemplateEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFunctionTemplateEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFunctionTemplate.UpdUser);
 var strUpdUser = objFunctionTemplateEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objFunctionTemplateEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFunctionTemplate.Memo);
 var strMemo = objFunctionTemplateEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FunctionTemplate");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTemplateDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objFunctionTemplateEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsFunctionTemplateEN objFunctionTemplateEN)
{
 objFunctionTemplateEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunctionTemplateEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFunctionTemplateEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFunctionTemplateEN.FunctionTemplateId !=  null)
 {
 arrFieldListForInsert.Add(conFunctionTemplate.FunctionTemplateId);
 var strFunctionTemplateId = objFunctionTemplateEN.FunctionTemplateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionTemplateId + "'");
 }
 
 if (objFunctionTemplateEN.FunctionTemplateName !=  null)
 {
 arrFieldListForInsert.Add(conFunctionTemplate.FunctionTemplateName);
 var strFunctionTemplateName = objFunctionTemplateEN.FunctionTemplateName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionTemplateName + "'");
 }
 
 if (objFunctionTemplateEN.FunctionTemplateENName !=  null)
 {
 arrFieldListForInsert.Add(conFunctionTemplate.FunctionTemplateENName);
 var strFunctionTemplateENName = objFunctionTemplateEN.FunctionTemplateENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionTemplateENName + "'");
 }
 
 if (objFunctionTemplateEN.ProgLangTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFunctionTemplate.ProgLangTypeId);
 var strProgLangTypeId = objFunctionTemplateEN.ProgLangTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLangTypeId + "'");
 }
 
 if (objFunctionTemplateEN.CreateUserId !=  null)
 {
 arrFieldListForInsert.Add(conFunctionTemplate.CreateUserId);
 var strCreateUserId = objFunctionTemplateEN.CreateUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateUserId + "'");
 }
 
 if (objFunctionTemplateEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFunctionTemplate.UpdDate);
 var strUpdDate = objFunctionTemplateEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFunctionTemplateEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFunctionTemplate.UpdUser);
 var strUpdUser = objFunctionTemplateEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objFunctionTemplateEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFunctionTemplate.Memo);
 var strMemo = objFunctionTemplateEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FunctionTemplate");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTemplateDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objFunctionTemplateEN.FunctionTemplateId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objFunctionTemplateEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsFunctionTemplateEN objFunctionTemplateEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objFunctionTemplateEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunctionTemplateEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFunctionTemplateEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFunctionTemplateEN.FunctionTemplateId !=  null)
 {
 arrFieldListForInsert.Add(conFunctionTemplate.FunctionTemplateId);
 var strFunctionTemplateId = objFunctionTemplateEN.FunctionTemplateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionTemplateId + "'");
 }
 
 if (objFunctionTemplateEN.FunctionTemplateName !=  null)
 {
 arrFieldListForInsert.Add(conFunctionTemplate.FunctionTemplateName);
 var strFunctionTemplateName = objFunctionTemplateEN.FunctionTemplateName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionTemplateName + "'");
 }
 
 if (objFunctionTemplateEN.FunctionTemplateENName !=  null)
 {
 arrFieldListForInsert.Add(conFunctionTemplate.FunctionTemplateENName);
 var strFunctionTemplateENName = objFunctionTemplateEN.FunctionTemplateENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionTemplateENName + "'");
 }
 
 if (objFunctionTemplateEN.ProgLangTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFunctionTemplate.ProgLangTypeId);
 var strProgLangTypeId = objFunctionTemplateEN.ProgLangTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLangTypeId + "'");
 }
 
 if (objFunctionTemplateEN.CreateUserId !=  null)
 {
 arrFieldListForInsert.Add(conFunctionTemplate.CreateUserId);
 var strCreateUserId = objFunctionTemplateEN.CreateUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateUserId + "'");
 }
 
 if (objFunctionTemplateEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFunctionTemplate.UpdDate);
 var strUpdDate = objFunctionTemplateEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFunctionTemplateEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFunctionTemplate.UpdUser);
 var strUpdUser = objFunctionTemplateEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objFunctionTemplateEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFunctionTemplate.Memo);
 var strMemo = objFunctionTemplateEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FunctionTemplate");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTemplateDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objFunctionTemplateEN.FunctionTemplateId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objFunctionTemplateEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsFunctionTemplateEN objFunctionTemplateEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objFunctionTemplateEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunctionTemplateEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFunctionTemplateEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFunctionTemplateEN.FunctionTemplateId !=  null)
 {
 arrFieldListForInsert.Add(conFunctionTemplate.FunctionTemplateId);
 var strFunctionTemplateId = objFunctionTemplateEN.FunctionTemplateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionTemplateId + "'");
 }
 
 if (objFunctionTemplateEN.FunctionTemplateName !=  null)
 {
 arrFieldListForInsert.Add(conFunctionTemplate.FunctionTemplateName);
 var strFunctionTemplateName = objFunctionTemplateEN.FunctionTemplateName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionTemplateName + "'");
 }
 
 if (objFunctionTemplateEN.FunctionTemplateENName !=  null)
 {
 arrFieldListForInsert.Add(conFunctionTemplate.FunctionTemplateENName);
 var strFunctionTemplateENName = objFunctionTemplateEN.FunctionTemplateENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionTemplateENName + "'");
 }
 
 if (objFunctionTemplateEN.ProgLangTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFunctionTemplate.ProgLangTypeId);
 var strProgLangTypeId = objFunctionTemplateEN.ProgLangTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLangTypeId + "'");
 }
 
 if (objFunctionTemplateEN.CreateUserId !=  null)
 {
 arrFieldListForInsert.Add(conFunctionTemplate.CreateUserId);
 var strCreateUserId = objFunctionTemplateEN.CreateUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateUserId + "'");
 }
 
 if (objFunctionTemplateEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFunctionTemplate.UpdDate);
 var strUpdDate = objFunctionTemplateEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFunctionTemplateEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFunctionTemplate.UpdUser);
 var strUpdUser = objFunctionTemplateEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objFunctionTemplateEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFunctionTemplate.Memo);
 var strMemo = objFunctionTemplateEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FunctionTemplate");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTemplateDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewFunctionTemplates(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTemplateDA.GetSpecSQLObj();
strSQL = "Select * from FunctionTemplate where FunctionTemplateId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "FunctionTemplate");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strFunctionTemplateId = oRow[conFunctionTemplate.FunctionTemplateId].ToString().Trim();
if (IsExist(strFunctionTemplateId))
{
 string strResult = "关键字变量值为:" + string.Format("FunctionTemplateId = {0}", strFunctionTemplateId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsFunctionTemplateEN._CurrTabName ].NewRow();
objRow[conFunctionTemplate.FunctionTemplateId] = oRow[conFunctionTemplate.FunctionTemplateId].ToString().Trim(); //函数模板Id
objRow[conFunctionTemplate.FunctionTemplateName] = oRow[conFunctionTemplate.FunctionTemplateName].ToString().Trim(); //函数模板名
objRow[conFunctionTemplate.FunctionTemplateENName] = oRow[conFunctionTemplate.FunctionTemplateENName].ToString().Trim(); //函数模板英文名
objRow[conFunctionTemplate.ProgLangTypeId] = oRow[conFunctionTemplate.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objRow[conFunctionTemplate.CreateUserId] = oRow[conFunctionTemplate.CreateUserId].ToString().Trim(); //建立用户Id
objRow[conFunctionTemplate.UpdDate] = oRow[conFunctionTemplate.UpdDate].ToString().Trim(); //修改日期
objRow[conFunctionTemplate.UpdUser] = oRow[conFunctionTemplate.UpdUser].ToString().Trim(); //修改者
objRow[conFunctionTemplate.Memo] = oRow[conFunctionTemplate.Memo].ToString().Trim(); //说明
 objDS.Tables[clsFunctionTemplateEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsFunctionTemplateEN._CurrTabName);
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
 /// <param name = "objFunctionTemplateEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsFunctionTemplateEN objFunctionTemplateEN)
{
 objFunctionTemplateEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunctionTemplateEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFunctionTemplateEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTemplateDA.GetSpecSQLObj();
strSQL = "Select * from FunctionTemplate where FunctionTemplateId = " + "'"+ objFunctionTemplateEN.FunctionTemplateId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsFunctionTemplateEN._CurrTabName);
if (objDS.Tables[clsFunctionTemplateEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:FunctionTemplateId = " + "'"+ objFunctionTemplateEN.FunctionTemplateId+"'");
return false;
}
objRow = objDS.Tables[clsFunctionTemplateEN._CurrTabName].Rows[0];
 if (objFunctionTemplateEN.IsUpdated(conFunctionTemplate.FunctionTemplateId))
 {
objRow[conFunctionTemplate.FunctionTemplateId] = objFunctionTemplateEN.FunctionTemplateId; //函数模板Id
 }
 if (objFunctionTemplateEN.IsUpdated(conFunctionTemplate.FunctionTemplateName))
 {
objRow[conFunctionTemplate.FunctionTemplateName] = objFunctionTemplateEN.FunctionTemplateName; //函数模板名
 }
 if (objFunctionTemplateEN.IsUpdated(conFunctionTemplate.FunctionTemplateENName))
 {
objRow[conFunctionTemplate.FunctionTemplateENName] = objFunctionTemplateEN.FunctionTemplateENName; //函数模板英文名
 }
 if (objFunctionTemplateEN.IsUpdated(conFunctionTemplate.ProgLangTypeId))
 {
objRow[conFunctionTemplate.ProgLangTypeId] = objFunctionTemplateEN.ProgLangTypeId; //编程语言类型Id
 }
 if (objFunctionTemplateEN.IsUpdated(conFunctionTemplate.CreateUserId))
 {
objRow[conFunctionTemplate.CreateUserId] = objFunctionTemplateEN.CreateUserId; //建立用户Id
 }
 if (objFunctionTemplateEN.IsUpdated(conFunctionTemplate.UpdDate))
 {
objRow[conFunctionTemplate.UpdDate] = objFunctionTemplateEN.UpdDate; //修改日期
 }
 if (objFunctionTemplateEN.IsUpdated(conFunctionTemplate.UpdUser))
 {
objRow[conFunctionTemplate.UpdUser] = objFunctionTemplateEN.UpdUser; //修改者
 }
 if (objFunctionTemplateEN.IsUpdated(conFunctionTemplate.Memo))
 {
objRow[conFunctionTemplate.Memo] = objFunctionTemplateEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsFunctionTemplateEN._CurrTabName);
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
 /// <param name = "objFunctionTemplateEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsFunctionTemplateEN objFunctionTemplateEN)
{
 objFunctionTemplateEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunctionTemplateEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFunctionTemplateEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTemplateDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update FunctionTemplate Set ");
 
 if (objFunctionTemplateEN.IsUpdated(conFunctionTemplate.FunctionTemplateName))
 {
 if (objFunctionTemplateEN.FunctionTemplateName !=  null)
 {
 var strFunctionTemplateName = objFunctionTemplateEN.FunctionTemplateName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFunctionTemplateName, conFunctionTemplate.FunctionTemplateName); //函数模板名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionTemplate.FunctionTemplateName); //函数模板名
 }
 }
 
 if (objFunctionTemplateEN.IsUpdated(conFunctionTemplate.FunctionTemplateENName))
 {
 if (objFunctionTemplateEN.FunctionTemplateENName !=  null)
 {
 var strFunctionTemplateENName = objFunctionTemplateEN.FunctionTemplateENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFunctionTemplateENName, conFunctionTemplate.FunctionTemplateENName); //函数模板英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionTemplate.FunctionTemplateENName); //函数模板英文名
 }
 }
 
 if (objFunctionTemplateEN.IsUpdated(conFunctionTemplate.ProgLangTypeId))
 {
 if (objFunctionTemplateEN.ProgLangTypeId !=  null)
 {
 var strProgLangTypeId = objFunctionTemplateEN.ProgLangTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProgLangTypeId, conFunctionTemplate.ProgLangTypeId); //编程语言类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionTemplate.ProgLangTypeId); //编程语言类型Id
 }
 }
 
 if (objFunctionTemplateEN.IsUpdated(conFunctionTemplate.CreateUserId))
 {
 if (objFunctionTemplateEN.CreateUserId !=  null)
 {
 var strCreateUserId = objFunctionTemplateEN.CreateUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateUserId, conFunctionTemplate.CreateUserId); //建立用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionTemplate.CreateUserId); //建立用户Id
 }
 }
 
 if (objFunctionTemplateEN.IsUpdated(conFunctionTemplate.UpdDate))
 {
 if (objFunctionTemplateEN.UpdDate !=  null)
 {
 var strUpdDate = objFunctionTemplateEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conFunctionTemplate.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionTemplate.UpdDate); //修改日期
 }
 }
 
 if (objFunctionTemplateEN.IsUpdated(conFunctionTemplate.UpdUser))
 {
 if (objFunctionTemplateEN.UpdUser !=  null)
 {
 var strUpdUser = objFunctionTemplateEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conFunctionTemplate.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionTemplate.UpdUser); //修改者
 }
 }
 
 if (objFunctionTemplateEN.IsUpdated(conFunctionTemplate.Memo))
 {
 if (objFunctionTemplateEN.Memo !=  null)
 {
 var strMemo = objFunctionTemplateEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conFunctionTemplate.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionTemplate.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where FunctionTemplateId = '{0}'", objFunctionTemplateEN.FunctionTemplateId); 
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
 /// <param name = "objFunctionTemplateEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsFunctionTemplateEN objFunctionTemplateEN, string strCondition)
{
 objFunctionTemplateEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunctionTemplateEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFunctionTemplateEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTemplateDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FunctionTemplate Set ");
 
 if (objFunctionTemplateEN.IsUpdated(conFunctionTemplate.FunctionTemplateName))
 {
 if (objFunctionTemplateEN.FunctionTemplateName !=  null)
 {
 var strFunctionTemplateName = objFunctionTemplateEN.FunctionTemplateName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FunctionTemplateName = '{0}',", strFunctionTemplateName); //函数模板名
 }
 else
 {
 sbSQL.Append(" FunctionTemplateName = null,"); //函数模板名
 }
 }
 
 if (objFunctionTemplateEN.IsUpdated(conFunctionTemplate.FunctionTemplateENName))
 {
 if (objFunctionTemplateEN.FunctionTemplateENName !=  null)
 {
 var strFunctionTemplateENName = objFunctionTemplateEN.FunctionTemplateENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FunctionTemplateENName = '{0}',", strFunctionTemplateENName); //函数模板英文名
 }
 else
 {
 sbSQL.Append(" FunctionTemplateENName = null,"); //函数模板英文名
 }
 }
 
 if (objFunctionTemplateEN.IsUpdated(conFunctionTemplate.ProgLangTypeId))
 {
 if (objFunctionTemplateEN.ProgLangTypeId !=  null)
 {
 var strProgLangTypeId = objFunctionTemplateEN.ProgLangTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProgLangTypeId = '{0}',", strProgLangTypeId); //编程语言类型Id
 }
 else
 {
 sbSQL.Append(" ProgLangTypeId = null,"); //编程语言类型Id
 }
 }
 
 if (objFunctionTemplateEN.IsUpdated(conFunctionTemplate.CreateUserId))
 {
 if (objFunctionTemplateEN.CreateUserId !=  null)
 {
 var strCreateUserId = objFunctionTemplateEN.CreateUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateUserId = '{0}',", strCreateUserId); //建立用户Id
 }
 else
 {
 sbSQL.Append(" CreateUserId = null,"); //建立用户Id
 }
 }
 
 if (objFunctionTemplateEN.IsUpdated(conFunctionTemplate.UpdDate))
 {
 if (objFunctionTemplateEN.UpdDate !=  null)
 {
 var strUpdDate = objFunctionTemplateEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objFunctionTemplateEN.IsUpdated(conFunctionTemplate.UpdUser))
 {
 if (objFunctionTemplateEN.UpdUser !=  null)
 {
 var strUpdUser = objFunctionTemplateEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objFunctionTemplateEN.IsUpdated(conFunctionTemplate.Memo))
 {
 if (objFunctionTemplateEN.Memo !=  null)
 {
 var strMemo = objFunctionTemplateEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objFunctionTemplateEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsFunctionTemplateEN objFunctionTemplateEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objFunctionTemplateEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunctionTemplateEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFunctionTemplateEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTemplateDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FunctionTemplate Set ");
 
 if (objFunctionTemplateEN.IsUpdated(conFunctionTemplate.FunctionTemplateName))
 {
 if (objFunctionTemplateEN.FunctionTemplateName !=  null)
 {
 var strFunctionTemplateName = objFunctionTemplateEN.FunctionTemplateName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FunctionTemplateName = '{0}',", strFunctionTemplateName); //函数模板名
 }
 else
 {
 sbSQL.Append(" FunctionTemplateName = null,"); //函数模板名
 }
 }
 
 if (objFunctionTemplateEN.IsUpdated(conFunctionTemplate.FunctionTemplateENName))
 {
 if (objFunctionTemplateEN.FunctionTemplateENName !=  null)
 {
 var strFunctionTemplateENName = objFunctionTemplateEN.FunctionTemplateENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FunctionTemplateENName = '{0}',", strFunctionTemplateENName); //函数模板英文名
 }
 else
 {
 sbSQL.Append(" FunctionTemplateENName = null,"); //函数模板英文名
 }
 }
 
 if (objFunctionTemplateEN.IsUpdated(conFunctionTemplate.ProgLangTypeId))
 {
 if (objFunctionTemplateEN.ProgLangTypeId !=  null)
 {
 var strProgLangTypeId = objFunctionTemplateEN.ProgLangTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProgLangTypeId = '{0}',", strProgLangTypeId); //编程语言类型Id
 }
 else
 {
 sbSQL.Append(" ProgLangTypeId = null,"); //编程语言类型Id
 }
 }
 
 if (objFunctionTemplateEN.IsUpdated(conFunctionTemplate.CreateUserId))
 {
 if (objFunctionTemplateEN.CreateUserId !=  null)
 {
 var strCreateUserId = objFunctionTemplateEN.CreateUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateUserId = '{0}',", strCreateUserId); //建立用户Id
 }
 else
 {
 sbSQL.Append(" CreateUserId = null,"); //建立用户Id
 }
 }
 
 if (objFunctionTemplateEN.IsUpdated(conFunctionTemplate.UpdDate))
 {
 if (objFunctionTemplateEN.UpdDate !=  null)
 {
 var strUpdDate = objFunctionTemplateEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objFunctionTemplateEN.IsUpdated(conFunctionTemplate.UpdUser))
 {
 if (objFunctionTemplateEN.UpdUser !=  null)
 {
 var strUpdUser = objFunctionTemplateEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objFunctionTemplateEN.IsUpdated(conFunctionTemplate.Memo))
 {
 if (objFunctionTemplateEN.Memo !=  null)
 {
 var strMemo = objFunctionTemplateEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objFunctionTemplateEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsFunctionTemplateEN objFunctionTemplateEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objFunctionTemplateEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunctionTemplateEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFunctionTemplateEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTemplateDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FunctionTemplate Set ");
 
 if (objFunctionTemplateEN.IsUpdated(conFunctionTemplate.FunctionTemplateName))
 {
 if (objFunctionTemplateEN.FunctionTemplateName !=  null)
 {
 var strFunctionTemplateName = objFunctionTemplateEN.FunctionTemplateName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFunctionTemplateName, conFunctionTemplate.FunctionTemplateName); //函数模板名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionTemplate.FunctionTemplateName); //函数模板名
 }
 }
 
 if (objFunctionTemplateEN.IsUpdated(conFunctionTemplate.FunctionTemplateENName))
 {
 if (objFunctionTemplateEN.FunctionTemplateENName !=  null)
 {
 var strFunctionTemplateENName = objFunctionTemplateEN.FunctionTemplateENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFunctionTemplateENName, conFunctionTemplate.FunctionTemplateENName); //函数模板英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionTemplate.FunctionTemplateENName); //函数模板英文名
 }
 }
 
 if (objFunctionTemplateEN.IsUpdated(conFunctionTemplate.ProgLangTypeId))
 {
 if (objFunctionTemplateEN.ProgLangTypeId !=  null)
 {
 var strProgLangTypeId = objFunctionTemplateEN.ProgLangTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProgLangTypeId, conFunctionTemplate.ProgLangTypeId); //编程语言类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionTemplate.ProgLangTypeId); //编程语言类型Id
 }
 }
 
 if (objFunctionTemplateEN.IsUpdated(conFunctionTemplate.CreateUserId))
 {
 if (objFunctionTemplateEN.CreateUserId !=  null)
 {
 var strCreateUserId = objFunctionTemplateEN.CreateUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateUserId, conFunctionTemplate.CreateUserId); //建立用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionTemplate.CreateUserId); //建立用户Id
 }
 }
 
 if (objFunctionTemplateEN.IsUpdated(conFunctionTemplate.UpdDate))
 {
 if (objFunctionTemplateEN.UpdDate !=  null)
 {
 var strUpdDate = objFunctionTemplateEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conFunctionTemplate.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionTemplate.UpdDate); //修改日期
 }
 }
 
 if (objFunctionTemplateEN.IsUpdated(conFunctionTemplate.UpdUser))
 {
 if (objFunctionTemplateEN.UpdUser !=  null)
 {
 var strUpdUser = objFunctionTemplateEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conFunctionTemplate.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionTemplate.UpdUser); //修改者
 }
 }
 
 if (objFunctionTemplateEN.IsUpdated(conFunctionTemplate.Memo))
 {
 if (objFunctionTemplateEN.Memo !=  null)
 {
 var strMemo = objFunctionTemplateEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conFunctionTemplate.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionTemplate.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where FunctionTemplateId = '{0}'", objFunctionTemplateEN.FunctionTemplateId); 
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
 /// <param name = "strFunctionTemplateId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strFunctionTemplateId) 
{
CheckPrimaryKey(strFunctionTemplateId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTemplateDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strFunctionTemplateId,
};
 objSQL.ExecSP("FunctionTemplate_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strFunctionTemplateId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strFunctionTemplateId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strFunctionTemplateId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTemplateDA.GetSpecSQLObj();
//删除FunctionTemplate本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FunctionTemplate where FunctionTemplateId = " + "'"+ strFunctionTemplateId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelFunctionTemplate(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTemplateDA.GetSpecSQLObj();
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
//删除FunctionTemplate本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FunctionTemplate where FunctionTemplateId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strFunctionTemplateId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strFunctionTemplateId) 
{
CheckPrimaryKey(strFunctionTemplateId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTemplateDA.GetSpecSQLObj();
//删除FunctionTemplate本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FunctionTemplate where FunctionTemplateId = " + "'"+ strFunctionTemplateId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelFunctionTemplate(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsFunctionTemplateDA: DelFunctionTemplate)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTemplateDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from FunctionTemplate where " + strCondition ;
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
public bool DelFunctionTemplateWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsFunctionTemplateDA: DelFunctionTemplateWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTemplateDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from FunctionTemplate where " + strCondition ;
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
 /// <param name = "objFunctionTemplateENS">源对象</param>
 /// <param name = "objFunctionTemplateENT">目标对象</param>
public void CopyTo(clsFunctionTemplateEN objFunctionTemplateENS, clsFunctionTemplateEN objFunctionTemplateENT)
{
objFunctionTemplateENT.FunctionTemplateId = objFunctionTemplateENS.FunctionTemplateId; //函数模板Id
objFunctionTemplateENT.FunctionTemplateName = objFunctionTemplateENS.FunctionTemplateName; //函数模板名
objFunctionTemplateENT.FunctionTemplateENName = objFunctionTemplateENS.FunctionTemplateENName; //函数模板英文名
objFunctionTemplateENT.ProgLangTypeId = objFunctionTemplateENS.ProgLangTypeId; //编程语言类型Id
objFunctionTemplateENT.CreateUserId = objFunctionTemplateENS.CreateUserId; //建立用户Id
objFunctionTemplateENT.UpdDate = objFunctionTemplateENS.UpdDate; //修改日期
objFunctionTemplateENT.UpdUser = objFunctionTemplateENS.UpdUser; //修改者
objFunctionTemplateENT.Memo = objFunctionTemplateENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsFunctionTemplateEN objFunctionTemplateEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objFunctionTemplateEN.FunctionTemplateName, conFunctionTemplate.FunctionTemplateName);
clsCheckSql.CheckFieldNotNull(objFunctionTemplateEN.FunctionTemplateENName, conFunctionTemplate.FunctionTemplateENName);
clsCheckSql.CheckFieldNotNull(objFunctionTemplateEN.ProgLangTypeId, conFunctionTemplate.ProgLangTypeId);
clsCheckSql.CheckFieldNotNull(objFunctionTemplateEN.CreateUserId, conFunctionTemplate.CreateUserId);
//检查字段长度
clsCheckSql.CheckFieldLen(objFunctionTemplateEN.FunctionTemplateId, 4, conFunctionTemplate.FunctionTemplateId);
clsCheckSql.CheckFieldLen(objFunctionTemplateEN.FunctionTemplateName, 50, conFunctionTemplate.FunctionTemplateName);
clsCheckSql.CheckFieldLen(objFunctionTemplateEN.FunctionTemplateENName, 50, conFunctionTemplate.FunctionTemplateENName);
clsCheckSql.CheckFieldLen(objFunctionTemplateEN.ProgLangTypeId, 2, conFunctionTemplate.ProgLangTypeId);
clsCheckSql.CheckFieldLen(objFunctionTemplateEN.CreateUserId, 18, conFunctionTemplate.CreateUserId);
clsCheckSql.CheckFieldLen(objFunctionTemplateEN.UpdDate, 20, conFunctionTemplate.UpdDate);
clsCheckSql.CheckFieldLen(objFunctionTemplateEN.UpdUser, 20, conFunctionTemplate.UpdUser);
clsCheckSql.CheckFieldLen(objFunctionTemplateEN.Memo, 1000, conFunctionTemplate.Memo);
//检查字段外键固定长度
 objFunctionTemplateEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsFunctionTemplateEN objFunctionTemplateEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objFunctionTemplateEN.FunctionTemplateName, 50, conFunctionTemplate.FunctionTemplateName);
clsCheckSql.CheckFieldLen(objFunctionTemplateEN.FunctionTemplateENName, 50, conFunctionTemplate.FunctionTemplateENName);
clsCheckSql.CheckFieldLen(objFunctionTemplateEN.ProgLangTypeId, 2, conFunctionTemplate.ProgLangTypeId);
clsCheckSql.CheckFieldLen(objFunctionTemplateEN.CreateUserId, 18, conFunctionTemplate.CreateUserId);
clsCheckSql.CheckFieldLen(objFunctionTemplateEN.UpdDate, 20, conFunctionTemplate.UpdDate);
clsCheckSql.CheckFieldLen(objFunctionTemplateEN.UpdUser, 20, conFunctionTemplate.UpdUser);
clsCheckSql.CheckFieldLen(objFunctionTemplateEN.Memo, 1000, conFunctionTemplate.Memo);
//检查外键字段长度
 objFunctionTemplateEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsFunctionTemplateEN objFunctionTemplateEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objFunctionTemplateEN.FunctionTemplateId, 4, conFunctionTemplate.FunctionTemplateId);
clsCheckSql.CheckFieldLen(objFunctionTemplateEN.FunctionTemplateName, 50, conFunctionTemplate.FunctionTemplateName);
clsCheckSql.CheckFieldLen(objFunctionTemplateEN.FunctionTemplateENName, 50, conFunctionTemplate.FunctionTemplateENName);
clsCheckSql.CheckFieldLen(objFunctionTemplateEN.ProgLangTypeId, 2, conFunctionTemplate.ProgLangTypeId);
clsCheckSql.CheckFieldLen(objFunctionTemplateEN.CreateUserId, 18, conFunctionTemplate.CreateUserId);
clsCheckSql.CheckFieldLen(objFunctionTemplateEN.UpdDate, 20, conFunctionTemplate.UpdDate);
clsCheckSql.CheckFieldLen(objFunctionTemplateEN.UpdUser, 20, conFunctionTemplate.UpdUser);
clsCheckSql.CheckFieldLen(objFunctionTemplateEN.Memo, 1000, conFunctionTemplate.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objFunctionTemplateEN.FunctionTemplateId, conFunctionTemplate.FunctionTemplateId);
clsCheckSql.CheckSqlInjection4Field(objFunctionTemplateEN.FunctionTemplateName, conFunctionTemplate.FunctionTemplateName);
clsCheckSql.CheckSqlInjection4Field(objFunctionTemplateEN.FunctionTemplateENName, conFunctionTemplate.FunctionTemplateENName);
clsCheckSql.CheckSqlInjection4Field(objFunctionTemplateEN.ProgLangTypeId, conFunctionTemplate.ProgLangTypeId);
clsCheckSql.CheckSqlInjection4Field(objFunctionTemplateEN.CreateUserId, conFunctionTemplate.CreateUserId);
clsCheckSql.CheckSqlInjection4Field(objFunctionTemplateEN.UpdDate, conFunctionTemplate.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objFunctionTemplateEN.UpdUser, conFunctionTemplate.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objFunctionTemplateEN.Memo, conFunctionTemplate.Memo);
//检查外键字段长度
 objFunctionTemplateEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetFunctionTemplateId()
{
//获取某学院所有专业信息
string strSQL = "select FunctionTemplateId, FunctionTemplateName from FunctionTemplate ";
 clsSpecSQLforSql mySql = clsFunctionTemplateDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--FunctionTemplate(函数模板),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objFunctionTemplateEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsFunctionTemplateEN objFunctionTemplateEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FunctionTemplateName = '{0}'", objFunctionTemplateEN.FunctionTemplateName);
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
 objSQL = clsFunctionTemplateDA.GetSpecSQLObj();
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
 objSQL = clsFunctionTemplateDA.GetSpecSQLObj();
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
 objSQL = clsFunctionTemplateDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsFunctionTemplateEN._CurrTabName);
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
 objSQL = clsFunctionTemplateDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsFunctionTemplateEN._CurrTabName, strCondition);
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
 objSQL = clsFunctionTemplateDA.GetSpecSQLObj();
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
 objSQL = clsFunctionTemplateDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}