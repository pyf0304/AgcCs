
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCTRelationTypeDA
 表名:CTRelationType(00050645)
 * 版本:2026.05.30(服务器:PYF-AI)
 日期:2026/06/16 22:27:33
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
 /// CT关系类型(CTRelationType)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsCTRelationTypeDA : clsCommBase4DA
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
 return clsCTRelationTypeEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsCTRelationTypeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCTRelationTypeEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsCTRelationTypeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsCTRelationTypeEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strCtRelationTypeId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strCtRelationTypeId)
{
strCtRelationTypeId = strCtRelationTypeId.Replace("'", "''");
if (strCtRelationTypeId.Length > 2)
{
throw new Exception("(errid:Data000001)在表:CTRelationType中,检查关键字,长度不正确!(clsCTRelationTypeDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strCtRelationTypeId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:CTRelationType中,关键字不能为空 或 null!(clsCTRelationTypeDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCtRelationTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsCTRelationTypeDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsCTRelationTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTRelationTypeDA.GetSpecSQLObj();
strSQL = "Select * from CTRelationType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_CTRelationType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsCTRelationTypeDA: GetDataTable_CTRelationType)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTRelationTypeDA.GetSpecSQLObj();
strSQL = "Select * from CTRelationType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsCTRelationTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTRelationTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsCTRelationTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTRelationTypeDA.GetSpecSQLObj();
strSQL = "Select * from CTRelationType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsCTRelationTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTRelationTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsCTRelationTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTRelationTypeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CTRelationType where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CTRelationType where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsCTRelationTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTRelationTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from CTRelationType where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsCTRelationTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTRelationTypeDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} CTRelationType.* " + 
$"from CTRelationType " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and CTRelationType.CtRelationTypeId not in " + 
$"(Select top {intTop_In} CTRelationType.CtRelationTypeId from CTRelationType " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CTRelationType where {1} and CtRelationTypeId not in (Select top {2} CtRelationTypeId from CTRelationType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CTRelationType where {1} and CtRelationTypeId not in (Select top {3} CtRelationTypeId from CTRelationType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsCTRelationTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTRelationTypeDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} CTRelationType.* " + 
$"from CTRelationType " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and CTRelationType.CtRelationTypeId not in " + 
$"(Select top {intTop_In} CTRelationType.CtRelationTypeId from CTRelationType " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CTRelationType where {1} and CtRelationTypeId not in (Select top {2} CtRelationTypeId from CTRelationType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CTRelationType where {1} and CtRelationTypeId not in (Select top {3} CtRelationTypeId from CTRelationType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsCTRelationTypeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsCTRelationTypeDA:GetObjLst)", objException.Message));
}
List<clsCTRelationTypeEN> arrObjLst = new List<clsCTRelationTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTRelationTypeDA.GetSpecSQLObj();
strSQL = "Select * from CTRelationType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCTRelationTypeEN objCTRelationTypeEN = new clsCTRelationTypeEN();
try
{
objCTRelationTypeEN.CtRelationTypeId = objRow[conCTRelationType.CtRelationTypeId].ToString().Trim(); //Ct关系类型Id
objCTRelationTypeEN.RelationTypeName = objRow[conCTRelationType.RelationTypeName].ToString().Trim(); //关系类型名
objCTRelationTypeEN.RelationTypeEN = objRow[conCTRelationType.RelationTypeEN] == DBNull.Value ? null : objRow[conCTRelationType.RelationTypeEN].ToString().Trim(); //关系类型英文名
objCTRelationTypeEN.Description = objRow[conCTRelationType.Description] == DBNull.Value ? null : objRow[conCTRelationType.Description].ToString().Trim(); //描述
objCTRelationTypeEN.OrderNum = objRow[conCTRelationType.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCTRelationType.OrderNum].ToString().Trim()); //序号
objCTRelationTypeEN.InUse = TransNullToBool(objRow[conCTRelationType.InUse].ToString().Trim()); //是否在用
objCTRelationTypeEN.LineColor = objRow[conCTRelationType.LineColor] == DBNull.Value ? null : objRow[conCTRelationType.LineColor].ToString().Trim(); //LineColor
objCTRelationTypeEN.LineStyle = objRow[conCTRelationType.LineStyle] == DBNull.Value ? null : objRow[conCTRelationType.LineStyle].ToString().Trim(); //LineStyle
objCTRelationTypeEN.LineWidth = objRow[conCTRelationType.LineWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCTRelationType.LineWidth].ToString().Trim()); //LineWidth
objCTRelationTypeEN.ArrowType = objRow[conCTRelationType.ArrowType] == DBNull.Value ? null : objRow[conCTRelationType.ArrowType].ToString().Trim(); //箭头类型
objCTRelationTypeEN.DisplayColor = objRow[conCTRelationType.DisplayColor] == DBNull.Value ? null : objRow[conCTRelationType.DisplayColor].ToString().Trim(); //DisplayColor
objCTRelationTypeEN.UpdDate = objRow[conCTRelationType.UpdDate] == DBNull.Value ? null : objRow[conCTRelationType.UpdDate].ToString().Trim(); //修改日期
objCTRelationTypeEN.UpdUser = objRow[conCTRelationType.UpdUser] == DBNull.Value ? null : objRow[conCTRelationType.UpdUser].ToString().Trim(); //修改者
objCTRelationTypeEN.Memo = objRow[conCTRelationType.Memo] == DBNull.Value ? null : objRow[conCTRelationType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCTRelationTypeDA: GetObjLst)", objException.Message));
}
objCTRelationTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCTRelationTypeEN);
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
public List<clsCTRelationTypeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsCTRelationTypeDA:GetObjLstByTabName)", objException.Message));
}
List<clsCTRelationTypeEN> arrObjLst = new List<clsCTRelationTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTRelationTypeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCTRelationTypeEN objCTRelationTypeEN = new clsCTRelationTypeEN();
try
{
objCTRelationTypeEN.CtRelationTypeId = objRow[conCTRelationType.CtRelationTypeId].ToString().Trim(); //Ct关系类型Id
objCTRelationTypeEN.RelationTypeName = objRow[conCTRelationType.RelationTypeName].ToString().Trim(); //关系类型名
objCTRelationTypeEN.RelationTypeEN = objRow[conCTRelationType.RelationTypeEN] == DBNull.Value ? null : objRow[conCTRelationType.RelationTypeEN].ToString().Trim(); //关系类型英文名
objCTRelationTypeEN.Description = objRow[conCTRelationType.Description] == DBNull.Value ? null : objRow[conCTRelationType.Description].ToString().Trim(); //描述
objCTRelationTypeEN.OrderNum = objRow[conCTRelationType.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCTRelationType.OrderNum].ToString().Trim()); //序号
objCTRelationTypeEN.InUse = TransNullToBool(objRow[conCTRelationType.InUse].ToString().Trim()); //是否在用
objCTRelationTypeEN.LineColor = objRow[conCTRelationType.LineColor] == DBNull.Value ? null : objRow[conCTRelationType.LineColor].ToString().Trim(); //LineColor
objCTRelationTypeEN.LineStyle = objRow[conCTRelationType.LineStyle] == DBNull.Value ? null : objRow[conCTRelationType.LineStyle].ToString().Trim(); //LineStyle
objCTRelationTypeEN.LineWidth = objRow[conCTRelationType.LineWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCTRelationType.LineWidth].ToString().Trim()); //LineWidth
objCTRelationTypeEN.ArrowType = objRow[conCTRelationType.ArrowType] == DBNull.Value ? null : objRow[conCTRelationType.ArrowType].ToString().Trim(); //箭头类型
objCTRelationTypeEN.DisplayColor = objRow[conCTRelationType.DisplayColor] == DBNull.Value ? null : objRow[conCTRelationType.DisplayColor].ToString().Trim(); //DisplayColor
objCTRelationTypeEN.UpdDate = objRow[conCTRelationType.UpdDate] == DBNull.Value ? null : objRow[conCTRelationType.UpdDate].ToString().Trim(); //修改日期
objCTRelationTypeEN.UpdUser = objRow[conCTRelationType.UpdUser] == DBNull.Value ? null : objRow[conCTRelationType.UpdUser].ToString().Trim(); //修改者
objCTRelationTypeEN.Memo = objRow[conCTRelationType.Memo] == DBNull.Value ? null : objRow[conCTRelationType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCTRelationTypeDA: GetObjLst)", objException.Message));
}
objCTRelationTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCTRelationTypeEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objCTRelationTypeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetCTRelationType(ref clsCTRelationTypeEN objCTRelationTypeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTRelationTypeDA.GetSpecSQLObj();
strSQL = "Select * from CTRelationType where CtRelationTypeId = " + "'"+ objCTRelationTypeEN.CtRelationTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objCTRelationTypeEN.CtRelationTypeId = objDT.Rows[0][conCTRelationType.CtRelationTypeId].ToString().Trim(); //Ct关系类型Id(字段类型:char,字段长度:2,是否可空:True)
 objCTRelationTypeEN.RelationTypeName = objDT.Rows[0][conCTRelationType.RelationTypeName].ToString().Trim(); //关系类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objCTRelationTypeEN.RelationTypeEN = objDT.Rows[0][conCTRelationType.RelationTypeEN].ToString().Trim(); //关系类型英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objCTRelationTypeEN.Description = objDT.Rows[0][conCTRelationType.Description].ToString().Trim(); //描述(字段类型:varchar,字段长度:300,是否可空:True)
 objCTRelationTypeEN.OrderNum = TransNullToInt(objDT.Rows[0][conCTRelationType.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objCTRelationTypeEN.InUse = TransNullToBool(objDT.Rows[0][conCTRelationType.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objCTRelationTypeEN.LineColor = objDT.Rows[0][conCTRelationType.LineColor].ToString().Trim(); //LineColor(字段类型:varchar,字段长度:20,是否可空:True)
 objCTRelationTypeEN.LineStyle = objDT.Rows[0][conCTRelationType.LineStyle].ToString().Trim(); //LineStyle(字段类型:varchar,字段长度:20,是否可空:True)
 objCTRelationTypeEN.LineWidth = TransNullToInt(objDT.Rows[0][conCTRelationType.LineWidth].ToString().Trim()); //LineWidth(字段类型:int,字段长度:4,是否可空:True)
 objCTRelationTypeEN.ArrowType = objDT.Rows[0][conCTRelationType.ArrowType].ToString().Trim(); //箭头类型(字段类型:varchar,字段长度:20,是否可空:True)
 objCTRelationTypeEN.DisplayColor = objDT.Rows[0][conCTRelationType.DisplayColor].ToString().Trim(); //DisplayColor(字段类型:varchar,字段长度:20,是否可空:True)
 objCTRelationTypeEN.UpdDate = objDT.Rows[0][conCTRelationType.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCTRelationTypeEN.UpdUser = objDT.Rows[0][conCTRelationType.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objCTRelationTypeEN.Memo = objDT.Rows[0][conCTRelationType.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsCTRelationTypeDA: GetCTRelationType)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCtRelationTypeId">表关键字</param>
 /// <returns>表对象</returns>
public clsCTRelationTypeEN GetObjByCtRelationTypeId(string strCtRelationTypeId)
{
CheckPrimaryKey(strCtRelationTypeId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTRelationTypeDA.GetSpecSQLObj();
strSQL = "Select * from CTRelationType where CtRelationTypeId = " + "'"+ strCtRelationTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsCTRelationTypeEN objCTRelationTypeEN = new clsCTRelationTypeEN();
try
{
 objCTRelationTypeEN.CtRelationTypeId = objRow[conCTRelationType.CtRelationTypeId].ToString().Trim(); //Ct关系类型Id(字段类型:char,字段长度:2,是否可空:True)
 objCTRelationTypeEN.RelationTypeName = objRow[conCTRelationType.RelationTypeName].ToString().Trim(); //关系类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objCTRelationTypeEN.RelationTypeEN = objRow[conCTRelationType.RelationTypeEN] == DBNull.Value ? null : objRow[conCTRelationType.RelationTypeEN].ToString().Trim(); //关系类型英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objCTRelationTypeEN.Description = objRow[conCTRelationType.Description] == DBNull.Value ? null : objRow[conCTRelationType.Description].ToString().Trim(); //描述(字段类型:varchar,字段长度:300,是否可空:True)
 objCTRelationTypeEN.OrderNum = objRow[conCTRelationType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTRelationType.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objCTRelationTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCTRelationType.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objCTRelationTypeEN.LineColor = objRow[conCTRelationType.LineColor] == DBNull.Value ? null : objRow[conCTRelationType.LineColor].ToString().Trim(); //LineColor(字段类型:varchar,字段长度:20,是否可空:True)
 objCTRelationTypeEN.LineStyle = objRow[conCTRelationType.LineStyle] == DBNull.Value ? null : objRow[conCTRelationType.LineStyle].ToString().Trim(); //LineStyle(字段类型:varchar,字段长度:20,是否可空:True)
 objCTRelationTypeEN.LineWidth = objRow[conCTRelationType.LineWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTRelationType.LineWidth].ToString().Trim()); //LineWidth(字段类型:int,字段长度:4,是否可空:True)
 objCTRelationTypeEN.ArrowType = objRow[conCTRelationType.ArrowType] == DBNull.Value ? null : objRow[conCTRelationType.ArrowType].ToString().Trim(); //箭头类型(字段类型:varchar,字段长度:20,是否可空:True)
 objCTRelationTypeEN.DisplayColor = objRow[conCTRelationType.DisplayColor] == DBNull.Value ? null : objRow[conCTRelationType.DisplayColor].ToString().Trim(); //DisplayColor(字段类型:varchar,字段长度:20,是否可空:True)
 objCTRelationTypeEN.UpdDate = objRow[conCTRelationType.UpdDate] == DBNull.Value ? null : objRow[conCTRelationType.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCTRelationTypeEN.UpdUser = objRow[conCTRelationType.UpdUser] == DBNull.Value ? null : objRow[conCTRelationType.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objCTRelationTypeEN.Memo = objRow[conCTRelationType.Memo] == DBNull.Value ? null : objRow[conCTRelationType.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsCTRelationTypeDA: GetObjByCtRelationTypeId)", objException.Message));
}
return objCTRelationTypeEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsCTRelationTypeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsCTRelationTypeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTRelationTypeDA.GetSpecSQLObj();
strSQL = "Select * from CTRelationType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsCTRelationTypeEN objCTRelationTypeEN = new clsCTRelationTypeEN()
{
CtRelationTypeId = objRow[conCTRelationType.CtRelationTypeId].ToString().Trim(), //Ct关系类型Id
RelationTypeName = objRow[conCTRelationType.RelationTypeName].ToString().Trim(), //关系类型名
RelationTypeEN = objRow[conCTRelationType.RelationTypeEN] == DBNull.Value ? null : objRow[conCTRelationType.RelationTypeEN].ToString().Trim(), //关系类型英文名
Description = objRow[conCTRelationType.Description] == DBNull.Value ? null : objRow[conCTRelationType.Description].ToString().Trim(), //描述
OrderNum = objRow[conCTRelationType.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCTRelationType.OrderNum].ToString().Trim()), //序号
InUse = TransNullToBool(objRow[conCTRelationType.InUse].ToString().Trim()), //是否在用
LineColor = objRow[conCTRelationType.LineColor] == DBNull.Value ? null : objRow[conCTRelationType.LineColor].ToString().Trim(), //LineColor
LineStyle = objRow[conCTRelationType.LineStyle] == DBNull.Value ? null : objRow[conCTRelationType.LineStyle].ToString().Trim(), //LineStyle
LineWidth = objRow[conCTRelationType.LineWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCTRelationType.LineWidth].ToString().Trim()), //LineWidth
ArrowType = objRow[conCTRelationType.ArrowType] == DBNull.Value ? null : objRow[conCTRelationType.ArrowType].ToString().Trim(), //箭头类型
DisplayColor = objRow[conCTRelationType.DisplayColor] == DBNull.Value ? null : objRow[conCTRelationType.DisplayColor].ToString().Trim(), //DisplayColor
UpdDate = objRow[conCTRelationType.UpdDate] == DBNull.Value ? null : objRow[conCTRelationType.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conCTRelationType.UpdUser] == DBNull.Value ? null : objRow[conCTRelationType.UpdUser].ToString().Trim(), //修改者
Memo = objRow[conCTRelationType.Memo] == DBNull.Value ? null : objRow[conCTRelationType.Memo].ToString().Trim() //说明
};
objCTRelationTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCTRelationTypeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsCTRelationTypeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsCTRelationTypeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCTRelationTypeEN objCTRelationTypeEN = new clsCTRelationTypeEN();
try
{
objCTRelationTypeEN.CtRelationTypeId = objRow[conCTRelationType.CtRelationTypeId].ToString().Trim(); //Ct关系类型Id
objCTRelationTypeEN.RelationTypeName = objRow[conCTRelationType.RelationTypeName].ToString().Trim(); //关系类型名
objCTRelationTypeEN.RelationTypeEN = objRow[conCTRelationType.RelationTypeEN] == DBNull.Value ? null : objRow[conCTRelationType.RelationTypeEN].ToString().Trim(); //关系类型英文名
objCTRelationTypeEN.Description = objRow[conCTRelationType.Description] == DBNull.Value ? null : objRow[conCTRelationType.Description].ToString().Trim(); //描述
objCTRelationTypeEN.OrderNum = objRow[conCTRelationType.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCTRelationType.OrderNum].ToString().Trim()); //序号
objCTRelationTypeEN.InUse = TransNullToBool(objRow[conCTRelationType.InUse].ToString().Trim()); //是否在用
objCTRelationTypeEN.LineColor = objRow[conCTRelationType.LineColor] == DBNull.Value ? null : objRow[conCTRelationType.LineColor].ToString().Trim(); //LineColor
objCTRelationTypeEN.LineStyle = objRow[conCTRelationType.LineStyle] == DBNull.Value ? null : objRow[conCTRelationType.LineStyle].ToString().Trim(); //LineStyle
objCTRelationTypeEN.LineWidth = objRow[conCTRelationType.LineWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCTRelationType.LineWidth].ToString().Trim()); //LineWidth
objCTRelationTypeEN.ArrowType = objRow[conCTRelationType.ArrowType] == DBNull.Value ? null : objRow[conCTRelationType.ArrowType].ToString().Trim(); //箭头类型
objCTRelationTypeEN.DisplayColor = objRow[conCTRelationType.DisplayColor] == DBNull.Value ? null : objRow[conCTRelationType.DisplayColor].ToString().Trim(); //DisplayColor
objCTRelationTypeEN.UpdDate = objRow[conCTRelationType.UpdDate] == DBNull.Value ? null : objRow[conCTRelationType.UpdDate].ToString().Trim(); //修改日期
objCTRelationTypeEN.UpdUser = objRow[conCTRelationType.UpdUser] == DBNull.Value ? null : objRow[conCTRelationType.UpdUser].ToString().Trim(); //修改者
objCTRelationTypeEN.Memo = objRow[conCTRelationType.Memo] == DBNull.Value ? null : objRow[conCTRelationType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsCTRelationTypeDA: GetObjByDataRowCTRelationType)", objException.Message));
}
objCTRelationTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCTRelationTypeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsCTRelationTypeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCTRelationTypeEN objCTRelationTypeEN = new clsCTRelationTypeEN();
try
{
objCTRelationTypeEN.CtRelationTypeId = objRow[conCTRelationType.CtRelationTypeId].ToString().Trim(); //Ct关系类型Id
objCTRelationTypeEN.RelationTypeName = objRow[conCTRelationType.RelationTypeName].ToString().Trim(); //关系类型名
objCTRelationTypeEN.RelationTypeEN = objRow[conCTRelationType.RelationTypeEN] == DBNull.Value ? null : objRow[conCTRelationType.RelationTypeEN].ToString().Trim(); //关系类型英文名
objCTRelationTypeEN.Description = objRow[conCTRelationType.Description] == DBNull.Value ? null : objRow[conCTRelationType.Description].ToString().Trim(); //描述
objCTRelationTypeEN.OrderNum = objRow[conCTRelationType.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCTRelationType.OrderNum].ToString().Trim()); //序号
objCTRelationTypeEN.InUse = TransNullToBool(objRow[conCTRelationType.InUse].ToString().Trim()); //是否在用
objCTRelationTypeEN.LineColor = objRow[conCTRelationType.LineColor] == DBNull.Value ? null : objRow[conCTRelationType.LineColor].ToString().Trim(); //LineColor
objCTRelationTypeEN.LineStyle = objRow[conCTRelationType.LineStyle] == DBNull.Value ? null : objRow[conCTRelationType.LineStyle].ToString().Trim(); //LineStyle
objCTRelationTypeEN.LineWidth = objRow[conCTRelationType.LineWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCTRelationType.LineWidth].ToString().Trim()); //LineWidth
objCTRelationTypeEN.ArrowType = objRow[conCTRelationType.ArrowType] == DBNull.Value ? null : objRow[conCTRelationType.ArrowType].ToString().Trim(); //箭头类型
objCTRelationTypeEN.DisplayColor = objRow[conCTRelationType.DisplayColor] == DBNull.Value ? null : objRow[conCTRelationType.DisplayColor].ToString().Trim(); //DisplayColor
objCTRelationTypeEN.UpdDate = objRow[conCTRelationType.UpdDate] == DBNull.Value ? null : objRow[conCTRelationType.UpdDate].ToString().Trim(); //修改日期
objCTRelationTypeEN.UpdUser = objRow[conCTRelationType.UpdUser] == DBNull.Value ? null : objRow[conCTRelationType.UpdUser].ToString().Trim(); //修改者
objCTRelationTypeEN.Memo = objRow[conCTRelationType.Memo] == DBNull.Value ? null : objRow[conCTRelationType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsCTRelationTypeDA: GetObjByDataRow)", objException.Message));
}
objCTRelationTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCTRelationTypeEN;
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
objSQL = clsCTRelationTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCTRelationTypeEN._CurrTabName, conCTRelationType.CtRelationTypeId, 2, "");
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
objSQL = clsCTRelationTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCTRelationTypeEN._CurrTabName, conCTRelationType.CtRelationTypeId, 2, strPrefix);
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
 objSQL = clsCTRelationTypeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select CtRelationTypeId from CTRelationType where " + strCondition;
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
 objSQL = clsCTRelationTypeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select CtRelationTypeId from CTRelationType where " + strCondition;
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
 /// <param name = "strCtRelationTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strCtRelationTypeId)
{
CheckPrimaryKey(strCtRelationTypeId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTRelationTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CTRelationType", "CtRelationTypeId = " + "'"+ strCtRelationTypeId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsCTRelationTypeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTRelationTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CTRelationType", strCondition))
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
objSQL = clsCTRelationTypeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("CTRelationType");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsCTRelationTypeEN objCTRelationTypeEN)
 {
 if (objCTRelationTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCTRelationTypeEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTRelationTypeDA.GetSpecSQLObj();
strSQL = "Select * from CTRelationType where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CTRelationType");
objRow = objDS.Tables["CTRelationType"].NewRow();
objRow[conCTRelationType.CtRelationTypeId] = objCTRelationTypeEN.CtRelationTypeId; //Ct关系类型Id
objRow[conCTRelationType.RelationTypeName] = objCTRelationTypeEN.RelationTypeName; //关系类型名
 if (objCTRelationTypeEN.RelationTypeEN !=  "")
 {
objRow[conCTRelationType.RelationTypeEN] = objCTRelationTypeEN.RelationTypeEN; //关系类型英文名
 }
 if (objCTRelationTypeEN.Description !=  "")
 {
objRow[conCTRelationType.Description] = objCTRelationTypeEN.Description; //描述
 }
objRow[conCTRelationType.OrderNum] = objCTRelationTypeEN.OrderNum; //序号
objRow[conCTRelationType.InUse] = objCTRelationTypeEN.InUse; //是否在用
 if (objCTRelationTypeEN.LineColor !=  "")
 {
objRow[conCTRelationType.LineColor] = objCTRelationTypeEN.LineColor; //LineColor
 }
 if (objCTRelationTypeEN.LineStyle !=  "")
 {
objRow[conCTRelationType.LineStyle] = objCTRelationTypeEN.LineStyle; //LineStyle
 }
objRow[conCTRelationType.LineWidth] = objCTRelationTypeEN.LineWidth; //LineWidth
 if (objCTRelationTypeEN.ArrowType !=  "")
 {
objRow[conCTRelationType.ArrowType] = objCTRelationTypeEN.ArrowType; //箭头类型
 }
 if (objCTRelationTypeEN.DisplayColor !=  "")
 {
objRow[conCTRelationType.DisplayColor] = objCTRelationTypeEN.DisplayColor; //DisplayColor
 }
 if (objCTRelationTypeEN.UpdDate !=  "")
 {
objRow[conCTRelationType.UpdDate] = objCTRelationTypeEN.UpdDate; //修改日期
 }
 if (objCTRelationTypeEN.UpdUser !=  "")
 {
objRow[conCTRelationType.UpdUser] = objCTRelationTypeEN.UpdUser; //修改者
 }
 if (objCTRelationTypeEN.Memo !=  "")
 {
objRow[conCTRelationType.Memo] = objCTRelationTypeEN.Memo; //说明
 }
objDS.Tables[clsCTRelationTypeEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsCTRelationTypeEN._CurrTabName);
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
 /// <param name = "objCTRelationTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCTRelationTypeEN objCTRelationTypeEN)
{
 if (objCTRelationTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCTRelationTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCTRelationTypeEN.CtRelationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCTRelationType.CtRelationTypeId);
 var strCtRelationTypeId = objCTRelationTypeEN.CtRelationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtRelationTypeId + "'");
 }
 
 if (objCTRelationTypeEN.RelationTypeName !=  null)
 {
 arrFieldListForInsert.Add(conCTRelationType.RelationTypeName);
 var strRelationTypeName = objCTRelationTypeEN.RelationTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelationTypeName + "'");
 }
 
 if (objCTRelationTypeEN.RelationTypeEN !=  null)
 {
 arrFieldListForInsert.Add(conCTRelationType.RelationTypeEN);
 var strRelationTypeEN = objCTRelationTypeEN.RelationTypeEN.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelationTypeEN + "'");
 }
 
 if (objCTRelationTypeEN.Description !=  null)
 {
 arrFieldListForInsert.Add(conCTRelationType.Description);
 var strDescription = objCTRelationTypeEN.Description.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDescription + "'");
 }
 
 if (objCTRelationTypeEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conCTRelationType.OrderNum);
 arrValueListForInsert.Add(objCTRelationTypeEN.OrderNum.ToString());
 }
 
 arrFieldListForInsert.Add(conCTRelationType.InUse);
 arrValueListForInsert.Add("'" + (objCTRelationTypeEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objCTRelationTypeEN.LineColor !=  null)
 {
 arrFieldListForInsert.Add(conCTRelationType.LineColor);
 var strLineColor = objCTRelationTypeEN.LineColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLineColor + "'");
 }
 
 if (objCTRelationTypeEN.LineStyle !=  null)
 {
 arrFieldListForInsert.Add(conCTRelationType.LineStyle);
 var strLineStyle = objCTRelationTypeEN.LineStyle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLineStyle + "'");
 }
 
 if (objCTRelationTypeEN.LineWidth !=  null)
 {
 arrFieldListForInsert.Add(conCTRelationType.LineWidth);
 arrValueListForInsert.Add(objCTRelationTypeEN.LineWidth.ToString());
 }
 
 if (objCTRelationTypeEN.ArrowType !=  null)
 {
 arrFieldListForInsert.Add(conCTRelationType.ArrowType);
 var strArrowType = objCTRelationTypeEN.ArrowType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strArrowType + "'");
 }
 
 if (objCTRelationTypeEN.DisplayColor !=  null)
 {
 arrFieldListForInsert.Add(conCTRelationType.DisplayColor);
 var strDisplayColor = objCTRelationTypeEN.DisplayColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDisplayColor + "'");
 }
 
 if (objCTRelationTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCTRelationType.UpdDate);
 var strUpdDate = objCTRelationTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCTRelationTypeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCTRelationType.UpdUser);
 var strUpdUser = objCTRelationTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objCTRelationTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCTRelationType.Memo);
 var strMemo = objCTRelationTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CTRelationType");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTRelationTypeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objCTRelationTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCTRelationTypeEN objCTRelationTypeEN)
{
 if (objCTRelationTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCTRelationTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCTRelationTypeEN.CtRelationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCTRelationType.CtRelationTypeId);
 var strCtRelationTypeId = objCTRelationTypeEN.CtRelationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtRelationTypeId + "'");
 }
 
 if (objCTRelationTypeEN.RelationTypeName !=  null)
 {
 arrFieldListForInsert.Add(conCTRelationType.RelationTypeName);
 var strRelationTypeName = objCTRelationTypeEN.RelationTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelationTypeName + "'");
 }
 
 if (objCTRelationTypeEN.RelationTypeEN !=  null)
 {
 arrFieldListForInsert.Add(conCTRelationType.RelationTypeEN);
 var strRelationTypeEN = objCTRelationTypeEN.RelationTypeEN.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelationTypeEN + "'");
 }
 
 if (objCTRelationTypeEN.Description !=  null)
 {
 arrFieldListForInsert.Add(conCTRelationType.Description);
 var strDescription = objCTRelationTypeEN.Description.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDescription + "'");
 }
 
 if (objCTRelationTypeEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conCTRelationType.OrderNum);
 arrValueListForInsert.Add(objCTRelationTypeEN.OrderNum.ToString());
 }
 
 arrFieldListForInsert.Add(conCTRelationType.InUse);
 arrValueListForInsert.Add("'" + (objCTRelationTypeEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objCTRelationTypeEN.LineColor !=  null)
 {
 arrFieldListForInsert.Add(conCTRelationType.LineColor);
 var strLineColor = objCTRelationTypeEN.LineColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLineColor + "'");
 }
 
 if (objCTRelationTypeEN.LineStyle !=  null)
 {
 arrFieldListForInsert.Add(conCTRelationType.LineStyle);
 var strLineStyle = objCTRelationTypeEN.LineStyle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLineStyle + "'");
 }
 
 if (objCTRelationTypeEN.LineWidth !=  null)
 {
 arrFieldListForInsert.Add(conCTRelationType.LineWidth);
 arrValueListForInsert.Add(objCTRelationTypeEN.LineWidth.ToString());
 }
 
 if (objCTRelationTypeEN.ArrowType !=  null)
 {
 arrFieldListForInsert.Add(conCTRelationType.ArrowType);
 var strArrowType = objCTRelationTypeEN.ArrowType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strArrowType + "'");
 }
 
 if (objCTRelationTypeEN.DisplayColor !=  null)
 {
 arrFieldListForInsert.Add(conCTRelationType.DisplayColor);
 var strDisplayColor = objCTRelationTypeEN.DisplayColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDisplayColor + "'");
 }
 
 if (objCTRelationTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCTRelationType.UpdDate);
 var strUpdDate = objCTRelationTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCTRelationTypeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCTRelationType.UpdUser);
 var strUpdUser = objCTRelationTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objCTRelationTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCTRelationType.Memo);
 var strMemo = objCTRelationTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CTRelationType");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTRelationTypeDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objCTRelationTypeEN.CtRelationTypeId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objCTRelationTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCTRelationTypeEN objCTRelationTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objCTRelationTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCTRelationTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCTRelationTypeEN.CtRelationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCTRelationType.CtRelationTypeId);
 var strCtRelationTypeId = objCTRelationTypeEN.CtRelationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtRelationTypeId + "'");
 }
 
 if (objCTRelationTypeEN.RelationTypeName !=  null)
 {
 arrFieldListForInsert.Add(conCTRelationType.RelationTypeName);
 var strRelationTypeName = objCTRelationTypeEN.RelationTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelationTypeName + "'");
 }
 
 if (objCTRelationTypeEN.RelationTypeEN !=  null)
 {
 arrFieldListForInsert.Add(conCTRelationType.RelationTypeEN);
 var strRelationTypeEN = objCTRelationTypeEN.RelationTypeEN.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelationTypeEN + "'");
 }
 
 if (objCTRelationTypeEN.Description !=  null)
 {
 arrFieldListForInsert.Add(conCTRelationType.Description);
 var strDescription = objCTRelationTypeEN.Description.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDescription + "'");
 }
 
 if (objCTRelationTypeEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conCTRelationType.OrderNum);
 arrValueListForInsert.Add(objCTRelationTypeEN.OrderNum.ToString());
 }
 
 arrFieldListForInsert.Add(conCTRelationType.InUse);
 arrValueListForInsert.Add("'" + (objCTRelationTypeEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objCTRelationTypeEN.LineColor !=  null)
 {
 arrFieldListForInsert.Add(conCTRelationType.LineColor);
 var strLineColor = objCTRelationTypeEN.LineColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLineColor + "'");
 }
 
 if (objCTRelationTypeEN.LineStyle !=  null)
 {
 arrFieldListForInsert.Add(conCTRelationType.LineStyle);
 var strLineStyle = objCTRelationTypeEN.LineStyle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLineStyle + "'");
 }
 
 if (objCTRelationTypeEN.LineWidth !=  null)
 {
 arrFieldListForInsert.Add(conCTRelationType.LineWidth);
 arrValueListForInsert.Add(objCTRelationTypeEN.LineWidth.ToString());
 }
 
 if (objCTRelationTypeEN.ArrowType !=  null)
 {
 arrFieldListForInsert.Add(conCTRelationType.ArrowType);
 var strArrowType = objCTRelationTypeEN.ArrowType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strArrowType + "'");
 }
 
 if (objCTRelationTypeEN.DisplayColor !=  null)
 {
 arrFieldListForInsert.Add(conCTRelationType.DisplayColor);
 var strDisplayColor = objCTRelationTypeEN.DisplayColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDisplayColor + "'");
 }
 
 if (objCTRelationTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCTRelationType.UpdDate);
 var strUpdDate = objCTRelationTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCTRelationTypeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCTRelationType.UpdUser);
 var strUpdUser = objCTRelationTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objCTRelationTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCTRelationType.Memo);
 var strMemo = objCTRelationTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CTRelationType");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTRelationTypeDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objCTRelationTypeEN.CtRelationTypeId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objCTRelationTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCTRelationTypeEN objCTRelationTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objCTRelationTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCTRelationTypeEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCTRelationTypeEN.CtRelationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCTRelationType.CtRelationTypeId);
 var strCtRelationTypeId = objCTRelationTypeEN.CtRelationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtRelationTypeId + "'");
 }
 
 if (objCTRelationTypeEN.RelationTypeName !=  null)
 {
 arrFieldListForInsert.Add(conCTRelationType.RelationTypeName);
 var strRelationTypeName = objCTRelationTypeEN.RelationTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelationTypeName + "'");
 }
 
 if (objCTRelationTypeEN.RelationTypeEN !=  null)
 {
 arrFieldListForInsert.Add(conCTRelationType.RelationTypeEN);
 var strRelationTypeEN = objCTRelationTypeEN.RelationTypeEN.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelationTypeEN + "'");
 }
 
 if (objCTRelationTypeEN.Description !=  null)
 {
 arrFieldListForInsert.Add(conCTRelationType.Description);
 var strDescription = objCTRelationTypeEN.Description.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDescription + "'");
 }
 
 if (objCTRelationTypeEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conCTRelationType.OrderNum);
 arrValueListForInsert.Add(objCTRelationTypeEN.OrderNum.ToString());
 }
 
 arrFieldListForInsert.Add(conCTRelationType.InUse);
 arrValueListForInsert.Add("'" + (objCTRelationTypeEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objCTRelationTypeEN.LineColor !=  null)
 {
 arrFieldListForInsert.Add(conCTRelationType.LineColor);
 var strLineColor = objCTRelationTypeEN.LineColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLineColor + "'");
 }
 
 if (objCTRelationTypeEN.LineStyle !=  null)
 {
 arrFieldListForInsert.Add(conCTRelationType.LineStyle);
 var strLineStyle = objCTRelationTypeEN.LineStyle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLineStyle + "'");
 }
 
 if (objCTRelationTypeEN.LineWidth !=  null)
 {
 arrFieldListForInsert.Add(conCTRelationType.LineWidth);
 arrValueListForInsert.Add(objCTRelationTypeEN.LineWidth.ToString());
 }
 
 if (objCTRelationTypeEN.ArrowType !=  null)
 {
 arrFieldListForInsert.Add(conCTRelationType.ArrowType);
 var strArrowType = objCTRelationTypeEN.ArrowType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strArrowType + "'");
 }
 
 if (objCTRelationTypeEN.DisplayColor !=  null)
 {
 arrFieldListForInsert.Add(conCTRelationType.DisplayColor);
 var strDisplayColor = objCTRelationTypeEN.DisplayColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDisplayColor + "'");
 }
 
 if (objCTRelationTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCTRelationType.UpdDate);
 var strUpdDate = objCTRelationTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCTRelationTypeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCTRelationType.UpdUser);
 var strUpdUser = objCTRelationTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objCTRelationTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCTRelationType.Memo);
 var strMemo = objCTRelationTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CTRelationType");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTRelationTypeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewCTRelationTypes(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTRelationTypeDA.GetSpecSQLObj();
