
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsdm_model_diagram_stage_mapDA
 表名:dm_model_diagram_stage_map(00050672)
 * 版本:2026.08.13(服务器:WIN-SRV103-116)
 日期:2026/08/15 13:11:30
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
 /// 图阶段布局映射(dm_model_diagram_stage_map)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsdm_model_diagram_stage_mapDA : clsCommBase4DA
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
 return clsdm_model_diagram_stage_mapEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsdm_model_diagram_stage_mapEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsdm_model_diagram_stage_mapEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsdm_model_diagram_stage_mapEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsdm_model_diagram_stage_mapEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsdm_model_diagram_stage_mapDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_diagram_stage_mapDA.GetSpecSQLObj();
strSQL = "Select * from dm_model_diagram_stage_map where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_dm_model_diagram_stage_map(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsdm_model_diagram_stage_mapDA: GetDataTable_dm_model_diagram_stage_map)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_diagram_stage_mapDA.GetSpecSQLObj();
strSQL = "Select * from dm_model_diagram_stage_map where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsdm_model_diagram_stage_mapDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_diagram_stage_mapDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsdm_model_diagram_stage_mapDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_diagram_stage_mapDA.GetSpecSQLObj();
strSQL = "Select * from dm_model_diagram_stage_map where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsdm_model_diagram_stage_mapDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_diagram_stage_mapDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsdm_model_diagram_stage_mapDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_diagram_stage_mapDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from dm_model_diagram_stage_map where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from dm_model_diagram_stage_map where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsdm_model_diagram_stage_mapDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_diagram_stage_mapDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from dm_model_diagram_stage_map where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsdm_model_diagram_stage_mapDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_diagram_stage_mapDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} dm_model_diagram_stage_map.* " + 
$"from dm_model_diagram_stage_map " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and dm_model_diagram_stage_map.diagram_stage_map_id not in " + 
$"(Select top {intTop_In} dm_model_diagram_stage_map.diagram_stage_map_id from dm_model_diagram_stage_map " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from dm_model_diagram_stage_map where {1} and diagram_stage_map_id not in (Select top {2} diagram_stage_map_id from dm_model_diagram_stage_map where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from dm_model_diagram_stage_map where {1} and diagram_stage_map_id not in (Select top {3} diagram_stage_map_id from dm_model_diagram_stage_map where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsdm_model_diagram_stage_mapDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_diagram_stage_mapDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} dm_model_diagram_stage_map.* " + 
$"from dm_model_diagram_stage_map " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and dm_model_diagram_stage_map.diagram_stage_map_id not in " + 
$"(Select top {intTop_In} dm_model_diagram_stage_map.diagram_stage_map_id from dm_model_diagram_stage_map " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from dm_model_diagram_stage_map where {1} and diagram_stage_map_id not in (Select top {2} diagram_stage_map_id from dm_model_diagram_stage_map where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from dm_model_diagram_stage_map where {1} and diagram_stage_map_id not in (Select top {3} diagram_stage_map_id from dm_model_diagram_stage_map where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsdm_model_diagram_stage_mapEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsdm_model_diagram_stage_mapDA:GetObjLst)", objException.Message));
}
List<clsdm_model_diagram_stage_mapEN> arrObjLst = new List<clsdm_model_diagram_stage_mapEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_diagram_stage_mapDA.GetSpecSQLObj();
strSQL = "Select * from dm_model_diagram_stage_map where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsdm_model_diagram_stage_mapEN objdm_model_diagram_stage_mapEN = new clsdm_model_diagram_stage_mapEN();
try
{
objdm_model_diagram_stage_mapEN.diagram_stage_map_id = TransNullToInt(objRow[condm_model_diagram_stage_map.diagram_stage_map_id].ToString().Trim()); //图阶段映射ID
objdm_model_diagram_stage_mapEN.PrjId = objRow[condm_model_diagram_stage_map.PrjId].ToString().Trim(); //工程Id
objdm_model_diagram_stage_mapEN.diagram_id = objRow[condm_model_diagram_stage_map.diagram_id].ToString().Trim(); //图ID
objdm_model_diagram_stage_mapEN.stage_id = objRow[condm_model_diagram_stage_map.stage_id].ToString().Trim(); //阶段ID
objdm_model_diagram_stage_mapEN.x_pos = TransNullToInt(objRow[condm_model_diagram_stage_map.x_pos].ToString().Trim()); //X坐标
objdm_model_diagram_stage_mapEN.y_pos = TransNullToInt(objRow[condm_model_diagram_stage_map.y_pos].ToString().Trim()); //Y坐标
objdm_model_diagram_stage_mapEN.Width = TransNullToInt(objRow[condm_model_diagram_stage_map.Width].ToString().Trim()); //宽
objdm_model_diagram_stage_mapEN.Height = TransNullToInt(objRow[condm_model_diagram_stage_map.Height].ToString().Trim()); //高度
objdm_model_diagram_stage_mapEN.sort_no = TransNullToInt(objRow[condm_model_diagram_stage_map.sort_no].ToString().Trim()); //排序号
objdm_model_diagram_stage_mapEN.is_visible = TransNullToBool(objRow[condm_model_diagram_stage_map.is_visible].ToString().Trim()); //是否可见
objdm_model_diagram_stage_mapEN.Status = objRow[condm_model_diagram_stage_map.Status].ToString().Trim(); //Status
objdm_model_diagram_stage_mapEN.created_by = objRow[condm_model_diagram_stage_map.created_by].ToString().Trim(); //创建人
objdm_model_diagram_stage_mapEN.created_time = TransNullToDate(objRow[condm_model_diagram_stage_map.created_time].ToString().Trim()); //创建时间
objdm_model_diagram_stage_mapEN.updated_by = objRow[condm_model_diagram_stage_map.updated_by].ToString().Trim(); //更新人
objdm_model_diagram_stage_mapEN.updated_time = TransNullToDate(objRow[condm_model_diagram_stage_map.updated_time].ToString().Trim()); //更新时间
objdm_model_diagram_stage_mapEN.remark = objRow[condm_model_diagram_stage_map.remark] == DBNull.Value ? null : objRow[condm_model_diagram_stage_map.remark].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsdm_model_diagram_stage_mapDA: GetObjLst)", objException.Message));
}
objdm_model_diagram_stage_mapEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objdm_model_diagram_stage_mapEN);
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
public List<clsdm_model_diagram_stage_mapEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsdm_model_diagram_stage_mapDA:GetObjLstByTabName)", objException.Message));
}
List<clsdm_model_diagram_stage_mapEN> arrObjLst = new List<clsdm_model_diagram_stage_mapEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_diagram_stage_mapDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsdm_model_diagram_stage_mapEN objdm_model_diagram_stage_mapEN = new clsdm_model_diagram_stage_mapEN();
try
{
objdm_model_diagram_stage_mapEN.diagram_stage_map_id = TransNullToInt(objRow[condm_model_diagram_stage_map.diagram_stage_map_id].ToString().Trim()); //图阶段映射ID
objdm_model_diagram_stage_mapEN.PrjId = objRow[condm_model_diagram_stage_map.PrjId].ToString().Trim(); //工程Id
objdm_model_diagram_stage_mapEN.diagram_id = objRow[condm_model_diagram_stage_map.diagram_id].ToString().Trim(); //图ID
objdm_model_diagram_stage_mapEN.stage_id = objRow[condm_model_diagram_stage_map.stage_id].ToString().Trim(); //阶段ID
objdm_model_diagram_stage_mapEN.x_pos = TransNullToInt(objRow[condm_model_diagram_stage_map.x_pos].ToString().Trim()); //X坐标
objdm_model_diagram_stage_mapEN.y_pos = TransNullToInt(objRow[condm_model_diagram_stage_map.y_pos].ToString().Trim()); //Y坐标
objdm_model_diagram_stage_mapEN.Width = TransNullToInt(objRow[condm_model_diagram_stage_map.Width].ToString().Trim()); //宽
objdm_model_diagram_stage_mapEN.Height = TransNullToInt(objRow[condm_model_diagram_stage_map.Height].ToString().Trim()); //高度
objdm_model_diagram_stage_mapEN.sort_no = TransNullToInt(objRow[condm_model_diagram_stage_map.sort_no].ToString().Trim()); //排序号
objdm_model_diagram_stage_mapEN.is_visible = TransNullToBool(objRow[condm_model_diagram_stage_map.is_visible].ToString().Trim()); //是否可见
objdm_model_diagram_stage_mapEN.Status = objRow[condm_model_diagram_stage_map.Status].ToString().Trim(); //Status
objdm_model_diagram_stage_mapEN.created_by = objRow[condm_model_diagram_stage_map.created_by].ToString().Trim(); //创建人
objdm_model_diagram_stage_mapEN.created_time = TransNullToDate(objRow[condm_model_diagram_stage_map.created_time].ToString().Trim()); //创建时间
objdm_model_diagram_stage_mapEN.updated_by = objRow[condm_model_diagram_stage_map.updated_by].ToString().Trim(); //更新人
objdm_model_diagram_stage_mapEN.updated_time = TransNullToDate(objRow[condm_model_diagram_stage_map.updated_time].ToString().Trim()); //更新时间
objdm_model_diagram_stage_mapEN.remark = objRow[condm_model_diagram_stage_map.remark] == DBNull.Value ? null : objRow[condm_model_diagram_stage_map.remark].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsdm_model_diagram_stage_mapDA: GetObjLst)", objException.Message));
}
objdm_model_diagram_stage_mapEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objdm_model_diagram_stage_mapEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objdm_model_diagram_stage_mapEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getdm_model_diagram_stage_map(ref clsdm_model_diagram_stage_mapEN objdm_model_diagram_stage_mapEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_diagram_stage_mapDA.GetSpecSQLObj();
strSQL = "Select * from dm_model_diagram_stage_map where diagram_stage_map_id = " + ""+ objdm_model_diagram_stage_mapEN.diagram_stage_map_id+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objdm_model_diagram_stage_mapEN.diagram_stage_map_id = TransNullToInt(objDT.Rows[0][condm_model_diagram_stage_map.diagram_stage_map_id].ToString().Trim()); //图阶段映射ID(字段类型:bigint,字段长度:8,是否可空:False)
 objdm_model_diagram_stage_mapEN.PrjId = objDT.Rows[0][condm_model_diagram_stage_map.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objdm_model_diagram_stage_mapEN.diagram_id = objDT.Rows[0][condm_model_diagram_stage_map.diagram_id].ToString().Trim(); //图ID(字段类型:char,字段长度:8,是否可空:False)
 objdm_model_diagram_stage_mapEN.stage_id = objDT.Rows[0][condm_model_diagram_stage_map.stage_id].ToString().Trim(); //阶段ID(字段类型:char,字段长度:8,是否可空:False)
 objdm_model_diagram_stage_mapEN.x_pos = TransNullToInt(objDT.Rows[0][condm_model_diagram_stage_map.x_pos].ToString().Trim()); //X坐标(字段类型:int,字段长度:0,是否可空:True)
 objdm_model_diagram_stage_mapEN.y_pos = TransNullToInt(objDT.Rows[0][condm_model_diagram_stage_map.y_pos].ToString().Trim()); //Y坐标(字段类型:int,字段长度:0,是否可空:True)
 objdm_model_diagram_stage_mapEN.Width = TransNullToInt(objDT.Rows[0][condm_model_diagram_stage_map.Width].ToString().Trim()); //宽(字段类型:int,字段长度:4,是否可空:True)
 objdm_model_diagram_stage_mapEN.Height = TransNullToInt(objDT.Rows[0][condm_model_diagram_stage_map.Height].ToString().Trim()); //高度(字段类型:int,字段长度:4,是否可空:True)
 objdm_model_diagram_stage_mapEN.sort_no = TransNullToInt(objDT.Rows[0][condm_model_diagram_stage_map.sort_no].ToString().Trim()); //排序号(字段类型:int,字段长度:0,是否可空:True)
 objdm_model_diagram_stage_mapEN.is_visible = TransNullToBool(objDT.Rows[0][condm_model_diagram_stage_map.is_visible].ToString().Trim()); //是否可见(字段类型:bit,字段长度:0,是否可空:False)
 objdm_model_diagram_stage_mapEN.Status = objDT.Rows[0][condm_model_diagram_stage_map.Status].ToString().Trim(); //Status(字段类型:varchar,字段长度:20,是否可空:False)
 objdm_model_diagram_stage_mapEN.created_by = objDT.Rows[0][condm_model_diagram_stage_map.created_by].ToString().Trim(); //创建人(字段类型:varchar,字段长度:50,是否可空:True)
 objdm_model_diagram_stage_mapEN.created_time = TransNullToDate(objDT.Rows[0][condm_model_diagram_stage_map.created_time].ToString().Trim()); //创建时间(字段类型:datetime,字段长度:0,是否可空:True)
 objdm_model_diagram_stage_mapEN.updated_by = objDT.Rows[0][condm_model_diagram_stage_map.updated_by].ToString().Trim(); //更新人(字段类型:varchar,字段长度:50,是否可空:True)
 objdm_model_diagram_stage_mapEN.updated_time = TransNullToDate(objDT.Rows[0][condm_model_diagram_stage_map.updated_time].ToString().Trim()); //更新时间(字段类型:datetime,字段长度:0,是否可空:True)
 objdm_model_diagram_stage_mapEN.remark = objDT.Rows[0][condm_model_diagram_stage_map.remark].ToString().Trim(); //备注(字段类型:varchar,字段长度:500,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsdm_model_diagram_stage_mapDA: Getdm_model_diagram_stage_map)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngdiagram_stage_map_id">表关键字</param>
 /// <returns>表对象</returns>
public clsdm_model_diagram_stage_mapEN GetObjBydiagram_stage_map_id(long lngdiagram_stage_map_id)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_diagram_stage_mapDA.GetSpecSQLObj();
strSQL = "Select * from dm_model_diagram_stage_map where diagram_stage_map_id = " + ""+ lngdiagram_stage_map_id+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsdm_model_diagram_stage_mapEN objdm_model_diagram_stage_mapEN = new clsdm_model_diagram_stage_mapEN();
try
{
 objdm_model_diagram_stage_mapEN.diagram_stage_map_id = Int32.Parse(objRow[condm_model_diagram_stage_map.diagram_stage_map_id].ToString().Trim()); //图阶段映射ID(字段类型:bigint,字段长度:8,是否可空:False)
 objdm_model_diagram_stage_mapEN.PrjId = objRow[condm_model_diagram_stage_map.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objdm_model_diagram_stage_mapEN.diagram_id = objRow[condm_model_diagram_stage_map.diagram_id].ToString().Trim(); //图ID(字段类型:char,字段长度:8,是否可空:False)
 objdm_model_diagram_stage_mapEN.stage_id = objRow[condm_model_diagram_stage_map.stage_id].ToString().Trim(); //阶段ID(字段类型:char,字段长度:8,是否可空:False)
 objdm_model_diagram_stage_mapEN.x_pos = Int32.Parse(objRow[condm_model_diagram_stage_map.x_pos].ToString().Trim()); //X坐标(字段类型:int,字段长度:0,是否可空:True)
 objdm_model_diagram_stage_mapEN.y_pos = Int32.Parse(objRow[condm_model_diagram_stage_map.y_pos].ToString().Trim()); //Y坐标(字段类型:int,字段长度:0,是否可空:True)
 objdm_model_diagram_stage_mapEN.Width = Int32.Parse(objRow[condm_model_diagram_stage_map.Width].ToString().Trim()); //宽(字段类型:int,字段长度:4,是否可空:True)
 objdm_model_diagram_stage_mapEN.Height = Int32.Parse(objRow[condm_model_diagram_stage_map.Height].ToString().Trim()); //高度(字段类型:int,字段长度:4,是否可空:True)
 objdm_model_diagram_stage_mapEN.sort_no = Int32.Parse(objRow[condm_model_diagram_stage_map.sort_no].ToString().Trim()); //排序号(字段类型:int,字段长度:0,是否可空:True)
 objdm_model_diagram_stage_mapEN.is_visible = clsEntityBase2.TransNullToBool_S(objRow[condm_model_diagram_stage_map.is_visible].ToString().Trim()); //是否可见(字段类型:bit,字段长度:0,是否可空:False)
 objdm_model_diagram_stage_mapEN.Status = objRow[condm_model_diagram_stage_map.Status].ToString().Trim(); //Status(字段类型:varchar,字段长度:20,是否可空:False)
 objdm_model_diagram_stage_mapEN.created_by = objRow[condm_model_diagram_stage_map.created_by].ToString().Trim(); //创建人(字段类型:varchar,字段长度:50,是否可空:True)
 objdm_model_diagram_stage_mapEN.created_time = System.DateTime.Parse(objRow[condm_model_diagram_stage_map.created_time].ToString().Trim()); //创建时间(字段类型:datetime,字段长度:0,是否可空:True)
 objdm_model_diagram_stage_mapEN.updated_by = objRow[condm_model_diagram_stage_map.updated_by].ToString().Trim(); //更新人(字段类型:varchar,字段长度:50,是否可空:True)
 objdm_model_diagram_stage_mapEN.updated_time = System.DateTime.Parse(objRow[condm_model_diagram_stage_map.updated_time].ToString().Trim()); //更新时间(字段类型:datetime,字段长度:0,是否可空:True)
 objdm_model_diagram_stage_mapEN.remark = objRow[condm_model_diagram_stage_map.remark] == DBNull.Value ? null : objRow[condm_model_diagram_stage_map.remark].ToString().Trim(); //备注(字段类型:varchar,字段长度:500,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsdm_model_diagram_stage_mapDA: GetObjBydiagram_stage_map_id)", objException.Message));
}
return objdm_model_diagram_stage_mapEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsdm_model_diagram_stage_mapEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsdm_model_diagram_stage_mapDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_diagram_stage_mapDA.GetSpecSQLObj();
strSQL = "Select * from dm_model_diagram_stage_map where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsdm_model_diagram_stage_mapEN objdm_model_diagram_stage_mapEN = new clsdm_model_diagram_stage_mapEN()
{
diagram_stage_map_id = TransNullToInt(objRow[condm_model_diagram_stage_map.diagram_stage_map_id].ToString().Trim()), //图阶段映射ID
PrjId = objRow[condm_model_diagram_stage_map.PrjId].ToString().Trim(), //工程Id
diagram_id = objRow[condm_model_diagram_stage_map.diagram_id].ToString().Trim(), //图ID
stage_id = objRow[condm_model_diagram_stage_map.stage_id].ToString().Trim(), //阶段ID
x_pos = TransNullToInt(objRow[condm_model_diagram_stage_map.x_pos].ToString().Trim()), //X坐标
y_pos = TransNullToInt(objRow[condm_model_diagram_stage_map.y_pos].ToString().Trim()), //Y坐标
Width = TransNullToInt(objRow[condm_model_diagram_stage_map.Width].ToString().Trim()), //宽
Height = TransNullToInt(objRow[condm_model_diagram_stage_map.Height].ToString().Trim()), //高度
sort_no = TransNullToInt(objRow[condm_model_diagram_stage_map.sort_no].ToString().Trim()), //排序号
is_visible = TransNullToBool(objRow[condm_model_diagram_stage_map.is_visible].ToString().Trim()), //是否可见
Status = objRow[condm_model_diagram_stage_map.Status].ToString().Trim(), //Status
created_by = objRow[condm_model_diagram_stage_map.created_by].ToString().Trim(), //创建人
created_time = TransNullToDate(objRow[condm_model_diagram_stage_map.created_time].ToString().Trim()), //创建时间
updated_by = objRow[condm_model_diagram_stage_map.updated_by].ToString().Trim(), //更新人
updated_time = TransNullToDate(objRow[condm_model_diagram_stage_map.updated_time].ToString().Trim()), //更新时间
remark = objRow[condm_model_diagram_stage_map.remark] == DBNull.Value ? null : objRow[condm_model_diagram_stage_map.remark].ToString().Trim() //备注
};
objdm_model_diagram_stage_mapEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objdm_model_diagram_stage_mapEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsdm_model_diagram_stage_mapDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsdm_model_diagram_stage_mapEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsdm_model_diagram_stage_mapEN objdm_model_diagram_stage_mapEN = new clsdm_model_diagram_stage_mapEN();
try
{
objdm_model_diagram_stage_mapEN.diagram_stage_map_id = TransNullToInt(objRow[condm_model_diagram_stage_map.diagram_stage_map_id].ToString().Trim()); //图阶段映射ID
objdm_model_diagram_stage_mapEN.PrjId = objRow[condm_model_diagram_stage_map.PrjId].ToString().Trim(); //工程Id
objdm_model_diagram_stage_mapEN.diagram_id = objRow[condm_model_diagram_stage_map.diagram_id].ToString().Trim(); //图ID
objdm_model_diagram_stage_mapEN.stage_id = objRow[condm_model_diagram_stage_map.stage_id].ToString().Trim(); //阶段ID
objdm_model_diagram_stage_mapEN.x_pos = TransNullToInt(objRow[condm_model_diagram_stage_map.x_pos].ToString().Trim()); //X坐标
objdm_model_diagram_stage_mapEN.y_pos = TransNullToInt(objRow[condm_model_diagram_stage_map.y_pos].ToString().Trim()); //Y坐标
objdm_model_diagram_stage_mapEN.Width = TransNullToInt(objRow[condm_model_diagram_stage_map.Width].ToString().Trim()); //宽
objdm_model_diagram_stage_mapEN.Height = TransNullToInt(objRow[condm_model_diagram_stage_map.Height].ToString().Trim()); //高度
objdm_model_diagram_stage_mapEN.sort_no = TransNullToInt(objRow[condm_model_diagram_stage_map.sort_no].ToString().Trim()); //排序号
objdm_model_diagram_stage_mapEN.is_visible = TransNullToBool(objRow[condm_model_diagram_stage_map.is_visible].ToString().Trim()); //是否可见
objdm_model_diagram_stage_mapEN.Status = objRow[condm_model_diagram_stage_map.Status].ToString().Trim(); //Status
objdm_model_diagram_stage_mapEN.created_by = objRow[condm_model_diagram_stage_map.created_by].ToString().Trim(); //创建人
objdm_model_diagram_stage_mapEN.created_time = TransNullToDate(objRow[condm_model_diagram_stage_map.created_time].ToString().Trim()); //创建时间
objdm_model_diagram_stage_mapEN.updated_by = objRow[condm_model_diagram_stage_map.updated_by].ToString().Trim(); //更新人
objdm_model_diagram_stage_mapEN.updated_time = TransNullToDate(objRow[condm_model_diagram_stage_map.updated_time].ToString().Trim()); //更新时间
objdm_model_diagram_stage_mapEN.remark = objRow[condm_model_diagram_stage_map.remark] == DBNull.Value ? null : objRow[condm_model_diagram_stage_map.remark].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsdm_model_diagram_stage_mapDA: GetObjByDataRowdm_model_diagram_stage_map)", objException.Message));
}
objdm_model_diagram_stage_mapEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objdm_model_diagram_stage_mapEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsdm_model_diagram_stage_mapEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsdm_model_diagram_stage_mapEN objdm_model_diagram_stage_mapEN = new clsdm_model_diagram_stage_mapEN();
try
{
objdm_model_diagram_stage_mapEN.diagram_stage_map_id = TransNullToInt(objRow[condm_model_diagram_stage_map.diagram_stage_map_id].ToString().Trim()); //图阶段映射ID
objdm_model_diagram_stage_mapEN.PrjId = objRow[condm_model_diagram_stage_map.PrjId].ToString().Trim(); //工程Id
objdm_model_diagram_stage_mapEN.diagram_id = objRow[condm_model_diagram_stage_map.diagram_id].ToString().Trim(); //图ID
objdm_model_diagram_stage_mapEN.stage_id = objRow[condm_model_diagram_stage_map.stage_id].ToString().Trim(); //阶段ID
objdm_model_diagram_stage_mapEN.x_pos = TransNullToInt(objRow[condm_model_diagram_stage_map.x_pos].ToString().Trim()); //X坐标
objdm_model_diagram_stage_mapEN.y_pos = TransNullToInt(objRow[condm_model_diagram_stage_map.y_pos].ToString().Trim()); //Y坐标
objdm_model_diagram_stage_mapEN.Width = TransNullToInt(objRow[condm_model_diagram_stage_map.Width].ToString().Trim()); //宽
objdm_model_diagram_stage_mapEN.Height = TransNullToInt(objRow[condm_model_diagram_stage_map.Height].ToString().Trim()); //高度
objdm_model_diagram_stage_mapEN.sort_no = TransNullToInt(objRow[condm_model_diagram_stage_map.sort_no].ToString().Trim()); //排序号
objdm_model_diagram_stage_mapEN.is_visible = TransNullToBool(objRow[condm_model_diagram_stage_map.is_visible].ToString().Trim()); //是否可见
objdm_model_diagram_stage_mapEN.Status = objRow[condm_model_diagram_stage_map.Status].ToString().Trim(); //Status
objdm_model_diagram_stage_mapEN.created_by = objRow[condm_model_diagram_stage_map.created_by].ToString().Trim(); //创建人
objdm_model_diagram_stage_mapEN.created_time = TransNullToDate(objRow[condm_model_diagram_stage_map.created_time].ToString().Trim()); //创建时间
objdm_model_diagram_stage_mapEN.updated_by = objRow[condm_model_diagram_stage_map.updated_by].ToString().Trim(); //更新人
objdm_model_diagram_stage_mapEN.updated_time = TransNullToDate(objRow[condm_model_diagram_stage_map.updated_time].ToString().Trim()); //更新时间
objdm_model_diagram_stage_mapEN.remark = objRow[condm_model_diagram_stage_map.remark] == DBNull.Value ? null : objRow[condm_model_diagram_stage_map.remark].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsdm_model_diagram_stage_mapDA: GetObjByDataRow)", objException.Message));
}
objdm_model_diagram_stage_mapEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objdm_model_diagram_stage_mapEN;
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
objSQL = clsdm_model_diagram_stage_mapDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsdm_model_diagram_stage_mapEN._CurrTabName, condm_model_diagram_stage_map.diagram_stage_map_id, 8, "");
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
objSQL = clsdm_model_diagram_stage_mapDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsdm_model_diagram_stage_mapEN._CurrTabName, condm_model_diagram_stage_map.diagram_stage_map_id, 8, strPrefix);
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
 objSQL = clsdm_model_diagram_stage_mapDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select diagram_stage_map_id from dm_model_diagram_stage_map where " + strCondition;
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
 objSQL = clsdm_model_diagram_stage_mapDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select diagram_stage_map_id from dm_model_diagram_stage_map where " + strCondition;
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
 /// <param name = "lngdiagram_stage_map_id">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngdiagram_stage_map_id)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_diagram_stage_mapDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("dm_model_diagram_stage_map", "diagram_stage_map_id = " + ""+ lngdiagram_stage_map_id+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsdm_model_diagram_stage_mapDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_diagram_stage_mapDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("dm_model_diagram_stage_map", strCondition))
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
objSQL = clsdm_model_diagram_stage_mapDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("dm_model_diagram_stage_map");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsdm_model_diagram_stage_mapEN objdm_model_diagram_stage_mapEN)
 {
 if (objdm_model_diagram_stage_mapEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objdm_model_diagram_stage_mapEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_diagram_stage_mapDA.GetSpecSQLObj();
strSQL = "Select * from dm_model_diagram_stage_map where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "dm_model_diagram_stage_map");
objRow = objDS.Tables["dm_model_diagram_stage_map"].NewRow();
objRow[condm_model_diagram_stage_map.PrjId] = objdm_model_diagram_stage_mapEN.PrjId; //工程Id
objRow[condm_model_diagram_stage_map.diagram_id] = objdm_model_diagram_stage_mapEN.diagram_id; //图ID
objRow[condm_model_diagram_stage_map.stage_id] = objdm_model_diagram_stage_mapEN.stage_id; //阶段ID
objRow[condm_model_diagram_stage_map.x_pos] = objdm_model_diagram_stage_mapEN.x_pos; //X坐标
objRow[condm_model_diagram_stage_map.y_pos] = objdm_model_diagram_stage_mapEN.y_pos; //Y坐标
objRow[condm_model_diagram_stage_map.Width] = objdm_model_diagram_stage_mapEN.Width; //宽
objRow[condm_model_diagram_stage_map.Height] = objdm_model_diagram_stage_mapEN.Height; //高度
objRow[condm_model_diagram_stage_map.sort_no] = objdm_model_diagram_stage_mapEN.sort_no; //排序号
objRow[condm_model_diagram_stage_map.is_visible] = objdm_model_diagram_stage_mapEN.is_visible; //是否可见
objRow[condm_model_diagram_stage_map.Status] = objdm_model_diagram_stage_mapEN.Status; //Status
objRow[condm_model_diagram_stage_map.created_by] = objdm_model_diagram_stage_mapEN.created_by; //创建人
objRow[condm_model_diagram_stage_map.created_time] = objdm_model_diagram_stage_mapEN.created_time; //创建时间
objRow[condm_model_diagram_stage_map.updated_by] = objdm_model_diagram_stage_mapEN.updated_by; //更新人
objRow[condm_model_diagram_stage_map.updated_time] = objdm_model_diagram_stage_mapEN.updated_time; //更新时间
 if (objdm_model_diagram_stage_mapEN.remark !=  "")
 {
objRow[condm_model_diagram_stage_map.remark] = objdm_model_diagram_stage_mapEN.remark; //备注
 }
objDS.Tables[clsdm_model_diagram_stage_mapEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsdm_model_diagram_stage_mapEN._CurrTabName);
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
 /// <param name = "objdm_model_diagram_stage_mapEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsdm_model_diagram_stage_mapEN objdm_model_diagram_stage_mapEN)
{
 if (objdm_model_diagram_stage_mapEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objdm_model_diagram_stage_mapEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objdm_model_diagram_stage_mapEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.PrjId);
 var strPrjId = objdm_model_diagram_stage_mapEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objdm_model_diagram_stage_mapEN.diagram_id !=  null)
 {
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.diagram_id);
 var strdiagram_id = objdm_model_diagram_stage_mapEN.diagram_id.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strdiagram_id + "'");
 }
 
 if (objdm_model_diagram_stage_mapEN.stage_id !=  null)
 {
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.stage_id);
 var strstage_id = objdm_model_diagram_stage_mapEN.stage_id.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strstage_id + "'");
 }
 
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.x_pos);
 arrValueListForInsert.Add(objdm_model_diagram_stage_mapEN.x_pos.ToString());
 
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.y_pos);
 arrValueListForInsert.Add(objdm_model_diagram_stage_mapEN.y_pos.ToString());
 
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.Width);
 arrValueListForInsert.Add(objdm_model_diagram_stage_mapEN.Width.ToString());
 
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.Height);
 arrValueListForInsert.Add(objdm_model_diagram_stage_mapEN.Height.ToString());
 
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.sort_no);
 arrValueListForInsert.Add(objdm_model_diagram_stage_mapEN.sort_no.ToString());
 
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.is_visible);
 arrValueListForInsert.Add("'" + (objdm_model_diagram_stage_mapEN.is_visible  ==  false ? "0" : "1") + "'");
 
 if (objdm_model_diagram_stage_mapEN.Status !=  null)
 {
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.Status);
 var strStatus = objdm_model_diagram_stage_mapEN.Status.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStatus + "'");
 }
 
 if (objdm_model_diagram_stage_mapEN.created_by !=  null)
 {
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.created_by);
 var strcreated_by = objdm_model_diagram_stage_mapEN.created_by.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strcreated_by + "'");
 }
 
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.created_time);
 var dtecreated_time = objdm_model_diagram_stage_mapEN.created_time;
 arrValueListForInsert.Add("'" + dtecreated_time + "'");
 
 if (objdm_model_diagram_stage_mapEN.updated_by !=  null)
 {
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.updated_by);
 var strupdated_by = objdm_model_diagram_stage_mapEN.updated_by.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strupdated_by + "'");
 }
 
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.updated_time);
 var dteupdated_time = objdm_model_diagram_stage_mapEN.updated_time;
 arrValueListForInsert.Add("'" + dteupdated_time + "'");
 
 if (objdm_model_diagram_stage_mapEN.remark !=  null)
 {
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.remark);
 var strremark = objdm_model_diagram_stage_mapEN.remark.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strremark + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into dm_model_diagram_stage_map");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_diagram_stage_mapDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objdm_model_diagram_stage_mapEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsdm_model_diagram_stage_mapEN objdm_model_diagram_stage_mapEN)
{
 if (objdm_model_diagram_stage_mapEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objdm_model_diagram_stage_mapEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objdm_model_diagram_stage_mapEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.PrjId);
 var strPrjId = objdm_model_diagram_stage_mapEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objdm_model_diagram_stage_mapEN.diagram_id !=  null)
 {
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.diagram_id);
 var strdiagram_id = objdm_model_diagram_stage_mapEN.diagram_id.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strdiagram_id + "'");
 }
 
 if (objdm_model_diagram_stage_mapEN.stage_id !=  null)
 {
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.stage_id);
 var strstage_id = objdm_model_diagram_stage_mapEN.stage_id.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strstage_id + "'");
 }
 
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.x_pos);
 arrValueListForInsert.Add(objdm_model_diagram_stage_mapEN.x_pos.ToString());
 
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.y_pos);
 arrValueListForInsert.Add(objdm_model_diagram_stage_mapEN.y_pos.ToString());
 
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.Width);
 arrValueListForInsert.Add(objdm_model_diagram_stage_mapEN.Width.ToString());
 
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.Height);
 arrValueListForInsert.Add(objdm_model_diagram_stage_mapEN.Height.ToString());
 
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.sort_no);
 arrValueListForInsert.Add(objdm_model_diagram_stage_mapEN.sort_no.ToString());
 
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.is_visible);
 arrValueListForInsert.Add("'" + (objdm_model_diagram_stage_mapEN.is_visible  ==  false ? "0" : "1") + "'");
 
 if (objdm_model_diagram_stage_mapEN.Status !=  null)
 {
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.Status);
 var strStatus = objdm_model_diagram_stage_mapEN.Status.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStatus + "'");
 }
 
 if (objdm_model_diagram_stage_mapEN.created_by !=  null)
 {
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.created_by);
 var strcreated_by = objdm_model_diagram_stage_mapEN.created_by.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strcreated_by + "'");
 }
 
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.created_time);
 var dtecreated_time = objdm_model_diagram_stage_mapEN.created_time;
 arrValueListForInsert.Add("'" + dtecreated_time + "'");
 
 if (objdm_model_diagram_stage_mapEN.updated_by !=  null)
 {
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.updated_by);
 var strupdated_by = objdm_model_diagram_stage_mapEN.updated_by.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strupdated_by + "'");
 }
 
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.updated_time);
 var dteupdated_time = objdm_model_diagram_stage_mapEN.updated_time;
 arrValueListForInsert.Add("'" + dteupdated_time + "'");
 
 if (objdm_model_diagram_stage_mapEN.remark !=  null)
 {
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.remark);
 var strremark = objdm_model_diagram_stage_mapEN.remark.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strremark + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into dm_model_diagram_stage_map");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_diagram_stage_mapDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objdm_model_diagram_stage_mapEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsdm_model_diagram_stage_mapEN objdm_model_diagram_stage_mapEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objdm_model_diagram_stage_mapEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objdm_model_diagram_stage_mapEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objdm_model_diagram_stage_mapEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.PrjId);
 var strPrjId = objdm_model_diagram_stage_mapEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objdm_model_diagram_stage_mapEN.diagram_id !=  null)
 {
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.diagram_id);
 var strdiagram_id = objdm_model_diagram_stage_mapEN.diagram_id.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strdiagram_id + "'");
 }
 
 if (objdm_model_diagram_stage_mapEN.stage_id !=  null)
 {
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.stage_id);
 var strstage_id = objdm_model_diagram_stage_mapEN.stage_id.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strstage_id + "'");
 }
 
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.x_pos);
 arrValueListForInsert.Add(objdm_model_diagram_stage_mapEN.x_pos.ToString());
 
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.y_pos);
 arrValueListForInsert.Add(objdm_model_diagram_stage_mapEN.y_pos.ToString());
 
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.Width);
 arrValueListForInsert.Add(objdm_model_diagram_stage_mapEN.Width.ToString());
 
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.Height);
 arrValueListForInsert.Add(objdm_model_diagram_stage_mapEN.Height.ToString());
 
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.sort_no);
 arrValueListForInsert.Add(objdm_model_diagram_stage_mapEN.sort_no.ToString());
 
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.is_visible);
 arrValueListForInsert.Add("'" + (objdm_model_diagram_stage_mapEN.is_visible  ==  false ? "0" : "1") + "'");
 
 if (objdm_model_diagram_stage_mapEN.Status !=  null)
 {
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.Status);
 var strStatus = objdm_model_diagram_stage_mapEN.Status.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStatus + "'");
 }
 
 if (objdm_model_diagram_stage_mapEN.created_by !=  null)
 {
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.created_by);
 var strcreated_by = objdm_model_diagram_stage_mapEN.created_by.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strcreated_by + "'");
 }
 
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.created_time);
 var dtecreated_time = objdm_model_diagram_stage_mapEN.created_time;
 arrValueListForInsert.Add("'" + dtecreated_time + "'");
 
 if (objdm_model_diagram_stage_mapEN.updated_by !=  null)
 {
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.updated_by);
 var strupdated_by = objdm_model_diagram_stage_mapEN.updated_by.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strupdated_by + "'");
 }
 
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.updated_time);
 var dteupdated_time = objdm_model_diagram_stage_mapEN.updated_time;
 arrValueListForInsert.Add("'" + dteupdated_time + "'");
 
 if (objdm_model_diagram_stage_mapEN.remark !=  null)
 {
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.remark);
 var strremark = objdm_model_diagram_stage_mapEN.remark.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strremark + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into dm_model_diagram_stage_map");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_diagram_stage_mapDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objdm_model_diagram_stage_mapEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsdm_model_diagram_stage_mapEN objdm_model_diagram_stage_mapEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objdm_model_diagram_stage_mapEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objdm_model_diagram_stage_mapEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objdm_model_diagram_stage_mapEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.PrjId);
 var strPrjId = objdm_model_diagram_stage_mapEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objdm_model_diagram_stage_mapEN.diagram_id !=  null)
 {
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.diagram_id);
 var strdiagram_id = objdm_model_diagram_stage_mapEN.diagram_id.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strdiagram_id + "'");
 }
 
 if (objdm_model_diagram_stage_mapEN.stage_id !=  null)
 {
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.stage_id);
 var strstage_id = objdm_model_diagram_stage_mapEN.stage_id.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strstage_id + "'");
 }
 
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.x_pos);
 arrValueListForInsert.Add(objdm_model_diagram_stage_mapEN.x_pos.ToString());
 
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.y_pos);
 arrValueListForInsert.Add(objdm_model_diagram_stage_mapEN.y_pos.ToString());
 
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.Width);
 arrValueListForInsert.Add(objdm_model_diagram_stage_mapEN.Width.ToString());
 
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.Height);
 arrValueListForInsert.Add(objdm_model_diagram_stage_mapEN.Height.ToString());
 
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.sort_no);
 arrValueListForInsert.Add(objdm_model_diagram_stage_mapEN.sort_no.ToString());
 
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.is_visible);
 arrValueListForInsert.Add("'" + (objdm_model_diagram_stage_mapEN.is_visible  ==  false ? "0" : "1") + "'");
 
 if (objdm_model_diagram_stage_mapEN.Status !=  null)
 {
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.Status);
 var strStatus = objdm_model_diagram_stage_mapEN.Status.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStatus + "'");
 }
 
 if (objdm_model_diagram_stage_mapEN.created_by !=  null)
 {
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.created_by);
 var strcreated_by = objdm_model_diagram_stage_mapEN.created_by.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strcreated_by + "'");
 }
 
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.created_time);
 var dtecreated_time = objdm_model_diagram_stage_mapEN.created_time;
 arrValueListForInsert.Add("'" + dtecreated_time + "'");
 
 if (objdm_model_diagram_stage_mapEN.updated_by !=  null)
 {
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.updated_by);
 var strupdated_by = objdm_model_diagram_stage_mapEN.updated_by.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strupdated_by + "'");
 }
 
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.updated_time);
 var dteupdated_time = objdm_model_diagram_stage_mapEN.updated_time;
 arrValueListForInsert.Add("'" + dteupdated_time + "'");
 
 if (objdm_model_diagram_stage_mapEN.remark !=  null)
 {
 arrFieldListForInsert.Add(condm_model_diagram_stage_map.remark);
 var strremark = objdm_model_diagram_stage_mapEN.remark.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strremark + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into dm_model_diagram_stage_map");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_diagram_stage_mapDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewdm_model_diagram_stage_maps(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_diagram_stage_mapDA.GetSpecSQLObj();
strSQL = "Select * from dm_model_diagram_stage_map where diagram_stage_map_id = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "dm_model_diagram_stage_map");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngdiagram_stage_map_id = TransNullToInt(oRow[condm_model_diagram_stage_map.diagram_stage_map_id].ToString().Trim());
if (IsExist(lngdiagram_stage_map_id))
{
 string strResult = "关键字变量值为:" + string.Format("diagram_stage_map_id = {0}", lngdiagram_stage_map_id) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsdm_model_diagram_stage_mapEN._CurrTabName ].NewRow();
objRow[condm_model_diagram_stage_map.PrjId] = oRow[condm_model_diagram_stage_map.PrjId].ToString().Trim(); //工程Id
objRow[condm_model_diagram_stage_map.diagram_id] = oRow[condm_model_diagram_stage_map.diagram_id].ToString().Trim(); //图ID
objRow[condm_model_diagram_stage_map.stage_id] = oRow[condm_model_diagram_stage_map.stage_id].ToString().Trim(); //阶段ID
objRow[condm_model_diagram_stage_map.x_pos] = oRow[condm_model_diagram_stage_map.x_pos].ToString().Trim(); //X坐标
objRow[condm_model_diagram_stage_map.y_pos] = oRow[condm_model_diagram_stage_map.y_pos].ToString().Trim(); //Y坐标
objRow[condm_model_diagram_stage_map.Width] = oRow[condm_model_diagram_stage_map.Width].ToString().Trim(); //宽
objRow[condm_model_diagram_stage_map.Height] = oRow[condm_model_diagram_stage_map.Height].ToString().Trim(); //高度
objRow[condm_model_diagram_stage_map.sort_no] = oRow[condm_model_diagram_stage_map.sort_no].ToString().Trim(); //排序号
objRow[condm_model_diagram_stage_map.is_visible] = oRow[condm_model_diagram_stage_map.is_visible].ToString().Trim(); //是否可见
objRow[condm_model_diagram_stage_map.Status] = oRow[condm_model_diagram_stage_map.Status].ToString().Trim(); //Status
objRow[condm_model_diagram_stage_map.created_by] = oRow[condm_model_diagram_stage_map.created_by].ToString().Trim(); //创建人
objRow[condm_model_diagram_stage_map.created_time] = oRow[condm_model_diagram_stage_map.created_time].ToString().Trim(); //创建时间
objRow[condm_model_diagram_stage_map.updated_by] = oRow[condm_model_diagram_stage_map.updated_by].ToString().Trim(); //更新人
objRow[condm_model_diagram_stage_map.updated_time] = oRow[condm_model_diagram_stage_map.updated_time].ToString().Trim(); //更新时间
objRow[condm_model_diagram_stage_map.remark] = oRow[condm_model_diagram_stage_map.remark].ToString().Trim(); //备注
 objDS.Tables[clsdm_model_diagram_stage_mapEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsdm_model_diagram_stage_mapEN._CurrTabName);
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
 /// <param name = "objdm_model_diagram_stage_mapEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsdm_model_diagram_stage_mapEN objdm_model_diagram_stage_mapEN)
{
 if (objdm_model_diagram_stage_mapEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objdm_model_diagram_stage_mapEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_diagram_stage_mapDA.GetSpecSQLObj();
strSQL = "Select * from dm_model_diagram_stage_map where diagram_stage_map_id = " + ""+ objdm_model_diagram_stage_mapEN.diagram_stage_map_id+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsdm_model_diagram_stage_mapEN._CurrTabName);
if (objDS.Tables[clsdm_model_diagram_stage_mapEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:diagram_stage_map_id = " + ""+ objdm_model_diagram_stage_mapEN.diagram_stage_map_id+"");
return false;
}
objRow = objDS.Tables[clsdm_model_diagram_stage_mapEN._CurrTabName].Rows[0];
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.PrjId))
 {
objRow[condm_model_diagram_stage_map.PrjId] = objdm_model_diagram_stage_mapEN.PrjId; //工程Id
 }
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.diagram_id))
 {
objRow[condm_model_diagram_stage_map.diagram_id] = objdm_model_diagram_stage_mapEN.diagram_id; //图ID
 }
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.stage_id))
 {
objRow[condm_model_diagram_stage_map.stage_id] = objdm_model_diagram_stage_mapEN.stage_id; //阶段ID
 }
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.x_pos))
 {
objRow[condm_model_diagram_stage_map.x_pos] = objdm_model_diagram_stage_mapEN.x_pos; //X坐标
 }
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.y_pos))
 {
objRow[condm_model_diagram_stage_map.y_pos] = objdm_model_diagram_stage_mapEN.y_pos; //Y坐标
 }
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.Width))
 {
objRow[condm_model_diagram_stage_map.Width] = objdm_model_diagram_stage_mapEN.Width; //宽
 }
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.Height))
 {
objRow[condm_model_diagram_stage_map.Height] = objdm_model_diagram_stage_mapEN.Height; //高度
 }
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.sort_no))
 {
objRow[condm_model_diagram_stage_map.sort_no] = objdm_model_diagram_stage_mapEN.sort_no; //排序号
 }
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.is_visible))
 {
objRow[condm_model_diagram_stage_map.is_visible] = objdm_model_diagram_stage_mapEN.is_visible; //是否可见
 }
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.Status))
 {
objRow[condm_model_diagram_stage_map.Status] = objdm_model_diagram_stage_mapEN.Status; //Status
 }
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.created_by))
 {
objRow[condm_model_diagram_stage_map.created_by] = objdm_model_diagram_stage_mapEN.created_by; //创建人
 }
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.created_time))
 {
objRow[condm_model_diagram_stage_map.created_time] = objdm_model_diagram_stage_mapEN.created_time; //创建时间
 }
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.updated_by))
 {
objRow[condm_model_diagram_stage_map.updated_by] = objdm_model_diagram_stage_mapEN.updated_by; //更新人
 }
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.updated_time))
 {
objRow[condm_model_diagram_stage_map.updated_time] = objdm_model_diagram_stage_mapEN.updated_time; //更新时间
 }
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.remark))
 {
objRow[condm_model_diagram_stage_map.remark] = objdm_model_diagram_stage_mapEN.remark; //备注
 }
