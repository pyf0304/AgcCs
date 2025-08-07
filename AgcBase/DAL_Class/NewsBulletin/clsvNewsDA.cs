
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvNewsDA
 表名:vNews(00050480)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:18:04
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:新闻公告(NewsBulletin)
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
 /// v新闻(vNews)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class clsvNewsDA : clsCommBase4DA
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
 return clsvNewsEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvNewsEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvNewsEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvNewsEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvNewsEN._ConnectString);
 }
 return objSQL;
 }


 #region 获取数据表的DataSet

 /// <summary>
 /// 根据条件获取当前表的数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataSetByCond_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据集DataSet</returns>
public System.Data.DataSet GetDataSet(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsvNewsDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvNewsDA.GetSpecSQLObj();
 strSQL = "Select * from vNews where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "vNews");
 return objDS;
}

 /// <summary>
 /// 根据条件获取当前表的数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查,用存储过程来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataSetByCondBySP_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据集DataSet</returns>
public System.Data.DataSet GetDataSetByCondBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsvNewsDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvNewsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("vNews_SelectByCond",values, "vNews");
return objDS;
}

 /// <summary>
 /// 根据条件获取当前表的顶部数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetTopDataSetByCond_S)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据集DataSet</returns>
public System.Data.DataSet GetDataSet_Top(int intTopSize, string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsvNewsDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvNewsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vNews where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "vNews");
 return objDS;
}

 /// <summary>
 /// 根据条件获取一定范围数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataSetByCondByRange_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回数据集DataSet</returns>
