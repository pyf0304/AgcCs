using AGC.BusinessLogic;
using AGC.Entity;

using com.taishsoft.commdb;
using com.taishsoft.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.taishsoft.datetime;
using System.Threading;

namespace AGC.BusinessLogicEx
{
    public class clsLog4GeneTabCodeBLEx
    {
        public static Queue<clsLog4GeneTabCodeEN> arrLog4GeneTabCode_Edit = new Queue<clsLog4GeneTabCodeEN>();
        public static Thread t1 = null;// new Thread(new ThreadStart(Log4GeneTabCode_Edit));
        public static bool AddLog4GeneTabCodeBak(string strTabId, int intApplicationTypeId, string strUserId, string strVersion)
        {
            clsLog4GeneTabCodeEN objLog4GeneTabCodeEN = new clsLog4GeneTabCodeEN();
            objLog4GeneTabCodeEN.GeneCodeDate = clsDateTime.getTodayDateTimeStr(1);
            objLog4GeneTabCodeEN.VersionGeneCode = strVersion;
            objLog4GeneTabCodeEN.UserId = strUserId;
            objLog4GeneTabCodeEN.TabId = strTabId;
            objLog4GeneTabCodeEN.ApplicationTypeId = intApplicationTypeId;
            AddToList(objLog4GeneTabCodeEN);
            if (t1 == null)
            {
                t1 = new Thread(new ThreadStart(Log4GeneTabCode_Edit));
            }
            if (t1.ThreadState == ThreadState.Unstarted || t1.ThreadState == ThreadState.Stopped || t1.ThreadState == ThreadState.Suspended)
            {
                try
                {
                    t1.Start();
                }
                catch(Exception objException)
                {
                    string strMsg = string.Format("开始线程出错！{0}(In {1})" , objException.Message, clsStackTrace.GetCurrClassFunction());
                    clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
                    if (t1.ThreadState == ThreadState.Stopped)
                    {
                        try
                        {
                            t1 = new Thread(new ThreadStart(Log4GeneTabCode_Edit));
                            t1.Start();
                        }
                        catch(Exception objException2)
                        {
                            string strMsg2 = string.Format("再次启动线程出错！{0}(In {1})", objException2.Message, clsStackTrace.GetCurrClassFunction());
                            clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg2);
                        }
                    }
                 
                }
            }
            return true;
        }
        public static bool AddLog4GeneTabCode(string strTabId, string strGcPathId, int intApplicationTypeId, string strUserId, string strVersion)
        {
            clsLog4GeneTabCodeEN objLog4GeneTabCodeEN = new clsLog4GeneTabCodeEN();
            objLog4GeneTabCodeEN.GeneCodeDate = clsDateTime.getTodayDateTimeStr(1);
            objLog4GeneTabCodeEN.VersionGeneCode = strVersion;
            objLog4GeneTabCodeEN.UserId = strUserId;
            objLog4GeneTabCodeEN.TabId = strTabId;
            objLog4GeneTabCodeEN.PrjId = strTabId.Substring(0,4);

            objLog4GeneTabCodeEN.GcPathId = strGcPathId;

            objLog4GeneTabCodeEN.ApplicationTypeId = intApplicationTypeId;

            string strCondition = objLog4GeneTabCodeEN.GetUniCondStr();
            if (clsLog4GeneTabCodeBL.IsExistRecord(strCondition) == false)
            {
                clsLog4GeneTabCodeBL.AddNewRecordBySql2(objLog4GeneTabCodeEN);
            }
            else
            {
                objLog4GeneTabCodeEN.UpdateWithCondition(strCondition);
            }
            return true;
        }
        public static void AddToList(clsLog4GeneTabCodeEN objLog4GeneTabCodeEN)
        {
            if (arrLog4GeneTabCode_Edit.Where(x=>x.TabId == objLog4GeneTabCodeEN.TabId 
                            && x.ApplicationTypeId == objLog4GeneTabCodeEN.ApplicationTypeId
                            && x.UserId == objLog4GeneTabCodeEN.UserId).Count()==0)
            {
                arrLog4GeneTabCode_Edit.Enqueue(objLog4GeneTabCodeEN);
            }
        }

        public  static void Log4GeneTabCode_Edit()
        {
            System.Threading.Thread.Sleep(10000);
            string strMsg = string.Format("开始进行编辑！待编辑对象数：{0}. (In {1})", 
                arrLog4GeneTabCode_Edit.Count, 
                clsStackTrace.GetCurrClassFunction());
        clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
            while (arrLog4GeneTabCode_Edit.Count > 0)
            {
                clsLog4GeneTabCodeEN objLog4GeneTabCodeEN = arrLog4GeneTabCode_Edit.Dequeue();
                string strCondition = objLog4GeneTabCodeEN.GetUniCondStr();
                if (clsLog4GeneTabCodeBL.IsExistRecord(strCondition) == false)
                {
                    clsLog4GeneTabCodeBL.AddNewRecordBySql2(objLog4GeneTabCodeEN);
                }
                else
                {
                    objLog4GeneTabCodeEN.UpdateWithCondition(strCondition);
                }
            }
        }
    }
}
