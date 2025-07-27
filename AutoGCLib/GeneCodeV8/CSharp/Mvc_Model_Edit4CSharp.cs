using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AgcCommBase;
using com.taishsoft.comm_db_obj;
using com.taishsoft.commexception;
using com.taishsoft.common;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace AutoGCLib
{
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
    partial class Mvc_Model_Edit4CSharp : clsGeneCodeBase4View  
    {
        //int intZIndex;      ///控件焦点序号
        //float intCurrLeft;  ///控件的左边空;
        //float intCurrTop;  ///控件的顶面空;
        #region 构造函数
        public Mvc_Model_Edit4CSharp()
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            //InitPageSetup();
        }
        public Mvc_Model_Edit4CSharp(string strViewId)
       : base(strViewId, "", "")
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            //InitPageSetup();
        }
        public Mvc_Model_Edit4CSharp( string strViewId, string strPrjDataBaseId, string strPrjId)
        : base(strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            //InitPageSetup();
        }
        #endregion

    
        
        /// <summary>
        /// 生成指定的函数
        /// </summary>
        /// <returns>返回生成的指定函数代码</returns>
        public string A_GenCode4Function(string strFuncId4GC)
        {
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp; //临时变量;
            string strFuncName = "";
            try
            {
                //类名开始
                 clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
                strFuncName = objvFunction4GeneCodeEN.FuncName;

                //if (objFunction4GeneCodeEN.FuncTypeId == "10")//用户自定义函数
                //{
                //    strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId(objFunction4GeneCodeEN.FuncId4GC,
                //        objPrjTabENEx.TabId, objPrjTabENEx.PrjDataBaseId, objPrjTabENEx.PrjId);
                //}
                //else
                //{
                    strTemp = A_GeneFuncCode(strFuncName);
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

        protected string GenRefDomainName()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成仅有变量;
                strCodeForCs.Append("\r\n" + "using System;");
                strCodeForCs.Append("\r\n" + "using System.Data;");
                strCodeForCs.Append("\r\n" + "using System.Configuration;");
                strCodeForCs.Append("\r\n" + "using System.Collections.Generic;");
                strCodeForCs.Append("\r\n" + "using System.Collections;");
                strCodeForCs.Append("\r\n" + "using System.Text;");
                strCodeForCs.Append("\r\n" + "using System.Web;");
                strCodeForCs.Append("\r\n" + "using System.Web.Mvc;");
                strCodeForCs.Append("\r\n" + "using System.Linq;");
                strCodeForCs.Append("\r\n" + "using System.Web.Security;");
                strCodeForCs.Append("\r\n" + "using System.Web.UI;");
                strCodeForCs.Append("\r\n" + "using System.Web.UI.WebControls;");
                strCodeForCs.Append("\r\n" + "using System.Web.UI.WebControls.WebParts;");
                strCodeForCs.Append("\r\n" + "using System.Web.UI.HtmlControls;");
                strCodeForCs.Append("\r\n" + "using System.ComponentModel;");
                strCodeForCs.Append("\r\n" + "using System.ComponentModel.DataAnnotations;");

                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.common;");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.datetime;");
                strCodeForCs.Append("\r\n" + "using CommFunc4WebForm;");

                clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objViewInfoENEx.PrjId); //
                
                strCodeForCs.AppendFormat("\r\n" + "using {0}.Entity;", objProject.PrjDomain);
                strCodeForCs.AppendFormat("\r\n" + "using {0}.BusinessLogic;", objProject.PrjDomain);
                strCodeForCs.AppendFormat("\r\n" + "using {0}.BusinessLogicEx;", objProject.PrjDomain);
                strCodeForCs.AppendFormat("\r\n" + "using {0};", objProject.PrjDomain);
                strCodeForCs.AppendFormat("\r\n" + "using {0}Mvc.Models.PubFun;", objProject.PrjDomain);
                strCodeForCs.AppendFormat("\r\n" + "using {0}Mvc.Models;", objProject.PrjDomain);
                
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();

        }


        /// <summary>
        /// 生成扩展模型代码－－Asp.NET Mvc
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            this.objViewInfoENEx = objViewInfoENEx;


            if (objViewInfoENEx.arrEditRegionFldSet4InUse == null || objViewInfoENEx.arrEditRegionFldSet4InUse.Count == 0)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有编辑区域,或者编辑区域没有字段。请检查!", strViewName);
                throw new clsDbObjException(sbMessage.ToString());
            }

            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            //string strFolder;
            //string strTemp;
            objViewInfoENEx.MvcModelExName = string.Format("EditModel4{0}", objViewInfoENEx.TabName);

            objViewInfoENEx.WebUserCtlCsFName = string.Format("{0}{1}.cs", 
                objViewInfoENEx.FolderName, objViewInfoENEx.MvcModelExName);
            objViewInfoENEx.FileName = objViewInfoENEx.WebUserCtlCsFName;
            objViewInfoENEx.ClsName = objViewInfoENEx.MvcModelExName;

            strRe_ClsName = objViewInfoENEx.MvcModelExName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebUserCtlCsFName);

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
        clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objViewInfoENEx.FunctionTemplateId,
             objViewInfoENEx.LangType, objViewInfoENEx.CodeTypeId, objViewInfoENEx.SqlDsTypeId);


            try
            {
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objViewInfoENEx.CurrUserName, objViewInfoENEx));

                strCodeForCs.Append("\r\n" + "//生成与主表相关的扩展模型代码");
            
                strCodeForCs.Append("\r\n" + GenRefDomainName());    //生成参考域名

              

                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.AppendFormat("\r\n" + "namespace {0}Mvc.Models", objViewInfoENEx.NameSpace);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///		{0} 的摘要说明。", objViewInfoENEx.MvcModelExName);
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public class  {0} ",
                    objViewInfoENEx.MvcModelExName, objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.AppendFormat("\r\n" + "public {0}()",
                    objViewInfoENEx.MvcModelExName);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "[DisplayName(\"编辑消息\")]");
                strCodeForCs.Append("\r\n" + "public string Msg_Edt { get; set; }");
                List<string> arrFldName = new List<string>();
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    string strFldName = objEditRegionFldsEx.FldName;
                    string strCaption = objEditRegionFldsEx.LabelCaption;
                    string strCsType = objEditRegionFldsEx.ObjFieldTabENEx.CsType();

                    //if (objEditRegionFldsEx.objPrjTabFldENEx.FieldTypeId == enumFieldType.KeyField_02
                    //&& objEditRegionFldsEx.objPrjTabFldENEx.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    //{
                    //    continue;
                    //}
                    if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                        && objEditRegionFldsEx.PrimaryTypeId()== enumPrimaryType.StringAutoAddPrimaryKey_03)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "[DisplayName(\"{0}\")]",
                       strCaption);
                        if (objEditRegionFldsEx.IsTabNullable() == false)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "//[Required(ErrorMessage = \"请输入:{0}\")]",
                                strCaption);
                        }
                        strCodeForCs.AppendFormat("\r\n" + "public {0} {1} {{ get; set; }}",
                            strCsType, strFldName);
                        arrFldName.Add(strFldName);
                        continue;
                    }

                    strCodeForCs.AppendFormat("\r\n" + "[DisplayName(\"{0}\")]",
                        strCaption);
                    if (objEditRegionFldsEx.IsTabNullable() == false)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "[Required(ErrorMessage = \"请输入:{0}\")]",
                            strCaption);
                    }
                    strCodeForCs.AppendFormat("\r\n" + "public {0} {1} {{ get; set; }}",
                        strCsType, strFldName);
                    arrFldName.Add(strFldName);
                }
                if (arrFldName.Contains(objKeyField.FldName) == false)
                {
                    strCodeForCs.AppendFormat("\r\n" + "public {0} {1} {{ get; set; }}",
                        objKeyField.CsType, objKeyField.FldName);
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 生成扩展模型代码－－Asp.NET Mvc
        /// </summary>
        /// <returns></returns>
        public string A_GenMvcModel4Query(clsViewInfoENEx objViewInfoENEx, ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            this.objViewInfoENEx = objViewInfoENEx;


            if (objViewInfoENEx.arrEditRegionFldSet4InUse == null || objViewInfoENEx.arrEditRegionFldSet4InUse.Count == 0)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有编辑区域,或者编辑区域没有字段。请检查!", strViewName);
                throw new clsDbObjException(sbMessage.ToString());
            }

            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
           
            objViewInfoENEx.MvcModel4QueryName = string.Format("QryModel4{0}", objViewInfoENEx.TabName_Out);

            objViewInfoENEx.WebUserCtlCsFName = string.Format("{0}{1}.cs",
                objViewInfoENEx.FolderName, objViewInfoENEx.MvcModel4QueryName);
            objViewInfoENEx.FileName = objViewInfoENEx.WebUserCtlCsFName;
            objViewInfoENEx.ClsName = objViewInfoENEx.MvcModel4QueryName;

            strRe_ClsName = objViewInfoENEx.MvcModel4QueryName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebUserCtlCsFName);

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
        clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objViewInfoENEx.FunctionTemplateId,
             objViewInfoENEx.LangType, objViewInfoENEx.CodeTypeId, objViewInfoENEx.SqlDsTypeId);


            try
            {
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objViewInfoENEx.CurrUserName, objViewInfoENEx));

                strCodeForCs.Append("\r\n" + "//生成与主表相关的扩展模型代码");

                strCodeForCs.Append("\r\n" + GenRefDomainName());    //生成参考域名



                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.AppendFormat("\r\n" + "namespace {0}Mvc.Models", objViewInfoENEx.NameSpace);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///		{0} 的摘要说明。", objViewInfoENEx.MvcModelExName);
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public class  {0} ",
                    objViewInfoENEx.MvcModel4QueryName, objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "{");

            
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                   
                    string strFldName = objQryRegionFldsEx.FldName;
                    string strCaption = objQryRegionFldsEx.LabelCaption;
                    string strCsType = objQryRegionFldsEx.ObjFieldTabENEx.CsType();

                    strCodeForCs.AppendFormat("\r\n" + "[DisplayName(\"{0}\")]",
                        strCaption);
                    strCodeForCs.AppendFormat("\r\n" + "[Required(ErrorMessage = \"请输入:{0}\")]",
                        strCaption);
                    if (objQryRegionFldsEx.objCtlType.CtlTypeName == "DropDownList" && strCsType == "bool")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "public string {1} {{ get; set; }}",
                         strCsType, strFldName, "{", "}");
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "public {0} {1} {{ get; set; }}",
                            strCsType, strFldName, "{", "}");
                    }
                }

              
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_4MvcCtrl_PrepareModel()
        {          
            StringBuilder strCodeForCs = new StringBuilder();
         
            try
            {
                
                strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.Append("\r\n /// 为页面准备模型,包括：查询区信息、排序信息、分页信息等");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <param name = \"model\">模型</param>");
                strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">修改的关键字</param>", objKeyField.PrivFuncName);
                strCodeForCs.Append("\r\n /// <param name = \"sortOrder\">排序信息</param>");
                strCodeForCs.Append("\r\n /// <param name = \"page\">页号</param>");
                strCodeForCs.AppendFormat("\r\n" + "private ViewModel4{0} PrepareModel(ViewModel4{0} model, {1} {2}, string sortOrder = \"\", int page = 1)",
                    objViewInfoENEx.TabName, objKeyField.CsType, objKeyField.PrivFuncName);
                    strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strWhereCond = \" 1 =1 \";");
                strCodeForCs.AppendFormat("\r\n" + "{0}ExViewModel NewModel = null;", objViewInfoENEx.TabName);
                if (IsNumberType4Key == false)
                {
                    strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == false)",
                        objKeyField.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "if ({0} >0)",
                        objKeyField.PrivFuncName);
                }
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = cls{0}BL.GetObjBy{1}({2});",
                    objMainPrjTab.TabName, FldName4Key, objKeyField.PrivFuncName);
                strCodeForCs.AppendFormat("\r\n" + "NewModel = new ViewModel4{0}(obj{0}EN);",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "NewModel = new ViewModel4{0}();",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "if (model == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "model = new ViewModel4{0}();",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "NewModel.qryModel4{0} = model.qryModel4{0};",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.AppendFormat("\r\n" + "if (model.qryModel4{0} != null)",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "strWhereCond = Combine{0}Condition(model.qryModel4{0});",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.AppendFormat("\r\n" + "IEnumerable <cls{0}EN> arrObjLst = cls{0}BL.GetObjLst(strWhereCond);",
                    objMainPrjTab.TabName);
                bool bolIsFirst = true;
                foreach (clsDGRegionFldsENEx ObjInFor in objViewInfoENEx.arrDGRegionFldSet)
                {
                    if (bolIsFirst == true)
                    {
                        bolIsFirst = false;
                        strCodeForCs.AppendFormat("\r\n" + "ViewBag.{0}SortParm = String.IsNullOrEmpty(sortOrder) || sortOrder== \"{0}\" ? \"{0}_desc\" : \"\";",
                            ObjInFor.ObjFieldTabENEx.FldName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "ViewBag.{0}SortParm = sortOrder == \"{0}\" ? \"{0}_desc\" : \"{0}\";",
                            ObjInFor.ObjFieldTabENEx.FldName);
                    }
                }
                        strCodeForCs.Append("\r\n" + "            switch (sortOrder)");
                        strCodeForCs.Append("\r\n" + "{");
                bolIsFirst = true;
                string strFirstFieldName = "";
                foreach (clsDGRegionFldsENEx ObjInFor in objViewInfoENEx.arrDGRegionFldSet)
                {
                    if (bolIsFirst == true)
                    {
                        bolIsFirst = false;
                        strFirstFieldName = ObjInFor.ObjFieldTabENEx.FldName;
                     }
                    strCodeForCs.AppendFormat("\r\n" + "case \"{0}\":",
                        ObjInFor.ObjFieldTabENEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "arrObjLst = arrObjLst.OrderBy(s => s.{0});",
                        ObjInFor.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "break;");
                    strCodeForCs.AppendFormat("\r\n" + "case \"{0}_desc\":",
                        ObjInFor.ObjFieldTabENEx.FldName);
                        strCodeForCs.AppendFormat("\r\n" + "arrObjLst = arrObjLst.OrderByDescending(s => s.{0});",
                            ObjInFor.ObjFieldTabENEx.FldName);
                        strCodeForCs.Append("\r\n" + "break;");
                    
                }

                strCodeForCs.Append("\r\n" + "default:");
                strCodeForCs.AppendFormat("\r\n" + "arrObjLst = arrObjLst.OrderBy(s => s.{0});",
                    strFirstFieldName);
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.AppendFormat("\r\n" + "NewModel.{0}Lst = arrObjLst",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + ".Skip((page - 1) * PageSize)");
                strCodeForCs.Append("\r\n" + ".Take(PageSize);");
                strCodeForCs.Append("\r\n" + "NewModel.PagingInfo = new PagingInfo");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "CurrentPage = page,");
                strCodeForCs.Append("\r\n" + "ItemsPerPage = PageSize,");
                strCodeForCs.Append("\r\n" + "TotalItems = arrObjLst.Count()");
                strCodeForCs.Append("\r\n" + "};");
                strCodeForCs.Append("\r\n" + "return NewModel;");
                strCodeForCs.Append("\r\n" + "}");                
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        public string A_GeneFuncCode(string strFuncName)
        {
            try
            {
                switch (strFuncName)
                {

                    case "Gen_4MvcCtrl_PrepareModel":
                        return Gen_4MvcCtrl_PrepareModel();
                    case "Gen_4MvcCtrl_CombineCondition":
                        return Gen_4MvcCtrl_CombineCondition();

                        
                    default:
                        string strMsg = string.Format("功能名:{1}在Switch没有处理,请检查!({0})",
                            clsStackTrace.GetCurrClassFunction(), strFuncName);
                        throw new Exception(strMsg);
                        //            return "///该1函数不存在:" + strFuncName;
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
        }

        public string Gen_4MvcCtrl_CombineCondition()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                ///生成仅有变量;

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 把所有的查询控件内容组合成一个条件串");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <returns>条件串(strWhereCond)</returns>");
                strCodeForCs.AppendFormat("\r\n" + "protected string Combine{0}Condition(QryModel4{0} obj{0}EN)", objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//使条件串的初值为\"1 = 1\",以便在该串的后面用\"and \"添加其他条件,");
                strCodeForCs.Append("\r\n" + "//例如 1 = 1 && UserName = '张三'");
                strCodeForCs.Append("\r\n" + "string strWhereCond = \" 1 = 1 \";");
                strCodeForCs.Append("\r\n" + "//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。");

           
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    string strFldName = objQryRegionFldsEx.FldName;
                    switch (objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeId) //objEditRegionFldsEx.objCtlType.CtlTypeName
                    {

                        case enumDataTypeAbbr.bit_03:
                            strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.{1} == true)",
                                        objViewInfoENEx.TabName_Out, strFldName);
                            strCodeForCs.Append("\r\n" + "{");
                          
                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '1'\", con{1}.{0});",
                                     strFldName,
                                     objViewInfoENEx.TabName_Out,
                                     "{", "}");
                            strCodeForCs.Append("\r\n" + "}");

                            strCodeForCs.AppendFormat("\r\n" + "else");
                            strCodeForCs.Append("\r\n" + "{");
                        
                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '0'\", con{1}.{0});",
                                 objQryRegionFldsEx.FldName,
                                     objViewInfoENEx.TabName_Out,
                                    "{", "}");
                            strCodeForCs.Append("\r\n" + "}");
                            break;

                        case enumDataTypeAbbr.char_04:
                        case enumDataTypeAbbr.nvarchar_15:
                        case enumDataTypeAbbr.varchar_25:
                        case enumDataTypeAbbr.text_20:
                                strCodeForCs.AppendFormat("\r\n" + "if (string.IsNumeric(obj{0}EN.{1}))", objViewInfoENEx.TabName_Out,
                                strFldName);
                            strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);
                               
                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '{{1}}'\", con{0}.{1}, obj{0}EN.{1});",
                                        objViewInfoENEx.TabName_Out, 
                                        strFldName,                                        
                                        "{", "}");
                                        break;
                                    case "int":

                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = obj{0}EN.{1};",
                                             objViewInfoENEx.TabName_Out,
                                            objQryRegionFldsEx.FldName,
                                          objQryRegionFldsEx.CtrlId());

                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = {{1}}\", con{2}.{0}, obj{0}EN.{1});",
                                        objViewInfoENEx.TabName_Out, 
                                        objQryRegionFldsEx.FldName,
                                        
                                        "{", "}");
                                        break;
                                    default:

                                       
                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '{{1}}'\", con{0}.{1}, obj{0}EN.{1});",
                                        objViewInfoENEx.TabName_Out, 
                                        objQryRegionFldsEx.FldName,                                        
                                        "{", "}");
                                        break;
                                }
                                strCodeForCs.Append("\r\n" + "}");
                          
                            break;
                     
                }

                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.CheckProperty4Condition();",
                       objViewInfoENEx.TabName_Out);

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch(Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                  objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Combine{0}Condition", "在组合查询条件(Combine{0}Condition)时出错!请联系管理员!", "生成代码");
                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName);

                strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{1})在组合查询条件(Combine{0}Condition)时出错!请联系管理员!\" + objException.Message);",
                   objViewInfoENEx.TabName, strErrId);
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return strWhereCond;");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(Mvc_Model_Edit4CSharp);
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
        public override void GetClsName()
        {
            this.ClsName = string.Format("EditModel4{0}", objViewInfoENEx.TabName);
            objViewInfoENEx.ClsName = this.ClsName;
        }
    
    }
}
