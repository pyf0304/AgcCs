
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsQxUsersENEx
表名:QxUsers(00140015)
生成代码版本:2018.06.11.1
生成日期:2018/06/16 16:03:32
生成者:潘以锋
生成服务器IP:101.251.68.133
工程名称:统一平台
工程ID:0014
相关数据库:101.251.68.133,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:用户管理
模块英文名:UserManage
框架-层名:实体扩展层(EntityLayerEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2018.05.31.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace GeneralPlatform.WebApi
{
    /// <summary>
    /// 用户(QxUsers)
    /// (AutoGCLib.AutoGC6Cs_M:A_GenEntityLayerCodeEx)
    /// </summary>
    [Serializable]
    [DataContractAttribute]
    public class stuUserEx 
    {
        [DataMember]//非常重要
        public string UserId { get; set; }    //用户ID
        [DataMember]//非常重要
        public string UserName { get; set; }    //用户名
        [DataMember]//非常重要
        public string DepartmentName { get; set; }    //部门Id
        [DataMember]//非常重要
        public string UserStateName { get; set; }    //用户状态Id        
        [DataMember]//非常重要
        public string Password { get; set; }    //口令
        [DataMember]//非常重要
        public string EffitiveBeginDate { get; set; }    //有效开始日期
        [DataMember]//非常重要
        public string EffitiveEndDate { get; set; }    //有效结束日期
        [DataMember]//非常重要
        public string StuTeacherId { get; set; }    //学工号
        [DataMember]//非常重要
        public string IdentityName { get; set; }    //身份编号        
        [DataMember]//非常重要
        public string openid { get; set; }    //微信openid
        [DataMember]//非常重要
        public string Email { get; set; }    //邮箱
        [DataMember]//非常重要
        public string PhoneNumber { get; set; }    //电话号码
        [DataMember]//非常重要
        public string UpdDate { get; set; }    //修改日期
        [DataMember]//非常重要
        public string UpdUser { get; set; }    //修改用户
        [DataMember]//非常重要
        public string Memo { get; set; }    //备注               
        [DataMember]//非常重要
        public string RoleName { get; set; }
        [DataMember]//非常重要
        public string PrjId { get; set; }


    }
}