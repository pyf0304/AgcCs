
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFieldTab2DA
 表名:vFieldTab2(00050120)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:12:14
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
 /// vFieldTab2(vFieldTab2)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvFieldTab2DA : clsCommBase4DA
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
 return clsvFieldTab2EN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvFieldTab2EN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvFieldTab2EN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvFieldTab2EN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvFieldTab2EN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vFieldTab2中,检查关键字,长度不正确!(clsvFieldTab2DA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strFldId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vFieldTab2中,关键字不能为空 或 null!(clsvFieldTab2DA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFldId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvFieldTab2DA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvFieldTab2DA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab2DA.GetSpecSQLObj();
strSQL = "Select * from vFieldTab2 where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vFieldTab2(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvFieldTab2DA: GetDataTable_vFieldTab2)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab2DA.GetSpecSQLObj();
strSQL = "Select * from vFieldTab2 where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvFieldTab2DA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab2DA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvFieldTab2DA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab2DA.GetSpecSQLObj();
strSQL = "Select * from vFieldTab2 where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvFieldTab2DA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab2DA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvFieldTab2DA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab2DA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFieldTab2 where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFieldTab2 where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvFieldTab2DA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab2DA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vFieldTab2 where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvFieldTab2DA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab2DA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vFieldTab2.* " + 
$"from vFieldTab2 " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vFieldTab2.FldId not in " + 
$"(Select top {intTop_In} vFieldTab2.FldId from vFieldTab2 " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFieldTab2 where {1} and FldId not in (Select top {2} FldId from vFieldTab2 where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFieldTab2 where {1} and FldId not in (Select top {3} FldId from vFieldTab2 where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvFieldTab2DA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab2DA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vFieldTab2.* " + 
$"from vFieldTab2 " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vFieldTab2.FldId not in " + 
$"(Select top {intTop_In} vFieldTab2.FldId from vFieldTab2 " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFieldTab2 where {1} and FldId not in (Select top {2} FldId from vFieldTab2 where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFieldTab2 where {1} and FldId not in (Select top {3} FldId from vFieldTab2 where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvFieldTab2EN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvFieldTab2DA:GetObjLst)", objException.Message));
}
List<clsvFieldTab2EN> arrObjLst = new List<clsvFieldTab2EN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab2DA.GetSpecSQLObj();
strSQL = "Select * from vFieldTab2 where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFieldTab2EN objvFieldTab2EN = new clsvFieldTab2EN();
try
{
objvFieldTab2EN.DataTypeName = objRow[convFieldTab2.DataTypeName].ToString().Trim(); //数据类型名称
objvFieldTab2EN.FldId = objRow[convFieldTab2.FldId].ToString().Trim(); //字段Id
objvFieldTab2EN.PrjId = objRow[convFieldTab2.PrjId].ToString().Trim(); //工程Id
objvFieldTab2EN.PrjName = objRow[convFieldTab2.PrjName].ToString().Trim(); //工程名称
objvFieldTab2EN.FldName = objRow[convFieldTab2.FldName].ToString().Trim(); //字段名
objvFieldTab2EN.Caption = objRow[convFieldTab2.Caption].ToString().Trim(); //标题
objvFieldTab2EN.FldLength = TransNullToInt(objRow[convFieldTab2.FldLength].ToString().Trim()); //字段长度
objvFieldTab2EN.FldInfo = objRow[convFieldTab2.FldInfo].ToString().Trim(); //字段信息
objvFieldTab2EN.IsNull = TransNullToBool(objRow[convFieldTab2.IsNull].ToString().Trim()); //是否可空
objvFieldTab2EN.IsPrimaryKey = TransNullToBool(objRow[convFieldTab2.IsPrimaryKey].ToString().Trim()); //是否主键
objvFieldTab2EN.IsIdentity = TransNullToBool(objRow[convFieldTab2.IsIdentity].ToString().Trim()); //是否Identity
objvFieldTab2EN.IsChecked = TransNullToBool(objRow[convFieldTab2.IsChecked].ToString().Trim()); //是否核实
objvFieldTab2EN.IsOnlyOne = TransNullToBool(objRow[convFieldTab2.IsOnlyOne].ToString().Trim()); //是否唯一
objvFieldTab2EN.MaxValue = objRow[convFieldTab2.MaxValue].ToString().Trim(); //最大值
objvFieldTab2EN.MinValue = objRow[convFieldTab2.MinValue].ToString().Trim(); //最小值
objvFieldTab2EN.DefaultValue = objRow[convFieldTab2.DefaultValue].ToString().Trim(); //缺省值
objvFieldTab2EN.IsNeedTransCode = TransNullToBool(objRow[convFieldTab2.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvFieldTab2EN.AppliedScope = objRow[convFieldTab2.AppliedScope].ToString().Trim(); //应用范围
objvFieldTab2EN.CodeTabId = objRow[convFieldTab2.CodeTabId] == DBNull.Value ? null : objRow[convFieldTab2.CodeTabId].ToString().Trim(); //代码表Id
objvFieldTab2EN.CodeTabNameId = objRow[convFieldTab2.CodeTabNameId] == DBNull.Value ? null : objRow[convFieldTab2.CodeTabNameId].ToString().Trim(); //代码_名Id
objvFieldTab2EN.CodeTabCodeId = objRow[convFieldTab2.CodeTabCodeId] == DBNull.Value ? null : objRow[convFieldTab2.CodeTabCodeId].ToString().Trim(); //代码Id
objvFieldTab2EN.UpdDate = objRow[convFieldTab2.UpdDate] == DBNull.Value ? null : objRow[convFieldTab2.UpdDate].ToString().Trim(); //修改日期
objvFieldTab2EN.UpdUser = objRow[convFieldTab2.UpdUser].ToString().Trim(); //修改者
objvFieldTab2EN.UserName = objRow[convFieldTab2.UserName] == DBNull.Value ? null : objRow[convFieldTab2.UserName].ToString().Trim(); //用户名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvFieldTab2DA: GetObjLst)", objException.Message));
}
objvFieldTab2EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvFieldTab2EN);
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
public List<clsvFieldTab2EN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvFieldTab2DA:GetObjLstByTabName)", objException.Message));
}
List<clsvFieldTab2EN> arrObjLst = new List<clsvFieldTab2EN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab2DA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFieldTab2EN objvFieldTab2EN = new clsvFieldTab2EN();
try
{
objvFieldTab2EN.DataTypeName = objRow[convFieldTab2.DataTypeName].ToString().Trim(); //数据类型名称
objvFieldTab2EN.FldId = objRow[convFieldTab2.FldId].ToString().Trim(); //字段Id
objvFieldTab2EN.PrjId = objRow[convFieldTab2.PrjId].ToString().Trim(); //工程Id
objvFieldTab2EN.PrjName = objRow[convFieldTab2.PrjName].ToString().Trim(); //工程名称
objvFieldTab2EN.FldName = objRow[convFieldTab2.FldName].ToString().Trim(); //字段名
objvFieldTab2EN.Caption = objRow[convFieldTab2.Caption].ToString().Trim(); //标题
objvFieldTab2EN.FldLength = TransNullToInt(objRow[convFieldTab2.FldLength].ToString().Trim()); //字段长度
objvFieldTab2EN.FldInfo = objRow[convFieldTab2.FldInfo].ToString().Trim(); //字段信息
objvFieldTab2EN.IsNull = TransNullToBool(objRow[convFieldTab2.IsNull].ToString().Trim()); //是否可空
objvFieldTab2EN.IsPrimaryKey = TransNullToBool(objRow[convFieldTab2.IsPrimaryKey].ToString().Trim()); //是否主键
objvFieldTab2EN.IsIdentity = TransNullToBool(objRow[convFieldTab2.IsIdentity].ToString().Trim()); //是否Identity
objvFieldTab2EN.IsChecked = TransNullToBool(objRow[convFieldTab2.IsChecked].ToString().Trim()); //是否核实
objvFieldTab2EN.IsOnlyOne = TransNullToBool(objRow[convFieldTab2.IsOnlyOne].ToString().Trim()); //是否唯一
objvFieldTab2EN.MaxValue = objRow[convFieldTab2.MaxValue].ToString().Trim(); //最大值
objvFieldTab2EN.MinValue = objRow[convFieldTab2.MinValue].ToString().Trim(); //最小值
objvFieldTab2EN.DefaultValue = objRow[convFieldTab2.DefaultValue].ToString().Trim(); //缺省值
objvFieldTab2EN.IsNeedTransCode = TransNullToBool(objRow[convFieldTab2.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvFieldTab2EN.AppliedScope = objRow[convFieldTab2.AppliedScope].ToString().Trim(); //应用范围
objvFieldTab2EN.CodeTabId = objRow[convFieldTab2.CodeTabId] == DBNull.Value ? null : objRow[convFieldTab2.CodeTabId].ToString().Trim(); //代码表Id
objvFieldTab2EN.CodeTabNameId = objRow[convFieldTab2.CodeTabNameId] == DBNull.Value ? null : objRow[convFieldTab2.CodeTabNameId].ToString().Trim(); //代码_名Id
objvFieldTab2EN.CodeTabCodeId = objRow[convFieldTab2.CodeTabCodeId] == DBNull.Value ? null : objRow[convFieldTab2.CodeTabCodeId].ToString().Trim(); //代码Id
objvFieldTab2EN.UpdDate = objRow[convFieldTab2.UpdDate] == DBNull.Value ? null : objRow[convFieldTab2.UpdDate].ToString().Trim(); //修改日期
objvFieldTab2EN.UpdUser = objRow[convFieldTab2.UpdUser].ToString().Trim(); //修改者
objvFieldTab2EN.UserName = objRow[convFieldTab2.UserName] == DBNull.Value ? null : objRow[convFieldTab2.UserName].ToString().Trim(); //用户名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvFieldTab2DA: GetObjLst)", objException.Message));
}
objvFieldTab2EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvFieldTab2EN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvFieldTab2EN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvFieldTab2(ref clsvFieldTab2EN objvFieldTab2EN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab2DA.GetSpecSQLObj();
strSQL = "Select * from vFieldTab2 where FldId = " + "'"+ objvFieldTab2EN.FldId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvFieldTab2EN.DataTypeName = objDT.Rows[0][convFieldTab2.DataTypeName].ToString().Trim(); //数据类型名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvFieldTab2EN.FldId = objDT.Rows[0][convFieldTab2.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objvFieldTab2EN.PrjId = objDT.Rows[0][convFieldTab2.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvFieldTab2EN.PrjName = objDT.Rows[0][convFieldTab2.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvFieldTab2EN.FldName = objDT.Rows[0][convFieldTab2.FldName].ToString().Trim(); //字段名(字段类型:varchar,字段长度:50,是否可空:False)
 objvFieldTab2EN.Caption = objDT.Rows[0][convFieldTab2.Caption].ToString().Trim(); //标题(字段类型:varchar,字段长度:200,是否可空:False)
 objvFieldTab2EN.FldLength = TransNullToInt(objDT.Rows[0][convFieldTab2.FldLength].ToString().Trim()); //字段长度(字段类型:int,字段长度:4,是否可空:False)
 objvFieldTab2EN.FldInfo = objDT.Rows[0][convFieldTab2.FldInfo].ToString().Trim(); //字段信息(字段类型:varchar,字段长度:100,是否可空:True)
 objvFieldTab2EN.IsNull = TransNullToBool(objDT.Rows[0][convFieldTab2.IsNull].ToString().Trim()); //是否可空(字段类型:bit,字段长度:1,是否可空:False)
 objvFieldTab2EN.IsPrimaryKey = TransNullToBool(objDT.Rows[0][convFieldTab2.IsPrimaryKey].ToString().Trim()); //是否主键(字段类型:bit,字段长度:1,是否可空:False)
 objvFieldTab2EN.IsIdentity = TransNullToBool(objDT.Rows[0][convFieldTab2.IsIdentity].ToString().Trim()); //是否Identity(字段类型:bit,字段长度:1,是否可空:True)
 objvFieldTab2EN.IsChecked = TransNullToBool(objDT.Rows[0][convFieldTab2.IsChecked].ToString().Trim()); //是否核实(字段类型:bit,字段长度:1,是否可空:True)
 objvFieldTab2EN.IsOnlyOne = TransNullToBool(objDT.Rows[0][convFieldTab2.IsOnlyOne].ToString().Trim()); //是否唯一(字段类型:bit,字段长度:1,是否可空:True)
 objvFieldTab2EN.MaxValue = objDT.Rows[0][convFieldTab2.MaxValue].ToString().Trim(); //最大值(字段类型:varchar,字段长度:50,是否可空:True)
 objvFieldTab2EN.MinValue = objDT.Rows[0][convFieldTab2.MinValue].ToString().Trim(); //最小值(字段类型:varchar,字段长度:50,是否可空:True)
 objvFieldTab2EN.DefaultValue = objDT.Rows[0][convFieldTab2.DefaultValue].ToString().Trim(); //缺省值(字段类型:varchar,字段长度:50,是否可空:True)
 objvFieldTab2EN.IsNeedTransCode = TransNullToBool(objDT.Rows[0][convFieldTab2.IsNeedTransCode].ToString().Trim()); //是否需要转换代码(字段类型:bit,字段长度:1,是否可空:False)
 objvFieldTab2EN.AppliedScope = objDT.Rows[0][convFieldTab2.AppliedScope].ToString().Trim(); //应用范围(字段类型:varchar,字段长度:10,是否可空:True)
 objvFieldTab2EN.CodeTabId = objDT.Rows[0][convFieldTab2.CodeTabId].ToString().Trim(); //代码表Id(字段类型:char,字段长度:8,是否可空:True)
 objvFieldTab2EN.CodeTabNameId = objDT.Rows[0][convFieldTab2.CodeTabNameId].ToString().Trim(); //代码_名Id(字段类型:char,字段长度:8,是否可空:True)
 objvFieldTab2EN.CodeTabCodeId = objDT.Rows[0][convFieldTab2.CodeTabCodeId].ToString().Trim(); //代码Id(字段类型:char,字段长度:8,是否可空:True)
 objvFieldTab2EN.UpdDate = objDT.Rows[0][convFieldTab2.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvFieldTab2EN.UpdUser = objDT.Rows[0][convFieldTab2.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvFieldTab2EN.UserName = objDT.Rows[0][convFieldTab2.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvFieldTab2DA: GetvFieldTab2)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFldId">表关键字</param>
 /// <returns>表对象</returns>
public clsvFieldTab2EN GetObjByFldId(string strFldId)
{
CheckPrimaryKey(strFldId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab2DA.GetSpecSQLObj();
strSQL = "Select * from vFieldTab2 where FldId = " + "'"+ strFldId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvFieldTab2EN objvFieldTab2EN = new clsvFieldTab2EN();
try
{
 objvFieldTab2EN.DataTypeName = objRow[convFieldTab2.DataTypeName].ToString().Trim(); //数据类型名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvFieldTab2EN.FldId = objRow[convFieldTab2.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objvFieldTab2EN.PrjId = objRow[convFieldTab2.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvFieldTab2EN.PrjName = objRow[convFieldTab2.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvFieldTab2EN.FldName = objRow[convFieldTab2.FldName].ToString().Trim(); //字段名(字段类型:varchar,字段长度:50,是否可空:False)
 objvFieldTab2EN.Caption = objRow[convFieldTab2.Caption].ToString().Trim(); //标题(字段类型:varchar,字段长度:200,是否可空:False)
 objvFieldTab2EN.FldLength = Int32.Parse(objRow[convFieldTab2.FldLength].ToString().Trim()); //字段长度(字段类型:int,字段长度:4,是否可空:False)
 objvFieldTab2EN.FldInfo = objRow[convFieldTab2.FldInfo].ToString().Trim(); //字段信息(字段类型:varchar,字段长度:100,是否可空:True)
 objvFieldTab2EN.IsNull = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsNull].ToString().Trim()); //是否可空(字段类型:bit,字段长度:1,是否可空:False)
 objvFieldTab2EN.IsPrimaryKey = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsPrimaryKey].ToString().Trim()); //是否主键(字段类型:bit,字段长度:1,是否可空:False)
 objvFieldTab2EN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsIdentity].ToString().Trim()); //是否Identity(字段类型:bit,字段长度:1,是否可空:True)
 objvFieldTab2EN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsChecked].ToString().Trim()); //是否核实(字段类型:bit,字段长度:1,是否可空:True)
 objvFieldTab2EN.IsOnlyOne = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsOnlyOne].ToString().Trim()); //是否唯一(字段类型:bit,字段长度:1,是否可空:True)
 objvFieldTab2EN.MaxValue = objRow[convFieldTab2.MaxValue].ToString().Trim(); //最大值(字段类型:varchar,字段长度:50,是否可空:True)
 objvFieldTab2EN.MinValue = objRow[convFieldTab2.MinValue].ToString().Trim(); //最小值(字段类型:varchar,字段长度:50,是否可空:True)
 objvFieldTab2EN.DefaultValue = objRow[convFieldTab2.DefaultValue].ToString().Trim(); //缺省值(字段类型:varchar,字段长度:50,是否可空:True)
 objvFieldTab2EN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsNeedTransCode].ToString().Trim()); //是否需要转换代码(字段类型:bit,字段长度:1,是否可空:False)
 objvFieldTab2EN.AppliedScope = objRow[convFieldTab2.AppliedScope].ToString().Trim(); //应用范围(字段类型:varchar,字段长度:10,是否可空:True)
 objvFieldTab2EN.CodeTabId = objRow[convFieldTab2.CodeTabId] == DBNull.Value ? null : objRow[convFieldTab2.CodeTabId].ToString().Trim(); //代码表Id(字段类型:char,字段长度:8,是否可空:True)
 objvFieldTab2EN.CodeTabNameId = objRow[convFieldTab2.CodeTabNameId] == DBNull.Value ? null : objRow[convFieldTab2.CodeTabNameId].ToString().Trim(); //代码_名Id(字段类型:char,字段长度:8,是否可空:True)
 objvFieldTab2EN.CodeTabCodeId = objRow[convFieldTab2.CodeTabCodeId] == DBNull.Value ? null : objRow[convFieldTab2.CodeTabCodeId].ToString().Trim(); //代码Id(字段类型:char,字段长度:8,是否可空:True)
 objvFieldTab2EN.UpdDate = objRow[convFieldTab2.UpdDate] == DBNull.Value ? null : objRow[convFieldTab2.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvFieldTab2EN.UpdUser = objRow[convFieldTab2.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvFieldTab2EN.UserName = objRow[convFieldTab2.UserName] == DBNull.Value ? null : objRow[convFieldTab2.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvFieldTab2DA: GetObjByFldId)", objException.Message));
}
return objvFieldTab2EN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvFieldTab2EN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvFieldTab2DA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab2DA.GetSpecSQLObj();
strSQL = "Select * from vFieldTab2 where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvFieldTab2EN objvFieldTab2EN = new clsvFieldTab2EN()
{
DataTypeName = objRow[convFieldTab2.DataTypeName].ToString().Trim(), //数据类型名称
FldId = objRow[convFieldTab2.FldId].ToString().Trim(), //字段Id
PrjId = objRow[convFieldTab2.PrjId].ToString().Trim(), //工程Id
PrjName = objRow[convFieldTab2.PrjName].ToString().Trim(), //工程名称
FldName = objRow[convFieldTab2.FldName].ToString().Trim(), //字段名
Caption = objRow[convFieldTab2.Caption].ToString().Trim(), //标题
FldLength = TransNullToInt(objRow[convFieldTab2.FldLength].ToString().Trim()), //字段长度
FldInfo = objRow[convFieldTab2.FldInfo].ToString().Trim(), //字段信息
IsNull = TransNullToBool(objRow[convFieldTab2.IsNull].ToString().Trim()), //是否可空
IsPrimaryKey = TransNullToBool(objRow[convFieldTab2.IsPrimaryKey].ToString().Trim()), //是否主键
IsIdentity = TransNullToBool(objRow[convFieldTab2.IsIdentity].ToString().Trim()), //是否Identity
IsChecked = TransNullToBool(objRow[convFieldTab2.IsChecked].ToString().Trim()), //是否核实
IsOnlyOne = TransNullToBool(objRow[convFieldTab2.IsOnlyOne].ToString().Trim()), //是否唯一
MaxValue = objRow[convFieldTab2.MaxValue].ToString().Trim(), //最大值
MinValue = objRow[convFieldTab2.MinValue].ToString().Trim(), //最小值
DefaultValue = objRow[convFieldTab2.DefaultValue].ToString().Trim(), //缺省值
IsNeedTransCode = TransNullToBool(objRow[convFieldTab2.IsNeedTransCode].ToString().Trim()), //是否需要转换代码
AppliedScope = objRow[convFieldTab2.AppliedScope].ToString().Trim(), //应用范围
CodeTabId = objRow[convFieldTab2.CodeTabId] == DBNull.Value ? null : objRow[convFieldTab2.CodeTabId].ToString().Trim(), //代码表Id
CodeTabNameId = objRow[convFieldTab2.CodeTabNameId] == DBNull.Value ? null : objRow[convFieldTab2.CodeTabNameId].ToString().Trim(), //代码_名Id
CodeTabCodeId = objRow[convFieldTab2.CodeTabCodeId] == DBNull.Value ? null : objRow[convFieldTab2.CodeTabCodeId].ToString().Trim(), //代码Id
UpdDate = objRow[convFieldTab2.UpdDate] == DBNull.Value ? null : objRow[convFieldTab2.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convFieldTab2.UpdUser].ToString().Trim(), //修改者
UserName = objRow[convFieldTab2.UserName] == DBNull.Value ? null : objRow[convFieldTab2.UserName].ToString().Trim() //用户名
};
objvFieldTab2EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFieldTab2EN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvFieldTab2DA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvFieldTab2EN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvFieldTab2EN objvFieldTab2EN = new clsvFieldTab2EN();
try
{
objvFieldTab2EN.DataTypeName = objRow[convFieldTab2.DataTypeName].ToString().Trim(); //数据类型名称
objvFieldTab2EN.FldId = objRow[convFieldTab2.FldId].ToString().Trim(); //字段Id
objvFieldTab2EN.PrjId = objRow[convFieldTab2.PrjId].ToString().Trim(); //工程Id
objvFieldTab2EN.PrjName = objRow[convFieldTab2.PrjName].ToString().Trim(); //工程名称
objvFieldTab2EN.FldName = objRow[convFieldTab2.FldName].ToString().Trim(); //字段名
objvFieldTab2EN.Caption = objRow[convFieldTab2.Caption].ToString().Trim(); //标题
objvFieldTab2EN.FldLength = TransNullToInt(objRow[convFieldTab2.FldLength].ToString().Trim()); //字段长度
objvFieldTab2EN.FldInfo = objRow[convFieldTab2.FldInfo].ToString().Trim(); //字段信息
objvFieldTab2EN.IsNull = TransNullToBool(objRow[convFieldTab2.IsNull].ToString().Trim()); //是否可空
objvFieldTab2EN.IsPrimaryKey = TransNullToBool(objRow[convFieldTab2.IsPrimaryKey].ToString().Trim()); //是否主键
objvFieldTab2EN.IsIdentity = TransNullToBool(objRow[convFieldTab2.IsIdentity].ToString().Trim()); //是否Identity
objvFieldTab2EN.IsChecked = TransNullToBool(objRow[convFieldTab2.IsChecked].ToString().Trim()); //是否核实
objvFieldTab2EN.IsOnlyOne = TransNullToBool(objRow[convFieldTab2.IsOnlyOne].ToString().Trim()); //是否唯一
objvFieldTab2EN.MaxValue = objRow[convFieldTab2.MaxValue].ToString().Trim(); //最大值
objvFieldTab2EN.MinValue = objRow[convFieldTab2.MinValue].ToString().Trim(); //最小值
objvFieldTab2EN.DefaultValue = objRow[convFieldTab2.DefaultValue].ToString().Trim(); //缺省值
objvFieldTab2EN.IsNeedTransCode = TransNullToBool(objRow[convFieldTab2.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvFieldTab2EN.AppliedScope = objRow[convFieldTab2.AppliedScope].ToString().Trim(); //应用范围
objvFieldTab2EN.CodeTabId = objRow[convFieldTab2.CodeTabId] == DBNull.Value ? null : objRow[convFieldTab2.CodeTabId].ToString().Trim(); //代码表Id
objvFieldTab2EN.CodeTabNameId = objRow[convFieldTab2.CodeTabNameId] == DBNull.Value ? null : objRow[convFieldTab2.CodeTabNameId].ToString().Trim(); //代码_名Id
objvFieldTab2EN.CodeTabCodeId = objRow[convFieldTab2.CodeTabCodeId] == DBNull.Value ? null : objRow[convFieldTab2.CodeTabCodeId].ToString().Trim(); //代码Id
objvFieldTab2EN.UpdDate = objRow[convFieldTab2.UpdDate] == DBNull.Value ? null : objRow[convFieldTab2.UpdDate].ToString().Trim(); //修改日期
objvFieldTab2EN.UpdUser = objRow[convFieldTab2.UpdUser].ToString().Trim(); //修改者
objvFieldTab2EN.UserName = objRow[convFieldTab2.UserName] == DBNull.Value ? null : objRow[convFieldTab2.UserName].ToString().Trim(); //用户名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvFieldTab2DA: GetObjByDataRowvFieldTab2)", objException.Message));
}
objvFieldTab2EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFieldTab2EN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvFieldTab2EN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvFieldTab2EN objvFieldTab2EN = new clsvFieldTab2EN();
try
{
objvFieldTab2EN.DataTypeName = objRow[convFieldTab2.DataTypeName].ToString().Trim(); //数据类型名称
objvFieldTab2EN.FldId = objRow[convFieldTab2.FldId].ToString().Trim(); //字段Id
objvFieldTab2EN.PrjId = objRow[convFieldTab2.PrjId].ToString().Trim(); //工程Id
objvFieldTab2EN.PrjName = objRow[convFieldTab2.PrjName].ToString().Trim(); //工程名称
objvFieldTab2EN.FldName = objRow[convFieldTab2.FldName].ToString().Trim(); //字段名
objvFieldTab2EN.Caption = objRow[convFieldTab2.Caption].ToString().Trim(); //标题
objvFieldTab2EN.FldLength = TransNullToInt(objRow[convFieldTab2.FldLength].ToString().Trim()); //字段长度
objvFieldTab2EN.FldInfo = objRow[convFieldTab2.FldInfo].ToString().Trim(); //字段信息
objvFieldTab2EN.IsNull = TransNullToBool(objRow[convFieldTab2.IsNull].ToString().Trim()); //是否可空
objvFieldTab2EN.IsPrimaryKey = TransNullToBool(objRow[convFieldTab2.IsPrimaryKey].ToString().Trim()); //是否主键
objvFieldTab2EN.IsIdentity = TransNullToBool(objRow[convFieldTab2.IsIdentity].ToString().Trim()); //是否Identity
objvFieldTab2EN.IsChecked = TransNullToBool(objRow[convFieldTab2.IsChecked].ToString().Trim()); //是否核实
objvFieldTab2EN.IsOnlyOne = TransNullToBool(objRow[convFieldTab2.IsOnlyOne].ToString().Trim()); //是否唯一
objvFieldTab2EN.MaxValue = objRow[convFieldTab2.MaxValue].ToString().Trim(); //最大值
objvFieldTab2EN.MinValue = objRow[convFieldTab2.MinValue].ToString().Trim(); //最小值
objvFieldTab2EN.DefaultValue = objRow[convFieldTab2.DefaultValue].ToString().Trim(); //缺省值
objvFieldTab2EN.IsNeedTransCode = TransNullToBool(objRow[convFieldTab2.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvFieldTab2EN.AppliedScope = objRow[convFieldTab2.AppliedScope].ToString().Trim(); //应用范围
objvFieldTab2EN.CodeTabId = objRow[convFieldTab2.CodeTabId] == DBNull.Value ? null : objRow[convFieldTab2.CodeTabId].ToString().Trim(); //代码表Id
objvFieldTab2EN.CodeTabNameId = objRow[convFieldTab2.CodeTabNameId] == DBNull.Value ? null : objRow[convFieldTab2.CodeTabNameId].ToString().Trim(); //代码_名Id
objvFieldTab2EN.CodeTabCodeId = objRow[convFieldTab2.CodeTabCodeId] == DBNull.Value ? null : objRow[convFieldTab2.CodeTabCodeId].ToString().Trim(); //代码Id
objvFieldTab2EN.UpdDate = objRow[convFieldTab2.UpdDate] == DBNull.Value ? null : objRow[convFieldTab2.UpdDate].ToString().Trim(); //修改日期
objvFieldTab2EN.UpdUser = objRow[convFieldTab2.UpdUser].ToString().Trim(); //修改者
objvFieldTab2EN.UserName = objRow[convFieldTab2.UserName] == DBNull.Value ? null : objRow[convFieldTab2.UserName].ToString().Trim(); //用户名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvFieldTab2DA: GetObjByDataRow)", objException.Message));
}
objvFieldTab2EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFieldTab2EN;
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
objSQL = clsvFieldTab2DA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvFieldTab2EN._CurrTabName, convFieldTab2.FldId, 8, "");
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
objSQL = clsvFieldTab2DA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvFieldTab2EN._CurrTabName, convFieldTab2.FldId, 8, strPrefix);
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
 objSQL = clsvFieldTab2DA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select FldId from vFieldTab2 where " + strCondition;
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
 objSQL = clsvFieldTab2DA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select FldId from vFieldTab2 where " + strCondition;
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
 objSQL = clsvFieldTab2DA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vFieldTab2", "FldId = " + "'"+ strFldId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvFieldTab2DA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab2DA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vFieldTab2", strCondition))
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
objSQL = clsvFieldTab2DA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vFieldTab2");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvFieldTab2ENS">源对象</param>
 /// <param name = "objvFieldTab2ENT">目标对象</param>
public void CopyTo(clsvFieldTab2EN objvFieldTab2ENS, clsvFieldTab2EN objvFieldTab2ENT)
{
objvFieldTab2ENT.DataTypeName = objvFieldTab2ENS.DataTypeName; //数据类型名称
objvFieldTab2ENT.FldId = objvFieldTab2ENS.FldId; //字段Id
objvFieldTab2ENT.PrjId = objvFieldTab2ENS.PrjId; //工程Id
objvFieldTab2ENT.PrjName = objvFieldTab2ENS.PrjName; //工程名称
objvFieldTab2ENT.FldName = objvFieldTab2ENS.FldName; //字段名
objvFieldTab2ENT.Caption = objvFieldTab2ENS.Caption; //标题
objvFieldTab2ENT.FldLength = objvFieldTab2ENS.FldLength; //字段长度
objvFieldTab2ENT.FldInfo = objvFieldTab2ENS.FldInfo; //字段信息
objvFieldTab2ENT.IsNull = objvFieldTab2ENS.IsNull; //是否可空
objvFieldTab2ENT.IsPrimaryKey = objvFieldTab2ENS.IsPrimaryKey; //是否主键
objvFieldTab2ENT.IsIdentity = objvFieldTab2ENS.IsIdentity; //是否Identity
objvFieldTab2ENT.IsChecked = objvFieldTab2ENS.IsChecked; //是否核实
objvFieldTab2ENT.IsOnlyOne = objvFieldTab2ENS.IsOnlyOne; //是否唯一
objvFieldTab2ENT.MaxValue = objvFieldTab2ENS.MaxValue; //最大值
objvFieldTab2ENT.MinValue = objvFieldTab2ENS.MinValue; //最小值
objvFieldTab2ENT.DefaultValue = objvFieldTab2ENS.DefaultValue; //缺省值
objvFieldTab2ENT.IsNeedTransCode = objvFieldTab2ENS.IsNeedTransCode; //是否需要转换代码
objvFieldTab2ENT.AppliedScope = objvFieldTab2ENS.AppliedScope; //应用范围
objvFieldTab2ENT.CodeTabId = objvFieldTab2ENS.CodeTabId; //代码表Id
objvFieldTab2ENT.CodeTabNameId = objvFieldTab2ENS.CodeTabNameId; //代码_名Id
objvFieldTab2ENT.CodeTabCodeId = objvFieldTab2ENS.CodeTabCodeId; //代码Id
objvFieldTab2ENT.UpdDate = objvFieldTab2ENS.UpdDate; //修改日期
objvFieldTab2ENT.UpdUser = objvFieldTab2ENS.UpdUser; //修改者
objvFieldTab2ENT.UserName = objvFieldTab2ENS.UserName; //用户名
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvFieldTab2EN objvFieldTab2EN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvFieldTab2EN.DataTypeName, 100, convFieldTab2.DataTypeName);
clsCheckSql.CheckFieldLen(objvFieldTab2EN.FldId, 8, convFieldTab2.FldId);
clsCheckSql.CheckFieldLen(objvFieldTab2EN.PrjId, 4, convFieldTab2.PrjId);
clsCheckSql.CheckFieldLen(objvFieldTab2EN.PrjName, 30, convFieldTab2.PrjName);
clsCheckSql.CheckFieldLen(objvFieldTab2EN.FldName, 50, convFieldTab2.FldName);
clsCheckSql.CheckFieldLen(objvFieldTab2EN.Caption, 200, convFieldTab2.Caption);
clsCheckSql.CheckFieldLen(objvFieldTab2EN.FldInfo, 100, convFieldTab2.FldInfo);
clsCheckSql.CheckFieldLen(objvFieldTab2EN.MaxValue, 50, convFieldTab2.MaxValue);
clsCheckSql.CheckFieldLen(objvFieldTab2EN.MinValue, 50, convFieldTab2.MinValue);
clsCheckSql.CheckFieldLen(objvFieldTab2EN.DefaultValue, 50, convFieldTab2.DefaultValue);
clsCheckSql.CheckFieldLen(objvFieldTab2EN.AppliedScope, 10, convFieldTab2.AppliedScope);
clsCheckSql.CheckFieldLen(objvFieldTab2EN.CodeTabId, 8, convFieldTab2.CodeTabId);
clsCheckSql.CheckFieldLen(objvFieldTab2EN.CodeTabNameId, 8, convFieldTab2.CodeTabNameId);
clsCheckSql.CheckFieldLen(objvFieldTab2EN.CodeTabCodeId, 8, convFieldTab2.CodeTabCodeId);
clsCheckSql.CheckFieldLen(objvFieldTab2EN.UpdDate, 20, convFieldTab2.UpdDate);
clsCheckSql.CheckFieldLen(objvFieldTab2EN.UpdUser, 20, convFieldTab2.UpdUser);
clsCheckSql.CheckFieldLen(objvFieldTab2EN.UserName, 30, convFieldTab2.UserName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvFieldTab2EN.DataTypeName, convFieldTab2.DataTypeName);
clsCheckSql.CheckSqlInjection4Field(objvFieldTab2EN.FldId, convFieldTab2.FldId);
clsCheckSql.CheckSqlInjection4Field(objvFieldTab2EN.PrjId, convFieldTab2.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvFieldTab2EN.PrjName, convFieldTab2.PrjName);
clsCheckSql.CheckSqlInjection4Field(objvFieldTab2EN.FldName, convFieldTab2.FldName);
clsCheckSql.CheckSqlInjection4Field(objvFieldTab2EN.Caption, convFieldTab2.Caption);
clsCheckSql.CheckSqlInjection4Field(objvFieldTab2EN.FldInfo, convFieldTab2.FldInfo);
clsCheckSql.CheckSqlInjection4Field(objvFieldTab2EN.MaxValue, convFieldTab2.MaxValue);
clsCheckSql.CheckSqlInjection4Field(objvFieldTab2EN.MinValue, convFieldTab2.MinValue);
clsCheckSql.CheckSqlInjection4Field(objvFieldTab2EN.DefaultValue, convFieldTab2.DefaultValue);
clsCheckSql.CheckSqlInjection4Field(objvFieldTab2EN.AppliedScope, convFieldTab2.AppliedScope);
clsCheckSql.CheckSqlInjection4Field(objvFieldTab2EN.CodeTabId, convFieldTab2.CodeTabId);
clsCheckSql.CheckSqlInjection4Field(objvFieldTab2EN.CodeTabNameId, convFieldTab2.CodeTabNameId);
clsCheckSql.CheckSqlInjection4Field(objvFieldTab2EN.CodeTabCodeId, convFieldTab2.CodeTabCodeId);
clsCheckSql.CheckSqlInjection4Field(objvFieldTab2EN.UpdDate, convFieldTab2.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvFieldTab2EN.UpdUser, convFieldTab2.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvFieldTab2EN.UserName, convFieldTab2.UserName);
//检查外键字段长度
 objvFieldTab2EN._IsCheckProperty = true;
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
 objSQL = clsvFieldTab2DA.GetSpecSQLObj();
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
 objSQL = clsvFieldTab2DA.GetSpecSQLObj();
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
 objSQL = clsvFieldTab2DA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvFieldTab2EN._CurrTabName);
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
 objSQL = clsvFieldTab2DA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvFieldTab2EN._CurrTabName, strCondition);
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
 objSQL = clsvFieldTab2DA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}