
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvPrjTabENEx
表名:vPrjTab(00050124)
生成代码版本:2018.07.23.1
生成日期:2018/07/26 10:55:49
生成者:潘以锋
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:字段、表维护
模块英文名:Table_Field
框架-层名:实体扩展层(EntityLayerEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2018.05.31.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;

namespace AGC.Entity
{
    /// <summary>
    /// v工程表(vPrjTab)
    /// (AutoGCLib.AutoGC6Cs_M:A_GenEntityLayerCodeEx)
    /// </summary>
    [Serializable]
    public class clsvPrjTabENEx : clsvPrjTabEN
    {
        private bool mbolIsAppliedInViewList = false;
        /// <summary>
        /// 是否在视图列表区中应用
        /// </summary>
        public bool IsAppliedInViewList
        {
            get
            {
                return mbolIsAppliedInViewList;
            }
            set
            {
                mbolIsAppliedInViewList = value;
            }
        }
    }
}