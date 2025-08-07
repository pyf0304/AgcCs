
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscss_ControlDA
 表名:css_Control(00050467)
 * 版本:2023.03.09.1(服务器:WIN-SRV103-116)
 日期:2023/03/09 12:39:52
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:样式表管理(CssManage)
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
 /// 控件(css_Control)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class clscss_ControlDA : clsCommBase4DA
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
 return clscss_ControlEN._CurrTabName;
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
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象！");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象！");
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
if (string.IsNullOrEmpty(clscss_ControlEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clscss_ControlEN._ConnectString);
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
 if (string.IsNullOrEmpty(clscss_ControlEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clscss_ControlEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strControlId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strControlId)
{
strControlId = strControlId.Replace("'", "''");
if (strControlId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:css_Control中,检查关键字,长度不正确!(clscss_ControlDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strControlId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:css_Control中,关键字不能为空 或 null!(clscss_ControlDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strControlId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clscss_ControlDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clscss_ControlDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_ControlDA.GetSpecSQLObj();
strSQL = "Select * from css_Control where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_css_Control(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clscss_ControlDA: GetDataTable_css_Control)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_ControlDA.GetSpecSQLObj();
strSQL = "Select * from css_Control where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clscss_ControlDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_ControlDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clscss_ControlDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_ControlDA.GetSpecSQLObj();
strSQL = "Select * from css_Control where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clscss_ControlDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_ControlDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clscss_ControlDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_ControlDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from css_Control where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from css_Control where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clscss_ControlDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_ControlDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from css_Control where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clscss_ControlDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_ControlDA.GetSpecSQLObj();
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
throw new Exception(string.Format("在带有特殊排序分页查询中，strOrderBy:[{0}]应该有竖线(|)分隔的3部分组成,请检查!(in {1})",
strOrderBy, clsStackTrace.GetCurrClassFunction()));
}
string strTabName = arrPart[0];
string strNewOrderBy = arrPart[1];
string strOnCondition = arrPart[2];
strSQL = string.Format("Select Top {0} css_Control.* from css_Control Left Join {1} on {2} where {3} and css_Control.ControlId not in (Select top {5} css_Control.ControlId from css_Control Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from css_Control where {1} and ControlId not in (Select top {2} ControlId from css_Control where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from css_Control where {1} and ControlId not in (Select top {3} ControlId from css_Control where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clscss_ControlDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_ControlDA.GetSpecSQLObj();
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
throw new Exception(string.Format("在带有特殊排序分页查询中，strOrderBy:[{0}]应该有竖线(|)分隔的3部分组成,请检查!(in {1})",
strOrderBy, clsStackTrace.GetCurrClassFunction()));
}
string strTabName = arrPart[0];
string strNewOrderBy = arrPart[1];
string strOnCondition = arrPart[2];
strSQL = string.Format("Select Top {0} css_Control.* from css_Control Left Join {1} on {2} where {3} and css_Control.ControlId not in (Select top {5} css_Control.ControlId from css_Control Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from css_Control where {1} and ControlId not in (Select top {2} ControlId from css_Control where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from css_Control where {1} and ControlId not in (Select top {3} ControlId from css_Control where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clscss_ControlEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clscss_ControlDA:GetObjLst)", objException.Message));
}
List<clscss_ControlEN> arrObjLst = new List<clscss_ControlEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_ControlDA.GetSpecSQLObj();
strSQL = "Select * from css_Control where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscss_ControlEN objcss_ControlEN = new clscss_ControlEN();
try
{
objcss_ControlEN.ControlId = objRow[concss_Control.ControlId].ToString().Trim(); //控件ID
objcss_ControlEN.ControlName = objRow[concss_Control.ControlName].ToString().Trim(); //控件名称
objcss_ControlEN.ControlENName = objRow[concss_Control.ControlENName].ToString().Trim(); //控件英文名
objcss_ControlEN.IsDeleted = TransNullToBool(objRow[concss_Control.IsDeleted].ToString().Trim()); //是否删除
objcss_ControlEN.DeletedDate = objRow[concss_Control.DeletedDate].ToString().Trim(); //删除日期
objcss_ControlEN.UpdDate = objRow[concss_Control.UpdDate].ToString().Trim(); //修改日期
objcss_ControlEN.UpdUser = objRow[concss_Control.UpdUser].ToString().Trim(); //修改者
objcss_ControlEN.Memo = objRow[concss_Control.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clscss_ControlDA: GetObjLst)", objException.Message));
}
objcss_ControlEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objcss_ControlEN);
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
public List<clscss_ControlEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clscss_ControlDA:GetObjLstByTabName)", objException.Message));
}
List<clscss_ControlEN> arrObjLst = new List<clscss_ControlEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_ControlDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscss_ControlEN objcss_ControlEN = new clscss_ControlEN();
try
{
objcss_ControlEN.ControlId = objRow[concss_Control.ControlId].ToString().Trim(); //控件ID
objcss_ControlEN.ControlName = objRow[concss_Control.ControlName].ToString().Trim(); //控件名称
objcss_ControlEN.ControlENName = objRow[concss_Control.ControlENName].ToString().Trim(); //控件英文名
objcss_ControlEN.IsDeleted = TransNullToBool(objRow[concss_Control.IsDeleted].ToString().Trim()); //是否删除
objcss_ControlEN.DeletedDate = objRow[concss_Control.DeletedDate].ToString().Trim(); //删除日期
objcss_ControlEN.UpdDate = objRow[concss_Control.UpdDate].ToString().Trim(); //修改日期
objcss_ControlEN.UpdUser = objRow[concss_Control.UpdUser].ToString().Trim(); //修改者
objcss_ControlEN.Memo = objRow[concss_Control.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clscss_ControlDA: GetObjLst)", objException.Message));
}
objcss_ControlEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objcss_ControlEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objcss_ControlEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getcss_Control(ref clscss_ControlEN objcss_ControlEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_ControlDA.GetSpecSQLObj();
strSQL = "Select * from css_Control where ControlId = " + "'"+ objcss_ControlEN.ControlId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objcss_ControlEN.ControlId = objDT.Rows[0][concss_Control.ControlId].ToString().Trim(); //控件ID(字段类型:char,字段长度:8,是否可空:False)
 objcss_ControlEN.ControlName = objDT.Rows[0][concss_Control.ControlName].ToString().Trim(); //控件名称(字段类型:varchar,字段长度:50,是否可空:True)
 objcss_ControlEN.ControlENName = objDT.Rows[0][concss_Control.ControlENName].ToString().Trim(); //控件英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objcss_ControlEN.IsDeleted = TransNullToBool(objDT.Rows[0][concss_Control.IsDeleted].ToString().Trim()); //是否删除(字段类型:bit,字段长度:1,是否可空:True)
 objcss_ControlEN.DeletedDate = objDT.Rows[0][concss_Control.DeletedDate].ToString().Trim(); //删除日期(字段类型:varchar,字段长度:50,是否可空:True)
 objcss_ControlEN.UpdDate = objDT.Rows[0][concss_Control.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objcss_ControlEN.UpdUser = objDT.Rows[0][concss_Control.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objcss_ControlEN.Memo = objDT.Rows[0][concss_Control.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clscss_ControlDA: Getcss_Control)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strControlId">表关键字</param>
 /// <returns>表对象</returns>
public clscss_ControlEN GetObjByControlId(string strControlId)
{
CheckPrimaryKey(strControlId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_ControlDA.GetSpecSQLObj();
strSQL = "Select * from css_Control where ControlId = " + "'"+ strControlId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clscss_ControlEN objcss_ControlEN = new clscss_ControlEN();
try
{
 objcss_ControlEN.ControlId = objRow[concss_Control.ControlId].ToString().Trim(); //控件ID(字段类型:char,字段长度:8,是否可空:False)
 objcss_ControlEN.ControlName = objRow[concss_Control.ControlName].ToString().Trim(); //控件名称(字段类型:varchar,字段长度:50,是否可空:True)
 objcss_ControlEN.ControlENName = objRow[concss_Control.ControlENName] == DBNull.Value ? null : objRow[concss_Control.ControlENName].ToString().Trim(); //控件英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objcss_ControlEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[concss_Control.IsDeleted] == DBNull.Value ? null : objRow[concss_Control.IsDeleted].ToString().Trim()); //是否删除(字段类型:bit,字段长度:1,是否可空:True)
 objcss_ControlEN.DeletedDate = objRow[concss_Control.DeletedDate] == DBNull.Value ? null : objRow[concss_Control.DeletedDate].ToString().Trim(); //删除日期(字段类型:varchar,字段长度:50,是否可空:True)
 objcss_ControlEN.UpdDate = objRow[concss_Control.UpdDate] == DBNull.Value ? null : objRow[concss_Control.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objcss_ControlEN.UpdUser = objRow[concss_Control.UpdUser] == DBNull.Value ? null : objRow[concss_Control.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objcss_ControlEN.Memo = objRow[concss_Control.Memo] == DBNull.Value ? null : objRow[concss_Control.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clscss_ControlDA: GetObjByControlId)", objException.Message));
}
return objcss_ControlEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clscss_ControlEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clscss_ControlDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_ControlDA.GetSpecSQLObj();
strSQL = "Select * from css_Control where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clscss_ControlEN objcss_ControlEN = new clscss_ControlEN()
{
ControlId = objRow[concss_Control.ControlId].ToString().Trim(), //控件ID
ControlName = objRow[concss_Control.ControlName].ToString().Trim(), //控件名称
ControlENName = objRow[concss_Control.ControlENName].ToString().Trim(), //控件英文名
IsDeleted = TransNullToBool(objRow[concss_Control.IsDeleted].ToString().Trim()), //是否删除
DeletedDate = objRow[concss_Control.DeletedDate].ToString().Trim(), //删除日期
UpdDate = objRow[concss_Control.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[concss_Control.UpdUser].ToString().Trim(), //修改者
Memo = objRow[concss_Control.Memo].ToString().Trim() //说明
};
objcss_ControlEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcss_ControlEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clscss_ControlDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clscss_ControlEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clscss_ControlEN objcss_ControlEN = new clscss_ControlEN();
try
{
objcss_ControlEN.ControlId = objRow[concss_Control.ControlId].ToString().Trim(); //控件ID
objcss_ControlEN.ControlName = objRow[concss_Control.ControlName].ToString().Trim(); //控件名称
objcss_ControlEN.ControlENName = objRow[concss_Control.ControlENName].ToString().Trim(); //控件英文名
objcss_ControlEN.IsDeleted = TransNullToBool(objRow[concss_Control.IsDeleted].ToString().Trim()); //是否删除
objcss_ControlEN.DeletedDate = objRow[concss_Control.DeletedDate].ToString().Trim(); //删除日期
objcss_ControlEN.UpdDate = objRow[concss_Control.UpdDate].ToString().Trim(); //修改日期
objcss_ControlEN.UpdUser = objRow[concss_Control.UpdUser].ToString().Trim(); //修改者
objcss_ControlEN.Memo = objRow[concss_Control.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clscss_ControlDA: GetObjByDataRowcss_Control)", objException.Message));
}
objcss_ControlEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcss_ControlEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clscss_ControlEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clscss_ControlEN objcss_ControlEN = new clscss_ControlEN();
try
{
objcss_ControlEN.ControlId = objRow[concss_Control.ControlId].ToString().Trim(); //控件ID
objcss_ControlEN.ControlName = objRow[concss_Control.ControlName].ToString().Trim(); //控件名称
objcss_ControlEN.ControlENName = objRow[concss_Control.ControlENName].ToString().Trim(); //控件英文名
objcss_ControlEN.IsDeleted = TransNullToBool(objRow[concss_Control.IsDeleted].ToString().Trim()); //是否删除
objcss_ControlEN.DeletedDate = objRow[concss_Control.DeletedDate].ToString().Trim(); //删除日期
objcss_ControlEN.UpdDate = objRow[concss_Control.UpdDate].ToString().Trim(); //修改日期
objcss_ControlEN.UpdUser = objRow[concss_Control.UpdUser].ToString().Trim(); //修改者
objcss_ControlEN.Memo = objRow[concss_Control.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clscss_ControlDA: GetObjByDataRow)", objException.Message));
}
objcss_ControlEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcss_ControlEN;
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
objSQL = clscss_ControlDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clscss_ControlEN._CurrTabName, concss_Control.ControlId, 8, "");
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
objSQL = clscss_ControlDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clscss_ControlEN._CurrTabName, concss_Control.ControlId, 8, strPrefix);
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
 objSQL = clscss_ControlDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ControlId from css_Control where " + strCondition;
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
 objSQL = clscss_ControlDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ControlId from css_Control where " + strCondition;
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
 /// <param name = "strControlId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strControlId)
{
CheckPrimaryKey(strControlId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_ControlDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("css_Control", "ControlId = " + "'"+ strControlId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clscss_ControlDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_ControlDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("css_Control", strCondition))
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
objSQL = clscss_ControlDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("css_Control");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clscss_ControlEN objcss_ControlEN)
 {
 objcss_ControlEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcss_ControlEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcss_ControlEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_ControlDA.GetSpecSQLObj();
strSQL = "Select * from css_Control where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "css_Control");
objRow = objDS.Tables["css_Control"].NewRow();
objRow[concss_Control.ControlId] = objcss_ControlEN.ControlId; //控件ID
objRow[concss_Control.ControlName] = objcss_ControlEN.ControlName; //控件名称
 if (objcss_ControlEN.ControlENName !=  "")
 {
objRow[concss_Control.ControlENName] = objcss_ControlEN.ControlENName; //控件英文名
 }
objRow[concss_Control.IsDeleted] = objcss_ControlEN.IsDeleted; //是否删除
 if (objcss_ControlEN.DeletedDate !=  "")
 {
objRow[concss_Control.DeletedDate] = objcss_ControlEN.DeletedDate; //删除日期
 }
 if (objcss_ControlEN.UpdDate !=  "")
 {
objRow[concss_Control.UpdDate] = objcss_ControlEN.UpdDate; //修改日期
 }
 if (objcss_ControlEN.UpdUser !=  "")
 {
objRow[concss_Control.UpdUser] = objcss_ControlEN.UpdUser; //修改者
 }
 if (objcss_ControlEN.Memo !=  "")
 {
objRow[concss_Control.Memo] = objcss_ControlEN.Memo; //说明
 }
objDS.Tables[clscss_ControlEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clscss_ControlEN._CurrTabName);
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
 /// <param name = "objcss_ControlEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clscss_ControlEN objcss_ControlEN)
{
 objcss_ControlEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcss_ControlEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcss_ControlEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objcss_ControlEN.ControlId !=  null)
 {
 arrFieldListForInsert.Add(concss_Control.ControlId);
 objcss_ControlEN.ControlId = objcss_ControlEN.ControlId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objcss_ControlEN.ControlId + "'");
 }
 
 if (objcss_ControlEN.ControlName !=  null)
 {
 arrFieldListForInsert.Add(concss_Control.ControlName);
 objcss_ControlEN.ControlName = objcss_ControlEN.ControlName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objcss_ControlEN.ControlName + "'");
 }
 
 if (objcss_ControlEN.ControlENName !=  null)
 {
 arrFieldListForInsert.Add(concss_Control.ControlENName);
 objcss_ControlEN.ControlENName = objcss_ControlEN.ControlENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objcss_ControlEN.ControlENName + "'");
 }
 
 arrFieldListForInsert.Add(concss_Control.IsDeleted);
 arrValueListForInsert.Add("'" + (objcss_ControlEN.IsDeleted  ==  false ? "0" : "1") + "'");
 
 if (objcss_ControlEN.DeletedDate !=  null)
 {
 arrFieldListForInsert.Add(concss_Control.DeletedDate);
 objcss_ControlEN.DeletedDate = objcss_ControlEN.DeletedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objcss_ControlEN.DeletedDate + "'");
 }
 
 if (objcss_ControlEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concss_Control.UpdDate);
 objcss_ControlEN.UpdDate = objcss_ControlEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objcss_ControlEN.UpdDate + "'");
 }
 
 if (objcss_ControlEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(concss_Control.UpdUser);
 objcss_ControlEN.UpdUser = objcss_ControlEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objcss_ControlEN.UpdUser + "'");
 }
 
 if (objcss_ControlEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concss_Control.Memo);
 objcss_ControlEN.Memo = objcss_ControlEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objcss_ControlEN.Memo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into css_Control");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_ControlDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objcss_ControlEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clscss_ControlEN objcss_ControlEN)
{
 objcss_ControlEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcss_ControlEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcss_ControlEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objcss_ControlEN.ControlId !=  null)
 {
 arrFieldListForInsert.Add(concss_Control.ControlId);
 objcss_ControlEN.ControlId = objcss_ControlEN.ControlId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objcss_ControlEN.ControlId + "'");
 }
 
 if (objcss_ControlEN.ControlName !=  null)
 {
 arrFieldListForInsert.Add(concss_Control.ControlName);
 objcss_ControlEN.ControlName = objcss_ControlEN.ControlName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objcss_ControlEN.ControlName + "'");
 }
 
 if (objcss_ControlEN.ControlENName !=  null)
 {
 arrFieldListForInsert.Add(concss_Control.ControlENName);
 objcss_ControlEN.ControlENName = objcss_ControlEN.ControlENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objcss_ControlEN.ControlENName + "'");
 }
 
 arrFieldListForInsert.Add(concss_Control.IsDeleted);
 arrValueListForInsert.Add("'" + (objcss_ControlEN.IsDeleted  ==  false ? "0" : "1") + "'");
 
 if (objcss_ControlEN.DeletedDate !=  null)
 {
 arrFieldListForInsert.Add(concss_Control.DeletedDate);
 objcss_ControlEN.DeletedDate = objcss_ControlEN.DeletedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objcss_ControlEN.DeletedDate + "'");
 }
 
 if (objcss_ControlEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concss_Control.UpdDate);
 objcss_ControlEN.UpdDate = objcss_ControlEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objcss_ControlEN.UpdDate + "'");
 }
 
 if (objcss_ControlEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(concss_Control.UpdUser);
 objcss_ControlEN.UpdUser = objcss_ControlEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objcss_ControlEN.UpdUser + "'");
 }
 
 if (objcss_ControlEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concss_Control.Memo);
 objcss_ControlEN.Memo = objcss_ControlEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objcss_ControlEN.Memo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into css_Control");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_ControlDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objcss_ControlEN.ControlId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objcss_ControlEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clscss_ControlEN objcss_ControlEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objcss_ControlEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcss_ControlEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcss_ControlEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objcss_ControlEN.ControlId !=  null)
 {
 arrFieldListForInsert.Add(concss_Control.ControlId);
 objcss_ControlEN.ControlId = objcss_ControlEN.ControlId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objcss_ControlEN.ControlId + "'");
 }
 
 if (objcss_ControlEN.ControlName !=  null)
 {
 arrFieldListForInsert.Add(concss_Control.ControlName);
 objcss_ControlEN.ControlName = objcss_ControlEN.ControlName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objcss_ControlEN.ControlName + "'");
 }
 
 if (objcss_ControlEN.ControlENName !=  null)
 {
 arrFieldListForInsert.Add(concss_Control.ControlENName);
 objcss_ControlEN.ControlENName = objcss_ControlEN.ControlENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objcss_ControlEN.ControlENName + "'");
 }
 
 arrFieldListForInsert.Add(concss_Control.IsDeleted);
 arrValueListForInsert.Add("'" + (objcss_ControlEN.IsDeleted  ==  false ? "0" : "1") + "'");
 
 if (objcss_ControlEN.DeletedDate !=  null)
 {
 arrFieldListForInsert.Add(concss_Control.DeletedDate);
 objcss_ControlEN.DeletedDate = objcss_ControlEN.DeletedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objcss_ControlEN.DeletedDate + "'");
 }
 
 if (objcss_ControlEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concss_Control.UpdDate);
 objcss_ControlEN.UpdDate = objcss_ControlEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objcss_ControlEN.UpdDate + "'");
 }
 
 if (objcss_ControlEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(concss_Control.UpdUser);
 objcss_ControlEN.UpdUser = objcss_ControlEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objcss_ControlEN.UpdUser + "'");
 }
 
 if (objcss_ControlEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concss_Control.Memo);
 objcss_ControlEN.Memo = objcss_ControlEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objcss_ControlEN.Memo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into css_Control");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_ControlDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objcss_ControlEN.ControlId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objcss_ControlEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clscss_ControlEN objcss_ControlEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objcss_ControlEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcss_ControlEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcss_ControlEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objcss_ControlEN.ControlId !=  null)
 {
 arrFieldListForInsert.Add(concss_Control.ControlId);
 objcss_ControlEN.ControlId = objcss_ControlEN.ControlId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objcss_ControlEN.ControlId + "'");
 }
 
 if (objcss_ControlEN.ControlName !=  null)
 {
 arrFieldListForInsert.Add(concss_Control.ControlName);
 objcss_ControlEN.ControlName = objcss_ControlEN.ControlName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objcss_ControlEN.ControlName + "'");
 }
 
 if (objcss_ControlEN.ControlENName !=  null)
 {
 arrFieldListForInsert.Add(concss_Control.ControlENName);
 objcss_ControlEN.ControlENName = objcss_ControlEN.ControlENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objcss_ControlEN.ControlENName + "'");
 }
 
 arrFieldListForInsert.Add(concss_Control.IsDeleted);
 arrValueListForInsert.Add("'" + (objcss_ControlEN.IsDeleted  ==  false ? "0" : "1") + "'");
 
 if (objcss_ControlEN.DeletedDate !=  null)
 {
 arrFieldListForInsert.Add(concss_Control.DeletedDate);
 objcss_ControlEN.DeletedDate = objcss_ControlEN.DeletedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objcss_ControlEN.DeletedDate + "'");
 }
 
 if (objcss_ControlEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concss_Control.UpdDate);
 objcss_ControlEN.UpdDate = objcss_ControlEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objcss_ControlEN.UpdDate + "'");
 }
 
 if (objcss_ControlEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(concss_Control.UpdUser);
 objcss_ControlEN.UpdUser = objcss_ControlEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objcss_ControlEN.UpdUser + "'");
 }
 
 if (objcss_ControlEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concss_Control.Memo);
 objcss_ControlEN.Memo = objcss_ControlEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objcss_ControlEN.Memo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into css_Control");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_ControlDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewcss_Controls(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_ControlDA.GetSpecSQLObj();
