
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvApplicationTypeEN
 表名:vApplicationType(00050403)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:48:26
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码(GeneCode)
 框架-层名:实体层(CS)(EntityLayer,0001)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Text; 
using System.Collections; 

using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace AGC.Entity
{
 /// <summary>
 /// 表vApplicationType的关键字(ApplicationTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ApplicationTypeId_vApplicationType
{
private int _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public int Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="intApplicationTypeId">表关键字</param>
public K_ApplicationTypeId_vApplicationType(int intApplicationTypeId)
{
if (IsValid(intApplicationTypeId)) Value = intApplicationTypeId;
else
{
Value = 0;
}
}
private static bool IsValid(int intApplicationTypeId)
{
if (intApplicationTypeId == 0) return false;
if (intApplicationTypeId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ApplicationTypeId_vApplicationType]类型的对象</returns>
public static implicit operator K_ApplicationTypeId_vApplicationType(int value)
{
return new K_ApplicationTypeId_vApplicationType(value);
}
}
 /// <summary>
 /// v应用程序类型(vApplicationType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvApplicationTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vApplicationType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ApplicationTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 29;
public static string[] _AttributeName = new string[] {"ApplicationTypeId", "ApplicationTypeName", "ApplicationTypeSimName", "ApplicationTypeENName", "ProgLangTypeId", "ProgLangTypeName", "ProgLangTypeENName", "CharEncodingId", "CharEncodingName", "ProgLangTypeId2", "ProgLangTypeId3", "ProgLangTypeId4", "ProgLangTypeId5", "IsVisible", "OrderNum", "Memo", "CharEncodingId2", "CharEncodingId3", "CharEncodingName2", "CharEncodingName3", "ProgLangTypeName2", "ProgLangTypeName3", "ProgLangTypeName5", "CodeTypeCount", "CharEncodingId4", "CharEncodingName4", "ProgLangTypeName4", "CharEncodingId5", "CharEncodingName5"};

protected int mintApplicationTypeId;    //应用程序类型ID
protected string mstrApplicationTypeName;    //应用程序类型名称
protected string mstrApplicationTypeSimName;    //应用程序类型简称
protected string mstrApplicationTypeENName;    //应用类型英文名
protected string mstrProgLangTypeId;    //编程语言类型Id
protected string mstrProgLangTypeName;    //编程语言类型名
protected string mstrProgLangTypeENName;    //编程语言类型英文名
protected string mstrCharEncodingId;    //字符编码
protected string mstrCharEncodingName;    //字符编码名称
protected string mstrProgLangTypeId2;    //编程语言类型Id2
protected string mstrProgLangTypeId3;    //编程语言类型Id3
protected string mstrProgLangTypeId4;    //编程语言类型Id4
protected string mstrProgLangTypeId5;    //编程语言类型Id5
protected bool mbolIsVisible;    //是否显示
protected int mintOrderNum;    //序号
protected string mstrMemo;    //说明
protected string mstrCharEncodingId2;    //CharEncodingId2
protected string mstrCharEncodingId3;    //CharEncodingId3
protected string mstrCharEncodingName2;    //CharEncodingName2
protected string mstrCharEncodingName3;    //CharEncodingName3
protected string mstrProgLangTypeName2;    //ProgLangTypeName2
protected string mstrProgLangTypeName3;    //ProgLangTypeName3
protected string mstrProgLangTypeName5;    //ProgLangTypeName5
protected int? mintCodeTypeCount;    //代码类型数
protected string mstrCharEncodingId4;    //CharEncodingId4
protected string mstrCharEncodingName4;    //CharEncodingName4
protected string mstrProgLangTypeName4;    //ProgLangTypeName4
protected string mstrCharEncodingId5;    //CharEncodingId5
protected string mstrCharEncodingName5;    //CharEncodingName5

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvApplicationTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ApplicationTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "intApplicationTypeId">关键字:应用程序类型ID</param>
public clsvApplicationTypeEN(int intApplicationTypeId)
 {
 if (intApplicationTypeId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mintApplicationTypeId = intApplicationTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ApplicationTypeId");
 }

public static int AttributeCount
{
get
{
return _AttributeCount;
}
}
public override object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  convApplicationType.ApplicationTypeId)
{
return mintApplicationTypeId;
}
else if (strAttributeName  ==  convApplicationType.ApplicationTypeName)
{
return mstrApplicationTypeName;
}
else if (strAttributeName  ==  convApplicationType.ApplicationTypeSimName)
{
return mstrApplicationTypeSimName;
}
else if (strAttributeName  ==  convApplicationType.ApplicationTypeENName)
{
return mstrApplicationTypeENName;
}
else if (strAttributeName  ==  convApplicationType.ProgLangTypeId)
{
return mstrProgLangTypeId;
}
else if (strAttributeName  ==  convApplicationType.ProgLangTypeName)
{
return mstrProgLangTypeName;
}
else if (strAttributeName  ==  convApplicationType.ProgLangTypeENName)
{
return mstrProgLangTypeENName;
}
else if (strAttributeName  ==  convApplicationType.CharEncodingId)
{
return mstrCharEncodingId;
}
else if (strAttributeName  ==  convApplicationType.CharEncodingName)
{
return mstrCharEncodingName;
}
else if (strAttributeName  ==  convApplicationType.ProgLangTypeId2)
{
return mstrProgLangTypeId2;
}
else if (strAttributeName  ==  convApplicationType.ProgLangTypeId3)
{
return mstrProgLangTypeId3;
}
else if (strAttributeName  ==  convApplicationType.ProgLangTypeId4)
{
return mstrProgLangTypeId4;
}
else if (strAttributeName  ==  convApplicationType.ProgLangTypeId5)
{
return mstrProgLangTypeId5;
}
else if (strAttributeName  ==  convApplicationType.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  convApplicationType.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convApplicationType.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convApplicationType.CharEncodingId2)
{
return mstrCharEncodingId2;
}
else if (strAttributeName  ==  convApplicationType.CharEncodingId3)
{
return mstrCharEncodingId3;
}
else if (strAttributeName  ==  convApplicationType.CharEncodingName2)
{
return mstrCharEncodingName2;
}
else if (strAttributeName  ==  convApplicationType.CharEncodingName3)
{
return mstrCharEncodingName3;
}
else if (strAttributeName  ==  convApplicationType.ProgLangTypeName2)
{
return mstrProgLangTypeName2;
}
else if (strAttributeName  ==  convApplicationType.ProgLangTypeName3)
{
return mstrProgLangTypeName3;
}
else if (strAttributeName  ==  convApplicationType.ProgLangTypeName5)
{
return mstrProgLangTypeName5;
}
else if (strAttributeName  ==  convApplicationType.CodeTypeCount)
{
return mintCodeTypeCount;
}
else if (strAttributeName  ==  convApplicationType.CharEncodingId4)
{
return mstrCharEncodingId4;
}
else if (strAttributeName  ==  convApplicationType.CharEncodingName4)
{
return mstrCharEncodingName4;
}
else if (strAttributeName  ==  convApplicationType.ProgLangTypeName4)
{
return mstrProgLangTypeName4;
}
else if (strAttributeName  ==  convApplicationType.CharEncodingId5)
{
return mstrCharEncodingId5;
}
else if (strAttributeName  ==  convApplicationType.CharEncodingName5)
{
return mstrCharEncodingName5;
}
return null;
}
set
{
if (strAttributeName  ==  convApplicationType.ApplicationTypeId)
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convApplicationType.ApplicationTypeId);
}
else if (strAttributeName  ==  convApplicationType.ApplicationTypeName)
{
mstrApplicationTypeName = value.ToString();
 AddUpdatedFld(convApplicationType.ApplicationTypeName);
}
else if (strAttributeName  ==  convApplicationType.ApplicationTypeSimName)
{
mstrApplicationTypeSimName = value.ToString();
 AddUpdatedFld(convApplicationType.ApplicationTypeSimName);
}
else if (strAttributeName  ==  convApplicationType.ApplicationTypeENName)
{
mstrApplicationTypeENName = value.ToString();
 AddUpdatedFld(convApplicationType.ApplicationTypeENName);
}
else if (strAttributeName  ==  convApplicationType.ProgLangTypeId)
{
mstrProgLangTypeId = value.ToString();
 AddUpdatedFld(convApplicationType.ProgLangTypeId);
}
else if (strAttributeName  ==  convApplicationType.ProgLangTypeName)
{
mstrProgLangTypeName = value.ToString();
 AddUpdatedFld(convApplicationType.ProgLangTypeName);
}
else if (strAttributeName  ==  convApplicationType.ProgLangTypeENName)
{
mstrProgLangTypeENName = value.ToString();
 AddUpdatedFld(convApplicationType.ProgLangTypeENName);
}
else if (strAttributeName  ==  convApplicationType.CharEncodingId)
{
mstrCharEncodingId = value.ToString();
 AddUpdatedFld(convApplicationType.CharEncodingId);
}
else if (strAttributeName  ==  convApplicationType.CharEncodingName)
{
mstrCharEncodingName = value.ToString();
 AddUpdatedFld(convApplicationType.CharEncodingName);
}
else if (strAttributeName  ==  convApplicationType.ProgLangTypeId2)
{
mstrProgLangTypeId2 = value.ToString();
 AddUpdatedFld(convApplicationType.ProgLangTypeId2);
}
else if (strAttributeName  ==  convApplicationType.ProgLangTypeId3)
{
mstrProgLangTypeId3 = value.ToString();
 AddUpdatedFld(convApplicationType.ProgLangTypeId3);
}
else if (strAttributeName  ==  convApplicationType.ProgLangTypeId4)
{
mstrProgLangTypeId4 = value.ToString();
 AddUpdatedFld(convApplicationType.ProgLangTypeId4);
}
else if (strAttributeName  ==  convApplicationType.ProgLangTypeId5)
{
mstrProgLangTypeId5 = value.ToString();
 AddUpdatedFld(convApplicationType.ProgLangTypeId5);
}
else if (strAttributeName  ==  convApplicationType.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convApplicationType.IsVisible);
}
else if (strAttributeName  ==  convApplicationType.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convApplicationType.OrderNum);
}
else if (strAttributeName  ==  convApplicationType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convApplicationType.Memo);
}
else if (strAttributeName  ==  convApplicationType.CharEncodingId2)
{
mstrCharEncodingId2 = value.ToString();
 AddUpdatedFld(convApplicationType.CharEncodingId2);
}
else if (strAttributeName  ==  convApplicationType.CharEncodingId3)
{
mstrCharEncodingId3 = value.ToString();
 AddUpdatedFld(convApplicationType.CharEncodingId3);
}
else if (strAttributeName  ==  convApplicationType.CharEncodingName2)
{
mstrCharEncodingName2 = value.ToString();
 AddUpdatedFld(convApplicationType.CharEncodingName2);
}
else if (strAttributeName  ==  convApplicationType.CharEncodingName3)
{
mstrCharEncodingName3 = value.ToString();
 AddUpdatedFld(convApplicationType.CharEncodingName3);
}
else if (strAttributeName  ==  convApplicationType.ProgLangTypeName2)
{
mstrProgLangTypeName2 = value.ToString();
 AddUpdatedFld(convApplicationType.ProgLangTypeName2);
}
else if (strAttributeName  ==  convApplicationType.ProgLangTypeName3)
{
mstrProgLangTypeName3 = value.ToString();
 AddUpdatedFld(convApplicationType.ProgLangTypeName3);
}
else if (strAttributeName  ==  convApplicationType.ProgLangTypeName5)
{
mstrProgLangTypeName5 = value.ToString();
 AddUpdatedFld(convApplicationType.ProgLangTypeName5);
}
else if (strAttributeName  ==  convApplicationType.CodeTypeCount)
{
mintCodeTypeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convApplicationType.CodeTypeCount);
}
else if (strAttributeName  ==  convApplicationType.CharEncodingId4)
{
mstrCharEncodingId4 = value.ToString();
 AddUpdatedFld(convApplicationType.CharEncodingId4);
}
else if (strAttributeName  ==  convApplicationType.CharEncodingName4)
{
mstrCharEncodingName4 = value.ToString();
 AddUpdatedFld(convApplicationType.CharEncodingName4);
}
else if (strAttributeName  ==  convApplicationType.ProgLangTypeName4)
{
mstrProgLangTypeName4 = value.ToString();
 AddUpdatedFld(convApplicationType.ProgLangTypeName4);
}
else if (strAttributeName  ==  convApplicationType.CharEncodingId5)
{
mstrCharEncodingId5 = value.ToString();
 AddUpdatedFld(convApplicationType.CharEncodingId5);
}
else if (strAttributeName  ==  convApplicationType.CharEncodingName5)
{
mstrCharEncodingName5 = value.ToString();
 AddUpdatedFld(convApplicationType.CharEncodingName5);
}
}
}
public object this[int intIndex]
{
get
{
if (convApplicationType.ApplicationTypeId  ==  _AttributeName[intIndex])
{
return mintApplicationTypeId;
}
else if (convApplicationType.ApplicationTypeName  ==  _AttributeName[intIndex])
{
return mstrApplicationTypeName;
}
else if (convApplicationType.ApplicationTypeSimName  ==  _AttributeName[intIndex])
{
return mstrApplicationTypeSimName;
}
else if (convApplicationType.ApplicationTypeENName  ==  _AttributeName[intIndex])
{
return mstrApplicationTypeENName;
}
else if (convApplicationType.ProgLangTypeId  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeId;
}
else if (convApplicationType.ProgLangTypeName  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeName;
}
else if (convApplicationType.ProgLangTypeENName  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeENName;
}
else if (convApplicationType.CharEncodingId  ==  _AttributeName[intIndex])
{
return mstrCharEncodingId;
}
else if (convApplicationType.CharEncodingName  ==  _AttributeName[intIndex])
{
return mstrCharEncodingName;
}
else if (convApplicationType.ProgLangTypeId2  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeId2;
}
else if (convApplicationType.ProgLangTypeId3  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeId3;
}
else if (convApplicationType.ProgLangTypeId4  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeId4;
}
else if (convApplicationType.ProgLangTypeId5  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeId5;
}
else if (convApplicationType.IsVisible  ==  _AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (convApplicationType.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convApplicationType.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (convApplicationType.CharEncodingId2  ==  _AttributeName[intIndex])
{
return mstrCharEncodingId2;
}
else if (convApplicationType.CharEncodingId3  ==  _AttributeName[intIndex])
{
return mstrCharEncodingId3;
}
else if (convApplicationType.CharEncodingName2  ==  _AttributeName[intIndex])
{
return mstrCharEncodingName2;
}
else if (convApplicationType.CharEncodingName3  ==  _AttributeName[intIndex])
{
return mstrCharEncodingName3;
}
else if (convApplicationType.ProgLangTypeName2  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeName2;
}
else if (convApplicationType.ProgLangTypeName3  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeName3;
}
else if (convApplicationType.ProgLangTypeName5  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeName5;
}
else if (convApplicationType.CodeTypeCount  ==  _AttributeName[intIndex])
{
return mintCodeTypeCount;
}
else if (convApplicationType.CharEncodingId4  ==  _AttributeName[intIndex])
{
return mstrCharEncodingId4;
}
else if (convApplicationType.CharEncodingName4  ==  _AttributeName[intIndex])
{
return mstrCharEncodingName4;
}
else if (convApplicationType.ProgLangTypeName4  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeName4;
}
else if (convApplicationType.CharEncodingId5  ==  _AttributeName[intIndex])
{
return mstrCharEncodingId5;
}
else if (convApplicationType.CharEncodingName5  ==  _AttributeName[intIndex])
{
return mstrCharEncodingName5;
}
return null;
}
set
{
if (convApplicationType.ApplicationTypeId  ==  _AttributeName[intIndex])
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convApplicationType.ApplicationTypeId);
}
else if (convApplicationType.ApplicationTypeName  ==  _AttributeName[intIndex])
{
mstrApplicationTypeName = value.ToString();
 AddUpdatedFld(convApplicationType.ApplicationTypeName);
}
else if (convApplicationType.ApplicationTypeSimName  ==  _AttributeName[intIndex])
{
mstrApplicationTypeSimName = value.ToString();
 AddUpdatedFld(convApplicationType.ApplicationTypeSimName);
}
else if (convApplicationType.ApplicationTypeENName  ==  _AttributeName[intIndex])
{
mstrApplicationTypeENName = value.ToString();
 AddUpdatedFld(convApplicationType.ApplicationTypeENName);
}
else if (convApplicationType.ProgLangTypeId  ==  _AttributeName[intIndex])
{
mstrProgLangTypeId = value.ToString();
 AddUpdatedFld(convApplicationType.ProgLangTypeId);
}
else if (convApplicationType.ProgLangTypeName  ==  _AttributeName[intIndex])
{
mstrProgLangTypeName = value.ToString();
 AddUpdatedFld(convApplicationType.ProgLangTypeName);
}
else if (convApplicationType.ProgLangTypeENName  ==  _AttributeName[intIndex])
{
mstrProgLangTypeENName = value.ToString();
 AddUpdatedFld(convApplicationType.ProgLangTypeENName);
}
else if (convApplicationType.CharEncodingId  ==  _AttributeName[intIndex])
{
mstrCharEncodingId = value.ToString();
 AddUpdatedFld(convApplicationType.CharEncodingId);
}
else if (convApplicationType.CharEncodingName  ==  _AttributeName[intIndex])
{
mstrCharEncodingName = value.ToString();
 AddUpdatedFld(convApplicationType.CharEncodingName);
}
else if (convApplicationType.ProgLangTypeId2  ==  _AttributeName[intIndex])
{
mstrProgLangTypeId2 = value.ToString();
 AddUpdatedFld(convApplicationType.ProgLangTypeId2);
}
else if (convApplicationType.ProgLangTypeId3  ==  _AttributeName[intIndex])
{
mstrProgLangTypeId3 = value.ToString();
 AddUpdatedFld(convApplicationType.ProgLangTypeId3);
}
else if (convApplicationType.ProgLangTypeId4  ==  _AttributeName[intIndex])
{
mstrProgLangTypeId4 = value.ToString();
 AddUpdatedFld(convApplicationType.ProgLangTypeId4);
}
else if (convApplicationType.ProgLangTypeId5  ==  _AttributeName[intIndex])
{
mstrProgLangTypeId5 = value.ToString();
 AddUpdatedFld(convApplicationType.ProgLangTypeId5);
}
else if (convApplicationType.IsVisible  ==  _AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convApplicationType.IsVisible);
}
else if (convApplicationType.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convApplicationType.OrderNum);
}
else if (convApplicationType.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convApplicationType.Memo);
}
else if (convApplicationType.CharEncodingId2  ==  _AttributeName[intIndex])
{
mstrCharEncodingId2 = value.ToString();
 AddUpdatedFld(convApplicationType.CharEncodingId2);
}
else if (convApplicationType.CharEncodingId3  ==  _AttributeName[intIndex])
{
mstrCharEncodingId3 = value.ToString();
 AddUpdatedFld(convApplicationType.CharEncodingId3);
}
else if (convApplicationType.CharEncodingName2  ==  _AttributeName[intIndex])
{
mstrCharEncodingName2 = value.ToString();
 AddUpdatedFld(convApplicationType.CharEncodingName2);
}
else if (convApplicationType.CharEncodingName3  ==  _AttributeName[intIndex])
{
mstrCharEncodingName3 = value.ToString();
 AddUpdatedFld(convApplicationType.CharEncodingName3);
}
else if (convApplicationType.ProgLangTypeName2  ==  _AttributeName[intIndex])
{
mstrProgLangTypeName2 = value.ToString();
 AddUpdatedFld(convApplicationType.ProgLangTypeName2);
}
else if (convApplicationType.ProgLangTypeName3  ==  _AttributeName[intIndex])
{
mstrProgLangTypeName3 = value.ToString();
 AddUpdatedFld(convApplicationType.ProgLangTypeName3);
}
else if (convApplicationType.ProgLangTypeName5  ==  _AttributeName[intIndex])
{
mstrProgLangTypeName5 = value.ToString();
 AddUpdatedFld(convApplicationType.ProgLangTypeName5);
}
else if (convApplicationType.CodeTypeCount  ==  _AttributeName[intIndex])
{
mintCodeTypeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convApplicationType.CodeTypeCount);
}
else if (convApplicationType.CharEncodingId4  ==  _AttributeName[intIndex])
{
mstrCharEncodingId4 = value.ToString();
 AddUpdatedFld(convApplicationType.CharEncodingId4);
}
else if (convApplicationType.CharEncodingName4  ==  _AttributeName[intIndex])
{
mstrCharEncodingName4 = value.ToString();
 AddUpdatedFld(convApplicationType.CharEncodingName4);
}
else if (convApplicationType.ProgLangTypeName4  ==  _AttributeName[intIndex])
{
mstrProgLangTypeName4 = value.ToString();
 AddUpdatedFld(convApplicationType.ProgLangTypeName4);
}
else if (convApplicationType.CharEncodingId5  ==  _AttributeName[intIndex])
{
mstrCharEncodingId5 = value.ToString();
 AddUpdatedFld(convApplicationType.CharEncodingId5);
}
else if (convApplicationType.CharEncodingName5  ==  _AttributeName[intIndex])
{
mstrCharEncodingName5 = value.ToString();
 AddUpdatedFld(convApplicationType.CharEncodingName5);
}
}
}

