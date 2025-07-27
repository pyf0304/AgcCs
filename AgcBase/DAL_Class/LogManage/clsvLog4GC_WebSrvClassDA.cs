
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvLog4GC_WebSrvClassDA
 表名:vLog4GC_WebSrvClass(00050371)
 * 版本:2024.01.24.1(服务器:WIN-SRV103-116)
 日期:2024/01/26 16:17:45
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:日志管理(LogManage)
 框架-层名:数据处理层(CS)(DALCode)
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
using AGC.Entity;

namespace AGC.DAL
{
 /// <summary>
 /// v生成WebSrvClass代码日志(vLog4GC_WebSrvClass)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvLog4GC_WebSrvClassDA : clsCommBase4DA
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
 return clsvLog4GC_WebSrvClassEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvLog4GC_WebSrvClassEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvLog4GC_WebSrvClassEN._ConnectString);
}
return objSQL;
}


 /// <summary>
 /// 获取SQL服务器连接对象
 /// (AutoGCLib.clsGeneCodeBase:Gen_GetSpecSQLObj_Obj)
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
 if (string.IsNullOrEmpty(clsvLog4GC_WebSrvClassEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvLog4GC_WebSrvClassEN._ConnectString);
 }
 return objSQL;
 }


 #region 获取数据表的DataTable

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvLog4GC_WebSrvClassDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvLog4GC_WebSrvClassDA.GetSpecSQLObj();
strSQL = "Select * from vLog4GC_WebSrvClass where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vLog4GC_WebSrvClass(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvLog4GC_WebSrvClassDA: GetDataTable_vLog4GC_WebSrvClass)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvLog4GC_WebSrvClassDA.GetSpecSQLObj();
strSQL = "Select * from vLog4GC_WebSrvClass where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(给定表名)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByTabName_S)
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvLog4GC_WebSrvClassDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvLog4GC_WebSrvClassDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable_Exclude)
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvLog4GC_WebSrvClassDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvLog4GC_WebSrvClassDA.GetSpecSQLObj();
strSQL = "Select * from vLog4GC_WebSrvClass where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByTabName_S_Exclude)
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvLog4GC_WebSrvClassDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvLog4GC_WebSrvClassDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:Gen_GetDataTable_Top_S)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_Top(stuTopPara objTopPara)
{
 return GetDataTable_Top(objTopPara.topSize, objTopPara.whereCond, objTopPara.orderBy);
}

 /// <summary>
 /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:Gen_GetDataTable_Top_S)
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvLog4GC_WebSrvClassDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvLog4GC_WebSrvClassDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vLog4GC_WebSrvClass where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vLog4GC_WebSrvClass where {1} order by {2}", intTopSize, strCondition, strOrderBy);
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:Gen_GetDataTable_Top_S_Exclude)
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvLog4GC_WebSrvClassDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvLog4GC_WebSrvClassDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vLog4GC_WebSrvClass where {1}", intTopSize, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取分页记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByPager_S)
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvLog4GC_WebSrvClassDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvLog4GC_WebSrvClassDA.GetSpecSQLObj();
 int intTop_In = intPageSize * (intPageIndex - 1);//获取连接对象
int intPos_Dot = strOrderBy.IndexOf('|');
if (intPos_Dot > 0)
{
var IsAscOrDesc = "Asc";
if (strOrderBy.IndexOf(" Asc", StringComparison.InvariantCultureIgnoreCase) > 0)
{
strOrderBy = strOrderBy.Replace(" Asc", "");
IsAscOrDesc = "Asc";
}
else if (strOrderBy.IndexOf(" Desc", StringComparison.InvariantCultureIgnoreCase) > 0)
{
strOrderBy = strOrderBy.Replace(" Desc", "");
IsAscOrDesc = "Desc";
}
var arrPart = strOrderBy.Split('|');
if (arrPart.Length != 3)
{
throw new Exception(string.Format("在带有特殊排序分页查询中,strOrderBy:[{0}]应该有竖线(|)分隔的3部分组成,请检查!(in {1})",
strOrderBy, clsStackTrace.GetCurrClassFunction()));
}
string strTabName = arrPart[0];
string strNewOrderBy = arrPart[1];
string strOnCondition = arrPart[2];
strSQL = string.Format("Select Top {0} vLog4GC_WebSrvClass.* from vLog4GC_WebSrvClass Left Join {1} on {2} where {3} and vLog4GC_WebSrvClass.mId not in (Select top {5} vLog4GC_WebSrvClass.mId from vLog4GC_WebSrvClass Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vLog4GC_WebSrvClass where {1} and mId not in (Select top {2} mId from vLog4GC_WebSrvClass where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vLog4GC_WebSrvClass where {1} and mId not in (Select top {3} mId from vLog4GC_WebSrvClass where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
 }
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取分页记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByPager_S_Exclude)
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvLog4GC_WebSrvClassDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvLog4GC_WebSrvClassDA.GetSpecSQLObj();
 int intTop_In = intPageSize * (intPageIndex - 1);//获取连接对象
