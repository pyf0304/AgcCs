using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AGC.PureClass;
using AGC.PureClassEx;
using AgcCommBase;
using com.taishsoft.comm_db_obj;
using com.taishsoft.commexception;
using com.taishsoft.common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
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
    partial class Mvc_ControllerBase4CSharp : clsGeneCodeBase4View
    {
        private string strKeyFldName_ObjName = "";

        #region 构造函数
        public Mvc_ControllerBase4CSharp()
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            InitPageSetup();
        }
        public Mvc_ControllerBase4CSharp(string strViewId)
       : base( strViewId, "", "")
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            InitPageSetup();
        }
        public Mvc_ControllerBase4CSharp(string strViewId, string strPrjDataBaseId, string strPrjId)
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
            this.objViewInfoENEx = objViewInfoENEx;
            string strFuncName = "";

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
     
            string strTemp;
            objViewInfoENEx.MvcControllerName = string.Format("{0}BaseController", objViewInfoENEx.TabName);

            objViewInfoENEx.WebUserCtlCsFName = string.Format("{0}{1}.cs",
                objViewInfoENEx.FolderName, objViewInfoENEx.MvcControllerName);
            objViewInfoENEx.FileName = objViewInfoENEx.WebUserCtlCsFName;
            objViewInfoENEx.ClsName = objViewInfoENEx.MvcControllerName;

            strRe_ClsName = objViewInfoENEx.MvcControllerName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebUserCtlCsFName);

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                  clsvFunction4GeneCodeBLEx.GetObjLstByViewInfoEx(objViewInfoENEx);


            //IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
            //    clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objViewInfoENEx.FunctionTemplateId,
            //        objViewInfoENEx.LangType, objViewInfoENEx.CodeTypeId, objViewInfoENEx.SqlDsTypeId);

            //int intCount1 = arrvFunction4GeneCodeObjLst.Count();
            //IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLstByFeature = objViewInfoENEx.arrvFunction4GeneCodeSetByFeatureLst;
            //int intCount2 = arrvFunction4GeneCodeObjLstByFeature.Count();
            //arrvFunction4GeneCodeObjLstByFeature = arrvFunction4GeneCodeObjLstByFeature.Where(x => x.CodeTypeId == objViewInfoENEx.CodeTypeId);
            //int intCount3 = arrvFunction4GeneCodeObjLstByFeature.Count();
            //IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_All = arrvFunction4GeneCodeObjLst.Union(arrvFunction4GeneCodeObjLstByFeature, new VFunction4GeneCodeComparer());
            //int intCount4 = arrvFunction4GeneCodeObjLst_All.Count();
            //arrvFunction4GeneCodeObjLst_All = arrvFunction4GeneCodeObjLst_All.OrderBy(x => x.OrderNum);
            //int intCount5 = arrvFunction4GeneCodeObjLst_All.Count();

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
                strCodeForCs.AppendFormat("\r\n" + "public partial class  {0} : Controller",
                    objViewInfoENEx.MvcControllerName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "public int PageSize = 10;");
                strCodeForCs.Append("\r\n" + "public int RecordNum = 0;");
                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;

                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }

                }

                ///生成用户自定义控件界面中Page_Load代码;
                //strTemp = GenPage_LoadCode4Wuc();
                //strCodeForCs.Append(strTemp);

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
                strCodeForCs.AppendFormat("\r\n" + "protected virtual ViewModel4{0} PrepareModel(ViewModel4{0} model, {1} {2} = {3}, string sortOrder = \"\", int page = 1)",
                    objViewInfoENEx.TabName, objKeyField.CsType, objKeyField.PrivFuncName,
                    IsNumberType4Key?"0":"\"\"");
                strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.Append("\r\n" + "string strWhereCond = \" 1 =1 \";");
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
                strCodeForCs.AppendFormat("\r\n" + "GetDataFrom{0}Class(obj{0}EN, NewModel.editModel4{0});",
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

                strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = Combine{0}Condition(NewModel.qryModel4{0});",
                    objViewInfoENEx.TabName_Out);

                strCodeForCs.Append("\r\n" + "string strSortOrder = sortOrder.Replace(\"_desc\", \" desc\");");
                strCodeForCs.AppendFormat("\r\n" + "IEnumerable <cls{0}EN> arrObjLst = cls{0}BL.GetObjLstByPager(page, PageSize, strWhereCond, strSortOrder);",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "this.RecordNum = cls{0}BL.GetRecCountByCond(strWhereCond);",
                    objViewInfoENEx.TabName_Out);

                //strCodeForCs.Append("\r\n" + "IEnumerable <cls{0}EN> arrObjLst2 = arrObjLst;", objMainPrjTab.TabName);
                bool bolIsFirst = true;
                foreach (clsDGRegionFldsENEx ObjInFor in objViewInfoENEx.arrDGRegionFldSet.Where(x=>x.ObjFieldTabENEx != null))
                {
                    if (bolIsFirst == true)
                    {
                        bolIsFirst = false;
                        strCodeForCs.AppendFormat("\r\n" + "ViewBag.{0}SortParm = String.IsNullOrEmpty(sortOrder) || sortOrder== \"{0}\" ? \"{0}_desc\" : \"{0}\";",
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
                foreach (clsDGRegionFldsENEx ObjInFor in objViewInfoENEx.arrDGRegionFldSet.Where(x => x.ObjFieldTabENEx != null))
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

        public string Gen_4MvcCtrl_PrepareListModel()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 为列表区准备列表模型");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <param name = \"model\">模型</param>");
                strCodeForCs.Append("\r\n /// <param name = \"sortOrder\">排序信息</param>");
                strCodeForCs.Append("\r\n /// <param name = \"page\">页号</param>");
                strCodeForCs.AppendFormat("\r\n" + "protected virtual ViewModel4{0} PrepareListModel(QryModel4{1} model, string sortOrder = \"\", int page = 1)",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.Append("\r\n" + "string strWhereCond = \" 1 =1 \";");
                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModel =  new ViewModel4{0}();",
                    objMainPrjTab.TabName);

                strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = Combine{0}Condition(model);",
                    objViewInfoENEx.TabName_Out);
                //strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "string strSortOrder = sortOrder.Replace(\"_desc\", \" desc\");");
                strCodeForCs.AppendFormat("\r\n" + "IEnumerable <cls{0}EN> arrObjLst = cls{0}BL.GetObjLstByPager(page, PageSize, strWhereCond, strSortOrder);",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "this.RecordNum = cls{0}BL.GetRecCountByCond(strWhereCond);",
                    objViewInfoENEx.TabName_Out);

                //strCodeForCs.Append("\r\n" + "IEnumerable <cls{0}EN> arrObjLst2 = arrObjLst;", objMainPrjTab.TabName);
                bool bolIsFirst = true;
                foreach (clsDGRegionFldsENEx ObjInFor in objViewInfoENEx.arrDGRegionFldSet.Where(x => x.ObjFieldTabENEx != null))
                {
                    if (bolIsFirst == true)
                    {
                        bolIsFirst = false;
                        strCodeForCs.AppendFormat("\r\n" + "ViewBag.{0}SortParm = String.IsNullOrEmpty(sortOrder) || sortOrder== \"{0}\" ? \"{0}_desc\" : \"{0}\";",
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
                foreach (clsDGRegionFldsENEx ObjInFor in objViewInfoENEx.arrDGRegionFldSet.Where(x => x.ObjFieldTabENEx != null))
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


        public string Gen_4MvcCtrl_PrepareEditModel()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 为编辑区准备编辑模型");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">修改的关键字</param>", objKeyField.PrivFuncName);
                strCodeForCs.AppendFormat("\r\n" + "protected virtual EditModel4{0} PrepareEditModel({1} {2} = {3})",
                    objViewInfoENEx.TabName, objKeyField.CsType, objKeyField.PrivFuncName,
                    IsNumberType4Key ? "0" : "\"\"");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "EditModel4{0} NewModel = NewModel = new EditModel4{0}();",
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
           
                strCodeForCs.AppendFormat("\r\n" + "GetDataFrom{0}Class(obj{0}EN, NewModel);",
                    objMainPrjTab.TabName);
                              
                strCodeForCs.Append("\r\n" + "}");
              
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
        public string Gen_4MvcCtrl_PrepareQueryModel()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 为查询区准备查询模型");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">修改的关键字</param>", objKeyField.PrivFuncName);
                strCodeForCs.AppendFormat("\r\n" + "protected virtual QryModel4{0} PrepareQueryModel()",
                    objViewInfoENEx.TabName_Out, objKeyField.CsType, objKeyField.PrivFuncName,
                    IsNumberType4Key ? "0" : "\"\"");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "PrepareDdlData4Query();");
                strCodeForCs.AppendFormat("\r\n" + "QryModel4{0} NewModel = null;",
                    objViewInfoENEx.TabName_Out);

                strCodeForCs.AppendFormat("\r\n" + "if (seQryModel4{0} != null)",
    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "NewModel = seQryModel4{0};",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "NewModel = new QryModel4{0}();",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "}");
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

        public string Gen_4MvcCtrl_PrepareFeatureModel()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 为功能区准备功能数据模型");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">修改的关键字</param>", objKeyField.PrivFuncName);
                strCodeForCs.AppendFormat("\r\n" + "protected virtual FeatureModel4{0} PrepareFeatureModel()",
                    objViewInfoENEx.TabName_In, objKeyField.CsType, objKeyField.PrivFuncName,
                    IsNumberType4Key ? "0" : "\"\"");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "PrepareDdlData4Feature();");
                strCodeForCs.AppendFormat("\r\n" + "FeatureModel4{0} NewModel = null;",
                    objViewInfoENEx.TabName_In);

                strCodeForCs.AppendFormat("\r\n" + "if (seFeatureModel4{0} != null)",
    objViewInfoENEx.TabName_In);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "NewModel = seFeatureModel4{0};",
                    objViewInfoENEx.TabName_In);
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "NewModel = new FeatureModel4{0}();",
                    objViewInfoENEx.TabName_In);
                strCodeForCs.Append("\r\n" + "}");
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
                strCodeForCs.Append("\r\n" + "[HttpPost]");
                strCodeForCs.Append("\r\n" + "[MultipleButton(Name = \"action\", Argument = \"Create\")]");
                strCodeForCs.AppendFormat("\r\n" + "public virtual ViewResult Create()",
                    objViewInfoENEx.TabName, objKeyField.CsType, objKeyField.PrivFuncName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "PrepareDdlViewData();");

                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModel = PrepareModel(null);",
                    objMainPrjTab.TabName);
                if (IsNumberType4Key == false)
                {
                    if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "NewModel.editModel4{1}.{0} = cls{1}BL.GetMaxStrId_S();",
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

        public string Gen_4MvcCtrl_CreateAjax()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 新建记录");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "[HttpPost]");
                strCodeForCs.Append("\r\n" + "[MultipleButton(Name = \"action\", Argument = \"CreateAjax\")]");
                strCodeForCs.AppendFormat("\r\n" + "public virtual PartialViewResult CreateAjax()",
                    objViewInfoENEx.TabName, objKeyField.CsType, objKeyField.PrivFuncName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "PrepareDdlData4Edit();");

                strCodeForCs.AppendFormat("\r\n" + "EditModel4{0} NewModel = PrepareEditModel();",
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
                strCodeForCs.AppendFormat("\r\n" + "return PartialView(\"{0}EditAjax\", NewModel);",
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
        public string Gen_4MvcCtrl_UpdateAjax()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 修改记录");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "[HttpPost]");
                strCodeForCs.Append("\r\n" + "[MultipleButton(Name = \"action\", Argument = \"UpdateAjax\")]");
                strCodeForCs.Append("\r\n" + "public virtual PartialViewResult UpdateAjax(string[] checkedId)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if (checkedId == null || checkedId.Length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"请选择需要修改的记录!\");");
                strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "PrepareDdlData4Edit();");

                if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = {0}.Parse(checkedId[0]);",
                  objKeyField.CsType, objKeyField.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = checkedId[0];",
       objKeyField.CsType, objKeyField.PrivFuncName);
                }

                strCodeForCs.AppendFormat("\r\n" + "EditModel4{0} NewModel = PrepareEditModel({1});",
                    objMainPrjTab.TabName, objKeyField.PrivFuncName);

                strCodeForCs.Append("\r\n" + "ViewBag.Operate = \"Update\";");
                //strCodeForCs.AppendFormat("\r\n" + "NewModel.{0} = cls{1}BL.GetMaxStrId_S();",
                //    FldName4Key, objMainPrjTab.TabName);
                strCodeForCs.AppendFormat("\r\n" + "seKeyId = {0};", objKeyField.PrivFuncName);

                strCodeForCs.AppendFormat("\r\n" + "return PartialView(\"{0}EditAjax\", NewModel);",
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


        public string Gen_4MvcCtrl_OnException()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// Mvc 控制器(Controller)的异常(Exception)处理函数");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + " protected override void OnException(ExceptionContext filterContext)");
                strCodeForCs.Append("\r\n" + "        {");
                strCodeForCs.Append("\r\n" + "            if (filterContext.Exception == null) return;");
                strCodeForCs.Append("\r\n" + "            //获取抛出异常的对象          ");
                strCodeForCs.Append("\r\n" + "             //写日志    ");
                strCodeForCs.Append("\r\n" + "  	    //Exception ex = filterContext.Exception;             ");
                strCodeForCs.Append("\r\n" + "            //System.IO.File.AppendAllText(filterContext.HttpContext.Server.MapPath(\"/Logs/Log.txt\"), ex.ToString());");
                strCodeForCs.Append("\r\n" + "            //如果这里设为false,就表示告诉MVC框架,我没有处理这个错误。然后让它跳转到自己定义的错误页（设为true的话,就表示告诉MVC框架,异常我已经处理了。不需要在跳转到错误页了,也部会抛出黄页了）          ");
                strCodeForCs.Append("\r\n" + "            filterContext.ExceptionHandled = true;");
                strCodeForCs.Append("\r\n" + "            filterContext.HttpContext.Response.Clear();");
                strCodeForCs.Append("\r\n" + "            filterContext.HttpContext.Response.ContentEncoding = Encoding.UTF8;");
                strCodeForCs.Append("\r\n" + "            filterContext.HttpContext.Response.HeaderEncoding = Encoding.UTF8;");
                strCodeForCs.Append("\r\n" + "            filterContext.HttpContext.Response.TrySkipIisCustomErrors = true;");
                strCodeForCs.Append("\r\n" + "            filterContext.HttpContext.Response.StatusCode = 500;");

                strCodeForCs.Append("\r\n" + "    string strMsg = filterContext.Exception.Message;");
                strCodeForCs.Append("\r\n" + "            string strUTF8Code = \"\";");
                strCodeForCs.Append("\r\n" + "            //foreach (byte b in Encoding.UTF8.GetBytes(strMsg))");
                strCodeForCs.Append("\r\n" + "            //{");
                strCodeForCs.Append("\r\n" + "            //    strUTF8Code += '%' + b.ToString(\"X\");");
                strCodeForCs.Append("\r\n" + "            //}");
                strCodeForCs.Append("\r\n" + "            strUTF8Code = HttpUtility.UrlEncode(strMsg, Encoding.UTF8);");
                strCodeForCs.Append("\r\n" + "            filterContext.HttpContext.Response.StatusDescription = strUTF8Code;");
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
                strCodeForCs.Append("\r\n" + "[HttpPost]");
                strCodeForCs.Append("\r\n" + "[MultipleButton(Name = \"action\", Argument = \"Update\")]");
                strCodeForCs.Append("\r\n" + "public virtual ViewResult Update(string[] checkedId)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if (checkedId == null || checkedId.Length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"请选择需要修改的记录!\");");
                strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
         
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "PrepareDdlViewData();");

                if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = {0}.Parse(checkedId[0]);",
                  objKeyField.CsType, objKeyField.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = checkedId[0];",
       objKeyField.CsType, objKeyField.PrivFuncName);
                }

                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModel = PrepareModel(null, {1});",
                    objMainPrjTab.TabName, objKeyField.PrivFuncName);

                strCodeForCs.Append("\r\n" + "ViewBag.Operate = \"Update\";");
                //strCodeForCs.AppendFormat("\r\n" + "NewModel.{0} = cls{1}BL.GetMaxStrId_S();",
                //    FldName4Key, objMainPrjTab.TabName);
                strCodeForCs.AppendFormat("\r\n" + "seKeyId = {0};", objKeyField.PrivFuncName);

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
        public string Gen_4MvcCtrl_UpdateInTab()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 修改记录");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public virtual ViewResult UpdateInTab({0} {1})",
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, FldName4Key, objMainPrjTab.TabName);
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
        public string Gen_4MvcCtrl_UpdateInTabAjax()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 修改记录");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public virtual PartialViewResult UpdateInTabAjax({0} {1})",
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, FldName4Key, objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "{");
                if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "if ({0} == 0)", KeyFldName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true)", KeyFldName);
                }
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"没有选择记录,不能修改!\");");
                strCodeForCs.Append("\r\n" + "            TempData[\"message\"] = string.Format(\"没有选择记录,不能修改!\");");

                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "PrepareDdlData4Edit();");

                strCodeForCs.AppendFormat("\r\n" + "EditModel4{0} NewModel = PrepareEditModel({1});",
                    objMainPrjTab.TabName, FldName4Key);

                strCodeForCs.Append("\r\n" + "ViewBag.Operate = \"Update\";");
                //strCodeForCs.AppendFormat("\r\n" + "NewModel.{0} = cls{1}BL.GetMaxStrId_S();",
                //    FldName4Key, objMainPrjTab.TabName);
                strCodeForCs.AppendFormat("\r\n" + "seKeyId = {0};", FldName4Key);
                strCodeForCs.AppendFormat("\r\n" + "return PartialView(\"{0}EditAjax\", NewModel);",
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
                strCodeForCs.AppendFormat("\r\n" + "public virtual ActionResult List(int page = 1)",
                    FldName4Key);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "sePageIndex = page;");
                strCodeForCs.Append("\r\n" + "seIsAjax = false;");
                strCodeForCs.Append("\r\n" + "PrepareDdlViewData();");
                if (objSortField != null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "string sortOrder = string.Format(\"{{0}}\", con{0}.{1});",
                        objViewInfoENEx.TabName_Out, objSortField.FldName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "string sortOrder = string.Format(\"{{0}}\", con{0}.{1});",
                        objViewInfoENEx.TabName_Out, objKeyField.FldName);
                }
