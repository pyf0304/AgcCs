
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:DateTime
 表名:DateTime(00050565)
 生成代码版本:2021.07.29.1
 生成日期:2021/07/29 17:41:10
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:AGC
 工程ID:0005
 模块中文名:系统参数
 模块英文名:SysPara
 框架-层名:纯粹类(PureClass)
 编程语言:CSharp
 注意:1、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
using System;
using System.Text; 
using System.Collections; 
using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;
using System.Runtime.Serialization;

namespace AGC.PureClass
{
 /// <summary>
 /// DateTime(DateTime)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class DateTime 
{
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"mId", "Year", "Month", "Day", "Hour", "Minute", "Second"};
//以下是属性变量

protected long mlngmId;    //mId
protected int mintYear;    //年
protected int mintMonth;    //月
protected int mintDay;    //日
protected int mintHour;    //时
protected int mintMinute;    //分
protected int mintSecond;    //秒


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_mId = "mId";    //mId

 /// <summary>
 /// 常量:"Year"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Year = "Year";    //年

 /// <summary>
 /// 常量:"Month"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Month = "Month";    //月

 /// <summary>
 /// 常量:"Day"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Day = "Day";    //日

 /// <summary>
 /// 常量:"Hour"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Hour = "Hour";    //时

 /// <summary>
 /// 常量:"Minute"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Minute = "Minute";    //分

 /// <summary>
 /// 常量:"Second"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Second = "Second";    //秒

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public DateTime()
 {
 }

public static int AttributeCount
{
get
{
return mintAttributeCount;
}
}
/// <summary>
/// 类索引器(Indexer)函数,字符串参数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClsIndexer)
/// </summary>
public object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  con_mId)
{
return mlngmId;
}
else if (strAttributeName  ==  con_Year)
{
return mintYear;
}
else if (strAttributeName  ==  con_Month)
{
return mintMonth;
}
else if (strAttributeName  ==  con_Day)
{
return mintDay;
}
else if (strAttributeName  ==  con_Hour)
{
return mintHour;
}
else if (strAttributeName  ==  con_Minute)
{
return mintMinute;
}
else if (strAttributeName  ==  con_Second)
{
return mintSecond;
}
return null;
}
set
{
if (strAttributeName  ==  con_mId)
{
mlngmId = clsEntityBase2.TransNullToInt_S(value.ToString());
}
else if (strAttributeName  ==  con_Year)
{
mintYear = clsEntityBase2.TransNullToInt_S(value.ToString());
}
else if (strAttributeName  ==  con_Month)
{
mintMonth = clsEntityBase2.TransNullToInt_S(value.ToString());
}
else if (strAttributeName  ==  con_Day)
{
mintDay = clsEntityBase2.TransNullToInt_S(value.ToString());
}
else if (strAttributeName  ==  con_Hour)
{
mintHour = clsEntityBase2.TransNullToInt_S(value.ToString());
}
else if (strAttributeName  ==  con_Minute)
{
mintMinute = clsEntityBase2.TransNullToInt_S(value.ToString());
}
else if (strAttributeName  ==  con_Second)
{
mintSecond = clsEntityBase2.TransNullToInt_S(value.ToString());
}
}
}
/// <summary>
/// 类索引器(Indexer)函数, 整型(INT)序号参数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClsIndexer)
/// </summary>
public object this[int intIndex]
{
get
{
if (con_mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (con_Year  ==  AttributeName[intIndex])
{
return mintYear;
}
else if (con_Month  ==  AttributeName[intIndex])
{
return mintMonth;
}
else if (con_Day  ==  AttributeName[intIndex])
{
return mintDay;
}
else if (con_Hour  ==  AttributeName[intIndex])
{
return mintHour;
}
else if (con_Minute  ==  AttributeName[intIndex])
{
return mintMinute;
}
else if (con_Second  ==  AttributeName[intIndex])
{
return mintSecond;
}
return null;
}
set
{
if (con_mId  ==  AttributeName[intIndex])
{
mlngmId = clsEntityBase2.TransNullToInt_S(value.ToString());
}
else if (con_Year  ==  AttributeName[intIndex])
{
mintYear = clsEntityBase2.TransNullToInt_S(value.ToString());
}
else if (con_Month  ==  AttributeName[intIndex])
{
mintMonth = clsEntityBase2.TransNullToInt_S(value.ToString());
}
else if (con_Day  ==  AttributeName[intIndex])
{
mintDay = clsEntityBase2.TransNullToInt_S(value.ToString());
}
else if (con_Hour  ==  AttributeName[intIndex])
{
mintHour = clsEntityBase2.TransNullToInt_S(value.ToString());
}
else if (con_Minute  ==  AttributeName[intIndex])
{
mintMinute = clsEntityBase2.TransNullToInt_S(value.ToString());
}
else if (con_Second  ==  AttributeName[intIndex])
{
mintSecond = clsEntityBase2.TransNullToInt_S(value.ToString());
}
}
}

/// <summary>
/// mId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public long mId
{
get
{
return mlngmId;
}
set
{
 mlngmId = value;
}
}
/// <summary>
/// 年(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public int Year
{
get
{
return mintYear;
}
set
{
 mintYear = value;
}
}
/// <summary>
/// 月(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public int Month
{
get
{
return mintMonth;
}
set
{
 mintMonth = value;
}
}
/// <summary>
/// 日(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public int Day
{
get
{
return mintDay;
}
set
{
 mintDay = value;
}
}
/// <summary>
/// 时(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public int Hour
{
get
{
return mintHour;
}
set
{
 mintHour = value;
}
}
/// <summary>
/// 分(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public int Minute
{
get
{
return mintMinute;
}
set
{
 mintMinute = value;
}
}
/// <summary>
/// 秒(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public int Second
{
get
{
return mintSecond;
}
set
{
 mintSecond = value;
}
}
}
}