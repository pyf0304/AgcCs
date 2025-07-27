using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AGC.PureClass;
using AGC.PureClassEx;
using AgcCommBase;
using CodeStruct;
using com.taishsoft.comm_db_obj;
using com.taishsoft.commexception;
using com.taishsoft.common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web.UI.WebControls;

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
    partial class Vue_ViewScript_List_TS4Html : clsGeneCodeBase4View
    {
        protected clsPrjTabENEx objPrjTabEx_ListRegion = null;
        protected string strSqlDsTypeId4ListRegion = "";
        //private string strJSPath = "";
        private clsFuncModule_AgcEN objFuncModule_Gc = null;
        //clsBiDimDistribute objBiDimDistribue4Qry = null;
        #region 构造函数
        public Vue_ViewScript_List_TS4Html()
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //

        }
        public Vue_ViewScript_List_TS4Html(string strViewId)
       : base( strViewId, "", "")
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;

        }
        public Vue_ViewScript_List_TS4Html( string strViewId, string strPrjDataBaseId, string strPrjId)
        : base(strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
        }

        #endregion

        public string Gen_List_Prop_Define(CodeElement objCodeElement_Parent)
        {
            CodeElement objCodeElement_Props = new CodeElement { Name = "props", ElementType = CodeElementType.Props, Modifiers = "export abstract" };
            objCodeElement_Parent.Children.Add(objCodeElement_Props);

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n" + "props:");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "items:");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "type: Array<any>,");
            strCodeForCs.Append("\r\n" + "required: true,");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "showErrorMessage:");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "type: Boolean,");
            strCodeForCs.Append("\r\n" + "required: true,");
            strCodeForCs.Append("\r\n" + "default: false,");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "emptyRecNumInfo:");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "type: String,");
            strCodeForCs.Append("\r\n" + "required: true,");
            strCodeForCs.Append("\r\n" + "default: '',");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "dataColumn:");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "type: Array<clsDataColumn>,");
            strCodeForCs.Append("\r\n" + "required: false,");
            strCodeForCs.Append("\r\n" + "default: () => [],");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "},");
            objCodeElement_Props.CodeContent = strCodeForCs.ToString();
            return strCodeForCs.ToString();
        }
        public string Gen_List_Emits_Define(CodeElement objCodeElement_Parent)
        {
            CodeElement objCodeElement_Emits = new CodeElement { Name = "emits", ElementType = CodeElementType.Emits, Modifiers = "export abstract" };
            objCodeElement_Parent.Children.Add(objCodeElement_Emits);
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n" + "emits: [");
            strCodeForCs.Append("\r\n" + "'on-edit-tab-relainfo', ");
            strCodeForCs.Append("\r\n" + "'on-sort-column',");
            strCodeForCs.Append("\r\n" + "'on-submit-sel',");
            strCodeForCs.Append("\r\n" + "], ");
            objCodeElement_Emits.CodeContent = strCodeForCs.ToString();
            return strCodeForCs.ToString();
        }



        public string Gen_List_watch_Define(CodeElement objCodeElement_Parent)
        {
            CodeElement objCodeElement_Watch = new CodeElement { Name = "watch", ElementType = CodeElementType.Watch, Modifiers = "export abstract" };
            objCodeElement_Parent.Children.Add(objCodeElement_Watch);
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "watch:");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "// 监听 selectAllChecked 变化，当复选框列头状态改变时，修改所有记录的选中状态");
            strCodeForCs.Append("\r\n" + "selectAllChecked(newValue) {");
            strCodeForCs.Append("\r\n" + "this.items.forEach((item) => (item.checked = newValue));");
            strCodeForCs.Append("\r\n" + "},"); 
            strCodeForCs.Append("\r\n" + "},");
            objCodeElement_Watch.CodeContent = strCodeForCs.ToString();
            return strCodeForCs.ToString();
        }


        public string Gen_List_methods_Define(CodeElement objCodeElement_Parent)
        {
            CodeElement objCodeElement_Methods = new CodeElement { Name = "methods", ElementType = CodeElementType.Methods, Modifiers = "export abstract" };
            objCodeElement_Parent.Children.Add(objCodeElement_Methods);
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n" + "methods:");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "},");
            objCodeElement_Methods.CodeContent = strCodeForCs.ToString();
            return strCodeForCs.ToString();
        }

        public string Gen_List_Setup_Define(CodeElement objCodeElement_Parent)
        {
            CodeElement objCodeElement_Setup = new CodeElement { Name = "setup", ElementType = CodeElementType.Setup, Modifiers = "export abstract" };
            objCodeElement_Parent.Children.Add(objCodeElement_Setup);
            StringBuilder strCodeForCs = new StringBuilder();
            
            strCodeForCs.Append("\r\n" + "setup(props, { emit }) {");

            strCodeForCs.Append("\r\n" + "const selectAllChecked = ref (false); // 初始化复选框列头选中状态为 false);");
            objCodeElement_Setup.Children.Add(new CodeElement
            {
                Name = "selectAllChecked",
                CodeContent = "const selectAllChecked = ref (false); // 初始化复选框列头选中状态为 false);",
                ElementType = CodeElementType.Constant,
            });

            strCodeForCs.Append("\r\n" + "const sortColumnKey = ref (''); // 初始化排序列");
            objCodeElement_Setup.Children.Add(new CodeElement
            {
                Name = "sortColumnKey",
                CodeContent = "const sortColumnKey = ref (''); // 初始化排序列",
                ElementType = CodeElementType.Constant,
            });
            strCodeForCs.Append("\r\n" + "const sortDirection = ref ('asc'); // 初始化排序方向");
            objCodeElement_Setup.Children.Add(new CodeElement
            {
                Name = "sortDirection",
                CodeContent = "const sortDirection = ref ('asc'); // 初始化排序方向",
                ElementType = CodeElementType.Constant,
            });
            strCodeForCs.Append("\r\n" + "//const showCourseColumn = ref (false);");
            strCodeForCs.Append("\r\n" + "const showSelectColumn = ref (false);");
            objCodeElement_Setup.Children.Add(new CodeElement
            {
                Name = "showSelectColumn",
                CodeContent = "const showSelectColumn = ref (false);",
                ElementType = CodeElementType.Constant,
            });
            // 手动维护字段名列表
            StringBuilder sbTdFieldNames = new StringBuilder();
            sbTdFieldNames.Append("\r\n" + $"   const tdFieldNames = [");
            //strCodeForCs.Append("\r\n" + $"'constId',");
            var arrDGRegionFlds = objViewInfoENEx.arrDGRegionFldSet.OrderBy(x => x.SeqNum);

            foreach (clsDGRegionFldsENEx objDGRegionFldsENEx in arrDGRegionFlds)
            {
                string strDataPropertyName = "";
                if (string.IsNullOrEmpty(objDGRegionFldsENEx.DataPropertyName()) == false)
                {
                    strDataPropertyName = clsString.FstLcaseS(objDGRegionFldsENEx.DataPropertyName4GC());
                }
                else if (objDGRegionFldsENEx.ObjPrjTabFld() != null && objDGRegionFldsENEx.ObjPrjTabFld().IsForExtendClass)
                {
                    strDataPropertyName = clsString.FstLcaseS(objDGRegionFldsENEx.FldName);
                }
                else
                {
                    strDataPropertyName = clsString.FstLcaseS(objDGRegionFldsENEx.FldName);
                }

                sbTdFieldNames.Append("\r\n" + $"'{strDataPropertyName}',");
            }

            sbTdFieldNames.Append("\r\n" + "];");
            strCodeForCs.Append(sbTdFieldNames);
            objCodeElement_Setup.Children.Add(new CodeElement
            {
                Name = "tdFieldNames",
                CodeContent = sbTdFieldNames.ToString(),
                ElementType = CodeElementType.Constant,
            });
            StringBuilder sbWatchEffect = new StringBuilder();
            sbWatchEffect.Append("\r\n" + "watchEffect(() => {");
            sbWatchEffect.Append("\r\n" + "//showCourseColumn.value = props.dataColumn.some((column) => column.colHeader === '课程');");
            sbWatchEffect.Append("\r\n" + "showSelectColumn.value = props.dataColumn.some((column) => column.colHeader === '选择');");
            sbWatchEffect.Append("\r\n" + "//console.error('showCourseColumn:', showCourseColumn.value);");
            sbWatchEffect.Append("\r\n" + "});");
            strCodeForCs.Append(sbWatchEffect);
            objCodeElement_Setup.Children.Add(new CodeElement
            {
                Name = "watchEffect",
                CodeContent = sbWatchEffect.ToString(),
                ElementType = CodeElementType.WatchEffect,
            });

            strCodeForCs.Append("\r\n" + Gen_List_Setup_Fun_btnClickInRow(objCodeElement_Setup));
            strCodeForCs.Append("\r\n" + Gen_List_Setup_Fun_btnSubmitSel(objCodeElement_Setup));

            strCodeForCs.Append("\r\n" + Gen_List_Setup_Fun_sortColumn(objCodeElement_Setup));
            strCodeForCs.Append("\r\n" + Gen_List_Setup_Fun_selectAllRows(objCodeElement_Setup));
            StringBuilder sbReturn = new StringBuilder();
            sbReturn.Append("\r\n" + "    return {");
            // items,
            sbReturn.Append("\r\n" + "btnClickInRow,");
            sbReturn.Append("\r\n" + "sortColumn,");
            sbReturn.Append("\r\n" + "sortColumnKey,");
            sbReturn.Append("\r\n" + "sortDirection,");
            sbReturn.Append("\r\n" + "selectAllChecked,");
            sbReturn.Append("\r\n" + "selectAllRows,");
            sbReturn.Append("\r\n" + "//showCourseColumn,");
            sbReturn.Append("\r\n" + "btnSubmitSel,");
            sbReturn.Append("\r\n" + "showSelectColumn,");
            sbReturn.Append("\r\n" + "tdFieldNames,");
            sbReturn.Append("\r\n" + "};");
            strCodeForCs.Append(sbReturn);
            objCodeElement_Setup.Children.Add(new CodeElement
            {
                Name = "return",
                CodeContent = sbReturn.ToString(),
                ElementType = CodeElementType.SetupReturn,
            });
            strCodeForCs.Append("\r\n" + "},");

            objCodeElement_Setup.CodeContent = strCodeForCs.ToString();
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 功能:单表的查询、修改、插入、删除
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            if (objViewInfoENEx.objViewRegion_List == null || objViewInfoENEx.objViewRegion_List.IsDispInViewInfo(objViewInfoENEx) == false)
            {
                return "";
            }

            //让用户设置属性;
            if (objViewInfoENEx.arrDGRegionFldSet == null || objViewInfoENEx.arrDGRegionFldSet.Count == 0)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有编辑区域,或者编辑区域没有字段。请检查!", strViewName);
                sbMessage.Append("\r\n当前界面的功能:查询(Q)、修改(U)、删除(D)、添加(I)。");
                throw new clsDbObjException(sbMessage.ToString());
            }
            this.objCodeElement_Root = new CodeElement { Name = "Root", ElementType = CodeElementType.Root };
            
            this.objCodeElement_Imports = new CodeElement { Name = "imports", ElementType = CodeElementType.Import, Modifiers = "export abstract" };

            var objPrjTab_ListRegion = clsPrjTabBL.GetObjByTabIdCache(TabId_Out4ListRegion, objViewInfoENEx.PrjId);
            if (objPrjTab_ListRegion != null)
            {
                strSqlDsTypeId4ListRegion = objPrjTab_ListRegion.SqlDsTypeId;
            }

            objPrjTabEx_ListRegion = clsPrjTabBLEx.CopyToEx(objPrjTab_ListRegion);
            objPrjTabEx_ListRegion.GetObjAllInfoEx();
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;


            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                    clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objViewInfoENEx.FunctionTemplateId,
                        objViewInfoENEx.LangType, objViewInfoENEx.CodeTypeId, objViewInfoENEx.SqlDsTypeId);

            objViewInfoENEx.WebFormName = string.Format("{0}", ThisClsName);
            objViewInfoENEx.WebFormFName = string.Format("{0}{1}.vue",
                objViewInfoENEx.FolderName, ThisClsName);
            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;

            strRe_ClsName = objViewInfoENEx.WebFormName;
            objFuncModule_Gc = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName(objFuncModule_Gc, objViewInfoENEx);
            //this.objCodeElement_Class = new CodeElement { Name = ThisClsName, ElementType = CodeElementType.Class, Modifiers = "export abstract" };
            //this.objCodeElement_Root.Children.Add(this.objCodeElement_Class);
            try
            {
                strCodeForCs.Append("\r\n" + Gen_List_Template_DefDiv4ListRegion(objCodeElement_Root));
                strCodeForCs.Append("\r\n" + Gen_List_Script_DefDiv4ListRegion(objCodeElement_Root));
                strCodeForCs.Append("\r\n" + Gen_List_Style_DefDiv4ListRegion(objCodeElement_Root));

            }
            catch (Exception ex)
            {
                string strMsg = $"在生成界面殂出错。{ex.Message}. (In {clsStackTrace.GetCurrClassFunction()})";
                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }

            return strCodeForCs.ToString();
        }



        public string GenFeatureRegion(clsViewRegionEN objDGRegionENEx, clsViewInfoENEx objViewInfoENEx)
        {
            string strFuncName = "";
            string lngRegionId = "";
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;

            //			string strTemp ;     ///临时变量;
            ///判断DataGrid是否需要排序
            foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
            {
                if (objDGRegionFldsEx.IsNeedSort)
                {
                    //objViewInfoENEx.objViewRegion_List.AllowSorting() = true;
                }
            }
            try
            {


                ASPDivEx objASPDivENEx_Function = clsASPDivBLEx.GetEmptyDiv();
                objASPDivENEx_Function.Class = "table table-bordered table-hover";
                objASPDivENEx_Function.Runat = "server";
                objASPDivENEx_Function.CtrlId = "divFunction";
                IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFldsObjLst = objViewInfoENEx.arrFeatureRegionFlds;
                if (objViewInfoENEx.arrFeatureRegionFlds == null)
                {
                    string strMsg = string.Format("界面功能区为空,请添加界面功能!界面:{0}. (In {1})", objViewInfoENEx.ViewName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);

                }
                IEnumerable<clsViewRegionENEx> arrViewRegion = objViewInfoENEx.arrViewRegion
                    .Where(x => x.RegionTypeId == enumRegionType.FeatureRegion_0008);
                if (arrViewRegion.Count() == 0)
                {
                    string strMsg = string.Format("界面功能区为空,请添加界面功能!界面:{0}. (In {1})", objViewInfoENEx.ViewName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);

                }
                lngRegionId = arrViewRegion.First().RegionId;
                IEnumerable<ASPControlEx> arrControls = clsFeatureRegionFldsBLEx.GetControlLst4Regoin(lngRegionId, enumViewImplementation.FunctionRegion_0001, objViewInfoENEx, "");

                List<ASPControlGroupEx> arrControlGroupLst = arrControls
                    .OrderBy(x => x.OrderNum)
                    .Select(clsASPControlGroupBLEx.GetControlGroup)
                    .OrderBy(x => x.GroupName).ToList();


                //IEnumerable<ASPButtonEx> arrButtonLst = objViewInfoENEx.arrFeatureRegionFlds.Where(x => x.ViewImplId == enumViewImplementation.FunctionRegion_0001).Select(clsASPButtonBLEx.GetButton4MvcAjax);
                IEnumerable<ASPControlGroupEx> arrControlGroupLst_New = clsASPControlGroupBLEx.MergeControlGroup(arrControlGroupLst);


                //添加层div
                ASPUlEx objASPUlENEx = clsASPUlBLEx.GetEmptyUl();
                objASPUlENEx.Class = "nav";
                objASPDivENEx_Function.arrSubAspControlLst2.Add(objASPUlENEx);

                ASPLiEx objASPLiENEx = clsASPLiBLEx.GetEmptyLi();
                objASPLiENEx.Class = "nav-item";
                objASPUlENEx.arrSubAspControlLst2.Add(objASPLiENEx);
                //列表标题
                ASPLabelEx objASPNETLabelENEx = clsASPLabelBLEx.GetDataListTitle(objViewInfoENEx, true);
                objASPLiENEx.arrSubAspControlLst2.Add(objASPNETLabelENEx);

                //Action<ASPButtonEx> AddToTd = (x) =>
                //{
                //    objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                //    ASPButtonEx objASPNETButtonENEx = clsASPButtonBLEx.GetbtnAddNewRec4Gv();
                //    objASPNETColENEx.arrSubAspControlLst2.Add(x);
                //    objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);
                //};
                //<li class="nav-item">

                Action<ASPButtonEx> AddToLi = (x) =>
                {
                    objASPLiENEx = clsASPLiBLEx.GetEmptyLi();
                    objASPLiENEx.Class = "nav-item ml-3";
                    ASPButtonEx objASPNETButtonENEx = clsASPButtonBLEx.GetbtnAddNewRec4Gv();
                    objASPLiENEx.arrSubAspControlLst2.Add(x);
                    objASPUlENEx.arrSubAspControlLst2.Add(objASPLiENEx);
                };

                foreach (ASPControlGroupEx objInFor in arrControlGroupLst_New)
                {
                    objASPLiENEx = clsASPLiBLEx.GetEmptyLi();
                    objASPLiENEx.Class = "nav-item ml-3";
                    //ASPButtonEx objASPNETButtonENEx = clsASPButtonBLEx.GetbtnAddNewRec4Gv();
                    objASPLiENEx.arrSubAspControlLst2.Add(objInFor);
                    objASPUlENEx.arrSubAspControlLst2.Add(objASPLiENEx);
                }

                objASPDivENEx_Function.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
                //生成GridView的代码;

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }
        public string ClsName4WucTabName4Gv()
        {
            string strClsName = string.Format("wuc{0}4Gv", objViewInfoENEx.TabName_Out);
            return strClsName;
        }
        private string gfunRadioClick()
        {
            clsTitleStyleEN objTitleStyle = clsTitleStyleBL.GetObjByTitleStyleIdCache(objViewInfoENEx.objViewStyleEN.TitleStyleId);
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp;     ///临时变量;
            ///生成Label的代码;
            strCodeForCs.Append("\r\n" + "<script language = \"javascript\">");
            strCodeForCs.Append("\r\n" + "<!--");
            strCodeForCs.Append("\r\n" + "function radioClick()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (document.Form1.RadioName != null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "for (i = 0; i<document.Form1.RadioName.length; i++)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (document.Form1.RadioName[i].checked == true)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "document.Form1.rd.value = document.Form1.RadioName[i].value;");
            //document.getElementById("TextBox1").value = document.Form1.rd.value;
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//-->");
            strCodeForCs.Append("\r\n" + "</script>");

            intZIndex += 1;
            return strCodeForCs.ToString();


        }

        private string GenViewTitle(string strTitle, clsViewInfoENEx objViewInfoENEx)
        {
            if (string.IsNullOrEmpty(objViewInfoENEx.objViewStyleEN.TitleStyleId) == true)
            {
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.AppendFormat("在界面:{0}中,没有设置标题类型,请检查!", objViewInfoENEx.ViewName);
                throw new Exception(sbMsg.ToString());
            }
            clsTitleStyleEN objTitleStyle = clsTitleStyleBL.GetObjByTitleStyleIdCache(objViewInfoENEx.objViewStyleEN.TitleStyleId);
            if (objTitleStyle == null)
            {
                string strMsg = string.Format("(errid:BlEx000044)标题模式Id:[{0}]没有相应的对象,请检查!(AutoGC6Cs_VWeb_Net2005:GenViewTitle)", objViewInfoENEx.objViewStyleEN.TitleStyleId);
                throw new Exception(strMsg);
            }
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp;     ///临时变量;
            ///生成Label的代码;
            switch (objTitleStyle.TitleTypeId)
            {
                case "01":
                    strCodeForCs.AppendFormat("\r\n" + "<table id = \"tabTitle\" style = \"z-index: 102; left: 8px; position: absolute; top: 1px\" cellspacing = \"1\" ");
                    strCodeForCs.AppendFormat("\r\n" + "cellpadding = \"1\" width = \"100%\" bgColor = \"{0}\" border = \"0\">",
                      objTitleStyle.BackColor);
                    strCodeForCs.AppendFormat("\r\n" + "<tr>");
                    strCodeForCs.AppendFormat("\r\n" + "<td bgColor = \"{0}\">",
                      objTitleStyle.BackColor);
                    strCodeForCs.AppendFormat("\r\n" + "<asp:Label id = \"lblViewTile\" runat = \"server\" Font-Size = \"Small\" Font-Names = \"宋体\" ForeColor = \"{1}\" Font-Bold = \"True\">{0}</asp:Label>",
                      strTitle, objTitleStyle.ForeColor);
                    strCodeForCs.AppendFormat("\r\n" + "</td>");
                    strCodeForCs.AppendFormat("\r\n" + "</tr>");
                    strCodeForCs.AppendFormat("\r\n" + "</table>");
                    break;
                case "02":

                    break;
                case "03":
                    ASPDivEx objDiv = new ASPDivEx();
                    objDiv.Style = "position: relative; width: 648px; height: 37px; left: 0px; top: 0px;";
                    ASPLabelEx objLabel = new ASPLabelEx();
                    objLabel.CtrlId = "lblViewTitle";
                    objLabel.Class = "h5";
                    //objLabel.Is4PureHtml = true;
                    objLabel.Text = strTitle;
                    objDiv.arrSubAspControlLst2.Add(objLabel);
                    ASPLabelEx objLabel_ErrMsg = clsASPLabelBLEx.GetLabel4ErrMsg("lblMsg_List", true);
                    objDiv.arrSubAspControlLst2.Add(objLabel_ErrMsg);
                    objDiv.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

                    break;
            }

            intZIndex += 1;
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 生成CheckBox控件
        /// </summary>
        /// <param name = "objCheckStyle"></param>
        /// <returns></returns>
        public string GenCheckBoxNoPosition(clsCheckStyleEN objCheckStyle, string strCheckId, string strCheckText)
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp;     ///临时变量;
            try
            {
                objCheckStyle.StyleZindex = intZIndex + 1;
                objCheckStyle.StyleLeft = (int)intCurrLeft;
                objCheckStyle.StyleTop = (int)intCurrTop;

                ///生成CheckBox的代码;
                ///
                //生成控件的<开始标志>和<ID>
                strCodeForCs.Append("\r\n" + "<td>");
                strCodeForCs.AppendFormat("\r\n" + "<asp:CheckBox id = \"{0}\" ",
                  strCheckId);
                //生成<控件样式Style>
                //生成<高度>和<宽度>
                strCodeForCs.AppendFormat("\r\n" + "style = \"z-index: {0}; Width:{1}px; Height:{2}px;\" ",
                  objCheckStyle.StyleZindex,
                  objCheckStyle.Width, objCheckStyle.Height);
                //生成运行模式是否在服务器运行
                strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" ",
                  objCheckStyle.Runat);

                //生成<字号>和<字体>
                //strCodeForCs.AppendFormat("\r\n" + "Font-Size = \"{0}\" Font-Names = \"{1}\" ", 
                //  objCheckStyle.FontSize, objCheckStyle.FontName);
                //生成<显示文本> 
                strCodeForCs.AppendFormat("\r\n" + "Text = \"{0}\" ", strCheckText);

                //生成<结束标志>
                strCodeForCs.Append("\r\n" + "CssClass = \"Check_Defa\"></asp:CheckBox>");

                strCodeForCs.Append("\r\n" + "</td>");

                intZIndex += 1;

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
        /// 生成{组合控件},即左边的标签,和右边的输入条件的控件
        /// </summary>
        /// <param name = "objLabelStyle"></param>
        /// <param name = "strLabelId"></param>
        /// <param name = "strLabelText"></param>
        /// <param name = "objGenCtlStyle"></param>
        /// <param name = "strCtlTypeName"></param>
        /// <param name = "strCtlId"></param>
        /// <returns></returns>
        public string GenCombineCtlNoPosition(clsLabelStyleEN objLabelStyle, string strLabelId, string strLabelText,
          clsGenCtlStyleEN objGenCtlStyle, string strCtlTypeName, string strCtlId)
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp;     ///临时变量;
            objLabelStyle.StyleZindex = intZIndex + 1;
            objLabelStyle.StyleLeft = (int)intCurrLeft;
            objLabelStyle.StyleTop = (int)intCurrTop;
            ///生成Label的代码;
            ///      
            strCodeForCs.Append("\r\n" + "<td>");

            strCodeForCs.AppendFormat("\r\n" + "<asp:Label id = \"{0}\" style = \"z-index: {1};\" ",
              strLabelId, objLabelStyle.StyleZindex, objLabelStyle.Width, objLabelStyle.Height);
            strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" CssClass = \"NameLabel\">",
              objLabelStyle.Runat);
            strCodeForCs.AppendFormat("{0}</asp:Label>",
              strLabelText);
            strCodeForCs.Append("\r\n" + "</td>");

            intZIndex += 1;

            objGenCtlStyle.StyleZindex = intZIndex + 1;
            objGenCtlStyle.StyleLeft = (int)intCurrLeft + objLabelStyle.Width + 5;
            //objGenCtlStyle.StyleLeft = (int)intCurrLeft + 5;
            objGenCtlStyle.StyleTop = (int)intCurrTop;
            ///生成右边控件的代码;
            strCodeForCs.Append("\r\n" + "<td>");

            strCodeForCs.AppendFormat("\r\n" + "<asp:{0} id = \"{1}\" style = \"z-index: {2}; \" ",
              strCtlTypeName, strCtlId, objGenCtlStyle.StyleZindex, objGenCtlStyle.Width, objGenCtlStyle.Height);

            strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" CssClass = \"TextBox_Defa\">",
              objGenCtlStyle.Runat);
            strCodeForCs.AppendFormat("\r\n" + "</asp:{0}>",
              strCtlTypeName);
            strCodeForCs.Append("\r\n" + "</td>");

            intZIndex += 1;
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 生成Button控件
        /// </summary>
        /// <param name = "objCheckStyle"></param>
        /// <returns></returns>
        public string GenButtonNoPosition(clsButtonStyleEN objButtonStyle, string strButtonId, string strButtonText, string strOnClick)
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp;     ///临时变量;
            try
            {
                objButtonStyle.StyleZindex = intZIndex + 1;
                objButtonStyle.StyleLeft = (int)intCurrLeft;
                objButtonStyle.StyleTop = (int)intCurrTop;

                ///生成Button的代码;
                ///
                //生成控件的<开始标志>和<ID>
                strCodeForCs.AppendFormat("\r\n" + "<asp:Button id = \"{0}\" ",
                  strButtonId);
                //生成<控件样式Style>
                //生成<高度>和<宽度>
                strCodeForCs.AppendFormat("\r\n" + "style = \"z-index: {0}; Width:{2}px; Height:{3}px;\" ",
                  objButtonStyle.StyleZindex, objButtonStyle.StyleLeft,
                  objButtonStyle.Width, objButtonStyle.Height);

                //生成运行模式是否在服务器运行
                strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" ",
                  objButtonStyle.Runat);

                //生成<字号>和<字体>
                //				strCodeForCs.AppendFormat("\r\n" + "Font-Size = \"{0}\" Font-Names = \"{1}\" ", 
                //					objButtonStyle.FontSize, objButtonStyle.FontName);
                //生成<显示文本> 
                strCodeForCs.AppendFormat("\r\n" + "Text = \"{0}\" CssClass = \"btn btn-primary btn-sm\" ", strButtonText);
                //生成单击事件
                strCodeForCs.AppendFormat("\r\n" + "OnClick = \"{0}\" ", strOnClick);

                //生成<结束标志>
                strCodeForCs.Append("\r\n" + "></asp:Button>");

                intZIndex += 1;

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
        /// 定义用于编辑的层Div,该层可以被弹出
        /// </summary>
        /// <param name="objvFunction4GeneCodeEN"></param>
        /// <returns></returns>
        public string Gen_List_Template_DefDiv4ListRegion(CodeElement objCodeElement_Parent)
        {
            clsViewRegionENEx objViewRegionEx = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.ListRegion_0002);
            CodeElement objCodeElement_Template = new CodeElement { Name = "template", ElementType = CodeElementType.Template, Modifiers = "export abstract" };
            objCodeElement_Parent.Children.Add(objCodeElement_Template);
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "<template>");
            strCodeForCs.Append("\r\n" + $"<div>");
            strCodeForCs.Append("\r\n" + $"<span v-if=\"emptyRecNumInfo !== '' && items.length === 0\">{{ emptyRecNumInfo }}</span>");
            strCodeForCs.Append("\r\n" + $"<template v-else>");
            strCodeForCs.Append("\r\n" + Gen_List_Table_All(objCodeElement_Template));
            strCodeForCs.Append("\r\n" + " </template>");

            strCodeForCs.Append("\r\n" + "</div>");
            strCodeForCs.Append("\r\n" + " </template>");
            objCodeElement_Template.CodeContent = strCodeForCs.ToString();

            return strCodeForCs.ToString();
        }



        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(Vue_ViewScript_List_TS4Html);
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
            string strClassName = string.Format("{0}_List", objViewInfoENEx.TabName);
            clsViewRegionENEx objViewRegionENEx = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.ListRegion_0002);
            if (objViewRegionENEx != null && string.IsNullOrEmpty(objViewRegionENEx.ClsName) == false)
            {
                strClassName = objViewRegionENEx.ClsName;
            }
            this.ClsName = strClassName;
            objViewInfoENEx.ClsName = this.ClsName;
        }
  
        public string Gen_WebView_Vue_Code4FeatureRegion()
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;
            strCodeForCs.Append("\r\n" + "<!-- 功能区 -->");
            strCodeForCs.Append("\r\n" + GenFeatureRegion(objViewInfoENEx.objViewRegion_List, objViewInfoENEx));

            return strCodeForCs.ToString();
        }
        public string Gen_WebView_Vue_Code4ListRegion()
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;
            strCodeForCs.Append("\r\n" + "<!-- 列表层 -->");
            strCodeForCs.Append("\r\n" + "<div id = \"divList\" class = \"div_List\">");

            strCodeForCs.Append("\r\n" + "<div id = \"divDataLst\" class = \"div_List\">");

            strCodeForCs.Append("\r\n" + "</div>");
            strCodeForCs.Append("\r\n" + "<div id = \"divPager\" class = \"pager\" value=\"1\">");
            strCodeForCs.Append("\r\n" + "@Html.Partial(\"~/Pages/PubWebClass/pager.cshtml\")");
            strCodeForCs.Append("\r\n" + "</div>");
            strCodeForCs.Append("\r\n" + "</div>");
            return strCodeForCs.ToString();
        }




        public string Gen_WApi_Ts_BindTab4Func(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (this.IsUseFunc == false) return "";

            IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFlds_GridRegion = objViewInfoENEx.arrFeatureRegionFlds.Where(x => x.RegionId == objViewInfoENEx.objViewRegion_Feature.RegionId);

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.AppendFormat("\r\n /** 显示{0}对象的所有属性值", TabName_Out4ListRegion4GC);
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @param divContainer:显示容器");
            strCodeForCs.AppendFormat("\r\n * @param arr{0}ExObjLst:需要绑定的对象列表",
                ViewMainTabName4GC);
            strCodeForCs.Append("\r\n" + " **/");

            strCodeForCs.AppendFormat("\r\n" + "public async BindTab_{0}4Func(divContainer: HTMLDivElement, arr{0}ExObjLst: Array<cls{0}ENEx>) ",
                TabName_Out4ListRegion4GC);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.BindTab_{0}4Func.name;", TabName_Out4ListRegion4GC);


            strCodeForCs.Append("\r\n" + "if (divContainer == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(Format(\"{0}不存在!\",divContainer));");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + $"const divDataLst = GetDivObjInDivObj(divContainer, 'divDataLst');");
            ImportClass objImportClass = AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetDivObjInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

            CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

            //strCodeForCs.Append("\r\n" + "const sstrFldName: Array <string> = new Array<string>();");
            //strCodeForCs.Append("\r\n" + "const sstrColHeader: Array <string> = new Array<string>();");
            //strCodeForCs.Append("\r\n" + "sstrFldName.push(\"IdentityID\"); sstrColHeader.push(\"身份Id\");");
            strCodeForCs.Append("\r\n" + "const arrDataColumn: Array <clsDataColumn> =");
            strCodeForCs.Append("\r\n" + "       [");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "fldName: \"\",");
            strCodeForCs.Append("\r\n" + "sortBy: \"\",");
            strCodeForCs.Append("\r\n" + "sortFun: SortFun,");
            strCodeForCs.Append("\r\n" + "getDataSource: \"\",");
            strCodeForCs.Append("\r\n" + "colHeader: \"\",");
            strCodeForCs.Append("\r\n" + "text: \"\",");
            strCodeForCs.Append("\r\n" + "tdClass: \"text-left\",");
            strCodeForCs.Append("\r\n" + "columnType: \"CheckBox\",");
            strCodeForCs.Append("\r\n" + "orderNum: 1,");
            strCodeForCs.Append("\r\n" + "funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}");
            strCodeForCs.Append("\r\n" + "},");
            var arrDGRegionFlds = objViewInfoENEx.arrDGRegionFldSet.OrderBy(x => x.SeqNum);
            foreach (clsDGRegionFldsENEx objDGRegionFldsENEx in arrDGRegionFlds)
            {
                if (objDGRegionFldsENEx.ObjFieldTabENEx == null) continue;
                string strFldName4Bind = objDGRegionFldsENEx.PropertyName(this.IsFstLcase);
                if (objDGRegionFldsENEx.IsUseFunc())
                {
                    strFldName4Bind = objDGRegionFldsENEx.DataPropertyName_FstLcase(this.IsFstLcase);
                }
                string strSortBy = objDGRegionFldsENEx.SortExpression_FstLcase(this.IsFstLcase);

                if (string.IsNullOrEmpty(objDGRegionFldsENEx.SortExpression) == true)
                {
                    if (string.IsNullOrEmpty(objDGRegionFldsENEx.DataPropertyName()) == false)
                    {
                        strSortBy = objDGRegionFldsENEx.DataPropertyName_FstLcase(this.IsFstLcase);
                    }
                    else
                    {
                        var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objDGRegionFldsENEx.FldId, objViewInfoENEx.PrjId);
                        if (objFieldTab != null)
                        {
                            strSortBy = objFieldTab.PropertyName(this.IsFstLcase);
                        }
                    }
                }

                strCodeForCs.Append("\r\n" + "{");
                var objPrjTabFld = clsPrjTabFldBLEx.GetObjByTabIdAndFldIdCache(objDGRegionFldsENEx.ObjPrjTab().TabId, objDGRegionFldsENEx.FldId, objViewInfoENEx.PrjId);
                if (string.IsNullOrEmpty(objDGRegionFldsENEx.DataPropertyName()) == false)
                {
                    strCodeForCs.AppendFormat("\r\n" + "fldName: cls{0}ENEx.con_{1},", TabName_Out4ListRegion4GC, objDGRegionFldsENEx.DataPropertyName4GC());
                }
                else if (objPrjTabFld != null && objPrjTabFld.IsForExtendClass)
                {
                    strCodeForCs.AppendFormat("\r\n" + "fldName: cls{0}ENEx.con_{1},", TabName_Out4ListRegion4GC, objDGRegionFldsENEx.FldName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "fldName: cls{0}EN.con_{1},", TabName_Out4ListRegion4GC, objDGRegionFldsENEx.FldName);
                }
                if (string.IsNullOrEmpty(objDGRegionFldsENEx.SortExpression) == false)
                {
                    strCodeForCs.AppendFormat("\r\n" + "sortBy: \"{0}\",", objDGRegionFldsENEx.SortExpression_FstLcase(this.IsFstLcase));
                }
                else if (objPrjTabFld != null && objPrjTabFld.IsForExtendClass)
                {
                    strCodeForCs.AppendFormat("\r\n" + "sortBy: cls{0}ENEx.con_{1},", TabName_Out4ListRegion4GC, objDGRegionFldsENEx.FldName);
                }
                else
                {
                    if (string.IsNullOrEmpty(objDGRegionFldsENEx.DataPropertyName()) == false)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "sortBy: cls{0}ENEx.con_{1},", TabName_Out4ListRegion4GC, objDGRegionFldsENEx.DataPropertyName4GC());
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "sortBy: cls{0}EN.con_{1},", TabName_Out4ListRegion4GC, objDGRegionFldsENEx.FldName);
                    }
                }
                strCodeForCs.Append("\r\n" + "sortFun: SortFun,");
                strCodeForCs.Append("\r\n" + "getDataSource: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"{0}\",", objDGRegionFldsENEx.HeaderText);
                strCodeForCs.Append("\r\n" + "text: \"\",");
                strCodeForCs.Append("\r\n" + "tdClass: \"text-left\",");
                strCodeForCs.Append("\r\n" + "columnType: \"Label\",");
                strCodeForCs.AppendFormat("\r\n" + "orderNum: {0},", objDGRegionFldsENEx.SeqNum + 1);
                strCodeForCs.Append("\r\n" + "funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}");
                strCodeForCs.Append("\r\n" + "},");
                //strCodeForCs.AppendFormat("\r\n" + "sstrFldName.push(\"{0}\"); sstrColHeader.push(\"{1}\");",
                //    objDGRegionFldsENEx.FldName,
                //    objDGRegionFldsENEx.ColCaption);
            }
            if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.UpdateRecord_Gv_0174).Count() > 0)  //在DG中是否有修改按钮
            {

                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "fldName: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "sortBy: \"\",");
                strCodeForCs.Append("\r\n" + "sortFun: SortFun,");
                strCodeForCs.Append("\r\n" + "getDataSource: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"修改\",");
                strCodeForCs.Append("\r\n" + "text: \"修改\",");
                strCodeForCs.Append("\r\n" + "tdClass: \"text-left\",");
                strCodeForCs.Append("\r\n" + "columnType: \"Button\",");
                strCodeForCs.Append("\r\n" + "orderNum: 1,");
                strCodeForCs.Append("\r\n" + "funcName: (strKeyId: string, strText: string) => { ");
                strCodeForCs.Append("\r\n" + "const btn1: HTMLElement = document.createElement(\"button\");");
                strCodeForCs.Append("\r\n" + "btn1.innerText = strText;");
                strCodeForCs.Append("\r\n" + "btn1.className = \"btn btn-outline-info btn-sm\";");

                strCodeForCs.Append("\r\n" + "btn1.onclick = function() {");
                strCodeForCs.Append("\r\n" + $"{ThisClsName}.vuebtn_Click('UpdateRecordInTab', strKeyId);");
                strCodeForCs.Append("\r\n" + "};");
                strCodeForCs.Append("\r\n" + "return btn1;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "},");
            }
            if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.DelRecord_Gv_0175).Count() > 0)
            {
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "fldName: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "sortBy: \"\",");
                strCodeForCs.Append("\r\n" + "sortFun: SortFun,");
                strCodeForCs.Append("\r\n" + "getDataSource: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"删除\",");
                strCodeForCs.Append("\r\n" + "text: \"删除\",");
                strCodeForCs.Append("\r\n" + "tdClass: \"text-left\",");
                strCodeForCs.Append("\r\n" + "columnType: \"Button\",");
                strCodeForCs.Append("\r\n" + "orderNum: 1,");
                strCodeForCs.Append("\r\n" + "funcName: (strKeyId: string, strText: string) => { ");
                strCodeForCs.Append("\r\n" + "const btn1: HTMLElement = document.createElement(\"button\");");
                strCodeForCs.Append("\r\n" + "btn1.innerText = strText;");
                strCodeForCs.Append("\r\n" + "btn1.className = \"btn btn-outline-info btn-sm\";");

                strCodeForCs.Append("\r\n" + "btn1.onclick = function() {");
                strCodeForCs.Append("\r\n" + $"{ThisClsName}.vuebtn_Click('DelRecordInTab', strKeyId);");
                strCodeForCs.Append("\r\n" + "};");

                strCodeForCs.Append("\r\n" + "return btn1;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "},");
            }
            if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.DetailRecord_Gv_0181).Count() > 0)
            {
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "fldName: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "sortBy: \"\",");
                strCodeForCs.Append("\r\n" + "sortFun: SortFun,");
                strCodeForCs.Append("\r\n" + "getDataSource: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"详细信息\",");
                strCodeForCs.Append("\r\n" + "text: \"详细信息\",");
                strCodeForCs.Append("\r\n" + "tdClass: \"text-left\",");
                strCodeForCs.Append("\r\n" + "columnType: \"Button\",");
                strCodeForCs.Append("\r\n" + "orderNum: 1,");
                strCodeForCs.Append("\r\n" + "funcName: (strKeyId: string, strText: string) => { ");
                strCodeForCs.Append("\r\n" + "const btn1: HTMLElement = document.createElement(\"button\");");
                strCodeForCs.Append("\r\n" + "btn1.innerText = strText;");
                strCodeForCs.Append("\r\n" + "btn1.className = \"btn btn-outline-info btn-sm\";");

                strCodeForCs.Append("\r\n" + "btn1.onclick = function() {");
                strCodeForCs.Append("\r\n" + $"{ThisClsName}.vuebtn_Click('DetailRecordInTab', strKeyId);");
                strCodeForCs.Append("\r\n" + "};");

                strCodeForCs.Append("\r\n" + "return btn1;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "},");

            }
            if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.SelectRecord_Gv_0182).Count() > 0)
            {
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "fldName: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "sortBy: \"\",");
                strCodeForCs.Append("\r\n" + "sortFun: SortFun,");
                strCodeForCs.Append("\r\n" + "getDataSource: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"选择\",");
                strCodeForCs.Append("\r\n" + "text: \"选择\",");
                strCodeForCs.Append("\r\n" + "tdClass: \"text-left\",");
                strCodeForCs.Append("\r\n" + "columnType: \"Button\",");
                strCodeForCs.Append("\r\n" + "orderNum: 1,");
                strCodeForCs.Append("\r\n" + "funcName: (strKeyId: string, strText: string) => { ");
                strCodeForCs.Append("\r\n" + "const btn1: HTMLElement = document.createElement(\"button\");");
                strCodeForCs.Append("\r\n" + "btn1.innerText = strText;");
                strCodeForCs.Append("\r\n" + "btn1.className = \"btn btn-outline-info btn-sm\";");

                strCodeForCs.Append("\r\n" + "btn1.onclick = function() {");
                strCodeForCs.Append("\r\n" + $"{ThisClsName}.vuebtn_Click('SelectRecordInTab', strKeyId);");
                strCodeForCs.Append("\r\n" + "};");

                strCodeForCs.Append("\r\n" + "return btn1;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "},");

            }
            strCodeForCs.Append("\r\n" + "];");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "await this.ExtendFldFuncMap(arr{0}ExObjLst, arrDataColumn);", TabName_Out4ListRegion4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = `扩展字段值的映射出错,${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");



            strCodeForCs.Append("\r\n" + $"if (this.objPager.IsInit(divContainer, this.divName4Pager) == false)");
            strCodeForCs.Append("\r\n" + $"this.objPager.InitShow(divContainer, this.divName4Pager);");
            strCodeForCs.Append("\r\n" + "this.objPager.recCount = this.recCount;");
            strCodeForCs.Append("\r\n" + "this.objPager.pageSize = this.pageSize;");
            strCodeForCs.Append("\r\n" + $"this.objPager.ShowPagerV2(divContainer, this, this.divName4Pager);");
            //strCodeForCs.Append("\r\n" + "$(\"#divPager\").load(\"../PubWebClass/pager.html\");");
            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }



        public string Gen_List_Table_Head_OneRow(CodeElement objCodeElement_Parent)
        {
            CodeElement objCodeElement_Tr = new CodeElement { Name = "trHead", ElementType = CodeElementType.TrHead, Modifiers = "export abstract" };
            objCodeElement_Parent.Children.Add(objCodeElement_Tr);
            StringBuilder strCodeForCs = new StringBuilder();

            var arrDGRegionFlds = objViewInfoENEx.arrDGRegionFldSet.OrderBy(x => x.SeqNum);
            strCodeForCs.Append("\r\n" + $"<tr class=\"text-primary\">");
            strCodeForCs.Append("\r\n" + $"<th style = \"width: 30px\">");
            strCodeForCs.Append("\r\n" + $"<input v-model=\"selectAllChecked\" type=\"checkbox\" @change=\"selectAllRows\" />");
            strCodeForCs.Append("\r\n" + $"</th>");
            foreach (clsDGRegionFldsENEx objDGRegionFldsENEx in arrDGRegionFlds)
            {
                strCodeForCs.Append("\r\n" + Gen_List_tabHead_OneColumn(objDGRegionFldsENEx));
            }
            strCodeForCs.Append("\r\n" + $"<th v-if= \"showSelectColumn\"> 选择 </th>");
            strCodeForCs.Append("\r\n" + $"</tr>");
            objCodeElement_Tr.CodeContent = strCodeForCs.ToString();
            return strCodeForCs.ToString();
        }

        public string Gen_List_Table_Body_OneRow(CodeElement objCodeElement_Parent)
        {
            CodeElement objCodeElement_Tr = new CodeElement { Name = "trRow", ElementType = CodeElementType.TrRow, Modifiers = "export abstract" };
            objCodeElement_Parent.Children.Add(objCodeElement_Tr);
            StringBuilder strCodeForCs = new StringBuilder();
            StringBuilder sbChkKeyLst = new StringBuilder();

            var arrDGRegionFlds = objViewInfoENEx.arrDGRegionFldSet.OrderBy(x => x.SeqNum);

            if (objPrjTabEx_ListRegion.arrKeyFldSet.Count > 1)
            {
                int intIndex = 0;
                foreach (var objInFor in objPrjTabEx_ListRegion.arrKeyFldSet)
                {
                    if (intIndex == 0)
                    {
                        sbChkKeyLst.Append($" item.{ objInFor.ObjFieldTab0().PropertyName_TS(this.IsFstLcase)}");
                    }
                    else
                    {
                        sbChkKeyLst.Append($" + item.{objInFor.ObjFieldTab0().PropertyName_TS(this.IsFstLcase)}");
                    }
                    intIndex++;
                }

            }
            else
            {
                int intIndex = 0;
                foreach (var objInFor in objPrjTabEx_ListRegion.arrKeyFldSet)
                {
                    if (intIndex == 0)
                    {
                        sbChkKeyLst.Append($" item.{objInFor.ObjFieldTab0().PropertyName_TS(this.IsFstLcase)}");
                    }
                    else
                    {
                        sbChkKeyLst.Append($" + item.{objInFor.ObjFieldTab0().PropertyName_TS(this.IsFstLcase)}");
                    }
                    intIndex++;
                }

            }

            strCodeForCs.Append("\r\n" + $"<tr v-for=\"(item, index) in items\" :key = \"index\" class=\"text-secondary\">");
            strCodeForCs.Append("\r\n" + $"<td>");
            strCodeForCs.Append("\r\n" + $"<input :id=\"'chk' + {sbChkKeyLst.ToString()}\"");
            strCodeForCs.Append("\r\n" + $"v-model=\"item.checked\"");
            strCodeForCs.Append("\r\n" + $"type=\"checkbox\"");
            strCodeForCs.Append("\r\n" + $"name=\"chkInTab\"");
            strCodeForCs.Append("\r\n" + $"class=\"CheckInTab\" ");
            strCodeForCs.Append("\r\n" + $" />");
            strCodeForCs.Append("\r\n" + $"</td>");
            foreach (clsDGRegionFldsENEx objDGRegionFldsENEx in arrDGRegionFlds)
            {
                strCodeForCs.Append("\r\n" + Gen_List_tabBody_OneColumn(objDGRegionFldsENEx));
            }
            strCodeForCs.Append("\r\n" + $"<td v-if= \"showSelectColumn\" ><button @click = \"btnSubmitSel(item)\" > 选择 </button ></td> ");

            strCodeForCs.Append("\r\n" + $"</tr>");
            objCodeElement_Tr.CodeContent = strCodeForCs.ToString();
            return strCodeForCs.ToString();
        }

        public string Gen_List_tabHead_OneColumn(clsDGRegionFldsENEx objDGRegionFldsENEx)
        {
            if (objDGRegionFldsENEx.ObjFieldTabENEx == null) return "";
            string strFldName4Bind = objDGRegionFldsENEx.PropertyName(this.IsFstLcase);
            StringBuilder strCodeForCs = new StringBuilder();
            if (string.IsNullOrEmpty(objDGRegionFldsENEx.SortExpression) == true)
            {
                strCodeForCs.Append("\r\n" + $"<th>");
                strCodeForCs.Append("\r\n" + $"{objDGRegionFldsENEx.HeaderText}");
                strCodeForCs.Append("\r\n" + "</th>");
            }
            else
            {
                string strIsEx = "";
                if (string.IsNullOrEmpty(objDGRegionFldsENEx.OutFldId) == false)
                {
                    string strOutFldName = objDGRegionFldsENEx.OutFldName();
                    if (objDGRegionFldsENEx.SortExpression_FstLcase(this.IsFstLcase).IndexOf(strOutFldName, StringComparison.InvariantCultureIgnoreCase) > -1) strIsEx = "|Ex";
                }
                strCodeForCs.Append("\r\n" + $"<th @click = \"sortColumn('{objDGRegionFldsENEx.SortExpression_FstLcase(this.IsFstLcase)}{strIsEx}')\">");
                strCodeForCs.Append("\r\n" + $"{objDGRegionFldsENEx.HeaderText}");
                strCodeForCs.Append("\r\n" + $"<span>");
                strCodeForCs.Append("\r\n" + $"<i :class=\"sortColumnKey === '{objDGRegionFldsENEx.SortExpression_FstLcase(this.IsFstLcase)}{strIsEx}'? (sortDirection === 'Asc' ? 'arrow-up' : 'arrow-down'):'arrow-neutral'\"></i>");
                strCodeForCs.Append("\r\n" + "</span>");
                strCodeForCs.Append("\r\n" + "</th>");
            }
            return strCodeForCs.ToString();
        }

        public string Gen_List_tabBody_OneColumn(clsDGRegionFldsENEx objDGRegionFldsENEx)
        {
            if (objDGRegionFldsENEx.ObjFieldTabENEx == null) return "";
            string strFldName4Bind = objDGRegionFldsENEx.PropertyName(this.IsFstLcase);
            StringBuilder strCodeForCs = new StringBuilder();
            string strDataPropertyName = "";
            if (string.IsNullOrEmpty(objDGRegionFldsENEx.DataPropertyName()) == false)
            {
                strDataPropertyName = clsString.FstLcaseS(objDGRegionFldsENEx.DataPropertyName4GC());
            }
            else if (objDGRegionFldsENEx.ObjPrjTabFld() != null && objDGRegionFldsENEx.ObjPrjTabFld().IsForExtendClass)
            {
                strDataPropertyName = clsString.FstLcaseS(objDGRegionFldsENEx.FldName);
            }
            else
            {
                strDataPropertyName =clsString.FstLcaseS( objDGRegionFldsENEx.FldName);
            }

            strCodeForCs.Append("\r\n" + $"<td v-html=\"item.{strDataPropertyName}\"></td>");
            return strCodeForCs.ToString();
        }

        public string Gen_List_Table_All(CodeElement objCodeElement_Parent)
        {
            CodeElement objCodeElement_Table = new CodeElement { Name = "table", ElementType = CodeElementType.Table, Modifiers = "export abstract" };
            objCodeElement_Parent.Children.Add(objCodeElement_Table);
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + $"<table>");
            strCodeForCs.Append("\r\n" + $"<tbody>");
            strCodeForCs.Append("\r\n" + Gen_List_Table_Head_OneRow(objCodeElement_Table));
            strCodeForCs.Append("\r\n" + Gen_List_Table_Body_OneRow(objCodeElement_Table));
            strCodeForCs.Append("\r\n" + $"</tbody>");
            strCodeForCs.Append("\r\n" + $"</table>");
            objCodeElement_Table.CodeContent = strCodeForCs.ToString();
            return strCodeForCs.ToString();
        }

        public string Gen_List_Style_DefDiv4ListRegion(CodeElement objCodeElement_Parent)
        {
            CodeElement objCodeElement_Style = new CodeElement { Name = "style", ElementType = CodeElementType.Style, Modifiers = "export abstract" };
            objCodeElement_Parent.Children.Add(objCodeElement_Style);
            StringBuilder strCodeForCs = new StringBuilder();


            strCodeForCs.Append("\r\n" + "<style scoped>");
            strCodeForCs.Append("\r\n" + ".read-the-docs {");
            strCodeForCs.Append("\r\n" + "color: #888;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "");

            strCodeForCs.Append("\r\n" + ".arrow-neutral {");
            strCodeForCs.Append("\r\n" + "border: solid gray;");
                strCodeForCs.Append("\r\n" + "border-width: 0 2px 2px 0;");
            strCodeForCs.Append("\r\n" + "display: inline-block;");
            strCodeForCs.Append("\r\n" + "padding: 3px;");
            strCodeForCs.Append("\r\n" + "transform: rotate(45deg);");
                strCodeForCs.Append("\r\n" + "-webkit-transform: rotate(45deg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "/* 样式可根据实际情况自行调整 */");
            strCodeForCs.Append("\r\n" + ".arrow-up {");
            strCodeForCs.Append("\r\n" + "display: inline-block;");
            strCodeForCs.Append("\r\n" + "width: 0;");
            strCodeForCs.Append("\r\n" + "height: 0;");
            strCodeForCs.Append("\r\n" + "border-left: 5px solid transparent;");
            strCodeForCs.Append("\r\n" + "border-right: 5px solid transparent;");
            strCodeForCs.Append("\r\n" + "border-bottom: 5px solid #000; /* 箭头向上，可根据需要设置颜色 */");
            strCodeForCs.Append("\r\n" + "margin-left: 5px;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n");

           strCodeForCs.Append("\r\n" + ".arrow-down {");
            strCodeForCs.Append("\r\n" + "display: inline-block;");
            strCodeForCs.Append("\r\n" + "width: 0;");
            strCodeForCs.Append("\r\n" + "height: 0;");
            strCodeForCs.Append("\r\n" + "border-left: 5px solid transparent;");
            strCodeForCs.Append("\r\n" + "border-right: 5px solid transparent;");
            strCodeForCs.Append("\r\n" + "border-top: 5px solid #000; /* 箭头向下，可根据需要设置颜色 */");
            strCodeForCs.Append("\r\n" + "margin-left: 5px;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n");

            strCodeForCs.Append("\r\n" + "th:not(:last-child) {");
            strCodeForCs.Append("\r\n" + "margin-right: 10px;");
            strCodeForCs.Append("\r\n" + "border-right: 1px solid #ccc;");
            strCodeForCs.Append("\r\n" + "background-color: rgba(0, 0, 255, 0.6);");
            strCodeForCs.Append("\r\n" + "color: white;");
            strCodeForCs.Append("\r\n" + "font-weight: bold;");
            strCodeForCs.Append("\r\n" + "padding: 2px; /* 添加内边距 */");


                strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n");

            strCodeForCs.Append("\r\n" + "th:last-child {");
            strCodeForCs.Append("\r\n" + "margin-right: 0; /* Reset margin for the last column */");
            strCodeForCs.Append("\r\n" + "border-right: none; /* Remove the border for the last column */");
            strCodeForCs.Append("\r\n" + "background-color: rgba(0, 0, 255, 0.6);");
            strCodeForCs.Append("\r\n" + "color: white;");
            strCodeForCs.Append("\r\n" + "font-weight: bold;");
            strCodeForCs.Append("\r\n" + "padding: 2px; /* 添加内边距 */");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n");

            strCodeForCs.Append("\r\n" + ".Bakth:not(:last-child) {");
            strCodeForCs.Append("\r\n" + "margin-right: 10px; /* Adjust the value to control the spacing */");
            strCodeForCs.Append("\r\n" + "border-right: 1px solid #ccc; /* Adjust the color and width as needed */");
            strCodeForCs.Append("\r\n" + "background-color: #333; /* Adjust the color as needed */");
            strCodeForCs.Append("\r\n" + "color: #fff; /* Adjust the text color as needed */");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n");

            strCodeForCs.Append("\r\n" + "td {");
            strCodeForCs.Append("\r\n" + "border-right: 1px solid #ccc; /* Adjust the color and width as needed */");
            strCodeForCs.Append("\r\n" + "padding: 2px; /* 添加内边距 */");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n");

            strCodeForCs.Append("\r\n" + "tr:nth-child(odd) {");
            strCodeForCs.Append("\r\n" + "background-color: #f2f2f2; /* Adjust the color as needed for odd rows */");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n");

            strCodeForCs.Append("\r\n" + "tr:nth-child(even) {");
            strCodeForCs.Append("\r\n" + "background-color: #ffffff; /* Adjust the color as needed for even rows */");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "/* 添加表格单元格之间的空隙 */");
            strCodeForCs.Append("\r\n" + "table {");
            strCodeForCs.Append("\r\n" + "border-collapse: separate; /* 使用 separate 模式，允许单元格之间的空隙 */");
            strCodeForCs.Append("\r\n" + "border-spacing: 2px; /* 定义单元格之间的间距 */");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "</style>");
            objCodeElement_Style.CodeContent = strCodeForCs.ToString();
            return strCodeForCs.ToString();
        }


        public string Gen_List_Script_DefDiv4ListRegion(CodeElement objCodeElement_Parent)
        {
            CodeElement objCodeElement_Script = new CodeElement { Name = "script", ElementType = CodeElementType.Script, Modifiers = "export abstract" };
            objCodeElement_Parent.Children.Add(objCodeElement_Script);
            
            objCodeElement_Script.Children.Add(this.objCodeElement_Imports);

            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            //生成编辑区域代码 == == == == == == == == == == == == == == 
            try
            {
                strCodeForCs.Append("\r\n" + "<script lang=\"ts\">");
                strCodeForCs.Append("\r\n" + "import { defineComponent, ref,watchEffect } from \"vue\";");
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, new CodeElement
                {
                    Name = "defineComponent, ref,watchEffect",
                    ElementType = CodeElementType.Import,
                    Modifiers = "import",
                    CodeContent = "import { defineComponent, ref,watchEffect } from \"vue\";",
                    From = "vue"
                });

                strCodeForCs.Append("\r\n" + "import 'jquery/dist/jquery.min.js';");
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, new CodeElement
                {
                    Name = "jquery/dist/jquery.min.js",
                    CodeContent = "import 'jquery/dist/jquery.min.js';",
                    ElementType = CodeElementType.Import,
                    Modifiers = "import",
                    From = "jquery/dist/jquery.min.js"
                });
                strCodeForCs.Append("\r\n" + "import 'bootstrap/dist/js/bootstrap.min.js';");
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, new CodeElement
                {
                    Name = "bootstrap/dist/js/bootstrap.min.js",
                    CodeContent = "import 'bootstrap/dist/js/bootstrap.min.js';;",
                    ElementType = CodeElementType.Import,
                    Modifiers = "import",
                    From = "bootstrap/dist/js/bootstrap.min.js"
                });
                strCodeForCs.Append("\r\n" + "import 'bootstrap/dist/css/bootstrap.css';");
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, new CodeElement
                {
                    Name = "bootstrap/dist/css/bootstrap.css",
                    CodeContent = "import 'bootstrap/dist/css/bootstrap.css';",
                    ElementType = CodeElementType.Import,
                    Modifiers = "import",
                    From = "bootstrap/dist/css/bootstrap.css"
                });
                strCodeForCs.Append("\r\n" + "//import router from '@/router';");
                strCodeForCs.Append("\r\n" + "import { clsDataColumn } from '@/ts/PubFun/clsDataColumn';");
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, new CodeElement
                {
                    Name = "clsDataColumn",
                    ElementType = CodeElementType.Import,
                    CodeContent = "import { clsDataColumn } from '@/ts/PubFun/clsDataColumn';",
                    Modifiers = "import",
                    isPublic = true,
                    From = "@/ts/PubFun/clsDataColumn",
                });

                strCodeForCs.Append("\r\n" + "  export  default defineComponent({");
                strCodeForCs.Append("\r\n" + $"name: '{clsString.FirstUcaseS(ThisClsName.Replace("_",""))}',");

                strCodeForCs.Append("\r\n" + "        components: {");
                strCodeForCs.Append("\r\n" + "            // 组件注册");
                //strCodeForCs.AppendFormat("\r\n" + "{0}", objViewRegion_Edit.ClsName);
                strCodeForCs.Append("\r\n" + "        },");
                strCodeForCs.Append("\r\n" + Gen_List_Prop_Define(objCodeElement_Script));
                strCodeForCs.Append("\r\n" + Gen_List_Emits_Define(objCodeElement_Script));
                strCodeForCs.Append("\r\n" + Gen_List_Setup_Define(objCodeElement_Script));

                strCodeForCs.Append("\r\n" + Gen_List_watch_Define(objCodeElement_Script));


                strCodeForCs.Append("\r\n" + Gen_List_methods_Define(objCodeElement_Script));


                strCodeForCs.Append("\r\n" + "});");
                strCodeForCs.Append("\r\n" + "</script>");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            objCodeElement_Script.CodeContent = strCodeForCs.ToString();
            return strCodeForCs.ToString();
        }

        public string Gen_List_Setup_Fun_btnSubmitSel(CodeElement objCodeElement_Parent)
        {
            CodeElement objCodeElement_Method = new CodeElement { Name = "btnSubmitSel", ElementType = CodeElementType.Method, Modifiers = "export abstract" };
            objCodeElement_Parent.Children.Add(objCodeElement_Method);
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  * 提交编辑");
            strCodeForCs.AppendFormat("\r\n *({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + "const btnSubmitSel = (item: any) => {");

            strCodeForCs.Append("\r\n" + "emit('on-submit-sel', {");
            foreach (var objInFor in PrjTabEx_EditRegion.arrKeyFldSet)
            {
                strCodeForCs.Append("\r\n" + $"{objInFor.ObjFieldTab0().PropertyName_TS(this.IsFstLcase)}:item.{objInFor.ObjFieldTab0().PropertyName_TS(this.IsFstLcase)},");
                //strCodeForCs.Append("\r\n" + "tabId: item.tabId,");
            }
       
            strCodeForCs.Append("\r\n" + "content: '这是当前表的关键字',");
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "};");
            objCodeElement_Method.CodeContent = strCodeForCs.ToString();
            return strCodeForCs.ToString();
        }


        public string Gen_List_Setup_Fun_btnClickInRow(CodeElement objCodeElement_Parent)
        {
            CodeElement objCodeElement_Method = new CodeElement { Name = "btnClickInRow", ElementType = CodeElementType.Method, Modifiers = "export abstract" };
            objCodeElement_Parent.Children.Add(objCodeElement_Method);

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  * 提交编辑");
            strCodeForCs.AppendFormat("\r\n *({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + "const btnClickInRow = (item: any) => {");
            // console.log(item);
            // alert(item.tabId);
            //strCodeForCs.Append("\r\n" + "clsPrivateSessionStorage.tabId = item.tabId;");
            strCodeForCs.Append("\r\n" + "emit('on-edit-tab-relainfo', {");
            
            foreach (var objInFor in PrjTabEx_EditRegion.arrKeyFldSet)
            {
                strCodeForCs.Append("\r\n" + $"{objInFor.ObjFieldTab0().PropertyName_TS(this.IsFstLcase)}:item.{objInFor.ObjFieldTab0().PropertyName_TS(this.IsFstLcase)},");
                //strCodeForCs.Append("\r\n" + "tabId: item.tabId,");
            }
            strCodeForCs.Append("\r\n" + "content: '这是当前表的关键字',");
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "};");
            objCodeElement_Method.CodeContent = strCodeForCs.ToString();
            return strCodeForCs.ToString();
        }

        public string Gen_List_Setup_Fun_sortColumn(CodeElement objCodeElement_Parent)
        {
            CodeElement objCodeElement_Method = new CodeElement { Name = "sortColumn", ElementType = CodeElementType.Method, Modifiers = "export abstract" };
            objCodeElement_Parent.Children.Add(objCodeElement_Method);

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  * 提交编辑");
            strCodeForCs.AppendFormat("\r\n *({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");

            strCodeForCs.Append("\r\n" + "    const sortColumn = (columnKey: string) => {");
            strCodeForCs.Append("\r\n" + "if (sortColumnKey.value === columnKey)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "// 如果点击的是当前排序列，则切换排序方向");
            strCodeForCs.Append("\r\n" + "sortDirection.value = sortDirection.value === 'Asc' ? 'Desc' : 'Asc';");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "// 如果点击的是其他列，则设置新的排序列和排序方向");
            strCodeForCs.Append("\r\n" + "sortColumnKey.value = columnKey;");
            strCodeForCs.Append("\r\n" + "sortDirection.value = 'Asc';");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "emit('on-sort-column', {");
            strCodeForCs.Append("\r\n" + "sortColumnKey: sortColumnKey.value,");
            strCodeForCs.Append("\r\n" + "sortDirection: sortDirection.value,");
            strCodeForCs.Append("\r\n" + "content: '这是当前列表的列头排序',");
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "};");
            objCodeElement_Method.CodeContent = strCodeForCs.ToString();
            return strCodeForCs.ToString();
        }

        public string Gen_List_Setup_Fun_selectAllRows(CodeElement objCodeElement_Parent)
        {
            CodeElement objCodeElement_Method = new CodeElement { Name = "selectAllRows", ElementType = CodeElementType.Method, Modifiers = "export abstract" };
            objCodeElement_Parent.Children.Add(objCodeElement_Method);
            StringBuilder strCodeForCs = new StringBuilder();
            // 点击复选框列头触发的方法，用于修改所有记录的选中状态
            strCodeForCs.Append("\r\n" + "const selectAllRows = () => {");
            // selectAllChecked.value = !selectAllChecked.value;
            strCodeForCs.Append("\r\n" + "console.error(selectAllChecked.value);");
            strCodeForCs.Append("\r\n" + "};");
            objCodeElement_Method.CodeContent = strCodeForCs.ToString();
            return strCodeForCs.ToString();
        }

    }
}
