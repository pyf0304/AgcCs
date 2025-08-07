//using AGC.BusinessLogic;
//using AGC.DAL;
//using AGC.Entity;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace AGC.BusinessLogicEx
//{
//    public class clsPlatDefaRoleBLEx : clsPlatDefaRoleBL
//    {
//        /// <summary>
//        /// 检查唯一性（Uniqueness）--人员类别(PersonType)
//        /// </summary>
//        /// <param name="lngmId">mId（主键）</param>
//        /// <param name="strPersonType">人员类别（要求唯一的字段）</param>
//        /// <returns></returns>
//        public static bool CheckRoleIDAndPrjIdPersonTypeUniqueness(clsPlatDefaRoleEN objPlatDefaRoleEN)
//        {
//            //检测记录是否存在
//            bool bolIsUniqueness;
//            if (objPlatDefaRoleEN == null) return true;
//            if (objPlatDefaRoleEN.mId == 0)
//            {
//                bolIsUniqueness = clsPlatDefaRoleDAEx.CheckRoleIDAndPrjIdPersonTypeUniqueness(
//                objPlatDefaRoleEN.RoleId,
//                objPlatDefaRoleEN.QxPrjId,
//                objPlatDefaRoleEN.PersonType
//                );
//            }
//            else
//            {
//                bolIsUniqueness = clsPlatDefaRoleDAEx.CheckRoleIDAndPrjIdPersonTypeUniqueness(
//                objPlatDefaRoleEN.mId, objPlatDefaRoleEN.RoleId,
//                objPlatDefaRoleEN.QxPrjId,
//                objPlatDefaRoleEN.PersonType);
//            }
//            return bolIsUniqueness;
//        }
//    }
//}
