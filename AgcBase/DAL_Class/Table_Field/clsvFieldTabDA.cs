
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFieldTabDA
 表名:vFieldTab(00050119)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:49:12
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
 /// v工程字段(vFieldTab)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvFieldTabDA : clsCommBase4DA
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
 return clsvFieldTabEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvFieldTabEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvFieldTabEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvFieldTabEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvFieldTabEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vFieldTab中,检查关键字,长度不正确!(clsvFieldTabDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strFldId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vFieldTab中,关键字不能为空 或 null!(clsvFieldTabDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFldId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvFieldTabDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvFieldTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTabDA.GetSpecSQLObj();
strSQL = "Select * from vFieldTab where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vFieldTab(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvFieldTabDA: GetDataTable_vFieldTab)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTabDA.GetSpecSQLObj();
strSQL = "Select * from vFieldTab where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvFieldTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTabDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvFieldTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTabDA.GetSpecSQLObj();
strSQL = "Select * from vFieldTab where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvFieldTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTabDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvFieldTabDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTabDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFieldTab where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFieldTab where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvFieldTabDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTabDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vFieldTab where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvFieldTabDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTabDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vFieldTab.* " + 
$"from vFieldTab " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vFieldTab.FldId not in " + 
$"(Select top {intTop_In} vFieldTab.FldId from vFieldTab " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFieldTab where {1} and FldId not in (Select top {2} FldId from vFieldTab where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFieldTab where {1} and FldId not in (Select top {3} FldId from vFieldTab where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvFieldTabDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTabDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vFieldTab.* " + 
$"from vFieldTab " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vFieldTab.FldId not in " + 
$"(Select top {intTop_In} vFieldTab.FldId from vFieldTab " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFieldTab where {1} and FldId not in (Select top {2} FldId from vFieldTab where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFieldTab where {1} and FldId not in (Select top {3} FldId from vFieldTab where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvFieldTabEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvFieldTabDA:GetObjLst)", objException.Message));
}
List<clsvFieldTabEN> arrObjLst = new List<clsvFieldTabEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTabDA.GetSpecSQLObj();
strSQL = "Select * from vFieldTab where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFieldTabEN objvFieldTabEN = new clsvFieldTabEN();
try
{
objvFieldTabEN.TabNum = objRow[convFieldTab.TabNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFieldTab.TabNum].ToString().Trim()); //表数
objvFieldTabEN.FieldTypeName = objRow[convFieldTab.FieldTypeName] == DBNull.Value ? null : objRow[convFieldTab.FieldTypeName].ToString().Trim(); //字段类型名
objvFieldTabEN.FieldTypeENName = objRow[convFieldTab.FieldTypeENName] == DBNull.Value ? null : objRow[convFieldTab.FieldTypeENName].ToString().Trim(); //字段类型英文名
objvFieldTabEN.OraDbType = objRow[convFieldTab.OraDbType].ToString().Trim(); //Ora数据类型
objvFieldTabEN.IsNeedTransCode = TransNullToBool(objRow[convFieldTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvFieldTabEN.FldId = objRow[convFieldTab.FldId].ToString().Trim(); //字段Id
objvFieldTabEN.FldName = objRow[convFieldTab.FldName].ToString().Trim(); //字段名
objvFieldTabEN.FldCnName = objRow[convFieldTab.FldCnName] == DBNull.Value ? null : objRow[convFieldTab.FldCnName].ToString().Trim(); //字段中文详名
objvFieldTabEN.Caption = objRow[convFieldTab.Caption].ToString().Trim(); //标题
objvFieldTabEN.FieldTypeId = objRow[convFieldTab.FieldTypeId] == DBNull.Value ? null : objRow[convFieldTab.FieldTypeId].ToString().Trim(); //字段类型Id
objvFieldTabEN.DataTypeId = objRow[convFieldTab.DataTypeId].ToString().Trim(); //数据类型Id
objvFieldTabEN.DataTypeName = objRow[convFieldTab.DataTypeName].ToString().Trim(); //数据类型名称
objvFieldTabEN.FldLength = TransNullToInt(objRow[convFieldTab.FldLength].ToString().Trim()); //字段长度
objvFieldTabEN.FldPrecision = objRow[convFieldTab.FldPrecision] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFieldTab.FldPrecision].ToString().Trim()); //精确度
objvFieldTabEN.FldInfo = objRow[convFieldTab.FldInfo].ToString().Trim(); //字段信息
objvFieldTabEN.IsNull = TransNullToBool(objRow[convFieldTab.IsNull].ToString().Trim()); //是否可空
objvFieldTabEN.IsPrimaryKey = TransNullToBool(objRow[convFieldTab.IsPrimaryKey].ToString().Trim()); //是否主键
objvFieldTabEN.IsIdentity = TransNullToBool(objRow[convFieldTab.IsIdentity].ToString().Trim()); //是否Identity
objvFieldTabEN.IsChecked = TransNullToBool(objRow[convFieldTab.IsChecked].ToString().Trim()); //是否核实
objvFieldTabEN.IsArchive = TransNullToBool(objRow[convFieldTab.IsArchive].ToString().Trim()); //是否存档
objvFieldTabEN.IsOnlyOne = TransNullToBool(objRow[convFieldTab.IsOnlyOne].ToString().Trim()); //是否唯一
objvFieldTabEN.MaxValue = objRow[convFieldTab.MaxValue].ToString().Trim(); //最大值
objvFieldTabEN.MinValue = objRow[convFieldTab.MinValue].ToString().Trim(); //最小值
objvFieldTabEN.DefaultValue = objRow[convFieldTab.DefaultValue].ToString().Trim(); //缺省值
objvFieldTabEN.FldStateId = objRow[convFieldTab.FldStateId].ToString().Trim(); //字段状态Id
objvFieldTabEN.HomologousFldId = objRow[convFieldTab.HomologousFldId] == DBNull.Value ? null : objRow[convFieldTab.HomologousFldId].ToString().Trim(); //同源字段Id
objvFieldTabEN.PrjId = objRow[convFieldTab.PrjId].ToString().Trim(); //工程Id
objvFieldTabEN.PrjName = objRow[convFieldTab.PrjName].ToString().Trim(); //工程名称
objvFieldTabEN.UpdDate = objRow[convFieldTab.UpdDate] == DBNull.Value ? null : objRow[convFieldTab.UpdDate].ToString().Trim(); //修改日期
objvFieldTabEN.UpdUser = objRow[convFieldTab.UpdUser].ToString().Trim(); //修改者
objvFieldTabEN.Memo = objRow[convFieldTab.Memo] == DBNull.Value ? null : objRow[convFieldTab.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvFieldTabDA: GetObjLst)", objException.Message));
}
objvFieldTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvFieldTabEN);
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
public List<clsvFieldTabEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvFieldTabDA:GetObjLstByTabName)", objException.Message));
}
List<clsvFieldTabEN> arrObjLst = new List<clsvFieldTabEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTabDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFieldTabEN objvFieldTabEN = new clsvFieldTabEN();
try
{
objvFieldTabEN.TabNum = objRow[convFieldTab.TabNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFieldTab.TabNum].ToString().Trim()); //表数
objvFieldTabEN.FieldTypeName = objRow[convFieldTab.FieldTypeName] == DBNull.Value ? null : objRow[convFieldTab.FieldTypeName].ToString().Trim(); //字段类型名
objvFieldTabEN.FieldTypeENName = objRow[convFieldTab.FieldTypeENName] == DBNull.Value ? null : objRow[convFieldTab.FieldTypeENName].ToString().Trim(); //字段类型英文名
objvFieldTabEN.OraDbType = objRow[convFieldTab.OraDbType].ToString().Trim(); //Ora数据类型
objvFieldTabEN.IsNeedTransCode = TransNullToBool(objRow[convFieldTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvFieldTabEN.FldId = objRow[convFieldTab.FldId].ToString().Trim(); //字段Id
objvFieldTabEN.FldName = objRow[convFieldTab.FldName].ToString().Trim(); //字段名
objvFieldTabEN.FldCnName = objRow[convFieldTab.FldCnName] == DBNull.Value ? null : objRow[convFieldTab.FldCnName].ToString().Trim(); //字段中文详名
objvFieldTabEN.Caption = objRow[convFieldTab.Caption].ToString().Trim(); //标题
objvFieldTabEN.FieldTypeId = objRow[convFieldTab.FieldTypeId] == DBNull.Value ? null : objRow[convFieldTab.FieldTypeId].ToString().Trim(); //字段类型Id
objvFieldTabEN.DataTypeId = objRow[convFieldTab.DataTypeId].ToString().Trim(); //数据类型Id
objvFieldTabEN.DataTypeName = objRow[convFieldTab.DataTypeName].ToString().Trim(); //数据类型名称
objvFieldTabEN.FldLength = TransNullToInt(objRow[convFieldTab.FldLength].ToString().Trim()); //字段长度
objvFieldTabEN.FldPrecision = objRow[convFieldTab.FldPrecision] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFieldTab.FldPrecision].ToString().Trim()); //精确度
objvFieldTabEN.FldInfo = objRow[convFieldTab.FldInfo].ToString().Trim(); //字段信息
objvFieldTabEN.IsNull = TransNullToBool(objRow[convFieldTab.IsNull].ToString().Trim()); //是否可空
objvFieldTabEN.IsPrimaryKey = TransNullToBool(objRow[convFieldTab.IsPrimaryKey].ToString().Trim()); //是否主键
objvFieldTabEN.IsIdentity = TransNullToBool(objRow[convFieldTab.IsIdentity].ToString().Trim()); //是否Identity
objvFieldTabEN.IsChecked = TransNullToBool(objRow[convFieldTab.IsChecked].ToString().Trim()); //是否核实
objvFieldTabEN.IsArchive = TransNullToBool(objRow[convFieldTab.IsArchive].ToString().Trim()); //是否存档
objvFieldTabEN.IsOnlyOne = TransNullToBool(objRow[convFieldTab.IsOnlyOne].ToString().Trim()); //是否唯一
objvFieldTabEN.MaxValue = objRow[convFieldTab.MaxValue].ToString().Trim(); //最大值
objvFieldTabEN.MinValue = objRow[convFieldTab.MinValue].ToString().Trim(); //最小值
objvFieldTabEN.DefaultValue = objRow[convFieldTab.DefaultValue].ToString().Trim(); //缺省值
objvFieldTabEN.FldStateId = objRow[convFieldTab.FldStateId].ToString().Trim(); //字段状态Id
objvFieldTabEN.HomologousFldId = objRow[convFieldTab.HomologousFldId] == DBNull.Value ? null : objRow[convFieldTab.HomologousFldId].ToString().Trim(); //同源字段Id
objvFieldTabEN.PrjId = objRow[convFieldTab.PrjId].ToString().Trim(); //工程Id
objvFieldTabEN.PrjName = objRow[convFieldTab.PrjName].ToString().Trim(); //工程名称
objvFieldTabEN.UpdDate = objRow[convFieldTab.UpdDate] == DBNull.Value ? null : objRow[convFieldTab.UpdDate].ToString().Trim(); //修改日期
objvFieldTabEN.UpdUser = objRow[convFieldTab.UpdUser].ToString().Trim(); //修改者
objvFieldTabEN.Memo = objRow[convFieldTab.Memo] == DBNull.Value ? null : objRow[convFieldTab.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvFieldTabDA: GetObjLst)", objException.Message));
}
objvFieldTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvFieldTabEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvFieldTab(ref clsvFieldTabEN objvFieldTabEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTabDA.GetSpecSQLObj();
strSQL = "Select * from vFieldTab where FldId = " + "'"+ objvFieldTabEN.FldId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvFieldTabEN.TabNum = TransNullToInt(objDT.Rows[0][convFieldTab.TabNum].ToString().Trim()); //表数(字段类型:int,字段长度:4,是否可空:True)
 objvFieldTabEN.FieldTypeName = objDT.Rows[0][convFieldTab.FieldTypeName].ToString().Trim(); //字段类型名(字段类型:varchar,字段长度:30,是否可空:True)
 objvFieldTabEN.FieldTypeENName = objDT.Rows[0][convFieldTab.FieldTypeENName].ToString().Trim(); //字段类型英文名(字段类型:varchar,字段长度:30,是否可空:True)
 objvFieldTabEN.OraDbType = objDT.Rows[0][convFieldTab.OraDbType].ToString().Trim(); //Ora数据类型(字段类型:varchar,字段长度:100,是否可空:False)
 objvFieldTabEN.IsNeedTransCode = TransNullToBool(objDT.Rows[0][convFieldTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码(字段类型:bit,字段长度:1,是否可空:False)
 objvFieldTabEN.FldId = objDT.Rows[0][convFieldTab.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objvFieldTabEN.FldName = objDT.Rows[0][convFieldTab.FldName].ToString().Trim(); //字段名(字段类型:varchar,字段长度:50,是否可空:False)
 objvFieldTabEN.FldCnName = objDT.Rows[0][convFieldTab.FldCnName].ToString().Trim(); //字段中文详名(字段类型:varchar,字段长度:200,是否可空:True)
 objvFieldTabEN.Caption = objDT.Rows[0][convFieldTab.Caption].ToString().Trim(); //标题(字段类型:varchar,字段长度:200,是否可空:False)
 objvFieldTabEN.FieldTypeId = objDT.Rows[0][convFieldTab.FieldTypeId].ToString().Trim(); //字段类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvFieldTabEN.DataTypeId = objDT.Rows[0][convFieldTab.DataTypeId].ToString().Trim(); //数据类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvFieldTabEN.DataTypeName = objDT.Rows[0][convFieldTab.DataTypeName].ToString().Trim(); //数据类型名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvFieldTabEN.FldLength = TransNullToInt(objDT.Rows[0][convFieldTab.FldLength].ToString().Trim()); //字段长度(字段类型:int,字段长度:4,是否可空:False)
 objvFieldTabEN.FldPrecision = TransNullToInt(objDT.Rows[0][convFieldTab.FldPrecision].ToString().Trim()); //精确度(字段类型:int,字段长度:4,是否可空:True)
 objvFieldTabEN.FldInfo = objDT.Rows[0][convFieldTab.FldInfo].ToString().Trim(); //字段信息(字段类型:varchar,字段长度:100,是否可空:True)
 objvFieldTabEN.IsNull = TransNullToBool(objDT.Rows[0][convFieldTab.IsNull].ToString().Trim()); //是否可空(字段类型:bit,字段长度:1,是否可空:False)
 objvFieldTabEN.IsPrimaryKey = TransNullToBool(objDT.Rows[0][convFieldTab.IsPrimaryKey].ToString().Trim()); //是否主键(字段类型:bit,字段长度:1,是否可空:False)
 objvFieldTabEN.IsIdentity = TransNullToBool(objDT.Rows[0][convFieldTab.IsIdentity].ToString().Trim()); //是否Identity(字段类型:bit,字段长度:1,是否可空:True)
 objvFieldTabEN.IsChecked = TransNullToBool(objDT.Rows[0][convFieldTab.IsChecked].ToString().Trim()); //是否核实(字段类型:bit,字段长度:1,是否可空:True)
 objvFieldTabEN.IsArchive = TransNullToBool(objDT.Rows[0][convFieldTab.IsArchive].ToString().Trim()); //是否存档(字段类型:bit,字段长度:1,是否可空:True)
 objvFieldTabEN.IsOnlyOne = TransNullToBool(objDT.Rows[0][convFieldTab.IsOnlyOne].ToString().Trim()); //是否唯一(字段类型:bit,字段长度:1,是否可空:True)
 objvFieldTabEN.MaxValue = objDT.Rows[0][convFieldTab.MaxValue].ToString().Trim(); //最大值(字段类型:varchar,字段长度:50,是否可空:True)
 objvFieldTabEN.MinValue = objDT.Rows[0][convFieldTab.MinValue].ToString().Trim(); //最小值(字段类型:varchar,字段长度:50,是否可空:True)
 objvFieldTabEN.DefaultValue = objDT.Rows[0][convFieldTab.DefaultValue].ToString().Trim(); //缺省值(字段类型:varchar,字段长度:50,是否可空:True)
 objvFieldTabEN.FldStateId = objDT.Rows[0][convFieldTab.FldStateId].ToString().Trim(); //字段状态Id(字段类型:char,字段长度:2,是否可空:False)
 objvFieldTabEN.HomologousFldId = objDT.Rows[0][convFieldTab.HomologousFldId].ToString().Trim(); //同源字段Id(字段类型:char,字段长度:8,是否可空:False)
 objvFieldTabEN.PrjId = objDT.Rows[0][convFieldTab.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvFieldTabEN.PrjName = objDT.Rows[0][convFieldTab.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvFieldTabEN.UpdDate = objDT.Rows[0][convFieldTab.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvFieldTabEN.UpdUser = objDT.Rows[0][convFieldTab.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvFieldTabEN.Memo = objDT.Rows[0][convFieldTab.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvFieldTabDA: GetvFieldTab)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFldId">表关键字</param>
 /// <returns>表对象</returns>
public clsvFieldTabEN GetObjByFldId(string strFldId)
{
CheckPrimaryKey(strFldId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTabDA.GetSpecSQLObj();
strSQL = "Select * from vFieldTab where FldId = " + "'"+ strFldId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvFieldTabEN objvFieldTabEN = new clsvFieldTabEN();
try
{
 objvFieldTabEN.TabNum = objRow[convFieldTab.TabNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFieldTab.TabNum].ToString().Trim()); //表数(字段类型:int,字段长度:4,是否可空:True)
 objvFieldTabEN.FieldTypeName = objRow[convFieldTab.FieldTypeName] == DBNull.Value ? null : objRow[convFieldTab.FieldTypeName].ToString().Trim(); //字段类型名(字段类型:varchar,字段长度:30,是否可空:True)
 objvFieldTabEN.FieldTypeENName = objRow[convFieldTab.FieldTypeENName] == DBNull.Value ? null : objRow[convFieldTab.FieldTypeENName].ToString().Trim(); //字段类型英文名(字段类型:varchar,字段长度:30,是否可空:True)
 objvFieldTabEN.OraDbType = objRow[convFieldTab.OraDbType].ToString().Trim(); //Ora数据类型(字段类型:varchar,字段长度:100,是否可空:False)
 objvFieldTabEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码(字段类型:bit,字段长度:1,是否可空:False)
 objvFieldTabEN.FldId = objRow[convFieldTab.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objvFieldTabEN.FldName = objRow[convFieldTab.FldName].ToString().Trim(); //字段名(字段类型:varchar,字段长度:50,是否可空:False)
 objvFieldTabEN.FldCnName = objRow[convFieldTab.FldCnName] == DBNull.Value ? null : objRow[convFieldTab.FldCnName].ToString().Trim(); //字段中文详名(字段类型:varchar,字段长度:200,是否可空:True)
 objvFieldTabEN.Caption = objRow[convFieldTab.Caption].ToString().Trim(); //标题(字段类型:varchar,字段长度:200,是否可空:False)
 objvFieldTabEN.FieldTypeId = objRow[convFieldTab.FieldTypeId] == DBNull.Value ? null : objRow[convFieldTab.FieldTypeId].ToString().Trim(); //字段类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvFieldTabEN.DataTypeId = objRow[convFieldTab.DataTypeId].ToString().Trim(); //数据类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvFieldTabEN.DataTypeName = objRow[convFieldTab.DataTypeName].ToString().Trim(); //数据类型名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvFieldTabEN.FldLength = Int32.Parse(objRow[convFieldTab.FldLength].ToString().Trim()); //字段长度(字段类型:int,字段长度:4,是否可空:False)
 objvFieldTabEN.FldPrecision = objRow[convFieldTab.FldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFieldTab.FldPrecision].ToString().Trim()); //精确度(字段类型:int,字段长度:4,是否可空:True)
 objvFieldTabEN.FldInfo = objRow[convFieldTab.FldInfo].ToString().Trim(); //字段信息(字段类型:varchar,字段长度:100,是否可空:True)
 objvFieldTabEN.IsNull = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsNull].ToString().Trim()); //是否可空(字段类型:bit,字段长度:1,是否可空:False)
 objvFieldTabEN.IsPrimaryKey = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsPrimaryKey].ToString().Trim()); //是否主键(字段类型:bit,字段长度:1,是否可空:False)
 objvFieldTabEN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsIdentity].ToString().Trim()); //是否Identity(字段类型:bit,字段长度:1,是否可空:True)
 objvFieldTabEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsChecked].ToString().Trim()); //是否核实(字段类型:bit,字段长度:1,是否可空:True)
 objvFieldTabEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsArchive].ToString().Trim()); //是否存档(字段类型:bit,字段长度:1,是否可空:True)
 objvFieldTabEN.IsOnlyOne = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsOnlyOne].ToString().Trim()); //是否唯一(字段类型:bit,字段长度:1,是否可空:True)
 objvFieldTabEN.MaxValue = objRow[convFieldTab.MaxValue].ToString().Trim(); //最大值(字段类型:varchar,字段长度:50,是否可空:True)
 objvFieldTabEN.MinValue = objRow[convFieldTab.MinValue].ToString().Trim(); //最小值(字段类型:varchar,字段长度:50,是否可空:True)
 objvFieldTabEN.DefaultValue = objRow[convFieldTab.DefaultValue].ToString().Trim(); //缺省值(字段类型:varchar,字段长度:50,是否可空:True)
 objvFieldTabEN.FldStateId = objRow[convFieldTab.FldStateId].ToString().Trim(); //字段状态Id(字段类型:char,字段长度:2,是否可空:False)
 objvFieldTabEN.HomologousFldId = objRow[convFieldTab.HomologousFldId] == DBNull.Value ? null : objRow[convFieldTab.HomologousFldId].ToString().Trim(); //同源字段Id(字段类型:char,字段长度:8,是否可空:False)
 objvFieldTabEN.PrjId = objRow[convFieldTab.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvFieldTabEN.PrjName = objRow[convFieldTab.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvFieldTabEN.UpdDate = objRow[convFieldTab.UpdDate] == DBNull.Value ? null : objRow[convFieldTab.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvFieldTabEN.UpdUser = objRow[convFieldTab.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvFieldTabEN.Memo = objRow[convFieldTab.Memo] == DBNull.Value ? null : objRow[convFieldTab.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvFieldTabDA: GetObjByFldId)", objException.Message));
}
return objvFieldTabEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvFieldTabEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvFieldTabDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTabDA.GetSpecSQLObj();
strSQL = "Select * from vFieldTab where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvFieldTabEN objvFieldTabEN = new clsvFieldTabEN()
{
TabNum = objRow[convFieldTab.TabNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFieldTab.TabNum].ToString().Trim()), //表数
FieldTypeName = objRow[convFieldTab.FieldTypeName] == DBNull.Value ? null : objRow[convFieldTab.FieldTypeName].ToString().Trim(), //字段类型名
FieldTypeENName = objRow[convFieldTab.FieldTypeENName] == DBNull.Value ? null : objRow[convFieldTab.FieldTypeENName].ToString().Trim(), //字段类型英文名
OraDbType = objRow[convFieldTab.OraDbType].ToString().Trim(), //Ora数据类型
IsNeedTransCode = TransNullToBool(objRow[convFieldTab.IsNeedTransCode].ToString().Trim()), //是否需要转换代码
FldId = objRow[convFieldTab.FldId].ToString().Trim(), //字段Id
FldName = objRow[convFieldTab.FldName].ToString().Trim(), //字段名
FldCnName = objRow[convFieldTab.FldCnName] == DBNull.Value ? null : objRow[convFieldTab.FldCnName].ToString().Trim(), //字段中文详名
Caption = objRow[convFieldTab.Caption].ToString().Trim(), //标题
FieldTypeId = objRow[convFieldTab.FieldTypeId] == DBNull.Value ? null : objRow[convFieldTab.FieldTypeId].ToString().Trim(), //字段类型Id
DataTypeId = objRow[convFieldTab.DataTypeId].ToString().Trim(), //数据类型Id
DataTypeName = objRow[convFieldTab.DataTypeName].ToString().Trim(), //数据类型名称
FldLength = TransNullToInt(objRow[convFieldTab.FldLength].ToString().Trim()), //字段长度
FldPrecision = objRow[convFieldTab.FldPrecision] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFieldTab.FldPrecision].ToString().Trim()), //精确度
FldInfo = objRow[convFieldTab.FldInfo].ToString().Trim(), //字段信息
IsNull = TransNullToBool(objRow[convFieldTab.IsNull].ToString().Trim()), //是否可空
IsPrimaryKey = TransNullToBool(objRow[convFieldTab.IsPrimaryKey].ToString().Trim()), //是否主键
IsIdentity = TransNullToBool(objRow[convFieldTab.IsIdentity].ToString().Trim()), //是否Identity
IsChecked = TransNullToBool(objRow[convFieldTab.IsChecked].ToString().Trim()), //是否核实
IsArchive = TransNullToBool(objRow[convFieldTab.IsArchive].ToString().Trim()), //是否存档
IsOnlyOne = TransNullToBool(objRow[convFieldTab.IsOnlyOne].ToString().Trim()), //是否唯一
MaxValue = objRow[convFieldTab.MaxValue].ToString().Trim(), //最大值
MinValue = objRow[convFieldTab.MinValue].ToString().Trim(), //最小值
DefaultValue = objRow[convFieldTab.DefaultValue].ToString().Trim(), //缺省值
FldStateId = objRow[convFieldTab.FldStateId].ToString().Trim(), //字段状态Id
HomologousFldId = objRow[convFieldTab.HomologousFldId] == DBNull.Value ? null : objRow[convFieldTab.HomologousFldId].ToString().Trim(), //同源字段Id
PrjId = objRow[convFieldTab.PrjId].ToString().Trim(), //工程Id
PrjName = objRow[convFieldTab.PrjName].ToString().Trim(), //工程名称
UpdDate = objRow[convFieldTab.UpdDate] == DBNull.Value ? null : objRow[convFieldTab.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convFieldTab.UpdUser].ToString().Trim(), //修改者
Memo = objRow[convFieldTab.Memo] == DBNull.Value ? null : objRow[convFieldTab.Memo].ToString().Trim() //说明
};
objvFieldTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFieldTabEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvFieldTabDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvFieldTabEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvFieldTabEN objvFieldTabEN = new clsvFieldTabEN();
try
{
objvFieldTabEN.TabNum = objRow[convFieldTab.TabNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFieldTab.TabNum].ToString().Trim()); //表数
objvFieldTabEN.FieldTypeName = objRow[convFieldTab.FieldTypeName] == DBNull.Value ? null : objRow[convFieldTab.FieldTypeName].ToString().Trim(); //字段类型名
objvFieldTabEN.FieldTypeENName = objRow[convFieldTab.FieldTypeENName] == DBNull.Value ? null : objRow[convFieldTab.FieldTypeENName].ToString().Trim(); //字段类型英文名
objvFieldTabEN.OraDbType = objRow[convFieldTab.OraDbType].ToString().Trim(); //Ora数据类型
objvFieldTabEN.IsNeedTransCode = TransNullToBool(objRow[convFieldTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvFieldTabEN.FldId = objRow[convFieldTab.FldId].ToString().Trim(); //字段Id
objvFieldTabEN.FldName = objRow[convFieldTab.FldName].ToString().Trim(); //字段名
objvFieldTabEN.FldCnName = objRow[convFieldTab.FldCnName] == DBNull.Value ? null : objRow[convFieldTab.FldCnName].ToString().Trim(); //字段中文详名
objvFieldTabEN.Caption = objRow[convFieldTab.Caption].ToString().Trim(); //标题
objvFieldTabEN.FieldTypeId = objRow[convFieldTab.FieldTypeId] == DBNull.Value ? null : objRow[convFieldTab.FieldTypeId].ToString().Trim(); //字段类型Id
objvFieldTabEN.DataTypeId = objRow[convFieldTab.DataTypeId].ToString().Trim(); //数据类型Id
objvFieldTabEN.DataTypeName = objRow[convFieldTab.DataTypeName].ToString().Trim(); //数据类型名称
objvFieldTabEN.FldLength = TransNullToInt(objRow[convFieldTab.FldLength].ToString().Trim()); //字段长度
objvFieldTabEN.FldPrecision = objRow[convFieldTab.FldPrecision] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFieldTab.FldPrecision].ToString().Trim()); //精确度
objvFieldTabEN.FldInfo = objRow[convFieldTab.FldInfo].ToString().Trim(); //字段信息
objvFieldTabEN.IsNull = TransNullToBool(objRow[convFieldTab.IsNull].ToString().Trim()); //是否可空
objvFieldTabEN.IsPrimaryKey = TransNullToBool(objRow[convFieldTab.IsPrimaryKey].ToString().Trim()); //是否主键
objvFieldTabEN.IsIdentity = TransNullToBool(objRow[convFieldTab.IsIdentity].ToString().Trim()); //是否Identity
objvFieldTabEN.IsChecked = TransNullToBool(objRow[convFieldTab.IsChecked].ToString().Trim()); //是否核实
objvFieldTabEN.IsArchive = TransNullToBool(objRow[convFieldTab.IsArchive].ToString().Trim()); //是否存档
objvFieldTabEN.IsOnlyOne = TransNullToBool(objRow[convFieldTab.IsOnlyOne].ToString().Trim()); //是否唯一
objvFieldTabEN.MaxValue = objRow[convFieldTab.MaxValue].ToString().Trim(); //最大值
objvFieldTabEN.MinValue = objRow[convFieldTab.MinValue].ToString().Trim(); //最小值
objvFieldTabEN.DefaultValue = objRow[convFieldTab.DefaultValue].ToString().Trim(); //缺省值
objvFieldTabEN.FldStateId = objRow[convFieldTab.FldStateId].ToString().Trim(); //字段状态Id
objvFieldTabEN.HomologousFldId = objRow[convFieldTab.HomologousFldId] == DBNull.Value ? null : objRow[convFieldTab.HomologousFldId].ToString().Trim(); //同源字段Id
objvFieldTabEN.PrjId = objRow[convFieldTab.PrjId].ToString().Trim(); //工程Id
objvFieldTabEN.PrjName = objRow[convFieldTab.PrjName].ToString().Trim(); //工程名称
objvFieldTabEN.UpdDate = objRow[convFieldTab.UpdDate] == DBNull.Value ? null : objRow[convFieldTab.UpdDate].ToString().Trim(); //修改日期
objvFieldTabEN.UpdUser = objRow[convFieldTab.UpdUser].ToString().Trim(); //修改者
objvFieldTabEN.Memo = objRow[convFieldTab.Memo] == DBNull.Value ? null : objRow[convFieldTab.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvFieldTabDA: GetObjByDataRowvFieldTab)", objException.Message));
}
objvFieldTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFieldTabEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvFieldTabEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvFieldTabEN objvFieldTabEN = new clsvFieldTabEN();
try
{
objvFieldTabEN.TabNum = objRow[convFieldTab.TabNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFieldTab.TabNum].ToString().Trim()); //表数
objvFieldTabEN.FieldTypeName = objRow[convFieldTab.FieldTypeName] == DBNull.Value ? null : objRow[convFieldTab.FieldTypeName].ToString().Trim(); //字段类型名
objvFieldTabEN.FieldTypeENName = objRow[convFieldTab.FieldTypeENName] == DBNull.Value ? null : objRow[convFieldTab.FieldTypeENName].ToString().Trim(); //字段类型英文名
objvFieldTabEN.OraDbType = objRow[convFieldTab.OraDbType].ToString().Trim(); //Ora数据类型
objvFieldTabEN.IsNeedTransCode = TransNullToBool(objRow[convFieldTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvFieldTabEN.FldId = objRow[convFieldTab.FldId].ToString().Trim(); //字段Id
objvFieldTabEN.FldName = objRow[convFieldTab.FldName].ToString().Trim(); //字段名
objvFieldTabEN.FldCnName = objRow[convFieldTab.FldCnName] == DBNull.Value ? null : objRow[convFieldTab.FldCnName].ToString().Trim(); //字段中文详名
objvFieldTabEN.Caption = objRow[convFieldTab.Caption].ToString().Trim(); //标题
objvFieldTabEN.FieldTypeId = objRow[convFieldTab.FieldTypeId] == DBNull.Value ? null : objRow[convFieldTab.FieldTypeId].ToString().Trim(); //字段类型Id
objvFieldTabEN.DataTypeId = objRow[convFieldTab.DataTypeId].ToString().Trim(); //数据类型Id
objvFieldTabEN.DataTypeName = objRow[convFieldTab.DataTypeName].ToString().Trim(); //数据类型名称
objvFieldTabEN.FldLength = TransNullToInt(objRow[convFieldTab.FldLength].ToString().Trim()); //字段长度
objvFieldTabEN.FldPrecision = objRow[convFieldTab.FldPrecision] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFieldTab.FldPrecision].ToString().Trim()); //精确度
objvFieldTabEN.FldInfo = objRow[convFieldTab.FldInfo].ToString().Trim(); //字段信息
objvFieldTabEN.IsNull = TransNullToBool(objRow[convFieldTab.IsNull].ToString().Trim()); //是否可空
objvFieldTabEN.IsPrimaryKey = TransNullToBool(objRow[convFieldTab.IsPrimaryKey].ToString().Trim()); //是否主键
objvFieldTabEN.IsIdentity = TransNullToBool(objRow[convFieldTab.IsIdentity].ToString().Trim()); //是否Identity
objvFieldTabEN.IsChecked = TransNullToBool(objRow[convFieldTab.IsChecked].ToString().Trim()); //是否核实
objvFieldTabEN.IsArchive = TransNullToBool(objRow[convFieldTab.IsArchive].ToString().Trim()); //是否存档
objvFieldTabEN.IsOnlyOne = TransNullToBool(objRow[convFieldTab.IsOnlyOne].ToString().Trim()); //是否唯一
objvFieldTabEN.MaxValue = objRow[convFieldTab.MaxValue].ToString().Trim(); //最大值
objvFieldTabEN.MinValue = objRow[convFieldTab.MinValue].ToString().Trim(); //最小值
objvFieldTabEN.DefaultValue = objRow[convFieldTab.DefaultValue].ToString().Trim(); //缺省值
objvFieldTabEN.FldStateId = objRow[convFieldTab.FldStateId].ToString().Trim(); //字段状态Id
objvFieldTabEN.HomologousFldId = objRow[convFieldTab.HomologousFldId] == DBNull.Value ? null : objRow[convFieldTab.HomologousFldId].ToString().Trim(); //同源字段Id
objvFieldTabEN.PrjId = objRow[convFieldTab.PrjId].ToString().Trim(); //工程Id
objvFieldTabEN.PrjName = objRow[convFieldTab.PrjName].ToString().Trim(); //工程名称
objvFieldTabEN.UpdDate = objRow[convFieldTab.UpdDate] == DBNull.Value ? null : objRow[convFieldTab.UpdDate].ToString().Trim(); //修改日期
objvFieldTabEN.UpdUser = objRow[convFieldTab.UpdUser].ToString().Trim(); //修改者
objvFieldTabEN.Memo = objRow[convFieldTab.Memo] == DBNull.Value ? null : objRow[convFieldTab.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvFieldTabDA: GetObjByDataRow)", objException.Message));
}
objvFieldTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFieldTabEN;
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
objSQL = clsvFieldTabDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvFieldTabEN._CurrTabName, convFieldTab.FldId, 8, "");
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
objSQL = clsvFieldTabDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvFieldTabEN._CurrTabName, convFieldTab.FldId, 8, strPrefix);
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
 objSQL = clsvFieldTabDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select FldId from vFieldTab where " + strCondition;
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
 objSQL = clsvFieldTabDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select FldId from vFieldTab where " + strCondition;
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
 objSQL = clsvFieldTabDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vFieldTab", "FldId = " + "'"+ strFldId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvFieldTabDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTabDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vFieldTab", strCondition))
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
objSQL = clsvFieldTabDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vFieldTab");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvFieldTabENS">源对象</param>
 /// <param name = "objvFieldTabENT">目标对象</param>
