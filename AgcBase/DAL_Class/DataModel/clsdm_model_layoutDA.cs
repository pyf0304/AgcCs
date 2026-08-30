
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsdm_model_layoutDA
 表名:dm_model_layout(00050663)
 * 版本:2026.08.01(服务器:WIN-SRV103-116)
 日期:2026/08/04 15:30:37
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:数据模型(DataModel)
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
 /// 模型布局表(dm_model_layout)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsdm_model_layoutDA : clsCommBase4DA
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
 return clsdm_model_layoutEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsdm_model_layoutEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsdm_model_layoutEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsdm_model_layoutEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsdm_model_layoutEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strmodel_id">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strmodel_id)
{
strmodel_id = strmodel_id.Replace("'", "''");
if (strmodel_id.Length > 32)
{
throw new Exception("(errid:Data000001)在表:dm_model_layout中,检查关键字,长度不正确!(clsdm_model_layoutDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strmodel_id)  ==  true)
{
throw new Exception("(errid:Data000002)在表:dm_model_layout中,关键字不能为空 或 null!(clsdm_model_layoutDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strmodel_id);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsdm_model_layoutDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsdm_model_layoutDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_layoutDA.GetSpecSQLObj();
strSQL = "Select * from dm_model_layout where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_dm_model_layout(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsdm_model_layoutDA: GetDataTable_dm_model_layout)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_layoutDA.GetSpecSQLObj();
strSQL = "Select * from dm_model_layout where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsdm_model_layoutDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_layoutDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsdm_model_layoutDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_layoutDA.GetSpecSQLObj();
strSQL = "Select * from dm_model_layout where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsdm_model_layoutDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_layoutDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsdm_model_layoutDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_layoutDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from dm_model_layout where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from dm_model_layout where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsdm_model_layoutDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_layoutDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from dm_model_layout where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsdm_model_layoutDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_layoutDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} dm_model_layout.* " + 
$"from dm_model_layout " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and dm_model_layout.model_id not in " + 
$"(Select top {intTop_In} dm_model_layout.model_id from dm_model_layout " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from dm_model_layout where {1} and model_id not in (Select top {2} model_id from dm_model_layout where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from dm_model_layout where {1} and model_id not in (Select top {3} model_id from dm_model_layout where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsdm_model_layoutDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_layoutDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} dm_model_layout.* " + 
$"from dm_model_layout " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and dm_model_layout.model_id not in " + 
$"(Select top {intTop_In} dm_model_layout.model_id from dm_model_layout " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from dm_model_layout where {1} and model_id not in (Select top {2} model_id from dm_model_layout where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from dm_model_layout where {1} and model_id not in (Select top {3} model_id from dm_model_layout where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsdm_model_layoutEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsdm_model_layoutDA:GetObjLst)", objException.Message));
}
List<clsdm_model_layoutEN> arrObjLst = new List<clsdm_model_layoutEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_layoutDA.GetSpecSQLObj();
strSQL = "Select * from dm_model_layout where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsdm_model_layoutEN objdm_model_layoutEN = new clsdm_model_layoutEN();
try
{
objdm_model_layoutEN.model_id = objRow[condm_model_layout.model_id].ToString().Trim(); //模型ID
objdm_model_layoutEN.model_name = objRow[condm_model_layout.model_name].ToString().Trim(); //模型名称
objdm_model_layoutEN.prj_id = objRow[condm_model_layout.prj_id].ToString().Trim(); //项目ID
objdm_model_layoutEN.model_desc = objRow[condm_model_layout.model_desc] == DBNull.Value ? null : objRow[condm_model_layout.model_desc].ToString().Trim(); //模型说明
objdm_model_layoutEN.layout_data = objRow[condm_model_layout.layout_data] == DBNull.Value ? null : objRow[condm_model_layout.layout_data].ToString().Trim(); //布局数据
objdm_model_layoutEN.canvas_height = objRow[condm_model_layout.canvas_height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[condm_model_layout.canvas_height].ToString().Trim()); //画布高
objdm_model_layoutEN.canvas_width = objRow[condm_model_layout.canvas_width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[condm_model_layout.canvas_width].ToString().Trim()); //画布宽
objdm_model_layoutEN.Status = objRow[condm_model_layout.Status].ToString().Trim(); //Status
objdm_model_layoutEN.sort_no = objRow[condm_model_layout.sort_no] == DBNull.Value ? (int?)null : TransNullToInt(objRow[condm_model_layout.sort_no].ToString().Trim()); //排序号
objdm_model_layoutEN.created_by = objRow[condm_model_layout.created_by] == DBNull.Value ? null : objRow[condm_model_layout.created_by].ToString().Trim(); //创建人
objdm_model_layoutEN.created_time = TransNullToDate(objRow[condm_model_layout.created_time].ToString().Trim()); //创建时间
objdm_model_layoutEN.updated_by = objRow[condm_model_layout.updated_by] == DBNull.Value ? null : objRow[condm_model_layout.updated_by].ToString().Trim(); //更新人
objdm_model_layoutEN.updated_time = TransNullToDate(objRow[condm_model_layout.updated_time].ToString().Trim()); //更新时间
objdm_model_layoutEN.remark = objRow[condm_model_layout.remark] == DBNull.Value ? null : objRow[condm_model_layout.remark].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsdm_model_layoutDA: GetObjLst)", objException.Message));
}
objdm_model_layoutEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objdm_model_layoutEN);
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
public List<clsdm_model_layoutEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsdm_model_layoutDA:GetObjLstByTabName)", objException.Message));
}
List<clsdm_model_layoutEN> arrObjLst = new List<clsdm_model_layoutEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_layoutDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsdm_model_layoutEN objdm_model_layoutEN = new clsdm_model_layoutEN();
try
{
objdm_model_layoutEN.model_id = objRow[condm_model_layout.model_id].ToString().Trim(); //模型ID
objdm_model_layoutEN.model_name = objRow[condm_model_layout.model_name].ToString().Trim(); //模型名称
objdm_model_layoutEN.prj_id = objRow[condm_model_layout.prj_id].ToString().Trim(); //项目ID
objdm_model_layoutEN.model_desc = objRow[condm_model_layout.model_desc] == DBNull.Value ? null : objRow[condm_model_layout.model_desc].ToString().Trim(); //模型说明
objdm_model_layoutEN.layout_data = objRow[condm_model_layout.layout_data] == DBNull.Value ? null : objRow[condm_model_layout.layout_data].ToString().Trim(); //布局数据
objdm_model_layoutEN.canvas_height = objRow[condm_model_layout.canvas_height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[condm_model_layout.canvas_height].ToString().Trim()); //画布高
objdm_model_layoutEN.canvas_width = objRow[condm_model_layout.canvas_width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[condm_model_layout.canvas_width].ToString().Trim()); //画布宽
objdm_model_layoutEN.Status = objRow[condm_model_layout.Status].ToString().Trim(); //Status
objdm_model_layoutEN.sort_no = objRow[condm_model_layout.sort_no] == DBNull.Value ? (int?)null : TransNullToInt(objRow[condm_model_layout.sort_no].ToString().Trim()); //排序号
objdm_model_layoutEN.created_by = objRow[condm_model_layout.created_by] == DBNull.Value ? null : objRow[condm_model_layout.created_by].ToString().Trim(); //创建人
objdm_model_layoutEN.created_time = TransNullToDate(objRow[condm_model_layout.created_time].ToString().Trim()); //创建时间
objdm_model_layoutEN.updated_by = objRow[condm_model_layout.updated_by] == DBNull.Value ? null : objRow[condm_model_layout.updated_by].ToString().Trim(); //更新人
objdm_model_layoutEN.updated_time = TransNullToDate(objRow[condm_model_layout.updated_time].ToString().Trim()); //更新时间
objdm_model_layoutEN.remark = objRow[condm_model_layout.remark] == DBNull.Value ? null : objRow[condm_model_layout.remark].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsdm_model_layoutDA: GetObjLst)", objException.Message));
}
objdm_model_layoutEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objdm_model_layoutEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objdm_model_layoutEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getdm_model_layout(ref clsdm_model_layoutEN objdm_model_layoutEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_layoutDA.GetSpecSQLObj();
strSQL = "Select * from dm_model_layout where model_id = " + "'"+ objdm_model_layoutEN.model_id+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objdm_model_layoutEN.model_id = objDT.Rows[0][condm_model_layout.model_id].ToString().Trim(); //模型ID(字段类型:varchar,字段长度:32,是否可空:False)
 objdm_model_layoutEN.model_name = objDT.Rows[0][condm_model_layout.model_name].ToString().Trim(); //模型名称(字段类型:varchar,字段长度:100,是否可空:False)
 objdm_model_layoutEN.prj_id = objDT.Rows[0][condm_model_layout.prj_id].ToString().Trim(); //项目ID(字段类型:varchar,字段长度:32,是否可空:False)
 objdm_model_layoutEN.model_desc = objDT.Rows[0][condm_model_layout.model_desc].ToString().Trim(); //模型说明(字段类型:varchar,字段长度:500,是否可空:True)
 objdm_model_layoutEN.layout_data = objDT.Rows[0][condm_model_layout.layout_data].ToString().Trim(); //布局数据(字段类型:varchar,字段长度:4000,是否可空:True)
 objdm_model_layoutEN.canvas_height = TransNullToInt(objDT.Rows[0][condm_model_layout.canvas_height].ToString().Trim()); //画布高(字段类型:int,字段长度:4,是否可空:True)
 objdm_model_layoutEN.canvas_width = TransNullToInt(objDT.Rows[0][condm_model_layout.canvas_width].ToString().Trim()); //画布宽(字段类型:int,字段长度:4,是否可空:True)
 objdm_model_layoutEN.Status = objDT.Rows[0][condm_model_layout.Status].ToString().Trim(); //Status(字段类型:varchar,字段长度:20,是否可空:False)
 objdm_model_layoutEN.sort_no = TransNullToInt(objDT.Rows[0][condm_model_layout.sort_no].ToString().Trim()); //排序号(字段类型:int,字段长度:0,是否可空:True)
 objdm_model_layoutEN.created_by = objDT.Rows[0][condm_model_layout.created_by].ToString().Trim(); //创建人(字段类型:varchar,字段长度:50,是否可空:True)
 objdm_model_layoutEN.created_time = TransNullToDate(objDT.Rows[0][condm_model_layout.created_time].ToString().Trim()); //创建时间(字段类型:datetime,字段长度:0,是否可空:True)
 objdm_model_layoutEN.updated_by = objDT.Rows[0][condm_model_layout.updated_by].ToString().Trim(); //更新人(字段类型:varchar,字段长度:50,是否可空:True)
 objdm_model_layoutEN.updated_time = TransNullToDate(objDT.Rows[0][condm_model_layout.updated_time].ToString().Trim()); //更新时间(字段类型:datetime,字段长度:0,是否可空:True)
 objdm_model_layoutEN.remark = objDT.Rows[0][condm_model_layout.remark].ToString().Trim(); //备注(字段类型:varchar,字段长度:500,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsdm_model_layoutDA: Getdm_model_layout)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strmodel_id">表关键字</param>
 /// <returns>表对象</returns>
public clsdm_model_layoutEN GetObjBymodel_id(string strmodel_id)
{
CheckPrimaryKey(strmodel_id);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_layoutDA.GetSpecSQLObj();
strSQL = "Select * from dm_model_layout where model_id = " + "'"+ strmodel_id+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsdm_model_layoutEN objdm_model_layoutEN = new clsdm_model_layoutEN();
try
{
 objdm_model_layoutEN.model_id = objRow[condm_model_layout.model_id].ToString().Trim(); //模型ID(字段类型:varchar,字段长度:32,是否可空:False)
 objdm_model_layoutEN.model_name = objRow[condm_model_layout.model_name].ToString().Trim(); //模型名称(字段类型:varchar,字段长度:100,是否可空:False)
 objdm_model_layoutEN.prj_id = objRow[condm_model_layout.prj_id].ToString().Trim(); //项目ID(字段类型:varchar,字段长度:32,是否可空:False)
 objdm_model_layoutEN.model_desc = objRow[condm_model_layout.model_desc] == DBNull.Value ? null : objRow[condm_model_layout.model_desc].ToString().Trim(); //模型说明(字段类型:varchar,字段长度:500,是否可空:True)
 objdm_model_layoutEN.layout_data = objRow[condm_model_layout.layout_data] == DBNull.Value ? null : objRow[condm_model_layout.layout_data].ToString().Trim(); //布局数据(字段类型:varchar,字段长度:4000,是否可空:True)
 objdm_model_layoutEN.canvas_height = objRow[condm_model_layout.canvas_height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_layout.canvas_height].ToString().Trim()); //画布高(字段类型:int,字段长度:4,是否可空:True)
 objdm_model_layoutEN.canvas_width = objRow[condm_model_layout.canvas_width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_layout.canvas_width].ToString().Trim()); //画布宽(字段类型:int,字段长度:4,是否可空:True)
 objdm_model_layoutEN.Status = objRow[condm_model_layout.Status].ToString().Trim(); //Status(字段类型:varchar,字段长度:20,是否可空:False)
 objdm_model_layoutEN.sort_no = objRow[condm_model_layout.sort_no] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_layout.sort_no].ToString().Trim()); //排序号(字段类型:int,字段长度:0,是否可空:True)
 objdm_model_layoutEN.created_by = objRow[condm_model_layout.created_by] == DBNull.Value ? null : objRow[condm_model_layout.created_by].ToString().Trim(); //创建人(字段类型:varchar,字段长度:50,是否可空:True)
 objdm_model_layoutEN.created_time = clsEntityBase2.TransNullToDate_S(objRow[condm_model_layout.created_time].ToString().Trim()); //创建时间(字段类型:datetime,字段长度:0,是否可空:True)
 objdm_model_layoutEN.updated_by = objRow[condm_model_layout.updated_by] == DBNull.Value ? null : objRow[condm_model_layout.updated_by].ToString().Trim(); //更新人(字段类型:varchar,字段长度:50,是否可空:True)
 objdm_model_layoutEN.updated_time = clsEntityBase2.TransNullToDate_S(objRow[condm_model_layout.updated_time].ToString().Trim()); //更新时间(字段类型:datetime,字段长度:0,是否可空:True)
 objdm_model_layoutEN.remark = objRow[condm_model_layout.remark] == DBNull.Value ? null : objRow[condm_model_layout.remark].ToString().Trim(); //备注(字段类型:varchar,字段长度:500,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsdm_model_layoutDA: GetObjBymodel_id)", objException.Message));
}
return objdm_model_layoutEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsdm_model_layoutEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsdm_model_layoutDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_layoutDA.GetSpecSQLObj();
strSQL = "Select * from dm_model_layout where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsdm_model_layoutEN objdm_model_layoutEN = new clsdm_model_layoutEN()
{
model_id = objRow[condm_model_layout.model_id].ToString().Trim(), //模型ID
model_name = objRow[condm_model_layout.model_name].ToString().Trim(), //模型名称
prj_id = objRow[condm_model_layout.prj_id].ToString().Trim(), //项目ID
model_desc = objRow[condm_model_layout.model_desc] == DBNull.Value ? null : objRow[condm_model_layout.model_desc].ToString().Trim(), //模型说明
layout_data = objRow[condm_model_layout.layout_data] == DBNull.Value ? null : objRow[condm_model_layout.layout_data].ToString().Trim(), //布局数据
canvas_height = objRow[condm_model_layout.canvas_height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[condm_model_layout.canvas_height].ToString().Trim()), //画布高
canvas_width = objRow[condm_model_layout.canvas_width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[condm_model_layout.canvas_width].ToString().Trim()), //画布宽
Status = objRow[condm_model_layout.Status].ToString().Trim(), //Status
sort_no = objRow[condm_model_layout.sort_no] == DBNull.Value ? (int?)null : TransNullToInt(objRow[condm_model_layout.sort_no].ToString().Trim()), //排序号
created_by = objRow[condm_model_layout.created_by] == DBNull.Value ? null : objRow[condm_model_layout.created_by].ToString().Trim(), //创建人
created_time = TransNullToDate(objRow[condm_model_layout.created_time].ToString().Trim()), //创建时间
updated_by = objRow[condm_model_layout.updated_by] == DBNull.Value ? null : objRow[condm_model_layout.updated_by].ToString().Trim(), //更新人
updated_time = TransNullToDate(objRow[condm_model_layout.updated_time].ToString().Trim()), //更新时间
remark = objRow[condm_model_layout.remark] == DBNull.Value ? null : objRow[condm_model_layout.remark].ToString().Trim() //备注
};
objdm_model_layoutEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objdm_model_layoutEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsdm_model_layoutDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsdm_model_layoutEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsdm_model_layoutEN objdm_model_layoutEN = new clsdm_model_layoutEN();
try
{
objdm_model_layoutEN.model_id = objRow[condm_model_layout.model_id].ToString().Trim(); //模型ID
objdm_model_layoutEN.model_name = objRow[condm_model_layout.model_name].ToString().Trim(); //模型名称
objdm_model_layoutEN.prj_id = objRow[condm_model_layout.prj_id].ToString().Trim(); //项目ID
objdm_model_layoutEN.model_desc = objRow[condm_model_layout.model_desc] == DBNull.Value ? null : objRow[condm_model_layout.model_desc].ToString().Trim(); //模型说明
objdm_model_layoutEN.layout_data = objRow[condm_model_layout.layout_data] == DBNull.Value ? null : objRow[condm_model_layout.layout_data].ToString().Trim(); //布局数据
objdm_model_layoutEN.canvas_height = objRow[condm_model_layout.canvas_height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[condm_model_layout.canvas_height].ToString().Trim()); //画布高
objdm_model_layoutEN.canvas_width = objRow[condm_model_layout.canvas_width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[condm_model_layout.canvas_width].ToString().Trim()); //画布宽
objdm_model_layoutEN.Status = objRow[condm_model_layout.Status].ToString().Trim(); //Status
objdm_model_layoutEN.sort_no = objRow[condm_model_layout.sort_no] == DBNull.Value ? (int?)null : TransNullToInt(objRow[condm_model_layout.sort_no].ToString().Trim()); //排序号
objdm_model_layoutEN.created_by = objRow[condm_model_layout.created_by] == DBNull.Value ? null : objRow[condm_model_layout.created_by].ToString().Trim(); //创建人
objdm_model_layoutEN.created_time = TransNullToDate(objRow[condm_model_layout.created_time].ToString().Trim()); //创建时间
objdm_model_layoutEN.updated_by = objRow[condm_model_layout.updated_by] == DBNull.Value ? null : objRow[condm_model_layout.updated_by].ToString().Trim(); //更新人
objdm_model_layoutEN.updated_time = TransNullToDate(objRow[condm_model_layout.updated_time].ToString().Trim()); //更新时间
objdm_model_layoutEN.remark = objRow[condm_model_layout.remark] == DBNull.Value ? null : objRow[condm_model_layout.remark].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsdm_model_layoutDA: GetObjByDataRowdm_model_layout)", objException.Message));
}
objdm_model_layoutEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objdm_model_layoutEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsdm_model_layoutEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsdm_model_layoutEN objdm_model_layoutEN = new clsdm_model_layoutEN();
try
{
objdm_model_layoutEN.model_id = objRow[condm_model_layout.model_id].ToString().Trim(); //模型ID
objdm_model_layoutEN.model_name = objRow[condm_model_layout.model_name].ToString().Trim(); //模型名称
objdm_model_layoutEN.prj_id = objRow[condm_model_layout.prj_id].ToString().Trim(); //项目ID
objdm_model_layoutEN.model_desc = objRow[condm_model_layout.model_desc] == DBNull.Value ? null : objRow[condm_model_layout.model_desc].ToString().Trim(); //模型说明
objdm_model_layoutEN.layout_data = objRow[condm_model_layout.layout_data] == DBNull.Value ? null : objRow[condm_model_layout.layout_data].ToString().Trim(); //布局数据
objdm_model_layoutEN.canvas_height = objRow[condm_model_layout.canvas_height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[condm_model_layout.canvas_height].ToString().Trim()); //画布高
objdm_model_layoutEN.canvas_width = objRow[condm_model_layout.canvas_width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[condm_model_layout.canvas_width].ToString().Trim()); //画布宽
objdm_model_layoutEN.Status = objRow[condm_model_layout.Status].ToString().Trim(); //Status
objdm_model_layoutEN.sort_no = objRow[condm_model_layout.sort_no] == DBNull.Value ? (int?)null : TransNullToInt(objRow[condm_model_layout.sort_no].ToString().Trim()); //排序号
objdm_model_layoutEN.created_by = objRow[condm_model_layout.created_by] == DBNull.Value ? null : objRow[condm_model_layout.created_by].ToString().Trim(); //创建人
objdm_model_layoutEN.created_time = TransNullToDate(objRow[condm_model_layout.created_time].ToString().Trim()); //创建时间
objdm_model_layoutEN.updated_by = objRow[condm_model_layout.updated_by] == DBNull.Value ? null : objRow[condm_model_layout.updated_by].ToString().Trim(); //更新人
objdm_model_layoutEN.updated_time = TransNullToDate(objRow[condm_model_layout.updated_time].ToString().Trim()); //更新时间
objdm_model_layoutEN.remark = objRow[condm_model_layout.remark] == DBNull.Value ? null : objRow[condm_model_layout.remark].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsdm_model_layoutDA: GetObjByDataRow)", objException.Message));
}
objdm_model_layoutEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objdm_model_layoutEN;
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
objSQL = clsdm_model_layoutDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsdm_model_layoutEN._CurrTabName, condm_model_layout.model_id, 32, "");
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
objSQL = clsdm_model_layoutDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsdm_model_layoutEN._CurrTabName, condm_model_layout.model_id, 32, strPrefix);
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
 objSQL = clsdm_model_layoutDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select model_id from dm_model_layout where " + strCondition;
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
 objSQL = clsdm_model_layoutDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select model_id from dm_model_layout where " + strCondition;
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
 /// <param name = "strmodel_id">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strmodel_id)
{
CheckPrimaryKey(strmodel_id);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_layoutDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("dm_model_layout", "model_id = " + "'"+ strmodel_id+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsdm_model_layoutDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_layoutDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("dm_model_layout", strCondition))
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
objSQL = clsdm_model_layoutDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("dm_model_layout");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsdm_model_layoutEN objdm_model_layoutEN)
 {
 if (objdm_model_layoutEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objdm_model_layoutEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_layoutDA.GetSpecSQLObj();
strSQL = "Select * from dm_model_layout where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "dm_model_layout");
objRow = objDS.Tables["dm_model_layout"].NewRow();
objRow[condm_model_layout.model_id] = objdm_model_layoutEN.model_id; //模型ID
objRow[condm_model_layout.model_name] = objdm_model_layoutEN.model_name; //模型名称
objRow[condm_model_layout.prj_id] = objdm_model_layoutEN.prj_id; //项目ID
 if (objdm_model_layoutEN.model_desc !=  "")
 {
objRow[condm_model_layout.model_desc] = objdm_model_layoutEN.model_desc; //模型说明
 }
 if (objdm_model_layoutEN.layout_data !=  "")
 {
objRow[condm_model_layout.layout_data] = objdm_model_layoutEN.layout_data; //布局数据
 }
objRow[condm_model_layout.canvas_height] = objdm_model_layoutEN.canvas_height; //画布高
objRow[condm_model_layout.canvas_width] = objdm_model_layoutEN.canvas_width; //画布宽
objRow[condm_model_layout.Status] = objdm_model_layoutEN.Status; //Status
objRow[condm_model_layout.sort_no] = objdm_model_layoutEN.sort_no; //排序号
 if (objdm_model_layoutEN.created_by !=  "")
 {
objRow[condm_model_layout.created_by] = objdm_model_layoutEN.created_by; //创建人
 }
objRow[condm_model_layout.created_time] = objdm_model_layoutEN.created_time; //创建时间
 if (objdm_model_layoutEN.updated_by !=  "")
 {
objRow[condm_model_layout.updated_by] = objdm_model_layoutEN.updated_by; //更新人
 }
objRow[condm_model_layout.updated_time] = objdm_model_layoutEN.updated_time; //更新时间
 if (objdm_model_layoutEN.remark !=  "")
 {
objRow[condm_model_layout.remark] = objdm_model_layoutEN.remark; //备注
 }
objDS.Tables[clsdm_model_layoutEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsdm_model_layoutEN._CurrTabName);
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
 /// <param name = "objdm_model_layoutEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsdm_model_layoutEN objdm_model_layoutEN)
{
 if (objdm_model_layoutEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objdm_model_layoutEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objdm_model_layoutEN.model_id !=  null)
 {
 arrFieldListForInsert.Add(condm_model_layout.model_id);
 var strmodel_id = objdm_model_layoutEN.model_id.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strmodel_id + "'");
 }
 
 if (objdm_model_layoutEN.model_name !=  null)
 {
 arrFieldListForInsert.Add(condm_model_layout.model_name);
 var strmodel_name = objdm_model_layoutEN.model_name.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strmodel_name + "'");
 }
 
 if (objdm_model_layoutEN.prj_id !=  null)
 {
 arrFieldListForInsert.Add(condm_model_layout.prj_id);
 var strprj_id = objdm_model_layoutEN.prj_id.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strprj_id + "'");
 }
 
 if (objdm_model_layoutEN.model_desc !=  null)
 {
 arrFieldListForInsert.Add(condm_model_layout.model_desc);
 var strmodel_desc = objdm_model_layoutEN.model_desc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strmodel_desc + "'");
 }
 
 if (objdm_model_layoutEN.layout_data !=  null)
 {
 arrFieldListForInsert.Add(condm_model_layout.layout_data);
 var strlayout_data = objdm_model_layoutEN.layout_data.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strlayout_data + "'");
 }
 
 if (objdm_model_layoutEN.canvas_height !=  null)
 {
 arrFieldListForInsert.Add(condm_model_layout.canvas_height);
 arrValueListForInsert.Add(objdm_model_layoutEN.canvas_height.ToString());
 }
 
 if (objdm_model_layoutEN.canvas_width !=  null)
 {
 arrFieldListForInsert.Add(condm_model_layout.canvas_width);
 arrValueListForInsert.Add(objdm_model_layoutEN.canvas_width.ToString());
 }
 
 if (objdm_model_layoutEN.Status !=  null)
 {
 arrFieldListForInsert.Add(condm_model_layout.Status);
 var strStatus = objdm_model_layoutEN.Status.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStatus + "'");
 }
 
 if (objdm_model_layoutEN.sort_no !=  null)
 {
 arrFieldListForInsert.Add(condm_model_layout.sort_no);
 arrValueListForInsert.Add(objdm_model_layoutEN.sort_no.ToString());
 }
 
 if (objdm_model_layoutEN.created_by !=  null)
 {
 arrFieldListForInsert.Add(condm_model_layout.created_by);
 var strcreated_by = objdm_model_layoutEN.created_by.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strcreated_by + "'");
 }
 
 arrFieldListForInsert.Add(condm_model_layout.created_time);
 var dtecreated_time = objdm_model_layoutEN.created_time;
 arrValueListForInsert.Add("'" + dtecreated_time + "'");
 
 if (objdm_model_layoutEN.updated_by !=  null)
 {
 arrFieldListForInsert.Add(condm_model_layout.updated_by);
 var strupdated_by = objdm_model_layoutEN.updated_by.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strupdated_by + "'");
 }
 
 arrFieldListForInsert.Add(condm_model_layout.updated_time);
 var dteupdated_time = objdm_model_layoutEN.updated_time;
 arrValueListForInsert.Add("'" + dteupdated_time + "'");
 
 if (objdm_model_layoutEN.remark !=  null)
 {
 arrFieldListForInsert.Add(condm_model_layout.remark);
 var strremark = objdm_model_layoutEN.remark.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strremark + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into dm_model_layout");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_layoutDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objdm_model_layoutEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsdm_model_layoutEN objdm_model_layoutEN)
{
 if (objdm_model_layoutEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objdm_model_layoutEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objdm_model_layoutEN.model_id !=  null)
 {
 arrFieldListForInsert.Add(condm_model_layout.model_id);
 var strmodel_id = objdm_model_layoutEN.model_id.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strmodel_id + "'");
 }
 
 if (objdm_model_layoutEN.model_name !=  null)
 {
 arrFieldListForInsert.Add(condm_model_layout.model_name);
 var strmodel_name = objdm_model_layoutEN.model_name.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strmodel_name + "'");
 }
 
 if (objdm_model_layoutEN.prj_id !=  null)
 {
 arrFieldListForInsert.Add(condm_model_layout.prj_id);
 var strprj_id = objdm_model_layoutEN.prj_id.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strprj_id + "'");
 }
 
 if (objdm_model_layoutEN.model_desc !=  null)
 {
 arrFieldListForInsert.Add(condm_model_layout.model_desc);
 var strmodel_desc = objdm_model_layoutEN.model_desc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strmodel_desc + "'");
 }
 
 if (objdm_model_layoutEN.layout_data !=  null)
 {
 arrFieldListForInsert.Add(condm_model_layout.layout_data);
 var strlayout_data = objdm_model_layoutEN.layout_data.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strlayout_data + "'");
 }
 
 if (objdm_model_layoutEN.canvas_height !=  null)
 {
 arrFieldListForInsert.Add(condm_model_layout.canvas_height);
 arrValueListForInsert.Add(objdm_model_layoutEN.canvas_height.ToString());
 }
 
 if (objdm_model_layoutEN.canvas_width !=  null)
 {
 arrFieldListForInsert.Add(condm_model_layout.canvas_width);
 arrValueListForInsert.Add(objdm_model_layoutEN.canvas_width.ToString());
 }
 
 if (objdm_model_layoutEN.Status !=  null)
 {
 arrFieldListForInsert.Add(condm_model_layout.Status);
 var strStatus = objdm_model_layoutEN.Status.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStatus + "'");
 }
 
 if (objdm_model_layoutEN.sort_no !=  null)
 {
 arrFieldListForInsert.Add(condm_model_layout.sort_no);
 arrValueListForInsert.Add(objdm_model_layoutEN.sort_no.ToString());
 }
 
 if (objdm_model_layoutEN.created_by !=  null)
 {
 arrFieldListForInsert.Add(condm_model_layout.created_by);
 var strcreated_by = objdm_model_layoutEN.created_by.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strcreated_by + "'");
 }
 
 arrFieldListForInsert.Add(condm_model_layout.created_time);
 var dtecreated_time = objdm_model_layoutEN.created_time;
 arrValueListForInsert.Add("'" + dtecreated_time + "'");
 
 if (objdm_model_layoutEN.updated_by !=  null)
 {
 arrFieldListForInsert.Add(condm_model_layout.updated_by);
 var strupdated_by = objdm_model_layoutEN.updated_by.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strupdated_by + "'");
 }
 
 arrFieldListForInsert.Add(condm_model_layout.updated_time);
 var dteupdated_time = objdm_model_layoutEN.updated_time;
 arrValueListForInsert.Add("'" + dteupdated_time + "'");
 
 if (objdm_model_layoutEN.remark !=  null)
 {
 arrFieldListForInsert.Add(condm_model_layout.remark);
 var strremark = objdm_model_layoutEN.remark.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strremark + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into dm_model_layout");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_layoutDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objdm_model_layoutEN.model_id;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objdm_model_layoutEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsdm_model_layoutEN objdm_model_layoutEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objdm_model_layoutEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objdm_model_layoutEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objdm_model_layoutEN.model_id !=  null)
 {
 arrFieldListForInsert.Add(condm_model_layout.model_id);
 var strmodel_id = objdm_model_layoutEN.model_id.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strmodel_id + "'");
 }
 
 if (objdm_model_layoutEN.model_name !=  null)
 {
 arrFieldListForInsert.Add(condm_model_layout.model_name);
 var strmodel_name = objdm_model_layoutEN.model_name.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strmodel_name + "'");
 }
 
 if (objdm_model_layoutEN.prj_id !=  null)
 {
 arrFieldListForInsert.Add(condm_model_layout.prj_id);
 var strprj_id = objdm_model_layoutEN.prj_id.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strprj_id + "'");
 }
 
 if (objdm_model_layoutEN.model_desc !=  null)
 {
 arrFieldListForInsert.Add(condm_model_layout.model_desc);
 var strmodel_desc = objdm_model_layoutEN.model_desc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strmodel_desc + "'");
 }
 
 if (objdm_model_layoutEN.layout_data !=  null)
 {
 arrFieldListForInsert.Add(condm_model_layout.layout_data);
 var strlayout_data = objdm_model_layoutEN.layout_data.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strlayout_data + "'");
 }
 
 if (objdm_model_layoutEN.canvas_height !=  null)
 {
 arrFieldListForInsert.Add(condm_model_layout.canvas_height);
 arrValueListForInsert.Add(objdm_model_layoutEN.canvas_height.ToString());
 }
 
 if (objdm_model_layoutEN.canvas_width !=  null)
 {
 arrFieldListForInsert.Add(condm_model_layout.canvas_width);
 arrValueListForInsert.Add(objdm_model_layoutEN.canvas_width.ToString());
 }
 
 if (objdm_model_layoutEN.Status !=  null)
 {
 arrFieldListForInsert.Add(condm_model_layout.Status);
 var strStatus = objdm_model_layoutEN.Status.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStatus + "'");
 }
 
 if (objdm_model_layoutEN.sort_no !=  null)
 {
 arrFieldListForInsert.Add(condm_model_layout.sort_no);
 arrValueListForInsert.Add(objdm_model_layoutEN.sort_no.ToString());
 }
 
 if (objdm_model_layoutEN.created_by !=  null)
 {
 arrFieldListForInsert.Add(condm_model_layout.created_by);
 var strcreated_by = objdm_model_layoutEN.created_by.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strcreated_by + "'");
 }
 
 arrFieldListForInsert.Add(condm_model_layout.created_time);
 var dtecreated_time = objdm_model_layoutEN.created_time;
 arrValueListForInsert.Add("'" + dtecreated_time + "'");
 
 if (objdm_model_layoutEN.updated_by !=  null)
 {
 arrFieldListForInsert.Add(condm_model_layout.updated_by);
 var strupdated_by = objdm_model_layoutEN.updated_by.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strupdated_by + "'");
 }
 
 arrFieldListForInsert.Add(condm_model_layout.updated_time);
 var dteupdated_time = objdm_model_layoutEN.updated_time;
 arrValueListForInsert.Add("'" + dteupdated_time + "'");
 
 if (objdm_model_layoutEN.remark !=  null)
 {
 arrFieldListForInsert.Add(condm_model_layout.remark);
 var strremark = objdm_model_layoutEN.remark.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strremark + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into dm_model_layout");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_layoutDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objdm_model_layoutEN.model_id;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objdm_model_layoutEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsdm_model_layoutEN objdm_model_layoutEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objdm_model_layoutEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objdm_model_layoutEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objdm_model_layoutEN.model_id !=  null)
 {
 arrFieldListForInsert.Add(condm_model_layout.model_id);
 var strmodel_id = objdm_model_layoutEN.model_id.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strmodel_id + "'");
 }
 
 if (objdm_model_layoutEN.model_name !=  null)
 {
 arrFieldListForInsert.Add(condm_model_layout.model_name);
 var strmodel_name = objdm_model_layoutEN.model_name.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strmodel_name + "'");
 }
 
 if (objdm_model_layoutEN.prj_id !=  null)
 {
 arrFieldListForInsert.Add(condm_model_layout.prj_id);
 var strprj_id = objdm_model_layoutEN.prj_id.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strprj_id + "'");
 }
 
 if (objdm_model_layoutEN.model_desc !=  null)
 {
 arrFieldListForInsert.Add(condm_model_layout.model_desc);
 var strmodel_desc = objdm_model_layoutEN.model_desc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strmodel_desc + "'");
 }
 
 if (objdm_model_layoutEN.layout_data !=  null)
 {
 arrFieldListForInsert.Add(condm_model_layout.layout_data);
 var strlayout_data = objdm_model_layoutEN.layout_data.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strlayout_data + "'");
 }
 
 if (objdm_model_layoutEN.canvas_height !=  null)
 {
 arrFieldListForInsert.Add(condm_model_layout.canvas_height);
 arrValueListForInsert.Add(objdm_model_layoutEN.canvas_height.ToString());
 }
 
 if (objdm_model_layoutEN.canvas_width !=  null)
 {
 arrFieldListForInsert.Add(condm_model_layout.canvas_width);
 arrValueListForInsert.Add(objdm_model_layoutEN.canvas_width.ToString());
 }
 
 if (objdm_model_layoutEN.Status !=  null)
 {
 arrFieldListForInsert.Add(condm_model_layout.Status);
 var strStatus = objdm_model_layoutEN.Status.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStatus + "'");
 }
 
 if (objdm_model_layoutEN.sort_no !=  null)
 {
 arrFieldListForInsert.Add(condm_model_layout.sort_no);
 arrValueListForInsert.Add(objdm_model_layoutEN.sort_no.ToString());
 }
 
 if (objdm_model_layoutEN.created_by !=  null)
 {
 arrFieldListForInsert.Add(condm_model_layout.created_by);
 var strcreated_by = objdm_model_layoutEN.created_by.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strcreated_by + "'");
 }
 
 arrFieldListForInsert.Add(condm_model_layout.created_time);
 var dtecreated_time = objdm_model_layoutEN.created_time;
 arrValueListForInsert.Add("'" + dtecreated_time + "'");
 
 if (objdm_model_layoutEN.updated_by !=  null)
 {
 arrFieldListForInsert.Add(condm_model_layout.updated_by);
 var strupdated_by = objdm_model_layoutEN.updated_by.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strupdated_by + "'");
 }
 
 arrFieldListForInsert.Add(condm_model_layout.updated_time);
 var dteupdated_time = objdm_model_layoutEN.updated_time;
 arrValueListForInsert.Add("'" + dteupdated_time + "'");
 
 if (objdm_model_layoutEN.remark !=  null)
 {
 arrFieldListForInsert.Add(condm_model_layout.remark);
 var strremark = objdm_model_layoutEN.remark.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strremark + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into dm_model_layout");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_layoutDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewdm_model_layouts(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_layoutDA.GetSpecSQLObj();
strSQL = "Select * from dm_model_layout where model_id = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "dm_model_layout");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strmodel_id = oRow[condm_model_layout.model_id].ToString().Trim();
if (IsExist(strmodel_id))
{
 string strResult = "关键字变量值为:" + string.Format("model_id = {0}", strmodel_id) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsdm_model_layoutEN._CurrTabName ].NewRow();
objRow[condm_model_layout.model_id] = oRow[condm_model_layout.model_id].ToString().Trim(); //模型ID
objRow[condm_model_layout.model_name] = oRow[condm_model_layout.model_name].ToString().Trim(); //模型名称
objRow[condm_model_layout.prj_id] = oRow[condm_model_layout.prj_id].ToString().Trim(); //项目ID
objRow[condm_model_layout.model_desc] = oRow[condm_model_layout.model_desc].ToString().Trim(); //模型说明
objRow[condm_model_layout.layout_data] = oRow[condm_model_layout.layout_data].ToString().Trim(); //布局数据
objRow[condm_model_layout.canvas_height] = oRow[condm_model_layout.canvas_height].ToString().Trim(); //画布高
objRow[condm_model_layout.canvas_width] = oRow[condm_model_layout.canvas_width].ToString().Trim(); //画布宽
objRow[condm_model_layout.Status] = oRow[condm_model_layout.Status].ToString().Trim(); //Status
objRow[condm_model_layout.sort_no] = oRow[condm_model_layout.sort_no].ToString().Trim(); //排序号
objRow[condm_model_layout.created_by] = oRow[condm_model_layout.created_by].ToString().Trim(); //创建人
objRow[condm_model_layout.created_time] = oRow[condm_model_layout.created_time].ToString().Trim(); //创建时间
objRow[condm_model_layout.updated_by] = oRow[condm_model_layout.updated_by].ToString().Trim(); //更新人
objRow[condm_model_layout.updated_time] = oRow[condm_model_layout.updated_time].ToString().Trim(); //更新时间
objRow[condm_model_layout.remark] = oRow[condm_model_layout.remark].ToString().Trim(); //备注
 objDS.Tables[clsdm_model_layoutEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsdm_model_layoutEN._CurrTabName);
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
 /// <param name = "objdm_model_layoutEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsdm_model_layoutEN objdm_model_layoutEN)
{
 if (objdm_model_layoutEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objdm_model_layoutEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_layoutDA.GetSpecSQLObj();
strSQL = "Select * from dm_model_layout where model_id = " + "'"+ objdm_model_layoutEN.model_id+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsdm_model_layoutEN._CurrTabName);
if (objDS.Tables[clsdm_model_layoutEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:model_id = " + "'"+ objdm_model_layoutEN.model_id+"'");
return false;
}
objRow = objDS.Tables[clsdm_model_layoutEN._CurrTabName].Rows[0];
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.model_id))
 {
objRow[condm_model_layout.model_id] = objdm_model_layoutEN.model_id; //模型ID
 }
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.model_name))
 {
objRow[condm_model_layout.model_name] = objdm_model_layoutEN.model_name; //模型名称
 }
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.prj_id))
 {
objRow[condm_model_layout.prj_id] = objdm_model_layoutEN.prj_id; //项目ID
 }
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.model_desc))
 {
objRow[condm_model_layout.model_desc] = objdm_model_layoutEN.model_desc; //模型说明
 }
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.layout_data))
 {
objRow[condm_model_layout.layout_data] = objdm_model_layoutEN.layout_data; //布局数据
 }
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.canvas_height))
 {
objRow[condm_model_layout.canvas_height] = objdm_model_layoutEN.canvas_height; //画布高
 }
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.canvas_width))
 {
objRow[condm_model_layout.canvas_width] = objdm_model_layoutEN.canvas_width; //画布宽
 }
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.Status))
 {
objRow[condm_model_layout.Status] = objdm_model_layoutEN.Status; //Status
 }
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.sort_no))
 {
objRow[condm_model_layout.sort_no] = objdm_model_layoutEN.sort_no; //排序号
 }
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.created_by))
 {
objRow[condm_model_layout.created_by] = objdm_model_layoutEN.created_by; //创建人
 }
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.created_time))
 {
objRow[condm_model_layout.created_time] = objdm_model_layoutEN.created_time; //创建时间
 }
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.updated_by))
 {
objRow[condm_model_layout.updated_by] = objdm_model_layoutEN.updated_by; //更新人
 }
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.updated_time))
 {
objRow[condm_model_layout.updated_time] = objdm_model_layoutEN.updated_time; //更新时间
 }
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.remark))
 {
objRow[condm_model_layout.remark] = objdm_model_layoutEN.remark; //备注
 }