//                string sortOrder = string.Format("{0}_desc", conUserPrjGrant.LastVisitedDate);
                strCodeForCs.AppendFormat("\r\n" + "seSortOrder = sortOrder;");
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
                strCodeForCs.AppendFormat("\r\n" + "public virtual ActionResult Pager(int page = 1)",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");                        
                strCodeForCs.Append("\r\n" + "PrepareDdlViewData();");
                strCodeForCs.Append("\r\n" + "sePageIndex = page;");
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
                strCodeForCs.AppendFormat("\r\n" + "public virtual ActionResult RedirectToList()",
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

        public string Gen_4MvcCtrl_RedirectToListAjax()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 返回列表Ajax区共享视图");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/// <returns></returns>");
                strCodeForCs.AppendFormat("\r\n" + "public virtual PartialViewResult RedirectToListAjax(string[] checkedId = null)",
                    FldName4Key);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string sortOrder = seSortOrder;");
               
                    strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModel = PrepareListModel(seQryModel4{1}, sortOrder, sePageIndex);",
                 objMainPrjTab.TabName, objViewInfoENEx.TabName_Out);
               
                strCodeForCs.Append("\r\n" + "if (checkedId != null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN objInFor in NewModel.{0}Lst)",
objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "if (checkedId.Contains(objInFor.{0}.ToString()) == true) objInFor._Checked = \"checked\";",
                    objKeyField.FldName, objKeyField.PrivFuncName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.AppendFormat("\r\n" + "return PartialView(\"{0}LstAjax\", NewModel);", objViewInfoENEx.TabName);

                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 返回列表Ajax区共享视图");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/// <returns></returns>");
                strCodeForCs.AppendFormat("\r\n" + "public virtual PartialViewResult RedirectToListAjax({0} {1})",
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, FldName4Key);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string sortOrder = seSortOrder;");

                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModel = PrepareListModel(seQryModel4{1}, sortOrder, sePageIndex);",
                objMainPrjTab.TabName, objViewInfoENEx.TabName_Out);

                if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "if ({0} > 0)", KeyFldName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == false)", KeyFldName);
                }

                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN objInFor in NewModel.{0}Lst)",
objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "if ({0} == objInFor.{0}) objInFor._Checked = \"checked\";",
                    objKeyField.FldName, objKeyField.PrivFuncName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.AppendFormat("\r\n" + "return PartialView(\"{0}LstAjax\", NewModel);", objViewInfoENEx.TabName);

                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_4MvcCtrl_ListAjax()
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
                strCodeForCs.AppendFormat("\r\n" + "public virtual ActionResult ListAjax(int page = 1)",
                    FldName4Key);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//设置查询区是否隐藏");
                strCodeForCs.Append("\r\n" + "ViewBag.IsHideQryRegion = false;");

                strCodeForCs.Append("\r\n" + "sePageIndex = page;");
                strCodeForCs.Append("\r\n" + "seIsAjax = false;");
                if (objSortField != null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "string sortOrder = string.Format(\"{{0}}\", con{0}.{1});",
                        objViewInfoENEx.TabName_Out, objSortField.FldName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "string sortOrder = string.Format(\"{{0}}\", con{0}.{1});",
                        objViewInfoENEx.TabName_Out, objKeyField.FldName);
                }

                //                string sortOrder = string.Format("{0}_desc", conUserPrjGrant.LastVisitedDate);
                strCodeForCs.AppendFormat("\r\n" + "seSortOrder = sortOrder;");
                strCodeForCs.Append("\r\n" + "//准备查询区模型,包括查询区下拉框的绑定数据");
                strCodeForCs.AppendFormat("\r\n" + "QryModel4{0} NewModel = PrepareQueryModel();",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "FeatureModel4{0} FeatureModel = PrepareFeatureModel();",
               objViewInfoENEx.TabName_In);
                strCodeForCs.AppendFormat("\r\n" + "return View(\"{0}CRUDAjax\", Tuple.Create( NewModel, FeatureModel));",
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
                strCodeForCs.AppendFormat("\r\n" + "public virtual ActionResult Query(ViewModel4{0} model)",
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
                strCodeForCs.Append("\r\n" + "[HttpPost]");
                strCodeForCs.Append("\r\n" + "[MultipleButton(Name = \"action\", Argument = \"QueryAjax\")]");
                strCodeForCs.AppendFormat("\r\n" + "public virtual PartialViewResult QueryAjax(QryModel4{1} model)",
                    objMainPrjTab.TabName, objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string sortOrder = seSortOrder;");

                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModel = PrepareListModel(model, sortOrder);",
                    objMainPrjTab.TabName);
                strCodeForCs.AppendFormat("\r\n" + "seQryModel4{0} = model;",
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

        public string Gen_4MvcCtrl_QueryAjax2()
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
                strCodeForCs.AppendFormat("\r\n" + "public virtual PartialViewResult QueryAjax2(QryModel4{1} model)",
                    objMainPrjTab.TabName, objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string sortOrder = seSortOrder;");

                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModel = PrepareListModel(model, sortOrder);",
                    objMainPrjTab.TabName);
                strCodeForCs.AppendFormat("\r\n" + "seQryModel4{0} = model;",
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

        public string Gen_4MvcCtrl_DownLoadFile()
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
                strCodeForCs.Append("\r\n" + "public virtual FileResult DownLoadFile(string FileName)");
                strCodeForCs.Append("\r\n" + "{");
                //	下载文件,测试成功

                strCodeForCs.Append("\r\n" + "string filePath = Server.MapPath(FileName);");
                strCodeForCs.Append("\r\n" + "string strFileName = clsString.GetSimpleFName_S(filePath); ");
                strCodeForCs.Append("\r\n" + "byte[] fileBytes = System.IO.File.ReadAllBytes(filePath);");
                strCodeForCs.Append("\r\n" + "return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, strFileName);");
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_4MvcCtrl_SortListAjax()
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
                strCodeForCs.AppendFormat("\r\n" + "public virtual PartialViewResult SortListAjax(string sortOrder)",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "seSortOrder = sortOrder;");                
                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModel = PrepareListModel(seQryModel4{1}, sortOrder);",
                    objMainPrjTab.TabName, objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + " NewModel.qryModel4{0} = seQryModel4{0};",
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

        public string Gen_4MvcCtrl_PagerAjax()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 处理分页");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/// <param name=\"page\">页序号</param>");
                strCodeForCs.Append("\r\n" + "/// <returns></returns>");
                strCodeForCs.AppendFormat("\r\n" + "public virtual PartialViewResult PagerAjax(int page=1)",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                // strCodeForCs.Append("\r\n" + "PrepareDdlViewData();");
                strCodeForCs.Append("\r\n" + "sePageIndex = page;");
                strCodeForCs.Append("\r\n" + "string sortOrder = seSortOrder;");
                strCodeForCs.Append("\r\n" + "sePageIndex = page;");
                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModel = PrepareListModel(seQryModel4{1}, sortOrder, page);",
                    objMainPrjTab.TabName, objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "NewModel.qryModel4{0} = seQryModel4{0};",
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
                strCodeForCs.AppendFormat("\r\n" + "public virtual ActionResult Delete({0} {1})",
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
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
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
                strCodeForCs.AppendFormat("\r\n" + "public virtual  ActionResult GetObjBy{1}({0} {1})",
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
                strCodeForCs.AppendFormat("\r\n" + "public virtual JsonResult GetJsonObjBy{1}({0} {1})",
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
                strCodeForCs.Append("\r\n" + "[HttpPost]");
                strCodeForCs.Append("\r\n" + "[MultipleButton(Name = \"action\", Argument = \"Deletes\")]");
                strCodeForCs.AppendFormat("\r\n" + "public virtual ActionResult Deletes(string[] checkedId)",
                    FldName4Key);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "PrepareDdlViewData();");
             

                strCodeForCs.Append("\r\n" + " try");
                strCodeForCs.Append("\r\n" + "            {");
                strCodeForCs.Append("\r\n" + "if (checkedId == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"没有选择记录,不能删除!\");");
                strCodeForCs.Append("\r\n" + "            TempData[\"message\"] = string.Format(\"没有选择记录,不能删除!\");");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
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
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
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
        public string Gen_4MvcCtrl_DeletesAjax()
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
                strCodeForCs.Append("\r\n" + "[HttpPost]");
                strCodeForCs.Append("\r\n" + "[MultipleButton(Name = \"action\", Argument = \"DeletesAjax\")]");
                strCodeForCs.AppendFormat("\r\n" + "public virtual PartialViewResult DeletesAjax(string[] checkedId)",
                    FldName4Key);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "PrepareDdlViewData();");


                strCodeForCs.Append("\r\n" + " try");
                strCodeForCs.Append("\r\n" + "            {");
                strCodeForCs.Append("\r\n" + "if (checkedId == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"没有选择记录,不能删除!\");");
                strCodeForCs.Append("\r\n" + "            TempData[\"message\"] = string.Format(\"没有选择记录,不能删除!\");");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
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
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "            }");
                strCodeForCs.Append("\r\n" + "            return RedirectToListAjax(checkedId);");

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

        public string Gen_4MvcCtrl_DeleteAjax()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 删除数据列表中的一条记录");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name=\"{0}\">待删除的关键字</param>", FldName4Key);
                strCodeForCs.Append("\r\n" + "/// <returns></returns>");
                strCodeForCs.AppendFormat("\r\n" + "public virtual PartialViewResult DeleteAjax({0} {1})",
                     objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, FldName4Key);
                strCodeForCs.Append("\r\n" + "{");

//                strCodeForCs.Append("\r\n" + "PrepareDdlViewData();");


                strCodeForCs.Append("\r\n" + " try");
                strCodeForCs.Append("\r\n" + "            {");
                if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "if ({0} == 0)", KeyFldName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true)", KeyFldName);
                }
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"没有选择记录,不能删除!\");");
                strCodeForCs.Append("\r\n" + "            TempData[\"message\"] = string.Format(\"没有选择记录,不能删除!\");");
        
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.AppendFormat("\r\n" + "int intRecCount = cls{0}BL.DelRecord({1});",
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
                strCodeForCs.Append("\r\n" + "                string strMsg = string.Format(\"删除一条记录出错!出错信息:{0}.\", objException.Message);");
                strCodeForCs.Append("\r\n" + "                TempData[\"message\"] = strMsg;");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "            }");
                strCodeForCs.AppendFormat("\r\n" + "      return RedirectToListAjax({0});", KeyFldName);

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


        public string Gen_4MvcCtrl_DelRecordBySignAjax()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            if (objDelSignField == null)
            {
                string strMsg = string.Format("//表：[{0}]的删除标志字段(DeletedDate, IsDeleted)为空,不能生成【恢复被删除记录(UnDelRecordBySign)】函数;",
                    objViewInfoENEx.TabName);
                throw new Exception(strMsg);
                //strCodeForCs.AppendFormat("\r\n" + "//表：[{0}]的删除标志字段为空,不能生成【标志性删除记录(DelRecordBySign)】函数;", 
                //    objViewInfoENEx.TabName);
                //return strCodeForCs.ToString();
            }
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 标志性删除数据列表中多选的首条记录");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/// <param name=\"checkedId\">多选的关键字列表</param>");
                strCodeForCs.Append("\r\n" + "/// <returns></returns>");
                strCodeForCs.Append("\r\n" + "[HttpPost]");
                strCodeForCs.Append("\r\n" + "[MultipleButton(Name = \"action\", Argument = \"DelRecordBySignAjax\")]");
                strCodeForCs.AppendFormat("\r\n" + "public virtual PartialViewResult DelRecordBySignAjax(string[] checkedId)",
                    FldName4Key);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "PrepareDdlViewData();");


                strCodeForCs.Append("\r\n" + " try");
                strCodeForCs.Append("\r\n" + "            {");
                strCodeForCs.Append("\r\n" + "if (checkedId == null || checkedId.Length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "            TempData[\"message\"] = string.Format(\"没有选择记录,不能删除!\");");
                strCodeForCs.Append("\r\n" + "            return RedirectToListAjax();");
                strCodeForCs.Append("\r\n" + "}");

                //strCodeForCs.Append("\r\n" + "string strIds = string.Join(", ", checkedId.Cast<string>().ToArray());
                strCodeForCs.AppendFormat("\r\n" + "List<string> arr{0} = new List<string>(checkedId);",
                    FldName4Key);
                //  DAL.BatchDelete(strIds)
                //return View();
//                strCodeForCs.Append("\r\n" + "int intRecCount = 0;");
                //strCodeForCs.AppendFormat("\r\n" + "     foreach(string strKey in arr{0})", FldName4Key);
                //strCodeForCs.Append("\r\n" + "                {");
                strCodeForCs.AppendFormat("\r\n" + "int intRecCount = cls{0}BL.DelRecordBySign(arr{1});",
                    objMainPrjTab.TabName,
                    FldName4Key);
                //strCodeForCs.Append("\r\n" + "intRecCount += intDelCount;");
                //strCodeForCs.Append("\r\n" + "                }");

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
                strCodeForCs.Append("\r\n" + "                string strMsg = string.Format(\"标志性删除一条记录出错!出错信息:{0}.\", objException.Message);");
                strCodeForCs.Append("\r\n" + "                TempData[\"message\"] = strMsg;");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "            }");
                strCodeForCs.Append("\r\n" + "            return RedirectToListAjax(checkedId);");

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


        public string Gen_4MvcCtrl_UnDelRecordBySignAjax()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            if (objDelSignField == null)
            {
string strMsg = string.Format("//表：[{0}]的删除标志字段(DeletedDate, IsDeleted)为空,不能生成【恢复被删除记录(UnDelRecordBySign)】函数;",
                    objViewInfoENEx.TabName);
                throw new Exception(strMsg);
                //strCodeForCs.AppendFormat("\r\n" + "//表：[{0}]的删除标志字段为空,不能生成【恢复被删除记录(UnDelRecordBySign)】函数;",
                //    objViewInfoENEx.TabName);
                //return strCodeForCs.ToString();
            }
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 恢复删除数据列表中多选的首条记录");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/// <param name=\"checkedId\">多选的关键字列表</param>");
                strCodeForCs.Append("\r\n" + "/// <returns></returns>");
                strCodeForCs.Append("\r\n" + "[HttpPost]");
                strCodeForCs.Append("\r\n" + "[MultipleButton(Name = \"action\", Argument = \"UnDelRecordBySignAjax\")]");
                strCodeForCs.AppendFormat("\r\n" + "public virtual PartialViewResult UnDelRecordBySignAjax(string[] checkedId)",
                    FldName4Key);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "PrepareDdlViewData();");


                strCodeForCs.Append("\r\n" + " try");
                strCodeForCs.Append("\r\n" + "            {");
                strCodeForCs.Append("\r\n" + "if (checkedId == null || checkedId.Length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "            TempData[\"message\"] = string.Format(\"没有选择记录,不能恢复删除!\");");
                strCodeForCs.Append("\r\n" + "            return RedirectToListAjax();");
                strCodeForCs.Append("\r\n" + "}");

                //strCodeForCs.Append("\r\n" + "string strIds = string.Join(", ", checkedId.Cast<string>().ToArray());
                strCodeForCs.AppendFormat("\r\n" + "List<string> arr{0} = new List<string>(checkedId);",
                    FldName4Key);
                //  DAL.BatchDelete(strIds)
                
         //       strCodeForCs.Append("\r\n" + "int intRecCount = 0;");
                //strCodeForCs.AppendFormat("\r\n" + "     foreach(string strKey in arr{0})", FldName4Key);
                //strCodeForCs.Append("\r\n" + "                {");
                strCodeForCs.AppendFormat("\r\n" + "int intRecCount = cls{0}BL.UnDelRecordBySign(arr{1});",
                    objMainPrjTab.TabName,
                    FldName4Key);
                //strCodeForCs.Append("\r\n" + "intRecCount += intDelCount;");
                //strCodeForCs.Append("\r\n" + "                }");

                strCodeForCs.Append("\r\n" + "                if (intRecCount > 0)");
                strCodeForCs.Append("\r\n" + "                {");
                strCodeForCs.Append("\r\n" + "                    TempData[\"message\"] = string.Format(\"有[{0}]条记录 已经被恢复删除!\", intRecCount);");
                strCodeForCs.Append("\r\n" + "                }");
                strCodeForCs.Append("\r\n" + "                else");
                strCodeForCs.Append("\r\n" + "                {");
                strCodeForCs.Append("\r\n" + "                    TempData[\"message\"] = string.Format(\"有[0]条记录被恢复删除!\");");
                strCodeForCs.Append("\r\n" + "                }");
                strCodeForCs.Append("\r\n" + "            }");
                strCodeForCs.Append("\r\n" + "            catch(Exception objException)");
                strCodeForCs.Append("\r\n" + "            {");
                strCodeForCs.Append("\r\n" + "                string strMsg = string.Format(\"恢复删除一条记录出错!出错信息:{0}.\", objException.Message);");
                strCodeForCs.Append("\r\n" + "                TempData[\"message\"] = strMsg;");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "            }");
                strCodeForCs.Append("\r\n" + "            return RedirectToListAjax(checkedId);");
                             
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
                strCodeForCs.AppendFormat("\r\n" + "public virtual ViewResult SortList(ViewModel4{0} model, string sortOrder)",
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

                strCodeForCs.AppendFormat("\r\n" + "public virtual ActionResult Save(ViewModel4{0} model, string Operate)",
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
                strCodeForCs.AppendFormat("\r\n" + "PutDataTo{0}Class(obj{0}EN, model.editModel4{0});",
                    objMainPrjTab.TabName);
                if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
                {
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.Append("\r\n" + "//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键");
                    strCodeForCs.AppendFormat("\r\n" + "//if (cls{0}BL.IsExist({1}) == true)",
                    objMainPrjTab.TabName, strKeyFldName_ObjName);
                    strCodeForCs.Append("\r\n" + "//{");

                    strCodeForCs.AppendFormat("\r\n" + "//string strMsg = string.Format(\"关键字:[用户Id:{0}]已经存在,不能重复添加相同关键字记录!\",  model.editModel4{1}.{0});",
                            FldName4Key, objViewInfoENEx.TabName);
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

                    strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"关键字:[用户Id:{0}]已经存在,不能重复添加相同关键字记录!\",  model.editModel4{1}.{0});",
                            FldName4Key, objViewInfoENEx.TabName);
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
                        objMainPrjTab.TabName, objKeyField.FldName, strKeyFldName_ObjName);
                    strCodeForCs.Append("\r\n" + " {");
                    strCodeForCs.AppendFormat("\r\n" + "     obj{0}EN.{1} = cls{0}BL.GetMaxStrId_S();",
                        objMainPrjTab.TabName, objKeyField.FldName);
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
                strCodeForCs.Append("\r\n" + "//return RedirectToList();");

                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                    objMainPrjTab.TabName);
                strCodeForCs.AppendFormat("\r\n" + "PutDataTo{0}Class(obj{0}EN, model.editModel4{0});",
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
                strCodeForCs.Append("\r\n" + "//return RedirectToList();");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "}");

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

        public string Gen_4MvcCtrl_SaveAjax()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 修改记录");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + " [HttpPost]");

                strCodeForCs.AppendFormat("\r\n" + "public virtual ActionResult SaveAjax(EditModel4{0} model, string Operate)",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "{");
               
                strCodeForCs.Append("\r\n" + "if (ModelState.IsValid == false)");                
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = \"编辑记录有错!\";");
                strCodeForCs.Append("\r\n" + "ModelState.AddModelError(\"\", strMsg);");
                strCodeForCs.Append("\r\n" + "string action = GetCurrentAction();");
                //strCodeForCs.AppendFormat("\r\n" + "NewModel.{0} = cls{1}BL.GetMaxStrId_S();",
                //    FldName4Key, objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "ViewBag.EditError = \"true\";");
                //strCodeForCs.Append("\r\n" + "ViewBag.PreOperate = Operate;");
                strCodeForCs.Append("\r\n" + "ViewBag.Operate = Operate;");
                strCodeForCs.Append("\r\n" + "            return RedirectToListAjax();");
                //strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModel = PrepareModel(null);",
                //    objMainPrjTab.TabName);
                //strCodeForCs.AppendFormat("\r\n" + "return View(\"{0}CRUD\", NewModel);",
                //    objMainPrjTab.TabName);
                //return RedirectToAction("List");

                strCodeForCs.Append("\r\n" + "}");


                strCodeForCs.Append("\r\n" + "if (Operate == \"Add\")");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return AddSaveAjax(model);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return UpdateSaveAjax(model);");
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

        public string Gen_4MvcCtrl_UpdateSaveAjax()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 修改记录");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + " [HttpPost]");

                strCodeForCs.AppendFormat("\r\n" + "public virtual ActionResult UpdateSaveAjax(EditModel4{0} model)",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "PrepareDdlData4Edit();");
                
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
                strCodeForCs.Append("\r\n" + "ViewBag.Operate = \"\";");
                strCodeForCs.Append("\r\n" + "            return RedirectToListAjax();");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"[{0}]编辑记录有错!错误：{1}\", clsStackTrace.GetCurrFunction(), objException.Message);");
                strCodeForCs.Append("\r\n" + "TempData[\"message\"] = strMsg;");
                strCodeForCs.Append("\r\n" + "ModelState.AddModelError(\"\", strMsg);");
                //strCodeForCs.Append("\r\n" + "return RedirectToAction(\"Update\", NewModel);");
                strCodeForCs.Append("\r\n" + "ViewBag.Operate = \"Update\";");
                strCodeForCs.Append("\r\n" + "string strJS = string.Format(\"ShowErrMsg('{0}'); \", strMsg);");
                strCodeForCs.Append("\r\n" + "return JavaScript(strJS);");
                strCodeForCs.Append("\r\n" + "//throw new Exception(strMsg);");
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


        public string Gen_4MvcCtrl_AddSaveAjax()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 修改记录");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + " [HttpPost]");

                strCodeForCs.AppendFormat("\r\n" + "public virtual ActionResult AddSaveAjax(EditModel4{0} model)",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "PrepareDdlData4Edit();");

         
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

                    strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"[{{0}}]关键字:[用户Id:{0}]已经存在,不能重复添加相同关键字记录!\", clsStackTrace.GetCurrFunction(), model.{0});",
                            FldName4Key);
                    strCodeForCs.Append("\r\n" + "TempData[\"message\"] = strMsg;");
                    strCodeForCs.Append("\r\n" + "ModelState.AddModelError(\"\", strMsg);");
                    //strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModel = PrepareModel(model, {1});",
                    //    objMainPrjTab.TabName, IsNumberType4Key ? "0" : "\"\"");
                    //strCodeForCs.Append("\r\n" + "return RedirectToAction(\"Create\", NewModel);");
                    strCodeForCs.Append("\r\n" + "ViewBag.Operate = \"Add\";");
                    //strCodeForCs.AppendFormat("\r\n" + "return View(\"{0}CRUD\", model);",
                    //    objMainPrjTab.TabName);
                    strCodeForCs.Append("\r\n" + "string strJS = string.Format(\"ShowErrMsg('{0}'); \", strMsg);");
                    strCodeForCs.Append("\r\n" + "return JavaScript(strJS);");
                    strCodeForCs.Append("\r\n" + "}");
                }

                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.CheckPropertyNew();",
                objMainPrjTab.TabName);

                if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
                {
                    strCodeForCs.Append("\r\n" + "//因为是字符型自增主键,所以在添加时,自动获取主键值。");
                    strCodeForCs.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(obj{0}EN.{1}) == true || cls{0}BL.IsExist({2}) == true)",
                        objMainPrjTab.TabName, objKeyField.FldName, strKeyFldName_ObjName);
                    strCodeForCs.Append("\r\n" + " {");
                    strCodeForCs.AppendFormat("\r\n" + "     obj{0}EN.{1} = cls{0}BL.GetMaxStrId_S();",
                        objMainPrjTab.TabName, objKeyField.FldName);
                    strCodeForCs.Append("\r\n" + " }");
                }

                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.AddNewRecord();",
                    objMainPrjTab.TabName);
                strCodeForCs.AppendFormat("\r\n" + "TempData[\"message\"] = string.Format(\"{{0}} has been saved\", obj{0}EN.{1});",
                    objMainPrjTab.TabName, FldName4Key, "{", "}");
                strCodeForCs.Append("\r\n" + "ViewBag.Operate = \"\";");
                strCodeForCs.Append("\r\n" + "            return RedirectToListAjax();");

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"[{0}]编辑记录有错!错误：{1}\", clsStackTrace.GetCurrFunction(), objException.Message);");
                strCodeForCs.Append("\r\n" + "TempData[\"message\"] = strMsg;");
                strCodeForCs.Append("\r\n" + "ModelState.AddModelError(\"\", strMsg);");
                //strCodeForCs.Append("\r\n" + "return RedirectToAction(\"Create\", NewModel);");
                strCodeForCs.Append("\r\n" + "ViewBag.Operate = \"Add\";");
  
                strCodeForCs.Append("\r\n" + "string strJS = string.Format(\"ShowErrMsg('{0}'); \", strMsg);");
                strCodeForCs.Append("\r\n" + "return JavaScript(strJS);");
  
                strCodeForCs.Append("\r\n" + "//return View();");
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
        

        public string Gen_4MvcCtrl_seSortOrder()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 用于保存排序信息的Session");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n" + "public string seSortOrder",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strSortOrder;");
                strCodeForCs.AppendFormat("\r\n" + "strSortOrder = (string)System.Web.HttpContext.Current.Session[\"SortOrder4{0}\"];", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "if (strSortOrder == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "strSortOrder = \"\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return strSortOrder;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strSortOrder = value;");
                strCodeForCs.AppendFormat("\r\n" + "System.Web.HttpContext.Current.Session.Add(\"SortOrder4{0}\", strSortOrder);", objViewInfoENEx.TabName);

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

        public string Gen_4MvcCtrl_sePageIndex()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 用于保存排序信息的Session");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n" + "public int sePageIndex",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strPageIndex;");
                strCodeForCs.AppendFormat("\r\n" + "strPageIndex = (string)System.Web.HttpContext.Current.Session[\"PageIndex4{0}\"];", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "if (strPageIndex == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return 1;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return int.Parse(strPageIndex);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strPageIndex = value.ToString();");
                strCodeForCs.AppendFormat("\r\n" + "System.Web.HttpContext.Current.Session.Add(\"PageIndex4{0}\", strPageIndex);", objViewInfoENEx.TabName);

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

        public string Gen_4MvcCtrl_seTabInfo4Feature()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strTabName = objViewInfoENEx.TabName_In;
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 用于查询信息的Session");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n" + "public FeatureModel4{0} seFeatureModel4{0}",
                    strTabName);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "FeatureModel4{0} objFeatureModel4{0};",
                    strTabName);
                strCodeForCs.AppendFormat("\r\n" + "objFeatureModel4{0} = (FeatureModel4{0})System.Web.HttpContext.Current.Session[\"FeatureModel4{0}\"];",
                    strTabName);
                strCodeForCs.AppendFormat("\r\n" + "return objFeatureModel4{0};",
                    strTabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "FeatureModel4{0} objFeatureModel4{0} = value;",
                    strTabName);
                strCodeForCs.AppendFormat("\r\n" + "System.Web.HttpContext.Current.Session.Add(\"FeatureModel4{0}\", objFeatureModel4{0});",
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

                strCodeForCs.AppendFormat("\r\n" + "protected virtual void PrepareDdlViewData()",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "{");
                //string strTemp = Gen_4MvcCtrl_GetDdlBindDS();
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
        public string Gen_4MvcCtrl_PrepareDdlData4Query()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 为查询区准备下拉框的绑定数据");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n" + "protected virtual void PrepareDdlData4Query()",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "{");
                string strTemp = Gen_4MvcCtrl_GetDdlBindDS4Query();
                strCodeForCs.AppendFormat("\r\n" + "{0}", strTemp);


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

        public string Gen_4MvcCtrl_PrepareDdlData4FeatureRegion()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 为功能区准备下拉框的绑定数据");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n" + "protected virtual void PrepareDdlData4Feature()",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "{");
                string strTemp = Gen_4MvcCtrl_GetDdlBindDS4Feature();
                strCodeForCs.AppendFormat("\r\n" + "{0}", strTemp);


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
        public string Gen_4MvcCtrl_PrepareDdlData4Edit()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 为编辑区准备下拉框的绑定数据");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n" + "protected virtual void PrepareDdlData4Edit()",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "{");
                string strTemp = Gen_4MvcCtrl_GetDdlBindDS4Edit();
                strCodeForCs.AppendFormat("\r\n" + "{0}", strTemp);


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
        public string Gen_4MvcCtrl_GetDdlBindDSBak20230309()
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
                                strCodeForCs.Append("\r\n" + "  ViewData[\"TrueAndFalseList\"] = clsPubFun_Mvc.GetSliLst4TrueAndFalse();");
                            }
                        }
                        else
                        {
                            clsPrjTabEN objPrjTabEN_CodeTab = clsPrjTabBLEx.GetObjByTabIdEx(objQryRegionFldsEx.DsTabId);
                            //clsFieldTabEN objFieldTab_ValueField = clsFieldTabBL.GetObjByFldIdCache(objQryRegionFldsEx.DsDataValueFieldId, objViewInfoENEx.PrjId);
                            //clsFieldTabEN objFieldTabEN_TextField = clsFieldTabBL.GetObjByFldIdCache(objQryRegionFldsEx.Ds_DataTextFieldId, objViewInfoENEx.PrjId);

                            //if (objPrjTabEN_CodeTab == null)
                            //{
                            //    string strMsg = string.Format("在界面查询区,{0}下拉框的数据源表没有设置,请检查!({1})",
                            //        objQryRegionFldsEx.FldName,
                            //        clsStackTrace.GetCurrClassFunction());
                            //    throw new Exception(strMsg);
                            //}
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

        public string Gen_4MvcCtrl_GetDdlBindDS4Edit()
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
                                    strCodeForCs.Append("\r\n" + "  ViewData[\"TrueAndFalseList\"] = clsPubFun.GetSliLst4TrueAndFalse();");
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
                                             
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_4MvcCtrl_GetDdlBindDS4QueryBak()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            List<string> arrTabName = new List<string>();
            try
            {
                

                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.objCtlType.CtlTypeName.Contains("DropDownList") == true)
                    {
                        if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                        {
                            if (arrTabName.Contains("TrueAndFalse") == false)
                            {
                                arrTabName.Add("TrueAndFalse");
                                strCodeForCs.Append("\r\n" + "  ViewData[\"TrueAndFalseList\"] = clsPubFun_Mvc.GetSliLst4TrueAndFalse();");
                            }
                        }
                        else
                        {
                            clsPrjTabEN objPrjTabEN_CodeTab = clsPrjTabBLEx.GetObjByTabIdEx(objQryRegionFldsEx.DsTabId);
                            //clsFieldTabEN objFieldTab_ValueField = clsFieldTabBL.GetObjByFldIdCache(objQryRegionFldsEx.DsDataValueFieldId, objViewInfoENEx.PrjId);
                            //clsFieldTabEN objFieldTabEN_TextField = clsFieldTabBL.GetObjByFldIdCache(objQryRegionFldsEx.Ds_DataTextFieldId, objViewInfoENEx.PrjId);

                            //if (objPrjTabEN_CodeTab == null)
                            //{
                            //    string strMsg = string.Format("在界面查询区,{0}下拉框的数据源表没有设置,请检查!({1})",
                            //        objQryRegionFldsEx.FldName,
                            //        clsStackTrace.GetCurrClassFunction());
                            //    throw new Exception(strMsg);
                            //}
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
      
        Func<clsQryRegionFldsENEx, ASPDropDownListEx> GetDdlObj = obj => clsASPDropDownListBLEx.GetDropDownLst_Asp(obj, new clsGetTabFieldObj());


        public string Gen_4MvcCtrl_GetDdlBindDS4Query()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            List<string> arrTabName = new List<string>();
            try
            {

                IEnumerable<ASPDropDownListEx> arrASPDropDownListENEx = objViewInfoENEx.arrQryRegionFldSet
                    .Where(x=>x.objCtlType.CtlTypeName.Contains("DropDownList"))
                    .Select(GetDdlObj).Distinct(new DsTabNameComparer());

                foreach (ASPDropDownListEx objASPDropDownListENEx in arrASPDropDownListENEx)
                {
                    strCodeForCs.Append("\r\n" + objASPDropDownListENEx.GC_BindDdl4Mvc());
                    
                }
                //        foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                //    {
                //        if (objQryRegionFldsEx.objCtlType.CtlTypeName.Contains("DropDownList") == true)
                //        {
                //            if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                //            {
                //                if (arrTabName.Contains("TrueAndFalse") == false)
                //                {
                //                    arrTabName.Add("TrueAndFalse");
                //                    strCodeForCs.Append("\r\n" + "  ViewData[\"TrueAndFalseList\"] = clsPubFun_Mvc.GetSliLst4TrueAndFalse();");
                //                }
                //            }
                //            else
                //            {
                //                clsPrjTabEN objPrjTabEN_CodeTab = clsPrjTabBLEx.GetObjByTabIdEx(objQryRegionFldsEx.DsTabId);
                //                clsFieldTabEN objFieldTab_ValueField = clsFieldTabBLEx.GetObjByFldIDCache(objQryRegionFldsEx.DsDataValueFieldId, objViewInfoENEx.PrjId);
                //                clsFieldTabEN objFieldTabEN_TextField = clsFieldTabBLEx.GetObjByFldIDCache(objQryRegionFldsEx.Ds_DataTextFieldId, objViewInfoENEx.PrjId);

                //                if (objPrjTabEN_CodeTab == null)
                //                {
                //                    string strMsg = string.Format("在界面查询区,{0}下拉框的数据源表没有设置,请检查!({1})",
                //                        objQryRegionFldsEx.FldName,
                //                        clsStackTrace.GetCurrClassFunction());
                //                    throw new Exception(strMsg);
                //                }
                //                if (objFieldTab_ValueField == null)
                //                {
                //                    string strMsg = string.Format("在界面查询区,{0}下拉框的数据源值字段没有设置,请检查!({1})",
                //                        objQryRegionFldsEx.FldName,
                //                        clsStackTrace.GetCurrClassFunction());
                //                    throw new Exception(strMsg);
                //                }
                //                if (objFieldTabEN_TextField == null)
                //                {
                //                    string strMsg = string.Format("在界面查询区,{0}下拉框的数据源文本字段没有设置,请检查!({1})",
                //                        objQryRegionFldsEx.FldName,
                //                        clsStackTrace.GetCurrClassFunction());
                //                    throw new Exception(strMsg);
                //                }
                //                if (arrTabName.Contains(objPrjTabEN_CodeTab.TabName) == false)
                //                {
                //                    arrTabName.Add(objPrjTabEN_CodeTab.TabName);
                //                    strCodeForCs.AppendFormat("\r\n" + "ViewData[\"{0}List\"] = cls{0}BL4Mvc.GetObjLst4SelectListItem(\"1=1\");",
                //                          objPrjTabEN_CodeTab.TabName);
                //                }
                //            }
                //        }
                //    }
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        Func<clsViewFeatureFldsENEx, ASPDropDownListEx> GetDdlObj2 = obj => clsASPDropDownListBLEx.GetDropDownLst_Asp(obj, new clsGetTabFieldObj());



        public string Gen_4MvcCtrl_GetDdlBindDS4Feature()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            List<string> arrTabName = new List<string>();
            try
            {
                IEnumerable<ASPDropDownListEx> arrASPDropDownListENEx = objViewInfoENEx.arrViewFeatureFlds
                    .Where(x => x.ObjCtlType.CtlTypeName.Contains("DropDownList"))
                  .Select(GetDdlObj2).Distinct(new DsTabNameComparer());

                foreach (ASPDropDownListEx objASPDropDownListENEx in arrASPDropDownListENEx)
                {
                    strCodeForCs.Append("\r\n" + objASPDropDownListENEx.GC_BindDdl4Mvc());

                }
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
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
                strCodeForCs.AppendFormat("\r\n" + "protected  virtual string Combine{0}Condition(QryModel4{0} obj{0}EN)", objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//使条件串的初值为\"1 = 1\",以便在该串的后面用\"and \"添加其他条件,");
                strCodeForCs.Append("\r\n" + "//例如 1 = 1 && UserName = '张三'");
                strCodeForCs.Append("\r\n" + "string strWhereCond = \" 1 = 1 \";");
                strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN == null)",
             objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return strWhereCond;");

                strCodeForCs.Append("\r\n" + "}");

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
                    strCodeForCs.AppendFormat("\r\n" + "protected  virtual void PutDataTo{0}Class(cls{0}EN pobj{0}EN, EditModel4{0} model)",
                    objViewInfoENEx.TabName );
                    strCodeForCs.Append("\r\n" + "{");
                int intIndex = 0;
                    foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                    {
                    intIndex++;
                    string strTemp = "";
                    if (intIndex == 1)
                    {
                        strTemp = Get_4MvcCtrl_Code4FieldInPutDataToClass_First(objEditRegionFldsEx, objViewInfoENEx);
                    }
                    else if (intIndex == objViewInfoENEx.arrEditRegionFldSet4InUse.Count)
                    {
                        strTemp = Get_4MvcCtrl_Code4FieldInPutDataToClass_Last(objEditRegionFldsEx, objViewInfoENEx);
                    }
                    else
                    {
                        strTemp = Get_4MvcCtrl_Code4FieldInPutDataToClass(objEditRegionFldsEx, objViewInfoENEx);
                    }
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
                    strCodeForCs.AppendFormat("\r\n" + "protected  virtual void GetDataFrom{0}Class(cls{0}EN pobj{0}EN, EditModel4{0} model)",
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
                sbCodeForCs.AppendFormat("\r\n" + ".Set{1}(model.{3})",
              objViewInfoENEx.TabName, objEditRegionFldsEx.FldName, objViewInfoENEx.TabName, objEditRegionFldsEx.FldName);
                sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

                return sbCodeForCs.ToString();
            }
            sbCodeForCs.AppendFormat("\r\n" + ".Set{1}(model.{3})",
            objViewInfoENEx.TabName, objEditRegionFldsEx.FldName, objViewInfoENEx.TabName, objEditRegionFldsEx.FldName);
            sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

            return sbCodeForCs.ToString();
        }

        private string Get_4MvcCtrl_Code4FieldInPutDataToClass_First(clsEditRegionFldsENEx objEditRegionFldsEx, clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder sbCodeForCs = new StringBuilder();
            if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                  && objEditRegionFldsEx.PrimaryTypeId()== clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }
            if (objEditRegionFldsEx.FldOpTypeId() == "0002")
            {
                sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.Set{1}(model.{3})",
              objViewInfoENEx.TabName, objEditRegionFldsEx.FldName, objViewInfoENEx.TabName, objEditRegionFldsEx.FldName);
                sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

                return sbCodeForCs.ToString();
            }
            sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.Set{1}(model.{3})",
            objViewInfoENEx.TabName, objEditRegionFldsEx.FldName, objViewInfoENEx.TabName, objEditRegionFldsEx.FldName);
            sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

            return sbCodeForCs.ToString();
        }
        private string Get_4MvcCtrl_Code4FieldInPutDataToClass_Last(clsEditRegionFldsENEx objEditRegionFldsEx, clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder sbCodeForCs = new StringBuilder();
            if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                  && objEditRegionFldsEx.PrimaryTypeId()== clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }
            if (objEditRegionFldsEx.FldOpTypeId() == "0002")
            {
                sbCodeForCs.AppendFormat("\r\n" + ".Set{1}(model.{3});",
              objViewInfoENEx.TabName, objEditRegionFldsEx.FldName, objViewInfoENEx.TabName, objEditRegionFldsEx.FldName);
                sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

                return sbCodeForCs.ToString();
            }
            sbCodeForCs.AppendFormat("\r\n" + ".Set{1}(model.{3});",
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

        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(Mvc_ControllerBase4CSharp);
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
            this.ClsName = string.Format("{0}BaseController", objViewInfoENEx.TabName);
            objViewInfoENEx.ClsName = this.ClsName;
        }
    
        public string Gen_4MvcCtrl_GoTop()
        {
            if (this.objOrderNumField == null) return "";
            StringBuilder strCodeForCs = new StringBuilder();
  
 
            try
            {

                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///置顶");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "[HttpPost]");
                strCodeForCs.Append("\r\n" + "[MultipleButton(Name = \"action\", Argument = \"GoTop\")]");
                strCodeForCs.Append("\r\n" + "public ActionResult GoTop(string[] checkedId, int page = 1)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "sePageIndex = page;");
                strCodeForCs.Append("\r\n" + "if (checkedId == null || checkedId.Length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"请选择需要移动的记录!\");");
                strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                strCodeForCs.Append("\r\n" + "PrepareDdlViewData();");
                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} modelErr = new ViewModel4{0}();",
                    objMainPrjTab.TabName);
                if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModelErr = PrepareModel(modelErr, 0);",
                 objMainPrjTab.TabName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModelErr = PrepareModel(modelErr, \"\");",
                    objMainPrjTab.TabName);
                }

                strCodeForCs.AppendFormat("\r\n" + "return View(\"{0}CRUD\", NewModelErr);",
                    objMainPrjTab.TabName);

                strCodeForCs.Append("\r\n" + "}");


                strCodeForCs.Append("\r\n" + "if (PreCheck4Order() == false) return View();");
                if (objAdjustOrderNum.ClassificationFieldValueLst.Count>0)
                {
                    foreach (string strInFor in objAdjustOrderNum.ClassificationFieldValueLst)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string str{0} = {0}.ToString();",
                                strInFor);
                    }
                }
              
                if (objKeyField.CsType == "string")
                {
                    strCodeForCs.AppendFormat("\r\n" + "List<string> lst{0} = new List<string>(checkedId);",
                                        objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "List<string> lst{0}_Str = new List<string>(checkedId);",
                                        objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                    strCodeForCs.AppendFormat("\r\n" + "List<{0}> lst{1} = lst{1}_Str.Select(x => {0}.Parse(x)).ToList();",
                        objKeyField.CsType,
                        objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                }
                strCodeForCs.AppendFormat("\r\n" + "if (lst{0}  == null)",
                    objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = \"请选择需要置顶的记录!\";");
                strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                strCodeForCs.Append("\r\n" + "return View();");

                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                if (string.IsNullOrEmpty(objAdjustOrderNum.VarLst) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.GoTop(lst{1});",
                      objViewInfoENEx.TabName,
                      objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.GoTop(lst{2}, {1});",
                         objViewInfoENEx.TabName,
                         objAdjustOrderNum.VarLst,
                         objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"置顶出错。错误:{0}.({1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
                strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "}");
                                
                strCodeForCs.Append("\r\n" + "PrepareDdlViewData();");

                strCodeForCs.Append("\r\n" + "string sortOrder = seSortOrder;");
                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} model = new ViewModel4{0}();",
                    objMainPrjTab.TabName);
                strCodeForCs.AppendFormat("\r\n" + "model.qryModel4{0} = seQryModel4{0};",
                    objViewInfoENEx.TabName_Out);

                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModel = PrepareModel(model, {1}, sortOrder, page);",
                    objMainPrjTab.TabName, IsNumberType4Key ? "0" : "\"\"");

                strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN objInFor in NewModel.{0}Lst)",
    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "if (checkedId.Contains(objInFor.{0}.ToString()) == true) objInFor._Checked = \"checked\";",
                    objKeyField.FldName, objKeyField.PrivFuncName);
                strCodeForCs.Append("\r\n" + "}");


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

        public string Gen_4MvcCtrl_GoTopAjax()
        {
            if (this.objOrderNumField == null) return "";
            StringBuilder strCodeForCs = new StringBuilder();
         
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///置顶");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "[HttpPost]");
                strCodeForCs.Append("\r\n" + "[MultipleButton(Name = \"action\", Argument = \"GoTopAjax\")]");
                if (objAdjustOrderNum.VarDefLst.Count() == 0)
                {
                    strCodeForCs.Append("\r\n" + "public virtual PartialViewResult GoTopAjax(string[] checkedId, int page = 1)");
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "public virtual PartialViewResult GoTopAjax(string[] checkedId, {0}, int page = 1)",
                        string.Join(",", objAdjustOrderNum.VarDefLst));
                }
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "sePageIndex = page;");
                strCodeForCs.Append("\r\n" + "if (checkedId == null || checkedId.Length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"请选择需要移动的记录!\");");
                strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");

                strCodeForCs.Append("\r\n" + "}");


                strCodeForCs.Append("\r\n" + "if (PreCheck4Order() == false) return RedirectToListAjax();");
                if (objAdjustOrderNum.ClassificationFieldValueLst.Count>0)
                {
                    foreach (string strInFor in objAdjustOrderNum.ClassificationFieldValueLst)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string str{0} = {0}.ToString();",
                              strInFor);
                    }
                }
                if (objKeyField.CsType == "string")
                {
                    strCodeForCs.AppendFormat("\r\n" + "List<string> lst{0} = new List<string>(checkedId);",
                                        objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "List<string> lst{0}_Str = new List<string>(checkedId);",
                                        objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                    strCodeForCs.AppendFormat("\r\n" + "List<{0}> lst{1} = lst{1}_Str.Select(x => {0}.Parse(x)).ToList();",
                        objKeyField.CsType,
                        objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                }
                strCodeForCs.AppendFormat("\r\n" + "if (lst{0}  == null)",
                    objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = \"请选择需要置顶的记录!\";");
                strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");

                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");

                if (string.IsNullOrEmpty(objAdjustOrderNum.VarLst) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.GoTop(lst{1});",
                      objViewInfoENEx.TabName,
                      objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.GoTop(lst{2}, {1});",
                         objViewInfoENEx.TabName,
                         objAdjustOrderNum.VarLst,
                         objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"置顶出错。错误:{0}.({1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
                strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "            return RedirectToListAjax(checkedId);");

    //            strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN objInFor in NewModel.{0}Lst)",
    //objViewInfoENEx.TabName_Out);
    //            strCodeForCs.Append("\r\n" + "{");
    //            strCodeForCs.AppendFormat("\r\n" + "if (checkedId.Contains(objInFor.{0}.ToString()) == true) objInFor._Checked = \"checked\";",
    //                objKeyField.FldName, objKeyField.PrivFuncName);
    //            strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_4MvcCtrl_UpMove()
        {
            if (this.objOrderNumField == null) return "";
            StringBuilder strCodeForCs = new StringBuilder();
    
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///上移");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "[HttpPost]");
                strCodeForCs.Append("\r\n" + "[MultipleButton(Name = \"action\", Argument = \"UpMove\")]");
                strCodeForCs.Append("\r\n" + "public ActionResult UpMove(string[] checkedId, int page = 1)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "sePageIndex = page;");
                strCodeForCs.Append("\r\n" + "if (checkedId == null || checkedId.Length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"请选择需要移动的记录!\");");
                strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                strCodeForCs.Append("\r\n" + "PrepareDdlViewData();");
                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} modelErr = new ViewModel4{0}();",
                    objMainPrjTab.TabName);
                if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModelErr = PrepareModel(modelErr, 0);",
                 objMainPrjTab.TabName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModelErr = PrepareModel(modelErr, \"\");",
                    objMainPrjTab.TabName);
                }

                strCodeForCs.AppendFormat("\r\n" + "return View(\"{0}CRUD\", NewModelErr);",
                    objMainPrjTab.TabName);

                strCodeForCs.Append("\r\n" + "}");

                if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = {0}.Parse(checkedId[0]);",
                  objKeyField.CsType, objKeyField.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = checkedId[0];",
       objKeyField.CsType, objKeyField.PrivFuncName);
                }
                strCodeForCs.AppendFormat("\r\n" + "return MoveRecord(\"UP\", {0}, page);",
                                        objKeyField.PrivFuncName);
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        public string Gen_4MvcCtrl_UpMoveAjax()
        {
            if (this.objOrderNumField == null) return "";
            StringBuilder strCodeForCs = new StringBuilder();
      
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///上移");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "[HttpPost]");
                strCodeForCs.Append("\r\n" + "[MultipleButton(Name = \"action\", Argument = \"UpMoveAjax\")]");
                if (string.IsNullOrEmpty(objAdjustOrderNum.VarLst) == true)
                {
                    strCodeForCs.Append("\r\n" + "public virtual PartialViewResult UpMoveAjax(string[] checkedId, int page = 1)");
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "public virtual PartialViewResult UpMoveAjax(string[] checkedId, {0}, int page = 1)",
                        string.Join(",", objAdjustOrderNum.VarDefLst));
                }
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "sePageIndex = page;");
                strCodeForCs.Append("\r\n" + "if (checkedId == null || checkedId.Length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"请选择需要移动的记录!\");");
                strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");

                strCodeForCs.Append("\r\n" + "}");

                if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = {0}.Parse(checkedId[0]);",
                  objKeyField.CsType, objKeyField.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = checkedId[0];",
       objKeyField.CsType, objKeyField.PrivFuncName);
                }
                if (string.IsNullOrEmpty(objAdjustOrderNum.VarLst) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "return MoveRecordAjax(\"UP\", {0}, page);",
                                        objKeyField.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "return MoveRecordAjax(\"UP\", {0}, {1}, page);",
                             objKeyField.PrivFuncName, objAdjustOrderNum.VarLst);
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


        public string Gen_4MvcCtrl_MoveRecord()
        {
            if (this.objOrderNumField == null) return "";
            StringBuilder strCodeForCs = new StringBuilder();
       
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///移动记录,包括上移和下移");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n" + " public ActionResult MoveRecord(string strDirect, {0} {1}, int page)",
                    objKeyField.CsType, objKeyField.PrivFuncName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "sePageIndex = page;");
                strCodeForCs.Append("\r\n" + "if (PreCheck4Order() == false) return  View();");
                if (objAdjustOrderNum.ClassificationFieldValueLst.Count > 0)
                {
                    foreach (string strInFor in objAdjustOrderNum.ClassificationFieldValueLst)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string str{0} = {0}.ToString();",
                    strInFor);
                    }
                }
                    //strCodeForCs.AppendFormat("\r\n" + "{1} {0} = GetFirstCheckedKeyFromGv();",
                    //                    objKeyField.PrivFuncName,
                    //                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
               
                if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "if ({0} == 0)",
                        objKeyField.PrivFuncName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"请选择需要移动({0})的记录!\", strDirect);");
                    strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                    strCodeForCs.Append("\r\n" + "return View();");
                    strCodeForCs.Append("\r\n" + "}");
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true)",
                         objKeyField.PrivFuncName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"请选择需要移动({0})的记录!\", strDirect);");
                    strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                    strCodeForCs.Append("\r\n" + "return View();");
                    strCodeForCs.Append("\r\n" + "}");
                }
                //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                if (string.IsNullOrEmpty(objAdjustOrderNum.VarLst) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.AdjustOrderNum(strDirect, {1});",
                  objViewInfoENEx.TabName,
                  objKeyField.PrivFuncName);
                }
                else
                {
                    string strClassificationFieldLst = "";
                    objAdjustOrderNum.ClassificationFieldValueLst.ForEach(
                        x => strClassificationFieldLst += string.Format("vs{0},", x));                    
                    strClassificationFieldLst = strClassificationFieldLst.TrimEnd(",".ToCharArray());
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.AdjustOrderNum(strDirect, {2}, str{1});",
                     objViewInfoENEx.TabName,
                     strClassificationFieldLst,
                     objKeyField.PrivFuncName);
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"移动({0})记录出错。错误:{1}.({2})\", strDirect, objException.Message, clsStackTrace.GetCurrClassFunction());");
                strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "PrepareDdlViewData();");

                strCodeForCs.Append("\r\n" + "string sortOrder = seSortOrder;");
                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} model = new ViewModel4{0}();",
                    objMainPrjTab.TabName);
                strCodeForCs.AppendFormat("\r\n" + "model.qryModel4{0} = seQryModel4{0};",
                    objViewInfoENEx.TabName_Out);

                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModel = PrepareModel(model, {1}, sortOrder, page);",
                    objMainPrjTab.TabName, IsNumberType4Key ? "0" : "\"\"");
                strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN objInFor in NewModel.{0}Lst)",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "if (objInFor.{0} == {1}) objInFor._Checked = \"checked\";",
                    objKeyField.FldName, objKeyField.PrivFuncName);
                strCodeForCs.Append("\r\n" + "}");
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

        public string Gen_4MvcCtrl_MoveRecordAjax()
        {
            if (this.objOrderNumField == null) return "";
            StringBuilder strCodeForCs = new StringBuilder();
       
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";


                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///移动记录,包括上移和下移");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                if (string.IsNullOrEmpty(objAdjustOrderNum.VarLst) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + " public PartialViewResult MoveRecordAjax(string strDirect, {0} {1}, int page)",
                        objKeyField.CsType, objKeyField.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + " public PartialViewResult MoveRecordAjax(string strDirect, {0} {1}, {2}, int page)",
                        objKeyField.CsType, objKeyField.PrivFuncName, string.Join(",", objAdjustOrderNum.VarDefLst));
                }
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "sePageIndex = page;");
                strCodeForCs.Append("\r\n" + "if (PreCheck4Order() == false) return RedirectToListAjax();");
                if (objAdjustOrderNum.ClassificationFieldValueLst.Count > 0)
                {
                    foreach (string strInFor in objAdjustOrderNum.ClassificationFieldValueLst)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string str{0} = {0}.ToString();",
                            strInFor);
                    }
                }
                //strCodeForCs.AppendFormat("\r\n" + "{1} {0} = GetFirstCheckedKeyFromGv();",
                //                    objKeyField.PrivFuncName,
                //                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);

                if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "if ({0} == 0)",
                        objKeyField.PrivFuncName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"请选择需要移动({0})的记录!\", strDirect);");
                    strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true)",
                         objKeyField.PrivFuncName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"请选择需要移动({0})的记录!\", strDirect);");
                    strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                    strCodeForCs.Append("\r\n" + "            return RedirectToListAjax();");
                    strCodeForCs.Append("\r\n" + "}");
                }
                //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                if (string.IsNullOrEmpty(objAdjustOrderNum.VarLst) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.AdjustOrderNum(strDirect, {1});",
                  objViewInfoENEx.TabName,
                  objKeyField.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.AdjustOrderNum(strDirect, {2}, {1});",
                     objViewInfoENEx.TabName,
                     objAdjustOrderNum.VarLst,
                     objKeyField.PrivFuncName);
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"移动({0})记录出错。错误:{1}.({2})\", strDirect, objException.Message, clsStackTrace.GetCurrClassFunction());");
                strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "PrepareDdlViewData();");

                strCodeForCs.Append("\r\n" + "string sortOrder = seSortOrder;");
                            
                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModel = PrepareListModel(seQryModel4{1}, sortOrder, page);",
                    objMainPrjTab.TabName, objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN objInFor in NewModel.{0}Lst)",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "if (objInFor.{0} == {1}) objInFor._Checked = \"checked\";",
                    objKeyField.FldName, objKeyField.PrivFuncName);
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.AppendFormat("\r\n" + "return PartialView(\"{0}LstAjax\", NewModel);", objViewInfoENEx.TabName);

                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_4MvcCtrl_DownMove()
        {
            if (this.objOrderNumField == null) return "";
            StringBuilder strCodeForCs = new StringBuilder();
     
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///下移");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "[HttpPost]");
                strCodeForCs.Append("\r\n" + "[MultipleButton(Name = \"action\", Argument = \"DownMove\")]");
                strCodeForCs.Append("\r\n" + "public ActionResult DownMove(string[] checkedId, int page = 1)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "sePageIndex = page;");
                strCodeForCs.Append("\r\n" + "if (checkedId == null || checkedId.Length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"请选择需要移动的记录!\");");
                strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                strCodeForCs.Append("\r\n" + "PrepareDdlViewData();");
                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} modelErr = new ViewModel4{0}();",
                    objMainPrjTab.TabName);
                if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModelErr = PrepareModel(modelErr, 0);",
                 objMainPrjTab.TabName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModelErr = PrepareModel(modelErr, \"\");",
                    objMainPrjTab.TabName);
                }

                strCodeForCs.AppendFormat("\r\n" + "return View(\"{0}CRUD\", NewModelErr);",
                    objMainPrjTab.TabName);

                strCodeForCs.Append("\r\n" + "}");

                if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = {0}.Parse(checkedId[0]);",
                  objKeyField.CsType, objKeyField.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = checkedId[0];",
       objKeyField.CsType, objKeyField.PrivFuncName);
                }
                strCodeForCs.AppendFormat("\r\n" + "return MoveRecord(\"DOWN\", {0}, page);",
                    objKeyField.PrivFuncName);
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        public string Gen_4MvcCtrl_DownMoveAjax()
        {
            if (this.objOrderNumField == null) return "";
            StringBuilder strCodeForCs = new StringBuilder();
 
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///下移");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "[HttpPost]");
                strCodeForCs.Append("\r\n" + "[MultipleButton(Name = \"action\", Argument = \"DownMoveAjax\")]");
                if (string.IsNullOrEmpty(objAdjustOrderNum.VarLst) == true)
                {
                    strCodeForCs.Append("\r\n" + "public virtual PartialViewResult DownMoveAjax(string[] checkedId, int page = 1)");
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "public virtual PartialViewResult DownMoveAjax(string[] checkedId, {0}, int page = 1)",
                        string.Join(",", objAdjustOrderNum.VarDefLst));
                }
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "sePageIndex = page;");
                strCodeForCs.Append("\r\n" + "if (checkedId == null || checkedId.Length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"请选择需要移动的记录!\");");
                strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");

                strCodeForCs.Append("\r\n" + "}");

                if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = {0}.Parse(checkedId[0]);",
                  objKeyField.CsType, objKeyField.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = checkedId[0];",
       objKeyField.CsType, objKeyField.PrivFuncName);
                }
                if (string.IsNullOrEmpty(objAdjustOrderNum.VarLst) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "return MoveRecordAjax(\"DOWN\", {0}, page);",
                    objKeyField.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "return MoveRecordAjax(\"DOWN\", {0}, {1}, page);",
                    objKeyField.PrivFuncName, objAdjustOrderNum.VarLst);
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


        public string Gen_4MvcCtrl_PreCheck4Order()
        {
            if (this.objOrderNumField == null) return "";
            StringBuilder strCodeForCs = new StringBuilder();
      
            clsFieldTabEN objFieldTabEN_Classification = null;
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///置底");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "private bool PreCheck4Order()");
                strCodeForCs.Append("\r\n" + "{");
                if (objAdjustOrderNum.ClassificationFieldValueLst.Count > 0)
                {
                    foreach (string strInFor in objAdjustOrderNum.ClassificationFieldValueLst)
                    {
                        if (clsDataTypeAbbrBLEx.IsNumberType(clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objFieldTabEN_Classification.DataTypeId)) == true)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "if ({0} <= 0)",
                                    strInFor);
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true)",
                                strInFor);
                        }
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "string strMsg = \"请输入分类字段{0}!\";", strInFor);
                        strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                        strCodeForCs.Append("\r\n" + "return false;");
                        strCodeForCs.Append("\r\n" + "}");
                    }
                }
                strCodeForCs.Append("\r\n" + "return true;");
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
        /// 生成排序分类字段名属性
        /// </summary>
        /// <returns></returns>
        public string Gen_4MvcCtrl_ClassificationFieldValue()
        {
            if (this.objOrderNumField == null) return "";
            StringBuilder strCodeForCs = new StringBuilder();
   
            clsDataTypeAbbrEN objDataTypeAbbrEN = null;
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);
                if (objAdjustOrderNum == null) return "";
                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";

                if (objAdjustOrderNum.ClassificationFieldValueLst.Count == 0)
                {           
                    return strCodeForCs.ToString();
                }
                foreach (string strInFor in objAdjustOrderNum.ClassificationFieldValueLst)
                {
                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.AppendFormat("\r\n ///置底");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.AppendFormat("\r\n" + "public virtual {0} {1}", objDataTypeAbbrEN.CsType, strInFor);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "get;set;");
                    strCodeForCs.Append("\r\n" + "}");
                }
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_4MvcCtrl_GoBottumAjax()
        {
            if (this.objOrderNumField == null) return "";
            StringBuilder strCodeForCs = new StringBuilder();
         
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///置底");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "[HttpPost]");
                strCodeForCs.Append("\r\n" + "[MultipleButton(Name = \"action\", Argument = \"GoBottumAjax\")]");
                if (string.IsNullOrEmpty(objAdjustOrderNum.VarLst) == true)
                {
                    strCodeForCs.Append("\r\n" + "public virtual PartialViewResult GoBottumAjax(string[] checkedId, int page = 1)");
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "public virtual PartialViewResult GoBottumAjax(string[] checkedId, {0}, int page = 1)",
                        string.Join(",", objAdjustOrderNum.VarDefLst));
                }
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "sePageIndex = page;");
                strCodeForCs.Append("\r\n" + "if (checkedId == null || checkedId.Length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"请选择需要移动的记录!\");");
                strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");

                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "if (PreCheck4Order() == false) return RedirectToListAjax();");
                if (objAdjustOrderNum.ClassificationFieldValueLst.Count > 0)
                {
                    foreach (string strInFor in objAdjustOrderNum.ClassificationFieldValueLst)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string str{0} = {0}.ToString();",
                            strInFor);
                    }
                }
                
                if (objKeyField.CsType == "string")
                {
                    strCodeForCs.AppendFormat("\r\n" + "List<string> lst{0} = new List<string>(checkedId);",
                                        objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "List<string> lst{0}_Str = new List<string>(checkedId);",
                                        objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                    strCodeForCs.AppendFormat("\r\n" + "List<{0}> lst{1} = lst{1}_Str.Select(x => {0}.Parse(x)).ToList();",
                        objKeyField.CsType,
                        objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                }

                strCodeForCs.AppendFormat("\r\n" + "if (lst{0}  == null)",
                    objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = \"请选择需要置底的记录!\";");
                strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                strCodeForCs.Append("\r\n" + "            return RedirectToListAjax(checkedId);");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                if (string.IsNullOrEmpty(objAdjustOrderNum.VarLst) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.GoBottom(lst{1});",
                        objViewInfoENEx.TabName,
                        objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.GoBottom(lst{2}, {1});",
                     objViewInfoENEx.TabName,
                     objAdjustOrderNum.VarLst,
                     objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"置底出错。错误:{0}.({1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
                strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "            return RedirectToListAjax(checkedId);");

                //strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN objInFor in NewModel.{0}Lst)",
                //    objViewInfoENEx.TabName_Out);
                //strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.AppendFormat("\r\n" + "if (checkedId.Contains(objInFor.{0}.ToString()) == true) objInFor._Checked = \"checked\";",
                //    objKeyField.FldName, objKeyField.PrivFuncName);
                //strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_4MvcCtrl_GoBottum()
        {
            if (this.objOrderNumField == null) return "";
            StringBuilder strCodeForCs = new StringBuilder();
     
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///置底");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "[HttpPost]");
                strCodeForCs.Append("\r\n" + "[MultipleButton(Name = \"action\", Argument = \"GoBottum\")]");
                strCodeForCs.Append("\r\n" + "public ActionResult GoBottum(string[] checkedId, int page = 1)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "sePageIndex = page;");
                strCodeForCs.Append("\r\n" + "if (checkedId == null || checkedId.Length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"请选择需要移动的记录!\");");
                strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                strCodeForCs.Append("\r\n" + "PrepareDdlViewData();");
                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} modelErr = new ViewModel4{0}();",
                    objMainPrjTab.TabName);
                if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModelErr = PrepareModel(modelErr, 0);",
                 objMainPrjTab.TabName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModelErr = PrepareModel(modelErr, \"\");",
                    objMainPrjTab.TabName);
                }

                strCodeForCs.AppendFormat("\r\n" + "return View(\"{0}CRUD\", NewModelErr);",
                    objMainPrjTab.TabName);

                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "if (PreCheck4Order() == false) return View();");
                if (objAdjustOrderNum.ClassificationFieldValueLst.Count > 0)
                {
                    foreach (string strInFor in objAdjustOrderNum.ClassificationFieldValueLst)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string str{0} = {0}.ToString();",
                            strInFor);
                    }
                }
                if (objKeyField.CsType == "string")
                {
                    strCodeForCs.AppendFormat("\r\n" + "List<string> lst{0} = new List<string>(checkedId);",
                                        objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "List<string> lst{0}_Str = new List<string>(checkedId);",
                                        objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                    strCodeForCs.AppendFormat("\r\n" + "List<{0}> lst{1} = lst{1}_Str.Select(x => {0}.Parse(x)).ToList();",
                        objKeyField.CsType,
                        objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                }

                strCodeForCs.AppendFormat("\r\n" + "if (lst{0}  == null)",
                    objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = \"请选择需要置底的记录!\";");
                strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                strCodeForCs.Append("\r\n" + "return View();");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                if (string.IsNullOrEmpty(objAdjustOrderNum.VarLst) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.GoBottom(lst{1});",
                        objViewInfoENEx.TabName,
                        objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.GoBottom(lst{2}, {1});",
                     objViewInfoENEx.TabName,
                     objAdjustOrderNum.VarLst,
                     objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"置底出错。错误:{0}.({1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
                strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "PrepareDdlViewData();");

                strCodeForCs.Append("\r\n" + "string sortOrder = seSortOrder;");
                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} model = new ViewModel4{0}();",
                    objMainPrjTab.TabName);
                strCodeForCs.AppendFormat("\r\n" + "model.qryModel4{0} = seQryModel4{0};",
                    objViewInfoENEx.TabName_Out);

                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModel = PrepareModel(model, {1}, sortOrder, page);",
                    objMainPrjTab.TabName, IsNumberType4Key ? "0" : "\"\"");

                strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN objInFor in NewModel.{0}Lst)",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");                
                strCodeForCs.AppendFormat("\r\n" + "if (checkedId.Contains(objInFor.{0}.ToString()) == true) objInFor._Checked = \"checked\";",
                    objKeyField.FldName, objKeyField.PrivFuncName);
                strCodeForCs.Append("\r\n" + "}");

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
        public string Gen_4MvcCtrl_ReOrder()
        {
            if (this.objOrderNumField == null) return "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///重序");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "[HttpPost]");
                strCodeForCs.Append("\r\n" + "[MultipleButton(Name = \"action\", Argument = \"ReOrder\")]");
                strCodeForCs.Append("\r\n" + "public ActionResult ReOrder(string[] checkedId, int page = 1)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "sePageIndex = page;");
                strCodeForCs.Append("\r\n" + "if (PreCheck4Order() == false) return View();");

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                if (string.IsNullOrEmpty(objAdjustOrderNum.VarLst) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.ReOrder();",
                   objViewInfoENEx.TabName);
                }
                else
                {
                    
                        foreach (string strInFor in objAdjustOrderNum.ClassificationFieldValueLst)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "string str{0} = {0}.ToString();",
                                strInFor);
                        }
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.ReOrder({1});",
                   objViewInfoENEx.TabName,
                   objAdjustOrderNum.VarLst);
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"重序出错。错误:{0}.({1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
                strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "}");

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

        public string Gen_4MvcCtrl_ReOrderAjax()
        {
            if (this.objOrderNumField == null) return "";
            StringBuilder strCodeForCs = new StringBuilder();
           
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///重序");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "[HttpPost]");
                strCodeForCs.Append("\r\n" + "[MultipleButton(Name = \"action\", Argument = \"ReOrderAjax\")]");
                if (string.IsNullOrEmpty(objAdjustOrderNum.VarLst) == true)
                {
                    strCodeForCs.Append("\r\n" + "public virtual PartialViewResult ReOrderAjax(string[] checkedId, int page = 1)" );
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "public virtual PartialViewResult ReOrderAjax(string[] checkedId, {0}, int page = 1)",
                        string.Join(",", objAdjustOrderNum.VarDefLst));
                }
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "sePageIndex = page;");
                strCodeForCs.Append("\r\n" + "if (PreCheck4Order() == false) return RedirectToListAjax();");

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                if (string.IsNullOrEmpty(objAdjustOrderNum.VarLst) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.ReOrder();",
                   objViewInfoENEx.TabName);
                }
                else
                {

                    //strCodeForCs.AppendFormat("\r\n" + "string str{0} = {0}.ToString();",
                    //    objAdjustOrderNum.ClassificationFieldValue);

                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.ReOrder({1});",
                   objViewInfoENEx.TabName,
                   objAdjustOrderNum.VarLst);
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"重序出错。错误:{0}.({1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
                strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);"); ;
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "            return RedirectToListAjax();");

                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_4MvcCtrl_AddErrors()
        {

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n ///添加错误信息");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n" + "public void AddErrors(string error)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "ModelState.AddModelError(\"\", error);");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_4MvcCtrl_Command4List()
        {

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n ///列表区域的命令");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n" + "public virtual ActionResult Command4List(string button, string[] checkedId)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//switch(button)");
            strCodeForCs.Append("\r\n" + "//{");
            strCodeForCs.Append("\r\n" + "//    case \"Create\":");
            strCodeForCs.Append("\r\n" + "//    Create();");
            strCodeForCs.Append("\r\n" + "//    break;");
            strCodeForCs.Append("\r\n" + "//}");
            strCodeForCs.Append("\r\n" + "return RedirectToList();");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_4MvcCtrl_Command4Query()
        {

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n ///列表区域的命令");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n" + "public virtual ActionResult Command4Query(string button, string[] checkedId)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//switch(button)");
            strCodeForCs.Append("\r\n" + "//{");
            strCodeForCs.Append("\r\n" + "//    case \"Query\":");
            strCodeForCs.Append("\r\n" + "//    QueryAjax();");
            strCodeForCs.Append("\r\n" + "//    break;");
            strCodeForCs.Append("\r\n" + "//}");
            strCodeForCs.Append("\r\n" + "return RedirectToList();");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }
        public string Gen_4MvcCtrl_Clone()
        {
            StringBuilder strCodeForCs = new StringBuilder();
       
            try
            {

                List<clsPrjTabFldENEx> arrFldSet = clsPrjTabFldBLEx.GetObjExLst(objViewInfoENEx.MainTabId, objViewInfoENEx.PrjId);
                //生成仅有变量;
                //第0步:把控件中下拉框ComboBox转换成ComboBox
              
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///置顶");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "[HttpPost]");
                strCodeForCs.Append("\r\n" + "[MultipleButton(Name = \"action\", Argument = \"Clone\")]");
                strCodeForCs.Append("\r\n" + "public ActionResult Clone(string[] checkedId, int page = 1)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "sePageIndex = page;");
                strCodeForCs.Append("\r\n" + "if (checkedId == null || checkedId.Length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"请选择需要复制的记录!\");");
                strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                strCodeForCs.Append("\r\n" + "PrepareDdlViewData();");
                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} modelErr = new ViewModel4{0}();",
                    objMainPrjTab.TabName);
                if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModelErr = PrepareModel(modelErr, 0);",
                 objMainPrjTab.TabName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModelErr = PrepareModel(modelErr, \"\");",
                    objMainPrjTab.TabName);
                }

                strCodeForCs.AppendFormat("\r\n" + "return View(\"{0}CRUD\", NewModelErr);",
                    objMainPrjTab.TabName);

                strCodeForCs.Append("\r\n" + "}");


                strCodeForCs.AppendFormat("\r\n" + "List<string> lst{0} = new List<string>(checkedId);",
                                    objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);

                strCodeForCs.AppendFormat("\r\n" + "if (lst{0}  == null)",
                    objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = \"请选择需要置顶的记录!\";");
                strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "foreach (string strKey in checkedId)");
                strCodeForCs.Append("\r\n" + "{");
                if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = {0}.Parse(checkedId[0]);",
                  objKeyField.CsType, objKeyField.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = checkedId[0];",
       objKeyField.CsType, objKeyField.PrivFuncName);
                }
                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = cls{0}BL.GetObjBy{1}({2});",
                        objViewInfoENEx.TabName, objKeyField.FldName, objKeyField.PrivFuncName);
                if (objNameField != null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = \"C_\" + obj{0}EN.{1};",
                                        objViewInfoENEx.TabName, objNameField.FldName);
                }
                if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
                {
                    strCodeForCs.Append("\r\n" + "//因为是字符型自增主键,所以在添加时,自动获取主键值。");
       
                    strCodeForCs.AppendFormat("\r\n" + "     obj{0}EN.{1} = cls{0}BL.GetMaxStrId_S();",
                        objMainPrjTab.TabName, objKeyField.FldName);
                }
                else if (objKeyField.PrimaryTypeId == enumPrimaryType.Identity_02)
                {

                }
                else
                {
                    strCodeForCs.Append("\r\n" + "//因为是字符型非自增主键,所以在添加时,自动获取主键值。");

                    strCodeForCs.AppendFormat("\r\n" + "     obj{0}EN.{1} = cls{0}BL.GetMaxStrId_S();",
                        objMainPrjTab.TabName, objKeyField.FldName);
                }

                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.AddNewRecord();",
                    objMainPrjTab.TabName);

                strCodeForCs.Append("\r\n" + "}");


                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"复制记录出错。错误:{0}.({1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
                strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "}");

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

        public string Gen_4MvcCtrl_CloneAjax()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                List<clsPrjTabFldENEx> arrFldSet = clsPrjTabFldBLEx.GetObjExLst(objViewInfoENEx.MainTabId, objViewInfoENEx.PrjId);
                //生成仅有变量;
                //第0步:把控件中下拉框ComboBox转换成ComboBox

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///置顶");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "[HttpPost]");
                strCodeForCs.Append("\r\n" + "[MultipleButton(Name = \"action\", Argument = \"CloneAjax\")]");
                strCodeForCs.Append("\r\n" + "public virtual PartialViewResult CloneAjax(string[] checkedId, int page = 1)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "sePageIndex = page;");
                strCodeForCs.Append("\r\n" + "if (checkedId == null || checkedId.Length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"请选择需要复制的记录!\");");
                strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");

                strCodeForCs.Append("\r\n" + "}");


                strCodeForCs.AppendFormat("\r\n" + "List<string> lst{0} = new List<string>(checkedId);",
                                    objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);

                strCodeForCs.AppendFormat("\r\n" + "if (lst{0}  == null)",
                    objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = \"请选择需要置顶的记录!\";");
                strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");

                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "foreach (string strKey in checkedId)");
                strCodeForCs.Append("\r\n" + "{");
                if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = {0}.Parse(checkedId[0]);",
                  objKeyField.CsType, objKeyField.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = checkedId[0];",
       objKeyField.CsType, objKeyField.PrivFuncName);
                }
                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = cls{0}BL.GetObjBy{1}({2});",
                        objViewInfoENEx.TabName, objKeyField.FldName, objKeyField.PrivFuncName);
                if (objNameField != null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = \"C_\" + obj{0}EN.{1};",
                                            objViewInfoENEx.TabName, objNameField.FldName);
                }
                if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
                {
                    strCodeForCs.Append("\r\n" + "//因为是字符型自增主键,所以在添加时,自动获取主键值。");

                    strCodeForCs.AppendFormat("\r\n" + "     obj{0}EN.{1} = cls{0}BL.GetMaxStrId_S();",
                        objMainPrjTab.TabName, objKeyField.FldName);
                }
                else if (objKeyField.PrimaryTypeId == enumPrimaryType.Identity_02)
                {

                }
                else
                {
                    strCodeForCs.Append("\r\n" + "//因为是字符型非自增主键,所以在添加时,自动获取主键值。");

                    strCodeForCs.AppendFormat("\r\n" + "     obj{0}EN.{1} = cls{0}BL.GetMaxStrId_S();",
                        objMainPrjTab.TabName, objKeyField.FldName);
                }

                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.AddNewRecord();",
                    objMainPrjTab.TabName);

                strCodeForCs.Append("\r\n" + "}");


                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"复制记录出错。错误:{0}.({1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
                strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "            return RedirectToListAjax();");

                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        public string Gen_4MvcCtrl_ExportErr()
        {

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.AppendFormat("\r\n /// 用于显示导出错误", objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n" + "private string ExportErr(string strErrMsg)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strDownLoadStr = string.Format(\" <span>下载错误:{0}</span></a>\", strErrMsg);");
            strCodeForCs.Append("\r\n" + "return strDownLoadStr;");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_4MvcCtrl_ExportExcel()
        {

            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                if (objViewInfoENEx.arrExcelExportRegionFldSet == null || objViewInfoENEx.arrExcelExportRegionFldSet.Count == 0)
                {
                    //					StringBuilder sbMessage = new StringBuilder();
                    //					string strViewName = objViewInfoENEx.ViewName;
                    //					sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有编辑区域,或者编辑区域没有字段。请检查!" , strViewName);
                    //					throw new clsDbObjException(sbMessage.ToString());
                    return "";
                }

                //生成专门用于导出Excel 的相关代码
                strCodeForCs.Append("\r\n /// <summary>");
                
                    strCodeForCs.AppendFormat("\r\n /// 导出Excel。根据查询区组合的查询条件,从[{0}]表中获取记录集,最终导出到Excel", objViewInfoENEx.TabName);
                
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public virtual string ExportExcel(QryModel4{0} model)",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//	1、组合界面条件串；");
                strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = Combine{0}Condition(model);",
                        objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "//	2、根据条件串获取该表满足条件的DataTable；");
                strCodeForCs.Append("\r\n" + "System.Data.DataTable objDT;");
                //				strCodeForCs.Append("\r\n" + "int intColNum = objDT.Columns.Count;");
                strCodeForCs.Append("\r\n" + "List<string> arrCnName = new List<string>();");
                strCodeForCs.Append("\r\n" + "List<string> arrColName = new List<string>();");


                strCodeForCs.AppendFormat("\r\n" + "string strFileName = \"{0}信息导出.xls\";",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "string strFolderName;");
                strCodeForCs.Append("\r\n" + "string strDownLoadFileName;");
                //				strCodeForCs.Append("\r\n" + "for (int i = 0; i<intColNum; i++)");
                //				strCodeForCs.Append("\r\n" + "{");
                //				strCodeForCs.Append("\r\n" + "strCnName[i] = objDT.Columns[i].ColumnName;");
                //				strCodeForCs.Append("\r\n" + "strColName[i] = strCnName[i];");
                //				strCodeForCs.Append("\r\n" + "}");
                List<string> arrColHead = new List<string>();
                foreach (clsExcelExportRegionFldsENEx objExcelExportRegionFldsEx in objViewInfoENEx.arrExcelExportRegionFldSet)
                {
                    string strColHead = objExcelExportRegionFldsEx.ColCaption;
                    if (arrColHead.Contains(strColHead) == false)
                    {
                        arrColHead.Add(strColHead);
                    }
                    else
                    {
                        string strMsg = string.Format("导出Excel时,列头重复!重复列头:[{0}({2})].(In {1})",
                            strColHead, clsStackTrace.GetCurrClassFunction(),
                            objExcelExportRegionFldsEx.ObjFieldTabENEx.FldName);
                        throw new Exception(strMsg);
                    }
                    strCodeForCs.AppendFormat("\r\n" + "arrColName.Add(con{2}.{0}); arrCnName.Add(\"{1}\");",
                    objExcelExportRegionFldsEx.ObjFieldTabENEx.FldName,
                    objExcelExportRegionFldsEx.ColCaption,
                    objViewInfoENEx.TabName_Out);
                }

                strCodeForCs.Append("\r\n" + "strFolderName = clsSysParaEN.TempFileFolder;");
                strCodeForCs.Append("\r\n" + "strDownLoadFileName = strFolderName + strFileName;");
                strCodeForCs.Append("\r\n" + "//初始化需要导出的Excel文件,即复制标准Excel文件作为母版,复制不成功即不能导出");

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "clsPubFun_Mvc.InitExcelFile(strFolderName, strDownLoadFileName);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return ExportErr(string.Format(objException.Message));");
                strCodeForCs.Append("\r\n" + "}");
                //				strCodeForCs.Append("\r\n" + "GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTable(objDT, strColName, strCnName, strDownLoadFileName);");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//	2、根据条件串获取该表满足条件的DataTable；");
                
                    strCodeForCs.AppendFormat("\r\n" + "objDT = cls{0}BL.GetDataTable(strWhereCond);",
                    objViewInfoENEx.TabName_Out);
                
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"获取数据出错,请联系管理员!错误:{0}.({1})\",");
                strCodeForCs.Append("\r\n" + "objException.Message, clsStackTrace.GetCurrClassFunction());");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "  try");
                strCodeForCs.Append("\r\n" + "  {");
                strCodeForCs.Append("\r\n" + "//用户Odbc的方式来导出Excel,在Web服务器不需要安装Excel,目前是Excel2003,如果希望2007,可以换下面一条语句。");
                strCodeForCs.Append("\r\n" + "GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4Odbc(objDT, arrColName, arrCnName, strDownLoadFileName);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + " catch (Exception objException)");
                strCodeForCs.Append("\r\n" + " {");
                strCodeForCs.Append("\r\n" + " try");
                strCodeForCs.Append("\r\n" + " {");
                strCodeForCs.Append("\r\n" + "clsSysParaEN.objErrorLog.WriteDebugLog(objException.Message);");

                strCodeForCs.Append("\r\n" + "GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4OdbcExcel2007(objDT, arrColName, arrCnName, strDownLoadFileName);");

                strCodeForCs.Append("\r\n" + "//GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr(objDT, arrColName, arrCnName, strDownLoadFileName);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException2)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"导出Excel出错,请联系管理员!错误:{0}.({1})\",");
                strCodeForCs.Append("\r\n" + "objException2.Message, clsStackTrace.GetCurrClassFunction());");
                
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "string strFilePath = string.Format(\"~/{0}/{1}\", \"TempFiles\", strFileName);");
                strCodeForCs.AppendFormat("\r\n" + "string strDownLoadStr = string.Format(\"<a href=\\\"/{0}/{{0}}?FileName={{1}}\\\">下载</a>\", \"DownLoadFile\", strFilePath); ",
                    objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "return strDownLoadStr;");
                strCodeForCs.Append("\r\n" + "}");
               
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_4MvcCtrl_ExportExcelAjax()
        {

            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                if (objViewInfoENEx.arrExcelExportRegionFldSet == null || objViewInfoENEx.arrExcelExportRegionFldSet.Count == 0)
                {
                    //					StringBuilder sbMessage = new StringBuilder();
                    //					string strViewName = objViewInfoENEx.ViewName;
                    //					sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有编辑区域,或者编辑区域没有字段。请检查!" , strViewName);
                    //					throw new clsDbObjException(sbMessage.ToString());
                    return "";
                }

                //生成专门用于导出Excel 的相关代码
                strCodeForCs.Append("\r\n /// <summary>");
                
                    strCodeForCs.AppendFormat("\r\n /// 导出Excel。根据查询区组合的查询条件,从[{0}]表中获取记录集,最终导出到Excel", objViewInfoENEx.TabName);
                
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "[HttpPost]");
                strCodeForCs.Append("\r\n" + "[MultipleButton(Name = \"action\", Argument = \"ExportExcelAjax\")]");
                strCodeForCs.AppendFormat("\r\n" + "public virtual FileResult ExportExcelAjax(ViewModel4{0} model)",
                        objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//	1、组合界面条件串；");
                strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = Combine{0}Condition(model.qryModel4{0});",
                        objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "//	2、根据条件串获取该表满足条件的DataTable；");
                strCodeForCs.Append("\r\n" + "System.Data.DataTable objDT;");
                //				strCodeForCs.Append("\r\n" + "int intColNum = objDT.Columns.Count;");
                strCodeForCs.Append("\r\n" + "List<string> arrCnName = new List<string>();");
                strCodeForCs.Append("\r\n" + "List<string> arrColName = new List<string>();");


                strCodeForCs.AppendFormat("\r\n" + "string strFileName = \"{0}信息导出.xls\";",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "string strFolderName;");
                strCodeForCs.Append("\r\n" + "string strDownLoadFileName;");
                //				strCodeForCs.Append("\r\n" + "for (int i = 0; i<intColNum; i++)");
                //				strCodeForCs.Append("\r\n" + "{");
                //				strCodeForCs.Append("\r\n" + "strCnName[i] = objDT.Columns[i].ColumnName;");
                //				strCodeForCs.Append("\r\n" + "strColName[i] = strCnName[i];");
                //				strCodeForCs.Append("\r\n" + "}");
                List<string> arrColHead = new List<string>();
                foreach (clsExcelExportRegionFldsENEx objExcelExportRegionFldsEx in objViewInfoENEx.arrExcelExportRegionFldSet)
                {
                    string strColHead = objExcelExportRegionFldsEx.ColCaption;
                    if (arrColHead.Contains(strColHead) == false)
                    {
                        arrColHead.Add(strColHead);
                    }
                    else
                    {
                        string strMsg = string.Format("导出Excel时,列头重复!重复列头:[{0}({2})].(In {1})",
                            strColHead, clsStackTrace.GetCurrClassFunction(),
                            objExcelExportRegionFldsEx.ObjFieldTabENEx.FldName);
                        throw new Exception(strMsg);
                    }
                    strCodeForCs.AppendFormat("\r\n" + "arrColName.Add(con{2}.{0}); arrCnName.Add(\"{1}\");",
                    objExcelExportRegionFldsEx.ObjFieldTabENEx.FldName,
                    objExcelExportRegionFldsEx.ColCaption,
                    objViewInfoENEx.TabName_Out);
                }

                strCodeForCs.Append("\r\n" + "strFolderName = clsSysParaEN.TempFileFolder;");
                strCodeForCs.Append("\r\n" + "strDownLoadFileName = strFolderName + strFileName;");
                strCodeForCs.Append("\r\n" + "//初始化需要导出的Excel文件,即复制标准Excel文件作为母版,复制不成功即不能导出");
             
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "clsPubFun_Mvc.InitExcelFile(strFolderName, strDownLoadFileName);"); 
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"初始化Excel导出文件时出错!出错信息:{0}.\", objException.Message);");
                strCodeForCs.Append("\r\n" + "TempData[\"message\"] = strMsg;");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");

                //strCodeForCs.Append("\r\n" + "return ExportErr(string.Format(objException.Message));");
                strCodeForCs.Append("\r\n" + "}");
                //				strCodeForCs.Append("\r\n" + "GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTable(objDT, strColName, strCnName, strDownLoadFileName);");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//	2、根据条件串获取该表满足条件的DataTable；");
                
                    strCodeForCs.AppendFormat("\r\n" + "objDT = cls{0}BL.GetDataTable(strWhereCond);",
                    objViewInfoENEx.TabName_Out);
                
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"获取数据出错,请联系管理员!错误:{0}.({1})\",");
                strCodeForCs.Append("\r\n" + "objException.Message, clsStackTrace.GetCurrClassFunction());");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "  try");
                strCodeForCs.Append("\r\n" + "  {");
                strCodeForCs.Append("\r\n" + "//用户Odbc的方式来导出Excel,在Web服务器不需要安装Excel,目前是Excel2003,如果希望2007,可以换下面一条语句。");
                strCodeForCs.Append("\r\n" + "GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4Odbc(objDT, arrColName, arrCnName, strDownLoadFileName);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + " catch (Exception objException)");
                strCodeForCs.Append("\r\n" + " {");
                strCodeForCs.Append("\r\n" + " try");
                strCodeForCs.Append("\r\n" + " {");
                strCodeForCs.Append("\r\n" + "clsSysParaEN.objErrorLog.WriteDebugLog(objException.Message);");

                strCodeForCs.Append("\r\n" + "GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4OdbcExcel2007(objDT, arrColName, arrCnName, strDownLoadFileName);");

                strCodeForCs.Append("\r\n" + "//GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr(objDT, arrColName, arrCnName, strDownLoadFileName);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException2)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"导出Excel出错,请联系管理员!错误:{0}.({1})\",");
                strCodeForCs.Append("\r\n" + "objException2.Message, clsStackTrace.GetCurrClassFunction());");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "const path = Server.MapPath(\"~/TempFiles/\" + strFileName);");
                strCodeForCs.Append("\r\n" + "return File(path, \"application/ms-excel\", strFileName);");

                //strCodeForCs.Append("\r\n" + "string strFilePath = string.Format(\"~/{0}/{1}\", \"TempFiles\", strFileName);");

                //strCodeForCs.AppendFormat("\r\n" + "string strDownLoadStr = string.Format(\"<a href=\\\"/{0}/{{0}}?FileName={{1}}\\\">下载</a>\", \"DownLoadFile\", strFilePath); ",
                //    objViewInfoENEx.TabName);
                //strCodeForCs.Append("\r\n" + "return strDownLoadStr;");

                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        public string Gen_4MvcCtrl_SetFieldValueAjax()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFldsObjLst = objViewInfoENEx.arrFeatureRegionFlds.Where(x => x.FeatureId == "0148");
                foreach (clsFeatureRegionFldsENEx objInFor in arrFeatureRegionFldsObjLst)
                {
                    clsFieldTabEN objFieldTabEN = clsFieldTabBL.GetObjByFldIdCache(objInFor.ReleFldId, objInFor.PrjId());

                    string strFuncName = string.Format("{0}Ajax", objInFor.ButtonName.Substring(3));
                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.AppendFormat("\r\n ///设置字段值");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.Append("\r\n" + "[HttpPost]");
                    strCodeForCs.AppendFormat("\r\n" + "[MultipleButton(Name = \"action\", Argument = \"{0}\")]", strFuncName);
                 
                    string strKeys = "";
                    ArrayList arrKeysLst = new ArrayList();
                    foreach (clsPrjTabFldENEx objPrjTabFldENEx in objViewInfoENEx.arrKeyPrjTabFldSet)
                    {
                        arrKeysLst.Add("\"" + objPrjTabFldENEx.FldName + "\"");
                    }
                    //objViewInfoENEx.arrKeyPrjTabFldSet.Count.objMainPrjTab.
                    strKeys = clsArray.Join(arrKeysLst, ",");
                    //List<string> lstExam1TypeId = GetAllCheckedKeysFromGv();
                    //if (lstExam1TypeId == null) return;

            
                    clsViewFeatureFldsENEx objViewFeatureFlds = null;


                    if (objInFor.ValueGivingModeId == enumValueGivingMode.GivenValue_02)
                    {
                        List<clsViewFeatureFldsENEx> arrViewFeatureFlds = objViewInfoENEx.arrViewFeatureFlds.Where(x =>
                               x.ViewFeatureId == objInFor.ViewFeatureId).ToList();
                        if (arrViewFeatureFlds.Count == 0)
                        {
                            throw new Exception("功能：设置字段值的给值方式是给定值,但缺少相应的界面功能字段,请维护后再生成代码");
                        }
                        objViewFeatureFlds = arrViewFeatureFlds[0];
                        
                            strCodeForCs.AppendFormat("\r\n" + "public virtual PartialViewResult {0}(string[] checkedId, {1} {2})",
                            strFuncName, objViewFeatureFlds.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objViewFeatureFlds.ObjFieldTabENEx.FldName);
                        strCodeForCs.Append("\r\n" + "{");
                        //ASPDropDownListEx objASPDropDownListENEx = clsASPDropDownListBLEx.GetDropDownLst_Asp(objViewFeatureFlds);
                            strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}))",
                                        objViewFeatureFlds.ObjFieldTabENEx.FldName);
                        
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "string strMsg = \"请输入{0}({1})!\";",
                                objViewFeatureFlds.ObjFieldTabENEx.Caption,
                                objViewFeatureFlds.ObjFieldTabENEx.FldName);
                        strCodeForCs.Append("\r\n" + "                TempData[\"message\"] = strMsg;");

                        strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                        strCodeForCs.Append("\r\n" + "}");
      
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "public virtual PartialViewResult {0}(string[] checkedId)",
                                strFuncName);
                        strCodeForCs.Append("\r\n" + "{");
                    }

                    strCodeForCs.Append("\r\n" + "if (checkedId == null)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"没有选择记录,不能设置字段值!\");");
                    strCodeForCs.Append("\r\n" + "            TempData[\"message\"] = string.Format(\"没有选择记录,不能设置字段值!\");");
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");

                    //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");

                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "List<string> arr{0} = new List<string>(checkedId);",
                        FldName4Key);
                    strCodeForCs.Append("\r\n" + "int intRecCount = 0;");
                    strCodeForCs.AppendFormat("\r\n" + "foreach (string {0} in arr{1})",                        
                        objKeyField.PrivFuncName,
                        FldName4Key);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "K_{0}_{1} objKey = {2};",
                        objKeyField.FldName, objViewInfoENEx.TabName, objKeyField.PrivFuncName);
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0} = objKey.GetObj();",
                                            objViewInfoENEx.TabName);
                    if (objInFor.ValueGivingModeId == enumValueGivingMode.GivenValue_02)
                    {
                        if (objViewFeatureFlds == null)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "obj{0}.Set{1}(\"这里不正确,值为空!\");",
                                                      objViewInfoENEx.TabName, objFieldTabEN.FldName);
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "obj{0}.Set{1}({2});",
                                                      objViewInfoENEx.TabName, objFieldTabEN.FldName,
                                                      objViewFeatureFlds.ObjFieldTabENEx.FldName);
                        }
                    }
                    else
                    {
                        clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objFieldTabEN.DataTypeId);
                        if (clsDataTypeAbbrBLEx.IsNumberType(objDataTypeAbbrEN) == true)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "obj{0}.Set{1}({2});",
                                                    objViewInfoENEx.TabName, objFieldTabEN.FldName, objInFor.DefaultValue);

                        }
                        else
                        {
                            if (objDataTypeAbbrEN.CsType == "bool")
                            {
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}.Set{1}(bool.Parse(\"{2}\"));",
                                                        objViewInfoENEx.TabName, objFieldTabEN.FldName, objInFor.DefaultValue);
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}.Set{1}(\"{2}\");",
                                                        objViewInfoENEx.TabName, objFieldTabEN.FldName, objInFor.DefaultValue);
                            }
                        }
                    }
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}.Update();",
                        objViewInfoENEx.TabName,
                        objKeyField.PrivFuncName);
                    strCodeForCs.Append("\r\n" + "      intRecCount += 1;");
                    strCodeForCs.Append("\r\n" + "              }");
                    strCodeForCs.Append("\r\n" + "                if (intRecCount > 0)");
                    strCodeForCs.Append("\r\n" + "                {");
                    strCodeForCs.Append("\r\n" + "                    TempData[\"message\"] = string.Format(\"有[{0}]条记录 已经被设置字段值!\", intRecCount);");
                    strCodeForCs.Append("\r\n" + "                }");
                    strCodeForCs.Append("\r\n" + "                else");
                    strCodeForCs.Append("\r\n" + "                {");
                    strCodeForCs.Append("\r\n" + "                    TempData[\"message\"] = string.Format(\"有[0]条记录被设置字段值!\");");
                    strCodeForCs.Append("\r\n" + "                }");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                        objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, string.Format("{0}_Click", objInFor.ButtonName), string.Format("{0}不成功!", objInFor.Text), "生成代码");

                    strCodeForCs.AppendFormat("\r\n" + "string strMsg = \"(errid:{0})设置字段值({1})不成功!\" + objException.Message;", strErrId, objInFor.Text);
                    strCodeForCs.Append("\r\n" + "                TempData[\"message\"] = strMsg;");
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "            return RedirectToListAjax(checkedId);");

                    strCodeForCs.Append("\r\n" + "}");

                }

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

    }
}
