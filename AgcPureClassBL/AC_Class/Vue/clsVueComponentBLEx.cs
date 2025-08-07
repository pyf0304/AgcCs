using Agc.PureClass;
using AGC.BusinessLogic;
using AGC.Entity;
using AGC.PureClass;
using AgcCommBase;
using com.taishsoft.common;
using System;
using System.Text;
using System.Web.UI.HtmlControls;

namespace AGC.PureClassEx
{
    public static class clsVueComponentBLEx_Static
    {
        /// <summary>
        /// 生成该对象相关的代码
        /// </summary>
        /// <param name="objVueComponentEx">按钮对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GeneCode(this VueComponentEx objVueComponentEx, enumApplicationType intApplicationTypeId,
            StringBuilder strCodeForCs)
        {
            switch (intApplicationTypeId)
            {
                case enumApplicationType.WebApp_2:
                    break;
                case enumApplicationType.AspMvcAjaxApp_20:
                case enumApplicationType.AspMvcApp_13:
                case enumApplicationType.AspMvcApp_TS_16:
                    break;
                case enumApplicationType.SpaAppInCore_TS_18:
                case enumApplicationType.VueAppInCore_TS_30:
                    break;
                default:
                    var objApp = clsApplicationTypeBL.GetObjByApplicationTypeIdCache((int)intApplicationTypeId);
                    var strMsg = string.Format("应用:[{0}]在函数Switch中没有被处理.(in {1})", objApp.ApplicationTypeName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                    //break;
            }

            string strActionId = AgcPubFun.getASPNETID();
            //       < input value = "重序" id = "btnReOrder" name = "action:ReOrder" type = "submit" class="btn btn-outline-info" />
            strCodeForCs.Append("\r\n" + $"<{objVueComponentEx.ComponentName} ");
            strCodeForCs.Append("\r\n" + $"ref=\"{objVueComponentEx.RefName}\" ");

            //生成控件的Value
            clsASPControlBLEx.GC4Value(objVueComponentEx, strCodeForCs);

            //生成控件的Id、Name
            clsASPControlBLEx.GC4IdName(objVueComponentEx, strCodeForCs);

            //生成控件的Type
            clsASPControlBLEx.GC4Type(objVueComponentEx, strCodeForCs);

            //生成控件的样式
            clsASPControlBLEx.GC4Style(objVueComponentEx, strCodeForCs);

            //生成控件的Tag
            clsASPControlBLEx.GC4Tag(objVueComponentEx, strCodeForCs);

            //生成控件的尺寸-高、宽
            clsASPControlBLEx.GC4Size(objVueComponentEx, strCodeForCs);
            //生成控件的边界尺寸-即与四周的距离
            clsASPControlBLEx.GC4Margin(objVueComponentEx, strCodeForCs);


            foreach (clsVueProp objProp in objVueComponentEx.Props)
            {
                if (string.IsNullOrEmpty(objProp.PropName) == false)
                {
                    strCodeForCs.Append("\r\n" + $":{objProp.PropName}=\"{objProp.PropValue}\"");
                }
            }
            foreach (clsVueEvent objEvent in objVueComponentEx.Events)
            {
                if (string.IsNullOrEmpty(objEvent.EventName) == false)
                {
                    strCodeForCs.Append("\r\n" + $"@{objEvent.EventName}=\"{objEvent.EventValue}\"");
                }
            }
            if (string.IsNullOrEmpty(objVueComponentEx.OnClick) == false)
            {
                strCodeForCs.AppendFormat(" onclick=\"{0}\"",
                    objVueComponentEx.OnClick);
            }

            //生成控件的样式
            clsASPControlBLEx.GC4Text(objVueComponentEx, strCodeForCs);

            //生成控件的约束-即与四周控件的约束关系
            clsASPControlBLEx.GC4Constraint(objVueComponentEx, strCodeForCs);
            //strCodeForCs.AppendFormat(" runat=\"server\" ");

            strCodeForCs.AppendFormat(">");
            strCodeForCs.Append("\r\n" + $"</{objVueComponentEx.ComponentName}>");


        }
        public static void GeneCode4Html(this VueComponentEx objVueComponentEx, enumApplicationType intApplicationTypeId,
      StringBuilder strCodeForCs)
        {
            string strActionId = AgcPubFun.getASPNETID();


            strCodeForCs.AppendFormat("\r\n" + "<button ");

            clsASPControlBLEx.GC4Type(objVueComponentEx, strCodeForCs);

            //生成控件的Id、Name
            clsASPControlBLEx.GC4IdName(objVueComponentEx, strCodeForCs);

            clsASPControlBLEx.GC4Data_dismiss(objVueComponentEx, strCodeForCs);

            clsASPControlBLEx.GC4Aria_label(objVueComponentEx, strCodeForCs);

            //生成控件的Tag
            clsASPControlBLEx.GC4Tag(objVueComponentEx, strCodeForCs);

            //生成控件的样式
            //clsASPControlBLEx.GC4Style(objVueComponentEx, strCodeForCs);
            if (string.IsNullOrEmpty(objVueComponentEx.CssClass) == false)
            {
                strCodeForCs.AppendFormat(" class=\"{0}\"",
                    objVueComponentEx.CssClass);
            }
            else if (string.IsNullOrEmpty(objVueComponentEx.Class) == false)
            {
                strCodeForCs.AppendFormat(" class=\"{0}\"",
                    objVueComponentEx.Class);
            }
            if (string.IsNullOrEmpty(objVueComponentEx.Style) == false)
            {
                strCodeForCs.AppendFormat(" style=\"{0}\"",
                    objVueComponentEx.Style);
            }
            //生成控件的尺寸-高、宽
            //clsASPControlBLEx.GC4Size(objVueComponentEx, strCodeForCs);
            //生成控件的边界尺寸-即与四周的距离
            clsASPControlBLEx.GC4Margin(objVueComponentEx, strCodeForCs);

            if (string.IsNullOrEmpty(objVueComponentEx.OnClick4Html) == false)
            {
                strCodeForCs.AppendFormat(" @click=\"btn_Click('{0}', '')\"",
                    objVueComponentEx.CtrlId);
            }


            clsASPControlBLEx.GC4Tabindex(objVueComponentEx, strCodeForCs);
            clsASPControlBLEx.GC4Aria_labelledby(objVueComponentEx, strCodeForCs);
            clsASPControlBLEx.GC4Aria_hidden(objVueComponentEx, strCodeForCs);

            //生成控件的样式
            //clsASPControlBLEx.GC4Text(objVueComponentEx, strCodeForCs);

            //生成控件的约束-即与四周控件的约束关系
            //clsASPControlBLEx.GC4Constraint(objVueComponentEx, strCodeForCs);
            strCodeForCs.Append(">");
            if (string.IsNullOrEmpty(objVueComponentEx.Value) == false)
            {
                strCodeForCs.AppendFormat("{0}",
                       objVueComponentEx.Value);
            }
            else if (string.IsNullOrEmpty(objVueComponentEx.Text) == false)
            {
                strCodeForCs.AppendFormat("{0}",
                       objVueComponentEx.Text);
            }

            foreach (ASPControlEx objSubASPControlENEx in objVueComponentEx.arrSubAspControlLst2)
            {
                //if (objSubASPControlENEx.CtlTypeId != enumCtlTypeAbbr.ASPNETAutoresizingMask) continue;
                objSubASPControlENEx.GeneCode(intApplicationTypeId, strCodeForCs); ;
            }

            strCodeForCs.AppendFormat("</button>");
        }

        public static void GeneCode4Mvc(this VueComponentEx objVueComponentEx, enumApplicationType intApplicationTypeId,
     StringBuilder strCodeForCs)
        {

            string strActionId = AgcPubFun.getASPNETID();

            //       < input value = "重序" id = "btnReOrder" name = "action:ReOrder" type = "submit" class="btn btn-outline-info" />
            //< input value = "查询" id = "btnQuery" Name = "action:QueryAjax" type = "submit" class="btn btn-outline-warning" onclick="OnClickInFeatureRegion()" />

            strCodeForCs.AppendFormat("\r\n" + "<input ");

            //生成控件的Value
            clsASPControlBLEx.GC4Value(objVueComponentEx, strCodeForCs);

            //生成控件的Id、Name
            clsASPControlBLEx.GC4Id(objVueComponentEx, strCodeForCs);
            clsASPControlBLEx.GC4Name4MvcAjax(objVueComponentEx, strCodeForCs);

            //生成控件的Type
            clsASPControlBLEx.GC4Type(objVueComponentEx, strCodeForCs);
            if (string.IsNullOrEmpty(objVueComponentEx.Class) == false)
            {
                strCodeForCs.AppendFormat(" class=\"{0}\"",
                    objVueComponentEx.Class);
            }
            ////生成控件的样式
            //clsASPControlBLEx.GC4Style(objVueComponentEx, strCodeForCs);

            //生成控件的Tag
            clsASPControlBLEx.GC4Tag(objVueComponentEx, strCodeForCs);

            //生成控件的尺寸-高、宽
            clsASPControlBLEx.GC4Size(objVueComponentEx, strCodeForCs);
            //生成控件的边界尺寸-即与四周的距离
            clsASPControlBLEx.GC4Margin(objVueComponentEx, strCodeForCs);

            if (string.IsNullOrEmpty(objVueComponentEx.OnClick4MvcAjax) == false)
            {
                strCodeForCs.AppendFormat(" onclick=\"{0}\"",
                    objVueComponentEx.OnClick4MvcAjax);
            }

            //生成控件的样式
            //       clsASPControlBLEx.GC4Text(objVueComponentEx, strCodeForCs);

            //生成控件的约束-即与四周控件的约束关系
            clsASPControlBLEx.GC4Constraint(objVueComponentEx, strCodeForCs);
            //strCodeForCs.AppendFormat(" runat=\"server\" ");

            strCodeForCs.AppendFormat("/>");


        }

        public static void GeneHtmlControl(this VueComponentEx objVueComponentEx, HtmlContainerControl objContainer)
        {
            string strActionId = AgcPubFun.getASPNETID();
            HtmlInputButton objHtmlInputButton = new HtmlInputButton();
            objHtmlInputButton.ID = objVueComponentEx.CtrlId;

            objHtmlInputButton.Name = objVueComponentEx.CtrlName;
            objHtmlInputButton.Attributes["class"] = objVueComponentEx.Class;
            objHtmlInputButton.Value = objVueComponentEx.Value;
            if (string.IsNullOrEmpty(objVueComponentEx.OnClick4Html) == false)
            {
                objHtmlInputButton.Attributes.Add("onclick", objVueComponentEx.OnClick4Html);
            }

            if (objVueComponentEx.Is4Mvc == true)
            {


                //生成控件的Type
                //clsASPControlBLEx.GC4Type(objVueComponentEx, strCodeForCs);

                //生成控件的样式
                //objHtmlInputButton.Style = objVueComponentEx.Style;

                //clsASPControlBLEx.GC4Style(objVueComponentEx, strCodeForCs);


                //生成控件的尺寸-高、宽
                //clsASPControlBLEx.GC4Size(objVueComponentEx, strCodeForCs);
                //生成控件的边界尺寸-即与四周的距离
                //clsASPControlBLEx.GC4Margin(objVueComponentEx, strCodeForCs);

                //if (string.IsNullOrEmpty(objVueComponentEx.OnClick) == false)
                //{
                //    strCodeForCs.AppendFormat(" onclick=\"{0}\"",
                //        objVueComponentEx.OnClick);
                //}

                objContainer.Controls.Add(objHtmlInputButton);
                return;
            }
            else
            {
                objHtmlInputButton.Attributes["class"] = objVueComponentEx.CssClass;

                objHtmlInputButton.Value = objVueComponentEx.Text;

                ////生成控件的Id、Name
                //clsASPControlBLEx.GC4IdName(objVueComponentEx, strCodeForCs);

                ////生成控件的Tag
                //clsASPControlBLEx.GC4Tag(objVueComponentEx, strCodeForCs);

                ////生成控件的样式
                //clsASPControlBLEx.GC4Style(objVueComponentEx, strCodeForCs);

                ////生成控件的尺寸-高、宽
                //clsASPControlBLEx.GC4Size(objVueComponentEx, strCodeForCs);
                ////生成控件的边界尺寸-即与四周的距离
                //clsASPControlBLEx.GC4Margin(objVueComponentEx, strCodeForCs);

                //if (string.IsNullOrEmpty(objVueComponentEx.OnClick) == false)
                //{
                //    strCodeForCs.AppendFormat(" OnClick=\"{0}\"",
                //        objVueComponentEx.OnClick);
                //}

                ////生成控件的样式
                //clsASPControlBLEx.GC4Text(objVueComponentEx, strCodeForCs);

                ////生成控件的约束-即与四周控件的约束关系
                //clsASPControlBLEx.GC4Constraint(objVueComponentEx, strCodeForCs);
                //strCodeForCs.AppendFormat(" runat=\"server\" ");

                objContainer.Controls.Add(objHtmlInputButton);
                return;
            }
            //foreach (ASPControlEx objSubASPControlENEx in objVueComponentEx.arrSubAspControlLst2)
            //{
            //    //if (objSubASPControlENEx.CtlTypeId != enumCtlTypeAbbr.ASPNETAutoresizingMask) continue;
            //    objSubASPControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);;
            //}


        }
    }

