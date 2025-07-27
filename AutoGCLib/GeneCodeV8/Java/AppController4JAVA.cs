using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AGC.PureClass;
using AgcCommBase;
using com.taishsoft.comm_db_obj;
using com.taishsoft.commexception;
using com.taishsoft.common;
using com.taishsoft.datetime;
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
    partial class AppController4JAVA : AppController4JAVABase
    {

        #region 构造函数

        //public AppController4JAVA()
        //{
        //    // 
        //    // TODO: 在此处添加构造函数逻辑
        //    //
        //}
        public AppController4JAVA(string strTabId, string strPrjDataBaseId, string strPrjId)
          : base(strTabId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
        }
        #endregion


        /// <summary>
        /// 生成Web Service转换层代码
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strFuncName = "";
            string strResult = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strResult = string.Format("当前表:[{0}]的字段数为0,无法生成通用逻辑层({1})",
                        objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strResult = string.Format("当前表:[{0}]的关键字的个数为0,无法生成通用逻辑层({1})",
                   objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            objPrjTabENEx.CurrDate = clsDateTime.getTodayStr2(0);

            //让用户设置属性;
            //string strFolder;
            string strClassFName;
            StringBuilder strBuilder = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp; ///临时变量;

            objPrjTabENEx.ClsName = "cls" + objPrjTabENEx.TabName + "_Controller";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".java";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName( objFuncModule, objPrjTabENEx);
            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".java";

            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //
            try
            {
                //类名开始

                strBuilder.Append(clsPubFun4GC.GenUserInfoAndDate4Java(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));

                strBuilder.AppendFormat("\r\n" + "package {0}.GC.L5_Controller.{1};",
                       objProject.JavaPackageName, objFuncModule.FuncModuleEnName4GC());
                strBuilder.Append("\r\n" + "import android.app.Activity;");
                strBuilder.Append("\r\n" + "import android.util.Log;");
                strBuilder.Append("\r\n" + "import android.widget.TextView;");
                strBuilder.Append("\r\n" + "import android.widget.EditText;");

                strBuilder.AppendFormat("\r\n" + "import {0}.GC.L0Entity.{2}.cls{1}EN;",
                    objProjectsENEx.JavaPackageName,
                      objPrjTabENEx.TabName, objFuncModule.FuncModuleEnName4GC()); //
                strBuilder.AppendFormat("\r\n" + "import {0}.GC.L4_Controller4WS.{2}.cls{1}WS4Controller;",
                            objProjectsENEx.JavaPackageName,
                              objPrjTabENEx.TabName, objFuncModule.FuncModuleEnName4GC()); //

                strBuilder.AppendFormat("\r\n" + "import {0}.PubFun.clsPubFun;",
                                  objProjectsENEx.JavaPackageName,
                                    objPrjTabENEx.TabName); //

                strBuilder.Append("\r\n" + "import com.taishsoft.util.clsResponseData;"); //
                strBuilder.Append("\r\n" + "import com.taishsoft.commdb.clsTableObjWS4ControllerDelegate;"); //
                strBuilder.Append("\r\n" + "import com.taishsoft.util.clsDate;"); //

                strBuilder.Append("\r\n" + "import java.util.List;"); //


                strBuilder.Append("\r\n" + ""); //

                strBuilder.Append("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);

                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.Append("\r\n" + "/**");
                strBuilder.AppendFormat("\r\n" + "* Created by {0} on {1}.",
                    objPrjTabENEx.UserId,
                    clsDateTime.getTodayStr(3));
                strBuilder.AppendFormat("\r\n" + "* 注意:该类必须与调用界面处于同一个包,否则调用不成功!", objPrjTabENEx.UserId, clsDateTime.getTodayStr(3));
                strBuilder.Append("\r\n" + "*/");
                strBuilder.AppendFormat("\r\n" + "public class  cls{0}_Controller",
                    objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "private TextView tvMsg;");

                //生成所有的函数
                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                  clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
                  objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                .OrderBy(x => x.OrderNum);

                //为所有的函数定义相关输入控件
                List<string> arrValueLst = new List<string>();
                int intIndex = 1;
                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    if (strFuncName.IndexOf("Invoke") <= 0) continue;

                    //string strTemp = "";
                    try
                    {
                        strTemp = GC_DeclareCtrlVar4FuncPara(objvFunction4GeneCodeEN, arrValueLst);
                        if (string.IsNullOrEmpty(strTemp) == false)
                        {
                            strBuilder.AppendFormat("\r\n" + "//为函数[{0}、{1}]的参数定义输入控件：",
                                intIndex,
                                objvFunction4GeneCodeEN.FuncName4Code);
                            strBuilder.Append(strTemp + "\r\n");
                        }
                        else
                        {
                            strTemp = string.Format("//该函数：[{0}、{1}]无法生成.",
                                 intIndex,
                                 objvFunction4GeneCodeEN.FuncName4Code);
                            strBuilder.Append("\r\n" + strTemp);
                        }
                        intIndex++;
                    }
                    catch (Exception objException)
                    {
                        strTemp = string.Format("//该函数：[{0}]无法生成.错误:[{1}]({2}->{3})",
                            objvFunction4GeneCodeEN.FunctionSignature,
                            objException.Message,
                            clsStackTrace.GetCurrClassFunctionByLevel(2),
                            clsStackTrace.GetCurrClassFunction());
                        strBuilder.Append("\r\n" + strTemp);
                    }
                }


                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    if (strFuncName.IndexOf("Java_icls") > 0) continue;

                    if (strFuncName.IndexOf("Java_btnClick") > 0)
                    {
                        strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    else if (strFuncName.IndexOf("Java_Invoke") > 0)
                    {
                        strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    else
                    {
                        strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    //strTemp = A_GeneFuncCode_Java(strFuncName);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strBuilder.Append("\r\n" + strTemp);
                    }
                }


                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    if (strFuncName.IndexOf("Java_icls") < 0) continue;
                    if (strFuncName.IndexOf("Java_btnClick") > 0)
                    {
                        strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    else if (strFuncName.IndexOf("Java_icls") > 0)
                    {
                        strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    else if (strFuncName.IndexOf("Java_Invoke") > 0)
                    {
                        strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    else
                    {
                        strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strBuilder.Append("\r\n" + strTemp);
                    }
                }
                strBuilder.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
           
            }
            return strBuilder.ToString();
        }

       
        private AndroidLinearLayoutEx GetLinearLayout4Function1(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            AndroidLinearLayoutEx objAndroidLinearLayoutENEx = new AndroidLinearLayoutEx();
            objAndroidLinearLayoutENEx.CtrlId = string.Format("tab{0}",
                objvFunction4GeneCodeEN.FuncName4Code);

            objAndroidLinearLayoutENEx.layout_width = "match_parent";
            objAndroidLinearLayoutENEx.layout_height = "match_parent";
            objAndroidLinearLayoutENEx.orientation = "vertical";



            AndroidButtonEx objAndroidButtonENEx = new AndroidButtonEx();
            objAndroidButtonENEx.CtrlId = string.Format("btn{0}",
                objvFunction4GeneCodeEN.FuncName4Code);
            objAndroidButtonENEx.OnClick =
                string.Format("btn{0}_Click", objvFunction4GeneCodeEN.FuncName4Code); ;
            objAndroidButtonENEx.Text = objvFunction4GeneCodeEN.FuncCHName4Code;
            objAndroidButtonENEx.layout_width = "wrap_content";
            objAndroidButtonENEx.layout_height = "wrap_content";
            objAndroidButtonENEx.mTextSize = "12sp";
            objAndroidButtonENEx.minHeight = "35dp";
            //objAndroidButtonENEx.layout_constraintStart_toStartOf = "parent";
            //objAndroidButtonENEx.layout_constraintTop_toBottomOf = "@+id/txtNum2";

            //objAndroidTabHostENEx.arrSubAndroidControlLst2.Add(objAndroidLinearLayoutENEx);
            objAndroidLinearLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidButtonENEx);
            return objAndroidLinearLayoutENEx;
        }

        private AndroidConstraintLayoutEx GetConstraintLayout4Function(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN,
            List<string> arrValueLst)
        {
            AndroidConstraintLayoutEx objAndroidConstraintLayoutENEx = new AndroidConstraintLayoutEx();
            objAndroidConstraintLayoutENEx.CtrlId = string.Format("tab{0}",
                objvFunction4GeneCodeEN.FuncName4Code);

            objAndroidConstraintLayoutENEx.layout_width = "match_parent";
            objAndroidConstraintLayoutENEx.layout_height = "match_parent";
            //objAndroidConstraintLayoutENEx.orientation = "vertical";
            List<clsFuncPara4CodeEN> arrFuncPara4CodeObjLst =
                clsFuncPara4CodeBLEx.GetObjListByFuncId4CodeCacheEx(objvFunction4GeneCodeEN.FuncId4Code, enumFunctionPurpose.GeneCode_01);
            string strMsg = "";
            bool bolIsFirstPara = true;//是否是第一个参数
            string strLastParaName = "";
            if (arrFuncPara4CodeObjLst != null)
            {
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

                    }
                    else
                    {
                        string strParaName_New = clsString.GetUniqueStrValue_S(objFuncPara4CodeEN.ParaName, arrValueLst);
                        arrValueLst.Add(strParaName_New);
                        AndroidTextViewEx objAndroidTextViewENEx = new AndroidTextViewEx();
                        objAndroidTextViewENEx.CtrlId = string.Format("lbl{0}", strParaName_New);
                        objAndroidTextViewENEx.Text = string.Format("{0}:", objFuncPara4CodeEN.ParaName);
                        objAndroidTextViewENEx.layout_width = "wrap_content";
                        objAndroidTextViewENEx.layout_height = "wrap_content";
                        objAndroidTextViewENEx.layout_constraintStart_toStartOf = "parent";
                        if (bolIsFirstPara == true)
                        {
                            objAndroidTextViewENEx.layout_marginTop = 8;

                            objAndroidTextViewENEx.layout_constraintTop_toTopOf = string.Format("{0}", "parent");
                        }
                        else
                        {
                            objAndroidTextViewENEx.layout_marginTop = 16 + 8;

                            objAndroidTextViewENEx.layout_constraintTop_toBottomOf = string.Format("@+id/lbl{0}", strLastParaName);
                        }
                        objAndroidConstraintLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidTextViewENEx);

                        AndroidEditTextEx objAndroidEditTextENEx = new AndroidEditTextEx();
                        objAndroidEditTextENEx.CtrlId = string.Format("txt{0}", strParaName_New);
                        //  objAndroidEditTextENEx.Text = "测试Add";
                        objAndroidEditTextENEx.layout_width = "wrap_content";
                        objAndroidEditTextENEx.layout_height = "wrap_content";
                        objAndroidEditTextENEx.layout_marginLeft = 8;
                        objAndroidEditTextENEx.layout_constraintLeft_toRightOf = string.Format("@+id/lbl{0}", strParaName_New);
                        if (bolIsFirstPara == true)
                        {
                            objAndroidEditTextENEx.layout_constraintTop_toTopOf = string.Format("{0}", "parent");
                        }
                        else
                        {
                            objAndroidEditTextENEx.layout_marginTop = 16;

                            objAndroidEditTextENEx.layout_constraintTop_toBottomOf = string.Format("@+id/lbl{0}", strLastParaName);

                        }
                        objAndroidConstraintLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidEditTextENEx);

                        strLastParaName = strParaName_New;
                        bolIsFirstPara = false;
                    }
                }
            }
            AndroidButtonEx objAndroidButtonENEx = new AndroidButtonEx();
            objAndroidButtonENEx.CtrlId = string.Format("btn{0}",
                objvFunction4GeneCodeEN.FuncName4Code);
            objAndroidButtonENEx.OnClick =
                string.Format("btn{0}_Click", objvFunction4GeneCodeEN.FuncName4Code); ;
            objAndroidButtonENEx.Text = objvFunction4GeneCodeEN.FuncCHName4Code;
            objAndroidButtonENEx.layout_width = "wrap_content";
            objAndroidButtonENEx.layout_height = "wrap_content";
            objAndroidButtonENEx.mTextSize = "12sp";
            objAndroidButtonENEx.minHeight = "35dp";
            objAndroidButtonENEx.layout_constraintStart_toStartOf = "parent";
            if (string.IsNullOrEmpty(strLastParaName) == true)
            {
                objAndroidButtonENEx.layout_constraintTop_toTopOf = "parent";
            }
            else
            {
                objAndroidButtonENEx.layout_constraintTop_toBottomOf = string.Format("@+id/lbl{0}", strLastParaName);
            }
            //objAndroidButtonENEx.layout_constraintTop_toBottomOf = "@+id/txtNum2";

            //objAndroidTabHostENEx.arrSubAndroidControlLst2.Add(objAndroidConstraintLayoutENEx);
            objAndroidConstraintLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidButtonENEx);
            return objAndroidConstraintLayoutENEx;
        }


        private AndroidLinearLayoutEx GetLinearLayout4Function4SelfDefWs1(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {
            AndroidLinearLayoutEx objAndroidLinearLayoutENEx = new AndroidLinearLayoutEx();
            objAndroidLinearLayoutENEx.CtrlId = string.Format("tab{0}",
                objWebSrvFunctionsENEx.FunctionName);

            objAndroidLinearLayoutENEx.layout_width = "match_parent";
            objAndroidLinearLayoutENEx.layout_height = "match_parent";
            objAndroidLinearLayoutENEx.orientation = "vertical";
            string strMsg = "";
            bool bolIsFirstPara = true;//是否是第一个参数
            string strLastParaName = "";
            foreach (clsWebSrvFuncParaEN objWebSrvFuncParaEN in objWebSrvFunctionsENEx.arrWebSrvFuncParaObjLst)
            {
                clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objWebSrvFuncParaEN.DataTypeId);
                clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;
                if (objDataTypeAbbrEN == null)
                {
                    objSelfDefDataTypeEN_Para = clsSelfDefDataTypeBLEx.getSelfDefDataTypeByDataTypeName(objWebSrvFuncParaEN.ParameterType);
                    if (objSelfDefDataTypeEN_Para == null)
                    {
                        strMsg = string.Format("函数参数的数据类型：[{0}({1})]没有处理,不能生成相应代码。", objDataTypeAbbrEN.DataTypeId,
                            objWebSrvFuncParaEN.ParameterType);
                        throw new Exception(strMsg);
                    }
                }
                if (objWebSrvFuncParaEN.IsByRef == true)
                {
                    //strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">引用型参数,返回:{1}</param>",
                    //    objWebSrvFuncParaEN.ParaName, objWebSrvFuncParaEN.ParaCnName);
                    //if (objSelfDefDataTypeEN_Para != null)
                    //{
                    //    sbParaList.AppendFormat("ref {0} {1},", objSelfDefDataTypeEN_Para.JavaType,
                    //        objWebSrvFuncParaEN.ParaName);
                    //}
                    //else
                    //{
                    //    sbParaList.AppendFormat("ref {0} {1},", objDataTypeAbbrEN.JavaType, objWebSrvFuncParaEN.ParaName);
                    //}
                    //sbParaVarList.AppendFormat("ref {0},", objWebSrvFuncParaEN.ParaName);
                }
                else
                {
                    AndroidTextViewEx objAndroidTextViewENEx = new AndroidTextViewEx();
                    objAndroidTextViewENEx.CtrlId = string.Format("lbl{0}", objWebSrvFuncParaEN.ParaName);
                    objAndroidTextViewENEx.Text = objWebSrvFuncParaEN.ParaName;
                    objAndroidTextViewENEx.layout_width = "wrap_content";
                    objAndroidTextViewENEx.layout_height = "wrap_content";
                    objAndroidTextViewENEx.layout_constraintStart_toStartOf = "parent";
                    if (bolIsFirstPara == true)
                    {
                        objAndroidTextViewENEx.layout_constraintTop_toTopOf = string.Format("{0}", "parent");
                    }
                    else
                    {
                        objAndroidTextViewENEx.layout_constraintTop_toBottomOf = string.Format("@+id/lbl{0}", strLastParaName);
                    }
                    objAndroidLinearLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidTextViewENEx);

                    AndroidEditTextEx objAndroidEditTextENEx = new AndroidEditTextEx();
                    objAndroidEditTextENEx.CtrlId = string.Format("txt{0}", objWebSrvFuncParaEN.ParaName);
                    //  objAndroidEditTextENEx.Text = "测试Add";
                    objAndroidEditTextENEx.layout_width = "wrap_content";
                    objAndroidEditTextENEx.layout_height = "wrap_content";
                    objAndroidEditTextENEx.layout_constraintLeft_toRightOf = string.Format("lbl{0}", objWebSrvFuncParaEN.ParaName);
                    if (bolIsFirstPara == true)
                    {
                        objAndroidEditTextENEx.layout_constraintTop_toTopOf = string.Format("{0}", "parent");
                    }
                    else
                    {
                        objAndroidEditTextENEx.layout_constraintTop_toBottomOf = string.Format("@+id/lbl{0}", strLastParaName);

                    }
                    objAndroidLinearLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidEditTextENEx);

                    strLastParaName = objWebSrvFuncParaEN.ParaName;

                }
            }
            AndroidButtonEx objAndroidButtonENEx = new AndroidButtonEx();
            objAndroidButtonENEx.CtrlId = string.Format("btn{0}",
                objWebSrvFunctionsENEx.FunctionName);
            objAndroidButtonENEx.OnClick =
                string.Format("btn{0}_Click", objWebSrvFunctionsENEx.FunctionName);
            objAndroidButtonENEx.Text = objWebSrvFunctionsENEx.FunctionName;
            objAndroidButtonENEx.layout_width = "wrap_content";
            objAndroidButtonENEx.layout_height = "wrap_content";
            objAndroidButtonENEx.mTextSize = "12sp";
            objAndroidButtonENEx.minHeight = "35dp";
            //objAndroidButtonENEx.layout_constraintStart_toStartOf = "parent";
            //objAndroidButtonENEx.layout_constraintTop_toBottomOf = "@+id/txtNum2";

            //objAndroidTabHostENEx.arrSubAndroidControlLst2.Add(objAndroidLinearLayoutENEx);
            objAndroidLinearLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidButtonENEx);
            return objAndroidLinearLayoutENEx;
        }
        private AndroidConstraintLayoutEx GetConstraintLayout4Function4SelfDefWs(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx,
            List<string> arrValueLst)
        {
            AndroidConstraintLayoutEx objAndroidConstraintLayoutENEx = new AndroidConstraintLayoutEx();
            objAndroidConstraintLayoutENEx.CtrlId = string.Format("tab{0}",
                objWebSrvFunctionsENEx.FunctionName);

            objAndroidConstraintLayoutENEx.layout_width = "match_parent";
            objAndroidConstraintLayoutENEx.layout_height = "match_parent";
            //objAndroidConstraintLayoutENEx.orientation = "vertical";
            string strMsg = "";
            bool bolIsFirstPara = true;//是否是第一个参数
            string strLastParaName = "";
            foreach (clsWebSrvFuncParaEN objWebSrvFuncParaEN in objWebSrvFunctionsENEx.arrWebSrvFuncParaObjLst)
            {
                clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objWebSrvFuncParaEN.DataTypeId);
                clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;
                if (objDataTypeAbbrEN == null)
                {
                    objSelfDefDataTypeEN_Para = clsSelfDefDataTypeBLEx.getSelfDefDataTypeByDataTypeName(objWebSrvFuncParaEN.ParameterType);
                    if (objSelfDefDataTypeEN_Para == null)
                    {
                        strMsg = string.Format("函数参数的数据类型：[{0}({1})]没有处理,不能生成相应代码。", objDataTypeAbbrEN.DataTypeId,
                            objWebSrvFuncParaEN.ParameterType);
                        throw new Exception(strMsg);
                    }
                }
                if (objWebSrvFuncParaEN.IsByRef == true)
                {
                    //strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">引用型参数,返回:{1}</param>",
                    //    objWebSrvFuncParaEN.ParaName, objWebSrvFuncParaEN.ParaCnName);
                    //if (objSelfDefDataTypeEN_Para != null)
                    //{
                    //    sbParaList.AppendFormat("ref {0} {1},", objSelfDefDataTypeEN_Para.JavaType,
                    //        objWebSrvFuncParaEN.ParaName);
                    //}
                    //else
                    //{
                    //    sbParaList.AppendFormat("ref {0} {1},", objDataTypeAbbrEN.JavaType, objWebSrvFuncParaEN.ParaName);
                    //}
                    //sbParaVarList.AppendFormat("ref {0},", objWebSrvFuncParaEN.ParaName);
                }
                else
                {
                    string strParaName_New = clsString.GetUniqueStrValue_S(objWebSrvFuncParaEN.ParaName, arrValueLst);
                    arrValueLst.Add(strParaName_New);
                    AndroidTextViewEx objAndroidTextViewENEx = new AndroidTextViewEx();
                    objAndroidTextViewENEx.CtrlId = string.Format("lbl{0}", strParaName_New);
                    objAndroidTextViewENEx.Text = string.Format("{0}:", objWebSrvFuncParaEN.ParaName);
                    objAndroidTextViewENEx.layout_width = "wrap_content";
                    objAndroidTextViewENEx.layout_height = "wrap_content";
                    objAndroidTextViewENEx.layout_constraintStart_toStartOf = "parent";
                    if (bolIsFirstPara == true)
                    {
                        objAndroidTextViewENEx.layout_marginTop = 8;

                        objAndroidTextViewENEx.layout_constraintTop_toTopOf = string.Format("{0}", "parent");
                    }
                    else
                    {
                        objAndroidTextViewENEx.layout_marginTop = 16 + 8;

                        objAndroidTextViewENEx.layout_constraintTop_toBottomOf = string.Format("@+id/lbl{0}", strLastParaName);
                    }
                    objAndroidConstraintLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidTextViewENEx);

                    AndroidEditTextEx objAndroidEditTextENEx = new AndroidEditTextEx();
                    objAndroidEditTextENEx.CtrlId = string.Format("txt{0}", strParaName_New);
                    //  objAndroidEditTextENEx.Text = "测试Add";
                    objAndroidEditTextENEx.layout_width = "wrap_content";
                    objAndroidEditTextENEx.layout_height = "wrap_content";
                    objAndroidEditTextENEx.layout_marginLeft = 8;
                    objAndroidEditTextENEx.layout_constraintLeft_toRightOf = string.Format("@+id/lbl{0}", strParaName_New);
                    if (bolIsFirstPara == true)
                    {
                        objAndroidEditTextENEx.layout_constraintTop_toTopOf = string.Format("{0}", "parent");
                    }
                    else
                    {
                        objAndroidEditTextENEx.layout_marginTop = 16;

                        objAndroidEditTextENEx.layout_constraintTop_toBottomOf = string.Format("@+id/lbl{0}", strLastParaName);

                    }
                    objAndroidConstraintLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidEditTextENEx);

                    strLastParaName = strParaName_New;
                    bolIsFirstPara = false;
                }
            }
            AndroidButtonEx objAndroidButtonENEx = new AndroidButtonEx();
            objAndroidButtonENEx.CtrlId = string.Format("btn{0}",
                objWebSrvFunctionsENEx.FunctionName);
            objAndroidButtonENEx.OnClick =
                string.Format("btn{0}_Click", objWebSrvFunctionsENEx.FunctionName);
            objAndroidButtonENEx.Text = objWebSrvFunctionsENEx.FunctionName;
            objAndroidButtonENEx.layout_width = "wrap_content";
            objAndroidButtonENEx.layout_height = "wrap_content";
            objAndroidButtonENEx.layout_marginTop = 16;

            objAndroidButtonENEx.mTextSize = "12sp";
            objAndroidButtonENEx.minHeight = "35dp";
            objAndroidButtonENEx.layout_constraintStart_toStartOf = "parent";
            if (string.IsNullOrEmpty(strLastParaName) == true)
            {
                objAndroidButtonENEx.layout_constraintTop_toTopOf = "parent";
            }
            else
            {
                objAndroidButtonENEx.layout_constraintTop_toBottomOf = string.Format("@+id/lbl{0}", strLastParaName);
            }
            //objAndroidTabHostENEx.arrSubAndroidControlLst2.Add(objAndroidLinearLayoutENEx);
            objAndroidConstraintLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidButtonENEx);
            return objAndroidConstraintLayoutENEx;
        }
        private string GC_DeclareCtrlVar4FuncPara(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx,
            List<string> arrValueLst)
        {
            StringBuilder sbCode = new StringBuilder();
            //objAndroidConstraintLayoutENEx.orientation = "vertical";
            string strMsg = "";

            foreach (clsWebSrvFuncParaEN objWebSrvFuncParaEN in objWebSrvFunctionsENEx.arrWebSrvFuncParaObjLst)
            {
                clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objWebSrvFuncParaEN.DataTypeId);
                clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;
                if (objDataTypeAbbrEN == null)
                {
                    objSelfDefDataTypeEN_Para = clsSelfDefDataTypeBLEx.getSelfDefDataTypeByDataTypeName(objWebSrvFuncParaEN.ParameterType);
                    if (objSelfDefDataTypeEN_Para == null)
                    {
                        strMsg = string.Format("函数参数的数据类型：[{0}({1})]没有处理,不能生成相应代码。", objDataTypeAbbrEN.DataTypeId,
                            objWebSrvFuncParaEN.ParameterType);
                        throw new Exception(strMsg);
                    }
                }
                if (objWebSrvFuncParaEN.IsByRef == true)
                {

                }
                else
                {
                    string strParaName_New = clsString.GetUniqueStrValue_S(objWebSrvFuncParaEN.ParaName, arrValueLst);
                    arrValueLst.Add(strParaName_New);
                    objWebSrvFuncParaEN._StrTag = strParaName_New;
                    sbCode.AppendFormat("\r\n" + "private EditText txt{0};", strParaName_New);
                }
            }
            return sbCode.ToString();
        }

        private string GC_DeclareCtrlVar4FuncPara(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN,
       List<string> arrValueLst)
        {
            StringBuilder sbCode = new StringBuilder();
            //objAndroidConstraintLayoutENEx.orientation = "vertical";
            string strMsg = "";
            List<clsFuncPara4CodeEN> arrFuncPara4CodeObjLst =
               clsFuncPara4CodeBLEx.GetObjListByFuncId4CodeCacheEx(objvFunction4GeneCodeEN.FuncId4Code, enumFunctionPurpose.GeneCode_01);
            if (arrFuncPara4CodeObjLst != null)
            {
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

                    }
                    else
                    {
                        string strParaName_New = clsString.GetUniqueStrValue_S(objFuncPara4CodeEN.ParaName, arrValueLst);
                        arrValueLst.Add(strParaName_New);
                        objFuncPara4CodeEN._StrTag = strParaName_New;
                        sbCode.AppendFormat("\r\n" + "private EditText txt{0};", strParaName_New);
                    }
                }
            }
            return sbCode.ToString();
        }
        private string GC_BindCtrlVar4FuncPara(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx,
         List<string> arrValueLst)
        {
            StringBuilder sbCode = new StringBuilder();
            //objAndroidConstraintLayoutENEx.orientation = "vertical";
            string strMsg = "";

            foreach (clsWebSrvFuncParaEN objWebSrvFuncParaEN in objWebSrvFunctionsENEx.arrWebSrvFuncParaObjLst)
            {
                clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objWebSrvFuncParaEN.DataTypeId);
                clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;
                if (objDataTypeAbbrEN == null)
                {
                    objSelfDefDataTypeEN_Para = clsSelfDefDataTypeBLEx.getSelfDefDataTypeByDataTypeName(objWebSrvFuncParaEN.ParameterType);
                    if (objSelfDefDataTypeEN_Para == null)
                    {
                        strMsg = string.Format("函数参数的数据类型：[{0}({1})]没有处理,不能生成相应代码。", objDataTypeAbbrEN.DataTypeId,
                            objWebSrvFuncParaEN.ParameterType);
                        throw new Exception(strMsg);
                    }
                }
                if (objWebSrvFuncParaEN.IsByRef == true)
                {

                }
                else
                {
                    string strParaName_New = objWebSrvFuncParaEN._StrTag;
                    //string strParaName_New = clsString.GetUniqueStrValue_S(objWebSrvFuncParaEN.ParaName, arrValueLst);
                    //arrValueLst.Add(strParaName_New);
                    //objWebSrvFuncParaEN._StrTag = strParaName_New;
                    sbCode.AppendFormat("\r\n" + "txt{0} = (EditText)findViewById(R.id.txt{0});", strParaName_New);
                }
            }
            return sbCode.ToString();
        }

        private string GC_BindCtrlVar4FuncPara(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN,
    List<string> arrValueLst)
        {
            StringBuilder sbCode = new StringBuilder();
            //objAndroidConstraintLayoutENEx.orientation = "vertical";
            string strMsg = "";
            List<clsFuncPara4CodeEN> arrFuncPara4CodeObjLst =
              clsFuncPara4CodeBLEx.GetObjListByFuncId4CodeCacheEx(objvFunction4GeneCodeEN.FuncId4Code, enumFunctionPurpose.GeneCode_01);
            if (arrFuncPara4CodeObjLst != null)
            {
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

                    }
                    else
                    {
                        string strParaName_New = objFuncPara4CodeEN._StrTag;
                        //string strParaName_New = clsString.GetUniqueStrValue_S(objWebSrvFuncParaEN.ParaName, arrValueLst);
                        //arrValueLst.Add(strParaName_New);
                        //objWebSrvFuncParaEN._StrTag = strParaName_New;
                        sbCode.AppendFormat("\r\n" + "txt{0} = (EditText)findViewById(R.id.txt{0});", strParaName_New);
                    }
                }
            }
            return sbCode.ToString();
        }
       

        public string Gen_Controller_Java_btnGetFirstJSONObj_Click(string strFuncId4GC)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取相应的第一条记录的对象");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.Append("\r\n" + "public void btnGetFirstJSONObj_Click(View myView) {");

            strBuilder.AppendFormat("\r\n" + "icls{0}GetFirstJSONObj iobj{0}GetFirstJSONObj = new icls{0}GetFirstJSONObj();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetFirstJSONObj.main();",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "class icls{0}GetFirstJSONObj extends  clsTableObjWS4ControllerDelegate",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "public void main()");
            strBuilder.Append("\r\n" + "{");


            strBuilder.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "String strWhereCond =\" 1=1 \";");
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.GetFirst{0}(strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//通过WebService执行GetFirstJSONObj,返回的事件函数,可能需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(clsResponseData objResponseData, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetFirstJSONObj,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "clsPubFun.ShowMessage(ac{0}_QUDI.this, objResponseData.faultString);",
    objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//通过WebService执行GetFirstJSONObj,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(Object returnObject, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetFirstJSONObj,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = (cls{0}EN)returnObject;",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "String strWhereCond = txt{0}.getText().toString();",
                GetNewParaCtrlName(strFuncId4GC, "strWhereCond"));
            strBuilder.AppendFormat("\r\n" + "String strInfo = String.format(\"根据条件:[%s] 获取第一个记录对象：%s!\", strWhereCond, obj{0}EN.get{1}());",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.Append("\r\n" + "tvMsg.setText(strInfo);");
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strBuilder.Append("\r\n" + "}");


            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// 根据关键字获取相应的记录的对象 
        /// </summary>
        /// <returns></returns>
        public string Gen_Controller_Java_btnIsExistRecord_Click(string strFuncId4GC)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 检查相应关键字的记录是否存在");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">发送者</param>");
            strBuilder.Append("\r\n /// <returns>返回是否存在</returns>");

            strBuilder.Append("\r\n" + "public void btnIsExistRecord_Click(View myView) {");


            strBuilder.Append("\r\n" + "iclsIsExistRecord iobjIsExistRecord = new iclsIsExistRecord();");
            strBuilder.Append("\r\n" + "iobjIsExistRecord.main();");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "class iclsIsExistRecord extends  clsTableObjWS4ControllerDelegate");
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "public void main()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "String strWhereCond = \"{0} ='12'\";",
                objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.IsExistRecord(strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行IsExistRecord,返回的事件函数,可能需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(clsResponseData objResponseData, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "clsPubFun.ShowMessage(ac{0}_QUDI.this, objResponseData.faultString);",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行IsExistRecord,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(boolean returnBool, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "switch (strClassName) {");
            strBuilder.AppendFormat("\r\n" + "case \"cls{0}WS4Controller\":",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "if (returnBool == false)");
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "String strWhereCond = txt{0}.getText().toString();",
                GetNewParaCtrlName(strFuncId4GC, "strWhereCond"));
            strBuilder.AppendFormat("\r\n" + "String strInfo = String.format(\"根据条件:[%s] 不存在!\", strWhereCond);",
                objKeyField.FldName);
            strBuilder.Append("\r\n" + "tvMsg.setText(strInfo);");
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "String strWhereCond = txt{0}.getText().toString();",
                GetNewParaCtrlName(strFuncId4GC, "strWhereCond"));
            strBuilder.AppendFormat("\r\n" + "String strInfo = String.format(\"根据条件:[%s] 存在!\", strWhereCond);",
                objKeyField.FldName);
            strBuilder.Append("\r\n" + "tvMsg.setText(strInfo);");
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "break;");
            strBuilder.AppendFormat("\r\n" + "case \"cls{0}WS4Controller2\":",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "break;");

            strBuilder.Append("\r\n" + "default: ");

            strBuilder.Append("\r\n" + "break;");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// 根据关键字获取相应的记录的对象 
        /// </summary>
        /// <returns></returns>
        public string Gen_Controller_Java_GetRecCountByCond_Click(string strFuncId4GC)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 检查相应关键字的记录是否存在");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">发送者</param>");
            strBuilder.Append("\r\n /// <returns>返回是否存在</returns>");

            strBuilder.Append("\r\n" + "public void GetRecCountByCond_Click(View myView) {");


            strBuilder.Append("\r\n" + "iclsGetRecCountByCond iobjGetRecCountByCond = new iclsGetRecCountByCond();");
            strBuilder.Append("\r\n" + "iobjGetRecCountByCond.main();");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "class iclsGetRecCountByCond extends  clsTableObjWS4ControllerDelegate");
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "public void main()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "String strWhereCond = \"{0} ='12'\";",
                objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.GetRecCountByCond(strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行GetRecCountByCond,返回的事件函数,可能需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(clsResponseData objResponseData, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecCountByCond,
                enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "clsPubFun.ShowMessage(ac{0}_QUDI.this, objResponseData.faultString);",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行GetRecCountByCond,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(int returnInt, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecCountByCond,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");


            strBuilder.AppendFormat("\r\n" + "String strWhereCond = txt{0}.getText().toString();",
                GetNewParaCtrlName(strFuncId4GC, "strWhereCond"));

            strBuilder.AppendFormat("\r\n" + "String strInfo = String.format(\"根据条件:[%s]的记录数:[%s]!\", strWhereCond, returnInt);",
                objKeyField.FldName);
            strBuilder.Append("\r\n" + "tvMsg.setText(strInfo);");
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.AppendFormat("\r\n" + "clsPubFun.ShowMessage(ac{0}_QUDI.this, strInfo);",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }



        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(AppController4JAVA);
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
            this.ClsName = string.Format("cls{0}_Controller", objPrjTabENEx.TabName);
            objPrjTabENEx.ClsName = this.ClsName;
        }

        public override string GeneCode4Function(string strFuncId4GC, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp; //临时变量;
            string strFuncName = "";
            try
            {
                //类名开始
                clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
                strFuncName = objvFunction4GeneCodeEN.FuncName;

                if (strFuncName.Substring(0, 6) == "Print:")
                {
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.Append("\r\n " + strFuncName.Substring(6));
                    return strCodeForCs.ToString();
                }

                if (objvFunction4GeneCodeEN.FuncTypeId == "10")//用户自定义函数
                {
                    strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId(objvFunction4GeneCodeEN.FuncId4GC,
                        objPrjTabENEx.TabId, objPrjTabENEx.PrjDataBaseId, objPrjTabENEx.PrjId);
                }
                else
                {
                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                }

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
