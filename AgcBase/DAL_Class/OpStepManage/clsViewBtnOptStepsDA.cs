
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewBtnOptStepsDA
 表名:ViewBtnOptSteps(00050094)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:17:43
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:操作步骤管理(OpStepManage)
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
 /// 界面按钮操作步骤(ViewBtnOptSteps)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class clsViewBtnOptStepsDA : clsCommBase4DA
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
 return clsViewBtnOptStepsEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsViewBtnOptStepsEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsViewBtnOptStepsEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsViewBtnOptStepsEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsViewBtnOptStepsEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsViewBtnOptStepsDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
 strSQL = "Select * from ViewBtnOptSteps where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "ViewBtnOptSteps");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsViewBtnOptStepsDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("ViewBtnOptSteps_SelectByCond",values, "ViewBtnOptSteps");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsViewBtnOptStepsDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from ViewBtnOptSteps where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "ViewBtnOptSteps");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsViewBtnOptStepsDA: GetViewBtnOptStepsByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsViewBtnOptStepsDA: GetViewBtnOptStepsByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsViewBtnOptStepsDA: GetViewBtnOptStepsByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsViewBtnOptStepsDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from ViewBtnOptSteps a where {0} And a.mId not in (Select Top {2} mId From ViewBtnOptSteps Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "ViewBtnOptSteps");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsViewBtnOptStepsDA: GetViewBtnOptStepsByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsViewBtnOptStepsDA: GetViewBtnOptStepsByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsViewBtnOptStepsDA: GetViewBtnOptStepsByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsViewBtnOptStepsDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from ViewBtnOptSteps a where {0} And a.mId not in (Select Top {2} mId From ViewBtnOptSteps Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "ViewBtnOptSteps");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsViewBtnOptStepsDA: GetViewBtnOptStepsByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsViewBtnOptStepsDA: GetViewBtnOptStepsByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsViewBtnOptStepsDA: GetViewBtnOptStepsByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsViewBtnOptStepsDA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsViewBtnOptStepsDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from ViewBtnOptSteps a where {0} And a.mId not in (Select Top {2} mId From ViewBtnOptSteps Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "ViewBtnOptSteps");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsViewBtnOptStepsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
