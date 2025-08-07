
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvDnFunctionDA
 表名:vDnFunction(00050553)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:28:03
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:AI模块(AIModule)
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
 /// vDnFunction(vDnFunction)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvDnFunctionDA : clsCommBase4DA
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
 return clsvDnFunctionEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvDnFunctionEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvDnFunctionEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvDnFunctionEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvDnFunctionEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strDnFunctionId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strDnFunctionId)
{
strDnFunctionId = strDnFunctionId.Replace("'", "''");
if (strDnFunctionId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vDnFunction中,检查关键字,长度不正确!(clsvDnFunctionDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strDnFunctionId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vDnFunction中,关键字不能为空 或 null!(clsvDnFunctionDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strDnFunctionId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvDnFunctionDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvDnFunctionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDnFunctionDA.GetSpecSQLObj();
strSQL = "Select * from vDnFunction where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vDnFunction(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvDnFunctionDA: GetDataTable_vDnFunction)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDnFunctionDA.GetSpecSQLObj();
strSQL = "Select * from vDnFunction where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvDnFunctionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDnFunctionDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvDnFunctionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDnFunctionDA.GetSpecSQLObj();
strSQL = "Select * from vDnFunction where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvDnFunctionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDnFunctionDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvDnFunctionDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDnFunctionDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vDnFunction where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vDnFunction where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvDnFunctionDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDnFunctionDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vDnFunction where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvDnFunctionDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDnFunctionDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vDnFunction.* " + 
$"from vDnFunction " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vDnFunction.DnFunctionId not in " + 
$"(Select top {intTop_In} vDnFunction.DnFunctionId from vDnFunction " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vDnFunction where {1} and DnFunctionId not in (Select top {2} DnFunctionId from vDnFunction where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vDnFunction where {1} and DnFunctionId not in (Select top {3} DnFunctionId from vDnFunction where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvDnFunctionDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDnFunctionDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vDnFunction.* " + 
$"from vDnFunction " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vDnFunction.DnFunctionId not in " + 
$"(Select top {intTop_In} vDnFunction.DnFunctionId from vDnFunction " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vDnFunction where {1} and DnFunctionId not in (Select top {2} DnFunctionId from vDnFunction where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vDnFunction where {1} and DnFunctionId not in (Select top {3} DnFunctionId from vDnFunction where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvDnFunctionEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvDnFunctionDA:GetObjLst)", objException.Message));
}
List<clsvDnFunctionEN> arrObjLst = new List<clsvDnFunctionEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDnFunctionDA.GetSpecSQLObj();
strSQL = "Select * from vDnFunction where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDnFunctionEN objvDnFunctionEN = new clsvDnFunctionEN();
try
{
objvDnFunctionEN.DnFunctionId = objRow[convDnFunction.DnFunctionId].ToString().Trim(); //DN函数Id
objvDnFunctionEN.DnFunctionName = objRow[convDnFunction.DnFunctionName] == DBNull.Value ? null : objRow[convDnFunction.DnFunctionName].ToString().Trim(); //DN函数
objvDnFunctionEN.AssociationMappingId = objRow[convDnFunction.AssociationMappingId] == DBNull.Value ? null : objRow[convDnFunction.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objvDnFunctionEN.AssociationMappingName = objRow[convDnFunction.AssociationMappingName] == DBNull.Value ? null : objRow[convDnFunction.AssociationMappingName].ToString().Trim(); //关联关系映射名
objvDnFunctionEN.ImportClass = objRow[convDnFunction.ImportClass] == DBNull.Value ? null : objRow[convDnFunction.ImportClass].ToString().Trim(); //导入类
objvDnFunctionEN.ImportPath = objRow[convDnFunction.ImportPath] == DBNull.Value ? null : objRow[convDnFunction.ImportPath].ToString().Trim(); //导入路径
objvDnFunctionEN.PrjId = objRow[convDnFunction.PrjId].ToString().Trim(); //工程Id
objvDnFunctionEN.UpdDate = objRow[convDnFunction.UpdDate] == DBNull.Value ? null : objRow[convDnFunction.UpdDate].ToString().Trim(); //修改日期
objvDnFunctionEN.UpdUser = objRow[convDnFunction.UpdUser] == DBNull.Value ? null : objRow[convDnFunction.UpdUser].ToString().Trim(); //修改者
objvDnFunctionEN.Memo = objRow[convDnFunction.Memo] == DBNull.Value ? null : objRow[convDnFunction.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvDnFunctionDA: GetObjLst)", objException.Message));
}
objvDnFunctionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvDnFunctionEN);
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
public List<clsvDnFunctionEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvDnFunctionDA:GetObjLstByTabName)", objException.Message));
}
List<clsvDnFunctionEN> arrObjLst = new List<clsvDnFunctionEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDnFunctionDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDnFunctionEN objvDnFunctionEN = new clsvDnFunctionEN();
try
{
objvDnFunctionEN.DnFunctionId = objRow[convDnFunction.DnFunctionId].ToString().Trim(); //DN函数Id
objvDnFunctionEN.DnFunctionName = objRow[convDnFunction.DnFunctionName] == DBNull.Value ? null : objRow[convDnFunction.DnFunctionName].ToString().Trim(); //DN函数
objvDnFunctionEN.AssociationMappingId = objRow[convDnFunction.AssociationMappingId] == DBNull.Value ? null : objRow[convDnFunction.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objvDnFunctionEN.AssociationMappingName = objRow[convDnFunction.AssociationMappingName] == DBNull.Value ? null : objRow[convDnFunction.AssociationMappingName].ToString().Trim(); //关联关系映射名
objvDnFunctionEN.ImportClass = objRow[convDnFunction.ImportClass] == DBNull.Value ? null : objRow[convDnFunction.ImportClass].ToString().Trim(); //导入类
objvDnFunctionEN.ImportPath = objRow[convDnFunction.ImportPath] == DBNull.Value ? null : objRow[convDnFunction.ImportPath].ToString().Trim(); //导入路径
objvDnFunctionEN.PrjId = objRow[convDnFunction.PrjId].ToString().Trim(); //工程Id
objvDnFunctionEN.UpdDate = objRow[convDnFunction.UpdDate] == DBNull.Value ? null : objRow[convDnFunction.UpdDate].ToString().Trim(); //修改日期
objvDnFunctionEN.UpdUser = objRow[convDnFunction.UpdUser] == DBNull.Value ? null : objRow[convDnFunction.UpdUser].ToString().Trim(); //修改者
objvDnFunctionEN.Memo = objRow[convDnFunction.Memo] == DBNull.Value ? null : objRow[convDnFunction.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvDnFunctionDA: GetObjLst)", objException.Message));
}
objvDnFunctionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvDnFunctionEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvDnFunctionEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvDnFunction(ref clsvDnFunctionEN objvDnFunctionEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDnFunctionDA.GetSpecSQLObj();
strSQL = "Select * from vDnFunction where DnFunctionId = " + "'"+ objvDnFunctionEN.DnFunctionId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvDnFunctionEN.DnFunctionId = objDT.Rows[0][convDnFunction.DnFunctionId].ToString().Trim(); //DN函数Id(字段类型:char,字段长度:8,是否可空:True)
 objvDnFunctionEN.DnFunctionName = objDT.Rows[0][convDnFunction.DnFunctionName].ToString().Trim(); //DN函数(字段类型:varchar,字段长度:50,是否可空:True)
 objvDnFunctionEN.AssociationMappingId = objDT.Rows[0][convDnFunction.AssociationMappingId].ToString().Trim(); //关联关系映射Id(字段类型:char,字段长度:2,是否可空:True)
 objvDnFunctionEN.AssociationMappingName = objDT.Rows[0][convDnFunction.AssociationMappingName].ToString().Trim(); //关联关系映射名(字段类型:varchar,字段长度:50,是否可空:True)
 objvDnFunctionEN.ImportClass = objDT.Rows[0][convDnFunction.ImportClass].ToString().Trim(); //导入类(字段类型:varchar,字段长度:50,是否可空:True)
 objvDnFunctionEN.ImportPath = objDT.Rows[0][convDnFunction.ImportPath].ToString().Trim(); //导入路径(字段类型:varchar,字段长度:100,是否可空:True)
 objvDnFunctionEN.PrjId = objDT.Rows[0][convDnFunction.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvDnFunctionEN.UpdDate = objDT.Rows[0][convDnFunction.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvDnFunctionEN.UpdUser = objDT.Rows[0][convDnFunction.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvDnFunctionEN.Memo = objDT.Rows[0][convDnFunction.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvDnFunctionDA: GetvDnFunction)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strDnFunctionId">表关键字</param>
 /// <returns>表对象</returns>
public clsvDnFunctionEN GetObjByDnFunctionId(string strDnFunctionId)
{
CheckPrimaryKey(strDnFunctionId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDnFunctionDA.GetSpecSQLObj();
strSQL = "Select * from vDnFunction where DnFunctionId = " + "'"+ strDnFunctionId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvDnFunctionEN objvDnFunctionEN = new clsvDnFunctionEN();
try
{
 objvDnFunctionEN.DnFunctionId = objRow[convDnFunction.DnFunctionId].ToString().Trim(); //DN函数Id(字段类型:char,字段长度:8,是否可空:True)
 objvDnFunctionEN.DnFunctionName = objRow[convDnFunction.DnFunctionName] == DBNull.Value ? null : objRow[convDnFunction.DnFunctionName].ToString().Trim(); //DN函数(字段类型:varchar,字段长度:50,是否可空:True)
 objvDnFunctionEN.AssociationMappingId = objRow[convDnFunction.AssociationMappingId] == DBNull.Value ? null : objRow[convDnFunction.AssociationMappingId].ToString().Trim(); //关联关系映射Id(字段类型:char,字段长度:2,是否可空:True)
 objvDnFunctionEN.AssociationMappingName = objRow[convDnFunction.AssociationMappingName] == DBNull.Value ? null : objRow[convDnFunction.AssociationMappingName].ToString().Trim(); //关联关系映射名(字段类型:varchar,字段长度:50,是否可空:True)
 objvDnFunctionEN.ImportClass = objRow[convDnFunction.ImportClass] == DBNull.Value ? null : objRow[convDnFunction.ImportClass].ToString().Trim(); //导入类(字段类型:varchar,字段长度:50,是否可空:True)
 objvDnFunctionEN.ImportPath = objRow[convDnFunction.ImportPath] == DBNull.Value ? null : objRow[convDnFunction.ImportPath].ToString().Trim(); //导入路径(字段类型:varchar,字段长度:100,是否可空:True)
 objvDnFunctionEN.PrjId = objRow[convDnFunction.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvDnFunctionEN.UpdDate = objRow[convDnFunction.UpdDate] == DBNull.Value ? null : objRow[convDnFunction.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvDnFunctionEN.UpdUser = objRow[convDnFunction.UpdUser] == DBNull.Value ? null : objRow[convDnFunction.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvDnFunctionEN.Memo = objRow[convDnFunction.Memo] == DBNull.Value ? null : objRow[convDnFunction.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvDnFunctionDA: GetObjByDnFunctionId)", objException.Message));
}
return objvDnFunctionEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvDnFunctionEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvDnFunctionDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDnFunctionDA.GetSpecSQLObj();
strSQL = "Select * from vDnFunction where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvDnFunctionEN objvDnFunctionEN = new clsvDnFunctionEN()
{
DnFunctionId = objRow[convDnFunction.DnFunctionId].ToString().Trim(), //DN函数Id
DnFunctionName = objRow[convDnFunction.DnFunctionName] == DBNull.Value ? null : objRow[convDnFunction.DnFunctionName].ToString().Trim(), //DN函数
AssociationMappingId = objRow[convDnFunction.AssociationMappingId] == DBNull.Value ? null : objRow[convDnFunction.AssociationMappingId].ToString().Trim(), //关联关系映射Id
AssociationMappingName = objRow[convDnFunction.AssociationMappingName] == DBNull.Value ? null : objRow[convDnFunction.AssociationMappingName].ToString().Trim(), //关联关系映射名
ImportClass = objRow[convDnFunction.ImportClass] == DBNull.Value ? null : objRow[convDnFunction.ImportClass].ToString().Trim(), //导入类
ImportPath = objRow[convDnFunction.ImportPath] == DBNull.Value ? null : objRow[convDnFunction.ImportPath].ToString().Trim(), //导入路径
PrjId = objRow[convDnFunction.PrjId].ToString().Trim(), //工程Id
UpdDate = objRow[convDnFunction.UpdDate] == DBNull.Value ? null : objRow[convDnFunction.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convDnFunction.UpdUser] == DBNull.Value ? null : objRow[convDnFunction.UpdUser].ToString().Trim(), //修改者
Memo = objRow[convDnFunction.Memo] == DBNull.Value ? null : objRow[convDnFunction.Memo].ToString().Trim() //说明
};
objvDnFunctionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvDnFunctionEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvDnFunctionDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvDnFunctionEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvDnFunctionEN objvDnFunctionEN = new clsvDnFunctionEN();
try
{
objvDnFunctionEN.DnFunctionId = objRow[convDnFunction.DnFunctionId].ToString().Trim(); //DN函数Id
objvDnFunctionEN.DnFunctionName = objRow[convDnFunction.DnFunctionName] == DBNull.Value ? null : objRow[convDnFunction.DnFunctionName].ToString().Trim(); //DN函数
objvDnFunctionEN.AssociationMappingId = objRow[convDnFunction.AssociationMappingId] == DBNull.Value ? null : objRow[convDnFunction.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objvDnFunctionEN.AssociationMappingName = objRow[convDnFunction.AssociationMappingName] == DBNull.Value ? null : objRow[convDnFunction.AssociationMappingName].ToString().Trim(); //关联关系映射名
objvDnFunctionEN.ImportClass = objRow[convDnFunction.ImportClass] == DBNull.Value ? null : objRow[convDnFunction.ImportClass].ToString().Trim(); //导入类
objvDnFunctionEN.ImportPath = objRow[convDnFunction.ImportPath] == DBNull.Value ? null : objRow[convDnFunction.ImportPath].ToString().Trim(); //导入路径
objvDnFunctionEN.PrjId = objRow[convDnFunction.PrjId].ToString().Trim(); //工程Id
objvDnFunctionEN.UpdDate = objRow[convDnFunction.UpdDate] == DBNull.Value ? null : objRow[convDnFunction.UpdDate].ToString().Trim(); //修改日期
objvDnFunctionEN.UpdUser = objRow[convDnFunction.UpdUser] == DBNull.Value ? null : objRow[convDnFunction.UpdUser].ToString().Trim(); //修改者
objvDnFunctionEN.Memo = objRow[convDnFunction.Memo] == DBNull.Value ? null : objRow[convDnFunction.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvDnFunctionDA: GetObjByDataRowvDnFunction)", objException.Message));
}
objvDnFunctionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvDnFunctionEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvDnFunctionEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvDnFunctionEN objvDnFunctionEN = new clsvDnFunctionEN();
try
{
objvDnFunctionEN.DnFunctionId = objRow[convDnFunction.DnFunctionId].ToString().Trim(); //DN函数Id
objvDnFunctionEN.DnFunctionName = objRow[convDnFunction.DnFunctionName] == DBNull.Value ? null : objRow[convDnFunction.DnFunctionName].ToString().Trim(); //DN函数
objvDnFunctionEN.AssociationMappingId = objRow[convDnFunction.AssociationMappingId] == DBNull.Value ? null : objRow[convDnFunction.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objvDnFunctionEN.AssociationMappingName = objRow[convDnFunction.AssociationMappingName] == DBNull.Value ? null : objRow[convDnFunction.AssociationMappingName].ToString().Trim(); //关联关系映射名
objvDnFunctionEN.ImportClass = objRow[convDnFunction.ImportClass] == DBNull.Value ? null : objRow[convDnFunction.ImportClass].ToString().Trim(); //导入类
objvDnFunctionEN.ImportPath = objRow[convDnFunction.ImportPath] == DBNull.Value ? null : objRow[convDnFunction.ImportPath].ToString().Trim(); //导入路径
objvDnFunctionEN.PrjId = objRow[convDnFunction.PrjId].ToString().Trim(); //工程Id
objvDnFunctionEN.UpdDate = objRow[convDnFunction.UpdDate] == DBNull.Value ? null : objRow[convDnFunction.UpdDate].ToString().Trim(); //修改日期
objvDnFunctionEN.UpdUser = objRow[convDnFunction.UpdUser] == DBNull.Value ? null : objRow[convDnFunction.UpdUser].ToString().Trim(); //修改者
objvDnFunctionEN.Memo = objRow[convDnFunction.Memo] == DBNull.Value ? null : objRow[convDnFunction.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvDnFunctionDA: GetObjByDataRow)", objException.Message));
}
objvDnFunctionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvDnFunctionEN;
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
objSQL = clsvDnFunctionDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvDnFunctionEN._CurrTabName, convDnFunction.DnFunctionId, 8, "");
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
objSQL = clsvDnFunctionDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvDnFunctionEN._CurrTabName, convDnFunction.DnFunctionId, 8, strPrefix);
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
 objSQL = clsvDnFunctionDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select DnFunctionId from vDnFunction where " + strCondition;
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
 objSQL = clsvDnFunctionDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select DnFunctionId from vDnFunction where " + strCondition;
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
 /// <param name = "strDnFunctionId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strDnFunctionId)
{
CheckPrimaryKey(strDnFunctionId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDnFunctionDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vDnFunction", "DnFunctionId = " + "'"+ strDnFunctionId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvDnFunctionDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDnFunctionDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vDnFunction", strCondition))
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
objSQL = clsvDnFunctionDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vDnFunction");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvDnFunctionENS">源对象</param>
 /// <param name = "objvDnFunctionENT">目标对象</param>
public void CopyTo(clsvDnFunctionEN objvDnFunctionENS, clsvDnFunctionEN objvDnFunctionENT)
{
objvDnFunctionENT.DnFunctionId = objvDnFunctionENS.DnFunctionId; //DN函数Id
objvDnFunctionENT.DnFunctionName = objvDnFunctionENS.DnFunctionName; //DN函数
objvDnFunctionENT.AssociationMappingId = objvDnFunctionENS.AssociationMappingId; //关联关系映射Id
objvDnFunctionENT.AssociationMappingName = objvDnFunctionENS.AssociationMappingName; //关联关系映射名
objvDnFunctionENT.ImportClass = objvDnFunctionENS.ImportClass; //导入类
objvDnFunctionENT.ImportPath = objvDnFunctionENS.ImportPath; //导入路径
objvDnFunctionENT.PrjId = objvDnFunctionENS.PrjId; //工程Id
objvDnFunctionENT.UpdDate = objvDnFunctionENS.UpdDate; //修改日期
objvDnFunctionENT.UpdUser = objvDnFunctionENS.UpdUser; //修改者
objvDnFunctionENT.Memo = objvDnFunctionENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvDnFunctionEN objvDnFunctionEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvDnFunctionEN.DnFunctionId, 8, convDnFunction.DnFunctionId);
clsCheckSql.CheckFieldLen(objvDnFunctionEN.DnFunctionName, 50, convDnFunction.DnFunctionName);
clsCheckSql.CheckFieldLen(objvDnFunctionEN.AssociationMappingId, 2, convDnFunction.AssociationMappingId);
clsCheckSql.CheckFieldLen(objvDnFunctionEN.AssociationMappingName, 50, convDnFunction.AssociationMappingName);
clsCheckSql.CheckFieldLen(objvDnFunctionEN.ImportClass, 50, convDnFunction.ImportClass);
clsCheckSql.CheckFieldLen(objvDnFunctionEN.ImportPath, 100, convDnFunction.ImportPath);
clsCheckSql.CheckFieldLen(objvDnFunctionEN.PrjId, 4, convDnFunction.PrjId);
clsCheckSql.CheckFieldLen(objvDnFunctionEN.UpdDate, 20, convDnFunction.UpdDate);
clsCheckSql.CheckFieldLen(objvDnFunctionEN.UpdUser, 20, convDnFunction.UpdUser);
clsCheckSql.CheckFieldLen(objvDnFunctionEN.Memo, 1000, convDnFunction.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvDnFunctionEN.DnFunctionId, convDnFunction.DnFunctionId);
clsCheckSql.CheckSqlInjection4Field(objvDnFunctionEN.DnFunctionName, convDnFunction.DnFunctionName);
clsCheckSql.CheckSqlInjection4Field(objvDnFunctionEN.AssociationMappingId, convDnFunction.AssociationMappingId);
clsCheckSql.CheckSqlInjection4Field(objvDnFunctionEN.AssociationMappingName, convDnFunction.AssociationMappingName);
clsCheckSql.CheckSqlInjection4Field(objvDnFunctionEN.ImportClass, convDnFunction.ImportClass);
clsCheckSql.CheckSqlInjection4Field(objvDnFunctionEN.ImportPath, convDnFunction.ImportPath);
clsCheckSql.CheckSqlInjection4Field(objvDnFunctionEN.PrjId, convDnFunction.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvDnFunctionEN.UpdDate, convDnFunction.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvDnFunctionEN.UpdUser, convDnFunction.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvDnFunctionEN.Memo, convDnFunction.Memo);
//检查外键字段长度
 objvDnFunctionEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--vDnFunction(vDnFunction),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objvDnFunctionEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsvDnFunctionEN objvDnFunctionEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objvDnFunctionEN.DnFunctionName == null)
{
 sbCondition.AppendFormat(" and DnFunctionName is null");
}
else
{
 sbCondition.AppendFormat(" and DnFunctionName = '{0}'", objvDnFunctionEN.DnFunctionName);
}
 sbCondition.AppendFormat(" and PrjId = '{0}'", objvDnFunctionEN.PrjId);
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
 objSQL = clsvDnFunctionDA.GetSpecSQLObj();
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
 objSQL = clsvDnFunctionDA.GetSpecSQLObj();
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
 objSQL = clsvDnFunctionDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvDnFunctionEN._CurrTabName);
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
 objSQL = clsvDnFunctionDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvDnFunctionEN._CurrTabName, strCondition);
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
 objSQL = clsvDnFunctionDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}