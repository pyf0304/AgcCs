
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvPrjTab_SimExWApi
表名:vPrjTab_Sim(00050597)
生成代码版本:2021.12.17.1
生成日期:2021/12/18 01:25:43
生成者:pyf
生成服务器IP:103.116.76.183
工程名称:AGC(0005)
CM工程:AgcSpa后端(变量首字母不限定)
相关数据库:103.116.76.183,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:字段、表维护(Table_Field)
框架-层名:WA_访问扩展层(WA_AccessEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
**/
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
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Linq;


namespace AGC4WApi
{
    public static class clsvPrjTab_SimExWApi_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objvPrjTab_SimENS">源对象</param>
        /// <returns>目标对象=>clsvPrjTab_SimEN:objvPrjTab_SimENT</returns>
        public static clsvPrjTab_SimENEx CopyToEx(this clsvPrjTab_SimEN objvPrjTab_SimENS)
        {
            try
            {
                clsvPrjTab_SimENEx objvPrjTab_SimENT = new clsvPrjTab_SimENEx();
                clsvPrjTab_SimWApi.CopyTo(objvPrjTab_SimENS, objvPrjTab_SimENT);
                return objvPrjTab_SimENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:Watl000068)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 获取对象扩展信息
        /// </summary>
        /// <param name="objUserCodePathEx"></param>
        /// <returns></returns>
        public static void GetObjExInfo1(this clsvPrjTab_SimENEx objPrjTabEx, clsUserCodePathENEx objUserCodePathEx)
        {
            clsvCodeType_SimEN objCodeTypeEN = clsvCodeType_SimWApi.GetObjByCodeTypeIdCache(objUserCodePathEx.CodeTypeId);
            objPrjTabEx.CodeTypeId = objUserCodePathEx.CodeTypeId;
            objPrjTabEx.ObjFuncModule = clsFuncModule_AgcWApi.GetObjByFuncModuleAgcIdCache(objPrjTabEx.FuncModuleAgcId, objPrjTabEx.PrjId);
            objPrjTabEx.FileName = string.Format(objCodeTypeEN.FileNameFormat, objPrjTabEx.TabName);
            //this.ObjGCPrjRelaFile.PrjInnerCodePath = objUserCodePathEx.GetPrjInnerCodePath();
            objPrjTabEx.PrjInnerFileName = clsPrjTabExWApi.GetFileNameInPrj(objUserCodePathEx.PrjInnerCodePath,
                objPrjTabEx.ObjFuncModule.FuncModuleEnName, objPrjTabEx.FileName);

            //this.ObjGCPrjRelaFile.FullProjectPath = objUserCodePathEx.GetFullProjectPath(this.ObjUserCodePrjMainPath);
            objPrjTabEx.FullFileName = string.Format("{0}\\{1}\\{2}", objUserCodePathEx.NewCodePath,
                objPrjTabEx.ObjFuncModule.FuncModuleEnName, objPrjTabEx.FileName);
            objPrjTabEx.FullFileName = objPrjTabEx.FullFileName.Replace("\\/\\", "\\")
                              .Replace("/", "\\").Replace("\\\\", "\\");

            objPrjTabEx.SuffixPath = objUserCodePathEx.SuffixPath;
            objPrjTabEx.TabSpace = objPrjTabEx.DataBaseName;
            objPrjTabEx.objProjectsEN = clsProjectsWApi.GetObjByPrjIdCache(objPrjTabEx.PrjId);
        }


    }
    /// <summary>
    /// v工程表_Sim(vPrjTab_Sim)
    /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
    /// </summary>
    public class clsvPrjTab_SimExWApi
    {
        private static readonly string mstrApiControllerName = "vPrjTab_SimExApi";
        /// <summary>
        /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        public static List<clsvPrjTab_SimEN> arrvPrjTab_SimObjLst_Cache = null;
        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        protected static int intFindFailCount = 0;

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_ClassConstructor1)
        /// </summary>
        public clsvPrjTab_SimExWApi()
        {
        }

        /// <summary>
        /// 修改记录
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_EditRecordEx)
        /// </summary>
        /// <returns>是否成功?</returns>
        public static bool EditRecordEx(clsvPrjTab_SimEN objvPrjTab_SimEN)
        {
            if (string.IsNullOrEmpty(objvPrjTab_SimEN.sfUpdFldSetStr) == true)
            {
                string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
                objvPrjTab_SimEN.TabId, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            string strAction = "EditRecordEx";
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            try
            {
                string strJson = clsJSON.GetJsonFromObj<clsvPrjTab_SimEN>(objvPrjTab_SimEN);
                if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
                {
                    JObject jobjReturn0 = JObject.Parse(strResult);
                    if ((int)jobjReturn0["errorId"] == 0)
                    {
                        var bolReturnBool = (bool)jobjReturn0["returnBool"];
                        return bolReturnBool;
                    }
                    else
                    {
                        string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
                        throw new Exception(strMsg);
                    }
                }
                else return false;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
                     HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
               clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
                throw new Exception(strMsg);
            }
        }
        /// <summary>
        /// GetObjExLstByPrjIdEx
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCode)
        /// </summary>
        /// <param name = "strPrjId">工程Id</param>
        /// <returns>返回对象列表</returns>
        public static List<clsvPrjTab_SimENEx> GetObjExLstByPrjIdEx(string strPrjId)
        {
            string strAction = "GetObjExLstByPrjIdEx";
            string strErrMsg = string.Empty;
            string strResult = "";
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strPrjId"] = strPrjId,
            };
            try
            {
                if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
                {
                    JObject jobjReturn = JObject.Parse(strResult);
                    if ((int)jobjReturn["errorId"] == 0)
                    {
                        string strJson = JsonConvert.SerializeObject(jobjReturn["returnObjLst"]);
                        var varResult = JsonConvert.DeserializeObject<List<clsvPrjTab_SimENEx>>(strJson);

                        //var varResult1 = clsJSON.GetObjLstFromJson<clsPrjTabENEx>((string1)jobjReturn["returnObjLst"]);
                        return varResult;
                    }
                    else
                    {
                        string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
                        throw new Exception(strMsg);
                    }
                }
                else return null;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("GetObjExLstByPrjIdEx出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
        }

        public static void BindCbo_TabIdCacheEx(System.Windows.Forms.ComboBox objComboBox, string strCmPrjId)
        {
            //为数据源为表的下拉框设置内容
            //string strCondition = string.Format("PrjId = '{0}' order by {1}", strPrjId, conPrjTab.TabName);
            string strPrjId = clsCMProjectExWApi.GetPrjIdByCmPrjIdCache(strCmPrjId);
            var arrvCmProjectPrjTab_Sim = clsvCmProjectPrjTab_SimWApi.GetObjLstCache(strPrjId);
            var arrTabId = arrvCmProjectPrjTab_Sim.Where(x=>x.CmPrjId == strCmPrjId).Select(x => x.TabId).ToList();

            List<clsvPrjTab_SimEN> arrObj = clsvPrjTab_SimWApi.GetObjLstCache(strPrjId).Where(x=>arrTabId.Contains(x.TabId) == true).ToList();

            arrObj = arrObj.OrderBy(x=>x.TabName).ToList();
            clsvPrjTab_SimEN objPrjTabEN;
            //初始化一个对象列表
            ArrayList PrjTabList = new ArrayList();
            //插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
            objPrjTabEN = new clsvPrjTab_SimEN();
            objPrjTabEN.TabId = "0";
            objPrjTabEN.TabName = "请选择...";
            PrjTabList.Add(objPrjTabEN);
            //把DataTable中的所有项均加到对象列表中
            foreach (clsvPrjTab_SimEN objRow in arrObj)
            {
                PrjTabList.Add(objRow);
            }
            //设置下拉框的数据源、以及设置值项、显示项
            objComboBox.DataSource = PrjTabList;
            objComboBox.ValueMember = "TabId";
            objComboBox.DisplayMember = "TabName";
            objComboBox.SelectedIndex = 0;
        }

    }
}