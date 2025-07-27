using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AGC.PureClass;
using AGC.PureClassEx;
using AgcCommBase;
using com.taishsoft.comm_db_obj;
using com.taishsoft.commexception;
using com.taishsoft.common;
using com.taishsoft.datetime;
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
    partial class AppViewUTScript_UDF4JAVA : clsGeneCodeBase4Tab
    {        

        #region 构造函数

        
        public AppViewUTScript_UDF4JAVA(string strViewId, string strPrjDataBaseId, string strPrjId)
          : base( strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
        }
        #endregion


    
     
      
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
                    //strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">引用型参数,返回:{1}</param>",
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
                    //strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">引用型参数,返回:{1}</param>",
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
     
        /// <summary>
        /// 生成自定义WS的App界面脚本
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {

            string strResult = "";
            if (objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst.Count == 0)
            {
                strResult = string.Format("当前类:[{0}]的函数数为0,无法生成相关层!({1})",
                      objWebSrvClassENEx.ClsName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }

            objWebSrvClassENEx.CurrDate = clsDateTime.getTodayStr2(0);

            //让用户设置属性;
            //string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp = ""; ///临时变量;

            objWebSrvClassENEx.ClsName = "ac" + objWebSrvClassENEx.ClsName + "4SD_UTScript";
            objWebSrvClassENEx.ClsName = objWebSrvClassENEx.ClsName.ToLower();
            //objWebSrvClassENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objWebSrvClassENEx.SimpleFileName = objWebSrvClassENEx.ClsName + ".xml";
            strRe_ClsName = objWebSrvClassENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objWebSrvClassENEx.FuncModuleAgcId, objWebSrvClassENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("UT_{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objWebSrvClassENEx.SimpleFileName);
            strClassFName = objWebSrvClassENEx.FolderName + objWebSrvClassENEx.ClsName + ".xml";

            objWebSrvClassENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objWebSrvClassENEx.PrjId); //

            try
            {
                //类名开始

                //   strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate4Java(objWebSrvClassENEx.CurrUserName, objWebSrvClassENEx));

                strCodeForCs.Append("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                AndroidConstraintLayoutEx objAndroidConstraintLayoutENEx = new AndroidConstraintLayoutEx();
                objAndroidConstraintLayoutENEx.android = "http://schemas.android.com/apk/res/android";
                objAndroidConstraintLayoutENEx.app = "http://schemas.android.com/apk/res-auto";
                objAndroidConstraintLayoutENEx.tools = "http://schemas.android.com/tools";

                objAndroidConstraintLayoutENEx.layout_width = "match_parent";
                objAndroidConstraintLayoutENEx.layout_height = "match_parent";

                //objAndroidConstraintLayoutENEx.showIn = "@layout/ac_invoke_web_srv";
                //objAndroidConstraintLayoutENEx.context = "com.taishsoft.TechnicalResearch.InvokeWebSrv";
                objAndroidConstraintLayoutENEx.layout_behavior = "@string/appbar_scrolling_view_behavior";

                AndroidTabHostEx objAndroidTabHostENEx = new AndroidTabHostEx();
                objAndroidTabHostENEx.CtrlId = "tabHost";
                objAndroidTabHostENEx.layout_width = "wrap_content";
                objAndroidTabHostENEx.layout_height = "300dip";
                objAndroidTabHostENEx.layout_constraintStart_toStartOf = "parent";
                objAndroidTabHostENEx.layout_constraintTop_toTopOf = "parent";
                objAndroidConstraintLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidTabHostENEx);

                AndroidLinearLayoutEx objAndroidLinearLayoutENEx = new AndroidLinearLayoutEx();
                //objAndroidLinearLayoutENEx.CtrlId = "txtAdd";

                objAndroidLinearLayoutENEx.layout_width = "match_parent";
                objAndroidLinearLayoutENEx.layout_height = "match_parent";
                objAndroidLinearLayoutENEx.orientation = "vertical";
                objAndroidTabHostENEx.arrSubAndroidControlLst2.Add(objAndroidLinearLayoutENEx);

                AndroidHorizontalScrollViewEx objAndroidHorizontalScrollViewENEx = new AndroidHorizontalScrollViewEx();
                //objAndroidHorizontalScrollViewENEx.CtrlId = "tabs";
                objAndroidHorizontalScrollViewENEx.layout_width = "match_parent";
                objAndroidHorizontalScrollViewENEx.layout_height = "wrap_content";
                objAndroidHorizontalScrollViewENEx.scrollbars = "none";

                objAndroidLinearLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidHorizontalScrollViewENEx);

                AndroidTabWidgetEx objAndroidTabWidgetENEx = new AndroidTabWidgetEx();
                objAndroidTabWidgetENEx.CtrlId = "tabs";

                objAndroidTabWidgetENEx.layout_width = "match_parent";
                objAndroidTabWidgetENEx.layout_height = "wrap_content";

                objAndroidHorizontalScrollViewENEx.arrSubAndroidControlLst2.Add(objAndroidTabWidgetENEx);

                AndroidFrameLayoutEx objAndroidFrameLayoutENEx = new AndroidFrameLayoutEx();
                objAndroidFrameLayoutENEx.CtrlId = "tabcontent";
                objAndroidFrameLayoutENEx.layout_width = "match_parent";
                objAndroidFrameLayoutENEx.layout_height = "match_parent";
                objAndroidLinearLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidFrameLayoutENEx);
                List<string> arrValueLst = new List<string>();
                foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
                {
                    if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                    try
                    {
                        //strTemp = Gen_Controller_Java_DefButtonByCommonFunction(objWebSrvFunctionsENEx);
                        AndroidConstraintLayoutEx objAndroidConstraintLayoutENEx1 =
                           GetConstraintLayout4Function4SelfDefWs(objWebSrvFunctionsENEx, arrValueLst);
                        objAndroidFrameLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidConstraintLayoutENEx1);
                        //                   

                    }
                    catch (Exception objException)
                    {
                        strTemp = string.Format("//该函数：[{0}]无法生成.错误:[{1}]({2}->{3})",
                            objWebSrvFunctionsENEx.FunctionSignature,
                            objException.Message,
                            clsStackTrace.GetCurrClassFunctionByLevel(2),
                            clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n" + strTemp);
                    }
                }
                AndroidTextViewEx objAndroidTextViewENEx = new AndroidTextViewEx();
                objAndroidTextViewENEx.CtrlId = "tvMsg";

                objAndroidTextViewENEx.Text = "返回结果";
                objAndroidTextViewENEx.layout_width = "wrap_content";
                objAndroidTextViewENEx.layout_height = "wrap_content";
                objAndroidTextViewENEx.layout_constraintStart_toStartOf = "parent";
                objAndroidTextViewENEx.layout_constraintTop_toBottomOf = "@+id/tabHost";

                objAndroidConstraintLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidTextViewENEx);
                //objAndroidConstraintLayoutENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }



        /// <summary>
        /// 生成Web Service转换层代码
        /// </summary>
        /// <returns></returns>
        public string A_GenController_Java_SelfDefWs(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            if (objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst.Count == 0)
            {
                string strResult = string.Format("当前类:[{0}]的函数数为0,无法生成相关层!({1})",
                      objWebSrvClassENEx.ClsName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }

            objWebSrvClassENEx.CurrDate = clsDateTime.getTodayStr2(0);

            //让用户设置属性;
            //string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp; ///临时变量;

            objWebSrvClassENEx.ClsName = "cls" + objWebSrvClassENEx.ClsName + "4SD_Controller";
            //objWebSrvClassENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objWebSrvClassENEx.SimpleFileName = objWebSrvClassENEx.ClsName + ".java";
            strRe_ClsName = objWebSrvClassENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objWebSrvClassENEx.FuncModuleAgcId, objWebSrvClassENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objWebSrvClassENEx.SimpleFileName);
            strClassFName = objWebSrvClassENEx.FolderName + objWebSrvClassENEx.ClsName + ".java";

            objWebSrvClassENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objWebSrvClassENEx.PrjId); //
            try
            {
                //类名开始

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objWebSrvClassENEx.CurrUserName, objWebSrvClassENEx));

                strCodeForCs.AppendFormat("\r\n" + "package {0}.GC.L5_Controller.{1};",
                       objProject.JavaPackageName, objFuncModule.FuncModuleEnName4GC());

                //strCodeForCs.AppendFormat("\r\n" + "import {0}.L0Entity.cls{1}EN;",
                //    objProjectsENEx.JavaPackageName,
                //      objWebSrvClassENEx.TabName); //
                strCodeForCs.Append("\r\n" + " import android.app.Activity;");

                strCodeForCs.Append("\r\n" + "import com.taishsoft.util.clsResponseData;"); //
                strCodeForCs.Append("\r\n" + "import com.taishsoft.commdb.clsTableObjWS4ControllerDelegate;"); //
                strCodeForCs.AppendFormat("\r\n" + "import {0}.GC.L4_Controller4WS.{1}.{2}WS4SDController;",
                    objProjectsENEx.JavaPackageName,
                    objFuncModule.FuncModuleEnName4GC(),
                    objWebSrvClassENEx.ClsName); //


                strCodeForCs.AppendFormat("\r\n" + "import {0}.PubFun.clsPubFun;",
                    objProjectsENEx.JavaPackageName); //
                strCodeForCs.Append("\r\n" + "import java.util.List;"); //

                strCodeForCs.Append("\r\n" + ""); //

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})", objWebSrvClassENEx.ClsName,
                    objWebSrvClassENEx.PageName);

                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/**");
                strCodeForCs.AppendFormat("\r\n" + "* Created by {0} on {1}.",
                    objWebSrvClassENEx.CurrUserName,
                    clsDateTime.getTodayStr(3));
                strCodeForCs.AppendFormat("\r\n" + "* 注意:该类必须与调用界面处于同一个包,否则调用不成功!", objWebSrvClassENEx.CurrUserName, clsDateTime.getTodayStr(3));
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "public class  cls{0}4SD_Controller extends Activity",
                    objWebSrvClassENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");

                //生成所有的函数
                foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
                {
                    if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                    try
                    {
                        strTemp = Gen_Controller_Java_ByCommonFunction(objWebSrvFunctionsENEx);
                        if (string.IsNullOrEmpty(strTemp) == false)
                        {
                            strCodeForCs.Append("\r\n" + strTemp);
                            clsWebSrvFunctionsBLEx.SetGeneCode(objWebSrvFunctionsENEx.WebSrvFunctionId, true);
                        }
                        else
                        {
                            strTemp = string.Format("//该函数：[{0}]无法生成.", objWebSrvFunctionsENEx.FunctionSignature);
                            strCodeForCs.Append("\r\n" + strTemp);
                        }
                    }
                    catch (Exception objException)
                    {
                        strTemp = string.Format("//该函数：[{0}]无法生成.错误:[{1}]({2}->{3})",
                            objWebSrvFunctionsENEx.FunctionSignature,
                            objException.Message,
                            clsStackTrace.GetCurrClassFunctionByLevel(2),
                            clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n" + strTemp);
                    }
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


        /// <summary>
        /// 生成Web Service转换层代码
        /// </summary>
        /// <returns></returns>
        public string A_GenTableObjWSController_Java_SelfDefWs(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {

            string strResult = "";
            if (objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst.Count == 0)
            {
                strResult = string.Format("当前类:[{0}]的函数数为0,无法生成Web服务处理高层!({1})",
                      objWebSrvClassENEx.ClsName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            objWebSrvClassENEx.CurrDate = clsDateTime.getTodayStr2(0);

            //让用户设置属性;
            //string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp; ///临时变量;

            objWebSrvClassENEx.ClsName = string.Format("{0}WS4SDController", objWebSrvClassENEx.ClsName);
            //objWebSrvClassENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objWebSrvClassENEx.SimpleFileName = objWebSrvClassENEx.ClsName + ".java";
            strRe_ClsName = objWebSrvClassENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objWebSrvClassENEx.FuncModuleAgcId, objWebSrvClassENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objWebSrvClassENEx.SimpleFileName);
            strClassFName = objWebSrvClassENEx.FolderName + objWebSrvClassENEx.ClsName + ".java";

            objWebSrvClassENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objWebSrvClassENEx.PrjId); //
            try
            {
                //类名开始
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objWebSrvClassENEx.CurrUserName, objWebSrvClassENEx));

                strCodeForCs.AppendFormat("\r\n" + "package {0}.GC.L4_Controller4WS.{1};",
                       objProject.JavaPackageName, objFuncModule.FuncModuleEnName4GC());

                //strCodeForCs.AppendFormat("\r\n" + "import {0}.L0Entity.cls{1}EN;",
                //      objProjectsENEx.JavaPackageName,
                //      objWebSrvClassENEx.TabName);
                //strCodeForCs.AppendFormat("\r\n" + "import {0}.Logic.cls{1}BL;",
                //      objProjectsENEx.JavaPackageName,
                //      objWebSrvClassENEx.TabName);
                strCodeForCs.Append("\r\n" + "import com.taishsoft.util.clsResponseData;");
                strCodeForCs.Append("\r\n" + "import com.taishsoft.commdb.clsTableObjWS4ControllerDelegate;");
                strCodeForCs.AppendFormat("\r\n" + "import {0}.GC.L3_ForWS.{1}.{2}WS4SD;",
                   objProjectsENEx.JavaPackageName,
                   objFuncModule.FuncModuleEnName4GC(), objWebSrvClassENEx.ClsName);

                strCodeForCs.Append("\r\n" + "import android.os.Bundle;");
                strCodeForCs.Append("\r\n" + "import android.os.Handler;");
                strCodeForCs.Append("\r\n" + "import android.os.Looper;");
                strCodeForCs.Append("\r\n" + "import android.os.Message;");
                strCodeForCs.Append("\r\n" + "import android.widget.TextView;");
                strCodeForCs.Append("\r\n" + "import android.widget.Toast;");

                strCodeForCs.Append("\r\n" + "import org.json.JSONObject;");
                strCodeForCs.Append("\r\n" + "import org.ksoap2.SoapEnvelope;");
                strCodeForCs.Append("\r\n" + "import org.ksoap2.serialization.SoapObject;");
                strCodeForCs.Append("\r\n" + "import org.ksoap2.serialization.SoapPrimitive;");
                strCodeForCs.Append("\r\n" + "import org.ksoap2.serialization.SoapSerializationEnvelope;");
                strCodeForCs.Append("\r\n" + "import org.ksoap2.transport.HttpTransportSE;");

                strCodeForCs.Append("\r\n" + "import java.util.HashMap;");

                strCodeForCs.Append("\r\n" + "import java.util.Iterator;");
                strCodeForCs.Append("\r\n" + "import java.util.List;");
                strCodeForCs.Append("\r\n" + "import java.util.Map;");

                strCodeForCs.Append("\r\n" + ""); //
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})",
                    objWebSrvClassENEx.PageName,
                    objWebSrvClassENEx.ClsName);

                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/**");
                strCodeForCs.AppendFormat("\r\n" + "* Created by {0} on {1}.",
                    objWebSrvClassENEx.CurrUserName,
                    clsDateTime.getTodayStr(3));
                strCodeForCs.AppendFormat("\r\n" + "* 注意:该类必须与调用界面处于同一个包,否则调用不成功!", objWebSrvClassENEx.CurrUserName, clsDateTime.getTodayStr(3));
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "public class  {0}",
                       objWebSrvClassENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "public clsTableObjWS4ControllerDelegate objTableObjWS4ControllerDelegate;");

                strCodeForCs.AppendFormat("\r\n" + "public {0}()", objWebSrvClassENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");


                strCodeForCs.Append("\r\n" + "}");

                //生成所有的函数

                foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
                {
                    if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                    try
                    {
                        strTemp = Gen_4WS4Controller_Java_ByCommonFunction(objWebSrvFunctionsENEx);
                        if (string.IsNullOrEmpty(strTemp) == false)
                        {
                            strCodeForCs.Append("\r\n" + strTemp);
                            clsWebSrvFunctionsBLEx.SetGeneCode(objWebSrvFunctionsENEx.WebSrvFunctionId, true);
                        }
                        else
                        {
                            strTemp = string.Format("//该函数：[{0}]无法生成.", objWebSrvFunctionsENEx.FunctionSignature);
                            strCodeForCs.Append("\r\n" + strTemp);
                        }
                    }
                    catch (Exception objException)
                    {
                        strTemp = string.Format("//该函数：[{0}]无法生成.错误:[{1}]({2}->{3})",
                            objWebSrvFunctionsENEx.FunctionSignature,
                            objException.Message,
                            clsStackTrace.GetCurrClassFunctionByLevel(2),
                            clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n" + strTemp);
                    }
                }
                //strTemp = A_GeneFuncCode_Java("Gen_4WS4Controller_Java_SelfDefWs_handleMessage");
                strTemp = Gen_4WS4Controller_Java_SelfDefWs_handleMessage();
                strCodeForCs.Append("\r\n" + strTemp);

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
        /// 根据关键字获取相应的记录的对象 
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Java_ByCommonFunction(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {
            string strMsg = "";
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// {0}", objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            StringBuilder sbParaList = new StringBuilder();
            StringBuilder sbParaVarList = new StringBuilder();

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
                    strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">引用型参数,返回:{1}</param>",
                        objWebSrvFuncParaEN.ParaName, objWebSrvFuncParaEN.ParaCnName);
                    if (objSelfDefDataTypeEN_Para != null)
                    {
                        sbParaList.AppendFormat("ref {0} {1},", objSelfDefDataTypeEN_Para.JavaType,
                            objWebSrvFuncParaEN.ParaName);
                    }
                    else
                    {
                        sbParaList.AppendFormat("ref {0} {1},", objDataTypeAbbrEN.JavaType, objWebSrvFuncParaEN.ParaName);
                    }
                    sbParaVarList.AppendFormat("ref {0},", objWebSrvFuncParaEN.ParaName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">{1}</param>",
                        objWebSrvFuncParaEN.ParaName, objWebSrvFuncParaEN.ParaCnName);
                    if (objSelfDefDataTypeEN_Para != null)
                    {
                        sbParaList.AppendFormat("{0} {1},",
                            objSelfDefDataTypeEN_Para.JavaType,
                            objWebSrvFuncParaEN.ParaName);
                    }
                    else
                    {
                        sbParaList.AppendFormat("{0} {1},",
                            objDataTypeAbbrEN.JavaType,
                            objWebSrvFuncParaEN.ParaName);
                    }
                    sbParaVarList.AppendFormat("{0},", objWebSrvFuncParaEN.ParaName);
                }
            }
            if (sbParaList.Length > 0)
            {
                sbParaList.Remove(sbParaList.Length - 1, 1);
                sbParaVarList.Remove(sbParaVarList.Length - 1, 1);
            }
            strCodeForCs.AppendFormat("\r\n /// <returns>返回{0}</returns>",
                     objWebSrvFunctionsENEx.ReturnValueDescription);

            strCodeForCs.AppendFormat("\r\n" + "public void {0}({1})",
                objWebSrvFunctionsENEx.FunctionName, sbParaList.ToString());
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "Map<String, String> mapParam = new HashMap<String, String>();");
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
                    strMsg = string.Format("Java函数参数的不接受引用型参数。参数名：[{0}],数据类型：[{1}]没有处理,不能生成相应代码。",
                        objWebSrvFuncParaEN.ParaName,
                          objWebSrvFuncParaEN.ParameterType);
                    throw new Exception(strMsg);

                    //if (objDataTypeAbbrEN.IsNeedQuote == true)
                    //{
                    //    strCodeForCs.AppendFormat("\r\n" + "mapParam.put(\"{0}\", {0});",
                    //        objWebSrvFuncParaEN.ParaName);
                    //}
                    //else
                    //{
                    //    strCodeForCs.AppendFormat("\r\n" + "mapParam.put(\"{0}\", {0}.toString());",
                    //        objWebSrvFuncParaEN.ParaName);
                    //}
                }
                else
                {
                    if (objDataTypeAbbrEN.IsNeedQuote == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "mapParam.put(\"{0}\", {0});",
                            objWebSrvFuncParaEN.ParaName);
                    }
                    else
                    {
                        switch (objDataTypeAbbrEN.JavaType)
                        {
                            case "int":
                                strCodeForCs.AppendFormat("\r\n" + "mapParam.put(\"{0}\", Integer.toString({0}));",
                                    objWebSrvFuncParaEN.ParaName);
                                break;
                            case "long":
                                strCodeForCs.AppendFormat("\r\n" + "mapParam.put(\"{0}\", Long.toString({0}));",
                                    objWebSrvFuncParaEN.ParaName);
                                break;
                            case "float":
                                strCodeForCs.AppendFormat("\r\n" + "mapParam.put(\"{0}\", Float.toString({0}));",
                                    objWebSrvFuncParaEN.ParaName);
                                break;
                            case "double":
                                strCodeForCs.AppendFormat("\r\n" + "mapParam.put(\"{0}\", Double.toString({0}));",
                                    objWebSrvFuncParaEN.ParaName);
                                break;
                            default:
                                strMsg = string.Format("Java类型：[{0}]没有在函数中被处理!({1})",
                                    objDataTypeAbbrEN.JavaType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                        }
                    }
                }
            }

            strCodeForCs.AppendFormat("\r\n" + "{0}WS4SD obj{0}WS4SD = new {0}WS4SD(mHandler, \"{1}\",",
                objWebSrvClassENEx.ClsName,
                objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.Append("\r\n" + "mapParam);");
            //strCodeForCs.AppendFormat("obj{0}EN);",
            //    objWebSrvFunctionsENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "Thread mThread = new Thread(obj{0}WS4SD);",
                objWebSrvClassENEx.ClsName);
            strCodeForCs.Append("\r\n" + "mThread.start();");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }



        /// <summary>
        /// 根据关键字获取相应的记录的对象 
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Java_SelfDefWs_handleMessage()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 调用WebService是否完成函数");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns>获取的调用WebService是否完成函数返回的数据</returns>");
            strCodeForCs.Append("\r\n" + "private Handler mHandler = new Handler()");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "public void handleMessage(Message msg)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "Bundle data = null;");

            strCodeForCs.Append("\r\n" + "String strResultValue = \"\";");
            //strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;",
            //    objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "clsResponseData objResponseData = {0}WS4SD.objResponseData;",
                objWebSrvClassENEx.ClsName);

            strCodeForCs.Append("\r\n" + "boolean bolResult;");
            strCodeForCs.Append("\r\n" + "String strMsg = \"\";");
            strCodeForCs.Append("\r\n" + "switch (msg.what)");

            strCodeForCs.Append("\r\n" + "{");
            int intIndex = 50;
            foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
            {
                if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                strCodeForCs.AppendFormat("\r\n" + "case {1}: //\"{0}\":",
                            objWebSrvFunctionsENEx.FunctionName,
                            intIndex);
                strCodeForCs.Append("\r\n" + " //获取传递的数据 ");
                strCodeForCs.Append("\r\n" + " data = msg.getData();");
                //                    int count = data.getInt("COUNT");
                strCodeForCs.Append("\r\n" + "strResultValue = data.getString(\"strResultValue\");");
                strCodeForCs.AppendFormat("\r\n" + " if ({0}WS4SD.objResponseData.errorId >= 2)",
                        objWebSrvClassENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + " objTableObjWS4ControllerDelegate.{1}(objResponseData, \"cls{0}WS4Controller\", \"{2}\");",
                    objWebSrvClassENEx.ClsName,
                   clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
                enumDict4GC_DictKey2.conFinished),
                   objWebSrvFunctionsENEx.FunctionName);

                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.AppendFormat("\r\n" + "else if ({0}WS4SD.objResponseData.errorId == 1)",
                    objWebSrvClassENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "String strInfo = String.format(\"调用{0}函数出错。%s\", {0}WS4SD.objResponseData.faultString);",
                    objWebSrvClassENEx.ClsName);
                strCodeForCs.Append("\r\n" + "objResponseData.faultString = strInfo;");
                strCodeForCs.AppendFormat("\r\n" + " objTableObjWS4ControllerDelegate.{1}(objResponseData, \"{0}WS4Controller\", \"{2}\");",
                     objWebSrvClassENEx.ClsName,
                    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
                    enumDict4GC_DictKey2.conFinished),
                    objWebSrvFunctionsENEx.FunctionName);
                strCodeForCs.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");

                //strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = cls{0}BL.GetObjByJSONStr(strResultValue);",
                //    objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "objResponseData.returnString = strResultValue;");
                //strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{2}(objResponseData, \"{0}\", \"{1}\");",
                //    objWebSrvClassENEx.ClsName, objWebSrvFunctionsENEx.FunctionName,
                //clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
                //enumDict4GC_DictKey2.conFinished));

                strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{2}(strResultValue, \"{0}\", \"{1}\");",
                     objWebSrvClassENEx.ClsName, objWebSrvFunctionsENEx.FunctionName,
                     clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
                     enumDict4GC_DictKey2.conCorrectFinished));

                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "break;");
                intIndex++;
            }

            strCodeForCs.Append("\r\n" + "default:");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "print(strResult);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "};");

            return strCodeForCs.ToString();
        }



        public string Gen_Controller_Java_ByCommonFunction(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {
            string strMsg = "";
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// {0}", objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            //  strCodeForCs.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.AppendFormat("\r\n" + "public void Invoke_{0}(Object vcParentView) ",
                objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "icls{0}_{1} iobj{0}_{1} = new icls{0}_{1}(vcParentView);",
                objWebSrvClassENEx.ClsName, objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.AppendFormat("\r\n" + "iobj{0}_{1}.main();",
                objWebSrvClassENEx.ClsName, objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "public static class icls{0}_{1} extends clsTableObjWS4ControllerDelegate",
                objWebSrvClassENEx.ClsName, objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.Append("\r\n" + "{");

            //strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
            //    objWebSrvClassENEx.TabName);
            strCodeForCs.Append("\r\n" + "public Object vcParent = null;");
            strCodeForCs.AppendFormat("\r\n" + "public icls{0}_{1}(Object pvcParent)",
                    objWebSrvClassENEx.ClsName, objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "vcParent = pvcParent;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "public void main()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "{0}WS4SDController obj{0}WS4SDController = new {0}WS4SDController();",
                objWebSrvClassENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4SDController.objTableObjWS4ControllerDelegate = this;",
                objWebSrvClassENEx.ClsName);

            StringBuilder sbParaList = new StringBuilder();
            StringBuilder sbParaVarList = new StringBuilder();

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
                    strMsg = string.Format("Java函数参数的不接受引用型参数。参数名：[{0}],数据类型：[{1}]没有处理,不能生成相应代码。",
                       objWebSrvFuncParaEN.ParaName,
                         objWebSrvFuncParaEN.ParameterType);
                    throw new Exception(strMsg);
                }
                else
                {
                    if (objDataTypeAbbrEN.IsNeedQuote == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "{0} {1} = \"{2}\";",
                            objDataTypeAbbrEN.JavaType,
                            objWebSrvFuncParaEN.ParaName,
                            "0");
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "{0} {1} = {2};",
                            objDataTypeAbbrEN.JavaType,
                            objWebSrvFuncParaEN.ParaName,
                            "0");
                    }
                    if (objSelfDefDataTypeEN_Para != null)
                    {
                        sbParaList.AppendFormat("{0} {1},",
                            objSelfDefDataTypeEN_Para.JavaType,
                            objWebSrvFuncParaEN.ParaName);
                    }
                    else
                    {
                        sbParaList.AppendFormat("{0} {1},",
                            objDataTypeAbbrEN.JavaType,
                            objWebSrvFuncParaEN.ParaName);
                    }
                    sbParaVarList.AppendFormat("{0},", objWebSrvFuncParaEN.ParaName);
                }
            }
            if (sbParaList.Length > 0)
            {
                sbParaList.Remove(sbParaList.Length - 1, 1);
                sbParaVarList.Remove(sbParaVarList.Length - 1, 1);
            }

            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4SDController.{1}({2});",
                    objWebSrvClassENEx.ClsName,
                    objWebSrvFunctionsENEx.FunctionName,
                    sbParaVarList.ToString());

            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.AppendFormat("\r\n" + "//通过WebService执行函数:[{0}],返回的事件函数,可能需要处理执行错误。",
                objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(clsResponseData objResponseData, String strClassName, String strFunctionName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "clsPubFun.ShowMessage((Activity) vcParent, objResponseData.faultString);",
             objWebSrvClassENEx.ClsName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "//通过WebService执行函数:[{0}],返回的事件函数,这是正确返回,不需要处理执行错误。",
                objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}( String returnString, String strClassName, String strFunctionName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");


            strCodeForCs.Append("\r\n" + "String strInfo = String.format(\"返回值为：[%s]!\", returnString);");
            //strCodeForCs.Append("\r\n" + "tvMsg.setText(strInfo);");
            strCodeForCs.Append("\r\n" + "//显示信息框");
            //  strCodeForCs.Append("\r\n" + "//clsPubFun.myAlert(strInfo, vcObj: vcParent);");
            strCodeForCs.AppendFormat("\r\n" + "clsPubFun.ShowMessage((Activity) vcParent, strInfo);",
                objWebSrvClassENEx.ClsName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");



            return strCodeForCs.ToString();
        }

       
        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(AppViewUTScript_UDF4JAVA);
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
            this.ClsName = string.Format("ac{0}4SD_UTScript", objWebSrvClassENEx.ClsName);
            objWebSrvClassENEx.ClsName = this.ClsName;
        }

       
        public string A_GeneFuncCodeByFuncName(string strFuncName)
        {
            
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBLEx.GetObjByFuncNameCache(strFuncName);
            try
            {
                string strCode = "";
                Type t = typeof(AppViewUTScript_UDF4JAVA);
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
                        strCode = (string)mt.Invoke(this, new object[] { objFunction4GeneCodeEN });
                    }
                    //Console.WriteLine(str);
                }

                return strCode;

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
        /// <summary>
        /// 生成指定的函数
        /// </summary>
        /// <returns>返回生成的指定函数代码</returns>
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
                //string strTemp_ImportClass = GeneCode_ImportClass();
                //if (string.IsNullOrEmpty(strTemp_ImportClass) == false)
                //{
                //    strCodeForCs.Append("\r\n" + strTemp_ImportClass);
                //}
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