int intPos_Dot = strOrderBy.IndexOf('|');
if (intPos_Dot > 0)
{
var IsAscOrDesc = "Asc";
if (strOrderBy.IndexOf(" Asc", StringComparison.InvariantCultureIgnoreCase) > 0)
{
strOrderBy = strOrderBy.Replace(" Asc", "");
IsAscOrDesc = "Asc";
}
else if (strOrderBy.IndexOf(" Desc", StringComparison.InvariantCultureIgnoreCase) > 0)
{
strOrderBy = strOrderBy.Replace(" Desc", "");
IsAscOrDesc = "Desc";
}
var arrPart = strOrderBy.Split('|');
if (arrPart.Length != 3)
{
throw new Exception(string.Format("在带有特殊排序分页查询中,strOrderBy:[{0}]应该有竖线(|)分隔的3部分组成,请检查!(in {1})",
strOrderBy, clsStackTrace.GetCurrClassFunction()));
}
string strTabName = arrPart[0];
string strNewOrderBy = arrPart[1];
string strOnCondition = arrPart[2];
strSQL = string.Format("Select Top {0} vLog4GC_WebSrvClass.* from vLog4GC_WebSrvClass Left Join {1} on {2} where {3} and vLog4GC_WebSrvClass.mId not in (Select top {5} vLog4GC_WebSrvClass.mId from vLog4GC_WebSrvClass Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vLog4GC_WebSrvClass where {1} and mId not in (Select top {2} mId from vLog4GC_WebSrvClass where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vLog4GC_WebSrvClass where {1} and mId not in (Select top {3} mId from vLog4GC_WebSrvClass where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
 }
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 #endregion 获取数据表的DataTable

 #region 获取数据表的多个对象列表

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLst)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsvLog4GC_WebSrvClassEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvLog4GC_WebSrvClassDA:GetObjLst)", objException.Message));
}
List<clsvLog4GC_WebSrvClassEN> arrObjLst = new List<clsvLog4GC_WebSrvClassEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvLog4GC_WebSrvClassDA.GetSpecSQLObj();
strSQL = "Select * from vLog4GC_WebSrvClass where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN = new clsvLog4GC_WebSrvClassEN();
try
{
objvLog4GC_WebSrvClassEN.mId = TransNullToInt(objRow[convLog4GC_WebSrvClass.mId].ToString().Trim()); //mId
objvLog4GC_WebSrvClassEN.UserId = objRow[convLog4GC_WebSrvClass.UserId] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.UserId].ToString().Trim(); //用户Id
objvLog4GC_WebSrvClassEN.UserName = objRow[convLog4GC_WebSrvClass.UserName].ToString().Trim(); //用户名
objvLog4GC_WebSrvClassEN.WebSrvClassId = objRow[convLog4GC_WebSrvClass.WebSrvClassId].ToString().Trim(); //类Id
objvLog4GC_WebSrvClassEN.NameSpace = objRow[convLog4GC_WebSrvClass.NameSpace] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.NameSpace].ToString().Trim(); //域名
objvLog4GC_WebSrvClassEN.WebSrvUrl = objRow[convLog4GC_WebSrvClass.WebSrvUrl].ToString().Trim(); //WebSrv地址
objvLog4GC_WebSrvClassEN.PageName = objRow[convLog4GC_WebSrvClass.PageName] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.PageName].ToString().Trim(); //页面名称
objvLog4GC_WebSrvClassEN.FuncModuleAgcId = objRow[convLog4GC_WebSrvClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvLog4GC_WebSrvClassEN.FuncModuleName = objRow[convLog4GC_WebSrvClass.FuncModuleName].ToString().Trim(); //功能模块名称
objvLog4GC_WebSrvClassEN.IsNeedGene = TransNullToBool(objRow[convLog4GC_WebSrvClass.IsNeedGene].ToString().Trim()); //是否需要生成
objvLog4GC_WebSrvClassEN.PrjId = objRow[convLog4GC_WebSrvClass.PrjId].ToString().Trim(); //工程ID
objvLog4GC_WebSrvClassEN.PrjName = objRow[convLog4GC_WebSrvClass.PrjName].ToString().Trim(); //工程名称
objvLog4GC_WebSrvClassEN.FuncNum = objRow[convLog4GC_WebSrvClass.FuncNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convLog4GC_WebSrvClass.FuncNum].ToString().Trim()); //函数个数
objvLog4GC_WebSrvClassEN.GeneCodeDate = objRow[convLog4GC_WebSrvClass.GeneCodeDate] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.GeneCodeDate].ToString().Trim(); //生成代码日期
objvLog4GC_WebSrvClassEN.VersionGeneCode = objRow[convLog4GC_WebSrvClass.VersionGeneCode].ToString().Trim(); //生成代码版本
objvLog4GC_WebSrvClassEN.Memo = objRow[convLog4GC_WebSrvClass.Memo] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.Memo].ToString().Trim(); //说明
objvLog4GC_WebSrvClassEN.ClsName = objRow[convLog4GC_WebSrvClass.ClsName] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvLog4GC_WebSrvClassDA: GetObjLst)", objException.Message));
}
objvLog4GC_WebSrvClassEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvLog4GC_WebSrvClassEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstByTabName)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <param name = "strTabName">表名</param>
 /// <returns>返回对象列表</returns>
