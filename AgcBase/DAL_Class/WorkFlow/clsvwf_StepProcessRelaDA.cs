
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvwf_StepProcessRelaDA
 表名:vwf_StepProcessRela(00050494)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:18:31
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:工作流管理(WorkFlow)
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
 /// v工作流步骤过程关系(vwf_StepProcessRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class clsvwf_StepProcessRelaDA : clsCommBase4DA
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
 return clsvwf_StepProcessRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvwf_StepProcessRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvwf_StepProcessRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvwf_StepProcessRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvwf_StepProcessRelaEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsvwf_StepProcessRelaDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_StepProcessRelaDA.GetSpecSQLObj();
 strSQL = "Select * from vwf_StepProcessRela where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "vwf_StepProcessRela");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsvwf_StepProcessRelaDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_StepProcessRelaDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("vwf_StepProcessRela_SelectByCond",values, "vwf_StepProcessRela");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsvwf_StepProcessRelaDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_StepProcessRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vwf_StepProcessRela where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "vwf_StepProcessRela");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvwf_StepProcessRelaDA: Getvwf_StepProcessRelaByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvwf_StepProcessRelaDA: Getvwf_StepProcessRelaByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvwf_StepProcessRelaDA: Getvwf_StepProcessRelaByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsvwf_StepProcessRelaDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_StepProcessRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vwf_StepProcessRela a where {0} And a.WorkFlowStepProcessRelaId not in (Select Top {2} WorkFlowStepProcessRelaId From vwf_StepProcessRela Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vwf_StepProcessRela");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvwf_StepProcessRelaDA: Getvwf_StepProcessRelaByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvwf_StepProcessRelaDA: Getvwf_StepProcessRelaByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvwf_StepProcessRelaDA: Getvwf_StepProcessRelaByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsvwf_StepProcessRelaDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_StepProcessRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vwf_StepProcessRela a where {0} And a.WorkFlowStepProcessRelaId not in (Select Top {2} WorkFlowStepProcessRelaId From vwf_StepProcessRela Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vwf_StepProcessRela");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvwf_StepProcessRelaDA: Getvwf_StepProcessRelaByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvwf_StepProcessRelaDA: Getvwf_StepProcessRelaByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvwf_StepProcessRelaDA: Getvwf_StepProcessRelaByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsvwf_StepProcessRelaDA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsvwf_StepProcessRelaDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_StepProcessRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vwf_StepProcessRela a where {0} And a.WorkFlowStepProcessRelaId not in (Select Top {2} WorkFlowStepProcessRelaId From vwf_StepProcessRela Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vwf_StepProcessRela");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvwf_StepProcessRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_StepProcessRelaDA.GetSpecSQLObj();
