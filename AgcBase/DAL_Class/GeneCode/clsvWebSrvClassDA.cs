
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvWebSrvClassDA
 表名:vWebSrvClass(00050349)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:44:30
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
 /// vWebSrv类(vWebSrvClass)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvWebSrvClassDA : clsCommBase4DA
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
 return clsvWebSrvClassEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvWebSrvClassEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvWebSrvClassEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvWebSrvClassEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvWebSrvClassEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strWebSrvClassId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strWebSrvClassId)
{
strWebSrvClassId = strWebSrvClassId.Replace("'", "''");
if (strWebSrvClassId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vWebSrvClass中,检查关键字,长度不正确!(clsvWebSrvClassDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strWebSrvClassId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vWebSrvClass中,关键字不能为空 或 null!(clsvWebSrvClassDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strWebSrvClassId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvWebSrvClassDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvWebSrvClassDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvClassDA.GetSpecSQLObj();
strSQL = "Select * from vWebSrvClass where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vWebSrvClass(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvWebSrvClassDA: GetDataTable_vWebSrvClass)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvClassDA.GetSpecSQLObj();
strSQL = "Select * from vWebSrvClass where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvWebSrvClassDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvClassDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvWebSrvClassDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvClassDA.GetSpecSQLObj();
strSQL = "Select * from vWebSrvClass where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvWebSrvClassDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvClassDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvWebSrvClassDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvClassDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vWebSrvClass where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vWebSrvClass where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvWebSrvClassDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvClassDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vWebSrvClass where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvWebSrvClassDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvClassDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vWebSrvClass.* " + 
$"from vWebSrvClass " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vWebSrvClass.WebSrvClassId not in " + 
$"(Select top {intTop_In} vWebSrvClass.WebSrvClassId from vWebSrvClass " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vWebSrvClass where {1} and WebSrvClassId not in (Select top {2} WebSrvClassId from vWebSrvClass where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vWebSrvClass where {1} and WebSrvClassId not in (Select top {3} WebSrvClassId from vWebSrvClass where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvWebSrvClassDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvClassDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vWebSrvClass.* " + 
$"from vWebSrvClass " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vWebSrvClass.WebSrvClassId not in " + 
$"(Select top {intTop_In} vWebSrvClass.WebSrvClassId from vWebSrvClass " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vWebSrvClass where {1} and WebSrvClassId not in (Select top {2} WebSrvClassId from vWebSrvClass where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vWebSrvClass where {1} and WebSrvClassId not in (Select top {3} WebSrvClassId from vWebSrvClass where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvWebSrvClassEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvWebSrvClassDA:GetObjLst)", objException.Message));
}
List<clsvWebSrvClassEN> arrObjLst = new List<clsvWebSrvClassEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvClassDA.GetSpecSQLObj();
strSQL = "Select * from vWebSrvClass where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvWebSrvClassEN objvWebSrvClassEN = new clsvWebSrvClassEN();
try
{
objvWebSrvClassEN.WebSrvClassId = objRow[convWebSrvClass.WebSrvClassId].ToString().Trim(); //类Id
objvWebSrvClassEN.NameSpace = objRow[convWebSrvClass.NameSpace] == DBNull.Value ? null : objRow[convWebSrvClass.NameSpace].ToString().Trim(); //域名
objvWebSrvClassEN.WebSrvUrl = objRow[convWebSrvClass.WebSrvUrl].ToString().Trim(); //WebSrv地址
objvWebSrvClassEN.PageName = objRow[convWebSrvClass.PageName].ToString().Trim(); //页面名称
objvWebSrvClassEN.FuncModuleAgcId = objRow[convWebSrvClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvWebSrvClassEN.FuncModuleName = objRow[convWebSrvClass.FuncModuleName].ToString().Trim(); //功能模块名称
objvWebSrvClassEN.FuncModuleEnName = objRow[convWebSrvClass.FuncModuleEnName] == DBNull.Value ? null : objRow[convWebSrvClass.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvWebSrvClassEN.FuncModuleNameSim = objRow[convWebSrvClass.FuncModuleNameSim] == DBNull.Value ? null : objRow[convWebSrvClass.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvWebSrvClassEN.IsNeedGene = TransNullToBool(objRow[convWebSrvClass.IsNeedGene].ToString().Trim()); //是否需要生成
objvWebSrvClassEN.PrjId = objRow[convWebSrvClass.PrjId].ToString().Trim(); //工程Id
objvWebSrvClassEN.PrjName = objRow[convWebSrvClass.PrjName] == DBNull.Value ? null : objRow[convWebSrvClass.PrjName].ToString().Trim(); //工程名称
objvWebSrvClassEN.UpdDate = objRow[convWebSrvClass.UpdDate] == DBNull.Value ? null : objRow[convWebSrvClass.UpdDate].ToString().Trim(); //修改日期
objvWebSrvClassEN.UpdUser = objRow[convWebSrvClass.UpdUser] == DBNull.Value ? null : objRow[convWebSrvClass.UpdUser].ToString().Trim(); //修改者
objvWebSrvClassEN.Memo = objRow[convWebSrvClass.Memo] == DBNull.Value ? null : objRow[convWebSrvClass.Memo].ToString().Trim(); //说明
objvWebSrvClassEN.FuncNum = objRow[convWebSrvClass.FuncNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convWebSrvClass.FuncNum].ToString().Trim()); //函数个数
objvWebSrvClassEN.ClsName = objRow[convWebSrvClass.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvWebSrvClassDA: GetObjLst)", objException.Message));
}
objvWebSrvClassEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvWebSrvClassEN);
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
public List<clsvWebSrvClassEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvWebSrvClassDA:GetObjLstByTabName)", objException.Message));
}
List<clsvWebSrvClassEN> arrObjLst = new List<clsvWebSrvClassEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvClassDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvWebSrvClassEN objvWebSrvClassEN = new clsvWebSrvClassEN();
try
{
objvWebSrvClassEN.WebSrvClassId = objRow[convWebSrvClass.WebSrvClassId].ToString().Trim(); //类Id
objvWebSrvClassEN.NameSpace = objRow[convWebSrvClass.NameSpace] == DBNull.Value ? null : objRow[convWebSrvClass.NameSpace].ToString().Trim(); //域名
objvWebSrvClassEN.WebSrvUrl = objRow[convWebSrvClass.WebSrvUrl].ToString().Trim(); //WebSrv地址
objvWebSrvClassEN.PageName = objRow[convWebSrvClass.PageName].ToString().Trim(); //页面名称
objvWebSrvClassEN.FuncModuleAgcId = objRow[convWebSrvClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvWebSrvClassEN.FuncModuleName = objRow[convWebSrvClass.FuncModuleName].ToString().Trim(); //功能模块名称
objvWebSrvClassEN.FuncModuleEnName = objRow[convWebSrvClass.FuncModuleEnName] == DBNull.Value ? null : objRow[convWebSrvClass.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvWebSrvClassEN.FuncModuleNameSim = objRow[convWebSrvClass.FuncModuleNameSim] == DBNull.Value ? null : objRow[convWebSrvClass.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvWebSrvClassEN.IsNeedGene = TransNullToBool(objRow[convWebSrvClass.IsNeedGene].ToString().Trim()); //是否需要生成
objvWebSrvClassEN.PrjId = objRow[convWebSrvClass.PrjId].ToString().Trim(); //工程Id
objvWebSrvClassEN.PrjName = objRow[convWebSrvClass.PrjName] == DBNull.Value ? null : objRow[convWebSrvClass.PrjName].ToString().Trim(); //工程名称
objvWebSrvClassEN.UpdDate = objRow[convWebSrvClass.UpdDate] == DBNull.Value ? null : objRow[convWebSrvClass.UpdDate].ToString().Trim(); //修改日期
objvWebSrvClassEN.UpdUser = objRow[convWebSrvClass.UpdUser] == DBNull.Value ? null : objRow[convWebSrvClass.UpdUser].ToString().Trim(); //修改者
objvWebSrvClassEN.Memo = objRow[convWebSrvClass.Memo] == DBNull.Value ? null : objRow[convWebSrvClass.Memo].ToString().Trim(); //说明
objvWebSrvClassEN.FuncNum = objRow[convWebSrvClass.FuncNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convWebSrvClass.FuncNum].ToString().Trim()); //函数个数
objvWebSrvClassEN.ClsName = objRow[convWebSrvClass.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvWebSrvClassDA: GetObjLst)", objException.Message));
}
objvWebSrvClassEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvWebSrvClassEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvWebSrvClassEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvWebSrvClass(ref clsvWebSrvClassEN objvWebSrvClassEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvClassDA.GetSpecSQLObj();
strSQL = "Select * from vWebSrvClass where WebSrvClassId = " + "'"+ objvWebSrvClassEN.WebSrvClassId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvWebSrvClassEN.WebSrvClassId = objDT.Rows[0][convWebSrvClass.WebSrvClassId].ToString().Trim(); //类Id(字段类型:char,字段长度:8,是否可空:False)
 objvWebSrvClassEN.NameSpace = objDT.Rows[0][convWebSrvClass.NameSpace].ToString().Trim(); //域名(字段类型:varchar,字段长度:50,是否可空:True)
 objvWebSrvClassEN.WebSrvUrl = objDT.Rows[0][convWebSrvClass.WebSrvUrl].ToString().Trim(); //WebSrv地址(字段类型:varchar,字段长度:300,是否可空:False)
 objvWebSrvClassEN.PageName = objDT.Rows[0][convWebSrvClass.PageName].ToString().Trim(); //页面名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvWebSrvClassEN.FuncModuleAgcId = objDT.Rows[0][convWebSrvClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvWebSrvClassEN.FuncModuleName = objDT.Rows[0][convWebSrvClass.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvWebSrvClassEN.FuncModuleEnName = objDT.Rows[0][convWebSrvClass.FuncModuleEnName].ToString().Trim(); //功能模块英文名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvWebSrvClassEN.FuncModuleNameSim = objDT.Rows[0][convWebSrvClass.FuncModuleNameSim].ToString().Trim(); //功能模块简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvWebSrvClassEN.IsNeedGene = TransNullToBool(objDT.Rows[0][convWebSrvClass.IsNeedGene].ToString().Trim()); //是否需要生成(字段类型:bit,字段长度:1,是否可空:True)
 objvWebSrvClassEN.PrjId = objDT.Rows[0][convWebSrvClass.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvWebSrvClassEN.PrjName = objDT.Rows[0][convWebSrvClass.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvWebSrvClassEN.UpdDate = objDT.Rows[0][convWebSrvClass.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvWebSrvClassEN.UpdUser = objDT.Rows[0][convWebSrvClass.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvWebSrvClassEN.Memo = objDT.Rows[0][convWebSrvClass.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvWebSrvClassEN.FuncNum = TransNullToInt(objDT.Rows[0][convWebSrvClass.FuncNum].ToString().Trim()); //函数个数(字段类型:int,字段长度:4,是否可空:True)
 objvWebSrvClassEN.ClsName = objDT.Rows[0][convWebSrvClass.ClsName].ToString().Trim(); //类名(字段类型:varchar,字段长度:100,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvWebSrvClassDA: GetvWebSrvClass)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strWebSrvClassId">表关键字</param>
 /// <returns>表对象</returns>
public clsvWebSrvClassEN GetObjByWebSrvClassId(string strWebSrvClassId)
{
CheckPrimaryKey(strWebSrvClassId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvClassDA.GetSpecSQLObj();
strSQL = "Select * from vWebSrvClass where WebSrvClassId = " + "'"+ strWebSrvClassId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvWebSrvClassEN objvWebSrvClassEN = new clsvWebSrvClassEN();
try
{
 objvWebSrvClassEN.WebSrvClassId = objRow[convWebSrvClass.WebSrvClassId].ToString().Trim(); //类Id(字段类型:char,字段长度:8,是否可空:False)
 objvWebSrvClassEN.NameSpace = objRow[convWebSrvClass.NameSpace] == DBNull.Value ? null : objRow[convWebSrvClass.NameSpace].ToString().Trim(); //域名(字段类型:varchar,字段长度:50,是否可空:True)
 objvWebSrvClassEN.WebSrvUrl = objRow[convWebSrvClass.WebSrvUrl].ToString().Trim(); //WebSrv地址(字段类型:varchar,字段长度:300,是否可空:False)
 objvWebSrvClassEN.PageName = objRow[convWebSrvClass.PageName].ToString().Trim(); //页面名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvWebSrvClassEN.FuncModuleAgcId = objRow[convWebSrvClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvWebSrvClassEN.FuncModuleName = objRow[convWebSrvClass.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvWebSrvClassEN.FuncModuleEnName = objRow[convWebSrvClass.FuncModuleEnName] == DBNull.Value ? null : objRow[convWebSrvClass.FuncModuleEnName].ToString().Trim(); //功能模块英文名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvWebSrvClassEN.FuncModuleNameSim = objRow[convWebSrvClass.FuncModuleNameSim] == DBNull.Value ? null : objRow[convWebSrvClass.FuncModuleNameSim].ToString().Trim(); //功能模块简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvWebSrvClassEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvClass.IsNeedGene].ToString().Trim()); //是否需要生成(字段类型:bit,字段长度:1,是否可空:True)
 objvWebSrvClassEN.PrjId = objRow[convWebSrvClass.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvWebSrvClassEN.PrjName = objRow[convWebSrvClass.PrjName] == DBNull.Value ? null : objRow[convWebSrvClass.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvWebSrvClassEN.UpdDate = objRow[convWebSrvClass.UpdDate] == DBNull.Value ? null : objRow[convWebSrvClass.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvWebSrvClassEN.UpdUser = objRow[convWebSrvClass.UpdUser] == DBNull.Value ? null : objRow[convWebSrvClass.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvWebSrvClassEN.Memo = objRow[convWebSrvClass.Memo] == DBNull.Value ? null : objRow[convWebSrvClass.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvWebSrvClassEN.FuncNum = objRow[convWebSrvClass.FuncNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convWebSrvClass.FuncNum].ToString().Trim()); //函数个数(字段类型:int,字段长度:4,是否可空:True)
 objvWebSrvClassEN.ClsName = objRow[convWebSrvClass.ClsName].ToString().Trim(); //类名(字段类型:varchar,字段长度:100,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvWebSrvClassDA: GetObjByWebSrvClassId)", objException.Message));
}
return objvWebSrvClassEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvWebSrvClassEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvWebSrvClassDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvClassDA.GetSpecSQLObj();
strSQL = "Select * from vWebSrvClass where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvWebSrvClassEN objvWebSrvClassEN = new clsvWebSrvClassEN()
{
WebSrvClassId = objRow[convWebSrvClass.WebSrvClassId].ToString().Trim(), //类Id
NameSpace = objRow[convWebSrvClass.NameSpace] == DBNull.Value ? null : objRow[convWebSrvClass.NameSpace].ToString().Trim(), //域名
WebSrvUrl = objRow[convWebSrvClass.WebSrvUrl].ToString().Trim(), //WebSrv地址
PageName = objRow[convWebSrvClass.PageName].ToString().Trim(), //页面名称
FuncModuleAgcId = objRow[convWebSrvClass.FuncModuleAgcId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convWebSrvClass.FuncModuleName].ToString().Trim(), //功能模块名称
FuncModuleEnName = objRow[convWebSrvClass.FuncModuleEnName] == DBNull.Value ? null : objRow[convWebSrvClass.FuncModuleEnName].ToString().Trim(), //功能模块英文名称
FuncModuleNameSim = objRow[convWebSrvClass.FuncModuleNameSim] == DBNull.Value ? null : objRow[convWebSrvClass.FuncModuleNameSim].ToString().Trim(), //功能模块简称
IsNeedGene = TransNullToBool(objRow[convWebSrvClass.IsNeedGene].ToString().Trim()), //是否需要生成
PrjId = objRow[convWebSrvClass.PrjId].ToString().Trim(), //工程Id
PrjName = objRow[convWebSrvClass.PrjName] == DBNull.Value ? null : objRow[convWebSrvClass.PrjName].ToString().Trim(), //工程名称
UpdDate = objRow[convWebSrvClass.UpdDate] == DBNull.Value ? null : objRow[convWebSrvClass.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convWebSrvClass.UpdUser] == DBNull.Value ? null : objRow[convWebSrvClass.UpdUser].ToString().Trim(), //修改者
Memo = objRow[convWebSrvClass.Memo] == DBNull.Value ? null : objRow[convWebSrvClass.Memo].ToString().Trim(), //说明
FuncNum = objRow[convWebSrvClass.FuncNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convWebSrvClass.FuncNum].ToString().Trim()), //函数个数
ClsName = objRow[convWebSrvClass.ClsName].ToString().Trim() //类名
};
objvWebSrvClassEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvWebSrvClassEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvWebSrvClassDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvWebSrvClassEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvWebSrvClassEN objvWebSrvClassEN = new clsvWebSrvClassEN();
try
{
objvWebSrvClassEN.WebSrvClassId = objRow[convWebSrvClass.WebSrvClassId].ToString().Trim(); //类Id
objvWebSrvClassEN.NameSpace = objRow[convWebSrvClass.NameSpace] == DBNull.Value ? null : objRow[convWebSrvClass.NameSpace].ToString().Trim(); //域名
objvWebSrvClassEN.WebSrvUrl = objRow[convWebSrvClass.WebSrvUrl].ToString().Trim(); //WebSrv地址
objvWebSrvClassEN.PageName = objRow[convWebSrvClass.PageName].ToString().Trim(); //页面名称
objvWebSrvClassEN.FuncModuleAgcId = objRow[convWebSrvClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvWebSrvClassEN.FuncModuleName = objRow[convWebSrvClass.FuncModuleName].ToString().Trim(); //功能模块名称
objvWebSrvClassEN.FuncModuleEnName = objRow[convWebSrvClass.FuncModuleEnName] == DBNull.Value ? null : objRow[convWebSrvClass.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvWebSrvClassEN.FuncModuleNameSim = objRow[convWebSrvClass.FuncModuleNameSim] == DBNull.Value ? null : objRow[convWebSrvClass.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvWebSrvClassEN.IsNeedGene = TransNullToBool(objRow[convWebSrvClass.IsNeedGene].ToString().Trim()); //是否需要生成
objvWebSrvClassEN.PrjId = objRow[convWebSrvClass.PrjId].ToString().Trim(); //工程Id
objvWebSrvClassEN.PrjName = objRow[convWebSrvClass.PrjName] == DBNull.Value ? null : objRow[convWebSrvClass.PrjName].ToString().Trim(); //工程名称
objvWebSrvClassEN.UpdDate = objRow[convWebSrvClass.UpdDate] == DBNull.Value ? null : objRow[convWebSrvClass.UpdDate].ToString().Trim(); //修改日期
objvWebSrvClassEN.UpdUser = objRow[convWebSrvClass.UpdUser] == DBNull.Value ? null : objRow[convWebSrvClass.UpdUser].ToString().Trim(); //修改者
objvWebSrvClassEN.Memo = objRow[convWebSrvClass.Memo] == DBNull.Value ? null : objRow[convWebSrvClass.Memo].ToString().Trim(); //说明
objvWebSrvClassEN.FuncNum = objRow[convWebSrvClass.FuncNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convWebSrvClass.FuncNum].ToString().Trim()); //函数个数
objvWebSrvClassEN.ClsName = objRow[convWebSrvClass.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvWebSrvClassDA: GetObjByDataRowvWebSrvClass)", objException.Message));
}
objvWebSrvClassEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvWebSrvClassEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvWebSrvClassEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvWebSrvClassEN objvWebSrvClassEN = new clsvWebSrvClassEN();
try
{
objvWebSrvClassEN.WebSrvClassId = objRow[convWebSrvClass.WebSrvClassId].ToString().Trim(); //类Id
objvWebSrvClassEN.NameSpace = objRow[convWebSrvClass.NameSpace] == DBNull.Value ? null : objRow[convWebSrvClass.NameSpace].ToString().Trim(); //域名
objvWebSrvClassEN.WebSrvUrl = objRow[convWebSrvClass.WebSrvUrl].ToString().Trim(); //WebSrv地址
objvWebSrvClassEN.PageName = objRow[convWebSrvClass.PageName].ToString().Trim(); //页面名称
objvWebSrvClassEN.FuncModuleAgcId = objRow[convWebSrvClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvWebSrvClassEN.FuncModuleName = objRow[convWebSrvClass.FuncModuleName].ToString().Trim(); //功能模块名称
objvWebSrvClassEN.FuncModuleEnName = objRow[convWebSrvClass.FuncModuleEnName] == DBNull.Value ? null : objRow[convWebSrvClass.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvWebSrvClassEN.FuncModuleNameSim = objRow[convWebSrvClass.FuncModuleNameSim] == DBNull.Value ? null : objRow[convWebSrvClass.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvWebSrvClassEN.IsNeedGene = TransNullToBool(objRow[convWebSrvClass.IsNeedGene].ToString().Trim()); //是否需要生成
objvWebSrvClassEN.PrjId = objRow[convWebSrvClass.PrjId].ToString().Trim(); //工程Id
objvWebSrvClassEN.PrjName = objRow[convWebSrvClass.PrjName] == DBNull.Value ? null : objRow[convWebSrvClass.PrjName].ToString().Trim(); //工程名称
objvWebSrvClassEN.UpdDate = objRow[convWebSrvClass.UpdDate] == DBNull.Value ? null : objRow[convWebSrvClass.UpdDate].ToString().Trim(); //修改日期
objvWebSrvClassEN.UpdUser = objRow[convWebSrvClass.UpdUser] == DBNull.Value ? null : objRow[convWebSrvClass.UpdUser].ToString().Trim(); //修改者
objvWebSrvClassEN.Memo = objRow[convWebSrvClass.Memo] == DBNull.Value ? null : objRow[convWebSrvClass.Memo].ToString().Trim(); //说明
objvWebSrvClassEN.FuncNum = objRow[convWebSrvClass.FuncNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convWebSrvClass.FuncNum].ToString().Trim()); //函数个数
objvWebSrvClassEN.ClsName = objRow[convWebSrvClass.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvWebSrvClassDA: GetObjByDataRow)", objException.Message));
}
objvWebSrvClassEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvWebSrvClassEN;
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
objSQL = clsvWebSrvClassDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvWebSrvClassEN._CurrTabName, convWebSrvClass.WebSrvClassId, 8, "");
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
objSQL = clsvWebSrvClassDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvWebSrvClassEN._CurrTabName, convWebSrvClass.WebSrvClassId, 8, strPrefix);
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
 objSQL = clsvWebSrvClassDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select WebSrvClassId from vWebSrvClass where " + strCondition;
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
 objSQL = clsvWebSrvClassDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select WebSrvClassId from vWebSrvClass where " + strCondition;
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
 /// <param name = "strWebSrvClassId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strWebSrvClassId)
{
CheckPrimaryKey(strWebSrvClassId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvClassDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vWebSrvClass", "WebSrvClassId = " + "'"+ strWebSrvClassId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvWebSrvClassDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvClassDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vWebSrvClass", strCondition))
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
objSQL = clsvWebSrvClassDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vWebSrvClass");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvWebSrvClassENS">源对象</param>
 /// <param name = "objvWebSrvClassENT">目标对象</param>
public void CopyTo(clsvWebSrvClassEN objvWebSrvClassENS, clsvWebSrvClassEN objvWebSrvClassENT)
{
objvWebSrvClassENT.WebSrvClassId = objvWebSrvClassENS.WebSrvClassId; //类Id
objvWebSrvClassENT.NameSpace = objvWebSrvClassENS.NameSpace; //域名
objvWebSrvClassENT.WebSrvUrl = objvWebSrvClassENS.WebSrvUrl; //WebSrv地址
objvWebSrvClassENT.PageName = objvWebSrvClassENS.PageName; //页面名称
objvWebSrvClassENT.FuncModuleAgcId = objvWebSrvClassENS.FuncModuleAgcId; //功能模块Id
objvWebSrvClassENT.FuncModuleName = objvWebSrvClassENS.FuncModuleName; //功能模块名称
objvWebSrvClassENT.FuncModuleEnName = objvWebSrvClassENS.FuncModuleEnName; //功能模块英文名称
objvWebSrvClassENT.FuncModuleNameSim = objvWebSrvClassENS.FuncModuleNameSim; //功能模块简称
objvWebSrvClassENT.IsNeedGene = objvWebSrvClassENS.IsNeedGene; //是否需要生成
objvWebSrvClassENT.PrjId = objvWebSrvClassENS.PrjId; //工程Id
objvWebSrvClassENT.PrjName = objvWebSrvClassENS.PrjName; //工程名称
objvWebSrvClassENT.UpdDate = objvWebSrvClassENS.UpdDate; //修改日期
objvWebSrvClassENT.UpdUser = objvWebSrvClassENS.UpdUser; //修改者
objvWebSrvClassENT.Memo = objvWebSrvClassENS.Memo; //说明
objvWebSrvClassENT.FuncNum = objvWebSrvClassENS.FuncNum; //函数个数
objvWebSrvClassENT.ClsName = objvWebSrvClassENS.ClsName; //类名
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvWebSrvClassEN objvWebSrvClassEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvWebSrvClassEN.WebSrvClassId, 8, convWebSrvClass.WebSrvClassId);
clsCheckSql.CheckFieldLen(objvWebSrvClassEN.NameSpace, 50, convWebSrvClass.NameSpace);
clsCheckSql.CheckFieldLen(objvWebSrvClassEN.WebSrvUrl, 300, convWebSrvClass.WebSrvUrl);
clsCheckSql.CheckFieldLen(objvWebSrvClassEN.PageName, 100, convWebSrvClass.PageName);
clsCheckSql.CheckFieldLen(objvWebSrvClassEN.FuncModuleAgcId, 8, convWebSrvClass.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(objvWebSrvClassEN.FuncModuleName, 30, convWebSrvClass.FuncModuleName);
clsCheckSql.CheckFieldLen(objvWebSrvClassEN.FuncModuleEnName, 30, convWebSrvClass.FuncModuleEnName);
clsCheckSql.CheckFieldLen(objvWebSrvClassEN.FuncModuleNameSim, 30, convWebSrvClass.FuncModuleNameSim);
clsCheckSql.CheckFieldLen(objvWebSrvClassEN.PrjId, 4, convWebSrvClass.PrjId);
clsCheckSql.CheckFieldLen(objvWebSrvClassEN.PrjName, 30, convWebSrvClass.PrjName);
clsCheckSql.CheckFieldLen(objvWebSrvClassEN.UpdDate, 20, convWebSrvClass.UpdDate);
clsCheckSql.CheckFieldLen(objvWebSrvClassEN.UpdUser, 20, convWebSrvClass.UpdUser);
clsCheckSql.CheckFieldLen(objvWebSrvClassEN.Memo, 1000, convWebSrvClass.Memo);
clsCheckSql.CheckFieldLen(objvWebSrvClassEN.ClsName, 100, convWebSrvClass.ClsName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvWebSrvClassEN.WebSrvClassId, convWebSrvClass.WebSrvClassId);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvClassEN.NameSpace, convWebSrvClass.NameSpace);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvClassEN.WebSrvUrl, convWebSrvClass.WebSrvUrl);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvClassEN.PageName, convWebSrvClass.PageName);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvClassEN.FuncModuleAgcId, convWebSrvClass.FuncModuleAgcId);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvClassEN.FuncModuleName, convWebSrvClass.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvClassEN.FuncModuleEnName, convWebSrvClass.FuncModuleEnName);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvClassEN.FuncModuleNameSim, convWebSrvClass.FuncModuleNameSim);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvClassEN.PrjId, convWebSrvClass.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvClassEN.PrjName, convWebSrvClass.PrjName);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvClassEN.UpdDate, convWebSrvClass.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvClassEN.UpdUser, convWebSrvClass.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvClassEN.Memo, convWebSrvClass.Memo);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvClassEN.ClsName, convWebSrvClass.ClsName);
//检查外键字段长度
 objvWebSrvClassEN._IsCheckProperty = true;
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
 objSQL = clsvWebSrvClassDA.GetSpecSQLObj();
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
 objSQL = clsvWebSrvClassDA.GetSpecSQLObj();
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
 objSQL = clsvWebSrvClassDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvWebSrvClassEN._CurrTabName);
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
 objSQL = clsvWebSrvClassDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvWebSrvClassEN._CurrTabName, strCondition);
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
 objSQL = clsvWebSrvClassDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}