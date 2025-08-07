
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTextBoxStyleDA
 表名:TextBoxStyle(00050088)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:16:37
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:界面控件管理(ViewControlManage)
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
 /// TextBoxStyle(TextBoxStyle)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class clsTextBoxStyleDA : clsCommBase4DA
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
 return clsTextBoxStyleEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsTextBoxStyleEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsTextBoxStyleEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsTextBoxStyleEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsTextBoxStyleEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strTextBoxStyleId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strTextBoxStyleId)
{
strTextBoxStyleId = strTextBoxStyleId.Replace("'", "''");
if (strTextBoxStyleId.Length > 4)
{
throw new Exception("(errid:Data000001)在表:TextBoxStyle中,检查关键字,长度不正确!(clsTextBoxStyleDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strTextBoxStyleId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:TextBoxStyle中,关键字不能为空 或 null!(clsTextBoxStyleDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTextBoxStyleId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsTextBoxStyleDA:CheckPrimaryKey)", objException.Message));
}
return true;
}

 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey_Sim)
 /// </summary>
 /// <param name = "strTextBoxStyleId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey_Sim(string strTextBoxStyleId)
{
strTextBoxStyleId = strTextBoxStyleId.Replace("'", "''");
if (strTextBoxStyleId.Length > 4 + 4)
{
throw new Exception("(errid:Data000004)在表:TextBoxStyle中,检查关键字,长度不正确!(简化版)(clsTextBoxStyleDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strTextBoxStyleId)  ==  true)
{
throw new Exception("(errid:Data000005)在表:TextBoxStyle中,关键字不能为空 或 null!(clsTextBoxStyleDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTextBoxStyleId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000006)在关键字中含有{0},非法,请检查!(clsTextBoxStyleDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsTextBoxStyleDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
 strSQL = "Select * from TextBoxStyle where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "TextBoxStyle");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsTextBoxStyleDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("TextBoxStyle_SelectByCond",values, "TextBoxStyle");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsTextBoxStyleDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from TextBoxStyle where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "TextBoxStyle");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsTextBoxStyleDA: GetTextBoxStyleByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsTextBoxStyleDA: GetTextBoxStyleByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsTextBoxStyleDA: GetTextBoxStyleByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsTextBoxStyleDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from TextBoxStyle a where {0} And a.TextBoxStyleId not in (Select Top {2} TextBoxStyleId From TextBoxStyle Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "TextBoxStyle");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsTextBoxStyleDA: GetTextBoxStyleByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsTextBoxStyleDA: GetTextBoxStyleByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsTextBoxStyleDA: GetTextBoxStyleByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsTextBoxStyleDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from TextBoxStyle a where {0} And a.TextBoxStyleId not in (Select Top {2} TextBoxStyleId From TextBoxStyle Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "TextBoxStyle");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsTextBoxStyleDA: GetTextBoxStyleByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsTextBoxStyleDA: GetTextBoxStyleByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsTextBoxStyleDA: GetTextBoxStyleByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsTextBoxStyleDA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsTextBoxStyleDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from TextBoxStyle a where {0} And a.TextBoxStyleId not in (Select Top {2} TextBoxStyleId From TextBoxStyle Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "TextBoxStyle");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsTextBoxStyleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
strSQL = "Select * from TextBoxStyle where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_TextBoxStyle(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsTextBoxStyleDA: GetDataTable_TextBoxStyle)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
strSQL = "Select * from TextBoxStyle where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsTextBoxStyleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsTextBoxStyleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
strSQL = "Select * from TextBoxStyle where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsTextBoxStyleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsTextBoxStyleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
strSQL = "Select * from TextBoxStyle where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsTextBoxStyleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsTextBoxStyleDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from TextBoxStyle where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from TextBoxStyle where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsTextBoxStyleDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from TextBoxStyle where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsTextBoxStyleDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from TextBoxStyle where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsTextBoxStyleDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} TextBoxStyle.* from TextBoxStyle Left Join {1} on {2} where {3} and TextBoxStyle.TextBoxStyleId not in (Select top {5} TextBoxStyle.TextBoxStyleId from TextBoxStyle Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from TextBoxStyle where {1} and TextBoxStyleId not in (Select top {2} TextBoxStyleId from TextBoxStyle where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from TextBoxStyle where {1} and TextBoxStyleId not in (Select top {3} TextBoxStyleId from TextBoxStyle where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsTextBoxStyleDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} TextBoxStyle.* from TextBoxStyle Left Join {1} on {2} where {3} and TextBoxStyle.TextBoxStyleId not in (Select top {5} TextBoxStyle.TextBoxStyleId from TextBoxStyle Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from TextBoxStyle where {1} and TextBoxStyleId not in (Select top {2} TextBoxStyleId from TextBoxStyle where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from TextBoxStyle where {1} and TextBoxStyleId not in (Select top {3} TextBoxStyleId from TextBoxStyle where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsTextBoxStyleDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} TextBoxStyle.* from TextBoxStyle Left Join {1} on {2} where {3} and TextBoxStyle.TextBoxStyleId not in (Select top {5} TextBoxStyle.TextBoxStyleId from TextBoxStyle Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from TextBoxStyle where {1} and TextBoxStyleId not in (Select top {2} TextBoxStyleId from TextBoxStyle where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from TextBoxStyle where {1} and TextBoxStyleId not in (Select top {3} TextBoxStyleId from TextBoxStyle where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsTextBoxStyleDA: GetTextBoxStyleByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsTextBoxStyleDA: GetTextBoxStyleByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsTextBoxStyleDA: GetTextBoxStyleByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsTextBoxStyleDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from TextBoxStyle a where {0} And a.TextBoxStyleId not in (Select Top {2} TextBoxStyleId From TextBoxStyle Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from TextBoxStyle a where {0} And a.TextBoxStyleId not in (Select Top {2} TextBoxStyleId From TextBoxStyle Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsTextBoxStyleDA: GetTextBoxStyleByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsTextBoxStyleDA: GetTextBoxStyleByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsTextBoxStyleDA: GetTextBoxStyleByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsTextBoxStyleDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from TextBoxStyle a where {0} And a.TextBoxStyleId not in (Select Top {2} TextBoxStyleId From TextBoxStyle Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from TextBoxStyle a where {0} And a.TextBoxStyleId not in (Select Top {2} TextBoxStyleId From TextBoxStyle Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsTextBoxStyleDA: GetTextBoxStyleByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsTextBoxStyleDA: GetTextBoxStyleByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsTextBoxStyleDA: GetTextBoxStyleByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsTextBoxStyleDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
strSQL = "Select * from TextBoxStyle where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsTextBoxStyleDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("TextBoxStyle_SelectByCond",values);
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
public List<clsTextBoxStyleEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsTextBoxStyleDA:GetObjLst)", objException.Message));
}
List<clsTextBoxStyleEN> arrObjLst = new List<clsTextBoxStyleEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
strSQL = "Select * from TextBoxStyle where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTextBoxStyleEN objTextBoxStyleEN = new clsTextBoxStyleEN();
try
{
objTextBoxStyleEN.TextBoxStyleId = objRow[conTextBoxStyle.TextBoxStyleId].ToString().Trim(); //TextBoxStyleId
objTextBoxStyleEN.TextBoxStyleName = objRow[conTextBoxStyle.TextBoxStyleName].ToString().Trim(); //TextBoxStyleName
objTextBoxStyleEN.Style = objRow[conTextBoxStyle.Style] == DBNull.Value ? null : objRow[conTextBoxStyle.Style].ToString().Trim(); //类型
objTextBoxStyleEN.Runat = objRow[conTextBoxStyle.Runat] == DBNull.Value ? null : objRow[conTextBoxStyle.Runat].ToString().Trim(); //运行在
objTextBoxStyleEN.FontSize = objRow[conTextBoxStyle.FontSize] == DBNull.Value ? null : objRow[conTextBoxStyle.FontSize].ToString().Trim(); //字号
objTextBoxStyleEN.FontName = objRow[conTextBoxStyle.FontName] == DBNull.Value ? null : objRow[conTextBoxStyle.FontName].ToString().Trim(); //字体
objTextBoxStyleEN.Width = objRow[conTextBoxStyle.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTextBoxStyle.Width].ToString().Trim()); //宽
objTextBoxStyleEN.Height = objRow[conTextBoxStyle.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTextBoxStyle.Height].ToString().Trim()); //高度
objTextBoxStyleEN.TextMode = objRow[conTextBoxStyle.TextMode].ToString().Trim(); //TextMode
objTextBoxStyleEN.ReadOnly = TransNullToBool(objRow[conTextBoxStyle.ReadOnly].ToString().Trim()); //ReadOnly
objTextBoxStyleEN.StyleZindex = objRow[conTextBoxStyle.StyleZindex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTextBoxStyle.StyleZindex].ToString().Trim()); //StyleZindex
objTextBoxStyleEN.StyleLeft = objRow[conTextBoxStyle.StyleLeft] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTextBoxStyle.StyleLeft].ToString().Trim()); //StyleLeft
objTextBoxStyleEN.StylePosition = objRow[conTextBoxStyle.StylePosition] == DBNull.Value ? null : objRow[conTextBoxStyle.StylePosition].ToString().Trim(); //StylePosition
objTextBoxStyleEN.StyleTop = objRow[conTextBoxStyle.StyleTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTextBoxStyle.StyleTop].ToString().Trim()); //StyleTop
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsTextBoxStyleDA: GetObjLst)", objException.Message));
}
objTextBoxStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objTextBoxStyleEN);
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
public List<clsTextBoxStyleEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsTextBoxStyleDA:GetObjLstByTabName)", objException.Message));
}
List<clsTextBoxStyleEN> arrObjLst = new List<clsTextBoxStyleEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTextBoxStyleEN objTextBoxStyleEN = new clsTextBoxStyleEN();
try
{
objTextBoxStyleEN.TextBoxStyleId = objRow[conTextBoxStyle.TextBoxStyleId].ToString().Trim(); //TextBoxStyleId
objTextBoxStyleEN.TextBoxStyleName = objRow[conTextBoxStyle.TextBoxStyleName].ToString().Trim(); //TextBoxStyleName
objTextBoxStyleEN.Style = objRow[conTextBoxStyle.Style] == DBNull.Value ? null : objRow[conTextBoxStyle.Style].ToString().Trim(); //类型
objTextBoxStyleEN.Runat = objRow[conTextBoxStyle.Runat] == DBNull.Value ? null : objRow[conTextBoxStyle.Runat].ToString().Trim(); //运行在
objTextBoxStyleEN.FontSize = objRow[conTextBoxStyle.FontSize] == DBNull.Value ? null : objRow[conTextBoxStyle.FontSize].ToString().Trim(); //字号
objTextBoxStyleEN.FontName = objRow[conTextBoxStyle.FontName] == DBNull.Value ? null : objRow[conTextBoxStyle.FontName].ToString().Trim(); //字体
objTextBoxStyleEN.Width = objRow[conTextBoxStyle.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTextBoxStyle.Width].ToString().Trim()); //宽
objTextBoxStyleEN.Height = objRow[conTextBoxStyle.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTextBoxStyle.Height].ToString().Trim()); //高度
objTextBoxStyleEN.TextMode = objRow[conTextBoxStyle.TextMode].ToString().Trim(); //TextMode
objTextBoxStyleEN.ReadOnly = TransNullToBool(objRow[conTextBoxStyle.ReadOnly].ToString().Trim()); //ReadOnly
objTextBoxStyleEN.StyleZindex = objRow[conTextBoxStyle.StyleZindex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTextBoxStyle.StyleZindex].ToString().Trim()); //StyleZindex
objTextBoxStyleEN.StyleLeft = objRow[conTextBoxStyle.StyleLeft] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTextBoxStyle.StyleLeft].ToString().Trim()); //StyleLeft
objTextBoxStyleEN.StylePosition = objRow[conTextBoxStyle.StylePosition] == DBNull.Value ? null : objRow[conTextBoxStyle.StylePosition].ToString().Trim(); //StylePosition
objTextBoxStyleEN.StyleTop = objRow[conTextBoxStyle.StyleTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTextBoxStyle.StyleTop].ToString().Trim()); //StyleTop
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsTextBoxStyleDA: GetObjLst)", objException.Message));
}
objTextBoxStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objTextBoxStyleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsTextBoxStyleEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsTextBoxStyleDA:GetObjLstBySP)", objException.Message));
}
List<clsTextBoxStyleEN> arrObjLst = new List<clsTextBoxStyleEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("TextBoxStyle_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTextBoxStyleEN objTextBoxStyleEN = new clsTextBoxStyleEN();
try
{
objTextBoxStyleEN.TextBoxStyleId = objRow[conTextBoxStyle.TextBoxStyleId].ToString().Trim(); //TextBoxStyleId
objTextBoxStyleEN.TextBoxStyleName = objRow[conTextBoxStyle.TextBoxStyleName].ToString().Trim(); //TextBoxStyleName
objTextBoxStyleEN.Style = objRow[conTextBoxStyle.Style] == DBNull.Value ? null : objRow[conTextBoxStyle.Style].ToString().Trim(); //类型
objTextBoxStyleEN.Runat = objRow[conTextBoxStyle.Runat] == DBNull.Value ? null : objRow[conTextBoxStyle.Runat].ToString().Trim(); //运行在
objTextBoxStyleEN.FontSize = objRow[conTextBoxStyle.FontSize] == DBNull.Value ? null : objRow[conTextBoxStyle.FontSize].ToString().Trim(); //字号
objTextBoxStyleEN.FontName = objRow[conTextBoxStyle.FontName] == DBNull.Value ? null : objRow[conTextBoxStyle.FontName].ToString().Trim(); //字体
objTextBoxStyleEN.Width = objRow[conTextBoxStyle.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTextBoxStyle.Width].ToString().Trim()); //宽
objTextBoxStyleEN.Height = objRow[conTextBoxStyle.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTextBoxStyle.Height].ToString().Trim()); //高度
objTextBoxStyleEN.TextMode = objRow[conTextBoxStyle.TextMode].ToString().Trim(); //TextMode
objTextBoxStyleEN.ReadOnly = TransNullToBool(objRow[conTextBoxStyle.ReadOnly].ToString().Trim()); //ReadOnly
objTextBoxStyleEN.StyleZindex = objRow[conTextBoxStyle.StyleZindex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTextBoxStyle.StyleZindex].ToString().Trim()); //StyleZindex
objTextBoxStyleEN.StyleLeft = objRow[conTextBoxStyle.StyleLeft] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTextBoxStyle.StyleLeft].ToString().Trim()); //StyleLeft
objTextBoxStyleEN.StylePosition = objRow[conTextBoxStyle.StylePosition] == DBNull.Value ? null : objRow[conTextBoxStyle.StylePosition].ToString().Trim(); //StylePosition
objTextBoxStyleEN.StyleTop = objRow[conTextBoxStyle.StyleTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTextBoxStyle.StyleTop].ToString().Trim()); //StyleTop
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsTextBoxStyleDA: GetObjLstBySP)", objException.Message));
}
objTextBoxStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objTextBoxStyleEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objTextBoxStyleEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetTextBoxStyle(ref clsTextBoxStyleEN objTextBoxStyleEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
strSQL = "Select * from TextBoxStyle where TextBoxStyleId = " + "'"+ objTextBoxStyleEN.TextBoxStyleId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objTextBoxStyleEN.TextBoxStyleId = objDT.Rows[0][conTextBoxStyle.TextBoxStyleId].ToString().Trim(); //TextBoxStyleId(字段类型:varchar,字段长度:4,是否可空:False)
 objTextBoxStyleEN.TextBoxStyleName = objDT.Rows[0][conTextBoxStyle.TextBoxStyleName].ToString().Trim(); //TextBoxStyleName(字段类型:varchar,字段长度:30,是否可空:False)
 objTextBoxStyleEN.Style = objDT.Rows[0][conTextBoxStyle.Style].ToString().Trim(); //类型(字段类型:varchar,字段长度:800,是否可空:True)
 objTextBoxStyleEN.Runat = objDT.Rows[0][conTextBoxStyle.Runat].ToString().Trim(); //运行在(字段类型:varchar,字段长度:30,是否可空:True)
 objTextBoxStyleEN.FontSize = objDT.Rows[0][conTextBoxStyle.FontSize].ToString().Trim(); //字号(字段类型:varchar,字段长度:20,是否可空:True)
 objTextBoxStyleEN.FontName = objDT.Rows[0][conTextBoxStyle.FontName].ToString().Trim(); //字体(字段类型:varchar,字段长度:20,是否可空:True)
 objTextBoxStyleEN.Width = TransNullToInt(objDT.Rows[0][conTextBoxStyle.Width].ToString().Trim()); //宽(字段类型:int,字段长度:4,是否可空:True)
 objTextBoxStyleEN.Height = TransNullToInt(objDT.Rows[0][conTextBoxStyle.Height].ToString().Trim()); //高度(字段类型:int,字段长度:4,是否可空:True)
 objTextBoxStyleEN.TextMode = objDT.Rows[0][conTextBoxStyle.TextMode].ToString().Trim(); //TextMode(字段类型:varchar,字段长度:20,是否可空:False)
 objTextBoxStyleEN.ReadOnly = TransNullToBool(objDT.Rows[0][conTextBoxStyle.ReadOnly].ToString().Trim()); //ReadOnly(字段类型:bit,字段长度:1,是否可空:False)
 objTextBoxStyleEN.StyleZindex = TransNullToInt(objDT.Rows[0][conTextBoxStyle.StyleZindex].ToString().Trim()); //StyleZindex(字段类型:int,字段长度:4,是否可空:True)
 objTextBoxStyleEN.StyleLeft = TransNullToInt(objDT.Rows[0][conTextBoxStyle.StyleLeft].ToString().Trim()); //StyleLeft(字段类型:int,字段长度:4,是否可空:True)
 objTextBoxStyleEN.StylePosition = objDT.Rows[0][conTextBoxStyle.StylePosition].ToString().Trim(); //StylePosition(字段类型:varchar,字段长度:20,是否可空:True)
 objTextBoxStyleEN.StyleTop = TransNullToInt(objDT.Rows[0][conTextBoxStyle.StyleTop].ToString().Trim()); //StyleTop(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsTextBoxStyleDA: GetTextBoxStyle)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTextBoxStyleId">表关键字</param>
 /// <returns>表对象</returns>
public clsTextBoxStyleEN GetObjByTextBoxStyleId(string strTextBoxStyleId)
{
CheckPrimaryKey(strTextBoxStyleId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
strSQL = "Select * from TextBoxStyle where TextBoxStyleId = " + "'"+ strTextBoxStyleId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsTextBoxStyleEN objTextBoxStyleEN = new clsTextBoxStyleEN();
try
{
 objTextBoxStyleEN.TextBoxStyleId = objRow[conTextBoxStyle.TextBoxStyleId].ToString().Trim(); //TextBoxStyleId(字段类型:varchar,字段长度:4,是否可空:False)
 objTextBoxStyleEN.TextBoxStyleName = objRow[conTextBoxStyle.TextBoxStyleName].ToString().Trim(); //TextBoxStyleName(字段类型:varchar,字段长度:30,是否可空:False)
 objTextBoxStyleEN.Style = objRow[conTextBoxStyle.Style] == DBNull.Value ? null : objRow[conTextBoxStyle.Style].ToString().Trim(); //类型(字段类型:varchar,字段长度:800,是否可空:True)
 objTextBoxStyleEN.Runat = objRow[conTextBoxStyle.Runat] == DBNull.Value ? null : objRow[conTextBoxStyle.Runat].ToString().Trim(); //运行在(字段类型:varchar,字段长度:30,是否可空:True)
 objTextBoxStyleEN.FontSize = objRow[conTextBoxStyle.FontSize] == DBNull.Value ? null : objRow[conTextBoxStyle.FontSize].ToString().Trim(); //字号(字段类型:varchar,字段长度:20,是否可空:True)
 objTextBoxStyleEN.FontName = objRow[conTextBoxStyle.FontName] == DBNull.Value ? null : objRow[conTextBoxStyle.FontName].ToString().Trim(); //字体(字段类型:varchar,字段长度:20,是否可空:True)
 objTextBoxStyleEN.Width = objRow[conTextBoxStyle.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTextBoxStyle.Width].ToString().Trim()); //宽(字段类型:int,字段长度:4,是否可空:True)
 objTextBoxStyleEN.Height = objRow[conTextBoxStyle.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTextBoxStyle.Height].ToString().Trim()); //高度(字段类型:int,字段长度:4,是否可空:True)
 objTextBoxStyleEN.TextMode = objRow[conTextBoxStyle.TextMode].ToString().Trim(); //TextMode(字段类型:varchar,字段长度:20,是否可空:False)
 objTextBoxStyleEN.ReadOnly = clsEntityBase2.TransNullToBool_S(objRow[conTextBoxStyle.ReadOnly].ToString().Trim()); //ReadOnly(字段类型:bit,字段长度:1,是否可空:False)
 objTextBoxStyleEN.StyleZindex = objRow[conTextBoxStyle.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTextBoxStyle.StyleZindex].ToString().Trim()); //StyleZindex(字段类型:int,字段长度:4,是否可空:True)
 objTextBoxStyleEN.StyleLeft = objRow[conTextBoxStyle.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTextBoxStyle.StyleLeft].ToString().Trim()); //StyleLeft(字段类型:int,字段长度:4,是否可空:True)
 objTextBoxStyleEN.StylePosition = objRow[conTextBoxStyle.StylePosition] == DBNull.Value ? null : objRow[conTextBoxStyle.StylePosition].ToString().Trim(); //StylePosition(字段类型:varchar,字段长度:20,是否可空:True)
 objTextBoxStyleEN.StyleTop = objRow[conTextBoxStyle.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTextBoxStyle.StyleTop].ToString().Trim()); //StyleTop(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsTextBoxStyleDA: GetObjByTextBoxStyleId)", objException.Message));
}
return objTextBoxStyleEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程TextBoxStyle_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objTextBoxStyleEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetTextBoxStyleOneBySP(clsTextBoxStyleEN objTextBoxStyleEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objTextBoxStyleEN.TextBoxStyleId
};
 objDT = objSQL.ExecSpReturnDT("TextBoxStyle_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objTextBoxStyleEN.TextBoxStyleId = objDT.Rows[0][conTextBoxStyle.TextBoxStyleId].ToString().Trim(); //TextBoxStyleId(字段类型:varchar,字段长度:4,是否可空:False)
 objTextBoxStyleEN.TextBoxStyleName = objDT.Rows[0][conTextBoxStyle.TextBoxStyleName].ToString().Trim(); //TextBoxStyleName(字段类型:varchar,字段长度:30,是否可空:False)
 objTextBoxStyleEN.Style = objDT.Rows[0][conTextBoxStyle.Style].ToString().Trim(); //类型(字段类型:varchar,字段长度:800,是否可空:True)
 objTextBoxStyleEN.Runat = objDT.Rows[0][conTextBoxStyle.Runat].ToString().Trim(); //运行在(字段类型:varchar,字段长度:30,是否可空:True)
 objTextBoxStyleEN.FontSize = objDT.Rows[0][conTextBoxStyle.FontSize].ToString().Trim(); //字号(字段类型:varchar,字段长度:20,是否可空:True)
 objTextBoxStyleEN.FontName = objDT.Rows[0][conTextBoxStyle.FontName].ToString().Trim(); //字体(字段类型:varchar,字段长度:20,是否可空:True)
 objTextBoxStyleEN.Width = TransNullToInt(objDT.Rows[0][conTextBoxStyle.Width].ToString().Trim()); //宽(字段类型:int,字段长度:4,是否可空:True)
 objTextBoxStyleEN.Height = TransNullToInt(objDT.Rows[0][conTextBoxStyle.Height].ToString().Trim()); //高度(字段类型:int,字段长度:4,是否可空:True)
 objTextBoxStyleEN.TextMode = objDT.Rows[0][conTextBoxStyle.TextMode].ToString().Trim(); //TextMode(字段类型:varchar,字段长度:20,是否可空:False)
 objTextBoxStyleEN.ReadOnly = TransNullToBool(objDT.Rows[0][conTextBoxStyle.ReadOnly].ToString().Trim()); //ReadOnly(字段类型:bit,字段长度:1,是否可空:False)
 objTextBoxStyleEN.StyleZindex = TransNullToInt(objDT.Rows[0][conTextBoxStyle.StyleZindex].ToString().Trim()); //StyleZindex(字段类型:int,字段长度:4,是否可空:True)
 objTextBoxStyleEN.StyleLeft = TransNullToInt(objDT.Rows[0][conTextBoxStyle.StyleLeft].ToString().Trim()); //StyleLeft(字段类型:int,字段长度:4,是否可空:True)
 objTextBoxStyleEN.StylePosition = objDT.Rows[0][conTextBoxStyle.StylePosition].ToString().Trim(); //StylePosition(字段类型:varchar,字段长度:20,是否可空:True)
 objTextBoxStyleEN.StyleTop = TransNullToInt(objDT.Rows[0][conTextBoxStyle.StyleTop].ToString().Trim()); //StyleTop(字段类型:int,字段长度:4,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsTextBoxStyleEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsTextBoxStyleDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
strSQL = "Select * from TextBoxStyle where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsTextBoxStyleEN objTextBoxStyleEN = new clsTextBoxStyleEN()
{
TextBoxStyleId = objRow[conTextBoxStyle.TextBoxStyleId].ToString().Trim(), //TextBoxStyleId
TextBoxStyleName = objRow[conTextBoxStyle.TextBoxStyleName].ToString().Trim(), //TextBoxStyleName
Style = objRow[conTextBoxStyle.Style] == DBNull.Value ? null : objRow[conTextBoxStyle.Style].ToString().Trim(), //类型
Runat = objRow[conTextBoxStyle.Runat] == DBNull.Value ? null : objRow[conTextBoxStyle.Runat].ToString().Trim(), //运行在
FontSize = objRow[conTextBoxStyle.FontSize] == DBNull.Value ? null : objRow[conTextBoxStyle.FontSize].ToString().Trim(), //字号
FontName = objRow[conTextBoxStyle.FontName] == DBNull.Value ? null : objRow[conTextBoxStyle.FontName].ToString().Trim(), //字体
Width = objRow[conTextBoxStyle.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTextBoxStyle.Width].ToString().Trim()), //宽
Height = objRow[conTextBoxStyle.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTextBoxStyle.Height].ToString().Trim()), //高度
TextMode = objRow[conTextBoxStyle.TextMode].ToString().Trim(), //TextMode
ReadOnly = TransNullToBool(objRow[conTextBoxStyle.ReadOnly].ToString().Trim()), //ReadOnly
StyleZindex = objRow[conTextBoxStyle.StyleZindex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTextBoxStyle.StyleZindex].ToString().Trim()), //StyleZindex
StyleLeft = objRow[conTextBoxStyle.StyleLeft] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTextBoxStyle.StyleLeft].ToString().Trim()), //StyleLeft
StylePosition = objRow[conTextBoxStyle.StylePosition] == DBNull.Value ? null : objRow[conTextBoxStyle.StylePosition].ToString().Trim(), //StylePosition
StyleTop = objRow[conTextBoxStyle.StyleTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTextBoxStyle.StyleTop].ToString().Trim()) //StyleTop
};
objTextBoxStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objTextBoxStyleEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsTextBoxStyleDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsTextBoxStyleEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsTextBoxStyleDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("TextBoxStyle_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsTextBoxStyleEN objTextBoxStyleEN = new clsTextBoxStyleEN()
{
TextBoxStyleId = objRow[conTextBoxStyle.TextBoxStyleId].ToString().Trim(), //TextBoxStyleId
TextBoxStyleName = objRow[conTextBoxStyle.TextBoxStyleName].ToString().Trim(), //TextBoxStyleName
Style = objRow[conTextBoxStyle.Style] == DBNull.Value ? null : objRow[conTextBoxStyle.Style].ToString().Trim(), //类型
Runat = objRow[conTextBoxStyle.Runat] == DBNull.Value ? null : objRow[conTextBoxStyle.Runat].ToString().Trim(), //运行在
FontSize = objRow[conTextBoxStyle.FontSize] == DBNull.Value ? null : objRow[conTextBoxStyle.FontSize].ToString().Trim(), //字号
FontName = objRow[conTextBoxStyle.FontName] == DBNull.Value ? null : objRow[conTextBoxStyle.FontName].ToString().Trim(), //字体
Width = objRow[conTextBoxStyle.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTextBoxStyle.Width].ToString().Trim()), //宽
Height = objRow[conTextBoxStyle.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTextBoxStyle.Height].ToString().Trim()), //高度
TextMode = objRow[conTextBoxStyle.TextMode].ToString().Trim(), //TextMode
ReadOnly = TransNullToBool(objRow[conTextBoxStyle.ReadOnly].ToString().Trim()), //ReadOnly
StyleZindex = objRow[conTextBoxStyle.StyleZindex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTextBoxStyle.StyleZindex].ToString().Trim()), //StyleZindex
StyleLeft = objRow[conTextBoxStyle.StyleLeft] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTextBoxStyle.StyleLeft].ToString().Trim()), //StyleLeft
StylePosition = objRow[conTextBoxStyle.StylePosition] == DBNull.Value ? null : objRow[conTextBoxStyle.StylePosition].ToString().Trim(), //StylePosition
StyleTop = objRow[conTextBoxStyle.StyleTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTextBoxStyle.StyleTop].ToString().Trim()) //StyleTop
};
objTextBoxStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objTextBoxStyleEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsTextBoxStyleEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsTextBoxStyleEN objTextBoxStyleEN = new clsTextBoxStyleEN();
try
{
objTextBoxStyleEN.TextBoxStyleId = objRow[conTextBoxStyle.TextBoxStyleId].ToString().Trim(); //TextBoxStyleId
objTextBoxStyleEN.TextBoxStyleName = objRow[conTextBoxStyle.TextBoxStyleName].ToString().Trim(); //TextBoxStyleName
objTextBoxStyleEN.Style = objRow[conTextBoxStyle.Style] == DBNull.Value ? null : objRow[conTextBoxStyle.Style].ToString().Trim(); //类型
objTextBoxStyleEN.Runat = objRow[conTextBoxStyle.Runat] == DBNull.Value ? null : objRow[conTextBoxStyle.Runat].ToString().Trim(); //运行在
objTextBoxStyleEN.FontSize = objRow[conTextBoxStyle.FontSize] == DBNull.Value ? null : objRow[conTextBoxStyle.FontSize].ToString().Trim(); //字号
objTextBoxStyleEN.FontName = objRow[conTextBoxStyle.FontName] == DBNull.Value ? null : objRow[conTextBoxStyle.FontName].ToString().Trim(); //字体
objTextBoxStyleEN.Width = objRow[conTextBoxStyle.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTextBoxStyle.Width].ToString().Trim()); //宽
objTextBoxStyleEN.Height = objRow[conTextBoxStyle.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTextBoxStyle.Height].ToString().Trim()); //高度
objTextBoxStyleEN.TextMode = objRow[conTextBoxStyle.TextMode].ToString().Trim(); //TextMode
objTextBoxStyleEN.ReadOnly = TransNullToBool(objRow[conTextBoxStyle.ReadOnly].ToString().Trim()); //ReadOnly
objTextBoxStyleEN.StyleZindex = objRow[conTextBoxStyle.StyleZindex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTextBoxStyle.StyleZindex].ToString().Trim()); //StyleZindex
objTextBoxStyleEN.StyleLeft = objRow[conTextBoxStyle.StyleLeft] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTextBoxStyle.StyleLeft].ToString().Trim()); //StyleLeft
objTextBoxStyleEN.StylePosition = objRow[conTextBoxStyle.StylePosition] == DBNull.Value ? null : objRow[conTextBoxStyle.StylePosition].ToString().Trim(); //StylePosition
objTextBoxStyleEN.StyleTop = objRow[conTextBoxStyle.StyleTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTextBoxStyle.StyleTop].ToString().Trim()); //StyleTop
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsTextBoxStyleDA: GetObjByDataRowTextBoxStyle)", objException.Message));
}
objTextBoxStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objTextBoxStyleEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsTextBoxStyleEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsTextBoxStyleEN objTextBoxStyleEN = new clsTextBoxStyleEN();
try
{
objTextBoxStyleEN.TextBoxStyleId = objRow[conTextBoxStyle.TextBoxStyleId].ToString().Trim(); //TextBoxStyleId
objTextBoxStyleEN.TextBoxStyleName = objRow[conTextBoxStyle.TextBoxStyleName].ToString().Trim(); //TextBoxStyleName
objTextBoxStyleEN.Style = objRow[conTextBoxStyle.Style] == DBNull.Value ? null : objRow[conTextBoxStyle.Style].ToString().Trim(); //类型
objTextBoxStyleEN.Runat = objRow[conTextBoxStyle.Runat] == DBNull.Value ? null : objRow[conTextBoxStyle.Runat].ToString().Trim(); //运行在
objTextBoxStyleEN.FontSize = objRow[conTextBoxStyle.FontSize] == DBNull.Value ? null : objRow[conTextBoxStyle.FontSize].ToString().Trim(); //字号
objTextBoxStyleEN.FontName = objRow[conTextBoxStyle.FontName] == DBNull.Value ? null : objRow[conTextBoxStyle.FontName].ToString().Trim(); //字体
objTextBoxStyleEN.Width = objRow[conTextBoxStyle.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTextBoxStyle.Width].ToString().Trim()); //宽
objTextBoxStyleEN.Height = objRow[conTextBoxStyle.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTextBoxStyle.Height].ToString().Trim()); //高度
objTextBoxStyleEN.TextMode = objRow[conTextBoxStyle.TextMode].ToString().Trim(); //TextMode
objTextBoxStyleEN.ReadOnly = TransNullToBool(objRow[conTextBoxStyle.ReadOnly].ToString().Trim()); //ReadOnly
objTextBoxStyleEN.StyleZindex = objRow[conTextBoxStyle.StyleZindex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTextBoxStyle.StyleZindex].ToString().Trim()); //StyleZindex
objTextBoxStyleEN.StyleLeft = objRow[conTextBoxStyle.StyleLeft] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTextBoxStyle.StyleLeft].ToString().Trim()); //StyleLeft
objTextBoxStyleEN.StylePosition = objRow[conTextBoxStyle.StylePosition] == DBNull.Value ? null : objRow[conTextBoxStyle.StylePosition].ToString().Trim(); //StylePosition
objTextBoxStyleEN.StyleTop = objRow[conTextBoxStyle.StyleTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTextBoxStyle.StyleTop].ToString().Trim()); //StyleTop
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsTextBoxStyleDA: GetObjByDataRow)", objException.Message));
}
objTextBoxStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objTextBoxStyleEN;
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
objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsTextBoxStyleEN._CurrTabName, conTextBoxStyle.TextBoxStyleId, 4, "");
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
objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsTextBoxStyleEN._CurrTabName, conTextBoxStyle.TextBoxStyleId, 4, strPrefix);
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
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select TextBoxStyleId from TextBoxStyle where " + strCondition;
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
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select TextBoxStyleId from TextBoxStyle where " + strCondition;
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
 /// <param name = "strTextBoxStyleId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strTextBoxStyleId)
{
CheckPrimaryKey(strTextBoxStyleId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("TextBoxStyle", "TextBoxStyleId = " + "'"+ strTextBoxStyleId+"'"))
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
 /// <param name = "strTextBoxStyleId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExistBySP(string strTextBoxStyleId)
{
CheckPrimaryKey(strTextBoxStyleId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
strTextBoxStyleId,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("TextBoxStyle_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsTextBoxStyleDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("TextBoxStyle", strCondition))
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
objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("TextBoxStyle");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsTextBoxStyleEN objTextBoxStyleEN)
 {
 if (objTextBoxStyleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTextBoxStyleEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
strSQL = "Select * from TextBoxStyle where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "TextBoxStyle");
objRow = objDS.Tables["TextBoxStyle"].NewRow();
objRow[conTextBoxStyle.TextBoxStyleId] = objTextBoxStyleEN.TextBoxStyleId; //TextBoxStyleId
objRow[conTextBoxStyle.TextBoxStyleName] = objTextBoxStyleEN.TextBoxStyleName; //TextBoxStyleName
 if (objTextBoxStyleEN.Style !=  "")
 {
objRow[conTextBoxStyle.Style] = objTextBoxStyleEN.Style; //类型
 }
 if (objTextBoxStyleEN.Runat !=  "")
 {
objRow[conTextBoxStyle.Runat] = objTextBoxStyleEN.Runat; //运行在
 }
 if (objTextBoxStyleEN.FontSize !=  "")
 {
objRow[conTextBoxStyle.FontSize] = objTextBoxStyleEN.FontSize; //字号
 }
 if (objTextBoxStyleEN.FontName !=  "")
 {
objRow[conTextBoxStyle.FontName] = objTextBoxStyleEN.FontName; //字体
 }
objRow[conTextBoxStyle.Width] = objTextBoxStyleEN.Width; //宽
objRow[conTextBoxStyle.Height] = objTextBoxStyleEN.Height; //高度
objRow[conTextBoxStyle.TextMode] = objTextBoxStyleEN.TextMode; //TextMode
objRow[conTextBoxStyle.ReadOnly] = objTextBoxStyleEN.ReadOnly; //ReadOnly
objRow[conTextBoxStyle.StyleZindex] = objTextBoxStyleEN.StyleZindex; //StyleZindex
objRow[conTextBoxStyle.StyleLeft] = objTextBoxStyleEN.StyleLeft; //StyleLeft
 if (objTextBoxStyleEN.StylePosition !=  "")
 {
objRow[conTextBoxStyle.StylePosition] = objTextBoxStyleEN.StylePosition; //StylePosition
 }
objRow[conTextBoxStyle.StyleTop] = objTextBoxStyleEN.StyleTop; //StyleTop
objDS.Tables[clsTextBoxStyleEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsTextBoxStyleEN._CurrTabName);
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
 /// <param name = "objTextBoxStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsTextBoxStyleEN objTextBoxStyleEN)
{
 if (objTextBoxStyleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTextBoxStyleEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objTextBoxStyleEN.TextBoxStyleId !=  null)
 {
 arrFieldListForInsert.Add(conTextBoxStyle.TextBoxStyleId);
 objTextBoxStyleEN.TextBoxStyleId = objTextBoxStyleEN.TextBoxStyleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objTextBoxStyleEN.TextBoxStyleId + "'");
 }
 
 if (objTextBoxStyleEN.TextBoxStyleName !=  null)
 {
 arrFieldListForInsert.Add(conTextBoxStyle.TextBoxStyleName);
 objTextBoxStyleEN.TextBoxStyleName = objTextBoxStyleEN.TextBoxStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objTextBoxStyleEN.TextBoxStyleName + "'");
 }
 
 if (objTextBoxStyleEN.Style !=  null)
 {
 arrFieldListForInsert.Add(conTextBoxStyle.Style);
 objTextBoxStyleEN.Style = objTextBoxStyleEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objTextBoxStyleEN.Style + "'");
 }
 
 if (objTextBoxStyleEN.Runat !=  null)
 {
 arrFieldListForInsert.Add(conTextBoxStyle.Runat);
 objTextBoxStyleEN.Runat = objTextBoxStyleEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objTextBoxStyleEN.Runat + "'");
 }
 
 if (objTextBoxStyleEN.FontSize !=  null)
 {
 arrFieldListForInsert.Add(conTextBoxStyle.FontSize);
 objTextBoxStyleEN.FontSize = objTextBoxStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objTextBoxStyleEN.FontSize + "'");
 }
 
 if (objTextBoxStyleEN.FontName !=  null)
 {
 arrFieldListForInsert.Add(conTextBoxStyle.FontName);
 objTextBoxStyleEN.FontName = objTextBoxStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objTextBoxStyleEN.FontName + "'");
 }
 
 arrFieldListForInsert.Add(conTextBoxStyle.Width);
 arrValueListForInsert.Add(objTextBoxStyleEN.Width.ToString());
 
 arrFieldListForInsert.Add(conTextBoxStyle.Height);
 arrValueListForInsert.Add(objTextBoxStyleEN.Height.ToString());
 
 if (objTextBoxStyleEN.TextMode !=  null)
 {
 arrFieldListForInsert.Add(conTextBoxStyle.TextMode);
 objTextBoxStyleEN.TextMode = objTextBoxStyleEN.TextMode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objTextBoxStyleEN.TextMode + "'");
 }
 
 arrFieldListForInsert.Add(conTextBoxStyle.ReadOnly);
 arrValueListForInsert.Add("'" + (objTextBoxStyleEN.ReadOnly  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTextBoxStyle.StyleZindex);
 arrValueListForInsert.Add(objTextBoxStyleEN.StyleZindex.ToString());
 
 arrFieldListForInsert.Add(conTextBoxStyle.StyleLeft);
 arrValueListForInsert.Add(objTextBoxStyleEN.StyleLeft.ToString());
 
 if (objTextBoxStyleEN.StylePosition !=  null)
 {
 arrFieldListForInsert.Add(conTextBoxStyle.StylePosition);
 objTextBoxStyleEN.StylePosition = objTextBoxStyleEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objTextBoxStyleEN.StylePosition + "'");
 }
 
 arrFieldListForInsert.Add(conTextBoxStyle.StyleTop);
 arrValueListForInsert.Add(objTextBoxStyleEN.StyleTop.ToString());
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TextBoxStyle");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objTextBoxStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsTextBoxStyleEN objTextBoxStyleEN)
{
 if (objTextBoxStyleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTextBoxStyleEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objTextBoxStyleEN.TextBoxStyleId !=  null)
 {
 arrFieldListForInsert.Add(conTextBoxStyle.TextBoxStyleId);
 objTextBoxStyleEN.TextBoxStyleId = objTextBoxStyleEN.TextBoxStyleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objTextBoxStyleEN.TextBoxStyleId + "'");
 }
 
 if (objTextBoxStyleEN.TextBoxStyleName !=  null)
 {
 arrFieldListForInsert.Add(conTextBoxStyle.TextBoxStyleName);
 objTextBoxStyleEN.TextBoxStyleName = objTextBoxStyleEN.TextBoxStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objTextBoxStyleEN.TextBoxStyleName + "'");
 }
 
 if (objTextBoxStyleEN.Style !=  null)
 {
 arrFieldListForInsert.Add(conTextBoxStyle.Style);
 objTextBoxStyleEN.Style = objTextBoxStyleEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objTextBoxStyleEN.Style + "'");
 }
 
 if (objTextBoxStyleEN.Runat !=  null)
 {
 arrFieldListForInsert.Add(conTextBoxStyle.Runat);
 objTextBoxStyleEN.Runat = objTextBoxStyleEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objTextBoxStyleEN.Runat + "'");
 }
 
 if (objTextBoxStyleEN.FontSize !=  null)
 {
 arrFieldListForInsert.Add(conTextBoxStyle.FontSize);
 objTextBoxStyleEN.FontSize = objTextBoxStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objTextBoxStyleEN.FontSize + "'");
 }
 
 if (objTextBoxStyleEN.FontName !=  null)
 {
 arrFieldListForInsert.Add(conTextBoxStyle.FontName);
 objTextBoxStyleEN.FontName = objTextBoxStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objTextBoxStyleEN.FontName + "'");
 }
 
 arrFieldListForInsert.Add(conTextBoxStyle.Width);
 arrValueListForInsert.Add(objTextBoxStyleEN.Width.ToString());
 
 arrFieldListForInsert.Add(conTextBoxStyle.Height);
 arrValueListForInsert.Add(objTextBoxStyleEN.Height.ToString());
 
 if (objTextBoxStyleEN.TextMode !=  null)
 {
 arrFieldListForInsert.Add(conTextBoxStyle.TextMode);
 objTextBoxStyleEN.TextMode = objTextBoxStyleEN.TextMode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objTextBoxStyleEN.TextMode + "'");
 }
 
 arrFieldListForInsert.Add(conTextBoxStyle.ReadOnly);
 arrValueListForInsert.Add("'" + (objTextBoxStyleEN.ReadOnly  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTextBoxStyle.StyleZindex);
 arrValueListForInsert.Add(objTextBoxStyleEN.StyleZindex.ToString());
 
 arrFieldListForInsert.Add(conTextBoxStyle.StyleLeft);
 arrValueListForInsert.Add(objTextBoxStyleEN.StyleLeft.ToString());
 
 if (objTextBoxStyleEN.StylePosition !=  null)
 {
 arrFieldListForInsert.Add(conTextBoxStyle.StylePosition);
 objTextBoxStyleEN.StylePosition = objTextBoxStyleEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objTextBoxStyleEN.StylePosition + "'");
 }
 
 arrFieldListForInsert.Add(conTextBoxStyle.StyleTop);
 arrValueListForInsert.Add(objTextBoxStyleEN.StyleTop.ToString());
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TextBoxStyle");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objTextBoxStyleEN.TextBoxStyleId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objTextBoxStyleEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsTextBoxStyleEN objTextBoxStyleEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objTextBoxStyleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTextBoxStyleEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objTextBoxStyleEN.TextBoxStyleId !=  null)
 {
 arrFieldListForInsert.Add(conTextBoxStyle.TextBoxStyleId);
 objTextBoxStyleEN.TextBoxStyleId = objTextBoxStyleEN.TextBoxStyleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objTextBoxStyleEN.TextBoxStyleId + "'");
 }
 
 if (objTextBoxStyleEN.TextBoxStyleName !=  null)
 {
 arrFieldListForInsert.Add(conTextBoxStyle.TextBoxStyleName);
 objTextBoxStyleEN.TextBoxStyleName = objTextBoxStyleEN.TextBoxStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objTextBoxStyleEN.TextBoxStyleName + "'");
 }
 
 if (objTextBoxStyleEN.Style !=  null)
 {
 arrFieldListForInsert.Add(conTextBoxStyle.Style);
 objTextBoxStyleEN.Style = objTextBoxStyleEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objTextBoxStyleEN.Style + "'");
 }
 
 if (objTextBoxStyleEN.Runat !=  null)
 {
 arrFieldListForInsert.Add(conTextBoxStyle.Runat);
 objTextBoxStyleEN.Runat = objTextBoxStyleEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objTextBoxStyleEN.Runat + "'");
 }
 
 if (objTextBoxStyleEN.FontSize !=  null)
 {
 arrFieldListForInsert.Add(conTextBoxStyle.FontSize);
 objTextBoxStyleEN.FontSize = objTextBoxStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objTextBoxStyleEN.FontSize + "'");
 }
 
 if (objTextBoxStyleEN.FontName !=  null)
 {
 arrFieldListForInsert.Add(conTextBoxStyle.FontName);
 objTextBoxStyleEN.FontName = objTextBoxStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objTextBoxStyleEN.FontName + "'");
 }
 
 arrFieldListForInsert.Add(conTextBoxStyle.Width);
 arrValueListForInsert.Add(objTextBoxStyleEN.Width.ToString());
 
 arrFieldListForInsert.Add(conTextBoxStyle.Height);
 arrValueListForInsert.Add(objTextBoxStyleEN.Height.ToString());
 
 if (objTextBoxStyleEN.TextMode !=  null)
 {
 arrFieldListForInsert.Add(conTextBoxStyle.TextMode);
 objTextBoxStyleEN.TextMode = objTextBoxStyleEN.TextMode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objTextBoxStyleEN.TextMode + "'");
 }
 
 arrFieldListForInsert.Add(conTextBoxStyle.ReadOnly);
 arrValueListForInsert.Add("'" + (objTextBoxStyleEN.ReadOnly  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTextBoxStyle.StyleZindex);
 arrValueListForInsert.Add(objTextBoxStyleEN.StyleZindex.ToString());
 
 arrFieldListForInsert.Add(conTextBoxStyle.StyleLeft);
 arrValueListForInsert.Add(objTextBoxStyleEN.StyleLeft.ToString());
 
 if (objTextBoxStyleEN.StylePosition !=  null)
 {
 arrFieldListForInsert.Add(conTextBoxStyle.StylePosition);
 objTextBoxStyleEN.StylePosition = objTextBoxStyleEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objTextBoxStyleEN.StylePosition + "'");
 }
 
 arrFieldListForInsert.Add(conTextBoxStyle.StyleTop);
 arrValueListForInsert.Add(objTextBoxStyleEN.StyleTop.ToString());
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TextBoxStyle");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objTextBoxStyleEN.TextBoxStyleId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objTextBoxStyleEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsTextBoxStyleEN objTextBoxStyleEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objTextBoxStyleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTextBoxStyleEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objTextBoxStyleEN.TextBoxStyleId !=  null)
 {
 arrFieldListForInsert.Add(conTextBoxStyle.TextBoxStyleId);
 objTextBoxStyleEN.TextBoxStyleId = objTextBoxStyleEN.TextBoxStyleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objTextBoxStyleEN.TextBoxStyleId + "'");
 }
 
 if (objTextBoxStyleEN.TextBoxStyleName !=  null)
 {
 arrFieldListForInsert.Add(conTextBoxStyle.TextBoxStyleName);
 objTextBoxStyleEN.TextBoxStyleName = objTextBoxStyleEN.TextBoxStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objTextBoxStyleEN.TextBoxStyleName + "'");
 }
 
 if (objTextBoxStyleEN.Style !=  null)
 {
 arrFieldListForInsert.Add(conTextBoxStyle.Style);
 objTextBoxStyleEN.Style = objTextBoxStyleEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objTextBoxStyleEN.Style + "'");
 }
 
 if (objTextBoxStyleEN.Runat !=  null)
 {
 arrFieldListForInsert.Add(conTextBoxStyle.Runat);
 objTextBoxStyleEN.Runat = objTextBoxStyleEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objTextBoxStyleEN.Runat + "'");
 }
 
 if (objTextBoxStyleEN.FontSize !=  null)
 {
 arrFieldListForInsert.Add(conTextBoxStyle.FontSize);
 objTextBoxStyleEN.FontSize = objTextBoxStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objTextBoxStyleEN.FontSize + "'");
 }
 
 if (objTextBoxStyleEN.FontName !=  null)
 {
 arrFieldListForInsert.Add(conTextBoxStyle.FontName);
 objTextBoxStyleEN.FontName = objTextBoxStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objTextBoxStyleEN.FontName + "'");
 }
 
 arrFieldListForInsert.Add(conTextBoxStyle.Width);
 arrValueListForInsert.Add(objTextBoxStyleEN.Width.ToString());
 
 arrFieldListForInsert.Add(conTextBoxStyle.Height);
 arrValueListForInsert.Add(objTextBoxStyleEN.Height.ToString());
 
 if (objTextBoxStyleEN.TextMode !=  null)
 {
 arrFieldListForInsert.Add(conTextBoxStyle.TextMode);
 objTextBoxStyleEN.TextMode = objTextBoxStyleEN.TextMode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objTextBoxStyleEN.TextMode + "'");
 }
 
 arrFieldListForInsert.Add(conTextBoxStyle.ReadOnly);
 arrValueListForInsert.Add("'" + (objTextBoxStyleEN.ReadOnly  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTextBoxStyle.StyleZindex);
 arrValueListForInsert.Add(objTextBoxStyleEN.StyleZindex.ToString());
 
 arrFieldListForInsert.Add(conTextBoxStyle.StyleLeft);
 arrValueListForInsert.Add(objTextBoxStyleEN.StyleLeft.ToString());
 
 if (objTextBoxStyleEN.StylePosition !=  null)
 {
 arrFieldListForInsert.Add(conTextBoxStyle.StylePosition);
 objTextBoxStyleEN.StylePosition = objTextBoxStyleEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objTextBoxStyleEN.StylePosition + "'");
 }
 
 arrFieldListForInsert.Add(conTextBoxStyle.StyleTop);
 arrValueListForInsert.Add(objTextBoxStyleEN.StyleTop.ToString());
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TextBoxStyle");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:通过存储过程来插入记录
 /// (AutoGCLib.DALCode4CSharp:GenAddnewRecBySP)
 /// </summary>
 /// <param name = "objTextBoxStyleEN">需要添加到数据库中的对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddnewTextBoxStyleBySP(clsTextBoxStyleEN objTextBoxStyleEN)
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objTextBoxStyleEN.TextBoxStyleId,
 objTextBoxStyleEN.TextBoxStyleName,
 objTextBoxStyleEN.Style,
 objTextBoxStyleEN.Runat,
 objTextBoxStyleEN.FontSize,
 objTextBoxStyleEN.FontName,
 objTextBoxStyleEN.Width,
 objTextBoxStyleEN.Height,
 objTextBoxStyleEN.TextMode,
 objTextBoxStyleEN.ReadOnly,
 objTextBoxStyleEN.StyleZindex,
 objTextBoxStyleEN.StyleLeft,
 objTextBoxStyleEN.StylePosition,