strSQL = "Select * from CTRelationType where CtRelationTypeId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CTRelationType");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strCtRelationTypeId = oRow[conCTRelationType.CtRelationTypeId].ToString().Trim();
if (IsExist(strCtRelationTypeId))
{
 string strResult = "关键字变量值为:" + string.Format("CtRelationTypeId = {0}", strCtRelationTypeId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsCTRelationTypeEN._CurrTabName ].NewRow();
objRow[conCTRelationType.CtRelationTypeId] = oRow[conCTRelationType.CtRelationTypeId].ToString().Trim(); //Ct关系类型Id
objRow[conCTRelationType.RelationTypeName] = oRow[conCTRelationType.RelationTypeName].ToString().Trim(); //关系类型名
objRow[conCTRelationType.RelationTypeEN] = oRow[conCTRelationType.RelationTypeEN].ToString().Trim(); //关系类型英文名
objRow[conCTRelationType.Description] = oRow[conCTRelationType.Description].ToString().Trim(); //描述
objRow[conCTRelationType.OrderNum] = oRow[conCTRelationType.OrderNum].ToString().Trim(); //序号
objRow[conCTRelationType.InUse] = oRow[conCTRelationType.InUse].ToString().Trim(); //是否在用
objRow[conCTRelationType.LineColor] = oRow[conCTRelationType.LineColor].ToString().Trim(); //LineColor
objRow[conCTRelationType.LineStyle] = oRow[conCTRelationType.LineStyle].ToString().Trim(); //LineStyle
objRow[conCTRelationType.LineWidth] = oRow[conCTRelationType.LineWidth].ToString().Trim(); //LineWidth
objRow[conCTRelationType.ArrowType] = oRow[conCTRelationType.ArrowType].ToString().Trim(); //箭头类型
objRow[conCTRelationType.DisplayColor] = oRow[conCTRelationType.DisplayColor].ToString().Trim(); //DisplayColor
objRow[conCTRelationType.UpdDate] = oRow[conCTRelationType.UpdDate].ToString().Trim(); //修改日期
objRow[conCTRelationType.UpdUser] = oRow[conCTRelationType.UpdUser].ToString().Trim(); //修改者
objRow[conCTRelationType.Memo] = oRow[conCTRelationType.Memo].ToString().Trim(); //说明
 objDS.Tables[clsCTRelationTypeEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsCTRelationTypeEN._CurrTabName);
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
 /// <param name = "objCTRelationTypeEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsCTRelationTypeEN objCTRelationTypeEN)
{
 if (objCTRelationTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCTRelationTypeEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTRelationTypeDA.GetSpecSQLObj();
strSQL = "Select * from CTRelationType where CtRelationTypeId = " + "'"+ objCTRelationTypeEN.CtRelationTypeId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsCTRelationTypeEN._CurrTabName);
if (objDS.Tables[clsCTRelationTypeEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:CtRelationTypeId = " + "'"+ objCTRelationTypeEN.CtRelationTypeId+"'");
return false;
}
objRow = objDS.Tables[clsCTRelationTypeEN._CurrTabName].Rows[0];
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.CtRelationTypeId))
 {
objRow[conCTRelationType.CtRelationTypeId] = objCTRelationTypeEN.CtRelationTypeId; //Ct关系类型Id
 }
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.RelationTypeName))
 {
objRow[conCTRelationType.RelationTypeName] = objCTRelationTypeEN.RelationTypeName; //关系类型名
 }
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.RelationTypeEN))
 {
objRow[conCTRelationType.RelationTypeEN] = objCTRelationTypeEN.RelationTypeEN; //关系类型英文名
 }
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.Description))
 {
objRow[conCTRelationType.Description] = objCTRelationTypeEN.Description; //描述
 }
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.OrderNum))
 {
objRow[conCTRelationType.OrderNum] = objCTRelationTypeEN.OrderNum; //序号
 }
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.InUse))
 {
objRow[conCTRelationType.InUse] = objCTRelationTypeEN.InUse; //是否在用
 }
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.LineColor))
 {
objRow[conCTRelationType.LineColor] = objCTRelationTypeEN.LineColor; //LineColor
 }
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.LineStyle))
 {
objRow[conCTRelationType.LineStyle] = objCTRelationTypeEN.LineStyle; //LineStyle
 }
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.LineWidth))
 {
objRow[conCTRelationType.LineWidth] = objCTRelationTypeEN.LineWidth; //LineWidth
 }
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.ArrowType))
 {
objRow[conCTRelationType.ArrowType] = objCTRelationTypeEN.ArrowType; //箭头类型
 }
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.DisplayColor))
 {
objRow[conCTRelationType.DisplayColor] = objCTRelationTypeEN.DisplayColor; //DisplayColor
 }
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.UpdDate))
 {
objRow[conCTRelationType.UpdDate] = objCTRelationTypeEN.UpdDate; //修改日期
 }
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.UpdUser))
 {
objRow[conCTRelationType.UpdUser] = objCTRelationTypeEN.UpdUser; //修改者
 }
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.Memo))
 {
objRow[conCTRelationType.Memo] = objCTRelationTypeEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsCTRelationTypeEN._CurrTabName);
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
 /// <param name = "objCTRelationTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCTRelationTypeEN objCTRelationTypeEN)
{
 if (objCTRelationTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCTRelationTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTRelationTypeDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update CTRelationType Set ");
 
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.RelationTypeName))
 {
 if (objCTRelationTypeEN.RelationTypeName !=  null)
 {
 var strRelationTypeName = objCTRelationTypeEN.RelationTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRelationTypeName, conCTRelationType.RelationTypeName); //关系类型名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTRelationType.RelationTypeName); //关系类型名
 }
 }
 
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.RelationTypeEN))
 {
 if (objCTRelationTypeEN.RelationTypeEN !=  null)
 {
 var strRelationTypeEN = objCTRelationTypeEN.RelationTypeEN.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRelationTypeEN, conCTRelationType.RelationTypeEN); //关系类型英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTRelationType.RelationTypeEN); //关系类型英文名
 }
 }
 
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.Description))
 {
 if (objCTRelationTypeEN.Description !=  null)
 {
 var strDescription = objCTRelationTypeEN.Description.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDescription, conCTRelationType.Description); //描述
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTRelationType.Description); //描述
 }
 }
 
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.OrderNum))
 {
 if (objCTRelationTypeEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCTRelationTypeEN.OrderNum, conCTRelationType.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTRelationType.OrderNum); //序号
 }
 }
 
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCTRelationTypeEN.InUse == true?"1":"0", conCTRelationType.InUse); //是否在用
 }
 
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.LineColor))
 {
 if (objCTRelationTypeEN.LineColor !=  null)
 {
 var strLineColor = objCTRelationTypeEN.LineColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLineColor, conCTRelationType.LineColor); //LineColor
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTRelationType.LineColor); //LineColor
 }
 }
 
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.LineStyle))
 {
 if (objCTRelationTypeEN.LineStyle !=  null)
 {
 var strLineStyle = objCTRelationTypeEN.LineStyle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLineStyle, conCTRelationType.LineStyle); //LineStyle
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTRelationType.LineStyle); //LineStyle
 }
 }
 
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.LineWidth))
 {
 if (objCTRelationTypeEN.LineWidth !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCTRelationTypeEN.LineWidth, conCTRelationType.LineWidth); //LineWidth
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTRelationType.LineWidth); //LineWidth
 }
 }
 
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.ArrowType))
 {
 if (objCTRelationTypeEN.ArrowType !=  null)
 {
 var strArrowType = objCTRelationTypeEN.ArrowType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strArrowType, conCTRelationType.ArrowType); //箭头类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTRelationType.ArrowType); //箭头类型
 }
 }
 
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.DisplayColor))
 {
 if (objCTRelationTypeEN.DisplayColor !=  null)
 {
 var strDisplayColor = objCTRelationTypeEN.DisplayColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDisplayColor, conCTRelationType.DisplayColor); //DisplayColor
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTRelationType.DisplayColor); //DisplayColor
 }
 }
 
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.UpdDate))
 {
 if (objCTRelationTypeEN.UpdDate !=  null)
 {
 var strUpdDate = objCTRelationTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conCTRelationType.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTRelationType.UpdDate); //修改日期
 }
 }
 
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.UpdUser))
 {
 if (objCTRelationTypeEN.UpdUser !=  null)
 {
 var strUpdUser = objCTRelationTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conCTRelationType.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTRelationType.UpdUser); //修改者
 }
 }
 
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.Memo))
 {
 if (objCTRelationTypeEN.Memo !=  null)
 {
 var strMemo = objCTRelationTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCTRelationType.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTRelationType.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where CtRelationTypeId = '{0}'", objCTRelationTypeEN.CtRelationTypeId); 
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
 /// <param name = "objCTRelationTypeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsCTRelationTypeEN objCTRelationTypeEN, string strCondition)
{
 if (objCTRelationTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCTRelationTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTRelationTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CTRelationType Set ");
 
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.RelationTypeName))
 {
 if (objCTRelationTypeEN.RelationTypeName !=  null)
 {
 var strRelationTypeName = objCTRelationTypeEN.RelationTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RelationTypeName = '{0}',", strRelationTypeName); //关系类型名
 }
 else
 {
 sbSQL.Append(" RelationTypeName = null,"); //关系类型名
 }
 }
 
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.RelationTypeEN))
 {
 if (objCTRelationTypeEN.RelationTypeEN !=  null)
 {
 var strRelationTypeEN = objCTRelationTypeEN.RelationTypeEN.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RelationTypeEN = '{0}',", strRelationTypeEN); //关系类型英文名
 }
 else
 {
 sbSQL.Append(" RelationTypeEN = null,"); //关系类型英文名
 }
 }
 
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.Description))
 {
 if (objCTRelationTypeEN.Description !=  null)
 {
 var strDescription = objCTRelationTypeEN.Description.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Description = '{0}',", strDescription); //描述
 }
 else
 {
 sbSQL.Append(" Description = null,"); //描述
 }
 }
 
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.OrderNum))
 {
 if (objCTRelationTypeEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCTRelationTypeEN.OrderNum, conCTRelationType.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTRelationType.OrderNum); //序号
 }
 }
 
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objCTRelationTypeEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.LineColor))
 {
 if (objCTRelationTypeEN.LineColor !=  null)
 {
 var strLineColor = objCTRelationTypeEN.LineColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LineColor = '{0}',", strLineColor); //LineColor
 }
 else
 {
 sbSQL.Append(" LineColor = null,"); //LineColor
 }
 }
 
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.LineStyle))
 {
 if (objCTRelationTypeEN.LineStyle !=  null)
 {
 var strLineStyle = objCTRelationTypeEN.LineStyle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LineStyle = '{0}',", strLineStyle); //LineStyle
 }
 else
 {
 sbSQL.Append(" LineStyle = null,"); //LineStyle
 }
 }
 
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.LineWidth))
 {
 if (objCTRelationTypeEN.LineWidth !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCTRelationTypeEN.LineWidth, conCTRelationType.LineWidth); //LineWidth
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTRelationType.LineWidth); //LineWidth
 }
 }
 
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.ArrowType))
 {
 if (objCTRelationTypeEN.ArrowType !=  null)
 {
 var strArrowType = objCTRelationTypeEN.ArrowType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ArrowType = '{0}',", strArrowType); //箭头类型
 }
 else
 {
 sbSQL.Append(" ArrowType = null,"); //箭头类型
 }
 }
 
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.DisplayColor))
 {
 if (objCTRelationTypeEN.DisplayColor !=  null)
 {
 var strDisplayColor = objCTRelationTypeEN.DisplayColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DisplayColor = '{0}',", strDisplayColor); //DisplayColor
 }
 else
 {
 sbSQL.Append(" DisplayColor = null,"); //DisplayColor
 }
 }
 
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.UpdDate))
 {
 if (objCTRelationTypeEN.UpdDate !=  null)
 {
 var strUpdDate = objCTRelationTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.UpdUser))
 {
 if (objCTRelationTypeEN.UpdUser !=  null)
 {
 var strUpdUser = objCTRelationTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.Memo))
 {
 if (objCTRelationTypeEN.Memo !=  null)
 {
 var strMemo = objCTRelationTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objCTRelationTypeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsCTRelationTypeEN objCTRelationTypeEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objCTRelationTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCTRelationTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTRelationTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CTRelationType Set ");
 
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.RelationTypeName))
 {
 if (objCTRelationTypeEN.RelationTypeName !=  null)
 {
 var strRelationTypeName = objCTRelationTypeEN.RelationTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RelationTypeName = '{0}',", strRelationTypeName); //关系类型名
 }
 else
 {
 sbSQL.Append(" RelationTypeName = null,"); //关系类型名
 }
 }
 
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.RelationTypeEN))
 {
 if (objCTRelationTypeEN.RelationTypeEN !=  null)
 {
 var strRelationTypeEN = objCTRelationTypeEN.RelationTypeEN.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RelationTypeEN = '{0}',", strRelationTypeEN); //关系类型英文名
 }
 else
 {
 sbSQL.Append(" RelationTypeEN = null,"); //关系类型英文名
 }
 }
 
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.Description))
 {
 if (objCTRelationTypeEN.Description !=  null)
 {
 var strDescription = objCTRelationTypeEN.Description.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Description = '{0}',", strDescription); //描述
 }
 else
 {
 sbSQL.Append(" Description = null,"); //描述
 }
 }
 
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.OrderNum))
 {
 if (objCTRelationTypeEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCTRelationTypeEN.OrderNum, conCTRelationType.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTRelationType.OrderNum); //序号
 }
 }
 
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objCTRelationTypeEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.LineColor))
 {
 if (objCTRelationTypeEN.LineColor !=  null)
 {
 var strLineColor = objCTRelationTypeEN.LineColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LineColor = '{0}',", strLineColor); //LineColor
 }
 else
 {
 sbSQL.Append(" LineColor = null,"); //LineColor
 }
 }
 
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.LineStyle))
 {
 if (objCTRelationTypeEN.LineStyle !=  null)
 {
 var strLineStyle = objCTRelationTypeEN.LineStyle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LineStyle = '{0}',", strLineStyle); //LineStyle
 }
 else
 {
 sbSQL.Append(" LineStyle = null,"); //LineStyle
 }
 }
 
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.LineWidth))
 {
 if (objCTRelationTypeEN.LineWidth !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCTRelationTypeEN.LineWidth, conCTRelationType.LineWidth); //LineWidth
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTRelationType.LineWidth); //LineWidth
 }
 }
 
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.ArrowType))
 {
 if (objCTRelationTypeEN.ArrowType !=  null)
 {
 var strArrowType = objCTRelationTypeEN.ArrowType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ArrowType = '{0}',", strArrowType); //箭头类型
 }
 else
 {
 sbSQL.Append(" ArrowType = null,"); //箭头类型
 }
 }
 
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.DisplayColor))
 {
 if (objCTRelationTypeEN.DisplayColor !=  null)
 {
 var strDisplayColor = objCTRelationTypeEN.DisplayColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DisplayColor = '{0}',", strDisplayColor); //DisplayColor
 }
 else
 {
 sbSQL.Append(" DisplayColor = null,"); //DisplayColor
 }
 }
 
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.UpdDate))
 {
 if (objCTRelationTypeEN.UpdDate !=  null)
 {
 var strUpdDate = objCTRelationTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.UpdUser))
 {
 if (objCTRelationTypeEN.UpdUser !=  null)
 {
 var strUpdUser = objCTRelationTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.Memo))
 {
 if (objCTRelationTypeEN.Memo !=  null)
 {
 var strMemo = objCTRelationTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objCTRelationTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCTRelationTypeEN objCTRelationTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objCTRelationTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCTRelationTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTRelationTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CTRelationType Set ");
 
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.RelationTypeName))
 {
 if (objCTRelationTypeEN.RelationTypeName !=  null)
 {
 var strRelationTypeName = objCTRelationTypeEN.RelationTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRelationTypeName, conCTRelationType.RelationTypeName); //关系类型名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTRelationType.RelationTypeName); //关系类型名
 }
 }
 
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.RelationTypeEN))
 {
 if (objCTRelationTypeEN.RelationTypeEN !=  null)
 {
 var strRelationTypeEN = objCTRelationTypeEN.RelationTypeEN.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRelationTypeEN, conCTRelationType.RelationTypeEN); //关系类型英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTRelationType.RelationTypeEN); //关系类型英文名
 }
 }
 
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.Description))
 {
 if (objCTRelationTypeEN.Description !=  null)
 {
 var strDescription = objCTRelationTypeEN.Description.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDescription, conCTRelationType.Description); //描述
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTRelationType.Description); //描述
 }
 }
 
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.OrderNum))
 {
 if (objCTRelationTypeEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCTRelationTypeEN.OrderNum, conCTRelationType.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTRelationType.OrderNum); //序号
 }
 }
 
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCTRelationTypeEN.InUse == true?"1":"0", conCTRelationType.InUse); //是否在用
 }
 
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.LineColor))
 {
 if (objCTRelationTypeEN.LineColor !=  null)
 {
 var strLineColor = objCTRelationTypeEN.LineColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLineColor, conCTRelationType.LineColor); //LineColor
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTRelationType.LineColor); //LineColor
 }
 }
 
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.LineStyle))
 {
 if (objCTRelationTypeEN.LineStyle !=  null)
 {
 var strLineStyle = objCTRelationTypeEN.LineStyle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLineStyle, conCTRelationType.LineStyle); //LineStyle
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTRelationType.LineStyle); //LineStyle
 }
 }
 
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.LineWidth))
 {
 if (objCTRelationTypeEN.LineWidth !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCTRelationTypeEN.LineWidth, conCTRelationType.LineWidth); //LineWidth
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTRelationType.LineWidth); //LineWidth
 }
 }
 
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.ArrowType))
 {
 if (objCTRelationTypeEN.ArrowType !=  null)
 {
 var strArrowType = objCTRelationTypeEN.ArrowType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strArrowType, conCTRelationType.ArrowType); //箭头类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTRelationType.ArrowType); //箭头类型
 }
 }
 
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.DisplayColor))
 {
 if (objCTRelationTypeEN.DisplayColor !=  null)
 {
 var strDisplayColor = objCTRelationTypeEN.DisplayColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDisplayColor, conCTRelationType.DisplayColor); //DisplayColor
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTRelationType.DisplayColor); //DisplayColor
 }
 }
 
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.UpdDate))
 {
 if (objCTRelationTypeEN.UpdDate !=  null)
 {
 var strUpdDate = objCTRelationTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conCTRelationType.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTRelationType.UpdDate); //修改日期
 }
 }
 
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.UpdUser))
 {
 if (objCTRelationTypeEN.UpdUser !=  null)
 {
 var strUpdUser = objCTRelationTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conCTRelationType.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTRelationType.UpdUser); //修改者
 }
 }
 
 if (objCTRelationTypeEN.IsUpdated(conCTRelationType.Memo))
 {
 if (objCTRelationTypeEN.Memo !=  null)
 {
 var strMemo = objCTRelationTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCTRelationType.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTRelationType.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where CtRelationTypeId = '{0}'", objCTRelationTypeEN.CtRelationTypeId); 
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
 /// <param name = "strCtRelationTypeId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strCtRelationTypeId) 
{
CheckPrimaryKey(strCtRelationTypeId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTRelationTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strCtRelationTypeId,
};
 objSQL.ExecSP("CTRelationType_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strCtRelationTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strCtRelationTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strCtRelationTypeId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTRelationTypeDA.GetSpecSQLObj();
//删除CTRelationType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CTRelationType where CtRelationTypeId = " + "'"+ strCtRelationTypeId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelCTRelationType(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTRelationTypeDA.GetSpecSQLObj();
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
//删除CTRelationType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CTRelationType where CtRelationTypeId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strCtRelationTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strCtRelationTypeId) 
{
CheckPrimaryKey(strCtRelationTypeId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTRelationTypeDA.GetSpecSQLObj();
//删除CTRelationType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CTRelationType where CtRelationTypeId = " + "'"+ strCtRelationTypeId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelCTRelationType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsCTRelationTypeDA: DelCTRelationType)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTRelationTypeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CTRelationType where " + strCondition ;
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
public bool DelCTRelationTypeWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsCTRelationTypeDA: DelCTRelationTypeWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTRelationTypeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CTRelationType where " + strCondition ;
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
 /// <param name = "objCTRelationTypeENS">源对象</param>
 /// <param name = "objCTRelationTypeENT">目标对象</param>
public void CopyTo(clsCTRelationTypeEN objCTRelationTypeENS, clsCTRelationTypeEN objCTRelationTypeENT)
{
objCTRelationTypeENT.CtRelationTypeId = objCTRelationTypeENS.CtRelationTypeId; //Ct关系类型Id
objCTRelationTypeENT.RelationTypeName = objCTRelationTypeENS.RelationTypeName; //关系类型名
objCTRelationTypeENT.RelationTypeEN = objCTRelationTypeENS.RelationTypeEN; //关系类型英文名
objCTRelationTypeENT.Description = objCTRelationTypeENS.Description; //描述
objCTRelationTypeENT.OrderNum = objCTRelationTypeENS.OrderNum; //序号
objCTRelationTypeENT.InUse = objCTRelationTypeENS.InUse; //是否在用
objCTRelationTypeENT.LineColor = objCTRelationTypeENS.LineColor; //LineColor
objCTRelationTypeENT.LineStyle = objCTRelationTypeENS.LineStyle; //LineStyle
objCTRelationTypeENT.LineWidth = objCTRelationTypeENS.LineWidth; //LineWidth
objCTRelationTypeENT.ArrowType = objCTRelationTypeENS.ArrowType; //箭头类型
objCTRelationTypeENT.DisplayColor = objCTRelationTypeENS.DisplayColor; //DisplayColor
objCTRelationTypeENT.UpdDate = objCTRelationTypeENS.UpdDate; //修改日期
objCTRelationTypeENT.UpdUser = objCTRelationTypeENS.UpdUser; //修改者
objCTRelationTypeENT.Memo = objCTRelationTypeENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsCTRelationTypeEN objCTRelationTypeEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objCTRelationTypeEN.RelationTypeName, conCTRelationType.RelationTypeName);
//检查字段长度
clsCheckSql.CheckFieldLen(objCTRelationTypeEN.CtRelationTypeId, 2, conCTRelationType.CtRelationTypeId);
clsCheckSql.CheckFieldLen(objCTRelationTypeEN.RelationTypeName, 50, conCTRelationType.RelationTypeName);
clsCheckSql.CheckFieldLen(objCTRelationTypeEN.RelationTypeEN, 50, conCTRelationType.RelationTypeEN);
clsCheckSql.CheckFieldLen(objCTRelationTypeEN.Description, 300, conCTRelationType.Description);
clsCheckSql.CheckFieldLen(objCTRelationTypeEN.LineColor, 20, conCTRelationType.LineColor);
clsCheckSql.CheckFieldLen(objCTRelationTypeEN.LineStyle, 20, conCTRelationType.LineStyle);
clsCheckSql.CheckFieldLen(objCTRelationTypeEN.ArrowType, 20, conCTRelationType.ArrowType);
clsCheckSql.CheckFieldLen(objCTRelationTypeEN.DisplayColor, 20, conCTRelationType.DisplayColor);
clsCheckSql.CheckFieldLen(objCTRelationTypeEN.UpdDate, 20, conCTRelationType.UpdDate);
clsCheckSql.CheckFieldLen(objCTRelationTypeEN.UpdUser, 20, conCTRelationType.UpdUser);
clsCheckSql.CheckFieldLen(objCTRelationTypeEN.Memo, 1000, conCTRelationType.Memo);
//检查字段外键固定长度
 objCTRelationTypeEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsCTRelationTypeEN objCTRelationTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCTRelationTypeEN.RelationTypeName, 50, conCTRelationType.RelationTypeName);
clsCheckSql.CheckFieldLen(objCTRelationTypeEN.RelationTypeEN, 50, conCTRelationType.RelationTypeEN);
clsCheckSql.CheckFieldLen(objCTRelationTypeEN.Description, 300, conCTRelationType.Description);
clsCheckSql.CheckFieldLen(objCTRelationTypeEN.LineColor, 20, conCTRelationType.LineColor);
clsCheckSql.CheckFieldLen(objCTRelationTypeEN.LineStyle, 20, conCTRelationType.LineStyle);
clsCheckSql.CheckFieldLen(objCTRelationTypeEN.ArrowType, 20, conCTRelationType.ArrowType);
clsCheckSql.CheckFieldLen(objCTRelationTypeEN.DisplayColor, 20, conCTRelationType.DisplayColor);
clsCheckSql.CheckFieldLen(objCTRelationTypeEN.UpdDate, 20, conCTRelationType.UpdDate);
clsCheckSql.CheckFieldLen(objCTRelationTypeEN.UpdUser, 20, conCTRelationType.UpdUser);
clsCheckSql.CheckFieldLen(objCTRelationTypeEN.Memo, 1000, conCTRelationType.Memo);
//检查外键字段长度
 objCTRelationTypeEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsCTRelationTypeEN objCTRelationTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCTRelationTypeEN.CtRelationTypeId, 2, conCTRelationType.CtRelationTypeId);
clsCheckSql.CheckFieldLen(objCTRelationTypeEN.RelationTypeName, 50, conCTRelationType.RelationTypeName);
clsCheckSql.CheckFieldLen(objCTRelationTypeEN.RelationTypeEN, 50, conCTRelationType.RelationTypeEN);
clsCheckSql.CheckFieldLen(objCTRelationTypeEN.Description, 300, conCTRelationType.Description);
clsCheckSql.CheckFieldLen(objCTRelationTypeEN.LineColor, 20, conCTRelationType.LineColor);
clsCheckSql.CheckFieldLen(objCTRelationTypeEN.LineStyle, 20, conCTRelationType.LineStyle);
clsCheckSql.CheckFieldLen(objCTRelationTypeEN.ArrowType, 20, conCTRelationType.ArrowType);
clsCheckSql.CheckFieldLen(objCTRelationTypeEN.DisplayColor, 20, conCTRelationType.DisplayColor);
clsCheckSql.CheckFieldLen(objCTRelationTypeEN.UpdDate, 20, conCTRelationType.UpdDate);
clsCheckSql.CheckFieldLen(objCTRelationTypeEN.UpdUser, 20, conCTRelationType.UpdUser);
clsCheckSql.CheckFieldLen(objCTRelationTypeEN.Memo, 1000, conCTRelationType.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objCTRelationTypeEN.CtRelationTypeId, conCTRelationType.CtRelationTypeId);
clsCheckSql.CheckSqlInjection4Field(objCTRelationTypeEN.RelationTypeName, conCTRelationType.RelationTypeName);
clsCheckSql.CheckSqlInjection4Field(objCTRelationTypeEN.RelationTypeEN, conCTRelationType.RelationTypeEN);
clsCheckSql.CheckSqlInjection4Field(objCTRelationTypeEN.Description, conCTRelationType.Description);
clsCheckSql.CheckSqlInjection4Field(objCTRelationTypeEN.LineColor, conCTRelationType.LineColor);
clsCheckSql.CheckSqlInjection4Field(objCTRelationTypeEN.LineStyle, conCTRelationType.LineStyle);
clsCheckSql.CheckSqlInjection4Field(objCTRelationTypeEN.ArrowType, conCTRelationType.ArrowType);
clsCheckSql.CheckSqlInjection4Field(objCTRelationTypeEN.DisplayColor, conCTRelationType.DisplayColor);
clsCheckSql.CheckSqlInjection4Field(objCTRelationTypeEN.UpdDate, conCTRelationType.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objCTRelationTypeEN.UpdUser, conCTRelationType.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objCTRelationTypeEN.Memo, conCTRelationType.Memo);
//检查外键字段长度
 objCTRelationTypeEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetCtRelationTypeId()
{
//获取某学院所有专业信息
string strSQL = "select CtRelationTypeId, RelationTypeName from CTRelationType ";
 clsSpecSQLforSql mySql = clsCTRelationTypeDA.GetSpecSQLObj();
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
 objSQL = clsCTRelationTypeDA.GetSpecSQLObj();
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
 objSQL = clsCTRelationTypeDA.GetSpecSQLObj();
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
 objSQL = clsCTRelationTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCTRelationTypeEN._CurrTabName);
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
 objSQL = clsCTRelationTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCTRelationTypeEN._CurrTabName, strCondition);
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
 objSQL = clsCTRelationTypeDA.GetSpecSQLObj();
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
 objSQL = clsCTRelationTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}