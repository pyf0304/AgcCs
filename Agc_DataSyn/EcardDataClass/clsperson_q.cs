///----------------------
///生成代码版本：09.10.08.1
///生成日期：2009/10/16
///生成者：潘以锋
///注意：1、需要数据底层（PubDataBase.dll）的版本：09.10.08.2
///       2、需要公共函数层（TzPubFunction.dll）的版本：09.10.08.1
///========================
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Collections;
using com.taishsoft.common;
using com.taishsoft.commexception;
using com.taishsoft.commdb;

namespace EcardDataClass
{
    /// <summary>
    /// PERSON_q(PERSON_q)
    /// </summary>
    [Serializable]
    public class clsPERSON_q : clsGeneralTab2
    {
        /// <summary>
        /// 当前表名，与该类相关的表名
        /// </summary>
        public const string CurrTabName_S = "PERSON_q";
        /// <summary>
        /// 当前表中的关键字名称，与该类相关的表中关键字名
        /// </summary>
        public const string CurrTabKeyFldName_S = "Account";
        /// <summary>
        /// 当前类的属性个数
        /// </summary>
        protected const int mintAttributeCount = 40;
        /// <summary>
        /// 当前类的属性名数组
        /// </summary>
        public static string[] AttributeName = new string[] { "Account", "SCH_ID", "BANK_ACC", "CARD_NO", "TEMP_CARD_NO", "TEMP_USING", "TEMP_DEPOSIT", "PASSWORD", "MONEY", "CARD_KIND", "CARD_STATE", "LAST_TIME", "USEFUL_LIMIT", "RECYCLE_LIMIT", "NAME", "SEX", "IDEN_NO", "NATION_NO", "POLITICS", "DUTY", "BIRTH", "PERSON_ID", "STUDENT_ID", "SCHOOL_NO", "ACADEMY_NO", "DEP_NO", "CLASS_NO", "GRADE", "IN_TIME", "WALLANCE", "ADDRESS", "PHONE", "POST_NO", "POST_ADDRESS", "MAIL", "DESCR", "USER_ID", "OP_DATE", "ANNEX", "UpdDate" };
        //以下是属性变量

        /// <summary> 
        /// 卡号
        /// </summary>
        protected string mstrAccount;
        /// <summary> 
        /// SCH_ID
        /// </summary>
        protected string mstrSCH_ID;
        /// <summary> 
        /// 银行帐号
        /// </summary>
        protected string mstrBANK_ACC;
        /// <summary> 
        /// CARD_NO
        /// </summary>
        protected string mstrCARD_NO;
        /// <summary> 
        /// TEMP_CARD_NO
        /// </summary>
        protected string mstrTEMP_CARD_NO;
        /// <summary> 
        /// TEMP_USING
        /// </summary>
        protected double mdblTEMP_USING;
        /// <summary> 
        /// TEMP_DEPOSIT
        /// </summary>
        protected double mdblTEMP_DEPOSIT;
        /// <summary> 
        /// 密码
        /// </summary>
        protected string mstrPASSWORD;
        /// <summary> 
        /// MONEY
        /// </summary>
        protected double mdblMONEY;
        /// <summary> 
        /// CARD_KIND
        /// </summary>
        protected double mdblCARD_KIND;
        /// <summary> 
        /// CARD_STATE
        /// </summary>
        protected double mdblCARD_STATE;
        /// <summary> 
        /// LAST_TIME
        /// </summary>
        protected DateTime mdteLAST_TIME;
        /// <summary> 
        /// USEFUL_LIMIT
        /// </summary>
        protected DateTime mdteUSEFUL_LIMIT;
        /// <summary> 
        /// RECYCLE_LIMIT
        /// </summary>
        protected DateTime mdteRECYCLE_LIMIT;
        /// <summary> 
        /// 名称
        /// </summary>
        protected string mstrNAME;
        /// <summary> 
        /// 性别
        /// </summary>
        protected double mdblSEX;
        /// <summary> 
        /// IDEN_NO
        /// </summary>
        protected double mdblIDEN_NO;
        /// <summary> 
        /// 国籍编号
        /// </summary>
        protected double mdblNATION_NO;
        /// <summary> 
        /// 政治面貌
        /// </summary>
        protected string mstrPOLITICS;
        /// <summary> 
        /// DUTY
        /// </summary>
        protected string mstrDUTY;
        /// <summary> 
        /// 入学时间
        /// </summary>
        protected DateTime mdteBIRTH;
        /// <summary> 
        /// 身份证号码
        /// </summary>
        protected string mstrPERSON_ID;
        /// <summary> 
        /// 学号
        /// </summary>
        protected string mstrSTUDENT_ID;
        /// <summary> 
        /// SCHOOL_NO
        /// </summary>
        protected string mstrSCHOOL_NO;
        /// <summary> 
        /// 学院编号
        /// </summary>
        protected string mstrACADEMY_NO;
        /// <summary> 
        /// 专业编号
        /// </summary>
        protected string mstrDEP_NO;
        /// <summary> 
        /// 班级编号
        /// </summary>
        protected string mstrCLASS_NO;
        /// <summary> 
        /// 年级
        /// </summary>
        protected string mstrGRADE;
        /// <summary> 
        /// IN_TIME
        /// </summary>
        protected DateTime mdteIN_TIME;
        /// <summary> 
        /// WALLANCE
        /// </summary>
        protected double mdblWALLANCE;
        /// <summary> 
        /// 家庭住址
        /// </summary>
        protected string mstrADDRESS;
        /// <summary> 
        /// 电话
        /// </summary>
        protected string mstrPHONE;
        /// <summary> 
        /// 邮政编码
        /// </summary>
        protected string mstrPOST_NO;
        /// <summary> 
        /// 邮政地址
        /// </summary>
        protected string mstrPOST_ADDRESS;
        /// <summary> 
        /// 信箱
        /// </summary>
        protected string mstrMAIL;
        /// <summary> 
        /// DESCR
        /// </summary>
        protected string mstrDESCR;
        /// <summary> 
        /// 用户ID
        /// </summary>
        protected string mstrUSER_ID;
        /// <summary> 
        /// OP_DATE
        /// </summary>
        protected DateTime mdteOP_DATE;
        /// <summary> 
        /// ANNEX
        /// </summary>
        protected string mstrANNEX;
        /// <summary> 
        /// UpdDate
        /// </summary>
        protected string mstrUpdDate;

        //用户指定的连接串,如果用户不指定该连接串,就用PUBDATABASE中所指定的连接串
        private static string m_strConnectString;
        /// <summary>
        /// 当前类指定的连接串
        /// </summary>
        public static string ConnectString
        {
            get { return m_strConnectString; }
            set { m_strConnectString = value; }
        }
        private string m_strConnectString_Obj;
        /// <summary>
        /// 当前对象指定的连接串
        /// </summary>
        public string ConnectString_Obj
        {
            get { return m_strConnectString_Obj; }
            set { m_strConnectString_Obj = value; }
        }

        /// <summary>
        /// 当前类的构造函数
        /// </summary>
        public clsPERSON_q()
        {
            SetInit();
            CurrTabName = "PERSON_q";
            lstKeyFldNames.Add("Account");
        }

        /// <summary>
        /// 当前类的构造函数
        /// </summary>
        /// <param name="strAccount">卡号</param>
        public clsPERSON_q(string strAccount)
        {

            mstrAccount = strAccount;
            SetInit();
            CurrTabName = "PERSON_q";
            lstKeyFldNames.Add("Account");
        }

        /// <summary>
        /// 当前类的构造函数
        /// </summary>
        /// <param name="strAccount">卡号</param>
        /// <param name="bolIsGetPERSON_q">是否获取该关键字相关的记录属性</param>
        public clsPERSON_q(string strAccount, bool bolIsGetPERSON_q)
        {

            mstrAccount = strAccount;
            SetInit();
            if (bolIsGetPERSON_q == true)
            {
                GetPERSON_q();
            }
            CurrTabName = "PERSON_q";
            lstKeyFldNames.Add("Account");
        }


        /// <summary>
        /// 当前类的属性的个数
        /// </summary>
        public static int AttributeCount
        {
            get
            {
                return mintAttributeCount;
            }
        }
        /// <summary>
        /// 根据属性的名称(字符型名称)存取该属性的值
        /// </summary>
        /// <param name="strAttributeName">属性名称(字符型)</param>
        /// <returns>该属性的值</returns>
        public object this[string strAttributeName]
        {
            get
            {
                if (strAttributeName == "Account")
                {
                    return mstrAccount;
                }
                else if (strAttributeName == "SCH_ID")
                {
                    return mstrSCH_ID;
                }
                else if (strAttributeName == "BANK_ACC")
                {
                    return mstrBANK_ACC;
                }
                else if (strAttributeName == "CARD_NO")
                {
                    return mstrCARD_NO;
                }
                else if (strAttributeName == "TEMP_CARD_NO")
                {
                    return mstrTEMP_CARD_NO;
                }
                else if (strAttributeName == "TEMP_USING")
                {
                    return mdblTEMP_USING;
                }
                else if (strAttributeName == "TEMP_DEPOSIT")
                {
                    return mdblTEMP_DEPOSIT;
                }
                else if (strAttributeName == "PASSWORD")
                {
                    return mstrPASSWORD;
                }
                else if (strAttributeName == "MONEY")
                {
                    return mdblMONEY;
                }
                else if (strAttributeName == "CARD_KIND")
                {
                    return mdblCARD_KIND;
                }
                else if (strAttributeName == "CARD_STATE")
                {
                    return mdblCARD_STATE;
                }
                else if (strAttributeName == "LAST_TIME")
                {
                    return mdteLAST_TIME;
                }
                else if (strAttributeName == "USEFUL_LIMIT")
                {
                    return mdteUSEFUL_LIMIT;
                }
                else if (strAttributeName == "RECYCLE_LIMIT")
                {
                    return mdteRECYCLE_LIMIT;
                }
                else if (strAttributeName == "NAME")
                {
                    return mstrNAME;
                }
                else if (strAttributeName == "SEX")
                {
                    return mdblSEX;
                }
                else if (strAttributeName == "IDEN_NO")
                {
                    return mdblIDEN_NO;
                }
                else if (strAttributeName == "NATION_NO")
                {
                    return mdblNATION_NO;
                }
                else if (strAttributeName == "POLITICS")
                {
                    return mstrPOLITICS;
                }
                else if (strAttributeName == "DUTY")
                {
                    return mstrDUTY;
                }
                else if (strAttributeName == "BIRTH")
                {
                    return mdteBIRTH;
                }
                else if (strAttributeName == "PERSON_ID")
                {
                    return mstrPERSON_ID;
                }
                else if (strAttributeName == "STUDENT_ID")
                {
                    return mstrSTUDENT_ID;
                }
                else if (strAttributeName == "SCHOOL_NO")
                {
                    return mstrSCHOOL_NO;
                }
                else if (strAttributeName == "ACADEMY_NO")
                {
                    return mstrACADEMY_NO;
                }
                else if (strAttributeName == "DEP_NO")
                {
                    return mstrDEP_NO;
                }
                else if (strAttributeName == "CLASS_NO")
                {
                    return mstrCLASS_NO;
                }
                else if (strAttributeName == "GRADE")
                {
                    return mstrGRADE;
                }
                else if (strAttributeName == "IN_TIME")
                {
                    return mdteIN_TIME;
                }
                else if (strAttributeName == "WALLANCE")
                {
                    return mdblWALLANCE;
                }
                else if (strAttributeName == "ADDRESS")
                {
                    return mstrADDRESS;
                }
                else if (strAttributeName == "PHONE")
                {
                    return mstrPHONE;
                }
                else if (strAttributeName == "POST_NO")
                {
                    return mstrPOST_NO;
                }
                else if (strAttributeName == "POST_ADDRESS")
                {
                    return mstrPOST_ADDRESS;
                }
                else if (strAttributeName == "MAIL")
                {
                    return mstrMAIL;
                }
                else if (strAttributeName == "DESCR")
                {
                    return mstrDESCR;
                }
                else if (strAttributeName == "USER_ID")
                {
                    return mstrUSER_ID;
                }
                else if (strAttributeName == "OP_DATE")
                {
                    return mdteOP_DATE;
                }
                else if (strAttributeName == "ANNEX")
                {
                    return mstrANNEX;
                }
                else if (strAttributeName == "UpdDate")
                {
                    return mstrUpdDate;
                }
                return null;
            }
            set
            {
                if (strAttributeName == "Account")
                {
                    mstrAccount = value.ToString();
                }
                else if (strAttributeName == "SCH_ID")
                {
                    mstrSCH_ID = value.ToString();
                }
                else if (strAttributeName == "BANK_ACC")
                {
                    mstrBANK_ACC = value.ToString();
                }
                else if (strAttributeName == "CARD_NO")
                {
                    mstrCARD_NO = value.ToString();
                }
                else if (strAttributeName == "TEMP_CARD_NO")
                {
                    mstrTEMP_CARD_NO = value.ToString();
                }
                else if (strAttributeName == "TEMP_USING")
                {
                    mdblTEMP_USING = TransNullToDouble(value.ToString());
                }
                else if (strAttributeName == "TEMP_DEPOSIT")
                {
                    mdblTEMP_DEPOSIT = TransNullToDouble(value.ToString());
                }
                else if (strAttributeName == "PASSWORD")
                {
                    mstrPASSWORD = value.ToString();
                }
                else if (strAttributeName == "MONEY")
                {
                    mdblMONEY = TransNullToDouble(value.ToString());
                }
                else if (strAttributeName == "CARD_KIND")
                {
                    mdblCARD_KIND = TransNullToDouble(value.ToString());
                }
                else if (strAttributeName == "CARD_STATE")
                {
                    mdblCARD_STATE = TransNullToDouble(value.ToString());
                }
                else if (strAttributeName == "LAST_TIME")
                {
                    mdteLAST_TIME = TransNullToDate(value.ToString());
                }
                else if (strAttributeName == "USEFUL_LIMIT")
                {
                    mdteUSEFUL_LIMIT = TransNullToDate(value.ToString());
                }
                else if (strAttributeName == "RECYCLE_LIMIT")
                {
                    mdteRECYCLE_LIMIT = TransNullToDate(value.ToString());
                }
                else if (strAttributeName == "NAME")
                {
                    mstrNAME = value.ToString();
                }
                else if (strAttributeName == "SEX")
                {
                    mdblSEX = TransNullToDouble(value.ToString());
                }
                else if (strAttributeName == "IDEN_NO")
                {
                    mdblIDEN_NO = TransNullToDouble(value.ToString());
                }
                else if (strAttributeName == "NATION_NO")
                {
                    mdblNATION_NO = TransNullToDouble(value.ToString());
                }
                else if (strAttributeName == "POLITICS")
                {
                    mstrPOLITICS = value.ToString();
                }
                else if (strAttributeName == "DUTY")
                {
                    mstrDUTY = value.ToString();
                }
                else if (strAttributeName == "BIRTH")
                {
                    mdteBIRTH = TransNullToDate(value.ToString());
                }
                else if (strAttributeName == "PERSON_ID")
                {
                    mstrPERSON_ID = value.ToString();
                }
                else if (strAttributeName == "STUDENT_ID")
                {
                    mstrSTUDENT_ID = value.ToString();
                }
                else if (strAttributeName == "SCHOOL_NO")
                {
                    mstrSCHOOL_NO = value.ToString();
                }
                else if (strAttributeName == "ACADEMY_NO")
                {
                    mstrACADEMY_NO = value.ToString();
                }
                else if (strAttributeName == "DEP_NO")
                {
                    mstrDEP_NO = value.ToString();
                }
                else if (strAttributeName == "CLASS_NO")
                {
                    mstrCLASS_NO = value.ToString();
                }
                else if (strAttributeName == "GRADE")
                {
                    mstrGRADE = value.ToString();
                }
                else if (strAttributeName == "IN_TIME")
                {
                    mdteIN_TIME = TransNullToDate(value.ToString());
                }
                else if (strAttributeName == "WALLANCE")
                {
                    mdblWALLANCE = TransNullToDouble(value.ToString());
                }
                else if (strAttributeName == "ADDRESS")
                {
                    mstrADDRESS = value.ToString();
                }
                else if (strAttributeName == "PHONE")
                {
                    mstrPHONE = value.ToString();
                }
                else if (strAttributeName == "POST_NO")
                {
                    mstrPOST_NO = value.ToString();
                }
                else if (strAttributeName == "POST_ADDRESS")
                {
                    mstrPOST_ADDRESS = value.ToString();
                }
                else if (strAttributeName == "MAIL")
                {
                    mstrMAIL = value.ToString();
                }
                else if (strAttributeName == "DESCR")
                {
                    mstrDESCR = value.ToString();
                }
                else if (strAttributeName == "USER_ID")
                {
                    mstrUSER_ID = value.ToString();
                }
                else if (strAttributeName == "OP_DATE")
                {
                    mdteOP_DATE = TransNullToDate(value.ToString());
                }
                else if (strAttributeName == "ANNEX")
                {
                    mstrANNEX = value.ToString();
                }
                else if (strAttributeName == "UpdDate")
                {
                    mstrUpdDate = value.ToString();
                }
            }
        }
        /// <summary>
        /// 根据属性的序号(整型)存取该属性的值
        /// </summary>
        /// <param name="intIndex">属性序号(整型)</param>
        /// <returns>该属性的值</returns>
        public object this[int intIndex]
        {
            get
            {
                if ("Account" == AttributeName[intIndex])
                {
                    return mstrAccount;
                }
                else if ("SCH_ID" == AttributeName[intIndex])
                {
                    return mstrSCH_ID;
                }
                else if ("BANK_ACC" == AttributeName[intIndex])
                {
                    return mstrBANK_ACC;
                }
                else if ("CARD_NO" == AttributeName[intIndex])
                {
                    return mstrCARD_NO;
                }
                else if ("TEMP_CARD_NO" == AttributeName[intIndex])
                {
                    return mstrTEMP_CARD_NO;
                }
                else if ("TEMP_USING" == AttributeName[intIndex])
                {
                    return mdblTEMP_USING;
                }
                else if ("TEMP_DEPOSIT" == AttributeName[intIndex])
                {
                    return mdblTEMP_DEPOSIT;
                }
                else if ("PASSWORD" == AttributeName[intIndex])
                {
                    return mstrPASSWORD;
                }
                else if ("MONEY" == AttributeName[intIndex])
                {
                    return mdblMONEY;
                }
                else if ("CARD_KIND" == AttributeName[intIndex])
                {
                    return mdblCARD_KIND;
                }
                else if ("CARD_STATE" == AttributeName[intIndex])
                {
                    return mdblCARD_STATE;
                }
                else if ("LAST_TIME" == AttributeName[intIndex])
                {
                    return mdteLAST_TIME;
                }
                else if ("USEFUL_LIMIT" == AttributeName[intIndex])
                {
                    return mdteUSEFUL_LIMIT;
                }
                else if ("RECYCLE_LIMIT" == AttributeName[intIndex])
                {
                    return mdteRECYCLE_LIMIT;
                }
                else if ("NAME" == AttributeName[intIndex])
                {
                    return mstrNAME;
                }
                else if ("SEX" == AttributeName[intIndex])
                {
                    return mdblSEX;
                }
                else if ("IDEN_NO" == AttributeName[intIndex])
                {
                    return mdblIDEN_NO;
                }
                else if ("NATION_NO" == AttributeName[intIndex])
                {
                    return mdblNATION_NO;
                }
                else if ("POLITICS" == AttributeName[intIndex])
                {
                    return mstrPOLITICS;
                }
                else if ("DUTY" == AttributeName[intIndex])
                {
                    return mstrDUTY;
                }
                else if ("BIRTH" == AttributeName[intIndex])
                {
                    return mdteBIRTH;
                }
                else if ("PERSON_ID" == AttributeName[intIndex])
                {
                    return mstrPERSON_ID;
                }
                else if ("STUDENT_ID" == AttributeName[intIndex])
                {
                    return mstrSTUDENT_ID;
                }
                else if ("SCHOOL_NO" == AttributeName[intIndex])
                {
                    return mstrSCHOOL_NO;
                }
                else if ("ACADEMY_NO" == AttributeName[intIndex])
                {
                    return mstrACADEMY_NO;
                }
                else if ("DEP_NO" == AttributeName[intIndex])
                {
                    return mstrDEP_NO;
                }
                else if ("CLASS_NO" == AttributeName[intIndex])
                {
                    return mstrCLASS_NO;
                }
                else if ("GRADE" == AttributeName[intIndex])
                {
                    return mstrGRADE;
                }
                else if ("IN_TIME" == AttributeName[intIndex])
                {
                    return mdteIN_TIME;
                }
                else if ("WALLANCE" == AttributeName[intIndex])
                {
                    return mdblWALLANCE;
                }
                else if ("ADDRESS" == AttributeName[intIndex])
                {
                    return mstrADDRESS;
                }
                else if ("PHONE" == AttributeName[intIndex])
                {
                    return mstrPHONE;
                }
                else if ("POST_NO" == AttributeName[intIndex])
                {
                    return mstrPOST_NO;
                }
                else if ("POST_ADDRESS" == AttributeName[intIndex])
                {
                    return mstrPOST_ADDRESS;
                }
                else if ("MAIL" == AttributeName[intIndex])
                {
                    return mstrMAIL;
                }
                else if ("DESCR" == AttributeName[intIndex])
                {
                    return mstrDESCR;
                }
                else if ("USER_ID" == AttributeName[intIndex])
                {
                    return mstrUSER_ID;
                }
                else if ("OP_DATE" == AttributeName[intIndex])
                {
                    return mdteOP_DATE;
                }
                else if ("ANNEX" == AttributeName[intIndex])
                {
                    return mstrANNEX;
                }
                else if ("UpdDate" == AttributeName[intIndex])
                {
                    return mstrUpdDate;
                }
                return null;
            }
            set
            {
                if ("Account" == AttributeName[intIndex])
                {
                    mstrAccount = value.ToString();
                }
                else if ("SCH_ID" == AttributeName[intIndex])
                {
                    mstrSCH_ID = value.ToString();
                }
                else if ("BANK_ACC" == AttributeName[intIndex])
                {
                    mstrBANK_ACC = value.ToString();
                }
                else if ("CARD_NO" == AttributeName[intIndex])
                {
                    mstrCARD_NO = value.ToString();
                }
                else if ("TEMP_CARD_NO" == AttributeName[intIndex])
                {
                    mstrTEMP_CARD_NO = value.ToString();
                }
                else if ("TEMP_USING" == AttributeName[intIndex])
                {
                    mdblTEMP_USING = TransNullToDouble(value.ToString());
                }
                else if ("TEMP_DEPOSIT" == AttributeName[intIndex])
                {
                    mdblTEMP_DEPOSIT = TransNullToDouble(value.ToString());
                }
                else if ("PASSWORD" == AttributeName[intIndex])
                {
                    mstrPASSWORD = value.ToString();
                }
                else if ("MONEY" == AttributeName[intIndex])
                {
                    mdblMONEY = TransNullToDouble(value.ToString());
                }
                else if ("CARD_KIND" == AttributeName[intIndex])
                {
                    mdblCARD_KIND = TransNullToDouble(value.ToString());
                }
                else if ("CARD_STATE" == AttributeName[intIndex])
                {
                    mdblCARD_STATE = TransNullToDouble(value.ToString());
                }
                else if ("LAST_TIME" == AttributeName[intIndex])
                {
                    mdteLAST_TIME = TransNullToDate(value.ToString());
                }
                else if ("USEFUL_LIMIT" == AttributeName[intIndex])
                {
                    mdteUSEFUL_LIMIT = TransNullToDate(value.ToString());
                }
                else if ("RECYCLE_LIMIT" == AttributeName[intIndex])
                {
                    mdteRECYCLE_LIMIT = TransNullToDate(value.ToString());
                }
                else if ("NAME" == AttributeName[intIndex])
                {
                    mstrNAME = value.ToString();
                }
                else if ("SEX" == AttributeName[intIndex])
                {
                    mdblSEX = TransNullToDouble(value.ToString());
                }
                else if ("IDEN_NO" == AttributeName[intIndex])
                {
                    mdblIDEN_NO = TransNullToDouble(value.ToString());
                }
                else if ("NATION_NO" == AttributeName[intIndex])
                {
                    mdblNATION_NO = TransNullToDouble(value.ToString());
                }
                else if ("POLITICS" == AttributeName[intIndex])
                {
                    mstrPOLITICS = value.ToString();
                }
                else if ("DUTY" == AttributeName[intIndex])
                {
                    mstrDUTY = value.ToString();
                }
                else if ("BIRTH" == AttributeName[intIndex])
                {
                    mdteBIRTH = TransNullToDate(value.ToString());
                }
                else if ("PERSON_ID" == AttributeName[intIndex])
                {
                    mstrPERSON_ID = value.ToString();
                }
                else if ("STUDENT_ID" == AttributeName[intIndex])
                {
                    mstrSTUDENT_ID = value.ToString();
                }
                else if ("SCHOOL_NO" == AttributeName[intIndex])
                {
                    mstrSCHOOL_NO = value.ToString();
                }
                else if ("ACADEMY_NO" == AttributeName[intIndex])
                {
                    mstrACADEMY_NO = value.ToString();
                }
                else if ("DEP_NO" == AttributeName[intIndex])
                {
                    mstrDEP_NO = value.ToString();
                }
                else if ("CLASS_NO" == AttributeName[intIndex])
                {
                    mstrCLASS_NO = value.ToString();
                }
                else if ("GRADE" == AttributeName[intIndex])
                {
                    mstrGRADE = value.ToString();
                }
                else if ("IN_TIME" == AttributeName[intIndex])
                {
                    mdteIN_TIME = TransNullToDate(value.ToString());
                }
                else if ("WALLANCE" == AttributeName[intIndex])
                {
                    mdblWALLANCE = TransNullToDouble(value.ToString());
                }
                else if ("ADDRESS" == AttributeName[intIndex])
                {
                    mstrADDRESS = value.ToString();
                }
                else if ("PHONE" == AttributeName[intIndex])
                {
                    mstrPHONE = value.ToString();
                }
                else if ("POST_NO" == AttributeName[intIndex])
                {
                    mstrPOST_NO = value.ToString();
                }
                else if ("POST_ADDRESS" == AttributeName[intIndex])
                {
                    mstrPOST_ADDRESS = value.ToString();
                }
                else if ("MAIL" == AttributeName[intIndex])
                {
                    mstrMAIL = value.ToString();
                }
                else if ("DESCR" == AttributeName[intIndex])
                {
                    mstrDESCR = value.ToString();
                }
                else if ("USER_ID" == AttributeName[intIndex])
                {
                    mstrUSER_ID = value.ToString();
                }
                else if ("OP_DATE" == AttributeName[intIndex])
                {
                    mdteOP_DATE = TransNullToDate(value.ToString());
                }
                else if ("ANNEX" == AttributeName[intIndex])
                {
                    mstrANNEX = value.ToString();
                }
                else if ("UpdDate" == AttributeName[intIndex])
                {
                    mstrUpdDate = value.ToString();
                }
            }
        }

