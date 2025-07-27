using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AGC.Entity;

using com.taishsoft.commexception;
using com.taishsoft.commdb;
using AGC.BusinessLogic;
using com.taishsoft.common;
using AGC.DAL;
using com.taishsoft.datetime;
using AGC.PureClass;
using AGC.PureClassEx;
using System.Windows.Forms;

namespace AGC.BusinessLogicEx
{
    public static class clsFeatureRegionFldsBLEx_Static
    {
       
        //public static clsViewRegionEN ObjViewRegion(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strCmPrjId)
        //{
        //    try
        //    {
        //        clsViewRegionEN objViewRegion = clsViewRegionBLEx.GetObjByRegionIdCache(objFeatureRegionFldsEN.RegionId, strCmPrjId);
        //        return objViewRegion;
        //    }
        //    catch (Exception objException)
        //    {
        //        string strMsg = string.Format("(errid:BlEx000002)根据列表字段获取区域象出错,{1}.({0})",
        //        clsStackTrace.GetCurrClassFunction(),
        //        objException.Message);
        //        throw new Exception(strMsg);
        //    }
        //}
     
        /// <summary>
        /// 字段生成的属性名，根据bolIsFstLcase的值决定首字母是否小写
        /// </summary>
        /// <param name="objFeatureRegionFldsEN"></param>
        /// <returns></returns>
        public static string PropertyName(this clsFeatureRegionFldsENEx objFeatureRegionFldsEN, bool bolIsFstLcase)
        {
            if (bolIsFstLcase == false)
            {
                return objFeatureRegionFldsEN.ObjFieldTabENEx.FldName;
            }
            else
            {
                return clsString.FstLcaseS(objFeatureRegionFldsEN.ObjFieldTabENEx.FldName);
            }
        }
        /// <summary>
        /// 检查表功能
        /// </summary>
        /// <param name="objFeatureRegionFldsEN"></param>
        /// <param name="strUpdUser"></param>
        /// <returns></returns>
        public static bool CheckTabFeature(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strUpdUser)
        {
            clsPrjFeatureEN objPrjFeature = clsPrjFeatureBL.GetObjByFeatureIdCache(objFeatureRegionFldsEN.FeatureId);
            if (objPrjFeature == null) return true;
            if (objPrjFeature.IsNeedTabFeature == false)
            {
                objFeatureRegionFldsEN.CheckTabFeature = "不相关";
                objFeatureRegionFldsEN.Update();
                return true;
            }

            objFeatureRegionFldsEN.TabFeatureId = clsFeatureRegionFldsBLEx.GetRelaTabFeatureId(objFeatureRegionFldsEN.ViewFeatureId);
            if (string.IsNullOrEmpty(objFeatureRegionFldsEN.TabFeatureId) == true)
            {
                objFeatureRegionFldsEN.CheckTabFeature = "错:相关表功能不存在!";
                objFeatureRegionFldsEN.Update();
                return false;
            }
            objFeatureRegionFldsEN.CheckTabFeature = "";
            objFeatureRegionFldsEN.Update();
            //bool bolResult = clsTabFeatureFldsBLEx.CopyToTabFeature(objFeatureRegionFldsEN.ViewFeatureId);
            if (objPrjFeature.IsNeedField == false) return true;

            List<clsvTabFeatureFldsENEx> arrvTabFeatureFlds = clsvTabFeatureFldsBLEx.GetObjExLstByTabFeatureId(objFeatureRegionFldsEN.TabFeatureId);
            IEnumerable<clsViewFeatureFldsEN> arrViewFeatureFlds = arrvTabFeatureFlds
                .Where(x=>x.FldId != objFeatureRegionFldsEN.ReleFldId)
                .Select(clsViewFeatureFldsBLEx.GetObjByvTabFeatureFlds);
            foreach (clsViewFeatureFldsEN objInFor2 in arrViewFeatureFlds)
            {
                objInFor2.SetViewFeatureId(objFeatureRegionFldsEN.ViewFeatureId)
                    .SetUpdUser(strUpdUser);
                if (objInFor2.CheckUniqueness() == true)
                {
                    objInFor2.AddNewRecord();
                }
                else
                {
                    //string strCondition = objInFor2.GetUniConditionStr_ViewFeatureId_FldId();
                    //clsViewFeatureFldsEN objViewFeatureFldsEN = clsViewFeatureFldsBL.GetFirstObj_S(strCondition);
                    //objInFor2.mId = objViewFeatureFldsEN.mId;
                    //objInFor2.UpdateWithCondition(strCondition);
                }
            }
            return true;
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objFeatureRegionFldsENS">源对象</param>
        /// <returns>目标对象=>clsFeatureRegionFldsEN:objFeatureRegionFldsENT</returns>
        public static clsFeatureRegionFldsENEx CopyToEx(this clsFeatureRegionFldsEN objFeatureRegionFldsENS)
        {
            try
            {
                clsFeatureRegionFldsENEx objFeatureRegionFldsENT = new clsFeatureRegionFldsENEx();
                clsFeatureRegionFldsBL.CopyTo(objFeatureRegionFldsENS, objFeatureRegionFldsENT);
                return objFeatureRegionFldsENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000001)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
        /// </summary>
        /// <param name = "objFeatureRegionFldsENS">源对象</param>
        /// <returns>目标对象=>clsFeatureRegionFldsEN:objFeatureRegionFldsENT</returns>
        public static clsFeatureRegionFldsEN CopyTo(this clsFeatureRegionFldsENEx objFeatureRegionFldsENS)
        {
            try
            {
                clsFeatureRegionFldsEN objFeatureRegionFldsENT = new clsFeatureRegionFldsEN();
                clsFeatureRegionFldsBL.CopyTo(objFeatureRegionFldsENS, objFeatureRegionFldsENT);
                return objFeatureRegionFldsENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
    }
    public class ControlIdComparer : IEqualityComparer<ASPControlEx>
    {
        public bool Equals(ASPControlEx t1, ASPControlEx t2)
        {
            return (t1.CtrlId == t2.CtrlId);
        }
        public int GetHashCode(ASPControlEx t)
        {
            return t.ToString().GetHashCode();
        }
    }
    public partial class clsFeatureRegionFldsBLEx : clsFeatureRegionFldsBL
    {
        public static string strPrjIdCache_Init = "";
        /// <summary>
        /// 初始化列表缓存.
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_InitListCache)
        /// </summary>
        //public static void InitListCache(string strPrjId)
        //{
        //    //检查缓存刷新机制
        //    string strMsg = "";
        //    if (clsFeatureRegionFldsBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsFeatureRegionFldsBL没有刷新缓存机制(clsFeatureRegionFldsBL.objCommFun4BL == null), 请联系程序员！({1}->{0})",
        //            clsStackTrace.GetCurrClassFunction(), clsStackTrace.GetCurrClassFunctionByLevel(2));
        //        throw new Exception(strMsg);
        //    }
        //    if (strPrjIdCache_Init != strPrjId) arrFeatureRegionFldsObjLstCache = null;
        //    //初始化列表缓存
        //    //string strWhereCond = string.Format("1 = 1 order by mId");
        //    if (arrFeatureRegionFldsObjLstCache == null)
        //    {
        //        //string strWhereCond = string.Format("{0} = '{1}' order by SeqNum",
        //        //     conPrjTab.PrjId, strPrjId);

        //        string strWhereCond = string.Format("{0} in (select {0} From {1} where {2} = '{3}') order by {4}",
        //          conFeatureRegionFlds.RegionId, clsvViewRegionEN._CurrTabName,
        //          clsvViewRegionEN.con_PrjId, strPrjId,
        //          conFeatureRegionFlds.SeqNum);

        //        arrFeatureRegionFldsObjLstCache = new clsFeatureRegionFldsDA().GetObjLst(strWhereCond);
        //        strMsg = string.Format("初始化成功！strPrjId={0}，strPrjIdCache_Init={1}.({4}->{3}->{2})",
        //          strPrjId, strPrjIdCache_Init,
        //          clsStackTrace.GetCurrClassFunction(),
        //          clsStackTrace.GetCurrClassFunctionByLevel(2),
        //          clsStackTrace.GetCurrClassFunctionByLevel(3));
        //        clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
        //        strPrjIdCache_Init = strPrjId;
        //    }
        //}

        public static void TestFunctionalProgram()
        {
            List<clsUserStateEN> arrObjLst = clsUserStateBL.GetObjLst("1=1");
            IEnumerable<clsUserStateEN> arrObjLst2 = arrObjLst.Where(x => x.UserStateId.CompareTo("66") >= 0);

        }

        //public static Func<clsFeatureRegionFldsENEx, ASPControlGroupEx> GetButtonGroup4PureHtml = obj => GetButtonGroup(obj, true);
        
        //public static Func<clsFeatureRegionFldsENEx, ASPControlGroupEx> GetButtonGroup4NotPureHtml = obj => GetButtonGroup(obj, false);
        public static ASPControlGroupEx GetButtonGroup(clsFeatureRegionFldsENEx objFeatureRegionFldsENEx, int intApplicationTypeId, bool bolIsHasExportRegion)
        {
     
            ASPControlGroupEx objASPControlGroupENEx = new ASPControlGroupEx();
            List<clsButtonTabEN> arrButtonTab = clsFeatureButtonRelaBLEx.GetButtonTabLstByFeatureIdCache(objFeatureRegionFldsENEx.FeatureId, intApplicationTypeId);
            foreach (var objButtonTab in arrButtonTab)
            {
                if (objFeatureRegionFldsENEx.FeatureId == enumPrjFeature.ExportToFile_0143)
                {
                    if (bolIsHasExportRegion == false) continue;
                }
                ASPButtonEx objASPButtonENEx = new ASPButtonEx();
                //objASPButtonENEx.Is4PureHtml = bolIs4PureHtml;
                objASPButtonENEx.CtrlId = objFeatureRegionFldsENEx.ButtonName;
                if (string.IsNullOrEmpty( objButtonTab.CommandName) == false)
                {
                    objASPButtonENEx.CommandName = objButtonTab.CommandName;
                }
                else
                {
                    objASPButtonENEx.CommandName = objFeatureRegionFldsENEx.CommandName;
                }
                objASPButtonENEx.OnClick = string.Format("{0}_Click", objFeatureRegionFldsENEx.ButtonName);
               if (objFeatureRegionFldsENEx.FeatureId == enumPrjFeature.ExportToFile_0143)
                {
                    if (bolIsHasExportRegion == false) objASPButtonENEx.OnClick = "";
                }
                //if (string.IsNullOrEmpty(objFeatureRegionFldsENEx.EventFuncName))
                //{
                //    objASPButtonENEx.OnClick4Html = string.Format("{0}_Click()", objFeatureRegionFldsENEx.ButtonName);
                //}
                //else
                //{
                //    objASPButtonENEx.OnClick4Html = objFeatureRegionFldsENEx.EventFuncName.Replace("''", "'");
                //}
                objASPButtonENEx.Text = objFeatureRegionFldsENEx.Text;// "添加记录";

                objASPButtonENEx.Value = objFeatureRegionFldsENEx.Text;// "添加记录";
                objASPButtonENEx.type = "submit";
                List<string> arrName = new List<string>() { "导出Excel", "查询" };
                if (arrName.Contains(objASPButtonENEx.Text))
                {
                    objASPButtonENEx.Class = "btn btn-outline-warning text-nowrap";
                    objASPButtonENEx.CssClass = "btn btn-outline-warning text-nowrap";

                }
                else
                {
                    objASPButtonENEx.Class = "btn btn-outline-info text-nowrap";
                    objASPButtonENEx.CssClass = "btn btn-outline-info text-nowrap";
                }
                //< input value = "查询" id = "btnQuery" Name = "action:QueryAjax" type = "submit" class="btn btn-outline-warning" onclick="OnClickInFeatureRegion()" />

                objASPButtonENEx.Name4MvcAjax = string.Format("action:{0}Ajax", objFeatureRegionFldsENEx.ButtonName.Substring(3));
                objASPButtonENEx.OnClick4MvcAjax = string.Format("OnClickInFeatureRegion()");

                //objASPButtonENEx.Style = "z-index: 107;";

                //objASPButtonENEx.Width = objFeatureRegionFldsENEx.Width;
                //objASPButtonENEx.Height = 0;
                objASPControlGroupENEx.arrSubAspControlLst2.Add(objASPButtonENEx);
            }
            return objASPControlGroupENEx;
        }

        //public static VueControlGroupEx GetButtonGroup_Vue(clsFeatureRegionFldsENEx objFeatureRegionFldsENEx, bool bolIs4PureHtml = false)
        //{

        //    VueControlGroupEx objASPControlGroupENEx = new VueControlGroupEx();

        //    VueButtonEx objASPButtonENEx = new VueButtonEx();
        //    objASPButtonENEx.Is4PureHtml = bolIs4PureHtml;
        //    objASPButtonENEx.CtrlId = objFeatureRegionFldsENEx.ButtonName;
        //    objASPButtonENEx.OnClick = string.Format("{0}_Click", objFeatureRegionFldsENEx.ButtonName);
        //    if (string.IsNullOrEmpty(objFeatureRegionFldsENEx.EventFuncName))
        //    {
        //        objASPButtonENEx.OnClick4Html = string.Format("{0}_Click()", objFeatureRegionFldsENEx.ButtonName);
        //    }
        //    else
        //    {
        //        objASPButtonENEx.OnClick4Html = objFeatureRegionFldsENEx.EventFuncName.Replace("''", "'");
        //    }
        //    objASPButtonENEx.Text = objFeatureRegionFldsENEx.Text;// "添加记录";
        //    objASPButtonENEx.Value = objFeatureRegionFldsENEx.Text;// "添加记录";
        //    objASPButtonENEx.type = "submit";
        //    List<string> arrName = new List<string>() { "导出Excel", "查询" };
        //    if (arrName.Contains(objASPButtonENEx.Text))
        //    {
        //        objASPButtonENEx.Class = "btn btn-outline-warning text-nowrap";
        //        objASPButtonENEx.CssClass = "btn btn-outline-warning text-nowrap";

        //    }
        //    else
        //    {
        //        objASPButtonENEx.Class = "btn btn-outline-info text-nowrap";
        //        objASPButtonENEx.CssClass = "btn btn-outline-info text-nowrap";
        //    }
        //    //< input value = "查询" id = "btnQuery" Name = "action:QueryAjax" type = "submit" class="btn btn-outline-warning" onclick="OnClickInFeatureRegion()" />

        //    objASPButtonENEx.Name4MvcAjax = string.Format("action:{0}Ajax", objFeatureRegionFldsENEx.ButtonName.Substring(3));
        //    objASPButtonENEx.OnClick4MvcAjax = string.Format("OnClickInFeatureRegion()");

        //    //objASPButtonENEx.Style = "z-index: 107;";

        //    //objASPButtonENEx.Width = objFeatureRegionFldsENEx.Width;
        //    //objASPButtonENEx.Height = 0;
        //    objASPControlGroupENEx.arrSubAspControlLst2.Add(objASPButtonENEx);

        //    return objASPControlGroupENEx;
        //}

        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.        
        /// </summary>
        /// <param name = "arrRegionId">所给的关键字</param>
        /// <param name = "strPrjId">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static List<clsFeatureRegionFldsEN> GetObjLstByRegionIdsCacheEx1(List<string> arrRegionId, string strPrjId)
        {
            //初始化列表缓存
            List<clsFeatureRegionFldsEN> arrObjLstCache = clsFeatureRegionFldsBL.GetObjLstCache(strPrjId);

            IEnumerable<clsFeatureRegionFldsEN> arrFeatureRegionFldsObjLst_Sel1 =
            from objFeatureRegionFldsEN in arrObjLstCache
            where arrRegionId.Contains( objFeatureRegionFldsEN.RegionId) && objFeatureRegionFldsEN.InUse == true
            orderby objFeatureRegionFldsEN.SeqNum
            select objFeatureRegionFldsEN;
            List<clsFeatureRegionFldsEN> arrFeatureRegionFldsObjLst_Sel = new List<clsFeatureRegionFldsEN>();
            foreach (clsFeatureRegionFldsEN obj in arrFeatureRegionFldsObjLst_Sel1)
            {
                arrFeatureRegionFldsObjLst_Sel.Add(obj);
            }
          
            return arrFeatureRegionFldsObjLst_Sel;
        }


        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.        
        /// </summary>
        /// <param name = "lngRegionId">关键字:RegionId</param>
        /// <param name = "strPrjId">工程Id</param>
        /// <returns>根据关键字获取的对象</returns>
        public static List<clsFeatureRegionFldsEN> GetObjLstByRegionIdCacheEx1(string lngRegionId, string strPrjId)
        {
            //初始化列表缓存
            List<clsFeatureRegionFldsEN> arrObjLstCache = clsFeatureRegionFldsBL.GetObjLstCache(strPrjId);

            var arrFeatureRegionFldsObjLst_Sel1 = arrObjLstCache.Where(x=>x.RegionId == lngRegionId && x.InUse == true)
                .OrderBy(x=>x.SeqNum);
            List<clsFeatureRegionFldsEN> arrFeatureRegionFldsObjLst_Sel = new List<clsFeatureRegionFldsEN>();
            foreach (clsFeatureRegionFldsEN obj in arrFeatureRegionFldsObjLst_Sel1)
            {
                arrFeatureRegionFldsObjLst_Sel.Add(obj);
            }
          
            return arrFeatureRegionFldsObjLst_Sel;
        }

        /// <summary>
        /// 根据ViewId获取功能区域字段列表
        /// </summary>
        /// <param name="strViewId">界面Id</param>
        /// <returns></returns>
        public static List<clsFeatureRegionFldsEN> GetObjLstByViewIdEx(string strViewId)
        {
            //初始化列表缓存
            string strCondition = string.Format("{0} in (Select {0} From {1} where {2}='{3}')", 
                conFeatureRegionFlds.RegionId,
                clsViewRegionRelaEN._CurrTabName, conViewRegionRela.ViewId, strViewId);

         
            List<clsFeatureRegionFldsEN> arrFeatureRegionFldsObjLst_Sel = clsFeatureRegionFldsBL.GetObjLst(strCondition);
            return arrFeatureRegionFldsObjLst_Sel;
        }

        public static List<clsFeatureRegionFldsEN> GetObjLstByRegionId(string lngRegionId)
        {
            //初始化列表缓存
            string strCondition = string.Format("{0}={1}",
                conFeatureRegionFlds.RegionId, lngRegionId);

            List<clsFeatureRegionFldsEN> arrFeatureRegionFldsObjLst_Sel = clsFeatureRegionFldsBL.GetObjLst(strCondition);
            return arrFeatureRegionFldsObjLst_Sel;
        }

        /// <summary>
        /// 为界面功能获取相关的表功能
        /// </summary>
        /// <param name="strViewFeatureId">界面功能Id</param>
        /// <returns>表功能TabFeatureId</returns>
        public static string GetRelaTabFeatureId(string strViewFeatureId)
        {
            clsvFeatureRegionFldsEN obj = clsvFeatureRegionFldsBL.GetObjByViewFeatureId(strViewFeatureId);
            if (obj == null) return "";
            if (string.IsNullOrEmpty(obj.FeatureName) == true) return "";
            string strCondition = string.Format("{0}='{1}' And {2}='{3}'", 
                conPrjFeature.FeatureName, obj.FeatureName,
                conPrjFeature.FeatureTypeId, enumPrjFeatureType.TabFeature_03);
            clsPrjFeatureEN objPrjFeature = clsPrjFeatureBL.GetFirstObj_S(strCondition);
            if (objPrjFeature == null) return "";
            strCondition = string.Format("{0}='{1}' And {2}='{3}'",
                conTabFeature.FeatureId, objPrjFeature.FeatureId,
                conTabFeature.TabId, obj.ReleTabId);
            clsTabFeatureEN objTabFeature = clsTabFeatureBL.GetFirstObj_S(strCondition);
            if (objTabFeature == null) return "";
            return objTabFeature.TabFeatureId;
        }
        /// <summary>
        /// 为界面功能获取相关的表功能
        /// </summary>
        /// <param name="strFeatureId">功能Id</param>
        /// <param name="strTabId">表Id</param>
        /// <returns>相关父表功能Id(TabFeatureId)</returns>
        public static string GetRelaTabFeatureIdByFeatureId(string strFeatureId, string strTabId)
        {
            clsPrjFeatureEN objPrjFeature_Sub = clsPrjFeatureBL.GetObjByFeatureIdCache(strFeatureId);
            if (objPrjFeature_Sub == null) return "";        

            string strCondition = string.Format("{0}='{1}' And {2}='{3}'",
                conPrjFeature.FeatureName, objPrjFeature_Sub.FeatureName,
                conPrjFeature.FeatureTypeId, enumPrjFeatureType.TabFeature_03);
            clsPrjFeatureEN objPrjFeature = clsPrjFeatureBL.GetFirstObj_S(strCondition);
            if (objPrjFeature == null) return "";
            strCondition = string.Format("{0}='{1}' And {2}='{3}'",
                conTabFeature.FeatureId, objPrjFeature.FeatureId,
                conTabFeature.TabId, strTabId);
            clsTabFeatureEN objTabFeature = clsTabFeatureBL.GetFirstObj_S(strCondition);
            if (objTabFeature == null) return "";
            return objTabFeature.TabFeatureId;
        }
        public static bool AdjustSequenceNumber(string strDirect, string strViewFeatureId)
        {
            //操作步骤:
            //1、获取当前所选中的关键字Mid。
            //2、根据关键字Mid来获取字的序号
            //3、如果当前序号是否是末端序号,
            //		3.1 如果是末端序号,就退出,
            //		3.2 如果不是,即如果是向下移动,就判断当前序号是否“小于”当前表中的字段数,
            //		    即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
            //		    如果是向上移动,就判断当前序号是否“大于”1,
            //		    即不是最开始一个记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
            //4、获取下(上)一个序号字段的关键字Mid
            //5、把当前关键字Mid的序号加(减)1
            //6、把下一个序号的关键字Mid减(加)1
            //7、重新显示DATAGRID
            //
            int intSeqNum;	//当前记录的序号
            int intPrevSeqNum, intNextSeqNum;	//上下两条记录的序号
            //			string strMid;
            string lngPrevMid = "";	//上一条序号的关键字ViewFeatureId
            string lngNextMid = "";	//下一条序号的关键字ViewFeatureId
            int intTabRecNum;		//当前表中字段的记录数
            string strCurrRegionId;
            //ArrayList arrID;
            StringBuilder strCondition = new StringBuilder();
            //1、获取当前所选中的字段ID。

            clsFeatureRegionFldsEN objFeatureRegionFldsEN = clsFeatureRegionFldsBL.GetObjByViewFeatureId(strViewFeatureId);

            intSeqNum = objFeatureRegionFldsEN.SeqNum ?? 0;
            intPrevSeqNum = intSeqNum - 1;
            intNextSeqNum = intSeqNum + 1;
            //3、如果当前序号是否是末端序号,
            //		3.1 如果是末端序号,就退出,
            strCurrRegionId = objFeatureRegionFldsEN.RegionId;		//获取当前记录的{表ID}
            intTabRecNum = clsGeneralTab2.funGetRecCountByCond("FeatureRegionFlds", "RegionId = '" + strCurrRegionId + "'");	//获取当前{表ID}的记录数
            if (strDirect  ==  "UP")
            {
                if (intSeqNum <=  1)
                {
                    throw new clsDbObjException("已经是第一条记录,不能再上移!");
                }
            }
            else if (strDirect  ==  "DOWN")
            {
                if (intSeqNum >=  intTabRecNum)	//如果当前序号大于表记录数
                {
                    throw new clsDbObjException("已经是最后一条记录,不能再下移!");
                }
            }
            //		3.2 如果不是,即如果是向下移动,就判断当前序号是否“小于”当前表中的字段数,
            //		    即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
            //		    如果是向上移动,就判断当前序号是否“大于”1,
            //		    即不是最开始一个记录,就准备把当前字段项的序号减1,而上一字段的序号加1。

            //4、获取下(上)一个序号字段的关键字Mid
            if (strDirect  ==  "UP")
            {
                strCondition.AppendFormat("RegionId = '{0}' and SeqNum = {1}",
                    strCurrRegionId, intSeqNum - 1);
                try
                {
                    lngPrevMid = clsFeatureRegionFldsBL.GetFirstID_S(strCondition.ToString());
                }
                catch(Exception objException)
                {
                    throw new clsDbObjException("获取上一条记录的关键字出错!错误:" + objException.Message);

                }
            }
            else if (strDirect  ==  "DOWN")
            {
                strCondition.AppendFormat("RegionId = '{0}' and SeqNum = {1}",
                    strCurrRegionId, intSeqNum + 1);
                try
                {
                    lngNextMid = clsFeatureRegionFldsBL.GetFirstID_S(strCondition.ToString());
                }
                catch (Exception objException)
                {
                    throw new clsDbObjException("获取下一条记录的关键字出错! 错误:" + objException.Message);
                }

            }
            else if (strDirect  ==  "FIRST")
            {
            }
            else if (strDirect  ==  "LAST")
            {
            }
            else
            {
                throw new clsDbObjException("方向参数出错!");
            }
            //5、把当前关键字Mid的序号加(减)1
            //6、把下一个序号的关键字Mid减(加)1
            if (strDirect  ==  "UP")
            {
                clsFeatureRegionFldsBL.SetFldValue("FeatureRegionFlds", "SeqNum", intSeqNum - 1, "ViewFeatureId = " + strViewFeatureId);
                clsFeatureRegionFldsBL.SetFldValue("FeatureRegionFlds", "SeqNum", intPrevSeqNum + 1, "ViewFeatureId = " + lngPrevMid);
            }
            else if (strDirect  ==  "DOWN")
            {
                clsFeatureRegionFldsBL.SetFldValue("FeatureRegionFlds", "SeqNum", intSeqNum + 1, "ViewFeatureId = " + strViewFeatureId);
                clsFeatureRegionFldsBL.SetFldValue("FeatureRegionFlds", "SeqNum", intNextSeqNum - 1, "ViewFeatureId = " + lngNextMid);
            }
            else if (strDirect  ==  "FIRST")
            {
                clsFeatureRegionFldsBL.SetFldValue("FeatureRegionFlds", "SeqNum", 0, "ViewFeatureId = " + strViewFeatureId);
                ReOrder(strCurrRegionId);
            }
            else if (strDirect  ==  "LAST")
            {
                clsFeatureRegionFldsBL.SetFldValue("FeatureRegionFlds", "SeqNum", intTabRecNum + 1, "ViewFeatureId = " + strViewFeatureId);
                ReOrder(strCurrRegionId);
            }
            clsFeatureRegionFldsBL.ReFreshCache(objFeatureRegionFldsEN.PrjId);
            //7、重新显示DATAGRID
            return true;
        }

     
        public static void ReOrderBak(string lngRegionId)
        {
            List<clsFeatureRegionFldsEN> arrFeatureRegionFldsObjList = clsFeatureRegionFldsBL.GetObjLst("RegionId = '" + lngRegionId + "' order by SeqNum ");
            int intIndex = 1;
            foreach (clsFeatureRegionFldsEN objFeatureRegionFldsEN in arrFeatureRegionFldsObjList)
            {
                objFeatureRegionFldsEN.SeqNum = intIndex;
                clsFeatureRegionFldsBL.UpdateBySql2(objFeatureRegionFldsEN);
                intIndex++;
            }
        }
        public static List<clsFeatureRegionFldsENEx> GetObjExLst1(List<string> arrRegionId, string strCmPrjId)
        {
            //"RegionId = " + lngRegionId + " order by SeqNum"
            List<clsFeatureRegionFldsENEx> arrObjENExList = new List<clsFeatureRegionFldsENEx>();
            List<clsFeatureRegionFldsEN> arrObjList = GetObjLstByRegionIdsCacheEx1(arrRegionId, strCmPrjId);
            foreach (clsFeatureRegionFldsEN objFeatureRegionFldsEN in arrObjList)
            {
                clsFeatureRegionFldsENEx objFeatureRegionFldsENEx = new clsFeatureRegionFldsENEx();
                CopyTo(objFeatureRegionFldsEN, objFeatureRegionFldsENEx);
                arrObjENExList.Add(objFeatureRegionFldsENEx);
            }
            return arrObjENExList;
        }
        public static List<clsFeatureRegionFldsENEx> GetObjExLstByRegionId(string lngRegionId)
        {
            //"RegionId = " + lngRegionId + " order by SeqNum"
            List<clsFeatureRegionFldsENEx> arrObjENExList = new List<clsFeatureRegionFldsENEx>();
            List<clsFeatureRegionFldsEN> arrObjList = GetObjLstByRegionId(lngRegionId);
            foreach (clsFeatureRegionFldsEN objFeatureRegionFldsEN in arrObjList)
            {
                clsFeatureRegionFldsENEx objFeatureRegionFldsENEx = new clsFeatureRegionFldsENEx();
                CopyTo(objFeatureRegionFldsEN, objFeatureRegionFldsENEx);
                arrObjENExList.Add(objFeatureRegionFldsENEx);
            }
            return arrObjENExList;
        }
        public static List<clsFeatureRegionFldsENEx> GetObjExLstByRegionIdEx(string lngRegionId, string strPrjId)
        {
            //"RegionId = " + lngRegionId + " order by SeqNum"
            List<clsFeatureRegionFldsENEx> arrObjENExList = new List<clsFeatureRegionFldsENEx>();
            List<clsFeatureRegionFldsEN> arrObjList = GetObjLstByRegionId(lngRegionId);
            foreach (clsFeatureRegionFldsEN objFeatureRegionFldsEN in arrObjList)
            {
                clsFeatureRegionFldsENEx objFeatureRegionFldsENEx = new clsFeatureRegionFldsENEx();
                CopyTo(objFeatureRegionFldsEN, objFeatureRegionFldsENEx);
                if (string.IsNullOrEmpty(objFeatureRegionFldsENEx.ReleFldId) == false)
                {
                    objFeatureRegionFldsENEx.ObjFieldTabENEx = clsFieldTabBLEx.GetObjExByFldIDCache(objFeatureRegionFldsENEx.ReleFldId, strPrjId);
                }
                objFeatureRegionFldsENEx.objCtlType = clsCtlTypeBL.GetObjByCtlTypeIdCache(objFeatureRegionFldsENEx.CtlTypeId);
                arrObjENExList.Add(objFeatureRegionFldsENEx);
            }
            return arrObjENExList;
        }
        public static List<clsFeatureRegionFldsENEx> GetFeatureRegionFldsENExObjListBak(string strCondition)
        {

            List<clsFeatureRegionFldsENEx> arrObjENExList = new List<clsFeatureRegionFldsENEx>();
            List<clsFeatureRegionFldsEN> arrObjList = GetObjLst(strCondition);
            foreach (clsFeatureRegionFldsEN objFeatureRegionFldsEN in arrObjList)
            {
                clsFeatureRegionFldsENEx objFeatureRegionFldsENEx = new clsFeatureRegionFldsENEx();
                CopyTo(objFeatureRegionFldsEN, objFeatureRegionFldsENEx);
                arrObjENExList.Add(objFeatureRegionFldsENEx);
            }
            return arrObjENExList;
        }
       
        /// <summary>
        /// 功能:设置字段可用，同时设置多条记录。
        /// </summary>
        /// <param name = "arrmIdLst">给定的关键字值列表</param>
        /// <param name = "strUpdUser">给定的关键字值列表</param>
        /// <returns>返回设置可用的记录数</returns>
        public static int SetInUse(List<string> arrmIdLst, string strUpdUser)
        {
            try
            {
                int intRecNum = 0;
                foreach (string strViewFeatureId in arrmIdLst)
                {
                    clsFeatureRegionFldsEN objFeatureRegionFldsEN = clsFeatureRegionFldsBL.GetObjByViewFeatureId(strViewFeatureId);
                    objFeatureRegionFldsEN.InUse = true;
                    objFeatureRegionFldsEN.UpdUser = strUpdUser;
                    objFeatureRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                    clsFeatureRegionFldsBL.UpdateBySql2(objFeatureRegionFldsEN);
                    intRecNum++;
                }
                return intRecNum;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("设置字段可用出错,{1}.({0})",
                 clsStackTrace.GetCurrClassFunction(),
                 objException.Message);
                throw new Exception(strMsg);
            }
        }
        /// <summary>
        /// 功能:设置字段不可用，同时设置多条记录。
        /// </summary>
        /// <param name = "arrmIdLst">给定的关键字值列表</param>
        /// <param name = "strUpdUser">给定的关键字值列表</param>
        /// <returns>返回设置不可用的记录数</returns>
        public static int SetNotInUse(List<string> arrmIdLst, string strUpdUser)
        {
            try
            {
                int intRecNum = 0;
                foreach (string strViewFeatureId in arrmIdLst)
                {
                    clsFeatureRegionFldsEN objFeatureRegionFldsEN = clsFeatureRegionFldsBL.GetObjByViewFeatureId(strViewFeatureId);
                    objFeatureRegionFldsEN.InUse = false;
                    objFeatureRegionFldsEN.UpdUser = strUpdUser;
                    objFeatureRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                    clsFeatureRegionFldsBL.UpdateBySql2(objFeatureRegionFldsEN);
                    intRecNum++;
                }
                return intRecNum;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("设置字段不可用出错,{1}.({0})",
                 clsStackTrace.GetCurrClassFunction(),
                 objException.Message);
                throw new Exception(strMsg);
            }
        }
        public static bool AddFeatureRegionFldsRecordSave(string lngRegionId, int intApplicationTypeId, string strTabId, clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strUpdUser)
        {
            
            //操作步骤:
            //1、检查控件中输入数据类型是否正确
            //2、定义对象并初始化对象
            //3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            //3.2、检查唯一性
            //4、把值从界面层传到逻辑层或数据实体层
            //5、检查传进去的对象属性是否合法
            //6、把数据实体层的数据存贮到数据库中
            //7、把新添的记录内容显示在GridView中
            string strMsg;  //专门用于传递信息的变量

            //clsFeatureRegionFldsEN objFeatureRegionFldsEN;
            ////2、定义对象并初始化对象
            ////clsFeatureRegionFldsEN objFeatureRegionFldsEN;	//定义对象
            //objFeatureRegionFldsEN = new clsFeatureRegionFldsEN();  //初始化新对象
            //clsViewFeatureFldsEN objViewFeatureFlds_OrderNum = null;
            clsViewFeatureFldsEN objViewFeatureFlds_ClassificationField = null;
            clsViewFeatureFldsEN objViewFeatureFlds_SetFldValue = null;
            //clsViewInfoEN objViewInfoEN = clsViewInfoBLEx.GetObjByRegionId(lngRegionId);            
            //if (objViewInfoEN == null)
            //{
            //    strMsg = string.Format("根据区域Id:{0}获取缓存对象为空，请检查！(In {1})", lngRegionId, clsStackTrace.GetCurrClassFunction());
            //    throw new Exception(strMsg);
            //}
            var objFeatureRegionFldsENEx = CopyToEx(objFeatureRegionFldsEN);
            string strFldName = "";
            string strPrjId = "";
            //string strFeatureId = objFeatureIdGroup.Item1;
            clsPrjFeatureEN objPrjFeature = clsPrjFeatureBL.GetObjByFeatureId(objFeatureRegionFldsEN.FeatureId);
            List<clsFeatureButtonRelaEN> arrFeatureButtonRela = clsFeatureButtonRelaBLEx.GetObjLstByFeatureIdCache(objPrjFeature.FeatureId, intApplicationTypeId);
            if (arrFeatureButtonRela.Count == 0)
            {
                strMsg = string.Format("在应用:[{0}]中，功能:[{1}]没有相应的按钮。(In {2})",
                    clsApplicationTypeBL.GetNameByApplicationTypeIdCache(intApplicationTypeId),
                    clsPrjFeatureBL.GetNameByFeatureIdCache(objPrjFeature.FeatureId),
                    clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            string strCtrlId = "";
            var objFeatureButtonRela = arrFeatureButtonRela[0];
            switch (objPrjFeature.FeatureId)
            {
                case enumPrjFeature.GoTop_0159:// "移顶":
                case enumPrjFeature.UpMove_0160:// "上移":
                case enumPrjFeature.DownMove_0161:// "下移":
                case enumPrjFeature.GoButton_0162:// "移底":
                case enumPrjFeature.ReOrder_0163:// "重序":
                case enumPrjFeature.AdjustOrderNum_1196:// "重序":
               
                    strPrjId = objFeatureRegionFldsENEx.PrjId();
                    clsPrjTabFldEN objField_OrderNum = clsPrjTabFldBLEx.GetOrderNumObjCache(strTabId, strPrjId);
                    //clsPrjTabFldEN objField_ClassificationField = clsPrjTabFldBLEx.GetClassificationFieldObjCache(objViewInfoEN.MainTabId, objViewInfoEN.PrjId);
                    clsvPrjTabFldEN objvField_ClassificationField = null;
                    if (string.IsNullOrEmpty(strTabId) == false)
                    {
                        objvField_ClassificationField = clsvPrjTabFldBLEx.GetClassificationFieldObjCache(strTabId, strPrjId);
                    }
                    if (objField_OrderNum == null)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objFeatureRegionFldsEN.ReleTabId, strPrjId);
                        strMsg = string.Format("界面主表:[{1}]没有设置[序号字段]，不能添加功能：[{0}]", objPrjFeature.FeatureName, objPrjTab.TabName);
                        throw new Exception(strMsg);
                    }
                    


                    objFeatureRegionFldsEN
                        .SetReleTabId(objField_OrderNum.TabId)
                        .SetReleFldId(objField_OrderNum.FldId)
                        .SetFieldTypeId(enumFieldType.OrderNumField_09)
                        .SetButtonName(objPrjFeature.DefaButtonName)
                        .SetButtonName4Mvc(objPrjFeature.DefaButtonName4Mvc)
                        //.SetEventFuncName(objFeatureButtonRela.EventFuncName)
                        .SetPrjId(objFeatureRegionFldsEN.PrjId)
                        .SetKeyIdGetModeId(enumGCKeyIdGetMode.ListCheckedRecord_0001)
                        .SetText(objPrjFeature.FeatureName);
                                    
                    if (objvField_ClassificationField != null)
                    {
                        clsEditRegionFldsEN objEditRegionFlds = clsEditRegionFldsBLEx.GetObjByvPrjTabFld(objvField_ClassificationField);
                        strCtrlId = clsCtlTypeBLEx.GetCtrlId(objEditRegionFlds.CtlTypeId, objvField_ClassificationField.FldName);
                        objViewFeatureFlds_ClassificationField = clsViewFeatureFldsBLEx.GetObjByvPrjTabFld(objvField_ClassificationField);
                        objViewFeatureFlds_ClassificationField.SetViewFeatureId(objFeatureRegionFldsEN.ViewFeatureId)
                            .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                            .SetUpdUser(strUpdUser)
                            .SetPrjId(objFeatureRegionFldsEN.PrjId)
                            .SetInUse(true)
                            .SetFieldTypeId(enumFieldType.ClassificationField_10)
                            .SetCtrlId(strCtrlId)
                            .SetDsTabId(objEditRegionFlds.DsTabId)
                            .SetTabFeatureId4Ddl(clsTabFeatureBLEx.GetFstFeatureIdByTabId(objEditRegionFlds.DsTabId, objFeatureRegionFldsEN.PrjId))                                                        
                            .SetCtlTypeId(objEditRegionFlds.CtlTypeId);
                    }
                    break;
                case enumPrjFeature.SetFieldValue_0148:// "设置字段值":
                    //K_FldId_FieldTab objKey = new K_FldId_FieldTab(objFeatureRegionFldsEN.ReleFldId);

                    clsFieldTabEN objFieldTabEN = clsFieldTabBL.GetObjByFldIdCache(objFeatureRegionFldsEN.ReleFldId, objFeatureRegionFldsENEx.PrjId());
                    if (objFieldTabEN == null)
                    {
                        strMsg = string.Format("字段Id:{0}获取缓存对象为空，请检查！(In {1})", objFeatureRegionFldsEN.ReleFldId, clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                    }
                    strFldName = objFieldTabEN.FldName;
                    strPrjId = objFieldTabEN.PrjId;
                    objFeatureRegionFldsEN
                        .SetButtonName(string.Format("btnSet{0}", objFieldTabEN.FldName))
                        .SetButtonName4Mvc(string.Format("btnSet{0}", objFieldTabEN.FldName))
                        //.SetEventFuncName(objFeatureButtonRela.EventFuncName)
                        .SetText(string.Format("设置{0}", objFieldTabEN.Caption))
                        .SetPrjId(objFeatureRegionFldsEN.PrjId)
                        .SetFieldTypeId(enumFieldType.SetField_17);

                    if (string.IsNullOrEmpty(strTabId) == true)
                    {
                        throw new Exception("在添加设置字段值功能时，TabId不能为空！");
                    }
                    clsvPrjTabFldEN objField_SetFldValue = clsvPrjTabFldBLEx.GetObjByFldIdCache(strTabId, objFeatureRegionFldsENEx.PrjId(), objFieldTabEN.FldId);
                    objViewFeatureFlds_SetFldValue = clsViewFeatureFldsBLEx.GetObjByvPrjTabFld(objField_SetFldValue);

                    var objCtlType = clsCtlTypeBL.GetObjByCtlTypeIdCache(objViewFeatureFlds_SetFldValue.CtlTypeId);
                    strCtrlId = string.Format("{0}{1}_SetFldValue", objCtlType.CtlTypeAbbr, objField_SetFldValue.FldName);
                                        
                    objViewFeatureFlds_SetFldValue
                        .SetUpdUser(strUpdUser)
                        .SetCtrlId(strCtrlId)
                        .SetPrjId(objFeatureRegionFldsEN.PrjId)
                        .SetFieldTypeId(enumFieldType.SetField_17);
                    break;
                case enumPrjFeature.CopyRecord_0141:
                case enumPrjFeature.CopyRecord_0198:
                                       
                    strPrjId = objFeatureRegionFldsENEx.PrjId();
                    objFeatureRegionFldsEN.ButtonName = objPrjFeature.DefaButtonName;// 功能Id    
                    objFeatureRegionFldsEN.ButtonName4Mvc = objPrjFeature.DefaButtonName4Mvc;// 功能Id    
                    //objFeatureRegionFldsEN.EventFuncName = objFeatureButtonRela.EventFuncName;
                    objFeatureRegionFldsEN.Text = objPrjFeature.FeatureName;// 功能Id     
                    objFeatureRegionFldsEN.KeyIdGetModeId = enumGCKeyIdGetMode.ListCheckedRecord_0001;// 功能Id     

                    break;
                case enumPrjFeature.DefaultFeature_0240://自定义功能
                 
                    strPrjId = objFeatureRegionFldsENEx.PrjId();
                    objFeatureRegionFldsEN.ButtonName = objPrjFeature.DefaButtonName;// 功能Id    
                    objFeatureRegionFldsEN.ButtonName4Mvc = objPrjFeature.DefaButtonName4Mvc;// 功能Id    
                    //objFeatureRegionFldsEN.EventFuncName = objFeatureButtonRela.EventFuncName;
                    objFeatureRegionFldsEN.Text = objPrjFeature.FeatureName;// 功能Id      
                    break;
                default:
                   
                    strPrjId = objFeatureRegionFldsENEx.PrjId();
                    objFeatureRegionFldsEN.ButtonName = objPrjFeature.DefaButtonName;// 功能Id    
                    objFeatureRegionFldsEN.ButtonName4Mvc = objPrjFeature.DefaButtonName4Mvc;// 功能Id    
                    //objFeatureRegionFldsEN.EventFuncName = objFeatureButtonRela.EventFuncName;
                    objFeatureRegionFldsEN.Text = objPrjFeature.FeatureName;// 功能Id      
                    break;
            }
            objFeatureRegionFldsEN.RegionId = lngRegionId;// 函数Id4Code
            //objFeatureRegionFldsEN.FeatureId = strFeatureId;// 功能Id      
            objFeatureRegionFldsEN.FeatureDescription = objPrjFeature.FeatureDescription;// 功能Id      
            objFeatureRegionFldsEN.GroupName =string.Format("{0}_{1}", objPrjFeature.GroupName, strFldName).Replace("SetFieldValue", "SFV");// 功能Id      
            objFeatureRegionFldsEN.TabFeatureId = GetRelaTabFeatureIdByFeatureId(objFeatureRegionFldsEN.FeatureId, objFeatureRegionFldsEN.ReleTabId);
            objFeatureRegionFldsEN.InUse = true;
            string strViewImplId_Defa = clsFeatureImplementationBLEx.GetDefaultImplemanetationByFeatureId(objFeatureRegionFldsEN.FeatureId);
            objFeatureRegionFldsEN.SetViewImplId( strViewImplId_Defa)
                .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                 .SetPrjId(objFeatureRegionFldsEN.PrjId)
                .SetUpdUser( strUpdUser);// 修改者

            //            objFeatureRegionFldsEN.Memo = wucFeatureRegionFldsB1.Memo;// 说明
            //3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            //4、把值从界面层传到逻辑层或数据实体层
            string strCondition = "";
            //5.1、检查传进去的对象属性是否合法
            try
            {
                clsFeatureRegionFldsBL.CheckPropertyNew(objFeatureRegionFldsEN);
                //6、把数据实体层的数据存贮到数据库中
                strCondition = objFeatureRegionFldsEN.GetUniCondStr();
                if (clsFeatureRegionFldsBL.IsExistRecord(strCondition) == true)
                {
                    clsFeatureRegionFldsBL.UpdateBySql2(objFeatureRegionFldsEN);
                }
                else
                {
                    clsFeatureRegionFldsBL.AddNewRecordBySql2(objFeatureRegionFldsEN);
                }
                if (string.IsNullOrEmpty(objFeatureRegionFldsEN.TabFeatureId) == false)
                {
                    if (clsPrjFeatureBLEx.IsNeedFlds(objFeatureRegionFldsEN.FeatureId) == true)
                    {
                        CopyFeatureFldsFromTabFeature(objFeatureRegionFldsEN, objFeatureRegionFldsEN.TabFeatureId, objFeatureRegionFldsEN.PrjId, strUpdUser);
                    }
                }
                else
                {
                    //if (objViewFeatureFlds_OrderNum != null)
                    //{
                    //    if (objViewFeatureFlds_OrderNum.CheckUniqueness_ViewFeatureId_FldId() == true)
                    //    {
                    //        objViewFeatureFlds_OrderNum.AddNewRecord();
                    //    }
                    //    else
                    //    {
                    //        strCondition = objViewFeatureFlds_OrderNum.GetUniConditionStr_ViewFeatureId_FldId();
                    //        objViewFeatureFlds_OrderNum.UpdateWithCondition(strCondition);
                    //    }
                    //}
                    if (objViewFeatureFlds_ClassificationField != null)
                    {
                        if (objViewFeatureFlds_ClassificationField.CheckUniqueness() == true)
                        {
                            objViewFeatureFlds_ClassificationField.AddNewRecord();
                        }
                        else
                        {
                            strCondition = objViewFeatureFlds_ClassificationField.GetUniCondStr();
                            objViewFeatureFlds_ClassificationField.UpdateWithCondition(strCondition);
                        }

                    }
                }
                if (objViewFeatureFlds_SetFldValue != null)
                {
                    objViewFeatureFlds_SetFldValue.SetViewFeatureId(objFeatureRegionFldsEN.ViewFeatureId);
                    if (string.IsNullOrEmpty(objViewFeatureFlds_SetFldValue.CtrlId))
                    {
                        objViewFeatureFlds_SetFldValue.CtrlId = clsViewFeatureFldsBLEx.GetCtrlId(objViewFeatureFlds_SetFldValue);
                    }
                    if (objViewFeatureFlds_SetFldValue.CheckUniqueness() == true)
                    {
             
                        objViewFeatureFlds_SetFldValue.AddNewRecord();
                    }
                    else
                    {
                        strCondition = objViewFeatureFlds_SetFldValue.GetUniCondStr();
                        objViewFeatureFlds_SetFldValue.UpdateWithCondition(strCondition);
                    }

                }
                objFeatureRegionFldsEN.CheckTabFeature(strUpdUser);
            }
            catch (Exception objException)
            {
                strMsg = "(errid:WebI000005)添加记录不成功!" + objException.Message;
                throw new Exception(strMsg);
                //return false;
            }
            strMsg = "添加记录成功!";

            return true;
        }
        /// <summary>
        /// 从表功能复制字段到界面功能
        /// </summary>
        /// <param name="strViewFeatureId">界面功能Id</param>
        /// <param name="strTabFeatureId">表功能Id</param>
        /// <param name="strPrjId">工程Id</param>
        /// <param name="strUpdUser">修改用户</param>
        /// <returns></returns>
        public static bool CopyFeatureFldsFromTabFeature(string strViewFeatureId, string strTabFeatureId, string strPrjId, string strUpdUser)
        {
            clsFeatureRegionFldsEN objFeatureRegionFldsEN = clsFeatureRegionFldsBL.GetObjByViewFeatureId(strViewFeatureId);
            return CopyFeatureFldsFromTabFeature(objFeatureRegionFldsEN, strTabFeatureId, strPrjId, strUpdUser);
        }
        /// <summary>
        /// 从表功能复制字段到界面功能
        /// </summary>
        /// <param name="objFeatureRegionFldsEN">界面功能对象</param>
        /// <param name="strTabFeatureId">表功能Id</param>
        /// <param name="strPrjId">工程Id</param>
        /// <param name="strUpdUser">修改用户</param>
        /// <returns></returns>
        public static bool CopyFeatureFldsFromTabFeature(clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strTabFeatureId, string strPrjId, string strUpdUser)
            {
            string strPrjId_p = strPrjId;// clsCMProjectBLEx.GetPrjIdByCmPrjIdCache(strCmPrjId);
                List<clsvTabFeatureFldsENEx> arrvTabFeatureFlds = clsvTabFeatureFldsBLEx.GetObjExLstByTabFeatureId(strTabFeatureId);
            IEnumerable<clsViewFeatureFldsEN> arrViewFeatureFlds = arrvTabFeatureFlds
                .Where(x => x.FldId != objFeatureRegionFldsEN.ReleFldId)
                .Select(clsViewFeatureFldsBLEx.GetObjByvTabFeatureFlds);
            foreach (clsViewFeatureFldsEN objInFor in arrViewFeatureFlds)
            {
                if (objInFor.FieldTypeId == enumFieldType.OrderNumField_09) continue;

                clsvPrjTabFldEN objvPrjTabFldEN = clsvPrjTabFldBLEx.GetObjByFldIdCache(objFeatureRegionFldsEN.ReleTabId, strPrjId_p, objInFor.ReleFldId);
                clsViewFeatureFldsEN objViewFeatureFldsEN = clsViewFeatureFldsBLEx.GetObjByvPrjTabFld(objvPrjTabFldEN);
                objViewFeatureFldsEN.CtrlId = clsCtlTypeBLEx.GetCtrlId(objViewFeatureFldsEN.CtlTypeId, objvPrjTabFldEN.FldName) + "_OrderNum";
                objViewFeatureFldsEN.SetViewFeatureId(objFeatureRegionFldsEN.ViewFeatureId)
                    .SetFieldTypeId(enumFieldType.ClassificationField_10)
                    .SetPrjId(strPrjId)
                    .SetUpdUser(strUpdUser);
                if (objViewFeatureFldsEN.CheckUniqueness() == true)
                {
                    objViewFeatureFldsEN.AddNewRecord();
                }
                else
                {
//                    clsTabFeatureBLEx.GetFeatureIdLstByTabId()
                    objInFor.SetViewFeatureId(objFeatureRegionFldsEN.ViewFeatureId)
                        .SetCtlTypeId(objViewFeatureFldsEN.CtlTypeId)
                        .SetCtrlId(objViewFeatureFldsEN.CtrlId)
                        .SetFieldTypeId(enumFieldType.ClassificationField_10)
                        .SetDsCondStr(objViewFeatureFldsEN.DsCondStr)
                        //.SetDs_DataTextFieldId(objViewFeatureFldsEN.Ds_DataTextFieldId)
                        //.SetDsDataValueFieldId(objViewFeatureFldsEN.DsDataValueFieldId)
                        .SetDsSqlStr(objViewFeatureFldsEN.DsSqlStr)
                        .SetDsTabId(objViewFeatureFldsEN.DsTabId)
                        .SetTabFeatureId4Ddl(clsTabFeatureBLEx.GetFstFeatureIdByTabId(objViewFeatureFldsEN.DsTabId, strPrjId))
                        .SetDdlItemsOptionId(objViewFeatureFldsEN.DdlItemsOptionId)
                        .SetItemsString(objViewFeatureFldsEN.ItemsString);
                    string strCondition = objInFor.GetUniCondStr();
                    clsViewFeatureFldsEN objViewFeatureFldsEN2 = clsViewFeatureFldsBL.GetFirstObj_S(strCondition);
                    objInFor.mId = objViewFeatureFldsEN2.mId;
                    objInFor.UpdateWithCondition(strCondition);
                }
            }
            return true;
        }
        public static List<ASPControlEx> GetControlLst4Regoin(string lngRegionId, string strPrjId, string strItemName4MultiModel = "", bool bolIs4Visible = false)
        {
            clsvViewRegionEN objViewRegion = clsvViewRegionBL.GetObjByRegionId(lngRegionId);
            //clsViewInfoENEx objViewInfoENEx = clsViewInfoBLEx.GetObjExByViewId(objViewRegion.ViewId, objViewRegion.PrjId);

            int intApplicationTypeId = objViewRegion.ApplicationTypeId ?? 0;
            List<clsFeatureRegionFldsENEx> arrFeatureRegionFlds = clsFeatureRegionFldsBLEx.GetObjExLstByRegionId(lngRegionId);
            arrFeatureRegionFlds = arrFeatureRegionFlds.Where(x => x.InUse == true).ToList();

            //var arrFeatureId = arrFeatureRegionFlds.Select(x => x.FeatureId);
            //var arrFeatureButtonRela = clsFeatureButtonRelaBL.GetObjLstCache();

            //var arrFeatureButtonRela_Sel = arrFeatureButtonRela.Where(x => arrFeatureId.Contains(x.FeatureId) && x.ApplicationTypeId == intApplicationTypeId);
            List<clsButtonTabENEx> arrButtonTabSet = clsButtonTabBLEx.GetObjExLstByFeatureRegionFldsLst(arrFeatureRegionFlds, intApplicationTypeId, strPrjId);


            if (bolIs4Visible== true)
            {
                arrFeatureRegionFlds.ForEach(x=> x.Is4Visible = true );
            }
            List<string> ViewFeatureId_DefaultValue = arrFeatureRegionFlds
                .Where(x=>x.ValueGivingModeId == enumValueGivingMode.DefaultValue_01)
                .Select(x=>x.ViewFeatureId).ToList();
            IEnumerable<ASPButtonEx> arrButtonLst = null;
            switch (objViewRegion.ApplicationTypeId)
            {
                case (int)enumApplicationType.Neo4JApp_24:
                    arrButtonLst = arrButtonTabSet.Select(obj => clsASPButtonBLEx.GetButton(obj));
                    break;
                case (int)enumApplicationType.WebApp_JS_RJ_28:
                    arrButtonLst = arrButtonTabSet.Select(obj => clsASPButtonBLEx.GetButton(obj));
                    break;

                case (int)enumApplicationType.WebApp_2:
                    arrButtonLst = arrButtonTabSet.Select(obj => clsASPButtonBLEx.GetButton(obj));
                    break;
                case (int)enumApplicationType.WinApp_1:
                    arrButtonLst = arrButtonTabSet.Select(obj => clsASPButtonBLEx.GetButton(obj));
                    break;
                case (int)enumApplicationType.SpaAppInCore_TS_18:
                case (int)enumApplicationType.SpaInCoreUT_27:
                case (int)enumApplicationType.VueAppInCore_TS_30:

                    arrButtonLst = arrButtonTabSet.Select(obj => clsASPButtonBLEx.GetButton(obj));
                    break;
                case (int)enumApplicationType.AspMvcAjaxApp_20:
                    arrButtonLst = arrButtonTabSet.Select(obj => clsASPButtonBLEx.GetButton(obj) );
                    break;
                default:
                    string strMsg = string.Format("应用类型:[{0}]未被处理。(In {1})", 
                        clsApplicationTypeBL.GetNameByApplicationTypeIdCache(objViewRegion.ApplicationTypeId ?? 0),
                        clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                    //break;
            }

            //List<clsViewFeatureFldsENEx> arrViewFeatureFlds = clsViewFeatureFldsBLEx.GetObjExLstByRegionId(lngRegionId, strPrjId);
            List<clsViewFeatureFldsENEx> arrvViewFeatureFlds = clsViewFeatureFldsBLEx.GetObjExLstByRegionId(lngRegionId, strPrjId);
            var arrExclude = new List<string>() { enumCtlType.GivenValue_35 , enumCtlType.ViewVariable_38 };
            arrvViewFeatureFlds = arrvViewFeatureFlds
                .Where(x => arrExclude.Contains(x.CtlTypeId) == false)
                .Where(x=>ViewFeatureId_DefaultValue.Contains(x.ViewFeatureId) == false)
                .ToList();
            IEnumerable<ASPControlEx> arrControls = arrvViewFeatureFlds.Select(obj => clsASPControlBLEx.GetControl_Asp(obj, strItemName4MultiModel));
            arrControls = arrControls.Distinct(new ControlIdComparer());
            //IEnumerable<ASPControlEx> arrControls_Sub = arrControls.Distinct();
            IEnumerable<ASPControlEx> arrControls_All = arrControls.Union(arrButtonLst);
            return arrControls_All.ToList();


            //List<ASPControlGroupEx> arrControlGroupLst = arrControls_All.OrderBy(x => x.OrderNum).Select(clsASPControlGroupBLEx.GetControlGroup).OrderBy(x => x.GroupName).ToList();
            //int iLen = arrControlGroupLst.Count;
            ////在设置字段值的按钮前按需要添加一个输入控件，用于输入一个值
            ////for (int i = 0; i < iLen; i++)
            ////{
            ////    ASPControlGroupEx objInFor = arrControlGroupLst[i];
            ////    ASPControlEx objASPButtonENEx = objInFor.arrSubAspControlLst2[0] as ASPControlEx;
            ////    if (objASPButtonENEx.FeatureId == enumPrjFeature.SetFieldValue_0148
            ////      && objASPButtonENEx.ValueGivingModeId == enumValueGivingMode.GivenValue_02)
            ////    {
            ////        List<clsvViewFeatureFldsENEx> arrViewFeatureFlds_Sub = arrvViewFeatureFlds.Where(x =>
            ////        x.ViewFeatureId == objASPButtonENEx.ViewFeatureId).ToList();
            ////        if (arrViewFeatureFlds_Sub.Count > 0)
            ////        {
            ////            clsvViewFeatureFldsENEx objViewFeatureFlds = arrViewFeatureFlds_Sub[0];
            ////            clsASPDropDownListENEx objASPDropDownListENEx = clsASPDropDownListBLEx.GetDropDownLst_Asp(objViewFeatureFlds);
            ////            objInFor.arrSubAspControlLst2.Insert(0, objASPDropDownListENEx);
            ////        }
            ////    }
            ////}
            //for (int i = 0; i < iLen; i++)
            //{
            //    ASPControlGroupEx objInFor = arrControlGroupLst[i];
            //    if (objInFor._StrTag == "Delete") continue;
            //    if (string.IsNullOrEmpty(objInFor.GroupName) == false)
            //    {
            //        for (int j = i + 1; j < iLen; j++)
            //        {
            //            ASPControlGroupEx objInFor_J = arrControlGroupLst[j];
            //            if (objInFor_J.GroupName == objInFor.GroupName)
            //            {
            //                foreach (ASPControlEx objInFor_Sub in objInFor_J.arrSubAspControlLst2)
            //                {
            //                    objInFor.arrSubAspControlLst2.Add(objInFor_Sub);
            //                }
            //                objInFor_J._StrTag = "Delete";
            //            }
            //        }
            //    }
            //}
            //IEnumerable<ASPControlGroupEx> arrControlGroupLst_New = arrControlGroupLst.Where(x => x._StrTag != "Delete");

            //clsASPUlENEx objASPUlENEx = clsASPUlBLEx.GetEmptyUl();
            //objASPUlENEx.Class = "nav";
            ////objASPDivENEx_Function.arrSubAspControlLst2.Add(objASPUlENEx);

            //clsASPLiENEx objASPLiENEx = clsASPLiBLEx.GetEmptyLi();
            //objASPLiENEx.Class = "nav-item";
            //objASPLiENEx.Style = "width:250px;";

            //objASPUlENEx.arrSubAspControlLst2.Add(objASPLiENEx);
            ////列表标题
            //clsASPSpanENEx objASPSpanENEx = clsASPSpanBLEx.GetDataListTitle("aa", "表名");
            //objASPLiENEx.arrSubAspControlLst2.Add(objASPSpanENEx);

            ////Action<ASPButtonEx> AddToTd = (x) =>
            ////{
            ////    objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
            ////    ASPButtonEx objASPNETButtonENEx = clsASPButtonBLEx.GetbtnAddNewRec4Gv();
            ////    objASPNETColENEx.arrSubAspControlLst2.Add(x);
            ////    objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);
            ////};
            ////< li class="nav-item">

            ////Action<ASPButtonEx> AddToLi = (x) =>
            ////{
            ////    objASPLiENEx = clsASPLiBLEx.GetEmptyLi();
            ////    objASPLiENEx.Class = "nav-item ml-3";
            ////    ASPButtonEx objASPNETButtonENEx = clsASPButtonBLEx.GetbtnAddNewRec4Gv();
            ////    objASPLiENEx.arrSubAspControlLst2.Add(x);
            ////    objASPUlENEx.arrSubAspControlLst2.Add(objASPLiENEx);
            ////};

            //foreach (ASPControlGroupEx objInFor in arrControlGroupLst_New.OrderBy(x => x.OrderNum))
            //{
            //    objASPLiENEx = clsASPLiBLEx.GetEmptyLi();
            //    objASPLiENEx.Class = "nav-item ml-3";
            //    //ASPButtonEx objASPNETButtonENEx = clsASPButtonBLEx.GetbtnAddNewRec4Gv();
            //    objASPLiENEx.arrSubAspControlLst2.Add(objInFor);
            //    objASPUlENEx.arrSubAspControlLst2.Add(objASPLiENEx);
            //}

            //objASPLiENEx = clsASPLiBLEx.GetEmptyLi();
            //objASPLiENEx.Class = "nav-item ml-3";

            //objASPUlENEx.arrSubAspControlLst2.Add(objASPLiENEx);
            ////列表标题
            //clsASPSpanENEx objASPSpanENEx_Msg = clsASPSpanBLEx.GetDataListMsg();
            //objASPLiENEx.arrSubAspControlLst2.Add(objASPSpanENEx_Msg);


            ////objASPUlENEx.GeneCode(strCodeForCs);

            //HtmlControl objUl = objASPUlENEx.GeneHtmlControl();// new HtmlGenericControl("");


            ////            IEnumerable<HtmlControl> arrHtmlControl = arrControlGroupLst_New.Select(            clsASPControlGroupBLEx.GeneHtmlControl);

            //pnlControlLst.Controls.Add(objUl);

        }

        public static List<ASPControlEx> GetControlLst4Regoin(string lngRegionId, string strViewImplId, clsViewInfoENEx objViewInfoENEx, 
            string strItemName4MultiModel = "")
        {
          
            List<clsFeatureRegionFldsENEx> arrFeatureRegionFlds = objViewInfoENEx.arrFeatureRegionFlds
                .Where(x=>x.RegionId == lngRegionId && x.ViewImplId == strViewImplId).ToList();// clsFeatureRegionFldsBLEx.GetObjExLstByRegionId(lngRegionId);

            if (objViewInfoENEx.objViewRegion_Edit == null)
            {
                arrFeatureRegionFlds = arrFeatureRegionFlds.Where(x => x.FeatureId != enumPrjFeature.AddNewRecordWithMaxId_0183
                && x.FeatureId != enumPrjFeature.AddNewRecord_0136
                && x.FeatureId != enumPrjFeature.AddNewRecord_0197
                && x.FeatureId != enumPrjFeature.UpdateRecord_0137
                && x.FeatureId != enumPrjFeature.UpdateRecord_0199).ToList();
            }
            List<clsButtonTabENEx> arrButtonTabSet = clsButtonTabBLEx.GetObjExLstByFeatureRegionFldsLst(arrFeatureRegionFlds, 
                objViewInfoENEx.ApplicationTypeId, objViewInfoENEx.PrjId);

            List<ASPButtonEx> arrButtonLst = arrButtonTabSet.Select(obj => clsASPButtonBLEx.GetButton(obj)).ToList();
         
            List<clsViewFeatureFldsENEx> arrvViewFeatureFlds = objViewInfoENEx.arrViewFeatureFlds
                .Where(x => x.RegionId == lngRegionId &&
                ((x.FeatureId != enumPrjFeature.SetFieldValue_0148) 
                || (x.FeatureId == enumPrjFeature.SetFieldValue_0148 
                && x.ValueGivingModeId != enumValueGivingMode.DefaultValue_01))).ToList();//.GetObjExLstByRegionId(lngRegionId, strPrjId);
            var arrExclude = new List<string>() { enumCtlType.ViewVariable_38, enumCtlType.GivenValue_35 };
            arrvViewFeatureFlds = arrvViewFeatureFlds.Where(x=> arrExclude.Contains(x.CtlTypeId) == false  && x.CtlTypeId != enumCtlType.None_00).ToList();

            Func<clsViewFeatureFldsENEx, ASPControlEx> GetControl_Asp4MultiModel = obj => clsASPControlBLEx.GetControl_Asp(obj, strItemName4MultiModel);

            List<ASPControlEx> arrControls = arrvViewFeatureFlds.Select(GetControl_Asp4MultiModel).ToList();
            arrControls = arrControls.Distinct(new ControlIdComparer()).ToList();
            //IEnumerable<ASPControlEx> arrControls_Sub = arrControls.Distinct();
            List<ASPControlEx> arrControls_All = arrControls.Union(arrButtonLst).ToList();
            return arrControls_All;


        }

        //public static IEnumerable<ASPControlEx> GetControlLst4Regoin_Vue(string lngRegionId, clsViewInfoENEx objViewInfoENEx,
        //  string strItemName4MultiModel = "", bool bolIs4PureHtml = false)
        //{

        //    IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFlds = objViewInfoENEx.arrFeatureRegionFlds
        //        .Where(x => x.RegionId == lngRegionId);// clsFeatureRegionFldsBLEx.GetObjExLstByRegionId(lngRegionId);
        //    IEnumerable<VueButtonEx> arrButtonLst = null;
        //    switch (objViewInfoENEx.ApplicationTypeId)
        //    {
        //        case (int)enumApplicationType.Neo4JApp_24:
        //            arrButtonLst = arrFeatureRegionFlds.Select(obj => clsVueButtonBLEx.GetButton(obj, false, false));
        //            break;
        //        case (int)enumApplicationType.WebApp_2:
        //            arrButtonLst = arrFeatureRegionFlds.Select(obj => clsVueButtonBLEx.GetButton(obj, false, false));
        //            break;
        //        case (int)enumApplicationType.WinApp_1:
        //            arrButtonLst = arrFeatureRegionFlds.Select(obj => clsVueButtonBLEx.GetButton(obj, false, false));
        //            break;
        //        case (int)enumApplicationType.AspMvcAjaxApp_20:
        //            arrButtonLst = arrFeatureRegionFlds.Select(obj => clsVueButtonBLEx.GetButton(obj, true, true));
        //            break;
        //        case (int)enumApplicationType.SpaAppInCore_TS_18:
        //        case (int)enumApplicationType.SpaInCoreUT_27:
        //        case (int)enumApplicationType.VueAppInCore_TS_30:

        //            arrButtonLst = arrFeatureRegionFlds.Select(obj => clsVueButtonBLEx.GetButton(obj, false, false, true));
        //            break;
        //        case (int)enumApplicationType.WebApp_JS_RJ_28:
        //            arrButtonLst = arrFeatureRegionFlds.Select(obj => clsVueButtonBLEx.GetButton(obj, false, false, true));
        //            break;
        //        default:
        //            string strMsg = string.Format("应用类型:[{0}]未被处理。(In {1})",
        //                clsApplicationTypeBL.GetNameByApplicationTypeIdCache(objViewInfoENEx.ApplicationTypeId),
        //                clsStackTrace.GetCurrClassFunction());
        //            throw new Exception(strMsg);
        //    }

        //    IEnumerable<clsvViewFeatureFldsENEx> arrvViewFeatureFlds = objViewInfoENEx.arrViewFeatureFlds
        //        .Where(x => x.RegionId == lngRegionId &&
        //        ((x.FeatureId != enumPrjFeature.SetFieldValue_0148) || (x.FeatureId == enumPrjFeature.SetFieldValue_0148 && x.ValueGivingModeId != enumValueGivingMode.DefaultValue_01)));//.GetObjExLstByRegionId(lngRegionId, strPrjId);
        //    var arrExclude = new List<string>() { enumCtlType.ViewVariable_38, enumCtlType.GivenValue_35 };
        //    arrvViewFeatureFlds = arrvViewFeatureFlds.Where(x => arrExclude.Contains(x.CtlTypeId) == false);

        //    Func<clsvViewFeatureFldsENEx, ASPControlEx> GetControl_Asp4MultiModel = obj => clsASPControlBLEx.GetControl_Asp(obj, strItemName4MultiModel, bolIs4PureHtml);

        //    IEnumerable<ASPControlEx> arrControls = arrvViewFeatureFlds.Select(GetControl_Asp4MultiModel);
        //    arrControls = arrControls.Distinct(new ControlIdComparer());
        //    //IEnumerable<ASPControlEx> arrControls_Sub = arrControls.Distinct();
        //    IEnumerable<ASPControlEx> arrControls_All = arrControls.Union(arrButtonLst);
        //    return arrControls_All;


        //}


        public static clsTabFeatureEN CopyToTabFeature(string strViewFeatureId, string strPrjId, string strUpdUser)
        {

            clsFeatureRegionFldsEN objFeatureRegionFlds = clsFeatureRegionFldsBL.GetObjByViewFeatureId(strViewFeatureId);
            //复制表功能
            clsTabFeatureEN objTabFeature = clsTabFeatureBLEx.GetObjByFeatureRegionFldsObj(objFeatureRegionFlds, strPrjId);
            objTabFeature.SetTabFeatureId(clsTabFeatureBL.GetMaxStrIdByPrefix_S(strPrjId))
                .SetUpdUser(strUpdUser);
            if (objTabFeature.CheckUniqueness() == true)
            {
                objTabFeature.AddNewRecordEx(strPrjId, strUpdUser);
            }
            else
            {
                string strCondition = objTabFeature.GetUniCondStr();
                objTabFeature = clsTabFeatureBL.GetFirstObj_S(strCondition);
            }
            if (clsPrjFeatureBLEx.IsNeedFlds(objFeatureRegionFlds.FeatureId) == true)
            {
                //复制在表功能对象中字段信息到TabFeatureFlds
                clsTabFeatureFldsEN objTabFeatureFldsEN_1 = clsTabFeatureFldsBLEx.GetObjByFeatureRegionFlds(objFeatureRegionFlds);
                objTabFeatureFldsEN_1.SetTabFeatureId(objTabFeature.TabFeatureId)
                  .SetUpdUser(strUpdUser);

                //复制表功能字段

                List<clsViewFeatureFldsENEx> arrViewFeatureFlds = clsViewFeatureFldsBLEx.GetObjExLstByViewFeatureId(strViewFeatureId, strPrjId);

                List<clsTabFeatureFldsEN> arrTabFeatureFlds = arrViewFeatureFlds.Select(clsTabFeatureFldsBLEx.GetObjByViewFeatureFlds).ToList();
                arrTabFeatureFlds.Insert(0, objTabFeatureFldsEN_1);

                foreach (clsTabFeatureFldsEN objInFor2 in arrTabFeatureFlds)
                {
                    objInFor2.SetTabFeatureId(objTabFeature.TabFeatureId)
                        .SetUpdUser(strUpdUser);
                    if (objInFor2.CheckUniqueness() == true)
                    {
                        objInFor2.AddNewRecord();
                    }
                    else
                    {
                        string strCondition = objInFor2.GetUniCondStr();
                        clsTabFeatureFldsEN objTabFeatureFldsEN = clsTabFeatureFldsBL.GetFirstObj_S(strCondition);
                        objInFor2.mId = objTabFeatureFldsEN.mId;
                        objInFor2.UpdateWithCondition(strCondition);
                    }
                }
            }
            return  objTabFeature ;
        }
        /// <summary>
        /// 同步满足条件的DG信息到Server
        /// </summary>
        /// <param name="strCondition"></param>
        /// <param name="strUserId"></param>
        /// <returns></returns>
        //public static int SynchToServerByCondition(string strCondition, string strUserId)
        //{
        //    //string strCondition = string.Format("id_CurrEduClass='{0}'", strId_TransferCourses);
        //    if (string.IsNullOrEmpty(strUserId) == true)
        //    {
        //        throw new Exception("上传到WEB库时，同步人不能为空！");
        //    }
        //    int intCount = 0;
        //    clsSysParaEN.strConnectStrName = "ConnectionString";
        //    string strCurrDate14 = clsDateTime_Db.GetDataBaseDateTime14();

        //    clsSysParaEN.strConnectStrName = "ConnectionStringWeb";

        //    List<clsFeatureRegionFldsEN> arrFeatureRegionFldsENObjLst = clsFeatureRegionFldsBL.GetObjLst(strCondition);

        //    foreach (clsFeatureRegionFldsEN objFeatureRegionFldsEN4Web in arrFeatureRegionFldsENObjLst)
        //    {

        //        objFeatureRegionFldsEN4Web.IsSynchToServer = true;
        //        objFeatureRegionFldsEN4Web.SynchToServerDate = strCurrDate14;
        //        objFeatureRegionFldsEN4Web.SynchToServerUser = strUserId;
        //        clsSysParaEN.strConnectStrName = "ConnectionString";

        //        try
        //        {
        //            clsFeatureRegionFldsEN objFeatureRegionFldsEN4Web2 = new clsFeatureRegionFldsEN();
        //            clsFeatureRegionFldsBL.CopyTo(objFeatureRegionFldsEN4Web, objFeatureRegionFldsEN4Web2);
        //            objFeatureRegionFldsEN4Web2.SynSource = "Client";
        //            clsFeatureRegionFldsEN objFeatureRegionFlds_Target = clsFeatureRegionFldsBL.GetObjByViewFeatureId(objFeatureRegionFldsEN4Web.ViewFeatureId);

        //            if (objFeatureRegionFlds_Target != null)
        //            {
        //                //如果目标地的对象日期小于来源对象的日期就更新
        //                int intResult = objFeatureRegionFlds_Target.UpdDate.CompareTo(objFeatureRegionFldsEN4Web.UpdDate);
        //                if (intResult < 0)
        //                {

        //                    clsFeatureRegionFldsBL.UpdateBySql2(objFeatureRegionFldsEN4Web2);
        //                    intCount++;
        //                }
        //            }
        //            else
        //            {
        //                clsFeatureRegionFldsBL.AddNewRecordBySql2(objFeatureRegionFldsEN4Web2);
        //                intCount++;
        //            }

        //            clsSysParaEN.strConnectStrName = "ConnectionStringWeb";
        //            clsFeatureRegionFldsBL.UpdateBySql2(objFeatureRegionFldsEN4Web);
        //        }
        //        catch (Exception objException)
        //        {
        //            StringBuilder sbMsg = new StringBuilder();
        //            sbMsg.AppendFormat("在同步到Main库，工程表：{0}({1})时出错。({3}).[上级抛错:{2}]", objFeatureRegionFldsEN4Web.RegionId,
        //                        objFeatureRegionFldsEN4Web.RegionId, objException.Message, clsStackTrace.GetCurrClassFunction());
        //            throw new Exception(sbMsg.ToString());
        //        }
        //    }
        //    clsSysParaEN.strConnectStrName = "ConnectionString";
        //    return intCount;
        //}


        /// <summary>
        /// 同步满足条件的信息到Client
        /// </summary>
        /// <param name="strCondition"></param>
        /// <param name="strUserId"></param>
        /// <returns></returns>
        //public static int SynchToClientByCondition(string strCondition, string strUserId)
        //{
        //    if (string.IsNullOrEmpty(strUserId) == true)
        //    {
        //        throw new Exception("上传到WEB库时，同步人不能为空！");
        //    }
        //    int intCount = 0;
        //    clsSysParaEN.strConnectStrName = "ConnectionString";
        //    string strCurrDate14 = clsDateTime_Db.GetDataBaseDateTime14();

        //    clsSysParaEN.strConnectStrName = "ConnectionString";

        //    List<clsFeatureRegionFldsEN> arrFeatureRegionFldsENObjLst = clsFeatureRegionFldsBL.GetObjLst(strCondition);

        //    foreach (clsFeatureRegionFldsEN objFeatureRegionFldsEN4Main in arrFeatureRegionFldsENObjLst)
        //    {

        //        objFeatureRegionFldsEN4Main.IsSynchToClient = true;
        //        objFeatureRegionFldsEN4Main.SynchToClientDate = strCurrDate14;
        //        objFeatureRegionFldsEN4Main.SynchToClientUser = strUserId;
        //        clsSysParaEN.strConnectStrName = "ConnectionStringWeb";
        //        try
        //        {
        //            clsFeatureRegionFldsEN objFeatureRegionFldsEN4Main2 = new clsFeatureRegionFldsEN();
        //            clsFeatureRegionFldsBL.CopyTo(objFeatureRegionFldsEN4Main, objFeatureRegionFldsEN4Main2);
        //            objFeatureRegionFldsEN4Main2.SynSource = "Server";
        //            clsFeatureRegionFldsEN objFeatureRegionFlds_Target = clsFeatureRegionFldsBL.GetObjByViewFeatureId(objFeatureRegionFldsEN4Main.ViewFeatureId);

        //            if (objFeatureRegionFlds_Target != null)
        //            {
        //                //如果目标地的对象日期小于来源对象的日期就更新
        //                int intResult = objFeatureRegionFlds_Target.UpdDate.CompareTo(objFeatureRegionFldsEN4Main.UpdDate);
        //                if (intResult < 0)
        //                {

        //                    clsFeatureRegionFldsBL.UpdateBySql2(objFeatureRegionFldsEN4Main2);
        //                    intCount++;
        //                }
        //            }
        //            else
        //            {
        //                clsFeatureRegionFldsBL.AddNewRecordBySql2(objFeatureRegionFldsEN4Main2);
        //                intCount++;
        //            }

        //            clsSysParaEN.strConnectStrName = "ConnectionString";
        //            clsFeatureRegionFldsBL.UpdateBySql2(objFeatureRegionFldsEN4Main);
        //        }
        //        catch (Exception objException)
        //        {
        //            StringBuilder sbMsg = new StringBuilder();
        //            sbMsg.AppendFormat("在同步到Web库，工程表：{0}({1})时出错。({3}).[上级抛错:{2}]", objFeatureRegionFldsEN4Main.RegionId,
        //                        objFeatureRegionFldsEN4Main.RegionId, objException.Message, clsStackTrace.GetCurrClassFunction());
        //            throw new Exception(sbMsg.ToString());
        //        }
        //    }
        //    clsSysParaEN.strConnectStrName = "ConnectionString";
        //    return intCount;
        //}
        public static bool ImportRelaFlds(string strRegionId, string strPrjId, string strUserId)
        {
            //string strPrjId_p = clsCMProjectBLEx.GetPrjIdByCmPrjIdCache(strCmPrjId);
            int intRecNum = 0;
            //1、获取当前区域ID的相关主表ID；
            //string lngRegionId = 0;
            //List<clsViewRegionEN> arrViewRegion = clsViewRegionBLEx.GetObjLstByViewIdCache(strViewId, strPrjId);
            //if (arrViewRegion.Count == 0)
            //{
            //    string strMsg = string.Format("界面:{0}的相关区域数为0，请检查！", clsViewInfoBL.GetNameByViewIdCache(strViewId, strPrjId));
            //    throw new Exception(strMsg);
            //}
            //获取当前区域所在界面的界面类型码对象,以便决定Func区域的相关属性
            //clsViewRegionEN objViewRegionEN = new clsViewRegionEN(lngRegionId);
            //clsViewRegionBL.GetViewRegion(ref objViewRegionEN);
            //string strViewId = objViewRegionEN.ViewId;
            string strCondition = string.Format("ViewName = '{0}'", "wfmTemplate1_QUDI");
            clsViewInfoEN objViewInfoEN_Template = clsViewInfoBL.GetFirstObj_S(strCondition);

            List<clsViewRegionEN> arrViewRegion_Template = clsViewRegionBLEx.GetObjLstByViewIdCache(objViewInfoEN_Template.ViewId, objViewInfoEN_Template.PrjId);

            //strCondition = string.Format("ViewId = '{0}' And RegionTypeId = '{1}'", objViewInfoEN_Template.ViewId, clsRegionTypeENEx.FEATUREREGION);
            clsViewRegionEN objViewRegionEN_Tempplate = arrViewRegion_Template.Find(x => x.RegionTypeId == enumRegionType.FeatureRegion_0008);


            clsViewRegionEN objViewRegionEN = clsViewRegionBL.GetObjByRegionId(strRegionId);


            //2、获取相关主表ID的字段的对象列表;
            //objFeatureRegionEN_Tempplate.RegionId:11732
            strCondition = string.Format("RegionId = '{0}' order by SeqNum", objViewRegionEN_Tempplate.RegionId);
            List<clsFeatureRegionFldsEN> arrFeatureRegionFldsObjList_Template = clsFeatureRegionFldsBL.GetObjLst(strCondition);
            foreach (clsFeatureRegionFldsEN objFeatureRegionFldsEN in arrFeatureRegionFldsObjList_Template)
            {
                string strFeatureId = objFeatureRegionFldsEN.FeatureId;
                string strButtonName = objFeatureRegionFldsEN.ButtonName;
                if (strFeatureId == enumPrjFeature.AddNewRecord_0136 || strFeatureId == enumPrjFeature.AddNewRecord_0197)
                {
                    clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objViewRegionEN.TabId, strPrjId);
                    if (objPrjTab.PrimaryTypeId() == enumPrimaryType.StringAutoAddPrimaryKey_03)
                    {
                        strFeatureId = enumPrjFeature.AddNewRecordWithMaxId_0183;
                        strButtonName = "";
                    }
                }
                clsPrjFeatureEN objPrjFeature = clsPrjFeatureBL.GetObjByFeatureIdCache(strFeatureId);
                strButtonName = objPrjFeature.DefaButtonName;

                List<clsFeatureButtonRelaEN> arrFeatureButtonRela = clsFeatureButtonRelaBLEx.GetObjLstByFeatureIdCache(objPrjFeature.FeatureId, objViewInfoEN_Template.ApplicationTypeId);
                if (arrFeatureButtonRela.Count == 0)
                {
                    var strMsg = string.Format("在应用:[{0}]中，功能:[{1}]没有相应的按钮。(In {2})",
                        clsApplicationTypeBL.GetNameByApplicationTypeIdCache(objViewInfoEN_Template.ApplicationTypeId),
                        clsPrjFeatureBL.GetNameByFeatureIdCache(objPrjFeature.FeatureId),
                        clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                var objFeatureButtonRela = arrFeatureButtonRela[0];

                objFeatureRegionFldsEN.FeatureId = strFeatureId;
                //if (objPrjFeature.InOutTypeId == enumInOutType.IN_02)
                //{
                //    objFeatureRegionFldsEN.ReleTabId = objViewInfoEN.MainTabId;
                //}
                //else
                //{
                //    objFeatureRegionFldsEN.ReleTabId = objViewInfoEN.OutRelaTabId;
                //}
                objFeatureRegionFldsEN.ReleTabId = objViewRegionEN.TabId;

                objFeatureRegionFldsEN.FeatureDescription = objFeatureRegionFldsEN.FeatureDescription;
                objFeatureRegionFldsEN.ViewImplId = objFeatureRegionFldsEN.ViewImplId;
                objFeatureRegionFldsEN.ButtonName = strButtonName;
                objFeatureRegionFldsEN.ButtonName4Mvc = objFeatureRegionFldsEN.ButtonName4Mvc;
                //objFeatureRegionFldsEN.EventFuncName = objFeatureButtonRela.EventFuncName;

                objFeatureRegionFldsEN.Text = objPrjFeature.FeatureName;
                objFeatureRegionFldsEN.InUse = objFeatureRegionFldsEN.InUse;

                objFeatureRegionFldsEN.RegionId = strRegionId;
                objFeatureRegionFldsEN.UpdDate = clsDateTime.getTodayStr(0);
                objFeatureRegionFldsEN.UpdUser = strUserId;
                objFeatureRegionFldsEN.PrjId = strPrjId;

                //5、检查传进去的对象属性是否合法

                clsFeatureRegionFldsBL.CheckPropertyNew(objFeatureRegionFldsEN);

                //6、把数据实体层的数据存贮到数据库中

                intRecNum = clsGeneralTab2.funGetRecCountByCond("FeatureRegionFlds", "RegionId = " + strRegionId);
                if (clsFeatureRegionFldsBL.IsExistRecord("RegionId = " + strRegionId + " and ButtonName = '" + objFeatureRegionFldsEN.ButtonName + "'") == false)
                {
                    objFeatureRegionFldsEN.SeqNum = intRecNum + 1;
                    intRecNum++;
                    if (clsFeatureRegionFldsBL.AddNewRecordBySql2(objFeatureRegionFldsEN) == false)
                    {
                        throw new clsDbObjException("添加功能区域字段不成功!" + objFeatureRegionFldsEN.ButtonName);
                    }
                    else
                    {
                    }
                }

            }
            //设置当前界面的修改日期
            //clsViewInfoBLEx.SetViewUpdDate(strViewId);

            return true;

        }

        public static bool CopyTo1(string lngRegionId_S, string lngRegionId_T, string strCmPrjId, string strUpdUser)
        {


            //List<clsViewRegionEN> arrViewRegionObjLst = clsViewRegionBLEx.GetObjLstByViewIdCache(strViewId, strPrjId);
            //List<string> arrRegionId = arrViewRegionObjLst.Select(x => x.RegionId).ToList();


            List<clsFeatureRegionFldsEN> arrFeatureRegionFldsObjLst = clsFeatureRegionFldsBLEx.GetObjLstByRegionIdCacheEx1(lngRegionId_S, strCmPrjId);
            foreach (clsFeatureRegionFldsEN objInfor2 in arrFeatureRegionFldsObjLst)
            {
                clsPrjFeatureEN objPrjFeature = clsPrjFeatureBL.GetObjByFeatureIdCache(objInfor2.FeatureId);
                if (objPrjFeature.RegionTypeId != enumRegionType.FeatureRegion_0008) continue;
                clsFeatureRegionFldsEN objInfor2_T = new clsFeatureRegionFldsEN();
                clsFeatureRegionFldsBL.CopyTo(objInfor2, objInfor2_T);
                objInfor2_T.ViewFeatureId = clsFeatureRegionFldsBL.GetMaxStrId_S();
                objInfor2_T.RegionId = lngRegionId_T;
                objInfor2_T.SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                    .SetUpdUser(strUpdUser);
                objInfor2_T.EditRecordEx();
                List<clsViewFeatureFldsEN> arrViewFeatureFlds = clsViewFeatureFldsBLEx.GetObjLstByViewFeatureId(objInfor2.ViewFeatureId);
                foreach (clsViewFeatureFldsEN objInFor3 in arrViewFeatureFlds)
                {
                    clsViewFeatureFldsEN objInfor3_T = new clsViewFeatureFldsEN();
                    clsViewFeatureFldsBL.CopyTo(objInFor3, objInfor3_T);
                    objInfor3_T.ViewFeatureId = objInfor2_T.ViewFeatureId;

                    objInfor3_T.SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                        .SetPrjId(objInFor3.PrjId)
                        .SetUpdUser(strUpdUser);
                    objInfor3_T.EditRecordEx();
                }
            }
            return true;
        }

        public static bool CopyTo(string strViewId, string lngRegionId_S, string lngRegionId_T, string strCmPrjId, string strPrjId, string strUpdUser)
        {


            List<clsViewRegionEN> arrViewRegionObjLst = clsViewRegionBLEx.GetObjLstByViewIdCache(strViewId, strCmPrjId);
            List<string> arrRegionId = arrViewRegionObjLst.Select(x => x.RegionId).ToList();


            List<clsFeatureRegionFldsEN> arrFeatureRegionFldsObjLst = clsFeatureRegionFldsBLEx.GetObjLstByRegionIdsCacheEx1(arrRegionId, strCmPrjId);
            foreach (clsFeatureRegionFldsEN objInfor2 in arrFeatureRegionFldsObjLst)
            {
                clsPrjFeatureEN objPrjFeature = clsPrjFeatureBL.GetObjByFeatureIdCache(objInfor2.FeatureId);
                if (objPrjFeature.RegionTypeId != enumRegionType.FeatureRegion_0008) continue;
                clsFeatureRegionFldsEN objInfor2_T = new clsFeatureRegionFldsEN();
                clsFeatureRegionFldsBL.CopyTo(objInfor2, objInfor2_T);
                objInfor2_T.ViewFeatureId = clsFeatureRegionFldsBL.GetMaxStrId_S();
                objInfor2_T.RegionId = lngRegionId_T;
                objInfor2_T.SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                    .SetUpdUser(strUpdUser);
                objInfor2_T.EditRecordEx();
                List<clsViewFeatureFldsEN> arrViewFeatureFlds = clsViewFeatureFldsBLEx.GetObjLstByViewFeatureId(objInfor2.ViewFeatureId);
                foreach (clsViewFeatureFldsEN objInFor3 in arrViewFeatureFlds)
                {
                    clsViewFeatureFldsEN objInfor3_T = new clsViewFeatureFldsEN();
                    clsViewFeatureFldsBL.CopyTo(objInFor3, objInfor3_T);
                    objInfor3_T.ViewFeatureId = objInfor2_T.ViewFeatureId;

                    objInfor3_T.SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                        .SetPrjId(objInFor3.PrjId)
                        .SetUpdUser(strUpdUser);
                    objInfor3_T.EditRecordEx();
                }
            }
            return true;
        }
        public static List<string> getRelaTabId4Ddl2(string lngRegionId, string strPrjId)
        {
            string strCondition = string.Format("{0}={1}",
                conFeatureRegionFlds.RegionId, lngRegionId);

            List<string> arrTabId = new List<string>();
            IEnumerable<clsViewFeatureFldsEN> arrObjENList = clsViewFeatureFldsBLEx.GetObjLstByRegionIdCache2(lngRegionId, strPrjId);

            foreach (clsViewFeatureFldsEN objFeatureRegionFldsEN in arrObjENList)
            {
                //if (objFeatureRegionFldsENEx.CtlTypeId != enumCtlType.DropDownList_06) continue;
                string strTabId = objFeatureRegionFldsEN.DsTabId;
                if (string.IsNullOrEmpty(strTabId) == true) continue;
                if (arrTabId.Contains(strTabId) == false) arrTabId.Add(strTabId);
            }

            return arrTabId;
        }

        public static int GetRecCount4InUseCache1(string lngRegionId, string strPrjId)
        {
            //初始化列表缓存
            List<clsFeatureRegionFldsEN> arrObjLstCache = clsFeatureRegionFldsBL.GetObjLstCache(strPrjId);

            List<clsFeatureRegionFldsEN> arrFeatureRegionFldsObjLst_Sel =
                    arrObjLstCache.Where(x => x.RegionId == lngRegionId && x.InUse == true)
                    .OrderBy(x => x.SeqNum).ToList();
            return arrFeatureRegionFldsObjLst_Sel.Count;
        }


        public static int GetRecCountCache1(string lngRegionId, string strPrjId)
        {
            //初始化列表缓存
            List<clsFeatureRegionFldsEN> arrObjLstCache = clsFeatureRegionFldsBL.GetObjLstCache(strPrjId);

            List<clsFeatureRegionFldsEN> arrFeatureRegionFldsObjLst_Sel =
                    arrObjLstCache.Where(x => x.RegionId == lngRegionId)
                    .OrderBy(x => x.SeqNum).ToList();
            return arrFeatureRegionFldsObjLst_Sel.Count;
        }
        public static bool SetCmPrjId1(string strRegionId, string strPrjId, string strUserId)
        {
            try
            {
                List<clsFeatureRegionFldsEN> arrFeatureRegionFlds = clsFeatureRegionFldsBLEx.GetObjLstByRegionId(strRegionId);

                foreach (var objInFor in arrFeatureRegionFlds)
                {
                    try
                    {
                        objInFor
                            .SetPrjId(strPrjId)
                            .SetUpdDate(clsDateTime.getTodayDateTimeStr(0))
                            .SetUpdUser(strUserId)
                            .Update();
                        clsViewFeatureFldsBLEx.SetPrjId(objInFor.ViewFeatureId, strPrjId, strUserId);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
                return true;
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }
        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objFeatureRegionFldsENS">源对象</param>
        /// <returns>目标对象=>clsFeatureRegionFldsEN:objFeatureRegionFldsENT</returns>
        public static clsFeatureRegionFldsENEx CopyToEx(clsFeatureRegionFldsEN objFeatureRegionFldsENS)
        {
            try
            {
                clsFeatureRegionFldsENEx objFeatureRegionFldsENT = new clsFeatureRegionFldsENEx();
                clsFeatureRegionFldsBL.FeatureRegionFldsDA.CopyTo(objFeatureRegionFldsENS, objFeatureRegionFldsENT);
                return objFeatureRegionFldsENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000005)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
    }
}
