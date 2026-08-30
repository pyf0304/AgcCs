
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsdm_cardinality_type_dictDA
 表名:dm_cardinality_type_dict(00050661)
 * 版本:2026.08.13(服务器:WIN-SRV103-116)
 日期:2026/08/14 16:37:20
 生成者:pyf_agc
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:数据模型图(ModelDiagram)
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
 /// 关系类型字典表(dm_cardinality_type_dict)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsdm_cardinality_type_dictDA : clsCommBase4DA
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
 return clsdm_cardinality_type_dictEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsdm_cardinality_type_dictEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsdm_cardinality_type_dictEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsdm_cardinality_type_dictEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsdm_cardinality_type_dictEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strcardinality_code">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strcardinality_code)
{
strcardinality_code = strcardinality_code.Replace("'", "''");
if (strcardinality_code.Length > 30)
{
throw new Exception("(errid:Data000001)在表:dm_cardinality_type_dict中,检查关键字,长度不正确!(clsdm_cardinality_type_dictDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strcardinality_code)  ==  true)
{
throw new Exception("(errid:Data000002)在表:dm_cardinality_type_dict中,关键字不能为空 或 null!(clsdm_cardinality_type_dictDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strcardinality_code);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsdm_cardinality_type_dictDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsdm_cardinality_type_dictDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_cardinality_type_dictDA.GetSpecSQLObj();
strSQL = "Select * from dm_cardinality_type_dict where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_dm_cardinality_type_dict(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsdm_cardinality_type_dictDA: GetDataTable_dm_cardinality_type_dict)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_cardinality_type_dictDA.GetSpecSQLObj();
strSQL = "Select * from dm_cardinality_type_dict where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsdm_cardinality_type_dictDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_cardinality_type_dictDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsdm_cardinality_type_dictDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_cardinality_type_dictDA.GetSpecSQLObj();
strSQL = "Select * from dm_cardinality_type_dict where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsdm_cardinality_type_dictDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_cardinality_type_dictDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsdm_cardinality_type_dictDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_cardinality_type_dictDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from dm_cardinality_type_dict where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from dm_cardinality_type_dict where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsdm_cardinality_type_dictDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_cardinality_type_dictDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from dm_cardinality_type_dict where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsdm_cardinality_type_dictDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_cardinality_type_dictDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} dm_cardinality_type_dict.* " + 
$"from dm_cardinality_type_dict " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and dm_cardinality_type_dict.cardinality_code not in " + 
$"(Select top {intTop_In} dm_cardinality_type_dict.cardinality_code from dm_cardinality_type_dict " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from dm_cardinality_type_dict where {1} and cardinality_code not in (Select top {2} cardinality_code from dm_cardinality_type_dict where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from dm_cardinality_type_dict where {1} and cardinality_code not in (Select top {3} cardinality_code from dm_cardinality_type_dict where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsdm_cardinality_type_dictDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_cardinality_type_dictDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} dm_cardinality_type_dict.* " + 
$"from dm_cardinality_type_dict " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and dm_cardinality_type_dict.cardinality_code not in " + 
$"(Select top {intTop_In} dm_cardinality_type_dict.cardinality_code from dm_cardinality_type_dict " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from dm_cardinality_type_dict where {1} and cardinality_code not in (Select top {2} cardinality_code from dm_cardinality_type_dict where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from dm_cardinality_type_dict where {1} and cardinality_code not in (Select top {3} cardinality_code from dm_cardinality_type_dict where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsdm_cardinality_type_dictEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsdm_cardinality_type_dictDA:GetObjLst)", objException.Message));
}
List<clsdm_cardinality_type_dictEN> arrObjLst = new List<clsdm_cardinality_type_dictEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_cardinality_type_dictDA.GetSpecSQLObj();
strSQL = "Select * from dm_cardinality_type_dict where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsdm_cardinality_type_dictEN objdm_cardinality_type_dictEN = new clsdm_cardinality_type_dictEN();
try
{
objdm_cardinality_type_dictEN.cardinality_code = objRow[condm_cardinality_type_dict.cardinality_code].ToString().Trim(); //基数编码
objdm_cardinality_type_dictEN.cardinality_name = objRow[condm_cardinality_type_dict.cardinality_name].ToString().Trim(); //基数名称
objdm_cardinality_type_dictEN.cardinality_desc = objRow[condm_cardinality_type_dict.cardinality_desc] == DBNull.Value ? null : objRow[condm_cardinality_type_dict.cardinality_desc].ToString().Trim(); //基数说明
objdm_cardinality_type_dictEN.is_active = TransNullToBool(objRow[condm_cardinality_type_dict.is_active].ToString().Trim()); //是否启用
objdm_cardinality_type_dictEN.arrow_mode = objRow[condm_cardinality_type_dict.arrow_mode] == DBNull.Value ? null : objRow[condm_cardinality_type_dict.arrow_mode].ToString().Trim(); //箭头模式
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsdm_cardinality_type_dictDA: GetObjLst)", objException.Message));
}
objdm_cardinality_type_dictEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objdm_cardinality_type_dictEN);
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
public List<clsdm_cardinality_type_dictEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsdm_cardinality_type_dictDA:GetObjLstByTabName)", objException.Message));
}
List<clsdm_cardinality_type_dictEN> arrObjLst = new List<clsdm_cardinality_type_dictEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_cardinality_type_dictDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsdm_cardinality_type_dictEN objdm_cardinality_type_dictEN = new clsdm_cardinality_type_dictEN();
try
{
objdm_cardinality_type_dictEN.cardinality_code = objRow[condm_cardinality_type_dict.cardinality_code].ToString().Trim(); //基数编码
objdm_cardinality_type_dictEN.cardinality_name = objRow[condm_cardinality_type_dict.cardinality_name].ToString().Trim(); //基数名称
objdm_cardinality_type_dictEN.cardinality_desc = objRow[condm_cardinality_type_dict.cardinality_desc] == DBNull.Value ? null : objRow[condm_cardinality_type_dict.cardinality_desc].ToString().Trim(); //基数说明
objdm_cardinality_type_dictEN.is_active = TransNullToBool(objRow[condm_cardinality_type_dict.is_active].ToString().Trim()); //是否启用
objdm_cardinality_type_dictEN.arrow_mode = objRow[condm_cardinality_type_dict.arrow_mode] == DBNull.Value ? null : objRow[condm_cardinality_type_dict.arrow_mode].ToString().Trim(); //箭头模式
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsdm_cardinality_type_dictDA: GetObjLst)", objException.Message));
}
objdm_cardinality_type_dictEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objdm_cardinality_type_dictEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objdm_cardinality_type_dictEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getdm_cardinality_type_dict(ref clsdm_cardinality_type_dictEN objdm_cardinality_type_dictEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_cardinality_type_dictDA.GetSpecSQLObj();
strSQL = "Select * from dm_cardinality_type_dict where cardinality_code = " + "'"+ objdm_cardinality_type_dictEN.cardinality_code+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objdm_cardinality_type_dictEN.cardinality_code = objDT.Rows[0][condm_cardinality_type_dict.cardinality_code].ToString().Trim(); //基数编码(字段类型:varchar,字段长度:30,是否可空:False)
 objdm_cardinality_type_dictEN.cardinality_name = objDT.Rows[0][condm_cardinality_type_dict.cardinality_name].ToString().Trim(); //基数名称(字段类型:varchar,字段长度:20,是否可空:False)
 objdm_cardinality_type_dictEN.cardinality_desc = objDT.Rows[0][condm_cardinality_type_dict.cardinality_desc].ToString().Trim(); //基数说明(字段类型:varchar,字段长度:300,是否可空:True)
 objdm_cardinality_type_dictEN.is_active = TransNullToBool(objDT.Rows[0][condm_cardinality_type_dict.is_active].ToString().Trim()); //是否启用(字段类型:bit,字段长度:0,是否可空:False)
 objdm_cardinality_type_dictEN.arrow_mode = objDT.Rows[0][condm_cardinality_type_dict.arrow_mode].ToString().Trim(); //箭头模式(字段类型:varchar,字段长度:20,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsdm_cardinality_type_dictDA: Getdm_cardinality_type_dict)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strcardinality_code">表关键字</param>
 /// <returns>表对象</returns>
public clsdm_cardinality_type_dictEN GetObjBycardinality_code(string strcardinality_code)
{
CheckPrimaryKey(strcardinality_code);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_cardinality_type_dictDA.GetSpecSQLObj();
strSQL = "Select * from dm_cardinality_type_dict where cardinality_code = " + "'"+ strcardinality_code+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsdm_cardinality_type_dictEN objdm_cardinality_type_dictEN = new clsdm_cardinality_type_dictEN();
try
{
 objdm_cardinality_type_dictEN.cardinality_code = objRow[condm_cardinality_type_dict.cardinality_code].ToString().Trim(); //基数编码(字段类型:varchar,字段长度:30,是否可空:False)
 objdm_cardinality_type_dictEN.cardinality_name = objRow[condm_cardinality_type_dict.cardinality_name].ToString().Trim(); //基数名称(字段类型:varchar,字段长度:20,是否可空:False)
 objdm_cardinality_type_dictEN.cardinality_desc = objRow[condm_cardinality_type_dict.cardinality_desc] == DBNull.Value ? null : objRow[condm_cardinality_type_dict.cardinality_desc].ToString().Trim(); //基数说明(字段类型:varchar,字段长度:300,是否可空:True)
 objdm_cardinality_type_dictEN.is_active = clsEntityBase2.TransNullToBool_S(objRow[condm_cardinality_type_dict.is_active].ToString().Trim()); //是否启用(字段类型:bit,字段长度:0,是否可空:False)
 objdm_cardinality_type_dictEN.arrow_mode = objRow[condm_cardinality_type_dict.arrow_mode] == DBNull.Value ? null : objRow[condm_cardinality_type_dict.arrow_mode].ToString().Trim(); //箭头模式(字段类型:varchar,字段长度:20,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsdm_cardinality_type_dictDA: GetObjBycardinality_code)", objException.Message));
}
return objdm_cardinality_type_dictEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsdm_cardinality_type_dictEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsdm_cardinality_type_dictDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_cardinality_type_dictDA.GetSpecSQLObj();
strSQL = "Select * from dm_cardinality_type_dict where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsdm_cardinality_type_dictEN objdm_cardinality_type_dictEN = new clsdm_cardinality_type_dictEN()
{
cardinality_code = objRow[condm_cardinality_type_dict.cardinality_code].ToString().Trim(), //基数编码
cardinality_name = objRow[condm_cardinality_type_dict.cardinality_name].ToString().Trim(), //基数名称
cardinality_desc = objRow[condm_cardinality_type_dict.cardinality_desc] == DBNull.Value ? null : objRow[condm_cardinality_type_dict.cardinality_desc].ToString().Trim(), //基数说明
is_active = TransNullToBool(objRow[condm_cardinality_type_dict.is_active].ToString().Trim()), //是否启用
arrow_mode = objRow[condm_cardinality_type_dict.arrow_mode] == DBNull.Value ? null : objRow[condm_cardinality_type_dict.arrow_mode].ToString().Trim() //箭头模式
};
objdm_cardinality_type_dictEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objdm_cardinality_type_dictEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsdm_cardinality_type_dictDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsdm_cardinality_type_dictEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsdm_cardinality_type_dictEN objdm_cardinality_type_dictEN = new clsdm_cardinality_type_dictEN();
try
{
objdm_cardinality_type_dictEN.cardinality_code = objRow[condm_cardinality_type_dict.cardinality_code].ToString().Trim(); //基数编码
objdm_cardinality_type_dictEN.cardinality_name = objRow[condm_cardinality_type_dict.cardinality_name].ToString().Trim(); //基数名称
objdm_cardinality_type_dictEN.cardinality_desc = objRow[condm_cardinality_type_dict.cardinality_desc] == DBNull.Value ? null : objRow[condm_cardinality_type_dict.cardinality_desc].ToString().Trim(); //基数说明
objdm_cardinality_type_dictEN.is_active = TransNullToBool(objRow[condm_cardinality_type_dict.is_active].ToString().Trim()); //是否启用
objdm_cardinality_type_dictEN.arrow_mode = objRow[condm_cardinality_type_dict.arrow_mode] == DBNull.Value ? null : objRow[condm_cardinality_type_dict.arrow_mode].ToString().Trim(); //箭头模式
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsdm_cardinality_type_dictDA: GetObjByDataRowdm_cardinality_type_dict)", objException.Message));
}
objdm_cardinality_type_dictEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objdm_cardinality_type_dictEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsdm_cardinality_type_dictEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsdm_cardinality_type_dictEN objdm_cardinality_type_dictEN = new clsdm_cardinality_type_dictEN();
try
{
objdm_cardinality_type_dictEN.cardinality_code = objRow[condm_cardinality_type_dict.cardinality_code].ToString().Trim(); //基数编码
objdm_cardinality_type_dictEN.cardinality_name = objRow[condm_cardinality_type_dict.cardinality_name].ToString().Trim(); //基数名称
objdm_cardinality_type_dictEN.cardinality_desc = objRow[condm_cardinality_type_dict.cardinality_desc] == DBNull.Value ? null : objRow[condm_cardinality_type_dict.cardinality_desc].ToString().Trim(); //基数说明
objdm_cardinality_type_dictEN.is_active = TransNullToBool(objRow[condm_cardinality_type_dict.is_active].ToString().Trim()); //是否启用
objdm_cardinality_type_dictEN.arrow_mode = objRow[condm_cardinality_type_dict.arrow_mode] == DBNull.Value ? null : objRow[condm_cardinality_type_dict.arrow_mode].ToString().Trim(); //箭头模式
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsdm_cardinality_type_dictDA: GetObjByDataRow)", objException.Message));
}
objdm_cardinality_type_dictEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objdm_cardinality_type_dictEN;
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
objSQL = clsdm_cardinality_type_dictDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsdm_cardinality_type_dictEN._CurrTabName, condm_cardinality_type_dict.cardinality_code, 30, "");
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
objSQL = clsdm_cardinality_type_dictDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsdm_cardinality_type_dictEN._CurrTabName, condm_cardinality_type_dict.cardinality_code, 30, strPrefix);
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
 objSQL = clsdm_cardinality_type_dictDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select cardinality_code from dm_cardinality_type_dict where " + strCondition;
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
 objSQL = clsdm_cardinality_type_dictDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select cardinality_code from dm_cardinality_type_dict where " + strCondition;
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
 /// <param name = "strcardinality_code">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strcardinality_code)
{
CheckPrimaryKey(strcardinality_code);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_cardinality_type_dictDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("dm_cardinality_type_dict", "cardinality_code = " + "'"+ strcardinality_code+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsdm_cardinality_type_dictDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_cardinality_type_dictDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("dm_cardinality_type_dict", strCondition))
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
objSQL = clsdm_cardinality_type_dictDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("dm_cardinality_type_dict");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsdm_cardinality_type_dictEN objdm_cardinality_type_dictEN)
 {
 if (objdm_cardinality_type_dictEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objdm_cardinality_type_dictEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_cardinality_type_dictDA.GetSpecSQLObj();
strSQL = "Select * from dm_cardinality_type_dict where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "dm_cardinality_type_dict");
objRow = objDS.Tables["dm_cardinality_type_dict"].NewRow();
objRow[condm_cardinality_type_dict.cardinality_code] = objdm_cardinality_type_dictEN.cardinality_code; //基数编码
objRow[condm_cardinality_type_dict.cardinality_name] = objdm_cardinality_type_dictEN.cardinality_name; //基数名称
 if (objdm_cardinality_type_dictEN.cardinality_desc !=  "")
 {
objRow[condm_cardinality_type_dict.cardinality_desc] = objdm_cardinality_type_dictEN.cardinality_desc; //基数说明
 }
objRow[condm_cardinality_type_dict.is_active] = objdm_cardinality_type_dictEN.is_active; //是否启用
 if (objdm_cardinality_type_dictEN.arrow_mode !=  "")
 {
objRow[condm_cardinality_type_dict.arrow_mode] = objdm_cardinality_type_dictEN.arrow_mode; //箭头模式
 }
objDS.Tables[clsdm_cardinality_type_dictEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsdm_cardinality_type_dictEN._CurrTabName);
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
 /// <param name = "objdm_cardinality_type_dictEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsdm_cardinality_type_dictEN objdm_cardinality_type_dictEN)
{
 if (objdm_cardinality_type_dictEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objdm_cardinality_type_dictEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objdm_cardinality_type_dictEN.cardinality_code !=  null)
 {
 arrFieldListForInsert.Add(condm_cardinality_type_dict.cardinality_code);
 var strcardinality_code = objdm_cardinality_type_dictEN.cardinality_code.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strcardinality_code + "'");
 }
 
 if (objdm_cardinality_type_dictEN.cardinality_name !=  null)
 {
 arrFieldListForInsert.Add(condm_cardinality_type_dict.cardinality_name);
 var strcardinality_name = objdm_cardinality_type_dictEN.cardinality_name.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strcardinality_name + "'");
 }
 
 if (objdm_cardinality_type_dictEN.cardinality_desc !=  null)
 {
 arrFieldListForInsert.Add(condm_cardinality_type_dict.cardinality_desc);
 var strcardinality_desc = objdm_cardinality_type_dictEN.cardinality_desc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strcardinality_desc + "'");
 }
 
 arrFieldListForInsert.Add(condm_cardinality_type_dict.is_active);
 arrValueListForInsert.Add("'" + (objdm_cardinality_type_dictEN.is_active  ==  false ? "0" : "1") + "'");
 
 if (objdm_cardinality_type_dictEN.arrow_mode !=  null)
 {
 arrFieldListForInsert.Add(condm_cardinality_type_dict.arrow_mode);
 var strarrow_mode = objdm_cardinality_type_dictEN.arrow_mode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strarrow_mode + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into dm_cardinality_type_dict");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_cardinality_type_dictDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objdm_cardinality_type_dictEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsdm_cardinality_type_dictEN objdm_cardinality_type_dictEN)
{
 if (objdm_cardinality_type_dictEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objdm_cardinality_type_dictEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objdm_cardinality_type_dictEN.cardinality_code !=  null)
 {
 arrFieldListForInsert.Add(condm_cardinality_type_dict.cardinality_code);
 var strcardinality_code = objdm_cardinality_type_dictEN.cardinality_code.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strcardinality_code + "'");
 }
 
 if (objdm_cardinality_type_dictEN.cardinality_name !=  null)
 {
 arrFieldListForInsert.Add(condm_cardinality_type_dict.cardinality_name);
 var strcardinality_name = objdm_cardinality_type_dictEN.cardinality_name.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strcardinality_name + "'");
 }
 
 if (objdm_cardinality_type_dictEN.cardinality_desc !=  null)
 {
 arrFieldListForInsert.Add(condm_cardinality_type_dict.cardinality_desc);
 var strcardinality_desc = objdm_cardinality_type_dictEN.cardinality_desc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strcardinality_desc + "'");
 }
 
 arrFieldListForInsert.Add(condm_cardinality_type_dict.is_active);
 arrValueListForInsert.Add("'" + (objdm_cardinality_type_dictEN.is_active  ==  false ? "0" : "1") + "'");
 
 if (objdm_cardinality_type_dictEN.arrow_mode !=  null)
 {
 arrFieldListForInsert.Add(condm_cardinality_type_dict.arrow_mode);
 var strarrow_mode = objdm_cardinality_type_dictEN.arrow_mode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strarrow_mode + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into dm_cardinality_type_dict");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_cardinality_type_dictDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objdm_cardinality_type_dictEN.cardinality_code;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objdm_cardinality_type_dictEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsdm_cardinality_type_dictEN objdm_cardinality_type_dictEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objdm_cardinality_type_dictEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objdm_cardinality_type_dictEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objdm_cardinality_type_dictEN.cardinality_code !=  null)
 {
 arrFieldListForInsert.Add(condm_cardinality_type_dict.cardinality_code);
 var strcardinality_code = objdm_cardinality_type_dictEN.cardinality_code.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strcardinality_code + "'");
 }
 
 if (objdm_cardinality_type_dictEN.cardinality_name !=  null)
 {
 arrFieldListForInsert.Add(condm_cardinality_type_dict.cardinality_name);
 var strcardinality_name = objdm_cardinality_type_dictEN.cardinality_name.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strcardinality_name + "'");
 }
 
 if (objdm_cardinality_type_dictEN.cardinality_desc !=  null)
 {
 arrFieldListForInsert.Add(condm_cardinality_type_dict.cardinality_desc);
 var strcardinality_desc = objdm_cardinality_type_dictEN.cardinality_desc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strcardinality_desc + "'");
 }
 
 arrFieldListForInsert.Add(condm_cardinality_type_dict.is_active);
 arrValueListForInsert.Add("'" + (objdm_cardinality_type_dictEN.is_active  ==  false ? "0" : "1") + "'");
 
 if (objdm_cardinality_type_dictEN.arrow_mode !=  null)
 {
 arrFieldListForInsert.Add(condm_cardinality_type_dict.arrow_mode);
 var strarrow_mode = objdm_cardinality_type_dictEN.arrow_mode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strarrow_mode + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into dm_cardinality_type_dict");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_cardinality_type_dictDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objdm_cardinality_type_dictEN.cardinality_code;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objdm_cardinality_type_dictEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsdm_cardinality_type_dictEN objdm_cardinality_type_dictEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objdm_cardinality_type_dictEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objdm_cardinality_type_dictEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objdm_cardinality_type_dictEN.cardinality_code !=  null)
 {
 arrFieldListForInsert.Add(condm_cardinality_type_dict.cardinality_code);
 var strcardinality_code = objdm_cardinality_type_dictEN.cardinality_code.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strcardinality_code + "'");
 }
 
 if (objdm_cardinality_type_dictEN.cardinality_name !=  null)
 {
 arrFieldListForInsert.Add(condm_cardinality_type_dict.cardinality_name);
 var strcardinality_name = objdm_cardinality_type_dictEN.cardinality_name.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strcardinality_name + "'");
 }
 
 if (objdm_cardinality_type_dictEN.cardinality_desc !=  null)
 {
 arrFieldListForInsert.Add(condm_cardinality_type_dict.cardinality_desc);
 var strcardinality_desc = objdm_cardinality_type_dictEN.cardinality_desc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strcardinality_desc + "'");
 }
 
 arrFieldListForInsert.Add(condm_cardinality_type_dict.is_active);
 arrValueListForInsert.Add("'" + (objdm_cardinality_type_dictEN.is_active  ==  false ? "0" : "1") + "'");
 
 if (objdm_cardinality_type_dictEN.arrow_mode !=  null)
 {
 arrFieldListForInsert.Add(condm_cardinality_type_dict.arrow_mode);
 var strarrow_mode = objdm_cardinality_type_dictEN.arrow_mode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strarrow_mode + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into dm_cardinality_type_dict");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_cardinality_type_dictDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewdm_cardinality_type_dicts(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_cardinality_type_dictDA.GetSpecSQLObj();
strSQL = "Select * from dm_cardinality_type_dict where cardinality_code = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "dm_cardinality_type_dict");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strcardinality_code = oRow[condm_cardinality_type_dict.cardinality_code].ToString().Trim();
if (IsExist(strcardinality_code))
{
 string strResult = "关键字变量值为:" + string.Format("cardinality_code = {0}", strcardinality_code) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsdm_cardinality_type_dictEN._CurrTabName ].NewRow();
objRow[condm_cardinality_type_dict.cardinality_code] = oRow[condm_cardinality_type_dict.cardinality_code].ToString().Trim(); //基数编码
objRow[condm_cardinality_type_dict.cardinality_name] = oRow[condm_cardinality_type_dict.cardinality_name].ToString().Trim(); //基数名称
objRow[condm_cardinality_type_dict.cardinality_desc] = oRow[condm_cardinality_type_dict.cardinality_desc].ToString().Trim(); //基数说明
objRow[condm_cardinality_type_dict.is_active] = oRow[condm_cardinality_type_dict.is_active].ToString().Trim(); //是否启用
objRow[condm_cardinality_type_dict.arrow_mode] = oRow[condm_cardinality_type_dict.arrow_mode].ToString().Trim(); //箭头模式
 objDS.Tables[clsdm_cardinality_type_dictEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsdm_cardinality_type_dictEN._CurrTabName);
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
 /// <param name = "objdm_cardinality_type_dictEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsdm_cardinality_type_dictEN objdm_cardinality_type_dictEN)
{
 if (objdm_cardinality_type_dictEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objdm_cardinality_type_dictEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_cardinality_type_dictDA.GetSpecSQLObj();
strSQL = "Select * from dm_cardinality_type_dict where cardinality_code = " + "'"+ objdm_cardinality_type_dictEN.cardinality_code+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsdm_cardinality_type_dictEN._CurrTabName);
if (objDS.Tables[clsdm_cardinality_type_dictEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:cardinality_code = " + "'"+ objdm_cardinality_type_dictEN.cardinality_code+"'");
return false;
}
objRow = objDS.Tables[clsdm_cardinality_type_dictEN._CurrTabName].Rows[0];
 if (objdm_cardinality_type_dictEN.IsUpdated(condm_cardinality_type_dict.cardinality_code))
 {
objRow[condm_cardinality_type_dict.cardinality_code] = objdm_cardinality_type_dictEN.cardinality_code; //基数编码
 }
 if (objdm_cardinality_type_dictEN.IsUpdated(condm_cardinality_type_dict.cardinality_name))
 {
objRow[condm_cardinality_type_dict.cardinality_name] = objdm_cardinality_type_dictEN.cardinality_name; //基数名称
 }
 if (objdm_cardinality_type_dictEN.IsUpdated(condm_cardinality_type_dict.cardinality_desc))
 {
objRow[condm_cardinality_type_dict.cardinality_desc] = objdm_cardinality_type_dictEN.cardinality_desc; //基数说明
 }
 if (objdm_cardinality_type_dictEN.IsUpdated(condm_cardinality_type_dict.is_active))
 {
objRow[condm_cardinality_type_dict.is_active] = objdm_cardinality_type_dictEN.is_active; //是否启用
 }
 if (objdm_cardinality_type_dictEN.IsUpdated(condm_cardinality_type_dict.arrow_mode))
 {
objRow[condm_cardinality_type_dict.arrow_mode] = objdm_cardinality_type_dictEN.arrow_mode; //箭头模式
 }
try
{
objDA.Update(objDS, clsdm_cardinality_type_dictEN._CurrTabName);
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
 /// <param name = "objdm_cardinality_type_dictEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsdm_cardinality_type_dictEN objdm_cardinality_type_dictEN)
{
 if (objdm_cardinality_type_dictEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objdm_cardinality_type_dictEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_cardinality_type_dictDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update dm_cardinality_type_dict Set ");
 
 if (objdm_cardinality_type_dictEN.IsUpdated(condm_cardinality_type_dict.cardinality_name))
 {
 if (objdm_cardinality_type_dictEN.cardinality_name !=  null)
 {
 var strcardinality_name = objdm_cardinality_type_dictEN.cardinality_name.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strcardinality_name, condm_cardinality_type_dict.cardinality_name); //基数名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",condm_cardinality_type_dict.cardinality_name); //基数名称
 }
 }
 
 if (objdm_cardinality_type_dictEN.IsUpdated(condm_cardinality_type_dict.cardinality_desc))
 {
 if (objdm_cardinality_type_dictEN.cardinality_desc !=  null)
 {
 var strcardinality_desc = objdm_cardinality_type_dictEN.cardinality_desc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strcardinality_desc, condm_cardinality_type_dict.cardinality_desc); //基数说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",condm_cardinality_type_dict.cardinality_desc); //基数说明
 }
 }
 
 if (objdm_cardinality_type_dictEN.IsUpdated(condm_cardinality_type_dict.is_active))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objdm_cardinality_type_dictEN.is_active == true?"1":"0", condm_cardinality_type_dict.is_active); //是否启用
 }
 
 if (objdm_cardinality_type_dictEN.IsUpdated(condm_cardinality_type_dict.arrow_mode))
 {
 if (objdm_cardinality_type_dictEN.arrow_mode !=  null)
 {
 var strarrow_mode = objdm_cardinality_type_dictEN.arrow_mode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strarrow_mode, condm_cardinality_type_dict.arrow_mode); //箭头模式
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",condm_cardinality_type_dict.arrow_mode); //箭头模式
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where cardinality_code = '{0}'", objdm_cardinality_type_dictEN.cardinality_code); 
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
 /// <param name = "objdm_cardinality_type_dictEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsdm_cardinality_type_dictEN objdm_cardinality_type_dictEN, string strCondition)
{
 if (objdm_cardinality_type_dictEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objdm_cardinality_type_dictEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_cardinality_type_dictDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update dm_cardinality_type_dict Set ");
 
 if (objdm_cardinality_type_dictEN.IsUpdated(condm_cardinality_type_dict.cardinality_name))
 {
 if (objdm_cardinality_type_dictEN.cardinality_name !=  null)
 {
 var strcardinality_name = objdm_cardinality_type_dictEN.cardinality_name.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" cardinality_name = '{0}',", strcardinality_name); //基数名称
 }
 else
 {
 sbSQL.Append(" cardinality_name = null,"); //基数名称
 }
 }
 
 if (objdm_cardinality_type_dictEN.IsUpdated(condm_cardinality_type_dict.cardinality_desc))
 {
 if (objdm_cardinality_type_dictEN.cardinality_desc !=  null)
 {
 var strcardinality_desc = objdm_cardinality_type_dictEN.cardinality_desc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" cardinality_desc = '{0}',", strcardinality_desc); //基数说明
 }
 else
 {
 sbSQL.Append(" cardinality_desc = null,"); //基数说明
 }
 }
 
 if (objdm_cardinality_type_dictEN.IsUpdated(condm_cardinality_type_dict.is_active))
 {
 sbSQL.AppendFormat(" is_active = '{0}',", objdm_cardinality_type_dictEN.is_active == true?"1":"0"); //是否启用
 }
 
 if (objdm_cardinality_type_dictEN.IsUpdated(condm_cardinality_type_dict.arrow_mode))
 {
 if (objdm_cardinality_type_dictEN.arrow_mode !=  null)
 {
 var strarrow_mode = objdm_cardinality_type_dictEN.arrow_mode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" arrow_mode = '{0}',", strarrow_mode); //箭头模式
 }
 else
 {
 sbSQL.Append(" arrow_mode = null,"); //箭头模式
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
 /// <param name = "objdm_cardinality_type_dictEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsdm_cardinality_type_dictEN objdm_cardinality_type_dictEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objdm_cardinality_type_dictEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objdm_cardinality_type_dictEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_cardinality_type_dictDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update dm_cardinality_type_dict Set ");
 
 if (objdm_cardinality_type_dictEN.IsUpdated(condm_cardinality_type_dict.cardinality_name))
 {
 if (objdm_cardinality_type_dictEN.cardinality_name !=  null)
 {
 var strcardinality_name = objdm_cardinality_type_dictEN.cardinality_name.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" cardinality_name = '{0}',", strcardinality_name); //基数名称
 }
 else
 {
 sbSQL.Append(" cardinality_name = null,"); //基数名称
 }
 }
 
 if (objdm_cardinality_type_dictEN.IsUpdated(condm_cardinality_type_dict.cardinality_desc))
 {
 if (objdm_cardinality_type_dictEN.cardinality_desc !=  null)
 {
 var strcardinality_desc = objdm_cardinality_type_dictEN.cardinality_desc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" cardinality_desc = '{0}',", strcardinality_desc); //基数说明
 }
 else
 {
 sbSQL.Append(" cardinality_desc = null,"); //基数说明
 }
 }
 
 if (objdm_cardinality_type_dictEN.IsUpdated(condm_cardinality_type_dict.is_active))
 {
 sbSQL.AppendFormat(" is_active = '{0}',", objdm_cardinality_type_dictEN.is_active == true?"1":"0"); //是否启用
 }
 
 if (objdm_cardinality_type_dictEN.IsUpdated(condm_cardinality_type_dict.arrow_mode))
 {
 if (objdm_cardinality_type_dictEN.arrow_mode !=  null)
 {
 var strarrow_mode = objdm_cardinality_type_dictEN.arrow_mode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" arrow_mode = '{0}',", strarrow_mode); //箭头模式
 }
 else
 {
 sbSQL.Append(" arrow_mode = null,"); //箭头模式
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
 /// <param name = "objdm_cardinality_type_dictEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsdm_cardinality_type_dictEN objdm_cardinality_type_dictEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objdm_cardinality_type_dictEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objdm_cardinality_type_dictEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_cardinality_type_dictDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update dm_cardinality_type_dict Set ");
 
 if (objdm_cardinality_type_dictEN.IsUpdated(condm_cardinality_type_dict.cardinality_name))
 {
 if (objdm_cardinality_type_dictEN.cardinality_name !=  null)
 {
 var strcardinality_name = objdm_cardinality_type_dictEN.cardinality_name.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strcardinality_name, condm_cardinality_type_dict.cardinality_name); //基数名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",condm_cardinality_type_dict.cardinality_name); //基数名称
 }
 }
 
 if (objdm_cardinality_type_dictEN.IsUpdated(condm_cardinality_type_dict.cardinality_desc))
 {
 if (objdm_cardinality_type_dictEN.cardinality_desc !=  null)
 {
 var strcardinality_desc = objdm_cardinality_type_dictEN.cardinality_desc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strcardinality_desc, condm_cardinality_type_dict.cardinality_desc); //基数说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",condm_cardinality_type_dict.cardinality_desc); //基数说明
 }
 }
 
 if (objdm_cardinality_type_dictEN.IsUpdated(condm_cardinality_type_dict.is_active))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objdm_cardinality_type_dictEN.is_active == true?"1":"0", condm_cardinality_type_dict.is_active); //是否启用
 }
 
 if (objdm_cardinality_type_dictEN.IsUpdated(condm_cardinality_type_dict.arrow_mode))
 {
 if (objdm_cardinality_type_dictEN.arrow_mode !=  null)
 {
 var strarrow_mode = objdm_cardinality_type_dictEN.arrow_mode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strarrow_mode, condm_cardinality_type_dict.arrow_mode); //箭头模式
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",condm_cardinality_type_dict.arrow_mode); //箭头模式
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where cardinality_code = '{0}'", objdm_cardinality_type_dictEN.cardinality_code); 
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
 /// <param name = "strcardinality_code">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strcardinality_code) 
{
CheckPrimaryKey(strcardinality_code);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_cardinality_type_dictDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strcardinality_code,
};
 objSQL.ExecSP("dm_cardinality_type_dict_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strcardinality_code">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strcardinality_code, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strcardinality_code);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_cardinality_type_dictDA.GetSpecSQLObj();
//删除dm_cardinality_type_dict本表中与当前对象有关的记录
strSQL = strSQL + "Delete from dm_cardinality_type_dict where cardinality_code = " + "'"+ strcardinality_code+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Deldm_cardinality_type_dict(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_cardinality_type_dictDA.GetSpecSQLObj();
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
//删除dm_cardinality_type_dict本表中与当前对象有关的记录
strSQL = strSQL + "Delete from dm_cardinality_type_dict where cardinality_code in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strcardinality_code">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strcardinality_code) 
{
CheckPrimaryKey(strcardinality_code);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_cardinality_type_dictDA.GetSpecSQLObj();
//删除dm_cardinality_type_dict本表中与当前对象有关的记录
strSQL = strSQL + "Delete from dm_cardinality_type_dict where cardinality_code = " + "'"+ strcardinality_code+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Deldm_cardinality_type_dict(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsdm_cardinality_type_dictDA: Deldm_cardinality_type_dict)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_cardinality_type_dictDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from dm_cardinality_type_dict where " + strCondition ;
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
public bool Deldm_cardinality_type_dictWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsdm_cardinality_type_dictDA: Deldm_cardinality_type_dictWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_cardinality_type_dictDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from dm_cardinality_type_dict where " + strCondition ;
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
 /// <param name = "objdm_cardinality_type_dictENS">源对象</param>
 /// <param name = "objdm_cardinality_type_dictENT">目标对象</param>
public void CopyTo(clsdm_cardinality_type_dictEN objdm_cardinality_type_dictENS, clsdm_cardinality_type_dictEN objdm_cardinality_type_dictENT)
{
objdm_cardinality_type_dictENT.cardinality_code = objdm_cardinality_type_dictENS.cardinality_code; //基数编码
objdm_cardinality_type_dictENT.cardinality_name = objdm_cardinality_type_dictENS.cardinality_name; //基数名称
objdm_cardinality_type_dictENT.cardinality_desc = objdm_cardinality_type_dictENS.cardinality_desc; //基数说明
objdm_cardinality_type_dictENT.is_active = objdm_cardinality_type_dictENS.is_active; //是否启用
objdm_cardinality_type_dictENT.arrow_mode = objdm_cardinality_type_dictENS.arrow_mode; //箭头模式
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsdm_cardinality_type_dictEN objdm_cardinality_type_dictEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objdm_cardinality_type_dictEN.cardinality_name, condm_cardinality_type_dict.cardinality_name);
clsCheckSql.CheckFieldNotNull(objdm_cardinality_type_dictEN.is_active, condm_cardinality_type_dict.is_active);
//检查字段长度
clsCheckSql.CheckFieldLen(objdm_cardinality_type_dictEN.cardinality_code, 30, condm_cardinality_type_dict.cardinality_code);
clsCheckSql.CheckFieldLen(objdm_cardinality_type_dictEN.cardinality_name, 20, condm_cardinality_type_dict.cardinality_name);
clsCheckSql.CheckFieldLen(objdm_cardinality_type_dictEN.cardinality_desc, 300, condm_cardinality_type_dict.cardinality_desc);
clsCheckSql.CheckFieldLen(objdm_cardinality_type_dictEN.arrow_mode, 20, condm_cardinality_type_dict.arrow_mode);
//检查字段外键固定长度
 objdm_cardinality_type_dictEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsdm_cardinality_type_dictEN objdm_cardinality_type_dictEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objdm_cardinality_type_dictEN.cardinality_name, 20, condm_cardinality_type_dict.cardinality_name);
clsCheckSql.CheckFieldLen(objdm_cardinality_type_dictEN.cardinality_desc, 300, condm_cardinality_type_dict.cardinality_desc);
clsCheckSql.CheckFieldLen(objdm_cardinality_type_dictEN.arrow_mode, 20, condm_cardinality_type_dict.arrow_mode);
//检查外键字段长度
 objdm_cardinality_type_dictEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsdm_cardinality_type_dictEN objdm_cardinality_type_dictEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objdm_cardinality_type_dictEN.cardinality_code, 30, condm_cardinality_type_dict.cardinality_code);
