using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgcCommBase
{
    public class clsGCPrjRelaFile
    {
        public bool IsCheckDate { get; set; }
        /// <summary>
        /// 最新的生成系统发布日期
        /// </summary>
        public DateTime NewestPublishDate { get; set; }
        /// <summary>
        /// 当前需要生成代码的代码类型Id
        /// </summary>
        //public string CodeTypeId { get; set; }
        /// <summary>
        /// 纯粹的文件名
        /// </summary>
        //public string FileName { get; set; }
        /// <summary>
        /// 文件全名，带完全的文件路径
        /// </summary>
        //public string FullFileName { get; set; }
        /// <summary>
        /// 完全的工程路径
        /// </summary>
        //public string FullProjectPath { get; set; }
        /// <summary>
        /// 完全的代码备份路径
        /// </summary>
        //public string FullCodeBackupPath { get; set; }

        /// <summary>
        /// 完全的代码路径,从根目录开始
        /// </summary>
        //public string FullCodePath { get; set; }

        //public string SuffixPath { get; set; }
        /// <summary>
        /// 当前处理的工程文件名，完全的工程文件名
        /// </summary>
        //public string PrjFileName { get; set; }
        /// <summary>
        /// 工程内部代码路径。例如设置的代码路径为：/SamplePrj_DAL/Class, 工程路径为/SamplePrj_DAL，则：工程内的代码路径为：/Class
        /// </summary>
        //public string PrjInnerCodePath { get; set; }
        /// <summary>
        /// 工程内部文件名。例如设置的代码路径为：/SamplePrj_DAL/Class, 工程路径为/SamplePrj_DAL，文件名：clsTestEN.cs,模块名：/BaseInfo
        ///             则：工程内的文件名为：Class/BaseInfo/clsTestEN.cs
        /// </summary>
        //public string PrjInnerFileName { get; set; }


    }
}
