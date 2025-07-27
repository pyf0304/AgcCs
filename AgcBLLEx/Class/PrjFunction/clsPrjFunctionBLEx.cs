
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsPrjFunctionBLEx
表名:PrjFunction
生成代码版本:2017.05.06.1
生成日期:2017/05/07
生成者:
工程名称:AGC_CSV7
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
using com.taishsoft.datetime;

namespace AGC.BusinessLogicEx
{
    /// <summary>
    /// 工程函数(PrjFunction)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsPrjFunctionBLEx : clsPrjFunctionBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsPrjFunctionDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsPrjFunctionDAEx PrjFunctionDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsPrjFunctionDAEx();
                }
                return uniqueInstanceEx;
            }
        }
        public static bool IsExistSameFunName(string strPrjId, string strFuncName)
        {
            StringBuilder strCondition = new StringBuilder();
            strCondition.AppendFormat("PrjId = '{1}' and FuncName = '{0}'", strFuncName, strPrjId);
            return clsPrjFunctionBL.IsExistRecord(strCondition.ToString());
        }
        public static bool SaveToHistory(clsPrjFunctionEN objSourPrjFunc, string strUpdator)
        {
            clsPrjFunctionHistoryEN objPrjFuncHis = new clsPrjFunctionHistoryEN();
            objPrjFuncHis.FuncId = objSourPrjFunc.FuncId;
            objPrjFuncHis.FuncCode = objSourPrjFunc.FuncCode;
            objPrjFuncHis.Memo = objSourPrjFunc.Memo;
            objPrjFuncHis.PrjId = objSourPrjFunc.PrjId;
            objPrjFuncHis.UserId = objSourPrjFunc.UserId;
            objPrjFuncHis.Updator = strUpdator;
            objPrjFuncHis.UpdDate = clsDateTime.getTodayStr(0);
            objPrjFuncHis.UpdTime = clsDateTime.getCurrTime(0);
            return clsPrjFunctionHistoryBL.AddNewRecordBySql2(objPrjFuncHis);
        }
    }
}