try
{
objDA.Update(objDS, clsdm_model_layoutEN._CurrTabName);
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
 /// <param name = "objdm_model_layoutEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsdm_model_layoutEN objdm_model_layoutEN)
{
 if (objdm_model_layoutEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objdm_model_layoutEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_layoutDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update dm_model_layout Set ");
 
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.model_name))
 {
 if (objdm_model_layoutEN.model_name !=  null)
 {
 var strmodel_name = objdm_model_layoutEN.model_name.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strmodel_name, condm_model_layout.model_name); //模型名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",condm_model_layout.model_name); //模型名称
 }
 }
 
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.prj_id))
 {
 if (objdm_model_layoutEN.prj_id !=  null)
 {
 var strprj_id = objdm_model_layoutEN.prj_id.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strprj_id, condm_model_layout.prj_id); //项目ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",condm_model_layout.prj_id); //项目ID
 }
 }
 
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.model_desc))
 {
 if (objdm_model_layoutEN.model_desc !=  null)
 {
 var strmodel_desc = objdm_model_layoutEN.model_desc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strmodel_desc, condm_model_layout.model_desc); //模型说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",condm_model_layout.model_desc); //模型说明
 }
 }
 
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.layout_data))
 {
 if (objdm_model_layoutEN.layout_data !=  null)
 {
 var strlayout_data = objdm_model_layoutEN.layout_data.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strlayout_data, condm_model_layout.layout_data); //布局数据
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",condm_model_layout.layout_data); //布局数据
 }
 }
 
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.canvas_height))
 {
 if (objdm_model_layoutEN.canvas_height !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objdm_model_layoutEN.canvas_height, condm_model_layout.canvas_height); //画布高
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",condm_model_layout.canvas_height); //画布高
 }
 }
 
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.canvas_width))
 {
 if (objdm_model_layoutEN.canvas_width !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objdm_model_layoutEN.canvas_width, condm_model_layout.canvas_width); //画布宽
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",condm_model_layout.canvas_width); //画布宽
 }
 }
 
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.Status))
 {
 if (objdm_model_layoutEN.Status !=  null)
 {
 var strStatus = objdm_model_layoutEN.Status.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStatus, condm_model_layout.Status); //Status
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",condm_model_layout.Status); //Status
 }
 }
 
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.sort_no))
 {
 if (objdm_model_layoutEN.sort_no !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objdm_model_layoutEN.sort_no, condm_model_layout.sort_no); //排序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",condm_model_layout.sort_no); //排序号
 }
 }
 
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.created_by))
 {
 if (objdm_model_layoutEN.created_by !=  null)
 {
 var strcreated_by = objdm_model_layoutEN.created_by.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strcreated_by, condm_model_layout.created_by); //创建人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",condm_model_layout.created_by); //创建人
 }
 }
 
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.created_time))
 {
 if (objdm_model_layoutEN.created_time !=  null)
 {
 var dtecreated_time = objdm_model_layoutEN.created_time;
 sbSQL.AppendFormat("{1} = '{0}',", dtecreated_time, condm_model_layout.created_time); //创建时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",condm_model_layout.created_time); //创建时间
 }
 }
 
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.updated_by))
 {
 if (objdm_model_layoutEN.updated_by !=  null)
 {
 var strupdated_by = objdm_model_layoutEN.updated_by.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strupdated_by, condm_model_layout.updated_by); //更新人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",condm_model_layout.updated_by); //更新人
 }
 }
 
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.updated_time))
 {
 if (objdm_model_layoutEN.updated_time !=  null)
 {
 var dteupdated_time = objdm_model_layoutEN.updated_time;
 sbSQL.AppendFormat("{1} = '{0}',", dteupdated_time, condm_model_layout.updated_time); //更新时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",condm_model_layout.updated_time); //更新时间
 }
 }
 
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.remark))
 {
 if (objdm_model_layoutEN.remark !=  null)
 {
 var strremark = objdm_model_layoutEN.remark.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strremark, condm_model_layout.remark); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",condm_model_layout.remark); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where model_id = '{0}'", objdm_model_layoutEN.model_id); 
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
 /// <param name = "objdm_model_layoutEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsdm_model_layoutEN objdm_model_layoutEN, string strCondition)
{
 if (objdm_model_layoutEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objdm_model_layoutEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_layoutDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update dm_model_layout Set ");
 
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.model_name))
 {
 if (objdm_model_layoutEN.model_name !=  null)
 {
 var strmodel_name = objdm_model_layoutEN.model_name.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" model_name = '{0}',", strmodel_name); //模型名称
 }
 else
 {
 sbSQL.Append(" model_name = null,"); //模型名称
 }
 }
 
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.prj_id))
 {
 if (objdm_model_layoutEN.prj_id !=  null)
 {
 var strprj_id = objdm_model_layoutEN.prj_id.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" prj_id = '{0}',", strprj_id); //项目ID
 }
 else
 {
 sbSQL.Append(" prj_id = null,"); //项目ID
 }
 }
 
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.model_desc))
 {
 if (objdm_model_layoutEN.model_desc !=  null)
 {
 var strmodel_desc = objdm_model_layoutEN.model_desc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" model_desc = '{0}',", strmodel_desc); //模型说明
 }
 else
 {
 sbSQL.Append(" model_desc = null,"); //模型说明
 }
 }
 
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.layout_data))
 {
 if (objdm_model_layoutEN.layout_data !=  null)
 {
 var strlayout_data = objdm_model_layoutEN.layout_data.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" layout_data = '{0}',", strlayout_data); //布局数据
 }
 else
 {
 sbSQL.Append(" layout_data = null,"); //布局数据
 }
 }
 
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.canvas_height))
 {
 if (objdm_model_layoutEN.canvas_height !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objdm_model_layoutEN.canvas_height, condm_model_layout.canvas_height); //画布高
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",condm_model_layout.canvas_height); //画布高
 }
 }
 
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.canvas_width))
 {
 if (objdm_model_layoutEN.canvas_width !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objdm_model_layoutEN.canvas_width, condm_model_layout.canvas_width); //画布宽
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",condm_model_layout.canvas_width); //画布宽
 }
 }
 
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.Status))
 {
 if (objdm_model_layoutEN.Status !=  null)
 {
 var strStatus = objdm_model_layoutEN.Status.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Status = '{0}',", strStatus); //Status
 }
 else
 {
 sbSQL.Append(" Status = null,"); //Status
 }
 }
 
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.sort_no))
 {
 if (objdm_model_layoutEN.sort_no !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objdm_model_layoutEN.sort_no, condm_model_layout.sort_no); //排序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",condm_model_layout.sort_no); //排序号
 }
 }
 
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.created_by))
 {
 if (objdm_model_layoutEN.created_by !=  null)
 {
 var strcreated_by = objdm_model_layoutEN.created_by.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" created_by = '{0}',", strcreated_by); //创建人
 }
 else
 {
 sbSQL.Append(" created_by = null,"); //创建人
 }
 }
 
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.created_time))
 {
 if (objdm_model_layoutEN.created_time !=  null)
 {
 var dtecreated_time = objdm_model_layoutEN.created_time;
 sbSQL.AppendFormat(" created_time = '{0}',", dtecreated_time); //创建时间
 }
 else
 {
 sbSQL.Append(" created_time = null,"); //创建时间
 }
 }
 
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.updated_by))
 {
 if (objdm_model_layoutEN.updated_by !=  null)
 {
 var strupdated_by = objdm_model_layoutEN.updated_by.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" updated_by = '{0}',", strupdated_by); //更新人
 }
 else
 {
 sbSQL.Append(" updated_by = null,"); //更新人
 }
 }
 
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.updated_time))
 {
 if (objdm_model_layoutEN.updated_time !=  null)
 {
 var dteupdated_time = objdm_model_layoutEN.updated_time;
 sbSQL.AppendFormat(" updated_time = '{0}',", dteupdated_time); //更新时间
 }
 else
 {
 sbSQL.Append(" updated_time = null,"); //更新时间
 }
 }
 
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.remark))
 {
 if (objdm_model_layoutEN.remark !=  null)
 {
 var strremark = objdm_model_layoutEN.remark.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objdm_model_layoutEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsdm_model_layoutEN objdm_model_layoutEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objdm_model_layoutEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objdm_model_layoutEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_layoutDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update dm_model_layout Set ");
 
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.model_name))
 {
 if (objdm_model_layoutEN.model_name !=  null)
 {
 var strmodel_name = objdm_model_layoutEN.model_name.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" model_name = '{0}',", strmodel_name); //模型名称
 }
 else
 {
 sbSQL.Append(" model_name = null,"); //模型名称
 }
 }
 
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.prj_id))
 {
 if (objdm_model_layoutEN.prj_id !=  null)
 {
 var strprj_id = objdm_model_layoutEN.prj_id.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" prj_id = '{0}',", strprj_id); //项目ID
 }
 else
 {
 sbSQL.Append(" prj_id = null,"); //项目ID
 }
 }
 
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.model_desc))
 {
 if (objdm_model_layoutEN.model_desc !=  null)
 {
 var strmodel_desc = objdm_model_layoutEN.model_desc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" model_desc = '{0}',", strmodel_desc); //模型说明
 }
 else
 {
 sbSQL.Append(" model_desc = null,"); //模型说明
 }
 }
 
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.layout_data))
 {
 if (objdm_model_layoutEN.layout_data !=  null)
 {
 var strlayout_data = objdm_model_layoutEN.layout_data.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" layout_data = '{0}',", strlayout_data); //布局数据
 }
 else
 {
 sbSQL.Append(" layout_data = null,"); //布局数据
 }
 }
 
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.canvas_height))
 {
 if (objdm_model_layoutEN.canvas_height !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objdm_model_layoutEN.canvas_height, condm_model_layout.canvas_height); //画布高
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",condm_model_layout.canvas_height); //画布高
 }
 }
 
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.canvas_width))
 {
 if (objdm_model_layoutEN.canvas_width !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objdm_model_layoutEN.canvas_width, condm_model_layout.canvas_width); //画布宽
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",condm_model_layout.canvas_width); //画布宽
 }
 }
 
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.Status))
 {
 if (objdm_model_layoutEN.Status !=  null)
 {
 var strStatus = objdm_model_layoutEN.Status.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Status = '{0}',", strStatus); //Status
 }
 else
 {
 sbSQL.Append(" Status = null,"); //Status
 }
 }
 
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.sort_no))
 {
 if (objdm_model_layoutEN.sort_no !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objdm_model_layoutEN.sort_no, condm_model_layout.sort_no); //排序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",condm_model_layout.sort_no); //排序号
 }
 }
 
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.created_by))
 {
 if (objdm_model_layoutEN.created_by !=  null)
 {
 var strcreated_by = objdm_model_layoutEN.created_by.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" created_by = '{0}',", strcreated_by); //创建人
 }
 else
 {
 sbSQL.Append(" created_by = null,"); //创建人
 }
 }
 
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.created_time))
 {
 if (objdm_model_layoutEN.created_time !=  null)
 {
 var dtecreated_time = objdm_model_layoutEN.created_time;
 sbSQL.AppendFormat(" created_time = '{0}',", dtecreated_time); //创建时间
 }
 else
 {
 sbSQL.Append(" created_time = null,"); //创建时间
 }
 }
 
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.updated_by))
 {
 if (objdm_model_layoutEN.updated_by !=  null)
 {
 var strupdated_by = objdm_model_layoutEN.updated_by.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" updated_by = '{0}',", strupdated_by); //更新人
 }
 else
 {
 sbSQL.Append(" updated_by = null,"); //更新人
 }
 }
 
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.updated_time))
 {
 if (objdm_model_layoutEN.updated_time !=  null)
 {
 var dteupdated_time = objdm_model_layoutEN.updated_time;
 sbSQL.AppendFormat(" updated_time = '{0}',", dteupdated_time); //更新时间
 }
 else
 {
 sbSQL.Append(" updated_time = null,"); //更新时间
 }
 }
 
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.remark))
 {
 if (objdm_model_layoutEN.remark !=  null)
 {
 var strremark = objdm_model_layoutEN.remark.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objdm_model_layoutEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsdm_model_layoutEN objdm_model_layoutEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objdm_model_layoutEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objdm_model_layoutEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_layoutDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update dm_model_layout Set ");
 
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.model_name))
 {
 if (objdm_model_layoutEN.model_name !=  null)
 {
 var strmodel_name = objdm_model_layoutEN.model_name.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strmodel_name, condm_model_layout.model_name); //模型名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",condm_model_layout.model_name); //模型名称
 }
 }
 
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.prj_id))
 {
 if (objdm_model_layoutEN.prj_id !=  null)
 {
 var strprj_id = objdm_model_layoutEN.prj_id.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strprj_id, condm_model_layout.prj_id); //项目ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",condm_model_layout.prj_id); //项目ID
 }
 }
 
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.model_desc))
 {
 if (objdm_model_layoutEN.model_desc !=  null)
 {
 var strmodel_desc = objdm_model_layoutEN.model_desc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strmodel_desc, condm_model_layout.model_desc); //模型说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",condm_model_layout.model_desc); //模型说明
 }
 }
 
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.layout_data))
 {
 if (objdm_model_layoutEN.layout_data !=  null)
 {
 var strlayout_data = objdm_model_layoutEN.layout_data.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strlayout_data, condm_model_layout.layout_data); //布局数据
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",condm_model_layout.layout_data); //布局数据
 }
 }
 
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.canvas_height))
 {
 if (objdm_model_layoutEN.canvas_height !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objdm_model_layoutEN.canvas_height, condm_model_layout.canvas_height); //画布高
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",condm_model_layout.canvas_height); //画布高
 }
 }
 
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.canvas_width))
 {
 if (objdm_model_layoutEN.canvas_width !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objdm_model_layoutEN.canvas_width, condm_model_layout.canvas_width); //画布宽
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",condm_model_layout.canvas_width); //画布宽
 }
 }
 
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.Status))
 {
 if (objdm_model_layoutEN.Status !=  null)
 {
 var strStatus = objdm_model_layoutEN.Status.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStatus, condm_model_layout.Status); //Status
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",condm_model_layout.Status); //Status
 }
 }
 
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.sort_no))
 {
 if (objdm_model_layoutEN.sort_no !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objdm_model_layoutEN.sort_no, condm_model_layout.sort_no); //排序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",condm_model_layout.sort_no); //排序号
 }
 }
 
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.created_by))
 {
 if (objdm_model_layoutEN.created_by !=  null)
 {
 var strcreated_by = objdm_model_layoutEN.created_by.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strcreated_by, condm_model_layout.created_by); //创建人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",condm_model_layout.created_by); //创建人
 }
 }
 
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.created_time))
 {
 if (objdm_model_layoutEN.created_time !=  null)
 {
 var dtecreated_time = objdm_model_layoutEN.created_time;
 sbSQL.AppendFormat("{1} = '{0}',", dtecreated_time, condm_model_layout.created_time); //创建时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",condm_model_layout.created_time); //创建时间
 }
 }
 
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.updated_by))
 {
 if (objdm_model_layoutEN.updated_by !=  null)
 {
 var strupdated_by = objdm_model_layoutEN.updated_by.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strupdated_by, condm_model_layout.updated_by); //更新人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",condm_model_layout.updated_by); //更新人
 }
 }
 
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.updated_time))
 {
 if (objdm_model_layoutEN.updated_time !=  null)
 {
 var dteupdated_time = objdm_model_layoutEN.updated_time;
 sbSQL.AppendFormat("{1} = '{0}',", dteupdated_time, condm_model_layout.updated_time); //更新时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",condm_model_layout.updated_time); //更新时间
 }
 }
 
 if (objdm_model_layoutEN.IsUpdated(condm_model_layout.remark))
 {
 if (objdm_model_layoutEN.remark !=  null)
 {
 var strremark = objdm_model_layoutEN.remark.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strremark, condm_model_layout.remark); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",condm_model_layout.remark); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where model_id = '{0}'", objdm_model_layoutEN.model_id); 
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
 /// <param name = "strmodel_id">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strmodel_id) 
{
CheckPrimaryKey(strmodel_id);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_layoutDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strmodel_id,
};
 objSQL.ExecSP("dm_model_layout_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strmodel_id">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strmodel_id, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strmodel_id);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_layoutDA.GetSpecSQLObj();
