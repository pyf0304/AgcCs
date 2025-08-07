///----------------------
///生成代码版本：6.3.0.0
///生成日期：2008/03/05
///生成者：尹华蓓
///注意：需要数据底层（PubDataBase.dll）的版本：4.3.0.0
///========================
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Collections;
using com.taishsoft.commdb;

namespace EcardDataClass
{
    public class clsv_pfy_personEx : clsv_pfy_person
    {

        public clsv_pfy_personEx()
            : base()
        {
        }

        public clsv_pfy_personEx(string strACCOUNT)
            : base(strACCOUNT)
        {
        }

        public clsv_pfy_personEx(string strACCOUNT, bool bolIsGetv_pfy_person)
            : base(strACCOUNT, bolIsGetv_pfy_person)
        {
        }
        public static DataTable Getv_pyf_personDataTable(string strCondition)
        {
            string strSQL;
            System.Data.DataSet objDS = null;
            clsSpecSQLforSql objSQL = null;
            DataTable objDT = new DataTable();
            //获取连接对象
            objSQL = clsv_pfy_person.GetSpecSQLObj();
            strSQL = "Select * from v_pfy_person where " + strCondition;
            objDS = objSQL.GetDataSet(strSQL, "v_pfy_person");
            objDT = objDS.Tables[0];
            return objDT;
        }
        public bool Getobjv_pyf_person(DataRow objDR)
        {
            mstrName = objDR["Name"].ToString().Trim(); //姓名
            mstrSex = objDR["Sex"].ToString().Trim(); //性别
            mstrMAIL = objDR["MAIL"].ToString().Trim(); //MAIL
            mstrAddress = objDR["Address"].ToString().Trim(); //地址
            mstrACCOUNT = objDR["ACCOUNT"].ToString().Trim(); //ACCOUNT
            mstrSCH_ID = objDR["SCH_ID"].ToString().Trim(); //SCH_ID
            mstrCARD_NO = objDR["CARD_NO"].ToString().Trim(); //CARD_NO
            mstrTEMP_CARD_NO = objDR["TEMP_CARD_NO"].ToString().Trim(); //TEMP_CARD_NO
            mdblCARD_KIND = TransNullToDouble(objDR["CARD_KIND"].ToString().Trim()); //CARD_KIND
            mdblCARD_STATE = TransNullToDouble(objDR["CARD_STATE"].ToString().Trim()); //CARD_STATE
            mdteUSEFUL_LIMIT = ConvertNullToDate(objDR["USEFUL_LIMIT"].ToString().Trim()); //USEFUL_LIMIT
            mdteRECYCLE_LIMIT = ConvertNullToDate(objDR["RECYCLE_LIMIT"].ToString().Trim()); //RECYCLE_LIMIT
            mdblIDEN_NO = TransNullToDouble(objDR["IDEN_NO"].ToString().Trim()); //IDEN_NO
            mdblNATION_NO = TransNullToDouble(objDR["NATION_NO"].ToString().Trim()); //NATION_NO
            mstrPOLITICS = objDR["POLITICS"].ToString().Trim(); //POLITICS
            mstrDUTY = objDR["DUTY"].ToString().Trim(); //DUTY
            mdteBIRTH = ConvertNullToDate(objDR["BIRTH"].ToString().Trim()); //BIRTH
            mstrPERSON_ID = objDR["PERSON_ID"].ToString().Trim(); //PERSON_ID
            mstrSTUDENT_ID = objDR["STUDENT_ID"].ToString().Trim(); //STUDENT_ID
            mstrACADEMY_NO = objDR["ACADEMY_NO"].ToString().Trim(); //ACADEMY_NO
            mstrDEP_NO = objDR["DEP_NO"].ToString().Trim(); //DEP_NO
            mstrCLASS_NO = objDR["CLASS_NO"].ToString().Trim(); //CLASS_NO
            mstrGRADE = objDR["GRADE"].ToString().Trim(); //GRADE
            mdteIN_TIME = ConvertNullToDate(objDR["IN_TIME"].ToString().Trim()); //IN_TIME
            mstrPHONE = objDR["PHONE"].ToString().Trim(); //PHONE
            mstrPOST_NO = objDR["POST_NO"].ToString().Trim(); //POST_NO
            mstrPOST_ADDRESS = objDR["POST_ADDRESS"].ToString().Trim(); //POST_ADDRESS
            return true;
        }
        public DateTime ConvertNullToDate(string strDateTime)
        {
            DateTime date = new DateTime(1900, 1, 1);
            if (strDateTime == null || strDateTime=="")
            {
                return date;
            }
            else
            {
                return DateTime.Parse(strDateTime);
            }
        }
    }
}