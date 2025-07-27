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
    public  class clsPropertyDef4GC
    {  
        /// <summary>
        /// 操作类型
        /// </summary>
        [DataMember]//非常重要
        public string OperateType { get ; set; }
     
        /// <summary>
        /// 控件类型
        /// </summary>
        [DataMember]//非常重要
        public string ControlType { get; set; }
        /// <summary>
        /// 控件Id
        /// </summary>
        [DataMember]//非常重要
        public string CtrlId { get; set; }
        /// <summary>
        /// 属性名
        /// </summary>
        [DataMember]//非常重要
        public string PropertyName { get; set; }

        /// <summary>
        /// 引用变量
        /// </summary>
        [DataMember]//非常重要
        public string RefVarName { get; set; }
        /// <summary>
        /// 注释
        /// </summary>
        [DataMember]//非常重要
        public string Comment { get; set; }
        /// <summary>
        /// 数据类型
        /// </summary>
        [DataMember]//非常重要
        public string DataType { get; set; }
        /// <summary>
        /// 是否静态函数
        /// </summary>
        [DataMember]//非常重要
        public bool IsStatic { get; set; }

        /// <summary>
        /// 区域类型
        /// </summary>
        [DataMember]//非常重要
        public string ParentDivName { get; set; }

        /// <summary>
        /// 属主类名
        /// </summary>
        [DataMember]//非常重要
        public string ThisClsName { get; set; }

    }
}
