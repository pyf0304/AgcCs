
using AGC.BusinessLogic;using AGC.FunClass;
using AGC.BusinessLogicEx;
using AGC.Entity;

using com.taishsoft.common;
using com.taishsoft.datetime;
using CommFunc4WebForm;

using System;
using System.Data;
using System.Diagnostics;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;
using AutoGCLib;
using System.Collections.Generic;
using com.taishsoft.file;
using com.taishsoft.comm_db_obj;
using com.taishsoft.util;

namespace AGC
{
 
    public static class clsPubFun
    {
        /// <summary>
        /// 合并两个Sort串
        /// </summary>
        /// <param name="strSort1"></param>
        /// <param name="strSort2"></param>
        /// <returns></returns>
        public static string CombineSortFld(string strSort1, string strSort2)
        {
            List<string> arr = new List<string>() { strSort1, strSort2 };
            return string.Join(",", arr);
        }

        public static string GetName(this clsTabStateEN obj)
        {
            return obj.TabStateName + ",";
        }
        public static void SetCommFun4BL()
        {
            clsPubFun4BLEx.SetCommFun4BL();
        }
        public static clsEntityBase2 GetClassByName(string strClassName)
        {
            string strMyClassName = string.Format("{0},AgcEN", strClassName);
            Type expType = Type.GetType(strMyClassName);
            //string strTypeName = typeof(clsNodeObj).ToString();
            //Type expType2 = Type.GetType(strTypeName);
            //string cnClassName = "EntityLayer";
            //string ltLangType = "CSharp";

            //string strClassName2 = string.Format("AutoGCLib.{0}4{1}", cnClassName, ltLangType);
            //Type expType3 = Type.GetType(strClassName2);
            //clsGeneCodeBase objGeneCodeBase = clsGeneCodeBase.GetClassByName(strClassName2);
            //clsGeneCodeBase objGeneCodeBase2 = clsGeneCodeBase.GetClassByName(strClassName);

            if (expType == null)
            {
                string strMsg = string.Format("类型:{0}不存在，请检查！", strClassName);
                throw new Exception(strMsg);
            }
            //使用Type对象也可以实例化一个对象同样调用上面方法
            clsEntityBase2 objEntityBase2 = (clsEntityBase2)Activator.CreateInstance(expType);
            return objEntityBase2;
        }


        public static void AddReferencedAssemblies(Page thisPage)
        {
            try
            {
                List<string> arrReferencedAssemblies = new List<string>();
             
                arrReferencedAssemblies.Add("AgcBLLEx.dll");
                arrReferencedAssemblies.Add("AgcDA.dll");
                arrReferencedAssemblies.Add("AgcEN.dll");
                arrReferencedAssemblies.Add("AgcBase.dll");
                arrReferencedAssemblies.Add("AutoGCLib.dll");
                //arrReferencedAssemblies.Add("CommonTableENDABL.dll");
                arrReferencedAssemblies.Add("PubDataBase.dll");
                arrReferencedAssemblies.Add("TzPubFunction.dll");
                string strFolderName_Root = thisPage.Server.MapPath("~");
                foreach (string strReferencedAssemblie in arrReferencedAssemblies)
                {
                    string strFindFileFullFile = clsFile.FindFileFromFolder(strFolderName_Root, strReferencedAssemblie);
                    if (string.IsNullOrEmpty(strFindFileFullFile) == true)
                    {
                        string strMsg = string.Format("所引用的程序集:[{0}]不存在！({1}->{2})",
                     strReferencedAssemblie,
                     clsStackTrace.GetCurrClassFunctionByLevel(2),
                     clsStackTrace.GetCurrClassFunction());
                        clsCommonJsFunc.Alert(thisPage, strMsg);
                    }

                    AutoGC_SelfDefineFunction.AddReferencedAssemblie(strFindFileFullFile);
                }
            }
            catch(Exception objException)
            {
                clsCommonJsFunc.Alert(thisPage, objException.Message);
            }
        }
        public static bool LogErrMsg(Page myPage, string strMsg)
        {
            StackTrace st = new StackTrace(new StackFrame(true));
            Console.WriteLine(" Stack trace for current level: {0}", st.ToString());
            StackFrame sf = st.GetFrame(0);
            Console.WriteLine(" File: {0}", sf.GetFileName());
            Console.WriteLine(" Method: {0}", sf.GetMethod().Name);
            Console.WriteLine(" Line Number: {0}", sf.GetFileLineNumber());
            Console.WriteLine(" Column Number: {0}", sf.GetFileColumnNumber());
            string strIpUser = clsCommonSession.UserId + " at " + clsCommForWebForm.GetClientIp();
            ErrorInformationBL.AddInformation(myPage.Request.Url.AbsolutePath, sf.GetMethod().Name, strMsg, strIpUser);
            return true;
        }

