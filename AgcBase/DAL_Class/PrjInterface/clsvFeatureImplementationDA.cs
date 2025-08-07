
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFeatureImplementationDA
 表名:vFeatureImplementation(00050394)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:48:51
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:界面管理(PrjInterface)
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
 /// v功能实现方式(vFeatureImplementation)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvFeatureImplementationDA : clsCommBase4DA
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
 return clsvFeatureImplementationEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvFeatureImplementationEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvFeatureImplementationEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvFeatureImplementationEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvFeatureImplementationEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvFeatureImplementationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureImplementationDA.GetSpecSQLObj();
strSQL = "Select * from vFeatureImplementation where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vFeatureImplementation(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvFeatureImplementationDA: GetDataTable_vFeatureImplementation)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureImplementationDA.GetSpecSQLObj();
strSQL = "Select * from vFeatureImplementation where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvFeatureImplementationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureImplementationDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvFeatureImplementationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureImplementationDA.GetSpecSQLObj();
strSQL = "Select * from vFeatureImplementation where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvFeatureImplementationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureImplementationDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvFeatureImplementationDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureImplementationDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFeatureImplementation where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFeatureImplementation where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvFeatureImplementationDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureImplementationDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vFeatureImplementation where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvFeatureImplementationDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureImplementationDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vFeatureImplementation.* " + 
$"from vFeatureImplementation " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vFeatureImplementation.mId not in " + 
$"(Select top {intTop_In} vFeatureImplementation.mId from vFeatureImplementation " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFeatureImplementation where {1} and mId not in (Select top {2} mId from vFeatureImplementation where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFeatureImplementation where {1} and mId not in (Select top {3} mId from vFeatureImplementation where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvFeatureImplementationDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureImplementationDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vFeatureImplementation.* " + 
$"from vFeatureImplementation " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vFeatureImplementation.mId not in " + 
$"(Select top {intTop_In} vFeatureImplementation.mId from vFeatureImplementation " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFeatureImplementation where {1} and mId not in (Select top {2} mId from vFeatureImplementation where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFeatureImplementation where {1} and mId not in (Select top {3} mId from vFeatureImplementation where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvFeatureImplementationEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvFeatureImplementationDA:GetObjLst)", objException.Message));
}
List<clsvFeatureImplementationEN> arrObjLst = new List<clsvFeatureImplementationEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureImplementationDA.GetSpecSQLObj();
strSQL = "Select * from vFeatureImplementation where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureImplementationEN objvFeatureImplementationEN = new clsvFeatureImplementationEN();
try
{
objvFeatureImplementationEN.mId = TransNullToInt(objRow[convFeatureImplementation.mId].ToString().Trim()); //mId
objvFeatureImplementationEN.FeatureId = objRow[convFeatureImplementation.FeatureId].ToString().Trim(); //功能Id
objvFeatureImplementationEN.FeatureName = objRow[convFeatureImplementation.FeatureName].ToString().Trim(); //功能名称
objvFeatureImplementationEN.KeyWords = objRow[convFeatureImplementation.KeyWords] == DBNull.Value ? null : objRow[convFeatureImplementation.KeyWords].ToString().Trim(); //关键字
objvFeatureImplementationEN.FeatureDescription = objRow[convFeatureImplementation.FeatureDescription] == DBNull.Value ? null : objRow[convFeatureImplementation.FeatureDescription].ToString().Trim(); //功能说明
objvFeatureImplementationEN.FeatureTypeId = objRow[convFeatureImplementation.FeatureTypeId].ToString().Trim(); //功能类型Id
objvFeatureImplementationEN.FeatureTypeName = objRow[convFeatureImplementation.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureImplementationEN.ViewImplId = objRow[convFeatureImplementation.ViewImplId].ToString().Trim(); //界面实现Id
objvFeatureImplementationEN.ViewImplName = objRow[convFeatureImplementation.ViewImplName] == DBNull.Value ? null : objRow[convFeatureImplementation.ViewImplName].ToString().Trim(); //界面实现名
objvFeatureImplementationEN.UpdDate = objRow[convFeatureImplementation.UpdDate] == DBNull.Value ? null : objRow[convFeatureImplementation.UpdDate].ToString().Trim(); //修改日期
objvFeatureImplementationEN.UpdUser = objRow[convFeatureImplementation.UpdUser] == DBNull.Value ? null : objRow[convFeatureImplementation.UpdUser].ToString().Trim(); //修改者
objvFeatureImplementationEN.Memo = objRow[convFeatureImplementation.Memo] == DBNull.Value ? null : objRow[convFeatureImplementation.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvFeatureImplementationDA: GetObjLst)", objException.Message));
}
objvFeatureImplementationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvFeatureImplementationEN);
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
public List<clsvFeatureImplementationEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvFeatureImplementationDA:GetObjLstByTabName)", objException.Message));
}
List<clsvFeatureImplementationEN> arrObjLst = new List<clsvFeatureImplementationEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureImplementationDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureImplementationEN objvFeatureImplementationEN = new clsvFeatureImplementationEN();
try
{
objvFeatureImplementationEN.mId = TransNullToInt(objRow[convFeatureImplementation.mId].ToString().Trim()); //mId
objvFeatureImplementationEN.FeatureId = objRow[convFeatureImplementation.FeatureId].ToString().Trim(); //功能Id
objvFeatureImplementationEN.FeatureName = objRow[convFeatureImplementation.FeatureName].ToString().Trim(); //功能名称
objvFeatureImplementationEN.KeyWords = objRow[convFeatureImplementation.KeyWords] == DBNull.Value ? null : objRow[convFeatureImplementation.KeyWords].ToString().Trim(); //关键字
objvFeatureImplementationEN.FeatureDescription = objRow[convFeatureImplementation.FeatureDescription] == DBNull.Value ? null : objRow[convFeatureImplementation.FeatureDescription].ToString().Trim(); //功能说明
objvFeatureImplementationEN.FeatureTypeId = objRow[convFeatureImplementation.FeatureTypeId].ToString().Trim(); //功能类型Id
objvFeatureImplementationEN.FeatureTypeName = objRow[convFeatureImplementation.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureImplementationEN.ViewImplId = objRow[convFeatureImplementation.ViewImplId].ToString().Trim(); //界面实现Id
objvFeatureImplementationEN.ViewImplName = objRow[convFeatureImplementation.ViewImplName] == DBNull.Value ? null : objRow[convFeatureImplementation.ViewImplName].ToString().Trim(); //界面实现名
objvFeatureImplementationEN.UpdDate = objRow[convFeatureImplementation.UpdDate] == DBNull.Value ? null : objRow[convFeatureImplementation.UpdDate].ToString().Trim(); //修改日期
objvFeatureImplementationEN.UpdUser = objRow[convFeatureImplementation.UpdUser] == DBNull.Value ? null : objRow[convFeatureImplementation.UpdUser].ToString().Trim(); //修改者
objvFeatureImplementationEN.Memo = objRow[convFeatureImplementation.Memo] == DBNull.Value ? null : objRow[convFeatureImplementation.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvFeatureImplementationDA: GetObjLst)", objException.Message));
}
objvFeatureImplementationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvFeatureImplementationEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvFeatureImplementationEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvFeatureImplementation(ref clsvFeatureImplementationEN objvFeatureImplementationEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureImplementationDA.GetSpecSQLObj();
strSQL = "Select * from vFeatureImplementation where mId = " + ""+ objvFeatureImplementationEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvFeatureImplementationEN.mId = TransNullToInt(objDT.Rows[0][convFeatureImplementation.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvFeatureImplementationEN.FeatureId = objDT.Rows[0][convFeatureImplementation.FeatureId].ToString().Trim(); //功能Id(字段类型:char,字段长度:4,是否可空:False)
 objvFeatureImplementationEN.FeatureName = objDT.Rows[0][convFeatureImplementation.FeatureName].ToString().Trim(); //功能名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvFeatureImplementationEN.KeyWords = objDT.Rows[0][convFeatureImplementation.KeyWords].ToString().Trim(); //关键字(字段类型:varchar,字段长度:500,是否可空:True)
 objvFeatureImplementationEN.FeatureDescription = objDT.Rows[0][convFeatureImplementation.FeatureDescription].ToString().Trim(); //功能说明(字段类型:varchar,字段长度:4000,是否可空:True)
 objvFeatureImplementationEN.FeatureTypeId = objDT.Rows[0][convFeatureImplementation.FeatureTypeId].ToString().Trim(); //功能类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvFeatureImplementationEN.FeatureTypeName = objDT.Rows[0][convFeatureImplementation.FeatureTypeName].ToString().Trim(); //功能类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvFeatureImplementationEN.ViewImplId = objDT.Rows[0][convFeatureImplementation.ViewImplId].ToString().Trim(); //界面实现Id(字段类型:char,字段长度:4,是否可空:False)
 objvFeatureImplementationEN.ViewImplName = objDT.Rows[0][convFeatureImplementation.ViewImplName].ToString().Trim(); //界面实现名(字段类型:varchar,字段长度:50,是否可空:False)
 objvFeatureImplementationEN.UpdDate = objDT.Rows[0][convFeatureImplementation.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvFeatureImplementationEN.UpdUser = objDT.Rows[0][convFeatureImplementation.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvFeatureImplementationEN.Memo = objDT.Rows[0][convFeatureImplementation.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvFeatureImplementationDA: GetvFeatureImplementation)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvFeatureImplementationEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureImplementationDA.GetSpecSQLObj();
strSQL = "Select * from vFeatureImplementation where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvFeatureImplementationEN objvFeatureImplementationEN = new clsvFeatureImplementationEN();
try
{
 objvFeatureImplementationEN.mId = Int32.Parse(objRow[convFeatureImplementation.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvFeatureImplementationEN.FeatureId = objRow[convFeatureImplementation.FeatureId].ToString().Trim(); //功能Id(字段类型:char,字段长度:4,是否可空:False)
 objvFeatureImplementationEN.FeatureName = objRow[convFeatureImplementation.FeatureName].ToString().Trim(); //功能名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvFeatureImplementationEN.KeyWords = objRow[convFeatureImplementation.KeyWords] == DBNull.Value ? null : objRow[convFeatureImplementation.KeyWords].ToString().Trim(); //关键字(字段类型:varchar,字段长度:500,是否可空:True)
 objvFeatureImplementationEN.FeatureDescription = objRow[convFeatureImplementation.FeatureDescription] == DBNull.Value ? null : objRow[convFeatureImplementation.FeatureDescription].ToString().Trim(); //功能说明(字段类型:varchar,字段长度:4000,是否可空:True)
 objvFeatureImplementationEN.FeatureTypeId = objRow[convFeatureImplementation.FeatureTypeId].ToString().Trim(); //功能类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvFeatureImplementationEN.FeatureTypeName = objRow[convFeatureImplementation.FeatureTypeName].ToString().Trim(); //功能类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvFeatureImplementationEN.ViewImplId = objRow[convFeatureImplementation.ViewImplId].ToString().Trim(); //界面实现Id(字段类型:char,字段长度:4,是否可空:False)
 objvFeatureImplementationEN.ViewImplName = objRow[convFeatureImplementation.ViewImplName] == DBNull.Value ? null : objRow[convFeatureImplementation.ViewImplName].ToString().Trim(); //界面实现名(字段类型:varchar,字段长度:50,是否可空:False)
 objvFeatureImplementationEN.UpdDate = objRow[convFeatureImplementation.UpdDate] == DBNull.Value ? null : objRow[convFeatureImplementation.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvFeatureImplementationEN.UpdUser = objRow[convFeatureImplementation.UpdUser] == DBNull.Value ? null : objRow[convFeatureImplementation.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvFeatureImplementationEN.Memo = objRow[convFeatureImplementation.Memo] == DBNull.Value ? null : objRow[convFeatureImplementation.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvFeatureImplementationDA: GetObjBymId)", objException.Message));
}
return objvFeatureImplementationEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvFeatureImplementationEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvFeatureImplementationDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureImplementationDA.GetSpecSQLObj();
strSQL = "Select * from vFeatureImplementation where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvFeatureImplementationEN objvFeatureImplementationEN = new clsvFeatureImplementationEN()
{
mId = TransNullToInt(objRow[convFeatureImplementation.mId].ToString().Trim()), //mId
FeatureId = objRow[convFeatureImplementation.FeatureId].ToString().Trim(), //功能Id
FeatureName = objRow[convFeatureImplementation.FeatureName].ToString().Trim(), //功能名称
KeyWords = objRow[convFeatureImplementation.KeyWords] == DBNull.Value ? null : objRow[convFeatureImplementation.KeyWords].ToString().Trim(), //关键字
FeatureDescription = objRow[convFeatureImplementation.FeatureDescription] == DBNull.Value ? null : objRow[convFeatureImplementation.FeatureDescription].ToString().Trim(), //功能说明
FeatureTypeId = objRow[convFeatureImplementation.FeatureTypeId].ToString().Trim(), //功能类型Id
FeatureTypeName = objRow[convFeatureImplementation.FeatureTypeName].ToString().Trim(), //功能类型名称
ViewImplId = objRow[convFeatureImplementation.ViewImplId].ToString().Trim(), //界面实现Id
ViewImplName = objRow[convFeatureImplementation.ViewImplName] == DBNull.Value ? null : objRow[convFeatureImplementation.ViewImplName].ToString().Trim(), //界面实现名
UpdDate = objRow[convFeatureImplementation.UpdDate] == DBNull.Value ? null : objRow[convFeatureImplementation.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convFeatureImplementation.UpdUser] == DBNull.Value ? null : objRow[convFeatureImplementation.UpdUser].ToString().Trim(), //修改者
Memo = objRow[convFeatureImplementation.Memo] == DBNull.Value ? null : objRow[convFeatureImplementation.Memo].ToString().Trim() //说明
};
objvFeatureImplementationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFeatureImplementationEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvFeatureImplementationDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvFeatureImplementationEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvFeatureImplementationEN objvFeatureImplementationEN = new clsvFeatureImplementationEN();
try
{
objvFeatureImplementationEN.mId = TransNullToInt(objRow[convFeatureImplementation.mId].ToString().Trim()); //mId
objvFeatureImplementationEN.FeatureId = objRow[convFeatureImplementation.FeatureId].ToString().Trim(); //功能Id
objvFeatureImplementationEN.FeatureName = objRow[convFeatureImplementation.FeatureName].ToString().Trim(); //功能名称
objvFeatureImplementationEN.KeyWords = objRow[convFeatureImplementation.KeyWords] == DBNull.Value ? null : objRow[convFeatureImplementation.KeyWords].ToString().Trim(); //关键字
objvFeatureImplementationEN.FeatureDescription = objRow[convFeatureImplementation.FeatureDescription] == DBNull.Value ? null : objRow[convFeatureImplementation.FeatureDescription].ToString().Trim(); //功能说明
objvFeatureImplementationEN.FeatureTypeId = objRow[convFeatureImplementation.FeatureTypeId].ToString().Trim(); //功能类型Id
objvFeatureImplementationEN.FeatureTypeName = objRow[convFeatureImplementation.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureImplementationEN.ViewImplId = objRow[convFeatureImplementation.ViewImplId].ToString().Trim(); //界面实现Id
objvFeatureImplementationEN.ViewImplName = objRow[convFeatureImplementation.ViewImplName] == DBNull.Value ? null : objRow[convFeatureImplementation.ViewImplName].ToString().Trim(); //界面实现名
objvFeatureImplementationEN.UpdDate = objRow[convFeatureImplementation.UpdDate] == DBNull.Value ? null : objRow[convFeatureImplementation.UpdDate].ToString().Trim(); //修改日期
objvFeatureImplementationEN.UpdUser = objRow[convFeatureImplementation.UpdUser] == DBNull.Value ? null : objRow[convFeatureImplementation.UpdUser].ToString().Trim(); //修改者
objvFeatureImplementationEN.Memo = objRow[convFeatureImplementation.Memo] == DBNull.Value ? null : objRow[convFeatureImplementation.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvFeatureImplementationDA: GetObjByDataRowvFeatureImplementation)", objException.Message));
}
objvFeatureImplementationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFeatureImplementationEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvFeatureImplementationEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvFeatureImplementationEN objvFeatureImplementationEN = new clsvFeatureImplementationEN();
try
{
objvFeatureImplementationEN.mId = TransNullToInt(objRow[convFeatureImplementation.mId].ToString().Trim()); //mId
objvFeatureImplementationEN.FeatureId = objRow[convFeatureImplementation.FeatureId].ToString().Trim(); //功能Id
objvFeatureImplementationEN.FeatureName = objRow[convFeatureImplementation.FeatureName].ToString().Trim(); //功能名称
objvFeatureImplementationEN.KeyWords = objRow[convFeatureImplementation.KeyWords] == DBNull.Value ? null : objRow[convFeatureImplementation.KeyWords].ToString().Trim(); //关键字
objvFeatureImplementationEN.FeatureDescription = objRow[convFeatureImplementation.FeatureDescription] == DBNull.Value ? null : objRow[convFeatureImplementation.FeatureDescription].ToString().Trim(); //功能说明
objvFeatureImplementationEN.FeatureTypeId = objRow[convFeatureImplementation.FeatureTypeId].ToString().Trim(); //功能类型Id
objvFeatureImplementationEN.FeatureTypeName = objRow[convFeatureImplementation.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureImplementationEN.ViewImplId = objRow[convFeatureImplementation.ViewImplId].ToString().Trim(); //界面实现Id
objvFeatureImplementationEN.ViewImplName = objRow[convFeatureImplementation.ViewImplName] == DBNull.Value ? null : objRow[convFeatureImplementation.ViewImplName].ToString().Trim(); //界面实现名
objvFeatureImplementationEN.UpdDate = objRow[convFeatureImplementation.UpdDate] == DBNull.Value ? null : objRow[convFeatureImplementation.UpdDate].ToString().Trim(); //修改日期
objvFeatureImplementationEN.UpdUser = objRow[convFeatureImplementation.UpdUser] == DBNull.Value ? null : objRow[convFeatureImplementation.UpdUser].ToString().Trim(); //修改者
objvFeatureImplementationEN.Memo = objRow[convFeatureImplementation.Memo] == DBNull.Value ? null : objRow[convFeatureImplementation.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvFeatureImplementationDA: GetObjByDataRow)", objException.Message));
}
objvFeatureImplementationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFeatureImplementationEN;
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
objSQL = clsvFeatureImplementationDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvFeatureImplementationEN._CurrTabName, convFeatureImplementation.mId, 8, "");
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
objSQL = clsvFeatureImplementationDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvFeatureImplementationEN._CurrTabName, convFeatureImplementation.mId, 8, strPrefix);
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
 objSQL = clsvFeatureImplementationDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vFeatureImplementation where " + strCondition;
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
 objSQL = clsvFeatureImplementationDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vFeatureImplementation where " + strCondition;
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngmId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureImplementationDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vFeatureImplementation", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvFeatureImplementationDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureImplementationDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vFeatureImplementation", strCondition))
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
objSQL = clsvFeatureImplementationDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vFeatureImplementation");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvFeatureImplementationENS">源对象</param>
 /// <param name = "objvFeatureImplementationENT">目标对象</param>
public void CopyTo(clsvFeatureImplementationEN objvFeatureImplementationENS, clsvFeatureImplementationEN objvFeatureImplementationENT)
{
objvFeatureImplementationENT.mId = objvFeatureImplementationENS.mId; //mId
objvFeatureImplementationENT.FeatureId = objvFeatureImplementationENS.FeatureId; //功能Id
objvFeatureImplementationENT.FeatureName = objvFeatureImplementationENS.FeatureName; //功能名称
objvFeatureImplementationENT.KeyWords = objvFeatureImplementationENS.KeyWords; //关键字
objvFeatureImplementationENT.FeatureDescription = objvFeatureImplementationENS.FeatureDescription; //功能说明
objvFeatureImplementationENT.FeatureTypeId = objvFeatureImplementationENS.FeatureTypeId; //功能类型Id
objvFeatureImplementationENT.FeatureTypeName = objvFeatureImplementationENS.FeatureTypeName; //功能类型名称
objvFeatureImplementationENT.ViewImplId = objvFeatureImplementationENS.ViewImplId; //界面实现Id
objvFeatureImplementationENT.ViewImplName = objvFeatureImplementationENS.ViewImplName; //界面实现名
objvFeatureImplementationENT.UpdDate = objvFeatureImplementationENS.UpdDate; //修改日期
objvFeatureImplementationENT.UpdUser = objvFeatureImplementationENS.UpdUser; //修改者
objvFeatureImplementationENT.Memo = objvFeatureImplementationENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvFeatureImplementationEN objvFeatureImplementationEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvFeatureImplementationEN.FeatureId, 4, convFeatureImplementation.FeatureId);
clsCheckSql.CheckFieldLen(objvFeatureImplementationEN.FeatureName, 100, convFeatureImplementation.FeatureName);
clsCheckSql.CheckFieldLen(objvFeatureImplementationEN.KeyWords, 500, convFeatureImplementation.KeyWords);
clsCheckSql.CheckFieldLen(objvFeatureImplementationEN.FeatureDescription, 4000, convFeatureImplementation.FeatureDescription);
clsCheckSql.CheckFieldLen(objvFeatureImplementationEN.FeatureTypeId, 2, convFeatureImplementation.FeatureTypeId);
clsCheckSql.CheckFieldLen(objvFeatureImplementationEN.FeatureTypeName, 30, convFeatureImplementation.FeatureTypeName);
clsCheckSql.CheckFieldLen(objvFeatureImplementationEN.ViewImplId, 4, convFeatureImplementation.ViewImplId);
clsCheckSql.CheckFieldLen(objvFeatureImplementationEN.ViewImplName, 50, convFeatureImplementation.ViewImplName);
clsCheckSql.CheckFieldLen(objvFeatureImplementationEN.UpdDate, 20, convFeatureImplementation.UpdDate);
clsCheckSql.CheckFieldLen(objvFeatureImplementationEN.UpdUser, 20, convFeatureImplementation.UpdUser);
clsCheckSql.CheckFieldLen(objvFeatureImplementationEN.Memo, 1000, convFeatureImplementation.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvFeatureImplementationEN.FeatureId, convFeatureImplementation.FeatureId);
clsCheckSql.CheckSqlInjection4Field(objvFeatureImplementationEN.FeatureName, convFeatureImplementation.FeatureName);
clsCheckSql.CheckSqlInjection4Field(objvFeatureImplementationEN.KeyWords, convFeatureImplementation.KeyWords);
clsCheckSql.CheckSqlInjection4Field(objvFeatureImplementationEN.FeatureDescription, convFeatureImplementation.FeatureDescription);
clsCheckSql.CheckSqlInjection4Field(objvFeatureImplementationEN.FeatureTypeId, convFeatureImplementation.FeatureTypeId);
clsCheckSql.CheckSqlInjection4Field(objvFeatureImplementationEN.FeatureTypeName, convFeatureImplementation.FeatureTypeName);
clsCheckSql.CheckSqlInjection4Field(objvFeatureImplementationEN.ViewImplId, convFeatureImplementation.ViewImplId);
clsCheckSql.CheckSqlInjection4Field(objvFeatureImplementationEN.ViewImplName, convFeatureImplementation.ViewImplName);
clsCheckSql.CheckSqlInjection4Field(objvFeatureImplementationEN.UpdDate, convFeatureImplementation.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvFeatureImplementationEN.UpdUser, convFeatureImplementation.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvFeatureImplementationEN.Memo, convFeatureImplementation.Memo);
//检查外键字段长度
 objvFeatureImplementationEN._IsCheckProperty = true;
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
 objSQL = clsvFeatureImplementationDA.GetSpecSQLObj();
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
 objSQL = clsvFeatureImplementationDA.GetSpecSQLObj();
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
 objSQL = clsvFeatureImplementationDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvFeatureImplementationEN._CurrTabName);
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
 objSQL = clsvFeatureImplementationDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvFeatureImplementationEN._CurrTabName, strCondition);
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
 objSQL = clsvFeatureImplementationDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}