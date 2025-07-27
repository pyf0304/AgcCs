using AGC_CSV7.BusinessLogic;
using AGC_CSV7.BusinessLogicEx;
using AGC_CSV7.Entity;
using AgcCommBase;
using com.taishsoft.commexception;
using com.taishsoft.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoGCLib
{
    public class clsViewInfoBLEx_GeneCode
    {

        public static string GeneCtlControlCodeBak20170330(string strViewId, string strNetVersion, clsProjectsEN objCurrSelProject,
string strUserId, string strUserName, string strSysCodePath, string strSysCodePathBackup, string strCharEncodingId, ref string strFileName4GenCode, ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            Encoding myEncoding = clsString.GetEncodingObjByCharEncodingId(strCharEncodingId);
            string strCodeText = "";
            clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
            clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx);
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetFuncModule_AgcObjByFuncModuleAgcId_Cache(objViewInfoENEx.FuncModuleAgcId);
            try
            {

                AutoGC6Cs_CWeb_Net2005 autoGC6Cs_CWeb = new AutoGC6Cs_CWeb_Net2005(strViewId);
                if (objViewInfoENEx.ViewFldNum == 0)
                {
                    throw new clsDbObjException("界面中字段数为0,不能生成界面代码");
                }
                //if (autoGC6Cs_CWeb.TabKeyFldNum  ==  0)
                //{
                //    throw new clsDbObjException("界面相关表的表关键字段数为0,请检查界面的相关表是否有表关键字段!");
                //}

                objViewInfoENEx.BackupFolderName = strSysCodePathBackup;
                if (string.IsNullOrEmpty(strSysCodePath) == false)
                {
                    objViewInfoENEx.FolderName_Root = strSysCodePath + "\\";
                    objViewInfoENEx.FolderName = strSysCodePath + "\\" + objFuncModule.FuncModuleEnName + "\\";
                }
                else
                {
                    objViewInfoENEx.FolderName_Root = string.Format("D:\\FTP\\ClsFile\\{0}\\{1}\\ViewLayer\\", strUserId, objCurrSelProject.PrjDomain);
                    objViewInfoENEx.FolderName = string.Format("D:\\FTP\\ClsFile\\{0}\\{1}\\ViewLayer\\", strUserId, objCurrSelProject.PrjDomain) + objFuncModule.FuncModuleEnName + "\\";
                }
                objViewInfoENEx.CurrUserName = strUserName;
                strCodeText = autoGC6Cs_CWeb.A_GenCtlControlCodeforTab(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                strFileName4GenCode = objViewInfoENEx.FileName;
                strRe_ClsName = clsString.GetSimpleFName_S(objViewInfoENEx.FileName);
                strRe_FileNameWithModuleName = objViewInfoENEx.FolderName;
                clsLog4GeneViewCodeBLEx.AddLog4GeneViewCode(objViewInfoENEx.ViewId, strUserId);

            }
            catch (Exception objException)
            {
                throw objException;
            }
            return strCodeText;
        }


        public static string GeneViewCodeBak20170330(string strViewId, string strNetVersion, clsProjectsEN objCurrSelProject,
string strUserId, string strUserName, string strSysCodePath, string strSysCodePathBackup,
             string strCharEncodingId,
            ref string strFileName4GenCode, ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {

            Encoding myEncoding = clsString.GetEncodingObjByCharEncodingId(strCharEncodingId);
            clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
            clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx);
            string strCodeText = "";
            //clsViewInfoEN objViewInfo = clsViewInfoBL.GetViewInfoByViewId(strViewId);
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetFuncModule_AgcObjByFuncModuleAgcId_Cache(objViewInfoENEx.FuncModuleAgcId);
            try
            {
                AutoGC6Cs_VWeb_Net2005 autoGC6Cs_VWeb = new AutoGC6Cs_VWeb_Net2005(strViewId);
                if (objViewInfoENEx.ViewFldNum == 0)
                {
                    throw new clsDbObjException("界面中字段数为0,不能生成界面代码");
                }

                objViewInfoENEx.BackupFolderName = strSysCodePathBackup;
                if (string.IsNullOrEmpty(strSysCodePath) == false)
                {
                    objViewInfoENEx.FolderName_Root = strSysCodePath + "\\";
                    objViewInfoENEx.FolderName = strSysCodePath + "\\" + objFuncModule.FuncModuleEnName + "\\";
                }
                else
                {
                    objViewInfoENEx.FolderName_Root = string.Format("D:\\FTP\\ClsFile\\{0}\\{1}\\ViewLayer\\", strUserId, objCurrSelProject.PrjDomain);
                    objViewInfoENEx.FolderName = string.Format("D:\\FTP\\ClsFile\\{0}\\{1}\\ViewLayer\\", strUserId, objCurrSelProject.PrjDomain) + objFuncModule.FuncModuleEnName + "\\";
                }
                objViewInfoENEx.CurrUserName = strUserName;
                strCodeText = autoGC6Cs_VWeb.A_GenViewCode_Web(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                strFileName4GenCode = objViewInfoENEx.FileName;
                strRe_ClsName = clsString.GetSimpleFName_S(objViewInfoENEx.FileName);
                strRe_FileNameWithModuleName = objViewInfoENEx.FolderName;
                clsLog4GeneViewCodeBLEx.AddLog4GeneViewCode(objViewInfoENEx.ViewId, strUserId);

            }
            catch (Exception objException)
            {
                throw objException;
            }
            return strCodeText;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name = "strViewId"></param>
        /// <param name = "strNetVersion"></param>
        /// <param name = "objCurrSelProject"></param>
        /// <param name = "strUserId"></param>
        /// <param name = "strUserName"></param>
        /// <param name = "strSysCodePath"></param>
        /// <param name = "strSysCodePathBackup"></param>
        /// <param name = "strCharEncodingId">字符编码</param>
        /// <param name = "strFileName4GenCode"></param>
        /// <param name = "strRe_ClsName"></param>
        /// <param name = "strRe_FileNameWithModuleName"></param>
        /// <returns></returns>
        public static string GeneControlCodeBak20170330(string strViewId, string strNetVersion, clsProjectsEN objCurrSelProject,
                string strUserId, string strUserName, string strSysCodePath, string strSysCodePathBackup, string strCharEncodingId,
                ref string strFileName4GenCode, ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            Encoding myEncoding = clsString.GetEncodingObjByCharEncodingId(strCharEncodingId);
            string strCodeText = "";
            clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
            clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx);
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetFuncModule_AgcObjByFuncModuleAgcId_Cache(objViewInfoENEx.FuncModuleAgcId);
            try
            {

                AutoGC6Cs_CWeb_Net2005 autoGC6Cs_CWeb = new AutoGC6Cs_CWeb_Net2005(strViewId);
                if (objViewInfoENEx.ViewFldNum == 0)
                {
                    throw new clsDbObjException("界面中字段数为0,不能生成界面代码");
                }
                //if (objViewInfoENEx.TabKeyFldNum  ==  0)
                //{
                //    throw new clsDbObjException("界面相关表的表关键字段数为0,请检查界面的相关表是否有表关键字段!");
                //}

                objViewInfoENEx.BackupFolderName = strSysCodePathBackup;
                if (string.IsNullOrEmpty(strSysCodePath) == false)
                {
                    objViewInfoENEx.FolderName_Root = strSysCodePath + "\\";
                    objViewInfoENEx.FolderName = strSysCodePath + "\\" + objFuncModule.FuncModuleEnName + "\\";
                }
                else
                {
                    objViewInfoENEx.FolderName_Root = string.Format("D:\\FTP\\ClsFile\\{0}\\{1}\\ViewLayer\\", strUserId, objCurrSelProject.PrjDomain);
                    objViewInfoENEx.FolderName = string.Format("D:\\FTP\\ClsFile\\{0}\\{1}\\ViewLayer\\", strUserId, objCurrSelProject.PrjDomain) + objFuncModule.FuncModuleEnName + "\\";
                }
                objViewInfoENEx.CurrUserName = strUserName;
                strCodeText = autoGC6Cs_CWeb.A_GenViewCode_Web(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                strFileName4GenCode = objViewInfoENEx.FileName;
                strRe_ClsName = clsString.GetSimpleFName_S(objViewInfoENEx.FileName);
                strRe_FileNameWithModuleName = objViewInfoENEx.FolderName;
                clsLog4GeneViewCodeBLEx.AddLog4GeneViewCode(objViewInfoENEx.ViewId, strUserId);

            }
            catch (Exception objException)
            {
                throw objException;
            }
            return strCodeText;
        }


        public static string GeneGenViewCode_WinBak20170330(string strViewId, string strNetVersion, clsProjectsEN objCurrSelProject,
string strUserId, string strUserName, string strSysCodePath, string strSysCodePathBackup, bool bolIsUseCtl,
        enumViewTypeCodeTab strViewTypeCode, string strCharEncodingId, ref string strFileName4GenCode, ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            Encoding myEncoding = clsString.GetEncodingObjByCharEncodingId(strCharEncodingId);
            string strCodeText = "";
            clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
            clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx);
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetFuncModule_AgcObjByFuncModuleAgcId_Cache(objViewInfoENEx.FuncModuleAgcId);
            try
            {
                if (strNetVersion == "Net2003")
                {

                    AutoGC6Cs_VWin autoGC5Cs_VWin = new AutoGC6Cs_VWin(strViewId);

                    objViewInfoENEx.BackupFolderName = strSysCodePathBackup;
                    if (string.IsNullOrEmpty(strSysCodePath) == false)
                    {
                        objViewInfoENEx.FolderName_Root = strSysCodePath + "\\";
                        objViewInfoENEx.FolderName = strSysCodePath + "\\" + objFuncModule.FuncModuleEnName + "\\";
                    }
                    else
                    {
                        objViewInfoENEx.FolderName_Root = string.Format("D:\\FTP\\ClsFile\\{0}\\{1}\\Frm\\", strUserId, objCurrSelProject.PrjDomain);
                        objViewInfoENEx.FolderName = string.Format("D:\\FTP\\ClsFile\\{0}\\{1}\\Frm\\", strUserId, objCurrSelProject.PrjDomain) + objFuncModule.FuncModuleEnName + "\\";
                    }
                    objViewInfoENEx.CurrUserName = strUserName;
                    objViewInfoENEx.MainSubViewType = clsPubConst.MainSubViewType.MainView;


                    objViewInfoENEx.IsDesign = false;
                    //是否使用控件
                    objViewInfoENEx.IsUseCtl = bolIsUseCtl;

                    strCodeText = autoGC5Cs_VWin.A_GenViewCode_Win(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                    strFileName4GenCode = objViewInfoENEx.FileName;
                    strRe_ClsName = clsString.GetSimpleFName_S(objViewInfoENEx.FileName);
                    strRe_FileNameWithModuleName = objViewInfoENEx.FolderName;
                    clsLog4GeneViewCodeBLEx.AddLog4GeneViewCode(objViewInfoENEx.ViewId, strUserId);
                }
                else if (strNetVersion == "Net2005")
                {
                    AutoGC6Cs_VWin autoGC5Cs_VWin = new AutoGC6Cs_VWin(strViewId);

                    objViewInfoENEx.BackupFolderName = strSysCodePathBackup;
                    if (string.IsNullOrEmpty(strSysCodePath) == false)
                    {
                        objViewInfoENEx.FolderName_Root = strSysCodePath + "\\";
                        objViewInfoENEx.FolderName = strSysCodePath + "\\" + objFuncModule.FuncModuleEnName + "\\";
                    }
                    else
                    {
                        objViewInfoENEx.FolderName_Root = string.Format("D:\\FTP\\ClsFile\\{0}\\{1}\\Frm\\", strUserId, objCurrSelProject.PrjDomain);
                        objViewInfoENEx.FolderName = string.Format("D:\\FTP\\ClsFile\\{0}\\{1}\\Frm\\", strUserId, objCurrSelProject.PrjDomain) + objFuncModule.FuncModuleEnName + "\\";
                    }
                    objViewInfoENEx.CurrUserName = strUserName;
                    objViewInfoENEx.MainSubViewType = clsPubConst.MainSubViewType.MainView;


                    objViewInfoENEx.IsDesign = false;
                    //是否使用控件
                    objViewInfoENEx.IsUseCtl = bolIsUseCtl;

                    strCodeText = autoGC5Cs_VWin.A_GenViewCode_Win(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                    strFileName4GenCode = objViewInfoENEx.FileName;
                    strRe_ClsName = clsString.GetSimpleFName_S(objViewInfoENEx.FileName);
                    strRe_FileNameWithModuleName = objViewInfoENEx.FolderName;
                    clsLog4GeneViewCodeBLEx.AddLog4GeneViewCode(objViewInfoENEx.ViewId, strUserId);
                    //SimpleFName = clsString.GetSimpleFName_S(objViewInfoENEx.FileName);

                }
                else if (strNetVersion == "Net2010")
                {

                    AutoGC6Cs_VWin autoGC6Cs_VWin = new AutoGC6Cs_VWin(strViewId);

                    objViewInfoENEx.BackupFolderName = strSysCodePathBackup;
                    if (string.IsNullOrEmpty(strSysCodePath) == false)
                    {
                        objViewInfoENEx.FolderName_Root = strSysCodePath + "\\";
                        objViewInfoENEx.FolderName = strSysCodePath + "\\" + objFuncModule.FuncModuleEnName + "\\";
                    }
                    else
                    {
                        objViewInfoENEx.FolderName_Root = string.Format("D:\\FTP\\ClsFile\\{0}\\{1}\\Frm\\", strUserId, objCurrSelProject.PrjDomain);
                        objViewInfoENEx.FolderName = string.Format("D:\\FTP\\ClsFile\\{0}\\{1}\\Frm\\", strUserId, objCurrSelProject.PrjDomain) + objFuncModule.FuncModuleEnName + "\\";
                    }
                    objViewInfoENEx.CurrUserName = strUserName;

                    objViewInfoENEx.MainSubViewType = clsPubConst.MainSubViewType.MainView;


                    objViewInfoENEx.IsDesign = false;
                    //是否使用控件
                    objViewInfoENEx.IsUseCtl = bolIsUseCtl;

                    strCodeText = autoGC6Cs_VWin.A_GenViewCode_Win(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                    strFileName4GenCode = objViewInfoENEx.FileName;
                    strRe_ClsName = clsString.GetSimpleFName_S(objViewInfoENEx.FileName);
                    strRe_FileNameWithModuleName = objViewInfoENEx.FolderName;
                    clsLog4GeneViewCodeBLEx.AddLog4GeneViewCode(objViewInfoENEx.ViewId, strUserId);
                }
            }
            catch (Exception objException)
            {
                throw objException;
            }
            return strCodeText;
        }


        public static string GeneGenViewDesignCode_WinBak20170330(string strViewId, string strNetVersion, clsProjectsEN objCurrSelProject,
string strUserId, string strUserName, string strSysCodePath, string strSysCodePathBackup, bool bolIsUseCtl,
            enumViewTypeCodeTab strViewTypeCode, string strCharEncodingId, ref string strFileName4GenCode, ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            Encoding myEncoding = clsString.GetEncodingObjByCharEncodingId(strCharEncodingId);

            string strCodeText = "";
            clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
            clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx);
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetFuncModule_AgcObjByFuncModuleAgcId_Cache(objViewInfoENEx.FuncModuleAgcId);
            try
            {
                if (strNetVersion == "Net2003")
                {

                    AutoGC6Cs_VWin autoGC5Cs_VWin = new AutoGC6Cs_VWin(strViewId);

                    objViewInfoENEx.BackupFolderName = strSysCodePathBackup;
                    if (string.IsNullOrEmpty(strSysCodePath) == false)
                    {
                        objViewInfoENEx.FolderName_Root = strSysCodePath + "\\";
                        objViewInfoENEx.FolderName = strSysCodePath + "\\" + objFuncModule.FuncModuleEnName + "\\";
                    }
                    else
                    {
                        objViewInfoENEx.FolderName_Root = string.Format("D:\\FTP\\ClsFile\\{0}\\{1}\\Frm\\", strUserId, objCurrSelProject.PrjDomain);
                        objViewInfoENEx.FolderName = string.Format("D:\\FTP\\ClsFile\\{0}\\{1}\\Frm\\", strUserId, objCurrSelProject.PrjDomain) + objFuncModule.FuncModuleEnName + "\\";
                    }

                    objViewInfoENEx.CurrUserName = strUserName;
                    objViewInfoENEx.MainSubViewType = clsPubConst.MainSubViewType.MainView;


                    objViewInfoENEx.IsDesign = true;
                    //是否使用控件
                    objViewInfoENEx.IsUseCtl = bolIsUseCtl;

                    strCodeText = autoGC5Cs_VWin.A_GenViewCode_Win(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                    strFileName4GenCode = objViewInfoENEx.FileName;
                    strRe_ClsName = clsString.GetSimpleFName_S(objViewInfoENEx.FileName);
                    strRe_FileNameWithModuleName = objViewInfoENEx.FolderName;
                    clsLog4GeneViewCodeBLEx.AddLog4GeneViewCode(objViewInfoENEx.ViewId, strUserId);
                }
                else if (strNetVersion == "Net2005")
                {
                    AutoGC6Cs_VWin autoGC5Cs_VWin = new AutoGC6Cs_VWin(strViewId);

                    objViewInfoENEx.BackupFolderName = strSysCodePathBackup;
                    if (string.IsNullOrEmpty(strSysCodePath) == false)
                    {
                        objViewInfoENEx.FolderName_Root = strSysCodePath + "\\";
                        objViewInfoENEx.FolderName = strSysCodePath + "\\" + objFuncModule.FuncModuleEnName + "\\";
                    }
                    else
                    {
                        objViewInfoENEx.FolderName_Root = string.Format("D:\\FTP\\ClsFile\\{0}\\{1}\\Frm\\", strUserId, objCurrSelProject.PrjDomain);
                        objViewInfoENEx.FolderName = string.Format("D:\\FTP\\ClsFile\\{0}\\{1}\\Frm\\", strUserId, objCurrSelProject.PrjDomain) + objFuncModule.FuncModuleEnName + "\\";
                    }
                    objViewInfoENEx.CurrUserName = strUserName;
                    objViewInfoENEx.MainSubViewType = clsPubConst.MainSubViewType.MainView;

                    objViewInfoENEx.IsDesign = true;
                    //是否使用控件
                    objViewInfoENEx.IsUseCtl = bolIsUseCtl;

                    strCodeText = autoGC5Cs_VWin.A_GenViewCode_Win(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                    strFileName4GenCode = objViewInfoENEx.FileName;
                    strRe_ClsName = clsString.GetSimpleFName_S(objViewInfoENEx.FileName);
                    strRe_FileNameWithModuleName = objViewInfoENEx.FolderName;
                    clsLog4GeneViewCodeBLEx.AddLog4GeneViewCode(objViewInfoENEx.ViewId, strUserId);
                    //SimpleFName = clsString.GetSimpleFName_S(objViewInfoENEx.FileName);

                }
                else if (strNetVersion == "Net2010")
                {

                    AutoGC6Cs_VWin autoGC5Cs_VWin = new AutoGC6Cs_VWin(strViewId);

                    objViewInfoENEx.BackupFolderName = strSysCodePathBackup;
                    if (string.IsNullOrEmpty(strSysCodePath) == false)
                    {
                        objViewInfoENEx.FolderName_Root = strSysCodePath + "\\";
                        objViewInfoENEx.FolderName = strSysCodePath + "\\" + objFuncModule.FuncModuleEnName + "\\";
                    }
                    else
                    {
                        objViewInfoENEx.FolderName_Root = string.Format("D:\\FTP\\ClsFile\\{0}\\{1}\\Frm\\", strUserId, objCurrSelProject.PrjDomain);
                        objViewInfoENEx.FolderName = string.Format("D:\\FTP\\ClsFile\\{0}\\{1}\\Frm\\", strUserId, objCurrSelProject.PrjDomain) + objFuncModule.FuncModuleEnName + "\\";
                    }
                    objViewInfoENEx.CurrUserName = strUserName;
                    objViewInfoENEx.MainSubViewType = clsPubConst.MainSubViewType.MainView;

                    objViewInfoENEx.IsDesign = true;
                    //是否使用控件
                    objViewInfoENEx.IsUseCtl = bolIsUseCtl;

                    strCodeText = autoGC5Cs_VWin.A_GenViewCode_Win(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                    strFileName4GenCode = objViewInfoENEx.FileName;
                    strRe_ClsName = clsString.GetSimpleFName_S(objViewInfoENEx.FileName);
                    strRe_FileNameWithModuleName = objViewInfoENEx.FolderName;
                    clsLog4GeneViewCodeBLEx.AddLog4GeneViewCode(objViewInfoENEx.ViewId, strUserId);
                }
            }
            catch (Exception objException)
            {
                throw objException;
            }
            return strCodeText;
        }


        public static string GeneGenViewCode_Sub_WinBak20170330(string strViewId, string strNetVersion, clsProjectsEN objCurrSelProject,
string strUserId, string strUserName, string strSysCodePath, string strSysCodePathBackup,
            bool bolIsUseCtl, enumViewTypeCodeTab strViewTypeCode,
             string strCharEncodingId, ref string strFileName4GenCode, ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {

            Encoding myEncoding = clsString.GetEncodingObjByCharEncodingId(strCharEncodingId);
            string strCodeText = "";
            clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
            clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx);
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetFuncModule_AgcObjByFuncModuleAgcId_Cache(objViewInfoENEx.FuncModuleAgcId);
            try
            {
                if (strNetVersion == "Net2003")
                {

                    AutoGC6Cs_VWin autoGC5Cs_VWin = new AutoGC6Cs_VWin(strViewId);

                    objViewInfoENEx.BackupFolderName = strSysCodePathBackup;
                    if (string.IsNullOrEmpty(strSysCodePath) == false)
                    {
                        objViewInfoENEx.FolderName_Root = strSysCodePath + "\\";
                        objViewInfoENEx.FolderName = strSysCodePath + "\\" + objFuncModule.FuncModuleEnName + "\\";
                    }
                    else
                    {
                        objViewInfoENEx.FolderName_Root = string.Format("D:\\FTP\\ClsFile\\{0}\\{1}\\Frm\\", strUserId, objCurrSelProject.PrjDomain);
                        objViewInfoENEx.FolderName = string.Format("D:\\FTP\\ClsFile\\{0}\\{1}\\Frm\\", strUserId, objCurrSelProject.PrjDomain) + objFuncModule.FuncModuleEnName + "\\";
                    }
                    objViewInfoENEx.CurrUserName = strUserName;
                    objViewInfoENEx.MainSubViewType = clsPubConst.MainSubViewType.SubView;
                    //objViewInfoENEx.NetVersion = "2005";

                    objViewInfoENEx.IsDesign = false;
                    //是否使用控件
                    objViewInfoENEx.IsUseCtl = bolIsUseCtl;

                    strCodeText = autoGC5Cs_VWin.A_GenViewCode_Win(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                    strFileName4GenCode = objViewInfoENEx.FileName;
                    strRe_ClsName = clsString.GetSimpleFName_S(objViewInfoENEx.FileName);
                    strRe_FileNameWithModuleName = objViewInfoENEx.FolderName;
                    clsLog4GeneViewCodeBLEx.AddLog4GeneViewCode(objViewInfoENEx.ViewId, strUserId);
                }
                else if (strNetVersion == "Net2005")
                {
                    AutoGC6Cs_VWin autoGC5Cs_VWin = new AutoGC6Cs_VWin(strViewId);

                    objViewInfoENEx.BackupFolderName = strSysCodePathBackup;
                    if (string.IsNullOrEmpty(strSysCodePath) == false)
                    {
                        objViewInfoENEx.FolderName_Root = strSysCodePath + "\\";
                        objViewInfoENEx.FolderName = strSysCodePath + "\\" + objFuncModule.FuncModuleEnName + "\\";
                    }
                    else
                    {
                        objViewInfoENEx.FolderName_Root = string.Format("D:\\FTP\\ClsFile\\{0}\\{1}\\Frm\\", strUserId, objCurrSelProject.PrjDomain);
                        objViewInfoENEx.FolderName = string.Format("D:\\FTP\\ClsFile\\{0}\\{1}\\Frm\\", strUserId, objCurrSelProject.PrjDomain) + objFuncModule.FuncModuleEnName + "\\";
                    }
                    objViewInfoENEx.CurrUserName = strUserName;
                    objViewInfoENEx.MainSubViewType = clsPubConst.MainSubViewType.SubView;

                    objViewInfoENEx.IsDesign = false;
                    //是否使用控件
                    objViewInfoENEx.IsUseCtl = bolIsUseCtl;

                    strCodeText = autoGC5Cs_VWin.A_GenViewCode_Win(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                    strFileName4GenCode = objViewInfoENEx.FileName;
                    strRe_ClsName = clsString.GetSimpleFName_S(objViewInfoENEx.FileName);
                    strRe_FileNameWithModuleName = objViewInfoENEx.FolderName;
                    clsLog4GeneViewCodeBLEx.AddLog4GeneViewCode(objViewInfoENEx.ViewId, strUserId);
                    //SimpleFName = clsString.GetSimpleFName_S(objViewInfoENEx.FileName);

                }
                else if (strNetVersion == "Net2010")
                {

                    AutoGC6Cs_VWin autoGC5Cs_VWin = new AutoGC6Cs_VWin(strViewId);

                    objViewInfoENEx.BackupFolderName = strSysCodePathBackup;
                    if (string.IsNullOrEmpty(strSysCodePath) == false)
                    {
                        objViewInfoENEx.FolderName_Root = strSysCodePath + "\\";
                        objViewInfoENEx.FolderName = strSysCodePath + "\\" + objFuncModule.FuncModuleEnName + "\\";
                    }
                    else
                    {
                        objViewInfoENEx.FolderName_Root = string.Format("D:\\FTP\\ClsFile\\{0}\\{1}\\Frm\\", strUserId, objCurrSelProject.PrjDomain);
                        objViewInfoENEx.FolderName = string.Format("D:\\FTP\\ClsFile\\{0}\\{1}\\Frm\\", strUserId, objCurrSelProject.PrjDomain) + objFuncModule.FuncModuleEnName + "\\";
                    }
                    objViewInfoENEx.CurrUserName = strUserName;
                    objViewInfoENEx.MainSubViewType = clsPubConst.MainSubViewType.SubView;

                    objViewInfoENEx.IsDesign = false;
                    //是否使用控件
                    objViewInfoENEx.IsUseCtl = bolIsUseCtl;

                    strCodeText = autoGC5Cs_VWin.A_GenViewCode_Win(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                    strFileName4GenCode = objViewInfoENEx.FileName;
                    strRe_ClsName = clsString.GetSimpleFName_S(objViewInfoENEx.FileName);
                    strRe_FileNameWithModuleName = objViewInfoENEx.FolderName;
                    clsLog4GeneViewCodeBLEx.AddLog4GeneViewCode(objViewInfoENEx.ViewId, strUserId);
                }
            }
            catch (Exception objException)
            {
                throw objException;
            }
            return strCodeText;
        }

        public static string GeneGenViewDesignCode_Sub_WinBak20170330(string strViewId, string strNetVersion, clsProjectsEN objCurrSelProject,
string strUserId, string strUserName, string strSysCodePath, string strSysCodePathBackup,
            bool bolIsUseCtl, enumViewTypeCodeTab strViewTypeCode, string strCharEncodingId, ref string strFileName4GenCode, ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            Encoding myEncoding = clsString.GetEncodingObjByCharEncodingId(strCharEncodingId);
            string strCodeText = "";
            clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
            clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx);
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetFuncModule_AgcObjByFuncModuleAgcId_Cache(objViewInfoENEx.FuncModuleAgcId);
            try
            {
                if (strNetVersion == "Net2003")
                {

                    AutoGC6Cs_VWin autoGC5Cs_VWin = new AutoGC6Cs_VWin(strViewId);

                    objViewInfoENEx.BackupFolderName = strSysCodePathBackup;
                    if (string.IsNullOrEmpty(strSysCodePath) == false)
                    {
                        objViewInfoENEx.FolderName_Root = strSysCodePath + "\\";
                        objViewInfoENEx.FolderName = strSysCodePath + "\\" + objFuncModule.FuncModuleEnName + "\\";
                    }
                    else
                    {
                        objViewInfoENEx.FolderName_Root = string.Format("D:\\FTP\\ClsFile\\{0}\\{1}\\Frm\\", strUserId, objCurrSelProject.PrjDomain);
                        objViewInfoENEx.FolderName = string.Format("D:\\FTP\\ClsFile\\{0}\\{1}\\Frm\\", strUserId, objCurrSelProject.PrjDomain) + objFuncModule.FuncModuleEnName + "\\";
                    }
                    objViewInfoENEx.CurrUserName = strUserName;
                    objViewInfoENEx.MainSubViewType = clsPubConst.MainSubViewType.SubView;

                    objViewInfoENEx.IsDesign = true;
                    //是否使用控件
                    objViewInfoENEx.IsUseCtl = bolIsUseCtl;

                    strCodeText = autoGC5Cs_VWin.A_GenViewCode_Win(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                    strFileName4GenCode = objViewInfoENEx.FileName;
                    strRe_ClsName = clsString.GetSimpleFName_S(objViewInfoENEx.FileName);
                    strRe_FileNameWithModuleName = objViewInfoENEx.FolderName;
                    clsLog4GeneViewCodeBLEx.AddLog4GeneViewCode(objViewInfoENEx.ViewId, strUserId);
                }
                else if (strNetVersion == "Net2005")
                {
                    AutoGC6Cs_VWin autoGC5Cs_VWin = new AutoGC6Cs_VWin(strViewId);

                    objViewInfoENEx.BackupFolderName = strSysCodePathBackup;
                    if (string.IsNullOrEmpty(strSysCodePath) == false)
                    {
                        objViewInfoENEx.FolderName_Root = strSysCodePath + "\\";
                        objViewInfoENEx.FolderName = strSysCodePath + "\\" + objFuncModule.FuncModuleEnName + "\\";
                    }
                    else
                    {
                        objViewInfoENEx.FolderName_Root = string.Format("D:\\FTP\\ClsFile\\{0}\\{1}\\Frm\\", strUserId, objCurrSelProject.PrjDomain);
                        objViewInfoENEx.FolderName = string.Format("D:\\FTP\\ClsFile\\{0}\\{1}\\Frm\\", strUserId, objCurrSelProject.PrjDomain) + objFuncModule.FuncModuleEnName + "\\";
                    }
                    objViewInfoENEx.CurrUserName = strUserName;
                    objViewInfoENEx.MainSubViewType = clsPubConst.MainSubViewType.SubView;

                    objViewInfoENEx.IsDesign = true;
                    //是否使用控件
                    objViewInfoENEx.IsUseCtl = bolIsUseCtl;

                    strCodeText = autoGC5Cs_VWin.A_GenViewCode_Win(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                    strFileName4GenCode = objViewInfoENEx.FileName;
                    strRe_ClsName = clsString.GetSimpleFName_S(objViewInfoENEx.FileName);
                    strRe_FileNameWithModuleName = objViewInfoENEx.FolderName;
                    clsLog4GeneViewCodeBLEx.AddLog4GeneViewCode(objViewInfoENEx.ViewId, strUserId);
                    //SimpleFName = clsString.GetSimpleFName_S(objViewInfoENEx.FileName);

                }
                else if (strNetVersion == "Net2010")
                {

                    AutoGC6Cs_VWin autoGC5Cs_VWin = new AutoGC6Cs_VWin(strViewId);

                    objViewInfoENEx.BackupFolderName = strSysCodePathBackup;
                    if (string.IsNullOrEmpty(strSysCodePath) == false)
                    {
                        objViewInfoENEx.FolderName_Root = strSysCodePath + "\\";
                        objViewInfoENEx.FolderName = strSysCodePath + "\\" + objFuncModule.FuncModuleEnName + "\\";
                    }
                    else
                    {
                        objViewInfoENEx.FolderName_Root = string.Format("D:\\FTP\\ClsFile\\{0}\\{1}\\Frm\\", strUserId, objCurrSelProject.PrjDomain);
                        objViewInfoENEx.FolderName = string.Format("D:\\FTP\\ClsFile\\{0}\\{1}\\Frm\\", strUserId, objCurrSelProject.PrjDomain) + objFuncModule.FuncModuleEnName + "\\";
                    }
                    objViewInfoENEx.CurrUserName = strUserName;
                    objViewInfoENEx.MainSubViewType = clsPubConst.MainSubViewType.SubView;

                    objViewInfoENEx.IsDesign = true;
                    //是否使用控件
                    objViewInfoENEx.IsUseCtl = bolIsUseCtl;

                    strCodeText = autoGC5Cs_VWin.A_GenViewCode_Win(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                    strFileName4GenCode = objViewInfoENEx.FileName;
                    strRe_ClsName = clsString.GetSimpleFName_S(objViewInfoENEx.FileName);
                    strRe_FileNameWithModuleName = objViewInfoENEx.FolderName;
                    clsLog4GeneViewCodeBLEx.AddLog4GeneViewCode(objViewInfoENEx.ViewId, strUserId);
                }
            }
            catch (Exception objException)
            {
                throw objException;
            }
            return strCodeText;
        }


        public static string GeneCtlViewCodeBak20170330(string strViewId, string strNetVersion, clsProjectsEN objCurrSelProject,
string strUserId, string strUserName,
          string strSysCodePath, string strSysCodePathBackup,

          ref string strFileName4GenCode, ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {

            string strCodeText = "";
            clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
            clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx);
            //clsFieldTabBLEx.strPrjId = objViewInfoENEx.PrjId;

            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetFuncModule_AgcObjByFuncModuleAgcId_Cache(objViewInfoENEx.FuncModuleAgcId);
            try
            {
                if (strNetVersion == "Net2003")
                {

                    AutoGC7Cs_VWeb_Net2005 autoGC5Cs_VWeb = new AutoGC7Cs_VWeb_Net2005(strViewId);
                    //if (autoGC5Cs_VWeb.ViewFldNum  ==  0)
                    //{
                    //    throw new clsDbObjException("界面中字段数为0,不能生成界面代码");
                    //}

                    objViewInfoENEx.BackupFolderName = strSysCodePathBackup;
                    if (string.IsNullOrEmpty(strSysCodePath) == false)
                    {
                        objViewInfoENEx.FolderName_Root = strSysCodePath + "\\";
                        objViewInfoENEx.FolderName = strSysCodePath + "\\" + objFuncModule.FuncModuleEnName + "\\";
                    }
                    else
                    {
                        objViewInfoENEx.FolderName_Root = string.Format("D:\\FTP\\ClsFile\\{0}\\{1}\\ViewLayer\\", strUserId, objCurrSelProject.PrjDomain);
                        objViewInfoENEx.FolderName = string.Format("D:\\FTP\\ClsFile\\{0}\\{1}\\ViewLayer\\", strUserId, objCurrSelProject.PrjDomain) + objFuncModule.FuncModuleEnName + "\\";
                    }
                    objViewInfoENEx.CurrUserName = strUserName;
                    strCodeText = autoGC5Cs_VWeb.A_GenCtlViewCodeforTab(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);

                    //clsPubFun4BLEx.SaveClassContentToFile(objViewInfoENEx.WinUserCtlCsFName, strCodeText, 
                    //    objViewInfoENEx.FolderName_Root, myEncoding);


                    strFileName4GenCode = objViewInfoENEx.FileName;
                    strRe_ClsName = clsString.GetSimpleFName_S(objViewInfoENEx.FileName);
                    strRe_FileNameWithModuleName = objViewInfoENEx.FolderName;
                    clsLog4GeneViewCodeBLEx.AddLog4GeneViewCode(objViewInfoENEx.ViewId, strUserId);
                }
                else if (strNetVersion == "Net2005")
                {

                    AutoGC7Cs_VWeb_Net2005 autoGC5Cs_VWeb = new AutoGC7Cs_VWeb_Net2005(strViewId);
                    //if (autoGC5Cs_VWeb.ViewFldNum  ==  0)
                    //{
                    //    throw new clsDbObjException("界面中字段数为0,不能生成界面代码");
                    //}

                    objViewInfoENEx.BackupFolderName = strSysCodePathBackup;
                    if (string.IsNullOrEmpty(strSysCodePath) == false)
                    {
                        objViewInfoENEx.FolderName_Root = strSysCodePath + "\\";
                        objViewInfoENEx.FolderName = strSysCodePath + "\\" + objFuncModule.FuncModuleEnName + "\\";
                    }
                    else
                    {
                        objViewInfoENEx.FolderName_Root = string.Format("D:\\FTP\\ClsFile\\{0}\\{1}\\ViewLayer\\", strUserId, objCurrSelProject.PrjDomain);
                        objViewInfoENEx.FolderName = string.Format("D:\\FTP\\ClsFile\\{0}\\{1}\\ViewLayer\\", strUserId, objCurrSelProject.PrjDomain) + objFuncModule.FuncModuleEnName + "\\";
                    }
                    objViewInfoENEx.CurrUserName = strUserName;
                    strCodeText = autoGC5Cs_VWeb.A_GenCtlViewCodeforTab(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                    strFileName4GenCode = objViewInfoENEx.FileName;
                    strRe_ClsName = clsString.GetSimpleFName_S(objViewInfoENEx.FileName);
                    strRe_FileNameWithModuleName = objViewInfoENEx.FolderName;
                    clsLog4GeneViewCodeBLEx.AddLog4GeneViewCode(objViewInfoENEx.ViewId, strUserId);
                }
                else if (strNetVersion == "Net2010")
                {

                    AutoGC7Cs_VWeb_Net2005 autoGC6Cs_VWeb = new AutoGC7Cs_VWeb_Net2005(strViewId);
                    //if (autoGC6Cs_VWeb.ViewFldNum  ==  0)
                    //{
                    //    throw new clsDbObjException("界面中字段数为0,不能生成界面代码");
                    //}

                    objViewInfoENEx.BackupFolderName = strSysCodePathBackup;
                    if (string.IsNullOrEmpty(strSysCodePath) == false)
                    {
                        objViewInfoENEx.FolderName_Root = strSysCodePath + "\\";
                        objViewInfoENEx.FolderName = strSysCodePath + "\\" + objFuncModule.FuncModuleEnName + "\\";
                    }
                    else
                    {
                        objViewInfoENEx.FolderName_Root = string.Format("D:\\FTP\\ClsFile\\{0}\\{1}\\ViewLayer\\", strUserId, objCurrSelProject.PrjDomain);
                        objViewInfoENEx.FolderName = string.Format("D:\\FTP\\ClsFile\\{0}\\{1}\\ViewLayer\\", strUserId, objCurrSelProject.PrjDomain) + objFuncModule.FuncModuleEnName + "\\";
                    }
                    objViewInfoENEx.CurrUserName = strUserName;
                    strCodeText = autoGC6Cs_VWeb.A_GenCtlViewCodeforTab(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                    strFileName4GenCode = objViewInfoENEx.FileName;
                    strRe_ClsName = clsString.GetSimpleFName_S(objViewInfoENEx.FileName);
                    strRe_FileNameWithModuleName = objViewInfoENEx.FolderName;
                    clsLog4GeneViewCodeBLEx.AddLog4GeneViewCode(objViewInfoENEx.ViewId, strUserId);
                }
            }
            catch (Exception objException)
            {
                throw objException;
            }
            return strCodeText;
        }


        public static string GeneCtlControlCodeBak20170330(string strViewId, string strNetVersion, clsProjectsEN objCurrSelProject,
string strUserId, string strUserName, string strSysCodePath, string strSysCodePathBackup, ref string strFileName4GenCode, ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {

            string strCodeText = "";
            clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
            clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx);

            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetFuncModule_AgcObjByFuncModuleAgcId_Cache(objViewInfoENEx.FuncModuleAgcId);
            try
            {
                if (strNetVersion == "Net2003")
                {

                    AutoGC7Cs_CWeb_Net2005 autoGC5Cs_CWeb = new AutoGC7Cs_CWeb_Net2005(strViewId);
                    //if (objViewInfoENEx.ViewFldNum  ==  0)
                    //{
                    //    throw new clsDbObjException("界面中字段数为0,不能生成界面代码");
                    //}
                    //if (autoGC5Cs_CWeb.TabKeyFldNum  ==  0)
                    //{
                    //    throw new clsDbObjException("界面相关表的表关键字段数为0,请检查界面的相关表是否有表关键字段!");
                    //}

                    objViewInfoENEx.BackupFolderName = strSysCodePathBackup;
                    if (string.IsNullOrEmpty(strSysCodePath) == false)
                    {
                        objViewInfoENEx.FolderName_Root = strSysCodePath + "\\";
                        objViewInfoENEx.FolderName = strSysCodePath + "\\" + objFuncModule.FuncModuleEnName + "\\";
                    }
                    else
                    {
                        objViewInfoENEx.FolderName_Root = string.Format("D:\\FTP\\ClsFile\\{0}\\{1}\\ViewLayer\\", strUserId, objCurrSelProject.PrjDomain);
                        objViewInfoENEx.FolderName = string.Format("D:\\FTP\\ClsFile\\{0}\\{1}\\ViewLayer\\", strUserId, objCurrSelProject.PrjDomain) + objFuncModule.FuncModuleEnName + "\\";
                    }
                    objViewInfoENEx.CurrUserName = strUserName;
                    strCodeText = autoGC5Cs_CWeb.A_GenCtlControlCodeforTab(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                    strFileName4GenCode = objViewInfoENEx.FileName;
                    strRe_ClsName = clsString.GetSimpleFName_S(objViewInfoENEx.FileName);
                    strRe_FileNameWithModuleName = objViewInfoENEx.FolderName;
                    clsLog4GeneViewCodeBLEx.AddLog4GeneViewCode(objViewInfoENEx.ViewId, strUserId);
                }
                else if (strNetVersion == "Net2005")
                {

                    AutoGC7Cs_CWeb_Net2005 autoGC5Cs_CWeb = new AutoGC7Cs_CWeb_Net2005(strViewId);
                    //if (objViewInfoENEx.ViewFldNum  ==  0)
                    //{
                    //    throw new clsDbObjException("界面中字段数为0,不能生成界面代码");
                    //}
                    //if (autoGC5Cs_CWeb.TabKeyFldNum  ==  0)
                    //{
                    //    throw new clsDbObjException("界面相关表的表关键字段数为0,请检查界面的相关表是否有表关键字段!");
                    //}

                    objViewInfoENEx.BackupFolderName = strSysCodePathBackup;
                    if (string.IsNullOrEmpty(strSysCodePath) == false)
                    {
                        objViewInfoENEx.FolderName_Root = strSysCodePath + "\\";
                        objViewInfoENEx.FolderName = strSysCodePath + "\\" + objFuncModule.FuncModuleEnName + "\\";
                    }
                    else
                    {
                        objViewInfoENEx.FolderName_Root = string.Format("D:\\FTP\\ClsFile\\{0}\\{1}\\ViewLayer\\", strUserId, objCurrSelProject.PrjDomain);
                        objViewInfoENEx.FolderName = string.Format("D:\\FTP\\ClsFile\\{0}\\{1}\\ViewLayer\\", strUserId, objCurrSelProject.PrjDomain) + objFuncModule.FuncModuleEnName + "\\";
                    }
                    objViewInfoENEx.CurrUserName = strUserName;
                    strCodeText = autoGC5Cs_CWeb.A_GenCtlControlCodeforTab(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                    strFileName4GenCode = objViewInfoENEx.FileName;
                    strRe_ClsName = clsString.GetSimpleFName_S(objViewInfoENEx.FileName);
                    strRe_FileNameWithModuleName = objViewInfoENEx.FolderName;
                    clsLog4GeneViewCodeBLEx.AddLog4GeneViewCode(objViewInfoENEx.ViewId, strUserId);
                }
                else if (strNetVersion == "Net2010")
                {

                    AutoGC7Cs_CWeb_Net2005 autoGC6Cs_CWeb = new AutoGC7Cs_CWeb_Net2005(strViewId);
                    //if (objViewInfoENEx.ViewFldNum  ==  0)
                    //{
                    //    throw new clsDbObjException("界面中字段数为0,不能生成界面代码");
                    //}
                    //if (autoGC6Cs_CWeb.TabKeyFldNum  ==  0)
                    //{
                    //    throw new clsDbObjException("界面相关表的表关键字段数为0,请检查界面的相关表是否有表关键字段!");
                    //}

                    objViewInfoENEx.BackupFolderName = strSysCodePathBackup;
                    if (string.IsNullOrEmpty(strSysCodePath) == false)
                    {
                        objViewInfoENEx.FolderName_Root = strSysCodePath + "\\";
                        objViewInfoENEx.FolderName = strSysCodePath + "\\" + objFuncModule.FuncModuleEnName + "\\";
                    }
                    else
                    {
                        objViewInfoENEx.FolderName_Root = string.Format("D:\\FTP\\ClsFile\\{0}\\{1}\\ViewLayer\\", strUserId, objCurrSelProject.PrjDomain);
                        objViewInfoENEx.FolderName = string.Format("D:\\FTP\\ClsFile\\{0}\\{1}\\ViewLayer\\", strUserId, objCurrSelProject.PrjDomain) + objFuncModule.FuncModuleEnName + "\\";
                    }
                    objViewInfoENEx.CurrUserName = strUserName;
                    strCodeText = autoGC6Cs_CWeb.A_GenCtlControlCodeforTab(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                    strFileName4GenCode = objViewInfoENEx.FileName;
                    strRe_ClsName = clsString.GetSimpleFName_S(objViewInfoENEx.FileName);
                    strRe_FileNameWithModuleName = objViewInfoENEx.FolderName;
                    clsLog4GeneViewCodeBLEx.AddLog4GeneViewCode(objViewInfoENEx.ViewId, strUserId);
                }
            }
            catch (Exception objException)
            {
                throw objException;
            }
            return strCodeText;
        }




        public static string GeneViewCodeBak20170330(string strViewId, string strNetVersion, clsProjectsEN objCurrSelProject,
string strUserId, string strUserName, string strSysCodePath, string strSysCodePathBackup,
            ref string strFileName4GenCode, ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {

            string strCodeText = "";
            clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
            clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx);

            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetFuncModule_AgcObjByFuncModuleAgcId_Cache(objViewInfoENEx.FuncModuleAgcId);
            try
            {
                if (strNetVersion == "Net2003")
                {

                    AutoGC7Cs_VWeb_Net2005 autoGC5Cs_VWeb = new AutoGC7Cs_VWeb_Net2005(strViewId);
                    //if (objViewInfoENEx.ViewFldNum  ==  0)
                    //{
                    //    throw new clsDbObjException("界面中字段数为0,不能生成界面代码");
                    //}

                    objViewInfoENEx.BackupFolderName = strSysCodePathBackup;
                    if (string.IsNullOrEmpty(strSysCodePath) == false)
                    {
                        objViewInfoENEx.FolderName_Root = strSysCodePath + "\\";
                        objViewInfoENEx.FolderName = strSysCodePath + "\\" + objFuncModule.FuncModuleEnName + "\\";
                    }
                    else
                    {
                        objViewInfoENEx.FolderName_Root = string.Format("D:\\FTP\\ClsFile\\{0}\\{1}\\ViewLayer\\", strUserId, objCurrSelProject.PrjDomain);
                        objViewInfoENEx.FolderName = string.Format("D:\\FTP\\ClsFile\\{0}\\{1}\\ViewLayer\\", strUserId, objCurrSelProject.PrjDomain) + objFuncModule.FuncModuleEnName + "\\";
                    }
                    objViewInfoENEx.CurrUserName = strUserName;
                    strCodeText = autoGC5Cs_VWeb.A_GenViewCode_Web(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                    strFileName4GenCode = objViewInfoENEx.FileName;
                    strRe_ClsName = clsString.GetSimpleFName_S(objViewInfoENEx.FileName);
                    strRe_FileNameWithModuleName = objViewInfoENEx.FolderName;
                    clsLog4GeneViewCodeBLEx.AddLog4GeneViewCode(objViewInfoENEx.ViewId, strUserId);
                }
                else if (strNetVersion == "Net2005")
                {

                    AutoGC7Cs_VWeb_Net2005 autoGC5Cs_VWeb = new AutoGC7Cs_VWeb_Net2005(strViewId);
                    //if (objViewInfoENEx.ViewFldNum  ==  0)
                    //{
                    //    throw new clsDbObjException("界面中字段数为0,不能生成界面代码");
                    //}

                    objViewInfoENEx.BackupFolderName = strSysCodePathBackup;
                    if (string.IsNullOrEmpty(strSysCodePath) == false)
                    {
                        objViewInfoENEx.FolderName_Root = strSysCodePath + "\\";
                        objViewInfoENEx.FolderName = strSysCodePath + "\\" + objFuncModule.FuncModuleEnName + "\\";
                    }
                    else
                    {
                        objViewInfoENEx.FolderName_Root = string.Format("D:\\FTP\\ClsFile\\{0}\\{1}\\ViewLayer\\", strUserId, objCurrSelProject.PrjDomain);
                        objViewInfoENEx.FolderName = string.Format("D:\\FTP\\ClsFile\\{0}\\{1}\\ViewLayer\\", strUserId, objCurrSelProject.PrjDomain) + objFuncModule.FuncModuleEnName + "\\";
                    }
                    objViewInfoENEx.CurrUserName = strUserName;
                    strCodeText = autoGC5Cs_VWeb.A_GenViewCode_Web(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                    strFileName4GenCode = objViewInfoENEx.FileName;
                    strRe_ClsName = clsString.GetSimpleFName_S(objViewInfoENEx.FileName);
                    strRe_FileNameWithModuleName = objViewInfoENEx.FolderName;
                    clsLog4GeneViewCodeBLEx.AddLog4GeneViewCode(objViewInfoENEx.ViewId, strUserId);
                }
                else if (strNetVersion == "Net2010")
                {

                    AutoGC7Cs_VWeb_Net2005 autoGC6Cs_VWeb = new AutoGC7Cs_VWeb_Net2005(strViewId);
                    //if (objViewInfoENEx.ViewFldNum  ==  0)
                    //{
                    //    throw new clsDbObjException("界面中字段数为0,不能生成界面代码");
                    //}

                    objViewInfoENEx.BackupFolderName = strSysCodePathBackup;
                    if (string.IsNullOrEmpty(strSysCodePath) == false)
                    {
                        objViewInfoENEx.FolderName_Root = strSysCodePath + "\\";
                        objViewInfoENEx.FolderName = strSysCodePath + "\\" + objFuncModule.FuncModuleEnName + "\\";
                    }
                    else
                    {
                        objViewInfoENEx.FolderName_Root = string.Format("D:\\FTP\\ClsFile\\{0}\\{1}\\ViewLayer\\", strUserId, objCurrSelProject.PrjDomain);
                        objViewInfoENEx.FolderName = string.Format("D:\\FTP\\ClsFile\\{0}\\{1}\\ViewLayer\\", strUserId, objCurrSelProject.PrjDomain) + objFuncModule.FuncModuleEnName + "\\";
                    }
                    objViewInfoENEx.CurrUserName = strUserName;
                    strCodeText = autoGC6Cs_VWeb.A_GenViewCode_Web(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                    strFileName4GenCode = objViewInfoENEx.FileName;
                    strRe_ClsName = clsString.GetSimpleFName_S(objViewInfoENEx.FileName);
                    strRe_FileNameWithModuleName = objViewInfoENEx.FolderName;
                    clsLog4GeneViewCodeBLEx.AddLog4GeneViewCode(objViewInfoENEx.ViewId, strUserId);
                }
            }
            catch (Exception objException)
            {
                throw objException;
            }
            return strCodeText;
        }


        public static string GeneControlCodeBak20170330(string strViewId, string strNetVersion, clsProjectsEN objCurrSelProject,
string strUserId, string strUserName, string strSysCodePath, string strSysCodePathBackup,
            ref string strFileName4GenCode, ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {

            string strCodeText = "";
            clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
            clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx);

            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetFuncModule_AgcObjByFuncModuleAgcId_Cache(objViewInfoENEx.FuncModuleAgcId);
            try
            {
                if (strNetVersion == "Net2003")
                {

                    AutoGC7Cs_CWeb_Net2005 autoGC5Cs_CWeb = new AutoGC7Cs_CWeb_Net2005(strViewId);
                    //if (objViewInfoENEx.ViewFldNum  ==  0)
                    //{
                    //    throw new clsDbObjException("界面中字段数为0,不能生成界面代码");
                    //}
                    //if (autoGC5Cs_CWeb.TabKeyFldNum  ==  0)
                    //{
                    //    throw new clsDbObjException("界面相关表的表关键字段数为0,请检查界面的相关表是否有表关键字段!");
                    //}

                    objViewInfoENEx.BackupFolderName = strSysCodePathBackup;
                    if (string.IsNullOrEmpty(strSysCodePath) == false)
                    {
                        objViewInfoENEx.FolderName_Root = strSysCodePath + "\\";
                        objViewInfoENEx.FolderName = strSysCodePath + "\\" + objFuncModule.FuncModuleEnName + "\\";
                    }
                    else
                    {
                        objViewInfoENEx.FolderName_Root = string.Format("D:\\FTP\\ClsFile\\{0}\\{1}\\ViewLayer\\", strUserId, objCurrSelProject.PrjDomain);
                        objViewInfoENEx.FolderName = string.Format("D:\\FTP\\ClsFile\\{0}\\{1}\\ViewLayer\\", strUserId, objCurrSelProject.PrjDomain) + objFuncModule.FuncModuleEnName + "\\";
                    }
                    objViewInfoENEx.CurrUserName = strUserName;
                    strCodeText = autoGC5Cs_CWeb.A_GenViewCode_Web(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                    strFileName4GenCode = objViewInfoENEx.FileName;
                    strRe_ClsName = clsString.GetSimpleFName_S(objViewInfoENEx.FileName);
                    strRe_FileNameWithModuleName = objViewInfoENEx.FolderName;
                    clsLog4GeneViewCodeBLEx.AddLog4GeneViewCode(objViewInfoENEx.ViewId, strUserId);
                }
                else if (strNetVersion == "Net2005")
                {

                    AutoGC7Cs_CWeb_Net2005 autoGC5Cs_CWeb = new AutoGC7Cs_CWeb_Net2005(strViewId);
                    //if (objViewInfoENEx.ViewFldNum  ==  0)
                    //{
                    //    throw new clsDbObjException("界面中字段数为0,不能生成界面代码");
                    //}
                    //if (autoGC5Cs_CWeb.TabKeyFldNum  ==  0)
                    //{
                    //    throw new clsDbObjException("界面相关表的表关键字段数为0,请检查界面的相关表是否有表关键字段!");
                    //}

                    objViewInfoENEx.BackupFolderName = strSysCodePathBackup;
                    if (string.IsNullOrEmpty(strSysCodePath) == false)
                    {
                        objViewInfoENEx.FolderName_Root = strSysCodePath + "\\";
                        objViewInfoENEx.FolderName = strSysCodePath + "\\" + objFuncModule.FuncModuleEnName + "\\";
                    }
                    else
                    {
                        objViewInfoENEx.FolderName_Root = string.Format("D:\\FTP\\ClsFile\\{0}\\{1}\\ViewLayer\\", strUserId, objCurrSelProject.PrjDomain);
                        objViewInfoENEx.FolderName = string.Format("D:\\FTP\\ClsFile\\{0}\\{1}\\ViewLayer\\", strUserId, objCurrSelProject.PrjDomain) + objFuncModule.FuncModuleEnName + "\\";
                    }
                    objViewInfoENEx.CurrUserName = strUserName;
                    strCodeText = autoGC5Cs_CWeb.A_GenViewCode_Web(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                    strFileName4GenCode = objViewInfoENEx.FileName;
                    strRe_ClsName = clsString.GetSimpleFName_S(objViewInfoENEx.FileName);
                    strRe_FileNameWithModuleName = objViewInfoENEx.FolderName;
                    clsLog4GeneViewCodeBLEx.AddLog4GeneViewCode(objViewInfoENEx.ViewId, strUserId);
                }
                else if (strNetVersion == "Net2010")
                {

                    AutoGC7Cs_CWeb_Net2005 autoGC6Cs_CWeb = new AutoGC7Cs_CWeb_Net2005(strViewId);
                    //if (objViewInfoENEx.ViewFldNum  ==  0)
                    //{
                    //    throw new clsDbObjException("界面中字段数为0,不能生成界面代码");
                    //}
                    //if (autoGC6Cs_CWeb.TabKeyFldNum  ==  0)
                    //{
                    //    throw new clsDbObjException("界面相关表的表关键字段数为0,请检查界面的相关表是否有表关键字段!");
                    //}

                    objViewInfoENEx.BackupFolderName = strSysCodePathBackup;
                    if (string.IsNullOrEmpty(strSysCodePath) == false)
                    {
                        objViewInfoENEx.FolderName_Root = strSysCodePath + "\\";
                        objViewInfoENEx.FolderName = strSysCodePath + "\\" + objFuncModule.FuncModuleEnName + "\\";
                    }
                    else
                    {
                        objViewInfoENEx.FolderName_Root = string.Format("D:\\FTP\\ClsFile\\{0}\\{1}\\ViewLayer\\", strUserId, objCurrSelProject.PrjDomain);
                        objViewInfoENEx.FolderName = string.Format("D:\\FTP\\ClsFile\\{0}\\{1}\\ViewLayer\\", strUserId, objCurrSelProject.PrjDomain) + objFuncModule.FuncModuleEnName + "\\";
                    }
                    objViewInfoENEx.CurrUserName = strUserName;
                    strCodeText = autoGC6Cs_CWeb.A_GenViewCode_Web(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                    strFileName4GenCode = objViewInfoENEx.FileName;
                    strRe_ClsName = clsString.GetSimpleFName_S(objViewInfoENEx.FileName);
                    strRe_FileNameWithModuleName = objViewInfoENEx.FolderName;
                    clsLog4GeneViewCodeBLEx.AddLog4GeneViewCode(objViewInfoENEx.ViewId, strUserId);
                }
            }
            catch (Exception objException)
            {
                throw objException;
            }
            return strCodeText;
        }

    }
}