strSQL = "Select * from vwf_StepProcessRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vwf_StepProcessRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvwf_StepProcessRelaDA: GetDataTable_vwf_StepProcessRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_StepProcessRelaDA.GetSpecSQLObj();
strSQL = "Select * from vwf_StepProcessRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvwf_StepProcessRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_StepProcessRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvwf_StepProcessRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_StepProcessRelaDA.GetSpecSQLObj();
strSQL = "Select * from vwf_StepProcessRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvwf_StepProcessRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_StepProcessRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsvwf_StepProcessRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_StepProcessRelaDA.GetSpecSQLObj();
strSQL = "Select * from vwf_StepProcessRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsvwf_StepProcessRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_StepProcessRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvwf_StepProcessRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_StepProcessRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vwf_StepProcessRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vwf_StepProcessRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvwf_StepProcessRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_StepProcessRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vwf_StepProcessRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsvwf_StepProcessRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_StepProcessRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vwf_StepProcessRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvwf_StepProcessRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_StepProcessRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vwf_StepProcessRela.* from vwf_StepProcessRela Left Join {1} on {2} where {3} and vwf_StepProcessRela.WorkFlowStepProcessRelaId not in (Select top {5} vwf_StepProcessRela.WorkFlowStepProcessRelaId from vwf_StepProcessRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vwf_StepProcessRela where {1} and WorkFlowStepProcessRelaId not in (Select top {2} WorkFlowStepProcessRelaId from vwf_StepProcessRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vwf_StepProcessRela where {1} and WorkFlowStepProcessRelaId not in (Select top {3} WorkFlowStepProcessRelaId from vwf_StepProcessRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvwf_StepProcessRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_StepProcessRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vwf_StepProcessRela.* from vwf_StepProcessRela Left Join {1} on {2} where {3} and vwf_StepProcessRela.WorkFlowStepProcessRelaId not in (Select top {5} vwf_StepProcessRela.WorkFlowStepProcessRelaId from vwf_StepProcessRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vwf_StepProcessRela where {1} and WorkFlowStepProcessRelaId not in (Select top {2} WorkFlowStepProcessRelaId from vwf_StepProcessRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vwf_StepProcessRela where {1} and WorkFlowStepProcessRelaId not in (Select top {3} WorkFlowStepProcessRelaId from vwf_StepProcessRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsvwf_StepProcessRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_StepProcessRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vwf_StepProcessRela.* from vwf_StepProcessRela Left Join {1} on {2} where {3} and vwf_StepProcessRela.WorkFlowStepProcessRelaId not in (Select top {5} vwf_StepProcessRela.WorkFlowStepProcessRelaId from vwf_StepProcessRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vwf_StepProcessRela where {1} and WorkFlowStepProcessRelaId not in (Select top {2} WorkFlowStepProcessRelaId from vwf_StepProcessRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vwf_StepProcessRela where {1} and WorkFlowStepProcessRelaId not in (Select top {3} WorkFlowStepProcessRelaId from vwf_StepProcessRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvwf_StepProcessRelaDA: Getvwf_StepProcessRelaByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvwf_StepProcessRelaDA: Getvwf_StepProcessRelaByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvwf_StepProcessRelaDA: Getvwf_StepProcessRelaByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsvwf_StepProcessRelaDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_StepProcessRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from vwf_StepProcessRela a where {0} And a.WorkFlowStepProcessRelaId not in (Select Top {2} WorkFlowStepProcessRelaId From vwf_StepProcessRela Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from vwf_StepProcessRela a where {0} And a.WorkFlowStepProcessRelaId not in (Select Top {2} WorkFlowStepProcessRelaId From vwf_StepProcessRela Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvwf_StepProcessRelaDA: Getvwf_StepProcessRelaByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvwf_StepProcessRelaDA: Getvwf_StepProcessRelaByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvwf_StepProcessRelaDA: Getvwf_StepProcessRelaByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsvwf_StepProcessRelaDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_StepProcessRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from vwf_StepProcessRela a where {0} And a.WorkFlowStepProcessRelaId not in (Select Top {2} WorkFlowStepProcessRelaId From vwf_StepProcessRela Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from vwf_StepProcessRela a where {0} And a.WorkFlowStepProcessRelaId not in (Select Top {2} WorkFlowStepProcessRelaId From vwf_StepProcessRela Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvwf_StepProcessRelaDA: Getvwf_StepProcessRelaByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvwf_StepProcessRelaDA: Getvwf_StepProcessRelaByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvwf_StepProcessRelaDA: Getvwf_StepProcessRelaByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsvwf_StepProcessRelaDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_StepProcessRelaDA.GetSpecSQLObj();
strSQL = "Select * from vwf_StepProcessRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsvwf_StepProcessRelaDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_StepProcessRelaDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vwf_StepProcessRela_SelectByCond",values);
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
public List<clsvwf_StepProcessRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvwf_StepProcessRelaDA:GetObjLst)", objException.Message));
}
List<clsvwf_StepProcessRelaEN> arrObjLst = new List<clsvwf_StepProcessRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_StepProcessRelaDA.GetSpecSQLObj();
strSQL = "Select * from vwf_StepProcessRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN = new clsvwf_StepProcessRelaEN();
try
{
objvwf_StepProcessRelaEN.WorkFlowStepProcessRelaId = TransNullToInt(objRow[convwf_StepProcessRela.WorkFlowStepProcessRelaId].ToString().Trim()); //工作流与过程关系Id
objvwf_StepProcessRelaEN.WorkFlowId = objRow[convwf_StepProcessRela.WorkFlowId].ToString().Trim(); //工作流Id
objvwf_StepProcessRelaEN.WorkFlowName = objRow[convwf_StepProcessRela.WorkFlowName].ToString().Trim(); //工作流名称
objvwf_StepProcessRelaEN.WorkFlowNameSim = objRow[convwf_StepProcessRela.WorkFlowNameSim] == DBNull.Value ? null : objRow[convwf_StepProcessRela.WorkFlowNameSim].ToString().Trim(); //工作流简称
objvwf_StepProcessRelaEN.PrjId = objRow[convwf_StepProcessRela.PrjId] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PrjId].ToString().Trim(); //工程ID
objvwf_StepProcessRelaEN.PrjName = objRow[convwf_StepProcessRela.PrjName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PrjName].ToString().Trim(); //工程名称
objvwf_StepProcessRelaEN.ProcessId = objRow[convwf_StepProcessRela.ProcessId].ToString().Trim(); //过程ID
objvwf_StepProcessRelaEN.ProcessName = objRow[convwf_StepProcessRela.ProcessName].ToString().Trim(); //过程名称
objvwf_StepProcessRelaEN.EndPoint = objRow[convwf_StepProcessRela.EndPoint].ToString().Trim(); //终点
objvwf_StepProcessRelaEN.StartPoint = objRow[convwf_StepProcessRela.StartPoint].ToString().Trim(); //起点
objvwf_StepProcessRelaEN.StartPointName = objRow[convwf_StepProcessRela.StartPointName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.StartPointName].ToString().Trim(); //起点名
objvwf_StepProcessRelaEN.EndPointName = objRow[convwf_StepProcessRela.EndPointName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.EndPointName].ToString().Trim(); //终点名
objvwf_StepProcessRelaEN.OrderNum = objRow[convwf_StepProcessRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convwf_StepProcessRela.OrderNum].ToString().Trim()); //序号
objvwf_StepProcessRelaEN.RoleId = objRow[convwf_StepProcessRela.RoleId].ToString().Trim(); //角色ID
objvwf_StepProcessRelaEN.PageName = objRow[convwf_StepProcessRela.PageName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PageName].ToString().Trim(); //页面名称
objvwf_StepProcessRelaEN.DepartmentId = objRow[convwf_StepProcessRela.DepartmentId] == DBNull.Value ? null : objRow[convwf_StepProcessRela.DepartmentId].ToString().Trim(); //部门ID
objvwf_StepProcessRelaEN.UpdDate = objRow[convwf_StepProcessRela.UpdDate] == DBNull.Value ? null : objRow[convwf_StepProcessRela.UpdDate].ToString().Trim(); //修改日期
objvwf_StepProcessRelaEN.UpdUser = objRow[convwf_StepProcessRela.UpdUser] == DBNull.Value ? null : objRow[convwf_StepProcessRela.UpdUser].ToString().Trim(); //修改者
objvwf_StepProcessRelaEN.Memo = objRow[convwf_StepProcessRela.Memo] == DBNull.Value ? null : objRow[convwf_StepProcessRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvwf_StepProcessRelaDA: GetObjLst)", objException.Message));
}
objvwf_StepProcessRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvwf_StepProcessRelaEN);
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
public List<clsvwf_StepProcessRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvwf_StepProcessRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsvwf_StepProcessRelaEN> arrObjLst = new List<clsvwf_StepProcessRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_StepProcessRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN = new clsvwf_StepProcessRelaEN();
try
{
objvwf_StepProcessRelaEN.WorkFlowStepProcessRelaId = TransNullToInt(objRow[convwf_StepProcessRela.WorkFlowStepProcessRelaId].ToString().Trim()); //工作流与过程关系Id
objvwf_StepProcessRelaEN.WorkFlowId = objRow[convwf_StepProcessRela.WorkFlowId].ToString().Trim(); //工作流Id
objvwf_StepProcessRelaEN.WorkFlowName = objRow[convwf_StepProcessRela.WorkFlowName].ToString().Trim(); //工作流名称
objvwf_StepProcessRelaEN.WorkFlowNameSim = objRow[convwf_StepProcessRela.WorkFlowNameSim] == DBNull.Value ? null : objRow[convwf_StepProcessRela.WorkFlowNameSim].ToString().Trim(); //工作流简称
objvwf_StepProcessRelaEN.PrjId = objRow[convwf_StepProcessRela.PrjId] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PrjId].ToString().Trim(); //工程ID
objvwf_StepProcessRelaEN.PrjName = objRow[convwf_StepProcessRela.PrjName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PrjName].ToString().Trim(); //工程名称
objvwf_StepProcessRelaEN.ProcessId = objRow[convwf_StepProcessRela.ProcessId].ToString().Trim(); //过程ID
objvwf_StepProcessRelaEN.ProcessName = objRow[convwf_StepProcessRela.ProcessName].ToString().Trim(); //过程名称
objvwf_StepProcessRelaEN.EndPoint = objRow[convwf_StepProcessRela.EndPoint].ToString().Trim(); //终点
objvwf_StepProcessRelaEN.StartPoint = objRow[convwf_StepProcessRela.StartPoint].ToString().Trim(); //起点
objvwf_StepProcessRelaEN.StartPointName = objRow[convwf_StepProcessRela.StartPointName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.StartPointName].ToString().Trim(); //起点名
objvwf_StepProcessRelaEN.EndPointName = objRow[convwf_StepProcessRela.EndPointName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.EndPointName].ToString().Trim(); //终点名
objvwf_StepProcessRelaEN.OrderNum = objRow[convwf_StepProcessRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convwf_StepProcessRela.OrderNum].ToString().Trim()); //序号
objvwf_StepProcessRelaEN.RoleId = objRow[convwf_StepProcessRela.RoleId].ToString().Trim(); //角色ID
objvwf_StepProcessRelaEN.PageName = objRow[convwf_StepProcessRela.PageName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PageName].ToString().Trim(); //页面名称
objvwf_StepProcessRelaEN.DepartmentId = objRow[convwf_StepProcessRela.DepartmentId] == DBNull.Value ? null : objRow[convwf_StepProcessRela.DepartmentId].ToString().Trim(); //部门ID
objvwf_StepProcessRelaEN.UpdDate = objRow[convwf_StepProcessRela.UpdDate] == DBNull.Value ? null : objRow[convwf_StepProcessRela.UpdDate].ToString().Trim(); //修改日期
objvwf_StepProcessRelaEN.UpdUser = objRow[convwf_StepProcessRela.UpdUser] == DBNull.Value ? null : objRow[convwf_StepProcessRela.UpdUser].ToString().Trim(); //修改者
objvwf_StepProcessRelaEN.Memo = objRow[convwf_StepProcessRela.Memo] == DBNull.Value ? null : objRow[convwf_StepProcessRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvwf_StepProcessRelaDA: GetObjLst)", objException.Message));
}
objvwf_StepProcessRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvwf_StepProcessRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsvwf_StepProcessRelaEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsvwf_StepProcessRelaDA:GetObjLstBySP)", objException.Message));
}
List<clsvwf_StepProcessRelaEN> arrObjLst = new List<clsvwf_StepProcessRelaEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_StepProcessRelaDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vwf_StepProcessRela_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN = new clsvwf_StepProcessRelaEN();
try
{
objvwf_StepProcessRelaEN.WorkFlowStepProcessRelaId = TransNullToInt(objRow[convwf_StepProcessRela.WorkFlowStepProcessRelaId].ToString().Trim()); //工作流与过程关系Id
objvwf_StepProcessRelaEN.WorkFlowId = objRow[convwf_StepProcessRela.WorkFlowId].ToString().Trim(); //工作流Id
objvwf_StepProcessRelaEN.WorkFlowName = objRow[convwf_StepProcessRela.WorkFlowName].ToString().Trim(); //工作流名称
objvwf_StepProcessRelaEN.WorkFlowNameSim = objRow[convwf_StepProcessRela.WorkFlowNameSim] == DBNull.Value ? null : objRow[convwf_StepProcessRela.WorkFlowNameSim].ToString().Trim(); //工作流简称
objvwf_StepProcessRelaEN.PrjId = objRow[convwf_StepProcessRela.PrjId] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PrjId].ToString().Trim(); //工程ID
objvwf_StepProcessRelaEN.PrjName = objRow[convwf_StepProcessRela.PrjName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PrjName].ToString().Trim(); //工程名称
objvwf_StepProcessRelaEN.ProcessId = objRow[convwf_StepProcessRela.ProcessId].ToString().Trim(); //过程ID
objvwf_StepProcessRelaEN.ProcessName = objRow[convwf_StepProcessRela.ProcessName].ToString().Trim(); //过程名称
objvwf_StepProcessRelaEN.EndPoint = objRow[convwf_StepProcessRela.EndPoint].ToString().Trim(); //终点
objvwf_StepProcessRelaEN.StartPoint = objRow[convwf_StepProcessRela.StartPoint].ToString().Trim(); //起点
objvwf_StepProcessRelaEN.StartPointName = objRow[convwf_StepProcessRela.StartPointName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.StartPointName].ToString().Trim(); //起点名
objvwf_StepProcessRelaEN.EndPointName = objRow[convwf_StepProcessRela.EndPointName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.EndPointName].ToString().Trim(); //终点名
objvwf_StepProcessRelaEN.OrderNum = objRow[convwf_StepProcessRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convwf_StepProcessRela.OrderNum].ToString().Trim()); //序号
objvwf_StepProcessRelaEN.RoleId = objRow[convwf_StepProcessRela.RoleId].ToString().Trim(); //角色ID
objvwf_StepProcessRelaEN.PageName = objRow[convwf_StepProcessRela.PageName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PageName].ToString().Trim(); //页面名称
objvwf_StepProcessRelaEN.DepartmentId = objRow[convwf_StepProcessRela.DepartmentId] == DBNull.Value ? null : objRow[convwf_StepProcessRela.DepartmentId].ToString().Trim(); //部门ID
objvwf_StepProcessRelaEN.UpdDate = objRow[convwf_StepProcessRela.UpdDate] == DBNull.Value ? null : objRow[convwf_StepProcessRela.UpdDate].ToString().Trim(); //修改日期
objvwf_StepProcessRelaEN.UpdUser = objRow[convwf_StepProcessRela.UpdUser] == DBNull.Value ? null : objRow[convwf_StepProcessRela.UpdUser].ToString().Trim(); //修改者
objvwf_StepProcessRelaEN.Memo = objRow[convwf_StepProcessRela.Memo] == DBNull.Value ? null : objRow[convwf_StepProcessRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsvwf_StepProcessRelaDA: GetObjLstBySP)", objException.Message));
}
objvwf_StepProcessRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvwf_StepProcessRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvwf_StepProcessRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvwf_StepProcessRela(ref clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_StepProcessRelaDA.GetSpecSQLObj();
strSQL = "Select * from vwf_StepProcessRela where WorkFlowStepProcessRelaId = " + ""+ objvwf_StepProcessRelaEN.WorkFlowStepProcessRelaId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvwf_StepProcessRelaEN.WorkFlowStepProcessRelaId = TransNullToInt(objDT.Rows[0][convwf_StepProcessRela.WorkFlowStepProcessRelaId].ToString().Trim()); //工作流与过程关系Id(字段类型:bigint,字段长度:8,是否可空:False)
 objvwf_StepProcessRelaEN.WorkFlowId = objDT.Rows[0][convwf_StepProcessRela.WorkFlowId].ToString().Trim(); //工作流Id(字段类型:char,字段长度:4,是否可空:False)
 objvwf_StepProcessRelaEN.WorkFlowName = objDT.Rows[0][convwf_StepProcessRela.WorkFlowName].ToString().Trim(); //工作流名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvwf_StepProcessRelaEN.WorkFlowNameSim = objDT.Rows[0][convwf_StepProcessRela.WorkFlowNameSim].ToString().Trim(); //工作流简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvwf_StepProcessRelaEN.PrjId = objDT.Rows[0][convwf_StepProcessRela.PrjId].ToString().Trim(); //工程ID(字段类型:char,字段长度:4,是否可空:False)
 objvwf_StepProcessRelaEN.PrjName = objDT.Rows[0][convwf_StepProcessRela.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvwf_StepProcessRelaEN.ProcessId = objDT.Rows[0][convwf_StepProcessRela.ProcessId].ToString().Trim(); //过程ID(字段类型:char,字段长度:8,是否可空:False)
 objvwf_StepProcessRelaEN.ProcessName = objDT.Rows[0][convwf_StepProcessRela.ProcessName].ToString().Trim(); //过程名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvwf_StepProcessRelaEN.EndPoint = objDT.Rows[0][convwf_StepProcessRela.EndPoint].ToString().Trim(); //终点(字段类型:char,字段长度:8,是否可空:False)
 objvwf_StepProcessRelaEN.StartPoint = objDT.Rows[0][convwf_StepProcessRela.StartPoint].ToString().Trim(); //起点(字段类型:char,字段长度:8,是否可空:False)
 objvwf_StepProcessRelaEN.StartPointName = objDT.Rows[0][convwf_StepProcessRela.StartPointName].ToString().Trim(); //起点名(字段类型:varchar,字段长度:100,是否可空:True)
 objvwf_StepProcessRelaEN.EndPointName = objDT.Rows[0][convwf_StepProcessRela.EndPointName].ToString().Trim(); //终点名(字段类型:varchar,字段长度:100,是否可空:True)
 objvwf_StepProcessRelaEN.OrderNum = TransNullToInt(objDT.Rows[0][convwf_StepProcessRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvwf_StepProcessRelaEN.RoleId = objDT.Rows[0][convwf_StepProcessRela.RoleId].ToString().Trim(); //角色ID(字段类型:char,字段长度:8,是否可空:True)
 objvwf_StepProcessRelaEN.PageName = objDT.Rows[0][convwf_StepProcessRela.PageName].ToString().Trim(); //页面名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvwf_StepProcessRelaEN.DepartmentId = objDT.Rows[0][convwf_StepProcessRela.DepartmentId].ToString().Trim(); //部门ID(字段类型:varchar,字段长度:6,是否可空:True)
 objvwf_StepProcessRelaEN.UpdDate = objDT.Rows[0][convwf_StepProcessRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvwf_StepProcessRelaEN.UpdUser = objDT.Rows[0][convwf_StepProcessRela.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvwf_StepProcessRelaEN.Memo = objDT.Rows[0][convwf_StepProcessRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvwf_StepProcessRelaDA: Getvwf_StepProcessRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngWorkFlowStepProcessRelaId">表关键字</param>
 /// <returns>表对象</returns>
public clsvwf_StepProcessRelaEN GetObjByWorkFlowStepProcessRelaId(long lngWorkFlowStepProcessRelaId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_StepProcessRelaDA.GetSpecSQLObj();
strSQL = "Select * from vwf_StepProcessRela where WorkFlowStepProcessRelaId = " + ""+ lngWorkFlowStepProcessRelaId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN = new clsvwf_StepProcessRelaEN();
try
{
 objvwf_StepProcessRelaEN.WorkFlowStepProcessRelaId = Int32.Parse(objRow[convwf_StepProcessRela.WorkFlowStepProcessRelaId].ToString().Trim()); //工作流与过程关系Id(字段类型:bigint,字段长度:8,是否可空:False)
 objvwf_StepProcessRelaEN.WorkFlowId = objRow[convwf_StepProcessRela.WorkFlowId].ToString().Trim(); //工作流Id(字段类型:char,字段长度:4,是否可空:False)
 objvwf_StepProcessRelaEN.WorkFlowName = objRow[convwf_StepProcessRela.WorkFlowName].ToString().Trim(); //工作流名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvwf_StepProcessRelaEN.WorkFlowNameSim = objRow[convwf_StepProcessRela.WorkFlowNameSim] == DBNull.Value ? null : objRow[convwf_StepProcessRela.WorkFlowNameSim].ToString().Trim(); //工作流简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvwf_StepProcessRelaEN.PrjId = objRow[convwf_StepProcessRela.PrjId] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PrjId].ToString().Trim(); //工程ID(字段类型:char,字段长度:4,是否可空:False)
 objvwf_StepProcessRelaEN.PrjName = objRow[convwf_StepProcessRela.PrjName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvwf_StepProcessRelaEN.ProcessId = objRow[convwf_StepProcessRela.ProcessId].ToString().Trim(); //过程ID(字段类型:char,字段长度:8,是否可空:False)
 objvwf_StepProcessRelaEN.ProcessName = objRow[convwf_StepProcessRela.ProcessName].ToString().Trim(); //过程名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvwf_StepProcessRelaEN.EndPoint = objRow[convwf_StepProcessRela.EndPoint].ToString().Trim(); //终点(字段类型:char,字段长度:8,是否可空:False)
 objvwf_StepProcessRelaEN.StartPoint = objRow[convwf_StepProcessRela.StartPoint].ToString().Trim(); //起点(字段类型:char,字段长度:8,是否可空:False)
 objvwf_StepProcessRelaEN.StartPointName = objRow[convwf_StepProcessRela.StartPointName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.StartPointName].ToString().Trim(); //起点名(字段类型:varchar,字段长度:100,是否可空:True)
 objvwf_StepProcessRelaEN.EndPointName = objRow[convwf_StepProcessRela.EndPointName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.EndPointName].ToString().Trim(); //终点名(字段类型:varchar,字段长度:100,是否可空:True)
 objvwf_StepProcessRelaEN.OrderNum = objRow[convwf_StepProcessRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_StepProcessRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvwf_StepProcessRelaEN.RoleId = objRow[convwf_StepProcessRela.RoleId].ToString().Trim(); //角色ID(字段类型:char,字段长度:8,是否可空:True)
 objvwf_StepProcessRelaEN.PageName = objRow[convwf_StepProcessRela.PageName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PageName].ToString().Trim(); //页面名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvwf_StepProcessRelaEN.DepartmentId = objRow[convwf_StepProcessRela.DepartmentId] == DBNull.Value ? null : objRow[convwf_StepProcessRela.DepartmentId].ToString().Trim(); //部门ID(字段类型:varchar,字段长度:6,是否可空:True)
 objvwf_StepProcessRelaEN.UpdDate = objRow[convwf_StepProcessRela.UpdDate] == DBNull.Value ? null : objRow[convwf_StepProcessRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvwf_StepProcessRelaEN.UpdUser = objRow[convwf_StepProcessRela.UpdUser] == DBNull.Value ? null : objRow[convwf_StepProcessRela.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvwf_StepProcessRelaEN.Memo = objRow[convwf_StepProcessRela.Memo] == DBNull.Value ? null : objRow[convwf_StepProcessRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvwf_StepProcessRelaDA: GetObjByWorkFlowStepProcessRelaId)", objException.Message));
}
return objvwf_StepProcessRelaEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程vwf_StepProcessRela_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objvwf_StepProcessRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvwf_StepProcessRelaOneBySP(clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_StepProcessRelaDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objvwf_StepProcessRelaEN.WorkFlowStepProcessRelaId
};
 objDT = objSQL.ExecSpReturnDT("vwf_StepProcessRela_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objvwf_StepProcessRelaEN.WorkFlowStepProcessRelaId = TransNullToInt(objDT.Rows[0][convwf_StepProcessRela.WorkFlowStepProcessRelaId].ToString().Trim()); //工作流与过程关系Id(字段类型:bigint,字段长度:8,是否可空:False)
 objvwf_StepProcessRelaEN.WorkFlowId = objDT.Rows[0][convwf_StepProcessRela.WorkFlowId].ToString().Trim(); //工作流Id(字段类型:char,字段长度:4,是否可空:False)
 objvwf_StepProcessRelaEN.WorkFlowName = objDT.Rows[0][convwf_StepProcessRela.WorkFlowName].ToString().Trim(); //工作流名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvwf_StepProcessRelaEN.WorkFlowNameSim = objDT.Rows[0][convwf_StepProcessRela.WorkFlowNameSim].ToString().Trim(); //工作流简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvwf_StepProcessRelaEN.PrjId = objDT.Rows[0][convwf_StepProcessRela.PrjId].ToString().Trim(); //工程ID(字段类型:char,字段长度:4,是否可空:False)
 objvwf_StepProcessRelaEN.PrjName = objDT.Rows[0][convwf_StepProcessRela.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvwf_StepProcessRelaEN.ProcessId = objDT.Rows[0][convwf_StepProcessRela.ProcessId].ToString().Trim(); //过程ID(字段类型:char,字段长度:8,是否可空:False)
 objvwf_StepProcessRelaEN.ProcessName = objDT.Rows[0][convwf_StepProcessRela.ProcessName].ToString().Trim(); //过程名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvwf_StepProcessRelaEN.EndPoint = objDT.Rows[0][convwf_StepProcessRela.EndPoint].ToString().Trim(); //终点(字段类型:char,字段长度:8,是否可空:False)
 objvwf_StepProcessRelaEN.StartPoint = objDT.Rows[0][convwf_StepProcessRela.StartPoint].ToString().Trim(); //起点(字段类型:char,字段长度:8,是否可空:False)
 objvwf_StepProcessRelaEN.StartPointName = objDT.Rows[0][convwf_StepProcessRela.StartPointName].ToString().Trim(); //起点名(字段类型:varchar,字段长度:100,是否可空:True)
 objvwf_StepProcessRelaEN.EndPointName = objDT.Rows[0][convwf_StepProcessRela.EndPointName].ToString().Trim(); //终点名(字段类型:varchar,字段长度:100,是否可空:True)
 objvwf_StepProcessRelaEN.OrderNum = TransNullToInt(objDT.Rows[0][convwf_StepProcessRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvwf_StepProcessRelaEN.RoleId = objDT.Rows[0][convwf_StepProcessRela.RoleId].ToString().Trim(); //角色ID(字段类型:char,字段长度:8,是否可空:True)
 objvwf_StepProcessRelaEN.PageName = objDT.Rows[0][convwf_StepProcessRela.PageName].ToString().Trim(); //页面名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvwf_StepProcessRelaEN.DepartmentId = objDT.Rows[0][convwf_StepProcessRela.DepartmentId].ToString().Trim(); //部门ID(字段类型:varchar,字段长度:6,是否可空:True)
 objvwf_StepProcessRelaEN.UpdDate = objDT.Rows[0][convwf_StepProcessRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvwf_StepProcessRelaEN.UpdUser = objDT.Rows[0][convwf_StepProcessRela.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvwf_StepProcessRelaEN.Memo = objDT.Rows[0][convwf_StepProcessRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvwf_StepProcessRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvwf_StepProcessRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_StepProcessRelaDA.GetSpecSQLObj();
strSQL = "Select * from vwf_StepProcessRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN = new clsvwf_StepProcessRelaEN()
{
WorkFlowStepProcessRelaId = TransNullToInt(objRow[convwf_StepProcessRela.WorkFlowStepProcessRelaId].ToString().Trim()), //工作流与过程关系Id
WorkFlowId = objRow[convwf_StepProcessRela.WorkFlowId].ToString().Trim(), //工作流Id
WorkFlowName = objRow[convwf_StepProcessRela.WorkFlowName].ToString().Trim(), //工作流名称
WorkFlowNameSim = objRow[convwf_StepProcessRela.WorkFlowNameSim] == DBNull.Value ? null : objRow[convwf_StepProcessRela.WorkFlowNameSim].ToString().Trim(), //工作流简称
PrjId = objRow[convwf_StepProcessRela.PrjId] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PrjId].ToString().Trim(), //工程ID
PrjName = objRow[convwf_StepProcessRela.PrjName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PrjName].ToString().Trim(), //工程名称
ProcessId = objRow[convwf_StepProcessRela.ProcessId].ToString().Trim(), //过程ID
ProcessName = objRow[convwf_StepProcessRela.ProcessName].ToString().Trim(), //过程名称
EndPoint = objRow[convwf_StepProcessRela.EndPoint].ToString().Trim(), //终点
StartPoint = objRow[convwf_StepProcessRela.StartPoint].ToString().Trim(), //起点
StartPointName = objRow[convwf_StepProcessRela.StartPointName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.StartPointName].ToString().Trim(), //起点名
EndPointName = objRow[convwf_StepProcessRela.EndPointName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.EndPointName].ToString().Trim(), //终点名
OrderNum = objRow[convwf_StepProcessRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convwf_StepProcessRela.OrderNum].ToString().Trim()), //序号
RoleId = objRow[convwf_StepProcessRela.RoleId].ToString().Trim(), //角色ID
PageName = objRow[convwf_StepProcessRela.PageName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PageName].ToString().Trim(), //页面名称
DepartmentId = objRow[convwf_StepProcessRela.DepartmentId] == DBNull.Value ? null : objRow[convwf_StepProcessRela.DepartmentId].ToString().Trim(), //部门ID
UpdDate = objRow[convwf_StepProcessRela.UpdDate] == DBNull.Value ? null : objRow[convwf_StepProcessRela.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convwf_StepProcessRela.UpdUser] == DBNull.Value ? null : objRow[convwf_StepProcessRela.UpdUser].ToString().Trim(), //修改者
Memo = objRow[convwf_StepProcessRela.Memo] == DBNull.Value ? null : objRow[convwf_StepProcessRela.Memo].ToString().Trim() //说明
};
objvwf_StepProcessRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvwf_StepProcessRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvwf_StepProcessRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvwf_StepProcessRelaEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsvwf_StepProcessRelaDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_StepProcessRelaDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vwf_StepProcessRela_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN = new clsvwf_StepProcessRelaEN()
{
WorkFlowStepProcessRelaId = TransNullToInt(objRow[convwf_StepProcessRela.WorkFlowStepProcessRelaId].ToString().Trim()), //工作流与过程关系Id
WorkFlowId = objRow[convwf_StepProcessRela.WorkFlowId].ToString().Trim(), //工作流Id
WorkFlowName = objRow[convwf_StepProcessRela.WorkFlowName].ToString().Trim(), //工作流名称
WorkFlowNameSim = objRow[convwf_StepProcessRela.WorkFlowNameSim] == DBNull.Value ? null : objRow[convwf_StepProcessRela.WorkFlowNameSim].ToString().Trim(), //工作流简称
PrjId = objRow[convwf_StepProcessRela.PrjId] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PrjId].ToString().Trim(), //工程ID
PrjName = objRow[convwf_StepProcessRela.PrjName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PrjName].ToString().Trim(), //工程名称
ProcessId = objRow[convwf_StepProcessRela.ProcessId].ToString().Trim(), //过程ID
ProcessName = objRow[convwf_StepProcessRela.ProcessName].ToString().Trim(), //过程名称
EndPoint = objRow[convwf_StepProcessRela.EndPoint].ToString().Trim(), //终点
StartPoint = objRow[convwf_StepProcessRela.StartPoint].ToString().Trim(), //起点
StartPointName = objRow[convwf_StepProcessRela.StartPointName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.StartPointName].ToString().Trim(), //起点名
EndPointName = objRow[convwf_StepProcessRela.EndPointName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.EndPointName].ToString().Trim(), //终点名
OrderNum = objRow[convwf_StepProcessRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convwf_StepProcessRela.OrderNum].ToString().Trim()), //序号
RoleId = objRow[convwf_StepProcessRela.RoleId].ToString().Trim(), //角色ID
PageName = objRow[convwf_StepProcessRela.PageName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PageName].ToString().Trim(), //页面名称
DepartmentId = objRow[convwf_StepProcessRela.DepartmentId] == DBNull.Value ? null : objRow[convwf_StepProcessRela.DepartmentId].ToString().Trim(), //部门ID
UpdDate = objRow[convwf_StepProcessRela.UpdDate] == DBNull.Value ? null : objRow[convwf_StepProcessRela.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convwf_StepProcessRela.UpdUser] == DBNull.Value ? null : objRow[convwf_StepProcessRela.UpdUser].ToString().Trim(), //修改者
Memo = objRow[convwf_StepProcessRela.Memo] == DBNull.Value ? null : objRow[convwf_StepProcessRela.Memo].ToString().Trim() //说明
};
objvwf_StepProcessRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvwf_StepProcessRelaEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvwf_StepProcessRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN = new clsvwf_StepProcessRelaEN();
try
{
objvwf_StepProcessRelaEN.WorkFlowStepProcessRelaId = TransNullToInt(objRow[convwf_StepProcessRela.WorkFlowStepProcessRelaId].ToString().Trim()); //工作流与过程关系Id
objvwf_StepProcessRelaEN.WorkFlowId = objRow[convwf_StepProcessRela.WorkFlowId].ToString().Trim(); //工作流Id
objvwf_StepProcessRelaEN.WorkFlowName = objRow[convwf_StepProcessRela.WorkFlowName].ToString().Trim(); //工作流名称
objvwf_StepProcessRelaEN.WorkFlowNameSim = objRow[convwf_StepProcessRela.WorkFlowNameSim] == DBNull.Value ? null : objRow[convwf_StepProcessRela.WorkFlowNameSim].ToString().Trim(); //工作流简称
objvwf_StepProcessRelaEN.PrjId = objRow[convwf_StepProcessRela.PrjId] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PrjId].ToString().Trim(); //工程ID
objvwf_StepProcessRelaEN.PrjName = objRow[convwf_StepProcessRela.PrjName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PrjName].ToString().Trim(); //工程名称
objvwf_StepProcessRelaEN.ProcessId = objRow[convwf_StepProcessRela.ProcessId].ToString().Trim(); //过程ID
objvwf_StepProcessRelaEN.ProcessName = objRow[convwf_StepProcessRela.ProcessName].ToString().Trim(); //过程名称
objvwf_StepProcessRelaEN.EndPoint = objRow[convwf_StepProcessRela.EndPoint].ToString().Trim(); //终点
objvwf_StepProcessRelaEN.StartPoint = objRow[convwf_StepProcessRela.StartPoint].ToString().Trim(); //起点
objvwf_StepProcessRelaEN.StartPointName = objRow[convwf_StepProcessRela.StartPointName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.StartPointName].ToString().Trim(); //起点名
objvwf_StepProcessRelaEN.EndPointName = objRow[convwf_StepProcessRela.EndPointName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.EndPointName].ToString().Trim(); //终点名
objvwf_StepProcessRelaEN.OrderNum = objRow[convwf_StepProcessRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convwf_StepProcessRela.OrderNum].ToString().Trim()); //序号
objvwf_StepProcessRelaEN.RoleId = objRow[convwf_StepProcessRela.RoleId].ToString().Trim(); //角色ID
objvwf_StepProcessRelaEN.PageName = objRow[convwf_StepProcessRela.PageName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PageName].ToString().Trim(); //页面名称
objvwf_StepProcessRelaEN.DepartmentId = objRow[convwf_StepProcessRela.DepartmentId] == DBNull.Value ? null : objRow[convwf_StepProcessRela.DepartmentId].ToString().Trim(); //部门ID
objvwf_StepProcessRelaEN.UpdDate = objRow[convwf_StepProcessRela.UpdDate] == DBNull.Value ? null : objRow[convwf_StepProcessRela.UpdDate].ToString().Trim(); //修改日期
objvwf_StepProcessRelaEN.UpdUser = objRow[convwf_StepProcessRela.UpdUser] == DBNull.Value ? null : objRow[convwf_StepProcessRela.UpdUser].ToString().Trim(); //修改者
objvwf_StepProcessRelaEN.Memo = objRow[convwf_StepProcessRela.Memo] == DBNull.Value ? null : objRow[convwf_StepProcessRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvwf_StepProcessRelaDA: GetObjByDataRowvwf_StepProcessRela)", objException.Message));
}
objvwf_StepProcessRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvwf_StepProcessRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvwf_StepProcessRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN = new clsvwf_StepProcessRelaEN();
try
{
objvwf_StepProcessRelaEN.WorkFlowStepProcessRelaId = TransNullToInt(objRow[convwf_StepProcessRela.WorkFlowStepProcessRelaId].ToString().Trim()); //工作流与过程关系Id
objvwf_StepProcessRelaEN.WorkFlowId = objRow[convwf_StepProcessRela.WorkFlowId].ToString().Trim(); //工作流Id
objvwf_StepProcessRelaEN.WorkFlowName = objRow[convwf_StepProcessRela.WorkFlowName].ToString().Trim(); //工作流名称
objvwf_StepProcessRelaEN.WorkFlowNameSim = objRow[convwf_StepProcessRela.WorkFlowNameSim] == DBNull.Value ? null : objRow[convwf_StepProcessRela.WorkFlowNameSim].ToString().Trim(); //工作流简称
objvwf_StepProcessRelaEN.PrjId = objRow[convwf_StepProcessRela.PrjId] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PrjId].ToString().Trim(); //工程ID
objvwf_StepProcessRelaEN.PrjName = objRow[convwf_StepProcessRela.PrjName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PrjName].ToString().Trim(); //工程名称
objvwf_StepProcessRelaEN.ProcessId = objRow[convwf_StepProcessRela.ProcessId].ToString().Trim(); //过程ID
objvwf_StepProcessRelaEN.ProcessName = objRow[convwf_StepProcessRela.ProcessName].ToString().Trim(); //过程名称
objvwf_StepProcessRelaEN.EndPoint = objRow[convwf_StepProcessRela.EndPoint].ToString().Trim(); //终点
objvwf_StepProcessRelaEN.StartPoint = objRow[convwf_StepProcessRela.StartPoint].ToString().Trim(); //起点
objvwf_StepProcessRelaEN.StartPointName = objRow[convwf_StepProcessRela.StartPointName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.StartPointName].ToString().Trim(); //起点名
objvwf_StepProcessRelaEN.EndPointName = objRow[convwf_StepProcessRela.EndPointName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.EndPointName].ToString().Trim(); //终点名
objvwf_StepProcessRelaEN.OrderNum = objRow[convwf_StepProcessRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convwf_StepProcessRela.OrderNum].ToString().Trim()); //序号
objvwf_StepProcessRelaEN.RoleId = objRow[convwf_StepProcessRela.RoleId].ToString().Trim(); //角色ID
objvwf_StepProcessRelaEN.PageName = objRow[convwf_StepProcessRela.PageName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PageName].ToString().Trim(); //页面名称
objvwf_StepProcessRelaEN.DepartmentId = objRow[convwf_StepProcessRela.DepartmentId] == DBNull.Value ? null : objRow[convwf_StepProcessRela.DepartmentId].ToString().Trim(); //部门ID
objvwf_StepProcessRelaEN.UpdDate = objRow[convwf_StepProcessRela.UpdDate] == DBNull.Value ? null : objRow[convwf_StepProcessRela.UpdDate].ToString().Trim(); //修改日期
objvwf_StepProcessRelaEN.UpdUser = objRow[convwf_StepProcessRela.UpdUser] == DBNull.Value ? null : objRow[convwf_StepProcessRela.UpdUser].ToString().Trim(); //修改者
objvwf_StepProcessRelaEN.Memo = objRow[convwf_StepProcessRela.Memo] == DBNull.Value ? null : objRow[convwf_StepProcessRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvwf_StepProcessRelaDA: GetObjByDataRow)", objException.Message));
}
objvwf_StepProcessRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvwf_StepProcessRelaEN;
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
objSQL = clsvwf_StepProcessRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvwf_StepProcessRelaEN._CurrTabName, convwf_StepProcessRela.WorkFlowStepProcessRelaId, 8, "");
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
objSQL = clsvwf_StepProcessRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvwf_StepProcessRelaEN._CurrTabName, convwf_StepProcessRela.WorkFlowStepProcessRelaId, 8, strPrefix);
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
 objSQL = clsvwf_StepProcessRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select WorkFlowStepProcessRelaId from vwf_StepProcessRela where " + strCondition;
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
 objSQL = clsvwf_StepProcessRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select WorkFlowStepProcessRelaId from vwf_StepProcessRela where " + strCondition;
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
 /// <param name = "lngWorkFlowStepProcessRelaId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngWorkFlowStepProcessRelaId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_StepProcessRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vwf_StepProcessRela", "WorkFlowStepProcessRelaId = " + ""+ lngWorkFlowStepProcessRelaId+""))
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
 /// <param name = "lngWorkFlowStepProcessRelaId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExistBySP(long lngWorkFlowStepProcessRelaId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_StepProcessRelaDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
lngWorkFlowStepProcessRelaId,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("vwf_StepProcessRela_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvwf_StepProcessRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_StepProcessRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vwf_StepProcessRela", strCondition))
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
objSQL = clsvwf_StepProcessRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vwf_StepProcessRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvwf_StepProcessRelaENS">源对象</param>
 /// <param name = "objvwf_StepProcessRelaENT">目标对象</param>
public void CopyTo(clsvwf_StepProcessRelaEN objvwf_StepProcessRelaENS, clsvwf_StepProcessRelaEN objvwf_StepProcessRelaENT)
{
objvwf_StepProcessRelaENT.WorkFlowStepProcessRelaId = objvwf_StepProcessRelaENS.WorkFlowStepProcessRelaId; //工作流与过程关系Id
objvwf_StepProcessRelaENT.WorkFlowId = objvwf_StepProcessRelaENS.WorkFlowId; //工作流Id
objvwf_StepProcessRelaENT.WorkFlowName = objvwf_StepProcessRelaENS.WorkFlowName; //工作流名称
objvwf_StepProcessRelaENT.WorkFlowNameSim = objvwf_StepProcessRelaENS.WorkFlowNameSim; //工作流简称
objvwf_StepProcessRelaENT.PrjId = objvwf_StepProcessRelaENS.PrjId; //工程ID
objvwf_StepProcessRelaENT.PrjName = objvwf_StepProcessRelaENS.PrjName; //工程名称
objvwf_StepProcessRelaENT.ProcessId = objvwf_StepProcessRelaENS.ProcessId; //过程ID
objvwf_StepProcessRelaENT.ProcessName = objvwf_StepProcessRelaENS.ProcessName; //过程名称
objvwf_StepProcessRelaENT.EndPoint = objvwf_StepProcessRelaENS.EndPoint; //终点
objvwf_StepProcessRelaENT.StartPoint = objvwf_StepProcessRelaENS.StartPoint; //起点
objvwf_StepProcessRelaENT.StartPointName = objvwf_StepProcessRelaENS.StartPointName; //起点名
objvwf_StepProcessRelaENT.EndPointName = objvwf_StepProcessRelaENS.EndPointName; //终点名
objvwf_StepProcessRelaENT.OrderNum = objvwf_StepProcessRelaENS.OrderNum; //序号
objvwf_StepProcessRelaENT.RoleId = objvwf_StepProcessRelaENS.RoleId; //角色ID
objvwf_StepProcessRelaENT.PageName = objvwf_StepProcessRelaENS.PageName; //页面名称
objvwf_StepProcessRelaENT.DepartmentId = objvwf_StepProcessRelaENS.DepartmentId; //部门ID
objvwf_StepProcessRelaENT.UpdDate = objvwf_StepProcessRelaENS.UpdDate; //修改日期
objvwf_StepProcessRelaENT.UpdUser = objvwf_StepProcessRelaENS.UpdUser; //修改者
objvwf_StepProcessRelaENT.Memo = objvwf_StepProcessRelaENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvwf_StepProcessRelaEN.WorkFlowId, 4, convwf_StepProcessRela.WorkFlowId);
clsCheckSql.CheckFieldLen(objvwf_StepProcessRelaEN.WorkFlowName, 50, convwf_StepProcessRela.WorkFlowName);
clsCheckSql.CheckFieldLen(objvwf_StepProcessRelaEN.WorkFlowNameSim, 30, convwf_StepProcessRela.WorkFlowNameSim);
clsCheckSql.CheckFieldLen(objvwf_StepProcessRelaEN.PrjId, 4, convwf_StepProcessRela.PrjId);
clsCheckSql.CheckFieldLen(objvwf_StepProcessRelaEN.PrjName, 30, convwf_StepProcessRela.PrjName);
clsCheckSql.CheckFieldLen(objvwf_StepProcessRelaEN.ProcessId, 8, convwf_StepProcessRela.ProcessId);
clsCheckSql.CheckFieldLen(objvwf_StepProcessRelaEN.ProcessName, 100, convwf_StepProcessRela.ProcessName);
clsCheckSql.CheckFieldLen(objvwf_StepProcessRelaEN.EndPoint, 8, convwf_StepProcessRela.EndPoint);
clsCheckSql.CheckFieldLen(objvwf_StepProcessRelaEN.StartPoint, 8, convwf_StepProcessRela.StartPoint);
clsCheckSql.CheckFieldLen(objvwf_StepProcessRelaEN.StartPointName, 100, convwf_StepProcessRela.StartPointName);
clsCheckSql.CheckFieldLen(objvwf_StepProcessRelaEN.EndPointName, 100, convwf_StepProcessRela.EndPointName);
clsCheckSql.CheckFieldLen(objvwf_StepProcessRelaEN.RoleId, 8, convwf_StepProcessRela.RoleId);
clsCheckSql.CheckFieldLen(objvwf_StepProcessRelaEN.PageName, 100, convwf_StepProcessRela.PageName);
clsCheckSql.CheckFieldLen(objvwf_StepProcessRelaEN.DepartmentId, 6, convwf_StepProcessRela.DepartmentId);
clsCheckSql.CheckFieldLen(objvwf_StepProcessRelaEN.UpdDate, 20, convwf_StepProcessRela.UpdDate);
clsCheckSql.CheckFieldLen(objvwf_StepProcessRelaEN.UpdUser, 20, convwf_StepProcessRela.UpdUser);
clsCheckSql.CheckFieldLen(objvwf_StepProcessRelaEN.Memo, 1000, convwf_StepProcessRela.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvwf_StepProcessRelaEN.WorkFlowId, convwf_StepProcessRela.WorkFlowId);
clsCheckSql.CheckSqlInjection4Field(objvwf_StepProcessRelaEN.WorkFlowName, convwf_StepProcessRela.WorkFlowName);
clsCheckSql.CheckSqlInjection4Field(objvwf_StepProcessRelaEN.WorkFlowNameSim, convwf_StepProcessRela.WorkFlowNameSim);
clsCheckSql.CheckSqlInjection4Field(objvwf_StepProcessRelaEN.PrjId, convwf_StepProcessRela.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvwf_StepProcessRelaEN.PrjName, convwf_StepProcessRela.PrjName);
clsCheckSql.CheckSqlInjection4Field(objvwf_StepProcessRelaEN.ProcessId, convwf_StepProcessRela.ProcessId);
clsCheckSql.CheckSqlInjection4Field(objvwf_StepProcessRelaEN.ProcessName, convwf_StepProcessRela.ProcessName);
clsCheckSql.CheckSqlInjection4Field(objvwf_StepProcessRelaEN.EndPoint, convwf_StepProcessRela.EndPoint);
clsCheckSql.CheckSqlInjection4Field(objvwf_StepProcessRelaEN.StartPoint, convwf_StepProcessRela.StartPoint);
clsCheckSql.CheckSqlInjection4Field(objvwf_StepProcessRelaEN.StartPointName, convwf_StepProcessRela.StartPointName);
clsCheckSql.CheckSqlInjection4Field(objvwf_StepProcessRelaEN.EndPointName, convwf_StepProcessRela.EndPointName);
clsCheckSql.CheckSqlInjection4Field(objvwf_StepProcessRelaEN.RoleId, convwf_StepProcessRela.RoleId);
clsCheckSql.CheckSqlInjection4Field(objvwf_StepProcessRelaEN.PageName, convwf_StepProcessRela.PageName);
clsCheckSql.CheckSqlInjection4Field(objvwf_StepProcessRelaEN.DepartmentId, convwf_StepProcessRela.DepartmentId);
clsCheckSql.CheckSqlInjection4Field(objvwf_StepProcessRelaEN.UpdDate, convwf_StepProcessRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvwf_StepProcessRelaEN.UpdUser, convwf_StepProcessRela.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvwf_StepProcessRelaEN.Memo, convwf_StepProcessRela.Memo);
//检查外键字段长度
 objvwf_StepProcessRelaEN._IsCheckProperty = true;
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
 objSQL = clsvwf_StepProcessRelaDA.GetSpecSQLObj();
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
 objSQL = clsvwf_StepProcessRelaDA.GetSpecSQLObj();
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
 objSQL = clsvwf_StepProcessRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvwf_StepProcessRelaEN._CurrTabName);
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
 objSQL = clsvwf_StepProcessRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvwf_StepProcessRelaEN._CurrTabName, strCondition);
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
 objSQL = clsvwf_StepProcessRelaDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}