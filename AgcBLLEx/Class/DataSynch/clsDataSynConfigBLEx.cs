
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsDataSynConfigBLEx
表名:DataSynConfig
生成代码版本:2017.06.11.2
生成日期:2017/06/21 18:18:09
生成者:
工程名称:AGC
工程ID:0005
模块中文名:系统设置
模块英文名:SystemSet
框架-层名:业务逻辑扩展层
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.06.10.01
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
using System.Reflection;


namespace AGC.BusinessLogicEx
{
    public static class clsDataSynConfigBLEx_Static
    {


        /// <summary>
        /// 插入记录存盘到数据表中
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_AddRecordEx)
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        public static bool AddRecordEx2(this clsDataSynConfigEN objDataSynConfigEN)
        {
            //操作步骤:
            //1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            //2、检查唯一性
            //3、检查传进去的对象属性是否合法
            //4、把数据实体层的数据存贮到数据库中
            string strMsg;  //专门用于传递信息的变量
                            //1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            try
            {
                //2、检查传进去的对象属性是否合法
                objDataSynConfigEN.CheckPropertyNew();
                //5.2、检查唯一性
                if (objDataSynConfigEN.CheckUniqueness_TabName() == false)
                {
                    strMsg = string.Format("(表名(TabName)=[{0}])已经存在，不能重复!", objDataSynConfigEN.TabName);
                    throw new Exception(strMsg);
                }
                //6、把数据实体层的数据存贮到数据库中
                objDataSynConfigEN.AddNewRecord();
            }
            catch (Exception objException)
            {
                strMsg = "(errid:BlEx000003)添加记录不成功!" + objException.Message;
                throw new Exception(strMsg);
            }
            return true;
        }