strSQL = "Select * from ViewBtnOptSteps where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_ViewBtnOptSteps(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsViewBtnOptStepsDA: GetDataTable_ViewBtnOptSteps)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
strSQL = "Select * from ViewBtnOptSteps where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsViewBtnOptStepsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsViewBtnOptStepsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
strSQL = "Select * from ViewBtnOptSteps where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsViewBtnOptStepsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsViewBtnOptStepsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
strSQL = "Select * from ViewBtnOptSteps where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsViewBtnOptStepsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsViewBtnOptStepsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ViewBtnOptSteps where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ViewBtnOptSteps where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsViewBtnOptStepsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from ViewBtnOptSteps where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsViewBtnOptStepsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from ViewBtnOptSteps where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsViewBtnOptStepsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} ViewBtnOptSteps.* from ViewBtnOptSteps Left Join {1} on {2} where {3} and ViewBtnOptSteps.mId not in (Select top {5} ViewBtnOptSteps.mId from ViewBtnOptSteps Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ViewBtnOptSteps where {1} and mId not in (Select top {2} mId from ViewBtnOptSteps where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ViewBtnOptSteps where {1} and mId not in (Select top {3} mId from ViewBtnOptSteps where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsViewBtnOptStepsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} ViewBtnOptSteps.* from ViewBtnOptSteps Left Join {1} on {2} where {3} and ViewBtnOptSteps.mId not in (Select top {5} ViewBtnOptSteps.mId from ViewBtnOptSteps Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ViewBtnOptSteps where {1} and mId not in (Select top {2} mId from ViewBtnOptSteps where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ViewBtnOptSteps where {1} and mId not in (Select top {3} mId from ViewBtnOptSteps where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsViewBtnOptStepsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} ViewBtnOptSteps.* from ViewBtnOptSteps Left Join {1} on {2} where {3} and ViewBtnOptSteps.mId not in (Select top {5} ViewBtnOptSteps.mId from ViewBtnOptSteps Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ViewBtnOptSteps where {1} and mId not in (Select top {2} mId from ViewBtnOptSteps where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ViewBtnOptSteps where {1} and mId not in (Select top {3} mId from ViewBtnOptSteps where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsViewBtnOptStepsDA: GetViewBtnOptStepsByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsViewBtnOptStepsDA: GetViewBtnOptStepsByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsViewBtnOptStepsDA: GetViewBtnOptStepsByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsViewBtnOptStepsDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from ViewBtnOptSteps a where {0} And a.mId not in (Select Top {2} mId From ViewBtnOptSteps Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from ViewBtnOptSteps a where {0} And a.mId not in (Select Top {2} mId From ViewBtnOptSteps Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsViewBtnOptStepsDA: GetViewBtnOptStepsByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsViewBtnOptStepsDA: GetViewBtnOptStepsByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsViewBtnOptStepsDA: GetViewBtnOptStepsByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsViewBtnOptStepsDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from ViewBtnOptSteps a where {0} And a.mId not in (Select Top {2} mId From ViewBtnOptSteps Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from ViewBtnOptSteps a where {0} And a.mId not in (Select Top {2} mId From ViewBtnOptSteps Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsViewBtnOptStepsDA: GetViewBtnOptStepsByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsViewBtnOptStepsDA: GetViewBtnOptStepsByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsViewBtnOptStepsDA: GetViewBtnOptStepsByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsViewBtnOptStepsDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
strSQL = "Select * from ViewBtnOptSteps where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsViewBtnOptStepsDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("ViewBtnOptSteps_SelectByCond",values);
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
public List<clsViewBtnOptStepsEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsViewBtnOptStepsDA:GetObjLst)", objException.Message));
}
List<clsViewBtnOptStepsEN> arrObjLst = new List<clsViewBtnOptStepsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
strSQL = "Select * from ViewBtnOptSteps where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewBtnOptStepsEN objViewBtnOptStepsEN = new clsViewBtnOptStepsEN();
try
{
objViewBtnOptStepsEN.mId = TransNullToInt(objRow[conViewBtnOptSteps.mId].ToString().Trim()); //mId
objViewBtnOptStepsEN.ViewId = objRow[conViewBtnOptSteps.ViewId].ToString().Trim(); //界面Id
objViewBtnOptStepsEN.BtnName = objRow[conViewBtnOptSteps.BtnName].ToString().Trim(); //BtnName
objViewBtnOptStepsEN.BtnOptFunction = objRow[conViewBtnOptSteps.BtnOptFunction].ToString().Trim(); //BtnOptFunction
objViewBtnOptStepsEN.BtnStepDetail = objRow[conViewBtnOptSteps.BtnStepDetail] == DBNull.Value ? null : objRow[conViewBtnOptSteps.BtnStepDetail].ToString().Trim(); //BtnStepDetail
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsViewBtnOptStepsDA: GetObjLst)", objException.Message));
}
objViewBtnOptStepsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objViewBtnOptStepsEN);
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
public List<clsViewBtnOptStepsEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsViewBtnOptStepsDA:GetObjLstByTabName)", objException.Message));
}
List<clsViewBtnOptStepsEN> arrObjLst = new List<clsViewBtnOptStepsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewBtnOptStepsEN objViewBtnOptStepsEN = new clsViewBtnOptStepsEN();
try
{
objViewBtnOptStepsEN.mId = TransNullToInt(objRow[conViewBtnOptSteps.mId].ToString().Trim()); //mId
objViewBtnOptStepsEN.ViewId = objRow[conViewBtnOptSteps.ViewId].ToString().Trim(); //界面Id
objViewBtnOptStepsEN.BtnName = objRow[conViewBtnOptSteps.BtnName].ToString().Trim(); //BtnName
objViewBtnOptStepsEN.BtnOptFunction = objRow[conViewBtnOptSteps.BtnOptFunction].ToString().Trim(); //BtnOptFunction
objViewBtnOptStepsEN.BtnStepDetail = objRow[conViewBtnOptSteps.BtnStepDetail] == DBNull.Value ? null : objRow[conViewBtnOptSteps.BtnStepDetail].ToString().Trim(); //BtnStepDetail
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsViewBtnOptStepsDA: GetObjLst)", objException.Message));
}
objViewBtnOptStepsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objViewBtnOptStepsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsViewBtnOptStepsEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsViewBtnOptStepsDA:GetObjLstBySP)", objException.Message));
}
List<clsViewBtnOptStepsEN> arrObjLst = new List<clsViewBtnOptStepsEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("ViewBtnOptSteps_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewBtnOptStepsEN objViewBtnOptStepsEN = new clsViewBtnOptStepsEN();
try
{
objViewBtnOptStepsEN.mId = TransNullToInt(objRow[conViewBtnOptSteps.mId].ToString().Trim()); //mId
objViewBtnOptStepsEN.ViewId = objRow[conViewBtnOptSteps.ViewId].ToString().Trim(); //界面Id
objViewBtnOptStepsEN.BtnName = objRow[conViewBtnOptSteps.BtnName].ToString().Trim(); //BtnName
objViewBtnOptStepsEN.BtnOptFunction = objRow[conViewBtnOptSteps.BtnOptFunction].ToString().Trim(); //BtnOptFunction
objViewBtnOptStepsEN.BtnStepDetail = objRow[conViewBtnOptSteps.BtnStepDetail] == DBNull.Value ? null : objRow[conViewBtnOptSteps.BtnStepDetail].ToString().Trim(); //BtnStepDetail
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsViewBtnOptStepsDA: GetObjLstBySP)", objException.Message));
}
objViewBtnOptStepsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objViewBtnOptStepsEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objViewBtnOptStepsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetViewBtnOptSteps(ref clsViewBtnOptStepsEN objViewBtnOptStepsEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
strSQL = "Select * from ViewBtnOptSteps where mId = " + ""+ objViewBtnOptStepsEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objViewBtnOptStepsEN.mId = TransNullToInt(objDT.Rows[0][conViewBtnOptSteps.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objViewBtnOptStepsEN.ViewId = objDT.Rows[0][conViewBtnOptSteps.ViewId].ToString().Trim(); //界面Id(字段类型:char,字段长度:8,是否可空:True)
 objViewBtnOptStepsEN.BtnName = objDT.Rows[0][conViewBtnOptSteps.BtnName].ToString().Trim(); //BtnName(字段类型:varchar,字段长度:30,是否可空:False)
 objViewBtnOptStepsEN.BtnOptFunction = objDT.Rows[0][conViewBtnOptSteps.BtnOptFunction].ToString().Trim(); //BtnOptFunction(字段类型:varchar,字段长度:50,是否可空:False)
 objViewBtnOptStepsEN.BtnStepDetail = objDT.Rows[0][conViewBtnOptSteps.BtnStepDetail].ToString().Trim(); //BtnStepDetail(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsViewBtnOptStepsDA: GetViewBtnOptSteps)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsViewBtnOptStepsEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
strSQL = "Select * from ViewBtnOptSteps where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsViewBtnOptStepsEN objViewBtnOptStepsEN = new clsViewBtnOptStepsEN();
try
{
 objViewBtnOptStepsEN.mId = Int32.Parse(objRow[conViewBtnOptSteps.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objViewBtnOptStepsEN.ViewId = objRow[conViewBtnOptSteps.ViewId].ToString().Trim(); //界面Id(字段类型:char,字段长度:8,是否可空:True)
 objViewBtnOptStepsEN.BtnName = objRow[conViewBtnOptSteps.BtnName].ToString().Trim(); //BtnName(字段类型:varchar,字段长度:30,是否可空:False)
 objViewBtnOptStepsEN.BtnOptFunction = objRow[conViewBtnOptSteps.BtnOptFunction].ToString().Trim(); //BtnOptFunction(字段类型:varchar,字段长度:50,是否可空:False)
 objViewBtnOptStepsEN.BtnStepDetail = objRow[conViewBtnOptSteps.BtnStepDetail] == DBNull.Value ? null : objRow[conViewBtnOptSteps.BtnStepDetail].ToString().Trim(); //BtnStepDetail(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsViewBtnOptStepsDA: GetObjBymId)", objException.Message));
}
return objViewBtnOptStepsEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程ViewBtnOptSteps_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objViewBtnOptStepsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetViewBtnOptStepsOneBySP(clsViewBtnOptStepsEN objViewBtnOptStepsEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objViewBtnOptStepsEN.mId
};
 objDT = objSQL.ExecSpReturnDT("ViewBtnOptSteps_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objViewBtnOptStepsEN.mId = TransNullToInt(objDT.Rows[0][conViewBtnOptSteps.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objViewBtnOptStepsEN.ViewId = objDT.Rows[0][conViewBtnOptSteps.ViewId].ToString().Trim(); //界面Id(字段类型:char,字段长度:8,是否可空:True)
 objViewBtnOptStepsEN.BtnName = objDT.Rows[0][conViewBtnOptSteps.BtnName].ToString().Trim(); //BtnName(字段类型:varchar,字段长度:30,是否可空:False)
 objViewBtnOptStepsEN.BtnOptFunction = objDT.Rows[0][conViewBtnOptSteps.BtnOptFunction].ToString().Trim(); //BtnOptFunction(字段类型:varchar,字段长度:50,是否可空:False)
 objViewBtnOptStepsEN.BtnStepDetail = objDT.Rows[0][conViewBtnOptSteps.BtnStepDetail].ToString().Trim(); //BtnStepDetail(字段类型:varchar,字段长度:1000,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsViewBtnOptStepsEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsViewBtnOptStepsDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
strSQL = "Select * from ViewBtnOptSteps where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsViewBtnOptStepsEN objViewBtnOptStepsEN = new clsViewBtnOptStepsEN()
{
mId = TransNullToInt(objRow[conViewBtnOptSteps.mId].ToString().Trim()), //mId
ViewId = objRow[conViewBtnOptSteps.ViewId].ToString().Trim(), //界面Id
BtnName = objRow[conViewBtnOptSteps.BtnName].ToString().Trim(), //BtnName
BtnOptFunction = objRow[conViewBtnOptSteps.BtnOptFunction].ToString().Trim(), //BtnOptFunction
BtnStepDetail = objRow[conViewBtnOptSteps.BtnStepDetail] == DBNull.Value ? null : objRow[conViewBtnOptSteps.BtnStepDetail].ToString().Trim() //BtnStepDetail
};
objViewBtnOptStepsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objViewBtnOptStepsEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsViewBtnOptStepsDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsViewBtnOptStepsEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsViewBtnOptStepsDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("ViewBtnOptSteps_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsViewBtnOptStepsEN objViewBtnOptStepsEN = new clsViewBtnOptStepsEN()
{
mId = TransNullToInt(objRow[conViewBtnOptSteps.mId].ToString().Trim()), //mId
ViewId = objRow[conViewBtnOptSteps.ViewId].ToString().Trim(), //界面Id
BtnName = objRow[conViewBtnOptSteps.BtnName].ToString().Trim(), //BtnName
BtnOptFunction = objRow[conViewBtnOptSteps.BtnOptFunction].ToString().Trim(), //BtnOptFunction
BtnStepDetail = objRow[conViewBtnOptSteps.BtnStepDetail] == DBNull.Value ? null : objRow[conViewBtnOptSteps.BtnStepDetail].ToString().Trim() //BtnStepDetail
};
objViewBtnOptStepsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objViewBtnOptStepsEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsViewBtnOptStepsEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsViewBtnOptStepsEN objViewBtnOptStepsEN = new clsViewBtnOptStepsEN();
try
{
objViewBtnOptStepsEN.mId = TransNullToInt(objRow[conViewBtnOptSteps.mId].ToString().Trim()); //mId
objViewBtnOptStepsEN.ViewId = objRow[conViewBtnOptSteps.ViewId].ToString().Trim(); //界面Id
objViewBtnOptStepsEN.BtnName = objRow[conViewBtnOptSteps.BtnName].ToString().Trim(); //BtnName
objViewBtnOptStepsEN.BtnOptFunction = objRow[conViewBtnOptSteps.BtnOptFunction].ToString().Trim(); //BtnOptFunction
objViewBtnOptStepsEN.BtnStepDetail = objRow[conViewBtnOptSteps.BtnStepDetail] == DBNull.Value ? null : objRow[conViewBtnOptSteps.BtnStepDetail].ToString().Trim(); //BtnStepDetail
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsViewBtnOptStepsDA: GetObjByDataRowViewBtnOptSteps)", objException.Message));
}
objViewBtnOptStepsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objViewBtnOptStepsEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsViewBtnOptStepsEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsViewBtnOptStepsEN objViewBtnOptStepsEN = new clsViewBtnOptStepsEN();
try
{
objViewBtnOptStepsEN.mId = TransNullToInt(objRow[conViewBtnOptSteps.mId].ToString().Trim()); //mId
objViewBtnOptStepsEN.ViewId = objRow[conViewBtnOptSteps.ViewId].ToString().Trim(); //界面Id
objViewBtnOptStepsEN.BtnName = objRow[conViewBtnOptSteps.BtnName].ToString().Trim(); //BtnName
objViewBtnOptStepsEN.BtnOptFunction = objRow[conViewBtnOptSteps.BtnOptFunction].ToString().Trim(); //BtnOptFunction
objViewBtnOptStepsEN.BtnStepDetail = objRow[conViewBtnOptSteps.BtnStepDetail] == DBNull.Value ? null : objRow[conViewBtnOptSteps.BtnStepDetail].ToString().Trim(); //BtnStepDetail
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsViewBtnOptStepsDA: GetObjByDataRow)", objException.Message));
}
objViewBtnOptStepsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objViewBtnOptStepsEN;
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
objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsViewBtnOptStepsEN._CurrTabName, conViewBtnOptSteps.mId, 8, "");
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
objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsViewBtnOptStepsEN._CurrTabName, conViewBtnOptSteps.mId, 8, strPrefix);
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
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from ViewBtnOptSteps where " + strCondition;
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
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from ViewBtnOptSteps where " + strCondition;
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
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ViewBtnOptSteps", "mId = " + ""+ lngmId+""))
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExistBySP(long lngmId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
lngmId,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("ViewBtnOptSteps_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsViewBtnOptStepsDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ViewBtnOptSteps", strCondition))
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
objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("ViewBtnOptSteps");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsViewBtnOptStepsEN objViewBtnOptStepsEN)
 {
 if (objViewBtnOptStepsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewBtnOptStepsEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
strSQL = "Select * from ViewBtnOptSteps where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ViewBtnOptSteps");
objRow = objDS.Tables["ViewBtnOptSteps"].NewRow();
objRow[conViewBtnOptSteps.ViewId] = objViewBtnOptStepsEN.ViewId; //界面Id
objRow[conViewBtnOptSteps.BtnName] = objViewBtnOptStepsEN.BtnName; //BtnName
objRow[conViewBtnOptSteps.BtnOptFunction] = objViewBtnOptStepsEN.BtnOptFunction; //BtnOptFunction
 if (objViewBtnOptStepsEN.BtnStepDetail !=  "")
 {
objRow[conViewBtnOptSteps.BtnStepDetail] = objViewBtnOptStepsEN.BtnStepDetail; //BtnStepDetail
 }
objDS.Tables[clsViewBtnOptStepsEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsViewBtnOptStepsEN._CurrTabName);
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
 /// <param name = "objViewBtnOptStepsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsViewBtnOptStepsEN objViewBtnOptStepsEN)
{
 if (objViewBtnOptStepsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewBtnOptStepsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objViewBtnOptStepsEN.ViewId  ==  "")
 {
 objViewBtnOptStepsEN.ViewId = null;
 }
 if (objViewBtnOptStepsEN.ViewId !=  null)
 {
 arrFieldListForInsert.Add(conViewBtnOptSteps.ViewId);
 objViewBtnOptStepsEN.ViewId = objViewBtnOptStepsEN.ViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewBtnOptStepsEN.ViewId + "'");
 }
 
 if (objViewBtnOptStepsEN.BtnName !=  null)
 {
 arrFieldListForInsert.Add(conViewBtnOptSteps.BtnName);
 objViewBtnOptStepsEN.BtnName = objViewBtnOptStepsEN.BtnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewBtnOptStepsEN.BtnName + "'");
 }
 
 if (objViewBtnOptStepsEN.BtnOptFunction !=  null)
 {
 arrFieldListForInsert.Add(conViewBtnOptSteps.BtnOptFunction);
 objViewBtnOptStepsEN.BtnOptFunction = objViewBtnOptStepsEN.BtnOptFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewBtnOptStepsEN.BtnOptFunction + "'");
 }
 
 if (objViewBtnOptStepsEN.BtnStepDetail !=  null)
 {
 arrFieldListForInsert.Add(conViewBtnOptSteps.BtnStepDetail);
 objViewBtnOptStepsEN.BtnStepDetail = objViewBtnOptStepsEN.BtnStepDetail.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewBtnOptStepsEN.BtnStepDetail + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ViewBtnOptSteps");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objViewBtnOptStepsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsViewBtnOptStepsEN objViewBtnOptStepsEN)
{
 if (objViewBtnOptStepsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewBtnOptStepsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objViewBtnOptStepsEN.ViewId  ==  "")
 {
 objViewBtnOptStepsEN.ViewId = null;
 }
 if (objViewBtnOptStepsEN.ViewId !=  null)
 {
 arrFieldListForInsert.Add(conViewBtnOptSteps.ViewId);
 objViewBtnOptStepsEN.ViewId = objViewBtnOptStepsEN.ViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewBtnOptStepsEN.ViewId + "'");
 }
 
 if (objViewBtnOptStepsEN.BtnName !=  null)
 {
 arrFieldListForInsert.Add(conViewBtnOptSteps.BtnName);
 objViewBtnOptStepsEN.BtnName = objViewBtnOptStepsEN.BtnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewBtnOptStepsEN.BtnName + "'");
 }
 
 if (objViewBtnOptStepsEN.BtnOptFunction !=  null)
 {
 arrFieldListForInsert.Add(conViewBtnOptSteps.BtnOptFunction);
 objViewBtnOptStepsEN.BtnOptFunction = objViewBtnOptStepsEN.BtnOptFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewBtnOptStepsEN.BtnOptFunction + "'");
 }
 
 if (objViewBtnOptStepsEN.BtnStepDetail !=  null)
 {
 arrFieldListForInsert.Add(conViewBtnOptSteps.BtnStepDetail);
 objViewBtnOptStepsEN.BtnStepDetail = objViewBtnOptStepsEN.BtnStepDetail.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewBtnOptStepsEN.BtnStepDetail + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ViewBtnOptSteps");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objViewBtnOptStepsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsViewBtnOptStepsEN objViewBtnOptStepsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objViewBtnOptStepsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewBtnOptStepsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objViewBtnOptStepsEN.ViewId  ==  "")
 {
 objViewBtnOptStepsEN.ViewId = null;
 }
 if (objViewBtnOptStepsEN.ViewId !=  null)
 {
 arrFieldListForInsert.Add(conViewBtnOptSteps.ViewId);
 objViewBtnOptStepsEN.ViewId = objViewBtnOptStepsEN.ViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewBtnOptStepsEN.ViewId + "'");
 }
 
 if (objViewBtnOptStepsEN.BtnName !=  null)
 {
 arrFieldListForInsert.Add(conViewBtnOptSteps.BtnName);
 objViewBtnOptStepsEN.BtnName = objViewBtnOptStepsEN.BtnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewBtnOptStepsEN.BtnName + "'");
 }
 
 if (objViewBtnOptStepsEN.BtnOptFunction !=  null)
 {
 arrFieldListForInsert.Add(conViewBtnOptSteps.BtnOptFunction);
 objViewBtnOptStepsEN.BtnOptFunction = objViewBtnOptStepsEN.BtnOptFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewBtnOptStepsEN.BtnOptFunction + "'");
 }
 
 if (objViewBtnOptStepsEN.BtnStepDetail !=  null)
 {
 arrFieldListForInsert.Add(conViewBtnOptSteps.BtnStepDetail);
 objViewBtnOptStepsEN.BtnStepDetail = objViewBtnOptStepsEN.BtnStepDetail.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewBtnOptStepsEN.BtnStepDetail + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ViewBtnOptSteps");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objViewBtnOptStepsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsViewBtnOptStepsEN objViewBtnOptStepsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objViewBtnOptStepsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewBtnOptStepsEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objViewBtnOptStepsEN.ViewId  ==  "")
 {
 objViewBtnOptStepsEN.ViewId = null;
 }
 if (objViewBtnOptStepsEN.ViewId !=  null)
 {
 arrFieldListForInsert.Add(conViewBtnOptSteps.ViewId);
 objViewBtnOptStepsEN.ViewId = objViewBtnOptStepsEN.ViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewBtnOptStepsEN.ViewId + "'");
 }
 
 if (objViewBtnOptStepsEN.BtnName !=  null)
 {
 arrFieldListForInsert.Add(conViewBtnOptSteps.BtnName);
 objViewBtnOptStepsEN.BtnName = objViewBtnOptStepsEN.BtnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewBtnOptStepsEN.BtnName + "'");
 }
 
 if (objViewBtnOptStepsEN.BtnOptFunction !=  null)
 {
 arrFieldListForInsert.Add(conViewBtnOptSteps.BtnOptFunction);
 objViewBtnOptStepsEN.BtnOptFunction = objViewBtnOptStepsEN.BtnOptFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewBtnOptStepsEN.BtnOptFunction + "'");
 }
 
 if (objViewBtnOptStepsEN.BtnStepDetail !=  null)
 {
 arrFieldListForInsert.Add(conViewBtnOptSteps.BtnStepDetail);
 objViewBtnOptStepsEN.BtnStepDetail = objViewBtnOptStepsEN.BtnStepDetail.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewBtnOptStepsEN.BtnStepDetail + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ViewBtnOptSteps");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:通过存储过程来插入记录
 /// (AutoGCLib.DALCode4CSharp:GenAddnewRecBySP)
 /// </summary>
 /// <param name = "objViewBtnOptStepsEN">需要添加到数据库中的对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddnewViewBtnOptStepsBySP(clsViewBtnOptStepsEN objViewBtnOptStepsEN)
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objViewBtnOptStepsEN.ViewId,
 objViewBtnOptStepsEN.BtnName,
 objViewBtnOptStepsEN.BtnOptFunction,
objViewBtnOptStepsEN.BtnStepDetail
};
 objSQL.ExecSP("ViewBtnOptSteps_Add",values);
