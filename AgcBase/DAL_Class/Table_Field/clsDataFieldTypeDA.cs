
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDataFieldTypeDA
 表名:DataFieldType(00050596)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:13:48
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
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
 /// 数据字段类型(DataFieldType)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class clsDataFieldTypeDA : clsCommBase4DA
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
 return clsDataFieldTypeEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsDataFieldTypeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsDataFieldTypeEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsDataFieldTypeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsDataFieldTypeEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strDataFieldTypeId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strDataFieldTypeId)
{
strDataFieldTypeId = strDataFieldTypeId.Replace("'", "''");
if (strDataFieldTypeId.Length > 2)
{
throw new Exception("(errid:Data000001)在表:DataFieldType中,检查关键字,长度不正确!(clsDataFieldTypeDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strDataFieldTypeId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:DataFieldType中,关键字不能为空 或 null!(clsDataFieldTypeDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strDataFieldTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsDataFieldTypeDA:CheckPrimaryKey)", objException.Message));
}
return true;
}

 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey_Sim)
 /// </summary>
 /// <param name = "strDataFieldTypeId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey_Sim(string strDataFieldTypeId)
{
strDataFieldTypeId = strDataFieldTypeId.Replace("'", "''");
if (strDataFieldTypeId.Length > 2 + 4)
{
throw new Exception("(errid:Data000004)在表:DataFieldType中,检查关键字,长度不正确!(简化版)(clsDataFieldTypeDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strDataFieldTypeId)  ==  true)
{
throw new Exception("(errid:Data000005)在表:DataFieldType中,关键字不能为空 或 null!(clsDataFieldTypeDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strDataFieldTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000006)在关键字中含有{0},非法,请检查!(clsDataFieldTypeDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsDataFieldTypeDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
 strSQL = "Select * from DataFieldType where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "DataFieldType");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsDataFieldTypeDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("DataFieldType_SelectByCond",values, "DataFieldType");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsDataFieldTypeDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from DataFieldType where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "DataFieldType");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsDataFieldTypeDA: GetDataFieldTypeByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsDataFieldTypeDA: GetDataFieldTypeByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsDataFieldTypeDA: GetDataFieldTypeByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsDataFieldTypeDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from DataFieldType a where {0} And a.DataFieldTypeId not in (Select Top {2} DataFieldTypeId From DataFieldType Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "DataFieldType");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsDataFieldTypeDA: GetDataFieldTypeByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsDataFieldTypeDA: GetDataFieldTypeByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsDataFieldTypeDA: GetDataFieldTypeByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsDataFieldTypeDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from DataFieldType a where {0} And a.DataFieldTypeId not in (Select Top {2} DataFieldTypeId From DataFieldType Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "DataFieldType");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsDataFieldTypeDA: GetDataFieldTypeByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsDataFieldTypeDA: GetDataFieldTypeByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsDataFieldTypeDA: GetDataFieldTypeByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsDataFieldTypeDA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsDataFieldTypeDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from DataFieldType a where {0} And a.DataFieldTypeId not in (Select Top {2} DataFieldTypeId From DataFieldType Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "DataFieldType");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsDataFieldTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
strSQL = "Select * from DataFieldType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_DataFieldType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsDataFieldTypeDA: GetDataTable_DataFieldType)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
strSQL = "Select * from DataFieldType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsDataFieldTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsDataFieldTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
strSQL = "Select * from DataFieldType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsDataFieldTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsDataFieldTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
strSQL = "Select * from DataFieldType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsDataFieldTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsDataFieldTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from DataFieldType where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from DataFieldType where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsDataFieldTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from DataFieldType where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsDataFieldTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from DataFieldType where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsDataFieldTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} DataFieldType.* from DataFieldType Left Join {1} on {2} where {3} and DataFieldType.DataFieldTypeId not in (Select top {5} DataFieldType.DataFieldTypeId from DataFieldType Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from DataFieldType where {1} and DataFieldTypeId not in (Select top {2} DataFieldTypeId from DataFieldType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from DataFieldType where {1} and DataFieldTypeId not in (Select top {3} DataFieldTypeId from DataFieldType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsDataFieldTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} DataFieldType.* from DataFieldType Left Join {1} on {2} where {3} and DataFieldType.DataFieldTypeId not in (Select top {5} DataFieldType.DataFieldTypeId from DataFieldType Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from DataFieldType where {1} and DataFieldTypeId not in (Select top {2} DataFieldTypeId from DataFieldType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from DataFieldType where {1} and DataFieldTypeId not in (Select top {3} DataFieldTypeId from DataFieldType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsDataFieldTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} DataFieldType.* from DataFieldType Left Join {1} on {2} where {3} and DataFieldType.DataFieldTypeId not in (Select top {5} DataFieldType.DataFieldTypeId from DataFieldType Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from DataFieldType where {1} and DataFieldTypeId not in (Select top {2} DataFieldTypeId from DataFieldType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from DataFieldType where {1} and DataFieldTypeId not in (Select top {3} DataFieldTypeId from DataFieldType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsDataFieldTypeDA: GetDataFieldTypeByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsDataFieldTypeDA: GetDataFieldTypeByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsDataFieldTypeDA: GetDataFieldTypeByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsDataFieldTypeDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from DataFieldType a where {0} And a.DataFieldTypeId not in (Select Top {2} DataFieldTypeId From DataFieldType Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from DataFieldType a where {0} And a.DataFieldTypeId not in (Select Top {2} DataFieldTypeId From DataFieldType Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsDataFieldTypeDA: GetDataFieldTypeByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsDataFieldTypeDA: GetDataFieldTypeByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsDataFieldTypeDA: GetDataFieldTypeByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsDataFieldTypeDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from DataFieldType a where {0} And a.DataFieldTypeId not in (Select Top {2} DataFieldTypeId From DataFieldType Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from DataFieldType a where {0} And a.DataFieldTypeId not in (Select Top {2} DataFieldTypeId From DataFieldType Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsDataFieldTypeDA: GetDataFieldTypeByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsDataFieldTypeDA: GetDataFieldTypeByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsDataFieldTypeDA: GetDataFieldTypeByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsDataFieldTypeDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
strSQL = "Select * from DataFieldType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsDataFieldTypeDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("DataFieldType_SelectByCond",values);
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
public List<clsDataFieldTypeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsDataFieldTypeDA:GetObjLst)", objException.Message));
}
List<clsDataFieldTypeEN> arrObjLst = new List<clsDataFieldTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
strSQL = "Select * from DataFieldType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataFieldTypeEN objDataFieldTypeEN = new clsDataFieldTypeEN();
try
{
objDataFieldTypeEN.DataFieldTypeId = objRow[conDataFieldType.DataFieldTypeId].ToString().Trim(); //数据字段类型Id
objDataFieldTypeEN.DataFieldTypeName = objRow[conDataFieldType.DataFieldTypeName].ToString().Trim(); //数据字段类型名
objDataFieldTypeEN.DataFieldTypeENName = objRow[conDataFieldType.DataFieldTypeENName] == DBNull.Value ? null : objRow[conDataFieldType.DataFieldTypeENName].ToString().Trim(); //数据字段类型英文名
objDataFieldTypeEN.UpdDate = objRow[conDataFieldType.UpdDate] == DBNull.Value ? null : objRow[conDataFieldType.UpdDate].ToString().Trim(); //修改日期
objDataFieldTypeEN.UpdUser = objRow[conDataFieldType.UpdUser] == DBNull.Value ? null : objRow[conDataFieldType.UpdUser].ToString().Trim(); //修改者
objDataFieldTypeEN.Memo = objRow[conDataFieldType.Memo] == DBNull.Value ? null : objRow[conDataFieldType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsDataFieldTypeDA: GetObjLst)", objException.Message));
}
objDataFieldTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objDataFieldTypeEN);
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
public List<clsDataFieldTypeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsDataFieldTypeDA:GetObjLstByTabName)", objException.Message));
}
List<clsDataFieldTypeEN> arrObjLst = new List<clsDataFieldTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataFieldTypeEN objDataFieldTypeEN = new clsDataFieldTypeEN();
try
{
objDataFieldTypeEN.DataFieldTypeId = objRow[conDataFieldType.DataFieldTypeId].ToString().Trim(); //数据字段类型Id
objDataFieldTypeEN.DataFieldTypeName = objRow[conDataFieldType.DataFieldTypeName].ToString().Trim(); //数据字段类型名
objDataFieldTypeEN.DataFieldTypeENName = objRow[conDataFieldType.DataFieldTypeENName] == DBNull.Value ? null : objRow[conDataFieldType.DataFieldTypeENName].ToString().Trim(); //数据字段类型英文名
objDataFieldTypeEN.UpdDate = objRow[conDataFieldType.UpdDate] == DBNull.Value ? null : objRow[conDataFieldType.UpdDate].ToString().Trim(); //修改日期
objDataFieldTypeEN.UpdUser = objRow[conDataFieldType.UpdUser] == DBNull.Value ? null : objRow[conDataFieldType.UpdUser].ToString().Trim(); //修改者
objDataFieldTypeEN.Memo = objRow[conDataFieldType.Memo] == DBNull.Value ? null : objRow[conDataFieldType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsDataFieldTypeDA: GetObjLst)", objException.Message));
}
objDataFieldTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objDataFieldTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsDataFieldTypeEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsDataFieldTypeDA:GetObjLstBySP)", objException.Message));
}
List<clsDataFieldTypeEN> arrObjLst = new List<clsDataFieldTypeEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("DataFieldType_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataFieldTypeEN objDataFieldTypeEN = new clsDataFieldTypeEN();
try
{
objDataFieldTypeEN.DataFieldTypeId = objRow[conDataFieldType.DataFieldTypeId].ToString().Trim(); //数据字段类型Id
objDataFieldTypeEN.DataFieldTypeName = objRow[conDataFieldType.DataFieldTypeName].ToString().Trim(); //数据字段类型名
objDataFieldTypeEN.DataFieldTypeENName = objRow[conDataFieldType.DataFieldTypeENName] == DBNull.Value ? null : objRow[conDataFieldType.DataFieldTypeENName].ToString().Trim(); //数据字段类型英文名
objDataFieldTypeEN.UpdDate = objRow[conDataFieldType.UpdDate] == DBNull.Value ? null : objRow[conDataFieldType.UpdDate].ToString().Trim(); //修改日期
objDataFieldTypeEN.UpdUser = objRow[conDataFieldType.UpdUser] == DBNull.Value ? null : objRow[conDataFieldType.UpdUser].ToString().Trim(); //修改者
objDataFieldTypeEN.Memo = objRow[conDataFieldType.Memo] == DBNull.Value ? null : objRow[conDataFieldType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsDataFieldTypeDA: GetObjLstBySP)", objException.Message));
}
objDataFieldTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objDataFieldTypeEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objDataFieldTypeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetDataFieldType(ref clsDataFieldTypeEN objDataFieldTypeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
strSQL = "Select * from DataFieldType where DataFieldTypeId = " + "'"+ objDataFieldTypeEN.DataFieldTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objDataFieldTypeEN.DataFieldTypeId = objDT.Rows[0][conDataFieldType.DataFieldTypeId].ToString().Trim(); //数据字段类型Id(字段类型:char,字段长度:2,是否可空:False)
 objDataFieldTypeEN.DataFieldTypeName = objDT.Rows[0][conDataFieldType.DataFieldTypeName].ToString().Trim(); //数据字段类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objDataFieldTypeEN.DataFieldTypeENName = objDT.Rows[0][conDataFieldType.DataFieldTypeENName].ToString().Trim(); //数据字段类型英文名(字段类型:varchar,字段长度:30,是否可空:True)
 objDataFieldTypeEN.UpdDate = objDT.Rows[0][conDataFieldType.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objDataFieldTypeEN.UpdUser = objDT.Rows[0][conDataFieldType.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objDataFieldTypeEN.Memo = objDT.Rows[0][conDataFieldType.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsDataFieldTypeDA: GetDataFieldType)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strDataFieldTypeId">表关键字</param>
 /// <returns>表对象</returns>
public clsDataFieldTypeEN GetObjByDataFieldTypeId(string strDataFieldTypeId)
{
CheckPrimaryKey(strDataFieldTypeId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
strSQL = "Select * from DataFieldType where DataFieldTypeId = " + "'"+ strDataFieldTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsDataFieldTypeEN objDataFieldTypeEN = new clsDataFieldTypeEN();
try
{
 objDataFieldTypeEN.DataFieldTypeId = objRow[conDataFieldType.DataFieldTypeId].ToString().Trim(); //数据字段类型Id(字段类型:char,字段长度:2,是否可空:False)
 objDataFieldTypeEN.DataFieldTypeName = objRow[conDataFieldType.DataFieldTypeName].ToString().Trim(); //数据字段类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objDataFieldTypeEN.DataFieldTypeENName = objRow[conDataFieldType.DataFieldTypeENName] == DBNull.Value ? null : objRow[conDataFieldType.DataFieldTypeENName].ToString().Trim(); //数据字段类型英文名(字段类型:varchar,字段长度:30,是否可空:True)
 objDataFieldTypeEN.UpdDate = objRow[conDataFieldType.UpdDate] == DBNull.Value ? null : objRow[conDataFieldType.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objDataFieldTypeEN.UpdUser = objRow[conDataFieldType.UpdUser] == DBNull.Value ? null : objRow[conDataFieldType.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objDataFieldTypeEN.Memo = objRow[conDataFieldType.Memo] == DBNull.Value ? null : objRow[conDataFieldType.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsDataFieldTypeDA: GetObjByDataFieldTypeId)", objException.Message));
}
return objDataFieldTypeEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程DataFieldType_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objDataFieldTypeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetDataFieldTypeOneBySP(clsDataFieldTypeEN objDataFieldTypeEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objDataFieldTypeEN.DataFieldTypeId
};
 objDT = objSQL.ExecSpReturnDT("DataFieldType_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objDataFieldTypeEN.DataFieldTypeId = objDT.Rows[0][conDataFieldType.DataFieldTypeId].ToString().Trim(); //数据字段类型Id(字段类型:char,字段长度:2,是否可空:False)
 objDataFieldTypeEN.DataFieldTypeName = objDT.Rows[0][conDataFieldType.DataFieldTypeName].ToString().Trim(); //数据字段类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objDataFieldTypeEN.DataFieldTypeENName = objDT.Rows[0][conDataFieldType.DataFieldTypeENName].ToString().Trim(); //数据字段类型英文名(字段类型:varchar,字段长度:30,是否可空:True)
 objDataFieldTypeEN.UpdDate = objDT.Rows[0][conDataFieldType.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objDataFieldTypeEN.UpdUser = objDT.Rows[0][conDataFieldType.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objDataFieldTypeEN.Memo = objDT.Rows[0][conDataFieldType.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsDataFieldTypeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsDataFieldTypeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
strSQL = "Select * from DataFieldType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsDataFieldTypeEN objDataFieldTypeEN = new clsDataFieldTypeEN()
{
DataFieldTypeId = objRow[conDataFieldType.DataFieldTypeId].ToString().Trim(), //数据字段类型Id
DataFieldTypeName = objRow[conDataFieldType.DataFieldTypeName].ToString().Trim(), //数据字段类型名
DataFieldTypeENName = objRow[conDataFieldType.DataFieldTypeENName] == DBNull.Value ? null : objRow[conDataFieldType.DataFieldTypeENName].ToString().Trim(), //数据字段类型英文名
UpdDate = objRow[conDataFieldType.UpdDate] == DBNull.Value ? null : objRow[conDataFieldType.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conDataFieldType.UpdUser] == DBNull.Value ? null : objRow[conDataFieldType.UpdUser].ToString().Trim(), //修改者
Memo = objRow[conDataFieldType.Memo] == DBNull.Value ? null : objRow[conDataFieldType.Memo].ToString().Trim() //说明
};
objDataFieldTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objDataFieldTypeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsDataFieldTypeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsDataFieldTypeEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsDataFieldTypeDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("DataFieldType_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsDataFieldTypeEN objDataFieldTypeEN = new clsDataFieldTypeEN()
{
DataFieldTypeId = objRow[conDataFieldType.DataFieldTypeId].ToString().Trim(), //数据字段类型Id
DataFieldTypeName = objRow[conDataFieldType.DataFieldTypeName].ToString().Trim(), //数据字段类型名
DataFieldTypeENName = objRow[conDataFieldType.DataFieldTypeENName] == DBNull.Value ? null : objRow[conDataFieldType.DataFieldTypeENName].ToString().Trim(), //数据字段类型英文名
UpdDate = objRow[conDataFieldType.UpdDate] == DBNull.Value ? null : objRow[conDataFieldType.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conDataFieldType.UpdUser] == DBNull.Value ? null : objRow[conDataFieldType.UpdUser].ToString().Trim(), //修改者
Memo = objRow[conDataFieldType.Memo] == DBNull.Value ? null : objRow[conDataFieldType.Memo].ToString().Trim() //说明
};
objDataFieldTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objDataFieldTypeEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsDataFieldTypeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsDataFieldTypeEN objDataFieldTypeEN = new clsDataFieldTypeEN();
try
{
objDataFieldTypeEN.DataFieldTypeId = objRow[conDataFieldType.DataFieldTypeId].ToString().Trim(); //数据字段类型Id
objDataFieldTypeEN.DataFieldTypeName = objRow[conDataFieldType.DataFieldTypeName].ToString().Trim(); //数据字段类型名
objDataFieldTypeEN.DataFieldTypeENName = objRow[conDataFieldType.DataFieldTypeENName] == DBNull.Value ? null : objRow[conDataFieldType.DataFieldTypeENName].ToString().Trim(); //数据字段类型英文名
objDataFieldTypeEN.UpdDate = objRow[conDataFieldType.UpdDate] == DBNull.Value ? null : objRow[conDataFieldType.UpdDate].ToString().Trim(); //修改日期
objDataFieldTypeEN.UpdUser = objRow[conDataFieldType.UpdUser] == DBNull.Value ? null : objRow[conDataFieldType.UpdUser].ToString().Trim(); //修改者
objDataFieldTypeEN.Memo = objRow[conDataFieldType.Memo] == DBNull.Value ? null : objRow[conDataFieldType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsDataFieldTypeDA: GetObjByDataRowDataFieldType)", objException.Message));
}
objDataFieldTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objDataFieldTypeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsDataFieldTypeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsDataFieldTypeEN objDataFieldTypeEN = new clsDataFieldTypeEN();
try
{
objDataFieldTypeEN.DataFieldTypeId = objRow[conDataFieldType.DataFieldTypeId].ToString().Trim(); //数据字段类型Id
objDataFieldTypeEN.DataFieldTypeName = objRow[conDataFieldType.DataFieldTypeName].ToString().Trim(); //数据字段类型名
objDataFieldTypeEN.DataFieldTypeENName = objRow[conDataFieldType.DataFieldTypeENName] == DBNull.Value ? null : objRow[conDataFieldType.DataFieldTypeENName].ToString().Trim(); //数据字段类型英文名
objDataFieldTypeEN.UpdDate = objRow[conDataFieldType.UpdDate] == DBNull.Value ? null : objRow[conDataFieldType.UpdDate].ToString().Trim(); //修改日期
objDataFieldTypeEN.UpdUser = objRow[conDataFieldType.UpdUser] == DBNull.Value ? null : objRow[conDataFieldType.UpdUser].ToString().Trim(); //修改者
objDataFieldTypeEN.Memo = objRow[conDataFieldType.Memo] == DBNull.Value ? null : objRow[conDataFieldType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsDataFieldTypeDA: GetObjByDataRow)", objException.Message));
}
objDataFieldTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objDataFieldTypeEN;
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
objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsDataFieldTypeEN._CurrTabName, conDataFieldType.DataFieldTypeId, 2, "");
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
objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsDataFieldTypeEN._CurrTabName, conDataFieldType.DataFieldTypeId, 2, strPrefix);
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
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select DataFieldTypeId from DataFieldType where " + strCondition;
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
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select DataFieldTypeId from DataFieldType where " + strCondition;
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
 /// <param name = "strDataFieldTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strDataFieldTypeId)
{
CheckPrimaryKey(strDataFieldTypeId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("DataFieldType", "DataFieldTypeId = " + "'"+ strDataFieldTypeId+"'"))
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
 /// <param name = "strDataFieldTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExistBySP(string strDataFieldTypeId)
{
CheckPrimaryKey(strDataFieldTypeId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
strDataFieldTypeId,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("DataFieldType_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsDataFieldTypeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("DataFieldType", strCondition))
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
objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("DataFieldType");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsDataFieldTypeEN objDataFieldTypeEN)
 {
 objDataFieldTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDataFieldTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDataFieldTypeEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
strSQL = "Select * from DataFieldType where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "DataFieldType");
objRow = objDS.Tables["DataFieldType"].NewRow();
objRow[conDataFieldType.DataFieldTypeId] = objDataFieldTypeEN.DataFieldTypeId; //数据字段类型Id
objRow[conDataFieldType.DataFieldTypeName] = objDataFieldTypeEN.DataFieldTypeName; //数据字段类型名
 if (objDataFieldTypeEN.DataFieldTypeENName !=  "")
 {
objRow[conDataFieldType.DataFieldTypeENName] = objDataFieldTypeEN.DataFieldTypeENName; //数据字段类型英文名
 }
 if (objDataFieldTypeEN.UpdDate !=  "")
 {
objRow[conDataFieldType.UpdDate] = objDataFieldTypeEN.UpdDate; //修改日期
 }
 if (objDataFieldTypeEN.UpdUser !=  "")
 {
objRow[conDataFieldType.UpdUser] = objDataFieldTypeEN.UpdUser; //修改者
 }
 if (objDataFieldTypeEN.Memo !=  "")
 {
objRow[conDataFieldType.Memo] = objDataFieldTypeEN.Memo; //说明
 }
objDS.Tables[clsDataFieldTypeEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsDataFieldTypeEN._CurrTabName);
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
 /// <param name = "objDataFieldTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsDataFieldTypeEN objDataFieldTypeEN)
{
 objDataFieldTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDataFieldTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDataFieldTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objDataFieldTypeEN.DataFieldTypeId !=  null)
 {
 arrFieldListForInsert.Add(conDataFieldType.DataFieldTypeId);
 objDataFieldTypeEN.DataFieldTypeId = objDataFieldTypeEN.DataFieldTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataFieldTypeEN.DataFieldTypeId + "'");
 }
 
 if (objDataFieldTypeEN.DataFieldTypeName !=  null)
 {
 arrFieldListForInsert.Add(conDataFieldType.DataFieldTypeName);
 objDataFieldTypeEN.DataFieldTypeName = objDataFieldTypeEN.DataFieldTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataFieldTypeEN.DataFieldTypeName + "'");
 }
 
 if (objDataFieldTypeEN.DataFieldTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conDataFieldType.DataFieldTypeENName);
 objDataFieldTypeEN.DataFieldTypeENName = objDataFieldTypeEN.DataFieldTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataFieldTypeEN.DataFieldTypeENName + "'");
 }
 
 if (objDataFieldTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conDataFieldType.UpdDate);
 objDataFieldTypeEN.UpdDate = objDataFieldTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataFieldTypeEN.UpdDate + "'");
 }
 
 if (objDataFieldTypeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conDataFieldType.UpdUser);
 objDataFieldTypeEN.UpdUser = objDataFieldTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataFieldTypeEN.UpdUser + "'");
 }
 
 if (objDataFieldTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDataFieldType.Memo);
 objDataFieldTypeEN.Memo = objDataFieldTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataFieldTypeEN.Memo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DataFieldType");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objDataFieldTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsDataFieldTypeEN objDataFieldTypeEN)
{
 objDataFieldTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDataFieldTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDataFieldTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objDataFieldTypeEN.DataFieldTypeId !=  null)
 {
 arrFieldListForInsert.Add(conDataFieldType.DataFieldTypeId);
 objDataFieldTypeEN.DataFieldTypeId = objDataFieldTypeEN.DataFieldTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataFieldTypeEN.DataFieldTypeId + "'");
 }
 
 if (objDataFieldTypeEN.DataFieldTypeName !=  null)
 {
 arrFieldListForInsert.Add(conDataFieldType.DataFieldTypeName);
 objDataFieldTypeEN.DataFieldTypeName = objDataFieldTypeEN.DataFieldTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataFieldTypeEN.DataFieldTypeName + "'");
 }
 
 if (objDataFieldTypeEN.DataFieldTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conDataFieldType.DataFieldTypeENName);
 objDataFieldTypeEN.DataFieldTypeENName = objDataFieldTypeEN.DataFieldTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataFieldTypeEN.DataFieldTypeENName + "'");
 }
 
 if (objDataFieldTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conDataFieldType.UpdDate);
 objDataFieldTypeEN.UpdDate = objDataFieldTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataFieldTypeEN.UpdDate + "'");
 }
 
 if (objDataFieldTypeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conDataFieldType.UpdUser);
 objDataFieldTypeEN.UpdUser = objDataFieldTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataFieldTypeEN.UpdUser + "'");
 }
 
 if (objDataFieldTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDataFieldType.Memo);
 objDataFieldTypeEN.Memo = objDataFieldTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataFieldTypeEN.Memo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DataFieldType");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objDataFieldTypeEN.DataFieldTypeId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objDataFieldTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsDataFieldTypeEN objDataFieldTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objDataFieldTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDataFieldTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDataFieldTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objDataFieldTypeEN.DataFieldTypeId !=  null)
 {
 arrFieldListForInsert.Add(conDataFieldType.DataFieldTypeId);
 objDataFieldTypeEN.DataFieldTypeId = objDataFieldTypeEN.DataFieldTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataFieldTypeEN.DataFieldTypeId + "'");
 }
 
 if (objDataFieldTypeEN.DataFieldTypeName !=  null)
 {
 arrFieldListForInsert.Add(conDataFieldType.DataFieldTypeName);
 objDataFieldTypeEN.DataFieldTypeName = objDataFieldTypeEN.DataFieldTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataFieldTypeEN.DataFieldTypeName + "'");
 }
 
 if (objDataFieldTypeEN.DataFieldTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conDataFieldType.DataFieldTypeENName);
 objDataFieldTypeEN.DataFieldTypeENName = objDataFieldTypeEN.DataFieldTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataFieldTypeEN.DataFieldTypeENName + "'");
 }
 
 if (objDataFieldTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conDataFieldType.UpdDate);
 objDataFieldTypeEN.UpdDate = objDataFieldTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataFieldTypeEN.UpdDate + "'");
 }
 
 if (objDataFieldTypeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conDataFieldType.UpdUser);
 objDataFieldTypeEN.UpdUser = objDataFieldTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataFieldTypeEN.UpdUser + "'");
 }
 
 if (objDataFieldTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDataFieldType.Memo);
 objDataFieldTypeEN.Memo = objDataFieldTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataFieldTypeEN.Memo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DataFieldType");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objDataFieldTypeEN.DataFieldTypeId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objDataFieldTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsDataFieldTypeEN objDataFieldTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objDataFieldTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDataFieldTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDataFieldTypeEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objDataFieldTypeEN.DataFieldTypeId !=  null)
 {
 arrFieldListForInsert.Add(conDataFieldType.DataFieldTypeId);
 objDataFieldTypeEN.DataFieldTypeId = objDataFieldTypeEN.DataFieldTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataFieldTypeEN.DataFieldTypeId + "'");
 }
 
 if (objDataFieldTypeEN.DataFieldTypeName !=  null)
 {
 arrFieldListForInsert.Add(conDataFieldType.DataFieldTypeName);
 objDataFieldTypeEN.DataFieldTypeName = objDataFieldTypeEN.DataFieldTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataFieldTypeEN.DataFieldTypeName + "'");
 }
 
 if (objDataFieldTypeEN.DataFieldTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conDataFieldType.DataFieldTypeENName);
 objDataFieldTypeEN.DataFieldTypeENName = objDataFieldTypeEN.DataFieldTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataFieldTypeEN.DataFieldTypeENName + "'");
 }
 
 if (objDataFieldTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conDataFieldType.UpdDate);
 objDataFieldTypeEN.UpdDate = objDataFieldTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataFieldTypeEN.UpdDate + "'");
 }
 
 if (objDataFieldTypeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conDataFieldType.UpdUser);
 objDataFieldTypeEN.UpdUser = objDataFieldTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataFieldTypeEN.UpdUser + "'");
 }
 
 if (objDataFieldTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDataFieldType.Memo);
 objDataFieldTypeEN.Memo = objDataFieldTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataFieldTypeEN.Memo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DataFieldType");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:通过存储过程来插入记录
 /// (AutoGCLib.DALCode4CSharp:GenAddnewRecBySP)
 /// </summary>
 /// <param name = "objDataFieldTypeEN">需要添加到数据库中的对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddnewDataFieldTypeBySP(clsDataFieldTypeEN objDataFieldTypeEN)
{
//通过存储过程来
//直接使用
 objDataFieldTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objDataFieldTypeEN.DataFieldTypeId,
 objDataFieldTypeEN.DataFieldTypeName,
 objDataFieldTypeEN.DataFieldTypeENName,
 objDataFieldTypeEN.UpdDate,
 objDataFieldTypeEN.UpdUser,
objDataFieldTypeEN.Memo
};
 objSQL.ExecSP("DataFieldType_Add",values);