public List<clsvLog4GC_WebSrvClassEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvLog4GC_WebSrvClassDA:GetObjLstByTabName)", objException.Message));
}
List<clsvLog4GC_WebSrvClassEN> arrObjLst = new List<clsvLog4GC_WebSrvClassEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvLog4GC_WebSrvClassDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN = new clsvLog4GC_WebSrvClassEN();
try
{
objvLog4GC_WebSrvClassEN.mId = TransNullToInt(objRow[convLog4GC_WebSrvClass.mId].ToString().Trim()); //mId
objvLog4GC_WebSrvClassEN.UserId = objRow[convLog4GC_WebSrvClass.UserId] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.UserId].ToString().Trim(); //用户Id
objvLog4GC_WebSrvClassEN.UserName = objRow[convLog4GC_WebSrvClass.UserName].ToString().Trim(); //用户名
objvLog4GC_WebSrvClassEN.WebSrvClassId = objRow[convLog4GC_WebSrvClass.WebSrvClassId].ToString().Trim(); //类Id
objvLog4GC_WebSrvClassEN.NameSpace = objRow[convLog4GC_WebSrvClass.NameSpace] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.NameSpace].ToString().Trim(); //域名
objvLog4GC_WebSrvClassEN.WebSrvUrl = objRow[convLog4GC_WebSrvClass.WebSrvUrl].ToString().Trim(); //WebSrv地址
objvLog4GC_WebSrvClassEN.PageName = objRow[convLog4GC_WebSrvClass.PageName] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.PageName].ToString().Trim(); //页面名称
objvLog4GC_WebSrvClassEN.FuncModuleAgcId = objRow[convLog4GC_WebSrvClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvLog4GC_WebSrvClassEN.FuncModuleName = objRow[convLog4GC_WebSrvClass.FuncModuleName].ToString().Trim(); //功能模块名称
objvLog4GC_WebSrvClassEN.IsNeedGene = TransNullToBool(objRow[convLog4GC_WebSrvClass.IsNeedGene].ToString().Trim()); //是否需要生成
objvLog4GC_WebSrvClassEN.PrjId = objRow[convLog4GC_WebSrvClass.PrjId].ToString().Trim(); //工程ID
objvLog4GC_WebSrvClassEN.PrjName = objRow[convLog4GC_WebSrvClass.PrjName].ToString().Trim(); //工程名称
objvLog4GC_WebSrvClassEN.FuncNum = objRow[convLog4GC_WebSrvClass.FuncNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convLog4GC_WebSrvClass.FuncNum].ToString().Trim()); //函数个数
objvLog4GC_WebSrvClassEN.GeneCodeDate = objRow[convLog4GC_WebSrvClass.GeneCodeDate] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.GeneCodeDate].ToString().Trim(); //生成代码日期
objvLog4GC_WebSrvClassEN.VersionGeneCode = objRow[convLog4GC_WebSrvClass.VersionGeneCode].ToString().Trim(); //生成代码版本
objvLog4GC_WebSrvClassEN.Memo = objRow[convLog4GC_WebSrvClass.Memo] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.Memo].ToString().Trim(); //说明
objvLog4GC_WebSrvClassEN.ClsName = objRow[convLog4GC_WebSrvClass.ClsName] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvLog4GC_WebSrvClassDA: GetObjLst)", objException.Message));
}
objvLog4GC_WebSrvClassEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvLog4GC_WebSrvClassEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvLog4GC_WebSrvClassEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvLog4GC_WebSrvClass(ref clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvLog4GC_WebSrvClassDA.GetSpecSQLObj();
strSQL = "Select * from vLog4GC_WebSrvClass where mId = " + ""+ objvLog4GC_WebSrvClassEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvLog4GC_WebSrvClassEN.mId = TransNullToInt(objDT.Rows[0][convLog4GC_WebSrvClass.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvLog4GC_WebSrvClassEN.UserId = objDT.Rows[0][convLog4GC_WebSrvClass.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objvLog4GC_WebSrvClassEN.UserName = objDT.Rows[0][convLog4GC_WebSrvClass.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:False)
 objvLog4GC_WebSrvClassEN.WebSrvClassId = objDT.Rows[0][convLog4GC_WebSrvClass.WebSrvClassId].ToString().Trim(); //类Id(字段类型:char,字段长度:8,是否可空:False)
 objvLog4GC_WebSrvClassEN.NameSpace = objDT.Rows[0][convLog4GC_WebSrvClass.NameSpace].ToString().Trim(); //域名(字段类型:varchar,字段长度:50,是否可空:True)
 objvLog4GC_WebSrvClassEN.WebSrvUrl = objDT.Rows[0][convLog4GC_WebSrvClass.WebSrvUrl].ToString().Trim(); //WebSrv地址(字段类型:varchar,字段长度:300,是否可空:False)
 objvLog4GC_WebSrvClassEN.PageName = objDT.Rows[0][convLog4GC_WebSrvClass.PageName].ToString().Trim(); //页面名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvLog4GC_WebSrvClassEN.FuncModuleAgcId = objDT.Rows[0][convLog4GC_WebSrvClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvLog4GC_WebSrvClassEN.FuncModuleName = objDT.Rows[0][convLog4GC_WebSrvClass.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvLog4GC_WebSrvClassEN.IsNeedGene = TransNullToBool(objDT.Rows[0][convLog4GC_WebSrvClass.IsNeedGene].ToString().Trim()); //是否需要生成(字段类型:bit,字段长度:1,是否可空:True)
 objvLog4GC_WebSrvClassEN.PrjId = objDT.Rows[0][convLog4GC_WebSrvClass.PrjId].ToString().Trim(); //工程ID(字段类型:char,字段长度:4,是否可空:False)
 objvLog4GC_WebSrvClassEN.PrjName = objDT.Rows[0][convLog4GC_WebSrvClass.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvLog4GC_WebSrvClassEN.FuncNum = TransNullToInt(objDT.Rows[0][convLog4GC_WebSrvClass.FuncNum].ToString().Trim()); //函数个数(字段类型:int,字段长度:4,是否可空:True)
 objvLog4GC_WebSrvClassEN.GeneCodeDate = objDT.Rows[0][convLog4GC_WebSrvClass.GeneCodeDate].ToString().Trim(); //生成代码日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvLog4GC_WebSrvClassEN.VersionGeneCode = objDT.Rows[0][convLog4GC_WebSrvClass.VersionGeneCode].ToString().Trim(); //生成代码版本(字段类型:varchar,字段长度:30,是否可空:False)
 objvLog4GC_WebSrvClassEN.Memo = objDT.Rows[0][convLog4GC_WebSrvClass.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvLog4GC_WebSrvClassEN.ClsName = objDT.Rows[0][convLog4GC_WebSrvClass.ClsName].ToString().Trim(); //类名(字段类型:varchar,字段长度:100,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvLog4GC_WebSrvClassDA: GetvLog4GC_WebSrvClass)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvLog4GC_WebSrvClassEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvLog4GC_WebSrvClassDA.GetSpecSQLObj();
strSQL = "Select * from vLog4GC_WebSrvClass where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN = new clsvLog4GC_WebSrvClassEN();
try
{
 objvLog4GC_WebSrvClassEN.mId = Int32.Parse(objRow[convLog4GC_WebSrvClass.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvLog4GC_WebSrvClassEN.UserId = objRow[convLog4GC_WebSrvClass.UserId] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objvLog4GC_WebSrvClassEN.UserName = objRow[convLog4GC_WebSrvClass.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:False)
 objvLog4GC_WebSrvClassEN.WebSrvClassId = objRow[convLog4GC_WebSrvClass.WebSrvClassId].ToString().Trim(); //类Id(字段类型:char,字段长度:8,是否可空:False)
 objvLog4GC_WebSrvClassEN.NameSpace = objRow[convLog4GC_WebSrvClass.NameSpace] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.NameSpace].ToString().Trim(); //域名(字段类型:varchar,字段长度:50,是否可空:True)
 objvLog4GC_WebSrvClassEN.WebSrvUrl = objRow[convLog4GC_WebSrvClass.WebSrvUrl].ToString().Trim(); //WebSrv地址(字段类型:varchar,字段长度:300,是否可空:False)
 objvLog4GC_WebSrvClassEN.PageName = objRow[convLog4GC_WebSrvClass.PageName] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.PageName].ToString().Trim(); //页面名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvLog4GC_WebSrvClassEN.FuncModuleAgcId = objRow[convLog4GC_WebSrvClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvLog4GC_WebSrvClassEN.FuncModuleName = objRow[convLog4GC_WebSrvClass.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvLog4GC_WebSrvClassEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[convLog4GC_WebSrvClass.IsNeedGene].ToString().Trim()); //是否需要生成(字段类型:bit,字段长度:1,是否可空:True)
 objvLog4GC_WebSrvClassEN.PrjId = objRow[convLog4GC_WebSrvClass.PrjId].ToString().Trim(); //工程ID(字段类型:char,字段长度:4,是否可空:False)
 objvLog4GC_WebSrvClassEN.PrjName = objRow[convLog4GC_WebSrvClass.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvLog4GC_WebSrvClassEN.FuncNum = objRow[convLog4GC_WebSrvClass.FuncNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convLog4GC_WebSrvClass.FuncNum].ToString().Trim()); //函数个数(字段类型:int,字段长度:4,是否可空:True)
 objvLog4GC_WebSrvClassEN.GeneCodeDate = objRow[convLog4GC_WebSrvClass.GeneCodeDate] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.GeneCodeDate].ToString().Trim(); //生成代码日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvLog4GC_WebSrvClassEN.VersionGeneCode = objRow[convLog4GC_WebSrvClass.VersionGeneCode].ToString().Trim(); //生成代码版本(字段类型:varchar,字段长度:30,是否可空:False)
 objvLog4GC_WebSrvClassEN.Memo = objRow[convLog4GC_WebSrvClass.Memo] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvLog4GC_WebSrvClassEN.ClsName = objRow[convLog4GC_WebSrvClass.ClsName] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.ClsName].ToString().Trim(); //类名(字段类型:varchar,字段长度:100,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvLog4GC_WebSrvClassDA: GetObjBymId)", objException.Message));
}
return objvLog4GC_WebSrvClassEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvLog4GC_WebSrvClassEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvLog4GC_WebSrvClassDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvLog4GC_WebSrvClassDA.GetSpecSQLObj();
strSQL = "Select * from vLog4GC_WebSrvClass where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN = new clsvLog4GC_WebSrvClassEN()
{
mId = TransNullToInt(objRow[convLog4GC_WebSrvClass.mId].ToString().Trim()), //mId
UserId = objRow[convLog4GC_WebSrvClass.UserId] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.UserId].ToString().Trim(), //用户Id
UserName = objRow[convLog4GC_WebSrvClass.UserName].ToString().Trim(), //用户名
WebSrvClassId = objRow[convLog4GC_WebSrvClass.WebSrvClassId].ToString().Trim(), //类Id
NameSpace = objRow[convLog4GC_WebSrvClass.NameSpace] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.NameSpace].ToString().Trim(), //域名
WebSrvUrl = objRow[convLog4GC_WebSrvClass.WebSrvUrl].ToString().Trim(), //WebSrv地址
PageName = objRow[convLog4GC_WebSrvClass.PageName] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.PageName].ToString().Trim(), //页面名称
FuncModuleAgcId = objRow[convLog4GC_WebSrvClass.FuncModuleAgcId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convLog4GC_WebSrvClass.FuncModuleName].ToString().Trim(), //功能模块名称
IsNeedGene = TransNullToBool(objRow[convLog4GC_WebSrvClass.IsNeedGene].ToString().Trim()), //是否需要生成
PrjId = objRow[convLog4GC_WebSrvClass.PrjId].ToString().Trim(), //工程ID
PrjName = objRow[convLog4GC_WebSrvClass.PrjName].ToString().Trim(), //工程名称
FuncNum = objRow[convLog4GC_WebSrvClass.FuncNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convLog4GC_WebSrvClass.FuncNum].ToString().Trim()), //函数个数
GeneCodeDate = objRow[convLog4GC_WebSrvClass.GeneCodeDate] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.GeneCodeDate].ToString().Trim(), //生成代码日期
VersionGeneCode = objRow[convLog4GC_WebSrvClass.VersionGeneCode].ToString().Trim(), //生成代码版本
Memo = objRow[convLog4GC_WebSrvClass.Memo] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.Memo].ToString().Trim(), //说明
ClsName = objRow[convLog4GC_WebSrvClass.ClsName] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.ClsName].ToString().Trim() //类名
};
objvLog4GC_WebSrvClassEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvLog4GC_WebSrvClassEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvLog4GC_WebSrvClassDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvLog4GC_WebSrvClassEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN = new clsvLog4GC_WebSrvClassEN();
try
{
objvLog4GC_WebSrvClassEN.mId = TransNullToInt(objRow[convLog4GC_WebSrvClass.mId].ToString().Trim()); //mId
objvLog4GC_WebSrvClassEN.UserId = objRow[convLog4GC_WebSrvClass.UserId] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.UserId].ToString().Trim(); //用户Id
objvLog4GC_WebSrvClassEN.UserName = objRow[convLog4GC_WebSrvClass.UserName].ToString().Trim(); //用户名
objvLog4GC_WebSrvClassEN.WebSrvClassId = objRow[convLog4GC_WebSrvClass.WebSrvClassId].ToString().Trim(); //类Id
objvLog4GC_WebSrvClassEN.NameSpace = objRow[convLog4GC_WebSrvClass.NameSpace] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.NameSpace].ToString().Trim(); //域名
objvLog4GC_WebSrvClassEN.WebSrvUrl = objRow[convLog4GC_WebSrvClass.WebSrvUrl].ToString().Trim(); //WebSrv地址
objvLog4GC_WebSrvClassEN.PageName = objRow[convLog4GC_WebSrvClass.PageName] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.PageName].ToString().Trim(); //页面名称
objvLog4GC_WebSrvClassEN.FuncModuleAgcId = objRow[convLog4GC_WebSrvClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvLog4GC_WebSrvClassEN.FuncModuleName = objRow[convLog4GC_WebSrvClass.FuncModuleName].ToString().Trim(); //功能模块名称
objvLog4GC_WebSrvClassEN.IsNeedGene = TransNullToBool(objRow[convLog4GC_WebSrvClass.IsNeedGene].ToString().Trim()); //是否需要生成
objvLog4GC_WebSrvClassEN.PrjId = objRow[convLog4GC_WebSrvClass.PrjId].ToString().Trim(); //工程ID
objvLog4GC_WebSrvClassEN.PrjName = objRow[convLog4GC_WebSrvClass.PrjName].ToString().Trim(); //工程名称
objvLog4GC_WebSrvClassEN.FuncNum = objRow[convLog4GC_WebSrvClass.FuncNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convLog4GC_WebSrvClass.FuncNum].ToString().Trim()); //函数个数
objvLog4GC_WebSrvClassEN.GeneCodeDate = objRow[convLog4GC_WebSrvClass.GeneCodeDate] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.GeneCodeDate].ToString().Trim(); //生成代码日期
objvLog4GC_WebSrvClassEN.VersionGeneCode = objRow[convLog4GC_WebSrvClass.VersionGeneCode].ToString().Trim(); //生成代码版本
objvLog4GC_WebSrvClassEN.Memo = objRow[convLog4GC_WebSrvClass.Memo] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.Memo].ToString().Trim(); //说明
objvLog4GC_WebSrvClassEN.ClsName = objRow[convLog4GC_WebSrvClass.ClsName] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvLog4GC_WebSrvClassDA: GetObjByDataRowvLog4GC_WebSrvClass)", objException.Message));
}
objvLog4GC_WebSrvClassEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvLog4GC_WebSrvClassEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvLog4GC_WebSrvClassEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN = new clsvLog4GC_WebSrvClassEN();
try
{
objvLog4GC_WebSrvClassEN.mId = TransNullToInt(objRow[convLog4GC_WebSrvClass.mId].ToString().Trim()); //mId
objvLog4GC_WebSrvClassEN.UserId = objRow[convLog4GC_WebSrvClass.UserId] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.UserId].ToString().Trim(); //用户Id
objvLog4GC_WebSrvClassEN.UserName = objRow[convLog4GC_WebSrvClass.UserName].ToString().Trim(); //用户名
objvLog4GC_WebSrvClassEN.WebSrvClassId = objRow[convLog4GC_WebSrvClass.WebSrvClassId].ToString().Trim(); //类Id
objvLog4GC_WebSrvClassEN.NameSpace = objRow[convLog4GC_WebSrvClass.NameSpace] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.NameSpace].ToString().Trim(); //域名
objvLog4GC_WebSrvClassEN.WebSrvUrl = objRow[convLog4GC_WebSrvClass.WebSrvUrl].ToString().Trim(); //WebSrv地址
objvLog4GC_WebSrvClassEN.PageName = objRow[convLog4GC_WebSrvClass.PageName] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.PageName].ToString().Trim(); //页面名称
objvLog4GC_WebSrvClassEN.FuncModuleAgcId = objRow[convLog4GC_WebSrvClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvLog4GC_WebSrvClassEN.FuncModuleName = objRow[convLog4GC_WebSrvClass.FuncModuleName].ToString().Trim(); //功能模块名称
objvLog4GC_WebSrvClassEN.IsNeedGene = TransNullToBool(objRow[convLog4GC_WebSrvClass.IsNeedGene].ToString().Trim()); //是否需要生成
objvLog4GC_WebSrvClassEN.PrjId = objRow[convLog4GC_WebSrvClass.PrjId].ToString().Trim(); //工程ID
objvLog4GC_WebSrvClassEN.PrjName = objRow[convLog4GC_WebSrvClass.PrjName].ToString().Trim(); //工程名称
objvLog4GC_WebSrvClassEN.FuncNum = objRow[convLog4GC_WebSrvClass.FuncNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convLog4GC_WebSrvClass.FuncNum].ToString().Trim()); //函数个数
objvLog4GC_WebSrvClassEN.GeneCodeDate = objRow[convLog4GC_WebSrvClass.GeneCodeDate] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.GeneCodeDate].ToString().Trim(); //生成代码日期
objvLog4GC_WebSrvClassEN.VersionGeneCode = objRow[convLog4GC_WebSrvClass.VersionGeneCode].ToString().Trim(); //生成代码版本
objvLog4GC_WebSrvClassEN.Memo = objRow[convLog4GC_WebSrvClass.Memo] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.Memo].ToString().Trim(); //说明
objvLog4GC_WebSrvClassEN.ClsName = objRow[convLog4GC_WebSrvClass.ClsName] == DBNull.Value ? null : objRow[convLog4GC_WebSrvClass.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvLog4GC_WebSrvClassDA: GetObjByDataRow)", objException.Message));
}
objvLog4GC_WebSrvClassEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvLog4GC_WebSrvClassEN;
}

 #endregion 获取一个实体对象

 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表最大字符型关键字ID
 /// (AutoGCLib.clsGeneCodeBase:GenGetMaxStrID)
 /// </summary>
 /// <returns>返回的最大关键字值ID</returns>
