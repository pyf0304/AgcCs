
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvNewsEN
 表名:vNews(00050480)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:18:04
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:新闻公告(NewsBulletin)
 框架-层名:实体层(CS)(EntityLayer)
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

namespace AGC.Entity
{
 /// <summary>
 /// 表vNews的关键字(Id_News)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_Id_News_vNews
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngId_News">表关键字</param>
public K_Id_News_vNews(long lngId_News)
{
if (IsValid(lngId_News)) Value = lngId_News;
else
{
Value = 0;
}
}
private static bool IsValid(long lngId_News)
{
if (lngId_News == 0) return false;
if (lngId_News == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_Id_News_vNews]类型的对象</returns>
public static implicit operator K_Id_News_vNews(long value)
{
return new K_Id_News_vNews(value);
}
}
 /// <summary>
 /// v新闻(vNews)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvNewsEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接，如果为空就使用系统默认的连接
public new const string _CurrTabName = "vNews"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "Id_News"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string WhereFormat = ""; //条件格式串
protected const int mintAttributeCount = 15;
public static string[] AttributeName = new string[] {"Id_News", "NewsTypeId", "NewsTypeName", "NewsTitle", "NewsContent", "ImgPath", "EditPeople", "EditTime", "Source", "IsTop", "Views", "Audit", "Memo", "DeletedDate", "IsDeleted"};

protected long mlngId_News;    //Id_News
protected string mstrNewsTypeId;    //信息类型Id
protected string mstrNewsTypeName;    //信息类型名称
protected string mstrNewsTitle;    //信息标题
protected string mstrNewsContent;    //信息内容
protected string mstrImgPath;    //图片路径
protected string mstrEditPeople;    //编辑人
protected string mstrEditTime;    //编辑时间
protected string mstrSource;    //来源
protected bool mbolIsTop;    //是否置顶
protected int? mintViews;    //浏览量
protected string mstrAudit;    //审核
protected string mstrMemo;    //说明
protected string mstrDeletedDate;    //删除日期
protected bool mbolIsDeleted;    //是否删除

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvNewsEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "vNews";
 lstKeyFldNames.Add("Id_News");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngId_News">关键字:Id_News</param>
public clsvNewsEN(long lngId_News)
 {
 if (lngId_News  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngId_News = lngId_News;
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "vNews";
 lstKeyFldNames.Add("Id_News");
 }

public static int AttributeCount
{
get
{
return mintAttributeCount;
}
}
public override object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  convNews.Id_News)
{
return mlngId_News;
}
else if (strAttributeName  ==  convNews.NewsTypeId)
{
return mstrNewsTypeId;
}
else if (strAttributeName  ==  convNews.NewsTypeName)
{
return mstrNewsTypeName;
}
else if (strAttributeName  ==  convNews.NewsTitle)
{
return mstrNewsTitle;
}
else if (strAttributeName  ==  convNews.NewsContent)
{
return mstrNewsContent;
}
else if (strAttributeName  ==  convNews.ImgPath)
{
return mstrImgPath;
}
else if (strAttributeName  ==  convNews.EditPeople)
{
return mstrEditPeople;
}
else if (strAttributeName  ==  convNews.EditTime)
{
return mstrEditTime;
}
else if (strAttributeName  ==  convNews.Source)
{
return mstrSource;
}
else if (strAttributeName  ==  convNews.IsTop)
{
return mbolIsTop;
}
else if (strAttributeName  ==  convNews.Views)
{
return mintViews;
}
else if (strAttributeName  ==  convNews.Audit)
{
return mstrAudit;
}
else if (strAttributeName  ==  convNews.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convNews.DeletedDate)
{
return mstrDeletedDate;
}
else if (strAttributeName  ==  convNews.IsDeleted)
{
return mbolIsDeleted;
}
return null;
}
set
{
if (strAttributeName  ==  convNews.Id_News)
{
mlngId_News = TransNullToInt(value.ToString());
 AddUpdatedFld(convNews.Id_News);
}
else if (strAttributeName  ==  convNews.NewsTypeId)
{
mstrNewsTypeId = value.ToString();
 AddUpdatedFld(convNews.NewsTypeId);
}
else if (strAttributeName  ==  convNews.NewsTypeName)
{
mstrNewsTypeName = value.ToString();
 AddUpdatedFld(convNews.NewsTypeName);
}
else if (strAttributeName  ==  convNews.NewsTitle)
{
mstrNewsTitle = value.ToString();
 AddUpdatedFld(convNews.NewsTitle);
}
else if (strAttributeName  ==  convNews.NewsContent)
{
mstrNewsContent = value.ToString();
 AddUpdatedFld(convNews.NewsContent);
}
else if (strAttributeName  ==  convNews.ImgPath)
{
mstrImgPath = value.ToString();
 AddUpdatedFld(convNews.ImgPath);
}
else if (strAttributeName  ==  convNews.EditPeople)
{
mstrEditPeople = value.ToString();
 AddUpdatedFld(convNews.EditPeople);
}
else if (strAttributeName  ==  convNews.EditTime)
{
mstrEditTime = value.ToString();
 AddUpdatedFld(convNews.EditTime);
}
else if (strAttributeName  ==  convNews.Source)
{
mstrSource = value.ToString();
 AddUpdatedFld(convNews.Source);
}
else if (strAttributeName  ==  convNews.IsTop)
{
mbolIsTop = TransNullToBool(value.ToString());
 AddUpdatedFld(convNews.IsTop);
}
else if (strAttributeName  ==  convNews.Views)
{
mintViews = TransNullToInt(value.ToString());
 AddUpdatedFld(convNews.Views);
}
else if (strAttributeName  ==  convNews.Audit)
{
mstrAudit = value.ToString();
 AddUpdatedFld(convNews.Audit);
}
else if (strAttributeName  ==  convNews.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convNews.Memo);
}
else if (strAttributeName  ==  convNews.DeletedDate)
{
mstrDeletedDate = value.ToString();
 AddUpdatedFld(convNews.DeletedDate);
}
else if (strAttributeName  ==  convNews.IsDeleted)
{
mbolIsDeleted = TransNullToBool(value.ToString());
 AddUpdatedFld(convNews.IsDeleted);
}
}
}
public object this[int intIndex]
{
get
{
if (convNews.Id_News  ==  AttributeName[intIndex])
{
return mlngId_News;
}
else if (convNews.NewsTypeId  ==  AttributeName[intIndex])
{
return mstrNewsTypeId;
}
else if (convNews.NewsTypeName  ==  AttributeName[intIndex])
{
return mstrNewsTypeName;
}
else if (convNews.NewsTitle  ==  AttributeName[intIndex])
{
return mstrNewsTitle;
}
else if (convNews.NewsContent  ==  AttributeName[intIndex])
{
return mstrNewsContent;
}
else if (convNews.ImgPath  ==  AttributeName[intIndex])
{
return mstrImgPath;
}
else if (convNews.EditPeople  ==  AttributeName[intIndex])
{
return mstrEditPeople;
}
else if (convNews.EditTime  ==  AttributeName[intIndex])
{
return mstrEditTime;
}
else if (convNews.Source  ==  AttributeName[intIndex])
{
return mstrSource;
}
else if (convNews.IsTop  ==  AttributeName[intIndex])
{
return mbolIsTop;
}
else if (convNews.Views  ==  AttributeName[intIndex])
{
return mintViews;
}
else if (convNews.Audit  ==  AttributeName[intIndex])
{
return mstrAudit;
}
else if (convNews.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convNews.DeletedDate  ==  AttributeName[intIndex])
{
return mstrDeletedDate;
}
else if (convNews.IsDeleted  ==  AttributeName[intIndex])
{
return mbolIsDeleted;
}
return null;
}
set
{
if (convNews.Id_News  ==  AttributeName[intIndex])
{
mlngId_News = TransNullToInt(value.ToString());
 AddUpdatedFld(convNews.Id_News);
}
else if (convNews.NewsTypeId  ==  AttributeName[intIndex])
{
mstrNewsTypeId = value.ToString();
 AddUpdatedFld(convNews.NewsTypeId);
}
else if (convNews.NewsTypeName  ==  AttributeName[intIndex])
{
mstrNewsTypeName = value.ToString();
 AddUpdatedFld(convNews.NewsTypeName);
}
else if (convNews.NewsTitle  ==  AttributeName[intIndex])
{
mstrNewsTitle = value.ToString();
 AddUpdatedFld(convNews.NewsTitle);
}
else if (convNews.NewsContent  ==  AttributeName[intIndex])
{
mstrNewsContent = value.ToString();
 AddUpdatedFld(convNews.NewsContent);
}
else if (convNews.ImgPath  ==  AttributeName[intIndex])
{
mstrImgPath = value.ToString();
 AddUpdatedFld(convNews.ImgPath);
}
else if (convNews.EditPeople  ==  AttributeName[intIndex])
{
mstrEditPeople = value.ToString();
 AddUpdatedFld(convNews.EditPeople);
}
else if (convNews.EditTime  ==  AttributeName[intIndex])
{
mstrEditTime = value.ToString();
 AddUpdatedFld(convNews.EditTime);
}
else if (convNews.Source  ==  AttributeName[intIndex])
{
mstrSource = value.ToString();
 AddUpdatedFld(convNews.Source);
}
else if (convNews.IsTop  ==  AttributeName[intIndex])
{
mbolIsTop = TransNullToBool(value.ToString());
 AddUpdatedFld(convNews.IsTop);
}
else if (convNews.Views  ==  AttributeName[intIndex])
{
mintViews = TransNullToInt(value.ToString());
 AddUpdatedFld(convNews.Views);
}
else if (convNews.Audit  ==  AttributeName[intIndex])
{
mstrAudit = value.ToString();
 AddUpdatedFld(convNews.Audit);
}
else if (convNews.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convNews.Memo);
}
else if (convNews.DeletedDate  ==  AttributeName[intIndex])
{
mstrDeletedDate = value.ToString();
 AddUpdatedFld(convNews.DeletedDate);
}
else if (convNews.IsDeleted  ==  AttributeName[intIndex])
{
mbolIsDeleted = TransNullToBool(value.ToString());
 AddUpdatedFld(convNews.IsDeleted);
}
}
}

