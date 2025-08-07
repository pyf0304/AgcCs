
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsFeatureImplementationBLEx
表名:FeatureImplementation
生成代码版本:2018.03.11.1
生成日期:2018/03/17 10:29:27
生成者:潘以锋
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
模块中文名:界面管理
模块英文名:PrjInterface
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

using AGC.Entity;
using System.Data;
using System.Data.SqlClient;
using AGC.DAL;
using AGC.BusinessLogic;

namespace AGC.BusinessLogicEx
{
    /// <summary>
    /// 功能实现方式(FeatureImplementation)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsFeatureImplementationBLEx : clsFeatureImplementationBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsFeatureImplementationDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsFeatureImplementationDAEx FeatureImplementationDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsFeatureImplementationDAEx();
                }
                return uniqueInstanceEx;
            }
        }
        /// <summary>
        /// 根据功能Id获取默认的实现方式Id
        /// </summary>
        /// <param name="strFeatureId">功能Id</param>
        /// <returns></returns>
        public static string GetDefaultImplemanetationByFeatureId(string strFeatureId)
        {
            string strCodition = string.Format("{0}='{1}' And {2}='1'", 
                conFeatureImplementation.FeatureId, strFeatureId,
                conFeatureImplementation.IsDefault);
            clsFeatureImplementationEN objFeatureImplementationEN = clsFeatureImplementationBL.GetFirstObj_S(strCodition);
            if (objFeatureImplementationEN == null) return enumViewImplementation.FunctionRegion_0001;
            return objFeatureImplementationEN.ViewImplId;
        }
    }
}