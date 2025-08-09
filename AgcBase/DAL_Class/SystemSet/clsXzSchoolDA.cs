
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsXzSchoolDA
 表名:XzSchool(00050244)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:06:31
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统设置(SystemSet)
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
 /// 学校(XzSchool)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsXzSchoolDA : clsCommBase4DA
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
 return clsXzSchoolEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsXzSchoolEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsXzSchoolEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsXzSchoolEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsXzSchoolEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdSchool">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdSchool)
{
strIdSchool = strIdSchool.Replace("'", "''");
if (strIdSchool.Length > 4)
{
throw new Exception("(errid:Data000001)在表:XzSchool中,检查关键字,长度不正确!(clsXzSchoolDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdSchool)  ==  true)
{
throw new Exception("(errid:Data000002)在表:XzSchool中,关键字不能为空 或 null!(clsXzSchoolDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdSchool);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsXzSchoolDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsXzSchoolDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
strSQL = "Select * from XzSchool where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_XzSchool(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsXzSchoolDA: GetDataTable_XzSchool)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
strSQL = "Select * from XzSchool where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsXzSchoolDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsXzSchoolDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
strSQL = "Select * from XzSchool where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsXzSchoolDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsXzSchoolDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from XzSchool where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from XzSchool where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsXzSchoolDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from XzSchool where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsXzSchoolDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} XzSchool.* " + 
$"from XzSchool " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and XzSchool.IdSchool not in " + 
$"(Select top {intTop_In} XzSchool.IdSchool from XzSchool " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from XzSchool where {1} and IdSchool not in (Select top {2} IdSchool from XzSchool where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from XzSchool where {1} and IdSchool not in (Select top {3} IdSchool from XzSchool where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsXzSchoolDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} XzSchool.* " + 
$"from XzSchool " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and XzSchool.IdSchool not in " + 
$"(Select top {intTop_In} XzSchool.IdSchool from XzSchool " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from XzSchool where {1} and IdSchool not in (Select top {2} IdSchool from XzSchool where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from XzSchool where {1} and IdSchool not in (Select top {3} IdSchool from XzSchool where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsXzSchoolEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsXzSchoolDA:GetObjLst)", objException.Message));
}
List<clsXzSchoolEN> arrObjLst = new List<clsXzSchoolEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
strSQL = "Select * from XzSchool where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzSchoolEN objXzSchoolEN = new clsXzSchoolEN();
try
{
objXzSchoolEN.IdSchool = objRow[conXzSchool.IdSchool].ToString().Trim(); //学校流水号
objXzSchoolEN.SchoolId = objRow[conXzSchool.SchoolId].ToString().Trim(); //学校Id
objXzSchoolEN.SchoolName = objRow[conXzSchool.SchoolName].ToString().Trim(); //学校名称
objXzSchoolEN.IsCurrentUse = TransNullToBool(objRow[conXzSchool.IsCurrentUse].ToString().Trim()); //是否当前使用
objXzSchoolEN.SchoolENName = objRow[conXzSchool.SchoolENName] == DBNull.Value ? null : objRow[conXzSchool.SchoolENName].ToString().Trim(); //学校英文名
objXzSchoolEN.SchoolNameA = objRow[conXzSchool.SchoolNameA] == DBNull.Value ? null : objRow[conXzSchool.SchoolNameA].ToString().Trim(); //学校简称
objXzSchoolEN.SchoolTypeId = objRow[conXzSchool.SchoolTypeId] == DBNull.Value ? null : objRow[conXzSchool.SchoolTypeId].ToString().Trim(); //学校类型Id
objXzSchoolEN.UpdDate = objRow[conXzSchool.UpdDate] == DBNull.Value ? null : objRow[conXzSchool.UpdDate].ToString().Trim(); //修改日期
objXzSchoolEN.UpdUserId = objRow[conXzSchool.UpdUserId] == DBNull.Value ? null : objRow[conXzSchool.UpdUserId].ToString().Trim(); //修改用户Id
objXzSchoolEN.Memo = objRow[conXzSchool.Memo] == DBNull.Value ? null : objRow[conXzSchool.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsXzSchoolDA: GetObjLst)", objException.Message));
}
objXzSchoolEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objXzSchoolEN);
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
public List<clsXzSchoolEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsXzSchoolDA:GetObjLstByTabName)", objException.Message));
}
List<clsXzSchoolEN> arrObjLst = new List<clsXzSchoolEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzSchoolEN objXzSchoolEN = new clsXzSchoolEN();
try
{
objXzSchoolEN.IdSchool = objRow[conXzSchool.IdSchool].ToString().Trim(); //学校流水号
objXzSchoolEN.SchoolId = objRow[conXzSchool.SchoolId].ToString().Trim(); //学校Id
objXzSchoolEN.SchoolName = objRow[conXzSchool.SchoolName].ToString().Trim(); //学校名称
objXzSchoolEN.IsCurrentUse = TransNullToBool(objRow[conXzSchool.IsCurrentUse].ToString().Trim()); //是否当前使用
objXzSchoolEN.SchoolENName = objRow[conXzSchool.SchoolENName] == DBNull.Value ? null : objRow[conXzSchool.SchoolENName].ToString().Trim(); //学校英文名
objXzSchoolEN.SchoolNameA = objRow[conXzSchool.SchoolNameA] == DBNull.Value ? null : objRow[conXzSchool.SchoolNameA].ToString().Trim(); //学校简称
objXzSchoolEN.SchoolTypeId = objRow[conXzSchool.SchoolTypeId] == DBNull.Value ? null : objRow[conXzSchool.SchoolTypeId].ToString().Trim(); //学校类型Id
objXzSchoolEN.UpdDate = objRow[conXzSchool.UpdDate] == DBNull.Value ? null : objRow[conXzSchool.UpdDate].ToString().Trim(); //修改日期
objXzSchoolEN.UpdUserId = objRow[conXzSchool.UpdUserId] == DBNull.Value ? null : objRow[conXzSchool.UpdUserId].ToString().Trim(); //修改用户Id
objXzSchoolEN.Memo = objRow[conXzSchool.Memo] == DBNull.Value ? null : objRow[conXzSchool.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsXzSchoolDA: GetObjLst)", objException.Message));
}
objXzSchoolEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objXzSchoolEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objXzSchoolEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetXzSchool(ref clsXzSchoolEN objXzSchoolEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
strSQL = "Select * from XzSchool where IdSchool = " + "'"+ objXzSchoolEN.IdSchool+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objXzSchoolEN.IdSchool = objDT.Rows[0][conXzSchool.IdSchool].ToString().Trim(); //学校流水号(字段类型:char,字段长度:4,是否可空:True)
 objXzSchoolEN.SchoolId = objDT.Rows[0][conXzSchool.SchoolId].ToString().Trim(); //学校Id(字段类型:varchar,字段长度:20,是否可空:False)
 objXzSchoolEN.SchoolName = objDT.Rows[0][conXzSchool.SchoolName].ToString().Trim(); //学校名称(字段类型:varchar,字段长度:50,是否可空:False)
 objXzSchoolEN.IsCurrentUse = TransNullToBool(objDT.Rows[0][conXzSchool.IsCurrentUse].ToString().Trim()); //是否当前使用(字段类型:bit,字段长度:1,是否可空:True)
 objXzSchoolEN.SchoolENName = objDT.Rows[0][conXzSchool.SchoolENName].ToString().Trim(); //学校英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objXzSchoolEN.SchoolNameA = objDT.Rows[0][conXzSchool.SchoolNameA].ToString().Trim(); //学校简称(字段类型:varchar,字段长度:14,是否可空:True)
 objXzSchoolEN.SchoolTypeId = objDT.Rows[0][conXzSchool.SchoolTypeId].ToString().Trim(); //学校类型Id(字段类型:char,字段长度:2,是否可空:True)
 objXzSchoolEN.UpdDate = objDT.Rows[0][conXzSchool.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objXzSchoolEN.UpdUserId = objDT.Rows[0][conXzSchool.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objXzSchoolEN.Memo = objDT.Rows[0][conXzSchool.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsXzSchoolDA: GetXzSchool)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdSchool">表关键字</param>
 /// <returns>表对象</returns>
public clsXzSchoolEN GetObjByIdSchool(string strIdSchool)
{
CheckPrimaryKey(strIdSchool);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
strSQL = "Select * from XzSchool where IdSchool = " + "'"+ strIdSchool+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsXzSchoolEN objXzSchoolEN = new clsXzSchoolEN();
try
{
 objXzSchoolEN.IdSchool = objRow[conXzSchool.IdSchool].ToString().Trim(); //学校流水号(字段类型:char,字段长度:4,是否可空:True)
 objXzSchoolEN.SchoolId = objRow[conXzSchool.SchoolId].ToString().Trim(); //学校Id(字段类型:varchar,字段长度:20,是否可空:False)
 objXzSchoolEN.SchoolName = objRow[conXzSchool.SchoolName].ToString().Trim(); //学校名称(字段类型:varchar,字段长度:50,是否可空:False)
 objXzSchoolEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[conXzSchool.IsCurrentUse].ToString().Trim()); //是否当前使用(字段类型:bit,字段长度:1,是否可空:True)
 objXzSchoolEN.SchoolENName = objRow[conXzSchool.SchoolENName] == DBNull.Value ? null : objRow[conXzSchool.SchoolENName].ToString().Trim(); //学校英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objXzSchoolEN.SchoolNameA = objRow[conXzSchool.SchoolNameA] == DBNull.Value ? null : objRow[conXzSchool.SchoolNameA].ToString().Trim(); //学校简称(字段类型:varchar,字段长度:14,是否可空:True)
 objXzSchoolEN.SchoolTypeId = objRow[conXzSchool.SchoolTypeId] == DBNull.Value ? null : objRow[conXzSchool.SchoolTypeId].ToString().Trim(); //学校类型Id(字段类型:char,字段长度:2,是否可空:True)
 objXzSchoolEN.UpdDate = objRow[conXzSchool.UpdDate] == DBNull.Value ? null : objRow[conXzSchool.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objXzSchoolEN.UpdUserId = objRow[conXzSchool.UpdUserId] == DBNull.Value ? null : objRow[conXzSchool.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objXzSchoolEN.Memo = objRow[conXzSchool.Memo] == DBNull.Value ? null : objRow[conXzSchool.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsXzSchoolDA: GetObjByIdSchool)", objException.Message));
}
return objXzSchoolEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsXzSchoolEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsXzSchoolDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
strSQL = "Select * from XzSchool where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsXzSchoolEN objXzSchoolEN = new clsXzSchoolEN()
{
IdSchool = objRow[conXzSchool.IdSchool].ToString().Trim(), //学校流水号
SchoolId = objRow[conXzSchool.SchoolId].ToString().Trim(), //学校Id
SchoolName = objRow[conXzSchool.SchoolName].ToString().Trim(), //学校名称
IsCurrentUse = TransNullToBool(objRow[conXzSchool.IsCurrentUse].ToString().Trim()), //是否当前使用
SchoolENName = objRow[conXzSchool.SchoolENName] == DBNull.Value ? null : objRow[conXzSchool.SchoolENName].ToString().Trim(), //学校英文名
SchoolNameA = objRow[conXzSchool.SchoolNameA] == DBNull.Value ? null : objRow[conXzSchool.SchoolNameA].ToString().Trim(), //学校简称
SchoolTypeId = objRow[conXzSchool.SchoolTypeId] == DBNull.Value ? null : objRow[conXzSchool.SchoolTypeId].ToString().Trim(), //学校类型Id
UpdDate = objRow[conXzSchool.UpdDate] == DBNull.Value ? null : objRow[conXzSchool.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conXzSchool.UpdUserId] == DBNull.Value ? null : objRow[conXzSchool.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conXzSchool.Memo] == DBNull.Value ? null : objRow[conXzSchool.Memo].ToString().Trim() //说明
};
objXzSchoolEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objXzSchoolEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsXzSchoolDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsXzSchoolEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsXzSchoolEN objXzSchoolEN = new clsXzSchoolEN();
try
{
objXzSchoolEN.IdSchool = objRow[conXzSchool.IdSchool].ToString().Trim(); //学校流水号
objXzSchoolEN.SchoolId = objRow[conXzSchool.SchoolId].ToString().Trim(); //学校Id
objXzSchoolEN.SchoolName = objRow[conXzSchool.SchoolName].ToString().Trim(); //学校名称
objXzSchoolEN.IsCurrentUse = TransNullToBool(objRow[conXzSchool.IsCurrentUse].ToString().Trim()); //是否当前使用
objXzSchoolEN.SchoolENName = objRow[conXzSchool.SchoolENName] == DBNull.Value ? null : objRow[conXzSchool.SchoolENName].ToString().Trim(); //学校英文名
objXzSchoolEN.SchoolNameA = objRow[conXzSchool.SchoolNameA] == DBNull.Value ? null : objRow[conXzSchool.SchoolNameA].ToString().Trim(); //学校简称
objXzSchoolEN.SchoolTypeId = objRow[conXzSchool.SchoolTypeId] == DBNull.Value ? null : objRow[conXzSchool.SchoolTypeId].ToString().Trim(); //学校类型Id
objXzSchoolEN.UpdDate = objRow[conXzSchool.UpdDate] == DBNull.Value ? null : objRow[conXzSchool.UpdDate].ToString().Trim(); //修改日期
objXzSchoolEN.UpdUserId = objRow[conXzSchool.UpdUserId] == DBNull.Value ? null : objRow[conXzSchool.UpdUserId].ToString().Trim(); //修改用户Id
objXzSchoolEN.Memo = objRow[conXzSchool.Memo] == DBNull.Value ? null : objRow[conXzSchool.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsXzSchoolDA: GetObjByDataRowXzSchool)", objException.Message));
}
objXzSchoolEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objXzSchoolEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsXzSchoolEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsXzSchoolEN objXzSchoolEN = new clsXzSchoolEN();
try
{
objXzSchoolEN.IdSchool = objRow[conXzSchool.IdSchool].ToString().Trim(); //学校流水号
objXzSchoolEN.SchoolId = objRow[conXzSchool.SchoolId].ToString().Trim(); //学校Id
objXzSchoolEN.SchoolName = objRow[conXzSchool.SchoolName].ToString().Trim(); //学校名称
objXzSchoolEN.IsCurrentUse = TransNullToBool(objRow[conXzSchool.IsCurrentUse].ToString().Trim()); //是否当前使用
objXzSchoolEN.SchoolENName = objRow[conXzSchool.SchoolENName] == DBNull.Value ? null : objRow[conXzSchool.SchoolENName].ToString().Trim(); //学校英文名
objXzSchoolEN.SchoolNameA = objRow[conXzSchool.SchoolNameA] == DBNull.Value ? null : objRow[conXzSchool.SchoolNameA].ToString().Trim(); //学校简称
objXzSchoolEN.SchoolTypeId = objRow[conXzSchool.SchoolTypeId] == DBNull.Value ? null : objRow[conXzSchool.SchoolTypeId].ToString().Trim(); //学校类型Id
objXzSchoolEN.UpdDate = objRow[conXzSchool.UpdDate] == DBNull.Value ? null : objRow[conXzSchool.UpdDate].ToString().Trim(); //修改日期
objXzSchoolEN.UpdUserId = objRow[conXzSchool.UpdUserId] == DBNull.Value ? null : objRow[conXzSchool.UpdUserId].ToString().Trim(); //修改用户Id
objXzSchoolEN.Memo = objRow[conXzSchool.Memo] == DBNull.Value ? null : objRow[conXzSchool.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsXzSchoolDA: GetObjByDataRow)", objException.Message));
}
objXzSchoolEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objXzSchoolEN;
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
objSQL = clsXzSchoolDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsXzSchoolEN._CurrTabName, conXzSchool.IdSchool, 4, "");
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
objSQL = clsXzSchoolDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsXzSchoolEN._CurrTabName, conXzSchool.IdSchool, 4, strPrefix);
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
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdSchool from XzSchool where " + strCondition;
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
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdSchool from XzSchool where " + strCondition;
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
 /// <param name = "strIdSchool">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdSchool)
{
CheckPrimaryKey(strIdSchool);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("XzSchool", "IdSchool = " + "'"+ strIdSchool+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsXzSchoolDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("XzSchool", strCondition))
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
objSQL = clsXzSchoolDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("XzSchool");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsXzSchoolEN objXzSchoolEN)
 {
 if (objXzSchoolEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objXzSchoolEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
strSQL = "Select * from XzSchool where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "XzSchool");
objRow = objDS.Tables["XzSchool"].NewRow();
objRow[conXzSchool.IdSchool] = objXzSchoolEN.IdSchool; //学校流水号
objRow[conXzSchool.SchoolId] = objXzSchoolEN.SchoolId; //学校Id
objRow[conXzSchool.SchoolName] = objXzSchoolEN.SchoolName; //学校名称
objRow[conXzSchool.IsCurrentUse] = objXzSchoolEN.IsCurrentUse; //是否当前使用
 if (objXzSchoolEN.SchoolENName !=  "")
 {
objRow[conXzSchool.SchoolENName] = objXzSchoolEN.SchoolENName; //学校英文名
 }
 if (objXzSchoolEN.SchoolNameA !=  "")
 {
objRow[conXzSchool.SchoolNameA] = objXzSchoolEN.SchoolNameA; //学校简称
 }
 if (objXzSchoolEN.SchoolTypeId !=  "")
 {
objRow[conXzSchool.SchoolTypeId] = objXzSchoolEN.SchoolTypeId; //学校类型Id
 }
 if (objXzSchoolEN.UpdDate !=  "")
 {
objRow[conXzSchool.UpdDate] = objXzSchoolEN.UpdDate; //修改日期
 }
 if (objXzSchoolEN.UpdUserId !=  "")
 {
objRow[conXzSchool.UpdUserId] = objXzSchoolEN.UpdUserId; //修改用户Id
 }
 if (objXzSchoolEN.Memo !=  "")
 {
objRow[conXzSchool.Memo] = objXzSchoolEN.Memo; //说明
 }
objDS.Tables[clsXzSchoolEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsXzSchoolEN._CurrTabName);
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
 /// <param name = "objXzSchoolEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsXzSchoolEN objXzSchoolEN)
{
 if (objXzSchoolEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objXzSchoolEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objXzSchoolEN.IdSchool !=  null)
 {
 arrFieldListForInsert.Add(conXzSchool.IdSchool);
 var strIdSchool = objXzSchoolEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSchool + "'");
 }
 
 if (objXzSchoolEN.SchoolId !=  null)
 {
 arrFieldListForInsert.Add(conXzSchool.SchoolId);
 var strSchoolId = objXzSchoolEN.SchoolId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolId + "'");
 }
 
 if (objXzSchoolEN.SchoolName !=  null)
 {
 arrFieldListForInsert.Add(conXzSchool.SchoolName);
 var strSchoolName = objXzSchoolEN.SchoolName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolName + "'");
 }
 
 arrFieldListForInsert.Add(conXzSchool.IsCurrentUse);
 arrValueListForInsert.Add("'" + (objXzSchoolEN.IsCurrentUse  ==  false ? "0" : "1") + "'");
 
 if (objXzSchoolEN.SchoolENName !=  null)
 {
 arrFieldListForInsert.Add(conXzSchool.SchoolENName);
 var strSchoolENName = objXzSchoolEN.SchoolENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolENName + "'");
 }
 
 if (objXzSchoolEN.SchoolNameA !=  null)
 {
 arrFieldListForInsert.Add(conXzSchool.SchoolNameA);
 var strSchoolNameA = objXzSchoolEN.SchoolNameA.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolNameA + "'");
 }
 
 if (objXzSchoolEN.SchoolTypeId !=  null)
 {
 arrFieldListForInsert.Add(conXzSchool.SchoolTypeId);
 var strSchoolTypeId = objXzSchoolEN.SchoolTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTypeId + "'");
 }
 
 if (objXzSchoolEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conXzSchool.UpdDate);
 var strUpdDate = objXzSchoolEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objXzSchoolEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conXzSchool.UpdUserId);
 var strUpdUserId = objXzSchoolEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objXzSchoolEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conXzSchool.Memo);
 var strMemo = objXzSchoolEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into XzSchool");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objXzSchoolEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsXzSchoolEN objXzSchoolEN)
{
 if (objXzSchoolEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objXzSchoolEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objXzSchoolEN.IdSchool !=  null)
 {
 arrFieldListForInsert.Add(conXzSchool.IdSchool);
 var strIdSchool = objXzSchoolEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSchool + "'");
 }
 
 if (objXzSchoolEN.SchoolId !=  null)
 {
 arrFieldListForInsert.Add(conXzSchool.SchoolId);
 var strSchoolId = objXzSchoolEN.SchoolId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolId + "'");
 }
 
 if (objXzSchoolEN.SchoolName !=  null)
 {
 arrFieldListForInsert.Add(conXzSchool.SchoolName);
 var strSchoolName = objXzSchoolEN.SchoolName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolName + "'");
 }
 
 arrFieldListForInsert.Add(conXzSchool.IsCurrentUse);
 arrValueListForInsert.Add("'" + (objXzSchoolEN.IsCurrentUse  ==  false ? "0" : "1") + "'");
 
 if (objXzSchoolEN.SchoolENName !=  null)
 {
 arrFieldListForInsert.Add(conXzSchool.SchoolENName);
 var strSchoolENName = objXzSchoolEN.SchoolENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolENName + "'");
 }
 
 if (objXzSchoolEN.SchoolNameA !=  null)
 {
 arrFieldListForInsert.Add(conXzSchool.SchoolNameA);
 var strSchoolNameA = objXzSchoolEN.SchoolNameA.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolNameA + "'");
 }
 
 if (objXzSchoolEN.SchoolTypeId !=  null)
 {
 arrFieldListForInsert.Add(conXzSchool.SchoolTypeId);
 var strSchoolTypeId = objXzSchoolEN.SchoolTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTypeId + "'");
 }
 
 if (objXzSchoolEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conXzSchool.UpdDate);
 var strUpdDate = objXzSchoolEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objXzSchoolEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conXzSchool.UpdUserId);
 var strUpdUserId = objXzSchoolEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objXzSchoolEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conXzSchool.Memo);
 var strMemo = objXzSchoolEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into XzSchool");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objXzSchoolEN.IdSchool;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objXzSchoolEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsXzSchoolEN objXzSchoolEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objXzSchoolEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objXzSchoolEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objXzSchoolEN.IdSchool !=  null)
 {
 arrFieldListForInsert.Add(conXzSchool.IdSchool);
 var strIdSchool = objXzSchoolEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSchool + "'");
 }
 
 if (objXzSchoolEN.SchoolId !=  null)
 {
 arrFieldListForInsert.Add(conXzSchool.SchoolId);
 var strSchoolId = objXzSchoolEN.SchoolId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolId + "'");
 }
 
 if (objXzSchoolEN.SchoolName !=  null)
 {
 arrFieldListForInsert.Add(conXzSchool.SchoolName);
 var strSchoolName = objXzSchoolEN.SchoolName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolName + "'");
 }
 
 arrFieldListForInsert.Add(conXzSchool.IsCurrentUse);
 arrValueListForInsert.Add("'" + (objXzSchoolEN.IsCurrentUse  ==  false ? "0" : "1") + "'");
 
 if (objXzSchoolEN.SchoolENName !=  null)
 {
 arrFieldListForInsert.Add(conXzSchool.SchoolENName);
 var strSchoolENName = objXzSchoolEN.SchoolENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolENName + "'");
 }
 
 if (objXzSchoolEN.SchoolNameA !=  null)
 {
 arrFieldListForInsert.Add(conXzSchool.SchoolNameA);
 var strSchoolNameA = objXzSchoolEN.SchoolNameA.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolNameA + "'");
 }
 
 if (objXzSchoolEN.SchoolTypeId !=  null)
 {
 arrFieldListForInsert.Add(conXzSchool.SchoolTypeId);
 var strSchoolTypeId = objXzSchoolEN.SchoolTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTypeId + "'");
 }
 
 if (objXzSchoolEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conXzSchool.UpdDate);
 var strUpdDate = objXzSchoolEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objXzSchoolEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conXzSchool.UpdUserId);
 var strUpdUserId = objXzSchoolEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objXzSchoolEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conXzSchool.Memo);
 var strMemo = objXzSchoolEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into XzSchool");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objXzSchoolEN.IdSchool;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objXzSchoolEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsXzSchoolEN objXzSchoolEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objXzSchoolEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objXzSchoolEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objXzSchoolEN.IdSchool !=  null)
 {
 arrFieldListForInsert.Add(conXzSchool.IdSchool);
 var strIdSchool = objXzSchoolEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSchool + "'");
 }
 
 if (objXzSchoolEN.SchoolId !=  null)
 {
 arrFieldListForInsert.Add(conXzSchool.SchoolId);
 var strSchoolId = objXzSchoolEN.SchoolId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolId + "'");
 }
 
 if (objXzSchoolEN.SchoolName !=  null)
 {
 arrFieldListForInsert.Add(conXzSchool.SchoolName);
 var strSchoolName = objXzSchoolEN.SchoolName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolName + "'");
 }
 
 arrFieldListForInsert.Add(conXzSchool.IsCurrentUse);
 arrValueListForInsert.Add("'" + (objXzSchoolEN.IsCurrentUse  ==  false ? "0" : "1") + "'");
 
 if (objXzSchoolEN.SchoolENName !=  null)
 {
 arrFieldListForInsert.Add(conXzSchool.SchoolENName);
 var strSchoolENName = objXzSchoolEN.SchoolENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolENName + "'");
 }
 
 if (objXzSchoolEN.SchoolNameA !=  null)
 {
 arrFieldListForInsert.Add(conXzSchool.SchoolNameA);
 var strSchoolNameA = objXzSchoolEN.SchoolNameA.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolNameA + "'");
 }
 
 if (objXzSchoolEN.SchoolTypeId !=  null)
 {
 arrFieldListForInsert.Add(conXzSchool.SchoolTypeId);
 var strSchoolTypeId = objXzSchoolEN.SchoolTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTypeId + "'");
 }
 
 if (objXzSchoolEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conXzSchool.UpdDate);
 var strUpdDate = objXzSchoolEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objXzSchoolEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conXzSchool.UpdUserId);
 var strUpdUserId = objXzSchoolEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objXzSchoolEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conXzSchool.Memo);
 var strMemo = objXzSchoolEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into XzSchool");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewXzSchools(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
