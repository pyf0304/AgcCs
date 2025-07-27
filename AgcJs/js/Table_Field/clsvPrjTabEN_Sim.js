
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjTabEN_Sim
 表名:vPrjTab
 生成代码版本:2017.07.08.1
 生成日期:2017/07/11 06:31:18
 生成者:
 生成服务器IP:211.144.85.77
 工程名称:AGC_CSV7
 工程ID:0005
 模块中文名:字段、表维护
 模块英文名:Table_Field
 框架-层名:实体层-简化
 编程语言:JavaScript
 注意:1、需要数据底层(PubDataBase.dll)的版本:2017.06.19.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2016.12.13.01
 == == == == == == == == == == == == 
 */
package .Entity;
import java.sql.*;
import java.sql.Date;
import java.util.*; 
import com.taishsoft.commdb.*;
import com.taishsoft.commexception.*;
{
 /// <summary>
 /// v工程表(vPrjTab)
 /// (AutoGCLib.AutoGC6Js_M:A_GenEntityLayerCode_Sim)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvPrjTabEN_Sim 
{
//以下是属性变量

private String mstrTabId;    //表ID
private int mintFldNum;    //FldNum
private String mstrGeneCodeDate;    //生成代码日期
private boolean mbolIsNeedGene;    //是否需要生成
private String mstrTabName;    //表名
private String mstrTabEnName;    //表英文详细名
private String mstrTabCnName;    //表中文名
private String mstrPrjId;    //工程ID
private String mstrPrjName;    //工程名称
private boolean mbolIsNeedTransCode;    //是否需要转换代码
private String mstrSQLDSTypeId;    //数据源类型
private String mstrSqlDsTypeName;    //Sql数据源名
private String mstrTabStateId;    //表状态ID
private String mstrTabStateName;    //表状态名称
private String mstrTabName_B;    //表名_后备
private boolean mbolIsParaTab;    //是否参数表
private boolean mbolIsNationStandard;    //是否国标
private boolean mbolIsArchive;    //是否存档
private boolean mbolIsChecked;    //是否核实
private String mstrErrMsg;    //错误信息
private String mstrFuncModuleAgcId;    //功能模块Id
private String mstrFuncModuleName;    //功能模块名称
private String mstrFuncModuleEnName;    //功能模块英文名称
private String mstrOwner;    //拥有者
private boolean mbolIsReleToSqlTab;    //是否与SQL表相关
private String mstrKeyword;    //关键字
private String mstrTabTypeId;    //表类型Id
private String mstrTabTypeName;    //表类型名
private String mstrRelaTabId4View;    //视图的相关表ID
private boolean mbolIsNeedCheckTab;    //是否需要检查表字段
private int mintOrderNum4Refer;    //引用序号
private boolean mbolIsNeedGeneIndexer;    //是否需要生成索引器
private String mstrKeyFldIds;    //关键字Id列表
private String mstrKeyFldNames;    //关键字名称列表
private String mstrPrimaryTypeId;    //主键类型ID
private String mstrPrimaryTypeName;    //主键类型名
private String mstrUpdUserId;    //修改用户Id
private String mstrUpdDate;    //修改日期
private String mstrMemo;    //说明
private String mstrDataBaseName_Tab;    //DataBaseName_Tab
private String mstrRelaTabName4View;    //RelaTabName4View
private String mstrUpdDate2;    //UpdDate2
var sf_UpdFldSetStr;    //系统字段_修改字段集合串


/// <summary>
/// 表ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getTabId = function()
{
return this.TabId;
}
/// <summary>
/// 表ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setTabId = function(value)
{
 this.TabId = value;
    this.hmProperty.add("TabId", "true");
}

/// <summary>
/// FldNum(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getFldNum = function()
{
return this.FldNum;
}
/// <summary>
/// FldNum(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setFldNum = function(value)
{
 this.FldNum = value;
    this.hmProperty.add("FldNum", "true");
}

/// <summary>
/// 生成代码日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getGeneCodeDate = function()
{
return this.GeneCodeDate;
}
/// <summary>
/// 生成代码日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setGeneCodeDate = function(value)
{
 this.GeneCodeDate = value;
    this.hmProperty.add("GeneCodeDate", "true");
}

/// <summary>
/// 是否需要生成(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getIsNeedGene = function()
{
return this.IsNeedGene;
}
/// <summary>
/// 是否需要生成(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setIsNeedGene = function(value)
{
 this.IsNeedGene = value;
    this.hmProperty.add("IsNeedGene", "true");
}

/// <summary>
/// 表名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getTabName = function()
{
return this.TabName;
}
/// <summary>
/// 表名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setTabName = function(value)
{
 this.TabName = value;
    this.hmProperty.add("TabName", "true");
}

/// <summary>
/// 表英文详细名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getTabEnName = function()
{
return this.TabEnName;
}
/// <summary>
/// 表英文详细名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setTabEnName = function(value)
{
 this.TabEnName = value;
    this.hmProperty.add("TabEnName", "true");
}

/// <summary>
/// 表中文名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getTabCnName = function()
{
return this.TabCnName;
}
/// <summary>
/// 表中文名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setTabCnName = function(value)
{
 this.TabCnName = value;
    this.hmProperty.add("TabCnName", "true");
}

/// <summary>
/// 工程ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getPrjId = function()
{
return this.PrjId;
}
/// <summary>
/// 工程ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setPrjId = function(value)
{
 this.PrjId = value;
    this.hmProperty.add("PrjId", "true");
}

/// <summary>
/// 工程名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getPrjName = function()
{
return this.PrjName;
}
/// <summary>
/// 工程名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setPrjName = function(value)
{
 this.PrjName = value;
    this.hmProperty.add("PrjName", "true");
}

/// <summary>
/// 是否需要转换代码(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getIsNeedTransCode = function()
{
return this.IsNeedTransCode;
}
/// <summary>
/// 是否需要转换代码(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setIsNeedTransCode = function(value)
{
 this.IsNeedTransCode = value;
    this.hmProperty.add("IsNeedTransCode", "true");
}

/// <summary>
/// 数据源类型(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getSQLDSTypeId = function()
{
return this.SQLDSTypeId;
}
/// <summary>
/// 数据源类型(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setSQLDSTypeId = function(value)
{
 this.SQLDSTypeId = value;
    this.hmProperty.add("SQLDSTypeId", "true");
}

/// <summary>
/// Sql数据源名(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getSqlDsTypeName = function()
{
return this.SqlDsTypeName;
}
/// <summary>
/// Sql数据源名(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setSqlDsTypeName = function(value)
{
 this.SqlDsTypeName = value;
    this.hmProperty.add("SqlDsTypeName", "true");
}

/// <summary>
/// 表状态ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getTabStateId = function()
{
return this.TabStateId;
}
/// <summary>
/// 表状态ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setTabStateId = function(value)
{
 this.TabStateId = value;
    this.hmProperty.add("TabStateId", "true");
}

/// <summary>
/// 表状态名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getTabStateName = function()
{
return this.TabStateName;
}
/// <summary>
/// 表状态名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setTabStateName = function(value)
{
 this.TabStateName = value;
    this.hmProperty.add("TabStateName", "true");
}

/// <summary>
/// 表名_后备(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getTabName_B = function()
{
return this.TabName_B;
}
/// <summary>
/// 表名_后备(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setTabName_B = function(value)
{
 this.TabName_B = value;
    this.hmProperty.add("TabName_B", "true");
}

/// <summary>
/// 是否参数表(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getIsParaTab = function()
{
return this.IsParaTab;
}
/// <summary>
/// 是否参数表(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setIsParaTab = function(value)
{
 this.IsParaTab = value;
    this.hmProperty.add("IsParaTab", "true");
}

/// <summary>
/// 是否国标(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getIsNationStandard = function()
{
return this.IsNationStandard;
}
/// <summary>
/// 是否国标(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setIsNationStandard = function(value)
{
 this.IsNationStandard = value;
    this.hmProperty.add("IsNationStandard", "true");
}

/// <summary>
/// 是否存档(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getIsArchive = function()
{
return this.IsArchive;
}
/// <summary>
/// 是否存档(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setIsArchive = function(value)
{
 this.IsArchive = value;
    this.hmProperty.add("IsArchive", "true");
}

/// <summary>
/// 是否核实(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getIsChecked = function()
{
return this.IsChecked;
}
/// <summary>
/// 是否核实(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setIsChecked = function(value)
{
 this.IsChecked = value;
    this.hmProperty.add("IsChecked", "true");
}

/// <summary>
/// 错误信息(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getErrMsg = function()
{
return this.ErrMsg;
}
/// <summary>
/// 错误信息(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setErrMsg = function(value)
{
 this.ErrMsg = value;
    this.hmProperty.add("ErrMsg", "true");
}

/// <summary>
/// 功能模块Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getFuncModuleAgcId = function()
{
return this.FuncModuleAgcId;
}
/// <summary>
/// 功能模块Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setFuncModuleAgcId = function(value)
{
 this.FuncModuleAgcId = value;
    this.hmProperty.add("FuncModuleAgcId", "true");
}

/// <summary>
/// 功能模块名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getFuncModuleName = function()
{
return this.FuncModuleName;
}
/// <summary>
/// 功能模块名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setFuncModuleName = function(value)
{
 this.FuncModuleName = value;
    this.hmProperty.add("FuncModuleName", "true");
}

/// <summary>
/// 功能模块英文名称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getFuncModuleEnName = function()
{
return this.FuncModuleEnName;
}
/// <summary>
/// 功能模块英文名称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setFuncModuleEnName = function(value)
{
 this.FuncModuleEnName = value;
    this.hmProperty.add("FuncModuleEnName", "true");
}

/// <summary>
/// 拥有者(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getOwner = function()
{
return this.Owner;
}
/// <summary>
/// 拥有者(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setOwner = function(value)
{
 this.Owner = value;
    this.hmProperty.add("Owner", "true");
}

/// <summary>
/// 是否与SQL表相关(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getIsReleToSqlTab = function()
{
return this.IsReleToSqlTab;
}
/// <summary>
/// 是否与SQL表相关(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setIsReleToSqlTab = function(value)
{
 this.IsReleToSqlTab = value;
    this.hmProperty.add("IsReleToSqlTab", "true");
}

/// <summary>
/// 关键字(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getKeyword = function()
{
return this.KeyWord;
}
/// <summary>
/// 关键字(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setKeyword = function(value)
{
 this.KeyWord = value;
    this.hmProperty.add("KeyWord", "true");
}

/// <summary>
/// 表类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getTabTypeId = function()
{
return this.TabTypeId;
}
/// <summary>
/// 表类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setTabTypeId = function(value)
{
 this.TabTypeId = value;
    this.hmProperty.add("TabTypeId", "true");
}

/// <summary>
/// 表类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getTabTypeName = function()
{
return this.TabTypeName;
}
/// <summary>
/// 表类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setTabTypeName = function(value)
{
 this.TabTypeName = value;
    this.hmProperty.add("TabTypeName", "true");
}

/// <summary>
/// 视图的相关表ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getRelaTabId4View = function()
{
return this.RelaTabId4View;
}
/// <summary>
/// 视图的相关表ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setRelaTabId4View = function(value)
{
 this.RelaTabId4View = value;
    this.hmProperty.add("RelaTabId4View", "true");
}

/// <summary>
/// 是否需要检查表字段(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getIsNeedCheckTab = function()
{
return this.IsNeedCheckTab;
}
/// <summary>
/// 是否需要检查表字段(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setIsNeedCheckTab = function(value)
{
 this.IsNeedCheckTab = value;
    this.hmProperty.add("IsNeedCheckTab", "true");
}

/// <summary>
/// 引用序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getOrderNum4Refer = function()
{
return this.OrderNum4Refer;
}
/// <summary>
/// 引用序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setOrderNum4Refer = function(value)
{
 this.OrderNum4Refer = value;
    this.hmProperty.add("OrderNum4Refer", "true");
}

/// <summary>
/// 是否需要生成索引器(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getIsNeedGeneIndexer = function()
{
return this.IsNeedGeneIndexer;
}
/// <summary>
/// 是否需要生成索引器(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setIsNeedGeneIndexer = function(value)
{
 this.IsNeedGeneIndexer = value;
    this.hmProperty.add("IsNeedGeneIndexer", "true");
}

/// <summary>
/// 关键字Id列表(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getKeyFldIds = function()
{
return this.KeyFldIds;
}
/// <summary>
/// 关键字Id列表(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setKeyFldIds = function(value)
{
 this.KeyFldIds = value;
    this.hmProperty.add("KeyFldIds", "true");
}

/// <summary>
/// 关键字名称列表(说明:;字段类型:varchar;字段长度:300;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getKeyFldNames = function()
{
return this.KeyFldNames;
}
/// <summary>
/// 关键字名称列表(说明:;字段类型:varchar;字段长度:300;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setKeyFldNames = function(value)
{
 this.KeyFldNames = value;
    this.hmProperty.add("KeyFldNames", "true");
}

/// <summary>
/// 主键类型ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getPrimaryTypeId = function()
{
return this.PrimaryTypeId;
}
/// <summary>
/// 主键类型ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setPrimaryTypeId = function(value)
{
 this.PrimaryTypeId = value;
    this.hmProperty.add("PrimaryTypeId", "true");
}

/// <summary>
/// 主键类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getPrimaryTypeName = function()
{
return this.PrimaryTypeName;
}
/// <summary>
/// 主键类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setPrimaryTypeName = function(value)
{
 this.PrimaryTypeName = value;
    this.hmProperty.add("PrimaryTypeName", "true");
}

/// <summary>
/// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getUpdUserId = function()
{
return this.UpdUserId;
}
/// <summary>
/// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setUpdUserId = function(value)
{
 this.UpdUserId = value;
    this.hmProperty.add("UpdUserId", "true");
}

/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getUpdDate = function()
{
return this.UpdDate;
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setUpdDate = function(value)
{
 this.UpdDate = value;
    this.hmProperty.add("UpdDate", "true");
}

/// <summary>
/// 说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getMemo = function()
{
return this.Memo;
}
/// <summary>
/// 说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setMemo = function(value)
{
 this.Memo = value;
    this.hmProperty.add("Memo", "true");
}

/// <summary>
/// DataBaseName_Tab(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getDataBaseName_Tab = function()
{
return this.DataBaseName_Tab;
}
/// <summary>
/// DataBaseName_Tab(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setDataBaseName_Tab = function(value)
{
 this.DataBaseName_Tab = value;
    this.hmProperty.add("DataBaseName_Tab", "true");
}

/// <summary>
/// RelaTabName4View(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getRelaTabName4View = function()
{
return this.RelaTabName4View;
}
/// <summary>
/// RelaTabName4View(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setRelaTabName4View = function(value)
{
 this.RelaTabName4View = value;
    this.hmProperty.add("RelaTabName4View", "true");
}

/// <summary>
/// UpdDate2(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getUpdDate2 = function()
{
return this.UpdDate2;
}
/// <summary>
/// UpdDate2(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setUpdDate2 = function(value)
{
 this.UpdDate2 = value;
    this.hmProperty.add("UpdDate2", "true");
}

/// <summary>
/// 系统字段_修改字段集合串(说明:;字段类型:str;字段长度:4;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getsf_UpdFldSetStr = function()
{
return this.sf_UpdFldSetStr;
}
/// <summary>
/// 系统字段_修改字段集合串(说明:;字段类型:str;字段长度:4;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setsf_UpdFldSetStr = function(value)
{
 this.sf_UpdFldSetStr = value;
    this.hmProperty.add("sf_UpdFldSetStr", "true");
}
}
}