    /// <summary>
    /// ASPNET按钮(ASPNETButton)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsVueComponentBLEx
    {

        public static void GeneCodeBak(VueComponentEx objVueComponentEx, enumApplicationType intApplicationTypeId, StringBuilder strCodeForCs)
        {
            //<asp:Button ID = "lblViewTitle" runat = "server" CssClass = "PageTitleH1" Height = "16px">性别表维护
            //       </asp:Button>
            strCodeForCs.AppendFormat("\r\n" + "<asp:Button ID = \"{0}\" Style = \"z-index: 105;\"  runat = \"server\" ", objVueComponentEx.AspControlId);
            if (string.IsNullOrEmpty(objVueComponentEx.CssClass) == false)
            {
                strCodeForCs.AppendFormat("CssClass = \"{0}\"  ", objVueComponentEx.CssClass);
            }
            if (objVueComponentEx.Width > 0)
            {
                strCodeForCs.AppendFormat("Width = \"{0}px\"  ", objVueComponentEx.Width);
            }
            if (objVueComponentEx.Height > 0)
            {
                strCodeForCs.AppendFormat("Height = \"{0}px\"  ", objVueComponentEx.Height);
            }

            if (string.IsNullOrEmpty(objVueComponentEx.Text) == false)
            {
                strCodeForCs.AppendFormat("Text = \"{0}\"  ", objVueComponentEx.Text);
            }
            if (string.IsNullOrEmpty(objVueComponentEx.OnClick) == false)
            {
                strCodeForCs.AppendFormat("OnClick = \"{0}\"  ", objVueComponentEx.OnClick);
            }
            strCodeForCs.Append(">");

            foreach (ASPControlEx objSubASPControlENEx in objVueComponentEx.arrSubAspControlLst2)
            {
                objSubASPControlENEx.GeneCode(intApplicationTypeId, strCodeForCs); ;
            }
            strCodeForCs.Append("\r\n" + "</asp:Button>");

        }



        /// <summary>
        /// 生成字段变量定义的代码
        /// </summary>
        /// <param name="objVueComponentEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarDef(VueComponentEx objVueComponentEx,
            StringBuilder strCodeForCs)
        {

            strCodeForCs.AppendFormat("\r\n" + "private Button {0};",
                objVueComponentEx.CtrlId);

        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objVueComponentEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind(VueComponentEx objVueComponentEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "btn{0} = (Button)findViewById(R.id.btn{0}); ",
                objVueComponentEx.CtrlId);

        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objVueComponentEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind4ListView(VueComponentEx objVueComponentEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "btn{0} = (Button)view.findViewById(R.id.btn{0}); ",
                objVueComponentEx.CtrlId);

        }



