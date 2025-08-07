using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.ServiceProcess;
using System.Text;
using com.taishsoft.commdb;
using System.Collections;
using com.taishsoft.common;
using System.IO;

using com.taishsoft.datetime;
using AGC.Entity;
using AGC.BusinessLogicEx;
using CommonTable.Entity;
using AGC.BusinessLogic;


namespace AgcDataSyn
{
    partial class AgcDataSynService : ServiceBase
    {
        public AgcDataSynService()
        {
            InitializeComponent();
            this.ServiceName = "AgcDataSynService";
            this.CanStop = true;
            this.CanPauseAndContinue = true;
            this.AutoLog = true;
            this.CanShutdown = true;
            try
            {
                //EcardDataClass.clsSysPara.strXMLFolder = clsApplicatoin.AppPath() + "\\XML\\";
                //EcardDataClass.clsSysPara.strXmlSpParaFileName = clsSysPara.strXMLFolder + "XMLSP.xml";

                //mstrConnectString_S = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString_S"].ToString();
                //mstrConnectString_T = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString_T"].ToString();

                mstrCurrDir = System.Configuration.ConfigurationManager.AppSettings["LogDir"].ToString();
                clsDataSynConfigBLEx.mstrCurrDir = mstrCurrDir;
                //mstrConditon_S = System.Configuration.ConfigurationManager.AppSettings["ConditionStr_S"].ToString();
                //mstrTargetProject = System.Configuration.ConfigurationManager.AppSettings["TargetProject"].ToString();
            }
            catch (Exception objException)
            {
                clsGeneralTab.LogErrorS(objException, "In Structure Function.");

                WriteLog(objException.Message);
            }
        }
        //private static bool mbolIsFirstRun = false;

        private static bool mbolIsCanConnect = false;
        private static string mstrCurrDir;		//当前目录
        //private static string mstrConnectString_S;
        //private static string mstrConnectString_T;
        //private static string strAutoDataSynchTime = ""; //自动同步的时间
        //private static clsEcardDataSyn objEcardDataSyn = new clsEcardDataSyn();
        //private static string mstrConditon_S;
        //private static string mstrTargetProject;//目标项目，即需要同步到的数据库


        private static List<clsDataSynConfigEN> arrDataSynConfigObjLst = null;
        static System.Timers.Timer timer;
        protected override void OnStart(string[] args)
        {
            WriteLog("AgcDataSynch Windows Service Started " + DateTime.Now.ToString());
            clsPubFuncVar.objLog.LogDir = mstrCurrDir;
            clsPubFuncVar.objLog.LogFileName = "SrvLog4Agc_DataSyn";
            //arrDataSynConfigObjLst = clsDataSynConfigBL.GetObjLst("IsSynch='1' Order by SynchStartTime");

            try
            {


                //WriteLog("在开始事件中首次运行 " + DateTime.Now.ToString());

                //if (mbolIsFirstRun == false)
                //{

                //        DataSyn();

                //    mbolIsFirstRun = true;
                //}
                //WriteLog("在开始事件中首次运行结束。 " + DateTime.Now.ToString());

            }
            catch (Exception objException)
            {
                clsGeneralTab.LogErrorS(objException, "OnStart(string[] args)!");

                WriteLog(objException.Message);
            }
            SetUpTimer();
        }

        protected override void OnStop()
        {
            // TODO: 在此处添加代码以执行停止服务所需的关闭操作。
            WriteLog("AgcDataSynch WinService Windows Service  Stopped " + DateTime.Now.ToString());
        }


