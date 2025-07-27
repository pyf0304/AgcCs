
using System;

namespace AGC4WApi
{
    /// <summary>
    /// clsSysPara。
    /// </summary>
    public class clsSysPara4WebApi_Agc
    {

        /// <summary>
        /// 当前机器的IPAddress
        /// </summary>
        public static String strCurrIPAddressAndPort
        {
            set
            {
                clsSysPara.CurrIPAddressAndPort = value;
            }
            get
            {
                return clsSysPara.CurrIPAddressAndPort;
            }
        }
        /// <summary>
        /// 当前机器的IPAddress（备用）
        /// </summary>
        public static String strCurrIPAddressAndPort2
        {
            set
            {
                clsSysPara.strCurrIPAddressAndPort2 = value;
            }
        }
          /// <summary>
        /// 是否使用备用的统一平台服务地址
        /// </summary>
        public static bool bolIsUseBackupIpAddressAndCurrPrx
        {
            set
            {
                clsSysPara.bolIsUseBackupIpAddressAndCurrPrx = value;
            }
        }

        ///// <summary>
        ///// 是否本机调试状态
        ///// </summary>
        //public static bool bolIsLocalHost
        //{
        //    set
        //    {
        //        clsSysPara.bolIsLocalHost = value;
        //    }
        //}
        /// <summary>
        /// 
        /// </summary>
        public static String strCurrIPAddressAndPort_Local
        {
            set
            {
                clsSysPara.strCurrIPAddressAndPort_Local = value;
            }
            get
            {
                return clsSysPara.strCurrIPAddressAndPort_Local;
            }
        }

        /// <summary>
        /// 当前机器的端口号
        /// </summary>
        public static String strCurrPrx
        {
            set
            {
                clsSysPara.CurrPrx = value;
            }
            get
            {
                return clsSysPara.CurrPrx;
            }
        }

        /// <summary>
        /// 当前机器的端口号（备用）
        /// </summary>
        public static String strCurrPrx2
        {
            set
            {
                clsSysPara.strCurrPrx2 = value;
            }
        }
        /// <summary>
        /// 是否本机调试状态
        /// </summary>
        public static bool bolIsLocalHost
        {
            set
            {
                clsSysPara.bolIsLocalHost = value;
            }
            get
            {
                return clsSysPara.bolIsLocalHost;
            }
        }
        ///// <summary>
        ///// 测试主连接
        ///// </summary>
        ///// <param name="strReturn">返回相关错误信息</param>
        ///// <returns>返回是否成功？</returns>
        //public static bool TestConnect(ref string strReturn)
        //{
        //    LoginServiceSoapClient objLoginService = null;
        //    try
        //    {
        //        objLoginService =clsLoginWS.GetLoginServiceSoapClient();
        //        string ss = objLoginService.GetUserIdByLoginName("pyf");
        //    }
        //    catch (Exception objException)
        //    {
        //        string strMessage = objException.InnerException.Message;
        //        if (strMessage.IndexOf("无法连接") >= 0)
        //        {
        //            string strMsg = string.Format(" 连接有问题,可能由于：{3}, 请使用其他连接。{0}.clsSysPara.CurrPrx={1}; clsSysPara.CurrIPAddressAndPort={2}",
        //                 objException.Message,
        //                 clsSysPara.CurrPrx,
        //                 clsSysPara.CurrIPAddressAndPort,
        //                 objException.InnerException.Message);
        //            com.taishsoft.common.clsLog.LogErrorS(objException, "TestConnect");
        //            strReturn = strMsg;
        //            return false;
        //        }
        //        else
        //        {
        //            return true;
        //        }
        //        //throw new Exception(strMsg);
        //    }
        //    return true;
        //}
        ///// <summary>
        ///// 测试备用连接
        ///// </summary>
        ///// <param name="strReturn">返回相关错误信息</param>
        ///// <returns>返回是否成功？</returns>
        //public static bool TestConnect2(ref string strReturn)
        //{
        //    LoginServiceSoapClient objLoginService = null;
        //    try
        //    {
        //        objLoginService = clsLoginWS.GetLoginServiceSoapClientByBackup();
        //    }
        //    catch (Exception objException)
        //    {
        //        string strMessage = objException.InnerException.Message;
        //        if (strMessage.IndexOf("无法连接") >= 0)
        //        {
        //            string strMsg = string.Format("测试备用连接有问题,可能由于：{3}, 请使用其他连接。{0}.clsSysPara.CurrPrx={1}; clsSysPara.CurrIPAddressAndPort={2}",
        //                 objException.Message,
        //                 clsSysPara.CurrPrx,
        //                 clsSysPara.CurrIPAddressAndPort,
        //                 objException.InnerException.Message);
        //            com.taishsoft.common.clsLog.LogErrorS(objException, "TestConnect");
        //            strReturn = strMsg;
        //            return false;
        //        }
        //        else
        //        {
        //            return true;
        //        }
        //    }
        //    return true;
        //}
    
    }
}
