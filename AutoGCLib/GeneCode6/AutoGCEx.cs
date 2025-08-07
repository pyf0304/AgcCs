using AGC.BusinessLogicEx;
using AGC.Entity;
using com.taishsoft.comm_db_obj;
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.syspara;

namespace AutoGCLib
{
    public class AutoGCEx : AutoGC
    {
        public static clsPrjTabENEx InitGC(string strTabId, string strPrjDataBaseId, string strPrjId)
        {
            AutoGCLib.clsGeneCodeBase4Tab autoGCPubFunc = null;
            autoGCPubFunc = new AutoGCLib.AutoGC6Cs_M(strTabId, strPrjDataBaseId, strPrjId);
            return autoGCPubFunc.objPrjTabENEx;
        }
        public static void SetCommFun4BL()
        {
            clsPubFun4BLEx.SetCommFun4BL();
        }
        public static void AppSet(string strConnectString)
        {
            if (string.IsNullOrEmpty(com.taishsoft.commdb.clsSpecSQLforSql.strAppType) == false)
            {
                return;
            }
            com.taishsoft.commdb.clsSpecSQLforSql.strAppType = "DynamicCompiler";
            com.taishsoft.commdbfororacle.clsSpecSQLforOra.strAppType = "DynamicCompiler";
            clsSysLogEN._ConnectString = strConnectString;
            clsConnectStrObj objConnectStrObj = new clsConnectStrObj();
            objConnectStrObj.ConnectStringName = "ConnectString1";
            objConnectStrObj.ConnectStringValue = strConnectString;
            clsSpecSQLforSql.AddConnectStrObj(objConnectStrObj);
            clsSysParaEN.strConnectStrName = "ConnectString1";
            clsSysParaEN.bolIsUseConnectStrName = true;

            clsDebugBase_Sql.IsDebug = true;
            clsDebugBase_Sql.LogDir4Debug = @"D:\Log\AgcCs_USDFunction\";
            clsDebugBase_Sql.LogFile4Debug = "Log4DataBase";
            clsDebugBase_Sql.TraceLevel = 4;
            clsDebugBase_Pub.TraceLevel = 4;

            //clsPubVar4BLEx.objLog.LogDir = @"D:\Log\AgcCs_Win\";
            //clsPubVar4BLEx.objLog.LogFileName = "Debug4BL";
            //clsPubVar4BLEx.objLog.LogDir = @"D:\Log\AgcCs_Win\";
            //clsPubVar.objLog.LogFileName = "Debug4Web";
            clsSysParaEN.objLog = new clsLog(@"D:\Log\AgcCs_USDFunction\",  "Debug4USDFunction");

            SpecData.clsSpecSQL.IsUseEncrypt = true;//使用加密连接串

            clsSysParaEN.TempFileFolder = clsApplicatoin.AppPath() + "\\TempFiles\\";
            clsSysParaEN.strXMLFolder = clsApplicatoin.AppPath() + "\\XML\\";
            clsSysParaEN_Local.IsBackupForGeneCode = true;
            clsSysParaEN_Local.IsUseFieldCache = true;

        }
    }
}
