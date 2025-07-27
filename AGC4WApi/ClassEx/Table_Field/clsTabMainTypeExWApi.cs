
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsTabMainTypeExWApi
表名:TabMainType(00050534)
生成代码版本:2020.02.16.1
生成日期:2020/02/18 11:38:26
生成者:
生成服务器IP:192.168.1.10
工程名称:AGC
工程ID:0005
相关数据库:tzar.tpddns.cn,19433AGC_CS12
PrjDataBaseId:0213
模块中文名:系统参数
模块英文名:SysPara
框架-层名:WA_访问扩展层CSharp(WA_AccessEx)
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
using Newtonsoft.Json.Linq; 
using System.Linq;

namespace AGC4WApi
{
    public static class clsTabMainTypeExWApi_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objTabMainTypeENS">源对象</param>
        /// <returns>目标对象=>clsTabMainTypeEN:objTabMainTypeENT</returns>
        public static clsTabMainTypeENEx CopyToEx(this clsTabMainTypeEN objTabMainTypeENS)
        {
            try
            {
                clsTabMainTypeENEx objTabMainTypeENT = new clsTabMainTypeENEx();
                clsTabMainTypeWApi.CopyTo(objTabMainTypeENS, objTabMainTypeENT);
                return objTabMainTypeENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:Watl000002)Copy表对象数据出错,{1}.({0})",
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
        /// <param name = "objTabMainTypeEN">需要添加的实体对象</param>
        /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
        public static bool EditRecordEx(this clsTabMainTypeEN objTabMainTypeEN)
        {
            try
            {
                objTabMainTypeEN.sfUpdFldSetStr = objTabMainTypeEN.getsfUpdFldSetStr();
                bool bolResult = clsTabMainTypeExWApi.EditRecordEx(objTabMainTypeEN);
                // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
                clsTabMainTypeWApi.ReFreshCache();
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
    /// TabMainType(TabMainType)
    /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
    /// </summary>
    public class clsTabMainTypeExWApi
    {
        public static List<clsTabMainTypeEN> arrTabMainTypeObjLst = null;
        public static bool bolIsSelectIndexAfterBindCbo = false;

        private static readonly string mstrApiControllerName = "TabMainTypeExApi";
        /// <summary>
        /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        public static List<clsTabMainTypeEN> arrTabMainTypeObjLst_Cache = null;
        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        protected static int intFindFailCount = 0;

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_ClassConstructor1)
        /// </summary>
        public clsTabMainTypeExWApi()
        {
        }

        /// <summary>
        /// 修改记录
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_EditRecordEx)
        /// </summary>
        /// <returns>是否成功?</returns>
        public static bool EditRecordEx(clsTabMainTypeEN objTabMainTypeEN)
        {
            if (string.IsNullOrEmpty(objTabMainTypeEN.sfUpdFldSetStr) == true)
            {
                string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
                objTabMainTypeEN.TabMainTypeId, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            string strAction = "EditRecordEx";
            string strErrMsg = string.Empty;
            string strResult = "";
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            try
            {
                string strJson = clsJSON.GetJsonFromObj<clsTabMainTypeEN>(objTabMainTypeEN);
                if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
                {
                    JObject jobjReturn = JObject.Parse(strResult);
                    if ((int)jobjReturn["errorId"] == 0)
                    {
                        var bolReturnBool = (bool)jobjReturn["returnBool"];
                        return bolReturnBool;
                    }
                    else
                    {
                        string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
        /// 绑定基于Win的下拉框
        /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ComboBoxBindFunction)
        /// </summary>
        /// <param name="objComboBox">需要绑定当前表的下拉框</param>
        public static void BindCbo_TabMainTypeIdByAppIdCache(System.Windows.Forms.ComboBox objComboBox, int intApplicationTypeId)
        {
            //为数据源为表的下拉框设置内容
            
            if (intApplicationTypeId == 0) return;
            bolIsSelectIndexAfterBindCbo = true;
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");

            IEnumerable<clsAppCodeTypeRelaEN> arrAppCodeTypeRelaObjLst = clsAppCodeTypeRelaWApi.GetObjLstCache()
                .Where(x => x.ApplicationTypeId == intApplicationTypeId)
               .OrderBy(x => x.OrderNum);
            IEnumerable<string> arrTabMainTypeId = arrAppCodeTypeRelaObjLst.Select(x => x.TabMainTypeId);

            arrTabMainTypeObjLst = clsTabMainTypeWApi.GetObjLstCache()
                .Where(x => arrTabMainTypeId.Contains(x.TabMainTypeId))
                .ToList();
            //GetAppCodeTypeRelaObjLstByApplicationTypeIdCache(strApplicationTypeId);
            if (arrTabMainTypeObjLst == null)
            {
                string strMsg = string.Format("应用:[{0}]没有相应的代码类型，请联系管理员！", 
                    clsApplicationTypeWApi.GetNameByApplicationTypeIdCache(intApplicationTypeId));
                throw new Exception(strMsg);
            }

            clsTabMainTypeEN objTabMainTypeEN;
            //初始化一个对象列表
            //插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
            objTabMainTypeEN = new clsTabMainTypeEN();
            objTabMainTypeEN.TabMainTypeId = "0";
            objTabMainTypeEN.TabMainTypeName = "选[TabMainType]...";
            arrTabMainTypeObjLst.Insert(0, objTabMainTypeEN);
            //把DataTable中的所有项均加到对象列表中
            //设置下拉框的数据源、以及设置值项、显示项
            objComboBox.DataSource = arrTabMainTypeObjLst;
            objComboBox.ValueMember = "TabMainTypeId";
            objComboBox.DisplayMember = "TabMainTypeName";

            bolIsSelectIndexAfterBindCbo = true;
            if (arrTabMainTypeObjLst.Count > 1)
            {
                objComboBox.SelectedIndex = 1;
            }
            else
            {
                objComboBox.SelectedIndex = 0;
            }
        }
        public static void BindCbo_TabMainTypeIdCache(System.Windows.Forms.ComboBox objComboBox)
        {
            //为数据源为表的下拉框设置内容
            string strCondition = string.Format("1 =1 Order By {0}", conTabMainType.TabMainTypeId);
            List<clsTabMainTypeEN> arrObjLst = clsTabMainTypeWApi.GetObjLstCache();
            //初始化一个对象列表
            //插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
            clsTabMainTypeEN objTabMainTypeEN = new clsTabMainTypeEN()
            {
                TabMainTypeId = "0",
                TabMainTypeName = "选[表主类型]..."
            };
            arrObjLst.Insert(0, objTabMainTypeEN);
            //设置下拉框的数据源、以及设置值项、显示项
            objComboBox.ValueMember = conTabMainType.TabMainTypeId;
            objComboBox.DisplayMember = conTabMainType.TabMainTypeName;
            objComboBox.DataSource = arrObjLst;
            objComboBox.SelectedIndex = 0;
        }

    }
}