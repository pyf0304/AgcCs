using System;
using System.Collections.Generic;
using System.Text;
using com.taishsoft.commdb;
using com.taishsoft.common;
using System.Data;
using System.IO;
using System.Collections;

namespace EcardDataClass
{
    public class clsEcardDataSyn
    {
        private static string mstrCurrDir;		//当前目录
        public string CurrDir
        {
            get
            {
                return mstrCurrDir;
            }
            set
            {
                mstrCurrDir = value;
            }
        }
        private string mstrConnectString_S = "";
        private string mstrConnectString_S2 = "";
        private string mstrConnectString_T = "";

        public string ConnectString_S
        {
            get { return mstrConnectString_S; }
            set { mstrConnectString_S = value; }
        }

        public string ConnectString_S2
        {
            get { return mstrConnectString_S2; }
            set { mstrConnectString_S2 = value; }
        }


        public string ConnectString_T
        {
            get { return mstrConnectString_T; }
            set { mstrConnectString_T = value; }
        }

        private string mstrConditionStr_S = "";
        private string mstrConditionStr_S2 = "";
        private string mstrConditionStr_T = "";
        public string ConditionStr_S
        {
            get
            {
                return mstrConditionStr_S;
            }
            set
            {
                mstrConditionStr_S = value;
            }
        }
        public string ConditionStr_T
        {
            get
            {
                return mstrConditionStr_T;
            }
            set
            {
                mstrConditionStr_T = value;
            }
        }


        public string ConditionStr_S2
        {
            get { return mstrConditionStr_S2; }
            set { mstrConditionStr_S2 = value; }
        }

        private string mstrKeyword_T = "";
        private int mintKeyFldLength_T;//目标表关键字的长度
        /// <summary>
        /// 目标表关键字的长度
        /// </summary>
        public int KeyFldLength_T
        {
            get { return mintKeyFldLength_T; }
            set { mintKeyFldLength_T = value; }
        }


        clsSpecSQLforSql objSQL_T = null;
        clsSpecSQLforSql objSQL_S = null;

