
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFieldTabDA
 表名:FieldTab(00050021)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:27:08
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
 /// 工程字段(FieldTab)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsFieldTabDA : clsCommBase4DA
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
 return clsFieldTabEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsFieldTabEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsFieldTabEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsFieldTabEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsFieldTabEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:FieldTab中,检查关键字,长度不正确!(clsFieldTabDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strFldId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:FieldTab中,关键字不能为空 或 null!(clsFieldTabDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFldId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsFieldTabDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsFieldTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTabDA.GetSpecSQLObj();
strSQL = "Select * from FieldTab where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_FieldTab(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsFieldTabDA: GetDataTable_FieldTab)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTabDA.GetSpecSQLObj();
strSQL = "Select * from FieldTab where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsFieldTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTabDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsFieldTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTabDA.GetSpecSQLObj();
strSQL = "Select * from FieldTab where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsFieldTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTabDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsFieldTabDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTabDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FieldTab where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FieldTab where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsFieldTabDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTabDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from FieldTab where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsFieldTabDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTabDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} FieldTab.* " + 
$"from FieldTab " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and FieldTab.FldId not in " + 
$"(Select top {intTop_In} FieldTab.FldId from FieldTab " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FieldTab where {1} and FldId not in (Select top {2} FldId from FieldTab where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FieldTab where {1} and FldId not in (Select top {3} FldId from FieldTab where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsFieldTabDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTabDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} FieldTab.* " + 
$"from FieldTab " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and FieldTab.FldId not in " + 
$"(Select top {intTop_In} FieldTab.FldId from FieldTab " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FieldTab where {1} and FldId not in (Select top {2} FldId from FieldTab where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FieldTab where {1} and FldId not in (Select top {3} FldId from FieldTab where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsFieldTabEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsFieldTabDA:GetObjLst)", objException.Message));
}
List<clsFieldTabEN> arrObjLst = new List<clsFieldTabEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTabDA.GetSpecSQLObj();
strSQL = "Select * from FieldTab where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFieldTabEN objFieldTabEN = new clsFieldTabEN();
try
{
objFieldTabEN.FldId = objRow[conFieldTab.FldId].ToString().Trim(); //字段Id
objFieldTabEN.FldName = objRow[conFieldTab.FldName].ToString().Trim(); //字段名
objFieldTabEN.FldCnName = objRow[conFieldTab.FldCnName] == DBNull.Value ? null : objRow[conFieldTab.FldCnName].ToString().Trim(); //字段中文详名
objFieldTabEN.Caption = objRow[conFieldTab.Caption].ToString().Trim(); //标题
objFieldTabEN.FieldTypeId = objRow[conFieldTab.FieldTypeId] == DBNull.Value ? null : objRow[conFieldTab.FieldTypeId].ToString().Trim(); //字段类型Id
objFieldTabEN.DataTypeId = objRow[conFieldTab.DataTypeId].ToString().Trim(); //数据类型Id
objFieldTabEN.FldLength = TransNullToInt(objRow[conFieldTab.FldLength].ToString().Trim()); //字段长度
objFieldTabEN.FldPrecision = objRow[conFieldTab.FldPrecision] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFieldTab.FldPrecision].ToString().Trim()); //精确度
objFieldTabEN.FldInfo = objRow[conFieldTab.FldInfo] == DBNull.Value ? null : objRow[conFieldTab.FldInfo].ToString().Trim(); //字段信息
objFieldTabEN.IsNull = TransNullToBool(objRow[conFieldTab.IsNull].ToString().Trim()); //是否可空
objFieldTabEN.IsPrimaryKey = TransNullToBool(objRow[conFieldTab.IsPrimaryKey].ToString().Trim()); //是否主键
objFieldTabEN.IsIdentity = TransNullToBool(objRow[conFieldTab.IsIdentity].ToString().Trim()); //是否Identity
objFieldTabEN.IsChecked = TransNullToBool(objRow[conFieldTab.IsChecked].ToString().Trim()); //是否核实
objFieldTabEN.IsArchive = TransNullToBool(objRow[conFieldTab.IsArchive].ToString().Trim()); //是否存档
objFieldTabEN.IsOnlyOne = TransNullToBool(objRow[conFieldTab.IsOnlyOne].ToString().Trim()); //是否唯一
objFieldTabEN.MaxValue = objRow[conFieldTab.MaxValue] == DBNull.Value ? null : objRow[conFieldTab.MaxValue].ToString().Trim(); //最大值
objFieldTabEN.MinValue = objRow[conFieldTab.MinValue] == DBNull.Value ? null : objRow[conFieldTab.MinValue].ToString().Trim(); //最小值
objFieldTabEN.DefaultValue = objRow[conFieldTab.DefaultValue] == DBNull.Value ? null : objRow[conFieldTab.DefaultValue].ToString().Trim(); //缺省值
objFieldTabEN.FldStateId = objRow[conFieldTab.FldStateId].ToString().Trim(); //字段状态Id
objFieldTabEN.HomologousFldId = objRow[conFieldTab.HomologousFldId] == DBNull.Value ? null : objRow[conFieldTab.HomologousFldId].ToString().Trim(); //同源字段Id
objFieldTabEN.TabNum = objRow[conFieldTab.TabNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFieldTab.TabNum].ToString().Trim()); //表数
objFieldTabEN.InUse = TransNullToBool(objRow[conFieldTab.InUse].ToString().Trim()); //是否在用
objFieldTabEN.PrjId = objRow[conFieldTab.PrjId].ToString().Trim(); //工程Id
objFieldTabEN.UpdDate = objRow[conFieldTab.UpdDate].ToString().Trim(); //修改日期
objFieldTabEN.UpdUser = objRow[conFieldTab.UpdUser] == DBNull.Value ? null : objRow[conFieldTab.UpdUser].ToString().Trim(); //修改者
objFieldTabEN.Memo = objRow[conFieldTab.Memo] == DBNull.Value ? null : objRow[conFieldTab.Memo].ToString().Trim(); //说明
objFieldTabEN.IsNeedTransCode = TransNullToBool(objRow[conFieldTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsFieldTabDA: GetObjLst)", objException.Message));
}
objFieldTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objFieldTabEN);
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
public List<clsFieldTabEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsFieldTabDA:GetObjLstByTabName)", objException.Message));
}
List<clsFieldTabEN> arrObjLst = new List<clsFieldTabEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTabDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFieldTabEN objFieldTabEN = new clsFieldTabEN();
try
{
objFieldTabEN.FldId = objRow[conFieldTab.FldId].ToString().Trim(); //字段Id
objFieldTabEN.FldName = objRow[conFieldTab.FldName].ToString().Trim(); //字段名
objFieldTabEN.FldCnName = objRow[conFieldTab.FldCnName] == DBNull.Value ? null : objRow[conFieldTab.FldCnName].ToString().Trim(); //字段中文详名
objFieldTabEN.Caption = objRow[conFieldTab.Caption].ToString().Trim(); //标题
objFieldTabEN.FieldTypeId = objRow[conFieldTab.FieldTypeId] == DBNull.Value ? null : objRow[conFieldTab.FieldTypeId].ToString().Trim(); //字段类型Id
objFieldTabEN.DataTypeId = objRow[conFieldTab.DataTypeId].ToString().Trim(); //数据类型Id
objFieldTabEN.FldLength = TransNullToInt(objRow[conFieldTab.FldLength].ToString().Trim()); //字段长度
objFieldTabEN.FldPrecision = objRow[conFieldTab.FldPrecision] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFieldTab.FldPrecision].ToString().Trim()); //精确度
objFieldTabEN.FldInfo = objRow[conFieldTab.FldInfo] == DBNull.Value ? null : objRow[conFieldTab.FldInfo].ToString().Trim(); //字段信息
objFieldTabEN.IsNull = TransNullToBool(objRow[conFieldTab.IsNull].ToString().Trim()); //是否可空
objFieldTabEN.IsPrimaryKey = TransNullToBool(objRow[conFieldTab.IsPrimaryKey].ToString().Trim()); //是否主键
objFieldTabEN.IsIdentity = TransNullToBool(objRow[conFieldTab.IsIdentity].ToString().Trim()); //是否Identity
objFieldTabEN.IsChecked = TransNullToBool(objRow[conFieldTab.IsChecked].ToString().Trim()); //是否核实
objFieldTabEN.IsArchive = TransNullToBool(objRow[conFieldTab.IsArchive].ToString().Trim()); //是否存档
objFieldTabEN.IsOnlyOne = TransNullToBool(objRow[conFieldTab.IsOnlyOne].ToString().Trim()); //是否唯一
objFieldTabEN.MaxValue = objRow[conFieldTab.MaxValue] == DBNull.Value ? null : objRow[conFieldTab.MaxValue].ToString().Trim(); //最大值
objFieldTabEN.MinValue = objRow[conFieldTab.MinValue] == DBNull.Value ? null : objRow[conFieldTab.MinValue].ToString().Trim(); //最小值
objFieldTabEN.DefaultValue = objRow[conFieldTab.DefaultValue] == DBNull.Value ? null : objRow[conFieldTab.DefaultValue].ToString().Trim(); //缺省值
objFieldTabEN.FldStateId = objRow[conFieldTab.FldStateId].ToString().Trim(); //字段状态Id
objFieldTabEN.HomologousFldId = objRow[conFieldTab.HomologousFldId] == DBNull.Value ? null : objRow[conFieldTab.HomologousFldId].ToString().Trim(); //同源字段Id
objFieldTabEN.TabNum = objRow[conFieldTab.TabNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFieldTab.TabNum].ToString().Trim()); //表数
objFieldTabEN.InUse = TransNullToBool(objRow[conFieldTab.InUse].ToString().Trim()); //是否在用
objFieldTabEN.PrjId = objRow[conFieldTab.PrjId].ToString().Trim(); //工程Id
objFieldTabEN.UpdDate = objRow[conFieldTab.UpdDate].ToString().Trim(); //修改日期
objFieldTabEN.UpdUser = objRow[conFieldTab.UpdUser] == DBNull.Value ? null : objRow[conFieldTab.UpdUser].ToString().Trim(); //修改者
objFieldTabEN.Memo = objRow[conFieldTab.Memo] == DBNull.Value ? null : objRow[conFieldTab.Memo].ToString().Trim(); //说明
objFieldTabEN.IsNeedTransCode = TransNullToBool(objRow[conFieldTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsFieldTabDA: GetObjLst)", objException.Message));
}
objFieldTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objFieldTabEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objFieldTabEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetFieldTab(ref clsFieldTabEN objFieldTabEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTabDA.GetSpecSQLObj();
strSQL = "Select * from FieldTab where FldId = " + "'"+ objFieldTabEN.FldId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objFieldTabEN.FldId = objDT.Rows[0][conFieldTab.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objFieldTabEN.FldName = objDT.Rows[0][conFieldTab.FldName].ToString().Trim(); //字段名(字段类型:varchar,字段长度:50,是否可空:False)
 objFieldTabEN.FldCnName = objDT.Rows[0][conFieldTab.FldCnName].ToString().Trim(); //字段中文详名(字段类型:varchar,字段长度:200,是否可空:True)
 objFieldTabEN.Caption = objDT.Rows[0][conFieldTab.Caption].ToString().Trim(); //标题(字段类型:varchar,字段长度:200,是否可空:False)
 objFieldTabEN.FieldTypeId = objDT.Rows[0][conFieldTab.FieldTypeId].ToString().Trim(); //字段类型Id(字段类型:char,字段长度:2,是否可空:True)
 objFieldTabEN.DataTypeId = objDT.Rows[0][conFieldTab.DataTypeId].ToString().Trim(); //数据类型Id(字段类型:char,字段长度:2,是否可空:False)
 objFieldTabEN.FldLength = TransNullToInt(objDT.Rows[0][conFieldTab.FldLength].ToString().Trim()); //字段长度(字段类型:int,字段长度:4,是否可空:False)
 objFieldTabEN.FldPrecision = TransNullToInt(objDT.Rows[0][conFieldTab.FldPrecision].ToString().Trim()); //精确度(字段类型:int,字段长度:4,是否可空:True)
 objFieldTabEN.FldInfo = objDT.Rows[0][conFieldTab.FldInfo].ToString().Trim(); //字段信息(字段类型:varchar,字段长度:100,是否可空:True)
 objFieldTabEN.IsNull = TransNullToBool(objDT.Rows[0][conFieldTab.IsNull].ToString().Trim()); //是否可空(字段类型:bit,字段长度:1,是否可空:False)
 objFieldTabEN.IsPrimaryKey = TransNullToBool(objDT.Rows[0][conFieldTab.IsPrimaryKey].ToString().Trim()); //是否主键(字段类型:bit,字段长度:1,是否可空:False)
 objFieldTabEN.IsIdentity = TransNullToBool(objDT.Rows[0][conFieldTab.IsIdentity].ToString().Trim()); //是否Identity(字段类型:bit,字段长度:1,是否可空:True)
 objFieldTabEN.IsChecked = TransNullToBool(objDT.Rows[0][conFieldTab.IsChecked].ToString().Trim()); //是否核实(字段类型:bit,字段长度:1,是否可空:True)
 objFieldTabEN.IsArchive = TransNullToBool(objDT.Rows[0][conFieldTab.IsArchive].ToString().Trim()); //是否存档(字段类型:bit,字段长度:1,是否可空:True)
 objFieldTabEN.IsOnlyOne = TransNullToBool(objDT.Rows[0][conFieldTab.IsOnlyOne].ToString().Trim()); //是否唯一(字段类型:bit,字段长度:1,是否可空:True)
 objFieldTabEN.MaxValue = objDT.Rows[0][conFieldTab.MaxValue].ToString().Trim(); //最大值(字段类型:varchar,字段长度:50,是否可空:True)
 objFieldTabEN.MinValue = objDT.Rows[0][conFieldTab.MinValue].ToString().Trim(); //最小值(字段类型:varchar,字段长度:50,是否可空:True)
 objFieldTabEN.DefaultValue = objDT.Rows[0][conFieldTab.DefaultValue].ToString().Trim(); //缺省值(字段类型:varchar,字段长度:50,是否可空:True)
 objFieldTabEN.FldStateId = objDT.Rows[0][conFieldTab.FldStateId].ToString().Trim(); //字段状态Id(字段类型:char,字段长度:2,是否可空:False)
 objFieldTabEN.HomologousFldId = objDT.Rows[0][conFieldTab.HomologousFldId].ToString().Trim(); //同源字段Id(字段类型:char,字段长度:8,是否可空:False)
 objFieldTabEN.TabNum = TransNullToInt(objDT.Rows[0][conFieldTab.TabNum].ToString().Trim()); //表数(字段类型:int,字段长度:4,是否可空:True)
 objFieldTabEN.InUse = TransNullToBool(objDT.Rows[0][conFieldTab.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objFieldTabEN.PrjId = objDT.Rows[0][conFieldTab.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objFieldTabEN.UpdDate = objDT.Rows[0][conFieldTab.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objFieldTabEN.UpdUser = objDT.Rows[0][conFieldTab.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objFieldTabEN.Memo = objDT.Rows[0][conFieldTab.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objFieldTabEN.IsNeedTransCode = TransNullToBool(objDT.Rows[0][conFieldTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码(字段类型:bit,字段长度:1,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsFieldTabDA: GetFieldTab)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFldId">表关键字</param>
 /// <returns>表对象</returns>
public clsFieldTabEN GetObjByFldId(string strFldId)
{
CheckPrimaryKey(strFldId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTabDA.GetSpecSQLObj();
strSQL = "Select * from FieldTab where FldId = " + "'"+ strFldId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsFieldTabEN objFieldTabEN = new clsFieldTabEN();
try
{
 objFieldTabEN.FldId = objRow[conFieldTab.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objFieldTabEN.FldName = objRow[conFieldTab.FldName].ToString().Trim(); //字段名(字段类型:varchar,字段长度:50,是否可空:False)
 objFieldTabEN.FldCnName = objRow[conFieldTab.FldCnName] == DBNull.Value ? null : objRow[conFieldTab.FldCnName].ToString().Trim(); //字段中文详名(字段类型:varchar,字段长度:200,是否可空:True)
 objFieldTabEN.Caption = objRow[conFieldTab.Caption].ToString().Trim(); //标题(字段类型:varchar,字段长度:200,是否可空:False)
 objFieldTabEN.FieldTypeId = objRow[conFieldTab.FieldTypeId] == DBNull.Value ? null : objRow[conFieldTab.FieldTypeId].ToString().Trim(); //字段类型Id(字段类型:char,字段长度:2,是否可空:True)
 objFieldTabEN.DataTypeId = objRow[conFieldTab.DataTypeId].ToString().Trim(); //数据类型Id(字段类型:char,字段长度:2,是否可空:False)
 objFieldTabEN.FldLength = Int32.Parse(objRow[conFieldTab.FldLength].ToString().Trim()); //字段长度(字段类型:int,字段长度:4,是否可空:False)
 objFieldTabEN.FldPrecision = objRow[conFieldTab.FldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFieldTab.FldPrecision].ToString().Trim()); //精确度(字段类型:int,字段长度:4,是否可空:True)
 objFieldTabEN.FldInfo = objRow[conFieldTab.FldInfo] == DBNull.Value ? null : objRow[conFieldTab.FldInfo].ToString().Trim(); //字段信息(字段类型:varchar,字段长度:100,是否可空:True)
 objFieldTabEN.IsNull = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsNull].ToString().Trim()); //是否可空(字段类型:bit,字段长度:1,是否可空:False)
 objFieldTabEN.IsPrimaryKey = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsPrimaryKey].ToString().Trim()); //是否主键(字段类型:bit,字段长度:1,是否可空:False)
 objFieldTabEN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsIdentity].ToString().Trim()); //是否Identity(字段类型:bit,字段长度:1,是否可空:True)
 objFieldTabEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsChecked].ToString().Trim()); //是否核实(字段类型:bit,字段长度:1,是否可空:True)
 objFieldTabEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsArchive].ToString().Trim()); //是否存档(字段类型:bit,字段长度:1,是否可空:True)
 objFieldTabEN.IsOnlyOne = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsOnlyOne].ToString().Trim()); //是否唯一(字段类型:bit,字段长度:1,是否可空:True)
 objFieldTabEN.MaxValue = objRow[conFieldTab.MaxValue] == DBNull.Value ? null : objRow[conFieldTab.MaxValue].ToString().Trim(); //最大值(字段类型:varchar,字段长度:50,是否可空:True)
 objFieldTabEN.MinValue = objRow[conFieldTab.MinValue] == DBNull.Value ? null : objRow[conFieldTab.MinValue].ToString().Trim(); //最小值(字段类型:varchar,字段长度:50,是否可空:True)
 objFieldTabEN.DefaultValue = objRow[conFieldTab.DefaultValue] == DBNull.Value ? null : objRow[conFieldTab.DefaultValue].ToString().Trim(); //缺省值(字段类型:varchar,字段长度:50,是否可空:True)
 objFieldTabEN.FldStateId = objRow[conFieldTab.FldStateId].ToString().Trim(); //字段状态Id(字段类型:char,字段长度:2,是否可空:False)
 objFieldTabEN.HomologousFldId = objRow[conFieldTab.HomologousFldId] == DBNull.Value ? null : objRow[conFieldTab.HomologousFldId].ToString().Trim(); //同源字段Id(字段类型:char,字段长度:8,是否可空:False)
 objFieldTabEN.TabNum = objRow[conFieldTab.TabNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFieldTab.TabNum].ToString().Trim()); //表数(字段类型:int,字段长度:4,是否可空:True)
 objFieldTabEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objFieldTabEN.PrjId = objRow[conFieldTab.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objFieldTabEN.UpdDate = objRow[conFieldTab.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objFieldTabEN.UpdUser = objRow[conFieldTab.UpdUser] == DBNull.Value ? null : objRow[conFieldTab.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objFieldTabEN.Memo = objRow[conFieldTab.Memo] == DBNull.Value ? null : objRow[conFieldTab.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objFieldTabEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码(字段类型:bit,字段长度:1,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsFieldTabDA: GetObjByFldId)", objException.Message));
}
return objFieldTabEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsFieldTabEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsFieldTabDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTabDA.GetSpecSQLObj();
strSQL = "Select * from FieldTab where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsFieldTabEN objFieldTabEN = new clsFieldTabEN()
{
FldId = objRow[conFieldTab.FldId].ToString().Trim(), //字段Id
FldName = objRow[conFieldTab.FldName].ToString().Trim(), //字段名
FldCnName = objRow[conFieldTab.FldCnName] == DBNull.Value ? null : objRow[conFieldTab.FldCnName].ToString().Trim(), //字段中文详名
Caption = objRow[conFieldTab.Caption].ToString().Trim(), //标题
FieldTypeId = objRow[conFieldTab.FieldTypeId] == DBNull.Value ? null : objRow[conFieldTab.FieldTypeId].ToString().Trim(), //字段类型Id
DataTypeId = objRow[conFieldTab.DataTypeId].ToString().Trim(), //数据类型Id
FldLength = TransNullToInt(objRow[conFieldTab.FldLength].ToString().Trim()), //字段长度
FldPrecision = objRow[conFieldTab.FldPrecision] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFieldTab.FldPrecision].ToString().Trim()), //精确度
FldInfo = objRow[conFieldTab.FldInfo] == DBNull.Value ? null : objRow[conFieldTab.FldInfo].ToString().Trim(), //字段信息
IsNull = TransNullToBool(objRow[conFieldTab.IsNull].ToString().Trim()), //是否可空
IsPrimaryKey = TransNullToBool(objRow[conFieldTab.IsPrimaryKey].ToString().Trim()), //是否主键
IsIdentity = TransNullToBool(objRow[conFieldTab.IsIdentity].ToString().Trim()), //是否Identity
IsChecked = TransNullToBool(objRow[conFieldTab.IsChecked].ToString().Trim()), //是否核实
IsArchive = TransNullToBool(objRow[conFieldTab.IsArchive].ToString().Trim()), //是否存档
IsOnlyOne = TransNullToBool(objRow[conFieldTab.IsOnlyOne].ToString().Trim()), //是否唯一
MaxValue = objRow[conFieldTab.MaxValue] == DBNull.Value ? null : objRow[conFieldTab.MaxValue].ToString().Trim(), //最大值
MinValue = objRow[conFieldTab.MinValue] == DBNull.Value ? null : objRow[conFieldTab.MinValue].ToString().Trim(), //最小值
DefaultValue = objRow[conFieldTab.DefaultValue] == DBNull.Value ? null : objRow[conFieldTab.DefaultValue].ToString().Trim(), //缺省值
FldStateId = objRow[conFieldTab.FldStateId].ToString().Trim(), //字段状态Id
HomologousFldId = objRow[conFieldTab.HomologousFldId] == DBNull.Value ? null : objRow[conFieldTab.HomologousFldId].ToString().Trim(), //同源字段Id
TabNum = objRow[conFieldTab.TabNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFieldTab.TabNum].ToString().Trim()), //表数
InUse = TransNullToBool(objRow[conFieldTab.InUse].ToString().Trim()), //是否在用
PrjId = objRow[conFieldTab.PrjId].ToString().Trim(), //工程Id
UpdDate = objRow[conFieldTab.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conFieldTab.UpdUser] == DBNull.Value ? null : objRow[conFieldTab.UpdUser].ToString().Trim(), //修改者
Memo = objRow[conFieldTab.Memo] == DBNull.Value ? null : objRow[conFieldTab.Memo].ToString().Trim(), //说明
IsNeedTransCode = TransNullToBool(objRow[conFieldTab.IsNeedTransCode].ToString().Trim()) //是否需要转换代码
};
objFieldTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFieldTabEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsFieldTabDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsFieldTabEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsFieldTabEN objFieldTabEN = new clsFieldTabEN();
try
{
objFieldTabEN.FldId = objRow[conFieldTab.FldId].ToString().Trim(); //字段Id
objFieldTabEN.FldName = objRow[conFieldTab.FldName].ToString().Trim(); //字段名
objFieldTabEN.FldCnName = objRow[conFieldTab.FldCnName] == DBNull.Value ? null : objRow[conFieldTab.FldCnName].ToString().Trim(); //字段中文详名
objFieldTabEN.Caption = objRow[conFieldTab.Caption].ToString().Trim(); //标题
objFieldTabEN.FieldTypeId = objRow[conFieldTab.FieldTypeId] == DBNull.Value ? null : objRow[conFieldTab.FieldTypeId].ToString().Trim(); //字段类型Id
objFieldTabEN.DataTypeId = objRow[conFieldTab.DataTypeId].ToString().Trim(); //数据类型Id
objFieldTabEN.FldLength = TransNullToInt(objRow[conFieldTab.FldLength].ToString().Trim()); //字段长度
objFieldTabEN.FldPrecision = objRow[conFieldTab.FldPrecision] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFieldTab.FldPrecision].ToString().Trim()); //精确度
objFieldTabEN.FldInfo = objRow[conFieldTab.FldInfo] == DBNull.Value ? null : objRow[conFieldTab.FldInfo].ToString().Trim(); //字段信息
objFieldTabEN.IsNull = TransNullToBool(objRow[conFieldTab.IsNull].ToString().Trim()); //是否可空
objFieldTabEN.IsPrimaryKey = TransNullToBool(objRow[conFieldTab.IsPrimaryKey].ToString().Trim()); //是否主键
objFieldTabEN.IsIdentity = TransNullToBool(objRow[conFieldTab.IsIdentity].ToString().Trim()); //是否Identity
objFieldTabEN.IsChecked = TransNullToBool(objRow[conFieldTab.IsChecked].ToString().Trim()); //是否核实
objFieldTabEN.IsArchive = TransNullToBool(objRow[conFieldTab.IsArchive].ToString().Trim()); //是否存档
objFieldTabEN.IsOnlyOne = TransNullToBool(objRow[conFieldTab.IsOnlyOne].ToString().Trim()); //是否唯一
objFieldTabEN.MaxValue = objRow[conFieldTab.MaxValue] == DBNull.Value ? null : objRow[conFieldTab.MaxValue].ToString().Trim(); //最大值
objFieldTabEN.MinValue = objRow[conFieldTab.MinValue] == DBNull.Value ? null : objRow[conFieldTab.MinValue].ToString().Trim(); //最小值
objFieldTabEN.DefaultValue = objRow[conFieldTab.DefaultValue] == DBNull.Value ? null : objRow[conFieldTab.DefaultValue].ToString().Trim(); //缺省值
objFieldTabEN.FldStateId = objRow[conFieldTab.FldStateId].ToString().Trim(); //字段状态Id
objFieldTabEN.HomologousFldId = objRow[conFieldTab.HomologousFldId] == DBNull.Value ? null : objRow[conFieldTab.HomologousFldId].ToString().Trim(); //同源字段Id
objFieldTabEN.TabNum = objRow[conFieldTab.TabNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFieldTab.TabNum].ToString().Trim()); //表数
objFieldTabEN.InUse = TransNullToBool(objRow[conFieldTab.InUse].ToString().Trim()); //是否在用
objFieldTabEN.PrjId = objRow[conFieldTab.PrjId].ToString().Trim(); //工程Id
objFieldTabEN.UpdDate = objRow[conFieldTab.UpdDate].ToString().Trim(); //修改日期
objFieldTabEN.UpdUser = objRow[conFieldTab.UpdUser] == DBNull.Value ? null : objRow[conFieldTab.UpdUser].ToString().Trim(); //修改者
objFieldTabEN.Memo = objRow[conFieldTab.Memo] == DBNull.Value ? null : objRow[conFieldTab.Memo].ToString().Trim(); //说明
objFieldTabEN.IsNeedTransCode = TransNullToBool(objRow[conFieldTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsFieldTabDA: GetObjByDataRowFieldTab)", objException.Message));
}
objFieldTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFieldTabEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsFieldTabEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsFieldTabEN objFieldTabEN = new clsFieldTabEN();
try
{
objFieldTabEN.FldId = objRow[conFieldTab.FldId].ToString().Trim(); //字段Id
objFieldTabEN.FldName = objRow[conFieldTab.FldName].ToString().Trim(); //字段名
objFieldTabEN.FldCnName = objRow[conFieldTab.FldCnName] == DBNull.Value ? null : objRow[conFieldTab.FldCnName].ToString().Trim(); //字段中文详名
objFieldTabEN.Caption = objRow[conFieldTab.Caption].ToString().Trim(); //标题
objFieldTabEN.FieldTypeId = objRow[conFieldTab.FieldTypeId] == DBNull.Value ? null : objRow[conFieldTab.FieldTypeId].ToString().Trim(); //字段类型Id
objFieldTabEN.DataTypeId = objRow[conFieldTab.DataTypeId].ToString().Trim(); //数据类型Id
objFieldTabEN.FldLength = TransNullToInt(objRow[conFieldTab.FldLength].ToString().Trim()); //字段长度
objFieldTabEN.FldPrecision = objRow[conFieldTab.FldPrecision] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFieldTab.FldPrecision].ToString().Trim()); //精确度
objFieldTabEN.FldInfo = objRow[conFieldTab.FldInfo] == DBNull.Value ? null : objRow[conFieldTab.FldInfo].ToString().Trim(); //字段信息
objFieldTabEN.IsNull = TransNullToBool(objRow[conFieldTab.IsNull].ToString().Trim()); //是否可空
objFieldTabEN.IsPrimaryKey = TransNullToBool(objRow[conFieldTab.IsPrimaryKey].ToString().Trim()); //是否主键
objFieldTabEN.IsIdentity = TransNullToBool(objRow[conFieldTab.IsIdentity].ToString().Trim()); //是否Identity
objFieldTabEN.IsChecked = TransNullToBool(objRow[conFieldTab.IsChecked].ToString().Trim()); //是否核实
objFieldTabEN.IsArchive = TransNullToBool(objRow[conFieldTab.IsArchive].ToString().Trim()); //是否存档
objFieldTabEN.IsOnlyOne = TransNullToBool(objRow[conFieldTab.IsOnlyOne].ToString().Trim()); //是否唯一
objFieldTabEN.MaxValue = objRow[conFieldTab.MaxValue] == DBNull.Value ? null : objRow[conFieldTab.MaxValue].ToString().Trim(); //最大值
objFieldTabEN.MinValue = objRow[conFieldTab.MinValue] == DBNull.Value ? null : objRow[conFieldTab.MinValue].ToString().Trim(); //最小值
objFieldTabEN.DefaultValue = objRow[conFieldTab.DefaultValue] == DBNull.Value ? null : objRow[conFieldTab.DefaultValue].ToString().Trim(); //缺省值
objFieldTabEN.FldStateId = objRow[conFieldTab.FldStateId].ToString().Trim(); //字段状态Id
objFieldTabEN.HomologousFldId = objRow[conFieldTab.HomologousFldId] == DBNull.Value ? null : objRow[conFieldTab.HomologousFldId].ToString().Trim(); //同源字段Id
objFieldTabEN.TabNum = objRow[conFieldTab.TabNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFieldTab.TabNum].ToString().Trim()); //表数
objFieldTabEN.InUse = TransNullToBool(objRow[conFieldTab.InUse].ToString().Trim()); //是否在用
objFieldTabEN.PrjId = objRow[conFieldTab.PrjId].ToString().Trim(); //工程Id
objFieldTabEN.UpdDate = objRow[conFieldTab.UpdDate].ToString().Trim(); //修改日期
objFieldTabEN.UpdUser = objRow[conFieldTab.UpdUser] == DBNull.Value ? null : objRow[conFieldTab.UpdUser].ToString().Trim(); //修改者
objFieldTabEN.Memo = objRow[conFieldTab.Memo] == DBNull.Value ? null : objRow[conFieldTab.Memo].ToString().Trim(); //说明
objFieldTabEN.IsNeedTransCode = TransNullToBool(objRow[conFieldTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsFieldTabDA: GetObjByDataRow)", objException.Message));
}
objFieldTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFieldTabEN;
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
objSQL = clsFieldTabDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsFieldTabEN._CurrTabName, conFieldTab.FldId, 8, "");
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
objSQL = clsFieldTabDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsFieldTabEN._CurrTabName, conFieldTab.FldId, 8, strPrefix);
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
 objSQL = clsFieldTabDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select FldId from FieldTab where " + strCondition;
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
 objSQL = clsFieldTabDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select FldId from FieldTab where " + strCondition;
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
 objSQL = clsFieldTabDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("FieldTab", "FldId = " + "'"+ strFldId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsFieldTabDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTabDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("FieldTab", strCondition))
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
objSQL = clsFieldTabDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("FieldTab");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsFieldTabEN objFieldTabEN)
 {
 objFieldTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFieldTabEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFieldTabEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTabDA.GetSpecSQLObj();
strSQL = "Select * from FieldTab where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "FieldTab");
objRow = objDS.Tables["FieldTab"].NewRow();
objRow[conFieldTab.FldId] = objFieldTabEN.FldId; //字段Id
objRow[conFieldTab.FldName] = objFieldTabEN.FldName; //字段名
 if (objFieldTabEN.FldCnName !=  "")
 {
objRow[conFieldTab.FldCnName] = objFieldTabEN.FldCnName; //字段中文详名
 }
objRow[conFieldTab.Caption] = objFieldTabEN.Caption; //标题
 if (objFieldTabEN.FieldTypeId !=  "")
 {
objRow[conFieldTab.FieldTypeId] = objFieldTabEN.FieldTypeId; //字段类型Id
 }
objRow[conFieldTab.DataTypeId] = objFieldTabEN.DataTypeId; //数据类型Id
objRow[conFieldTab.FldLength] = objFieldTabEN.FldLength; //字段长度
objRow[conFieldTab.FldPrecision] = objFieldTabEN.FldPrecision; //精确度
 if (objFieldTabEN.FldInfo !=  "")
 {
objRow[conFieldTab.FldInfo] = objFieldTabEN.FldInfo; //字段信息
 }
objRow[conFieldTab.IsNull] = objFieldTabEN.IsNull; //是否可空
objRow[conFieldTab.IsPrimaryKey] = objFieldTabEN.IsPrimaryKey; //是否主键
objRow[conFieldTab.IsIdentity] = objFieldTabEN.IsIdentity; //是否Identity
objRow[conFieldTab.IsChecked] = objFieldTabEN.IsChecked; //是否核实
objRow[conFieldTab.IsArchive] = objFieldTabEN.IsArchive; //是否存档
objRow[conFieldTab.IsOnlyOne] = objFieldTabEN.IsOnlyOne; //是否唯一
 if (objFieldTabEN.MaxValue !=  "")
 {
objRow[conFieldTab.MaxValue] = objFieldTabEN.MaxValue; //最大值
 }
 if (objFieldTabEN.MinValue !=  "")
 {
objRow[conFieldTab.MinValue] = objFieldTabEN.MinValue; //最小值
 }
 if (objFieldTabEN.DefaultValue !=  "")
 {
objRow[conFieldTab.DefaultValue] = objFieldTabEN.DefaultValue; //缺省值
 }
objRow[conFieldTab.FldStateId] = objFieldTabEN.FldStateId; //字段状态Id
 if (objFieldTabEN.HomologousFldId !=  "")
 {
objRow[conFieldTab.HomologousFldId] = objFieldTabEN.HomologousFldId; //同源字段Id
 }
objRow[conFieldTab.TabNum] = objFieldTabEN.TabNum; //表数
objRow[conFieldTab.InUse] = objFieldTabEN.InUse; //是否在用
objRow[conFieldTab.PrjId] = objFieldTabEN.PrjId; //工程Id
objRow[conFieldTab.UpdDate] = objFieldTabEN.UpdDate; //修改日期
 if (objFieldTabEN.UpdUser !=  "")
 {
objRow[conFieldTab.UpdUser] = objFieldTabEN.UpdUser; //修改者
 }
 if (objFieldTabEN.Memo !=  "")
 {
objRow[conFieldTab.Memo] = objFieldTabEN.Memo; //说明
 }
objRow[conFieldTab.IsNeedTransCode] = objFieldTabEN.IsNeedTransCode; //是否需要转换代码
objDS.Tables[clsFieldTabEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsFieldTabEN._CurrTabName);
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
 /// <param name = "objFieldTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsFieldTabEN objFieldTabEN)
{
 objFieldTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFieldTabEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFieldTabEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFieldTabEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab.FldId);
 var strFldId = objFieldTabEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 if (objFieldTabEN.FldName !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab.FldName);
 var strFldName = objFieldTabEN.FldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldName + "'");
 }
 
 if (objFieldTabEN.FldCnName !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab.FldCnName);
 var strFldCnName = objFieldTabEN.FldCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldCnName + "'");
 }
 
 if (objFieldTabEN.Caption !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab.Caption);
 var strCaption = objFieldTabEN.Caption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaption + "'");
 }
 
 if (objFieldTabEN.FieldTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab.FieldTypeId);
 var strFieldTypeId = objFieldTabEN.FieldTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFieldTypeId + "'");
 }
 
 if (objFieldTabEN.DataTypeId  ==  "")
 {
 objFieldTabEN.DataTypeId = null;
 }
 if (objFieldTabEN.DataTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab.DataTypeId);
 var strDataTypeId = objFieldTabEN.DataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conFieldTab.FldLength);
 arrValueListForInsert.Add(objFieldTabEN.FldLength.ToString());
 
 if (objFieldTabEN.FldPrecision !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab.FldPrecision);
 arrValueListForInsert.Add(objFieldTabEN.FldPrecision.ToString());
 }
 
 if (objFieldTabEN.FldInfo !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab.FldInfo);
 var strFldInfo = objFieldTabEN.FldInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldInfo + "'");
 }
 
 arrFieldListForInsert.Add(conFieldTab.IsNull);
 arrValueListForInsert.Add("'" + (objFieldTabEN.IsNull  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conFieldTab.IsPrimaryKey);
 arrValueListForInsert.Add("'" + (objFieldTabEN.IsPrimaryKey  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conFieldTab.IsIdentity);
 arrValueListForInsert.Add("'" + (objFieldTabEN.IsIdentity  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conFieldTab.IsChecked);
 arrValueListForInsert.Add("'" + (objFieldTabEN.IsChecked  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conFieldTab.IsArchive);
 arrValueListForInsert.Add("'" + (objFieldTabEN.IsArchive  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conFieldTab.IsOnlyOne);
 arrValueListForInsert.Add("'" + (objFieldTabEN.IsOnlyOne  ==  false ? "0" : "1") + "'");
 
 if (objFieldTabEN.MaxValue !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab.MaxValue);
 var strMaxValue = objFieldTabEN.MaxValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMaxValue + "'");
 }
 
 if (objFieldTabEN.MinValue !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab.MinValue);
 var strMinValue = objFieldTabEN.MinValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMinValue + "'");
 }
 
 if (objFieldTabEN.DefaultValue !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab.DefaultValue);
 var strDefaultValue = objFieldTabEN.DefaultValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDefaultValue + "'");
 }
 
 if (objFieldTabEN.FldStateId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab.FldStateId);
 var strFldStateId = objFieldTabEN.FldStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldStateId + "'");
 }
 
 if (objFieldTabEN.HomologousFldId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab.HomologousFldId);
 var strHomologousFldId = objFieldTabEN.HomologousFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strHomologousFldId + "'");
 }
 
 if (objFieldTabEN.TabNum !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab.TabNum);
 arrValueListForInsert.Add(objFieldTabEN.TabNum.ToString());
 }
 
 arrFieldListForInsert.Add(conFieldTab.InUse);
 arrValueListForInsert.Add("'" + (objFieldTabEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objFieldTabEN.PrjId  ==  "")
 {
 objFieldTabEN.PrjId = null;
 }
 if (objFieldTabEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab.PrjId);
 var strPrjId = objFieldTabEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objFieldTabEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab.UpdDate);
 var strUpdDate = objFieldTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFieldTabEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab.UpdUser);
 var strUpdUser = objFieldTabEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objFieldTabEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab.Memo);
 var strMemo = objFieldTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 arrFieldListForInsert.Add(conFieldTab.IsNeedTransCode);
 arrValueListForInsert.Add("'" + (objFieldTabEN.IsNeedTransCode  ==  false ? "0" : "1") + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FieldTab");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTabDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objFieldTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsFieldTabEN objFieldTabEN)
{
 objFieldTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFieldTabEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFieldTabEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFieldTabEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab.FldId);
 var strFldId = objFieldTabEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 if (objFieldTabEN.FldName !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab.FldName);
 var strFldName = objFieldTabEN.FldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldName + "'");
 }
 
 if (objFieldTabEN.FldCnName !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab.FldCnName);
 var strFldCnName = objFieldTabEN.FldCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldCnName + "'");
 }
 
 if (objFieldTabEN.Caption !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab.Caption);
 var strCaption = objFieldTabEN.Caption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaption + "'");
 }
 
 if (objFieldTabEN.FieldTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab.FieldTypeId);
 var strFieldTypeId = objFieldTabEN.FieldTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFieldTypeId + "'");
 }
 
 if (objFieldTabEN.DataTypeId  ==  "")
 {
 objFieldTabEN.DataTypeId = null;
 }
 if (objFieldTabEN.DataTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab.DataTypeId);
 var strDataTypeId = objFieldTabEN.DataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conFieldTab.FldLength);
 arrValueListForInsert.Add(objFieldTabEN.FldLength.ToString());
 
 if (objFieldTabEN.FldPrecision !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab.FldPrecision);
 arrValueListForInsert.Add(objFieldTabEN.FldPrecision.ToString());
 }
 
 if (objFieldTabEN.FldInfo !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab.FldInfo);
 var strFldInfo = objFieldTabEN.FldInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldInfo + "'");
 }
 
 arrFieldListForInsert.Add(conFieldTab.IsNull);
 arrValueListForInsert.Add("'" + (objFieldTabEN.IsNull  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conFieldTab.IsPrimaryKey);
 arrValueListForInsert.Add("'" + (objFieldTabEN.IsPrimaryKey  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conFieldTab.IsIdentity);
 arrValueListForInsert.Add("'" + (objFieldTabEN.IsIdentity  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conFieldTab.IsChecked);
 arrValueListForInsert.Add("'" + (objFieldTabEN.IsChecked  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conFieldTab.IsArchive);
 arrValueListForInsert.Add("'" + (objFieldTabEN.IsArchive  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conFieldTab.IsOnlyOne);
 arrValueListForInsert.Add("'" + (objFieldTabEN.IsOnlyOne  ==  false ? "0" : "1") + "'");
 
 if (objFieldTabEN.MaxValue !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab.MaxValue);
 var strMaxValue = objFieldTabEN.MaxValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMaxValue + "'");
 }
 
 if (objFieldTabEN.MinValue !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab.MinValue);
 var strMinValue = objFieldTabEN.MinValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMinValue + "'");
 }
 
 if (objFieldTabEN.DefaultValue !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab.DefaultValue);
 var strDefaultValue = objFieldTabEN.DefaultValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDefaultValue + "'");
 }
 
 if (objFieldTabEN.FldStateId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab.FldStateId);
 var strFldStateId = objFieldTabEN.FldStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldStateId + "'");
 }
 
 if (objFieldTabEN.HomologousFldId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab.HomologousFldId);
 var strHomologousFldId = objFieldTabEN.HomologousFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strHomologousFldId + "'");
 }
 
 if (objFieldTabEN.TabNum !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab.TabNum);
 arrValueListForInsert.Add(objFieldTabEN.TabNum.ToString());
 }
 
 arrFieldListForInsert.Add(conFieldTab.InUse);
 arrValueListForInsert.Add("'" + (objFieldTabEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objFieldTabEN.PrjId  ==  "")
 {
 objFieldTabEN.PrjId = null;
 }
 if (objFieldTabEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab.PrjId);
 var strPrjId = objFieldTabEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objFieldTabEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab.UpdDate);
 var strUpdDate = objFieldTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFieldTabEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab.UpdUser);
 var strUpdUser = objFieldTabEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objFieldTabEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab.Memo);
 var strMemo = objFieldTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 arrFieldListForInsert.Add(conFieldTab.IsNeedTransCode);
 arrValueListForInsert.Add("'" + (objFieldTabEN.IsNeedTransCode  ==  false ? "0" : "1") + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FieldTab");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTabDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objFieldTabEN.FldId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objFieldTabEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsFieldTabEN objFieldTabEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objFieldTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFieldTabEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFieldTabEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFieldTabEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab.FldId);
 var strFldId = objFieldTabEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 if (objFieldTabEN.FldName !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab.FldName);
 var strFldName = objFieldTabEN.FldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldName + "'");
 }
 
 if (objFieldTabEN.FldCnName !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab.FldCnName);
 var strFldCnName = objFieldTabEN.FldCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldCnName + "'");
 }
 
 if (objFieldTabEN.Caption !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab.Caption);
 var strCaption = objFieldTabEN.Caption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaption + "'");
 }
 
 if (objFieldTabEN.FieldTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab.FieldTypeId);
 var strFieldTypeId = objFieldTabEN.FieldTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFieldTypeId + "'");
 }
 
 if (objFieldTabEN.DataTypeId  ==  "")
 {
 objFieldTabEN.DataTypeId = null;
 }
 if (objFieldTabEN.DataTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab.DataTypeId);
 var strDataTypeId = objFieldTabEN.DataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conFieldTab.FldLength);
 arrValueListForInsert.Add(objFieldTabEN.FldLength.ToString());
 
 if (objFieldTabEN.FldPrecision !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab.FldPrecision);
 arrValueListForInsert.Add(objFieldTabEN.FldPrecision.ToString());
 }
 
 if (objFieldTabEN.FldInfo !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab.FldInfo);
 var strFldInfo = objFieldTabEN.FldInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldInfo + "'");
 }
 
 arrFieldListForInsert.Add(conFieldTab.IsNull);
 arrValueListForInsert.Add("'" + (objFieldTabEN.IsNull  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conFieldTab.IsPrimaryKey);
 arrValueListForInsert.Add("'" + (objFieldTabEN.IsPrimaryKey  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conFieldTab.IsIdentity);
 arrValueListForInsert.Add("'" + (objFieldTabEN.IsIdentity  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conFieldTab.IsChecked);
 arrValueListForInsert.Add("'" + (objFieldTabEN.IsChecked  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conFieldTab.IsArchive);
 arrValueListForInsert.Add("'" + (objFieldTabEN.IsArchive  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conFieldTab.IsOnlyOne);
 arrValueListForInsert.Add("'" + (objFieldTabEN.IsOnlyOne  ==  false ? "0" : "1") + "'");
 
 if (objFieldTabEN.MaxValue !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab.MaxValue);
 var strMaxValue = objFieldTabEN.MaxValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMaxValue + "'");
 }
 
 if (objFieldTabEN.MinValue !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab.MinValue);
 var strMinValue = objFieldTabEN.MinValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMinValue + "'");
 }
 
 if (objFieldTabEN.DefaultValue !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab.DefaultValue);
 var strDefaultValue = objFieldTabEN.DefaultValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDefaultValue + "'");
 }
 
 if (objFieldTabEN.FldStateId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab.FldStateId);
 var strFldStateId = objFieldTabEN.FldStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldStateId + "'");
 }
 
 if (objFieldTabEN.HomologousFldId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab.HomologousFldId);
 var strHomologousFldId = objFieldTabEN.HomologousFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strHomologousFldId + "'");
 }
 
 if (objFieldTabEN.TabNum !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab.TabNum);
 arrValueListForInsert.Add(objFieldTabEN.TabNum.ToString());
 }
 
 arrFieldListForInsert.Add(conFieldTab.InUse);
 arrValueListForInsert.Add("'" + (objFieldTabEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objFieldTabEN.PrjId  ==  "")
 {
 objFieldTabEN.PrjId = null;
 }
 if (objFieldTabEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab.PrjId);
 var strPrjId = objFieldTabEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objFieldTabEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab.UpdDate);
 var strUpdDate = objFieldTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFieldTabEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab.UpdUser);
 var strUpdUser = objFieldTabEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objFieldTabEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab.Memo);
 var strMemo = objFieldTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 arrFieldListForInsert.Add(conFieldTab.IsNeedTransCode);
 arrValueListForInsert.Add("'" + (objFieldTabEN.IsNeedTransCode  ==  false ? "0" : "1") + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FieldTab");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTabDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewFieldTabs(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTabDA.GetSpecSQLObj();
strSQL = "Select * from FieldTab where FldId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "FieldTab");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strFldId = oRow[conFieldTab.FldId].ToString().Trim();
if (IsExist(strFldId))
{
 string strResult = "关键字变量值为:" + string.Format("FldId = {0}", strFldId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsFieldTabEN._CurrTabName ].NewRow();
objRow[conFieldTab.FldId] = oRow[conFieldTab.FldId].ToString().Trim(); //字段Id
objRow[conFieldTab.FldName] = oRow[conFieldTab.FldName].ToString().Trim(); //字段名
objRow[conFieldTab.FldCnName] = oRow[conFieldTab.FldCnName].ToString().Trim(); //字段中文详名
objRow[conFieldTab.Caption] = oRow[conFieldTab.Caption].ToString().Trim(); //标题
objRow[conFieldTab.FieldTypeId] = oRow[conFieldTab.FieldTypeId].ToString().Trim(); //字段类型Id
objRow[conFieldTab.DataTypeId] = oRow[conFieldTab.DataTypeId].ToString().Trim(); //数据类型Id
objRow[conFieldTab.FldLength] = oRow[conFieldTab.FldLength].ToString().Trim(); //字段长度
objRow[conFieldTab.FldPrecision] = oRow[conFieldTab.FldPrecision].ToString().Trim(); //精确度
objRow[conFieldTab.FldInfo] = oRow[conFieldTab.FldInfo].ToString().Trim(); //字段信息
objRow[conFieldTab.IsNull] = oRow[conFieldTab.IsNull].ToString().Trim(); //是否可空
objRow[conFieldTab.IsPrimaryKey] = oRow[conFieldTab.IsPrimaryKey].ToString().Trim(); //是否主键
objRow[conFieldTab.IsIdentity] = oRow[conFieldTab.IsIdentity].ToString().Trim(); //是否Identity
objRow[conFieldTab.IsChecked] = oRow[conFieldTab.IsChecked].ToString().Trim(); //是否核实
objRow[conFieldTab.IsArchive] = oRow[conFieldTab.IsArchive].ToString().Trim(); //是否存档
objRow[conFieldTab.IsOnlyOne] = oRow[conFieldTab.IsOnlyOne].ToString().Trim(); //是否唯一
objRow[conFieldTab.MaxValue] = oRow[conFieldTab.MaxValue].ToString().Trim(); //最大值
objRow[conFieldTab.MinValue] = oRow[conFieldTab.MinValue].ToString().Trim(); //最小值
objRow[conFieldTab.DefaultValue] = oRow[conFieldTab.DefaultValue].ToString().Trim(); //缺省值
objRow[conFieldTab.FldStateId] = oRow[conFieldTab.FldStateId].ToString().Trim(); //字段状态Id
objRow[conFieldTab.HomologousFldId] = oRow[conFieldTab.HomologousFldId].ToString().Trim(); //同源字段Id
objRow[conFieldTab.TabNum] = oRow[conFieldTab.TabNum].ToString().Trim(); //表数
objRow[conFieldTab.InUse] = oRow[conFieldTab.InUse].ToString().Trim(); //是否在用
objRow[conFieldTab.PrjId] = oRow[conFieldTab.PrjId].ToString().Trim(); //工程Id
objRow[conFieldTab.UpdDate] = oRow[conFieldTab.UpdDate].ToString().Trim(); //修改日期
objRow[conFieldTab.UpdUser] = oRow[conFieldTab.UpdUser].ToString().Trim(); //修改者
objRow[conFieldTab.Memo] = oRow[conFieldTab.Memo].ToString().Trim(); //说明
objRow[conFieldTab.IsNeedTransCode] = oRow[conFieldTab.IsNeedTransCode].ToString().Trim(); //是否需要转换代码
 objDS.Tables[clsFieldTabEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsFieldTabEN._CurrTabName);
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
 /// <param name = "objFieldTabEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsFieldTabEN objFieldTabEN)
{
 objFieldTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFieldTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFieldTabEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTabDA.GetSpecSQLObj();
strSQL = "Select * from FieldTab where FldId = " + "'"+ objFieldTabEN.FldId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsFieldTabEN._CurrTabName);
if (objDS.Tables[clsFieldTabEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:FldId = " + "'"+ objFieldTabEN.FldId+"'");
return false;
}
objRow = objDS.Tables[clsFieldTabEN._CurrTabName].Rows[0];
 if (objFieldTabEN.IsUpdated(conFieldTab.FldId))
 {
objRow[conFieldTab.FldId] = objFieldTabEN.FldId; //字段Id
 }
 if (objFieldTabEN.IsUpdated(conFieldTab.FldName))
 {
objRow[conFieldTab.FldName] = objFieldTabEN.FldName; //字段名
 }
 if (objFieldTabEN.IsUpdated(conFieldTab.FldCnName))
 {
objRow[conFieldTab.FldCnName] = objFieldTabEN.FldCnName; //字段中文详名
 }
 if (objFieldTabEN.IsUpdated(conFieldTab.Caption))
 {
objRow[conFieldTab.Caption] = objFieldTabEN.Caption; //标题
 }
 if (objFieldTabEN.IsUpdated(conFieldTab.FieldTypeId))
 {
objRow[conFieldTab.FieldTypeId] = objFieldTabEN.FieldTypeId; //字段类型Id
 }
 if (objFieldTabEN.IsUpdated(conFieldTab.DataTypeId))
 {
objRow[conFieldTab.DataTypeId] = objFieldTabEN.DataTypeId; //数据类型Id
 }
 if (objFieldTabEN.IsUpdated(conFieldTab.FldLength))
 {
objRow[conFieldTab.FldLength] = objFieldTabEN.FldLength; //字段长度
 }
 if (objFieldTabEN.IsUpdated(conFieldTab.FldPrecision))
 {
objRow[conFieldTab.FldPrecision] = objFieldTabEN.FldPrecision; //精确度
 }
 if (objFieldTabEN.IsUpdated(conFieldTab.FldInfo))
 {
objRow[conFieldTab.FldInfo] = objFieldTabEN.FldInfo; //字段信息
 }
 if (objFieldTabEN.IsUpdated(conFieldTab.IsNull))
 {
objRow[conFieldTab.IsNull] = objFieldTabEN.IsNull; //是否可空
 }
 if (objFieldTabEN.IsUpdated(conFieldTab.IsPrimaryKey))
 {
objRow[conFieldTab.IsPrimaryKey] = objFieldTabEN.IsPrimaryKey; //是否主键
 }
 if (objFieldTabEN.IsUpdated(conFieldTab.IsIdentity))
 {
objRow[conFieldTab.IsIdentity] = objFieldTabEN.IsIdentity; //是否Identity
 }
 if (objFieldTabEN.IsUpdated(conFieldTab.IsChecked))
 {
objRow[conFieldTab.IsChecked] = objFieldTabEN.IsChecked; //是否核实
 }
 if (objFieldTabEN.IsUpdated(conFieldTab.IsArchive))
 {
objRow[conFieldTab.IsArchive] = objFieldTabEN.IsArchive; //是否存档
 }
 if (objFieldTabEN.IsUpdated(conFieldTab.IsOnlyOne))
 {
objRow[conFieldTab.IsOnlyOne] = objFieldTabEN.IsOnlyOne; //是否唯一
 }
 if (objFieldTabEN.IsUpdated(conFieldTab.MaxValue))
 {
objRow[conFieldTab.MaxValue] = objFieldTabEN.MaxValue; //最大值
 }
 if (objFieldTabEN.IsUpdated(conFieldTab.MinValue))
 {
objRow[conFieldTab.MinValue] = objFieldTabEN.MinValue; //最小值
 }
 if (objFieldTabEN.IsUpdated(conFieldTab.DefaultValue))
 {
objRow[conFieldTab.DefaultValue] = objFieldTabEN.DefaultValue; //缺省值
 }
 if (objFieldTabEN.IsUpdated(conFieldTab.FldStateId))
 {
objRow[conFieldTab.FldStateId] = objFieldTabEN.FldStateId; //字段状态Id
 }
 if (objFieldTabEN.IsUpdated(conFieldTab.HomologousFldId))
 {
objRow[conFieldTab.HomologousFldId] = objFieldTabEN.HomologousFldId; //同源字段Id
 }
 if (objFieldTabEN.IsUpdated(conFieldTab.TabNum))
 {
objRow[conFieldTab.TabNum] = objFieldTabEN.TabNum; //表数
 }
 if (objFieldTabEN.IsUpdated(conFieldTab.InUse))
 {
objRow[conFieldTab.InUse] = objFieldTabEN.InUse; //是否在用
 }
 if (objFieldTabEN.IsUpdated(conFieldTab.PrjId))
 {
objRow[conFieldTab.PrjId] = objFieldTabEN.PrjId; //工程Id
 }
 if (objFieldTabEN.IsUpdated(conFieldTab.UpdDate))
 {
objRow[conFieldTab.UpdDate] = objFieldTabEN.UpdDate; //修改日期
 }
 if (objFieldTabEN.IsUpdated(conFieldTab.UpdUser))
 {
objRow[conFieldTab.UpdUser] = objFieldTabEN.UpdUser; //修改者
 }
 if (objFieldTabEN.IsUpdated(conFieldTab.Memo))
 {
objRow[conFieldTab.Memo] = objFieldTabEN.Memo; //说明
 }
 if (objFieldTabEN.IsUpdated(conFieldTab.IsNeedTransCode))
 {
objRow[conFieldTab.IsNeedTransCode] = objFieldTabEN.IsNeedTransCode; //是否需要转换代码
 }
try
{
objDA.Update(objDS, clsFieldTabEN._CurrTabName);
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
 /// <param name = "objFieldTabEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsFieldTabEN objFieldTabEN)
{
 objFieldTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFieldTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFieldTabEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTabDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update FieldTab Set ");
 
 if (objFieldTabEN.IsUpdated(conFieldTab.FldName))
 {
 if (objFieldTabEN.FldName !=  null)
 {
 var strFldName = objFieldTabEN.FldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldName, conFieldTab.FldName); //字段名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab.FldName); //字段名
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.FldCnName))
 {
 if (objFieldTabEN.FldCnName !=  null)
 {
 var strFldCnName = objFieldTabEN.FldCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldCnName, conFieldTab.FldCnName); //字段中文详名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab.FldCnName); //字段中文详名
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.Caption))
 {
 if (objFieldTabEN.Caption !=  null)
 {
 var strCaption = objFieldTabEN.Caption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaption, conFieldTab.Caption); //标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab.Caption); //标题
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.FieldTypeId))
 {
 if (objFieldTabEN.FieldTypeId !=  null)
 {
 var strFieldTypeId = objFieldTabEN.FieldTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFieldTypeId, conFieldTab.FieldTypeId); //字段类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab.FieldTypeId); //字段类型Id
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.DataTypeId))
 {
 if (objFieldTabEN.DataTypeId  ==  "")
 {
 objFieldTabEN.DataTypeId = null;
 }
 if (objFieldTabEN.DataTypeId !=  null)
 {
 var strDataTypeId = objFieldTabEN.DataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataTypeId, conFieldTab.DataTypeId); //数据类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab.DataTypeId); //数据类型Id
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.FldLength))
 {
 sbSQL.AppendFormat("{1} = {0},",objFieldTabEN.FldLength, conFieldTab.FldLength); //字段长度
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.FldPrecision))
 {
 if (objFieldTabEN.FldPrecision !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFieldTabEN.FldPrecision, conFieldTab.FldPrecision); //精确度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab.FldPrecision); //精确度
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.FldInfo))
 {
 if (objFieldTabEN.FldInfo !=  null)
 {
 var strFldInfo = objFieldTabEN.FldInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldInfo, conFieldTab.FldInfo); //字段信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab.FldInfo); //字段信息
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.IsNull))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFieldTabEN.IsNull == true?"1":"0", conFieldTab.IsNull); //是否可空
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.IsPrimaryKey))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFieldTabEN.IsPrimaryKey == true?"1":"0", conFieldTab.IsPrimaryKey); //是否主键
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.IsIdentity))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFieldTabEN.IsIdentity == true?"1":"0", conFieldTab.IsIdentity); //是否Identity
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.IsChecked))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFieldTabEN.IsChecked == true?"1":"0", conFieldTab.IsChecked); //是否核实
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.IsArchive))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFieldTabEN.IsArchive == true?"1":"0", conFieldTab.IsArchive); //是否存档
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.IsOnlyOne))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFieldTabEN.IsOnlyOne == true?"1":"0", conFieldTab.IsOnlyOne); //是否唯一
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.MaxValue))
 {
 if (objFieldTabEN.MaxValue !=  null)
 {
 var strMaxValue = objFieldTabEN.MaxValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMaxValue, conFieldTab.MaxValue); //最大值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab.MaxValue); //最大值
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.MinValue))
 {
 if (objFieldTabEN.MinValue !=  null)
 {
 var strMinValue = objFieldTabEN.MinValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMinValue, conFieldTab.MinValue); //最小值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab.MinValue); //最小值
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.DefaultValue))
 {
 if (objFieldTabEN.DefaultValue !=  null)
 {
 var strDefaultValue = objFieldTabEN.DefaultValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDefaultValue, conFieldTab.DefaultValue); //缺省值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab.DefaultValue); //缺省值
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.FldStateId))
 {
 if (objFieldTabEN.FldStateId !=  null)
 {
 var strFldStateId = objFieldTabEN.FldStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldStateId, conFieldTab.FldStateId); //字段状态Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab.FldStateId); //字段状态Id
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.HomologousFldId))
 {
 if (objFieldTabEN.HomologousFldId !=  null)
 {
 var strHomologousFldId = objFieldTabEN.HomologousFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strHomologousFldId, conFieldTab.HomologousFldId); //同源字段Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab.HomologousFldId); //同源字段Id
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.TabNum))
 {
 if (objFieldTabEN.TabNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFieldTabEN.TabNum, conFieldTab.TabNum); //表数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab.TabNum); //表数
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFieldTabEN.InUse == true?"1":"0", conFieldTab.InUse); //是否在用
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.PrjId))
 {
 if (objFieldTabEN.PrjId  ==  "")
 {
 objFieldTabEN.PrjId = null;
 }
 if (objFieldTabEN.PrjId !=  null)
 {
 var strPrjId = objFieldTabEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conFieldTab.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab.PrjId); //工程Id
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.UpdDate))
 {
 if (objFieldTabEN.UpdDate !=  null)
 {
 var strUpdDate = objFieldTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conFieldTab.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab.UpdDate); //修改日期
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.UpdUser))
 {
 if (objFieldTabEN.UpdUser !=  null)
 {
 var strUpdUser = objFieldTabEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conFieldTab.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab.UpdUser); //修改者
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.Memo))
 {
 if (objFieldTabEN.Memo !=  null)
 {
 var strMemo = objFieldTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conFieldTab.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab.Memo); //说明
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.IsNeedTransCode))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFieldTabEN.IsNeedTransCode == true?"1":"0", conFieldTab.IsNeedTransCode); //是否需要转换代码
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where FldId = '{0}'", objFieldTabEN.FldId); 
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
 /// <param name = "objFieldTabEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsFieldTabEN objFieldTabEN, string strCondition)
{
 objFieldTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFieldTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFieldTabEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTabDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FieldTab Set ");
 
 if (objFieldTabEN.IsUpdated(conFieldTab.FldName))
 {
 if (objFieldTabEN.FldName !=  null)
 {
 var strFldName = objFieldTabEN.FldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldName = '{0}',", strFldName); //字段名
 }
 else
 {
 sbSQL.Append(" FldName = null,"); //字段名
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.FldCnName))
 {
 if (objFieldTabEN.FldCnName !=  null)
 {
 var strFldCnName = objFieldTabEN.FldCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldCnName = '{0}',", strFldCnName); //字段中文详名
 }
 else
 {
 sbSQL.Append(" FldCnName = null,"); //字段中文详名
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.Caption))
 {
 if (objFieldTabEN.Caption !=  null)
 {
 var strCaption = objFieldTabEN.Caption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Caption = '{0}',", strCaption); //标题
 }
 else
 {
 sbSQL.Append(" Caption = null,"); //标题
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.FieldTypeId))
 {
 if (objFieldTabEN.FieldTypeId !=  null)
 {
 var strFieldTypeId = objFieldTabEN.FieldTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FieldTypeId = '{0}',", strFieldTypeId); //字段类型Id
 }
 else
 {
 sbSQL.Append(" FieldTypeId = null,"); //字段类型Id
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.DataTypeId))
 {
 if (objFieldTabEN.DataTypeId  ==  "")
 {
 objFieldTabEN.DataTypeId = null;
 }
 if (objFieldTabEN.DataTypeId !=  null)
 {
 var strDataTypeId = objFieldTabEN.DataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataTypeId = '{0}',", strDataTypeId); //数据类型Id
 }
 else
 {
 sbSQL.Append(" DataTypeId = null,"); //数据类型Id
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.FldLength))
 {
 sbSQL.AppendFormat(" FldLength = {0},", objFieldTabEN.FldLength); //字段长度
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.FldPrecision))
 {
 if (objFieldTabEN.FldPrecision !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFieldTabEN.FldPrecision, conFieldTab.FldPrecision); //精确度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab.FldPrecision); //精确度
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.FldInfo))
 {
 if (objFieldTabEN.FldInfo !=  null)
 {
 var strFldInfo = objFieldTabEN.FldInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldInfo = '{0}',", strFldInfo); //字段信息
 }
 else
 {
 sbSQL.Append(" FldInfo = null,"); //字段信息
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.IsNull))
 {
 sbSQL.AppendFormat(" IsNull = '{0}',", objFieldTabEN.IsNull == true?"1":"0"); //是否可空
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.IsPrimaryKey))
 {
 sbSQL.AppendFormat(" IsPrimaryKey = '{0}',", objFieldTabEN.IsPrimaryKey == true?"1":"0"); //是否主键
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.IsIdentity))
 {
 sbSQL.AppendFormat(" IsIdentity = '{0}',", objFieldTabEN.IsIdentity == true?"1":"0"); //是否Identity
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.IsChecked))
 {
 sbSQL.AppendFormat(" IsChecked = '{0}',", objFieldTabEN.IsChecked == true?"1":"0"); //是否核实
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.IsArchive))
 {
 sbSQL.AppendFormat(" IsArchive = '{0}',", objFieldTabEN.IsArchive == true?"1":"0"); //是否存档
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.IsOnlyOne))
 {
 sbSQL.AppendFormat(" IsOnlyOne = '{0}',", objFieldTabEN.IsOnlyOne == true?"1":"0"); //是否唯一
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.MaxValue))
 {
 if (objFieldTabEN.MaxValue !=  null)
 {
 var strMaxValue = objFieldTabEN.MaxValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MaxValue = '{0}',", strMaxValue); //最大值
 }
 else
 {
 sbSQL.Append(" MaxValue = null,"); //最大值
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.MinValue))
 {
 if (objFieldTabEN.MinValue !=  null)
 {
 var strMinValue = objFieldTabEN.MinValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MinValue = '{0}',", strMinValue); //最小值
 }
 else
 {
 sbSQL.Append(" MinValue = null,"); //最小值
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.DefaultValue))
 {
 if (objFieldTabEN.DefaultValue !=  null)
 {
 var strDefaultValue = objFieldTabEN.DefaultValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DefaultValue = '{0}',", strDefaultValue); //缺省值
 }
 else
 {
 sbSQL.Append(" DefaultValue = null,"); //缺省值
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.FldStateId))
 {
 if (objFieldTabEN.FldStateId !=  null)
 {
 var strFldStateId = objFieldTabEN.FldStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldStateId = '{0}',", strFldStateId); //字段状态Id
 }
 else
 {
 sbSQL.Append(" FldStateId = null,"); //字段状态Id
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.HomologousFldId))
 {
 if (objFieldTabEN.HomologousFldId !=  null)
 {
 var strHomologousFldId = objFieldTabEN.HomologousFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" HomologousFldId = '{0}',", strHomologousFldId); //同源字段Id
 }
 else
 {
 sbSQL.Append(" HomologousFldId = null,"); //同源字段Id
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.TabNum))
 {
 if (objFieldTabEN.TabNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFieldTabEN.TabNum, conFieldTab.TabNum); //表数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab.TabNum); //表数
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objFieldTabEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.PrjId))
 {
 if (objFieldTabEN.PrjId  ==  "")
 {
 objFieldTabEN.PrjId = null;
 }
 if (objFieldTabEN.PrjId !=  null)
 {
 var strPrjId = objFieldTabEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.UpdDate))
 {
 if (objFieldTabEN.UpdDate !=  null)
 {
 var strUpdDate = objFieldTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.UpdUser))
 {
 if (objFieldTabEN.UpdUser !=  null)
 {
 var strUpdUser = objFieldTabEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.Memo))
 {
 if (objFieldTabEN.Memo !=  null)
 {
 var strMemo = objFieldTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //说明
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //说明
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.IsNeedTransCode))
 {
 sbSQL.AppendFormat(" IsNeedTransCode = '{0}',", objFieldTabEN.IsNeedTransCode == true?"1":"0"); //是否需要转换代码
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
 /// <param name = "objFieldTabEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsFieldTabEN objFieldTabEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objFieldTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFieldTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFieldTabEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTabDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FieldTab Set ");
 
 if (objFieldTabEN.IsUpdated(conFieldTab.FldName))
 {
 if (objFieldTabEN.FldName !=  null)
 {
 var strFldName = objFieldTabEN.FldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldName = '{0}',", strFldName); //字段名
 }
 else
 {
 sbSQL.Append(" FldName = null,"); //字段名
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.FldCnName))
 {
 if (objFieldTabEN.FldCnName !=  null)
 {
 var strFldCnName = objFieldTabEN.FldCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldCnName = '{0}',", strFldCnName); //字段中文详名
 }
 else
 {
 sbSQL.Append(" FldCnName = null,"); //字段中文详名
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.Caption))
 {
 if (objFieldTabEN.Caption !=  null)
 {
 var strCaption = objFieldTabEN.Caption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Caption = '{0}',", strCaption); //标题
 }
 else
 {
 sbSQL.Append(" Caption = null,"); //标题
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.FieldTypeId))
 {
 if (objFieldTabEN.FieldTypeId !=  null)
 {
 var strFieldTypeId = objFieldTabEN.FieldTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FieldTypeId = '{0}',", strFieldTypeId); //字段类型Id
 }
 else
 {
 sbSQL.Append(" FieldTypeId = null,"); //字段类型Id
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.DataTypeId))
 {
 if (objFieldTabEN.DataTypeId  ==  "")
 {
 objFieldTabEN.DataTypeId = null;
 }
 if (objFieldTabEN.DataTypeId !=  null)
 {
 var strDataTypeId = objFieldTabEN.DataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataTypeId = '{0}',", strDataTypeId); //数据类型Id
 }
 else
 {
 sbSQL.Append(" DataTypeId = null,"); //数据类型Id
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.FldLength))
 {
 sbSQL.AppendFormat(" FldLength = {0},", objFieldTabEN.FldLength); //字段长度
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.FldPrecision))
 {
 if (objFieldTabEN.FldPrecision !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFieldTabEN.FldPrecision, conFieldTab.FldPrecision); //精确度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab.FldPrecision); //精确度
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.FldInfo))
 {
 if (objFieldTabEN.FldInfo !=  null)
 {
 var strFldInfo = objFieldTabEN.FldInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldInfo = '{0}',", strFldInfo); //字段信息
 }
 else
 {
 sbSQL.Append(" FldInfo = null,"); //字段信息
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.IsNull))
 {
 sbSQL.AppendFormat(" IsNull = '{0}',", objFieldTabEN.IsNull == true?"1":"0"); //是否可空
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.IsPrimaryKey))
 {
 sbSQL.AppendFormat(" IsPrimaryKey = '{0}',", objFieldTabEN.IsPrimaryKey == true?"1":"0"); //是否主键
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.IsIdentity))
 {
 sbSQL.AppendFormat(" IsIdentity = '{0}',", objFieldTabEN.IsIdentity == true?"1":"0"); //是否Identity
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.IsChecked))
 {
 sbSQL.AppendFormat(" IsChecked = '{0}',", objFieldTabEN.IsChecked == true?"1":"0"); //是否核实
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.IsArchive))
 {
 sbSQL.AppendFormat(" IsArchive = '{0}',", objFieldTabEN.IsArchive == true?"1":"0"); //是否存档
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.IsOnlyOne))
 {
 sbSQL.AppendFormat(" IsOnlyOne = '{0}',", objFieldTabEN.IsOnlyOne == true?"1":"0"); //是否唯一
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.MaxValue))
 {
 if (objFieldTabEN.MaxValue !=  null)
 {
 var strMaxValue = objFieldTabEN.MaxValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MaxValue = '{0}',", strMaxValue); //最大值
 }
 else
 {
 sbSQL.Append(" MaxValue = null,"); //最大值
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.MinValue))
 {
 if (objFieldTabEN.MinValue !=  null)
 {
 var strMinValue = objFieldTabEN.MinValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MinValue = '{0}',", strMinValue); //最小值
 }
 else
 {
 sbSQL.Append(" MinValue = null,"); //最小值
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.DefaultValue))
 {
 if (objFieldTabEN.DefaultValue !=  null)
 {
 var strDefaultValue = objFieldTabEN.DefaultValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DefaultValue = '{0}',", strDefaultValue); //缺省值
 }
 else
 {
 sbSQL.Append(" DefaultValue = null,"); //缺省值
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.FldStateId))
 {
 if (objFieldTabEN.FldStateId !=  null)
 {
 var strFldStateId = objFieldTabEN.FldStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldStateId = '{0}',", strFldStateId); //字段状态Id
 }
 else
 {
 sbSQL.Append(" FldStateId = null,"); //字段状态Id
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.HomologousFldId))
 {
 if (objFieldTabEN.HomologousFldId !=  null)
 {
 var strHomologousFldId = objFieldTabEN.HomologousFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" HomologousFldId = '{0}',", strHomologousFldId); //同源字段Id
 }
 else
 {
 sbSQL.Append(" HomologousFldId = null,"); //同源字段Id
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.TabNum))
 {
 if (objFieldTabEN.TabNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFieldTabEN.TabNum, conFieldTab.TabNum); //表数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab.TabNum); //表数
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objFieldTabEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.PrjId))
 {
 if (objFieldTabEN.PrjId  ==  "")
 {
 objFieldTabEN.PrjId = null;
 }
 if (objFieldTabEN.PrjId !=  null)
 {
 var strPrjId = objFieldTabEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.UpdDate))
 {
 if (objFieldTabEN.UpdDate !=  null)
 {
 var strUpdDate = objFieldTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.UpdUser))
 {
 if (objFieldTabEN.UpdUser !=  null)
 {
 var strUpdUser = objFieldTabEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.Memo))
 {
 if (objFieldTabEN.Memo !=  null)
 {
 var strMemo = objFieldTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //说明
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //说明
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.IsNeedTransCode))
 {
 sbSQL.AppendFormat(" IsNeedTransCode = '{0}',", objFieldTabEN.IsNeedTransCode == true?"1":"0"); //是否需要转换代码
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
 /// <param name = "objFieldTabEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsFieldTabEN objFieldTabEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objFieldTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFieldTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFieldTabEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTabDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FieldTab Set ");
 
 if (objFieldTabEN.IsUpdated(conFieldTab.FldName))
 {
 if (objFieldTabEN.FldName !=  null)
 {
 var strFldName = objFieldTabEN.FldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldName, conFieldTab.FldName); //字段名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab.FldName); //字段名
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.FldCnName))
 {
 if (objFieldTabEN.FldCnName !=  null)
 {
 var strFldCnName = objFieldTabEN.FldCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldCnName, conFieldTab.FldCnName); //字段中文详名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab.FldCnName); //字段中文详名
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.Caption))
 {
 if (objFieldTabEN.Caption !=  null)
 {
 var strCaption = objFieldTabEN.Caption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaption, conFieldTab.Caption); //标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab.Caption); //标题
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.FieldTypeId))
 {
 if (objFieldTabEN.FieldTypeId !=  null)
 {
 var strFieldTypeId = objFieldTabEN.FieldTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFieldTypeId, conFieldTab.FieldTypeId); //字段类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab.FieldTypeId); //字段类型Id
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.DataTypeId))
 {
 if (objFieldTabEN.DataTypeId  ==  "")
 {
 objFieldTabEN.DataTypeId = null;
 }
 if (objFieldTabEN.DataTypeId !=  null)
 {
 var strDataTypeId = objFieldTabEN.DataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataTypeId, conFieldTab.DataTypeId); //数据类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab.DataTypeId); //数据类型Id
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.FldLength))
 {
 sbSQL.AppendFormat("{1} = {0},",objFieldTabEN.FldLength, conFieldTab.FldLength); //字段长度
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.FldPrecision))
 {
 if (objFieldTabEN.FldPrecision !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFieldTabEN.FldPrecision, conFieldTab.FldPrecision); //精确度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab.FldPrecision); //精确度
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.FldInfo))
 {
 if (objFieldTabEN.FldInfo !=  null)
 {
 var strFldInfo = objFieldTabEN.FldInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldInfo, conFieldTab.FldInfo); //字段信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab.FldInfo); //字段信息
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.IsNull))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFieldTabEN.IsNull == true?"1":"0", conFieldTab.IsNull); //是否可空
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.IsPrimaryKey))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFieldTabEN.IsPrimaryKey == true?"1":"0", conFieldTab.IsPrimaryKey); //是否主键
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.IsIdentity))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFieldTabEN.IsIdentity == true?"1":"0", conFieldTab.IsIdentity); //是否Identity
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.IsChecked))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFieldTabEN.IsChecked == true?"1":"0", conFieldTab.IsChecked); //是否核实
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.IsArchive))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFieldTabEN.IsArchive == true?"1":"0", conFieldTab.IsArchive); //是否存档
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.IsOnlyOne))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFieldTabEN.IsOnlyOne == true?"1":"0", conFieldTab.IsOnlyOne); //是否唯一
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.MaxValue))
 {
 if (objFieldTabEN.MaxValue !=  null)
 {
 var strMaxValue = objFieldTabEN.MaxValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMaxValue, conFieldTab.MaxValue); //最大值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab.MaxValue); //最大值
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.MinValue))
 {
 if (objFieldTabEN.MinValue !=  null)
 {
 var strMinValue = objFieldTabEN.MinValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMinValue, conFieldTab.MinValue); //最小值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab.MinValue); //最小值
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.DefaultValue))
 {
 if (objFieldTabEN.DefaultValue !=  null)
 {
 var strDefaultValue = objFieldTabEN.DefaultValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDefaultValue, conFieldTab.DefaultValue); //缺省值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab.DefaultValue); //缺省值
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.FldStateId))
 {
 if (objFieldTabEN.FldStateId !=  null)
 {
 var strFldStateId = objFieldTabEN.FldStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldStateId, conFieldTab.FldStateId); //字段状态Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab.FldStateId); //字段状态Id
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.HomologousFldId))
 {
 if (objFieldTabEN.HomologousFldId !=  null)
 {
 var strHomologousFldId = objFieldTabEN.HomologousFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strHomologousFldId, conFieldTab.HomologousFldId); //同源字段Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab.HomologousFldId); //同源字段Id
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.TabNum))
 {
 if (objFieldTabEN.TabNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFieldTabEN.TabNum, conFieldTab.TabNum); //表数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab.TabNum); //表数
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFieldTabEN.InUse == true?"1":"0", conFieldTab.InUse); //是否在用
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.PrjId))
 {
 if (objFieldTabEN.PrjId  ==  "")
 {
 objFieldTabEN.PrjId = null;
 }
 if (objFieldTabEN.PrjId !=  null)
 {
 var strPrjId = objFieldTabEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conFieldTab.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab.PrjId); //工程Id
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.UpdDate))
 {
 if (objFieldTabEN.UpdDate !=  null)
 {
 var strUpdDate = objFieldTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conFieldTab.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab.UpdDate); //修改日期
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.UpdUser))
 {
 if (objFieldTabEN.UpdUser !=  null)
 {
 var strUpdUser = objFieldTabEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conFieldTab.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab.UpdUser); //修改者
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.Memo))
 {
 if (objFieldTabEN.Memo !=  null)
 {
 var strMemo = objFieldTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conFieldTab.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab.Memo); //说明
 }
 }
 
 if (objFieldTabEN.IsUpdated(conFieldTab.IsNeedTransCode))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFieldTabEN.IsNeedTransCode == true?"1":"0", conFieldTab.IsNeedTransCode); //是否需要转换代码
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where FldId = '{0}'", objFieldTabEN.FldId); 
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
 /// <param name = "strFldId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strFldId) 
{
CheckPrimaryKey(strFldId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTabDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strFldId,
};
 objSQL.ExecSP("FieldTab_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strFldId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strFldId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strFldId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTabDA.GetSpecSQLObj();
//删除FieldTab本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FieldTab where FldId = " + "'"+ strFldId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelFieldTab(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTabDA.GetSpecSQLObj();
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
//删除FieldTab本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FieldTab where FldId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strFldId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strFldId) 
{
CheckPrimaryKey(strFldId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTabDA.GetSpecSQLObj();
//删除FieldTab本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FieldTab where FldId = " + "'"+ strFldId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelFieldTab(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsFieldTabDA: DelFieldTab)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTabDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from FieldTab where " + strCondition ;
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
public bool DelFieldTabWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsFieldTabDA: DelFieldTabWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTabDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from FieldTab where " + strCondition ;
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
 /// <param name = "objFieldTabENS">源对象</param>
 /// <param name = "objFieldTabENT">目标对象</param>
public void CopyTo(clsFieldTabEN objFieldTabENS, clsFieldTabEN objFieldTabENT)
{
objFieldTabENT.FldId = objFieldTabENS.FldId; //字段Id
objFieldTabENT.FldName = objFieldTabENS.FldName; //字段名
objFieldTabENT.FldCnName = objFieldTabENS.FldCnName; //字段中文详名
objFieldTabENT.Caption = objFieldTabENS.Caption; //标题
objFieldTabENT.FieldTypeId = objFieldTabENS.FieldTypeId; //字段类型Id
objFieldTabENT.DataTypeId = objFieldTabENS.DataTypeId; //数据类型Id
objFieldTabENT.FldLength = objFieldTabENS.FldLength; //字段长度
objFieldTabENT.FldPrecision = objFieldTabENS.FldPrecision; //精确度
objFieldTabENT.FldInfo = objFieldTabENS.FldInfo; //字段信息
objFieldTabENT.IsNull = objFieldTabENS.IsNull; //是否可空
objFieldTabENT.IsPrimaryKey = objFieldTabENS.IsPrimaryKey; //是否主键
objFieldTabENT.IsIdentity = objFieldTabENS.IsIdentity; //是否Identity
objFieldTabENT.IsChecked = objFieldTabENS.IsChecked; //是否核实
objFieldTabENT.IsArchive = objFieldTabENS.IsArchive; //是否存档
objFieldTabENT.IsOnlyOne = objFieldTabENS.IsOnlyOne; //是否唯一
objFieldTabENT.MaxValue = objFieldTabENS.MaxValue; //最大值
objFieldTabENT.MinValue = objFieldTabENS.MinValue; //最小值
objFieldTabENT.DefaultValue = objFieldTabENS.DefaultValue; //缺省值
objFieldTabENT.FldStateId = objFieldTabENS.FldStateId; //字段状态Id
objFieldTabENT.HomologousFldId = objFieldTabENS.HomologousFldId; //同源字段Id
objFieldTabENT.TabNum = objFieldTabENS.TabNum; //表数
objFieldTabENT.InUse = objFieldTabENS.InUse; //是否在用
objFieldTabENT.PrjId = objFieldTabENS.PrjId; //工程Id
objFieldTabENT.UpdDate = objFieldTabENS.UpdDate; //修改日期
objFieldTabENT.UpdUser = objFieldTabENS.UpdUser; //修改者
objFieldTabENT.Memo = objFieldTabENS.Memo; //说明
objFieldTabENT.IsNeedTransCode = objFieldTabENS.IsNeedTransCode; //是否需要转换代码
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsFieldTabEN objFieldTabEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objFieldTabEN.FldName, conFieldTab.FldName);
clsCheckSql.CheckFieldNotNull(objFieldTabEN.Caption, conFieldTab.Caption);
clsCheckSql.CheckFieldNotNull(objFieldTabEN.DataTypeId, conFieldTab.DataTypeId);
clsCheckSql.CheckFieldNotNull(objFieldTabEN.FldLength, conFieldTab.FldLength);
clsCheckSql.CheckFieldNotNull(objFieldTabEN.IsNull, conFieldTab.IsNull);
clsCheckSql.CheckFieldNotNull(objFieldTabEN.IsPrimaryKey, conFieldTab.IsPrimaryKey);
clsCheckSql.CheckFieldNotNull(objFieldTabEN.FldStateId, conFieldTab.FldStateId);
clsCheckSql.CheckFieldNotNull(objFieldTabEN.InUse, conFieldTab.InUse);
clsCheckSql.CheckFieldNotNull(objFieldTabEN.PrjId, conFieldTab.PrjId);
clsCheckSql.CheckFieldNotNull(objFieldTabEN.UpdDate, conFieldTab.UpdDate);
//检查字段长度
clsCheckSql.CheckFieldLen(objFieldTabEN.FldId, 8, conFieldTab.FldId);
clsCheckSql.CheckFieldLen(objFieldTabEN.FldName, 50, conFieldTab.FldName);
clsCheckSql.CheckFieldLen(objFieldTabEN.FldCnName, 200, conFieldTab.FldCnName);
clsCheckSql.CheckFieldLen(objFieldTabEN.Caption, 200, conFieldTab.Caption);
clsCheckSql.CheckFieldLen(objFieldTabEN.FieldTypeId, 2, conFieldTab.FieldTypeId);
clsCheckSql.CheckFieldLen(objFieldTabEN.DataTypeId, 2, conFieldTab.DataTypeId);
clsCheckSql.CheckFieldLen(objFieldTabEN.FldInfo, 100, conFieldTab.FldInfo);
clsCheckSql.CheckFieldLen(objFieldTabEN.MaxValue, 50, conFieldTab.MaxValue);
clsCheckSql.CheckFieldLen(objFieldTabEN.MinValue, 50, conFieldTab.MinValue);
clsCheckSql.CheckFieldLen(objFieldTabEN.DefaultValue, 50, conFieldTab.DefaultValue);
clsCheckSql.CheckFieldLen(objFieldTabEN.FldStateId, 2, conFieldTab.FldStateId);
clsCheckSql.CheckFieldLen(objFieldTabEN.HomologousFldId, 8, conFieldTab.HomologousFldId);
clsCheckSql.CheckFieldLen(objFieldTabEN.PrjId, 4, conFieldTab.PrjId);
clsCheckSql.CheckFieldLen(objFieldTabEN.UpdDate, 20, conFieldTab.UpdDate);
clsCheckSql.CheckFieldLen(objFieldTabEN.UpdUser, 20, conFieldTab.UpdUser);
clsCheckSql.CheckFieldLen(objFieldTabEN.Memo, 1000, conFieldTab.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objFieldTabEN.DataTypeId, 2, conFieldTab.DataTypeId);
clsCheckSql.CheckFieldForeignKey(objFieldTabEN.PrjId, 4, conFieldTab.PrjId);
 objFieldTabEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsFieldTabEN objFieldTabEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objFieldTabEN.FldName, 50, conFieldTab.FldName);
clsCheckSql.CheckFieldLen(objFieldTabEN.FldCnName, 200, conFieldTab.FldCnName);
clsCheckSql.CheckFieldLen(objFieldTabEN.Caption, 200, conFieldTab.Caption);
clsCheckSql.CheckFieldLen(objFieldTabEN.FieldTypeId, 2, conFieldTab.FieldTypeId);
clsCheckSql.CheckFieldLen(objFieldTabEN.DataTypeId, 2, conFieldTab.DataTypeId);
clsCheckSql.CheckFieldLen(objFieldTabEN.FldInfo, 100, conFieldTab.FldInfo);
clsCheckSql.CheckFieldLen(objFieldTabEN.MaxValue, 50, conFieldTab.MaxValue);
clsCheckSql.CheckFieldLen(objFieldTabEN.MinValue, 50, conFieldTab.MinValue);
clsCheckSql.CheckFieldLen(objFieldTabEN.DefaultValue, 50, conFieldTab.DefaultValue);
clsCheckSql.CheckFieldLen(objFieldTabEN.FldStateId, 2, conFieldTab.FldStateId);
clsCheckSql.CheckFieldLen(objFieldTabEN.HomologousFldId, 8, conFieldTab.HomologousFldId);
clsCheckSql.CheckFieldLen(objFieldTabEN.PrjId, 4, conFieldTab.PrjId);
clsCheckSql.CheckFieldLen(objFieldTabEN.UpdDate, 20, conFieldTab.UpdDate);
clsCheckSql.CheckFieldLen(objFieldTabEN.UpdUser, 20, conFieldTab.UpdUser);
clsCheckSql.CheckFieldLen(objFieldTabEN.Memo, 1000, conFieldTab.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objFieldTabEN.DataTypeId, 2, conFieldTab.DataTypeId);
clsCheckSql.CheckFieldForeignKey(objFieldTabEN.PrjId, 4, conFieldTab.PrjId);
 objFieldTabEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsFieldTabEN objFieldTabEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objFieldTabEN.FldId, 8, conFieldTab.FldId);
clsCheckSql.CheckFieldLen(objFieldTabEN.FldName, 50, conFieldTab.FldName);
clsCheckSql.CheckFieldLen(objFieldTabEN.FldCnName, 200, conFieldTab.FldCnName);
clsCheckSql.CheckFieldLen(objFieldTabEN.Caption, 200, conFieldTab.Caption);
clsCheckSql.CheckFieldLen(objFieldTabEN.FieldTypeId, 2, conFieldTab.FieldTypeId);
clsCheckSql.CheckFieldLen(objFieldTabEN.DataTypeId, 2, conFieldTab.DataTypeId);
clsCheckSql.CheckFieldLen(objFieldTabEN.FldInfo, 100, conFieldTab.FldInfo);
clsCheckSql.CheckFieldLen(objFieldTabEN.MaxValue, 50, conFieldTab.MaxValue);
clsCheckSql.CheckFieldLen(objFieldTabEN.MinValue, 50, conFieldTab.MinValue);
clsCheckSql.CheckFieldLen(objFieldTabEN.DefaultValue, 50, conFieldTab.DefaultValue);
clsCheckSql.CheckFieldLen(objFieldTabEN.FldStateId, 2, conFieldTab.FldStateId);
clsCheckSql.CheckFieldLen(objFieldTabEN.HomologousFldId, 8, conFieldTab.HomologousFldId);
clsCheckSql.CheckFieldLen(objFieldTabEN.PrjId, 4, conFieldTab.PrjId);
clsCheckSql.CheckFieldLen(objFieldTabEN.UpdDate, 20, conFieldTab.UpdDate);
clsCheckSql.CheckFieldLen(objFieldTabEN.UpdUser, 20, conFieldTab.UpdUser);
clsCheckSql.CheckFieldLen(objFieldTabEN.Memo, 1000, conFieldTab.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objFieldTabEN.FldId, conFieldTab.FldId);
clsCheckSql.CheckSqlInjection4Field(objFieldTabEN.FldName, conFieldTab.FldName);
clsCheckSql.CheckSqlInjection4Field(objFieldTabEN.FldCnName, conFieldTab.FldCnName);
clsCheckSql.CheckSqlInjection4Field(objFieldTabEN.Caption, conFieldTab.Caption);
clsCheckSql.CheckSqlInjection4Field(objFieldTabEN.FieldTypeId, conFieldTab.FieldTypeId);
clsCheckSql.CheckSqlInjection4Field(objFieldTabEN.DataTypeId, conFieldTab.DataTypeId);
clsCheckSql.CheckSqlInjection4Field(objFieldTabEN.FldInfo, conFieldTab.FldInfo);
clsCheckSql.CheckSqlInjection4Field(objFieldTabEN.MaxValue, conFieldTab.MaxValue);
clsCheckSql.CheckSqlInjection4Field(objFieldTabEN.MinValue, conFieldTab.MinValue);
clsCheckSql.CheckSqlInjection4Field(objFieldTabEN.DefaultValue, conFieldTab.DefaultValue);
clsCheckSql.CheckSqlInjection4Field(objFieldTabEN.FldStateId, conFieldTab.FldStateId);
clsCheckSql.CheckSqlInjection4Field(objFieldTabEN.HomologousFldId, conFieldTab.HomologousFldId);
clsCheckSql.CheckSqlInjection4Field(objFieldTabEN.PrjId, conFieldTab.PrjId);
clsCheckSql.CheckSqlInjection4Field(objFieldTabEN.UpdDate, conFieldTab.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objFieldTabEN.UpdUser, conFieldTab.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objFieldTabEN.Memo, conFieldTab.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objFieldTabEN.DataTypeId, 2, conFieldTab.DataTypeId);
clsCheckSql.CheckFieldForeignKey(objFieldTabEN.PrjId, 4, conFieldTab.PrjId);
 objFieldTabEN._IsCheckProperty = true;
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
string strSQL = "select FldId, FldName from FieldTab ";
 clsSpecSQLforSql mySql = clsFieldTabDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--FieldTab(工程字段),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objFieldTabEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsFieldTabEN objFieldTabEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FldName = '{0}'", objFieldTabEN.FldName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objFieldTabEN.PrjId);
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
 objSQL = clsFieldTabDA.GetSpecSQLObj();
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
 objSQL = clsFieldTabDA.GetSpecSQLObj();
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
 objSQL = clsFieldTabDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsFieldTabEN._CurrTabName);
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
 objSQL = clsFieldTabDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsFieldTabEN._CurrTabName, strCondition);
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
 objSQL = clsFieldTabDA.GetSpecSQLObj();
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
 objSQL = clsFieldTabDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}