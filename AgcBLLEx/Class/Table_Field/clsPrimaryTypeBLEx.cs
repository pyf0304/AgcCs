using AGC.BusinessLogic;
using AGC.DAL;
using AGC.Entity;
using AgcCommBase;
using System.Collections.Generic;

namespace AGC.BusinessLogicEx
{
    public class clsPrimaryTypeBLEx : clsPrimaryTypeBL
    {
        /// <summary>
        /// 获取相关对象列表, 从缓存的对象列表中获取.
        /// </summary>
        /// <returns>获取相关对象列表</returns>
        public static List<clsPrimaryTypeEN> GetPrimaryTypeObjLstForBindDdl()
        {
            List<clsPrimaryTypeEN> arrObjLstCache = clsPrimaryTypeBL.GetObjLstCache();

            return arrObjLstCache;
        }
        public static KeyTypeEnum GetKeyTypeEnumByPrimaryType(string strPrimaryTypeId)
        {
            switch (strPrimaryTypeId)
            {
                case enumPrimaryType.PrimaryKey_01:
                    return KeyTypeEnum.PrimaryKey;
                case enumPrimaryType.Identity_02:
                    return KeyTypeEnum.Identity;
                case enumPrimaryType.StringAutoAddPrimaryKey_03:
                    return KeyTypeEnum.StringAutoAddPrimaryKey;
                case enumPrimaryType.IntegerPrimaryKey_04:
                    return KeyTypeEnum.IntegerPrimaryKey;
                case enumPrimaryType.ForeignPrimaryKey_05:
                    return KeyTypeEnum.ForeignPrimaryKey;
                case enumPrimaryType.StringAutoAddPrimaryKeyWithPrefix_06:
                    return KeyTypeEnum.StringAutoAddPrimaryKeyWithPrefix;
                case enumPrimaryType.CompositePrimaryKey_07:
                    return KeyTypeEnum.CompositePrimaryKey;
                default:
                    return KeyTypeEnum.Unknown;
            }

        }
    }
}
