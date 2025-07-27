using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

using System.Collections;
using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;

namespace AgcCommBase
{
    [Serializable]
    [DataContractAttribute]
    public  class clsGCResult
    {
        [DataMember]//非常重要
        public string codeTypeName { get; set; }
        [DataMember]//非常重要
        public string codeTypeENName { get; set; }
        [DataMember]//非常重要
        public string langType{ get ; set; }
        [DataMember]//非常重要
        public string dataBaseType { get; set; }
        [DataMember]//非常重要
        public string tabName { get; set; }
        [DataMember]//非常重要
        public string viewName { get; set; }
        [DataMember]//非常重要
        public string prjName { get; set; }
        [DataMember]//非常重要
        public string prjDataBaseName { get; set; }
        [DataMember]//非常重要
        public string gcUserId { get; set; }

        /// <summary>
        /// 代码类型Id
        /// </summary>
        [DataMember]//非常重要
        public string codeTypeId { get ; set; }
        /// <summary>
        /// 生成的代码文本
        /// </summary>
        [DataMember]//非常重要
        public string codeText { get; set; }

        /// <summary>
        /// 生成代码版本
        /// </summary>
        [DataMember]//非常重要
        public string version { get; set; }
                
        /// <summary>
        /// 错误信息
        /// </summary>
        [DataMember]//非常重要
        public string errorMsg { get; set; }
        /// <summary>
        /// 错误Id
        /// </summary>
        [DataMember]//非常重要
        public int errorId { get; set; }

        /// <summary>
        /// 返回的-类名 
        /// </summary>
        [DataMember]//非常重要
        public string re_ClsName { get; set ; }
        /// <summary>
        /// 返回的-文件名(带模块名)
        /// </summary>
        [DataMember]//非常重要
        public string re_FileNameWithModuleName { get ; set ; }

        /// <summary>
        /// 返回的-函数名
        /// </summary>
        [DataMember]//非常重要
        public string re_FuncName { get; set; }

        /// <summary>
        /// 返回的-函数中文名或者说明
        /// </summary>
        [DataMember]//非常重要
        public string re_FuncCHName { get; set; }

        
        /// <summary>
        /// 代码类型Id
        /// </summary>
        [DataMember]//非常重要
        public string codeTypeId2 { get; set; }
        /// <summary>
        /// 生成的代码文本
        /// </summary>
        [DataMember]//非常重要
        public string codeText2 { get; set; }
        /// <summary>
        /// 返回的-类名 
        /// </summary>
        [DataMember]//非常重要
        public string re_ClsName2 { get; set; }
        /// <summary>
        /// 返回的-文件名(带模块名)
        /// </summary>
        [DataMember]//非常重要
        public string re_FileNameWithModuleName2 { get; set; }
        /// <summary>
        /// 返回的-文件名(带模块名)
        /// </summary>
        [DataMember]//非常重要
        public string codeElementJson { get; set; }
    }
}
