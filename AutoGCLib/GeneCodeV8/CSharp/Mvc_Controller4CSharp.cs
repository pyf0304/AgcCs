using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AgcCommBase;
using com.taishsoft.comm_db_obj;
using com.taishsoft.commexception;
using com.taishsoft.common;
using System;
using System.Collections.Generic;
using System.Linq;
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
    partial class Mvc_Controller4CSharp : clsGeneCodeBase4View
    {
        private string strKeyFldName_ObjName = "";


        #region 构造函数
      
        public Mvc_Controller4CSharp(string strViewId)
       : base(strViewId, "", "")
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            InitPageSetup();
        }
        public Mvc_Controller4CSharp(string strViewId, string strPrjDataBaseId, string strPrjId)
        : base(strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            InitPageSetup();
        }

        /// <summary>
        /// 初始化页面设置
        /// </summary>
        public void InitPageSetup()
        {
            //intZIndex = 100;        ///控件焦点序号
            //intCurrLeft = 10;  ///控件的左边空;
            //intCurrTop = 10;
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
                strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
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
                strCodeForCs.AppendFormat("\r\n" + "using {0}Mvc.BusinessLogic;", objProject.PrjDomain);
                
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();

        }


        /// <summary>
        /// 生成业务逻辑层代码－－C#.NET
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strFuncName = "";
            this.objViewInfoENEx = objViewInfoENEx;


            if (objViewInfoENEx.arrEditRegionFldSet4InUse == null || objViewInfoENEx.arrEditRegionFldSet4InUse.Count == 0)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有编辑区域,或者编辑区域没有字段。请检查!", strViewName);
                throw new clsDbObjException(sbMessage.ToString());
            }
            //var arrPrjTabFldEx = objPrjTabENEx.arrKeyFldSet;
            //var arrKeyFldName = arrPrjTabFldEx.Select(x => x.FldName).ToList();
            //var arrKeyFldName_ObjName = arrKeyFldName.Select(x => string.Format("obj{0}EN.{1}", objPrjTabENEx.TabName, x));
            //strKeyFldName_ObjName = string.Join(",", arrKeyFldName_ObjName);

            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            //string strFolder;
            string strTemp;
            objViewInfoENEx.MvcControllerName = string.Format("{0}Controller", objViewInfoENEx.TabName);

            objViewInfoENEx.WebUserCtlCsFName = string.Format("{0}{1}.cs",
                objViewInfoENEx.FolderName, objViewInfoENEx.MvcControllerName);
            objViewInfoENEx.FileName = objViewInfoENEx.WebUserCtlCsFName;
            objViewInfoENEx.ClsName = objViewInfoENEx.MvcControllerName;

            strRe_ClsName = objViewInfoENEx.MvcControllerName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebUserCtlCsFName);

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
        clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objViewInfoENEx.FunctionTemplateId,
             objViewInfoENEx.LangType, objViewInfoENEx.CodeTypeId, objViewInfoENEx.SqlDsTypeId);


            try
            {
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objViewInfoENEx.CurrUserName, objViewInfoENEx));

                strCodeForCs.Append("\r\n" + "//生成与表相关的控件控制层代码");

                strCodeForCs.Append("\r\n" + GenRefDomainName());    //生成参考域名



                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.AppendFormat("\r\n" + "namespace {0}Mvc.Controllers", objViewInfoENEx.NameSpace);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///		{0} 的摘要说明。", objViewInfoENEx.MvcControllerName);
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public partial class  {0} : {1}BaseController",
                    objViewInfoENEx.MvcControllerName, objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.Append("\r\n" + "public int PageSize = 10;");
                //strCodeForCs.Append("\r\n" + "public int RecordNum = 0;");
                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;

                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }

                }

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
       
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
                strCodeForCs.AppendFormat("\r\n" + "private ViewModel4{0} PrepareModel(ViewModel4{0} model, {1} {2} = {3}, string sortOrder = \"\", int page = 1)",
                    objViewInfoENEx.TabName, objKeyField.CsType, objKeyField.PrivFuncName,
                    IsNumberType4Key?"0":"\"\"");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strWhereCond = \" 1 =1 \";");
                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModel = null;",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "//关键字不为空,说明是修改");
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
                strCodeForCs.AppendFormat("\r\n" + "NewModel = new ViewModel4{0}();",
                    objMainPrjTab.TabName);
                strCodeForCs.AppendFormat("\r\n" + "GetDataFrom{0}Class(obj{0}EN, NewModel);",
                    objMainPrjTab.TabName);

                strCodeForCs.AppendFormat("\r\n" + "if (seQryModel4{0} != null)",
                    objViewInfoENEx.TabName_Out   );
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "NewModel.qryModel4{0} = seQryModel4{0};",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else if (model == null)"); 
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//model为空,从View没有获取模型,可能是首次调用该View, 或者没有从View没有获取模型");

                strCodeForCs.AppendFormat("\r\n" + "NewModel = new ViewModel4{0}();",
                    objMainPrjTab.TabName);
                strCodeForCs.AppendFormat("\r\n" + "if (seQryModel4{0} != null)",
    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "NewModel.qryModel4{0} = seQryModel4{0};",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "}");


                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");            
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//model不为空,从View获取了模型。");
                strCodeForCs.Append("\r\n" + "//1、根据模型中获取的查询信息获取条件,查询相关记录对象列表。");
                strCodeForCs.Append("\r\n" + "//2、把查询区的数据带回到View中。");
                strCodeForCs.Append("\r\n" + "//3、把编辑区的数据带回到View中。");

                strCodeForCs.AppendFormat("\r\n" + "NewModel = model;",
                    objMainPrjTab.TabName);
              
                //strCodeForCs.AppendFormat("\r\n" + "NewModel.qryModel4{0} = model.qryModel4{0};",
                //    objViewInfoENEx.TabName_Out);
            
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.AppendFormat("\r\n" + "if (NewModel.qryModel4{0} != null)",
                objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "strWhereCond = Combine{0}Condition(NewModel.qryModel4{0});",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "string strSortOrder = sortOrder.Replace(\"_desc\", \" desc\");");
                strCodeForCs.AppendFormat("\r\n" + "IEnumerable <cls{0}EN> arrObjLst = cls{0}BL.GetObjLstByPager(page, PageSize, strWhereCond, strSortOrder);",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "this.RecordNum = cls{0}BL.GetRecCountByCond(strWhereCond);",
                    objViewInfoENEx.TabName_Out);

                //strCodeForCs.Append("\r\n" + "IEnumerable <cls{0}EN> arrObjLst2 = arrObjLst;", objMainPrjTab.TabName);
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

                strCodeForCs.AppendFormat("\r\n" + "NewModel.{0}Lst = arrObjLst;",
                    objViewInfoENEx.TabName_Out);
                //strCodeForCs.Append("\r\n" + ".Skip((page - 1) * PageSize)");
                //strCodeForCs.Append("\r\n" + ".Take(PageSize);");
                strCodeForCs.Append("\r\n" + "NewModel.PagingInfo = new PagingInfo");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "CurrentPage = page,");
                strCodeForCs.Append("\r\n" + "ItemsPerPage = PageSize,");
                strCodeForCs.Append("\r\n" + "TotalItems = this.RecordNum");
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

        public string Gen_4MvcCtrl_Create()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 新建记录");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public ViewResult Create()",
                    objViewInfoENEx.TabName, objKeyField.CsType, objKeyField.PrivFuncName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "PrepareDdlViewData();");

                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModel = PrepareModel(null);",
                    objMainPrjTab.TabName);
                if (IsNumberType4Key == false)
                {
                    if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "NewModel.{0} = cls{1}BL.GetMaxStrId_S();",
                            objKeyField.FldName, objMainPrjTab.TabName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "//NewModel.{0} = cls{1}BL.GetMaxStrId_S();",
                            objKeyField.FldName, objMainPrjTab.TabName);
                    }
                }
                strCodeForCs.Append("\r\n" + "ViewBag.Operate = \"Add\";");
                strCodeForCs.AppendFormat("\r\n" + "return View(\"{0}CRUD\", NewModel);",
                    objMainPrjTab.TabName);

                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_4MvcCtrl_Update()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 修改记录");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public ViewResult Update({0} {1})",
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,  FldName4Key, objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "PrepareDdlViewData();");

                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModel = PrepareModel(null, {1});",
                    objMainPrjTab.TabName, FldName4Key);

                strCodeForCs.Append("\r\n" + "ViewBag.Operate = \"Update\";");
                //strCodeForCs.AppendFormat("\r\n" + "NewModel.{0} = cls{1}BL.GetMaxStrId_S();",
                //    FldName4Key, objMainPrjTab.TabName);
                strCodeForCs.AppendFormat("\r\n" + "seKeyId = {0};", FldName4Key);

                strCodeForCs.AppendFormat("\r\n" + "return View(\"{0}CRUD\", NewModel);",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_4MvcCtrl_List()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 专门用于分页中的显示列表记录");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/// <param name=\"page\"></param>");
                strCodeForCs.Append("\r\n" + "/// <returns></returns>");
                strCodeForCs.AppendFormat("\r\n" + "public ActionResult List(int page = 1)",
                    FldName4Key);
                strCodeForCs.Append("\r\n" + "{");
           
                strCodeForCs.Append("\r\n" + "seIsAjax = false;");
                strCodeForCs.Append("\r\n" + "PrepareDdlViewData();");

                strCodeForCs.Append("\r\n" + "string sortOrder = seSortOrder;");
                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} model = new ViewModel4{0}();",
                    objMainPrjTab.TabName);
                strCodeForCs.AppendFormat("\r\n" + "model.qryModel4{0} = seQryModel4{0};",
                    objViewInfoENEx.TabName_Out);

                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModel = PrepareModel(model, {1}, sortOrder, page);",
                    objMainPrjTab.TabName, IsNumberType4Key ? "0" : "\"\"");
         
                strCodeForCs.AppendFormat("\r\n" + "return View(\"{0}CRUD\", NewModel);",
                    objMainPrjTab.TabName);
         
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        public string Gen_4MvcCtrl_Pager()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 专门用于分页中的显示列表记录");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/// <param name=\"page\"></param>");
                strCodeForCs.Append("\r\n" + "/// <returns></returns>");
                strCodeForCs.AppendFormat("\r\n" + "public ActionResult {0}_Pager(int page = 1)",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                        
                strCodeForCs.Append("\r\n" + "PrepareDdlViewData();");

                strCodeForCs.Append("\r\n" + "string sortOrder = seSortOrder;");
                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} model = new ViewModel4{0}();",
                    objMainPrjTab.TabName);
                strCodeForCs.AppendFormat("\r\n" + "model.qryModel4{0} = seQryModel4{0};",
                    objViewInfoENEx.TabName_Out);

                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModel = PrepareModel(model, {1}, sortOrder, page);",
                    objMainPrjTab.TabName, IsNumberType4Key ? "0" : "\"\"");

                strCodeForCs.AppendFormat("\r\n" + "return View(\"{0}CRUD\", NewModel);",
                    objMainPrjTab.TabName);

                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_4MvcCtrl_RedirectToList()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 根据是否是Ajax,分别重定向到相应启动View");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/// <returns></returns>");
                strCodeForCs.AppendFormat("\r\n" + "public ActionResult RedirectToList()",
                    FldName4Key);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if (seIsAjax == true)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return RedirectToAction(\"ListAjax\");");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + " {");
                strCodeForCs.Append("\r\n" + "return RedirectToAction(\"List\");");
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
        
        public string Gen_4MvcCtrl_Query()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 查询记录");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/// <param name=\"model\">从View获取的模型数据</param>");
                strCodeForCs.Append("\r\n" + "/// <returns></returns>");
                strCodeForCs.AppendFormat("\r\n" + "public ActionResult {1}_Query(ViewModel4{0} model)",
                    objMainPrjTab.TabName, objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "PrepareDdlViewData();");

                strCodeForCs.Append("\r\n" + "string sortOrder = seSortOrder;");
      
                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModel = PrepareModel(model, {1}, sortOrder);",
                    objMainPrjTab.TabName, IsNumberType4Key ? "0" : "\"\"");
                strCodeForCs.AppendFormat("\r\n" + "seQryModel4{0} = model.qryModel4{0};",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "return View(\"{0}CRUD\", NewModel);",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        public string Gen_4MvcCtrl_QueryAjax()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 查询记录");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/// <param name=\"model\">从View获取的模型数据</param>");
                strCodeForCs.Append("\r\n" + "/// <returns></returns>");
                strCodeForCs.AppendFormat("\r\n" + "public PartialViewResult QueryAjax(ViewModel4{0} model)",
                    objMainPrjTab.TabName, objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string sortOrder = seSortOrder;");

                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModel = PrepareModel(model, {1}, sortOrder);",
                    objMainPrjTab.TabName, IsNumberType4Key ? "0" : "\"\"");
                strCodeForCs.AppendFormat("\r\n" + "seQryModel4{0} = model.qryModel4{0};",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "return PartialView(\"{0}LstAjax\", NewModel);",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }     

        public string Gen_4MvcCtrl_Delete()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 删除数据列表中单选的一条记录");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/// <param name=\"checkedId\">多选的关键字列表</param>");
                strCodeForCs.Append("\r\n" + "/// <returns></returns>");
                strCodeForCs.AppendFormat("\r\n" + "public ActionResult Delete({0} {1})",
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    FldName4Key);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "PrepareDdlViewData();");
                              
                strCodeForCs.Append("\r\n" + " try");
                strCodeForCs.Append("\r\n" + "            {");
                strCodeForCs.AppendFormat("\r\n" + "int intRecCount = cls{0}BL.DelRecord({1});",
                            objMainPrjTab.TabName, FldName4Key);
                strCodeForCs.Append("\r\n" + "                if (intRecCount == 1)");
                strCodeForCs.Append("\r\n" + "                {");
                strCodeForCs.AppendFormat("\r\n" + "                    TempData[\"message\"] = string.Format(\"[{{0}}] 已经被删除!\", {0});",
                    FldName4Key);
                strCodeForCs.Append("\r\n" + "                }");
                strCodeForCs.Append("\r\n" + "                else");
                strCodeForCs.Append("\r\n" + "                {");
                strCodeForCs.AppendFormat("\r\n" + "                    TempData[\"message\"] = string.Format(\"[{{0}}] 可能已经被删除!\", {0});",
                    FldName4Key);
                strCodeForCs.Append("\r\n" + "                }");
                strCodeForCs.Append("\r\n" + "            }");
                strCodeForCs.Append("\r\n" + "            catch(Exception objException)");
                strCodeForCs.Append("\r\n" + "            {");
                strCodeForCs.AppendFormat("\r\n" + "                string strMsg = string.Format(\"删除记录出错!关键字:[{{0}}].出错信息:{{1}}.\", {0}, objException.Message);",
                    FldName4Key);
                strCodeForCs.Append("\r\n" + "                TempData[\"message\"] = strMsg;");
                strCodeForCs.Append("\r\n" + "            }");
                strCodeForCs.Append("\r\n" + "            return RedirectToList();");


                //strCodeForCs.Append("\r\n" + "string sortOrder = seSortOrder;");
                //strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} model = new ViewModel4{0}();",
                //    objMainPrjTab.TabName);
                //strCodeForCs.AppendFormat("\r\n" + "model.qryModel4{0} = seQryModel4{0};",
                //    objViewInfoENEx.TabName_Out);

                //strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModel = PrepareModel(model, {1}, sortOrder);",
                //    objMainPrjTab.TabName, IsNumberType4Key ? "0" : "\"\"");
                //strCodeForCs.AppendFormat("\r\n" + "return View(\"{0}CRUD\", NewModel);",
                //    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
            

        public string Gen_4MvcCtrl_GetObjByKey()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 根据关键字获取对象");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/// <param name=\"{0}\">关键字</param>");
                strCodeForCs.Append("\r\n" + "/// <returns>Json对象</returns>");
                strCodeForCs.AppendFormat("\r\n" + "public ActionResult GetObjBy{1}({0} {1})",
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    FldName4Key);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = cls{0}BL.GetObjBy{1}({1});",
                    objMainPrjTab.TabName, FldName4Key);
                strCodeForCs.Append("\r\n" + "   if (seIsAjax == true)");
                strCodeForCs.Append("\r\n" + " {");
                strCodeForCs.AppendFormat("\r\n" + "return View(\"{0}CRUDAjax\", (object)obj{0}EN);",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + " {");
                strCodeForCs.AppendFormat("\r\n" + "return View(\"{0}CRUD\", (object)obj{0}EN);",
                    objMainPrjTab.TabName);
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


        public string Gen_4MvcCtrl_GetJsonObjByKey()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 根据关键字获取Json对象");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/// <param name=\"{0}\">关键字</param>");
                strCodeForCs.Append("\r\n" + "/// <returns>Json对象</returns>");
                strCodeForCs.AppendFormat("\r\n" + "public JsonResult GetJsonObjBy{1}({0} {1})",
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    FldName4Key);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = cls{0}BL.GetObjBy{1}({1});",
                    objMainPrjTab.TabName, FldName4Key);
                strCodeForCs.AppendFormat("\r\n" + "return Json(obj{0}EN, JsonRequestBehavior.AllowGet);",
                    objMainPrjTab.TabName, FldName4Key);
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_4MvcCtrl_Deletes()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 删除数据列表中多选的多条记录");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/// <param name=\"checkedId\">多选的关键字列表</param>");
                strCodeForCs.Append("\r\n" + "/// <returns></returns>");
                strCodeForCs.AppendFormat("\r\n" + "public ActionResult Deletes(string[] checkedId)",
                    FldName4Key);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "PrepareDdlViewData();");
             

                strCodeForCs.Append("\r\n" + " try");
                strCodeForCs.Append("\r\n" + "            {");
                strCodeForCs.Append("\r\n" + "if (checkedId == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "            TempData[\"message\"] = string.Format(\"没有选择记录,不能删除!\");");
                strCodeForCs.Append("\r\n" + "            return RedirectToList();");
                strCodeForCs.Append("\r\n" + "}");

                //strCodeForCs.Append("\r\n" + "string strIds = string.Join(", ", checkedId.Cast<string>().ToArray());
                strCodeForCs.AppendFormat("\r\n" + "List<string> arr{0} = new List<string>(checkedId);",
                    FldName4Key);
                //  DAL.BatchDelete(strIds)
                //return View();
                strCodeForCs.AppendFormat("\r\n" + "int intRecCount = cls{0}BL.Del{0}s(arr{1});",
                    objMainPrjTab.TabName,
                    FldName4Key);
             
                strCodeForCs.Append("\r\n" + "                if (intRecCount > 0)");
                strCodeForCs.Append("\r\n" + "                {");
                strCodeForCs.Append("\r\n" + "                    TempData[\"message\"] = string.Format(\"有[{0}]条记录 已经被删除!\", intRecCount);");
                strCodeForCs.Append("\r\n" + "                }");
                strCodeForCs.Append("\r\n" + "                else");
                strCodeForCs.Append("\r\n" + "                {");
                strCodeForCs.Append("\r\n" + "                    TempData[\"message\"] = string.Format(\"有[0]条记录被删除!\");");
                strCodeForCs.Append("\r\n" + "                }");
                strCodeForCs.Append("\r\n" + "            }");
                strCodeForCs.Append("\r\n" + "            catch(Exception objException)");
                strCodeForCs.Append("\r\n" + "            {");
                strCodeForCs.Append("\r\n" + "                string strMsg = string.Format(\"删除多条记录出错!出错信息:{0}.\", objException.Message);");
                strCodeForCs.Append("\r\n" + "                TempData[\"message\"] = strMsg;");
                strCodeForCs.Append("\r\n" + "            }");
                strCodeForCs.Append("\r\n" + "            return RedirectToList();");



                //strCodeForCs.Append("\r\n" + "string sortOrder = seSortOrder;");
                //strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} model = new ViewModel4{0}();",
                //    objMainPrjTab.TabName);
                //strCodeForCs.AppendFormat("\r\n" + "model.qryModel4{0} = seQryModel4{0};",
                //    objViewInfoENEx.TabName_Out);

                //strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModel = PrepareModel(model, {1}, sortOrder);",
                //    objMainPrjTab.TabName, IsNumberType4Key ? "0" : "\"\"");
                //strCodeForCs.AppendFormat("\r\n" + "return View(\"{0}CRUD\", NewModel);",
                //    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_4MvcCtrl_SortList()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 专门用于列表字段排序的显示列表记录");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/// <param name=\"model\">从View传回来的Model</param>");
                strCodeForCs.Append("\r\n" + "/// <param name=\"sortOrder\">从View传回来的排序信息</param>");
                strCodeForCs.Append("\r\n" + "/// <returns></returns>");
                strCodeForCs.AppendFormat("\r\n" + "public ViewResult {1}_SortList(ViewModel4{0} model, string sortOrder)",
                    objMainPrjTab.TabName, objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "PrepareDdlViewData();");

                strCodeForCs.Append("\r\n" + "seSortOrder = sortOrder;");
                strCodeForCs.AppendFormat("\r\n" + "model.qryModel4{0} = seQryModel4{0};",
                    objViewInfoENEx.TabName_Out);

                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModel = PrepareModel(model, {1}, sortOrder);",
                    objMainPrjTab.TabName, IsNumberType4Key ? "0" : "\"\"");
                strCodeForCs.AppendFormat("\r\n" + "return View(\"{0}CRUD\", NewModel);",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_4MvcCtrl_Save()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 修改记录");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + " [HttpPost]");

                strCodeForCs.AppendFormat("\r\n" + "public ActionResult Save(ViewModel4{0} model, string Operate)",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "PrepareDdlViewData();");
                
                strCodeForCs.Append("\r\n" + "if (ModelState.IsValid)");
                strCodeForCs.Append("\r\n" + "{");             
             
                strCodeForCs.Append("\r\n" + "if (Operate == \"Add\")");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                    objMainPrjTab.TabName);
                strCodeForCs.AppendFormat("\r\n" + "PutDataTo{0}Class(obj{0}EN, model);",
                    objMainPrjTab.TabName);
                if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
                {
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.Append("\r\n" + "//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键");
                    strCodeForCs.AppendFormat("\r\n" + "//if (cls{0}BL.IsExist({1}) == true)",
                    objMainPrjTab.TabName, strKeyFldName_ObjName);
                    strCodeForCs.Append("\r\n" + "//{");

                    strCodeForCs.AppendFormat("\r\n" + "//string strMsg = string.Format(\"关键字:[用户Id:{0}]已经存在,不能重复添加相同关键字记录!\",  model.{0});",
                            FldName4Key);
                    strCodeForCs.Append("\r\n" + "//TempData[\"message\"] = strMsg;");
                    strCodeForCs.Append("\r\n" + "//ModelState.AddModelError(\"\", strMsg);");
                    strCodeForCs.AppendFormat("\r\n" + "//ViewModel4{0} NewModel = PrepareModel(model, {1});",
                        objMainPrjTab.TabName, IsNumberType4Key ? "0" : "\"\"");
                    //strCodeForCs.Append("\r\n" + "return RedirectToAction(\"Create\", NewModel);");
                    strCodeForCs.Append("\r\n" + "//ViewBag.Operate = \"Add\";");
                    strCodeForCs.AppendFormat("\r\n" + "//return View(\"{0}CRUD\", NewModel);",
                        objMainPrjTab.TabName);
                    strCodeForCs.Append("\r\n" + "//}");
                    strCodeForCs.Append("\r\n" + "");
                }
                else if (objKeyField.PrimaryTypeId != enumPrimaryType.Identity_02)
                {
                    strCodeForCs.AppendFormat("\r\n" + "if (cls{0}BL.IsExist({1}) == true)",
                    objMainPrjTab.TabName, strKeyFldName_ObjName);
                    strCodeForCs.Append("\r\n" + "{");

                    strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"关键字:[用户Id:{0}]已经存在,不能重复添加相同关键字记录!\",  model.{0});",
                            FldName4Key);
                    strCodeForCs.Append("\r\n" + "TempData[\"message\"] = strMsg;");
                    strCodeForCs.Append("\r\n" + "ModelState.AddModelError(\"\", strMsg);");
                    strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModel = PrepareModel(model, {1});",
                        objMainPrjTab.TabName, IsNumberType4Key ? "0" : "\"\"");
                    //strCodeForCs.Append("\r\n" + "return RedirectToAction(\"Create\", NewModel);");
                    strCodeForCs.Append("\r\n" + "ViewBag.Operate = \"Add\";");
                    strCodeForCs.AppendFormat("\r\n" + "return View(\"{0}CRUD\", NewModel);",
                        objMainPrjTab.TabName);
                    strCodeForCs.Append("\r\n" + "}");
                }
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.CheckPropertyNew();",
                 objMainPrjTab.TabName);

                if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
                {
                    strCodeForCs.Append("\r\n" + "//因为是字符型自增主键,所以在添加时,自动获取主键值。");
                    strCodeForCs.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(obj{0}EN.{1}) == true || cls{0}BL.IsExist({2}) == true)",
                        objMainPrjTab.TabName, objKeyField.PropertyName(this.IsFstLcase), strKeyFldName_ObjName);
                    strCodeForCs.Append("\r\n" + " {");
                    strCodeForCs.AppendFormat("\r\n" + "     obj{0}EN.{1} = cls{0}BL.GetMaxStrId_S();",
                        objMainPrjTab.TabName, objKeyField.PropertyName(this.IsFstLcase));
                    strCodeForCs.Append("\r\n" + " }");
                }

                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.AddNewRecord();",
                    objMainPrjTab.TabName);
                strCodeForCs.AppendFormat("\r\n" + "TempData[\"message\"] = string.Format(\"{{0}} has been saved\", obj{0}EN.{1});",
                    objMainPrjTab.TabName, FldName4Key, "{", "}");
             
                strCodeForCs.Append("\r\n" + "return RedirectToList();");
             
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"编辑记录有错!错误：{0}\", objException.Message);");
                strCodeForCs.Append("\r\n" + "TempData[\"message\"] = strMsg;");
                strCodeForCs.Append("\r\n" + "ModelState.AddModelError(\"\", strMsg);");
                //strCodeForCs.Append("\r\n" + "return RedirectToAction(\"Create\", NewModel);");
                strCodeForCs.Append("\r\n" + "ViewBag.Operate = \"Add\";");
                //strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModel = PrepareModel(model, {1});",
                //    objMainPrjTab.TabName, IsNumberType4Key ? "0" : "\"\"");
                //strCodeForCs.AppendFormat("\r\n" + "return View(\"{0}CRUD\", NewModel);",
                //    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "return RedirectToList();");

                strCodeForCs.Append("\r\n" + "//return View();");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                    objMainPrjTab.TabName);
                strCodeForCs.AppendFormat("\r\n" + "PutDataTo{0}Class(obj{0}EN, model);",
                    objMainPrjTab.TabName);
                if (objKeyField.PrimaryTypeId == enumPrimaryType.Identity_02)
                {
                    strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.{1} == 0)",
                                     objMainPrjTab.TabName, FldName4Key);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty(obj{0}EN.{1}) == true)",
                                        objMainPrjTab.TabName, FldName4Key);
                }
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = seKeyId;", 
                    objMainPrjTab.TabName, FldName4Key);
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.CheckPropertyNew();",
                 objMainPrjTab.TabName);
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Update();",
                    objMainPrjTab.TabName);
                strCodeForCs.AppendFormat("\r\n" + "TempData[\"message\"] = string.Format(\"{{0}} has been saved.\", obj{0}EN.{1}); ",
                    objMainPrjTab.TabName, FldName4Key, "{", "}");
                strCodeForCs.Append("\r\n" + "return RedirectToList();");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"编辑记录有错!错误：{0}\", objException.Message);");
                strCodeForCs.Append("\r\n" + "TempData[\"message\"] = strMsg;");
                strCodeForCs.Append("\r\n" + "ModelState.AddModelError(\"\", strMsg);");
                //strCodeForCs.Append("\r\n" + "return RedirectToAction(\"Update\", NewModel);");
                strCodeForCs.Append("\r\n" + "ViewBag.Operate = \"Update\";");
                strCodeForCs.Append("\r\n" + "return RedirectToList();");
                //strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModel = PrepareModel(model, {1});",
                //objMainPrjTab.TabName, IsNumberType4Key ? "0" : "\"\"");
                //strCodeForCs.AppendFormat("\r\n" + "return View(\"{0}CRUD\", NewModel);",
                //objMainPrjTab.TabName);
                //strCodeForCs.Append("\r\n" + "//return View();");
                strCodeForCs.Append("\r\n" + "}");

                //strCodeForCs.Append("\r\n" + "}");
                //strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                //strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"编辑记录有错!错误：{0}\", objException.Message);");
                //strCodeForCs.Append("\r\n" + "TempData[\"message\"] = strMsg;");
                //strCodeForCs.Append("\r\n" + "ModelState.AddModelError(\"\", strMsg);");
                //strCodeForCs.Append("\r\n" + "return View();");
                //strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = \"编辑记录有错!\";");
                strCodeForCs.Append("\r\n" + "ModelState.AddModelError(\"\", strMsg);");
                strCodeForCs.Append("\r\n" + "string action = GetCurrentAction();");
                //strCodeForCs.AppendFormat("\r\n" + "NewModel.{0} = cls{1}BL.GetMaxStrId_S();",
                //    FldName4Key, objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "ViewBag.EditError = \"true\";");
                //strCodeForCs.Append("\r\n" + "ViewBag.PreOperate = Operate;");
                strCodeForCs.Append("\r\n" + "ViewBag.Operate = Operate;");
                strCodeForCs.Append("\r\n" + "return RedirectToList();");
                //strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModel = PrepareModel(null);",
                //    objMainPrjTab.TabName);
                //strCodeForCs.AppendFormat("\r\n" + "return View(\"{0}CRUD\", NewModel);",
                //    objMainPrjTab.TabName);
                //return RedirectToAction("List");

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



        public string Gen_4MvcCtrl_seKeyId()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 用于保存修改记录的关键字(KeyId)");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n" + "public {0} seKeyId",
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "{0} strKeyId = {1};", 
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    IsNumberType4Key ? "0" : "\"\"");
            
                strCodeForCs.Append("\r\n" + "if (System.Web.HttpContext.Current.Session[\"KeyId\"] == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "strKeyId = {0};", IsNumberType4Key ? "0" : "\"\"");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "strKeyId = ({0})System.Web.HttpContext.Current.Session[\"KeyId\"];",
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "return strKeyId;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "{0} strKeyId = value;",
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                strCodeForCs.Append("\r\n" + "System.Web.HttpContext.Current.Session.Add(\"KeyId\", strKeyId);");

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


        public string Gen_4MvcCtrl_seIsAjax()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 用于保存当前是否用Ajax处理功能");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.Append("\r\n" + "    public bool seIsAjax");
                strCodeForCs.Append("\r\n" + "        {");
                strCodeForCs.Append("\r\n" + "            get");
                strCodeForCs.Append("\r\n" + "            {");
                strCodeForCs.Append("\r\n" + "                bool bolIsAjax = false;");
                strCodeForCs.Append("\r\n" + "                if (System.Web.HttpContext.Current.Session[\"IsAjax\"] == null)");
                strCodeForCs.Append("\r\n" + "                {");
                strCodeForCs.Append("\r\n" + "                    return false;");
                strCodeForCs.Append("\r\n" + "                }");
                strCodeForCs.Append("\r\n" + "                bolIsAjax = (bool)System.Web.HttpContext.Current.Session[\"IsAjax\"];");
                strCodeForCs.Append("\r\n" + "                return bolIsAjax;");
                strCodeForCs.Append("\r\n" + "            }");
                strCodeForCs.Append("\r\n" + "            set");
                strCodeForCs.Append("\r\n" + "            {");
                strCodeForCs.Append("\r\n" + "                bool bolIsAjax = value;");
                strCodeForCs.Append("\r\n" + "                System.Web.HttpContext.Current.Session.Add(\"IsAjax\", bolIsAjax);");
                strCodeForCs.Append("\r\n" + "            }");
                strCodeForCs.Append("\r\n" + "        }");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_4MvcCtrl_seTabInfo4Query()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strTabName =  objViewInfoENEx.TabName_Out;
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 用于查询信息的Session");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n" + "public QryModel4{0} seQryModel4{0}",
                    strTabName);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "QryModel4{0} objQryModel4{0};",
                    strTabName);
                strCodeForCs.AppendFormat("\r\n" + "objQryModel4{0} = (QryModel4{0})System.Web.HttpContext.Current.Session[\"QryModel4{0}\"];",
                    strTabName);
                strCodeForCs.AppendFormat("\r\n" + "return objQryModel4{0};",
                    strTabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "QryModel4{0} objQryModel4{0} = value;",
                    strTabName);
                strCodeForCs.AppendFormat("\r\n" + "System.Web.HttpContext.Current.Session.Add(\"QryModel4{0}\", objQryModel4{0});",
                    strTabName);
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
       

        public string Gen_4MvcCtrl_PrepareDdlViewData()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 准备下拉框的绑定数据");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n" + "private void PrepareDdlViewData()",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "{");
                //string strTemp = Gen_Mvc_GetDdlBindDS();
                //strCodeForCs.AppendFormat("\r\n" + "{0}", strTemp);
                

            //    strCodeForCs.Append("\r\n" + "ViewData[\"CollegeList\"] = clsDepartmentInfoBL.GetObjLst4SelectListItem(\"1=1\");");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        public string Gen_4MvcCtrl_GetCurrentAction()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 获取当前页面的Action名称");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n" + "public string GetCurrentAction()",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "{");


                strCodeForCs.Append("\r\n" + "string action = Request.RequestContext.RouteData.Values[\"action\"].ToString();");
                strCodeForCs.Append("\r\n" + "if (!string.IsNullOrWhiteSpace(action))");
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "action = \"\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return action;");
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_4MvcCtrl_GetCurrentController()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 获取当前页面的Controller名称");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n" + "public string GetCurrentController()",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "string controller = Request.RequestContext.RouteData.Values[\"controller\"].ToString();");
                strCodeForCs.Append("\r\n" + "if (!string.IsNullOrWhiteSpace(controller))");
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "controller = \"\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return controller;");
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
        /// 获取下拉框绑定的数据源
        /// </summary>
        /// <param name="objViewInfoENEx"></param>
        /// <returns></returns>
        public string Gen_Mvc_GetDdlBindDSBak20230309()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            List<string> arrTabName = new List<string>();
            try
            {
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd
                    || objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate)
                {
                    strCodeForCs.Append("\r\n" + "//1、为下拉框设置数据源,绑定列表数据");
                    foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                    {
                        if (objEditRegionFldsEx.objCtlType.CtlTypeName.Contains("DropDownList") == true)
                        {
                            if (objEditRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                            {
                                if (arrTabName.Contains("TrueAndFalse") == false)
                                {
                                    arrTabName.Add("TrueAndFalse");
                                    strCodeForCs.Append("\r\n" + "  ViewData[\"TrueAndFalseList\"] = clsPubFun_Mvc.GetSliLst4TrueAndFalse();");
                                }
                            }
                            else
                            {
                                clsPrjTabEN objPrjTabEN_CodeTab = clsPrjTabBLEx.GetObjByTabIdEx(objEditRegionFldsEx.DsTabId);
                                if (objPrjTabEN_CodeTab == null)
                                {
                                    string strMsg = string.Format("在界面编辑区,{0}下拉框的数据源表没有设置,请检查!({1})",
                                        objEditRegionFldsEx.FldName,
                                        clsStackTrace.GetCurrClassFunction());
                                    throw new Exception(strMsg);
                                }
                                if (arrTabName.Contains(objPrjTabEN_CodeTab.TabName) == false)
                                {
                                    arrTabName.Add(objPrjTabEN_CodeTab.TabName);
                                    strCodeForCs.AppendFormat("\r\n" + "ViewData[\"{0}List\"] = cls{0}BL4Mvc.GetObjLst4SelectListItem(\"1=1\");",
                                        objPrjTabEN_CodeTab.TabName);
                                }
                            }
                        }
                    }
                }


                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.objCtlType.CtlTypeName.Contains("DropDownList") == true)
                    {
                        if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                        {
                            if (arrTabName.Contains("TrueAndFalse") == false)
                            {
                                arrTabName.Add("TrueAndFalse");
                                strCodeForCs.Append("\r\n" + "  ViewData[\"TrueAndFalseList\"] = clsPubFun.GetSliLst4TrueAndFalse();");
                            }
                        }
                        else
                        {
                            clsPrjTabEN objPrjTabEN_CodeTab = clsPrjTabBLEx.GetObjByTabIdEx(objQryRegionFldsEx.DsTabId);
                            //clsFieldTabEN objFieldTab_ValueField = clsFieldTabBL.GetObjByFldIdCache(objQryRegionFldsEx.DsDataValueFieldId, objViewInfoENEx.PrjId);
                            //clsFieldTabEN objFieldTabEN_TextField = clsFieldTabBL.GetObjByFldIdCache(objQryRegionFldsEx.Ds_DataTextFieldId, objViewInfoENEx.PrjId);

                            if (objPrjTabEN_CodeTab == null)
                            {
                                string strMsg = string.Format("在界面查询区,{0}下拉框的数据源表没有设置,请检查!({1})",
                                    objQryRegionFldsEx.FldName,
                                    clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                            }
                            //if (objFieldTab_ValueField == null)
                            //{
                            //    string strMsg = string.Format("在界面查询区,{0}下拉框的数据源值字段没有设置,请检查!({1})",
                            //        objQryRegionFldsEx.FldName,
                            //        clsStackTrace.GetCurrClassFunction());
                            //    throw new Exception(strMsg);
                            //}
                            //if (objFieldTabEN_TextField == null)
                            //{
                            //    string strMsg = string.Format("在界面查询区,{0}下拉框的数据源文本字段没有设置,请检查!({1})",
                            //        objQryRegionFldsEx.FldName,
                            //        clsStackTrace.GetCurrClassFunction());
                            //    throw new Exception(strMsg);
                            //}
                            if (arrTabName.Contains(objPrjTabEN_CodeTab.TabName) == false)
                            {
                                arrTabName.Add(objPrjTabEN_CodeTab.TabName);
                                strCodeForCs.AppendFormat("\r\n" + "ViewData[\"{0}List\"] = cls{0}BL4Mvc.GetObjLst4SelectListItem(\"1=1\");",
                                      objPrjTabEN_CodeTab.TabName);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_4MvcCtrl_DdlEvent()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            List<string> arrTabName = new List<string>();
            try
            {
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd
                    || objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate)
                {
                    strCodeForCs.Append("\r\n" + "//1、为下拉框设置数据源,绑定列表数据");
                    foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                    {
                        if (objEditRegionFldsEx.objCtlType.CtlTypeName.Contains("DropDownList") == true)
                        {
                            if (objEditRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                            {
                                if (arrTabName.Contains("TrueAndFalse") == false)
                                {

                                    using (JsFunction objJsFunc = new JsFunction())
                                    {
                                        objJsFunc.funcName = string.Format("{0}Selected()", objEditRegionFldsEx.CtrlId);
                                        arrTabName.Add("TrueAndFalse");
                                        objJsFunc.sbText.Append("\r\n" + "[HttpGet]");
                                        objJsFunc.sbText.AppendFormat("\r\n" + "public JsonResult {0}Selected(string {1})",
                                           objEditRegionFldsEx.CtrlId, objEditRegionFldsEx.FldName);
                                        //objJsFunc.sbText.Append("\r\n" + "  ViewData[\"TrueAndFalseList\"] = clsPubFun.GetSliLst4TrueAndFalse();");
                                        objJsFunc.sbText.Append("\r\n" + "const res = new JsonResult();");
                                        objJsFunc.sbText.Append("\r\n" + "List<SelectListItem> sltSubType = null;");
                                        objJsFunc.sbText.Append("\r\n" + "//在需要此函数时,请去除下面两行代码的注释,并作相应的修改");

                                        objJsFunc.sbText.AppendFormat("\r\n" + "//string strCondition = string.Format(\"{{0}}='{{1}}'\", conSubType.{0}, {0});",
                                            objEditRegionFldsEx.FldName);
                                        objJsFunc.sbText.Append("\r\n" + "//sltSubType = clsSubTypeBL4Mvc.GetObjLst4SelectListItem(strCondition);");

                                        objJsFunc.sbText.Append("\r\n" + "res.JsonRequestBehavior = JsonRequestBehavior.AllowGet;");
                                        objJsFunc.sbText.Append("\r\n" + "res.Data = new");
                                        objJsFunc.sbText.Append("\r\n" + "{");
                                        objJsFunc.sbText.Append("\r\n" + "SubTypeLst = sltSubType");
                                        objJsFunc.sbText.Append("\r\n" + "};");
                                        objJsFunc.sbText.Append("\r\n" + "return res;");
                                        objJsFunc.sbText.Append("\r\n" + "}");
                                    }
                                }
                            }
                            else
                            {
                                clsPrjTabEN objPrjTabEN_CodeTab = clsPrjTabBLEx.GetObjByTabIdEx(objEditRegionFldsEx.DsTabId);
                                if (objPrjTabEN_CodeTab == null)
                                {
                                    string strMsg = string.Format("在界面编辑区,{0}下拉框的数据源表没有设置,请检查!({1})",
                                        objEditRegionFldsEx.FldName,
                                        clsStackTrace.GetCurrClassFunction());
                                    throw new Exception(strMsg);
                                }
                               
                                using (JsFunction objJsFunc = new JsFunction())
                                {
                                    objJsFunc.funcName = string.Format("{0}Selected()", objEditRegionFldsEx.CtrlId);
                                    objJsFunc.sbText.Append("\r\n" + "[HttpGet]");
                                    objJsFunc.sbText.AppendFormat("\r\n" + "public JsonResult {0}Selected(string {1})",
                                       objEditRegionFldsEx.CtrlId, objEditRegionFldsEx.FldName);
                                    objJsFunc.sbText.Append("\r\n" + "{");
                                    objJsFunc.sbText.Append("\r\n" + "const res = new JsonResult();");
                                    objJsFunc.sbText.Append("\r\n" + "List<SelectListItem> sltSubType = null;");
                                    objJsFunc.sbText.Append("\r\n" + "//在需要此函数时,请去除下面两行代码的注释,并作相应的修改");

                                    objJsFunc.sbText.AppendFormat("\r\n" + "//string strCondition = string.Format(\"{{0}}='{{1}}'\", conSubType.{0}, {0});",
                                        objEditRegionFldsEx.FldName);
                                    objJsFunc.sbText.Append("\r\n" + "//sltSubType = clsSubTypeBL4Mvc.GetObjLst4SelectListItem(strCondition);");
                                    
                                    objJsFunc.sbText.Append("\r\n" + "res.JsonRequestBehavior = JsonRequestBehavior.AllowGet;");
                                    objJsFunc.sbText.Append("\r\n" + "res.Data = new");
                                    objJsFunc.sbText.Append("\r\n" + "{");
                                    objJsFunc.sbText.Append("\r\n" + "SubTypeLst = sltSubType");
                                    objJsFunc.sbText.Append("\r\n" + "};");
                                    objJsFunc.sbText.Append("\r\n" + "return res;");
                                    objJsFunc.sbText.Append("\r\n" + "}");
                                    arrJsFunction.Add(objJsFunc);
                                }

                            }
                        }
                    }
                }


                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.objCtlType.CtlTypeName.Contains("DropDownList") == true)
                    {
                        if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                        {
                            if (arrTabName.Contains("TrueAndFalse") == false)
                            {
                                using (JsFunction objJsFunc = new JsFunction())
                                {
                                    arrTabName.Add("TrueAndFalse");
                                    objJsFunc.funcName = string.Format("{0}Selected()", objQryRegionFldsEx.CtrlId());
                                    objJsFunc.sbText.Append("\r\n" + "[HttpGet]");
                                    objJsFunc.sbText.AppendFormat("\r\n" + "public JsonResult {0}Selected(string {1})",
                                       objQryRegionFldsEx.CtrlId(), objQryRegionFldsEx.FldName);
                                    objJsFunc.sbText.Append("\r\n" + "{");
                                    //objJsFunc.sbText.Append("\r\n" + "  ViewData[\"TrueAndFalseList\"] = clsPubFun.GetSliLst4TrueAndFalse();");
                                    objJsFunc.sbText.Append("\r\n" + "const res = new JsonResult();");
                                    objJsFunc.sbText.Append("\r\n" + "List<SelectListItem> sltSubType = null;");
                                    objJsFunc.sbText.Append("\r\n" + "//在需要此函数时,请去除下面两行代码的注释,并作相应的修改");

                                    objJsFunc.sbText.AppendFormat("\r\n" + "//string strCondition = string.Format(\"{{0}}='{{1}}'\", conSubType.{0}, {0});",
                                        objQryRegionFldsEx.FldName);
                                    objJsFunc.sbText.Append("\r\n" + "//sltSubType = clsSubTypeBL4Mvc.GetObjLst4SelectListItem(strCondition);");
                                    objJsFunc.sbText.Append("\r\n" + "res.JsonRequestBehavior = JsonRequestBehavior.AllowGet;");
                                    objJsFunc.sbText.Append("\r\n" + "res.Data = new");
                                    objJsFunc.sbText.Append("\r\n" + "{");
                                    objJsFunc.sbText.Append("\r\n" + "SubTypeLst = sltSubType");
                                    objJsFunc.sbText.Append("\r\n" + "};");
                                    objJsFunc.sbText.Append("\r\n" + "return res;");
                                    objJsFunc.sbText.Append("\r\n" + "}");
                                    arrJsFunction.Add(objJsFunc);
                                }

                            }
                        }
                        else
                        {
                            clsPrjTabEN objPrjTabEN_CodeTab = clsPrjTabBLEx.GetObjByTabIdEx(objQryRegionFldsEx.DsTabId);
                            //clsFieldTabEN objFieldTab_ValueField = clsFieldTabBL.GetObjByFldIdCache(objQryRegionFldsEx.DsDataValueFieldId, objViewInfoENEx.PrjId);
                            //clsFieldTabEN objFieldTabEN_TextField = clsFieldTabBL.GetObjByFldIdCache(objQryRegionFldsEx.Ds_DataTextFieldId, objViewInfoENEx.PrjId);

                            if (objPrjTabEN_CodeTab == null)
                            {
                                string strMsg = string.Format("在界面查询区,{0}下拉框的数据源表没有设置,请检查!({1})",
                                    objQryRegionFldsEx.FldName,
                                    clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                            }
                            //if (objFieldTab_ValueField == null)
                            //{
                            //    string strMsg = string.Format("在界面查询区,{0}下拉框的数据源值字段没有设置,请检查!({1})",
                            //        objQryRegionFldsEx.FldName,
                            //        clsStackTrace.GetCurrClassFunction());
                            //    throw new Exception(strMsg);
                            //}
                            //if (objFieldTabEN_TextField == null)
                            //{
                            //    string strMsg = string.Format("在界面查询区,{0}下拉框的数据源文本字段没有设置,请检查!({1})",
                            //        objQryRegionFldsEx.FldName,
                            //        clsStackTrace.GetCurrClassFunction());
                            //    throw new Exception(strMsg);
                            //}
                            using (JsFunction objJsFunc = new JsFunction())
                            {
                                objJsFunc.funcName = string.Format("{0}Selected()", objQryRegionFldsEx.CtrlId());
                                objJsFunc.sbText.Append("\r\n" + "[HttpGet]");
                                objJsFunc.sbText.AppendFormat("\r\n" + "public JsonResult {0}Selected(string {1})",
                                   objQryRegionFldsEx.CtrlId(), objQryRegionFldsEx.FldName);
                                objJsFunc.sbText.Append("\r\n" + "{");
                                objJsFunc.sbText.Append("\r\n" + "const res = new JsonResult();");
                                objJsFunc.sbText.Append("\r\n" + "List<SelectListItem> sltSubType = null;");
                                objJsFunc.sbText.Append("\r\n" + "//在需要此函数时,请去除下面两行代码的注释,并作相应的修改");

                                objJsFunc.sbText.AppendFormat("\r\n" + "//string strCondition = string.Format(\"{{0}}='{{1}}'\", conSubType.{0}, {0});",
                                    objQryRegionFldsEx.FldName);
                                objJsFunc.sbText.Append("\r\n" + "//sltSubType = clsSubTypeBL4Mvc.GetObjLst4SelectListItem(strCondition);");                                
                                objJsFunc.sbText.Append("\r\n" + "res.JsonRequestBehavior = JsonRequestBehavior.AllowGet;");
                                objJsFunc.sbText.Append("\r\n" + "res.Data = new");
                                objJsFunc.sbText.Append("\r\n" + "{");
                                objJsFunc.sbText.Append("\r\n" + "SubTypeLst = sltSubType");
                                objJsFunc.sbText.Append("\r\n" + "};");
                                objJsFunc.sbText.Append("\r\n" + "return res;");
                                objJsFunc.sbText.Append("\r\n" + "}");
                                arrJsFunction.Add(objJsFunc);
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }

            arrJsFunction.Sort((x, y) => { return x.funcName.CompareTo(y.funcName); });
            foreach (JsFunction objJsFunction in arrJsFunction)
            {
                strCodeForCs.Append("\r\n" + objJsFunction.funcText);
            }
            return strCodeForCs.ToString();
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
                    switch (objQryRegionFldsEx.objCtlType.CtlTypeName) //objEditRegionFldsEx.objCtlType.CtlTypeName
                    {

                        case "CheckBox":
                            strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.{1} == true)",
                                        objViewInfoENEx.TabName_Out, objQryRegionFldsEx.FldName);
                            strCodeForCs.Append("\r\n" + "{");
                          
                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '1'\", con{1}.{0});",
                                     objQryRegionFldsEx.FldName,
                                     objViewInfoENEx.TabName_Out,
                                     "{", "}");
                            strCodeForCs.Append("\r\n" + "}");

                            strCodeForCs.AppendFormat("\r\n" + "else");
                            strCodeForCs.Append("\r\n" + "{");


                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '0'\", con{1}.{0});",
                                 objQryRegionFldsEx.FldName,
                                     objViewInfoENEx.TabName_Out);
                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        case "DropDownList": ///如果控件是下拉框;
                            if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.{1} == \"true\")",
                                        objViewInfoENEx.TabName_Out,
                                           strFldName);
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);

                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '1'\", con{1}.{0}); ",
                                      objQryRegionFldsEx.FldName,
                                       objViewInfoENEx.TabName_Out);
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.AppendFormat("\r\n" + "else if (obj{0}EN.{1} == \"false\")",
                                        objViewInfoENEx.TabName_Out,
                                         strFldName);
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);

                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '0'\", con{1}.{0});",
                                       objQryRegionFldsEx.FldName,
                                     objViewInfoENEx.TabName_Out);
                                strCodeForCs.Append("\r\n" + "}");

                            }
                            else
                            {
                        
                                switch (objQryRegionFldsEx.ObjFieldTabENEx.CsType())
                                {
                                    case "string":

                                        strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty(obj{0}EN.{1}) == false && obj{0}EN.{1} != \"0\")",
                                    objViewInfoENEx.TabName_Out,
                                    strFldName);
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);
                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '{{1}}'\", con{0}.{1}, obj{0}EN.{1});",
                                                  objViewInfoENEx.TabName_Out,
                                                objQryRegionFldsEx.FldName);
                                        break;
                                    case "int":
                                        strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.{1}>0)",
                                    objViewInfoENEx.TabName_Out,
                                    strFldName);
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);
                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = {{1}}\", con{0}.{1}, obj{0}EN.{1});",
                                                objViewInfoENEx.TabName_Out,
                                                objQryRegionFldsEx.FldName);
                                        break;
                                    default:
                                        strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty(obj{0}EN.{1}) == false && obj{0}EN.{1} != \"0\")",
                                    objViewInfoENEx.TabName_Out,
                                    strFldName);
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);
                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '{{1}}'\", con{0}.{1}, obj{0}EN.{1});",
                                                  objViewInfoENEx.TabName_Out,
                                                objQryRegionFldsEx.FldName);
                                        break;
                                }
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            break;

                        case "TextBox": ///如果控件类型是文本框;
                            if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() != "string"
                                && objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02)
                            {
                                objQryRegionFldsEx.QueryOptionId = enumQueryOption.EqualQuery_01;
                            }
                            if ((objQryRegionFldsEx.QueryOptionId == enumQueryOption.Known_00) ||
                            (objQryRegionFldsEx.QueryOptionId == enumQueryOption.EqualQuery_01)) ///相等查询;
                            {
                                switch (objQryRegionFldsEx.ObjFieldTabENEx.CsType())
                                {
                                    case "string":
                                        strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty(obj{0}EN.{1}) == false)",
                                      objViewInfoENEx.TabName_Out,
                                        strFldName);
                                        break;
                                    case "int":
                                    case "long":
                                        strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.{1}>0)",
                                  objViewInfoENEx.TabName_Out,
                                    strFldName);
                                        break;
                                    default:
                                        strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty(obj{0}EN.{1}) == false)",
                                  objViewInfoENEx.TabName_Out,
                                    strFldName);
                                        break;
                                }
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);

                                if (objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '{{1}}'\", con{0}.{1}, obj{0}EN.{1});",
                                           objViewInfoENEx.TabName_Out,
                                            objQryRegionFldsEx.FldName);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = {{1}}\", con{0}.{1},  obj{0}EN.{1});",
                                    objViewInfoENEx.TabName_Out,
                                    objQryRegionFldsEx.FldName);
                                }
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02) ///模糊查询;
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty(obj{0}EN.{1}) == false)",
                                     objViewInfoENEx.TabName_Out,
                                        strFldName);
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} like '%{{1}}%'\", con{0}.{1}, obj{0}EN.{1});",
                                     objViewInfoENEx.TabName_Out,
                                     objQryRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.RangeQuery_03)
                            { ///范围查询;
                                strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty(obj{0}EN.{1}) == false)",
                                      objViewInfoENEx.TabName_Out,
                                       strFldName);
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '{{1}}'\", con{0}.{1}, obj{0}EN.{1});",
                                                                        objViewInfoENEx.TabName_Out,
                                        objQryRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty(obj{0}EN.{1}) == false)",
                                                  objViewInfoENEx.TabName_Out,
                                                    strFldName);
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);

                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\"And {{0}} = '{{1}}'\", con{0}.{1}, obj{0}EN.{1});",
                                      objViewInfoENEx.TabName_Out,
                                      objQryRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            break;
                        case "HyperLink":
                            break;
                        case "Image":
                            break;
                        case "ImageButton":
                            break;
                        case "Label":
                            break;
                        case "Link1Button":
                            break;
                        case "ListBox":
                            break;
                        case "Panel":
                            break;
                        case "RadioButton":
                            break;
                        case "RadioButtonList":
                            break;
                        case "CheckBoxList":
                            break;
                        case "DataGrid":
                            break;
                        case "DataList":
                            break;
                        case "Button":
                            break;
                    }
                }
               
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch(Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                  objViewInfoENEx.PrjId, objViewInfoENEx.MvcControllerName, "Combine{0}Condition", "(AspMvc)在组合查询条件(Combine{0}Condition)时出错!请联系管理员!", "生成代码");
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

        public string Gen_4MvcCtrl_PutDataToClass()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                ///生成仅有变量;
                //strCodeForCs.Append("\r\n ///1生成从界面层到逻辑层的数据传输函数代码");
              
                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.Append("\r\n /// 函数功能:把界面上的属性数据传到类对象中");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.AppendFormat("\r\n /// <param name = \"pobj{0}EN\">数据传输的目的类对象</param>",
                    objViewInfoENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "protected void PutDataTo{0}Class(cls{0}EN pobj{0}EN, ViewModel4{0} model)",
                    objViewInfoENEx.TabName );
                    strCodeForCs.Append("\r\n" + "{");
                    foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                    {
                        string strTemp = Get_4MvcCtrl_Code4FieldInPutDataToClass(objEditRegionFldsEx, objViewInfoENEx);
                        strCodeForCs.AppendFormat("{0}", strTemp);
                    }
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "");
                
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        public string Gen_4MvcCtrl_GetDataFromClass()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成仅有变量;

              
                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.Append("\r\n /// 函数功能:把类对象的属性内容显示到界面上");
                    strCodeForCs.Append("\r\n ///注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值");
                    strCodeForCs.Append("\r\n /// 如果在设置数据库时,就应该一级字段在前,二级字段在后");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.AppendFormat("\r\n /// <param name = \"pobj{0}EN\">表实体类对象</param>",
                    objViewInfoENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "protected void GetDataFrom{0}Class(cls{0}EN pobj{0}EN, ViewModel4{0} model)",
                            objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                    {
                        string strTemp = Get_4MvcCtrl_Code4FieldInGetDataFromClass(objEditRegionFldsEx, objViewInfoENEx);
                        strCodeForCs.AppendFormat("{0}", strTemp);

                    }
                    strCodeForCs.Append("\r\n" + "}");
                
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        private string Get_4MvcCtrl_Code4FieldInPutDataToClass(clsEditRegionFldsENEx objEditRegionFldsEx, clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder sbCodeForCs = new StringBuilder();
            if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                  && objEditRegionFldsEx.PrimaryTypeId()== clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }
            if (objEditRegionFldsEx.FldOpTypeId() == "0002")
            {
                sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.Set{1}(model.{3});",
              objViewInfoENEx.TabName, objEditRegionFldsEx.FldName, objViewInfoENEx.TabName, objEditRegionFldsEx.FldName);
                sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

                return sbCodeForCs.ToString();
            }
            sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = model.{3};",
            objViewInfoENEx.TabName, objEditRegionFldsEx.FldName, objViewInfoENEx.TabName, objEditRegionFldsEx.FldName);
            sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

            return sbCodeForCs.ToString();
        }
        private string Get_4MvcCtrl_Code4FieldInGetDataFromClass(clsEditRegionFldsENEx objEditRegionFldsEx, clsViewInfoENEx objViewInfoENEx)
        {

            StringBuilder sbCodeForCs = new StringBuilder();


            if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                  && objEditRegionFldsEx.PrimaryTypeId()== clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }
            if (objEditRegionFldsEx.FldOpTypeId() == "0003") //只写
            {
                sbCodeForCs.AppendFormat("\r\n" + "model.{1} = pobj{2}BL.Get{3}();",
                  objViewInfoENEx.TabName, objEditRegionFldsEx.FldName, objViewInfoENEx.TabName, objEditRegionFldsEx.FldName);
                sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

                return sbCodeForCs.ToString();
            }
            else if (objEditRegionFldsEx.FldOpTypeId() == "0002") //只读
            {
                sbCodeForCs.AppendFormat("\r\n" + "model.{1} = pobj{2}EN.{3};",
                  objViewInfoENEx.TabName, objEditRegionFldsEx.FldName, objViewInfoENEx.TabName, objEditRegionFldsEx.FldName);
                sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

                return sbCodeForCs.ToString();
            }
            sbCodeForCs.AppendFormat("\r\n" + "model.{1} = pobj{2}EN.{3};",
            objViewInfoENEx.TabName, objEditRegionFldsEx.FldName, objViewInfoENEx.TabName, objEditRegionFldsEx.FldName);
            sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

            return sbCodeForCs.ToString();
        }
        //public string Gen_4MvcCtrl_GetObjLst4SelectListItem()
        //{
        //    if (objProjectsENEx.IsSupportMvc == false) return "//由于项目不支持Mvc,所以不能生成GetObjLst4SelectListItem()函数";
        //    StringBuilder strCodeForCs = new StringBuilder();
        //    string strTextFieldName = "";
        //    string strValueFieldName = "";
        //    try
        //    {
        //        ///生成仅有变量;
        //        //第0步:把控件中下拉框ComboBox转换成ComboBox
        //        foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
        //        {
        //            if (objField.FieldTypeId == "02")
        //            {
        //                strValueFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
        //            }
        //            if (objField.FieldTypeId == "03")
        //            {
        //                strTextFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
        //            }
        //        }
        //        if (strValueFieldName != "" && strTextFieldName != "")
        //        {
        //            strCodeForCs.Append("\r\n /// <summary>");
        //            strCodeForCs.Append("\r\n /// 获取用户绑定下拉框的对象列表");
        //            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
        //            strCodeForCs.Append("\r\n /// </summary>");
        //            strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">条件</param>");
        //            strCodeForCs.AppendFormat("\r\n" + "public static List<SelectListItem> GetObjLst4SelectListItem(string strWhereCond)",
        //            strValueFieldName);
        //            strCodeForCs.Append("\r\n" + "{");
        //            strCodeForCs.Append("\r\n" + "//为数据源于表的下拉框设置内容");


        //            //strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = new cls{1}DA().Get{0}();",
        //            //strValueFieldName, objPrjTabENEx.TabName);
        //            strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arrObjLst = GetObjLst(strWhereCond); ",
        //                      objPrjTabENEx.TabName);
        //            strCodeForCs.AppendFormat("\r\n" + "List<SelectListItem> {0}List = new List<SelectListItem>();",
        //                objPrjTabENEx.TabName);
        //            strCodeForCs.AppendFormat("\r\n" + "{0}List.Add(new SelectListItem {3} Text = \"选[{5}]...\", Value = \"0\" {4});",
        //            objPrjTabENEx.TabName, strTextFieldName, strValueFieldName, "{", "}", objPrjTabENEx.TabCnName);

        //            strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN objInFor in arrObjLst)", objPrjTabENEx.TabName);
        //            strCodeForCs.Append("\r\n" + "{");
        //            strCodeForCs.AppendFormat("\r\n" + "{0}List.Add(new SelectListItem {3} Text = objInFor.{1}, Value = objInFor.{2} {4});",
        //                objPrjTabENEx.TabName, strTextFieldName, strValueFieldName, "{", "}");
        //            strCodeForCs.Append("\r\n" + "}");

        //            strCodeForCs.AppendFormat("\r\n" + "return {0}List;", objPrjTabENEx.TabName);

        //            strCodeForCs.Append("\r\n" + "}");
        //        }
        //    }

        //    catch (Exception ex)
        //    {
        //        clsEntityBase.LogErrorS(ex, "");
        //        throw new Exception(ex.Message, ex);
        //    }
        //    return strCodeForCs.ToString();
        //}
        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(Mvc_Controller4CSharp);
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
            this.ClsName = string.Format("{0}Controller", objViewInfoENEx.TabName);
            objViewInfoENEx.ClsName = this.ClsName;
        }
   
    }
}
