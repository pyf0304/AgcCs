using System;
using System.Data;
using System.Configuration;
using System.Web;
using SpecData;
using System.Windows.Forms;

using System.Text;
using System.Collections.Generic;
using com.taishsoft.common;
using CommonTable.BusinessLogic;
using AGC.Entity;
using CommonTable.Entity;
using AGC.BusinessLogic;
using AGC.BusinessLogicEx;

namespace AgcDataSyn
{
    /// <summary>
    /// clsPubFuncVar 的摘要说明
    /// </summary>
    public class clsPubFuncVar
    {

        public clsPubFuncVar()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }

    

        public static bool bolIsDispMenu = false;
        //public static TzGeneralPlatformDll2.MenuAndPotence objMenuAndPotence = null;// (clsSysPara.ConfigFileName)
        public static clsLog objLog = new clsLog();// null;
        public static List<clsUserCodePathEN> arrUserCodePathENObjLst = null;
        //public static bool GetCurrShoolYear()
        //{
        //    string strCondition = "CurrentTermSeq = '1'";
        //    clsXzGradeBaseEN objXzGradeBaseEN = clsXzGradeBaseBL.GetFirstXzGradeBase_S(strCondition);

        //    clsSysParaEN.CurrYear = objXzGradeBaseEN.SchoolYear;
        //    clsSysParaEN.CurrTerm = objXzGradeBaseEN.SchoolTerm;

        //    strCondition = "CurrentTermSeq = '0'";
        //    clsXzGradeBaseEN objXzGradeBaseEN_Pk2 = clsXzGradeBaseBL.GetFirstXzGradeBase_S(strCondition);

        //    clsSysParaEN.Pk2SchoolYear = objXzGradeBaseEN_Pk2.SchoolYear;
        //    clsSysParaEN.Pk2SchoolTerm = objXzGradeBaseEN_Pk2.SchoolTerm;

        //    strCondition = "CurrentTermSeq = '2'";
        //    clsXzGradeBaseEN objXzGradeBaseEN_Last = clsXzGradeBaseBL.GetFirstXzGradeBase_S(strCondition);

        //    clsSysParaEN.LastSchoolYear = objXzGradeBaseEN_Last.SchoolYear;
        //    clsSysParaEN.LastSchoolTerm = objXzGradeBaseEN_Last.SchoolTerm;

        //    return true;
        //}

        /// <summary>
        /// 设置可视性
        /// </summary>
        public static void SetDgVisibility(DataGridView objDGV, string strViewName)
        {
            foreach (DataGridViewColumn objDGColumn in objDGV.Columns)
            {
                string strColumnName = objDGColumn.DataPropertyName;
                if (string.IsNullOrEmpty(strColumnName) == true)
                {
                    strColumnName = objDGColumn.HeaderText;
                }
                bool bolIsVisible = clsSetFieldVisibilityBLEx.IsVisible(clsMyConfig2.School, strViewName, strColumnName);
                if (bolIsVisible == false)
                {
                    objDGColumn.Visible = false;
                }
                else
                {
                    objDGColumn.Visible = true;
                }
                //if (strColumnName == "卡号" && clsMyConfig.School == "THXY")
                //{
                //    objDGColumn.HeaderText = "工号";
                //}
            }
        }

        public static clsUserCodePathEN GetUserCodePathObjByCodeTypeId(string strCodeTypeId, int intApplicationTypeId)
        {
            if (arrUserCodePathENObjLst == null)
            {
                string strCondition = string.Format("UserId='{0}'", clsSysParaEN.strUserId);

                arrUserCodePathENObjLst = clsUserCodePathBL.GetObjLst(strCondition);
            }
            foreach (clsUserCodePathEN objUserCodePathEN in arrUserCodePathENObjLst)
            {
                if (objUserCodePathEN.CodeTypeId == strCodeTypeId)
                {
                    return objUserCodePathEN;
                }
            }
            try
            {
                clsUserCodePathBLEx.CopyUserCodePathFromTemplate(clsSysParaEN.strUserId, intApplicationTypeId);
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
                
            }
            arrUserCodePathENObjLst = null;
            StringBuilder sbMsg = new StringBuilder();
            clsSynCodeTypeEN objCodeTypeEN = clsSynCodeTypeBL.GetObjBySynCodeTypeId_Cache(strCodeTypeId);
            clsUsersEN objUsersEN =  clsUsersBL.GetObjByUserId(clsSysParaEN.strUserId);
            sbMsg.AppendFormat("{0},您好！您未设置路径，将按默认路径导出！", objUsersEN.UserName, objCodeTypeEN.SynCodeTypeName);
            return GetUserCodePathObjByCodeTypeId(strCodeTypeId, intApplicationTypeId);
            //throw new Exception(sbMsg.ToString());
            //return null;
        }
 
    }
}