clsCheckSql.CheckFieldLen(objdm_cardinality_type_dictEN.cardinality_name, 20, condm_cardinality_type_dict.cardinality_name);
clsCheckSql.CheckFieldLen(objdm_cardinality_type_dictEN.cardinality_desc, 300, condm_cardinality_type_dict.cardinality_desc);
clsCheckSql.CheckFieldLen(objdm_cardinality_type_dictEN.arrow_mode, 20, condm_cardinality_type_dict.arrow_mode);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objdm_cardinality_type_dictEN.cardinality_code, condm_cardinality_type_dict.cardinality_code);
clsCheckSql.CheckSqlInjection4Field(objdm_cardinality_type_dictEN.cardinality_name, condm_cardinality_type_dict.cardinality_name);
clsCheckSql.CheckSqlInjection4Field(objdm_cardinality_type_dictEN.cardinality_desc, condm_cardinality_type_dict.cardinality_desc);
clsCheckSql.CheckSqlInjection4Field(objdm_cardinality_type_dictEN.arrow_mode, condm_cardinality_type_dict.arrow_mode);
//检查外键字段长度
 objdm_cardinality_type_dictEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable Getcardinality_code()
{
//获取某学院所有专业信息
string strSQL = "select cardinality_code, cardinality_name from dm_cardinality_type_dict ";
 clsSpecSQLforSql mySql = clsdm_cardinality_type_dictDA.GetSpecSQLObj();
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
 objSQL = clsdm_cardinality_type_dictDA.GetSpecSQLObj();
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
 objSQL = clsdm_cardinality_type_dictDA.GetSpecSQLObj();
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
 objSQL = clsdm_cardinality_type_dictDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsdm_cardinality_type_dictEN._CurrTabName);
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
 objSQL = clsdm_cardinality_type_dictDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsdm_cardinality_type_dictEN._CurrTabName, strCondition);
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
 objSQL = clsdm_cardinality_type_dictDA.GetSpecSQLObj();
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
 objSQL = clsdm_cardinality_type_dictDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}