        /// <summary>
        /// 建立修改按钮
        /// </summary>
        /// <returns></returns>
        public static VueComponentEx GetbtnUpdate4Gv(bool bolIs4Mvc = false, bool bolIs4Ajax = false)
        {
            VueComponentEx objVueComponentEx = new VueComponentEx();
            objVueComponentEx.Is4Mvc = bolIs4Mvc;
            if (bolIs4Mvc == true)
            {
                // <input value="修改" id="btnUpdate" name="action:Update" type="submit" class="btn btn-outline-info" />
                objVueComponentEx.CtrlId = "btnUpdate";
                if (bolIs4Ajax == true)
                {
                    objVueComponentEx.CtrlName = "action:UpdateAjax";
                }
                else
                {
                    objVueComponentEx.CtrlName = "action:Update";
                }
                objVueComponentEx.type = "submit";
                objVueComponentEx.OnClick = "OnClickInFeatureRegion()";

                //objVueComponentEx.OnClick = "btnAddNewRec4Gv_Click";
                objVueComponentEx.Value = "修改";
                objVueComponentEx.Style = "";
                objVueComponentEx.Class = "btn btn-outline-info btn-sm text-nowrap";
                objVueComponentEx.CssClass = "";
                //objVueComponentEx.Width = 80;
                //objVueComponentEx.Height = 0;
            }
            else
            {
                objVueComponentEx.CtrlId = "btnUpdate4Gv";
                objVueComponentEx.OnClick = "btnUpdate4Gv_Click";
                objVueComponentEx.Text = "修改记录";
                objVueComponentEx.Style = "z-index: 107;";
                objVueComponentEx.CssClass = "btn btn-outline-info btn-sm";
                objVueComponentEx.Width = 80;
                objVueComponentEx.Height = 0;
            }
            return objVueComponentEx;
        }