try
{
objDA.Update(objDS, clsdm_model_diagram_stage_mapEN._CurrTabName);
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
 /// <param name = "objdm_model_diagram_stage_mapEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsdm_model_diagram_stage_mapEN objdm_model_diagram_stage_mapEN)
{
 if (objdm_model_diagram_stage_mapEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objdm_model_diagram_stage_mapEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_diagram_stage_mapDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update dm_model_diagram_stage_map Set ");
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.PrjId))
 {
 if (objdm_model_diagram_stage_mapEN.PrjId !=  null)
 {
 var strPrjId = objdm_model_diagram_stage_mapEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, condm_model_diagram_stage_map.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",condm_model_diagram_stage_map.PrjId); //工程Id
 }
 }
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.diagram_id))
 {
 if (objdm_model_diagram_stage_mapEN.diagram_id !=  null)
 {
 var strdiagram_id = objdm_model_diagram_stage_mapEN.diagram_id.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strdiagram_id, condm_model_diagram_stage_map.diagram_id); //图ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",condm_model_diagram_stage_map.diagram_id); //图ID
 }
 }
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.stage_id))
 {
 if (objdm_model_diagram_stage_mapEN.stage_id !=  null)
 {
 var strstage_id = objdm_model_diagram_stage_mapEN.stage_id.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strstage_id, condm_model_diagram_stage_map.stage_id); //阶段ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",condm_model_diagram_stage_map.stage_id); //阶段ID
 }
 }
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.x_pos))
 {
 sbSQL.AppendFormat("{1} = {0},",objdm_model_diagram_stage_mapEN.x_pos, condm_model_diagram_stage_map.x_pos); //X坐标
 }
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.y_pos))
 {
 sbSQL.AppendFormat("{1} = {0},",objdm_model_diagram_stage_mapEN.y_pos, condm_model_diagram_stage_map.y_pos); //Y坐标
 }
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.Width))
 {
 sbSQL.AppendFormat("{1} = {0},",objdm_model_diagram_stage_mapEN.Width, condm_model_diagram_stage_map.Width); //宽
 }
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.Height))
 {
 sbSQL.AppendFormat("{1} = {0},",objdm_model_diagram_stage_mapEN.Height, condm_model_diagram_stage_map.Height); //高度
 }
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.sort_no))
 {
 sbSQL.AppendFormat("{1} = {0},",objdm_model_diagram_stage_mapEN.sort_no, condm_model_diagram_stage_map.sort_no); //排序号
 }
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.is_visible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objdm_model_diagram_stage_mapEN.is_visible == true?"1":"0", condm_model_diagram_stage_map.is_visible); //是否可见
 }
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.Status))
 {
 if (objdm_model_diagram_stage_mapEN.Status !=  null)
 {
 var strStatus = objdm_model_diagram_stage_mapEN.Status.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStatus, condm_model_diagram_stage_map.Status); //Status
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",condm_model_diagram_stage_map.Status); //Status
 }
 }
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.created_by))
 {
 if (objdm_model_diagram_stage_mapEN.created_by !=  null)
 {
 var strcreated_by = objdm_model_diagram_stage_mapEN.created_by.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strcreated_by, condm_model_diagram_stage_map.created_by); //创建人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",condm_model_diagram_stage_map.created_by); //创建人
 }
 }
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.created_time))
 {
 if (objdm_model_diagram_stage_mapEN.created_time !=  null)
 {
 var dtecreated_time = objdm_model_diagram_stage_mapEN.created_time;
 sbSQL.AppendFormat("{1} = '{0}',", dtecreated_time, condm_model_diagram_stage_map.created_time); //创建时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",condm_model_diagram_stage_map.created_time); //创建时间
 }
 }
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.updated_by))
 {
 if (objdm_model_diagram_stage_mapEN.updated_by !=  null)
 {
 var strupdated_by = objdm_model_diagram_stage_mapEN.updated_by.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strupdated_by, condm_model_diagram_stage_map.updated_by); //更新人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",condm_model_diagram_stage_map.updated_by); //更新人
 }
 }
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.updated_time))
 {
 if (objdm_model_diagram_stage_mapEN.updated_time !=  null)
 {
 var dteupdated_time = objdm_model_diagram_stage_mapEN.updated_time;
 sbSQL.AppendFormat("{1} = '{0}',", dteupdated_time, condm_model_diagram_stage_map.updated_time); //更新时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",condm_model_diagram_stage_map.updated_time); //更新时间
 }
 }
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.remark))
 {
 if (objdm_model_diagram_stage_mapEN.remark !=  null)
 {
 var strremark = objdm_model_diagram_stage_mapEN.remark.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strremark, condm_model_diagram_stage_map.remark); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",condm_model_diagram_stage_map.remark); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where diagram_stage_map_id = {0}", objdm_model_diagram_stage_mapEN.diagram_stage_map_id); 
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
 /// <param name = "objdm_model_diagram_stage_mapEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsdm_model_diagram_stage_mapEN objdm_model_diagram_stage_mapEN, string strCondition)
{
 if (objdm_model_diagram_stage_mapEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objdm_model_diagram_stage_mapEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_diagram_stage_mapDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update dm_model_diagram_stage_map Set ");
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.PrjId))
 {
 if (objdm_model_diagram_stage_mapEN.PrjId !=  null)
 {
 var strPrjId = objdm_model_diagram_stage_mapEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.diagram_id))
 {
 if (objdm_model_diagram_stage_mapEN.diagram_id !=  null)
 {
 var strdiagram_id = objdm_model_diagram_stage_mapEN.diagram_id.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" diagram_id = '{0}',", strdiagram_id); //图ID
 }
 else
 {
 sbSQL.Append(" diagram_id = null,"); //图ID
 }
 }
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.stage_id))
 {
 if (objdm_model_diagram_stage_mapEN.stage_id !=  null)
 {
 var strstage_id = objdm_model_diagram_stage_mapEN.stage_id.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" stage_id = '{0}',", strstage_id); //阶段ID
 }
 else
 {
 sbSQL.Append(" stage_id = null,"); //阶段ID
 }
 }
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.x_pos))
 {
 sbSQL.AppendFormat(" x_pos = {0},", objdm_model_diagram_stage_mapEN.x_pos); //X坐标
 }
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.y_pos))
 {
 sbSQL.AppendFormat(" y_pos = {0},", objdm_model_diagram_stage_mapEN.y_pos); //Y坐标
 }
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.Width))
 {
 sbSQL.AppendFormat(" Width = {0},", objdm_model_diagram_stage_mapEN.Width); //宽
 }
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.Height))
 {
 sbSQL.AppendFormat(" Height = {0},", objdm_model_diagram_stage_mapEN.Height); //高度
 }
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.sort_no))
 {
 sbSQL.AppendFormat(" sort_no = {0},", objdm_model_diagram_stage_mapEN.sort_no); //排序号
 }
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.is_visible))
 {
 sbSQL.AppendFormat(" is_visible = '{0}',", objdm_model_diagram_stage_mapEN.is_visible == true?"1":"0"); //是否可见
 }
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.Status))
 {
 if (objdm_model_diagram_stage_mapEN.Status !=  null)
 {
 var strStatus = objdm_model_diagram_stage_mapEN.Status.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Status = '{0}',", strStatus); //Status
 }
 else
 {
 sbSQL.Append(" Status = null,"); //Status
 }
 }
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.created_by))
 {
 if (objdm_model_diagram_stage_mapEN.created_by !=  null)
 {
 var strcreated_by = objdm_model_diagram_stage_mapEN.created_by.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" created_by = '{0}',", strcreated_by); //创建人
 }
 else
 {
 sbSQL.Append(" created_by = null,"); //创建人
 }
 }
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.created_time))
 {
 if (objdm_model_diagram_stage_mapEN.created_time !=  null)
 {
 var dtecreated_time = objdm_model_diagram_stage_mapEN.created_time;
 sbSQL.AppendFormat(" created_time = '{0}',", dtecreated_time); //创建时间
 }
 else
 {
 sbSQL.Append(" created_time = null,"); //创建时间
 }
 }
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.updated_by))
 {
 if (objdm_model_diagram_stage_mapEN.updated_by !=  null)
 {
 var strupdated_by = objdm_model_diagram_stage_mapEN.updated_by.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" updated_by = '{0}',", strupdated_by); //更新人
 }
 else
 {
 sbSQL.Append(" updated_by = null,"); //更新人
 }
 }
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.updated_time))
 {
 if (objdm_model_diagram_stage_mapEN.updated_time !=  null)
 {
 var dteupdated_time = objdm_model_diagram_stage_mapEN.updated_time;
 sbSQL.AppendFormat(" updated_time = '{0}',", dteupdated_time); //更新时间
 }
 else
 {
 sbSQL.Append(" updated_time = null,"); //更新时间
 }
 }
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.remark))
 {
 if (objdm_model_diagram_stage_mapEN.remark !=  null)
 {
 var strremark = objdm_model_diagram_stage_mapEN.remark.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" remark = '{0}',", strremark); //备注
 }
 else
 {
 sbSQL.Append(" remark = null,"); //备注
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
 /// <param name = "objdm_model_diagram_stage_mapEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsdm_model_diagram_stage_mapEN objdm_model_diagram_stage_mapEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objdm_model_diagram_stage_mapEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objdm_model_diagram_stage_mapEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_diagram_stage_mapDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update dm_model_diagram_stage_map Set ");
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.PrjId))
 {
 if (objdm_model_diagram_stage_mapEN.PrjId !=  null)
 {
 var strPrjId = objdm_model_diagram_stage_mapEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.diagram_id))
 {
 if (objdm_model_diagram_stage_mapEN.diagram_id !=  null)
 {
 var strdiagram_id = objdm_model_diagram_stage_mapEN.diagram_id.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" diagram_id = '{0}',", strdiagram_id); //图ID
 }
 else
 {
 sbSQL.Append(" diagram_id = null,"); //图ID
 }
 }
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.stage_id))
 {
 if (objdm_model_diagram_stage_mapEN.stage_id !=  null)
 {
 var strstage_id = objdm_model_diagram_stage_mapEN.stage_id.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" stage_id = '{0}',", strstage_id); //阶段ID
 }
 else
 {
 sbSQL.Append(" stage_id = null,"); //阶段ID
 }
 }
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.x_pos))
 {
 sbSQL.AppendFormat(" x_pos = {0},", objdm_model_diagram_stage_mapEN.x_pos); //X坐标
 }
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.y_pos))
 {
 sbSQL.AppendFormat(" y_pos = {0},", objdm_model_diagram_stage_mapEN.y_pos); //Y坐标
 }
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.Width))
 {
 sbSQL.AppendFormat(" Width = {0},", objdm_model_diagram_stage_mapEN.Width); //宽
 }
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.Height))
 {
 sbSQL.AppendFormat(" Height = {0},", objdm_model_diagram_stage_mapEN.Height); //高度
 }
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.sort_no))
 {
 sbSQL.AppendFormat(" sort_no = {0},", objdm_model_diagram_stage_mapEN.sort_no); //排序号
 }
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.is_visible))
 {
 sbSQL.AppendFormat(" is_visible = '{0}',", objdm_model_diagram_stage_mapEN.is_visible == true?"1":"0"); //是否可见
 }
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.Status))
 {
 if (objdm_model_diagram_stage_mapEN.Status !=  null)
 {
 var strStatus = objdm_model_diagram_stage_mapEN.Status.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Status = '{0}',", strStatus); //Status
 }
 else
 {
 sbSQL.Append(" Status = null,"); //Status
 }
 }
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.created_by))
 {
 if (objdm_model_diagram_stage_mapEN.created_by !=  null)
 {
 var strcreated_by = objdm_model_diagram_stage_mapEN.created_by.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" created_by = '{0}',", strcreated_by); //创建人
 }
 else
 {
 sbSQL.Append(" created_by = null,"); //创建人
 }
 }
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.created_time))
 {
 if (objdm_model_diagram_stage_mapEN.created_time !=  null)
 {
 var dtecreated_time = objdm_model_diagram_stage_mapEN.created_time;
 sbSQL.AppendFormat(" created_time = '{0}',", dtecreated_time); //创建时间
 }
 else
 {
 sbSQL.Append(" created_time = null,"); //创建时间
 }
 }
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.updated_by))
 {
 if (objdm_model_diagram_stage_mapEN.updated_by !=  null)
 {
 var strupdated_by = objdm_model_diagram_stage_mapEN.updated_by.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" updated_by = '{0}',", strupdated_by); //更新人
 }
 else
 {
 sbSQL.Append(" updated_by = null,"); //更新人
 }
 }
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.updated_time))
 {
 if (objdm_model_diagram_stage_mapEN.updated_time !=  null)
 {
 var dteupdated_time = objdm_model_diagram_stage_mapEN.updated_time;
 sbSQL.AppendFormat(" updated_time = '{0}',", dteupdated_time); //更新时间
 }
 else
 {
 sbSQL.Append(" updated_time = null,"); //更新时间
 }
 }
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.remark))
 {
 if (objdm_model_diagram_stage_mapEN.remark !=  null)
 {
 var strremark = objdm_model_diagram_stage_mapEN.remark.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" remark = '{0}',", strremark); //备注
 }
 else
 {
 sbSQL.Append(" remark = null,"); //备注
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
 /// <param name = "objdm_model_diagram_stage_mapEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsdm_model_diagram_stage_mapEN objdm_model_diagram_stage_mapEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objdm_model_diagram_stage_mapEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objdm_model_diagram_stage_mapEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_diagram_stage_mapDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update dm_model_diagram_stage_map Set ");
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.PrjId))
 {
 if (objdm_model_diagram_stage_mapEN.PrjId !=  null)
 {
 var strPrjId = objdm_model_diagram_stage_mapEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, condm_model_diagram_stage_map.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",condm_model_diagram_stage_map.PrjId); //工程Id
 }
 }
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.diagram_id))
 {
 if (objdm_model_diagram_stage_mapEN.diagram_id !=  null)
 {
 var strdiagram_id = objdm_model_diagram_stage_mapEN.diagram_id.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strdiagram_id, condm_model_diagram_stage_map.diagram_id); //图ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",condm_model_diagram_stage_map.diagram_id); //图ID
 }
 }
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.stage_id))
 {
 if (objdm_model_diagram_stage_mapEN.stage_id !=  null)
 {
 var strstage_id = objdm_model_diagram_stage_mapEN.stage_id.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strstage_id, condm_model_diagram_stage_map.stage_id); //阶段ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",condm_model_diagram_stage_map.stage_id); //阶段ID
 }
 }
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.x_pos))
 {
 sbSQL.AppendFormat("{1} = {0},",objdm_model_diagram_stage_mapEN.x_pos, condm_model_diagram_stage_map.x_pos); //X坐标
 }
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.y_pos))
 {
 sbSQL.AppendFormat("{1} = {0},",objdm_model_diagram_stage_mapEN.y_pos, condm_model_diagram_stage_map.y_pos); //Y坐标
 }
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.Width))
 {
 sbSQL.AppendFormat("{1} = {0},",objdm_model_diagram_stage_mapEN.Width, condm_model_diagram_stage_map.Width); //宽
 }
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.Height))
 {
 sbSQL.AppendFormat("{1} = {0},",objdm_model_diagram_stage_mapEN.Height, condm_model_diagram_stage_map.Height); //高度
 }
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.sort_no))
 {
 sbSQL.AppendFormat("{1} = {0},",objdm_model_diagram_stage_mapEN.sort_no, condm_model_diagram_stage_map.sort_no); //排序号
 }
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.is_visible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objdm_model_diagram_stage_mapEN.is_visible == true?"1":"0", condm_model_diagram_stage_map.is_visible); //是否可见
 }
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.Status))
 {
 if (objdm_model_diagram_stage_mapEN.Status !=  null)
 {
 var strStatus = objdm_model_diagram_stage_mapEN.Status.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStatus, condm_model_diagram_stage_map.Status); //Status
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",condm_model_diagram_stage_map.Status); //Status
 }
 }
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.created_by))
 {
 if (objdm_model_diagram_stage_mapEN.created_by !=  null)
 {
 var strcreated_by = objdm_model_diagram_stage_mapEN.created_by.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strcreated_by, condm_model_diagram_stage_map.created_by); //创建人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",condm_model_diagram_stage_map.created_by); //创建人
 }
 }
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.created_time))
 {
 if (objdm_model_diagram_stage_mapEN.created_time !=  null)
 {
 var dtecreated_time = objdm_model_diagram_stage_mapEN.created_time;
 sbSQL.AppendFormat("{1} = '{0}',", dtecreated_time, condm_model_diagram_stage_map.created_time); //创建时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",condm_model_diagram_stage_map.created_time); //创建时间
 }
 }
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.updated_by))
 {
 if (objdm_model_diagram_stage_mapEN.updated_by !=  null)
 {
 var strupdated_by = objdm_model_diagram_stage_mapEN.updated_by.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strupdated_by, condm_model_diagram_stage_map.updated_by); //更新人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",condm_model_diagram_stage_map.updated_by); //更新人
 }
 }
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.updated_time))
 {
 if (objdm_model_diagram_stage_mapEN.updated_time !=  null)
 {
 var dteupdated_time = objdm_model_diagram_stage_mapEN.updated_time;
 sbSQL.AppendFormat("{1} = '{0}',", dteupdated_time, condm_model_diagram_stage_map.updated_time); //更新时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",condm_model_diagram_stage_map.updated_time); //更新时间
 }
 }
 
 if (objdm_model_diagram_stage_mapEN.IsUpdated(condm_model_diagram_stage_map.remark))
 {
 if (objdm_model_diagram_stage_mapEN.remark !=  null)
 {
 var strremark = objdm_model_diagram_stage_mapEN.remark.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strremark, condm_model_diagram_stage_map.remark); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",condm_model_diagram_stage_map.remark); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where diagram_stage_map_id = {0}", objdm_model_diagram_stage_mapEN.diagram_stage_map_id); 
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
 /// <param name = "lngdiagram_stage_map_id">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngdiagram_stage_map_id) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_diagram_stage_mapDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngdiagram_stage_map_id,
};
 objSQL.ExecSP("dm_model_diagram_stage_map_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngdiagram_stage_map_id">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngdiagram_stage_map_id, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_diagram_stage_mapDA.GetSpecSQLObj();
//删除dm_model_diagram_stage_map本表中与当前对象有关的记录
strSQL = strSQL + "Delete from dm_model_diagram_stage_map where diagram_stage_map_id = " + ""+ lngdiagram_stage_map_id+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Deldm_model_diagram_stage_map(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_diagram_stage_mapDA.GetSpecSQLObj();
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
//删除dm_model_diagram_stage_map本表中与当前对象有关的记录
strSQL = strSQL + "Delete from dm_model_diagram_stage_map where diagram_stage_map_id in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngdiagram_stage_map_id">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngdiagram_stage_map_id) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_diagram_stage_mapDA.GetSpecSQLObj();
//删除dm_model_diagram_stage_map本表中与当前对象有关的记录
strSQL = strSQL + "Delete from dm_model_diagram_stage_map where diagram_stage_map_id = " + ""+ lngdiagram_stage_map_id+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Deldm_model_diagram_stage_map(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsdm_model_diagram_stage_mapDA: Deldm_model_diagram_stage_map)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_diagram_stage_mapDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from dm_model_diagram_stage_map where " + strCondition ;
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
public bool Deldm_model_diagram_stage_mapWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsdm_model_diagram_stage_mapDA: Deldm_model_diagram_stage_mapWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_diagram_stage_mapDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from dm_model_diagram_stage_map where " + strCondition ;
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
 /// <param name = "objdm_model_diagram_stage_mapENS">源对象</param>
 /// <param name = "objdm_model_diagram_stage_mapENT">目标对象</param>
public void CopyTo(clsdm_model_diagram_stage_mapEN objdm_model_diagram_stage_mapENS, clsdm_model_diagram_stage_mapEN objdm_model_diagram_stage_mapENT)
{
objdm_model_diagram_stage_mapENT.diagram_stage_map_id = objdm_model_diagram_stage_mapENS.diagram_stage_map_id; //图阶段映射ID
objdm_model_diagram_stage_mapENT.PrjId = objdm_model_diagram_stage_mapENS.PrjId; //工程Id
objdm_model_diagram_stage_mapENT.diagram_id = objdm_model_diagram_stage_mapENS.diagram_id; //图ID
objdm_model_diagram_stage_mapENT.stage_id = objdm_model_diagram_stage_mapENS.stage_id; //阶段ID
objdm_model_diagram_stage_mapENT.x_pos = objdm_model_diagram_stage_mapENS.x_pos; //X坐标
objdm_model_diagram_stage_mapENT.y_pos = objdm_model_diagram_stage_mapENS.y_pos; //Y坐标
objdm_model_diagram_stage_mapENT.Width = objdm_model_diagram_stage_mapENS.Width; //宽
objdm_model_diagram_stage_mapENT.Height = objdm_model_diagram_stage_mapENS.Height; //高度
objdm_model_diagram_stage_mapENT.sort_no = objdm_model_diagram_stage_mapENS.sort_no; //排序号
objdm_model_diagram_stage_mapENT.is_visible = objdm_model_diagram_stage_mapENS.is_visible; //是否可见
objdm_model_diagram_stage_mapENT.Status = objdm_model_diagram_stage_mapENS.Status; //Status
objdm_model_diagram_stage_mapENT.created_by = objdm_model_diagram_stage_mapENS.created_by; //创建人
objdm_model_diagram_stage_mapENT.created_time = objdm_model_diagram_stage_mapENS.created_time; //创建时间
objdm_model_diagram_stage_mapENT.updated_by = objdm_model_diagram_stage_mapENS.updated_by; //更新人
objdm_model_diagram_stage_mapENT.updated_time = objdm_model_diagram_stage_mapENS.updated_time; //更新时间
objdm_model_diagram_stage_mapENT.remark = objdm_model_diagram_stage_mapENS.remark; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsdm_model_diagram_stage_mapEN objdm_model_diagram_stage_mapEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objdm_model_diagram_stage_mapEN.PrjId, condm_model_diagram_stage_map.PrjId);
clsCheckSql.CheckFieldNotNull(objdm_model_diagram_stage_mapEN.diagram_id, condm_model_diagram_stage_map.diagram_id);
clsCheckSql.CheckFieldNotNull(objdm_model_diagram_stage_mapEN.stage_id, condm_model_diagram_stage_map.stage_id);
clsCheckSql.CheckFieldNotNull(objdm_model_diagram_stage_mapEN.x_pos, condm_model_diagram_stage_map.x_pos);
clsCheckSql.CheckFieldNotNull(objdm_model_diagram_stage_mapEN.y_pos, condm_model_diagram_stage_map.y_pos);
clsCheckSql.CheckFieldNotNull(objdm_model_diagram_stage_mapEN.Width, condm_model_diagram_stage_map.Width);
clsCheckSql.CheckFieldNotNull(objdm_model_diagram_stage_mapEN.Height, condm_model_diagram_stage_map.Height);
clsCheckSql.CheckFieldNotNull(objdm_model_diagram_stage_mapEN.sort_no, condm_model_diagram_stage_map.sort_no);
clsCheckSql.CheckFieldNotNull(objdm_model_diagram_stage_mapEN.is_visible, condm_model_diagram_stage_map.is_visible);
clsCheckSql.CheckFieldNotNull(objdm_model_diagram_stage_mapEN.Status, condm_model_diagram_stage_map.Status);
clsCheckSql.CheckFieldNotNull(objdm_model_diagram_stage_mapEN.created_by, condm_model_diagram_stage_map.created_by);
clsCheckSql.CheckFieldNotNull(objdm_model_diagram_stage_mapEN.created_time, condm_model_diagram_stage_map.created_time);
clsCheckSql.CheckFieldNotNull(objdm_model_diagram_stage_mapEN.updated_by, condm_model_diagram_stage_map.updated_by);
clsCheckSql.CheckFieldNotNull(objdm_model_diagram_stage_mapEN.updated_time, condm_model_diagram_stage_map.updated_time);
//检查字段长度
clsCheckSql.CheckFieldLen(objdm_model_diagram_stage_mapEN.PrjId, 4, condm_model_diagram_stage_map.PrjId);
clsCheckSql.CheckFieldLen(objdm_model_diagram_stage_mapEN.diagram_id, 8, condm_model_diagram_stage_map.diagram_id);
clsCheckSql.CheckFieldLen(objdm_model_diagram_stage_mapEN.stage_id, 8, condm_model_diagram_stage_map.stage_id);
clsCheckSql.CheckFieldLen(objdm_model_diagram_stage_mapEN.Status, 20, condm_model_diagram_stage_map.Status);
clsCheckSql.CheckFieldLen(objdm_model_diagram_stage_mapEN.created_by, 50, condm_model_diagram_stage_map.created_by);
clsCheckSql.CheckFieldLen(objdm_model_diagram_stage_mapEN.updated_by, 50, condm_model_diagram_stage_map.updated_by);
clsCheckSql.CheckFieldLen(objdm_model_diagram_stage_mapEN.remark, 500, condm_model_diagram_stage_map.remark);
//检查字段外键固定长度
 objdm_model_diagram_stage_mapEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsdm_model_diagram_stage_mapEN objdm_model_diagram_stage_mapEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objdm_model_diagram_stage_mapEN.PrjId, 4, condm_model_diagram_stage_map.PrjId);
