///----------------------
///生成代码版本：6.3.0.0
///生成日期：2008/03/04
///生成者：尹华蓓
///注意：需要数据底层（PubDataBase.dll）的版本：4.3.0.0
///========================
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Collections;
using com.taishsoft.commdb;
using EcardDataClass;

namespace EcardDataClass
{
    public class clsv_pfy_person : clsGeneralTab
    {
        public const string CurrTabName_S = "v_pfy_person"; //当前表名，与该类相关的表名
        public const string CurrTabKeyFldName_S = "ACCOUNT"; //当前表中的关键字名称，与该类相关的表中关键字名
        protected const int mintAttributeCount = 27;
        public static string[] AttributeName = new string[] { "Name", "Sex", "MAIL", "Address", "ACCOUNT", "SCH_ID", "CARD_NO", "TEMP_CARD_NO", "CARD_KIND", "CARD_STATE", "USEFUL_LIMIT", "RECYCLE_LIMIT", "IDEN_NO", "NATION_NO", "POLITICS", "DUTY", "BIRTH", "PERSON_ID", "STUDENT_ID", "ACADEMY_NO", "DEP_NO", "CLASS_NO", "GRADE", "IN_TIME", "PHONE", "POST_NO", "POST_ADDRESS" };
        //以下是属性变量

        protected string mstrName;    //姓名
        protected string mstrSex;    //性别
        protected string mstrMAIL;    //MAIL
        protected string mstrAddress;    //地址
        protected string mstrACCOUNT;    //ACCOUNT
        protected string mstrSCH_ID;    //SCH_ID
        protected string mstrCARD_NO;    //CARD_NO
        protected string mstrTEMP_CARD_NO;    //TEMP_CARD_NO
        protected double mdblCARD_KIND;    //CARD_KIND
        protected double mdblCARD_STATE;    //CARD_STATE
        protected DateTime mdteUSEFUL_LIMIT;    //USEFUL_LIMIT
        protected DateTime mdteRECYCLE_LIMIT;    //RECYCLE_LIMIT
        protected double mdblIDEN_NO;    //IDEN_NO
        protected double mdblNATION_NO;    //NATION_NO
        protected string mstrPOLITICS;    //POLITICS
        protected string mstrDUTY;    //DUTY
        protected DateTime mdteBIRTH;    //BIRTH
        protected string mstrPERSON_ID;    //PERSON_ID
        protected string mstrSTUDENT_ID;    //STUDENT_ID
        protected string mstrACADEMY_NO;    //ACADEMY_NO
        protected string mstrDEP_NO;    //DEP_NO
        protected string mstrCLASS_NO;    //CLASS_NO
        protected string mstrGRADE;    //GRADE
        protected DateTime mdteIN_TIME;    //IN_TIME
        protected string mstrPHONE;    //PHONE
        protected string mstrPOST_NO;    //POST_NO
        protected string mstrPOST_ADDRESS;    //POST_ADDRESS

        //用户指定的连接串,如果用户不指定该连接串,就用PUBDATABASE中所指定的连接串
        private static string m_strConnectString;
        public static string ConnectString
        {
            get { return m_strConnectString; }
            set { m_strConnectString = value; }
        }

        public clsv_pfy_person()
        {
            SetInit();
            CurrTabName = "v_pfy_person";
            KeyFldName = "ACCOUNT";
        }

        public clsv_pfy_person(string strACCOUNT)
        {

            mstrACCOUNT = strACCOUNT;
            SetInit();
            CurrTabName = "v_pfy_person";
            KeyFldName = "ACCOUNT";
        }

        public clsv_pfy_person(string strACCOUNT, bool bolIsGetv_pfy_person)
        {

            mstrACCOUNT = strACCOUNT;
            SetInit();
            if (bolIsGetv_pfy_person == true)
            {
                Getv_pfy_person();
            }
            CurrTabName = "v_pfy_person";
            KeyFldName = "ACCOUNT";
        }


