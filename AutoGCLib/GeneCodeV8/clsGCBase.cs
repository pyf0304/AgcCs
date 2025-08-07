using AGC.BusinessLogicEx;
using AGC.Entity;
using AgcCommBase;
using CodeStruct;
using com.taishsoft.common;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace AutoGCLib
{

    public class JsFunction : IDisposable
    {
        public StringBuilder sbText = null;
        //是否回收完毕
        bool _disposed;
        /// <summary>
        /// 函数名
        /// </summary>
        public string funcName { get; set; }
        /// <summary>
        /// 函数文本内容
        /// </summary>
        public string funcText
        {
            get { return sbText.ToString(); }
        }

        public JsFunction()
        {
            sbText = new StringBuilder();

        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return; //如果已经被回收,就中断执行
            if (disposing)
            {
                //TODO:释放那些实现IDisposable接口的托管对象
            }
            //TODO:释放非托管资源,设置对象为null
            _disposed = true;
        }
    }


    /// <summary>
    /// 该类专门用生成数据表的表代理层,该代理层是逻辑层的一部分,体系结构从下到下,
    /// 共分以下几层:
    ///		1、界面层
    ///			通用界面层,专门提供一些界面控件的公共操作函数
    ///		2、逻辑层
    ///			2.1 业务逻辑层
    ///			2.2 表代理层。包括:
    ///					1)表记录的添加、
    ///					2)表记录的删除
    ///					3)表记录的修改
    ///					4)表记录的查询
    ///					5)获取某些表记录的有关字段属性
    ///					6)设置表记录的有关字段属性等。
    ///		3、数据层,即通用数据层,专门用于操作数据库的一些操作,以及操作表的一些通用操作
    /// </summary>
    public abstract partial class clsGCBase : IImportClass
    {
        public CodeElement objCodeElement_Root = null;
        protected CodeElement objCodeElement_Class = null;
        protected CodeElement objCodeElement_Imports = null;
        public List<PubVarType> pubVarTypes = null;
        public abstract string thisPrjId { get; }
        protected bool isFstLcase = false;      //是否属性首字母小写
        protected string strBaseUrl = "../..";
        protected string strTabNameHead;
        protected string strTabNameHeadEx;
        protected string strControllerName;
        protected string strControllerNameEx;
        protected string strConstructorName;
        protected string strConstructorNameEx;

        protected string strIsUseFunc = null;
        protected string strIsUseFunc4ExcelExport = null;
        protected CacheClassify4View myCacheClassify4View = null;
        protected CacheClassify objCacheClassify_TS = null;
        protected CacheClassify objCacheClassify_List_TS = null;
        protected CacheClassify objCacheClassify_ExportExcel_TS = null;
        protected CacheClassify objCacheClassify = null;
        protected TabProp objTabProp_TS = null;
        protected TabProp objEditTabProp_TS = null;
        protected TabProp objDetailTabProp_TS = null;

        protected TabProp objExcelExportTabProp_TS = null;
        protected TabProp objListTabProp_TS = null;

        protected TabProp objViewTabProp_TS = null;

        
        //protected clsPrjTabENEx objPrjTabEx_EditRegion = null;

        protected int intZIndex;      ///控件焦点序号
        protected float intCurrLeft;  ///控件的左边空;
        protected float intCurrTop;  ///控件的顶面空;
        public bool IsHasOrderFunc = false;//是否有排序函数

        //public string controllerName = "_";
        //public string constructorName = "";
        public clsFunction4CodeEN Re_objFunction4Code = null;
        public List<JsFunction> arrJsFunction = null;
        public List<string> arrDdlKeyIdLst = null;
        public List<ImportClass> arrImportClass = null;// new List<ImportClass>();
        //public List<ImportClass> arrImportClass_RemoveDup = null;// new List<ImportClass>();

        protected clsPrjTabFldENEx mobjKeyField = null;
        protected clsPrjTabFldENEx mobjPrefixField = null;
      

        public string CmPrjId { get; set; }


        protected clsPrjTabFldENEx mobjDelSignField = null;

        protected clsPrjTabFldENEx mobjOrderNumField = null;
        /// <summary>
        /// 序号字段对象
        /// </summary>
        protected clsFieldTabENEx mobjSortField = null;
        /// <summary>
        /// 默认排序字段对象
        /// </summary>
        protected clsPrjTabFldENEx mobjNameField = null;

        /// <summary>
        /// 名称字段对象
        /// </summary>

        public clsFuncModule_AgcEN objFuncModuleEN { get => mobjFuncModuleEN; set => mobjFuncModuleEN = value; }
        public clsPrjDataBaseEN objPrjDataBaseEN { get => mobjPrjDataBaseEN; set => mobjPrjDataBaseEN = value; }
        public clsWebSrvClassENEx objWebSrvClassENEx { get => mobjWebSrvClassENEx; set => mobjWebSrvClassENEx = value; }
        public string WebSrvClassId { get => mstrWebSrvClassId; set => mstrWebSrvClassId = value; }
        public string ClsName { get => mstrClsName; set => mstrClsName = value; }
        public string BaseClsName { get; set; }
    
        

        protected clsFuncModule_AgcEN mobjFuncModuleEN = null;

        protected clsProjectsENEx mobjProjectsENEx = null;

        protected clsPrjDataBaseEN mobjPrjDataBaseEN = null;

        protected clsWebSrvClassENEx mobjWebSrvClassENEx = null;

        

        private string mstrWebSrvClassId = "";
        //protected //CommProgramSet.clsComm objComm = new CommProgramSet.clsComm();
        private string mstrClsName = "";
        //public string objPrjTabENEx.ClsName;
        protected string strClsNameEx;
        public string ClsNameEx;
        //public string strTemp;
        protected string strDataBaseType = clsPubConst.con_MsSql;
       
        //protected string objPrjTabENEx.FileName;

        #region 构造函数

        public clsGCBase()
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            clsErrorIdManageBLEx.arrErrIdLstCache = null;
            arrJsFunction = new List<JsFunction>();
            this.Re_objFunction4Code = new clsFunction4CodeEN();
            pubVarTypes = new List<PubVarType>();
        }
        public clsGCBase(string strPrjId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            clsErrorIdManageBLEx.arrErrIdLstCache = null;
            arrJsFunction = new List<JsFunction>();
            this.Re_objFunction4Code = new clsFunction4CodeEN();
            pubVarTypes = new List<PubVarType>();
        }
     

        public abstract string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code);



        #endregion

        public string AccessNull_Sub4WS(string strContent, string strPropType, bool bolIsNullable)
        {
            //			string strReturn;
            //			strReturn = "";
            switch (strPropType)
            {
                case "string":
                    return strContent;
                case "int":
                    if (bolIsNullable == true)
                    {
                        return "com.taishsoft.common.clsTranslate.TransNullToInt_S(" + strContent + ")";
                    }
                    else
                    {
                        return "Int32.Parse(" + strContent + ")";
                    }
                case "short":
                    if (bolIsNullable == true)
                    {
                        return "com.taishsoft.common.clsTranslate.TransNullToShort_S(" + strContent + ")";
                    }
                    else
                    {
                        return "short.Parse(" + strContent + ")";
                    }
                case "DateTime":
                    if (bolIsNullable == true)
                    {
                        return "com.taishsoft.common.clsTranslate.TransNullToDate_S(" + strContent + ")";
                    }
                    else
                    {
                        return "System.DateTime.Parse(" + strContent + ")";
                    }
                case "Single":
                case "float":
                    if (bolIsNullable == true)
                    {
                        return "com.taishsoft.common.clsTranslate.TransNullToFloat_S(" + strContent + ")";
                    }
                    else
                    {
                        return "Single.Parse(" + strContent + ")";
                    }
                case "Double":
                case "Money":
                case "double":
                    if (bolIsNullable == true)
                    {
                        return "com.taishsoft.common.clsTranslate.TransNullToDouble_S(" + strContent + ")";
                    }
                    else
                    {
                        return "Double.Parse(" + strContent + ")";
                    }
                case "bool":
                    if (bolIsNullable == true)
                    {
                        return "com.taishsoft.common.clsTranslate.TransNullToBool_S(" + strContent + ")";
                    }
                    else
                    {
                        return "com.taishsoft.common.clsTranslate.TransNullToBool_S(" + strContent + ")";
                        //20070701--return "bool.Parse(" + strContent + ")";
                    }
                case "Decimal":
                    if (bolIsNullable == true)
                    {
                        return "com.taishsoft.common.clsTranslate.TransNullToDouble_S(" + strContent + ")";
                    }
                    else
                    {
                        return "Double.Parse(" + strContent + ")";
                    }
                case "Long":
                case "long":
                    if (bolIsNullable == true)
                    {
                        return "com.taishsoft.common.clsTranslate.TransNullToInt_S(" + strContent + ")";
                    }
                    else
                    {
                        return "Int32.Parse(" + strContent + ")";
                    }
                case "Byte":
                    if (bolIsNullable == true)
                    {
                        return "com.taishsoft.common.clsTranslate.TransNullToInt_S(" + strContent + ")";
                    }
                    else
                    {
                        return strContent;
                    }
                case "byte[]":
                    return "(byte[])" + strContent;
                case "byte":
                    return "(byte)" + strContent;
                case "Int16":
                    if (bolIsNullable == true)
                    {
                        return "com.taishsoft.common.clsTranslate.TransNullToInt_S(" + strContent + ")";
                    }
                    else
                    {
                        return "Int32.Parse(" + strContent + ")";
                    }
                case "System.Guid":
                    if (bolIsNullable == true)
                    {
                        return strContent;
                    }
                    else
                    {
                        return strContent;
                    }
                default:
                    if (bolIsNullable == true)
                    {
                        return strContent;
                    }
                    else
                    {
                        return strContent;
                    }
            }
        }//end of AccessNull

        public string AccessNull(string strContent, string strPropType, bool bolIsNullable)
        {
            //			string strReturn;
            //			strReturn = "";
            switch (strPropType)
            {
                case "string":
                    return strContent;
                case "int":
                    return "TransNullToInt(" + strContent + ")";
                case "short":
                    return "TransNullToShort(" + strContent + ")";
                case "DateTime":
                    return "TransNullToDate(" + strContent + ")";
                case "Single":
                case "float":
                    return "TransNullToFloat(" + strContent + ")";
                case "Double":
                case "Money":
                case "double":
                    return "TransNullToDouble(" + strContent + ")";
                case "bool":
                    return "TransNullToBool(" + strContent + ")";
                case "Decimal":
                    return "TransNullToDouble(" + strContent + ")";
                case "Long":
                case "long":
                    return "TransNullToInt(" + strContent + ")";
                case "Byte":
                    if (bolIsNullable == true)
                    {
                        return "TransNullToInt(" + strContent + ")";
                    }
                    else
                    {
                        return strContent;
                    }
                case "byte[]":
                    return "(byte[])" + strContent;
                case "byte":
                    return "(byte)" + strContent;
                case "Int16":

                    return "TransNullToInt(" + strContent + ")";

                case "System.Guid":
                    if (bolIsNullable == true)
                    {
                        return strContent;
                    }
                    else
                    {
                        return strContent;
                    }
                default:
                    if (bolIsNullable == true)
                    {
                        return strContent;
                    }
                    else
                    {
                        return strContent;
                    }
            }
        }//end of AccessNull


        public string AccessNull_Static(string strContent, string strPropType, bool bolIsNullable)
        {
            //			string strReturn;
            //			strReturn = "";
            switch (strPropType)
            {
                case "string":
                    return strContent;
                case "int":
                    if (bolIsNullable == true)
                    {
                        return "clsEntityBase2.TransNullToInt_S(" + strContent + ")";
                    }
                    else
                    {
                        return "Int32.Parse(" + strContent + ")";
                    }
                case "short":
                    if (bolIsNullable == true)
                    {
                        return "clsEntityBase2.TransNullToShort_S(" + strContent + ")";
                    }
                    else
                    {
                        return "short.Parse(" + strContent + ")";
                    }
                case "DateTime":
                    if (bolIsNullable == true)
                    {
                        return "clsEntityBase2.TransNullToDate_S(" + strContent + ")";
                    }
                    else
                    {
                        return "System.DateTime.Parse(" + strContent + ")";
                    }
                case "Single":
                case "float":
                    if (bolIsNullable == true)
                    {
                        return "clsEntityBase2.TransNullToFloat_S(" + strContent + ")";
                    }
                    else
                    {
                        return "Single.Parse(" + strContent + ")";
                    }
                case "Double":
                case "Money":
                case "double":
                    if (bolIsNullable == true)
                    {
                        return "clsEntityBase2.TransNullToDouble_S(" + strContent + ")";
                    }
                    else
                    {
                        return "Double.Parse(" + strContent + ")";
                    }
                case "bool":
                    if (bolIsNullable == true)
                    {
                        return "clsEntityBase2.TransNullToBool_S(" + strContent + ")";
                    }
                    else
                    {
                        return "clsEntityBase2.TransNullToBool_S(" + strContent + ")";
                        //20070701--return "bool.Parse(" + strContent + ")";
                    }
                case "Decimal":
                    if (bolIsNullable == true)
                    {
                        return "clsEntityBase2.TransNullToDouble_S(" + strContent + ")";
                    }
                    else
                    {
                        return "Double.Parse(" + strContent + ")";
                    }
                case "Long":
                case "long":
                    if (bolIsNullable == true)
                    {
                        return "clsEntityBase2.TransNullToInt_S(" + strContent + ")";
                    }
                    else
                    {
                        return "Int32.Parse(" + strContent + ")";
                    }
                case "Byte":
                    if (bolIsNullable == true)
                    {
                        return "clsEntityBase2.TransNullToInt_S(" + strContent + ")";
                    }
                    else
                    {
                        return strContent;
                    }
                case "byte[]":
                    return "(byte[])" + strContent;
                case "byte":
                    return "(byte)" + strContent;
                case "Int16":
                    if (bolIsNullable == true)
                    {
                        return "clsEntityBase2.TransNullToInt_S(" + strContent + ")";
                    }
                    else
                    {
                        return "Int32.Parse(" + strContent + ")";
                    }
                case "System.Guid":
                    if (bolIsNullable == true)
                    {
                        return strContent;
                    }
                    else
                    {
                        return strContent;
                    }
                default:
                    if (bolIsNullable == true)
                    {
                        return strContent;
                    }
                    else
                    {
                        return strContent;
                    }
            }
        }//end of AccessNull

        public string Mark(clsPrjTabFldENEx pobjField)
        {
            if (pobjField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
            {
                return "\"\'\"";
            }
            else
            {
                return "\"\"";
            }

        }
        

        public string GenConnectString()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///用户指定的连接串,如果用户不指定该连接串,就用PUBDATABASE中所指定的连接串;
            strCodeForCs.Append("\r\n//用户指定的连接串,如果用户不指定该连接串,就用PUBDATABASE中所指定的连接串");
            strCodeForCs.Append("\r\nprivate static string m_strConnectString;");
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 当前所使用的连接串内容");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");

            strCodeForCs.Append("\r\npublic static string ConnectString");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nget { return m_strConnectString; }");
            strCodeForCs.Append("\r\nset { m_strConnectString = value; }");
            strCodeForCs.Append("\r\n}");

            return strCodeForCs.ToString();
        }

        public string GenpErrNo()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///属性过程;
            ///每个表类都应该有的错误代码类;
            strCodeForCs.Append("\r\npublic int ErrNo");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n get");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n return mintErrNo;");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n set");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n mintErrNo = value;");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n }");
            return strCodeForCs.ToString();
        }
        public string GenDispErrMsg()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            ///每个表类都应该有的对外显示的错误信息;
            strCodeForCs.Append("\r\npublic string DispErrMsg //对外显示的错误信息");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n get");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n return objPrjTabENEx.DispErrMsg;");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n set");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n objPrjTabENEx.DispErrMsg = value;");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n }");
            return strCodeForCs.ToString();
        }


        public string GenClassConstructorEx1()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            ///类构造器----------------------------------------------;
            strCodeForCs.Append("\r\n public " + ClsNameEx + "()" + ": base()");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n }");
            return strCodeForCs.ToString();
        }

        public virtual string Gen_GetSpecSQLObj()
        {
            return "";

        }

        protected string A_GeneFuncCodeBase(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, Type t)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                //Type t = typeof(WA_ViewScriptCS_TS4TypeScript);
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
                string strMsg = "";
                if (objException.InnerException != null && string.IsNullOrEmpty(objException.InnerException.Message) == false)
                {
                    strMsg = objException.InnerException.Message;
                }
                else
                {
                    strMsg = objException.Message;
                }
                sbMessage.AppendFormat("在生成函数:{0}时出错. \r\n出错信息:{1}.", strFuncName, strMsg);
                throw new Exception(sbMessage.ToString());
            }
        }
        public ImportClass AddImportClass(string strTabId, string strClassName, string strFuncName, string strImportObjType, string strBasePath)
        {
            return clsPubFun4GC.AddImportClass(strTabId, strClassName, strFuncName, strImportObjType, strBasePath, arrImportClass, thisPrjId);
        }

        public abstract void GetClsName();

        public bool IsFstLcase { get => isFstLcase; set => isFstLcase = value; }

        public abstract string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName);

    }
}
