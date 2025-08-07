
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCMFeatureDA
 表名:CMFeature(00050517)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:33:53
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:代码管理(CodeMan)
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
 /// CM功能(CMFeature)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsCMFeatureDA : clsCommBase4DA
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
 return clsCMFeatureEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsCMFeatureEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCMFeatureEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsCMFeatureEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsCMFeatureEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strCmFeatureId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strCmFeatureId)
{
strCmFeatureId = strCmFeatureId.Replace("'", "''");
if (strCmFeatureId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:CMFeature中,检查关键字,长度不正确!(clsCMFeatureDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strCmFeatureId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:CMFeature中,关键字不能为空 或 null!(clsCMFeatureDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCmFeatureId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsCMFeatureDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsCMFeatureDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureDA.GetSpecSQLObj();
strSQL = "Select * from CMFeature where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_CMFeature(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsCMFeatureDA: GetDataTable_CMFeature)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureDA.GetSpecSQLObj();
strSQL = "Select * from CMFeature where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsCMFeatureDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsCMFeatureDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureDA.GetSpecSQLObj();
strSQL = "Select * from CMFeature where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsCMFeatureDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsCMFeatureDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CMFeature where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CMFeature where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsCMFeatureDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from CMFeature where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsCMFeatureDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} CMFeature.* " + 
$"from CMFeature " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and CMFeature.CmFeatureId not in " + 
$"(Select top {intTop_In} CMFeature.CmFeatureId from CMFeature " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CMFeature where {1} and CmFeatureId not in (Select top {2} CmFeatureId from CMFeature where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CMFeature where {1} and CmFeatureId not in (Select top {3} CmFeatureId from CMFeature where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsCMFeatureDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} CMFeature.* " + 
$"from CMFeature " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and CMFeature.CmFeatureId not in " + 
$"(Select top {intTop_In} CMFeature.CmFeatureId from CMFeature " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CMFeature where {1} and CmFeatureId not in (Select top {2} CmFeatureId from CMFeature where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CMFeature where {1} and CmFeatureId not in (Select top {3} CmFeatureId from CMFeature where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsCMFeatureEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsCMFeatureDA:GetObjLst)", objException.Message));
}
List<clsCMFeatureEN> arrObjLst = new List<clsCMFeatureEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureDA.GetSpecSQLObj();
strSQL = "Select * from CMFeature where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMFeatureEN objCMFeatureEN = new clsCMFeatureEN();
try
{
objCMFeatureEN.CmFeatureId = objRow[conCMFeature.CmFeatureId].ToString().Trim(); //功能Id
objCMFeatureEN.FeatureName = objRow[conCMFeature.FeatureName].ToString().Trim(); //功能名称
objCMFeatureEN.FeatureENName = objRow[conCMFeature.FeatureENName] == DBNull.Value ? null : objRow[conCMFeature.FeatureENName].ToString().Trim(); //功能英文名
objCMFeatureEN.KeyWords = objRow[conCMFeature.KeyWords] == DBNull.Value ? null : objRow[conCMFeature.KeyWords].ToString().Trim(); //关键字
objCMFeatureEN.FeatureDescription = objRow[conCMFeature.FeatureDescription] == DBNull.Value ? null : objRow[conCMFeature.FeatureDescription].ToString().Trim(); //功能说明
objCMFeatureEN.CmParentFeatureId = objRow[conCMFeature.CmParentFeatureId] == DBNull.Value ? null : objRow[conCMFeature.CmParentFeatureId].ToString().Trim(); //父功能Id
objCMFeatureEN.ParentFeatureName = objRow[conCMFeature.ParentFeatureName] == DBNull.Value ? null : objRow[conCMFeature.ParentFeatureName].ToString().Trim(); //父功能名
objCMFeatureEN.CmFeatureTypeId = objRow[conCMFeature.CmFeatureTypeId].ToString().Trim(); //功能类型Id
objCMFeatureEN.CreateUserId = objRow[conCMFeature.CreateUserId].ToString().Trim(); //建立用户Id
objCMFeatureEN.InUse = TransNullToBool(objRow[conCMFeature.InUse].ToString().Trim()); //是否在用
objCMFeatureEN.OrderNum = TransNullToInt(objRow[conCMFeature.OrderNum].ToString().Trim()); //序号
objCMFeatureEN.FuncModuleAgcId = objRow[conCMFeature.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objCMFeatureEN.CmPrjId = objRow[conCMFeature.CmPrjId].ToString().Trim(); //Cm工程Id
objCMFeatureEN.PrjId = objRow[conCMFeature.PrjId].ToString().Trim(); //工程Id
objCMFeatureEN.UpdDate = objRow[conCMFeature.UpdDate] == DBNull.Value ? null : objRow[conCMFeature.UpdDate].ToString().Trim(); //修改日期
objCMFeatureEN.UpdUser = objRow[conCMFeature.UpdUser] == DBNull.Value ? null : objRow[conCMFeature.UpdUser].ToString().Trim(); //修改者
objCMFeatureEN.Memo = objRow[conCMFeature.Memo] == DBNull.Value ? null : objRow[conCMFeature.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCMFeatureDA: GetObjLst)", objException.Message));
}
objCMFeatureEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCMFeatureEN);
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
public List<clsCMFeatureEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsCMFeatureDA:GetObjLstByTabName)", objException.Message));
}
List<clsCMFeatureEN> arrObjLst = new List<clsCMFeatureEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMFeatureEN objCMFeatureEN = new clsCMFeatureEN();
try
{
objCMFeatureEN.CmFeatureId = objRow[conCMFeature.CmFeatureId].ToString().Trim(); //功能Id
objCMFeatureEN.FeatureName = objRow[conCMFeature.FeatureName].ToString().Trim(); //功能名称
objCMFeatureEN.FeatureENName = objRow[conCMFeature.FeatureENName] == DBNull.Value ? null : objRow[conCMFeature.FeatureENName].ToString().Trim(); //功能英文名
objCMFeatureEN.KeyWords = objRow[conCMFeature.KeyWords] == DBNull.Value ? null : objRow[conCMFeature.KeyWords].ToString().Trim(); //关键字
objCMFeatureEN.FeatureDescription = objRow[conCMFeature.FeatureDescription] == DBNull.Value ? null : objRow[conCMFeature.FeatureDescription].ToString().Trim(); //功能说明
objCMFeatureEN.CmParentFeatureId = objRow[conCMFeature.CmParentFeatureId] == DBNull.Value ? null : objRow[conCMFeature.CmParentFeatureId].ToString().Trim(); //父功能Id
objCMFeatureEN.ParentFeatureName = objRow[conCMFeature.ParentFeatureName] == DBNull.Value ? null : objRow[conCMFeature.ParentFeatureName].ToString().Trim(); //父功能名
objCMFeatureEN.CmFeatureTypeId = objRow[conCMFeature.CmFeatureTypeId].ToString().Trim(); //功能类型Id
objCMFeatureEN.CreateUserId = objRow[conCMFeature.CreateUserId].ToString().Trim(); //建立用户Id
objCMFeatureEN.InUse = TransNullToBool(objRow[conCMFeature.InUse].ToString().Trim()); //是否在用
objCMFeatureEN.OrderNum = TransNullToInt(objRow[conCMFeature.OrderNum].ToString().Trim()); //序号
objCMFeatureEN.FuncModuleAgcId = objRow[conCMFeature.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objCMFeatureEN.CmPrjId = objRow[conCMFeature.CmPrjId].ToString().Trim(); //Cm工程Id
objCMFeatureEN.PrjId = objRow[conCMFeature.PrjId].ToString().Trim(); //工程Id
objCMFeatureEN.UpdDate = objRow[conCMFeature.UpdDate] == DBNull.Value ? null : objRow[conCMFeature.UpdDate].ToString().Trim(); //修改日期
objCMFeatureEN.UpdUser = objRow[conCMFeature.UpdUser] == DBNull.Value ? null : objRow[conCMFeature.UpdUser].ToString().Trim(); //修改者
objCMFeatureEN.Memo = objRow[conCMFeature.Memo] == DBNull.Value ? null : objRow[conCMFeature.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCMFeatureDA: GetObjLst)", objException.Message));
}
objCMFeatureEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCMFeatureEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objCMFeatureEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetCMFeature(ref clsCMFeatureEN objCMFeatureEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureDA.GetSpecSQLObj();
strSQL = "Select * from CMFeature where CmFeatureId = " + "'"+ objCMFeatureEN.CmFeatureId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objCMFeatureEN.CmFeatureId = objDT.Rows[0][conCMFeature.CmFeatureId].ToString().Trim(); //功能Id(字段类型:char,字段长度:8,是否可空:False)
 objCMFeatureEN.FeatureName = objDT.Rows[0][conCMFeature.FeatureName].ToString().Trim(); //功能名称(字段类型:varchar,字段长度:100,是否可空:False)
 objCMFeatureEN.FeatureENName = objDT.Rows[0][conCMFeature.FeatureENName].ToString().Trim(); //功能英文名(字段类型:varchar,字段长度:100,是否可空:True)
 objCMFeatureEN.KeyWords = objDT.Rows[0][conCMFeature.KeyWords].ToString().Trim(); //关键字(字段类型:varchar,字段长度:500,是否可空:True)
 objCMFeatureEN.FeatureDescription = objDT.Rows[0][conCMFeature.FeatureDescription].ToString().Trim(); //功能说明(字段类型:varchar,字段长度:4000,是否可空:True)
 objCMFeatureEN.CmParentFeatureId = objDT.Rows[0][conCMFeature.CmParentFeatureId].ToString().Trim(); //父功能Id(字段类型:char,字段长度:8,是否可空:False)
 objCMFeatureEN.ParentFeatureName = objDT.Rows[0][conCMFeature.ParentFeatureName].ToString().Trim(); //父功能名(字段类型:varchar,字段长度:500,是否可空:True)
 objCMFeatureEN.CmFeatureTypeId = objDT.Rows[0][conCMFeature.CmFeatureTypeId].ToString().Trim(); //功能类型Id(字段类型:char,字段长度:2,是否可空:False)
 objCMFeatureEN.CreateUserId = objDT.Rows[0][conCMFeature.CreateUserId].ToString().Trim(); //建立用户Id(字段类型:varchar,字段长度:18,是否可空:False)
 objCMFeatureEN.InUse = TransNullToBool(objDT.Rows[0][conCMFeature.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objCMFeatureEN.OrderNum = TransNullToInt(objDT.Rows[0][conCMFeature.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objCMFeatureEN.FuncModuleAgcId = objDT.Rows[0][conCMFeature.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objCMFeatureEN.CmPrjId = objDT.Rows[0][conCMFeature.CmPrjId].ToString().Trim(); //Cm工程Id(字段类型:char,字段长度:6,是否可空:False)
 objCMFeatureEN.PrjId = objDT.Rows[0][conCMFeature.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objCMFeatureEN.UpdDate = objDT.Rows[0][conCMFeature.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCMFeatureEN.UpdUser = objDT.Rows[0][conCMFeature.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objCMFeatureEN.Memo = objDT.Rows[0][conCMFeature.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsCMFeatureDA: GetCMFeature)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCmFeatureId">表关键字</param>
 /// <returns>表对象</returns>
public clsCMFeatureEN GetObjByCmFeatureId(string strCmFeatureId)
{
CheckPrimaryKey(strCmFeatureId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureDA.GetSpecSQLObj();
strSQL = "Select * from CMFeature where CmFeatureId = " + "'"+ strCmFeatureId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsCMFeatureEN objCMFeatureEN = new clsCMFeatureEN();
try
{
 objCMFeatureEN.CmFeatureId = objRow[conCMFeature.CmFeatureId].ToString().Trim(); //功能Id(字段类型:char,字段长度:8,是否可空:False)
 objCMFeatureEN.FeatureName = objRow[conCMFeature.FeatureName].ToString().Trim(); //功能名称(字段类型:varchar,字段长度:100,是否可空:False)
 objCMFeatureEN.FeatureENName = objRow[conCMFeature.FeatureENName] == DBNull.Value ? null : objRow[conCMFeature.FeatureENName].ToString().Trim(); //功能英文名(字段类型:varchar,字段长度:100,是否可空:True)
 objCMFeatureEN.KeyWords = objRow[conCMFeature.KeyWords] == DBNull.Value ? null : objRow[conCMFeature.KeyWords].ToString().Trim(); //关键字(字段类型:varchar,字段长度:500,是否可空:True)
 objCMFeatureEN.FeatureDescription = objRow[conCMFeature.FeatureDescription] == DBNull.Value ? null : objRow[conCMFeature.FeatureDescription].ToString().Trim(); //功能说明(字段类型:varchar,字段长度:4000,是否可空:True)
 objCMFeatureEN.CmParentFeatureId = objRow[conCMFeature.CmParentFeatureId] == DBNull.Value ? null : objRow[conCMFeature.CmParentFeatureId].ToString().Trim(); //父功能Id(字段类型:char,字段长度:8,是否可空:False)
 objCMFeatureEN.ParentFeatureName = objRow[conCMFeature.ParentFeatureName] == DBNull.Value ? null : objRow[conCMFeature.ParentFeatureName].ToString().Trim(); //父功能名(字段类型:varchar,字段长度:500,是否可空:True)
 objCMFeatureEN.CmFeatureTypeId = objRow[conCMFeature.CmFeatureTypeId].ToString().Trim(); //功能类型Id(字段类型:char,字段长度:2,是否可空:False)
 objCMFeatureEN.CreateUserId = objRow[conCMFeature.CreateUserId].ToString().Trim(); //建立用户Id(字段类型:varchar,字段长度:18,是否可空:False)
 objCMFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCMFeature.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objCMFeatureEN.OrderNum = Int32.Parse(objRow[conCMFeature.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objCMFeatureEN.FuncModuleAgcId = objRow[conCMFeature.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objCMFeatureEN.CmPrjId = objRow[conCMFeature.CmPrjId].ToString().Trim(); //Cm工程Id(字段类型:char,字段长度:6,是否可空:False)
 objCMFeatureEN.PrjId = objRow[conCMFeature.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objCMFeatureEN.UpdDate = objRow[conCMFeature.UpdDate] == DBNull.Value ? null : objRow[conCMFeature.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCMFeatureEN.UpdUser = objRow[conCMFeature.UpdUser] == DBNull.Value ? null : objRow[conCMFeature.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objCMFeatureEN.Memo = objRow[conCMFeature.Memo] == DBNull.Value ? null : objRow[conCMFeature.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsCMFeatureDA: GetObjByCmFeatureId)", objException.Message));
}
return objCMFeatureEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsCMFeatureEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsCMFeatureDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureDA.GetSpecSQLObj();
strSQL = "Select * from CMFeature where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsCMFeatureEN objCMFeatureEN = new clsCMFeatureEN()
{
CmFeatureId = objRow[conCMFeature.CmFeatureId].ToString().Trim(), //功能Id
FeatureName = objRow[conCMFeature.FeatureName].ToString().Trim(), //功能名称
FeatureENName = objRow[conCMFeature.FeatureENName] == DBNull.Value ? null : objRow[conCMFeature.FeatureENName].ToString().Trim(), //功能英文名
KeyWords = objRow[conCMFeature.KeyWords] == DBNull.Value ? null : objRow[conCMFeature.KeyWords].ToString().Trim(), //关键字
FeatureDescription = objRow[conCMFeature.FeatureDescription] == DBNull.Value ? null : objRow[conCMFeature.FeatureDescription].ToString().Trim(), //功能说明
CmParentFeatureId = objRow[conCMFeature.CmParentFeatureId] == DBNull.Value ? null : objRow[conCMFeature.CmParentFeatureId].ToString().Trim(), //父功能Id
ParentFeatureName = objRow[conCMFeature.ParentFeatureName] == DBNull.Value ? null : objRow[conCMFeature.ParentFeatureName].ToString().Trim(), //父功能名
CmFeatureTypeId = objRow[conCMFeature.CmFeatureTypeId].ToString().Trim(), //功能类型Id
CreateUserId = objRow[conCMFeature.CreateUserId].ToString().Trim(), //建立用户Id
InUse = TransNullToBool(objRow[conCMFeature.InUse].ToString().Trim()), //是否在用
OrderNum = TransNullToInt(objRow[conCMFeature.OrderNum].ToString().Trim()), //序号
FuncModuleAgcId = objRow[conCMFeature.FuncModuleAgcId].ToString().Trim(), //功能模块Id
CmPrjId = objRow[conCMFeature.CmPrjId].ToString().Trim(), //Cm工程Id
PrjId = objRow[conCMFeature.PrjId].ToString().Trim(), //工程Id
UpdDate = objRow[conCMFeature.UpdDate] == DBNull.Value ? null : objRow[conCMFeature.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conCMFeature.UpdUser] == DBNull.Value ? null : objRow[conCMFeature.UpdUser].ToString().Trim(), //修改者
Memo = objRow[conCMFeature.Memo] == DBNull.Value ? null : objRow[conCMFeature.Memo].ToString().Trim() //说明
};
objCMFeatureEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCMFeatureEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsCMFeatureDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsCMFeatureEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCMFeatureEN objCMFeatureEN = new clsCMFeatureEN();
try
{
objCMFeatureEN.CmFeatureId = objRow[conCMFeature.CmFeatureId].ToString().Trim(); //功能Id
objCMFeatureEN.FeatureName = objRow[conCMFeature.FeatureName].ToString().Trim(); //功能名称
objCMFeatureEN.FeatureENName = objRow[conCMFeature.FeatureENName] == DBNull.Value ? null : objRow[conCMFeature.FeatureENName].ToString().Trim(); //功能英文名
objCMFeatureEN.KeyWords = objRow[conCMFeature.KeyWords] == DBNull.Value ? null : objRow[conCMFeature.KeyWords].ToString().Trim(); //关键字
objCMFeatureEN.FeatureDescription = objRow[conCMFeature.FeatureDescription] == DBNull.Value ? null : objRow[conCMFeature.FeatureDescription].ToString().Trim(); //功能说明
objCMFeatureEN.CmParentFeatureId = objRow[conCMFeature.CmParentFeatureId] == DBNull.Value ? null : objRow[conCMFeature.CmParentFeatureId].ToString().Trim(); //父功能Id
objCMFeatureEN.ParentFeatureName = objRow[conCMFeature.ParentFeatureName] == DBNull.Value ? null : objRow[conCMFeature.ParentFeatureName].ToString().Trim(); //父功能名
objCMFeatureEN.CmFeatureTypeId = objRow[conCMFeature.CmFeatureTypeId].ToString().Trim(); //功能类型Id
objCMFeatureEN.CreateUserId = objRow[conCMFeature.CreateUserId].ToString().Trim(); //建立用户Id
objCMFeatureEN.InUse = TransNullToBool(objRow[conCMFeature.InUse].ToString().Trim()); //是否在用
objCMFeatureEN.OrderNum = TransNullToInt(objRow[conCMFeature.OrderNum].ToString().Trim()); //序号
objCMFeatureEN.FuncModuleAgcId = objRow[conCMFeature.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objCMFeatureEN.CmPrjId = objRow[conCMFeature.CmPrjId].ToString().Trim(); //Cm工程Id
objCMFeatureEN.PrjId = objRow[conCMFeature.PrjId].ToString().Trim(); //工程Id
objCMFeatureEN.UpdDate = objRow[conCMFeature.UpdDate] == DBNull.Value ? null : objRow[conCMFeature.UpdDate].ToString().Trim(); //修改日期
objCMFeatureEN.UpdUser = objRow[conCMFeature.UpdUser] == DBNull.Value ? null : objRow[conCMFeature.UpdUser].ToString().Trim(); //修改者
objCMFeatureEN.Memo = objRow[conCMFeature.Memo] == DBNull.Value ? null : objRow[conCMFeature.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsCMFeatureDA: GetObjByDataRowCMFeature)", objException.Message));
}
objCMFeatureEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCMFeatureEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsCMFeatureEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCMFeatureEN objCMFeatureEN = new clsCMFeatureEN();
try
{
objCMFeatureEN.CmFeatureId = objRow[conCMFeature.CmFeatureId].ToString().Trim(); //功能Id
objCMFeatureEN.FeatureName = objRow[conCMFeature.FeatureName].ToString().Trim(); //功能名称
objCMFeatureEN.FeatureENName = objRow[conCMFeature.FeatureENName] == DBNull.Value ? null : objRow[conCMFeature.FeatureENName].ToString().Trim(); //功能英文名
objCMFeatureEN.KeyWords = objRow[conCMFeature.KeyWords] == DBNull.Value ? null : objRow[conCMFeature.KeyWords].ToString().Trim(); //关键字
objCMFeatureEN.FeatureDescription = objRow[conCMFeature.FeatureDescription] == DBNull.Value ? null : objRow[conCMFeature.FeatureDescription].ToString().Trim(); //功能说明
objCMFeatureEN.CmParentFeatureId = objRow[conCMFeature.CmParentFeatureId] == DBNull.Value ? null : objRow[conCMFeature.CmParentFeatureId].ToString().Trim(); //父功能Id
objCMFeatureEN.ParentFeatureName = objRow[conCMFeature.ParentFeatureName] == DBNull.Value ? null : objRow[conCMFeature.ParentFeatureName].ToString().Trim(); //父功能名
objCMFeatureEN.CmFeatureTypeId = objRow[conCMFeature.CmFeatureTypeId].ToString().Trim(); //功能类型Id
objCMFeatureEN.CreateUserId = objRow[conCMFeature.CreateUserId].ToString().Trim(); //建立用户Id
objCMFeatureEN.InUse = TransNullToBool(objRow[conCMFeature.InUse].ToString().Trim()); //是否在用
objCMFeatureEN.OrderNum = TransNullToInt(objRow[conCMFeature.OrderNum].ToString().Trim()); //序号
objCMFeatureEN.FuncModuleAgcId = objRow[conCMFeature.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objCMFeatureEN.CmPrjId = objRow[conCMFeature.CmPrjId].ToString().Trim(); //Cm工程Id
objCMFeatureEN.PrjId = objRow[conCMFeature.PrjId].ToString().Trim(); //工程Id
objCMFeatureEN.UpdDate = objRow[conCMFeature.UpdDate] == DBNull.Value ? null : objRow[conCMFeature.UpdDate].ToString().Trim(); //修改日期
objCMFeatureEN.UpdUser = objRow[conCMFeature.UpdUser] == DBNull.Value ? null : objRow[conCMFeature.UpdUser].ToString().Trim(); //修改者
objCMFeatureEN.Memo = objRow[conCMFeature.Memo] == DBNull.Value ? null : objRow[conCMFeature.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsCMFeatureDA: GetObjByDataRow)", objException.Message));
}
objCMFeatureEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCMFeatureEN;
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
objSQL = clsCMFeatureDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCMFeatureEN._CurrTabName, conCMFeature.CmFeatureId, 8, "");
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
objSQL = clsCMFeatureDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCMFeatureEN._CurrTabName, conCMFeature.CmFeatureId, 8, strPrefix);
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
 objSQL = clsCMFeatureDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select CmFeatureId from CMFeature where " + strCondition;
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
 objSQL = clsCMFeatureDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select CmFeatureId from CMFeature where " + strCondition;
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
 /// <param name = "strCmFeatureId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strCmFeatureId)
{
CheckPrimaryKey(strCmFeatureId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CMFeature", "CmFeatureId = " + "'"+ strCmFeatureId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsCMFeatureDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CMFeature", strCondition))
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
objSQL = clsCMFeatureDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("CMFeature");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsCMFeatureEN objCMFeatureEN)
 {
 objCMFeatureEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMFeatureEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCMFeatureEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureDA.GetSpecSQLObj();
strSQL = "Select * from CMFeature where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CMFeature");
objRow = objDS.Tables["CMFeature"].NewRow();
objRow[conCMFeature.CmFeatureId] = objCMFeatureEN.CmFeatureId; //功能Id
objRow[conCMFeature.FeatureName] = objCMFeatureEN.FeatureName; //功能名称
 if (objCMFeatureEN.FeatureENName !=  "")
 {
objRow[conCMFeature.FeatureENName] = objCMFeatureEN.FeatureENName; //功能英文名
 }
 if (objCMFeatureEN.KeyWords !=  "")
 {
objRow[conCMFeature.KeyWords] = objCMFeatureEN.KeyWords; //关键字
 }
 if (objCMFeatureEN.FeatureDescription !=  "")
 {
objRow[conCMFeature.FeatureDescription] = objCMFeatureEN.FeatureDescription; //功能说明
 }
 if (objCMFeatureEN.CmParentFeatureId !=  "")
 {
objRow[conCMFeature.CmParentFeatureId] = objCMFeatureEN.CmParentFeatureId; //父功能Id
 }
 if (objCMFeatureEN.ParentFeatureName !=  "")
 {
objRow[conCMFeature.ParentFeatureName] = objCMFeatureEN.ParentFeatureName; //父功能名
 }
objRow[conCMFeature.CmFeatureTypeId] = objCMFeatureEN.CmFeatureTypeId; //功能类型Id
objRow[conCMFeature.CreateUserId] = objCMFeatureEN.CreateUserId; //建立用户Id
objRow[conCMFeature.InUse] = objCMFeatureEN.InUse; //是否在用
objRow[conCMFeature.OrderNum] = objCMFeatureEN.OrderNum; //序号
objRow[conCMFeature.FuncModuleAgcId] = objCMFeatureEN.FuncModuleAgcId; //功能模块Id
objRow[conCMFeature.CmPrjId] = objCMFeatureEN.CmPrjId; //Cm工程Id
objRow[conCMFeature.PrjId] = objCMFeatureEN.PrjId; //工程Id
 if (objCMFeatureEN.UpdDate !=  "")
 {
objRow[conCMFeature.UpdDate] = objCMFeatureEN.UpdDate; //修改日期
 }
 if (objCMFeatureEN.UpdUser !=  "")
 {
objRow[conCMFeature.UpdUser] = objCMFeatureEN.UpdUser; //修改者
 }
 if (objCMFeatureEN.Memo !=  "")
 {
objRow[conCMFeature.Memo] = objCMFeatureEN.Memo; //说明
 }
objDS.Tables[clsCMFeatureEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsCMFeatureEN._CurrTabName);
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
 /// <param name = "objCMFeatureEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCMFeatureEN objCMFeatureEN)
{
 objCMFeatureEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMFeatureEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCMFeatureEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCMFeatureEN.CmFeatureId !=  null)
 {
 arrFieldListForInsert.Add(conCMFeature.CmFeatureId);
 var strCmFeatureId = objCMFeatureEN.CmFeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmFeatureId + "'");
 }
 
 if (objCMFeatureEN.FeatureName !=  null)
 {
 arrFieldListForInsert.Add(conCMFeature.FeatureName);
 var strFeatureName = objCMFeatureEN.FeatureName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFeatureName + "'");
 }
 
 if (objCMFeatureEN.FeatureENName !=  null)
 {
 arrFieldListForInsert.Add(conCMFeature.FeatureENName);
 var strFeatureENName = objCMFeatureEN.FeatureENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFeatureENName + "'");
 }
 
 if (objCMFeatureEN.KeyWords !=  null)
 {
 arrFieldListForInsert.Add(conCMFeature.KeyWords);
 var strKeyWords = objCMFeatureEN.KeyWords.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyWords + "'");
 }
 
 if (objCMFeatureEN.FeatureDescription !=  null)
 {
 arrFieldListForInsert.Add(conCMFeature.FeatureDescription);
 var strFeatureDescription = objCMFeatureEN.FeatureDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFeatureDescription + "'");
 }
 
 if (objCMFeatureEN.CmParentFeatureId !=  null)
 {
 arrFieldListForInsert.Add(conCMFeature.CmParentFeatureId);
 var strCmParentFeatureId = objCMFeatureEN.CmParentFeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmParentFeatureId + "'");
 }
 
 if (objCMFeatureEN.ParentFeatureName !=  null)
 {
 arrFieldListForInsert.Add(conCMFeature.ParentFeatureName);
 var strParentFeatureName = objCMFeatureEN.ParentFeatureName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentFeatureName + "'");
 }
 
 if (objCMFeatureEN.CmFeatureTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCMFeature.CmFeatureTypeId);
 var strCmFeatureTypeId = objCMFeatureEN.CmFeatureTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmFeatureTypeId + "'");
 }
 
 if (objCMFeatureEN.CreateUserId !=  null)
 {
 arrFieldListForInsert.Add(conCMFeature.CreateUserId);
 var strCreateUserId = objCMFeatureEN.CreateUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateUserId + "'");
 }
 
 arrFieldListForInsert.Add(conCMFeature.InUse);
 arrValueListForInsert.Add("'" + (objCMFeatureEN.InUse  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCMFeature.OrderNum);
 arrValueListForInsert.Add(objCMFeatureEN.OrderNum.ToString());
 
 if (objCMFeatureEN.FuncModuleAgcId !=  null)
 {
 arrFieldListForInsert.Add(conCMFeature.FuncModuleAgcId);
 var strFuncModuleAgcId = objCMFeatureEN.FuncModuleAgcId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleAgcId + "'");
 }
 
 if (objCMFeatureEN.CmPrjId !=  null)
 {
 arrFieldListForInsert.Add(conCMFeature.CmPrjId);
 var strCmPrjId = objCMFeatureEN.CmPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmPrjId + "'");
 }
 
 if (objCMFeatureEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conCMFeature.PrjId);
 var strPrjId = objCMFeatureEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objCMFeatureEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCMFeature.UpdDate);
 var strUpdDate = objCMFeatureEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCMFeatureEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCMFeature.UpdUser);
 var strUpdUser = objCMFeatureEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objCMFeatureEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCMFeature.Memo);
 var strMemo = objCMFeatureEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CMFeature");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objCMFeatureEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCMFeatureEN objCMFeatureEN)
{
 objCMFeatureEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMFeatureEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCMFeatureEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCMFeatureEN.CmFeatureId !=  null)
 {
 arrFieldListForInsert.Add(conCMFeature.CmFeatureId);
 var strCmFeatureId = objCMFeatureEN.CmFeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmFeatureId + "'");
 }
 
 if (objCMFeatureEN.FeatureName !=  null)
 {
 arrFieldListForInsert.Add(conCMFeature.FeatureName);
 var strFeatureName = objCMFeatureEN.FeatureName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFeatureName + "'");
 }
 
 if (objCMFeatureEN.FeatureENName !=  null)
 {
 arrFieldListForInsert.Add(conCMFeature.FeatureENName);
 var strFeatureENName = objCMFeatureEN.FeatureENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFeatureENName + "'");
 }
 
 if (objCMFeatureEN.KeyWords !=  null)
 {
 arrFieldListForInsert.Add(conCMFeature.KeyWords);
 var strKeyWords = objCMFeatureEN.KeyWords.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyWords + "'");
 }
 
 if (objCMFeatureEN.FeatureDescription !=  null)
 {
 arrFieldListForInsert.Add(conCMFeature.FeatureDescription);
 var strFeatureDescription = objCMFeatureEN.FeatureDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFeatureDescription + "'");
 }
 
 if (objCMFeatureEN.CmParentFeatureId !=  null)
 {
 arrFieldListForInsert.Add(conCMFeature.CmParentFeatureId);
 var strCmParentFeatureId = objCMFeatureEN.CmParentFeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmParentFeatureId + "'");
 }
 
 if (objCMFeatureEN.ParentFeatureName !=  null)
 {
 arrFieldListForInsert.Add(conCMFeature.ParentFeatureName);
 var strParentFeatureName = objCMFeatureEN.ParentFeatureName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentFeatureName + "'");
 }
 
 if (objCMFeatureEN.CmFeatureTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCMFeature.CmFeatureTypeId);
 var strCmFeatureTypeId = objCMFeatureEN.CmFeatureTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmFeatureTypeId + "'");
 }
 
 if (objCMFeatureEN.CreateUserId !=  null)
 {
 arrFieldListForInsert.Add(conCMFeature.CreateUserId);
 var strCreateUserId = objCMFeatureEN.CreateUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateUserId + "'");
 }
 
 arrFieldListForInsert.Add(conCMFeature.InUse);
 arrValueListForInsert.Add("'" + (objCMFeatureEN.InUse  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCMFeature.OrderNum);
 arrValueListForInsert.Add(objCMFeatureEN.OrderNum.ToString());
 
 if (objCMFeatureEN.FuncModuleAgcId !=  null)
 {
 arrFieldListForInsert.Add(conCMFeature.FuncModuleAgcId);
 var strFuncModuleAgcId = objCMFeatureEN.FuncModuleAgcId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleAgcId + "'");
 }
 
 if (objCMFeatureEN.CmPrjId !=  null)
 {
 arrFieldListForInsert.Add(conCMFeature.CmPrjId);
 var strCmPrjId = objCMFeatureEN.CmPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmPrjId + "'");
 }
 
 if (objCMFeatureEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conCMFeature.PrjId);
 var strPrjId = objCMFeatureEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objCMFeatureEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCMFeature.UpdDate);
 var strUpdDate = objCMFeatureEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCMFeatureEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCMFeature.UpdUser);
 var strUpdUser = objCMFeatureEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objCMFeatureEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCMFeature.Memo);
 var strMemo = objCMFeatureEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CMFeature");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objCMFeatureEN.CmFeatureId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objCMFeatureEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCMFeatureEN objCMFeatureEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objCMFeatureEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMFeatureEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCMFeatureEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCMFeatureEN.CmFeatureId !=  null)
 {
 arrFieldListForInsert.Add(conCMFeature.CmFeatureId);
 var strCmFeatureId = objCMFeatureEN.CmFeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmFeatureId + "'");
 }
 
 if (objCMFeatureEN.FeatureName !=  null)
 {
 arrFieldListForInsert.Add(conCMFeature.FeatureName);
 var strFeatureName = objCMFeatureEN.FeatureName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFeatureName + "'");
 }
 
 if (objCMFeatureEN.FeatureENName !=  null)
 {
 arrFieldListForInsert.Add(conCMFeature.FeatureENName);
 var strFeatureENName = objCMFeatureEN.FeatureENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFeatureENName + "'");
 }
 
 if (objCMFeatureEN.KeyWords !=  null)
 {
 arrFieldListForInsert.Add(conCMFeature.KeyWords);
 var strKeyWords = objCMFeatureEN.KeyWords.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyWords + "'");
 }
 
 if (objCMFeatureEN.FeatureDescription !=  null)
 {
 arrFieldListForInsert.Add(conCMFeature.FeatureDescription);
 var strFeatureDescription = objCMFeatureEN.FeatureDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFeatureDescription + "'");
 }
 
 if (objCMFeatureEN.CmParentFeatureId !=  null)
 {
 arrFieldListForInsert.Add(conCMFeature.CmParentFeatureId);
 var strCmParentFeatureId = objCMFeatureEN.CmParentFeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmParentFeatureId + "'");
 }
 
 if (objCMFeatureEN.ParentFeatureName !=  null)
 {
 arrFieldListForInsert.Add(conCMFeature.ParentFeatureName);
 var strParentFeatureName = objCMFeatureEN.ParentFeatureName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentFeatureName + "'");
 }
 
 if (objCMFeatureEN.CmFeatureTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCMFeature.CmFeatureTypeId);
 var strCmFeatureTypeId = objCMFeatureEN.CmFeatureTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmFeatureTypeId + "'");
 }
 
 if (objCMFeatureEN.CreateUserId !=  null)
 {
 arrFieldListForInsert.Add(conCMFeature.CreateUserId);
 var strCreateUserId = objCMFeatureEN.CreateUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateUserId + "'");
 }
 
 arrFieldListForInsert.Add(conCMFeature.InUse);
 arrValueListForInsert.Add("'" + (objCMFeatureEN.InUse  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCMFeature.OrderNum);
 arrValueListForInsert.Add(objCMFeatureEN.OrderNum.ToString());
 
 if (objCMFeatureEN.FuncModuleAgcId !=  null)
 {
 arrFieldListForInsert.Add(conCMFeature.FuncModuleAgcId);
 var strFuncModuleAgcId = objCMFeatureEN.FuncModuleAgcId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleAgcId + "'");
 }
 
 if (objCMFeatureEN.CmPrjId !=  null)
 {
 arrFieldListForInsert.Add(conCMFeature.CmPrjId);
 var strCmPrjId = objCMFeatureEN.CmPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmPrjId + "'");
 }
 
 if (objCMFeatureEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conCMFeature.PrjId);
 var strPrjId = objCMFeatureEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objCMFeatureEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCMFeature.UpdDate);
 var strUpdDate = objCMFeatureEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCMFeatureEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCMFeature.UpdUser);
 var strUpdUser = objCMFeatureEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objCMFeatureEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCMFeature.Memo);
 var strMemo = objCMFeatureEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CMFeature");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewCMFeatures(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureDA.GetSpecSQLObj();
