using AGC.Entity;
using Agc_CsWin.frm.Test;
using AGC_CSWin;
using AGC4WApi;
using com.taishsoft.common;
using GP4WApi;
using System;
using System.Windows.Forms;

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
            //com.taishsoft.commdb.clsSpecSQLforSql.strAppType = "WINAPP";

            //com.taishsoft.commdbfororacle.clsSpecSQLforOra.strAppType = "WINAPP";
            //clsDebugBase_Sql.IsDebug = true;
            //clsDebugBase_Sql.LogDir4Debug = @"D:\Log\AgcCs_Win\";
            //clsDebugBase_Sql.LogFile4Debug = "Log4DataBase";
            //clsDebugBase_Sql.TraceLevel = 4;
            clsDebugBase_Pub.TraceLevel = 4;

            //clsPubVar4ExWApi.objLog.LogDir = @"D:\Log\AgcCs_Win\";
            //clsPubVar4ExWApi.objLog.LogFileName = "Debug4BL";
            clsPubVar.objLog = new clsLog(@"D:\Log\AgcCs_Win\", "Debug4Web");
            clsSysParaEN_Local.objLog = new clsLog(@"D:\Log\AgcCs_Win\", "Debug4Win");
            clsPubVar4WApi.objLog4Error = new clsLog(@"D:\Log\AgcCs_Win\", "Debug4BLEx");

            //SpecData.clsSpecSQL.IsUseEncrypt = true;//使用加密连接串
            //SpecData.clsSpecSQL.IsUseEncrypt = false;//使用加密连接串
            clsApplicatoin.ExecutablePath = Application.ExecutablePath;
            {
                clsSysPara4WebApi_Agc.bolIsLocalHost = false;
                clsSysPara4WebApi_GP.strCurrIPAddressAndPort = clsMyConfig4AgcWin.CurrIPAddressAndPort;// "202.121.63.9";
                clsSysPara4WebApi_Agc.strCurrPrx = "AgcWAV3";
                clsSysPara4WebApi_GP.strCurrPrx = clsMyConfig4AgcWin.CurrPrxWA;// "GP_SHNU_WS";
            }
            {
                //clsSysPara4WebApi_Agc.bolIsLocalHost = true;
                //clsSysPara4WebApi_GP.strCurrIPAddressAndPort = "http://localhost:7109";
                //clsSysPara4WebApi_Agc.strCurrPrx = "";
                //clsSysPara4WebApi_GP.strCurrPrx = "";// "GP_SHNU_WS";
            }
   
            clsSysPara4WebApi_Agc.strCurrIPAddressAndPort = clsMyConfig4AgcWin.CurrIPAddressAndPort4WA;
            
            //用于本地调试：
            clsSysPara4WebApi_Agc.strCurrIPAddressAndPort_Local = "http://localhost:7109";
            //clsSysPara4WebApi_Agc.strCurrPrx = "";

            //clsSysPara.strCurrIPAddressAndPort
            clsSysParaEN.TempFileFolder = clsApplicatoin.AppPath() + "\\TempFiles\\";
            clsSysParaEN.strXMLFolder = clsApplicatoin.AppPath() + "\\XML\\";
            clsSysParaEN_Local.IsBackupForGeneCode = true;
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
                //Application.Run(new frm获取对象属性列表());
                Application.Run(new frmLogin());
                //Application.Run(new frmTest());
                if (clsSysParaEN.strUserStateId == "0001")
                {
                    //Application.Run(new MdiForm());   
                    if (clsPubVar.objMainForm == null)
                    {
                        clsPubVar.objMainForm = new MdiForm();
                    }
                    Application.Run(clsPubVar.objMainForm);
                }
                return;
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
                switch (args[0])
                {
                    case "login":
                    case "登录":
                        Application.Run(new frmLogin());
                        break;
                    case "Excel导入":

                        //PrjId = '0011'
                        //Application.Run(new frmDataImport_Excel());
                        break;
                    case "Excel导入字段设置":
                        //PrjId = '0011'
                        //Application.Run(new frmTabFieldRela_QD_LV());
                        break;
                    case "测试分析代码":
                        //PrjId = '0011'
                        Application.Run(new frmTestParseCsFile());
                        break;
                    case "测试工程信息":
                        //PrjId = '0011'
                        Application.Run(new frm读取工程信息());
                        break;
                    case "从主库上传到WEB":
                        //PrjId = '0053'
                        //Application.Run(new frmDataImportV2());
                        break;
                    case "从主库上传到WEB字段设置":
                        //PrjId = '0053'
                        //Application.Run(new frmTabFieldRela_QD_LV());
                        break;
                    case "从WEB下载到主库":
                        //PrjId = '0054'
                        //Application.Run(new frmDataImportV2());
                        break;
                    case "从WEB下载到主库字段设置":
                        //PrjId = '0054'
                        //Application.Run(new frmTabFieldRela_QD_LV());
                        break;
                    default:
                        MessageBox.Show(args[0] + "，找不到对应的界面！");
                        break;
                }
            }


        }
    }
}
