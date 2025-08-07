
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsASPHtmlButtonBLEx
表名:ASPNETHtmlButton(00050416)
生成代码版本:2018.08.16.1
生成日期:2018/08/19 17:02:23
生成者:潘以锋
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:生成C#代码
模块英文名:GeneCode
框架-层名:业务逻辑扩展层(BusinessLogicEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2018.07.27.01
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
using AGC.Entity;

namespace AGC.PureClassEx
{
    /// <summary>
    /// ASPNETHtml按钮(ASPNETHtmlButton)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public static class clsASPHtmlButtonBLEx_Static
    {
        /// <summary>
        /// 生成该对象相关的代码
        /// </summary>
        /// <param name="objASPHtmlButtonENEx">按钮对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GeneCode(this ASPHtmlButtonEx objASPHtmlButtonENEx, enumApplicationType intApplicationTypeId,
            StringBuilder strCodeForCs)
        {
            string strActionId = AgcPubFun.getASPNETID();

            switch (intApplicationTypeId)
            {
                case enumApplicationType.WebApp_2:
                case enumApplicationType.WebApi_19:
                    strCodeForCs.AppendFormat("\r\n" + "<input  ");
                    clsASPControlBLEx.GC4Type(objASPHtmlButtonENEx, strCodeForCs);

                    //生成控件的Id、Name
                    clsASPControlBLEx.GC4IdName(objASPHtmlButtonENEx, strCodeForCs);
                    strCodeForCs.AppendFormat(" type=\"button\" ");

                    clsASPControlBLEx.GC4Data_dismiss(objASPHtmlButtonENEx, strCodeForCs);

                    clsASPControlBLEx.GC4Aria_label(objASPHtmlButtonENEx, strCodeForCs);

                    //生成控件的Tag
                    clsASPControlBLEx.GC4Tag(objASPHtmlButtonENEx, strCodeForCs);

                    //生成控件的样式
                    clsASPControlBLEx.GC4Style(objASPHtmlButtonENEx, strCodeForCs);

                    //生成控件的尺寸-高、宽
                    //clsASPControlBLEx.GC4Size(objASPHtmlButtonENEx, strCodeForCs);
                    //生成控件的边界尺寸-即与四周的距离
                    clsASPControlBLEx.GC4Margin(objASPHtmlButtonENEx, strCodeForCs);

                    if (string.IsNullOrEmpty(objASPHtmlButtonENEx.OnClick) == false)
                    {
                        strCodeForCs.AppendFormat(" onclick=\"{0}\"",
                            objASPHtmlButtonENEx.OnClick);
                    }


                    clsASPControlBLEx.GC4Tabindex(objASPHtmlButtonENEx, strCodeForCs);
                    clsASPControlBLEx.GC4Aria_labelledby(objASPHtmlButtonENEx, strCodeForCs);
                    clsASPControlBLEx.GC4Aria_hidden(objASPHtmlButtonENEx, strCodeForCs);

                    //生成控件的样式
                    //clsASPControlBLEx.GC4Text(objASPHtmlButtonENEx, strCodeForCs);

                    //生成控件的约束-即与四周控件的约束关系
                    //clsASPControlBLEx.GC4Constraint(objASPHtmlButtonENEx, strCodeForCs);

                    if (string.IsNullOrEmpty(objASPHtmlButtonENEx.Value) == false)
                    {
                        strCodeForCs.AppendFormat(" value=\"{0}\" ",
                               objASPHtmlButtonENEx.Value);
                    }
                    if (string.IsNullOrEmpty(objASPHtmlButtonENEx.Text) == false)
                    {
                        strCodeForCs.AppendFormat("{0}",
                               objASPHtmlButtonENEx.Text);
                    }
                    strCodeForCs.Append(" />");
                    break;
                case enumApplicationType.AspMvcAjaxApp_20:
                case enumApplicationType.AspMvcApp_13:
                case enumApplicationType.AspMvcApp_TS_16:
                    strCodeForCs.AppendFormat("\r\n" + "<input ");
                    clsASPControlBLEx.GC4Type(objASPHtmlButtonENEx, strCodeForCs);

                    //生成控件的Id、Name
                    clsASPControlBLEx.GC4IdName(objASPHtmlButtonENEx, strCodeForCs);
                    strCodeForCs.AppendFormat(" type='button' ");

                    clsASPControlBLEx.GC4Data_dismiss(objASPHtmlButtonENEx, strCodeForCs);

                    clsASPControlBLEx.GC4Aria_label(objASPHtmlButtonENEx, strCodeForCs);

                    //生成控件的Tag
                    clsASPControlBLEx.GC4Tag(objASPHtmlButtonENEx, strCodeForCs);

                    //生成控件的样式
                    clsASPControlBLEx.GC4Style(objASPHtmlButtonENEx, strCodeForCs);

                    //生成控件的尺寸-高、宽
                    //clsASPControlBLEx.GC4Size(objASPHtmlButtonENEx, strCodeForCs);
                    //生成控件的边界尺寸-即与四周的距离
                    clsASPControlBLEx.GC4Margin(objASPHtmlButtonENEx, strCodeForCs);

                    if (string.IsNullOrEmpty(objASPHtmlButtonENEx.OnClick) == false)
                    {
                        strCodeForCs.AppendFormat(" onclick=\"{0}\"",
                            objASPHtmlButtonENEx.OnClick);
                    }


                    clsASPControlBLEx.GC4Tabindex(objASPHtmlButtonENEx, strCodeForCs);
                    clsASPControlBLEx.GC4Aria_labelledby(objASPHtmlButtonENEx, strCodeForCs);
                    clsASPControlBLEx.GC4Aria_hidden(objASPHtmlButtonENEx, strCodeForCs);

                    //生成控件的样式
                    //clsASPControlBLEx.GC4Text(objASPHtmlButtonENEx, strCodeForCs);

                    //生成控件的约束-即与四周控件的约束关系
                    //clsASPControlBLEx.GC4Constraint(objASPHtmlButtonENEx, strCodeForCs);

                    if (string.IsNullOrEmpty(objASPHtmlButtonENEx.Value) == false)
                    {
                        strCodeForCs.AppendFormat(" value=\"{0}\" ",
                               objASPHtmlButtonENEx.Value);
                    }
                    if (string.IsNullOrEmpty(objASPHtmlButtonENEx.Text) == false)
                    {
                        strCodeForCs.AppendFormat("{0}",
                               objASPHtmlButtonENEx.Text);
                    }
                    strCodeForCs.Append(" />");
                    break;
                case enumApplicationType.SpaAppInCore_TS_18:
                case enumApplicationType.VueAppInCore_TS_30:
                    strCodeForCs.AppendFormat("\r\n" + "<button ");
                    
                    //生成控件的Id、Name
                    clsASPControlBLEx.GC4IdName(objASPHtmlButtonENEx, strCodeForCs);

                    clsASPControlBLEx.GC4Type(objASPHtmlButtonENEx, strCodeForCs);

                    clsASPControlBLEx.GC4Data_dismiss(objASPHtmlButtonENEx, strCodeForCs);

                    clsASPControlBLEx.GC4Aria_label(objASPHtmlButtonENEx, strCodeForCs);

                    //生成控件的Tag
                    clsASPControlBLEx.GC4Tag(objASPHtmlButtonENEx, strCodeForCs);

                    //生成控件的样式
                    clsASPControlBLEx.GC4Style(objASPHtmlButtonENEx, strCodeForCs);

                    //生成控件的尺寸-高、宽
                    //clsASPControlBLEx.GC4Size(objASPHtmlButtonENEx, strCodeForCs);
                    //生成控件的边界尺寸-即与四周的距离
                    clsASPControlBLEx.GC4Margin(objASPHtmlButtonENEx, strCodeForCs);

                    if (string.IsNullOrEmpty(objASPHtmlButtonENEx.OnClick) == false)
                    {
                        strCodeForCs.AppendFormat(" onclick=\"{0}\"",
                            objASPHtmlButtonENEx.OnClick);
                    }


                    clsASPControlBLEx.GC4Tabindex(objASPHtmlButtonENEx, strCodeForCs);
                    clsASPControlBLEx.GC4Aria_labelledby(objASPHtmlButtonENEx, strCodeForCs);
                    clsASPControlBLEx.GC4Aria_hidden(objASPHtmlButtonENEx, strCodeForCs);

                    //生成控件的样式
                    //clsASPControlBLEx.GC4Text(objASPHtmlButtonENEx, strCodeForCs);

                    //生成控件的约束-即与四周控件的约束关系
                    //clsASPControlBLEx.GC4Constraint(objASPHtmlButtonENEx, strCodeForCs);
                    strCodeForCs.Append(">");
                    if (string.IsNullOrEmpty(objASPHtmlButtonENEx.Value) == false)
                    {
                        strCodeForCs.AppendFormat("{0}",
                               objASPHtmlButtonENEx.Value);
                    }
                    if (string.IsNullOrEmpty(objASPHtmlButtonENEx.Text) == false)
                    {
                        strCodeForCs.AppendFormat("{0}",
                               objASPHtmlButtonENEx.Text);
                    }

                    foreach (ASPControlEx objSubASPControlENEx in objASPHtmlButtonENEx.arrSubAspControlLst2)
                    {
                        //if (objSubASPControlENEx.CtlTypeId != enumCtlType.ASPNETAutoresizingMask) continue;
                        objSubASPControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    }

                    strCodeForCs.AppendFormat("</button>");
                    break;
                default:
                    var objApp = clsApplicationTypeBL.GetObjByApplicationTypeIdCache((int)intApplicationTypeId);
                    var strMsg = string.Format("应用:[{0}]在函数Switch中没有被处理.(in {1})", objApp.ApplicationTypeName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                    //break;
            }
         
        }
               

        public static void GeneCode4Mvc(this ASPHtmlButtonEx objASPHtmlButtonENEx, enumApplicationType intApplicationTypeId,
         StringBuilder strCodeForCs)
        {
            string strActionId = AgcPubFun.getASPNETID();


            strCodeForCs.AppendFormat("\r\n" + "<button ");

            //生成控件的Id、Name
            clsASPControlBLEx.GC4IdName(objASPHtmlButtonENEx, strCodeForCs);

            clsASPControlBLEx.GC4Type(objASPHtmlButtonENEx, strCodeForCs);

            clsASPControlBLEx.GC4Data_dismiss(objASPHtmlButtonENEx, strCodeForCs);

            clsASPControlBLEx.GC4Aria_label(objASPHtmlButtonENEx, strCodeForCs);

            //生成控件的Tag
            clsASPControlBLEx.GC4Tag(objASPHtmlButtonENEx, strCodeForCs);

            //生成控件的样式
            clsASPControlBLEx.GC4Style(objASPHtmlButtonENEx, strCodeForCs);

            //生成控件的尺寸-高、宽
            //clsASPControlBLEx.GC4Size(objASPHtmlButtonENEx, strCodeForCs);
            //生成控件的边界尺寸-即与四周的距离
            clsASPControlBLEx.GC4Margin(objASPHtmlButtonENEx, strCodeForCs);

            if (string.IsNullOrEmpty(objASPHtmlButtonENEx.OnClick) == false)
            {
                strCodeForCs.AppendFormat(" onclick=\"{0}\"",
                    objASPHtmlButtonENEx.OnClick);
            }
            if (string.IsNullOrEmpty(objASPHtmlButtonENEx.Value) == false)
            {
                strCodeForCs.AppendFormat(" value=\"{0}\"",
                       objASPHtmlButtonENEx.Value);
            }

            clsASPControlBLEx.GC4Tabindex(objASPHtmlButtonENEx, strCodeForCs);
            clsASPControlBLEx.GC4Aria_labelledby(objASPHtmlButtonENEx, strCodeForCs);
            clsASPControlBLEx.GC4Aria_hidden(objASPHtmlButtonENEx, strCodeForCs);

            //生成控件的样式
            //clsASPControlBLEx.GC4Text(objASPHtmlButtonENEx, strCodeForCs);

            //生成控件的约束-即与四周控件的约束关系
            //clsASPControlBLEx.GC4Constraint(objASPHtmlButtonENEx, strCodeForCs);

            if (string.IsNullOrEmpty(objASPHtmlButtonENEx.Text) == false)
            {
                strCodeForCs.AppendFormat(">{0}</button>",
                       objASPHtmlButtonENEx.Text);
            }
            else
            {
                if (objASPHtmlButtonENEx.arrSubAspControlLst2.Count == 0)
                {
                    strCodeForCs.AppendFormat("/>");
                }
                else
                {
                    strCodeForCs.AppendFormat(">");
                    foreach (ASPControlEx objSubASPControlENEx in objASPHtmlButtonENEx.arrSubAspControlLst2)
                    {
                        //if (objSubASPControlENEx.CtlTypeId != enumCtlType.ASPNETAutoresizingMask) continue;
                        objSubASPControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    }
                    strCodeForCs.AppendFormat("</button>");
                }
            }
        }
    }
    /// <summary>
    /// ASPNETHtml按钮(ASPNETHtmlButton)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsASPHtmlButtonBLEx
    {

        /// <summary>
        /// 生成字段变量定义的代码
        /// </summary>
        /// <param name="objASPHtmlButtonENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarDef(ASPHtmlButtonEx objASPHtmlButtonENEx,
            StringBuilder strCodeForCs)
        {

            strCodeForCs.AppendFormat("\r\n" + "private Button {0};",
                objASPHtmlButtonENEx.CtrlId);

        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objASPHtmlButtonENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind(ASPHtmlButtonEx objASPHtmlButtonENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "btn{0} = (Button)findViewById(R.id.btn{0}); ",
                objASPHtmlButtonENEx.CtrlId);

        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objASPHtmlButtonENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind4ListView(ASPHtmlButtonEx objASPHtmlButtonENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "btn{0} = (Button)view.findViewById(R.id.btn{0}); ",
                objASPHtmlButtonENEx.CtrlId);

        }
        /// <summary>
        /// 生成字段控件的设置控件值(查询区字段)
        /// </summary>
        /// <param name="objASPHtmlButtonENEx"></param>
        /// <param name="objViewInfoENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_LvFieldAssignment(ASPHtmlButtonEx objASPHtmlButtonENEx, clsViewInfoEN objViewInfoENEx,
            StringBuilder strCodeForCs)
        {
            //string strTemp = objASPHtmlButtonENEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName;

            //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            //strCodeForCs.AppendFormat("\r\n //设置{0}({1})的值", objASPHtmlButtonENEx.objQryRegionFldsEN.ObjFieldTab_PC().Caption,
            //    objASPHtmlButtonENEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName);

            //strCodeForCs.AppendFormat("\r\n public void set{0}_q({1} value)", strTemp, objASPHtmlButtonENEx.objQryRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType);
            //strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n" + "tv{1}.setText(obj{0}EN.get{1}());",
               objViewInfoENEx.ObjOutRelaTab().TabName,
               objASPHtmlButtonENEx.objDGRegionFldsEN.ObjFieldTab_PC().FldName);
            //strCodeForCs.Append("\r\n }");
        }
        /// <summary>
        /// 建立空按钮
        /// </summary>
        /// <returns></returns>
        public static ASPHtmlButtonEx GetEmptyButton()
        {
            ASPHtmlButtonEx objASPHtmlButtonENEx = new ASPHtmlButtonEx();
            return objASPHtmlButtonENEx;
        }

        /// <summary>
        /// 建立修改按钮
        /// </summary>
        /// <returns></returns>
        public static ASPHtmlButtonEx GetbtnUpdate4Gv()
        {
            ASPHtmlButtonEx objASPHtmlButtonENEx = new ASPHtmlButtonEx();
            objASPHtmlButtonENEx.CtrlId = "btnUpdate4Gv";
            objASPHtmlButtonENEx.OnClick = "btnUpdate4Gv_Click()";
            objASPHtmlButtonENEx.Value = "修改记录";
            objASPHtmlButtonENEx.Style = "z-index: 107;";
            objASPHtmlButtonENEx.Class = "btn btn-outline-info";
            objASPHtmlButtonENEx.Width = 80;
            objASPHtmlButtonENEx.Height = 0;
            return objASPHtmlButtonENEx;
        }
        public static ASPHtmlButtonEx GetbtnUpdate()
        {
            ASPHtmlButtonEx objASPHtmlButtonENEx = new ASPHtmlButtonEx();
            objASPHtmlButtonENEx.CtrlId = "btnUpdateRecord";
            objASPHtmlButtonENEx.OnClick = "btnUpdateRecord_Click()";
            objASPHtmlButtonENEx.Value = "修改";
            objASPHtmlButtonENEx.Style = "z-index: 107;";
            objASPHtmlButtonENEx.Class = "btn btn-outline-info";
            objASPHtmlButtonENEx.Width = 80;
            objASPHtmlButtonENEx.Height = 0;
            return objASPHtmlButtonENEx;
        }
        /// <summary>
        /// 建立修改按钮
        /// </summary>
        /// <returns></returns>
        public static ASPHtmlButtonEx GetbtnQuery()
        {
            ASPHtmlButtonEx objASPHtmlButtonENEx = new ASPHtmlButtonEx();
            objASPHtmlButtonENEx.CtrlId = "btnQuery";
            objASPHtmlButtonENEx.OnClick = "btnQuery_Click()";
            objASPHtmlButtonENEx.Value = "查询";
            objASPHtmlButtonENEx.Style = "z-index: 107;";
            objASPHtmlButtonENEx.Class = "btn btn-outline-info";
            objASPHtmlButtonENEx.Width = 80;
            objASPHtmlButtonENEx.Height = 0;
            return objASPHtmlButtonENEx;
        }
        /// <summary>
        /// 建立详细信息按钮
        /// </summary>
        /// <returns></returns>
        public static ASPHtmlButtonEx GetbtnDetail4Gv()
        {
            ASPHtmlButtonEx objASPHtmlButtonENEx = new ASPHtmlButtonEx();
            objASPHtmlButtonENEx.CtrlId = "btnDetail4Gv";
            objASPHtmlButtonENEx.OnClick = "btnDetail4Gv_Click()";
            objASPHtmlButtonENEx.Value = "详细信息";
            objASPHtmlButtonENEx.Style = "z-index: 107;";
            objASPHtmlButtonENEx.Class = "btn btn-outline-info";
            objASPHtmlButtonENEx.Width = 80;
            objASPHtmlButtonENEx.Height = 0;
            return objASPHtmlButtonENEx;
        }

        /// <summary>
        /// 建立删除按钮
        /// </summary>
        /// <returns></returns>
        public static ASPHtmlButtonEx GetbtnDelete4Gv()
        {
            ASPHtmlButtonEx objASPHtmlButtonENEx = new ASPHtmlButtonEx();
            objASPHtmlButtonENEx.CtrlId = "btnDelete4Gv";
            objASPHtmlButtonENEx.OnClick = "btnDelete4Gv_Click()";
            objASPHtmlButtonENEx.Value = "删除记录";
            objASPHtmlButtonENEx.Style = "z-index: 107;";
            objASPHtmlButtonENEx.Class = "btn btn-outline-info";
            objASPHtmlButtonENEx.Width = 80;
            objASPHtmlButtonENEx.Height = 0;
            return objASPHtmlButtonENEx;
        }
        public static ASPHtmlButtonEx GetbtnDelete()
        {
            ASPHtmlButtonEx objASPHtmlButtonENEx = new ASPHtmlButtonEx();
            objASPHtmlButtonENEx.CtrlId = "btnDelRecord";
            objASPHtmlButtonENEx.OnClick = "btnDelRecord_Click()";
            objASPHtmlButtonENEx.Value = "删除";
            objASPHtmlButtonENEx.Style = "z-index: 107;";
            objASPHtmlButtonENEx.Class = "btn btn-outline-info";
            objASPHtmlButtonENEx.Width = 80;
            objASPHtmlButtonENEx.Height = 0;
            return objASPHtmlButtonENEx;
        }
        /// <summary>
        /// 建立添加记录按钮
        /// </summary>
        /// <returns></returns>
        public static ASPHtmlButtonEx GetbtnAddNewRec4Gv()
        {
            ASPHtmlButtonEx objASPHtmlButtonENEx = new ASPHtmlButtonEx();
            objASPHtmlButtonENEx.CtrlId = "btnAddNewRec4Gv";
            objASPHtmlButtonENEx.OnClick = "btnAddNewRec4Gv_Click()";
            objASPHtmlButtonENEx.Value = "添加记录";
            objASPHtmlButtonENEx.Style = "z-index: 107;";
            objASPHtmlButtonENEx.Class = "btn btn-outline-info";
            objASPHtmlButtonENEx.Width = 80;
            objASPHtmlButtonENEx.Height = 0;
            return objASPHtmlButtonENEx;
        }

        public static ASPHtmlButtonEx GetbtnAddNewRec()
        {
            ASPHtmlButtonEx objASPHtmlButtonENEx = new ASPHtmlButtonEx();
            objASPHtmlButtonENEx.CtrlId = "btnAddNewRecord";
            objASPHtmlButtonENEx.OnClick = "btnAddNewRecord_Click()";
            objASPHtmlButtonENEx.Value = "添加";
            objASPHtmlButtonENEx.Style = "z-index: 107;";
            objASPHtmlButtonENEx.Class = "btn btn-outline-info";
            objASPHtmlButtonENEx.Width = 80;
            objASPHtmlButtonENEx.Height = 0;
            return objASPHtmlButtonENEx;
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
        public static ASPHtmlButtonEx GetbtnGoTop()
        {
            ASPHtmlButtonEx objASPHtmlButtonENEx = new ASPHtmlButtonEx();
            objASPHtmlButtonENEx.CtrlId = "btnGoTop";
            objASPHtmlButtonENEx.OnClick = "btnGoTop_Click()";
            objASPHtmlButtonENEx.Text = "移顶";
            objASPHtmlButtonENEx.Style = "z-index: 107;";
            objASPHtmlButtonENEx.CssClass = "btn btn-outline-info";
            objASPHtmlButtonENEx.Width = 48;
            objASPHtmlButtonENEx.Height = 0;
            return objASPHtmlButtonENEx;
        }

        /// <summary>
        /// 建立[移底]按钮
        /// </summary>
        /// <returns></returns>
        public static ASPHtmlButtonEx GetbtnGoBottum()
        {
            ASPHtmlButtonEx objASPHtmlButtonENEx = new ASPHtmlButtonEx();
            objASPHtmlButtonENEx.CtrlId = "btnGoBottum";
            objASPHtmlButtonENEx.OnClick = "btnGoBottum_Click()";
            objASPHtmlButtonENEx.Text = "移底";
            objASPHtmlButtonENEx.Style = "z-index: 107;";
            objASPHtmlButtonENEx.CssClass = "btn btn-outline-info";
            objASPHtmlButtonENEx.Width = 48;
            objASPHtmlButtonENEx.Height = 0;
            return objASPHtmlButtonENEx;
        }

        /// <summary>
        /// 建立[重序]按钮
        /// </summary>
        /// <returns></returns>
        public static ASPHtmlButtonEx GetbtnReOrder()
        {
            ASPHtmlButtonEx objASPHtmlButtonENEx = new ASPHtmlButtonEx();
            objASPHtmlButtonENEx.CtrlId = "btnReOrder";
            objASPHtmlButtonENEx.OnClick = "btnReOrder_Click()";
            objASPHtmlButtonENEx.Text = "重序";
            objASPHtmlButtonENEx.Style = "z-index: 107;";
            objASPHtmlButtonENEx.CssClass = "btn btn-outline-info";
            objASPHtmlButtonENEx.Width = 48;
            objASPHtmlButtonENEx.Height = 0;
            return objASPHtmlButtonENEx;
        }

        /// <summary>
        /// 建立[上移]按钮
        /// </summary>
        /// <returns></returns>
        public static ASPHtmlButtonEx GetbtnUpMove()
        {
            ASPHtmlButtonEx objASPHtmlButtonENEx = new ASPHtmlButtonEx();
            objASPHtmlButtonENEx.CtrlId = "btnUpMove";
            objASPHtmlButtonENEx.OnClick = "btnUpMove_Click()";
            objASPHtmlButtonENEx.Text = "上移";
            objASPHtmlButtonENEx.Style = "z-index: 107;";
            objASPHtmlButtonENEx.CssClass = "btn btn-outline-info";
            objASPHtmlButtonENEx.Width = 48;
            objASPHtmlButtonENEx.Height = 0;
            return objASPHtmlButtonENEx;
        }

        /// <summary>
        /// 建立[下移]按钮
        /// </summary>
        /// <returns></returns>
        public static ASPHtmlButtonEx GetbtnDownMove()
        {
            ASPHtmlButtonEx objASPHtmlButtonENEx = new ASPHtmlButtonEx();
            objASPHtmlButtonENEx.CtrlId = "btnDownMove";
            objASPHtmlButtonENEx.OnClick = "btnDownMove_Click()";
            objASPHtmlButtonENEx.Text = "下移";
            objASPHtmlButtonENEx.Style = "z-index: 107;";
            objASPHtmlButtonENEx.CssClass = "btn btn-outline-info";
            objASPHtmlButtonENEx.Width = 48;
            objASPHtmlButtonENEx.Height = 0;
            return objASPHtmlButtonENEx;
        }

        /// <summary>
        /// 建立[导出Excel]按钮
        /// </summary>
        /// <returns></returns>
        public static ASPHtmlButtonEx GetbtnExportExcel4Gv()
        {
            ASPHtmlButtonEx objASPHtmlButtonENEx = new ASPHtmlButtonEx();
            objASPHtmlButtonENEx.CtrlId = "btnExportExcel4Gv";
            objASPHtmlButtonENEx.OnClick = "btnExportExcel4Gv_Click()";
            objASPHtmlButtonENEx.Value = "导出Excel";
            objASPHtmlButtonENEx.Style = "z-index: 107;";
            objASPHtmlButtonENEx.Class = "btn btn-outline-info";
            objASPHtmlButtonENEx.Width = 80;
            objASPHtmlButtonENEx.Height = 0;
            return objASPHtmlButtonENEx;
        }
        public static ASPHtmlButtonEx GetbtnExportExcel()
        {
            ASPHtmlButtonEx objASPHtmlButtonENEx = new ASPHtmlButtonEx();
            objASPHtmlButtonENEx.CtrlId = "btnExportExcel";
            objASPHtmlButtonENEx.OnClick = "btnExportExcel_Click()";
            objASPHtmlButtonENEx.Value = "导出Excel";
            objASPHtmlButtonENEx.Style = "z-index: 107;";
            objASPHtmlButtonENEx.Class = "btn btn-outline-info";
            objASPHtmlButtonENEx.Width = 100;
            objASPHtmlButtonENEx.Height = 0;
            return objASPHtmlButtonENEx;
        }
        /// <summary>
        /// 建立[导出Excel]按钮
        /// </summary>
        /// <returns></returns>
        public static ASPHtmlButtonEx GetbtnSetExportExcel4User()
        {
            ASPHtmlButtonEx objASPHtmlButtonENEx = new ASPHtmlButtonEx();
            objASPHtmlButtonENEx.CtrlId = "btnSetExportExcel4User";
            objASPHtmlButtonENEx.OnClick = "btnSetExportExcel4User_Click()";
            objASPHtmlButtonENEx.Text = "设置导出字段";
            objASPHtmlButtonENEx.Style = "z-index: 107;";
            objASPHtmlButtonENEx.CssClass = "btn btn-outline-info";
            objASPHtmlButtonENEx.Width = 100;
            objASPHtmlButtonENEx.Height = 0;
            return objASPHtmlButtonENEx;
        }

    }
}