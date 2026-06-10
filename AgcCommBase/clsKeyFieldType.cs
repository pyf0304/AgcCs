using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgcCommBase
{
    public enum KeyTypeEnum
    {
        Unknown = 0,
        PrimaryKey,
        Identity,
        StringAutoAddPrimaryKey,
        IntegerPrimaryKey,
        ForeignPrimaryKey,
        StringAutoAddPrimaryKeyWithPrefix,
        CompositePrimaryKey
    }
    public class clsKeyFieldType
    {
        public clsKeyFieldType() { }
        public string KeyField { get; set; }
        public string KeyFieldCamel { get; set; }
        public string KeyFieldUpper { get; set; }
        public string KeyFieldLower { get; set; }
        public bool IsNumber { get; set; }
        public KeyTypeEnum KeyType { get; set; } = KeyTypeEnum.PrimaryKey;
        
    }
}
