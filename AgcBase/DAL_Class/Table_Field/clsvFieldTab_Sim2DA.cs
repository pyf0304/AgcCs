
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFieldTab_Sim2DA
 表名:vFieldTab_Sim2(00050608)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:27:12
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
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
 /// vFieldTab_Sim2(vFieldTab_Sim2)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvFieldTab_Sim2DA : clsCommBase4DA
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
 return clsvFieldTab_Sim2EN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvFieldTab_Sim2EN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvFieldTab_Sim2EN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvFieldTab_Sim2EN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvFieldTab_Sim2EN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strFldId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strFldId)
{
strFldId = strFldId.Replace("'", "''");
if (strFldId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vFieldTab_Sim2中,检查关键字,长度不正确!(clsvFieldTab_Sim2DA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strFldId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vFieldTab_Sim2中,关键字不能为空 或 null!(clsvFieldTab_Sim2DA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFldId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvFieldTab_Sim2DA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvFieldTab_Sim2DA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab_Sim2DA.GetSpecSQLObj();
strSQL = "Select * from vFieldTab_Sim2 where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vFieldTab_Sim2(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvFieldTab_Sim2DA: GetDataTable_vFieldTab_Sim2)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab_Sim2DA.GetSpecSQLObj();
strSQL = "Select * from vFieldTab_Sim2 where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvFieldTab_Sim2DA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab_Sim2DA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvFieldTab_Sim2DA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab_Sim2DA.GetSpecSQLObj();
strSQL = "Select * from vFieldTab_Sim2 where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvFieldTab_Sim2DA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab_Sim2DA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvFieldTab_Sim2DA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab_Sim2DA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFieldTab_Sim2 where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFieldTab_Sim2 where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvFieldTab_Sim2DA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab_Sim2DA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vFieldTab_Sim2 where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvFieldTab_Sim2DA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab_Sim2DA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vFieldTab_Sim2.* " + 
$"from vFieldTab_Sim2 " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vFieldTab_Sim2.FldId not in " + 
$"(Select top {intTop_In} vFieldTab_Sim2.FldId from vFieldTab_Sim2 " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFieldTab_Sim2 where {1} and FldId not in (Select top {2} FldId from vFieldTab_Sim2 where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFieldTab_Sim2 where {1} and FldId not in (Select top {3} FldId from vFieldTab_Sim2 where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvFieldTab_Sim2DA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab_Sim2DA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vFieldTab_Sim2.* " + 
$"from vFieldTab_Sim2 " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vFieldTab_Sim2.FldId not in " + 
$"(Select top {intTop_In} vFieldTab_Sim2.FldId from vFieldTab_Sim2 " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFieldTab_Sim2 where {1} and FldId not in (Select top {2} FldId from vFieldTab_Sim2 where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFieldTab_Sim2 where {1} and FldId not in (Select top {3} FldId from vFieldTab_Sim2 where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvFieldTab_Sim2EN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvFieldTab_Sim2DA:GetObjLst)", objException.Message));
}
List<clsvFieldTab_Sim2EN> arrObjLst = new List<clsvFieldTab_Sim2EN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab_Sim2DA.GetSpecSQLObj();
strSQL = "Select * from vFieldTab_Sim2 where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFieldTab_Sim2EN objvFieldTab_Sim2EN = new clsvFieldTab_Sim2EN();
try
{
objvFieldTab_Sim2EN.FldId = objRow[convFieldTab_Sim2.FldId].ToString().Trim(); //字段Id
objvFieldTab_Sim2EN.DataTypeId = objRow[convFieldTab_Sim2.DataTypeId].ToString().Trim(); //数据类型Id
objvFieldTab_Sim2EN.FldName = objRow[convFieldTab_Sim2.FldName].ToString().Trim(); //字段名
objvFieldTab_Sim2EN.Caption = objRow[convFieldTab_Sim2.Caption].ToString().Trim(); //标题
objvFieldTab_Sim2EN.FldLength = TransNullToInt(objRow[convFieldTab_Sim2.FldLength].ToString().Trim()); //字段长度
objvFieldTab_Sim2EN.FldPrecision = objRow[convFieldTab_Sim2.FldPrecision] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFieldTab_Sim2.FldPrecision].ToString().Trim()); //精确度
objvFieldTab_Sim2EN.PrjId = objRow[convFieldTab_Sim2.PrjId].ToString().Trim(); //工程Id
objvFieldTab_Sim2EN.FieldTypeId = objRow[convFieldTab_Sim2.FieldTypeId] == DBNull.Value ? null : objRow[convFieldTab_Sim2.FieldTypeId].ToString().Trim(); //字段类型Id
objvFieldTab_Sim2EN.HomologousFldId = objRow[convFieldTab_Sim2.HomologousFldId] == DBNull.Value ? null : objRow[convFieldTab_Sim2.HomologousFldId].ToString().Trim(); //同源字段Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvFieldTab_Sim2DA: GetObjLst)", objException.Message));
}
objvFieldTab_Sim2EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvFieldTab_Sim2EN);
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
public List<clsvFieldTab_Sim2EN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvFieldTab_Sim2DA:GetObjLstByTabName)", objException.Message));
}
List<clsvFieldTab_Sim2EN> arrObjLst = new List<clsvFieldTab_Sim2EN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab_Sim2DA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFieldTab_Sim2EN objvFieldTab_Sim2EN = new clsvFieldTab_Sim2EN();
try
{
objvFieldTab_Sim2EN.FldId = objRow[convFieldTab_Sim2.FldId].ToString().Trim(); //字段Id
objvFieldTab_Sim2EN.DataTypeId = objRow[convFieldTab_Sim2.DataTypeId].ToString().Trim(); //数据类型Id
objvFieldTab_Sim2EN.FldName = objRow[convFieldTab_Sim2.FldName].ToString().Trim(); //字段名
objvFieldTab_Sim2EN.Caption = objRow[convFieldTab_Sim2.Caption].ToString().Trim(); //标题
objvFieldTab_Sim2EN.FldLength = TransNullToInt(objRow[convFieldTab_Sim2.FldLength].ToString().Trim()); //字段长度
objvFieldTab_Sim2EN.FldPrecision = objRow[convFieldTab_Sim2.FldPrecision] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFieldTab_Sim2.FldPrecision].ToString().Trim()); //精确度
objvFieldTab_Sim2EN.PrjId = objRow[convFieldTab_Sim2.PrjId].ToString().Trim(); //工程Id
objvFieldTab_Sim2EN.FieldTypeId = objRow[convFieldTab_Sim2.FieldTypeId] == DBNull.Value ? null : objRow[convFieldTab_Sim2.FieldTypeId].ToString().Trim(); //字段类型Id
objvFieldTab_Sim2EN.HomologousFldId = objRow[convFieldTab_Sim2.HomologousFldId] == DBNull.Value ? null : objRow[convFieldTab_Sim2.HomologousFldId].ToString().Trim(); //同源字段Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvFieldTab_Sim2DA: GetObjLst)", objException.Message));
}
objvFieldTab_Sim2EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvFieldTab_Sim2EN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvFieldTab_Sim2EN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvFieldTab_Sim2(ref clsvFieldTab_Sim2EN objvFieldTab_Sim2EN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab_Sim2DA.GetSpecSQLObj();
strSQL = "Select * from vFieldTab_Sim2 where FldId = " + "'"+ objvFieldTab_Sim2EN.FldId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvFieldTab_Sim2EN.FldId = objDT.Rows[0][convFieldTab_Sim2.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objvFieldTab_Sim2EN.DataTypeId = objDT.Rows[0][convFieldTab_Sim2.DataTypeId].ToString().Trim(); //数据类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvFieldTab_Sim2EN.FldName = objDT.Rows[0][convFieldTab_Sim2.FldName].ToString().Trim(); //字段名(字段类型:varchar,字段长度:50,是否可空:False)
 objvFieldTab_Sim2EN.Caption = objDT.Rows[0][convFieldTab_Sim2.Caption].ToString().Trim(); //标题(字段类型:varchar,字段长度:200,是否可空:False)
 objvFieldTab_Sim2EN.FldLength = TransNullToInt(objDT.Rows[0][convFieldTab_Sim2.FldLength].ToString().Trim()); //字段长度(字段类型:int,字段长度:4,是否可空:False)
 objvFieldTab_Sim2EN.FldPrecision = TransNullToInt(objDT.Rows[0][convFieldTab_Sim2.FldPrecision].ToString().Trim()); //精确度(字段类型:int,字段长度:4,是否可空:True)
 objvFieldTab_Sim2EN.PrjId = objDT.Rows[0][convFieldTab_Sim2.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvFieldTab_Sim2EN.FieldTypeId = objDT.Rows[0][convFieldTab_Sim2.FieldTypeId].ToString().Trim(); //字段类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvFieldTab_Sim2EN.HomologousFldId = objDT.Rows[0][convFieldTab_Sim2.HomologousFldId].ToString().Trim(); //同源字段Id(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvFieldTab_Sim2DA: GetvFieldTab_Sim2)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFldId">表关键字</param>
 /// <returns>表对象</returns>
public clsvFieldTab_Sim2EN GetObjByFldId(string strFldId)
{
CheckPrimaryKey(strFldId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab_Sim2DA.GetSpecSQLObj();
strSQL = "Select * from vFieldTab_Sim2 where FldId = " + "'"+ strFldId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvFieldTab_Sim2EN objvFieldTab_Sim2EN = new clsvFieldTab_Sim2EN();
try
{
 objvFieldTab_Sim2EN.FldId = objRow[convFieldTab_Sim2.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objvFieldTab_Sim2EN.DataTypeId = objRow[convFieldTab_Sim2.DataTypeId].ToString().Trim(); //数据类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvFieldTab_Sim2EN.FldName = objRow[convFieldTab_Sim2.FldName].ToString().Trim(); //字段名(字段类型:varchar,字段长度:50,是否可空:False)
 objvFieldTab_Sim2EN.Caption = objRow[convFieldTab_Sim2.Caption].ToString().Trim(); //标题(字段类型:varchar,字段长度:200,是否可空:False)
 objvFieldTab_Sim2EN.FldLength = Int32.Parse(objRow[convFieldTab_Sim2.FldLength].ToString().Trim()); //字段长度(字段类型:int,字段长度:4,是否可空:False)
 objvFieldTab_Sim2EN.FldPrecision = objRow[convFieldTab_Sim2.FldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFieldTab_Sim2.FldPrecision].ToString().Trim()); //精确度(字段类型:int,字段长度:4,是否可空:True)
 objvFieldTab_Sim2EN.PrjId = objRow[convFieldTab_Sim2.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvFieldTab_Sim2EN.FieldTypeId = objRow[convFieldTab_Sim2.FieldTypeId] == DBNull.Value ? null : objRow[convFieldTab_Sim2.FieldTypeId].ToString().Trim(); //字段类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvFieldTab_Sim2EN.HomologousFldId = objRow[convFieldTab_Sim2.HomologousFldId] == DBNull.Value ? null : objRow[convFieldTab_Sim2.HomologousFldId].ToString().Trim(); //同源字段Id(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvFieldTab_Sim2DA: GetObjByFldId)", objException.Message));
}
return objvFieldTab_Sim2EN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvFieldTab_Sim2EN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvFieldTab_Sim2DA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab_Sim2DA.GetSpecSQLObj();
strSQL = "Select * from vFieldTab_Sim2 where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvFieldTab_Sim2EN objvFieldTab_Sim2EN = new clsvFieldTab_Sim2EN()
{
FldId = objRow[convFieldTab_Sim2.FldId].ToString().Trim(), //字段Id
DataTypeId = objRow[convFieldTab_Sim2.DataTypeId].ToString().Trim(), //数据类型Id
FldName = objRow[convFieldTab_Sim2.FldName].ToString().Trim(), //字段名
Caption = objRow[convFieldTab_Sim2.Caption].ToString().Trim(), //标题
FldLength = TransNullToInt(objRow[convFieldTab_Sim2.FldLength].ToString().Trim()), //字段长度
FldPrecision = objRow[convFieldTab_Sim2.FldPrecision] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFieldTab_Sim2.FldPrecision].ToString().Trim()), //精确度
PrjId = objRow[convFieldTab_Sim2.PrjId].ToString().Trim(), //工程Id
FieldTypeId = objRow[convFieldTab_Sim2.FieldTypeId] == DBNull.Value ? null : objRow[convFieldTab_Sim2.FieldTypeId].ToString().Trim(), //字段类型Id
HomologousFldId = objRow[convFieldTab_Sim2.HomologousFldId] == DBNull.Value ? null : objRow[convFieldTab_Sim2.HomologousFldId].ToString().Trim() //同源字段Id
};
objvFieldTab_Sim2EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFieldTab_Sim2EN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvFieldTab_Sim2DA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvFieldTab_Sim2EN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvFieldTab_Sim2EN objvFieldTab_Sim2EN = new clsvFieldTab_Sim2EN();
try
{
objvFieldTab_Sim2EN.FldId = objRow[convFieldTab_Sim2.FldId].ToString().Trim(); //字段Id
objvFieldTab_Sim2EN.DataTypeId = objRow[convFieldTab_Sim2.DataTypeId].ToString().Trim(); //数据类型Id
objvFieldTab_Sim2EN.FldName = objRow[convFieldTab_Sim2.FldName].ToString().Trim(); //字段名
objvFieldTab_Sim2EN.Caption = objRow[convFieldTab_Sim2.Caption].ToString().Trim(); //标题
objvFieldTab_Sim2EN.FldLength = TransNullToInt(objRow[convFieldTab_Sim2.FldLength].ToString().Trim()); //字段长度
objvFieldTab_Sim2EN.FldPrecision = objRow[convFieldTab_Sim2.FldPrecision] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFieldTab_Sim2.FldPrecision].ToString().Trim()); //精确度
objvFieldTab_Sim2EN.PrjId = objRow[convFieldTab_Sim2.PrjId].ToString().Trim(); //工程Id
objvFieldTab_Sim2EN.FieldTypeId = objRow[convFieldTab_Sim2.FieldTypeId] == DBNull.Value ? null : objRow[convFieldTab_Sim2.FieldTypeId].ToString().Trim(); //字段类型Id
objvFieldTab_Sim2EN.HomologousFldId = objRow[convFieldTab_Sim2.HomologousFldId] == DBNull.Value ? null : objRow[convFieldTab_Sim2.HomologousFldId].ToString().Trim(); //同源字段Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvFieldTab_Sim2DA: GetObjByDataRowvFieldTab_Sim2)", objException.Message));
}
objvFieldTab_Sim2EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFieldTab_Sim2EN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvFieldTab_Sim2EN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvFieldTab_Sim2EN objvFieldTab_Sim2EN = new clsvFieldTab_Sim2EN();
try
{
objvFieldTab_Sim2EN.FldId = objRow[convFieldTab_Sim2.FldId].ToString().Trim(); //字段Id
objvFieldTab_Sim2EN.DataTypeId = objRow[convFieldTab_Sim2.DataTypeId].ToString().Trim(); //数据类型Id
objvFieldTab_Sim2EN.FldName = objRow[convFieldTab_Sim2.FldName].ToString().Trim(); //字段名
objvFieldTab_Sim2EN.Caption = objRow[convFieldTab_Sim2.Caption].ToString().Trim(); //标题
objvFieldTab_Sim2EN.FldLength = TransNullToInt(objRow[convFieldTab_Sim2.FldLength].ToString().Trim()); //字段长度
objvFieldTab_Sim2EN.FldPrecision = objRow[convFieldTab_Sim2.FldPrecision] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFieldTab_Sim2.FldPrecision].ToString().Trim()); //精确度
objvFieldTab_Sim2EN.PrjId = objRow[convFieldTab_Sim2.PrjId].ToString().Trim(); //工程Id
objvFieldTab_Sim2EN.FieldTypeId = objRow[convFieldTab_Sim2.FieldTypeId] == DBNull.Value ? null : objRow[convFieldTab_Sim2.FieldTypeId].ToString().Trim(); //字段类型Id
objvFieldTab_Sim2EN.HomologousFldId = objRow[convFieldTab_Sim2.HomologousFldId] == DBNull.Value ? null : objRow[convFieldTab_Sim2.HomologousFldId].ToString().Trim(); //同源字段Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvFieldTab_Sim2DA: GetObjByDataRow)", objException.Message));
}
objvFieldTab_Sim2EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFieldTab_Sim2EN;
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
objSQL = clsvFieldTab_Sim2DA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvFieldTab_Sim2EN._CurrTabName, convFieldTab_Sim2.FldId, 8, "");
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
objSQL = clsvFieldTab_Sim2DA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvFieldTab_Sim2EN._CurrTabName, convFieldTab_Sim2.FldId, 8, strPrefix);
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
 objSQL = clsvFieldTab_Sim2DA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select FldId from vFieldTab_Sim2 where " + strCondition;
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
 objSQL = clsvFieldTab_Sim2DA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select FldId from vFieldTab_Sim2 where " + strCondition;
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
 /// <param name = "strFldId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strFldId)
{
CheckPrimaryKey(strFldId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab_Sim2DA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vFieldTab_Sim2", "FldId = " + "'"+ strFldId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvFieldTab_Sim2DA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab_Sim2DA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vFieldTab_Sim2", strCondition))
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
objSQL = clsvFieldTab_Sim2DA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vFieldTab_Sim2");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvFieldTab_Sim2ENS">源对象</param>
 /// <param name = "objvFieldTab_Sim2ENT">目标对象</param>
public void CopyTo(clsvFieldTab_Sim2EN objvFieldTab_Sim2ENS, clsvFieldTab_Sim2EN objvFieldTab_Sim2ENT)
{
objvFieldTab_Sim2ENT.FldId = objvFieldTab_Sim2ENS.FldId; //字段Id
objvFieldTab_Sim2ENT.DataTypeId = objvFieldTab_Sim2ENS.DataTypeId; //数据类型Id
objvFieldTab_Sim2ENT.FldName = objvFieldTab_Sim2ENS.FldName; //字段名
objvFieldTab_Sim2ENT.Caption = objvFieldTab_Sim2ENS.Caption; //标题
objvFieldTab_Sim2ENT.FldLength = objvFieldTab_Sim2ENS.FldLength; //字段长度
objvFieldTab_Sim2ENT.FldPrecision = objvFieldTab_Sim2ENS.FldPrecision; //精确度
objvFieldTab_Sim2ENT.PrjId = objvFieldTab_Sim2ENS.PrjId; //工程Id
objvFieldTab_Sim2ENT.FieldTypeId = objvFieldTab_Sim2ENS.FieldTypeId; //字段类型Id
objvFieldTab_Sim2ENT.HomologousFldId = objvFieldTab_Sim2ENS.HomologousFldId; //同源字段Id
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvFieldTab_Sim2EN objvFieldTab_Sim2EN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvFieldTab_Sim2EN.FldId, 8, convFieldTab_Sim2.FldId);
clsCheckSql.CheckFieldLen(objvFieldTab_Sim2EN.DataTypeId, 2, convFieldTab_Sim2.DataTypeId);
clsCheckSql.CheckFieldLen(objvFieldTab_Sim2EN.FldName, 50, convFieldTab_Sim2.FldName);
clsCheckSql.CheckFieldLen(objvFieldTab_Sim2EN.Caption, 200, convFieldTab_Sim2.Caption);
clsCheckSql.CheckFieldLen(objvFieldTab_Sim2EN.PrjId, 4, convFieldTab_Sim2.PrjId);
clsCheckSql.CheckFieldLen(objvFieldTab_Sim2EN.FieldTypeId, 2, convFieldTab_Sim2.FieldTypeId);
clsCheckSql.CheckFieldLen(objvFieldTab_Sim2EN.HomologousFldId, 8, convFieldTab_Sim2.HomologousFldId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvFieldTab_Sim2EN.FldId, convFieldTab_Sim2.FldId);
clsCheckSql.CheckSqlInjection4Field(objvFieldTab_Sim2EN.DataTypeId, convFieldTab_Sim2.DataTypeId);
clsCheckSql.CheckSqlInjection4Field(objvFieldTab_Sim2EN.FldName, convFieldTab_Sim2.FldName);
clsCheckSql.CheckSqlInjection4Field(objvFieldTab_Sim2EN.Caption, convFieldTab_Sim2.Caption);
clsCheckSql.CheckSqlInjection4Field(objvFieldTab_Sim2EN.PrjId, convFieldTab_Sim2.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvFieldTab_Sim2EN.FieldTypeId, convFieldTab_Sim2.FieldTypeId);
clsCheckSql.CheckSqlInjection4Field(objvFieldTab_Sim2EN.HomologousFldId, convFieldTab_Sim2.HomologousFldId);
//检查外键字段长度
 objvFieldTab_Sim2EN._IsCheckProperty = true;
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
 objSQL = clsvFieldTab_Sim2DA.GetSpecSQLObj();
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
 objSQL = clsvFieldTab_Sim2DA.GetSpecSQLObj();
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
 objSQL = clsvFieldTab_Sim2DA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvFieldTab_Sim2EN._CurrTabName);
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
 objSQL = clsvFieldTab_Sim2DA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvFieldTab_Sim2EN._CurrTabName, strCondition);
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
 objSQL = clsvFieldTab_Sim2DA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}