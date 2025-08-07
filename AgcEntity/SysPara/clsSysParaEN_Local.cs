using System;
using com.taishsoft.commdbforxml;
using com.taishsoft.common;

namespace AGC.Entity
{
    /// <summary>
    /// clsSysPara 的摘要说明。
    /// </summary>
    public class clsSysParaEN_Local : clsSysParaEN
    {

        public static clsLog objLog4GCError = null;//new clsLog();

        private static bool mbolIsBackupForGeneCode = true;
        /// <summary>
        /// 当生成代码时是否备份
        /// </summary>
        public static bool IsBackupForGeneCode
        {
            get { return clsSysParaEN_Local.mbolIsBackupForGeneCode; }
            set
            {
                clsSysParaEN_Local.mbolIsBackupForGeneCode = value;
            }
        }
        private static bool mbolIsUseFieldCache = false;
        /// <summary>
        /// 是否使用字段缓存
        /// </summary>
        public static bool IsUseFieldCache
        {
            get { return clsSysParaEN_Local.mbolIsUseFieldCache; }
            set { clsSysParaEN_Local.mbolIsUseFieldCache = value; }
        }
        /// <summary>
        /// 是否处理SQL注入,20090524添加该功能
        /// </summary>
        public static bool bolIsAccessSqlInjection = false;

        public static string strMainJobDesc = "主要工作";
        public static string strDynamicLibPath = "";

        public static string strCurrPrjConnectString = "";  //当前所选工作的连接串
        public static string strVersion = "2025.08.02.1";

        public clsSysParaEN_Local()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }
    }
}
