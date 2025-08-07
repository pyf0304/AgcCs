
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsButtonTabENEx
 表名:ButtonTab(00050427)
 生成代码版本:2019.03.05.1
 生成日期:2019/03/06 09:43:16
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:AGC
 工程ID:0005
 相关数据库:101.251.68.133,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码
 模块英文名:GeneCode
 框架-层名:实体扩展层(EntityLayerEx)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.02.22.01
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
 /// ButtonTab(ButtonTab)
 /// (AutoGCLib.EntityLayerEx4CSharp:GeneCode)
 /// </summary>
[Serializable]
public class clsButtonTabENEx : clsButtonTabEN
{
        public string Action4Ajax
        {
            get
            {
                return string.Format("{0}Ajax", this.ButtonName);
            }
        }
        public string CtlName
        {
            get
            {
                return string.Format("btn{0}", this.ButtonName); 
            }
        }
        public int OrderNum4Feature { get; set; }
        public int SeqNum { get; set; }
        public string         FeatureId { get; set; }
        public string ValueGivingModeId { get; set; }
        public string ViewFeatureId { get; set; }
        public string GroupName { get; set; }
        public string ButtonName4Mvc { get; set; }
        public bool Is4Visible { get; set; }
        public string EventFuncName { get; set; }
    }
}