//删除dm_model_layout本表中与当前对象有关的记录
strSQL = strSQL + "Delete from dm_model_layout where model_id = " + "'"+ strmodel_id+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Deldm_model_layout(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_layoutDA.GetSpecSQLObj();
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
//删除dm_model_layout本表中与当前对象有关的记录
strSQL = strSQL + "Delete from dm_model_layout where model_id in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strmodel_id">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strmodel_id) 
{
CheckPrimaryKey(strmodel_id);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_layoutDA.GetSpecSQLObj();
//删除dm_model_layout本表中与当前对象有关的记录
strSQL = strSQL + "Delete from dm_model_layout where model_id = " + "'"+ strmodel_id+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Deldm_model_layout(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsdm_model_layoutDA: Deldm_model_layout)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_layoutDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from dm_model_layout where " + strCondition ;
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
public bool Deldm_model_layoutWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsdm_model_layoutDA: Deldm_model_layoutWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsdm_model_layoutDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from dm_model_layout where " + strCondition ;
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
 /// <param name = "objdm_model_layoutENS">源对象</param>
 /// <param name = "objdm_model_layoutENT">目标对象</param>
public void CopyTo(clsdm_model_layoutEN objdm_model_layoutENS, clsdm_model_layoutEN objdm_model_layoutENT)
{
objdm_model_layoutENT.model_id = objdm_model_layoutENS.model_id; //模型ID
objdm_model_layoutENT.model_name = objdm_model_layoutENS.model_name; //模型名称
objdm_model_layoutENT.prj_id = objdm_model_layoutENS.prj_id; //项目ID
objdm_model_layoutENT.model_desc = objdm_model_layoutENS.model_desc; //模型说明
objdm_model_layoutENT.layout_data = objdm_model_layoutENS.layout_data; //布局数据
objdm_model_layoutENT.canvas_height = objdm_model_layoutENS.canvas_height; //画布高
objdm_model_layoutENT.canvas_width = objdm_model_layoutENS.canvas_width; //画布宽
objdm_model_layoutENT.Status = objdm_model_layoutENS.Status; //Status
objdm_model_layoutENT.sort_no = objdm_model_layoutENS.sort_no; //排序号
objdm_model_layoutENT.created_by = objdm_model_layoutENS.created_by; //创建人
objdm_model_layoutENT.created_time = objdm_model_layoutENS.created_time; //创建时间
objdm_model_layoutENT.updated_by = objdm_model_layoutENS.updated_by; //更新人
objdm_model_layoutENT.updated_time = objdm_model_layoutENS.updated_time; //更新时间
objdm_model_layoutENT.remark = objdm_model_layoutENS.remark; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsdm_model_layoutEN objdm_model_layoutEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objdm_model_layoutEN.model_name, condm_model_layout.model_name);
clsCheckSql.CheckFieldNotNull(objdm_model_layoutEN.prj_id, condm_model_layout.prj_id);
clsCheckSql.CheckFieldNotNull(objdm_model_layoutEN.Status, condm_model_layout.Status);
//检查字段长度
clsCheckSql.CheckFieldLen(objdm_model_layoutEN.model_id, 32, condm_model_layout.model_id);
clsCheckSql.CheckFieldLen(objdm_model_layoutEN.model_name, 100, condm_model_layout.model_name);
clsCheckSql.CheckFieldLen(objdm_model_layoutEN.prj_id, 32, condm_model_layout.prj_id);
clsCheckSql.CheckFieldLen(objdm_model_layoutEN.model_desc, 500, condm_model_layout.model_desc);
clsCheckSql.CheckFieldLen(objdm_model_layoutEN.layout_data, 4000, condm_model_layout.layout_data);
clsCheckSql.CheckFieldLen(objdm_model_layoutEN.Status, 20, condm_model_layout.Status);
clsCheckSql.CheckFieldLen(objdm_model_layoutEN.created_by, 50, condm_model_layout.created_by);
clsCheckSql.CheckFieldLen(objdm_model_layoutEN.updated_by, 50, condm_model_layout.updated_by);
clsCheckSql.CheckFieldLen(objdm_model_layoutEN.remark, 500, condm_model_layout.remark);
//检查字段外键固定长度
 objdm_model_layoutEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsdm_model_layoutEN objdm_model_layoutEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objdm_model_layoutEN.model_name, 100, condm_model_layout.model_name);