        /// <summary>
        /// 获取当前WEB项目的虚拟根目录
        /// </summary>
        /// <returns></returns>
        public static string GetVirtualRoot()
        {
            string strApp1 = System.Web.HttpContext.Current.Request.ApplicationPath;
            return strApp1;
        }
        /// <summary>
        /// 获取用户登陆IP
        /// </summary>
        /// <returns>返回用户IP</returns>
        public static string GetIp()
        {
            string user_IP;
            if (System.Web.HttpContext.Current.Request.ServerVariables["HTTP_VIA"] != null)
            {
                user_IP = System.Web.HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"].ToString();
            }
            else
            {
                user_IP = System.Web.HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"].ToString();
            }
            return user_IP;
        }
        public static bool IsLocal()
        {
            bool bolIsLocal = System.Web.HttpContext.Current.Request.IsLocal;
            return bolIsLocal;
        }
        /// <summary>
        /// 设置可视性
        /// </summary>
        public static void SetDgVisibility(DataGrid objDG)
        {
            foreach (DataGridColumn objDGColumn in objDG.Columns)
            {
                string strColumnName = objDGColumn.HeaderText;
                bool bolIsVisible = clsvSetFieldVisibilityBLEx.IsVisible(clsMyConfig.spSchool, strColumnName);
                if (bolIsVisible == false)
                {
                    objDGColumn.Visible = false;
                }
                //if (strColumnName == "卡号" && clsMyConfig.School == "THXY")
                //{
                //    objDGColumn.HeaderText = "工号";
                //}
            }
        }
        /// <summary>
        /// 设置GridView可视性
        /// </summary>
        public static void SetGvVisibility(GridView objGV, string strColumnName, bool bolIsVisible)
        {
            int intColumnNum = objGV.Columns.Count;
            for (int i = 0; i < intColumnNum; i++)
            {
                string strColumnNameIn = objGV.Columns[i].HeaderText;
                if (strColumnName.Equals(strColumnNameIn, StringComparison.CurrentCultureIgnoreCase) == true)
                {
                    objGV.Columns[i].Visible = bolIsVisible;
                    return;
                }
                string strColTypeName = objGV.Columns[i].GetType().ToString();
                if (strColTypeName.IndexOf("BoundField") == -1) continue;
                BoundField objBoundField = (BoundField)objGV.Columns[i];
                string strDataField = objBoundField.DataField;

                if (strColumnName.Equals(strDataField, StringComparison.CurrentCultureIgnoreCase) == true)
                {
                    objGV.Columns[i].Visible = bolIsVisible;
                    return;
                }
            }
        }
        /// <summary>
        /// 根据界面功能名称－设置可视性,
        /// </summary>
        public static void SetDgVisibilityByViewName(DataGrid objDG, string strViewName)
        {
            foreach (DataGridColumn objDGColumn in objDG.Columns)
            {
                string strColumnName = objDGColumn.HeaderText;
                bool bolIsVisible = clsvSetFieldVisibilityBLEx.IsVisible(clsMyConfig.spSchool, strViewName, strColumnName);
                if (bolIsVisible == false)
                {
                    objDGColumn.Visible = false;
                }
                //if (strColumnName == "卡号" && clsMyConfig.School == "THXY")
                //{
                //    objDGColumn.HeaderText = "工号";
                //}
            }
        }

        public static void SetDgVisibilityByViewName(GridView objDG, string strViewName)
        {
            foreach (DataControlField objDGColumn in objDG.Columns)
            {
                string strColTypeName = objDGColumn.GetType().ToString();
                if (strColTypeName.IndexOf("BoundField") == -1) continue;
                BoundField objBoundField = (BoundField)objDGColumn;


                string strColumnName = objBoundField.DataField;
                bool bolIsVisible = clsvSetFieldVisibilityBLEx.IsVisible(clsMyConfig.spSchool, strViewName, strColumnName);
                if (bolIsVisible == false)
                {
                    objDGColumn.Visible = false;
                }
                //if (strColumnName == "卡号" && clsMyConfig.School == "THXY")
                //{
                //    objDGColumn.HeaderText = "工号";
                //}
            }
        }

