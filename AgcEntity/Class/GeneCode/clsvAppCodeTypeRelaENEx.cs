
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvAppCodeTypeRelaENEx
 表名:vAppCodeTypeRela(00050419)
 生成代码版本:2018.09.02.1
 生成日期:2018/09/03 08:09:42
 生成者:潘以锋
 生成服务器IP:202.121.63.42
 工程名称:AGC
 工程ID:0005
 相关数据库:101.251.68.133,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:工程管理
 模块英文名:PrjManage
 框架-层名:实体扩展层(EntityLayerEx)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2018.07.27.01
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
 /// vAppCodeTypeRela(vAppCodeTypeRela)
 /// (AutoGCLib.AutoGC6Cs_M:A_GenEntityLayerCodeEx)
 /// </summary>
[Serializable]
public class clsvAppCodeTypeRelaENEx : clsvAppCodeTypeRelaEN
{
        public string Action4Ajax
        {
            get
            {
                //     return string.Format("{0}Ajax", this.CodeTypeENName);
                     return string.Format("GeneCodeAjax", this.CodeTypeENName);
            }
        }
        public string CtlName
        {
            get
            {
                return string.Format("btn{0}", this.CodeTypeId);
            }
        }
    }
}