clsCheckSql.CheckFieldLen(objdm_model_layoutEN.prj_id, 32, condm_model_layout.prj_id);
clsCheckSql.CheckFieldLen(objdm_model_layoutEN.model_desc, 500, condm_model_layout.model_desc);
clsCheckSql.CheckFieldLen(objdm_model_layoutEN.layout_data, 4000, condm_model_layout.layout_data);
clsCheckSql.CheckFieldLen(objdm_model_layoutEN.Status, 20, condm_model_layout.Status);
clsCheckSql.CheckFieldLen(objdm_model_layoutEN.created_by, 50, condm_model_layout.created_by);
clsCheckSql.CheckFieldLen(objdm_model_layoutEN.updated_by, 50, condm_model_layout.updated_by);
clsCheckSql.CheckFieldLen(objdm_model_layoutEN.remark, 500, condm_model_layout.remark);
//检查外键字段长度
 objdm_model_layoutEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsdm_model_layoutEN objdm_model_layoutEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objdm_model_layoutEN.model_id, 32, condm_model_layout.model_id);
clsCheckSql.CheckFieldLen(objdm_model_layoutEN.model_name, 100, condm_model_layout.model_name);
clsCheckSql.CheckFieldLen(objdm_model_layoutEN.prj_id, 32, condm_model_layout.prj_id);
clsCheckSql.CheckFieldLen(objdm_model_layoutEN.model_desc, 500, condm_model_layout.model_desc);
clsCheckSql.CheckFieldLen(objdm_model_layoutEN.layout_data, 4000, condm_model_layout.layout_data);
clsCheckSql.CheckFieldLen(objdm_model_layoutEN.Status, 20, condm_model_layout.Status);
clsCheckSql.CheckFieldLen(objdm_model_layoutEN.created_by, 50, condm_model_layout.created_by);
clsCheckSql.CheckFieldLen(objdm_model_layoutEN.updated_by, 50, condm_model_layout.updated_by);
clsCheckSql.CheckFieldLen(objdm_model_layoutEN.remark, 500, condm_model_layout.remark);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objdm_model_layoutEN.model_id, condm_model_layout.model_id);
clsCheckSql.CheckSqlInjection4Field(objdm_model_layoutEN.model_name, condm_model_layout.model_name);
clsCheckSql.CheckSqlInjection4Field(objdm_model_layoutEN.prj_id, condm_model_layout.prj_id);
clsCheckSql.CheckSqlInjection4Field(objdm_model_layoutEN.model_desc, condm_model_layout.model_desc);
clsCheckSql.CheckSqlInjection4Field(objdm_model_layoutEN.layout_data, condm_model_layout.layout_data);
clsCheckSql.CheckSqlInjection4Field(objdm_model_layoutEN.Status, condm_model_layout.Status);
clsCheckSql.CheckSqlInjection4Field(objdm_model_layoutEN.created_by, condm_model_layout.created_by);
clsCheckSql.CheckSqlInjection4Field(objdm_model_layoutEN.updated_by, condm_model_layout.updated_by);
clsCheckSql.CheckSqlInjection4Field(objdm_model_layoutEN.remark, condm_model_layout.remark);
//检查外键字段长度
 objdm_model_layoutEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable Getmodel_id()
{
//获取某学院所有专业信息
string strSQL = "select model_id, model_name from dm_model_layout ";
 clsSpecSQLforSql mySql = clsdm_model_layoutDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--dm_model_layout(模型布局表),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objdm_model_layoutEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsdm_model_layoutEN objdm_model_layoutEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and model_name = '{0}'", objdm_model_layoutEN.model_name);
 sbCondition.AppendFormat(" and prj_id = '{0}'", objdm_model_layoutEN.prj_id);
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
 objSQL = clsdm_model_layoutDA.GetSpecSQLObj();
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
 objSQL = clsdm_model_layoutDA.GetSpecSQLObj();
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
 objSQL = clsdm_model_layoutDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsdm_model_layoutEN._CurrTabName);
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
 objSQL = clsdm_model_layoutDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsdm_model_layoutEN._CurrTabName, strCondition);
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
 objSQL = clsdm_model_layoutDA.GetSpecSQLObj();
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
 objSQL = clsdm_model_layoutDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}