        /// <summary>
        /// 建立详细信息按钮
        /// </summary>
        /// <returns></returns>
        public static VueComponentEx GetbtnDetail4Gv(bool bolIs4Mvc = false, bool bolIs4Ajax = false)
        {
            VueComponentEx objVueComponentEx = new VueComponentEx();
            objVueComponentEx.Is4Mvc = bolIs4Mvc;
            if (bolIs4Mvc == true)
            {
                //  <input value="下移" id="btnDownMove" name="action:DownMove" type="submit" class="btn btn-outline-info" />
                objVueComponentEx.CtrlId = "btnDetail";
                if (bolIs4Ajax == true)
                {
                    objVueComponentEx.CtrlName = "action:DetailAjax";
                }
                else
                {
                    objVueComponentEx.CtrlName = "action:Detail";
                }
                objVueComponentEx.type = "submit";
                objVueComponentEx.OnClick = "OnClickInFeatureRegion()";

                //objVueComponentEx.OnClick = "btnAddNewRec4Gv_Click";
                objVueComponentEx.Value = "详细";
                objVueComponentEx.Style = "";
                objVueComponentEx.Class = "btn btn-outline-info btn-sm text-nowrap";
                objVueComponentEx.CssClass = "";
                //objVueComponentEx.Width = 80;
                //objVueComponentEx.Height = 0;
            }
            else
            {
                objVueComponentEx.CtrlId = "btnDetail4Gv";
                objVueComponentEx.OnClick = "btnDetail4Gv_Click";
                objVueComponentEx.Text = "详细信息";
                objVueComponentEx.Style = "z-index: 107;";
                objVueComponentEx.CssClass = "btn btn-outline-info btn-sm";
                objVueComponentEx.Width = 80;
                objVueComponentEx.Height = 0;
            }
            return objVueComponentEx;
        }

        /// <summary>
        /// 建立删除按钮
        /// </summary>
        /// <returns></returns>
        public static VueComponentEx GetbtnDelete4Gv(bool bolIs4Mvc = false, bool bolIs4Ajax = false)
        {
            VueComponentEx objVueComponentEx = new VueComponentEx();
            objVueComponentEx.Is4Mvc = bolIs4Mvc;
            if (bolIs4Mvc == true)
            {
                // <input value="删除" id="btnDelete" name="action:DelRecords" type="submit" class="btn btn-outline-info" />
                objVueComponentEx.CtrlId = "btnDeletes";
                if (bolIs4Ajax == true)
                {
                    objVueComponentEx.CtrlName = "action:DeletesAjax";
                }
                else
                {
                    objVueComponentEx.CtrlName = "action:Deletes";
                }
                objVueComponentEx.type = "submit";
                objVueComponentEx.OnClick = "OnClickInFeatureRegion()";

                //objVueComponentEx.OnClick = "btnAddNewRec4Gv_Click";
                objVueComponentEx.Value = "删除";
                objVueComponentEx.Style = "";
                objVueComponentEx.Class = "btn btn-outline-info btn-sm text-nowrap";
                objVueComponentEx.CssClass = "";
                //objVueComponentEx.Width = 80;
                //objVueComponentEx.Height = 0;
            }
            else
            {
                objVueComponentEx.CtrlId = "btnDelete4Gv";
                objVueComponentEx.OnClick = "btnDelete4Gv_Click";
                objVueComponentEx.Text = "删除记录";
                objVueComponentEx.Style = "z-index: 107;";
                objVueComponentEx.CssClass = "btn btn-outline-info btn-sm";
                objVueComponentEx.Width = 80;
                objVueComponentEx.Height = 0;
            }
            return objVueComponentEx;
        }

        /// <summary>
        /// 建立删除按钮
        /// </summary>
        /// <returns></returns>
        public static VueComponentEx GetbtnDeleteBySign(bool bolIs4Mvc = false, bool bolIs4Ajax = false)
        {
            VueComponentEx objVueComponentEx = new VueComponentEx();
            objVueComponentEx.Is4Mvc = bolIs4Mvc;
            if (bolIs4Mvc == true)
            {
                // <input value="删除" id="btnDelete" name="action:DelRecords" type="submit" class="btn btn-outline-info" />
                objVueComponentEx.CtrlId = "btnDeleteBySign";
                if (bolIs4Ajax == true)
                {
                    objVueComponentEx.CtrlName = "action:DeleteBySignAjax";
                }
                else
                {
                    objVueComponentEx.CtrlName = "action:DeleteBySign";
                }
                objVueComponentEx.type = "submit";
                objVueComponentEx.OnClick = "OnClickInFeatureRegion()";

                //objVueComponentEx.OnClick = "btnAddNewRec4Gv_Click";
                objVueComponentEx.Value = "标志性删除";
                objVueComponentEx.Style = "";
                objVueComponentEx.Class = "btn btn-outline-info btn-sm text-nowrap";
                objVueComponentEx.CssClass = "";
                //objVueComponentEx.Width = 80;
                //objVueComponentEx.Height = 0;
            }
            else
            {
                objVueComponentEx.CtrlId = "btnDeleteBySign";
                objVueComponentEx.OnClick = "btnDeleteBySign_Click";
                objVueComponentEx.Text = "标志性删除";
                objVueComponentEx.Style = "z-index: 107;";
                objVueComponentEx.CssClass = "btn btn-outline-info btn-sm";
                objVueComponentEx.Width = 90;
                objVueComponentEx.Height = 0;
            }
            return objVueComponentEx;
        }

