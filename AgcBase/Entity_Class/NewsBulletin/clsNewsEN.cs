
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsNewsEN
 表名:News(00050478)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:15:21
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
 /// 表News的关键字(Id_News)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_Id_News_News
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
public K_Id_News_News(long lngId_News)
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
 /// <returns>返回:[K_Id_News_News]类型的对象</returns>
public static implicit operator K_Id_News_News(long value)
{
return new K_Id_News_News(value);
}
}
 /// <summary>
 /// 新闻(News)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsNewsEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接，如果为空就使用系统默认的连接
public new const string _CurrTabName = "News"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "Id_News"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string WhereFormat = ""; //条件格式串
protected const int mintAttributeCount = 14;
public static string[] AttributeName = new string[] {"Id_News", "NewsTypeId", "NewsTitle", "NewsContent", "ImgPath", "EditPeople", "EditTime", "Source", "IsTop", "Views", "Audit", "IsDeleted", "DeletedDate", "Memo"};

protected long mlngId_News;    //Id_News
protected string mstrNewsTypeId;    //信息类型Id
protected string mstrNewsTitle;    //信息标题
protected string mstrNewsContent;    //信息内容
protected string mstrImgPath;    //图片路径
protected string mstrEditPeople;    //编辑人
protected string mstrEditTime;    //编辑时间
protected string mstrSource;    //来源
protected bool mbolIsTop;    //是否置顶
protected int? mintViews;    //浏览量
protected string mstrAudit;    //审核
protected bool mbolIsDeleted;    //是否删除
protected string mstrDeletedDate;    //删除日期
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsNewsEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "News";
 lstKeyFldNames.Add("Id_News");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngId_News">关键字:Id_News</param>