/// <summary>
/// Id_News(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long Id_News
{
get
{
return mlngId_News;
}
set
{
 mlngId_News = value;
//记录修改过的字段
 AddUpdatedFld(convNews.Id_News);
}
}
/// <summary>
/// 信息类型Id(说明:;字段类型:char;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string NewsTypeId
{
get
{
return mstrNewsTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrNewsTypeId = value;
}
else
{
 mstrNewsTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convNews.NewsTypeId);
}
}
/// <summary>
/// 信息类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string NewsTypeName
{
get
{
return mstrNewsTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrNewsTypeName = value;
}
else
{
 mstrNewsTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convNews.NewsTypeName);
}
}
/// <summary>
/// 信息标题(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string NewsTitle
{
get
{
return mstrNewsTitle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrNewsTitle = value;
}
else
{
 mstrNewsTitle = value;
}
//记录修改过的字段
 AddUpdatedFld(convNews.NewsTitle);
}
}
/// <summary>
/// 信息内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string NewsContent
{
get
{
return mstrNewsContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrNewsContent = value;
}
else
{
 mstrNewsContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convNews.NewsContent);
}
}
/// <summary>
/// 图片路径(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ImgPath
{
get
{
return mstrImgPath;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrImgPath = value;
}
else
{
 mstrImgPath = value;
}
//记录修改过的字段
 AddUpdatedFld(convNews.ImgPath);
}
}
/// <summary>
/// 编辑人(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EditPeople
{
get
{
return mstrEditPeople;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEditPeople = value;
}
else
{
 mstrEditPeople = value;
}
//记录修改过的字段
 AddUpdatedFld(convNews.EditPeople);
}
}
/// <summary>
/// 编辑时间(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EditTime
{
get
{
return mstrEditTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEditTime = value;
}
else
{
 mstrEditTime = value;
}
//记录修改过的字段
 AddUpdatedFld(convNews.EditTime);
}
}
/// <summary>
/// 来源(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Source
{
get
{
return mstrSource;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSource = value;
}
else
{
 mstrSource = value;
}
//记录修改过的字段
 AddUpdatedFld(convNews.Source);
}
}
/// <summary>
/// 是否置顶(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsTop
{
get
{
return mbolIsTop;
}
set
{
 mbolIsTop = value;
//记录修改过的字段
 AddUpdatedFld(convNews.IsTop);
}
}
/// <summary>
/// 浏览量(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? Views
{
get
{
return mintViews;
}
set
{
 mintViews = value;
//记录修改过的字段
 AddUpdatedFld(convNews.Views);
}
}
/// <summary>
/// 审核(说明:;字段类型:char;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Audit
{
get
{
return mstrAudit;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAudit = value;
}
else
{
 mstrAudit = value;
}
//记录修改过的字段
 AddUpdatedFld(convNews.Audit);
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
 AddUpdatedFld(convNews.Memo);
}
}
/// <summary>
/// 删除日期(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DeletedDate
{
get
{
return mstrDeletedDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDeletedDate = value;
}
else
{
 mstrDeletedDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convNews.DeletedDate);
}
}
/// <summary>
/// 是否删除(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsDeleted
{
get
{
return mbolIsDeleted;
}
set
{
 mbolIsDeleted = value;
//记录修改过的字段
 AddUpdatedFld(convNews.IsDeleted);
}
}

