
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSV_RelaTabTypeDA
 表名:SV_RelaTabType(00050248)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:16:16
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:Sql视图管理(SqlViewMan)
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
 /// Sql视图相关表类型(SV_RelaTabType)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class clsSV_RelaTabTypeDA : clsCommBase4DA
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
 return clsSV_RelaTabTypeEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsSV_RelaTabTypeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsSV_RelaTabTypeEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsSV_RelaTabTypeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsSV_RelaTabTypeEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strSvRelaTabTypeId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strSvRelaTabTypeId)
{
strSvRelaTabTypeId = strSvRelaTabTypeId.Replace("'", "''");
if (strSvRelaTabTypeId.Length > 2)
{
throw new Exception("(errid:Data000001)在表:SV_RelaTabType中,检查关键字,长度不正确!(clsSV_RelaTabTypeDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strSvRelaTabTypeId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:SV_RelaTabType中,关键字不能为空 或 null!(clsSV_RelaTabTypeDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strSvRelaTabTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsSV_RelaTabTypeDA:CheckPrimaryKey)", objException.Message));
}
return true;
}

 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey_Sim)
 /// </summary>
 /// <param name = "strSvRelaTabTypeId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey_Sim(string strSvRelaTabTypeId)
{
strSvRelaTabTypeId = strSvRelaTabTypeId.Replace("'", "''");
if (strSvRelaTabTypeId.Length > 2 + 4)
{
throw new Exception("(errid:Data000004)在表:SV_RelaTabType中,检查关键字,长度不正确!(简化版)(clsSV_RelaTabTypeDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strSvRelaTabTypeId)  ==  true)
{
throw new Exception("(errid:Data000005)在表:SV_RelaTabType中,关键字不能为空 或 null!(clsSV_RelaTabTypeDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strSvRelaTabTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000006)在关键字中含有{0},非法,请检查!(clsSV_RelaTabTypeDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsSV_RelaTabTypeDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
 strSQL = "Select * from SV_RelaTabType where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "SV_RelaTabType");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsSV_RelaTabTypeDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("SV_RelaTabType_SelectByCond",values, "SV_RelaTabType");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsSV_RelaTabTypeDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from SV_RelaTabType where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "SV_RelaTabType");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsSV_RelaTabTypeDA: GetSV_RelaTabTypeByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsSV_RelaTabTypeDA: GetSV_RelaTabTypeByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsSV_RelaTabTypeDA: GetSV_RelaTabTypeByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsSV_RelaTabTypeDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from SV_RelaTabType a where {0} And a.SvRelaTabTypeId not in (Select Top {2} SvRelaTabTypeId From SV_RelaTabType Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "SV_RelaTabType");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsSV_RelaTabTypeDA: GetSV_RelaTabTypeByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsSV_RelaTabTypeDA: GetSV_RelaTabTypeByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsSV_RelaTabTypeDA: GetSV_RelaTabTypeByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsSV_RelaTabTypeDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from SV_RelaTabType a where {0} And a.SvRelaTabTypeId not in (Select Top {2} SvRelaTabTypeId From SV_RelaTabType Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "SV_RelaTabType");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsSV_RelaTabTypeDA: GetSV_RelaTabTypeByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsSV_RelaTabTypeDA: GetSV_RelaTabTypeByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsSV_RelaTabTypeDA: GetSV_RelaTabTypeByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsSV_RelaTabTypeDA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsSV_RelaTabTypeDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from SV_RelaTabType a where {0} And a.SvRelaTabTypeId not in (Select Top {2} SvRelaTabTypeId From SV_RelaTabType Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "SV_RelaTabType");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsSV_RelaTabTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
strSQL = "Select * from SV_RelaTabType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_SV_RelaTabType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsSV_RelaTabTypeDA: GetDataTable_SV_RelaTabType)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
strSQL = "Select * from SV_RelaTabType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsSV_RelaTabTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsSV_RelaTabTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
strSQL = "Select * from SV_RelaTabType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsSV_RelaTabTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsSV_RelaTabTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
strSQL = "Select * from SV_RelaTabType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsSV_RelaTabTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsSV_RelaTabTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SV_RelaTabType where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SV_RelaTabType where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsSV_RelaTabTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from SV_RelaTabType where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsSV_RelaTabTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from SV_RelaTabType where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsSV_RelaTabTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} SV_RelaTabType.* from SV_RelaTabType Left Join {1} on {2} where {3} and SV_RelaTabType.SvRelaTabTypeId not in (Select top {5} SV_RelaTabType.SvRelaTabTypeId from SV_RelaTabType Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SV_RelaTabType where {1} and SvRelaTabTypeId not in (Select top {2} SvRelaTabTypeId from SV_RelaTabType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SV_RelaTabType where {1} and SvRelaTabTypeId not in (Select top {3} SvRelaTabTypeId from SV_RelaTabType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsSV_RelaTabTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} SV_RelaTabType.* from SV_RelaTabType Left Join {1} on {2} where {3} and SV_RelaTabType.SvRelaTabTypeId not in (Select top {5} SV_RelaTabType.SvRelaTabTypeId from SV_RelaTabType Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SV_RelaTabType where {1} and SvRelaTabTypeId not in (Select top {2} SvRelaTabTypeId from SV_RelaTabType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SV_RelaTabType where {1} and SvRelaTabTypeId not in (Select top {3} SvRelaTabTypeId from SV_RelaTabType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsSV_RelaTabTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} SV_RelaTabType.* from SV_RelaTabType Left Join {1} on {2} where {3} and SV_RelaTabType.SvRelaTabTypeId not in (Select top {5} SV_RelaTabType.SvRelaTabTypeId from SV_RelaTabType Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SV_RelaTabType where {1} and SvRelaTabTypeId not in (Select top {2} SvRelaTabTypeId from SV_RelaTabType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SV_RelaTabType where {1} and SvRelaTabTypeId not in (Select top {3} SvRelaTabTypeId from SV_RelaTabType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsSV_RelaTabTypeDA: GetSV_RelaTabTypeByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsSV_RelaTabTypeDA: GetSV_RelaTabTypeByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsSV_RelaTabTypeDA: GetSV_RelaTabTypeByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsSV_RelaTabTypeDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from SV_RelaTabType a where {0} And a.SvRelaTabTypeId not in (Select Top {2} SvRelaTabTypeId From SV_RelaTabType Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from SV_RelaTabType a where {0} And a.SvRelaTabTypeId not in (Select Top {2} SvRelaTabTypeId From SV_RelaTabType Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsSV_RelaTabTypeDA: GetSV_RelaTabTypeByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsSV_RelaTabTypeDA: GetSV_RelaTabTypeByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsSV_RelaTabTypeDA: GetSV_RelaTabTypeByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsSV_RelaTabTypeDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from SV_RelaTabType a where {0} And a.SvRelaTabTypeId not in (Select Top {2} SvRelaTabTypeId From SV_RelaTabType Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from SV_RelaTabType a where {0} And a.SvRelaTabTypeId not in (Select Top {2} SvRelaTabTypeId From SV_RelaTabType Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsSV_RelaTabTypeDA: GetSV_RelaTabTypeByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsSV_RelaTabTypeDA: GetSV_RelaTabTypeByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsSV_RelaTabTypeDA: GetSV_RelaTabTypeByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsSV_RelaTabTypeDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
strSQL = "Select * from SV_RelaTabType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsSV_RelaTabTypeDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("SV_RelaTabType_SelectByCond",values);
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
public List<clsSV_RelaTabTypeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsSV_RelaTabTypeDA:GetObjLst)", objException.Message));
}
List<clsSV_RelaTabTypeEN> arrObjLst = new List<clsSV_RelaTabTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
strSQL = "Select * from SV_RelaTabType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSV_RelaTabTypeEN objSV_RelaTabTypeEN = new clsSV_RelaTabTypeEN();
try
{
objSV_RelaTabTypeEN.SvRelaTabTypeId = objRow[conSV_RelaTabType.SvRelaTabTypeId].ToString().Trim(); //Sql视图相关表类型Id
objSV_RelaTabTypeEN.SvRelaTabTypeName = objRow[conSV_RelaTabType.SvRelaTabTypeName].ToString().Trim(); //Sql视图相关表类型名
objSV_RelaTabTypeEN.Memo = objRow[conSV_RelaTabType.Memo] == DBNull.Value ? null : objRow[conSV_RelaTabType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsSV_RelaTabTypeDA: GetObjLst)", objException.Message));
}
objSV_RelaTabTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objSV_RelaTabTypeEN);
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
public List<clsSV_RelaTabTypeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsSV_RelaTabTypeDA:GetObjLstByTabName)", objException.Message));
}
List<clsSV_RelaTabTypeEN> arrObjLst = new List<clsSV_RelaTabTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSV_RelaTabTypeEN objSV_RelaTabTypeEN = new clsSV_RelaTabTypeEN();
try
{
objSV_RelaTabTypeEN.SvRelaTabTypeId = objRow[conSV_RelaTabType.SvRelaTabTypeId].ToString().Trim(); //Sql视图相关表类型Id
objSV_RelaTabTypeEN.SvRelaTabTypeName = objRow[conSV_RelaTabType.SvRelaTabTypeName].ToString().Trim(); //Sql视图相关表类型名
objSV_RelaTabTypeEN.Memo = objRow[conSV_RelaTabType.Memo] == DBNull.Value ? null : objRow[conSV_RelaTabType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsSV_RelaTabTypeDA: GetObjLst)", objException.Message));
}
objSV_RelaTabTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objSV_RelaTabTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsSV_RelaTabTypeEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsSV_RelaTabTypeDA:GetObjLstBySP)", objException.Message));
}
List<clsSV_RelaTabTypeEN> arrObjLst = new List<clsSV_RelaTabTypeEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("SV_RelaTabType_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSV_RelaTabTypeEN objSV_RelaTabTypeEN = new clsSV_RelaTabTypeEN();
try
{
objSV_RelaTabTypeEN.SvRelaTabTypeId = objRow[conSV_RelaTabType.SvRelaTabTypeId].ToString().Trim(); //Sql视图相关表类型Id
objSV_RelaTabTypeEN.SvRelaTabTypeName = objRow[conSV_RelaTabType.SvRelaTabTypeName].ToString().Trim(); //Sql视图相关表类型名
objSV_RelaTabTypeEN.Memo = objRow[conSV_RelaTabType.Memo] == DBNull.Value ? null : objRow[conSV_RelaTabType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsSV_RelaTabTypeDA: GetObjLstBySP)", objException.Message));
}
objSV_RelaTabTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objSV_RelaTabTypeEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objSV_RelaTabTypeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetSV_RelaTabType(ref clsSV_RelaTabTypeEN objSV_RelaTabTypeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
strSQL = "Select * from SV_RelaTabType where SvRelaTabTypeId = " + "'"+ objSV_RelaTabTypeEN.SvRelaTabTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objSV_RelaTabTypeEN.SvRelaTabTypeId = objDT.Rows[0][conSV_RelaTabType.SvRelaTabTypeId].ToString().Trim(); //Sql视图相关表类型Id(字段类型:char,字段长度:2,是否可空:False)
 objSV_RelaTabTypeEN.SvRelaTabTypeName = objDT.Rows[0][conSV_RelaTabType.SvRelaTabTypeName].ToString().Trim(); //Sql视图相关表类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objSV_RelaTabTypeEN.Memo = objDT.Rows[0][conSV_RelaTabType.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsSV_RelaTabTypeDA: GetSV_RelaTabType)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strSvRelaTabTypeId">表关键字</param>
 /// <returns>表对象</returns>
public clsSV_RelaTabTypeEN GetObjBySvRelaTabTypeId(string strSvRelaTabTypeId)
{
CheckPrimaryKey(strSvRelaTabTypeId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
strSQL = "Select * from SV_RelaTabType where SvRelaTabTypeId = " + "'"+ strSvRelaTabTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsSV_RelaTabTypeEN objSV_RelaTabTypeEN = new clsSV_RelaTabTypeEN();
try
{
 objSV_RelaTabTypeEN.SvRelaTabTypeId = objRow[conSV_RelaTabType.SvRelaTabTypeId].ToString().Trim(); //Sql视图相关表类型Id(字段类型:char,字段长度:2,是否可空:False)
 objSV_RelaTabTypeEN.SvRelaTabTypeName = objRow[conSV_RelaTabType.SvRelaTabTypeName].ToString().Trim(); //Sql视图相关表类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objSV_RelaTabTypeEN.Memo = objRow[conSV_RelaTabType.Memo] == DBNull.Value ? null : objRow[conSV_RelaTabType.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsSV_RelaTabTypeDA: GetObjBySvRelaTabTypeId)", objException.Message));
}
return objSV_RelaTabTypeEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程SV_RelaTabType_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objSV_RelaTabTypeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetSV_RelaTabTypeOneBySP(clsSV_RelaTabTypeEN objSV_RelaTabTypeEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objSV_RelaTabTypeEN.SvRelaTabTypeId
};
 objDT = objSQL.ExecSpReturnDT("SV_RelaTabType_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objSV_RelaTabTypeEN.SvRelaTabTypeId = objDT.Rows[0][conSV_RelaTabType.SvRelaTabTypeId].ToString().Trim(); //Sql视图相关表类型Id(字段类型:char,字段长度:2,是否可空:False)
 objSV_RelaTabTypeEN.SvRelaTabTypeName = objDT.Rows[0][conSV_RelaTabType.SvRelaTabTypeName].ToString().Trim(); //Sql视图相关表类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objSV_RelaTabTypeEN.Memo = objDT.Rows[0][conSV_RelaTabType.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsSV_RelaTabTypeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsSV_RelaTabTypeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
strSQL = "Select * from SV_RelaTabType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsSV_RelaTabTypeEN objSV_RelaTabTypeEN = new clsSV_RelaTabTypeEN()
{
SvRelaTabTypeId = objRow[conSV_RelaTabType.SvRelaTabTypeId].ToString().Trim(), //Sql视图相关表类型Id
SvRelaTabTypeName = objRow[conSV_RelaTabType.SvRelaTabTypeName].ToString().Trim(), //Sql视图相关表类型名
Memo = objRow[conSV_RelaTabType.Memo] == DBNull.Value ? null : objRow[conSV_RelaTabType.Memo].ToString().Trim() //说明
};
objSV_RelaTabTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSV_RelaTabTypeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsSV_RelaTabTypeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsSV_RelaTabTypeEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsSV_RelaTabTypeDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("SV_RelaTabType_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsSV_RelaTabTypeEN objSV_RelaTabTypeEN = new clsSV_RelaTabTypeEN()
{
SvRelaTabTypeId = objRow[conSV_RelaTabType.SvRelaTabTypeId].ToString().Trim(), //Sql视图相关表类型Id
SvRelaTabTypeName = objRow[conSV_RelaTabType.SvRelaTabTypeName].ToString().Trim(), //Sql视图相关表类型名
Memo = objRow[conSV_RelaTabType.Memo] == DBNull.Value ? null : objRow[conSV_RelaTabType.Memo].ToString().Trim() //说明
};
objSV_RelaTabTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSV_RelaTabTypeEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsSV_RelaTabTypeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsSV_RelaTabTypeEN objSV_RelaTabTypeEN = new clsSV_RelaTabTypeEN();
try
{
objSV_RelaTabTypeEN.SvRelaTabTypeId = objRow[conSV_RelaTabType.SvRelaTabTypeId].ToString().Trim(); //Sql视图相关表类型Id
objSV_RelaTabTypeEN.SvRelaTabTypeName = objRow[conSV_RelaTabType.SvRelaTabTypeName].ToString().Trim(); //Sql视图相关表类型名
objSV_RelaTabTypeEN.Memo = objRow[conSV_RelaTabType.Memo] == DBNull.Value ? null : objRow[conSV_RelaTabType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsSV_RelaTabTypeDA: GetObjByDataRowSV_RelaTabType)", objException.Message));
}
objSV_RelaTabTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSV_RelaTabTypeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsSV_RelaTabTypeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsSV_RelaTabTypeEN objSV_RelaTabTypeEN = new clsSV_RelaTabTypeEN();
try
{
objSV_RelaTabTypeEN.SvRelaTabTypeId = objRow[conSV_RelaTabType.SvRelaTabTypeId].ToString().Trim(); //Sql视图相关表类型Id
objSV_RelaTabTypeEN.SvRelaTabTypeName = objRow[conSV_RelaTabType.SvRelaTabTypeName].ToString().Trim(); //Sql视图相关表类型名
objSV_RelaTabTypeEN.Memo = objRow[conSV_RelaTabType.Memo] == DBNull.Value ? null : objRow[conSV_RelaTabType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsSV_RelaTabTypeDA: GetObjByDataRow)", objException.Message));
}
objSV_RelaTabTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSV_RelaTabTypeEN;
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
objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsSV_RelaTabTypeEN._CurrTabName, conSV_RelaTabType.SvRelaTabTypeId, 2, "");
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
objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsSV_RelaTabTypeEN._CurrTabName, conSV_RelaTabType.SvRelaTabTypeId, 2, strPrefix);
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
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select SvRelaTabTypeId from SV_RelaTabType where " + strCondition;
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
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select SvRelaTabTypeId from SV_RelaTabType where " + strCondition;
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
 /// <param name = "strSvRelaTabTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strSvRelaTabTypeId)
{
CheckPrimaryKey(strSvRelaTabTypeId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("SV_RelaTabType", "SvRelaTabTypeId = " + "'"+ strSvRelaTabTypeId+"'"))
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
 /// <param name = "strSvRelaTabTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExistBySP(string strSvRelaTabTypeId)
{
CheckPrimaryKey(strSvRelaTabTypeId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
strSvRelaTabTypeId,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("SV_RelaTabType_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsSV_RelaTabTypeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("SV_RelaTabType", strCondition))
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
objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("SV_RelaTabType");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsSV_RelaTabTypeEN objSV_RelaTabTypeEN)
 {
 if (objSV_RelaTabTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSV_RelaTabTypeEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
strSQL = "Select * from SV_RelaTabType where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "SV_RelaTabType");
objRow = objDS.Tables["SV_RelaTabType"].NewRow();
objRow[conSV_RelaTabType.SvRelaTabTypeId] = objSV_RelaTabTypeEN.SvRelaTabTypeId; //Sql视图相关表类型Id
objRow[conSV_RelaTabType.SvRelaTabTypeName] = objSV_RelaTabTypeEN.SvRelaTabTypeName; //Sql视图相关表类型名
 if (objSV_RelaTabTypeEN.Memo !=  "")
 {
objRow[conSV_RelaTabType.Memo] = objSV_RelaTabTypeEN.Memo; //说明
 }
objDS.Tables[clsSV_RelaTabTypeEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsSV_RelaTabTypeEN._CurrTabName);
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
 /// <param name = "objSV_RelaTabTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsSV_RelaTabTypeEN objSV_RelaTabTypeEN)
{
 if (objSV_RelaTabTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSV_RelaTabTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSV_RelaTabTypeEN.SvRelaTabTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSV_RelaTabType.SvRelaTabTypeId);
 objSV_RelaTabTypeEN.SvRelaTabTypeId = objSV_RelaTabTypeEN.SvRelaTabTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objSV_RelaTabTypeEN.SvRelaTabTypeId + "'");
 }
 
 if (objSV_RelaTabTypeEN.SvRelaTabTypeName !=  null)
 {
 arrFieldListForInsert.Add(conSV_RelaTabType.SvRelaTabTypeName);
 objSV_RelaTabTypeEN.SvRelaTabTypeName = objSV_RelaTabTypeEN.SvRelaTabTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objSV_RelaTabTypeEN.SvRelaTabTypeName + "'");
 }
 
 if (objSV_RelaTabTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSV_RelaTabType.Memo);
 objSV_RelaTabTypeEN.Memo = objSV_RelaTabTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objSV_RelaTabTypeEN.Memo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SV_RelaTabType");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objSV_RelaTabTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsSV_RelaTabTypeEN objSV_RelaTabTypeEN)
{
 if (objSV_RelaTabTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSV_RelaTabTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSV_RelaTabTypeEN.SvRelaTabTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSV_RelaTabType.SvRelaTabTypeId);
 objSV_RelaTabTypeEN.SvRelaTabTypeId = objSV_RelaTabTypeEN.SvRelaTabTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objSV_RelaTabTypeEN.SvRelaTabTypeId + "'");
 }
 
 if (objSV_RelaTabTypeEN.SvRelaTabTypeName !=  null)
 {
 arrFieldListForInsert.Add(conSV_RelaTabType.SvRelaTabTypeName);
 objSV_RelaTabTypeEN.SvRelaTabTypeName = objSV_RelaTabTypeEN.SvRelaTabTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objSV_RelaTabTypeEN.SvRelaTabTypeName + "'");
 }
 
 if (objSV_RelaTabTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSV_RelaTabType.Memo);
 objSV_RelaTabTypeEN.Memo = objSV_RelaTabTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objSV_RelaTabTypeEN.Memo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SV_RelaTabType");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objSV_RelaTabTypeEN.SvRelaTabTypeId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objSV_RelaTabTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsSV_RelaTabTypeEN objSV_RelaTabTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objSV_RelaTabTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSV_RelaTabTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSV_RelaTabTypeEN.SvRelaTabTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSV_RelaTabType.SvRelaTabTypeId);
 objSV_RelaTabTypeEN.SvRelaTabTypeId = objSV_RelaTabTypeEN.SvRelaTabTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objSV_RelaTabTypeEN.SvRelaTabTypeId + "'");
 }
 
 if (objSV_RelaTabTypeEN.SvRelaTabTypeName !=  null)
 {
 arrFieldListForInsert.Add(conSV_RelaTabType.SvRelaTabTypeName);
 objSV_RelaTabTypeEN.SvRelaTabTypeName = objSV_RelaTabTypeEN.SvRelaTabTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objSV_RelaTabTypeEN.SvRelaTabTypeName + "'");
 }
 
 if (objSV_RelaTabTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSV_RelaTabType.Memo);
 objSV_RelaTabTypeEN.Memo = objSV_RelaTabTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objSV_RelaTabTypeEN.Memo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SV_RelaTabType");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objSV_RelaTabTypeEN.SvRelaTabTypeId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objSV_RelaTabTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsSV_RelaTabTypeEN objSV_RelaTabTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objSV_RelaTabTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSV_RelaTabTypeEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSV_RelaTabTypeEN.SvRelaTabTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSV_RelaTabType.SvRelaTabTypeId);
 objSV_RelaTabTypeEN.SvRelaTabTypeId = objSV_RelaTabTypeEN.SvRelaTabTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objSV_RelaTabTypeEN.SvRelaTabTypeId + "'");
 }
 
 if (objSV_RelaTabTypeEN.SvRelaTabTypeName !=  null)
 {
 arrFieldListForInsert.Add(conSV_RelaTabType.SvRelaTabTypeName);
 objSV_RelaTabTypeEN.SvRelaTabTypeName = objSV_RelaTabTypeEN.SvRelaTabTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objSV_RelaTabTypeEN.SvRelaTabTypeName + "'");
 }
 
 if (objSV_RelaTabTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSV_RelaTabType.Memo);
 objSV_RelaTabTypeEN.Memo = objSV_RelaTabTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objSV_RelaTabTypeEN.Memo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SV_RelaTabType");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:通过存储过程来插入记录
 /// (AutoGCLib.DALCode4CSharp:GenAddnewRecBySP)
 /// </summary>
 /// <param name = "objSV_RelaTabTypeEN">需要添加到数据库中的对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddnewSV_RelaTabTypeBySP(clsSV_RelaTabTypeEN objSV_RelaTabTypeEN)
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objSV_RelaTabTypeEN.SvRelaTabTypeId,
 objSV_RelaTabTypeEN.SvRelaTabTypeName,
