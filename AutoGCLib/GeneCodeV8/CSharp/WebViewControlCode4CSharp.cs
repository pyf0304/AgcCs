using System;
using System.Text;
using System.IO;
using com.taishsoft.file;

using System.Collections;
using com.taishsoft.common;using com.taishsoft.comm_db_obj;
using com.taishsoft.commexception;
using AGC.Entity;

using AGC.BusinessLogic;

using AGC.BusinessLogicEx;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using AGC.PureClass;
using AGC.PureClassEx;
using AgcCommBase;

namespace AutoGCLib
{
  
    /// <summary>
    /// 自动生成界面控制层的代码类(Control of Mvc)
    /// </summary>
    public class WebViewControlCode4CSharp : clsGeneCodeBase4View
    {
        private string strKeyFldName_ObjName = "";

        
        private string strTabName_Out4ListRegion = "";

        //private string thisCacheClassify4View.VarDef4Fld = "";
        List<string> arrFunctionName4Code = null;
        private bool IsHaveEditRegion = true;
        protected bool mbolIsUseCtl = true;
        protected bool bolIsUseWuc4Gv = true;
        #region 构造函数


        public WebViewControlCode4CSharp()
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            clsErrorIdManageBLEx.arrErrIdLstCache = null;
            if (objViewInfoENEx.objCacheClassifyFld4View != null)
            {
                thisCacheClassify4View.VarDef4Fld = string.Format("vs{0}Cache", objViewInfoENEx.objCacheClassifyFld4View.FldName);
            }
        }
        public WebViewControlCode4CSharp(string strViewId)
      : base(strViewId, "", "")
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            //this.strDataBaseType = clsPubConst.con_MsSql;
            //InitPageSetup();
            clsErrorIdManageBLEx.arrErrIdLstCache = null;
            if (objViewInfoENEx.objCacheClassifyFld4View != null)
            {
                thisCacheClassify4View.VarDef4Fld = string.Format("vs{0}Cache", objViewInfoENEx.objCacheClassifyFld4View.FldName);
            }
        }
        
        public WebViewControlCode4CSharp( string strViewId, string strPrjDataBaseId, string strPrjId)
        : base(strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            if (objViewInfoENEx.objCacheClassifyFld4View != null)
            {
                thisCacheClassify4View.VarDef4Fld = string.Format("vs{0}Cache", objViewInfoENEx.objCacheClassifyFld4View.FldName);
            }
        }
        #endregion

        /// <summary>
        /// 生成<显示列表、编辑区域>
        /// </summary>
        /// <returns></returns>
        private string GenDispListAndEditRegion()
        {

            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放WebForm的代码;
            //			string strTemp; ///临时变量;

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 布局控制函数,显示用于编辑的用户控件,并隐藏数据列表区");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n" + "private void DispEdit{0}Region()",
              objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "divList.Visible = false;",
            objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "tabEdit{0}Region.Visible = true;",
            objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 布局控制函数,显示数据列表区,并隐藏用于编辑的用户控件");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n" + "private void Disp{0}ListRegion()",
              objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "divList.Visible = true;",
            objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "tabEdit{0}Region.Visible = false;",
            objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        private string GetCode4FieldInPutDataToClass(clsEditRegionFldsENEx objEditRegionFldsEx, clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder sbCodeForCs = new StringBuilder();
            if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                  && objEditRegionFldsEx.PrimaryTypeId()== clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }
            if (objEditRegionFldsEx.FldOpTypeId() == "0002")
            {
                sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.Set{1}( {2}1.{3});",
              objViewInfoENEx.TabName, objEditRegionFldsEx.FldName, this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003), objEditRegionFldsEx.FldName);
                sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

                return sbCodeForCs.ToString();
            }
            if (objEditRegionFldsEx.FieldTypeId(objViewInfoENEx.PrjId) == enumFieldType.Log_UpdDate_13)
            {
                sbCodeForCs.AppendFormat("\r\n" + ".Set{1}(clsDateTime.getTodayDateTimeStr(0))//(字段类型:{2},字段长度:{3},是否可空:{3})",
                    objViewInfoENEx.TabName, objEditRegionFldsEx.FldName, 
                    objEditRegionFldsEx.ObjFieldTabENEx.CsType(),
                    objEditRegionFldsEx.ObjFieldTabENEx.FldLength,
                    objEditRegionFldsEx.IsTabNullable()         );
                return sbCodeForCs.ToString();
            }
            if (objEditRegionFldsEx.FieldTypeId(objViewInfoENEx.PrjId) == enumFieldType.Log_UpdUser_14)
            {
                sbCodeForCs.AppendFormat("\r\n" + ".Set{1}(clsCommonSession.UserId)//(字段类型:{2},字段长度:{3},是否可空:{3})",
                    objViewInfoENEx.TabName, objEditRegionFldsEx.FldName,
                    objEditRegionFldsEx.ObjFieldTabENEx.CsType(),
                    objEditRegionFldsEx.ObjFieldTabENEx.FldLength,
                    objEditRegionFldsEx.IsTabNullable());
                return sbCodeForCs.ToString();
            }
            //if (objEditRegionFldsEx.CtlTypeId == enumCtlType.CacheClassifyField_37)
            //{
            //    sbCodeForCs.AppendFormat("\r\n" + ".Set{1}({2})",
            // objViewInfoENEx.TabName, objEditRegionFldsEx.FldName, thisCacheClassify4View.VarDef4Fld);

            //}
            //else
            //{
                sbCodeForCs.AppendFormat("\r\n" + ".Set{1}({2}1.{3})",
                objViewInfoENEx.TabName, objEditRegionFldsEx.FldName, this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003), objEditRegionFldsEx.FldName);
            //}
            sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

            return sbCodeForCs.ToString();
        }
                     
        private string GetCode4FieldInGetDataFromClass(clsEditRegionFldsENEx objEditRegionFldsEx, clsViewInfoENEx objViewInfoENEx)
        {
            
            StringBuilder sbCodeForCs = new StringBuilder();

            if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                  && objEditRegionFldsEx.PrimaryTypeId()== clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }
            if (objEditRegionFldsEx.FldOpTypeId() == "0003") //只写
            {
                sbCodeForCs.AppendFormat("\r\n" + "{0}1.{1} = pobj{2}BL.Get{3}();",
                  this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003), objEditRegionFldsEx.FldName, objViewInfoENEx.TabName, objEditRegionFldsEx.FldName);
                sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

                return sbCodeForCs.ToString();
            }
            else if (objEditRegionFldsEx.FldOpTypeId() == "0002") //只读
            {
                sbCodeForCs.AppendFormat("\r\n" + "{0}1.{1} = pobj{2}EN.{3};",
                  this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003), 
                  objEditRegionFldsEx.FldName, objViewInfoENEx.TabName, objEditRegionFldsEx.FldName, PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");
                sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

                return sbCodeForCs.ToString();
            }
            sbCodeForCs.AppendFormat("\r\n" + "{0}1.{1} = pobj{2}EN.{3};",
                    this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003), 
                    objEditRegionFldsEx.FldName, objViewInfoENEx.TabName, objEditRegionFldsEx.FldName, PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache":"");
            sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

            return sbCodeForCs.ToString();
        }

        //public string GeneCode11(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        //{
        //    switch ((enumViewTypeCodeTab)objViewInfoENEx.ViewTypeCode)
        //    {
        //        case enumViewTypeCodeTab.Table_Insert_1:// "0001":	//单表插入
        //            return GenInsRecControlCode(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
        //        case enumViewTypeCodeTab.Table_Update_2:// "0002":	//单表修改
        //            return GenUpdRecControlCode(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
        //        case enumViewTypeCodeTab.Table_Query_3:// "0003":	//单表查询
        //            return GenQueryRecControlCode(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
        //        //case enumViewTypeCodeTab.Table_QUDI_4:// "0004":	//单表的QUDI
        //        //    return GenQueryUpdDelInsRecControlCodeWithWuc4Gv(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
        //        case enumViewTypeCodeTab.Table_QI_5:// "0005":	//单表的查询插入
        //            return GenQueryInsRecControlCode(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
        //        case enumViewTypeCodeTab.Table_QU_6:// "0006":	//单表的查询修改
        //            return GenQueryUpdRecControlCode(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
        //        case enumViewTypeCodeTab.Table_QD_7:// "0007":	//单表的查询删除
        //            return GenQueryDelRecControlCode(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
        //        case enumViewTypeCodeTab.Table_UI_9:// "0009":	//单表的插入修改
        //            return GenUpdInsRecControlCode(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
        //        case enumViewTypeCodeTab.Table_QUD_18:// "0018":	//单表的查询修改删除
        //            return GenQueryUpdDelRecControlCode(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
        //        case enumViewTypeCodeTab.Table_QD_InvokeUI_ListView_11:// "0019":	//单表的查询删除,调用修改、添加
        //            return GenQueryDel_UpdInsRecControlCode(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
        //        case enumViewTypeCodeTab.Table_List_14:
        //            return GenQueryRecControlCode(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
        //        default:
        //            clsViewTypeCodeTabEN objViewTypeCodeTabEN = clsViewTypeCodeTabBL.GetObjByViewTypeCodeCache(objViewInfoENEx.ViewTypeCode);
        //            string strMsg = string.Format("界面类型：[{0}({1})]在函数:[{2}]中没有被处理,请联系管理员!",
        //                objViewTypeCodeTabEN.ViewTypeName,
        //                objViewInfoENEx.ViewTypeCode,
        //                clsStackTrace.GetCurrClassFunction());
        //            throw new Exception(strMsg);
        //    }
        //    //return "";
        //}
    
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strFuncName = "";
            if (objViewInfoENEx.arrEditRegionFldSet4InUse == null || objViewInfoENEx.arrEditRegionFldSet4InUse.Count == 0)
            {
                IsHaveEditRegion = false;
                //StringBuilder sbMessage = new StringBuilder();
                //string strViewName = objViewInfoENEx.ViewName;
                //sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有编辑区域,或者编辑区域没有字段。请检查!", strViewName);
                //sbMessage.Append("\r\n当前界面的功能:查询(Q)、修改(U)、删除(D)、添加(I)。");
                //throw new clsDbObjException(sbMessage.ToString());
            }


            //var arrPrjTabFldEx = objPrjTabENEx.arrKeyFldSet;
            //var arrKeyFldName = arrPrjTabFldEx.Select(x => x.FldName).ToList();
            //var arrKeyFldName_ObjName = arrKeyFldName.Select(x => string.Format("obj{0}EN.{1}", objPrjTabENEx.TabName, x));
            //strKeyFldName_ObjName = string.Join(",", arrKeyFldName_ObjName);

            strTabName_Out4ListRegion = clsPrjTabBL.GetNameByTabIdCache(objViewInfoENEx.objViewRegion_List.TabId, objViewInfoENEx.PrjId);

            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp; ///临时变量;


            objViewInfoENEx.WebFormName = string.Format("{0}", this.ClsName, PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache":"");
            objViewInfoENEx.WebFormFName = string.Format("{0}{1}.aspx.cs", objViewInfoENEx.FolderName, this.ClsName, PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");
            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;
            objViewInfoENEx.ClsName = objViewInfoENEx.WebFormName;

            strRe_ClsName = objViewInfoENEx.WebFormName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebFormFName);

            
            try
            {
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objViewInfoENEx.CurrUserName, objViewInfoENEx));

                //strCodeForCs.Append("\r\n ///生成查询,修改,删除,添加记录的控制层代码");

                strCodeForCs.Append("\r\n" + GenRefDomainName());    //生成参考域名

                strCodeForCs.AppendFormat("\r\n" + "namespace {0}.Webform", objViewInfoENEx.NameSpace);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0} 的摘要说明。其中Q代表查询,U代表修改", objViewInfoENEx.WebFormName);
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public partial class  {0} : System.Web.UI.Page", objViewInfoENEx.WebFormName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "");
                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst = 
                    clsvFunction4GeneCodeBLEx.GetObjLstByViewInfoEx(objViewInfoENEx);

                //IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                //         clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objViewInfoENEx.FunctionTemplateId,
                //         objViewInfoENEx.LangType, objViewInfoENEx.CodeTypeId, objViewInfoENEx.SqlDsTypeId)
                //                       .OrderBy(x => x.OrderNum);

                //int intCount1 = arrvFunction4GeneCodeObjLst.Count();
                //IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLstByFeature = objViewInfoENEx.arrvFunction4GeneCodeSetByFeatureLst;
                //int intCount2 = arrvFunction4GeneCodeObjLstByFeature.Count();
                //arrvFunction4GeneCodeObjLstByFeature = arrvFunction4GeneCodeObjLstByFeature.Where(x => x.CodeTypeId == objViewInfoENEx.CodeTypeId);
                //int intCount3 = arrvFunction4GeneCodeObjLstByFeature.Count();
                //IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_All = arrvFunction4GeneCodeObjLst.Union(arrvFunction4GeneCodeObjLstByFeature, new VFunction4GeneCodeComparer());

                //int intCount4 = arrvFunction4GeneCodeObjLst_All.Count();

                //arrvFunction4GeneCodeObjLst_All = arrvFunction4GeneCodeObjLst_All.OrderBy(x => x.OrderNum);

                //int intCount5 = arrvFunction4GeneCodeObjLst_All.Count();
                arrFunctionName4Code = arrvFunction4GeneCodeObjLst.Select(x=>x.FuncName4Code).ToList();
                //arrvFunction4GeneCodeObjLst.Distinct((x,y )=> x.FuncId4GC != y.FuncId4GC);
                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    if (strFuncName.Substring(0, 6) == "Print:")
                    {
                        strCodeForCs.Append("\r\n" + "");
                        strCodeForCs.Append("\r\n " + strFuncName.Substring(6));
                        continue;
                    }
                    try
                    {
                        strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                        if (string.IsNullOrEmpty(strTemp) == false)
                        {
                            strCodeForCs.Append("\r\n" + strTemp);
                        }
                    }
                    catch(Exception objException)
                    {
                        throw objException;
                    }
                }


                strCodeForCs.Append("\r\n" + "");
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

        public string Gen_WebView_CS_Page_Load()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 函数功能:页面导入,当页面开始运行时所发生的事件");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <param name = \"sender\"></param>");
                strCodeForCs.Append("\r\n /// <param name = \"e\"></param>");
                strCodeForCs.Append("\r\n" + "protected void Page_Load(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "// 在此处放置用户代码以初始化页面");
                strCodeForCs.Append("\r\n" + "if (!IsPostBack)	///如果本界面是初次被调用,而不是单击按钮事件所调用");
                strCodeForCs.Append("\r\n" + "{");
                if (objViewInfoENEx.objCacheClassifyFld4View != null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0}= \"\";", thisCacheClassify4View.VarDef4Fld);
                }
                    strCodeForCs.Append("\r\n" + "//1、初始化,初始化一些导出Excel要用的变量");
                strCodeForCs.AppendFormat("\r\n" + "vsViewName = \"{0}\";", objViewInfoENEx.ViewCnName);
                strCodeForCs.AppendFormat("\r\n" + "vsTabName = string.Format(\"{{0}}\", cls{0}EN._CurrTabName);",
                            objViewInfoENEx.TabName_Out);

                strCodeForCs.Append("\r\n" + "//2、用户权限管理:处理当前用户在当前界面的权限相关操作");
                strCodeForCs.Append("\r\n" + "AccessUserPotence();");

                //生成Page_Load中的绑定下拉框的代码
                strCodeForCs.Append("\r\n" + "//3、绑定查询区的下拉框");
                strCodeForCs.Append("\r\n" + "BindDdl4QueryRegion();");

                strCodeForCs.Append("\r\n" + GenDdlBind4ViewFeatureInPage_Load());

                if (objViewInfoENEx.objViewRegion_List.AllowSorting() == true)
                {
                    strCodeForCs.Append("\r\n" + "//4、设置列表区的排序字段");
                    strCodeForCs.AppendFormat("\r\n" + "{2}1.SetSortBy(string.Format(\"{{0}} Asc\", con{1}.{0}));",
                        objViewInfoENEx.FirstSortField, objViewInfoENEx.TabName_Out, 
                        this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002), PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache":"");
                }

                strCodeForCs.Append("\r\n" + "//5、显示无条件的表内容在GridView中");
                if (bolIsUseWuc4Gv == true)
                {

                    if (this.IsUseFunc)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}ByFunc();",
                              strTabName_Out4ListRegion);

                    }
                    else if (PrjTabEx_ListRegion.IsUseCache_TS() == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}Cache();",
                            strTabName_Out4ListRegion);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                            strTabName_Out4ListRegion);
                    }
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();", strTabName_Out4ListRegion);
                }
                if (IsHaveEditRegion)
                {

                    //strCodeForCs.Append("\r\n" + "//6、设置表控件中字段控件的ReadOnly属性,");
                    //strCodeForCs.Append("\r\n" + "// 使之只读,因为在修改功能中关键字是不能被修改的。");

                    //if (objKeyField.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    //{
                    //    strCodeForCs.AppendFormat("\r\n" + "{0}1.SetKeyReadOnly(true);", this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003));
                    //}
                    if (arrFunctionName4Code.Contains("DispTabNameListRegion()"))
                    {
                        strCodeForCs.Append("\r\n" + "//6、显示列表区域,隐藏编辑区域,");
                        strCodeForCs.AppendFormat("\r\n" + "Disp{0}ListRegion();", objViewInfoENEx.TabName);
                    }
                }
                strCodeForCs.Append("\r\n" + "//7、设置逻辑层的公共函数,包含：缓存刷新函数");
                strCodeForCs.AppendFormat("\r\n" + "//cls{0}BL.objCommFun4BL = new clsCommFun4BL4{0}();",
                    objViewInfoENEx.TabName);

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }
        public string Gen_WebView_CS_btnQuery_Click()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 函数功能:事件函数,当单击<查询>按钮时所发生的事件");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <param name = \"sender\"></param>");
                strCodeForCs.Append("\r\n /// <param name = \"e\"></param>");
                strCodeForCs.Append("\r\n" + "protected void btnQuery_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//把GridView的当前页索引设置为0,即第1页。");
                strCodeForCs.Append("\r\n" + "//当单击查询时,首先显示的是表记录内容的第一部分内容。");
                if (bolIsUseWuc4Gv == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + " {0}1.vsPageIndex = 1;",
                        this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002), PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");
                    strCodeForCs.AppendFormat("\r\n" + "//把表记录的内容显示在GridView中");
                    if (this.IsUseFunc)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}ByFunc();",
                              strTabName_Out4ListRegion);

                    }
                    else if (PrjTabEx_ListRegion.IsUseCache_TS() == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}Cache();",
                            strTabName_Out4ListRegion);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                            strTabName_Out4ListRegion);
                    }
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "this.gv{0}.pageIndex = 0;", objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "//把表记录的内容显示在GridView中");
                    strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();", objViewInfoENEx.TabName);
                }
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

        public string Gen_WebView_CS_BindDropDownLst4EditRegion()
        {
            clsVarManage objVarManage = new clsVarManage("CSharp");
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成仅有变量;
                //strCodeForCs.Append("\r\n ////*生1成绑定GridView的代码*/");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 函数功能:为编辑区控件绑定下拉框。");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "protected void BindDdl4EditRegion()", objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
        
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "if (vsIsBindDdl4Edit == true) return;");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                if (IsHaveEditRegion)
                {
                    foreach (ASPDropDownListEx objInfor in objViewInfoENEx.arrASPDropDownListObj)
                    {
                        if (string.IsNullOrEmpty(objInfor.TabFeatureId4Ddl) == false)
                        {
                            var objTabFeature = clsTabFeatureBL.GetObjByTabFeatureIdCache(objInfor.TabFeatureId4Ddl, objInfor.PrjId);
                            var arrTabFeatureFlds = clsTabFeatureFldsBLEx.GetObjLstByTabFeatureIdCache(objTabFeature.TabFeatureId, objInfor.PrjId);
                            var arrTabFeatureFlds_Cond = arrTabFeatureFlds.Where(x => x.FieldTypeId == enumFieldType.ConditionField_16).ToList();
                            if (arrTabFeatureFlds_Cond.Count == 0)
                            {
                                objInfor.VarIdCond1 = "";
                                objInfor.VarIdCond2 = "";
                                objInfor.FldIdCond1 = "";
                                objInfor.FldIdCond2 = "";
                            }
                            else if (arrTabFeatureFlds_Cond.Count == 1)
                            {
                                objInfor.VarIdCond2 = "";
                                objInfor.FldIdCond2 = "";
                            }
                        }
                        if (objInfor.RegionTypeId == enumRegionType.QueryRegion_0001) continue;
                        if (objInfor.RegionTypeId == enumRegionType.FeatureRegion_0008) continue;

                        //strCodeForCs.AppendFormat("\r\n" + objInfor.GC_SetBindDdl(objVarManage));

                        if (objInfor.objFieldTabCacheClassify() == null)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "{0}1.SetDdl{1}();",
                                        this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003), objInfor.FldName);
                        }
                        else
                        {
                            var strVariableName = objInfor.objFieldTabCacheClassify().PrivFuncName();
                            if (objVarManage.AddVariable(new clsVariable(strVariableName)) == true)
                            {
                                objVarManage.SetVariableProp(strVariableName, "\"\"", "");
                            }
                            strCodeForCs.AppendFormat("\r\n" + "{0}1.SetDdl{1}({2});",
                                   this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003), objInfor.FldName,
                                   strVariableName);
                        }

                    }

                }
                strCodeForCs.Append("\r\n" + "vsIsBindDdl4Edit = true;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");

                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "BindDdl4EditRegion", "绑定编辑区下拉框出错!", "生成代码");

                strCodeForCs.AppendFormat("\r\n" + "string strMsg = \"(errid:{0})绑定编辑区下拉框出错!\" + objException.Message;", strErrId);

                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WebView_CS_BindDropDownLst4QueryRegion()
        {
            clsVarManage objVarManage = new clsVarManage("CSharp");
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成仅有变量;
                //strCodeForCs.Append("\r\n ////*生1成绑定GridView的代码*/");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 函数功能:为查询区控件绑定下拉框。");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "protected void BindDdl4QueryRegion()", objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
       
                strCodeForCs.Append("\r\n" + "");

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                foreach (ASPDropDownListEx objInfor in objViewInfoENEx.arrASPDropDownListObj)
                {
                    if (objInfor.RegionTypeId == enumRegionType.EditRegion_0003) continue;
                    if (objInfor.RegionTypeId == enumRegionType.FeatureRegion_0008) continue;

                    //strCodeForCs.AppendFormat("\r\n" + objInfor.GC_BindDdl(objVarManage));

                }
               

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");

                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "BindDdl4QueryRegion", "绑定查询区下拉框出错!", "生成代码");

                strCodeForCs.AppendFormat("\r\n" + "string strMsg = \"(errid:{0})绑定查询区下拉框出错!\" + objException.Message;", strErrId);

                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WebView_CS_BindGridView4WucInPage()
        {
            if (this.IsUseFunc == true) return "";
            if (PrjTabEx_ListRegion.IsUseCache_TS() == true)
            {
                return "";
            }
            else
            {
            }

            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成仅有变量;
                //strCodeForCs.Append("\r\n ////*生1成绑定GridView的代码*/");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 函数功能:把查询数据绑定在GridView上。根据界面上查询控件中所设置内容查询表记录,");
                strCodeForCs.Append("\r\n ///			 并显示在GridView中。");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "protected void BindGv_{0}()", strTabName_Out4ListRegion);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//操作步骤:(共5步)");
                strCodeForCs.Append("\r\n" + "//	1、设置Gv控件的某些列不可见;");
                strCodeForCs.Append("\r\n" + "//	2、组合界面条件串；");
                strCodeForCs.Append("\r\n" + "//	3、调用控件中的绑定GridView函数;");
                strCodeForCs.Append("\r\n" + "");

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//	1、设置Gv控件的某些列不可见；");
                strCodeForCs.AppendFormat("\r\n" + "//{0}{2}1.SetGvVisibility(con{1}.UpdDate, false);",
                    this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002),
                    objViewInfoENEx.TabName_Out, PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");
                strCodeForCs.AppendFormat("\r\n" + "//{0}{2}1.SetGvVisibility(con{1}.UpdUser, false);",
                    this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002),
                    objViewInfoENEx.TabName_Out, PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");

                strCodeForCs.Append("\r\n" + "//	2、组合界面条件串；");
                strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = Combine{0}Condition();",
                      objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "//	3、调用控件中的绑定GridView函数；");
                strCodeForCs.AppendFormat("\r\n" + " {1}1.BindGv_{0}(strWhereCond);",
                  strTabName_Out4ListRegion, this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002), PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");


                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "BindGv_{0}", "绑定GridView出错!", "生成代码");

                strCodeForCs.AppendFormat("\r\n" + "string strMsg = \"(errid:{0})绑定GridView出错!\" + objException.Message;", strErrId);

                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WebView_CS_BindGridView4WucInPageCache()
        {
            if (this.IsUseFunc == true) return "";
            if (PrjTabEx_ListRegion.IsUseCache_TS() == true)
            {
             
            }
            else
            {
                return "";
            }
            clsQryRegionFldsENEx objQryRegionFldsENExCacheClassifyFld = objViewInfoENEx.arrQryRegionFldSet.Find(x => x.ObjFieldTabENEx.FldId == objViewInfoENEx.objInRelaTab.CacheClassifyField);

            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成仅有变量;
                //strCodeForCs.Append("\r\n ////*生1成绑定GridView的代码*/");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 函数功能:把查询数据绑定在GridView上。根据界面上查询控件中所设置内容查询表记录,");
                strCodeForCs.Append("\r\n ///			 并显示在GridView中。");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "protected void BindGv_{0}Cache()", strTabName_Out4ListRegion);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//操作步骤:(共5步)");
                strCodeForCs.Append("\r\n" + "//	1、设置Gv控件的某些列不可见;");
                strCodeForCs.Append("\r\n" + "//	2、组合界面条件串；");
                strCodeForCs.Append("\r\n" + "//	3、调用控件中的绑定GridView函数;");
                strCodeForCs.Append("\r\n" + "");
                if (objQryRegionFldsENExCacheClassifyFld != null)
                {
                   
                    if (objQryRegionFldsENExCacheClassifyFld.FldName == objViewInfoENEx.objCacheClassifyFld4View.FldName)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string str{0} = {1};",
                            objQryRegionFldsENExCacheClassifyFld.FldName, thisCacheClassify4View.VarDef4Fld);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string str{0} = \"\";",
                            objQryRegionFldsENExCacheClassifyFld.FldName);
                    }
                    //strCodeForCs.AppendFormat("\r\n" + " {1}1.vs{0} = str{0};",
                    //    objQryRegionFldsENExCacheClassifyFld.FldName, this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002));

                }
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//	1、设置Gv控件的某些列不可见；");
                strCodeForCs.AppendFormat("\r\n" + "//{0}1.SetGvVisibility(con{1}.UpdDate, false);",
                    this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002),
                    objViewInfoENEx.TabName_Out, PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");
                strCodeForCs.AppendFormat("\r\n" + "//{0}1.SetGvVisibility(con{1}.UpdUser, false);",
                    this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002),
                    objViewInfoENEx.TabName_Out, PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");

                strCodeForCs.Append("\r\n" + "//	2、组合界面条件串；");
                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}Cond = Combine{0}ConditionObj();",
                    objViewInfoENEx.TabName_Out);
                if (objQryRegionFldsENExCacheClassifyFld != null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.Set{1}({2}, \"=\");",
                        objViewInfoENEx.TabName_Out,
                        objQryRegionFldsENExCacheClassifyFld.ObjFieldTabENEx.FldName,
                        objQryRegionFldsENExCacheClassifyFld.ObjFieldTabENEx.PrivFuncName);
                }
                    strCodeForCs.Append("\r\n" + "//	3、调用控件中的绑定GridView函数；");
                strCodeForCs.AppendFormat("\r\n" + " {1}1.BindGv_{0}Cache(obj{2}Cond);",
                  objViewInfoENEx.TabName, this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002), objViewInfoENEx.TabName_Out, PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");



                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");


                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "BindGv_{0}Cache", "绑定GridView出错!", "生成代码");

                strCodeForCs.AppendFormat("\r\n" + "string strMsg = \"(errid:{0})绑定GridView出错!\" + objException.Message;", strErrId);

                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WebView_CS_BindGridViewByFunc()
        {
            if (this.IsUseFunc == false) return "";
   
            clsQryRegionFldsENEx objQryRegionFldsENExCacheClassifyFld = objViewInfoENEx.arrQryRegionFldSet.Find(x => x.ObjFieldTabENEx.FldId == objViewInfoENEx.objInRelaTab.CacheClassifyField);

            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成仅有变量;
                //strCodeForCs.Append("\r\n ////*生1成绑定GridView的代码*/");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 函数功能:把查询数据绑定在GridView上。根据界面上查询控件中所设置内容查询表记录,");
                strCodeForCs.Append("\r\n ///			 并显示在GridView中。");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "protected void BindGv_{0}ByFunc()", strTabName_Out4ListRegion);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//操作步骤:(共5步)");
                strCodeForCs.Append("\r\n" + "//	1、设置Gv控件的某些列不可见;");
                strCodeForCs.Append("\r\n" + "//	2、组合界面条件串；");
                strCodeForCs.Append("\r\n" + "//	3、调用控件中的绑定GridView函数;");
                strCodeForCs.Append("\r\n" + "");
                if (objQryRegionFldsENExCacheClassifyFld != null)
                {

                    if (objQryRegionFldsENExCacheClassifyFld.FldName == objViewInfoENEx.objCacheClassifyFld4View.FldName)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string str{0} = {1};",
                            objQryRegionFldsENExCacheClassifyFld.FldName, thisCacheClassify4View.VarDef4Fld);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string str{0} = \"\";",
                            objQryRegionFldsENExCacheClassifyFld.FldName);
                    }
                    //strCodeForCs.AppendFormat("\r\n" + " {1}1.vs{0} = str{0};",
                    //    objQryRegionFldsENExCacheClassifyFld.FldName, this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002));

                }
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//	1、设置Gv控件的某些列不可见；");
                strCodeForCs.AppendFormat("\r\n" + "//{0}1.SetGvVisibility(con{1}.UpdDate, false);",
                    this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002),
                    objViewInfoENEx.TabName_Out, PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");
                strCodeForCs.AppendFormat("\r\n" + "//{0}1.SetGvVisibility(con{1}.UpdUser, false);",
                    this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002),
                    objViewInfoENEx.TabName_Out, PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");

                strCodeForCs.Append("\r\n" + "//	2、组合界面条件串；");
                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}Cond = Combine{0}ConditionObj();",
                    strTabName_Out4ListRegion);
                if (objQryRegionFldsENExCacheClassifyFld != null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.Set{1}({2}, \"=\");",
                        strTabName_Out4ListRegion,
                        objQryRegionFldsENExCacheClassifyFld.ObjFieldTabENEx.FldName,
                        objQryRegionFldsENExCacheClassifyFld.ObjFieldTabENEx.PrivFuncName);
                }
                strCodeForCs.Append("\r\n" + "//	3、调用控件中的绑定GridView函数；");
                strCodeForCs.AppendFormat("\r\n" + " {1}1.BindGv_{0}ByFunc(obj{2}Cond);",
                  strTabName_Out4ListRegion, this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002), strTabName_Out4ListRegion, PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");
                

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");


                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "BindGv_{0}Cache", "绑定GridView出错!", "生成代码");

                strCodeForCs.AppendFormat("\r\n" + "string strMsg = \"(errid:{0})绑定GridView出错!\" + objException.Message;", strErrId);

                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }



        public string Gen_WebView_CS_CombineConditionObj()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                ///生成仅有变量;

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 把所有的查询控件内容组合成一个条件串");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <returns>条件串(strWhereCond)</returns>");
                strCodeForCs.AppendFormat("\r\n" + "protected cls{0}EN Combine{0}ConditionObj()", strTabName_Out4ListRegion);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//使条件串的初值为\"1 = 1\",以便在该串的后面用\"and \"添加其他条件,");
                strCodeForCs.Append("\r\n" + "//例如 1 = 1 && UserName = '张三'");
                strCodeForCs.Append("\r\n" + "string strWhereCond = \" 1 = 1 \";");
                strCodeForCs.Append("\r\n" + "//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。");

                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                    strTabName_Out4ListRegion);


                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    switch (objQryRegionFldsEx.CtlTypeId) //objEditRegionFldsEx.objCtlType.CtlTypeName
                    {
                        case enumCtlType.CheckBox_02:
                            strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Checked == true)",
                                        objQryRegionFldsEx.CtrlId());
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = true;",
                                strTabName_Out4ListRegion,
                                objQryRegionFldsEx.FldName);

                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '1'\", con{1}.{0});",
                                     objQryRegionFldsEx.FldName,
                                     strTabName_Out4ListRegion,
                                     "{", "}");
                            strCodeForCs.Append("\r\n" + "}");

                            strCodeForCs.AppendFormat("\r\n" + "else");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = false;",
                                strTabName_Out4ListRegion,
                                objQryRegionFldsEx.FldName);

                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '0'\", con{1}.{0});",
                                 objQryRegionFldsEx.FldName,
                                     strTabName_Out4ListRegion,
                                    "{", "}");
                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        case enumCtlType.DropDownList_06: ///如果控件是下拉框;
                        case enumCtlType.DropDownList_Bool_18: ///如果控件是下拉框;
                            if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.SelectedIndex == 1)",
                                objQryRegionFldsEx.CtrlId());
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(strTabName_Out4ListRegion);
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = true;",
                             strTabName_Out4ListRegion,
                             objQryRegionFldsEx.FldName);

                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '1'\", con{1}.{0}); ",
                                      objQryRegionFldsEx.FldName,
                                       strTabName_Out4ListRegion,
                                      "{", "}");
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.AppendFormat("\r\n" + "else if (this.{0}.SelectedIndex == 2)",
                                objQryRegionFldsEx.CtrlId());
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(strTabName_Out4ListRegion);
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = false;",
                             strTabName_Out4ListRegion,
                             objQryRegionFldsEx.FldName);

                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '0'\", con{1}.{0});",
                                       objQryRegionFldsEx.FldName,
                                     strTabName_Out4ListRegion,
                                      "{", "}");
                                strCodeForCs.Append("\r\n" + "}");

                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.SelectedValue!= \"\" && this.{1}.SelectedValue!= \"0\")",
                                objQryRegionFldsEx.CtrlId(), objQryRegionFldsEx.CtrlId());
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(strTabName_Out4ListRegion);
                                switch (objQryRegionFldsEx.ObjFieldTabENEx.CsType())
                                {
                                    case "string":

                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}(this.{2}.SelectedValue, \"=\");",
                                             strTabName_Out4ListRegion,
                                            objQryRegionFldsEx.FldName,
                                          objQryRegionFldsEx.CtrlId());

                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '{{1}}'\", con{2}.{0}, this.{1}.SelectedValue);",
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.CtrlId(),
                                        strTabName_Out4ListRegion,
                                        "{", "}");
                                        break;
                                    case "int":

                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}(int.Parse( this.{2}.SelectedValue.ToString()), \"=\");",
                                             strTabName_Out4ListRegion,
                                            objQryRegionFldsEx.FldName,
                                          objQryRegionFldsEx.CtrlId());

                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = {{1}}\", con{2}.{0}, this.{1}.SelectedValue);",
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.CtrlId(),
                                        strTabName_Out4ListRegion,
                                        "{", "}");
                                        break;
                                    default:

                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}(this.{2}.SelectedValue, \"=\");",
                                             strTabName_Out4ListRegion,
                                            objQryRegionFldsEx.FldName,
                                          objQryRegionFldsEx.CtrlId());

                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '{{1}}'\", con{2}.{0}, this.{1}.SelectedValue);",
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.CtrlId(),
                                        strTabName_Out4ListRegion,
                                        "{", "}");
                                        break;
                                }
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            break;

                        case enumCtlType.TextBox_16: ///如果控件类型是文本框;
                        case enumCtlType.TextArea_41: ///如果控件类型是文本框;
                            if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() != "string"
                                && objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02)
                            {
                                objQryRegionFldsEx.QueryOptionId = enumQueryOption.EqualQuery_01;
                            }
                            if ((objQryRegionFldsEx.QueryOptionId == enumQueryOption.Known_00) ||
                            (objQryRegionFldsEx.QueryOptionId == enumQueryOption.EqualQuery_01)) ///相等查询;
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId());
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(strTabName_Out4ListRegion);
                                if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "string")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}(this.{2}.Text.Trim(), \"=\");",
                                    strTabName_Out4ListRegion,
                                   objQryRegionFldsEx.FldName,
                                 objQryRegionFldsEx.CtrlId());
                                }
                                if (objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '{{1}}'\", con{2}.{0}, this.{1}.Text.Trim());",
                                objQryRegionFldsEx.FldName,
                                objQryRegionFldsEx.CtrlId(),
                                strTabName_Out4ListRegion,
                                "{", "}");
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = {{1}}\", con{2}.{0}, this.{1}.Text.Trim());",
                             objQryRegionFldsEx.FldName,
                             objQryRegionFldsEx.CtrlId(),
                             strTabName_Out4ListRegion,
                             "{", "}");
                                }
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02) ///模糊查询;
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId());
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(strTabName_Out4ListRegion);
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}(string.Format(\"{{0}}\", this.{2}.Text.Trim()), \"like\");",
                             strTabName_Out4ListRegion,
                            objQryRegionFldsEx.FldName,
                          objQryRegionFldsEx.CtrlId());
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} like '%{{1}}%'\", con{2}.{0}, this.{1}.Text.Trim());",
                                   objQryRegionFldsEx.FldName,
                                     objQryRegionFldsEx.CtrlId(),
                                     strTabName_Out4ListRegion,
                                     "{", "}");
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.RangeQuery_03)
                            { ///范围查询;
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId());
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(strTabName_Out4ListRegion);
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}(this.{2}.Text.Trim(), \"=\");",
                             strTabName_Out4ListRegion,
                            objQryRegionFldsEx.FldName,
                          objQryRegionFldsEx.CtrlId());
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '{{1}}'\", con{2}.{0}, this.{1}.Text.Trim());",
                                objQryRegionFldsEx.FldName,
                                objQryRegionFldsEx.CtrlId(),
                                strTabName_Out4ListRegion,
                                "{", "}");
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId());
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(strTabName_Out4ListRegion);
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}(this.{2}.Text.Trim(), \"=\");",
                             strTabName_Out4ListRegion,
                            objQryRegionFldsEx.FldName,
                          objQryRegionFldsEx.CtrlId());
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\"And {{0}} = '{{1}}'\", con{2}.{0}, this.{1}.Text.Trim());",
                                     objQryRegionFldsEx.FldName,
                                      objQryRegionFldsEx.CtrlId(),
                                      strTabName_Out4ListRegion,
                                     "{", "}");
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            break;
                        case enumCtlType.HyperLink_07:
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

                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.CheckProperty4Condition();",
                       strTabName_Out4ListRegion);

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch(Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                  objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Combine{0}ConditionObj", "在组合查询条件(Combine{0}ConditionObj)时出错!请联系管理员!", "生成代码");
                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName);

                strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{1})在组合查询条件(Combine{0}ConditionObj)时出错!请联系管理员!\" + objException.Message);",
                   objViewInfoENEx.TabName, strErrId);
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.AppendFormat("\r\n" + "return obj{0}EN;", strTabName_Out4ListRegion);
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

        public string Gen_WebView_CS_CombineCondition()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                ///生成仅有变量;

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 把所有的查询控件内容组合成一个条件串");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <returns>条件串(strWhereCond)</returns>");
                strCodeForCs.AppendFormat("\r\n" + "protected string Combine{0}Condition()", strTabName_Out4ListRegion);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//使条件串的初值为\"1 = 1\",以便在该串的后面用\"and \"添加其他条件,");
                strCodeForCs.Append("\r\n" + "//例如 1 = 1 && UserName = '张三'");
                strCodeForCs.Append("\r\n" + "string strWhereCond = \" 1 = 1 \";");
                strCodeForCs.Append("\r\n" + "//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。");

                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                    strTabName_Out4ListRegion);


                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    switch (objQryRegionFldsEx.CtlTypeId) //objEditRegionFldsEx.objCtlType.CtlTypeName
                    {

                        case enumCtlType.CheckBox_02:
                            strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Checked == true)",
                                        objQryRegionFldsEx.CtrlId());
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = true;",
                                strTabName_Out4ListRegion,
                                objQryRegionFldsEx.FldName);

                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '1'\", con{1}.{0});",
                                     objQryRegionFldsEx.FldName,
                                     strTabName_Out4ListRegion,
                                     "{", "}");
                            strCodeForCs.Append("\r\n" + "}");

                            strCodeForCs.AppendFormat("\r\n" + "else");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = false;",
                                strTabName_Out4ListRegion,
                                objQryRegionFldsEx.FldName);

                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '0'\", con{1}.{0});",
                                 objQryRegionFldsEx.FldName,
                                     strTabName_Out4ListRegion,
                                    "{", "}");
                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        case enumCtlType.DropDownList_06: ///如果控件是下拉框;
                        case enumCtlType.DropDownList_Bool_18: ///如果控件是下拉框;
                            if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.SelectedIndex == 1)",
                                objQryRegionFldsEx.CtrlId());
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(strTabName_Out4ListRegion);
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = true;",
                             strTabName_Out4ListRegion,
                             objQryRegionFldsEx.FldName);

                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '1'\", con{1}.{0}); ",
                                      objQryRegionFldsEx.FldName,
                                       strTabName_Out4ListRegion,
                                      "{", "}");
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.AppendFormat("\r\n" + "else if (this.{0}.SelectedIndex == 2)",
                                objQryRegionFldsEx.CtrlId());
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(strTabName_Out4ListRegion);
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = false;",
                             strTabName_Out4ListRegion,
                             objQryRegionFldsEx.FldName);

                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '0'\", con{1}.{0});",
                                       objQryRegionFldsEx.FldName,
                                     strTabName_Out4ListRegion,
                                      "{", "}");
                                strCodeForCs.Append("\r\n" + "}");

                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.SelectedValue!= \"\" && this.{1}.SelectedValue!= \"0\")",
                                objQryRegionFldsEx.CtrlId(), objQryRegionFldsEx.CtrlId());
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(strTabName_Out4ListRegion);
                                switch (objQryRegionFldsEx.ObjFieldTabENEx.CsType())
                                {
                                    case "string":

                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = this.{2}.SelectedValue;",
                                             strTabName_Out4ListRegion,
                                            objQryRegionFldsEx.FldName,
                                          objQryRegionFldsEx.CtrlId());

                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '{{1}}'\", con{2}.{0}, this.{1}.SelectedValue);",
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.CtrlId(),
                                        strTabName_Out4ListRegion,
                                        "{", "}");
                                        break;
                                    case "int":

                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = int.Parse( this.{2}.SelectedValue.ToString());",
                                             strTabName_Out4ListRegion,
                                            objQryRegionFldsEx.FldName,
                                          objQryRegionFldsEx.CtrlId());

                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = {{1}}\", con{2}.{0}, this.{1}.SelectedValue);",
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.CtrlId(),
                                        strTabName_Out4ListRegion,
                                        "{", "}");
                                        break;
                                    default:

                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = this.{2}.SelectedValue;",
                                             strTabName_Out4ListRegion,
                                            objQryRegionFldsEx.FldName,
                                          objQryRegionFldsEx.CtrlId());

                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '{{1}}'\", con{2}.{0}, this.{1}.SelectedValue);",
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.CtrlId(),
                                        strTabName_Out4ListRegion,
                                        "{", "}");
                                        break;
                                }
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            break;

                        case enumCtlType.TextBox_16: ///如果控件类型是文本框;
                        case enumCtlType.TextArea_41: ///如果控件类型是文本框;
                            if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() != "string"
                                && objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02)
                            {
                                objQryRegionFldsEx.QueryOptionId = enumQueryOption.EqualQuery_01;
                            }
                            if ((objQryRegionFldsEx.QueryOptionId == enumQueryOption.Known_00) ||
                            (objQryRegionFldsEx.QueryOptionId == enumQueryOption.EqualQuery_01)) ///相等查询;
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId());
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(strTabName_Out4ListRegion);
                                if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "string")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = this.{2}.Text.Trim();",
                                    strTabName_Out4ListRegion,
                                   objQryRegionFldsEx.FldName,
                                 objQryRegionFldsEx.CtrlId());
                                }
                                if (objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '{{1}}'\", con{2}.{0}, this.{1}.Text.Trim());",
                                objQryRegionFldsEx.FldName,
                                objQryRegionFldsEx.CtrlId(),
                                strTabName_Out4ListRegion,
                                "{", "}");
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = {{1}}\", con{2}.{0}, this.{1}.Text.Trim());",
                             objQryRegionFldsEx.FldName,
                             objQryRegionFldsEx.CtrlId(),
                             strTabName_Out4ListRegion,
                             "{", "}");
                                }
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02) ///模糊查询;
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId());
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(strTabName_Out4ListRegion);
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = this.{2}.Text.Trim();",
                             strTabName_Out4ListRegion,
                            objQryRegionFldsEx.FldName,
                          objQryRegionFldsEx.CtrlId());
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} like '%{{1}}%'\", con{2}.{0}, this.{1}.Text.Trim());",
                                   objQryRegionFldsEx.FldName,
                                     objQryRegionFldsEx.CtrlId(),
                                     strTabName_Out4ListRegion,
                                     "{", "}");
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.RangeQuery_03)
                            { ///范围查询;
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId());
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(strTabName_Out4ListRegion);
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = this.{2}.Text.Trim();",
                             strTabName_Out4ListRegion,
                            objQryRegionFldsEx.FldName,
                          objQryRegionFldsEx.CtrlId());
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '{{1}}'\", con{2}.{0}, this.{1}.Text.Trim());",
                                objQryRegionFldsEx.FldName,
                                objQryRegionFldsEx.CtrlId(),
                                strTabName_Out4ListRegion,
                                "{", "}");
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId());
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(strTabName_Out4ListRegion);
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = this.{2}.Text.Trim();",
                             strTabName_Out4ListRegion,
                            objQryRegionFldsEx.FldName,
                          objQryRegionFldsEx.CtrlId());
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\"And {{0}} = '{{1}}'\", con{2}.{0}, this.{1}.Text.Trim());",
                                     objQryRegionFldsEx.FldName,
                                      objQryRegionFldsEx.CtrlId(),
                                      strTabName_Out4ListRegion,
                                     "{", "}");
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

                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.CheckProperty4Condition();",
                       strTabName_Out4ListRegion);

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
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }
        public string Gen_WebView_CS_vsPageSize()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成仅有变量;

                //生成登录用户的用户名Session
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 专门用于记录GridView中的每页记录数");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "public int vsPageSize");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strPageSize;");
                strCodeForCs.Append("\r\n" + "strPageSize = (string)ViewState[\"pageSize\"];");
                strCodeForCs.Append("\r\n" + "if (strPageSize == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "strPageSize = \"\";");
                strCodeForCs.Append("\r\n" + "return 15;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return int.Parse(strPageSize);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strPageSize = value.ToString();");
                strCodeForCs.Append("\r\n" + "ViewState.Add(\"pageSize\", strPageSize);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_WebView_CS_vsIsBindDdl4Edit()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {                        
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 专门用于记录当前界面是否绑定编辑区的下拉框");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "public bool vsIsBindDdl4Edit");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strIsBindDdl4Edit;");
                strCodeForCs.Append("\r\n" + "strIsBindDdl4Edit = (string)ViewState[\"IsBindDdl4Edit\"];");
                strCodeForCs.Append("\r\n" + "if (strIsBindDdl4Edit == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return false;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return bool.Parse(strIsBindDdl4Edit);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strIsBindDdl4Edit = value.ToString();");
                strCodeForCs.Append("\r\n" + "ViewState.Add(\"IsBindDdl4Edit\", strIsBindDdl4Edit);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_WebView_CS_btnAddNewRecord_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                strCodeForCs.Append("\r\n ///添加新记录的事件过程,建议在该过程中调用其他函数,不要在其中添加多行代码。");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///添加新记录的事件过程 ");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "protected void btnAddNewRecord_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd)
                {
                    strCodeForCs.AppendFormat("\r\n" + "Add{0}Record();",
                    objViewInfoENEx.TabName);
                }
                else if (objViewInfoENEx.objViewTypeCodeTab.IsHaveExeAdd)
                {
                    strCodeForCs.Append("\r\n" + "clsCommonSession.ParentPage = Page.Request.Url.AbsolutePath;");
                    strCodeForCs.AppendFormat("\r\n" + "Response.Redirect(\"wfm{0}_UI.aspx?OperateType = ADD\");",
                    objViewInfoENEx.TabName);

                }
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

        public string Gen_WebView_CS_btnAddNewRecordWithMaxId_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                strCodeForCs.Append("\r\n ///添加新记录的事件过程,建议在该过程中调用其他函数,不要在其中添加多行代码。");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///添加新记录的事件过程 ");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "protected void btnAddNewRecordWithMaxId_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd)
                {
                    strCodeForCs.AppendFormat("\r\n" + "Add{0}RecordWithMaxId();",
                    objViewInfoENEx.TabName);
                }
                else if (objViewInfoENEx.objViewTypeCodeTab.IsHaveExeAdd)
                {
                    strCodeForCs.Append("\r\n" + "clsCommonSession.ParentPage = Page.Request.Url.AbsolutePath;");
                    strCodeForCs.AppendFormat("\r\n" + "Response.Redirect(\"wfm{0}_UI.aspx?OperateType = ADD\");",
                    objViewInfoENEx.TabName);

                }
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


        public string Gen_WebView_CS_AddNewRecord()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {

                //生成的插入记录准备过程代码for C#
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 为插入记录做准备工作");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "protected void Add{0}Record()",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//1、绑定编辑区的下拉框");
                strCodeForCs.Append("\r\n" + "BindDdl4EditRegion();");

                strCodeForCs.Append("\r\n" + "//2、设置关键字字段可以编辑");
                if (objKeyField.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0}1.SetKeyReadOnly(false);",
                    this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003));
                }
                strCodeForCs.Append("\r\n" + "//3、改变相关编辑按钮的状态");

                strCodeForCs.Append("\r\n" + "btnOKUpd.Text = \"确认添加\";");
                strCodeForCs.AppendFormat("\r\n" + "btnCancel{0}Edit.Text = \"取消添加\";",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "//4、设置添加时编辑区域控件的初值");

                //获取最大值
                if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0}1.{2} = cls{1}BL.GetMaxStrId_S();",
                        this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003), objViewInfoENEx.TabName, objKeyField.ObjFieldTabENEx.FldName, objKeyField.ObjFieldTabENEx.FldLength);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "//{2}1.{1} = cls{0}BL.GetMaxStrId_S();",
                            objViewInfoENEx.TabName, objKeyField.ObjFieldTabENEx.FldName,
                            this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003));
                }
                clsEditRegionFldsENEx objEditField_OrderNum = objViewInfoENEx.arrEditRegionFldSet4InUse.Find(x => x.FieldTypeId(objViewInfoENEx.PrjId) == enumFieldType.OrderNumField_09);
                clsEditRegionFldsENEx objEditField_Classify = objViewInfoENEx.arrEditRegionFldSet4InUse.Find(x => x.FieldTypeId(objViewInfoENEx.PrjId) == enumFieldType.ClassificationField_10);
