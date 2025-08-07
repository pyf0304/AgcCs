using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AgcCommBase;

using com.taishsoft.common;using com.taishsoft.comm_db_obj;
using com.taishsoft.util;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AutoGCLib
{
    /// <summary>
    /// 
    /// </summary>
    public class WinViewCode_QD_Gv4CSharp : AutoGC_Cs_VWin_PubFun
    {
        
        #region 构造函数
        public WinViewCode_QD_Gv4CSharp()
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            InitPageSetup();
        }
        public WinViewCode_QD_Gv4CSharp(string strViewId)
       : base(strViewId, "", "")
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            InitPageSetup();
        }
        public WinViewCode_QD_Gv4CSharp( string strViewId, string strPrjDataBaseId, string strPrjId)
        : base(strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            InitPageSetup();
        }
        #endregion
           
      

        /// <summary>
        /// 生成查询删除的主界面,在界面可以调用用于编辑的界面
        /// 注:不使用控件(NoCtrl)
        /// </summary>
        /// <returns></returns>
        public string A_GenQueryDelAffitUpdInsRecCodeWithLV_NoContral_Net2005(clsViewInfoENEx objViewInfoENEx, ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            //      Point pntLocation = new Point();
            string strTemp;
            ArrayList arrInnerCtlSet = new ArrayList();     //内部控件集合

            //让用户设置属性;
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;
            clsPubFun4BLEx.CheckDgStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.DgStyleId);
            clsPubFun4BLEx.CheckTitleStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.TitleStyleId);

            clsDataGridStyleEN objDGStyleEx = clsDataGridStyleBL.GetObjByDgStyleIdCache(objViewInfoENEx.objViewStyleEN.DgStyleId);
            clsBiDimDistribute objBiDimDistribute = new clsBiDimDistribute();
            objBiDimDistribute.ColNum = objViewInfoENEx.objViewRegion_Query.ColNum ?? 0;
            objBiDimDistribute.ColWidth = 250;
            objBiDimDistribute.LineHeight = 35;
            float intCtlWidth = objBiDimDistribute.GetCtlWidth();
            float intCtlHeight = objBiDimDistribute.GetCtlHeigh(objViewInfoENEx.objViewRegion_Query.FieldNum());
            ///检查编辑区域
            CheckEditRegion();
            //检查LIstView区域
            CheckListViewRegion();
            //检查查询区域
            CheckQueryRegion();
            //检查Excel导出区域
            CheckExcelExportRegion();
            objViewInfoENEx.WebFormName = "frm" + objViewInfoENEx.TabName + "_QD_LV";
           objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;

            objViewInfoENEx.WebFormFName = "frm" + objViewInfoENEx.TabName + "_QD_LV.cs";
            strRe_ClsName = objViewInfoENEx.WebFormName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}",
                objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebFormFName);

            try
            {
                //第0步:把控件中下拉框ComboBox转换成ComboBox
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.objCtlType.CtlTypeName == "DropDownList")
                    {
                        objEditRegionFldsEx.objCtlType.CtlTypeName = "ComboBox";
                        objEditRegionFldsEx.CtrlId4Win = objEditRegionFldsEx.CtrlId4Win.Replace("ddl", "cbo");
                    }
                }
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.objCtlType.CtlTypeName == "DropDownList")
                    {
                        objQryRegionFldsEx.objCtlType.CtlTypeName = "ComboBox";
                        objQryRegionFldsEx.CtrlId4Win = objQryRegionFldsEx.CtrlId4Win.Replace("ddl", "cbo");
                    }
                }
                //第一步:生成导入域名空间
                

                //类名开始
                ///
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objViewInfoENEx.CurrUserName, objViewInfoENEx));

                strCodeForCs.Append("\r\n" + "//生成与表相关的控件控制层代码");
                strCodeForCs.Append("\r\n" + "using System;");
                strCodeForCs.Append("\r\n" + "using System.Collections;");
                strCodeForCs.Append("\r\n" + "using System.Collections.Generic;");
                strCodeForCs.Append("\r\n" + "using System.ComponentModel;");
                strCodeForCs.Append("\r\n" + "using System.Data;");
                strCodeForCs.Append("\r\n" + "using System.Drawing;");
                strCodeForCs.Append("\r\n" + "using System.IO;");
                strCodeForCs.Append("\r\n" + "using System.Windows.Forms;");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.util;");
                strCodeForCs.Append("\r\n" + "using CommFunc4Win;");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.common;");

                clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objViewInfoENEx.PrjId); //
                strCodeForCs.AppendFormat("\r\n" + "using {0}.Entity;", objProject.PrjDomain);
                strCodeForCs.AppendFormat("\r\n" + "using {0}.BusinessLogic;", objProject.PrjDomain);

                strCodeForCs.Append("\r\n" + "");

                strCodeForCs.AppendFormat("\r\n" + "namespace {0}", objViewInfoENEx.NameSpace);
                strCodeForCs.Append("\r\n" + "{");
                //第二步:生成控件类名
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///		frm{0}_QD_LV 的摘要说明。", objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public partial class frm{0}_QD_LV : System.Windows.Forms.Form, IBindListView", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                //第三步:生成控件中变量的名称


                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;",
                  objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "private System.Data.DataTable objDT{0} = null;",
                  objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "private clsListViewSorter obj{0}Sorter;",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "private int intLastSelected{0}ColumIndex ;",
                  objViewInfoENEx.TabName_Out);

                //第四步:生成必需的设计器变量
                strCodeForCs.AppendFormat("\r\n" + "public frm{0}_QD_LV()",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "// 该调用是 Windows.Forms 窗体设计器所必需的。");
                strCodeForCs.Append("\r\n" + "InitializeComponent();");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "// TODO: 在 InitializeComponent 调用后添加任何初始化");
                strCodeForCs.AppendFormat("\r\n" + "obj{0}Sorter = new clsListViewSorter();",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "//为ListViewItemSorter指定排序类");
                strCodeForCs.AppendFormat("\r\n" + "this.lv{0}.ListViewItemSorter = obj{0}Sorter;",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "obj{0}Sorter.SortOrder = SortOrder.Ascending;",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "}");
                //第五步:清理所有正在使用的资源
                //第六步:组件设计器生成的代码
                //第七步:生成objViewInfoENEx.load代码

                strCodeForCs.AppendFormat("\r\n" + "private void frm{0}_QD_Load(object sender, System.EventArgs e)",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "// 在此处放置用户代码以初始化页面");
                //1、为下拉框设置数据源,绑定列表数据

                strCodeForCs.Append("\r\n" + "//1、为下拉框设置数据源,绑定列表数据");
                strCodeForCs.Append("\r\n" + "this.SetAllComboBox();");

                strCodeForCs.AppendFormat("\r\n" + "BindLv_{0}();",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "this.JudgebtnDelRec(); //用来判断删除按钮是否可用");
                strCodeForCs.Append("\r\n" + "this.JudgebtnUpdate(); //用来判断修改按钮是否可用");

                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "}");

                //生成下拉框的绑定函数
                strTemp = Genfun_SetAllComboBox4Query();
                strCodeForCs.Append(strTemp);

                //生成界面控件的相关属性
                strTemp = Genfun_ViewCtrlProperty4Query();
                strCodeForCs.Append(strTemp);


                //第九步:生成设置控件中关键字只读特性。SetKeyReadOnly
                //clsEditRegionFldsENEx objEditRegionKeyFld = getEditRegionKeyFld();
                //if (objEditRegionKeyFld != null)	//如果编辑区存在主关键字
                //{
                //  if (getEditRegionKeyFld().objPrjTabFldENEx.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                //  {
                //strCodeForCs.Append("\r\n" + "/// <summary>");
                //strCodeForCs.Append("\r\n" + "/// 在用户自定义控件中,设置关键字的值,是否只读");
                //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                //strCodeForCs.Append("\r\n" + "/// </summary>");
                //strCodeForCs.Append("\r\n" + "/// <param name = \"bolReadonly\">是否只读</param>");
                //    strCodeForCs.Append("\r\n" + "public void SetKeyReadOnly(bool bolReadonly)");
                //    strCodeForCs.Append("\r\n" + "{");
                //    strCodeForCs.AppendFormat("\r\n" + "{0}.ReadOnly = bolReadonly;", getEditRegionKeyFld().CtrlId4Win);
                //    strCodeForCs.Append("\r\n" + "}");
                //  }
                //}
                //第十步:生成Clear()函数。用来初始化控件中内部控件的值。
                strTemp = Genfun_Clear4QryRegion();
                strCodeForCs.Append(strTemp);

                //第十一步:生成设置缺省值的函数。设置该控件在插入状态下的缺省值;
                strTemp = Genfun_SetDefaultValue4QryRegion();
                strCodeForCs.Append(strTemp);

                ///设置该控件在插入状态下的缺省值;
                //第十二步:生成校验函数(IsValid())。校验自定义控件中自子控件的类型数值是否是合法正确的;
                strTemp = Genfun_IsValid();
                strCodeForCs.Append(strTemp);

                //第十三步:生成获取当前日期的字符串(getTodayStr) 获取当前日期的字符串以及获取当前月的字符串;
                //strTemp = clsPubFun4GC.GenGetCurrMonth();
                //strCodeForCs.Append(strTemp);
                //strTemp = clsPubFun4GC.GenGetTodayStr();
                //strCodeForCs.Append(strTemp);

                //第十四步:生成控件中下拉框的BIND函数,即添加下拉框列表项的函数;
                //strTemp = GenComboBoxBindFunction();
                //strCodeForCs.Append(strTemp);


                //第十五步:生成一些判断数据类型的的公共函数

                //				strTemp = clsPubFun4GC.GenIsDate();
                //				strCodeForCs.Append(strTemp);
                //strTemp = clsPubFun4GC.1GenIsDigit();
                //strCodeForCs.Append(strTemp);
                //strTemp = clsPubFun4GC.GenIsFloat();
                //strCodeForCs.Append(strTemp);
                //strTemp = clsPubFun4GC.GenIsNumeric();
                //strCodeForCs.Append(strTemp);

                //第十六步:生成用于组合查询条件的函数
                strTemp = GenCombineCondition(objViewInfoENEx.arrQryRegionFldSet, objViewInfoENEx);
                strCodeForCs.Append(strTemp);
                //strTemp = GenCombineConditionWithSel(objViewInfoENEx.arrQryRegionFldSet, objViewInfoENEx);
                //strCodeForCs.Append(strTemp);
                //strTemp = GenCombineConditionWithTabName(objViewInfoENEx.arrQryRegionFldSet, objViewInfoENEx);
                //strCodeForCs.Append(strTemp);



                //生成用来判断删除按钮是否可用
                strTemp = gfunGenJudgebtnDelete();
                strCodeForCs.Append(strTemp);
                //用来判断修改按钮是否可用
                strTemp = gfunGenJudgebtnUpdate();
                strCodeForCs.Append(strTemp);

                //第八步:生成绑定ListView的代码


                strTemp = gfunGenBindListView();
                strCodeForCs.Append(strTemp);


                //第九步:生成处理查询按钮的单击事件。

                strTemp = Gen_btnQuery_Click();
                strCodeForCs.Append(strTemp);

                //第十步:生成获取DataGrid中当前行的主键值。
                strTemp = gfunGenGetCurrKey4DataGrid();
                strCodeForCs.Append(strTemp);

                strTemp = gfunGenGetCurrKey4ListView();
                strCodeForCs.Append(strTemp);


                //第十一步:生成处理ListView的单击事件。
                strTemp = Gen_lvListView_Click();
                strCodeForCs.Append(strTemp);

                //第十四步:///生成修改的事件函数
                strTemp = Gen_btnUpdate_Click();
                strCodeForCs.Append(strTemp);

                //第十五步:///生成添加的事件函数

                strTemp = Gen_btnAdd_Click();
                strCodeForCs.Append(strTemp);


                //第十六步:生成删除按钮的单击事件函数

                strTemp = Gen_btnDelRec_Click();
                strCodeForCs.Append(strTemp);

                //第十七步:生成导出Excel按钮的单击事件函数
                strTemp = gfunGenbtnExportExcel4ListView_Click();
                strCodeForCs.Append(strTemp);
                strTemp = gfunGenExportExcel();
                strCodeForCs.Append(strTemp);
                strTemp = gfunGenExportExcel_SelColumns();
                strCodeForCs.Append(strTemp);

                //第十八步:生成LISTVIEW的列单击事件函数
                strTemp = gfunGenListView_ColumnClick();
                strCodeForCs.Append(strTemp);

                ///实现接口函数,通过子窗体调用,来实现本窗体(父窗体)的LISTVIEW重新绑定功能
                strTemp = gfunGenIBindListView_BindListView();
                strCodeForCs.Append(strTemp);

                //修改记录准备过程
                strTemp = GenUpdateRecordCode();
                strCodeForCs.Append(strTemp);

                //删除记录过程
                strTemp = GenDelRecordCode();
                strCodeForCs.Append(strTemp);

                //最后一步:生成类的结束符和域名空间的结束符
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            //把生成写到文件中;
            //clsPubFun4BLEx.SaveClassContentToFile(objViewInfoENEx.WebFormFName, strCodeForCs.ToString(), objViewInfoENEx.FolderName_Root, myEncoding);

            ////检查该文件名的文件夹名,并判断是否存在;
            //strFolder = clsString.ParentDir_S(objViewInfoENEx.WebFormFName);
            //if (System.IO.Directory.Exists(strFolder) == false)
            //{
            //    Directory.CreateDirectory(strFolder);
            //}

            //if (clsSysParaEN_Local.IsBackupForGeneCode  == true)
            //{
            //    string strSimpleFileName = clsString.GetSimpleFName_S(objViewInfoENEx.WebFormFName);
            //    string strFindFileFullFile = clsFile.FindFileFromFolder(objViewInfoENEx.FolderName_Root, strSimpleFileName);
            //    while (string.IsNullOrEmpty(strFindFileFullFile) == false)
            //    {
            //        string strMsg = string.Format("文件:{0}已经存在!", strFindFileFullFile);
            //        throw new Exception(strMsg);
            //    }
            //}
            ////UTF8Encoding utf8 = new UTF8Encoding(false);
            //clsFile.1CreateFileByString(objViewInfoENEx.WebFormFName, strCodeForCs.ToString(), myEncoding);
            return strCodeForCs.ToString();

        }


        /// <summary>
        /// 生成查询删除的主界面,在界面可以调用用于编辑的界面
        /// 注:不使用控件(NoCtrl),显示列表用DataGridView
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            //      Point pntLocation = new Point();
            string strTemp;
            ArrayList arrInnerCtlSet = new ArrayList();     //内部控件集合

            //让用户设置属性;
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;
            clsPubFun4BLEx.CheckDgStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.DgStyleId);
            clsPubFun4BLEx.CheckTitleStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.TitleStyleId);

            clsDataGridStyleEN objDGStyleEx = clsDataGridStyleBL.GetObjByDgStyleIdCache(objViewInfoENEx.objViewStyleEN.DgStyleId);
            clsBiDimDistribute objBiDimDistribute = new clsBiDimDistribute();
            objBiDimDistribute.ColNum = objViewInfoENEx.objViewRegion_Query.ColNum ?? 0;
            objBiDimDistribute.ColWidth = 250;
            objBiDimDistribute.LineHeight = 35;
            float intCtlWidth = objBiDimDistribute.GetCtlWidth();
            float intCtlHeight = objBiDimDistribute.GetCtlHeigh(objViewInfoENEx.objViewRegion_Query.FieldNum());
            ///检查编辑区域
            //CheckEditRegion();
            //检查LIstView区域
            CheckListViewRegion();
            //检查查询区域
            CheckQueryRegion();
            //检查Excel导出区域
            //CheckExcelExportRegion();
            objViewInfoENEx.WebFormName = "frm" + objViewInfoENEx.TabName + "_QD_DGV";
            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;

            objViewInfoENEx.WebFormFName = "frm" + objViewInfoENEx.TabName + "_QD_DGV.cs";

            strRe_ClsName = objViewInfoENEx.WebFormName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}",
                objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebFormFName);

            try
            {
                //第0步:把控件中下拉框ComboBox转换成ComboBox
                if (objViewInfoENEx.arrEditRegionFldSet4InUse != null)
                {
                    foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                    {
                        if (objEditRegionFldsEx.objCtlType.CtlTypeName == "DropDownList")
                        {
                            objEditRegionFldsEx.objCtlType.CtlTypeName = "ComboBox";
                            objEditRegionFldsEx.CtrlId4Win = objEditRegionFldsEx.CtrlId4Win.Replace("ddl", "cbo");
                        }
                    }
                }
                if (objViewInfoENEx.arrQryRegionFldSet != null)
                {
                    foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                    {
                        if (objQryRegionFldsEx.objCtlType.CtlTypeName == "DropDownList")
                        {
                            objQryRegionFldsEx.objCtlType.CtlTypeName = "ComboBox";
                            objQryRegionFldsEx.CtrlId4Win = objQryRegionFldsEx.CtrlId4Win.Replace("ddl", "cbo");
                        }
                    }
                }
                //第一步:生成导入域名空间
                

                //类名开始
                ///
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objViewInfoENEx.CurrUserName, objViewInfoENEx));

                strCodeForCs.Append("\r\n" + "//生成与表相关的控件控制层代码");
                strCodeForCs.Append("\r\n" + "using System;");
                strCodeForCs.Append("\r\n" + "using System.Collections;");
                strCodeForCs.Append("\r\n" + "using System.Collections.Generic;");
                strCodeForCs.Append("\r\n" + "using System.ComponentModel;");
                strCodeForCs.Append("\r\n" + "using System.Data;");
                strCodeForCs.Append("\r\n" + "using System.Drawing;");
                strCodeForCs.Append("\r\n" + "using System.IO;");
                strCodeForCs.Append("\r\n" + "using System.Windows.Forms;");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.util;");
                strCodeForCs.Append("\r\n" + "using CommFunc4Win;");
                strCodeForCs.Append("\r\n" + "");

                strCodeForCs.AppendFormat("\r\n" + "using {0};", objViewInfoENEx.NameSpace);

                clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objViewInfoENEx.PrjId); //
                strCodeForCs.AppendFormat("\r\n" + "using {0}.Entity;", objProject.PrjDomain);
                strCodeForCs.AppendFormat("\r\n" + "using {0}.BusinessLogic;", objProject.PrjDomain);

                strCodeForCs.Append("\r\n" + "using com.taishsoft.common;");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.datetime;");

                strCodeForCs.Append("\r\n" + "");

                strCodeForCs.AppendFormat("\r\n" + "namespace {0}", objViewInfoENEx.NameSpace);
                strCodeForCs.Append("\r\n" + "{");
                //第二步:生成控件类名
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///		frm{0}_QD_DGV 的摘要说明。", objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public partial class frm{0}_QD_DGV : System.Windows.Forms.Form, IBindListView", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                //第三步:生成控件中变量的名称


                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;",
                  objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "private System.Data.DataTable objDT{0} = null;",
                  objViewInfoENEx.TabName);
                //strCodeForCs.AppendFormat("\r\n" + "private clsListViewSorter obj{0}Sorter;",
                //  objViewInfoENEx.TabName_Out);
                //strCodeForCs.AppendFormat("\r\n" + "private int intLastSelected{0}ColumIndex ;",
                //  objViewInfoENEx.TabName_Out);

                //第四步:生成必需的设计器变量
                strCodeForCs.AppendFormat("\r\n" + "public frm{0}_QD_DGV()",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "// 该调用是 Windows.Forms 窗体设计器所必需的。");
                strCodeForCs.Append("\r\n" + "InitializeComponent();");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "// TODO: 在 InitializeComponent 调用后添加任何初始化");
                //strCodeForCs.AppendFormat("\r\n" + "obj{0}Sorter = new clsListViewSorter();",
                //  objViewInfoENEx.TabName_Out);
                //strCodeForCs.Append("\r\n" + "//为ListViewItemSorter指定排序类");
                //strCodeForCs.AppendFormat("\r\n" + "this.lv{0}.ListViewItemSorter = obj{0}Sorter;",
                //  objViewInfoENEx.TabName_Out);
                //strCodeForCs.AppendFormat("\r\n" + "obj{0}Sorter.SortOrder = SortOrder.Ascending;",
                //  objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "}");
                //第五步:清理所有正在使用的资源
                //第六步:组件设计器生成的代码
                //第七步:生成objViewInfoENEx.load代码

                strCodeForCs.AppendFormat("\r\n" + "private void frm{0}_QD_Load(object sender, System.EventArgs e)",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "// 在此处放置用户代码以初始化页面");
                //1、为下拉框设置数据源,绑定列表数据

                strCodeForCs.Append("\r\n" + "//1、为下拉框设置数据源,绑定列表数据");
                strCodeForCs.Append("\r\n" + "this.SetAllComboBox();");

                strCodeForCs.AppendFormat("\r\n" + "BindDgv_{0}();",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "this.JudgebtnDelRec(); //用来判断删除按钮是否可用");
                strCodeForCs.Append("\r\n" + "this.JudgebtnUpdate(); //用来判断修改按钮是否可用");

                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "}");

                //生成下拉框的绑定函数
                strTemp = Genfun_SetAllComboBox4Query();
                strCodeForCs.Append(strTemp);

                strTemp = Genfun_ViewCtrlProperty4Query();
                strCodeForCs.Append(strTemp);


                //第九步:生成设置控件中关键字只读特性。SetKeyReadOnly
                //clsEditRegionFldsENEx objEditRegionKeyFld = getEditRegionKeyFld();
                //if (objEditRegionKeyFld != null)	//如果编辑区存在主关键字
                //{
                //  if (getEditRegionKeyFld().objPrjTabFldENEx.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                //  {
                //strCodeForCs.Append("\r\n" + "/// <summary>");
                //strCodeForCs.Append("\r\n" + "/// 在用户自定义控件中,设置关键字的值,是否只读");
                //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                //strCodeForCs.Append("\r\n" + "/// </summary>");
                //strCodeForCs.Append("\r\n" + "/// <param name = \"bolReadonly\">是否只读</param>");
                //    strCodeForCs.Append("\r\n" + "public void SetKeyReadOnly(bool bolReadonly)");
                //    strCodeForCs.Append("\r\n" + "{");
                //    strCodeForCs.AppendFormat("\r\n" + "{0}.ReadOnly = bolReadonly;", getEditRegionKeyFld().CtrlId4Win);
                //    strCodeForCs.Append("\r\n" + "}");
                //  }
                //}
                //第十步:生成Clear()函数。用来初始化控件中内部控件的值。

                strTemp = Genfun_Clear4QryRegion();
                strCodeForCs.Append(strTemp);

                //第十一步:生成设置缺省值的函数。设置该控件在插入状态下的缺省值;
                ///设置该控件在插入状态下的缺省值;
                strTemp = Genfun_SetDefaultValue4QryRegion();
                strCodeForCs.Append(strTemp);

                //第十二步:生成校验函数(IsValid())。校验自定义控件中自子控件的类型数值是否是合法正确的;
                strTemp = Genfun_IsValid();
                strCodeForCs.Append(strTemp);

                //第十三步:生成获取当前日期的字符串(getTodayStr) 获取当前日期的字符串以及获取当前月的字符串;
                //strTemp = clsPubFun4GC.GenGetCurrMonth();
                //strCodeForCs.Append(strTemp);
                //strTemp = clsPubFun4GC.GenGetTodayStr();
                //strCodeForCs.Append(strTemp);

                //第十四步:生成控件中下拉框的BIND函数,即添加下拉框列表项的函数;
                //strTemp = GenComboBoxBindFunction();
                //strCodeForCs.Append(strTemp);


                //第十五步:生成一些判断数据类型的的公共函数

                //				strTemp = clsPubFun4GC.GenIsDate();
                //				strCodeForCs.Append(strTemp);
                //strTemp = clsPubFun4GC.1GenIsDigit();
                //strCodeForCs.Append(strTemp);
                //strTemp = clsPubFun4GC.GenIsFloat();
                //strCodeForCs.Append(strTemp);
                //strTemp = clsPubFun4GC.GenIsNumeric();
                //strCodeForCs.Append(strTemp);

                //第十六步:生成用于组合查询条件的函数
                strTemp = GenCombineCondition(objViewInfoENEx.arrQryRegionFldSet, objViewInfoENEx);
                strCodeForCs.Append(strTemp);
                //strTemp = GenCombineConditionWithSel(objViewInfoENEx.arrQryRegionFldSet, objViewInfoENEx);
                //strCodeForCs.Append(strTemp);
                //strTemp = GenCombineConditionWithTabName(objViewInfoENEx.arrQryRegionFldSet, objViewInfoENEx);
                //strCodeForCs.Append(strTemp);

                //生成用来判断删除按钮是否可用
                strTemp = gfunGenJudgebtnDelete4DataGridView();
                strCodeForCs.Append(strTemp);
                //用来判断修改按钮是否可用
                strTemp = gfunGenJudgebtnUpdate4DataGridView();
                strCodeForCs.Append(strTemp);

                //第八步:生成绑定ListView的代码

                strTemp = gfunGenBindDataGridView();
                strCodeForCs.Append(strTemp);


                //第九步:生成处理查询按钮的单击事件。

                strTemp = Gen_btnQuery_Click4Dgv();
                strCodeForCs.Append(strTemp);


                //第十步:生成获取DataGrid中当前行的主键值。
                strTemp = gfunGenGetCurrKey4DataGrid();
                strCodeForCs.Append(strTemp);

                strTemp = gfunGenGetCurrKey4DataGridView();
                strCodeForCs.Append(strTemp);

                strTemp = gfunGenGetCurrKey4ListView();
                strCodeForCs.Append(strTemp);


                //第十一步:生成处理ListView的单击事件。
                strCodeForCs.AppendFormat("\r\n" + "private void dgv{0}_Click(object sender, System.EventArgs e)",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "this.JudgebtnDelRec(); //用来判断删除按钮是否可用");
                strCodeForCs.Append("\r\n" + "this.JudgebtnUpdate(); //用来判断修改按钮是否可用");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.AppendFormat("\r\n" + "private void dgv{0}_CellClick(object sender, DataGridViewCellEventArgs e)",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "this.JudgebtnDelRec(); //用来判断删除按钮是否可用");
                strCodeForCs.Append("\r\n" + "this.JudgebtnUpdate(); //用来判断修改按钮是否可用");
                strCodeForCs.Append("\r\n" + "}");

                //第十四步:///生成修改的事件函数
                strTemp = Gen_btnUpdate_Click();
                strCodeForCs.Append(strTemp);


                //第十五步:///生成添加的事件函数
                strTemp = Gen_btnAdd_Click();
                strCodeForCs.Append(strTemp);



                //第十六步:生成删除按钮的单击事件函数
                strTemp = Gen_btnDelRec_Click();
                strCodeForCs.Append(strTemp);

                //第十七步:生成导出Excel按钮的单击事件函数
                strTemp = gfunGenbtnExportExcel4ListView_Click();
                strCodeForCs.Append(strTemp);
                strTemp = gfunGenExportExcel();
                strCodeForCs.Append(strTemp);
                strTemp = gfunGenExportExcel_SelColumns();
                strCodeForCs.Append(strTemp);

                //第十八步:生成LISTVIEW的列单击事件函数
                //strTemp = gfunGenListView_ColumnClick();
                //strCodeForCs.Append(strTemp);

                ///实现接口函数,通过子窗体调用,来实现本窗体(父窗体)的LISTVIEW重新绑定功能
                strTemp = gfunGenIBindListView_BindListView4DataGridView();
                strCodeForCs.Append(strTemp);

                //修改记录准备过程
                strTemp = GenUpdateRecordCode4DataGridView();
                strCodeForCs.Append(strTemp);

                //删除记录过程
                strTemp = GenDelRecordCode4DataGridView();
                strCodeForCs.Append(strTemp);

                //最后一步:生成类的结束符和域名空间的结束符
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            //把生成写到文件中;
            //clsPubFun4BLEx.SaveClassContentToFile(objViewInfoENEx.WebFormFName, strCodeForCs.ToString(), objViewInfoENEx.FolderName_Root, myEncoding);

            ////检查该文件名的文件夹名,并判断是否存在;
            //strFolder = clsString.ParentDir_S(objViewInfoENEx.WebFormFName);
            //if (System.IO.Directory.Exists(strFolder) == false)
            //{
            //    Directory.CreateDirectory(strFolder);
            //}

            //if (clsSysParaEN_Local.IsBackupForGeneCode  == true)
            //{
            //    string strSimpleFileName = clsString.GetSimpleFName_S(objViewInfoENEx.WebFormFName);
            //    string strFindFileFullFile = clsFile.FindFileFromFolder(objViewInfoENEx.FolderName_Root, strSimpleFileName);
            //    while (string.IsNullOrEmpty(strFindFileFullFile) == false)
            //    {
            //        string strMsg = string.Format("文件:{0}已经存在!", strFindFileFullFile);
            //        throw new Exception(strMsg);
            //    }
            //}

            ////UTF8Encoding utf8 = new UTF8Encoding(false);
            //clsFile.1CreateFileByString(objViewInfoENEx.WebFormFName, strCodeForCs.ToString(), myEncoding);
            return strCodeForCs.ToString();

        }

        /// <summary>
        /// 生成查询删除的主界面,在界面可以调用用于编辑的界面
        /// 注:不使用控件(NoCtrl)
        /// </summary>
        /// <returns></returns>
        public string A_GenQueryDelAffitUpdInsRecCodeWithDGV_NoContral_Net2005_Design(clsViewInfoENEx objViewInfoENEx, ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            Point pntLocation = new Point();
            ArrayList arrInnerCtlSet = new ArrayList();     //内部控件集合

            //让用户设置属性;
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;
            clsPubFun4BLEx.CheckDgStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.DgStyleId);
            clsPubFun4BLEx.CheckTitleStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.TitleStyleId);

            clsDataGridStyleEN objDGStyleEx = clsDataGridStyleBL.GetObjByDgStyleIdCache(objViewInfoENEx.objViewStyleEN.DgStyleId);
            clsBiDimDistribute objBiDimDistribute = new clsBiDimDistribute();
            objBiDimDistribute.ColNum = objViewInfoENEx.objViewRegion_Query.ColNum ?? 0;
            objBiDimDistribute.ColWidth = 250;
            objBiDimDistribute.LineHeight = 35;
            int intLblHeight = 18;
            int intLblWidth = 70;
            int intTxtHeight = 20;
            int intTxtWidth = 100;
            float intCtlWidth = objBiDimDistribute.GetCtlWidth();
            float intCtlHeight = objBiDimDistribute.GetCtlHeigh(objViewInfoENEx.objViewRegion_Query.FieldNum());
            ///检查编辑区域
            //CheckEditRegion();
            //检查LIstView区域
            CheckListViewRegion();
            //检查查询区域
            CheckQueryRegion();
            //检查Excel导出区域
            //CheckExcelExportRegion();
            objViewInfoENEx.WebFormName = "frm" + objViewInfoENEx.TabName + "_QD_DGV";
           objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;
            objViewInfoENEx.WebFormFName = "frm" + objViewInfoENEx.TabName + "_QD_DGV.Designer.cs";

            strRe_ClsName = objViewInfoENEx.WebFormName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}",
                objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebFormFName);

            try
            {
                //第0步:把控件中下拉框ComboBox转换成ComboBox
                if (objViewInfoENEx.arrEditRegionFldSet4InUse != null)
                {
                    foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                    {
                        if (objEditRegionFldsEx.objCtlType.CtlTypeName == "DropDownList")
                        {
                            objEditRegionFldsEx.objCtlType.CtlTypeName = "ComboBox";
                            objEditRegionFldsEx.CtrlId4Win = objEditRegionFldsEx.CtrlId4Win.Replace("ddl", "cbo");
                        }
                    }
                }
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.objCtlType.CtlTypeName == "DropDownList")
                    {
                        objQryRegionFldsEx.objCtlType.CtlTypeName = "ComboBox";
                        objQryRegionFldsEx.CtrlId4Win = objQryRegionFldsEx.CtrlId4Win.Replace("ddl", "cbo");
                    }
                }
                //第一步:生成导入域名空间

                strCodeForCs.AppendFormat("\r\n" + "namespace {0}", objViewInfoENEx.NameSpace);
                strCodeForCs.Append("\r\n" + "{");
                //第二步:生成控件类名
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///		frm{0}_QD_DGV 的摘要说明。", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "partial class frm{0}_QD_DGV", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                //第三步:生成控件中内部控件变量的名称

                //第四步:生成必需的设计器变量
                strCodeForCs.Append("\r\n /// <summary> ");
                strCodeForCs.Append("\r\n /// 必需的设计器变量。");
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "private System.ComponentModel.Container components = null;");
                strCodeForCs.Append("\r\n" + "");
                //第五步:清理所有正在使用的资源
                strCodeForCs.Append("\r\n /// <summary> ");
                strCodeForCs.Append("\r\n /// 清理所有正在使用的资源。");
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "protected override void Dispose( bool disposing)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if( disposing)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if(components != null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "components.Dispose();");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "base.Dispose( disposing);");
                strCodeForCs.Append("\r\n" + "}");
                //第六步:组件设计器生成的代码

                strCodeForCs.Append("\r\n" + "#region 组件设计器生成的代码");
                strCodeForCs.Append("\r\n /// <summary> ");
                strCodeForCs.Append("\r\n /// 设计器支持所需的方法 - 不要使用代码编辑器 ");
                strCodeForCs.Append("\r\n /// 修改此方法的内容。");
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "private void InitializeComponent()");
                strCodeForCs.Append("\r\n" + "{");

                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    strCodeForCs.AppendFormat("\r\n" + "this.lbl{0} = new System.Windows.Forms.Label();",
                      objQryRegionFldsEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "this.{0} = new System.Windows.Forms.{1}();",
                      objQryRegionFldsEx.CtrlId4Win, objQryRegionFldsEx.objCtlType.CtlTypeName);
                }

                strCodeForCs.Append("\r\n" + "this.btnQuery = new System.Windows.Forms.Button();");
                strCodeForCs.Append("\r\n" + "this.lblMsg = new System.Windows.Forms.Label();");
                strCodeForCs.Append("\r\n" + "this.btnUpdate = new System.Windows.Forms.Button();");
                strCodeForCs.Append("\r\n" + "this.btnAdd = new System.Windows.Forms.Button();");
                strCodeForCs.Append("\r\n" + "this.btnDelRec = new System.Windows.Forms.Button();");
                strCodeForCs.Append("\r\n" + "this.btnExportExcel4Dg = new System.Windows.Forms.Button();");
                strCodeForCs.Append("\r\n" + "this.lblRecNum = new System.Windows.Forms.Label();");

                strCodeForCs.AppendFormat("\r\n" + "this.dgv{0} = new System.Windows.Forms.DataGridView();",
                  objViewInfoENEx.TabName_Out);

                foreach (clsDGRegionFldsENEx ObjLstViewRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
                {
                    if (ObjLstViewRegionFldsEx.ObjFieldTabENEx.CsType() != "byte[]")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "this.dgvc{0} = new System.Windows.Forms.DataGridViewTextBoxColumn();",
                          ObjLstViewRegionFldsEx.ObjFieldTabENEx.FldName);
                    }
                }
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition = new System.Windows.Forms.GroupBox();");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.SuspendLayout();");

                strCodeForCs.Append("\r\n" + "this.SuspendLayout();");

                int intIndex = 1;
                pntLocation.X = 10;
                pntLocation.Y = 10;
                clsBiDimDistribute objBiDimDistribue = new clsBiDimDistribute();
                objBiDimDistribue.StartX = 10;
                objBiDimDistribue.StartY = 18;
                objBiDimDistribue.ColNum = objViewInfoENEx.objViewRegion_Query.ColNum ?? 0;
                objBiDimDistribue.ColWidth = 250;
                objBiDimDistribue.LineHeight = 30;
                int intFieldIndex = 0;

                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    ///如果该字段不是标识递增型就生成控件,否则就不生成;
                    if (objQryRegionFldsEx.PrimaryTypeId() != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        switch (objQryRegionFldsEx.objCtlType.CtlTypeName)
                        {
                            case "CheckBox":
                                // 
                                // checkBox1
                                // 
                                //定义控件
                                strCodeForCs.Append("\r\n" + "//");
                                strCodeForCs.AppendFormat("\r\n" + "// {0}", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "//");

                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Location = new System.Drawing.Point({1}, {2});",
                                  objQryRegionFldsEx.CtrlId4Win,
                                  objBiDimDistribue.GetPosition(intFieldIndex).X,
                                  objBiDimDistribue.GetPosition(intFieldIndex).Y);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Name = \"{0}\";",
                                  objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Size = new System.Drawing.Size({1}, {2});",
                                  objQryRegionFldsEx.CtrlId4Win, intTxtWidth, intTxtHeight);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.TabIndex = {1};",
                                  objQryRegionFldsEx.CtrlId4Win, intIndex++);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Text = \"{1}\";",
                                  objQryRegionFldsEx.CtrlId4Win,
                                  objQryRegionFldsEx.LabelCaption);
                                //把当前内部控件添加内部控件集合中
                                arrInnerCtlSet.Add("this." + objQryRegionFldsEx.CtrlId4Win);
                                pntLocation.Y += 30;
                                break;
                            case "ComboBox":
                            case "DropDownList":
                                //定义控件相应的Label
                                strCodeForCs.Append("\r\n" + "//");
                                strCodeForCs.AppendFormat("\r\n" + "// lbl{0}", objQryRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "//");

                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Location = new System.Drawing.Point({1}, {2});",
                                  objQryRegionFldsEx.FldName,
                                  objBiDimDistribue.GetPosition(intFieldIndex).X,
                                  objBiDimDistribue.GetPosition(intFieldIndex).Y);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Name = \"lbl{0}\";",
                                  objQryRegionFldsEx.FldName);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Size = new System.Drawing.Size({1}, {2});",
                                  objQryRegionFldsEx.FldName, intLblWidth, intLblHeight);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.TabIndex = {1};",
                                  objQryRegionFldsEx.FldName, intIndex++);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Text = \"{1}\";",
                                  objQryRegionFldsEx.FldName,
                                  objQryRegionFldsEx.LabelCaption);
                                //把当前内部控件添加内部控件集合中
                                arrInnerCtlSet.Add("this.lbl" + objQryRegionFldsEx.FldName);

                                //定义控件
                                strCodeForCs.Append("\r\n" + "//");
                                strCodeForCs.AppendFormat("\r\n" + "// {0}", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "//");

                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;",
                                  objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Location = new System.Drawing.Point({1}, {2});",
                                  objQryRegionFldsEx.CtrlId4Win,
                                  objBiDimDistribue.GetPosition(intFieldIndex).X + 80,
                                  objBiDimDistribue.GetPosition(intFieldIndex).Y);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Name = \"{0}\";",
                                  objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Size = new System.Drawing.Size({1}, {2});",
                                  objQryRegionFldsEx.CtrlId4Win, intTxtWidth, intTxtHeight);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.TabIndex = {1};",
                                  objQryRegionFldsEx.CtrlId4Win, intIndex++);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Text = \"\";",
                                  objQryRegionFldsEx.CtrlId4Win);
                                //把当前内部控件添加内部控件集合中
                                arrInnerCtlSet.Add("this." + objQryRegionFldsEx.CtrlId4Win);
                                pntLocation.Y += 30;
                                break;

                            default:

                                //定义控件相应的Label
                                strCodeForCs.Append("\r\n" + "//");
                                strCodeForCs.AppendFormat("\r\n" + "// lbl{0}", objQryRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "//");

                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Location = new System.Drawing.Point({1}, {2});",
                                  objQryRegionFldsEx.FldName,
                                  objBiDimDistribue.GetPosition(intFieldIndex).X,
                                  objBiDimDistribue.GetPosition(intFieldIndex).Y);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Name = \"lbl{0}\";",
                                  objQryRegionFldsEx.FldName);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Size = new System.Drawing.Size({1}, {2});",
                                  objQryRegionFldsEx.FldName, intLblWidth, intLblHeight);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.TabIndex = {1};",
                                  objQryRegionFldsEx.FldName, intIndex++);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Text = \"{1}\";",
                                  objQryRegionFldsEx.FldName,
                                  objQryRegionFldsEx.LabelCaption);
                                //把当前内部控件添加内部控件集合中
                                arrInnerCtlSet.Add("this.lbl" + objQryRegionFldsEx.FldName);

                                //定义控件
                                strCodeForCs.Append("\r\n" + "//");
                                strCodeForCs.AppendFormat("\r\n" + "// {0}", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "//");

                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Location = new System.Drawing.Point({1}, {2});",
                                  objQryRegionFldsEx.CtrlId4Win,
                                  objBiDimDistribue.GetPosition(intFieldIndex).X + 80,
                                  objBiDimDistribue.GetPosition(intFieldIndex).Y);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Name = \"{0}\";",
                                  objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Size = new System.Drawing.Size({1}, {2});",
                                  objQryRegionFldsEx.CtrlId4Win, intTxtWidth, intTxtHeight);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.TabIndex = {1};",
                                  objQryRegionFldsEx.CtrlId4Win, intIndex++);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Text = \"\";",
                                  objQryRegionFldsEx.CtrlId4Win);
                                //把当前内部控件添加内部控件集合中
                                arrInnerCtlSet.Add("this." + objQryRegionFldsEx.CtrlId4Win);
                                pntLocation.Y += 30;
                                break;
                                //end of switch
                        }
                        //end of if(objQryRegionFldsEx.IsIdentity = false && objQryRegionFldsEx.IsCtlField == true)
                    }
                    //end of foreach(clsEditRegionFldsENEx objQryRegionFldsEx in arrViewCtlFldSet4Query)
                    intFieldIndex++;    //字段序号增1
                }

                // 
                // lblMsg
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// lblMsg");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.lblMsg.Location = new System.Drawing.Point(192, 144);");
                strCodeForCs.Append("\r\n" + "this.lblMsg.Name = \"lblMsg\";");
                strCodeForCs.Append("\r\n" + "this.lblMsg.Size = new System.Drawing.Size(128, 16);");
                strCodeForCs.AppendFormat("\r\n" + "this.lblMsg.TabIndex = {0};",
                  intIndex++);
                // 
                // btnAdd
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// btnAdd");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.btnAdd.Location = new System.Drawing.Point(408, 137);");
                strCodeForCs.Append("\r\n" + "this.btnAdd.Name = \"btnAdd\";");
                strCodeForCs.Append("\r\n" + "this.btnAdd.Size = new System.Drawing.Size(80, 26);");
                strCodeForCs.AppendFormat("\r\n" + "this.btnAdd.TabIndex = {0};",
                  intIndex++);
                strCodeForCs.Append("\r\n" + "this.btnAdd.Text = \"添加\";");
                strCodeForCs.Append("\r\n" + "this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);");
                // 
                // 
                // btnUpdate
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// btnUpdate");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.btnUpdate.Location = new System.Drawing.Point(496, 137);");
                strCodeForCs.Append("\r\n" + "this.btnUpdate.Name = \"btnUpdate\";");
                strCodeForCs.Append("\r\n" + "this.btnUpdate.Size = new System.Drawing.Size(80, 26);");
                strCodeForCs.AppendFormat("\r\n" + "this.btnUpdate.TabIndex = {0};",
                  intIndex++);
                strCodeForCs.Append("\r\n" + "this.btnUpdate.Text = \"修改\";");
                strCodeForCs.Append("\r\n" + "this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);");
                // 
                // btnDelRec
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// btnDelRec");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.btnDelRec.Location = new System.Drawing.Point(576, 137);");
                strCodeForCs.Append("\r\n" + "this.btnDelRec.Name = \"btnDelRec\";");
                strCodeForCs.Append("\r\n" + "this.btnDelRec.Size = new System.Drawing.Size(80, 26);");
                strCodeForCs.AppendFormat("\r\n" + "this.btnDelRec.TabIndex = {0};",
                  intIndex++);
                strCodeForCs.Append("\r\n" + "this.btnDelRec.Text = \"删除记录\";");
                strCodeForCs.Append("\r\n" + "this.btnDelRec.Click += new System.EventHandler(this.btnDelRec_Click);");
                // 
                // btnExportExcel4Dg
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// btnExportExcel4Dg");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.btnExportExcel4Dg.Location = new System.Drawing.Point(664, 137);");
                strCodeForCs.Append("\r\n" + "this.btnExportExcel4Dg.Name = \"btnExportExcel4Dg\";");
                strCodeForCs.Append("\r\n" + "this.btnExportExcel4Dg.Size = new System.Drawing.Size(80, 26);");
                strCodeForCs.AppendFormat("\r\n" + "this.btnExportExcel4Dg.TabIndex = {0};",
                  intIndex++);
                strCodeForCs.Append("\r\n" + "this.btnExportExcel4Dg.Text = \"导出Excel\";");
                strCodeForCs.Append("\r\n" + "this.btnExportExcel4Dg.Click += new System.EventHandler(this.btnExportExcel4Dg_Click);");
                //
                //查询按钮<btnQuery>
                //
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// btnQuery");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.btnQuery.Location = new System.Drawing.Point(328, 137);");
                strCodeForCs.Append("\r\n" + "this.btnQuery.Name = \"btnQuery\";");
                strCodeForCs.Append("\r\n" + "this.btnQuery.Size = new System.Drawing.Size(80, 26);");
                strCodeForCs.AppendFormat("\r\n" + "this.btnQuery.TabIndex = {0};",
                  intIndex++);
                strCodeForCs.Append("\r\n" + "this.btnQuery.Text = \"查询\";");
                strCodeForCs.Append("\r\n" + "this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);");
                // 
                // lblRecNum
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// lblRecNum");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.lblRecNum.Location = new System.Drawing.Point(752, 144);");
                strCodeForCs.Append("\r\n" + "this.lblRecNum.Name = \"lblRecNum\";");
                strCodeForCs.Append("\r\n" + "this.lblRecNum.Size = new System.Drawing.Size(112, 16);");
                strCodeForCs.AppendFormat("\r\n" + "this.lblRecNum.TabIndex = {0} ;",
                  intIndex++);
                strCodeForCs.Append("\r\n" + "this.lblRecNum.Text = \"记录数:\";");


                // 
                // dgv{0}
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.AppendFormat("\r\n" + "// dgv{0}",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.AppendFormat("\r\n" + "this.dgv{0}.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "this.dgv{0}.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] ",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                for (int i = 0; i < objViewInfoENEx.arrDGRegionFldSet.Count; i++)
                {
                    clsDGRegionFldsENEx ObjLstViewRegionFldsEx = objViewInfoENEx.arrDGRegionFldSet[i] as clsDGRegionFldsENEx;
                    if (ObjLstViewRegionFldsEx.ObjFieldTabENEx.CsType() != "byte[]")
                    {
                        if (i + 1 == objViewInfoENEx.arrDGRegionFldSet.Count)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "this.dgvc{0}",
                             ObjLstViewRegionFldsEx.ObjFieldTabENEx.FldName);
                            strCodeForCs.Append("\r\n" + "});");
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "this.dgvc{0},",
                              ObjLstViewRegionFldsEx.ObjFieldTabENEx.FldName);
                        }
                    }
                }


                strCodeForCs.AppendFormat("\r\n" + "this.dgv{0}.Dock = System.Windows.Forms.DockStyle.Fill;",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "this.dgv{0}.Location = new System.Drawing.Point(0, 176);",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "this.dgv{0}.Name = \"dgv{0}\";",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "this.dgv{0}.Size = new System.Drawing.Size(1000, 524);",
                  objViewInfoENEx.TabName_Out);
                //strCodeForCs.AppendFormat("\r\n" + "this.dgv{0}.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.dgv{0}_ColumnClick);",
                //  objViewInfoENEx.TabName_Out);

                strCodeForCs.AppendFormat("\r\n" + "this.dgv{0}.TabIndex = {1};",
                  objViewInfoENEx.TabName_Out,
                  intIndex++);
                //strCodeForCs.AppendFormat("\r\n" + "this.dgv{0}.View = System.Windows.Forms.View.Details;",
                //  objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "this.dgv{0}.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv{0}_CellClick);",
                  objViewInfoENEx.TabName_Out);

                strCodeForCs.AppendFormat("\r\n" + "this.dgv{0}.Click += new System.EventHandler(this.dgv{0}_Click);",
                  objViewInfoENEx.TabName_Out);

                foreach (clsDGRegionFldsENEx ObjLstViewRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
                {
                    if (ObjLstViewRegionFldsEx.ObjFieldTabENEx.CsType() != "byte[]")
                    {

                        strCodeForCs.Append("\r\n" + "// ");
                        strCodeForCs.AppendFormat("\r\n" + "// dgvc{0}",
                          ObjLstViewRegionFldsEx.ObjFieldTabENEx.FldName);
                        strCodeForCs.Append("\r\n" + "// ");
                        strCodeForCs.AppendFormat("\r\n" + "this.dgvc{0}.DataPropertyName = \"{0}\";",
                          ObjLstViewRegionFldsEx.ObjFieldTabENEx.FldName);
                        strCodeForCs.AppendFormat("\r\n" + "this.dgvc{0}.HeaderText = \"{1}\";",
                          ObjLstViewRegionFldsEx.ObjFieldTabENEx.FldName,
                          ObjLstViewRegionFldsEx.HeaderText);
                        strCodeForCs.AppendFormat("\r\n" + "this.dgvc{0}.Name = \"dgvc{0}\";",
                          ObjLstViewRegionFldsEx.ObjFieldTabENEx.FldName);
                        strCodeForCs.AppendFormat("\r\n" + "this.dgvc{0}.Visible = true;",
                          ObjLstViewRegionFldsEx.ObjFieldTabENEx.FldName);
                    }
                }
                // 
                // gbQueryCondition
                // 
                //向控件的内部控件集合中添加内部控件
                foreach (string strCtlName in arrInnerCtlSet)
                {
                    strCodeForCs.AppendFormat("\r\n" + "this.gbQueryCondition.Controls.Add({0});",
                      strCtlName);
                }
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Controls.Add(this.btnExportExcel4Dg);");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Controls.Add(this.btnQuery);");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Controls.Add(this.btnUpdate);");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Controls.Add(this.btnAdd);");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Controls.Add(this.btnDelRec);");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Controls.Add(this.lblMsg);");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Controls.Add(this.lblRecNum);");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Dock = System.Windows.Forms.DockStyle.Top;");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Font = new System.Drawing.Font(\"宋体\", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Location = new System.Drawing.Point(0, 0);");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Name = \"gbQueryCondition\";");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Size = new System.Drawing.Size(720, 176);");
                strCodeForCs.AppendFormat("\r\n" + "this.gbQueryCondition.TabIndex = {0};",
                  intIndex++);
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.TabStop = false;");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Text = \"查询条件\";");

                //向控件的内部控件集合中添加内部控件
                // 
                // frm{0}_QD_LV
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.AppendFormat("\r\n" + "// frm{0}_QD_LV",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "// ");
                //				strCodeForCs.Append("\r\n" + "this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);");
                strCodeForCs.Append("\r\n" + "this.ClientSize = new System.Drawing.Size(1000, 700);");
                strCodeForCs.AppendFormat("\r\n" + "this.Controls.Add(this.dgv{0});",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "this.Controls.Add(this.gbQueryCondition);");
                strCodeForCs.Append("\r\n" + "this.Font = new System.Drawing.Font(\"宋体\", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));");

                strCodeForCs.AppendFormat("\r\n" + "this.Name = \"frm{0}_QD_LV\";",
                  objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "this.Text = \"frm{0}_QD_LV\";",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;");

                strCodeForCs.AppendFormat("\r\n" + "this.Load += new System.EventHandler(this.frm{0}_QD_Load);",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "this.ResumeLayout(false);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "#endregion");

                //第三步:生成控件中内部控件变量的名称

                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.Label {0};", "lbl" + objQryRegionFldsEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.{1} {0};", objQryRegionFldsEx.CtrlId4Win, objQryRegionFldsEx.objCtlType.CtlTypeName);
                }


                strCodeForCs.Append("\r\n" + "private System.Windows.Forms.Button btnQuery;");
                strCodeForCs.Append("\r\n" + "private System.Windows.Forms.Label lblMsg; ");
                strCodeForCs.Append("\r\n" + "private System.Windows.Forms.Button btnUpdate;");
                strCodeForCs.Append("\r\n" + "private System.Windows.Forms.Button btnAdd;");
                strCodeForCs.Append("\r\n" + "private System.Windows.Forms.Button btnDelRec;");
                strCodeForCs.Append("\r\n" + "private System.Windows.Forms.Button btnExportExcel4Dg;");
                strCodeForCs.Append("\r\n" + "private System.Windows.Forms.Label lblRecNum;");
                strCodeForCs.Append("\r\n" + "private System.Windows.Forms.GroupBox gbQueryCondition;");

                strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.DataGridView dgv{0};",
                  objViewInfoENEx.TabName_Out);

                foreach (clsDGRegionFldsENEx ObjLstViewRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
                {
                    if (ObjLstViewRegionFldsEx.ObjFieldTabENEx.CsType() != "byte[]")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.DataGridViewTextBoxColumn dgvc{0};",
                          ObjLstViewRegionFldsEx.ObjFieldTabENEx.FldName);
                    }
                }
                //第七步:生成objViewInfoENEx.load代码

                //最后一步:生成类的结束符和域名空间的结束符
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            //把生成写到文件中;
            //clsPubFun4BLEx.SaveClassContentToFile(objViewInfoENEx.WebFormFName, strCodeForCs.ToString(), objViewInfoENEx.FolderName_Root, myEncoding);

            ////检查该文件名的文件夹名,并判断是否存在;
            //strFolder = clsString.ParentDir_S(objViewInfoENEx.WebFormFName);
            //if (System.IO.Directory.Exists(strFolder) == false)
            //{
            //    Directory.CreateDirectory(strFolder);
            //}

            //if (clsSysParaEN_Local.IsBackupForGeneCode  == true)
            //{
            //    string strSimpleFileName = clsString.GetSimpleFName_S(objViewInfoENEx.WebFormFName);
            //    string strFindFileFullFile = clsFile.FindFileFromFolder(objViewInfoENEx.FolderName_Root, strSimpleFileName);
            //    while (string.IsNullOrEmpty(strFindFileFullFile) == false)
            //    {
            //        string strMsg = string.Format("文件:{0}已经存在!", strFindFileFullFile);
            //        throw new Exception(strMsg);
            //    }
            //}
            ////UTF8Encoding utf8 = new UTF8Encoding(false);
            //clsFile.1CreateFileByString(objViewInfoENEx.WebFormFName, strCodeForCs.ToString(), myEncoding);
            return strCodeForCs.ToString();

        }



        /// <summary>
        /// 生成用于编辑某个表的界面,包括:修改、添加,该界面主要用于被其他界面来调用
        /// 注:不使用控件(NoContral)
        /// </summary>
        /// <returns></returns>
        //public string A_GenUpdInsRecCode_NoContral(clsViewInfoENEx objViewInfoENEx, ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        //{
        //    Point pntLocation = new Point();
        //    string strTemp;
        //    ArrayList arrInnerCtlSet = new ArrayList();     //内部控件集合

        //    //让用户设置属性;
        //    StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
        //    //			string strTemp ;     ///临时变量;
        //    clsPubFun4BLEx.CheckDgStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.DgStyleId);
        //    clsPubFun4BLEx.CheckTitleStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.TitleStyleId);

        //    clsDataGridStyleEN objDGStyleEx = clsDataGridStyleBL.GetObjByDgStyleIdCache(objViewInfoENEx.objViewStyleEN.DgStyleId);
        //    clsBiDimDistribute objBiDimDistribute = new clsBiDimDistribute();
        //    objBiDimDistribute.ColNum = objViewInfoENEx.objViewRegion_Edit.ColNum;
        //    objBiDimDistribute.ColWidth = 250;
        //    objBiDimDistribute.LineHeight = 35;
        //    int intLblHeight = 18;
        //    int intLblWidth = 70;
        //    int intTxtHeight = 20;
        //    int intTxtWidth = 100;

        //    float intCtlWidth = objBiDimDistribute.GetCtlWidth();
        //    float intCtlHeight = objBiDimDistribute.GetCtlHeigh(objViewInfoENEx.objViewRegion_Edit.FieldNum());

        //    //检查编辑区域
        //    CheckEditRegion();

        //    objViewInfoENEx.WebFormName = "frm" + objViewInfoENEx.TabName + "_UI";
        //    objViewInfoENEx.WebFormFName = objViewInfoENEx.FolderName + "frm" + objViewInfoENEx.TabName + "_UI.cs";
        //    objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;

        //    objViewInfoENEx.WebFormCsFName = "frm" + objViewInfoENEx.TabName + "_UI.cs";
        //    strRe_ClsName = objViewInfoENEx.WebFormName;
        //    clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
        //    strRe_FileNameWithModuleName = string.Format("{0}\\{1}",
        //        objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebFormCsFName);

        //    try
        //    {

        //        //第0步:把控件中下拉框ComboBox转换成ComboBox
        //        foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
        //        {
        //            if (objEditRegionFldsEx.objCtlType.CtlTypeName == "DropDownList")
        //            {
        //                objEditRegionFldsEx.objCtlType.CtlTypeName = "ComboBox";
        //                objEditRegionFldsEx.CtrlId4Win = objEditRegionFldsEx.CtrlId4Win.Replace("ddl", "cbo");
        //            }
        //        }

        //        //第一步:生成导入域名空间
        //      

        //        //类名开始
        //        ///
        //        strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objViewInfoENEx.CurrUserName, objViewInfoENEx));

        //        strCodeForCs.Append("\r\n" + "//生成与表相关的控件控制层代码");
        //        strCodeForCs.Append("\r\n" + "using System;");
        //        strCodeForCs.Append("\r\n" + "using System.Collections;");
        //        strCodeForCs.Append("\r\n" + "using System.Collections.Generic;");
        //        strCodeForCs.Append("\r\n" + "using System.ComponentModel;");
        //        strCodeForCs.Append("\r\n" + "using System.Data;");
        //        strCodeForCs.Append("\r\n" + "using System.Drawing;");
        //        strCodeForCs.Append("\r\n" + "using System.IO;");
        //        strCodeForCs.Append("\r\n" + "using System.Windows.Forms;");
        //        strCodeForCs.Append("\r\n" + "");
        //        strCodeForCs.Append("\r\n" + "using com.taishsoft.common;");
        //        strCodeForCs.Append("\r\n" + "using com.taishsoft.datetime;");

        //        clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objViewInfoENEx.PrjId); //
        //        strCodeForCs.AppendFormat("\r\n" + "using {0}.Entity;", objProject.PrjDomain);
        //        strCodeForCs.AppendFormat("\r\n" + "using {0}.BusinessLogic;", objProject.PrjDomain);

        //        strCodeForCs.Append("\r\n" + "using com.taishsoft.util;");
        //        strCodeForCs.Append("\r\n" + "using CommFunc4Win;");


        //        strCodeForCs.Append("\r\n" + "");

        //        strCodeForCs.AppendFormat("\r\n" + "namespace {0}", objViewInfoENEx.NameSpace);
        //        strCodeForCs.Append("\r\n" + "{");
        //        //第二步:生成控件类名
        //        strCodeForCs.Append("\r\n /// <summary>");
        //        strCodeForCs.AppendFormat("\r\n ///		frm{0}_UI 的摘要说明。", objViewInfoENEx.TabName);
        //        strCodeForCs.Append("\r\n /// </summary>");
        //        strCodeForCs.AppendFormat("\r\n" + "public class frm{0}_UI : System.Windows.Forms.Form", objViewInfoENEx.TabName);
        //        strCodeForCs.Append("\r\n" + "{");
        //        //第三步:生成控件中内部控件变量的名称

        //        foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
        //        {
        //            strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.Label {0};", "lbl" + objEditRegionFldsEx.FldName);
        //            strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.{1} {0};", objEditRegionFldsEx.CtrlId4Win, objEditRegionFldsEx.objCtlType.CtlTypeName);
        //        }
        //        strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.Label lblMsg; ");
        //        strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.Button btnOKUpd;");
        //        strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;",
        //          objViewInfoENEx.TabName);
        //        strCodeForCs.Append("\r\n" + "private System.Windows.Forms.Button btnClose;");
        //        strCodeForCs.AppendFormat("\r\n" + "private string {0};		//用于传递关键字值的变量",
        //          objKeyField.ObjFieldTabENEx.PrivPropName);
        //        strCodeForCs.Append("\r\n" + "public string OperateType;");
        //        strCodeForCs.Append("\r\n" + "public IBindListView iBindListView = null;");


        //        //第四步:生成必需的设计器变量
        //        strCodeForCs.Append("\r\n /// <summary> ");
        //        strCodeForCs.Append("\r\n /// 必需的设计器变量。");
        //        strCodeForCs.Append("\r\n /// </summary>");
        //        strCodeForCs.Append("\r\n" + "private System.ComponentModel.Container components = null;");
        //        strCodeForCs.Append("\r\n" + "");
        //        strCodeForCs.AppendFormat("\r\n" + "public frm{0}_UI()",
        //          objViewInfoENEx.TabName);
        //        strCodeForCs.Append("\r\n" + "{");
        //        strCodeForCs.Append("\r\n" + "// 该调用是 Windows.Forms 窗体设计器所必需的。");
        //        strCodeForCs.Append("\r\n" + "InitializeComponent();");
        //        strCodeForCs.Append("\r\n" + "");
        //        strCodeForCs.Append("\r\n" + "// TODO: 在 InitializeComponent 调用后添加任何初始化");
        //        strCodeForCs.Append("\r\n" + "");
        //        strCodeForCs.Append("\r\n" + "}");
        //        //第五步:清理所有正在使用的资源
        //        strCodeForCs.Append("\r\n /// <summary> ");
        //        strCodeForCs.Append("\r\n /// 清理所有正在使用的资源。");
        //        strCodeForCs.Append("\r\n /// </summary>");
        //        strCodeForCs.Append("\r\n" + "protected override void Dispose( bool disposing)");
        //        strCodeForCs.Append("\r\n" + "{");
        //        strCodeForCs.Append("\r\n" + "if( disposing)");
        //        strCodeForCs.Append("\r\n" + "{");
        //        strCodeForCs.Append("\r\n" + "if(components != null)");
        //        strCodeForCs.Append("\r\n" + "{");
        //        strCodeForCs.Append("\r\n" + "components.Dispose();");
        //        strCodeForCs.Append("\r\n" + "}");
        //        strCodeForCs.Append("\r\n" + "}");
        //        strCodeForCs.Append("\r\n" + "base.Dispose( disposing);");
        //        strCodeForCs.Append("\r\n" + "}");
        //        //第六步:组件设计器生成的代码

        //        strCodeForCs.Append("\r\n" + "#region 组件设计器生成的代码");
        //        strCodeForCs.Append("\r\n /// <summary> ");
        //        strCodeForCs.Append("\r\n /// 设计器支持所需的方法 - 不要使用代码编辑器 ");
        //        strCodeForCs.Append("\r\n /// 修改此方法的内容。");
        //        strCodeForCs.Append("\r\n /// </summary>");
        //        strCodeForCs.Append("\r\n" + "private void InitializeComponent()");
        //        strCodeForCs.Append("\r\n" + "{");
        //        foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
        //        {
        //            strCodeForCs.AppendFormat("\r\n" + "this.lbl{0} = new System.Windows.Forms.Label();",
        //              objEditRegionFldsEx.FldName);
        //            strCodeForCs.AppendFormat("\r\n" + "this.{0} = new System.Windows.Forms.{1}();",
        //              objEditRegionFldsEx.CtrlId4Win, objEditRegionFldsEx.objCtlType.CtlTypeName);
        //        }

        //        strCodeForCs.Append("\r\n" + "this.lblMsg = new System.Windows.Forms.Label();");
        //        strCodeForCs.Append("\r\n" + "this.btnOKUpd = new System.Windows.Forms.Button();");
        //        strCodeForCs.Append("\r\n" + "this.btnClose = new System.Windows.Forms.Button();");
        //        strCodeForCs.Append("\r\n" + "this.SuspendLayout();");

        //        int intIndex = 1;
        //        pntLocation.X = 10;
        //        pntLocation.Y = 10;
        //        clsBiDimDistribute objBiDimDistribue = new clsBiDimDistribute();
        //        objBiDimDistribue.StartX = 10;
        //        objBiDimDistribue.StartY = 10;
        //        objBiDimDistribue.ColNum = objViewInfoENEx.objViewRegion_Edit.ColNum;
        //        objBiDimDistribue.ColWidth = 250;
        //        objBiDimDistribue.LineHeight = 30;
        //        int intFieldIndex = 0;
        //        foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
        //        {
        //            ///如果该字段不是标识递增型就生成控件,否则就不生成;
        //            if (objEditRegionFldsEx.objPrjTabFldENEx.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
        //            {
        //                switch (objEditRegionFldsEx.objCtlType.CtlTypeName)
        //                {
        //                    case "CheckBox":
        //                        // 
        //                        // checkBox1
        //                        // 
        //                        //定义控件
        //                        strCodeForCs.Append("\r\n" + "//");
        //                        strCodeForCs.AppendFormat("\r\n" + "// {0}", objEditRegionFldsEx.CtrlId4Win);
        //                        strCodeForCs.Append("\r\n" + "//");

        //                        strCodeForCs.AppendFormat("\r\n" + "this.{0}.Location = new System.Drawing.Point({1}, {2});",
        //                          objEditRegionFldsEx.CtrlId4Win,
        //                          objBiDimDistribue.GetPosition(intFieldIndex).X,
        //                          objBiDimDistribue.GetPosition(intFieldIndex).Y);
        //                        strCodeForCs.AppendFormat("\r\n" + "this.{0}.Name = \"{0}\";",
        //                          objEditRegionFldsEx.CtrlId4Win);
        //                        strCodeForCs.AppendFormat("\r\n" + "this.{0}.Size = new System.Drawing.Size({1}, {2});",
        //                          objEditRegionFldsEx.CtrlId4Win, intTxtWidth, intTxtHeight);
        //                        strCodeForCs.AppendFormat("\r\n" + "this.{0}.TabIndex = {1};",
        //                          objEditRegionFldsEx.CtrlId4Win, intIndex++);
        //                        strCodeForCs.AppendFormat("\r\n" + "this.{0}.Text = \"{1}\";",
        //                          objEditRegionFldsEx.CtrlId4Win, objEditRegionFldsEx.LabelCaption);
        //                        //把当前内部控件添加内部控件集合中
        //                        arrInnerCtlSet.Add("this." + objEditRegionFldsEx.CtrlId4Win);
        //                        pntLocation.Y += 30;
        //                        break;
        //                    default:

        //                        //定义控件相应的Label
        //                        strCodeForCs.Append("\r\n" + "//");
        //                        strCodeForCs.AppendFormat("\r\n" + "// lbl{0}", objEditRegionFldsEx.FldName);
        //                        strCodeForCs.Append("\r\n" + "//");

        //                        strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Location = new System.Drawing.Point({1}, {2});",
        //                          objEditRegionFldsEx.FldName,
        //                          objBiDimDistribue.GetPosition(intFieldIndex).X,
        //                          objBiDimDistribue.GetPosition(intFieldIndex).Y);
        //                        strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Name = \"lbl{0}\";",
        //                          objEditRegionFldsEx.FldName);
        //                        strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Size = new System.Drawing.Size({1}, {2});",
        //                          objEditRegionFldsEx.FldName, intLblWidth, intLblHeight);
        //                        strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.TabIndex = {1};",
        //                          objEditRegionFldsEx.FldName, intIndex++);
        //                        strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Text = \"{1}\";",
        //                          objEditRegionFldsEx.FldName,
        //                          objEditRegionFldsEx.LabelCaption);
        //                        //把当前内部控件添加内部控件集合中
        //                        arrInnerCtlSet.Add("this.lbl" + objEditRegionFldsEx.FldName);

        //                        //定义控件
        //                        strCodeForCs.Append("\r\n" + "//");
        //                        strCodeForCs.AppendFormat("\r\n" + "// {0}", objEditRegionFldsEx.CtrlId4Win);
        //                        strCodeForCs.Append("\r\n" + "//");

        //                        strCodeForCs.AppendFormat("\r\n" + "this.{0}.Location = new System.Drawing.Point({1}, {2});",
        //                          objEditRegionFldsEx.CtrlId4Win,
        //                          objBiDimDistribue.GetPosition(intFieldIndex).X + 80,
        //                          objBiDimDistribue.GetPosition(intFieldIndex).Y);
        //                        strCodeForCs.AppendFormat("\r\n" + "this.{0}.Name = \"{0}\";",
        //                          objEditRegionFldsEx.CtrlId4Win);
        //                        strCodeForCs.AppendFormat("\r\n" + "this.{0}.Size = new System.Drawing.Size({1}, {2});",
        //                          objEditRegionFldsEx.CtrlId4Win, intTxtWidth, intTxtHeight);
        //                        strCodeForCs.AppendFormat("\r\n" + "this.{0}.TabIndex = {1};",
        //                          objEditRegionFldsEx.CtrlId4Win, intIndex++);
        //                        strCodeForCs.AppendFormat("\r\n" + "this.{0}.Text = \"\";",
        //                          objEditRegionFldsEx.CtrlId4Win);
        //                        //把当前内部控件添加内部控件集合中
        //                        arrInnerCtlSet.Add("this." + objEditRegionFldsEx.CtrlId4Win);
        //                        pntLocation.Y += 30;
        //                        break;
        //                        //end of switch
        //                }
        //                //end of if(objEditRegionFldsEx.IsIdentity = false && objEditRegionFldsEx.IsCtlField == true)
        //            }
        //            //end of foreach(clsEditRegionFldsENEx objEditRegionFldsEx in arrViewCtlFldSet)
        //            intFieldIndex++;
        //        }



        //        // 
        //        // btnOKUpd
        //        // 
        //        strCodeForCs.Append("\r\n" + "// ");
        //        strCodeForCs.Append("\r\n" + "// btnOKUpd");
        //        strCodeForCs.Append("\r\n" + "// ");
        //        strCodeForCs.Append("\r\n" + "this.btnOKUpd.Font = new System.Drawing.Font(\"宋体\", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));");
        //        strCodeForCs.AppendFormat("\r\n" + "this.btnOKUpd.Location = new System.Drawing.Point({0}, {1});",
        //          intCtlWidth / 4,
        //          intCtlHeight + 30);
        //        strCodeForCs.Append("\r\n" + "this.btnOKUpd.Name = \"btnOKUpd\";");
        //        strCodeForCs.Append("\r\n" + "this.btnOKUpd.Size = new System.Drawing.Size(80, 30);");
        //        strCodeForCs.AppendFormat("\r\n" + "this.btnOKUpd.TabIndex = {0};",
        //          intIndex++);
        //        strCodeForCs.Append("\r\n" + "this.btnOKUpd.Text = \"添加\";");
        //        strCodeForCs.Append("\r\n" + "this.btnOKUpd.Click += new System.EventHandler(this.btnOKUpd_Click);");

        //        // 
        //        // btnClose
        //        // 
        //        strCodeForCs.Append("\r\n" + "// ");
        //        strCodeForCs.Append("\r\n" + "// btnClose");
        //        strCodeForCs.Append("\r\n" + "// ");
        //        strCodeForCs.Append("\r\n" + "this.btnClose.Font = new System.Drawing.Font(\"宋体\", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));");
        //        strCodeForCs.AppendFormat("\r\n" + "this.btnClose.Location = new System.Drawing.Point({0}, {1});",
        //          intCtlWidth / 4 + 120,
        //          intCtlHeight + 30);
        //        strCodeForCs.Append("\r\n" + "this.btnClose.Name = \"btnClose\";");
        //        strCodeForCs.Append("\r\n" + "this.btnClose.Size = new System.Drawing.Size(80, 30);");
        //        strCodeForCs.AppendFormat("\r\n" + "this.btnClose.TabIndex = {0};",
        //          intIndex++);
        //        strCodeForCs.Append("\r\n" + "this.btnClose.Text = \"关闭\";");
        //        strCodeForCs.Append("\r\n" + "this.btnClose.Click += new System.EventHandler(this.btnClose_Click);");
        //        // 
        //        // lblMsg
        //        // 
        //        strCodeForCs.Append("\r\n" + "// ");
        //        strCodeForCs.Append("\r\n" + "// lblMsg");
        //        strCodeForCs.Append("\r\n" + "// ");
        //        strCodeForCs.AppendFormat("\r\n" + "this.lblMsg.Location = new System.Drawing.Point({0}, {1});",
        //          intCtlWidth / 4,
        //          intCtlHeight + 60);
        //        strCodeForCs.Append("\r\n" + "this.lblMsg.Name = \"lblMsg\";");
        //        strCodeForCs.Append("\r\n" + "this.lblMsg.Size = new System.Drawing.Size(128, 16);");
        //        strCodeForCs.AppendFormat("\r\n" + "this.lblMsg.TabIndex = {0};",
        //          intIndex++);

        //        //向控件的内部控件集合中添加内部控件
        //        strCodeForCs.Append("\r\n" + "// ");
        //        strCodeForCs.AppendFormat("\r\n" + "// frm{0}_UI",
        //          objViewInfoENEx.TabName);
        //        strCodeForCs.Append("\r\n" + "// ");
        //        strCodeForCs.Append("\r\n" + "this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);");
        //        strCodeForCs.AppendFormat("\r\n" + "this.ClientSize = new System.Drawing.Size({0}, {1});",
        //          intCtlWidth + 30,
        //          intCtlHeight + 100);
        //        //向控件的内部控件集合中添加内部控件
        //        foreach (string strCtlName in arrInnerCtlSet)
        //        {
        //            strCodeForCs.AppendFormat("\r\n" + "this.Controls.Add({0});",
        //              strCtlName);
        //        }


        //        strCodeForCs.Append("\r\n" + "this.Controls.Add(this.btnClose);");
        //        strCodeForCs.Append("\r\n" + "this.Controls.Add(this.btnOKUpd);");
        //        strCodeForCs.Append("\r\n" + "this.Controls.Add(this.lblMsg);");
        //        strCodeForCs.AppendFormat("\r\n" + "this.Name = \"frm{0}_UI\";",
        //          objViewInfoENEx.TabName);
        //        strCodeForCs.Append("\r\n" + "this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;");
        //        strCodeForCs.Append("\r\n" + "this.Font = new System.Drawing.Font(\"宋体\", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));");

        //        strCodeForCs.AppendFormat("\r\n" + "this.Text = \"frm{0}_UI\";",
        //          objViewInfoENEx.TabName);
        //        strCodeForCs.AppendFormat("\r\n" + "this.Load += new System.EventHandler(this.frm{0}_UI_Load);",
        //          objViewInfoENEx.TabName);
        //        strCodeForCs.Append("\r\n" + "this.ResumeLayout(false);");
        //        strCodeForCs.Append("\r\n" + "}");
        //        strCodeForCs.Append("\r\n" + "#endregion");

        //        //第七步:生成objViewInfoENEx.load代码

        //        strCodeForCs.AppendFormat("\r\n" + "private void frm{0}_UI_Load(object sender, System.EventArgs e)",
        //          objViewInfoENEx.TabName);
        //        strCodeForCs.Append("\r\n" + "{");
        //        strCodeForCs.Append("\r\n" + "// 在此处放置用户代码以初始化页面");

        //        strCodeForCs.Append("\r\n" + "//1、为下拉框设置数据源,绑定列表数据");
        //        //1、为下拉框设置数据源,绑定列表数据
        //        strCodeForCs.Append("\r\n" + "this.SetAllComboBox();");

        //        strCodeForCs.Append("\r\n" + "if (OperateType == \"Update\")");
        //        strCodeForCs.Append("\r\n" + "{");
        //        strCodeForCs.AppendFormat("\r\n" + "ShowData({0});",
        //          objKeyField.ObjFieldTabENEx.PrivPropName);
        //        strCodeForCs.Append("\r\n" + "btnOKUpd.Text = \"确认修改\";");
        //        strCodeForCs.Append("\r\n" + "}");
        //        strCodeForCs.Append("\r\n" + "else");
        //        strCodeForCs.Append("\r\n" + "{");
        //        strCodeForCs.Append("\r\n" + "btnOKUpd.Text = \"确认添加\";");
        //        strCodeForCs.Append("\r\n" + "}");


        //        strCodeForCs.Append("\r\n" + "");
        //        strCodeForCs.Append("\r\n" + "}");
        //        //生成下拉框的绑定函数
        //        strTemp = Genfun_SetAllComboBox4Edit();
        //        strCodeForCs.Append(strTemp);

        //        //生成属性变量:
        //        //第八步:生成控件属性,一般为每个内部控件都相应配置一个属性

        //        strTemp = Genfun_ViewCtrlProperty4Edit();
        //        strCodeForCs.Append(strTemp);

        //        //第九步:生成设置控件中关键字只读特性。SetKeyReadOnly
        //        clsEditRegionFldsENEx objEditRegionKeyFld = getEditRegionKeyFld();
        //        if (objEditRegionKeyFld != null)    //如果编辑区存在主关键字
        //        {
        //            if (getEditRegionKeyFld().objPrjTabFldENEx.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
        //            {
        //                strCodeForCs.Append("\r\n" + "/// <summary>");
        //                strCodeForCs.Append("\r\n" + "/// 在用户自定义控件中,设置关键字的值,是否只读");
        //                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
        //                strCodeForCs.Append("\r\n" + "/// </summary>");
        //                strCodeForCs.Append("\r\n" + "/// <param name = \"bolReadonly\">是否只读</param>");
        //                strCodeForCs.Append("\r\n" + "public void SetKeyReadOnly(bool bolReadonly)");
        //                strCodeForCs.Append("\r\n" + "{");
        //                strCodeForCs.AppendFormat("\r\n" + "{0}.ReadOnly = bolReadonly;", getEditRegionKeyFld().CtrlId4Win);
        //                strCodeForCs.Append("\r\n" + "}");
        //            }
        //        }
        //        //第十步:生成Clear()函数。用来初始化控件中内部控件的值。

        //        strTemp = Genfun_Clear();
        //        strCodeForCs.Append(strTemp);

        //        //第十一步:生成设置缺省值的函数。设置该控件在插入状态下的缺省值;
        //        ///设置该控件在插入状态下的缺省值;
        //        strTemp = Genfun_SetDefaultValue();
        //        strCodeForCs.Append(strTemp);

        //        //第十二步:生成校验函数(IsValid())。校验自定义控件中自子控件的类型数值是否是合法正确的;
        //        strTemp = Genfun_IsValid();
        //        strCodeForCs.Append(strTemp);

        //        //第十三步:生成获取当前日期的字符串(getTodayStr) 获取当前日期的字符串以及获取当前月的字符串;
        //        //strTemp = clsPubFun4GC.GenGetCurrMonth();
        //        //strCodeForCs.Append(strTemp);
        //        //strTemp = clsPubFun4GC.GenGetTodayStr();
        //        //strCodeForCs.Append(strTemp);

        //        //第十四步:生成控件中下拉框的BIND函数,即添加下拉框列表项的函数;
        //        //strTemp = GenComboBoxBindFunction();
        //        //strCodeForCs.Append(strTemp);


        //        //第十五步:生成一些判断数据类型的的公共函数

        //        //				strTemp = clsPubFun4GC.GenIsDate();
        //        //				strCodeForCs.Append(strTemp);
        //        //strTemp = clsPubFun4GC.1GenIsDigit();
        //        //strCodeForCs.Append(strTemp);
        //        //strTemp = clsPubFun4GC.GenIsFloat();
        //        //strCodeForCs.Append(strTemp);
        //        //strTemp = clsPubFun4GC.GenIsNumeric();
        //        //strCodeForCs.Append(strTemp);



        //        //第十二步:生成显示数据函数(ShowData)校验函数。
        //        if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate || objViewInfoENEx.objViewTypeCodeTab.IsHaveDetail)
        //        {
        //            strCodeForCs.Append("\r\n" + GenShowDataCode_Win());
        //        }

        //        //第十三步:生成把类对象的属性内容显示到界面上;
        //        strTemp = GenGetDataFromClass();
        //        strCodeForCs.Append(strTemp);

        //        //第十四步://生成确定修改的事件函数
        //        strTemp = GenbtnOKUpd_Click();
        //        strCodeForCs.Append(strTemp);

        //        //第十五步:生成把界面上的属性数据传到类对象中的代码
        //        strTemp = GenPutDataToClass();
        //        strCodeForCs.Append(strTemp);
        //        //第十六步:生成关闭窗体的的单击事件函数
        //        strCodeForCs.Append("\r\n" + "private void btnClose_Click(object sender, System.EventArgs e)");
        //        strCodeForCs.Append("\r\n" + "{");
        //        strCodeForCs.Append("\r\n" + "this.Close();");
        //        strCodeForCs.Append("\r\n" + "}");
        //        //				//第十六步:生成用于传递关键字值的属性函数
        //        strCodeForCs.AppendFormat("\r\n" + "public {0} {1}_key",
        //          objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.ObjFieldTabENEx.FldName);
        //        strCodeForCs.Append("\r\n" + "{");
        //        strCodeForCs.Append("\r\n" + "get");
        //        strCodeForCs.Append("\r\n" + "{");
        //        strCodeForCs.AppendFormat("\r\n" + "return {0};",
        //          objKeyField.ObjFieldTabENEx.PrivPropName);
        //        strCodeForCs.Append("\r\n" + "}");
        //        strCodeForCs.Append("\r\n" + "set");
        //        strCodeForCs.Append("\r\n" + "{");
        //        strCodeForCs.AppendFormat("\r\n" + "{0} = value;",
        //          objKeyField.ObjFieldTabENEx.PrivPropName);
        //        strCodeForCs.Append("\r\n" + "}");
        //        strCodeForCs.Append("\r\n" + "}");

        //        //添加记录准备过程
        //        strTemp = GenAddRecordCode();
        //        strCodeForCs.Append(strTemp);

        //        //添加记录存盘过程
        //        strTemp = GenAddRecordSaveCode();
        //        strCodeForCs.Append(strTemp);

        //        //				//添加记录存盘过程V5版
        //        //				strTemp = GenAddRecordSaveCodeV5();
        //        //				strCodeForCs.Append(strTemp);
        //        //修改记录存盘过程
        //        strTemp = GenUpdateRecordSaveCode();
        //        strCodeForCs.Append(strTemp);
        //        //				//修改记录存盘过程V5版
        //        //				strTemp = GenUpdateRecordSaveCodeV5();
        //        //				strCodeForCs.Append(strTemp);


        //        //最后一步:生成类的结束符和域名空间的结束符
        //        strCodeForCs.Append("\r\n" + "}");
        //        strCodeForCs.Append("\r\n" + "}");
        //    }
        //    catch (Exception ex)
        //    {
        //        clsEntityBase.LogErrorS(ex, "");
        //        throw new Exception(ex.Message, ex);
        //    }
        //    //把生成写到文件中;
        //    //clsPubFun4BLEx.SaveClassContentToFile(objViewInfoENEx.WebFormFName, strCodeForCs.ToString(), objViewInfoENEx.FolderName_Root, myEncoding);

        //    ////检查该文件名的文件夹名,并判断是否存在;
        //    //strFolder = clsString.ParentDir_S(objViewInfoENEx.WebFormFName);
        //    //if (System.IO.Directory.Exists(strFolder) == false)
        //    //{
        //    //    Directory.CreateDirectory(strFolder);
        //    //}

        //    //if (clsSysParaEN_Local.IsBackupForGeneCode  == true)
        //    //{
        //    //    string strSimpleFileName = clsString.GetSimpleFName_S(objViewInfoENEx.WebFormFName);
        //    //    string strFindFileFullFile = clsFile.FindFileFromFolder(objViewInfoENEx.FolderName_Root, strSimpleFileName);
        //    //    while (string.IsNullOrEmpty(strFindFileFullFile) == false)
        //    //    {
        //    //        string strMsg = string.Format("文件:{0}已经存在!", strFindFileFullFile);
        //    //        throw new Exception(strMsg);
        //    //    }
        //    //}
        //    ////UTF8Encoding utf8 = new UTF8Encoding(false);
        //    //clsFile.1CreateFileByString(objViewInfoENEx.WebFormFName, strCodeForCs.ToString(), myEncoding);
        //    return strCodeForCs.ToString();
        //}

        /// <summary>
        /// 生成用于编辑某个表的界面,包括:修改、添加,该界面主要用于被其他界面来调用
        /// 注:不使用控件(NoContral)
        /// </summary>
        /// <returns></returns>
        public string A_GenUpdInsRecCode_NoContral_Net2005(clsViewInfoENEx objViewInfoENEx, ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            if (objViewInfoENEx.objViewRegion_Edit == null)
            {
                string strMsg = string.Format("界面的编辑区域为空,请检查!");
                throw new Exception(strMsg);
            }
            string strTemp;
            ArrayList arrInnerCtlSet = new ArrayList();     //内部控件集合

            //让用户设置属性;
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;
            clsPubFun4BLEx.CheckDgStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.DgStyleId);
            clsPubFun4BLEx.CheckTitleStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.TitleStyleId);

            clsDataGridStyleEN objDGStyleEx = clsDataGridStyleBL.GetObjByDgStyleIdCache(objViewInfoENEx.objViewStyleEN.DgStyleId);
            clsBiDimDistribute objBiDimDistribute = new clsBiDimDistribute();
            objBiDimDistribute.ColNum = objViewInfoENEx.objViewRegion_Edit.ColNum ?? 0;
            objBiDimDistribute.ColWidth = 250;
            objBiDimDistribute.LineHeight = 35;

            float intCtlWidth = objBiDimDistribute.GetCtlWidth();
            float intCtlHeight = objBiDimDistribute.GetCtlHeigh(objViewInfoENEx.objViewRegion_Edit.FieldNum());

            //检查编辑区域
            CheckEditRegion();

            objViewInfoENEx.WebFormName = "frm" + objViewInfoENEx.TabName + "_UI";
            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;
            objViewInfoENEx.WebFormFName = "frm" + objViewInfoENEx.TabName + "_UI.cs";

            strRe_ClsName = objViewInfoENEx.WebFormName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}",
                objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebFormFName);

            try
            {

                //第0步:把控件中下拉框ComboBox转换成ComboBox
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.objCtlType.CtlTypeName == "DropDownList")
                    {
                        objEditRegionFldsEx.objCtlType.CtlTypeName = "ComboBox";
                        objEditRegionFldsEx.CtrlId4Win = objEditRegionFldsEx.CtrlId4Win.Replace("ddl", "cbo");
                    }
                }

                //第一步:生成导入域名空间

                
                //类名开始
                ///
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objViewInfoENEx.CurrUserName, objViewInfoENEx));

                strCodeForCs.Append("\r\n" + "//生成与表相关的控件控制层代码");
                strCodeForCs.Append("\r\n" + "using System;");
                strCodeForCs.Append("\r\n" + "using System.Collections;");
                strCodeForCs.Append("\r\n" + "using System.Collections.Generic;");
                strCodeForCs.Append("\r\n" + "using System.ComponentModel;");
                strCodeForCs.Append("\r\n" + "using System.Data;");
                strCodeForCs.Append("\r\n" + "using System.Drawing;");
                strCodeForCs.Append("\r\n" + "using System.IO;");
                strCodeForCs.Append("\r\n" + "using System.Windows.Forms;");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.common;");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.datetime;");
                
                clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objViewInfoENEx.PrjId); //
                strCodeForCs.AppendFormat("\r\n" + "using {0}.Entity;", objProject.PrjDomain);
                strCodeForCs.AppendFormat("\r\n" + "using {0}.BusinessLogic;", objProject.PrjDomain);

                strCodeForCs.Append("\r\n" + "using com.taishsoft.util;");
                strCodeForCs.Append("\r\n" + "using CommFunc4Win;");


                strCodeForCs.Append("\r\n" + "");

                strCodeForCs.AppendFormat("\r\n" + "namespace {0}", objViewInfoENEx.NameSpace);
                strCodeForCs.Append("\r\n" + "{");
                //第二步:生成控件类名
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///		frm{0}_UI 的摘要说明。", objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public partial class frm{0}_UI : System.Windows.Forms.Form", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                //第三步:生成控件中内部控件变量的名称

                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;",
                  objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "private {1} {0};		//用于传递关键字值的变量",
                  objKeyField.ObjFieldTabENEx.PrivPropName, objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                strCodeForCs.Append("\r\n" + "public string OperateType;");
                strCodeForCs.Append("\r\n" + "public IBindListView iBindListView = null;");

                //第四步:生成必需的设计器变量
                strCodeForCs.AppendFormat("\r\n" + "public frm{0}_UI()",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "// 该调用是 Windows.Forms 窗体设计器所必需的。");
                strCodeForCs.Append("\r\n" + "InitializeComponent();");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "// TODO: 在 InitializeComponent 调用后添加任何初始化");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "}");
                //第五步:清理所有正在使用的资源
                //第六步:组件设计器生成的代码


                //第七步:生成objViewInfoENEx.load代码

                strCodeForCs.AppendFormat("\r\n" + "private void frm{0}_UI_Load(object sender, System.EventArgs e)",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "// 在此处放置用户代码以初始化页面");

                strCodeForCs.Append("\r\n" + "//1、为下拉框设置数据源,绑定列表数据");
                //1、为下拉框设置数据源,绑定列表数据
                strCodeForCs.Append("\r\n" + "this.SetAllComboBox();");

                strCodeForCs.Append("\r\n" + "if (OperateType == \"Update\")");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "ShowData({0});",
                  objKeyField.ObjFieldTabENEx.PrivPropName);
                strCodeForCs.Append("\r\n" + "btnOKUpd.Text = \"确认修改\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "Add{0}Record();",
                        objViewInfoENEx.TabName);
                //        strCodeForCs.Append("\r\n" + "btnOKUpd.Text = \"确认添加\";");
                strCodeForCs.Append("\r\n" + "}");


                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "}");
                //生成下拉框的绑定函数
                strTemp = Genfun_SetAllComboBox4Edit();
                strCodeForCs.Append(strTemp);
                //生成属性变量:
                //第八步:生成控件属性,一般为每个内部控件都相应配置一个属性

                strTemp = Genfun_ViewCtrlProperty4Edit();
                strCodeForCs.Append(strTemp);


                //第九步:生成设置控件中关键字只读特性。SetKeyReadOnly
                clsEditRegionFldsENEx objEditRegionKeyFld = getEditRegionKeyFld();
                if (objEditRegionKeyFld != null)    //如果编辑区存在主关键字
                {
                    if (getEditRegionKeyFld().PrimaryTypeId() != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        strCodeForCs.Append("\r\n" + "/// <summary>");
                        strCodeForCs.Append("\r\n" + "/// 在用户自定义控件中,设置关键字的值,是否只读");
                        strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n" + "/// </summary>");
                        strCodeForCs.Append("\r\n" + "/// <param name = \"bolReadonly\">是否只读</param>");
                        strCodeForCs.Append("\r\n" + "public void SetKeyReadOnly(bool bolReadonly)");
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "{0}.ReadOnly = bolReadonly;", getEditRegionKeyFld().CtrlId4Win);
                        strCodeForCs.Append("\r\n" + "}");
                    }
                }
                //第十步:生成Clear()函数。用来初始化控件中内部控件的值。

                strTemp = Genfun_Clear4EditResion();
                strCodeForCs.Append(strTemp);

                //第十一步:生成设置缺省值的函数。设置该控件在插入状态下的缺省值;
                ///设置该控件在插入状态下的缺省值;
                strTemp = Genfun_SetDefaultValue4EditRegion();
                strCodeForCs.Append(strTemp);

                //第十二步:生成校验函数(IsValid())。校验自定义控件中自子控件的类型数值是否是合法正确的;
                strTemp = Genfun_IsValid();
                strCodeForCs.Append(strTemp);

                //第十三步:生成获取当前日期的字符串(getTodayStr) 获取当前日期的字符串以及获取当前月的字符串;
                //strTemp = clsPubFun4GC.GenGetCurrMonth();
                //strCodeForCs.Append(strTemp);
                //strTemp = clsPubFun4GC.GenGetTodayStr();
                //strCodeForCs.Append(strTemp);

                //第十四步:生成控件中下拉框的BIND函数,即添加下拉框列表项的函数;
                //strTemp = GenCombo1BoxBindFunction();
                //strCodeForCs.Append(strTemp);


                //第十五步:生成一些判断数据类型的的公共函数

                //				strTemp = clsPubFun4GC.GenIsDate();
                //				strCodeForCs.Append(strTemp);
                //strTemp = clsPubFun4GC.1GenIsDigit();
                //strCodeForCs.Append(strTemp);
                //strTemp = clsPubFun4GC.GenIsFloat();
                //strCodeForCs.Append(strTemp);
                //strTemp = clsPubFun4GC.GenIsNumeric();
                //strCodeForCs.Append(strTemp);



                //第十二步:生成显示数据函数(ShowData)校验函数。

                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveExeUpdate || objViewInfoENEx.objViewTypeCodeTab.IsHaveDetail)
                {
                    strCodeForCs.Append("\r\n" + GenShowDataCode_Win());
                }

                //第十三步:生成把类对象的属性内容显示到界面上;
                strTemp = GenGetDataFromClass();
                strCodeForCs.Append(strTemp);

                //第十四步://生成确定修改的事件函数
                strTemp = GenbtnOKUpd_Click();
                strCodeForCs.Append(strTemp);
                //第十五步:生成把界面上的属性数据传到类对象中的代码
                strTemp = GenPutDataToClass();
                strCodeForCs.Append(strTemp);
                //第十六步:生成关闭窗体的的单击事件函数
                strCodeForCs.Append("\r\n" + "private void btnClose_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "this.Close();");
                strCodeForCs.Append("\r\n" + "}");
                //				//第十六步:生成用于传递关键字值的属性函数
                strCodeForCs.AppendFormat("\r\n" + "public {0} {1}_key",
                  objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.ObjFieldTabENEx.FldName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "return {0};",
                  objKeyField.ObjFieldTabENEx.PrivPropName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "{0} = value;",
                  objKeyField.ObjFieldTabENEx.PrivPropName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");

                //添加记录准备过程
                strTemp = GenAddRecordCode();
                strCodeForCs.Append(strTemp);

                //添加记录存盘过程
                strTemp = GenAddRecordSaveCode();
                strCodeForCs.Append(strTemp);

                //				//添加记录存盘过程V5版
                //				strTemp = GenAddRecordSaveCodeV5();
                //				strCodeForCs.Append(strTemp);
                //修改记录存盘过程
                strTemp = GenUpdateRecordSaveCode();
                strCodeForCs.Append(strTemp);
                //				//修改记录存盘过程V5版
                //				strTemp = GenUpdateRecordSaveCodeV5();
                //				strCodeForCs.Append(strTemp);


                //最后一步:生成类的结束符和域名空间的结束符
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            //把生成写到文件中;
            //clsPubFun4BLEx.SaveClassContentToFile(objViewInfoENEx.WebFormFName, strCodeForCs.ToString(), objViewInfoENEx.FolderName_Root, myEncoding);

            ////检查该文件名的文件夹名,并判断是否存在;
            //strFolder = clsString.ParentDir_S(objViewInfoENEx.WebFormFName);
            //if (System.IO.Directory.Exists(strFolder) == false)
            //{
            //    Directory.CreateDirectory(strFolder);
            //}

            //if (clsSysParaEN_Local.IsBackupForGeneCode  == true)
            //{
            //    string strSimpleFileName = clsString.GetSimpleFName_S(objViewInfoENEx.WebFormFName);
            //    string strFindFileFullFile = clsFile.FindFileFromFolder(objViewInfoENEx.FolderName_Root, strSimpleFileName);
            //    while (string.IsNullOrEmpty(strFindFileFullFile) == false)
            //    {
            //        string strMsg = string.Format("文件:{0}已经存在!", strFindFileFullFile);
            //        throw new Exception(strMsg);
            //    }
            //}
            ////UTF8Encoding utf8 = new UTF8Encoding(false);
            //clsFile.1CreateFileByString(objViewInfoENEx.WebFormFName, strCodeForCs.ToString(), myEncoding);
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 生成用于编辑某个表的界面,包括:修改、添加,该界面主要用于被其他界面来调用
        /// 注:不使用控件(NoContral)
        /// </summary>
        /// <returns></returns>
        public string A_GenUpdInsRecCode_NoContral_Net2005_Design(clsViewInfoENEx objViewInfoENEx, ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            Point pntLocation = new Point();
            ArrayList arrInnerCtlSet = new ArrayList();     //内部控件集合

            //让用户设置属性;
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;
            clsPubFun4BLEx.CheckDgStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.DgStyleId);
            clsPubFun4BLEx.CheckTitleStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.TitleStyleId);

            clsDataGridStyleEN objDGStyleEx = clsDataGridStyleBL.GetObjByDgStyleIdCache(objViewInfoENEx.objViewStyleEN.DgStyleId);
            clsBiDimDistribute objBiDimDistribute = new clsBiDimDistribute();
            objBiDimDistribute.ColNum = objViewInfoENEx.objViewRegion_Edit.ColNum ?? 0;
            objBiDimDistribute.ColWidth = 250;
            objBiDimDistribute.LineHeight = 35;
            int intLblHeight = 18;
            int intLblWidth = 70;
            int intTxtHeight = 20;
            int intTxtWidth = 100;

            float intCtlWidth = objBiDimDistribute.GetCtlWidth();
            float intCtlHeight = objBiDimDistribute.GetCtlHeigh(objViewInfoENEx.objViewRegion_Edit.FieldNum());

            //检查编辑区域
            CheckEditRegion();

            objViewInfoENEx.WebFormName = "frm" + objViewInfoENEx.TabName + "_UI";
            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;
            objViewInfoENEx.WebFormFName = "frm" + objViewInfoENEx.TabName + "_UI.Designer.cs";

            strRe_ClsName = objViewInfoENEx.WebFormName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}",
                objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebFormFName);

            try
            {

                //第0步:把控件中下拉框ComboBox转换成ComboBox
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.objCtlType.CtlTypeName == "DropDownList")
                    {
                        objEditRegionFldsEx.objCtlType.CtlTypeName = "ComboBox";
                        objEditRegionFldsEx.CtrlId4Win = objEditRegionFldsEx.CtrlId4Win.Replace("ddl", "cbo");
                    }
                }

                //第一步:生成导入域名空间

                
                //类名开始
                ///
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objViewInfoENEx.CurrUserName, objViewInfoENEx));

                strCodeForCs.AppendFormat("\r\n" + "namespace {0}", objViewInfoENEx.NameSpace);
                strCodeForCs.Append("\r\n" + "{");
                //第二步:生成控件类名
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///		frm{0}_UI 的摘要说明。", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "partial class frm{0}_UI", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");

                //第四步:生成必需的设计器变量
                strCodeForCs.Append("\r\n /// <summary> ");
                strCodeForCs.Append("\r\n /// 必需的设计器变量。");
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "private System.ComponentModel.Container components = null;");
                strCodeForCs.Append("\r\n" + "");
                //第五步:清理所有正在使用的资源
                strCodeForCs.Append("\r\n /// <summary> ");
                strCodeForCs.Append("\r\n /// 清理所有正在使用的资源。");
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "protected override void Dispose( bool disposing)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if( disposing)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if(components != null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "components.Dispose();");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "base.Dispose( disposing);");
                strCodeForCs.Append("\r\n" + "}");
                //第六步:组件设计器生成的代码

                strCodeForCs.Append("\r\n" + "#region 组件设计器生成的代码");
                strCodeForCs.Append("\r\n /// <summary> ");
                strCodeForCs.Append("\r\n /// 设计器支持所需的方法 - 不要使用代码编辑器 ");
                strCodeForCs.Append("\r\n /// 修改此方法的内容。");
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "private void InitializeComponent()");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    strCodeForCs.AppendFormat("\r\n" + "this.lbl{0} = new System.Windows.Forms.Label();",
                      objEditRegionFldsEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "this.{0} = new System.Windows.Forms.{1}();",
                      objEditRegionFldsEx.CtrlId4Win, objEditRegionFldsEx.objCtlType.CtlTypeName);
                }

                strCodeForCs.Append("\r\n" + "this.lblMsg = new System.Windows.Forms.Label();");
                strCodeForCs.Append("\r\n" + "this.btnOKUpd = new System.Windows.Forms.Button();");
                strCodeForCs.Append("\r\n" + "this.btnClose = new System.Windows.Forms.Button();");
                strCodeForCs.Append("\r\n" + "this.SuspendLayout();");

                int intIndex = 1;
                pntLocation.X = 10;
                pntLocation.Y = 10;
                clsBiDimDistribute objBiDimDistribue = new clsBiDimDistribute();
                objBiDimDistribue.StartX = 10;
                objBiDimDistribue.StartY = 10;
                objBiDimDistribue.ColNum = objViewInfoENEx.objViewRegion_Edit.ColNum ?? 0;
                objBiDimDistribue.ColWidth = 250;
                objBiDimDistribue.LineHeight = 30;
                int intFieldIndex = 0;
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    ///如果该字段不是标识递增型就生成控件,否则就不生成;
                    if (objEditRegionFldsEx.PrimaryTypeId()!= clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        switch (objEditRegionFldsEx.objCtlType.CtlTypeName)
                        {
                            case "CheckBox":
                                // 
                                // checkBox1
                                // 
                                //定义控件
                                strCodeForCs.Append("\r\n" + "//");
                                strCodeForCs.AppendFormat("\r\n" + "// {0}", objEditRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "//");

                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Location = new System.Drawing.Point({1}, {2});",
                                  objEditRegionFldsEx.CtrlId4Win,
                                  objBiDimDistribue.GetPosition(intFieldIndex).X,
                                  objBiDimDistribue.GetPosition(intFieldIndex).Y);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Name = \"{0}\";",
                                  objEditRegionFldsEx.CtrlId4Win);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Size = new System.Drawing.Size({1}, {2});",
                                  objEditRegionFldsEx.CtrlId4Win, intTxtWidth, intTxtHeight);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.TabIndex = {1};",
                                  objEditRegionFldsEx.CtrlId4Win, intIndex++);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Text = \"{1}\";",
                                  objEditRegionFldsEx.CtrlId4Win, objEditRegionFldsEx.LabelCaption);
                                //把当前内部控件添加内部控件集合中
                                arrInnerCtlSet.Add("this." + objEditRegionFldsEx.CtrlId4Win);
                                pntLocation.Y += 30;
                                break;
                            case "ComboBox":
                            case "DropDownList":
                                //定义控件相应的Label
                                strCodeForCs.Append("\r\n" + "//");
                                strCodeForCs.AppendFormat("\r\n" + "// lbl{0}", objEditRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "//");

                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Location = new System.Drawing.Point({1}, {2});",
                                  objEditRegionFldsEx.FldName,
                                  objBiDimDistribue.GetPosition(intFieldIndex).X,
                                  objBiDimDistribue.GetPosition(intFieldIndex).Y);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Name = \"lbl{0}\";",
                                  objEditRegionFldsEx.FldName);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Size = new System.Drawing.Size({1}, {2});",
                                  objEditRegionFldsEx.FldName, intLblWidth, intLblHeight);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.TabIndex = {1};",
                                  objEditRegionFldsEx.FldName, intIndex++);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Text = \"{1}\";",
                                  objEditRegionFldsEx.FldName,
                                  objEditRegionFldsEx.LabelCaption);
                                //把当前内部控件添加内部控件集合中
                                arrInnerCtlSet.Add("this.lbl" + objEditRegionFldsEx.FldName);

                                //定义控件
                                strCodeForCs.Append("\r\n" + "//");
                                strCodeForCs.AppendFormat("\r\n" + "// {0}", objEditRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "//");
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;",
                                    objEditRegionFldsEx.CtrlId4Win);

                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Location = new System.Drawing.Point({1}, {2});",
                                  objEditRegionFldsEx.CtrlId4Win,
                                  objBiDimDistribue.GetPosition(intFieldIndex).X + 80,
                                  objBiDimDistribue.GetPosition(intFieldIndex).Y);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Name = \"{0}\";",
                                  objEditRegionFldsEx.CtrlId4Win);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Size = new System.Drawing.Size({1}, {2});",
                                  objEditRegionFldsEx.CtrlId4Win, intTxtWidth, intTxtHeight);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.TabIndex = {1};",
                                  objEditRegionFldsEx.CtrlId4Win, intIndex++);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Text = \"\";",
                                  objEditRegionFldsEx.CtrlId4Win);
                                //把当前内部控件添加内部控件集合中
                                arrInnerCtlSet.Add("this." + objEditRegionFldsEx.CtrlId4Win);
                                pntLocation.Y += 30;
                                break;

                            default:

                                //定义控件相应的Label
                                strCodeForCs.Append("\r\n" + "//");
                                strCodeForCs.AppendFormat("\r\n" + "// lbl{0}", objEditRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "//");

                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Location = new System.Drawing.Point({1}, {2});",
                                  objEditRegionFldsEx.FldName,
                                  objBiDimDistribue.GetPosition(intFieldIndex).X,
                                  objBiDimDistribue.GetPosition(intFieldIndex).Y);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Name = \"lbl{0}\";",
                                  objEditRegionFldsEx.FldName);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Size = new System.Drawing.Size({1}, {2});",
                                  objEditRegionFldsEx.FldName, intLblWidth, intLblHeight);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.TabIndex = {1};",
                                  objEditRegionFldsEx.FldName, intIndex++);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Text = \"{1}\";",
                                  objEditRegionFldsEx.FldName,
                                  objEditRegionFldsEx.LabelCaption);
                                //把当前内部控件添加内部控件集合中
                                arrInnerCtlSet.Add("this.lbl" + objEditRegionFldsEx.FldName);

                                //定义控件
                                strCodeForCs.Append("\r\n" + "//");
                                strCodeForCs.AppendFormat("\r\n" + "// {0}", objEditRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "//");

                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Location = new System.Drawing.Point({1}, {2});",
                                  objEditRegionFldsEx.CtrlId4Win,
                                  objBiDimDistribue.GetPosition(intFieldIndex).X + 80,
                                  objBiDimDistribue.GetPosition(intFieldIndex).Y);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Name = \"{0}\";",
                                  objEditRegionFldsEx.CtrlId4Win);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Size = new System.Drawing.Size({1}, {2});",
                                  objEditRegionFldsEx.CtrlId4Win, intTxtWidth, intTxtHeight);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.TabIndex = {1};",
                                  objEditRegionFldsEx.CtrlId4Win, intIndex++);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Text = \"\";",
                                  objEditRegionFldsEx.CtrlId4Win);
                                //把当前内部控件添加内部控件集合中
                                arrInnerCtlSet.Add("this." + objEditRegionFldsEx.CtrlId4Win);
                                pntLocation.Y += 30;
                                break;
                                //end of switch
                        }
                        //end of if(objEditRegionFldsEx.IsIdentity = false && objEditRegionFldsEx.IsCtlField == true)
                    }
                    //end of foreach(clsEditRegionFldsENEx objEditRegionFldsEx in arrViewCtlFldSet)
                    intFieldIndex++;
                }



                // 
                // btnOKUpd
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// btnOKUpd");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.btnOKUpd.Font = new System.Drawing.Font(\"宋体\", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));");
                strCodeForCs.AppendFormat("\r\n" + "this.btnOKUpd.Location = new System.Drawing.Point({0}, {1});",
                  intCtlWidth / 4,
                  objBiDimDistribue.GetPosition(intFieldIndex + 1).Y + 30);
                strCodeForCs.Append("\r\n" + "this.btnOKUpd.Name = \"btnOKUpd\";");
                strCodeForCs.Append("\r\n" + "this.btnOKUpd.Size = new System.Drawing.Size(80, 30);");
                strCodeForCs.AppendFormat("\r\n" + "this.btnOKUpd.TabIndex = {0};",
                  intIndex++);
                strCodeForCs.Append("\r\n" + "this.btnOKUpd.Text = \"添加\";");
                strCodeForCs.Append("\r\n" + "this.btnOKUpd.Click += new System.EventHandler(this.btnOKUpd_Click);");

                // 
                // btnClose
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// btnClose");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.btnClose.Font = new System.Drawing.Font(\"宋体\", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));");
                strCodeForCs.AppendFormat("\r\n" + "this.btnClose.Location = new System.Drawing.Point({0}, {1});",
                  intCtlWidth / 4 + 120,
                  objBiDimDistribue.GetPosition(intFieldIndex + 1).Y + 30);
                strCodeForCs.Append("\r\n" + "this.btnClose.Name = \"btnClose\";");
                strCodeForCs.Append("\r\n" + "this.btnClose.Size = new System.Drawing.Size(80, 30);");
                strCodeForCs.AppendFormat("\r\n" + "this.btnClose.TabIndex = {0};",
                  intIndex++);
                strCodeForCs.Append("\r\n" + "this.btnClose.Text = \"关闭\";");
                strCodeForCs.Append("\r\n" + "this.btnClose.Click += new System.EventHandler(this.btnClose_Click);");
                // 
                // lblMsg
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// lblMsg");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.AppendFormat("\r\n" + "this.lblMsg.Location = new System.Drawing.Point({0}, {1});",
                  intCtlWidth / 4,
                   objBiDimDistribue.GetPosition(intFieldIndex + 1).Y + 60);
                strCodeForCs.Append("\r\n" + "this.lblMsg.Name = \"lblMsg\";");
                strCodeForCs.Append("\r\n" + "this.lblMsg.Size = new System.Drawing.Size(128, 16);");
                strCodeForCs.AppendFormat("\r\n" + "this.lblMsg.TabIndex = {0};",
                  intIndex++);

                //向控件的内部控件集合中添加内部控件
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.AppendFormat("\r\n" + "// frm{0}_UI",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);");
                strCodeForCs.AppendFormat("\r\n" + "this.ClientSize = new System.Drawing.Size({0}, {1});",
                  intCtlWidth + 30,
                  objBiDimDistribue.GetPosition(intFieldIndex + 3).Y + 150);
                //向控件的内部控件集合中添加内部控件
                foreach (string strCtlName in arrInnerCtlSet)
                {
                    strCodeForCs.AppendFormat("\r\n" + "this.Controls.Add({0});",
                      strCtlName);
                }


                strCodeForCs.Append("\r\n" + "this.Controls.Add(this.btnClose);");
                strCodeForCs.Append("\r\n" + "this.Controls.Add(this.btnOKUpd);");
                strCodeForCs.Append("\r\n" + "this.Controls.Add(this.lblMsg);");
                strCodeForCs.AppendFormat("\r\n" + "this.Name = \"frm{0}_UI\";",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;");
                strCodeForCs.Append("\r\n" + "this.Font = new System.Drawing.Font(\"宋体\", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));");

                strCodeForCs.AppendFormat("\r\n" + "this.Text = \"frm{0}_UI\";",
                  objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "this.Load += new System.EventHandler(this.frm{0}_UI_Load);",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "this.ResumeLayout(false);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "#endregion");

                //第三步:生成控件中内部控件变量的名称

                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.Label {0};", "lbl" + objEditRegionFldsEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.{1} {0};", objEditRegionFldsEx.CtrlId4Win, objEditRegionFldsEx.objCtlType.CtlTypeName);
                }
                strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.Label lblMsg; ");
                strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.Button btnOKUpd;");
                strCodeForCs.Append("\r\n" + "private System.Windows.Forms.Button btnClose;");

                //最后一步:生成类的结束符和域名空间的结束符
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            //把生成写到文件中;
            //clsPubFun4BLEx.SaveClassContentToFile(objViewInfoENEx.WebFormFName, strCodeForCs.ToString(), objViewInfoENEx.FolderName_Root, myEncoding);

            ////检查该文件名的文件夹名,并判断是否存在;
            //strFolder = clsString.ParentDir_S(objViewInfoENEx.WebFormFName);
            //if (System.IO.Directory.Exists(strFolder) == false)
            //{
            //    Directory.CreateDirectory(strFolder);
            //}

            //if (clsSysParaEN_Local.IsBackupForGeneCode  == true)
            //{
            //    string strSimpleFileName = clsString.GetSimpleFName_S(objViewInfoENEx.WebFormFName);
            //    string strFindFileFullFile = clsFile.FindFileFromFolder(objViewInfoENEx.FolderName_Root, strSimpleFileName);
            //    while (string.IsNullOrEmpty(strFindFileFullFile) == false)
            //    {
            //        string strMsg = string.Format("文件:{0}已经存在!", strFindFileFullFile);
            //        throw new Exception(strMsg);
            //    }
            //}
            ////UTF8Encoding utf8 = new UTF8Encoding(false);
            //clsFile.1CreateFileByString(objViewInfoENEx.WebFormFName, strCodeForCs.ToString(), myEncoding);
            return strCodeForCs.ToString();
        }


        /// <summary>
        /// 生成指定的函数
        /// </summary>
        /// <returns>返回生成的指定函数代码</returns>
        public string A_GenCode4Function(clsViewInfoENEx objViewInfoENEx, string strFuncId4GC)
        {
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp = ""; //临时变量;
            string strFuncName = "";
            try
            {
                //类名开始
                 clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
                strFuncName = objvFunction4GeneCodeEN.FuncName;

                //if (objFunction4GeneCodeEN.FuncTypeId == "10")//用户自定义函数
                //{
                //    //strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId(objFunction4GeneCodeEN.FuncId4GC,
                //    //    objPrjTabENEx.TabId, objPrjTabENEx.PrjDataBaseId, objPrjTabENEx.PrjId);
                //}
                //else
                //{
                //strTemp = A_GeneFuncCode(objViewInfoENEx, strFuncName);
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
    }
}