objSV_RelaTabTypeEN.Memo
};
 objSQL.ExecSP("SV_RelaTabType_Add",values);
return true;
}

 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewSV_RelaTabTypes(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
strSQL = "Select * from SV_RelaTabType where SvRelaTabTypeId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "SV_RelaTabType");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strSvRelaTabTypeId = oRow[conSV_RelaTabType.SvRelaTabTypeId].ToString().Trim();
if (IsExist(strSvRelaTabTypeId))
{
 string strResult = "关键字变量值为:" + string.Format("SvRelaTabTypeId = {0}", strSvRelaTabTypeId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsSV_RelaTabTypeEN._CurrTabName ].NewRow();
objRow[conSV_RelaTabType.SvRelaTabTypeId] = oRow[conSV_RelaTabType.SvRelaTabTypeId].ToString().Trim(); //Sql视图相关表类型Id
objRow[conSV_RelaTabType.SvRelaTabTypeName] = oRow[conSV_RelaTabType.SvRelaTabTypeName].ToString().Trim(); //Sql视图相关表类型名
objRow[conSV_RelaTabType.Memo] = oRow[conSV_RelaTabType.Memo].ToString().Trim(); //说明
 objDS.Tables[clsSV_RelaTabTypeEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsSV_RelaTabTypeEN._CurrTabName);
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
 /// <param name = "objSV_RelaTabTypeEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsSV_RelaTabTypeEN objSV_RelaTabTypeEN)
{
 if (objSV_RelaTabTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSV_RelaTabTypeEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
strSQL = "Select * from SV_RelaTabType where SvRelaTabTypeId = " + "'"+ objSV_RelaTabTypeEN.SvRelaTabTypeId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsSV_RelaTabTypeEN._CurrTabName);
if (objDS.Tables[clsSV_RelaTabTypeEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:SvRelaTabTypeId = " + "'"+ objSV_RelaTabTypeEN.SvRelaTabTypeId+"'");
return false;
}
objRow = objDS.Tables[clsSV_RelaTabTypeEN._CurrTabName].Rows[0];
 if (objSV_RelaTabTypeEN.IsUpdated(conSV_RelaTabType.SvRelaTabTypeId))
 {
objRow[conSV_RelaTabType.SvRelaTabTypeId] = objSV_RelaTabTypeEN.SvRelaTabTypeId; //Sql视图相关表类型Id
 }
 if (objSV_RelaTabTypeEN.IsUpdated(conSV_RelaTabType.SvRelaTabTypeName))
 {
objRow[conSV_RelaTabType.SvRelaTabTypeName] = objSV_RelaTabTypeEN.SvRelaTabTypeName; //Sql视图相关表类型名
 }
 if (objSV_RelaTabTypeEN.IsUpdated(conSV_RelaTabType.Memo))
 {
objRow[conSV_RelaTabType.Memo] = objSV_RelaTabTypeEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsSV_RelaTabTypeEN._CurrTabName);
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
public bool UpdateBySP(clsSV_RelaTabTypeEN objSV_RelaTabTypeEN)
{
 if (objSV_RelaTabTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSV_RelaTabTypeEN);
 }
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objSV_RelaTabTypeEN.SvRelaTabTypeId,
 objSV_RelaTabTypeEN.SvRelaTabTypeName,
 objSV_RelaTabTypeEN.Memo
};
 objSQL.ExecSP("SV_RelaTabType_Update",values);
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySql2)
 /// </summary>
 /// <param name = "objSV_RelaTabTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsSV_RelaTabTypeEN objSV_RelaTabTypeEN)
{
 if (objSV_RelaTabTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSV_RelaTabTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update SV_RelaTabType Set ");
 
 if (objSV_RelaTabTypeEN.IsUpdated(conSV_RelaTabType.SvRelaTabTypeName))
 {
 if (objSV_RelaTabTypeEN.SvRelaTabTypeName !=  null)
 {
 objSV_RelaTabTypeEN.SvRelaTabTypeName = objSV_RelaTabTypeEN.SvRelaTabTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objSV_RelaTabTypeEN.SvRelaTabTypeName, conSV_RelaTabType.SvRelaTabTypeName); //Sql视图相关表类型名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSV_RelaTabType.SvRelaTabTypeName); //Sql视图相关表类型名
 }
 }
 
 if (objSV_RelaTabTypeEN.IsUpdated(conSV_RelaTabType.Memo))
 {
 if (objSV_RelaTabTypeEN.Memo !=  null)
 {
 objSV_RelaTabTypeEN.Memo = objSV_RelaTabTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objSV_RelaTabTypeEN.Memo, conSV_RelaTabType.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSV_RelaTabType.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where SvRelaTabTypeId = '{0}'", objSV_RelaTabTypeEN.SvRelaTabTypeId); 
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
 /// <param name = "objSV_RelaTabTypeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsSV_RelaTabTypeEN objSV_RelaTabTypeEN, string strCondition)
{
 if (objSV_RelaTabTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSV_RelaTabTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SV_RelaTabType Set ");
 
 if (objSV_RelaTabTypeEN.IsUpdated(conSV_RelaTabType.SvRelaTabTypeName))
 {
 if (objSV_RelaTabTypeEN.SvRelaTabTypeName !=  null)
 {
 objSV_RelaTabTypeEN.SvRelaTabTypeName = objSV_RelaTabTypeEN.SvRelaTabTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SvRelaTabTypeName = '{0}',", objSV_RelaTabTypeEN.SvRelaTabTypeName); //Sql视图相关表类型名
 }
 else
 {
 sbSQL.Append(" SvRelaTabTypeName = null,"); //Sql视图相关表类型名
 }
 }
 
 if (objSV_RelaTabTypeEN.IsUpdated(conSV_RelaTabType.Memo))
 {
 if (objSV_RelaTabTypeEN.Memo !=  null)
 {
 objSV_RelaTabTypeEN.Memo = objSV_RelaTabTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", objSV_RelaTabTypeEN.Memo); //说明
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
 /// <param name = "objSV_RelaTabTypeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsSV_RelaTabTypeEN objSV_RelaTabTypeEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objSV_RelaTabTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSV_RelaTabTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SV_RelaTabType Set ");
 
 if (objSV_RelaTabTypeEN.IsUpdated(conSV_RelaTabType.SvRelaTabTypeName))
 {
 if (objSV_RelaTabTypeEN.SvRelaTabTypeName !=  null)
 {
 objSV_RelaTabTypeEN.SvRelaTabTypeName = objSV_RelaTabTypeEN.SvRelaTabTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SvRelaTabTypeName = '{0}',", objSV_RelaTabTypeEN.SvRelaTabTypeName); //Sql视图相关表类型名
 }
 else
 {
 sbSQL.Append(" SvRelaTabTypeName = null,"); //Sql视图相关表类型名
 }
 }
 
 if (objSV_RelaTabTypeEN.IsUpdated(conSV_RelaTabType.Memo))
 {
 if (objSV_RelaTabTypeEN.Memo !=  null)
 {
 objSV_RelaTabTypeEN.Memo = objSV_RelaTabTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", objSV_RelaTabTypeEN.Memo); //说明
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
 /// <param name = "objSV_RelaTabTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsSV_RelaTabTypeEN objSV_RelaTabTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objSV_RelaTabTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSV_RelaTabTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SV_RelaTabType Set ");
 
 if (objSV_RelaTabTypeEN.IsUpdated(conSV_RelaTabType.SvRelaTabTypeName))
 {
 if (objSV_RelaTabTypeEN.SvRelaTabTypeName !=  null)
 {
 objSV_RelaTabTypeEN.SvRelaTabTypeName = objSV_RelaTabTypeEN.SvRelaTabTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objSV_RelaTabTypeEN.SvRelaTabTypeName, conSV_RelaTabType.SvRelaTabTypeName); //Sql视图相关表类型名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSV_RelaTabType.SvRelaTabTypeName); //Sql视图相关表类型名
 }
 }
 
 if (objSV_RelaTabTypeEN.IsUpdated(conSV_RelaTabType.Memo))
 {
 if (objSV_RelaTabTypeEN.Memo !=  null)
 {
 objSV_RelaTabTypeEN.Memo = objSV_RelaTabTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objSV_RelaTabTypeEN.Memo, conSV_RelaTabType.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSV_RelaTabType.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where SvRelaTabTypeId = '{0}'", objSV_RelaTabTypeEN.SvRelaTabTypeId); 
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
 /// <param name = "strSvRelaTabTypeId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strSvRelaTabTypeId) 
{
CheckPrimaryKey(strSvRelaTabTypeId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strSvRelaTabTypeId,
};
 objSQL.ExecSP("SV_RelaTabType_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strSvRelaTabTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strSvRelaTabTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strSvRelaTabTypeId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
//删除SV_RelaTabType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SV_RelaTabType where SvRelaTabTypeId = " + "'"+ strSvRelaTabTypeId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelSV_RelaTabType(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
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
//删除SV_RelaTabType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SV_RelaTabType where SvRelaTabTypeId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strSvRelaTabTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strSvRelaTabTypeId) 
{
CheckPrimaryKey(strSvRelaTabTypeId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
//删除SV_RelaTabType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SV_RelaTabType where SvRelaTabTypeId = " + "'"+ strSvRelaTabTypeId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelSV_RelaTabType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsSV_RelaTabTypeDA: DelSV_RelaTabType)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from SV_RelaTabType where " + strCondition ;
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
public bool DelSV_RelaTabTypeWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsSV_RelaTabTypeDA: DelSV_RelaTabTypeWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from SV_RelaTabType where " + strCondition ;
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
 /// <param name = "objSV_RelaTabTypeENS">源对象</param>
 /// <param name = "objSV_RelaTabTypeENT">目标对象</param>
public void CopyTo(clsSV_RelaTabTypeEN objSV_RelaTabTypeENS, clsSV_RelaTabTypeEN objSV_RelaTabTypeENT)
{
objSV_RelaTabTypeENT.SvRelaTabTypeId = objSV_RelaTabTypeENS.SvRelaTabTypeId; //Sql视图相关表类型Id
objSV_RelaTabTypeENT.SvRelaTabTypeName = objSV_RelaTabTypeENS.SvRelaTabTypeName; //Sql视图相关表类型名
objSV_RelaTabTypeENT.Memo = objSV_RelaTabTypeENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsSV_RelaTabTypeEN objSV_RelaTabTypeEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objSV_RelaTabTypeEN.SvRelaTabTypeName, conSV_RelaTabType.SvRelaTabTypeName);
//检查字段长度
clsCheckSql.CheckFieldLen(objSV_RelaTabTypeEN.SvRelaTabTypeId, 2, conSV_RelaTabType.SvRelaTabTypeId);
clsCheckSql.CheckFieldLen(objSV_RelaTabTypeEN.SvRelaTabTypeName, 30, conSV_RelaTabType.SvRelaTabTypeName);
clsCheckSql.CheckFieldLen(objSV_RelaTabTypeEN.Memo, 1000, conSV_RelaTabType.Memo);
//检查字段外键固定长度
 objSV_RelaTabTypeEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsSV_RelaTabTypeEN objSV_RelaTabTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objSV_RelaTabTypeEN.SvRelaTabTypeName, 30, conSV_RelaTabType.SvRelaTabTypeName);
clsCheckSql.CheckFieldLen(objSV_RelaTabTypeEN.Memo, 1000, conSV_RelaTabType.Memo);
//检查外键字段长度
 objSV_RelaTabTypeEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsSV_RelaTabTypeEN objSV_RelaTabTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objSV_RelaTabTypeEN.SvRelaTabTypeId, 2, conSV_RelaTabType.SvRelaTabTypeId);
clsCheckSql.CheckFieldLen(objSV_RelaTabTypeEN.SvRelaTabTypeName, 30, conSV_RelaTabType.SvRelaTabTypeName);
clsCheckSql.CheckFieldLen(objSV_RelaTabTypeEN.Memo, 1000, conSV_RelaTabType.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objSV_RelaTabTypeEN.SvRelaTabTypeId, conSV_RelaTabType.SvRelaTabTypeId);
clsCheckSql.CheckSqlInjection4Field(objSV_RelaTabTypeEN.SvRelaTabTypeName, conSV_RelaTabType.SvRelaTabTypeName);
clsCheckSql.CheckSqlInjection4Field(objSV_RelaTabTypeEN.Memo, conSV_RelaTabType.Memo);
//检查外键字段长度
 objSV_RelaTabTypeEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetSvRelaTabTypeId()
{
//获取某学院所有专业信息
string strSQL = "select SvRelaTabTypeId, SvRelaTabTypeName from SV_RelaTabType ";
 clsSpecSQLforSql mySql = clsSV_RelaTabTypeDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--SV_RelaTabType(Sql视图相关表类型),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objSV_RelaTabTypeEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStrSV_RelaTabTypeName(clsSV_RelaTabTypeEN objSV_RelaTabTypeEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and SvRelaTabTypeName = '{0}'", objSV_RelaTabTypeEN.SvRelaTabTypeName);
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
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
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
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
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
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsSV_RelaTabTypeEN._CurrTabName);
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
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsSV_RelaTabTypeEN._CurrTabName, strCondition);
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
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
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
 objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}