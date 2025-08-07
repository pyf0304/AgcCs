
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCMFunctionKeyWordDA
 表名:vCMFunctionKeyWord(00050516)
 * 版本:2024.01.24.1(服务器:WIN-SRV103-116)
 日期:2024/01/26 16:18:25
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
 /// vCM函数关键字(vCMFunctionKeyWord)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvCMFunctionKeyWordDA : clsCommBase4DA
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
 return clsvCMFunctionKeyWordEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvCMFunctionKeyWordEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCMFunctionKeyWordEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvCMFunctionKeyWordEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvCMFunctionKeyWordEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvCMFunctionKeyWordDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFunctionKeyWordDA.GetSpecSQLObj();
strSQL = "Select * from vCMFunctionKeyWord where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vCMFunctionKeyWord(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvCMFunctionKeyWordDA: GetDataTable_vCMFunctionKeyWord)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFunctionKeyWordDA.GetSpecSQLObj();
strSQL = "Select * from vCMFunctionKeyWord where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvCMFunctionKeyWordDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFunctionKeyWordDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvCMFunctionKeyWordDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFunctionKeyWordDA.GetSpecSQLObj();
strSQL = "Select * from vCMFunctionKeyWord where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvCMFunctionKeyWordDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFunctionKeyWordDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvCMFunctionKeyWordDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFunctionKeyWordDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCMFunctionKeyWord where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCMFunctionKeyWord where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvCMFunctionKeyWordDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFunctionKeyWordDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vCMFunctionKeyWord where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvCMFunctionKeyWordDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFunctionKeyWordDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCMFunctionKeyWord.* from vCMFunctionKeyWord Left Join {1} on {2} where {3} and vCMFunctionKeyWord.mId not in (Select top {5} vCMFunctionKeyWord.mId from vCMFunctionKeyWord Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCMFunctionKeyWord where {1} and mId not in (Select top {2} mId from vCMFunctionKeyWord where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCMFunctionKeyWord where {1} and mId not in (Select top {3} mId from vCMFunctionKeyWord where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvCMFunctionKeyWordDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFunctionKeyWordDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCMFunctionKeyWord.* from vCMFunctionKeyWord Left Join {1} on {2} where {3} and vCMFunctionKeyWord.mId not in (Select top {5} vCMFunctionKeyWord.mId from vCMFunctionKeyWord Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCMFunctionKeyWord where {1} and mId not in (Select top {2} mId from vCMFunctionKeyWord where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCMFunctionKeyWord where {1} and mId not in (Select top {3} mId from vCMFunctionKeyWord where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvCMFunctionKeyWordEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvCMFunctionKeyWordDA:GetObjLst)", objException.Message));
}
List<clsvCMFunctionKeyWordEN> arrObjLst = new List<clsvCMFunctionKeyWordEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFunctionKeyWordDA.GetSpecSQLObj();
strSQL = "Select * from vCMFunctionKeyWord where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN = new clsvCMFunctionKeyWordEN();
try
{
objvCMFunctionKeyWordEN.mId = TransNullToInt(objRow[convCMFunctionKeyWord.mId].ToString().Trim()); //mId
objvCMFunctionKeyWordEN.CmFunctionId = objRow[convCMFunctionKeyWord.CmFunctionId].ToString().Trim(); //函数Id
objvCMFunctionKeyWordEN.CmClassId = objRow[convCMFunctionKeyWord.CmClassId].ToString().Trim(); //类Id
objvCMFunctionKeyWordEN.ApplicationTypeId = TransNullToInt(objRow[convCMFunctionKeyWord.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMFunctionKeyWordEN.ProgLangTypeId = objRow[convCMFunctionKeyWord.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCMFunctionKeyWordEN.ProgLangTypeName = objRow[convCMFunctionKeyWord.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvCMFunctionKeyWordEN.ProgLangTypeSimName = objRow[convCMFunctionKeyWord.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvCMFunctionKeyWordEN.NameSpace = objRow[convCMFunctionKeyWord.NameSpace] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.NameSpace].ToString().Trim(); //域名
objvCMFunctionKeyWordEN.ProjectPath = objRow[convCMFunctionKeyWord.ProjectPath].ToString().Trim(); //工程路径
objvCMFunctionKeyWordEN.FilePath = objRow[convCMFunctionKeyWord.FilePath].ToString().Trim(); //文件路径
objvCMFunctionKeyWordEN.FileName = objRow[convCMFunctionKeyWord.FileName].ToString().Trim(); //文件名
objvCMFunctionKeyWordEN.CodeTypeId = objRow[convCMFunctionKeyWord.CodeTypeId].ToString().Trim(); //代码类型Id
objvCMFunctionKeyWordEN.UserId = objRow[convCMFunctionKeyWord.UserId] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.UserId].ToString().Trim(); //用户Id
objvCMFunctionKeyWordEN.PrjId = objRow[convCMFunctionKeyWord.PrjId].ToString().Trim(); //工程ID
objvCMFunctionKeyWordEN.PrjName = objRow[convCMFunctionKeyWord.PrjName].ToString().Trim(); //工程名称
objvCMFunctionKeyWordEN.FunctionName = objRow[convCMFunctionKeyWord.FunctionName] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FunctionName].ToString().Trim(); //功能名称
objvCMFunctionKeyWordEN.FuncContent = objRow[convCMFunctionKeyWord.FuncContent] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FuncContent].ToString().Trim(); //函数内容
objvCMFunctionKeyWordEN.FuncParaLst = objRow[convCMFunctionKeyWord.FuncParaLst] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FuncParaLst].ToString().Trim(); //函数参数列表
objvCMFunctionKeyWordEN.FuncComments = objRow[convCMFunctionKeyWord.FuncComments] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FuncComments].ToString().Trim(); //函数注释
objvCMFunctionKeyWordEN.FunctionSignature = objRow[convCMFunctionKeyWord.FunctionSignature].ToString().Trim(); //函数签名
objvCMFunctionKeyWordEN.Keyword = objRow[convCMFunctionKeyWord.Keyword] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.Keyword].ToString().Trim(); //关键字
objvCMFunctionKeyWordEN.UpdDate = objRow[convCMFunctionKeyWord.UpdDate] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.UpdDate].ToString().Trim(); //修改日期
objvCMFunctionKeyWordEN.UpdUser = objRow[convCMFunctionKeyWord.UpdUser] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.UpdUser].ToString().Trim(); //修改者
objvCMFunctionKeyWordEN.Memo = objRow[convCMFunctionKeyWord.Memo] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.Memo].ToString().Trim(); //说明
objvCMFunctionKeyWordEN.ClsName = objRow[convCMFunctionKeyWord.ClsName] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCMFunctionKeyWordDA: GetObjLst)", objException.Message));
}
objvCMFunctionKeyWordEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCMFunctionKeyWordEN);
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
public List<clsvCMFunctionKeyWordEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvCMFunctionKeyWordDA:GetObjLstByTabName)", objException.Message));
}
List<clsvCMFunctionKeyWordEN> arrObjLst = new List<clsvCMFunctionKeyWordEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFunctionKeyWordDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN = new clsvCMFunctionKeyWordEN();
try
{
objvCMFunctionKeyWordEN.mId = TransNullToInt(objRow[convCMFunctionKeyWord.mId].ToString().Trim()); //mId
objvCMFunctionKeyWordEN.CmFunctionId = objRow[convCMFunctionKeyWord.CmFunctionId].ToString().Trim(); //函数Id
objvCMFunctionKeyWordEN.CmClassId = objRow[convCMFunctionKeyWord.CmClassId].ToString().Trim(); //类Id
objvCMFunctionKeyWordEN.ApplicationTypeId = TransNullToInt(objRow[convCMFunctionKeyWord.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMFunctionKeyWordEN.ProgLangTypeId = objRow[convCMFunctionKeyWord.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCMFunctionKeyWordEN.ProgLangTypeName = objRow[convCMFunctionKeyWord.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvCMFunctionKeyWordEN.ProgLangTypeSimName = objRow[convCMFunctionKeyWord.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvCMFunctionKeyWordEN.NameSpace = objRow[convCMFunctionKeyWord.NameSpace] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.NameSpace].ToString().Trim(); //域名
objvCMFunctionKeyWordEN.ProjectPath = objRow[convCMFunctionKeyWord.ProjectPath].ToString().Trim(); //工程路径
objvCMFunctionKeyWordEN.FilePath = objRow[convCMFunctionKeyWord.FilePath].ToString().Trim(); //文件路径
objvCMFunctionKeyWordEN.FileName = objRow[convCMFunctionKeyWord.FileName].ToString().Trim(); //文件名
objvCMFunctionKeyWordEN.CodeTypeId = objRow[convCMFunctionKeyWord.CodeTypeId].ToString().Trim(); //代码类型Id
objvCMFunctionKeyWordEN.UserId = objRow[convCMFunctionKeyWord.UserId] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.UserId].ToString().Trim(); //用户Id
objvCMFunctionKeyWordEN.PrjId = objRow[convCMFunctionKeyWord.PrjId].ToString().Trim(); //工程ID
objvCMFunctionKeyWordEN.PrjName = objRow[convCMFunctionKeyWord.PrjName].ToString().Trim(); //工程名称
objvCMFunctionKeyWordEN.FunctionName = objRow[convCMFunctionKeyWord.FunctionName] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FunctionName].ToString().Trim(); //功能名称
objvCMFunctionKeyWordEN.FuncContent = objRow[convCMFunctionKeyWord.FuncContent] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FuncContent].ToString().Trim(); //函数内容
objvCMFunctionKeyWordEN.FuncParaLst = objRow[convCMFunctionKeyWord.FuncParaLst] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FuncParaLst].ToString().Trim(); //函数参数列表
objvCMFunctionKeyWordEN.FuncComments = objRow[convCMFunctionKeyWord.FuncComments] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FuncComments].ToString().Trim(); //函数注释
objvCMFunctionKeyWordEN.FunctionSignature = objRow[convCMFunctionKeyWord.FunctionSignature].ToString().Trim(); //函数签名
objvCMFunctionKeyWordEN.Keyword = objRow[convCMFunctionKeyWord.Keyword] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.Keyword].ToString().Trim(); //关键字
objvCMFunctionKeyWordEN.UpdDate = objRow[convCMFunctionKeyWord.UpdDate] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.UpdDate].ToString().Trim(); //修改日期
objvCMFunctionKeyWordEN.UpdUser = objRow[convCMFunctionKeyWord.UpdUser] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.UpdUser].ToString().Trim(); //修改者
objvCMFunctionKeyWordEN.Memo = objRow[convCMFunctionKeyWord.Memo] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.Memo].ToString().Trim(); //说明
objvCMFunctionKeyWordEN.ClsName = objRow[convCMFunctionKeyWord.ClsName] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCMFunctionKeyWordDA: GetObjLst)", objException.Message));
}
objvCMFunctionKeyWordEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCMFunctionKeyWordEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvCMFunctionKeyWordEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvCMFunctionKeyWord(ref clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFunctionKeyWordDA.GetSpecSQLObj();
strSQL = "Select * from vCMFunctionKeyWord where mId = " + ""+ objvCMFunctionKeyWordEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvCMFunctionKeyWordEN.mId = TransNullToInt(objDT.Rows[0][convCMFunctionKeyWord.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvCMFunctionKeyWordEN.CmFunctionId = objDT.Rows[0][convCMFunctionKeyWord.CmFunctionId].ToString().Trim(); //函数Id(字段类型:char,字段长度:8,是否可空:False)
 objvCMFunctionKeyWordEN.CmClassId = objDT.Rows[0][convCMFunctionKeyWord.CmClassId].ToString().Trim(); //类Id(字段类型:char,字段长度:8,是否可空:False)
 objvCMFunctionKeyWordEN.ApplicationTypeId = TransNullToInt(objDT.Rows[0][convCMFunctionKeyWord.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objvCMFunctionKeyWordEN.ProgLangTypeId = objDT.Rows[0][convCMFunctionKeyWord.ProgLangTypeId].ToString().Trim(); //编程语言类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvCMFunctionKeyWordEN.ProgLangTypeName = objDT.Rows[0][convCMFunctionKeyWord.ProgLangTypeName].ToString().Trim(); //编程语言类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvCMFunctionKeyWordEN.ProgLangTypeSimName = objDT.Rows[0][convCMFunctionKeyWord.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvCMFunctionKeyWordEN.NameSpace = objDT.Rows[0][convCMFunctionKeyWord.NameSpace].ToString().Trim(); //域名(字段类型:varchar,字段长度:50,是否可空:True)
 objvCMFunctionKeyWordEN.ProjectPath = objDT.Rows[0][convCMFunctionKeyWord.ProjectPath].ToString().Trim(); //工程路径(字段类型:varchar,字段长度:500,是否可空:False)
 objvCMFunctionKeyWordEN.FilePath = objDT.Rows[0][convCMFunctionKeyWord.FilePath].ToString().Trim(); //文件路径(字段类型:varchar,字段长度:500,是否可空:False)
 objvCMFunctionKeyWordEN.FileName = objDT.Rows[0][convCMFunctionKeyWord.FileName].ToString().Trim(); //文件名(字段类型:varchar,字段长度:150,是否可空:False)
 objvCMFunctionKeyWordEN.CodeTypeId = objDT.Rows[0][convCMFunctionKeyWord.CodeTypeId].ToString().Trim(); //代码类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvCMFunctionKeyWordEN.UserId = objDT.Rows[0][convCMFunctionKeyWord.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objvCMFunctionKeyWordEN.PrjId = objDT.Rows[0][convCMFunctionKeyWord.PrjId].ToString().Trim(); //工程ID(字段类型:char,字段长度:4,是否可空:False)
 objvCMFunctionKeyWordEN.PrjName = objDT.Rows[0][convCMFunctionKeyWord.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCMFunctionKeyWordEN.FunctionName = objDT.Rows[0][convCMFunctionKeyWord.FunctionName].ToString().Trim(); //功能名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvCMFunctionKeyWordEN.FuncContent = objDT.Rows[0][convCMFunctionKeyWord.FuncContent].ToString().Trim(); //函数内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvCMFunctionKeyWordEN.FuncParaLst = objDT.Rows[0][convCMFunctionKeyWord.FuncParaLst].ToString().Trim(); //函数参数列表(字段类型:varchar,字段长度:500,是否可空:True)
 objvCMFunctionKeyWordEN.FuncComments = objDT.Rows[0][convCMFunctionKeyWord.FuncComments].ToString().Trim(); //函数注释(字段类型:text,字段长度:5000,是否可空:True)
 objvCMFunctionKeyWordEN.FunctionSignature = objDT.Rows[0][convCMFunctionKeyWord.FunctionSignature].ToString().Trim(); //函数签名(字段类型:varchar,字段长度:500,是否可空:False)
 objvCMFunctionKeyWordEN.Keyword = objDT.Rows[0][convCMFunctionKeyWord.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:50,是否可空:True)
 objvCMFunctionKeyWordEN.UpdDate = objDT.Rows[0][convCMFunctionKeyWord.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCMFunctionKeyWordEN.UpdUser = objDT.Rows[0][convCMFunctionKeyWord.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvCMFunctionKeyWordEN.Memo = objDT.Rows[0][convCMFunctionKeyWord.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCMFunctionKeyWordEN.ClsName = objDT.Rows[0][convCMFunctionKeyWord.ClsName].ToString().Trim(); //类名(字段类型:varchar,字段长度:100,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvCMFunctionKeyWordDA: GetvCMFunctionKeyWord)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvCMFunctionKeyWordEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFunctionKeyWordDA.GetSpecSQLObj();
strSQL = "Select * from vCMFunctionKeyWord where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN = new clsvCMFunctionKeyWordEN();
try
{
 objvCMFunctionKeyWordEN.mId = Int32.Parse(objRow[convCMFunctionKeyWord.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvCMFunctionKeyWordEN.CmFunctionId = objRow[convCMFunctionKeyWord.CmFunctionId].ToString().Trim(); //函数Id(字段类型:char,字段长度:8,是否可空:False)
 objvCMFunctionKeyWordEN.CmClassId = objRow[convCMFunctionKeyWord.CmClassId].ToString().Trim(); //类Id(字段类型:char,字段长度:8,是否可空:False)
 objvCMFunctionKeyWordEN.ApplicationTypeId = Int32.Parse(objRow[convCMFunctionKeyWord.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objvCMFunctionKeyWordEN.ProgLangTypeId = objRow[convCMFunctionKeyWord.ProgLangTypeId].ToString().Trim(); //编程语言类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvCMFunctionKeyWordEN.ProgLangTypeName = objRow[convCMFunctionKeyWord.ProgLangTypeName].ToString().Trim(); //编程语言类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvCMFunctionKeyWordEN.ProgLangTypeSimName = objRow[convCMFunctionKeyWord.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvCMFunctionKeyWordEN.NameSpace = objRow[convCMFunctionKeyWord.NameSpace] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.NameSpace].ToString().Trim(); //域名(字段类型:varchar,字段长度:50,是否可空:True)
 objvCMFunctionKeyWordEN.ProjectPath = objRow[convCMFunctionKeyWord.ProjectPath].ToString().Trim(); //工程路径(字段类型:varchar,字段长度:500,是否可空:False)
 objvCMFunctionKeyWordEN.FilePath = objRow[convCMFunctionKeyWord.FilePath].ToString().Trim(); //文件路径(字段类型:varchar,字段长度:500,是否可空:False)
 objvCMFunctionKeyWordEN.FileName = objRow[convCMFunctionKeyWord.FileName].ToString().Trim(); //文件名(字段类型:varchar,字段长度:150,是否可空:False)
 objvCMFunctionKeyWordEN.CodeTypeId = objRow[convCMFunctionKeyWord.CodeTypeId].ToString().Trim(); //代码类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvCMFunctionKeyWordEN.UserId = objRow[convCMFunctionKeyWord.UserId] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objvCMFunctionKeyWordEN.PrjId = objRow[convCMFunctionKeyWord.PrjId].ToString().Trim(); //工程ID(字段类型:char,字段长度:4,是否可空:False)
 objvCMFunctionKeyWordEN.PrjName = objRow[convCMFunctionKeyWord.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCMFunctionKeyWordEN.FunctionName = objRow[convCMFunctionKeyWord.FunctionName] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FunctionName].ToString().Trim(); //功能名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvCMFunctionKeyWordEN.FuncContent = objRow[convCMFunctionKeyWord.FuncContent] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FuncContent].ToString().Trim(); //函数内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvCMFunctionKeyWordEN.FuncParaLst = objRow[convCMFunctionKeyWord.FuncParaLst] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FuncParaLst].ToString().Trim(); //函数参数列表(字段类型:varchar,字段长度:500,是否可空:True)
 objvCMFunctionKeyWordEN.FuncComments = objRow[convCMFunctionKeyWord.FuncComments] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FuncComments].ToString().Trim(); //函数注释(字段类型:text,字段长度:5000,是否可空:True)
 objvCMFunctionKeyWordEN.FunctionSignature = objRow[convCMFunctionKeyWord.FunctionSignature].ToString().Trim(); //函数签名(字段类型:varchar,字段长度:500,是否可空:False)
 objvCMFunctionKeyWordEN.Keyword = objRow[convCMFunctionKeyWord.Keyword] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:50,是否可空:True)
 objvCMFunctionKeyWordEN.UpdDate = objRow[convCMFunctionKeyWord.UpdDate] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCMFunctionKeyWordEN.UpdUser = objRow[convCMFunctionKeyWord.UpdUser] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvCMFunctionKeyWordEN.Memo = objRow[convCMFunctionKeyWord.Memo] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCMFunctionKeyWordEN.ClsName = objRow[convCMFunctionKeyWord.ClsName] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.ClsName].ToString().Trim(); //类名(字段类型:varchar,字段长度:100,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvCMFunctionKeyWordDA: GetObjBymId)", objException.Message));
}
return objvCMFunctionKeyWordEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvCMFunctionKeyWordEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvCMFunctionKeyWordDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFunctionKeyWordDA.GetSpecSQLObj();
strSQL = "Select * from vCMFunctionKeyWord where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN = new clsvCMFunctionKeyWordEN()
{
mId = TransNullToInt(objRow[convCMFunctionKeyWord.mId].ToString().Trim()), //mId
CmFunctionId = objRow[convCMFunctionKeyWord.CmFunctionId].ToString().Trim(), //函数Id
CmClassId = objRow[convCMFunctionKeyWord.CmClassId].ToString().Trim(), //类Id
ApplicationTypeId = TransNullToInt(objRow[convCMFunctionKeyWord.ApplicationTypeId].ToString().Trim()), //应用程序类型ID
ProgLangTypeId = objRow[convCMFunctionKeyWord.ProgLangTypeId].ToString().Trim(), //编程语言类型Id
ProgLangTypeName = objRow[convCMFunctionKeyWord.ProgLangTypeName].ToString().Trim(), //编程语言类型名
ProgLangTypeSimName = objRow[convCMFunctionKeyWord.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.ProgLangTypeSimName].ToString().Trim(), //编程语言类型简称
NameSpace = objRow[convCMFunctionKeyWord.NameSpace] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.NameSpace].ToString().Trim(), //域名
ProjectPath = objRow[convCMFunctionKeyWord.ProjectPath].ToString().Trim(), //工程路径
FilePath = objRow[convCMFunctionKeyWord.FilePath].ToString().Trim(), //文件路径
FileName = objRow[convCMFunctionKeyWord.FileName].ToString().Trim(), //文件名
CodeTypeId = objRow[convCMFunctionKeyWord.CodeTypeId].ToString().Trim(), //代码类型Id
UserId = objRow[convCMFunctionKeyWord.UserId] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.UserId].ToString().Trim(), //用户Id
PrjId = objRow[convCMFunctionKeyWord.PrjId].ToString().Trim(), //工程ID
PrjName = objRow[convCMFunctionKeyWord.PrjName].ToString().Trim(), //工程名称
FunctionName = objRow[convCMFunctionKeyWord.FunctionName] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FunctionName].ToString().Trim(), //功能名称
FuncContent = objRow[convCMFunctionKeyWord.FuncContent] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FuncContent].ToString().Trim(), //函数内容
FuncParaLst = objRow[convCMFunctionKeyWord.FuncParaLst] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FuncParaLst].ToString().Trim(), //函数参数列表
FuncComments = objRow[convCMFunctionKeyWord.FuncComments] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FuncComments].ToString().Trim(), //函数注释
FunctionSignature = objRow[convCMFunctionKeyWord.FunctionSignature].ToString().Trim(), //函数签名
Keyword = objRow[convCMFunctionKeyWord.Keyword] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.Keyword].ToString().Trim(), //关键字
UpdDate = objRow[convCMFunctionKeyWord.UpdDate] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convCMFunctionKeyWord.UpdUser] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.UpdUser].ToString().Trim(), //修改者
Memo = objRow[convCMFunctionKeyWord.Memo] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.Memo].ToString().Trim(), //说明
ClsName = objRow[convCMFunctionKeyWord.ClsName] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.ClsName].ToString().Trim() //类名
};
objvCMFunctionKeyWordEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCMFunctionKeyWordEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvCMFunctionKeyWordDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvCMFunctionKeyWordEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN = new clsvCMFunctionKeyWordEN();
try
{
objvCMFunctionKeyWordEN.mId = TransNullToInt(objRow[convCMFunctionKeyWord.mId].ToString().Trim()); //mId
objvCMFunctionKeyWordEN.CmFunctionId = objRow[convCMFunctionKeyWord.CmFunctionId].ToString().Trim(); //函数Id
objvCMFunctionKeyWordEN.CmClassId = objRow[convCMFunctionKeyWord.CmClassId].ToString().Trim(); //类Id
objvCMFunctionKeyWordEN.ApplicationTypeId = TransNullToInt(objRow[convCMFunctionKeyWord.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMFunctionKeyWordEN.ProgLangTypeId = objRow[convCMFunctionKeyWord.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCMFunctionKeyWordEN.ProgLangTypeName = objRow[convCMFunctionKeyWord.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvCMFunctionKeyWordEN.ProgLangTypeSimName = objRow[convCMFunctionKeyWord.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvCMFunctionKeyWordEN.NameSpace = objRow[convCMFunctionKeyWord.NameSpace] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.NameSpace].ToString().Trim(); //域名
objvCMFunctionKeyWordEN.ProjectPath = objRow[convCMFunctionKeyWord.ProjectPath].ToString().Trim(); //工程路径
objvCMFunctionKeyWordEN.FilePath = objRow[convCMFunctionKeyWord.FilePath].ToString().Trim(); //文件路径
objvCMFunctionKeyWordEN.FileName = objRow[convCMFunctionKeyWord.FileName].ToString().Trim(); //文件名
objvCMFunctionKeyWordEN.CodeTypeId = objRow[convCMFunctionKeyWord.CodeTypeId].ToString().Trim(); //代码类型Id
objvCMFunctionKeyWordEN.UserId = objRow[convCMFunctionKeyWord.UserId] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.UserId].ToString().Trim(); //用户Id
objvCMFunctionKeyWordEN.PrjId = objRow[convCMFunctionKeyWord.PrjId].ToString().Trim(); //工程ID
objvCMFunctionKeyWordEN.PrjName = objRow[convCMFunctionKeyWord.PrjName].ToString().Trim(); //工程名称
objvCMFunctionKeyWordEN.FunctionName = objRow[convCMFunctionKeyWord.FunctionName] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FunctionName].ToString().Trim(); //功能名称
objvCMFunctionKeyWordEN.FuncContent = objRow[convCMFunctionKeyWord.FuncContent] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FuncContent].ToString().Trim(); //函数内容
objvCMFunctionKeyWordEN.FuncParaLst = objRow[convCMFunctionKeyWord.FuncParaLst] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FuncParaLst].ToString().Trim(); //函数参数列表
objvCMFunctionKeyWordEN.FuncComments = objRow[convCMFunctionKeyWord.FuncComments] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FuncComments].ToString().Trim(); //函数注释
objvCMFunctionKeyWordEN.FunctionSignature = objRow[convCMFunctionKeyWord.FunctionSignature].ToString().Trim(); //函数签名
objvCMFunctionKeyWordEN.Keyword = objRow[convCMFunctionKeyWord.Keyword] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.Keyword].ToString().Trim(); //关键字
objvCMFunctionKeyWordEN.UpdDate = objRow[convCMFunctionKeyWord.UpdDate] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.UpdDate].ToString().Trim(); //修改日期
objvCMFunctionKeyWordEN.UpdUser = objRow[convCMFunctionKeyWord.UpdUser] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.UpdUser].ToString().Trim(); //修改者
objvCMFunctionKeyWordEN.Memo = objRow[convCMFunctionKeyWord.Memo] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.Memo].ToString().Trim(); //说明
objvCMFunctionKeyWordEN.ClsName = objRow[convCMFunctionKeyWord.ClsName] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvCMFunctionKeyWordDA: GetObjByDataRowvCMFunctionKeyWord)", objException.Message));
}
objvCMFunctionKeyWordEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCMFunctionKeyWordEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvCMFunctionKeyWordEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN = new clsvCMFunctionKeyWordEN();
try
{
objvCMFunctionKeyWordEN.mId = TransNullToInt(objRow[convCMFunctionKeyWord.mId].ToString().Trim()); //mId
objvCMFunctionKeyWordEN.CmFunctionId = objRow[convCMFunctionKeyWord.CmFunctionId].ToString().Trim(); //函数Id
objvCMFunctionKeyWordEN.CmClassId = objRow[convCMFunctionKeyWord.CmClassId].ToString().Trim(); //类Id
objvCMFunctionKeyWordEN.ApplicationTypeId = TransNullToInt(objRow[convCMFunctionKeyWord.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMFunctionKeyWordEN.ProgLangTypeId = objRow[convCMFunctionKeyWord.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCMFunctionKeyWordEN.ProgLangTypeName = objRow[convCMFunctionKeyWord.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvCMFunctionKeyWordEN.ProgLangTypeSimName = objRow[convCMFunctionKeyWord.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvCMFunctionKeyWordEN.NameSpace = objRow[convCMFunctionKeyWord.NameSpace] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.NameSpace].ToString().Trim(); //域名
objvCMFunctionKeyWordEN.ProjectPath = objRow[convCMFunctionKeyWord.ProjectPath].ToString().Trim(); //工程路径
objvCMFunctionKeyWordEN.FilePath = objRow[convCMFunctionKeyWord.FilePath].ToString().Trim(); //文件路径
objvCMFunctionKeyWordEN.FileName = objRow[convCMFunctionKeyWord.FileName].ToString().Trim(); //文件名
objvCMFunctionKeyWordEN.CodeTypeId = objRow[convCMFunctionKeyWord.CodeTypeId].ToString().Trim(); //代码类型Id
objvCMFunctionKeyWordEN.UserId = objRow[convCMFunctionKeyWord.UserId] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.UserId].ToString().Trim(); //用户Id
objvCMFunctionKeyWordEN.PrjId = objRow[convCMFunctionKeyWord.PrjId].ToString().Trim(); //工程ID
objvCMFunctionKeyWordEN.PrjName = objRow[convCMFunctionKeyWord.PrjName].ToString().Trim(); //工程名称
objvCMFunctionKeyWordEN.FunctionName = objRow[convCMFunctionKeyWord.FunctionName] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FunctionName].ToString().Trim(); //功能名称
objvCMFunctionKeyWordEN.FuncContent = objRow[convCMFunctionKeyWord.FuncContent] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FuncContent].ToString().Trim(); //函数内容
objvCMFunctionKeyWordEN.FuncParaLst = objRow[convCMFunctionKeyWord.FuncParaLst] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FuncParaLst].ToString().Trim(); //函数参数列表
objvCMFunctionKeyWordEN.FuncComments = objRow[convCMFunctionKeyWord.FuncComments] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FuncComments].ToString().Trim(); //函数注释
objvCMFunctionKeyWordEN.FunctionSignature = objRow[convCMFunctionKeyWord.FunctionSignature].ToString().Trim(); //函数签名
objvCMFunctionKeyWordEN.Keyword = objRow[convCMFunctionKeyWord.Keyword] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.Keyword].ToString().Trim(); //关键字
objvCMFunctionKeyWordEN.UpdDate = objRow[convCMFunctionKeyWord.UpdDate] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.UpdDate].ToString().Trim(); //修改日期
objvCMFunctionKeyWordEN.UpdUser = objRow[convCMFunctionKeyWord.UpdUser] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.UpdUser].ToString().Trim(); //修改者
objvCMFunctionKeyWordEN.Memo = objRow[convCMFunctionKeyWord.Memo] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.Memo].ToString().Trim(); //说明
objvCMFunctionKeyWordEN.ClsName = objRow[convCMFunctionKeyWord.ClsName] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvCMFunctionKeyWordDA: GetObjByDataRow)", objException.Message));
}
objvCMFunctionKeyWordEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCMFunctionKeyWordEN;
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
objSQL = clsvCMFunctionKeyWordDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCMFunctionKeyWordEN._CurrTabName, convCMFunctionKeyWord.mId, 8, "");
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
objSQL = clsvCMFunctionKeyWordDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCMFunctionKeyWordEN._CurrTabName, convCMFunctionKeyWord.mId, 8, strPrefix);
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
 objSQL = clsvCMFunctionKeyWordDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vCMFunctionKeyWord where " + strCondition;
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
 objSQL = clsvCMFunctionKeyWordDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vCMFunctionKeyWord where " + strCondition;
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
 objSQL = clsvCMFunctionKeyWordDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCMFunctionKeyWord", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvCMFunctionKeyWordDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFunctionKeyWordDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCMFunctionKeyWord", strCondition))
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
objSQL = clsvCMFunctionKeyWordDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vCMFunctionKeyWord");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvCMFunctionKeyWordENS">源对象</param>
 /// <param name = "objvCMFunctionKeyWordENT">目标对象</param>
