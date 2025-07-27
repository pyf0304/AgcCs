
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsCMClassExWApi
表名:CMClass(00050501)
生成代码版本:2020.01.01.1
生成日期:2020/01/02 12:09:32
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
using System.IO;
using AgcCommBase;
using System.Linq;

namespace AGC4WApi
{
    /// <summary>
    /// CM类(CMClass)
    /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
    /// </summary>
    public class clsCMClassExWApi
    {
        //private static readonly string mstrApiControllerName = "CMClassExApi";
        /// <summary>
        /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        public static List<clsCMClassEN> arrCMClassObjLst_Cache = null;
        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        protected static int intFindFailCount = 0;

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_ClassConstructor1)
        /// </summary>
        public clsCMClassExWApi()
        {
        }
        public static bool ImportCode4PrjId(string strUserCodePrjMainPathId, string strPrjId, string strCmPrjId, string strMachineName, string strUserId,
         IMSProject myMSProject, IParseCsFile myParseCsFile)
        {
            clsProjectsEN objProjects = clsProjectsWApi.GetObjByPrjIdCache(strPrjId);

            //保存当前选择的字符编码
            //clsPubFun.SaveCharEncodingId4PrjUser(clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId, strCharEncodingId);
            //intCurrIndex = 0;
            //intSuccessCount = 0;
            //intAddCount = 0;
            //intDeleteCount = 0;
            //intNotNeedGC = 0;
            //arrErrorLst = new List<string>();
            //arrAddFileName = new List<string>();
            //arrNotNeedGC = new List<string>();
            //arrDeleteFileName = new List<string>();

            //Encoding myEncoding = clsString.GetEncodingObjByCharEncodingId(strCharEncodingId);

            //clsPubConst.ClsName cnClassName_Sim = clsPubConst.ClsName.EntityLayer_Sim;
            string strMsg = "";
            //string strViewId = "";
            //string strRe_ClsName = "";
            //string strRe_FileNameWithModuleName = "";
            //string strClassFName = "";
            var objUserCodePrjMainPath = clsUserCodePrjMainPathWApi.GetObjByUserCodePrjMainPathIdCache(strUserCodePrjMainPathId, strPrjId);

            clsAppCodeTypeRelaEN objCondition = new clsAppCodeTypeRelaEN();
            string strCondition = objCondition.SetApplicationTypeId(objUserCodePrjMainPath.ApplicationTypeId(), "=")
                .GetCombineCondition();
            List<clsAppCodeTypeRelaEN> arrAppCodeTypeRela = clsAppCodeTypeRelaWApi.GetObjLst(strCondition);
            List<string> arrCodeTypeIdLst = arrAppCodeTypeRela.Select(x => x.CodeTypeId).ToList();
            //this.CodeTypeIdLst = arrCodeTypeId;
            //保存当前选择的字符编码
            //clsPubFun.SaveCharEncodingId4PrjUser(clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId, strCharEncodingId);

            //int intCount = 0;
            //string strCodeText = "";
            //初始化与代码类型相关的字典：代码类型<-->工程文件名；代码类型<-->用户代码路径对象
            IDictionary<string, clsUserCodePathENEx> dicCodeTypeIdUserCodePath = InitDict4CodeTypeId(arrCodeTypeIdLst, objUserCodePrjMainPath.CMProjectAppRelaId, strPrjId, strCmPrjId, strMachineName, strUserId);

            //progressBar1.Minimum = 0;
            //progressBar1.Maximum = arrCompileTab.Count;
            //progressBar2.Minimum = 0;
            //progressBar2.Maximum = arrCompileTab.Count;

            //timer1.Enabled = true;
            //timer1.Start();


            int intCodeTypeIdIndex = 0;
            foreach (string strCodeTypeId in arrCodeTypeIdLst)
            {
                clsCodeTypeEN objCodeTypeEN = clsCodeTypeWApi.GetObjByCodeTypeId(strCodeTypeId);
                if (objCodeTypeEN.IsAutoParseFile == false) continue;

                clsProgLangTypeEN objProgLangTypeEN = clsProgLangTypeWApi.GetObjByProgLangTypeIdCache(objCodeTypeEN.ProgLangTypeId);
                //clsPubConst.ClsName cnClassName = clsPubConst.GetClassNameByString(objCodeTypeEN.CodeTypeENName);
                clsPubConst.LangType ltLangType = clsPubConst.GetLangTypeByString(objProgLangTypeEN.ProgLangTypeName);

                clsUserCodePathENEx objUserCodePathEx = dicCodeTypeIdUserCodePath[strCodeTypeId];
                objUserCodePathEx.GetObjExInfo11(strUserId, strMachineName, strPrjId);

                //clsMSProject.ProjectPath = objUserCodePathEx.PrjFileName;// @"E:\ASPNETJX\SamplePrj\SamplePrj_Entity\SamplePrj_Entity.csproj";

                IEnumerable<string> arrCompileFileLst = myMSProject.GetCompileFileLst(objUserCodePathEx.PrjFileName);
                StringBuilder sbMsg = new StringBuilder();
                foreach (string strPrjInnerFileName in arrCompileFileLst)
                {
                    string strFullFileName = string.Format("{0}\\{1}", objUserCodePathEx.FullProjectPath, strPrjInnerFileName);
                    if (File.Exists(strFullFileName) == false)
                    {
                        continue;
                    }
                    myParseCsFile.ParseCsFile(strFullFileName, objUserCodePathEx.FullProjectPath, strPrjId, strUserId);
                    sbMsg.AppendLine(strFullFileName);
                }
                strMsg = sbMsg.ToString();
                if (objCodeTypeEN.IsExtend == true)
                {
                    //RemovePrjInnerFileForOtherPrj4CannotOverride(strCodeTypeId, objPrjTabEx.PrjInnerFileName);

                    continue;
                }


                intCodeTypeIdIndex++;
            }
            //intCurrIndex++;

            //bolIsFinished = true;

            return true;
        }
        public static IDictionary<string, clsUserCodePathENEx> InitDict4CodeTypeId(List<string> arrCodeTypeIdLst, 
            long lngCMProjectAppRelaId, string strPrjId, string strCmPrjId, string strMachineName, string strUserId)
        {

            IDictionary<string, clsUserCodePathENEx> dicCodeTypeIdUserCodePath = new Dictionary<string, clsUserCodePathENEx>();

            foreach (string strCodeTypeId in arrCodeTypeIdLst)
            {
                clsvCodeType_SimEN objCodeTypeEN = clsvCodeType_SimWApi.GetObjByCodeTypeIdCache(strCodeTypeId);
                //clsCodeTypeENEx objCodeTypeENEx = objCodeTypeEN.CopyToEx();

                clsProgLangTypeEN objProgLangTypeEN = clsProgLangTypeWApi.GetObjByProgLangTypeIdCache(objCodeTypeEN.ProgLangTypeId);
                //clsPubConst.ClsName cnClassName = clsPubConst.GetClassNameByString(objCodeTypeEN.CodeTypeENName);
                clsPubConst.LangType ltLangType = clsPubConst.GetLangTypeByString(objProgLangTypeEN.ProgLangTypeName);
                clsUserCodePathENEx objUserCodePathENEx = clsUserCodePathExWApi.GetObjExByClassName(lngCMProjectAppRelaId,
                    strCodeTypeId, strPrjId, strMachineName, strUserId);

                //clsPubFun.AccessIsExistPath(objUserCodePathENEx);
                objUserCodePathENEx.GetObjExInfo11(strUserId, strMachineName, strPrjId);
                dicCodeTypeIdUserCodePath.Add(strCodeTypeId, objUserCodePathENEx);
            }
            return dicCodeTypeIdUserCodePath;
        }
        public static clsCMClassEN AddCMClass(clsCMClassEN objCMClass)
        {
            clsCMClassEN objCMClass_Cond = new clsCMClassEN();
            string strCondition = objCMClass_Cond.SetClsName(objCMClass.ClsName, "=")
               .SetProgLangTypeId(objCMClass.ProgLangTypeId, "=")
               .SetTabName(objCMClass.TabName, "=")
               .SetFileName(objCMClass.FileName, "=")
               .SetNameSpace(objCMClass.NameSpace, "=")
               .SetUserId(objCMClass.UserId, "=")
               .SetPrjId(objCMClass.PrjId, "=")
               .GetUniConditionStr();
            objCMClass._IsCheckProperty = true;
            bool bolIsExist = clsCMClassWApi.IsExistRecord(strCondition);

            if (bolIsExist)
            {
                objCMClass.CmClassId = clsCMClassWApi.GetFirstID(strCondition);
                objCMClass.FileText = objCMClass.FileText.Replace(";", "；");
                objCMClass.UpdateWithCondition(strCondition);
            }
            else
            {

                objCMClass.SetCmClassId(clsCMClassWApi.GetMaxStrId());
                objCMClass.AddNewRecord();
            }

            return objCMClass;
        }
        public static bool ImportCode4PrjIdV2(int intApplicationTypeId, string strProjectPath, string strPrjFileName, string strPrjId, string strUserId,
     IMSProject myMSProject, IParseCsFile myParseCsFile)
        {
            clsProjectsEN objProjects = clsProjectsWApi.GetObjByPrjIdCache(strPrjId);

            //保存当前选择的字符编码
            //clsPubFun.SaveCharEncodingId4PrjUser(clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId, strCharEncodingId);
            //intCurrIndex = 0;
            //intSuccessCount = 0;
            //intAddCount = 0;
            //intDeleteCount = 0;
            //intNotNeedGC = 0;
            //arrErrorLst = new List<string>();
            //arrAddFileName = new List<string>();
            //arrNotNeedGC = new List<string>();
            //arrDeleteFileName = new List<string>();

            //Encoding myEncoding = clsString.GetEncodingObjByCharEncodingId(strCharEncodingId);

            //clsPubConst.ClsName cnClassName_Sim = clsPubConst.ClsName.EntityLayer_Sim;
            string strMsg = "";
            //string strViewId = "";
            //string strRe_ClsName = "";
            //string strRe_FileNameWithModuleName = "";
            //string strClassFName = "";


            //clsAppCodeTypeRelaEN objCondition = new clsAppCodeTypeRelaEN();
            //string strCondition = objCondition.SetApplicationTypeId(intApplicationTypeId, "=").GetCombineCondition();
            //List<clsAppCodeTypeRelaEN> arrAppCodeTypeRela = clsAppCodeTypeRelaWApi.GetObjLst(strCondition);
            //List<string> arrCodeTypeIdLst = arrAppCodeTypeRela.Select(x => x.CodeTypeId).ToList();
            //this.CodeTypeIdLst = arrCodeTypeId;
            //保存当前选择的字符编码
            //clsPubFun.SaveCharEncodingId4PrjUser(clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId, strCharEncodingId);

            //int intCount = 0;
            //string strCodeText = "";
            //初始化与代码类型相关的字典：代码类型<-->工程文件名；代码类型<-->用户代码路径对象
            //IDictionary<string, clsUserCodePathENEx> dicCodeTypeIdUserCodePath = InitDict4CodeTypeId(arrCodeTypeIdLst, intApplicationTypeId, strPrjId);

            //progressBar1.Minimum = 0;
            //progressBar1.Maximum = arrCompileTab.Count;
            //progressBar2.Minimum = 0;
            //progressBar2.Maximum = arrCompileTab.Count;

            //timer1.Enabled = true;
            //timer1.Start();


            int intCodeTypeIdIndex = 0;


            //clsMSProject.ProjectPath = objUserCodePathEx.PrjFileName;// @"E:\ASPNETJX\SamplePrj\SamplePrj_Entity\SamplePrj_Entity.csproj";

            IEnumerable<string> arrCompileFileLst = myMSProject.GetCompileFileLst(strPrjFileName);
            StringBuilder sbMsg = new StringBuilder();
            foreach (string strPrjInnerFileName in arrCompileFileLst)
            {
                string strFullFileName = string.Format("{0}\\{1}", strProjectPath, strPrjInnerFileName);
                if (File.Exists(strFullFileName) == false)
                {
                    continue;
                }
                try
                {
                    myParseCsFile.ParseCsFile(strFullFileName, strProjectPath, strPrjId, strUserId);
                    sbMsg.AppendLine(strFullFileName);
                }
                catch (Exception objException)
                {
                    string strSS = objException.Message;
                }
            }
            strMsg = sbMsg.ToString();
            //if (objCodeTypeEN.IsExtend == true)
            //{
            //    //RemovePrjInnerFileForOtherPrj4CannotOverride(strCodeTypeId, objPrjTabEx.PrjInnerFileName);

            //    continue;
            //}


            intCodeTypeIdIndex++;
            //}
            //intCurrIndex++;

            //bolIsFinished = true;

            return true;
        }

    }
}