objTextBoxStyleEN.StyleTop
};
 objSQL.ExecSP("TextBoxStyle_Add",values);
return true;
}

 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewTextBoxStyles(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
strSQL = "Select * from TextBoxStyle where TextBoxStyleId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "TextBoxStyle");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strTextBoxStyleId = oRow[conTextBoxStyle.TextBoxStyleId].ToString().Trim();
if (IsExist(strTextBoxStyleId))
{
 string strResult = "关键字变量值为:" + string.Format("TextBoxStyleId = {0}", strTextBoxStyleId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsTextBoxStyleEN._CurrTabName ].NewRow();
objRow[conTextBoxStyle.TextBoxStyleId] = oRow[conTextBoxStyle.TextBoxStyleId].ToString().Trim(); //TextBoxStyleId
objRow[conTextBoxStyle.TextBoxStyleName] = oRow[conTextBoxStyle.TextBoxStyleName].ToString().Trim(); //TextBoxStyleName
objRow[conTextBoxStyle.Style] = oRow[conTextBoxStyle.Style].ToString().Trim(); //类型
objRow[conTextBoxStyle.Runat] = oRow[conTextBoxStyle.Runat].ToString().Trim(); //运行在
objRow[conTextBoxStyle.FontSize] = oRow[conTextBoxStyle.FontSize].ToString().Trim(); //字号
objRow[conTextBoxStyle.FontName] = oRow[conTextBoxStyle.FontName].ToString().Trim(); //字体
objRow[conTextBoxStyle.Width] = oRow[conTextBoxStyle.Width].ToString().Trim(); //宽
objRow[conTextBoxStyle.Height] = oRow[conTextBoxStyle.Height].ToString().Trim(); //高度
objRow[conTextBoxStyle.TextMode] = oRow[conTextBoxStyle.TextMode].ToString().Trim(); //TextMode
objRow[conTextBoxStyle.ReadOnly] = oRow[conTextBoxStyle.ReadOnly].ToString().Trim(); //ReadOnly
objRow[conTextBoxStyle.StyleZindex] = oRow[conTextBoxStyle.StyleZindex].ToString().Trim(); //StyleZindex
objRow[conTextBoxStyle.StyleLeft] = oRow[conTextBoxStyle.StyleLeft].ToString().Trim(); //StyleLeft
objRow[conTextBoxStyle.StylePosition] = oRow[conTextBoxStyle.StylePosition].ToString().Trim(); //StylePosition
objRow[conTextBoxStyle.StyleTop] = oRow[conTextBoxStyle.StyleTop].ToString().Trim(); //StyleTop
 objDS.Tables[clsTextBoxStyleEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsTextBoxStyleEN._CurrTabName);
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
 /// <param name = "objTextBoxStyleEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsTextBoxStyleEN objTextBoxStyleEN)
{
 if (objTextBoxStyleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTextBoxStyleEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
strSQL = "Select * from TextBoxStyle where TextBoxStyleId = " + "'"+ objTextBoxStyleEN.TextBoxStyleId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsTextBoxStyleEN._CurrTabName);
if (objDS.Tables[clsTextBoxStyleEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:TextBoxStyleId = " + "'"+ objTextBoxStyleEN.TextBoxStyleId+"'");
return false;
}
objRow = objDS.Tables[clsTextBoxStyleEN._CurrTabName].Rows[0];
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.TextBoxStyleId))
 {
objRow[conTextBoxStyle.TextBoxStyleId] = objTextBoxStyleEN.TextBoxStyleId; //TextBoxStyleId
 }
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.TextBoxStyleName))
 {
objRow[conTextBoxStyle.TextBoxStyleName] = objTextBoxStyleEN.TextBoxStyleName; //TextBoxStyleName
 }
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.Style))
 {
objRow[conTextBoxStyle.Style] = objTextBoxStyleEN.Style; //类型
 }
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.Runat))
 {
objRow[conTextBoxStyle.Runat] = objTextBoxStyleEN.Runat; //运行在
 }
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.FontSize))
 {
objRow[conTextBoxStyle.FontSize] = objTextBoxStyleEN.FontSize; //字号
 }
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.FontName))
 {
objRow[conTextBoxStyle.FontName] = objTextBoxStyleEN.FontName; //字体
 }
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.Width))
 {
objRow[conTextBoxStyle.Width] = objTextBoxStyleEN.Width; //宽
 }
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.Height))
 {
objRow[conTextBoxStyle.Height] = objTextBoxStyleEN.Height; //高度
 }
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.TextMode))
 {
objRow[conTextBoxStyle.TextMode] = objTextBoxStyleEN.TextMode; //TextMode
 }
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.ReadOnly))
 {
objRow[conTextBoxStyle.ReadOnly] = objTextBoxStyleEN.ReadOnly; //ReadOnly
 }
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.StyleZindex))
 {
objRow[conTextBoxStyle.StyleZindex] = objTextBoxStyleEN.StyleZindex; //StyleZindex
 }
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.StyleLeft))
 {
objRow[conTextBoxStyle.StyleLeft] = objTextBoxStyleEN.StyleLeft; //StyleLeft
 }
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.StylePosition))
 {
objRow[conTextBoxStyle.StylePosition] = objTextBoxStyleEN.StylePosition; //StylePosition
 }
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.StyleTop))
 {
objRow[conTextBoxStyle.StyleTop] = objTextBoxStyleEN.StyleTop; //StyleTop
 }