        /// <summary>
        /// 修改记录存盘到数据表中
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_UpdateRecordEx)
        /// </summary>
        /// <param name = "objDataSynConfigEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        public static bool UpdateRecordEx2(this clsDataSynConfigEN objDataSynConfigEN)
        {
            //操作步骤:
            //1、检查传进去的对象属性是否合法
            //2、检查唯一性
            //3、把数据实体层的数据存贮到数据库中
            string strMsg;  //专门用于传递信息的变量
            try
            {
                //1、检查传进去的对象属性是否合法
                objDataSynConfigEN.CheckPropertyNew();
                //2、检查唯一性
                if (objDataSynConfigEN.CheckUniqueness_TabName() == false)
                {
                    strMsg = "(表名(TabName))不能重复!";
                    throw new Exception(strMsg);
                }
                //4、把数据实体层的数据存贮到数据库中
                objDataSynConfigEN.Update();
            }
            catch (Exception objException)
            {
                strMsg = "修改记录不成功!" + objException.Message;
                throw new Exception(strMsg);
            }
            return true;
        }

        /// <summary>
        /// 编辑记录存盘到数据表中。如果存在相关记录就修改，不存在就添加
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_EditRecordEx)
        /// </summary>
        /// <param name = "objDataSynConfig">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        public static bool EditRecordEx2(this clsDataSynConfigEN objDataSynConfig)
        {
            //操作步骤:
            //1、检查传进去的对象属性是否合法
            //2、检查唯一性
            //3、把数据实体层的数据存贮到数据库中
            clsDataSynConfigEN objDataSynConfig_Cond = new clsDataSynConfigEN();
            string strCondition = objDataSynConfig_Cond
            .SetTabName(objDataSynConfig.TabName, "=")
            .GetCombineCondition();
            objDataSynConfig._IsCheckProperty = true;
            bool bolIsExist = clsDataSynConfigBL.IsExistRecord(strCondition);
            if (bolIsExist)
            {
                objDataSynConfig.mId = clsDataSynConfigBL.GetFirstID_S(strCondition);
                objDataSynConfig.UpdateWithCondition(strCondition);
            }
            else
            {
                objDataSynConfig.AddNewRecord();
            }
            return true;
        }



        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objDataSynConfigENS">源对象</param>
        /// <returns>目标对象=>clsDataSynConfigEN:objDataSynConfigENT</returns>
        public static clsDataSynConfigENEx CopyToEx(this clsDataSynConfigEN objDataSynConfigENS)
        {
            try
            {
                clsDataSynConfigENEx objDataSynConfigENT = new clsDataSynConfigENEx();
                clsDataSynConfigBL.DataSynConfigDA.CopyTo(objDataSynConfigENS, objDataSynConfigENT);
                return objDataSynConfigENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000001)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
        /// </summary>
        /// <param name = "objDataSynConfigENS">源对象</param>
        /// <returns>目标对象=>clsDataSynConfigEN:objDataSynConfigENT</returns>
        public static clsDataSynConfigEN CopyTo(this clsDataSynConfigENEx objDataSynConfigENS)
        {
            try
            {
                clsDataSynConfigEN objDataSynConfigENT = new clsDataSynConfigEN();
                clsDataSynConfigBL.CopyTo(objDataSynConfigENS, objDataSynConfigENT);
                return objDataSynConfigENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
    }

    /// <summary>
    /// 同步配置(DataSynConfig)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsDataSynConfigBLEx : clsDataSynConfigBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsDataSynConfigDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsDataSynConfigDAEx DataSynConfigDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsDataSynConfigDAEx();
                }
                return uniqueInstanceEx;
            }
        }
        public static string mstrCurrDir;		//当前目录
        public static void DataSyn(List<clsDataSynConfigEN> arrDataSynConfigObjLst, clsLog objLog, string strUserId)
        {
            DateTime objNowDT = DateTime.Now;
            string strCurrDate8 = clsDateTime_Db.GetDataBaseDate8();
            int intSynchRecNum = 0, intSynchRecNum4Main = 0;
            int intSynchRecNum_Sum = 0, intSynchRecNum4Main_Sum = 0;

            //objEcardDataSyn.ConnectString_S = mstrConnectString_S;
            //objEcardDataSyn.ConnectString_T = mstrConnectString_T;
            //objEcardDataSyn.ConditionStr_S = mstrConditon_S;
            //objEcardDataSyn.CurrDir = mstrCurrDir;
            try
            {
                foreach (clsDataSynConfigEN objDataSynConfigEN in arrDataSynConfigObjLst)
                {

                    if (objDataSynConfigEN.SynchCycle == "DAY") // 每天
                    {
                        if (objDataSynConfigEN.lastExecuteDate == strCurrDate8) continue;
                        if (string.IsNullOrEmpty(objDataSynConfigEN.lastExecuteDate) == false)
                        {
                            DateTime objDT = clsDateTime.GetDateTimeByDateStr8(objDataSynConfigEN.lastExecuteDate);
                            int intDays = objNowDT.Subtract(objDT).Days;
                            if (intDays == 1)
                            {
                                string strCurrTime = objNowDT.ToShortTimeString();
                                if (strCurrTime.CompareTo(objDataSynConfigEN.SynchTime) < 0 && string.IsNullOrEmpty(objDataSynConfigEN.lastExecuteDate) == false) continue;
                            }
                        }
                    }
                    else if (objDataSynConfigEN.SynchCycle == "YEAR") // 每年
                    {
                        if (objDataSynConfigEN.lastExecuteDate == strCurrDate8) continue;

                        string strCurrTime = objNowDT.ToShortTimeString();
                        clsDateTime objDateTime = new clsDateTime(objDataSynConfigEN.SynchDate);
                        clsDateTime objDateTime_Curr = new clsDateTime(strCurrDate8);
                        if (objDateTime.Month != objDateTime_Curr.Month
                            || objDateTime.Day != objDateTime_Curr.Day) continue;

                    }
                    objDataSynConfigEN.SynchStartTime = clsDateTime_Db.GetDataBaseDateTime14();

                    clsDataSynConfigBL.UpdateBySql2(objDataSynConfigEN);
                    string strMsg = "";
                    string strCondition = "";
                    string strCondition4Web = "";
                    switch (objDataSynConfigEN.TabName)
                    {
                        case "FieldTab":
                            strCondition = GetCondition(objDataSynConfigEN.SynCondition, objDataSynConfigEN);// "(SynchToClientDate is null or modifydate>SynchToClientDate)";
                            strCondition4Web = GetCondition(objDataSynConfigEN.SynCondition4Web, objDataSynConfigEN);// "(SynchToClientDate is null or modifydate>SynchToClientDate)";
                            objDataSynConfigEN.SynCondition = strCondition;
                            objDataSynConfigEN.SynCondition4Web = strCondition4Web;
                            strCondition += "[exclude]or [/exclude]";
                            strCondition4Web += "[exclude]or [/exclude]";

                            strMsg = "字段表（FieldTab）同步开始!";
                            WriteLog(strMsg);
                            intSynchRecNum = 1;
                            intSynchRecNum4Main = 1;
                            intSynchRecNum_Sum = 0;
                            intSynchRecNum4Main_Sum = 0;
                            //while (intSynchRecNum > 0)
                            //{
                            //    intSynchRecNum = clsFieldTabBLEx.SynchToClientByCondition(strCondition, strUserId);
                            //    intSynchRecNum_Sum += intSynchRecNum;
                            //}
                            //while (intSynchRecNum4Main > 0)
                            //{
                            //    intSynchRecNum4Main = clsFieldTabBLEx.SynchToServerByCondition(strCondition4Web, strUserId);
                            //    intSynchRecNum4Main_Sum += intSynchRecNum4Main;
                            //}
                            strMsg = string.Format("字段表（FieldTab）同步结束!共从Server库到Client库同步：{0} 记录，从Client到Server库同步：{1} 记录，。", intSynchRecNum_Sum, intSynchRecNum4Main_Sum);
                            WriteLog(strMsg);
                            clsSysParaEN.strConnectStrName = "ConnectionString";
                            objDataSynConfigEN.lastExecuteDate = strCurrDate8;
                            objDataSynConfigEN.SynchEndTime = clsDateTime_Db.GetDataBaseDateTime14();
                            clsDataSynConfigBL.UpdateBySql2(objDataSynConfigEN);
                            break;
                        case "PrjTab":
                            strCondition = GetCondition(objDataSynConfigEN.SynCondition, objDataSynConfigEN);// "(SynchToClientDate is null or modifydate>SynchToClientDate)";
                            strCondition4Web = GetCondition(objDataSynConfigEN.SynCondition4Web, objDataSynConfigEN);// "(SynchToClientDate is null or modifydate>SynchToClientDate)";
                            objDataSynConfigEN.SynCondition = strCondition;
                            objDataSynConfigEN.SynCondition4Web = strCondition4Web;
                            strCondition += "[exclude]or [/exclude]";
                            strCondition4Web += "[exclude]or [/exclude]";

                            strMsg = "工程表（PrjTab）同步开始!";
                            WriteLog(strMsg);
                            //intSynchRecNum = clsPrjTabBLEx.SynchToClientByCondition(strCondition, strUserId);
                            //intSynchRecNum4Main = clsPrjTabBLEx.SynchToServerByCondition(strCondition4Web, strUserId);

                            strMsg = string.Format("工程表（PrjTab）同步结束!共从主库到Client同步：{0} 记录，从Client到主库同步：{1} 记录，。", intSynchRecNum, intSynchRecNum4Main);
                            WriteLog(strMsg);
                            clsSysParaEN.strConnectStrName = "ConnectionString";
                            objDataSynConfigEN.lastExecuteDate = strCurrDate8;
                            objDataSynConfigEN.SynchEndTime = clsDateTime_Db.GetDataBaseDateTime14();
                            clsDataSynConfigBL.UpdateBySql2(objDataSynConfigEN);
                            break;
                        case "PrjTabFld":
                            strCondition = GetCondition(objDataSynConfigEN.SynCondition, objDataSynConfigEN);// "(SynchToClientDate is null or modifydate>SynchToClientDate)";
                            strCondition4Web = GetCondition(objDataSynConfigEN.SynCondition4Web, objDataSynConfigEN);// "(SynchToClientDate is null or modifydate>SynchToClientDate)";
                            objDataSynConfigEN.SynCondition = strCondition;
                            objDataSynConfigEN.SynCondition4Web = strCondition4Web;
                            strCondition += "[exclude]or [/exclude]";
                            strCondition4Web += "[exclude]or [/exclude]";

                            strMsg = "工程表字段（PrjTabFld）同步开始!";
                            WriteLog(strMsg);
                            intSynchRecNum = 1;
                            intSynchRecNum4Main = 1;
                            intSynchRecNum_Sum = 0;
                            intSynchRecNum4Main_Sum = 0;
                            while (intSynchRecNum > 0)
                            {
                                //intSynchRecNum = clsPrjTabFldBLEx.SynchToClientByCondition(strCondition, strUserId);
                                intSynchRecNum_Sum += intSynchRecNum;
                            }

                            while (intSynchRecNum4Main > 0)
                            {
                                //intSynchRecNum4Main = clsPrjTabFldBLEx.SynchToServerByCondition(strCondition4Web, strUserId);
                                intSynchRecNum4Main_Sum += intSynchRecNum4Main;
                            }
                            strMsg = string.Format("工程表字段（PrjTabFld）同步结束!共从主库到Client同步：{0} 记录，从Client到主库同步：{1} 记录，。", intSynchRecNum_Sum, intSynchRecNum4Main_Sum);
                            WriteLog(strMsg);
                            clsSysParaEN.strConnectStrName = "ConnectionString";
                            objDataSynConfigEN.lastExecuteDate = strCurrDate8;
                            objDataSynConfigEN.SynchEndTime = clsDateTime_Db.GetDataBaseDateTime14();
                            clsDataSynConfigBL.UpdateBySql2(objDataSynConfigEN);
                            break;
                        //case conDGRegion._CurrTabName:
                        //    DataSynch(objDataSynConfigEN, typeof(clsDGRegionBLEx), strUserId, strCurrDate8);
                        //    break;
                        case conDGRegionFlds._CurrTabName:
                            DataSynch(objDataSynConfigEN, typeof(clsDGRegionFldsBLEx), strUserId, strCurrDate8);
                            break;
                        //case conEditRegion._CurrTabName:
                        //    DataSynch(objDataSynConfigEN, typeof(clsEditRegionBLEx), strUserId, strCurrDate8);
                        //    break;
                        case conEditRegionFlds._CurrTabName:
                            DataSynch(objDataSynConfigEN, typeof(clsEditRegionFldsBLEx), strUserId, strCurrDate8);
                            break;
                        //case conQueryRegion._CurrTabName:
                        //    DataSynch(objDataSynConfigEN, typeof(clsQueryRegionBLEx), strUserId, strCurrDate8);
                        //    break;
                        case conQryRegionFlds._CurrTabName:
                            DataSynch(objDataSynConfigEN, typeof(clsQryRegionFldsBLEx), strUserId, strCurrDate8);
                            break;
                        //case conFeatureRegion._CurrTabName:
                        //    DataSynch(objDataSynConfigEN, typeof(clsFeatureRegionBLEx), strUserId, strCurrDate8);
                        //    break;
                        case conFeatureRegionFlds._CurrTabName:
                            DataSynch(objDataSynConfigEN, typeof(clsFeatureRegionFldsBLEx), strUserId, strCurrDate8);
                            break;
                        case conExcelExportRegionFlds._CurrTabName:
                            DataSynch(objDataSynConfigEN, typeof(clsExcelExportRegionFldsBLEx), strUserId, strCurrDate8);
                            break;
                        //case conExcelExportRegion._CurrTabName:
                        //    DataSynch(objDataSynConfigEN, typeof(clsExcelExportRegionBLEx), strUserId, strCurrDate8);
                        //    break;
                        case conCMRequirement._CurrTabName:
                            DataSynch(objDataSynConfigEN, typeof(clsCMRequirementBLEx), strUserId, strCurrDate8);
                            break;
                        case conCMFeature._CurrTabName:
                            DataSynch(objDataSynConfigEN, typeof(clsCMFeatureBLEx), strUserId, strCurrDate8);
                            break;
                        case conCMFeatureRequirement._CurrTabName:
                            DataSynch(objDataSynConfigEN, typeof(clsCMFeatureRequirementBLEx), strUserId, strCurrDate8);
                            break;
                        case conCMProject._CurrTabName:
                            DataSynch(objDataSynConfigEN, typeof(clsCMProjectBLEx), strUserId, strCurrDate8);
                            break;
                        case conCMFunctionKeyWord._CurrTabName:
                            DataSynch(objDataSynConfigEN, typeof(clsCMFunctionKeyWordBLEx), strUserId, strCurrDate8);
                            break;
                        case conCMFunction._CurrTabName:
                            DataSynch(objDataSynConfigEN, typeof(clsCMFunctionBLEx), strUserId, strCurrDate8);
                            break;
                        case conViewRegion._CurrTabName:
                            DataSynch(objDataSynConfigEN, typeof(clsViewRegionBLEx), strUserId, strCurrDate8);
                            break;
                        case "ViewInfo":
                            DataSynch(objDataSynConfigEN, typeof(clsViewInfoBLEx), strUserId, strCurrDate8);
                            //strCondition = GetCondition(objDataSynConfigEN.SynCondition, objDataSynConfigEN);// "(SynchToClientDate is null or modifydate>SynchToClientDate)";
                            //strCondition4Web = GetCondition(objDataSynConfigEN.SynCondition4Web, objDataSynConfigEN);// "(SynchToClientDate is null or modifydate>SynchToClientDate)";
                            //objDataSynConfigEN.SynCondition = strCondition;
                            //objDataSynConfigEN.SynCondition4Web = strCondition4Web;
                            //strCondition += "[exclude]or [/exclude]";
                            //strCondition4Web += "[exclude]or [/exclude]";

                            //strMsg = "工程表（ViewInfo）同步开始!";
                            //WriteLog(strMsg);
                            //intSynchRecNum = clsViewInfoBLEx.SynchToClientByCondition(strCondition, strUserId);
                            //intSynchRecNum4Main = clsViewInfoBLEx.SynchToServerByCondition(strCondition4Web, strUserId);

                            //strMsg = string.Format("工程表（ViewInfo）同步结束!共从主库到Client同步：{0} 记录，从Client到主库同步：{1} 记录，。", intSynchRecNum, intSynchRecNum4Main);
                            //WriteLog(strMsg);
                            //clsSysParaEN.strConnectStrName = "ConnectionString";
                            //objDataSynConfigEN.lastExecuteDate = strCurrDate8;
                            //objDataSynConfigEN.SynchEndTime = clsDateTime_Db.GetDataBaseDateTime14();
                            //clsDataSynConfigBL.UpdateBySql2(objDataSynConfigEN);
                            break;
                    }
                }
                //intSynchRecNum =    objEcardDataSyn.DataSynFromEcard();

            }
            catch (Exception objException)
            {
                WriteLog(objException.Message);
                throw objException;
            }
            //WriteLog(string.Format("同步数据完成!共同步：{0} 记录。当前时间:{1}", intSynchRecNum, clsDateTime.getTodayDateTimeStr(1)));

        }

        public static bool DataSynch(clsDataSynConfigEN objDataSynConfigEN, Type tClsName, string strUserId, string strCurrDate8)
        {
            string strCondition = GetCondition(objDataSynConfigEN.SynCondition, objDataSynConfigEN);// "(SynchToClientDate is null or modifydate>SynchToClientDate)";
            string strCondition4Web = GetCondition(objDataSynConfigEN.SynCondition4Web, objDataSynConfigEN);// "(SynchToClientDate is null or modifydate>SynchToClientDate)";
            objDataSynConfigEN.SynCondition = strCondition;
            objDataSynConfigEN.SynCondition4Web = strCondition4Web;
            strCondition += "[exclude]or [/exclude]";
            strCondition4Web += "[exclude]or [/exclude]";

            string strMsg = string.Format("表:{0}同步开始!", objDataSynConfigEN.TabName);
            WriteLog(strMsg);
            string strFuncName = "SynchToClientByCondition";
            MethodInfo mt = tClsName.GetMethod(strFuncName, BindingFlags.Static | BindingFlags.Public);
            int intSynchRecNum = 0;
            if (mt == null)
            {
                strMsg = string.Format("在类:[{0}]中没有相应的函数:{1}.(In {2})",
                    tClsName.Name,
                    strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            else
            {
                intSynchRecNum = (int)tClsName.InvokeMember(strFuncName,
System.Reflection.BindingFlags.InvokeMethod | System.Reflection.BindingFlags.Static
| System.Reflection.BindingFlags.Public, null, null,
new object[] { strCondition, strUserId });  //最后一个是参数:0


                //                string str = (string)mt.Invoke(null, new object[] { "1234567890123"    });

                //intSynchRecNum = (int)mt.Invoke(this, new object[] { strCondition, strUserId });

                //Console.WriteLine(str);
            }

            strFuncName = "SynchToServerByCondition";
            mt = tClsName.GetMethod(strFuncName, BindingFlags.Static | BindingFlags.Public);
            int intSynchRecNum4Main = 0;
            if (mt == null)
            {
                strMsg = string.Format("在类:[{0}]中没有相应的函数:{1}.(In {2})",
                    tClsName.Name,
                    strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            else
            {
                intSynchRecNum4Main = (int)tClsName.InvokeMember(strFuncName,
                                System.Reflection.BindingFlags.InvokeMethod 
                                | System.Reflection.BindingFlags.Static
                                | System.Reflection.BindingFlags.Public, null, null,
                                new object[] { strCondition, strUserId });  //最后一个是参数:0

                //intSynchRecNum4Main = (int)mt.Invoke(this, new object[] { strCondition4Web, strUserId });

                //Console.WriteLine(str);
            }

            //int intSynchRecNum = clsViewInfoBLEx.SynchToClientByCondition(strCondition, strUserId);
            //int intSynchRecNum4Main = clsViewInfoBLEx.SynchToServerByCondition(strCondition4Web, strUserId);

            strMsg = string.Format("表:{0}同步结束!共从主库到Client同步：{1} 记录，从Client到主库同步：{2} 记录，。",
                objDataSynConfigEN.TabName,
                intSynchRecNum, intSynchRecNum4Main);
            WriteLog(strMsg);
            clsSysParaEN.strConnectStrName = "ConnectionString";
            objDataSynConfigEN.lastExecuteDate = strCurrDate8;
            objDataSynConfigEN.SynchEndTime = clsDateTime_Db.GetDataBaseDateTime14();
            clsDataSynConfigBL.UpdateBySql2(objDataSynConfigEN);

            return true;
           
        }


        public static string GetCondition(string strCondition, clsDataSynConfigEN objDataSynConfigEN)
        {
            string strCondition_New = strCondition;
            while (strCondition_New.IndexOf("''") >= 0)
            {
                strCondition_New = strCondition_New.Replace("''", "'");
            }
            if (string.IsNullOrEmpty(objDataSynConfigEN.lastExecuteDate)) return strCondition_New;
            strCondition_New += string.Format(" and UpdDate>'{0}'", objDataSynConfigEN.lastExecuteDate);
            return strCondition_New;
        }
        private static void WriteLog(string strLogContent)
        {
            string mstrFullLogFileName;	//日志文件名
            //mstrCurrDir = @"D:\TaishSoft";
            if (Directory.Exists(mstrCurrDir) == false)
            {
                Directory.CreateDirectory(mstrCurrDir);
            }
            mstrFullLogFileName = mstrCurrDir + @"\EventLog4Edu_DataSynch.txt";

            FileStream fs = new FileStream(mstrFullLogFileName, FileMode.OpenOrCreate,
                FileAccess.Write);
            StreamWriter m_streamWriter = new StreamWriter(fs);
            m_streamWriter.BaseStream.Seek(0, SeekOrigin.End);
            m_streamWriter.WriteLine(clsDateTime.getTodayDateTimeStr(1) + ",数据同步: " + strLogContent + "\r\n");
            m_streamWriter.Flush();
            m_streamWriter.Close();
            fs.Close();
        }
    }
}