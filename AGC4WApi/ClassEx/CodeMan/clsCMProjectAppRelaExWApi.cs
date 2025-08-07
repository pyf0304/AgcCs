
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsCMProjectAppRelaExWApi
表名:CMProjectAppRela(00050600)
生成代码版本:2021.12.24.1
生成日期:2021/12/24 12:01:04
生成者:pyf
生成服务器IP:
工程名称:AGC(0005)
CM工程:AgcSpa后端(变量首字母不限定)
相关数据库:103.116.76.183,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:代码管理(CodeMan)
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
using System.Linq;
using com.taishsoft.datetime;
using System.Data.SqlTypes;

namespace AGC4WApi
{
    public static class clsCMProjectAppRelaExWApi_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objCMProjectAppRelaENS">源对象</param>
        /// <returns>目标对象=>clsCMProjectAppRelaEN:objCMProjectAppRelaENT</returns>
        public static clsCMProjectAppRelaENEx CopyToEx(this clsCMProjectAppRelaEN objCMProjectAppRelaENS)
        {
            try
            {
                clsCMProjectAppRelaENEx objCMProjectAppRelaENT = new clsCMProjectAppRelaENEx();
                clsCMProjectAppRelaWApi.CopyTo(objCMProjectAppRelaENS, objCMProjectAppRelaENT);
                return objCMProjectAppRelaENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:Watl000068)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
        public static string ApplicationTypeName(this clsCMProjectAppRelaEN objCMProjectAppRelaEN)
        {
            try
            {
                clsApplicationTypeEN objApplicationTypeEN = clsApplicationTypeWApi.GetObjByApplicationTypeIdCache(objCMProjectAppRelaEN.ApplicationTypeId);
                return objApplicationTypeEN.ApplicationTypeName;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:Watl000069)获取ApplicationTypeName数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
        /// <summary>
        /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
        /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_Static_EditRecordEx)
        /// </summary>
        /// <param name = "objCMProjectAppRelaEN">需要添加的实体对象</param>
        /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
        public static bool EditRecordEx(this clsCMProjectAppRelaEN objCMProjectAppRelaEN)
        {
            try
            {
                objCMProjectAppRelaEN.sfUpdFldSetStr = objCMProjectAppRelaEN.getsfUpdFldSetStr();
                bool bolResult = clsCMProjectAppRelaExWApi.EditRecordEx(objCMProjectAppRelaEN);
                // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
                clsCMProjectAppRelaWApi.ReFreshCache(objCMProjectAppRelaEN.PrjId);
                return bolResult;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:Watl000006)编辑记录出错,{1}!(from {0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
    }
    /// <summary>
    /// CM项目应用关系(CMProjectAppRela)
    /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
    /// </summary>
    public class clsCMProjectAppRelaExWApi
    {
        private static readonly string mstrApiControllerName = "CMProjectAppRelaExApi";
        /// <summary>
        /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        public static List<clsCMProjectAppRelaEN> arrCMProjectAppRelaObjLst_Cache = null;
        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        protected static int intFindFailCount = 0;

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_ClassConstructor1)
        /// </summary>
        public clsCMProjectAppRelaExWApi()
        {
        }

        /// <summary>
        /// 修改记录
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_EditRecordEx)
        /// </summary>
        /// <returns>是否成功?</returns>
        public static bool EditRecordEx(clsCMProjectAppRelaEN objCMProjectAppRelaEN)
        {
            if (string.IsNullOrEmpty(objCMProjectAppRelaEN.sfUpdFldSetStr) == true)
            {
                string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
                objCMProjectAppRelaEN.CMProjectAppRelaId, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            string strAction = "EditRecordEx";
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            try
            {
                string strJson = clsJSON.GetJsonFromObj<clsCMProjectAppRelaEN>(objCMProjectAppRelaEN);
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

        public static long AddCMProjectAppRelaId(string strCmPrjId, int intApplicationTypeId, string strPrjId)
        {
            if (intApplicationTypeId == 0)
            {
                throw new Exception($"ApplicationTypeId:{intApplicationTypeId} 不正确！({clsStackTrace.GetCurrClassFunction()})");
            }
            if (strPrjId =="0000")
            {
                throw new Exception($"PrjId:{strPrjId} 不正确！({clsStackTrace.GetCurrClassFunction()})");
            }
            var arrCMProjectAppRelaObjLst_Cache = clsCMProjectAppRelaWApi.GetObjLstCache(strPrjId);
            try
            {
                var arrCMProjectAppRela_Sel = arrCMProjectAppRelaObjLst_Cache.Where(x =>
                x.CmPrjId == strCmPrjId && x.ApplicationTypeId == intApplicationTypeId).ToList();
                if (arrCMProjectAppRela_Sel.Count > 0)
                {
                    return arrCMProjectAppRela_Sel[0].CMProjectAppRelaId;
                }
                else
                {
                    var obj = new clsCMProjectAppRelaEN();
                    obj.CmPrjId = strCmPrjId;
                    obj.PrjId = strPrjId;
                    obj.ApplicationTypeId= intApplicationTypeId;
                    obj.UpdUser = "sysauto";
                    obj.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                    obj.OrderNum = 1;
                    string strReturn = clsCMProjectAppRelaWApi.AddNewRecordWithReturnKey(obj);
                    return long.Parse(strReturn);
                }
            }
            catch (Exception objException)
            {
                var strMsg = string.Format("错误:[{0}]. \n根据Cm工程Id:[{1}]获取相应的对象列表不成功!(in {2}.{3})", objException.Message, strCmPrjId, clsStackTrace.GetCurrClassFunction());
                clsPubVar4WApi.objLog4Error.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }

        }

        public static long getCMProjectAppRelaId(string strCmPrjId, int intApplicationTypeId, string strPrjId)
        {
            var arrCMProjectAppRelaObjLst_Cache = clsCMProjectAppRelaWApi.GetObjLstCache(strPrjId);
            try
            {
                var arrCMProjectAppRela_Sel = arrCMProjectAppRelaObjLst_Cache.Where(x =>
                x.CmPrjId == strCmPrjId && x.ApplicationTypeId == intApplicationTypeId).ToList();
                if (arrCMProjectAppRela_Sel.Count > 0)
                {
                    return arrCMProjectAppRela_Sel[0].CMProjectAppRelaId;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception objException)
            {
                var strMsg = string.Format("错误:[{0}]. \n根据Cm工程Id:[{1}]获取相应的对象列表不成功!(in {2}.{3})", objException.Message, strCmPrjId, clsStackTrace.GetCurrClassFunction());
                clsPubVar4WApi.objLog4Error.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }

        }

        public static List<string> getCmPrjIdLstByAppTypeId(int intApplicationTypeId, string strPrjId)
        {
            var arrCMProjectAppRelaObjLst_Cache = clsCMProjectAppRelaWApi.GetObjLstCache(strPrjId);
            try
            {
                var arrCMProjectAppRela_Sel = arrCMProjectAppRelaObjLst_Cache.Where(x =>
                 x.ApplicationTypeId == intApplicationTypeId).ToList();
                return arrCMProjectAppRela_Sel.Select(x => x.CmPrjId).ToList();

            }
            catch (Exception objException)
            {
                var strMsg = string.Format("错误:[{0}]. \n根据AppId:[{1}]获取相应的对象列表不成功!(in {2}.{3})", objException.Message, intApplicationTypeId, clsStackTrace.GetCurrClassFunction());
                clsPubVar4WApi.objLog4Error.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }

        }

        public static List<int> getAppTypeIdLstByCmPrjId(string strCmPrjId, string strPrjId)
        {
            var arrCMProjectAppRelaObjLst_Cache = clsCMProjectAppRelaWApi.GetObjLstCache(strPrjId);
            try
            {
                var arrCMProjectAppRela_Sel = arrCMProjectAppRelaObjLst_Cache.Where(x =>
                 x.CmPrjId == strCmPrjId).ToList();
                return arrCMProjectAppRela_Sel.Select(x => x.ApplicationTypeId).ToList();

            }
            catch (Exception objException)
            {
                var strMsg = string.Format("错误:[{0}]. \n根据CmPrjId:[{1}]获取相应的对象列表不成功!(in {2}.{3})", objException.Message, strCmPrjId, clsStackTrace.GetCurrClassFunction());
                clsPubVar4WApi.objLog4Error.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }

        }


        /// <summary>
        /// 根据关键字获取相关对象, 从缓存中获取
        /// </summary>
        /// <param name="strCmPrjId"></param>
        /// <param name="strPrjId"></param>
        /// <returns></returns>
        public static List<clsCMProjectAppRelaEN> GetObjLstByCmPrjIdCache(string strCmPrjId, string strPrjId)
        {
            //const strThisFuncName = "GetObjLstByCmPrjId_Cache";
            var arrCMProjectAppRelaObjLst_Cache = clsCMProjectAppRelaWApi.GetObjLstCache(strPrjId);
            try
            {
                var arrCMProjectAppRela_Sel = arrCMProjectAppRelaObjLst_Cache.Where(x => x.CmPrjId == strCmPrjId).ToList();
                if (arrCMProjectAppRela_Sel.Count > 0)
                {
                    return arrCMProjectAppRela_Sel;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception objException)
            {
                var strMsg = string.Format("错误:[{0}]. \n根据Cm工程Id:[{1}]获取相应的对象列表不成功!(in {2}.{3})", objException.Message, strCmPrjId, clsStackTrace.GetCurrClassFunction());
                clsPubVar4WApi.objLog4Error.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }
        }
        public static void BindCbo_CmPrjIdAppEx0(System.Windows.Forms.ComboBox objComboBox, string strPrjId, int intApplicationTypeId, string strUserId)
        {
            //为数据源为表的下拉框设置内容
            string strCondition = string.Format("1 =1 Order By {0}", conCMProject.CmPrjId);
            List<clsCMProjectEN> arrObjLst = clsCMProjectWApi.GetObjLst(strCondition);
            arrObjLst = arrObjLst.Where(x => x.PrjId == strPrjId).ToList();


            List<clsvCmProjectAppRelaEN> arrvCmProjectAppRelaObjLst_Cache = clsvCmProjectAppRelaWApi.GetObjLstCache(strPrjId);

            var arrvCmProjectAppRela_Sel = arrvCmProjectAppRelaObjLst_Cache.Where(x => x.ApplicationTypeId == intApplicationTypeId
                                 && x.PrjId == strPrjId);
            var arrvCmProjectAppRelaEx = arrvCmProjectAppRela_Sel.Select(clsvCmProjectAppRelaExWApi.CopyToEx).ToList();

            foreach (var objInFor in arrvCmProjectAppRelaEx)
            {
                objInFor.CmPrjAppName = $"{objInFor.CmPrjName}-{objInFor.ApplicationTypeSimName}";
            }
            if (arrvCmProjectAppRelaEx.Count == 0)
            {
                objComboBox.Enabled = false;
            }
            //var arrObjLst_Sel = arrObjLst.Where(x => arrCmPrjId_Sel.Contains(x.CmPrjId) == true).ToList();

            //初始化一个对象列表
            //插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
            clsvCmProjectAppRelaENEx objCMProjectEN = new clsvCmProjectAppRelaENEx()
            {
                CMProjectAppRelaId = 0,
                CmPrjAppName = "选[CM项目]..."
            };
            arrvCmProjectAppRelaEx.Insert(0, objCMProjectEN);
            //设置下拉框的数据源、以及设置值项、显示项
            objComboBox.ValueMember = conCMProjectAppRela.CMProjectAppRelaId;
            objComboBox.DisplayMember = "CmPrjAppName";
            objComboBox.DataSource = arrvCmProjectAppRelaEx;
            objComboBox.SelectedIndex = 0;
        }

        public static void BindCbo_CmPrjIdAppByPrjIdEx(System.Windows.Forms.ComboBox objComboBox, string strPrjId)
        {
            //为数据源为表的下拉框设置内容
            //string strCondition = string.Format("1 =1 Order By {0}", conCMProject.CmPrjId);
            //List<clsCMProjectEN> arrObjLst = clsCMProjectWApi.GetObjLst(strCondition);
            //arrObjLst = arrObjLst.Where(x => x.PrjId == strPrjId).ToList();

            List<clsvCmProjectAppRelaEN> arrvCmProjectAppRelaObjLst_Cache = clsvCmProjectAppRelaWApi.GetObjLstCache(strPrjId);
            var arrvCmProjectAppRelaEx = arrvCmProjectAppRelaObjLst_Cache.Select(clsvCmProjectAppRelaExWApi.CopyToEx).OrderBy(x=>x.CmPrjName).ToList();

            foreach (var objInFor in arrvCmProjectAppRelaEx)
            {
                objInFor.CmPrjAppName = $"{objInFor.CmPrjName}-{objInFor.ApplicationTypeSimName}({objInFor.CMProjectAppRelaId})";
            }
            if (arrvCmProjectAppRelaEx.Count == 0)
            {
                objComboBox.Enabled = false;
            }
            //var arrObjLst_Sel = arrObjLst.Where(x => arrCmPrjId_Sel.Contains(x.CmPrjId) == true).ToList();

            //初始化一个对象列表
            //插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
            clsvCmProjectAppRelaENEx objvCmProjectAppRelaEN = new clsvCmProjectAppRelaENEx()
            {
                CMProjectAppRelaId = 0,
                CmPrjAppName = "选[CM项目]..."
            };
            arrvCmProjectAppRelaEx.Insert(0, objvCmProjectAppRelaEN);
            //设置下拉框的数据源、以及设置值项、显示项
            objComboBox.ValueMember = conCMProjectAppRela.CMProjectAppRelaId;
            objComboBox.DisplayMember = "CmPrjAppName";
            objComboBox.DataSource = arrvCmProjectAppRelaEx;
            objComboBox.SelectedIndex = 0;
        }

    }
}