try
{
objDA.Update(objDS, clsTextBoxStyleEN._CurrTabName);
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
public bool UpdateBySP(clsTextBoxStyleEN objTextBoxStyleEN)
{
 if (objTextBoxStyleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTextBoxStyleEN);
 }
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objTextBoxStyleEN.TextBoxStyleId,
 objTextBoxStyleEN.TextBoxStyleName,
 objTextBoxStyleEN.Style,
 objTextBoxStyleEN.Runat,
 objTextBoxStyleEN.FontSize,
 objTextBoxStyleEN.FontName,
 objTextBoxStyleEN.Width,
 objTextBoxStyleEN.Height,
 objTextBoxStyleEN.TextMode,
 objTextBoxStyleEN.ReadOnly,
 objTextBoxStyleEN.StyleZindex,
 objTextBoxStyleEN.StyleLeft,
 objTextBoxStyleEN.StylePosition,
 objTextBoxStyleEN.StyleTop
};
 objSQL.ExecSP("TextBoxStyle_Update",values);
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySql2)
 /// </summary>
 /// <param name = "objTextBoxStyleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsTextBoxStyleEN objTextBoxStyleEN)
{
 if (objTextBoxStyleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTextBoxStyleEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update TextBoxStyle Set ");
 
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.TextBoxStyleName))
 {
 if (objTextBoxStyleEN.TextBoxStyleName !=  null)
 {
 objTextBoxStyleEN.TextBoxStyleName = objTextBoxStyleEN.TextBoxStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objTextBoxStyleEN.TextBoxStyleName, conTextBoxStyle.TextBoxStyleName); //TextBoxStyleName
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTextBoxStyle.TextBoxStyleName); //TextBoxStyleName
 }
 }
 
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.Style))
 {
 if (objTextBoxStyleEN.Style !=  null)
 {
 objTextBoxStyleEN.Style = objTextBoxStyleEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objTextBoxStyleEN.Style, conTextBoxStyle.Style); //类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTextBoxStyle.Style); //类型
 }
 }
 
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.Runat))
 {
 if (objTextBoxStyleEN.Runat !=  null)
 {
 objTextBoxStyleEN.Runat = objTextBoxStyleEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objTextBoxStyleEN.Runat, conTextBoxStyle.Runat); //运行在
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTextBoxStyle.Runat); //运行在
 }
 }
 
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.FontSize))
 {
 if (objTextBoxStyleEN.FontSize !=  null)
 {
 objTextBoxStyleEN.FontSize = objTextBoxStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objTextBoxStyleEN.FontSize, conTextBoxStyle.FontSize); //字号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTextBoxStyle.FontSize); //字号
 }
 }
 
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.FontName))
 {
 if (objTextBoxStyleEN.FontName !=  null)
 {
 objTextBoxStyleEN.FontName = objTextBoxStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objTextBoxStyleEN.FontName, conTextBoxStyle.FontName); //字体
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTextBoxStyle.FontName); //字体
 }
 }
 
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.Width))
 {
 sbSQL.AppendFormat("{1} = {0},",objTextBoxStyleEN.Width, conTextBoxStyle.Width); //宽
 }
 
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.Height))
 {
 sbSQL.AppendFormat("{1} = {0},",objTextBoxStyleEN.Height, conTextBoxStyle.Height); //高度
 }
 
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.TextMode))
 {
 if (objTextBoxStyleEN.TextMode !=  null)
 {
 objTextBoxStyleEN.TextMode = objTextBoxStyleEN.TextMode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objTextBoxStyleEN.TextMode, conTextBoxStyle.TextMode); //TextMode
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTextBoxStyle.TextMode); //TextMode
 }
 }
 
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.ReadOnly))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTextBoxStyleEN.ReadOnly == true?"1":"0", conTextBoxStyle.ReadOnly); //ReadOnly
 }
 
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.StyleZindex))
 {
 sbSQL.AppendFormat("{1} = {0},",objTextBoxStyleEN.StyleZindex, conTextBoxStyle.StyleZindex); //StyleZindex
 }
 
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.StyleLeft))
 {
 sbSQL.AppendFormat("{1} = {0},",objTextBoxStyleEN.StyleLeft, conTextBoxStyle.StyleLeft); //StyleLeft
 }
 
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.StylePosition))
 {
 if (objTextBoxStyleEN.StylePosition !=  null)
 {
 objTextBoxStyleEN.StylePosition = objTextBoxStyleEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objTextBoxStyleEN.StylePosition, conTextBoxStyle.StylePosition); //StylePosition
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTextBoxStyle.StylePosition); //StylePosition
 }
 }
 
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.StyleTop))
 {
 sbSQL.AppendFormat("{1} = {0},",objTextBoxStyleEN.StyleTop, conTextBoxStyle.StyleTop); //StyleTop
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where TextBoxStyleId = '{0}'", objTextBoxStyleEN.TextBoxStyleId); 
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
 /// <param name = "objTextBoxStyleEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsTextBoxStyleEN objTextBoxStyleEN, string strCondition)
{
 if (objTextBoxStyleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTextBoxStyleEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update TextBoxStyle Set ");
 
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.TextBoxStyleName))
 {
 if (objTextBoxStyleEN.TextBoxStyleName !=  null)
 {
 objTextBoxStyleEN.TextBoxStyleName = objTextBoxStyleEN.TextBoxStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextBoxStyleName = '{0}',", objTextBoxStyleEN.TextBoxStyleName); //TextBoxStyleName
 }
 else
 {
 sbSQL.Append(" TextBoxStyleName = null,"); //TextBoxStyleName
 }
 }
 
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.Style))
 {
 if (objTextBoxStyleEN.Style !=  null)
 {
 objTextBoxStyleEN.Style = objTextBoxStyleEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Style = '{0}',", objTextBoxStyleEN.Style); //类型
 }
 else
 {
 sbSQL.Append(" Style = null,"); //类型
 }
 }
 
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.Runat))
 {
 if (objTextBoxStyleEN.Runat !=  null)
 {
 objTextBoxStyleEN.Runat = objTextBoxStyleEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Runat = '{0}',", objTextBoxStyleEN.Runat); //运行在
 }
 else
 {
 sbSQL.Append(" Runat = null,"); //运行在
 }
 }
 
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.FontSize))
 {
 if (objTextBoxStyleEN.FontSize !=  null)
 {
 objTextBoxStyleEN.FontSize = objTextBoxStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FontSize = '{0}',", objTextBoxStyleEN.FontSize); //字号
 }
 else
 {
 sbSQL.Append(" FontSize = null,"); //字号
 }
 }
 
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.FontName))
 {
 if (objTextBoxStyleEN.FontName !=  null)
 {
 objTextBoxStyleEN.FontName = objTextBoxStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FontName = '{0}',", objTextBoxStyleEN.FontName); //字体
 }
 else
 {
 sbSQL.Append(" FontName = null,"); //字体
 }
 }
 
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.Width))
 {
 sbSQL.AppendFormat(" Width = {0},", objTextBoxStyleEN.Width); //宽
 }
 
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.Height))
 {
 sbSQL.AppendFormat(" Height = {0},", objTextBoxStyleEN.Height); //高度
 }
 
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.TextMode))
 {
 if (objTextBoxStyleEN.TextMode !=  null)
 {
 objTextBoxStyleEN.TextMode = objTextBoxStyleEN.TextMode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextMode = '{0}',", objTextBoxStyleEN.TextMode); //TextMode
 }
 else
 {
 sbSQL.Append(" TextMode = null,"); //TextMode
 }
 }
 
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.ReadOnly))
 {
 sbSQL.AppendFormat(" ReadOnly = '{0}',", objTextBoxStyleEN.ReadOnly == true?"1":"0"); //ReadOnly
 }
 
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.StyleZindex))
 {
 sbSQL.AppendFormat(" StyleZindex = {0},", objTextBoxStyleEN.StyleZindex); //StyleZindex
 }
 
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.StyleLeft))
 {
 sbSQL.AppendFormat(" StyleLeft = {0},", objTextBoxStyleEN.StyleLeft); //StyleLeft
 }
 
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.StylePosition))
 {
 if (objTextBoxStyleEN.StylePosition !=  null)
 {
 objTextBoxStyleEN.StylePosition = objTextBoxStyleEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StylePosition = '{0}',", objTextBoxStyleEN.StylePosition); //StylePosition
 }
 else
 {
 sbSQL.Append(" StylePosition = null,"); //StylePosition
 }
 }
 
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.StyleTop))
 {
 sbSQL.AppendFormat(" StyleTop = {0},", objTextBoxStyleEN.StyleTop); //StyleTop
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
 /// <param name = "objTextBoxStyleEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsTextBoxStyleEN objTextBoxStyleEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objTextBoxStyleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTextBoxStyleEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update TextBoxStyle Set ");
 
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.TextBoxStyleName))
 {
 if (objTextBoxStyleEN.TextBoxStyleName !=  null)
 {
 objTextBoxStyleEN.TextBoxStyleName = objTextBoxStyleEN.TextBoxStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextBoxStyleName = '{0}',", objTextBoxStyleEN.TextBoxStyleName); //TextBoxStyleName
 }
 else
 {
 sbSQL.Append(" TextBoxStyleName = null,"); //TextBoxStyleName
 }
 }
 
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.Style))
 {
 if (objTextBoxStyleEN.Style !=  null)
 {
 objTextBoxStyleEN.Style = objTextBoxStyleEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Style = '{0}',", objTextBoxStyleEN.Style); //类型
 }
 else
 {
 sbSQL.Append(" Style = null,"); //类型
 }
 }
 
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.Runat))
 {
 if (objTextBoxStyleEN.Runat !=  null)
 {
 objTextBoxStyleEN.Runat = objTextBoxStyleEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Runat = '{0}',", objTextBoxStyleEN.Runat); //运行在
 }
 else
 {
 sbSQL.Append(" Runat = null,"); //运行在
 }
 }
 
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.FontSize))
 {
 if (objTextBoxStyleEN.FontSize !=  null)
 {
 objTextBoxStyleEN.FontSize = objTextBoxStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FontSize = '{0}',", objTextBoxStyleEN.FontSize); //字号
 }
 else
 {
 sbSQL.Append(" FontSize = null,"); //字号
 }
 }
 
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.FontName))
 {
 if (objTextBoxStyleEN.FontName !=  null)
 {
 objTextBoxStyleEN.FontName = objTextBoxStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FontName = '{0}',", objTextBoxStyleEN.FontName); //字体
 }
 else
 {
 sbSQL.Append(" FontName = null,"); //字体
 }
 }
 
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.Width))
 {
 sbSQL.AppendFormat(" Width = {0},", objTextBoxStyleEN.Width); //宽
 }
 
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.Height))
 {
 sbSQL.AppendFormat(" Height = {0},", objTextBoxStyleEN.Height); //高度
 }
 
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.TextMode))
 {
 if (objTextBoxStyleEN.TextMode !=  null)
 {
 objTextBoxStyleEN.TextMode = objTextBoxStyleEN.TextMode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextMode = '{0}',", objTextBoxStyleEN.TextMode); //TextMode
 }
 else
 {
 sbSQL.Append(" TextMode = null,"); //TextMode
 }
 }
 
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.ReadOnly))
 {
 sbSQL.AppendFormat(" ReadOnly = '{0}',", objTextBoxStyleEN.ReadOnly == true?"1":"0"); //ReadOnly
 }
 
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.StyleZindex))
 {
 sbSQL.AppendFormat(" StyleZindex = {0},", objTextBoxStyleEN.StyleZindex); //StyleZindex
 }
 
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.StyleLeft))
 {
 sbSQL.AppendFormat(" StyleLeft = {0},", objTextBoxStyleEN.StyleLeft); //StyleLeft
 }
 
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.StylePosition))
 {
 if (objTextBoxStyleEN.StylePosition !=  null)
 {
 objTextBoxStyleEN.StylePosition = objTextBoxStyleEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StylePosition = '{0}',", objTextBoxStyleEN.StylePosition); //StylePosition
 }
 else
 {
 sbSQL.Append(" StylePosition = null,"); //StylePosition
 }
 }
 
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.StyleTop))
 {
 sbSQL.AppendFormat(" StyleTop = {0},", objTextBoxStyleEN.StyleTop); //StyleTop
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
 /// <param name = "objTextBoxStyleEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsTextBoxStyleEN objTextBoxStyleEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objTextBoxStyleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTextBoxStyleEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update TextBoxStyle Set ");
 
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.TextBoxStyleName))
 {
 if (objTextBoxStyleEN.TextBoxStyleName !=  null)
 {
 objTextBoxStyleEN.TextBoxStyleName = objTextBoxStyleEN.TextBoxStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objTextBoxStyleEN.TextBoxStyleName, conTextBoxStyle.TextBoxStyleName); //TextBoxStyleName
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTextBoxStyle.TextBoxStyleName); //TextBoxStyleName
 }
 }
 
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.Style))
 {
 if (objTextBoxStyleEN.Style !=  null)
 {
 objTextBoxStyleEN.Style = objTextBoxStyleEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objTextBoxStyleEN.Style, conTextBoxStyle.Style); //类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTextBoxStyle.Style); //类型
 }
 }
 
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.Runat))
 {
 if (objTextBoxStyleEN.Runat !=  null)
 {
 objTextBoxStyleEN.Runat = objTextBoxStyleEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objTextBoxStyleEN.Runat, conTextBoxStyle.Runat); //运行在
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTextBoxStyle.Runat); //运行在
 }
 }
 
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.FontSize))
 {
 if (objTextBoxStyleEN.FontSize !=  null)
 {
 objTextBoxStyleEN.FontSize = objTextBoxStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objTextBoxStyleEN.FontSize, conTextBoxStyle.FontSize); //字号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTextBoxStyle.FontSize); //字号
 }
 }
 
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.FontName))
 {
 if (objTextBoxStyleEN.FontName !=  null)
 {
 objTextBoxStyleEN.FontName = objTextBoxStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objTextBoxStyleEN.FontName, conTextBoxStyle.FontName); //字体
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTextBoxStyle.FontName); //字体
 }
 }
 
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.Width))
 {
 sbSQL.AppendFormat("{1} = {0},",objTextBoxStyleEN.Width, conTextBoxStyle.Width); //宽
 }
 
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.Height))
 {
 sbSQL.AppendFormat("{1} = {0},",objTextBoxStyleEN.Height, conTextBoxStyle.Height); //高度
 }
 
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.TextMode))
 {
 if (objTextBoxStyleEN.TextMode !=  null)
 {
 objTextBoxStyleEN.TextMode = objTextBoxStyleEN.TextMode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objTextBoxStyleEN.TextMode, conTextBoxStyle.TextMode); //TextMode
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTextBoxStyle.TextMode); //TextMode
 }
 }
 
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.ReadOnly))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTextBoxStyleEN.ReadOnly == true?"1":"0", conTextBoxStyle.ReadOnly); //ReadOnly
 }
 
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.StyleZindex))
 {
 sbSQL.AppendFormat("{1} = {0},",objTextBoxStyleEN.StyleZindex, conTextBoxStyle.StyleZindex); //StyleZindex
 }
 
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.StyleLeft))
 {
 sbSQL.AppendFormat("{1} = {0},",objTextBoxStyleEN.StyleLeft, conTextBoxStyle.StyleLeft); //StyleLeft
 }
 
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.StylePosition))
 {
 if (objTextBoxStyleEN.StylePosition !=  null)
 {
 objTextBoxStyleEN.StylePosition = objTextBoxStyleEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objTextBoxStyleEN.StylePosition, conTextBoxStyle.StylePosition); //StylePosition
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTextBoxStyle.StylePosition); //StylePosition
 }
 }
 
 if (objTextBoxStyleEN.IsUpdated(conTextBoxStyle.StyleTop))
 {
 sbSQL.AppendFormat("{1} = {0},",objTextBoxStyleEN.StyleTop, conTextBoxStyle.StyleTop); //StyleTop
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where TextBoxStyleId = '{0}'", objTextBoxStyleEN.TextBoxStyleId); 
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
 /// <param name = "strTextBoxStyleId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strTextBoxStyleId) 
{
CheckPrimaryKey(strTextBoxStyleId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strTextBoxStyleId,
};
 objSQL.ExecSP("TextBoxStyle_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strTextBoxStyleId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strTextBoxStyleId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strTextBoxStyleId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
//删除TextBoxStyle本表中与当前对象有关的记录
strSQL = strSQL + "Delete from TextBoxStyle where TextBoxStyleId = " + "'"+ strTextBoxStyleId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelTextBoxStyle(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
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
//删除TextBoxStyle本表中与当前对象有关的记录
strSQL = strSQL + "Delete from TextBoxStyle where TextBoxStyleId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strTextBoxStyleId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strTextBoxStyleId) 
{
CheckPrimaryKey(strTextBoxStyleId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
//删除TextBoxStyle本表中与当前对象有关的记录
strSQL = strSQL + "Delete from TextBoxStyle where TextBoxStyleId = " + "'"+ strTextBoxStyleId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelTextBoxStyle(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsTextBoxStyleDA: DelTextBoxStyle)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from TextBoxStyle where " + strCondition ;
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
public bool DelTextBoxStyleWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsTextBoxStyleDA: DelTextBoxStyleWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from TextBoxStyle where " + strCondition ;
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
 /// <param name = "objTextBoxStyleENS">源对象</param>
 /// <param name = "objTextBoxStyleENT">目标对象</param>
public void CopyTo(clsTextBoxStyleEN objTextBoxStyleENS, clsTextBoxStyleEN objTextBoxStyleENT)
{
objTextBoxStyleENT.TextBoxStyleId = objTextBoxStyleENS.TextBoxStyleId; //TextBoxStyleId
objTextBoxStyleENT.TextBoxStyleName = objTextBoxStyleENS.TextBoxStyleName; //TextBoxStyleName
objTextBoxStyleENT.Style = objTextBoxStyleENS.Style; //类型
objTextBoxStyleENT.Runat = objTextBoxStyleENS.Runat; //运行在
objTextBoxStyleENT.FontSize = objTextBoxStyleENS.FontSize; //字号
objTextBoxStyleENT.FontName = objTextBoxStyleENS.FontName; //字体
objTextBoxStyleENT.Width = objTextBoxStyleENS.Width; //宽
objTextBoxStyleENT.Height = objTextBoxStyleENS.Height; //高度
objTextBoxStyleENT.TextMode = objTextBoxStyleENS.TextMode; //TextMode
objTextBoxStyleENT.ReadOnly = objTextBoxStyleENS.ReadOnly; //ReadOnly
objTextBoxStyleENT.StyleZindex = objTextBoxStyleENS.StyleZindex; //StyleZindex
objTextBoxStyleENT.StyleLeft = objTextBoxStyleENS.StyleLeft; //StyleLeft
objTextBoxStyleENT.StylePosition = objTextBoxStyleENS.StylePosition; //StylePosition
objTextBoxStyleENT.StyleTop = objTextBoxStyleENS.StyleTop; //StyleTop
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsTextBoxStyleEN objTextBoxStyleEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objTextBoxStyleEN.TextBoxStyleName, conTextBoxStyle.TextBoxStyleName);
clsCheckSql.CheckFieldNotNull(objTextBoxStyleEN.TextMode, conTextBoxStyle.TextMode);
clsCheckSql.CheckFieldNotNull(objTextBoxStyleEN.ReadOnly, conTextBoxStyle.ReadOnly);
//检查字段长度
clsCheckSql.CheckFieldLen(objTextBoxStyleEN.TextBoxStyleId, 4, conTextBoxStyle.TextBoxStyleId);
clsCheckSql.CheckFieldLen(objTextBoxStyleEN.TextBoxStyleName, 30, conTextBoxStyle.TextBoxStyleName);
clsCheckSql.CheckFieldLen(objTextBoxStyleEN.Style, 800, conTextBoxStyle.Style);
clsCheckSql.CheckFieldLen(objTextBoxStyleEN.Runat, 30, conTextBoxStyle.Runat);
clsCheckSql.CheckFieldLen(objTextBoxStyleEN.FontSize, 20, conTextBoxStyle.FontSize);
clsCheckSql.CheckFieldLen(objTextBoxStyleEN.FontName, 20, conTextBoxStyle.FontName);
clsCheckSql.CheckFieldLen(objTextBoxStyleEN.TextMode, 20, conTextBoxStyle.TextMode);
clsCheckSql.CheckFieldLen(objTextBoxStyleEN.StylePosition, 20, conTextBoxStyle.StylePosition);
//检查字段外键固定长度
 objTextBoxStyleEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsTextBoxStyleEN objTextBoxStyleEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objTextBoxStyleEN.TextBoxStyleName, 30, conTextBoxStyle.TextBoxStyleName);
clsCheckSql.CheckFieldLen(objTextBoxStyleEN.Style, 800, conTextBoxStyle.Style);
clsCheckSql.CheckFieldLen(objTextBoxStyleEN.Runat, 30, conTextBoxStyle.Runat);
clsCheckSql.CheckFieldLen(objTextBoxStyleEN.FontSize, 20, conTextBoxStyle.FontSize);
clsCheckSql.CheckFieldLen(objTextBoxStyleEN.FontName, 20, conTextBoxStyle.FontName);
clsCheckSql.CheckFieldLen(objTextBoxStyleEN.TextMode, 20, conTextBoxStyle.TextMode);
clsCheckSql.CheckFieldLen(objTextBoxStyleEN.StylePosition, 20, conTextBoxStyle.StylePosition);
//检查外键字段长度
 objTextBoxStyleEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsTextBoxStyleEN objTextBoxStyleEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objTextBoxStyleEN.TextBoxStyleId, 4, conTextBoxStyle.TextBoxStyleId);
clsCheckSql.CheckFieldLen(objTextBoxStyleEN.TextBoxStyleName, 30, conTextBoxStyle.TextBoxStyleName);
clsCheckSql.CheckFieldLen(objTextBoxStyleEN.Style, 800, conTextBoxStyle.Style);
clsCheckSql.CheckFieldLen(objTextBoxStyleEN.Runat, 30, conTextBoxStyle.Runat);
clsCheckSql.CheckFieldLen(objTextBoxStyleEN.FontSize, 20, conTextBoxStyle.FontSize);
clsCheckSql.CheckFieldLen(objTextBoxStyleEN.FontName, 20, conTextBoxStyle.FontName);
clsCheckSql.CheckFieldLen(objTextBoxStyleEN.TextMode, 20, conTextBoxStyle.TextMode);
clsCheckSql.CheckFieldLen(objTextBoxStyleEN.StylePosition, 20, conTextBoxStyle.StylePosition);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objTextBoxStyleEN.TextBoxStyleId, conTextBoxStyle.TextBoxStyleId);
clsCheckSql.CheckSqlInjection4Field(objTextBoxStyleEN.TextBoxStyleName, conTextBoxStyle.TextBoxStyleName);
clsCheckSql.CheckSqlInjection4Field(objTextBoxStyleEN.Style, conTextBoxStyle.Style);
clsCheckSql.CheckSqlInjection4Field(objTextBoxStyleEN.Runat, conTextBoxStyle.Runat);
clsCheckSql.CheckSqlInjection4Field(objTextBoxStyleEN.FontSize, conTextBoxStyle.FontSize);
clsCheckSql.CheckSqlInjection4Field(objTextBoxStyleEN.FontName, conTextBoxStyle.FontName);
clsCheckSql.CheckSqlInjection4Field(objTextBoxStyleEN.TextMode, conTextBoxStyle.TextMode);
clsCheckSql.CheckSqlInjection4Field(objTextBoxStyleEN.StylePosition, conTextBoxStyle.StylePosition);
//检查外键字段长度
 objTextBoxStyleEN._IsCheckProperty = true;
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
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
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
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
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
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsTextBoxStyleEN._CurrTabName);
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
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsTextBoxStyleEN._CurrTabName, strCondition);
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
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
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
 objSQL = clsTextBoxStyleDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}