return true;
}

 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewDataFieldTypes(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
strSQL = "Select * from DataFieldType where DataFieldTypeId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "DataFieldType");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strDataFieldTypeId = oRow[conDataFieldType.DataFieldTypeId].ToString().Trim();
if (IsExist(strDataFieldTypeId))
{
 string strResult = "关键字变量值为:" + string.Format("DataFieldTypeId = {0}", strDataFieldTypeId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsDataFieldTypeEN._CurrTabName ].NewRow();
objRow[conDataFieldType.DataFieldTypeId] = oRow[conDataFieldType.DataFieldTypeId].ToString().Trim(); //数据字段类型Id
objRow[conDataFieldType.DataFieldTypeName] = oRow[conDataFieldType.DataFieldTypeName].ToString().Trim(); //数据字段类型名
objRow[conDataFieldType.DataFieldTypeENName] = oRow[conDataFieldType.DataFieldTypeENName].ToString().Trim(); //数据字段类型英文名
objRow[conDataFieldType.UpdDate] = oRow[conDataFieldType.UpdDate].ToString().Trim(); //修改日期
objRow[conDataFieldType.UpdUser] = oRow[conDataFieldType.UpdUser].ToString().Trim(); //修改者
objRow[conDataFieldType.Memo] = oRow[conDataFieldType.Memo].ToString().Trim(); //说明
 objDS.Tables[clsDataFieldTypeEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsDataFieldTypeEN._CurrTabName);
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
 /// <param name = "objDataFieldTypeEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsDataFieldTypeEN objDataFieldTypeEN)
{
 objDataFieldTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDataFieldTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDataFieldTypeEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
strSQL = "Select * from DataFieldType where DataFieldTypeId = " + "'"+ objDataFieldTypeEN.DataFieldTypeId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsDataFieldTypeEN._CurrTabName);
if (objDS.Tables[clsDataFieldTypeEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:DataFieldTypeId = " + "'"+ objDataFieldTypeEN.DataFieldTypeId+"'");
return false;
}
objRow = objDS.Tables[clsDataFieldTypeEN._CurrTabName].Rows[0];
 if (objDataFieldTypeEN.IsUpdated(conDataFieldType.DataFieldTypeId))
 {
objRow[conDataFieldType.DataFieldTypeId] = objDataFieldTypeEN.DataFieldTypeId; //数据字段类型Id
 }
 if (objDataFieldTypeEN.IsUpdated(conDataFieldType.DataFieldTypeName))
 {
objRow[conDataFieldType.DataFieldTypeName] = objDataFieldTypeEN.DataFieldTypeName; //数据字段类型名
 }
 if (objDataFieldTypeEN.IsUpdated(conDataFieldType.DataFieldTypeENName))
 {
objRow[conDataFieldType.DataFieldTypeENName] = objDataFieldTypeEN.DataFieldTypeENName; //数据字段类型英文名
 }
 if (objDataFieldTypeEN.IsUpdated(conDataFieldType.UpdDate))
 {
objRow[conDataFieldType.UpdDate] = objDataFieldTypeEN.UpdDate; //修改日期
 }
 if (objDataFieldTypeEN.IsUpdated(conDataFieldType.UpdUser))
 {
objRow[conDataFieldType.UpdUser] = objDataFieldTypeEN.UpdUser; //修改者
 }
 if (objDataFieldTypeEN.IsUpdated(conDataFieldType.Memo))
 {
objRow[conDataFieldType.Memo] = objDataFieldTypeEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsDataFieldTypeEN._CurrTabName);
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
public bool UpdateBySP(clsDataFieldTypeEN objDataFieldTypeEN)
{
 objDataFieldTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDataFieldTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDataFieldTypeEN);
 }
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objDataFieldTypeEN.DataFieldTypeId,
 objDataFieldTypeEN.DataFieldTypeName,
 objDataFieldTypeEN.DataFieldTypeENName,
 objDataFieldTypeEN.UpdDate,
 objDataFieldTypeEN.UpdUser,
 objDataFieldTypeEN.Memo
};
 objSQL.ExecSP("DataFieldType_Update",values);
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySql2)
 /// </summary>
 /// <param name = "objDataFieldTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsDataFieldTypeEN objDataFieldTypeEN)
{
 objDataFieldTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDataFieldTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDataFieldTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update DataFieldType Set ");
 
 if (objDataFieldTypeEN.IsUpdated(conDataFieldType.DataFieldTypeName))
 {
 if (objDataFieldTypeEN.DataFieldTypeName !=  null)
 {
 objDataFieldTypeEN.DataFieldTypeName = objDataFieldTypeEN.DataFieldTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataFieldTypeEN.DataFieldTypeName, conDataFieldType.DataFieldTypeName); //数据字段类型名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataFieldType.DataFieldTypeName); //数据字段类型名
 }
 }
 
 if (objDataFieldTypeEN.IsUpdated(conDataFieldType.DataFieldTypeENName))
 {
 if (objDataFieldTypeEN.DataFieldTypeENName !=  null)
 {
 objDataFieldTypeEN.DataFieldTypeENName = objDataFieldTypeEN.DataFieldTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataFieldTypeEN.DataFieldTypeENName, conDataFieldType.DataFieldTypeENName); //数据字段类型英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataFieldType.DataFieldTypeENName); //数据字段类型英文名
 }
 }
 
 if (objDataFieldTypeEN.IsUpdated(conDataFieldType.UpdDate))
 {
 if (objDataFieldTypeEN.UpdDate !=  null)
 {
 objDataFieldTypeEN.UpdDate = objDataFieldTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataFieldTypeEN.UpdDate, conDataFieldType.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataFieldType.UpdDate); //修改日期
 }
 }
 
 if (objDataFieldTypeEN.IsUpdated(conDataFieldType.UpdUser))
 {
 if (objDataFieldTypeEN.UpdUser !=  null)
 {
 objDataFieldTypeEN.UpdUser = objDataFieldTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataFieldTypeEN.UpdUser, conDataFieldType.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataFieldType.UpdUser); //修改者
 }
 }
 
 if (objDataFieldTypeEN.IsUpdated(conDataFieldType.Memo))
 {
 if (objDataFieldTypeEN.Memo !=  null)
 {
 objDataFieldTypeEN.Memo = objDataFieldTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataFieldTypeEN.Memo, conDataFieldType.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataFieldType.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where DataFieldTypeId = '{0}'", objDataFieldTypeEN.DataFieldTypeId); 
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
 /// <param name = "objDataFieldTypeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsDataFieldTypeEN objDataFieldTypeEN, string strCondition)
{
 objDataFieldTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDataFieldTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDataFieldTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update DataFieldType Set ");
 
 if (objDataFieldTypeEN.IsUpdated(conDataFieldType.DataFieldTypeName))
 {
 if (objDataFieldTypeEN.DataFieldTypeName !=  null)
 {
 objDataFieldTypeEN.DataFieldTypeName = objDataFieldTypeEN.DataFieldTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataFieldTypeName = '{0}',", objDataFieldTypeEN.DataFieldTypeName); //数据字段类型名
 }
 else
 {
 sbSQL.Append(" DataFieldTypeName = null,"); //数据字段类型名
 }
 }
 
 if (objDataFieldTypeEN.IsUpdated(conDataFieldType.DataFieldTypeENName))
 {
 if (objDataFieldTypeEN.DataFieldTypeENName !=  null)
 {
 objDataFieldTypeEN.DataFieldTypeENName = objDataFieldTypeEN.DataFieldTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataFieldTypeENName = '{0}',", objDataFieldTypeEN.DataFieldTypeENName); //数据字段类型英文名
 }
 else
 {
 sbSQL.Append(" DataFieldTypeENName = null,"); //数据字段类型英文名
 }
 }
 
 if (objDataFieldTypeEN.IsUpdated(conDataFieldType.UpdDate))
 {
 if (objDataFieldTypeEN.UpdDate !=  null)
 {
 objDataFieldTypeEN.UpdDate = objDataFieldTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", objDataFieldTypeEN.UpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objDataFieldTypeEN.IsUpdated(conDataFieldType.UpdUser))
 {
 if (objDataFieldTypeEN.UpdUser !=  null)
 {
 objDataFieldTypeEN.UpdUser = objDataFieldTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", objDataFieldTypeEN.UpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objDataFieldTypeEN.IsUpdated(conDataFieldType.Memo))
 {
 if (objDataFieldTypeEN.Memo !=  null)
 {
 objDataFieldTypeEN.Memo = objDataFieldTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", objDataFieldTypeEN.Memo); //说明
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
 /// <param name = "objDataFieldTypeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsDataFieldTypeEN objDataFieldTypeEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objDataFieldTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDataFieldTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDataFieldTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update DataFieldType Set ");
 
 if (objDataFieldTypeEN.IsUpdated(conDataFieldType.DataFieldTypeName))
 {
 if (objDataFieldTypeEN.DataFieldTypeName !=  null)
 {
 objDataFieldTypeEN.DataFieldTypeName = objDataFieldTypeEN.DataFieldTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataFieldTypeName = '{0}',", objDataFieldTypeEN.DataFieldTypeName); //数据字段类型名
 }
 else
 {
 sbSQL.Append(" DataFieldTypeName = null,"); //数据字段类型名
 }
 }
 
 if (objDataFieldTypeEN.IsUpdated(conDataFieldType.DataFieldTypeENName))
 {
 if (objDataFieldTypeEN.DataFieldTypeENName !=  null)
 {
 objDataFieldTypeEN.DataFieldTypeENName = objDataFieldTypeEN.DataFieldTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataFieldTypeENName = '{0}',", objDataFieldTypeEN.DataFieldTypeENName); //数据字段类型英文名
 }
 else
 {
 sbSQL.Append(" DataFieldTypeENName = null,"); //数据字段类型英文名
 }
 }
 
 if (objDataFieldTypeEN.IsUpdated(conDataFieldType.UpdDate))
 {
 if (objDataFieldTypeEN.UpdDate !=  null)
 {
 objDataFieldTypeEN.UpdDate = objDataFieldTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", objDataFieldTypeEN.UpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objDataFieldTypeEN.IsUpdated(conDataFieldType.UpdUser))
 {
 if (objDataFieldTypeEN.UpdUser !=  null)
 {
 objDataFieldTypeEN.UpdUser = objDataFieldTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", objDataFieldTypeEN.UpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objDataFieldTypeEN.IsUpdated(conDataFieldType.Memo))
 {
 if (objDataFieldTypeEN.Memo !=  null)
 {
 objDataFieldTypeEN.Memo = objDataFieldTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", objDataFieldTypeEN.Memo); //说明
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
 /// <param name = "objDataFieldTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsDataFieldTypeEN objDataFieldTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objDataFieldTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDataFieldTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDataFieldTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update DataFieldType Set ");
 
 if (objDataFieldTypeEN.IsUpdated(conDataFieldType.DataFieldTypeName))
 {
 if (objDataFieldTypeEN.DataFieldTypeName !=  null)
 {
 objDataFieldTypeEN.DataFieldTypeName = objDataFieldTypeEN.DataFieldTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataFieldTypeEN.DataFieldTypeName, conDataFieldType.DataFieldTypeName); //数据字段类型名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataFieldType.DataFieldTypeName); //数据字段类型名
 }
 }
 
 if (objDataFieldTypeEN.IsUpdated(conDataFieldType.DataFieldTypeENName))
 {
 if (objDataFieldTypeEN.DataFieldTypeENName !=  null)
 {
 objDataFieldTypeEN.DataFieldTypeENName = objDataFieldTypeEN.DataFieldTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataFieldTypeEN.DataFieldTypeENName, conDataFieldType.DataFieldTypeENName); //数据字段类型英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataFieldType.DataFieldTypeENName); //数据字段类型英文名
 }
 }
 
 if (objDataFieldTypeEN.IsUpdated(conDataFieldType.UpdDate))
 {
 if (objDataFieldTypeEN.UpdDate !=  null)
 {
 objDataFieldTypeEN.UpdDate = objDataFieldTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataFieldTypeEN.UpdDate, conDataFieldType.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataFieldType.UpdDate); //修改日期
 }
 }
 
 if (objDataFieldTypeEN.IsUpdated(conDataFieldType.UpdUser))
 {
 if (objDataFieldTypeEN.UpdUser !=  null)
 {
 objDataFieldTypeEN.UpdUser = objDataFieldTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataFieldTypeEN.UpdUser, conDataFieldType.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataFieldType.UpdUser); //修改者
 }
 }
 
 if (objDataFieldTypeEN.IsUpdated(conDataFieldType.Memo))
 {
 if (objDataFieldTypeEN.Memo !=  null)
 {
 objDataFieldTypeEN.Memo = objDataFieldTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataFieldTypeEN.Memo, conDataFieldType.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataFieldType.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where DataFieldTypeId = '{0}'", objDataFieldTypeEN.DataFieldTypeId); 
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
 /// <param name = "strDataFieldTypeId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strDataFieldTypeId) 
{
CheckPrimaryKey(strDataFieldTypeId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strDataFieldTypeId,
};
 objSQL.ExecSP("DataFieldType_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strDataFieldTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strDataFieldTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strDataFieldTypeId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
//删除DataFieldType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from DataFieldType where DataFieldTypeId = " + "'"+ strDataFieldTypeId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelDataFieldType(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
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
//删除DataFieldType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from DataFieldType where DataFieldTypeId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strDataFieldTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strDataFieldTypeId) 
{
CheckPrimaryKey(strDataFieldTypeId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
//删除DataFieldType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from DataFieldType where DataFieldTypeId = " + "'"+ strDataFieldTypeId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelDataFieldType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsDataFieldTypeDA: DelDataFieldType)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from DataFieldType where " + strCondition ;
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
public bool DelDataFieldTypeWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsDataFieldTypeDA: DelDataFieldTypeWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from DataFieldType where " + strCondition ;
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
 /// <param name = "objDataFieldTypeENS">源对象</param>
 /// <param name = "objDataFieldTypeENT">目标对象</param>
public void CopyTo(clsDataFieldTypeEN objDataFieldTypeENS, clsDataFieldTypeEN objDataFieldTypeENT)
{
objDataFieldTypeENT.DataFieldTypeId = objDataFieldTypeENS.DataFieldTypeId; //数据字段类型Id
objDataFieldTypeENT.DataFieldTypeName = objDataFieldTypeENS.DataFieldTypeName; //数据字段类型名
objDataFieldTypeENT.DataFieldTypeENName = objDataFieldTypeENS.DataFieldTypeENName; //数据字段类型英文名
objDataFieldTypeENT.UpdDate = objDataFieldTypeENS.UpdDate; //修改日期
objDataFieldTypeENT.UpdUser = objDataFieldTypeENS.UpdUser; //修改者
objDataFieldTypeENT.Memo = objDataFieldTypeENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsDataFieldTypeEN objDataFieldTypeEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objDataFieldTypeEN.DataFieldTypeName, conDataFieldType.DataFieldTypeName);
//检查字段长度
clsCheckSql.CheckFieldLen(objDataFieldTypeEN.DataFieldTypeId, 2, conDataFieldType.DataFieldTypeId);
clsCheckSql.CheckFieldLen(objDataFieldTypeEN.DataFieldTypeName, 30, conDataFieldType.DataFieldTypeName);
clsCheckSql.CheckFieldLen(objDataFieldTypeEN.DataFieldTypeENName, 30, conDataFieldType.DataFieldTypeENName);
clsCheckSql.CheckFieldLen(objDataFieldTypeEN.UpdDate, 20, conDataFieldType.UpdDate);
clsCheckSql.CheckFieldLen(objDataFieldTypeEN.UpdUser, 20, conDataFieldType.UpdUser);
clsCheckSql.CheckFieldLen(objDataFieldTypeEN.Memo, 1000, conDataFieldType.Memo);
//检查字段外键固定长度
 objDataFieldTypeEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsDataFieldTypeEN objDataFieldTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objDataFieldTypeEN.DataFieldTypeName, 30, conDataFieldType.DataFieldTypeName);
clsCheckSql.CheckFieldLen(objDataFieldTypeEN.DataFieldTypeENName, 30, conDataFieldType.DataFieldTypeENName);
clsCheckSql.CheckFieldLen(objDataFieldTypeEN.UpdDate, 20, conDataFieldType.UpdDate);
clsCheckSql.CheckFieldLen(objDataFieldTypeEN.UpdUser, 20, conDataFieldType.UpdUser);
clsCheckSql.CheckFieldLen(objDataFieldTypeEN.Memo, 1000, conDataFieldType.Memo);
//检查外键字段长度
 objDataFieldTypeEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsDataFieldTypeEN objDataFieldTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objDataFieldTypeEN.DataFieldTypeId, 2, conDataFieldType.DataFieldTypeId);
clsCheckSql.CheckFieldLen(objDataFieldTypeEN.DataFieldTypeName, 30, conDataFieldType.DataFieldTypeName);
clsCheckSql.CheckFieldLen(objDataFieldTypeEN.DataFieldTypeENName, 30, conDataFieldType.DataFieldTypeENName);
clsCheckSql.CheckFieldLen(objDataFieldTypeEN.UpdDate, 20, conDataFieldType.UpdDate);
clsCheckSql.CheckFieldLen(objDataFieldTypeEN.UpdUser, 20, conDataFieldType.UpdUser);
clsCheckSql.CheckFieldLen(objDataFieldTypeEN.Memo, 1000, conDataFieldType.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objDataFieldTypeEN.DataFieldTypeId, conDataFieldType.DataFieldTypeId);
clsCheckSql.CheckSqlInjection4Field(objDataFieldTypeEN.DataFieldTypeName, conDataFieldType.DataFieldTypeName);
clsCheckSql.CheckSqlInjection4Field(objDataFieldTypeEN.DataFieldTypeENName, conDataFieldType.DataFieldTypeENName);
clsCheckSql.CheckSqlInjection4Field(objDataFieldTypeEN.UpdDate, conDataFieldType.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objDataFieldTypeEN.UpdUser, conDataFieldType.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objDataFieldTypeEN.Memo, conDataFieldType.Memo);
//检查外键字段长度
 objDataFieldTypeEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetDataFieldTypeId()
{
//获取某学院所有专业信息
string strSQL = "select DataFieldTypeId, DataFieldTypeName from DataFieldType ";
 clsSpecSQLforSql mySql = clsDataFieldTypeDA.GetSpecSQLObj();
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
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
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
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
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
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsDataFieldTypeEN._CurrTabName);
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
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsDataFieldTypeEN._CurrTabName, strCondition);
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
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
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
 objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}