if (objEditField_OrderNum != null)
                {
                    if (objEditField_Classify == null)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "{2}1.{1} = cls{0}BL.GetRecCount() + 1;", 
                            objViewInfoENEx.TabName, 
                            objEditField_OrderNum.FldName,
                            this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003));
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string {0} = \"\";",
                            objEditField_Classify.ObjFieldTabENEx.PrivFuncName);
                        strCodeForCs.AppendFormat("\r\n" + "string strCondition = string.Format(\"{{0}}='{{1}}'\", con{0}.{1}, {2});",
                             objViewInfoENEx.TabName, objEditField_Classify.FldName, objEditField_Classify.ObjFieldTabENEx.PrivFuncName);
                        //wucReferFilesB1.OrderNum = clsReferFilesBL.GetRecCountByCond(strCondition) + 1;
                        strCodeForCs.AppendFormat("\r\n" + "{2}1.{1} = cls{0}BL.GetRecCountByCond(strCondition) + 1;",
                            objViewInfoENEx.TabName,
                            objEditField_OrderNum.FldName,
                            this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003));
                    }
                }
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveQuery == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "DispEdit{0}Region();",
                            objViewInfoENEx.TabName);
                }
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

        public string Gen_WebView_CS_AddNewRecordWithMaxId()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {

                //生成的插入记录准备过程代码for C#
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 为插入记录做准备工作");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "protected void Add{0}RecordWithMaxId()",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//1、绑定编辑区的下拉框");
                strCodeForCs.Append("\r\n" + "BindDdl4EditRegion();");

                strCodeForCs.Append("\r\n" + "//2、设置关键字字段可以编辑");
                if (objKeyField.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0}1.SetKeyReadOnly(false);",
                    this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003));
                }
                strCodeForCs.Append("\r\n" + "//3、改变相关编辑按钮的状态");

                strCodeForCs.Append("\r\n" + "btnOKUpd.Text = \"确认添加\";");
                strCodeForCs.Append("\r\n" + "btnOKUpd.CommandArgument = \"AddWithMaxId\";");
                strCodeForCs.AppendFormat("\r\n" + "btnCancel{0}Edit.Text = \"取消添加\";",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "//4、设置添加时编辑区域控件的初值");

                //获取最大值
                //if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
                //{
                //    strCodeForCs.AppendFormat("\r\n" + "{0}1.{2} = cls{1}BL.GetMaxStrId_S();",
                //        this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003), objViewInfoENEx.TabName, objKeyField.ObjFieldTabENEx.FldName, objKeyField.ObjFieldTabENEx.FldLength);
                //}
                //else
                //{
                //    strCodeForCs.AppendFormat("\r\n" + "//{2}1.{1} = cls{0}BL.GetMaxStrId_S();",
                //            objViewInfoENEx.TabName, objKeyField.ObjFieldTabENEx.FldName,
                //            this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003));
                //}
                clsEditRegionFldsENEx objEditField_OrderNum = objViewInfoENEx.arrEditRegionFldSet4InUse.Find(x => x.FieldTypeId(objViewInfoENEx.PrjId) == enumFieldType.OrderNumField_09);
                clsEditRegionFldsENEx objEditField_Classify = objViewInfoENEx.arrEditRegionFldSet4InUse.Find(x => x.FieldTypeId(objViewInfoENEx.PrjId) == enumFieldType.ClassificationField_10);
                if (objEditField_OrderNum != null)
                {
                    if (objEditField_Classify == null)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "{2}1.{1} = cls{0}BL.GetRecCount() + 1;",
                            objViewInfoENEx.TabName,
                            objEditField_OrderNum.FldName,
                            this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003));
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string {0} = \"\";",
                            objEditField_Classify.ObjFieldTabENEx.PrivFuncName);
                        strCodeForCs.AppendFormat("\r\n" + "string strCondition = string.Format(\"{{0}}='{{1}}'\", con{0}.{1}, {2});",
                             objViewInfoENEx.TabName, objEditField_Classify.FldName, objEditField_Classify.ObjFieldTabENEx.PrivFuncName);
                        //wucReferFilesB1.OrderNum = clsReferFilesBL.GetRecCountByCond(strCondition) + 1;
                        strCodeForCs.AppendFormat("\r\n" + "{2}1.{1} = cls{0}BL.GetRecCountByCond(strCondition) + 1;",
                            objViewInfoENEx.TabName,
                            objEditField_OrderNum.FldName,
                            this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003));
                    }
                }
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveQuery == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "DispEdit{0}Region();",
                            objViewInfoENEx.TabName);
                }
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


       
        public string Gen_WebView_CS_AddNewRecordWithMaxIdSave()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                //插入记录存盘过程代码for C#
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 插入记录存盘到数据表中");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <returns>插入记录是否成功？</returns>");

                strCodeForCs.AppendFormat("\r\n" + "protected bool Add{0}RecordWithMaxIdSave()",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//操作步骤:");
                strCodeForCs.Append("\r\n" + "//1、检查控件中输入数据类型是否正确");
                strCodeForCs.Append("\r\n" + "//2、定义对象并初始化对象");
                strCodeForCs.Append("\r\n" + "//3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在");
                strCodeForCs.Append("\r\n" + "//3.2、检查唯一性");
                strCodeForCs.Append("\r\n" + "//4、把值从界面层传到逻辑层或数据实体层");
                strCodeForCs.Append("\r\n" + "//5、检查传进去的对象属性是否合法");
                strCodeForCs.Append("\r\n" + "//6、把数据实体层的数据存贮到数据库中");
                strCodeForCs.Append("\r\n" + "//7、把新添的记录内容显示在GridView中");
                strCodeForCs.Append("\r\n" + "string strMsg;	//专门用于传递信息的变量");
                strCodeForCs.Append("\r\n" + "string strResult = \" \";	//用于传递在检验对象属性时结果值的变量");
                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{1}EN;",
                objViewInfoENEx.TabName, objViewInfoENEx.TabName);

                strCodeForCs.Append("\r\n" + "//1、检查控件中输入数据类型是否正确");
                strCodeForCs.AppendFormat("\r\n" + "if (!{0}1.IsValid(ref strResult))",
                        this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003));
                strCodeForCs.Append("\r\n" + "{");
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
             objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Add{0}RecordWithMaxIdSave", "控件中输入数据类型不正确请检查!", "生成代码");

                strCodeForCs.AppendFormat("\r\n" + "lblMsg_Edit.Text = \"(errid:{0})控件中输入数据类型不正确请检查!\";", strErrId);
                strCodeForCs.Append("\r\n" + "return false;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "//2、定义对象并初始化对象");
                strCodeForCs.AppendFormat("\r\n" + "//cls{0}EN obj{1}EN;	//定义对象", objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                if (objKeyField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = new cls{1}EN();	//初始化新对象",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                }
                else
                {
                    //string strKeyFldNameLstStrWithAddStr = KeyFldNameLstStrWithAddStr(string.Format("{0}1.", this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003)), objViewInfoENEx);
                    //strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = new cls{1}EN({2});	//初始化新对象",
                    //objViewInfoENEx.TabName, objViewInfoENEx.TabName, strKeyFldNameLstStrWithAddStr);
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = new cls{1}EN();	//初始化新对象",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                }
                strCodeForCs.Append("\r\n" + "");


                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//4、把值从界面层传到逻辑层或数据实体层");
                strCodeForCs.AppendFormat("\r\n" + "PutDataTo{0}Class(obj{1}EN);		//把界面的值传到", objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch(Exception objException)");
                strCodeForCs.Append("\r\n" + "{");

                strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Add{0}RecordWithMaxIdSave", "为对象赋值不成功!", "生成代码");

                strCodeForCs.AppendFormat("\r\n" + "strMsg = \"(errid:{0})为对象赋值不成功!\" + objException.Message;", strErrId);
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "lblMsg_Edit.Text = strMsg;");
                strCodeForCs.Append("\r\n" + "return false;");

                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n //5、使用扩展添加方法,到逻辑层去添加");
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.AddRecordEx();", objViewInfoENEx.TabName);

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch(Exception objException)");
                strCodeForCs.Append("\r\n" + "{");

                strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Add{0}RecordWithMaxIdSave", "添加记录不成功!", "生成代码");

                strCodeForCs.AppendFormat("\r\n" + "strMsg = \"(errid:{0})添加记录不成功!\" + objException.Message;", strErrId);
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "lblMsg_Edit.Text = strMsg;");
                strCodeForCs.Append("\r\n" + "return false;");

                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "strMsg = \"添加记录成功!\";");
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "lblMsg_Edit.Text = \"添加记录成功!\";");
                //如果有查询区域
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveQuery)
                {
                    strCodeForCs.Append("\r\n" + "//7、把新添的记录内容显示在GridView中");
                    if (bolIsUseWuc4Gv == true)
                    {
                        if (this.IsUseFunc)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}ByFunc();",
                                  strTabName_Out4ListRegion);

                        }
                        else if (PrjTabEx_ListRegion.IsUseCache_TS() == true)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}Cache();",
                                strTabName_Out4ListRegion);
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                                strTabName_Out4ListRegion);
                        }
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();", strTabName_Out4ListRegion);
                    }
                    strCodeForCs.AppendFormat("\r\n" + "Disp{0}ListRegion();", objViewInfoENEx.TabName);
                }
                strCodeForCs.AppendFormat("\r\n" + "{0}1.Clear();		//清空控件中内容",
                        this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003));
                strCodeForCs.Append("\r\n ///恢复<确认添加>变成<添加>");
                strCodeForCs.Append("\r\n" + "btnOKUpd.Text = \"添加\";");
                strCodeForCs.AppendFormat("\r\n" + "btnCancel{0}Edit.Text = \"取消编辑\";",
                objViewInfoENEx.TabName);

                strCodeForCs.Append("\r\n" + "return true;");

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


       
        public string Gen_WebView_CS_btnUpdateRecord_Click()
        {
            string strFuncName = "";
            if (objViewInfoENEx.arrKeyPrjTabFldSet.Count == 1)
            {
                return GenbtnUpdateRecord_Click4OneKeyword();
            }
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n ///修改当前被选记录");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");



                if (objViewInfoENEx.objViewRegion_List.IsCheck() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnUpdateRecord_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");

                    strCodeForCs.AppendFormat("\r\n" + "List<string> lstKeyValue = clsCommForWebForm.GetFirstCheckedItemFromGv(gv{1},{0});",
                    clsViewInfoBLEx.KeyFldNameLstStrWithQuote(objViewInfoENEx), objViewInfoENEx.TabName);


                    strCodeForCs.Append("\r\n" + "if (lstKeyValue.Count == 0) ");
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                       objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnUpdateRecord_Click", "没有选择记录,请选择一个有效的表记录!", "生成代码");

                    strCodeForCs.AppendFormat("\r\n" + "lblMsg_List.Text = \"(errid:{0})没有选择记录,请选择一个有效的表记录!\";", strErrId);

                    //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"没有选择记录,请选择一个有效的表记录!\";");
                    strCodeForCs.Append("\r\n" + "return ;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");
                    strCodeForCs.Append("\r\n" + "//1、显示该关键字的数据让用户修改该关键字记录；");
                    int intKeyIndex = 0;
                    strCodeForCs.Append("\r\n" + "string[] strKeys = lstKeyValue[0].Split(',');");

                    foreach (clsPrjTabFldENEx objKeyPrjTabFld in objViewInfoENEx.arrKeyPrjTabFldSet)
                    {
                        switch (objKeyPrjTabFld.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                        {
                            case "string":
                                strCodeForCs.AppendFormat("\r\n" + "{0} = strKeys[{1}];",
                                objKeyPrjTabFld.KeyVarDefineStr, intKeyIndex);
                                break;
                            case "int":
                            case "long":
                                strCodeForCs.AppendFormat("\r\n" + "{0} = {2}.Parse(strKeys[{1}]);",
                                objKeyPrjTabFld.KeyVarDefineStr, intKeyIndex, objKeyPrjTabFld.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                                break;
                        }
                        intKeyIndex++;
                    }
                    if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "Update{0}Record({1});",
                        objViewInfoENEx.TabName,
                       objViewInfoENEx.KeyPrivFuncFldNameLstStr);
                    }
                    else if (objViewInfoENEx.objViewTypeCodeTab.IsHaveExeUpdate)
                    {
                        //strStd1Id = "";
                        strCodeForCs.Append("\r\n" + "clsCommonSession.ParentPage = Page.Request.Url.AbsolutePath;");
                        strCodeForCs.AppendFormat("\r\n" + "Response.Redirect(\"wfm{0}_UI.aspx?OperateType = UPDATE&{1} = \" + {2});",
                        objViewInfoENEx.TabName,
                        objKeyField.ObjFieldTabENEx.FldName,
                        objKeyField.PrivFuncName);
                    }

                    strCodeForCs.Append("\r\n" + "}");
                }
                else if (objViewInfoENEx.objViewRegion_List.IsRadio() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnUpdateRecord_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string str{0} = (string) rd.Value;",
                    objKeyField.ObjFieldTabENEx.FldName);
                    switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                    {
                        case "string":
                            //							strCodeForCs.AppendFormat("\r\n" + "{0} = e.Item.Cells[{1}].Text;", 
                            //								objViewInfoENEx. objMainTabKeyField.ObjFieldTabENEx.PrivFuncName, intItemNum);
                            break;
                        case "int":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = int.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                        case "long":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = long.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                    }

                    strCodeForCs.AppendFormat("\r\n" + "if (str{0} == null || str{0}.Trim().Length == 0) ",
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                        objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnUpdateRecord_Click", "没有选择记录,请选择一个有效的表记录!", "生成代码");

                    strCodeForCs.AppendFormat("\r\n" + "lblMsg.Text = \"(errid:{0})没有选择记录,请选择一个有效的表记录!\";", strErrId);

                    //strCodeForCs.Append("\r\n" + "lblMsg.Text = \"没有选择记录,请选择一个有效的表记录!\";");
                    strCodeForCs.Append("\r\n" + "return ;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "lblMsg.Text = \"\";");
                    strCodeForCs.Append("\r\n" + "//1、显示该关键字记录的内容在界面上；");
                    if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "ShowData({0});",
                        objKeyField.PrivFuncName);
                        //					strCodeForCs.AppendFormat("\r\n" + "ShowData(str{0});",
                        //						objViewInfoENEx. objMainTabKeyField.ObjFieldTabENEx.FldName);
                        strCodeForCs.Append("\r\n" + "//2、清空提示信息的内容,同时使<确定修改>按钮可用；");
                        strCodeForCs.Append("\r\n" + "btnOKUpd.Enabled = true;");
                        if (objKeyField.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "{0}1.SetKeyReadOnly(true);",
                                    this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003));
                        }
                        strCodeForCs.Append("\r\n" + "btnOKUpd.Text = \"确认修改\";	");
                        strCodeForCs.Append("\r\n" + "}");
                    }
                    else if (objViewInfoENEx.objViewTypeCodeTab.IsHaveExeUpdate)
                    {
                        //strStd1Id = "";
                        strCodeForCs.Append("\r\n" + "clsCommonSession.ParentPage = Page.Request.Url.AbsolutePath;");
                        strCodeForCs.AppendFormat("\r\n" + "Response.Redirect(\"wfm{0}_UI.aspx?OperateType = UPDATE&{1} = \" + {2});",
                        objViewInfoENEx.TabName,
                        objKeyField.ObjFieldTabENEx.FldName,
                        objKeyField.PrivFuncName);
                        //Update{TabName}Record(strStd1Id);
                    }
                }
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WebView_CS_btnCopyRecord_Click()
        {
            string strFuncName = "";
            if (objViewInfoENEx.arrKeyPrjTabFldSet.Count == 1)
            {
                return GenbtnCopyRecord_Click4OneKeyword();
            }
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n ///复制当前被选记录");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");



                if (objViewInfoENEx.objViewRegion_List.IsCheck() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnCopyRecord_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");

                    strCodeForCs.AppendFormat("\r\n" + "List<string> lstKeyValue = clsCommForWebForm.GetFirstCheckedItemFromGv(gv{1},{0});",
                    clsViewInfoBLEx.KeyFldNameLstStrWithQuote(objViewInfoENEx), objViewInfoENEx.TabName);


                    strCodeForCs.Append("\r\n" + "if (lstKeyValue.Count == 0) ");
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                       objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnCopyRecord_Click", "没有选择记录,请选择一个有效的表记录!", "生成代码");

                    strCodeForCs.AppendFormat("\r\n" + "lblMsg_List.Text = \"(errid:{0})没有选择记录,请选择一个有效的表记录!\";", strErrId);

                    //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"没有选择记录,请选择一个有效的表记录!\";");
                    strCodeForCs.Append("\r\n" + "return ;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");
                    strCodeForCs.Append("\r\n" + "//1、显示该关键字的数据让用户修改该关键字记录；");
                    int intKeyIndex = 0;
                    strCodeForCs.Append("\r\n" + "string[] strKeys = lstKeyValue[0].Split(',');");

                    foreach (clsPrjTabFldENEx objKeyPrjTabFld in objViewInfoENEx.arrKeyPrjTabFldSet)
                    {
                        switch (objKeyPrjTabFld.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                        {
                            case "string":
                                strCodeForCs.AppendFormat("\r\n" + "{0} = strKeys[{1}];",
                                objKeyPrjTabFld.KeyVarDefineStr, intKeyIndex);
                                break;
                            case "int":
                            case "long":
                                strCodeForCs.AppendFormat("\r\n" + "{0} = {2}.Parse(strKeys[{1}]);",
                                objKeyPrjTabFld.KeyVarDefineStr, intKeyIndex, objKeyPrjTabFld.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                                break;
                        }
                        intKeyIndex++;
                    }
                    if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "CopyRecord({1});",
                        objViewInfoENEx.TabName,
                       objViewInfoENEx.KeyPrivFuncFldNameLstStr);
                    }
                    else if (objViewInfoENEx.objViewTypeCodeTab.IsHaveExeUpdate)
                    {
                        //strStd1Id = "";
                        strCodeForCs.Append("\r\n" + "clsCommonSession.ParentPage = Page.Request.Url.AbsolutePath;");
                        strCodeForCs.AppendFormat("\r\n" + "Response.Redirect(\"wfm{0}_UI.aspx?OperateType = UPDATE&{1} = \" + {2});",
                        objViewInfoENEx.TabName,
                        objKeyField.ObjFieldTabENEx.FldName,
                        objKeyField.PrivFuncName);
                    }

                    strCodeForCs.Append("\r\n" + "}");
                }
                else if (objViewInfoENEx.objViewRegion_List.IsRadio() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnCopyRecord_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string str{0} = (string) rd.Value;",
                    objKeyField.ObjFieldTabENEx.FldName);
                    switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                    {
                        case "string":
                            //							strCodeForCs.AppendFormat("\r\n" + "{0} = e.Item.Cells[{1}].Text;", 
                            //								objViewInfoENEx. objMainTabKeyField.ObjFieldTabENEx.PrivFuncName, intItemNum);
                            break;
                        case "int":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = int.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                        case "long":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = long.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                    }

                    strCodeForCs.AppendFormat("\r\n" + "if (str{0} == null || str{0}.Trim().Length == 0) ",
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                        objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnCopyRecord_Click", "没有选择记录,请选择一个有效的表记录!", "生成代码");

                    strCodeForCs.AppendFormat("\r\n" + "lblMsg.Text = \"(errid:{0})没有选择记录,请选择一个有效的表记录!\";", strErrId);

                    //strCodeForCs.Append("\r\n" + "lblMsg.Text = \"没有选择记录,请选择一个有效的表记录!\";");
                    strCodeForCs.Append("\r\n" + "return ;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "lblMsg.Text = \"\";");
                    strCodeForCs.Append("\r\n" + "//1、显示该关键字记录的内容在界面上；");
                    if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "ShowData({0});",
                        objKeyField.PrivFuncName);
                        //					strCodeForCs.AppendFormat("\r\n" + "ShowData(str{0});",
                        //						objViewInfoENEx. objMainTabKeyField.ObjFieldTabENEx.FldName);
                        strCodeForCs.Append("\r\n" + "//2、清空提示信息的内容,同时使<确定修改>按钮可用；");
                        strCodeForCs.Append("\r\n" + "btnOKUpd.Enabled = true;");
                        if (objKeyField.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "{0}1.SetKeyReadOnly(true);",
                                    this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003));
                        }
                        strCodeForCs.Append("\r\n" + "btnOKUpd.Text = \"确认修改\";	");
                        strCodeForCs.Append("\r\n" + "}");
                    }
                    else if (objViewInfoENEx.objViewTypeCodeTab.IsHaveExeUpdate)
                    {
                        //strStd1Id = "";
                        strCodeForCs.Append("\r\n" + "clsCommonSession.ParentPage = Page.Request.Url.AbsolutePath;");
                        strCodeForCs.AppendFormat("\r\n" + "Response.Redirect(\"wfm{0}_UI.aspx?OperateType = UPDATE&{1} = \" + {2});",
                        objViewInfoENEx.TabName,
                        objKeyField.ObjFieldTabENEx.FldName,
                        objKeyField.PrivFuncName);
                        //Update{TabName}Record(strStd1Id);
                    }
                }
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WebView_CS_Code4QueryRegion()
        {
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp = "";
            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                     clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(enumFunctionTemplate.RegionFunctionDetailSet_0005,
                     objViewInfoENEx.CodeTypeId,
                            enumRegionType.QueryRegion_0001)
                                   .OrderBy(x => x.OrderNum);
            foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
            {
                string  strFuncName = objvFunction4GeneCodeEN.FuncName;
                if (strFuncName.Substring(0, 6) == "Print:")
                {
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.Append("\r\n " + strFuncName.Substring(6));
                    continue;
                }
                try
                {
                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append(strTemp);
                    }
                }
                catch (Exception objException)
                {
                    throw objException;
                }
            }
            
            strCodeForCs.Append("\r\n" + "");
            return strCodeForCs.ToString();
        }

        public string Gen_WebView_CS_Code4FeatureRegion()
        {
            string strTemp = "";
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                       clsvFunction4GeneCodeBLEx.GetObjLst4FeatureRegionByViewInfoEx(objViewInfoENEx);

            foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
            {
                string strFuncName = objvFunction4GeneCodeEN.FuncName;
                if (strFuncName.Substring(0, 6) == "Print:")
                {
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.Append("\r\n " + strFuncName.Substring(6));
                    continue;
                }
                try
                {
                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append(strTemp);
                    }
                }
                catch (Exception objException)
                {
                    throw objException;
                }
            }

            strCodeForCs.Append("\r\n" + "");
            return strCodeForCs.ToString();
        }

        public string Gen_WebView_CS_Code4ExcelExportRegion()
        {
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp = "";
            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                     clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(enumFunctionTemplate.RegionFunctionDetailSet_0005,
                     objViewInfoENEx.CodeTypeId,
                     enumRegionType.ExcelExportRegion_0007)
                                   .OrderBy(x => x.OrderNum);
            foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
            {
                string strFuncName = objvFunction4GeneCodeEN.FuncName;
                if (strFuncName.Substring(0, 6) == "Print:")
                {
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.Append("\r\n " + strFuncName.Substring(6));
                    continue;
                }
                try
                {
                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append(strTemp);
                    }
                }
                catch (Exception objException)
                {
                    throw objException;
                }
            }

            strCodeForCs.Append("\r\n" + "");
            return strCodeForCs.ToString();
        }


        public string Gen_WebView_CS_ShowData()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate
