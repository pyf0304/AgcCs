using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AGC.PureClass;
using AGC.PureClassEx;
using AgcCommBase;
using com.taishsoft.commexception;
using com.taishsoft.common;
using com.taishsoft.comm_db_obj;
using com.taishsoft.util;
using TzAdvancedLib;
using CodeStruct;

namespace AutoGCLib
{
    /// <summary>
    /// Ai4版本的TypeScript代码生成器
    /// 特点：
    /// 1. 继承 AIOperateListBase 基类
    /// 2. 使用模板方法模式
    /// 3. 更简洁的代码结构
    /// 4. 列定义外置到独立文件
    /// </summary>
    partial class Vue_ViewScriptCS_TS4TypeScript_Ai4 : Vue_ViewScriptCS_TS4TypeScript
    {
        #region 构造函数
        public Vue_ViewScriptCS_TS4TypeScript_Ai4()
        {
        }

        public Vue_ViewScriptCS_TS4TypeScript_Ai4(string strViewId)
            : base(strViewId, "", "")
        {
        }

        public Vue_ViewScriptCS_TS4TypeScript_Ai4(string strViewId, string strPrjDataBaseId, string strPrjId)
            : base(strViewId, strPrjDataBaseId, strPrjId)
        {
        }
        #endregion

        #region 生成主入口
        /// <summary>
        /// 生成Ai4版本的TypeScript代码
        /// </summary>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            // 先调用基类方法进行初始化
            base.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName);

            // 修改类名后缀为 Ai4
            strRe_ClsName = strRe_ClsName + "Ai4";
            objViewInfoENEx.WebFormName = strRe_ClsName;

            StringBuilder strCodeForTs = new StringBuilder();

            // 生成文件头部注释
            strCodeForTs.AppendLine(Gen_Ai4_FileHeader());

            // 生成导入语句
            strCodeForTs.AppendLine(Gen_Ai4_Imports());

            // 生成文档注释
            strCodeForTs.AppendLine(Gen_Ai4_ClassDocComment());

            // 生成类定义
            strCodeForTs.AppendLine(Gen_Ai4_ClassDefinition());

            // 生成构造函数
            strCodeForTs.AppendLine(Gen_Ai4_Constructor());

            // 生成属性和抽象方法
            strCodeForTs.AppendLine(Gen_Ai4_PropertiesAndAbstractMethods());

            // 生成页面加载方法
            strCodeForTs.AppendLine(Gen_Ai4_PageLoadCache());

            // 生成查询按钮方法
            strCodeForTs.AppendLine(Gen_Ai4_btnQuery_Click());

            // 生成下拉框绑定方法
            strCodeForTs.AppendLine(Gen_Ai4_SetDdl_Methods());

            // 生成按钮点击方法
            strCodeForTs.AppendLine(Gen_Ai4_ButtonClickMethods());

            // 生成导出Excel方法
            strCodeForTs.AppendLine(Gen_Ai4_ExportExcelMethods());

            // 生成数据绑定方法
            strCodeForTs.AppendLine(Gen_Ai4_BindTabMethods());

            // 生成分页方法
            strCodeForTs.AppendLine(Gen_Ai4_PagingMethods());

            // 生成辅助方法
            strCodeForTs.AppendLine(Gen_Ai4_HelperMethods());

            // 生成类结束
            strCodeForTs.AppendLine("}");

