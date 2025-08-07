using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AGC.Entity;
using AGC_CSWin;
using com.taishsoft.common;
using Agc_CsWin.frm.Test;
using AGC4WS;
using AGC.BusinessLogicEx;
using CommonTable.Entity;
using com.taishsoft.syspara;

using SamplePrjWin.frm;

namespace Agc_CsWin
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            com.taishsoft.commdb.clsSpecSQLforSql.strAppType = "WINAPP";
            com.taishsoft.commdbfororacle.clsSpecSQLforOra.strAppType = "WINAPP";
            clsDebugBase_Sql.IsDebug = true;
            clsDebugBase_Sql.LogDir4Debug = @"D:\Log\AgcCs_Win\";
            clsDebugBase_Sql.LogFile4Debug = "Log4DataBase";
            clsDebugBase_Sql.TraceLevel = 4;
            clsDebugBase_Pub.TraceLevel = 4;

            //clsPubVar4BLEx.objLog.LogDir = @"D:\Log\AgcCs_Win\";
            //clsPubVar4BLEx.objLog.LogFileName = "Debug4BL";
            clsPubVar.objLog.LogDir = @"D:\Log\AgcCs_Win\";
            clsPubVar.objLog.LogFileName = "Debug4Web";
            clsSysParaEN_Local.objLog.LogDir = @"D:\Log\AgcCs_Win\";
            clsSysParaEN_Local.objLog.LogFileName = "Debug4Win";
            clsPubVar4BLEx.objLog4Error.LogDir = @"D:\Log\AgcCs_Win\";
            clsPubVar4BLEx.objLog4Error.LogFileName = "Debug4BLEx";

            //SpecData.clsSpecSQL.IsUseEncrypt = true;//使用加密连接串
            SpecData.clsSpecSQL.IsUseEncrypt = false;//使用加密连接串
            clsApplicatoin.ExecutablePath = Application.ExecutablePath;

            clsSysPara4WS.bolIsLocalHost = false;
            //            AGCCS4WS.clsSysPara4WS.strCurrIPAddressAndPort = "202.121.63.9";

            AGC4WS.clsSysPara4WS.strCurrIPAddressAndPort = "101.251.68.133";
            //AGC4WS.clsSysPara4WS.strCurrPrx = "Agc_csV6/WebService";

            //clsSysPara4WS.bolIsLocalHost = true;
            //clsSysPara4WS.strCurrIPAddressAndPort_Local = "localhost:54453/";
            //clsSysPara4WS.strCurrIPAddressAndPort = "localhost:54453/";
            AGC4WS.clsSysPara4WS.strCurrIPAddressAndPort = "101.251.68.133";
            clsSysPara4WS.strCurrPrx = "Agc/WebService";

            clsSysParaEN.TempFileFolder = clsApplicatoin.AppPath() + "\\TempFiles\\";
            clsSysParaEN.strXMLFolder = clsApplicatoin.AppPath() + "\\XML\\";
            clsSysParaEN_Local.IsBackupForGeneCode  = true;
            clsSysParaEN_Local.IsUseFieldCache = true;
            clsPubFun.SetCommFun4BL();
            //DataSynImport.ImportPara.XmlDataSourceFileName = clsSysParaEN.strXMLFolder + "TzSysDataSet.xml";
            if (args.Length == 0)
            {
                string strIsUseXmlDataSource = System.Configuration.ConfigurationManager.AppSettings["IsUseXmlDataSource"].ToString();
                //DataSynImport.ImportPara.IsUseXmlDataSource = strIsUseXmlDataSource == "TRUE" ? true : false;
                //				Application.Run(new frmXkEduClassInfo_QUDI_LV());
                //Application.Run(new MdiForm());   
                //Application.Run(new frm即时编译());
                //Application.Run(new frm扩展对象列表());
                //Application.Run(new frm建立界面结构树());              
                //Application.Run(new frm读取工程信息());
                Application.Run(new frmTestGCByIncludeTab());
                
                return;
                //Application.Run(new frmLogin());
                //Application.Run(new frmTest());
        
            }

            else
            {
                //clsSysParaEN.strUserId = args[1];
                string[] strChRightName = args[1].Split(',');
                //clsSysParaEN.arrChRightName = clsCommForWin.ChangeArray2ArrayList(strChRightName);

                string[] sstrPrjUser = args[2].Split(',');
                clsSysParaEN.strUserId = sstrPrjUser[1];

                string strPrjId = sstrPrjUser[0];
                clsSysParaEN.CurrSelPrjId = strPrjId;
                //                clsSysParaEN.strUserRoleId = objUserPrjGrant.RoleId;
                clsPubVar.CurrSelPrjId = strPrjId;
                //if (clsSysParaEN.bolIsUseXmlDataSource == false)
                //{
                //    clsUserUsedLogEx.SetUsedLog(clsSysParaEN.strUserId, "Project", clsPubVar.CurrSelPrjId);
                //    try
                //    {
                //        //访问数增1
                //        objUserPrjGrant.VisitedNum++;
                //        objUserPrjGrant.UpdateBySql();
                //    }
                //    catch (Exception objException)
                //    {
                //        MessageBox.Show("修改访问次数不成功!\r\n" + objException.Message);
                //    }
                //}


                if (args[0] == "Excel导入")
                {
                    //PrjId = '0011'
                    //Application.Run(new frmDataImport_Excel());
                }
                else if (args[0] == "Excel导入字段设置")
                {
                    //PrjId = '0011'
                    //Application.Run(new frmTabFieldRela_QD_LV());
                }
                else if (args[0] == "从主库上传到WEB")
                {
                    //PrjId = '0053'
                    //Application.Run(new frmDataImportV2());
                }
                else if (args[0] == "从主库上传到WEB字段设置")
                {
                    //PrjId = '0053'
                    //Application.Run(new frmTabFieldRela_QD_LV());
                }
                else if (args[0] == "从WEB下载到主库")
                {
                    //PrjId = '0054'
                    //Application.Run(new frmDataImportV2());
                }
                else if (args[0] == "从WEB下载到主库字段设置")
                {
                    //PrjId = '0054'
                    //Application.Run(new frmTabFieldRela_QD_LV());
                }
                else
                {
                    MessageBox.Show(args[0] + "，找不到对应的界面！");
                }
            }


        }
    }
}
