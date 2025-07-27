using System;
using System.Text;
using System.Data;
using System.Collections;
using System.IO;
using com.taishsoft.commexception;
using com.taishsoft.file;
using com.taishsoft.common;using com.taishsoft.comm_db_obj;


using AGC.Entity;

using com.taishsoft.datetime;
using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using System.Collections.Generic;
using System.Reflection;
using AGC.PureClass;
using AGC.PureClassEx;
using System.Linq;

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
    partial class WA_ViewUTScript4Html : clsGeneCodeBase4Tab
    {
        private clsPrjTabENEx objPrjTabENEx = null;
        public WA_ViewUTScript4Html()
        {


            // 
            // TODO: 在此处添加构造函数逻辑
            //
        }
        public WA_ViewUTScript4Html( string strViewId, string strPrjDataBaseId, string strPrjId)
          : base( strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
        }

        /// <summary>
        /// 生成指定的函数
        /// </summary>
        /// <returns>返回生成的指定函数代码</returns>
        public string A_GenCode4Function_CS_DefButton(string strFuncId4GC)
        {
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp; //临时变量;
            string strFuncName = "";
            try
            {
                //类名开始
                // clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
                string strCondition = string.Format("{0}='{1}'", convFunction4GeneCode.FuncId4GC, strFuncId4GC);
                clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBL.GetFirstObj_S(strCondition);

                //strFuncName = objFunction4GeneCodeEN.FuncName;

                //if (objFunction4GeneCodeEN.FuncTypeId == "10")//用户自定义函数
                //{
                //    strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId(objFunction4GeneCodeEN.FuncId4GC,
                //        objPrjTabENEx.TabId, objPrjTabENEx.PrjDataBaseId, objPrjTabENEx.PrjId);
                //}
                //else
                //{
                //    strTemp = A_GeneFuncCode_Ts_btnClick(strFuncName);
                //}
                strTemp = A_GeneFuncCode_CS_DefButton(objvFunction4GeneCodeEN);
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

        public string A_GeneFuncCode_CS_DefButton(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            try
            {
                switch (objvFunction4GeneCodeEN.FuncName)
                {
                           
                    default:
                        string strMsg = string.Format("功能名:{1}在Switch没有处理,请检查({0})",
                             clsStackTrace.GetCurrClassFunction(), objvFunction4GeneCodeEN.FuncName);
                        throw new Exception(strMsg);
                        //            return "///该1函数不存在:" + strFuncName;
                }
            }
            catch (Exception objException)
            {
                StringBuilder sbMessage = new StringBuilder();
                sbMessage.AppendFormat("在生成函数:{0}时出错. \r\n出错信息:{1}.", objvFunction4GeneCodeEN.FuncName, objException.Message);
                throw new Exception(sbMessage.ToString());
            }
        }


        public ASPLabelEx GetOrderNumLabel(int intOrderNum)
        {


            ASPLabelEx objASPNETLabelENEx = new ASPLabelEx();
            objASPNETLabelENEx.CtrlId = string.Format("lblOrderNum{0}", intOrderNum);
            objASPNETLabelENEx.Text = string.Format("第{0}个函数：", intOrderNum);
            objASPNETLabelENEx.Width = 80;
            objASPNETLabelENEx.Height = 24;

            return objASPNETLabelENEx;
        }
        public ASPDivEx GetParaInputCtrlGroup(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            ASPDivEx objASPNETDivENEx = new ASPDivEx();
            objASPNETDivENEx.CtrlId = string.Format("divParaGroup{0}", objvFunction4GeneCodeEN.OrderNum);
            objASPNETDivENEx.Style = string.Format("width: 100%; float: left");
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);
            GC_GetInputValueCtrl4Para(objFunction4GeneCodeEN.FuncId4Code, objvFunction4GeneCodeEN.OrderNum, objASPNETDivENEx);


            return objASPNETDivENEx;


        }

        private void GC_GetInputValueCtrl4Para(string strFuncId4Code, int intOrderNum, ASPDivEx objASPNETDivENEx)
        {
            string strMsg = "";
            //            StringBuilder strCodeForCs = new StringBuilder();
            List<clsFuncPara4CodeEN> arrFuncPara4CodeObjLst =
  clsFuncPara4CodeBLEx.GetObjListByFuncId4CodeCacheEx(strFuncId4Code, enumFunctionPurpose.GeneCode_01);
            if (arrFuncPara4CodeObjLst == null) return;
            foreach (clsFuncPara4CodeEN objFuncPara4CodeEN in arrFuncPara4CodeObjLst)
            {
                clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objFuncPara4CodeEN.DataTypeId);
                clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;
                if (objDataTypeAbbrEN == null)
                {
                    objSelfDefDataTypeEN_Para = clsSelfDefDataTypeBLEx.getSelfDefDataTypeByDataTypeName(objFuncPara4CodeEN.ParameterType);
                    if (objSelfDefDataTypeEN_Para == null)
                    {
                        strMsg = string.Format("函数参数的数据类型：[{0}({1})]没有处理,不能生成相应代码。", objDataTypeAbbrEN.DataTypeId,
                            objFuncPara4CodeEN.ParameterType);
                        throw new Exception(strMsg);
                    }
                }
                if (objFuncPara4CodeEN.IsByRef == true)
                {
                    strMsg = string.Format("Java函数参数的不接受引用型参数。参数名：[{0}],数据类型：[{1}]没有处理,不能生成相应代码。",
                       objFuncPara4CodeEN.ParaName,
                         objFuncPara4CodeEN.ParameterType);
                    throw new Exception(strMsg);
                }
                ASPDivEx objASPNETDivENEx_Para = new ASPDivEx();
                objASPNETDivENEx_Para.CtrlId = string.Format("divPara{0}{1}", objFuncPara4CodeEN.ParaName, intOrderNum);
                objASPNETDivENEx_Para.Style = string.Format("width: 100%; float: left");

                ASPLabelEx objASPNETLabelENEx = new ASPLabelEx();
                //objASPNETLabelENEx.Is4PureHtml = true;
                objASPNETLabelENEx.CtrlId = string.Format("lblPara{0}{1}", objFuncPara4CodeEN.ParaName, intOrderNum);
                objASPNETLabelENEx.Text = objFuncPara4CodeEN.ParaName;
                objASPNETLabelENEx.Width = 200;
                objASPNETLabelENEx.Height = 24;

                objASPNETDivENEx_Para.arrSubAspControlLst2.Add(objASPNETLabelENEx);

                if (objDataTypeAbbrEN.IsNeedQuote == true)
                {
                    ASPTextBoxEx objASPNETTextBoxENEx = new ASPTextBoxEx();
                    //objASPNETTextBoxENEx.Is4PureHtml = true;
                    objASPNETTextBoxENEx.CtrlId = string.Format("txt{0}{1}", objFuncPara4CodeEN.ParaName, intOrderNum);
                    if (objFuncPara4CodeEN.ParaName.IndexOf("Where") > 0)
                    {
                        objASPNETTextBoxENEx.Text = string.Format("1=1", intOrderNum);
                        objASPNETTextBoxENEx.Value = string.Format("1=1", intOrderNum);

                    }
                    else if (objFuncPara4CodeEN.ParaName.IndexOf("OrderBy") > 0)
                    {
                        objASPNETTextBoxENEx.Text = string.Format("{0} Asc", objKeyField.FldName);
                        objASPNETTextBoxENEx.Value = string.Format("{0} Asc", objKeyField.FldName);

                    }

                    objASPNETTextBoxENEx.Width = 400;
                    objASPNETTextBoxENEx.Height = 24;
                    objASPNETDivENEx_Para.arrSubAspControlLst2.Add(objASPNETTextBoxENEx);

                    objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Para);
                }
                else
                {
                    ASPTextBoxEx objASPNETTextBoxENEx = new ASPTextBoxEx();
                    //objASPNETTextBoxENEx.Is4PureHtml = true;
                    objASPNETTextBoxENEx.CtrlId = string.Format("txt{0}{1}", objFuncPara4CodeEN.ParaName, intOrderNum);
                    if (objFuncPara4CodeEN.ParaName.IndexOf("pageSize") > 0)
                    {
                        objASPNETTextBoxENEx.Text = string.Format("5", intOrderNum);
                        objASPNETTextBoxENEx.Value = string.Format("5", intOrderNum);

                    }
                    else if (objFuncPara4CodeEN.ParaName.IndexOf("pageIndex") > 0)
                    {
                        objASPNETTextBoxENEx.Text = string.Format("1", intOrderNum);
                        objASPNETTextBoxENEx.Value = string.Format("1", intOrderNum);

                    }
                    else if (objFuncPara4CodeEN.ParaName.IndexOf("topSize") > 0)
                    {
                        objASPNETTextBoxENEx.Text = string.Format("3", intOrderNum);
                        objASPNETTextBoxENEx.Value = string.Format("3", intOrderNum);
                    }
                    else if (objFuncPara4CodeEN.ParaName.IndexOf("Min") > 0)
                    {
                        objASPNETTextBoxENEx.Text = string.Format("2", intOrderNum);
                        objASPNETTextBoxENEx.Value = string.Format("2", intOrderNum);
                    }
                    else if (objFuncPara4CodeEN.ParaName.IndexOf("Max") > 0)
                    {
                        objASPNETTextBoxENEx.Text = string.Format("5", intOrderNum);
                        objASPNETTextBoxENEx.Value = string.Format("5", intOrderNum);

                    }

                    objASPNETTextBoxENEx.Width = 400;
                    objASPNETTextBoxENEx.Height = 24;
                    objASPNETDivENEx_Para.arrSubAspControlLst2.Add(objASPNETTextBoxENEx);

                    objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Para);

                }
            }

        }

        public ASPDivEx GetFunctionGroupDiv(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4CodeEN objFunction4CodeEN = clsFunction4CodeBL.GetObjByFuncId4CodeCache(objvFunction4GeneCodeEN.FuncId4Code);// "UpdateRecord";
            string strFunctionName = objFunction4CodeEN.FuncName4Code;


            //string strFunctionName_CN = string.Format("{0}、检查是否存在记录", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = new ASPDivEx();
            objASPNETDivENEx.CtrlId = string.Format("div{0}", strFunctionName);
            objASPNETDivENEx.Style = string.Format("width: 100%; float: left; margin-bottom:5px;");
            objASPNETDivENEx.Class = "function";
            
            //添加水平线
            ASPHrEx objASPNETHrENEx = new ASPHrEx();
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETHrENEx);

            ASPDivEx objASPNETDivENEx_Title = GetDiv4FuncTitle(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Title);

            return objASPNETDivENEx;
        }

        private ASPDivEx GetFunctionResultDiv(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4CodeEN objFunction4CodeEN = clsFunction4CodeBL.GetObjByFuncId4CodeCache(objvFunction4GeneCodeEN.FuncId4Code);// "UpdateRecord";
            string strFunctionName = objFunction4CodeEN.FuncName4Code;

            string strFunctionName_CN = string.Format("{0}、{1}", objvFunction4GeneCodeEN.OrderNum, objFunction4CodeEN.FuncCHName4Code);

            ASPDivEx objASPNETDivENEx_Para = new ASPDivEx();
            objASPNETDivENEx_Para.CtrlId = string.Format("divResult{0}", objvFunction4GeneCodeEN.OrderNum);
            objASPNETDivENEx_Para.Style = string.Format("width: 100%; float: left");

            ASPButtonEx objASPNETButtonENEx = new ASPButtonEx();
            objASPNETButtonENEx.CtrlId = string.Format("btn{0}", strFunctionName);
            objASPNETButtonENEx.OnClick = string.Format("btn{0}_Click", strFunctionName); ;
            objASPNETButtonENEx.Text = strFunctionName_CN;
            objASPNETButtonENEx.Width = 300;
            objASPNETButtonENEx.Height = 24;
            objASPNETButtonENEx.mTextSize = "12sp";
            objASPNETButtonENEx.minHeight = "35dp";
         

            ASPLabelEx objASPNETLabelENEx2 = new ASPLabelEx();
            objASPNETLabelENEx2.CtrlId = string.Format("lblResult{0}", objvFunction4GeneCodeEN.OrderNum);
            objASPNETLabelENEx2.Text = "结果";
            objASPNETLabelENEx2.CssClass = "Content";
            objASPNETLabelENEx2.Width = 600;
            objASPNETLabelENEx2.Height = 24;

            objASPNETDivENEx_Para.arrSubAspControlLst2.Add(objASPNETButtonENEx);
            objASPNETDivENEx_Para.arrSubAspControlLst2.Add(objASPNETLabelENEx2);
            return objASPNETDivENEx_Para;
            
        }
        /// <summary>
        /// 建立函数的标题Div
        /// </summary>
        /// <param name="objvFunction4GeneCodeEN"></param>
        /// <returns></returns>
        public ASPDivEx GetDiv4FuncTitle(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4CodeEN objFunction4CodeEN = clsFunction4CodeBL.GetObjByFuncId4CodeCache(objvFunction4GeneCodeEN.FuncId4Code);// "UpdateRecord";
            string strFunctionName = objFunction4CodeEN.FuncName4Code;
            //string strFunctionName = "DelRecord";
            string strFunctionName_CN = string.Format("{0}、{1}", 
                objvFunction4GeneCodeEN.OrderNum, objFunction4CodeEN.FuncCHName4Code);

            //< div class="title" style="width:100%">
            //      <div style = "float:left; width:80%; " >
            //                 < asp:Label ID = "lblIsExistRecord4Title" Width="600px" Height="24px" Text="结果" runat="server" />

            //      </div>
            //      <div style = "float:right; width:20%; " >
            //          < input id="btnIsExistRecord4Expand" type="button" value="展开" onclick="ExpandDiv('divGen_WApi_CS_DefButtonIsExistRecord')" />
            //      </div>
            //  </div>
            ASPDivEx objASPNETDivENEx = new ASPDivEx();
            objASPNETDivENEx.Class = "title";
            objASPNETDivENEx.Style = "width:100%; height:25px;";

            {
                ASPDivEx objASPNETDivENEx_Left = new ASPDivEx();

                objASPNETDivENEx_Left.Style = "float:left; width:80%;";

                ASPLabelEx objASPNETLabelENEx = new ASPLabelEx();
                objASPNETLabelENEx.CtrlId = string.Format("lblTitle{0}", objvFunction4GeneCodeEN.OrderNum);
                objASPNETLabelENEx.Text = string.Format("测试：{0}", strFunctionName_CN);
                objASPNETLabelENEx.CssClass = "h6";
                objASPNETLabelENEx.Width = 600;
                objASPNETLabelENEx.Height = 20;

                objASPNETDivENEx_Left.arrSubAspControlLst2.Add(objASPNETLabelENEx);

                objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Left);

            }
            {
                ASPDivEx objASPNETDivENEx_Right = new ASPDivEx();

                objASPNETDivENEx_Right.Style = "float:right; width:20%;";

                ASPHtmlButtonEx objASPNETHtmlButtonENEx = new ASPHtmlButtonEx();
                objASPNETHtmlButtonENEx.CtrlId = string.Format("btnExpand{0}", strFunctionName);
                objASPNETHtmlButtonENEx.Value = string.Format("展开");
                objASPNETHtmlButtonENEx.OnClick = string.Format("ExpandDiv('div{0}');", strFunctionName);
                objASPNETHtmlButtonENEx.Width = 300;
                objASPNETHtmlButtonENEx.Height = 24;

                objASPNETDivENEx_Right.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
                
                objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Right);
            }
            
            return objASPNETDivENEx;
        }

        /// <summary>
        /// 建立函数的内容Div
        /// </summary>
        /// <param name="objvFunction4GeneCodeEN"></param>
        /// <returns></returns>
        private ASPDivEx GetDiv4FuncContent(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4CodeEN objFunction4CodeEN = clsFunction4CodeBL.GetObjByFuncId4CodeCache(objvFunction4GeneCodeEN.FuncId4Code);// "UpdateRecord";
            string strFunctionName = objFunction4CodeEN.FuncName4Code;

            string strFunctionName_CN = string.Format("{0}、{1}", objvFunction4GeneCodeEN.OrderNum, objFunction4CodeEN.FuncCHName4Code);

            ASPDivEx objASPNETDivENEx = new ASPDivEx();
            objASPNETDivENEx.Class = "content";
            objASPNETDivENEx.Style = "width: 100%";

            {
                ASPDivEx objASPNETDivENEx_Para = GetParaInputCtrlGroup(objvFunction4GeneCodeEN);
                objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Para);
            }
            //{
            //    ASPDivEx objASPNETDivENEx_Button = new ASPDivEx();
            //    objASPNETDivENEx_Button.Class = "button";
            //    objASPNETDivENEx_Button.Style = "width: 100%";

            //    ASPButtonEx objASPNETButtonENEx = new ASPButtonEx();
            //    objASPNETButtonENEx.CtrlId = string.Format("btn{0}", strFunctionName);
            //    objASPNETButtonENEx.OnClick = string.Format("btn{0}_Click", strFunctionName); ;
            //    objASPNETButtonENEx.Text = strFunctionName_CN;
            //    objASPNETButtonENEx.Width = 200;
            //    objASPNETButtonENEx.Height = 24;
            //    objASPNETButtonENEx.mTextSize = "12sp";
            //    objASPNETButtonENEx.minHeight = "35dp";
            //    objASPNETDivENEx_Button.arrSubAspControlLst2.Add(objASPNETButtonENEx);
            //    objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Button);
            //}
            //添加显示结果的控件
            ASPDivEx objASPNETDivENEx_ShowResult = GetFunctionResultDiv(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_ShowResult);

            return objASPNETDivENEx;

            //objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            //return strCodeForCs.ToString();
        }

        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(WA_ViewUTScript4Html);
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
            this.ClsName = string.Format("WApi{0}_UT_JS", objPrjTabENEx.TabName);
            objPrjTabENEx.ClsName = this.ClsName;
        }
    }

}
