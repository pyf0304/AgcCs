
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvWebSrvFunctionsBLEx
表名:vWebSrvFunctions
生成代码版本:2017.05.18.1
生成日期:2017/05/19 17:43:59
生成者:
工程名称:AGC
工程ID:0005
模块中文名:项目函数管理
模块英文名:PrjFunction
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

namespace AGC.BusinessLogicEx
{
    /// <summary>
    /// vWebSrvFunctions(vWebSrvFunctions)
    /// 数据源类型:SQL视图
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsvWebSrvFunctionsBLEx : clsvWebSrvFunctionsBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsvWebSrvFunctionsDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsvWebSrvFunctionsDAEx vWebSrvFunctionsDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsvWebSrvFunctionsDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 根据[类Id]获取对象列表
        /// </summary>
        /// <param name = "strWebSrvClassId">类Id</param>
        /// <returns>返回对象列表</returns>
        public static List<clsvWebSrvFunctionsEN> GetObjLstByClassId(string strWebSrvClassId)
        {
            string strCondition = string.Format("{0}='{1}'",
                convWebSrvFunctions.WebSrvClassId, strWebSrvClassId);
            List<clsvWebSrvFunctionsEN> arrObjList = GetObjLst(strCondition);
            return arrObjList;
        }
    }
}