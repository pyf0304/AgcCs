
using AGC.BusinessLogic;
using AGC.DAL;
using AGC.Entity;
using AgcCommBase;
using com.taishsoft.common;
using com.taishsoft.util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AGC.BusinessLogicEx
{

    public class GCVariableComparer : IEqualityComparer<clsGCVariableEN>
    {
        public bool Equals(clsGCVariableEN t1, clsGCVariableEN t2)
        {
            return (t1.VarId == t2.VarId);
        }
        public int GetHashCode(clsGCVariableEN t)
        {
            return t.ToString().GetHashCode();
        }
    }
    public static class clsGCVariableBLEx_Static
    {
        public static clsDataTypeAbbrEN ObjDataTypeAbbr(this clsGCVariableEN objGCVariable)
        {
            clsDataTypeAbbrEN objDataTypeAbbr = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objGCVariable.DataTypeId);
            return objDataTypeAbbr;
        }
        public static bool IsNumberType(this clsGCVariableEN objGCVariable)
        {
            var objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objGCVariable.DataTypeId);
            switch (objDataTypeAbbrEN.CsType)
            {
                case "Int":
                case "int":
                case "long":
                case "float":
                case "short":
                case "double":
                    return true;
                default:
                    return false;
            }
        }
        public static bool IsBoolType(this clsGCVariableEN objGCVariable)
        {
            var objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objGCVariable.DataTypeId);
            switch (objDataTypeAbbrEN.CsType)
            {
                case "bool":
                case "boolean":
                    return true;
                default:
                    return false;
            }
        }
        public static string GetVarDef4View(this clsGCVariableEN objGCVariable, string strViewName)
        {
            var strVarDef = "";
            if (objGCVariable.VarTypeId == enumGCVariableType.sessionStorage_0004 ||
                objGCVariable.VarTypeId == enumGCVariableType.localStorage_0003 ||
                objGCVariable.VarTypeId == enumGCVariableType.storeStorage_0009)
            {
                strVarDef = string.Format("{0}", objGCVariable.VarExpression);
            }
            else
            {
                strVarDef = string.Format("{0}.{1}", strViewName, objGCVariable.VarExpression);
            }
            return strVarDef;
        }

        public static string GetVarName4View(this clsGCVariableEN objGCVariable)
        {
            switch (objGCVariable.VarTypeId)
            {
                case enumGCVariableType.sessionStorage_0004:
                    return $"{objGCVariable.VarName}_Session";
                case enumGCVariableType.localStorage_0003:
                    return $"{objGCVariable.VarName}_Local";
                case enumGCVariableType.GivingValue_0001:
                    return $"{objGCVariable.VarName}_Giving";
                case enumGCVariableType.DefaultValue_0002:
                    return $"{objGCVariable.VarName}_Default";
                case enumGCVariableType.QueryString_0005:
                    return $"{objGCVariable.VarName}_Query";
                case enumGCVariableType.StaticValuable_0006:
                    return $"{objGCVariable.VarName}_Static";
                case enumGCVariableType.CacheClassifyField_0007:
                    return $"{objGCVariable.VarName}_Cache";
                case enumGCVariableType.Function_0008:
                    return $"{objGCVariable.VarName}_Fun";
                case enumGCVariableType.storeStorage_0009:
                    return $"{objGCVariable.VarName}_Store";
                case enumGCVariableType.Object_0010:
                    return $"{objGCVariable.VarName}_Static";
                default:
                    return $"{objGCVariable.VarName}"; 
            }
        }

        public static string TypeScriptType(this clsGCVariableEN objGCVariable)
        {
            var ObjDataTypeAbbr = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objGCVariable.DataTypeId);
            if (ObjDataTypeAbbr == null) return "string";
            return ObjDataTypeAbbr.TypeScriptType;
        }
        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objGCVariableENS">源对象</param>
        /// <returns>目标对象=>clsGCVariableEN:objGCVariableENT</returns>
        public static clsGCVariableENEx CopyToEx(this clsGCVariableEN objGCVariableENS)
        {
            try
            {
                clsGCVariableENEx objGCVariableENT = new clsGCVariableENEx();
                clsGCVariableBL.GCVariableDA.CopyTo(objGCVariableENS, objGCVariableENT);
                return objGCVariableENT;
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
        /// <param name = "objGCVariableENS">源对象</param>
        /// <returns>目标对象=>clsGCVariableEN:objGCVariableENT</returns>
        public static clsGCVariableEN CopyTo(this clsGCVariableENEx objGCVariableENS)
        {
            try
            {
                clsGCVariableEN objGCVariableENT = new clsGCVariableEN();
                clsGCVariableBL.CopyTo(objGCVariableENS, objGCVariableENT);
                return objGCVariableENT;
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
    /// <summary>
    /// GC变量(GCVariable)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsGCVariableBLEx : clsGCVariableBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsGCVariableDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsGCVariableDAEx GCVariableDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsGCVariableDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objGCVariableENS">源对象</param>
        /// <returns>目标对象=>clsGCVariableEN:objGCVariableENT</returns>
        public static clsGCVariableENEx CopyToEx(clsGCVariableEN objGCVariableENS)
        {
            try
            {
                clsGCVariableENEx objGCVariableENT = new clsGCVariableENEx();
                clsGCVariableBL.GCVariableDA.CopyTo(objGCVariableENS, objGCVariableENT);
                return objGCVariableENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000005)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 根据条件获取扩展对象列表
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        /// </summary>
        /// <param name = "strCondition">给定条件</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsGCVariableENEx> GetObjExLst(string strCondition)
        {
            List<clsGCVariableEN> arrObjLst = clsGCVariableBL.GetObjLst(strCondition);
            List<clsGCVariableENEx> arrObjExLst = new List<clsGCVariableENEx>();
            foreach (clsGCVariableEN objInFor in arrObjLst)
            {
                clsGCVariableENEx objGCVariableENEx = new clsGCVariableENEx();
                clsGCVariableBL.CopyTo(objInFor, objGCVariableENEx);
                arrObjExLst.Add(objGCVariableENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strVarId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsGCVariableENEx GetObjExByVarId(string strVarId)
        {
            clsGCVariableEN objGCVariableEN = clsGCVariableBL.GetObjByVarId(strVarId);
            clsGCVariableENEx objGCVariableENEx = new clsGCVariableENEx();
            clsGCVariableBL.CopyTo(objGCVariableEN, objGCVariableENEx);
            return objGCVariableENEx;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        /// <param name = "strPrjId">strPrjId</param>
        public static void BindDdl_VarIdCacheEx(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[GC变量]...", "0");
            
            var arrObjLst = clsGCVariableBL.GetObjLstCache()
                .Select(x=>new clsCboObject(x.VarId, clsGCVariableTypeBL.GetNameByVarTypeIdCache( x.VarTypeId) + "-" + x.VarName))
                .OrderBy(x => x.Text);
            objDDL.DataValueField = clsCboObject.con_Value;
            objDDL.DataTextField = clsCboObject.con_Text;
            objDDL.DataSource = arrObjLst;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        public static clsGCVariableEN GetObjByVarNameAndType(string strVarName, string strVarTypeId, string strPrjId)
        {
            var arrObjLst = clsGCVariableBL.GetObjLstCache();
            var myObj = arrObjLst.Find(x => x.VarName == strVarName && x.VarTypeId == strVarTypeId);
            return myObj;
        }


        public static clsGCVariableEN GetObjByVarName(string strVarName, string strPrjId)
        {
            var arrGCVariablePrjIdRela = clsGCVariablePrjIdRelaBL.GetObjLstCache(strPrjId);
            var arrVarId = arrGCVariablePrjIdRela.Select(x=>x.VarId).ToList();
            var arrObjLst = clsGCVariableBL.GetObjLstCache();
            var myObj = arrObjLst.Find(x => x.VarName == strVarName && arrVarId.Contains( x.VarId));
            return myObj;
        }


        public static string GetVarIdByVarName(string strVarName, string strPrjId)
        {
            var arrGCVariablePrjIdRela = clsGCVariablePrjIdRelaBL.GetObjLstCache(strPrjId);
            var arrVarId = arrGCVariablePrjIdRela.Select(x => x.VarId).ToList();
            var arrObjLst = clsGCVariableBL.GetObjLstCache();
            var myObj = arrObjLst.Find(x => x.VarName == strVarName && arrVarId.Contains(x.VarId));
            if (myObj != null) return myObj.VarId;
            return "";
        }

        public static List<string> GetVarIdLstByVarName(string strVarName)
        {
            //var arrGCVariablePrjIdRela = clsGCVariablePrjIdRelaBL.GetObjLstCache(strPrjId);
            //var arrVarId = arrGCVariablePrjIdRela.Select(x => x.VarId).ToList();
            var arrObjLst = clsGCVariableBL.GetObjLstCache();
            var arrVarId = arrObjLst.Where(x => x.VarName.Equals(strVarName, StringComparison.InvariantCultureIgnoreCase)).Select(x=>x.VarId).ToList();
            
            return arrVarId;
        }

        public static PubVarType getPubVarTypeByVarId(string strVarId, string ThisClsName)         
        {
            var objGCVariable = clsGCVariableBL.GetObjByVarIdCache(strVarId);
            var objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objGCVariable.DataTypeId);
            var objDataTypeAbbrENEx = objDataTypeAbbrEN.CopyToEx();
            string strDefaValue = objDataTypeAbbrENEx.DefaValue;
            if (string.IsNullOrEmpty(strDefaValue) == true) strDefaValue = "\"\"";

            string strVarName = objGCVariable.GetVarName4View();
            PubVarType myPubVar = null;
            switch (objGCVariable.VarTypeId)
            {
                case enumGCVariableType.sessionStorage_0004:
                case enumGCVariableType.localStorage_0003:

                    myPubVar = new PubVarType();
                    myPubVar.VarType = gcVarType.Session;
                    myPubVar.FldName = objGCVariable.VarName;
                    myPubVar.VarName = objGCVariable.GetVarName4View();
                    myPubVar.VarName4Get = objGCVariable.VarExpression;

                    myPubVar.IsStatic = false;
                    myPubVar.IsNeedDefine = true;
                    myPubVar.DefaultValue = strDefaValue;
                    myPubVar.Memo = "1、界面列表区主表的缓存分类字段变量1-Session,local存储";
                    return myPubVar;


                case enumGCVariableType.StaticValuable_0006:
                    myPubVar = new PubVarType();
                    myPubVar.VarType = gcVarType.Static;
                    myPubVar.FldName = objGCVariable.VarName;
                    myPubVar.IsStatic = true;
                    myPubVar.VarName = strVarName;

                    myPubVar.VarName4Get = string.Format("{0}.{1}", ThisClsName, strVarName);

                    myPubVar.IsNeedDefine = true;
                    myPubVar.DefaultValue = strDefaValue;
                    myPubVar.Memo = "5、处理添加、修改记录时PutData所用的Session缓存变量,用于获取界面编辑主表时所用的Session类字段值";
                    return myPubVar;

                case enumGCVariableType.CacheClassifyField_0007:
                    myPubVar = new PubVarType();
                    myPubVar.VarType = gcVarType.Cache;
                    myPubVar.FldName = objGCVariable.VarName;
                    myPubVar.IsStatic = false;
                    myPubVar.VarName = strVarName;
                    myPubVar.VarName4Get = string.Format("{0}.{1}", ThisClsName, strVarName);

                    myPubVar.IsNeedDefine = true;
                    myPubVar.DefaultValue = strDefaValue;
                    myPubVar.Memo = "5、处理添加、修改记录时PutData所用的Session缓存变量,用于获取界面编辑主表时所用的Session类字段值";
                    return myPubVar;

                case enumGCVariableType.GivingValue_0001:
                    myPubVar = new PubVarType();

                    myPubVar.VarType = gcVarType.Giving;
                    myPubVar.FldName = objGCVariable.VarName;
                    myPubVar.VarName = strVarName;
                    myPubVar.VarName4Get = string.Format("{0}.{1}", ThisClsName, strVarName);
                    myPubVar.IsStatic = true;
                    myPubVar.IsNeedDefine = true;
                    myPubVar.DefaultValue = strDefaValue;
                    myPubVar.Memo = "6、定义下拉框条件给定值2";
                    return myPubVar;
                case enumGCVariableType.Object_0010:
                    myPubVar = new PubVarType();

                    myPubVar.VarType = gcVarType.Object;
                    myPubVar.FldName = objGCVariable.VarName;
                    myPubVar.VarName = strVarName;
                    myPubVar.VarName4Get = string.Format("{0}.{1}", ThisClsName, strVarName);
                    myPubVar.IsStatic = true;
                    myPubVar.IsNeedDefine = true;
                    myPubVar.DefaultValue = strDefaValue;
                    myPubVar.Memo = "6、定义下拉框条件给定值2";
                    return myPubVar;
                case enumGCVariableType.DefaultValue_0002:
                    myPubVar = new PubVarType();

                    myPubVar.VarType = gcVarType.Static;
                    myPubVar.FldName = objGCVariable.VarName;
                    myPubVar.VarName = strVarName;
                    myPubVar.VarName4Get = string.Format("{0}.{1}", ThisClsName, strVarName);
                    myPubVar.IsStatic = true;
                    myPubVar.IsNeedDefine = true;
                    myPubVar.DefaultValue = strDefaValue;
                    myPubVar.Memo = "缺省值";
                    return myPubVar;
                    //return null;
                    

                default:
                    var objGCVariableType = clsGCVariableTypeBL.GetObjByVarTypeIdCache(objGCVariable.VarTypeId);

                    var strMsg = string.Format("在Switch中类型：[{0}({1})]没有被处理!(in {2})", objGCVariableType.VarTypeName, objGCVariableType.VarTypeId,
    clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                    //break;

            }
        }
    }
}