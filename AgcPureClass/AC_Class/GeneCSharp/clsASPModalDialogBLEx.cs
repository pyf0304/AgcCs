
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsASPModalDialogBLEx
表名:ASPModalDialog(00050443)
生成代码版本:2019.04.13.1
生成日期:2019/04/19 09:59:10
生成者:
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:生成C#代码
模块英文名:GeneCSharp
框架-层名:业务逻辑扩展层(BusinessLogicEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Xml;
using com.taishsoft.file;
using com.taishsoft.common;

using com.taishsoft.comm_db_obj;

using AGC.PureClass;
using System.Data;
using System.Data.SqlClient;
using AGC.DAL;
using AGC.BusinessLogic;
using AgcCommBase;

namespace AGC.PureClassEx
{
    public static class clsASPModalDialogBLEx_Static
    {

        /// <summary>
        /// 生成该对象相关的代码
        /// </summary>
        /// <param name="objASPButtonENEx">按钮对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GeneCode(this ASPModalDialogEx objASPModalDialogENEx,
            StringBuilder strCodeForCs)
        {
            string strActionId = AgcPubFun.getASPNETID();
            ASPDivEx objDiv1 = clsASPDivBLEx.GetEmptyDiv();
            objDiv1.CtrlId = objASPModalDialogENEx.CtrlId;
            objDiv1.Class = "modal fade";
            objDiv1.tabindex = "-1";
            objDiv1.aria_labelledby = "myModalLabel";
            objDiv1.aria_hidden = "true";
            objDiv1.role = "dialog";

            ASPDivEx objDiv2 = clsASPDivBLEx.GetEmptyDiv();
            objDiv1.arrSubAspControlLst2.Add(objDiv2);
            objDiv2.Class = "modal-dialog modal-sm";

            ASPDivEx objDiv_Content = clsASPDivBLEx.GetEmptyDiv();
            objDiv_Content.Class = "modal-content text-left";
            if (objASPModalDialogENEx.Width == 0)
            {
                objDiv_Content.Style = string.Format("width: 600px;", objASPModalDialogENEx.Width);
            }
            else
            {
                objDiv_Content.Style = string.Format("width: {0}px;", objASPModalDialogENEx.Width);
            }
            objDiv2.arrSubAspControlLst2.Add(objDiv_Content);

            {
                ASPDivEx objDiv_Head = clsASPDivBLEx.GetEmptyDiv();
                objDiv_Head.Class = "modal-header";
                {
                    ASPHtmlButtonEx objButton_InHead = clsASPHtmlButtonBLEx.GetEmptyButton();
                    objButton_InHead.type = "button";
                    objButton_InHead.Class = "close";
                    objButton_InHead.aria_label = "Close";
                    objButton_InHead.data_dismiss = "modal";
                    ASPSpanEx objSpan_Button = clsASPSpanBLEx.GetEmptySpan();
                    objSpan_Button.aria_hidden = "true";
                    objButton_InHead.arrSubAspControlLst2.Add(objSpan_Button);
                    objDiv_Head.arrSubAspControlLst2.Add(objButton_InHead);
                }
                {
                    ASPH4Ex objH4 = new ASPH4Ex();
                    objH4.CtrlId = "myModalLabel";
                    objH4.Text = objASPModalDialogENEx.modal_title;

                    objDiv_Head.arrSubAspControlLst2.Add(objH4);
                }

                objDiv_Content.arrSubAspControlLst2.Add(objDiv_Head);
            }
            {
                ASPDivEx objDiv_Body = clsASPDivBLEx.GetEmptyDiv();
                objDiv_Body.Class = "modal-body";
                objDiv_Body.ContentFunc = objASPModalDialogENEx.ContentFunc;
                objDiv_Content.arrSubAspControlLst2.Add(objDiv_Body);
            }

            {
                ASPDivEx objDiv_Footer = clsASPDivBLEx.GetEmptyDiv();
                objDiv_Footer.Class = "modal-footer";
                objDiv_Content.arrSubAspControlLst2.Add(objDiv_Footer);

                //ASPDivEx objDiv_Button_group = clsASPDivBLEx.GetEmptyDiv();
                //objDiv_Button_group.Class = "form-group";
                //objDiv_Footer.arrSubAspControlLst2.Add(objDiv_Button_group);

                //ASPDivEx objDiv_Button_group_Sub = clsASPDivBLEx.GetEmptyDiv();
                //objDiv_Button_group_Sub.Class = "col-md-offset-2 col-md-10";
                //objDiv_Button_group.arrSubAspControlLst2.Add(objDiv_Button_group_Sub);

                ASPHtmlInputEx objASPHtmlInput_Submit = clsASPHtmlInputBLEx.GetInput_Submit();

                objASPHtmlInput_Submit.CtrlId = "btnSave";
                objASPHtmlInput_Submit.CtrlName = "btnSave";
                objASPHtmlInput_Submit.Value = "Save";
                objASPHtmlInput_Submit.Class = "btn btn-default";

                objDiv_Footer.arrSubAspControlLst2.Add(objASPHtmlInput_Submit);

                ASPHtmlButtonEx objASPHtmlButton_Cancel = clsASPHtmlButtonBLEx.GetEmptyButton();

                //objASPHtmlButton_Cancel.CtrlId = "btnSave";
                //objASPHtmlButton_Cancel.CtrlName = "btnSave";
                //objASPHtmlButton_Cancel.Value = "Save";
                objASPHtmlButton_Cancel.Text = "Cancel";
                objASPHtmlButton_Cancel.Class = "btn btn-default";
                objASPHtmlButton_Cancel.data_dismiss = "modal";
                objDiv_Footer.arrSubAspControlLst2.Add(objASPHtmlButton_Cancel);
                
            }


            if (objASPModalDialogENEx.Is4Mvc == true)
            {
                //       < input value = "重序" id = "btnReOrder" name = "action:ReOrder" type = "submit" class="btn btn-default" />
                objDiv1.GeneCode(strCodeForCs);
            }
            else
            {
                objDiv1.GeneCode(strCodeForCs);
            }
            //foreach (ASPControlEx objSubASPControlENEx in objASPModalDialogENEx.arrSubAspControlLst2)
            //{
            //    //if (objSubASPControlENEx.CtlTypeId != enumCtlTypeAbbr.ASPNETAutoresizingMask) continue;
            //    objSubASPControlENEx.GeneCode(strCodeForCs);
            //}


        }
       

    }
    /// <summary>
    /// ASP模态对话框(ASPModalDialog)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsASPModalDialogBLEx 
    {

    }
}