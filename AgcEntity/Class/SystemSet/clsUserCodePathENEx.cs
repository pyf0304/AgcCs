
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsUserCodePathENEx
表名:UserCodePath(00050204)
生成代码版本:2018.08.09.1
生成日期:2018/08/11 15:12:08
生成者:潘以锋
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:系统设置
模块英文名:SystemSet
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
    /// 用户生成路径(UserCodePath)
    /// (AutoGCLib.AutoGC6Cs_M:A_GenEntityLayerCodeEx)
    /// </summary>
    [Serializable]
    public class clsUserCodePathENEx : clsUserCodePathEN
    {
        /// <summary>
        /// 当前处理的工程文件名，完全的工程文件名
        /// </summary>
        public string PrjFileName { get; set; }
        /// <summary>
        /// 完全的代码路径,从根目录开始
        /// </summary>
        public string FullCodePath { get; set; }

        /// <summary>
        /// 完全的代码备份路径
        /// </summary>
        public string FullCodeBackupPath { get; set; }
        /// <summary>
        /// 完全的工程路径
        /// </summary>
        public string FullProjectPath { get; set; }
        /// <summary>
        /// 工程内部代码路径。例如设置的代码路径为：/SamplePrj_DAL/Class, 工程路径为/SamplePrj_DAL，则：工程内的代码路径为：/Class
        /// </summary>
        public string PrjInnerCodePath { get; set; }

        public string NewCodePath { get; set; }

        public bool IsExistCodePathP { get; set; }

        public string NewCodePathBackup { get; set; }
             
                
    }
}