strSQL = "Select * from css_Control where ControlId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "css_Control");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strControlId = oRow[concss_Control.ControlId].ToString().Trim();
if (IsExist(strControlId))
{
 string strResult = "关键字变量值为:" + string.Format("ControlId = {0}", strControlId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clscss_ControlEN._CurrTabName ].NewRow();
objRow[concss_Control.ControlId] = oRow[concss_Control.ControlId].ToString().Trim(); //控件ID
objRow[concss_Control.ControlName] = oRow[concss_Control.ControlName].ToString().Trim(); //控件名称
objRow[concss_Control.ControlENName] = oRow[concss_Control.ControlENName].ToString().Trim(); //控件英文名
objRow[concss_Control.IsDeleted] = oRow[concss_Control.IsDeleted].ToString().Trim(); //是否删除
objRow[concss_Control.DeletedDate] = oRow[concss_Control.DeletedDate].ToString().Trim(); //删除日期
objRow[concss_Control.UpdDate] = oRow[concss_Control.UpdDate].ToString().Trim(); //修改日期
objRow[concss_Control.UpdUser] = oRow[concss_Control.UpdUser].ToString().Trim(); //修改者
objRow[concss_Control.Memo] = oRow[concss_Control.Memo].ToString().Trim(); //说明
 objDS.Tables[clscss_ControlEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clscss_ControlEN._CurrTabName);
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
 /// <param name = "objcss_ControlEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clscss_ControlEN objcss_ControlEN)
{
 objcss_ControlEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcss_ControlEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcss_ControlEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_ControlDA.GetSpecSQLObj();
strSQL = "Select * from css_Control where ControlId = " + "'"+ objcss_ControlEN.ControlId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clscss_ControlEN._CurrTabName);
if (objDS.Tables[clscss_ControlEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:ControlId = " + "'"+ objcss_ControlEN.ControlId+"'");
return false;
}
objRow = objDS.Tables[clscss_ControlEN._CurrTabName].Rows[0];
 if (objcss_ControlEN.IsUpdated(concss_Control.ControlId))
 {
objRow[concss_Control.ControlId] = objcss_ControlEN.ControlId; //控件ID
 }
 if (objcss_ControlEN.IsUpdated(concss_Control.ControlName))
 {
objRow[concss_Control.ControlName] = objcss_ControlEN.ControlName; //控件名称
 }
 if (objcss_ControlEN.IsUpdated(concss_Control.ControlENName))
 {
objRow[concss_Control.ControlENName] = objcss_ControlEN.ControlENName; //控件英文名
 }
 if (objcss_ControlEN.IsUpdated(concss_Control.IsDeleted))
 {
objRow[concss_Control.IsDeleted] = objcss_ControlEN.IsDeleted; //是否删除
 }
 if (objcss_ControlEN.IsUpdated(concss_Control.DeletedDate))
 {
objRow[concss_Control.DeletedDate] = objcss_ControlEN.DeletedDate; //删除日期
 }
 if (objcss_ControlEN.IsUpdated(concss_Control.UpdDate))
 {
objRow[concss_Control.UpdDate] = objcss_ControlEN.UpdDate; //修改日期
 }
 if (objcss_ControlEN.IsUpdated(concss_Control.UpdUser))
 {
objRow[concss_Control.UpdUser] = objcss_ControlEN.UpdUser; //修改者
 }
 if (objcss_ControlEN.IsUpdated(concss_Control.Memo))
 {
objRow[concss_Control.Memo] = objcss_ControlEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clscss_ControlEN._CurrTabName);
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
 /// <param name = "objcss_ControlEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clscss_ControlEN objcss_ControlEN)
{
 objcss_ControlEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcss_ControlEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcss_ControlEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_ControlDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update css_Control Set ");
 
 if (objcss_ControlEN.IsUpdated(concss_Control.ControlName))
 {
 if (objcss_ControlEN.ControlName !=  null)
 {
 objcss_ControlEN.ControlName = objcss_ControlEN.ControlName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objcss_ControlEN.ControlName, concss_Control.ControlName); //控件名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_Control.ControlName); //控件名称
 }
 }
 
 if (objcss_ControlEN.IsUpdated(concss_Control.ControlENName))
 {
 if (objcss_ControlEN.ControlENName !=  null)
 {
 objcss_ControlEN.ControlENName = objcss_ControlEN.ControlENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objcss_ControlEN.ControlENName, concss_Control.ControlENName); //控件英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_Control.ControlENName); //控件英文名
 }
 }
 
 if (objcss_ControlEN.IsUpdated(concss_Control.IsDeleted))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcss_ControlEN.IsDeleted == true?"1":"0", concss_Control.IsDeleted); //是否删除
 }
 
 if (objcss_ControlEN.IsUpdated(concss_Control.DeletedDate))
 {
 if (objcss_ControlEN.DeletedDate !=  null)
 {
 objcss_ControlEN.DeletedDate = objcss_ControlEN.DeletedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objcss_ControlEN.DeletedDate, concss_Control.DeletedDate); //删除日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_Control.DeletedDate); //删除日期
 }
 }
 
 if (objcss_ControlEN.IsUpdated(concss_Control.UpdDate))
 {
 if (objcss_ControlEN.UpdDate !=  null)
 {
 objcss_ControlEN.UpdDate = objcss_ControlEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objcss_ControlEN.UpdDate, concss_Control.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_Control.UpdDate); //修改日期
 }
 }
 
 if (objcss_ControlEN.IsUpdated(concss_Control.UpdUser))
 {
 if (objcss_ControlEN.UpdUser !=  null)
 {
 objcss_ControlEN.UpdUser = objcss_ControlEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objcss_ControlEN.UpdUser, concss_Control.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_Control.UpdUser); //修改者
 }
 }
 
 if (objcss_ControlEN.IsUpdated(concss_Control.Memo))
 {
 if (objcss_ControlEN.Memo !=  null)
 {
 objcss_ControlEN.Memo = objcss_ControlEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objcss_ControlEN.Memo, concss_Control.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_Control.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ControlId = '{0}'", objcss_ControlEN.ControlId); 
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
 /// <param name = "objcss_ControlEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clscss_ControlEN objcss_ControlEN, string strCondition)
{
 objcss_ControlEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcss_ControlEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcss_ControlEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_ControlDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update css_Control Set ");
 
 if (objcss_ControlEN.IsUpdated(concss_Control.ControlName))
 {
 if (objcss_ControlEN.ControlName !=  null)
 {
 objcss_ControlEN.ControlName = objcss_ControlEN.ControlName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ControlName = '{0}',", objcss_ControlEN.ControlName); //控件名称
 }
 else
 {
 sbSQL.Append(" ControlName = null,"); //控件名称
 }
 }
 
 if (objcss_ControlEN.IsUpdated(concss_Control.ControlENName))
 {
 if (objcss_ControlEN.ControlENName !=  null)
 {
 objcss_ControlEN.ControlENName = objcss_ControlEN.ControlENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ControlENName = '{0}',", objcss_ControlEN.ControlENName); //控件英文名
 }
 else
 {
 sbSQL.Append(" ControlENName = null,"); //控件英文名
 }
 }
 
 if (objcss_ControlEN.IsUpdated(concss_Control.IsDeleted))
 {
 sbSQL.AppendFormat(" IsDeleted = '{0}',", objcss_ControlEN.IsDeleted == true?"1":"0"); //是否删除
 }
 
 if (objcss_ControlEN.IsUpdated(concss_Control.DeletedDate))
 {
 if (objcss_ControlEN.DeletedDate !=  null)
 {
 objcss_ControlEN.DeletedDate = objcss_ControlEN.DeletedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DeletedDate = '{0}',", objcss_ControlEN.DeletedDate); //删除日期
 }
 else
 {
 sbSQL.Append(" DeletedDate = null,"); //删除日期
 }
 }
 
 if (objcss_ControlEN.IsUpdated(concss_Control.UpdDate))
 {
 if (objcss_ControlEN.UpdDate !=  null)
 {
 objcss_ControlEN.UpdDate = objcss_ControlEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", objcss_ControlEN.UpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objcss_ControlEN.IsUpdated(concss_Control.UpdUser))
 {
 if (objcss_ControlEN.UpdUser !=  null)
 {
 objcss_ControlEN.UpdUser = objcss_ControlEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", objcss_ControlEN.UpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objcss_ControlEN.IsUpdated(concss_Control.Memo))
 {
 if (objcss_ControlEN.Memo !=  null)
 {
 objcss_ControlEN.Memo = objcss_ControlEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", objcss_ControlEN.Memo); //说明
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
 /// <param name = "objcss_ControlEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clscss_ControlEN objcss_ControlEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objcss_ControlEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcss_ControlEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcss_ControlEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_ControlDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update css_Control Set ");
 
 if (objcss_ControlEN.IsUpdated(concss_Control.ControlName))
 {
 if (objcss_ControlEN.ControlName !=  null)
 {
 objcss_ControlEN.ControlName = objcss_ControlEN.ControlName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ControlName = '{0}',", objcss_ControlEN.ControlName); //控件名称
 }
 else
 {
 sbSQL.Append(" ControlName = null,"); //控件名称
 }
 }
 
 if (objcss_ControlEN.IsUpdated(concss_Control.ControlENName))
 {
 if (objcss_ControlEN.ControlENName !=  null)
 {
 objcss_ControlEN.ControlENName = objcss_ControlEN.ControlENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ControlENName = '{0}',", objcss_ControlEN.ControlENName); //控件英文名
 }
 else
 {
 sbSQL.Append(" ControlENName = null,"); //控件英文名
 }
 }
 
 if (objcss_ControlEN.IsUpdated(concss_Control.IsDeleted))
 {
 sbSQL.AppendFormat(" IsDeleted = '{0}',", objcss_ControlEN.IsDeleted == true?"1":"0"); //是否删除
 }
 
 if (objcss_ControlEN.IsUpdated(concss_Control.DeletedDate))
 {
 if (objcss_ControlEN.DeletedDate !=  null)
 {
 objcss_ControlEN.DeletedDate = objcss_ControlEN.DeletedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DeletedDate = '{0}',", objcss_ControlEN.DeletedDate); //删除日期
 }
 else
 {
 sbSQL.Append(" DeletedDate = null,"); //删除日期
 }
 }
 
 if (objcss_ControlEN.IsUpdated(concss_Control.UpdDate))
 {
 if (objcss_ControlEN.UpdDate !=  null)
 {
 objcss_ControlEN.UpdDate = objcss_ControlEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", objcss_ControlEN.UpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objcss_ControlEN.IsUpdated(concss_Control.UpdUser))
 {
 if (objcss_ControlEN.UpdUser !=  null)
 {
 objcss_ControlEN.UpdUser = objcss_ControlEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", objcss_ControlEN.UpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objcss_ControlEN.IsUpdated(concss_Control.Memo))
 {
 if (objcss_ControlEN.Memo !=  null)
 {
 objcss_ControlEN.Memo = objcss_ControlEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", objcss_ControlEN.Memo); //说明
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
 /// <param name = "objcss_ControlEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clscss_ControlEN objcss_ControlEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objcss_ControlEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcss_ControlEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcss_ControlEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_ControlDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update css_Control Set ");
 
 if (objcss_ControlEN.IsUpdated(concss_Control.ControlName))
 {
 if (objcss_ControlEN.ControlName !=  null)
 {
 objcss_ControlEN.ControlName = objcss_ControlEN.ControlName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objcss_ControlEN.ControlName, concss_Control.ControlName); //控件名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_Control.ControlName); //控件名称
 }
 }
 
 if (objcss_ControlEN.IsUpdated(concss_Control.ControlENName))
 {
 if (objcss_ControlEN.ControlENName !=  null)
 {
 objcss_ControlEN.ControlENName = objcss_ControlEN.ControlENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objcss_ControlEN.ControlENName, concss_Control.ControlENName); //控件英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_Control.ControlENName); //控件英文名
 }
 }
 
 if (objcss_ControlEN.IsUpdated(concss_Control.IsDeleted))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcss_ControlEN.IsDeleted == true?"1":"0", concss_Control.IsDeleted); //是否删除
 }
 
 if (objcss_ControlEN.IsUpdated(concss_Control.DeletedDate))
 {
 if (objcss_ControlEN.DeletedDate !=  null)
 {
 objcss_ControlEN.DeletedDate = objcss_ControlEN.DeletedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objcss_ControlEN.DeletedDate, concss_Control.DeletedDate); //删除日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_Control.DeletedDate); //删除日期
 }
 }
 
 if (objcss_ControlEN.IsUpdated(concss_Control.UpdDate))
 {
 if (objcss_ControlEN.UpdDate !=  null)
 {
 objcss_ControlEN.UpdDate = objcss_ControlEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objcss_ControlEN.UpdDate, concss_Control.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_Control.UpdDate); //修改日期
 }
 }
 
 if (objcss_ControlEN.IsUpdated(concss_Control.UpdUser))
 {
 if (objcss_ControlEN.UpdUser !=  null)
 {
 objcss_ControlEN.UpdUser = objcss_ControlEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objcss_ControlEN.UpdUser, concss_Control.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_Control.UpdUser); //修改者
 }
 }
 
 if (objcss_ControlEN.IsUpdated(concss_Control.Memo))
 {
 if (objcss_ControlEN.Memo !=  null)
 {
 objcss_ControlEN.Memo = objcss_ControlEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objcss_ControlEN.Memo, concss_Control.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_Control.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ControlId = '{0}'", objcss_ControlEN.ControlId); 
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
 /// <param name = "strControlId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strControlId) 
{
CheckPrimaryKey(strControlId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_ControlDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strControlId,
};
 objSQL.ExecSP("css_Control_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strControlId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strControlId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strControlId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_ControlDA.GetSpecSQLObj();
//删除css_Control本表中与当前对象有关的记录
strSQL = strSQL + "Delete from css_Control where ControlId = " + "'"+ strControlId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delcss_Control(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_ControlDA.GetSpecSQLObj();
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
//删除css_Control本表中与当前对象有关的记录
strSQL = strSQL + "Delete from css_Control where ControlId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strControlId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strControlId) 
{
CheckPrimaryKey(strControlId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_ControlDA.GetSpecSQLObj();
//删除css_Control本表中与当前对象有关的记录
strSQL = strSQL + "Delete from css_Control where ControlId = " + "'"+ strControlId+"'";
 return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:根据标志删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecordBySign)
 /// </summary>
 /// <param name = "strControlId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecordBySign(string strControlId) 
{
CheckPrimaryKey(strControlId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_ControlDA.GetSpecSQLObj();
//删除css_Control本表中与当前对象有关的记录
strSQL = strSQL + string.Format("Update css_Control Set {0}='1', {1} = '{2}' where ControlId = '{3}'",
concss_Control.IsDeleted, concss_Control.DeletedDate, clsDateTime.getTodayDateTimeStr(0), strControlId);
 return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:恢复被删除的记录，针对有删除标志的表
 /// (AutoGCLib.DALCode4CSharp:GenUnDelRecordBySign)
 /// </summary>
 /// <param name = "strControlId">给定的关键字值</param>
 /// <returns>返回恢复删除的记录数</returns>
public int UnDelRecordBySign(string strControlId) 
{
CheckPrimaryKey(strControlId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_ControlDA.GetSpecSQLObj();
//删除css_Control本表中与当前对象有关的记录
strSQL = strSQL + string.Format("Update css_Control Set {0}='0', {1} = '{2}' where ControlId = '{3}'",
concss_Control.IsDeleted, concss_Control.DeletedDate, clsDateTime.getTodayDateTimeStr(0), strControlId);
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delcss_Control(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clscss_ControlDA: Delcss_Control)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_ControlDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from css_Control where " + strCondition ;
}
int intRecoCount = objSQL.ExecSql2(strSQL);
return intRecoCount;
}



 /// <summary>
 /// 功能:删除满足条件的多条记录,同时处理事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRecWithTransaction)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回是否删除成功。</returns>
public bool Delcss_ControlWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clscss_ControlDA: Delcss_ControlWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_ControlDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from css_Control where " + strCondition ;
}
 bool bolResult = objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
return bolResult;
}


 #endregion 删除记录

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objcss_ControlENS">源对象</param>
 /// <param name = "objcss_ControlENT">目标对象</param>
public void CopyTo(clscss_ControlEN objcss_ControlENS, clscss_ControlEN objcss_ControlENT)
{
objcss_ControlENT.ControlId = objcss_ControlENS.ControlId; //控件ID
objcss_ControlENT.ControlName = objcss_ControlENS.ControlName; //控件名称
objcss_ControlENT.ControlENName = objcss_ControlENS.ControlENName; //控件英文名
objcss_ControlENT.IsDeleted = objcss_ControlENS.IsDeleted; //是否删除
objcss_ControlENT.DeletedDate = objcss_ControlENS.DeletedDate; //删除日期
objcss_ControlENT.UpdDate = objcss_ControlENS.UpdDate; //修改日期
objcss_ControlENT.UpdUser = objcss_ControlENS.UpdUser; //修改者
objcss_ControlENT.Memo = objcss_ControlENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clscss_ControlEN objcss_ControlEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objcss_ControlEN.ControlName, concss_Control.ControlName);
//检查字段长度
clsCheckSql.CheckFieldLen(objcss_ControlEN.ControlId, 8, concss_Control.ControlId);
clsCheckSql.CheckFieldLen(objcss_ControlEN.ControlName, 50, concss_Control.ControlName);
clsCheckSql.CheckFieldLen(objcss_ControlEN.ControlENName, 50, concss_Control.ControlENName);
clsCheckSql.CheckFieldLen(objcss_ControlEN.DeletedDate, 50, concss_Control.DeletedDate);
clsCheckSql.CheckFieldLen(objcss_ControlEN.UpdDate, 20, concss_Control.UpdDate);
clsCheckSql.CheckFieldLen(objcss_ControlEN.UpdUser, 20, concss_Control.UpdUser);
clsCheckSql.CheckFieldLen(objcss_ControlEN.Memo, 1000, concss_Control.Memo);
//检查字段外键固定长度
 objcss_ControlEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clscss_ControlEN objcss_ControlEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objcss_ControlEN.ControlName, 50, concss_Control.ControlName);
clsCheckSql.CheckFieldLen(objcss_ControlEN.ControlENName, 50, concss_Control.ControlENName);
clsCheckSql.CheckFieldLen(objcss_ControlEN.DeletedDate, 50, concss_Control.DeletedDate);
clsCheckSql.CheckFieldLen(objcss_ControlEN.UpdDate, 20, concss_Control.UpdDate);
clsCheckSql.CheckFieldLen(objcss_ControlEN.UpdUser, 20, concss_Control.UpdUser);
clsCheckSql.CheckFieldLen(objcss_ControlEN.Memo, 1000, concss_Control.Memo);
//检查外键字段长度
 objcss_ControlEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clscss_ControlEN objcss_ControlEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objcss_ControlEN.ControlId, 8, concss_Control.ControlId);
clsCheckSql.CheckFieldLen(objcss_ControlEN.ControlName, 50, concss_Control.ControlName);
clsCheckSql.CheckFieldLen(objcss_ControlEN.ControlENName, 50, concss_Control.ControlENName);
clsCheckSql.CheckFieldLen(objcss_ControlEN.DeletedDate, 50, concss_Control.DeletedDate);
clsCheckSql.CheckFieldLen(objcss_ControlEN.UpdDate, 20, concss_Control.UpdDate);
clsCheckSql.CheckFieldLen(objcss_ControlEN.UpdUser, 20, concss_Control.UpdUser);
clsCheckSql.CheckFieldLen(objcss_ControlEN.Memo, 1000, concss_Control.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objcss_ControlEN.ControlId, concss_Control.ControlId);
clsCheckSql.CheckSqlInjection4Field(objcss_ControlEN.ControlName, concss_Control.ControlName);
clsCheckSql.CheckSqlInjection4Field(objcss_ControlEN.ControlENName, concss_Control.ControlENName);
clsCheckSql.CheckSqlInjection4Field(objcss_ControlEN.DeletedDate, concss_Control.DeletedDate);
clsCheckSql.CheckSqlInjection4Field(objcss_ControlEN.UpdDate, concss_Control.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objcss_ControlEN.UpdUser, concss_Control.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objcss_ControlEN.Memo, concss_Control.Memo);
//检查外键字段长度
 objcss_ControlEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetControlId()
{
//获取某学院所有专业信息
string strSQL = "select ControlId, ControlName from css_Control ";
 clsSpecSQLforSql mySql = clscss_ControlDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 检查唯一性(Uniqueness)--css_Control(控件), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.clsGeneCodeBase:GenCheckUniquenessV3)
 /// </summary>
 /// <param name = "strControlId">控件ID(主键)</param>
 /// <returns></returns>
public bool Checkcss_ControlUniqueness(string strControlId )
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("ControlId !=  '{0}'", strControlId);
if (IsExistCondRec(sbCondition.ToString())  ==  true)
{
return false;
}
else
{
return true;
}
}
 /// <summary>
 /// 检查唯一性(Uniqueness)--css_Control(控件), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.clsGeneCodeBase:GenCheckUniquenessV3)
 /// </summary>
 /// <returns></returns>
public bool Checkcss_ControlUniqueness()
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
if (IsExistCondRec(sbCondition.ToString())  ==  true)
{
return false;
}
else
{
return true;
}
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
 objSQL = clscss_ControlDA.GetSpecSQLObj();
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
 objSQL = clscss_ControlDA.GetSpecSQLObj();
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
 objSQL = clscss_ControlDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clscss_ControlEN._CurrTabName);
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
 objSQL = clscss_ControlDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clscss_ControlEN._CurrTabName, strCondition);
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
 objSQL = clscss_ControlDA.GetSpecSQLObj();
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
 objSQL = clscss_ControlDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}