        public static VueComponentEx GetbtnUnDeleteBySign(bool bolIs4Mvc = false, bool bolIs4Ajax = false)
        {
            VueComponentEx objVueComponentEx = new VueComponentEx();
            objVueComponentEx.Is4Mvc = bolIs4Mvc;
            if (bolIs4Mvc == true)
            {
                // <input value="删除" id="btnDelete" name="action:DelRecords" type="submit" class="btn btn-outline-info" />
                objVueComponentEx.CtrlId = "btnUnDeleteBySign";
                if (bolIs4Ajax == true)
                {
                    objVueComponentEx.CtrlName = "action:UnDeleteBySignAjax";
                }
                else
                {
                    objVueComponentEx.CtrlName = "action:UnDeleteBySign";
                }
                objVueComponentEx.type = "submit";
                objVueComponentEx.OnClick = "OnClickInFeatureRegion()";

                //objVueComponentEx.OnClick = "btnAddNewRec4Gv_Click";
                objVueComponentEx.Value = "恢复删除";
                objVueComponentEx.Style = "";
                objVueComponentEx.Class = "btn btn-outline-info btn-sm text-nowrap";
                objVueComponentEx.CssClass = "";
                //objVueComponentEx.Width = 80;
                //objVueComponentEx.Height = 0;
            }
            else
            {
                objVueComponentEx.CtrlId = "btnUnDeleteBySign";
                objVueComponentEx.OnClick = "btnUnDeleteBySign_Click";
                objVueComponentEx.Text = "恢复删除";
                objVueComponentEx.Style = "z-index: 107;";
                objVueComponentEx.CssClass = "btn btn-outline-info btn-sm";
                objVueComponentEx.Width = 80;
                objVueComponentEx.Height = 0;
            }
            return objVueComponentEx;
        }


        /// <summary>
        /// 建立添加记录按钮
        /// </summary>
        /// <returns></returns>
        public static VueComponentEx GetbtnAddNewRec4Gv(bool bolIs4Mvc = false, bool bolIs4Ajax = false)
        {
            VueComponentEx objVueComponentEx = new VueComponentEx();
            objVueComponentEx.Is4Mvc = bolIs4Mvc;
            if (bolIs4Mvc == true)
            {

                // <input value="添加" id="btnCreate" name="action:Create" type="submit" class="btn btn-outline-info" />
                objVueComponentEx.CtrlId = "btnCreate";
                if (bolIs4Ajax == true)
                {
                    objVueComponentEx.CtrlName = "action:CreateAjax";
                }
                else
                {
                    objVueComponentEx.CtrlName = "action:Create";
                }
                objVueComponentEx.type = "submit";
                objVueComponentEx.OnClick = "OnClickInFeatureRegion()";

                //objVueComponentEx.OnClick = "btnAddNewRec4Gv_Click";
                objVueComponentEx.Value = "添加";
                objVueComponentEx.Style = "";
                objVueComponentEx.Class = "btn btn-outline-info btn-sm text-nowrap";
                objVueComponentEx.CssClass = "";
                //objVueComponentEx.Width = 80;
                //objVueComponentEx.Height = 0;
            }
            else
            {
                objVueComponentEx.CtrlId = "btnAddNewRec4Gv";
                objVueComponentEx.OnClick = "btnAddNewRec4Gv_Click";
                objVueComponentEx.Text = "添加记录";
                objVueComponentEx.Style = "z-index: 107;";
                objVueComponentEx.CssClass = "btn btn-outline-info btn-sm";
                objVueComponentEx.Width = 80;
                objVueComponentEx.Height = 0;
            }
            return objVueComponentEx;
        }
        public static VueComponentEx GetbtnQuery(bool bolIs4Mvc = false, bool bolIs4Ajax = false)
        {
            VueComponentEx objVueComponentEx = new VueComponentEx();
            objVueComponentEx.Is4Mvc = bolIs4Mvc;
            if (bolIs4Mvc == true)
            {

                // <input value="添加" id="btnCreate" name="action:Create" type="submit" class="btn btn-outline-info" />
                objVueComponentEx.CtrlId = "btnQuery";
                if (bolIs4Ajax == true)
                {
                    objVueComponentEx.CtrlName = "action:QueryAjax";
                }
                else
                {
                    objVueComponentEx.CtrlName = "action:Query";
                }
                objVueComponentEx.type = "submit";
                objVueComponentEx.OnClick = "OnClickInFeatureRegion()";

                //objVueComponentEx.OnClick = "btnAddNewRec4Gv_Click";
                objVueComponentEx.Value = "查询";
                objVueComponentEx.Style = "";
                objVueComponentEx.Class = "btn btn-outline-warning btn-sm text-nowrap";
                objVueComponentEx.CssClass = "";
                //objVueComponentEx.Width = 80;
                //objVueComponentEx.Height = 0;
            }
            else
            {
                objVueComponentEx.CtrlId = "btnQuery";
                objVueComponentEx.OnClick = "btnQuery_Click";
                objVueComponentEx.Text = "查询";
                objVueComponentEx.Style = "z-index: 107;";
                objVueComponentEx.CssClass = "btn btn-outline-warning btn-sm";
                //objVueComponentEx.Width = 80;
                objVueComponentEx.Height = 0;
            }
            return objVueComponentEx;
        }


