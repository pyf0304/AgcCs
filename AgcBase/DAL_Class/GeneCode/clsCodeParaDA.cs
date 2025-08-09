
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCodeParaDA
 表名:CodePara(00050437)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:08:23
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
 /// 代码参数(CodePara)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsCodeParaDA : clsCommBase4DA
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
 return clsCodeParaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsCodeParaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCodeParaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsCodeParaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsCodeParaEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strCodeParaId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strCodeParaId)
{
strCodeParaId = strCodeParaId.Replace("'", "''");
if (strCodeParaId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:CodePara中,检查关键字,长度不正确!(clsCodeParaDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strCodeParaId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:CodePara中,关键字不能为空 或 null!(clsCodeParaDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCodeParaId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsCodeParaDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsCodeParaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeParaDA.GetSpecSQLObj();
strSQL = "Select * from CodePara where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_CodePara(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsCodeParaDA: GetDataTable_CodePara)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeParaDA.GetSpecSQLObj();
strSQL = "Select * from CodePara where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsCodeParaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeParaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsCodeParaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeParaDA.GetSpecSQLObj();
strSQL = "Select * from CodePara where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsCodeParaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeParaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsCodeParaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeParaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CodePara where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CodePara where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsCodeParaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeParaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from CodePara where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsCodeParaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeParaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} CodePara.* " + 
$"from CodePara " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and CodePara.CodeParaId not in " + 
$"(Select top {intTop_In} CodePara.CodeParaId from CodePara " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CodePara where {1} and CodeParaId not in (Select top {2} CodeParaId from CodePara where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CodePara where {1} and CodeParaId not in (Select top {3} CodeParaId from CodePara where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsCodeParaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeParaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} CodePara.* " + 
$"from CodePara " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and CodePara.CodeParaId not in " + 
$"(Select top {intTop_In} CodePara.CodeParaId from CodePara " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CodePara where {1} and CodeParaId not in (Select top {2} CodeParaId from CodePara where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CodePara where {1} and CodeParaId not in (Select top {3} CodeParaId from CodePara where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsCodeParaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsCodeParaDA:GetObjLst)", objException.Message));
}
List<clsCodeParaEN> arrObjLst = new List<clsCodeParaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeParaDA.GetSpecSQLObj();
strSQL = "Select * from CodePara where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCodeParaEN objCodeParaEN = new clsCodeParaEN();
try
{
objCodeParaEN.CodeParaId = objRow[conCodePara.CodeParaId].ToString().Trim(); //代码参数Id
objCodeParaEN.CodeParaName = objRow[conCodePara.CodeParaName].ToString().Trim(); //代码参数名
objCodeParaEN.DataTypeId = objRow[conCodePara.DataTypeId].ToString().Trim(); //数据类型Id
objCodeParaEN.TabId = objRow[conCodePara.TabId].ToString().Trim(); //表ID
objCodeParaEN.FldId = objRow[conCodePara.FldId].ToString().Trim(); //字段Id
objCodeParaEN.PrjId = objRow[conCodePara.PrjId].ToString().Trim(); //工程Id
objCodeParaEN.CodeParaContent = objRow[conCodePara.CodeParaContent] == DBNull.Value ? null : objRow[conCodePara.CodeParaContent].ToString().Trim(); //代码参数内容
objCodeParaEN.UpdDate = objRow[conCodePara.UpdDate] == DBNull.Value ? null : objRow[conCodePara.UpdDate].ToString().Trim(); //修改日期
objCodeParaEN.UpdUser = objRow[conCodePara.UpdUser] == DBNull.Value ? null : objRow[conCodePara.UpdUser].ToString().Trim(); //修改者
objCodeParaEN.Memo = objRow[conCodePara.Memo] == DBNull.Value ? null : objRow[conCodePara.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCodeParaDA: GetObjLst)", objException.Message));
}
objCodeParaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCodeParaEN);
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
public List<clsCodeParaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsCodeParaDA:GetObjLstByTabName)", objException.Message));
}
List<clsCodeParaEN> arrObjLst = new List<clsCodeParaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeParaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCodeParaEN objCodeParaEN = new clsCodeParaEN();
try
{
objCodeParaEN.CodeParaId = objRow[conCodePara.CodeParaId].ToString().Trim(); //代码参数Id
objCodeParaEN.CodeParaName = objRow[conCodePara.CodeParaName].ToString().Trim(); //代码参数名
objCodeParaEN.DataTypeId = objRow[conCodePara.DataTypeId].ToString().Trim(); //数据类型Id
objCodeParaEN.TabId = objRow[conCodePara.TabId].ToString().Trim(); //表ID
objCodeParaEN.FldId = objRow[conCodePara.FldId].ToString().Trim(); //字段Id
objCodeParaEN.PrjId = objRow[conCodePara.PrjId].ToString().Trim(); //工程Id
objCodeParaEN.CodeParaContent = objRow[conCodePara.CodeParaContent] == DBNull.Value ? null : objRow[conCodePara.CodeParaContent].ToString().Trim(); //代码参数内容
objCodeParaEN.UpdDate = objRow[conCodePara.UpdDate] == DBNull.Value ? null : objRow[conCodePara.UpdDate].ToString().Trim(); //修改日期
objCodeParaEN.UpdUser = objRow[conCodePara.UpdUser] == DBNull.Value ? null : objRow[conCodePara.UpdUser].ToString().Trim(); //修改者
objCodeParaEN.Memo = objRow[conCodePara.Memo] == DBNull.Value ? null : objRow[conCodePara.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCodeParaDA: GetObjLst)", objException.Message));
}
objCodeParaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCodeParaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objCodeParaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetCodePara(ref clsCodeParaEN objCodeParaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeParaDA.GetSpecSQLObj();
strSQL = "Select * from CodePara where CodeParaId = " + "'"+ objCodeParaEN.CodeParaId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objCodeParaEN.CodeParaId = objDT.Rows[0][conCodePara.CodeParaId].ToString().Trim(); //代码参数Id(字段类型:char,字段长度:8,是否可空:True)
 objCodeParaEN.CodeParaName = objDT.Rows[0][conCodePara.CodeParaName].ToString().Trim(); //代码参数名(字段类型:varchar,字段长度:50,是否可空:True)
 objCodeParaEN.DataTypeId = objDT.Rows[0][conCodePara.DataTypeId].ToString().Trim(); //数据类型Id(字段类型:char,字段长度:2,是否可空:False)
 objCodeParaEN.TabId = objDT.Rows[0][conCodePara.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objCodeParaEN.FldId = objDT.Rows[0][conCodePara.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objCodeParaEN.PrjId = objDT.Rows[0][conCodePara.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objCodeParaEN.CodeParaContent = objDT.Rows[0][conCodePara.CodeParaContent].ToString().Trim(); //代码参数内容(字段类型:varchar,字段长度:100,是否可空:True)
 objCodeParaEN.UpdDate = objDT.Rows[0][conCodePara.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCodeParaEN.UpdUser = objDT.Rows[0][conCodePara.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objCodeParaEN.Memo = objDT.Rows[0][conCodePara.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsCodeParaDA: GetCodePara)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCodeParaId">表关键字</param>
 /// <returns>表对象</returns>
public clsCodeParaEN GetObjByCodeParaId(string strCodeParaId)
{
CheckPrimaryKey(strCodeParaId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeParaDA.GetSpecSQLObj();
strSQL = "Select * from CodePara where CodeParaId = " + "'"+ strCodeParaId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsCodeParaEN objCodeParaEN = new clsCodeParaEN();
try
{
 objCodeParaEN.CodeParaId = objRow[conCodePara.CodeParaId].ToString().Trim(); //代码参数Id(字段类型:char,字段长度:8,是否可空:True)
 objCodeParaEN.CodeParaName = objRow[conCodePara.CodeParaName].ToString().Trim(); //代码参数名(字段类型:varchar,字段长度:50,是否可空:True)
 objCodeParaEN.DataTypeId = objRow[conCodePara.DataTypeId].ToString().Trim(); //数据类型Id(字段类型:char,字段长度:2,是否可空:False)
 objCodeParaEN.TabId = objRow[conCodePara.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objCodeParaEN.FldId = objRow[conCodePara.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objCodeParaEN.PrjId = objRow[conCodePara.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objCodeParaEN.CodeParaContent = objRow[conCodePara.CodeParaContent] == DBNull.Value ? null : objRow[conCodePara.CodeParaContent].ToString().Trim(); //代码参数内容(字段类型:varchar,字段长度:100,是否可空:True)
 objCodeParaEN.UpdDate = objRow[conCodePara.UpdDate] == DBNull.Value ? null : objRow[conCodePara.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCodeParaEN.UpdUser = objRow[conCodePara.UpdUser] == DBNull.Value ? null : objRow[conCodePara.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objCodeParaEN.Memo = objRow[conCodePara.Memo] == DBNull.Value ? null : objRow[conCodePara.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsCodeParaDA: GetObjByCodeParaId)", objException.Message));
}
return objCodeParaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsCodeParaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsCodeParaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeParaDA.GetSpecSQLObj();
strSQL = "Select * from CodePara where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsCodeParaEN objCodeParaEN = new clsCodeParaEN()
{
CodeParaId = objRow[conCodePara.CodeParaId].ToString().Trim(), //代码参数Id
CodeParaName = objRow[conCodePara.CodeParaName].ToString().Trim(), //代码参数名
DataTypeId = objRow[conCodePara.DataTypeId].ToString().Trim(), //数据类型Id
TabId = objRow[conCodePara.TabId].ToString().Trim(), //表ID
FldId = objRow[conCodePara.FldId].ToString().Trim(), //字段Id
PrjId = objRow[conCodePara.PrjId].ToString().Trim(), //工程Id
CodeParaContent = objRow[conCodePara.CodeParaContent] == DBNull.Value ? null : objRow[conCodePara.CodeParaContent].ToString().Trim(), //代码参数内容
UpdDate = objRow[conCodePara.UpdDate] == DBNull.Value ? null : objRow[conCodePara.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conCodePara.UpdUser] == DBNull.Value ? null : objRow[conCodePara.UpdUser].ToString().Trim(), //修改者
Memo = objRow[conCodePara.Memo] == DBNull.Value ? null : objRow[conCodePara.Memo].ToString().Trim() //说明
};
objCodeParaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCodeParaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsCodeParaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsCodeParaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCodeParaEN objCodeParaEN = new clsCodeParaEN();
try
{
objCodeParaEN.CodeParaId = objRow[conCodePara.CodeParaId].ToString().Trim(); //代码参数Id
objCodeParaEN.CodeParaName = objRow[conCodePara.CodeParaName].ToString().Trim(); //代码参数名
objCodeParaEN.DataTypeId = objRow[conCodePara.DataTypeId].ToString().Trim(); //数据类型Id
objCodeParaEN.TabId = objRow[conCodePara.TabId].ToString().Trim(); //表ID
objCodeParaEN.FldId = objRow[conCodePara.FldId].ToString().Trim(); //字段Id
objCodeParaEN.PrjId = objRow[conCodePara.PrjId].ToString().Trim(); //工程Id
objCodeParaEN.CodeParaContent = objRow[conCodePara.CodeParaContent] == DBNull.Value ? null : objRow[conCodePara.CodeParaContent].ToString().Trim(); //代码参数内容
objCodeParaEN.UpdDate = objRow[conCodePara.UpdDate] == DBNull.Value ? null : objRow[conCodePara.UpdDate].ToString().Trim(); //修改日期
objCodeParaEN.UpdUser = objRow[conCodePara.UpdUser] == DBNull.Value ? null : objRow[conCodePara.UpdUser].ToString().Trim(); //修改者
objCodeParaEN.Memo = objRow[conCodePara.Memo] == DBNull.Value ? null : objRow[conCodePara.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsCodeParaDA: GetObjByDataRowCodePara)", objException.Message));
}
objCodeParaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCodeParaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsCodeParaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCodeParaEN objCodeParaEN = new clsCodeParaEN();
try
{
objCodeParaEN.CodeParaId = objRow[conCodePara.CodeParaId].ToString().Trim(); //代码参数Id
objCodeParaEN.CodeParaName = objRow[conCodePara.CodeParaName].ToString().Trim(); //代码参数名
objCodeParaEN.DataTypeId = objRow[conCodePara.DataTypeId].ToString().Trim(); //数据类型Id
objCodeParaEN.TabId = objRow[conCodePara.TabId].ToString().Trim(); //表ID
objCodeParaEN.FldId = objRow[conCodePara.FldId].ToString().Trim(); //字段Id
objCodeParaEN.PrjId = objRow[conCodePara.PrjId].ToString().Trim(); //工程Id
objCodeParaEN.CodeParaContent = objRow[conCodePara.CodeParaContent] == DBNull.Value ? null : objRow[conCodePara.CodeParaContent].ToString().Trim(); //代码参数内容
objCodeParaEN.UpdDate = objRow[conCodePara.UpdDate] == DBNull.Value ? null : objRow[conCodePara.UpdDate].ToString().Trim(); //修改日期
objCodeParaEN.UpdUser = objRow[conCodePara.UpdUser] == DBNull.Value ? null : objRow[conCodePara.UpdUser].ToString().Trim(); //修改者
objCodeParaEN.Memo = objRow[conCodePara.Memo] == DBNull.Value ? null : objRow[conCodePara.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsCodeParaDA: GetObjByDataRow)", objException.Message));
}
objCodeParaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCodeParaEN;
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
objSQL = clsCodeParaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCodeParaEN._CurrTabName, conCodePara.CodeParaId, 8, "");
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
objSQL = clsCodeParaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCodeParaEN._CurrTabName, conCodePara.CodeParaId, 8, strPrefix);
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
 objSQL = clsCodeParaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select CodeParaId from CodePara where " + strCondition;
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
 objSQL = clsCodeParaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select CodeParaId from CodePara where " + strCondition;
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
 /// <param name = "strCodeParaId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strCodeParaId)
{
CheckPrimaryKey(strCodeParaId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeParaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CodePara", "CodeParaId = " + "'"+ strCodeParaId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsCodeParaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeParaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CodePara", strCondition))
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
objSQL = clsCodeParaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("CodePara");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsCodeParaEN objCodeParaEN)
 {
 objCodeParaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCodeParaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCodeParaEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeParaDA.GetSpecSQLObj();
strSQL = "Select * from CodePara where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CodePara");
objRow = objDS.Tables["CodePara"].NewRow();
objRow[conCodePara.CodeParaId] = objCodeParaEN.CodeParaId; //代码参数Id
objRow[conCodePara.CodeParaName] = objCodeParaEN.CodeParaName; //代码参数名
objRow[conCodePara.DataTypeId] = objCodeParaEN.DataTypeId; //数据类型Id
objRow[conCodePara.TabId] = objCodeParaEN.TabId; //表ID
objRow[conCodePara.FldId] = objCodeParaEN.FldId; //字段Id
objRow[conCodePara.PrjId] = objCodeParaEN.PrjId; //工程Id
 if (objCodeParaEN.CodeParaContent !=  "")
 {
objRow[conCodePara.CodeParaContent] = objCodeParaEN.CodeParaContent; //代码参数内容
 }
 if (objCodeParaEN.UpdDate !=  "")
 {
objRow[conCodePara.UpdDate] = objCodeParaEN.UpdDate; //修改日期
 }
 if (objCodeParaEN.UpdUser !=  "")
 {
objRow[conCodePara.UpdUser] = objCodeParaEN.UpdUser; //修改者
 }
 if (objCodeParaEN.Memo !=  "")
 {
objRow[conCodePara.Memo] = objCodeParaEN.Memo; //说明
 }
objDS.Tables[clsCodeParaEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsCodeParaEN._CurrTabName);
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
 /// <param name = "objCodeParaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCodeParaEN objCodeParaEN)
{
 objCodeParaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCodeParaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCodeParaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCodeParaEN.CodeParaId !=  null)
 {
 arrFieldListForInsert.Add(conCodePara.CodeParaId);
 var strCodeParaId = objCodeParaEN.CodeParaId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeParaId + "'");
 }
 
 if (objCodeParaEN.CodeParaName !=  null)
 {
 arrFieldListForInsert.Add(conCodePara.CodeParaName);
 var strCodeParaName = objCodeParaEN.CodeParaName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeParaName + "'");
 }
 
 if (objCodeParaEN.DataTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCodePara.DataTypeId);
 var strDataTypeId = objCodeParaEN.DataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataTypeId + "'");
 }
 
 if (objCodeParaEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conCodePara.TabId);
 var strTabId = objCodeParaEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objCodeParaEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conCodePara.FldId);
 var strFldId = objCodeParaEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 if (objCodeParaEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conCodePara.PrjId);
 var strPrjId = objCodeParaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objCodeParaEN.CodeParaContent !=  null)
 {
 arrFieldListForInsert.Add(conCodePara.CodeParaContent);
 var strCodeParaContent = objCodeParaEN.CodeParaContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeParaContent + "'");
 }
 
 if (objCodeParaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCodePara.UpdDate);
 var strUpdDate = objCodeParaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCodeParaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCodePara.UpdUser);
 var strUpdUser = objCodeParaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objCodeParaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCodePara.Memo);
 var strMemo = objCodeParaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CodePara");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeParaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objCodeParaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCodeParaEN objCodeParaEN)
{
 objCodeParaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCodeParaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCodeParaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCodeParaEN.CodeParaId !=  null)
 {
 arrFieldListForInsert.Add(conCodePara.CodeParaId);
 var strCodeParaId = objCodeParaEN.CodeParaId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeParaId + "'");
 }
 
 if (objCodeParaEN.CodeParaName !=  null)
 {
 arrFieldListForInsert.Add(conCodePara.CodeParaName);
 var strCodeParaName = objCodeParaEN.CodeParaName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeParaName + "'");
 }
 
 if (objCodeParaEN.DataTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCodePara.DataTypeId);
 var strDataTypeId = objCodeParaEN.DataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataTypeId + "'");
 }
 
 if (objCodeParaEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conCodePara.TabId);
 var strTabId = objCodeParaEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objCodeParaEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conCodePara.FldId);
 var strFldId = objCodeParaEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 if (objCodeParaEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conCodePara.PrjId);
 var strPrjId = objCodeParaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objCodeParaEN.CodeParaContent !=  null)
 {
 arrFieldListForInsert.Add(conCodePara.CodeParaContent);
 var strCodeParaContent = objCodeParaEN.CodeParaContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeParaContent + "'");
 }
 
 if (objCodeParaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCodePara.UpdDate);
 var strUpdDate = objCodeParaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCodeParaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCodePara.UpdUser);
 var strUpdUser = objCodeParaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objCodeParaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCodePara.Memo);
 var strMemo = objCodeParaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CodePara");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeParaDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objCodeParaEN.CodeParaId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objCodeParaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCodeParaEN objCodeParaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objCodeParaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCodeParaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCodeParaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCodeParaEN.CodeParaId !=  null)
 {
 arrFieldListForInsert.Add(conCodePara.CodeParaId);
 var strCodeParaId = objCodeParaEN.CodeParaId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeParaId + "'");
 }
 
 if (objCodeParaEN.CodeParaName !=  null)
 {
 arrFieldListForInsert.Add(conCodePara.CodeParaName);
 var strCodeParaName = objCodeParaEN.CodeParaName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeParaName + "'");
 }
 
 if (objCodeParaEN.DataTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCodePara.DataTypeId);
 var strDataTypeId = objCodeParaEN.DataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataTypeId + "'");
 }
 
 if (objCodeParaEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conCodePara.TabId);
 var strTabId = objCodeParaEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objCodeParaEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conCodePara.FldId);
 var strFldId = objCodeParaEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 if (objCodeParaEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conCodePara.PrjId);
 var strPrjId = objCodeParaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objCodeParaEN.CodeParaContent !=  null)
 {
 arrFieldListForInsert.Add(conCodePara.CodeParaContent);
 var strCodeParaContent = objCodeParaEN.CodeParaContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeParaContent + "'");
 }
 
 if (objCodeParaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCodePara.UpdDate);
 var strUpdDate = objCodeParaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCodeParaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCodePara.UpdUser);
 var strUpdUser = objCodeParaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objCodeParaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCodePara.Memo);
 var strMemo = objCodeParaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CodePara");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeParaDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objCodeParaEN.CodeParaId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objCodeParaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCodeParaEN objCodeParaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objCodeParaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCodeParaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCodeParaEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCodeParaEN.CodeParaId !=  null)
 {
 arrFieldListForInsert.Add(conCodePara.CodeParaId);
 var strCodeParaId = objCodeParaEN.CodeParaId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeParaId + "'");
 }
 
 if (objCodeParaEN.CodeParaName !=  null)
 {
 arrFieldListForInsert.Add(conCodePara.CodeParaName);
 var strCodeParaName = objCodeParaEN.CodeParaName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeParaName + "'");
 }
 
 if (objCodeParaEN.DataTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCodePara.DataTypeId);
 var strDataTypeId = objCodeParaEN.DataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataTypeId + "'");
 }
 
 if (objCodeParaEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conCodePara.TabId);
 var strTabId = objCodeParaEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objCodeParaEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conCodePara.FldId);
 var strFldId = objCodeParaEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 if (objCodeParaEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conCodePara.PrjId);
 var strPrjId = objCodeParaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objCodeParaEN.CodeParaContent !=  null)
 {
 arrFieldListForInsert.Add(conCodePara.CodeParaContent);
 var strCodeParaContent = objCodeParaEN.CodeParaContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeParaContent + "'");
 }
 
 if (objCodeParaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCodePara.UpdDate);
 var strUpdDate = objCodeParaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCodeParaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCodePara.UpdUser);
 var strUpdUser = objCodeParaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objCodeParaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCodePara.Memo);
 var strMemo = objCodeParaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CodePara");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeParaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewCodeParas(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeParaDA.GetSpecSQLObj();