/// <summary>
/// 应用程序类型ID(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int ApplicationTypeId
{
get
{
return mintApplicationTypeId;
}
set
{
 mintApplicationTypeId = value;
//记录修改过的字段
 AddUpdatedFld(convApplicationType.ApplicationTypeId);
}
}
/// <summary>
/// 应用程序类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ApplicationTypeName
{
get
{
return mstrApplicationTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrApplicationTypeName = value;
}
else
{
 mstrApplicationTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convApplicationType.ApplicationTypeName);
}
}
/// <summary>
/// 应用程序类型简称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ApplicationTypeSimName
{
get
{
return mstrApplicationTypeSimName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrApplicationTypeSimName = value;
}
else
{
 mstrApplicationTypeSimName = value;
}
//记录修改过的字段
 AddUpdatedFld(convApplicationType.ApplicationTypeSimName);
}
}
/// <summary>
/// 应用类型英文名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ApplicationTypeENName
{
get
{
return mstrApplicationTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrApplicationTypeENName = value;
}
else
{
 mstrApplicationTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(convApplicationType.ApplicationTypeENName);
}
}
/// <summary>
/// 编程语言类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProgLangTypeId
{
get
{
return mstrProgLangTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProgLangTypeId = value;
}
else
{
 mstrProgLangTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convApplicationType.ProgLangTypeId);
}
}
/// <summary>
/// 编程语言类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProgLangTypeName
{
get
{
return mstrProgLangTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProgLangTypeName = value;
}
else
{
 mstrProgLangTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convApplicationType.ProgLangTypeName);
}
}
/// <summary>
/// 编程语言类型英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProgLangTypeENName
{
get
{
return mstrProgLangTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProgLangTypeENName = value;
}
else
{
 mstrProgLangTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(convApplicationType.ProgLangTypeENName);
}
}
/// <summary>
/// 字符编码(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CharEncodingId
{
get
{
return mstrCharEncodingId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCharEncodingId = value;
}
else
{
 mstrCharEncodingId = value;
}
//记录修改过的字段
 AddUpdatedFld(convApplicationType.CharEncodingId);
}
}
/// <summary>
/// 字符编码名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CharEncodingName
{
get
{
return mstrCharEncodingName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCharEncodingName = value;
}
else
{
 mstrCharEncodingName = value;
}
//记录修改过的字段
 AddUpdatedFld(convApplicationType.CharEncodingName);
}
}
/// <summary>
/// 编程语言类型Id2(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProgLangTypeId2
{
get
{
return mstrProgLangTypeId2;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProgLangTypeId2 = value;
}
else
{
 mstrProgLangTypeId2 = value;
}
//记录修改过的字段
 AddUpdatedFld(convApplicationType.ProgLangTypeId2);
}
}
/// <summary>
/// 编程语言类型Id3(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProgLangTypeId3
{
get
{
return mstrProgLangTypeId3;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProgLangTypeId3 = value;
}
else
{
 mstrProgLangTypeId3 = value;
}
//记录修改过的字段
 AddUpdatedFld(convApplicationType.ProgLangTypeId3);
}
}
/// <summary>
/// 编程语言类型Id4(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProgLangTypeId4
{
get
{
return mstrProgLangTypeId4;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProgLangTypeId4 = value;
}
else
{
 mstrProgLangTypeId4 = value;
}
//记录修改过的字段
 AddUpdatedFld(convApplicationType.ProgLangTypeId4);
}
}
/// <summary>
/// 编程语言类型Id5(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProgLangTypeId5
{
get
{
return mstrProgLangTypeId5;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProgLangTypeId5 = value;
}
else
{
 mstrProgLangTypeId5 = value;
}
//记录修改过的字段
 AddUpdatedFld(convApplicationType.ProgLangTypeId5);
}
}
/// <summary>
/// 是否显示(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsVisible
{
get
{
return mbolIsVisible;
}
set
{
 mbolIsVisible = value;
//记录修改过的字段
 AddUpdatedFld(convApplicationType.IsVisible);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(convApplicationType.OrderNum);
}
}
/// <summary>
/// 说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Memo
{
get
{
return mstrMemo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMemo = value;
}
else
{
 mstrMemo = value;
}
//记录修改过的字段
 AddUpdatedFld(convApplicationType.Memo);
}
}
/// <summary>
/// CharEncodingId2(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CharEncodingId2
{
get
{
return mstrCharEncodingId2;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCharEncodingId2 = value;
}
else
{
 mstrCharEncodingId2 = value;
}
//记录修改过的字段
 AddUpdatedFld(convApplicationType.CharEncodingId2);
}
}
/// <summary>
/// CharEncodingId3(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CharEncodingId3
{
get
{
return mstrCharEncodingId3;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCharEncodingId3 = value;
}
else
{
 mstrCharEncodingId3 = value;
}
//记录修改过的字段
 AddUpdatedFld(convApplicationType.CharEncodingId3);
}
}
/// <summary>
/// CharEncodingName2(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CharEncodingName2
{
get
{
return mstrCharEncodingName2;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCharEncodingName2 = value;
}
else
{
 mstrCharEncodingName2 = value;
}
//记录修改过的字段
 AddUpdatedFld(convApplicationType.CharEncodingName2);
}
}
/// <summary>
/// CharEncodingName3(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CharEncodingName3
{
get
{
return mstrCharEncodingName3;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCharEncodingName3 = value;
}
else
{
 mstrCharEncodingName3 = value;
}
//记录修改过的字段
 AddUpdatedFld(convApplicationType.CharEncodingName3);
}
}
/// <summary>
/// ProgLangTypeName2(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProgLangTypeName2
{
get
{
return mstrProgLangTypeName2;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProgLangTypeName2 = value;
}
else
{
 mstrProgLangTypeName2 = value;
}
//记录修改过的字段
 AddUpdatedFld(convApplicationType.ProgLangTypeName2);
}
}
/// <summary>
/// ProgLangTypeName3(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProgLangTypeName3
{
get
{
return mstrProgLangTypeName3;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProgLangTypeName3 = value;
}
else
{
 mstrProgLangTypeName3 = value;
}
//记录修改过的字段
 AddUpdatedFld(convApplicationType.ProgLangTypeName3);
}
}
/// <summary>
/// ProgLangTypeName5(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProgLangTypeName5
{
get
{
return mstrProgLangTypeName5;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProgLangTypeName5 = value;
}
else
{
 mstrProgLangTypeName5 = value;
}
//记录修改过的字段
 AddUpdatedFld(convApplicationType.ProgLangTypeName5);
}
}
/// <summary>
/// 代码类型数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? CodeTypeCount
{
get
{
return mintCodeTypeCount;
}
set
{
 mintCodeTypeCount = value;
//记录修改过的字段
 AddUpdatedFld(convApplicationType.CodeTypeCount);
}
}
/// <summary>
/// CharEncodingId4(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CharEncodingId4
{
get
{
return mstrCharEncodingId4;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCharEncodingId4 = value;
}
else
{
 mstrCharEncodingId4 = value;
}
//记录修改过的字段
 AddUpdatedFld(convApplicationType.CharEncodingId4);
}
}
/// <summary>
/// CharEncodingName4(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CharEncodingName4
{
get
{
return mstrCharEncodingName4;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCharEncodingName4 = value;
}
else
{
 mstrCharEncodingName4 = value;
}
//记录修改过的字段
 AddUpdatedFld(convApplicationType.CharEncodingName4);
}
}
/// <summary>
/// ProgLangTypeName4(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProgLangTypeName4
{
get
{
return mstrProgLangTypeName4;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProgLangTypeName4 = value;
}
else
{
 mstrProgLangTypeName4 = value;
}
//记录修改过的字段
 AddUpdatedFld(convApplicationType.ProgLangTypeName4);
}
}
/// <summary>
/// CharEncodingId5(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CharEncodingId5
{
get
{
return mstrCharEncodingId5;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCharEncodingId5 = value;
}
else
{
 mstrCharEncodingId5 = value;
}
//记录修改过的字段
 AddUpdatedFld(convApplicationType.CharEncodingId5);
}
}
/// <summary>
/// CharEncodingName5(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CharEncodingName5
{
get
{
return mstrCharEncodingName5;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCharEncodingName5 = value;
}
else
{
 mstrCharEncodingName5 = value;
}
//记录修改过的字段
 AddUpdatedFld(convApplicationType.CharEncodingName5);
}
}

