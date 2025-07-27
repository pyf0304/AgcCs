
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCMClassDA
 表名:vCMClass(00050506)
 * 版本:2024.01.24.1(服务器:WIN-SRV103-116)
 日期:2024/01/26 16:18:03
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:代码管理(CodeMan)
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
 /// vCM类(vCMClass)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvCMClassDA : clsCommBase4DA
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
 return clsvCMClassEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvCMClassEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCMClassEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvCMClassEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvCMClassEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strCmClassId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strCmClassId)
{
strCmClassId = strCmClassId.Replace("'", "''");
if (strCmClassId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vCMClass中,检查关键字,长度不正确!(clsvCMClassDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strCmClassId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vCMClass中,关键字不能为空 或 null!(clsvCMClassDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCmClassId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvCMClassDA:CheckPrimaryKey)", objException.Message));
}
return true;
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvCMClassDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMClassDA.GetSpecSQLObj();
strSQL = "Select * from vCMClass where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vCMClass(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvCMClassDA: GetDataTable_vCMClass)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMClassDA.GetSpecSQLObj();
strSQL = "Select * from vCMClass where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvCMClassDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMClassDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvCMClassDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMClassDA.GetSpecSQLObj();
strSQL = "Select * from vCMClass where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvCMClassDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMClassDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvCMClassDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMClassDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCMClass where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCMClass where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvCMClassDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMClassDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vCMClass where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvCMClassDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMClassDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCMClass.* from vCMClass Left Join {1} on {2} where {3} and vCMClass.CmClassId not in (Select top {5} vCMClass.CmClassId from vCMClass Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCMClass where {1} and CmClassId not in (Select top {2} CmClassId from vCMClass where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCMClass where {1} and CmClassId not in (Select top {3} CmClassId from vCMClass where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvCMClassDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMClassDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCMClass.* from vCMClass Left Join {1} on {2} where {3} and vCMClass.CmClassId not in (Select top {5} vCMClass.CmClassId from vCMClass Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCMClass where {1} and CmClassId not in (Select top {2} CmClassId from vCMClass where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCMClass where {1} and CmClassId not in (Select top {3} CmClassId from vCMClass where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvCMClassEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvCMClassDA:GetObjLst)", objException.Message));
}
List<clsvCMClassEN> arrObjLst = new List<clsvCMClassEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMClassDA.GetSpecSQLObj();
strSQL = "Select * from vCMClass where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMClassEN objvCMClassEN = new clsvCMClassEN();
try
{
objvCMClassEN.CmClassId = objRow[convCMClass.CmClassId].ToString().Trim(); //类Id
objvCMClassEN.ApplicationTypeId = TransNullToInt(objRow[convCMClass.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMClassEN.ApplicationTypeName = objRow[convCMClass.ApplicationTypeName] == DBNull.Value ? null : objRow[convCMClass.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvCMClassEN.ApplicationTypeSimName = objRow[convCMClass.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMClass.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMClassEN.ProgLangTypeId = objRow[convCMClass.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCMClassEN.ProgLangTypeName = objRow[convCMClass.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvCMClassEN.ProgLangTypeSimName = objRow[convCMClass.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCMClass.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvCMClassEN.TabName = objRow[convCMClass.TabName].ToString().Trim(); //表名
objvCMClassEN.NameSpace = objRow[convCMClass.NameSpace] == DBNull.Value ? null : objRow[convCMClass.NameSpace].ToString().Trim(); //域名
objvCMClassEN.ProjectPath = objRow[convCMClass.ProjectPath].ToString().Trim(); //工程路径
objvCMClassEN.FilePath = objRow[convCMClass.FilePath].ToString().Trim(); //文件路径
objvCMClassEN.FileName = objRow[convCMClass.FileName].ToString().Trim(); //文件名
objvCMClassEN.FileText = objRow[convCMClass.FileText] == DBNull.Value ? null : objRow[convCMClass.FileText].ToString().Trim(); //文件内容
objvCMClassEN.FuncModuleAgcId = objRow[convCMClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMClassEN.FuncModuleName = objRow[convCMClass.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMClassEN.FuncModuleNameSim = objRow[convCMClass.FuncModuleNameSim] == DBNull.Value ? null : objRow[convCMClass.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvCMClassEN.CodeTypeId = objRow[convCMClass.CodeTypeId].ToString().Trim(); //代码类型Id
objvCMClassEN.CodeTypeName = objRow[convCMClass.CodeTypeName].ToString().Trim(); //代码类型名
objvCMClassEN.CodeTypeSimName = objRow[convCMClass.CodeTypeSimName].ToString().Trim(); //简称
objvCMClassEN.UserId = objRow[convCMClass.UserId] == DBNull.Value ? null : objRow[convCMClass.UserId].ToString().Trim(); //用户Id
objvCMClassEN.PrjId = objRow[convCMClass.PrjId].ToString().Trim(); //工程ID
objvCMClassEN.PrjName = objRow[convCMClass.PrjName].ToString().Trim(); //工程名称
objvCMClassEN.IsOpen = TransNullToBool(objRow[convCMClass.IsOpen].ToString().Trim()); //是否开放
objvCMClassEN.UpdDate = objRow[convCMClass.UpdDate] == DBNull.Value ? null : objRow[convCMClass.UpdDate].ToString().Trim(); //修改日期
objvCMClassEN.UpdUser = objRow[convCMClass.UpdUser] == DBNull.Value ? null : objRow[convCMClass.UpdUser].ToString().Trim(); //修改者
objvCMClassEN.Memo = objRow[convCMClass.Memo] == DBNull.Value ? null : objRow[convCMClass.Memo].ToString().Trim(); //说明
objvCMClassEN.FuncNum = objRow[convCMClass.FuncNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCMClass.FuncNum].ToString().Trim()); //函数个数
objvCMClassEN.ClsName = objRow[convCMClass.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCMClassDA: GetObjLst)", objException.Message));
}
objvCMClassEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCMClassEN);
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
public List<clsvCMClassEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvCMClassDA:GetObjLstByTabName)", objException.Message));
}
List<clsvCMClassEN> arrObjLst = new List<clsvCMClassEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMClassDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMClassEN objvCMClassEN = new clsvCMClassEN();
try
{
objvCMClassEN.CmClassId = objRow[convCMClass.CmClassId].ToString().Trim(); //类Id
objvCMClassEN.ApplicationTypeId = TransNullToInt(objRow[convCMClass.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMClassEN.ApplicationTypeName = objRow[convCMClass.ApplicationTypeName] == DBNull.Value ? null : objRow[convCMClass.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvCMClassEN.ApplicationTypeSimName = objRow[convCMClass.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMClass.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMClassEN.ProgLangTypeId = objRow[convCMClass.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCMClassEN.ProgLangTypeName = objRow[convCMClass.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvCMClassEN.ProgLangTypeSimName = objRow[convCMClass.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCMClass.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvCMClassEN.TabName = objRow[convCMClass.TabName].ToString().Trim(); //表名
objvCMClassEN.NameSpace = objRow[convCMClass.NameSpace] == DBNull.Value ? null : objRow[convCMClass.NameSpace].ToString().Trim(); //域名
objvCMClassEN.ProjectPath = objRow[convCMClass.ProjectPath].ToString().Trim(); //工程路径
objvCMClassEN.FilePath = objRow[convCMClass.FilePath].ToString().Trim(); //文件路径
objvCMClassEN.FileName = objRow[convCMClass.FileName].ToString().Trim(); //文件名
objvCMClassEN.FileText = objRow[convCMClass.FileText] == DBNull.Value ? null : objRow[convCMClass.FileText].ToString().Trim(); //文件内容
objvCMClassEN.FuncModuleAgcId = objRow[convCMClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMClassEN.FuncModuleName = objRow[convCMClass.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMClassEN.FuncModuleNameSim = objRow[convCMClass.FuncModuleNameSim] == DBNull.Value ? null : objRow[convCMClass.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvCMClassEN.CodeTypeId = objRow[convCMClass.CodeTypeId].ToString().Trim(); //代码类型Id
objvCMClassEN.CodeTypeName = objRow[convCMClass.CodeTypeName].ToString().Trim(); //代码类型名
objvCMClassEN.CodeTypeSimName = objRow[convCMClass.CodeTypeSimName].ToString().Trim(); //简称
objvCMClassEN.UserId = objRow[convCMClass.UserId] == DBNull.Value ? null : objRow[convCMClass.UserId].ToString().Trim(); //用户Id
objvCMClassEN.PrjId = objRow[convCMClass.PrjId].ToString().Trim(); //工程ID
objvCMClassEN.PrjName = objRow[convCMClass.PrjName].ToString().Trim(); //工程名称
objvCMClassEN.IsOpen = TransNullToBool(objRow[convCMClass.IsOpen].ToString().Trim()); //是否开放
objvCMClassEN.UpdDate = objRow[convCMClass.UpdDate] == DBNull.Value ? null : objRow[convCMClass.UpdDate].ToString().Trim(); //修改日期
objvCMClassEN.UpdUser = objRow[convCMClass.UpdUser] == DBNull.Value ? null : objRow[convCMClass.UpdUser].ToString().Trim(); //修改者
objvCMClassEN.Memo = objRow[convCMClass.Memo] == DBNull.Value ? null : objRow[convCMClass.Memo].ToString().Trim(); //说明
objvCMClassEN.FuncNum = objRow[convCMClass.FuncNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCMClass.FuncNum].ToString().Trim()); //函数个数
objvCMClassEN.ClsName = objRow[convCMClass.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCMClassDA: GetObjLst)", objException.Message));
}
objvCMClassEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCMClassEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvCMClassEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvCMClass(ref clsvCMClassEN objvCMClassEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMClassDA.GetSpecSQLObj();
strSQL = "Select * from vCMClass where CmClassId = " + "'"+ objvCMClassEN.CmClassId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvCMClassEN.CmClassId = objDT.Rows[0][convCMClass.CmClassId].ToString().Trim(); //类Id(字段类型:char,字段长度:8,是否可空:False)
 objvCMClassEN.ApplicationTypeId = TransNullToInt(objDT.Rows[0][convCMClass.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objvCMClassEN.ApplicationTypeName = objDT.Rows[0][convCMClass.ApplicationTypeName].ToString().Trim(); //应用程序类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCMClassEN.ApplicationTypeSimName = objDT.Rows[0][convCMClass.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvCMClassEN.ProgLangTypeId = objDT.Rows[0][convCMClass.ProgLangTypeId].ToString().Trim(); //编程语言类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvCMClassEN.ProgLangTypeName = objDT.Rows[0][convCMClass.ProgLangTypeName].ToString().Trim(); //编程语言类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvCMClassEN.ProgLangTypeSimName = objDT.Rows[0][convCMClass.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvCMClassEN.TabName = objDT.Rows[0][convCMClass.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvCMClassEN.NameSpace = objDT.Rows[0][convCMClass.NameSpace].ToString().Trim(); //域名(字段类型:varchar,字段长度:50,是否可空:True)
 objvCMClassEN.ProjectPath = objDT.Rows[0][convCMClass.ProjectPath].ToString().Trim(); //工程路径(字段类型:varchar,字段长度:500,是否可空:False)
 objvCMClassEN.FilePath = objDT.Rows[0][convCMClass.FilePath].ToString().Trim(); //文件路径(字段类型:varchar,字段长度:500,是否可空:False)
 objvCMClassEN.FileName = objDT.Rows[0][convCMClass.FileName].ToString().Trim(); //文件名(字段类型:varchar,字段长度:150,是否可空:False)
 objvCMClassEN.FileText = objDT.Rows[0][convCMClass.FileText].ToString().Trim(); //文件内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvCMClassEN.FuncModuleAgcId = objDT.Rows[0][convCMClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvCMClassEN.FuncModuleName = objDT.Rows[0][convCMClass.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCMClassEN.FuncModuleNameSim = objDT.Rows[0][convCMClass.FuncModuleNameSim].ToString().Trim(); //功能模块简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvCMClassEN.CodeTypeId = objDT.Rows[0][convCMClass.CodeTypeId].ToString().Trim(); //代码类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvCMClassEN.CodeTypeName = objDT.Rows[0][convCMClass.CodeTypeName].ToString().Trim(); //代码类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvCMClassEN.CodeTypeSimName = objDT.Rows[0][convCMClass.CodeTypeSimName].ToString().Trim(); //简称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCMClassEN.UserId = objDT.Rows[0][convCMClass.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objvCMClassEN.PrjId = objDT.Rows[0][convCMClass.PrjId].ToString().Trim(); //工程ID(字段类型:char,字段长度:4,是否可空:False)
 objvCMClassEN.PrjName = objDT.Rows[0][convCMClass.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCMClassEN.IsOpen = TransNullToBool(objDT.Rows[0][convCMClass.IsOpen].ToString().Trim()); //是否开放(字段类型:bit,字段长度:1,是否可空:True)
 objvCMClassEN.UpdDate = objDT.Rows[0][convCMClass.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCMClassEN.UpdUser = objDT.Rows[0][convCMClass.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvCMClassEN.Memo = objDT.Rows[0][convCMClass.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCMClassEN.FuncNum = TransNullToInt(objDT.Rows[0][convCMClass.FuncNum].ToString().Trim()); //函数个数(字段类型:int,字段长度:4,是否可空:True)
 objvCMClassEN.ClsName = objDT.Rows[0][convCMClass.ClsName].ToString().Trim(); //类名(字段类型:varchar,字段长度:100,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvCMClassDA: GetvCMClass)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCmClassId">表关键字</param>
 /// <returns>表对象</returns>
public clsvCMClassEN GetObjByCmClassId(string strCmClassId)
{
CheckPrimaryKey(strCmClassId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMClassDA.GetSpecSQLObj();
strSQL = "Select * from vCMClass where CmClassId = " + "'"+ strCmClassId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvCMClassEN objvCMClassEN = new clsvCMClassEN();
try
{
 objvCMClassEN.CmClassId = objRow[convCMClass.CmClassId].ToString().Trim(); //类Id(字段类型:char,字段长度:8,是否可空:False)
 objvCMClassEN.ApplicationTypeId = Int32.Parse(objRow[convCMClass.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objvCMClassEN.ApplicationTypeName = objRow[convCMClass.ApplicationTypeName] == DBNull.Value ? null : objRow[convCMClass.ApplicationTypeName].ToString().Trim(); //应用程序类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCMClassEN.ApplicationTypeSimName = objRow[convCMClass.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMClass.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvCMClassEN.ProgLangTypeId = objRow[convCMClass.ProgLangTypeId].ToString().Trim(); //编程语言类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvCMClassEN.ProgLangTypeName = objRow[convCMClass.ProgLangTypeName].ToString().Trim(); //编程语言类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvCMClassEN.ProgLangTypeSimName = objRow[convCMClass.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCMClass.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvCMClassEN.TabName = objRow[convCMClass.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvCMClassEN.NameSpace = objRow[convCMClass.NameSpace] == DBNull.Value ? null : objRow[convCMClass.NameSpace].ToString().Trim(); //域名(字段类型:varchar,字段长度:50,是否可空:True)
 objvCMClassEN.ProjectPath = objRow[convCMClass.ProjectPath].ToString().Trim(); //工程路径(字段类型:varchar,字段长度:500,是否可空:False)
 objvCMClassEN.FilePath = objRow[convCMClass.FilePath].ToString().Trim(); //文件路径(字段类型:varchar,字段长度:500,是否可空:False)
 objvCMClassEN.FileName = objRow[convCMClass.FileName].ToString().Trim(); //文件名(字段类型:varchar,字段长度:150,是否可空:False)
 objvCMClassEN.FileText = objRow[convCMClass.FileText] == DBNull.Value ? null : objRow[convCMClass.FileText].ToString().Trim(); //文件内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvCMClassEN.FuncModuleAgcId = objRow[convCMClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvCMClassEN.FuncModuleName = objRow[convCMClass.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCMClassEN.FuncModuleNameSim = objRow[convCMClass.FuncModuleNameSim] == DBNull.Value ? null : objRow[convCMClass.FuncModuleNameSim].ToString().Trim(); //功能模块简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvCMClassEN.CodeTypeId = objRow[convCMClass.CodeTypeId].ToString().Trim(); //代码类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvCMClassEN.CodeTypeName = objRow[convCMClass.CodeTypeName].ToString().Trim(); //代码类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvCMClassEN.CodeTypeSimName = objRow[convCMClass.CodeTypeSimName].ToString().Trim(); //简称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCMClassEN.UserId = objRow[convCMClass.UserId] == DBNull.Value ? null : objRow[convCMClass.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objvCMClassEN.PrjId = objRow[convCMClass.PrjId].ToString().Trim(); //工程ID(字段类型:char,字段长度:4,是否可空:False)
 objvCMClassEN.PrjName = objRow[convCMClass.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCMClassEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convCMClass.IsOpen].ToString().Trim()); //是否开放(字段类型:bit,字段长度:1,是否可空:True)
 objvCMClassEN.UpdDate = objRow[convCMClass.UpdDate] == DBNull.Value ? null : objRow[convCMClass.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCMClassEN.UpdUser = objRow[convCMClass.UpdUser] == DBNull.Value ? null : objRow[convCMClass.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvCMClassEN.Memo = objRow[convCMClass.Memo] == DBNull.Value ? null : objRow[convCMClass.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCMClassEN.FuncNum = objRow[convCMClass.FuncNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMClass.FuncNum].ToString().Trim()); //函数个数(字段类型:int,字段长度:4,是否可空:True)
 objvCMClassEN.ClsName = objRow[convCMClass.ClsName].ToString().Trim(); //类名(字段类型:varchar,字段长度:100,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvCMClassDA: GetObjByCmClassId)", objException.Message));
}
return objvCMClassEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvCMClassEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvCMClassDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMClassDA.GetSpecSQLObj();
strSQL = "Select * from vCMClass where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvCMClassEN objvCMClassEN = new clsvCMClassEN()
{
CmClassId = objRow[convCMClass.CmClassId].ToString().Trim(), //类Id
ApplicationTypeId = TransNullToInt(objRow[convCMClass.ApplicationTypeId].ToString().Trim()), //应用程序类型ID
ApplicationTypeName = objRow[convCMClass.ApplicationTypeName] == DBNull.Value ? null : objRow[convCMClass.ApplicationTypeName].ToString().Trim(), //应用程序类型名称
ApplicationTypeSimName = objRow[convCMClass.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMClass.ApplicationTypeSimName].ToString().Trim(), //应用程序类型简称
ProgLangTypeId = objRow[convCMClass.ProgLangTypeId].ToString().Trim(), //编程语言类型Id
ProgLangTypeName = objRow[convCMClass.ProgLangTypeName].ToString().Trim(), //编程语言类型名
ProgLangTypeSimName = objRow[convCMClass.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCMClass.ProgLangTypeSimName].ToString().Trim(), //编程语言类型简称
TabName = objRow[convCMClass.TabName].ToString().Trim(), //表名
NameSpace = objRow[convCMClass.NameSpace] == DBNull.Value ? null : objRow[convCMClass.NameSpace].ToString().Trim(), //域名
ProjectPath = objRow[convCMClass.ProjectPath].ToString().Trim(), //工程路径
FilePath = objRow[convCMClass.FilePath].ToString().Trim(), //文件路径
FileName = objRow[convCMClass.FileName].ToString().Trim(), //文件名
FileText = objRow[convCMClass.FileText] == DBNull.Value ? null : objRow[convCMClass.FileText].ToString().Trim(), //文件内容
FuncModuleAgcId = objRow[convCMClass.FuncModuleAgcId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convCMClass.FuncModuleName].ToString().Trim(), //功能模块名称
FuncModuleNameSim = objRow[convCMClass.FuncModuleNameSim] == DBNull.Value ? null : objRow[convCMClass.FuncModuleNameSim].ToString().Trim(), //功能模块简称
CodeTypeId = objRow[convCMClass.CodeTypeId].ToString().Trim(), //代码类型Id
CodeTypeName = objRow[convCMClass.CodeTypeName].ToString().Trim(), //代码类型名
CodeTypeSimName = objRow[convCMClass.CodeTypeSimName].ToString().Trim(), //简称
UserId = objRow[convCMClass.UserId] == DBNull.Value ? null : objRow[convCMClass.UserId].ToString().Trim(), //用户Id
PrjId = objRow[convCMClass.PrjId].ToString().Trim(), //工程ID
PrjName = objRow[convCMClass.PrjName].ToString().Trim(), //工程名称
IsOpen = TransNullToBool(objRow[convCMClass.IsOpen].ToString().Trim()), //是否开放
UpdDate = objRow[convCMClass.UpdDate] == DBNull.Value ? null : objRow[convCMClass.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convCMClass.UpdUser] == DBNull.Value ? null : objRow[convCMClass.UpdUser].ToString().Trim(), //修改者
Memo = objRow[convCMClass.Memo] == DBNull.Value ? null : objRow[convCMClass.Memo].ToString().Trim(), //说明
FuncNum = objRow[convCMClass.FuncNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCMClass.FuncNum].ToString().Trim()), //函数个数
ClsName = objRow[convCMClass.ClsName].ToString().Trim() //类名
};
objvCMClassEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCMClassEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvCMClassDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvCMClassEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCMClassEN objvCMClassEN = new clsvCMClassEN();
try
{
objvCMClassEN.CmClassId = objRow[convCMClass.CmClassId].ToString().Trim(); //类Id
objvCMClassEN.ApplicationTypeId = TransNullToInt(objRow[convCMClass.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMClassEN.ApplicationTypeName = objRow[convCMClass.ApplicationTypeName] == DBNull.Value ? null : objRow[convCMClass.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvCMClassEN.ApplicationTypeSimName = objRow[convCMClass.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMClass.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMClassEN.ProgLangTypeId = objRow[convCMClass.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCMClassEN.ProgLangTypeName = objRow[convCMClass.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvCMClassEN.ProgLangTypeSimName = objRow[convCMClass.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCMClass.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvCMClassEN.TabName = objRow[convCMClass.TabName].ToString().Trim(); //表名
objvCMClassEN.NameSpace = objRow[convCMClass.NameSpace] == DBNull.Value ? null : objRow[convCMClass.NameSpace].ToString().Trim(); //域名
objvCMClassEN.ProjectPath = objRow[convCMClass.ProjectPath].ToString().Trim(); //工程路径
objvCMClassEN.FilePath = objRow[convCMClass.FilePath].ToString().Trim(); //文件路径
objvCMClassEN.FileName = objRow[convCMClass.FileName].ToString().Trim(); //文件名
objvCMClassEN.FileText = objRow[convCMClass.FileText] == DBNull.Value ? null : objRow[convCMClass.FileText].ToString().Trim(); //文件内容
objvCMClassEN.FuncModuleAgcId = objRow[convCMClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMClassEN.FuncModuleName = objRow[convCMClass.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMClassEN.FuncModuleNameSim = objRow[convCMClass.FuncModuleNameSim] == DBNull.Value ? null : objRow[convCMClass.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvCMClassEN.CodeTypeId = objRow[convCMClass.CodeTypeId].ToString().Trim(); //代码类型Id
objvCMClassEN.CodeTypeName = objRow[convCMClass.CodeTypeName].ToString().Trim(); //代码类型名
objvCMClassEN.CodeTypeSimName = objRow[convCMClass.CodeTypeSimName].ToString().Trim(); //简称
objvCMClassEN.UserId = objRow[convCMClass.UserId] == DBNull.Value ? null : objRow[convCMClass.UserId].ToString().Trim(); //用户Id
objvCMClassEN.PrjId = objRow[convCMClass.PrjId].ToString().Trim(); //工程ID
objvCMClassEN.PrjName = objRow[convCMClass.PrjName].ToString().Trim(); //工程名称
objvCMClassEN.IsOpen = TransNullToBool(objRow[convCMClass.IsOpen].ToString().Trim()); //是否开放
objvCMClassEN.UpdDate = objRow[convCMClass.UpdDate] == DBNull.Value ? null : objRow[convCMClass.UpdDate].ToString().Trim(); //修改日期
objvCMClassEN.UpdUser = objRow[convCMClass.UpdUser] == DBNull.Value ? null : objRow[convCMClass.UpdUser].ToString().Trim(); //修改者
objvCMClassEN.Memo = objRow[convCMClass.Memo] == DBNull.Value ? null : objRow[convCMClass.Memo].ToString().Trim(); //说明
objvCMClassEN.FuncNum = objRow[convCMClass.FuncNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCMClass.FuncNum].ToString().Trim()); //函数个数
objvCMClassEN.ClsName = objRow[convCMClass.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvCMClassDA: GetObjByDataRowvCMClass)", objException.Message));
}
objvCMClassEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCMClassEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvCMClassEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCMClassEN objvCMClassEN = new clsvCMClassEN();
try
{
objvCMClassEN.CmClassId = objRow[convCMClass.CmClassId].ToString().Trim(); //类Id
objvCMClassEN.ApplicationTypeId = TransNullToInt(objRow[convCMClass.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMClassEN.ApplicationTypeName = objRow[convCMClass.ApplicationTypeName] == DBNull.Value ? null : objRow[convCMClass.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvCMClassEN.ApplicationTypeSimName = objRow[convCMClass.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMClass.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMClassEN.ProgLangTypeId = objRow[convCMClass.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCMClassEN.ProgLangTypeName = objRow[convCMClass.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvCMClassEN.ProgLangTypeSimName = objRow[convCMClass.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCMClass.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvCMClassEN.TabName = objRow[convCMClass.TabName].ToString().Trim(); //表名
objvCMClassEN.NameSpace = objRow[convCMClass.NameSpace] == DBNull.Value ? null : objRow[convCMClass.NameSpace].ToString().Trim(); //域名
objvCMClassEN.ProjectPath = objRow[convCMClass.ProjectPath].ToString().Trim(); //工程路径
objvCMClassEN.FilePath = objRow[convCMClass.FilePath].ToString().Trim(); //文件路径
objvCMClassEN.FileName = objRow[convCMClass.FileName].ToString().Trim(); //文件名
objvCMClassEN.FileText = objRow[convCMClass.FileText] == DBNull.Value ? null : objRow[convCMClass.FileText].ToString().Trim(); //文件内容
objvCMClassEN.FuncModuleAgcId = objRow[convCMClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMClassEN.FuncModuleName = objRow[convCMClass.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMClassEN.FuncModuleNameSim = objRow[convCMClass.FuncModuleNameSim] == DBNull.Value ? null : objRow[convCMClass.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvCMClassEN.CodeTypeId = objRow[convCMClass.CodeTypeId].ToString().Trim(); //代码类型Id
objvCMClassEN.CodeTypeName = objRow[convCMClass.CodeTypeName].ToString().Trim(); //代码类型名
objvCMClassEN.CodeTypeSimName = objRow[convCMClass.CodeTypeSimName].ToString().Trim(); //简称
objvCMClassEN.UserId = objRow[convCMClass.UserId] == DBNull.Value ? null : objRow[convCMClass.UserId].ToString().Trim(); //用户Id
objvCMClassEN.PrjId = objRow[convCMClass.PrjId].ToString().Trim(); //工程ID
objvCMClassEN.PrjName = objRow[convCMClass.PrjName].ToString().Trim(); //工程名称
objvCMClassEN.IsOpen = TransNullToBool(objRow[convCMClass.IsOpen].ToString().Trim()); //是否开放
objvCMClassEN.UpdDate = objRow[convCMClass.UpdDate] == DBNull.Value ? null : objRow[convCMClass.UpdDate].ToString().Trim(); //修改日期
objvCMClassEN.UpdUser = objRow[convCMClass.UpdUser] == DBNull.Value ? null : objRow[convCMClass.UpdUser].ToString().Trim(); //修改者
objvCMClassEN.Memo = objRow[convCMClass.Memo] == DBNull.Value ? null : objRow[convCMClass.Memo].ToString().Trim(); //说明
objvCMClassEN.FuncNum = objRow[convCMClass.FuncNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCMClass.FuncNum].ToString().Trim()); //函数个数
objvCMClassEN.ClsName = objRow[convCMClass.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvCMClassDA: GetObjByDataRow)", objException.Message));
}
objvCMClassEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCMClassEN;
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
objSQL = clsvCMClassDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCMClassEN._CurrTabName, convCMClass.CmClassId, 8, "");
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
objSQL = clsvCMClassDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCMClassEN._CurrTabName, convCMClass.CmClassId, 8, strPrefix);
return strMaxValue;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public string GetFirstID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMClassDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select CmClassId from vCMClass where " + strCondition;
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
 objSQL = clsvCMClassDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select CmClassId from vCMClass where " + strCondition;
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
 /// <param name = "strCmClassId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strCmClassId)
{
CheckPrimaryKey(strCmClassId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMClassDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCMClass", "CmClassId = " + "'"+ strCmClassId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvCMClassDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMClassDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCMClass", strCondition))
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
objSQL = clsvCMClassDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vCMClass");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvCMClassENS">源对象</param>
 /// <param name = "objvCMClassENT">目标对象</param>
public void CopyTo(clsvCMClassEN objvCMClassENS, clsvCMClassEN objvCMClassENT)
{
objvCMClassENT.CmClassId = objvCMClassENS.CmClassId; //类Id
objvCMClassENT.ApplicationTypeId = objvCMClassENS.ApplicationTypeId; //应用程序类型ID
objvCMClassENT.ApplicationTypeName = objvCMClassENS.ApplicationTypeName; //应用程序类型名称
objvCMClassENT.ApplicationTypeSimName = objvCMClassENS.ApplicationTypeSimName; //应用程序类型简称
objvCMClassENT.ProgLangTypeId = objvCMClassENS.ProgLangTypeId; //编程语言类型Id
objvCMClassENT.ProgLangTypeName = objvCMClassENS.ProgLangTypeName; //编程语言类型名
objvCMClassENT.ProgLangTypeSimName = objvCMClassENS.ProgLangTypeSimName; //编程语言类型简称
objvCMClassENT.TabName = objvCMClassENS.TabName; //表名
objvCMClassENT.NameSpace = objvCMClassENS.NameSpace; //域名
objvCMClassENT.ProjectPath = objvCMClassENS.ProjectPath; //工程路径
objvCMClassENT.FilePath = objvCMClassENS.FilePath; //文件路径
objvCMClassENT.FileName = objvCMClassENS.FileName; //文件名
objvCMClassENT.FileText = objvCMClassENS.FileText; //文件内容
objvCMClassENT.FuncModuleAgcId = objvCMClassENS.FuncModuleAgcId; //功能模块Id
objvCMClassENT.FuncModuleName = objvCMClassENS.FuncModuleName; //功能模块名称
objvCMClassENT.FuncModuleNameSim = objvCMClassENS.FuncModuleNameSim; //功能模块简称
objvCMClassENT.CodeTypeId = objvCMClassENS.CodeTypeId; //代码类型Id
objvCMClassENT.CodeTypeName = objvCMClassENS.CodeTypeName; //代码类型名
objvCMClassENT.CodeTypeSimName = objvCMClassENS.CodeTypeSimName; //简称
objvCMClassENT.UserId = objvCMClassENS.UserId; //用户Id
objvCMClassENT.PrjId = objvCMClassENS.PrjId; //工程ID
objvCMClassENT.PrjName = objvCMClassENS.PrjName; //工程名称
objvCMClassENT.IsOpen = objvCMClassENS.IsOpen; //是否开放
objvCMClassENT.UpdDate = objvCMClassENS.UpdDate; //修改日期
objvCMClassENT.UpdUser = objvCMClassENS.UpdUser; //修改者
objvCMClassENT.Memo = objvCMClassENS.Memo; //说明
objvCMClassENT.FuncNum = objvCMClassENS.FuncNum; //函数个数
objvCMClassENT.ClsName = objvCMClassENS.ClsName; //类名
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvCMClassEN objvCMClassEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvCMClassEN.CmClassId, 8, convCMClass.CmClassId);
clsCheckSql.CheckFieldLen(objvCMClassEN.ApplicationTypeName, 30, convCMClass.ApplicationTypeName);
clsCheckSql.CheckFieldLen(objvCMClassEN.ApplicationTypeSimName, 30, convCMClass.ApplicationTypeSimName);
clsCheckSql.CheckFieldLen(objvCMClassEN.ProgLangTypeId, 2, convCMClass.ProgLangTypeId);
clsCheckSql.CheckFieldLen(objvCMClassEN.ProgLangTypeName, 30, convCMClass.ProgLangTypeName);
clsCheckSql.CheckFieldLen(objvCMClassEN.ProgLangTypeSimName, 30, convCMClass.ProgLangTypeSimName);
clsCheckSql.CheckFieldLen(objvCMClassEN.TabName, 100, convCMClass.TabName);
clsCheckSql.CheckFieldLen(objvCMClassEN.NameSpace, 50, convCMClass.NameSpace);
clsCheckSql.CheckFieldLen(objvCMClassEN.ProjectPath, 500, convCMClass.ProjectPath);
clsCheckSql.CheckFieldLen(objvCMClassEN.FilePath, 500, convCMClass.FilePath);
clsCheckSql.CheckFieldLen(objvCMClassEN.FileName, 150, convCMClass.FileName);
clsCheckSql.CheckFieldLen(objvCMClassEN.FuncModuleAgcId, 8, convCMClass.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(objvCMClassEN.FuncModuleName, 30, convCMClass.FuncModuleName);
clsCheckSql.CheckFieldLen(objvCMClassEN.FuncModuleNameSim, 30, convCMClass.FuncModuleNameSim);
clsCheckSql.CheckFieldLen(objvCMClassEN.CodeTypeId, 4, convCMClass.CodeTypeId);
clsCheckSql.CheckFieldLen(objvCMClassEN.CodeTypeName, 50, convCMClass.CodeTypeName);
clsCheckSql.CheckFieldLen(objvCMClassEN.CodeTypeSimName, 50, convCMClass.CodeTypeSimName);
clsCheckSql.CheckFieldLen(objvCMClassEN.UserId, 18, convCMClass.UserId);
clsCheckSql.CheckFieldLen(objvCMClassEN.PrjId, 4, convCMClass.PrjId);
clsCheckSql.CheckFieldLen(objvCMClassEN.PrjName, 30, convCMClass.PrjName);
clsCheckSql.CheckFieldLen(objvCMClassEN.UpdDate, 20, convCMClass.UpdDate);
clsCheckSql.CheckFieldLen(objvCMClassEN.UpdUser, 20, convCMClass.UpdUser);
clsCheckSql.CheckFieldLen(objvCMClassEN.Memo, 1000, convCMClass.Memo);
clsCheckSql.CheckFieldLen(objvCMClassEN.ClsName, 100, convCMClass.ClsName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvCMClassEN.CmClassId, convCMClass.CmClassId);
clsCheckSql.CheckSqlInjection4Field(objvCMClassEN.ApplicationTypeName, convCMClass.ApplicationTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCMClassEN.ApplicationTypeSimName, convCMClass.ApplicationTypeSimName);
clsCheckSql.CheckSqlInjection4Field(objvCMClassEN.ProgLangTypeId, convCMClass.ProgLangTypeId);
clsCheckSql.CheckSqlInjection4Field(objvCMClassEN.ProgLangTypeName, convCMClass.ProgLangTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCMClassEN.ProgLangTypeSimName, convCMClass.ProgLangTypeSimName);
clsCheckSql.CheckSqlInjection4Field(objvCMClassEN.TabName, convCMClass.TabName);
clsCheckSql.CheckSqlInjection4Field(objvCMClassEN.NameSpace, convCMClass.NameSpace);
clsCheckSql.CheckSqlInjection4Field(objvCMClassEN.ProjectPath, convCMClass.ProjectPath);
clsCheckSql.CheckSqlInjection4Field(objvCMClassEN.FilePath, convCMClass.FilePath);
clsCheckSql.CheckSqlInjection4Field(objvCMClassEN.FileName, convCMClass.FileName);
clsCheckSql.CheckSqlInjection4Field(objvCMClassEN.FuncModuleAgcId, convCMClass.FuncModuleAgcId);
clsCheckSql.CheckSqlInjection4Field(objvCMClassEN.FuncModuleName, convCMClass.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvCMClassEN.FuncModuleNameSim, convCMClass.FuncModuleNameSim);
clsCheckSql.CheckSqlInjection4Field(objvCMClassEN.CodeTypeId, convCMClass.CodeTypeId);
clsCheckSql.CheckSqlInjection4Field(objvCMClassEN.CodeTypeName, convCMClass.CodeTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCMClassEN.CodeTypeSimName, convCMClass.CodeTypeSimName);
clsCheckSql.CheckSqlInjection4Field(objvCMClassEN.UserId, convCMClass.UserId);
clsCheckSql.CheckSqlInjection4Field(objvCMClassEN.PrjId, convCMClass.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvCMClassEN.PrjName, convCMClass.PrjName);
clsCheckSql.CheckSqlInjection4Field(objvCMClassEN.UpdDate, convCMClass.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvCMClassEN.UpdUser, convCMClass.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvCMClassEN.Memo, convCMClass.Memo);
clsCheckSql.CheckSqlInjection4Field(objvCMClassEN.ClsName, convCMClass.ClsName);
//检查外键字段长度
 objvCMClassEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetCmClassId()
{
//获取某学院所有专业信息
string strSQL = "select CmClassId, UserId from vCMClass ";
 clsSpecSQLforSql mySql = clsvCMClassDA.GetSpecSQLObj();
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
 objSQL = clsvCMClassDA.GetSpecSQLObj();
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
 objSQL = clsvCMClassDA.GetSpecSQLObj();
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
 objSQL = clsvCMClassDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCMClassEN._CurrTabName);
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
 objSQL = clsvCMClassDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCMClassEN._CurrTabName, strCondition);
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
 objSQL = clsvCMClassDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}