        public clsEcardDataSyn()
        {
            com.taishsoft.commdb.clsSpecSQLforSql.strAppType = "WINAPP";
            com.taishsoft.commdbfororacle.clsSpecSQLforOra.strAppType = "WINAPP";
            clsSysPara.TempFileFolder = clsApplicatoin.AppPath() + "\\TempFiles\\";
            clsSysPara.strXMLFolder = clsApplicatoin.AppPath() + "\\XML\\";
            clsSysPara.strXmlDataSourceFileName = clsSysPara.strXMLFolder + "TzSysDataSet.xml";
        }
        public int DataSynFromEcard()
        {
            int intSynchRecNum = 0; //同步的记录数
            string strFieldName_Source;
            string strFiledValue_Source;
            string strFiledName_Target;
            string strFiledValue_Target;
            bool isAccoutExit = false;
            bool isSuccseFull = false;
            clsv_pfy_personEx objv_pyf_person = new clsv_pfy_personEx();
            StringBuilder objExcuString = new StringBuilder();
            DataTable objDT_Source = new DataTable();
            objSQL_S = new clsSpecSQLforSql(mstrConnectString_S);
            objSQL_T = new clsSpecSQLforSql(mstrConnectString_T);
            try
            {
                clsv_pfy_personEx.ConnectString = mstrConnectString_S;
                clsperson_qEx.ConnectString = mstrConnectString_T;
                objDT_Source = clsv_pfy_personEx.Getv_pyf_personDataTable(mstrConditionStr_S);
                intSynchRecNum = objDT_Source.Rows.Count;
            }
            catch (Exception objException)
            {
                StringBuilder sbMessage = new StringBuilder();

                sbMessage.AppendFormat("获取数据出错! 错误信息为:{0}\n\r", objException.Message);
                sbMessage.AppendFormat("连接串为：<{0}>.",
                         mstrConnectString_S);
                DateTime objNow = DateTime.Now;
                sbMessage.AppendFormat("时间：{0}", objNow.ToString());
                WriteLog(sbMessage.ToString());
            }
            //objDT_result=DataSynFromSourceDTtoTargetDT(objDT_Source, objDT_Target);
            if (objDT_Source.Rows.Count == 0)
            {
                return 0;
            }
            clsperson_qEx objperson_q = new clsperson_qEx();
            foreach (DataRow objDR in objDT_Source.Rows)
            {
                objv_pyf_person.Getobjv_pyf_person(objDR);
                objperson_q.Account = objv_pyf_person.ACCOUNT;
                objperson_q.ACADEMY_NO = objv_pyf_person.ACADEMY_NO;
                objperson_q.ADDRESS = objv_pyf_person.Address;
                objperson_q.BIRTH = objv_pyf_person.BIRTH;
                objperson_q.CARD_KIND = objv_pyf_person.CARD_KIND;
                objperson_q.CARD_NO = objv_pyf_person.CARD_NO;
                objperson_q.CARD_STATE = objv_pyf_person.CARD_STATE;
                objperson_q.CLASS_NO = objv_pyf_person.CLASS_NO;
                objperson_q.DEP_NO = objv_pyf_person.DEP_NO;
                objperson_q.DispErrMsg = objv_pyf_person.DispErrMsg;
                objperson_q.DUTY = objv_pyf_person.DUTY;
                objperson_q.ErrNo = objv_pyf_person.ErrNo;
                objperson_q.GRADE = objv_pyf_person.GRADE;
                objperson_q.IDEN_NO = objv_pyf_person.IDEN_NO;
                objperson_q.IN_TIME = objv_pyf_person.IN_TIME;
                objperson_q.MAIL = objv_pyf_person.MAIL;
                objperson_q.NAME = objv_pyf_person.Name;
                objperson_q.NATION_NO = objv_pyf_person.NATION_NO;
                objperson_q.PERSON_ID = objv_pyf_person.PERSON_ID;
                objperson_q.PHONE = objv_pyf_person.PHONE;
                objperson_q.POLITICS = objv_pyf_person.POLITICS;
                objperson_q.POST_ADDRESS = objv_pyf_person.POST_ADDRESS;
                objperson_q.POST_NO = objv_pyf_person.POST_NO;
                objperson_q.RECYCLE_LIMIT = objv_pyf_person.RECYCLE_LIMIT;
                objperson_q.SCH_ID = objv_pyf_person.SCH_ID;
                objperson_q.SEX = double.Parse(objv_pyf_person.Sex);
                objperson_q.STUDENT_ID = objv_pyf_person.STUDENT_ID;
                objperson_q.TEMP_CARD_NO = objv_pyf_person.TEMP_CARD_NO;
                objperson_q.USEFUL_LIMIT = objv_pyf_person.USEFUL_LIMIT;

                objperson_q.LAST_TIME = new DateTime(1900, 1, 1);
                objperson_q.OP_DATE = new DateTime(1900, 1, 1);
                objperson_q.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                clsperson_qEx.ConnectString = mstrConnectString_T;
                try
                {
                    isAccoutExit = clsperson_qEx.IsExist(objperson_q.Account);
                }
                catch (Exception objException)
                {
                    StringBuilder sbMessage = new StringBuilder();
                    sbMessage.AppendFormat("判断数据是否存在出错! 错误信息为:{0}\n\r", objException.Message);
                    sbMessage.AppendFormat("连接串为：<{0}>.",
                             mstrConnectString_T);
                    DateTime objNow = DateTime.Now;
                    sbMessage.AppendFormat("时间：{0}", objNow.ToString());
                    WriteLog(sbMessage.ToString());
                }
                if (isAccoutExit == false)
                {
                    try
                    {
                        objperson_q.CheckPropertyNew();
                        objperson_q.AddNewRecordBySQL2();
                        isSuccseFull = true;
                    }
                    catch (Exception objException)
                    {
                        StringBuilder sbMessage = new StringBuilder();
                        sbMessage.AppendFormat("添加新记录出错! 错误信息为:{0}\n\r", objException.Message);
                        sbMessage.AppendFormat("连接串为：<{0}>.",
                                 mstrConnectString_T);
                        DateTime objNow = DateTime.Now;
                        sbMessage.AppendFormat("时间：{0}", objNow.ToString());
                        WriteLog(sbMessage.ToString());
                    }
                }
                else
                {
                    try
                    {
                        objperson_q.UpdateBySql2();
                        isSuccseFull = true;
                    }
                    catch (Exception objException)
                    {
                        StringBuilder sbMessage = new StringBuilder();
                        sbMessage.AppendFormat("修改记录出错! 错误信息为:{0}\n\r", objException.Message);
                        sbMessage.AppendFormat("连接串为：<{0}>.",
                                 mstrConnectString_T);
                        DateTime objNow = DateTime.Now;
                        sbMessage.AppendFormat("时间：{0}", objNow.ToString());
                        WriteLog(sbMessage.ToString());
                    }
                }
            } //foreach (DataRow objDR in objDT_Source.Rows)
            return intSynchRecNum;
        }

