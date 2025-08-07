
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsCodeTypeExWApi
表名:CodeType(00050203)
生成代码版本:2019.07.15.2
生成日期:2019/07/16 19:00:39
生成者:
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:系统参数
模块英文名:SysPara
框架-层名:WebApi访问扩展层(WA_AccessEx)
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
using AGC.BusinessLogic;
using System.Collections.Generic;
using com.taishsoft.json;
using Newtonsoft.Json.Linq;
using System.Linq;
using AgcCommBase;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AGC4WApi
{
    /// <summary>
    /// 代码类型(CodeType)
    /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
    /// </summary>
    public class clsCodeTypeExWApi
    {
        private static readonly string mstrApiControllerName = "CodeTypeExApi";
        /// <summary>
        /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        public static List<clsCodeTypeEN> arrCodeTypeObjLst_Cache = null;
        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        protected static int intFindFailCount = 0;

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_ClassConstructor1)
        /// </summary>
        public clsCodeTypeExWApi()
        {
        }

        /// <summary>
        /// GetCodeTypeObjLstByApplicationType4Back
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCode)
        /// </summary>
        /// <param name = "intApplicationTypeId">intApplicationTypeId</param>
        /// <returns>返回对象列表</returns>
        public static List<clsCodeTypeEN> GetCodeTypeObjLstByApplicationType4Back1(int intApplicationTypeId)
        {
            string strAction = "GetCodeTypeObjLstByApplicationType4Back";
            string strErrMsg = string.Empty;
            string strResult = "";
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["intApplicationTypeId"] = intApplicationTypeId.ToString(),
            };
            try
            {
                if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
                {
                    JObject jobjReturn = JObject.Parse(strResult);
                    if ((int)jobjReturn["ErrorId"] == 0)
                    {
                        var varResult = clsJSON.GetObjLstFromJson<clsCodeTypeEN>((string)jobjReturn["ReturnObjLst"]);
                        return varResult;
                    }
                    else
                    {
                        string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
                        throw new Exception(strMsg);
                    }
                }
                else return null;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("GetCodeTypeObjLstByApplicationType4Back出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 获取所给语言类型的【后台】代码类型对象列表
        /// </summary>
        /// <param name="intApplicationTypeId"></param>
        /// <returns></returns>
        public static List<clsvCodeType_SimEN> GetCodeTypeObjLstByApplicationType4Back(int intApplicationTypeId, string strTabMainTypeId)
        {
            //string strCondition = string.Format(" {0} in ('Table', 'PureClass') ", clsCodeTypeEN.con_DependsOn);
            List<string> arrDependsOn = new List<string>() { "Table", "PureClass" };
            IEnumerable<clsAppCodeTypeRelaEN> arrAppCodeTypeRela = clsAppCodeTypeRelaExWApi.GetObjLstByApplicationTypeIdCache(intApplicationTypeId)
                .Where(x=>x.TabMainTypeId == strTabMainTypeId)                    
                .OrderBy(x => x.OrderNum);
            IEnumerable<string> arrCodeTypeId = arrAppCodeTypeRela.Select(x=>x.CodeTypeId);
            string strKey = string.Format("{0}", clsCodeTypeEN._CurrTabName);
            List<clsvCodeType_SimEN> arrCodeTypeObjLst_Cache = clsvCodeType_SimWApi.GetObjLstCache();
            List<clsvCodeType_SimEN> arrCodeTypeObjList =                 arrCodeTypeObjLst_Cache
                .Where(x=> arrCodeTypeId.Contains( x.CodeTypeId )
                                && arrDependsOn.Contains(x.DependsOn)).ToList();
            return arrCodeTypeObjList;
        }

        public static void BindCbo_CodeTypeIdEx(System.Windows.Forms.ComboBox objComboBox)
        {
            //为数据源为表的下拉框设置内容
            string strCondition = string.Format(" 1=1 Order By {0}", conCodeType.OrderNum);
     List<clsCodeTypeEN> arrObj = clsCodeTypeWApi.GetObjLst(strCondition);
            clsCodeTypeEN objCodeTypeEN;
            //初始化一个对象列表
            ArrayList CodeTypeList = new ArrayList();
            //插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
            objCodeTypeEN = new clsCodeTypeEN();
            objCodeTypeEN.CodeTypeId = "0";
            objCodeTypeEN.CodeTypeName = "请选择...";
            CodeTypeList.Add(objCodeTypeEN);
            //把DataTable中的所有项均加到对象列表中
            foreach (clsCodeTypeEN objRow in arrObj)
            {               
                CodeTypeList.Add(objRow);
            }
            //设置下拉框的数据源、以及设置值项、显示项
            objComboBox.DataSource = CodeTypeList;
            objComboBox.ValueMember = "CodeTypeId";
            objComboBox.DisplayMember = "CodeTypeName";
            objComboBox.SelectedIndex = 0;
        }
        static Func<clsCodeTypeEN, string, string, bool> IsMatch
         = (objCodeType, strClassName, strProgLangTypeId) =>
         {
                //if (objCodeType.DependsOn == "PureClass") return false;
                if (objCodeType.ProgLangTypeId != strProgLangTypeId) return false;
             string strPattern = objCodeType.ClassNamePattern;
                //string strClass3 = "aclsTestBLEx";

                //string strPattern = @"\bcls\S*BLEx\b";
                var r = new Regex(strPattern);
             Match m = r.Match(strClassName);
             return m.Success;
         };
        static Func<clsvCodeType_SimEN, string, string, bool> IsMatchV2
    = (objvCodeType_Sim, strClassName, strProgLangTypeId) =>
    {
        //if (objCodeType.DependsOn == "PureClass") return false;
        if (objvCodeType_Sim.ProgLangTypeId != strProgLangTypeId) return false;
        var objCodeTypeEN = clsCodeTypeWApi.GetObjByCodeTypeId(objvCodeType_Sim.CodeTypeId);
        string strPattern = objCodeTypeEN.ClassNamePattern;
        //string strClass3 = "aclsTestBLEx";

        //string strPattern = @"\bcls\S*BLEx\b";
        var r = new Regex(strPattern);
        Match m = r.Match(strClassName);
        return m.Success;
    };
        /// <summary>
        /// 根据类名和语言获取代码类型Id
        /// </summary>
        /// <param name="strClassName">类名</param>
        /// <param name="ltLangType">语言</param>
        /// <returns>代码类型Id</returns>
        public static Tuple<string, string> GetCodeTypeIdByClassName(string strClassName, clsPubConst.LangType ltLangType)
        {
            string strProgLangTypeId = clsProgLangTypeExWApi.GetProgLangTypeIdByLangType_Cache(ltLangType);
            IEnumerable<clsvCodeType_SimEN> arrCodeType = clsvCodeType_SimWApi.GetObjLstCache();
            IEnumerable<clsvCodeType_SimEN> arrCodeType_Sel = arrCodeType.Where(x => IsMatchV2(x, strClassName, strProgLangTypeId));
            string strTabName = "";
            string strCodeTypeId = "";

            if (arrCodeType_Sel.Count() > 0)
            {
                clsvCodeType_SimEN objvCodeType_Sim = arrCodeType_Sel.First();
                strCodeTypeId = objvCodeType_Sim.CodeTypeId;
                if (objvCodeType_Sim.DependsOn == "PureClass")
                {
                    return Tuple.Create(strTabName, strCodeTypeId);
                }
                var objCodeTypeEN = clsCodeTypeWApi.GetObjByCodeTypeId(objvCodeType_Sim.CodeTypeId);
                string strPattern = objCodeTypeEN.ClassNamePattern.Replace("\\b", "");
                int intStart_S = strPattern.IndexOf("\\S*");

                string strEndWith = strPattern.Substring(intStart_S + 3);

                int intEnd_S = strClassName.LastIndexOf(strEndWith);

                strTabName = strClassName.Substring(intStart_S, intEnd_S - intStart_S);
                //strTabName = "";

            }
            else
            {
                strCodeTypeId = "0192";
                return Tuple.Create(strTabName, strCodeTypeId);
            }
            Tuple<string, string> TypeGroup = Tuple.Create(strTabName, strCodeTypeId);
            return TypeGroup;

        }
        /// <summary>
        /// 获取所给语言类型的[前台][Web]代码类型对象列表
        /// </summary>     
        /// <param name="intApplicationTypeId"></param>
        /// <returns></returns>
        public static List<clsvCodeType_SimEN> GetCodeTypeObjLstByApplicationType4Front4Web(int intApplicationTypeId)
        {
            List<string> arrDependsOn = new List<string>() { "View" };
            IEnumerable<clsAppCodeTypeRelaEN> arrAppCodeTypeRela = clsAppCodeTypeRelaExWApi.GetObjLstByApplicationTypeIdCache(intApplicationTypeId)
                                  .OrderBy(x => x.OrderNum);
            IEnumerable<string> arrCodeTypeId = arrAppCodeTypeRela.Select(x => x.CodeTypeId);
            string strKey = string.Format("{0}", clsCodeTypeEN._CurrTabName);
            List<clsvCodeType_SimEN> arrCodeTypeObjLst_Cache = clsvCodeType_SimWApi.GetObjLstCache();
            List<clsvCodeType_SimEN> arrCodeTypeObjList =
                arrCodeTypeObjLst_Cache
                .Where(x => arrCodeTypeId.Contains(x.CodeTypeId)
                                && arrDependsOn.Contains(x.DependsOn)).ToList();
            return arrCodeTypeObjList;
          
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DdlBindFunction)
        /// </summary>
        /// <param name = "objComboBox">需要绑定当前表的下拉框</param>
        /// <param name = "intApplicationTypeId">应用类型Id</param>
        public static void BindCbo_CodeTypeIdByApplicationTypeidEx(System.Windows.Forms.ComboBox objComboBox,
            int intApplicationTypeId)
        {
            //为数据源于表的下拉框设置内容

            string strCondition = string.Format(" {0} in (Select {0} From {1} where {2}={3}) Order By {0}",
                conCodeType.CodeTypeId, conAppCodeTypeRela._CurrTabName,
                conAppCodeTypeRela.ApplicationTypeId, intApplicationTypeId,
                conCodeType.OrderNum);
            List<clsCodeTypeEN> arrObjLst = clsCodeTypeWApi.GetObjLst(strCondition);


            clsCodeTypeEN objCodeTypeEN;
            //初始化一个对象列表
            List<clsCodeTypeEN> CodeTypeList = new List<clsCodeTypeEN>();
            //插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
            objCodeTypeEN = new clsCodeTypeEN();
            objCodeTypeEN.CodeTypeId = "0";
            objCodeTypeEN.CodeTypeName = "请选择...";
            objCodeTypeEN.OrderNum = 0;
            CodeTypeList.Add(objCodeTypeEN);
            //把DataTable中的所有项均加到对象列表中
            foreach (clsCodeTypeEN objInFor in arrObjLst)
            {
                clsAppCodeTypeRelaEN objAppCodeTypeRelaEN = clsAppCodeTypeRelaExWApi.GetObjByAppAndCodeType(intApplicationTypeId, objInFor.CodeTypeId);
                objCodeTypeEN = new clsCodeTypeEN();
                objCodeTypeEN.OrderNum = objAppCodeTypeRelaEN.OrderNum;
                objCodeTypeEN.CodeTypeId = objInFor.CodeTypeId;
                objCodeTypeEN.CodeTypeName = string.Format("{0}({1})-{2}",
                    objInFor.CodeTypeName,
                     objInFor.CodeTypeId,
                     objCodeTypeEN.OrderNum);
                CodeTypeList.Add(objCodeTypeEN);
            }
            CodeTypeList.Sort((clsCodeTypeEN h1, clsCodeTypeEN h2) =>
            {
                if (h1.OrderNum < h2.OrderNum)
                {
                    return -1;//左值小于右值，返回-1，为升序，如果返回1，就是降序  
                }
                else if (h1.OrderNum == h2.OrderNum)//左值等于右值，返回0  
                {
                    return 0;
                }
                else
                {
                    return 1;//左值大于右值，返回1，为升序，如果返回-1，就是降序  
                }
            });
            //设置下拉框的数据源、以及设置值项、显示项
            objComboBox.DataSource = CodeTypeList;
            objComboBox.ValueMember = "CodeTypeId";
            objComboBox.DisplayMember = "CodeTypeName";
            objComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// 根据语言类型获取相关对象, 从缓存的对象列表中获取,使用顺序查询.
        /// </summary>
        /// <param name = "cnClassName">所给的类名</param>
        /// <param name = "ltLangType">所给的语言类型</param>
        /// <returns>根据关键字获取的对象</returns>
        public static string GetCodeTypeIdByClassName_Cache(clsPubConst.ClassName cnClassName, clsPubConst.LangType ltLangType)
        {
            string strCodeTypeENName = clsPubConst.GetClassNameStringByClassName(cnClassName);
            //string str = clsPubConst.GetLangTypeStringByLangType(ltLangType);
            clsProgLangTypeEN objProgLangTypeEN = clsProgLangTypeExWApi.GetObjByLangType_Cache(ltLangType);
            string strWhereCond = string.Format("1 = 1 order by {0}", conCodeType.OrderNum);
            string strKey = string.Format("{0}", clsCodeTypeEN._CurrTabName);
            List<clsvCodeType_SimEN> arrCodeTypeObjLst_Cache = clsvCodeType_SimWApi.GetObjLstCache();
            foreach (clsvCodeType_SimEN objCodeTypeEN in arrCodeTypeObjLst_Cache)
            {
                if (objCodeTypeEN.CodeTypeENName == strCodeTypeENName && objCodeTypeEN.ProgLangTypeId == objProgLangTypeEN.ProgLangTypeId)
                {
                    intFindFailCount = 0;
                    return objCodeTypeEN.CodeTypeId;
                }
            }
            intFindFailCount++;
            // 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
            clsCodeTypeWApi.ReFreshCache();
            if (intFindFailCount == 1) return GetCodeTypeIdByClassName_Cache(cnClassName, ltLangType);
            string strErrMsgForGetObjById = string.Format("在CodeType对象缓存列表中,找不到记录[cnClassName = {0},ltLangType={1}][intFindFailCount = {2}](函数:{3})",
                strCodeTypeENName, ltLangType,
                intFindFailCount, clsStackTrace.GetCurrClassFunction());
            clsLog.LogErrorS2("clsCodeTypeBLEx", clsStackTrace.GetCurrFunction(), strErrMsgForGetObjById, "", "");
            throw new Exception(strErrMsgForGetObjById);
        }

        /// <summary>
        /// 获取所给语言类型的[前台][Web]代码类型对象列表
        /// </summary>
        /// <param name="ltLangType"></param>
        /// <returns></returns>
        public static List<clsCodeTypeEN> GetCodeTypeObjLstByLangType4Front4Win(clsPubConst.LangType ltLangType)
        {
            string strCondition = string.Format(" {0}='前台' and {1}='1'",
                conCodeType.FrontOrBack, conCodeType.IsWin);
            switch (ltLangType)
            {
                case clsPubConst.LangType.CSharp:
                    strCondition += string.Format(" And {0}='1'", conCodeType.IsCSharp);
                    break;
                case clsPubConst.LangType.JAVA:
                    strCondition += string.Format(" And {0}='1'", conCodeType.IsJava);
                    break;
                case clsPubConst.LangType.Swift:
                    strCondition += string.Format(" And {0}='1'", conCodeType.IsSwift);
                    break;
                case clsPubConst.LangType.Swift3:
                    strCondition += string.Format(" And {0}='1'", conCodeType.IsSwift);
                    break;
                case clsPubConst.LangType.JavaScript:
                    strCondition += string.Format(" And {0}='1'", conCodeType.IsJavaScript);
                    break;
                case clsPubConst.LangType.SilverLight:
                    strCondition += string.Format(" And {0}='1'", conCodeType.IsSilverLight);
                    break;
                case clsPubConst.LangType.VB:
                    strCondition += string.Format(" And {0}='1'", conCodeType.IsVB);
                    break;
            }
            strCondition += string.Format(" Order By {0}", conCodeType.OrderNum);
            List<clsCodeTypeEN> arrCodeTypeObjList = clsCodeTypeWApi.GetObjLst(strCondition);
            return arrCodeTypeObjList;
        }


        public static bool IsCanVisible(List<clsCodeTypeEN> arrCodeTypeObjList, Button btnClassName)
        {
            foreach (clsCodeTypeEN objCodeTypeEN in arrCodeTypeObjList)
            {
                if (btnClassName.Name.Substring(3) == objCodeTypeEN.CodeTypeENName)
                {
                    btnClassName.Visible = true;
                    return true;
                }
            }
            btnClassName.Visible = false;
            return false;
        }

    }
}