clsCheckSql.CheckFieldLen(objdm_model_diagram_stage_mapEN.diagram_id, 8, condm_model_diagram_stage_map.diagram_id);
clsCheckSql.CheckFieldLen(objdm_model_diagram_stage_mapEN.stage_id, 8, condm_model_diagram_stage_map.stage_id);
clsCheckSql.CheckFieldLen(objdm_model_diagram_stage_mapEN.Status, 20, condm_model_diagram_stage_map.Status);
clsCheckSql.CheckFieldLen(objdm_model_diagram_stage_mapEN.created_by, 50, condm_model_diagram_stage_map.created_by);
clsCheckSql.CheckFieldLen(objdm_model_diagram_stage_mapEN.updated_by, 50, condm_model_diagram_stage_map.updated_by);
clsCheckSql.CheckFieldLen(objdm_model_diagram_stage_mapEN.remark, 500, condm_model_diagram_stage_map.remark);
//检查外键字段长度
 objdm_model_diagram_stage_mapEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsdm_model_diagram_stage_mapEN objdm_model_diagram_stage_mapEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objdm_model_diagram_stage_mapEN.PrjId, 4, condm_model_diagram_stage_map.PrjId);
clsCheckSql.CheckFieldLen(objdm_model_diagram_stage_mapEN.diagram_id, 8, condm_model_diagram_stage_map.diagram_id);
clsCheckSql.CheckFieldLen(objdm_model_diagram_stage_mapEN.stage_id, 8, condm_model_diagram_stage_map.stage_id);
clsCheckSql.CheckFieldLen(objdm_model_diagram_stage_mapEN.Status, 20, condm_model_diagram_stage_map.Status);
clsCheckSql.CheckFieldLen(objdm_model_diagram_stage_mapEN.created_by, 50, condm_model_diagram_stage_map.created_by);
clsCheckSql.CheckFieldLen(objdm_model_diagram_stage_mapEN.updated_by, 50, condm_model_diagram_stage_map.updated_by);
clsCheckSql.CheckFieldLen(objdm_model_diagram_stage_mapEN.remark, 500, condm_model_diagram_stage_map.remark);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objdm_model_diagram_stage_mapEN.PrjId, condm_model_diagram_stage_map.PrjId);
clsCheckSql.CheckSqlInjection4Field(objdm_model_diagram_stage_mapEN.diagram_id, condm_model_diagram_stage_map.diagram_id);
clsCheckSql.CheckSqlInjection4Field(objdm_model_diagram_stage_mapEN.stage_id, condm_model_diagram_stage_map.stage_id);
clsCheckSql.CheckSqlInjection4Field(objdm_model_diagram_stage_mapEN.Status, condm_model_diagram_stage_map.Status);
clsCheckSql.CheckSqlInjection4Field(objdm_model_diagram_stage_mapEN.created_by, condm_model_diagram_stage_map.created_by);
clsCheckSql.CheckSqlInjection4Field(objdm_model_diagram_stage_mapEN.updated_by, condm_model_diagram_stage_map.updated_by);
clsCheckSql.CheckSqlInjection4Field(objdm_model_diagram_stage_mapEN.remark, condm_model_diagram_stage_map.remark);
//检查外键字段长度
 objdm_model_diagram_stage_mapEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--dm_model_diagram_stage_map(图阶段布局映射),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objdm_model_diagram_stage_mapEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsdm_model_diagram_stage_mapEN objdm_model_diagram_stage_mapEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and diagram_id = '{0}'", objdm_model_diagram_stage_mapEN.diagram_id);
 sbCondition.AppendFormat(" and stage_id = '{0}'", objdm_model_diagram_stage_mapEN.stage_id);
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
 objSQL = clsdm_model_diagram_stage_mapDA.GetSpecSQLObj();
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
 objSQL = clsdm_model_diagram_stage_mapDA.GetSpecSQLObj();
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
 objSQL = clsdm_model_diagram_stage_mapDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsdm_model_diagram_stage_mapEN._CurrTabName);
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
 objSQL = clsdm_model_diagram_stage_mapDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsdm_model_diagram_stage_mapEN._CurrTabName, strCondition);
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
 objSQL = clsdm_model_diagram_stage_mapDA.GetSpecSQLObj();
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
 objSQL = clsdm_model_diagram_stage_mapDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}