return true;
}

 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewViewBtnOptStepss(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
strSQL = "Select * from ViewBtnOptSteps where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ViewBtnOptSteps");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngmId = TransNullToInt(oRow[conViewBtnOptSteps.mId].ToString().Trim());
if (IsExist(lngmId))
{
 string strResult = "关键字变量值为:" + string.Format("mId = {0}", lngmId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsViewBtnOptStepsEN._CurrTabName ].NewRow();
objRow[conViewBtnOptSteps.ViewId] = oRow[conViewBtnOptSteps.ViewId].ToString().Trim(); //界面Id
objRow[conViewBtnOptSteps.BtnName] = oRow[conViewBtnOptSteps.BtnName].ToString().Trim(); //BtnName
objRow[conViewBtnOptSteps.BtnOptFunction] = oRow[conViewBtnOptSteps.BtnOptFunction].ToString().Trim(); //BtnOptFunction
objRow[conViewBtnOptSteps.BtnStepDetail] = oRow[conViewBtnOptSteps.BtnStepDetail].ToString().Trim(); //BtnStepDetail
 objDS.Tables[clsViewBtnOptStepsEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsViewBtnOptStepsEN._CurrTabName);
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
 /// <param name = "objViewBtnOptStepsEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsViewBtnOptStepsEN objViewBtnOptStepsEN)
{
 if (objViewBtnOptStepsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewBtnOptStepsEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
strSQL = "Select * from ViewBtnOptSteps where mId = " + ""+ objViewBtnOptStepsEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsViewBtnOptStepsEN._CurrTabName);
if (objDS.Tables[clsViewBtnOptStepsEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objViewBtnOptStepsEN.mId+"");
return false;
}
objRow = objDS.Tables[clsViewBtnOptStepsEN._CurrTabName].Rows[0];
 if (objViewBtnOptStepsEN.IsUpdated(conViewBtnOptSteps.ViewId))
 {
objRow[conViewBtnOptSteps.ViewId] = objViewBtnOptStepsEN.ViewId; //界面Id
 }
 if (objViewBtnOptStepsEN.IsUpdated(conViewBtnOptSteps.BtnName))
 {
objRow[conViewBtnOptSteps.BtnName] = objViewBtnOptStepsEN.BtnName; //BtnName
 }
 if (objViewBtnOptStepsEN.IsUpdated(conViewBtnOptSteps.BtnOptFunction))
 {
objRow[conViewBtnOptSteps.BtnOptFunction] = objViewBtnOptStepsEN.BtnOptFunction; //BtnOptFunction
 }
 if (objViewBtnOptStepsEN.IsUpdated(conViewBtnOptSteps.BtnStepDetail))
 {
objRow[conViewBtnOptSteps.BtnStepDetail] = objViewBtnOptStepsEN.BtnStepDetail; //BtnStepDetail
 }
try
{
objDA.Update(objDS, clsViewBtnOptStepsEN._CurrTabName);
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
 /// /// 功能:通过存储过程(StoreProcedure)来修改记录
 /// /// 缺点:1、不能支持事务处理.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySP)
 /// </summary>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySP(clsViewBtnOptStepsEN objViewBtnOptStepsEN)
{
 if (objViewBtnOptStepsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewBtnOptStepsEN);
 }
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objViewBtnOptStepsEN.mId,
 objViewBtnOptStepsEN.ViewId,
 objViewBtnOptStepsEN.BtnName,
 objViewBtnOptStepsEN.BtnOptFunction,
 objViewBtnOptStepsEN.BtnStepDetail
};
 objSQL.ExecSP("ViewBtnOptSteps_Update",values);
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySql2)
 /// </summary>
 /// <param name = "objViewBtnOptStepsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsViewBtnOptStepsEN objViewBtnOptStepsEN)
{
 if (objViewBtnOptStepsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewBtnOptStepsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update ViewBtnOptSteps Set ");
 
 if (objViewBtnOptStepsEN.IsUpdated(conViewBtnOptSteps.ViewId))
 {
 if (objViewBtnOptStepsEN.ViewId  ==  "")
 {
 objViewBtnOptStepsEN.ViewId = null;
 }
 if (objViewBtnOptStepsEN.ViewId !=  null)
 {
 objViewBtnOptStepsEN.ViewId = objViewBtnOptStepsEN.ViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objViewBtnOptStepsEN.ViewId, conViewBtnOptSteps.ViewId); //界面Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewBtnOptSteps.ViewId); //界面Id
 }
 }
 
 if (objViewBtnOptStepsEN.IsUpdated(conViewBtnOptSteps.BtnName))
 {
 if (objViewBtnOptStepsEN.BtnName !=  null)
 {
 objViewBtnOptStepsEN.BtnName = objViewBtnOptStepsEN.BtnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objViewBtnOptStepsEN.BtnName, conViewBtnOptSteps.BtnName); //BtnName
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewBtnOptSteps.BtnName); //BtnName
 }
 }
 
 if (objViewBtnOptStepsEN.IsUpdated(conViewBtnOptSteps.BtnOptFunction))
 {
 if (objViewBtnOptStepsEN.BtnOptFunction !=  null)
 {
 objViewBtnOptStepsEN.BtnOptFunction = objViewBtnOptStepsEN.BtnOptFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objViewBtnOptStepsEN.BtnOptFunction, conViewBtnOptSteps.BtnOptFunction); //BtnOptFunction
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewBtnOptSteps.BtnOptFunction); //BtnOptFunction
 }
 }
 
 if (objViewBtnOptStepsEN.IsUpdated(conViewBtnOptSteps.BtnStepDetail))
 {
 if (objViewBtnOptStepsEN.BtnStepDetail !=  null)
 {
 objViewBtnOptStepsEN.BtnStepDetail = objViewBtnOptStepsEN.BtnStepDetail.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objViewBtnOptStepsEN.BtnStepDetail, conViewBtnOptSteps.BtnStepDetail); //BtnStepDetail
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewBtnOptSteps.BtnStepDetail); //BtnStepDetail
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objViewBtnOptStepsEN.mId); 
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
 /// <param name = "objViewBtnOptStepsEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsViewBtnOptStepsEN objViewBtnOptStepsEN, string strCondition)
{
 if (objViewBtnOptStepsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewBtnOptStepsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ViewBtnOptSteps Set ");
 
 if (objViewBtnOptStepsEN.IsUpdated(conViewBtnOptSteps.ViewId))
 {
 if (objViewBtnOptStepsEN.ViewId  ==  "")
 {
 objViewBtnOptStepsEN.ViewId = null;
 }
 if (objViewBtnOptStepsEN.ViewId !=  null)
 {
 objViewBtnOptStepsEN.ViewId = objViewBtnOptStepsEN.ViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewId = '{0}',", objViewBtnOptStepsEN.ViewId); //界面Id
 }
 else
 {
 sbSQL.Append(" ViewId = null,"); //界面Id
 }
 }
 
 if (objViewBtnOptStepsEN.IsUpdated(conViewBtnOptSteps.BtnName))
 {
 if (objViewBtnOptStepsEN.BtnName !=  null)
 {
 objViewBtnOptStepsEN.BtnName = objViewBtnOptStepsEN.BtnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" BtnName = '{0}',", objViewBtnOptStepsEN.BtnName); //BtnName
 }
 else
 {
 sbSQL.Append(" BtnName = null,"); //BtnName
 }
 }
 
 if (objViewBtnOptStepsEN.IsUpdated(conViewBtnOptSteps.BtnOptFunction))
 {
 if (objViewBtnOptStepsEN.BtnOptFunction !=  null)
 {
 objViewBtnOptStepsEN.BtnOptFunction = objViewBtnOptStepsEN.BtnOptFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" BtnOptFunction = '{0}',", objViewBtnOptStepsEN.BtnOptFunction); //BtnOptFunction
 }
 else
 {
 sbSQL.Append(" BtnOptFunction = null,"); //BtnOptFunction
 }
 }
 
 if (objViewBtnOptStepsEN.IsUpdated(conViewBtnOptSteps.BtnStepDetail))
 {
 if (objViewBtnOptStepsEN.BtnStepDetail !=  null)
 {
 objViewBtnOptStepsEN.BtnStepDetail = objViewBtnOptStepsEN.BtnStepDetail.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" BtnStepDetail = '{0}',", objViewBtnOptStepsEN.BtnStepDetail); //BtnStepDetail
 }
 else
 {
 sbSQL.Append(" BtnStepDetail = null,"); //BtnStepDetail
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
 /// <param name = "objViewBtnOptStepsEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsViewBtnOptStepsEN objViewBtnOptStepsEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objViewBtnOptStepsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewBtnOptStepsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ViewBtnOptSteps Set ");
 
 if (objViewBtnOptStepsEN.IsUpdated(conViewBtnOptSteps.ViewId))
 {
 if (objViewBtnOptStepsEN.ViewId  ==  "")
 {
 objViewBtnOptStepsEN.ViewId = null;
 }
 if (objViewBtnOptStepsEN.ViewId !=  null)
 {
 objViewBtnOptStepsEN.ViewId = objViewBtnOptStepsEN.ViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewId = '{0}',", objViewBtnOptStepsEN.ViewId); //界面Id
 }
 else
 {
 sbSQL.Append(" ViewId = null,"); //界面Id
 }
 }
 
 if (objViewBtnOptStepsEN.IsUpdated(conViewBtnOptSteps.BtnName))
 {
 if (objViewBtnOptStepsEN.BtnName !=  null)
 {
 objViewBtnOptStepsEN.BtnName = objViewBtnOptStepsEN.BtnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" BtnName = '{0}',", objViewBtnOptStepsEN.BtnName); //BtnName
 }
 else
 {
 sbSQL.Append(" BtnName = null,"); //BtnName
 }
 }
 
 if (objViewBtnOptStepsEN.IsUpdated(conViewBtnOptSteps.BtnOptFunction))
 {
 if (objViewBtnOptStepsEN.BtnOptFunction !=  null)
 {
 objViewBtnOptStepsEN.BtnOptFunction = objViewBtnOptStepsEN.BtnOptFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" BtnOptFunction = '{0}',", objViewBtnOptStepsEN.BtnOptFunction); //BtnOptFunction
 }
 else
 {
 sbSQL.Append(" BtnOptFunction = null,"); //BtnOptFunction
 }
 }
 
 if (objViewBtnOptStepsEN.IsUpdated(conViewBtnOptSteps.BtnStepDetail))
 {
 if (objViewBtnOptStepsEN.BtnStepDetail !=  null)
 {
 objViewBtnOptStepsEN.BtnStepDetail = objViewBtnOptStepsEN.BtnStepDetail.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" BtnStepDetail = '{0}',", objViewBtnOptStepsEN.BtnStepDetail); //BtnStepDetail
 }
 else
 {
 sbSQL.Append(" BtnStepDetail = null,"); //BtnStepDetail
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
 /// <param name = "objViewBtnOptStepsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsViewBtnOptStepsEN objViewBtnOptStepsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objViewBtnOptStepsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewBtnOptStepsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ViewBtnOptSteps Set ");
 
 if (objViewBtnOptStepsEN.IsUpdated(conViewBtnOptSteps.ViewId))
 {
 if (objViewBtnOptStepsEN.ViewId  ==  "")
 {
 objViewBtnOptStepsEN.ViewId = null;
 }
 if (objViewBtnOptStepsEN.ViewId !=  null)
 {
 objViewBtnOptStepsEN.ViewId = objViewBtnOptStepsEN.ViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objViewBtnOptStepsEN.ViewId, conViewBtnOptSteps.ViewId); //界面Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewBtnOptSteps.ViewId); //界面Id
 }
 }
 
 if (objViewBtnOptStepsEN.IsUpdated(conViewBtnOptSteps.BtnName))
 {
 if (objViewBtnOptStepsEN.BtnName !=  null)
 {
 objViewBtnOptStepsEN.BtnName = objViewBtnOptStepsEN.BtnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objViewBtnOptStepsEN.BtnName, conViewBtnOptSteps.BtnName); //BtnName
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewBtnOptSteps.BtnName); //BtnName
 }
 }
 
 if (objViewBtnOptStepsEN.IsUpdated(conViewBtnOptSteps.BtnOptFunction))
 {
 if (objViewBtnOptStepsEN.BtnOptFunction !=  null)
 {
 objViewBtnOptStepsEN.BtnOptFunction = objViewBtnOptStepsEN.BtnOptFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objViewBtnOptStepsEN.BtnOptFunction, conViewBtnOptSteps.BtnOptFunction); //BtnOptFunction
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewBtnOptSteps.BtnOptFunction); //BtnOptFunction
 }
 }
 
 if (objViewBtnOptStepsEN.IsUpdated(conViewBtnOptSteps.BtnStepDetail))
 {
 if (objViewBtnOptStepsEN.BtnStepDetail !=  null)
 {
 objViewBtnOptStepsEN.BtnStepDetail = objViewBtnOptStepsEN.BtnStepDetail.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objViewBtnOptStepsEN.BtnStepDetail, conViewBtnOptSteps.BtnStepDetail); //BtnStepDetail
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewBtnOptSteps.BtnStepDetail); //BtnStepDetail
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objViewBtnOptStepsEN.mId); 
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngmId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("ViewBtnOptSteps_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngmId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
//删除ViewBtnOptSteps本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ViewBtnOptSteps where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelViewBtnOptSteps(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
string strSQL;
string strKeyList;
if (lstKey.Count  == 0) return 0;
strKeyList = "";
for (int i = 0; i<lstKey.Count; i++)
{
if (i == 0) strKeyList = strKeyList + "" + lstKey[i].ToString() + "";
else strKeyList +=  "," + "" + lstKey[i].ToString() + "";
}
strSQL = "";
//删除ViewBtnOptSteps本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ViewBtnOptSteps where mId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngmId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
//删除ViewBtnOptSteps本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ViewBtnOptSteps where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelViewBtnOptSteps(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsViewBtnOptStepsDA: DelViewBtnOptSteps)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ViewBtnOptSteps where " + strCondition ;
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
public bool DelViewBtnOptStepsWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsViewBtnOptStepsDA: DelViewBtnOptStepsWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ViewBtnOptSteps where " + strCondition ;
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
 /// <param name = "objViewBtnOptStepsENS">源对象</param>
 /// <param name = "objViewBtnOptStepsENT">目标对象</param>
public void CopyTo(clsViewBtnOptStepsEN objViewBtnOptStepsENS, clsViewBtnOptStepsEN objViewBtnOptStepsENT)
{
objViewBtnOptStepsENT.mId = objViewBtnOptStepsENS.mId; //mId
objViewBtnOptStepsENT.ViewId = objViewBtnOptStepsENS.ViewId; //界面Id
objViewBtnOptStepsENT.BtnName = objViewBtnOptStepsENS.BtnName; //BtnName
objViewBtnOptStepsENT.BtnOptFunction = objViewBtnOptStepsENS.BtnOptFunction; //BtnOptFunction
objViewBtnOptStepsENT.BtnStepDetail = objViewBtnOptStepsENS.BtnStepDetail; //BtnStepDetail
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsViewBtnOptStepsEN objViewBtnOptStepsEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objViewBtnOptStepsEN.ViewId, conViewBtnOptSteps.ViewId);
clsCheckSql.CheckFieldNotNull(objViewBtnOptStepsEN.BtnName, conViewBtnOptSteps.BtnName);
clsCheckSql.CheckFieldNotNull(objViewBtnOptStepsEN.BtnOptFunction, conViewBtnOptSteps.BtnOptFunction);
//检查字段长度
clsCheckSql.CheckFieldLen(objViewBtnOptStepsEN.ViewId, 8, conViewBtnOptSteps.ViewId);
clsCheckSql.CheckFieldLen(objViewBtnOptStepsEN.BtnName, 30, conViewBtnOptSteps.BtnName);
clsCheckSql.CheckFieldLen(objViewBtnOptStepsEN.BtnOptFunction, 50, conViewBtnOptSteps.BtnOptFunction);
clsCheckSql.CheckFieldLen(objViewBtnOptStepsEN.BtnStepDetail, 1000, conViewBtnOptSteps.BtnStepDetail);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objViewBtnOptStepsEN.ViewId, 8, conViewBtnOptSteps.ViewId);
 objViewBtnOptStepsEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsViewBtnOptStepsEN objViewBtnOptStepsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objViewBtnOptStepsEN.ViewId, 8, conViewBtnOptSteps.ViewId);
