using AGC.Entity;
using AGC_CSWin;
using AGC4WApi;
using com.taishsoft.datetime;

using FileSplit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Agc_CsWin.frm.SystemSet
{
    public partial class frmWebServiceSet : Form
    {

        public MdiForm frmParentForm = null;
        public frmWebServiceSet()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //string strWebServiceSet = "";
            string strMid = cboWebApiIPVirtualPath.SelectedValue.ToString();
            clsWebApiIPAndPortTabEN objWebApiIPAndPortTab = clsWebApiIPAndPortTabWApi.GetObjBymIdCache(long.Parse(strMid));
            clsUserWebSrvSetEN objUserWebSrvSet = new clsUserWebSrvSetEN();
            objUserWebSrvSet.SetUserId(clsSysParaEN.strUserId)
                .SetMachineName(Environment.MachineName)
                .SetWebApiIPAndPort(objWebApiIPAndPortTab.WebApiIPAndPort)
                .SetWebApiVirtualPath(objWebApiIPAndPortTab.WebApiVirtualPath)
                .SetUpdDate(clsDateTime.getTodayDateTimeStr(0))
                .SetUpdUserId(clsSysParaEN.strUserId)
                .EditRecordEx();
            clsSysPara4WebApi_Agc.strCurrIPAddressAndPort = objWebApiIPAndPortTab.WebApiIPAndPort;// "103.116.76.183";
            clsSysPara4WebApi_Agc.strCurrPrx = objWebApiIPAndPortTab.WebApiVirtualPath;




            this.frmParentForm.SetTitle();
            //this.SetParentFormTitle();
            int intC  = AutoGeneCodeWApi.Plus(11,22);
            if (intC == 33)
            {
                MessageBox.Show("设置完成, 并且该地址可用！");
                this.Close();
            }
            else
            {
                MessageBox.Show("设置完成, 并且该地址不可用！");
            }
        }
        public void SetParentFormTitle()
        {
            clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseWApi.GetObjByPrjDataBaseIdCache(clsPubVar.CurrPrjDataBaseId);
            string strWebServiceSet = clsPubFun.GetWebServiceSet();
            this.MdiParent.Text = string.Format("自动生成代码20170623--工程：{0}({1}); 数据库：{2}({3}); 生成代码WebApi:{4} ",
                clsPubVar.objCurrSelProjectEN.PrjName,
                clsPubVar.objCurrSelProjectEN.PrjId,
                objPrjDataBaseEN.PrjDataBaseName,
                objPrjDataBaseEN.PrjDataBaseId,
                clsSysPara4WebApi_Agc.strCurrIPAddressAndPort);

        }
        private string example()
        {
            string Info = "";
            MachineInfo info = MachineInfo.I();       //获取主机的对象信息  


            Info = "\r\n主机名:" + Dns.GetHostName(); //获取主机名称  
            //Info += "\r\n系统类型:" + info.GetSystemType();
            //Info += "\r\n物理内存:" + info.GetPhysicalMemory();


            Info += "\r\n\r\n本地IP:";
            string[] LocalIp = info.GetLocalIpAddress();
            foreach (string ip in LocalIp) Info += "\r\n" + ip;


            Info += "\r\n\r\n外网IP:";
            string[] ExternalIp = info.GetExtenalIpAddress();
            foreach (string ip in ExternalIp) Info += "\r\n" + ip;


            //Info += "\r\n\r\nMAC:";
            //Info += "\r\n" + info.GetNetCardMACAddress();
            ////Info += "\r\n" + info.GetMacAddress(LocalIp[0]);   


            //Info += "\r\n";
            //Info += "\r\nCPU序列号:" + info.GetCPUSerialNumber();
            //Info += "\r\nCPU编号:" + info.GetCPUID();  
            //Info += "\r\nCPU版本信息:" + info.GetCPUVersion();  
            //Info += "\r\nCPU名称信息:" + info.GetCPUName();  
            //Info += "\r\nCPU制造厂商:" + info.GetCPUManufacturer();  
            //Info += "\r\n主板制造厂商:" + info.GetBoardManufacturer();  


            //Info += "\r\n主板序列号:" + info.GetBIOSSerialNumber();  
            //Info += "\r\n硬盘序列号:" + info.GetHardDiskSerialNumber();  
            //Info += "\r\n显卡PNPDeviceID:\r\n" + info.GetVideoPNPID();  
            //Info += "\r\n声卡PNPDeviceID:\r\n" + info.GetSoundPNPID();  


            return Info;
        }

        private void frmWebServiceSet_Load(object sender, EventArgs e)
        {
            label1.Text = example();// com.taishsoft.common.clsApplicatoin.ApplicationName;
            clsWebApiIPAndPortTabExWApi.BindCbo_WebApiIPAndPortVirtualPath(cboWebApiIPVirtualPath);

            List<clsWebApiIPAndPortTabEN> arrWebApiIPAndPortTab = clsWebApiIPAndPortTabWApi.GetObjLst("1=1");
            string strCondition = new clsUserWebSrvSetEN()
                .SetUserId(clsSysParaEN.strUserId)
                .SetMachineName(Environment.MachineName)
                .GetUniConditionStr();

            clsUserWebSrvSetEN objCurrUserWebSrvSet = clsUserWebSrvSetWApi.GetFirstObj(strCondition);
            if (objCurrUserWebSrvSet == null) return;
            clsWebApiIPAndPortTabEN objCurrWebApiIPAndPortTab = arrWebApiIPAndPortTab
                .Find(x => x.WebApiIPAndPort == objCurrUserWebSrvSet.WebApiIPAndPort
                 && x.WebApiVirtualPath == objCurrUserWebSrvSet.WebApiVirtualPath);
            if (objCurrWebApiIPAndPortTab == null) return;
            cboWebApiIPVirtualPath.SelectedValue = objCurrWebApiIPAndPortTab.mId;
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTestWebApiAddress_Click(object sender, EventArgs e)
        {
            int intC = AutoGeneCodeWApi.Plus(11, 22);
            if (intC == 33)
            {
                MessageBox.Show(string.Format("测试WebApi地址可用！(http://{0}/{1}/Api", 
                    clsSysPara4WebApi_Agc.strCurrIPAddressAndPort, clsSysPara4WebApi_Agc.strCurrPrx));     
            }
            else
            {
                MessageBox.Show(string.Format("测试WebApi地址不可用！(http://{0}/{1}/Api",
                    clsSysPara4WebApi_Agc.strCurrIPAddressAndPort, clsSysPara4WebApi_Agc.strCurrPrx));
            }
        }
    }
}
