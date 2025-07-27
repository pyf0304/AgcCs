
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsASPLiBLEx
表名:ASPNETLi(00050435)
生成代码版本:2019.03.09.1
生成日期:2019/03/13 01:11:51
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
using System.Web.UI.HtmlControls;
using AGC.Entity;

namespace AGC.PureClassEx
{
    /// <summary>
    /// ASPNET列表项目(ASPNETLi)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public static class clsASPLiBLEx_Static
    {


        /// <summary>
        /// 生成该对象相关的代码
        /// </summary>
        /// <param name="objASPLiENEx">编辑文本框对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GeneCode(this ASPLiEx objASPLiENEx,
            StringBuilder strCodeForCs)
        {
            string strActionId = AgcPubFun.getASPNETID();

            strCodeForCs.AppendFormat("\r\n" + "<li");

            //生成控件的Id、Name
            clsASPControlBLEx.GC4IdName(objASPLiENEx, strCodeForCs);

            //生成控件的Tag
            clsASPControlBLEx.GC4Style(objASPLiENEx, strCodeForCs);

            //生成控件的Tag
            clsASPControlBLEx.GC4Tag(objASPLiENEx, strCodeForCs);

            //生成控件的尺寸-高、宽
            clsASPControlBLEx.GC4Size(objASPLiENEx, strCodeForCs);

            //生成控件的边界尺寸-即与四周的距离
            clsASPControlBLEx.GC4Margin(objASPLiENEx, strCodeForCs);
            //生成线性布局的子控件的布局方向-横向、纵向
            //if (string.IsNullOrEmpty(objASPLiENEx.orientation) == false)
            //{
            //    strCodeForCs.AppendFormat("\r\n" + "android:orientation=\"{0}\"",
            //        objASPLiENEx.orientation);
            //}
            strCodeForCs.AppendFormat(">");

            foreach (ASPControlEx objSubASPControlENEx in objASPLiENEx.arrSubAspControlLst2)
            {
                //if (objSubASPControlENEx.CtlTypeId != enumCtlTypeAbbr.ASPNETAutoresizingMask) continue;
                objSubASPControlENEx.GeneCode(strCodeForCs);
            }
            strCodeForCs.AppendFormat("\r\n" + "</li>");

        }
        public static void GeneCode4Mvc(this ASPLiEx objASPLiENEx,
      StringBuilder strCodeForCs)
        {
            string strActionId = AgcPubFun.getASPNETID();

            strCodeForCs.AppendFormat("\r\n" + "<li");

            //生成控件的Id、Name
            clsASPControlBLEx.GC4IdName(objASPLiENEx, strCodeForCs);

            //生成控件的Tag
            clsASPControlBLEx.GC4Style(objASPLiENEx, strCodeForCs);

            //生成控件的Tag
            clsASPControlBLEx.GC4Tag(objASPLiENEx, strCodeForCs);

            //生成控件的尺寸-高、宽
            clsASPControlBLEx.GC4Size(objASPLiENEx, strCodeForCs);

            //生成控件的边界尺寸-即与四周的距离
            clsASPControlBLEx.GC4Margin(objASPLiENEx, strCodeForCs);
            //生成线性布局的子控件的布局方向-横向、纵向
            //if (string.IsNullOrEmpty(objASPLiENEx.orientation) == false)
            //{
            //    strCodeForCs.AppendFormat("\r\n" + "android:orientation=\"{0}\"",
            //        objASPLiENEx.orientation);
            //}
            strCodeForCs.AppendFormat(">");

            foreach (ASPControlEx objSubASPControlENEx in objASPLiENEx.arrSubAspControlLst2)
            {
                //if (objSubASPControlENEx.CtlTypeId != enumCtlTypeAbbr.ASPNETAutoresizingMask) continue;
                objSubASPControlENEx.GeneCode4Mvc(strCodeForCs);
            }
            strCodeForCs.AppendFormat("\r\n" + "</li>");

        }
        /// <summary>
        /// 生成该对象相关的代码
        /// </summary>
        /// <param name="objASPLiENEx">编辑文本框对象</param>      
        public static void GeneHtmlControl(this ASPLiEx objASPLiENEx, HtmlContainerControl objContainer)
        {
            string strActionId = AgcPubFun.getASPNETID();

            HtmlGenericControl objLi = new HtmlGenericControl("li");
            objLi.Attributes["class"] = objASPLiENEx.Class;
            objLi.ID = objASPLiENEx.CtrlId;
            objContainer.Controls.Add(objLi);
            foreach (ASPControlEx objSubASPControlENEx in objASPLiENEx.arrSubAspControlLst2)
            {
                objSubASPControlENEx.GeneHtmlControl(objLi);
               
            }
            //return objLi;
        }
    }
        /// <summary>
        /// ASPNET列表项目(ASPNETLi)
        /// 数据源类型:SQL表
        /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
        /// </summary>
        public partial class clsASPLiBLEx 
        {
        
        /// <summary>
        /// 生成字段变量定义的代码
        /// </summary>
        /// <param name="objASPLiENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarDef(ASPLiEx objASPLiENEx,
            StringBuilder strCodeForCs)
        {
            strCodeForCs.AppendFormat("\r\n" + "private Div tw{0};",
                objASPLiENEx.CtrlId);
        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objASPLiENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind(ASPLiEx objASPLiENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "tw{0} = (Div)findViewById(R.id.tw{0}); ",
                objASPLiENEx.CtrlId);

        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objASPLiENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind4ListView(ASPLiEx objASPLiENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "tw{0} = (Div)view.findViewById(R.id.tw{0}); ",
                objASPLiENEx.CtrlId);

        }

        /// <summary>
        /// 生成字段控件的设置控件值(查询区字段)
        /// </summary>
        /// <param name="objASPLiENEx"></param>
        /// <param name="objViewInfoENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_LvFieldAssignment(ASPLiEx objASPLiENEx, clsViewInfoENEx objViewInfoENEx,
            StringBuilder strCodeForCs)
        {
            //string strTemp = objASPLiENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName;

            //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            //strCodeForCs.AppendFormat("\r\n //设置{0}({1})的值", objASPLiENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.Caption,
            //    objASPLiENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);

            //strCodeForCs.AppendFormat("\r\n public void set{0}_q({1} value)", strTemp, objASPLiENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType);
            //strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n" + "tv{1}.setText(obj{0}EN.get{1}());",
               objViewInfoENEx.objOutRelaTab.TabName,
               objASPLiENEx.objDGRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName);
            //strCodeForCs.Append("\r\n }");
        }

        /// <summary>
        /// 建立[空行td]
        /// </summary>
        /// <returns></returns>
        public static ASPLiEx GetEmptyLi()
        {
            ASPLiEx objASPLiENEx = new ASPLiEx();
            //objASPColENEx.CtrlId = "tr1";         
            //objASPColENEx.Style = "width: 100%; height: 32px; ";
            //objASPColENEx.Class = "msgtable";
            return objASPLiENEx;
        }
    }
}