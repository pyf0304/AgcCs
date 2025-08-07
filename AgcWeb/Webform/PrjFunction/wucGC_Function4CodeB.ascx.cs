
/*-- -- -- -- -- -- -- -- -- -- --
类名:wucFunction4CodeB
表名:Function4Code
生成代码版本:2018.03.01.1
生成日期:2018/03/03 01:50:51
生成者:
工程名称:AGC
工程ID:0005
模块中文名:项目函数管理
模块英文名:PrjFunction
框架-层名:Web界面层
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.11.28.01
     2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
//生成与表相关的控件控制层代码
namespace AGC.Webform
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Web.UI.WebControls;
    using AGC.BusinessLogic;
    using AGC.Entity;
    using AGC.FunClass;
    using BusinessLogicEx;
    using CommFunc4WebForm;

    /// <summary>
    ///		wucFunction4CodeB 的摘要说明。
    /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
    /// </summary>
    public partial class wucGC_Function4CodeB : System.Web.UI.UserControl
    {
        /// <summary>
        /// 函数功能:页面导入,当页面开始运行时所发生的事件
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面
            FuncId4Code = vsFuncId4Code;
        }
       

        /// <summary>
        /// 清除用户自定义控件中，所有控件的值
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>	
        public void Clear()
        {
  
        }
        /// <summary>
        /// 校验自定义控件中自子控件的类型数值是否是合法正确的。
        /// 一般规则:
        ///		1、首先校验类型:整型、浮点型、日期型等,
        ///			这些代码由自动生成代码帮助生成
        ///		2、校验最值,即最大值和最小值等
        ///			这些代码由自动生成代码帮助生成
        ///		这些生成内容可以修改
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        /// <returns></returns>
        public bool IsValid(ref string strResult)
        {
          
            return true;
        }
        /// <summary>
        /// 设置该控件在插入状态下的缺省值
        /// 一般规则:
        ///		1、如果是整型就默认为0；
        ///		2、如果是浮点型不默认为0.0；
        ///		3、如果是日期型就默认为当前的日期；
        ///		4、如果是位(bit)型就默认为false;
        ///		这些默认值可以再行修改
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public void SetDefaultValue()
        {
       
        }
    
    

        protected void btnGeneCode_Click(object sender, EventArgs e)
        {
            Button objButton = (Button)sender;
            string strCodeTypeId = objButton.ToolTip.Split('-')[0];
            string strFuncId4Code = objButton.ToolTip.Split('-')[1];
            if (string.IsNullOrEmpty(strCodeTypeId) == true) return;
            //string strFuncId4Code = vsFuncId4Code;
            try
            {
                string strCode = "";
                if (objButton.ID == btnGeneCode0.ID)
                {
                    strCode = clsFunction4CodeBLEx.GeneCode4Class(strFuncId4Code, strCodeTypeId, clsPubVar.CurrSelPrjId);
                }
                else
                {
                    strCode = clsFunction4CodeBLEx.GeneCodeV2(clsPubVar.CurrWorkFlowId, strFuncId4Code, strCodeTypeId);
                }
                hidCode.Value = strCode;
                this.FuncId4CodeV2 = vsFuncId4Code;
            }
            catch(Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }
            string strHtml = string.Format("ShowCode('{0}')", hidCode.ClientID);
            this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "ShowCode", strHtml, true);
//            txtCode.Text = strCode;

          
        }
        public string FuncId4CodeV2
        {
            set
            {
                if (string.IsNullOrEmpty(value) == true) return;
                vsFuncId4Code = value;
                clsFunction4CodeEN objFunction4Code = clsFunction4CodeBL.GetObjByFuncId4CodeCache(vsFuncId4Code);
                if (objFunction4Code == null) return;
                if (string.IsNullOrEmpty(objFunction4Code.CodeTypeId) == true) return;
                if (string.IsNullOrEmpty(clsPubVar.CurrWorkFlowId) == true)
                {
                    clsCommonJsFunc.Alert(this, "当前没有设置默认的工作流Id,请去相关界面设置！");
                    return;
                }
                if (string.IsNullOrEmpty(objFunction4Code.FuncAccessModeId) == true)
                {
                    clsCommonJsFunc.Alert(this, "当前函数的访问方式为空，不能生成代码！");
                    return;
                }
                string strCondition = string.Format("{0}='{1}'", conFunction4Code.RootFuncId, objFunction4Code.RootFuncId);
                //List<clsFunction4CodeEN> arrFunction4Code = clsFunction4CodeBL.GetObjLst(strCondition);
                clsvwf_StepPointRelaEN objvwf_StepPointRelaEN = clsvwf_StepPointRelaBLEx.GetObjByWorkFlowIdAndTabKeyIdCache(clsPubVar.CurrWorkFlowId, objFunction4Code.CodeTypeId);
                IEnumerable<clswf_StepPointRelaEN> arrwf_StepPointRela = clswf_StepPointRelaBLEx.GetObjLstByWorkFlowIdCache(clsPubVar.CurrWorkFlowId).OrderBy(x => x.LevelNo); ;
                btnGeneCode0.Visible = false;
                btnGeneCode1.Visible = false;
                btnGeneCode2.Visible = false;
                btnGeneCode3.Visible = false;
                lblGC0.Visible = false;
                lblGC1.Visible = false;
                lblGC2.Visible = false;
                lblGC3.Visible = false;

                int i = 0;
                foreach (clswf_StepPointRelaEN objInFor in arrwf_StepPointRela)
                {
                    //Label lblFuncMsg = new Label();
                    if (objInFor.PointTypeId != enumwf_PointType.DataPoint_03) continue;
                    clswf_PointEN objwf_Point = clswf_PointBLEx.GetObjByPointIdCache(objInFor.PointId);

                    clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(objwf_Point.TabKeyId);
                    clsProgLangTypeEN objProgLangType = clsProgLangTypeBL.GetObjByProgLangTypeIdCache(objCodeType.ProgLangTypeId);
                    //clsFunction4CodeEN objFunction4Code_Sel = arrFunction4Code.Find(x => x.CodeTypeId == objCodeType.CodeTypeId);
                    //if (objFunction4Code_Sel == null) continue;
                    if (i == 0)
                    {
                        btnGeneCode0.Visible = true;
                        btnGeneCode0.Text = string.Format("生成类中所有函数-{0}({1})", objFunction4Code.ClsName, objProgLangType.ProgLangTypeSimName);
                        btnGeneCode0.ToolTip = string.Format("{0}-{1}", objFunction4Code.CodeTypeId, objFunction4Code.ClsName);
                        lblGC0.Text = string.Format("类名:{0}, 代码类型:{1}({2})",
                            objFunction4Code.ClsName,
                            objCodeType.CodeTypeName, clsProgLangTypeBL.GetNameByProgLangTypeIdCache(objCodeType.ProgLangTypeId));
                        lblGC0.Visible = true;


                    }
                    else if (i == 1)
                    {
                        btnGeneCode1.Visible = true;
                        btnGeneCode1.Text = string.Format("生成-{0}({1})", objCodeType.CodeTypeName, objProgLangType.ProgLangTypeSimName);
                        btnGeneCode1.ToolTip = string.Format("{0}-{1}", objCodeType.CodeTypeId, objFunction4Code.FuncId4Code);
                        lblGC1.Text = string.Format("函数:{0}({1})",
    objFunction4Code.FuncName4Code, objFunction4Code.FuncCHName4Code,
    objCodeType.CodeTypeName, clsProgLangTypeBL.GetNameByProgLangTypeIdCache(objCodeType.ProgLangTypeId));
                        lblGC1.Visible = true;

                    }
                    else if (i == 2)
                    {
                        btnGeneCode2.Visible = true;
                        btnGeneCode2.Text = string.Format("生成-{0}({1})", objCodeType.CodeTypeName, objProgLangType.ProgLangTypeSimName);
                        btnGeneCode2.ToolTip = string.Format("{0}-{1}", objCodeType.CodeTypeId, objFunction4Code.FuncId4Code);
                        lblGC2.Text = string.Format("函数:{0}({1})",
    objFunction4Code.FuncName4Code, objFunction4Code.FuncCHName4Code,
    objCodeType.CodeTypeName, clsProgLangTypeBL.GetNameByProgLangTypeIdCache(objCodeType.ProgLangTypeId));
                        lblGC2.Visible = true;

                    }
                    else if (i == 3)
                    {
                        btnGeneCode3.Visible = true;
                        btnGeneCode3.Text = string.Format("生成-{0}({1})", objCodeType.CodeTypeName, objProgLangType.ProgLangTypeSimName);
                        btnGeneCode3.ToolTip = string.Format("{0}-{1}", objCodeType.CodeTypeId, objFunction4Code.FuncId4Code);
                        lblGC3.Text = string.Format("函数:{0}({1})",
    objFunction4Code.FuncName4Code, objFunction4Code.FuncCHName4Code,
    objCodeType.CodeTypeName, clsProgLangTypeBL.GetNameByProgLangTypeIdCache(objCodeType.ProgLangTypeId));
                        lblGC3.Visible = true;

                    }
                    i++;
                }

            }
        }

        public string FuncId4Code
        {
            set
            {
                if (string.IsNullOrEmpty(value) == true) return;
                vsFuncId4Code = value;
                clsFunction4CodeEN objFunction4Code = clsFunction4CodeBL.GetObjByFuncId4CodeCache(vsFuncId4Code);
                if (objFunction4Code == null) return;
                if (string.IsNullOrEmpty(objFunction4Code.CodeTypeId) == true) return;
                if (string.IsNullOrEmpty(clsPubVar.CurrWorkFlowId) == true)
                {
                    clsCommonJsFunc.Alert(this, "当前没有设置默认的工作流Id,请去相关界面设置！");
                    return;
                }
                string strCondition = string.Format("{0}='{1}'", conFunction4Code.RootFuncId, objFunction4Code.RootFuncId);
                List<clsFunction4CodeEN> arrFunction4Code = clsFunction4CodeBL.GetObjLst(strCondition);
                clsvwf_StepPointRelaEN objvwf_StepPointRelaEN = clsvwf_StepPointRelaBLEx.GetObjByWorkFlowIdAndTabKeyIdCache(clsPubVar.CurrWorkFlowId, objFunction4Code.CodeTypeId);
                IEnumerable<clswf_StepPointRelaEN> arrwf_StepPointRela = clswf_StepPointRelaBLEx.GetObjLstByWorkFlowIdCache(clsPubVar.CurrWorkFlowId).OrderBy(x => x.LevelNo); ;
                btnGeneCode0.Visible = false;
                btnGeneCode1.Visible = false;
                btnGeneCode2.Visible = false;
                btnGeneCode3.Visible = false;
                lblGC0.Visible = false;
                lblGC1.Visible = false;
                lblGC2.Visible = false;
                lblGC3.Visible = false;

                int i = 0;
                foreach (clswf_StepPointRelaEN objInFor in arrwf_StepPointRela)
                {
                    //Label lblFuncMsg = new Label();
                    if (objInFor.PointTypeId != enumwf_PointType.DataPoint_03) continue;
                        clswf_PointEN objwf_Point = clswf_PointBLEx.GetObjByPointIdCache(objInFor.PointId);
                    
                    clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(objwf_Point.TabKeyId);
                    clsProgLangTypeEN objProgLangType = clsProgLangTypeBL.GetObjByProgLangTypeIdCache(objCodeType.ProgLangTypeId);
                    clsFunction4CodeEN objFunction4Code_Sel = arrFunction4Code.Find(x=>x.CodeTypeId == objCodeType.CodeTypeId);
                    if (objFunction4Code_Sel == null) continue;
                    if (i == 0)
                    {
                        btnGeneCode0.Visible = true;
                        btnGeneCode0.Text = string.Format("生成类中所有函数-{0}({1})", objFunction4Code.ClsName, objProgLangType.ProgLangTypeSimName);
                        btnGeneCode0.ToolTip = string.Format("{0}-{1}", objFunction4Code.CodeTypeId, objFunction4Code.ClsName);
                        lblGC0.Text = string.Format("类名:{0}, 代码类型:{1}({2})",
                            objFunction4Code.ClsName, 
                            objCodeType.CodeTypeName, clsProgLangTypeBL.GetNameByProgLangTypeIdCache(objCodeType.ProgLangTypeId));
                        lblGC0.Visible = true;


                    }
                    else if (i == 1)
                    {
                        btnGeneCode1.Visible = true;
                        btnGeneCode1.Text = string.Format("生成-{0}({1})", objCodeType.CodeTypeName, objProgLangType.ProgLangTypeSimName);
                        btnGeneCode1.ToolTip = string.Format("{0}-{1}", objCodeType.CodeTypeId, objFunction4Code_Sel.FuncId4Code);
                        lblGC1.Text = string.Format("函数:{0}({1})",
    objFunction4Code_Sel.FuncName4Code, objFunction4Code_Sel.FuncCHName4Code,
    objCodeType.CodeTypeName, clsProgLangTypeBL.GetNameByProgLangTypeIdCache(objCodeType.ProgLangTypeId));
                        lblGC1.Visible = true;

                    }
                    else if (i == 2)
                    {
                        btnGeneCode2.Visible = true;
                        btnGeneCode2.Text = string.Format("生成-{0}({1})", objCodeType.CodeTypeName, objProgLangType.ProgLangTypeSimName);
                        btnGeneCode2.ToolTip = string.Format("{0}-{1}", objCodeType.CodeTypeId, objFunction4Code_Sel.FuncId4Code);
                        lblGC2.Text = string.Format("函数:{0}({1})",
    objFunction4Code_Sel.FuncName4Code, objFunction4Code_Sel.FuncCHName4Code,
    objCodeType.CodeTypeName, clsProgLangTypeBL.GetNameByProgLangTypeIdCache(objCodeType.ProgLangTypeId));
                        lblGC2.Visible = true;

                    }
                    else if (i == 3)
                    {
                        btnGeneCode3.Visible = true;
                        btnGeneCode3.Text = string.Format("生成-{0}({1})", objCodeType.CodeTypeName, objProgLangType.ProgLangTypeSimName);
                        btnGeneCode3.ToolTip = string.Format("{0}-{1}", objCodeType.CodeTypeId, objFunction4Code_Sel.FuncId4Code);
                        lblGC3.Text = string.Format("函数:{0}({1})",
    objFunction4Code_Sel.FuncName4Code, objFunction4Code_Sel.FuncCHName4Code,
    objCodeType.CodeTypeName, clsProgLangTypeBL.GetNameByProgLangTypeIdCache(objCodeType.ProgLangTypeId));
                        lblGC3.Visible = true;

                    }
                    i++;
                }

            }
        }
        /// <summary>
        /// ViewState属性:当前操作的界面功能名称
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPotenceRelaVar)
        /// </summary>
        protected string vsFuncId4Code
        {
            get
            {
                string sFuncId4Code;
                sFuncId4Code = (string)ViewState["FuncId4Code"];
                if (sFuncId4Code == null)
                {
                    sFuncId4Code = "";
                }
                return sFuncId4Code;
            }
            set
            {
                string sFuncId4Code = value;
                ViewState.Add("FuncId4Code", sFuncId4Code);
            }
        }
    }
}