clsCheckSql.CheckFieldLen(objViewBtnOptStepsEN.BtnName, 30, conViewBtnOptSteps.BtnName);
clsCheckSql.CheckFieldLen(objViewBtnOptStepsEN.BtnOptFunction, 50, conViewBtnOptSteps.BtnOptFunction);
clsCheckSql.CheckFieldLen(objViewBtnOptStepsEN.BtnStepDetail, 1000, conViewBtnOptSteps.BtnStepDetail);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objViewBtnOptStepsEN.ViewId, 8, conViewBtnOptSteps.ViewId);
 objViewBtnOptStepsEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsViewBtnOptStepsEN objViewBtnOptStepsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objViewBtnOptStepsEN.ViewId, 8, conViewBtnOptSteps.ViewId);
clsCheckSql.CheckFieldLen(objViewBtnOptStepsEN.BtnName, 30, conViewBtnOptSteps.BtnName);
clsCheckSql.CheckFieldLen(objViewBtnOptStepsEN.BtnOptFunction, 50, conViewBtnOptSteps.BtnOptFunction);
clsCheckSql.CheckFieldLen(objViewBtnOptStepsEN.BtnStepDetail, 1000, conViewBtnOptSteps.BtnStepDetail);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objViewBtnOptStepsEN.ViewId, conViewBtnOptSteps.ViewId);
clsCheckSql.CheckSqlInjection4Field(objViewBtnOptStepsEN.BtnName, conViewBtnOptSteps.BtnName);
clsCheckSql.CheckSqlInjection4Field(objViewBtnOptStepsEN.BtnOptFunction, conViewBtnOptSteps.BtnOptFunction);
clsCheckSql.CheckSqlInjection4Field(objViewBtnOptStepsEN.BtnStepDetail, conViewBtnOptSteps.BtnStepDetail);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objViewBtnOptStepsEN.ViewId, 8, conViewBtnOptSteps.ViewId);
 objViewBtnOptStepsEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--ViewBtnOptSteps(界面按钮操作步骤),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objViewBtnOptStepsEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStrViewId_BtnName(clsViewBtnOptStepsEN objViewBtnOptStepsEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ViewId = '{0}'", objViewBtnOptStepsEN.ViewId);
 sbCondition.AppendFormat(" and BtnName = '{0}'", objViewBtnOptStepsEN.BtnName);
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
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
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
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
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
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsViewBtnOptStepsEN._CurrTabName);
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
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsViewBtnOptStepsEN._CurrTabName, strCondition);
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
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
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
 objSQL = clsViewBtnOptStepsDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}