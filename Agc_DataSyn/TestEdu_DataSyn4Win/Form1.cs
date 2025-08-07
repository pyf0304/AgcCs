using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Const;
using AGC.Entity;
using Agc_DataSyn;
using com.taishsoft.common;
using com.taishsoft.datetime;
using CommonTable.Entity;


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestAgc_DataSyn4Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static bool mbolIsCanConnect = false;
        private static string mstrCurrDir;		//当前目录
        private static List<clsDataSynConfigEN> arrDataSynConfigObjLst = null;
        static System.Timers.Timer timer;
        private void btnSynchFldTab_Click(object sender, EventArgs e)
        {
            //string strCondition = "StuId like '080%'";
            try
            {
                //clsXsStuBLEx.SynchToWebByCondition(strCondition);
                //DataSyn();
                string strCondition = string.Format("{0}='1' Order by {1},{2}",
               conDataSynConfig.IsSynch,
               conDataSynConfig.SynchTime,
               conDataSynConfig.OrderNum);
                arrDataSynConfigObjLst = clsDataSynConfigBL.GetObjLst(strCondition);


                SetUpTimer();
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }
        private string GetCondition(string strCondition)
        {
            string strCondition_New = strCondition;
            while (strCondition_New.IndexOf("''") >= 0)
            {
                strCondition_New = strCondition_New.Replace("''", "'");
            }
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
            mstrFullLogFileName = mstrCurrDir + @"\Agc_DataSynch.txt";

            FileStream fs = new FileStream(mstrFullLogFileName, FileMode.OpenOrCreate,
                FileAccess.Write);
            StreamWriter m_streamWriter = new StreamWriter(fs);
            m_streamWriter.BaseStream.Seek(0, SeekOrigin.End);
            m_streamWriter.WriteLine(clsDateTime.getTodayDateTimeStr(0) + ",数据同步: " + strLogContent + "\r\n");
            m_streamWriter.Flush();
            m_streamWriter.Close();
            fs.Close();
        }
        private void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {

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
                string strCondition = string.Format("{0}='1' Order by {1},{2}",
                    conDataSynConfig.IsSynch,
                    conDataSynConfig.SynchTime,
                    conDataSynConfig.OrderNum);
                arrDataSynConfigObjLst = clsDataSynConfigBL.GetObjLst(strCondition);
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

        private void SetUpTimer()
        {
            timer = new System.Timers.Timer();
            timer.Interval = 100000;
            timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);
            timer.Start();

            WriteLog("Timer Has Begin Work! " + clsDateTime.getTodayDateTimeStr(0));

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            mstrCurrDir = @"D:\Log\Agc_DataSyn\";
            clsDataSynConfigBLEx.mstrCurrDir = mstrCurrDir;
            clsPubFuncVar.objLog.LogDir = mstrCurrDir;
            clsPubFuncVar.objLog.LogFileName = "AgcDataSyn";
        }

        private void btnSynchFldTabWithoutTimer_Click(object sender, EventArgs e)
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
            catch(Exception objException)
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
                MessageBox.Show(sbErrMsg.ToString());
                return;
            }
            try
            {
                clsSysParaEN.strConnectStrName = "ConnectionString";
                //clsXsStuBLEx.SynchToWebByCondition(strCondition);
                //DataSyn();
                string strCondition = string.Format("{0}='1' Order by {1},{2}",
              conDataSynConfig.IsSynch,
              conDataSynConfig.SynchTime,
              conDataSynConfig.OrderNum);
                arrDataSynConfigObjLst = clsDataSynConfigBL.GetObjLst(strCondition);

                if (arrDataSynConfigObjLst == null)
                {

                    clsSysParaEN.strConnectStrName = "ConnectionString";
                    arrDataSynConfigObjLst = clsDataSynConfigBL.GetObjLst(strCondition);
                }

                clsDataSynConfigBLEx.DataSyn(arrDataSynConfigObjLst, clsPubFuncVar.objLog, "sys");
                
                //SetUpTimer();
            }
            catch (Exception objException)
            {
                arrDataSynConfigObjLst = null;

                MessageBox.Show(objException.Message);
            }
        }
    }
}
