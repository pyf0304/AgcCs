
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCMClassDA
 表名:CMClass(00050501)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:03:46
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
 /// CM类(CMClass)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsCMClassDA : clsCommBase4DA
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
 return clsCMClassEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsCMClassEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCMClassEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsCMClassEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsCMClassEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strCmClassId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strCmClassId)
{
strCmClassId = strCmClassId.Replace("'", "''");
if (strCmClassId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:CMClass中,检查关键字,长度不正确!(clsCMClassDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strCmClassId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:CMClass中,关键字不能为空 或 null!(clsCMClassDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCmClassId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsCMClassDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsCMClassDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMClassDA.GetSpecSQLObj();
strSQL = "Select * from CMClass where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_CMClass(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsCMClassDA: GetDataTable_CMClass)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMClassDA.GetSpecSQLObj();
strSQL = "Select * from CMClass where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsCMClassDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMClassDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsCMClassDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMClassDA.GetSpecSQLObj();
strSQL = "Select * from CMClass where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsCMClassDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMClassDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsCMClassDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMClassDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CMClass where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CMClass where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsCMClassDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMClassDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from CMClass where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsCMClassDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMClassDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} CMClass.* " + 
$"from CMClass " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and CMClass.CmClassId not in " + 
$"(Select top {intTop_In} CMClass.CmClassId from CMClass " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CMClass where {1} and CmClassId not in (Select top {2} CmClassId from CMClass where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CMClass where {1} and CmClassId not in (Select top {3} CmClassId from CMClass where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsCMClassDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMClassDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} CMClass.* " + 
$"from CMClass " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and CMClass.CmClassId not in " + 
$"(Select top {intTop_In} CMClass.CmClassId from CMClass " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CMClass where {1} and CmClassId not in (Select top {2} CmClassId from CMClass where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CMClass where {1} and CmClassId not in (Select top {3} CmClassId from CMClass where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsCMClassEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsCMClassDA:GetObjLst)", objException.Message));
}
List<clsCMClassEN> arrObjLst = new List<clsCMClassEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMClassDA.GetSpecSQLObj();
strSQL = "Select * from CMClass where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMClassEN objCMClassEN = new clsCMClassEN();
try
{
objCMClassEN.CmClassId = objRow[conCMClass.CmClassId].ToString().Trim(); //类Id
objCMClassEN.ApplicationTypeId = TransNullToInt(objRow[conCMClass.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objCMClassEN.ProgLangTypeId = objRow[conCMClass.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objCMClassEN.TabName = objRow[conCMClass.TabName] == DBNull.Value ? null : objRow[conCMClass.TabName].ToString().Trim(); //表名
objCMClassEN.NameSpace = objRow[conCMClass.NameSpace] == DBNull.Value ? null : objRow[conCMClass.NameSpace].ToString().Trim(); //域名
objCMClassEN.ProjectPath = objRow[conCMClass.ProjectPath].ToString().Trim(); //工程路径
objCMClassEN.FilePath = objRow[conCMClass.FilePath].ToString().Trim(); //文件路径
objCMClassEN.FileName = objRow[conCMClass.FileName].ToString().Trim(); //文件名
objCMClassEN.FileText = objRow[conCMClass.FileText] == DBNull.Value ? null : objRow[conCMClass.FileText].ToString().Trim(); //文件内容
objCMClassEN.FuncModuleAgcId = objRow[conCMClass.FuncModuleAgcId] == DBNull.Value ? null : objRow[conCMClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objCMClassEN.CodeTypeId = objRow[conCMClass.CodeTypeId].ToString().Trim(); //代码类型Id
objCMClassEN.UserId = objRow[conCMClass.UserId] == DBNull.Value ? null : objRow[conCMClass.UserId].ToString().Trim(); //用户Id
objCMClassEN.PrjId = objRow[conCMClass.PrjId].ToString().Trim(); //工程Id
objCMClassEN.IsOpen = TransNullToBool(objRow[conCMClass.IsOpen].ToString().Trim()); //是否开放
objCMClassEN.UpdDate = objRow[conCMClass.UpdDate] == DBNull.Value ? null : objRow[conCMClass.UpdDate].ToString().Trim(); //修改日期
objCMClassEN.UpdUser = objRow[conCMClass.UpdUser] == DBNull.Value ? null : objRow[conCMClass.UpdUser].ToString().Trim(); //修改者
objCMClassEN.Memo = objRow[conCMClass.Memo] == DBNull.Value ? null : objRow[conCMClass.Memo].ToString().Trim(); //说明
objCMClassEN.ClsName = objRow[conCMClass.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCMClassDA: GetObjLst)", objException.Message));
}
objCMClassEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCMClassEN);
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
public List<clsCMClassEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsCMClassDA:GetObjLstByTabName)", objException.Message));
}
List<clsCMClassEN> arrObjLst = new List<clsCMClassEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMClassDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMClassEN objCMClassEN = new clsCMClassEN();
try
{
objCMClassEN.CmClassId = objRow[conCMClass.CmClassId].ToString().Trim(); //类Id
objCMClassEN.ApplicationTypeId = TransNullToInt(objRow[conCMClass.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objCMClassEN.ProgLangTypeId = objRow[conCMClass.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objCMClassEN.TabName = objRow[conCMClass.TabName] == DBNull.Value ? null : objRow[conCMClass.TabName].ToString().Trim(); //表名
objCMClassEN.NameSpace = objRow[conCMClass.NameSpace] == DBNull.Value ? null : objRow[conCMClass.NameSpace].ToString().Trim(); //域名
objCMClassEN.ProjectPath = objRow[conCMClass.ProjectPath].ToString().Trim(); //工程路径
objCMClassEN.FilePath = objRow[conCMClass.FilePath].ToString().Trim(); //文件路径
objCMClassEN.FileName = objRow[conCMClass.FileName].ToString().Trim(); //文件名
objCMClassEN.FileText = objRow[conCMClass.FileText] == DBNull.Value ? null : objRow[conCMClass.FileText].ToString().Trim(); //文件内容
objCMClassEN.FuncModuleAgcId = objRow[conCMClass.FuncModuleAgcId] == DBNull.Value ? null : objRow[conCMClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objCMClassEN.CodeTypeId = objRow[conCMClass.CodeTypeId].ToString().Trim(); //代码类型Id
objCMClassEN.UserId = objRow[conCMClass.UserId] == DBNull.Value ? null : objRow[conCMClass.UserId].ToString().Trim(); //用户Id
objCMClassEN.PrjId = objRow[conCMClass.PrjId].ToString().Trim(); //工程Id
objCMClassEN.IsOpen = TransNullToBool(objRow[conCMClass.IsOpen].ToString().Trim()); //是否开放
objCMClassEN.UpdDate = objRow[conCMClass.UpdDate] == DBNull.Value ? null : objRow[conCMClass.UpdDate].ToString().Trim(); //修改日期
objCMClassEN.UpdUser = objRow[conCMClass.UpdUser] == DBNull.Value ? null : objRow[conCMClass.UpdUser].ToString().Trim(); //修改者
objCMClassEN.Memo = objRow[conCMClass.Memo] == DBNull.Value ? null : objRow[conCMClass.Memo].ToString().Trim(); //说明
objCMClassEN.ClsName = objRow[conCMClass.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCMClassDA: GetObjLst)", objException.Message));
}
objCMClassEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCMClassEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objCMClassEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetCMClass(ref clsCMClassEN objCMClassEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMClassDA.GetSpecSQLObj();
strSQL = "Select * from CMClass where CmClassId = " + "'"+ objCMClassEN.CmClassId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objCMClassEN.CmClassId = objDT.Rows[0][conCMClass.CmClassId].ToString().Trim(); //类Id(字段类型:char,字段长度:8,是否可空:False)
 objCMClassEN.ApplicationTypeId = TransNullToInt(objDT.Rows[0][conCMClass.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objCMClassEN.ProgLangTypeId = objDT.Rows[0][conCMClass.ProgLangTypeId].ToString().Trim(); //编程语言类型Id(字段类型:char,字段长度:2,是否可空:False)
 objCMClassEN.TabName = objDT.Rows[0][conCMClass.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objCMClassEN.NameSpace = objDT.Rows[0][conCMClass.NameSpace].ToString().Trim(); //域名(字段类型:varchar,字段长度:50,是否可空:True)
 objCMClassEN.ProjectPath = objDT.Rows[0][conCMClass.ProjectPath].ToString().Trim(); //工程路径(字段类型:varchar,字段长度:500,是否可空:False)
 objCMClassEN.FilePath = objDT.Rows[0][conCMClass.FilePath].ToString().Trim(); //文件路径(字段类型:varchar,字段长度:500,是否可空:False)
 objCMClassEN.FileName = objDT.Rows[0][conCMClass.FileName].ToString().Trim(); //文件名(字段类型:varchar,字段长度:150,是否可空:False)
 objCMClassEN.FileText = objDT.Rows[0][conCMClass.FileText].ToString().Trim(); //文件内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objCMClassEN.FuncModuleAgcId = objDT.Rows[0][conCMClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objCMClassEN.CodeTypeId = objDT.Rows[0][conCMClass.CodeTypeId].ToString().Trim(); //代码类型Id(字段类型:char,字段长度:4,是否可空:False)
 objCMClassEN.UserId = objDT.Rows[0][conCMClass.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objCMClassEN.PrjId = objDT.Rows[0][conCMClass.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objCMClassEN.IsOpen = TransNullToBool(objDT.Rows[0][conCMClass.IsOpen].ToString().Trim()); //是否开放(字段类型:bit,字段长度:1,是否可空:True)
 objCMClassEN.UpdDate = objDT.Rows[0][conCMClass.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCMClassEN.UpdUser = objDT.Rows[0][conCMClass.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objCMClassEN.Memo = objDT.Rows[0][conCMClass.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objCMClassEN.ClsName = objDT.Rows[0][conCMClass.ClsName].ToString().Trim(); //类名(字段类型:varchar,字段长度:100,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsCMClassDA: GetCMClass)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCmClassId">表关键字</param>
 /// <returns>表对象</returns>
public clsCMClassEN GetObjByCmClassId(string strCmClassId)
{
CheckPrimaryKey(strCmClassId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMClassDA.GetSpecSQLObj();
strSQL = "Select * from CMClass where CmClassId = " + "'"+ strCmClassId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsCMClassEN objCMClassEN = new clsCMClassEN();
try
{
 objCMClassEN.CmClassId = objRow[conCMClass.CmClassId].ToString().Trim(); //类Id(字段类型:char,字段长度:8,是否可空:False)
 objCMClassEN.ApplicationTypeId = Int32.Parse(objRow[conCMClass.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objCMClassEN.ProgLangTypeId = objRow[conCMClass.ProgLangTypeId].ToString().Trim(); //编程语言类型Id(字段类型:char,字段长度:2,是否可空:False)
 objCMClassEN.TabName = objRow[conCMClass.TabName] == DBNull.Value ? null : objRow[conCMClass.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objCMClassEN.NameSpace = objRow[conCMClass.NameSpace] == DBNull.Value ? null : objRow[conCMClass.NameSpace].ToString().Trim(); //域名(字段类型:varchar,字段长度:50,是否可空:True)
 objCMClassEN.ProjectPath = objRow[conCMClass.ProjectPath].ToString().Trim(); //工程路径(字段类型:varchar,字段长度:500,是否可空:False)
 objCMClassEN.FilePath = objRow[conCMClass.FilePath].ToString().Trim(); //文件路径(字段类型:varchar,字段长度:500,是否可空:False)
 objCMClassEN.FileName = objRow[conCMClass.FileName].ToString().Trim(); //文件名(字段类型:varchar,字段长度:150,是否可空:False)
 objCMClassEN.FileText = objRow[conCMClass.FileText] == DBNull.Value ? null : objRow[conCMClass.FileText].ToString().Trim(); //文件内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objCMClassEN.FuncModuleAgcId = objRow[conCMClass.FuncModuleAgcId] == DBNull.Value ? null : objRow[conCMClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objCMClassEN.CodeTypeId = objRow[conCMClass.CodeTypeId].ToString().Trim(); //代码类型Id(字段类型:char,字段长度:4,是否可空:False)
 objCMClassEN.UserId = objRow[conCMClass.UserId] == DBNull.Value ? null : objRow[conCMClass.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objCMClassEN.PrjId = objRow[conCMClass.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objCMClassEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[conCMClass.IsOpen].ToString().Trim()); //是否开放(字段类型:bit,字段长度:1,是否可空:True)
 objCMClassEN.UpdDate = objRow[conCMClass.UpdDate] == DBNull.Value ? null : objRow[conCMClass.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCMClassEN.UpdUser = objRow[conCMClass.UpdUser] == DBNull.Value ? null : objRow[conCMClass.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objCMClassEN.Memo = objRow[conCMClass.Memo] == DBNull.Value ? null : objRow[conCMClass.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objCMClassEN.ClsName = objRow[conCMClass.ClsName].ToString().Trim(); //类名(字段类型:varchar,字段长度:100,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsCMClassDA: GetObjByCmClassId)", objException.Message));
}
return objCMClassEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsCMClassEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsCMClassDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMClassDA.GetSpecSQLObj();
strSQL = "Select * from CMClass where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsCMClassEN objCMClassEN = new clsCMClassEN()
{
CmClassId = objRow[conCMClass.CmClassId].ToString().Trim(), //类Id
ApplicationTypeId = TransNullToInt(objRow[conCMClass.ApplicationTypeId].ToString().Trim()), //应用程序类型ID
ProgLangTypeId = objRow[conCMClass.ProgLangTypeId].ToString().Trim(), //编程语言类型Id
TabName = objRow[conCMClass.TabName] == DBNull.Value ? null : objRow[conCMClass.TabName].ToString().Trim(), //表名
NameSpace = objRow[conCMClass.NameSpace] == DBNull.Value ? null : objRow[conCMClass.NameSpace].ToString().Trim(), //域名
ProjectPath = objRow[conCMClass.ProjectPath].ToString().Trim(), //工程路径
FilePath = objRow[conCMClass.FilePath].ToString().Trim(), //文件路径
FileName = objRow[conCMClass.FileName].ToString().Trim(), //文件名
FileText = objRow[conCMClass.FileText] == DBNull.Value ? null : objRow[conCMClass.FileText].ToString().Trim(), //文件内容
FuncModuleAgcId = objRow[conCMClass.FuncModuleAgcId] == DBNull.Value ? null : objRow[conCMClass.FuncModuleAgcId].ToString().Trim(), //功能模块Id
CodeTypeId = objRow[conCMClass.CodeTypeId].ToString().Trim(), //代码类型Id
UserId = objRow[conCMClass.UserId] == DBNull.Value ? null : objRow[conCMClass.UserId].ToString().Trim(), //用户Id
PrjId = objRow[conCMClass.PrjId].ToString().Trim(), //工程Id
IsOpen = TransNullToBool(objRow[conCMClass.IsOpen].ToString().Trim()), //是否开放
UpdDate = objRow[conCMClass.UpdDate] == DBNull.Value ? null : objRow[conCMClass.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conCMClass.UpdUser] == DBNull.Value ? null : objRow[conCMClass.UpdUser].ToString().Trim(), //修改者
Memo = objRow[conCMClass.Memo] == DBNull.Value ? null : objRow[conCMClass.Memo].ToString().Trim(), //说明
ClsName = objRow[conCMClass.ClsName].ToString().Trim() //类名
};
objCMClassEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCMClassEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsCMClassDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsCMClassEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCMClassEN objCMClassEN = new clsCMClassEN();
try
{
objCMClassEN.CmClassId = objRow[conCMClass.CmClassId].ToString().Trim(); //类Id
objCMClassEN.ApplicationTypeId = TransNullToInt(objRow[conCMClass.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objCMClassEN.ProgLangTypeId = objRow[conCMClass.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objCMClassEN.TabName = objRow[conCMClass.TabName] == DBNull.Value ? null : objRow[conCMClass.TabName].ToString().Trim(); //表名
objCMClassEN.NameSpace = objRow[conCMClass.NameSpace] == DBNull.Value ? null : objRow[conCMClass.NameSpace].ToString().Trim(); //域名
objCMClassEN.ProjectPath = objRow[conCMClass.ProjectPath].ToString().Trim(); //工程路径
objCMClassEN.FilePath = objRow[conCMClass.FilePath].ToString().Trim(); //文件路径
objCMClassEN.FileName = objRow[conCMClass.FileName].ToString().Trim(); //文件名
objCMClassEN.FileText = objRow[conCMClass.FileText] == DBNull.Value ? null : objRow[conCMClass.FileText].ToString().Trim(); //文件内容
objCMClassEN.FuncModuleAgcId = objRow[conCMClass.FuncModuleAgcId] == DBNull.Value ? null : objRow[conCMClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objCMClassEN.CodeTypeId = objRow[conCMClass.CodeTypeId].ToString().Trim(); //代码类型Id
objCMClassEN.UserId = objRow[conCMClass.UserId] == DBNull.Value ? null : objRow[conCMClass.UserId].ToString().Trim(); //用户Id
objCMClassEN.PrjId = objRow[conCMClass.PrjId].ToString().Trim(); //工程Id
objCMClassEN.IsOpen = TransNullToBool(objRow[conCMClass.IsOpen].ToString().Trim()); //是否开放
objCMClassEN.UpdDate = objRow[conCMClass.UpdDate] == DBNull.Value ? null : objRow[conCMClass.UpdDate].ToString().Trim(); //修改日期
objCMClassEN.UpdUser = objRow[conCMClass.UpdUser] == DBNull.Value ? null : objRow[conCMClass.UpdUser].ToString().Trim(); //修改者
objCMClassEN.Memo = objRow[conCMClass.Memo] == DBNull.Value ? null : objRow[conCMClass.Memo].ToString().Trim(); //说明
objCMClassEN.ClsName = objRow[conCMClass.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsCMClassDA: GetObjByDataRowCMClass)", objException.Message));
}
objCMClassEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCMClassEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsCMClassEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCMClassEN objCMClassEN = new clsCMClassEN();
try
{
objCMClassEN.CmClassId = objRow[conCMClass.CmClassId].ToString().Trim(); //类Id
objCMClassEN.ApplicationTypeId = TransNullToInt(objRow[conCMClass.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objCMClassEN.ProgLangTypeId = objRow[conCMClass.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objCMClassEN.TabName = objRow[conCMClass.TabName] == DBNull.Value ? null : objRow[conCMClass.TabName].ToString().Trim(); //表名
objCMClassEN.NameSpace = objRow[conCMClass.NameSpace] == DBNull.Value ? null : objRow[conCMClass.NameSpace].ToString().Trim(); //域名
objCMClassEN.ProjectPath = objRow[conCMClass.ProjectPath].ToString().Trim(); //工程路径
objCMClassEN.FilePath = objRow[conCMClass.FilePath].ToString().Trim(); //文件路径
objCMClassEN.FileName = objRow[conCMClass.FileName].ToString().Trim(); //文件名
objCMClassEN.FileText = objRow[conCMClass.FileText] == DBNull.Value ? null : objRow[conCMClass.FileText].ToString().Trim(); //文件内容
objCMClassEN.FuncModuleAgcId = objRow[conCMClass.FuncModuleAgcId] == DBNull.Value ? null : objRow[conCMClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objCMClassEN.CodeTypeId = objRow[conCMClass.CodeTypeId].ToString().Trim(); //代码类型Id
objCMClassEN.UserId = objRow[conCMClass.UserId] == DBNull.Value ? null : objRow[conCMClass.UserId].ToString().Trim(); //用户Id
objCMClassEN.PrjId = objRow[conCMClass.PrjId].ToString().Trim(); //工程Id
objCMClassEN.IsOpen = TransNullToBool(objRow[conCMClass.IsOpen].ToString().Trim()); //是否开放
objCMClassEN.UpdDate = objRow[conCMClass.UpdDate] == DBNull.Value ? null : objRow[conCMClass.UpdDate].ToString().Trim(); //修改日期
objCMClassEN.UpdUser = objRow[conCMClass.UpdUser] == DBNull.Value ? null : objRow[conCMClass.UpdUser].ToString().Trim(); //修改者
objCMClassEN.Memo = objRow[conCMClass.Memo] == DBNull.Value ? null : objRow[conCMClass.Memo].ToString().Trim(); //说明
objCMClassEN.ClsName = objRow[conCMClass.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsCMClassDA: GetObjByDataRow)", objException.Message));
}
objCMClassEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCMClassEN;
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
objSQL = clsCMClassDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCMClassEN._CurrTabName, conCMClass.CmClassId, 8, "");
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
objSQL = clsCMClassDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCMClassEN._CurrTabName, conCMClass.CmClassId, 8, strPrefix);
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
 objSQL = clsCMClassDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select CmClassId from CMClass where " + strCondition;
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
 objSQL = clsCMClassDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select CmClassId from CMClass where " + strCondition;
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
 /// <param name = "strCmClassId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strCmClassId)
{
CheckPrimaryKey(strCmClassId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMClassDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CMClass", "CmClassId = " + "'"+ strCmClassId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsCMClassDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMClassDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CMClass", strCondition))
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
objSQL = clsCMClassDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("CMClass");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsCMClassEN objCMClassEN)
 {
 objCMClassEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMClassEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCMClassEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMClassDA.GetSpecSQLObj();
strSQL = "Select * from CMClass where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CMClass");
objRow = objDS.Tables["CMClass"].NewRow();
objRow[conCMClass.CmClassId] = objCMClassEN.CmClassId; //类Id
objRow[conCMClass.ApplicationTypeId] = objCMClassEN.ApplicationTypeId; //应用程序类型ID
objRow[conCMClass.ProgLangTypeId] = objCMClassEN.ProgLangTypeId; //编程语言类型Id
 if (objCMClassEN.TabName !=  "")
 {
objRow[conCMClass.TabName] = objCMClassEN.TabName; //表名
 }
 if (objCMClassEN.NameSpace !=  "")
 {
objRow[conCMClass.NameSpace] = objCMClassEN.NameSpace; //域名
 }
objRow[conCMClass.ProjectPath] = objCMClassEN.ProjectPath; //工程路径
objRow[conCMClass.FilePath] = objCMClassEN.FilePath; //文件路径
objRow[conCMClass.FileName] = objCMClassEN.FileName; //文件名
 if (objCMClassEN.FileText !=  "")
 {
objRow[conCMClass.FileText] = objCMClassEN.FileText; //文件内容
 }
 if (objCMClassEN.FuncModuleAgcId !=  "")
 {
objRow[conCMClass.FuncModuleAgcId] = objCMClassEN.FuncModuleAgcId; //功能模块Id
 }
objRow[conCMClass.CodeTypeId] = objCMClassEN.CodeTypeId; //代码类型Id
 if (objCMClassEN.UserId !=  "")
 {
objRow[conCMClass.UserId] = objCMClassEN.UserId; //用户Id
 }
objRow[conCMClass.PrjId] = objCMClassEN.PrjId; //工程Id
objRow[conCMClass.IsOpen] = objCMClassEN.IsOpen; //是否开放
 if (objCMClassEN.UpdDate !=  "")
 {
objRow[conCMClass.UpdDate] = objCMClassEN.UpdDate; //修改日期
 }
 if (objCMClassEN.UpdUser !=  "")
 {
objRow[conCMClass.UpdUser] = objCMClassEN.UpdUser; //修改者
 }
 if (objCMClassEN.Memo !=  "")
 {
objRow[conCMClass.Memo] = objCMClassEN.Memo; //说明
 }
objRow[conCMClass.ClsName] = objCMClassEN.ClsName; //类名
objDS.Tables[clsCMClassEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsCMClassEN._CurrTabName);
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
 /// <param name = "objCMClassEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCMClassEN objCMClassEN)
{
 objCMClassEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMClassEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCMClassEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCMClassEN.CmClassId !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.CmClassId);
 var strCmClassId = objCMClassEN.CmClassId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmClassId + "'");
 }
 
 arrFieldListForInsert.Add(conCMClass.ApplicationTypeId);
 arrValueListForInsert.Add(objCMClassEN.ApplicationTypeId.ToString());
 
 if (objCMClassEN.ProgLangTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.ProgLangTypeId);
 var strProgLangTypeId = objCMClassEN.ProgLangTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLangTypeId + "'");
 }
 
 if (objCMClassEN.TabName !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.TabName);
 var strTabName = objCMClassEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabName + "'");
 }
 
 if (objCMClassEN.NameSpace !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.NameSpace);
 var strNameSpace = objCMClassEN.NameSpace.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNameSpace + "'");
 }
 
 if (objCMClassEN.ProjectPath !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.ProjectPath);
 var strProjectPath = objCMClassEN.ProjectPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProjectPath + "'");
 }
 
 if (objCMClassEN.FilePath !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.FilePath);
 var strFilePath = objCMClassEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFilePath + "'");
 }
 
 if (objCMClassEN.FileName !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.FileName);
 var strFileName = objCMClassEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileName + "'");
 }
 
 if (objCMClassEN.FileText !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.FileText);
 var strFileText = objCMClassEN.FileText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileText + "'");
 }
 
 if (objCMClassEN.FuncModuleAgcId !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.FuncModuleAgcId);
 var strFuncModuleAgcId = objCMClassEN.FuncModuleAgcId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleAgcId + "'");
 }
 
 if (objCMClassEN.CodeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.CodeTypeId);
 var strCodeTypeId = objCMClassEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTypeId + "'");
 }
 
 if (objCMClassEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.UserId);
 var strUserId = objCMClassEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objCMClassEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.PrjId);
 var strPrjId = objCMClassEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 arrFieldListForInsert.Add(conCMClass.IsOpen);
 arrValueListForInsert.Add("'" + (objCMClassEN.IsOpen  ==  false ? "0" : "1") + "'");
 
 if (objCMClassEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.UpdDate);
 var strUpdDate = objCMClassEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCMClassEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.UpdUser);
 var strUpdUser = objCMClassEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objCMClassEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.Memo);
 var strMemo = objCMClassEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objCMClassEN.ClsName !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.ClsName);
 var strClsName = objCMClassEN.ClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClsName + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CMClass");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMClassDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objCMClassEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCMClassEN objCMClassEN)
{
 objCMClassEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMClassEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCMClassEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCMClassEN.CmClassId !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.CmClassId);
 var strCmClassId = objCMClassEN.CmClassId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmClassId + "'");
 }
 
 arrFieldListForInsert.Add(conCMClass.ApplicationTypeId);
 arrValueListForInsert.Add(objCMClassEN.ApplicationTypeId.ToString());
 
 if (objCMClassEN.ProgLangTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.ProgLangTypeId);
 var strProgLangTypeId = objCMClassEN.ProgLangTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLangTypeId + "'");
 }
 
 if (objCMClassEN.TabName !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.TabName);
 var strTabName = objCMClassEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabName + "'");
 }
 
 if (objCMClassEN.NameSpace !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.NameSpace);
 var strNameSpace = objCMClassEN.NameSpace.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNameSpace + "'");
 }
 
 if (objCMClassEN.ProjectPath !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.ProjectPath);
 var strProjectPath = objCMClassEN.ProjectPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProjectPath + "'");
 }
 
 if (objCMClassEN.FilePath !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.FilePath);
 var strFilePath = objCMClassEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFilePath + "'");
 }
 
 if (objCMClassEN.FileName !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.FileName);
 var strFileName = objCMClassEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileName + "'");
 }
 
 if (objCMClassEN.FileText !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.FileText);
 var strFileText = objCMClassEN.FileText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileText + "'");
 }
 
 if (objCMClassEN.FuncModuleAgcId !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.FuncModuleAgcId);
 var strFuncModuleAgcId = objCMClassEN.FuncModuleAgcId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleAgcId + "'");
 }
 
 if (objCMClassEN.CodeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.CodeTypeId);
 var strCodeTypeId = objCMClassEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTypeId + "'");
 }
 
 if (objCMClassEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.UserId);
 var strUserId = objCMClassEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objCMClassEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.PrjId);
 var strPrjId = objCMClassEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 arrFieldListForInsert.Add(conCMClass.IsOpen);
 arrValueListForInsert.Add("'" + (objCMClassEN.IsOpen  ==  false ? "0" : "1") + "'");
 
 if (objCMClassEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.UpdDate);
 var strUpdDate = objCMClassEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCMClassEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.UpdUser);
 var strUpdUser = objCMClassEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objCMClassEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.Memo);
 var strMemo = objCMClassEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objCMClassEN.ClsName !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.ClsName);
 var strClsName = objCMClassEN.ClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClsName + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CMClass");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMClassDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objCMClassEN.CmClassId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objCMClassEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCMClassEN objCMClassEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objCMClassEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMClassEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCMClassEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCMClassEN.CmClassId !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.CmClassId);
 var strCmClassId = objCMClassEN.CmClassId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmClassId + "'");
 }
 
 arrFieldListForInsert.Add(conCMClass.ApplicationTypeId);
 arrValueListForInsert.Add(objCMClassEN.ApplicationTypeId.ToString());
 
 if (objCMClassEN.ProgLangTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.ProgLangTypeId);
 var strProgLangTypeId = objCMClassEN.ProgLangTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLangTypeId + "'");
 }
 
 if (objCMClassEN.TabName !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.TabName);
 var strTabName = objCMClassEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabName + "'");
 }
 
 if (objCMClassEN.NameSpace !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.NameSpace);
 var strNameSpace = objCMClassEN.NameSpace.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNameSpace + "'");
 }
 
 if (objCMClassEN.ProjectPath !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.ProjectPath);
 var strProjectPath = objCMClassEN.ProjectPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProjectPath + "'");
 }
 
 if (objCMClassEN.FilePath !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.FilePath);
 var strFilePath = objCMClassEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFilePath + "'");
 }
 
 if (objCMClassEN.FileName !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.FileName);
 var strFileName = objCMClassEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileName + "'");
 }
 
 if (objCMClassEN.FileText !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.FileText);
 var strFileText = objCMClassEN.FileText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileText + "'");
 }
 
 if (objCMClassEN.FuncModuleAgcId !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.FuncModuleAgcId);
 var strFuncModuleAgcId = objCMClassEN.FuncModuleAgcId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleAgcId + "'");
 }
 
 if (objCMClassEN.CodeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.CodeTypeId);
 var strCodeTypeId = objCMClassEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTypeId + "'");
 }
 
 if (objCMClassEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.UserId);
 var strUserId = objCMClassEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objCMClassEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.PrjId);
 var strPrjId = objCMClassEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 arrFieldListForInsert.Add(conCMClass.IsOpen);
 arrValueListForInsert.Add("'" + (objCMClassEN.IsOpen  ==  false ? "0" : "1") + "'");
 
 if (objCMClassEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.UpdDate);
 var strUpdDate = objCMClassEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCMClassEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.UpdUser);
 var strUpdUser = objCMClassEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objCMClassEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.Memo);
 var strMemo = objCMClassEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objCMClassEN.ClsName !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.ClsName);
 var strClsName = objCMClassEN.ClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClsName + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CMClass");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMClassDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objCMClassEN.CmClassId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objCMClassEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCMClassEN objCMClassEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objCMClassEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMClassEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCMClassEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCMClassEN.CmClassId !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.CmClassId);
 var strCmClassId = objCMClassEN.CmClassId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmClassId + "'");
 }
 
 arrFieldListForInsert.Add(conCMClass.ApplicationTypeId);
 arrValueListForInsert.Add(objCMClassEN.ApplicationTypeId.ToString());
 
 if (objCMClassEN.ProgLangTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.ProgLangTypeId);
 var strProgLangTypeId = objCMClassEN.ProgLangTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLangTypeId + "'");
 }
 
 if (objCMClassEN.TabName !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.TabName);
 var strTabName = objCMClassEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabName + "'");
 }
 
 if (objCMClassEN.NameSpace !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.NameSpace);
 var strNameSpace = objCMClassEN.NameSpace.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNameSpace + "'");
 }
 
 if (objCMClassEN.ProjectPath !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.ProjectPath);
 var strProjectPath = objCMClassEN.ProjectPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProjectPath + "'");
 }
 
 if (objCMClassEN.FilePath !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.FilePath);
 var strFilePath = objCMClassEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFilePath + "'");
 }
 
 if (objCMClassEN.FileName !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.FileName);
 var strFileName = objCMClassEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileName + "'");
 }
 
 if (objCMClassEN.FileText !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.FileText);
 var strFileText = objCMClassEN.FileText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileText + "'");
 }
 
 if (objCMClassEN.FuncModuleAgcId !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.FuncModuleAgcId);
 var strFuncModuleAgcId = objCMClassEN.FuncModuleAgcId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleAgcId + "'");
 }
 
 if (objCMClassEN.CodeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.CodeTypeId);
 var strCodeTypeId = objCMClassEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTypeId + "'");
 }
 
 if (objCMClassEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.UserId);
 var strUserId = objCMClassEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objCMClassEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.PrjId);
 var strPrjId = objCMClassEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 arrFieldListForInsert.Add(conCMClass.IsOpen);
 arrValueListForInsert.Add("'" + (objCMClassEN.IsOpen  ==  false ? "0" : "1") + "'");
 
 if (objCMClassEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.UpdDate);
 var strUpdDate = objCMClassEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCMClassEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.UpdUser);
 var strUpdUser = objCMClassEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objCMClassEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.Memo);
 var strMemo = objCMClassEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objCMClassEN.ClsName !=  null)
 {
 arrFieldListForInsert.Add(conCMClass.ClsName);
 var strClsName = objCMClassEN.ClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClsName + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CMClass");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMClassDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewCMClasss(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMClassDA.GetSpecSQLObj();
strSQL = "Select * from CMClass where CmClassId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CMClass");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strCmClassId = oRow[conCMClass.CmClassId].ToString().Trim();
if (IsExist(strCmClassId))
{
 string strResult = "关键字变量值为:" + string.Format("CmClassId = {0}", strCmClassId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsCMClassEN._CurrTabName ].NewRow();
objRow[conCMClass.CmClassId] = oRow[conCMClass.CmClassId].ToString().Trim(); //类Id
objRow[conCMClass.ApplicationTypeId] = oRow[conCMClass.ApplicationTypeId].ToString().Trim(); //应用程序类型ID
objRow[conCMClass.ProgLangTypeId] = oRow[conCMClass.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objRow[conCMClass.TabName] = oRow[conCMClass.TabName].ToString().Trim(); //表名
objRow[conCMClass.NameSpace] = oRow[conCMClass.NameSpace].ToString().Trim(); //域名
objRow[conCMClass.ProjectPath] = oRow[conCMClass.ProjectPath].ToString().Trim(); //工程路径
objRow[conCMClass.FilePath] = oRow[conCMClass.FilePath].ToString().Trim(); //文件路径
objRow[conCMClass.FileName] = oRow[conCMClass.FileName].ToString().Trim(); //文件名
objRow[conCMClass.FileText] = oRow[conCMClass.FileText].ToString().Trim(); //文件内容
objRow[conCMClass.FuncModuleAgcId] = oRow[conCMClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objRow[conCMClass.CodeTypeId] = oRow[conCMClass.CodeTypeId].ToString().Trim(); //代码类型Id
objRow[conCMClass.UserId] = oRow[conCMClass.UserId].ToString().Trim(); //用户Id
objRow[conCMClass.PrjId] = oRow[conCMClass.PrjId].ToString().Trim(); //工程Id
objRow[conCMClass.IsOpen] = oRow[conCMClass.IsOpen].ToString().Trim(); //是否开放
objRow[conCMClass.UpdDate] = oRow[conCMClass.UpdDate].ToString().Trim(); //修改日期
objRow[conCMClass.UpdUser] = oRow[conCMClass.UpdUser].ToString().Trim(); //修改者
objRow[conCMClass.Memo] = oRow[conCMClass.Memo].ToString().Trim(); //说明
objRow[conCMClass.ClsName] = oRow[conCMClass.ClsName].ToString().Trim(); //类名
 objDS.Tables[clsCMClassEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsCMClassEN._CurrTabName);
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
 /// <param name = "objCMClassEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsCMClassEN objCMClassEN)
{
 objCMClassEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMClassEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCMClassEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMClassDA.GetSpecSQLObj();
strSQL = "Select * from CMClass where CmClassId = " + "'"+ objCMClassEN.CmClassId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsCMClassEN._CurrTabName);
if (objDS.Tables[clsCMClassEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:CmClassId = " + "'"+ objCMClassEN.CmClassId+"'");
return false;
}
objRow = objDS.Tables[clsCMClassEN._CurrTabName].Rows[0];
 if (objCMClassEN.IsUpdated(conCMClass.CmClassId))
 {
objRow[conCMClass.CmClassId] = objCMClassEN.CmClassId; //类Id
 }
 if (objCMClassEN.IsUpdated(conCMClass.ApplicationTypeId))
 {
objRow[conCMClass.ApplicationTypeId] = objCMClassEN.ApplicationTypeId; //应用程序类型ID
 }
 if (objCMClassEN.IsUpdated(conCMClass.ProgLangTypeId))
 {
objRow[conCMClass.ProgLangTypeId] = objCMClassEN.ProgLangTypeId; //编程语言类型Id
 }
 if (objCMClassEN.IsUpdated(conCMClass.TabName))
 {
objRow[conCMClass.TabName] = objCMClassEN.TabName; //表名
 }
 if (objCMClassEN.IsUpdated(conCMClass.NameSpace))
 {
objRow[conCMClass.NameSpace] = objCMClassEN.NameSpace; //域名
 }
 if (objCMClassEN.IsUpdated(conCMClass.ProjectPath))
 {
objRow[conCMClass.ProjectPath] = objCMClassEN.ProjectPath; //工程路径
 }
 if (objCMClassEN.IsUpdated(conCMClass.FilePath))
 {
objRow[conCMClass.FilePath] = objCMClassEN.FilePath; //文件路径
 }
 if (objCMClassEN.IsUpdated(conCMClass.FileName))
 {
objRow[conCMClass.FileName] = objCMClassEN.FileName; //文件名
 }
 if (objCMClassEN.IsUpdated(conCMClass.FileText))
 {
objRow[conCMClass.FileText] = objCMClassEN.FileText; //文件内容
 }
 if (objCMClassEN.IsUpdated(conCMClass.FuncModuleAgcId))
 {
objRow[conCMClass.FuncModuleAgcId] = objCMClassEN.FuncModuleAgcId; //功能模块Id
 }
 if (objCMClassEN.IsUpdated(conCMClass.CodeTypeId))
 {
objRow[conCMClass.CodeTypeId] = objCMClassEN.CodeTypeId; //代码类型Id
 }
 if (objCMClassEN.IsUpdated(conCMClass.UserId))
 {
objRow[conCMClass.UserId] = objCMClassEN.UserId; //用户Id
 }
 if (objCMClassEN.IsUpdated(conCMClass.PrjId))
 {
objRow[conCMClass.PrjId] = objCMClassEN.PrjId; //工程Id
 }
 if (objCMClassEN.IsUpdated(conCMClass.IsOpen))
 {
objRow[conCMClass.IsOpen] = objCMClassEN.IsOpen; //是否开放
 }
 if (objCMClassEN.IsUpdated(conCMClass.UpdDate))
 {
objRow[conCMClass.UpdDate] = objCMClassEN.UpdDate; //修改日期
 }
 if (objCMClassEN.IsUpdated(conCMClass.UpdUser))
 {
objRow[conCMClass.UpdUser] = objCMClassEN.UpdUser; //修改者
 }
 if (objCMClassEN.IsUpdated(conCMClass.Memo))
 {
objRow[conCMClass.Memo] = objCMClassEN.Memo; //说明
 }
 if (objCMClassEN.IsUpdated(conCMClass.ClsName))
 {
objRow[conCMClass.ClsName] = objCMClassEN.ClsName; //类名
 }
try
{
objDA.Update(objDS, clsCMClassEN._CurrTabName);
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
 /// <param name = "objCMClassEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCMClassEN objCMClassEN)
{
 objCMClassEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMClassEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCMClassEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMClassDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update CMClass Set ");
 
 if (objCMClassEN.IsUpdated(conCMClass.ApplicationTypeId))
 {
 sbSQL.AppendFormat("{1} = {0},",objCMClassEN.ApplicationTypeId, conCMClass.ApplicationTypeId); //应用程序类型ID
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.ProgLangTypeId))
 {
 if (objCMClassEN.ProgLangTypeId !=  null)
 {
 var strProgLangTypeId = objCMClassEN.ProgLangTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProgLangTypeId, conCMClass.ProgLangTypeId); //编程语言类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMClass.ProgLangTypeId); //编程语言类型Id
 }
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.TabName))
 {
 if (objCMClassEN.TabName !=  null)
 {
 var strTabName = objCMClassEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabName, conCMClass.TabName); //表名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMClass.TabName); //表名
 }
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.NameSpace))
 {
 if (objCMClassEN.NameSpace !=  null)
 {
 var strNameSpace = objCMClassEN.NameSpace.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strNameSpace, conCMClass.NameSpace); //域名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMClass.NameSpace); //域名
 }
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.ProjectPath))
 {
 if (objCMClassEN.ProjectPath !=  null)
 {
 var strProjectPath = objCMClassEN.ProjectPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProjectPath, conCMClass.ProjectPath); //工程路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMClass.ProjectPath); //工程路径
 }
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.FilePath))
 {
 if (objCMClassEN.FilePath !=  null)
 {
 var strFilePath = objCMClassEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFilePath, conCMClass.FilePath); //文件路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMClass.FilePath); //文件路径
 }
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.FileName))
 {
 if (objCMClassEN.FileName !=  null)
 {
 var strFileName = objCMClassEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileName, conCMClass.FileName); //文件名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMClass.FileName); //文件名
 }
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.FileText))
 {
 if (objCMClassEN.FileText !=  null)
 {
 var strFileText = objCMClassEN.FileText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileText, conCMClass.FileText); //文件内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMClass.FileText); //文件内容
 }
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.FuncModuleAgcId))
 {
 if (objCMClassEN.FuncModuleAgcId !=  null)
 {
 var strFuncModuleAgcId = objCMClassEN.FuncModuleAgcId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleAgcId, conCMClass.FuncModuleAgcId); //功能模块Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMClass.FuncModuleAgcId); //功能模块Id
 }
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.CodeTypeId))
 {
 if (objCMClassEN.CodeTypeId !=  null)
 {
 var strCodeTypeId = objCMClassEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCodeTypeId, conCMClass.CodeTypeId); //代码类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMClass.CodeTypeId); //代码类型Id
 }
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.UserId))
 {
 if (objCMClassEN.UserId !=  null)
 {
 var strUserId = objCMClassEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conCMClass.UserId); //用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMClass.UserId); //用户Id
 }
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.PrjId))
 {
 if (objCMClassEN.PrjId !=  null)
 {
 var strPrjId = objCMClassEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conCMClass.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMClass.PrjId); //工程Id
 }
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.IsOpen))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCMClassEN.IsOpen == true?"1":"0", conCMClass.IsOpen); //是否开放
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.UpdDate))
 {
 if (objCMClassEN.UpdDate !=  null)
 {
 var strUpdDate = objCMClassEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conCMClass.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMClass.UpdDate); //修改日期
 }
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.UpdUser))
 {
 if (objCMClassEN.UpdUser !=  null)
 {
 var strUpdUser = objCMClassEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conCMClass.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMClass.UpdUser); //修改者
 }
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.Memo))
 {
 if (objCMClassEN.Memo !=  null)
 {
 var strMemo = objCMClassEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCMClass.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMClass.Memo); //说明
 }
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.ClsName))
 {
 if (objCMClassEN.ClsName !=  null)
 {
 var strClsName = objCMClassEN.ClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClsName, conCMClass.ClsName); //类名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMClass.ClsName); //类名
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where CmClassId = '{0}'", objCMClassEN.CmClassId); 
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
 /// <param name = "objCMClassEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsCMClassEN objCMClassEN, string strCondition)
{
 objCMClassEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMClassEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCMClassEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMClassDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CMClass Set ");
 
 if (objCMClassEN.IsUpdated(conCMClass.ApplicationTypeId))
 {
 sbSQL.AppendFormat(" ApplicationTypeId = {0},", objCMClassEN.ApplicationTypeId); //应用程序类型ID
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.ProgLangTypeId))
 {
 if (objCMClassEN.ProgLangTypeId !=  null)
 {
 var strProgLangTypeId = objCMClassEN.ProgLangTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProgLangTypeId = '{0}',", strProgLangTypeId); //编程语言类型Id
 }
 else
 {
 sbSQL.Append(" ProgLangTypeId = null,"); //编程语言类型Id
 }
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.TabName))
 {
 if (objCMClassEN.TabName !=  null)
 {
 var strTabName = objCMClassEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabName = '{0}',", strTabName); //表名
 }
 else
 {
 sbSQL.Append(" TabName = null,"); //表名
 }
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.NameSpace))
 {
 if (objCMClassEN.NameSpace !=  null)
 {
 var strNameSpace = objCMClassEN.NameSpace.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" NameSpace = '{0}',", strNameSpace); //域名
 }
 else
 {
 sbSQL.Append(" NameSpace = null,"); //域名
 }
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.ProjectPath))
 {
 if (objCMClassEN.ProjectPath !=  null)
 {
 var strProjectPath = objCMClassEN.ProjectPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProjectPath = '{0}',", strProjectPath); //工程路径
 }
 else
 {
 sbSQL.Append(" ProjectPath = null,"); //工程路径
 }
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.FilePath))
 {
 if (objCMClassEN.FilePath !=  null)
 {
 var strFilePath = objCMClassEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FilePath = '{0}',", strFilePath); //文件路径
 }
 else
 {
 sbSQL.Append(" FilePath = null,"); //文件路径
 }
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.FileName))
 {
 if (objCMClassEN.FileName !=  null)
 {
 var strFileName = objCMClassEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileName = '{0}',", strFileName); //文件名
 }
 else
 {
 sbSQL.Append(" FileName = null,"); //文件名
 }
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.FileText))
 {
 if (objCMClassEN.FileText !=  null)
 {
 var strFileText = objCMClassEN.FileText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileText = '{0}',", strFileText); //文件内容
 }
 else
 {
 sbSQL.Append(" FileText = null,"); //文件内容
 }
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.FuncModuleAgcId))
 {
 if (objCMClassEN.FuncModuleAgcId !=  null)
 {
 var strFuncModuleAgcId = objCMClassEN.FuncModuleAgcId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleAgcId = '{0}',", strFuncModuleAgcId); //功能模块Id
 }
 else
 {
 sbSQL.Append(" FuncModuleAgcId = null,"); //功能模块Id
 }
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.CodeTypeId))
 {
 if (objCMClassEN.CodeTypeId !=  null)
 {
 var strCodeTypeId = objCMClassEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodeTypeId = '{0}',", strCodeTypeId); //代码类型Id
 }
 else
 {
 sbSQL.Append(" CodeTypeId = null,"); //代码类型Id
 }
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.UserId))
 {
 if (objCMClassEN.UserId !=  null)
 {
 var strUserId = objCMClassEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户Id
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户Id
 }
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.PrjId))
 {
 if (objCMClassEN.PrjId !=  null)
 {
 var strPrjId = objCMClassEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.IsOpen))
 {
 sbSQL.AppendFormat(" IsOpen = '{0}',", objCMClassEN.IsOpen == true?"1":"0"); //是否开放
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.UpdDate))
 {
 if (objCMClassEN.UpdDate !=  null)
 {
 var strUpdDate = objCMClassEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.UpdUser))
 {
 if (objCMClassEN.UpdUser !=  null)
 {
 var strUpdUser = objCMClassEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.Memo))
 {
 if (objCMClassEN.Memo !=  null)
 {
 var strMemo = objCMClassEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //说明
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //说明
 }
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.ClsName))
 {
 if (objCMClassEN.ClsName !=  null)
 {
 var strClsName = objCMClassEN.ClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClsName = '{0}',", strClsName); //类名
 }
 else
 {
 sbSQL.Append(" ClsName = null,"); //类名
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
 /// <param name = "objCMClassEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsCMClassEN objCMClassEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objCMClassEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMClassEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCMClassEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMClassDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CMClass Set ");
 
 if (objCMClassEN.IsUpdated(conCMClass.ApplicationTypeId))
 {
 sbSQL.AppendFormat(" ApplicationTypeId = {0},", objCMClassEN.ApplicationTypeId); //应用程序类型ID
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.ProgLangTypeId))
 {
 if (objCMClassEN.ProgLangTypeId !=  null)
 {
 var strProgLangTypeId = objCMClassEN.ProgLangTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProgLangTypeId = '{0}',", strProgLangTypeId); //编程语言类型Id
 }
 else
 {
 sbSQL.Append(" ProgLangTypeId = null,"); //编程语言类型Id
 }
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.TabName))
 {
 if (objCMClassEN.TabName !=  null)
 {
 var strTabName = objCMClassEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabName = '{0}',", strTabName); //表名
 }
 else
 {
 sbSQL.Append(" TabName = null,"); //表名
 }
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.NameSpace))
 {
 if (objCMClassEN.NameSpace !=  null)
 {
 var strNameSpace = objCMClassEN.NameSpace.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" NameSpace = '{0}',", strNameSpace); //域名
 }
 else
 {
 sbSQL.Append(" NameSpace = null,"); //域名
 }
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.ProjectPath))
 {
 if (objCMClassEN.ProjectPath !=  null)
 {
 var strProjectPath = objCMClassEN.ProjectPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProjectPath = '{0}',", strProjectPath); //工程路径
 }
 else
 {
 sbSQL.Append(" ProjectPath = null,"); //工程路径
 }
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.FilePath))
 {
 if (objCMClassEN.FilePath !=  null)
 {
 var strFilePath = objCMClassEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FilePath = '{0}',", strFilePath); //文件路径
 }
 else
 {
 sbSQL.Append(" FilePath = null,"); //文件路径
 }
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.FileName))
 {
 if (objCMClassEN.FileName !=  null)
 {
 var strFileName = objCMClassEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileName = '{0}',", strFileName); //文件名
 }
 else
 {
 sbSQL.Append(" FileName = null,"); //文件名
 }
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.FileText))
 {
 if (objCMClassEN.FileText !=  null)
 {
 var strFileText = objCMClassEN.FileText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileText = '{0}',", strFileText); //文件内容
 }
 else
 {
 sbSQL.Append(" FileText = null,"); //文件内容
 }
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.FuncModuleAgcId))
 {
 if (objCMClassEN.FuncModuleAgcId !=  null)
 {
 var strFuncModuleAgcId = objCMClassEN.FuncModuleAgcId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleAgcId = '{0}',", strFuncModuleAgcId); //功能模块Id
 }
 else
 {
 sbSQL.Append(" FuncModuleAgcId = null,"); //功能模块Id
 }
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.CodeTypeId))
 {
 if (objCMClassEN.CodeTypeId !=  null)
 {
 var strCodeTypeId = objCMClassEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodeTypeId = '{0}',", strCodeTypeId); //代码类型Id
 }
 else
 {
 sbSQL.Append(" CodeTypeId = null,"); //代码类型Id
 }
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.UserId))
 {
 if (objCMClassEN.UserId !=  null)
 {
 var strUserId = objCMClassEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户Id
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户Id
 }
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.PrjId))
 {
 if (objCMClassEN.PrjId !=  null)
 {
 var strPrjId = objCMClassEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.IsOpen))
 {
 sbSQL.AppendFormat(" IsOpen = '{0}',", objCMClassEN.IsOpen == true?"1":"0"); //是否开放
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.UpdDate))
 {
 if (objCMClassEN.UpdDate !=  null)
 {
 var strUpdDate = objCMClassEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.UpdUser))
 {
 if (objCMClassEN.UpdUser !=  null)
 {
 var strUpdUser = objCMClassEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.Memo))
 {
 if (objCMClassEN.Memo !=  null)
 {
 var strMemo = objCMClassEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //说明
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //说明
 }
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.ClsName))
 {
 if (objCMClassEN.ClsName !=  null)
 {
 var strClsName = objCMClassEN.ClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClsName = '{0}',", strClsName); //类名
 }
 else
 {
 sbSQL.Append(" ClsName = null,"); //类名
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
 /// <param name = "objCMClassEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCMClassEN objCMClassEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objCMClassEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMClassEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCMClassEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMClassDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CMClass Set ");
 
 if (objCMClassEN.IsUpdated(conCMClass.ApplicationTypeId))
 {
 sbSQL.AppendFormat("{1} = {0},",objCMClassEN.ApplicationTypeId, conCMClass.ApplicationTypeId); //应用程序类型ID
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.ProgLangTypeId))
 {
 if (objCMClassEN.ProgLangTypeId !=  null)
 {
 var strProgLangTypeId = objCMClassEN.ProgLangTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProgLangTypeId, conCMClass.ProgLangTypeId); //编程语言类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMClass.ProgLangTypeId); //编程语言类型Id
 }
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.TabName))
 {
 if (objCMClassEN.TabName !=  null)
 {
 var strTabName = objCMClassEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabName, conCMClass.TabName); //表名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMClass.TabName); //表名
 }
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.NameSpace))
 {
 if (objCMClassEN.NameSpace !=  null)
 {
 var strNameSpace = objCMClassEN.NameSpace.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strNameSpace, conCMClass.NameSpace); //域名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMClass.NameSpace); //域名
 }
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.ProjectPath))
 {
 if (objCMClassEN.ProjectPath !=  null)
 {
 var strProjectPath = objCMClassEN.ProjectPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProjectPath, conCMClass.ProjectPath); //工程路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMClass.ProjectPath); //工程路径
 }
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.FilePath))
 {
 if (objCMClassEN.FilePath !=  null)
 {
 var strFilePath = objCMClassEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFilePath, conCMClass.FilePath); //文件路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMClass.FilePath); //文件路径
 }
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.FileName))
 {
 if (objCMClassEN.FileName !=  null)
 {
 var strFileName = objCMClassEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileName, conCMClass.FileName); //文件名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMClass.FileName); //文件名
 }
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.FileText))
 {
 if (objCMClassEN.FileText !=  null)
 {
 var strFileText = objCMClassEN.FileText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileText, conCMClass.FileText); //文件内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMClass.FileText); //文件内容
 }
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.FuncModuleAgcId))
 {
 if (objCMClassEN.FuncModuleAgcId !=  null)
 {
 var strFuncModuleAgcId = objCMClassEN.FuncModuleAgcId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleAgcId, conCMClass.FuncModuleAgcId); //功能模块Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMClass.FuncModuleAgcId); //功能模块Id
 }
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.CodeTypeId))
 {
 if (objCMClassEN.CodeTypeId !=  null)
 {
 var strCodeTypeId = objCMClassEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCodeTypeId, conCMClass.CodeTypeId); //代码类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMClass.CodeTypeId); //代码类型Id
 }
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.UserId))
 {
 if (objCMClassEN.UserId !=  null)
 {
 var strUserId = objCMClassEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conCMClass.UserId); //用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMClass.UserId); //用户Id
 }
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.PrjId))
 {
 if (objCMClassEN.PrjId !=  null)
 {
 var strPrjId = objCMClassEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conCMClass.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMClass.PrjId); //工程Id
 }
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.IsOpen))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCMClassEN.IsOpen == true?"1":"0", conCMClass.IsOpen); //是否开放
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.UpdDate))
 {
 if (objCMClassEN.UpdDate !=  null)
 {
 var strUpdDate = objCMClassEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conCMClass.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMClass.UpdDate); //修改日期
 }
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.UpdUser))
 {
 if (objCMClassEN.UpdUser !=  null)
 {
 var strUpdUser = objCMClassEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conCMClass.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMClass.UpdUser); //修改者
 }
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.Memo))
 {
 if (objCMClassEN.Memo !=  null)
 {
 var strMemo = objCMClassEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCMClass.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMClass.Memo); //说明
 }
 }
 
 if (objCMClassEN.IsUpdated(conCMClass.ClsName))
 {
 if (objCMClassEN.ClsName !=  null)
 {
 var strClsName = objCMClassEN.ClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClsName, conCMClass.ClsName); //类名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMClass.ClsName); //类名
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where CmClassId = '{0}'", objCMClassEN.CmClassId); 
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
 /// <param name = "strCmClassId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strCmClassId) 
{
CheckPrimaryKey(strCmClassId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMClassDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strCmClassId,
};
 objSQL.ExecSP("CMClass_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strCmClassId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strCmClassId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strCmClassId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMClassDA.GetSpecSQLObj();
//删除CMClass本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CMClass where CmClassId = " + "'"+ strCmClassId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelCMClass(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMClassDA.GetSpecSQLObj();
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
//删除CMClass本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CMClass where CmClassId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strCmClassId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strCmClassId) 
{
CheckPrimaryKey(strCmClassId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMClassDA.GetSpecSQLObj();
//删除CMClass本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CMClass where CmClassId = " + "'"+ strCmClassId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelCMClass(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsCMClassDA: DelCMClass)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMClassDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CMClass where " + strCondition ;
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
public bool DelCMClassWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsCMClassDA: DelCMClassWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMClassDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CMClass where " + strCondition ;
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
 /// <param name = "objCMClassENS">源对象</param>
 /// <param name = "objCMClassENT">目标对象</param>
public void CopyTo(clsCMClassEN objCMClassENS, clsCMClassEN objCMClassENT)
{
objCMClassENT.CmClassId = objCMClassENS.CmClassId; //类Id
objCMClassENT.ApplicationTypeId = objCMClassENS.ApplicationTypeId; //应用程序类型ID
objCMClassENT.ProgLangTypeId = objCMClassENS.ProgLangTypeId; //编程语言类型Id
objCMClassENT.TabName = objCMClassENS.TabName; //表名
objCMClassENT.NameSpace = objCMClassENS.NameSpace; //域名
objCMClassENT.ProjectPath = objCMClassENS.ProjectPath; //工程路径
objCMClassENT.FilePath = objCMClassENS.FilePath; //文件路径
objCMClassENT.FileName = objCMClassENS.FileName; //文件名
objCMClassENT.FileText = objCMClassENS.FileText; //文件内容
objCMClassENT.FuncModuleAgcId = objCMClassENS.FuncModuleAgcId; //功能模块Id
objCMClassENT.CodeTypeId = objCMClassENS.CodeTypeId; //代码类型Id
objCMClassENT.UserId = objCMClassENS.UserId; //用户Id
objCMClassENT.PrjId = objCMClassENS.PrjId; //工程Id
objCMClassENT.IsOpen = objCMClassENS.IsOpen; //是否开放
objCMClassENT.UpdDate = objCMClassENS.UpdDate; //修改日期
objCMClassENT.UpdUser = objCMClassENS.UpdUser; //修改者
objCMClassENT.Memo = objCMClassENS.Memo; //说明
objCMClassENT.ClsName = objCMClassENS.ClsName; //类名
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsCMClassEN objCMClassEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objCMClassEN.ApplicationTypeId, conCMClass.ApplicationTypeId);
clsCheckSql.CheckFieldNotNull(objCMClassEN.ProgLangTypeId, conCMClass.ProgLangTypeId);
clsCheckSql.CheckFieldNotNull(objCMClassEN.ProjectPath, conCMClass.ProjectPath);
clsCheckSql.CheckFieldNotNull(objCMClassEN.FilePath, conCMClass.FilePath);
clsCheckSql.CheckFieldNotNull(objCMClassEN.FileName, conCMClass.FileName);
clsCheckSql.CheckFieldNotNull(objCMClassEN.CodeTypeId, conCMClass.CodeTypeId);
clsCheckSql.CheckFieldNotNull(objCMClassEN.PrjId, conCMClass.PrjId);
clsCheckSql.CheckFieldNotNull(objCMClassEN.ClsName, conCMClass.ClsName);
//检查字段长度
clsCheckSql.CheckFieldLen(objCMClassEN.CmClassId, 8, conCMClass.CmClassId);
clsCheckSql.CheckFieldLen(objCMClassEN.ProgLangTypeId, 2, conCMClass.ProgLangTypeId);
clsCheckSql.CheckFieldLen(objCMClassEN.TabName, 100, conCMClass.TabName);
clsCheckSql.CheckFieldLen(objCMClassEN.NameSpace, 50, conCMClass.NameSpace);
clsCheckSql.CheckFieldLen(objCMClassEN.ProjectPath, 500, conCMClass.ProjectPath);
clsCheckSql.CheckFieldLen(objCMClassEN.FilePath, 500, conCMClass.FilePath);
clsCheckSql.CheckFieldLen(objCMClassEN.FileName, 150, conCMClass.FileName);
clsCheckSql.CheckFieldLen(objCMClassEN.FuncModuleAgcId, 8, conCMClass.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(objCMClassEN.CodeTypeId, 4, conCMClass.CodeTypeId);
clsCheckSql.CheckFieldLen(objCMClassEN.UserId, 18, conCMClass.UserId);
clsCheckSql.CheckFieldLen(objCMClassEN.PrjId, 4, conCMClass.PrjId);
clsCheckSql.CheckFieldLen(objCMClassEN.UpdDate, 20, conCMClass.UpdDate);
clsCheckSql.CheckFieldLen(objCMClassEN.UpdUser, 20, conCMClass.UpdUser);
clsCheckSql.CheckFieldLen(objCMClassEN.Memo, 1000, conCMClass.Memo);
clsCheckSql.CheckFieldLen(objCMClassEN.ClsName, 100, conCMClass.ClsName);
//检查字段外键固定长度
 objCMClassEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsCMClassEN objCMClassEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCMClassEN.ProgLangTypeId, 2, conCMClass.ProgLangTypeId);
clsCheckSql.CheckFieldLen(objCMClassEN.TabName, 100, conCMClass.TabName);
clsCheckSql.CheckFieldLen(objCMClassEN.NameSpace, 50, conCMClass.NameSpace);
clsCheckSql.CheckFieldLen(objCMClassEN.ProjectPath, 500, conCMClass.ProjectPath);
clsCheckSql.CheckFieldLen(objCMClassEN.FilePath, 500, conCMClass.FilePath);
clsCheckSql.CheckFieldLen(objCMClassEN.FileName, 150, conCMClass.FileName);
clsCheckSql.CheckFieldLen(objCMClassEN.FuncModuleAgcId, 8, conCMClass.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(objCMClassEN.CodeTypeId, 4, conCMClass.CodeTypeId);
clsCheckSql.CheckFieldLen(objCMClassEN.UserId, 18, conCMClass.UserId);
clsCheckSql.CheckFieldLen(objCMClassEN.PrjId, 4, conCMClass.PrjId);
clsCheckSql.CheckFieldLen(objCMClassEN.UpdDate, 20, conCMClass.UpdDate);
clsCheckSql.CheckFieldLen(objCMClassEN.UpdUser, 20, conCMClass.UpdUser);
clsCheckSql.CheckFieldLen(objCMClassEN.Memo, 1000, conCMClass.Memo);
clsCheckSql.CheckFieldLen(objCMClassEN.ClsName, 100, conCMClass.ClsName);
//检查外键字段长度
 objCMClassEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsCMClassEN objCMClassEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCMClassEN.CmClassId, 8, conCMClass.CmClassId);
clsCheckSql.CheckFieldLen(objCMClassEN.ProgLangTypeId, 2, conCMClass.ProgLangTypeId);
clsCheckSql.CheckFieldLen(objCMClassEN.TabName, 100, conCMClass.TabName);
clsCheckSql.CheckFieldLen(objCMClassEN.NameSpace, 50, conCMClass.NameSpace);
clsCheckSql.CheckFieldLen(objCMClassEN.ProjectPath, 500, conCMClass.ProjectPath);
clsCheckSql.CheckFieldLen(objCMClassEN.FilePath, 500, conCMClass.FilePath);
clsCheckSql.CheckFieldLen(objCMClassEN.FileName, 150, conCMClass.FileName);
clsCheckSql.CheckFieldLen(objCMClassEN.FuncModuleAgcId, 8, conCMClass.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(objCMClassEN.CodeTypeId, 4, conCMClass.CodeTypeId);
clsCheckSql.CheckFieldLen(objCMClassEN.UserId, 18, conCMClass.UserId);
clsCheckSql.CheckFieldLen(objCMClassEN.PrjId, 4, conCMClass.PrjId);
clsCheckSql.CheckFieldLen(objCMClassEN.UpdDate, 20, conCMClass.UpdDate);
clsCheckSql.CheckFieldLen(objCMClassEN.UpdUser, 20, conCMClass.UpdUser);
clsCheckSql.CheckFieldLen(objCMClassEN.Memo, 1000, conCMClass.Memo);
clsCheckSql.CheckFieldLen(objCMClassEN.ClsName, 100, conCMClass.ClsName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objCMClassEN.CmClassId, conCMClass.CmClassId);
clsCheckSql.CheckSqlInjection4Field(objCMClassEN.ProgLangTypeId, conCMClass.ProgLangTypeId);
clsCheckSql.CheckSqlInjection4Field(objCMClassEN.TabName, conCMClass.TabName);
clsCheckSql.CheckSqlInjection4Field(objCMClassEN.NameSpace, conCMClass.NameSpace);
clsCheckSql.CheckSqlInjection4Field(objCMClassEN.ProjectPath, conCMClass.ProjectPath);
clsCheckSql.CheckSqlInjection4Field(objCMClassEN.FilePath, conCMClass.FilePath);
clsCheckSql.CheckSqlInjection4Field(objCMClassEN.FileName, conCMClass.FileName);
clsCheckSql.CheckSqlInjection4Field(objCMClassEN.FuncModuleAgcId, conCMClass.FuncModuleAgcId);
clsCheckSql.CheckSqlInjection4Field(objCMClassEN.CodeTypeId, conCMClass.CodeTypeId);
clsCheckSql.CheckSqlInjection4Field(objCMClassEN.UserId, conCMClass.UserId);
clsCheckSql.CheckSqlInjection4Field(objCMClassEN.PrjId, conCMClass.PrjId);
clsCheckSql.CheckSqlInjection4Field(objCMClassEN.UpdDate, conCMClass.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objCMClassEN.UpdUser, conCMClass.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objCMClassEN.Memo, conCMClass.Memo);
clsCheckSql.CheckSqlInjection4Field(objCMClassEN.ClsName, conCMClass.ClsName);
//检查外键字段长度
 objCMClassEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--CMClass(CM类),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objCMClassEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsCMClassEN objCMClassEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objCMClassEN.TabName == null)
{
 sbCondition.AppendFormat(" and TabName is null");
}
else
{
 sbCondition.AppendFormat(" and TabName = '{0}'", objCMClassEN.TabName);
}
 if (objCMClassEN.NameSpace == null)
{
 sbCondition.AppendFormat(" and NameSpace is null");
}
else
{
 sbCondition.AppendFormat(" and NameSpace = '{0}'", objCMClassEN.NameSpace);
}
 sbCondition.AppendFormat(" and ClsName = '{0}'", objCMClassEN.ClsName);
 sbCondition.AppendFormat(" and FileName = '{0}'", objCMClassEN.FileName);
 if (objCMClassEN.UserId == null)
{
 sbCondition.AppendFormat(" and UserId is null");
}
else
{
 sbCondition.AppendFormat(" and UserId = '{0}'", objCMClassEN.UserId);
}
 sbCondition.AppendFormat(" and PrjId = '{0}'", objCMClassEN.PrjId);
 sbCondition.AppendFormat(" and ProgLangTypeId = '{0}'", objCMClassEN.ProgLangTypeId);
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
 objSQL = clsCMClassDA.GetSpecSQLObj();
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
 objSQL = clsCMClassDA.GetSpecSQLObj();
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
 objSQL = clsCMClassDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCMClassEN._CurrTabName);
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
 objSQL = clsCMClassDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCMClassEN._CurrTabName, strCondition);
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
 objSQL = clsCMClassDA.GetSpecSQLObj();
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
 objSQL = clsCMClassDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}