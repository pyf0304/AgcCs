/// <reference path="tzDictionary.js" />

function getRootPath_web() {
    //获取当前网址，如： http://localhost:8083/uimcardprj/share/meun.jsp
    var curWwwPath = window.document.location.href;
    //获取主机地址之后的目录，如： uimcardprj/share/meun.jsp
    var pathName = window.document.location.pathname;
    var pos = curWwwPath.indexOf(pathName);
    //获取主机地址，如： http://localhost:8083
    var localhostPath = curWwwPath.substring(0, pos);
    //获取带"/"的项目名，如：/uimcardprj
    var projectName = pathName.substring(0, pathName.substr(1).indexOf('/') + 1);
    return (localhostPath + projectName);
}
//获取不带“Http的”根目录
function getVirtualRootPath_web() {
    //获取当前网址，如： http://localhost:8083/uimcardprj/share/meun.jsp
    //var curWwwPath = window.document.location.href;
    //获取主机地址之后的目录，如： uimcardprj/share/meun.jsp
    var pathName = window.document.location.pathname;
    //var pos = curWwwPath.indexOf(pathName);
    //获取主机地址，如： http://localhost:8083
    //var localhostPath = curWwwPath.substring(0, pos);
    //获取带"/"的项目名，如：/uimcardprj
    var projectName = pathName.substring(0, pathName.substr(1).indexOf('/') + 1);
    return (projectName);
}

var VirtualRootPath = getVirtualRootPath_web();
var strDictionaryDir = VirtualRootPath + "/js/PubFun/tzDictionary.js";
include(strDictionaryDir);

//
//  clsGeneralTab.Swift
//  ISOSample_s
//
//  Created by pan yifeng on 16/8/5.
//  Copyright © 2016年 pan yifeng. All rights reserved.
//