public clsNewsEN(long lngId_News)
 {
 if (lngId_News  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngId_News = lngId_News;
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "News";
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
if (strAttributeName  ==  conNews.Id_News)
{
return mlngId_News;
}
else if (strAttributeName  ==  conNews.NewsTypeId)
{
return mstrNewsTypeId;
}
else if (strAttributeName  ==  conNews.NewsTitle)
{
return mstrNewsTitle;
}
else if (strAttributeName  ==  conNews.NewsContent)
{
return mstrNewsContent;
}
else if (strAttributeName  ==  conNews.ImgPath)
{
return mstrImgPath;
}
else if (strAttributeName  ==  conNews.EditPeople)
{
return mstrEditPeople;
}
else if (strAttributeName  ==  conNews.EditTime)
{
return mstrEditTime;
}
else if (strAttributeName  ==  conNews.Source)
{
return mstrSource;
}
else if (strAttributeName  ==  conNews.IsTop)
{
return mbolIsTop;
}
else if (strAttributeName  ==  conNews.Views)
{
return mintViews;
}
else if (strAttributeName  ==  conNews.Audit)
{
return mstrAudit;
}
else if (strAttributeName  ==  conNews.IsDeleted)
{
return mbolIsDeleted;
}
else if (strAttributeName  ==  conNews.DeletedDate)
{
return mstrDeletedDate;
}
else if (strAttributeName  ==  conNews.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conNews.Id_News)
{
mlngId_News = TransNullToInt(value.ToString());
 AddUpdatedFld(conNews.Id_News);
}
else if (strAttributeName  ==  conNews.NewsTypeId)
{
mstrNewsTypeId = value.ToString();
 AddUpdatedFld(conNews.NewsTypeId);
}
else if (strAttributeName  ==  conNews.NewsTitle)
{
mstrNewsTitle = value.ToString();
 AddUpdatedFld(conNews.NewsTitle);
}
else if (strAttributeName  ==  conNews.NewsContent)
{
mstrNewsContent = value.ToString();
 AddUpdatedFld(conNews.NewsContent);
}
else if (strAttributeName  ==  conNews.ImgPath)
{
mstrImgPath = value.ToString();
 AddUpdatedFld(conNews.ImgPath);
}
else if (strAttributeName  ==  conNews.EditPeople)
{
mstrEditPeople = value.ToString();
 AddUpdatedFld(conNews.EditPeople);
}
else if (strAttributeName  ==  conNews.EditTime)
{
mstrEditTime = value.ToString();
 AddUpdatedFld(conNews.EditTime);
}
else if (strAttributeName  ==  conNews.Source)
{
mstrSource = value.ToString();
 AddUpdatedFld(conNews.Source);
}
else if (strAttributeName  ==  conNews.IsTop)
{
mbolIsTop = TransNullToBool(value.ToString());
 AddUpdatedFld(conNews.IsTop);
}
else if (strAttributeName  ==  conNews.Views)
{
mintViews = TransNullToInt(value.ToString());
 AddUpdatedFld(conNews.Views);
}
else if (strAttributeName  ==  conNews.Audit)
{
mstrAudit = value.ToString();
 AddUpdatedFld(conNews.Audit);
}
else if (strAttributeName  ==  conNews.IsDeleted)
{
mbolIsDeleted = TransNullToBool(value.ToString());
 AddUpdatedFld(conNews.IsDeleted);
}
else if (strAttributeName  ==  conNews.DeletedDate)
{
mstrDeletedDate = value.ToString();
 AddUpdatedFld(conNews.DeletedDate);
}
else if (strAttributeName  ==  conNews.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conNews.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conNews.Id_News  ==  AttributeName[intIndex])
{
return mlngId_News;
}
else if (conNews.NewsTypeId  ==  AttributeName[intIndex])
{
return mstrNewsTypeId;
}
else if (conNews.NewsTitle  ==  AttributeName[intIndex])
{
return mstrNewsTitle;
}
else if (conNews.NewsContent  ==  AttributeName[intIndex])
{
return mstrNewsContent;
}
else if (conNews.ImgPath  ==  AttributeName[intIndex])
{
return mstrImgPath;
}
else if (conNews.EditPeople  ==  AttributeName[intIndex])
{
return mstrEditPeople;
}
else if (conNews.EditTime  ==  AttributeName[intIndex])
{
return mstrEditTime;
}
else if (conNews.Source  ==  AttributeName[intIndex])
{
return mstrSource;
}
else if (conNews.IsTop  ==  AttributeName[intIndex])
{
return mbolIsTop;
}
else if (conNews.Views  ==  AttributeName[intIndex])
{
return mintViews;
}
else if (conNews.Audit  ==  AttributeName[intIndex])
{
return mstrAudit;
}
else if (conNews.IsDeleted  ==  AttributeName[intIndex])
{
return mbolIsDeleted;
}
else if (conNews.DeletedDate  ==  AttributeName[intIndex])
{
return mstrDeletedDate;
}
else if (conNews.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conNews.Id_News  ==  AttributeName[intIndex])
{
mlngId_News = TransNullToInt(value.ToString());
 AddUpdatedFld(conNews.Id_News);
}
else if (conNews.NewsTypeId  ==  AttributeName[intIndex])
{
mstrNewsTypeId = value.ToString();
 AddUpdatedFld(conNews.NewsTypeId);
}
else if (conNews.NewsTitle  ==  AttributeName[intIndex])
{
mstrNewsTitle = value.ToString();
 AddUpdatedFld(conNews.NewsTitle);
}
else if (conNews.NewsContent  ==  AttributeName[intIndex])
{
mstrNewsContent = value.ToString();
 AddUpdatedFld(conNews.NewsContent);
}
else if (conNews.ImgPath  ==  AttributeName[intIndex])
{
mstrImgPath = value.ToString();
 AddUpdatedFld(conNews.ImgPath);
}
else if (conNews.EditPeople  ==  AttributeName[intIndex])
{
mstrEditPeople = value.ToString();
 AddUpdatedFld(conNews.EditPeople);
}
else if (conNews.EditTime  ==  AttributeName[intIndex])
{
mstrEditTime = value.ToString();
 AddUpdatedFld(conNews.EditTime);
}
else if (conNews.Source  ==  AttributeName[intIndex])
{
mstrSource = value.ToString();
 AddUpdatedFld(conNews.Source);
}
else if (conNews.IsTop  ==  AttributeName[intIndex])
{
mbolIsTop = TransNullToBool(value.ToString());
 AddUpdatedFld(conNews.IsTop);
}
else if (conNews.Views  ==  AttributeName[intIndex])
{
mintViews = TransNullToInt(value.ToString());
 AddUpdatedFld(conNews.Views);
}
else if (conNews.Audit  ==  AttributeName[intIndex])
{
mstrAudit = value.ToString();
 AddUpdatedFld(conNews.Audit);
}
else if (conNews.IsDeleted  ==  AttributeName[intIndex])
{
mbolIsDeleted = TransNullToBool(value.ToString());
 AddUpdatedFld(conNews.IsDeleted);
}
else if (conNews.DeletedDate  ==  AttributeName[intIndex])
{
mstrDeletedDate = value.ToString();
 AddUpdatedFld(conNews.DeletedDate);
}
else if (conNews.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conNews.Memo);
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
 AddUpdatedFld(conNews.Id_News);
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
 AddUpdatedFld(conNews.NewsTypeId);
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
 AddUpdatedFld(conNews.NewsTitle);
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
 AddUpdatedFld(conNews.NewsContent);
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
 AddUpdatedFld(conNews.ImgPath);
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
 AddUpdatedFld(conNews.EditPeople);
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
 AddUpdatedFld(conNews.EditTime);
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
 AddUpdatedFld(conNews.Source);
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
 AddUpdatedFld(conNews.IsTop);
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
 AddUpdatedFld(conNews.Views);
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
 AddUpdatedFld(conNews.Audit);
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
 AddUpdatedFld(conNews.IsDeleted);
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
 AddUpdatedFld(conNews.DeletedDate);
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
 AddUpdatedFld(conNews.Memo);
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
 /// 新闻(News)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conNews
{
public new const string _CurrTabName = "News"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "Id_News"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"Id_News", "NewsTypeId", "NewsTitle", "NewsContent", "ImgPath", "EditPeople", "EditTime", "Source", "IsTop", "Views", "Audit", "IsDeleted", "DeletedDate", "Memo"};
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
 /// 常量:"IsDeleted"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDeleted = "IsDeleted";    //是否删除

 /// <summary>
 /// 常量:"DeletedDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DeletedDate = "DeletedDate";    //删除日期

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}