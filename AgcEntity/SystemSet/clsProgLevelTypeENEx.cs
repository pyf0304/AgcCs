using AGC.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGC.Entity
{
    public class clsProgLevelTypeENEx : clsProgLevelTypeEN
    {
        public const string CurrTabName_S = "";
//        01	实体层	Entity Level	Enti	20160101221659	pyf	
//02	实体扩展层	Entity Level Extend	EnEx	20160101211755		
//03	数据处理层	Data Access Level	Data	20160101221707	pyf	
//04	数据处理扩展层	Data Access Level Extend	DaEx	20160101211730		
//05	业务逻辑层	Business Logic Level	Busi	20160101221723	pyf	
//06	业务逻辑扩展层	Business Logic Level Extend	BlEx	20160101211703		
//07	Web界面层	Web Interface Level	WebI	20160101211651		
//08	Win界面层	Win Interface Level	WinI	20160101211639		
//09	Web服务层	Web Service Level	WebS	20160101212210		
//10	SilverLight控件层	SilverLight Control Level	SilC	20160101212420		
//11	Web用户控件层	Web User Control Level	WucL	20160101212616		
//12	JavaScript层 JavaScript Level jsle	20160106162231	pyf	
//13	Web服务转换层 Web Service Transfer Level Wstl    NULL NULL    NULL
//14	AndroidApp层 Android App Level   Aapl NULL    NULL NULL
        /// <summary>
        /// 实体层
        /// </summary>
        public const string EntityLevel="01";//	Enti	20160101221659	pyf	
        /// <summary>
        /// 实体扩展层
        /// </summary>
        public const string EntityLevelExtend="02";	//EnEx	20160101211755	
	    /// <summary>
        /// 数据处理层
	    /// </summary>
        public const string DataAccessLevel="03";//	Data	20160101221707	pyf	
        /// <summary>
        /// 数据处理扩展层
        /// </summary>
        public const string DataAccessLevelExtend="04";//	DaEx	20160101211730		
        /// <summary>
        /// 业务逻辑层
        /// </summary>
        public const string BusinessLogicLevel="05";//	Busi	20160101221723	pyf	
        /// <summary>
        /// 业务逻辑扩展层
        /// </summary>
        public const string BusinessLogicLevelExtend="06";//	BlEx	20160101211703		
        /// <summary>
        /// Web界面层
        /// </summary>
        public const string WebInterfaceLevel="07";	//WebI	20160101211651		
        /// <summary>
        /// Win界面层
        /// </summary>
        public const string WinInterfaceLevel="08";//	WinI	20160101211639		
        /// <summary>
        /// Web服务层
        /// </summary>
        public const string WebServiceLevel="09";//	WebS	20160101212210	
        
        /// <summary>
        /// Web服务转换层
        /// </summary>
        public const string WebServiceTransferLevel = "13";//	Wstl	20160101212210	

        /// <summary>
        /// SilverLight控件层
        /// </summary>
        public const string SilverLightControlLevel	="10";//SilC	20160101212420		
        /// <summary>
        /// Web用户控件层
        /// </summary>
        public const string WebUserControlLevel="11";//	WucL	20160101212616	

        /// <summary>
        /// JavaScript层
        /// </summary>
        public const string JavaScriptLevel = "12";//	jsle	20160101212616	

        /// <summary>
        /// AndroidApp层
        /// </summary>
        public const string AndroidAppLevel = "14";//	jsle	20160101212616	

                                                   /// <summary>
                                                   /// Web界面层
                                                   /// </summary>
        public const string Mvc_Controller_Level = "20";   //WebI	20160101211651		

    }
}