        public static int AttributeCount
        {
            get
            {
                return mintAttributeCount;
            }
        }
        public object this[string strAttributeName]
        {
            get
            {
                if (strAttributeName == "Name")
                {
                    return mstrName;
                }
                else if (strAttributeName == "Sex")
                {
                    return mstrSex;
                }
                else if (strAttributeName == "MAIL")
                {
                    return mstrMAIL;
                }
                else if (strAttributeName == "Address")
                {
                    return mstrAddress;
                }
                else if (strAttributeName == "ACCOUNT")
                {
                    return mstrACCOUNT;
                }
                else if (strAttributeName == "SCH_ID")
                {
                    return mstrSCH_ID;
                }
                else if (strAttributeName == "CARD_NO")
                {
                    return mstrCARD_NO;
                }
                else if (strAttributeName == "TEMP_CARD_NO")
                {
                    return mstrTEMP_CARD_NO;
                }
                else if (strAttributeName == "CARD_KIND")
                {
                    return mdblCARD_KIND;
                }
                else if (strAttributeName == "CARD_STATE")
                {
                    return mdblCARD_STATE;
                }
                else if (strAttributeName == "USEFUL_LIMIT")
                {
                    return mdteUSEFUL_LIMIT;
                }
                else if (strAttributeName == "RECYCLE_LIMIT")
                {
                    return mdteRECYCLE_LIMIT;
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
                return null;
            }
            set
            {
                if (strAttributeName == "Name")
                {
                    mstrName = value.ToString();
                }
                else if (strAttributeName == "Sex")
                {
                    mstrSex = value.ToString();
                }
                else if (strAttributeName == "MAIL")
                {
                    mstrMAIL = value.ToString();
                }
                else if (strAttributeName == "Address")
                {
                    mstrAddress = value.ToString();
                }
                else if (strAttributeName == "ACCOUNT")
                {
                    mstrACCOUNT = value.ToString();
                }
                else if (strAttributeName == "SCH_ID")
                {
                    mstrSCH_ID = value.ToString();
                }
                else if (strAttributeName == "CARD_NO")
                {
                    mstrCARD_NO = value.ToString();
                }
                else if (strAttributeName == "TEMP_CARD_NO")
                {
                    mstrTEMP_CARD_NO = value.ToString();
                }
                else if (strAttributeName == "CARD_KIND")
                {
                    mdblCARD_KIND = TransNullToDouble(value.ToString());
                }
                else if (strAttributeName == "CARD_STATE")
                {
                    mdblCARD_STATE = TransNullToDouble(value.ToString());
                }
                else if (strAttributeName == "USEFUL_LIMIT")
                {
                    mdteUSEFUL_LIMIT = TransNullToDate(value.ToString());
                }
                else if (strAttributeName == "RECYCLE_LIMIT")
                {
                    mdteRECYCLE_LIMIT = TransNullToDate(value.ToString());
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
            }
        }
        public object this[int intIndex]
        {
            get
            {
                if ("Name" == AttributeName[intIndex])
                {
                    return mstrName;
                }
                else if ("Sex" == AttributeName[intIndex])
                {
                    return mstrSex;
                }
                else if ("MAIL" == AttributeName[intIndex])
                {
                    return mstrMAIL;
                }
                else if ("Address" == AttributeName[intIndex])
                {
                    return mstrAddress;
                }
                else if ("ACCOUNT" == AttributeName[intIndex])
                {
                    return mstrACCOUNT;
                }
                else if ("SCH_ID" == AttributeName[intIndex])
                {
                    return mstrSCH_ID;
                }
                else if ("CARD_NO" == AttributeName[intIndex])
                {
                    return mstrCARD_NO;
                }
                else if ("TEMP_CARD_NO" == AttributeName[intIndex])
                {
                    return mstrTEMP_CARD_NO;
                }
                else if ("CARD_KIND" == AttributeName[intIndex])
                {
                    return mdblCARD_KIND;
                }
                else if ("CARD_STATE" == AttributeName[intIndex])
                {
                    return mdblCARD_STATE;
                }
                else if ("USEFUL_LIMIT" == AttributeName[intIndex])
                {
                    return mdteUSEFUL_LIMIT;
                }
                else if ("RECYCLE_LIMIT" == AttributeName[intIndex])
                {
                    return mdteRECYCLE_LIMIT;
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
                return null;
            }
            set
            {
                if ("Name" == AttributeName[intIndex])
                {
                    mstrName = value.ToString();
                }
                else if ("Sex" == AttributeName[intIndex])
                {
                    mstrSex = value.ToString();
                }
                else if ("MAIL" == AttributeName[intIndex])
                {
                    mstrMAIL = value.ToString();
                }
                else if ("Address" == AttributeName[intIndex])
                {
                    mstrAddress = value.ToString();
                }
                else if ("ACCOUNT" == AttributeName[intIndex])
                {
                    mstrACCOUNT = value.ToString();
                }
                else if ("SCH_ID" == AttributeName[intIndex])
                {
                    mstrSCH_ID = value.ToString();
                }
                else if ("CARD_NO" == AttributeName[intIndex])
                {
                    mstrCARD_NO = value.ToString();
                }
                else if ("TEMP_CARD_NO" == AttributeName[intIndex])
                {
                    mstrTEMP_CARD_NO = value.ToString();
                }
                else if ("CARD_KIND" == AttributeName[intIndex])
                {
                    mdblCARD_KIND = TransNullToDouble(value.ToString());
                }
                else if ("CARD_STATE" == AttributeName[intIndex])
                {
                    mdblCARD_STATE = TransNullToDouble(value.ToString());
                }
                else if ("USEFUL_LIMIT" == AttributeName[intIndex])
                {
                    mdteUSEFUL_LIMIT = TransNullToDate(value.ToString());
                }
                else if ("RECYCLE_LIMIT" == AttributeName[intIndex])
                {
                    mdteRECYCLE_LIMIT = TransNullToDate(value.ToString());
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
            }
        }

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name
        {
            get
            {
                return mstrName;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrName = value;
                }
                else
                {
                    mstrName = value;
                }
                if (htProperty.ContainsKey("Name") == false)
                {
                    htProperty.Add("Name", "true");
                }
            }
        }
        /// <summary>
        /// 性别
        /// </summary>
        public string Sex
        {
            get
            {
                return mstrSex;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrSex = value;
                }
                else
                {
                    mstrSex = value;
                }
                if (htProperty.ContainsKey("Sex") == false)
                {
                    htProperty.Add("Sex", "true");
                }
            }
        }
        /// <summary>
        /// MAIL
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
                if (htProperty.ContainsKey("MAIL") == false)
                {
                    htProperty.Add("MAIL", "true");
                }
            }
        }
        /// <summary>
        /// 地址
        /// </summary>
        public string Address
        {
            get
            {
                return mstrAddress;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrAddress = value;
                }
                else
                {
                    mstrAddress = value;
                }
                if (htProperty.ContainsKey("Address") == false)
                {
                    htProperty.Add("Address", "true");
                }
            }
        }
        /// <summary>
        /// ACCOUNT
        /// </summary>
        public string ACCOUNT
        {
            get
            {
                return mstrACCOUNT;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrACCOUNT = value;
                }
                else
                {
                    mstrACCOUNT = value;
                }
                if (htProperty.ContainsKey("ACCOUNT") == false)
                {
                    htProperty.Add("ACCOUNT", "true");
                }
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
                if (htProperty.ContainsKey("SCH_ID") == false)
                {
                    htProperty.Add("SCH_ID", "true");
                }
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
                if (htProperty.ContainsKey("CARD_NO") == false)
                {
                    htProperty.Add("CARD_NO", "true");
                }
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
                if (htProperty.ContainsKey("TEMP_CARD_NO") == false)
                {
                    htProperty.Add("TEMP_CARD_NO", "true");
                }
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
                if (htProperty.ContainsKey("CARD_KIND") == false)
                {
                    htProperty.Add("CARD_KIND", "true");
                }
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
                if (htProperty.ContainsKey("CARD_STATE") == false)
                {
                    htProperty.Add("CARD_STATE", "true");
                }
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
                if (htProperty.ContainsKey("USEFUL_LIMIT") == false)
                {
                    htProperty.Add("USEFUL_LIMIT", "true");
                }
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
                if (htProperty.ContainsKey("RECYCLE_LIMIT") == false)
                {
                    htProperty.Add("RECYCLE_LIMIT", "true");
                }
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
                if (htProperty.ContainsKey("IDEN_NO") == false)
                {
                    htProperty.Add("IDEN_NO", "true");
                }
            }
        }
        /// <summary>
        /// NATION_NO
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
                if (htProperty.ContainsKey("NATION_NO") == false)
                {
                    htProperty.Add("NATION_NO", "true");
                }
            }
        }
        /// <summary>
        /// POLITICS
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
                if (htProperty.ContainsKey("POLITICS") == false)
                {
                    htProperty.Add("POLITICS", "true");
                }
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
                if (htProperty.ContainsKey("DUTY") == false)
                {
                    htProperty.Add("DUTY", "true");
                }
            }
        }
        /// <summary>
        /// BIRTH
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
                if (htProperty.ContainsKey("BIRTH") == false)
                {
                    htProperty.Add("BIRTH", "true");
                }
            }
        }
        /// <summary>
        /// PERSON_ID
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
                if (htProperty.ContainsKey("PERSON_ID") == false)
                {
                    htProperty.Add("PERSON_ID", "true");
                }
            }
        }
        /// <summary>
        /// STUDENT_ID
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
                if (htProperty.ContainsKey("STUDENT_ID") == false)
                {
                    htProperty.Add("STUDENT_ID", "true");
                }
            }
        }
        /// <summary>
        /// ACADEMY_NO
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
                if (htProperty.ContainsKey("ACADEMY_NO") == false)
                {
                    htProperty.Add("ACADEMY_NO", "true");
                }
            }
        }
        /// <summary>
        /// DEP_NO
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
                if (htProperty.ContainsKey("DEP_NO") == false)
                {
                    htProperty.Add("DEP_NO", "true");
                }
            }
        }
        /// <summary>
        /// CLASS_NO
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
                if (htProperty.ContainsKey("CLASS_NO") == false)
                {
                    htProperty.Add("CLASS_NO", "true");
                }
            }
        }
        /// <summary>
        /// GRADE
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
                if (htProperty.ContainsKey("GRADE") == false)
                {
                    htProperty.Add("GRADE", "true");
                }
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
                if (htProperty.ContainsKey("IN_TIME") == false)
                {
                    htProperty.Add("IN_TIME", "true");
                }
            }
        }
        /// <summary>
        /// PHONE
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
                if (htProperty.ContainsKey("PHONE") == false)
                {
                    htProperty.Add("PHONE", "true");
                }
            }
        }
        /// <summary>
        /// POST_NO
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
                if (htProperty.ContainsKey("POST_NO") == false)
                {
                    htProperty.Add("POST_NO", "true");
                }
            }
        }
        /// <summary>
        /// POST_ADDRESS
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
                if (htProperty.ContainsKey("POST_ADDRESS") == false)
                {
                    htProperty.Add("POST_ADDRESS", "true");
                }
            }
        }

        /// <summary>
        /// 清除修改状态,即清空存储脏字段信息的HashTable列表.
        /// </summary>
        public void ClearUpdateState()
        {
            htProperty.Clear();
        }

        public static clsSpecSQLforSql GetSpecSQLObj()
        {
            clsSpecSQLforSql objSQL = null;
            if (clsSysPara.bolIsUseConnectStrName == true)
            {
                objSQL = new clsSpecSQLforSql(clsSysPara.strConnectStrName, true);
                return objSQL;
            }
            if (string.IsNullOrEmpty(clsv_pfy_person.ConnectString) == true)
            {
                objSQL = new clsSpecSQLforSql();
            }
            else
            {
                objSQL = new clsSpecSQLforSql(clsv_pfy_person.ConnectString);
            }
            return objSQL;
        }


        public bool Getv_pfy_person()
        {
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsv_pfy_person.GetSpecSQLObj();
            strSQL = "Select * from v_pfy_person where ACCOUNT=" + "'" + mstrACCOUNT + "'";
            objDT = objSQL.GetDataTable(strSQL);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return false;
            }
            mstrName = objDT.Rows[0]["Name"].ToString().Trim(); //姓名
            mstrSex = objDT.Rows[0]["Sex"].ToString().Trim(); //性别
            mstrMAIL = objDT.Rows[0]["MAIL"].ToString().Trim(); //MAIL
            mstrAddress = objDT.Rows[0]["Address"].ToString().Trim(); //地址
            mstrACCOUNT = objDT.Rows[0]["ACCOUNT"].ToString().Trim(); //ACCOUNT
            mstrSCH_ID = objDT.Rows[0]["SCH_ID"].ToString().Trim(); //SCH_ID
            mstrCARD_NO = objDT.Rows[0]["CARD_NO"].ToString().Trim(); //CARD_NO
            mstrTEMP_CARD_NO = objDT.Rows[0]["TEMP_CARD_NO"].ToString().Trim(); //TEMP_CARD_NO
            mdblCARD_KIND = TransNullToDouble(objDT.Rows[0]["CARD_KIND"].ToString().Trim()); //CARD_KIND
            mdblCARD_STATE = TransNullToDouble(objDT.Rows[0]["CARD_STATE"].ToString().Trim()); //CARD_STATE
            mdteUSEFUL_LIMIT = TransNullToDate(objDT.Rows[0]["USEFUL_LIMIT"].ToString().Trim()); //USEFUL_LIMIT
            mdteRECYCLE_LIMIT = TransNullToDate(objDT.Rows[0]["RECYCLE_LIMIT"].ToString().Trim()); //RECYCLE_LIMIT
            mdblIDEN_NO = TransNullToDouble(objDT.Rows[0]["IDEN_NO"].ToString().Trim()); //IDEN_NO
            mdblNATION_NO = TransNullToDouble(objDT.Rows[0]["NATION_NO"].ToString().Trim()); //NATION_NO
            mstrPOLITICS = objDT.Rows[0]["POLITICS"].ToString().Trim(); //POLITICS
            mstrDUTY = objDT.Rows[0]["DUTY"].ToString().Trim(); //DUTY
            mdteBIRTH = TransNullToDate(objDT.Rows[0]["BIRTH"].ToString().Trim()); //BIRTH
            mstrPERSON_ID = objDT.Rows[0]["PERSON_ID"].ToString().Trim(); //PERSON_ID
            mstrSTUDENT_ID = objDT.Rows[0]["STUDENT_ID"].ToString().Trim(); //STUDENT_ID
            mstrACADEMY_NO = objDT.Rows[0]["ACADEMY_NO"].ToString().Trim(); //ACADEMY_NO
            mstrDEP_NO = objDT.Rows[0]["DEP_NO"].ToString().Trim(); //DEP_NO
            mstrCLASS_NO = objDT.Rows[0]["CLASS_NO"].ToString().Trim(); //CLASS_NO
            mstrGRADE = objDT.Rows[0]["GRADE"].ToString().Trim(); //GRADE
            mdteIN_TIME = TransNullToDate(objDT.Rows[0]["IN_TIME"].ToString().Trim()); //IN_TIME
            mstrPHONE = objDT.Rows[0]["PHONE"].ToString().Trim(); //PHONE
            mstrPOST_NO = objDT.Rows[0]["POST_NO"].ToString().Trim(); //POST_NO
            mstrPOST_ADDRESS = objDT.Rows[0]["POST_ADDRESS"].ToString().Trim(); //POST_ADDRESS
            objDT = null;
            return true;
        }

        public bool Getv_pfy_personOneBySP()
        {
            System.Data.DataTable objDT = null;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsv_pfy_person.GetSpecSQLObj();
            objSQL.SPConfigXMLFile = clsSysPara.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(mstrACCOUNT);
            objDT = objSQL.ExecSpReturnDT("v_pfy_person_SelectOne", values);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return false;
            }
            mstrName = objDT.Rows[0]["Name"].ToString().Trim(); //姓名
            mstrSex = objDT.Rows[0]["Sex"].ToString().Trim(); //性别
            mstrMAIL = objDT.Rows[0]["MAIL"].ToString().Trim(); //MAIL
            mstrAddress = objDT.Rows[0]["Address"].ToString().Trim(); //地址
            mstrACCOUNT = objDT.Rows[0]["ACCOUNT"].ToString().Trim(); //ACCOUNT
            mstrSCH_ID = objDT.Rows[0]["SCH_ID"].ToString().Trim(); //SCH_ID
            mstrCARD_NO = objDT.Rows[0]["CARD_NO"].ToString().Trim(); //CARD_NO
            mstrTEMP_CARD_NO = objDT.Rows[0]["TEMP_CARD_NO"].ToString().Trim(); //TEMP_CARD_NO
            mdblCARD_KIND = TransNullToDouble(objDT.Rows[0]["CARD_KIND"].ToString().Trim()); //CARD_KIND
            mdblCARD_STATE = TransNullToDouble(objDT.Rows[0]["CARD_STATE"].ToString().Trim()); //CARD_STATE
            mdteUSEFUL_LIMIT = TransNullToDate(objDT.Rows[0]["USEFUL_LIMIT"].ToString().Trim()); //USEFUL_LIMIT
            mdteRECYCLE_LIMIT = TransNullToDate(objDT.Rows[0]["RECYCLE_LIMIT"].ToString().Trim()); //RECYCLE_LIMIT
            mdblIDEN_NO = TransNullToDouble(objDT.Rows[0]["IDEN_NO"].ToString().Trim()); //IDEN_NO
            mdblNATION_NO = TransNullToDouble(objDT.Rows[0]["NATION_NO"].ToString().Trim()); //NATION_NO
            mstrPOLITICS = objDT.Rows[0]["POLITICS"].ToString().Trim(); //POLITICS
            mstrDUTY = objDT.Rows[0]["DUTY"].ToString().Trim(); //DUTY
            mdteBIRTH = TransNullToDate(objDT.Rows[0]["BIRTH"].ToString().Trim()); //BIRTH
            mstrPERSON_ID = objDT.Rows[0]["PERSON_ID"].ToString().Trim(); //PERSON_ID
            mstrSTUDENT_ID = objDT.Rows[0]["STUDENT_ID"].ToString().Trim(); //STUDENT_ID
            mstrACADEMY_NO = objDT.Rows[0]["ACADEMY_NO"].ToString().Trim(); //ACADEMY_NO
            mstrDEP_NO = objDT.Rows[0]["DEP_NO"].ToString().Trim(); //DEP_NO
            mstrCLASS_NO = objDT.Rows[0]["CLASS_NO"].ToString().Trim(); //CLASS_NO
            mstrGRADE = objDT.Rows[0]["GRADE"].ToString().Trim(); //GRADE
            mdteIN_TIME = TransNullToDate(objDT.Rows[0]["IN_TIME"].ToString().Trim()); //IN_TIME
            mstrPHONE = objDT.Rows[0]["PHONE"].ToString().Trim(); //PHONE
            mstrPOST_NO = objDT.Rows[0]["POST_NO"].ToString().Trim(); //POST_NO
            mstrPOST_ADDRESS = objDT.Rows[0]["POST_ADDRESS"].ToString().Trim(); //POST_ADDRESS
            objDT = null;
            return true;
        }

        public static System.Data.DataTable Getv_pfy_person(string strCondition)
        {
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsv_pfy_person.GetSpecSQLObj();
            strSQL = "Select * from v_pfy_person where " + strCondition;
            objDT = objSQL.GetDataTable(strSQL);
            return objDT;
        }

        public static System.Data.DataTable Getv_pfy_personByCondBySP(string strCondition)
        {
            System.Data.DataTable objDT = null;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsv_pfy_person.GetSpecSQLObj();
            objSQL.SPConfigXMLFile = clsSysPara.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(strCondition);
            objDT = objSQL.ExecSpReturnDT("v_pfy_person_SelectByCond", values);
            return objDT;
        }

        public static System.Data.DataSet Getv_pfy_personDataSetByCondBySP(string strCondition)
        {
            System.Data.DataSet objDS = null;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsv_pfy_person.GetSpecSQLObj();
            objSQL.SPConfigXMLFile = clsSysPara.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(strCondition);
            objDS = objSQL.ExecSPReturnDS("v_pfy_person_SelectByCond", values, "v_pfy_person");
            return objDS;
        }

        public static System.Data.DataSet GetDataSet_v_pfy_person(string strCondition)
        {
            string strSQL;
            System.Data.DataSet objDS = null;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsv_pfy_person.GetSpecSQLObj();
            strSQL = "Select * from v_pfy_person where " + strCondition;
            objDS = objSQL.GetDataSet(strSQL, "v_pfy_person");
            return objDS;
        }

        public static System.Data.DataSet GetDataSet_v_pfy_personByCondBySP(string strCondition)
        {
            System.Data.DataSet objDS = null;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsv_pfy_person.GetSpecSQLObj();
            objSQL.SPConfigXMLFile = clsSysPara.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(strCondition);
            objDS = objSQL.ExecSPReturnDS("v_pfy_person_SelectByCond", values, "v_pfy_person");
            return objDS;
        }

        public ArrayList Getv_pfy_personObjList(string strCondition)
        {
            ArrayList arrObjList = new ArrayList();
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsv_pfy_person.GetSpecSQLObj();
            strSQL = "Select * from v_pfy_person where " + strCondition;
            objDT = objSQL.GetDataTable(strSQL);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsv_pfy_person objv_pfy_person = new clsv_pfy_person();
                objv_pfy_person.Name = objRow["Name"].ToString().Trim(); //姓名
                objv_pfy_person.Sex = objRow["Sex"].ToString().Trim(); //性别
                objv_pfy_person.MAIL = objRow["MAIL"].ToString().Trim(); //MAIL
                objv_pfy_person.Address = objRow["Address"].ToString().Trim(); //地址
                objv_pfy_person.ACCOUNT = objRow["ACCOUNT"].ToString().Trim(); //ACCOUNT
                objv_pfy_person.SCH_ID = objRow["SCH_ID"].ToString().Trim(); //SCH_ID
                objv_pfy_person.CARD_NO = objRow["CARD_NO"].ToString().Trim(); //CARD_NO
                objv_pfy_person.TEMP_CARD_NO = objRow["TEMP_CARD_NO"].ToString().Trim(); //TEMP_CARD_NO
                objv_pfy_person.CARD_KIND = TransNullToDouble(objRow["CARD_KIND"].ToString().Trim()); //CARD_KIND
                objv_pfy_person.CARD_STATE = TransNullToDouble(objRow["CARD_STATE"].ToString().Trim()); //CARD_STATE
                objv_pfy_person.USEFUL_LIMIT = TransNullToDate(objRow["USEFUL_LIMIT"].ToString().Trim()); //USEFUL_LIMIT
                objv_pfy_person.RECYCLE_LIMIT = TransNullToDate(objRow["RECYCLE_LIMIT"].ToString().Trim()); //RECYCLE_LIMIT
                objv_pfy_person.IDEN_NO = TransNullToDouble(objRow["IDEN_NO"].ToString().Trim()); //IDEN_NO
                objv_pfy_person.NATION_NO = TransNullToDouble(objRow["NATION_NO"].ToString().Trim()); //NATION_NO
                objv_pfy_person.POLITICS = objRow["POLITICS"].ToString().Trim(); //POLITICS
                objv_pfy_person.DUTY = objRow["DUTY"].ToString().Trim(); //DUTY
                objv_pfy_person.BIRTH = TransNullToDate(objRow["BIRTH"].ToString().Trim()); //BIRTH
                objv_pfy_person.PERSON_ID = objRow["PERSON_ID"].ToString().Trim(); //PERSON_ID
                objv_pfy_person.STUDENT_ID = objRow["STUDENT_ID"].ToString().Trim(); //STUDENT_ID
                objv_pfy_person.ACADEMY_NO = objRow["ACADEMY_NO"].ToString().Trim(); //ACADEMY_NO
                objv_pfy_person.DEP_NO = objRow["DEP_NO"].ToString().Trim(); //DEP_NO
                objv_pfy_person.CLASS_NO = objRow["CLASS_NO"].ToString().Trim(); //CLASS_NO
                objv_pfy_person.GRADE = objRow["GRADE"].ToString().Trim(); //GRADE
                objv_pfy_person.IN_TIME = TransNullToDate(objRow["IN_TIME"].ToString().Trim()); //IN_TIME
                objv_pfy_person.PHONE = objRow["PHONE"].ToString().Trim(); //PHONE
                objv_pfy_person.POST_NO = objRow["POST_NO"].ToString().Trim(); //POST_NO
                objv_pfy_person.POST_ADDRESS = objRow["POST_ADDRESS"].ToString().Trim(); //POST_ADDRESS
                objv_pfy_person.ClearUpdateState();//清除修改状态,即清除脏字段信息
                arrObjList.Add(objv_pfy_person);
            }
            objDT = null;
            return arrObjList;
        }

        public clsv_pfy_person GetFirstv_pfy_person(string strCondition)
        {
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsv_pfy_person.GetSpecSQLObj();
            strSQL = "Select * from v_pfy_person where " + strCondition;
            objDT = objSQL.GetDataTable(strSQL);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return null;
            }
            DataRow objRow = objDT.Rows[0];
            clsv_pfy_person objv_pfy_person = new clsv_pfy_person();
            objv_pfy_person.Name = objRow["Name"].ToString().Trim(); //姓名
            objv_pfy_person.Sex = objRow["Sex"].ToString().Trim(); //性别
            objv_pfy_person.MAIL = objRow["MAIL"].ToString().Trim(); //MAIL
            objv_pfy_person.Address = objRow["Address"].ToString().Trim(); //地址
            objv_pfy_person.ACCOUNT = objRow["ACCOUNT"].ToString().Trim(); //ACCOUNT
            objv_pfy_person.SCH_ID = objRow["SCH_ID"].ToString().Trim(); //SCH_ID
            objv_pfy_person.CARD_NO = objRow["CARD_NO"].ToString().Trim(); //CARD_NO
            objv_pfy_person.TEMP_CARD_NO = objRow["TEMP_CARD_NO"].ToString().Trim(); //TEMP_CARD_NO
            objv_pfy_person.CARD_KIND = TransNullToDouble(objRow["CARD_KIND"].ToString().Trim()); //CARD_KIND
            objv_pfy_person.CARD_STATE = TransNullToDouble(objRow["CARD_STATE"].ToString().Trim()); //CARD_STATE
            objv_pfy_person.USEFUL_LIMIT = TransNullToDate(objRow["USEFUL_LIMIT"].ToString().Trim()); //USEFUL_LIMIT
            objv_pfy_person.RECYCLE_LIMIT = TransNullToDate(objRow["RECYCLE_LIMIT"].ToString().Trim()); //RECYCLE_LIMIT
            objv_pfy_person.IDEN_NO = TransNullToDouble(objRow["IDEN_NO"].ToString().Trim()); //IDEN_NO
            objv_pfy_person.NATION_NO = TransNullToDouble(objRow["NATION_NO"].ToString().Trim()); //NATION_NO
            objv_pfy_person.POLITICS = objRow["POLITICS"].ToString().Trim(); //POLITICS
            objv_pfy_person.DUTY = objRow["DUTY"].ToString().Trim(); //DUTY
            objv_pfy_person.BIRTH = TransNullToDate(objRow["BIRTH"].ToString().Trim()); //BIRTH
            objv_pfy_person.PERSON_ID = objRow["PERSON_ID"].ToString().Trim(); //PERSON_ID
            objv_pfy_person.STUDENT_ID = objRow["STUDENT_ID"].ToString().Trim(); //STUDENT_ID
            objv_pfy_person.ACADEMY_NO = objRow["ACADEMY_NO"].ToString().Trim(); //ACADEMY_NO
            objv_pfy_person.DEP_NO = objRow["DEP_NO"].ToString().Trim(); //DEP_NO
            objv_pfy_person.CLASS_NO = objRow["CLASS_NO"].ToString().Trim(); //CLASS_NO
            objv_pfy_person.GRADE = objRow["GRADE"].ToString().Trim(); //GRADE
            objv_pfy_person.IN_TIME = TransNullToDate(objRow["IN_TIME"].ToString().Trim()); //IN_TIME
            objv_pfy_person.PHONE = objRow["PHONE"].ToString().Trim(); //PHONE
            objv_pfy_person.POST_NO = objRow["POST_NO"].ToString().Trim(); //POST_NO
            objv_pfy_person.POST_ADDRESS = objRow["POST_ADDRESS"].ToString().Trim(); //POST_ADDRESS
            objv_pfy_person.ClearUpdateState();//清除修改状态,即清除脏字段信息
            objDT = null;
            return objv_pfy_person;
        }

        public clsv_pfy_person GetFirstv_pfy_personBySP(string strCondition)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsv_pfy_person.GetSpecSQLObj();
            objSQL.SPConfigXMLFile = clsSysPara.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(strCondition);
            objDT = objSQL.ExecSpReturnDT("v_pfy_person_SelectTop1ByCond", values);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return null;
            }
            DataRow objRow = objDT.Rows[0];
            clsv_pfy_person objv_pfy_person = new clsv_pfy_person();
            objv_pfy_person.Name = objRow["Name"].ToString().Trim(); //姓名
            objv_pfy_person.Sex = objRow["Sex"].ToString().Trim(); //性别
            objv_pfy_person.MAIL = objRow["MAIL"].ToString().Trim(); //MAIL
            objv_pfy_person.Address = objRow["Address"].ToString().Trim(); //地址
            objv_pfy_person.ACCOUNT = objRow["ACCOUNT"].ToString().Trim(); //ACCOUNT
            objv_pfy_person.SCH_ID = objRow["SCH_ID"].ToString().Trim(); //SCH_ID
            objv_pfy_person.CARD_NO = objRow["CARD_NO"].ToString().Trim(); //CARD_NO
            objv_pfy_person.TEMP_CARD_NO = objRow["TEMP_CARD_NO"].ToString().Trim(); //TEMP_CARD_NO
            objv_pfy_person.CARD_KIND = TransNullToDouble(objRow["CARD_KIND"].ToString().Trim()); //CARD_KIND
            objv_pfy_person.CARD_STATE = TransNullToDouble(objRow["CARD_STATE"].ToString().Trim()); //CARD_STATE
            objv_pfy_person.USEFUL_LIMIT = TransNullToDate(objRow["USEFUL_LIMIT"].ToString().Trim()); //USEFUL_LIMIT
            objv_pfy_person.RECYCLE_LIMIT = TransNullToDate(objRow["RECYCLE_LIMIT"].ToString().Trim()); //RECYCLE_LIMIT
            objv_pfy_person.IDEN_NO = TransNullToDouble(objRow["IDEN_NO"].ToString().Trim()); //IDEN_NO
            objv_pfy_person.NATION_NO = TransNullToDouble(objRow["NATION_NO"].ToString().Trim()); //NATION_NO
            objv_pfy_person.POLITICS = objRow["POLITICS"].ToString().Trim(); //POLITICS
            objv_pfy_person.DUTY = objRow["DUTY"].ToString().Trim(); //DUTY
            objv_pfy_person.BIRTH = TransNullToDate(objRow["BIRTH"].ToString().Trim()); //BIRTH
            objv_pfy_person.PERSON_ID = objRow["PERSON_ID"].ToString().Trim(); //PERSON_ID
            objv_pfy_person.STUDENT_ID = objRow["STUDENT_ID"].ToString().Trim(); //STUDENT_ID
            objv_pfy_person.ACADEMY_NO = objRow["ACADEMY_NO"].ToString().Trim(); //ACADEMY_NO
            objv_pfy_person.DEP_NO = objRow["DEP_NO"].ToString().Trim(); //DEP_NO
            objv_pfy_person.CLASS_NO = objRow["CLASS_NO"].ToString().Trim(); //CLASS_NO
            objv_pfy_person.GRADE = objRow["GRADE"].ToString().Trim(); //GRADE
            objv_pfy_person.IN_TIME = TransNullToDate(objRow["IN_TIME"].ToString().Trim()); //IN_TIME
            objv_pfy_person.PHONE = objRow["PHONE"].ToString().Trim(); //PHONE
            objv_pfy_person.POST_NO = objRow["POST_NO"].ToString().Trim(); //POST_NO
            objv_pfy_person.POST_ADDRESS = objRow["POST_ADDRESS"].ToString().Trim(); //POST_ADDRESS
            objv_pfy_person.ClearUpdateState();//清除修改状态,即清除脏字段信息
            objDT = null;
            return objv_pfy_person;
        }

        public override bool IsExist()
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsv_pfy_person.GetSpecSQLObj();
            if (objSQL.IsExistRecord("v_pfy_person", "ACCOUNT=" + "'" + mstrACCOUNT + "'"))
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
        /// <param name="strACCOUNT">给定的关键字值</param>
        /// <returns>返回是否存在?</returns>
        public static bool IsExist(string strACCOUNT)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsv_pfy_person.GetSpecSQLObj();
            if (objSQL.IsExistRecord("v_pfy_person", "ACCOUNT=" + "'" + strACCOUNT + "'"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsExistBySP(string strACCOUNT)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsv_pfy_person.GetSpecSQLObj();
            objSQL.SPConfigXMLFile = clsSysPara.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(strACCOUNT);
            string strIsExist = "";
            values.Add(strIsExist);
            ArrayList arrReturn = objSQL.ExecSpWithOutPut("v_pfy_person_IsExist", values);
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
        /// 获取当前表满足条件的所有记录的关键字值列表
        /// </summary>
        /// <param name="strCondtion">条件串</param>
        /// <returns>返回的关键字值列表</returns>
        public override ArrayList GetID(string strCondtion)
        {
            string strSQL;
            System.Data.DataTable objDT;
            ArrayList arrList = new ArrayList();
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsv_pfy_person.GetSpecSQLObj();
            int iRow, iCol;
            string strKeyValue;
            strSQL = "Select ACCOUNT from v_pfy_person where " + strCondtion;
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
            objSQL = clsv_pfy_person.GetSpecSQLObj();
            string strKeyValue;
            strSQL = "Select ACCOUNT from v_pfy_person where " + strCondtion;
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
            objSQL = clsv_pfy_person.GetSpecSQLObj();
            string strKeyValue;
            strSQL = "Select ACCOUNT from v_pfy_person where " + strCondtion;
            try
            {
                objDT = objSQL.GetDataTable(strSQL);
            }
            catch (Exception objException)
            {
                LogErrorS(objException, "clsv_pfy_person");
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