            return strCodeForTs.ToString();
        }
        #endregion

        #region 生成文件头部
        /// <summary>
        /// 生成文件头部注释
        /// </summary>
        private string Gen_Ai4_FileHeader()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("import { ExportExcelData } from '@/ts/PubFun/ExportExcelData';");
            sb.AppendLine("import {");
            sb.AppendLine(string.Format("  Combine{0}ConditionObj4ExportExcel,", TabName_Out4ListRegion4GC));
            sb.AppendLine(string.Format("  Combine{0}ConditionObj,", TabName_Out4ListRegion4GC));
            sb.AppendLine(string.Format("  {0}_DeleteKeyIdCache,", TabName_Out4ListRegion4GC));
            sb.AppendLine("  divVarSet,");
            sb.AppendLine("  viewVarSet,");
            sb.AppendLine("  dataColumn,");
            sb.AppendLine("  BindTabByList,");
            sb.AppendLine(string.Format("  ref{0}_List,", TabName_Out4ListRegion4GC));
            sb.AppendLine(string.Format("}} from '@/views/{0}/{1}VueShare';", objFuncModuleEN.FuncModuleName, TabName_Out4ListRegion4GC));

            return sb.ToString();
        }

        /// <summary>
        /// 生成导入语句
        /// </summary>
        private string Gen_Ai4_Imports()
        {
            StringBuilder sb = new StringBuilder();

            // WApi导入
            sb.AppendLine("import {");
            sb.AppendLine(string.Format("  {0}_GetRecCountByCondCache,", TabName_Out4ListRegion4GC));
            sb.AppendLine(string.Format("  {0}_GetSubObjLstCache,", TabName_Out4ListRegion4GC));
            sb.AppendLine(string.Format("  {0}_ReFreshCache,", TabName_Out4ListRegion4GC));
            sb.AppendLine(string.Format("  {0}_FuncMapByFldName,", TabName_Out4ListRegion4GC));
            sb.AppendLine(string.Format("  {0}_GetObjExLstByPagerCache,", TabName_Out4ListRegion4GC));
            sb.AppendLine(string.Format("  {0}_GetObjLstBy{1}IdLstAsync,", TabName_Out4ListRegion4GC, TabName_Out4ListRegion4GC));
            sb.AppendLine(string.Format("  {0}_UpdateRecordAsync,", TabName_Out4ListRegion4GC));
            sb.AppendLine(string.Format("  {0}_Del{1}sAsync,", TabName_Out4ListRegion4GC, TabName_Out4ListRegion4GC));
            sb.AppendLine(string.Format("}} from '@/ts/L3ForWApi/{0}/cls{1}WApi';", objFuncModuleEN.FuncModuleName, TabName_Out4ListRegion4GC));

            // 实体类导入
            sb.AppendLine(string.Format("import {{ cls{0}ENEx }} from '@/ts/L0Entity/{1}/cls{0}ENEx';", TabName_Out4ListRegion4GC, objFuncModuleEN.FuncModuleName));
            sb.AppendLine(string.Format("import {{ cls{0}EN }} from '@/ts/L0Entity/{1}/cls{0}EN';", TabName_Out4ListRegion4GC, objFuncModuleEN.FuncModuleName));

            // 公共函数导入
            sb.AppendLine("import {");
            sb.AppendLine("  GetCheckedKeyIdsInDivObj,");
            sb.AppendLine("  GetSelectValueInDivObj,");
            sb.AppendLine("  GetDivObjInDivObj,");
            sb.AppendLine("} from '@/ts/PubFun/clsCommFunc4Ctrl';");

            sb.AppendLine("import { IsNullOrEmpty, Format } from '@/ts/PubFun/clsString';");
            sb.AppendLine("import { ObjectAssign, BindTab, confirmDel } from '@/ts/PubFun/clsCommFunc4Web';");
            sb.AppendLine("import { stuPagerPara } from '@/ts/PubFun/stuPagerPara';");
            sb.AppendLine("import { clsDataColumn } from '@/ts/PubFun/clsDataColumn';");
            sb.AppendLine("import { clsOperateList, GetCurrPageIndex } from '@/ts/PubFun/clsOperateList';");

            // 基类导入
            sb.AppendLine("import { AIOperateListBase } from '@/viewsBase/common/AIOperateListBase';");

            // 列定义导入
            sb.AppendLine("import {");
            sb.AppendLine("  getExportColumnSpecsAi2,");
            sb.AppendLine("  getListColumnsAi2,");
            sb.AppendLine(string.Format("}} from '@/viewsBase/{0}/{1}Ai2Columns';", objFuncModuleEN.FuncModuleName, ThisClsName));
            sb.AppendLine();

            return sb.ToString();
        }
        #endregion

        #region 生成类定义部分
        /// <summary>
        /// 生成类文档注释
        /// </summary>
        private string Gen_Ai4_ClassDocComment()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("/**");
            sb.AppendLine(" * Ai4版基类：");
            sb.AppendLine(" * 在Ai3基础上增加命令schema驱动，不改变原有基类行为。");
            sb.AppendLine(" */");
            return sb.ToString();
        }

        /// <summary>
        /// 生成类定义
        /// </summary>
        private string Gen_Ai4_ClassDefinition()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("export abstract class {0} extends AIOperateListBase implements clsOperateList {{", ThisClsName + "Ai4"));
            sb.AppendLine("  public static vuebtn_Click: (strCommandName: string, strKeyId: any) => void;");
            sb.AppendLine("  public static GetPropValue: (strPropName: string) => string;");
            sb.AppendLine("  public static sortFunStatic: (ascOrDesc: string) => (x: any, y: any) => number;");
            sb.AppendLine("  public recCount = 0;");
            sb.AppendLine();
            return sb.ToString();
        }

        /// <summary>
        /// 生成构造函数
        /// </summary>
        private string Gen_Ai4_Constructor()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("  constructor() {");
            sb.AppendLine("    super(divVarSet.refDivLayout, divVarSet.refDivList);");
            sb.AppendLine("  }");
            sb.AppendLine();
            return sb.ToString();
        }

        /// <summary>
        /// 生成属性和抽象方法
        /// </summary>
        private string Gen_Ai4_PropertiesAndAbstractMethods()
        {
            StringBuilder sb = new StringBuilder();

            // 属性
            sb.AppendLine("  public get thisTabName(): string {");
            sb.AppendLine(string.Format("    return cls{0}EN._CurrTabName;", TabName_Out4ListRegion4GC));
            sb.AppendLine("  }");
            sb.AppendLine();

            sb.AppendLine("  public get dispAllErrMsg_q(): boolean {");
            sb.AppendLine("    return true;");
            sb.AppendLine("  }");
            sb.AppendLine();

            // 抽象方法占位
            sb.AppendLine("  public async InitVarSet(): Promise<void> {");
            sb.AppendLine("    // no-op");
            sb.AppendLine("  }");
            sb.AppendLine();

            sb.AppendLine("  public async InitCtlVar(): Promise<void> {");
            sb.AppendLine("    // no-op");
            sb.AppendLine("  }");
            sb.AppendLine();

            // 列定义方法
            sb.AppendLine("  protected getListColumnsAi(): Array<clsDataColumn> {");
            sb.AppendLine("    return getListColumnsAi2();");
            sb.AppendLine("  }");
            sb.AppendLine();

            sb.AppendLine("  protected getExportColumnSpecsAi(): Array<{ colHeader: string }> {");
            sb.AppendLine("    return getExportColumnSpecsAi2();");
            sb.AppendLine("  }");
            sb.AppendLine();

            sb.AppendLine("  public abstract SortColumn(sortColumnKey: string, sortDirection: string): void;");
            sb.AppendLine();

            return sb.ToString();
        }
        #endregion

        #region 生成页面加载和查询方法
        /// <summary>
        /// 生成页面加载方法（Ai4版本）
        /// </summary>
        private string Gen_Ai4_PageLoadCache()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("  /**");
            sb.AppendLine("   * 页面加载初始化：调用基类PageLoadTemplate执行完整初始化流程");
            sb.AppendLine("   *");
            sb.AppendLine("   * 职责：");
            sb.AppendLine("   * 1. 初始化业务变量集合（InitVarSet）");
            sb.AppendLine("   * 2. 初始化UI控件状态（InitCtlVar）");
            sb.AppendLine("   * 3. 设置默认排序规则");
            sb.AppendLine("   * 4. 加载并绑定数据到表格");
            sb.AppendLine("   *");
            sb.AppendLine("   * 使用场景：页面首次加载或需要重置页面状态时调用");
            sb.AppendLine("   */");
            sb.AppendLine("  public async PageLoadCache() {");
            sb.AppendLine("    await this.PageLoadTemplate({");
            sb.AppendLine("      actionFuncName: this.PageLoadCache.name,");
            sb.AppendLine("      initVarSet: async () => {");
            sb.AppendLine("        await this.InitVarSet();");
            sb.AppendLine("      },");
            sb.AppendLine("      initCtlVar: async () => {");
            sb.AppendLine("        await this.InitCtlVar();");
            sb.AppendLine("      },");
            sb.AppendLine(string.Format("      currentSortBy: viewVarSet.sort{0}By,", TabName_Out4ListRegion4GC));
            sb.AppendLine(string.Format("      defaultSortBy: `${{cls{0}EN.con_{1}}} Asc`,", TabName_Out4ListRegion4GC, objKeyField.FldName));
            sb.AppendLine("      setSortBy: (sortBy: string) => {");
            sb.AppendLine(string.Format("        viewVarSet.sort{0}By = sortBy;", TabName_Out4ListRegion4GC));
            sb.AppendLine("      },");
            sb.AppendLine("      onLoaded: async () => {");
            sb.AppendLine(string.Format("        await this.BindGv_{0}4Func(divVarSet.refDivList);", TabName_Out4ListRegion4GC));
            sb.AppendLine("      },");
            sb.AppendLine("    });");
            sb.AppendLine("  }");
            sb.AppendLine();

            return sb.ToString();
        }

        /// <summary>
        /// 生成查询按钮方法（Ai4版本）
        /// </summary>
        private string Gen_Ai4_btnQuery_Click()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("  /**");
            sb.AppendLine("   * 查询按钮点击事件处理：调用基类QueryClickTemplate执行查询");
            sb.AppendLine("   *");
            sb.AppendLine("   * 职责：");
            sb.AppendLine("   * 1. 重置页码到第1页");
            sb.AppendLine("   * 2. 根据查询条件刷新数据");
            sb.AppendLine("   *");
            sb.AppendLine("   * 使用场景：用户点击查询按钮时触发");
            sb.AppendLine("   */");
            sb.AppendLine("  public async btnQuery_Click() {");
            sb.AppendLine("    await this.QueryClickTemplate(async () => {");
            sb.AppendLine(string.Format("      await this.BindGv_{0}4Func(divVarSet.refDivList);", TabName_Out4ListRegion4GC));
            sb.AppendLine("    });");
            sb.AppendLine("  }");
            sb.AppendLine();

            return sb.ToString();
        }
        #endregion

        #region 生成下拉框绑定方法
        /// <summary>
        /// 生成下拉框绑定方法
        /// </summary>
        private string Gen_Ai4_SetDdl_Methods()
        {
            StringBuilder sb = new StringBuilder();

            // 这里需要根据实际的FeatureRegion字段生成
            // 示例：生成 UseStateId 的下拉框绑定
            if (objViewInfoENEx.arrViewFeatureFlds != null)
            {
                foreach (var fld in objViewInfoENEx.arrViewFeatureFlds)
                {
                    if (fld.CtlTypeId == enumCtlType.DropDownList_06)
                    {
                        sb.AppendLine(string.Format("  public async SetDdl_{0}InDivInFeature() {{", fld.FldName));
                        // 这里需要生成实际的绑定代码
                        sb.AppendLine("    // TODO: 实现下拉框绑定");
                        sb.AppendLine("  }");
                        sb.AppendLine();
                    }
                }
            }

            return sb.ToString();
        }
        #endregion

        #region 生成按钮点击方法
        /// <summary>
        /// 生成按钮点击方法
        /// </summary>
        private string Gen_Ai4_ButtonClickMethods()
        {
            StringBuilder sb = new StringBuilder();

            // 删除按钮
            sb.AppendLine(Gen_Ai4_btnDelRecord_Click());

            // 其他功能按钮
            // 可以根据 arrFeatureRegionFlds 生成

            return sb.ToString();
        }

        /// <summary>
        /// 生成删除按钮方法
        /// </summary>
        private string Gen_Ai4_btnDelRecord_Click()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("  /**");
            sb.AppendLine("   * 删除记录按钮点击事件处理");
            sb.AppendLine("   *");
            sb.AppendLine("   * 流程：");
            sb.AppendLine("   * 1. 验证是否选中了要删除的记录");
            sb.AppendLine("   * 2. 弹出确认对话框，要求用户确认删除");
            sb.AppendLine("   * 3. 执行批量删除操作");
            sb.AppendLine("   * 4. 操作完成后刷新数据列表");
            sb.AppendLine("   *");
            sb.AppendLine("   * 使用场景：用户选择多条记录后，点击\"删除\"按钮");
            sb.AppendLine("   */");
            sb.AppendLine("  public async btnDelRecord_Click() {");
            sb.AppendLine("    try {");
            sb.AppendLine("      await this.ExecuteSelectionActionTemplate({");
            sb.AppendLine("        selectedKeys: GetCheckedKeyIdsInDivObj(divVarSet.refDivList),");
            sb.AppendLine(string.Format("        emptySelectionMessage: `请选择需要删除的${{this.thisTabName}}记录!`,"));
            sb.AppendLine("        beforeExecute: (arrKeyIds) => confirmDel(arrKeyIds.length),");
            sb.AppendLine("        execute: async (arrKeyIds) => {");
            sb.AppendLine("          await this.DelMultiRecord(arrKeyIds);");
            sb.AppendLine("        },");
            sb.AppendLine("        onAfterExecute: async () => {");
            sb.AppendLine(string.Format("          await this.BindGv_{0}4Func(divVarSet.refDivList);", TabName_Out4ListRegion4GC));
            sb.AppendLine("        },");
            sb.AppendLine("      });");
            sb.AppendLine("    } catch (e) {");
            sb.AppendLine(string.Format("      const strMsg = `删除${{this.thisTabName}}记录不成功. ${{e}}.(in ${{this.constructor.name}}.${{this.btnDelRecord_Click.name}}`;"));
            sb.AppendLine("      console.error(strMsg);");
            sb.AppendLine("      alert(strMsg);");
            sb.AppendLine("    }");
            sb.AppendLine("  }");
            sb.AppendLine();

            //DelMultiRecord 方法
            sb.AppendLine(string.Format("  public async DelMultiRecord(arr{0}Id: Array<string>) {{", TabName_Out4ListRegion4GC));
            sb.AppendLine("    const strThisFuncName = this.DelMultiRecord.name;");
            sb.AppendLine("    try {");
            sb.AppendLine(string.Format("      const returnInt = await {0}_Del{0}sAsync(arr{0}Id);", TabName_Out4ListRegion4GC));
            sb.AppendLine("      if (returnInt > 0) {");
            sb.AppendLine(string.Format("        {0}_ReFreshCache();", TabName_Out4ListRegion4GC));
            sb.AppendLine(string.Format("        alert(`删除${{this.thisTabName}}记录成功,共删除${{returnInt}}条记录!`);"));
            sb.AppendLine("      } else {");
            sb.AppendLine(string.Format("        alert(`删除${{this.thisTabName}}记录不成功!`);"));
            sb.AppendLine("      }");
            sb.AppendLine("    } catch (e) {");
            sb.AppendLine(string.Format("      const strMsg = `删除${{this.thisTabName}}记录不成功. ${{e}}.(in ${{this.constructor.name}}.${{strThisFuncName}}`;"));
            sb.AppendLine("      console.error(strMsg);");
            sb.AppendLine("      alert(strMsg);");
            sb.AppendLine("    }");
            sb.AppendLine("  }");
            sb.AppendLine();

            return sb.ToString();
        }
        #endregion

        #region 生成导出Excel方法
        /// <summary>
        /// 生成导出Excel方法
        /// </summary>
        private string Gen_Ai4_ExportExcelMethods()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("  /** 按当前查询条件导出原始列表数据。 */");
            sb.AppendLine(string.Format("  public async ExportExcel_{0}Cache(): Promise<ExportExcelData> {{", TabName_Out4ListRegion4GC));
            sb.AppendLine("    const strThisFuncName = this.ExportExcel_" + TabName_Out4ListRegion4GC + "Cache.name;");
            sb.AppendLine(string.Format("    if (viewVarSet.sort{0}By == null) {{", TabName_Out4ListRegion4GC));
            sb.AppendLine("      const strMsg = Format('在显示列表时,排序字段(sort" + TabName_Out4ListRegion4GC + "By)为空,请检查!(In BindGv_" + TabName_Out4ListRegion4GC + "Cache)');");
            sb.AppendLine("      console.error(strMsg);");
            sb.AppendLine("      alert(strMsg);");
            sb.AppendLine("      return { arrObjLst: [], sheetName: '', fileName: '' };");
            sb.AppendLine("    }");
            sb.AppendLine();
            sb.AppendLine(string.Format("    const obj{0}Cond = await Combine{0}ConditionObj4ExportExcel();", TabName_Out4ListRegion4GC));
            sb.AppendLine(string.Format("    let arr{0}ObjLst: Array<cls{0}EN> = [];", TabName_Out4ListRegion4GC));
            sb.AppendLine("    try {");
            sb.AppendLine(string.Format("      this.recCount = await {0}_GetRecCountByCondCache(obj{0}Cond);", TabName_Out4ListRegion4GC));
            sb.AppendLine("      if (this.recCount == 0) {");
            sb.AppendLine("        const strMsg = Format('在绑定GvCache过程中,根据条件:[{0}]获取的对象列表数为0!', obj" + TabName_Out4ListRegion4GC + "Cond.whereCond);");
            sb.AppendLine("        console.error(strMsg);");
            sb.AppendLine("        alert(strMsg);");
            sb.AppendLine("        return { arrObjLst: [], sheetName: '', fileName: '' };");
            sb.AppendLine("      }");
            sb.AppendLine(string.Format("      arr{0}ObjLst = await {0}_GetSubObjLstCache(obj{0}Cond);", TabName_Out4ListRegion4GC));
            sb.AppendLine("    } catch (e) {");
            sb.AppendLine("      const strMsg = `绑定GridView不成功,${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
            sb.AppendLine("      console.error(strMsg);");
            sb.AppendLine("      alert(strMsg);");
            sb.AppendLine("      return { arrObjLst: [], sheetName: '', fileName: '' };");
            sb.AppendLine("    }");
            sb.AppendLine();
            sb.AppendLine(string.Format("    if (arr{0}ObjLst.length == 0) {{", TabName_Out4ListRegion4GC));
            sb.AppendLine("      return { arrObjLst: [], sheetName: '', fileName: '' };");
            sb.AppendLine("    }");
            sb.AppendLine();
            sb.AppendLine("    try {");
            sb.AppendLine("      const arrDataColumn = this.getListColumnsAi();");
            sb.AppendLine(string.Format("      arr{0}ObjLst = arr{0}ObjLst.sort(this.SortFunExportExcel);", TabName_Out4ListRegion4GC));
            sb.AppendLine(string.Format("      return this.CombineData(arr{0}ObjLst, arrDataColumn);", TabName_Out4ListRegion4GC));
            sb.AppendLine("    } catch (e) {");
            sb.AppendLine("      const strMsg = `绑定${this.thisTabName}对象列表不成功, ${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
            sb.AppendLine("      console.error(strMsg);");
            sb.AppendLine("      alert(strMsg);");
            sb.AppendLine("      return { arrObjLst: [], sheetName: '', fileName: '' };");
            sb.AppendLine("    }");
            sb.AppendLine("  }");
            sb.AppendLine();

            // Ai2版本的导出方法
            sb.AppendLine("  /** 按导出列规格整理导出结果。 */");
            sb.AppendLine(string.Format("  public async ExportExcel_{0}CacheAi2(): Promise<ExportExcelData> {{", TabName_Out4ListRegion4GC));
            sb.AppendLine(string.Format("    const raw = await this.ExportExcel_{0}Cache();", TabName_Out4ListRegion4GC));
            sb.AppendLine("    if (raw.arrObjLst.length === 0) return raw;");
            sb.AppendLine("    const normalizedRows = this.NormalizeExportRowsBySpecs(");
            sb.AppendLine("      raw.arrObjLst as Array<Record<string, any>>,");
            sb.AppendLine("      this.getExportColumnSpecsAi(),");
            sb.AppendLine("    );");
            sb.AppendLine();
            sb.AppendLine("    return {");
            sb.AppendLine("      arrObjLst: normalizedRows,");
            sb.AppendLine("      sheetName: raw.sheetName,");
            sb.AppendLine("      fileName: raw.fileName,");
            sb.AppendLine("    };");
            sb.AppendLine("  }");
            sb.AppendLine();

            // 导出按钮入口
            sb.AppendLine("  /** 导出按钮入口。 */");
            sb.AppendLine("  public async btnExportExcel_Click() {");
            sb.AppendLine(string.Format("    await this.ExportExcel_{0}Cache();", TabName_Out4ListRegion4GC));
            sb.AppendLine("  }");
            sb.AppendLine();

            // CombineData方法
            sb.AppendLine("  /** 把实体列表组装成导出文件数据。 */");
            sb.AppendLine("  public CombineData(");
            sb.AppendLine(string.Format("    arr{0}ObjLst: Array<cls{0}EN>,", TabName_Out4ListRegion4GC));
            sb.AppendLine("    arrDataColumn: Array<clsDataColumn>,");
            sb.AppendLine("  ): ExportExcelData {");
            sb.AppendLine(string.Format("    const arrData = this.BuildExportRowsByColumns(arr{0}ObjLst, arrDataColumn, (obj, fld) =>", TabName_Out4ListRegion4GC));
            sb.AppendLine("      obj.GetFldValue(fld),");
            sb.AppendLine("    );");
            sb.AppendLine(string.Format("    const strFileName = Format('{0}({{0}})导出.xlsx', cls{1}EN._CurrTabName);", objPrjTabEx_ListRegion.TabCnName, TabName_Out4ListRegion4GC));
            sb.AppendLine(string.Format("    const strSheetName = '{0}列表';", objPrjTabEx_ListRegion.TabCnName));
            sb.AppendLine("    return { arrObjLst: arrData, sheetName: strSheetName, fileName: strFileName };");
            sb.AppendLine("  }");
            sb.AppendLine();

            return sb.ToString();
        }
        #endregion

        #region 生成数据绑定方法
        /// <summary>
        /// 生成数据绑定方法
        /// </summary>
        private string Gen_Ai4_BindTabMethods()
        {
            StringBuilder sb = new StringBuilder();

            // BindTab_XXX4Func方法
            sb.AppendLine("  /** 绑定表格内容并同步分页器。 */");
            sb.AppendLine(string.Format("  public async BindTab_{0}4Func(", TabName_Out4ListRegion4GC));
            sb.AppendLine("    divContainer: HTMLDivElement,");
            sb.AppendLine(string.Format("    arr{0}ExObjLst: Array<cls{0}ENEx>,", TabName_Out4ListRegion4GC));
            sb.AppendLine("  ) {");
            sb.AppendLine(string.Format("    const strThisFuncName = this.BindTab_{0}4Func.name;", TabName_Out4ListRegion4GC));
            sb.AppendLine("    if (divContainer == null) {");
            sb.AppendLine("      alert(Format('{0}不存在!', divContainer));");
            sb.AppendLine("      return;");
            sb.AppendLine("    }");
            sb.AppendLine();
            sb.AppendLine("    const arrDataColumn: Array<clsDataColumn> = this.getListColumnsAi();");
            sb.AppendLine();
            sb.AppendLine(string.Format("    if (ref{0}_List.value != null) {{", TabName_Out4ListRegion4GC));
            sb.AppendLine("      dataColumn.value = arrDataColumn;");
            sb.AppendLine("      try {");
            sb.AppendLine(string.Format("        await this.ExtendTdFldFuncMap(arr{0}ExObjLst);", TabName_Out4ListRegion4GC));
            sb.AppendLine("      } catch (e) {");
            sb.AppendLine("        const strMsg = `扩展Td字段值的映射出错,${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
            sb.AppendLine("        console.error(strMsg);");
            sb.AppendLine("        alert(strMsg);");
            sb.AppendLine("        return;");
            sb.AppendLine("      }");
            sb.AppendLine(string.Format("      await BindTabByList(arr{0}ExObjLst, this.dispAllErrMsg_q);", TabName_Out4ListRegion4GC));
            sb.AppendLine("    } else {");
            sb.AppendLine("      try {");
            sb.AppendLine(string.Format("        await this.ExtendFldFuncMap(arr{0}ExObjLst, arrDataColumn);", TabName_Out4ListRegion4GC));
            sb.AppendLine("      } catch (e) {");
            sb.AppendLine("        const strMsg = `扩展字段值的映射出错,${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
            sb.AppendLine("        console.error(strMsg);");
            sb.AppendLine("        alert(strMsg);");
            sb.AppendLine("        return;");
            sb.AppendLine("      }");
            sb.AppendLine("      const divDataLst = GetDivObjInDivObj(divContainer, 'divDataLst');");
            sb.AppendLine("      if (divDataLst == null) {");
            sb.AppendLine(string.Format("        alert('在BindTab_{0}4Func函数中，divDataLst不存在!');", TabName_Out4ListRegion4GC));
            sb.AppendLine("        return;");
            sb.AppendLine("      }");
            sb.AppendLine("      await BindTab(");
            sb.AppendLine("        divDataLst,");
            sb.AppendLine(string.Format("        arr{0}ExObjLst,", TabName_Out4ListRegion4GC));
            sb.AppendLine("        arrDataColumn,");
            sb.AppendLine(string.Format("        cls{0}EN.con_{1},", TabName_Out4ListRegion4GC, objKeyField.FldName));
            sb.AppendLine("        this,");
            sb.AppendLine("      );");
            sb.AppendLine("    }");
            sb.AppendLine();
            sb.AppendLine("    if (this.objPager.IsInit(divContainer, this.divName4Pager) == false)");
            sb.AppendLine("      this.objPager.InitShow(divContainer, this.divName4Pager);");
            sb.AppendLine("    this.objPager.recCount = this.recCount;");
            sb.AppendLine("    this.objPager.pageSize = this.pageSize;");
            sb.AppendLine("    this.objPager.ShowPagerV2(divContainer, this, this.divName4Pager);");
            sb.AppendLine("  }");
            sb.AppendLine();

            // BindGv_XXX4Func方法
            sb.AppendLine("  /** 按当前条件获取并绑定分页列表。 */");
            sb.AppendLine(string.Format("  public async BindGv_{0}4Func(divList: HTMLDivElement) {{", TabName_Out4ListRegion4GC));
            sb.AppendLine(string.Format("    const strThisFuncName = this.BindGv_{0}4Func.name;", TabName_Out4ListRegion4GC));
            sb.AppendLine(string.Format("    if (viewVarSet.sort{0}By == null) {{", TabName_Out4ListRegion4GC));
            sb.AppendLine("      const strMsg = Format('在显示列表时,排序字段(sort" + TabName_Out4ListRegion4GC + "By)为空,请检查!(In BindGv_" + TabName_Out4ListRegion4GC + "Cache)');");
            sb.AppendLine("      console.error(strMsg);");
            sb.AppendLine("      alert(strMsg);");
            sb.AppendLine("      return;");
            sb.AppendLine("    }");
            sb.AppendLine();
            sb.AppendLine(string.Format("    const obj{0}Cond = await Combine{0}ConditionObj();", TabName_Out4ListRegion4GC));
            sb.AppendLine(string.Format("    const strWhereCond = JSON.stringify(obj{0}Cond);", TabName_Out4ListRegion4GC));
            sb.AppendLine("    const intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);");
            sb.AppendLine(string.Format("    let arr{0}ExObjLst: Array<cls{0}ENEx> = [];", TabName_Out4ListRegion4GC));
            sb.AppendLine();
            sb.AppendLine("    try {");
            sb.AppendLine(string.Format("      this.recCount = await {0}_GetRecCountByCondCache(obj{0}Cond);", TabName_Out4ListRegion4GC));
            sb.AppendLine("      if (this.recCount == 0) {");
            sb.AppendLine("        const strMsg = Format('在绑定GvCache过程中,根据条件:[{0}]获取的对象列表数为0!', obj" + TabName_Out4ListRegion4GC + "Cond.whereCond);");
            sb.AppendLine("        console.error(strMsg);");
            sb.AppendLine("        alert(strMsg);");
            sb.AppendLine(string.Format("        BindTabByList(arr{0}ExObjLst, true);", TabName_Out4ListRegion4GC));
            sb.AppendLine("        return;");
            sb.AppendLine("      }");
            sb.AppendLine();
            sb.AppendLine("      let strSortFun = (x: any, y: any) => {");
            sb.AppendLine("        console.log(x, y);");
            sb.AppendLine("        return 0;");
            sb.AppendLine("      };");
            sb.AppendLine(string.Format("      const currentCtor = this.constructor as typeof {0};", ThisClsName + "Ai4"));
            sb.AppendLine("      if (currentCtor.sortFunStatic != undefined) {");
            sb.AppendLine("        strSortFun = currentCtor.sortFunStatic(viewVarSet.ascOrDesc4SortFun);");
            sb.AppendLine("      }");
            sb.AppendLine("      const objPagerPara: stuPagerPara = {");
            sb.AppendLine("        pageIndex: intCurrPageIndex,");
            sb.AppendLine("        pageSize: this.pageSize,");
            sb.AppendLine("        whereCond: strWhereCond,");
            sb.AppendLine(string.Format("        conditionCollection: obj{0}Cond,", TabName_Out4ListRegion4GC));
            sb.AppendLine(string.Format("        orderBy: viewVarSet.sort{0}By,", TabName_Out4ListRegion4GC));
            sb.AppendLine("        sortFun: strSortFun,");
            sb.AppendLine("      };");
            sb.AppendLine(string.Format("      arr{0}ExObjLst = await {0}_GetObjExLstByPagerCache(objPagerPara);", TabName_Out4ListRegion4GC));
            sb.AppendLine("    } catch (e) {");
            sb.AppendLine("      const strMsg = `绑定GridView不成功,${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
            sb.AppendLine("      console.error(strMsg);");
            sb.AppendLine("      alert(strMsg);");
            sb.AppendLine("      return;");
            sb.AppendLine("    }");
            sb.AppendLine();
            sb.AppendLine(string.Format("    if (arr{0}ExObjLst.length == 0) {{", TabName_Out4ListRegion4GC));
            sb.AppendLine("      this.objPager.Hide(divList, this.divName4Pager);");
            sb.AppendLine("      return;");
            sb.AppendLine("    }");
            sb.AppendLine();
            sb.AppendLine("    try {");
            sb.AppendLine(string.Format("      await this.BindTab_{0}4Func(divList, arr{0}ExObjLst);", TabName_Out4ListRegion4GC));
            sb.AppendLine("    } catch (e) {");
            sb.AppendLine("      const strMsg = `绑定${this.thisTabName}对象列表不成功, ${e}.(in ${this.constructor.name}.${strThisFuncName})`;");
            sb.AppendLine("      console.error(strMsg);");
            sb.AppendLine("      alert(strMsg);");
            sb.AppendLine("    }");
            sb.AppendLine("  }");
            sb.AppendLine();

            return sb.ToString();
        }
        #endregion

        #region 生成分页方法
        /// <summary>
        /// 生成分页方法
        /// </summary>
        private string Gen_Ai4_PagingMethods()
        {
            StringBuilder sb = new StringBuilder();

            // SortBy方法
            sb.AppendLine("  /** 列表排序入口。 */");
            sb.AppendLine("  public async SortBy(objAnchorElement: any) {");
            sb.AppendLine("    await this.SortByTemplate({");
            sb.AppendLine("      objAnchorElement,");
            sb.AppendLine("      currAscOrDesc: viewVarSet.ascOrDesc4SortFun,");
            sb.AppendLine(string.Format("      currSortBy: viewVarSet.sort{0}By,", TabName_Out4ListRegion4GC));
            sb.AppendLine("      onEntitySort: async (sortColumnKey: string, sortDirection: string) => {");
            sb.AppendLine(string.Format("        if (Object.prototype.hasOwnProperty.call(cls{0}ENEx, sortColumnKey) == false) {{", TabName_Out4ListRegion4GC));
            sb.AppendLine("          return false;");
            sb.AppendLine("        }");
            sb.AppendLine("        this.SortColumn(sortColumnKey, sortDirection);");
            sb.AppendLine("        return true;");
            sb.AppendLine("      },");
            sb.AppendLine("      onApplySortState: (sortBy, ascOrDesc4SortFun, sortFun) => {");
            sb.AppendLine(string.Format("        viewVarSet.sort{0}By = sortBy;", TabName_Out4ListRegion4GC));
            sb.AppendLine("        viewVarSet.ascOrDesc4SortFun = ascOrDesc4SortFun;");
            sb.AppendLine(string.Format("        const currentCtor = this.constructor as typeof {0};", ThisClsName + "Ai4"));
            sb.AppendLine("        currentCtor.sortFunStatic = sortFun;");
            sb.AppendLine("      },");
            sb.AppendLine("      onRefresh: async () => {");
            sb.AppendLine(string.Format("        await this.BindGv_{0}4Func(this.listPara.listDiv);", TabName_Out4ListRegion4GC));
            sb.AppendLine("      },");
            sb.AppendLine("    });");
            sb.AppendLine("  }");
            sb.AppendLine();

            // IndexPage方法
            sb.AppendLine("  /** 跳转到指定页。 */");
            sb.AppendLine("  public async IndexPage(intPageIndex: number) {");
            sb.AppendLine("    await this.IndexPageTemplate(intPageIndex, async () => {");
            sb.AppendLine(string.Format("      await this.BindGv_{0}4Func(this.listPara.listDiv);", TabName_Out4ListRegion4GC));
            sb.AppendLine("    });");
            sb.AppendLine("  }");
            sb.AppendLine();

            // NextPage方法
            sb.AppendLine("  /** 加载下一页。 */");
            sb.AppendLine("  public async NextPage() {");
            sb.AppendLine("    await this.NextPageTemplate(async () => {");
            sb.AppendLine(string.Format("      await this.BindGv_{0}4Func(this.listPara.listDiv);", TabName_Out4ListRegion4GC));
            sb.AppendLine("    });");
            sb.AppendLine("  }");
            sb.AppendLine();

            // PrevPage方法
            sb.AppendLine("  /** 加载上一页。 */");
            sb.AppendLine("  public async PrevPage() {");
            sb.AppendLine("    await this.PrevPageTemplate(async () => {");
            sb.AppendLine(string.Format("      await this.BindGv_{0}4Func(this.listPara.listDiv);", TabName_Out4ListRegion4GC));
            sb.AppendLine("    });");
            sb.AppendLine("  }");
            sb.AppendLine();

            return sb.ToString();
        }
        #endregion

        #region 生成辅助方法
        /// <summary>
        /// 生成辅助方法
        /// </summary>
        private string Gen_Ai4_HelperMethods()
        {
            StringBuilder sb = new StringBuilder();

            // ExtendFldFuncMap方法
            sb.AppendLine("  /** 为非实体原生字段补充显示映射。 */");
            sb.AppendLine("  public async ExtendFldFuncMap(");
            sb.AppendLine(string.Format("    arr{0}ExObjLst: Array<cls{0}ENEx>,", TabName_Out4ListRegion4GC));
            sb.AppendLine("    arrDataColumn: Array<clsDataColumn>,");
            sb.AppendLine("  ) {");
            sb.AppendLine(string.Format("    const arrFldName = cls{0}EN._AttributeName;", TabName_Out4ListRegion4GC));
            sb.AppendLine("    for (const objDataColumn of arrDataColumn) {");
            sb.AppendLine("      if (IsNullOrEmpty(objDataColumn.fldName) == true) continue;");
            sb.AppendLine("      if (arrFldName.indexOf(objDataColumn.fldName) > -1) continue;");
            sb.AppendLine(string.Format("      for (const objInFor of arr{0}ExObjLst) {{", TabName_Out4ListRegion4GC));
            sb.AppendLine(string.Format("        await {0}_FuncMapByFldName(objDataColumn.fldName, objInFor);", TabName_Out4ListRegion4GC));
            sb.AppendLine("      }");
            sb.AppendLine("    }");
            sb.AppendLine("  }");
            sb.AppendLine();

            // ExtendTdFldFuncMap方法
            sb.AppendLine("  /** 为表格Td字段补充显示映射。 */");
            sb.AppendLine(string.Format("  public async ExtendTdFldFuncMap(arr{0}ExObjLst: Array<cls{0}ENEx>) {{", TabName_Out4ListRegion4GC));
            sb.AppendLine(string.Format("    const arrFldName = cls{0}EN._AttributeName;", TabName_Out4ListRegion4GC));
            sb.AppendLine("    const tdFieldNames = this.ResolveTdFieldNames(");
            sb.AppendLine(string.Format("      ref{0}_List.value?.tdFieldNames,", TabName_Out4ListRegion4GC));
            sb.AppendLine("      dataColumn.value,");
            sb.AppendLine("      IsNullOrEmpty,");
            sb.AppendLine("    );");
            sb.AppendLine();
            sb.AppendLine("    if (tdFieldNames.length === 0) return;");
            sb.AppendLine();
            sb.AppendLine("    for (const normalizedFldName of tdFieldNames) {");
            sb.AppendLine("      if (arrFldName.indexOf(normalizedFldName) > -1) continue;");
            sb.AppendLine();
            sb.AppendLine(string.Format("      for (const objInFor of arr{0}ExObjLst) {{", TabName_Out4ListRegion4GC));
            sb.AppendLine(string.Format("        await {0}_FuncMapByFldName(normalizedFldName, objInFor);", TabName_Out4ListRegion4GC));
            sb.AppendLine("      }");
            sb.AppendLine("    }");
            sb.AppendLine("  }");
            sb.AppendLine();

            // SortFunExportExcel方法
            sb.AppendLine("  /** 导出时使用的默认排序规则。 */");
            sb.AppendLine(string.Format("  public SortFunExportExcel(a: cls{0}EN, b: cls{0}EN): number {{", TabName_Out4ListRegion4GC));
            sb.AppendLine("    // TODO: 根据实际需求定义排序规则");
            sb.AppendLine("    return 0;");
            sb.AppendLine("  }");
            sb.AppendLine();

            // BindInDiv方法
            sb.AppendLine("  /** 预留的容器绑定扩展点。 */");
            sb.AppendLine("  public async BindInDiv(divBind: HTMLDivElement) {");
            sb.AppendLine("    console.log(divBind);");
            sb.AppendLine("  }");
            sb.AppendLine();

            return sb.ToString();
        }
        #endregion
    }
}