        public static VueComponentEx GetbtnClone(bool bolIs4Mvc = false, bool bolIs4Ajax = false)
        {
            VueComponentEx objVueComponentEx = new VueComponentEx();
            objVueComponentEx.Is4Mvc = bolIs4Mvc;
            if (bolIs4Mvc == true)
            {

                // <input value="添加" id="btnCreate" name="action:Create" type="submit" class="btn btn-outline-info" />
                objVueComponentEx.CtrlId = "btnClone";
                if (bolIs4Ajax == true)
                {
                    objVueComponentEx.CtrlName = "action:CloneAjax";
                }
                else
                {
                    objVueComponentEx.CtrlName = "action:Clone";
                }
                objVueComponentEx.type = "submit";
                objVueComponentEx.OnClick = "OnClickInFeatureRegion()";

                //objVueComponentEx.OnClick = "btnAddNewRec4Gv_Click";
                objVueComponentEx.Value = "复制";
                objVueComponentEx.Style = "";
                objVueComponentEx.Class = "btn btn-outline-info btn-sm text-nowrap";
                objVueComponentEx.CssClass = "";
                //objVueComponentEx.Width = 80;
                //objVueComponentEx.Height = 0;
            }
            else
            {
                objVueComponentEx.CtrlId = "btnClone";
                objVueComponentEx.OnClick = "btnClone_Click";
                objVueComponentEx.Text = "复制";
                objVueComponentEx.Style = "z-index: 107;";
                objVueComponentEx.CssClass = "btn btn-outline-info btn-sm";
                objVueComponentEx.Width = 80;
                objVueComponentEx.Height = 0;
            }
            return objVueComponentEx;
        }


        //<td>
        //                    <asp:Button ID = "btnGoTop" runat="server" Height="24px" Style="z-index: 109; left: 616px;"
        //                        Text="移顶" Width="48px" OnClick="btnGoTop_Click" CssClass="btn btn-outline-info" />
        //                </td>
        //                <td>
        //                    <asp:Button ID = "btnUpMove" runat="server" Height="24px" OnClick="btnUpMove_Click"
        //                        Style="z-index: 109; left: 616px;" Text="上移" Width="48px" CssClass="btn btn-outline-info" />
        //                </td>
        //                <td>
        //                    <asp:Button ID = "btnDownMove" runat="server" Height="24px" OnClick="btnDownMove_Click"
        //                        Style="z-index: 110; left: 664px;" Text="下移" Width="48px" CssClass="btn btn-outline-info" />
        //                </td>
        //                <td>
        //                    <asp:Button ID = "btnGoBottum" runat="server" Height="24px" Style="z-index: 110; left: 664px;"
        //                        Text="移底" Width="48px" OnClick="btnGoBottum_Click" CssClass="btn btn-outline-info" />
        //                </td>
        //                <td>
        //                    <asp:Button ID = "btnReOrder" runat="server" Height="24px" OnClick="btnReOrder_Click"
        //                        Style="z-index: 111; left: 712px;" Text="重序" Width="40px" CssClass="btn btn-outline-info" />
        //                </td>
        /// <summary>
        /// 建立[移顶]按钮
        /// </summary>
        /// <returns></returns>
        public static VueComponentEx GetbtnGoTop(bool bolIs4Mvc = false, bool bolIs4Ajax = false)
        {
            VueComponentEx objVueComponentEx = new VueComponentEx();
            objVueComponentEx.Is4Mvc = bolIs4Mvc;
            if (bolIs4Mvc == true)
            {
                // <input value="移顶" id="btnGoTop" name="action:GoTop" type="submit" class="btn btn-outline-info" />
                objVueComponentEx.CtrlId = "btnGoTop";
                if (bolIs4Ajax == true)
                {
                    objVueComponentEx.CtrlName = "action:GoTopAjax";
                }
                else
                {
                    objVueComponentEx.CtrlName = "action:GoTop";
                }
                objVueComponentEx.type = "submit";
                objVueComponentEx.OnClick = "OnClickInFeatureRegion()";

                //objVueComponentEx.OnClick = "btnAddNewRec4Gv_Click";
                objVueComponentEx.Value = "移顶";
                objVueComponentEx.Style = "";
                objVueComponentEx.Class = "btn btn-outline-info btn-sm text-nowrap";
                objVueComponentEx.CssClass = "";
                //objVueComponentEx.Width = 80;
                //objVueComponentEx.Height = 0;
            }
            else
            {
                objVueComponentEx.CtrlId = "btnGoTop";
                objVueComponentEx.OnClick = "btnGoTop_Click";
                objVueComponentEx.Text = "移顶";
                objVueComponentEx.Style = "z-index: 107;";
                objVueComponentEx.CssClass = "btn btn-outline-info btn-sm";
                objVueComponentEx.Width = 48;
                objVueComponentEx.Height = 0;
            }
            return objVueComponentEx;
        }

        /// <summary>
        /// 建立[移底]按钮
        /// </summary>
        /// <returns></returns>
        public static VueComponentEx GetbtnGoBottum(bool bolIs4Mvc = false, bool bolIs4Ajax = false)
        {
            VueComponentEx objVueComponentEx = new VueComponentEx();
            objVueComponentEx.Is4Mvc = bolIs4Mvc;
            if (bolIs4Mvc == true)
            {
                //<input value="移底" id="btnGoBottum" name="action:GoBottum" type="submit" class="btn btn-outline-info" />
                objVueComponentEx.CtrlId = "btnGoBottum";
                if (bolIs4Ajax == true)
                {
                    objVueComponentEx.CtrlName = "action:GoBottumAjax";
                }
                else
                {
                    objVueComponentEx.CtrlName = "action:GoBottum";
                }
                objVueComponentEx.type = "submit";
                objVueComponentEx.OnClick = "OnClickInFeatureRegion()";

                //objVueComponentEx.OnClick = "btnAddNewRec4Gv_Click";
                objVueComponentEx.Value = "移底";
                objVueComponentEx.Style = "";
                objVueComponentEx.Class = "btn btn-outline-info btn-sm text-nowrap";
                objVueComponentEx.CssClass = "";
                //objVueComponentEx.Width = 80;
                //objVueComponentEx.Height = 0;
            }
            else
            {
                objVueComponentEx.CtrlId = "btnGoBottum";
                objVueComponentEx.OnClick = "btnGoBottum_Click";
                objVueComponentEx.Text = "移底";
                objVueComponentEx.Style = "z-index: 107;";
                objVueComponentEx.CssClass = "btn btn-outline-info btn-sm";
                objVueComponentEx.Width = 48;
                objVueComponentEx.Height = 0;
            }
            return objVueComponentEx;
        }

