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
    public  class clsGCPara
    {
  
        /// <summary>
        /// 代码类型Id
        /// </summary>
        [DataMember]//非常重要
        public string codeTypeId { get ; set; }

        /// <summary>
        /// 生成代码的函数Id
        /// </summary>
        [DataMember]//非常重要
        public string funcId4GC { get; set; }

        /// <summary>
        /// 功能Id
        /// </summary>
        [DataMember]//非常重要
        public string featureId { get; set; }

        /// <summary>
        /// 数据库类型
        /// </summary>
        [DataMember]//非常重要
        public string dataBaseType { get; set; }
        /// <summary>
        /// 表Id
        /// </summary>
        [DataMember]//非常重要
        public string tabId { get; set; }
        /// <summary>
        /// 界面Id
        /// </summary>
        [DataMember]//非常重要
        public string viewId { get; set; }
        /// <summary>
        /// 工程Id
        /// </summary>
        [DataMember]//非常重要
        public string prjId { get; set; }

        /// <summary>
        /// CM工程Id
        /// </summary>
        [DataMember]//非常重要
        public string cmPrjId { get; set; }
                
        /// <summary>
        /// 数据库Id
        /// </summary>
        [DataMember]//非常重要
        public string prjDataBaseId { get; set; }

        /// <summary>
        /// 应用类型Id
        /// </summary>        
        [DataMember]//非常重要
        public int applicationTypeId { get; set; }

        /// <summary>
        /// 用户Id
        /// </summary>        
        [DataMember]//非常重要
        public string gcUserId { get; set; }
        //[DataMember]//非常重要
        //public string ClassName { get; set; }
        ///// <summary>
        ///// 语言类型
        ///// </summary>
        //[DataMember]//非常重要
        //public string LangType { get; set; }
        /// <summary>
        /// 类型参数
        /// </summary>
        [DataMember]//非常重要
        public string typeParas { get; set; }


        /// <summary>
        /// 应用类型Id
        /// </summary>        
        [DataMember]//非常重要
        public string webSrvClassId { get; set; }

        /// <summary>
        /// 是否记录日志
        /// </summary>        
        [DataMember]//非常重要
        public bool isRecordLog { get; set; }

    }
}
