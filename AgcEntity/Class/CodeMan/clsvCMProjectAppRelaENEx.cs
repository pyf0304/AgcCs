
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvCmProjectAppRelaENEx
表名:vCmProjectAppRela(00050634)
* 版本:2024.08.31.1(服务器:WIN-SRV103-116)
日期:2024/08/31 17:56:08
生成者:pyf
生成服务器IP:
工程名称:AGC(0005)
CM工程:AgcSpa后端(变量首字母不限定)-WebApi函数集
相关数据库:103.116.76.183,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:代码管理(CodeMan)
框架-层名:实体扩展层(CS)(EntityLayerEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
**/
using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;
using System.Security.Cryptography.X509Certificates;

namespace AGC.Entity
{
    /// <summary>
    /// vCmProjectAppRela(vCmProjectAppRela)
    /// (AutoGCLib.EntityLayerEx4CSharp:GeneCode)
    /// </summary>
    [Serializable]
    public class clsvCmProjectAppRelaENEx : clsvCmProjectAppRelaEN
    {

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.EntityLayerEx4CSharp:Gen_ENEx_ClassConstructor1)
        /// </summary>
        public clsvCmProjectAppRelaENEx()
        {

        }
        public string CmPrjAppName { set; get; }
    }
}