        public int DataSynFromEcard4Lz()
        {
            int intSynchRecNum = 0; //同步的记录数
            string strFieldName_Source;
            string strFiledValue_Source;
            string strFiledName_Target;
            string strFiledValue_Target;
            bool isAccoutExit = false;
            bool isSuccseFull = false;
            clsPERSON_q_S objperson_q_S = new clsPERSON_q_S();
            StringBuilder objExcuString = new StringBuilder();
            DataTable objDT_Source = new DataTable();
            objSQL_S = new clsSpecSQLforSql(mstrConnectString_S);
            objSQL_T = new clsSpecSQLforSql(mstrConnectString_T);
            try
            {
                clsperson_q_SEx.ConnectString = mstrConnectString_S;
                clsperson_qEx.ConnectString = mstrConnectString_T;
                objDT_Source = clsperson_q_SEx.GetPerson_qDataTable(mstrConditionStr_S);
                intSynchRecNum = objDT_Source.Rows.Count;
            }
            catch (Exception objException)
            {
                StringBuilder sbMessage = new StringBuilder();

                sbMessage.AppendFormat("获取数据出错! 错误信息为:{0}\n\r", objException.Message);
                sbMessage.AppendFormat("连接串为：<{0}>.",
                         mstrConnectString_S);
                DateTime objNow = DateTime.Now;
                sbMessage.AppendFormat("时间：{0}", objNow.ToString());
                WriteLog(sbMessage.ToString());
            }
            //objDT_result=DataSynFromSourceDTtoTargetDT(objDT_Source, objDT_Target);
            if (objDT_Source.Rows.Count == 0)
            {
                return 0;
            }
            intSynchRecNum = 0;
            clsperson_qEx objperson_q = new clsperson_qEx();
            foreach (DataRow objDR in objDT_Source.Rows)
            {
                objperson_q = new clsperson_qEx();
                objperson_q_S = objperson_q_S.GetPERSON_qObjByDataRow(objDR);
                objperson_q.Account = objperson_q_S.Account;
                objperson_q.ACADEMY_NO = objperson_q_S.ACADEMY_NO;
                objperson_q.ADDRESS = objperson_q_S.ADDRESS;
                //objperson_q.BIRTH = objperson_q_S.BIRTH;
                objperson_q.CARD_KIND = objperson_q_S.CARD_KIND;
                objperson_q.CARD_NO = objperson_q_S.CARD_NO;
                objperson_q.CARD_STATE = objperson_q_S.CARD_STATE;
                objperson_q.CLASS_NO = objperson_q_S.CLASS_NO;
                objperson_q.DEP_NO = objperson_q_S.DEP_NO;
                objperson_q.DispErrMsg = objperson_q_S.DispErrMsg;
                objperson_q.DUTY = objperson_q_S.DUTY;
                objperson_q.ErrNo = objperson_q_S.ErrNo;
                objperson_q.GRADE = objperson_q_S.GRADE;
                objperson_q.IDEN_NO = objperson_q_S.IDEN_NO;
                //objperson_q.IN_TIME = objperson_q_S.IN_TIME;
                objperson_q.MAIL = objperson_q_S.MAIL;
                objperson_q.NAME = objperson_q_S.NAME;
                objperson_q.NATION_NO = objperson_q_S.NATION_NO;
                objperson_q.PERSON_ID = objperson_q_S.PERSON_ID;
                objperson_q.PHONE = objperson_q_S.PHONE;
                objperson_q.POLITICS = objperson_q_S.POLITICS;
                objperson_q.POST_ADDRESS = objperson_q_S.POST_ADDRESS;
                objperson_q.POST_NO = objperson_q_S.POST_NO;
                //objperson_q.RECYCLE_LIMIT = objperson_q_S.RECYCLE_LIMIT;
                objperson_q.SCH_ID = objperson_q_S.SCH_ID;
                objperson_q.SEX = objperson_q_S.SEX;
                objperson_q.STUDENT_ID = objperson_q_S.STUDENT_ID;
                objperson_q.TEMP_CARD_NO = objperson_q_S.TEMP_CARD_NO;
                //objperson_q.USEFUL_LIMIT = objperson_q_S.USEFUL_LIMIT;

                //objperson_q.LAST_TIME = new DateTime(1900, 1, 1);
                objperson_q.OP_DATE = new DateTime(1900, 1, 1);
                objperson_q.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                clsperson_qEx.ConnectString = mstrConnectString_T;
                try
                {
                    isAccoutExit = clsperson_qEx.IsExist(objperson_q.Account);
                }
                catch (Exception objException)
                {
                    StringBuilder sbMessage = new StringBuilder();
                    sbMessage.AppendFormat("判断数据是否存在出错! 错误信息为:{0}\n\r", objException.Message);
                    sbMessage.AppendFormat("连接串为：<{0}>.",
                             mstrConnectString_T);
                    DateTime objNow = DateTime.Now;
                    sbMessage.AppendFormat("时间：{0}", objNow.ToString());
                    WriteLog(sbMessage.ToString());
                }
                if (isAccoutExit == false)
                {
                    try
                    {
                        objperson_q.CheckPropertyNew();
                        objperson_q.AddNewRecordBySQL2();
                        isSuccseFull = true;
                        intSynchRecNum++;
                    }
                    catch (Exception objException)
                    {
                        StringBuilder sbMessage = new StringBuilder();
                        sbMessage.AppendFormat("添加新记录出错! 错误信息为:{0}\n\r", objException.Message);
                        sbMessage.AppendFormat("连接串为：<{0}>.",
                                 mstrConnectString_T);
                        DateTime objNow = DateTime.Now;
                        sbMessage.AppendFormat("时间：{0}", objNow.ToString());
                        WriteLog(sbMessage.ToString());
                    }
                }
                else
                {
                    try
                    {
                        objperson_q.UpdateBySql2();
                        isSuccseFull = true;
                        intSynchRecNum++;
                    }
                    catch (Exception objException)
                    {
                        StringBuilder sbMessage = new StringBuilder();
                        sbMessage.AppendFormat("修改记录出错! 错误信息为:{0}\n\r", objException.Message);
                        sbMessage.AppendFormat("连接串为：<{0}>.",
                                 mstrConnectString_T);
                        DateTime objNow = DateTime.Now;
                        sbMessage.AppendFormat("时间：{0}", objNow.ToString());
                        WriteLog(sbMessage.ToString());
                    }
                }
            } //foreach (DataRow objDR in objDT_Source.Rows)
            return intSynchRecNum;
        }


