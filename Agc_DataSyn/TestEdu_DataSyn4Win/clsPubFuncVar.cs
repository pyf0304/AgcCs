using System;
using System.Data;
using System.Configuration;
using System.Web;

using SpecData;
using System.Windows.Forms;


using System.Text;
using System.Collections.Generic;
using com.taishsoft.common;
using AGC.Entity;
using AGC.BusinessLogic;
using CommonTable.Entity;
using CommonTable.BusinessLogic;
using AGC.BusinessLogicEx;

namespace Agc_DataSyn
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
        //public static TzGeneralPlatformDll2.MenuAndPotence objMenuAndPotence = null;// (clsSysParaEN.ConfigFileName)
    
        public static List<clsUserCodePathEN> arrUserCodePathENObjLst = null;
        public static clsLog objLog = new clsLog();// null;
     

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
            //clsQxUsersEN objUsersEN = new clsQxUsersEN(clsSysParaEN.strUserId);
            //clsQxUsersBL.GetQxUsers(ref objUsersEN);
            sbMsg.AppendFormat("{0},您好！您未设置路径，将按默认路径导出！", clsSysParaEN.strUserId, objCodeTypeEN.SynCodeTypeName);
            return GetUserCodePathObjByCodeTypeId(strCodeTypeId, intApplicationTypeId);
            //throw new Exception(sbMsg.ToString());
            //return null;
        }
        public static void GetVersion()
        {
            string FilePath = "";
            if (FilePath == "")
            {
                FilePath = Application.ExecutablePath;
            }

            //获取文件版本信息
            System.Diagnostics.FileVersionInfo fvi =
                    System.Diagnostics.FileVersionInfo.GetVersionInfo(FilePath);

            MessageBox.Show(
                "版本号：" + fvi.FileVersion + "\n" +
                "主要版本号：" + fvi.FileMajorPart + "\n" +
                "次要版本号：" + fvi.FileMinorPart + "\n" +
                "内部版本号：" + fvi.FileBuildPart + "\n" +
                "专用部件号：" + fvi.FilePrivatePart,
                "版本信息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        /// <summary>
        /// 根据身份证号获取年龄
        /// </summary>
        /// <param name="strCitizenID">身份证号</param>
        /// <param name="intCurrYear">当前年</param>
        /// <returns>年龄</returns>
        public static int GetAgeByCitizenID(string strCitizenID, int intCurrYear)
        {
            if (strCitizenID.Length != 15 && strCitizenID.Length != 18)
            {
                throw new Exception(string.Format("身份证号：{0}不正确，请检查！", strCitizenID));
            }
            string strYear = "";
            if (strCitizenID.Length == 18)
            {
                 strYear = strCitizenID.Substring(6, 4);

            }
            if (strCitizenID.Length == 15)
            {
                strYear ="19" + strCitizenID.Substring(6, 2);

            }
            int intYear = 0;
            try
            {
                intYear = int.Parse(strYear);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("身份证号：{0}中年：{1}不正确，请检查！错误：{2}",
                    strCitizenID,
                    strYear,
                    objException.Message);
                throw new Exception(strMsg);
      
            }
            return intCurrYear - intYear;
        }
    }
}