/// <summary>
/// 获取关键字Id(keyId)
 /// (AutoGCLib.clsGeneCodeBase:GenGetKeyId)
/// </summary>
 public override string _KeyId
 {
 get
 {
  return mlngId_News.ToString();
 }
 }
}
 /// <summary>
 /// v新闻(vNews)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convNews
{
public new const string _CurrTabName = "vNews"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "Id_News"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"Id_News", "NewsTypeId", "NewsTypeName", "NewsTitle", "NewsContent", "ImgPath", "EditPeople", "EditTime", "Source", "IsTop", "Views", "Audit", "Memo", "DeletedDate", "IsDeleted"};
//以下是属性变量


 /// <summary>
 /// 常量:"Id_News"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Id_News = "Id_News";    //Id_News

 /// <summary>
 /// 常量:"NewsTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string NewsTypeId = "NewsTypeId";    //信息类型Id

 /// <summary>
 /// 常量:"NewsTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string NewsTypeName = "NewsTypeName";    //信息类型名称

 /// <summary>
 /// 常量:"NewsTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string NewsTitle = "NewsTitle";    //信息标题

 /// <summary>
 /// 常量:"NewsContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string NewsContent = "NewsContent";    //信息内容

 /// <summary>
 /// 常量:"ImgPath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ImgPath = "ImgPath";    //图片路径

 /// <summary>
 /// 常量:"EditPeople"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EditPeople = "EditPeople";    //编辑人

 /// <summary>
 /// 常量:"EditTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EditTime = "EditTime";    //编辑时间

 /// <summary>
 /// 常量:"Source"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Source = "Source";    //来源

 /// <summary>
 /// 常量:"IsTop"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsTop = "IsTop";    //是否置顶

 /// <summary>
 /// 常量:"Views"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Views = "Views";    //浏览量

 /// <summary>
 /// 常量:"Audit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Audit = "Audit";    //审核

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明

 /// <summary>
 /// 常量:"DeletedDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DeletedDate = "DeletedDate";    //删除日期

 /// <summary>
 /// 常量:"IsDeleted"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDeleted = "IsDeleted";    //是否删除
}

}