        /// <summary>
        /// 建立[重序]按钮
        /// </summary>
        /// <returns></returns>
        public static VueComponentEx GetbtnReOrder(bool bolIs4Mvc = false, bool bolIs4Ajax = false)
        {
            VueComponentEx objVueComponentEx = new VueComponentEx();
            objVueComponentEx.Is4Mvc = bolIs4Mvc;
            if (bolIs4Mvc == true)
            {
                //<input value="重序" id="btnReOrder" name="action:ReOrder" type="submit" class="btn btn-outline-info" />
                objVueComponentEx.CtrlId = "btnReOrder";
                if (bolIs4Ajax == true)
                {
                    objVueComponentEx.CtrlName = "action:ReOrderAjax";
                }
                else
                {
                    objVueComponentEx.CtrlName = "action:ReOrder";
                }
                objVueComponentEx.type = "submit";
                objVueComponentEx.OnClick = "OnClickInFeatureRegion()";

                //objVueComponentEx.OnClick = "btnAddNewRec4Gv_Click";
                objVueComponentEx.Value = "重序";
                objVueComponentEx.Style = "";
                objVueComponentEx.Class = "btn btn-outline-info btn-sm text-nowrap";
                objVueComponentEx.CssClass = "";
                //objVueComponentEx.Width = 80;
                //objVueComponentEx.Height = 0;
            }
            else
            {
                objVueComponentEx.CtrlId = "btnReOrder";
                objVueComponentEx.OnClick = "btnReOrder_Click";
                objVueComponentEx.Text = "重序";
                objVueComponentEx.Style = "z-index: 107;";
                objVueComponentEx.CssClass = "btn btn-outline-info btn-sm";
                objVueComponentEx.Width = 48;
                objVueComponentEx.Height = 0;
            }
            return objVueComponentEx;
        }

        /// <summary>
        /// 建立[上移]按钮
        /// </summary>
        /// <returns></returns>
        public static VueComponentEx GetbtnUpMove(bool bolIs4Mvc = false, bool bolIs4Ajax = false)
        {
            VueComponentEx objVueComponentEx = new VueComponentEx();
            objVueComponentEx.Is4Mvc = bolIs4Mvc;
            if (bolIs4Mvc == true)
            {
                //<input value="上移" id="btnUpMove" name="action:UpMove" type="submit" class="btn btn-outline-info" />
                objVueComponentEx.CtrlId = "btnUpMove";
                if (bolIs4Ajax == true)
                {
                    objVueComponentEx.CtrlName = "action:UpMoveAjax";
                }
                else
                {
                    objVueComponentEx.CtrlName = "action:UpMove";
                }
                objVueComponentEx.type = "submit";
                objVueComponentEx.OnClick = "OnClickInFeatureRegion()";

                //objVueComponentEx.OnClick = "btnAddNewRec4Gv_Click";
                objVueComponentEx.Value = "上移";
                objVueComponentEx.Style = "";
                objVueComponentEx.Class = "btn btn-outline-info btn-sm text-nowrap";
                objVueComponentEx.CssClass = "";
                //objVueComponentEx.Width = 80;
                //objVueComponentEx.Height = 0;
            }
            else
            {
                objVueComponentEx.CtrlId = "btnUpMove";
                objVueComponentEx.OnClick = "btnUpMove_Click";
                objVueComponentEx.Text = "上移";
                objVueComponentEx.Style = "z-index: 107;";
                objVueComponentEx.CssClass = "btn btn-outline-info btn-sm";
                objVueComponentEx.Width = 48;
                objVueComponentEx.Height = 0;
            }
            return objVueComponentEx;
        }

        /// <summary>
        /// 建立[下移]按钮
        /// </summary>
        /// <returns></returns>
        public static VueComponentEx GetbtnDownMove(bool bolIs4Mvc = false, bool bolIs4Ajax = false)
        {
            VueComponentEx objVueComponentEx = new VueComponentEx();
            objVueComponentEx.Is4Mvc = bolIs4Mvc;
            if (bolIs4Mvc == true)
            {
                //  <input value="下移" id="btnDownMove" name="action:DownMove" type="submit" class="btn btn-outline-info" />
                objVueComponentEx.CtrlId = "btnDownMove";
                if (bolIs4Ajax == true)
                {
                    objVueComponentEx.CtrlName = "action:DownMoveAjax";
                }
                else
                {
                    objVueComponentEx.CtrlName = "action:DownMove";
                }
                objVueComponentEx.type = "submit";
                objVueComponentEx.OnClick = "OnClickInFeatureRegion()";

                //objVueComponentEx.OnClick = "btnAddNewRec4Gv_Click";
                objVueComponentEx.Value = "下移";
                objVueComponentEx.Style = "";
                objVueComponentEx.Class = "btn btn-outline-info btn-sm text-nowrap";
                objVueComponentEx.CssClass = "";
                //objVueComponentEx.Width = 80;
                //objVueComponentEx.Height = 0;
            }
            else
            {
                objVueComponentEx.CtrlId = "btnDownMove";
                objVueComponentEx.OnClick = "btnDownMove_Click";
                objVueComponentEx.Text = "下移";
                objVueComponentEx.Style = "z-index: 107;";
                objVueComponentEx.CssClass = "btn btn-outline-info btn-sm";
                objVueComponentEx.Width = 48;
                objVueComponentEx.Height = 0;
            }
            return objVueComponentEx;
        }