        /// <summary>
        /// 卡号
        /// </summary>
        public string Account
        {
            get
            {
                return mstrAccount;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrAccount = value;
                }
                else
                {
                    mstrAccount = value;
                }
                //记录修改过的字段
                AddUpdatedFld("Account");
            }
        }
        /// <summary>
        /// SCH_ID
        /// </summary>
        public string SCH_ID
        {
            get
            {
                return mstrSCH_ID;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrSCH_ID = value;
                }
                else
                {
                    mstrSCH_ID = value;
                }
                //记录修改过的字段
                AddUpdatedFld("SCH_ID");
            }
        }
        /// <summary>
        /// 银行帐号
        /// </summary>
        public string BANK_ACC
        {
            get
            {
                return mstrBANK_ACC;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrBANK_ACC = value;
                }
                else
                {
                    mstrBANK_ACC = value;
                }
                //记录修改过的字段
                AddUpdatedFld("BANK_ACC");
            }
        }
        /// <summary>
        /// CARD_NO
        /// </summary>
        public string CARD_NO
        {
            get
            {
                return mstrCARD_NO;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrCARD_NO = value;
                }
                else
                {
                    mstrCARD_NO = value;
                }
                //记录修改过的字段
                AddUpdatedFld("CARD_NO");
            }
        }
        /// <summary>
        /// TEMP_CARD_NO
        /// </summary>
        public string TEMP_CARD_NO
        {
            get
            {
                return mstrTEMP_CARD_NO;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrTEMP_CARD_NO = value;
                }
                else
                {
                    mstrTEMP_CARD_NO = value;
                }
                //记录修改过的字段
                AddUpdatedFld("TEMP_CARD_NO");
            }
        }
        /// <summary>
        /// TEMP_USING
        /// </summary>
        public double TEMP_USING
        {
            get
            {
                return mdblTEMP_USING;
            }
            set
            {
                mdblTEMP_USING = value;
                //记录修改过的字段
                AddUpdatedFld("TEMP_USING");
            }
        }
        /// <summary>
        /// TEMP_DEPOSIT
        /// </summary>
        public double TEMP_DEPOSIT
        {
            get
            {
                return mdblTEMP_DEPOSIT;
            }
            set
            {
                mdblTEMP_DEPOSIT = value;
                //记录修改过的字段
                AddUpdatedFld("TEMP_DEPOSIT");
            }
        }
        /// <summary>
        /// 密码
        /// </summary>
        public string PASSWORD
        {
            get
            {
                return mstrPASSWORD;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrPASSWORD = value;
                }
                else
                {
                    mstrPASSWORD = value;
                }
                //记录修改过的字段
                AddUpdatedFld("PASSWORD");
            }
        }
        /// <summary>
        /// MONEY
        /// </summary>
        public double MONEY
        {
            get
            {
                return mdblMONEY;
            }
            set
            {
                mdblMONEY = value;
                //记录修改过的字段
                AddUpdatedFld("MONEY");
            }
        }
        /// <summary>
        /// CARD_KIND
        /// </summary>
        public double CARD_KIND
        {
            get
            {
                return mdblCARD_KIND;
            }
            set
            {
                mdblCARD_KIND = value;
                //记录修改过的字段
                AddUpdatedFld("CARD_KIND");
            }
        }
        /// <summary>
        /// CARD_STATE
        /// </summary>
        public double CARD_STATE
        {
            get
            {
                return mdblCARD_STATE;
            }
            set
            {
                mdblCARD_STATE = value;
                //记录修改过的字段
                AddUpdatedFld("CARD_STATE");
            }
        }
        /// <summary>
        /// LAST_TIME
        /// </summary>
        public DateTime LAST_TIME
        {
            get
            {
                return mdteLAST_TIME;
            }
            set
            {
                mdteLAST_TIME = value;
                //记录修改过的字段
                AddUpdatedFld("LAST_TIME");
            }
        }
        /// <summary>
        /// USEFUL_LIMIT
        /// </summary>
        public DateTime USEFUL_LIMIT
        {
            get
            {
                return mdteUSEFUL_LIMIT;
            }
            set
            {
                mdteUSEFUL_LIMIT = value;
                //记录修改过的字段
                AddUpdatedFld("USEFUL_LIMIT");
            }
        }
        /// <summary>
        /// RECYCLE_LIMIT
        /// </summary>
        public DateTime RECYCLE_LIMIT
        {
            get
            {
                return mdteRECYCLE_LIMIT;
            }
            set
            {
                mdteRECYCLE_LIMIT = value;
                //记录修改过的字段
                AddUpdatedFld("RECYCLE_LIMIT");
            }
        }
        /// <summary>
        /// 名称
        /// </summary>
        public string NAME
        {
            get
            {
                return mstrNAME;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrNAME = value;
                }
                else
                {
                    mstrNAME = value;
                }
                //记录修改过的字段
                AddUpdatedFld("NAME");
            }
        }
        /// <summary>
        /// 性别
        /// </summary>
        public double SEX
        {
            get
            {
                return mdblSEX;
            }
            set
            {
                mdblSEX = value;
                //记录修改过的字段
                AddUpdatedFld("SEX");
            }
        }
        /// <summary>
        /// IDEN_NO
        /// </summary>
        public double IDEN_NO
        {
            get
            {
                return mdblIDEN_NO;
            }
            set
            {
                mdblIDEN_NO = value;
                //记录修改过的字段
                AddUpdatedFld("IDEN_NO");
            }
        }
        /// <summary>
        /// 国籍编号
        /// </summary>
        public double NATION_NO
        {
            get
            {
                return mdblNATION_NO;
            }
            set
            {
                mdblNATION_NO = value;
                //记录修改过的字段
                AddUpdatedFld("NATION_NO");
            }
        }
        /// <summary>
        /// 政治面貌
        /// </summary>
        public string POLITICS
        {
            get
            {
                return mstrPOLITICS;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrPOLITICS = value;
                }
                else
                {
                    mstrPOLITICS = value;
                }
                //记录修改过的字段
                AddUpdatedFld("POLITICS");
            }
        }
        /// <summary>
        /// DUTY
        /// </summary>
        public string DUTY
        {
            get
            {
                return mstrDUTY;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrDUTY = value;
                }
                else
                {
                    mstrDUTY = value;
                }
                //记录修改过的字段
                AddUpdatedFld("DUTY");
            }
        }
        /// <summary>
        /// 入学时间
        /// </summary>
        public DateTime BIRTH
        {
            get
            {
                return mdteBIRTH;
            }
            set
            {
                mdteBIRTH = value;
                //记录修改过的字段
                AddUpdatedFld("BIRTH");
            }
        }
        /// <summary>
        /// 身份证号码
        /// </summary>
        public string PERSON_ID
        {
            get
            {
                return mstrPERSON_ID;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrPERSON_ID = value;
                }
                else
                {
                    mstrPERSON_ID = value;
                }
                //记录修改过的字段
                AddUpdatedFld("PERSON_ID");
            }
        }
        /// <summary>
        /// 学号
        /// </summary>
        public string STUDENT_ID
        {
            get
            {
                return mstrSTUDENT_ID;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrSTUDENT_ID = value;
                }
                else
                {
                    mstrSTUDENT_ID = value;
                }
                //记录修改过的字段
                AddUpdatedFld("STUDENT_ID");
            }
        }
        /// <summary>
        /// SCHOOL_NO
        /// </summary>
        public string SCHOOL_NO
        {
            get
            {
                return mstrSCHOOL_NO;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrSCHOOL_NO = value;
                }
                else
                {
                    mstrSCHOOL_NO = value;
                }
                //记录修改过的字段
                AddUpdatedFld("SCHOOL_NO");
            }
        }
        /// <summary>
        /// 学院编号
        /// </summary>
        public string ACADEMY_NO
        {
            get
            {
                return mstrACADEMY_NO;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrACADEMY_NO = value;
                }
                else
                {
                    mstrACADEMY_NO = value;
                }
                //记录修改过的字段
                AddUpdatedFld("ACADEMY_NO");
            }
        }
        /// <summary>
        /// 专业编号
        /// </summary>
        public string DEP_NO
        {
            get
            {
                return mstrDEP_NO;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrDEP_NO = value;
                }
                else
                {
                    mstrDEP_NO = value;
                }
                //记录修改过的字段
                AddUpdatedFld("DEP_NO");
            }
        }
        /// <summary>
        /// 班级编号
        /// </summary>
        public string CLASS_NO
        {
            get
            {
                return mstrCLASS_NO;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrCLASS_NO = value;
                }
                else
                {
                    mstrCLASS_NO = value;
                }
                //记录修改过的字段
                AddUpdatedFld("CLASS_NO");
            }
        }
        /// <summary>
        /// 年级
        /// </summary>
        public string GRADE
        {
            get
            {
                return mstrGRADE;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrGRADE = value;
                }
                else
                {
                    mstrGRADE = value;
                }
                //记录修改过的字段
                AddUpdatedFld("GRADE");
            }
        }
        /// <summary>
        /// IN_TIME
        /// </summary>
        public DateTime IN_TIME
        {
            get
            {
                return mdteIN_TIME;
            }
            set
            {
                mdteIN_TIME = value;
                //记录修改过的字段
                AddUpdatedFld("IN_TIME");
            }
        }
        /// <summary>
        /// WALLANCE
        /// </summary>
        public double WALLANCE
        {
            get
            {
                return mdblWALLANCE;
            }
            set
            {
                mdblWALLANCE = value;
                //记录修改过的字段
                AddUpdatedFld("WALLANCE");
            }
        }
        /// <summary>
        /// 家庭住址
        /// </summary>
        public string ADDRESS
        {
            get
            {
                return mstrADDRESS;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrADDRESS = value;
                }
                else
                {
                    mstrADDRESS = value;
                }
                //记录修改过的字段
                AddUpdatedFld("ADDRESS");
            }
        }
        /// <summary>
        /// 电话
        /// </summary>
        public string PHONE
        {
            get
            {
                return mstrPHONE;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrPHONE = value;
                }
                else
                {
                    mstrPHONE = value;
                }
                //记录修改过的字段
                AddUpdatedFld("PHONE");
            }
        }
        /// <summary>
        /// 邮政编码
        /// </summary>
        public string POST_NO
        {
            get
            {
                return mstrPOST_NO;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrPOST_NO = value;
                }
                else
                {
                    mstrPOST_NO = value;
                }
                //记录修改过的字段
                AddUpdatedFld("POST_NO");
            }
        }
        /// <summary>
        /// 邮政地址
        /// </summary>
        public string POST_ADDRESS
        {
            get
            {
                return mstrPOST_ADDRESS;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrPOST_ADDRESS = value;
                }
                else
                {
                    mstrPOST_ADDRESS = value;
                }
                //记录修改过的字段
                AddUpdatedFld("POST_ADDRESS");
            }
        }
        /// <summary>
        /// 信箱
        /// </summary>
        public string MAIL
        {
            get
            {
                return mstrMAIL;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrMAIL = value;
                }
                else
                {
                    mstrMAIL = value;
                }
                //记录修改过的字段
                AddUpdatedFld("MAIL");
            }
        }
        /// <summary>
        /// DESCR
        /// </summary>
        public string DESCR
        {
            get
            {
                return mstrDESCR;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrDESCR = value;
                }
                else
                {
                    mstrDESCR = value;
                }
                //记录修改过的字段
                AddUpdatedFld("DESCR");
            }
        }
        /// <summary>
        /// 用户ID
        /// </summary>
        public string USER_ID
        {
            get
            {
                return mstrUSER_ID;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrUSER_ID = value;
                }
                else
                {
                    mstrUSER_ID = value;
                }
                //记录修改过的字段
                AddUpdatedFld("USER_ID");
            }
        }
        /// <summary>
        /// OP_DATE
        /// </summary>
        public DateTime OP_DATE
        {
            get
            {
                return mdteOP_DATE;
            }
            set
            {
                mdteOP_DATE = value;
                //记录修改过的字段
                AddUpdatedFld("OP_DATE");
            }
        }
        /// <summary>
        /// ANNEX
        /// </summary>
        public string ANNEX
        {
            get
            {
                return mstrANNEX;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrANNEX = value;
                }
                else
                {
                    mstrANNEX = value;
                }
                //记录修改过的字段
                AddUpdatedFld("ANNEX");
            }
        }
        /// <summary>
        /// UpdDate
        /// </summary>
        public string UpdDate
        {
            get
            {
                return mstrUpdDate;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrUpdDate = value;
                }
                else
                {
                    mstrUpdDate = value;
                }
                //记录修改过的字段
                AddUpdatedFld("UpdDate");
            }
        }

        /// <summary>
        /// 获取SQL服务器连接对象
        /// </summary>
        /// <returns>SQL服务器连接对象</returns>
        public static clsSpecSQLforSql GetSpecSQLObj()
        {
            clsSpecSQLforSql objSQL = null;
            //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串
            if (clsSysPara.bolIsUseConnectStrName == true)
            {
                objSQL = new clsSpecSQLforSql(clsSysPara.strConnectStrName, true);
                return objSQL;
            }
            //2. 如果类所指定的连接串非空,就用该类所指定的连接串
            //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
            if (string.IsNullOrEmpty(clsPERSON_q.ConnectString) == true)
            {
                objSQL = new clsSpecSQLforSql();
            }
            else
            {
                objSQL = new clsSpecSQLforSql(clsPERSON_q.ConnectString);
            }
            return objSQL;
        }

        /// <summary>
        /// 获取SQL服务器连接对象
        /// </summary>
        /// <returns>SQL服务器连接对象</returns>
        public clsSpecSQLforSql GetSpecSQLObj_Obj()
        {
            clsSpecSQLforSql objSQL = null;
            //1. 如果当前对象有指定的连接串,就用对象连接串
            if (string.IsNullOrEmpty(this.ConnectString_Obj) == false)
            {
                objSQL = new clsSpecSQLforSql(this.ConnectString_Obj);
                return objSQL;
            }
            //2. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串
            if (clsSysPara.bolIsUseConnectStrName == true)
            {
                objSQL = new clsSpecSQLforSql(clsSysPara.strConnectStrName, true);
                return objSQL;
            }
            //3. 如果类所指定的连接串非空,就用该类所指定的连接串
            //4. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
            if (string.IsNullOrEmpty(clsPERSON_q.ConnectString) == true)
            {
                objSQL = new clsSpecSQLforSql();
            }
            else
            {
                objSQL = new clsSpecSQLforSql(clsPERSON_q.ConnectString);
            }
            return objSQL;
        }


        /// <summary>
        /// 添加新记录
        /// </summary>
        /// <returns>添加是否成功?</returns>
        public bool AddNewRecord()
        {
            string strSQL;
            System.Data.SqlClient.SqlDataAdapter objDA;
            System.Data.DataSet objDS = new System.Data.DataSet();
            System.Data.SqlClient.SqlCommandBuilder objCB;
            System.Data.DataRow objRow;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = this.GetSpecSQLObj_Obj();
            strSQL = "Select * from PERSON_q where 1=2";
            objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
            objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
            objDA.Fill(objDS, "PERSON_q");
            objRow = objDS.Tables["PERSON_q"].NewRow();
            objRow["Account"] = mstrAccount; //卡号
            if (mstrSCH_ID != "")
            {
                objRow["SCH_ID"] = mstrSCH_ID; //SCH_ID
            }
            if (mstrBANK_ACC != "")
            {
                objRow["BANK_ACC"] = mstrBANK_ACC; //银行帐号
            }
            if (mstrCARD_NO != "")
            {
                objRow["CARD_NO"] = mstrCARD_NO; //CARD_NO
            }
            if (mstrTEMP_CARD_NO != "")
            {
                objRow["TEMP_CARD_NO"] = mstrTEMP_CARD_NO; //TEMP_CARD_NO
            }
            objRow["TEMP_USING"] = mdblTEMP_USING; //TEMP_USING
            objRow["TEMP_DEPOSIT"] = mdblTEMP_DEPOSIT; //TEMP_DEPOSIT
            if (mstrPASSWORD != "")
            {
                objRow["PASSWORD"] = mstrPASSWORD; //密码
            }
            objRow["MONEY"] = mdblMONEY; //MONEY
            objRow["CARD_KIND"] = mdblCARD_KIND; //CARD_KIND
            objRow["CARD_STATE"] = mdblCARD_STATE; //CARD_STATE
            objRow["LAST_TIME"] = mdteLAST_TIME; //LAST_TIME
            objRow["USEFUL_LIMIT"] = mdteUSEFUL_LIMIT; //USEFUL_LIMIT
            objRow["RECYCLE_LIMIT"] = mdteRECYCLE_LIMIT; //RECYCLE_LIMIT
            if (mstrNAME != "")
            {
                objRow["NAME"] = mstrNAME; //名称
            }
            objRow["SEX"] = mdblSEX; //性别
            objRow["IDEN_NO"] = mdblIDEN_NO; //IDEN_NO
            objRow["NATION_NO"] = mdblNATION_NO; //国籍编号
            if (mstrPOLITICS != "")
            {
                objRow["POLITICS"] = mstrPOLITICS; //政治面貌
            }
            if (mstrDUTY != "")
            {
                objRow["DUTY"] = mstrDUTY; //DUTY
            }
            objRow["BIRTH"] = mdteBIRTH; //入学时间
            if (mstrPERSON_ID != "")
            {
                objRow["PERSON_ID"] = mstrPERSON_ID; //身份证号码
            }
            if (mstrSTUDENT_ID != "")
            {
                objRow["STUDENT_ID"] = mstrSTUDENT_ID; //学号
            }
            if (mstrSCHOOL_NO != "")
            {
                objRow["SCHOOL_NO"] = mstrSCHOOL_NO; //SCHOOL_NO
            }
            if (mstrACADEMY_NO != "")
            {
                objRow["ACADEMY_NO"] = mstrACADEMY_NO; //学院编号
            }
            if (mstrDEP_NO != "")
            {
                objRow["DEP_NO"] = mstrDEP_NO; //专业编号
            }
            if (mstrCLASS_NO != "")
            {
                objRow["CLASS_NO"] = mstrCLASS_NO; //班级编号
            }
            if (mstrGRADE != "")
            {
                objRow["GRADE"] = mstrGRADE; //年级
            }
            objRow["IN_TIME"] = mdteIN_TIME; //IN_TIME
            objRow["WALLANCE"] = mdblWALLANCE; //WALLANCE
            if (mstrADDRESS != "")
            {
                objRow["ADDRESS"] = mstrADDRESS; //家庭住址
            }
            if (mstrPHONE != "")
            {
                objRow["PHONE"] = mstrPHONE; //电话
            }
            if (mstrPOST_NO != "")
            {
                objRow["POST_NO"] = mstrPOST_NO; //邮政编码
            }
            if (mstrPOST_ADDRESS != "")
            {
                objRow["POST_ADDRESS"] = mstrPOST_ADDRESS; //邮政地址
            }
            if (mstrMAIL != "")
            {
                objRow["MAIL"] = mstrMAIL; //信箱
            }
            if (mstrDESCR != "")
            {
                objRow["DESCR"] = mstrDESCR; //DESCR
            }
            if (mstrUSER_ID != "")
            {
                objRow["USER_ID"] = mstrUSER_ID; //用户ID
            }
            objRow["OP_DATE"] = mdteOP_DATE; //OP_DATE
            if (mstrANNEX != "")
            {
                objRow["ANNEX"] = mstrANNEX; //ANNEX
            }
            if (mstrUpdDate != "")
            {
                objRow["UpdDate"] = mstrUpdDate; //UpdDate
            }
            objDS.Tables["PERSON_q"].Rows.Add(objRow);
            try
            {
                objDA.Update(objDS, "PERSON_q");
            }
            catch (Exception objException)
            {
                LogError(objException);
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
                objDA = null;
                objDS = null;
                objCB = null;
                objRow = null;
            }
            return true;
        }



        /// <summary>
        /// 功能：通过SQL命令来插入记录
        /// 主要用于上传文件时。
        /// </summary>
        /// <returns>如果插入成功则返回TRUE，否则为FALSE</returns>
        public bool AddNewRecordBySQL()
        {
            StringBuilder strSQL = new StringBuilder();
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = this.GetSpecSQLObj_Obj();
            strSQL.AppendFormat("insert into PERSON_q (Account, SCH_ID, BANK_ACC, CARD_NO, TEMP_CARD_NO, TEMP_USING, TEMP_DEPOSIT, PASSWORD, MONEY, CARD_KIND, CARD_STATE, LAST_TIME, USEFUL_LIMIT, RECYCLE_LIMIT, NAME, SEX, IDEN_NO, NATION_NO, POLITICS, DUTY, BIRTH, PERSON_ID, STUDENT_ID, SCHOOL_NO, ACADEMY_NO, DEP_NO, CLASS_NO, GRADE, IN_TIME, WALLANCE, ADDRESS, PHONE, POST_NO, POST_ADDRESS, MAIL, DESCR, USER_ID, OP_DATE, ANNEX, UpdDate) values ('{0}', '{1}', '{2}', '{3}', '{4}', {5}, {6}, '{7}', {8}, {9}, {10}, '{11}', '{12}', '{13}', '{14}', {15}, {16}, {17}, '{18}', '{19}', '{20}', '{21}', '{22}', '{23}', '{24}', '{25}', '{26}', '{27}', '{28}', {29}, '{30}', '{31}', '{32}', '{33}', '{34}', '{35}', '{36}', '{37}', '{38}', '{39}')", mstrAccount, mstrSCH_ID, mstrBANK_ACC, mstrCARD_NO, mstrTEMP_CARD_NO, mdblTEMP_USING, mdblTEMP_DEPOSIT, mstrPASSWORD, mdblMONEY, mdblCARD_KIND, mdblCARD_STATE, mdteLAST_TIME, mdteUSEFUL_LIMIT, mdteRECYCLE_LIMIT, mstrNAME, mdblSEX, mdblIDEN_NO, mdblNATION_NO, mstrPOLITICS, mstrDUTY, mdteBIRTH, mstrPERSON_ID, mstrSTUDENT_ID, mstrSCHOOL_NO, mstrACADEMY_NO, mstrDEP_NO, mstrCLASS_NO, mstrGRADE, mdteIN_TIME, mdblWALLANCE, mstrADDRESS, mstrPHONE, mstrPOST_NO, mstrPOST_ADDRESS, mstrMAIL, mstrDESCR, mstrUSER_ID, mdteOP_DATE, mstrANNEX, mstrUpdDate);
            return objSQL.ExecSql(strSQL.ToString());
        }



        /// <summary>
        /// /// 功能：通过SQL命令来插入记录,该方式是优化方式
        /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
        /// </summary>
        /// <returns>如果插入成功则返回TRUE，否则为FALSE</returns>
        public bool AddNewRecordBySQL2()
        {
            StringBuilder strSQL = new StringBuilder();
            //需要插入表的字段列表
            ArrayList arrFieldListForInsert = new ArrayList();
            //需要插入表的值列表
            ArrayList arrValueListForInsert = new ArrayList();
            if (mstrAccount != null)
            {
                arrFieldListForInsert.Add("Account");
                mstrAccount = mstrAccount.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                arrValueListForInsert.Add("'" + mstrAccount + "'");
            }
            if (mstrSCH_ID != null)
            {
                arrFieldListForInsert.Add("SCH_ID");
                mstrSCH_ID = mstrSCH_ID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                arrValueListForInsert.Add("'" + mstrSCH_ID + "'");
            }
            if (mstrBANK_ACC != null)
            {
                arrFieldListForInsert.Add("BANK_ACC");
                mstrBANK_ACC = mstrBANK_ACC.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                arrValueListForInsert.Add("'" + mstrBANK_ACC + "'");
            }
            if (mstrCARD_NO != null)
            {
                arrFieldListForInsert.Add("CARD_NO");
                mstrCARD_NO = mstrCARD_NO.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                arrValueListForInsert.Add("'" + mstrCARD_NO + "'");
            }
            if (mstrTEMP_CARD_NO != null)
            {
                arrFieldListForInsert.Add("TEMP_CARD_NO");
                mstrTEMP_CARD_NO = mstrTEMP_CARD_NO.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                arrValueListForInsert.Add("'" + mstrTEMP_CARD_NO + "'");
            }
            arrFieldListForInsert.Add("TEMP_USING");
            arrValueListForInsert.Add(mdblTEMP_USING.ToString());
            arrFieldListForInsert.Add("TEMP_DEPOSIT");
            arrValueListForInsert.Add(mdblTEMP_DEPOSIT.ToString());
            if (mstrPASSWORD != null)
            {
                arrFieldListForInsert.Add("PASSWORD");
                mstrPASSWORD = mstrPASSWORD.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                arrValueListForInsert.Add("'" + mstrPASSWORD + "'");
            }
            arrFieldListForInsert.Add("MONEY");
            arrValueListForInsert.Add(mdblMONEY.ToString());
            arrFieldListForInsert.Add("CARD_KIND");
            arrValueListForInsert.Add(mdblCARD_KIND.ToString());
            arrFieldListForInsert.Add("CARD_STATE");
            arrValueListForInsert.Add(mdblCARD_STATE.ToString());
            arrFieldListForInsert.Add("LAST_TIME");
            arrValueListForInsert.Add("'" + mdteLAST_TIME + "'");
            arrFieldListForInsert.Add("USEFUL_LIMIT");
            arrValueListForInsert.Add("'" + mdteUSEFUL_LIMIT + "'");
            arrFieldListForInsert.Add("RECYCLE_LIMIT");
            arrValueListForInsert.Add("'" + mdteRECYCLE_LIMIT + "'");
            if (mstrNAME != null)
            {
                arrFieldListForInsert.Add("NAME");
                mstrNAME = mstrNAME.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                arrValueListForInsert.Add("'" + mstrNAME + "'");
            }
            arrFieldListForInsert.Add("SEX");
            arrValueListForInsert.Add(mdblSEX.ToString());
            arrFieldListForInsert.Add("IDEN_NO");
            arrValueListForInsert.Add(mdblIDEN_NO.ToString());
            arrFieldListForInsert.Add("NATION_NO");
            arrValueListForInsert.Add(mdblNATION_NO.ToString());
            if (mstrPOLITICS != null)
            {
                arrFieldListForInsert.Add("POLITICS");
                mstrPOLITICS = mstrPOLITICS.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                arrValueListForInsert.Add("'" + mstrPOLITICS + "'");
            }
            if (mstrDUTY != null)
            {
                arrFieldListForInsert.Add("DUTY");
                mstrDUTY = mstrDUTY.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                arrValueListForInsert.Add("'" + mstrDUTY + "'");
            }
            arrFieldListForInsert.Add("BIRTH");
            arrValueListForInsert.Add("'" + mdteBIRTH + "'");
            if (mstrPERSON_ID != null)
            {
                arrFieldListForInsert.Add("PERSON_ID");
                mstrPERSON_ID = mstrPERSON_ID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                arrValueListForInsert.Add("'" + mstrPERSON_ID + "'");
            }
            if (mstrSTUDENT_ID != null)
            {
                arrFieldListForInsert.Add("STUDENT_ID");
                mstrSTUDENT_ID = mstrSTUDENT_ID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                arrValueListForInsert.Add("'" + mstrSTUDENT_ID + "'");
            }
            if (mstrSCHOOL_NO != null)
            {
                arrFieldListForInsert.Add("SCHOOL_NO");
                mstrSCHOOL_NO = mstrSCHOOL_NO.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                arrValueListForInsert.Add("'" + mstrSCHOOL_NO + "'");
            }
            if (mstrACADEMY_NO != null)
            {
                arrFieldListForInsert.Add("ACADEMY_NO");
                mstrACADEMY_NO = mstrACADEMY_NO.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                arrValueListForInsert.Add("'" + mstrACADEMY_NO + "'");
            }
            if (mstrDEP_NO != null)
            {
                arrFieldListForInsert.Add("DEP_NO");
                mstrDEP_NO = mstrDEP_NO.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                arrValueListForInsert.Add("'" + mstrDEP_NO + "'");
            }
            if (mstrCLASS_NO != null)
            {
                arrFieldListForInsert.Add("CLASS_NO");
                mstrCLASS_NO = mstrCLASS_NO.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                arrValueListForInsert.Add("'" + mstrCLASS_NO + "'");
            }
            if (mstrGRADE != null)
            {
                arrFieldListForInsert.Add("GRADE");
                mstrGRADE = mstrGRADE.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                arrValueListForInsert.Add("'" + mstrGRADE + "'");
            }
            arrFieldListForInsert.Add("IN_TIME");
            arrValueListForInsert.Add("'" + mdteIN_TIME + "'");
            arrFieldListForInsert.Add("WALLANCE");
            arrValueListForInsert.Add(mdblWALLANCE.ToString());
            if (mstrADDRESS != null)
            {
                arrFieldListForInsert.Add("ADDRESS");
                mstrADDRESS = mstrADDRESS.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                arrValueListForInsert.Add("'" + mstrADDRESS + "'");
            }
            if (mstrPHONE != null)
            {
                arrFieldListForInsert.Add("PHONE");
                mstrPHONE = mstrPHONE.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                arrValueListForInsert.Add("'" + mstrPHONE + "'");
            }
            if (mstrPOST_NO != null)
            {
                arrFieldListForInsert.Add("POST_NO");
                mstrPOST_NO = mstrPOST_NO.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                arrValueListForInsert.Add("'" + mstrPOST_NO + "'");
            }
            if (mstrPOST_ADDRESS != null)
            {
                arrFieldListForInsert.Add("POST_ADDRESS");
                mstrPOST_ADDRESS = mstrPOST_ADDRESS.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                arrValueListForInsert.Add("'" + mstrPOST_ADDRESS + "'");
            }
            if (mstrMAIL != null)
            {
                arrFieldListForInsert.Add("MAIL");
                mstrMAIL = mstrMAIL.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                arrValueListForInsert.Add("'" + mstrMAIL + "'");
            }
            if (mstrDESCR != null)
            {
                arrFieldListForInsert.Add("DESCR");
                mstrDESCR = mstrDESCR.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                arrValueListForInsert.Add("'" + mstrDESCR + "'");
            }
            if (mstrUSER_ID != null)
            {
                arrFieldListForInsert.Add("USER_ID");
                mstrUSER_ID = mstrUSER_ID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                arrValueListForInsert.Add("'" + mstrUSER_ID + "'");
            }
            arrFieldListForInsert.Add("OP_DATE");
            arrValueListForInsert.Add("'" + mdteOP_DATE + "'");
            if (mstrANNEX != null)
            {
                arrFieldListForInsert.Add("ANNEX");
                mstrANNEX = mstrANNEX.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                arrValueListForInsert.Add("'" + mstrANNEX + "'");
            }
            if (mstrUpdDate != null)
            {
                arrFieldListForInsert.Add("UpdDate");
                mstrUpdDate = mstrUpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                arrValueListForInsert.Add("'" + mstrUpdDate + "'");
            }
            //组织插入记录SQL串
            string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
            string strFieldListCode = string.Join(",", sstrFieldCode);
            string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
            string strValuesListCode = string.Join(",", sstrValuesCode);
            strSQL.Append("Insert into PERSON_q");
            strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = this.GetSpecSQLObj_Obj();
            return objSQL.ExecSql(strSQL.ToString());
        }



        /// <summary>
        /// 功能：通过SQL命令来插入记录
        /// 主要用于上传文件时。
        /// </summary>
        /// <returns>如果插入成功则返回TRUE，否则为FALSE</returns>
        public bool AddNewRecordBySQL(SqlConnection objSqlConnect, SqlTransaction objSqlTransaction)
        {
            StringBuilder strSQL = new StringBuilder();
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = this.GetSpecSQLObj_Obj();
            strSQL.AppendFormat("insert into PERSON_q (Account, SCH_ID, BANK_ACC, CARD_NO, TEMP_CARD_NO, TEMP_USING, TEMP_DEPOSIT, PASSWORD, MONEY, CARD_KIND, CARD_STATE, LAST_TIME, USEFUL_LIMIT, RECYCLE_LIMIT, NAME, SEX, IDEN_NO, NATION_NO, POLITICS, DUTY, BIRTH, PERSON_ID, STUDENT_ID, SCHOOL_NO, ACADEMY_NO, DEP_NO, CLASS_NO, GRADE, IN_TIME, WALLANCE, ADDRESS, PHONE, POST_NO, POST_ADDRESS, MAIL, DESCR, USER_ID, OP_DATE, ANNEX, UpdDate) values ('{0}', '{1}', '{2}', '{3}', '{4}', {5}, {6}, '{7}', {8}, {9}, {10}, '{11}', '{12}', '{13}', '{14}', {15}, {16}, {17}, '{18}', '{19}', '{20}', '{21}', '{22}', '{23}', '{24}', '{25}', '{26}', '{27}', '{28}', {29}, '{30}', '{31}', '{32}', '{33}', '{34}', '{35}', '{36}', '{37}', '{38}', '{39}')", mstrAccount, mstrSCH_ID, mstrBANK_ACC, mstrCARD_NO, mstrTEMP_CARD_NO, mdblTEMP_USING, mdblTEMP_DEPOSIT, mstrPASSWORD, mdblMONEY, mdblCARD_KIND, mdblCARD_STATE, mdteLAST_TIME, mdteUSEFUL_LIMIT, mdteRECYCLE_LIMIT, mstrNAME, mdblSEX, mdblIDEN_NO, mdblNATION_NO, mstrPOLITICS, mstrDUTY, mdteBIRTH, mstrPERSON_ID, mstrSTUDENT_ID, mstrSCHOOL_NO, mstrACADEMY_NO, mstrDEP_NO, mstrCLASS_NO, mstrGRADE, mdteIN_TIME, mdblWALLANCE, mstrADDRESS, mstrPHONE, mstrPOST_NO, mstrPOST_ADDRESS, mstrMAIL, mstrDESCR, mstrUSER_ID, mdteOP_DATE, mstrANNEX, mstrUpdDate);
            return objSQL.ExecSql(strSQL.ToString(), objSqlConnect, objSqlTransaction);
        }



        /// <summary>
        /// 功能：通过SQL命令来插入记录
        /// 主要用于上传文件时。
        /// </summary>
        /// <returns>如果插入成功则返回TRUE，否则为FALSE</returns>
        public bool AddNewRecordBySQL2(SqlConnection objSqlConnect, SqlTransaction objSqlTransaction)
        {
            StringBuilder strSQL = new StringBuilder();
            //需要插入表的字段列表
            ArrayList arrFieldListForInsert = new ArrayList();
            //需要插入表的值列表
            ArrayList arrValueListForInsert = new ArrayList();
            if (mstrAccount != null)
            {
                arrFieldListForInsert.Add("Account");
                mstrAccount = mstrAccount.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                arrValueListForInsert.Add("'" + mstrAccount + "'");
            }
            if (mstrSCH_ID != null)
            {
                arrFieldListForInsert.Add("SCH_ID");
                mstrSCH_ID = mstrSCH_ID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                arrValueListForInsert.Add("'" + mstrSCH_ID + "'");
            }
            if (mstrBANK_ACC != null)
            {
                arrFieldListForInsert.Add("BANK_ACC");
                mstrBANK_ACC = mstrBANK_ACC.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                arrValueListForInsert.Add("'" + mstrBANK_ACC + "'");
            }
            if (mstrCARD_NO != null)
            {
                arrFieldListForInsert.Add("CARD_NO");
                mstrCARD_NO = mstrCARD_NO.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                arrValueListForInsert.Add("'" + mstrCARD_NO + "'");
            }
            if (mstrTEMP_CARD_NO != null)
            {
                arrFieldListForInsert.Add("TEMP_CARD_NO");
                mstrTEMP_CARD_NO = mstrTEMP_CARD_NO.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                arrValueListForInsert.Add("'" + mstrTEMP_CARD_NO + "'");
            }
            arrFieldListForInsert.Add("TEMP_USING");
            arrValueListForInsert.Add(mdblTEMP_USING.ToString());
            arrFieldListForInsert.Add("TEMP_DEPOSIT");
            arrValueListForInsert.Add(mdblTEMP_DEPOSIT.ToString());
            if (mstrPASSWORD != null)
            {
                arrFieldListForInsert.Add("PASSWORD");
                mstrPASSWORD = mstrPASSWORD.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                arrValueListForInsert.Add("'" + mstrPASSWORD + "'");
            }
            arrFieldListForInsert.Add("MONEY");
            arrValueListForInsert.Add(mdblMONEY.ToString());
            arrFieldListForInsert.Add("CARD_KIND");
            arrValueListForInsert.Add(mdblCARD_KIND.ToString());
            arrFieldListForInsert.Add("CARD_STATE");
            arrValueListForInsert.Add(mdblCARD_STATE.ToString());
            arrFieldListForInsert.Add("LAST_TIME");
            arrValueListForInsert.Add("'" + mdteLAST_TIME + "'");
            arrFieldListForInsert.Add("USEFUL_LIMIT");
            arrValueListForInsert.Add("'" + mdteUSEFUL_LIMIT + "'");
            arrFieldListForInsert.Add("RECYCLE_LIMIT");
            arrValueListForInsert.Add("'" + mdteRECYCLE_LIMIT + "'");
            if (mstrNAME != null)
            {
                arrFieldListForInsert.Add("NAME");
                mstrNAME = mstrNAME.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                arrValueListForInsert.Add("'" + mstrNAME + "'");
            }
            arrFieldListForInsert.Add("SEX");
            arrValueListForInsert.Add(mdblSEX.ToString());
            arrFieldListForInsert.Add("IDEN_NO");
            arrValueListForInsert.Add(mdblIDEN_NO.ToString());
            arrFieldListForInsert.Add("NATION_NO");
            arrValueListForInsert.Add(mdblNATION_NO.ToString());
            if (mstrPOLITICS != null)
            {
                arrFieldListForInsert.Add("POLITICS");
                mstrPOLITICS = mstrPOLITICS.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                arrValueListForInsert.Add("'" + mstrPOLITICS + "'");
            }
            if (mstrDUTY != null)
            {
                arrFieldListForInsert.Add("DUTY");
                mstrDUTY = mstrDUTY.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                arrValueListForInsert.Add("'" + mstrDUTY + "'");
            }
            arrFieldListForInsert.Add("BIRTH");
            arrValueListForInsert.Add("'" + mdteBIRTH + "'");
            if (mstrPERSON_ID != null)
            {
                arrFieldListForInsert.Add("PERSON_ID");
                mstrPERSON_ID = mstrPERSON_ID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                arrValueListForInsert.Add("'" + mstrPERSON_ID + "'");
            }
            if (mstrSTUDENT_ID != null)
            {
                arrFieldListForInsert.Add("STUDENT_ID");
                mstrSTUDENT_ID = mstrSTUDENT_ID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                arrValueListForInsert.Add("'" + mstrSTUDENT_ID + "'");
            }
            if (mstrSCHOOL_NO != null)
            {
                arrFieldListForInsert.Add("SCHOOL_NO");
                mstrSCHOOL_NO = mstrSCHOOL_NO.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                arrValueListForInsert.Add("'" + mstrSCHOOL_NO + "'");
            }
            if (mstrACADEMY_NO != null)
            {
                arrFieldListForInsert.Add("ACADEMY_NO");
                mstrACADEMY_NO = mstrACADEMY_NO.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                arrValueListForInsert.Add("'" + mstrACADEMY_NO + "'");
            }
            if (mstrDEP_NO != null)
            {
                arrFieldListForInsert.Add("DEP_NO");
                mstrDEP_NO = mstrDEP_NO.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                arrValueListForInsert.Add("'" + mstrDEP_NO + "'");
            }
            if (mstrCLASS_NO != null)
            {
                arrFieldListForInsert.Add("CLASS_NO");
                mstrCLASS_NO = mstrCLASS_NO.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                arrValueListForInsert.Add("'" + mstrCLASS_NO + "'");
            }
            if (mstrGRADE != null)
            {
                arrFieldListForInsert.Add("GRADE");
                mstrGRADE = mstrGRADE.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                arrValueListForInsert.Add("'" + mstrGRADE + "'");
            }
            arrFieldListForInsert.Add("IN_TIME");
            arrValueListForInsert.Add("'" + mdteIN_TIME + "'");
            arrFieldListForInsert.Add("WALLANCE");
            arrValueListForInsert.Add(mdblWALLANCE.ToString());
            if (mstrADDRESS != null)
            {
                arrFieldListForInsert.Add("ADDRESS");
                mstrADDRESS = mstrADDRESS.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                arrValueListForInsert.Add("'" + mstrADDRESS + "'");
            }
            if (mstrPHONE != null)
            {
                arrFieldListForInsert.Add("PHONE");
                mstrPHONE = mstrPHONE.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                arrValueListForInsert.Add("'" + mstrPHONE + "'");
            }
            if (mstrPOST_NO != null)
            {
                arrFieldListForInsert.Add("POST_NO");
                mstrPOST_NO = mstrPOST_NO.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                arrValueListForInsert.Add("'" + mstrPOST_NO + "'");
            }
            if (mstrPOST_ADDRESS != null)
            {
                arrFieldListForInsert.Add("POST_ADDRESS");
                mstrPOST_ADDRESS = mstrPOST_ADDRESS.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                arrValueListForInsert.Add("'" + mstrPOST_ADDRESS + "'");
            }
            if (mstrMAIL != null)
            {
                arrFieldListForInsert.Add("MAIL");
                mstrMAIL = mstrMAIL.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                arrValueListForInsert.Add("'" + mstrMAIL + "'");
            }
            if (mstrDESCR != null)
            {
                arrFieldListForInsert.Add("DESCR");
                mstrDESCR = mstrDESCR.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                arrValueListForInsert.Add("'" + mstrDESCR + "'");
            }
            if (mstrUSER_ID != null)
            {
                arrFieldListForInsert.Add("USER_ID");
                mstrUSER_ID = mstrUSER_ID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                arrValueListForInsert.Add("'" + mstrUSER_ID + "'");
            }
            arrFieldListForInsert.Add("OP_DATE");
            arrValueListForInsert.Add("'" + mdteOP_DATE + "'");
            if (mstrANNEX != null)
            {
                arrFieldListForInsert.Add("ANNEX");
                mstrANNEX = mstrANNEX.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                arrValueListForInsert.Add("'" + mstrANNEX + "'");
            }
            if (mstrUpdDate != null)
            {
                arrFieldListForInsert.Add("UpdDate");
                mstrUpdDate = mstrUpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                arrValueListForInsert.Add("'" + mstrUpdDate + "'");
            }
            //组织插入记录SQL串
            string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
            string strFieldListCode = string.Join(",", sstrFieldCode);
            string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
            string strValuesListCode = string.Join(",", sstrValuesCode);
            strSQL.Append("Insert into PERSON_q");
            strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = this.GetSpecSQLObj_Obj();
            return objSQL.ExecSql(strSQL.ToString(), objSqlConnect, objSqlTransaction);
        }


        /// <summary>
        /// 功能：通过存储过程来插入记录
        /// </summary>
        /// <returns>如果插入成功则返回TRUE，否则为FALSE</returns>
        public bool AddnewPERSON_qBySP()
        {
            //通过存储过程来
            //直接使用
            if (mintErrNo != 0)
            {
                //MsgBox(mstrErrMsg(mintErrNo))
                return false;
            }
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = this.GetSpecSQLObj_Obj();
            objSQL.SPConfigXMLFile = clsSysPara.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(mstrAccount);
            values.Add(mstrSCH_ID);
            values.Add(mstrBANK_ACC);
            values.Add(mstrCARD_NO);
            values.Add(mstrTEMP_CARD_NO);
            values.Add(mdblTEMP_USING);
            values.Add(mdblTEMP_DEPOSIT);
            values.Add(mstrPASSWORD);
            values.Add(mdblMONEY);
            values.Add(mdblCARD_KIND);
            values.Add(mdblCARD_STATE);
            values.Add(mdteLAST_TIME);
            values.Add(mdteUSEFUL_LIMIT);
            values.Add(mdteRECYCLE_LIMIT);
            values.Add(mstrNAME);
            values.Add(mdblSEX);
            values.Add(mdblIDEN_NO);
            values.Add(mdblNATION_NO);
            values.Add(mstrPOLITICS);
            values.Add(mstrDUTY);
            values.Add(mdteBIRTH);
            values.Add(mstrPERSON_ID);
            values.Add(mstrSTUDENT_ID);
            values.Add(mstrSCHOOL_NO);
            values.Add(mstrACADEMY_NO);
            values.Add(mstrDEP_NO);
            values.Add(mstrCLASS_NO);
            values.Add(mstrGRADE);
            values.Add(mdteIN_TIME);
            values.Add(mdblWALLANCE);
            values.Add(mstrADDRESS);
            values.Add(mstrPHONE);
            values.Add(mstrPOST_NO);
            values.Add(mstrPOST_ADDRESS);
            values.Add(mstrMAIL);
            values.Add(mstrDESCR);
            values.Add(mstrUSER_ID);
            values.Add(mdteOP_DATE);
            values.Add(mstrANNEX);
            values.Add(mstrUpdDate);
            objSQL.ExecSP("p_Add_PERSON_q", values);
            return true;
        }

        /// <summary>
        /// 把多条记录同时插入到表中!
        /// </summary>
        /// <param name="oDT"></param>
        /// <param name="strResult"></param>
        /// <returns></returns>
        public bool AddnewPERSON_qs(System.Data.DataTable oDT, ref string strResult)
        {
            string strSQL;
            System.Data.SqlClient.SqlDataAdapter objDA;
            System.Data.DataSet objDS = new System.Data.DataSet();
            System.Data.SqlClient.SqlCommandBuilder objCB;
            System.Data.DataRow objRow;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = this.GetSpecSQLObj_Obj();
            if (mintErrNo != 0)
            {
                strResult = "错误号为：" + mintErrNo.ToString();
                return false;
            }
            strSQL = "Select * from PERSON_q where Account='111'";
            objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
            objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
            objDA.Fill(objDS, "PERSON_q");
            //检查关键字的唯一性
            foreach (System.Data.DataRow oRow in oDT.Rows)
            {
                string strAccount = oRow["Account"].ToString().Trim();
                if (IsExist(strAccount))
                {
                    strResult = "关键字Account为：" + strAccount + "的记录已存在，不能重复插入!";
                    return false;
                }
            }
            //把多条记录插入到表中
            foreach (System.Data.DataRow oRow in oDT.Rows)
            {
                objRow = objDS.Tables["PERSON_q"].NewRow();
                objRow["Account"] = oRow["Account"].ToString().Trim(); //卡号
                objRow["SCH_ID"] = oRow["SCH_ID"].ToString().Trim(); //SCH_ID
                objRow["BANK_ACC"] = oRow["BANK_ACC"].ToString().Trim(); //银行帐号
                objRow["CARD_NO"] = oRow["CARD_NO"].ToString().Trim(); //CARD_NO
                objRow["TEMP_CARD_NO"] = oRow["TEMP_CARD_NO"].ToString().Trim(); //TEMP_CARD_NO
                objRow["TEMP_USING"] = oRow["TEMP_USING"].ToString().Trim(); //TEMP_USING
                objRow["TEMP_DEPOSIT"] = oRow["TEMP_DEPOSIT"].ToString().Trim(); //TEMP_DEPOSIT
                objRow["PASSWORD"] = oRow["PASSWORD"].ToString().Trim(); //密码
                objRow["MONEY"] = oRow["MONEY"].ToString().Trim(); //MONEY
                objRow["CARD_KIND"] = oRow["CARD_KIND"].ToString().Trim(); //CARD_KIND
                objRow["CARD_STATE"] = oRow["CARD_STATE"].ToString().Trim(); //CARD_STATE
                objRow["LAST_TIME"] = oRow["LAST_TIME"].ToString().Trim(); //LAST_TIME
                objRow["USEFUL_LIMIT"] = oRow["USEFUL_LIMIT"].ToString().Trim(); //USEFUL_LIMIT
                objRow["RECYCLE_LIMIT"] = oRow["RECYCLE_LIMIT"].ToString().Trim(); //RECYCLE_LIMIT
                objRow["NAME"] = oRow["NAME"].ToString().Trim(); //名称
                objRow["SEX"] = oRow["SEX"].ToString().Trim(); //性别
                objRow["IDEN_NO"] = oRow["IDEN_NO"].ToString().Trim(); //IDEN_NO
                objRow["NATION_NO"] = oRow["NATION_NO"].ToString().Trim(); //国籍编号
                objRow["POLITICS"] = oRow["POLITICS"].ToString().Trim(); //政治面貌
                objRow["DUTY"] = oRow["DUTY"].ToString().Trim(); //DUTY
                objRow["BIRTH"] = oRow["BIRTH"].ToString().Trim(); //入学时间
                objRow["PERSON_ID"] = oRow["PERSON_ID"].ToString().Trim(); //身份证号码
                objRow["STUDENT_ID"] = oRow["STUDENT_ID"].ToString().Trim(); //学号
                objRow["SCHOOL_NO"] = oRow["SCHOOL_NO"].ToString().Trim(); //SCHOOL_NO
                objRow["ACADEMY_NO"] = oRow["ACADEMY_NO"].ToString().Trim(); //学院编号
                objRow["DEP_NO"] = oRow["DEP_NO"].ToString().Trim(); //专业编号
                objRow["CLASS_NO"] = oRow["CLASS_NO"].ToString().Trim(); //班级编号
                objRow["GRADE"] = oRow["GRADE"].ToString().Trim(); //年级
                objRow["IN_TIME"] = oRow["IN_TIME"].ToString().Trim(); //IN_TIME
                objRow["WALLANCE"] = oRow["WALLANCE"].ToString().Trim(); //WALLANCE
                objRow["ADDRESS"] = oRow["ADDRESS"].ToString().Trim(); //家庭住址
                objRow["PHONE"] = oRow["PHONE"].ToString().Trim(); //电话
                objRow["POST_NO"] = oRow["POST_NO"].ToString().Trim(); //邮政编码
                objRow["POST_ADDRESS"] = oRow["POST_ADDRESS"].ToString().Trim(); //邮政地址
                objRow["MAIL"] = oRow["MAIL"].ToString().Trim(); //信箱
                objRow["DESCR"] = oRow["DESCR"].ToString().Trim(); //DESCR
                objRow["USER_ID"] = oRow["USER_ID"].ToString().Trim(); //用户ID
                objRow["OP_DATE"] = oRow["OP_DATE"].ToString().Trim(); //OP_DATE
                objRow["ANNEX"] = oRow["ANNEX"].ToString().Trim(); //ANNEX
                objRow["UpdDate"] = oRow["UpdDate"].ToString().Trim(); //UpdDate
                objDS.Tables["PERSON_q"].Rows.Add(objRow);
            }
            try
            {
                objDA.Update(objDS, "PERSON_q");
            }
            catch (Exception objException)
            {
                LogError(objException);
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
                objDA = null;
                objDS = null;
                objCB = null;
                objRow = null;
                objSQL.SQLConnect.Close();
                objSQL = null;
            }
            return true;
        }

        /// <summary>
        /// 功能：修改记录
        /// </summary>
        /// <returns>如果修改成功则返回TRUE，否则为FALSE</returns>
        public bool Update()
        {
            string strSQL;
            System.Data.SqlClient.SqlDataAdapter objDA;
            System.Data.DataSet objDS = new System.Data.DataSet();
            System.Data.SqlClient.SqlCommandBuilder objCB;
            System.Data.DataRow objRow;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = this.GetSpecSQLObj_Obj();
            strSQL = "Select * from PERSON_q where Account=" + "'" + mstrAccount + "'";
            objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
            objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
            objDA.Fill(objDS, "PERSON_q");
            if (objDS.Tables["PERSON_q"].Rows.Count == 0)
            {
                //MsgBox("没有相应的ID号：Account=" + "'"+ mstrAccount+"'");
                return false;
            }
            objRow = objDS.Tables["PERSON_q"].Rows[0];
            if (IsUpdated("SCH_ID"))
            {
                objRow["SCH_ID"] = mstrSCH_ID; //SCH_ID
            }
            if (IsUpdated("BANK_ACC"))
            {
                objRow["BANK_ACC"] = mstrBANK_ACC; //银行帐号
            }
            if (IsUpdated("CARD_NO"))
            {
                objRow["CARD_NO"] = mstrCARD_NO; //CARD_NO
            }
            if (IsUpdated("TEMP_CARD_NO"))
            {
                objRow["TEMP_CARD_NO"] = mstrTEMP_CARD_NO; //TEMP_CARD_NO
            }
            if (IsUpdated("TEMP_USING"))
            {
                objRow["TEMP_USING"] = mdblTEMP_USING; //TEMP_USING
            }
            if (IsUpdated("TEMP_DEPOSIT"))
            {
                objRow["TEMP_DEPOSIT"] = mdblTEMP_DEPOSIT; //TEMP_DEPOSIT
            }
            if (IsUpdated("PASSWORD"))
            {
                objRow["PASSWORD"] = mstrPASSWORD; //密码
            }
            if (IsUpdated("MONEY"))
            {
                objRow["MONEY"] = mdblMONEY; //MONEY
            }
            if (IsUpdated("CARD_KIND"))
            {
                objRow["CARD_KIND"] = mdblCARD_KIND; //CARD_KIND
            }
            if (IsUpdated("CARD_STATE"))
            {
                objRow["CARD_STATE"] = mdblCARD_STATE; //CARD_STATE
            }
            if (IsUpdated("LAST_TIME"))
            {
                objRow["LAST_TIME"] = mdteLAST_TIME; //LAST_TIME
            }
            if (IsUpdated("USEFUL_LIMIT"))
            {
                objRow["USEFUL_LIMIT"] = mdteUSEFUL_LIMIT; //USEFUL_LIMIT
            }
            if (IsUpdated("RECYCLE_LIMIT"))
            {
                objRow["RECYCLE_LIMIT"] = mdteRECYCLE_LIMIT; //RECYCLE_LIMIT
            }
            if (IsUpdated("NAME"))
            {
                objRow["NAME"] = mstrNAME; //名称
            }
            if (IsUpdated("SEX"))
            {
                objRow["SEX"] = mdblSEX; //性别
            }
            if (IsUpdated("IDEN_NO"))
            {
                objRow["IDEN_NO"] = mdblIDEN_NO; //IDEN_NO
            }
            if (IsUpdated("NATION_NO"))
            {
                objRow["NATION_NO"] = mdblNATION_NO; //国籍编号
            }
            if (IsUpdated("POLITICS"))
            {
                objRow["POLITICS"] = mstrPOLITICS; //政治面貌
            }
            if (IsUpdated("DUTY"))
            {
                objRow["DUTY"] = mstrDUTY; //DUTY
            }
            if (IsUpdated("BIRTH"))
            {
                objRow["BIRTH"] = mdteBIRTH; //入学时间
            }
            if (IsUpdated("PERSON_ID"))
            {
                objRow["PERSON_ID"] = mstrPERSON_ID; //身份证号码
            }
            if (IsUpdated("STUDENT_ID"))
            {
                objRow["STUDENT_ID"] = mstrSTUDENT_ID; //学号
            }
            if (IsUpdated("SCHOOL_NO"))
            {
                objRow["SCHOOL_NO"] = mstrSCHOOL_NO; //SCHOOL_NO
            }
            if (IsUpdated("ACADEMY_NO"))
            {
                objRow["ACADEMY_NO"] = mstrACADEMY_NO; //学院编号
            }
            if (IsUpdated("DEP_NO"))
            {
                objRow["DEP_NO"] = mstrDEP_NO; //专业编号
            }
            if (IsUpdated("CLASS_NO"))
            {
                objRow["CLASS_NO"] = mstrCLASS_NO; //班级编号
            }
            if (IsUpdated("GRADE"))
            {
                objRow["GRADE"] = mstrGRADE; //年级
            }
            if (IsUpdated("IN_TIME"))
            {
                objRow["IN_TIME"] = mdteIN_TIME; //IN_TIME
            }
            if (IsUpdated("WALLANCE"))
            {
                objRow["WALLANCE"] = mdblWALLANCE; //WALLANCE
            }
            if (IsUpdated("ADDRESS"))
            {
                objRow["ADDRESS"] = mstrADDRESS; //家庭住址
            }
            if (IsUpdated("PHONE"))
            {
                objRow["PHONE"] = mstrPHONE; //电话
            }
            if (IsUpdated("POST_NO"))
            {
                objRow["POST_NO"] = mstrPOST_NO; //邮政编码
            }
            if (IsUpdated("POST_ADDRESS"))
            {
                objRow["POST_ADDRESS"] = mstrPOST_ADDRESS; //邮政地址
            }
            if (IsUpdated("MAIL"))
            {
                objRow["MAIL"] = mstrMAIL; //信箱
            }
            if (IsUpdated("DESCR"))
            {
                objRow["DESCR"] = mstrDESCR; //DESCR
            }
            if (IsUpdated("USER_ID"))
            {
                objRow["USER_ID"] = mstrUSER_ID; //用户ID
            }
            if (IsUpdated("OP_DATE"))
            {
                objRow["OP_DATE"] = mdteOP_DATE; //OP_DATE
            }
            if (IsUpdated("ANNEX"))
            {
                objRow["ANNEX"] = mstrANNEX; //ANNEX
            }
            if (IsUpdated("UpdDate"))
            {
                objRow["UpdDate"] = mstrUpdDate; //UpdDate
            }
            try
            {
                objDA.Update(objDS, "PERSON_q");
            }
            catch (Exception objException)
            {
                LogError(objException);
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
                objDA = null;
                objDS = null;
                objCB = null;
                objRow = null;
            }
            return true;
        }


        /// <summary>
        /// /// 功能：通过存储过程(StoreProcedure)来修改记录
        /// /// 缺点:1、不能支持事务处理.
        /// </summary>
        /// <returns>如果修改成功则返回TRUE，否则为FALSE</returns>
        public bool UpdatePERSON_qBySP()
        {
            //通过存储过程来
            //直接使用
            if (mintErrNo != 0)
            {
                //MsgBox(mstrErrMsg(mintErrNo))
                return false;
            }
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = this.GetSpecSQLObj_Obj();
            objSQL.SPConfigXMLFile = clsSysPara.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(mstrAccount);
            values.Add(mstrSCH_ID);
            values.Add(mstrBANK_ACC);
            values.Add(mstrCARD_NO);
            values.Add(mstrTEMP_CARD_NO);
            values.Add(mdblTEMP_USING);
            values.Add(mdblTEMP_DEPOSIT);
            values.Add(mstrPASSWORD);
            values.Add(mdblMONEY);
            values.Add(mdblCARD_KIND);
            values.Add(mdblCARD_STATE);
            values.Add(mdteLAST_TIME);
            values.Add(mdteUSEFUL_LIMIT);
            values.Add(mdteRECYCLE_LIMIT);
            values.Add(mstrNAME);
            values.Add(mdblSEX);
            values.Add(mdblIDEN_NO);
            values.Add(mdblNATION_NO);
            values.Add(mstrPOLITICS);
            values.Add(mstrDUTY);
            values.Add(mdteBIRTH);
            values.Add(mstrPERSON_ID);
            values.Add(mstrSTUDENT_ID);
            values.Add(mstrSCHOOL_NO);
            values.Add(mstrACADEMY_NO);
            values.Add(mstrDEP_NO);
            values.Add(mstrCLASS_NO);
            values.Add(mstrGRADE);
            values.Add(mdteIN_TIME);
            values.Add(mdblWALLANCE);
            values.Add(mstrADDRESS);
            values.Add(mstrPHONE);
            values.Add(mstrPOST_NO);
            values.Add(mstrPOST_ADDRESS);
            values.Add(mstrMAIL);
            values.Add(mstrDESCR);
            values.Add(mstrUSER_ID);
            values.Add(mdteOP_DATE);
            values.Add(mstrANNEX);
            values.Add(mstrUpdDate);
            objSQL.ExecSP("p_Upt_PERSON_q", values);
            return true;
        }

        /// <summary>
        /// /// 功能：通过SQL命令来修改记录,该方式是非优化方式
        /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
        /// </summary>
        /// <returns>如果修改成功则返回TRUE，否则为FALSE</returns>
        public bool UpdateBySql()
        {
            StringBuilder sbSQL = new StringBuilder();
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = this.GetSpecSQLObj_Obj();
            sbSQL.AppendFormat("Update PERSON_q Set ");
            sbSQL.AppendFormat("SCH_ID = '{0}'", mstrSCH_ID); //SCH_ID
            sbSQL.AppendFormat(", BANK_ACC = '{0}'", mstrBANK_ACC); //银行帐号
            sbSQL.AppendFormat(", CARD_NO = '{0}'", mstrCARD_NO); //CARD_NO
            sbSQL.AppendFormat(", TEMP_CARD_NO = '{0}'", mstrTEMP_CARD_NO); //TEMP_CARD_NO
            sbSQL.AppendFormat(", TEMP_USING = {0}", mdblTEMP_USING); //TEMP_USING
            sbSQL.AppendFormat(", TEMP_DEPOSIT = {0}", mdblTEMP_DEPOSIT); //TEMP_DEPOSIT
            sbSQL.AppendFormat(", PASSWORD = '{0}'", mstrPASSWORD); //密码
            sbSQL.AppendFormat(", MONEY = {0}", mdblMONEY); //MONEY
            sbSQL.AppendFormat(", CARD_KIND = {0}", mdblCARD_KIND); //CARD_KIND
            sbSQL.AppendFormat(", CARD_STATE = {0}", mdblCARD_STATE); //CARD_STATE
            sbSQL.AppendFormat(", LAST_TIME = '{0}'", mdteLAST_TIME); //LAST_TIME
            sbSQL.AppendFormat(", USEFUL_LIMIT = '{0}'", mdteUSEFUL_LIMIT); //USEFUL_LIMIT
            sbSQL.AppendFormat(", RECYCLE_LIMIT = '{0}'", mdteRECYCLE_LIMIT); //RECYCLE_LIMIT
            sbSQL.AppendFormat(", NAME = '{0}'", mstrNAME); //名称
            sbSQL.AppendFormat(", SEX = {0}", mdblSEX); //性别
            sbSQL.AppendFormat(", IDEN_NO = {0}", mdblIDEN_NO); //IDEN_NO
            sbSQL.AppendFormat(", NATION_NO = {0}", mdblNATION_NO); //国籍编号
            sbSQL.AppendFormat(", POLITICS = '{0}'", mstrPOLITICS); //政治面貌
            sbSQL.AppendFormat(", DUTY = '{0}'", mstrDUTY); //DUTY
            sbSQL.AppendFormat(", BIRTH = '{0}'", mdteBIRTH); //入学时间
            sbSQL.AppendFormat(", PERSON_ID = '{0}'", mstrPERSON_ID); //身份证号码
            sbSQL.AppendFormat(", STUDENT_ID = '{0}'", mstrSTUDENT_ID); //学号
            sbSQL.AppendFormat(", SCHOOL_NO = '{0}'", mstrSCHOOL_NO); //SCHOOL_NO
            sbSQL.AppendFormat(", ACADEMY_NO = '{0}'", mstrACADEMY_NO); //学院编号
            sbSQL.AppendFormat(", DEP_NO = '{0}'", mstrDEP_NO); //专业编号
            sbSQL.AppendFormat(", CLASS_NO = '{0}'", mstrCLASS_NO); //班级编号
            sbSQL.AppendFormat(", GRADE = '{0}'", mstrGRADE); //年级
            sbSQL.AppendFormat(", IN_TIME = '{0}'", mdteIN_TIME); //IN_TIME
            sbSQL.AppendFormat(", WALLANCE = {0}", mdblWALLANCE); //WALLANCE
            sbSQL.AppendFormat(", ADDRESS = '{0}'", mstrADDRESS); //家庭住址
            sbSQL.AppendFormat(", PHONE = '{0}'", mstrPHONE); //电话
            sbSQL.AppendFormat(", POST_NO = '{0}'", mstrPOST_NO); //邮政编码
            sbSQL.AppendFormat(", POST_ADDRESS = '{0}'", mstrPOST_ADDRESS); //邮政地址
            sbSQL.AppendFormat(", MAIL = '{0}'", mstrMAIL); //信箱
            sbSQL.AppendFormat(", DESCR = '{0}'", mstrDESCR); //DESCR
            sbSQL.AppendFormat(", USER_ID = '{0}'", mstrUSER_ID); //用户ID
            sbSQL.AppendFormat(", OP_DATE = '{0}'", mdteOP_DATE); //OP_DATE
            sbSQL.AppendFormat(", ANNEX = '{0}'", mstrANNEX); //ANNEX
            sbSQL.AppendFormat(", UpdDate = '{0}'", mstrUpdDate); //UpdDate
            sbSQL.AppendFormat("Where Account = '{0}'", mstrAccount);
            try
            {
                return objSQL.ExecSql(sbSQL.ToString());
            }
            catch (Exception objException)
            {
                LogError(objException);
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
            }
        }


        /// <summary>
        /// /// 功能：通过SQL命令来修改记录,该方式是优化方式
        /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
        /// </summary>
        /// <returns>如果修改成功则返回TRUE，否则为FALSE</returns>
        public bool UpdateBySql2()
        {
            StringBuilder sbSQL = new StringBuilder();
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = this.GetSpecSQLObj_Obj();
            sbSQL.AppendFormat("Update PERSON_q Set ");
            if (IsUpdated("SCH_ID"))
            {
                mstrSCH_ID = mstrSCH_ID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                sbSQL.AppendFormat(" SCH_ID = '{0}',", mstrSCH_ID); //SCH_ID
            }
            if (IsUpdated("BANK_ACC"))
            {
                mstrBANK_ACC = mstrBANK_ACC.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                sbSQL.AppendFormat(" BANK_ACC = '{0}',", mstrBANK_ACC); //银行帐号
            }
            if (IsUpdated("CARD_NO"))
            {
                mstrCARD_NO = mstrCARD_NO.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                sbSQL.AppendFormat(" CARD_NO = '{0}',", mstrCARD_NO); //CARD_NO
            }
            if (IsUpdated("TEMP_CARD_NO"))
            {
                mstrTEMP_CARD_NO = mstrTEMP_CARD_NO.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                sbSQL.AppendFormat(" TEMP_CARD_NO = '{0}',", mstrTEMP_CARD_NO); //TEMP_CARD_NO
            }
            if (IsUpdated("TEMP_USING"))
            {
                sbSQL.AppendFormat(" TEMP_USING = {0},", mdblTEMP_USING); //TEMP_USING
            }
            if (IsUpdated("TEMP_DEPOSIT"))
            {
                sbSQL.AppendFormat(" TEMP_DEPOSIT = {0},", mdblTEMP_DEPOSIT); //TEMP_DEPOSIT
            }
            if (IsUpdated("PASSWORD"))
            {
                mstrPASSWORD = mstrPASSWORD.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                sbSQL.AppendFormat(" PASSWORD = '{0}',", mstrPASSWORD); //密码
            }
            if (IsUpdated("MONEY"))
            {
                sbSQL.AppendFormat(" MONEY = {0},", mdblMONEY); //MONEY
            }
            if (IsUpdated("CARD_KIND"))
            {
                sbSQL.AppendFormat(" CARD_KIND = {0},", mdblCARD_KIND); //CARD_KIND
            }
            if (IsUpdated("CARD_STATE"))
            {
                sbSQL.AppendFormat(" CARD_STATE = {0},", mdblCARD_STATE); //CARD_STATE
            }
            if (IsUpdated("LAST_TIME"))
            {
                sbSQL.AppendFormat(" LAST_TIME = '{0}',", mdteLAST_TIME); //LAST_TIME
            }
            if (IsUpdated("USEFUL_LIMIT"))
            {
                sbSQL.AppendFormat(" USEFUL_LIMIT = '{0}',", mdteUSEFUL_LIMIT); //USEFUL_LIMIT
            }
            if (IsUpdated("RECYCLE_LIMIT"))
            {
                sbSQL.AppendFormat(" RECYCLE_LIMIT = '{0}',", mdteRECYCLE_LIMIT); //RECYCLE_LIMIT
            }
            if (IsUpdated("NAME"))
            {
                mstrNAME = mstrNAME.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                sbSQL.AppendFormat(" NAME = '{0}',", mstrNAME); //名称
            }
            if (IsUpdated("SEX"))
            {
                sbSQL.AppendFormat(" SEX = {0},", mdblSEX); //性别
            }
            if (IsUpdated("IDEN_NO"))
            {
                sbSQL.AppendFormat(" IDEN_NO = {0},", mdblIDEN_NO); //IDEN_NO
            }
            if (IsUpdated("NATION_NO"))
            {
                sbSQL.AppendFormat(" NATION_NO = {0},", mdblNATION_NO); //国籍编号
            }
            if (IsUpdated("POLITICS"))
            {
                mstrPOLITICS = mstrPOLITICS.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                sbSQL.AppendFormat(" POLITICS = '{0}',", mstrPOLITICS); //政治面貌
            }
            if (IsUpdated("DUTY"))
            {
                mstrDUTY = mstrDUTY.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                sbSQL.AppendFormat(" DUTY = '{0}',", mstrDUTY); //DUTY
            }
            if (IsUpdated("BIRTH"))
            {
                sbSQL.AppendFormat(" BIRTH = '{0}',", mdteBIRTH); //入学时间
            }
            if (IsUpdated("PERSON_ID"))
            {
                mstrPERSON_ID = mstrPERSON_ID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                sbSQL.AppendFormat(" PERSON_ID = '{0}',", mstrPERSON_ID); //身份证号码
            }
            if (IsUpdated("STUDENT_ID"))
            {
                mstrSTUDENT_ID = mstrSTUDENT_ID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                sbSQL.AppendFormat(" STUDENT_ID = '{0}',", mstrSTUDENT_ID); //学号
            }
            if (IsUpdated("SCHOOL_NO"))
            {
                mstrSCHOOL_NO = mstrSCHOOL_NO.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                sbSQL.AppendFormat(" SCHOOL_NO = '{0}',", mstrSCHOOL_NO); //SCHOOL_NO
            }
            if (IsUpdated("ACADEMY_NO"))
            {
                mstrACADEMY_NO = mstrACADEMY_NO.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                sbSQL.AppendFormat(" ACADEMY_NO = '{0}',", mstrACADEMY_NO); //学院编号
            }
            if (IsUpdated("DEP_NO"))
            {
                mstrDEP_NO = mstrDEP_NO.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                sbSQL.AppendFormat(" DEP_NO = '{0}',", mstrDEP_NO); //专业编号
            }
            if (IsUpdated("CLASS_NO"))
            {
                mstrCLASS_NO = mstrCLASS_NO.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                sbSQL.AppendFormat(" CLASS_NO = '{0}',", mstrCLASS_NO); //班级编号
            }
            if (IsUpdated("GRADE"))
            {
                mstrGRADE = mstrGRADE.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                sbSQL.AppendFormat(" GRADE = '{0}',", mstrGRADE); //年级
            }
            if (IsUpdated("IN_TIME"))
            {
                sbSQL.AppendFormat(" IN_TIME = '{0}',", mdteIN_TIME); //IN_TIME
            }
            if (IsUpdated("WALLANCE"))
            {
                sbSQL.AppendFormat(" WALLANCE = {0},", mdblWALLANCE); //WALLANCE
            }
            if (IsUpdated("ADDRESS"))
            {
                mstrADDRESS = mstrADDRESS.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                sbSQL.AppendFormat(" ADDRESS = '{0}',", mstrADDRESS); //家庭住址
            }
            if (IsUpdated("PHONE"))
            {
                mstrPHONE = mstrPHONE.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                sbSQL.AppendFormat(" PHONE = '{0}',", mstrPHONE); //电话
            }
            if (IsUpdated("POST_NO"))
            {
                mstrPOST_NO = mstrPOST_NO.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                sbSQL.AppendFormat(" POST_NO = '{0}',", mstrPOST_NO); //邮政编码
            }
            if (IsUpdated("POST_ADDRESS"))
            {
                mstrPOST_ADDRESS = mstrPOST_ADDRESS.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                sbSQL.AppendFormat(" POST_ADDRESS = '{0}',", mstrPOST_ADDRESS); //邮政地址
            }
            if (IsUpdated("MAIL"))
            {
                mstrMAIL = mstrMAIL.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                sbSQL.AppendFormat(" MAIL = '{0}',", mstrMAIL); //信箱
            }
            if (IsUpdated("DESCR"))
            {
                mstrDESCR = mstrDESCR.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                sbSQL.AppendFormat(" DESCR = '{0}',", mstrDESCR); //DESCR
            }
            if (IsUpdated("USER_ID"))
            {
                mstrUSER_ID = mstrUSER_ID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                sbSQL.AppendFormat(" USER_ID = '{0}',", mstrUSER_ID); //用户ID
            }
            if (IsUpdated("OP_DATE"))
            {
                sbSQL.AppendFormat(" OP_DATE = '{0}',", mdteOP_DATE); //OP_DATE
            }
            if (IsUpdated("ANNEX"))
            {
                mstrANNEX = mstrANNEX.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                sbSQL.AppendFormat(" ANNEX = '{0}',", mstrANNEX); //ANNEX
            }
            if (IsUpdated("UpdDate"))
            {
                mstrUpdDate = mstrUpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                sbSQL.AppendFormat(" UpdDate = '{0}',", mstrUpdDate); //UpdDate
            }
            sbSQL.Remove(sbSQL.Length - 1, 1);
            sbSQL.AppendFormat(" Where Account = '{0}'", mstrAccount);
            try
            {
                return objSQL.ExecSql(sbSQL.ToString());
            }
            catch (Exception objException)
            {
                LogError(objException);
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
            }
        }


        /// <summary>
        /// /// 功能：通过SQL命令来修改记录,支持事务处理,该方式是非优化方式
        /// /// 优点:1、支持事务处理.
        /// /// 缺点:1、不能处理字段中的单撇问题；
        /// ///      2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库;
        /// </summary>
        /// <returns>如果修改成功则返回TRUE，否则为FALSE</returns>
        public bool UpdateBySql(SqlConnection objSqlConnect, SqlTransaction objSqlTransaction)
        {
            StringBuilder sbSQL = new StringBuilder();
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = this.GetSpecSQLObj_Obj();
            sbSQL.AppendFormat("Update PERSON_q Set ");
            sbSQL.AppendFormat("SCH_ID = '{0}'", mstrSCH_ID); //SCH_ID
            sbSQL.AppendFormat(", BANK_ACC = '{0}'", mstrBANK_ACC); //银行帐号
            sbSQL.AppendFormat(", CARD_NO = '{0}'", mstrCARD_NO); //CARD_NO
            sbSQL.AppendFormat(", TEMP_CARD_NO = '{0}'", mstrTEMP_CARD_NO); //TEMP_CARD_NO
            sbSQL.AppendFormat(", TEMP_USING = {0}", mdblTEMP_USING); //TEMP_USING
            sbSQL.AppendFormat(", TEMP_DEPOSIT = {0}", mdblTEMP_DEPOSIT); //TEMP_DEPOSIT
            sbSQL.AppendFormat(", PASSWORD = '{0}'", mstrPASSWORD); //密码
            sbSQL.AppendFormat(", MONEY = {0}", mdblMONEY); //MONEY
            sbSQL.AppendFormat(", CARD_KIND = {0}", mdblCARD_KIND); //CARD_KIND
            sbSQL.AppendFormat(", CARD_STATE = {0}", mdblCARD_STATE); //CARD_STATE
            sbSQL.AppendFormat(", LAST_TIME = '{0}'", mdteLAST_TIME); //LAST_TIME
            sbSQL.AppendFormat(", USEFUL_LIMIT = '{0}'", mdteUSEFUL_LIMIT); //USEFUL_LIMIT
            sbSQL.AppendFormat(", RECYCLE_LIMIT = '{0}'", mdteRECYCLE_LIMIT); //RECYCLE_LIMIT
            sbSQL.AppendFormat(", NAME = '{0}'", mstrNAME); //名称
            sbSQL.AppendFormat(", SEX = {0}", mdblSEX); //性别
            sbSQL.AppendFormat(", IDEN_NO = {0}", mdblIDEN_NO); //IDEN_NO
            sbSQL.AppendFormat(", NATION_NO = {0}", mdblNATION_NO); //国籍编号
            sbSQL.AppendFormat(", POLITICS = '{0}'", mstrPOLITICS); //政治面貌
            sbSQL.AppendFormat(", DUTY = '{0}'", mstrDUTY); //DUTY
            sbSQL.AppendFormat(", BIRTH = '{0}'", mdteBIRTH); //入学时间
            sbSQL.AppendFormat(", PERSON_ID = '{0}'", mstrPERSON_ID); //身份证号码
            sbSQL.AppendFormat(", STUDENT_ID = '{0}'", mstrSTUDENT_ID); //学号
            sbSQL.AppendFormat(", SCHOOL_NO = '{0}'", mstrSCHOOL_NO); //SCHOOL_NO
            sbSQL.AppendFormat(", ACADEMY_NO = '{0}'", mstrACADEMY_NO); //学院编号
            sbSQL.AppendFormat(", DEP_NO = '{0}'", mstrDEP_NO); //专业编号
            sbSQL.AppendFormat(", CLASS_NO = '{0}'", mstrCLASS_NO); //班级编号
            sbSQL.AppendFormat(", GRADE = '{0}'", mstrGRADE); //年级
            sbSQL.AppendFormat(", IN_TIME = '{0}'", mdteIN_TIME); //IN_TIME
            sbSQL.AppendFormat(", WALLANCE = {0}", mdblWALLANCE); //WALLANCE
            sbSQL.AppendFormat(", ADDRESS = '{0}'", mstrADDRESS); //家庭住址
            sbSQL.AppendFormat(", PHONE = '{0}'", mstrPHONE); //电话
            sbSQL.AppendFormat(", POST_NO = '{0}'", mstrPOST_NO); //邮政编码
            sbSQL.AppendFormat(", POST_ADDRESS = '{0}'", mstrPOST_ADDRESS); //邮政地址
            sbSQL.AppendFormat(", MAIL = '{0}'", mstrMAIL); //信箱
            sbSQL.AppendFormat(", DESCR = '{0}'", mstrDESCR); //DESCR
            sbSQL.AppendFormat(", USER_ID = '{0}'", mstrUSER_ID); //用户ID
            sbSQL.AppendFormat(", OP_DATE = '{0}'", mdteOP_DATE); //OP_DATE
            sbSQL.AppendFormat(", ANNEX = '{0}'", mstrANNEX); //ANNEX
            sbSQL.AppendFormat(", UpdDate = '{0}'", mstrUpdDate); //UpdDate
            sbSQL.AppendFormat("Where Account = '{0}'", mstrAccount);
            try
            {
                return objSQL.ExecSql(sbSQL.ToString(), objSqlConnect, objSqlTransaction);
            }
            catch (Exception objException)
            {
                LogError(objException);
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
            }
        }


        /// <summary>
        /// /// 功能：通过SQL命令来修改记录,支持事务处理,该方式是优化方式
        /// /// 优点:1、能够处理字段中的单撇问题；
        /// ///      2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库;
        /// ///      3、支持事务处理.
        /// </summary>
        /// <returns>如果修改成功则返回TRUE，否则为FALSE</returns>
        public bool UpdateBySql2(SqlConnection objSqlConnect, SqlTransaction objSqlTransaction)
        {
            StringBuilder sbSQL = new StringBuilder();
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = this.GetSpecSQLObj_Obj();
            sbSQL.AppendFormat("Update PERSON_q Set ");
            if (IsUpdated("Account"))
            {
                mstrAccount = mstrAccount.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                sbSQL.AppendFormat(" Account = '{0}',", mstrAccount); //卡号
            }
            if (IsUpdated("SCH_ID"))
            {
                mstrSCH_ID = mstrSCH_ID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                sbSQL.AppendFormat(" SCH_ID = '{0}',", mstrSCH_ID); //SCH_ID
            }
            if (IsUpdated("BANK_ACC"))
            {
                mstrBANK_ACC = mstrBANK_ACC.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                sbSQL.AppendFormat(" BANK_ACC = '{0}',", mstrBANK_ACC); //银行帐号
            }
            if (IsUpdated("CARD_NO"))
            {
                mstrCARD_NO = mstrCARD_NO.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                sbSQL.AppendFormat(" CARD_NO = '{0}',", mstrCARD_NO); //CARD_NO
            }
            if (IsUpdated("TEMP_CARD_NO"))
            {
                mstrTEMP_CARD_NO = mstrTEMP_CARD_NO.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                sbSQL.AppendFormat(" TEMP_CARD_NO = '{0}',", mstrTEMP_CARD_NO); //TEMP_CARD_NO
            }
            if (IsUpdated("TEMP_USING"))
            {
                sbSQL.AppendFormat(" TEMP_USING = {0},", mdblTEMP_USING); //TEMP_USING
            }
            if (IsUpdated("TEMP_DEPOSIT"))
            {
                sbSQL.AppendFormat(" TEMP_DEPOSIT = {0},", mdblTEMP_DEPOSIT); //TEMP_DEPOSIT
            }
            if (IsUpdated("PASSWORD"))
            {
                mstrPASSWORD = mstrPASSWORD.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                sbSQL.AppendFormat(" PASSWORD = '{0}',", mstrPASSWORD); //密码
            }
            if (IsUpdated("MONEY"))
            {
                sbSQL.AppendFormat(" MONEY = {0},", mdblMONEY); //MONEY
            }
            if (IsUpdated("CARD_KIND"))
            {
                sbSQL.AppendFormat(" CARD_KIND = {0},", mdblCARD_KIND); //CARD_KIND
            }
            if (IsUpdated("CARD_STATE"))
            {
                sbSQL.AppendFormat(" CARD_STATE = {0},", mdblCARD_STATE); //CARD_STATE
            }
            if (IsUpdated("LAST_TIME"))
            {
                sbSQL.AppendFormat(" LAST_TIME = '{0}',", mdteLAST_TIME); //LAST_TIME
            }
            if (IsUpdated("USEFUL_LIMIT"))
            {
                sbSQL.AppendFormat(" USEFUL_LIMIT = '{0}',", mdteUSEFUL_LIMIT); //USEFUL_LIMIT
            }
            if (IsUpdated("RECYCLE_LIMIT"))
            {
                sbSQL.AppendFormat(" RECYCLE_LIMIT = '{0}',", mdteRECYCLE_LIMIT); //RECYCLE_LIMIT
            }
            if (IsUpdated("NAME"))
            {
                mstrNAME = mstrNAME.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                sbSQL.AppendFormat(" NAME = '{0}',", mstrNAME); //名称
            }
            if (IsUpdated("SEX"))
            {
                sbSQL.AppendFormat(" SEX = {0},", mdblSEX); //性别
            }
            if (IsUpdated("IDEN_NO"))
            {
                sbSQL.AppendFormat(" IDEN_NO = {0},", mdblIDEN_NO); //IDEN_NO
            }
            if (IsUpdated("NATION_NO"))
            {
                sbSQL.AppendFormat(" NATION_NO = {0},", mdblNATION_NO); //国籍编号
            }
            if (IsUpdated("POLITICS"))
            {
                mstrPOLITICS = mstrPOLITICS.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                sbSQL.AppendFormat(" POLITICS = '{0}',", mstrPOLITICS); //政治面貌
            }
            if (IsUpdated("DUTY"))
            {
                mstrDUTY = mstrDUTY.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                sbSQL.AppendFormat(" DUTY = '{0}',", mstrDUTY); //DUTY
            }
            if (IsUpdated("BIRTH"))
            {
                sbSQL.AppendFormat(" BIRTH = '{0}',", mdteBIRTH); //入学时间
            }
            if (IsUpdated("PERSON_ID"))
            {
                mstrPERSON_ID = mstrPERSON_ID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                sbSQL.AppendFormat(" PERSON_ID = '{0}',", mstrPERSON_ID); //身份证号码
            }
            if (IsUpdated("STUDENT_ID"))
            {
                mstrSTUDENT_ID = mstrSTUDENT_ID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                sbSQL.AppendFormat(" STUDENT_ID = '{0}',", mstrSTUDENT_ID); //学号
            }
            if (IsUpdated("SCHOOL_NO"))
            {
                mstrSCHOOL_NO = mstrSCHOOL_NO.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                sbSQL.AppendFormat(" SCHOOL_NO = '{0}',", mstrSCHOOL_NO); //SCHOOL_NO
            }
            if (IsUpdated("ACADEMY_NO"))
            {
                mstrACADEMY_NO = mstrACADEMY_NO.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                sbSQL.AppendFormat(" ACADEMY_NO = '{0}',", mstrACADEMY_NO); //学院编号
            }
            if (IsUpdated("DEP_NO"))
            {
                mstrDEP_NO = mstrDEP_NO.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                sbSQL.AppendFormat(" DEP_NO = '{0}',", mstrDEP_NO); //专业编号
            }
            if (IsUpdated("CLASS_NO"))
            {
                mstrCLASS_NO = mstrCLASS_NO.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                sbSQL.AppendFormat(" CLASS_NO = '{0}',", mstrCLASS_NO); //班级编号
            }
            if (IsUpdated("GRADE"))
            {
                mstrGRADE = mstrGRADE.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                sbSQL.AppendFormat(" GRADE = '{0}',", mstrGRADE); //年级
            }
            if (IsUpdated("IN_TIME"))
            {
                sbSQL.AppendFormat(" IN_TIME = '{0}',", mdteIN_TIME); //IN_TIME
            }
            if (IsUpdated("WALLANCE"))
            {
                sbSQL.AppendFormat(" WALLANCE = {0},", mdblWALLANCE); //WALLANCE
            }
            if (IsUpdated("ADDRESS"))
            {
                mstrADDRESS = mstrADDRESS.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                sbSQL.AppendFormat(" ADDRESS = '{0}',", mstrADDRESS); //家庭住址
            }
            if (IsUpdated("PHONE"))
            {
                mstrPHONE = mstrPHONE.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                sbSQL.AppendFormat(" PHONE = '{0}',", mstrPHONE); //电话
            }
            if (IsUpdated("POST_NO"))
            {
                mstrPOST_NO = mstrPOST_NO.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                sbSQL.AppendFormat(" POST_NO = '{0}',", mstrPOST_NO); //邮政编码
            }
            if (IsUpdated("POST_ADDRESS"))
            {
                mstrPOST_ADDRESS = mstrPOST_ADDRESS.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                sbSQL.AppendFormat(" POST_ADDRESS = '{0}',", mstrPOST_ADDRESS); //邮政地址
            }
            if (IsUpdated("MAIL"))
            {
                mstrMAIL = mstrMAIL.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                sbSQL.AppendFormat(" MAIL = '{0}',", mstrMAIL); //信箱
            }
            if (IsUpdated("DESCR"))
            {
                mstrDESCR = mstrDESCR.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                sbSQL.AppendFormat(" DESCR = '{0}',", mstrDESCR); //DESCR
            }
            if (IsUpdated("USER_ID"))
            {
                mstrUSER_ID = mstrUSER_ID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                sbSQL.AppendFormat(" USER_ID = '{0}',", mstrUSER_ID); //用户ID
            }
            if (IsUpdated("OP_DATE"))
            {
                sbSQL.AppendFormat(" OP_DATE = '{0}',", mdteOP_DATE); //OP_DATE
            }
            if (IsUpdated("ANNEX"))
            {
                mstrANNEX = mstrANNEX.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                sbSQL.AppendFormat(" ANNEX = '{0}',", mstrANNEX); //ANNEX
            }
            if (IsUpdated("UpdDate"))
            {
                mstrUpdDate = mstrUpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                sbSQL.AppendFormat(" UpdDate = '{0}',", mstrUpdDate); //UpdDate
            }
            sbSQL.Remove(sbSQL.Length - 1, 1);
            sbSQL.AppendFormat(" Where Account = '{0}'", mstrAccount);
            try
            {
                return objSQL.ExecSql(sbSQL.ToString(), objSqlConnect, objSqlTransaction);
            }
            catch (Exception objException)
            {
                LogError(objException);
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
            }
        }



        /// <summary>
        /// 功能：修改多条记录
        /// </summary>
        /// <param name="strCondition"></param>
        /// <returns></returns>
        public int UpdateMultiRec(string strCondition)
        {
            string strSQL;
            System.Data.SqlClient.SqlDataAdapter objDA;
            System.Data.DataSet objDS = new System.Data.DataSet();
            System.Data.SqlClient.SqlCommandBuilder objCB;
            //			System.Data.DataRow objRow ;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = this.GetSpecSQLObj_Obj();
            int intRecCount;
            if (strCondition == "")
            {
                return 0; //表示删除0条记录，实际上是不能该表的所有记录
            }
            strSQL = "Select * from PERSON_q where " + strCondition;
            objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
            objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
            objDA.Fill(objDS, "PERSON_q");
            if (objDS.Tables["PERSON_q"].Rows.Count == 0)
            {
                return 0;
            }
            intRecCount = objDS.Tables["PERSON_q"].Rows.Count;
            foreach (System.Data.DataRow objRow in objDS.Tables["PERSON_q"].Rows)
            {
                objRow["SCH_ID"] = mstrSCH_ID; //SCH_ID
                objRow["BANK_ACC"] = mstrBANK_ACC; //银行帐号
                objRow["CARD_NO"] = mstrCARD_NO; //CARD_NO
                objRow["TEMP_CARD_NO"] = mstrTEMP_CARD_NO; //TEMP_CARD_NO
                objRow["TEMP_USING"] = mdblTEMP_USING; //TEMP_USING
                objRow["TEMP_DEPOSIT"] = mdblTEMP_DEPOSIT; //TEMP_DEPOSIT
                objRow["PASSWORD"] = mstrPASSWORD; //密码
                objRow["MONEY"] = mdblMONEY; //MONEY
                objRow["CARD_KIND"] = mdblCARD_KIND; //CARD_KIND
                objRow["CARD_STATE"] = mdblCARD_STATE; //CARD_STATE
                objRow["LAST_TIME"] = mdteLAST_TIME; //LAST_TIME
                objRow["USEFUL_LIMIT"] = mdteUSEFUL_LIMIT; //USEFUL_LIMIT
                objRow["RECYCLE_LIMIT"] = mdteRECYCLE_LIMIT; //RECYCLE_LIMIT
                objRow["NAME"] = mstrNAME; //名称
                objRow["SEX"] = mdblSEX; //性别
                objRow["IDEN_NO"] = mdblIDEN_NO; //IDEN_NO
                objRow["NATION_NO"] = mdblNATION_NO; //国籍编号
                objRow["POLITICS"] = mstrPOLITICS; //政治面貌
                objRow["DUTY"] = mstrDUTY; //DUTY
                objRow["BIRTH"] = mdteBIRTH; //入学时间
                objRow["PERSON_ID"] = mstrPERSON_ID; //身份证号码
                objRow["STUDENT_ID"] = mstrSTUDENT_ID; //学号
                objRow["SCHOOL_NO"] = mstrSCHOOL_NO; //SCHOOL_NO
                objRow["ACADEMY_NO"] = mstrACADEMY_NO; //学院编号
                objRow["DEP_NO"] = mstrDEP_NO; //专业编号
                objRow["CLASS_NO"] = mstrCLASS_NO; //班级编号
                objRow["GRADE"] = mstrGRADE; //年级
                objRow["IN_TIME"] = mdteIN_TIME; //IN_TIME
                objRow["WALLANCE"] = mdblWALLANCE; //WALLANCE
                objRow["ADDRESS"] = mstrADDRESS; //家庭住址
                objRow["PHONE"] = mstrPHONE; //电话
                objRow["POST_NO"] = mstrPOST_NO; //邮政编码
                objRow["POST_ADDRESS"] = mstrPOST_ADDRESS; //邮政地址
                objRow["MAIL"] = mstrMAIL; //信箱
                objRow["DESCR"] = mstrDESCR; //DESCR
                objRow["USER_ID"] = mstrUSER_ID; //用户ID
                objRow["OP_DATE"] = mdteOP_DATE; //OP_DATE
                objRow["ANNEX"] = mstrANNEX; //ANNEX
                objRow["UpdDate"] = mstrUpdDate; //UpdDate
            }
            try
            {
                objDA.Update(objDS, "PERSON_q");
            }
            catch (Exception objException)
            {
                LogError(objException);
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
                objDA = null;
                objDS = null;
                objCB = null;
            }
            return intRecCount;
        }


        /// <summary>
        /// 功能：把当前对象复制到新的对象
        /// </summary>
        /// <param name="objPERSON_q">新对象,目标对象</param>
        public void CopyTo(clsPERSON_q objPERSON_q)
        {
            objPERSON_q.Account = mstrAccount; //卡号
            objPERSON_q.SCH_ID = mstrSCH_ID; //SCH_ID
            objPERSON_q.BANK_ACC = mstrBANK_ACC; //银行帐号
            objPERSON_q.CARD_NO = mstrCARD_NO; //CARD_NO
            objPERSON_q.TEMP_CARD_NO = mstrTEMP_CARD_NO; //TEMP_CARD_NO
            objPERSON_q.TEMP_USING = mdblTEMP_USING; //TEMP_USING
            objPERSON_q.TEMP_DEPOSIT = mdblTEMP_DEPOSIT; //TEMP_DEPOSIT
            objPERSON_q.PASSWORD = mstrPASSWORD; //密码
            objPERSON_q.MONEY = mdblMONEY; //MONEY
            objPERSON_q.CARD_KIND = mdblCARD_KIND; //CARD_KIND
            objPERSON_q.CARD_STATE = mdblCARD_STATE; //CARD_STATE
            objPERSON_q.LAST_TIME = mdteLAST_TIME; //LAST_TIME
            objPERSON_q.USEFUL_LIMIT = mdteUSEFUL_LIMIT; //USEFUL_LIMIT
            objPERSON_q.RECYCLE_LIMIT = mdteRECYCLE_LIMIT; //RECYCLE_LIMIT
            objPERSON_q.NAME = mstrNAME; //名称
            objPERSON_q.SEX = mdblSEX; //性别
            objPERSON_q.IDEN_NO = mdblIDEN_NO; //IDEN_NO
            objPERSON_q.NATION_NO = mdblNATION_NO; //国籍编号
            objPERSON_q.POLITICS = mstrPOLITICS; //政治面貌
            objPERSON_q.DUTY = mstrDUTY; //DUTY
            objPERSON_q.BIRTH = mdteBIRTH; //入学时间
            objPERSON_q.PERSON_ID = mstrPERSON_ID; //身份证号码
            objPERSON_q.STUDENT_ID = mstrSTUDENT_ID; //学号
            objPERSON_q.SCHOOL_NO = mstrSCHOOL_NO; //SCHOOL_NO
            objPERSON_q.ACADEMY_NO = mstrACADEMY_NO; //学院编号
            objPERSON_q.DEP_NO = mstrDEP_NO; //专业编号
            objPERSON_q.CLASS_NO = mstrCLASS_NO; //班级编号
            objPERSON_q.GRADE = mstrGRADE; //年级
            objPERSON_q.IN_TIME = mdteIN_TIME; //IN_TIME
            objPERSON_q.WALLANCE = mdblWALLANCE; //WALLANCE
            objPERSON_q.ADDRESS = mstrADDRESS; //家庭住址
            objPERSON_q.PHONE = mstrPHONE; //电话
            objPERSON_q.POST_NO = mstrPOST_NO; //邮政编码
            objPERSON_q.POST_ADDRESS = mstrPOST_ADDRESS; //邮政地址
            objPERSON_q.MAIL = mstrMAIL; //信箱
            objPERSON_q.DESCR = mstrDESCR; //DESCR
            objPERSON_q.USER_ID = mstrUSER_ID; //用户ID
            objPERSON_q.OP_DATE = mdteOP_DATE; //OP_DATE
            objPERSON_q.ANNEX = mstrANNEX; //ANNEX
            objPERSON_q.UpdDate = mstrUpdDate; //UpdDate
        }

        /// <summary>
        /// 功能：把源对象复制到目标对象
        /// </summary>
        /// <param name="objPERSON_qS">源对象</param>
        /// <param name="objPERSON_qT">目标对象</param>
        public void CopyTo(clsPERSON_q objPERSON_qS, clsPERSON_q objPERSON_qT)
        {
            objPERSON_qT.Account = objPERSON_qS.Account; //卡号
            objPERSON_qT.SCH_ID = objPERSON_qS.SCH_ID; //SCH_ID
            objPERSON_qT.BANK_ACC = objPERSON_qS.BANK_ACC; //银行帐号
            objPERSON_qT.CARD_NO = objPERSON_qS.CARD_NO; //CARD_NO
            objPERSON_qT.TEMP_CARD_NO = objPERSON_qS.TEMP_CARD_NO; //TEMP_CARD_NO
            objPERSON_qT.TEMP_USING = objPERSON_qS.TEMP_USING; //TEMP_USING
            objPERSON_qT.TEMP_DEPOSIT = objPERSON_qS.TEMP_DEPOSIT; //TEMP_DEPOSIT
            objPERSON_qT.PASSWORD = objPERSON_qS.PASSWORD; //密码
            objPERSON_qT.MONEY = objPERSON_qS.MONEY; //MONEY
            objPERSON_qT.CARD_KIND = objPERSON_qS.CARD_KIND; //CARD_KIND
            objPERSON_qT.CARD_STATE = objPERSON_qS.CARD_STATE; //CARD_STATE
            objPERSON_qT.LAST_TIME = objPERSON_qS.LAST_TIME; //LAST_TIME
            objPERSON_qT.USEFUL_LIMIT = objPERSON_qS.USEFUL_LIMIT; //USEFUL_LIMIT
            objPERSON_qT.RECYCLE_LIMIT = objPERSON_qS.RECYCLE_LIMIT; //RECYCLE_LIMIT
            objPERSON_qT.NAME = objPERSON_qS.NAME; //名称
            objPERSON_qT.SEX = objPERSON_qS.SEX; //性别
            objPERSON_qT.IDEN_NO = objPERSON_qS.IDEN_NO; //IDEN_NO
            objPERSON_qT.NATION_NO = objPERSON_qS.NATION_NO; //国籍编号
            objPERSON_qT.POLITICS = objPERSON_qS.POLITICS; //政治面貌
            objPERSON_qT.DUTY = objPERSON_qS.DUTY; //DUTY
            objPERSON_qT.BIRTH = objPERSON_qS.BIRTH; //入学时间
            objPERSON_qT.PERSON_ID = objPERSON_qS.PERSON_ID; //身份证号码
            objPERSON_qT.STUDENT_ID = objPERSON_qS.STUDENT_ID; //学号
            objPERSON_qT.SCHOOL_NO = objPERSON_qS.SCHOOL_NO; //SCHOOL_NO
            objPERSON_qT.ACADEMY_NO = objPERSON_qS.ACADEMY_NO; //学院编号
            objPERSON_qT.DEP_NO = objPERSON_qS.DEP_NO; //专业编号
            objPERSON_qT.CLASS_NO = objPERSON_qS.CLASS_NO; //班级编号
            objPERSON_qT.GRADE = objPERSON_qS.GRADE; //年级
            objPERSON_qT.IN_TIME = objPERSON_qS.IN_TIME; //IN_TIME
            objPERSON_qT.WALLANCE = objPERSON_qS.WALLANCE; //WALLANCE
            objPERSON_qT.ADDRESS = objPERSON_qS.ADDRESS; //家庭住址
            objPERSON_qT.PHONE = objPERSON_qS.PHONE; //电话
            objPERSON_qT.POST_NO = objPERSON_qS.POST_NO; //邮政编码
            objPERSON_qT.POST_ADDRESS = objPERSON_qS.POST_ADDRESS; //邮政地址
            objPERSON_qT.MAIL = objPERSON_qS.MAIL; //信箱
            objPERSON_qT.DESCR = objPERSON_qS.DESCR; //DESCR
            objPERSON_qT.USER_ID = objPERSON_qS.USER_ID; //用户ID
            objPERSON_qT.OP_DATE = objPERSON_qS.OP_DATE; //OP_DATE
            objPERSON_qT.ANNEX = objPERSON_qS.ANNEX; //ANNEX
            objPERSON_qT.UpdDate = objPERSON_qS.UpdDate; //UpdDate
        }

        /// <summary>
        /// 同步记录：把记录同步到另一个服务器中
        /// </summary>
        /// <param name="strConnectStringT">代表目标服务器的连接串</param>
        /// <param name="objPERSON_q">需要同步的对象记录</param>
        /// <returns>已经同步的记录数</returns>
        public static int SynchRecordToServerB(string strConnectStringT, clsPERSON_q objPERSON_q)
        {
            objPERSON_q.ConnectString_Obj = strConnectStringT;
            //检查在表中是否有<IsArchive>字段
            if (objPERSON_q["IsArchive"] != null)
            {
                bool bolIsArchive = bool.Parse(objPERSON_q["IsArchive"].ToString());
                //如果已经归档,就不需要再归档
                if (bolIsArchive == true)
                {
                    StringBuilder sbMsg = new StringBuilder();
                    sbMsg.AppendFormat("关键字:{0}的记录,在当前服务器已经归档,不需要再同步.",
                    objPERSON_q.Account);
                    throw new Exception(sbMsg.ToString());
                }
            }
            //检查在目标表中是否存在
            if (objPERSON_q.IsExist() == false)
            {
                //如果不存在,就添加
                objPERSON_q.AddNewRecordBySQL2();
                return 1;
            }
            else
            {
                clsPERSON_q objPERSON_qT = null;
                //如果存在,就修改.
                //检查是否有<UptDate>字段
                if (objPERSON_q["UptDate"] != null)
                {
                    string strUptDate = objPERSON_q["UptDate"].ToString();
                    //获取目标服务器中的同关键字的记录
                    objPERSON_qT = new clsPERSON_q();
                    objPERSON_qT.Account = objPERSON_q.Account;
                    objPERSON_qT.ConnectString_Obj = strConnectStringT;
                    objPERSON_qT.GetPERSON_q();
                    string strUptDateT = objPERSON_qT["UptDate"].ToString();
                    if (strUptDateT.CompareTo(strUptDate) > 0)
                    {
                        StringBuilder sbMsg = new StringBuilder();
                        sbMsg.AppendFormat("关键字:{0}的记录,在当前服务器比目录服务器旧,不能同步.当前记录的修改时间:{1},而目标记录的修改时间:{2}.",
                        objPERSON_q.Account,
                        strUptDate,
                        strUptDateT);
                        throw new Exception(sbMsg.ToString());
                    }
                }
                objPERSON_q.CopyTo(objPERSON_qT);
                objPERSON_qT.UpdateBySql2();
                return 1;
            }
        }

        /// <summary>
        /// 功能：删除当前对象所指的记录
        /// </summary>
        /// <returns>如果删除成功则返回TRUE，否则为FALSE</returns>
        public bool DelRecord()
        {
            string strSQL = "";
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = this.GetSpecSQLObj_Obj();
            //删除PERSON_q本表中与当前对象有关的记录
            strSQL = strSQL + "Delete from PERSON_q where Account=" + "'" + mstrAccount + "'";
            return objSQL.ExecSql(strSQL);
        }


        /// <summary>
        /// 功能：删除当前对象所指的记录,通过存储过程来实现
        /// </summary>
        /// <returns>如果删除成功则返回TRUE，否则为FALSE</returns>
        public bool DelRecordBySP()
        {
            //通过存储过程来
            //直接使用
            if (mintErrNo != 0)
            {
                //MsgBox(mstrErrMsg(mintErrNo))
                return false;
            }
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = this.GetSpecSQLObj_Obj();
            objSQL.SPConfigXMLFile = clsSysPara.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(mstrAccount);
            objSQL.ExecSP("p_Del_PERSON_q", values);
            return true;
        }

        /// <summary>
        /// 功能：当前对象所指的记录
        /// </summary>
        /// <param name="objSqlConnect">Sql连接对象</param>
        /// <param name="objSqlTransaction">Sql事务对象</param>
        /// <returns>返回删除的记录0。</returns>
        public bool DelRecord(SqlConnection objSqlConnect, SqlTransaction objSqlTransaction)
        {
            string strSQL = "";
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = this.GetSpecSQLObj_Obj();
            //删除PERSON_q本表中与当前对象有关的记录
            strSQL = strSQL + "Delete from PERSON_q where Account=" + "'" + mstrAccount + "'";
            return objSQL.ExecSql(strSQL, objSqlConnect, objSqlTransaction);
        }


        /// <summary>
        /// 功能：同时删除多条记录
        /// </summary>
        /// <param name="lstKey">给定的关键字值列表</param>
        /// <returns>返回删除是否成功?</returns>
        public static bool DelPERSON_q(ArrayList lstKey)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsPERSON_q.GetSpecSQLObj();
            string strSQL;
            string strKeyList;
            if (lstKey.Count == 0) return true;
            strKeyList = "";
            for (int i = 0; i < lstKey.Count; i++)
            {
                if (i == 0) strKeyList = strKeyList + "'" + lstKey[i].ToString() + "'";
                else strKeyList += "," + "'" + lstKey[i].ToString() + "'";
            }
            strSQL = "";
            //删除PERSON_q本表中与当前对象有关的记录
            strSQL = strSQL + "Delete from PERSON_q where Account in (" + strKeyList + ")";
            return objSQL.ExecSql(strSQL);
        }

        /// <summary>
        /// 功能：同时删除多条记录
        /// </summary>
        /// <param name="lstKey">给定的关键字值列表</param>
        /// <param name="objSqlConnect">Sql连接对象</param>
        /// <param name="objSqlTransaction">Sql事务对象</param>
        /// <returns>返回删除是否成功?。</returns>
        public static bool DelPERSON_q(ArrayList lstKey, SqlConnection objSqlConnect, SqlTransaction objSqlTransaction)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsPERSON_q.GetSpecSQLObj();
            string strSQL;
            string strKeyList;
            if (lstKey.Count == 0) return true;
            strKeyList = "";
            for (int i = 0; i < lstKey.Count; i++)
            {
                if (i == 0) strKeyList = strKeyList + "'" + lstKey[i].ToString() + "'";
                else strKeyList += "," + "'" + lstKey[i].ToString() + "'";
            }
            strSQL = "";
            //删除PERSON_q本表中与当前对象有关的记录
            strSQL = strSQL + "Delete from PERSON_q where Account in (" + strKeyList + ")";
            return objSQL.ExecSql(strSQL, objSqlConnect, objSqlTransaction);
        }

        /// <summary>
        /// 功能：删除关键字所指定的记录
        /// </summary>
        /// <param name="strAccount">给定的关键字值</param>
        /// <returns>如果删除成功则返回TRUE，否则为FALSE</returns>
        public static bool DelRecord(string strAccount)
        {
            //删除单条记录
            string strSQL = "";
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsPERSON_q.GetSpecSQLObj();
            //删除PERSON_q本表中与当前对象有关的记录
            strSQL = strSQL + "Delete from PERSON_q where Account=" + "'" + strAccount + "'";
            return objSQL.ExecSql(strSQL);
        }

        /// <summary>
        /// 功能：当前对象所指的记录
        /// </summary>
        /// <param name="strAccount">给定的关键字值</param>
        /// <param name="objSqlConnect">Sql连接对象</param>
        /// <param name="objSqlTransaction">Sql事务对象</param>
        /// <returns>返回删除的记录0。</returns>
        public static bool DelRecord(string strAccount, SqlConnection objSqlConnect, SqlTransaction objSqlTransaction)
        {
            //删除单条记录
            string strSQL = "";
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsPERSON_q.GetSpecSQLObj();
            //删除PERSON_q本表中与当前对象有关的记录
            strSQL = strSQL + "Delete from PERSON_q where Account=" + "'" + strAccount + "'";
            return objSQL.ExecSql(strSQL, objSqlConnect, objSqlTransaction);
        }


        /// <summary>
        /// 功能：删除多条记录，带条件的删除
        /// </summary>
        /// <param name="strCondition">需要删除的记录条件</param>
        /// <returns>返回删除的记录0。</returns>
        public static int DelPERSON_q(string strCondition)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsPERSON_q.GetSpecSQLObj();
            string strSQL;
            if (strCondition == "")
            {
                return 0;	//表示删除0条记录，实际上是不能该表的所有记录
            }
            else
            {
                strSQL = "Delete from PERSON_q where " + strCondition;
            }
            int intRecoCount = objSQL.ExecSql2(strSQL);
            return intRecoCount;
        }



        /// <summary>
        /// 功能：删除多条记录，带条件的删除
        /// </summary>
        /// <param name="strCondition">需要删除的记录条件</param>
        /// <param name="objSqlConnect">Sql连接对象</param>
        /// <param name="objSqlTransaction">Sql事务对象</param>
        /// <returns>返回删除的记录0。</returns>
        public static int DelPERSON_q(string strCondition, SqlConnection objSqlConnect, SqlTransaction objSqlTransaction)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsPERSON_q.GetSpecSQLObj();
            string strSQL;
            if (strCondition == "")
            {
                return 0;	//表示删除0条记录，实际上是不能该表的所有记录
            }
            else
            {
                strSQL = "Delete from PERSON_q where " + strCondition;
            }
            int intRecoCount = objSQL.ExecSql2(strSQL, objSqlConnect, objSqlTransaction);
            return intRecoCount;
        }


        /// <summary>
        /// 获取当前关键字的记录对象,用对象的形式表示.
        /// </summary>
        /// <returns>是否成功</returns>
        public bool GetPERSON_q()
        {
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = this.GetSpecSQLObj_Obj();
            strSQL = "Select * from PERSON_q where Account=" + "'" + mstrAccount + "'";
            objDT = objSQL.GetDataTable(strSQL);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return false;
            }
            mstrAccount = objDT.Rows[0]["Account"].ToString().Trim(); //卡号
            mstrSCH_ID = objDT.Rows[0]["SCH_ID"].ToString().Trim(); //SCH_ID
            mstrBANK_ACC = objDT.Rows[0]["BANK_ACC"].ToString().Trim(); //银行帐号
            mstrCARD_NO = objDT.Rows[0]["CARD_NO"].ToString().Trim(); //CARD_NO
            mstrTEMP_CARD_NO = objDT.Rows[0]["TEMP_CARD_NO"].ToString().Trim(); //TEMP_CARD_NO
            mdblTEMP_USING = TransNullToDouble(objDT.Rows[0]["TEMP_USING"].ToString().Trim()); //TEMP_USING
            mdblTEMP_DEPOSIT = TransNullToDouble(objDT.Rows[0]["TEMP_DEPOSIT"].ToString().Trim()); //TEMP_DEPOSIT
            mstrPASSWORD = objDT.Rows[0]["PASSWORD"].ToString().Trim(); //密码
            mdblMONEY = TransNullToDouble(objDT.Rows[0]["MONEY"].ToString().Trim()); //MONEY
            mdblCARD_KIND = TransNullToDouble(objDT.Rows[0]["CARD_KIND"].ToString().Trim()); //CARD_KIND
            mdblCARD_STATE = TransNullToDouble(objDT.Rows[0]["CARD_STATE"].ToString().Trim()); //CARD_STATE
            mdteLAST_TIME = TransNullToDate(objDT.Rows[0]["LAST_TIME"].ToString().Trim()); //LAST_TIME
            mdteUSEFUL_LIMIT = TransNullToDate(objDT.Rows[0]["USEFUL_LIMIT"].ToString().Trim()); //USEFUL_LIMIT
            mdteRECYCLE_LIMIT = TransNullToDate(objDT.Rows[0]["RECYCLE_LIMIT"].ToString().Trim()); //RECYCLE_LIMIT
            mstrNAME = objDT.Rows[0]["NAME"].ToString().Trim(); //名称
            mdblSEX = TransNullToDouble(objDT.Rows[0]["SEX"].ToString().Trim()); //性别
            mdblIDEN_NO = TransNullToDouble(objDT.Rows[0]["IDEN_NO"].ToString().Trim()); //IDEN_NO
            mdblNATION_NO = TransNullToDouble(objDT.Rows[0]["NATION_NO"].ToString().Trim()); //国籍编号
            mstrPOLITICS = objDT.Rows[0]["POLITICS"].ToString().Trim(); //政治面貌
            mstrDUTY = objDT.Rows[0]["DUTY"].ToString().Trim(); //DUTY
            mdteBIRTH = TransNullToDate(objDT.Rows[0]["BIRTH"].ToString().Trim()); //入学时间
            mstrPERSON_ID = objDT.Rows[0]["PERSON_ID"].ToString().Trim(); //身份证号码
            mstrSTUDENT_ID = objDT.Rows[0]["STUDENT_ID"].ToString().Trim(); //学号
            mstrSCHOOL_NO = objDT.Rows[0]["SCHOOL_NO"].ToString().Trim(); //SCHOOL_NO
            mstrACADEMY_NO = objDT.Rows[0]["ACADEMY_NO"].ToString().Trim(); //学院编号
            mstrDEP_NO = objDT.Rows[0]["DEP_NO"].ToString().Trim(); //专业编号
            mstrCLASS_NO = objDT.Rows[0]["CLASS_NO"].ToString().Trim(); //班级编号
            mstrGRADE = objDT.Rows[0]["GRADE"].ToString().Trim(); //年级
            mdteIN_TIME = TransNullToDate(objDT.Rows[0]["IN_TIME"].ToString().Trim()); //IN_TIME
            mdblWALLANCE = TransNullToDouble(objDT.Rows[0]["WALLANCE"].ToString().Trim()); //WALLANCE
            mstrADDRESS = objDT.Rows[0]["ADDRESS"].ToString().Trim(); //家庭住址
            mstrPHONE = objDT.Rows[0]["PHONE"].ToString().Trim(); //电话
            mstrPOST_NO = objDT.Rows[0]["POST_NO"].ToString().Trim(); //邮政编码
            mstrPOST_ADDRESS = objDT.Rows[0]["POST_ADDRESS"].ToString().Trim(); //邮政地址
            mstrMAIL = objDT.Rows[0]["MAIL"].ToString().Trim(); //信箱
            mstrDESCR = objDT.Rows[0]["DESCR"].ToString().Trim(); //DESCR
            mstrUSER_ID = objDT.Rows[0]["USER_ID"].ToString().Trim(); //用户ID
            mdteOP_DATE = TransNullToDate(objDT.Rows[0]["OP_DATE"].ToString().Trim()); //OP_DATE
            mstrANNEX = objDT.Rows[0]["ANNEX"].ToString().Trim(); //ANNEX
            mstrUpdDate = objDT.Rows[0]["UpdDate"].ToString().Trim(); //UpdDate
            objDT = null;
            return true;
        }

        /// <summary>
        /// 把DataRow转换成记录对象.
        /// </summary>
        /// <param name="objRow">所给的DataRow</param>
        /// <returns>记录对象</returns>
        public clsPERSON_q GetPERSON_qObjByDataRow(DataRow objRow)
        {
            if (objRow == null)
            {
                return null;
            }
            clsPERSON_q objPERSON_q = new clsPERSON_q();
            objPERSON_q.Account = objRow["Account"].ToString().Trim(); //卡号
            objPERSON_q.SCH_ID = objRow["SCH_ID"].ToString().Trim(); //SCH_ID
            objPERSON_q.BANK_ACC = objRow["BANK_ACC"].ToString().Trim(); //银行帐号
            objPERSON_q.CARD_NO = objRow["CARD_NO"].ToString().Trim(); //CARD_NO
            objPERSON_q.TEMP_CARD_NO = objRow["TEMP_CARD_NO"].ToString().Trim(); //TEMP_CARD_NO
            objPERSON_q.TEMP_USING = TransNullToDouble(objRow["TEMP_USING"].ToString().Trim()); //TEMP_USING
            objPERSON_q.TEMP_DEPOSIT = TransNullToDouble(objRow["TEMP_DEPOSIT"].ToString().Trim()); //TEMP_DEPOSIT
            objPERSON_q.PASSWORD = objRow["PASSWORD"].ToString().Trim(); //密码
            objPERSON_q.MONEY = TransNullToDouble(objRow["MONEY"].ToString().Trim()); //MONEY
            objPERSON_q.CARD_KIND = TransNullToDouble(objRow["CARD_KIND"].ToString().Trim()); //CARD_KIND
            objPERSON_q.CARD_STATE = TransNullToDouble(objRow["CARD_STATE"].ToString().Trim()); //CARD_STATE
            objPERSON_q.LAST_TIME = TransNullToDate(objRow["LAST_TIME"].ToString().Trim()); //LAST_TIME
            objPERSON_q.USEFUL_LIMIT = TransNullToDate(objRow["USEFUL_LIMIT"].ToString().Trim()); //USEFUL_LIMIT
            objPERSON_q.RECYCLE_LIMIT = TransNullToDate(objRow["RECYCLE_LIMIT"].ToString().Trim()); //RECYCLE_LIMIT
            objPERSON_q.NAME = objRow["NAME"].ToString().Trim(); //名称
            objPERSON_q.SEX = TransNullToDouble(objRow["SEX"].ToString().Trim()); //性别
            objPERSON_q.IDEN_NO = TransNullToDouble(objRow["IDEN_NO"].ToString().Trim()); //IDEN_NO
            objPERSON_q.NATION_NO = TransNullToDouble(objRow["NATION_NO"].ToString().Trim()); //国籍编号
            objPERSON_q.POLITICS = objRow["POLITICS"].ToString().Trim(); //政治面貌
            objPERSON_q.DUTY = objRow["DUTY"].ToString().Trim(); //DUTY
            objPERSON_q.BIRTH = TransNullToDate(objRow["BIRTH"].ToString().Trim()); //入学时间
            objPERSON_q.PERSON_ID = objRow["PERSON_ID"].ToString().Trim(); //身份证号码
            objPERSON_q.STUDENT_ID = objRow["STUDENT_ID"].ToString().Trim(); //学号
            objPERSON_q.SCHOOL_NO = objRow["SCHOOL_NO"].ToString().Trim(); //SCHOOL_NO
            objPERSON_q.ACADEMY_NO = objRow["ACADEMY_NO"].ToString().Trim(); //学院编号
            objPERSON_q.DEP_NO = objRow["DEP_NO"].ToString().Trim(); //专业编号
            objPERSON_q.CLASS_NO = objRow["CLASS_NO"].ToString().Trim(); //班级编号
            objPERSON_q.GRADE = objRow["GRADE"].ToString().Trim(); //年级
            objPERSON_q.IN_TIME = TransNullToDate(objRow["IN_TIME"].ToString().Trim()); //IN_TIME
            objPERSON_q.WALLANCE = TransNullToDouble(objRow["WALLANCE"].ToString().Trim()); //WALLANCE
            objPERSON_q.ADDRESS = objRow["ADDRESS"].ToString().Trim(); //家庭住址
            objPERSON_q.PHONE = objRow["PHONE"].ToString().Trim(); //电话
            objPERSON_q.POST_NO = objRow["POST_NO"].ToString().Trim(); //邮政编码
            objPERSON_q.POST_ADDRESS = objRow["POST_ADDRESS"].ToString().Trim(); //邮政地址
            objPERSON_q.MAIL = objRow["MAIL"].ToString().Trim(); //信箱
            objPERSON_q.DESCR = objRow["DESCR"].ToString().Trim(); //DESCR
            objPERSON_q.USER_ID = objRow["USER_ID"].ToString().Trim(); //用户ID
            objPERSON_q.OP_DATE = TransNullToDate(objRow["OP_DATE"].ToString().Trim()); //OP_DATE
            objPERSON_q.ANNEX = objRow["ANNEX"].ToString().Trim(); //ANNEX
            objPERSON_q.UpdDate = objRow["UpdDate"].ToString().Trim(); //UpdDate
            objPERSON_q.ClearUpdateState();//清除修改状态,即清除脏字段信息
            return objPERSON_q;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用对象的形式表示,用存储过程来实现.
        /// </summary>
        /// <returns>是否成功</returns>
        public bool GetPERSON_qOneBySP()
        {
            System.Data.DataTable objDT = null;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = this.GetSpecSQLObj_Obj();
            objSQL.SPConfigXMLFile = clsSysPara.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(mstrAccount);
            objDT = objSQL.ExecSpReturnDT("p_Get_PERSON_q", values);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return false;
            }
            mstrAccount = objDT.Rows[0]["Account"].ToString().Trim(); //卡号
            mstrSCH_ID = objDT.Rows[0]["SCH_ID"].ToString().Trim(); //SCH_ID
            mstrBANK_ACC = objDT.Rows[0]["BANK_ACC"].ToString().Trim(); //银行帐号
            mstrCARD_NO = objDT.Rows[0]["CARD_NO"].ToString().Trim(); //CARD_NO
            mstrTEMP_CARD_NO = objDT.Rows[0]["TEMP_CARD_NO"].ToString().Trim(); //TEMP_CARD_NO
            mdblTEMP_USING = TransNullToDouble(objDT.Rows[0]["TEMP_USING"].ToString().Trim()); //TEMP_USING
            mdblTEMP_DEPOSIT = TransNullToDouble(objDT.Rows[0]["TEMP_DEPOSIT"].ToString().Trim()); //TEMP_DEPOSIT
            mstrPASSWORD = objDT.Rows[0]["PASSWORD"].ToString().Trim(); //密码
            mdblMONEY = TransNullToDouble(objDT.Rows[0]["MONEY"].ToString().Trim()); //MONEY
            mdblCARD_KIND = TransNullToDouble(objDT.Rows[0]["CARD_KIND"].ToString().Trim()); //CARD_KIND
            mdblCARD_STATE = TransNullToDouble(objDT.Rows[0]["CARD_STATE"].ToString().Trim()); //CARD_STATE
            mdteLAST_TIME = TransNullToDate(objDT.Rows[0]["LAST_TIME"].ToString().Trim()); //LAST_TIME
            mdteUSEFUL_LIMIT = TransNullToDate(objDT.Rows[0]["USEFUL_LIMIT"].ToString().Trim()); //USEFUL_LIMIT
            mdteRECYCLE_LIMIT = TransNullToDate(objDT.Rows[0]["RECYCLE_LIMIT"].ToString().Trim()); //RECYCLE_LIMIT
            mstrNAME = objDT.Rows[0]["NAME"].ToString().Trim(); //名称
            mdblSEX = TransNullToDouble(objDT.Rows[0]["SEX"].ToString().Trim()); //性别
            mdblIDEN_NO = TransNullToDouble(objDT.Rows[0]["IDEN_NO"].ToString().Trim()); //IDEN_NO
            mdblNATION_NO = TransNullToDouble(objDT.Rows[0]["NATION_NO"].ToString().Trim()); //国籍编号
            mstrPOLITICS = objDT.Rows[0]["POLITICS"].ToString().Trim(); //政治面貌
            mstrDUTY = objDT.Rows[0]["DUTY"].ToString().Trim(); //DUTY
            mdteBIRTH = TransNullToDate(objDT.Rows[0]["BIRTH"].ToString().Trim()); //入学时间
            mstrPERSON_ID = objDT.Rows[0]["PERSON_ID"].ToString().Trim(); //身份证号码
            mstrSTUDENT_ID = objDT.Rows[0]["STUDENT_ID"].ToString().Trim(); //学号
            mstrSCHOOL_NO = objDT.Rows[0]["SCHOOL_NO"].ToString().Trim(); //SCHOOL_NO
            mstrACADEMY_NO = objDT.Rows[0]["ACADEMY_NO"].ToString().Trim(); //学院编号
            mstrDEP_NO = objDT.Rows[0]["DEP_NO"].ToString().Trim(); //专业编号
            mstrCLASS_NO = objDT.Rows[0]["CLASS_NO"].ToString().Trim(); //班级编号
            mstrGRADE = objDT.Rows[0]["GRADE"].ToString().Trim(); //年级
            mdteIN_TIME = TransNullToDate(objDT.Rows[0]["IN_TIME"].ToString().Trim()); //IN_TIME
            mdblWALLANCE = TransNullToDouble(objDT.Rows[0]["WALLANCE"].ToString().Trim()); //WALLANCE
            mstrADDRESS = objDT.Rows[0]["ADDRESS"].ToString().Trim(); //家庭住址
            mstrPHONE = objDT.Rows[0]["PHONE"].ToString().Trim(); //电话
            mstrPOST_NO = objDT.Rows[0]["POST_NO"].ToString().Trim(); //邮政编码
            mstrPOST_ADDRESS = objDT.Rows[0]["POST_ADDRESS"].ToString().Trim(); //邮政地址
            mstrMAIL = objDT.Rows[0]["MAIL"].ToString().Trim(); //信箱
            mstrDESCR = objDT.Rows[0]["DESCR"].ToString().Trim(); //DESCR
            mstrUSER_ID = objDT.Rows[0]["USER_ID"].ToString().Trim(); //用户ID
            mdteOP_DATE = TransNullToDate(objDT.Rows[0]["OP_DATE"].ToString().Trim()); //OP_DATE
            mstrANNEX = objDT.Rows[0]["ANNEX"].ToString().Trim(); //ANNEX
            mstrUpdDate = objDT.Rows[0]["UpdDate"].ToString().Trim(); //UpdDate
            objDT = null;
            return true;
        }

        /// <summary>
        /// 获取满足条件的所有记录,用DataTable的形式表示
        /// </summary>
        /// <param name="strCondition">条件串</param>
        /// <returns>满足条件的所有记录</returns>
        public static System.Data.DataTable GetPERSON_q(string strCondition)
        {
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsPERSON_q.GetSpecSQLObj();
            strSQL = "Select * from PERSON_q where " + strCondition;
            objDT = objSQL.GetDataTable(strSQL);
            return objDT;
        }

        /// <summary>
        /// 获取满足条件的所有记录,用DataTable的形式表示,用存储过程来实现
        /// </summary>
        /// <param name="strCondition">条件串</param>
        /// <returns>满足条件的所有记录</returns>
        public static System.Data.DataTable GetPERSON_qByCondBySP(string strCondition)
        {
            System.Data.DataTable objDT = null;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsPERSON_q.GetSpecSQLObj();
            objSQL.SPConfigXMLFile = clsSysPara.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(strCondition);
            objDT = objSQL.ExecSpReturnDT("p_Get_PERSON_qByCond", values);
            return objDT;
        }

        /// <summary>
        /// 获取满足条件的所有记录,用DataSet的形式表示
        /// </summary>
        /// <param name="strCondition">条件串</param>
        /// <returns>满足条件的所有记录</returns>
        public static System.Data.DataSet GetPERSON_qDataSetByCondBySP(string strCondition)
        {
            System.Data.DataSet objDS = null;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsPERSON_q.GetSpecSQLObj();
            objSQL.SPConfigXMLFile = clsSysPara.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(strCondition);
            objDS = objSQL.ExecSPReturnDS("p_Get_PERSON_qByCond", values, "PERSON_q");
            return objDS;
        }

        /// <summary>
        /// 获取满足条件的所有记录,用DataSet的形式表示
        /// </summary>
        /// <param name="strCondition">条件串</param>
        /// <returns>满足条件的所有记录</returns>
        public static System.Data.DataSet GetDataSet_PERSON_q(string strCondition)
        {
            string strSQL;
            System.Data.DataSet objDS = null;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsPERSON_q.GetSpecSQLObj();
            strSQL = "Select * from PERSON_q where " + strCondition;
            objDS = objSQL.GetDataSet(strSQL, "PERSON_q");
            return objDS;
        }

        /// <summary>
        /// 获取与该表中满足条件的所有记录,用DataSet的形式表示, 用存储过程来实现
        /// </summary>
        /// <param name="strCondition">条件串</param>
        /// <returns>满足条件的所有记录</returns>
        public static System.Data.DataSet GetDataSet_PERSON_qByCondBySP(string strCondition)
        {
            System.Data.DataSet objDS = null;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsPERSON_q.GetSpecSQLObj();
            objSQL.SPConfigXMLFile = clsSysPara.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(strCondition);
            objDS = objSQL.ExecSPReturnDS("p_Get_PERSON_qByCond", values, "PERSON_q");
            return objDS;
        }

        /// <summary>
        /// 获取与该表视图中满足条件的所有记录,用DataSet的形式表示
        /// </summary>
        /// <param name="strCondition">条件串</param>
        /// <returns>满足条件的所有记录</returns>
        public static System.Data.DataSet GetDataSet_PERSON_qV(string strCondition)
        {
            string strSQL;
            System.Data.DataSet objDS = null;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsPERSON_q.GetSpecSQLObj();
            strSQL = "Select * from vPERSON_q where " + strCondition;
            objDS = objSQL.GetDataSet(strSQL, "vPERSON_q");
            return objDS;
        }

        /// <summary>
        /// 获取满足条件的所有记录对象列表,用对象列表的形式表示
        /// </summary>
        /// <param name="strCondition">条件串</param>
        /// <returns>满足条件的所有记录对象列表</returns>
        public ArrayList GetPERSON_qObjList(string strCondition)
        {
            ArrayList arrObjList = new ArrayList();
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = this.GetSpecSQLObj_Obj();
            strSQL = "Select * from PERSON_q where " + strCondition;
            objDT = objSQL.GetDataTable(strSQL);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsPERSON_q objPERSON_q = new clsPERSON_q();
                objPERSON_q.Account = objRow["Account"].ToString().Trim(); //卡号
                objPERSON_q.SCH_ID = objRow["SCH_ID"].ToString().Trim(); //SCH_ID
                objPERSON_q.BANK_ACC = objRow["BANK_ACC"].ToString().Trim(); //银行帐号
                objPERSON_q.CARD_NO = objRow["CARD_NO"].ToString().Trim(); //CARD_NO
                objPERSON_q.TEMP_CARD_NO = objRow["TEMP_CARD_NO"].ToString().Trim(); //TEMP_CARD_NO
                objPERSON_q.TEMP_USING = TransNullToDouble(objRow["TEMP_USING"].ToString().Trim()); //TEMP_USING
                objPERSON_q.TEMP_DEPOSIT = TransNullToDouble(objRow["TEMP_DEPOSIT"].ToString().Trim()); //TEMP_DEPOSIT
                objPERSON_q.PASSWORD = objRow["PASSWORD"].ToString().Trim(); //密码
                objPERSON_q.MONEY = TransNullToDouble(objRow["MONEY"].ToString().Trim()); //MONEY
                objPERSON_q.CARD_KIND = TransNullToDouble(objRow["CARD_KIND"].ToString().Trim()); //CARD_KIND
                objPERSON_q.CARD_STATE = TransNullToDouble(objRow["CARD_STATE"].ToString().Trim()); //CARD_STATE
                objPERSON_q.LAST_TIME = TransNullToDate(objRow["LAST_TIME"].ToString().Trim()); //LAST_TIME
                objPERSON_q.USEFUL_LIMIT = TransNullToDate(objRow["USEFUL_LIMIT"].ToString().Trim()); //USEFUL_LIMIT
                objPERSON_q.RECYCLE_LIMIT = TransNullToDate(objRow["RECYCLE_LIMIT"].ToString().Trim()); //RECYCLE_LIMIT
                objPERSON_q.NAME = objRow["NAME"].ToString().Trim(); //名称
                objPERSON_q.SEX = TransNullToDouble(objRow["SEX"].ToString().Trim()); //性别
                objPERSON_q.IDEN_NO = TransNullToDouble(objRow["IDEN_NO"].ToString().Trim()); //IDEN_NO
                objPERSON_q.NATION_NO = TransNullToDouble(objRow["NATION_NO"].ToString().Trim()); //国籍编号
                objPERSON_q.POLITICS = objRow["POLITICS"].ToString().Trim(); //政治面貌
                objPERSON_q.DUTY = objRow["DUTY"].ToString().Trim(); //DUTY
                objPERSON_q.BIRTH = TransNullToDate(objRow["BIRTH"].ToString().Trim()); //入学时间
                objPERSON_q.PERSON_ID = objRow["PERSON_ID"].ToString().Trim(); //身份证号码
                objPERSON_q.STUDENT_ID = objRow["STUDENT_ID"].ToString().Trim(); //学号
                objPERSON_q.SCHOOL_NO = objRow["SCHOOL_NO"].ToString().Trim(); //SCHOOL_NO
                objPERSON_q.ACADEMY_NO = objRow["ACADEMY_NO"].ToString().Trim(); //学院编号
                objPERSON_q.DEP_NO = objRow["DEP_NO"].ToString().Trim(); //专业编号
                objPERSON_q.CLASS_NO = objRow["CLASS_NO"].ToString().Trim(); //班级编号
                objPERSON_q.GRADE = objRow["GRADE"].ToString().Trim(); //年级
                objPERSON_q.IN_TIME = TransNullToDate(objRow["IN_TIME"].ToString().Trim()); //IN_TIME
                objPERSON_q.WALLANCE = TransNullToDouble(objRow["WALLANCE"].ToString().Trim()); //WALLANCE
                objPERSON_q.ADDRESS = objRow["ADDRESS"].ToString().Trim(); //家庭住址
                objPERSON_q.PHONE = objRow["PHONE"].ToString().Trim(); //电话
                objPERSON_q.POST_NO = objRow["POST_NO"].ToString().Trim(); //邮政编码
                objPERSON_q.POST_ADDRESS = objRow["POST_ADDRESS"].ToString().Trim(); //邮政地址
                objPERSON_q.MAIL = objRow["MAIL"].ToString().Trim(); //信箱
                objPERSON_q.DESCR = objRow["DESCR"].ToString().Trim(); //DESCR
                objPERSON_q.USER_ID = objRow["USER_ID"].ToString().Trim(); //用户ID
                objPERSON_q.OP_DATE = TransNullToDate(objRow["OP_DATE"].ToString().Trim()); //OP_DATE
                objPERSON_q.ANNEX = objRow["ANNEX"].ToString().Trim(); //ANNEX
                objPERSON_q.UpdDate = objRow["UpdDate"].ToString().Trim(); //UpdDate
                objPERSON_q.ClearUpdateState();//清除修改状态,即清除脏字段信息
                arrObjList.Add(objPERSON_q);
            }
            objDT = null;
            return arrObjList;
        }

        /// <summary>
        /// 获取满足条件的所有记录对象列表,用对象列表的形式表示,用存储过程来实现.
        /// </summary>
        /// <param name="strCondition">条件串</param>
        /// <returns>满足条件的所有记录对象列表</returns>
        public ArrayList GetPERSON_qObjListBySP(string strCondition)
        {
            ArrayList arrObjList = new ArrayList();
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = this.GetSpecSQLObj_Obj();
            objSQL.SPConfigXMLFile = clsSysPara.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(strCondition);
            objDT = objSQL.ExecSpReturnDT("p_Get_PERSON_qByCond", values);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsPERSON_q objPERSON_q = new clsPERSON_q();
                objPERSON_q.Account = objRow["Account"].ToString().Trim(); //卡号
                objPERSON_q.SCH_ID = objRow["SCH_ID"].ToString().Trim(); //SCH_ID
                objPERSON_q.BANK_ACC = objRow["BANK_ACC"].ToString().Trim(); //银行帐号
                objPERSON_q.CARD_NO = objRow["CARD_NO"].ToString().Trim(); //CARD_NO
                objPERSON_q.TEMP_CARD_NO = objRow["TEMP_CARD_NO"].ToString().Trim(); //TEMP_CARD_NO
                objPERSON_q.TEMP_USING = TransNullToDouble(objRow["TEMP_USING"].ToString().Trim()); //TEMP_USING
                objPERSON_q.TEMP_DEPOSIT = TransNullToDouble(objRow["TEMP_DEPOSIT"].ToString().Trim()); //TEMP_DEPOSIT
                objPERSON_q.PASSWORD = objRow["PASSWORD"].ToString().Trim(); //密码
                objPERSON_q.MONEY = TransNullToDouble(objRow["MONEY"].ToString().Trim()); //MONEY
                objPERSON_q.CARD_KIND = TransNullToDouble(objRow["CARD_KIND"].ToString().Trim()); //CARD_KIND
                objPERSON_q.CARD_STATE = TransNullToDouble(objRow["CARD_STATE"].ToString().Trim()); //CARD_STATE
                objPERSON_q.LAST_TIME = TransNullToDate(objRow["LAST_TIME"].ToString().Trim()); //LAST_TIME
                objPERSON_q.USEFUL_LIMIT = TransNullToDate(objRow["USEFUL_LIMIT"].ToString().Trim()); //USEFUL_LIMIT
                objPERSON_q.RECYCLE_LIMIT = TransNullToDate(objRow["RECYCLE_LIMIT"].ToString().Trim()); //RECYCLE_LIMIT
                objPERSON_q.NAME = objRow["NAME"].ToString().Trim(); //名称
                objPERSON_q.SEX = TransNullToDouble(objRow["SEX"].ToString().Trim()); //性别
                objPERSON_q.IDEN_NO = TransNullToDouble(objRow["IDEN_NO"].ToString().Trim()); //IDEN_NO
                objPERSON_q.NATION_NO = TransNullToDouble(objRow["NATION_NO"].ToString().Trim()); //国籍编号
                objPERSON_q.POLITICS = objRow["POLITICS"].ToString().Trim(); //政治面貌
                objPERSON_q.DUTY = objRow["DUTY"].ToString().Trim(); //DUTY
                objPERSON_q.BIRTH = TransNullToDate(objRow["BIRTH"].ToString().Trim()); //入学时间
                objPERSON_q.PERSON_ID = objRow["PERSON_ID"].ToString().Trim(); //身份证号码
                objPERSON_q.STUDENT_ID = objRow["STUDENT_ID"].ToString().Trim(); //学号
                objPERSON_q.SCHOOL_NO = objRow["SCHOOL_NO"].ToString().Trim(); //SCHOOL_NO
                objPERSON_q.ACADEMY_NO = objRow["ACADEMY_NO"].ToString().Trim(); //学院编号
                objPERSON_q.DEP_NO = objRow["DEP_NO"].ToString().Trim(); //专业编号
                objPERSON_q.CLASS_NO = objRow["CLASS_NO"].ToString().Trim(); //班级编号
                objPERSON_q.GRADE = objRow["GRADE"].ToString().Trim(); //年级
                objPERSON_q.IN_TIME = TransNullToDate(objRow["IN_TIME"].ToString().Trim()); //IN_TIME
                objPERSON_q.WALLANCE = TransNullToDouble(objRow["WALLANCE"].ToString().Trim()); //WALLANCE
                objPERSON_q.ADDRESS = objRow["ADDRESS"].ToString().Trim(); //家庭住址
                objPERSON_q.PHONE = objRow["PHONE"].ToString().Trim(); //电话
                objPERSON_q.POST_NO = objRow["POST_NO"].ToString().Trim(); //邮政编码
                objPERSON_q.POST_ADDRESS = objRow["POST_ADDRESS"].ToString().Trim(); //邮政地址
                objPERSON_q.MAIL = objRow["MAIL"].ToString().Trim(); //信箱
                objPERSON_q.DESCR = objRow["DESCR"].ToString().Trim(); //DESCR
                objPERSON_q.USER_ID = objRow["USER_ID"].ToString().Trim(); //用户ID
                objPERSON_q.OP_DATE = TransNullToDate(objRow["OP_DATE"].ToString().Trim()); //OP_DATE
                objPERSON_q.ANNEX = objRow["ANNEX"].ToString().Trim(); //ANNEX
                objPERSON_q.UpdDate = objRow["UpdDate"].ToString().Trim(); //UpdDate
                objPERSON_q.ClearUpdateState();//清除修改状态,即清除脏字段信息
                arrObjList.Add(objPERSON_q);
            }
            objDT = null;
            return arrObjList;
        }

        /// <summary>
        /// 获取满足条件的第一条记录,用对象的形式表示
        /// </summary>
        /// <param name="strCondition">条件串</param>
        /// <returns>第一条记录的对象</returns>
        public clsPERSON_q GetFirstPERSON_q(string strCondition)
        {
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = this.GetSpecSQLObj_Obj();
            strSQL = "Select * from PERSON_q where " + strCondition;
            objDT = objSQL.GetDataTable(strSQL);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return null;
            }
            DataRow objRow = objDT.Rows[0];
            clsPERSON_q objPERSON_q = new clsPERSON_q();
            objPERSON_q.Account = objRow["Account"].ToString().Trim(); //卡号
            objPERSON_q.SCH_ID = objRow["SCH_ID"].ToString().Trim(); //SCH_ID
            objPERSON_q.BANK_ACC = objRow["BANK_ACC"].ToString().Trim(); //银行帐号
            objPERSON_q.CARD_NO = objRow["CARD_NO"].ToString().Trim(); //CARD_NO
            objPERSON_q.TEMP_CARD_NO = objRow["TEMP_CARD_NO"].ToString().Trim(); //TEMP_CARD_NO
            objPERSON_q.TEMP_USING = TransNullToDouble(objRow["TEMP_USING"].ToString().Trim()); //TEMP_USING
            objPERSON_q.TEMP_DEPOSIT = TransNullToDouble(objRow["TEMP_DEPOSIT"].ToString().Trim()); //TEMP_DEPOSIT
            objPERSON_q.PASSWORD = objRow["PASSWORD"].ToString().Trim(); //密码
            objPERSON_q.MONEY = TransNullToDouble(objRow["MONEY"].ToString().Trim()); //MONEY
            objPERSON_q.CARD_KIND = TransNullToDouble(objRow["CARD_KIND"].ToString().Trim()); //CARD_KIND
            objPERSON_q.CARD_STATE = TransNullToDouble(objRow["CARD_STATE"].ToString().Trim()); //CARD_STATE
            objPERSON_q.LAST_TIME = TransNullToDate(objRow["LAST_TIME"].ToString().Trim()); //LAST_TIME
            objPERSON_q.USEFUL_LIMIT = TransNullToDate(objRow["USEFUL_LIMIT"].ToString().Trim()); //USEFUL_LIMIT
            objPERSON_q.RECYCLE_LIMIT = TransNullToDate(objRow["RECYCLE_LIMIT"].ToString().Trim()); //RECYCLE_LIMIT
            objPERSON_q.NAME = objRow["NAME"].ToString().Trim(); //名称
            objPERSON_q.SEX = TransNullToDouble(objRow["SEX"].ToString().Trim()); //性别
            objPERSON_q.IDEN_NO = TransNullToDouble(objRow["IDEN_NO"].ToString().Trim()); //IDEN_NO
            objPERSON_q.NATION_NO = TransNullToDouble(objRow["NATION_NO"].ToString().Trim()); //国籍编号
            objPERSON_q.POLITICS = objRow["POLITICS"].ToString().Trim(); //政治面貌
            objPERSON_q.DUTY = objRow["DUTY"].ToString().Trim(); //DUTY
            objPERSON_q.BIRTH = TransNullToDate(objRow["BIRTH"].ToString().Trim()); //入学时间
            objPERSON_q.PERSON_ID = objRow["PERSON_ID"].ToString().Trim(); //身份证号码
            objPERSON_q.STUDENT_ID = objRow["STUDENT_ID"].ToString().Trim(); //学号
            objPERSON_q.SCHOOL_NO = objRow["SCHOOL_NO"].ToString().Trim(); //SCHOOL_NO
            objPERSON_q.ACADEMY_NO = objRow["ACADEMY_NO"].ToString().Trim(); //学院编号
            objPERSON_q.DEP_NO = objRow["DEP_NO"].ToString().Trim(); //专业编号
            objPERSON_q.CLASS_NO = objRow["CLASS_NO"].ToString().Trim(); //班级编号
            objPERSON_q.GRADE = objRow["GRADE"].ToString().Trim(); //年级
            objPERSON_q.IN_TIME = TransNullToDate(objRow["IN_TIME"].ToString().Trim()); //IN_TIME
            objPERSON_q.WALLANCE = TransNullToDouble(objRow["WALLANCE"].ToString().Trim()); //WALLANCE
            objPERSON_q.ADDRESS = objRow["ADDRESS"].ToString().Trim(); //家庭住址
            objPERSON_q.PHONE = objRow["PHONE"].ToString().Trim(); //电话
            objPERSON_q.POST_NO = objRow["POST_NO"].ToString().Trim(); //邮政编码
            objPERSON_q.POST_ADDRESS = objRow["POST_ADDRESS"].ToString().Trim(); //邮政地址
            objPERSON_q.MAIL = objRow["MAIL"].ToString().Trim(); //信箱
            objPERSON_q.DESCR = objRow["DESCR"].ToString().Trim(); //DESCR
            objPERSON_q.USER_ID = objRow["USER_ID"].ToString().Trim(); //用户ID
            objPERSON_q.OP_DATE = TransNullToDate(objRow["OP_DATE"].ToString().Trim()); //OP_DATE
            objPERSON_q.ANNEX = objRow["ANNEX"].ToString().Trim(); //ANNEX
            objPERSON_q.UpdDate = objRow["UpdDate"].ToString().Trim(); //UpdDate
            objPERSON_q.ClearUpdateState();//清除修改状态,即清除脏字段信息
            objDT = null;
            return objPERSON_q;
        }

        /// <summary>
        /// 获取满足条件的第一条记录,用对象的形式表示,用存储过程来实现
        /// </summary>
        /// <param name="strCondition">条件串</param>
        /// <returns>第一条记录的对象</returns>
        public clsPERSON_q GetFirstPERSON_qBySP(string strCondition)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = this.GetSpecSQLObj_Obj();
            objSQL.SPConfigXMLFile = clsSysPara.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(strCondition);
            objDT = objSQL.ExecSpReturnDT("p_Get_PERSON_qTop1ByCond", values);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return null;
            }
            DataRow objRow = objDT.Rows[0];
            clsPERSON_q objPERSON_q = new clsPERSON_q();
            objPERSON_q.Account = objRow["Account"].ToString().Trim(); //卡号
            objPERSON_q.SCH_ID = objRow["SCH_ID"].ToString().Trim(); //SCH_ID
            objPERSON_q.BANK_ACC = objRow["BANK_ACC"].ToString().Trim(); //银行帐号
            objPERSON_q.CARD_NO = objRow["CARD_NO"].ToString().Trim(); //CARD_NO
            objPERSON_q.TEMP_CARD_NO = objRow["TEMP_CARD_NO"].ToString().Trim(); //TEMP_CARD_NO
            objPERSON_q.TEMP_USING = TransNullToDouble(objRow["TEMP_USING"].ToString().Trim()); //TEMP_USING
            objPERSON_q.TEMP_DEPOSIT = TransNullToDouble(objRow["TEMP_DEPOSIT"].ToString().Trim()); //TEMP_DEPOSIT
            objPERSON_q.PASSWORD = objRow["PASSWORD"].ToString().Trim(); //密码
            objPERSON_q.MONEY = TransNullToDouble(objRow["MONEY"].ToString().Trim()); //MONEY
            objPERSON_q.CARD_KIND = TransNullToDouble(objRow["CARD_KIND"].ToString().Trim()); //CARD_KIND
            objPERSON_q.CARD_STATE = TransNullToDouble(objRow["CARD_STATE"].ToString().Trim()); //CARD_STATE
            objPERSON_q.LAST_TIME = TransNullToDate(objRow["LAST_TIME"].ToString().Trim()); //LAST_TIME
            objPERSON_q.USEFUL_LIMIT = TransNullToDate(objRow["USEFUL_LIMIT"].ToString().Trim()); //USEFUL_LIMIT
            objPERSON_q.RECYCLE_LIMIT = TransNullToDate(objRow["RECYCLE_LIMIT"].ToString().Trim()); //RECYCLE_LIMIT
            objPERSON_q.NAME = objRow["NAME"].ToString().Trim(); //名称
            objPERSON_q.SEX = TransNullToDouble(objRow["SEX"].ToString().Trim()); //性别
            objPERSON_q.IDEN_NO = TransNullToDouble(objRow["IDEN_NO"].ToString().Trim()); //IDEN_NO
            objPERSON_q.NATION_NO = TransNullToDouble(objRow["NATION_NO"].ToString().Trim()); //国籍编号
            objPERSON_q.POLITICS = objRow["POLITICS"].ToString().Trim(); //政治面貌
            objPERSON_q.DUTY = objRow["DUTY"].ToString().Trim(); //DUTY
            objPERSON_q.BIRTH = TransNullToDate(objRow["BIRTH"].ToString().Trim()); //入学时间
            objPERSON_q.PERSON_ID = objRow["PERSON_ID"].ToString().Trim(); //身份证号码
            objPERSON_q.STUDENT_ID = objRow["STUDENT_ID"].ToString().Trim(); //学号
            objPERSON_q.SCHOOL_NO = objRow["SCHOOL_NO"].ToString().Trim(); //SCHOOL_NO
            objPERSON_q.ACADEMY_NO = objRow["ACADEMY_NO"].ToString().Trim(); //学院编号
            objPERSON_q.DEP_NO = objRow["DEP_NO"].ToString().Trim(); //专业编号
            objPERSON_q.CLASS_NO = objRow["CLASS_NO"].ToString().Trim(); //班级编号
            objPERSON_q.GRADE = objRow["GRADE"].ToString().Trim(); //年级
            objPERSON_q.IN_TIME = TransNullToDate(objRow["IN_TIME"].ToString().Trim()); //IN_TIME
            objPERSON_q.WALLANCE = TransNullToDouble(objRow["WALLANCE"].ToString().Trim()); //WALLANCE
            objPERSON_q.ADDRESS = objRow["ADDRESS"].ToString().Trim(); //家庭住址
            objPERSON_q.PHONE = objRow["PHONE"].ToString().Trim(); //电话
            objPERSON_q.POST_NO = objRow["POST_NO"].ToString().Trim(); //邮政编码
            objPERSON_q.POST_ADDRESS = objRow["POST_ADDRESS"].ToString().Trim(); //邮政地址
            objPERSON_q.MAIL = objRow["MAIL"].ToString().Trim(); //信箱
            objPERSON_q.DESCR = objRow["DESCR"].ToString().Trim(); //DESCR
            objPERSON_q.USER_ID = objRow["USER_ID"].ToString().Trim(); //用户ID
            objPERSON_q.OP_DATE = TransNullToDate(objRow["OP_DATE"].ToString().Trim()); //OP_DATE
            objPERSON_q.ANNEX = objRow["ANNEX"].ToString().Trim(); //ANNEX
            objPERSON_q.UpdDate = objRow["UpdDate"].ToString().Trim(); //UpdDate
            objPERSON_q.ClearUpdateState();//清除修改状态,即清除脏字段信息
            objDT = null;
            return objPERSON_q;
        }



        /// <summary>
        /// 功能：获取某一条件的相关表视图(View)
        /// </summary>
        /// <param name="strCondition">条件串</param>
        /// <returns>返回已经转换代码的DataTable</returns>
        public static System.Data.DataTable GetPERSON_qV(string strCondition)
        {
            StringBuilder strSQL = new StringBuilder();
            System.Data.DataTable objDT = null;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsPERSON_q.GetSpecSQLObj();
            strSQL.Append("Select vPERSON_q.* ");
            strSQL.Append(" from vPERSON_q ");
            strSQL.Append(" where " + strCondition);
            objDT = objSQL.GetDataTable(strSQL.ToString());
            return objDT;
        }


        /// <summary>
        /// 是否存在记录
        /// </summary>
        /// <returns>是否存在</returns>
        public bool IsExist()
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = this.GetSpecSQLObj_Obj();
            if (objSQL.IsExistRecord("PERSON_q", "Account=" + "'" + mstrAccount + "'"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 判断当前表中是否存在给定关键字值的记录
        /// </summary>
        /// <param name="strAccount">给定的关键字值</param>
        /// <returns>返回是否存在?</returns>
        public static bool IsExist(string strAccount)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsPERSON_q.GetSpecSQLObj();
            if (objSQL.IsExistRecord("PERSON_q", "Account=" + "'" + strAccount + "'"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 是否存在记录
        /// </summary>
        /// <param name="strAccount">关键字</param>
        /// <returns>是否存在</returns>
        public static bool IsExistBySP_S(string strAccount)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsPERSON_q.GetSpecSQLObj();
            objSQL.SPConfigXMLFile = clsSysPara.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(strAccount);
            string strIsExist = "";
            values.Add(strIsExist);
            ArrayList arrReturn = objSQL.ExecSpWithOutPut("p_IsExist_PERSON_q", values);
            if (arrReturn[0].ToString() == "1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 检查字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
        /// </summary>
        public void CheckPropertyNew()
        {
            if (Object.Equals(null, mstrAccount)
            || (!Object.Equals(null, mstrAccount) && mstrAccount.ToString() == "")
            )
            {
                throw new clsDbObjException("字段[卡号]不能为空(NULL)!");
            }
            if (!Object.Equals(null, mstrAccount) && getStrLen(mstrAccount) > 10)
            {
                throw new clsDbObjException("字段[卡号]的长度不能超过10!");
            }
            if (!Object.Equals(null, mstrSCH_ID) && getStrLen(mstrSCH_ID) > 25)
            {
                throw new clsDbObjException("字段[SCH_ID]的长度不能超过25!");
            }
            if (!Object.Equals(null, mstrBANK_ACC) && getStrLen(mstrBANK_ACC) > 20)
            {
                throw new clsDbObjException("字段[银行帐号]的长度不能超过20!");
            }
            if (!Object.Equals(null, mstrCARD_NO) && getStrLen(mstrCARD_NO) > 19)
            {
                throw new clsDbObjException("字段[CARD_NO]的长度不能超过19!");
            }
            if (!Object.Equals(null, mstrTEMP_CARD_NO) && getStrLen(mstrTEMP_CARD_NO) > 19)
            {
                throw new clsDbObjException("字段[TEMP_CARD_NO]的长度不能超过19!");
            }
            if (!Object.Equals(null, mstrPASSWORD) && getStrLen(mstrPASSWORD) > 8)
            {
                throw new clsDbObjException("字段[密码]的长度不能超过8!");
            }
            if (!Object.Equals(null, mstrNAME) && getStrLen(mstrNAME) > 40)
            {
                throw new clsDbObjException("字段[名称]的长度不能超过40!");
            }
            if (!Object.Equals(null, mstrPOLITICS) && getStrLen(mstrPOLITICS) > 10)
            {
                throw new clsDbObjException("字段[政治面貌]的长度不能超过10!");
            }
            if (!Object.Equals(null, mstrDUTY) && getStrLen(mstrDUTY) > 20)
            {
                throw new clsDbObjException("字段[DUTY]的长度不能超过20!");
            }
            if (!Object.Equals(null, mstrPERSON_ID) && getStrLen(mstrPERSON_ID) > 18)
            {
                throw new clsDbObjException("字段[身份证号码]的长度不能超过18!");
            }
            if (!Object.Equals(null, mstrSTUDENT_ID) && getStrLen(mstrSTUDENT_ID) > 15)
            {
                throw new clsDbObjException("字段[学号]的长度不能超过15!");
            }
            if (!Object.Equals(null, mstrSCHOOL_NO) && getStrLen(mstrSCHOOL_NO) > 8)
            {
                throw new clsDbObjException("字段[SCHOOL_NO]的长度不能超过8!");
            }
            if (!Object.Equals(null, mstrACADEMY_NO) && getStrLen(mstrACADEMY_NO) > 8)
            {
                throw new clsDbObjException("字段[学院编号]的长度不能超过8!");
            }
            if (!Object.Equals(null, mstrDEP_NO) && getStrLen(mstrDEP_NO) > 8)
            {
                throw new clsDbObjException("字段[专业编号]的长度不能超过8!");
            }
            if (!Object.Equals(null, mstrCLASS_NO) && getStrLen(mstrCLASS_NO) > 8)
            {
                throw new clsDbObjException("字段[班级编号]的长度不能超过8!");
            }
            if (!Object.Equals(null, mstrGRADE) && getStrLen(mstrGRADE) > 4)
            {
                throw new clsDbObjException("字段[年级]的长度不能超过4!");
            }
            if (!Object.Equals(null, mstrADDRESS) && getStrLen(mstrADDRESS) > 100)
            {
                throw new clsDbObjException("字段[家庭住址]的长度不能超过100!");
            }
            if (!Object.Equals(null, mstrPHONE) && getStrLen(mstrPHONE) > 50)
            {
                throw new clsDbObjException("字段[电话]的长度不能超过50!");
            }
            if (!Object.Equals(null, mstrPOST_NO) && getStrLen(mstrPOST_NO) > 8)
            {
                throw new clsDbObjException("字段[邮政编码]的长度不能超过8!");
            }
            if (!Object.Equals(null, mstrPOST_ADDRESS) && getStrLen(mstrPOST_ADDRESS) > 40)
            {
                throw new clsDbObjException("字段[邮政地址]的长度不能超过40!");
            }
            if (!Object.Equals(null, mstrMAIL) && getStrLen(mstrMAIL) > 50)
            {
                throw new clsDbObjException("字段[信箱]的长度不能超过50!");
            }
            if (!Object.Equals(null, mstrDESCR) && getStrLen(mstrDESCR) > 100)
            {
                throw new clsDbObjException("字段[DESCR]的长度不能超过100!");
            }
            if (!Object.Equals(null, mstrUSER_ID) && getStrLen(mstrUSER_ID) > 12)
            {
                throw new clsDbObjException("字段[用户ID]的长度不能超过12!");
            }
            if (!Object.Equals(null, mstrANNEX) && getStrLen(mstrANNEX) > 20)
            {
                throw new clsDbObjException("字段[ANNEX]的长度不能超过20!");
            }
            if (!Object.Equals(null, mstrUpdDate) && getStrLen(mstrUpdDate) > 14)
            {
                throw new clsDbObjException("字段[UpdDate]的长度不能超过14!");
            }
        }


        /// <summary>
        /// 获取当前表满足条件的所有记录的关键字值列表
        /// </summary>
        /// <param name="strCondtion">条件串</param>
        /// <returns>返回的关键字值列表</returns>
        public ArrayList GetID(string strCondtion)
        {
            string strSQL;
            System.Data.DataTable objDT;
            ArrayList arrList = new ArrayList();
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = this.GetSpecSQLObj_Obj();
            int iRow, iCol;
            string strKeyValue;
            strSQL = "Select Account from PERSON_q where " + strCondtion;
            try
            {
                objDT = objSQL.GetDataTable(strSQL);
            }
            catch (Exception objException)
            {
                LogError(objException);
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
            }

            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return null;
            }
            for (iRow = 0; iRow <= objDT.Rows.Count - 1; iRow++)
            {
                strKeyValue = "";
                for (iCol = 0; iCol <= objDT.Columns.Count - 1; iCol++)
                {
                    if (iCol == 0)
                    {
                        strKeyValue += objDT.Rows[iRow][iCol].ToString();
                    }
                    else
                    {
                        strKeyValue += "//" + objDT.Rows[iRow][iCol].ToString();
                    }
                }
                arrList.Add(strKeyValue);
            }
            objDT = null;
            return arrList;
        }

        /// <summary>
        /// 获取当前表满足条件的第一条记录的关键字值
        /// </summary>
        /// <param name="strCondtion">条件串</param>
        /// <returns>返回的第一条记录的关键字值</returns>
        public string GetFirstID(string strCondtion)
        {
            string strSQL;
            System.Data.DataTable objDT;
            ArrayList arrList = new ArrayList();
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = this.GetSpecSQLObj_Obj();
            string strKeyValue;
            strSQL = "Select Account from PERSON_q where " + strCondtion;
            try
            {
                objDT = objSQL.GetDataTable(strSQL);
            }
            catch (Exception objException)
            {
                LogError(objException);
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
            }

            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return null;
            }
            strKeyValue = objDT.Rows[0][0].ToString();
            objDT = null;
            return strKeyValue;
        }

        /// <summary>
        /// 获取当前表满足条件的第一条记录的关键字值
        /// </summary>
        /// <param name="strCondtion">条件串</param>
        /// <returns>返回的第一条记录的关键字值</returns>
        public static string GetFirstID_S(string strCondtion)
        {
            string strSQL;
            System.Data.DataTable objDT;
            ArrayList arrList = new ArrayList();
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsPERSON_q.GetSpecSQLObj();
            string strKeyValue;
            strSQL = "Select Account from PERSON_q where " + strCondtion;
            try
            {
                objDT = objSQL.GetDataTable(strSQL);
            }
            catch (Exception objException)
            {
                LogErrorS(objException, "clsPERSON_q");
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
            }

            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return null;
            }
            strKeyValue = objDT.Rows[0][0].ToString();
            objDT = null;
            return strKeyValue;
        }
    }
}