
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFeatureButtonRelaDA
 表名:vFeatureButtonRela(00050428)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:01:03
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:函数管理(PrjFunction)
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
 /// v功能按钮关系(vFeatureButtonRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvFeatureButtonRelaDA : clsCommBase4DA
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
 return clsvFeatureButtonRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvFeatureButtonRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvFeatureButtonRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvFeatureButtonRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvFeatureButtonRelaEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvFeatureButtonRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureButtonRelaDA.GetSpecSQLObj();
strSQL = "Select * from vFeatureButtonRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vFeatureButtonRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvFeatureButtonRelaDA: GetDataTable_vFeatureButtonRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureButtonRelaDA.GetSpecSQLObj();
strSQL = "Select * from vFeatureButtonRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvFeatureButtonRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureButtonRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvFeatureButtonRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureButtonRelaDA.GetSpecSQLObj();
strSQL = "Select * from vFeatureButtonRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvFeatureButtonRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureButtonRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvFeatureButtonRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureButtonRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFeatureButtonRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFeatureButtonRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvFeatureButtonRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureButtonRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vFeatureButtonRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvFeatureButtonRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureButtonRelaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vFeatureButtonRela.* " + 
$"from vFeatureButtonRela " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vFeatureButtonRela.mId not in " + 
$"(Select top {intTop_In} vFeatureButtonRela.mId from vFeatureButtonRela " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFeatureButtonRela where {1} and mId not in (Select top {2} mId from vFeatureButtonRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFeatureButtonRela where {1} and mId not in (Select top {3} mId from vFeatureButtonRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvFeatureButtonRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureButtonRelaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vFeatureButtonRela.* " + 
$"from vFeatureButtonRela " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vFeatureButtonRela.mId not in " + 
$"(Select top {intTop_In} vFeatureButtonRela.mId from vFeatureButtonRela " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFeatureButtonRela where {1} and mId not in (Select top {2} mId from vFeatureButtonRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFeatureButtonRela where {1} and mId not in (Select top {3} mId from vFeatureButtonRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvFeatureButtonRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvFeatureButtonRelaDA:GetObjLst)", objException.Message));
}
List<clsvFeatureButtonRelaEN> arrObjLst = new List<clsvFeatureButtonRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureButtonRelaDA.GetSpecSQLObj();
strSQL = "Select * from vFeatureButtonRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureButtonRelaEN objvFeatureButtonRelaEN = new clsvFeatureButtonRelaEN();
try
{
objvFeatureButtonRelaEN.mId = TransNullToInt(objRow[convFeatureButtonRela.mId].ToString().Trim()); //mId
objvFeatureButtonRelaEN.ApplicationTypeId = TransNullToInt(objRow[convFeatureButtonRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFeatureButtonRelaEN.ApplicationTypeName = objRow[convFeatureButtonRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvFeatureButtonRelaEN.ApplicationTypeENName = objRow[convFeatureButtonRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvFeatureButtonRelaEN.FeatureId = objRow[convFeatureButtonRela.FeatureId].ToString().Trim(); //功能Id
objvFeatureButtonRelaEN.FeatureName = objRow[convFeatureButtonRela.FeatureName].ToString().Trim(); //功能名称
objvFeatureButtonRelaEN.FeatureTypeName = objRow[convFeatureButtonRela.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureButtonRelaEN.ButtonId = objRow[convFeatureButtonRela.ButtonId].ToString().Trim(); //按钮Id
objvFeatureButtonRelaEN.ButtonName = objRow[convFeatureButtonRela.ButtonName].ToString().Trim(); //按钮名称
objvFeatureButtonRelaEN.Text = objRow[convFeatureButtonRela.Text].ToString().Trim(); //文本
objvFeatureButtonRelaEN.OrderNum = TransNullToInt(objRow[convFeatureButtonRela.OrderNum].ToString().Trim()); //序号
objvFeatureButtonRelaEN.EventFuncName = objRow[convFeatureButtonRela.EventFuncName] == DBNull.Value ? null : objRow[convFeatureButtonRela.EventFuncName].ToString().Trim(); //事件函数名
objvFeatureButtonRelaEN.UpdDate = objRow[convFeatureButtonRela.UpdDate] == DBNull.Value ? null : objRow[convFeatureButtonRela.UpdDate].ToString().Trim(); //修改日期
objvFeatureButtonRelaEN.UpdUser = objRow[convFeatureButtonRela.UpdUser] == DBNull.Value ? null : objRow[convFeatureButtonRela.UpdUser].ToString().Trim(); //修改者
objvFeatureButtonRelaEN.Memo = objRow[convFeatureButtonRela.Memo] == DBNull.Value ? null : objRow[convFeatureButtonRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvFeatureButtonRelaDA: GetObjLst)", objException.Message));
}
objvFeatureButtonRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvFeatureButtonRelaEN);
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
public List<clsvFeatureButtonRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvFeatureButtonRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsvFeatureButtonRelaEN> arrObjLst = new List<clsvFeatureButtonRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureButtonRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureButtonRelaEN objvFeatureButtonRelaEN = new clsvFeatureButtonRelaEN();
try
{
objvFeatureButtonRelaEN.mId = TransNullToInt(objRow[convFeatureButtonRela.mId].ToString().Trim()); //mId
objvFeatureButtonRelaEN.ApplicationTypeId = TransNullToInt(objRow[convFeatureButtonRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFeatureButtonRelaEN.ApplicationTypeName = objRow[convFeatureButtonRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvFeatureButtonRelaEN.ApplicationTypeENName = objRow[convFeatureButtonRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvFeatureButtonRelaEN.FeatureId = objRow[convFeatureButtonRela.FeatureId].ToString().Trim(); //功能Id
objvFeatureButtonRelaEN.FeatureName = objRow[convFeatureButtonRela.FeatureName].ToString().Trim(); //功能名称
objvFeatureButtonRelaEN.FeatureTypeName = objRow[convFeatureButtonRela.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureButtonRelaEN.ButtonId = objRow[convFeatureButtonRela.ButtonId].ToString().Trim(); //按钮Id
objvFeatureButtonRelaEN.ButtonName = objRow[convFeatureButtonRela.ButtonName].ToString().Trim(); //按钮名称
objvFeatureButtonRelaEN.Text = objRow[convFeatureButtonRela.Text].ToString().Trim(); //文本
objvFeatureButtonRelaEN.OrderNum = TransNullToInt(objRow[convFeatureButtonRela.OrderNum].ToString().Trim()); //序号
objvFeatureButtonRelaEN.EventFuncName = objRow[convFeatureButtonRela.EventFuncName] == DBNull.Value ? null : objRow[convFeatureButtonRela.EventFuncName].ToString().Trim(); //事件函数名
objvFeatureButtonRelaEN.UpdDate = objRow[convFeatureButtonRela.UpdDate] == DBNull.Value ? null : objRow[convFeatureButtonRela.UpdDate].ToString().Trim(); //修改日期
objvFeatureButtonRelaEN.UpdUser = objRow[convFeatureButtonRela.UpdUser] == DBNull.Value ? null : objRow[convFeatureButtonRela.UpdUser].ToString().Trim(); //修改者
objvFeatureButtonRelaEN.Memo = objRow[convFeatureButtonRela.Memo] == DBNull.Value ? null : objRow[convFeatureButtonRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvFeatureButtonRelaDA: GetObjLst)", objException.Message));
}
objvFeatureButtonRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvFeatureButtonRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvFeatureButtonRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvFeatureButtonRela(ref clsvFeatureButtonRelaEN objvFeatureButtonRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureButtonRelaDA.GetSpecSQLObj();
strSQL = "Select * from vFeatureButtonRela where mId = " + ""+ objvFeatureButtonRelaEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvFeatureButtonRelaEN.mId = TransNullToInt(objDT.Rows[0][convFeatureButtonRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvFeatureButtonRelaEN.ApplicationTypeId = TransNullToInt(objDT.Rows[0][convFeatureButtonRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objvFeatureButtonRelaEN.ApplicationTypeName = objDT.Rows[0][convFeatureButtonRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvFeatureButtonRelaEN.ApplicationTypeENName = objDT.Rows[0][convFeatureButtonRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名(字段类型:varchar,字段长度:30,是否可空:False)
 objvFeatureButtonRelaEN.FeatureId = objDT.Rows[0][convFeatureButtonRela.FeatureId].ToString().Trim(); //功能Id(字段类型:char,字段长度:4,是否可空:False)
 objvFeatureButtonRelaEN.FeatureName = objDT.Rows[0][convFeatureButtonRela.FeatureName].ToString().Trim(); //功能名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvFeatureButtonRelaEN.FeatureTypeName = objDT.Rows[0][convFeatureButtonRela.FeatureTypeName].ToString().Trim(); //功能类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvFeatureButtonRelaEN.ButtonId = objDT.Rows[0][convFeatureButtonRela.ButtonId].ToString().Trim(); //按钮Id(字段类型:char,字段长度:2,是否可空:False)
 objvFeatureButtonRelaEN.ButtonName = objDT.Rows[0][convFeatureButtonRela.ButtonName].ToString().Trim(); //按钮名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvFeatureButtonRelaEN.Text = objDT.Rows[0][convFeatureButtonRela.Text].ToString().Trim(); //文本(字段类型:varchar,字段长度:30,是否可空:False)
 objvFeatureButtonRelaEN.OrderNum = TransNullToInt(objDT.Rows[0][convFeatureButtonRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvFeatureButtonRelaEN.EventFuncName = objDT.Rows[0][convFeatureButtonRela.EventFuncName].ToString().Trim(); //事件函数名(字段类型:varchar,字段长度:50,是否可空:True)
 objvFeatureButtonRelaEN.UpdDate = objDT.Rows[0][convFeatureButtonRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvFeatureButtonRelaEN.UpdUser = objDT.Rows[0][convFeatureButtonRela.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvFeatureButtonRelaEN.Memo = objDT.Rows[0][convFeatureButtonRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvFeatureButtonRelaDA: GetvFeatureButtonRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvFeatureButtonRelaEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureButtonRelaDA.GetSpecSQLObj();
strSQL = "Select * from vFeatureButtonRela where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvFeatureButtonRelaEN objvFeatureButtonRelaEN = new clsvFeatureButtonRelaEN();
try
{
 objvFeatureButtonRelaEN.mId = Int32.Parse(objRow[convFeatureButtonRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvFeatureButtonRelaEN.ApplicationTypeId = Int32.Parse(objRow[convFeatureButtonRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objvFeatureButtonRelaEN.ApplicationTypeName = objRow[convFeatureButtonRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvFeatureButtonRelaEN.ApplicationTypeENName = objRow[convFeatureButtonRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名(字段类型:varchar,字段长度:30,是否可空:False)
 objvFeatureButtonRelaEN.FeatureId = objRow[convFeatureButtonRela.FeatureId].ToString().Trim(); //功能Id(字段类型:char,字段长度:4,是否可空:False)
 objvFeatureButtonRelaEN.FeatureName = objRow[convFeatureButtonRela.FeatureName].ToString().Trim(); //功能名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvFeatureButtonRelaEN.FeatureTypeName = objRow[convFeatureButtonRela.FeatureTypeName].ToString().Trim(); //功能类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvFeatureButtonRelaEN.ButtonId = objRow[convFeatureButtonRela.ButtonId].ToString().Trim(); //按钮Id(字段类型:char,字段长度:2,是否可空:False)
 objvFeatureButtonRelaEN.ButtonName = objRow[convFeatureButtonRela.ButtonName].ToString().Trim(); //按钮名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvFeatureButtonRelaEN.Text = objRow[convFeatureButtonRela.Text].ToString().Trim(); //文本(字段类型:varchar,字段长度:30,是否可空:False)
 objvFeatureButtonRelaEN.OrderNum = Int32.Parse(objRow[convFeatureButtonRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvFeatureButtonRelaEN.EventFuncName = objRow[convFeatureButtonRela.EventFuncName] == DBNull.Value ? null : objRow[convFeatureButtonRela.EventFuncName].ToString().Trim(); //事件函数名(字段类型:varchar,字段长度:50,是否可空:True)
 objvFeatureButtonRelaEN.UpdDate = objRow[convFeatureButtonRela.UpdDate] == DBNull.Value ? null : objRow[convFeatureButtonRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvFeatureButtonRelaEN.UpdUser = objRow[convFeatureButtonRela.UpdUser] == DBNull.Value ? null : objRow[convFeatureButtonRela.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvFeatureButtonRelaEN.Memo = objRow[convFeatureButtonRela.Memo] == DBNull.Value ? null : objRow[convFeatureButtonRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvFeatureButtonRelaDA: GetObjBymId)", objException.Message));
}
return objvFeatureButtonRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvFeatureButtonRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvFeatureButtonRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureButtonRelaDA.GetSpecSQLObj();
strSQL = "Select * from vFeatureButtonRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvFeatureButtonRelaEN objvFeatureButtonRelaEN = new clsvFeatureButtonRelaEN()
{
mId = TransNullToInt(objRow[convFeatureButtonRela.mId].ToString().Trim()), //mId
ApplicationTypeId = TransNullToInt(objRow[convFeatureButtonRela.ApplicationTypeId].ToString().Trim()), //应用程序类型ID
ApplicationTypeName = objRow[convFeatureButtonRela.ApplicationTypeName].ToString().Trim(), //应用程序类型名称
ApplicationTypeENName = objRow[convFeatureButtonRela.ApplicationTypeENName].ToString().Trim(), //应用类型英文名
FeatureId = objRow[convFeatureButtonRela.FeatureId].ToString().Trim(), //功能Id
FeatureName = objRow[convFeatureButtonRela.FeatureName].ToString().Trim(), //功能名称
FeatureTypeName = objRow[convFeatureButtonRela.FeatureTypeName].ToString().Trim(), //功能类型名称
ButtonId = objRow[convFeatureButtonRela.ButtonId].ToString().Trim(), //按钮Id
ButtonName = objRow[convFeatureButtonRela.ButtonName].ToString().Trim(), //按钮名称
Text = objRow[convFeatureButtonRela.Text].ToString().Trim(), //文本
OrderNum = TransNullToInt(objRow[convFeatureButtonRela.OrderNum].ToString().Trim()), //序号
EventFuncName = objRow[convFeatureButtonRela.EventFuncName] == DBNull.Value ? null : objRow[convFeatureButtonRela.EventFuncName].ToString().Trim(), //事件函数名
UpdDate = objRow[convFeatureButtonRela.UpdDate] == DBNull.Value ? null : objRow[convFeatureButtonRela.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convFeatureButtonRela.UpdUser] == DBNull.Value ? null : objRow[convFeatureButtonRela.UpdUser].ToString().Trim(), //修改者
Memo = objRow[convFeatureButtonRela.Memo] == DBNull.Value ? null : objRow[convFeatureButtonRela.Memo].ToString().Trim() //说明
};
objvFeatureButtonRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFeatureButtonRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvFeatureButtonRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvFeatureButtonRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvFeatureButtonRelaEN objvFeatureButtonRelaEN = new clsvFeatureButtonRelaEN();
try
{
objvFeatureButtonRelaEN.mId = TransNullToInt(objRow[convFeatureButtonRela.mId].ToString().Trim()); //mId
objvFeatureButtonRelaEN.ApplicationTypeId = TransNullToInt(objRow[convFeatureButtonRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFeatureButtonRelaEN.ApplicationTypeName = objRow[convFeatureButtonRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvFeatureButtonRelaEN.ApplicationTypeENName = objRow[convFeatureButtonRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvFeatureButtonRelaEN.FeatureId = objRow[convFeatureButtonRela.FeatureId].ToString().Trim(); //功能Id
objvFeatureButtonRelaEN.FeatureName = objRow[convFeatureButtonRela.FeatureName].ToString().Trim(); //功能名称
objvFeatureButtonRelaEN.FeatureTypeName = objRow[convFeatureButtonRela.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureButtonRelaEN.ButtonId = objRow[convFeatureButtonRela.ButtonId].ToString().Trim(); //按钮Id
objvFeatureButtonRelaEN.ButtonName = objRow[convFeatureButtonRela.ButtonName].ToString().Trim(); //按钮名称
objvFeatureButtonRelaEN.Text = objRow[convFeatureButtonRela.Text].ToString().Trim(); //文本
objvFeatureButtonRelaEN.OrderNum = TransNullToInt(objRow[convFeatureButtonRela.OrderNum].ToString().Trim()); //序号
objvFeatureButtonRelaEN.EventFuncName = objRow[convFeatureButtonRela.EventFuncName] == DBNull.Value ? null : objRow[convFeatureButtonRela.EventFuncName].ToString().Trim(); //事件函数名
objvFeatureButtonRelaEN.UpdDate = objRow[convFeatureButtonRela.UpdDate] == DBNull.Value ? null : objRow[convFeatureButtonRela.UpdDate].ToString().Trim(); //修改日期
objvFeatureButtonRelaEN.UpdUser = objRow[convFeatureButtonRela.UpdUser] == DBNull.Value ? null : objRow[convFeatureButtonRela.UpdUser].ToString().Trim(); //修改者
objvFeatureButtonRelaEN.Memo = objRow[convFeatureButtonRela.Memo] == DBNull.Value ? null : objRow[convFeatureButtonRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvFeatureButtonRelaDA: GetObjByDataRowvFeatureButtonRela)", objException.Message));
}
objvFeatureButtonRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFeatureButtonRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvFeatureButtonRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvFeatureButtonRelaEN objvFeatureButtonRelaEN = new clsvFeatureButtonRelaEN();
try
{
objvFeatureButtonRelaEN.mId = TransNullToInt(objRow[convFeatureButtonRela.mId].ToString().Trim()); //mId
objvFeatureButtonRelaEN.ApplicationTypeId = TransNullToInt(objRow[convFeatureButtonRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFeatureButtonRelaEN.ApplicationTypeName = objRow[convFeatureButtonRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvFeatureButtonRelaEN.ApplicationTypeENName = objRow[convFeatureButtonRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvFeatureButtonRelaEN.FeatureId = objRow[convFeatureButtonRela.FeatureId].ToString().Trim(); //功能Id
objvFeatureButtonRelaEN.FeatureName = objRow[convFeatureButtonRela.FeatureName].ToString().Trim(); //功能名称
objvFeatureButtonRelaEN.FeatureTypeName = objRow[convFeatureButtonRela.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureButtonRelaEN.ButtonId = objRow[convFeatureButtonRela.ButtonId].ToString().Trim(); //按钮Id
objvFeatureButtonRelaEN.ButtonName = objRow[convFeatureButtonRela.ButtonName].ToString().Trim(); //按钮名称
objvFeatureButtonRelaEN.Text = objRow[convFeatureButtonRela.Text].ToString().Trim(); //文本
objvFeatureButtonRelaEN.OrderNum = TransNullToInt(objRow[convFeatureButtonRela.OrderNum].ToString().Trim()); //序号
objvFeatureButtonRelaEN.EventFuncName = objRow[convFeatureButtonRela.EventFuncName] == DBNull.Value ? null : objRow[convFeatureButtonRela.EventFuncName].ToString().Trim(); //事件函数名
objvFeatureButtonRelaEN.UpdDate = objRow[convFeatureButtonRela.UpdDate] == DBNull.Value ? null : objRow[convFeatureButtonRela.UpdDate].ToString().Trim(); //修改日期
objvFeatureButtonRelaEN.UpdUser = objRow[convFeatureButtonRela.UpdUser] == DBNull.Value ? null : objRow[convFeatureButtonRela.UpdUser].ToString().Trim(); //修改者
objvFeatureButtonRelaEN.Memo = objRow[convFeatureButtonRela.Memo] == DBNull.Value ? null : objRow[convFeatureButtonRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvFeatureButtonRelaDA: GetObjByDataRow)", objException.Message));
}
objvFeatureButtonRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFeatureButtonRelaEN;
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
objSQL = clsvFeatureButtonRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvFeatureButtonRelaEN._CurrTabName, convFeatureButtonRela.mId, 8, "");
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
objSQL = clsvFeatureButtonRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvFeatureButtonRelaEN._CurrTabName, convFeatureButtonRela.mId, 8, strPrefix);
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
 objSQL = clsvFeatureButtonRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vFeatureButtonRela where " + strCondition;
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
 objSQL = clsvFeatureButtonRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vFeatureButtonRela where " + strCondition;
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
 objSQL = clsvFeatureButtonRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vFeatureButtonRela", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvFeatureButtonRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureButtonRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vFeatureButtonRela", strCondition))
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
objSQL = clsvFeatureButtonRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vFeatureButtonRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvFeatureButtonRelaENS">源对象</param>
 /// <param name = "objvFeatureButtonRelaENT">目标对象</param>
public void CopyTo(clsvFeatureButtonRelaEN objvFeatureButtonRelaENS, clsvFeatureButtonRelaEN objvFeatureButtonRelaENT)
{
objvFeatureButtonRelaENT.mId = objvFeatureButtonRelaENS.mId; //mId
objvFeatureButtonRelaENT.ApplicationTypeId = objvFeatureButtonRelaENS.ApplicationTypeId; //应用程序类型ID
objvFeatureButtonRelaENT.ApplicationTypeName = objvFeatureButtonRelaENS.ApplicationTypeName; //应用程序类型名称
objvFeatureButtonRelaENT.ApplicationTypeENName = objvFeatureButtonRelaENS.ApplicationTypeENName; //应用类型英文名
objvFeatureButtonRelaENT.FeatureId = objvFeatureButtonRelaENS.FeatureId; //功能Id
objvFeatureButtonRelaENT.FeatureName = objvFeatureButtonRelaENS.FeatureName; //功能名称
objvFeatureButtonRelaENT.FeatureTypeName = objvFeatureButtonRelaENS.FeatureTypeName; //功能类型名称
objvFeatureButtonRelaENT.ButtonId = objvFeatureButtonRelaENS.ButtonId; //按钮Id
objvFeatureButtonRelaENT.ButtonName = objvFeatureButtonRelaENS.ButtonName; //按钮名称
objvFeatureButtonRelaENT.Text = objvFeatureButtonRelaENS.Text; //文本
objvFeatureButtonRelaENT.OrderNum = objvFeatureButtonRelaENS.OrderNum; //序号
objvFeatureButtonRelaENT.EventFuncName = objvFeatureButtonRelaENS.EventFuncName; //事件函数名
objvFeatureButtonRelaENT.UpdDate = objvFeatureButtonRelaENS.UpdDate; //修改日期
objvFeatureButtonRelaENT.UpdUser = objvFeatureButtonRelaENS.UpdUser; //修改者
objvFeatureButtonRelaENT.Memo = objvFeatureButtonRelaENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvFeatureButtonRelaEN objvFeatureButtonRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvFeatureButtonRelaEN.ApplicationTypeName, 30, convFeatureButtonRela.ApplicationTypeName);
clsCheckSql.CheckFieldLen(objvFeatureButtonRelaEN.ApplicationTypeENName, 30, convFeatureButtonRela.ApplicationTypeENName);
clsCheckSql.CheckFieldLen(objvFeatureButtonRelaEN.FeatureId, 4, convFeatureButtonRela.FeatureId);
clsCheckSql.CheckFieldLen(objvFeatureButtonRelaEN.FeatureName, 100, convFeatureButtonRela.FeatureName);
clsCheckSql.CheckFieldLen(objvFeatureButtonRelaEN.FeatureTypeName, 30, convFeatureButtonRela.FeatureTypeName);
clsCheckSql.CheckFieldLen(objvFeatureButtonRelaEN.ButtonId, 2, convFeatureButtonRela.ButtonId);
clsCheckSql.CheckFieldLen(objvFeatureButtonRelaEN.ButtonName, 30, convFeatureButtonRela.ButtonName);
clsCheckSql.CheckFieldLen(objvFeatureButtonRelaEN.Text, 30, convFeatureButtonRela.Text);
clsCheckSql.CheckFieldLen(objvFeatureButtonRelaEN.EventFuncName, 50, convFeatureButtonRela.EventFuncName);
clsCheckSql.CheckFieldLen(objvFeatureButtonRelaEN.UpdDate, 20, convFeatureButtonRela.UpdDate);
clsCheckSql.CheckFieldLen(objvFeatureButtonRelaEN.UpdUser, 20, convFeatureButtonRela.UpdUser);
clsCheckSql.CheckFieldLen(objvFeatureButtonRelaEN.Memo, 1000, convFeatureButtonRela.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvFeatureButtonRelaEN.ApplicationTypeName, convFeatureButtonRela.ApplicationTypeName);
clsCheckSql.CheckSqlInjection4Field(objvFeatureButtonRelaEN.ApplicationTypeENName, convFeatureButtonRela.ApplicationTypeENName);
clsCheckSql.CheckSqlInjection4Field(objvFeatureButtonRelaEN.FeatureId, convFeatureButtonRela.FeatureId);
clsCheckSql.CheckSqlInjection4Field(objvFeatureButtonRelaEN.FeatureName, convFeatureButtonRela.FeatureName);
clsCheckSql.CheckSqlInjection4Field(objvFeatureButtonRelaEN.FeatureTypeName, convFeatureButtonRela.FeatureTypeName);
clsCheckSql.CheckSqlInjection4Field(objvFeatureButtonRelaEN.ButtonId, convFeatureButtonRela.ButtonId);
clsCheckSql.CheckSqlInjection4Field(objvFeatureButtonRelaEN.ButtonName, convFeatureButtonRela.ButtonName);
clsCheckSql.CheckSqlInjection4Field(objvFeatureButtonRelaEN.Text, convFeatureButtonRela.Text);
clsCheckSql.CheckSqlInjection4Field(objvFeatureButtonRelaEN.EventFuncName, convFeatureButtonRela.EventFuncName);
clsCheckSql.CheckSqlInjection4Field(objvFeatureButtonRelaEN.UpdDate, convFeatureButtonRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvFeatureButtonRelaEN.UpdUser, convFeatureButtonRela.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvFeatureButtonRelaEN.Memo, convFeatureButtonRela.Memo);
//检查外键字段长度
 objvFeatureButtonRelaEN._IsCheckProperty = true;
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
 objSQL = clsvFeatureButtonRelaDA.GetSpecSQLObj();
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
 objSQL = clsvFeatureButtonRelaDA.GetSpecSQLObj();
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
 objSQL = clsvFeatureButtonRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvFeatureButtonRelaEN._CurrTabName);
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
 objSQL = clsvFeatureButtonRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvFeatureButtonRelaEN._CurrTabName, strCondition);
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
 objSQL = clsvFeatureButtonRelaDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}