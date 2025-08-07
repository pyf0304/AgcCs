
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvFeatureFuncRelaBLEx
表名:vFeatureFuncRela
生成代码版本:2018.03.19.1
生成日期:2018/03/20 00:11:49
生成者:潘以锋
生成服务器IP:101.251.68.133
工程名称:AGC_CSV7
工程ID:0005
模块中文名:函数管理
模块英文名:PrjFunction
框架-层名:业务逻辑扩展层
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.11.28.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
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

using System.Data;
using System.Data.SqlClient;

using AGC.DAL;
using AGC.BusinessLogic;

namespace AGC.BusinessLogicEx
{
    /// <summary>
    /// vFeatureFuncRela(vFeatureFuncRela)
    /// 数据源类型:SQL视图
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsvFeatureFuncRelaBLEx : clsvFeatureFuncRelaBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsvFeatureFuncRelaDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsvFeatureFuncRelaDAEx vFeatureFuncRelaDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsvFeatureFuncRelaDAEx();
                }
                return uniqueInstanceEx;
            }
        }
        /// <summary>
        /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_GetDataTable4Tab)
        /// </summary>
        /// <param name = "strWhereCond">条件串</param>
        /// <param name = "intApplicationTypeId">应用类型Id</param>
        /// <returns>返回数据表,用DataTable表示</returns>
        public static DataTable GetDataTableByAppId(string strWhereCond, int intApplicationTypeId)
        {
            DataTable objDT = null;
            try
            {
                objDT = vFeatureFuncRelaDAEx.GetDataTableByAppId(strWhereCond, intApplicationTypeId);
                return objDT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:Busi000006)获取表数据出错!(strWhereCond = {2})({0}->{1})\r\n{3}",
                clsStackTrace.GetCurrClassFunctionByLevel(2),
                clsStackTrace.GetCurrClassFunction(),
                strWhereCond,
                objException.Message);
                throw new Exception(strMsg);
            }
        }
    }
}