strSQL = "Select * from CodePara where CodeParaId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CodePara");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strCodeParaId = oRow[conCodePara.CodeParaId].ToString().Trim();
if (IsExist(strCodeParaId))
{
 string strResult = "关键字变量值为:" + string.Format("CodeParaId = {0}", strCodeParaId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsCodeParaEN._CurrTabName ].NewRow();
objRow[conCodePara.CodeParaId] = oRow[conCodePara.CodeParaId].ToString().Trim(); //代码参数Id
objRow[conCodePara.CodeParaName] = oRow[conCodePara.CodeParaName].ToString().Trim(); //代码参数名
objRow[conCodePara.DataTypeId] = oRow[conCodePara.DataTypeId].ToString().Trim(); //数据类型Id
objRow[conCodePara.TabId] = oRow[conCodePara.TabId].ToString().Trim(); //表ID
objRow[conCodePara.FldId] = oRow[conCodePara.FldId].ToString().Trim(); //字段Id
objRow[conCodePara.PrjId] = oRow[conCodePara.PrjId].ToString().Trim(); //工程Id
objRow[conCodePara.CodeParaContent] = oRow[conCodePara.CodeParaContent].ToString().Trim(); //代码参数内容
objRow[conCodePara.UpdDate] = oRow[conCodePara.UpdDate].ToString().Trim(); //修改日期
objRow[conCodePara.UpdUser] = oRow[conCodePara.UpdUser].ToString().Trim(); //修改者
objRow[conCodePara.Memo] = oRow[conCodePara.Memo].ToString().Trim(); //说明
 objDS.Tables[clsCodeParaEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsCodeParaEN._CurrTabName);
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
 /// <param name = "objCodeParaEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsCodeParaEN objCodeParaEN)
{
 objCodeParaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCodeParaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCodeParaEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeParaDA.GetSpecSQLObj();
strSQL = "Select * from CodePara where CodeParaId = " + "'"+ objCodeParaEN.CodeParaId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsCodeParaEN._CurrTabName);
if (objDS.Tables[clsCodeParaEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:CodeParaId = " + "'"+ objCodeParaEN.CodeParaId+"'");
return false;
}
objRow = objDS.Tables[clsCodeParaEN._CurrTabName].Rows[0];
 if (objCodeParaEN.IsUpdated(conCodePara.CodeParaId))
 {
objRow[conCodePara.CodeParaId] = objCodeParaEN.CodeParaId; //代码参数Id
 }
 if (objCodeParaEN.IsUpdated(conCodePara.CodeParaName))
 {
objRow[conCodePara.CodeParaName] = objCodeParaEN.CodeParaName; //代码参数名
 }
 if (objCodeParaEN.IsUpdated(conCodePara.DataTypeId))
 {
objRow[conCodePara.DataTypeId] = objCodeParaEN.DataTypeId; //数据类型Id
 }
 if (objCodeParaEN.IsUpdated(conCodePara.TabId))
 {
objRow[conCodePara.TabId] = objCodeParaEN.TabId; //表ID
 }
 if (objCodeParaEN.IsUpdated(conCodePara.FldId))
 {
objRow[conCodePara.FldId] = objCodeParaEN.FldId; //字段Id
 }
 if (objCodeParaEN.IsUpdated(conCodePara.PrjId))
 {
objRow[conCodePara.PrjId] = objCodeParaEN.PrjId; //工程Id
 }
 if (objCodeParaEN.IsUpdated(conCodePara.CodeParaContent))
 {
objRow[conCodePara.CodeParaContent] = objCodeParaEN.CodeParaContent; //代码参数内容
 }
 if (objCodeParaEN.IsUpdated(conCodePara.UpdDate))
 {
objRow[conCodePara.UpdDate] = objCodeParaEN.UpdDate; //修改日期
 }
 if (objCodeParaEN.IsUpdated(conCodePara.UpdUser))
 {
objRow[conCodePara.UpdUser] = objCodeParaEN.UpdUser; //修改者
 }
 if (objCodeParaEN.IsUpdated(conCodePara.Memo))
 {
objRow[conCodePara.Memo] = objCodeParaEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsCodeParaEN._CurrTabName);
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
 /// <param name = "objCodeParaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCodeParaEN objCodeParaEN)
{
 objCodeParaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCodeParaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCodeParaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeParaDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update CodePara Set ");
 
 if (objCodeParaEN.IsUpdated(conCodePara.CodeParaName))
 {
 if (objCodeParaEN.CodeParaName !=  null)
 {
 var strCodeParaName = objCodeParaEN.CodeParaName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCodeParaName, conCodePara.CodeParaName); //代码参数名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodePara.CodeParaName); //代码参数名
 }
 }
 
 if (objCodeParaEN.IsUpdated(conCodePara.DataTypeId))
 {
 if (objCodeParaEN.DataTypeId !=  null)
 {
 var strDataTypeId = objCodeParaEN.DataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataTypeId, conCodePara.DataTypeId); //数据类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodePara.DataTypeId); //数据类型Id
 }
 }
 
 if (objCodeParaEN.IsUpdated(conCodePara.TabId))
 {
 if (objCodeParaEN.TabId !=  null)
 {
 var strTabId = objCodeParaEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabId, conCodePara.TabId); //表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodePara.TabId); //表ID
 }
 }
 
 if (objCodeParaEN.IsUpdated(conCodePara.FldId))
 {
 if (objCodeParaEN.FldId !=  null)
 {
 var strFldId = objCodeParaEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldId, conCodePara.FldId); //字段Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodePara.FldId); //字段Id
 }
 }
 
 if (objCodeParaEN.IsUpdated(conCodePara.PrjId))
 {
 if (objCodeParaEN.PrjId !=  null)
 {
 var strPrjId = objCodeParaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conCodePara.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodePara.PrjId); //工程Id
 }
 }
 
 if (objCodeParaEN.IsUpdated(conCodePara.CodeParaContent))
 {
 if (objCodeParaEN.CodeParaContent !=  null)
 {
 var strCodeParaContent = objCodeParaEN.CodeParaContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCodeParaContent, conCodePara.CodeParaContent); //代码参数内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodePara.CodeParaContent); //代码参数内容
 }
 }
 
 if (objCodeParaEN.IsUpdated(conCodePara.UpdDate))
 {
 if (objCodeParaEN.UpdDate !=  null)
 {
 var strUpdDate = objCodeParaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conCodePara.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodePara.UpdDate); //修改日期
 }
 }
 
 if (objCodeParaEN.IsUpdated(conCodePara.UpdUser))
 {
 if (objCodeParaEN.UpdUser !=  null)
 {
 var strUpdUser = objCodeParaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conCodePara.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodePara.UpdUser); //修改者
 }
 }
 
 if (objCodeParaEN.IsUpdated(conCodePara.Memo))
 {
 if (objCodeParaEN.Memo !=  null)
 {
 var strMemo = objCodeParaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCodePara.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodePara.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where CodeParaId = '{0}'", objCodeParaEN.CodeParaId); 
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
 /// <param name = "objCodeParaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsCodeParaEN objCodeParaEN, string strCondition)
{
 objCodeParaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCodeParaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCodeParaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeParaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CodePara Set ");
 
 if (objCodeParaEN.IsUpdated(conCodePara.CodeParaName))
 {
 if (objCodeParaEN.CodeParaName !=  null)
 {
 var strCodeParaName = objCodeParaEN.CodeParaName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodeParaName = '{0}',", strCodeParaName); //代码参数名
 }
 else
 {
 sbSQL.Append(" CodeParaName = null,"); //代码参数名
 }
 }
 
 if (objCodeParaEN.IsUpdated(conCodePara.DataTypeId))
 {
 if (objCodeParaEN.DataTypeId !=  null)
 {
 var strDataTypeId = objCodeParaEN.DataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataTypeId = '{0}',", strDataTypeId); //数据类型Id
 }
 else
 {
 sbSQL.Append(" DataTypeId = null,"); //数据类型Id
 }
 }
 
 if (objCodeParaEN.IsUpdated(conCodePara.TabId))
 {
 if (objCodeParaEN.TabId !=  null)
 {
 var strTabId = objCodeParaEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabId = '{0}',", strTabId); //表ID
 }
 else
 {
 sbSQL.Append(" TabId = null,"); //表ID
 }
 }
 
 if (objCodeParaEN.IsUpdated(conCodePara.FldId))
 {
 if (objCodeParaEN.FldId !=  null)
 {
 var strFldId = objCodeParaEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldId = '{0}',", strFldId); //字段Id
 }
 else
 {
 sbSQL.Append(" FldId = null,"); //字段Id
 }
 }
 
 if (objCodeParaEN.IsUpdated(conCodePara.PrjId))
 {
 if (objCodeParaEN.PrjId !=  null)
 {
 var strPrjId = objCodeParaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objCodeParaEN.IsUpdated(conCodePara.CodeParaContent))
 {
 if (objCodeParaEN.CodeParaContent !=  null)
 {
 var strCodeParaContent = objCodeParaEN.CodeParaContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodeParaContent = '{0}',", strCodeParaContent); //代码参数内容
 }
 else
 {
 sbSQL.Append(" CodeParaContent = null,"); //代码参数内容
 }
 }
 
 if (objCodeParaEN.IsUpdated(conCodePara.UpdDate))
 {
 if (objCodeParaEN.UpdDate !=  null)
 {
 var strUpdDate = objCodeParaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objCodeParaEN.IsUpdated(conCodePara.UpdUser))
 {
 if (objCodeParaEN.UpdUser !=  null)
 {
 var strUpdUser = objCodeParaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objCodeParaEN.IsUpdated(conCodePara.Memo))
 {
 if (objCodeParaEN.Memo !=  null)
 {
 var strMemo = objCodeParaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objCodeParaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsCodeParaEN objCodeParaEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objCodeParaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCodeParaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCodeParaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeParaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CodePara Set ");
 
 if (objCodeParaEN.IsUpdated(conCodePara.CodeParaName))
 {
 if (objCodeParaEN.CodeParaName !=  null)
 {
 var strCodeParaName = objCodeParaEN.CodeParaName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodeParaName = '{0}',", strCodeParaName); //代码参数名
 }
 else
 {
 sbSQL.Append(" CodeParaName = null,"); //代码参数名
 }
 }
 
 if (objCodeParaEN.IsUpdated(conCodePara.DataTypeId))
 {
 if (objCodeParaEN.DataTypeId !=  null)
 {
 var strDataTypeId = objCodeParaEN.DataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataTypeId = '{0}',", strDataTypeId); //数据类型Id
 }
 else
 {
 sbSQL.Append(" DataTypeId = null,"); //数据类型Id
 }
 }
 
 if (objCodeParaEN.IsUpdated(conCodePara.TabId))
 {
 if (objCodeParaEN.TabId !=  null)
 {
 var strTabId = objCodeParaEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabId = '{0}',", strTabId); //表ID
 }
 else
 {
 sbSQL.Append(" TabId = null,"); //表ID
 }
 }
 
 if (objCodeParaEN.IsUpdated(conCodePara.FldId))
 {
 if (objCodeParaEN.FldId !=  null)
 {
 var strFldId = objCodeParaEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldId = '{0}',", strFldId); //字段Id
 }
 else
 {
 sbSQL.Append(" FldId = null,"); //字段Id
 }
 }
 
 if (objCodeParaEN.IsUpdated(conCodePara.PrjId))
 {
 if (objCodeParaEN.PrjId !=  null)
 {
 var strPrjId = objCodeParaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objCodeParaEN.IsUpdated(conCodePara.CodeParaContent))
 {
 if (objCodeParaEN.CodeParaContent !=  null)
 {
 var strCodeParaContent = objCodeParaEN.CodeParaContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodeParaContent = '{0}',", strCodeParaContent); //代码参数内容
 }
 else
 {
 sbSQL.Append(" CodeParaContent = null,"); //代码参数内容
 }
 }
 
 if (objCodeParaEN.IsUpdated(conCodePara.UpdDate))
 {
 if (objCodeParaEN.UpdDate !=  null)
 {
 var strUpdDate = objCodeParaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objCodeParaEN.IsUpdated(conCodePara.UpdUser))
 {
 if (objCodeParaEN.UpdUser !=  null)
 {
 var strUpdUser = objCodeParaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objCodeParaEN.IsUpdated(conCodePara.Memo))
 {
 if (objCodeParaEN.Memo !=  null)
 {
 var strMemo = objCodeParaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objCodeParaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCodeParaEN objCodeParaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objCodeParaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCodeParaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCodeParaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeParaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CodePara Set ");
 
 if (objCodeParaEN.IsUpdated(conCodePara.CodeParaName))
 {
 if (objCodeParaEN.CodeParaName !=  null)
 {
 var strCodeParaName = objCodeParaEN.CodeParaName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCodeParaName, conCodePara.CodeParaName); //代码参数名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodePara.CodeParaName); //代码参数名
 }
 }
 
 if (objCodeParaEN.IsUpdated(conCodePara.DataTypeId))
 {
 if (objCodeParaEN.DataTypeId !=  null)
 {
 var strDataTypeId = objCodeParaEN.DataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataTypeId, conCodePara.DataTypeId); //数据类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodePara.DataTypeId); //数据类型Id
 }
 }
 
 if (objCodeParaEN.IsUpdated(conCodePara.TabId))
 {
 if (objCodeParaEN.TabId !=  null)
 {
 var strTabId = objCodeParaEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabId, conCodePara.TabId); //表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodePara.TabId); //表ID
 }
 }
 
 if (objCodeParaEN.IsUpdated(conCodePara.FldId))
 {
 if (objCodeParaEN.FldId !=  null)
 {
 var strFldId = objCodeParaEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldId, conCodePara.FldId); //字段Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodePara.FldId); //字段Id
 }
 }
 
 if (objCodeParaEN.IsUpdated(conCodePara.PrjId))
 {
 if (objCodeParaEN.PrjId !=  null)
 {
 var strPrjId = objCodeParaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conCodePara.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodePara.PrjId); //工程Id
 }
 }
 
 if (objCodeParaEN.IsUpdated(conCodePara.CodeParaContent))
 {
 if (objCodeParaEN.CodeParaContent !=  null)
 {
 var strCodeParaContent = objCodeParaEN.CodeParaContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCodeParaContent, conCodePara.CodeParaContent); //代码参数内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodePara.CodeParaContent); //代码参数内容
 }
 }
 
 if (objCodeParaEN.IsUpdated(conCodePara.UpdDate))
 {
 if (objCodeParaEN.UpdDate !=  null)
 {
 var strUpdDate = objCodeParaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conCodePara.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodePara.UpdDate); //修改日期
 }
 }
 
 if (objCodeParaEN.IsUpdated(conCodePara.UpdUser))
 {
 if (objCodeParaEN.UpdUser !=  null)
 {
 var strUpdUser = objCodeParaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conCodePara.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodePara.UpdUser); //修改者
 }
 }
 
 if (objCodeParaEN.IsUpdated(conCodePara.Memo))
 {
 if (objCodeParaEN.Memo !=  null)
 {
 var strMemo = objCodeParaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCodePara.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodePara.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where CodeParaId = '{0}'", objCodeParaEN.CodeParaId); 
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
 /// <param name = "strCodeParaId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strCodeParaId) 
{
CheckPrimaryKey(strCodeParaId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeParaDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strCodeParaId,
};
 objSQL.ExecSP("CodePara_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strCodeParaId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strCodeParaId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strCodeParaId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeParaDA.GetSpecSQLObj();
//删除CodePara本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CodePara where CodeParaId = " + "'"+ strCodeParaId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelCodePara(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeParaDA.GetSpecSQLObj();
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
//删除CodePara本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CodePara where CodeParaId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strCodeParaId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strCodeParaId) 
{
CheckPrimaryKey(strCodeParaId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeParaDA.GetSpecSQLObj();
//删除CodePara本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CodePara where CodeParaId = " + "'"+ strCodeParaId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelCodePara(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsCodeParaDA: DelCodePara)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeParaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CodePara where " + strCondition ;
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
public bool DelCodeParaWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsCodeParaDA: DelCodeParaWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeParaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CodePara where " + strCondition ;
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
 /// <param name = "objCodeParaENS">源对象</param>
 /// <param name = "objCodeParaENT">目标对象</param>
public void CopyTo(clsCodeParaEN objCodeParaENS, clsCodeParaEN objCodeParaENT)
{
objCodeParaENT.CodeParaId = objCodeParaENS.CodeParaId; //代码参数Id
objCodeParaENT.CodeParaName = objCodeParaENS.CodeParaName; //代码参数名
objCodeParaENT.DataTypeId = objCodeParaENS.DataTypeId; //数据类型Id
objCodeParaENT.TabId = objCodeParaENS.TabId; //表ID
objCodeParaENT.FldId = objCodeParaENS.FldId; //字段Id
objCodeParaENT.PrjId = objCodeParaENS.PrjId; //工程Id
objCodeParaENT.CodeParaContent = objCodeParaENS.CodeParaContent; //代码参数内容
objCodeParaENT.UpdDate = objCodeParaENS.UpdDate; //修改日期
objCodeParaENT.UpdUser = objCodeParaENS.UpdUser; //修改者
objCodeParaENT.Memo = objCodeParaENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsCodeParaEN objCodeParaEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objCodeParaEN.CodeParaName, conCodePara.CodeParaName);
clsCheckSql.CheckFieldNotNull(objCodeParaEN.DataTypeId, conCodePara.DataTypeId);
clsCheckSql.CheckFieldNotNull(objCodeParaEN.TabId, conCodePara.TabId);
clsCheckSql.CheckFieldNotNull(objCodeParaEN.FldId, conCodePara.FldId);
clsCheckSql.CheckFieldNotNull(objCodeParaEN.PrjId, conCodePara.PrjId);
//检查字段长度
clsCheckSql.CheckFieldLen(objCodeParaEN.CodeParaId, 8, conCodePara.CodeParaId);
clsCheckSql.CheckFieldLen(objCodeParaEN.CodeParaName, 50, conCodePara.CodeParaName);
clsCheckSql.CheckFieldLen(objCodeParaEN.DataTypeId, 2, conCodePara.DataTypeId);
clsCheckSql.CheckFieldLen(objCodeParaEN.TabId, 8, conCodePara.TabId);
clsCheckSql.CheckFieldLen(objCodeParaEN.FldId, 8, conCodePara.FldId);
clsCheckSql.CheckFieldLen(objCodeParaEN.PrjId, 4, conCodePara.PrjId);
clsCheckSql.CheckFieldLen(objCodeParaEN.CodeParaContent, 100, conCodePara.CodeParaContent);
clsCheckSql.CheckFieldLen(objCodeParaEN.UpdDate, 20, conCodePara.UpdDate);
clsCheckSql.CheckFieldLen(objCodeParaEN.UpdUser, 20, conCodePara.UpdUser);
clsCheckSql.CheckFieldLen(objCodeParaEN.Memo, 1000, conCodePara.Memo);
//检查字段外键固定长度
 objCodeParaEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsCodeParaEN objCodeParaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCodeParaEN.CodeParaName, 50, conCodePara.CodeParaName);
clsCheckSql.CheckFieldLen(objCodeParaEN.DataTypeId, 2, conCodePara.DataTypeId);
clsCheckSql.CheckFieldLen(objCodeParaEN.TabId, 8, conCodePara.TabId);
clsCheckSql.CheckFieldLen(objCodeParaEN.FldId, 8, conCodePara.FldId);
clsCheckSql.CheckFieldLen(objCodeParaEN.PrjId, 4, conCodePara.PrjId);
clsCheckSql.CheckFieldLen(objCodeParaEN.CodeParaContent, 100, conCodePara.CodeParaContent);
clsCheckSql.CheckFieldLen(objCodeParaEN.UpdDate, 20, conCodePara.UpdDate);
clsCheckSql.CheckFieldLen(objCodeParaEN.UpdUser, 20, conCodePara.UpdUser);
clsCheckSql.CheckFieldLen(objCodeParaEN.Memo, 1000, conCodePara.Memo);
//检查外键字段长度
 objCodeParaEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsCodeParaEN objCodeParaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCodeParaEN.CodeParaId, 8, conCodePara.CodeParaId);
clsCheckSql.CheckFieldLen(objCodeParaEN.CodeParaName, 50, conCodePara.CodeParaName);
clsCheckSql.CheckFieldLen(objCodeParaEN.DataTypeId, 2, conCodePara.DataTypeId);
clsCheckSql.CheckFieldLen(objCodeParaEN.TabId, 8, conCodePara.TabId);
clsCheckSql.CheckFieldLen(objCodeParaEN.FldId, 8, conCodePara.FldId);
clsCheckSql.CheckFieldLen(objCodeParaEN.PrjId, 4, conCodePara.PrjId);
clsCheckSql.CheckFieldLen(objCodeParaEN.CodeParaContent, 100, conCodePara.CodeParaContent);
clsCheckSql.CheckFieldLen(objCodeParaEN.UpdDate, 20, conCodePara.UpdDate);
clsCheckSql.CheckFieldLen(objCodeParaEN.UpdUser, 20, conCodePara.UpdUser);
clsCheckSql.CheckFieldLen(objCodeParaEN.Memo, 1000, conCodePara.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objCodeParaEN.CodeParaId, conCodePara.CodeParaId);
clsCheckSql.CheckSqlInjection4Field(objCodeParaEN.CodeParaName, conCodePara.CodeParaName);
clsCheckSql.CheckSqlInjection4Field(objCodeParaEN.DataTypeId, conCodePara.DataTypeId);
clsCheckSql.CheckSqlInjection4Field(objCodeParaEN.TabId, conCodePara.TabId);
clsCheckSql.CheckSqlInjection4Field(objCodeParaEN.FldId, conCodePara.FldId);
clsCheckSql.CheckSqlInjection4Field(objCodeParaEN.PrjId, conCodePara.PrjId);
clsCheckSql.CheckSqlInjection4Field(objCodeParaEN.CodeParaContent, conCodePara.CodeParaContent);
clsCheckSql.CheckSqlInjection4Field(objCodeParaEN.UpdDate, conCodePara.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objCodeParaEN.UpdUser, conCodePara.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objCodeParaEN.Memo, conCodePara.Memo);
//检查外键字段长度
 objCodeParaEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetCodeParaId()
{
//获取某学院所有专业信息
string strSQL = "select CodeParaId, CodeParaName from CodePara ";
 clsSpecSQLforSql mySql = clsCodeParaDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

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
 objSQL = clsCodeParaDA.GetSpecSQLObj();
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
 objSQL = clsCodeParaDA.GetSpecSQLObj();
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
 objSQL = clsCodeParaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCodeParaEN._CurrTabName);
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
 objSQL = clsCodeParaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCodeParaEN._CurrTabName, strCondition);
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
 objSQL = clsCodeParaDA.GetSpecSQLObj();
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
 objSQL = clsCodeParaDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}