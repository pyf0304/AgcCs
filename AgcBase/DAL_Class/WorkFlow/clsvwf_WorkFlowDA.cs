
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvwf_WorkFlowDA
 表名:vwf_WorkFlow(00050490)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:18:36
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
 /// v工作流(vwf_WorkFlow)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class clsvwf_WorkFlowDA : clsCommBase4DA
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
 return clsvwf_WorkFlowEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvwf_WorkFlowEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvwf_WorkFlowEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvwf_WorkFlowEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvwf_WorkFlowEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strWorkFlowId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strWorkFlowId)
{
strWorkFlowId = strWorkFlowId.Replace("'", "''");
if (strWorkFlowId.Length > 4)
{
throw new Exception("(errid:Data000001)在表:vwf_WorkFlow中,检查关键字,长度不正确!(clsvwf_WorkFlowDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strWorkFlowId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vwf_WorkFlow中,关键字不能为空 或 null!(clsvwf_WorkFlowDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strWorkFlowId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvwf_WorkFlowDA:CheckPrimaryKey)", objException.Message));
}
return true;
}

 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey_Sim)
 /// </summary>
 /// <param name = "strWorkFlowId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey_Sim(string strWorkFlowId)
{
strWorkFlowId = strWorkFlowId.Replace("'", "''");
if (strWorkFlowId.Length > 4 + 4)
{
throw new Exception("(errid:Data000004)在表:vwf_WorkFlow中,检查关键字,长度不正确!(简化版)(clsvwf_WorkFlowDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strWorkFlowId)  ==  true)
{
throw new Exception("(errid:Data000005)在表:vwf_WorkFlow中,关键字不能为空 或 null!(clsvwf_WorkFlowDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strWorkFlowId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000006)在关键字中含有{0},非法,请检查!(clsvwf_WorkFlowDA:CheckPrimaryKey)", objException.Message));
}
return true;
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsvwf_WorkFlowDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_WorkFlowDA.GetSpecSQLObj();
 strSQL = "Select * from vwf_WorkFlow where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "vwf_WorkFlow");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsvwf_WorkFlowDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_WorkFlowDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("vwf_WorkFlow_SelectByCond",values, "vwf_WorkFlow");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsvwf_WorkFlowDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_WorkFlowDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vwf_WorkFlow where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "vwf_WorkFlow");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvwf_WorkFlowDA: Getvwf_WorkFlowByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvwf_WorkFlowDA: Getvwf_WorkFlowByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvwf_WorkFlowDA: Getvwf_WorkFlowByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsvwf_WorkFlowDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_WorkFlowDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vwf_WorkFlow a where {0} And a.WorkFlowId not in (Select Top {2} WorkFlowId From vwf_WorkFlow Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vwf_WorkFlow");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvwf_WorkFlowDA: Getvwf_WorkFlowByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvwf_WorkFlowDA: Getvwf_WorkFlowByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvwf_WorkFlowDA: Getvwf_WorkFlowByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsvwf_WorkFlowDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_WorkFlowDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vwf_WorkFlow a where {0} And a.WorkFlowId not in (Select Top {2} WorkFlowId From vwf_WorkFlow Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vwf_WorkFlow");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvwf_WorkFlowDA: Getvwf_WorkFlowByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvwf_WorkFlowDA: Getvwf_WorkFlowByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvwf_WorkFlowDA: Getvwf_WorkFlowByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsvwf_WorkFlowDA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsvwf_WorkFlowDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_WorkFlowDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vwf_WorkFlow a where {0} And a.WorkFlowId not in (Select Top {2} WorkFlowId From vwf_WorkFlow Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vwf_WorkFlow");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvwf_WorkFlowDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_WorkFlowDA.GetSpecSQLObj();
strSQL = "Select * from vwf_WorkFlow where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vwf_WorkFlow(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvwf_WorkFlowDA: GetDataTable_vwf_WorkFlow)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_WorkFlowDA.GetSpecSQLObj();
strSQL = "Select * from vwf_WorkFlow where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvwf_WorkFlowDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_WorkFlowDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvwf_WorkFlowDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_WorkFlowDA.GetSpecSQLObj();
strSQL = "Select * from vwf_WorkFlow where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvwf_WorkFlowDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_WorkFlowDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsvwf_WorkFlowDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_WorkFlowDA.GetSpecSQLObj();
strSQL = "Select * from vwf_WorkFlow where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsvwf_WorkFlowDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_WorkFlowDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvwf_WorkFlowDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_WorkFlowDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vwf_WorkFlow where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vwf_WorkFlow where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvwf_WorkFlowDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_WorkFlowDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vwf_WorkFlow where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsvwf_WorkFlowDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_WorkFlowDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vwf_WorkFlow where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvwf_WorkFlowDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_WorkFlowDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vwf_WorkFlow.* from vwf_WorkFlow Left Join {1} on {2} where {3} and vwf_WorkFlow.WorkFlowId not in (Select top {5} vwf_WorkFlow.WorkFlowId from vwf_WorkFlow Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vwf_WorkFlow where {1} and WorkFlowId not in (Select top {2} WorkFlowId from vwf_WorkFlow where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vwf_WorkFlow where {1} and WorkFlowId not in (Select top {3} WorkFlowId from vwf_WorkFlow where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvwf_WorkFlowDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_WorkFlowDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vwf_WorkFlow.* from vwf_WorkFlow Left Join {1} on {2} where {3} and vwf_WorkFlow.WorkFlowId not in (Select top {5} vwf_WorkFlow.WorkFlowId from vwf_WorkFlow Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vwf_WorkFlow where {1} and WorkFlowId not in (Select top {2} WorkFlowId from vwf_WorkFlow where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vwf_WorkFlow where {1} and WorkFlowId not in (Select top {3} WorkFlowId from vwf_WorkFlow where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsvwf_WorkFlowDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_WorkFlowDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vwf_WorkFlow.* from vwf_WorkFlow Left Join {1} on {2} where {3} and vwf_WorkFlow.WorkFlowId not in (Select top {5} vwf_WorkFlow.WorkFlowId from vwf_WorkFlow Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vwf_WorkFlow where {1} and WorkFlowId not in (Select top {2} WorkFlowId from vwf_WorkFlow where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vwf_WorkFlow where {1} and WorkFlowId not in (Select top {3} WorkFlowId from vwf_WorkFlow where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvwf_WorkFlowDA: Getvwf_WorkFlowByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvwf_WorkFlowDA: Getvwf_WorkFlowByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvwf_WorkFlowDA: Getvwf_WorkFlowByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsvwf_WorkFlowDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_WorkFlowDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from vwf_WorkFlow a where {0} And a.WorkFlowId not in (Select Top {2} WorkFlowId From vwf_WorkFlow Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from vwf_WorkFlow a where {0} And a.WorkFlowId not in (Select Top {2} WorkFlowId From vwf_WorkFlow Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvwf_WorkFlowDA: Getvwf_WorkFlowByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvwf_WorkFlowDA: Getvwf_WorkFlowByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvwf_WorkFlowDA: Getvwf_WorkFlowByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsvwf_WorkFlowDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_WorkFlowDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from vwf_WorkFlow a where {0} And a.WorkFlowId not in (Select Top {2} WorkFlowId From vwf_WorkFlow Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from vwf_WorkFlow a where {0} And a.WorkFlowId not in (Select Top {2} WorkFlowId From vwf_WorkFlow Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvwf_WorkFlowDA: Getvwf_WorkFlowByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvwf_WorkFlowDA: Getvwf_WorkFlowByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvwf_WorkFlowDA: Getvwf_WorkFlowByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsvwf_WorkFlowDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_WorkFlowDA.GetSpecSQLObj();
strSQL = "Select * from vwf_WorkFlow where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsvwf_WorkFlowDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_WorkFlowDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vwf_WorkFlow_SelectByCond",values);
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
public List<clsvwf_WorkFlowEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvwf_WorkFlowDA:GetObjLst)", objException.Message));
}
List<clsvwf_WorkFlowEN> arrObjLst = new List<clsvwf_WorkFlowEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_WorkFlowDA.GetSpecSQLObj();
strSQL = "Select * from vwf_WorkFlow where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_WorkFlowEN objvwf_WorkFlowEN = new clsvwf_WorkFlowEN();
try
{
objvwf_WorkFlowEN.WorkFlowId = objRow[convwf_WorkFlow.WorkFlowId].ToString().Trim(); //工作流Id
objvwf_WorkFlowEN.WorkFlowName = objRow[convwf_WorkFlow.WorkFlowName].ToString().Trim(); //工作流名称
objvwf_WorkFlowEN.WorkFlowNameSim = objRow[convwf_WorkFlow.WorkFlowNameSim] == DBNull.Value ? null : objRow[convwf_WorkFlow.WorkFlowNameSim].ToString().Trim(); //工作流简称
objvwf_WorkFlowEN.PrjId = objRow[convwf_WorkFlow.PrjId].ToString().Trim(); //工程ID
objvwf_WorkFlowEN.PrjName = objRow[convwf_WorkFlow.PrjName].ToString().Trim(); //工程名称
objvwf_WorkFlowEN.UpdDate = objRow[convwf_WorkFlow.UpdDate] == DBNull.Value ? null : objRow[convwf_WorkFlow.UpdDate].ToString().Trim(); //修改日期
objvwf_WorkFlowEN.UpdUser = objRow[convwf_WorkFlow.UpdUser] == DBNull.Value ? null : objRow[convwf_WorkFlow.UpdUser].ToString().Trim(); //修改者
objvwf_WorkFlowEN.Memo = objRow[convwf_WorkFlow.Memo] == DBNull.Value ? null : objRow[convwf_WorkFlow.Memo].ToString().Trim(); //说明
objvwf_WorkFlowEN.IsCurrentUse = TransNullToBool(objRow[convwf_WorkFlow.IsCurrentUse].ToString().Trim()); //是否当前使用
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvwf_WorkFlowDA: GetObjLst)", objException.Message));
}
objvwf_WorkFlowEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvwf_WorkFlowEN);
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
public List<clsvwf_WorkFlowEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvwf_WorkFlowDA:GetObjLstByTabName)", objException.Message));
}
List<clsvwf_WorkFlowEN> arrObjLst = new List<clsvwf_WorkFlowEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_WorkFlowDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_WorkFlowEN objvwf_WorkFlowEN = new clsvwf_WorkFlowEN();
try
{
objvwf_WorkFlowEN.WorkFlowId = objRow[convwf_WorkFlow.WorkFlowId].ToString().Trim(); //工作流Id
objvwf_WorkFlowEN.WorkFlowName = objRow[convwf_WorkFlow.WorkFlowName].ToString().Trim(); //工作流名称
objvwf_WorkFlowEN.WorkFlowNameSim = objRow[convwf_WorkFlow.WorkFlowNameSim] == DBNull.Value ? null : objRow[convwf_WorkFlow.WorkFlowNameSim].ToString().Trim(); //工作流简称
objvwf_WorkFlowEN.PrjId = objRow[convwf_WorkFlow.PrjId].ToString().Trim(); //工程ID
objvwf_WorkFlowEN.PrjName = objRow[convwf_WorkFlow.PrjName].ToString().Trim(); //工程名称
objvwf_WorkFlowEN.UpdDate = objRow[convwf_WorkFlow.UpdDate] == DBNull.Value ? null : objRow[convwf_WorkFlow.UpdDate].ToString().Trim(); //修改日期
objvwf_WorkFlowEN.UpdUser = objRow[convwf_WorkFlow.UpdUser] == DBNull.Value ? null : objRow[convwf_WorkFlow.UpdUser].ToString().Trim(); //修改者
objvwf_WorkFlowEN.Memo = objRow[convwf_WorkFlow.Memo] == DBNull.Value ? null : objRow[convwf_WorkFlow.Memo].ToString().Trim(); //说明
objvwf_WorkFlowEN.IsCurrentUse = TransNullToBool(objRow[convwf_WorkFlow.IsCurrentUse].ToString().Trim()); //是否当前使用
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvwf_WorkFlowDA: GetObjLst)", objException.Message));
}
objvwf_WorkFlowEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvwf_WorkFlowEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsvwf_WorkFlowEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsvwf_WorkFlowDA:GetObjLstBySP)", objException.Message));
}
List<clsvwf_WorkFlowEN> arrObjLst = new List<clsvwf_WorkFlowEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_WorkFlowDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vwf_WorkFlow_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_WorkFlowEN objvwf_WorkFlowEN = new clsvwf_WorkFlowEN();
try
{
objvwf_WorkFlowEN.WorkFlowId = objRow[convwf_WorkFlow.WorkFlowId].ToString().Trim(); //工作流Id
objvwf_WorkFlowEN.WorkFlowName = objRow[convwf_WorkFlow.WorkFlowName].ToString().Trim(); //工作流名称
objvwf_WorkFlowEN.WorkFlowNameSim = objRow[convwf_WorkFlow.WorkFlowNameSim] == DBNull.Value ? null : objRow[convwf_WorkFlow.WorkFlowNameSim].ToString().Trim(); //工作流简称
objvwf_WorkFlowEN.PrjId = objRow[convwf_WorkFlow.PrjId].ToString().Trim(); //工程ID
objvwf_WorkFlowEN.PrjName = objRow[convwf_WorkFlow.PrjName].ToString().Trim(); //工程名称
objvwf_WorkFlowEN.UpdDate = objRow[convwf_WorkFlow.UpdDate] == DBNull.Value ? null : objRow[convwf_WorkFlow.UpdDate].ToString().Trim(); //修改日期
objvwf_WorkFlowEN.UpdUser = objRow[convwf_WorkFlow.UpdUser] == DBNull.Value ? null : objRow[convwf_WorkFlow.UpdUser].ToString().Trim(); //修改者
objvwf_WorkFlowEN.Memo = objRow[convwf_WorkFlow.Memo] == DBNull.Value ? null : objRow[convwf_WorkFlow.Memo].ToString().Trim(); //说明
objvwf_WorkFlowEN.IsCurrentUse = TransNullToBool(objRow[convwf_WorkFlow.IsCurrentUse].ToString().Trim()); //是否当前使用
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsvwf_WorkFlowDA: GetObjLstBySP)", objException.Message));
}
objvwf_WorkFlowEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvwf_WorkFlowEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvwf_WorkFlowEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvwf_WorkFlow(ref clsvwf_WorkFlowEN objvwf_WorkFlowEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_WorkFlowDA.GetSpecSQLObj();
strSQL = "Select * from vwf_WorkFlow where WorkFlowId = " + "'"+ objvwf_WorkFlowEN.WorkFlowId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvwf_WorkFlowEN.WorkFlowId = objDT.Rows[0][convwf_WorkFlow.WorkFlowId].ToString().Trim(); //工作流Id(字段类型:char,字段长度:4,是否可空:False)
 objvwf_WorkFlowEN.WorkFlowName = objDT.Rows[0][convwf_WorkFlow.WorkFlowName].ToString().Trim(); //工作流名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvwf_WorkFlowEN.WorkFlowNameSim = objDT.Rows[0][convwf_WorkFlow.WorkFlowNameSim].ToString().Trim(); //工作流简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvwf_WorkFlowEN.PrjId = objDT.Rows[0][convwf_WorkFlow.PrjId].ToString().Trim(); //工程ID(字段类型:char,字段长度:4,是否可空:False)
 objvwf_WorkFlowEN.PrjName = objDT.Rows[0][convwf_WorkFlow.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvwf_WorkFlowEN.UpdDate = objDT.Rows[0][convwf_WorkFlow.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvwf_WorkFlowEN.UpdUser = objDT.Rows[0][convwf_WorkFlow.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvwf_WorkFlowEN.Memo = objDT.Rows[0][convwf_WorkFlow.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvwf_WorkFlowEN.IsCurrentUse = TransNullToBool(objDT.Rows[0][convwf_WorkFlow.IsCurrentUse].ToString().Trim()); //是否当前使用(字段类型:bit,字段长度:1,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvwf_WorkFlowDA: Getvwf_WorkFlow)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strWorkFlowId">表关键字</param>
 /// <returns>表对象</returns>
public clsvwf_WorkFlowEN GetObjByWorkFlowId(string strWorkFlowId)
{
CheckPrimaryKey(strWorkFlowId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_WorkFlowDA.GetSpecSQLObj();
strSQL = "Select * from vwf_WorkFlow where WorkFlowId = " + "'"+ strWorkFlowId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvwf_WorkFlowEN objvwf_WorkFlowEN = new clsvwf_WorkFlowEN();
try
{
 objvwf_WorkFlowEN.WorkFlowId = objRow[convwf_WorkFlow.WorkFlowId].ToString().Trim(); //工作流Id(字段类型:char,字段长度:4,是否可空:False)
 objvwf_WorkFlowEN.WorkFlowName = objRow[convwf_WorkFlow.WorkFlowName].ToString().Trim(); //工作流名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvwf_WorkFlowEN.WorkFlowNameSim = objRow[convwf_WorkFlow.WorkFlowNameSim] == DBNull.Value ? null : objRow[convwf_WorkFlow.WorkFlowNameSim].ToString().Trim(); //工作流简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvwf_WorkFlowEN.PrjId = objRow[convwf_WorkFlow.PrjId].ToString().Trim(); //工程ID(字段类型:char,字段长度:4,是否可空:False)
 objvwf_WorkFlowEN.PrjName = objRow[convwf_WorkFlow.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvwf_WorkFlowEN.UpdDate = objRow[convwf_WorkFlow.UpdDate] == DBNull.Value ? null : objRow[convwf_WorkFlow.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvwf_WorkFlowEN.UpdUser = objRow[convwf_WorkFlow.UpdUser] == DBNull.Value ? null : objRow[convwf_WorkFlow.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvwf_WorkFlowEN.Memo = objRow[convwf_WorkFlow.Memo] == DBNull.Value ? null : objRow[convwf_WorkFlow.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvwf_WorkFlowEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[convwf_WorkFlow.IsCurrentUse].ToString().Trim()); //是否当前使用(字段类型:bit,字段长度:1,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvwf_WorkFlowDA: GetObjByWorkFlowId)", objException.Message));
}
return objvwf_WorkFlowEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程vwf_WorkFlow_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objvwf_WorkFlowEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvwf_WorkFlowOneBySP(clsvwf_WorkFlowEN objvwf_WorkFlowEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_WorkFlowDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objvwf_WorkFlowEN.WorkFlowId
};
 objDT = objSQL.ExecSpReturnDT("vwf_WorkFlow_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objvwf_WorkFlowEN.WorkFlowId = objDT.Rows[0][convwf_WorkFlow.WorkFlowId].ToString().Trim(); //工作流Id(字段类型:char,字段长度:4,是否可空:False)
 objvwf_WorkFlowEN.WorkFlowName = objDT.Rows[0][convwf_WorkFlow.WorkFlowName].ToString().Trim(); //工作流名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvwf_WorkFlowEN.WorkFlowNameSim = objDT.Rows[0][convwf_WorkFlow.WorkFlowNameSim].ToString().Trim(); //工作流简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvwf_WorkFlowEN.PrjId = objDT.Rows[0][convwf_WorkFlow.PrjId].ToString().Trim(); //工程ID(字段类型:char,字段长度:4,是否可空:False)
 objvwf_WorkFlowEN.PrjName = objDT.Rows[0][convwf_WorkFlow.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvwf_WorkFlowEN.UpdDate = objDT.Rows[0][convwf_WorkFlow.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvwf_WorkFlowEN.UpdUser = objDT.Rows[0][convwf_WorkFlow.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvwf_WorkFlowEN.Memo = objDT.Rows[0][convwf_WorkFlow.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvwf_WorkFlowEN.IsCurrentUse = TransNullToBool(objDT.Rows[0][convwf_WorkFlow.IsCurrentUse].ToString().Trim()); //是否当前使用(字段类型:bit,字段长度:1,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvwf_WorkFlowEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvwf_WorkFlowDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_WorkFlowDA.GetSpecSQLObj();
strSQL = "Select * from vwf_WorkFlow where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvwf_WorkFlowEN objvwf_WorkFlowEN = new clsvwf_WorkFlowEN()
{
WorkFlowId = objRow[convwf_WorkFlow.WorkFlowId].ToString().Trim(), //工作流Id
WorkFlowName = objRow[convwf_WorkFlow.WorkFlowName].ToString().Trim(), //工作流名称
WorkFlowNameSim = objRow[convwf_WorkFlow.WorkFlowNameSim] == DBNull.Value ? null : objRow[convwf_WorkFlow.WorkFlowNameSim].ToString().Trim(), //工作流简称
PrjId = objRow[convwf_WorkFlow.PrjId].ToString().Trim(), //工程ID
PrjName = objRow[convwf_WorkFlow.PrjName].ToString().Trim(), //工程名称
UpdDate = objRow[convwf_WorkFlow.UpdDate] == DBNull.Value ? null : objRow[convwf_WorkFlow.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convwf_WorkFlow.UpdUser] == DBNull.Value ? null : objRow[convwf_WorkFlow.UpdUser].ToString().Trim(), //修改者
Memo = objRow[convwf_WorkFlow.Memo] == DBNull.Value ? null : objRow[convwf_WorkFlow.Memo].ToString().Trim(), //说明
IsCurrentUse = TransNullToBool(objRow[convwf_WorkFlow.IsCurrentUse].ToString().Trim()) //是否当前使用
};
objvwf_WorkFlowEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvwf_WorkFlowEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvwf_WorkFlowDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvwf_WorkFlowEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsvwf_WorkFlowDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_WorkFlowDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vwf_WorkFlow_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsvwf_WorkFlowEN objvwf_WorkFlowEN = new clsvwf_WorkFlowEN()
{
WorkFlowId = objRow[convwf_WorkFlow.WorkFlowId].ToString().Trim(), //工作流Id
WorkFlowName = objRow[convwf_WorkFlow.WorkFlowName].ToString().Trim(), //工作流名称
WorkFlowNameSim = objRow[convwf_WorkFlow.WorkFlowNameSim] == DBNull.Value ? null : objRow[convwf_WorkFlow.WorkFlowNameSim].ToString().Trim(), //工作流简称
PrjId = objRow[convwf_WorkFlow.PrjId].ToString().Trim(), //工程ID
PrjName = objRow[convwf_WorkFlow.PrjName].ToString().Trim(), //工程名称
UpdDate = objRow[convwf_WorkFlow.UpdDate] == DBNull.Value ? null : objRow[convwf_WorkFlow.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convwf_WorkFlow.UpdUser] == DBNull.Value ? null : objRow[convwf_WorkFlow.UpdUser].ToString().Trim(), //修改者
Memo = objRow[convwf_WorkFlow.Memo] == DBNull.Value ? null : objRow[convwf_WorkFlow.Memo].ToString().Trim(), //说明
IsCurrentUse = TransNullToBool(objRow[convwf_WorkFlow.IsCurrentUse].ToString().Trim()) //是否当前使用
};
objvwf_WorkFlowEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvwf_WorkFlowEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvwf_WorkFlowEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvwf_WorkFlowEN objvwf_WorkFlowEN = new clsvwf_WorkFlowEN();
try
{
objvwf_WorkFlowEN.WorkFlowId = objRow[convwf_WorkFlow.WorkFlowId].ToString().Trim(); //工作流Id
objvwf_WorkFlowEN.WorkFlowName = objRow[convwf_WorkFlow.WorkFlowName].ToString().Trim(); //工作流名称
objvwf_WorkFlowEN.WorkFlowNameSim = objRow[convwf_WorkFlow.WorkFlowNameSim] == DBNull.Value ? null : objRow[convwf_WorkFlow.WorkFlowNameSim].ToString().Trim(); //工作流简称
objvwf_WorkFlowEN.PrjId = objRow[convwf_WorkFlow.PrjId].ToString().Trim(); //工程ID
objvwf_WorkFlowEN.PrjName = objRow[convwf_WorkFlow.PrjName].ToString().Trim(); //工程名称
objvwf_WorkFlowEN.UpdDate = objRow[convwf_WorkFlow.UpdDate] == DBNull.Value ? null : objRow[convwf_WorkFlow.UpdDate].ToString().Trim(); //修改日期
objvwf_WorkFlowEN.UpdUser = objRow[convwf_WorkFlow.UpdUser] == DBNull.Value ? null : objRow[convwf_WorkFlow.UpdUser].ToString().Trim(); //修改者
objvwf_WorkFlowEN.Memo = objRow[convwf_WorkFlow.Memo] == DBNull.Value ? null : objRow[convwf_WorkFlow.Memo].ToString().Trim(); //说明
objvwf_WorkFlowEN.IsCurrentUse = TransNullToBool(objRow[convwf_WorkFlow.IsCurrentUse].ToString().Trim()); //是否当前使用
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvwf_WorkFlowDA: GetObjByDataRowvwf_WorkFlow)", objException.Message));
}
objvwf_WorkFlowEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvwf_WorkFlowEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvwf_WorkFlowEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvwf_WorkFlowEN objvwf_WorkFlowEN = new clsvwf_WorkFlowEN();
try
{
objvwf_WorkFlowEN.WorkFlowId = objRow[convwf_WorkFlow.WorkFlowId].ToString().Trim(); //工作流Id
objvwf_WorkFlowEN.WorkFlowName = objRow[convwf_WorkFlow.WorkFlowName].ToString().Trim(); //工作流名称
objvwf_WorkFlowEN.WorkFlowNameSim = objRow[convwf_WorkFlow.WorkFlowNameSim] == DBNull.Value ? null : objRow[convwf_WorkFlow.WorkFlowNameSim].ToString().Trim(); //工作流简称
objvwf_WorkFlowEN.PrjId = objRow[convwf_WorkFlow.PrjId].ToString().Trim(); //工程ID
objvwf_WorkFlowEN.PrjName = objRow[convwf_WorkFlow.PrjName].ToString().Trim(); //工程名称
objvwf_WorkFlowEN.UpdDate = objRow[convwf_WorkFlow.UpdDate] == DBNull.Value ? null : objRow[convwf_WorkFlow.UpdDate].ToString().Trim(); //修改日期
objvwf_WorkFlowEN.UpdUser = objRow[convwf_WorkFlow.UpdUser] == DBNull.Value ? null : objRow[convwf_WorkFlow.UpdUser].ToString().Trim(); //修改者
objvwf_WorkFlowEN.Memo = objRow[convwf_WorkFlow.Memo] == DBNull.Value ? null : objRow[convwf_WorkFlow.Memo].ToString().Trim(); //说明
objvwf_WorkFlowEN.IsCurrentUse = TransNullToBool(objRow[convwf_WorkFlow.IsCurrentUse].ToString().Trim()); //是否当前使用
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvwf_WorkFlowDA: GetObjByDataRow)", objException.Message));
}
objvwf_WorkFlowEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvwf_WorkFlowEN;
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
objSQL = clsvwf_WorkFlowDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvwf_WorkFlowEN._CurrTabName, convwf_WorkFlow.WorkFlowId, 4, "");
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
objSQL = clsvwf_WorkFlowDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvwf_WorkFlowEN._CurrTabName, convwf_WorkFlow.WorkFlowId, 4, strPrefix);
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
 objSQL = clsvwf_WorkFlowDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select WorkFlowId from vwf_WorkFlow where " + strCondition;
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
 objSQL = clsvwf_WorkFlowDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select WorkFlowId from vwf_WorkFlow where " + strCondition;
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
 /// <param name = "strWorkFlowId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strWorkFlowId)
{
CheckPrimaryKey(strWorkFlowId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_WorkFlowDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vwf_WorkFlow", "WorkFlowId = " + "'"+ strWorkFlowId+"'"))
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
 /// <param name = "strWorkFlowId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExistBySP(string strWorkFlowId)
{
CheckPrimaryKey(strWorkFlowId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_WorkFlowDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
strWorkFlowId,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("vwf_WorkFlow_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvwf_WorkFlowDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_WorkFlowDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vwf_WorkFlow", strCondition))
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
objSQL = clsvwf_WorkFlowDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vwf_WorkFlow");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvwf_WorkFlowENS">源对象</param>
 /// <param name = "objvwf_WorkFlowENT">目标对象</param>
public void CopyTo(clsvwf_WorkFlowEN objvwf_WorkFlowENS, clsvwf_WorkFlowEN objvwf_WorkFlowENT)
{
objvwf_WorkFlowENT.WorkFlowId = objvwf_WorkFlowENS.WorkFlowId; //工作流Id
objvwf_WorkFlowENT.WorkFlowName = objvwf_WorkFlowENS.WorkFlowName; //工作流名称
objvwf_WorkFlowENT.WorkFlowNameSim = objvwf_WorkFlowENS.WorkFlowNameSim; //工作流简称
objvwf_WorkFlowENT.PrjId = objvwf_WorkFlowENS.PrjId; //工程ID
objvwf_WorkFlowENT.PrjName = objvwf_WorkFlowENS.PrjName; //工程名称
objvwf_WorkFlowENT.UpdDate = objvwf_WorkFlowENS.UpdDate; //修改日期
objvwf_WorkFlowENT.UpdUser = objvwf_WorkFlowENS.UpdUser; //修改者
objvwf_WorkFlowENT.Memo = objvwf_WorkFlowENS.Memo; //说明
objvwf_WorkFlowENT.IsCurrentUse = objvwf_WorkFlowENS.IsCurrentUse; //是否当前使用
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvwf_WorkFlowEN objvwf_WorkFlowEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvwf_WorkFlowEN.WorkFlowId, 4, convwf_WorkFlow.WorkFlowId);
clsCheckSql.CheckFieldLen(objvwf_WorkFlowEN.WorkFlowName, 50, convwf_WorkFlow.WorkFlowName);
clsCheckSql.CheckFieldLen(objvwf_WorkFlowEN.WorkFlowNameSim, 30, convwf_WorkFlow.WorkFlowNameSim);
clsCheckSql.CheckFieldLen(objvwf_WorkFlowEN.PrjId, 4, convwf_WorkFlow.PrjId);
clsCheckSql.CheckFieldLen(objvwf_WorkFlowEN.PrjName, 30, convwf_WorkFlow.PrjName);
clsCheckSql.CheckFieldLen(objvwf_WorkFlowEN.UpdDate, 20, convwf_WorkFlow.UpdDate);
clsCheckSql.CheckFieldLen(objvwf_WorkFlowEN.UpdUser, 20, convwf_WorkFlow.UpdUser);
clsCheckSql.CheckFieldLen(objvwf_WorkFlowEN.Memo, 1000, convwf_WorkFlow.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvwf_WorkFlowEN.WorkFlowId, convwf_WorkFlow.WorkFlowId);
clsCheckSql.CheckSqlInjection4Field(objvwf_WorkFlowEN.WorkFlowName, convwf_WorkFlow.WorkFlowName);
clsCheckSql.CheckSqlInjection4Field(objvwf_WorkFlowEN.WorkFlowNameSim, convwf_WorkFlow.WorkFlowNameSim);
clsCheckSql.CheckSqlInjection4Field(objvwf_WorkFlowEN.PrjId, convwf_WorkFlow.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvwf_WorkFlowEN.PrjName, convwf_WorkFlow.PrjName);
clsCheckSql.CheckSqlInjection4Field(objvwf_WorkFlowEN.UpdDate, convwf_WorkFlow.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvwf_WorkFlowEN.UpdUser, convwf_WorkFlow.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvwf_WorkFlowEN.Memo, convwf_WorkFlow.Memo);
//检查外键字段长度
 objvwf_WorkFlowEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetWorkFlowId()
{
//获取某学院所有专业信息
string strSQL = "select WorkFlowId, WorkFlowName from vwf_WorkFlow ";
 clsSpecSQLforSql mySql = clsvwf_WorkFlowDA.GetSpecSQLObj();
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
 objSQL = clsvwf_WorkFlowDA.GetSpecSQLObj();
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
 objSQL = clsvwf_WorkFlowDA.GetSpecSQLObj();
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
 objSQL = clsvwf_WorkFlowDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvwf_WorkFlowEN._CurrTabName);
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
 objSQL = clsvwf_WorkFlowDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvwf_WorkFlowEN._CurrTabName, strCondition);
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
 objSQL = clsvwf_WorkFlowDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}