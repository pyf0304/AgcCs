
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsCMFuncParaExWApi
表名:CMFuncPara(00050503)
生成代码版本:2020.01.01.1
生成日期:2020/01/02 12:09:34
生成者:
生成服务器IP:192.168.1.10
工程名称:AGC
工程ID:0005
相关数据库:tzar.tpddns.cn,19433AGC_CS12
PrjDataBaseId:0213
模块中文名:代码管理
模块英文名:CodeMan
框架-层名:WA_访问扩展层(WA_AccessEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Web;
using System.Collections;
using com.taishsoft.common;
using System.ServiceModel;
using AGC.Entity;

using System.Collections.Generic;
using com.taishsoft.json;

namespace AGC4WApi
{
    /// <summary>
    /// CM函数参数(CMFuncPara)
    /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
    /// </summary>
    public class clsCMFuncParaExWApi
    {
        //private static readonly string mstrApiControllerName = "CMFuncParaExApi";
        /// <summary>
        /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        public static List<clsCMFuncParaEN> arrCMFuncParaObjLst_Cache = null;
        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        protected static int intFindFailCount = 0;

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_ClassConstructor1)
        /// </summary>
        public clsCMFuncParaExWApi()
        {
        }
        public static clsCMFuncParaEN AddCMFuncPara(clsCMFuncParaEN objCMFuncPara)
        {
            clsCMFuncParaEN objCMFuncPara_Cond = new clsCMFuncParaEN();
            string strCondition = objCMFuncPara_Cond
                .SetPrjId(objCMFuncPara.PrjId, "=")
                .SetParaName(objCMFuncPara.ParaName, "=")
                            .SetParameterType(objCMFuncPara.ParameterType, "=")
               .SetDataTypeId(objCMFuncPara.DataTypeId, "=")
.GetUniConditionStr();

            bool bolIsExist = clsCMFuncParaWApi.IsExistRecord(strCondition);

            if (bolIsExist)
            {
                objCMFuncPara.CmFuncParaId = clsCMFuncParaWApi.GetFirstID(strCondition);
                objCMFuncPara.UpdateWithCondition(strCondition);
            }
            else
            {

                objCMFuncPara.SetCmFuncParaId(clsCMFuncParaWApi.GetMaxStrId());
                objCMFuncPara.AddNewRecord();
            }

            return objCMFuncPara;
        }

    }
}