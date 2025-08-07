
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsGCContainerTypeDA
 表名:GCContainerType(00050563)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:31:51
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
 /// GC容器类型(GCContainerType)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsGCContainerTypeDA : clsCommBase4DA
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
 return clsGCContainerTypeEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsGCContainerTypeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsGCContainerTypeEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsGCContainerTypeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsGCContainerTypeEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strContainerTypeId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strContainerTypeId)
{
strContainerTypeId = strContainerTypeId.Replace("'", "''");
if (strContainerTypeId.Length > 4)
{
throw new Exception("(errid:Data000001)在表:GCContainerType中,检查关键字,长度不正确!(clsGCContainerTypeDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strContainerTypeId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:GCContainerType中,关键字不能为空 或 null!(clsGCContainerTypeDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strContainerTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsGCContainerTypeDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsGCContainerTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCContainerTypeDA.GetSpecSQLObj();
strSQL = "Select * from GCContainerType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_GCContainerType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsGCContainerTypeDA: GetDataTable_GCContainerType)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCContainerTypeDA.GetSpecSQLObj();
strSQL = "Select * from GCContainerType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsGCContainerTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCContainerTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsGCContainerTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCContainerTypeDA.GetSpecSQLObj();
strSQL = "Select * from GCContainerType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsGCContainerTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCContainerTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsGCContainerTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCContainerTypeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from GCContainerType where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from GCContainerType where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsGCContainerTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCContainerTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from GCContainerType where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsGCContainerTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCContainerTypeDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} GCContainerType.* " + 
$"from GCContainerType " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and GCContainerType.ContainerTypeId not in " + 
$"(Select top {intTop_In} GCContainerType.ContainerTypeId from GCContainerType " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from GCContainerType where {1} and ContainerTypeId not in (Select top {2} ContainerTypeId from GCContainerType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from GCContainerType where {1} and ContainerTypeId not in (Select top {3} ContainerTypeId from GCContainerType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsGCContainerTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCContainerTypeDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} GCContainerType.* " + 
$"from GCContainerType " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and GCContainerType.ContainerTypeId not in " + 
$"(Select top {intTop_In} GCContainerType.ContainerTypeId from GCContainerType " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from GCContainerType where {1} and ContainerTypeId not in (Select top {2} ContainerTypeId from GCContainerType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from GCContainerType where {1} and ContainerTypeId not in (Select top {3} ContainerTypeId from GCContainerType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsGCContainerTypeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsGCContainerTypeDA:GetObjLst)", objException.Message));
}
List<clsGCContainerTypeEN> arrObjLst = new List<clsGCContainerTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCContainerTypeDA.GetSpecSQLObj();
strSQL = "Select * from GCContainerType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCContainerTypeEN objGCContainerTypeEN = new clsGCContainerTypeEN();
try
{
objGCContainerTypeEN.ContainerTypeId = objRow[conGCContainerType.ContainerTypeId].ToString().Trim(); //容器类型Id
objGCContainerTypeEN.ContainerTypeName = objRow[conGCContainerType.ContainerTypeName].ToString().Trim(); //容器类型名
objGCContainerTypeEN.ContainerTypeENName = objRow[conGCContainerType.ContainerTypeENName].ToString().Trim(); //容器类型英文名
objGCContainerTypeEN.UpdDate = objRow[conGCContainerType.UpdDate] == DBNull.Value ? null : objRow[conGCContainerType.UpdDate].ToString().Trim(); //修改日期
objGCContainerTypeEN.UpdUser = objRow[conGCContainerType.UpdUser] == DBNull.Value ? null : objRow[conGCContainerType.UpdUser].ToString().Trim(); //修改者
objGCContainerTypeEN.Memo = objRow[conGCContainerType.Memo] == DBNull.Value ? null : objRow[conGCContainerType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsGCContainerTypeDA: GetObjLst)", objException.Message));
}
objGCContainerTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objGCContainerTypeEN);
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
public List<clsGCContainerTypeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsGCContainerTypeDA:GetObjLstByTabName)", objException.Message));
}
List<clsGCContainerTypeEN> arrObjLst = new List<clsGCContainerTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCContainerTypeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCContainerTypeEN objGCContainerTypeEN = new clsGCContainerTypeEN();
try
{
objGCContainerTypeEN.ContainerTypeId = objRow[conGCContainerType.ContainerTypeId].ToString().Trim(); //容器类型Id
objGCContainerTypeEN.ContainerTypeName = objRow[conGCContainerType.ContainerTypeName].ToString().Trim(); //容器类型名
objGCContainerTypeEN.ContainerTypeENName = objRow[conGCContainerType.ContainerTypeENName].ToString().Trim(); //容器类型英文名
objGCContainerTypeEN.UpdDate = objRow[conGCContainerType.UpdDate] == DBNull.Value ? null : objRow[conGCContainerType.UpdDate].ToString().Trim(); //修改日期
objGCContainerTypeEN.UpdUser = objRow[conGCContainerType.UpdUser] == DBNull.Value ? null : objRow[conGCContainerType.UpdUser].ToString().Trim(); //修改者
objGCContainerTypeEN.Memo = objRow[conGCContainerType.Memo] == DBNull.Value ? null : objRow[conGCContainerType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsGCContainerTypeDA: GetObjLst)", objException.Message));
}
objGCContainerTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objGCContainerTypeEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objGCContainerTypeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetGCContainerType(ref clsGCContainerTypeEN objGCContainerTypeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCContainerTypeDA.GetSpecSQLObj();
strSQL = "Select * from GCContainerType where ContainerTypeId = " + "'"+ objGCContainerTypeEN.ContainerTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objGCContainerTypeEN.ContainerTypeId = objDT.Rows[0][conGCContainerType.ContainerTypeId].ToString().Trim(); //容器类型Id(字段类型:char,字段长度:4,是否可空:True)
 objGCContainerTypeEN.ContainerTypeName = objDT.Rows[0][conGCContainerType.ContainerTypeName].ToString().Trim(); //容器类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objGCContainerTypeEN.ContainerTypeENName = objDT.Rows[0][conGCContainerType.ContainerTypeENName].ToString().Trim(); //容器类型英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objGCContainerTypeEN.UpdDate = objDT.Rows[0][conGCContainerType.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objGCContainerTypeEN.UpdUser = objDT.Rows[0][conGCContainerType.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objGCContainerTypeEN.Memo = objDT.Rows[0][conGCContainerType.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsGCContainerTypeDA: GetGCContainerType)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strContainerTypeId">表关键字</param>
 /// <returns>表对象</returns>
public clsGCContainerTypeEN GetObjByContainerTypeId(string strContainerTypeId)
{
CheckPrimaryKey(strContainerTypeId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCContainerTypeDA.GetSpecSQLObj();
strSQL = "Select * from GCContainerType where ContainerTypeId = " + "'"+ strContainerTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsGCContainerTypeEN objGCContainerTypeEN = new clsGCContainerTypeEN();
try
{
 objGCContainerTypeEN.ContainerTypeId = objRow[conGCContainerType.ContainerTypeId].ToString().Trim(); //容器类型Id(字段类型:char,字段长度:4,是否可空:True)
 objGCContainerTypeEN.ContainerTypeName = objRow[conGCContainerType.ContainerTypeName].ToString().Trim(); //容器类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objGCContainerTypeEN.ContainerTypeENName = objRow[conGCContainerType.ContainerTypeENName].ToString().Trim(); //容器类型英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objGCContainerTypeEN.UpdDate = objRow[conGCContainerType.UpdDate] == DBNull.Value ? null : objRow[conGCContainerType.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objGCContainerTypeEN.UpdUser = objRow[conGCContainerType.UpdUser] == DBNull.Value ? null : objRow[conGCContainerType.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objGCContainerTypeEN.Memo = objRow[conGCContainerType.Memo] == DBNull.Value ? null : objRow[conGCContainerType.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsGCContainerTypeDA: GetObjByContainerTypeId)", objException.Message));
}
return objGCContainerTypeEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsGCContainerTypeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsGCContainerTypeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCContainerTypeDA.GetSpecSQLObj();
strSQL = "Select * from GCContainerType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsGCContainerTypeEN objGCContainerTypeEN = new clsGCContainerTypeEN()
{
ContainerTypeId = objRow[conGCContainerType.ContainerTypeId].ToString().Trim(), //容器类型Id
ContainerTypeName = objRow[conGCContainerType.ContainerTypeName].ToString().Trim(), //容器类型名
ContainerTypeENName = objRow[conGCContainerType.ContainerTypeENName].ToString().Trim(), //容器类型英文名
UpdDate = objRow[conGCContainerType.UpdDate] == DBNull.Value ? null : objRow[conGCContainerType.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conGCContainerType.UpdUser] == DBNull.Value ? null : objRow[conGCContainerType.UpdUser].ToString().Trim(), //修改者
Memo = objRow[conGCContainerType.Memo] == DBNull.Value ? null : objRow[conGCContainerType.Memo].ToString().Trim() //说明
};
objGCContainerTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objGCContainerTypeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsGCContainerTypeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsGCContainerTypeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsGCContainerTypeEN objGCContainerTypeEN = new clsGCContainerTypeEN();
try
{
objGCContainerTypeEN.ContainerTypeId = objRow[conGCContainerType.ContainerTypeId].ToString().Trim(); //容器类型Id
objGCContainerTypeEN.ContainerTypeName = objRow[conGCContainerType.ContainerTypeName].ToString().Trim(); //容器类型名
objGCContainerTypeEN.ContainerTypeENName = objRow[conGCContainerType.ContainerTypeENName].ToString().Trim(); //容器类型英文名
objGCContainerTypeEN.UpdDate = objRow[conGCContainerType.UpdDate] == DBNull.Value ? null : objRow[conGCContainerType.UpdDate].ToString().Trim(); //修改日期
objGCContainerTypeEN.UpdUser = objRow[conGCContainerType.UpdUser] == DBNull.Value ? null : objRow[conGCContainerType.UpdUser].ToString().Trim(); //修改者
objGCContainerTypeEN.Memo = objRow[conGCContainerType.Memo] == DBNull.Value ? null : objRow[conGCContainerType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsGCContainerTypeDA: GetObjByDataRowGCContainerType)", objException.Message));
}
objGCContainerTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objGCContainerTypeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsGCContainerTypeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsGCContainerTypeEN objGCContainerTypeEN = new clsGCContainerTypeEN();
try
{
objGCContainerTypeEN.ContainerTypeId = objRow[conGCContainerType.ContainerTypeId].ToString().Trim(); //容器类型Id
objGCContainerTypeEN.ContainerTypeName = objRow[conGCContainerType.ContainerTypeName].ToString().Trim(); //容器类型名
objGCContainerTypeEN.ContainerTypeENName = objRow[conGCContainerType.ContainerTypeENName].ToString().Trim(); //容器类型英文名
objGCContainerTypeEN.UpdDate = objRow[conGCContainerType.UpdDate] == DBNull.Value ? null : objRow[conGCContainerType.UpdDate].ToString().Trim(); //修改日期
objGCContainerTypeEN.UpdUser = objRow[conGCContainerType.UpdUser] == DBNull.Value ? null : objRow[conGCContainerType.UpdUser].ToString().Trim(); //修改者
objGCContainerTypeEN.Memo = objRow[conGCContainerType.Memo] == DBNull.Value ? null : objRow[conGCContainerType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsGCContainerTypeDA: GetObjByDataRow)", objException.Message));
}
objGCContainerTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objGCContainerTypeEN;
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
objSQL = clsGCContainerTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsGCContainerTypeEN._CurrTabName, conGCContainerType.ContainerTypeId, 4, "");
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
objSQL = clsGCContainerTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsGCContainerTypeEN._CurrTabName, conGCContainerType.ContainerTypeId, 4, strPrefix);
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
 objSQL = clsGCContainerTypeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ContainerTypeId from GCContainerType where " + strCondition;
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
 objSQL = clsGCContainerTypeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ContainerTypeId from GCContainerType where " + strCondition;
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
 /// <param name = "strContainerTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strContainerTypeId)
{
CheckPrimaryKey(strContainerTypeId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCContainerTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("GCContainerType", "ContainerTypeId = " + "'"+ strContainerTypeId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsGCContainerTypeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCContainerTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("GCContainerType", strCondition))
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
objSQL = clsGCContainerTypeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("GCContainerType");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsGCContainerTypeEN objGCContainerTypeEN)
 {
 objGCContainerTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objGCContainerTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objGCContainerTypeEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCContainerTypeDA.GetSpecSQLObj();
strSQL = "Select * from GCContainerType where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "GCContainerType");
objRow = objDS.Tables["GCContainerType"].NewRow();
objRow[conGCContainerType.ContainerTypeId] = objGCContainerTypeEN.ContainerTypeId; //容器类型Id
objRow[conGCContainerType.ContainerTypeName] = objGCContainerTypeEN.ContainerTypeName; //容器类型名
objRow[conGCContainerType.ContainerTypeENName] = objGCContainerTypeEN.ContainerTypeENName; //容器类型英文名
 if (objGCContainerTypeEN.UpdDate !=  "")
 {
objRow[conGCContainerType.UpdDate] = objGCContainerTypeEN.UpdDate; //修改日期
 }
 if (objGCContainerTypeEN.UpdUser !=  "")
 {
objRow[conGCContainerType.UpdUser] = objGCContainerTypeEN.UpdUser; //修改者
 }
 if (objGCContainerTypeEN.Memo !=  "")
 {
objRow[conGCContainerType.Memo] = objGCContainerTypeEN.Memo; //说明
 }
objDS.Tables[clsGCContainerTypeEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsGCContainerTypeEN._CurrTabName);
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
 /// <param name = "objGCContainerTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsGCContainerTypeEN objGCContainerTypeEN)
{
 objGCContainerTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objGCContainerTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objGCContainerTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objGCContainerTypeEN.ContainerTypeId !=  null)
 {
 arrFieldListForInsert.Add(conGCContainerType.ContainerTypeId);
 var strContainerTypeId = objGCContainerTypeEN.ContainerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strContainerTypeId + "'");
 }
 
 if (objGCContainerTypeEN.ContainerTypeName !=  null)
 {
 arrFieldListForInsert.Add(conGCContainerType.ContainerTypeName);
 var strContainerTypeName = objGCContainerTypeEN.ContainerTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strContainerTypeName + "'");
 }
 
 if (objGCContainerTypeEN.ContainerTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conGCContainerType.ContainerTypeENName);
 var strContainerTypeENName = objGCContainerTypeEN.ContainerTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strContainerTypeENName + "'");
 }
 
 if (objGCContainerTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conGCContainerType.UpdDate);
 var strUpdDate = objGCContainerTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objGCContainerTypeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conGCContainerType.UpdUser);
 var strUpdUser = objGCContainerTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objGCContainerTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conGCContainerType.Memo);
 var strMemo = objGCContainerTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into GCContainerType");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCContainerTypeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objGCContainerTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsGCContainerTypeEN objGCContainerTypeEN)
{
 objGCContainerTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objGCContainerTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objGCContainerTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objGCContainerTypeEN.ContainerTypeId !=  null)
 {
 arrFieldListForInsert.Add(conGCContainerType.ContainerTypeId);
 var strContainerTypeId = objGCContainerTypeEN.ContainerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strContainerTypeId + "'");
 }
 
 if (objGCContainerTypeEN.ContainerTypeName !=  null)
 {
 arrFieldListForInsert.Add(conGCContainerType.ContainerTypeName);
 var strContainerTypeName = objGCContainerTypeEN.ContainerTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strContainerTypeName + "'");
 }
 
 if (objGCContainerTypeEN.ContainerTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conGCContainerType.ContainerTypeENName);
 var strContainerTypeENName = objGCContainerTypeEN.ContainerTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strContainerTypeENName + "'");
 }
 
 if (objGCContainerTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conGCContainerType.UpdDate);
 var strUpdDate = objGCContainerTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objGCContainerTypeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conGCContainerType.UpdUser);
 var strUpdUser = objGCContainerTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objGCContainerTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conGCContainerType.Memo);
 var strMemo = objGCContainerTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into GCContainerType");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCContainerTypeDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objGCContainerTypeEN.ContainerTypeId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objGCContainerTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsGCContainerTypeEN objGCContainerTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objGCContainerTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objGCContainerTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objGCContainerTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objGCContainerTypeEN.ContainerTypeId !=  null)
 {
 arrFieldListForInsert.Add(conGCContainerType.ContainerTypeId);
 var strContainerTypeId = objGCContainerTypeEN.ContainerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strContainerTypeId + "'");
 }
 
 if (objGCContainerTypeEN.ContainerTypeName !=  null)
 {
 arrFieldListForInsert.Add(conGCContainerType.ContainerTypeName);
 var strContainerTypeName = objGCContainerTypeEN.ContainerTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strContainerTypeName + "'");
 }
 
 if (objGCContainerTypeEN.ContainerTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conGCContainerType.ContainerTypeENName);
 var strContainerTypeENName = objGCContainerTypeEN.ContainerTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strContainerTypeENName + "'");
 }
 
 if (objGCContainerTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conGCContainerType.UpdDate);
 var strUpdDate = objGCContainerTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objGCContainerTypeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conGCContainerType.UpdUser);
 var strUpdUser = objGCContainerTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objGCContainerTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conGCContainerType.Memo);
 var strMemo = objGCContainerTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into GCContainerType");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCContainerTypeDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objGCContainerTypeEN.ContainerTypeId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objGCContainerTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsGCContainerTypeEN objGCContainerTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objGCContainerTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objGCContainerTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objGCContainerTypeEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objGCContainerTypeEN.ContainerTypeId !=  null)
 {
 arrFieldListForInsert.Add(conGCContainerType.ContainerTypeId);
 var strContainerTypeId = objGCContainerTypeEN.ContainerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strContainerTypeId + "'");
 }
 
 if (objGCContainerTypeEN.ContainerTypeName !=  null)
 {
 arrFieldListForInsert.Add(conGCContainerType.ContainerTypeName);
 var strContainerTypeName = objGCContainerTypeEN.ContainerTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strContainerTypeName + "'");
 }
 
 if (objGCContainerTypeEN.ContainerTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conGCContainerType.ContainerTypeENName);
 var strContainerTypeENName = objGCContainerTypeEN.ContainerTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strContainerTypeENName + "'");
 }
 
 if (objGCContainerTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conGCContainerType.UpdDate);
 var strUpdDate = objGCContainerTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objGCContainerTypeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conGCContainerType.UpdUser);
 var strUpdUser = objGCContainerTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objGCContainerTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conGCContainerType.Memo);
 var strMemo = objGCContainerTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into GCContainerType");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCContainerTypeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewGCContainerTypes(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCContainerTypeDA.GetSpecSQLObj();
