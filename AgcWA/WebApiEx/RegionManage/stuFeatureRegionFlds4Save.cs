using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AGC.WebApi
{
    [Serializable]
    [DataContractAttribute]
    public class stuFeatureRegionFlds4Save
    {
        [DataMember]
        public string RegionId { get; set; }

        [DataMember]
        public int ApplicationTypeId { get; set; }

        [DataMember]
        public string TabId { get; set; }
        [DataMember]
        public string UserId { get; set; }
        [DataMember]
        public string objString { get; set; }
    }
}