|| objViewInfoENEx.objViewTypeCodeTab.IsHaveDetail)
                {

                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.Append("\r\n /// 函数功能:把以该关键字的记录内容显示在界面上,");
                    strCodeForCs.Append("\r\n ///　　　   在这里是把值传到表控件中");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">表记录的关键字,显示该表关键字的内容</param>",
                      objKeyField.PrivFuncName);
                    strCodeForCs.AppendFormat("\r\n" + "protected void ShowData({0})",
                    objViewInfoENEx.KeyVarDefineLstStr);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "//操作步骤:");
                    strCodeForCs.Append("\r\n" + "//1、检查关键字是否为空；");
                    strCodeForCs.Append("\r\n" + "//2、检查该关键字的记录是否存在,如果不存在就返回不显示；");
                    strCodeForCs.Append("\r\n" + "//3、用提供的关键字初始化一个类对象；");
                    strCodeForCs.Append("\r\n" + "//4、获取类对象的所有属性；");
                    strCodeForCs.Append("\r\n" + "//5、把该对象的所有属性显示在界面上,在这里显示在表控件中");
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.Append("\r\n" + "//1、检查关键字是否为空；");
                    if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "long" || objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "int")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "if ({0} == 0) return ;		//如果关键字为空就返回退出",
                        objKeyField.PrivFuncName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "if ({0} == \"\") return ;		//如果关键字为空就返回退出",
                        objKeyField.PrivFuncName);
                    }
                    strCodeForCs.Append("\r\n" + "//2、检查该关键字的记录是否存在,如果不存在就返回不显示；");
                    strCodeForCs.AppendFormat("\r\n" + "if (cls{0}BL.IsExist({1}) == false)		//检查该关键字的记录是否存在",
                    objViewInfoENEx.TabName, objViewInfoENEx.KeyPrivFuncFldNameLstStr);
                    strCodeForCs.Append("\r\n" + "{");


                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                        objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "ShowData", "在表[{1}]中,关键字为:[{0}]的记录不存在!", "生成代码");

                    strCodeForCs.AppendFormat("\r\n" + "string strMsg = \"(errid:{2})在表[{1}]中,关键字为:[{0}]的记录不存在!\";",
                      objKeyField.PrivFuncName,
                      objViewInfoENEx.TabName, strErrId);
                    strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                    strCodeForCs.Append("\r\n" + "return ;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "//3、用提供的关键字初始化一个类对象；");
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{1}EN = new cls{1}EN({2});",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName, objViewInfoENEx.KeyPrivFuncFldNameLstStr);
                    strCodeForCs.Append("\r\n" + "//4、获取类对象的所有属性；");
                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.Get{1}(ref obj{0}EN);",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                    strCodeForCs.Append("\r\n" + "{");
                    strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                         objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "ShowData", "在显示数据时获取记录对象不成功!", "生成代码");

                    strCodeForCs.AppendFormat("\r\n" + "string strMsg = \"(errid:{0})在显示数据时获取记录对象不成功!\" + objException.Message;", strErrId);
                    strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                    strCodeForCs.Append("\r\n" + "lblMsg_Edit.Text = strMsg;");
                    strCodeForCs.Append("\r\n" + "return;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "Session.Add(\"obj{0}EN\", obj{0}EN);",
                    objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "//5、把该对象的所有属性显示在界面上,在这里显示在表控件中");
                    strCodeForCs.AppendFormat("\r\n" + "GetDataFrom{0}Class(obj{1}EN);",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "}");
                }
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WebView_CS_GetDataFromClass()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成仅有变量;

                if ((mbolIsUseCtl == false))
                {
                    ///从类中取数据传给窗体:protected void GetDataFromClass;
                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.Append("\r\n /// 函数功能:把类对象的属性内容显示到界面上");
                    strCodeForCs.Append("\r\n ///注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值");
                    strCodeForCs.Append("\r\n ///   如果在设置数据库时,就应该一级字段在前,二级字段在后");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.AppendFormat("\r\n /// <param name = \"pobj{0}\">表实体类对象</param>",
                      objViewInfoENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "protected void GetDataFrom{0}Class(cls" + objViewInfoENEx.TabName + "EN pobj" + objViewInfoENEx.TabName + "EN)", objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n ///注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值");
                    strCodeForCs.Append("\r\n /// 如果在设置数据库时,就应该一级字段在前,二级字段在后");
                    IEnumerable<clsEditRegionFldsENEx> arrEditRegionFld = objViewInfoENEx.arrEditRegionFldSet4InUse
                              .Where(x => x.IsPrimaryKey_Identity() == false)
                              .Where(x => x.InUse)
                              .Where(x => x.IsLogUpdDateOrUpdUser(objViewInfoENEx.PrjId) == false);

                    foreach (clsEditRegionFldsENEx objEditRegionFldsEx in arrEditRegionFld)
                    {
                       
                        switch (objEditRegionFldsEx.ObjFieldTabENEx.CsType())
                        {
                            case "int":
                                strCodeForCs.Append("\r\n" + objEditRegionFldsEx.CtrlId + ".Text = pobj" + objViewInfoENEx.TabName + "EN." + objEditRegionFldsEx.FldName + ".ToString();");
                                strCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);
                                strCodeForCs.AppendFormat("" + "(说明:{3};字段类型:{0};字段长度:{1};,是否可空:{2})",
                                objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                                objEditRegionFldsEx.ObjFieldTabENEx.FldLength,
                                objEditRegionFldsEx.ObjFieldTabENEx.IsNull,
                                objEditRegionFldsEx.ObjFieldTabENEx.MemoInTab);
                                break;
                            default:
                                strCodeForCs.Append("\r\n" + objEditRegionFldsEx.CtrlId + ".Text = pobj" + objViewInfoENEx.TabName + "EN." + objEditRegionFldsEx.FldName + ";");
                                strCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);
                                strCodeForCs.AppendFormat("" + "(说明:{3};字段类型:{0};字段长度:{1};,是否可空:{2})",
                                objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                                objEditRegionFldsEx.ObjFieldTabENEx.FldLength,
                                objEditRegionFldsEx.ObjFieldTabENEx.IsNull,
                                objEditRegionFldsEx.ObjFieldTabENEx.MemoInTab);
                                break;
                        }
                    }
                    strCodeForCs.Append("\r\n" + "}");
                }
                else
                {
                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.Append("\r\n /// 函数功能:把类对象的属性内容显示到界面上");
                    strCodeForCs.Append("\r\n ///注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值");
                    strCodeForCs.Append("\r\n /// 如果在设置数据库时,就应该一级字段在前,二级字段在后");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.AppendFormat("\r\n /// <param name = \"pobj{0}EN\">表实体类对象</param>",
                    objViewInfoENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "protected void GetDataFrom{0}Class(cls{1}EN pobj{2}EN)",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    IEnumerable<clsEditRegionFldsENEx> arrEditRegionFld = objViewInfoENEx.arrEditRegionFldSet4InUse
                                 .Where(x => x.IsPrimaryKey_Identity() == false)
                                 .Where(x => x.InUse)
                                 .Where(x => x.IsLogUpdDateOrUpdUser(objViewInfoENEx.PrjId) == false);

                    foreach (clsEditRegionFldsENEx objEditRegionFldsEx in arrEditRegionFld)
                    {                        
                        string strTemp = GetCode4FieldInGetDataFromClass(objEditRegionFldsEx, objViewInfoENEx);
                        strCodeForCs.AppendFormat("{0}", strTemp);

                    }
                    strCodeForCs.Append("\r\n" + "}");
                }
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WebView_CS_Wuc4Gv_GvUpdateClick()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n ///");
                strCodeForCs.AppendFormat("\r\n" + "/// <summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// 事件函数:在Gv列表控件中,当GeidView行单击修改时发生的事件。");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n" + "/// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"sender\"></param>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"e\"></param>");
                strCodeForCs.AppendFormat("\r\n" + "protected void {0}{1}1_GvUpdateClick(object sender, clsEventArgs4Update e)",
                        this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002), PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");
                strCodeForCs.Append("\r\n" + "{");


                switch (objViewInfoENEx.arrKeyPrjTabFldSet[0].ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                {
                    case "long":
                        strCodeForCs.AppendFormat("\r\n" + "long {0} = long.Parse(e.KeyId);",
                           objViewInfoENEx.MainTabPrimaryField_PrivFuncVar);    ////GridView的行删除事件过程
                                                                                //strTemp = Gen_GridView_RowDeleting(objViewInfoENEx, false);
                                                                                //strCodeForCs.Append(strTemp);rjTabFldSet[0].ObjFieldTabENEx.PrivFuncName);
                        break;
                    case "int":
                        strCodeForCs.AppendFormat("\r\n" + "int {0} = int.Parse(e.KeyId);",
                                objViewInfoENEx.MainTabPrimaryField_PrivFuncVar);
                        break;
                    default:
                        strCodeForCs.AppendFormat("\r\n" + "string {0} = e.KeyId;",
                            objViewInfoENEx.MainTabPrimaryField_PrivFuncVar);
                        break;
                }
                strCodeForCs.AppendFormat("\r\n" + "  Update{1}Record({0});",
                    objViewInfoENEx.MainTabPrimaryField_PrivFuncVar,
                    objViewInfoENEx.TabName);

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

        public string Gen_WebView_CS_Wuc4Gv_GvDeleteClick()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n ///");
                strCodeForCs.AppendFormat("\r\n" + "/// <summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// 事件函数:在Gv列表控件中,当GeidView行单击删除时发生的事件。");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n" + "/// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"sender\"></param>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"e\"></param>");
                strCodeForCs.AppendFormat("\r\n" + "protected void {0}{1}1_GvDeleteClick(object sender, clsEventArgs4Delete e)",
                        this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002), PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");
                strCodeForCs.Append("\r\n" + "{");


                switch (objViewInfoENEx.arrKeyPrjTabFldSet[0].ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                {
                    case "long":
                        strCodeForCs.AppendFormat("\r\n" + "long {0} = long.Parse(e.KeyId);",
                           objViewInfoENEx.MainTabPrimaryField_PrivFuncVar);
                        break;
                    case "int":
                        strCodeForCs.AppendFormat("\r\n" + "int {0} = int.Parse(e.KeyId);",
                                objViewInfoENEx.MainTabPrimaryField_PrivFuncVar);
                        break;
                    default:
                        strCodeForCs.AppendFormat("\r\n" + "string {0} = e.KeyId;",
                            objViewInfoENEx.MainTabPrimaryField_PrivFuncVar);
                        break;
                }
                strCodeForCs.AppendFormat("\r\n" + "  Delete{1}Record({0});",
                    objViewInfoENEx.MainTabPrimaryField_PrivFuncVar,
                    objViewInfoENEx.TabName);

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

        public string Gen_WebView_CS_DelRecord()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                //删除记录过程代码for C#"
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 根据给定关键字删除记录");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">给定关键字</param>", objViewInfoENEx.KeyPrivFuncFldNameLstStr);
                strCodeForCs.AppendFormat("\r\n" + "protected void Delete{1}Record({0})",
                objViewInfoENEx.KeyVarDefineLstStr,
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.DelRecord({1});",
                objViewInfoENEx.TabName, objViewInfoENEx.KeyPrivFuncFldNameLstStr);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                        objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Delete{0}Record", "删除记录不成功!", "生成代码");

                strCodeForCs.AppendFormat("\r\n" + "string strMsg = \"(errid:{0})删除记录不成功!\" + objException.Message;", strErrId);
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "lblMsg_List.Text = strMsg;");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
                if (bolIsUseWuc4Gv == true)
                {
                    if (this.IsUseFunc)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}ByFunc();",
                              strTabName_Out4ListRegion);

                    }
                    else if (PrjTabEx_ListRegion.IsUseCache_TS() == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}Cache();",
                            strTabName_Out4ListRegion);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                            strTabName_Out4ListRegion);
                    }
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();", strTabName_Out4ListRegion);
                }
                //strCodeForCs.AppendFormat("\r\n" + "Disp{0}ListRegion();", objViewInfoENEx.TabName);
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


        public string Gen_WebView_CS_btnGoTop_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";

          
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///置顶");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "protected void btnGoTop_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if (PreCheck4Order() == false) return;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {               
                    foreach (clsViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        switch (objInFor.CtlTypeId)
                        {
                            case enumCtlType.DropDownList_06:
                            case enumCtlType.DropDownList_Bool_18:
                                strCodeForCs.AppendFormat("\r\n" + "string str{0} = {1}.SelectedValue;",
                          objInFor.FldName, objInFor.CtrlId);
                                break;
                            case enumCtlType.TextBox_16:
                                strCodeForCs.AppendFormat("\r\n" + "string str{0} = {1}.Text;",
                          objInFor.FldName, objInFor.CtrlId);
                                break;
                            case enumCtlType.TextArea_41:
                                strCodeForCs.AppendFormat("\r\n" + "string str{0} = {1}.Text;",
                          objInFor.FldName, objInFor.CtrlId);
                                break;
                        }
                        strCodeForCs.AppendFormat("\r\n" + "vs{0}_OrderNum = str{0};", objInFor.FldName);
                    }
                }
                if (bolIsUseWuc4Gv == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "List<{1}> {0} = {2}{3}1.GetAllCheckedKeysFromGv();",
                                     objKeyField.PrivFuncListName,
                                     objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                                     this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002), PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "List<{1}> {0} = GetAllCheckedKeysFromGv();",
                                        objKeyField.PrivFuncListName,
                                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                }

                strCodeForCs.AppendFormat("\r\n" + "if ({0}  == null)",
                    objKeyField.PrivFuncListName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"请选择需要置顶的记录!\";");
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, lblMsg_List.Text);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
   

                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() >0)
                {
                    string strClassificationFieldLst = "";
                    objAdjustOrderNum.ClassificationFieldValueLst.ForEach(
                        x => strClassificationFieldLst += string.Format("vs{0}_OrderNum,", x));
                    strClassificationFieldLst = strClassificationFieldLst.Replace("_OrderNum_OrderNum", "_OrderNum");
                    strClassificationFieldLst = strClassificationFieldLst.TrimEnd(",".ToCharArray());

                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.GoTop({1}, {2});",
                     objViewInfoENEx.TabName,
                     objKeyField.PrivFuncListName,
                                          strClassificationFieldLst);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.GoTop({1});",
                     objViewInfoENEx.TabName,                     
                     objKeyField.PrivFuncListName);
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"置顶出错。错误:{0}.({1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = Combine{0}Condition();",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "{0}{2}1.BindGv_{1}(strWhereCond);",
                    this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002),
                    strTabName_Out4ListRegion, PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");
                //strCodeForCs.AppendFormat("\r\n" + "foreach({0} {1} in lst{2})",
                //    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.ObjFieldTabENEx.PrivFuncName,
                //    objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                //strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "{0}{2}1.SetCheckedItemsForGv({1});",
                    this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002), objKeyField.PrivFuncListName, PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");
                //strCodeForCs.Append("\r\n" + "}");


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

        public string Gen_WebView_CS_btnUpMove_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";


                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///上移");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "protected void btnUpMove_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "MoveRecord(\"UP\");");
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

        public string Gen_WebView_CS_MoveRecord()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";



                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///移动记录,包括上移和下移");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "protected void MoveRecord(string strDirect)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if (PreCheck4Order() == false) return;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    foreach (clsViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        switch (objInFor.CtlTypeId)
                        {
                            case enumCtlType.DropDownList_06:
                            case enumCtlType.DropDownList_Bool_18:
                                strCodeForCs.AppendFormat("\r\n" + "string str{0} = {1}.SelectedValue;",
                            objInFor.FldName, objInFor.CtrlId);
                                break;
                            case enumCtlType.TextBox_16:
                                strCodeForCs.AppendFormat("\r\n" + "string str{0} = {1}.Text;",
                          objInFor.FldName, objInFor.CtrlId);
                                break;
                            case enumCtlType.TextArea_41:
                                strCodeForCs.AppendFormat("\r\n" + "string str{0} = {1}.Text;",
                          objInFor.FldName, objInFor.CtrlId);
                                break;
                        }
                        strCodeForCs.AppendFormat("\r\n" + "vs{0}_OrderNum = str{0};", objInFor.FldName);
                        //strCodeForCs.AppendFormat("\r\n" + "vs{0} = str{1};", objAdjustOrderNum.ClassificationFieldValue, objInFor.FldName);
                    }
                }
                if (bolIsUseWuc4Gv == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "{1} {0} = {2}{3}1.GetFirstCheckedKeyFromGv();",
                                     objKeyField.PrivFuncName,
                                     objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                                     this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002), PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "{1} {0} = GetFirstCheckedKeyFromGv();",
                                        objKeyField.PrivFuncName,
                                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                }

                if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "if ({0} == 0)",
                        objKeyField.PrivFuncName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "lblMsg_List.Text = string.Format(\"请选择需要移动({0})的记录!\", strDirect);");
                    strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, lblMsg_List.Text);");
                    strCodeForCs.Append("\r\n" + "return;");
                    strCodeForCs.Append("\r\n" + "}");
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true)",
                         objKeyField.PrivFuncName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "lblMsg_List.Text = string.Format(\"请选择需要移动({0})的记录!\", strDirect);");
                    strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, lblMsg_List.Text);");
                    strCodeForCs.Append("\r\n" + "return;");
                    strCodeForCs.Append("\r\n" + "}");
                }
                strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    string strClassificationFieldLst = "";
                    objAdjustOrderNum.ClassificationFieldValueLst.ForEach(
                        x => strClassificationFieldLst += string.Format("vs{0}_OrderNum,", x));
                    strClassificationFieldLst = strClassificationFieldLst.Replace("_OrderNum_OrderNum", "_OrderNum");
                    strClassificationFieldLst = strClassificationFieldLst.TrimEnd(",".ToCharArray());

                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.AdjustOrderNum(strDirect, {2}, {1});",
                     objViewInfoENEx.TabName,
                     strClassificationFieldLst,
                     objKeyField.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.AdjustOrderNum(strDirect, {1});",
                     objViewInfoENEx.TabName,
                                          objKeyField.PrivFuncName);
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"移动({0})记录出错。错误:{1}.({2})\", strDirect, objException.Message, clsStackTrace.GetCurrClassFunction());");
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "lblMsg_List.Text = strMsg;");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = Combine{0}Condition();",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "{0}{2}1.BindGv_{1}(strWhereCond);",
                    this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002),
                    strTabName_Out4ListRegion, PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");
                strCodeForCs.AppendFormat("\r\n" + "{0}{2}1.SetCheckedItemForGv({1});",
                    this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002), objKeyField.PrivFuncName, PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");

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

        public string Gen_WebView_CS_btnDownMove_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";



                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///下移");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "protected void btnDownMove_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "MoveRecord(\"DOWN\");");
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

        public string Gen_WebView_CS_PreCheck4Order()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                clsFeatureRegionFldsENEx objFeatureRegionFlds_GoTop = objViewInfoENEx.arrFeatureRegionFlds.Find(x => x.FeatureId == enumPrjFeature.AdjustOrderNum_1196);
                if (objFeatureRegionFlds_GoTop == null) return "";
                //clsViewFeatureFldsENEx objField_OrderNum = objViewInfoENEx.arrViewFeatureFlds.Find(x => x.FieldTypeId == enumFieldType.OrderNumField_09 && x.ViewFeatureId == objFeatureRegionFlds_GoTop.ViewFeatureId);
                IEnumerable<clsViewFeatureFldsENEx> arrFieldLst_Classify = objViewInfoENEx.arrViewFeatureFlds.Where(x => x.FieldTypeId == enumFieldType.ClassificationField_10 && x.ViewFeatureId == objFeatureRegionFlds_GoTop.ViewFeatureId);

                List<clsPrjTabFldENEx> arrFldSet = clsPrjTabFldBLEx.GetObjExLst(objViewInfoENEx.MainTabId, objViewInfoENEx.PrjId);
                //生成仅有变量;
                //第0步:把控件中下拉框ComboBox转换成ComboBox
                //foreach (clsPrjTabFldENEx objField in arrFldSet)
                //{
                //    if (objField.FieldTypeId == enumFieldType.ClassificationField_10)
                //    {
                //        clsFieldTabEN objFieldTabEN = clsFieldTabBLEx.GetObjExByFldIDCache(objField.FldId, objField.PrjId);
                //        objAdjustOrderNum.ClassificationFieldValue = objFieldTabEN.FldName;
                //    }
                //    if (objField.FieldTypeId == enumFieldType.OrderNumField_09)
                //    {
                //        clsFieldTabEN objFieldTabEN = clsFieldTabBLEx.GetObjExByFldIDCache(objField.FldId, objField.PrjId);

                //        objAdjustOrderNum.OrderNumFieldName = objFieldTabEN.FldName;
                //    }
                //}
                if (string.IsNullOrEmpty(objFeatureRegionFlds_GoTop.ReleFldId))
                {
                    strCodeForCs.AppendFormat("\r\n" + "//表：[{0}]的序号字段为空,不能生成【预检函数(PreCheck4Order)】;",
                        objViewInfoENEx.TabName);
                    return strCodeForCs.ToString();

                }
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///置底");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "private bool PreCheck4Order()");
                strCodeForCs.Append("\r\n" + "{");
                if (arrFieldLst_Classify.Count() > 0)
                {
                    foreach (clsViewFeatureFldsENEx objInFor in arrFieldLst_Classify)
                    {
                        switch (objInFor.CtlTypeId)
                        {
                            case enumCtlType.DropDownList_06:
                            case enumCtlType.DropDownList_Bool_18:
                                strCodeForCs.AppendFormat("\r\n" + "if ({0}.SelectedIndex <= 0)",
                                    objInFor.CtrlId);
                                break;
                            case enumCtlType.TextBox_16:
                                strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}.Text) == true)",
                                    objInFor.CtrlId);
                                break;
                            case enumCtlType.TextArea_41:
                                strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}.Text) == true)",
                                    objInFor.CtrlId);
                                break;
                        }

                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "lblMsg_List.Text = \"请输入{0}!\";", objInFor.ObjFieldTabENEx.FldName);
                        strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, lblMsg_List.Text);");
                        strCodeForCs.AppendFormat("\r\n" + "{0}.Focus();",
                            objInFor.CtrlId);
                        strCodeForCs.Append("\r\n" + "return false;");
                        strCodeForCs.Append("\r\n" + "}");
                    }
                }
                strCodeForCs.Append("\r\n" + "return true;");
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

        public string Gen_WebView_CS_btnGoBottum_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";




                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///置底");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "protected void btnGoBottum_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "if (PreCheck4Order() == false) return;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    foreach (clsViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        switch (objInFor.CtlTypeId)
                        {
                            case enumCtlType.DropDownList_06:
                            case enumCtlType.DropDownList_Bool_18:
                                strCodeForCs.AppendFormat("\r\n" + "string str{0} = {1}.SelectedValue;",
                            objInFor.FldName, objInFor.CtrlId);
                                break;
                            case enumCtlType.TextBox_16:
                                strCodeForCs.AppendFormat("\r\n" + "string str{0} = {1}.Text;",
                          objInFor.FldName, objInFor.CtrlId);
                                break;
                            case enumCtlType.TextArea_41:
                                strCodeForCs.AppendFormat("\r\n" + "string str{0} = {1}.Text;",
                          objInFor.FldName, objInFor.CtrlId);
                                break;
                        }
                        strCodeForCs.AppendFormat("\r\n" + "vs{0}_OrderNum = str{0};", objInFor.FldName);
                        //strCodeForCs.AppendFormat("\r\n" + "vs{0} = str{1};", objAdjustOrderNum.ClassificationFieldValue, objInFor.FldName);
                    }
                }
                if (bolIsUseWuc4Gv == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "List<{1}> {0} = {2}{3}1.GetAllCheckedKeysFromGv();",
                                     objKeyField.PrivFuncListName,
                                     objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                                     this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002), PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "List<{1}> {0} = GetAllCheckedKeysFromGv();",
                                        objKeyField.PrivFuncListName,
                                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                }

                strCodeForCs.AppendFormat("\r\n" + "if ({0}  == null)",
                    objKeyField.PrivFuncListName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"请选择需要置底的记录!\";");
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, lblMsg_List.Text);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
           
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    string strClassificationFieldLst = "";
                    objAdjustOrderNum.ClassificationFieldValueLst.ForEach(
                        x => strClassificationFieldLst += string.Format("vs{0}_OrderNum,", x));
                    strClassificationFieldLst = strClassificationFieldLst.Replace("_OrderNum_OrderNum", "_OrderNum");
                    strClassificationFieldLst = strClassificationFieldLst.TrimEnd(",".ToCharArray());

                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.GoBottom({1}, {2});",
                         objViewInfoENEx.TabName,
                         objKeyField.PrivFuncListName,
                         strClassificationFieldLst);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.GoBottom({1});",
                         objViewInfoENEx.TabName,
                         objKeyField.PrivFuncListName);
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"置底出错。错误:{0}.({1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "lblMsg_List.Text = strMsg;");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = Combine{0}Condition();",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "{0}{2}1.BindGv_{1}(strWhereCond);",
                    this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002),
                    strTabName_Out4ListRegion, PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");
                //strCodeForCs.AppendFormat("\r\n" + "foreach({0} {1} in lst{2})",
                //        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.ObjFieldTabENEx.PrivFuncName,
                //        objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                //strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "{0}{2}1.SetCheckedItemsForGv({1});",
                    this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002), objKeyField.PrivFuncListName, PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");
                //strCodeForCs.Append("\r\n" + "}");

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
        public string Gen_WebView_CS_btnReOrder_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";




                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///重序");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "protected void btnReOrder_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if (PreCheck4Order() == false) return;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    foreach (clsViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        switch (objInFor.CtlTypeId)
                        {
                            case enumCtlType.DropDownList_06:
                            case enumCtlType.DropDownList_Bool_18:
                                strCodeForCs.AppendFormat("\r\n" + "string str{0} = {1}.SelectedValue;",
                            objInFor.FldName, objInFor.CtrlId);
                                break;
                            case enumCtlType.TextBox_16:
                                strCodeForCs.AppendFormat("\r\n" + "string str{0} = {1}.Text;",
                          objInFor.FldName, objInFor.CtrlId);
                                break;
                            case enumCtlType.TextArea_41:
                                strCodeForCs.AppendFormat("\r\n" + "string str{0} = {1}.Text;",
                          objInFor.FldName, objInFor.CtrlId);
                                break;
                        }
                        strCodeForCs.AppendFormat("\r\n" + "vs{0}_OrderNum = str{0};", objInFor.FldName);
                        //strCodeForCs.AppendFormat("\r\n" + "vs{0} = str{1};", objAdjustOrderNum.ClassificationFieldValue, objInFor.FldName);
                    }
                }
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
               
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    string strClassificationFieldLst = "";
                    objAdjustOrderNum.ClassificationFieldValueLst.ForEach(
                        x => strClassificationFieldLst += string.Format("vs{0}_OrderNum,", x));
                    strClassificationFieldLst = strClassificationFieldLst.Replace("_OrderNum_OrderNum", "_OrderNum");
                    strClassificationFieldLst = strClassificationFieldLst.TrimEnd(",".ToCharArray());

                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.ReOrder({1});",
                   objViewInfoENEx.TabName,
                   strClassificationFieldLst);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.ReOrder();",
                   objViewInfoENEx.TabName                   );
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"重序出错。错误:{0}.({1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = Combine{0}Condition();",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "{0}{2}1.BindGv_{1}(strWhereCond);",
                    this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002),
                    strTabName_Out4ListRegion, PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");

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

        /// <summary>
        /// 导出EXCEL文件,其中导出的字段完全与DataGrid一致。
        /// </summary>
        /// <returns></returns>
        public string Gen_WebView_CS_btnExportExcel_Click()
        {
            string strFuncName = "";
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
                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// 事件函数:把查询条件的表记录,导出到Excel.");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "/// </summary>");
                strCodeForCs.Append("\r\n" + "/// <param name = \"sender\"></param>");
                strCodeForCs.Append("\r\n" + "/// <param name = \"e\"></param>");
                //        strCodeForCs.Append("\r\n" + "//生成专门用于导出Excel的相关代码");
                strCodeForCs.Append("\r\n" + "protected void btnExportExcel_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//导出Excel函数");
                strCodeForCs.Append("\r\n" + "ExportExcel();");
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

        public string Gen_WebView_CS_btnSetExportExcel4User_Click()
        {
            if (objViewInfoENEx.IsNeedSetExportFld == false)
            {
                return "";
            }
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n ///设置当前用户的Excel导出字段");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");


                if (objViewInfoENEx.objViewRegion_List.IsCheck() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnSetExportExcel4User_Click(object sender, EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "clsExportExcelSetENEx objExportExcelSetENEx = new clsExportExcelSetENEx();");
                    strCodeForCs.Append("\r\n" + "StringBuilder sbCondition = new StringBuilder();");
                    strCodeForCs.Append("\r\n" + "sbCondition.AppendFormat(\"ViewName = '{" + "0" + "}'\", vsViewName);//当前界面");
                    strCodeForCs.Append("\r\n" + "sbCondition.AppendFormat(\" And TabName = '{" + "0" + "}'\", vsTabName);//当前导出的使用的表");
                    strCodeForCs.Append("\r\n" + "sbCondition.AppendFormat(\" And UserId = '{" + "0" + "}'\", clsCommonSession.UserId);//当前用户");
                    strCodeForCs.Append("\r\n" + "//根据条件获取Excel设置Id");
                    strCodeForCs.Append("\r\n" + "string strid_ExportExcel4Users = clsExportExcelSetBL.GetFirstID_S(sbCondition.ToString());");
                    strCodeForCs.Append("\r\n" + "if (string.IsNullOrEmpty(strid_ExportExcel4Users) == true)");
                    strCodeForCs.Append("\r\n" + "{");

                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                      objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "GetMaxStrId_S", "在系统中没有界面为{0},表名 = {1},并且用户 = {2}的导出Excel用户设置,请先导出一次Excel,再不行可与管理员联系!", "生成代码");

                    strCodeForCs.Append("\r\n" + "StringBuilder sbMsg = new StringBuilder();");
                    strCodeForCs.AppendFormat("\r\n" + "sbMsg.AppendFormat(\"(errid:{0})在系统中没有界面为[{{0}}]\", vsViewName);", strErrId, "{", "}");
                    strCodeForCs.Append("\r\n" + "sbMsg.AppendFormat(\",表名 = '{" + "0" + "}'\", vsTabName);");
                    strCodeForCs.Append("\r\n" + "sbMsg.AppendFormat(\"并且用户 = '{" + "0" + "}'的导出Excel用户设置,请先导出一次Excel,再不行可与管理员联系!\", clsCommonSession.UserId);");
                    strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, sbMsg.ToString());");
                    strCodeForCs.Append("\r\n" + "return;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "//弹出导出Excel字段界面进行设置");
                    strCodeForCs.Append("\r\n" + "StringBuilder sbScript = new StringBuilder();");

                    strCodeForCs.Append("\r\n" + "sbScript.Append(\"<script language = 'javascript'>\");");
                    strCodeForCs.Append("\r\n" + "sbScript.Append(\"window.open('\");");
                    strCodeForCs.Append("\r\n" + "sbScript.AppendFormat(\"../SysManage/wfmExportExcel4UsersB_QUDI.aspx?Id_ExportExcel4Users = {" + "0" + "}\", strid_ExportExcel4Users);");
                    strCodeForCs.Append("\r\n" + "sbScript.Append(\"','_blank', 'left = 50px,top = 50px,status = no,width = 920px,height = 650px,scrollbars = yes'); </script>\");");
                    strCodeForCs.Append("\r\n" + "Page.ClientScript.RegisterStartupScript(this.GetType(), \"导出Excel字段设置\", sbScript.ToString());");
                    strCodeForCs.Append("\r\n" + "// Response.Write(sbScript.ToString());");
                    strCodeForCs.Append("\r\n" + "}");
                }
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WebView_CS_ExportExcel()
        {
            if (objViewInfoENEx.IsNeedSetExportFld == true)
            {
                return GenExportExcel4SetExportFld();
            }
            if (objViewInfoENEx.objViewRegion_ExportExcel == null) return "";
            string strTabName_Out = clsPrjTabBL.GetNameByTabIdCache(objViewInfoENEx.objViewRegion_ExportExcel.TabId, objViewInfoENEx.PrjId);
            string strTabName_Out_Query = clsPrjTabBL.GetNameByTabIdCache(objViewInfoENEx.objViewRegion_Query.TabId, objViewInfoENEx.PrjId);
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
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
                strCodeForCs.Append("\r\n" + "private void ExportExcel()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//	1、组合界面条件串；");
                strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = Combine{0}Condition();",
                        strTabName_Out_Query);
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
                    strTabName_Out);
                }

                strCodeForCs.Append("\r\n" + "strFolderName = clsSysParaEN.TempFileFolder;");
                strCodeForCs.Append("\r\n" + "strDownLoadFileName = strFolderName + strFileName;");
                strCodeForCs.Append("\r\n" + "//初始化需要导出的Excel文件,即复制标准Excel文件作为母版,复制不成功即不能导出");
                strCodeForCs.Append("\r\n" + "if (clsPubVar.InitExcelFile(this, strFolderName, strDownLoadFileName) == false)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                //				strCodeForCs.Append("\r\n" + "GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTable(objDT, strColName, strCnName, strDownLoadFileName);");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//	2、根据条件串获取该表满足条件的DataTable；");
            
                    strCodeForCs.AppendFormat("\r\n" + "objDT = cls{0}BL.GetDataTable(strWhereCond);",
                    strTabName_Out);
            
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"获取数据出错,请联系管理员!错误:{0}.({1})\",");
                strCodeForCs.Append("\r\n" + "objException.Message, clsStackTrace.GetCurrClassFunction());");
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "return;");
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
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "clsCommForWebForm.DownLoadFile(strDownLoadFileName);");
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

        /// <summary>
        /// 生成<显示列表、编辑区域>
        /// </summary>
        /// <returns></returns>
        public string Gen_WebView_CS_DispListRegion()
        {

            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放WebForm的代码;
            //			string strTemp; ///临时变量;

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 布局控制函数,显示数据列表区,并隐藏用于编辑的用户控件");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n" + "private void Disp{0}ListRegion()",
              objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "divList.Visible = true;",
            objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "tabEdit{0}Region.Visible = false;",
            objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        /// <summary>
        /// 生成<显示列表、编辑区域>
        /// </summary>
        /// <returns></returns>
        public string Gen_WebView_CS_DispEditRegion()
        {

            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放WebForm的代码;
            //			string strTemp; ///临时变量;

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 布局控制函数,显示用于编辑的用户控件,并隐藏数据列表区");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n" + "private void DispEdit{0}Region()",
              objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "divList.Visible = false;",
            objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "tabEdit{0}Region.Visible = true;",
            objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WebView_CS_ErrMessageSession()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成仅有变量;

                //生成登录用户的用户名Session
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// Session属性:错误信息的Session属性,该Session传递给显示出错页面,显示相应的错误内容。");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.Append("\r\n" + "protected string seErrMessage");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strErrMessage;");
                strCodeForCs.Append("\r\n" + "strErrMessage = (string)Session[\"ErrMessage\"];");
                strCodeForCs.Append("\r\n" + "if (strErrMessage == null) ");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "strErrMessage = \"\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return strErrMessage;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strErrMessage = value;");
                strCodeForCs.Append("\r\n" + "Session.Add(\"ErrMessage\", strErrMessage);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WebView_CS_BackLinkStrSession()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成仅有变量;
                //生成登录用户的用户名Session
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// Session属性:返回链接串的Session属性,该Session用于告诉出错页面,哪一个页面是需要返回的页面。");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "protected string seBackErrPageLinkStr");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strBackErrPageLinkStr;");
                strCodeForCs.Append("\r\n" + "strBackErrPageLinkStr = (string)Session[\"BackErrPageLinkStr\"];");
                strCodeForCs.Append("\r\n" + "if (strBackErrPageLinkStr == null) ");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "strBackErrPageLinkStr = \"\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return strBackErrPageLinkStr;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strBackErrPageLinkStr = value;");
                strCodeForCs.Append("\r\n" + "Session.Add(\"BackErrPageLinkStr\", strBackErrPageLinkStr);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }



        public string Gen_WebView_CS_DefProperty_vsViewName()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成仅有变量;
                //strCodeForCs.Append("\r\n" + "//生成有关的变量定义代码");

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ViewState属性:当前操作的界面功能名称");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "protected string vsViewName");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string sViewName;");
                strCodeForCs.Append("\r\n" + "sViewName = (string)ViewState[\"ViewName\"];");
                strCodeForCs.Append("\r\n" + "if (sViewName == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "sViewName = \"\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return sViewName;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string sViewName = value;");
                strCodeForCs.Append("\r\n" + "ViewState.Add(\"ViewName\", sViewName);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                //				strCodeForCs.Append("\r\n" + "protected string vsPotenceLevel; //权限等级编号");
                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_WebView_CS_DefProperty_vsTabName()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成仅有变量;
                //strCodeForCs.Append("\r\n" + "//生成有关的变量定义代码");

               
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ViewState属性:当前操作的导出表名称");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "protected string vsTabName");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string sTabName;");
                strCodeForCs.Append("\r\n" + "sTabName = (string)ViewState[\"TabName\"];");
                strCodeForCs.Append("\r\n" + "if (sTabName == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "sTabName = \"\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return sTabName;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string sTabName = value;");
                strCodeForCs.Append("\r\n" + "ViewState.Add(\"TabName\", sTabName);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                
                //				strCodeForCs.Append("\r\n" + "protected string vsPotenceLevel; //权限等级编号");
                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_WebView_CS_DefProperty_vsCacheClassifyField()
        {
            if (objViewInfoENEx.objCacheClassifyFld4View == null)
            {
                return "";
            }
            var strVar4ViewCacheFld = string.Format("{0}Cache", objViewInfoENEx.objCacheClassifyFld4View.FldName);
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成仅有变量;
                //strCodeForCs.Append("\r\n" + "//生成有关的变量定义代码");


                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ViewState属性:当前操作的导出表名称");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "protected string vs{0}", strVar4ViewCacheFld);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "string s{0};", strVar4ViewCacheFld);
                strCodeForCs.AppendFormat("\r\n" + "s{0} = (string)ViewState[\"{0}\"];", strVar4ViewCacheFld);
                strCodeForCs.AppendFormat("\r\n" + "if (s{0} == null)", strVar4ViewCacheFld);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "s{0} = \"\";", strVar4ViewCacheFld);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.AppendFormat("\r\n" + "return s{0};", strVar4ViewCacheFld);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "string s{0} = value;", strVar4ViewCacheFld);
                strCodeForCs.AppendFormat("\r\n" + "ViewState.Add(\"{0}\", s{0});", strVar4ViewCacheFld);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");

                //				strCodeForCs.Append("\r\n" + "protected string vsPotenceLevel; //权限等级编号");
                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_WebView_CS_DefProperty_qsUserId()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// QueryString属性:通过QueryString传递过来的UserId参数。这里是样例,大家可以参考这个样例。");
                strCodeForCs.Append("\r\n /// 姓名:");
                strCodeForCs.Append("\r\n /// 日期:");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "private string qsUserId");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strUserId = Request.QueryString[ \"UserId\"] ?? \"\".ToString();");
                strCodeForCs.Append("\r\n" + "if ((strUserId != null) && (strUserId != \"\"))");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return strUserId;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return \"\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                                              
                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WebView_CS_DefProperty_vsPotenceLevel()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// ViewState属性:用于记录当前用户在当前界面的权限等级");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "/// </summary>");

                //获取当前用户的权限等级编号
                strCodeForCs.Append("\r\n" + "protected string vsPotenceLevel");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string sPotenceLevel;");
                strCodeForCs.Append("\r\n" + "sPotenceLevel = (string)ViewState[\"PotenceLevel\"];");
                strCodeForCs.Append("\r\n" + "if (sPotenceLevel == null) ");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//					sPotenceLevel = new General_Platform_Dll.MenuAndPotence().Get_PotenceLevel(ViewId4Potence);");
                strCodeForCs.Append("\r\n" + "sPotenceLevel = \"9\";");
                strCodeForCs.Append("\r\n" + "ViewState.Add(\"PotenceLevel\", sPotenceLevel);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return sPotenceLevel;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }



        /// <summary>
        // 生成权限有关的变量定义代码
        /// </summary>
        /// <returns></returns>
        public string Gen_WebView_CS_PotenceRelaVar()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成仅有变量;
                //strCodeForCs.Append("\r\n" + "//生成有关的变量定义代码");

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ViewState属性:当前操作的界面功能名称");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "protected string vsViewName");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string sViewName;");
                strCodeForCs.Append("\r\n" + "sViewName = (string)ViewState[\"ViewName\"];");
                strCodeForCs.Append("\r\n" + "if (sViewName == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "sViewName = \"\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return sViewName;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string sViewName = value;");
                strCodeForCs.Append("\r\n" + "ViewState.Add(\"ViewName\", sViewName);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ViewState属性:当前操作的导出表名称");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "protected string vsTabName");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string sTabName;");
                strCodeForCs.Append("\r\n" + "sTabName = (string)ViewState[\"TabName\"];");
                strCodeForCs.Append("\r\n" + "if (sTabName == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "sTabName = \"\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return sTabName;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string sTabName = value;");
                strCodeForCs.Append("\r\n" + "ViewState.Add(\"TabName\", sTabName);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// QueryString属性:通过QueryString传递过来的UserId参数。这里是样例,大家可以参考这个样例。");
                strCodeForCs.Append("\r\n /// 姓名:");
                strCodeForCs.Append("\r\n /// 日期:");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "private string qsUserId");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strUserId = Request.QueryString[ \"UserId\"] ?? \"\".ToString();");
                strCodeForCs.Append("\r\n" + "if ((strUserId != null) && (strUserId != \"\"))");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return strUserId;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return \"\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");


                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// 与权限相关的界面编号");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "/// </summary>");
                strCodeForCs.Append("\r\n" + "protected const string ViewId4Potence = \"00260203\";		//界面编号");
                //				strCodeForCs.Append("\r\n" + "protected string vsPotenceLevel; //权限等级编号");
                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_WebView_CS_DefConst_ViewId4Potence()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {                
                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// 与权限相关的界面编号");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "/// </summary>");
                strCodeForCs.Append("\r\n" + "protected const string ViewId4Potence = \"00260203\";		//界面编号");
                //				strCodeForCs.Append("\r\n" + "protected string vsPotenceLevel; //权限等级编号");
                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        /// <summary>
        // 生成权限有关权限等级的代码
        /// </summary>
        /// <returns></returns>
        public string Gen_WebView_CS_PotenceLevelProperty()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成仅有变量;
                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// ViewState属性:用于记录当前用户在当前界面的权限等级");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "/// </summary>");

                //获取当前用户的权限等级编号
                strCodeForCs.Append("\r\n" + "protected string vsPotenceLevel");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string sPotenceLevel;");
                strCodeForCs.Append("\r\n" + "sPotenceLevel = (string)ViewState[\"PotenceLevel\"];");
                strCodeForCs.Append("\r\n" + "if (sPotenceLevel == null) ");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//					sPotenceLevel = new General_Platform_Dll.MenuAndPotence().Get_PotenceLevel(ViewId4Potence);");
                strCodeForCs.Append("\r\n" + "sPotenceLevel = \"9\";");
                strCodeForCs.Append("\r\n" + "ViewState.Add(\"PotenceLevel\", sPotenceLevel);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return sPotenceLevel;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_WebView_CS_AccessUserPotence()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成仅有变量;
                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// 用户权限管理:处理当前用户在当前界面的权限相关操作");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "/// </summary>");

                //获取当前用户的权限等级编号
                strCodeForCs.Append("\r\n" + "protected bool AccessUserPotence()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//生成权限有关判断权限的代码");
                //获取当前用户的权限等级编号
                strCodeForCs.Append("\r\n" + "//根据等级权限编号来确定用户可以使用什么功能,等级编号方式:1为最大2其次,依此类推");
                strCodeForCs.Append("\r\n" + "switch (vsPotenceLevel)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "case \"0\":");
                strCodeForCs.Append("\r\n" + "Response.Redirect(\"../error.aspx\");");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "case \"1\":");
                strCodeForCs.Append("\r\n" + "Response.Redirect(\"../error.aspx\");");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "case \"2\":");
                strCodeForCs.Append("\r\n" + "Response.Redirect(\"../error.aspx\");");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "case \"3\":");
                strCodeForCs.Append("\r\n" + "Response.Redirect(\"../error.aspx\");");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "case \"4\":");
                strCodeForCs.Append("\r\n" + "Response.Redirect(\"../error.aspx\");");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "case \"9\":");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "default:");
                strCodeForCs.Append("\r\n" + "Response.Redirect(\"../error.aspx\");");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return true;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        /// <summary>
        /// 生成登录用户的用户名Session
        /// </summary>
        /// <returns></returns>
        public string Gen_WebView_CS_DefProperty_seUserId()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成仅有变量;
                //strCodeForCs.Append("\r\n" + "//生成登录用户的用户名Session");
                //生成登录用户的用户名Session
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// Session属性:登录的用户ID,用于检查用户权限");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.Append("\r\n" + "protected string seUserId");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strUserId;");
                strCodeForCs.Append("\r\n" + "strUserId = (string)Session[\"UserId\"];");
                strCodeForCs.Append("\r\n" + "if (strUserId == null) ");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "strUserId = \"\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return strUserId;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strUserId = value;");
                strCodeForCs.Append("\r\n" + "Session.Add(\"UserId\", strUserId);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n ///protected clsUsersEN objUser");
                strCodeForCs.Append("\r\n ///{");
                strCodeForCs.Append("\r\n ///get");
                strCodeForCs.Append("\r\n ///{");
                strCodeForCs.Append("\r\n ///clsUsersEN pobjUser;");
                strCodeForCs.Append("\r\n ///pobjUser = (clsUsersEN)Session[\"objUser\"];");
                strCodeForCs.Append("\r\n ///if (pobjUser == null) ");
                strCodeForCs.Append("\r\n ///{");
                strCodeForCs.Append("\r\n ///pobjUser = null;");
                strCodeForCs.Append("\r\n ///}");
                strCodeForCs.Append("\r\n ///return pobjUser;");
                strCodeForCs.Append("\r\n ///}");
                strCodeForCs.Append("\r\n ///set");
                strCodeForCs.Append("\r\n ///{");
                strCodeForCs.Append("\r\n ///clsUsersEN pobjUser = value;");
                strCodeForCs.Append("\r\n ///Session.Add(\"objUser\", pobjUser);");
                strCodeForCs.Append("\r\n ///}");
                strCodeForCs.Append("\r\n ///}");
                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 生成父对象的SESSION相关属性函数
        /// </summary>
        /// <returns></returns>
        public string Gen_WebView_CS_ParentObjSeesionProp()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {

                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {                    
                    if (objQryRegionFldsEx.IsTabForeignKey() == true)
                    {
                        strCodeForCs.Append("\r\n /// <summary>");
                        strCodeForCs.AppendFormat("\r\n /// {0}",
                        objQryRegionFldsEx.LabelCaption);
                        strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n /// </summary>");

                        strCodeForCs.AppendFormat("\r\n" + "protected string {0}",
                        objQryRegionFldsEx.FldName);
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.Append("\r\n" + "get");
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "string str{0};",
                        objQryRegionFldsEx.FldName);
                        strCodeForCs.AppendFormat("\r\n" + "str{0} = (string)Session[\"{0}\"];",
                        objQryRegionFldsEx.FldName);
                        strCodeForCs.AppendFormat("\r\n" + "if (str{0} == null) ",
                        objQryRegionFldsEx.FldName);
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "str{0} = \"\";",
                        objQryRegionFldsEx.FldName);
                        strCodeForCs.Append("\r\n" + "}");
                        strCodeForCs.AppendFormat("\r\n" + "return str{0};",
                        objQryRegionFldsEx.FldName);
                        strCodeForCs.Append("\r\n" + "}");
                        strCodeForCs.Append("\r\n" + "set");
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "string str{0} = value;",
                        objQryRegionFldsEx.FldName);
                        strCodeForCs.AppendFormat("\r\n" + "Session.Add(\"{0}\", str{0});",
                        objQryRegionFldsEx.FldName);
                        strCodeForCs.Append("\r\n" + "}");
                        strCodeForCs.Append("\r\n" + "}");

                    }
                }
                strCodeForCs.Append("\r\n" + "");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }
        
        public string Gen_WebView_CS_btnSetFieldValue_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFldsObjLst = objViewInfoENEx.arrFeatureRegionFlds.Where(x => x.FeatureId == "0148");
                foreach (clsFeatureRegionFldsENEx objInFor in arrFeatureRegionFldsObjLst)
                {
                 

                    K_FldId_FieldTab objKey = new K_FldId_FieldTab(objInFor.ReleFldId);
                    clsFieldTabEN objFieldTabEN = objKey.GetObj();

                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.AppendFormat("\r\n ///设置字段值");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");


                    strCodeForCs.AppendFormat("\r\n" + "protected void {0}_Click(object sender, System.EventArgs e)", objInFor.ButtonName);
                    strCodeForCs.Append("\r\n" + "{");

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
                    if (bolIsUseWuc4Gv == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "List<{1}> lst{0} = {2}{3}1.GetAllCheckedKeysFromGv();",
                                         objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                         objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                                         this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002), PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "List<{1}> lst{0} = GetAllCheckedKeysFromGv();",
                                            objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                    }
                    strCodeForCs.AppendFormat("\r\n" + "if (lst{0} == null) return;",
                                        objKeyField.ObjFieldTabENEx.FldName_FstUcase);

                    clsViewFeatureFldsENEx objViewFeatureFlds = null;


                    if (objInFor.FeatureId == enumPrjFeature.SetFieldValue_0148
                && objInFor.ValueGivingModeId == enumValueGivingMode.GivenValue_02)
                    {
                        List<clsViewFeatureFldsENEx> arrViewFeatureFlds = objViewInfoENEx.arrViewFeatureFlds.Where(x =>
                        x.ViewFeatureId == objInFor.ViewFeatureId).ToList();
                        if (arrViewFeatureFlds.Count > 0)
                        {
                            objViewFeatureFlds = arrViewFeatureFlds[0];
                            ASPDropDownListEx objASPDropDownListENEx = clsASPDropDownListBLEx.GetDropDownLst_Asp(objViewFeatureFlds, new clsGetTabFieldObj());
                            string strCtrlId = objASPDropDownListENEx.CtrlId;
                            if (strCtrlId.IndexOf("_SetFldValue") == -1)
                            {
                                strCtrlId = strCtrlId + "_SetFldValue";
                                objASPDropDownListENEx.CtrlId = strCtrlId;
                            }

                            strCodeForCs.AppendFormat("\r\n" + "if ({0}.SelectedIndex <= 0)",
                                        objASPDropDownListENEx.CtrlId);

                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "lblMsg_List.Text = \"请输入{0}({1})!\";", 
                                objViewFeatureFlds.ObjFieldTabENEx.Caption,
                                objViewFeatureFlds.ObjFieldTabENEx.FldName);
                            strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, lblMsg_List.Text);");
                            strCodeForCs.AppendFormat("\r\n" + "{0}.Focus();",
                                objASPDropDownListENEx.CtrlId);
                            strCodeForCs.Append("\r\n" + "return;");
                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.AppendFormat("\r\n" + "string str{0} = {1}.SelectedValue;",
                                   objViewFeatureFlds.ObjFieldTabENEx.FldName,
                                   objASPDropDownListENEx.CtrlId);
                        }
                    }
                
                strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");

                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "foreach ({0} {1} in lst{2})",
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                        objKeyField.PrivFuncName,
                        objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "K_{0}_{1} objKey = new K_{0}_{1}({2});",
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
                            strCodeForCs.AppendFormat("\r\n" + "obj{0}.Set{1}(str{2});",
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

                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                        objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, string.Format("{0}_Click", objInFor.ButtonName), string.Format("{0}不成功!", objInFor.Text), "生成代码");

                    strCodeForCs.AppendFormat("\r\n" + "string strMsg = \"(errid:{0}){1}不成功!\" + objException.Message;", strErrId, objInFor.Text);
                    strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                    strCodeForCs.Append("\r\n" + "lblMsg_List.Text = strMsg;");
                    strCodeForCs.Append("\r\n" + "return;");
                    strCodeForCs.Append("\r\n" + "}");
                    if (bolIsUseWuc4Gv == true)
                    {
                        if (this.IsUseFunc)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}ByFunc();",
                                  strTabName_Out4ListRegion);

                        }
                        else if (PrjTabEx_ListRegion.IsUseCache_TS() == true)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}Cache();",
                                strTabName_Out4ListRegion);
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                                strTabName_Out4ListRegion);
                        }
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();", strTabName_Out4ListRegion);
                    }
                    strCodeForCs.Append("\r\n" + "}");

                }
            
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        /// <summary>
        /// 针对主表只有一个关键字的删除事件
        /// </summary>
        /// <param name="objViewInfoENEx"></param>
        /// <returns></returns>
        public string Gen_WebView_CS_btnDelRecord_Click4OneKeyword()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///删除当前被选记录");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                if (objViewInfoENEx.objViewRegion_List.IsCheck() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnDelRecord_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");

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
                    if (bolIsUseWuc4Gv == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "List<{1}> lst{0} = {2}{3}1.GetAllCheckedKeysFromGv();",
                                         objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                         objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                                         this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002), PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "List<{1}> lst{0} = GetAllCheckedKeysFromGv();",
                                            objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                    }
                    strCodeForCs.AppendFormat("\r\n" + "if (lst{0} == null) return;",
                                        objKeyField.ObjFieldTabENEx.FldName_FstUcase);

                    strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");

                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "foreach ({0} {1} in lst{2})",
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                        objKeyField.PrivFuncName,
                        objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                    strCodeForCs.Append("\r\n" + "{");


                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.DelRecord({1});",
                        objViewInfoENEx.TabName,
                        objKeyField.PrivFuncName);

                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                        objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnDelRecord_Click", "删除记录不成功!", "生成代码");

                    strCodeForCs.AppendFormat("\r\n" + "string strMsg = \"(errid:{0})删除记录不成功!\" + objException.Message;", strErrId);
                    strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                    strCodeForCs.Append("\r\n" + "lblMsg_List.Text = strMsg;");
                    strCodeForCs.Append("\r\n" + "return;");
                    strCodeForCs.Append("\r\n" + "}");
                    if (bolIsUseWuc4Gv == true)
                    {
                        if (this.IsUseFunc)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}ByFunc();",
                                  strTabName_Out4ListRegion);

                        }
                        else if (PrjTabEx_ListRegion.IsUseCache_TS() == true)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}Cache();",
                                strTabName_Out4ListRegion);
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                                strTabName_Out4ListRegion);
                        }
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();", strTabName_Out4ListRegion);
                    }
                    strCodeForCs.Append("\r\n" + "}");
                }
                else if (objViewInfoENEx.objViewRegion_List.IsRadio() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnDelRecord_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string str{0} = (string) rd.Value;",
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "if (str{0} == null || str{0}.Trim().Length == 0) ",
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnDelRecord_Click", "没有选择记录,请选择一个有效的表记录!", "生成代码");

                    strCodeForCs.AppendFormat("\r\n" + "lblMsg.Text = \"(errid:{0})没有选择记录,请选择一个有效的表记录!\";", strErrId);

                    //strCodeForCs.Append("\r\n" + "lblMsg.Text = \"没有选择记录,请选择一个有效的表记录!\";");
                    strCodeForCs.Append("\r\n" + "return ;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "lblMsg.Text = \"\";");

                    switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                    {
                        case "string":
                            //							strCodeForCs.AppendFormat("\r\n" + "{0} = e.Item.Cells[{1}].Text;", 
                            //								objViewInfoENEx. objMainTabKeyField.ObjFieldTabENEx.PrivFuncName, intItemNum);
                            break;
                        case "int":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = int.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                        case "long":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = long.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                    }

                    strCodeForCs.AppendFormat("\r\n" + "cls{0}.DelRecord({1});",
                    objViewInfoENEx.TabName, objKeyField.PrivFuncName);
                    if (bolIsUseWuc4Gv == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + " string strWhereCond = Combine{0}Condition();",
               objViewInfoENEx.TabName);
                        strCodeForCs.AppendFormat("\r\n" + " {1}{2}1.BindGv_{0}(strWhereCond);",
                            objViewInfoENEx.TabName, this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002), PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();", objViewInfoENEx.TabName);
                    }
                    strCodeForCs.Append("\r\n" + "}");
                }
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WebView_CS_btnDelRecord_Click()
        {
            if (objViewInfoENEx.arrKeyPrjTabFldSet.Count == 1)
            {
                return GenbtnDelRecord_Click4OneKeyword();
            }
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///删除当前被选记录");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                if (objViewInfoENEx.objViewRegion_List.IsCheck() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnDelRecord_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");


                    string strKeys = "";
                    ArrayList arrKeysLst = new ArrayList();
                    foreach (clsPrjTabFldENEx objPrjTabFldENEx in objViewInfoENEx.arrKeyPrjTabFldSet)
                    {
                        arrKeysLst.Add("\"" + objPrjTabFldENEx.FldName + "\"");
                    }
                    //objViewInfoENEx.arrKeyPrjTabFldSet.Count.objMainPrjTab.
                    strKeys = clsArray.Join(arrKeysLst, ",");

                    strCodeForCs.AppendFormat("\r\n" + "List<string> lstKeyValues = clsCommForWebForm.GetAllCheckedItemFromGv(gv{0}, \"chkCheckRec\", {1});",
                    objViewInfoENEx.TabName, strKeys);

                    strCodeForCs.AppendFormat("\r\n" + "if (lstKeyValues.Count == 0) ",
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                     objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnDelRecord_Click", "没有选择记录,请选择一个有效的表记录!", "生成代码");

                    strCodeForCs.AppendFormat("\r\n" + "lblMsg_List.Text = \"(errid:{0})没有选择记录,请选择一个有效的表记录!\";", strErrId);
                    strCodeForCs.Append("\r\n" + "return ;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");

                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "foreach (string strKeyValue in lstKeyValues)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "string[] strKeys = strKeyValue.Split(',');");
                    int intKeyIndex = 0;
                    foreach (clsPrjTabFldENEx objPrjTabFldEN in objViewInfoENEx.arrKeyPrjTabFldSet)
                    {
                        switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                        {
                            case "string":
                                strCodeForCs.AppendFormat("\r\n" + "{0} = strKeys[{1}];",
                                objPrjTabFldEN.KeyVarDefineStr, intKeyIndex++);
                                break;
                            case "int":
                                strCodeForCs.AppendFormat("\r\n" + "{0} = int.Parse(strKeys[{1}]);",
                                objPrjTabFldEN.KeyVarDefineStr, intKeyIndex++);
                                break;
                            case "long":
                                strCodeForCs.AppendFormat("\r\n" + "{0} = long.Parse(strKeys[{1}]);",
                                objPrjTabFldEN.KeyVarDefineStr, intKeyIndex++);
                                break;
                        }
                    }
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.DelRecord({1});", objViewInfoENEx.TabName, objViewInfoENEx.KeyPrivFuncFldNameLstStr);
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"在删除记录时出错!错误：{0}.(In {1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
                    strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    if (this.IsUseFunc)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}ByFunc();",
                              strTabName_Out4ListRegion);

                    }
                    else if (PrjTabEx_ListRegion.IsUseCache_TS() == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}Cache();",
                            strTabName_Out4ListRegion);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                            strTabName_Out4ListRegion);
                    }
                    strCodeForCs.Append("\r\n" + "}");
                }
                else if (objViewInfoENEx.objViewRegion_List.IsRadio() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnDelRecord_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string str{0} = (string) rd.Value;",
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "if (str{0} == null || str{0}.Trim().Length == 0) ",
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnDelRecord_Click", "没有选择记录,请选择一个有效的表记录!", "生成代码");

                    strCodeForCs.AppendFormat("\r\n" + "lblMsg.Text = \"(errid:{0})没有选择记录,请选择一个有效的表记录!\";", strErrId);

                    //strCodeForCs.Append("\r\n" + "lblMsg.Text = \"没有选择记录,请选择一个有效的表记录!\";");
                    strCodeForCs.Append("\r\n" + "return ;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "lblMsg.Text = \"\";");

                    switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                    {
                        case "string":
                            //							strCodeForCs.AppendFormat("\r\n" + "{0} = e.Item.Cells[{1}].Text;", 
                            //								objViewInfoENEx. objMainTabKeyField.ObjFieldTabENEx.PrivFuncName, intItemNum);
                            break;
                        case "int":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = int.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                        case "long":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = long.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                    }

                    strCodeForCs.AppendFormat("\r\n" + "cls{0}.DelRecord({1});",
                    objViewInfoENEx.TabName, objKeyField.PrivFuncName);

                    if (this.IsUseFunc)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}ByFunc();",
                              strTabName_Out4ListRegion);

                    }
                    else if (PrjTabEx_ListRegion.IsUseCache_TS() == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}Cache();",
                            strTabName_Out4ListRegion);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                            strTabName_Out4ListRegion);
                    }
                    strCodeForCs.Append("\r\n" + "}");
                }
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WebView_CS_btnDelRecordBySign_Click()
        {
            if (objViewInfoENEx.arrKeyPrjTabFldSet.Count == 1)
            {
                return GenbtnDelRecordBySign_Click4OneKeyword();
            }
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///标志性删除数据列表中多选的首条记录");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                if (objViewInfoENEx.objViewRegion_List.IsCheck() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnDelRecordBySign_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");


                    string strKeys = "";
                    ArrayList arrKeysLst = new ArrayList();
                    foreach (clsPrjTabFldENEx objPrjTabFldENEx in objViewInfoENEx.arrKeyPrjTabFldSet)
                    {
                        arrKeysLst.Add("\"" + objPrjTabFldENEx.FldName + "\"");
                    }
                    //objViewInfoENEx.arrKeyPrjTabFldSet.Count.objMainPrjTab.
                    strKeys = clsArray.Join(arrKeysLst, ",");

                    strCodeForCs.AppendFormat("\r\n" + "List<string> lstKeyValues = clsCommForWebForm.GetAllCheckedItemFromGv(gv{0}, \"chkCheckRec\", {1});",
                    objViewInfoENEx.TabName, strKeys);

                    strCodeForCs.AppendFormat("\r\n" + "if (lstKeyValues.Count == 0) ",
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                     objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnDelRecordBySign_Click", "没有选择记录,请选择一个有效的表记录!", "生成代码");

                    strCodeForCs.AppendFormat("\r\n" + "lblMsg_List.Text = \"(errid:{0})没有选择记录,请选择一个有效的表记录!\";", strErrId);
                    strCodeForCs.Append("\r\n" + "return ;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");

                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "foreach (string strKeyValue in lstKeyValues)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "string[] strKeys = strKeyValue.Split(',');");
                    int intKeyIndex = 0;
                    foreach (clsPrjTabFldENEx objPrjTabFldEN in objViewInfoENEx.arrKeyPrjTabFldSet)
                    {
                        switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                        {
                            case "string":
                                strCodeForCs.AppendFormat("\r\n" + "{0} = strKeys[{1}];",
                                objPrjTabFldEN.KeyVarDefineStr, intKeyIndex++);
                                break;
                            case "int":
                                strCodeForCs.AppendFormat("\r\n" + "{0} = int.Parse(strKeys[{1}]);",
                                objPrjTabFldEN.KeyVarDefineStr, intKeyIndex++);
                                break;
                            case "long":
                                strCodeForCs.AppendFormat("\r\n" + "{0} = long.Parse(strKeys[{1}]);",
                                objPrjTabFldEN.KeyVarDefineStr, intKeyIndex++);
                                break;
                        }
                    }
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.DelRecordBySign({1});", objViewInfoENEx.TabName, objViewInfoENEx.KeyPrivFuncFldNameLstStr);
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"在根据标志删除记录时出错!错误：{0}.(In {1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
                    strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
           
                    strCodeForCs.Append("\r\n" + "}");
                    if (this.IsUseFunc)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}ByFunc();",
                              strTabName_Out4ListRegion);

                    }
                    else if (PrjTabEx_ListRegion.IsUseCache_TS() == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}Cache();",
                            strTabName_Out4ListRegion);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                            strTabName_Out4ListRegion);
                    }
                    strCodeForCs.Append("\r\n" + "}");
                }
                else if (objViewInfoENEx.objViewRegion_List.IsRadio() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnDelRecord_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string str{0} = (string) rd.Value;",
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "if (str{0} == null || str{0}.Trim().Length == 0) ",
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnDelRecord_Click", "没有选择记录,请选择一个有效的表记录!", "生成代码");

                    strCodeForCs.AppendFormat("\r\n" + "lblMsg.Text = \"(errid:{0})没有选择记录,请选择一个有效的表记录!\";", strErrId);

                    //strCodeForCs.Append("\r\n" + "lblMsg.Text = \"没有选择记录,请选择一个有效的表记录!\";");
                    strCodeForCs.Append("\r\n" + "return ;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "lblMsg.Text = \"\";");

                    switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                    {
                        case "string":
                            //							strCodeForCs.AppendFormat("\r\n" + "{0} = e.Item.Cells[{1}].Text;", 
                            //								objViewInfoENEx. objMainTabKeyField.ObjFieldTabENEx.PrivFuncName, intItemNum);
                            break;
                        case "int":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = int.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                        case "long":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = long.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                    }

                    strCodeForCs.AppendFormat("\r\n" + "cls{0}.DelRecord({1});",
                    objViewInfoENEx.TabName, objKeyField.PrivFuncName);

                    if (this.IsUseFunc)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}ByFunc();",
                              strTabName_Out4ListRegion);

                    }
                    else if (PrjTabEx_ListRegion.IsUseCache_TS() == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}Cache();",
                            strTabName_Out4ListRegion);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                            strTabName_Out4ListRegion);
                    }
                    strCodeForCs.Append("\r\n" + "}");
                }
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WebView_CS_btnUnDelRecordBySign_Click()
        {
            if (objViewInfoENEx.arrKeyPrjTabFldSet.Count == 1)
            {
                return GenbtnUnDelRecordBySign_Click4OneKeyword();
            }
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///标志性删除数据列表中多选的首条记录");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                if (objViewInfoENEx.objViewRegion_List.IsCheck() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnUnDelRecordBySign_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");


                    string strKeys = "";
                    ArrayList arrKeysLst = new ArrayList();
                    foreach (clsPrjTabFldENEx objPrjTabFldENEx in objViewInfoENEx.arrKeyPrjTabFldSet)
                    {
                        arrKeysLst.Add("\"" + objPrjTabFldENEx.FldName + "\"");
                    }
                    //objViewInfoENEx.arrKeyPrjTabFldSet.Count.objMainPrjTab.
                    strKeys = clsArray.Join(arrKeysLst, ",");

                    strCodeForCs.AppendFormat("\r\n" + "List<string> lstKeyValues = clsCommForWebForm.GetAllCheckedItemFromGv(gv{0}, \"chkCheckRec\", {1});",
                    objViewInfoENEx.TabName, strKeys);

                    strCodeForCs.AppendFormat("\r\n" + "if (lstKeyValues.Count == 0) ",
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                     objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnDelRecordBySign_Click", "没有选择记录,请选择一个有效的表记录!", "生成代码");

                    strCodeForCs.AppendFormat("\r\n" + "lblMsg_List.Text = \"(errid:{0})没有选择记录,请选择一个有效的表记录!\";", strErrId);
                    strCodeForCs.Append("\r\n" + "return ;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");

                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "foreach (string strKeyValue in lstKeyValues)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "string[] strKeys = strKeyValue.Split(',');");
                    int intKeyIndex = 0;
                    foreach (clsPrjTabFldENEx objPrjTabFldEN in objViewInfoENEx.arrKeyPrjTabFldSet)
                    {
                        switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                        {
                            case "string":
                                strCodeForCs.AppendFormat("\r\n" + "{0} = strKeys[{1}];",
                                objPrjTabFldEN.KeyVarDefineStr, intKeyIndex++);
                                break;
                            case "int":
                                strCodeForCs.AppendFormat("\r\n" + "{0} = int.Parse(strKeys[{1}]);",
                                objPrjTabFldEN.KeyVarDefineStr, intKeyIndex++);
                                break;
                            case "long":
                                strCodeForCs.AppendFormat("\r\n" + "{0} = long.Parse(strKeys[{1}]);",
                                objPrjTabFldEN.KeyVarDefineStr, intKeyIndex++);
                                break;
                        }
                    }
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.UnDelRecordBySign({1});", objViewInfoENEx.TabName, objViewInfoENEx.KeyPrivFuncFldNameLstStr);
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"在恢复根据标志删除记录时出错!错误：{0}.(In {1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
                    strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");

                    strCodeForCs.Append("\r\n" + "}");
                    if (this.IsUseFunc)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}ByFunc();",
                              strTabName_Out4ListRegion);

                    }
                    else if (PrjTabEx_ListRegion.IsUseCache_TS() == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}Cache();",
                            strTabName_Out4ListRegion);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                            strTabName_Out4ListRegion);
                    }
                    strCodeForCs.Append("\r\n" + "}");
                }
                else if (objViewInfoENEx.objViewRegion_List.IsRadio() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnDelRecord_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string str{0} = (string) rd.Value;",
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "if (str{0} == null || str{0}.Trim().Length == 0) ",
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnDelRecord_Click", "没有选择记录,请选择一个有效的表记录!", "生成代码");

                    strCodeForCs.AppendFormat("\r\n" + "lblMsg.Text = \"(errid:{0})没有选择记录,请选择一个有效的表记录!\";", strErrId);

                    //strCodeForCs.Append("\r\n" + "lblMsg.Text = \"没有选择记录,请选择一个有效的表记录!\";");
                    strCodeForCs.Append("\r\n" + "return ;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "lblMsg.Text = \"\";");

                    switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                    {
                        case "string":
                            //							strCodeForCs.AppendFormat("\r\n" + "{0} = e.Item.Cells[{1}].Text;", 
                            //								objViewInfoENEx. objMainTabKeyField.ObjFieldTabENEx.PrivFuncName, intItemNum);
                            break;
                        case "int":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = int.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                        case "long":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = long.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                    }

                    strCodeForCs.AppendFormat("\r\n" + "cls{0}.DelRecord({1});",
                    objViewInfoENEx.TabName, objKeyField.PrivFuncName);

                    if (this.IsUseFunc)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}ByFunc();",
                              strTabName_Out4ListRegion);

                    }
                    else if (PrjTabEx_ListRegion.IsUseCache_TS()== true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}Cache();",
                            strTabName_Out4ListRegion);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                            strTabName_Out4ListRegion);
                    }
                    strCodeForCs.Append("\r\n" + "}");
                }
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_WebView_CS_PutDataToClass()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            int intIndex = 0;
            try
            {
                ///生成仅有变量;
                //strCodeForCs.Append("\r\n ///1生成从界面层到逻辑层的数据传输函数代码");
                if ((mbolIsUseCtl == false))
                {
                    ///从类中取数据传给窗体:protected void PutDataToClass;
                    strCodeForCs.AppendFormat("\r\n" + "protected void PutDataTo{0}Class(cls" + objViewInfoENEx.TabName + "EN pobj" + objViewInfoENEx.TabName + "EN)", objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    IEnumerable<clsEditRegionFldsENEx> arrEditRegionFld = objViewInfoENEx.arrEditRegionFldSet4InUse
                         .Where(x => x.IsPrimaryKey_Identity() == false)
                         .Where(x => x.InUse);

                    foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                    {
                       if (objEditRegionFldsEx.FieldTypeId(objViewInfoENEx.PrjId) == enumFieldType.Log_UpdDate_13)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = clsDateTime.getTodayDateTimeStr(0);\\(字段类型:{2},字段长度:{3},是否可空:{3})",
                                objViewInfoENEx.TabName, objEditRegionFldsEx.FldName);
                            continue;
                        }
                        if (objEditRegionFldsEx.FieldTypeId(objViewInfoENEx.PrjId) == enumFieldType.Log_UpdUser_14)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = clsCommonSession.UserId;\\(字段类型:{2},字段长度:{3},是否可空:{3})",
                                objViewInfoENEx.TabName, objEditRegionFldsEx.FldName);
                            continue;
                        }
                        switch (objEditRegionFldsEx.ObjFieldTabENEx.CsType())
                        {
                            case "int":
                                strCodeForCs.AppendFormat("\r\n" + "if (txt{0}.Text.Trim() == \"\")", objEditRegionFldsEx.FldName);
                                strCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = 0;\\(字段类型:{2},字段长度:{3},是否可空:{3})",
                                objViewInfoENEx.TabName, objEditRegionFldsEx.FldName);

                                strCodeForCs.Append("\r\n" + "else");
                                strCodeForCs.Append("\r\n" + "pobj" + objViewInfoENEx.TabName + "EN." + objEditRegionFldsEx.FldName + " = int.Parse(" + objEditRegionFldsEx.CtrlId + ".Text);");

                                strCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);
                                strCodeForCs.AppendFormat("" + "(说明:{3};字段类型:{0};字段长度:{1};,是否可空:{2})",
                                objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                                objEditRegionFldsEx.ObjFieldTabENEx.FldLength,
                                objEditRegionFldsEx.ObjFieldTabENEx.IsNull,
                                objEditRegionFldsEx.ObjFieldTabENEx.MemoInTab);
                                break;
                            default:
                                strCodeForCs.Append("\r\n" + "pobj" + objViewInfoENEx.TabName + "EN." + objEditRegionFldsEx.FldName + " = " + objEditRegionFldsEx.CtrlId + ".Text;");
                                strCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);
                                strCodeForCs.AppendFormat("" + "(说明:{3};字段类型:{0};字段长度:{1};,是否可空:{2})",
                                objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                                objEditRegionFldsEx.ObjFieldTabENEx.FldLength,
                                objEditRegionFldsEx.ObjFieldTabENEx.IsNull,
                                objEditRegionFldsEx.ObjFieldTabENEx.MemoInTab);
                                break;
                        }

                    }
                    strCodeForCs.Append("\r\n" + "}");
                }
                else
                {
                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.Append("\r\n /// 函数功能:把界面上的属性数据传到类对象中");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.AppendFormat("\r\n /// <param name = \"pobj{0}EN\">数据传输的目的类对象</param>",
                    objViewInfoENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "protected void PutDataTo{0}Class(cls{1}EN pobj{2}EN)",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                 
                    IEnumerable<clsEditRegionFldsENEx> arrEditRegionFld = objViewInfoENEx.arrEditRegionFldSet4InUse
                       .Where(x => x.IsPrimaryKey_Identity() == false)
                       .Where(x => x.InUse);
                    intIndex = 0;
                    foreach (clsEditRegionFldsENEx objEditRegionFldsEx in arrEditRegionFld)
                    {
                        intIndex++;
                   
                        string strTemp = "";
                        if (intIndex == 1)
                        {
                            strTemp = GetCode4FieldInPutDataToClass_First(objEditRegionFldsEx, objViewInfoENEx);
                        }
                        else if (intIndex == arrEditRegionFld.Count())
                        {
                            strTemp = GetCode4FieldInPutDataToClass_Last(objEditRegionFldsEx, objViewInfoENEx);
                        }
                        else
                        {
                            strTemp = GetCode4FieldInPutDataToClass(objEditRegionFldsEx, objViewInfoENEx);
                        }
                        strCodeForCs.AppendFormat("{0}", strTemp);

                    }
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "");
                }
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        //生成GridView行删除的事件代码
        public string Gen_WebView_CS_btnCancelEdit_Click()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.AppendFormat("\r\n" + "/// <summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// 事件函数:取消编辑状态,退回到列表状态");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n" + "/// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"sender\"></param>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"e\"></param>");

                strCodeForCs.AppendFormat("\r\n" + "protected void btnCancel{0}Edit_Click(object sender, EventArgs e)",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                //if (objViewInfoENEx.ViewTypeCode != (int)enumViewTypeCodeTab.Table_Insert_1)
                //{
                //    strCodeForCs.AppendFormat("\r\n" + "Disp{0}ListRegion();",
                //    objViewInfoENEx.TabName);
                //}
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

        public string Gen_WebView_CS_btnOkUpd_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 函数功能:事件函数,当单击<确定修改>时发生的事件函数,");
                strCodeForCs.Append("\r\n /// 具体功能为把界面内容同步数据库中,把界面内容保存到数据库中");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <param name = \"sender\"></param>");
                strCodeForCs.Append("\r\n /// <param name = \"e\"></param>");
                strCodeForCs.Append("\r\n" + "protected void btnOKUpd_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strCommandText;");
                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{1}EN;",
                objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "Button btnTemp;");
                strCodeForCs.Append("\r\n" + "btnTemp = (Button) sender;");
                strCodeForCs.Append("\r\n" + "strCommandText = btnTemp.Text;");
                strCodeForCs.Append("\r\n" + "switch(strCommandText)");
                strCodeForCs.Append("\r\n" + "{");
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd)
                {

                    strCodeForCs.Append("\r\n" + "case \"添加\":");
                    if (objViewInfoENEx.arrFeatureId.Contains(enumPrjFeature.AddNewRecordWithMaxId_0183))
                    {
                        strCodeForCs.AppendFormat("\r\n" + "Add{0}RecordWithMaxId();",
                     objViewInfoENEx.TabName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "Add{0}Record();",
                        objViewInfoENEx.TabName);
                    }
                    strCodeForCs.Append("\r\n" + "break;				");
                    strCodeForCs.Append("\r\n" + "case \"确认添加\":");
                    strCodeForCs.Append("\r\n" + "//这是一个单表的插入的代码,由于逻辑层太简单,");
                    strCodeForCs.Append("\r\n" + "//就把逻辑层合并到控制层,");
                    strCodeForCs.Append("\r\n" + "if (btnOKUpd.CommandArgument == \"AddWithMaxId\")");
                    strCodeForCs.Append("\r\n" + "{");
                    if (objViewInfoENEx.arrFeatureId.Exists(x => x == enumPrjFeature.AddNewRecordWithMaxId_0183) == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "Add{0}RecordWithMaxIdSave();",
                       objViewInfoENEx.TabName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "//Add{0}RecordWithMaxIdSave();",
                       objViewInfoENEx.TabName);
                    }
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "else");
                    strCodeForCs.Append("\r\n" + "{");
                    if (objViewInfoENEx.arrFeatureId.Exists(x => x == enumPrjFeature.AddNewRecordWithMaxId_0183) == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "//Add{0}RecordSave();",
                    objViewInfoENEx.TabName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "Add{0}RecordSave();",
                    objViewInfoENEx.TabName);
                    }
                    strCodeForCs.Append("\r\n" + "}");

                    strCodeForCs.Append("\r\n" + "break;");
                }
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate)
                {
                    strCodeForCs.Append("\r\n" + "case \"确认修改\":");
                    strCodeForCs.Append("\r\n" + "//这是一个单表的修改的代码,由于逻辑层太简单,");
                    strCodeForCs.Append("\r\n" + "//就把逻辑层合并到控制层,");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = (cls{0}EN) Session[\"obj{0}EN\"];",
                    objViewInfoENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "Update{0}RecordSave(obj{0}EN);",
                    objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "break;");
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

        //生成修改记录准备过程代码
        public string Gen_WebView_CS_UpdateRecord()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                //生成修改记录准备过程代码 for C#;
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 为修改记录做准备过程,把给定关键字的记录字段值显示在用户控件上");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n" + "protected void Update{1}Record({0})",
                objViewInfoENEx.KeyVarDefineLstStr,
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "//操作步骤:(总共2步)");
                strCodeForCs.Append("\r\n" + "//1、绑定编辑区的下拉框");
                strCodeForCs.Append("\r\n" + "//2、显示该关键字记录的内容在界面上；");
                strCodeForCs.Append("\r\n" + "//3、清空提示信息的内容,同时使<确定修改>按钮可用；");
                strCodeForCs.Append("\r\n" + "");

                strCodeForCs.Append("\r\n" + "//1、绑定编辑区的下拉框");
                strCodeForCs.Append("\r\n" + "BindDdl4EditRegion();");

                strCodeForCs.Append("\r\n" + "//2、显示该关键字记录的内容在界面上；");
                strCodeForCs.AppendFormat("\r\n" + "ShowData({0});",
                objViewInfoENEx.KeyPrivFuncFldNameLstStr);
                strCodeForCs.Append("\r\n" + "//3、清空提示信息的内容,同时使<确定修改>按钮可用；");
                strCodeForCs.Append("\r\n" + "btnOKUpd.Enabled = true;");
                if (objKeyField.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0}1.SetKeyReadOnly(true);",
                            this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003));
                }
                strCodeForCs.Append("\r\n" + "btnOKUpd.Text = \"确认修改\";");
                strCodeForCs.AppendFormat("\r\n" + "btnCancel{0}Edit.Text = \"取消修改\";",
                objViewInfoENEx.TabName);

                strCodeForCs.Append("\r\n" + "lblMsg_Edit.Text = \"\";");
                //如果有查询区域
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveQuery)
                {
                    strCodeForCs.AppendFormat("\r\n" + "DispEdit{0}Region();", objViewInfoENEx.TabName);
                }
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


        public string Gen_WebView_CS_CopyRecord()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                List<clsFeatureRegionFldsENEx> arrFeature_AdditionalCopy = objViewInfoENEx.arrFeatureRegionFlds.Where(x=>x.FieldTypeId == enumFieldType.AdditionalCopyField_15).ToList();

                //生成修改记录准备过程代码 for C#;
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 复制记录,把给定关键字的记录内容复制一个新记录,把名称字段值的前面加上\"Copy_\"");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n" + "protected void CopyRecord({0})",
                objViewInfoENEx.KeyVarDefineLstStr);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "K_{1}_{0} myKey = new K_{1}_{0}({2});", objViewInfoENEx.TabName_In, objKeyField.FldName, objKeyField.PrivFuncName);
                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = myKey.GetObj();", objViewInfoENEx.TabName_In, objKeyField.FldName);
                if (objKeyField.PrimaryTypeId != enumPrimaryType.Identity_02)
                {
                    if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = cls{0}BL.GetMaxStrId_S();", objViewInfoENEx.TabName_In, objKeyField.FldName);
                    }
                    else
                    {
                        if (objKeyField.CsType == "string")
                        {
                            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = cls{0}BL.GetMaxStrId_S();", objViewInfoENEx.TabName_In, objKeyField.FldName);
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = 999;", objViewInfoENEx.TabName_In, objKeyField.FldName);
                        }
                    }
                }
                if (arrFeature_AdditionalCopy.Count()>0)
                {
                    clsFeatureRegionFldsENEx objFeature_AdditionalCopy = arrFeature_AdditionalCopy[0];
                    string strCopyValue = objFeature_AdditionalCopy.DefaultValue;
                    if (string.IsNullOrEmpty(strCopyValue)) strCopyValue = "Copy_";
                    clsFieldTabEN objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objFeature_AdditionalCopy.ReleFldId, objViewInfoENEx.PrjId);
                    if (objFieldTab == null)
                    {
                        var arrPrjTabFld = clsPrjTabFldBLEx.GetObjLstByTabIdCache(objViewInfoENEx.MainTabId, objViewInfoENEx.PrjId);
                        arrPrjTabFld = arrPrjTabFld.Where(x => x.FieldTypeId == enumFieldType.NameField_03).ToList();
                        if (arrPrjTabFld.Count == 0)
                        {
                            string strMsg = string.Format("当前表:[{0}]没有名称字段!", objViewInfoENEx.TabName);
                            throw new Exception(strMsg);
                        }
                        objFieldTab = clsFieldTabBL.GetObjByFldIdCache(arrPrjTabFld[0].FldId, objViewInfoENEx.PrjId);
                    }
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}(\"{2}\" + obj{0}EN.{1});", 
                        objViewInfoENEx.TabName_In, objFieldTab.FldName, strCopyValue);
                }
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.AddNewRecord();", objViewInfoENEx.TabName_In, objKeyField.FldName);


                if (this.IsUseFunc)
                {
                    strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}ByFunc();",
                          strTabName_Out4ListRegion);

                }
                else if (PrjTabEx_ListRegion.IsUseCache_TS() == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}Cache();",
                        strTabName_Out4ListRegion);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                        strTabName_Out4ListRegion);
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"在克隆记录时出错!错误：{0}.(In {1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
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


        //生成修改存盘准备过程代码
        public string Gen_WebView_CS_UpdateRecordSave()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                //修改存盘准备过程代码 for C#
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 修改记录存盘到数据表中");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要修改的实体对象</param>", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n /// <returns>修改是否成功？</returns>");
                strCodeForCs.AppendFormat("\r\n" + "protected bool Update{0}RecordSave(cls{0}EN obj{0}EN)",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//操作步骤:");
                strCodeForCs.Append("\r\n" + "//1、检查控件中输入数据类型是否正确");
                strCodeForCs.Append("\r\n" + "//2、把值从界面层传到逻辑层或数据实体层");
                strCodeForCs.Append("\r\n" + "//3.1、检查传进去的对象属性是否合法");
                strCodeForCs.Append("\r\n" + "//3.2、检查唯一性");
                strCodeForCs.Append("\r\n" + "//4、把数据实体层的数据存贮到数据库中");
                strCodeForCs.Append("\r\n" + "//5、把修改后的内容显示在GridView中");
                strCodeForCs.Append("\r\n" + "string strMsg;	//专门用于传递信息的变量");
                strCodeForCs.Append("\r\n" + "string strResult = \" \";	//用于传递在检验对象属性时结果值的变量");

                strCodeForCs.Append("\r\n" + "//1、检查控件中输入数据类型是否正确");
                strCodeForCs.AppendFormat("\r\n" + "if (!{0}1.IsValid(ref strResult))",
                        this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003));
                strCodeForCs.Append("\r\n" + "{");
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
          objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Update{0}RecordSave", "控件中输入数据类型不正确请检查!", "生成代码");

                strCodeForCs.AppendFormat("\r\n" + "lblMsg_Edit.Text = \"(errid:{0})控件中输入数据类型不正确请检查!\";", strErrId);

                //strCodeForCs.Append("\r\n" + "lblMsg_Edit.Text = \"控件中输入数据类型不正确请检查!\";");
                strCodeForCs.Append("\r\n" + "return false;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//2、把值从界面层传到逻辑层或数据实体层");
                strCodeForCs.AppendFormat("\r\n" + "PutDataTo{0}Class(obj{1}EN);		//把界面的值传到", objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch(Exception objException)");
                strCodeForCs.Append("\r\n" + "{");

                strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Update{0}RecordSave", "为对象赋值不成功!", "生成代码");

                strCodeForCs.AppendFormat("\r\n" + "strMsg = \"(errid:{0})为对象赋值不成功!\" + objException.Message;", strErrId);
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "lblMsg_Edit.Text = strMsg;");
                strCodeForCs.Append("\r\n" + "return false;");

                strCodeForCs.Append("\r\n" + "}");

       
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//3、使用扩展修改方法,到扩展逻辑层去修改");
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.UpdateRecordEx();", objViewInfoENEx.TabName);

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch(Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "strMsg = \"修改记录不成功!\" + objException.Message;");
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "lblMsg_Edit.Text = strMsg;");
                strCodeForCs.Append("\r\n" + "return false; ");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "strMsg = \"修改记录成功!\";");
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "lblMsg_Edit.Text = \"修改记录成功!\";");
                //如果有查询区域
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveQuery)
                {

                    strCodeForCs.Append("\r\n" + "//5、把修改后的内容显示在GridView中");
                    if (bolIsUseWuc4Gv == true)
                    {
                        if (this.IsUseFunc)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}ByFunc();",
                                  strTabName_Out4ListRegion);

                        }
                        else if (PrjTabEx_ListRegion.IsUseCache_TS() == true)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}Cache();",
                                strTabName_Out4ListRegion);
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                                strTabName_Out4ListRegion);
                        }
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();", strTabName_Out4ListRegion);
                    }
                    strCodeForCs.AppendFormat("\r\n" + "Disp{0}ListRegion();", objViewInfoENEx.TabName);
                }
                strCodeForCs.AppendFormat("\r\n" + "{0}1.Clear();//添空控件中的内容",
                        this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003));
                strCodeForCs.Append("\r\n" + "//恢复<确认修改>变成<添加>");
                strCodeForCs.Append("\r\n" + "btnOKUpd.Text = \"添加\";");
                strCodeForCs.AppendFormat("\r\n" + "btnCancel{0}Edit.Text = \"取消编辑\";",
                objViewInfoENEx.TabName);

                strCodeForCs.Append("\r\n" + "//跳转到列表中刚刚的记录处,使用锚点功能。");

                strCodeForCs.AppendFormat("\r\n" + "this.ClientScript.RegisterStartupScript(this.GetType(), \"Go-Anchor\", string.Format(\"this.location.href = '#A_{0}{{0}}'\", obj{0}EN.{3}.ToString().Trim()), true);",
                            objViewInfoENEx.TabName, "{", "}", objKeyField.ObjFieldTabENEx.FldName);


                strCodeForCs.Append("\r\n" + "return true; ");

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

        //生成修改存盘准备过程代码
        public string Gen_WebView_CS_UpdateRecordSave_Old()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                //修改存盘准备过程代码 for C#
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 修改记录存盘到数据表中");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要修改的实体对象</param>", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n /// <returns>修改是否成功？</returns>");
                strCodeForCs.AppendFormat("\r\n" + "protected bool Update{0}RecordSave_Old(cls{0}EN obj{0}EN)",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//操作步骤:");
                strCodeForCs.Append("\r\n" + "//1、检查控件中输入数据类型是否正确");
                strCodeForCs.Append("\r\n" + "//2、把值从界面层传到逻辑层或数据实体层");
                strCodeForCs.Append("\r\n" + "//3.1、检查传进去的对象属性是否合法");
                strCodeForCs.Append("\r\n" + "//3.2、检查唯一性");
                strCodeForCs.Append("\r\n" + "//4、把数据实体层的数据存贮到数据库中");
                strCodeForCs.Append("\r\n" + "//5、把修改后的内容显示在GridView中");
                strCodeForCs.Append("\r\n" + "string strMsg;	//专门用于传递信息的变量");
                strCodeForCs.Append("\r\n" + "string strResult = \" \";	//用于传递在检验对象属性时结果值的变量");

                strCodeForCs.Append("\r\n" + "//1、检查控件中输入数据类型是否正确");
                strCodeForCs.AppendFormat("\r\n" + "if (!{0}1.IsValid(ref strResult))",
                        this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003));
                strCodeForCs.Append("\r\n" + "{");
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
          objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Update{0}RecordSave_Old", "控件中输入数据类型不正确请检查!", "生成代码");

                strCodeForCs.AppendFormat("\r\n" + "lblMsg_Edit.Text = \"(errid:{0})控件中输入数据类型不正确请检查!\";", strErrId);

                //strCodeForCs.Append("\r\n" + "lblMsg_Edit.Text = \"控件中输入数据类型不正确请检查!\";");
                strCodeForCs.Append("\r\n" + "return false;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//2、把值从界面层传到逻辑层或数据实体层");
                strCodeForCs.AppendFormat("\r\n" + "PutDataTo{0}Class(obj{1}EN);		//把界面的值传到", objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch(Exception objException)");
                strCodeForCs.Append("\r\n" + "{");

                strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Update{0}RecordSave_Old", "为对象赋值不成功!", "生成代码");

                strCodeForCs.AppendFormat("\r\n" + "strMsg = \"(errid:{0})为对象赋值不成功!\" + objException.Message;", strErrId);
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "lblMsg_Edit.Text = strMsg;");
                strCodeForCs.Append("\r\n" + "return false;");

                strCodeForCs.Append("\r\n" + "}");


                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//3.1、检查传进去的对象属性是否合法");
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.CheckPropertyNew();", objViewInfoENEx.TabName);
                //检查唯一性------------------------------------------------------

                string strDuplicateInfo = "";
                bool bolIsFirst = true;
                //检查唯一性------------------------------------------------------
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.IsTabUnique() == true
                    && objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId != enumFieldType.KeyField_02)
                    {
                        if (bolIsFirst == true)
                        {
                            strDuplicateInfo += string.Format("{0}({1})",
                                  objEditRegionFldsEx.LabelCaption,
                                objEditRegionFldsEx.FldName);
                            bolIsFirst = false;
                        }
                        else
                        {
                            strDuplicateInfo += string.Format(",{0}({1})",
                              objEditRegionFldsEx.LabelCaption,
                               objEditRegionFldsEx.FldName);
                        }
                    }
                }
                if (string.IsNullOrEmpty(strDuplicateInfo) == false)
                {
                    strCodeForCs.Append("\r\n" + "//3.2、检查唯一性");
                    strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.Check{0}Uniqueness() == false)",
                          objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "strMsg = \"({0})不能重复!\";",
                           strDuplicateInfo);
                    strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                    strCodeForCs.Append("\r\n" + "return false;");
                    strCodeForCs.Append("\r\n" + "}");

                }
                //检查唯一性 == == == == == == == == == == == == == == == == == == == == == == == == 

                strCodeForCs.Append("\r\n" + "//4、把数据实体层的数据存贮到数据库中");
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Update();", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch(Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "strMsg = \"修改记录不成功!\" + objException.Message;");
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "lblMsg_Edit.Text = strMsg;");
                strCodeForCs.Append("\r\n" + "return false; ");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "strMsg = \"修改记录成功!\";");
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "lblMsg_Edit.Text = \"修改记录成功!\";");
                //如果有查询区域
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveQuery)
                {

                    strCodeForCs.Append("\r\n" + "//5、把修改后的内容显示在GridView中");
                    if (bolIsUseWuc4Gv == true)
                    {
                        if (this.IsUseFunc)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}ByFunc();",
                                  strTabName_Out4ListRegion);

                        }
                        else if (PrjTabEx_ListRegion.IsUseCache_TS() == true)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}Cache();",
                                strTabName_Out4ListRegion);
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                                strTabName_Out4ListRegion);
                        }
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();", strTabName_Out4ListRegion);
                    }
                    strCodeForCs.AppendFormat("\r\n" + "Disp{0}ListRegion();", objViewInfoENEx.TabName);
                }
                strCodeForCs.AppendFormat("\r\n" + "{0}1.Clear();//添空控件中的内容",
                        this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003));
                strCodeForCs.Append("\r\n" + "//恢复<确认修改>变成<添加>");
                strCodeForCs.Append("\r\n" + "btnOKUpd.Text = \"添加\";");
                strCodeForCs.AppendFormat("\r\n" + "btnCancel{0}Edit.Text = \"取消编辑\";",
                objViewInfoENEx.TabName);

                strCodeForCs.Append("\r\n" + "//跳转到列表中刚刚的记录处,使用锚点功能。");

                strCodeForCs.AppendFormat("\r\n" + "this.ClientScript.RegisterStartupScript(this.GetType(), \"Go-Anchor\", string.Format(\"this.location.href = '#A_{0}{{0}}'\", obj{0}EN.{3}.ToString().Trim()), true);",
                            objViewInfoENEx.TabName, "{", "}", objKeyField.ObjFieldTabENEx.FldName);


                strCodeForCs.Append("\r\n" + "return true; ");

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

        private string GetCode4FieldInPutDataToClass_First(clsEditRegionFldsENEx objEditRegionFldsEx, clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder sbCodeForCs = new StringBuilder();
            if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                  && objEditRegionFldsEx.PrimaryTypeId()== clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }

            if (objEditRegionFldsEx.FieldTypeId(objViewInfoENEx.PrjId) == enumFieldType.Log_UpdDate_13)
            {
                sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.Set{1}(clsDateTime.getTodayDateTimeStr(0))//(字段类型:{2},字段长度:{3},是否可空:{3})",
                    objViewInfoENEx.TabName, objEditRegionFldsEx.FldName,
                    objEditRegionFldsEx.ObjFieldTabENEx.CsType(),
                    objEditRegionFldsEx.ObjFieldTabENEx.FldLength,
                    objEditRegionFldsEx.IsTabNullable());
                return sbCodeForCs.ToString();
            }
            if (objEditRegionFldsEx.FieldTypeId(objViewInfoENEx.PrjId) == enumFieldType.Log_UpdUser_14)
            {
                sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.Set{1}(clsCommonSession.UserId)//(字段类型:{2},字段长度:{3},是否可空:{3})",
                    objViewInfoENEx.TabName, objEditRegionFldsEx.FldName,
                    objEditRegionFldsEx.ObjFieldTabENEx.CsType(),
                    objEditRegionFldsEx.ObjFieldTabENEx.FldLength,
                    objEditRegionFldsEx.IsTabNullable());
                return sbCodeForCs.ToString();
            }

            if (objEditRegionFldsEx.FldOpTypeId() == "0002")
            {
                sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.Set{1}({2}1.{3});",
              objViewInfoENEx.TabName, objEditRegionFldsEx.FldName, this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003), objEditRegionFldsEx.FldName);
                sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

                return sbCodeForCs.ToString();
            }
            //if (objEditRegionFldsEx.CtlTypeId == enumCtlType.CacheClassifyField_37)
            //{
            //    sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.Set{1}({2})",
            // objViewInfoENEx.TabName, objEditRegionFldsEx.FldName, thisCacheClassify4View.VarDef4Fld);

            //}
            //else
            //{
                sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.Set{1}({2}1.{3})",
            objViewInfoENEx.TabName, objEditRegionFldsEx.FldName, this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003), objEditRegionFldsEx.FldName);
            //}
            sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

            return sbCodeForCs.ToString();
        }
        private string GetCode4FieldInPutDataToClass_Last(clsEditRegionFldsENEx objEditRegionFldsEx, clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder sbCodeForCs = new StringBuilder();
            if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                  && objEditRegionFldsEx.PrimaryTypeId()== clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }

            if (objEditRegionFldsEx.FieldTypeId(objViewInfoENEx.PrjId) == enumFieldType.Log_UpdDate_13)
            {
                sbCodeForCs.AppendFormat("\r\n" + ".Set{1}(clsDateTime.getTodayDateTimeStr(0));//(字段类型:{2},字段长度:{3},是否可空:{3})",
                    objViewInfoENEx.TabName, objEditRegionFldsEx.FldName,
                    objEditRegionFldsEx.ObjFieldTabENEx.CsType(),
                    objEditRegionFldsEx.ObjFieldTabENEx.FldLength,
                    objEditRegionFldsEx.IsTabNullable());
                return sbCodeForCs.ToString();
            }
            if (objEditRegionFldsEx.FieldTypeId(objViewInfoENEx.PrjId) == enumFieldType.Log_UpdUser_14)
            {
                sbCodeForCs.AppendFormat("\r\n" + ".Set{1}(clsCommonSession.UserId);//(字段类型:{2},字段长度:{3},是否可空:{3})",
                    objViewInfoENEx.TabName, objEditRegionFldsEx.FldName,
                    objEditRegionFldsEx.ObjFieldTabENEx.CsType(),
                    objEditRegionFldsEx.ObjFieldTabENEx.FldLength,
                    objEditRegionFldsEx.IsTabNullable());
                return sbCodeForCs.ToString();
            }
            
            if (objEditRegionFldsEx.FldOpTypeId() == "0002")
            {
                sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.Set{1}( {2}1.{3});",
              objViewInfoENEx.TabName, objEditRegionFldsEx.FldName, this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003), objEditRegionFldsEx.FldName);
                sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

                return sbCodeForCs.ToString();
            }
            //if (objEditRegionFldsEx.CtlTypeId == enumCtlType.CacheClassifyField_37)
            //{
            //    sbCodeForCs.AppendFormat("\r\n" + ".Set{1}({2});",
            // objViewInfoENEx.TabName, objEditRegionFldsEx.FldName, thisCacheClassify4View.VarDef4Fld);

            //}
            //else
            //{
                sbCodeForCs.AppendFormat("\r\n" + ".Set{1}({2}1.{3});",
            objViewInfoENEx.TabName, objEditRegionFldsEx.FldName, this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003), objEditRegionFldsEx.FldName);
            //}
            sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

            return sbCodeForCs.ToString();
        }

        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(WebViewControlCode4CSharp);
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
            objViewInfoENEx.WebFormName = objViewInfoENEx.ViewName;

            this.ClsName = objViewInfoENEx.ViewName;
            objViewInfoENEx.ClsName = this.ClsName;
        }

        protected string GenRefDomainName()
        {
            string strFuncName = "";
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

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();

        }

        /// <summary>
        // 生成权限有关判断权限的代码
        /// </summary>
        /// <returns></returns>
        public string GenPotenceRelaCode()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成仅有变量;
                strCodeForCs.AppendFormat("\r\n" + "vsViewName = \"{0}\";", objViewInfoENEx.ViewCnName);
                strCodeForCs.AppendFormat("\r\n" + "vsTabName = string.Format(\"{{0}}\", cls{0}EN._CurrTabName);",
                            objViewInfoENEx.TabName_Out);

                //strCodeForCs.Append("\r\n" + "//生成权限有关判断权限的代码");
                ////获取当前用户的权限等级编号
                //strCodeForCs.Append("\r\n" + "//根据等级权限编号来确定用户可以使用什么功能,等级编号方式:1为最大2其次,依此类推");
                //strCodeForCs.Append("\r\n" + "switch (vsPotenceLevel)");
                //strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.Append("\r\n" + "case \"0\":");
                //strCodeForCs.Append("\r\n" + "Response.Redirect(\"../error.aspx\");");
                //strCodeForCs.Append("\r\n" + "break;");
                //strCodeForCs.Append("\r\n" + "case \"1\":");
                //strCodeForCs.Append("\r\n" + "Response.Redirect(\"../error.aspx\");");
                //strCodeForCs.Append("\r\n" + "break;");
                //strCodeForCs.Append("\r\n" + "case \"2\":");
                //strCodeForCs.Append("\r\n" + "Response.Redirect(\"../error.aspx\");");
                //strCodeForCs.Append("\r\n" + "break;");
                //strCodeForCs.Append("\r\n" + "case \"3\":");
                //strCodeForCs.Append("\r\n" + "Response.Redirect(\"../error.aspx\");");
                //strCodeForCs.Append("\r\n" + "break;");
                //strCodeForCs.Append("\r\n" + "case \"4\":");
                //strCodeForCs.Append("\r\n" + "Response.Redirect(\"../error.aspx\");");
                //strCodeForCs.Append("\r\n" + "break;");
                //strCodeForCs.Append("\r\n" + "case \"9\":");
                //strCodeForCs.Append("\r\n" + "break;");
                //strCodeForCs.Append("\r\n" + "default:");
                //strCodeForCs.Append("\r\n" + "Response.Redirect(\"../error.aspx\");");
                //strCodeForCs.Append("\r\n" + "break;");
                //strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        Func<clsQryRegionFldsENEx, ASPDropDownListEx> GetDdlObj = obj => clsASPDropDownListBLEx.GetDropDownLst_Asp(obj, new clsGetTabFieldObj());
        Func<clsViewFeatureFldsENEx, ASPDropDownListEx> GetDdlObj2 = obj => clsASPDropDownListBLEx.GetDropDownLst_Asp(obj, new clsGetTabFieldObj());

        public string GenDdlBindFunction4Page_Load()
        {
            clsVarManage objVarManage = new clsVarManage("CSharp");
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                if (IsHaveEditRegion)
                {
                    strCodeForCs.Append("\r\n" + "//1、为下拉框设置数据源,绑定列表数据");
                    foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                    {
                        if (objEditRegionFldsEx.InUse == false) continue;
                        if (objEditRegionFldsEx.objCtlType.CtlTypeName.Contains("DropDownList") == true)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "{0}1.SetDdl{1}();",
                                this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003), objEditRegionFldsEx.FldName);
                        }
                    }
                }

                //clsASPDropDownListBLEx.
                List<string> arrDropDownTypeLst = new List<string> { enumCtlType.DropDownList_06, enumCtlType.DropDownList_Bool_18 };
                IEnumerable<clsQryRegionFldsENEx> arrQRF4DropDownLst = objViewInfoENEx.arrQryRegionFldSet.Where(x => arrDropDownTypeLst.Contains(x.CtlTypeId));
                IEnumerable<ASPDropDownListEx> arrASPDropDownListObj = arrQRF4DropDownLst
                    .Select(GetDdlObj).Distinct(new ASPDropDownListEx4GCComparer());

                //从界面功能字段中获取下拉框字段

                IEnumerable<clsViewFeatureFldsENEx> arrWFF4DropDownLst = objViewInfoENEx.arrViewFeatureFlds.Where(x => arrDropDownTypeLst.Contains(x.CtlTypeId));
                List<ASPDropDownListEx> arrASPDropDownListObj4WFF = arrWFF4DropDownLst
                    .Select(GetDdlObj2).ToList();
                arrASPDropDownListObj = arrASPDropDownListObj.Union(arrASPDropDownListObj4WFF).Distinct(new ASPDropDownListComparer());

                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj)
                {
                    //strCodeForCs.AppendFormat("\r\n" + objInfor.GC_BindDdl(objVarManage));
                    
                }
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string GenDdlBind4ViewFeatureInPage_Load()
        {
            clsVarManage objVarManage = new clsVarManage("CSharp");
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
               

                //clsASPDropDownListBLEx.
                List<string> arrDropDownTypeLst = new List<string> { enumCtlType.DropDownList_06, enumCtlType.DropDownList_Bool_18 };
                
                //从界面功能字段中获取下拉框字段

                IEnumerable<clsViewFeatureFldsENEx> arrWFF4DropDownLst = objViewInfoENEx.arrViewFeatureFlds.Where(x => arrDropDownTypeLst.Contains(x.CtlTypeId));
                List<ASPDropDownListEx> arrASPDropDownListObj4WFF = arrWFF4DropDownLst
                    .Select(GetDdlObj2).Distinct(new ASPDropDownListEx4GCComparer()).ToList();
                
                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj4WFF)
                {
                    if (string.IsNullOrEmpty(objInfor.TabFeatureId4Ddl) == false)
                    {
                        var objTabFeature = clsTabFeatureBL.GetObjByTabFeatureIdCache(objInfor.TabFeatureId4Ddl, objInfor.PrjId);
                        var arrTabFeatureFlds = clsTabFeatureFldsBLEx.GetObjLstByTabFeatureIdCache(objTabFeature.TabFeatureId, objInfor.PrjId);
                        var arrTabFeatureFlds_Cond = arrTabFeatureFlds.Where(x => x.FieldTypeId == enumFieldType.ConditionField_16).ToList();
                        if (arrTabFeatureFlds_Cond.Count == 0)
                        {
                            objInfor.VarIdCond1 = "";
                            objInfor.VarIdCond2 = "";
                            objInfor.FldIdCond1 = "";
                            objInfor.FldIdCond2 = "";
                        }
                        else if (arrTabFeatureFlds_Cond.Count == 1)
                        {
                            objInfor.VarIdCond2 = "";
                            objInfor.FldIdCond2 = "";
                        }
                    }
                    string strCtrlId = objInfor.CtrlId;
                    if (objInfor.FeatureId == enumPrjFeature.SetFieldValue_0148)
                    {
                        if (strCtrlId.IndexOf("_SetFldValue") == -1)
                        {
                            strCtrlId = strCtrlId + "_SetFldValue";
                            objInfor.CtrlId = strCtrlId;
                        }
                    }
                    //strCodeForCs.AppendFormat("\r\n" + objInfor.GC_BindDdl(objVarManage));

                }
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        //public string this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002)
        //{
        //    string strClsName = string.Format("wuc{0}4Gv", objViewInfoENEx.TabName_Out);
        //    return strClsName;
        //}
        public string GenbtnUpdateRecord_Click4OneKeyword()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n ///修改当前被选记录");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                if (objViewInfoENEx.objViewRegion_List.IsCheck() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnUpdateRecord_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");

                    strCodeForCs.Append("\r\n" + "//1、显示该关键字的数据让用户修改该关键字记录；");

                    switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                    {
                        case "string":
                            if (bolIsUseWuc4Gv == true)
                            {
                                strCodeForCs.AppendFormat("\r\n" + "{0} = {2}1.GetFirstCheckedKeyFromGv();",
                                 objKeyField.KeyVarDefineStr,
                                 objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                 this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002), PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");

                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "{0} = GetFirstCheckedKeyFromGv();",
                                    objKeyField.KeyVarDefineStr,
                                    objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                            }
                            strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true) return;",
                                objViewInfoENEx.KeyPrivFuncFldNameLstStr);
                            break;
                        case "int":
                        case "long":
                            if (bolIsUseWuc4Gv == true)
                            {
                                strCodeForCs.AppendFormat("\r\n" + "{0} = {2}1.GetFirstCheckedKeyFromGv();",
                                 objKeyField.KeyVarDefineStr,
                                 objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                 this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002), PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");

                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "{0} = GetFirstCheckedKeyFromGv();",
                                objKeyField.KeyVarDefineStr,
                                objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                   objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                            }
                            strCodeForCs.AppendFormat("\r\n" + "if ({0} == 0) return;",
                          objViewInfoENEx.KeyPrivFuncFldNameLstStr);
                            break;
                    }

                    if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "Update{0}Record({1});",
                        objViewInfoENEx.TabName,
                       objViewInfoENEx.KeyPrivFuncFldNameLstStr);
                    }
                    else if (objViewInfoENEx.objViewTypeCodeTab.IsHaveExeUpdate)
                    {
                        //strStd1Id = "";
                        strCodeForCs.Append("\r\n" + "clsCommonSession.ParentPage = Page.Request.Url.AbsolutePath;");
                        strCodeForCs.AppendFormat("\r\n" + "Response.Redirect(\"wfm{0}_UI.aspx?OperateType = UPDATE&{1} = \" + {2});",
                        objViewInfoENEx.TabName,
                        objKeyField.ObjFieldTabENEx.FldName,
                        objKeyField.PrivFuncName);
                    }

                    strCodeForCs.Append("\r\n" + "}");
                }
                else if (objViewInfoENEx.objViewRegion_List.IsRadio() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnUpdateRecord_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string str{0} = (string) rd.Value;",
                    objKeyField.ObjFieldTabENEx.FldName);
                    switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                    {
                        case "string":
                            //							strCodeForCs.AppendFormat("\r\n" + "{0} = e.Item.Cells[{1}].Text;", 
                            //								objViewInfoENEx. objMainTabKeyField.ObjFieldTabENEx.PrivFuncName, intItemNum);
                            break;
                        case "int":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = int.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                        case "long":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = long.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                    }

                    strCodeForCs.AppendFormat("\r\n" + "if (str{0} == null || str{0}.Trim().Length == 0) ",
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                        objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnUpdateRecord_Click", "没有选择记录,请选择一个有效的表记录!", "生成代码");

                    strCodeForCs.AppendFormat("\r\n" + "lblMsg.Text = \"(errid:{0})没有选择记录,请选择一个有效的表记录!\";", strErrId);

                    //strCodeForCs.Append("\r\n" + "lblMsg.Text = \"没有选择记录,请选择一个有效的表记录!\";");
                    strCodeForCs.Append("\r\n" + "return ;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "lblMsg.Text = \"\";");
                    strCodeForCs.Append("\r\n" + "//1、显示该关键字记录的内容在界面上；");
                    if (IsHaveEditRegion)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "ShowData({0});",
                        objKeyField.PrivFuncName);
                        //					strCodeForCs.AppendFormat("\r\n" + "ShowData(str{0});",
                        //						objViewInfoENEx. objMainTabKeyField.ObjFieldTabENEx.FldName);
                        strCodeForCs.Append("\r\n" + "//2、清空提示信息的内容,同时使<确定修改>按钮可用；");
                        strCodeForCs.Append("\r\n" + "btnOKUpd.Enabled = true;");
                        if (objKeyField.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "{0}1.SetKeyReadOnly(true);",
                                    this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003));
                        }
                        strCodeForCs.Append("\r\n" + "btnOKUpd.Text = \"确认修改\";	");
                        strCodeForCs.Append("\r\n" + "}");
                    }
                    else if (objViewInfoENEx.objViewTypeCodeTab.IsHaveExeUpdate)
                    {
                        //strStd1Id = "";
                        strCodeForCs.Append("\r\n" + "clsCommonSession.ParentPage = Page.Request.Url.AbsolutePath;");
                        strCodeForCs.AppendFormat("\r\n" + "Response.Redirect(\"wfm{0}_UI.aspx?OperateType = UPDATE&{1} = \" + {2});",
                        objViewInfoENEx.TabName,
                        objKeyField.ObjFieldTabENEx.FldName,
                        objKeyField.PrivFuncName);
                        //Update{TabName}Record(strStd1Id);
                    }
                }
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string GenbtnCopyRecord_Click4OneKeyword()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n ///修改当前被选记录");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                if (objViewInfoENEx.objViewRegion_List.IsCheck() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnCopyRecord_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");

                    strCodeForCs.Append("\r\n" + "//1、显示该关键字的数据让用户修改该关键字记录；");

                    switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                    {
                        case "string":
                            if (bolIsUseWuc4Gv == true)
                            {
                                strCodeForCs.AppendFormat("\r\n" + "{0} = {2}1.GetFirstCheckedKeyFromGv();",
                                 objKeyField.KeyVarDefineStr,
                                 objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                 this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002), PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");

                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "{0} = GetFirstCheckedKeyFromGv();",
                                    objKeyField.KeyVarDefineStr,
                                    objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                            }
                            strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true) return;",
                                objViewInfoENEx.KeyPrivFuncFldNameLstStr);
                            break;
                        case "int":
                        case "long":
                            if (bolIsUseWuc4Gv == true)
                            {
                                strCodeForCs.AppendFormat("\r\n" + "{0} = {2}1.GetFirstCheckedKeyFromGv();",
                                 objKeyField.KeyVarDefineStr,
                                 objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                 this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002), PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");

                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "{0} = GetFirstCheckedKeyFromGv();",
                                objKeyField.KeyVarDefineStr,
                                objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                   objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                            }
                            strCodeForCs.AppendFormat("\r\n" + "if ({0} == 0) return;",
                          objViewInfoENEx.KeyPrivFuncFldNameLstStr);
                            break;
                    }

                        strCodeForCs.AppendFormat("\r\n" + "CopyRecord({1});",
                        objViewInfoENEx.TabName,
                       objViewInfoENEx.KeyPrivFuncFldNameLstStr);

                    strCodeForCs.Append("\r\n" + "}");
                }
                else if (objViewInfoENEx.objViewRegion_List.IsRadio() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnCopyRecord_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string str{0} = (string) rd.Value;",
                    objKeyField.ObjFieldTabENEx.FldName);
                    switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                    {
                        case "string":
                            //							strCodeForCs.AppendFormat("\r\n" + "{0} = e.Item.Cells[{1}].Text;", 
                            //								objViewInfoENEx. objMainTabKeyField.ObjFieldTabENEx.PrivFuncName, intItemNum);
                            break;
                        case "int":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = int.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                        case "long":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = long.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                    }

                    strCodeForCs.AppendFormat("\r\n" + "if (str{0} == null || str{0}.Trim().Length == 0) ",
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                        objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnCopyRecord_Click", "没有选择记录,请选择一个有效的表记录!", "生成代码");

                    strCodeForCs.AppendFormat("\r\n" + "lblMsg.Text = \"(errid:{0})没有选择记录,请选择一个有效的表记录!\";", strErrId);

                    //strCodeForCs.Append("\r\n" + "lblMsg.Text = \"没有选择记录,请选择一个有效的表记录!\";");
                    strCodeForCs.Append("\r\n" + "return ;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "lblMsg.Text = \"\";");
                    strCodeForCs.Append("\r\n" + "//1、显示该关键字记录的内容在界面上；");

                    strCodeForCs.AppendFormat("\r\n" + "CopyRecord({0});",
                    objKeyField.PrivFuncName);
                    strCodeForCs.Append("\r\n" + "}");

                }
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 针对主表只有一个关键字的删除事件
        /// </summary>
        /// <param name="objViewInfoENEx"></param>
        /// <returns></returns>
        public string GenbtnDelRecord_Click4OneKeyword()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///删除当前被选记录");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                if (objViewInfoENEx.objViewRegion_List.IsCheck() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnDelRecord_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");

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
                    if (bolIsUseWuc4Gv == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "List<{1}> lst{0} = {2}1.GetAllCheckedKeysFromGv();",
                                         objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                         objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                                         this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002), PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "List<{1}> lst{0} = GetAllCheckedKeysFromGv();",
                                            objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                    }
                    strCodeForCs.AppendFormat("\r\n" + "if (lst{0} == null) return;",
                                        objKeyField.ObjFieldTabENEx.FldName_FstUcase);

                    strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");

                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "foreach ({0} {1} in lst{2})",
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                        objKeyField.PrivFuncName,
                        objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                    strCodeForCs.Append("\r\n" + "{");


                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.DelRecord({1});",
                        objViewInfoENEx.TabName,
                        objKeyField.PrivFuncName);

                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                        objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnDelRecord_Click", "删除记录不成功!", "生成代码");

                    strCodeForCs.AppendFormat("\r\n" + "string strMsg = \"(errid:{0})删除记录不成功!\" + objException.Message;", strErrId);
                    strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                    strCodeForCs.Append("\r\n" + "lblMsg_List.Text = strMsg;");
                    strCodeForCs.Append("\r\n" + "return;");
                    strCodeForCs.Append("\r\n" + "}");
                    if (bolIsUseWuc4Gv == true)
                    {
                        if (this.IsUseFunc)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}ByFunc();",
                                  strTabName_Out4ListRegion);

                        }
                        else if (PrjTabEx_ListRegion.IsUseCache_TS() == true)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}Cache();",
                                strTabName_Out4ListRegion);
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                                strTabName_Out4ListRegion);
                        }
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();", strTabName_Out4ListRegion);
                    }
                    strCodeForCs.Append("\r\n" + "}");
                }
                else if (objViewInfoENEx.objViewRegion_List.IsRadio() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnDelRecord_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string str{0} = (string) rd.Value;",
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "if (str{0} == null || str{0}.Trim().Length == 0) ",
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnDelRecord_Click", "没有选择记录,请选择一个有效的表记录!", "生成代码");

                    strCodeForCs.AppendFormat("\r\n" + "lblMsg.Text = \"(errid:{0})没有选择记录,请选择一个有效的表记录!\";", strErrId);

                    //strCodeForCs.Append("\r\n" + "lblMsg.Text = \"没有选择记录,请选择一个有效的表记录!\";");
                    strCodeForCs.Append("\r\n" + "return ;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "lblMsg.Text = \"\";");

                    switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                    {
                        case "string":
                            //							strCodeForCs.AppendFormat("\r\n" + "{0} = e.Item.Cells[{1}].Text;", 
                            //								objViewInfoENEx. objMainTabKeyField.ObjFieldTabENEx.PrivFuncName, intItemNum);
                            break;
                        case "int":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = int.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                        case "long":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = long.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                    }

                    strCodeForCs.AppendFormat("\r\n" + "cls{0}.DelRecord({1});",
                    objViewInfoENEx.TabName, objKeyField.PrivFuncName);
                    if (bolIsUseWuc4Gv == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + " string strWhereCond = Combine{0}Condition();",
               objViewInfoENEx.TabName);
                        strCodeForCs.AppendFormat("\r\n" + " {1}1.BindGv_{0}(strWhereCond);",
                            objViewInfoENEx.TabName, this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002), PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();", objViewInfoENEx.TabName);
                    }
                    strCodeForCs.Append("\r\n" + "}");
                }
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        /// <summary>
        /// 针对主表只有一个关键字的删除事件
        /// </summary>
        /// <param name="objViewInfoENEx"></param>
        /// <returns></returns>
        public string GenbtnDelRecordBySign_Click4OneKeyword()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///标志性删除数据列表中多选的首条记录");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                if (objViewInfoENEx.objViewRegion_List.IsCheck() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnDelRecordBySign_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");

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
                    if (bolIsUseWuc4Gv == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "List<{1}> lst{0} = {2}{3}1.GetAllCheckedKeysFromGv();",
                                         objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                         objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                                         this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002), PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "List<{1}> lst{0} = GetAllCheckedKeysFromGv();",
                                            objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                    }
                    strCodeForCs.AppendFormat("\r\n" + "if (lst{0} == null) return;",
                                        objKeyField.ObjFieldTabENEx.FldName_FstUcase);

                    strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");

                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    //strCodeForCs.AppendFormat("\r\n" + "foreach ({0} {1} in lst{2})",
                    //    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    //    objKeyField.PrivFuncName,
                    //    objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                    //strCodeForCs.Append("\r\n" + "{");


                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.DelRecordBySign(lst{1});",
                        objViewInfoENEx.TabName,
                        objKeyField.FldName_FstUcase);

                    //strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                        objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnDelRecordBySign_Click", "标志性删除记录不成功!", "生成代码");

                    strCodeForCs.AppendFormat("\r\n" + "string strMsg = \"(errid:{0})标志性删除记录不成功!\" + objException.Message;", strErrId);
                    strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                    strCodeForCs.Append("\r\n" + "lblMsg_List.Text = strMsg;");
                    strCodeForCs.Append("\r\n" + "return;");
                    strCodeForCs.Append("\r\n" + "}");
                    if (bolIsUseWuc4Gv == true)
                    {
                        if (this.IsUseFunc)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}ByFunc();",
                                  strTabName_Out4ListRegion);

                        }
                        else if (PrjTabEx_ListRegion.IsUseCache_TS() == true)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}Cache();",
                                strTabName_Out4ListRegion);
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                                strTabName_Out4ListRegion);
                        }
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();", strTabName_Out4ListRegion);
                    }
                    strCodeForCs.Append("\r\n" + "}");
                }
                else if (objViewInfoENEx.objViewRegion_List.IsRadio() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnDelRecord_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string str{0} = (string) rd.Value;",
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "if (str{0} == null || str{0}.Trim().Length == 0) ",
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnDelRecord_Click", "没有选择记录,请选择一个有效的表记录!", "生成代码");

                    strCodeForCs.AppendFormat("\r\n" + "lblMsg.Text = \"(errid:{0})没有选择记录,请选择一个有效的表记录!\";", strErrId);

                    //strCodeForCs.Append("\r\n" + "lblMsg.Text = \"没有选择记录,请选择一个有效的表记录!\";");
                    strCodeForCs.Append("\r\n" + "return ;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "lblMsg.Text = \"\";");

                    switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                    {
                        case "string":
                            //							strCodeForCs.AppendFormat("\r\n" + "{0} = e.Item.Cells[{1}].Text;", 
                            //								objViewInfoENEx. objMainTabKeyField.ObjFieldTabENEx.PrivFuncName, intItemNum);
                            break;
                        case "int":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = int.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                        case "long":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = long.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                    }

                    strCodeForCs.AppendFormat("\r\n" + "cls{0}.DelRecord({1});",
                    objViewInfoENEx.TabName, objKeyField.PrivFuncName);
                    if (bolIsUseWuc4Gv == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + " string strWhereCond = Combine{0}Condition();",
               objViewInfoENEx.TabName);
                        strCodeForCs.AppendFormat("\r\n" + " {1}{2}1.BindGv_{0}(strWhereCond);",
                            objViewInfoENEx.TabName, this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002), PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();", objViewInfoENEx.TabName);
                    }
                    strCodeForCs.Append("\r\n" + "}");
                }
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        public string GenbtnUnDelRecordBySign_Click4OneKeyword()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///恢复标志性删除数据列表中多选的首条记录");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                if (objViewInfoENEx.objViewRegion_List.IsCheck() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnUnDelRecordBySign_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");

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
                    if (bolIsUseWuc4Gv == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "List<{1}> lst{0} = {2}{3}1.GetAllCheckedKeysFromGv();",
                                         objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                         objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                                         this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002), PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "List<{1}> lst{0} = GetAllCheckedKeysFromGv();",
                                            objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                    }
                    strCodeForCs.AppendFormat("\r\n" + "if (lst{0} == null) return;",
                                        objKeyField.ObjFieldTabENEx.FldName_FstUcase);

                    strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");

                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    //strCodeForCs.AppendFormat("\r\n" + "foreach ({0} {1} in lst{2})",
                    //    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    //    objKeyField.PrivFuncName,
                    //    objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                    //strCodeForCs.Append("\r\n" + "{");


                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.UnDelRecordBySign(lst{1});",
                        objViewInfoENEx.TabName,
                        objKeyField.FldName_FstUcase);

                    //strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                        objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnUnDelRecordBySign_Click", "恢复标志性删除记录不成功!", "生成代码");

                    strCodeForCs.AppendFormat("\r\n" + "string strMsg = \"(errid:{0})恢复标志性删除记录不成功!\" + objException.Message;", strErrId);
                    strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                    strCodeForCs.Append("\r\n" + "lblMsg_List.Text = strMsg;");
                    strCodeForCs.Append("\r\n" + "return;");
                    strCodeForCs.Append("\r\n" + "}");
                    if (bolIsUseWuc4Gv == true)
                    {
                        if (this.IsUseFunc)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}ByFunc();",
                                  strTabName_Out4ListRegion);

                        }
                        else if (PrjTabEx_ListRegion.IsUseCache_TS() == true)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}Cache();",
                                strTabName_Out4ListRegion);
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                                strTabName_Out4ListRegion);
                        }
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();", strTabName_Out4ListRegion);
                    }
                    strCodeForCs.Append("\r\n" + "}");
                }
                else if (objViewInfoENEx.objViewRegion_List.IsRadio() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnDelRecord_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string str{0} = (string) rd.Value;",
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "if (str{0} == null || str{0}.Trim().Length == 0) ",
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnDelRecord_Click", "没有选择记录,请选择一个有效的表记录!", "生成代码");

                    strCodeForCs.AppendFormat("\r\n" + "lblMsg.Text = \"(errid:{0})没有选择记录,请选择一个有效的表记录!\";", strErrId);

                    //strCodeForCs.Append("\r\n" + "lblMsg.Text = \"没有选择记录,请选择一个有效的表记录!\";");
                    strCodeForCs.Append("\r\n" + "return ;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "lblMsg.Text = \"\";");

                    switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                    {
                        case "string":
                            //							strCodeForCs.AppendFormat("\r\n" + "{0} = e.Item.Cells[{1}].Text;", 
                            //								objViewInfoENEx. objMainTabKeyField.ObjFieldTabENEx.PrivFuncName, intItemNum);
                            break;
                        case "int":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = int.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                        case "long":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = long.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                    }

                    strCodeForCs.AppendFormat("\r\n" + "cls{0}.DelRecord({1});",
                    objViewInfoENEx.TabName, objKeyField.PrivFuncName);
                    if (bolIsUseWuc4Gv == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + " string strWhereCond = Combine{0}Condition();",
               objViewInfoENEx.TabName);
                        strCodeForCs.AppendFormat("\r\n" + " {1}{2}1.BindGv_{0}(strWhereCond);",
                            objViewInfoENEx.TabName, this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002), PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();", objViewInfoENEx.TabName);
                    }
                    strCodeForCs.Append("\r\n" + "}");
                }
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }
        /// <summary>
        /// 导出EXCEL文件,其中导出的字段完全与DataGrid一致。专门针对导出字段
        /// </summary>
        /// <returns></returns>
        public string GenExportExcel4SetExportFld()
        {
            string strFuncName = "";
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
                if (
                    clsPrjTabBL.GetObjByTabIdCache(
                    clsViewRegionBL.GetObjByRegionIdCache(objViewInfoENEx.objViewRegion_ExportExcel.RegionId, objViewInfoENEx.PrjId).TabId, objViewInfoENEx.PrjId).SqlDsTypeId == clsSQLDSTypeENEx.SQLVIEW)
                {
                    strCodeForCs.AppendFormat("\r\n /// 导出Excel。根据查询区组合的查询条件,从[v{0}]表中获取记录集,最终导出到Excel", objViewInfoENEx.TabName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n /// 导出Excel。根据查询区组合的查询条件,从[{0}]表中获取记录集,最终导出到Excel", objViewInfoENEx.TabName);
                }
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "private void ExportExcel()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//	1、组合界面条件串；");
                strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = Combine{0}Condition();",
                objViewInfoENEx.TabName);
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
                foreach (clsExcelExportRegionFldsENEx objExcelExportRegionFldsEx in objViewInfoENEx.arrExcelExportRegionFldSet)
                {
                    strCodeForCs.AppendFormat("\r\n" + "arrColName.Add(con{2}.{0}); arrCnName.Add(\"{1}\");",
                    objExcelExportRegionFldsEx.ObjFieldTabENEx.FldName,
                    objExcelExportRegionFldsEx.ColCaption,
                    objViewInfoENEx.TabName_Out);
                }

                strCodeForCs.Append("\r\n" + "clsExportExcelSetENEx objExportExcelSetENEx = new clsExportExcelSetENEx();");
                strCodeForCs.Append("\r\n" + "objExportExcelSetENEx.ViewName = vsViewName;//当前界面");
                strCodeForCs.Append("\r\n" + "objExportExcelSetENEx.TabName = vsTabName;//导出Excel所用的表或者视图");
                strCodeForCs.Append("\r\n" + "objExportExcelSetENEx.ExportFileName = strFileName;//导出Excel的文件名");
                strCodeForCs.Append("\r\n" + "objExportExcelSetENEx.UserId = clsCommonSession.UserId;//当前用户Id");
                strCodeForCs.Append("\r\n" + "objExportExcelSetENEx.UpdUserId = clsCommonSession.UserId;");
                strCodeForCs.Append("\r\n" + "objExportExcelSetENEx.UpdDate = clsDateTime.getTodayStr(0);//当前日期");
                strCodeForCs.Append("\r\n" + "objExportExcelSetENEx.strPrjId = clsPubVar.strCurrPrjId4AgcCs;//当前工程在生成代码系统中所用的工程Id,为了翻译字段名的中文名");
                strCodeForCs.Append("\r\n" + "objExportExcelSetENEx.arrCnName = arrCnName;//中文字段名,也是Excel文件中的标题名");
                strCodeForCs.Append("\r\n" + "objExportExcelSetENEx.arrColName = arrColName;//数据表的列名");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "clsExportExcelSetBLEx.GetExportExcelSetInfo(ref objExportExcelSetENEx);");
                strCodeForCs.Append("\r\n" + "strFileName = objExportExcelSetENEx.ExportFileName;//导出Excel的文件名");
                strCodeForCs.Append("\r\n" + "arrCnName = objExportExcelSetENEx.arrCnName;//中文字段名,也是Excel文件中的标题名");
                strCodeForCs.Append("\r\n" + "arrColName = objExportExcelSetENEx.arrColName;//数据表的列名");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"在导出记录时出错!错误：{0}.(In {1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "}");




                strCodeForCs.Append("\r\n" + "strFolderName = clsSysParaEN.TempFileFolder;");
                strCodeForCs.Append("\r\n" + "strDownLoadFileName = strFolderName + strFileName;");
                strCodeForCs.Append("\r\n" + "//初始化需要导出的Excel文件,即复制标准Excel文件作为母版,复制不成功即不能导出");
                strCodeForCs.Append("\r\n" + "if (clsPubVar.InitExcelFile(this, strFolderName, strDownLoadFileName) == false)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                //				strCodeForCs.Append("\r\n" + "GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTable(objDT, strColName, strCnName, strDownLoadFileName);");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//	2、根据条件串获取该表满足条件的DataTable；");
                
                    strCodeForCs.AppendFormat("\r\n" + "objDT = cls{0}BL.GetDataTable(strWhereCond);",
                    objViewInfoENEx.TabName_Out);
                
                strCodeForCs.Append("\r\n" + "//用户Odbc的方式来导出Excel,在Web服务器不需要安装Excel,目前是Excel2003,如果希望2007,可以换下面一条语句。");
                strCodeForCs.Append("\r\n" + "GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4Odbc(objDT, arrColName, arrCnName, strDownLoadFileName);");
                strCodeForCs.Append("\r\n" + "//GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4OdbcExcel2007(objDT, arrColName, arrCnName, strDownLoadFileName);");

                strCodeForCs.Append("\r\n" + "//GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr(objDT, arrColName, arrCnName, strDownLoadFileName);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"在导出记录时出错!错误：{0}.(In {1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "clsCommForWebForm.DownLoadFile(strDownLoadFileName);");
                strCodeForCs.Append("\r\n" + "}");
                //strCodeForCs.Append("\r\n /// <summary>");
                //strCodeForCs.Append("\r\n /// 功能:下载文件。从服务器下载文件到客户端浏览器");
                //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                //strCodeForCs.Append("\r\n /// </summary>");
                //strCodeForCs.Append("\r\n /// <param name = \"strDownLoadFileName\">需要下载的文件名。该文件名为带目录的文件全名</param>");
                //strCodeForCs.Append("\r\n /// <returns></returns>");
                //strCodeForCs.Append("\r\n" + "protected bool DownLoadFile(string strDownLoadFileName)");
                //strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.Append("\r\n" + "System.IO.FileInfo file = new System.IO.FileInfo(strDownLoadFileName); ");
                //strCodeForCs.Append("\r\n" + "Response.Clear(); ");
                //strCodeForCs.Append("\r\n" + "Response.AddHeader(\"Content-Disposition\", \"attachment; filename = \" + HttpUtility.UrlEncode(file.Name)); ");
                //strCodeForCs.Append("\r\n" + "Response.AddHeader(\"Content-Length\", file.Length.ToString()); ");
                //strCodeForCs.Append("\r\n" + "Response.ContentType = \"application/octet-stream\"; ");
                //strCodeForCs.Append("\r\n" + "Response.WriteFile(file.FullName); ");
                //strCodeForCs.Append("\r\n" + "Response.End();");
                //strCodeForCs.Append("\r\n" + "return true;");
                //strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WebView_CS_DefProperty_vsClassificationFieldName()
        {

            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);
                if (objAdjustOrderNum == null) return "";
                
                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";
                if (objAdjustOrderNum.ClassificationFieldValueLst == null) return "";

                foreach (string strInFor in objAdjustOrderNum.ClassificationFieldValueLst)
                {
                    string strInFor_OrderNum = string.Format("{0}_OrderNum", strInFor);
                    strInFor_OrderNum = strInFor_OrderNum.Replace("_OrderNum_OrderNum", "_OrderNum");
                    ///生成仅有变量;
                    //strCodeForCs.Append("\r\n" + "//生成有关的变量定义代码");

                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.Append("\r\n /// ViewState属性:当前记录排序的分类名称");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.AppendFormat("\r\n" + "protected string vs{0}", strInFor_OrderNum);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "get");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "string sClassificationField;");
                    strCodeForCs.AppendFormat("\r\n" + "sClassificationField = (string)ViewState[\"{0}\"];", strInFor_OrderNum);
                    strCodeForCs.Append("\r\n" + "if (sClassificationField == null)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "sClassificationField = \"\";");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "return sClassificationField;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "set");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "string sClassificationField = value;");
                    strCodeForCs.AppendFormat("\r\n" + "ViewState.Add(\"{0}\", sClassificationField);", strInFor_OrderNum);
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");

                    strCodeForCs.Append("\r\n");
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