public static string GetMaxStrId()
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsvLog4GC_WebSrvClassDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvLog4GC_WebSrvClassEN._CurrTabName, convLog4GC_WebSrvClass.mId, 8, "");
return strMaxValue;
}

 /// <summary>
 /// 根据前缀获取当前表最大字符型关键字ID
 /// (AutoGCLib.clsGeneCodeBase:GenGetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>返回的最大关键字值ID</returns>
public string GetMaxStrIdByPrefix(string strPrefix)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsvLog4GC_WebSrvClassDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvLog4GC_WebSrvClassEN._CurrTabName, convLog4GC_WebSrvClass.mId, 8, strPrefix);
return strMaxValue;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public long GetFirstID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvLog4GC_WebSrvClassDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vLog4GC_WebSrvClass where " + strCondition;
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
 /// (AutoGCLib.clsGeneCodeBase:GenGetPrimaryKeyID)
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
 objSQL = clsvLog4GC_WebSrvClassDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vLog4GC_WebSrvClass where " + strCondition;
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
 /// (AutoGCLib.clsGeneCodeBase:GenIsExist_S)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngmId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvLog4GC_WebSrvClassDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vLog4GC_WebSrvClass", "mId = " + ""+ lngmId+""))
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
 /// (AutoGCLib.clsGeneCodeBase:GenIsExistCondRec_S)
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvLog4GC_WebSrvClassDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvLog4GC_WebSrvClassDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vLog4GC_WebSrvClass", strCondition))
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
 /// (AutoGCLib.clsGeneCodeBase:GenIsExistTable)
 /// </summary>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable()
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsvLog4GC_WebSrvClassDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vLog4GC_WebSrvClass");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvLog4GC_WebSrvClassENS">源对象</param>
 /// <param name = "objvLog4GC_WebSrvClassENT">目标对象</param>
