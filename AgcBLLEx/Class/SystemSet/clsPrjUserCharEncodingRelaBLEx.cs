
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsPrjUserCharEncodingRelaBLEx
表名:PrjUserCharEncodingRela
生成代码版本:2017.05.06.1
生成日期:2017/05/07
生成者:
工程名称:AGC_CSV7
工程ID:0005
模块中文名:系统设置
模块英文名:SystemSet
框架-层名:业务逻辑扩展层
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.05.05.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2016.12.13.01
== == == == == == == == == == == == 
*/
using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Xml;
using com.taishsoft.file;
using com.taishsoft.common;
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;

using AGC.Entity;
using System.Data;
using System.Data.SqlClient;
using AGC.DAL;
using AGC.BusinessLogic;
using com.taishsoft.datetime;

namespace AGC.BusinessLogicEx
{
    /// <summary>
    /// 项目用户字符编码关系(PrjUserCharEncodingRela)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsPrjUserCharEncodingRelaBLEx : clsPrjUserCharEncodingRelaBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsPrjUserCharEncodingRelaDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsPrjUserCharEncodingRelaDAEx PrjUserCharEncodingRelaDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsPrjUserCharEncodingRelaDAEx();
                }
                return uniqueInstanceEx;
            }
        }
        public static Encoding GetEncodingByPrjUser(string strPrjId, string strUserId)
        {
            string strCondition = string.Format("PrjId='{0}' And UserId='{1}'", strPrjId, strUserId);
            string strCurrCharEncodingId = "";
            clsPrjUserCharEncodingRelaEN objPrjUserCharEncodingRelaEN = clsPrjUserCharEncodingRelaBL.GetFirstObj_S(strCondition);
            if (objPrjUserCharEncodingRelaEN == null)
            {
                string strCharEncodingId = clsCharEncodingBLEx.GetDefaultCharEncoding();
                objPrjUserCharEncodingRelaEN = new clsPrjUserCharEncodingRelaEN();
                objPrjUserCharEncodingRelaEN.CharEncodingId = strCharEncodingId;
                objPrjUserCharEncodingRelaEN.PrjId = strPrjId;
                objPrjUserCharEncodingRelaEN.UserId = strUserId;
                objPrjUserCharEncodingRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                objPrjUserCharEncodingRelaEN.UpdUserId = strUserId;
                clsPrjUserCharEncodingRelaBL.AddNewRecordBySql2(objPrjUserCharEncodingRelaEN);
                strCurrCharEncodingId = strCharEncodingId;
            }
            else
            {
                strCurrCharEncodingId = objPrjUserCharEncodingRelaEN.CharEncodingId;
            }
            Encoding myEncoding = clsString.GetEncodingObjByCharEncodingId(strCurrCharEncodingId);
            return myEncoding;
        }

        public static string GetCharEncodingIdByPrjUser(string strPrjId, string strUserId)
        {
            string strCondition = string.Format("PrjId='{0}' And UserId='{1}'", strPrjId, strUserId);
            string strCurrCharEncodingId = "";
            clsPrjUserCharEncodingRelaEN objPrjUserCharEncodingRelaEN = clsPrjUserCharEncodingRelaBL.GetFirstObj_S(strCondition);
            if (objPrjUserCharEncodingRelaEN == null)
            {
                string strCharEncodingId = clsCharEncodingBLEx.GetDefaultCharEncoding();
                objPrjUserCharEncodingRelaEN = new clsPrjUserCharEncodingRelaEN();
                objPrjUserCharEncodingRelaEN.CharEncodingId = strCharEncodingId;
                objPrjUserCharEncodingRelaEN.PrjId = strPrjId;
                objPrjUserCharEncodingRelaEN.UserId = strUserId;
                objPrjUserCharEncodingRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                objPrjUserCharEncodingRelaEN.UpdUserId = strUserId;
                clsPrjUserCharEncodingRelaBL.AddNewRecordBySql2(objPrjUserCharEncodingRelaEN);
                strCurrCharEncodingId = strCharEncodingId;
            }
            else
            {
                strCurrCharEncodingId = objPrjUserCharEncodingRelaEN.CharEncodingId;
            }

            return strCurrCharEncodingId;
        }

    }
}