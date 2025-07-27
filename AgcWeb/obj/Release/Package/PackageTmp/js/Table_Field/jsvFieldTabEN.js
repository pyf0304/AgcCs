
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvFieldTabEN
表名:vFieldTab
生成代码版本:2017.07.08.1
生成日期:2017/07/09 15:40:11
生成者:
生成服务器IP:1011.251.68.133
工程名称:AGC
工程ID:0005
模块中文名:字段、表维护
模块英文名:Table_Field
框架-层名:实体层
编程语言:JavaScript
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.06.19.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2016.12.13.01
== == == == == == == == == == == == 
*/
/// <summary>
/// vFieldTab(vFieldTab)
/// (AutoGCLib.AutoGC6Js_M:A_GenEntityLayerCode)
/// </summary>
/// <reference path="../PubFun/jsGeneralTab.js" />
var VirtualRootPath = getVirtualRootPath_web();//该函数存在于/js/PubFun/jsPubFun.js文件中
include(VirtualRootPath + "/js/PubFun/jsGeneralTab.js");
var clsvFieldTabEN = function (strFldID) {
    clsvFieldTabEN.prototype = new clsGeneralTab();
    clsGeneralTab.call(this);
    this.FldId = strFldID || "";
    var CurrTabName_S = "vFieldTab"; //当前表名,与该类相关的表名
    var CurrTabKeyFldName_S = "FldId"; //当前表中的关键字名称,与该类相关的表中关键字名
    var mintAttributeCount = 39;
    var AttributeName = new Array("FldId", "TabNum", "PrjId", "PrjName", "FldName", "FldCnName", "FldName_B", "FldName_G", "Caption", "DataTypeId", "DataTypeName", "OraDbType", "FldLength", "FldPrecision", "FldInfo", "IsNull", "IsPrimaryKey", "IsIdentity", "IsNationStandard", "IsChecked", "IsArchive", "IsOnlyOne", "MaxValue", "MinValue", "DefaultValue", "IsNeedTransCode", "UserId", "AppliedScope", "FldStateId", "CodeTabId", "CodeTab_CodeId", "CodeTab_NameId", "UpdDate", "Memo", "CodeTab", "CodeTab_Name", "CodeTab_Code", "FldBName_B");
    //以下是属性变量

    var FldId;    //字段ID
    var TabNum;    //TabNum
    var PrjId;    //工程ID
    var PrjName;    //工程名称
    var FldName;    //字段名
    var FldCnName;    //字段中文详名
    
    var FldName_B;    //字段名_后备
    var FldName_G;    //字段名_国标
    var Caption;    //标题
    var DataTypeId;    //数据类型Id
    var DataTypeName;    //数据类型名称
    var OraDbType;    //Ora数据类型
    var FldLength;    //字段长度
    var FldPrecision;    //精确度
    var FldInfo;    //字段信息
    var IsNull;    //是否可空
    var IsPrimaryKey;    //是否主键
    var IsIdentity;    //是否Identity
    var IsNationStandard;    //是否国标
    var IsChecked;    //是否核实
    var IsArchive;    //是否存档
    var IsOnlyOne;    //是否唯一
    var MaxValue;    //最大值
    var MinValue;    //最小值
    var DefaultValue;    //缺省值
    var IsNeedTransCode;    //是否需要转换代码
    var UserId;    //用户ID
    var AppliedScope;    //应用范围
    var FldStateId;    //字段状态Id
    var CodeTabId;    //CodeTabId
    var CodeTab_CodeId;    //CodeTab_CodeId
    var CodeTab_NameId;    //CodeTab_NameId
    var UpdDate;    //修改日期
    var Memo;    //说明
    var CodeTab;    //代码表
    var CodeTab_Name;    //代码表_名称
    var CodeTab_Code;    //代码表_代码
    var FldBName_B;    //FldBName_B


    /// <summary>
    /// 常量:"FldId"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    var con_FldId = "FldId";    //字段ID

    /// <summary>
    /// 常量:"TabNum"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    var con_TabNum = "TabNum";    //TabNum

    /// <summary>
    /// 常量:"PrjId"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    var con_PrjId = "PrjId";    //工程ID

    /// <summary>
    /// 常量:"PrjName"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    var con_PrjName = "PrjName";    //工程名称

    /// <summary>
    /// 常量:"FldName"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    var con_FldName = "FldName";    //字段名

    /// <summary>
    /// 常量:"FldCnName"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    var con_FldCnName = "FldCnName";    //字段中文详名

    
    /// <summary>
    /// 常量:"FldName_B"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    var con_FldName_B = "FldName_B";    //字段名_后备

    /// <summary>
    /// 常量:"FldName_G"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    var con_FldName_G = "FldName_G";    //字段名_国标

    /// <summary>
    /// 常量:"Caption"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    var con_Caption = "Caption";    //标题

    /// <summary>
    /// 常量:"DataTypeId"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    var con_DataTypeId = "DataTypeId";    //数据类型Id

    /// <summary>
    /// 常量:"DataTypeName"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    var con_DataTypeName = "DataTypeName";    //数据类型名称

    /// <summary>
    /// 常量:"OraDbType"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    var con_OraDbType = "OraDbType";    //Ora数据类型

    /// <summary>
    /// 常量:"FldLength"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    var con_FldLength = "FldLength";    //字段长度

    /// <summary>
    /// 常量:"FldPrecision"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    var con_FldPrecision = "FldPrecision";    //精确度

    /// <summary>
    /// 常量:"FldInfo"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    var con_FldInfo = "FldInfo";    //字段信息

    /// <summary>
    /// 常量:"IsNull"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    var con_IsNull = "IsNull";    //是否可空

    /// <summary>
    /// 常量:"IsPrimaryKey"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    var con_IsPrimaryKey = "IsPrimaryKey";    //是否主键

    /// <summary>
    /// 常量:"IsIdentity"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    var con_IsIdentity = "IsIdentity";    //是否Identity

    /// <summary>
    /// 常量:"IsNationStandard"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    var con_IsNationStandard = "IsNationStandard";    //是否国标

    /// <summary>
    /// 常量:"IsChecked"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    var con_IsChecked = "IsChecked";    //是否核实

    /// <summary>
    /// 常量:"IsArchive"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    var con_IsArchive = "IsArchive";    //是否存档

    /// <summary>
    /// 常量:"IsOnlyOne"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    var con_IsOnlyOne = "IsOnlyOne";    //是否唯一

    /// <summary>
    /// 常量:"MaxValue"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    var con_MaxValue = "MaxValue";    //最大值

    /// <summary>
    /// 常量:"MinValue"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    var con_MinValue = "MinValue";    //最小值

    /// <summary>
    /// 常量:"DefaultValue"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    var con_DefaultValue = "DefaultValue";    //缺省值

    /// <summary>
    /// 常量:"IsNeedTransCode"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    var con_IsNeedTransCode = "IsNeedTransCode";    //是否需要转换代码

    /// <summary>
    /// 常量:"UserId"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    var con_UserId = "UserId";    //用户ID

    /// <summary>
    /// 常量:"AppliedScope"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    var con_AppliedScope = "AppliedScope";    //应用范围

    /// <summary>
    /// 常量:"FldStateId"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    var con_FldStateId = "FldStateId";    //字段状态Id

    /// <summary>
    /// 常量:"CodeTabId"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    var con_CodeTabId = "CodeTabId";    //CodeTabId

    /// <summary>
    /// 常量:"CodeTab_CodeId"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    var con_CodeTab_CodeId = "CodeTab_CodeId";    //CodeTab_CodeId

    /// <summary>
    /// 常量:"CodeTab_NameId"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    var con_CodeTab_NameId = "CodeTab_NameId";    //CodeTab_NameId

    /// <summary>
    /// 常量:"UpdDate"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    var con_UpdDate = "UpdDate";    //修改日期

    /// <summary>
    /// 常量:"Memo"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    var con_Memo = "Memo";    //说明

    /// <summary>
    /// 常量:"CodeTab"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    var con_CodeTab = "CodeTab";    //代码表

    /// <summary>
    /// 常量:"CodeTab_Name"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    var con_CodeTab_Name = "CodeTab_Name";    //代码表_名称

    /// <summary>
    /// 常量:"CodeTab_Code"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    var con_CodeTab_Code = "CodeTab_Code";    //代码表_代码

    /// <summary>
    /// 常量:"FldBName_B"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    var con_FldBName_B = "FldBName_B";    //FldBName_B

    /// <summary>
    /// 构造函数
    /// (AutoGCLib.AutoGCPubFuncV6:GenClassConstructor1_JavaScript)
    /// </summary>
    this.init = function () {
        this.hmProperty = new Dictionary();
        this.SetInit();
        CurrTabName = "vFieldTab";
        KeyFldName = "FldId";
    }


    /// <summary>
    /// 字段ID(说明:;字段类型:char;字段长度:8;是否可空:False)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.getFldID = function () {
        return this.FldId;
    }
    /// <summary>
    /// 字段ID(说明:;字段类型:char;字段长度:8;是否可空:False)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.setFldID = function (value) {
        this.FldId = value;
        this.hmProperty.add("FldId", "true");
    }

    /// <summary>
    /// TabNum(说明:;字段类型:int;字段长度:4;是否可空:True)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.getTabNum = function () {
        return this.TabNum;
    }
    /// <summary>
    /// TabNum(说明:;字段类型:int;字段长度:4;是否可空:True)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.setTabNum = function (value) {
        this.TabNum = value;
        this.hmProperty.add("TabNum", "true");
    }

    /// <summary>
    /// 工程ID(说明:;字段类型:char;字段长度:4;是否可空:False)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.getPrjId = function () {
        return this.PrjId;
    }
    /// <summary>
    /// 工程ID(说明:;字段类型:char;字段长度:4;是否可空:False)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.setPrjId = function (value) {
        this.PrjId = value;
        this.hmProperty.add("PrjId", "true");
    }

    /// <summary>
    /// 工程名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.getPrjName = function () {
        return this.PrjName;
    }
    /// <summary>
    /// 工程名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.setPrjName = function (value) {
        this.PrjName = value;
        this.hmProperty.add("PrjName", "true");
    }

    /// <summary>
    /// 字段名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.getFldName = function () {
        return this.FldName;
    }
    /// <summary>
    /// 字段名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.setFldName = function (value) {
        this.FldName = value;
        this.hmProperty.add("FldName", "true");
    }

    /// <summary>
    /// 字段中文详名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.getFldCnName = function () {
        return this.FldCnName;
    }
    /// <summary>
    /// 字段中文详名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.setFldCnName = function (value) {
        this.FldCnName = value;
        this.hmProperty.add("FldCnName", "true");
    }


    /// <summary>
    /// 字段名_后备(说明:;字段类型:varchar;字段长度:50;是否可空:True)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.getFldName_B = function () {
        return this.FldName_B;
    }
    /// <summary>
    /// 字段名_后备(说明:;字段类型:varchar;字段长度:50;是否可空:True)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.setFldName_B = function (value) {
        this.FldName_B = value;
        this.hmProperty.add("FldName_B", "true");
    }

    /// <summary>
    /// 字段名_国标(说明:;字段类型:varchar;字段长度:50;是否可空:True)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.getFldName_G = function () {
        return this.FldName_G;
    }
    /// <summary>
    /// 字段名_国标(说明:;字段类型:varchar;字段长度:50;是否可空:True)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.setFldName_G = function (value) {
        this.FldName_G = value;
        this.hmProperty.add("FldName_G", "true");
    }

    /// <summary>
    /// 标题(说明:;字段类型:varchar;字段长度:200;是否可空:False)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.getCaption = function () {
        return this.Caption;
    }
    /// <summary>
    /// 标题(说明:;字段类型:varchar;字段长度:200;是否可空:False)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.setCaption = function (value) {
        this.Caption = value;
        this.hmProperty.add("Caption", "true");
    }

    /// <summary>
    /// 数据类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.getDataTypeId = function () {
        return this.DataTypeId;
    }
    /// <summary>
    /// 数据类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.setDataTypeId = function (value) {
        this.DataTypeId = value;
        this.hmProperty.add("DataTypeId", "true");
    }

    /// <summary>
    /// 数据类型名称(说明:;字段类型:varchar;字段长度:20;是否可空:True)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.getDataTypeName = function () {
        return this.DataTypeName;
    }
    /// <summary>
    /// 数据类型名称(说明:;字段类型:varchar;字段长度:20;是否可空:True)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.setDataTypeName = function (value) {
        this.DataTypeName = value;
        this.hmProperty.add("DataTypeName", "true");
    }

    /// <summary>
    /// Ora数据类型(说明:;字段类型:varchar;字段长度:30;是否可空:False)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.getOraDbType = function () {
        return this.OraDbType;
    }
    /// <summary>
    /// Ora数据类型(说明:;字段类型:varchar;字段长度:30;是否可空:False)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.setOraDbType = function (value) {
        this.OraDbType = value;
        this.hmProperty.add("OraDbType", "true");
    }

    /// <summary>
    /// 字段长度(说明:;字段类型:int;字段长度:4;是否可空:False)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.getFldLength = function () {
        return this.FldLength;
    }
    /// <summary>
    /// 字段长度(说明:;字段类型:int;字段长度:4;是否可空:False)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.setFldLength = function (value) {
        this.FldLength = value;
        this.hmProperty.add("FldLength", "true");
    }

    /// <summary>
    /// 精确度(说明:;字段类型:int;字段长度:4;是否可空:True)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.getFldPrecision = function () {
        return this.FldPrecision;
    }
    /// <summary>
    /// 精确度(说明:;字段类型:int;字段长度:4;是否可空:True)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.setFldPrecision = function (value) {
        this.FldPrecision = value;
        this.hmProperty.add("FldPrecision", "true");
    }

    /// <summary>
    /// 字段信息(说明:;字段类型:varchar;字段长度:100;是否可空:True)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.getFldInfo = function () {
        return this.FldInfo;
    }
    /// <summary>
    /// 字段信息(说明:;字段类型:varchar;字段长度:100;是否可空:True)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.setFldInfo = function (value) {
        this.FldInfo = value;
        this.hmProperty.add("FldInfo", "true");
    }

    /// <summary>
    /// 是否可空(说明:;字段类型:bit;字段长度:1;是否可空:False)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.getIsNull = function () {
        return this.IsNull;
    }
    /// <summary>
    /// 是否可空(说明:;字段类型:bit;字段长度:1;是否可空:False)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.setIsNull = function (value) {
        this.IsNull = value;
        this.hmProperty.add("IsNull", "true");
    }

    /// <summary>
    /// 是否主键(说明:;字段类型:bit;字段长度:1;是否可空:False)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.getIsPrimaryKey = function () {
        return this.IsPrimaryKey;
    }
    /// <summary>
    /// 是否主键(说明:;字段类型:bit;字段长度:1;是否可空:False)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.setIsPrimaryKey = function (value) {
        this.IsPrimaryKey = value;
        this.hmProperty.add("IsPrimaryKey", "true");
    }

    /// <summary>
    /// 是否Identity(说明:;字段类型:bit;字段长度:1;是否可空:True)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.getIsIdentity = function () {
        return this.IsIdentity;
    }
    /// <summary>
    /// 是否Identity(说明:;字段类型:bit;字段长度:1;是否可空:True)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.setIsIdentity = function (value) {
        this.IsIdentity = value;
        this.hmProperty.add("IsIdentity", "true");
    }

    /// <summary>
    /// 是否国标(说明:;字段类型:bit;字段长度:1;是否可空:True)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.getIsNationStandard = function () {
        return this.IsNationStandard;
    }
    /// <summary>
    /// 是否国标(说明:;字段类型:bit;字段长度:1;是否可空:True)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.setIsNationStandard = function (value) {
        this.IsNationStandard = value;
        this.hmProperty.add("IsNationStandard", "true");
    }

    /// <summary>
    /// 是否核实(说明:;字段类型:bit;字段长度:1;是否可空:True)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.getIsChecked = function () {
        return this.IsChecked;
    }
    /// <summary>
    /// 是否核实(说明:;字段类型:bit;字段长度:1;是否可空:True)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.setIsChecked = function (value) {
        this.IsChecked = value;
        this.hmProperty.add("IsChecked", "true");
    }

    /// <summary>
    /// 是否存档(说明:;字段类型:bit;字段长度:1;是否可空:True)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.getIsArchive = function () {
        return this.IsArchive;
    }
    /// <summary>
    /// 是否存档(说明:;字段类型:bit;字段长度:1;是否可空:True)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.setIsArchive = function (value) {
        this.IsArchive = value;
        this.hmProperty.add("IsArchive", "true");
    }

    /// <summary>
    /// 是否唯一(说明:;字段类型:bit;字段长度:1;是否可空:True)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.getIsOnlyOne = function () {
        return this.IsOnlyOne;
    }
    /// <summary>
    /// 是否唯一(说明:;字段类型:bit;字段长度:1;是否可空:True)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.setIsOnlyOne = function (value) {
        this.IsOnlyOne = value;
        this.hmProperty.add("IsOnlyOne", "true");
    }

    /// <summary>
    /// 最大值(说明:;字段类型:varchar;字段长度:50;是否可空:True)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.getMaxValue = function () {
        return this.MaxValue;
    }
    /// <summary>
    /// 最大值(说明:;字段类型:varchar;字段长度:50;是否可空:True)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.setMaxValue = function (value) {
        this.MaxValue = value;
        this.hmProperty.add("MaxValue", "true");
    }

    /// <summary>
    /// 最小值(说明:;字段类型:varchar;字段长度:50;是否可空:True)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.getMinValue = function () {
        return this.MinValue;
    }
    /// <summary>
    /// 最小值(说明:;字段类型:varchar;字段长度:50;是否可空:True)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.setMinValue = function (value) {
        this.MinValue = value;
        this.hmProperty.add("MinValue", "true");
    }

    /// <summary>
    /// 缺省值(说明:;字段类型:varchar;字段长度:50;是否可空:True)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.getDefaultValue = function () {
        return this.DefaultValue;
    }
    /// <summary>
    /// 缺省值(说明:;字段类型:varchar;字段长度:50;是否可空:True)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.setDefaultValue = function (value) {
        this.DefaultValue = value;
        this.hmProperty.add("DefaultValue", "true");
    }

    /// <summary>
    /// 是否需要转换代码(说明:;字段类型:bit;字段长度:1;是否可空:False)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.getIsNeedTransCode = function () {
        return this.IsNeedTransCode;
    }
    /// <summary>
    /// 是否需要转换代码(说明:;字段类型:bit;字段长度:1;是否可空:False)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.setIsNeedTransCode = function (value) {
        this.IsNeedTransCode = value;
        this.hmProperty.add("IsNeedTransCode", "true");
    }

    /// <summary>
    /// 用户ID(说明:;字段类型:varchar;字段长度:18;是否可空:True)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.getUserId = function () {
        return this.UserId;
    }
    /// <summary>
    /// 用户ID(说明:;字段类型:varchar;字段长度:18;是否可空:True)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.setUserId = function (value) {
        this.UserId = value;
        this.hmProperty.add("UserId", "true");
    }

    /// <summary>
    /// 应用范围(说明:;字段类型:varchar;字段长度:10;是否可空:True)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.getAppliedScope = function () {
        return this.AppliedScope;
    }
    /// <summary>
    /// 应用范围(说明:;字段类型:varchar;字段长度:10;是否可空:True)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.setAppliedScope = function (value) {
        this.AppliedScope = value;
        this.hmProperty.add("AppliedScope", "true");
    }

    /// <summary>
    /// 字段状态Id(说明:;字段类型:char;字段长度:2;是否可空:False)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.getFldStateId = function () {
        return this.FldStateId;
    }
    /// <summary>
    /// 字段状态Id(说明:;字段类型:char;字段长度:2;是否可空:False)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.setFldStateId = function (value) {
        this.FldStateId = value;
        this.hmProperty.add("FldStateId", "true");
    }

    /// <summary>
    /// CodeTabId(说明:;字段类型:char;字段长度:8;是否可空:True)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.getCodeTabId = function () {
        return this.CodeTabId;
    }
    /// <summary>
    /// CodeTabId(说明:;字段类型:char;字段长度:8;是否可空:True)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.setCodeTabId = function (value) {
        this.CodeTabId = value;
        this.hmProperty.add("CodeTabId", "true");
    }

    /// <summary>
    /// CodeTab_CodeId(说明:;字段类型:char;字段长度:8;是否可空:True)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.getCodeTab_CodeId = function () {
        return this.CodeTab_CodeId;
    }
    /// <summary>
    /// CodeTab_CodeId(说明:;字段类型:char;字段长度:8;是否可空:True)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.setCodeTab_CodeId = function (value) {
        this.CodeTab_CodeId = value;
        this.hmProperty.add("CodeTab_CodeId", "true");
    }

    /// <summary>
    /// CodeTab_NameId(说明:;字段类型:char;字段长度:8;是否可空:True)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.getCodeTab_NameId = function () {
        return this.CodeTab_NameId;
    }
    /// <summary>
    /// CodeTab_NameId(说明:;字段类型:char;字段长度:8;是否可空:True)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.setCodeTab_NameId = function (value) {
        this.CodeTab_NameId = value;
        this.hmProperty.add("CodeTab_NameId", "true");
    }

    /// <summary>
    /// 修改日期(说明:;字段类型:varchar;字段长度:14;是否可空:True)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.getUpdDate = function () {
        return this.UpdDate;
    }
    /// <summary>
    /// 修改日期(说明:;字段类型:varchar;字段长度:14;是否可空:True)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.setUpdDate = function (value) {
        this.UpdDate = value;
        this.hmProperty.add("UpdDate", "true");
    }

    /// <summary>
    /// 说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.getMemo = function () {
        return this.Memo;
    }
    /// <summary>
    /// 说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.setMemo = function (value) {
        this.Memo = value;
        this.hmProperty.add("Memo", "true");
    }

    /// <summary>
    /// 代码表(说明:;字段类型:varchar;字段长度:50;是否可空:True)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.getCodeTab = function () {
        return this.CodeTab;
    }
    /// <summary>
    /// 代码表(说明:;字段类型:varchar;字段长度:50;是否可空:True)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.setCodeTab = function (value) {
        this.CodeTab = value;
        this.hmProperty.add("CodeTab", "true");
    }

    /// <summary>
    /// 代码表_名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.getCodeTab_Name = function () {
        return this.CodeTab_Name;
    }
    /// <summary>
    /// 代码表_名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.setCodeTab_Name = function (value) {
        this.CodeTab_Name = value;
        this.hmProperty.add("CodeTab_Name", "true");
    }

    /// <summary>
    /// 代码表_代码(说明:;字段类型:varchar;字段长度:50;是否可空:True)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.getCodeTab_Code = function () {
        return this.CodeTab_Code;
    }
    /// <summary>
    /// 代码表_代码(说明:;字段类型:varchar;字段长度:50;是否可空:True)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.setCodeTab_Code = function (value) {
        this.CodeTab_Code = value;
        this.hmProperty.add("CodeTab_Code", "true");
    }

    /// <summary>
    /// FldBName_B(说明:;字段类型:varchar;字段长度:50;是否可空:True)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.getFldBName_B = function () {
        return this.FldBName_B;
    }
    /// <summary>
    /// FldBName_B(说明:;字段类型:varchar;字段长度:50;是否可空:True)
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.setFldBName_B = function (value) {
        this.FldBName_B = value;
        this.hmProperty.add("FldBName_B", "true");
    }
    this.init();
}