        private static void WriteLog(string strLogContent)
        {
            string mstrFullLogFileName;	//日志文件名
            //mstrCurrDir = @"D:\TaishSoft";
            if (Directory.Exists(mstrCurrDir) == false)
            {
                Directory.CreateDirectory(mstrCurrDir);
            }
            string strCurrDate8 = clsDateTime.getTodayStr(0);
            mstrFullLogFileName = mstrCurrDir + string.Format(@"\SrvLog4Agc_DataSyn{0}.txt", strCurrDate8);

            FileStream fs = new FileStream(mstrFullLogFileName, FileMode.OpenOrCreate,
                FileAccess.Write);
            StreamWriter m_streamWriter = new StreamWriter(fs);
            m_streamWriter.BaseStream.Seek(0, SeekOrigin.End);
            m_streamWriter.WriteLine(clsDateTime.getTodayDateTimeStr(0) + ",数据同步: " + strLogContent + "\r\n");
            m_streamWriter.Flush();
            m_streamWriter.Close();
            fs.Close();
        }
        private static void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {

            string strMsg = "";
            StringBuilder sbErrMsg = new StringBuilder();
            int intRecNum = 0;
            clsSysParaEN.strConnectStrName = "ConnectionString";
            try
            {
                intRecNum = clsFieldTabBL.GetRecCountByCond("1=2");
                if (intRecNum == 0)
                {
                    strMsg = string.Format("测试连接:{0}成功！", clsSysParaEN.strConnectStrName);
                    sbErrMsg.AppendLine(strMsg);
                    clsPubFuncVar.objLog.WriteDebugLog(strMsg);
                    mbolIsCanConnect = true;
                }
            }
            catch (Exception objException)
            {
                mbolIsCanConnect = false;
                strMsg = string.Format("测试连接:{0}不成功！错误:{1}.(In {2})",
                    clsSysParaEN.strConnectStrName, objException.Message, clsStackTrace.GetCurrClassFunction());
                sbErrMsg.AppendLine(strMsg);
                clsPubFuncVar.objLog.WriteDebugLog(strMsg);
            }
            try
            {
                clsSysParaEN.strConnectStrName = "ConnectionStringClient";
                intRecNum = clsFieldTabBL.GetRecCountByCond("1=2");
                if (intRecNum == 0)
                {
                    strMsg = string.Format("测试连接:{0}成功！", clsSysParaEN.strConnectStrName);
                    clsPubFuncVar.objLog.WriteDebugLog(strMsg);
                    sbErrMsg.AppendLine(strMsg);
                    mbolIsCanConnect = mbolIsCanConnect && true;
                }
            }
            catch (Exception objException)
            {
                mbolIsCanConnect = false;
                strMsg = string.Format("测试连接:{0}不成功！错误:{1}.(In {2})",
                    clsSysParaEN.strConnectStrName, objException.Message, clsStackTrace.GetCurrClassFunction());
                sbErrMsg.AppendLine(strMsg);
                clsPubFuncVar.objLog.WriteDebugLog(strMsg);
            }
            if (mbolIsCanConnect == false)
            {
                //MessageBox.Show(sbErrMsg.ToString());
                return;
            }


            System.DateTime dtCurrTime = System.DateTime.Now;


            //foreach (DateTime dtTime in arrRunTime)
            //{
            //    if (dtTime.Hour == dtCurrTime.Hour
            //        && dtTime.Minute == dtCurrTime.Minute)
            //    {
            WriteLog("Copy Data Started " + clsDateTime.getTodayDateTimeStr(0));
            timer.Enabled = false;
            if (arrDataSynConfigObjLst == null)
            {

                clsSysParaEN.strConnectStrName = "ConnectionString";
                arrDataSynConfigObjLst = clsDataSynConfigBL.GetObjLst("IsSynch='1' Order by SynchStartTime");
            }
            try
            {
                clsDataSynConfigBLEx.DataSyn(arrDataSynConfigObjLst, clsPubFuncVar.objLog, "sys");
            }
            catch (Exception objException)
            {
                arrDataSynConfigObjLst = null;
            }

            timer.Enabled = true;
            WriteLog("Copy Data Finished " + clsDateTime.getTodayDateTimeStr(0));
            //    }
            //}
        }

        private static void SetUpTimer()
        {
            timer = new System.Timers.Timer();
            timer.Interval = 100000;
            timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);
            timer.Start();

            WriteLog("Timer Has Begin Work! " + clsDateTime.getTodayDateTimeStr(0));

        }
    }
}
