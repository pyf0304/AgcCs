
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsASPBoundFieldBLEx
表名:ASPNETBoundField(00050226)
生成代码版本:2018.06.22.1
生成日期:2018/06/29 07:55:19
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
注意:1、需要数据底层(PubDataBase.dll)的版本:2018.05.31.01
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
    /// ASPNET绑定字段(ASPNETBoundField)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public static class clsASPBoundFieldBLEx_Static
    {
        public static void GeneCode(this ASPBoundFieldEx objASPBoundFieldENEx, StringBuilder strCodeForCs)
        {
            strCodeForCs.AppendFormat("\r\n" + "<BoundField DataField = \"{0}\" ", objASPBoundFieldENEx.DataField);
            if (string.IsNullOrEmpty(objASPBoundFieldENEx.SortExpression) == false)
            {
                strCodeForCs.AppendFormat("SortExpression = \"{0}\"  ", objASPBoundFieldENEx.SortExpression);
            }
            if (string.IsNullOrEmpty(objASPBoundFieldENEx.HeaderText) == false)
            {
                strCodeForCs.AppendFormat("HeaderText = \"{0}\"  ", objASPBoundFieldENEx.HeaderText);
            }
            strCodeForCs.Append(">");

            foreach (ASPControlEx objSubASPControlENEx in objASPBoundFieldENEx.arrSubAspControlLst2)
            {
                objSubASPControlENEx.GeneCode(strCodeForCs);
            }
            strCodeForCs.Append("\r\n" + "</BoundField>");

        }
    }
    
    /// <summary>
     /// ASPNET绑定字段(ASPNETBoundField)
     /// 数据源类型:SQL表
     /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
     /// </summary>
    public class clsASPBoundFieldBLEx 
        {

        /// <summary>
        /// 生成字段变量定义的代码
        /// </summary>
        /// <param name="objASPBoundFieldENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarDef(ASPBoundFieldEx objASPBoundFieldENEx,
            StringBuilder strCodeForCs)
        {
            strCodeForCs.AppendFormat("\r\n" + "private BoundField {0};",
                objASPBoundFieldENEx.CtrlId);
        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objASPBoundFieldENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind(ASPBoundFieldEx objASPBoundFieldENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "{0} = (BoundField)findViewById(R.id.{0}); ",
                objASPBoundFieldENEx.CtrlId);

        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objASPBoundFieldENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind4ListView(ASPBoundFieldEx objASPBoundFieldENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "{0} = (BoundField)view.findViewById(R.id.{0}); ",
                objASPBoundFieldENEx.CtrlId);

        }

        /// <summary>
        /// 生成字段控件的设置控件值(查询区字段)
        /// </summary>
        /// <param name="objASPBoundFieldENEx"></param>
        /// <param name="objViewInfoENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_LvFieldAssignment(ASPBoundFieldEx objASPBoundFieldENEx, clsViewInfoENEx objViewInfoENEx,
            StringBuilder strCodeForCs)
        {
            //string strTemp = objASPBoundFieldENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName;

            //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            //strCodeForCs.AppendFormat("\r\n //设置{0}({1})的值", objASPBoundFieldENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.Caption,
            //    objASPBoundFieldENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);

            //strCodeForCs.AppendFormat("\r\n public void set{0}_q({1} value)", strTemp, objASPBoundFieldENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType);
            //strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n" + "tv{1}.setText(obj{0}EN.get{1}());",
               objViewInfoENEx.objOutRelaTab.TabName,
               objASPBoundFieldENEx.objDGRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName);
            //strCodeForCs.Append("\r\n }");
        }


        //<asp:BoundField DataField = "id_Sex" SortExpression = "id_Sex" HeaderText = "性别流水号"></asp:BoundField>
        //                          <asp:BoundField DataField = "SexID" SortExpression = "SexID" HeaderText = "性别编号"></asp:BoundField>
        //                          <asp:BoundField DataField = "SexDesc" SortExpression = "SexDesc" HeaderText = "SexDesc">
        //                          </asp:BoundField>


        /// <summary>
        /// 生成该对象相关的代码
        /// </summary>
        /// <param name="objASPBoundFieldENEx">编辑文本框对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GeneCodeBak(ASPBoundFieldEx objASPBoundFieldENEx,
            StringBuilder strCodeForCs)
        {
            string strActionId = AgcPubFun.getASPNETID();
            string strKey = "";
            if (string.IsNullOrEmpty(objASPBoundFieldENEx.mKey) == true)
            {
                strKey = "";
            }
            else
            {
                strKey = string.Format("key=\"{0}\"", objASPBoundFieldENEx.mKey);
            }

            strCodeForCs.AppendFormat("\r\n" + "<asp:BoundField");

            //生成控件的Id、Name
            clsASPControlBLEx.GC4IdName(objASPBoundFieldENEx, strCodeForCs);

            //生成控件的Tag
            clsASPControlBLEx.GC4Tag(objASPBoundFieldENEx, strCodeForCs);

            //生成控件的样式
            clsASPControlBLEx.GC4Style(objASPBoundFieldENEx, strCodeForCs);

            //生成控件的尺寸-高、宽
            clsASPControlBLEx.GC4Size(objASPBoundFieldENEx, strCodeForCs);

            //生成控件的边界尺寸-即与四周的距离
            clsASPControlBLEx.GC4Margin(objASPBoundFieldENEx, strCodeForCs);
            //生成线性布局的子控件的布局方向-横向、纵向
            if (string.IsNullOrEmpty(objASPBoundFieldENEx.orientation) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "android:orientation=\"{0}\"",
                    objASPBoundFieldENEx.orientation);
            }
            //生成控件的约束-即与四周控件的约束关系
            clsASPControlBLEx.GC4Constraint(objASPBoundFieldENEx, strCodeForCs);
            strCodeForCs.AppendFormat(">");

            foreach (ASPControlEx objSubASPControlENEx in objASPBoundFieldENEx.arrSubAspControlLst2)
            {
                //if (objSubASPControlENEx.CtlTypeId != enumCtlTypeAbbr.ASPNETAutoresizingMask) continue;
                objSubASPControlENEx.GeneCode(strCodeForCs);
            }
            strCodeForCs.AppendFormat("\r\n" + "</BoundField>");
        }
    }
}