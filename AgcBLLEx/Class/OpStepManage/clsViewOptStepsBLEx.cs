
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsViewOptStepsBLEx
表名:ViewOptSteps
生成代码版本:2017.05.06.1
生成日期:2017/05/07
生成者:
工程名称:AGC_CSV7
工程ID:0005
模块中文名:操作步骤管理
模块英文名:OpStepManage
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
    /// 界面操作步骤(ViewOptSteps)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsViewOptStepsBLEx : clsViewOptStepsBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsViewOptStepsDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsViewOptStepsDAEx ViewOptStepsDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsViewOptStepsDAEx();
                }
                return uniqueInstanceEx;
            }
        }


        /// <summary>
        /// 功能:下降序号,仅仅1步
        /// </summary>
        /// <param name = "strViewId">界面ID</param>
        /// <param name = "intStepIndex">当前步骤序号</param>
        /// <returns>如果增1成功就返回true, 否则返回false.</returns>
        public bool DownOrderByOne(string strViewId, int intStepIndex)
        {
            //操作步骤:
            //1、获取当前界面的操作步骤的数目(intStepsNum, 操作步骤的数目)；
            //2、如果当前步骤序号大于或等于(intStepsNum, 操作步骤的数目)记录数,就退出本过程,并返回false；
            //3、获取当前记录(本操作序号)的关键字(bintIdForCurrStep)；
            //4、获取下条记录(下一步骤序号)的关键字(bintIdForNextStep)；
            //5、修改当前步骤的序号,使之增1；
            //6、修改下一步骤的序号,使之减1；
            //7、返回TRUE；

            int intStepsNum; //操作步骤的数目
            long lngIdForCurrStep, lngIdForNextStep;   //当前记录(本操作序号)的关键字,下条记录(下一步骤序号)的关键字
            int intNextStepIndex;
            List<string> arrLst;
            //1、获取当前界面的操作步骤的数目(intStepsNum, 操作步骤的数目)；
            intStepsNum = clsGeneralTab2.funGetRecCountByCond(clsViewBtnOptStepsEN._CurrTabName, "ViewId = '" + strViewId + "'");
            //2、如果当前步骤序号大于或等于(intStepsNum, 操作步骤的数目)记录数,就退出本过程,并返回false；
            if (intStepIndex >= intStepsNum) return false;
            //3、获取当前记录(本操作序号)的关键字(lngIdForCurrStep)；
            arrLst = clsGeneralTab2.funGetFldValue(clsViewBtnOptStepsEN._CurrTabName, "mId", "ViewId = '" + strViewId + "' and StepIndex = " + intStepIndex.ToString());
            lngIdForCurrStep = long.Parse(arrLst[0].ToString());
            //4、获取下条记录(下一步骤序号)的关键字(lngIdForNextStep)；
            intNextStepIndex = intStepIndex + 1;
            arrLst = clsGeneralTab2.funGetFldValue(clsViewBtnOptStepsEN._CurrTabName, "mId", "ViewId = '" + strViewId + "' and StepIndex = " + intNextStepIndex.ToString());
            lngIdForNextStep = long.Parse(arrLst[0].ToString());
            //5、修改当前步骤的序号,使之增1；
            clsViewBtnOptStepsBL.SetFldValue(clsViewBtnOptStepsEN._CurrTabName, "StepIndex", intNextStepIndex.ToString(), "mId = " + lngIdForCurrStep.ToString());
            //6、修改下一步骤的序号,使之减1；
            clsViewBtnOptStepsBL.SetFldValue(clsViewBtnOptStepsEN._CurrTabName, "StepIndex", intStepIndex.ToString(), "mId = " + lngIdForNextStep.ToString());
            //7、返回TRUE；
            return true;
        }
        /// <summary>
        /// 功能:上升序号,仅仅1步
        /// </summary>
        /// <param name = "strViewId">界面ID</param>
        /// <param name = "intStepIndex">当前步骤序号</param>
        /// <returns>如果增1成功就返回true, 否则返回false.</returns>
        public bool UpOrderByOne(string strViewId, int intStepIndex)
        {
            //操作步骤:
            //1、如果当前步骤序号等于1, 就退出本过程,并返回false；
            //2、获取当前记录(本操作序号)的关键字(bintIdForCurrStep)；
            //3、获取下条记录(上一步骤序号)的关键字(bintIdForPrevStep)；
            //4、修改当前步骤的序号,使之减1；
            //5、修改上一步骤的序号,使之增1；
            //6、返回TRUE；

            //			int intStepsNum; //操作步骤的数目
            long lngIdForCurrStep, lngIdForPrevStep;   //当前记录(本操作序号)的关键字,下条记录(下一步骤序号)的关键字
            int intPrevStepIndex;
            List<string> arrLst;
            //1、如果当前步骤序号等于1, 就退出本过程,并返回false；
            if (intStepIndex == 1) return false;
            //2、获取当前记录(本操作序号)的关键字(lngIdForCurrStep)；
            arrLst = clsGeneralTab2.funGetFldValue(clsViewBtnOptStepsEN._CurrTabName, "mId", "ViewId = '" + strViewId + "' and StepIndex = " + intStepIndex.ToString());
            lngIdForCurrStep = long.Parse(arrLst[0].ToString());
            //3、获取下条记录(下一步骤序号)的关键字(lngIdForNextStep)；
            intPrevStepIndex = intStepIndex - 1;
            arrLst = clsGeneralTab2.funGetFldValue(clsViewBtnOptStepsEN._CurrTabName, "mId", "ViewId = '" + strViewId + "' and StepIndex = " + intPrevStepIndex.ToString());
            lngIdForPrevStep = long.Parse(arrLst[0].ToString());
            //4、修改当前步骤的序号,使之减1；
            clsViewBtnOptStepsBL.SetFldValue(clsViewBtnOptStepsEN._CurrTabName, "StepIndex", intPrevStepIndex.ToString(), "mId = " + lngIdForCurrStep.ToString());
            //5、修改上一步骤的序号,使之增1；
            clsViewBtnOptStepsBL.SetFldValue(clsViewBtnOptStepsEN._CurrTabName, "StepIndex", intStepIndex.ToString(), "mId = " + lngIdForPrevStep.ToString());
            //7、返回TRUE；
            return true;
        }

        /// <summary>
        /// 功能:获取某一条件的DataTable,其中的代码转换成相应的名称
        /// </summary>
        /// <param name = "strCondition">条件串</param>
        /// <returns>返回已经转换代码的DataTable</returns>
        public static System.Data.DataTable GetViewOptStepsT(string strCondition, string strOrderBy)
        {
            StringBuilder strSQL = new StringBuilder();
            System.Data.DataTable objDT = null;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            strSQL.Append("Select ViewOptSteps.* ");
            strSQL.Append(", ViewInfo.ViewName ViewInfoViewName ");
            strSQL.Append(" from ViewOptSteps ");
            strSQL.Append(" left JOIN ViewInfo on ViewOptSteps.ViewId = ViewInfo.ViewId ");
            strSQL.Append(" where " + strCondition);
            if (strOrderBy.Length > 0)
            {
                strSQL.AppendFormat(" order by {0}", strOrderBy);
            }
            objDT = objSQL.GetDataTable(strSQL.ToString());
            return objDT;
        }
        public new static bool DelRecordEx(long lngMId)
        {
            //操作步骤:
            //1、获取当前序号的步骤序号；
            //2、删除当前记录
            //3、把后面的记录的步骤序号都减1；
            //4、返回TRUE；
            int intCurrStepIndex;
            List<string> arrLst;
            //1、获取当前序号的步骤序号；
            arrLst = clsGeneralTab2.funGetFldValue("ViewOptSteps", "StepIndex", "mId = " + lngMId.ToString());
            intCurrStepIndex = int.Parse(arrLst[0].ToString());
            //2、删除当前记录
            clsViewOptStepsBL.DelRecord(lngMId);
            //3、把后面的记录的步骤序号都减1；
            string strSQL;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            //删除ViewOptSteps本表中与当前对象有关的记录
            strSQL = "Update ViewOptSteps set StepIndex = StepIndex -1 where StepIndex > " + intCurrStepIndex;
            objSQL.ExecSql(strSQL);

            //4、返回TRUE；
            return true;
        }

    }
}