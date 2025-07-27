
using com.taishsoft.common;
using CommFunc4WebForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace AGC.FunClass
{
    public class clsPubFun4Web
    {
        /// <summary>
        /// 检查表一致性。检查生成代码中与Sql库中字段是否一致
        /// </summary>
        /// <param name="thisPage"></param>
        /// <param name="strTabId"></param>
        /// <param name="strParentPage"></param>
        /// <returns></returns>
        public static bool CheckConsistency(Page thisPage, string strTabId, string strParentPage)
        {
            clsCommonSession.TabId = strTabId;
          clsCommonSession.ParentPage = strParentPage;// "wfmPrjTab_QUDI3.aspx";
            if (clsPubVar.CurrDataBaseTypeId == "03")
            {
                thisPage.Response.Redirect("../Table/wfmPrjTab_CheckConsistency_Ora.aspx?ParentPage=" + strParentPage);
            }
            else
            {
                thisPage.Response.Redirect("../Table/wfmPrjTab_CheckConsistency.aspx?ParentPage=" + strParentPage);
            }
            return true;
        }
        /// <summary>
        /// 跳转到编辑表字段和对象字段
        /// </summary>
        /// <param name="thisPage"></param>
        /// <param name="strTabId"></param>
        /// <param name="strObjId"></param>
        /// <param name="strParentPage"></param>
        /// <returns></returns>
        public static bool JumpToEditTabAndObjectFieldsBak0170705(Page thisPage, 
            string strTabId, string strObjId, string strParentPage)
        {
            clsCommonSession.TabId = strTabId;
            clsCommonSession.ParentPage = strParentPage;
            string strNextPage = string.Format("../Table/wfmEditTabAndObjectFields.aspx?ParentPage={0}&TabId={1}&ObjId={2}",
                strParentPage, strTabId, strObjId);
            thisPage.Response.Redirect(strNextPage);

            return true;
        }
        /// <summary>
        /// 跳转到编辑表字段和表
        /// </summary>
        /// <param name="thisPage"></param>
        /// <param name="strTabId"></param>    
        /// <param name="strParentPage"></param>
        /// <returns></returns>
        public static bool JumpToEditTabAndFields(Page thisPage,
            string strTabId, string strParentPage)
        {
            clsCommonSession.TabId = strTabId;
            clsCommonSession.ParentPage = strParentPage;
            string strNextPage = string.Format("../Table/wfmEditTabAndObjectFields.aspx?ParentPage={0}&TabId={1}",
                strParentPage, strTabId);
            thisPage.Response.Redirect(strNextPage);

            return true;
        }
        /// <summary>
        /// 处理错误
        /// </summary>
        /// <param name="thisPage"></param>
        /// <param name="strParentPage"></param>
        /// <returns></returns>
        public static bool AccessError(Page thisPage, string strParentPage)
        {
            clsCommonSession.ParentPage = strParentPage;// "wfmPrjTab_QUDI3.aspx";
                thisPage.Response.Redirect("../error.aspx?ParentPage=" + strParentPage);
            return true;
        }

        /// <summary>
        /// 跳转到工程表列表界面
        /// </summary>
        /// <param name="thisPage"></param>
        /// <param name="strParentPage"></param>
        /// <returns></returns>
        public static bool JumpToPrjTab_QUDI3(Page thisPage, string strParentPage)
        {
            clsCommonSession.ParentPage = strParentPage;// "wfmPrjTab_QUDI3.aspx";
            thisPage.Response.Redirect("../Table/wfmPrjTab_QUDI3.aspx?ParentPage=" + strParentPage);
            return true;
        }

        /// <summary>
        /// 跳转到WebSrv类函数维护界面
        /// </summary>
        /// <param name="thisPage"></param>
        /// <param name="strParentPage"></param>
        /// <returns></returns>
        public static bool JumpToWebSrvFunctionsB_QUDI(Page thisPage, 
            string strParentPage, string strWebSrvClassId)
        {
            if (string.IsNullOrEmpty(strWebSrvClassId) == true)
            {
                string strMsg = string.Format("WebSrv类Id不能为空！({0}->{1})", 
                    clsStackTrace.GetCurrClassFunctionByLevel(2),
                    clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(thisPage, strMsg);
                return false;
            }
            clsCommonSession.ParentPage = strParentPage;// "wfmPrjTab_QUDI3.aspx";
            string strNext = string.Format("../GenCode/wfmWebSrvFunctionsB_QUDI.aspx?ParentPage={0}&WebSrvClassId={1}", strParentPage, strWebSrvClassId);
            thisPage.Response.Redirect(strNext);
            return true;
        }

        /// <summary>
        /// 跳转到表检查界面
        /// </summary>
        /// <param name="thisPage"></param>
        /// <param name="strParentPage"></param>
        /// <returns></returns>
        public static bool JumpToTabCheckResultB_QUDI(Page thisPage, string strParentPage)
        {
            clsCommonSession.ParentPage = strParentPage;// "wfmPrjTab_QUDI3.aspx";
            thisPage.Response.Redirect("../LogManage/wfmTabCheckResultB_QUDI.aspx?ParentPage=" + strParentPage);
            return true;
        }

        /// <summary>
        /// 跳转到表检查界面
        /// </summary>
        /// <param name="thisPage"></param>
        /// <param name="strParentPage"></param>
        /// <returns></returns>
        public static bool JumpToFieldTab_U(Page thisPage, string strTabId, string strFldId, string strParentPage)
        {
            clsCommonSession.ParentPage = strParentPage;// "wfmPrjTab_QUDI3.aspx";
            thisPage.Response.Redirect(string.Format("../Field/wfmFieldTab_U.aspx?Operator=UpdateInTab&TabId={0}&FldId={1}&ParentPage={2}", 
                strTabId, strFldId, strParentPage));
            return true;
        }
        /// <summary>
        /// 跳转到界面操作步骤
        /// </summary>
        /// <param name="thisPage"></param>
        /// <param name="strParentPage"></param>
        /// <returns></returns>
        public static bool JumpToViewOptSteps_QUDI(Page thisPage, string strParentPage)
        {
            clsCommonSession.ParentPage = strParentPage;// "wfmPrjTab_QUDI3.aspx";
            thisPage.Response.Redirect("../View/wfmViewOptSteps_QUDI.aspx?ParentPage=" + strParentPage);
            return true;
        }
        /// <summary>
        /// 跳转到界面关系表
        /// </summary>
        /// <param name="thisPage"></param>
        /// <param name="strParentPage"></param>
        /// <returns></returns>
        public static bool JumpToViewRelaTab_QUDI(Page thisPage, string strParentPage)
        {
            clsCommonSession.ParentPage = strParentPage;// "wfmPrjTab_QUDI3.aspx";
            thisPage.Response.Redirect("../View/wfmViewRelaTab_QUDI.aspx?ParentPage=" + strParentPage);
            return true;
        }
        /// <summary>
        /// 跳转到界面按钮操作步骤
        /// </summary>
        /// <param name="thisPage"></param>
        /// <param name="strParentPage"></param>
        /// <returns></returns>
        public static bool JumpToViewBtnOptSteps_QUDI(Page thisPage, string strParentPage)
        {
            clsCommonSession.ParentPage = strParentPage;// "wfmPrjTab_QUDI3.aspx";
            thisPage.Response.Redirect("../View/wfmViewBtnOptSteps_QUDI.aspx?ParentPage=" + strParentPage);
            return true;
        }
        /// <summary>
        /// 跳转到界面添加字段
        /// </summary>
        /// <param name="thisPage"></param>
        /// <param name="strParentPage"></param>
        /// <returns></returns>
        public static bool JumpToViewAddField(Page thisPage, string strParentPage)
        {
            clsCommonSession.ParentPage = strParentPage;
            thisPage.Response.Redirect("../View/wfmViewAddField.aspx?ParentPage=" + strParentPage);
            return true;
        }
        /// <summary>
        /// 跳转到界面设置字段
        /// </summary>
        /// <param name="thisPage"></param>
        /// <param name="strParentPage"></param>
        /// <returns></returns>
        public static bool JumpToViewSetField(Page thisPage, string strParentPage)
        {
            clsCommonSession.ParentPage = strParentPage;
            thisPage.Response.Redirect("../View/wfmViewSetField.aspx?ParentPage=" + strParentPage);
            return true;
        }
        /// <summary>
        /// 跳转到界面设计
        /// </summary>
        /// <param name="thisPage"></param>
        /// <param name="strParentPage"></param>
        /// <returns></returns>
        public static bool JumpToDesignView3(Page thisPage, string strParentPage)
        {
            clsCommonSession.ParentPage = strParentPage;
            thisPage.Response.Redirect("../GenCode/wfmDesignView3.aspx?ParentPage=" + strParentPage);
            return true;
        }
        /// <summary>
        /// 跳转到界面设计
        /// </summary>
        /// <param name="thisPage"></param>
        /// <param name="strParentPage"></param>
        /// <returns></returns>
        public static bool JumpToViewRegion_QUDI(Page thisPage, string strParentPage)
        {
            clsCommonSession.ParentPage = strParentPage;
            thisPage.Response.Redirect("../View/wfmViewRegion_QUDI.aspx?ParentPage=" + strParentPage);
            return true;
        }
        /// <summary>
        /// 跳转到界面编辑
        /// </summary>
        /// <param name="thisPage"></param>
        /// <param name="strParentPage"></param>
        /// <returns></returns>
        public static bool JumpToViewInfo_U(Page thisPage, string strParentPage)
        {
            clsCommonSession.ParentPage = strParentPage;
            thisPage.Response.Redirect("../View/wfmViewInfo_U.aspx?ParentPage=" + strParentPage);
            return true;
        }
        /// <summary>
        /// 跳转到界面编辑
        /// </summary>
        /// <param name="thisPage"></param>
        /// <param name="strParentPage"></param>
        /// <returns></returns>
        public static bool JumpToAddViewRelaRegion(Page thisPage, string strParentPage)
        {
            clsCommonSession.ParentPage = strParentPage;
            thisPage.Response.Redirect("../View/wfmViewRegion_QUDI2.aspx?Operator=AddViewRelaRegion&ParentPage=" + strParentPage);
            return true;
        }
        public static void AddQueryFieldName(List<string> arrQueryFieldName, string strQueryFieldName)
        {
            if (arrQueryFieldName.Contains(strQueryFieldName) == false)
            {
                arrQueryFieldName.Add(strQueryFieldName);
            }
        }
    }
}