        private DataTable DataSynFromSourceDTtoTargetDT(DataTable objDT_Source, DataTable objDT_Target)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        private static void WriteLog(string strLogContent)
        {
            string mstrFullLogFileName;	//日志文件名
            //mstrCurrDir = @"D:\TaishSoft";
            if (Directory.Exists(mstrCurrDir) == false)
            {
                Directory.CreateDirectory(mstrCurrDir);
            }
            mstrFullLogFileName = mstrCurrDir + @"\EventLog4DataSynch_WebDevice.txt";

            FileStream fs = new FileStream(mstrFullLogFileName, FileMode.OpenOrCreate,
                FileAccess.Write);
            StreamWriter m_streamWriter = new StreamWriter(fs);
            m_streamWriter.BaseStream.Seek(0, SeekOrigin.End);
            m_streamWriter.WriteLine( "Data Synch: " + strLogContent + "\r\n");
            m_streamWriter.Flush();
            m_streamWriter.Close();
            fs.Close();
        }
        public bool spManualSure_P2()
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(mstrConnectString_T);

            //System.Data.DataTable objDT = null;
            //clsSpecSQLforSql objSQL = null;
            //获取连接对象
            //objSQL = clsAssociateInformation.GetSpecSQLObj();
            ArrayList values = new ArrayList();
            bool bolResult = objSQL.ExecSP2("spManualSure_P2", values);
            return bolResult;
        }
        public bool DealCardNoLenIs9ForCardNoRela()
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(mstrConnectString_T);

            //System.Data.DataTable objDT = null;
            //clsSpecSQLforSql objSQL = null;
            //获取连接对象
            //objSQL = clsAssociateInformation.GetSpecSQLObj();
            ArrayList values = new ArrayList();
            bool bolResult = objSQL.ExecSP2("DealCardNoLenIs9ForCardNoRela", values);
            return bolResult;
        }
        public bool DealCardNoLenIs9()
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(mstrConnectString_T);
            //System.Data.DataTable objDT = null;
            //clsSpecSQLforSql objSQL = null;
            //获取连接对象
            //objSQL = clsAssociateInformation.GetSpecSQLObj();
            ArrayList values = new ArrayList();
            bool bolResult = objSQL.ExecSP2("DealCardNoLenIs9", values);
            return bolResult;
        }
        public bool DelAllPerson_q()
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(mstrConnectString_T);
            //System.Data.DataTable objDT = null;
            //clsSpecSQLforSql objSQL = null;
            //获取连接对象
            //objSQL = clsAssociateInformation.GetSpecSQLObj();
            string strSQL = "Delete from person_q";
            bool bolResult = objSQL.ExecSql(strSQL);
            return bolResult;
        }
        public bool createCardNoRela()
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(mstrConnectString_T);
            //System.Data.DataTable objDT = null;
            //clsSpecSQLforSql objSQL = null;
            //获取连接对象
            //objSQL = clsAssociateInformation.GetSpecSQLObj();
            ArrayList values = new ArrayList();
            bool bolResult ;
            bolResult = objSQL.ExecSP2("createCardNoRela", values);
            return bolResult;
        }

        public bool CreateUsersFromPerson()
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(mstrConnectString_T);
            ArrayList values = new ArrayList();
            bool bolResult;
            bolResult = objSQL.ExecSP2("CreateUsersFromPerson", values);
            return bolResult;
        }
    }
}