/// <summary>
/// 获取关键字Id(keyId)
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetKeyId)
/// </summary>
 public override string _KeyId
 {
 get
 {
  return mintApplicationTypeId.ToString();
 }
 }
}
 /// <summary>
 /// v应用程序类型(vApplicationType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convApplicationType
{
public const string _CurrTabName = "vApplicationType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ApplicationTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"ApplicationTypeId", "ApplicationTypeName", "ApplicationTypeSimName", "ApplicationTypeENName", "ProgLangTypeId", "ProgLangTypeName", "ProgLangTypeENName", "CharEncodingId", "CharEncodingName", "ProgLangTypeId2", "ProgLangTypeId3", "ProgLangTypeId4", "ProgLangTypeId5", "IsVisible", "OrderNum", "Memo", "CharEncodingId2", "CharEncodingId3", "CharEncodingName2", "CharEncodingName3", "ProgLangTypeName2", "ProgLangTypeName3", "ProgLangTypeName5", "CodeTypeCount", "CharEncodingId4", "CharEncodingName4", "ProgLangTypeName4", "CharEncodingId5", "CharEncodingName5"};
//以下是属性变量


 /// <summary>
 /// 常量:"ApplicationTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeId = "ApplicationTypeId";    //应用程序类型ID

 /// <summary>
 /// 常量:"ApplicationTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeName = "ApplicationTypeName";    //应用程序类型名称

 /// <summary>
 /// 常量:"ApplicationTypeSimName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeSimName = "ApplicationTypeSimName";    //应用程序类型简称

 /// <summary>
 /// 常量:"ApplicationTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeENName = "ApplicationTypeENName";    //应用类型英文名

 /// <summary>
 /// 常量:"ProgLangTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeId = "ProgLangTypeId";    //编程语言类型Id

 /// <summary>
 /// 常量:"ProgLangTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeName = "ProgLangTypeName";    //编程语言类型名

 /// <summary>
 /// 常量:"ProgLangTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeENName = "ProgLangTypeENName";    //编程语言类型英文名

 /// <summary>
 /// 常量:"CharEncodingId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CharEncodingId = "CharEncodingId";    //字符编码

 /// <summary>
 /// 常量:"CharEncodingName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CharEncodingName = "CharEncodingName";    //字符编码名称

 /// <summary>
 /// 常量:"ProgLangTypeId2"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeId2 = "ProgLangTypeId2";    //编程语言类型Id2

 /// <summary>
 /// 常量:"ProgLangTypeId3"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeId3 = "ProgLangTypeId3";    //编程语言类型Id3

 /// <summary>
 /// 常量:"ProgLangTypeId4"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeId4 = "ProgLangTypeId4";    //编程语言类型Id4

 /// <summary>
 /// 常量:"ProgLangTypeId5"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeId5 = "ProgLangTypeId5";    //编程语言类型Id5

 /// <summary>
 /// 常量:"IsVisible"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsVisible = "IsVisible";    //是否显示

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明

 /// <summary>
 /// 常量:"CharEncodingId2"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CharEncodingId2 = "CharEncodingId2";    //CharEncodingId2

 /// <summary>
 /// 常量:"CharEncodingId3"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CharEncodingId3 = "CharEncodingId3";    //CharEncodingId3

 /// <summary>
 /// 常量:"CharEncodingName2"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CharEncodingName2 = "CharEncodingName2";    //CharEncodingName2

 /// <summary>
 /// 常量:"CharEncodingName3"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CharEncodingName3 = "CharEncodingName3";    //CharEncodingName3

 /// <summary>
 /// 常量:"ProgLangTypeName2"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeName2 = "ProgLangTypeName2";    //ProgLangTypeName2

 /// <summary>
 /// 常量:"ProgLangTypeName3"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeName3 = "ProgLangTypeName3";    //ProgLangTypeName3

 /// <summary>
 /// 常量:"ProgLangTypeName5"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeName5 = "ProgLangTypeName5";    //ProgLangTypeName5

 /// <summary>
 /// 常量:"CodeTypeCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTypeCount = "CodeTypeCount";    //代码类型数

 /// <summary>
 /// 常量:"CharEncodingId4"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CharEncodingId4 = "CharEncodingId4";    //CharEncodingId4

 /// <summary>
 /// 常量:"CharEncodingName4"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CharEncodingName4 = "CharEncodingName4";    //CharEncodingName4

 /// <summary>
 /// 常量:"ProgLangTypeName4"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeName4 = "ProgLangTypeName4";    //ProgLangTypeName4

 /// <summary>
 /// 常量:"CharEncodingId5"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CharEncodingId5 = "CharEncodingId5";    //CharEncodingId5

 /// <summary>
 /// 常量:"CharEncodingName5"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CharEncodingName5 = "CharEncodingName5";    //CharEncodingName5
}

}