        /// <summary>
        /// 插入序号
        /// </summary>
        public static void InsertOrderNum(DataTable objDT, string strColumnName)
        {

            objDT.Columns.Add(strColumnName);
            int intOrderNum = 1;
            foreach (DataRow objDTRow in objDT.Rows)
            {
                objDTRow[strColumnName] = intOrderNum.ToString();
                intOrderNum++;
            }
        }

        public static Encoding GetEncodingByPrjUser(string strPrjId, string strUserId)
        {
            string strCondition = string.Format("PrjId='{0}' And UserId='{1}'", strPrjId, strUserId);
            string strCurrCharEncodingId = "";
            clsPrjUserCharEncodingRelaEN objPrjUserCharEncodingRelaEN = clsPrjUserCharEncodingRelaBL.GetFirstObj_S(strCondition);
            if (objPrjUserCharEncodingRelaEN == null)
            {
                string strCharEncodingId = clsCharEncodingBLEx.GetDefaultCharEncoding();
                objPrjUserCharEncodingRelaEN = new clsPrjUserCharEncodingRelaEN();
                objPrjUserCharEncodingRelaEN.CharEncodingId = strCharEncodingId;
                objPrjUserCharEncodingRelaEN.PrjId = strPrjId;
                objPrjUserCharEncodingRelaEN.UserId = strUserId;
                objPrjUserCharEncodingRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                objPrjUserCharEncodingRelaEN.UpdUserId = strUserId;
                clsPrjUserCharEncodingRelaBL.AddNewRecordBySql2(objPrjUserCharEncodingRelaEN);
                strCurrCharEncodingId = strCharEncodingId;
            }
            else
            {
                strCurrCharEncodingId = objPrjUserCharEncodingRelaEN.CharEncodingId;
            }
            Encoding myEncoding = clsString.GetEncodingObjByCharEncodingId(strCurrCharEncodingId);
            return myEncoding;
        }

        public static string GetCharEncodingIdByPrjUser(string strPrjId, string strUserId)
        {
            string strCondition = string.Format("PrjId='{0}' And UserId='{1}'", strPrjId, strUserId);
            string strCurrCharEncodingId = "";
            clsPrjUserCharEncodingRelaEN objPrjUserCharEncodingRelaEN = clsPrjUserCharEncodingRelaBL.GetFirstObj_S(strCondition);
            if (objPrjUserCharEncodingRelaEN == null)
            {
                string strCharEncodingId = clsCharEncodingBLEx.GetDefaultCharEncoding();
                objPrjUserCharEncodingRelaEN = new clsPrjUserCharEncodingRelaEN();
                objPrjUserCharEncodingRelaEN.CharEncodingId = strCharEncodingId;
                objPrjUserCharEncodingRelaEN.PrjId = strPrjId;
                objPrjUserCharEncodingRelaEN.UserId = strUserId;
                objPrjUserCharEncodingRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                objPrjUserCharEncodingRelaEN.UpdUserId = strUserId;
                clsPrjUserCharEncodingRelaBL.AddNewRecordBySql2(objPrjUserCharEncodingRelaEN);
                strCurrCharEncodingId = strCharEncodingId;
            }
            else
            {
                strCurrCharEncodingId = objPrjUserCharEncodingRelaEN.CharEncodingId;
            }

            return strCurrCharEncodingId;
        }

        public static void js_Tz_HideDiv(string strDivName, Page myPage, int intWaitTimes)
        {
            if (intWaitTimes > 0)
            {
                string c1 = string.Format("window.setTimeout(\"Tz_HideDiv('{0}')\", {1}); ", strDivName, intWaitTimes);
                myPage.ClientScript.RegisterStartupScript(myPage.GetType(), "js_Tz_HideDiv", c1, true);

            }
            else
            {
                string c1 = string.Format("Tz_HideDiv('{0}'); ", strDivName);
                myPage.ClientScript.RegisterStartupScript(myPage.GetType(), "js_Tz_HideDiv", c1, true);
            }
        }
        public static void js_Tz_ShowDiv(string strDivName, Page myPage, int intWaitTimes)
        {
            if (intWaitTimes > 0)
            {
                string c1 = string.Format("window.setTimeout(\"Tz_ShowDiv('{0}')\", {1}); ", strDivName, intWaitTimes);
                myPage.ClientScript.RegisterStartupScript(myPage.GetType(), "js_HideExerciseDiv", c1, true);
            }
            else
            {
                string c1 = string.Format("Tz_ShowDiv('{0}'); ", strDivName);
                myPage.ClientScript.RegisterStartupScript(myPage.GetType(), "js_Tz_ShowDiv", c1, true);
            }
        }
        public static void js_HideExerciseDiv(string strDivName, Page myPage, int intWaitTimes)
        {
            if (intWaitTimes > 0)
            {
                string c1 = string.Format("window.setTimeout(\"HideExerciseDiv('{0}')\", {1}); ", strDivName, intWaitTimes);
                myPage.ClientScript.RegisterStartupScript(myPage.GetType(), "js_HideExerciseDiv", c1, true);
            }
            else
            {
                string c1 = string.Format("HideExerciseDiv('{0}'); ", strDivName);
                myPage.ClientScript.RegisterStartupScript(myPage.GetType(), "js_HideExerciseDiv", c1, true);
            }
        }