public System.Data.DataSet GetDataSetByRange(string strCondition, string strOrderBy, int intMinNum, int intMaxNum)
{
     if (intMinNum <=  0)
 {
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvNewsDA: GetvNewsByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvNewsDA: GetvNewsByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvNewsDA: GetvNewsByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsvNewsDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvNewsDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vNews a where {0} And a.Id_News not in (Select Top {2} Id_News From vNews Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vNews");
return objDS;
}

 /// <summary>
 /// 根据条件获取一定范围的数据表,用DataSet表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataSetByCondByRange_S_Exclude)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns>返回数据集DataSet</returns>
public System.Data.DataSet GetDataSetByRange(string strCondition, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
     if (intMinNum <=  0)
 {
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvNewsDA: GetvNewsByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvNewsDA: GetvNewsByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvNewsDA: GetvNewsByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsvNewsDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvNewsDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vNews a where {0} And a.Id_News not in (Select Top {2} Id_News From vNews Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vNews");
return objDS;
}

 /// <summary>
 /// 根据条件获取一定范围的数据表,用DataSet表示,同时可以决定是否检查SQL攻击
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataSetByCondByRange_S_IsCheckSQLAttack)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查Sql攻击</param>
 /// <returns>返回满足条件一定范围的DataSet</returns>
public System.Data.DataSet GetDataSetByRange(string strCondition, bool bolIsCheckSQLAttack, string strOrderBy, int intMinNum, int intMaxNum)
{
     if (intMinNum <=  0)
 {
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvNewsDA: GetvNewsByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvNewsDA: GetvNewsByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvNewsDA: GetvNewsByRange)", intMaxNum, intMinNum));
 }
try
{
 if (bolIsCheckSQLAttack  ==  true)
 {
 clsCheckSql.CheckStrSQL(strCondition);
 }
 else
 {
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
 }
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsvNewsDA: GetDataSet)ByRange", objException.Message));
}
try
 {
 if (bolIsCheckSQLAttack  ==  true)
 {
 clsCheckSql.CheckStrSQL(strCondition);
 }
 else
 {
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
 }
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsvNewsDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvNewsDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vNews a where {0} And a.Id_News not in (Select Top {2} Id_News From vNews Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vNews");
return objDS;
}

 #endregion 获取数据表的DataSet

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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvNewsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvNewsDA.GetSpecSQLObj();
strSQL = "Select * from vNews where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vNews(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvNewsDA: GetDataTable_vNews)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvNewsDA.GetSpecSQLObj();
strSQL = "Select * from vNews where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvNewsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvNewsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvNewsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvNewsDA.GetSpecSQLObj();
strSQL = "Select * from vNews where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvNewsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvNewsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以决定是否检查SQL攻击
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable_IsCheckSQLAttack)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查Sql攻击</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTable(string strCondition, bool bolIsCheckSQLAttack)
{
try
 {
 if (bolIsCheckSQLAttack  ==  true)
 {
 clsCheckSql.CheckStrSQL(strCondition);
 }
 else
 {
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
 }
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsvNewsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvNewsDA.GetSpecSQLObj();
strSQL = "Select * from vNews where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以决定是否检查SQL攻击
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByTabName_S_IsCheckSQLAttack)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strTabName">表名</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查Sql攻击</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTable(string strCondition, string strTabName, bool bolIsCheckSQLAttack)
{
try
 {
 if (bolIsCheckSQLAttack  ==  true)
 {
 clsCheckSql.CheckStrSQL(strCondition);
 }
 else
 {
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
 }
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsvNewsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvNewsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvNewsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvNewsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vNews where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vNews where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvNewsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvNewsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vNews where {1}", intTopSize, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取顶部记录数据表,用DataTable表示,同时可以决定是否检查SQL攻击
 /// (AutoGCLib.clsGeneCodeBase:Gen_GetDataTable_Top_S_IsCheckSQLAttack)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查Sql攻击</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTable_Top(int intTopSize, string strCondition, bool bolIsCheckSQLAttack)
{
try
 {
 if (bolIsCheckSQLAttack  ==  true)
 {
 clsCheckSql.CheckStrSQL(strCondition);
 }
 else
 {
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
 }
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsvNewsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvNewsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vNews where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvNewsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvNewsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vNews.* from vNews Left Join {1} on {2} where {3} and vNews.Id_News not in (Select top {5} vNews.Id_News from vNews Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vNews where {1} and Id_News not in (Select top {2} Id_News from vNews where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vNews where {1} and Id_News not in (Select top {3} Id_News from vNews where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvNewsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvNewsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vNews.* from vNews Left Join {1} on {2} where {3} and vNews.Id_News not in (Select top {5} vNews.Id_News from vNews Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vNews where {1} and Id_News not in (Select top {2} Id_News from vNews where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vNews where {1} and Id_News not in (Select top {3} Id_News from vNews where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
 }
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取分页记录数据表,用DataTable表示,同时可以决定是否检查SQL攻击
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByPager_S_IsCheckSQLAttack)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查Sql攻击</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strCondition, string strOrderBy, bool bolIsCheckSQLAttack)
{
try
 {
 if (bolIsCheckSQLAttack  ==  true)
 {
 clsCheckSql.CheckStrSQL(strCondition);
 }
 else
 {
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
 }
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsvNewsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvNewsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vNews.* from vNews Left Join {1} on {2} where {3} and vNews.Id_News not in (Select top {5} vNews.Id_News from vNews Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vNews where {1} and Id_News not in (Select top {2} Id_News from vNews where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vNews where {1} and Id_News not in (Select top {3} Id_News from vNews where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
 }
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取一定范围的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByRange_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTableByRange(string strCondition, string strOrderBy, int intMinNum, int intMaxNum)
{
     if (intMinNum <=  0)
 {
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvNewsDA: GetvNewsByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvNewsDA: GetvNewsByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvNewsDA: GetvNewsByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsvNewsDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvNewsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from vNews a where {0} And a.Id_News not in (Select Top {2} Id_News From vNews Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from vNews a where {0} And a.Id_News not in (Select Top {2} Id_News From vNews Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取一定范围的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByRange_S_Exclude)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTableByRange(string strCondition, string strOrderBy, int intMinNum, int intMaxNum, List<string> lstExclude)
{
     if (intMinNum <=  0)
 {
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvNewsDA: GetvNewsByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvNewsDA: GetvNewsByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvNewsDA: GetvNewsByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsvNewsDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvNewsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from vNews a where {0} And a.Id_News not in (Select Top {2} Id_News From vNews Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from vNews a where {0} And a.Id_News not in (Select Top {2} Id_News From vNews Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取一定范围的数据表,用DataTable表示,同时可以决定是否检查SQL攻击
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByRange_S_IsCheckSQLAttack)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查Sql攻击</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTableByRange(string strCondition, string strOrderBy, int intMinNum, int intMaxNum, bool bolIsCheckSQLAttack)
{
     if (intMinNum <=  0)
 {
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvNewsDA: GetvNewsByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvNewsDA: GetvNewsByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvNewsDA: GetvNewsByRange)", intMaxNum, intMinNum));
 }
try
 {
 if (bolIsCheckSQLAttack  ==  true)
 {
 clsCheckSql.CheckStrSQL(strCondition);
 }
 else
 {
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
 }
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsvNewsDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvNewsDA.GetSpecSQLObj();
strSQL = "Select * from vNews where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查, 用存储过程来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableBySP_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTableByCondBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsvNewsDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvNewsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vNews_SelectByCond",values);
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
public List<clsvNewsEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvNewsDA:GetObjLst)", objException.Message));
}
List<clsvNewsEN> arrObjLst = new List<clsvNewsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvNewsDA.GetSpecSQLObj();
strSQL = "Select * from vNews where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvNewsEN objvNewsEN = new clsvNewsEN();
try
{
objvNewsEN.Id_News = TransNullToInt(objRow[convNews.Id_News].ToString().Trim()); //Id_News
objvNewsEN.NewsTypeId = objRow[convNews.NewsTypeId].ToString().Trim(); //信息类型Id
objvNewsEN.NewsTypeName = objRow[convNews.NewsTypeName] == DBNull.Value ? null : objRow[convNews.NewsTypeName].ToString().Trim(); //信息类型名称
objvNewsEN.NewsTitle = objRow[convNews.NewsTitle] == DBNull.Value ? null : objRow[convNews.NewsTitle].ToString().Trim(); //信息标题
objvNewsEN.NewsContent = objRow[convNews.NewsContent] == DBNull.Value ? null : objRow[convNews.NewsContent].ToString().Trim(); //信息内容
objvNewsEN.ImgPath = objRow[convNews.ImgPath] == DBNull.Value ? null : objRow[convNews.ImgPath].ToString().Trim(); //图片路径
objvNewsEN.EditPeople = objRow[convNews.EditPeople] == DBNull.Value ? null : objRow[convNews.EditPeople].ToString().Trim(); //编辑人
objvNewsEN.EditTime = objRow[convNews.EditTime] == DBNull.Value ? null : objRow[convNews.EditTime].ToString().Trim(); //编辑时间
objvNewsEN.Source = objRow[convNews.Source] == DBNull.Value ? null : objRow[convNews.Source].ToString().Trim(); //来源
objvNewsEN.IsTop = TransNullToBool(objRow[convNews.IsTop].ToString().Trim()); //是否置顶
objvNewsEN.Views = objRow[convNews.Views] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convNews.Views].ToString().Trim()); //浏览量
objvNewsEN.Audit = objRow[convNews.Audit] == DBNull.Value ? null : objRow[convNews.Audit].ToString().Trim(); //审核
objvNewsEN.Memo = objRow[convNews.Memo] == DBNull.Value ? null : objRow[convNews.Memo].ToString().Trim(); //说明
objvNewsEN.DeletedDate = objRow[convNews.DeletedDate] == DBNull.Value ? null : objRow[convNews.DeletedDate].ToString().Trim(); //删除日期
objvNewsEN.IsDeleted = TransNullToBool(objRow[convNews.IsDeleted].ToString().Trim()); //是否删除
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvNewsDA: GetObjLst)", objException.Message));
}
objvNewsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvNewsEN);
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
public List<clsvNewsEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvNewsDA:GetObjLstByTabName)", objException.Message));
}
List<clsvNewsEN> arrObjLst = new List<clsvNewsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvNewsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvNewsEN objvNewsEN = new clsvNewsEN();
try
{
objvNewsEN.Id_News = TransNullToInt(objRow[convNews.Id_News].ToString().Trim()); //Id_News
objvNewsEN.NewsTypeId = objRow[convNews.NewsTypeId].ToString().Trim(); //信息类型Id
objvNewsEN.NewsTypeName = objRow[convNews.NewsTypeName] == DBNull.Value ? null : objRow[convNews.NewsTypeName].ToString().Trim(); //信息类型名称
objvNewsEN.NewsTitle = objRow[convNews.NewsTitle] == DBNull.Value ? null : objRow[convNews.NewsTitle].ToString().Trim(); //信息标题
objvNewsEN.NewsContent = objRow[convNews.NewsContent] == DBNull.Value ? null : objRow[convNews.NewsContent].ToString().Trim(); //信息内容
objvNewsEN.ImgPath = objRow[convNews.ImgPath] == DBNull.Value ? null : objRow[convNews.ImgPath].ToString().Trim(); //图片路径
objvNewsEN.EditPeople = objRow[convNews.EditPeople] == DBNull.Value ? null : objRow[convNews.EditPeople].ToString().Trim(); //编辑人
objvNewsEN.EditTime = objRow[convNews.EditTime] == DBNull.Value ? null : objRow[convNews.EditTime].ToString().Trim(); //编辑时间
objvNewsEN.Source = objRow[convNews.Source] == DBNull.Value ? null : objRow[convNews.Source].ToString().Trim(); //来源
objvNewsEN.IsTop = TransNullToBool(objRow[convNews.IsTop].ToString().Trim()); //是否置顶
objvNewsEN.Views = objRow[convNews.Views] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convNews.Views].ToString().Trim()); //浏览量
objvNewsEN.Audit = objRow[convNews.Audit] == DBNull.Value ? null : objRow[convNews.Audit].ToString().Trim(); //审核
objvNewsEN.Memo = objRow[convNews.Memo] == DBNull.Value ? null : objRow[convNews.Memo].ToString().Trim(); //说明
objvNewsEN.DeletedDate = objRow[convNews.DeletedDate] == DBNull.Value ? null : objRow[convNews.DeletedDate].ToString().Trim(); //删除日期
objvNewsEN.IsDeleted = TransNullToBool(objRow[convNews.IsDeleted].ToString().Trim()); //是否删除
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvNewsDA: GetObjLst)", objException.Message));
}
objvNewsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvNewsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsvNewsEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsvNewsDA:GetObjLstBySP)", objException.Message));
}
List<clsvNewsEN> arrObjLst = new List<clsvNewsEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvNewsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vNews_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvNewsEN objvNewsEN = new clsvNewsEN();
try
{
objvNewsEN.Id_News = TransNullToInt(objRow[convNews.Id_News].ToString().Trim()); //Id_News
objvNewsEN.NewsTypeId = objRow[convNews.NewsTypeId].ToString().Trim(); //信息类型Id
objvNewsEN.NewsTypeName = objRow[convNews.NewsTypeName] == DBNull.Value ? null : objRow[convNews.NewsTypeName].ToString().Trim(); //信息类型名称
objvNewsEN.NewsTitle = objRow[convNews.NewsTitle] == DBNull.Value ? null : objRow[convNews.NewsTitle].ToString().Trim(); //信息标题
objvNewsEN.NewsContent = objRow[convNews.NewsContent] == DBNull.Value ? null : objRow[convNews.NewsContent].ToString().Trim(); //信息内容
objvNewsEN.ImgPath = objRow[convNews.ImgPath] == DBNull.Value ? null : objRow[convNews.ImgPath].ToString().Trim(); //图片路径
objvNewsEN.EditPeople = objRow[convNews.EditPeople] == DBNull.Value ? null : objRow[convNews.EditPeople].ToString().Trim(); //编辑人
objvNewsEN.EditTime = objRow[convNews.EditTime] == DBNull.Value ? null : objRow[convNews.EditTime].ToString().Trim(); //编辑时间
objvNewsEN.Source = objRow[convNews.Source] == DBNull.Value ? null : objRow[convNews.Source].ToString().Trim(); //来源
objvNewsEN.IsTop = TransNullToBool(objRow[convNews.IsTop].ToString().Trim()); //是否置顶
objvNewsEN.Views = objRow[convNews.Views] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convNews.Views].ToString().Trim()); //浏览量
objvNewsEN.Audit = objRow[convNews.Audit] == DBNull.Value ? null : objRow[convNews.Audit].ToString().Trim(); //审核
objvNewsEN.Memo = objRow[convNews.Memo] == DBNull.Value ? null : objRow[convNews.Memo].ToString().Trim(); //说明
objvNewsEN.DeletedDate = objRow[convNews.DeletedDate] == DBNull.Value ? null : objRow[convNews.DeletedDate].ToString().Trim(); //删除日期
objvNewsEN.IsDeleted = TransNullToBool(objRow[convNews.IsDeleted].ToString().Trim()); //是否删除
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsvNewsDA: GetObjLstBySP)", objException.Message));
}
objvNewsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvNewsEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvNewsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvNews(ref clsvNewsEN objvNewsEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvNewsDA.GetSpecSQLObj();
strSQL = "Select * from vNews where Id_News = " + ""+ objvNewsEN.Id_News+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvNewsEN.Id_News = TransNullToInt(objDT.Rows[0][convNews.Id_News].ToString().Trim()); //Id_News(字段类型:bigint,字段长度:8,是否可空:False)
 objvNewsEN.NewsTypeId = objDT.Rows[0][convNews.NewsTypeId].ToString().Trim(); //信息类型Id(字段类型:char,字段长度:1,是否可空:False)
 objvNewsEN.NewsTypeName = objDT.Rows[0][convNews.NewsTypeName].ToString().Trim(); //信息类型名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvNewsEN.NewsTitle = objDT.Rows[0][convNews.NewsTitle].ToString().Trim(); //信息标题(字段类型:varchar,字段长度:50,是否可空:True)
 objvNewsEN.NewsContent = objDT.Rows[0][convNews.NewsContent].ToString().Trim(); //信息内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvNewsEN.ImgPath = objDT.Rows[0][convNews.ImgPath].ToString().Trim(); //图片路径(字段类型:varchar,字段长度:500,是否可空:True)
 objvNewsEN.EditPeople = objDT.Rows[0][convNews.EditPeople].ToString().Trim(); //编辑人(字段类型:varchar,字段长度:50,是否可空:True)
 objvNewsEN.EditTime = objDT.Rows[0][convNews.EditTime].ToString().Trim(); //编辑时间(字段类型:varchar,字段长度:20,是否可空:True)
 objvNewsEN.Source = objDT.Rows[0][convNews.Source].ToString().Trim(); //来源(字段类型:varchar,字段长度:50,是否可空:True)
 objvNewsEN.IsTop = TransNullToBool(objDT.Rows[0][convNews.IsTop].ToString().Trim()); //是否置顶(字段类型:bit,字段长度:1,是否可空:True)
 objvNewsEN.Views = TransNullToInt(objDT.Rows[0][convNews.Views].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvNewsEN.Audit = objDT.Rows[0][convNews.Audit].ToString().Trim(); //审核(字段类型:char,字段长度:1,是否可空:True)
 objvNewsEN.Memo = objDT.Rows[0][convNews.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvNewsEN.DeletedDate = objDT.Rows[0][convNews.DeletedDate].ToString().Trim(); //删除日期(字段类型:varchar,字段长度:50,是否可空:True)
 objvNewsEN.IsDeleted = TransNullToBool(objDT.Rows[0][convNews.IsDeleted].ToString().Trim()); //是否删除(字段类型:bit,字段长度:1,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvNewsDA: GetvNews)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngId_News">表关键字</param>
 /// <returns>表对象</returns>
public clsvNewsEN GetObjById_News(long lngId_News)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvNewsDA.GetSpecSQLObj();
strSQL = "Select * from vNews where Id_News = " + ""+ lngId_News+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvNewsEN objvNewsEN = new clsvNewsEN();
try
{
 objvNewsEN.Id_News = Int32.Parse(objRow[convNews.Id_News].ToString().Trim()); //Id_News(字段类型:bigint,字段长度:8,是否可空:False)
 objvNewsEN.NewsTypeId = objRow[convNews.NewsTypeId].ToString().Trim(); //信息类型Id(字段类型:char,字段长度:1,是否可空:False)
 objvNewsEN.NewsTypeName = objRow[convNews.NewsTypeName] == DBNull.Value ? null : objRow[convNews.NewsTypeName].ToString().Trim(); //信息类型名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvNewsEN.NewsTitle = objRow[convNews.NewsTitle] == DBNull.Value ? null : objRow[convNews.NewsTitle].ToString().Trim(); //信息标题(字段类型:varchar,字段长度:50,是否可空:True)
 objvNewsEN.NewsContent = objRow[convNews.NewsContent] == DBNull.Value ? null : objRow[convNews.NewsContent].ToString().Trim(); //信息内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvNewsEN.ImgPath = objRow[convNews.ImgPath] == DBNull.Value ? null : objRow[convNews.ImgPath].ToString().Trim(); //图片路径(字段类型:varchar,字段长度:500,是否可空:True)
 objvNewsEN.EditPeople = objRow[convNews.EditPeople] == DBNull.Value ? null : objRow[convNews.EditPeople].ToString().Trim(); //编辑人(字段类型:varchar,字段长度:50,是否可空:True)
 objvNewsEN.EditTime = objRow[convNews.EditTime] == DBNull.Value ? null : objRow[convNews.EditTime].ToString().Trim(); //编辑时间(字段类型:varchar,字段长度:20,是否可空:True)
 objvNewsEN.Source = objRow[convNews.Source] == DBNull.Value ? null : objRow[convNews.Source].ToString().Trim(); //来源(字段类型:varchar,字段长度:50,是否可空:True)
 objvNewsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[convNews.IsTop].ToString().Trim()); //是否置顶(字段类型:bit,字段长度:1,是否可空:True)
 objvNewsEN.Views = objRow[convNews.Views] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convNews.Views].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvNewsEN.Audit = objRow[convNews.Audit] == DBNull.Value ? null : objRow[convNews.Audit].ToString().Trim(); //审核(字段类型:char,字段长度:1,是否可空:True)
 objvNewsEN.Memo = objRow[convNews.Memo] == DBNull.Value ? null : objRow[convNews.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvNewsEN.DeletedDate = objRow[convNews.DeletedDate] == DBNull.Value ? null : objRow[convNews.DeletedDate].ToString().Trim(); //删除日期(字段类型:varchar,字段长度:50,是否可空:True)
 objvNewsEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[convNews.IsDeleted].ToString().Trim()); //是否删除(字段类型:bit,字段长度:1,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvNewsDA: GetObjById_News)", objException.Message));
}
return objvNewsEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程vNews_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objvNewsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvNewsOneBySP(clsvNewsEN objvNewsEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvNewsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objvNewsEN.Id_News
};
 objDT = objSQL.ExecSpReturnDT("vNews_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objvNewsEN.Id_News = TransNullToInt(objDT.Rows[0][convNews.Id_News].ToString().Trim()); //Id_News(字段类型:bigint,字段长度:8,是否可空:False)
 objvNewsEN.NewsTypeId = objDT.Rows[0][convNews.NewsTypeId].ToString().Trim(); //信息类型Id(字段类型:char,字段长度:1,是否可空:False)
 objvNewsEN.NewsTypeName = objDT.Rows[0][convNews.NewsTypeName].ToString().Trim(); //信息类型名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvNewsEN.NewsTitle = objDT.Rows[0][convNews.NewsTitle].ToString().Trim(); //信息标题(字段类型:varchar,字段长度:50,是否可空:True)
 objvNewsEN.NewsContent = objDT.Rows[0][convNews.NewsContent].ToString().Trim(); //信息内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvNewsEN.ImgPath = objDT.Rows[0][convNews.ImgPath].ToString().Trim(); //图片路径(字段类型:varchar,字段长度:500,是否可空:True)
 objvNewsEN.EditPeople = objDT.Rows[0][convNews.EditPeople].ToString().Trim(); //编辑人(字段类型:varchar,字段长度:50,是否可空:True)
 objvNewsEN.EditTime = objDT.Rows[0][convNews.EditTime].ToString().Trim(); //编辑时间(字段类型:varchar,字段长度:20,是否可空:True)
 objvNewsEN.Source = objDT.Rows[0][convNews.Source].ToString().Trim(); //来源(字段类型:varchar,字段长度:50,是否可空:True)
 objvNewsEN.IsTop = TransNullToBool(objDT.Rows[0][convNews.IsTop].ToString().Trim()); //是否置顶(字段类型:bit,字段长度:1,是否可空:True)
 objvNewsEN.Views = TransNullToInt(objDT.Rows[0][convNews.Views].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvNewsEN.Audit = objDT.Rows[0][convNews.Audit].ToString().Trim(); //审核(字段类型:char,字段长度:1,是否可空:True)
 objvNewsEN.Memo = objDT.Rows[0][convNews.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvNewsEN.DeletedDate = objDT.Rows[0][convNews.DeletedDate].ToString().Trim(); //删除日期(字段类型:varchar,字段长度:50,是否可空:True)
 objvNewsEN.IsDeleted = TransNullToBool(objDT.Rows[0][convNews.IsDeleted].ToString().Trim()); //是否删除(字段类型:bit,字段长度:1,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvNewsEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvNewsDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvNewsDA.GetSpecSQLObj();
strSQL = "Select * from vNews where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvNewsEN objvNewsEN = new clsvNewsEN()
{
Id_News = TransNullToInt(objRow[convNews.Id_News].ToString().Trim()), //Id_News
NewsTypeId = objRow[convNews.NewsTypeId].ToString().Trim(), //信息类型Id
NewsTypeName = objRow[convNews.NewsTypeName] == DBNull.Value ? null : objRow[convNews.NewsTypeName].ToString().Trim(), //信息类型名称
NewsTitle = objRow[convNews.NewsTitle] == DBNull.Value ? null : objRow[convNews.NewsTitle].ToString().Trim(), //信息标题
NewsContent = objRow[convNews.NewsContent] == DBNull.Value ? null : objRow[convNews.NewsContent].ToString().Trim(), //信息内容
ImgPath = objRow[convNews.ImgPath] == DBNull.Value ? null : objRow[convNews.ImgPath].ToString().Trim(), //图片路径
EditPeople = objRow[convNews.EditPeople] == DBNull.Value ? null : objRow[convNews.EditPeople].ToString().Trim(), //编辑人
EditTime = objRow[convNews.EditTime] == DBNull.Value ? null : objRow[convNews.EditTime].ToString().Trim(), //编辑时间
Source = objRow[convNews.Source] == DBNull.Value ? null : objRow[convNews.Source].ToString().Trim(), //来源
IsTop = TransNullToBool(objRow[convNews.IsTop].ToString().Trim()), //是否置顶
Views = objRow[convNews.Views] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convNews.Views].ToString().Trim()), //浏览量
Audit = objRow[convNews.Audit] == DBNull.Value ? null : objRow[convNews.Audit].ToString().Trim(), //审核
Memo = objRow[convNews.Memo] == DBNull.Value ? null : objRow[convNews.Memo].ToString().Trim(), //说明
DeletedDate = objRow[convNews.DeletedDate] == DBNull.Value ? null : objRow[convNews.DeletedDate].ToString().Trim(), //删除日期
IsDeleted = TransNullToBool(objRow[convNews.IsDeleted].ToString().Trim()) //是否删除
};
objvNewsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvNewsEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvNewsDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvNewsEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsvNewsDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvNewsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vNews_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsvNewsEN objvNewsEN = new clsvNewsEN()
{
Id_News = TransNullToInt(objRow[convNews.Id_News].ToString().Trim()), //Id_News
NewsTypeId = objRow[convNews.NewsTypeId].ToString().Trim(), //信息类型Id
NewsTypeName = objRow[convNews.NewsTypeName] == DBNull.Value ? null : objRow[convNews.NewsTypeName].ToString().Trim(), //信息类型名称
NewsTitle = objRow[convNews.NewsTitle] == DBNull.Value ? null : objRow[convNews.NewsTitle].ToString().Trim(), //信息标题
NewsContent = objRow[convNews.NewsContent] == DBNull.Value ? null : objRow[convNews.NewsContent].ToString().Trim(), //信息内容
ImgPath = objRow[convNews.ImgPath] == DBNull.Value ? null : objRow[convNews.ImgPath].ToString().Trim(), //图片路径
EditPeople = objRow[convNews.EditPeople] == DBNull.Value ? null : objRow[convNews.EditPeople].ToString().Trim(), //编辑人
EditTime = objRow[convNews.EditTime] == DBNull.Value ? null : objRow[convNews.EditTime].ToString().Trim(), //编辑时间
Source = objRow[convNews.Source] == DBNull.Value ? null : objRow[convNews.Source].ToString().Trim(), //来源
IsTop = TransNullToBool(objRow[convNews.IsTop].ToString().Trim()), //是否置顶
Views = objRow[convNews.Views] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convNews.Views].ToString().Trim()), //浏览量
Audit = objRow[convNews.Audit] == DBNull.Value ? null : objRow[convNews.Audit].ToString().Trim(), //审核
Memo = objRow[convNews.Memo] == DBNull.Value ? null : objRow[convNews.Memo].ToString().Trim(), //说明
DeletedDate = objRow[convNews.DeletedDate] == DBNull.Value ? null : objRow[convNews.DeletedDate].ToString().Trim(), //删除日期
IsDeleted = TransNullToBool(objRow[convNews.IsDeleted].ToString().Trim()) //是否删除
};
objvNewsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvNewsEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvNewsEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvNewsEN objvNewsEN = new clsvNewsEN();
try
{
objvNewsEN.Id_News = TransNullToInt(objRow[convNews.Id_News].ToString().Trim()); //Id_News
objvNewsEN.NewsTypeId = objRow[convNews.NewsTypeId].ToString().Trim(); //信息类型Id
objvNewsEN.NewsTypeName = objRow[convNews.NewsTypeName] == DBNull.Value ? null : objRow[convNews.NewsTypeName].ToString().Trim(); //信息类型名称
objvNewsEN.NewsTitle = objRow[convNews.NewsTitle] == DBNull.Value ? null : objRow[convNews.NewsTitle].ToString().Trim(); //信息标题
objvNewsEN.NewsContent = objRow[convNews.NewsContent] == DBNull.Value ? null : objRow[convNews.NewsContent].ToString().Trim(); //信息内容
objvNewsEN.ImgPath = objRow[convNews.ImgPath] == DBNull.Value ? null : objRow[convNews.ImgPath].ToString().Trim(); //图片路径
objvNewsEN.EditPeople = objRow[convNews.EditPeople] == DBNull.Value ? null : objRow[convNews.EditPeople].ToString().Trim(); //编辑人
objvNewsEN.EditTime = objRow[convNews.EditTime] == DBNull.Value ? null : objRow[convNews.EditTime].ToString().Trim(); //编辑时间
objvNewsEN.Source = objRow[convNews.Source] == DBNull.Value ? null : objRow[convNews.Source].ToString().Trim(); //来源
objvNewsEN.IsTop = TransNullToBool(objRow[convNews.IsTop].ToString().Trim()); //是否置顶
objvNewsEN.Views = objRow[convNews.Views] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convNews.Views].ToString().Trim()); //浏览量
objvNewsEN.Audit = objRow[convNews.Audit] == DBNull.Value ? null : objRow[convNews.Audit].ToString().Trim(); //审核
objvNewsEN.Memo = objRow[convNews.Memo] == DBNull.Value ? null : objRow[convNews.Memo].ToString().Trim(); //说明
objvNewsEN.DeletedDate = objRow[convNews.DeletedDate] == DBNull.Value ? null : objRow[convNews.DeletedDate].ToString().Trim(); //删除日期
objvNewsEN.IsDeleted = TransNullToBool(objRow[convNews.IsDeleted].ToString().Trim()); //是否删除
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvNewsDA: GetObjByDataRowvNews)", objException.Message));
}
objvNewsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvNewsEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvNewsEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvNewsEN objvNewsEN = new clsvNewsEN();
try
{
objvNewsEN.Id_News = TransNullToInt(objRow[convNews.Id_News].ToString().Trim()); //Id_News
objvNewsEN.NewsTypeId = objRow[convNews.NewsTypeId].ToString().Trim(); //信息类型Id
objvNewsEN.NewsTypeName = objRow[convNews.NewsTypeName] == DBNull.Value ? null : objRow[convNews.NewsTypeName].ToString().Trim(); //信息类型名称
objvNewsEN.NewsTitle = objRow[convNews.NewsTitle] == DBNull.Value ? null : objRow[convNews.NewsTitle].ToString().Trim(); //信息标题
objvNewsEN.NewsContent = objRow[convNews.NewsContent] == DBNull.Value ? null : objRow[convNews.NewsContent].ToString().Trim(); //信息内容
objvNewsEN.ImgPath = objRow[convNews.ImgPath] == DBNull.Value ? null : objRow[convNews.ImgPath].ToString().Trim(); //图片路径
objvNewsEN.EditPeople = objRow[convNews.EditPeople] == DBNull.Value ? null : objRow[convNews.EditPeople].ToString().Trim(); //编辑人
objvNewsEN.EditTime = objRow[convNews.EditTime] == DBNull.Value ? null : objRow[convNews.EditTime].ToString().Trim(); //编辑时间
objvNewsEN.Source = objRow[convNews.Source] == DBNull.Value ? null : objRow[convNews.Source].ToString().Trim(); //来源
objvNewsEN.IsTop = TransNullToBool(objRow[convNews.IsTop].ToString().Trim()); //是否置顶
objvNewsEN.Views = objRow[convNews.Views] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convNews.Views].ToString().Trim()); //浏览量
objvNewsEN.Audit = objRow[convNews.Audit] == DBNull.Value ? null : objRow[convNews.Audit].ToString().Trim(); //审核
objvNewsEN.Memo = objRow[convNews.Memo] == DBNull.Value ? null : objRow[convNews.Memo].ToString().Trim(); //说明
objvNewsEN.DeletedDate = objRow[convNews.DeletedDate] == DBNull.Value ? null : objRow[convNews.DeletedDate].ToString().Trim(); //删除日期
objvNewsEN.IsDeleted = TransNullToBool(objRow[convNews.IsDeleted].ToString().Trim()); //是否删除
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvNewsDA: GetObjByDataRow)", objException.Message));
}
objvNewsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvNewsEN;
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
objSQL = clsvNewsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvNewsEN._CurrTabName, convNews.Id_News, 8, "");
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
objSQL = clsvNewsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvNewsEN._CurrTabName, convNews.Id_News, 8, strPrefix);
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
 objSQL = clsvNewsDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select Id_News from vNews where " + strCondition;
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
 objSQL = clsvNewsDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select Id_News from vNews where " + strCondition;
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
 /// <param name = "lngId_News">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngId_News)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvNewsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vNews", "Id_News = " + ""+ lngId_News+""))
{
return true;
}
else
{
return false;
}
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录, 用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenIsExistBySP)
 /// </summary>
 /// <param name = "lngId_News">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExistBySP(long lngId_News)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvNewsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
