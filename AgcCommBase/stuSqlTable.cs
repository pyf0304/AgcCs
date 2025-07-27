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
    public  class stuSqlTable
    {


        /// <summary>
        /// 表名
        /// </summary>
        [DataMember]//非常重要
        public string TabName { get ; set; }

        /// <summary>
        /// Sql类型Id
        /// </summary>
        [DataMember]//非常重要
        public string SqlTypeId { get; set; }

       
        
    }
}