strSQL = "Select * from CMFeature where CmFeatureId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CMFeature");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strCmFeatureId = oRow[conCMFeature.CmFeatureId].ToString().Trim();
if (IsExist(strCmFeatureId))
{
 string strResult = "关键字变量值为:" + string.Format("CmFeatureId = {0}", strCmFeatureId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsCMFeatureEN._CurrTabName ].NewRow();
objRow[conCMFeature.CmFeatureId] = oRow[conCMFeature.CmFeatureId].ToString().Trim(); //功能Id
objRow[conCMFeature.FeatureName] = oRow[conCMFeature.FeatureName].ToString().Trim(); //功能名称
objRow[conCMFeature.FeatureENName] = oRow[conCMFeature.FeatureENName].ToString().Trim(); //功能英文名
objRow[conCMFeature.KeyWords] = oRow[conCMFeature.KeyWords].ToString().Trim(); //关键字
objRow[conCMFeature.FeatureDescription] = oRow[conCMFeature.FeatureDescription].ToString().Trim(); //功能说明
objRow[conCMFeature.CmParentFeatureId] = oRow[conCMFeature.CmParentFeatureId].ToString().Trim(); //父功能Id
objRow[conCMFeature.ParentFeatureName] = oRow[conCMFeature.ParentFeatureName].ToString().Trim(); //父功能名
objRow[conCMFeature.CmFeatureTypeId] = oRow[conCMFeature.CmFeatureTypeId].ToString().Trim(); //功能类型Id
objRow[conCMFeature.CreateUserId] = oRow[conCMFeature.CreateUserId].ToString().Trim(); //建立用户Id
objRow[conCMFeature.InUse] = oRow[conCMFeature.InUse].ToString().Trim(); //是否在用
objRow[conCMFeature.OrderNum] = oRow[conCMFeature.OrderNum].ToString().Trim(); //序号
objRow[conCMFeature.FuncModuleAgcId] = oRow[conCMFeature.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objRow[conCMFeature.CmPrjId] = oRow[conCMFeature.CmPrjId].ToString().Trim(); //Cm工程Id
objRow[conCMFeature.PrjId] = oRow[conCMFeature.PrjId].ToString().Trim(); //工程Id
objRow[conCMFeature.UpdDate] = oRow[conCMFeature.UpdDate].ToString().Trim(); //修改日期
objRow[conCMFeature.UpdUser] = oRow[conCMFeature.UpdUser].ToString().Trim(); //修改者
objRow[conCMFeature.Memo] = oRow[conCMFeature.Memo].ToString().Trim(); //说明
 objDS.Tables[clsCMFeatureEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsCMFeatureEN._CurrTabName);
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
 /// <param name = "objCMFeatureEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsCMFeatureEN objCMFeatureEN)
{
 objCMFeatureEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMFeatureEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCMFeatureEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureDA.GetSpecSQLObj();
strSQL = "Select * from CMFeature where CmFeatureId = " + "'"+ objCMFeatureEN.CmFeatureId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsCMFeatureEN._CurrTabName);
if (objDS.Tables[clsCMFeatureEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:CmFeatureId = " + "'"+ objCMFeatureEN.CmFeatureId+"'");
return false;
}
objRow = objDS.Tables[clsCMFeatureEN._CurrTabName].Rows[0];
 if (objCMFeatureEN.IsUpdated(conCMFeature.CmFeatureId))
 {
objRow[conCMFeature.CmFeatureId] = objCMFeatureEN.CmFeatureId; //功能Id
 }
 if (objCMFeatureEN.IsUpdated(conCMFeature.FeatureName))
 {
objRow[conCMFeature.FeatureName] = objCMFeatureEN.FeatureName; //功能名称
 }
 if (objCMFeatureEN.IsUpdated(conCMFeature.FeatureENName))
 {
objRow[conCMFeature.FeatureENName] = objCMFeatureEN.FeatureENName; //功能英文名
 }
 if (objCMFeatureEN.IsUpdated(conCMFeature.KeyWords))
 {
objRow[conCMFeature.KeyWords] = objCMFeatureEN.KeyWords; //关键字
 }
 if (objCMFeatureEN.IsUpdated(conCMFeature.FeatureDescription))
 {
objRow[conCMFeature.FeatureDescription] = objCMFeatureEN.FeatureDescription; //功能说明
 }
 if (objCMFeatureEN.IsUpdated(conCMFeature.CmParentFeatureId))
 {
objRow[conCMFeature.CmParentFeatureId] = objCMFeatureEN.CmParentFeatureId; //父功能Id
 }
 if (objCMFeatureEN.IsUpdated(conCMFeature.ParentFeatureName))
 {
objRow[conCMFeature.ParentFeatureName] = objCMFeatureEN.ParentFeatureName; //父功能名
 }
 if (objCMFeatureEN.IsUpdated(conCMFeature.CmFeatureTypeId))
 {
objRow[conCMFeature.CmFeatureTypeId] = objCMFeatureEN.CmFeatureTypeId; //功能类型Id
 }
 if (objCMFeatureEN.IsUpdated(conCMFeature.CreateUserId))
 {
objRow[conCMFeature.CreateUserId] = objCMFeatureEN.CreateUserId; //建立用户Id
 }
 if (objCMFeatureEN.IsUpdated(conCMFeature.InUse))
 {
objRow[conCMFeature.InUse] = objCMFeatureEN.InUse; //是否在用
 }
 if (objCMFeatureEN.IsUpdated(conCMFeature.OrderNum))
 {
objRow[conCMFeature.OrderNum] = objCMFeatureEN.OrderNum; //序号
 }
 if (objCMFeatureEN.IsUpdated(conCMFeature.FuncModuleAgcId))
 {
objRow[conCMFeature.FuncModuleAgcId] = objCMFeatureEN.FuncModuleAgcId; //功能模块Id
 }
 if (objCMFeatureEN.IsUpdated(conCMFeature.CmPrjId))
 {
objRow[conCMFeature.CmPrjId] = objCMFeatureEN.CmPrjId; //Cm工程Id
 }
 if (objCMFeatureEN.IsUpdated(conCMFeature.PrjId))
 {
objRow[conCMFeature.PrjId] = objCMFeatureEN.PrjId; //工程Id
 }
 if (objCMFeatureEN.IsUpdated(conCMFeature.UpdDate))
 {
objRow[conCMFeature.UpdDate] = objCMFeatureEN.UpdDate; //修改日期
 }
 if (objCMFeatureEN.IsUpdated(conCMFeature.UpdUser))
 {
objRow[conCMFeature.UpdUser] = objCMFeatureEN.UpdUser; //修改者
 }
 if (objCMFeatureEN.IsUpdated(conCMFeature.Memo))
 {
objRow[conCMFeature.Memo] = objCMFeatureEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsCMFeatureEN._CurrTabName);
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
 /// <param name = "objCMFeatureEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCMFeatureEN objCMFeatureEN)
{
 objCMFeatureEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMFeatureEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCMFeatureEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update CMFeature Set ");
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.FeatureName))
 {
 if (objCMFeatureEN.FeatureName !=  null)
 {
 var strFeatureName = objCMFeatureEN.FeatureName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFeatureName, conCMFeature.FeatureName); //功能名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFeature.FeatureName); //功能名称
 }
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.FeatureENName))
 {
 if (objCMFeatureEN.FeatureENName !=  null)
 {
 var strFeatureENName = objCMFeatureEN.FeatureENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFeatureENName, conCMFeature.FeatureENName); //功能英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFeature.FeatureENName); //功能英文名
 }
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.KeyWords))
 {
 if (objCMFeatureEN.KeyWords !=  null)
 {
 var strKeyWords = objCMFeatureEN.KeyWords.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKeyWords, conCMFeature.KeyWords); //关键字
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFeature.KeyWords); //关键字
 }
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.FeatureDescription))
 {
 if (objCMFeatureEN.FeatureDescription !=  null)
 {
 var strFeatureDescription = objCMFeatureEN.FeatureDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFeatureDescription, conCMFeature.FeatureDescription); //功能说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFeature.FeatureDescription); //功能说明
 }
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.CmParentFeatureId))
 {
 if (objCMFeatureEN.CmParentFeatureId !=  null)
 {
 var strCmParentFeatureId = objCMFeatureEN.CmParentFeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCmParentFeatureId, conCMFeature.CmParentFeatureId); //父功能Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFeature.CmParentFeatureId); //父功能Id
 }
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.ParentFeatureName))
 {
 if (objCMFeatureEN.ParentFeatureName !=  null)
 {
 var strParentFeatureName = objCMFeatureEN.ParentFeatureName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParentFeatureName, conCMFeature.ParentFeatureName); //父功能名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFeature.ParentFeatureName); //父功能名
 }
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.CmFeatureTypeId))
 {
 if (objCMFeatureEN.CmFeatureTypeId !=  null)
 {
 var strCmFeatureTypeId = objCMFeatureEN.CmFeatureTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCmFeatureTypeId, conCMFeature.CmFeatureTypeId); //功能类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFeature.CmFeatureTypeId); //功能类型Id
 }
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.CreateUserId))
 {
 if (objCMFeatureEN.CreateUserId !=  null)
 {
 var strCreateUserId = objCMFeatureEN.CreateUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateUserId, conCMFeature.CreateUserId); //建立用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFeature.CreateUserId); //建立用户Id
 }
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCMFeatureEN.InUse == true?"1":"0", conCMFeature.InUse); //是否在用
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objCMFeatureEN.OrderNum, conCMFeature.OrderNum); //序号
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.FuncModuleAgcId))
 {
 if (objCMFeatureEN.FuncModuleAgcId !=  null)
 {
 var strFuncModuleAgcId = objCMFeatureEN.FuncModuleAgcId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleAgcId, conCMFeature.FuncModuleAgcId); //功能模块Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFeature.FuncModuleAgcId); //功能模块Id
 }
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.CmPrjId))
 {
 if (objCMFeatureEN.CmPrjId !=  null)
 {
 var strCmPrjId = objCMFeatureEN.CmPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCmPrjId, conCMFeature.CmPrjId); //Cm工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFeature.CmPrjId); //Cm工程Id
 }
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.PrjId))
 {
 if (objCMFeatureEN.PrjId !=  null)
 {
 var strPrjId = objCMFeatureEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conCMFeature.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFeature.PrjId); //工程Id
 }
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.UpdDate))
 {
 if (objCMFeatureEN.UpdDate !=  null)
 {
 var strUpdDate = objCMFeatureEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conCMFeature.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFeature.UpdDate); //修改日期
 }
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.UpdUser))
 {
 if (objCMFeatureEN.UpdUser !=  null)
 {
 var strUpdUser = objCMFeatureEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conCMFeature.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFeature.UpdUser); //修改者
 }
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.Memo))
 {
 if (objCMFeatureEN.Memo !=  null)
 {
 var strMemo = objCMFeatureEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCMFeature.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFeature.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where CmFeatureId = '{0}'", objCMFeatureEN.CmFeatureId); 
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
 /// <param name = "objCMFeatureEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsCMFeatureEN objCMFeatureEN, string strCondition)
{
 objCMFeatureEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMFeatureEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCMFeatureEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CMFeature Set ");
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.FeatureName))
 {
 if (objCMFeatureEN.FeatureName !=  null)
 {
 var strFeatureName = objCMFeatureEN.FeatureName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FeatureName = '{0}',", strFeatureName); //功能名称
 }
 else
 {
 sbSQL.Append(" FeatureName = null,"); //功能名称
 }
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.FeatureENName))
 {
 if (objCMFeatureEN.FeatureENName !=  null)
 {
 var strFeatureENName = objCMFeatureEN.FeatureENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FeatureENName = '{0}',", strFeatureENName); //功能英文名
 }
 else
 {
 sbSQL.Append(" FeatureENName = null,"); //功能英文名
 }
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.KeyWords))
 {
 if (objCMFeatureEN.KeyWords !=  null)
 {
 var strKeyWords = objCMFeatureEN.KeyWords.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" KeyWords = '{0}',", strKeyWords); //关键字
 }
 else
 {
 sbSQL.Append(" KeyWords = null,"); //关键字
 }
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.FeatureDescription))
 {
 if (objCMFeatureEN.FeatureDescription !=  null)
 {
 var strFeatureDescription = objCMFeatureEN.FeatureDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FeatureDescription = '{0}',", strFeatureDescription); //功能说明
 }
 else
 {
 sbSQL.Append(" FeatureDescription = null,"); //功能说明
 }
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.CmParentFeatureId))
 {
 if (objCMFeatureEN.CmParentFeatureId !=  null)
 {
 var strCmParentFeatureId = objCMFeatureEN.CmParentFeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CmParentFeatureId = '{0}',", strCmParentFeatureId); //父功能Id
 }
 else
 {
 sbSQL.Append(" CmParentFeatureId = null,"); //父功能Id
 }
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.ParentFeatureName))
 {
 if (objCMFeatureEN.ParentFeatureName !=  null)
 {
 var strParentFeatureName = objCMFeatureEN.ParentFeatureName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParentFeatureName = '{0}',", strParentFeatureName); //父功能名
 }
 else
 {
 sbSQL.Append(" ParentFeatureName = null,"); //父功能名
 }
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.CmFeatureTypeId))
 {
 if (objCMFeatureEN.CmFeatureTypeId !=  null)
 {
 var strCmFeatureTypeId = objCMFeatureEN.CmFeatureTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CmFeatureTypeId = '{0}',", strCmFeatureTypeId); //功能类型Id
 }
 else
 {
 sbSQL.Append(" CmFeatureTypeId = null,"); //功能类型Id
 }
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.CreateUserId))
 {
 if (objCMFeatureEN.CreateUserId !=  null)
 {
 var strCreateUserId = objCMFeatureEN.CreateUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateUserId = '{0}',", strCreateUserId); //建立用户Id
 }
 else
 {
 sbSQL.Append(" CreateUserId = null,"); //建立用户Id
 }
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objCMFeatureEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objCMFeatureEN.OrderNum); //序号
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.FuncModuleAgcId))
 {
 if (objCMFeatureEN.FuncModuleAgcId !=  null)
 {
 var strFuncModuleAgcId = objCMFeatureEN.FuncModuleAgcId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleAgcId = '{0}',", strFuncModuleAgcId); //功能模块Id
 }
 else
 {
 sbSQL.Append(" FuncModuleAgcId = null,"); //功能模块Id
 }
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.CmPrjId))
 {
 if (objCMFeatureEN.CmPrjId !=  null)
 {
 var strCmPrjId = objCMFeatureEN.CmPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CmPrjId = '{0}',", strCmPrjId); //Cm工程Id
 }
 else
 {
 sbSQL.Append(" CmPrjId = null,"); //Cm工程Id
 }
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.PrjId))
 {
 if (objCMFeatureEN.PrjId !=  null)
 {
 var strPrjId = objCMFeatureEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.UpdDate))
 {
 if (objCMFeatureEN.UpdDate !=  null)
 {
 var strUpdDate = objCMFeatureEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.UpdUser))
 {
 if (objCMFeatureEN.UpdUser !=  null)
 {
 var strUpdUser = objCMFeatureEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.Memo))
 {
 if (objCMFeatureEN.Memo !=  null)
 {
 var strMemo = objCMFeatureEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objCMFeatureEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsCMFeatureEN objCMFeatureEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objCMFeatureEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMFeatureEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCMFeatureEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CMFeature Set ");
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.FeatureName))
 {
 if (objCMFeatureEN.FeatureName !=  null)
 {
 var strFeatureName = objCMFeatureEN.FeatureName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FeatureName = '{0}',", strFeatureName); //功能名称
 }
 else
 {
 sbSQL.Append(" FeatureName = null,"); //功能名称
 }
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.FeatureENName))
 {
 if (objCMFeatureEN.FeatureENName !=  null)
 {
 var strFeatureENName = objCMFeatureEN.FeatureENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FeatureENName = '{0}',", strFeatureENName); //功能英文名
 }
 else
 {
 sbSQL.Append(" FeatureENName = null,"); //功能英文名
 }
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.KeyWords))
 {
 if (objCMFeatureEN.KeyWords !=  null)
 {
 var strKeyWords = objCMFeatureEN.KeyWords.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" KeyWords = '{0}',", strKeyWords); //关键字
 }
 else
 {
 sbSQL.Append(" KeyWords = null,"); //关键字
 }
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.FeatureDescription))
 {
 if (objCMFeatureEN.FeatureDescription !=  null)
 {
 var strFeatureDescription = objCMFeatureEN.FeatureDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FeatureDescription = '{0}',", strFeatureDescription); //功能说明
 }
 else
 {
 sbSQL.Append(" FeatureDescription = null,"); //功能说明
 }
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.CmParentFeatureId))
 {
 if (objCMFeatureEN.CmParentFeatureId !=  null)
 {
 var strCmParentFeatureId = objCMFeatureEN.CmParentFeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CmParentFeatureId = '{0}',", strCmParentFeatureId); //父功能Id
 }
 else
 {
 sbSQL.Append(" CmParentFeatureId = null,"); //父功能Id
 }
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.ParentFeatureName))
 {
 if (objCMFeatureEN.ParentFeatureName !=  null)
 {
 var strParentFeatureName = objCMFeatureEN.ParentFeatureName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParentFeatureName = '{0}',", strParentFeatureName); //父功能名
 }
 else
 {
 sbSQL.Append(" ParentFeatureName = null,"); //父功能名
 }
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.CmFeatureTypeId))
 {
 if (objCMFeatureEN.CmFeatureTypeId !=  null)
 {
 var strCmFeatureTypeId = objCMFeatureEN.CmFeatureTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CmFeatureTypeId = '{0}',", strCmFeatureTypeId); //功能类型Id
 }
 else
 {
 sbSQL.Append(" CmFeatureTypeId = null,"); //功能类型Id
 }
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.CreateUserId))
 {
 if (objCMFeatureEN.CreateUserId !=  null)
 {
 var strCreateUserId = objCMFeatureEN.CreateUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateUserId = '{0}',", strCreateUserId); //建立用户Id
 }
 else
 {
 sbSQL.Append(" CreateUserId = null,"); //建立用户Id
 }
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objCMFeatureEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objCMFeatureEN.OrderNum); //序号
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.FuncModuleAgcId))
 {
 if (objCMFeatureEN.FuncModuleAgcId !=  null)
 {
 var strFuncModuleAgcId = objCMFeatureEN.FuncModuleAgcId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleAgcId = '{0}',", strFuncModuleAgcId); //功能模块Id
 }
 else
 {
 sbSQL.Append(" FuncModuleAgcId = null,"); //功能模块Id
 }
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.CmPrjId))
 {
 if (objCMFeatureEN.CmPrjId !=  null)
 {
 var strCmPrjId = objCMFeatureEN.CmPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CmPrjId = '{0}',", strCmPrjId); //Cm工程Id
 }
 else
 {
 sbSQL.Append(" CmPrjId = null,"); //Cm工程Id
 }
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.PrjId))
 {
 if (objCMFeatureEN.PrjId !=  null)
 {
 var strPrjId = objCMFeatureEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.UpdDate))
 {
 if (objCMFeatureEN.UpdDate !=  null)
 {
 var strUpdDate = objCMFeatureEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.UpdUser))
 {
 if (objCMFeatureEN.UpdUser !=  null)
 {
 var strUpdUser = objCMFeatureEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.Memo))
 {
 if (objCMFeatureEN.Memo !=  null)
 {
 var strMemo = objCMFeatureEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objCMFeatureEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCMFeatureEN objCMFeatureEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objCMFeatureEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMFeatureEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCMFeatureEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CMFeature Set ");
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.FeatureName))
 {
 if (objCMFeatureEN.FeatureName !=  null)
 {
 var strFeatureName = objCMFeatureEN.FeatureName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFeatureName, conCMFeature.FeatureName); //功能名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFeature.FeatureName); //功能名称
 }
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.FeatureENName))
 {
 if (objCMFeatureEN.FeatureENName !=  null)
 {
 var strFeatureENName = objCMFeatureEN.FeatureENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFeatureENName, conCMFeature.FeatureENName); //功能英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFeature.FeatureENName); //功能英文名
 }
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.KeyWords))
 {
 if (objCMFeatureEN.KeyWords !=  null)
 {
 var strKeyWords = objCMFeatureEN.KeyWords.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKeyWords, conCMFeature.KeyWords); //关键字
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFeature.KeyWords); //关键字
 }
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.FeatureDescription))
 {
 if (objCMFeatureEN.FeatureDescription !=  null)
 {
 var strFeatureDescription = objCMFeatureEN.FeatureDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFeatureDescription, conCMFeature.FeatureDescription); //功能说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFeature.FeatureDescription); //功能说明
 }
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.CmParentFeatureId))
 {
 if (objCMFeatureEN.CmParentFeatureId !=  null)
 {
 var strCmParentFeatureId = objCMFeatureEN.CmParentFeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCmParentFeatureId, conCMFeature.CmParentFeatureId); //父功能Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFeature.CmParentFeatureId); //父功能Id
 }
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.ParentFeatureName))
 {
 if (objCMFeatureEN.ParentFeatureName !=  null)
 {
 var strParentFeatureName = objCMFeatureEN.ParentFeatureName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParentFeatureName, conCMFeature.ParentFeatureName); //父功能名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFeature.ParentFeatureName); //父功能名
 }
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.CmFeatureTypeId))
 {
 if (objCMFeatureEN.CmFeatureTypeId !=  null)
 {
 var strCmFeatureTypeId = objCMFeatureEN.CmFeatureTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCmFeatureTypeId, conCMFeature.CmFeatureTypeId); //功能类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFeature.CmFeatureTypeId); //功能类型Id
 }
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.CreateUserId))
 {
 if (objCMFeatureEN.CreateUserId !=  null)
 {
 var strCreateUserId = objCMFeatureEN.CreateUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateUserId, conCMFeature.CreateUserId); //建立用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFeature.CreateUserId); //建立用户Id
 }
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCMFeatureEN.InUse == true?"1":"0", conCMFeature.InUse); //是否在用
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objCMFeatureEN.OrderNum, conCMFeature.OrderNum); //序号
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.FuncModuleAgcId))
 {
 if (objCMFeatureEN.FuncModuleAgcId !=  null)
 {
 var strFuncModuleAgcId = objCMFeatureEN.FuncModuleAgcId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleAgcId, conCMFeature.FuncModuleAgcId); //功能模块Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFeature.FuncModuleAgcId); //功能模块Id
 }
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.CmPrjId))
 {
 if (objCMFeatureEN.CmPrjId !=  null)
 {
 var strCmPrjId = objCMFeatureEN.CmPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCmPrjId, conCMFeature.CmPrjId); //Cm工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFeature.CmPrjId); //Cm工程Id
 }
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.PrjId))
 {
 if (objCMFeatureEN.PrjId !=  null)
 {
 var strPrjId = objCMFeatureEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conCMFeature.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFeature.PrjId); //工程Id
 }
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.UpdDate))
 {
 if (objCMFeatureEN.UpdDate !=  null)
 {
 var strUpdDate = objCMFeatureEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conCMFeature.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFeature.UpdDate); //修改日期
 }
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.UpdUser))
 {
 if (objCMFeatureEN.UpdUser !=  null)
 {
 var strUpdUser = objCMFeatureEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conCMFeature.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFeature.UpdUser); //修改者
 }
 }
 
 if (objCMFeatureEN.IsUpdated(conCMFeature.Memo))
 {
 if (objCMFeatureEN.Memo !=  null)
 {
 var strMemo = objCMFeatureEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCMFeature.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFeature.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where CmFeatureId = '{0}'", objCMFeatureEN.CmFeatureId); 
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
 /// <param name = "strCmFeatureId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strCmFeatureId) 
{
CheckPrimaryKey(strCmFeatureId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strCmFeatureId,
};
 objSQL.ExecSP("CMFeature_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strCmFeatureId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strCmFeatureId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strCmFeatureId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureDA.GetSpecSQLObj();
//删除CMFeature本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CMFeature where CmFeatureId = " + "'"+ strCmFeatureId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelCMFeature(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureDA.GetSpecSQLObj();
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
//删除CMFeature本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CMFeature where CmFeatureId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strCmFeatureId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strCmFeatureId) 
{
CheckPrimaryKey(strCmFeatureId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureDA.GetSpecSQLObj();
//删除CMFeature本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CMFeature where CmFeatureId = " + "'"+ strCmFeatureId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelCMFeature(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsCMFeatureDA: DelCMFeature)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CMFeature where " + strCondition ;
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
public bool DelCMFeatureWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsCMFeatureDA: DelCMFeatureWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFeatureDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CMFeature where " + strCondition ;
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
 /// <param name = "objCMFeatureENS">源对象</param>
 /// <param name = "objCMFeatureENT">目标对象</param>
public void CopyTo(clsCMFeatureEN objCMFeatureENS, clsCMFeatureEN objCMFeatureENT)
{
objCMFeatureENT.CmFeatureId = objCMFeatureENS.CmFeatureId; //功能Id
objCMFeatureENT.FeatureName = objCMFeatureENS.FeatureName; //功能名称
objCMFeatureENT.FeatureENName = objCMFeatureENS.FeatureENName; //功能英文名
objCMFeatureENT.KeyWords = objCMFeatureENS.KeyWords; //关键字
objCMFeatureENT.FeatureDescription = objCMFeatureENS.FeatureDescription; //功能说明
objCMFeatureENT.CmParentFeatureId = objCMFeatureENS.CmParentFeatureId; //父功能Id
objCMFeatureENT.ParentFeatureName = objCMFeatureENS.ParentFeatureName; //父功能名
objCMFeatureENT.CmFeatureTypeId = objCMFeatureENS.CmFeatureTypeId; //功能类型Id
objCMFeatureENT.CreateUserId = objCMFeatureENS.CreateUserId; //建立用户Id
objCMFeatureENT.InUse = objCMFeatureENS.InUse; //是否在用
objCMFeatureENT.OrderNum = objCMFeatureENS.OrderNum; //序号
objCMFeatureENT.FuncModuleAgcId = objCMFeatureENS.FuncModuleAgcId; //功能模块Id
objCMFeatureENT.CmPrjId = objCMFeatureENS.CmPrjId; //Cm工程Id
objCMFeatureENT.PrjId = objCMFeatureENS.PrjId; //工程Id
objCMFeatureENT.UpdDate = objCMFeatureENS.UpdDate; //修改日期
objCMFeatureENT.UpdUser = objCMFeatureENS.UpdUser; //修改者
objCMFeatureENT.Memo = objCMFeatureENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsCMFeatureEN objCMFeatureEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objCMFeatureEN.FeatureName, conCMFeature.FeatureName);
clsCheckSql.CheckFieldNotNull(objCMFeatureEN.CmFeatureTypeId, conCMFeature.CmFeatureTypeId);
clsCheckSql.CheckFieldNotNull(objCMFeatureEN.CreateUserId, conCMFeature.CreateUserId);
clsCheckSql.CheckFieldNotNull(objCMFeatureEN.OrderNum, conCMFeature.OrderNum);
clsCheckSql.CheckFieldNotNull(objCMFeatureEN.FuncModuleAgcId, conCMFeature.FuncModuleAgcId);
clsCheckSql.CheckFieldNotNull(objCMFeatureEN.CmPrjId, conCMFeature.CmPrjId);
clsCheckSql.CheckFieldNotNull(objCMFeatureEN.PrjId, conCMFeature.PrjId);
//检查字段长度
clsCheckSql.CheckFieldLen(objCMFeatureEN.CmFeatureId, 8, conCMFeature.CmFeatureId);
clsCheckSql.CheckFieldLen(objCMFeatureEN.FeatureName, 100, conCMFeature.FeatureName);
clsCheckSql.CheckFieldLen(objCMFeatureEN.FeatureENName, 100, conCMFeature.FeatureENName);
clsCheckSql.CheckFieldLen(objCMFeatureEN.KeyWords, 500, conCMFeature.KeyWords);
clsCheckSql.CheckFieldLen(objCMFeatureEN.FeatureDescription, 4000, conCMFeature.FeatureDescription);
clsCheckSql.CheckFieldLen(objCMFeatureEN.CmParentFeatureId, 8, conCMFeature.CmParentFeatureId);
clsCheckSql.CheckFieldLen(objCMFeatureEN.ParentFeatureName, 500, conCMFeature.ParentFeatureName);
clsCheckSql.CheckFieldLen(objCMFeatureEN.CmFeatureTypeId, 2, conCMFeature.CmFeatureTypeId);
clsCheckSql.CheckFieldLen(objCMFeatureEN.CreateUserId, 18, conCMFeature.CreateUserId);
clsCheckSql.CheckFieldLen(objCMFeatureEN.FuncModuleAgcId, 8, conCMFeature.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(objCMFeatureEN.CmPrjId, 6, conCMFeature.CmPrjId);
clsCheckSql.CheckFieldLen(objCMFeatureEN.PrjId, 4, conCMFeature.PrjId);
clsCheckSql.CheckFieldLen(objCMFeatureEN.UpdDate, 20, conCMFeature.UpdDate);
clsCheckSql.CheckFieldLen(objCMFeatureEN.UpdUser, 20, conCMFeature.UpdUser);
clsCheckSql.CheckFieldLen(objCMFeatureEN.Memo, 1000, conCMFeature.Memo);
//检查字段外键固定长度
 objCMFeatureEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsCMFeatureEN objCMFeatureEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCMFeatureEN.FeatureName, 100, conCMFeature.FeatureName);
clsCheckSql.CheckFieldLen(objCMFeatureEN.FeatureENName, 100, conCMFeature.FeatureENName);
clsCheckSql.CheckFieldLen(objCMFeatureEN.KeyWords, 500, conCMFeature.KeyWords);
clsCheckSql.CheckFieldLen(objCMFeatureEN.FeatureDescription, 4000, conCMFeature.FeatureDescription);
clsCheckSql.CheckFieldLen(objCMFeatureEN.CmParentFeatureId, 8, conCMFeature.CmParentFeatureId);
clsCheckSql.CheckFieldLen(objCMFeatureEN.ParentFeatureName, 500, conCMFeature.ParentFeatureName);
clsCheckSql.CheckFieldLen(objCMFeatureEN.CmFeatureTypeId, 2, conCMFeature.CmFeatureTypeId);
clsCheckSql.CheckFieldLen(objCMFeatureEN.CreateUserId, 18, conCMFeature.CreateUserId);
clsCheckSql.CheckFieldLen(objCMFeatureEN.FuncModuleAgcId, 8, conCMFeature.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(objCMFeatureEN.CmPrjId, 6, conCMFeature.CmPrjId);
clsCheckSql.CheckFieldLen(objCMFeatureEN.PrjId, 4, conCMFeature.PrjId);
clsCheckSql.CheckFieldLen(objCMFeatureEN.UpdDate, 20, conCMFeature.UpdDate);
clsCheckSql.CheckFieldLen(objCMFeatureEN.UpdUser, 20, conCMFeature.UpdUser);
clsCheckSql.CheckFieldLen(objCMFeatureEN.Memo, 1000, conCMFeature.Memo);
//检查外键字段长度
 objCMFeatureEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsCMFeatureEN objCMFeatureEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCMFeatureEN.CmFeatureId, 8, conCMFeature.CmFeatureId);
clsCheckSql.CheckFieldLen(objCMFeatureEN.FeatureName, 100, conCMFeature.FeatureName);
clsCheckSql.CheckFieldLen(objCMFeatureEN.FeatureENName, 100, conCMFeature.FeatureENName);
clsCheckSql.CheckFieldLen(objCMFeatureEN.KeyWords, 500, conCMFeature.KeyWords);
clsCheckSql.CheckFieldLen(objCMFeatureEN.FeatureDescription, 4000, conCMFeature.FeatureDescription);
clsCheckSql.CheckFieldLen(objCMFeatureEN.CmParentFeatureId, 8, conCMFeature.CmParentFeatureId);
clsCheckSql.CheckFieldLen(objCMFeatureEN.ParentFeatureName, 500, conCMFeature.ParentFeatureName);
clsCheckSql.CheckFieldLen(objCMFeatureEN.CmFeatureTypeId, 2, conCMFeature.CmFeatureTypeId);
clsCheckSql.CheckFieldLen(objCMFeatureEN.CreateUserId, 18, conCMFeature.CreateUserId);
clsCheckSql.CheckFieldLen(objCMFeatureEN.FuncModuleAgcId, 8, conCMFeature.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(objCMFeatureEN.CmPrjId, 6, conCMFeature.CmPrjId);
clsCheckSql.CheckFieldLen(objCMFeatureEN.PrjId, 4, conCMFeature.PrjId);
clsCheckSql.CheckFieldLen(objCMFeatureEN.UpdDate, 20, conCMFeature.UpdDate);
clsCheckSql.CheckFieldLen(objCMFeatureEN.UpdUser, 20, conCMFeature.UpdUser);
clsCheckSql.CheckFieldLen(objCMFeatureEN.Memo, 1000, conCMFeature.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objCMFeatureEN.CmFeatureId, conCMFeature.CmFeatureId);
clsCheckSql.CheckSqlInjection4Field(objCMFeatureEN.FeatureName, conCMFeature.FeatureName);
clsCheckSql.CheckSqlInjection4Field(objCMFeatureEN.FeatureENName, conCMFeature.FeatureENName);
clsCheckSql.CheckSqlInjection4Field(objCMFeatureEN.KeyWords, conCMFeature.KeyWords);
clsCheckSql.CheckSqlInjection4Field(objCMFeatureEN.FeatureDescription, conCMFeature.FeatureDescription);
clsCheckSql.CheckSqlInjection4Field(objCMFeatureEN.CmParentFeatureId, conCMFeature.CmParentFeatureId);
clsCheckSql.CheckSqlInjection4Field(objCMFeatureEN.ParentFeatureName, conCMFeature.ParentFeatureName);
clsCheckSql.CheckSqlInjection4Field(objCMFeatureEN.CmFeatureTypeId, conCMFeature.CmFeatureTypeId);
clsCheckSql.CheckSqlInjection4Field(objCMFeatureEN.CreateUserId, conCMFeature.CreateUserId);
clsCheckSql.CheckSqlInjection4Field(objCMFeatureEN.FuncModuleAgcId, conCMFeature.FuncModuleAgcId);
clsCheckSql.CheckSqlInjection4Field(objCMFeatureEN.CmPrjId, conCMFeature.CmPrjId);
clsCheckSql.CheckSqlInjection4Field(objCMFeatureEN.PrjId, conCMFeature.PrjId);
clsCheckSql.CheckSqlInjection4Field(objCMFeatureEN.UpdDate, conCMFeature.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objCMFeatureEN.UpdUser, conCMFeature.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objCMFeatureEN.Memo, conCMFeature.Memo);
//检查外键字段长度
 objCMFeatureEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetCmFeatureId()
{
//获取某学院所有专业信息
string strSQL = "select CmFeatureId, FeatureName from CMFeature ";
 clsSpecSQLforSql mySql = clsCMFeatureDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--CMFeature(CM功能),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objCMFeatureEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsCMFeatureEN objCMFeatureEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FeatureName = '{0}'", objCMFeatureEN.FeatureName);
 sbCondition.AppendFormat(" and CmPrjId = '{0}'", objCMFeatureEN.CmPrjId);
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
 objSQL = clsCMFeatureDA.GetSpecSQLObj();
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
 objSQL = clsCMFeatureDA.GetSpecSQLObj();
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
 objSQL = clsCMFeatureDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCMFeatureEN._CurrTabName);
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
 objSQL = clsCMFeatureDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCMFeatureEN._CurrTabName, strCondition);
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
 objSQL = clsCMFeatureDA.GetSpecSQLObj();
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
 objSQL = clsCMFeatureDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}