lngId_News,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("vNews_IsExist", values);
if (arrReturn[0].ToString()  ==  "1")
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvNewsDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvNewsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vNews", strCondition))
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
objSQL = clsvNewsDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vNews");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvNewsENS">源对象</param>
 /// <param name = "objvNewsENT">目标对象</param>
public void CopyTo(clsvNewsEN objvNewsENS, clsvNewsEN objvNewsENT)
{
objvNewsENT.Id_News = objvNewsENS.Id_News; //Id_News
objvNewsENT.NewsTypeId = objvNewsENS.NewsTypeId; //信息类型Id
objvNewsENT.NewsTypeName = objvNewsENS.NewsTypeName; //信息类型名称
objvNewsENT.NewsTitle = objvNewsENS.NewsTitle; //信息标题
objvNewsENT.NewsContent = objvNewsENS.NewsContent; //信息内容
objvNewsENT.ImgPath = objvNewsENS.ImgPath; //图片路径
objvNewsENT.EditPeople = objvNewsENS.EditPeople; //编辑人
objvNewsENT.EditTime = objvNewsENS.EditTime; //编辑时间
objvNewsENT.Source = objvNewsENS.Source; //来源
objvNewsENT.IsTop = objvNewsENS.IsTop; //是否置顶
objvNewsENT.Views = objvNewsENS.Views; //浏览量
objvNewsENT.Audit = objvNewsENS.Audit; //审核
objvNewsENT.Memo = objvNewsENS.Memo; //说明
objvNewsENT.DeletedDate = objvNewsENS.DeletedDate; //删除日期
objvNewsENT.IsDeleted = objvNewsENS.IsDeleted; //是否删除
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvNewsEN objvNewsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvNewsEN.NewsTypeId, 1, convNews.NewsTypeId);
clsCheckSql.CheckFieldLen(objvNewsEN.NewsTypeName, 50, convNews.NewsTypeName);
clsCheckSql.CheckFieldLen(objvNewsEN.NewsTitle, 50, convNews.NewsTitle);
clsCheckSql.CheckFieldLen(objvNewsEN.ImgPath, 500, convNews.ImgPath);
clsCheckSql.CheckFieldLen(objvNewsEN.EditPeople, 50, convNews.EditPeople);
clsCheckSql.CheckFieldLen(objvNewsEN.EditTime, 20, convNews.EditTime);
clsCheckSql.CheckFieldLen(objvNewsEN.Source, 50, convNews.Source);
clsCheckSql.CheckFieldLen(objvNewsEN.Audit, 1, convNews.Audit);
clsCheckSql.CheckFieldLen(objvNewsEN.Memo, 1000, convNews.Memo);
clsCheckSql.CheckFieldLen(objvNewsEN.DeletedDate, 50, convNews.DeletedDate);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvNewsEN.NewsTypeId, convNews.NewsTypeId);
clsCheckSql.CheckSqlInjection4Field(objvNewsEN.NewsTypeName, convNews.NewsTypeName);
clsCheckSql.CheckSqlInjection4Field(objvNewsEN.NewsTitle, convNews.NewsTitle);
clsCheckSql.CheckSqlInjection4Field(objvNewsEN.ImgPath, convNews.ImgPath);
clsCheckSql.CheckSqlInjection4Field(objvNewsEN.EditPeople, convNews.EditPeople);
clsCheckSql.CheckSqlInjection4Field(objvNewsEN.EditTime, convNews.EditTime);
clsCheckSql.CheckSqlInjection4Field(objvNewsEN.Source, convNews.Source);
clsCheckSql.CheckSqlInjection4Field(objvNewsEN.Audit, convNews.Audit);
clsCheckSql.CheckSqlInjection4Field(objvNewsEN.Memo, convNews.Memo);
clsCheckSql.CheckSqlInjection4Field(objvNewsEN.DeletedDate, convNews.DeletedDate);
//检查外键字段长度
 objvNewsEN._IsCheckProperty = true;
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
 objSQL = clsvNewsDA.GetSpecSQLObj();
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
 objSQL = clsvNewsDA.GetSpecSQLObj();
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
 objSQL = clsvNewsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvNewsEN._CurrTabName);
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
 objSQL = clsvNewsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvNewsEN._CurrTabName, strCondition);
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
 objSQL = clsvNewsDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}