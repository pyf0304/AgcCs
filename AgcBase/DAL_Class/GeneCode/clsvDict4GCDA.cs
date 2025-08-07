
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvDict4GCDA
 表名:vDict4GC(00050353)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:48:17
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
 /// v生成代码字典(vDict4GC)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvDict4GCDA : clsCommBase4DA
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
 return clsvDict4GCEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvDict4GCEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvDict4GCEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvDict4GCEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvDict4GCEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strDictId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strDictId)
{
strDictId = strDictId.Replace("'", "''");
if (strDictId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vDict4GC中,检查关键字,长度不正确!(clsvDict4GCDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strDictId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vDict4GC中,关键字不能为空 或 null!(clsvDict4GCDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strDictId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvDict4GCDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvDict4GCDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDict4GCDA.GetSpecSQLObj();
strSQL = "Select * from vDict4GC where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vDict4GC(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvDict4GCDA: GetDataTable_vDict4GC)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDict4GCDA.GetSpecSQLObj();
strSQL = "Select * from vDict4GC where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvDict4GCDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDict4GCDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvDict4GCDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDict4GCDA.GetSpecSQLObj();
strSQL = "Select * from vDict4GC where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvDict4GCDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDict4GCDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvDict4GCDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDict4GCDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vDict4GC where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vDict4GC where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvDict4GCDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDict4GCDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vDict4GC where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvDict4GCDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDict4GCDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vDict4GC.* " + 
$"from vDict4GC " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vDict4GC.DictId not in " + 
$"(Select top {intTop_In} vDict4GC.DictId from vDict4GC " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vDict4GC where {1} and DictId not in (Select top {2} DictId from vDict4GC where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vDict4GC where {1} and DictId not in (Select top {3} DictId from vDict4GC where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvDict4GCDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDict4GCDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vDict4GC.* " + 
$"from vDict4GC " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vDict4GC.DictId not in " + 
$"(Select top {intTop_In} vDict4GC.DictId from vDict4GC " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vDict4GC where {1} and DictId not in (Select top {2} DictId from vDict4GC where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vDict4GC where {1} and DictId not in (Select top {3} DictId from vDict4GC where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvDict4GCEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvDict4GCDA:GetObjLst)", objException.Message));
}
List<clsvDict4GCEN> arrObjLst = new List<clsvDict4GCEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDict4GCDA.GetSpecSQLObj();
strSQL = "Select * from vDict4GC where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDict4GCEN objvDict4GCEN = new clsvDict4GCEN();
try
{
objvDict4GCEN.DictId = objRow[convDict4GC.DictId].ToString().Trim(); //字典Id
objvDict4GCEN.DictValue = objRow[convDict4GC.DictValue].ToString().Trim(); //字典值
objvDict4GCEN.DictTypeId = objRow[convDict4GC.DictTypeId] == DBNull.Value ? null : objRow[convDict4GC.DictTypeId].ToString().Trim(); //字典类型Id
objvDict4GCEN.DictTypeName = objRow[convDict4GC.DictTypeName].ToString().Trim(); //字典类型名
objvDict4GCEN.DictKey1 = objRow[convDict4GC.DictKey1].ToString().Trim(); //字典关键字1
objvDict4GCEN.DictKey2 = objRow[convDict4GC.DictKey2].ToString().Trim(); //字典关键字2
objvDict4GCEN.UpdDate = objRow[convDict4GC.UpdDate] == DBNull.Value ? null : objRow[convDict4GC.UpdDate].ToString().Trim(); //修改日期
objvDict4GCEN.UpdUser = objRow[convDict4GC.UpdUser] == DBNull.Value ? null : objRow[convDict4GC.UpdUser].ToString().Trim(); //修改者
objvDict4GCEN.Memo = objRow[convDict4GC.Memo] == DBNull.Value ? null : objRow[convDict4GC.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvDict4GCDA: GetObjLst)", objException.Message));
}
objvDict4GCEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvDict4GCEN);
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
public List<clsvDict4GCEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvDict4GCDA:GetObjLstByTabName)", objException.Message));
}
List<clsvDict4GCEN> arrObjLst = new List<clsvDict4GCEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDict4GCDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDict4GCEN objvDict4GCEN = new clsvDict4GCEN();
try
{
objvDict4GCEN.DictId = objRow[convDict4GC.DictId].ToString().Trim(); //字典Id
objvDict4GCEN.DictValue = objRow[convDict4GC.DictValue].ToString().Trim(); //字典值
objvDict4GCEN.DictTypeId = objRow[convDict4GC.DictTypeId] == DBNull.Value ? null : objRow[convDict4GC.DictTypeId].ToString().Trim(); //字典类型Id
objvDict4GCEN.DictTypeName = objRow[convDict4GC.DictTypeName].ToString().Trim(); //字典类型名
objvDict4GCEN.DictKey1 = objRow[convDict4GC.DictKey1].ToString().Trim(); //字典关键字1
objvDict4GCEN.DictKey2 = objRow[convDict4GC.DictKey2].ToString().Trim(); //字典关键字2
objvDict4GCEN.UpdDate = objRow[convDict4GC.UpdDate] == DBNull.Value ? null : objRow[convDict4GC.UpdDate].ToString().Trim(); //修改日期
objvDict4GCEN.UpdUser = objRow[convDict4GC.UpdUser] == DBNull.Value ? null : objRow[convDict4GC.UpdUser].ToString().Trim(); //修改者
objvDict4GCEN.Memo = objRow[convDict4GC.Memo] == DBNull.Value ? null : objRow[convDict4GC.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvDict4GCDA: GetObjLst)", objException.Message));
}
objvDict4GCEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvDict4GCEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvDict4GCEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvDict4GC(ref clsvDict4GCEN objvDict4GCEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDict4GCDA.GetSpecSQLObj();
strSQL = "Select * from vDict4GC where DictId = " + "'"+ objvDict4GCEN.DictId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvDict4GCEN.DictId = objDT.Rows[0][convDict4GC.DictId].ToString().Trim(); //字典Id(字段类型:char,字段长度:8,是否可空:False)
 objvDict4GCEN.DictValue = objDT.Rows[0][convDict4GC.DictValue].ToString().Trim(); //字典值(字段类型:varchar,字段长度:500,是否可空:False)
 objvDict4GCEN.DictTypeId = objDT.Rows[0][convDict4GC.DictTypeId].ToString().Trim(); //字典类型Id(字段类型:char,字段长度:4,是否可空:True)
 objvDict4GCEN.DictTypeName = objDT.Rows[0][convDict4GC.DictTypeName].ToString().Trim(); //字典类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvDict4GCEN.DictKey1 = objDT.Rows[0][convDict4GC.DictKey1].ToString().Trim(); //字典关键字1(字段类型:varchar,字段长度:50,是否可空:False)
 objvDict4GCEN.DictKey2 = objDT.Rows[0][convDict4GC.DictKey2].ToString().Trim(); //字典关键字2(字段类型:varchar,字段长度:50,是否可空:False)
 objvDict4GCEN.UpdDate = objDT.Rows[0][convDict4GC.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvDict4GCEN.UpdUser = objDT.Rows[0][convDict4GC.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvDict4GCEN.Memo = objDT.Rows[0][convDict4GC.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvDict4GCDA: GetvDict4GC)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strDictId">表关键字</param>
 /// <returns>表对象</returns>
public clsvDict4GCEN GetObjByDictId(string strDictId)
{
CheckPrimaryKey(strDictId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDict4GCDA.GetSpecSQLObj();
strSQL = "Select * from vDict4GC where DictId = " + "'"+ strDictId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvDict4GCEN objvDict4GCEN = new clsvDict4GCEN();
try
{
 objvDict4GCEN.DictId = objRow[convDict4GC.DictId].ToString().Trim(); //字典Id(字段类型:char,字段长度:8,是否可空:False)
 objvDict4GCEN.DictValue = objRow[convDict4GC.DictValue].ToString().Trim(); //字典值(字段类型:varchar,字段长度:500,是否可空:False)
 objvDict4GCEN.DictTypeId = objRow[convDict4GC.DictTypeId] == DBNull.Value ? null : objRow[convDict4GC.DictTypeId].ToString().Trim(); //字典类型Id(字段类型:char,字段长度:4,是否可空:True)
 objvDict4GCEN.DictTypeName = objRow[convDict4GC.DictTypeName].ToString().Trim(); //字典类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvDict4GCEN.DictKey1 = objRow[convDict4GC.DictKey1].ToString().Trim(); //字典关键字1(字段类型:varchar,字段长度:50,是否可空:False)
 objvDict4GCEN.DictKey2 = objRow[convDict4GC.DictKey2].ToString().Trim(); //字典关键字2(字段类型:varchar,字段长度:50,是否可空:False)
 objvDict4GCEN.UpdDate = objRow[convDict4GC.UpdDate] == DBNull.Value ? null : objRow[convDict4GC.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvDict4GCEN.UpdUser = objRow[convDict4GC.UpdUser] == DBNull.Value ? null : objRow[convDict4GC.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvDict4GCEN.Memo = objRow[convDict4GC.Memo] == DBNull.Value ? null : objRow[convDict4GC.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvDict4GCDA: GetObjByDictId)", objException.Message));
}
return objvDict4GCEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvDict4GCEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvDict4GCDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDict4GCDA.GetSpecSQLObj();
strSQL = "Select * from vDict4GC where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvDict4GCEN objvDict4GCEN = new clsvDict4GCEN()
{
DictId = objRow[convDict4GC.DictId].ToString().Trim(), //字典Id
DictValue = objRow[convDict4GC.DictValue].ToString().Trim(), //字典值
DictTypeId = objRow[convDict4GC.DictTypeId] == DBNull.Value ? null : objRow[convDict4GC.DictTypeId].ToString().Trim(), //字典类型Id
DictTypeName = objRow[convDict4GC.DictTypeName].ToString().Trim(), //字典类型名
DictKey1 = objRow[convDict4GC.DictKey1].ToString().Trim(), //字典关键字1
DictKey2 = objRow[convDict4GC.DictKey2].ToString().Trim(), //字典关键字2
UpdDate = objRow[convDict4GC.UpdDate] == DBNull.Value ? null : objRow[convDict4GC.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convDict4GC.UpdUser] == DBNull.Value ? null : objRow[convDict4GC.UpdUser].ToString().Trim(), //修改者
Memo = objRow[convDict4GC.Memo] == DBNull.Value ? null : objRow[convDict4GC.Memo].ToString().Trim() //说明
};
objvDict4GCEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvDict4GCEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvDict4GCDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvDict4GCEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvDict4GCEN objvDict4GCEN = new clsvDict4GCEN();
try
{
objvDict4GCEN.DictId = objRow[convDict4GC.DictId].ToString().Trim(); //字典Id
objvDict4GCEN.DictValue = objRow[convDict4GC.DictValue].ToString().Trim(); //字典值
objvDict4GCEN.DictTypeId = objRow[convDict4GC.DictTypeId] == DBNull.Value ? null : objRow[convDict4GC.DictTypeId].ToString().Trim(); //字典类型Id
objvDict4GCEN.DictTypeName = objRow[convDict4GC.DictTypeName].ToString().Trim(); //字典类型名
objvDict4GCEN.DictKey1 = objRow[convDict4GC.DictKey1].ToString().Trim(); //字典关键字1
objvDict4GCEN.DictKey2 = objRow[convDict4GC.DictKey2].ToString().Trim(); //字典关键字2
objvDict4GCEN.UpdDate = objRow[convDict4GC.UpdDate] == DBNull.Value ? null : objRow[convDict4GC.UpdDate].ToString().Trim(); //修改日期
objvDict4GCEN.UpdUser = objRow[convDict4GC.UpdUser] == DBNull.Value ? null : objRow[convDict4GC.UpdUser].ToString().Trim(); //修改者
objvDict4GCEN.Memo = objRow[convDict4GC.Memo] == DBNull.Value ? null : objRow[convDict4GC.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvDict4GCDA: GetObjByDataRowvDict4GC)", objException.Message));
}
objvDict4GCEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvDict4GCEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvDict4GCEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvDict4GCEN objvDict4GCEN = new clsvDict4GCEN();
try
{
objvDict4GCEN.DictId = objRow[convDict4GC.DictId].ToString().Trim(); //字典Id
objvDict4GCEN.DictValue = objRow[convDict4GC.DictValue].ToString().Trim(); //字典值
objvDict4GCEN.DictTypeId = objRow[convDict4GC.DictTypeId] == DBNull.Value ? null : objRow[convDict4GC.DictTypeId].ToString().Trim(); //字典类型Id
objvDict4GCEN.DictTypeName = objRow[convDict4GC.DictTypeName].ToString().Trim(); //字典类型名
objvDict4GCEN.DictKey1 = objRow[convDict4GC.DictKey1].ToString().Trim(); //字典关键字1
objvDict4GCEN.DictKey2 = objRow[convDict4GC.DictKey2].ToString().Trim(); //字典关键字2
objvDict4GCEN.UpdDate = objRow[convDict4GC.UpdDate] == DBNull.Value ? null : objRow[convDict4GC.UpdDate].ToString().Trim(); //修改日期
objvDict4GCEN.UpdUser = objRow[convDict4GC.UpdUser] == DBNull.Value ? null : objRow[convDict4GC.UpdUser].ToString().Trim(); //修改者
objvDict4GCEN.Memo = objRow[convDict4GC.Memo] == DBNull.Value ? null : objRow[convDict4GC.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvDict4GCDA: GetObjByDataRow)", objException.Message));
}
objvDict4GCEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvDict4GCEN;
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
objSQL = clsvDict4GCDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvDict4GCEN._CurrTabName, convDict4GC.DictId, 8, "");
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
objSQL = clsvDict4GCDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvDict4GCEN._CurrTabName, convDict4GC.DictId, 8, strPrefix);
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
 objSQL = clsvDict4GCDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select DictId from vDict4GC where " + strCondition;
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
 objSQL = clsvDict4GCDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select DictId from vDict4GC where " + strCondition;
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
 /// <param name = "strDictId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strDictId)
{
CheckPrimaryKey(strDictId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDict4GCDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vDict4GC", "DictId = " + "'"+ strDictId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvDict4GCDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDict4GCDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vDict4GC", strCondition))
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
objSQL = clsvDict4GCDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vDict4GC");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvDict4GCENS">源对象</param>
 /// <param name = "objvDict4GCENT">目标对象</param>
public void CopyTo(clsvDict4GCEN objvDict4GCENS, clsvDict4GCEN objvDict4GCENT)
{
objvDict4GCENT.DictId = objvDict4GCENS.DictId; //字典Id
objvDict4GCENT.DictValue = objvDict4GCENS.DictValue; //字典值
objvDict4GCENT.DictTypeId = objvDict4GCENS.DictTypeId; //字典类型Id
objvDict4GCENT.DictTypeName = objvDict4GCENS.DictTypeName; //字典类型名
objvDict4GCENT.DictKey1 = objvDict4GCENS.DictKey1; //字典关键字1
objvDict4GCENT.DictKey2 = objvDict4GCENS.DictKey2; //字典关键字2
objvDict4GCENT.UpdDate = objvDict4GCENS.UpdDate; //修改日期
objvDict4GCENT.UpdUser = objvDict4GCENS.UpdUser; //修改者
objvDict4GCENT.Memo = objvDict4GCENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvDict4GCEN objvDict4GCEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvDict4GCEN.DictId, 8, convDict4GC.DictId);
clsCheckSql.CheckFieldLen(objvDict4GCEN.DictValue, 500, convDict4GC.DictValue);
clsCheckSql.CheckFieldLen(objvDict4GCEN.DictTypeId, 4, convDict4GC.DictTypeId);
clsCheckSql.CheckFieldLen(objvDict4GCEN.DictTypeName, 50, convDict4GC.DictTypeName);
clsCheckSql.CheckFieldLen(objvDict4GCEN.DictKey1, 50, convDict4GC.DictKey1);
clsCheckSql.CheckFieldLen(objvDict4GCEN.DictKey2, 50, convDict4GC.DictKey2);
clsCheckSql.CheckFieldLen(objvDict4GCEN.UpdDate, 20, convDict4GC.UpdDate);
clsCheckSql.CheckFieldLen(objvDict4GCEN.UpdUser, 20, convDict4GC.UpdUser);
clsCheckSql.CheckFieldLen(objvDict4GCEN.Memo, 1000, convDict4GC.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvDict4GCEN.DictId, convDict4GC.DictId);
clsCheckSql.CheckSqlInjection4Field(objvDict4GCEN.DictValue, convDict4GC.DictValue);
clsCheckSql.CheckSqlInjection4Field(objvDict4GCEN.DictTypeId, convDict4GC.DictTypeId);
clsCheckSql.CheckSqlInjection4Field(objvDict4GCEN.DictTypeName, convDict4GC.DictTypeName);
clsCheckSql.CheckSqlInjection4Field(objvDict4GCEN.DictKey1, convDict4GC.DictKey1);
clsCheckSql.CheckSqlInjection4Field(objvDict4GCEN.DictKey2, convDict4GC.DictKey2);
clsCheckSql.CheckSqlInjection4Field(objvDict4GCEN.UpdDate, convDict4GC.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvDict4GCEN.UpdUser, convDict4GC.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvDict4GCEN.Memo, convDict4GC.Memo);
//检查外键字段长度
 objvDict4GCEN._IsCheckProperty = true;
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
 objSQL = clsvDict4GCDA.GetSpecSQLObj();
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
 objSQL = clsvDict4GCDA.GetSpecSQLObj();
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
 objSQL = clsvDict4GCDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvDict4GCEN._CurrTabName);
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
 objSQL = clsvDict4GCDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvDict4GCEN._CurrTabName, strCondition);
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
 objSQL = clsvDict4GCDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}