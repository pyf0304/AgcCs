using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AGC.PureClass;
using AGC.PureClassEx;
using AgcCommBase;
using com.taishsoft.comm_db_obj;
using com.taishsoft.commexception;
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web.UI.WebControls;
using TzCommWebServerCtrlLib;

namespace AutoGCLib
{
    /// <summary>
    /// 自动生成界面控制层的代码类(View of Mvc)
    /// </summary>
    public class Mvc_ViewAjax4CSharp : clsGeneCodeBase4View
    {
        clsBiDimDistribute objBiDimDistribue4Qry = null;

        //		private objViewInfoENEx.FileName;		//生成的文件名；
        #region 构造函数
        public Mvc_ViewAjax4CSharp()
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            InitPageSetup();
        }
        public Mvc_ViewAjax4CSharp(string strViewId)
       : base(strViewId, "", "")
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            InitPageSetup();
        }
        public Mvc_ViewAjax4CSharp(string strViewId, string strPrjDataBaseId, string strPrjId)
        : base(strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            InitPageSetup();
        }
        #endregion
        /// <summary>
        /// 初始化页面设置
        /// </summary>
        public void InitPageSetup()
        {
            intZIndex = 100;        ///控件焦点序号
            intCurrLeft = 10;  ///控件的左边空;
            intCurrTop = 10;
        }



        /// <summary>
        /// 生成查询区域相关代码
        /// </summary>
        /// <returns></returns>
        public string Gen_MvcView_QryRegionCode4TableBak()
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //用来定义正文的标签类型
            clsLabelStyleEN objLabelStyle_Text = clsLabelStyleBL.GetObjByLabelStyleIdCache("0001");
            clsGenCtlStyleEN objGenCtlStyle = clsGenCtlStyleBL.GetObjByGenCtlStyleIdCache("0001");
            clsCheckStyleEN objCheckStyle = clsCheckStyleBL.GetObjByCheckStyleIdCache("0001");
            clsButtonStyleEN objButtonStyle = clsButtonStyleBL.GetObjByButtonStyleIdCache("0001");
            float intDivHeight;
            int intQueryFldNum = 0;

           
            objBiDimDistribue4Qry = new clsBiDimDistribute();

            objBiDimDistribue4Qry.ColNum = objViewInfoENEx.objViewRegion_Query.ColNum ?? 0;
            objBiDimDistribue4Qry.ColWidth = 250;
            objBiDimDistribue4Qry.LineHeight = 30;
            float intDivWidth = objBiDimDistribue4Qry.GetCtlWidth();

            intQueryFldNum = objViewInfoENEx.arrQryRegionFldSet.Count;

            //			intDivHeight = intQueryFldNum * 28 +40;
            intDivHeight = objBiDimDistribue4Qry.GetCtlHeigh(intQueryFldNum) + 40;

            
            strCodeForCs.Append("\r\n" + "<table style = \"width: 90%\"> ");

            intCurrTop -= 30;//因为这是在层(div)中
            int intFieldNum = 0;
            objBiDimDistribue4Qry.StartX = (int)intCurrLeft;
            objBiDimDistribue4Qry.StartY = (int)intCurrTop;
            ///生成专门用于查询的界面控件的代码;
            ///
            bool bolIsTrEnd = true;
            foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
            {
                if (intFieldNum % objViewInfoENEx.objViewRegion_Query.ColNum == 0)
                {
                    strCodeForCs.Append("\r\n" + "<tr>");
                    bolIsTrEnd = false;
                }

                switch (objQryRegionFldsEx.objCtlType.CtlTypeName)
                {
                    case "CheckBox":
                        strCodeForCs.Append("\r\n" + GenCheckBoxNoPosition(objCheckStyle, objQryRegionFldsEx.CtrlId(), objQryRegionFldsEx.LabelCaption));
                        break;
                    default:
                        string strTemp = Gen_Mvc_CombineCtlWithFor(objLabelStyle_Text,
                            objQryRegionFldsEx.FldName,
                          "lbl" + objQryRegionFldsEx.FldName + "_q",
                          objQryRegionFldsEx.LabelCaption,
                          objGenCtlStyle,
                          objQryRegionFldsEx.objCtlType.CtlTypeName,
                          objQryRegionFldsEx.CtrlId(), objQryRegionFldsEx.DsTabId, objQryRegionFldsEx.DdlItemsOptionId);
                        strCodeForCs.Append("\r\n" + strTemp);
                        break;
                }

                intZIndex += 1;
                intCurrTop += 28;
                intFieldNum++;
                if (intFieldNum % objViewInfoENEx.objViewRegion_Query.ColNum == 0)
                {
                    strCodeForCs.Append("\r\n" + "</tr>");
                    bolIsTrEnd = true;
                }
                intCurrLeft = objBiDimDistribue4Qry.GetPosition(intFieldNum).X;
                intCurrTop = objBiDimDistribue4Qry.GetPosition(intFieldNum).Y;

            }
            ///生成查询按钮的代码;
            ///
            if (bolIsTrEnd == true)
            {
                strCodeForCs.Append("\r\n" + "<tr>");
                bolIsTrEnd = false;
            }
            strCodeForCs.Append("\r\n" + "<td>");

            //strCodeForCs.Append("\r\n" + Gen_Mvc_ButtonInForm(objButtonStyle, "btnQuery", "查询"));
            //strCodeForCs.Append("\r\n" + GenButtonGroupInQuery());
            strCodeForCs.Append("\r\n" + "</td>");
            //strCodeForCs.Append("\r\n" + "<td>");
            //strCodeForCs.Append("\r\n" + "<a href = \"javascript:void(0);\" class=\"easyui-linkbutton\" data-options=\"iconCls:'icon-clear' \" onclick=\"resetSearch()\">清空</a>");
            //strCodeForCs.Append("\r\n" + "</td>");

            strCodeForCs.Append("\r\n" + "</tr>");
            strCodeForCs.Append("\r\n" + "</table>");

            intCurrTop += 40;
            return strCodeForCs.ToString();
        }

        public string Gen_MvcView_QryRegionCode4Table()
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //用来定义正文的标签类型
            clsLabelStyleEN objLabelStyle_Text = clsLabelStyleBL.GetObjByLabelStyleIdCache("0001");
            clsGenCtlStyleEN objGenCtlStyle = clsGenCtlStyleBL.GetObjByGenCtlStyleIdCache("0001");
            clsCheckStyleEN objCheckStyle = clsCheckStyleBL.GetObjByCheckStyleIdCache("0001");
            clsButtonStyleEN objButtonStyle = clsButtonStyleBL.GetObjByButtonStyleIdCache("0001");
            float intDivHeight;
            int intQueryFldNum = 0;

           
            objBiDimDistribue4Qry = new clsBiDimDistribute();

            objBiDimDistribue4Qry.ColNum = objViewInfoENEx.objViewRegion_Query.ColNum ?? 0;
            objBiDimDistribue4Qry.ColWidth = 250;
            objBiDimDistribue4Qry.LineHeight = 30;
            float intDivWidth = objBiDimDistribue4Qry.GetCtlWidth();

            intQueryFldNum = objViewInfoENEx.arrQryRegionFldSet.Count;

            //			intDivHeight = intQueryFldNum * 28 +40;
            intDivHeight = objBiDimDistribue4Qry.GetCtlHeigh(intQueryFldNum) + 40;


         
            intCurrTop -= 30;//因为这是在层(div)中
            //int intFieldNum = 0;
            objBiDimDistribue4Qry.StartX = (int)intCurrLeft;
            objBiDimDistribue4Qry.StartY = (int)intCurrTop;
            ///生成专门用于查询的界面控件的代码;
            ///
            //bool bolIsTrEnd = true;
            IEnumerable<clsViewRegionENEx> arrViewRegion = objViewInfoENEx.arrViewRegion.Where(x => x.RegionTypeId == enumRegionType.QueryRegion_0001);
            if (arrViewRegion.Count() == 0)
            {
                string strMsg = string.Format("界面功能区为空,请添加界面功能!界面:{0}. (In {1})", objViewInfoENEx.ViewName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);

            }
            string lngRegionId = arrViewRegion.First().RegionId;

            IEnumerable<ASPControlGroupEx> arrControlGroups = clsQryRegionFldsBLEx.GetControlGroup(lngRegionId, objViewInfoENEx, "Item1");

            ASPHtmlTableEx objTable = clsASPHtmlTableBLEx.PackageByTable4QueryRegion(arrControlGroups, objViewInfoENEx.objViewRegion_Query.ColNum ?? 0);
            objTable.GeneCode4Mvc(strCodeForCs);
            
            intCurrTop += 40;
            return strCodeForCs.ToString();
        }


        public bool DispQryRegionCtrl()
        {

            return true;
        }
        public string ClsName4WucTabName4Gv()
        {
            string strClsName = string.Format("wuc{0}4Gv", objViewInfoENEx.TabName_Out);
            return strClsName;
        }
      

        /// <summary>
        /// 功能:单表的查询、修改、插入、删除
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strFuncName = "";
            this.objViewInfoENEx = objViewInfoENEx;
            //让用户设置属性;
            if (objViewInfoENEx.arrEditRegionFldSet4InUse == null || objViewInfoENEx.arrEditRegionFldSet4InUse.Count == 0)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有编辑区域,或者编辑区域没有字段。请检查!", strViewName);
                sbMessage.Append("\r\n当前界面的功能:查询(Q)、修改(U)、删除(D)、添加(I)。");
                throw new clsDbObjException(sbMessage.ToString());
            }
          
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;
            clsPubFun4BLEx.CheckDgStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.DgStyleId);
            clsPubFun4BLEx.CheckTitleStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.TitleStyleId);

            clsDataGridStyleEN objDGStyleEx = clsDataGridStyleBL.GetObjByDgStyleIdCache(objViewInfoENEx.objViewStyleEN.DgStyleId);

            objViewInfoENEx.WebFormName = string.Format("{0}CRUDAjax", objViewInfoENEx.TabName);
            objViewInfoENEx.WebFormFName = string.Format("{0}{1}.cshtml",
                objViewInfoENEx.FolderName, objViewInfoENEx.WebFormName);
            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;
            objViewInfoENEx.ClsName = objViewInfoENEx.WebFormName;

            strRe_ClsName = objViewInfoENEx.WebFormName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            
            clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(objViewInfoENEx.CodeTypeId);
            if (objCodeType.IsDirByTabName == false)
            {
                strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebFormFName);
            }
            else
            {
                strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objViewInfoENEx.TabName, objViewInfoENEx.WebFormFName);
            }
            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                       clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objViewInfoENEx.FunctionTemplateId,
                       objViewInfoENEx.LangType, objViewInfoENEx.CodeTypeId, objViewInfoENEx.SqlDsTypeId);



            strCodeForCs.AppendFormat("\r\n" + "@using {0}.Entity", objProjectsENEx.PrjDomain);
            strCodeForCs.AppendFormat("\r\n" + "@using {0}Mvc.HtmlHelpers", objProjectsENEx.PrjDomain);
            strCodeForCs.AppendFormat("\r\n" + "@model Tuple<{0}Mvc.Models.QryModel4{2}, {0}Mvc.Models.FeatureModel4{1}>", 
                objProjectsENEx.PrjDomain, objMainPrjTab.TabName, objViewInfoENEx.TabName_Out);
            strCodeForCs.Append("\r\n" + "@{");
            strCodeForCs.Append("\r\n" + "    Layout = \"~/Views/Shared/TZ_Layout.cshtml\";");
            strCodeForCs.AppendFormat("\r\n" + "    ViewBag.Title = \"{0}\";", objViewInfoENEx.ViewCnName);
            strCodeForCs.Append("\r\n" + "    string controller = ViewContext.RouteData.Route.GetRouteData(this.Context).Values[\"controller\"].ToString();");
            strCodeForCs.Append("\r\n" + "    string action = ViewContext.RouteData.Values[\"action\"].ToString();");
            strCodeForCs.Append("\r\n" + "    string btnSaveName = \"\";");
            strCodeForCs.Append("\r\n" + "    if (ViewBag.Operate == \"Add\" )");
            strCodeForCs.Append("\r\n" + "    {");
            strCodeForCs.Append("\r\n" + "        btnSaveName = \"确认添加\";");
            strCodeForCs.Append("\r\n" + "    }");
            strCodeForCs.Append("\r\n" + "    else if (ViewBag.Operate == \"Update\" )");
            strCodeForCs.Append("\r\n" + "    {");
            strCodeForCs.Append("\r\n" + "        btnSaveName = \"确认修改\";");
            strCodeForCs.Append("\r\n" + "    }");
            strCodeForCs.Append("\r\n" + "AjaxOptions ajaxOpts = new AjaxOptions");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "UpdateTargetId = \"divLstTab_{0}\"",
                objViewInfoENEx.TabName_Out);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "<h3>{0}</h3>", objViewInfoENEx.ViewCnName);
            strCodeForCs.Append("\r\n" + "<h4>@ViewBag.Message</h4>");

            strCodeForCs.Append("\r\n" + "<style>");
            strCodeForCs.Append("\r\n" + "#divFunction{");
            strCodeForCs.Append("\r\n" + "margin-left:10%;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "</style>");

            strCodeForCs.Append("\r\n" + "<div>");

            try
            {
                clsTzGCScript objTzGCScript = new clsTzGCScript(objViewInfoENEx);
                string strTemp = "";
                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;

                    if (strFuncName.Substring(0, 6) == "Print:")
                    {
                        strCodeForCs.Append("\r\n" + "");
                        strCodeForCs.Append("\r\n" + "");
                        strCodeForCs.Append("\r\n " + strFuncName.Substring(6));
                        continue;
                    }

                    try
                    {
                        if (objvFunction4GeneCodeEN.FuncTypeId == "10")//用户自定义函数
                        {
                            strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId4View(objvFunction4GeneCodeEN.FuncId4GC,
                                 objViewInfoENEx.ViewId, objViewInfoENEx.PrjDataBaseId, objViewInfoENEx.PrjId);
                        }
                        else
                        {
                            strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                        }
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("在生成函数:[{0}]时出错。错误信息:{1}.", strFuncName, objException.Message);
                        throw new Exception(strMsg);
                    }
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }

                }
                strCodeForCs.Append("\r\n" + "</div>");

                strCodeForCs.Append("\r\n" + Gen_MvcView_JsFunc4CRUD());
       
                strCodeForCs.Append("\r\n" + Gen_MvcView_JsFunc4CRUD_Backup());

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }

            return strCodeForCs.ToString();
        }
        /// <summary>
        /// 功能:生成Js函数,用于界面的CRUD
        /// </summary>
        /// <returns></returns>
        public string Gen_MvcView_JsFunc4CRUD()
        {
            using (JsFunction objJsFunc = new JsFunction())
            {
                objJsFunc.funcName = "CheckAllHandler";
                objJsFunc.sbText.Append("\r\n" + "    function CheckAllHandler() {");
                objJsFunc.sbText.Append("\r\n" + "        //alert('CheckAllHandler');");
                objJsFunc.sbText.Append("\r\n" + "        var myCheckBox = event.target;");
                objJsFunc.sbText.Append("\r\n" + "        if (myCheckBox.checked === true) {");
                objJsFunc.sbText.AppendFormat("\r\n" + "            SetAllChecked('tab{0}Lst');", objViewInfoENEx.TabName_Out);
                objJsFunc.sbText.Append("\r\n" + "        }");
                objJsFunc.sbText.Append("\r\n" + "        else {");
                objJsFunc.sbText.AppendFormat("\r\n" + "            SetAllNoChecked('tab{0}Lst');", objViewInfoENEx.TabName_Out);
                objJsFunc.sbText.Append("\r\n" + "        }");
                objJsFunc.sbText.Append("\r\n" + "    }");

                arrJsFunction.Add(objJsFunc);
            }

            using (JsFunction objJsFunc = new JsFunction())
            {
                objJsFunc.funcName = "ShowEditDialog";
                objJsFunc.sbText.Append("\r\n" + "    function ShowEditDialog() {");
                objJsFunc.sbText.Append("\r\n" + "        //alert('complete');");
                objJsFunc.sbText.AppendFormat("\r\n" + "        $('#divEdit_{0}').modal('show');",
                    objViewInfoENEx.TabName_Out);
                objJsFunc.sbText.Append("\r\n" + "    }");
                arrJsFunction.Add(objJsFunc);
            }
            using (JsFunction objJsFunc = new JsFunction())
            {
                objJsFunc.funcName = "revertUTF8";
                objJsFunc.sbText.Append("\r\n" + "    function revertUTF8(szInput)");
                objJsFunc.sbText.Append("\r\n" + "    {");
                objJsFunc.sbText.Append("\r\n" + "    var x, wch, wch1, wch2, uch = \"\", szRet = \"\";");
                objJsFunc.sbText.Append("\r\n" + "    for (x = 0; x < szInput.length; x++)");
                objJsFunc.sbText.Append("\r\n" + "    {");
                objJsFunc.sbText.Append("\r\n" + "    if (szInput.charAt(x) == \"%\")");
                objJsFunc.sbText.Append("\r\n" + "    {");
                objJsFunc.sbText.Append("\r\n" + "    wch = parseInt(szInput.charAt(++x) + szInput.charAt(++x), 16);");
                objJsFunc.sbText.Append("\r\n" + "    if (!wch) { break; }");
                objJsFunc.sbText.Append("\r\n" + "    if (!(wch & 0x80))");
                objJsFunc.sbText.Append("\r\n" + "    {");
                objJsFunc.sbText.Append("\r\n" + "    wch = wch;");
                objJsFunc.sbText.Append("\r\n" + "    }");
                objJsFunc.sbText.Append("\r\n" + "    else if (!(wch & 0x20))");
                objJsFunc.sbText.Append("\r\n" + "    {");
                objJsFunc.sbText.Append("\r\n" + "    x++;");
                objJsFunc.sbText.Append("\r\n" + "    wch1 = parseInt(szInput.charAt(++x) + szInput.charAt(++x), 16);");
                objJsFunc.sbText.Append("\r\n" + "    wch = (wch & 0x1F) << 6;");
                objJsFunc.sbText.Append("\r\n" + "    wch1 = wch1 & 0x3F;");
                objJsFunc.sbText.Append("\r\n" + "    wch = wch + wch1;");
                objJsFunc.sbText.Append("\r\n" + "    }");
                objJsFunc.sbText.Append("\r\n" + "    else");
                objJsFunc.sbText.Append("\r\n" + "    {");
                objJsFunc.sbText.Append("\r\n" + "    x++;");
                objJsFunc.sbText.Append("\r\n" + "    wch1 = parseInt(szInput.charAt(++x) + szInput.charAt(++x), 16);");
                objJsFunc.sbText.Append("\r\n" + "    x++;");
                objJsFunc.sbText.Append("\r\n" + "    wch2 = parseInt(szInput.charAt(++x) + szInput.charAt(++x), 16);");
                objJsFunc.sbText.Append("\r\n" + "    wch = (wch & 0x0F) << 12;");
                objJsFunc.sbText.Append("\r\n" + "    wch1 = (wch1 & 0x3F) << 6;");
                objJsFunc.sbText.Append("\r\n" + "    wch2 = (wch2 & 0x3F);");
                objJsFunc.sbText.Append("\r\n" + "    wch = wch + wch1 + wch2;");
                objJsFunc.sbText.Append("\r\n" + "    }");
                objJsFunc.sbText.Append("\r\n" + "    szRet += String.fromCharCode(wch);");
                objJsFunc.sbText.Append("\r\n" + "    }");
                objJsFunc.sbText.Append("\r\n" + "    else");
                objJsFunc.sbText.Append("\r\n" + "    {");
                objJsFunc.sbText.Append("\r\n" + "    szRet += szInput.charAt(x);");
                objJsFunc.sbText.Append("\r\n" + "    }");
                objJsFunc.sbText.Append("\r\n" + "    }");
                objJsFunc.sbText.Append("\r\n" + "    return (szRet);");
                objJsFunc.sbText.Append("\r\n" + "    }");
                
                arrJsFunction.Add(objJsFunc);
            }
            using (JsFunction objJsFunc = new JsFunction())
            {
                objJsFunc.funcName = "OnFailureInFeatureRegion";
                objJsFunc.sbText.Append("\r\n" + "    function OnFailureInFeatureRegion(ajaxContext)");
                objJsFunc.sbText.Append("\r\n" + "    {");
                objJsFunc.sbText.Append("\r\n" + "    //var response = ajaxContext.get_response();");
                objJsFunc.sbText.Append("\r\n" + "    var statusText = ajaxContext.statusText;");
                objJsFunc.sbText.Append("\r\n" + "    var statusText_decode = revertUTF8(statusText);");
                objJsFunc.sbText.Append("\r\n" + "    console.log('revertUTF8:' + statusText_decode);");

                objJsFunc.sbText.Append("\r\n" + "    //var statusCode = response.get_statusCode();");
                objJsFunc.sbText.Append("\r\n" + "    alert(statusText_decode);");


                objJsFunc.sbText.Append("\r\n" + "    $('#spnMsg_Lst').html(statusText_decode);");
                //alert(statusText);

                objJsFunc.sbText.Append("\r\n" + "    }");
          
                arrJsFunction.Add(objJsFunc);
            }

            using (JsFunction objJsFunc = new JsFunction())
            {
                objJsFunc.funcName = "HideEditDialog";
                objJsFunc.sbText.Append("\r\n" + "    function HideEditDialog() {");
                objJsFunc.sbText.Append("\r\n" + "        //alert('complete');");
                objJsFunc.sbText.AppendFormat("\r\n" + "        $('#divEdit_{0}').modal('hide');",
                    objViewInfoENEx.TabName_Out);
                objJsFunc.sbText.Append("\r\n" + "    }");
                arrJsFunction.Add(objJsFunc);
            }
            using (JsFunction objJsFunc = new JsFunction())
            {
                objJsFunc.funcName = "OnSuccessInFeatureRegion";

                objJsFunc.sbText.Append("\r\n" + "    function OnSuccessInFeatureRegion(response, xhr){");
                objJsFunc.sbText.Append("\r\n" + "          switch (_clickedId) {");
                objJsFunc.sbText.Append("\r\n" + "              case \"btnCreate\":");
                objJsFunc.sbText.Append("\r\n" + "              case \"btnUpdate\":");
                objJsFunc.sbText.Append("\r\n" + "                  $('#divEdit').html(response);");
                objJsFunc.sbText.Append("\r\n" + "                  break;");
                objJsFunc.sbText.Append("\r\n" + "              case  \"btnExportExcel\":");
                objJsFunc.sbText.Append("\r\n" + "                  $('#spnExportExcel').html(response);");
                objJsFunc.sbText.Append("\r\n" + "                  break;");
                objJsFunc.sbText.Append("\r\n" + "              default:");
          objJsFunc.sbText.AppendFormat("\r\n" + "                  $('#divLstTab_{0}').html(response);", objViewInfoENEx.TabName_Out);
                objJsFunc.sbText.Append("\r\n" + "                  break;");
                objJsFunc.sbText.Append("\r\n" + "          }");
          //      objJsFunc.sbText.Append("\r\n" + "          strMsg = '@TempData[\"message\"]';");
                objJsFunc.sbText.Append("\r\n" + "          ShowFeatureRegionMsg(strMsg);");

                objJsFunc.sbText.Append("\r\n" + "    }");
                arrJsFunction.Add(objJsFunc);
            }

            using (JsFunction objJsFunc = new JsFunction())
            {
                objJsFunc.funcName = "OnSuccessInQueryRegion";

                objJsFunc.sbText.Append("\r\n" + "//查询区按钮被单击后,返回共享页面内容,再根据不同功能,更新不同的区域");
                objJsFunc.sbText.Append("\r\n" + "    function OnSuccessInQueryRegion(response, xhr){");
                objJsFunc.sbText.Append("\r\n" + "        switch (_clickedId){");
                objJsFunc.sbText.Append("\r\n" + "              case \"btnQuery\":");
          objJsFunc.sbText.AppendFormat("\r\n" + "                  $('#divLstTab_{0}').html(response);", objViewInfoENEx.TabName_Out);
                objJsFunc.sbText.Append("\r\n" + "                  break;");                
                objJsFunc.sbText.Append("\r\n" + "              case \"btnExportExcel\":");
                objJsFunc.sbText.Append("\r\n" + "                  $('#spnExportExcel').html(response);");
                objJsFunc.sbText.Append("\r\n" + "                  break;");
                objJsFunc.sbText.Append("\r\n" + "              default:");
          objJsFunc.sbText.AppendFormat("\r\n" + "                  $('#divLstTab_{0}').html(response);", objViewInfoENEx.TabName_Out);
                objJsFunc.sbText.Append("\r\n" + "                  break;");
                objJsFunc.sbText.Append("\r\n" + "        }");

                //objJsFunc.sbText.Append("\r\n" + "if (response.indexOf('UpdateTargetId:Edit') > 0)");
                //objJsFunc.sbText.Append("\r\n" + "{");
                //objJsFunc.sbText.Append("\r\n" + "$('#divEdit').html(response);");
                //objJsFunc.sbText.Append("\r\n" + "}");
                //objJsFunc.sbText.Append("\r\n" + "else");
                //objJsFunc.sbText.Append("\r\n" + "{");
                //objJsFunc.sbText.AppendFormat("\r\n" + "$('#divLstTab_{0}').html(response);", objViewInfoENEx.TabName_Out);
                //objJsFunc.sbText.Append("\r\n" + "}");
                //alert("已经替换在divEdit");
                objJsFunc.sbText.Append("\r\n" + "    }");

                arrJsFunction.Add(objJsFunc);
            }

            using (JsFunction objJsFunc = new JsFunction())
            {
                objJsFunc.funcName = "OnClickInFeatureRegion";

                objJsFunc.sbText.Append("\r\n" + "  //功能区按钮被单击时,记录单击按钮的Id");
                objJsFunc.sbText.Append("\r\n" + "    function OnClickInFeatureRegion(){");
                objJsFunc.sbText.Append("\r\n" + "        _clickedId = event.target.id;");
                objJsFunc.sbText.Append("\r\n" + "        console.log(_clickedId);");
                objJsFunc.sbText.Append("\r\n" + "    }");
                arrJsFunction.Add(objJsFunc);
            }

            using (JsFunction objJsFunc = new JsFunction())
            {
                objJsFunc.funcName = "ShowErrMsg";
                objJsFunc.sbText.Append("\r\n" + "  //用于显示错误的函数,同时更新界面上的显示错误的控件信息");
                objJsFunc.sbText.Append("\r\n" + "    function ShowErrMsg(strMsg){");
                objJsFunc.sbText.Append("\r\n" + "        alert(strMsg);");
                objJsFunc.sbText.Append("\r\n" + "        if (strMsg.indexOf('SaveAjax') > 0){");
                objJsFunc.sbText.Append("\r\n" + "            $('#spnEditErr').html(strMsg);");
                objJsFunc.sbText.Append("\r\n" + "        }");
                objJsFunc.sbText.Append("\r\n" + "    }");
                arrJsFunction.Add(objJsFunc);
            }
            using (JsFunction objJsFunc = new JsFunction())
            {
                objJsFunc.funcName = "ShowFeatureRegionMsg";
                objJsFunc.sbText.Append("\r\n" + "  //用于显示错误的函数,同时更新界面上的显示错误的控件信息");
                objJsFunc.sbText.Append("\r\n" + "    function ShowFeatureRegionMsg(pstrMsg){");
         
                objJsFunc.sbText.Append("\r\n" + "          switch (_clickedId) {");
                objJsFunc.sbText.Append("\r\n" + "              case \"btnCreate\":");
                objJsFunc.sbText.Append("\r\n" + "              case \"btnUpdate\":");
                objJsFunc.sbText.Append("\r\n" + "                  break;");
                objJsFunc.sbText.Append("\r\n" + "              case  \"btnDeletes\":");
        
                objJsFunc.sbText.Append("\r\n" + "                  $('#spnMsg_Lst').html(pstrMsg);");
                objJsFunc.sbText.Append("\r\n" + "                  alert(pstrMsg);");
                objJsFunc.sbText.Append("\r\n" + "                  break;");
                objJsFunc.sbText.Append("\r\n" + "              default:");
                objJsFunc.sbText.Append("\r\n" + "                  $('#spnMsg_Lst').html(pstrMsg);");
                objJsFunc.sbText.Append("\r\n" + "                  break;");
                objJsFunc.sbText.Append("\r\n" + "          }");

                objJsFunc.sbText.Append("\r\n" + "    }");
                arrJsFunction.Add(objJsFunc);
            }
            arrJsFunction.Sort((x, y) => { return x.funcName.CompareTo(y.funcName); });
          
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
        
            strCodeForCs.Append("\r\n" + "<script type=\"text/javascript\">");
            strCodeForCs.Append("\r\n" + "//Js函数,用于界面的CRUD");
            strCodeForCs.Append("\r\n" + "    var strOperate = \"@ViewBag.Operate\";");
            strCodeForCs.Append("\r\n" + "    var strMsg = '@TempData[\"message\"]';");
            strCodeForCs.Append("\r\n" + "    var IsHideQryRegion = \"@ViewBag.IsHideQryRegion\";");
            strCodeForCs.Append("\r\n" + "    //功能区按钮被单击后,返回共享页面内容,再根据不同功能,更新不同的区域");
            strCodeForCs.Append("\r\n" + "    var _clickedId = \"\";");
            strCodeForCs.Append("\r\n" + "    $(function () {");
            strCodeForCs.Append("\r\n" + "        //    searchExamType();");
            strCodeForCs.Append("\r\n" + "    });");
            foreach (JsFunction objJsFunction in arrJsFunction)
            {
                strCodeForCs.Append("\r\n" + objJsFunction.funcText);
            }





            strCodeForCs.Append("\r\n" + "    if (strOperate == \"Add\") {");
            strCodeForCs.Append("\r\n" + "        ShowEditDialog();");
            strCodeForCs.Append("\r\n" + "    }");
            strCodeForCs.Append("\r\n" + "    else if (strOperate == \"Update\") {");
            strCodeForCs.Append("\r\n" + "        ShowEditDialog();");
            strCodeForCs.Append("\r\n" + "    }");
            strCodeForCs.Append("\r\n" + "    else {");
            strCodeForCs.Append("\r\n" + "        HideEditDialog();");
            strCodeForCs.Append("\r\n" + "    }");
            strCodeForCs.Append("\r\n" + "    var EditError = \"@ViewBag.EditError\";");
            strCodeForCs.Append("\r\n" + "    if (EditError == \"true\") {");
            strCodeForCs.Append("\r\n" + "        ShowEditDialog();");
            strCodeForCs.Append("\r\n" + "    }");

            strCodeForCs.Append("\r\n" + "    if (IsHideQryRegion == \"True\"){");
            strCodeForCs.Append("\r\n" + "        $('#divQryRegion').hide();");
            strCodeForCs.Append("\r\n" + "    }");


            strCodeForCs.Append("\r\n" + "</script>");
            return strCodeForCs.ToString();
        }
        /// <summary>
        /// 功能:生成Js函数,用于界面的CRUD, 后备之用
        /// </summary>
        /// <returns></returns>
        public string Gen_MvcView_JsFunc4CRUD_Backup()
        {
                    List<JsFunction> arrJsFunc = new List<JsFunction>();
            using (JsFunction objJsFunc = new JsFunction())
            {
                objJsFunc.funcName = "resetSearch";
                objJsFunc.sbText.Append("\r\n" + "    //删除多条记录");
                objJsFunc.sbText.AppendFormat("\r\n" + "    function Delete{0}s() {{",
                    objMainPrjTab.TabName);
                objJsFunc.sbText.Append("\r\n" + "        if ($(\".checkboxes:checked\").length == 0) {");
                objJsFunc.sbText.Append("\r\n" + "            alert(\"请选择删除的数据行!\");");
                objJsFunc.sbText.Append("\r\n" + "            return;");
                objJsFunc.sbText.Append("\r\n" + "        }");
                objJsFunc.sbText.Append("\r\n" + "        var objects = new Array();");
                objJsFunc.sbText.Append("\r\n" + "        var obj = null;");
                objJsFunc.sbText.Append("\r\n" + "        $('.table').each(function () {");
                objJsFunc.sbText.Append("\r\n" + "            var objtr = $(this);");
                objJsFunc.sbText.Append("\r\n" + "            if (objtr.find(\".checkboxes\").prop('checked')) {");
                objJsFunc.sbText.Append("\r\n" + "                obj = new Object();");
                objJsFunc.sbText.Append("\r\n" + "                obj.Module_nbr = objtr.find(\".checkboxes\").val();");
                objJsFunc.sbText.Append("\r\n" + "                objects.push(obj);");
                objJsFunc.sbText.Append("\r\n" + "            }");
                objJsFunc.sbText.Append("\r\n" + "        })");
                objJsFunc.sbText.Append("\r\n" + "        var data = JSON.stringify(objects);");
                objJsFunc.sbText.Append("\r\n" + "        alert(data);");
                objJsFunc.sbText.Append("\r\n" + "    }");

                arrJsFunc.Add(objJsFunc);
            }
            using (JsFunction objJsFunc = new JsFunction())
            {
                objJsFunc.funcName = "resetSearch";
                objJsFunc.sbText.Append("\r\n" + "    //查询清空");
                objJsFunc.sbText.Append("\r\n" + "    function resetSearch() {");
                objJsFunc.sbText.Append("\r\n" + "        $('#search_Form').form('clear');");
                objJsFunc.sbText.Append("\r\n" + "    }");
                arrJsFunc.Add(objJsFunc);
            }
            using (JsFunction objJsFunc = new JsFunction())
            {
                objJsFunc.funcName = "delExamType";
                objJsFunc.sbText.Append("\r\n" + "    function delExamType(strExamTypeId) {");
                objJsFunc.sbText.Append("\r\n" + "        $.messager.confirm('确认', '是否真的删除?', function (r) {");
                objJsFunc.sbText.Append("\r\n" + "            if (r) {");
                objJsFunc.sbText.Append("\r\n" + "                $.ajax({");
                objJsFunc.sbText.Append("\r\n" + "                    url: \"DelRecord\",");
                objJsFunc.sbText.Append("\r\n" + "                    cache: false,");
                objJsFunc.sbText.Append("\r\n" + "                    async: false,");
                objJsFunc.sbText.Append("\r\n" + "                    type: 'post',");
                objJsFunc.sbText.Append("\r\n" + "                    dataType: \"json\",");
                objJsFunc.sbText.Append("\r\n" + "                    data: { ExamTypeId: strExamTypeId },");
                objJsFunc.sbText.Append("\r\n" + "                    success: function (text) {");
                objJsFunc.sbText.Append("\r\n" + "                        if (text == '1') {");
                objJsFunc.sbText.Append("\r\n" + "                            $('#tbl').datagrid('reload');");
                objJsFunc.sbText.Append("\r\n" + "                            $.messager.alert(\"友情提示\", \"删除成功\");");
                objJsFunc.sbText.Append("\r\n" + "                        }");
                objJsFunc.sbText.Append("\r\n" + "                        else {");
                objJsFunc.sbText.Append("\r\n" + "                            $.messager.alert(\"删除失败\");");
                objJsFunc.sbText.Append("\r\n" + "                        }");
                objJsFunc.sbText.Append("\r\n" + "                    }");
                objJsFunc.sbText.Append("\r\n" + "                });");
                objJsFunc.sbText.Append("\r\n" + "            }");
                objJsFunc.sbText.Append("\r\n" + "        });");
                objJsFunc.sbText.Append("\r\n" + "    }");
                arrJsFunc.Add(objJsFunc);
            }
            using (JsFunction objJsFunc = new JsFunction())
            {
                objJsFunc.funcName = "save()";
                objJsFunc.sbText.Append("\r\n" + "    //添加方法");
                objJsFunc.sbText.Append("\r\n" + "    function save() {");
                objJsFunc.sbText.Append("\r\n" + "        $('#add_Form').form('submit', {");
                objJsFunc.sbText.Append("\r\n" + "            url: 'SaveExamType',");
                objJsFunc.sbText.Append("\r\n" + "            onSubmit: function () {");
                objJsFunc.sbText.Append("\r\n" + "                var valid = $('#add_Form').form('validate');");
                objJsFunc.sbText.Append("\r\n" + "                if (valid == false) {");
                objJsFunc.sbText.Append("\r\n" + "                    return false;");
                objJsFunc.sbText.Append("\r\n" + "                }");
                objJsFunc.sbText.Append("\r\n" + "                return true;");
                objJsFunc.sbText.Append("\r\n" + "            },");
                objJsFunc.sbText.Append("\r\n" + "            success: function (data) {");
                objJsFunc.sbText.Append("\r\n" + "                data = eval('(' + data + ')');");
                objJsFunc.sbText.Append("\r\n" + "                if (data.Success) {");
                objJsFunc.sbText.Append("\r\n" + "                    $('#add_dialog').dialog('close');");
                objJsFunc.sbText.Append("\r\n" + "                    $('#tbl').datagrid('reload');");
                objJsFunc.sbText.Append("\r\n" + "                } else {");
                objJsFunc.sbText.Append("\r\n" + "                    $.messager.alert(\"友情提示\", data.Message);");
                objJsFunc.sbText.Append("\r\n" + "                }");
                objJsFunc.sbText.Append("\r\n" + "            }");
                objJsFunc.sbText.Append("\r\n" + "        });");
                objJsFunc.sbText.Append("\r\n" + "    }");
                arrJsFunc.Add(objJsFunc);
            }
            using (JsFunction objJsFunc = new JsFunction())
            {
                objJsFunc.funcName = "GetReturnStr";
                objJsFunc.sbText.Append("\r\n" + "    function GetReturnStr() {");
                objJsFunc.sbText.Append("\r\n" + "        //alert('complete');");
                objJsFunc.sbText.Append("\r\n" + "        //  $('#myModal4Edit').modal('show');");
                objJsFunc.sbText.AppendFormat("\r\n" + "        var {0} = \"ABC\";", objKeyField.PrivFuncName);
                objJsFunc.sbText.AppendFormat("\r\n" + "        $.post(\"GetReturnStr\", {{ {0}: {1} }}, function (data) {{ alert(data); }});",
                    objKeyField.FldName, objKeyField.PrivFuncName);
                objJsFunc.sbText.Append("\r\n" + "    }");
                arrJsFunc.Add(objJsFunc);
            }
            arrJsFunc.Sort((x, y) => { return x.funcName.CompareTo(y.funcName); });
           

            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;

            strCodeForCs.Append("\r\n" + "<script type=\"text/javascript\">");
            strCodeForCs.Append("\r\n" + "//Js函数,用于界面的CRUD, 后备之用,可能后面派作用");
            Gen_MvcView_Js_DdlSelected();

            foreach (JsFunction objJsFunction in arrJsFunc)
            {
                strCodeForCs.Append("\r\n" + objJsFunction.funcText);
            }

            strCodeForCs.Append("\r\n" + "</script>");
            return strCodeForCs.ToString();
        }


        /// <summary>
        /// 功能:生成查询区域
        /// </summary>
        /// <returns></returns>
        public string Gen_MvcView_QueryRegion()
        {
            string strFuncName = "";
          
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;

            try
            {
                ///生成插入记录的界面代码;
                strCodeForCs.AppendFormat("\r\n" + "@* 生成的针对Mvc View 的查询区域 *@");
                strCodeForCs.AppendFormat("\r\n" + "@* 生成函数:{0} *@", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "<div id=\"user_accordion\" class=\"easyui-accordion\" style=\"width:100%\" data-options=\"multiple:true\">");
                strCodeForCs.Append("\r\n" + "   <div title=\"查询选项\" style=\"padding:10px;\" data-options=\"collapsed:false,collapsible:true\">");
                strCodeForCs.Append("\r\n" + "     <div style=\"width:98%;margin:auto\">");
                strCodeForCs.AppendFormat("\r\n" + "     @using (Html.BeginForm(\"{1}_Query\", \"{0}\", FormMethod.Post))",
                    objMainPrjTab.TabName, objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "     {");
                string strTemp = Gen_MvcView_QryRegionCode4Table();
                strCodeForCs.AppendFormat("\r\n" + "{0}", strTemp);

                strCodeForCs.Append("\r\n" + "     }");
                strCodeForCs.Append("\r\n" + "     </div>");
                strCodeForCs.Append("\r\n" + "   </div>");
                strCodeForCs.Append("\r\n" + "</div>");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 功能:生成查询区域
        /// </summary>
        /// <returns></returns>
        public string Gen_MvcView_QueryRegionAjax()
        {
            string strFuncName = "";
           
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;

            try
            {
                ///生成插入记录的界面代码;
                strCodeForCs.AppendFormat("\r\n" + "@* 生成的针对Mvc View 的查询区域 *@");
                strCodeForCs.AppendFormat("\r\n" + "@* 生成函数:{0} *@", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " <div id=\"divQryRegion\" class=\"float-left\">");
                strCodeForCs.AppendFormat("\r\n" + "     @using (Ajax.BeginForm(\"Command4Query\", \"{0}\", new AjaxOptions {{ OnSuccess = \"OnSuccessInQueryRegion\" }}))",
                    objMainPrjTab.TabName, objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "     {");
 

          
                strCodeForCs.Append("\r\n" + "<div style=\"float:left; width:80%;\">");

                string strTemp = Gen_MvcView_QryRegionCode4Table();
                strCodeForCs.AppendFormat("\r\n" + "{0}", strTemp);
                strCodeForCs.Append("\r\n" + "</div>");
                strCodeForCs.Append("\r\n" + "<div style=\"float:left; width:100%;\">");
                strCodeForCs.Append("\r\n" + Gen_ValidationSummary());

                strCodeForCs.Append("\r\n" + "</div>");

                //strCodeForCs.Append("\r\n" + "<div class=\"panel-footer\">");

            
                //strCodeForCs.Append("\r\n" + "     </div>");
                strCodeForCs.Append("\r\n" + "     }");
                                
                strCodeForCs.Append("\r\n" + "</div>");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }

            return strCodeForCs.ToString();
        }



        /// <summary>
        /// 功能:生成查询区域
        /// </summary>
        /// <returns></returns>
        public string Gen_MvcView_QueryRegionSpa()
        {
            string strFuncName = "";
          
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;

            try
            {
                ///生成插入记录的界面代码;
                strCodeForCs.AppendFormat("\r\n" + "@* 生成的针对Mvc View 的查询区域 *@");
                strCodeForCs.AppendFormat("\r\n" + "@* 生成函数:{0} *@", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "<div id=\"user_accordion\" class=\"easyui-accordion\" style=\"width:100%\" data-options=\"multiple:true\">");
                strCodeForCs.Append("\r\n" + "   <div title=\"查询选项\" style=\"padding:10px;\" data-options=\"collapsed:false,collapsible:true\">");
                strCodeForCs.Append("\r\n" + "     <div style=\"width:98%;margin:auto\">");
                strCodeForCs.AppendFormat("\r\n" + "     @using (Ajax.BeginForm(\"{1}_QueryAjax\", \"{0}\", ajaxOpts))",
                    objMainPrjTab.TabName, objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "     {");
                string strTemp = Gen_MvcView_QryRegionCode4Table();
                strCodeForCs.AppendFormat("\r\n" + "{0}", strTemp);

                strCodeForCs.Append("\r\n" + "     }");
                strCodeForCs.Append("\r\n" + "     </div>");
                strCodeForCs.Append("\r\n" + "   </div>");
                strCodeForCs.Append("\r\n" + "</div>");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 功能:生成编辑区域
        /// </summary>
        /// <returns></returns>
        public string Gen_MvcView_EditRegion()
        {
            string strFuncName = "";
            if (objViewInfoENEx.arrEditRegionFldSet4InUse == null)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有编辑区域。请检查!", strViewName);
                sbMessage.Append("\r\n当前界面的功能:查询(Q)、修改(U)、删除(D)、添加(I)。");
                throw new clsDbObjException(sbMessage.ToString());
            }
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;

            try
            {
                ///生成插入记录的界面代码;
                strCodeForCs.AppendFormat("\r\n" + "@* 生成的针对Mvc View 的编辑区域 *@");
                strCodeForCs.AppendFormat("\r\n" + "@* 生成函数:{0} *@", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n" + "<div class=\"modal fade\" id=\"divEditDialog_{0}\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"lblDialogTitle_{0}\" aria-hidden=\"true\">",
                    objViewInfoENEx.TabName_In);
                strCodeForCs.Append("\r\n" + "    <div class=\"modal-dialog modal-sm\">");
                strCodeForCs.Append("\r\n" + "        <div class=\"modal-content text-left\" style=\"width: 600px; \">");
                strCodeForCs.Append("\r\n" + "            <div class=\"modal-header\">");
                strCodeForCs.Append("\r\n" + "                <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\"><span aria-hidden=\"true\">×</span></button>");
                strCodeForCs.AppendFormat("\r\n" + "          <h4 class=\"modal-title\" id=\"lblDialogTitle_{1}\">{0}编辑</h4>", 
                    objViewInfoENEx.TabCnName,
                    objViewInfoENEx.TabName_In);
                strCodeForCs.Append("\r\n" + "                @Html.ValidationSummary(true, \"\", new { @class = \"text-danger\" })");
                strCodeForCs.Append("\r\n" + "            </div>");


                strCodeForCs.AppendFormat("\r\n" + "      @using (Html.BeginForm(\"Save\", \"{0}\", FormMethod.Post))",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "            {");
                strCodeForCs.Append("\r\n" + "                if (ViewBag.Operate == \"Add\")");
                strCodeForCs.Append("\r\n" + "                {");
                strCodeForCs.Append("\r\n" + "                     @Html.Hidden(\"Operate\", \"Add\")");
                strCodeForCs.Append("\r\n" + "                 }");
                strCodeForCs.Append("\r\n" + "                 else");
                strCodeForCs.Append("\r\n" + "                 {");
                strCodeForCs.Append("\r\n" + "                      @Html.Hidden(\"Operate\", \"Update\")");
                if (objKeyField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    strCodeForCs.AppendFormat("\r\n" + "@Html.Hidden(\"{0}\", \"@Model.{0}\")", FldName4Key);
                }
                strCodeForCs.Append("\r\n" + "                 }");


                strCodeForCs.Append("\r\n" + "                @Html.AntiForgeryToken()");
                strCodeForCs.Append("\r\n" + "                <div class=\"modal-body\">");
                strCodeForCs.Append("\r\n" + "                    <div class=\"modal-footer\">");
                string strTemp = Gen_MvcView_CtlViewCodeforTab();
                strCodeForCs.AppendFormat("\r\n" + "{0}", strTemp);
                strCodeForCs.Append("\r\n" + "                        <div class=\"form-group\">");
                strCodeForCs.Append("\r\n" + "                            <div class=\"col-md-offset-2 col-md-10\">");
                strCodeForCs.Append("\r\n" + "                                <input type=\"submit\" value=\"@btnSaveName\" class=\"btn btn-default\" name=\"btnSave\" id=\"btnSave\" />");
                strCodeForCs.Append("\r\n" + "                                <button class=\"btn btn-default\" data-dismiss=\"modal\">Cancel</button>");
                strCodeForCs.Append("\r\n" + "                            </div>");
                strCodeForCs.Append("\r\n" + "                        </div>");
                strCodeForCs.Append("\r\n" + "                    </div>");
                strCodeForCs.Append("\r\n" + "                </div>");
                strCodeForCs.Append("\r\n" + "            }");
                strCodeForCs.Append("\r\n" + "        </div>");
                strCodeForCs.Append("\r\n" + "    </div>");
                strCodeForCs.Append("\r\n" + "</div>");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }

            return strCodeForCs.ToString();
        }


        /// <summary>
        /// 功能:生成编辑区域
        /// </summary>
        /// <returns></returns>
        public string Gen_MvcView_EditRegionAjax()
        {
            string strFuncName = "";
            if (objViewInfoENEx.arrEditRegionFldSet4InUse == null)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有编辑区域。请检查!", strViewName);
                sbMessage.Append("\r\n当前界面的功能:查询(Q)、修改(U)、删除(D)、添加(I)。");
                throw new clsDbObjException(sbMessage.ToString());
            }
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;

            try
            {
                ///生成插入记录的界面代码;
                strCodeForCs.AppendFormat("\r\n" + "@* 生成的针对Mvc View 的编辑区域 *@");
                strCodeForCs.AppendFormat("\r\n" + "@* 生成函数:{0} *@", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n" + "<div class=\"modal fade\" id=\"divEditDialog_{0}\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"lblDialogTitle_{0}\" aria-hidden=\"true\">",
                    objViewInfoENEx.TabName_In);
                strCodeForCs.Append("\r\n" + "    <div class=\"modal-dialog modal-sm\">");
                strCodeForCs.Append("\r\n" + "        <div class=\"modal-content text-left\" style=\"width: 600px; \">");
                strCodeForCs.Append("\r\n" + "            <div class=\"modal-header\">");
                strCodeForCs.Append("\r\n" + "                <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\"><span aria-hidden=\"true\">×</span></button>");
                strCodeForCs.AppendFormat("\r\n" + "          <h4 class=\"modal-title\" id=\"lblDialogTitle_{1}\">{0}编辑</h4>", 
                    objViewInfoENEx.TabCnName,
                    objViewInfoENEx.TabName_In);
                strCodeForCs.Append("\r\n" + "                @Html.ValidationSummary(true, \"\", new { @class = \"text-danger\" })");
                strCodeForCs.Append("\r\n" + "            </div>");


                strCodeForCs.AppendFormat("\r\n" + "      @using (Html.BeginForm(\"Save\", \"{0}\", FormMethod.Post))",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "            {");
                strCodeForCs.Append("\r\n" + "                if (ViewBag.Operate == \"Add\")");
                strCodeForCs.Append("\r\n" + "                {");
                strCodeForCs.Append("\r\n" + "                     @Html.Hidden(\"Operate\", \"Add\")");
                strCodeForCs.Append("\r\n" + "                 }");
                strCodeForCs.Append("\r\n" + "                 else");
                strCodeForCs.Append("\r\n" + "                 {");
                strCodeForCs.Append("\r\n" + "                      @Html.Hidden(\"Operate\", \"Update\")");
                if (objKeyField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    strCodeForCs.AppendFormat("\r\n" + "@Html.Hidden(\"{0}\", @Model.{0})", FldName4Key);
                }
                else
                {
                    //strCodeForCs.AppendFormat("\r\n" + "@Html.Hidden(\"{0}\", @Model.{0})", FldName4Key);
                }
                strCodeForCs.Append("\r\n" + "                 }");


                strCodeForCs.Append("\r\n" + "                @Html.AntiForgeryToken()");
                strCodeForCs.Append("\r\n" + "                <div class=\"modal-body\">");
                strCodeForCs.Append("\r\n" + "                    <div class=\"modal-footer\">");
                string strTemp = Gen_MvcView_CtlViewCodeforTab();
                strCodeForCs.AppendFormat("\r\n" + "{0}", strTemp);
                strCodeForCs.Append("\r\n" + "                        <div class=\"form-group\">");
                strCodeForCs.Append("\r\n" + "                            <div class=\"col-md-offset-2 col-md-10\">");
                strCodeForCs.Append("\r\n" + "                                <input type=\"submit\" value=\"@btnSaveName\" class=\"btn btn-default\" name=\"btnSave\" id=\"btnSave\" />");
                strCodeForCs.Append("\r\n" + "                                <button class=\"btn btn-default\" data-dismiss=\"modal\">Cancel</button>");
                strCodeForCs.Append("\r\n" + "                            </div>");
                strCodeForCs.Append("\r\n" + "                        </div>");
                strCodeForCs.Append("\r\n" + "                    </div>");
                strCodeForCs.Append("\r\n" + "                </div>");
                strCodeForCs.Append("\r\n" + "            }");
                strCodeForCs.Append("\r\n" + "        </div>");
                strCodeForCs.Append("\r\n" + "    </div>");
                strCodeForCs.Append("\r\n" + "</div>");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }

            return strCodeForCs.ToString();
        }



        /// <summary>
        /// 功能:生成编辑区域
        /// </summary>
        /// <returns></returns>
        public string Gen_MvcView_EditRegionSpa()
        {
            string strFuncName = "";
            if (objViewInfoENEx.arrEditRegionFldSet4InUse == null)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有编辑区域。请检查!", strViewName);
                sbMessage.Append("\r\n当前界面的功能:查询(Q)、修改(U)、删除(D)、添加(I)。");
                throw new clsDbObjException(sbMessage.ToString());
            }
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;

            try
            {
                ///生成插入记录的界面代码;
                strCodeForCs.AppendFormat("\r\n" + "@* 生成的针对Mvc View 的编辑区域 *@");
                strCodeForCs.AppendFormat("\r\n" + "@* 生成函数:{0} *@", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n" + "<div class=\"modal fade\" id=\"divEditDialog_{0}\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"lblDialogTitle_{0}\" aria-hidden=\"true\">",
                    objViewInfoENEx.TabName_In);
                strCodeForCs.Append("\r\n" + "    <div class=\"modal-dialog modal-sm\">");
                strCodeForCs.Append("\r\n" + "        <div class=\"modal-content text-left\" style=\"width: 600px; \">");
                strCodeForCs.Append("\r\n" + "            <div class=\"modal-header\">");
                strCodeForCs.Append("\r\n" + "                <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\"><span aria-hidden=\"true\">×</span></button>");
                strCodeForCs.AppendFormat("\r\n" + "          <h4 class=\"modal-title\" id=\"lblDialogTitle_{1}\">{0}编辑</h4>",
                    objViewInfoENEx.TabCnName,
                    objViewInfoENEx.TabName_In);
                strCodeForCs.Append("\r\n" + "                @Html.ValidationSummary(true, \"\", new { @class = \"text-danger\" })");
                strCodeForCs.Append("\r\n" + "            </div>");


                strCodeForCs.AppendFormat("\r\n" + "      @using (Html.BeginForm(\"Save\", \"{0}\", FormMethod.Post))",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "            {");
                strCodeForCs.Append("\r\n" + "                if (ViewBag.Operate == \"Add\")");
                strCodeForCs.Append("\r\n" + "                {");
                strCodeForCs.Append("\r\n" + "                     @Html.Hidden(\"Operate\", \"Add\")");
                strCodeForCs.Append("\r\n" + "                 }");
                strCodeForCs.Append("\r\n" + "                 else");
                strCodeForCs.Append("\r\n" + "                 {");
                strCodeForCs.Append("\r\n" + "                      @Html.Hidden(\"Operate\", \"Update\")");
                if (objKeyField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    strCodeForCs.AppendFormat("\r\n" + "@Html.Hidden(\"{0}\", @Model.{0})", FldName4Key);
                }
                else
                {
                    //strCodeForCs.AppendFormat("\r\n" + "@Html.Hidden(\"{0}\", @Model.{0})", FldName4Key);
                }
                strCodeForCs.Append("\r\n" + "                 }");


                strCodeForCs.Append("\r\n" + "                @Html.AntiForgeryToken()");
                strCodeForCs.Append("\r\n" + "                <div class=\"modal-body\">");
                strCodeForCs.Append("\r\n" + "                    <div class=\"modal-footer\">");
                string strTemp = Gen_MvcView_CtlViewCodeforTab();
                strCodeForCs.AppendFormat("\r\n" + "{0}", strTemp);
                strCodeForCs.Append("\r\n" + "                        <div class=\"form-group\">");
                strCodeForCs.Append("\r\n" + "                            <div class=\"col-md-offset-2 col-md-10\">");
                strCodeForCs.Append("\r\n" + "                                <input type=\"submit\" value=\"@btnSaveName\" class=\"btn btn-default\" name=\"btnSave\" id=\"btnSave\" />");
                strCodeForCs.Append("\r\n" + "                                <button class=\"btn btn-default\" data-dismiss=\"modal\">Cancel</button>");
                strCodeForCs.Append("\r\n" + "                            </div>");
                strCodeForCs.Append("\r\n" + "                        </div>");
                strCodeForCs.Append("\r\n" + "                    </div>");
                strCodeForCs.Append("\r\n" + "                </div>");
                strCodeForCs.Append("\r\n" + "            }");
                strCodeForCs.Append("\r\n" + "        </div>");
                strCodeForCs.Append("\r\n" + "    </div>");
                strCodeForCs.Append("\r\n" + "</div>");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 功能:生成列表区域
        /// </summary>
        /// <returns></returns>
        public string Gen_MvcView_ListRegion()
        {
            string strFuncName = "";
            if (objViewInfoENEx.arrDGRegionFldSet == null)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有列表区域。请检查!", strViewName);
                sbMessage.Append("\r\n当前界面的功能:查询(Q)、修改(U)、删除(D)、添加(I)。");
                throw new clsDbObjException(sbMessage.ToString());
            }
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;

            try
            {          
                strCodeForCs.AppendFormat("\r\n" + "@* 生成的针对Mvc View 的列表区域 *@");
                strCodeForCs.AppendFormat("\r\n" + "@* 生成函数:{0} *@", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "    <div class=\"panel panel-default\">");
                strCodeForCs.AppendFormat("\r\n" + "        @using (Html.BeginForm(\"Deletes\", \"{0}\", FormMethod.Post))",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "        {");
                strCodeForCs.Append("\r\n" + "            <div class=\"panel-heading\">");
                strCodeForCs.AppendFormat("\r\n" + "                <h3>{0}列表</h3>", objViewInfoENEx.TabCnName);
                strCodeForCs.Append("\r\n" + "            </div>");
                strCodeForCs.Append("\r\n" + "            <div class=\"panel-footer\">");
                strCodeForCs.Append("\r\n" + "                @Html.ActionLink(\"添加\", \"Create\", null,");
                strCodeForCs.Append("\r\n" + "             new { @class = \"btn btn-default\" })");
                strCodeForCs.Append("\r\n" + "                @*@Html.ActionLink(\"删除多条记录\", \"DelRecords\", null,");
                strCodeForCs.Append("\r\n" + "                    new { @class = \"btn btn-default\" })*@");
                strCodeForCs.Append("\r\n" + "                <input type=\"submit\"");
                strCodeForCs.Append("\r\n" + "                       class=\"btn btn-default\"");
                strCodeForCs.Append("\r\n" + "                       value=\"删除多条记录\" />");
                strCodeForCs.Append("\r\n" + "            </div>");
                strCodeForCs.Append("\r\n" + "            <div class=\"panel-body\">");
                string strTemp = Gen_Mvc_DataGrid();
                strCodeForCs.Append("\r\n" + strTemp);
                strCodeForCs.Append("\r\n" + "    </div>");
                strCodeForCs.Append("\r\n" + "        }");
                strCodeForCs.Append("\r\n" + "    </div>");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 功能:生成列表区域
        /// </summary>
        /// <returns></returns>
        public string Gen_MvcView_PartialListAjax()
        {
            string strFuncName = "";
            if (objViewInfoENEx.arrDGRegionFldSet == null)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有列表区域。请检查!", strViewName);
                sbMessage.Append("\r\n当前界面的功能:查询(Q)、修改(U)、删除(D)、添加(I)。");
                throw new clsDbObjException(sbMessage.ToString());
            }
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;

            try
            {
                strCodeForCs.AppendFormat("\r\n" + "@* 生成的针对Mvc ViewLstAjax 的列表区域 *@");
                strCodeForCs.AppendFormat("\r\n" + "@* 生成函数:{0} *@", clsStackTrace.GetCurrClassFunction());
                
                string strTemp = Gen_Mvc_DataGridAjax();
                strCodeForCs.Append("\r\n" + strTemp);
                             
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 功能:生成列表区域
        /// </summary>
        /// <returns></returns>
        public string Gen_MvcView_PartialListSpa()
        {
            string strFuncName = "";
            if (objViewInfoENEx.arrDGRegionFldSet == null)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有列表区域。请检查!", strViewName);
                sbMessage.Append("\r\n当前界面的功能:查询(Q)、修改(U)、删除(D)、添加(I)。");
                throw new clsDbObjException(sbMessage.ToString());
            }
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;

            try
            {
                strCodeForCs.AppendFormat("\r\n" + "@* 生成的针对Mvc ViewLstAjax 的列表区域 *@");
                strCodeForCs.AppendFormat("\r\n" + "@* 生成函数:{0} *@", clsStackTrace.GetCurrClassFunction());

                string strTemp = Gen_Mvc_DataGridAjax();
                strCodeForCs.Append("\r\n" + strTemp);

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }

            return strCodeForCs.ToString();
        }


        /// <summary>
        /// 功能:生成列表区域
        /// </summary>
        /// <returns></returns>
        public string Gen_MvcView_ListRegionAjax()
        {
            string strFuncName = "";
            if (objViewInfoENEx.arrDGRegionFldSet == null)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有列表区域。请检查!", strViewName);
                sbMessage.Append("\r\n当前界面的功能:查询(Q)、修改(U)、删除(D)、添加(I)。");
                throw new clsDbObjException(sbMessage.ToString());
            }
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;

            try
            {
                strCodeForCs.AppendFormat("\r\n" + "@* 生成的针对Mvc View 的列表区域 *@");
                strCodeForCs.AppendFormat("\r\n" + "@* 生成函数:{0} *@", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "    <div class=\"float-left mt-2\"  style=\"width: 100%;\">");
                strCodeForCs.AppendFormat("\r\n" + "        @using (Ajax.BeginForm(\"Command4List\", \"{0}\", new AjaxOptions",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + " {");
                strCodeForCs.Append("\r\n" + " OnSuccess = \"OnSuccessInFeatureRegion\",");
                strCodeForCs.Append("\r\n" + " OnFailure = \"OnFailureInFeatureRegion\""); 
                strCodeForCs.Append("\r\n" + " }))");
                //@using(Ajax.BeginForm("Command4List", "Student", new AjaxOptions
                //{
                //    OnSuccess = "OnSuccess"
                //}))
                strCodeForCs.Append("\r\n" + "        {");
                strCodeForCs.Append("\r\n" + "            <div >");
                //strCodeForCs.AppendFormat("\r\n" + "<ul class=\"nav\">");
                //strCodeForCs.AppendFormat("\r\n" + " <li class=\"nav-item\" style=\"width:250px;\">");
                //strCodeForCs.AppendFormat("\r\n" + "                <span class=\"h6\">{0}列表</span>", objViewInfoENEx.TabCnName);
                //strCodeForCs.Append("\r\n" + "            </li>");
                //strCodeForCs.Append("\r\n" + " <li class=\"nav-item ml-3\">");
                //------panel-footer---------

                //strCodeForCs.Append("\r\n" + "            <div id=\"divFunction\" class=\"panel-footer\">");
                
                strCodeForCs.Append("\r\n" + Gen_MvcView_FeatureRegion());

                strCodeForCs.Append("\r\n" + "            </div>");
                //========panel-footer============

                //------panel-body---------
         
                strCodeForCs.AppendFormat("\r\n" + "    <div id = \"divLstTab_{0}\" class=\"mt-2\">",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "        @Html.Action(\"QueryAjax2\")",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "          </div>");
                //=============panel-body===========

                //------panel-footer---------
                strCodeForCs.Append("\r\n" + "      <div id=\"divLstFooter\" >");
                strCodeForCs.Append("\r\n" + "          @* 这里放列表-脚的相关内容,例如汇总等 *@");
                strCodeForCs.Append("\r\n" + "      </div>");
                //========panel-footer============

                strCodeForCs.Append("\r\n" + "        }");
                strCodeForCs.Append("\r\n" + "    </div>");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }

            return strCodeForCs.ToString();
        }



        /// <summary>
        /// 功能:生成列表区域
        /// </summary>
        /// <returns></returns>
        public string Gen_MvcView_ListRegionSpa()
        {
            string strFuncName = "";
            if (objViewInfoENEx.arrDGRegionFldSet == null)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有列表区域。请检查!", strViewName);
                sbMessage.Append("\r\n当前界面的功能:查询(Q)、修改(U)、删除(D)、添加(I)。");
                throw new clsDbObjException(sbMessage.ToString());
            }
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;

            try
            {
                strCodeForCs.AppendFormat("\r\n" + "@* 生成的针对Mvc View 的列表区域 *@");
                strCodeForCs.AppendFormat("\r\n" + "@* 生成函数:{0} *@", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "    <div class=\"panel panel-default\">");
                strCodeForCs.AppendFormat("\r\n" + "        @using (Html.BeginForm(\"Deletes\", \"{0}\", FormMethod.Post))",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "        {");
                strCodeForCs.Append("\r\n" + "            <div class=\"panel-heading\">");
                strCodeForCs.AppendFormat("\r\n" + "          <h3>{0}列表</h3>", objViewInfoENEx.TabCnName);
                strCodeForCs.Append("\r\n" + "            </div>");

                strCodeForCs.Append("\r\n" + "            <div class=\"panel-footer\">");

                strCodeForCs.Append("\r\n" + "<input type = \"button\" class=\"btn btn-default\" value=\"添加记录\" onclick=\"AddRec()\" />");

                strCodeForCs.Append("\r\n" + "                @*@Html.ActionLink(\"删除多条记录\", \"DelRecords\", null,");
                strCodeForCs.Append("\r\n" + "                    new { @class = \"btn btn-default\" })*@");
                strCodeForCs.Append("\r\n" + "                <input type=\"submit\"");
                strCodeForCs.Append("\r\n" + "                       class=\"btn btn-default\"");
                strCodeForCs.Append("\r\n" + "                       value=\"删除多条记录\" />");
                strCodeForCs.Append("\r\n" + "            </div>");
                strCodeForCs.Append("\r\n" + "            <div class=\"panel-body\">");
                strCodeForCs.AppendFormat("\r\n" + "<div id = \"divLstTab_{0}\">",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "@Html.Action(\"QueryAjax\")",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "</div>");
                strCodeForCs.Append("\r\n" + "</div>");


                strCodeForCs.Append("\r\n" + "        }");
                strCodeForCs.Append("\r\n" + "    </div>");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }

            return strCodeForCs.ToString();
        }
              

        #region 生成单个控件的生成函数


        public string Gen_Mvc_DataGrid()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //int iDGHeight;      //DataGrid的高度
           
           
            try
            {
                ///生成插入记录的界面代码;
                //objViewInfoENEx.objViewRegion_List.StyleZindex() = intZIndex + 1;
                //objViewInfoENEx.objViewRegion_List.StyleLeft = (int)intCurrLeft;
                //objViewInfoENEx.objViewRegion_List.StyleTop = (int)intCurrTop;

                //iDGHeight = objViewInfoENEx.objViewRegion_List.Height + 50;
               

                strCodeForCs.Append("\r\n" + "                <table class=\"table table-striped table-condensed table-bordered\">");
                strCodeForCs.Append("\r\n" + "                    <tr>");
                strCodeForCs.Append("\r\n" + "                        <th>");
                strCodeForCs.Append("\r\n" + "                            <label class=\"mt-checkbox mt-checkbox-single mt-checkbox-outline\">");
                strCodeForCs.Append("\r\n" + "                                <input id=\"btnCheckAll\" type=\"checkbox\" class=\"group-checkable\" data-set=\"#MyTable.checkboxes\" onchange=\"CheckAllHandler()\" />");
                strCodeForCs.Append("\r\n" + "                                <span></span>");
                strCodeForCs.Append("\r\n" + "                            </label>");
                strCodeForCs.Append("\r\n" + "                        </th>");
                foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
                {
                    string strFldName = objDGRegionFldsEx.ObjFieldTabENEx.FldName;
                    string strCaption = objDGRegionFldsEx.HeaderText;

                    strCodeForCs.Append("\r\n" + " <th class=\"text-left\">");
                    strCodeForCs.AppendFormat("\r\n" + "  @Html.ActionLink(\"{0}\", \"{2}_SortList\", new {{ sortOrder = ViewBag.{1}SortParm }})",
                        strCaption, strFldName, objViewInfoENEx.TabName_Out);
                    strCodeForCs.Append("\r\n" + " </th>");
                }
                strCodeForCs.Append("\r\n" + "                        <th class=\"text-center\">修改</th>");
                strCodeForCs.Append("\r\n" + "                        <th class=\"text-center\">删除</th>");
                strCodeForCs.Append("\r\n" + "                    </tr>");

                string strSortExpression;

                strCodeForCs.AppendFormat("\r\n" + " @foreach (cls{0}EN item in Model.{0}Lst)", 
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + " {");
                strCodeForCs.Append("\r\n" + " <tr>");
                //if (objViewInfoENEx.objViewRegion_List.IsRadio() == true)    //判断是否需要单选按钮
                //{
                //    strCodeForCs.Append("\r\n" + "  <td>");
                //    strCodeForCs.Append("\r\n" + "     <label class=\"mt-checkbox mt-checkbox-single mt-checkbox-outline\">");
                //    strCodeForCs.AppendFormat("\r\n" + "     <input type=\"checkbox\" class=\"checkboxes\" value=\"@item.{0}\" checked=\"@item._Checked\" id=\"checkedId\" name =\"checkedId\" />",
                //        objKeyField.FldName);
                //    strCodeForCs.Append("\r\n" + "     <span></span>");
                //    strCodeForCs.Append("\r\n" + "     </label>");
                //    strCodeForCs.Append("\r\n" + "  </td>");
                //}
                //if (objViewInfoENEx.objViewRegion_List.IsCheck() == true)    //判断是否需要复选按钮
                //{
                    strCodeForCs.Append("\r\n" + "   <td>");
                    strCodeForCs.Append("\r\n" + "       <label class=\"mt-checkbox mt-checkbox-single mt-checkbox-outline\">");
                    strCodeForCs.AppendFormat("\r\n" + "           <input type=\"checkbox\" class=\"checkboxes\" value=\"@item.{0}\" checked=\"@item._Checked\" id=\"checkedId\" name =\"checkedId\" />",
                        objKeyField.FldName);
                    strCodeForCs.Append("\r\n" + "           <span></span>");
                    strCodeForCs.Append("\r\n" + "       </label>");
                    strCodeForCs.Append("\r\n" + "  </td>");
                //}
            
                foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
                {
                    string strFldName = objDGRegionFldsEx.ObjFieldTabENEx.FldName;
                    if (objDGRegionFldsEx.IsNeedSort)   //判断是否需要排序
                    {
                        strSortExpression = "SortExpression = \"" + objDGRegionFldsEx.ObjFieldTabENEx.FldName + "\"";
                    }
                    else
                    {
                        strSortExpression = "";
                    }
                    strCodeForCs.AppendFormat("\r\n" + "   <td class=\"text-left\">@item.{0}</td>",
                        strFldName);
                }
                //if (objViewInfoENEx.objViewRegion_List.IsHaveUpdBtn() == true)   //在DG中是否有修改按钮
                //{
                    strCodeForCs.Append("\r\n" + "   <td class=\"text-center\">");
                    strCodeForCs.AppendFormat("\r\n" + "      @Html.ActionLink(\"修改\", \"Update\", \"{0}\", new {{ {1} = @item.{1} }}, new {{ @class = \"btn btn-default\" }})",
                        objMainPrjTab.TabName, objKeyField.FldName);
                    strCodeForCs.Append("\r\n" + "   </td>");
                //}
                //if (objViewInfoENEx.objViewRegion_List.IsHaveDelBtn() == true)   //在DG中是否有删除按钮
                //{
                    strCodeForCs.Append("\r\n" + "   <td class=\"text-center\">");
                    strCodeForCs.AppendFormat("\r\n" + "      @Html.ActionLink(\"删除\", \"Delete\", \"{0}\", new {{ {1} = @item.{1} }}, new {{ @class = \"btn btn-default\" }})",
                        objMainPrjTab.TabName, objKeyField.FldName);
                    strCodeForCs.Append("\r\n" + "   </td>");
                //}
                //if (objViewInfoENEx.objViewRegion_List.IsHaveDetailBtn() == true) //在DG中是否有详细信息按钮
                //{
                    strCodeForCs.Append("\r\n" + "   <td class=\"text-center\">");
                    strCodeForCs.AppendFormat("\r\n" + "      @Html.ActionLink(\"详细信息\", \"Detail\", \"{0}\", new {{ {1} = @item.{1} }}, new {{ @class = \"btn btn-default\" }})",
                        objMainPrjTab.TabName, objKeyField.FldName);
                    strCodeForCs.Append("\r\n" + "   </td>");
                //}
                strCodeForCs.Append("\r\n" + "  </tr>");
                strCodeForCs.Append("\r\n" + "  }");
                strCodeForCs.Append("\r\n" + " </table>");
                //strCodeForCs.Append("\r\n" + "</div>");
                //if (objViewInfoENEx.objViewRegion_List.IsJumpPage() == true)
                //{
                    strCodeForCs.Append("\r\n" + " <div class=\"btn-group pull-right\">");
                    strCodeForCs.AppendFormat("\r\n" + "   @Html.PageLinksV2(Model.PagingInfo, x => Url.Action(\"{0}_Pager\", new {{ page = x }}))",
                        objViewInfoENEx.TabName_Out);
                    strCodeForCs.Append("\r\n" + " </div>");

                    //intZIndex += objViewInfoENEx.objViewRegion_List.StyleZindex() + 1;
                    //intCurrTop += objViewInfoENEx.objViewRegion_List.Height + 5;
                    intCurrLeft = 10;
                //}
                
       
                intCurrTop += 45;

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_Mvc_DataGridAjax()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //int iDGHeight;      //DataGrid的高度

            try
            {
                ///生成插入记录的界面代码;
                //objViewInfoENEx.objViewRegion_List.StyleZindex() = intZIndex + 1;
                //objViewInfoENEx.objViewRegion_List.StyleLeft = (int)intCurrLeft;
                //objViewInfoENEx.objViewRegion_List.StyleTop = (int)intCurrTop;

                //iDGHeight = objViewInfoENEx.objViewRegion_List.Height + 50;

                strCodeForCs.Append("\r\n" + "                @Html.ValidationSummary(true, \"\", new { @class = \"text-danger\" })");

                strCodeForCs.Append("\r\n" + "                <table class=\"table table-striped table-condensed table-bordered\">");
                strCodeForCs.Append("\r\n" + "                    <tr>");
                strCodeForCs.Append("\r\n" + "                        <th>");
                strCodeForCs.Append("\r\n" + "                            <label class=\"mt-checkbox mt-checkbox-single mt-checkbox-outline\">");
                strCodeForCs.Append("\r\n" + "                                <input id=\"btnCheckAll\" type=\"checkbox\" class=\"group-checkable\" data-set=\"#MyTable.checkboxes\" onchange=\"CheckAllHandler()\" />");
                strCodeForCs.Append("\r\n" + "                                <span></span>");
                strCodeForCs.Append("\r\n" + "                            </label>");
                strCodeForCs.Append("\r\n" + "                        </th>");
                foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
                {
                    string strFldName = objDGRegionFldsEx.ObjFieldTabENEx.FldName;
                    string strCaption = objDGRegionFldsEx.HeaderText;

                    strCodeForCs.Append("\r\n" + " <th class=\"text-left\">");
                    strCodeForCs.AppendFormat("\r\n" + "  @Ajax.ActionLink(\"{0}\", \"SortListAjax\", new {{ sortOrder = ViewBag.{1}SortParm }}, ",
                        strCaption, strFldName, objViewInfoENEx.TabName_Out);
                    strCodeForCs.AppendFormat("\r\n" + "                new AjaxOptions {{ Url = Url.Action(\"SortListAjax\", new {{ sortOrder = ViewBag.{1}SortParm }}), UpdateTargetId = \"divLstTab_{2}\" }})",
                        strCaption, strFldName, objViewInfoENEx.TabName_Out);
                    strCodeForCs.Append("\r\n" + " </th>");
                }
                strCodeForCs.Append("\r\n" + "                        <th class=\"text-center\">修改</th>");
                strCodeForCs.Append("\r\n" + "                        <th class=\"text-center\">删除</th>");
                strCodeForCs.Append("\r\n" + "                    </tr>");

                string strSortExpression;

                strCodeForCs.AppendFormat("\r\n" + " @foreach (cls{0}EN item in Model.{0}Lst)",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + " {");
                strCodeForCs.Append("\r\n" + " <tr>");
                //if (objViewInfoENEx.objViewRegion_List.IsRadio() == true)    //判断是否需要单选按钮
                //{
                //    strCodeForCs.Append("\r\n" + "  <td>");
                //    strCodeForCs.Append("\r\n" + "     <label class=\"mt-checkbox mt-checkbox-single mt-checkbox-outline\">");
                //    strCodeForCs.AppendFormat("\r\n" + "     <input type=\"checkbox\" class=\"checkboxes\" value=\"@item.{0}\" checked=\"@item._Checked\" id=\"checkedId\" name =\"checkedId\" />",
                //        objKeyField.FldName);
                //    strCodeForCs.Append("\r\n" + "     <span></span>");
                //    strCodeForCs.Append("\r\n" + "     </label>");
                //    strCodeForCs.Append("\r\n" + "  </td>");
                //}
                //if (objViewInfoENEx.objViewRegion_List.IsCheck() == true)    //判断是否需要复选按钮
                //{
                    strCodeForCs.Append("\r\n" + "   <td>");
                    strCodeForCs.Append("\r\n" + "       <label class=\"mt-checkbox mt-checkbox-single mt-checkbox-outline\">");
                    strCodeForCs.AppendFormat("\r\n" + "           <input type=\"checkbox\" class=\"checkboxes\" value=\"@item.{0}\" checked=\"@item._Checked\" id=\"checkedId\" name =\"checkedId\" />",
                        objKeyField.FldName);
                    strCodeForCs.Append("\r\n" + "           <span></span>");
                    strCodeForCs.Append("\r\n" + "       </label>");
                    strCodeForCs.Append("\r\n" + "  </td>");
                //}

                foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
                {
                    string strFldName = objDGRegionFldsEx.ObjFieldTabENEx.FldName;
                    if (objDGRegionFldsEx.IsNeedSort)   //判断是否需要排序
                    {
                        strSortExpression = "SortExpression = \"" + objDGRegionFldsEx.ObjFieldTabENEx.FldName + "\"";
                    }
                    else
                    {
                        strSortExpression = "";
                    }
                    strCodeForCs.AppendFormat("\r\n" + "   <td class=\"text-left\">@item.{0}</td>",
                        strFldName);
                }
                //if (objViewInfoENEx.objViewRegion_List.IsHaveUpdBtn() == true)   //在DG中是否有修改按钮
                //{
                    strCodeForCs.Append("\r\n" + "   <td class=\"text-center\">");
                    strCodeForCs.AppendFormat("\r\n" + "      @Ajax.ActionLink(\"修改\", \"GetObjBy{1}\", \"{0}\", new {{ {1} = @item.{1} }}, new AjaxOptions {{  Url = Url.Action(\"GetJsonObjBy{1}\", new {{ {1} = @item.{1} }}), OnSuccess=\"UpdateRec\" }}, new {{ @class = \"btn btn-default\" }})",
                        objMainPrjTab.TabName, objKeyField.FldName);
                    strCodeForCs.Append("\r\n" + "   </td>");
                //}
                //if (objViewInfoENEx.objViewRegion_List.IsHaveDelBtn() == true)   //在DG中是否有删除按钮
                //{
                    strCodeForCs.Append("\r\n" + "   <td class=\"text-center\">");
                    strCodeForCs.AppendFormat("\r\n" + "      @Html.ActionLink(\"删除\", \"Delete\", \"{0}\", new {{ {1} = @item.{1} }}, new {{ @class = \"btn btn-default\" }})",
                        objMainPrjTab.TabName, objKeyField.FldName);
                    strCodeForCs.Append("\r\n" + "   </td>");
                //}
                //if (objViewInfoENEx.objViewRegion_List.IsHaveDetailBtn() == true) //在DG中是否有详细信息按钮
                //{
                    strCodeForCs.Append("\r\n" + "   <td class=\"text-center\">");
                    strCodeForCs.AppendFormat("\r\n" + "      @Html.ActionLink(\"详细信息\", \"Detail\", \"{0}\", new {{ {1} = @item.{1} }}, new {{ @class = \"btn btn-default\" }})",
                        objMainPrjTab.TabName, objKeyField.FldName);
                    strCodeForCs.Append("\r\n" + "   </td>");
                //}
                strCodeForCs.Append("\r\n" + "  </tr>");
                strCodeForCs.Append("\r\n" + "  }");
                strCodeForCs.Append("\r\n" + " </table>");
                //strCodeForCs.Append("\r\n" + "</div>");
                //if (objViewInfoENEx.objViewRegion_List.IsJumpPage() == true)
                //{
                    strCodeForCs.Append("\r\n" + " <div class=\"btn-group pull-right\">");
                    strCodeForCs.Append("\r\n" + "   @Ajax.PageLinksAjax(Model.PagingInfo,");
                    strCodeForCs.AppendFormat("\r\n" + "       x => Url.Action(\"PagerAjax\", new {{ page = x }}), ",
                        objViewInfoENEx.TabName_Out);
                    strCodeForCs.AppendFormat("\r\n" + "        new AjaxOptions {{ Url = Url.Action(\"PagerAjax\"), UpdateTargetId = \"divLstTab_{0}\" }})",
                        objViewInfoENEx.TabName_Out);

                    strCodeForCs.Append("\r\n" + " </div>");

                    //intZIndex += objViewInfoENEx.objViewRegion_List.StyleZindex() + 1;
                    //intCurrTop += objViewInfoENEx.objViewRegion_List.Height + 5;
                    intCurrLeft = 10;
                //}
               

                intCurrTop += 45;

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }
        public string Gen_MvcView_FeatureRegion()
        {
            string strFuncName = "";
            string lngRegionId = "";
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //int iDGHeight;      //DataGrid的高度
            //int iDG_Div_Left;
            
            try
            {
                ///生成插入记录的界面代码;
      

                //strCodeForCs.AppendFormat("\r\n" + "<div id = \"divFunction\" class = \"div_Funttion\" runat = \"server\">",
                //  objViewInfoENEx.TabName, intCurrTop);
                //ASPDivEx objASPDivENEx_Function = clsASPDivBLEx.GetEmptyDiv();
                //objASPDivENEx_Function.Class = "table table-bordered table-hover";
                ////objASPDivENEx_Function.Runat = "server";
                //objASPDivENEx_Function.CtrlId = "divFunction";
                IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFldsObjLst = objViewInfoENEx.arrFeatureRegionFlds;
                if (objViewInfoENEx.arrFeatureRegionFlds == null)
                {
                    string strMsg = string.Format("界面功能区为空,请添加界面功能!界面:{0}. (In {1})", objViewInfoENEx.ViewName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);

                }
                IEnumerable<clsViewRegionENEx> arrViewRegion = objViewInfoENEx.arrViewRegion
                    .Where(x => x.RegionTypeId == enumRegionType.FeatureRegion_0008);
                if (arrViewRegion.Count() == 0)
                {
                    string strMsg = string.Format("界面功能区为空,请添加界面功能!界面:{0}. (In {1})", objViewInfoENEx.ViewName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);

                }
                lngRegionId = arrViewRegion.First().RegionId;

                IEnumerable<ASPControlEx> arrControls = clsFeatureRegionFldsBLEx.GetControlLst4Regoin(lngRegionId, enumViewImplementation.FunctionRegion_0001, objViewInfoENEx, "Item2");

                List<ASPControlGroupEx> arrControlGroupLst = arrControls
                    .OrderBy(x => x.OrderNum)
                    .Select(clsASPControlGroupBLEx.GetControlGroup).OrderBy(x => x.GroupName).ToList();


                //IEnumerable<ASPButtonEx> arrButtonLst = objViewInfoENEx.arrFeatureRegionFlds.Where(x => x.ViewImplId == enumViewImplementation.FunctionRegion_0001).Select(clsASPButtonBLEx.GetButton4MvcAjax);
                IEnumerable<ASPControlGroupEx> arrControlGroupLst_New = clsASPControlGroupBLEx.MergeControlGroup(arrControlGroupLst);



                //添加层div
                ASPUlEx objASPUlENEx = clsASPUlBLEx.GetEmptyUl();
                objASPUlENEx.Class = "nav";
                //objASPDivENEx_Function.arrSubAspControlLst2.Add(objASPUlENEx);

                ASPLiEx objASPLiENEx = clsASPLiBLEx.GetEmptyLi();
                objASPLiENEx.Class = "nav-item";
                objASPLiENEx.Style = "width:250px;";

                objASPUlENEx.arrSubAspControlLst2.Add(objASPLiENEx);
                //列表标题
                ASPSpanEx objASPSpanENEx = clsASPSpanBLEx.GetDataListTitle(objViewInfoENEx.TabName, objViewInfoENEx.TabCnName);
                objASPLiENEx.arrSubAspControlLst2.Add(objASPSpanENEx);
                
                Action<ASPButtonEx> AddToLi = (x) =>
                {
                    objASPLiENEx = clsASPLiBLEx.GetEmptyLi();
                    objASPLiENEx.Class = "nav-item ml-3";
                    ASPButtonEx objASPNETButtonENEx = clsASPButtonBLEx.GetbtnAddNewRec4Gv();
                    objASPLiENEx.arrSubAspControlLst2.Add(x);
                    objASPUlENEx.arrSubAspControlLst2.Add(objASPLiENEx);
                };

                foreach (ASPControlGroupEx objInFor in arrControlGroupLst_New)
                {
                    objASPLiENEx = clsASPLiBLEx.GetEmptyLi();
                    objASPLiENEx.Class = "nav-item ml-3";
                    //ASPButtonEx objASPNETButtonENEx = clsASPButtonBLEx.GetbtnAddNewRec4Gv();
                    objASPLiENEx.arrSubAspControlLst2.Add(objInFor);
                    objASPUlENEx.arrSubAspControlLst2.Add(objASPLiENEx);
                }

                objASPLiENEx = clsASPLiBLEx.GetEmptyLi();
                objASPLiENEx.Class = "nav-item ml-3";          

                objASPUlENEx.arrSubAspControlLst2.Add(objASPLiENEx);
                //列表标题
                ASPSpanEx objASPSpanENEx_Msg = clsASPSpanBLEx.GetDataListMsg("");
                objASPLiENEx.arrSubAspControlLst2.Add(objASPSpanENEx_Msg);


                objASPUlENEx.GeneCode4Mvc(strCodeForCs);
                intCurrTop += 45;

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        public string GenButtonGroupInQuery()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //int iDGHeight;      //DataGrid的高度

            try
            {

                //< div class="row">
                //       <div class="col-md-6">
                //           @Html.ValidationSummary(true, "", new { @class = "text-danger" })
                //       </div>
                //       <div class="col-md-offset-1 col-md-1">
                //           <input value = "查询" id="btnQuery" Name="action:QueryAjax" type="submit" class="btn btn-default" onclick="OnClickInFeatureRegion()" />
                //       </div>
                //       <div class="col-md-1">
                //           <input value = "导出" id="btnExportExcel" Name="action:ExportExcelAjax" type="submit" class="btn btn-default" onclick="OnClickInFeatureRegion()" />
                //       </div>
                //       <div class="col-md-1">
                //           <span id = "spnExportExcel" ></ span >
                //       </ div >

                //   </ div >
                ASPUlEx objASPNETUlENEx = new ASPUlEx();
                objASPNETUlENEx.Class = "nav";
                //{
                //    ASPDivEx objASPNETDivENEx_6 = new ASPDivEx();
                //    objASPNETDivENEx_6.Class = "col-md-6";
                //    ASPCodeEx objASPNETCodeENEx = new ASPCodeEx();
                //    objASPNETCodeENEx.codeText = "@Html.ValidationSummary(true, \"\", new { @class = \"text-danger\" })";
                //    objASPNETDivENEx_6.arrSubAspControlLst2.Add(objASPNETCodeENEx);
                //    objASPNETDivENEx_Row.arrSubAspControlLst2.Add(objASPNETDivENEx_6);
                //}
                {
                    ASPLiEx objASPNETLiENEx_1_1 = new ASPLiEx();
                    objASPNETLiENEx_1_1.Class = "nav-item";
                    ASPButtonEx objASPNETButtonENEx_Query = clsASPButtonBLEx.GetbtnQuery(true, true);
                    objASPNETLiENEx_1_1.arrSubAspControlLst2.Add(objASPNETButtonENEx_Query);
                    objASPNETUlENEx.arrSubAspControlLst2.Add(objASPNETLiENEx_1_1);
                }
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveExcelExport == true)
                {

                    ASPLiEx objASPNETLiENEx_1_2 = new ASPLiEx();
                    objASPNETLiENEx_1_2.Class = "nav-item ml-3";
                    ASPButtonEx objASPNETButtonENEx = clsASPButtonBLEx.GetbtnExportExcel4Gv(true, true);
                    objASPNETLiENEx_1_2.arrSubAspControlLst2.Add(objASPNETButtonENEx);

                    objASPNETUlENEx.arrSubAspControlLst2.Add(objASPNETLiENEx_1_2);
                }
               
                {

                    ASPLiEx objASPNETLiENEx_1_2 = new ASPLiEx();
                    objASPNETLiENEx_1_2.Class = "nav-item ml-3";
                    ASPCodeEx objASPCodeENEx = new ASPCodeEx();
                    objASPCodeENEx.CodeText = " @Html.ValidationSummary(true, \"\", new { @class = \"text-danger\" })";
                    
                    objASPNETLiENEx_1_2.arrSubAspControlLst2.Add(objASPCodeENEx);

                    objASPNETUlENEx.arrSubAspControlLst2.Add(objASPNETLiENEx_1_2);
                }


               

                {
                    ASPLiEx objASPNETLiENEx_1_3 = new ASPLiEx();

                    ASPSpanEx objASPNETSpanENEx = clsASPSpanBLEx.GetspnExportExcel(true);
                    objASPNETLiENEx_1_3.arrSubAspControlLst2.Add(objASPNETSpanENEx);
                    objASPNETUlENEx.arrSubAspControlLst2.Add(objASPNETLiENEx_1_3);
                }
                  
                   
                    if (objViewInfoENEx.IsNeedSetExportFld == true &&
      objViewInfoENEx.objViewTypeCodeTab.IsHaveSetExportExcel == true)
                    {
                    ASPLiEx objASPNETLiENEx_1_4 = new ASPLiEx();
                    ASPButtonEx objASPNETButtonENEx = clsASPButtonBLEx.GetbtnSetExportExcel4User(true, true);
                    objASPNETLiENEx_1_4.arrSubAspControlLst2.Add(objASPNETButtonENEx);

                    objASPNETUlENEx.arrSubAspControlLst2.Add(objASPNETLiENEx_1_4);
                    }

                objASPNETUlENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
                
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_ValidationSummary()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //int iDGHeight;      //DataGrid的高度

            try
            {

                ASPCodeEx objASPCodeENEx = new ASPCodeEx();
                objASPCodeENEx.CodeText = " @Html.ValidationSummary(true, \"\", new { @class = \"text-danger\" })";


                objASPCodeENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 生成CheckBox控件
        /// </summary>
        /// <param name = "objCheckStyle"></param>
        /// <returns></returns>
        public string GenCheckBoxNoPosition(clsCheckStyleEN objCheckStyle, string strCheckId, string strCheckText)
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp;     ///临时变量;
            try
            {
                objCheckStyle.StyleZindex = intZIndex + 1;
                objCheckStyle.StyleLeft = (int)intCurrLeft;
                objCheckStyle.StyleTop = (int)intCurrTop;

                ///生成CheckBox的代码;
                ///
                //生成控件的<开始标志>和<ID>
                strCodeForCs.Append("\r\n" + "<td>");
                strCodeForCs.AppendFormat("\r\n" + "<asp:CheckBox id = \"{0}\" ",
                  strCheckId);
                //生成<控件样式Style>
                //生成<高度>和<宽度>
                strCodeForCs.AppendFormat("\r\n" + "style = \"z-index: {0}; Width:{1}px; Height:{2}px;\" ",
                  objCheckStyle.StyleZindex,
                  objCheckStyle.Width, objCheckStyle.Height);
                //生成运行模式是否在服务器运行
                strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" ",
                  objCheckStyle.Runat);

                //生成<字号>和<字体>
                //strCodeForCs.AppendFormat("\r\n" + "Font-Size = \"{0}\" Font-Names = \"{1}\" ", 
                //  objCheckStyle.FontSize, objCheckStyle.FontName);
                //生成<显示文本> 
                strCodeForCs.AppendFormat("\r\n" + "Text = \"{0}\" ", strCheckText);

                //生成<结束标志>
                strCodeForCs.Append("\r\n" + "CssClass = \"Check_Defa\"></asp:CheckBox>");

                strCodeForCs.Append("\r\n" + "</td>");

                intZIndex += 1;

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

      
        /// <summary>
        /// 生成Button控件
        /// </summary>
        /// <param name = "objCheckStyle"></param>
        /// <returns></returns>
        public string Gen_Mvc_ButtonInForm(clsButtonStyleEN objButtonStyle, string strButtonId,
            string strButtonText, string strOnClick = "")
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp;     ///临时变量;
            try
            {
                objButtonStyle.StyleZindex = intZIndex + 1;
                objButtonStyle.StyleLeft = (int)intCurrLeft;
                objButtonStyle.StyleTop = (int)intCurrTop;

                ///生成Button的代码;
                ///   <td>
                //    < input type = "submit" value = "查询" class="btn btn-default" />
                //</td>

                //<td>
                //    <a href = "javascript:void(0);" class="easyui-linkbutton" data-options="iconCls:'icon-clear' " onclick="resetSearch()">清空</a>
                //</td>
                //生成控件的<开始标志>和<ID>
                strCodeForCs.AppendFormat("\r\n" + "<input id = \"{0}\"  type=\"submit\" ",
                  strButtonId);
               
                strCodeForCs.AppendFormat("\r\n" + "value = \"{0}\" class = \"btn btn-default\" ", strButtonText);
                //生成单击事件
                if (string.IsNullOrEmpty(strOnClick) == false)
                {
                    strCodeForCs.AppendFormat("\r\n" + "OnClick = \"{0}\" ", strOnClick);
                }
                //生成<结束标志>
                strCodeForCs.Append("\r\n" + "/>");

                intZIndex += 1;

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 生成DropDownList控件
        /// </summary>
        /// <param name = "objCheckStyle"></param>
        /// <returns></returns>
        public string GenDropDownLst(clsDropDownLstStyleEN objDropDownLstStyle, string strDropDownLstId)
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp;     ///临时变量;
            try
            {
                objDropDownLstStyle.StyleZindex = intZIndex + 1;
                objDropDownLstStyle.StyleLeft = (int)intCurrLeft;
                objDropDownLstStyle.StyleTop = (int)intCurrTop;

                ///生成DropDownList的代码;

                //生成控件的<开始标志>和<ID>
                strCodeForCs.AppendFormat("\r\n" + "<asp:DropDownList id = \"{0}\" ",
                  strDropDownLstId);
                //生成<控件样式Style>
                strCodeForCs.AppendFormat("\r\n" + "style = \"z-index: {0}; left: {1}px; ",
                  objDropDownLstStyle.StyleZindex, objDropDownLstStyle.StyleLeft);
                //生成<高度>和<宽度>
                strCodeForCs.AppendFormat("\r\n" + "position: {0}; top: {1}px; Width:{2}px; Height:{3}px;\" ",
                  objDropDownLstStyle.StylePosition, objDropDownLstStyle.StyleTop,
                  objDropDownLstStyle.Width, objDropDownLstStyle.Height);

                //生成运行模式是否在服务器运行
                strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" ",
                  objDropDownLstStyle.Runat);

                //生成<字号>和<字体>
                strCodeForCs.AppendFormat("\r\n" + "Font-Size = \"{0}\" Font-Names = \"{1}\" ",
                  objDropDownLstStyle.FontSize, objDropDownLstStyle.FontName);
                //生成<前景色>
                if (objDropDownLstStyle.ForeColor != "")
                {
                    strCodeForCs.AppendFormat("\r\n" + "ForeColor = \"{0}\" ", objDropDownLstStyle.ForeColor);
                }
                //生成<背景色>
                if (objDropDownLstStyle.BackColor != "")
                {
                    strCodeForCs.AppendFormat("\r\n" + "BackColor = \"{0}\" ", objDropDownLstStyle.BackColor);
                }
                //生成<文本字段>
                if (objDropDownLstStyle.DataTextField != "")
                {
                    strCodeForCs.AppendFormat("\r\n" + "DataTextField = \"{0}\" ", objDropDownLstStyle.DataTextField);
                }
                //生成<值字段>
                if (objDropDownLstStyle.DataValueField != "")
                {
                    strCodeForCs.AppendFormat("\r\n" + "DataValueField = \"{0}\" ", objDropDownLstStyle.DataValueField);
                }
                //生成<是否可见>
                if (objDropDownLstStyle.Visible == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "Visible = \"{0}\" ", objDropDownLstStyle.Visible);
                }

                //生成<结束标志>
                strCodeForCs.Append("\r\n" + "></asp:DropDownList>");

                intZIndex += 1;

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 生成{组合控件},即左边的标签,和右边的输入条件的控件
        /// </summary>
        /// <param name = "objLabelStyle"></param>
        /// <param name = "strLabelId"></param>
        /// <param name = "strLabelText"></param>
        /// <param name = "objGenCtlStyle"></param>
        /// <param name = "strCtlTypeName"></param>
        /// <param name = "strCtlId"></param>
        /// <returns></returns>
        public string GenCombineCtl(clsLabelStyleEN objLabelStyle, string strLabelId, string strLabelText,
          clsGenCtlStyleEN objGenCtlStyle, string strCtlTypeName, string strCtlId)
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp;     ///临时变量;
            objLabelStyle.StyleZindex = intZIndex + 1;
            objLabelStyle.StyleLeft = (int)intCurrLeft;
            objLabelStyle.StyleTop = (int)intCurrTop;
            ///生成Label的代码;
            strCodeForCs.AppendFormat("\r\n" + "<asp:Label id = \"{0}\" style = \"z-index: {1}; left: {2}px; position: absolute; top: {4}px; Width:{5}px; Height:{6}px;\" ",
              strLabelId, objLabelStyle.StyleZindex, objLabelStyle.StyleLeft, objLabelStyle.StylePosition, objLabelStyle.StyleTop, objLabelStyle.Width, objLabelStyle.Height);
            strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" CssClass = \"NameLabel\">",
              objLabelStyle.Runat);
            strCodeForCs.AppendFormat("{0}</asp:Label>",
              strLabelText);

            intZIndex += 1;

            objGenCtlStyle.StyleZindex = intZIndex + 1;
            objGenCtlStyle.StyleLeft = (int)intCurrLeft + objLabelStyle.Width + 5;
            //objGenCtlStyle.StyleLeft = (int)intCurrLeft + 5;
            objGenCtlStyle.StyleTop = (int)intCurrTop;
            ///生成右边控件的代码;

            strCodeForCs.AppendFormat("\r\n" + "<asp:{0} id = \"{1}\" style = \"z-index: {2}; left: {3}px; ",
              strCtlTypeName, strCtlId, objGenCtlStyle.StyleZindex, objGenCtlStyle.StyleLeft);
            strCodeForCs.AppendFormat("\r\n" + "position: absolute; top: {1}px; Width:{2}px; Height:{3}px;\" ",
              objGenCtlStyle.StylePosition, objGenCtlStyle.StyleTop, objGenCtlStyle.Width, objGenCtlStyle.Height);

            strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" CssClass = \"TextBox_Defa\">",
              objGenCtlStyle.Runat);
            strCodeForCs.AppendFormat("\r\n" + "</asp:{0}>",
              strCtlTypeName);
            intZIndex += 1;
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 生成{组合控件},即左边的标签,和右边的输入条件的控件
        /// </summary>
        /// <param name = "objLabelStyle"></param>
        /// <param name = "strLabelId"></param>
        /// <param name = "strLabelText"></param>
        /// <param name = "objGenCtlStyle"></param>
        /// <param name = "strCtlTypeName"></param>
        /// <param name = "strCtlId"></param>
        /// <returns></returns>
        public string Gen_Mvc_CombineCtlWithFor(clsLabelStyleEN objLabelStyle, string strFldName, string strLabelId, string strLabelText,
          clsGenCtlStyleEN objGenCtlStyle, string strCtlTypeName, string strCtlId, string strDsTabId, string strDdlItemsOptionId)
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp;     ///临时变量;
            try
            {
                objLabelStyle.StyleZindex = intZIndex + 1;
                objLabelStyle.StyleLeft = (int)intCurrLeft;
                objLabelStyle.StyleTop = (int)intCurrTop;
                ///生成Label的代码;

                strCodeForCs.Append("\r\n" + "<td>");
                strCodeForCs.AppendFormat("\r\n" + "@Html.LabelFor(model => model.{1}, htmlAttributes: new {{ @class = \"col-form-label text-right\", style = \"width:100px\" }})",
                    objViewInfoENEx.TabName_Out, strFldName);

                //strCodeForCs.AppendFormat("\r\n" + "<asp:Label id = \"{0}\" style = \"z-index: {1};\" ",
                //  strLabelId, objLabelStyle.StyleZindex, objLabelStyle.Width, objLabelStyle.Height);
                //strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" CssClass = \"NameLabel\">",
                //  objLabelStyle.Runat);
                //strCodeForCs.AppendFormat("{0}</asp:Label>",
                //  strLabelText);
                strCodeForCs.Append("\r\n" + "</td>");

                intZIndex += 1;

                objGenCtlStyle.StyleZindex = intZIndex + 1;
                objGenCtlStyle.StyleLeft = (int)intCurrLeft + objLabelStyle.Width + 5;
                //objGenCtlStyle.StyleLeft = (int)intCurrLeft + 5;
                objGenCtlStyle.StyleTop = (int)intCurrTop;
                ///生成右边控件的代码;
                strCodeForCs.Append("\r\n" + "<td>");
                switch (strCtlTypeName)
                {
                    case "TextBox":
                strCodeForCs.AppendFormat("\r\n" + "@Html.EditorFor(model => model.{1}, new {{ htmlAttributes = new {{ @class = \"form-control\" }} }})",
                    objViewInfoENEx.TabName_Out, strFldName);
                        break;
                    case "DropDownList":
                        if (strDdlItemsOptionId == enumDDLItemsOption.TrueAndFalseList_04)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "@Html.DropDownListFor(model => model.{1}, ViewData[\"TrueAndFalseList\"] as List<SelectListItem>)",
                                objViewInfoENEx.TabName_Out, strFldName);
                        }
                        else
                        {
                            clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strDsTabId, objProjectsENEx.PrjId);
                            strCodeForCs.AppendFormat("\r\n" + "@Html.DropDownListFor(model => model.{1}, ViewData[\"{2}List\"] as List<SelectListItem>)",
                                objViewInfoENEx.TabName_Out, strFldName, objPrjTab.TabName);
                        }
                        break;
                    default:
                        string strMsg = string.Format("控件名:{1}在Switch没有处理,请检查!({0})",
                          clsStackTrace.GetCurrClassFunction(), strCtlTypeName);
                        throw new Exception(strMsg);
                       
            }

                //strCodeForCs.AppendFormat("\r\n" + "<asp:{0} id = \"{1}\" style = \"z-index: {2}; \" ",
                //  strCtlTypeName, strCtlId, objGenCtlStyle.StyleZindex, objGenCtlStyle.Width, objGenCtlStyle.Height);

                //strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" CssClass = \"TextBox_Defa\">",
                //  objGenCtlStyle.Runat);
                //strCodeForCs.AppendFormat("\r\n" + "</asp:{0}>",
                //  strCtlTypeName);
                strCodeForCs.Append("\r\n" + "</td>");

                intZIndex += 1;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("在生成组合控件时出错!错误:{0}.({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }



        #endregion

        ///以下均是界面层内容(VIEW) == == = 



        public bool DispDataGridRegionCtrl(System.Web.UI.WebControls.PlaceHolder phDataGridRegion, clsViewInfoENEx objViewInfoENEx)
        {

            Table objTable = new Table();//创建一个表格
            Table objTable4JumpPage = new Table();//创建一个表格
            objTable.BorderWidth = Unit.Parse("4");
            objTable.BorderColor = System.Drawing.Color.BurlyWood;

            objTable.Width = Unit.Parse("100%");
            TableRow tabRow;
            TableCell cell1;
            System.Web.UI.WebControls.Label lbl1;
            System.Web.UI.WebControls.TextBox txt1;
            System.Web.UI.WebControls.Button btn1;

            tabRow = new TableRow();//创建一行
            //if (objViewInfoENEx.objViewRegion_List.IsRadio() || objViewInfoENEx.objViewRegion_List.IsCheck())
            //{
                cell1 = new TableCell();//创建单元格,也就是第一列

                lbl1 = new Label();
                lbl1.Text = objViewInfoENEx.objInRelaTab.TabCnName + "列表";
                lbl1.CssClass = "h6";
                //				lbl1.Style.Add("position","absolute");
                //				lbl1.Style.Add("left","4px");
                //				lbl1.Style.Add("top","4px");
                cell1.Controls.Add(lbl1);
                lbl1 = new Label();
                lbl1.Text = "　　　　";
                lbl1.CssClass = "h6";
                cell1.Controls.Add(lbl1);
                btn1 = MakeButton("添加记录");
                cell1.Controls.Add(btn1);
                tabRow.Cells.Add(cell1);
                btn1 = MakeButton("修改记录");
                cell1.Controls.Add(btn1);
                tabRow.Cells.Add(cell1);
                btn1 = MakeButton("删除记录");
                cell1.Controls.Add(btn1);
                tabRow.Cells.Add(cell1);
                btn1 = MakeButton("导出Excel");
                cell1.Controls.Add(btn1);
                tabRow.Cells.Add(cell1);
                objTable.Rows.Add(tabRow);//添加到表格中
            //}
            ///新建表行,专用于放Datagrid
            tabRow = new TableRow();//创建一行
            cell1 = new TableCell();//创建单元格,也就是第一列
            DataGrid dg = MakeGrid();
            cell1.Controls.Add(dg);
            cell1.HorizontalAlign = HorizontalAlign.Left;
            tabRow.Cells.Add(cell1);
            objTable.Rows.Add(tabRow);

            ///新建表行,专用于放跳页
            ///
            tabRow = new TableRow();//创建一行
            cell1 = new TableCell();//创建单元格,也就是第一列
                                    //cell1.Font.Name = "verdana";
                                    //cell1.Font.Size = FontUnit.Parse("x-small");
            cell1.CssClass = "NameLabel";
            cell1.BackColor = System.Drawing.Color.Plum;    // "#c0c0c0";
            cell1.Text = "共有记录:";
            tabRow.Cells.Add(cell1);

            cell1 = new TableCell();//创建单元格,也就是第一列
            lbl1 = MakeLabel("0");
            lbl1.Width = 16;
            cell1.Controls.Add(lbl1);
            tabRow.Cells.Add(cell1);

            cell1 = new TableCell();//创建单元格,也就是第一列
                                    //cell1.Font.Name = "verdana";
                                    //cell1.Font.Size = FontUnit.Parse("x-small");
            cell1.CssClass = "NameLabel";
            cell1.BackColor = System.Drawing.Color.Plum;    // "#c0c0c0";
            cell1.Text = "总页数:";
            tabRow.Cells.Add(cell1);

            cell1 = new TableCell();//创建单元格,也就是第一列
            lbl1 = MakeLabel("0");
            lbl1.Width = 16;
            cell1.Controls.Add(lbl1);
            tabRow.Cells.Add(cell1);

            cell1 = new TableCell();//创建单元格,也就是第一列
                                    //cell1.Font.Name = "verdana";
                                    //cell1.Font.Size = FontUnit.Parse("x-small");
            cell1.CssClass = "NameLabel";
            cell1.BackColor = System.Drawing.Color.Plum;    // "#c0c0c0";
            cell1.Text = "当前页:";
            tabRow.Cells.Add(cell1);

            cell1 = new TableCell();//创建单元格,也就是第一列
            lbl1 = MakeLabel("0");
            lbl1.Width = 16;
            cell1.Controls.Add(lbl1);
            tabRow.Cells.Add(cell1);

            cell1 = new TableCell();//创建单元格,也就是第一列
            btn1 = MakeButton("上一页");
            btn1.Width = 50;
            cell1.Controls.Add(btn1);
            tabRow.Cells.Add(cell1);

            cell1 = new TableCell();//创建单元格,也就是第一列
            btn1 = MakeButton("下一页");
            btn1.Width = 50;
            cell1.Controls.Add(btn1);
            tabRow.Cells.Add(cell1);

            cell1 = new TableCell();//创建单元格,也就是第一列
                                    //cell1.Font.Name = "verdana";
                                    //cell1.Font.Size = FontUnit.Parse("x-small");
            cell1.CssClass = "NameLabel";
            cell1.BackColor = System.Drawing.Color.Plum;    // "#c0c0c0";
            cell1.Text = "到第:";
            tabRow.Cells.Add(cell1);

            cell1 = new TableCell();//创建单元格,也就是第一列
            txt1 = MakeTextBox("1");
            txt1.Width = 35;
            cell1.Controls.Add(txt1);
            tabRow.Cells.Add(cell1);

            cell1 = new TableCell();//创建单元格,也就是第一列
            btn1 = MakeButton("确定");
            btn1.Width = 35;
            cell1.Controls.Add(btn1);
            tabRow.Cells.Add(cell1);

            objTable4JumpPage.Rows.Add(tabRow);

            tabRow = new TableRow();
            cell1 = new TableCell();//创建单元格,也就是第一列
            cell1.Controls.Add(objTable4JumpPage);
            tabRow.Cells.Add(cell1);
            objTable.Rows.Add(tabRow);
            phDataGridRegion.Controls.Add(objTable);
            //			phDataGridRegion.Controls.Add(objTable4JumpPage);

            return true;
        }
        public DataGrid MakeGrid()
        {

            DataGrid mygrid = new DataGrid();
            mygrid.CellPadding = 2;
            mygrid.Attributes.Add("align", "center");
            mygrid.CellSpacing = 0;
            mygrid.Width = 700;
            mygrid.BorderWidth = 1;
            mygrid.BorderColor = ColorTranslator.FromHtml("Black");
            mygrid.AutoGenerateColumns = false;
            mygrid.ForeColor = ColorTranslator.FromHtml("Black");
            mygrid.Font.Size = 9;
            mygrid.Font.Name = "宋体";
            mygrid.AllowSorting = true;
            //if (objViewInfoENEx.objViewRegion_List.AllowPaging() == true)
            //{
                mygrid.AllowPaging = true;
            mygrid.PageSize = 15;// objViewInfoENEx.objViewRegion_List.PageSize();
                mygrid.ShowFooter = true;
                mygrid.PagerStyle.Mode = PagerMode.NumericPages;
            //}
            ///sort命令的事件处理器

            //			mygrid.SortCommand += new DataGridSortCommandEventHandler(Sort_Grid);

            ///设置headerstyle
            mygrid.HeaderStyle.BackColor = ColorTranslator.FromHtml("Gold");
            mygrid.HeaderStyle.ForeColor = ColorTranslator.FromHtml("Black");
            mygrid.HeaderStyle.Font.Name = "宋体";
            mygrid.HeaderStyle.Font.Size = 9;
            mygrid.HeaderStyle.Font.Bold = true;
            mygrid.HeaderStyle.HorizontalAlign = HorizontalAlign.Center;

            ///设置alternating style
            mygrid.AlternatingItemStyle.BackColor = ColorTranslator.FromHtml("Silver");
            mygrid.AlternatingItemStyle.ForeColor = ColorTranslator.FromHtml("Black");

            ///设置itemstyle
            mygrid.ItemStyle.HorizontalAlign = HorizontalAlign.Left;

            ///创建绑定列和属性
            int intColNo = 0;   //列序号
                                ///如果有单选按钮
            //if (objViewInfoENEx.objViewRegion_List.IsRadio())
            //{
            //TemplateColumn tempCol = new TemplateColumn();
            //ColumnTemplate_Radio myColTemp = new ColumnTemplate_Radio();

            /////设置模板列属性和ItemStyle模板
            //tempCol.HeaderText = "选择";
            //tempCol.HeaderStyle.HorizontalAlign = HorizontalAlign.Center;
            //tempCol.ItemStyle.BackColor = ColorTranslator.FromHtml("#FFF778");
            //tempCol.ItemStyle.HorizontalAlign = HorizontalAlign.Center;

            /////创建列模板。
            /////列模板从ITemplate继承
            //tempCol.ItemTemplate = myColTemp;
            //mygrid.Columns.AddAt(intColNo++, tempCol);

            //}
            ///如果有复选按钮
            //if (objViewInfoENEx.objViewRegion_List.IsCheck())
            //{
            TemplateColumn tempCol = new TemplateColumn();
            ColumnTemplate_Chk myColTemp = new ColumnTemplate_Chk();

            ///设置模板列属性和ItemStyle模板
            tempCol.HeaderText = "全选";
                tempCol.HeaderStyle.HorizontalAlign = HorizontalAlign.Center;
                tempCol.ItemStyle.BackColor = ColorTranslator.FromHtml("#FFF778");
                tempCol.ItemStyle.HorizontalAlign = HorizontalAlign.Center;

                ///创建列模板。
                ///列模板从ITemplate继承
                tempCol.ItemTemplate = myColTemp;
                mygrid.Columns.AddAt(intColNo++, tempCol);

            //}
            foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
            {
                BoundColumn boundCol = new BoundColumn();
                boundCol.HeaderText = objDGRegionFldsEx.HeaderText;
                boundCol.DataField = objDGRegionFldsEx.ObjFieldTabENEx.FldName;
                boundCol.SortExpression = objDGRegionFldsEx.ObjFieldTabENEx.FldName;
                mygrid.Columns.AddAt(intColNo++, boundCol);
                //					mygrid.Columns.AddAt(1, LastName);
            }

            //if (objViewInfoENEx.objViewRegion_List.IsHaveUpdBtn())
            //{
                ButtonColumn objButtonCol = new ButtonColumn();
                objButtonCol.HeaderText = "修改";
                objButtonCol.Text = "修改";
                //				objButtonCol.DataField = objViewCtlField.FldName;
                //				objButtonCol.SortExpression = objViewCtlField.FldName;
                objButtonCol.CommandName = "Update";
                mygrid.Columns.AddAt(intColNo++, objButtonCol);
            //}

            //if (objViewInfoENEx.objViewRegion_List.IsHaveDelBtn())
            //{
                ButtonColumn objButtonCol2 = new ButtonColumn();
            objButtonCol2.HeaderText = "删除";
            objButtonCol2.Text = "删除";
            //				objButtonCol.DataField = objViewCtlField.FldName;
            //				objButtonCol.SortExpression = objViewCtlField.FldName;
            objButtonCol2.CommandName = "Delete";
                mygrid.Columns.AddAt(intColNo++, objButtonCol2);

                //				TemplateColumn tempCol = new TemplateColumn();
                //				ColumnTemplate myColTemp = new ColumnTemplate();
                //
                //				///设置模板列属性和ItemStyle模板
                //				tempCol.HeaderText = "删除";
                //				tempCol.HeaderStyle.HorizontalAlign = HorizontalAlign.Center;
                //				tempCol.ItemStyle.BackColor = ColorTranslator.FromHtml("#FFF778");
                //				tempCol.ItemStyle.HorizontalAlign = HorizontalAlign.Center;
                //				Button lb = new Button();
                //				lb.Text = "删除";
                //				///创建列模板。
                //				///列模板从ITemplate继承
                //				myColTemp.InstantiateIn(lb);
                //				tempCol.ItemTemplate = myColTemp;
                //				
                ////<asp:TemplateColumn>
                ////<ItemTemplate>
                ////<asp:Button id = "lbnDelete" runat = "Server" CommandName = "Delete" Text = "删除"></asp:Button>
                ////</ItemTemplate>
                ////</asp:TemplateColumn>
                ////
                //				mygrid.Columns.AddAt(intColNo++, tempCol);

            //}
            //if (objViewInfoENEx.objViewRegion_List.IsHaveDetailBtn())
            //{
                ButtonColumn objButtonCol3 = new ButtonColumn();
            objButtonCol3.HeaderText = "详细";
            objButtonCol3.Text = "详细";
            //				objButtonCol.DataField = objViewCtlField.FldName;
            //				objButtonCol.SortExpression = objViewCtlField.FldName;
            objButtonCol3.CommandName = "Update";
                mygrid.Columns.AddAt(intColNo++, objButtonCol3);
            //}

            mygrid.DataSource = MakeTestTable();

            mygrid.DataBind();
            return mygrid;
        }
        private DataView MakeTestTable()
        {
            // Create a new DataTable.
            System.Data.DataTable myDataTable = new DataTable("TestTable");
            // Declare variables for DataColumn and DataRow objects.
            DataColumn myDataColumn;
            DataRow myDataRow;
            foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
            {
                // Create new DataColumn, set DataType, ColumnName and add to DataTable.  
                myDataColumn = new DataColumn();
                myDataColumn.DataType = System.Type.GetType("System.String");
                myDataColumn.ColumnName = objDGRegionFldsEx.ObjFieldTabENEx.FldName;
                myDataColumn.ReadOnly = true;
                myDataColumn.Unique = false;
                // Add the Column to the DataColumnCollection.
                myDataTable.Columns.Add(myDataColumn);
            }
           
            for (int i = 0; i <= 2; i++)
            {
                myDataRow = myDataTable.NewRow();
                foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
                {
                    myDataRow[objDGRegionFldsEx.ObjFieldTabENEx.FldName] = i.ToString();
                }
                //				myDataRow["id"] = i;
                //				myDataRow["ParentItem"] = "ParentItem " + i;
                myDataTable.Rows.Add(myDataRow);
            }
            DataView myView = myDataTable.DefaultView;
            //myView.Sort = SortExpression;
            //Response.Write(sql);
            return myView;
        }

        public static Button MakeButton(string strButtonName)
        {
            System.Web.UI.WebControls.Button btn1;
            btn1 = new Button();
            btn1.Text = strButtonName;
            //btn1.Font.Name = "verdana";
            //btn1.Font.Size = FontUnit.Parse("x-small");
            btn1.CssClass = "btn btn-primary btn-sm";
            btn1.Width = 80;
            return btn1;
        }

        public static Label MakeLabel(string strLabelText)
        {
            System.Web.UI.WebControls.Label lbl1;
            lbl1 = new Label();
            lbl1.Text = strLabelText;
            lbl1.CssClass = "NameLabel";

            //lbl1.Font.Name = "verdana";
            //lbl1.Font.Size = FontUnit.Parse("x-small");
            lbl1.Width = 60;
            return lbl1;
        }
        public static TextBox MakeTextBox(string strTextBoxText)
        {
            System.Web.UI.WebControls.TextBox txt1;
            txt1 = new TextBox();
            txt1.Text = "";
            txt1.CssClass = "TextBox_Defa";
            //txt1.Font.Name = "verdana";
            //txt1.Font.Size = FontUnit.Parse("x-small");
            txt1.Width = 60;
            return txt1;
        }
        public static CheckBox MakeCheckBox(string strCheckBoxText)
        {
            System.Web.UI.WebControls.CheckBox chk1;
            chk1 = new CheckBox();
            chk1.Text = strCheckBoxText;
            chk1.CssClass = "Check_Defa";
            //chk1.Font.Name = "verdana";
            //chk1.Font.Size = FontUnit.Parse("x-small");
            chk1.Width = 100;
            return chk1;
        }


        public static bool DispEditRegionCtrl(System.Web.UI.WebControls.PlaceHolder phQryRegion, clsViewInfoENEx objViewInfoENEx)
        {
            int intColNum = objViewInfoENEx.objViewRegion_Edit.ColNum ?? 0;

            Table tb = new Table();//创建一个表格
            tb.BorderWidth = Unit.Parse("4");
            tb.BorderColor = System.Drawing.Color.BurlyWood;
            tb.Width = Unit.Parse("100%");
            int iCtlNum = 0;
            TableRow tr;
            TableCell cell1, cell2;
            System.Web.UI.WebControls.Label lbl1;
            System.Web.UI.WebControls.CheckBox chk1;
            System.Web.UI.WebControls.TextBox txt1;
            System.Web.UI.WebControls.DropDownList ddl1;
            System.Web.UI.WebControls.Button btn1;
            System.Web.UI.WebControls.Panel panel1;

            panel1 = new Panel();
            panel1.Width = 700;
            panel1.Height = 32;


            //	<asp:label id = "Label1" style = "z-index: 109; left: 0px; position: absolute; top: 1px" runat = "server"
            //	CssClass = "h6">编辑字段属性</asp:label></DIV>
            lbl1 = new Label();
            lbl1.Text = objViewInfoENEx.objInRelaTab.TabCnName + "字段属性";
            lbl1.CssClass = "h6";
            //lbl1.Style.Add("position", "absolute");
            //lbl1.Style.Add("left", "4px");
            //lbl1.Style.Add("top", "4px");
            lbl1.Width = 400;
            panel1.Controls.Add(lbl1);

            btn1 = new Button();
            btn1.Text = "添加";
            //btn1.Font.Name = "verdana";
            //btn1.Font.Size = FontUnit.Parse("x-small");
            btn1.CssClass = "btn btn-primary btn-sm";
            btn1.Width = 80;

            //<asp:Button id = "btnOKUpd" style = "z-index: 106; left: 720px; position: absolute; top: 0px" runat = "server"
            //												Font-Names = "verdana" Font-Size = "x-Small" Height = "24px" Width = "80px" Text = "添加"></asp:Button>

            //btn1.Style.Add("position","absolute");
            //btn1.Style.Add("left","620px");
            //btn1.Style.Add("top","4px");
            panel1.Controls.Add(btn1);

            tr = new TableRow();//创建一行
            cell1 = new TableCell();//创建单元格,也就是第一列
            cell1.Controls.Add(panel1);
            cell1.ColumnSpan = intColNum * 2;
            tr.Cells.Add(cell1);
            //			for(int i = 0; i<intColNum*2-1; i++)
            //			{
            //				cell1 = new TableCell();//创建单元格,也就是第一列
            //				tr.Cells.Add(cell1);   
            //			}
            tb.Rows.Add(tr);//添加到表格中


            tr = new TableRow();//创建一行
            bool bolIsEndRow = false;
            foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
            {
                if (objEditRegionFldsEx.InUse == false) continue;
                if (iCtlNum % (intColNum * 2) == 0)
                {
                    tr = new TableRow();//创建一行
                    bolIsEndRow = false;
                }

                switch (objEditRegionFldsEx.objCtlType.CtlTypeName)
                {
                    case "CheckBox":
                        chk1 = new CheckBox();
                        chk1.Text = objEditRegionFldsEx.LabelCaption;
                        //chk1.Font.Name = "verdana";
                        //chk1.Font.Size = FontUnit.Parse("x-small");
                        lbl1.CssClass = "NameLabel";
                        chk1.Width = 100;
                        cell1 = new TableCell();//创建单元格,也就是第一列
                        cell1.Controls.Add(chk1);
                        tr.Cells.Add(cell1);
                        iCtlNum++;
                        cell2 = new TableCell();//创建单元格,也就是第一列
                        cell1.Text = "";
                        tr.Cells.Add(cell2);

                        break;
                    case "TextBox":
                        lbl1 = new Label();
                        lbl1.Text = objEditRegionFldsEx.LabelCaption;
                        //lbl1.Font.Name = "verdana";
                        //lbl1.Font.Size = FontUnit.Parse("x-small");
                        lbl1.CssClass = "NameLabel";
                        lbl1.Width = 60;
                        cell1 = new TableCell();//创建单元格,也就是第一列
                        cell1.Controls.Add(lbl1);
                        tr.Cells.Add(cell1);
                        iCtlNum++;
                        txt1 = new TextBox();
                        txt1.Text = "";
                        //txt1.Font.Name = "verdana";
                        //txt1.Font.Size = FontUnit.Parse("x-small");
                        txt1.CssClass = "TextBox_Defa";
                        txt1.Width = 60;
                        cell2 = new TableCell();//创建单元格,也就是第一列
                        cell2.Controls.Add(txt1);
                        tr.Cells.Add(cell2);
                        break;
                    case "DropDownList":
                        lbl1 = new Label();
                        lbl1.Text = objEditRegionFldsEx.LabelCaption;
                        //lbl1.Font.Name = "verdana";
                        //lbl1.Font.Size = FontUnit.Parse("x-small");
                        lbl1.CssClass = "NameLabel";
                        lbl1.Width = 60;
                        cell1 = new TableCell();//创建单元格,也就是第一列
                        cell1.Controls.Add(lbl1);
                        tr.Cells.Add(cell1);
                        iCtlNum++;
                        ddl1 = new DropDownList();
                        //							ddl1.Text = "";
                        //ddl1.Font.Name = "verdana";
                        //ddl1.Font.Size = FontUnit.Parse("x-small");
                        ddl1.CssClass = "DropDown_Defa";
                        ddl1.Width = 60;
                        cell2 = new TableCell();//创建单元格,也就是第一列
                        cell2.Controls.Add(ddl1);
                        tr.Cells.Add(cell2);
                        break;

                    default:
                        lbl1 = new Label();
                        lbl1.Text = objEditRegionFldsEx.LabelCaption;
                        //lbl1.Font.Name = "verdana";
                        //lbl1.Font.Size = FontUnit.Parse("x-small");
                        lbl1.Width = 60;
                        cell1 = new TableCell();//创建单元格,也就是第一列
                        cell1.Controls.Add(lbl1);
                        tr.Cells.Add(cell1);
                        iCtlNum++;
                        txt1 = new TextBox();
                        txt1.Text = "";
                        //txt1.Font.Name = "verdana";
                        //txt1.Font.Size = FontUnit.Parse("x-small");
                        txt1.Width = 60;
                        cell2 = new TableCell();//创建单元格,也就是第一列
                        cell2.Controls.Add(txt1);
                        tr.Cells.Add(cell2);
                        break;
                }

                if (iCtlNum % (intColNum * 2) == (intColNum * 2 - 1))
                {
                    tb.Rows.Add(tr);//添加到表格中
                    bolIsEndRow = true;
                }
                iCtlNum++;
            }
            if (bolIsEndRow == false)
            {
                tb.Rows.Add(tr);//添加到表格中
            }

            ///生成查询按钮的代码;
            //			strCodeForCs.Append("\r\n" + GenButton(objButtonStyle,"btnQuery","查询"));
            phQryRegion.Controls.Add(tb);


            return true;
        }
        //显示预览<Excel导出区域>的控件
        public static bool DispExcelExportRegionCtrl(System.Web.UI.WebControls.PlaceHolder phExcelExportRegion, clsViewInfoENEx objViewInfoENEx)
        {

            Table tb = new Table();//创建一个表格

            tb.BorderWidth = Unit.Parse("4");
            tb.BorderColor = System.Drawing.Color.BurlyWood;
            tb.Width = Unit.Parse("100%");
            TableRow tr;
            TableCell cell1;
            System.Web.UI.WebControls.Label lbl1;
            System.Web.UI.WebControls.CheckBox chk1;
            System.Web.UI.WebControls.Button btn1;
            int intColNum = objViewInfoENEx.objViewRegion_Query.ColNum ?? 0;
            int intIndex = 1;
            foreach (clsExcelExportRegionFldsENEx objExcelExportRegionFldsEx in objViewInfoENEx.arrExcelExportRegionFldSet)
            {
                tr = new TableRow();//创建一行
                                    //序号
                lbl1 = new Label();
                lbl1.Text = intIndex.ToString();
                //lbl1.Font.Name = "verdana";
                //lbl1.Font.Size = FontUnit.Parse("x-small");
                lbl1.CssClass = "NameLabel";
                lbl1.Width = 20;
                cell1 = new TableCell();//创建单元格,也就是第一列
                cell1.Controls.Add(lbl1);
                tr.Cells.Add(cell1);

                //复选框
                chk1 = new CheckBox();
                chk1.Text = "";
                //chk1.Font.Name = "verdana";
                //chk1.Font.Size = FontUnit.Parse("x-small");
                chk1.CssClass = "Check_Defa";
                chk1.Width = 30;
                cell1 = new TableCell();//创建单元格,也就是第一列
                cell1.Controls.Add(chk1);
                tr.Cells.Add(cell1);

                //字段名(列名)
                lbl1 = new Label();
                lbl1.Text = objExcelExportRegionFldsEx.ColCaption;
                //lbl1.Font.Name = "verdana";
                //lbl1.Font.Size = FontUnit.Parse("x-small");
                lbl1.CssClass = "NameLabel";
                lbl1.Width = 120;
                cell1 = new TableCell();//创建单元格,也就是第一列
                cell1.Controls.Add(lbl1);
                tr.Cells.Add(cell1);
                tb.Rows.Add(tr);//添加到表格中
                intIndex++;
            }
            //导出EXCEL的按钮
            tr = new TableRow();//创建一行
                                //空两格
            cell1 = new TableCell();//创建单元格,也就是第一列
            tr.Cells.Add(cell1);
            cell1 = new TableCell();//创建单元格,也就是第一列
            tr.Cells.Add(cell1);

            btn1 = new Button();
            btn1.Text = "导出Excel";
            //btn1.Font.Name = "verdana";
            //btn1.Font.Size = FontUnit.Parse("x-small");
            btn1.CssClass = "btn btn-primary btn-sm";
            btn1.Width = 80;
            cell1 = new TableCell();//创建单元格,也就是第一列
            cell1.Controls.Add(btn1);
            tr.Cells.Add(cell1);
            tb.Rows.Add(tr);//添加到表格中
                            ///生成查询按钮的代码;
            //			strCodeForCs.Append("\r\n" + GenButton(objButtonStyle,"btnQuery","查询"));
            phExcelExportRegion.Controls.Add(tb);


            return true;
        }
        //显示预览<ListView区域>的控件
        public static bool DispListViewRegionCtrl(System.Web.UI.WebControls.PlaceHolder phListViewRegion, clsViewInfoENEx objViewInfoENEx)
        {

            Table tb = new Table();//创建一个表格

            tb.BorderWidth = Unit.Parse("4");
            tb.BorderColor = System.Drawing.Color.BurlyWood;
            tb.Width = Unit.Parse("100%");
            TableRow tr, tabRow;
            TableCell cell1;
            System.Web.UI.WebControls.Label lbl1;
            System.Web.UI.WebControls.Button btn1;
            int intColNum = objViewInfoENEx.objViewRegion_Query.ColNum ?? 0;

            Table objTable = new Table();//创建一个表格

            tabRow = new TableRow();//创建一行

            cell1 = new TableCell();//创建单元格,也就是第一列
            lbl1 = new Label();
            lbl1.Text = objViewInfoENEx.objInRelaTab.TabCnName + "列表";
            lbl1.CssClass = "h6";
            //				lbl1.Style.Add("position","absolute");
            //				lbl1.Style.Add("left","4px");
            //				lbl1.Style.Add("top","4px");
            lbl1.CssClass = "NameLabel";
            cell1.Controls.Add(lbl1);
            lbl1 = new Label();
            lbl1.Text = "　　　　";
            lbl1.CssClass = "h6";
            cell1.Controls.Add(lbl1);
            btn1 = MakeButton("添加记录");
            cell1.Controls.Add(btn1);
            tabRow.Cells.Add(cell1);
            btn1 = MakeButton("修改记录");
            cell1.Controls.Add(btn1);
            tabRow.Cells.Add(cell1);
            btn1 = MakeButton("删除记录");
            cell1.Controls.Add(btn1);
            tabRow.Cells.Add(cell1);
            btn1 = MakeButton("导出Excel");
            cell1.Controls.Add(btn1);
            tabRow.Cells.Add(cell1);
            objTable.Rows.Add(tabRow);//添加到表格中


            int intIndex = 1;
            tr = new TableRow();//创建一行
            foreach (clsDGRegionFldsENEx ObjLstViewRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
            {
                //字段名(列名)
                lbl1 = new Label();
                lbl1.Text = ObjLstViewRegionFldsEx.HeaderText;
                //lbl1.Font.Name = "verdana";
                //lbl1.Font.Size = FontUnit.Parse("x-small");
                lbl1.CssClass = "NameLabel";
                lbl1.Font.Bold = true;
                lbl1.Width = 60;
                cell1 = new TableCell();//创建单元格,也就是第一列
                cell1.Controls.Add(lbl1);
                tr.Cells.Add(cell1);
                intIndex++;
            }
            tb.Rows.Add(tr);//添加到表格中
            for (int i = 0; i < 5; i++)
            {
                tr = new TableRow();//创建一行
                intIndex = 1;
                int intFldNum = objViewInfoENEx.arrDGRegionFldSet.Count;
                for (int j = 0; j < intFldNum; j++)
                {
                    //字段名(列名)
                    lbl1 = new Label();
                    lbl1.Text = intIndex.ToString();
                    //lbl1.Font.Name = "verdana";
                    //lbl1.Font.Size = FontUnit.Parse("x-small");
                    lbl1.CssClass = "NameLabel";
                    lbl1.Width = 60;
                    cell1 = new TableCell();//创建单元格,也就是第一列
                    cell1.Controls.Add(lbl1);
                    tr.Cells.Add(cell1);
                    intIndex++;
                }
                tb.Rows.Add(tr);//添加到表格中
            }

            phListViewRegion.Controls.Add(objTable);
            phListViewRegion.Controls.Add(tb);
            return true;
        }
        //显示预览查询区域的控件
        public static int DispQryRegionCtrl(System.Web.UI.WebControls.PlaceHolder phQryRegion, clsViewInfoENEx objViewInfoENEx)
        {
            int intRow = 0, intCol = 0; //当前行,当前列
            int iCtlNum = 0;
            Table tb = new Table();//创建一个表格

            tb.BorderWidth = Unit.Parse("4");
            tb.BorderColor = System.Drawing.Color.BurlyWood;
            tb.Width = Unit.Parse("100%");

            TableRow tr;
            TableCell cell1;//, cell2;
                            //System.Web.UI.WebControls.Label lbl1;
                            //System.Web.UI.WebControls.CheckBox chk1;
                            //System.Web.UI.WebControls.TextBox txt1;
                            //System.Web.UI.WebControls.DropDownList ddl1;
            System.Web.UI.WebControls.Button btn1;
            int intColNum = objViewInfoENEx.objViewRegion_Query.ColNum ?? 0;//该区域定义的列数
            tr = new TableRow();//创建一行
            //bool bolIsEndRow = false;
            foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
            {
                if (intCol == intColNum)
                {
                    cell1 = new TableCell();//创建单元格,也就是第一列

                    tr.Cells.Add(cell1);
                    intCol++;

                    intRow++;
                    tb.Rows.Add(tr);//添加到表格中

                    tr = new TableRow();//创建一行
                    intCol = 0;
                    //bolIsEndRow = false;
                }
                wccFieldGroup wcc = new wccFieldGroup();
                wcc.Caption = objQryRegionFldsEx.LabelCaption;
                wcc.wccfg_CaptionCss = "NameLabel";
                wcc.wccfg_TextBoxCss = "TextBox_Defa";
                wcc.wccfg_LinkButtonCss = "lkbtn";
                wcc.Attributes.Add("DelThisCtrlClick", "wccFieldGroup2_DelThisCtrlClick");
                //wcc.DelThisCtrlClick += new EventHandler(wccFieldGroup2_DelThisCtrlClick);
                wcc.CtlTypeName = objQryRegionFldsEx.objCtlType.CtlTypeName;
                cell1 = new TableCell();//创建单元格,也就是第一列
                cell1.Controls.Add(wcc);
                tr.Cells.Add(cell1);
                intCol++;


                iCtlNum++;
            }
            //为最后一行添加单元格,使最后单元格不缺
            while (intCol < intColNum)
            {
                cell1 = new TableCell();//创建单元格,也就是第一列

                tr.Cells.Add(cell1);
                intCol++;
            }

            //if (bolIsEndRow == false)
            //{
            //  intRow++;
            //  tb.Rows.Add(tr);//添加到表格中
            //}
            //tr = new TableRow();//创建一行

            btn1 = new Button();
            btn1.Text = "查询";
            //btn1.Font.Name = "verdana";
            //btn1.Font.Size = FontUnit.Parse("x-small");
            btn1.CssClass = "btn btn-primary btn-sm";
            btn1.Width = 80;
            cell1 = new TableCell();//创建单元格,也就是第一列
            cell1.Controls.Add(btn1);
            tr.Cells.Add(cell1);
            tb.Rows.Add(tr);//添加到表格中
            intRow++;
            ///生成查询按钮的代码;
            //			strCodeForCs.Append("\r\n" + GenButton(objButtonStyle,"btnQuery","查询"));
            phQryRegion.Controls.Add(tb);


            return intRow;
        }
        //显示预览<详细信息区域>的控件
        public static bool DispDetailRegionCtrl(System.Web.UI.WebControls.PlaceHolder phDetailRegion, clsViewInfoENEx objViewInfoENEx)
        {

            Table tb = new Table();//创建一个表格

            tb.BorderWidth = Unit.Parse("4");
            tb.BorderColor = System.Drawing.Color.BurlyWood;
            tb.Width = Unit.Parse("100%");
            int iCtlNum = 0;
            TableRow tr;
            TableCell cell1, cell2;
            System.Web.UI.WebControls.Label lbl1;
            System.Web.UI.WebControls.CheckBox chk1;
            System.Web.UI.WebControls.TextBox txt1;
            System.Web.UI.WebControls.DropDownList ddl1;
            System.Web.UI.WebControls.Button btn1;
            int intColNum = objViewInfoENEx.objViewRegion_Query.ColNum ?? 0;
            tr = new TableRow();//创建一行
            bool bolIsEndRow = false;
            foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
            {
                if (iCtlNum % (intColNum * 2) == 0)
                {
                    tr = new TableRow();//创建一行
                    bolIsEndRow = false;
                }

                switch (objQryRegionFldsEx.objCtlType.CtlTypeName)
                {
                    case "CheckBox":
                        chk1 = new CheckBox();
                        chk1.Text = objQryRegionFldsEx.LabelCaption;
                        //chk1.Font.Name = "verdana";
                        //chk1.Font.Size = FontUnit.Parse("x-small");
                        chk1.CssClass = "Check_Defa";
                        chk1.Width = 100;
                        cell1 = new TableCell();//创建单元格,也就是第一列
                        cell1.Controls.Add(chk1);
                        tr.Cells.Add(cell1);
                        iCtlNum++;
                        cell2 = new TableCell();//创建单元格,也就是第一列
                        cell1.Text = "";
                        tr.Cells.Add(cell2);
                        break;
                    case "TextBox":
                        lbl1 = new Label();
                        lbl1.Text = objQryRegionFldsEx.LabelCaption;
                        //lbl1.Font.Name = "verdana";
                        //lbl1.Font.Size = FontUnit.Parse("x-small");
                        lbl1.CssClass = "Label_Defa";
                        lbl1.Width = 60;
                        cell1 = new TableCell();//创建单元格,也就是第一列
                        cell1.Controls.Add(lbl1);
                        tr.Cells.Add(cell1);
                        iCtlNum++;
                        txt1 = new TextBox();
                        txt1.Text = "";
                        //txt1.Font.Name = "verdana";
                        //txt1.Font.Size = FontUnit.Parse("x-small");
                        txt1.CssClass = "TextBox_Defa";
                        txt1.Width = 60;
                        cell2 = new TableCell();//创建单元格,也就是第一列
                        cell2.Controls.Add(txt1);
                        tr.Cells.Add(cell2);
                        break;
                    case "DropDownList":
                        lbl1 = new Label();
                        lbl1.Text = objQryRegionFldsEx.LabelCaption;
                        //lbl1.Font.Name = "verdana";
                        //lbl1.Font.Size = FontUnit.Parse("x-small");
                        lbl1.CssClass = "NameLabel";
                        lbl1.Width = 60;
                        cell1 = new TableCell();//创建单元格,也就是第一列
                        cell1.Controls.Add(lbl1);
                        tr.Cells.Add(cell1);
                        iCtlNum++;
                        ddl1 = new DropDownList();
                        //							ddl1.Text = "";
                        //ddl1.Font.Name = "verdana";
                        //ddl1.Font.Size = FontUnit.Parse("x-small");
                        ddl1.CssClass = "DropDown_Defa";
                        ddl1.Width = 60;
                        cell2 = new TableCell();//创建单元格,也就是第一列
                        cell2.Controls.Add(ddl1);
                        tr.Cells.Add(cell2);
                        break;

                    default:
                        lbl1 = new Label();
                        lbl1.Text = objQryRegionFldsEx.LabelCaption;
                        //lbl1.Font.Name = "verdana";
                        //lbl1.Font.Size = FontUnit.Parse("x-small");
                        lbl1.CssClass = "NameLabel";
                        lbl1.Width = 60;
                        cell1 = new TableCell();//创建单元格,也就是第一列
                        cell1.Controls.Add(lbl1);
                        tr.Cells.Add(cell1);
                        iCtlNum++;
                        txt1 = new TextBox();
                        txt1.Text = "";
                        //txt1.Font.Name = "verdana";
                        //txt1.Font.Size = FontUnit.Parse("x-small");
                        txt1.CssClass = "TextBox_Defa";
                        txt1.Width = 60;
                        cell2 = new TableCell();//创建单元格,也就是第一列
                        cell2.Controls.Add(txt1);
                        tr.Cells.Add(cell2);
                        break;
                }

                if (iCtlNum % (intColNum * 2) == (intColNum * 2 - 1))
                {
                    tb.Rows.Add(tr);//添加到表格中
                    bolIsEndRow = true;
                }
                iCtlNum++;
            }

            if (bolIsEndRow == false)
            {
                tb.Rows.Add(tr);//添加到表格中
            }
            tr = new TableRow();//创建一行
                                //空几个单元格
            for (int i = 0; i < intColNum * 2 - 1; i++)
            {
                cell1 = new TableCell();//创建单元格,也就是第一列
                tr.Cells.Add(cell1);
            }
            btn1 = new Button();
            btn1.Text = "关闭";
            //btn1.Font.Name = "verdana";
            //btn1.Font.Size = FontUnit.Parse("x-small");
            btn1.CssClass = "btn btn-primary btn-sm";
            btn1.Width = 80;
            cell1 = new TableCell();//创建单元格,也就是第一列
            cell1.Controls.Add(btn1);
            tr.Cells.Add(cell1);
            tb.Rows.Add(tr);//添加到表格中
                            ///生成查询按钮的代码;
            //			strCodeForCs.Append("\r\n" + GenButton(objButtonStyle,"btnQuery","查询"));
            phDetailRegion.Controls.Add(tb);


            return true;
        }

        /// <summary>
        /// 生成指定的函数
        /// </summary>
        /// <returns>返回生成的指定函数代码</returns>
        public string A_GenCode4Function(clsViewInfoENEx objViewInfoENEx, string strFuncId4GC)
        {
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp = ""; //临时变量;
            string strFuncName = "";
            try
            {
                //类名开始
                 clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
                strFuncName = objvFunction4GeneCodeEN.FuncName;

                //if (objFunction4GeneCodeEN.FuncTypeId == "10")//用户自定义函数
                //{
                //    //strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId(objFunction4GeneCodeEN.FuncId4GC,
                //    //    objPrjTabENEx.TabId, objPrjTabENEx.PrjDataBaseId, objPrjTabENEx.PrjId);
                //}
                //else
                //{
                //strTemp = A_GeneFuncCode(objViewInfoENEx, strFuncName);
                //}

                if (string.IsNullOrEmpty(strTemp) == false)
                {
                    strCodeForCs.Append("\r\n" + strTemp);
                }

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。错误信息:{1}.({2})", strFuncName,
                    objException.Message,
                    clsStackTrace.GetCurrClassFunction());
                clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_MvcView_CtlViewCodeforTab()
        {
            string strFuncName = "";
            //''该功能主要生成与表相关的控件代码,包括两个文件,;
            //一个是控件的界面文件, ;
            //另一个与之相关的界面类文件;
            //让用户设置属性;

            objViewInfoENEx.CurrDate = clsDateTime.getTodayStr2(0);
            //string strFolder;
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;

            int intZIndex;
            //			int intCurrLeft;  ///控件的左边空;
            int intCurrTop;  ///控件的顶面空;
            objViewInfoENEx.WebUserCtlFName = objViewInfoENEx.FolderName + "wuc" + objViewInfoENEx.TabName + "B.ascx";
            objViewInfoENEx.FileName = objViewInfoENEx.WebUserCtlFName;
            objViewInfoENEx.ClsName = objViewInfoENEx.WebUserCtlFName;


            try
            {
                ///生成插入记录的界面代码;

                intZIndex = 101;
                intCurrTop = 50;
                if (objViewInfoENEx.arrEditRegionFldSet4InUse == null || objViewInfoENEx.arrEditRegionFldSet4InUse.Count == 0)
                {
                    StringBuilder sbMessage = new StringBuilder();
                    string strViewName = objViewInfoENEx.ViewName;
                    sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有编辑区域,或者编辑区域没有字段。请检查!", strViewName);
                    throw new clsDbObjException(sbMessage.ToString());
                }
                strCodeForCs.Append("\r\n" + "<table class=\"col-md-12\">");
                //strCodeForCs.Append("\r\n" + "<tr>");
                //strCodeForCs.Append("\r\n" + "<td class=\"col-md-3\">");
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.InUse == false) continue;
                    ///如果该字段不是标识递增型就生成控件,否则就不生成;
                    if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                      && objEditRegionFldsEx.PrimaryTypeId()== clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        strCodeForCs.Append("\r\n" + "@Html.HiddenFor(model => model.{0})"); 
                    }
                    if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                        && objEditRegionFldsEx.PrimaryTypeId()== enumPrimaryType.StringAutoAddPrimaryKey_03)
                    {
                        continue;
                    }
                    string strFldName = objEditRegionFldsEx.FldName;
                    string strCaption = objEditRegionFldsEx.LabelCaption;
                    //strCodeForCs.Append("\r\n" + "                        <div class=\"form-group\">");
                    strCodeForCs.Append("\r\n" + "<tr>");
                    strCodeForCs.Append("\r\n" + "<td class=\"col-md-3\">");
                    switch (objEditRegionFldsEx.objCtlType.CtlTypeName)
                    {
                        case "CheckBox":
                            strCodeForCs.AppendFormat("\r\n" + "@Html.LabelFor(model => model.{0}, htmlAttributes: new {1} @class = \"control-label\" {2})",
                               strFldName, "{", "}");
                            strCodeForCs.AppendFormat("\r\n" + "</td>");
                            strCodeForCs.Append("\r\n" + "<td class=\"col-md-9\"  style=\"text-align:left\">");
                            strCodeForCs.AppendFormat("\r\n" + "     @Html.EditorFor(model => model.{0}, new {1} htmlAttributes = new {1} @class = \"form-control\"{2} {2})",
                                 strFldName, "{", "}");

                         
                            strCodeForCs.AppendFormat("\r\n" + "</td>");
                            break;
                        case "DropDownList":
                            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabIdCache(objEditRegionFldsEx.DsTabId, objProjectsENEx.PrjId);
                            strCodeForCs.AppendFormat("\r\n" + "@Html.LabelFor(model => model.{0}, htmlAttributes: new {1} @class = \"control-label\" {2})",
                                strFldName, "{", "}");
                            strCodeForCs.Append("\r\n" + "</td>");
                            strCodeForCs.Append("\r\n" + "<td class=\"col-md-9\"  style=\"text-align:left\">");
                            //strCodeForCs.Append("\r\n" + "    <div class=\"col-md-8\">");
                            if (strFldName == FldName4Key)
                            {
                                strCodeForCs.Append("\r\n" + " @if (ViewBag.Operate == \"Add\")");
                                strCodeForCs.Append("\r\n" + " {");

                                strCodeForCs.AppendFormat("\r\n" + "     @Html.DropDownListFor(model => model.{0}, ViewData[\"{1}List\"] as List<SelectListItem>, new {{ htmlAttributes = new {{ @class = \"form-control\" }} }})",
                                    strFldName, objPrjTabEN.TabName);
                                strCodeForCs.AppendFormat("\r\n" + "     @Html.ValidationMessageFor(model => model.{0}, \"\", new {1} @class = \"text-danger\" {2})",
                                    strFldName, "{", "}");
                                strCodeForCs.Append("\r\n" + " }");
                                strCodeForCs.Append("\r\n" + " else");
                                strCodeForCs.Append("\r\n" + " {");

                                strCodeForCs.AppendFormat("\r\n" + "     @Html.DropDownListFor(model => model.{0}, ViewData[\"{1}List\"] as List<SelectListItem>, new {{ htmlAttributes = new {{ @class = \"form-control\" }} }})",
                                    strFldName, objPrjTabEN.TabName);
                                strCodeForCs.Append("\r\n" + " }");
                            }
                            else
                            {

                                strCodeForCs.AppendFormat("\r\n" + "     @Html.DropDownListFor(model => model.{0}, ViewData[\"{1}List\"] as List<SelectListItem>, new {{ htmlAttributes = new {{ @class = \"form-control\" }} }})",
                                    strFldName, objPrjTabEN.TabName);
                                strCodeForCs.AppendFormat("\r\n" + "     @Html.ValidationMessageFor(model => model.{0}, \"{1}不能为空!\", new {2} @class = \"text-danger\" {3})",
                                    strFldName, strCaption, "{", "}");
                                strCodeForCs.Append("\r\n" + "           <asp:RequiredFieldValidator ID=\"RequiredFieldValidator2\" runat=\"server\"");
                                strCodeForCs.AppendFormat("\r\n" + "                 ControlToValidate=\"{0}\" Display=\"None\" ErrorMessage=\"请输入{1}\"></asp:RequiredFieldValidator>",
                                    strFldName, strCaption);
                            }
                            //strCodeForCs.Append("\r\n" + " </div>");
                            strCodeForCs.Append("\r\n" + "</td>");
                            break;
                        default:
                            strCodeForCs.AppendFormat("\r\n" + "@Html.LabelFor(model => model.{0}, htmlAttributes: new {1} @class = \"control-label\" {2})",
                                strFldName, "{", "}");
                            strCodeForCs.Append("\r\n" + "</td>");
                            strCodeForCs.Append("\r\n" + "<td class=\"col-md-9\">");

                            //strCodeForCs.Append("\r\n" + "    <div class=\"col-md-8\">");
                            if (strFldName == FldName4Key)
                            {
                                strCodeForCs.Append("\r\n" + " @if (ViewBag.Operate == \"Add\")");
                                strCodeForCs.Append("\r\n" + " {");
                                strCodeForCs.AppendFormat("\r\n" + "     @Html.EditorFor(model => model.{0}, new {1} htmlAttributes = new {1} @class = \"form-control\"{2} {2})",
                                    strFldName, "{", "}");
                                strCodeForCs.AppendFormat("\r\n" + "     @Html.ValidationMessageFor(model => model.{0}, \"\", new {1} @class = \"text-danger\" {2})",
                                    strFldName, "{", "}");
                                strCodeForCs.Append("\r\n" + " }");
                                strCodeForCs.Append("\r\n" + " else");
                                strCodeForCs.Append("\r\n" + " {");
                                strCodeForCs.AppendFormat("\r\n" + "     @Html.TextBoxFor(model => model.{0}, new {1} @readonly = \"readonly\", @class = \"form-control\" {2})",
                                    strFldName, "{", "}");
                                strCodeForCs.Append("\r\n" + " }");
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "     @Html.EditorFor(model => model.{0}, new {1} htmlAttributes = new {1} @class = \"form-control\"{2} {2})",
                                  strFldName, "{", "}");
                                strCodeForCs.AppendFormat("\r\n" + "     @Html.ValidationMessageFor(model => model.{0}, \"{1}不能为空!\", new {2} @class = \"text-danger\" {3})",
                                    strFldName, strCaption, "{", "}");
                                strCodeForCs.Append("\r\n" + "           <asp:RequiredFieldValidator ID=\"RequiredFieldValidator2\" runat=\"server\"");
                                strCodeForCs.AppendFormat("\r\n" + "                 ControlToValidate=\"{0}\" Display=\"None\" ErrorMessage=\"请输入{1}\"></asp:RequiredFieldValidator>",
                                    strFldName, strCaption);
                            }
                            //strCodeForCs.Append("\r\n" + " </div>");
                            strCodeForCs.Append("\r\n" + "</td>");

                            break;
                    }
                    //strCodeForCs.Append("\r\n" + "                        </div>");
                    strCodeForCs.Append("\r\n" + "</tr>");


                    intZIndex += 1;
                    intCurrTop += 25;

                }
                strCodeForCs.Append("\r\n" + "  </table>");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }

            return strCodeForCs.ToString();
        }
        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(Mvc_ViewAjax4CSharp);
                MethodInfo mt = t.GetMethod(strFuncName, BindingFlags.Instance | BindingFlags.Public);

                if (mt == null)
                {
                    string strMsg = string.Format("在类中没有相应的函数:{0}.(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                else
                {
                    //                string str = (string)mt.Invoke(null, new object[] { "1234567890123"    });
                    if (mt.GetParameters().Length == 0)
                    {
                        strCode = (string)mt.Invoke(this, null);
                    }
                    else if (mt.GetParameters().Length == 1)
                    {
                        strCode = (string)mt.Invoke(this, new object[] { objvFunction4GeneCodeEN });
                    }
                    //Console.WriteLine(str);
                }

                return strCode;
            }
            catch (Exception objException)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strErrMsg = objException.Message;
                if (strErrMsg == "调用的目标发生了异常。")
                {
                    strErrMsg = objException.InnerException.Message;
                }
                sbMessage.AppendFormat("在生成函数:{0}时出错. \r\n出错信息:{1}.", strFuncName, strErrMsg);
                throw new Exception(sbMessage.ToString());
            }
        }
        public override void GetClsName()
        {
            this.ClsName = string.Format("{0}CRUDAjax", objViewInfoENEx.TabName);
            objViewInfoENEx.ClsName = this.ClsName;
        }
  
        public string Gen_MvcView_Partial_EditRegion()
        {
            string strFuncName = "";
            if (objViewInfoENEx.arrEditRegionFldSet4InUse == null)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有编辑区域。请检查!", strViewName);
                sbMessage.Append("\r\n当前界面的功能:查询(Q)、修改(U)、删除(D)、添加(I)。");
                throw new clsDbObjException(sbMessage.ToString());
            }
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;

            try
            {                
                strCodeForCs.AppendFormat("\r\n" + "<div id = \"divEdit\">");
                strCodeForCs.AppendFormat("\r\n" + "</div>");
                //strCodeForCs.AppendFormat("\r\n" + "@Html.Partial(\"{0}EditAjax\")", objViewInfoENEx.TabName_In);
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }

            return strCodeForCs.ToString();
        }
        public string Gen_MvcView_Js_DdlSelected()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            List<string> arrTabName = new List<string>();
            try
            {
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd
                    || objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate)
                {
                    strCodeForCs.Append("\r\n" + "//1、为下拉框设置数据源,绑定列表数据");
                    foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                    {
                        if (objEditRegionFldsEx.InUse == false) continue;
                        if (objEditRegionFldsEx.objCtlType.CtlTypeName.Contains("DropDownList") == true)
                        {
                            if (objEditRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                            {
                                //if (arrTabName.Contains("TrueAndFalse") == false)
                                //{
                                //    arrTabName.Add("TrueAndFalse");
                                //    strCodeForCs.Append("\r\n" + "  ViewData[\"TrueAndFalseList\"] = clsPubFun.GetSliLst4TrueAndFalse();");
                                //}
                                using (JsFunction objJsFunc = new JsFunction())
                                {
                                    objJsFunc.funcName = string.Format("{0}Selected()", objEditRegionFldsEx.CtrlId);
                                    objJsFunc.sbText.AppendFormat("\r\n" + "function {0}Selected()", objEditRegionFldsEx.CtrlId);
                                    objJsFunc.sbText.Append("\r\n" + "{");
                                    objJsFunc.sbText.AppendFormat("\r\n" + "    var {1} = $('#{0} option:selected').val();        ",
                                        objEditRegionFldsEx.CtrlId, objEditRegionFldsEx.FldName);
                                    objJsFunc.sbText.Append("\r\n" + "    /**");

                                    objJsFunc.sbText.Append("\r\n" + "    $.ajax(");
                                    objJsFunc.sbText.Append("\r\n" + "    {");
                                    objJsFunc.sbText.AppendFormat("\r\n" + "        url: '/{0}/{1}Selected?{2}=' + {2},",
                                        objViewInfoENEx.TabName, objEditRegionFldsEx.CtrlId, objEditRegionFldsEx.FldName);
                                    objJsFunc.sbText.Append("\r\n" + "        type: 'GET',");
                                    objJsFunc.sbText.Append("\r\n" + "        data: \"\",");
                                    objJsFunc.sbText.Append("\r\n" + "        contentType: 'application/json; charset=utf-8',");
                                    objJsFunc.sbText.Append("\r\n" + "        success: function(data:any) {");
                                    objJsFunc.sbText.Append("\r\n" + "            var select = $('#ddlSubType');");
                                    objJsFunc.sbText.Append("\r\n" + "            select.empty();           ");
                                    objJsFunc.sbText.Append("\r\n" + "            $.each(data.SubTypeLst, function(index, itemData) {");
                                    objJsFunc.sbText.Append("\r\n" + "                select.append($('<option/>', {");
                                    objJsFunc.sbText.Append("\r\n" + "                    value: itemData.Value,");
                                    objJsFunc.sbText.Append("\r\n" + "                    text: itemData.Text");
                                    objJsFunc.sbText.Append("\r\n" + "                }));");
                                    objJsFunc.sbText.Append("\r\n" + "            });");
                                    objJsFunc.sbText.Append("\r\n" + "        },");
                                    objJsFunc.sbText.Append("\r\n" + "        error: function(e) {");
                                    objJsFunc.sbText.Append("\r\n" + "            alert(e);");
                                    objJsFunc.sbText.Append("\r\n" + "        }");
                                    objJsFunc.sbText.Append("\r\n" + "    });");
                                    objJsFunc.sbText.Append("\r\n" + "    **/");

                                    objJsFunc.sbText.Append("\r\n" + "}");

                                    arrJsFunction.Add(objJsFunc);
                                }
                            }
                            else
                            {
                                clsPrjTabEN objPrjTabEN_CodeTab = clsPrjTabBLEx.GetObjByTabIdEx(objEditRegionFldsEx.DsTabId);
                                if (objPrjTabEN_CodeTab == null)
                                {
                                    string strMsg = string.Format("在界面编辑区,{0}下拉框的数据源表没有设置,请检查!({1})",
                                        objEditRegionFldsEx.FldName,
                                        clsStackTrace.GetCurrClassFunction());
                                    throw new Exception(strMsg);
                                }

                                using (JsFunction objJsFunc = new JsFunction())
                                {
                                    objJsFunc.funcName = string.Format("{0}Selected()", objEditRegionFldsEx.CtrlId);

                                    objJsFunc.sbText.AppendFormat("\r\n" + "function {0}Selected()", objEditRegionFldsEx.CtrlId);
                                    objJsFunc.sbText.Append("\r\n" + "{");
                                    objJsFunc.sbText.AppendFormat("\r\n" + "    var {1} = $('#{0} option:selected').val();        ",
                                        objEditRegionFldsEx.CtrlId, objEditRegionFldsEx.FldName);
                                    objJsFunc.sbText.Append("\r\n" + "    /**");
                                    objJsFunc.sbText.Append("\r\n" + "    $.ajax(");
                                    objJsFunc.sbText.Append("\r\n" + "    {");
                                    objJsFunc.sbText.AppendFormat("\r\n" + "        url: '/{0}/{1}Selected?{2}=' + {2},",
                                        objViewInfoENEx.TabName, objEditRegionFldsEx.CtrlId, objEditRegionFldsEx.FldName);
                                    objJsFunc.sbText.Append("\r\n" + "        type: 'GET',");
                                    objJsFunc.sbText.Append("\r\n" + "        data: \"\",");
                                    objJsFunc.sbText.Append("\r\n" + "        contentType: 'application/json; charset=utf-8',");
                                    objJsFunc.sbText.Append("\r\n" + "        success: function(data:any) {");
                                    objJsFunc.sbText.Append("\r\n" + "            var select = $('#ddlSubType');");
                                    objJsFunc.sbText.Append("\r\n" + "            select.empty();           ");
                                    objJsFunc.sbText.Append("\r\n" + "            $.each(data.SubTypeLst, function(index, itemData) {");
                                    objJsFunc.sbText.Append("\r\n" + "                select.append($('<option/>', {");
                                    objJsFunc.sbText.Append("\r\n" + "                    value: itemData.Value,");
                                    objJsFunc.sbText.Append("\r\n" + "                    text: itemData.Text");
                                    objJsFunc.sbText.Append("\r\n" + "                }));");
                                    objJsFunc.sbText.Append("\r\n" + "            });");
                                    objJsFunc.sbText.Append("\r\n" + "        },");
                                    objJsFunc.sbText.Append("\r\n" + "        error: function(e) {");
                                    objJsFunc.sbText.Append("\r\n" + "            alert(e);");
                                    objJsFunc.sbText.Append("\r\n" + "        }");
                                    objJsFunc.sbText.Append("\r\n" + "    });");
                                    objJsFunc.sbText.Append("\r\n" + "    **/");

                                    objJsFunc.sbText.Append("\r\n" + "}");
                                    arrJsFunction.Add(objJsFunc);
                                }
                            }
                        }
                    }
                }


                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.objCtlType.CtlTypeName.Contains("DropDownList") == true)
                    {
                        if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                        {
                            //if (arrTabName.Contains("TrueAndFalse") == false)
                            //{
                            //    arrTabName.Add("TrueAndFalse");
                            //    strCodeForCs.Append("\r\n" + "  ViewData[\"TrueAndFalseList\"] = clsPubFun.GetSliLst4TrueAndFalse();");
                            //}
                            using (JsFunction objJsFunc = new JsFunction())
                            {
                                objJsFunc.funcName = string.Format("{0}Selected()", objQryRegionFldsEx.CtrlId());
                                objJsFunc.sbText.AppendFormat("\r\n" + "function {0}Selected()", objQryRegionFldsEx.CtrlId());
                                objJsFunc.sbText.Append("\r\n" + "{");
                                objJsFunc.sbText.AppendFormat("\r\n" + "    var {1} = $('#{0} option:selected').val();        ",
                                    objQryRegionFldsEx.CtrlId(), objQryRegionFldsEx.FldName);
                                objJsFunc.sbText.Append("\r\n" + "    /**");

                                objJsFunc.sbText.Append("\r\n" + "    $.ajax(");
                                objJsFunc.sbText.Append("\r\n" + "    {");
                                objJsFunc.sbText.AppendFormat("\r\n" + "        url: '/{0}/{1}Selected?{2}=' + {2},",
                                    objViewInfoENEx.TabName, objQryRegionFldsEx.CtrlId(), objQryRegionFldsEx.FldName);
                                objJsFunc.sbText.Append("\r\n" + "        type: 'GET',");
                                objJsFunc.sbText.Append("\r\n" + "        data: \"\",");
                                objJsFunc.sbText.Append("\r\n" + "        contentType: 'application/json; charset=utf-8',");
                                objJsFunc.sbText.Append("\r\n" + "        success: function(data:any) {");
                                objJsFunc.sbText.Append("\r\n" + "            var select = $('#ddlSubType');");
                                objJsFunc.sbText.Append("\r\n" + "            select.empty();           ");
                                objJsFunc.sbText.Append("\r\n" + "            $.each(data.SubTypeLst, function(index, itemData) {");
                                objJsFunc.sbText.Append("\r\n" + "                select.append($('<option/>', {");
                                objJsFunc.sbText.Append("\r\n" + "                    value: itemData.Value,");
                                objJsFunc.sbText.Append("\r\n" + "                    text: itemData.Text");
                                objJsFunc.sbText.Append("\r\n" + "                }));");
                                objJsFunc.sbText.Append("\r\n" + "            });");
                                objJsFunc.sbText.Append("\r\n" + "        },");
                                objJsFunc.sbText.Append("\r\n" + "        error: function(e) {");
                                objJsFunc.sbText.Append("\r\n" + "            alert(e);");
                                objJsFunc.sbText.Append("\r\n" + "        }");
                                objJsFunc.sbText.Append("\r\n" + "    });");
                                objJsFunc.sbText.Append("\r\n" + "    **/");

                                objJsFunc.sbText.Append("\r\n" + "}");

                                arrJsFunction.Add(objJsFunc);
                            }
                        }
                        else
                        {
                            clsPrjTabEN objPrjTabEN_CodeTab = clsPrjTabBLEx.GetObjByTabIdEx(objQryRegionFldsEx.DsTabId);
                            //clsFieldTabEN objFieldTab_ValueField = clsFieldTabBL.GetObjByFldIdCache(objQryRegionFldsEx.DsDataValueFieldId, objViewInfoENEx.PrjId);
                            //clsFieldTabEN objFieldTabEN_TextField = clsFieldTabBL.GetObjByFldIdCache(objQryRegionFldsEx.Ds_DataTextFieldId, objViewInfoENEx.PrjId);

                            if (objPrjTabEN_CodeTab == null)
                            {
                                string strMsg = string.Format("在界面查询区,{0}下拉框的数据源表没有设置,请检查!({1})",
                                    objQryRegionFldsEx.FldName,
                                    clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                            }
                            //if (objFieldTab_ValueField == null)
                            //{
                            //    string strMsg = string.Format("在界面查询区,{0}下拉框的数据源值字段没有设置,请检查!({1})",
                            //        objQryRegionFldsEx.FldName,
                            //        clsStackTrace.GetCurrClassFunction());
                            //    throw new Exception(strMsg);
                            //}
                            //if (objFieldTabEN_TextField == null)
                            //{
                            //    string strMsg = string.Format("在界面查询区,{0}下拉框的数据源文本字段没有设置,请检查!({1})",
                            //        objQryRegionFldsEx.FldName,
                            //        clsStackTrace.GetCurrClassFunction());
                            //    throw new Exception(strMsg);
                            //}

                            using (JsFunction objJsFunc = new JsFunction())
                            {
                                objJsFunc.funcName = string.Format("{0}Selected()", objQryRegionFldsEx.CtrlId());
                                objJsFunc.sbText.AppendFormat("\r\n" + "function {0}Selected()", objQryRegionFldsEx.CtrlId());
                                objJsFunc.sbText.Append("\r\n" + "{");
                                objJsFunc.sbText.AppendFormat("\r\n" + "    var {1} = $('#{0} option:selected').val();        ",
                                    objQryRegionFldsEx.CtrlId(), objQryRegionFldsEx.FldName);
                                objJsFunc.sbText.Append("\r\n" + "    /**");

                                objJsFunc.sbText.Append("\r\n" + "    $.ajax(");
                                objJsFunc.sbText.Append("\r\n" + "    {");
                                objJsFunc.sbText.AppendFormat("\r\n" + "        url: '/{0}/{1}Selected?{2}=' + {2},",
                                    objViewInfoENEx.TabName, objQryRegionFldsEx.CtrlId(), objQryRegionFldsEx.FldName);
                                objJsFunc.sbText.Append("\r\n" + "        type: 'GET',");
                                objJsFunc.sbText.Append("\r\n" + "        data: \"\",");
                                objJsFunc.sbText.Append("\r\n" + "        contentType: 'application/json; charset=utf-8',");
                                objJsFunc.sbText.Append("\r\n" + "        success: function(data:any) {");
                                objJsFunc.sbText.Append("\r\n" + "            var select = $('#ddlSubType');");
                                objJsFunc.sbText.Append("\r\n" + "            select.empty();           ");
                                objJsFunc.sbText.Append("\r\n" + "            $.each(data.SubTypeLst, function(index, itemData) {");
                                objJsFunc.sbText.Append("\r\n" + "                select.append($('<option/>', {");
                                objJsFunc.sbText.Append("\r\n" + "                    value: itemData.Value,");
                                objJsFunc.sbText.Append("\r\n" + "                    text: itemData.Text");
                                objJsFunc.sbText.Append("\r\n" + "                }));");
                                objJsFunc.sbText.Append("\r\n" + "            });");
                                objJsFunc.sbText.Append("\r\n" + "        },");
                                objJsFunc.sbText.Append("\r\n" + "        error: function(e) {");
                                objJsFunc.sbText.Append("\r\n" + "            alert(e);");
                                objJsFunc.sbText.Append("\r\n" + "        }");
                                objJsFunc.sbText.Append("\r\n" + "    });");
                                objJsFunc.sbText.Append("\r\n" + "    **/");

                                objJsFunc.sbText.Append("\r\n" + "}");

                                arrJsFunction.Add(objJsFunc);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

    }
}
