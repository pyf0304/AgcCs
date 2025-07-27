
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsFuncPara4CodeBLEx
表名:FuncPara4Code
生成代码版本:2018.03.01.1
生成日期:2018/03/03 01:33:04
生成者:潘以锋
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
模块中文名:项目函数管理
模块英文名:PrjFunction
框架-层名:业务逻辑扩展层
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.11.28.01
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
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;

using AGC.Entity;
using System.Data;
using System.Data.SqlClient;
using AGC.DAL;
using AGC.BusinessLogic;
using com.taishsoft.datetime;

namespace AGC.BusinessLogicEx
{

    public static class clsFuncPara4CodeBLEx_Static
    {
        public static string GetParaTypeName(this clsFuncPara4CodeEN objFuncPara4CodeEN, string strProgLangTypeId)
        {
            clsDataTypeAbbrEN objDataTypeAbbr = null;
            string strParameterType = "";
            //            throw new NotImplementedException();
            switch (objFuncPara4CodeEN.DataTypeId)
            {
                case enumDataTypeAbbr.Object_29:
                    if (string.IsNullOrEmpty(objFuncPara4CodeEN.ParameterType) == false)                    return objFuncPara4CodeEN.ParameterType;
                    objDataTypeAbbr = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objFuncPara4CodeEN.DataTypeId);
                    return objDataTypeAbbr.GetTypeString(strProgLangTypeId);

               
                case enumDataTypeAbbr.ObjectLst_30:
                    strParameterType = objFuncPara4CodeEN.ParameterType.Replace("[", "<")
                              .Replace("]", ">");
                    if (string.IsNullOrEmpty(strParameterType) == false)                    return strParameterType;
                    objDataTypeAbbr = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objFuncPara4CodeEN.DataTypeId);
                    return objDataTypeAbbr.GetTypeString(strProgLangTypeId);
                case enumDataTypeAbbr.Array_31:
                    strParameterType = objFuncPara4CodeEN.ParameterType.Replace("[", "<")
                              .Replace("]", ">");
                    if (string.IsNullOrEmpty(strParameterType) == false) return strParameterType;
                    objDataTypeAbbr = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objFuncPara4CodeEN.DataTypeId);
                    return objDataTypeAbbr.GetTypeString(strProgLangTypeId);
                default:
                    objDataTypeAbbr = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objFuncPara4CodeEN.DataTypeId);
                    return objDataTypeAbbr.GetTypeString(strProgLangTypeId);
            }
            //return "";
        }
    }
        /// <summary>
        /// 函数参数4Code(FuncPara4Code)
        /// 数据源类型:SQL表
        /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
        /// </summary>
        public class clsFuncPara4CodeBLEx : clsFuncPara4CodeBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsFuncPara4CodeDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsFuncPara4CodeDAEx FuncPara4CodeDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsFuncPara4CodeDAEx();
                }
                return uniqueInstanceEx;
            }
        }
      

        /// <summary>
        /// 克隆记录
        /// </summary>
        /// <param name="strFuncParaId4Code">strFuncParaId4Code</param>
        /// <returns></returns>
        public static clsFuncPara4CodeEN CloneRecord(string strFuncParaId4Code, string strUserId)
        {
            clsFuncPara4CodeEN objFuncPara4CodeEN = clsFuncPara4CodeBL.GetObjByFuncParaId4Code(strFuncParaId4Code);

            objFuncPara4CodeEN.FuncParaId4Code = clsFuncPara4CodeBL.GetMaxStrId_S();
            objFuncPara4CodeEN.ParaName = "Copy_" + objFuncPara4CodeEN.ParaName;
            objFuncPara4CodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
            objFuncPara4CodeEN.UpdUser = strUserId;
            //if (string.IsNullOrEmpty(obj.ReturnTypeId))
            //{
            //    obj.ReturnTypeId = "29";
            //}
            try
            {
                clsFuncPara4CodeBL.AddNewRecordBySql2(objFuncPara4CodeEN);
                return objFuncPara4CodeEN;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("克隆记录出错！错误：{0}。(strFuncParaId4Code:{1})({2})",
                     objException.Message,
                     strFuncParaId4Code,
                     clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 克隆记录
        /// </summary>
        /// <param name="strFuncParaId4Code">strFuncParaId4Code</param>
        /// <returns></returns>
        public static clsFuncPara4CodeEN CloneRecordFromTemplate(string strFuncParaId4Code, string strPrjId, string strUserId)
        {
            clsFuncPara4CodeEN objFuncPara4CodeEN = clsFuncPara4CodeBL.GetObjByFuncParaId4Code(strFuncParaId4Code);

            objFuncPara4CodeEN.FuncParaId4Code = clsFuncPara4CodeBL.GetMaxStrId_S();
            objFuncPara4CodeEN.PrjId = strPrjId;
            objFuncPara4CodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
            objFuncPara4CodeEN.UpdUser = strUserId;
            //if (string.IsNullOrEmpty(obj.ReturnTypeId))
            //{
            //    obj.ReturnTypeId = "29";
            //}
            try
            {
                clsFuncPara4CodeEN objFuncPara4Code_Cond = new clsFuncPara4CodeEN();
                string strCondition = objFuncPara4Code_Cond.SetPrjId(strPrjId, "=")
                    .SetParaName(objFuncPara4CodeEN.ParaName, "=")                    
                    .SetDataTypeId(objFuncPara4CodeEN.DataTypeId, "=")
                    .GetCombineCondition();
                clsFuncPara4CodeEN objFuncPara4Code_New = clsFuncPara4CodeBL.GetFirstObj_S(strCondition);
                if (objFuncPara4Code_New != null) return objFuncPara4Code_New;
              clsFuncPara4CodeBL.AddNewRecordBySql2(objFuncPara4CodeEN);
                return objFuncPara4CodeEN;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("克隆记录出错！错误：{0}。(strFuncParaId4Code:{1})({2})",
                     objException.Message,
                     strFuncParaId4Code,
                     clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 获取代码函数的用于QueryString的参数列表
        /// </summary>
        /// <param name="strFuncId4Code">代码函数Id</param>
        /// <returns>用于QueryString的参数列表</returns>
        public static string GC_GetQueryStringLst4FuncPara(string strFuncId4Code)
        {
            StringBuilder sbCode = new StringBuilder();

            List<clsFuncPara4CodeEN> arrFuncPara4CodeObjLst =
               clsFuncPara4CodeBLEx.GetObjListByFuncId4CodeCacheEx(strFuncId4Code, enumFunctionPurpose.GeneCode_01);
            if (arrFuncPara4CodeObjLst != null)
            {
                int intIndex = 1;
                foreach (clsFuncPara4CodeEN objFuncPara4CodeEN in arrFuncPara4CodeObjLst)
                {
                    sbCode.AppendFormat("{0}=v{1}&", objFuncPara4CodeEN.ParaName, intIndex++);
                }
            }
            return sbCode.ToString();
        }
        /// <summary>
        /// 根据函数Id4Code获取相关参数对象列表, 从缓存的对象列表中获取.没有就返回null.     
        /// </summary>
        /// <param name = "strFuncId4Code">函数Id4Code</param>
        /// <param name = "strFuncPurposeId">函数目的Id</param>
        /// <returns>根据函数Id4Code获取相关参数对象列表</returns>
        public static List<clsFuncPara4CodeEN> GetObjListByFuncId4CodeCacheEx(string strFuncId4Code, string strFuncPurposeId)
        {
            if (string.IsNullOrEmpty(strFuncId4Code) == true) return null;
            IEnumerable<string> arrFuncParaId4Code = clsFuncParaRelaBLEx.GetFuncParaIdLstByFuncId4CodeCacheEx(strFuncId4Code);
            if (arrFuncParaId4Code == null)
            {
                return null;
            }
            //初始化列表缓存
            List<clsFuncPara4CodeEN> arrObjLstCache = clsFuncPara4CodeBL.GetObjLstCache(strFuncPurposeId);

            IEnumerable<clsFuncPara4CodeEN> arrFuncPara4CodeObjLst_Sel1 =
                 arrObjLstCache.Where(x => arrFuncParaId4Code.Contains(x.FuncParaId4Code));
;
            List<clsFuncPara4CodeEN> arrFuncPara4CodeObjLst_Sel = new List<clsFuncPara4CodeEN>();
            foreach (clsFuncPara4CodeEN obj in arrFuncPara4CodeObjLst_Sel1)
            {
                arrFuncPara4CodeObjLst_Sel.Add(obj);
            }
            if (arrFuncPara4CodeObjLst_Sel.Count == 0)
            {
                return null;
            }
            return arrFuncPara4CodeObjLst_Sel;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        /// <param name = "strFuncPurposeId">函数目的</param>
        /// <param name = "strPrjId">工程Id</param>
        public static void BindDdl_FuncParaId4CodeEx(System.Web.UI.WebControls.DropDownList objDDL, 
            string strFuncPurposeId, string strPrjId)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择[函数参数4Code]...", "0");
            string strCondition = string.Format("1 =1 and {0}='{1}' Order By {2}",
                conFuncPara4Code.PrjId, strPrjId, conFuncPara4Code.ParaName);
            List<clsFuncPara4CodeEN> arrObjLstCache = clsFuncPara4CodeBL.GetObjLstCache(strFuncPurposeId);

            List<clsFuncPara4CodeEN> arrObjLst = null;
            if (string.IsNullOrEmpty(strPrjId) == true)
            {
                arrObjLst = arrObjLstCache
                    .OrderBy(x => x.ParaName)
                    .ToList();
            }
            else
            {
                arrObjLst = arrObjLstCache
                    .Where(x => x.PrjId == strPrjId)
                    .OrderBy(x => x.ParaName)
                    .ToList();
            }
            arrObjLst.ForEach(x=> { if (x.ParaName.Contains(x.ParameterType) == false) x.ParaName = string.Format("{1}({0}){2}", x.ParameterType, x.ParaName, x.IsByRef ? "(ByRef)" : ""); });

            objDDL.DataValueField = conFuncPara4Code.FuncParaId4Code;
            objDDL.DataTextField = conFuncPara4Code.ParaName;
            objDDL.DataSource = arrObjLst;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        
    }
}