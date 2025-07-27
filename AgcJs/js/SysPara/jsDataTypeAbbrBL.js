
/*-- -- -- -- -- -- -- -- -- -- --
类名:jsDataTypeAbbrBL
表名:DataTypeAbbr
生成代码版本:2017.07.08.1
生成日期:2017/07/08 18:17:47
生成者:
生成服务器IP:1011.251.68.133
工程名称:AGC
工程ID:0005
模块中文名:系统参数
模块英文名:SysPara
框架-层名:业务逻辑层
编程语言:JavaScript
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.06.19.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2016.12.13.01
== == == == == == == == == == == == 
*/
/// <summary>
/// 数据类型(DataTypeAbbr)
/// 数据源类型:SQL表
/// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicCode_JavaScript)
/// </summary>
/// <reference path="../PubFun/tzDictionary.js" />
/// <reference path="../PubFun/jsString.js" />
var VirtualRootPath = getVirtualRootPath_web();//该函数存在于/js/PubFun/jsPubFun.js文件中
include(VirtualRootPath + "/js/PubFun/tzDictionary.js");
include(VirtualRootPath + "/js/PubFun/jsString.js");
var clsDataTypeAbbrBL = function () {
    /// <summary>
    /// 单项的XML结点标签
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicCode_JavaScript)
    /// </summary>
    var itemXmlNode = "DataTypeAbbrListItem";
    /// <summary>
    /// 列表的XML结点标签
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicCode_JavaScript)
    /// </summary>
    var listXmlNode = "DataTypeAbbrList";
    /// <summary>
    /// 集合的XML结点标签
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicCode_JavaScript)
    /// </summary>
    var itemsXmlNode = "Items";
    /// <summary>
    /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicCode_JavaScript)
    /// </summary>
    var arrDataTypeAbbrObjLst_Cache = new Array();
    /// <summary>
    /// 从缓存中查找失败的次数
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicCode_JavaScript)
    /// </summary>
    var intFindFailCount = 0;

    /// <summary>
    /// 把一个JSON串转化为一个对象
    /// 作者:
    /// 日期:20170708181747
    /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_getRecObjByJSONStr_JavaScript)
    /// </summary>
    /// <param name = "strJSON">需要转化的JSON串</param>
    /// <returns>返回一个生成的对象</returns>
    this.getDataTypeAbbrObjByJSONStr = function (strJSON) {
        var pobjDataTypeAbbrEN = new clsDataTypeAbbrEN();
        if (strJSON === "") {
            return pobjDataTypeAbbrEN;
        }
        try {
            pobjDataTypeAbbrEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjDataTypeAbbrEN;
        }
        return pobjDataTypeAbbrEN;
    }

    /// <summary>
    /// 把一个JSON串转化为一个对象列表
    /// 作者:
    /// 日期:20170708181747
    /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_getRecObjLstByJSONStr_JavaScript)
    /// </summary>
    /// <param name = "strJSON">需要转化的JSON串</param>
    /// <returns>返回一个生成的对象列表</returns>
    this.getDataTypeAbbrObjLstByJSONStr = function (strJSON) {
        var arrDataTypeAbbrObjLst = new Array();
        if (strJSON == "") {
            return arrDataTypeAbbrObjLst;
        }
        try {
            arrDataTypeAbbrObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrDataTypeAbbrObjLst;
        }
        return arrDataTypeAbbrObjLst;
    }

    /// <summary>
    /// 把一个对象转化为一个JSON串
    /// 作者:
    /// 日期:20170708181747
    /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_getJSONStrByRecObj_JavaScript)
    /// </summary>
    /// <param name = "strJSON">需要转化的JSON串</param>
    /// <returns>返回一个生成的对象</returns>
    this.getJSONStrByDataTypeAbbrObj = function (pobjDataTypeAbbrEN) {
        pobjDataTypeAbbrEN.sf_UpdFldSetStr = pobjDataTypeAbbrEN.getUpdFldString();
        var strJson;
        var jsonData;
        try {
            strJson = JSON.stringify(pobjDataTypeAbbrEN);
        }
        catch (objException) {
            myShowErrorMsg(objException.message);
        }
        return strJson;
    }

    /// <summary>
    /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
    /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_CheckPropertyNew_JavaScript)
    /// </summary>
    this.CheckPropertyNew = function (pobjDataTypeAbbrEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((null == pobjDataTypeAbbrEN.DataTypeName) || ((null !== pobjDataTypeAbbrEN.DataTypeName) && pobjDataTypeAbbrEN.DataTypeName.toString() == "")) {
            throw ("(errid:Busi159622)字段[数据类型|数据类型名称]不能为空(NULL)!(clsDataTypeAbbrBL:CheckPropertyNew)");
        }
        if ((null == pobjDataTypeAbbrEN.DataCnName) || ((null !== pobjDataTypeAbbrEN.DataCnName) && pobjDataTypeAbbrEN.DataCnName.toString() == "")) {
            throw ("(errid:Busi159622)字段[数据类型|数据类型中文名称]不能为空(NULL)!(clsDataTypeAbbrBL:CheckPropertyNew)");
        }
        if ((null == pobjDataTypeAbbrEN.DataTypeAbbr) || ((null !== pobjDataTypeAbbrEN.DataTypeAbbr) && pobjDataTypeAbbrEN.DataTypeAbbr.toString() == "")) {
            throw ("(errid:Busi159622)字段[数据类型|数据类型缩写]不能为空(NULL)!(clsDataTypeAbbrBL:CheckPropertyNew)");
        }
        if ((null == pobjDataTypeAbbrEN.NetSysType) || ((null !== pobjDataTypeAbbrEN.NetSysType) && pobjDataTypeAbbrEN.NetSysType.toString() == "")) {
            throw ("(errid:Busi159622)字段[数据类型|NET系统类型]不能为空(NULL)!(clsDataTypeAbbrBL:CheckPropertyNew)");
        }
        if ((null == pobjDataTypeAbbrEN.VBNETType) || ((null !== pobjDataTypeAbbrEN.VBNETType) && pobjDataTypeAbbrEN.VBNETType.toString() == "")) {
            throw ("(errid:Busi159622)字段[数据类型|VBNET类型]不能为空(NULL)!(clsDataTypeAbbrBL:CheckPropertyNew)");
        }
        if ((null == pobjDataTypeAbbrEN.CSType) || ((null !== pobjDataTypeAbbrEN.CSType) && pobjDataTypeAbbrEN.CSType.toString() == "")) {
            throw ("(errid:Busi159622)字段[数据类型|CS类型]不能为空(NULL)!(clsDataTypeAbbrBL:CheckPropertyNew)");
        }
        if ((null == pobjDataTypeAbbrEN.JavaType) || ((null !== pobjDataTypeAbbrEN.JavaType) && pobjDataTypeAbbrEN.JavaType.toString() == "")) {
            throw ("(errid:Busi159622)字段[数据类型|JAVA类型]不能为空(NULL)!(clsDataTypeAbbrBL:CheckPropertyNew)");
        }
        if ((null == pobjDataTypeAbbrEN.IsNeedQuote) || ((null !== pobjDataTypeAbbrEN.IsNeedQuote) && pobjDataTypeAbbrEN.IsNeedQuote.toString() == "")) {
            throw ("(errid:Busi159622)字段[数据类型|是否需要引号]不能为空(NULL)!(clsDataTypeAbbrBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((null !== pobjDataTypeAbbrEN.DataTypeId) && getStrLen(pobjDataTypeAbbrEN.DataTypeId) > 2) {
            throw (String.format("(errid:Busi159623)字段[数据类型(DataTypeAbbr)|数据类型Id(DataTypeId)]的长度不能超过2!值:{0}(clsDataTypeAbbrBL:CheckPropertyNew)", pobjDataTypeAbbrEN.DataTypeId));
        }
        if ((null !== pobjDataTypeAbbrEN.DataTypeName) && getStrLen(pobjDataTypeAbbrEN.DataTypeName) > 20) {
            throw (String.format("(errid:Busi159623)字段[数据类型(DataTypeAbbr)|数据类型名称(DataTypeName)]的长度不能超过20!值:{0}(clsDataTypeAbbrBL:CheckPropertyNew)", pobjDataTypeAbbrEN.DataTypeName));
        }
        if ((null !== pobjDataTypeAbbrEN.DataCnName) && getStrLen(pobjDataTypeAbbrEN.DataCnName) > 30) {
            throw (String.format("(errid:Busi159623)字段[数据类型(DataTypeAbbr)|数据类型中文名称(DataCnName)]的长度不能超过30!值:{0}(clsDataTypeAbbrBL:CheckPropertyNew)", pobjDataTypeAbbrEN.DataCnName));
        }
        if ((null !== pobjDataTypeAbbrEN.DataTypeAbbr) && getStrLen(pobjDataTypeAbbrEN.DataTypeAbbr) > 5) {
            throw (String.format("(errid:Busi159623)字段[数据类型(DataTypeAbbr)|数据类型缩写(DataTypeAbbr)]的长度不能超过5!值:{0}(clsDataTypeAbbrBL:CheckPropertyNew)", pobjDataTypeAbbrEN.DataTypeAbbr));
        }
        if ((null !== pobjDataTypeAbbrEN.NetSysType) && getStrLen(pobjDataTypeAbbrEN.NetSysType) > 20) {
            throw (String.format("(errid:Busi159623)字段[数据类型(DataTypeAbbr)|NET系统类型(NetSysType)]的长度不能超过20!值:{0}(clsDataTypeAbbrBL:CheckPropertyNew)", pobjDataTypeAbbrEN.NetSysType));
        }
        if ((null !== pobjDataTypeAbbrEN.VBNETType) && getStrLen(pobjDataTypeAbbrEN.VBNETType) > 20) {
            throw (String.format("(errid:Busi159623)字段[数据类型(DataTypeAbbr)|VBNET类型(VBNETType)]的长度不能超过20!值:{0}(clsDataTypeAbbrBL:CheckPropertyNew)", pobjDataTypeAbbrEN.VBNETType));
        }
        if ((null !== pobjDataTypeAbbrEN.CSType) && getStrLen(pobjDataTypeAbbrEN.CSType) > 20) {
            throw (String.format("(errid:Busi159623)字段[数据类型(DataTypeAbbr)|CS类型(CSType)]的长度不能超过20!值:{0}(clsDataTypeAbbrBL:CheckPropertyNew)", pobjDataTypeAbbrEN.CSType));
        }
        if ((null !== pobjDataTypeAbbrEN.JavaType) && getStrLen(pobjDataTypeAbbrEN.JavaType) > 20) {
            throw (String.format("(errid:Busi159623)字段[数据类型(DataTypeAbbr)|JAVA类型(JavaType)]的长度不能超过20!值:{0}(clsDataTypeAbbrBL:CheckPropertyNew)", pobjDataTypeAbbrEN.JavaType));
        }
        if ((null !== pobjDataTypeAbbrEN.JavaObjType) && getStrLen(pobjDataTypeAbbrEN.JavaObjType) > 50) {
            throw (String.format("(errid:Busi159623)字段[数据类型(DataTypeAbbr)|JAVA对象类型(JavaObjType)]的长度不能超过50!值:{0}(clsDataTypeAbbrBL:CheckPropertyNew)", pobjDataTypeAbbrEN.JavaObjType));
        }
        if ((null !== pobjDataTypeAbbrEN.SwiftType) && getStrLen(pobjDataTypeAbbrEN.SwiftType) > 50) {
            throw (String.format("(errid:Busi159623)字段[数据类型(DataTypeAbbr)|SwiftType(SwiftType)]的长度不能超过50!值:{0}(clsDataTypeAbbrBL:CheckPropertyNew)", pobjDataTypeAbbrEN.SwiftType));
        }
        if ((null !== pobjDataTypeAbbrEN.OraDbType) && getStrLen(pobjDataTypeAbbrEN.OraDbType) > 30) {
            throw (String.format("(errid:Busi159623)字段[数据类型(DataTypeAbbr)|Ora数据类型(OraDbType)]的长度不能超过30!值:{0}(clsDataTypeAbbrBL:CheckPropertyNew)", pobjDataTypeAbbrEN.OraDbType));
        }
        if ((null !== pobjDataTypeAbbrEN.SqlParaType) && getStrLen(pobjDataTypeAbbrEN.SqlParaType) > 20) {
            throw (String.format("(errid:Busi159623)字段[数据类型(DataTypeAbbr)|SQL参数类型(SqlParaType)]的长度不能超过20!值:{0}(clsDataTypeAbbrBL:CheckPropertyNew)", pobjDataTypeAbbrEN.SqlParaType));
        }
        if ((null !== pobjDataTypeAbbrEN.MySqlType) && getStrLen(pobjDataTypeAbbrEN.MySqlType) > 30) {
            throw (String.format("(errid:Busi159623)字段[数据类型(DataTypeAbbr)|MySqlType(MySqlType)]的长度不能超过30!值:{0}(clsDataTypeAbbrBL:CheckPropertyNew)", pobjDataTypeAbbrEN.MySqlType));
        }
        if ((null !== pobjDataTypeAbbrEN.Memo) && getStrLen(pobjDataTypeAbbrEN.Memo) > 1000) {
            throw (String.format("(errid:Busi159623)字段[数据类型(DataTypeAbbr)|说明(Memo)]的长度不能超过1000!值:{0}(clsDataTypeAbbrBL:CheckPropertyNew)", pobjDataTypeAbbrEN.Memo));
        }
        //检查字段的数据类型是否正确
        if ((null !== pobjDataTypeAbbrEN.DataTypeId) && (undefined !== pobjDataTypeAbbrEN.DataTypeId) && tzDataType.isString(pobjDataTypeAbbrEN.getDataTypeId()) == false) {
            throw (String.format("(errid:Busi159624)字段[数据类型(DataTypeAbbr)|数据类型Id(DataTypeId)]的值:[{0}], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckPropertyNew)", pobjDataTypeAbbrEN.DataTypeId));
        }
        if ((null !== pobjDataTypeAbbrEN.DataTypeName) && (undefined !== pobjDataTypeAbbrEN.DataTypeName) && tzDataType.isString(pobjDataTypeAbbrEN.getDataTypeName()) == false) {
            throw (String.format("(errid:Busi159624)字段[数据类型(DataTypeAbbr)|数据类型名称(DataTypeName)]的值:[{0}], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckPropertyNew)", pobjDataTypeAbbrEN.DataTypeName));
        }
        if ((null !== pobjDataTypeAbbrEN.DataCnName) && (undefined !== pobjDataTypeAbbrEN.DataCnName) && tzDataType.isString(pobjDataTypeAbbrEN.getDataCnName()) == false) {
            throw (String.format("(errid:Busi159624)字段[数据类型(DataTypeAbbr)|数据类型中文名称(DataCnName)]的值:[{0}], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckPropertyNew)", pobjDataTypeAbbrEN.DataCnName));
        }
        if ((null !== pobjDataTypeAbbrEN.DataTypeAbbr) && (undefined !== pobjDataTypeAbbrEN.DataTypeAbbr) && tzDataType.isString(pobjDataTypeAbbrEN.getDataTypeAbbr()) == false) {
            throw (String.format("(errid:Busi159624)字段[数据类型(DataTypeAbbr)|数据类型缩写(DataTypeAbbr)]的值:[{0}], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckPropertyNew)", pobjDataTypeAbbrEN.DataTypeAbbr));
        }
        if ((null !== pobjDataTypeAbbrEN.NetSysType) && (undefined !== pobjDataTypeAbbrEN.NetSysType) && tzDataType.isString(pobjDataTypeAbbrEN.getNetSysType()) == false) {
            throw (String.format("(errid:Busi159624)字段[数据类型(DataTypeAbbr)|NET系统类型(NetSysType)]的值:[{0}], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckPropertyNew)", pobjDataTypeAbbrEN.NetSysType));
        }
        if ((null !== pobjDataTypeAbbrEN.VBNETType) && (undefined !== pobjDataTypeAbbrEN.VBNETType) && tzDataType.isString(pobjDataTypeAbbrEN.getVBNETType()) == false) {
            throw (String.format("(errid:Busi159624)字段[数据类型(DataTypeAbbr)|VBNET类型(VBNETType)]的值:[{0}], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckPropertyNew)", pobjDataTypeAbbrEN.VBNETType));
        }
        if ((null !== pobjDataTypeAbbrEN.CSType) && (undefined !== pobjDataTypeAbbrEN.CSType) && tzDataType.isString(pobjDataTypeAbbrEN.getCSType()) == false) {
            throw (String.format("(errid:Busi159624)字段[数据类型(DataTypeAbbr)|CS类型(CSType)]的值:[{0}], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckPropertyNew)", pobjDataTypeAbbrEN.CSType));
        }
        if ((null !== pobjDataTypeAbbrEN.JavaType) && (undefined !== pobjDataTypeAbbrEN.JavaType) && tzDataType.isString(pobjDataTypeAbbrEN.getJavaType()) == false) {
            throw (String.format("(errid:Busi159624)字段[数据类型(DataTypeAbbr)|JAVA类型(JavaType)]的值:[{0}], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckPropertyNew)", pobjDataTypeAbbrEN.JavaType));
        }
        if ((null !== pobjDataTypeAbbrEN.JavaObjType) && (undefined !== pobjDataTypeAbbrEN.JavaObjType) && tzDataType.isString(pobjDataTypeAbbrEN.getJavaObjType()) == false) {
            throw (String.format("(errid:Busi159624)字段[数据类型(DataTypeAbbr)|JAVA对象类型(JavaObjType)]的值:[{0}], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckPropertyNew)", pobjDataTypeAbbrEN.JavaObjType));
        }
        if ((null !== pobjDataTypeAbbrEN.SwiftType) && (undefined !== pobjDataTypeAbbrEN.SwiftType) && tzDataType.isString(pobjDataTypeAbbrEN.getSwiftType()) == false) {
            throw (String.format("(errid:Busi159624)字段[数据类型(DataTypeAbbr)|SwiftType(SwiftType)]的值:[{0}], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckPropertyNew)", pobjDataTypeAbbrEN.SwiftType));
        }
        if ((null !== pobjDataTypeAbbrEN.IsNeedQuote) && (undefined !== pobjDataTypeAbbrEN.IsNeedQuote) && tzDataType.isBoolean(pobjDataTypeAbbrEN.getIsNeedQuote()) == false) {
            throw (String.format("(errid:Busi159624)字段[数据类型(DataTypeAbbr)|是否需要引号(IsNeedQuote)]的值:[{0}], 非法，应该为布尔型!(clsDataTypeAbbrBL:CheckPropertyNew)", pobjDataTypeAbbrEN.IsNeedQuote));
        }
        if ((null !== pobjDataTypeAbbrEN.OraDbType) && (undefined !== pobjDataTypeAbbrEN.OraDbType) && tzDataType.isString(pobjDataTypeAbbrEN.getOraDbType()) == false) {
            throw (String.format("(errid:Busi159624)字段[数据类型(DataTypeAbbr)|Ora数据类型(OraDbType)]的值:[{0}], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckPropertyNew)", pobjDataTypeAbbrEN.OraDbType));
        }
        if ((null !== pobjDataTypeAbbrEN.IsReturnType) && (undefined !== pobjDataTypeAbbrEN.IsReturnType) && tzDataType.isBoolean(pobjDataTypeAbbrEN.getIsReturnType()) == false) {
            throw (String.format("(errid:Busi159624)字段[数据类型(DataTypeAbbr)|是否可作返回类型(IsReturnType)]的值:[{0}], 非法，应该为布尔型!(clsDataTypeAbbrBL:CheckPropertyNew)", pobjDataTypeAbbrEN.IsReturnType));
        }
        if ((null !== pobjDataTypeAbbrEN.SqlParaType) && (undefined !== pobjDataTypeAbbrEN.SqlParaType) && tzDataType.isString(pobjDataTypeAbbrEN.getSqlParaType()) == false) {
            throw (String.format("(errid:Busi159624)字段[数据类型(DataTypeAbbr)|SQL参数类型(SqlParaType)]的值:[{0}], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckPropertyNew)", pobjDataTypeAbbrEN.SqlParaType));
        }
        if ((null !== pobjDataTypeAbbrEN.MySqlType) && (undefined !== pobjDataTypeAbbrEN.MySqlType) && tzDataType.isString(pobjDataTypeAbbrEN.getMySqlType()) == false) {
            throw (String.format("(errid:Busi159624)字段[数据类型(DataTypeAbbr)|MySqlType(MySqlType)]的值:[{0}], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckPropertyNew)", pobjDataTypeAbbrEN.MySqlType));
        }
        if ((null !== pobjDataTypeAbbrEN.DefaFldLength) && (undefined !== pobjDataTypeAbbrEN.DefaFldLength) && tzDataType.isNumber(pobjDataTypeAbbrEN.getDefaFldLength()) == false) {
            throw (String.format("(errid:Busi159624)字段[数据类型(DataTypeAbbr)|默认长度(DefaFldLength)]的值:[{0}], 非法，应该为整型!(clsDataTypeAbbrBL:CheckPropertyNew)", pobjDataTypeAbbrEN.DefaFldLength));
        }
        if ((null !== pobjDataTypeAbbrEN.DefaFldPrecision) && (undefined !== pobjDataTypeAbbrEN.DefaFldPrecision) && tzDataType.isNumber(pobjDataTypeAbbrEN.getDefaFldPrecision()) == false) {
            throw (String.format("(errid:Busi159624)字段[数据类型(DataTypeAbbr)|默认小数位数(DefaFldPrecision)]的值:[{0}], 非法，应该为整型!(clsDataTypeAbbrBL:CheckPropertyNew)", pobjDataTypeAbbrEN.DefaFldPrecision));
        }
        if ((null !== pobjDataTypeAbbrEN.Memo) && (undefined !== pobjDataTypeAbbrEN.Memo) && tzDataType.isString(pobjDataTypeAbbrEN.getMemo()) == false) {
            throw (String.format("(errid:Busi159624)字段[数据类型(DataTypeAbbr)|说明(Memo)]的值:[{0}], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckPropertyNew)", pobjDataTypeAbbrEN.Memo));
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjDataTypeAbbrEN.setIsCheckProperty(true);
    }
    /// <summary>
    /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
    /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_CheckPropertyNew_JavaScript)
    /// </summary>
    this.CheckProperty4Update = function (pobjDataTypeAbbrEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((null !== pobjDataTypeAbbrEN.DataTypeId) && getStrLen(pobjDataTypeAbbrEN.DataTypeId) > 2) {
            throw (String.format("(errid:Busi159626)字段[数据类型(DataTypeAbbr)|数据类型Id(DataTypeId)]的长度不能超过2!值:{0}(clsDataTypeAbbrBL:CheckProperty4Update)", pobjDataTypeAbbrEN.DataTypeId));
        }
        if ((null !== pobjDataTypeAbbrEN.DataTypeName) && getStrLen(pobjDataTypeAbbrEN.DataTypeName) > 20) {
            throw (String.format("(errid:Busi159626)字段[数据类型(DataTypeAbbr)|数据类型名称(DataTypeName)]的长度不能超过20!值:{0}(clsDataTypeAbbrBL:CheckProperty4Update)", pobjDataTypeAbbrEN.DataTypeName));
        }
        if ((null !== pobjDataTypeAbbrEN.DataCnName) && getStrLen(pobjDataTypeAbbrEN.DataCnName) > 30) {
            throw (String.format("(errid:Busi159626)字段[数据类型(DataTypeAbbr)|数据类型中文名称(DataCnName)]的长度不能超过30!值:{0}(clsDataTypeAbbrBL:CheckProperty4Update)", pobjDataTypeAbbrEN.DataCnName));
        }
        if ((null !== pobjDataTypeAbbrEN.DataTypeAbbr) && getStrLen(pobjDataTypeAbbrEN.DataTypeAbbr) > 5) {
            throw (String.format("(errid:Busi159626)字段[数据类型(DataTypeAbbr)|数据类型缩写(DataTypeAbbr)]的长度不能超过5!值:{0}(clsDataTypeAbbrBL:CheckProperty4Update)", pobjDataTypeAbbrEN.DataTypeAbbr));
        }
        if ((null !== pobjDataTypeAbbrEN.NetSysType) && getStrLen(pobjDataTypeAbbrEN.NetSysType) > 20) {
            throw (String.format("(errid:Busi159626)字段[数据类型(DataTypeAbbr)|NET系统类型(NetSysType)]的长度不能超过20!值:{0}(clsDataTypeAbbrBL:CheckProperty4Update)", pobjDataTypeAbbrEN.NetSysType));
        }
        if ((null !== pobjDataTypeAbbrEN.VBNETType) && getStrLen(pobjDataTypeAbbrEN.VBNETType) > 20) {
            throw (String.format("(errid:Busi159626)字段[数据类型(DataTypeAbbr)|VBNET类型(VBNETType)]的长度不能超过20!值:{0}(clsDataTypeAbbrBL:CheckProperty4Update)", pobjDataTypeAbbrEN.VBNETType));
        }
        if ((null !== pobjDataTypeAbbrEN.CSType) && getStrLen(pobjDataTypeAbbrEN.CSType) > 20) {
            throw (String.format("(errid:Busi159626)字段[数据类型(DataTypeAbbr)|CS类型(CSType)]的长度不能超过20!值:{0}(clsDataTypeAbbrBL:CheckProperty4Update)", pobjDataTypeAbbrEN.CSType));
        }
        if ((null !== pobjDataTypeAbbrEN.JavaType) && getStrLen(pobjDataTypeAbbrEN.JavaType) > 20) {
            throw (String.format("(errid:Busi159626)字段[数据类型(DataTypeAbbr)|JAVA类型(JavaType)]的长度不能超过20!值:{0}(clsDataTypeAbbrBL:CheckProperty4Update)", pobjDataTypeAbbrEN.JavaType));
        }
        if ((null !== pobjDataTypeAbbrEN.JavaObjType) && getStrLen(pobjDataTypeAbbrEN.JavaObjType) > 50) {
            throw (String.format("(errid:Busi159626)字段[数据类型(DataTypeAbbr)|JAVA对象类型(JavaObjType)]的长度不能超过50!值:{0}(clsDataTypeAbbrBL:CheckProperty4Update)", pobjDataTypeAbbrEN.JavaObjType));
        }
        if ((null !== pobjDataTypeAbbrEN.SwiftType) && getStrLen(pobjDataTypeAbbrEN.SwiftType) > 50) {
            throw (String.format("(errid:Busi159626)字段[数据类型(DataTypeAbbr)|SwiftType(SwiftType)]的长度不能超过50!值:{0}(clsDataTypeAbbrBL:CheckProperty4Update)", pobjDataTypeAbbrEN.SwiftType));
        }
        if ((null !== pobjDataTypeAbbrEN.OraDbType) && getStrLen(pobjDataTypeAbbrEN.OraDbType) > 30) {
            throw (String.format("(errid:Busi159626)字段[数据类型(DataTypeAbbr)|Ora数据类型(OraDbType)]的长度不能超过30!值:{0}(clsDataTypeAbbrBL:CheckProperty4Update)", pobjDataTypeAbbrEN.OraDbType));
        }
        if ((null !== pobjDataTypeAbbrEN.SqlParaType) && getStrLen(pobjDataTypeAbbrEN.SqlParaType) > 20) {
            throw (String.format("(errid:Busi159626)字段[数据类型(DataTypeAbbr)|SQL参数类型(SqlParaType)]的长度不能超过20!值:{0}(clsDataTypeAbbrBL:CheckProperty4Update)", pobjDataTypeAbbrEN.SqlParaType));
        }
        if ((null !== pobjDataTypeAbbrEN.MySqlType) && getStrLen(pobjDataTypeAbbrEN.MySqlType) > 30) {
            throw (String.format("(errid:Busi159626)字段[数据类型(DataTypeAbbr)|MySqlType(MySqlType)]的长度不能超过30!值:{0}(clsDataTypeAbbrBL:CheckProperty4Update)", pobjDataTypeAbbrEN.MySqlType));
        }
        if ((null !== pobjDataTypeAbbrEN.Memo) && getStrLen(pobjDataTypeAbbrEN.Memo) > 1000) {
            throw (String.format("(errid:Busi159626)字段[数据类型(DataTypeAbbr)|说明(Memo)]的长度不能超过1000!值:{0}(clsDataTypeAbbrBL:CheckProperty4Update)", pobjDataTypeAbbrEN.Memo));
        }
        //检查字段的数据类型是否正确
        if ((null !== pobjDataTypeAbbrEN.DataTypeId) && (undefined !== pobjDataTypeAbbrEN.DataTypeId) && tzDataType.isString(pobjDataTypeAbbrEN.getDataTypeId()) == false) {
            throw (String.format("(errid:Busi159627)字段[数据类型(DataTypeAbbr)|数据类型Id(DataTypeId)]的值:[{0}], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckProperty4Update)", pobjDataTypeAbbrEN.DataTypeId));
        }
        if ((null !== pobjDataTypeAbbrEN.DataTypeName) && (undefined !== pobjDataTypeAbbrEN.DataTypeName) && tzDataType.isString(pobjDataTypeAbbrEN.getDataTypeName()) == false) {
            throw (String.format("(errid:Busi159627)字段[数据类型(DataTypeAbbr)|数据类型名称(DataTypeName)]的值:[{0}], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckProperty4Update)", pobjDataTypeAbbrEN.DataTypeName));
        }
        if ((null !== pobjDataTypeAbbrEN.DataCnName) && (undefined !== pobjDataTypeAbbrEN.DataCnName) && tzDataType.isString(pobjDataTypeAbbrEN.getDataCnName()) == false) {
            throw (String.format("(errid:Busi159627)字段[数据类型(DataTypeAbbr)|数据类型中文名称(DataCnName)]的值:[{0}], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckProperty4Update)", pobjDataTypeAbbrEN.DataCnName));
        }
        if ((null !== pobjDataTypeAbbrEN.DataTypeAbbr) && (undefined !== pobjDataTypeAbbrEN.DataTypeAbbr) && tzDataType.isString(pobjDataTypeAbbrEN.getDataTypeAbbr()) == false) {
            throw (String.format("(errid:Busi159627)字段[数据类型(DataTypeAbbr)|数据类型缩写(DataTypeAbbr)]的值:[{0}], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckProperty4Update)", pobjDataTypeAbbrEN.DataTypeAbbr));
        }
        if ((null !== pobjDataTypeAbbrEN.NetSysType) && (undefined !== pobjDataTypeAbbrEN.NetSysType) && tzDataType.isString(pobjDataTypeAbbrEN.getNetSysType()) == false) {
            throw (String.format("(errid:Busi159627)字段[数据类型(DataTypeAbbr)|NET系统类型(NetSysType)]的值:[{0}], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckProperty4Update)", pobjDataTypeAbbrEN.NetSysType));
        }
        if ((null !== pobjDataTypeAbbrEN.VBNETType) && (undefined !== pobjDataTypeAbbrEN.VBNETType) && tzDataType.isString(pobjDataTypeAbbrEN.getVBNETType()) == false) {
            throw (String.format("(errid:Busi159627)字段[数据类型(DataTypeAbbr)|VBNET类型(VBNETType)]的值:[{0}], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckProperty4Update)", pobjDataTypeAbbrEN.VBNETType));
        }
        if ((null !== pobjDataTypeAbbrEN.CSType) && (undefined !== pobjDataTypeAbbrEN.CSType) && tzDataType.isString(pobjDataTypeAbbrEN.getCSType()) == false) {
            throw (String.format("(errid:Busi159627)字段[数据类型(DataTypeAbbr)|CS类型(CSType)]的值:[{0}], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckProperty4Update)", pobjDataTypeAbbrEN.CSType));
        }
        if ((null !== pobjDataTypeAbbrEN.JavaType) && (undefined !== pobjDataTypeAbbrEN.JavaType) && tzDataType.isString(pobjDataTypeAbbrEN.getJavaType()) == false) {
            throw (String.format("(errid:Busi159627)字段[数据类型(DataTypeAbbr)|JAVA类型(JavaType)]的值:[{0}], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckProperty4Update)", pobjDataTypeAbbrEN.JavaType));
        }
        if ((null !== pobjDataTypeAbbrEN.JavaObjType) && (undefined !== pobjDataTypeAbbrEN.JavaObjType) && tzDataType.isString(pobjDataTypeAbbrEN.getJavaObjType()) == false) {
            throw (String.format("(errid:Busi159627)字段[数据类型(DataTypeAbbr)|JAVA对象类型(JavaObjType)]的值:[{0}], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckProperty4Update)", pobjDataTypeAbbrEN.JavaObjType));
        }
        if ((null !== pobjDataTypeAbbrEN.SwiftType) && (undefined !== pobjDataTypeAbbrEN.SwiftType) && tzDataType.isString(pobjDataTypeAbbrEN.getSwiftType()) == false) {
            throw (String.format("(errid:Busi159627)字段[数据类型(DataTypeAbbr)|SwiftType(SwiftType)]的值:[{0}], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckProperty4Update)", pobjDataTypeAbbrEN.SwiftType));
        }
        if ((null !== pobjDataTypeAbbrEN.IsNeedQuote) && (undefined !== pobjDataTypeAbbrEN.IsNeedQuote) && tzDataType.isBoolean(pobjDataTypeAbbrEN.getIsNeedQuote()) == false) {
            throw (String.format("(errid:Busi159627)字段[数据类型(DataTypeAbbr)|是否需要引号(IsNeedQuote)]的值:[{0}], 非法，应该为布尔型!(clsDataTypeAbbrBL:CheckProperty4Update)", pobjDataTypeAbbrEN.IsNeedQuote));
        }
        if ((null !== pobjDataTypeAbbrEN.OraDbType) && (undefined !== pobjDataTypeAbbrEN.OraDbType) && tzDataType.isString(pobjDataTypeAbbrEN.getOraDbType()) == false) {
            throw (String.format("(errid:Busi159627)字段[数据类型(DataTypeAbbr)|Ora数据类型(OraDbType)]的值:[{0}], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckProperty4Update)", pobjDataTypeAbbrEN.OraDbType));
        }
        if ((null !== pobjDataTypeAbbrEN.IsReturnType) && (undefined !== pobjDataTypeAbbrEN.IsReturnType) && tzDataType.isBoolean(pobjDataTypeAbbrEN.getIsReturnType()) == false) {
            throw (String.format("(errid:Busi159627)字段[数据类型(DataTypeAbbr)|是否可作返回类型(IsReturnType)]的值:[{0}], 非法，应该为布尔型!(clsDataTypeAbbrBL:CheckProperty4Update)", pobjDataTypeAbbrEN.IsReturnType));
        }
        if ((null !== pobjDataTypeAbbrEN.SqlParaType) && (undefined !== pobjDataTypeAbbrEN.SqlParaType) && tzDataType.isString(pobjDataTypeAbbrEN.getSqlParaType()) == false) {
            throw (String.format("(errid:Busi159627)字段[数据类型(DataTypeAbbr)|SQL参数类型(SqlParaType)]的值:[{0}], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckProperty4Update)", pobjDataTypeAbbrEN.SqlParaType));
        }
        if ((null !== pobjDataTypeAbbrEN.MySqlType) && (undefined !== pobjDataTypeAbbrEN.MySqlType) && tzDataType.isString(pobjDataTypeAbbrEN.getMySqlType()) == false) {
            throw (String.format("(errid:Busi159627)字段[数据类型(DataTypeAbbr)|MySqlType(MySqlType)]的值:[{0}], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckProperty4Update)", pobjDataTypeAbbrEN.MySqlType));
        }
        if ((null !== pobjDataTypeAbbrEN.DefaFldLength) && (undefined !== pobjDataTypeAbbrEN.DefaFldLength) && tzDataType.isNumber(pobjDataTypeAbbrEN.getDefaFldLength()) == false) {
            throw (String.format("(errid:Busi159627)字段[数据类型(DataTypeAbbr)|默认长度(DefaFldLength)]的值:[{0}], 非法，应该为整型!(clsDataTypeAbbrBL:CheckProperty4Update)", pobjDataTypeAbbrEN.DefaFldLength));
        }
        if ((null !== pobjDataTypeAbbrEN.DefaFldPrecision) && (undefined !== pobjDataTypeAbbrEN.DefaFldPrecision) && tzDataType.isNumber(pobjDataTypeAbbrEN.getDefaFldPrecision()) == false) {
            throw (String.format("(errid:Busi159627)字段[数据类型(DataTypeAbbr)|默认小数位数(DefaFldPrecision)]的值:[{0}], 非法，应该为整型!(clsDataTypeAbbrBL:CheckProperty4Update)", pobjDataTypeAbbrEN.DefaFldPrecision));
        }
        if ((null !== pobjDataTypeAbbrEN.Memo) && (undefined !== pobjDataTypeAbbrEN.Memo) && tzDataType.isString(pobjDataTypeAbbrEN.getMemo()) == false) {
            throw (String.format("(errid:Busi159627)字段[数据类型(DataTypeAbbr)|说明(Memo)]的值:[{0}], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckProperty4Update)", pobjDataTypeAbbrEN.Memo));
        }
        //检查主键是否为Null或者空！
        if ((null == pobjDataTypeAbbrEN.DataTypeId) || ((null !== pobjDataTypeAbbrEN.DataTypeId) && pobjDataTypeAbbrEN.DataTypeId.toString() == "")) {
            throw ("(errid:Busi159628)字段[数据类型|数据类型Id]不能为空(NULL)!(clsDataTypeAbbrBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

        pobjDataTypeAbbrEN.setIsCheckProperty(true);
    }
}