        /// <summary>
        /// 建立[导出Excel]按钮
        /// </summary>
        /// <returns></returns>
        public static VueComponentEx GetbtnExportExcel4Gv(bool bolIs4Mvc = false, bool bolIs4Ajax = false)
        {
            VueComponentEx objVueComponentEx = new VueComponentEx();
            objVueComponentEx.Is4Mvc = bolIs4Mvc;
            if (bolIs4Mvc == true)
            {
                //  <input value="下移" id="btnDownMove" name="action:DownMove" type="submit" class="btn btn-outline-info" />
                objVueComponentEx.CtrlId = "btnExportExcel";
                if (bolIs4Ajax == true)
                {
                    objVueComponentEx.CtrlName = "action:ExportExcelAjax";
                }
                else
                {
                    objVueComponentEx.CtrlName = "action:ExportExcel";
                }
                objVueComponentEx.type = "submit";
                objVueComponentEx.OnClick = "OnClickInFeatureRegion()";

                //objVueComponentEx.OnClick = "btnAddNewRec4Gv_Click";
                objVueComponentEx.Value = "导出";
                objVueComponentEx.Style = "";
                objVueComponentEx.Class = "btn btn-outline-warning btn-sm text-nowrap";
                objVueComponentEx.CssClass = "";
                //objVueComponentEx.Width = 80;
                //objVueComponentEx.Height = 0;
            }
            else
            {
                objVueComponentEx.CtrlId = "btnExportExcel4Gv";
                objVueComponentEx.OnClick = "btnExportExcel4Gv_Click";
                objVueComponentEx.Text = "导出Excel";
                objVueComponentEx.Style = "z-index: 107;";
                objVueComponentEx.CssClass = "btn btn-outline-info btn-sm";
                objVueComponentEx.Width = 80;
                objVueComponentEx.Height = 0;
            }
            return objVueComponentEx;
        }
        /// <summary>
        /// 建立[导出Excel]按钮
        /// </summary>
        /// <returns></returns>
        public static VueComponentEx GetbtnSetExportExcel4User(bool bolIs4Mvc = false, bool bolIs4Ajax = false)
        {
            VueComponentEx objVueComponentEx = new VueComponentEx();
            objVueComponentEx.Is4Mvc = bolIs4Mvc;
            if (bolIs4Mvc == true)
            {
                //  <input value="下移" id="btnDownMove" name="action:DownMove" type="submit" class="btn btn-outline-info" />
                objVueComponentEx.CtrlId = "btnSetExportExcel4User";
                if (bolIs4Ajax == true)
                {
                    objVueComponentEx.CtrlName = "action:SetExportExcel4UserAjax";
                }
                else
                {
                    objVueComponentEx.CtrlName = "action:SetExportExcel4User";
                }
                objVueComponentEx.type = "submit";
                objVueComponentEx.OnClick = "OnClickInFeatureRegion()";

                //objVueComponentEx.OnClick = "btnAddNewRec4Gv_Click";
                objVueComponentEx.Value = "设置导出";
                objVueComponentEx.Style = "";
                objVueComponentEx.Class = "btn btn-outline-info btn-sm text-nowrap";
                objVueComponentEx.CssClass = "";
                //objVueComponentEx.Width = 80;
                //objVueComponentEx.Height = 0;
            }
            else
            {
                objVueComponentEx.CtrlId = "btnSetExportExcel4User";
                objVueComponentEx.OnClick = "btnSetExportExcel4User_Click";
                objVueComponentEx.Text = "设置导出字段";
                objVueComponentEx.Style = "z-index: 107;";
                objVueComponentEx.CssClass = "btn btn-outline-info btn-sm";
                objVueComponentEx.Width = 100;
                objVueComponentEx.Height = 0;
            }
            return objVueComponentEx;
        }

        public static VueComponentEx GetButton(clsPrjFeatureEN objPrjFeature, bool bolIs4PureHtml = false)
        {
            VueComponentEx objVueComponentEx = new VueComponentEx();

            //objVueComponentEx.Is4Mvc = bolIs4Mvc;
            objVueComponentEx.objPrjFeature = objPrjFeature;
            objVueComponentEx.OrderNum = objPrjFeature.OrderNum + 20;
            objVueComponentEx.FeatureId = objPrjFeature.FeatureId;
            //objVueComponentEx.ValueGivingModeId = objPrjFeature.ValueGivingModeId;
            //objVueComponentEx.ViewFeatureId = objPrjFeature.ViewFeatureId;
            objVueComponentEx.GroupName = objPrjFeature.GroupName;

            objVueComponentEx.OnClick4Html = string.Format("btnSel_Click('{0}')", objVueComponentEx.CtrlId);

            //if (objPrjFeature.Is4Visible == true)
            //{
            //    objVueComponentEx.OnClick4Html = string.Format("btn_Click('{0}')", objVueComponentEx.CtrlId);
            //}
            //else
            //{
            //    if (string.IsNullOrEmpty(objPrjFeature.EventFuncName) == false)
            //    {
            //        objVueComponentEx.OnClick4Html = objPrjFeature.EventFuncName.Replace("''", "'");
            //    }
            //    else
            //    {
            //        objVueComponentEx.OnClick4Html = string.Format("{0}_Click()", objPrjFeature.ButtonName);
            //    }
            //}
            objVueComponentEx.Text = objPrjFeature.FeatureName;// "添加记录";
            if (objVueComponentEx.Text.Length > 4) objVueComponentEx.ColSpan_Ctrl = 2;
            else objVueComponentEx.ColSpan_Ctrl = 1;
            //objVueComponentEx.Class = "btn btn-outline-info";
            objVueComponentEx.CssClass = "btn btn-outline-info btn-sm";

            //objVueComponentEx.Style = "z-index: 107;";

            //objVueComponentEx.Width = objPrjFeature.Width;
            //objVueComponentEx.Height = 0;

            return objVueComponentEx;
        }

    }
}