public void CopyTo(clsvFieldTabEN objvFieldTabENS, clsvFieldTabEN objvFieldTabENT)
{
objvFieldTabENT.TabNum = objvFieldTabENS.TabNum; //表数
objvFieldTabENT.FieldTypeName = objvFieldTabENS.FieldTypeName; //字段类型名
objvFieldTabENT.FieldTypeENName = objvFieldTabENS.FieldTypeENName; //字段类型英文名
objvFieldTabENT.OraDbType = objvFieldTabENS.OraDbType; //Ora数据类型
objvFieldTabENT.IsNeedTransCode = objvFieldTabENS.IsNeedTransCode; //是否需要转换代码
objvFieldTabENT.FldId = objvFieldTabENS.FldId; //字段Id
objvFieldTabENT.FldName = objvFieldTabENS.FldName; //字段名
objvFieldTabENT.FldCnName = objvFieldTabENS.FldCnName; //字段中文详名
objvFieldTabENT.Caption = objvFieldTabENS.Caption; //标题
objvFieldTabENT.FieldTypeId = objvFieldTabENS.FieldTypeId; //字段类型Id
objvFieldTabENT.DataTypeId = objvFieldTabENS.DataTypeId; //数据类型Id
objvFieldTabENT.DataTypeName = objvFieldTabENS.DataTypeName; //数据类型名称
objvFieldTabENT.FldLength = objvFieldTabENS.FldLength; //字段长度
objvFieldTabENT.FldPrecision = objvFieldTabENS.FldPrecision; //精确度
objvFieldTabENT.FldInfo = objvFieldTabENS.FldInfo; //字段信息
objvFieldTabENT.IsNull = objvFieldTabENS.IsNull; //是否可空
objvFieldTabENT.IsPrimaryKey = objvFieldTabENS.IsPrimaryKey; //是否主键
objvFieldTabENT.IsIdentity = objvFieldTabENS.IsIdentity; //是否Identity
objvFieldTabENT.IsChecked = objvFieldTabENS.IsChecked; //是否核实
objvFieldTabENT.IsArchive = objvFieldTabENS.IsArchive; //是否存档
objvFieldTabENT.IsOnlyOne = objvFieldTabENS.IsOnlyOne; //是否唯一
objvFieldTabENT.MaxValue = objvFieldTabENS.MaxValue; //最大值
objvFieldTabENT.MinValue = objvFieldTabENS.MinValue; //最小值
objvFieldTabENT.DefaultValue = objvFieldTabENS.DefaultValue; //缺省值
objvFieldTabENT.FldStateId = objvFieldTabENS.FldStateId; //字段状态Id
objvFieldTabENT.HomologousFldId = objvFieldTabENS.HomologousFldId; //同源字段Id
objvFieldTabENT.PrjId = objvFieldTabENS.PrjId; //工程Id
objvFieldTabENT.PrjName = objvFieldTabENS.PrjName; //工程名称
objvFieldTabENT.UpdDate = objvFieldTabENS.UpdDate; //修改日期
objvFieldTabENT.UpdUser = objvFieldTabENS.UpdUser; //修改者
objvFieldTabENT.Memo = objvFieldTabENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvFieldTabEN objvFieldTabEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvFieldTabEN.FieldTypeName, 30, convFieldTab.FieldTypeName);
clsCheckSql.CheckFieldLen(objvFieldTabEN.FieldTypeENName, 30, convFieldTab.FieldTypeENName);
clsCheckSql.CheckFieldLen(objvFieldTabEN.OraDbType, 100, convFieldTab.OraDbType);
clsCheckSql.CheckFieldLen(objvFieldTabEN.FldId, 8, convFieldTab.FldId);
clsCheckSql.CheckFieldLen(objvFieldTabEN.FldName, 50, convFieldTab.FldName);
clsCheckSql.CheckFieldLen(objvFieldTabEN.FldCnName, 200, convFieldTab.FldCnName);
clsCheckSql.CheckFieldLen(objvFieldTabEN.Caption, 200, convFieldTab.Caption);
clsCheckSql.CheckFieldLen(objvFieldTabEN.FieldTypeId, 2, convFieldTab.FieldTypeId);
clsCheckSql.CheckFieldLen(objvFieldTabEN.DataTypeId, 2, convFieldTab.DataTypeId);
clsCheckSql.CheckFieldLen(objvFieldTabEN.DataTypeName, 100, convFieldTab.DataTypeName);
clsCheckSql.CheckFieldLen(objvFieldTabEN.FldInfo, 100, convFieldTab.FldInfo);
clsCheckSql.CheckFieldLen(objvFieldTabEN.MaxValue, 50, convFieldTab.MaxValue);
clsCheckSql.CheckFieldLen(objvFieldTabEN.MinValue, 50, convFieldTab.MinValue);
clsCheckSql.CheckFieldLen(objvFieldTabEN.DefaultValue, 50, convFieldTab.DefaultValue);
clsCheckSql.CheckFieldLen(objvFieldTabEN.FldStateId, 2, convFieldTab.FldStateId);
clsCheckSql.CheckFieldLen(objvFieldTabEN.HomologousFldId, 8, convFieldTab.HomologousFldId);
clsCheckSql.CheckFieldLen(objvFieldTabEN.PrjId, 4, convFieldTab.PrjId);
clsCheckSql.CheckFieldLen(objvFieldTabEN.PrjName, 30, convFieldTab.PrjName);
clsCheckSql.CheckFieldLen(objvFieldTabEN.UpdDate, 20, convFieldTab.UpdDate);
clsCheckSql.CheckFieldLen(objvFieldTabEN.UpdUser, 20, convFieldTab.UpdUser);
clsCheckSql.CheckFieldLen(objvFieldTabEN.Memo, 1000, convFieldTab.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvFieldTabEN.FieldTypeName, convFieldTab.FieldTypeName);
clsCheckSql.CheckSqlInjection4Field(objvFieldTabEN.FieldTypeENName, convFieldTab.FieldTypeENName);
clsCheckSql.CheckSqlInjection4Field(objvFieldTabEN.OraDbType, convFieldTab.OraDbType);
clsCheckSql.CheckSqlInjection4Field(objvFieldTabEN.FldId, convFieldTab.FldId);
clsCheckSql.CheckSqlInjection4Field(objvFieldTabEN.FldName, convFieldTab.FldName);
clsCheckSql.CheckSqlInjection4Field(objvFieldTabEN.FldCnName, convFieldTab.FldCnName);
clsCheckSql.CheckSqlInjection4Field(objvFieldTabEN.Caption, convFieldTab.Caption);
clsCheckSql.CheckSqlInjection4Field(objvFieldTabEN.FieldTypeId, convFieldTab.FieldTypeId);
clsCheckSql.CheckSqlInjection4Field(objvFieldTabEN.DataTypeId, convFieldTab.DataTypeId);
clsCheckSql.CheckSqlInjection4Field(objvFieldTabEN.DataTypeName, convFieldTab.DataTypeName);
clsCheckSql.CheckSqlInjection4Field(objvFieldTabEN.FldInfo, convFieldTab.FldInfo);
clsCheckSql.CheckSqlInjection4Field(objvFieldTabEN.MaxValue, convFieldTab.MaxValue);
clsCheckSql.CheckSqlInjection4Field(objvFieldTabEN.MinValue, convFieldTab.MinValue);
clsCheckSql.CheckSqlInjection4Field(objvFieldTabEN.DefaultValue, convFieldTab.DefaultValue);
clsCheckSql.CheckSqlInjection4Field(objvFieldTabEN.FldStateId, convFieldTab.FldStateId);
clsCheckSql.CheckSqlInjection4Field(objvFieldTabEN.HomologousFldId, convFieldTab.HomologousFldId);
clsCheckSql.CheckSqlInjection4Field(objvFieldTabEN.PrjId, convFieldTab.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvFieldTabEN.PrjName, convFieldTab.PrjName);
clsCheckSql.CheckSqlInjection4Field(objvFieldTabEN.UpdDate, convFieldTab.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvFieldTabEN.UpdUser, convFieldTab.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvFieldTabEN.Memo, convFieldTab.Memo);
//检查外键字段长度
 objvFieldTabEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetFldId()
{
//获取某学院所有专业信息
string strSQL = "select FldId, FldName from vFieldTab ";
 clsSpecSQLforSql mySql = clsvFieldTabDA.GetSpecSQLObj();
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
 objSQL = clsvFieldTabDA.GetSpecSQLObj();
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
 objSQL = clsvFieldTabDA.GetSpecSQLObj();
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
 objSQL = clsvFieldTabDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvFieldTabEN._CurrTabName);
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
 objSQL = clsvFieldTabDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvFieldTabEN._CurrTabName, strCondition);
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
 objSQL = clsvFieldTabDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}