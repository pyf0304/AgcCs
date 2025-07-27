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
    public  class stuUserLoginInfo
    {


        /// <summary>
        /// 用户Id
        /// </summary>
        [DataMember]//非常重要
        public string UserId { get ; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [DataMember]//非常重要
        public string UserName { get; set; }
        /// <summary>
        /// 角色Id
        /// </summary>
        [DataMember]//非常重要
        public string RoleId { get; set; }
        /// <summary>
        /// 角色
        /// </summary>
        [DataMember]//非常重要
        public string RoleName { get; set; }
        /// <summary>
        /// 当前选择工程Id
        /// </summary>
        [DataMember]//非常重要
        public string CurrSelPrjId { get; set; }
        /// <summary>
        /// 当前选择工程
        /// </summary>
        [DataMember]//非常重要
        public string CurrSelPrjName { get; set; }
        /// <summary>
        /// 工程Id
        /// </summary>
        [DataMember]//非常重要
        public string PrjId { get; set; }
        /// <summary>
        /// 数据库Id
        /// </summary>
        [DataMember]//非常重要
        public string CurrPrjDataBaseId { get; set; }

        /// <summary>
        /// 数据库名
        /// </summary>
        [DataMember]//非常重要
        public string PrjDataBaseName { get; set; }
        /// <summary>
        /// 当前数据库类型Id
        /// </summary>
        [DataMember]//非常重要
        public string CurrDataBaseTypeId { get; set; }
        /// <summary>
        /// 应用类型Id
        /// </summary>        
        [DataMember]//非常重要
        public int ApplicationTypeId { get; set; }
        
    }
}