public void CopyTo(clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassENS, clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassENT)
{
objvLog4GC_WebSrvClassENT.mId = objvLog4GC_WebSrvClassENS.mId; //mId
objvLog4GC_WebSrvClassENT.UserId = objvLog4GC_WebSrvClassENS.UserId; //用户Id
objvLog4GC_WebSrvClassENT.UserName = objvLog4GC_WebSrvClassENS.UserName; //用户名
objvLog4GC_WebSrvClassENT.WebSrvClassId = objvLog4GC_WebSrvClassENS.WebSrvClassId; //类Id
objvLog4GC_WebSrvClassENT.NameSpace = objvLog4GC_WebSrvClassENS.NameSpace; //域名
objvLog4GC_WebSrvClassENT.WebSrvUrl = objvLog4GC_WebSrvClassENS.WebSrvUrl; //WebSrv地址
objvLog4GC_WebSrvClassENT.PageName = objvLog4GC_WebSrvClassENS.PageName; //页面名称
objvLog4GC_WebSrvClassENT.FuncModuleAgcId = objvLog4GC_WebSrvClassENS.FuncModuleAgcId; //功能模块Id
objvLog4GC_WebSrvClassENT.FuncModuleName = objvLog4GC_WebSrvClassENS.FuncModuleName; //功能模块名称
objvLog4GC_WebSrvClassENT.IsNeedGene = objvLog4GC_WebSrvClassENS.IsNeedGene; //是否需要生成
objvLog4GC_WebSrvClassENT.PrjId = objvLog4GC_WebSrvClassENS.PrjId; //工程ID
objvLog4GC_WebSrvClassENT.PrjName = objvLog4GC_WebSrvClassENS.PrjName; //工程名称
objvLog4GC_WebSrvClassENT.FuncNum = objvLog4GC_WebSrvClassENS.FuncNum; //函数个数
objvLog4GC_WebSrvClassENT.GeneCodeDate = objvLog4GC_WebSrvClassENS.GeneCodeDate; //生成代码日期
objvLog4GC_WebSrvClassENT.VersionGeneCode = objvLog4GC_WebSrvClassENS.VersionGeneCode; //生成代码版本
objvLog4GC_WebSrvClassENT.Memo = objvLog4GC_WebSrvClassENS.Memo; //说明
objvLog4GC_WebSrvClassENT.ClsName = objvLog4GC_WebSrvClassENS.ClsName; //类名
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvLog4GC_WebSrvClassEN objvLog4GC_WebSrvClassEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvLog4GC_WebSrvClassEN.UserId, 18, convLog4GC_WebSrvClass.UserId);
clsCheckSql.CheckFieldLen(objvLog4GC_WebSrvClassEN.UserName, 30, convLog4GC_WebSrvClass.UserName);
clsCheckSql.CheckFieldLen(objvLog4GC_WebSrvClassEN.WebSrvClassId, 8, convLog4GC_WebSrvClass.WebSrvClassId);
clsCheckSql.CheckFieldLen(objvLog4GC_WebSrvClassEN.NameSpace, 50, convLog4GC_WebSrvClass.NameSpace);
clsCheckSql.CheckFieldLen(objvLog4GC_WebSrvClassEN.WebSrvUrl, 300, convLog4GC_WebSrvClass.WebSrvUrl);
clsCheckSql.CheckFieldLen(objvLog4GC_WebSrvClassEN.PageName, 100, convLog4GC_WebSrvClass.PageName);
clsCheckSql.CheckFieldLen(objvLog4GC_WebSrvClassEN.FuncModuleAgcId, 8, convLog4GC_WebSrvClass.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(objvLog4GC_WebSrvClassEN.FuncModuleName, 30, convLog4GC_WebSrvClass.FuncModuleName);
clsCheckSql.CheckFieldLen(objvLog4GC_WebSrvClassEN.PrjId, 4, convLog4GC_WebSrvClass.PrjId);
clsCheckSql.CheckFieldLen(objvLog4GC_WebSrvClassEN.PrjName, 30, convLog4GC_WebSrvClass.PrjName);
clsCheckSql.CheckFieldLen(objvLog4GC_WebSrvClassEN.GeneCodeDate, 20, convLog4GC_WebSrvClass.GeneCodeDate);
clsCheckSql.CheckFieldLen(objvLog4GC_WebSrvClassEN.VersionGeneCode, 30, convLog4GC_WebSrvClass.VersionGeneCode);
clsCheckSql.CheckFieldLen(objvLog4GC_WebSrvClassEN.Memo, 1000, convLog4GC_WebSrvClass.Memo);
clsCheckSql.CheckFieldLen(objvLog4GC_WebSrvClassEN.ClsName, 100, convLog4GC_WebSrvClass.ClsName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvLog4GC_WebSrvClassEN.UserId, convLog4GC_WebSrvClass.UserId);
clsCheckSql.CheckSqlInjection4Field(objvLog4GC_WebSrvClassEN.UserName, convLog4GC_WebSrvClass.UserName);
clsCheckSql.CheckSqlInjection4Field(objvLog4GC_WebSrvClassEN.WebSrvClassId, convLog4GC_WebSrvClass.WebSrvClassId);
clsCheckSql.CheckSqlInjection4Field(objvLog4GC_WebSrvClassEN.NameSpace, convLog4GC_WebSrvClass.NameSpace);
clsCheckSql.CheckSqlInjection4Field(objvLog4GC_WebSrvClassEN.WebSrvUrl, convLog4GC_WebSrvClass.WebSrvUrl);
clsCheckSql.CheckSqlInjection4Field(objvLog4GC_WebSrvClassEN.PageName, convLog4GC_WebSrvClass.PageName);
clsCheckSql.CheckSqlInjection4Field(objvLog4GC_WebSrvClassEN.FuncModuleAgcId, convLog4GC_WebSrvClass.FuncModuleAgcId);
clsCheckSql.CheckSqlInjection4Field(objvLog4GC_WebSrvClassEN.FuncModuleName, convLog4GC_WebSrvClass.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvLog4GC_WebSrvClassEN.PrjId, convLog4GC_WebSrvClass.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvLog4GC_WebSrvClassEN.PrjName, convLog4GC_WebSrvClass.PrjName);
clsCheckSql.CheckSqlInjection4Field(objvLog4GC_WebSrvClassEN.GeneCodeDate, convLog4GC_WebSrvClass.GeneCodeDate);
clsCheckSql.CheckSqlInjection4Field(objvLog4GC_WebSrvClassEN.VersionGeneCode, convLog4GC_WebSrvClass.VersionGeneCode);
clsCheckSql.CheckSqlInjection4Field(objvLog4GC_WebSrvClassEN.Memo, convLog4GC_WebSrvClass.Memo);
clsCheckSql.CheckSqlInjection4Field(objvLog4GC_WebSrvClassEN.ClsName, convLog4GC_WebSrvClass.ClsName);
//检查外键字段长度
 objvLog4GC_WebSrvClassEN._IsCheckProperty = true;
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
 objSQL = clsvLog4GC_WebSrvClassDA.GetSpecSQLObj();
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
 objSQL = clsvLog4GC_WebSrvClassDA.GetSpecSQLObj();
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
 objSQL = clsvLog4GC_WebSrvClassDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvLog4GC_WebSrvClassEN._CurrTabName);
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
 objSQL = clsvLog4GC_WebSrvClassDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvLog4GC_WebSrvClassEN._CurrTabName, strCondition);
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
 objSQL = clsvLog4GC_WebSrvClassDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}