var clsGeneralTab = function () {

    var CurrTabName;// : String! //当前表名，与该类相关的表名
    var KeyFldName;// : String! //当前表的关键字字段的名称
    var hmProperty;// : Dictionary<String, String>!
    //以下是出错信息
    var mstrErrMsg;// : [String] = [ "0:正常", "1:院系号为空", "2:专业编号为空", "3:已有相同的编号"];

    //以下是出错信息号码
    var mintErrNo;//: Int!  = 0; //0:正常,1:房间号为空,2:学号为空
    var mstrDispErrMsg;//: String! //对外显示的错误信息
    var mstrModuleName;// :  String!

    //		public static String mstrClassName;
    var mblnDisposed;// : Bool = false; //是否已经释放对象(用于析构函数)
    var EXCEPTION_MSG = " there was an error in the method. please see the Application Log for details.";

    var sf_UpdFldSetStr;// : String;     //字符型标签
    var mintIntTag;// : Int;     //整型Tag
    var mstrStrTag;// : String;     //字符型标签
    var mbolIsCheckProperty;// : Bool;     //是否检查属性

    /// <summary>
    /// 常量:"IntTag"
    /// (ExamLibWeb.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    var con_IntTag;// : String  =  "IntTag";    //整型Tag

    /// <summary>
    /// 常量:"StrTag"
    /// (ExamLibWeb.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    var con_StrTag;// : String  =  "StrTag";    //字符型标签

    /// <summary>
    /// 常量:"IsCheckProperty"
    /// (ExamLibWeb.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    var con_IsCheckProperty;// : String  =  "IsCheckProperty";    //是否检查属性


    /// <summary>
    /// 整型Tag(说明:;字段类型:int;字段长度:4;是否可空:False)
    /// (ExamLibWeb.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.getIntTag = function ()// : Int
    {
        return this.mintIntTag;
    }
    this.setIntTag = function (value)// : Int
    {
        this.mintIntTag = value;
        //记录修改过的字段
        this.hmProperty["IntTag"] = "true";
    }

    /// <summary>
    /// 字符型标签(说明:;字段类型:string;字段长度:1000;是否可空:False)
    /// (ExamLibWeb.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.getStrTag = function ()// : String
    {

        return this.mstrStrTag;
    }
    this.setStrTag = function (value)// : String
    {
        if (value === "") {
            this.mintErrNo = 1;
            this.mstrStrTag = value;
        }
        else {
            this.mstrStrTag = value;
        }
        //记录修改过的字段
        this.hmProperty["StrTag"] = "true";
    }

    /// <summary>
    /// 是否检查属性(说明:;字段类型:bool;字段长度:1;是否可空:False)
    /// (ExamLibWeb.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
    /// </summary>
    this.getIsCheckProperty = function ()// : Bool
    {
        return this.mbolIsCheckProperty;
    }
    this.setIsCheckProperty = function (value)// : Bool
    {
        this.mbolIsCheckProperty = value;
        //记录修改过的字段
        this.hmProperty["IsCheckProperty"] = "true";

    }

    //以下是属性变量
    ///该函数不存在:

    this.init = function () {
        this.sf_UpdFldSetStr = "";     //修改字符标志串
        this.mintIntTag = 0;     //整型Tag
        this.mstrStrTag = "";     //字符型标签
        this.mbolIsCheckProperty = false;     //是否检查属性

        this.SetInit();
    }

    /// <summary>
    /// 设置类的有些属性初始值
    /// </summary>
    this.SetInit = function () {
        this.CurrTabName = "Users"; //当前表名，与该类相关的表名
        this.KeyFldName = "UserId"; //当前表的关键字字段的名称
        this.hmProperty = new Dictionary();
        //mstrModuleName = this.GetType().toString();
    }

    this.getUpdFldProperty = function ()// -> Dictionary<String, String>  {
    {
        return this.hmProperty;
    }

    /*
     * 获取修改的字段名串
     */
    this.getUpdFldString = function ()//->String 
    {
        var sbMsg="";
        var iLen = this.hmProperty.length();

        for (var i = 0; i < iLen; i++) {
            var key = this.hmProperty.keys()[i];
            var value = this.hmProperty.getItem(key);
            sbMsg = sbMsg + key + "|";
        }
        return sbMsg;
    }

    this.getErrNo = function ()//->Int 
    {
        return this.mintErrNo;
    }

    this.setErrNo = function (value) {
        this.mintErrNo = value;
    }

    this.getDispErrMsg = function () { //对外显示的错误信息
        return this.mstrDispErrMsg;
    }

    this.setDispErrMsg = function (value) { //对外显示的错误信息
        this.mstrDispErrMsg = value;
    }

    this.getTabName_Curr = function () {
        return this.CurrTabName;
    }



    //this.TransNullToStr = function (obj)//->String 
    //{
    //    if (String( obj) == "") {
    //        return "";
    //    } else {
    //        return String( obj);
    //    }
    //}

    //this.TransNullToInt = function (obj)// ->Int
    //{
    //    if (String( obj) == "") {
    //        return 0;
    //    } else {
    //        return Int(String( obj));
    //    }
    //}

    //this.TransNullToShort = function (obj)//->CShort 
    //{
    //    if (String( obj) == "") {
    //        return 0;
    //    } else {
    //        return CShort(String( obj));
    //    }
    //}

    //this.TransNullToDate = function (obj)//->NSDate
    //{

    //    //let date_custom = NSDate.date(fromString: "2015-07-26", format: DateFormat.Custom("YYYY-MM-DD"))
    //    let dateFormatter = NSDateFormatter()
    //    //dateFormatter.timeStyle = ..ShortStyle
    //    dateFormatter.dateFormat = "yyyy-MM-dd" // k = Hour in 1~24, mm = Minute
    //    //
    //    //        let outputA = dateFormatter.dateFromString(a)
    //    //        let outputB = dateFormatter.dateFromString(b)
    //    //
    //    //    DateFormat formatter = new SimpleDateFormat("yyyy-MM-dd");
    //    if (String( obj) == "") {
    //        return dateFormatter.dateFromString("1900-01-01");
    //    } else {
    //        return dateFormatter.dateFromString(String( obj));
    //    }
    //}

    //this.TransNullToFloat = function (obj)//->Float 
    //{
    //    if (String( obj) == "") {
    //        return 0.0;
    //    } else {
    //        return Float(String( obj))!;
    //    }
    //}

    //this. TransNullToDouble = function( obj)// -> Double 
    //{
    //    if (String( obj) == "") {
    //        return 0.0;
    //    } else {
    //        return Double(String( obj))!;
    //    }
    //}



    this.getStrLen = function (strTemp)//->Int 
    {
        var len;
        //byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);
        len = strTemp.length;//.characters.count; //will output as 3+3*2=9
        return len;
    }


    this.LogError = function (objException) {
        //Log the error information to the Application Log
        var strLogMsg;

    }


}