        /// <summary>
        /// 弹出消息框并且跳转向到新的URL ,不需要页面对象
        /// </summary>
        /// <param name="message">消息内容</param>
        /// <param name="toURL">跳转的地址</param>
        public static void SetButtonEnabled(System.Web.UI.WebControls.Button objButton, bool bolIsEnabled)
        {
            if (bolIsEnabled == true)
            {
                objButton.Enabled = true;
                objButton.CssClass = "btn btn-outline-info btn-sm";

            }
            else
            {
                objButton.Enabled = false;
                objButton.CssClass = "btn btn-outline-info btn-sm disabled";
            }

        }

        public static void ShowUserDefaLangType(System.Web.UI.WebControls.RadioButtonList rblNetOrJava)
        {
            string strUserDefaLangType = clsUserDefaValue_LocalBLEx.getUserDefaValue(clsPubVar.CurrPrjId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId, "默认语言");
            rblNetOrJava.SelectedValue = strUserDefaLangType;
        }
        /// <summary>
        /// 从当前页面中获取某类型的所有控件
        /// </summary>
        /// <param name="thisPage">页面</param>
        /// <param name="pstrTypeName">所给类型名</param>
        /// <returns>返回所有符合条件的控件</returns>
        public static List<Control> GetControl4Type(Page thisPage, string pstrTypeName)
        {
            Queue<Control> quControls = new Queue<Control>();
            List<Control> arrControls = new List<Control>();
            foreach (Control ctrl in thisPage.Controls)
            {
                quControls.Enqueue(ctrl);
            }
            while(quControls.Count > 0)
            {
                Control ctrl = quControls.Dequeue();
                string strTypeName = ctrl.GetType().ToString();
                if (strTypeName.Contains(pstrTypeName) == true)
                {
                    arrControls.Add(ctrl);
                }
                foreach (Control ctrlp in ctrl.Controls)
                {
                    quControls.Enqueue(ctrlp);
                }
            }
            return arrControls;
        }
        public static void SetButton4ClearText(Page thisPage, TextBox txtCode)
        {

            foreach (Control ctrl in thisPage.Controls)
            {
                string strTypeName = ctrl.GetType().ToString();
                if (strTypeName.Contains("Button") == true)
                {
                    Button objButton = (Button)ctrl;
                    objButton.Attributes["onclick"] = string.Format("ClearText({0});", txtCode.ClientID);

                }
                else
                {
                    if (ctrl.Controls.Count>0)
                    {
                        SetButton4ClearText(ctrl, txtCode);
                    }
                }
            }
        }
        public static void SetButton4ClearText(Control thisCtrl, TextBox txtCode)
        {

            foreach (Control ctrl in thisCtrl.Controls)
            {
                string strTypeName = ctrl.GetType().ToString();
                if (strTypeName.Contains("LinkButton") == true)
                {
                   LinkButton objLinkButton = (LinkButton)ctrl;
                    objLinkButton.Attributes["onclick"] = string.Format("ClearText({0});", txtCode.ClientID);

                }
                else if (strTypeName.Contains("Button") == true)
                {
                    Button objButton = (Button)ctrl;
                    objButton.Attributes["onclick"] = string.Format("ClearText({0});", txtCode.ClientID);

                }
                else
                {
                    if (ctrl.Controls.Count > 0)
                    {
                        SetButton4ClearText(ctrl, txtCode);
                    }
                }

            }
        }
        public static void SetButtonEnabledInPager(System.Web.UI.WebControls.Button objButton, bool bolIsEnabled)
        {
            if (bolIsEnabled == true)
            {
                objButton.Enabled = true;
                objButton.CssClass = "Button_DefaInPager";

            }
            else
            {
                objButton.Enabled = false;
                objButton.CssClass = "Button_DefaInPager_false";
            }

        }
    }
}