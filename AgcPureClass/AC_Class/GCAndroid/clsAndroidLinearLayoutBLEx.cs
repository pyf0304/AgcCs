
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsAndroidLinearLayoutBLEx
表名:AndroidLinearLayout
生成代码版本:2018.02.11.1
生成日期:2018/02/25 23:49:02
生成者:潘以锋
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
模块中文名:生成Android
模块英文名:GCAndroid
框架-层名:业务逻辑扩展层
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.11.28.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using AGC.BusinessLogic;
using AGC.DAL;
using AGC.Entity;
using AGC.PureClass;
using AgcCommBase;
using System.Text;

namespace AGC.PureClassEx
{
    public static class clsAndroidLinearLayoutBLEx_Static
    {
        /// <summary>
        /// 生成该对象相关的代码
        /// </summary>
        /// <param name="objAndroidLinearLayoutENEx">编辑文本框对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GeneCode(this AndroidLinearLayoutEx objAndroidLinearLayoutENEx,
            StringBuilder strCodeForCs)
        {
            string strActionId = AgcPubFun.getAndroidID();
            string strKey = "";
            if (string.IsNullOrEmpty(objAndroidLinearLayoutENEx.mKey) == true)
            {
                strKey = "";
            }
            else
            {
                strKey = string.Format("key=\"{0}\"", objAndroidLinearLayoutENEx.mKey);
            }

            strCodeForCs.AppendFormat("\r\n" + "<LinearLayout");
            if (string.IsNullOrEmpty(objAndroidLinearLayoutENEx.android) == false)
            {
                //   strCodeForCs.AppendFormat("\r\n" + "xmlns:android=\"http://schemas.android.com/apk/res/android\"");
                strCodeForCs.AppendFormat("\r\n" + "xmlns:android=\"{0}\"",
                    objAndroidLinearLayoutENEx.android);
            }
            if (string.IsNullOrEmpty(objAndroidLinearLayoutENEx.CtrlId) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "android:id=\"@+id/{0}\"",
                objAndroidLinearLayoutENEx.CtrlId);
            }
            //生成控件的Tag
            clsAndroidControlBLEx.GC4Tag(objAndroidLinearLayoutENEx, strCodeForCs);

            //生成控件的样式
            clsAndroidControlBLEx.GC4Style(objAndroidLinearLayoutENEx, strCodeForCs);

            //生成控件的尺寸-高、宽
            clsAndroidControlBLEx.GC4Size(objAndroidLinearLayoutENEx, strCodeForCs);

            //生成控件的边界尺寸-即与四周的距离
            clsAndroidControlBLEx.GC4Margin(objAndroidLinearLayoutENEx, strCodeForCs);
            //生成线性布局的子控件的布局方向-横向、纵向
            if (string.IsNullOrEmpty(objAndroidLinearLayoutENEx.orientation) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "android:orientation=\"{0}\"",
                    objAndroidLinearLayoutENEx.orientation);
            }
            //生成控件的约束-即与四周控件的约束关系
            clsAndroidControlBLEx.GC4Constraint(objAndroidLinearLayoutENEx, strCodeForCs);
            strCodeForCs.AppendFormat(">");

            foreach (AndroidControlEx objSubAndroidControlENEx in objAndroidLinearLayoutENEx.arrSubAndroidControlLst2)
            {
                //if (objSubAndroidControlENEx.CtlTypeId != enumCtlTypeAbbr.AndroidAutoresizingMask) continue;
                objSubAndroidControlENEx.GeneCode(strCodeForCs);
            }
            strCodeForCs.AppendFormat("\r\n" + "</LinearLayout>");
        }
    }
        /// <summary>
        /// Android线性布局(AndroidLinearLayout)
        /// 数据源类型:SQL表
        /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
        /// </summary>
        public class clsAndroidLinearLayoutBLEx 
    {
    
        /// <summary>
        /// 生成字段变量定义的代码
        /// </summary>
        /// <param name="objAndroidLinearLayoutENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarDef(AndroidLinearLayoutEx objAndroidLinearLayoutENEx,
            StringBuilder strCodeForCs)
        {
            strCodeForCs.AppendFormat("\r\n" + "private LinearLayout {0};",
                objAndroidLinearLayoutENEx.CtrlId);
        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objAndroidLinearLayoutENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind(AndroidLinearLayoutEx objAndroidLinearLayoutENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "{0} = (LinearLayout)findViewById(R.id.{0}); ",
                objAndroidLinearLayoutENEx.CtrlId);

        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objAndroidLinearLayoutENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind4ListView(AndroidLinearLayoutEx objAndroidLinearLayoutENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "{0} = (LinearLayout)view.findViewById(R.id.{0}); ",
                objAndroidLinearLayoutENEx.CtrlId);

        }

        /// <summary>
        /// 生成字段控件的设置控件值(查询区字段)
        /// </summary>
        /// <param name="objAndroidLinearLayoutENEx"></param>
        /// <param name="objViewInfoENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_LvFieldAssignment(AndroidLinearLayoutEx objAndroidLinearLayoutENEx, clsViewInfoENEx objViewInfoENEx,
            StringBuilder strCodeForCs)
        {
            //string strTemp = objAndroidLinearLayoutENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName;

            //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            //strCodeForCs.AppendFormat("\r\n //设置{0}({1})的值", objAndroidLinearLayoutENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.Caption,
            //    objAndroidLinearLayoutENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);

            //strCodeForCs.AppendFormat("\r\n public void set{0}_q({1} value)", strTemp, objAndroidLinearLayoutENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType);
            //strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n" + "tv{1}.setText(obj{0}EN.get{1}());",
               objViewInfoENEx.objOutRelaTab.TabName,
               objAndroidLinearLayoutENEx.objDGRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName);
            //strCodeForCs.Append("\r\n }");
        }
    }
}