strSQL = "Select * from XzSchool where IdSchool = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "XzSchool");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strIdSchool = oRow[conXzSchool.IdSchool].ToString().Trim();
if (IsExist(strIdSchool))
{
 string strResult = "关键字变量值为:" + string.Format("IdSchool = {0}", strIdSchool) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsXzSchoolEN._CurrTabName ].NewRow();
objRow[conXzSchool.IdSchool] = oRow[conXzSchool.IdSchool].ToString().Trim(); //学校流水号
objRow[conXzSchool.SchoolId] = oRow[conXzSchool.SchoolId].ToString().Trim(); //学校Id
objRow[conXzSchool.SchoolName] = oRow[conXzSchool.SchoolName].ToString().Trim(); //学校名称
objRow[conXzSchool.IsCurrentUse] = oRow[conXzSchool.IsCurrentUse].ToString().Trim(); //是否当前使用
objRow[conXzSchool.SchoolENName] = oRow[conXzSchool.SchoolENName].ToString().Trim(); //学校英文名
objRow[conXzSchool.SchoolNameA] = oRow[conXzSchool.SchoolNameA].ToString().Trim(); //学校简称
objRow[conXzSchool.SchoolTypeId] = oRow[conXzSchool.SchoolTypeId].ToString().Trim(); //学校类型Id
objRow[conXzSchool.UpdDate] = oRow[conXzSchool.UpdDate].ToString().Trim(); //修改日期
objRow[conXzSchool.UpdUserId] = oRow[conXzSchool.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conXzSchool.Memo] = oRow[conXzSchool.Memo].ToString().Trim(); //说明
 objDS.Tables[clsXzSchoolEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsXzSchoolEN._CurrTabName);
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
 /// <param name = "objXzSchoolEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsXzSchoolEN objXzSchoolEN)
{
 if (objXzSchoolEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objXzSchoolEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
strSQL = "Select * from XzSchool where IdSchool = " + "'"+ objXzSchoolEN.IdSchool+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsXzSchoolEN._CurrTabName);
if (objDS.Tables[clsXzSchoolEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdSchool = " + "'"+ objXzSchoolEN.IdSchool+"'");
return false;
}
objRow = objDS.Tables[clsXzSchoolEN._CurrTabName].Rows[0];
 if (objXzSchoolEN.IsUpdated(conXzSchool.IdSchool))
 {
objRow[conXzSchool.IdSchool] = objXzSchoolEN.IdSchool; //学校流水号
 }
 if (objXzSchoolEN.IsUpdated(conXzSchool.SchoolId))
 {
objRow[conXzSchool.SchoolId] = objXzSchoolEN.SchoolId; //学校Id
 }
 if (objXzSchoolEN.IsUpdated(conXzSchool.SchoolName))
 {
objRow[conXzSchool.SchoolName] = objXzSchoolEN.SchoolName; //学校名称
 }
 if (objXzSchoolEN.IsUpdated(conXzSchool.IsCurrentUse))
 {
objRow[conXzSchool.IsCurrentUse] = objXzSchoolEN.IsCurrentUse; //是否当前使用
 }
 if (objXzSchoolEN.IsUpdated(conXzSchool.SchoolENName))
 {
objRow[conXzSchool.SchoolENName] = objXzSchoolEN.SchoolENName; //学校英文名
 }
 if (objXzSchoolEN.IsUpdated(conXzSchool.SchoolNameA))
 {
objRow[conXzSchool.SchoolNameA] = objXzSchoolEN.SchoolNameA; //学校简称
 }
 if (objXzSchoolEN.IsUpdated(conXzSchool.SchoolTypeId))
 {
objRow[conXzSchool.SchoolTypeId] = objXzSchoolEN.SchoolTypeId; //学校类型Id
 }
 if (objXzSchoolEN.IsUpdated(conXzSchool.UpdDate))
 {
objRow[conXzSchool.UpdDate] = objXzSchoolEN.UpdDate; //修改日期
 }
 if (objXzSchoolEN.IsUpdated(conXzSchool.UpdUserId))
 {
objRow[conXzSchool.UpdUserId] = objXzSchoolEN.UpdUserId; //修改用户Id
 }
 if (objXzSchoolEN.IsUpdated(conXzSchool.Memo))
 {
objRow[conXzSchool.Memo] = objXzSchoolEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsXzSchoolEN._CurrTabName);
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
 /// <param name = "objXzSchoolEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsXzSchoolEN objXzSchoolEN)
{
 if (objXzSchoolEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objXzSchoolEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update XzSchool Set ");
 
 if (objXzSchoolEN.IsUpdated(conXzSchool.SchoolId))
 {
 if (objXzSchoolEN.SchoolId !=  null)
 {
 var strSchoolId = objXzSchoolEN.SchoolId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolId, conXzSchool.SchoolId); //学校Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzSchool.SchoolId); //学校Id
 }
 }
 
 if (objXzSchoolEN.IsUpdated(conXzSchool.SchoolName))
 {
 if (objXzSchoolEN.SchoolName !=  null)
 {
 var strSchoolName = objXzSchoolEN.SchoolName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolName, conXzSchool.SchoolName); //学校名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzSchool.SchoolName); //学校名称
 }
 }
 
 if (objXzSchoolEN.IsUpdated(conXzSchool.IsCurrentUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objXzSchoolEN.IsCurrentUse == true?"1":"0", conXzSchool.IsCurrentUse); //是否当前使用
 }
 
 if (objXzSchoolEN.IsUpdated(conXzSchool.SchoolENName))
 {
 if (objXzSchoolEN.SchoolENName !=  null)
 {
 var strSchoolENName = objXzSchoolEN.SchoolENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolENName, conXzSchool.SchoolENName); //学校英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzSchool.SchoolENName); //学校英文名
 }
 }
 
 if (objXzSchoolEN.IsUpdated(conXzSchool.SchoolNameA))
 {
 if (objXzSchoolEN.SchoolNameA !=  null)
 {
 var strSchoolNameA = objXzSchoolEN.SchoolNameA.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolNameA, conXzSchool.SchoolNameA); //学校简称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzSchool.SchoolNameA); //学校简称
 }
 }
 
 if (objXzSchoolEN.IsUpdated(conXzSchool.SchoolTypeId))
 {
 if (objXzSchoolEN.SchoolTypeId !=  null)
 {
 var strSchoolTypeId = objXzSchoolEN.SchoolTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolTypeId, conXzSchool.SchoolTypeId); //学校类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzSchool.SchoolTypeId); //学校类型Id
 }
 }
 
 if (objXzSchoolEN.IsUpdated(conXzSchool.UpdDate))
 {
 if (objXzSchoolEN.UpdDate !=  null)
 {
 var strUpdDate = objXzSchoolEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conXzSchool.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzSchool.UpdDate); //修改日期
 }
 }
 
 if (objXzSchoolEN.IsUpdated(conXzSchool.UpdUserId))
 {
 if (objXzSchoolEN.UpdUserId !=  null)
 {
 var strUpdUserId = objXzSchoolEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conXzSchool.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzSchool.UpdUserId); //修改用户Id
 }
 }
 
 if (objXzSchoolEN.IsUpdated(conXzSchool.Memo))
 {
 if (objXzSchoolEN.Memo !=  null)
 {
 var strMemo = objXzSchoolEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conXzSchool.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzSchool.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdSchool = '{0}'", objXzSchoolEN.IdSchool); 
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
 /// <param name = "objXzSchoolEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsXzSchoolEN objXzSchoolEN, string strCondition)
{
 if (objXzSchoolEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objXzSchoolEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update XzSchool Set ");
 
 if (objXzSchoolEN.IsUpdated(conXzSchool.SchoolId))
 {
 if (objXzSchoolEN.SchoolId !=  null)
 {
 var strSchoolId = objXzSchoolEN.SchoolId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolId = '{0}',", strSchoolId); //学校Id
 }
 else
 {
 sbSQL.Append(" SchoolId = null,"); //学校Id
 }
 }
 
 if (objXzSchoolEN.IsUpdated(conXzSchool.SchoolName))
 {
 if (objXzSchoolEN.SchoolName !=  null)
 {
 var strSchoolName = objXzSchoolEN.SchoolName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolName = '{0}',", strSchoolName); //学校名称
 }
 else
 {
 sbSQL.Append(" SchoolName = null,"); //学校名称
 }
 }
 
 if (objXzSchoolEN.IsUpdated(conXzSchool.IsCurrentUse))
 {
 sbSQL.AppendFormat(" IsCurrentUse = '{0}',", objXzSchoolEN.IsCurrentUse == true?"1":"0"); //是否当前使用
 }
 
 if (objXzSchoolEN.IsUpdated(conXzSchool.SchoolENName))
 {
 if (objXzSchoolEN.SchoolENName !=  null)
 {
 var strSchoolENName = objXzSchoolEN.SchoolENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolENName = '{0}',", strSchoolENName); //学校英文名
 }
 else
 {
 sbSQL.Append(" SchoolENName = null,"); //学校英文名
 }
 }
 
 if (objXzSchoolEN.IsUpdated(conXzSchool.SchoolNameA))
 {
 if (objXzSchoolEN.SchoolNameA !=  null)
 {
 var strSchoolNameA = objXzSchoolEN.SchoolNameA.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolNameA = '{0}',", strSchoolNameA); //学校简称
 }
 else
 {
 sbSQL.Append(" SchoolNameA = null,"); //学校简称
 }
 }
 
 if (objXzSchoolEN.IsUpdated(conXzSchool.SchoolTypeId))
 {
 if (objXzSchoolEN.SchoolTypeId !=  null)
 {
 var strSchoolTypeId = objXzSchoolEN.SchoolTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolTypeId = '{0}',", strSchoolTypeId); //学校类型Id
 }
 else
 {
 sbSQL.Append(" SchoolTypeId = null,"); //学校类型Id
 }
 }
 
 if (objXzSchoolEN.IsUpdated(conXzSchool.UpdDate))
 {
 if (objXzSchoolEN.UpdDate !=  null)
 {
 var strUpdDate = objXzSchoolEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objXzSchoolEN.IsUpdated(conXzSchool.UpdUserId))
 {
 if (objXzSchoolEN.UpdUserId !=  null)
 {
 var strUpdUserId = objXzSchoolEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objXzSchoolEN.IsUpdated(conXzSchool.Memo))
 {
 if (objXzSchoolEN.Memo !=  null)
 {
 var strMemo = objXzSchoolEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objXzSchoolEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsXzSchoolEN objXzSchoolEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objXzSchoolEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objXzSchoolEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update XzSchool Set ");
 
 if (objXzSchoolEN.IsUpdated(conXzSchool.SchoolId))
 {
 if (objXzSchoolEN.SchoolId !=  null)
 {
 var strSchoolId = objXzSchoolEN.SchoolId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolId = '{0}',", strSchoolId); //学校Id
 }
 else
 {
 sbSQL.Append(" SchoolId = null,"); //学校Id
 }
 }
 
 if (objXzSchoolEN.IsUpdated(conXzSchool.SchoolName))
 {
 if (objXzSchoolEN.SchoolName !=  null)
 {
 var strSchoolName = objXzSchoolEN.SchoolName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolName = '{0}',", strSchoolName); //学校名称
 }
 else
 {
 sbSQL.Append(" SchoolName = null,"); //学校名称
 }
 }
 
 if (objXzSchoolEN.IsUpdated(conXzSchool.IsCurrentUse))
 {
 sbSQL.AppendFormat(" IsCurrentUse = '{0}',", objXzSchoolEN.IsCurrentUse == true?"1":"0"); //是否当前使用
 }
 
 if (objXzSchoolEN.IsUpdated(conXzSchool.SchoolENName))
 {
 if (objXzSchoolEN.SchoolENName !=  null)
 {
 var strSchoolENName = objXzSchoolEN.SchoolENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolENName = '{0}',", strSchoolENName); //学校英文名
 }
 else
 {
 sbSQL.Append(" SchoolENName = null,"); //学校英文名
 }
 }
 
 if (objXzSchoolEN.IsUpdated(conXzSchool.SchoolNameA))
 {
 if (objXzSchoolEN.SchoolNameA !=  null)
 {
 var strSchoolNameA = objXzSchoolEN.SchoolNameA.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolNameA = '{0}',", strSchoolNameA); //学校简称
 }
 else
 {
 sbSQL.Append(" SchoolNameA = null,"); //学校简称
 }
 }
 
 if (objXzSchoolEN.IsUpdated(conXzSchool.SchoolTypeId))
 {
 if (objXzSchoolEN.SchoolTypeId !=  null)
 {
 var strSchoolTypeId = objXzSchoolEN.SchoolTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolTypeId = '{0}',", strSchoolTypeId); //学校类型Id
 }
 else
 {
 sbSQL.Append(" SchoolTypeId = null,"); //学校类型Id
 }
 }
 
 if (objXzSchoolEN.IsUpdated(conXzSchool.UpdDate))
 {
 if (objXzSchoolEN.UpdDate !=  null)
 {
 var strUpdDate = objXzSchoolEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objXzSchoolEN.IsUpdated(conXzSchool.UpdUserId))
 {
 if (objXzSchoolEN.UpdUserId !=  null)
 {
 var strUpdUserId = objXzSchoolEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objXzSchoolEN.IsUpdated(conXzSchool.Memo))
 {
 if (objXzSchoolEN.Memo !=  null)
 {
 var strMemo = objXzSchoolEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objXzSchoolEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsXzSchoolEN objXzSchoolEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objXzSchoolEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objXzSchoolEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update XzSchool Set ");
 
 if (objXzSchoolEN.IsUpdated(conXzSchool.SchoolId))
 {
 if (objXzSchoolEN.SchoolId !=  null)
 {
 var strSchoolId = objXzSchoolEN.SchoolId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolId, conXzSchool.SchoolId); //学校Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzSchool.SchoolId); //学校Id
 }
 }
 
 if (objXzSchoolEN.IsUpdated(conXzSchool.SchoolName))
 {
 if (objXzSchoolEN.SchoolName !=  null)
 {
 var strSchoolName = objXzSchoolEN.SchoolName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolName, conXzSchool.SchoolName); //学校名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzSchool.SchoolName); //学校名称
 }
 }
 
 if (objXzSchoolEN.IsUpdated(conXzSchool.IsCurrentUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objXzSchoolEN.IsCurrentUse == true?"1":"0", conXzSchool.IsCurrentUse); //是否当前使用
 }
 
 if (objXzSchoolEN.IsUpdated(conXzSchool.SchoolENName))
 {
 if (objXzSchoolEN.SchoolENName !=  null)
 {
 var strSchoolENName = objXzSchoolEN.SchoolENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolENName, conXzSchool.SchoolENName); //学校英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzSchool.SchoolENName); //学校英文名
 }
 }
 
 if (objXzSchoolEN.IsUpdated(conXzSchool.SchoolNameA))
 {
 if (objXzSchoolEN.SchoolNameA !=  null)
 {
 var strSchoolNameA = objXzSchoolEN.SchoolNameA.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolNameA, conXzSchool.SchoolNameA); //学校简称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzSchool.SchoolNameA); //学校简称
 }
 }
 
 if (objXzSchoolEN.IsUpdated(conXzSchool.SchoolTypeId))
 {
 if (objXzSchoolEN.SchoolTypeId !=  null)
 {
 var strSchoolTypeId = objXzSchoolEN.SchoolTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolTypeId, conXzSchool.SchoolTypeId); //学校类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzSchool.SchoolTypeId); //学校类型Id
 }
 }
 
 if (objXzSchoolEN.IsUpdated(conXzSchool.UpdDate))
 {
 if (objXzSchoolEN.UpdDate !=  null)
 {
 var strUpdDate = objXzSchoolEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conXzSchool.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzSchool.UpdDate); //修改日期
 }
 }
 
 if (objXzSchoolEN.IsUpdated(conXzSchool.UpdUserId))
 {
 if (objXzSchoolEN.UpdUserId !=  null)
 {
 var strUpdUserId = objXzSchoolEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conXzSchool.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzSchool.UpdUserId); //修改用户Id
 }
 }
 
 if (objXzSchoolEN.IsUpdated(conXzSchool.Memo))
 {
 if (objXzSchoolEN.Memo !=  null)
 {
 var strMemo = objXzSchoolEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conXzSchool.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzSchool.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdSchool = '{0}'", objXzSchoolEN.IdSchool); 
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
 /// <param name = "strIdSchool">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strIdSchool) 
{
CheckPrimaryKey(strIdSchool);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strIdSchool,
};
 objSQL.ExecSP("XzSchool_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strIdSchool">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strIdSchool, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strIdSchool);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
//删除XzSchool本表中与当前对象有关的记录
strSQL = strSQL + "Delete from XzSchool where IdSchool = " + "'"+ strIdSchool+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelXzSchool(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
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
//删除XzSchool本表中与当前对象有关的记录
strSQL = strSQL + "Delete from XzSchool where IdSchool in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strIdSchool">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strIdSchool) 
{
CheckPrimaryKey(strIdSchool);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
//删除XzSchool本表中与当前对象有关的记录
strSQL = strSQL + "Delete from XzSchool where IdSchool = " + "'"+ strIdSchool+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelXzSchool(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsXzSchoolDA: DelXzSchool)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from XzSchool where " + strCondition ;
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
public bool DelXzSchoolWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsXzSchoolDA: DelXzSchoolWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from XzSchool where " + strCondition ;
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
 /// <param name = "objXzSchoolENS">源对象</param>
 /// <param name = "objXzSchoolENT">目标对象</param>
public void CopyTo(clsXzSchoolEN objXzSchoolENS, clsXzSchoolEN objXzSchoolENT)
{
objXzSchoolENT.IdSchool = objXzSchoolENS.IdSchool; //学校流水号
objXzSchoolENT.SchoolId = objXzSchoolENS.SchoolId; //学校Id
objXzSchoolENT.SchoolName = objXzSchoolENS.SchoolName; //学校名称
objXzSchoolENT.IsCurrentUse = objXzSchoolENS.IsCurrentUse; //是否当前使用
objXzSchoolENT.SchoolENName = objXzSchoolENS.SchoolENName; //学校英文名
objXzSchoolENT.SchoolNameA = objXzSchoolENS.SchoolNameA; //学校简称
objXzSchoolENT.SchoolTypeId = objXzSchoolENS.SchoolTypeId; //学校类型Id
objXzSchoolENT.UpdDate = objXzSchoolENS.UpdDate; //修改日期
objXzSchoolENT.UpdUserId = objXzSchoolENS.UpdUserId; //修改用户Id
objXzSchoolENT.Memo = objXzSchoolENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsXzSchoolEN objXzSchoolEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objXzSchoolEN.SchoolId, conXzSchool.SchoolId);
clsCheckSql.CheckFieldNotNull(objXzSchoolEN.SchoolName, conXzSchool.SchoolName);
clsCheckSql.CheckFieldNotNull(objXzSchoolEN.IsCurrentUse, conXzSchool.IsCurrentUse);
//检查字段长度
clsCheckSql.CheckFieldLen(objXzSchoolEN.IdSchool, 4, conXzSchool.IdSchool);
clsCheckSql.CheckFieldLen(objXzSchoolEN.SchoolId, 20, conXzSchool.SchoolId);
clsCheckSql.CheckFieldLen(objXzSchoolEN.SchoolName, 50, conXzSchool.SchoolName);
clsCheckSql.CheckFieldLen(objXzSchoolEN.SchoolENName, 50, conXzSchool.SchoolENName);
clsCheckSql.CheckFieldLen(objXzSchoolEN.SchoolNameA, 14, conXzSchool.SchoolNameA);
clsCheckSql.CheckFieldLen(objXzSchoolEN.SchoolTypeId, 2, conXzSchool.SchoolTypeId);
clsCheckSql.CheckFieldLen(objXzSchoolEN.UpdDate, 20, conXzSchool.UpdDate);
clsCheckSql.CheckFieldLen(objXzSchoolEN.UpdUserId, 20, conXzSchool.UpdUserId);
clsCheckSql.CheckFieldLen(objXzSchoolEN.Memo, 1000, conXzSchool.Memo);
//检查字段外键固定长度
 objXzSchoolEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsXzSchoolEN objXzSchoolEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objXzSchoolEN.SchoolId, 20, conXzSchool.SchoolId);
clsCheckSql.CheckFieldLen(objXzSchoolEN.SchoolName, 50, conXzSchool.SchoolName);
clsCheckSql.CheckFieldLen(objXzSchoolEN.SchoolENName, 50, conXzSchool.SchoolENName);
clsCheckSql.CheckFieldLen(objXzSchoolEN.SchoolNameA, 14, conXzSchool.SchoolNameA);
clsCheckSql.CheckFieldLen(objXzSchoolEN.SchoolTypeId, 2, conXzSchool.SchoolTypeId);
clsCheckSql.CheckFieldLen(objXzSchoolEN.UpdDate, 20, conXzSchool.UpdDate);
clsCheckSql.CheckFieldLen(objXzSchoolEN.UpdUserId, 20, conXzSchool.UpdUserId);
clsCheckSql.CheckFieldLen(objXzSchoolEN.Memo, 1000, conXzSchool.Memo);
//检查外键字段长度
 objXzSchoolEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsXzSchoolEN objXzSchoolEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objXzSchoolEN.IdSchool, 4, conXzSchool.IdSchool);
clsCheckSql.CheckFieldLen(objXzSchoolEN.SchoolId, 20, conXzSchool.SchoolId);
clsCheckSql.CheckFieldLen(objXzSchoolEN.SchoolName, 50, conXzSchool.SchoolName);
clsCheckSql.CheckFieldLen(objXzSchoolEN.SchoolENName, 50, conXzSchool.SchoolENName);
clsCheckSql.CheckFieldLen(objXzSchoolEN.SchoolNameA, 14, conXzSchool.SchoolNameA);
clsCheckSql.CheckFieldLen(objXzSchoolEN.SchoolTypeId, 2, conXzSchool.SchoolTypeId);
clsCheckSql.CheckFieldLen(objXzSchoolEN.UpdDate, 20, conXzSchool.UpdDate);
clsCheckSql.CheckFieldLen(objXzSchoolEN.UpdUserId, 20, conXzSchool.UpdUserId);
clsCheckSql.CheckFieldLen(objXzSchoolEN.Memo, 1000, conXzSchool.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objXzSchoolEN.IdSchool, conXzSchool.IdSchool);
clsCheckSql.CheckSqlInjection4Field(objXzSchoolEN.SchoolId, conXzSchool.SchoolId);
clsCheckSql.CheckSqlInjection4Field(objXzSchoolEN.SchoolName, conXzSchool.SchoolName);
clsCheckSql.CheckSqlInjection4Field(objXzSchoolEN.SchoolENName, conXzSchool.SchoolENName);
clsCheckSql.CheckSqlInjection4Field(objXzSchoolEN.SchoolNameA, conXzSchool.SchoolNameA);
clsCheckSql.CheckSqlInjection4Field(objXzSchoolEN.SchoolTypeId, conXzSchool.SchoolTypeId);
clsCheckSql.CheckSqlInjection4Field(objXzSchoolEN.UpdDate, conXzSchool.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objXzSchoolEN.UpdUserId, conXzSchool.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objXzSchoolEN.Memo, conXzSchool.Memo);
//检查外键字段长度
 objXzSchoolEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetIdSchool()
{
//获取某学院所有专业信息
string strSQL = "select IdSchool, SchoolName from XzSchool ";
 clsSpecSQLforSql mySql = clsXzSchoolDA.GetSpecSQLObj();
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
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
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
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
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
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsXzSchoolEN._CurrTabName);
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
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsXzSchoolEN._CurrTabName, strCondition);
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
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
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
 objSQL = clsXzSchoolDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}