public void CopyTo(clsvCMFunctionKeyWordEN objvCMFunctionKeyWordENS, clsvCMFunctionKeyWordEN objvCMFunctionKeyWordENT)
{
objvCMFunctionKeyWordENT.mId = objvCMFunctionKeyWordENS.mId; //mId
objvCMFunctionKeyWordENT.CmFunctionId = objvCMFunctionKeyWordENS.CmFunctionId; //函数Id
objvCMFunctionKeyWordENT.CmClassId = objvCMFunctionKeyWordENS.CmClassId; //类Id
objvCMFunctionKeyWordENT.ApplicationTypeId = objvCMFunctionKeyWordENS.ApplicationTypeId; //应用程序类型ID
objvCMFunctionKeyWordENT.ProgLangTypeId = objvCMFunctionKeyWordENS.ProgLangTypeId; //编程语言类型Id
objvCMFunctionKeyWordENT.ProgLangTypeName = objvCMFunctionKeyWordENS.ProgLangTypeName; //编程语言类型名
objvCMFunctionKeyWordENT.ProgLangTypeSimName = objvCMFunctionKeyWordENS.ProgLangTypeSimName; //编程语言类型简称
objvCMFunctionKeyWordENT.NameSpace = objvCMFunctionKeyWordENS.NameSpace; //域名
objvCMFunctionKeyWordENT.ProjectPath = objvCMFunctionKeyWordENS.ProjectPath; //工程路径
objvCMFunctionKeyWordENT.FilePath = objvCMFunctionKeyWordENS.FilePath; //文件路径
objvCMFunctionKeyWordENT.FileName = objvCMFunctionKeyWordENS.FileName; //文件名
objvCMFunctionKeyWordENT.CodeTypeId = objvCMFunctionKeyWordENS.CodeTypeId; //代码类型Id
objvCMFunctionKeyWordENT.UserId = objvCMFunctionKeyWordENS.UserId; //用户Id
objvCMFunctionKeyWordENT.PrjId = objvCMFunctionKeyWordENS.PrjId; //工程ID
objvCMFunctionKeyWordENT.PrjName = objvCMFunctionKeyWordENS.PrjName; //工程名称
objvCMFunctionKeyWordENT.FunctionName = objvCMFunctionKeyWordENS.FunctionName; //功能名称
objvCMFunctionKeyWordENT.FuncContent = objvCMFunctionKeyWordENS.FuncContent; //函数内容
objvCMFunctionKeyWordENT.FuncParaLst = objvCMFunctionKeyWordENS.FuncParaLst; //函数参数列表
objvCMFunctionKeyWordENT.FuncComments = objvCMFunctionKeyWordENS.FuncComments; //函数注释
objvCMFunctionKeyWordENT.FunctionSignature = objvCMFunctionKeyWordENS.FunctionSignature; //函数签名
objvCMFunctionKeyWordENT.Keyword = objvCMFunctionKeyWordENS.Keyword; //关键字
objvCMFunctionKeyWordENT.UpdDate = objvCMFunctionKeyWordENS.UpdDate; //修改日期
objvCMFunctionKeyWordENT.UpdUser = objvCMFunctionKeyWordENS.UpdUser; //修改者
objvCMFunctionKeyWordENT.Memo = objvCMFunctionKeyWordENS.Memo; //说明
objvCMFunctionKeyWordENT.ClsName = objvCMFunctionKeyWordENS.ClsName; //类名
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvCMFunctionKeyWordEN.CmFunctionId, 8, convCMFunctionKeyWord.CmFunctionId);
clsCheckSql.CheckFieldLen(objvCMFunctionKeyWordEN.CmClassId, 8, convCMFunctionKeyWord.CmClassId);
clsCheckSql.CheckFieldLen(objvCMFunctionKeyWordEN.ProgLangTypeId, 2, convCMFunctionKeyWord.ProgLangTypeId);
clsCheckSql.CheckFieldLen(objvCMFunctionKeyWordEN.ProgLangTypeName, 30, convCMFunctionKeyWord.ProgLangTypeName);
clsCheckSql.CheckFieldLen(objvCMFunctionKeyWordEN.ProgLangTypeSimName, 30, convCMFunctionKeyWord.ProgLangTypeSimName);
clsCheckSql.CheckFieldLen(objvCMFunctionKeyWordEN.NameSpace, 50, convCMFunctionKeyWord.NameSpace);
clsCheckSql.CheckFieldLen(objvCMFunctionKeyWordEN.ProjectPath, 500, convCMFunctionKeyWord.ProjectPath);
clsCheckSql.CheckFieldLen(objvCMFunctionKeyWordEN.FilePath, 500, convCMFunctionKeyWord.FilePath);
clsCheckSql.CheckFieldLen(objvCMFunctionKeyWordEN.FileName, 150, convCMFunctionKeyWord.FileName);
clsCheckSql.CheckFieldLen(objvCMFunctionKeyWordEN.CodeTypeId, 4, convCMFunctionKeyWord.CodeTypeId);
clsCheckSql.CheckFieldLen(objvCMFunctionKeyWordEN.UserId, 18, convCMFunctionKeyWord.UserId);
clsCheckSql.CheckFieldLen(objvCMFunctionKeyWordEN.PrjId, 4, convCMFunctionKeyWord.PrjId);
clsCheckSql.CheckFieldLen(objvCMFunctionKeyWordEN.PrjName, 30, convCMFunctionKeyWord.PrjName);
clsCheckSql.CheckFieldLen(objvCMFunctionKeyWordEN.FunctionName, 200, convCMFunctionKeyWord.FunctionName);
clsCheckSql.CheckFieldLen(objvCMFunctionKeyWordEN.FuncParaLst, 500, convCMFunctionKeyWord.FuncParaLst);
clsCheckSql.CheckFieldLen(objvCMFunctionKeyWordEN.FunctionSignature, 500, convCMFunctionKeyWord.FunctionSignature);
clsCheckSql.CheckFieldLen(objvCMFunctionKeyWordEN.Keyword, 50, convCMFunctionKeyWord.Keyword);
clsCheckSql.CheckFieldLen(objvCMFunctionKeyWordEN.UpdDate, 20, convCMFunctionKeyWord.UpdDate);
clsCheckSql.CheckFieldLen(objvCMFunctionKeyWordEN.UpdUser, 20, convCMFunctionKeyWord.UpdUser);
clsCheckSql.CheckFieldLen(objvCMFunctionKeyWordEN.Memo, 1000, convCMFunctionKeyWord.Memo);
clsCheckSql.CheckFieldLen(objvCMFunctionKeyWordEN.ClsName, 100, convCMFunctionKeyWord.ClsName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvCMFunctionKeyWordEN.CmFunctionId, convCMFunctionKeyWord.CmFunctionId);
clsCheckSql.CheckSqlInjection4Field(objvCMFunctionKeyWordEN.CmClassId, convCMFunctionKeyWord.CmClassId);
clsCheckSql.CheckSqlInjection4Field(objvCMFunctionKeyWordEN.ProgLangTypeId, convCMFunctionKeyWord.ProgLangTypeId);
clsCheckSql.CheckSqlInjection4Field(objvCMFunctionKeyWordEN.ProgLangTypeName, convCMFunctionKeyWord.ProgLangTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCMFunctionKeyWordEN.ProgLangTypeSimName, convCMFunctionKeyWord.ProgLangTypeSimName);
clsCheckSql.CheckSqlInjection4Field(objvCMFunctionKeyWordEN.NameSpace, convCMFunctionKeyWord.NameSpace);
clsCheckSql.CheckSqlInjection4Field(objvCMFunctionKeyWordEN.ProjectPath, convCMFunctionKeyWord.ProjectPath);
clsCheckSql.CheckSqlInjection4Field(objvCMFunctionKeyWordEN.FilePath, convCMFunctionKeyWord.FilePath);
clsCheckSql.CheckSqlInjection4Field(objvCMFunctionKeyWordEN.FileName, convCMFunctionKeyWord.FileName);
clsCheckSql.CheckSqlInjection4Field(objvCMFunctionKeyWordEN.CodeTypeId, convCMFunctionKeyWord.CodeTypeId);
clsCheckSql.CheckSqlInjection4Field(objvCMFunctionKeyWordEN.UserId, convCMFunctionKeyWord.UserId);
clsCheckSql.CheckSqlInjection4Field(objvCMFunctionKeyWordEN.PrjId, convCMFunctionKeyWord.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvCMFunctionKeyWordEN.PrjName, convCMFunctionKeyWord.PrjName);
clsCheckSql.CheckSqlInjection4Field(objvCMFunctionKeyWordEN.FunctionName, convCMFunctionKeyWord.FunctionName);
clsCheckSql.CheckSqlInjection4Field(objvCMFunctionKeyWordEN.FuncParaLst, convCMFunctionKeyWord.FuncParaLst);
clsCheckSql.CheckSqlInjection4Field(objvCMFunctionKeyWordEN.FunctionSignature, convCMFunctionKeyWord.FunctionSignature);
clsCheckSql.CheckSqlInjection4Field(objvCMFunctionKeyWordEN.Keyword, convCMFunctionKeyWord.Keyword);
clsCheckSql.CheckSqlInjection4Field(objvCMFunctionKeyWordEN.UpdDate, convCMFunctionKeyWord.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvCMFunctionKeyWordEN.UpdUser, convCMFunctionKeyWord.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvCMFunctionKeyWordEN.Memo, convCMFunctionKeyWord.Memo);
clsCheckSql.CheckSqlInjection4Field(objvCMFunctionKeyWordEN.ClsName, convCMFunctionKeyWord.ClsName);
//检查外键字段长度
 objvCMFunctionKeyWordEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetmId()
{
//获取某学院所有专业信息
string strSQL = "select mId, UserId from vCMFunctionKeyWord ";
 clsSpecSQLforSql mySql = clsvCMFunctionKeyWordDA.GetSpecSQLObj();
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
 objSQL = clsvCMFunctionKeyWordDA.GetSpecSQLObj();
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
 objSQL = clsvCMFunctionKeyWordDA.GetSpecSQLObj();
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
 objSQL = clsvCMFunctionKeyWordDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCMFunctionKeyWordEN._CurrTabName);
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
 objSQL = clsvCMFunctionKeyWordDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCMFunctionKeyWordEN._CurrTabName, strCondition);
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
 objSQL = clsvCMFunctionKeyWordDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}