strSQL = "Select * from GCContainerType where ContainerTypeId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "GCContainerType");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strContainerTypeId = oRow[conGCContainerType.ContainerTypeId].ToString().Trim();
if (IsExist(strContainerTypeId))
{
 string strResult = "关键字变量值为:" + string.Format("ContainerTypeId = {0}", strContainerTypeId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsGCContainerTypeEN._CurrTabName ].NewRow();
objRow[conGCContainerType.ContainerTypeId] = oRow[conGCContainerType.ContainerTypeId].ToString().Trim(); //容器类型Id
objRow[conGCContainerType.ContainerTypeName] = oRow[conGCContainerType.ContainerTypeName].ToString().Trim(); //容器类型名
objRow[conGCContainerType.ContainerTypeENName] = oRow[conGCContainerType.ContainerTypeENName].ToString().Trim(); //容器类型英文名
objRow[conGCContainerType.UpdDate] = oRow[conGCContainerType.UpdDate].ToString().Trim(); //修改日期
objRow[conGCContainerType.UpdUser] = oRow[conGCContainerType.UpdUser].ToString().Trim(); //修改者
objRow[conGCContainerType.Memo] = oRow[conGCContainerType.Memo].ToString().Trim(); //说明
 objDS.Tables[clsGCContainerTypeEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsGCContainerTypeEN._CurrTabName);
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
 /// <param name = "objGCContainerTypeEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsGCContainerTypeEN objGCContainerTypeEN)
{
 objGCContainerTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objGCContainerTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objGCContainerTypeEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCContainerTypeDA.GetSpecSQLObj();
strSQL = "Select * from GCContainerType where ContainerTypeId = " + "'"+ objGCContainerTypeEN.ContainerTypeId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsGCContainerTypeEN._CurrTabName);
if (objDS.Tables[clsGCContainerTypeEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:ContainerTypeId = " + "'"+ objGCContainerTypeEN.ContainerTypeId+"'");
return false;
}
objRow = objDS.Tables[clsGCContainerTypeEN._CurrTabName].Rows[0];
 if (objGCContainerTypeEN.IsUpdated(conGCContainerType.ContainerTypeId))
 {
objRow[conGCContainerType.ContainerTypeId] = objGCContainerTypeEN.ContainerTypeId; //容器类型Id
 }
 if (objGCContainerTypeEN.IsUpdated(conGCContainerType.ContainerTypeName))
 {
objRow[conGCContainerType.ContainerTypeName] = objGCContainerTypeEN.ContainerTypeName; //容器类型名
 }
 if (objGCContainerTypeEN.IsUpdated(conGCContainerType.ContainerTypeENName))
 {
objRow[conGCContainerType.ContainerTypeENName] = objGCContainerTypeEN.ContainerTypeENName; //容器类型英文名
 }
 if (objGCContainerTypeEN.IsUpdated(conGCContainerType.UpdDate))
 {
objRow[conGCContainerType.UpdDate] = objGCContainerTypeEN.UpdDate; //修改日期
 }
 if (objGCContainerTypeEN.IsUpdated(conGCContainerType.UpdUser))
 {
objRow[conGCContainerType.UpdUser] = objGCContainerTypeEN.UpdUser; //修改者
 }
 if (objGCContainerTypeEN.IsUpdated(conGCContainerType.Memo))
 {
objRow[conGCContainerType.Memo] = objGCContainerTypeEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsGCContainerTypeEN._CurrTabName);
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
 /// <param name = "objGCContainerTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsGCContainerTypeEN objGCContainerTypeEN)
{
 objGCContainerTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objGCContainerTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objGCContainerTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCContainerTypeDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update GCContainerType Set ");
 
 if (objGCContainerTypeEN.IsUpdated(conGCContainerType.ContainerTypeName))
 {
 if (objGCContainerTypeEN.ContainerTypeName !=  null)
 {
 var strContainerTypeName = objGCContainerTypeEN.ContainerTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strContainerTypeName, conGCContainerType.ContainerTypeName); //容器类型名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCContainerType.ContainerTypeName); //容器类型名
 }
 }
 
 if (objGCContainerTypeEN.IsUpdated(conGCContainerType.ContainerTypeENName))
 {
 if (objGCContainerTypeEN.ContainerTypeENName !=  null)
 {
 var strContainerTypeENName = objGCContainerTypeEN.ContainerTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strContainerTypeENName, conGCContainerType.ContainerTypeENName); //容器类型英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCContainerType.ContainerTypeENName); //容器类型英文名
 }
 }
 
 if (objGCContainerTypeEN.IsUpdated(conGCContainerType.UpdDate))
 {
 if (objGCContainerTypeEN.UpdDate !=  null)
 {
 var strUpdDate = objGCContainerTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conGCContainerType.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCContainerType.UpdDate); //修改日期
 }
 }
 
 if (objGCContainerTypeEN.IsUpdated(conGCContainerType.UpdUser))
 {
 if (objGCContainerTypeEN.UpdUser !=  null)
 {
 var strUpdUser = objGCContainerTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conGCContainerType.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCContainerType.UpdUser); //修改者
 }
 }
 
 if (objGCContainerTypeEN.IsUpdated(conGCContainerType.Memo))
 {
 if (objGCContainerTypeEN.Memo !=  null)
 {
 var strMemo = objGCContainerTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conGCContainerType.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCContainerType.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ContainerTypeId = '{0}'", objGCContainerTypeEN.ContainerTypeId); 
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
 /// <param name = "objGCContainerTypeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsGCContainerTypeEN objGCContainerTypeEN, string strCondition)
{
 objGCContainerTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objGCContainerTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objGCContainerTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCContainerTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update GCContainerType Set ");
 
 if (objGCContainerTypeEN.IsUpdated(conGCContainerType.ContainerTypeName))
 {
 if (objGCContainerTypeEN.ContainerTypeName !=  null)
 {
 var strContainerTypeName = objGCContainerTypeEN.ContainerTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ContainerTypeName = '{0}',", strContainerTypeName); //容器类型名
 }
 else
 {
 sbSQL.Append(" ContainerTypeName = null,"); //容器类型名
 }
 }
 
 if (objGCContainerTypeEN.IsUpdated(conGCContainerType.ContainerTypeENName))
 {
 if (objGCContainerTypeEN.ContainerTypeENName !=  null)
 {
 var strContainerTypeENName = objGCContainerTypeEN.ContainerTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ContainerTypeENName = '{0}',", strContainerTypeENName); //容器类型英文名
 }
 else
 {
 sbSQL.Append(" ContainerTypeENName = null,"); //容器类型英文名
 }
 }
 
 if (objGCContainerTypeEN.IsUpdated(conGCContainerType.UpdDate))
 {
 if (objGCContainerTypeEN.UpdDate !=  null)
 {
 var strUpdDate = objGCContainerTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objGCContainerTypeEN.IsUpdated(conGCContainerType.UpdUser))
 {
 if (objGCContainerTypeEN.UpdUser !=  null)
 {
 var strUpdUser = objGCContainerTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objGCContainerTypeEN.IsUpdated(conGCContainerType.Memo))
 {
 if (objGCContainerTypeEN.Memo !=  null)
 {
 var strMemo = objGCContainerTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objGCContainerTypeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsGCContainerTypeEN objGCContainerTypeEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objGCContainerTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objGCContainerTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objGCContainerTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCContainerTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update GCContainerType Set ");
 
 if (objGCContainerTypeEN.IsUpdated(conGCContainerType.ContainerTypeName))
 {
 if (objGCContainerTypeEN.ContainerTypeName !=  null)
 {
 var strContainerTypeName = objGCContainerTypeEN.ContainerTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ContainerTypeName = '{0}',", strContainerTypeName); //容器类型名
 }
 else
 {
 sbSQL.Append(" ContainerTypeName = null,"); //容器类型名
 }
 }
 
 if (objGCContainerTypeEN.IsUpdated(conGCContainerType.ContainerTypeENName))
 {
 if (objGCContainerTypeEN.ContainerTypeENName !=  null)
 {
 var strContainerTypeENName = objGCContainerTypeEN.ContainerTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ContainerTypeENName = '{0}',", strContainerTypeENName); //容器类型英文名
 }
 else
 {
 sbSQL.Append(" ContainerTypeENName = null,"); //容器类型英文名
 }
 }
 
 if (objGCContainerTypeEN.IsUpdated(conGCContainerType.UpdDate))
 {
 if (objGCContainerTypeEN.UpdDate !=  null)
 {
 var strUpdDate = objGCContainerTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objGCContainerTypeEN.IsUpdated(conGCContainerType.UpdUser))
 {
 if (objGCContainerTypeEN.UpdUser !=  null)
 {
 var strUpdUser = objGCContainerTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objGCContainerTypeEN.IsUpdated(conGCContainerType.Memo))
 {
 if (objGCContainerTypeEN.Memo !=  null)
 {
 var strMemo = objGCContainerTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objGCContainerTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsGCContainerTypeEN objGCContainerTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objGCContainerTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objGCContainerTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objGCContainerTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCContainerTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update GCContainerType Set ");
 
 if (objGCContainerTypeEN.IsUpdated(conGCContainerType.ContainerTypeName))
 {
 if (objGCContainerTypeEN.ContainerTypeName !=  null)
 {
 var strContainerTypeName = objGCContainerTypeEN.ContainerTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strContainerTypeName, conGCContainerType.ContainerTypeName); //容器类型名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCContainerType.ContainerTypeName); //容器类型名
 }
 }
 
 if (objGCContainerTypeEN.IsUpdated(conGCContainerType.ContainerTypeENName))
 {
 if (objGCContainerTypeEN.ContainerTypeENName !=  null)
 {
 var strContainerTypeENName = objGCContainerTypeEN.ContainerTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strContainerTypeENName, conGCContainerType.ContainerTypeENName); //容器类型英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCContainerType.ContainerTypeENName); //容器类型英文名
 }
 }
 
 if (objGCContainerTypeEN.IsUpdated(conGCContainerType.UpdDate))
 {
 if (objGCContainerTypeEN.UpdDate !=  null)
 {
 var strUpdDate = objGCContainerTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conGCContainerType.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCContainerType.UpdDate); //修改日期
 }
 }
 
 if (objGCContainerTypeEN.IsUpdated(conGCContainerType.UpdUser))
 {
 if (objGCContainerTypeEN.UpdUser !=  null)
 {
 var strUpdUser = objGCContainerTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conGCContainerType.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCContainerType.UpdUser); //修改者
 }
 }
 
 if (objGCContainerTypeEN.IsUpdated(conGCContainerType.Memo))
 {
 if (objGCContainerTypeEN.Memo !=  null)
 {
 var strMemo = objGCContainerTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conGCContainerType.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCContainerType.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ContainerTypeId = '{0}'", objGCContainerTypeEN.ContainerTypeId); 
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
 /// <param name = "strContainerTypeId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strContainerTypeId) 
{
CheckPrimaryKey(strContainerTypeId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCContainerTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strContainerTypeId,
};
 objSQL.ExecSP("GCContainerType_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strContainerTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strContainerTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strContainerTypeId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCContainerTypeDA.GetSpecSQLObj();
//删除GCContainerType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from GCContainerType where ContainerTypeId = " + "'"+ strContainerTypeId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelGCContainerType(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCContainerTypeDA.GetSpecSQLObj();
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
//删除GCContainerType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from GCContainerType where ContainerTypeId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strContainerTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strContainerTypeId) 
{
CheckPrimaryKey(strContainerTypeId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCContainerTypeDA.GetSpecSQLObj();
//删除GCContainerType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from GCContainerType where ContainerTypeId = " + "'"+ strContainerTypeId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelGCContainerType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsGCContainerTypeDA: DelGCContainerType)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCContainerTypeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from GCContainerType where " + strCondition ;
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
public bool DelGCContainerTypeWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsGCContainerTypeDA: DelGCContainerTypeWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCContainerTypeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from GCContainerType where " + strCondition ;
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
 /// <param name = "objGCContainerTypeENS">源对象</param>
 /// <param name = "objGCContainerTypeENT">目标对象</param>
public void CopyTo(clsGCContainerTypeEN objGCContainerTypeENS, clsGCContainerTypeEN objGCContainerTypeENT)
{
objGCContainerTypeENT.ContainerTypeId = objGCContainerTypeENS.ContainerTypeId; //容器类型Id
objGCContainerTypeENT.ContainerTypeName = objGCContainerTypeENS.ContainerTypeName; //容器类型名
objGCContainerTypeENT.ContainerTypeENName = objGCContainerTypeENS.ContainerTypeENName; //容器类型英文名
objGCContainerTypeENT.UpdDate = objGCContainerTypeENS.UpdDate; //修改日期
objGCContainerTypeENT.UpdUser = objGCContainerTypeENS.UpdUser; //修改者
objGCContainerTypeENT.Memo = objGCContainerTypeENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsGCContainerTypeEN objGCContainerTypeEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objGCContainerTypeEN.ContainerTypeName, conGCContainerType.ContainerTypeName);
clsCheckSql.CheckFieldNotNull(objGCContainerTypeEN.ContainerTypeENName, conGCContainerType.ContainerTypeENName);
//检查字段长度
clsCheckSql.CheckFieldLen(objGCContainerTypeEN.ContainerTypeId, 4, conGCContainerType.ContainerTypeId);
clsCheckSql.CheckFieldLen(objGCContainerTypeEN.ContainerTypeName, 50, conGCContainerType.ContainerTypeName);
clsCheckSql.CheckFieldLen(objGCContainerTypeEN.ContainerTypeENName, 50, conGCContainerType.ContainerTypeENName);
clsCheckSql.CheckFieldLen(objGCContainerTypeEN.UpdDate, 20, conGCContainerType.UpdDate);
clsCheckSql.CheckFieldLen(objGCContainerTypeEN.UpdUser, 20, conGCContainerType.UpdUser);
clsCheckSql.CheckFieldLen(objGCContainerTypeEN.Memo, 1000, conGCContainerType.Memo);
//检查字段外键固定长度
 objGCContainerTypeEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsGCContainerTypeEN objGCContainerTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objGCContainerTypeEN.ContainerTypeName, 50, conGCContainerType.ContainerTypeName);
clsCheckSql.CheckFieldLen(objGCContainerTypeEN.ContainerTypeENName, 50, conGCContainerType.ContainerTypeENName);
clsCheckSql.CheckFieldLen(objGCContainerTypeEN.UpdDate, 20, conGCContainerType.UpdDate);
clsCheckSql.CheckFieldLen(objGCContainerTypeEN.UpdUser, 20, conGCContainerType.UpdUser);
clsCheckSql.CheckFieldLen(objGCContainerTypeEN.Memo, 1000, conGCContainerType.Memo);
//检查外键字段长度
 objGCContainerTypeEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsGCContainerTypeEN objGCContainerTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objGCContainerTypeEN.ContainerTypeId, 4, conGCContainerType.ContainerTypeId);
clsCheckSql.CheckFieldLen(objGCContainerTypeEN.ContainerTypeName, 50, conGCContainerType.ContainerTypeName);
clsCheckSql.CheckFieldLen(objGCContainerTypeEN.ContainerTypeENName, 50, conGCContainerType.ContainerTypeENName);
clsCheckSql.CheckFieldLen(objGCContainerTypeEN.UpdDate, 20, conGCContainerType.UpdDate);
clsCheckSql.CheckFieldLen(objGCContainerTypeEN.UpdUser, 20, conGCContainerType.UpdUser);
clsCheckSql.CheckFieldLen(objGCContainerTypeEN.Memo, 1000, conGCContainerType.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objGCContainerTypeEN.ContainerTypeId, conGCContainerType.ContainerTypeId);
clsCheckSql.CheckSqlInjection4Field(objGCContainerTypeEN.ContainerTypeName, conGCContainerType.ContainerTypeName);
clsCheckSql.CheckSqlInjection4Field(objGCContainerTypeEN.ContainerTypeENName, conGCContainerType.ContainerTypeENName);
clsCheckSql.CheckSqlInjection4Field(objGCContainerTypeEN.UpdDate, conGCContainerType.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objGCContainerTypeEN.UpdUser, conGCContainerType.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objGCContainerTypeEN.Memo, conGCContainerType.Memo);
//检查外键字段长度
 objGCContainerTypeEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetContainerTypeId()
{
//获取某学院所有专业信息
string strSQL = "select ContainerTypeId, ContainerTypeName from GCContainerType ";
 clsSpecSQLforSql mySql = clsGCContainerTypeDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--GCContainerType(GC容器类型),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objGCContainerTypeEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsGCContainerTypeEN objGCContainerTypeEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ContainerTypeName = '{0}'", objGCContainerTypeEN.ContainerTypeName);
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
 objSQL = clsGCContainerTypeDA.GetSpecSQLObj();
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
 objSQL = clsGCContainerTypeDA.GetSpecSQLObj();
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
 objSQL = clsGCContainerTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsGCContainerTypeEN._CurrTabName);
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
 objSQL = clsGCContainerTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsGCContainerTypeEN._CurrTabName, strCondition);
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
 objSQL = clsGCContainerTypeDA.GetSpecSQLObj();
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
 objSQL = clsGCContainerTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}