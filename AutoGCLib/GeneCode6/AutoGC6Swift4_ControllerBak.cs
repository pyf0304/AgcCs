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
    partial class AutoGC6_Controller : AutoGCPubFuncV6
    {

      

        /// <summary>
        /// 生成Web Service转换层代码--Swift4Bak
        /// </summary>
        /// <returns></returns>
        public string A_GenController_Swift4Bak_SelfDefWs(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
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
            StringBuilder strBuilder = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp; ///临时变量;


            objWebSrvClassENEx.ClsName = "vc" + objWebSrvClassENEx.ClsName;
            //objWebSrvClassENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objWebSrvClassENEx.SimpleFileName = objWebSrvClassENEx.ClsName + ".swift";
            strRe_ClsName = objWebSrvClassENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objWebSrvClassENEx.FuncModuleAgcId, objWebSrvClassENEx.PrjId);

            string strIsShare = objPrjTabENEx.IsShare == true ? "_Share" : "";
            strRe_FileNameWithModuleName = string.Format("{0}{2}\\{1}", objFuncModule.FuncModuleEnName4GC(), objPrjTabENEx.SimpleFileName, strIsShare);

            strClassFName = objWebSrvClassENEx.FolderName + objWebSrvClassENEx.ClsName + ".swift";

            objWebSrvClassENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objWebSrvClassENEx.PrjId); //
            try
            {
                //类名开始

                strBuilder.Append(clsPubFun4GC.GenUserInfoAndDate(objWebSrvClassENEx.CurrUserName, objWebSrvClassENEx));



                strBuilder.AppendFormat("\r\n" + "import UIKit;",
                      objProjectsENEx.JavaPackageName);


                strBuilder.Append("\r\n" + ""); //

                strBuilder.Append("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// {0}({1})",
                    objWebSrvClassENEx.ClsName,
                    objWebSrvClassENEx.PageName);

                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.Append("\r\n" + "/**");
                strBuilder.AppendFormat("\r\n" + "* Created by {0} on {1}.",
                    objWebSrvClassENEx.CurrUserName,
                    clsDateTime.getTodayStr(3));
                strBuilder.AppendFormat("\r\n" + "* 注意:该类必须与调用界面处于同一个包,否则调用不成功!", objWebSrvClassENEx.CurrUserName, clsDateTime.getTodayStr(3));
                strBuilder.Append("\r\n" + " **/");
                strBuilder.AppendFormat("\r\n" + "class vc{0} : UIViewController",
                    objWebSrvClassENEx.ClsName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "@IBOutlet weak var lblResult: UILabel!");
                strBuilder.Append("\r\n" + "@IBOutlet weak var txtResult: UITextField!");


                strBuilder.Append("\r\n" + "override func viewDidLoad()");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "super.viewDidLoad()");

                strBuilder.Append("\r\n" + "// Do any additional setup after loading the view.");
                strBuilder.Append("\r\n" + "}");

                strBuilder.Append("\r\n" + "override func didReceiveMemoryWarning()");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "super.didReceiveMemoryWarning()");
                strBuilder.Append("\r\n" + "// Dispose of any resources that can be recreated.");
                strBuilder.Append("\r\n" + "}");

                //生成所有的函数

                foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
                {
                    if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                    try
                    {
                        strTemp = Gen_Controller_Swift4Bak_ByCommonFunction(objWebSrvFunctionsENEx);
                        if (string.IsNullOrEmpty(strTemp) == false)
                        {
                            strBuilder.Append("\r\n" + strTemp);
                            clsWebSrvFunctionsBLEx.SetGeneCode(objWebSrvFunctionsENEx.WebSrvFunctionId, true);
                        }
                        else
                        {
                            strTemp = string.Format("//该函数：[{0}]无法生成.", objWebSrvFunctionsENEx.FunctionSignature);
                            strBuilder.Append("\r\n" + strTemp);
                        }
                    }
                    catch (Exception objException)
                    {
                        strTemp = string.Format("//该函数：[{0}]无法生成.错误:[{1}]({2}->{3})",
                            objWebSrvFunctionsENEx.FunctionSignature,
                            objException.Message,
                            clsStackTrace.GetCurrClassFunctionByLevel(2),
                            clsStackTrace.GetCurrClassFunction());
                        strBuilder.Append("\r\n" + strTemp);
                    }
                }

                strBuilder.Append("\r\n" + "}");


            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strBuilder.ToString();
        }

       
        /// <summary>
        /// 生成Web Service转换层代码--Swift2
        /// </summary>
        /// <returns></returns>
        public string A_GenTableObjWSController_Swift4Bak_SelfDefWs(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            objWebSrvClassENEx.CurrDate = clsDateTime.getTodayStr2(0);

            //让用户设置属性;
            //string strFolder;
            string strClassFName;
            StringBuilder strBuilder = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp; ///临时变量;
           

            objWebSrvClassENEx.ClsName = string.Format("{0}WS4Controller", objWebSrvClassENEx.ClsName);
            //objWebSrvClassENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objWebSrvClassENEx.SimpleFileName = objWebSrvClassENEx.ClsName + ".swift";
            strRe_ClsName = objWebSrvClassENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objWebSrvClassENEx.FuncModuleAgcId, objWebSrvClassENEx.PrjId);
            
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName( objFuncModule, objPrjTabENEx);
            strClassFName = objWebSrvClassENEx.FolderName + objWebSrvClassENEx.ClsName + ".swift";

            objWebSrvClassENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objWebSrvClassENEx.PrjId); //
            try
            {
                //类名开始
                strBuilder.Append(clsPubFun4GC.GenUserInfoAndDate(objWebSrvClassENEx.CurrUserName, objWebSrvClassENEx));
                strBuilder.AppendFormat("\r\n" + "import UIKit;",
                      objProjectsENEx.JavaPackageName);

                strBuilder.Append("\r\n" + ""); //
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// {0}({1})",
                    objWebSrvClassENEx.ClsName,
                    objWebSrvClassENEx.PageName);

                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.Append("\r\n" + "/**");
                strBuilder.AppendFormat("\r\n" + "* Created by {0} on {1}.",
                    objWebSrvClassENEx.CurrUserName,
                    clsDateTime.getTodayStr(3));
                strBuilder.AppendFormat("\r\n" + "* 注意:该类必须与调用界面处于同一个包,否则调用不成功!", objWebSrvClassENEx.CurrUserName, clsDateTime.getTodayStr(3));
                strBuilder.Append("\r\n" + " **/");
                strBuilder.AppendFormat("\r\n" + "public class  {0} : NSObject",
                       objWebSrvClassENEx.ClsName);
                strBuilder.Append("\r\n" + "{");

                strBuilder.Append("\r\n" + "const objTableObjWS4ControllerDelegate : clsTableObjWS4ControllerDelegate?;");

                strBuilder.Append("\r\n" + "const queue : OperationQueue!");

                strBuilder.Append("\r\n" + "const theTimer: Timer!");
                strBuilder.Append("\r\n" + "override init()");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "super.init();");
                strBuilder.Append("\r\n" + "queue = OperationQueue();");

                strBuilder.Append("\r\n" + "}");
                strBuilder.AppendFormat("\r\n" + "init(strMethod : String, mapParam : Dictionary<String, String>)",
                    objWebSrvClassENEx.ClsName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "super.init();");
                strBuilder.Append("\r\n" + "queue = OperationQueue();");
                strBuilder.Append("\r\n" + "}");

                //生成所有的函数
                foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
                {
                    if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                    try
                    {
                        strTemp = Gen_4WS4Controller_Swift4Bak_ByCommonFunction(objWebSrvFunctionsENEx);
                        if (string.IsNullOrEmpty(strTemp) == false)
                        {
                            strBuilder.Append("\r\n" + strTemp);
                            clsWebSrvFunctionsBLEx.SetGeneCode(objWebSrvFunctionsENEx.WebSrvFunctionId, true);
                        }
                        else
                        {
                            strTemp = string.Format("//该函数：[{0}]无法生成.", objWebSrvFunctionsENEx.FunctionSignature);
                            strBuilder.Append("\r\n" + strTemp);
                        }
                    }
                    catch (Exception objException)
                    {
                        strTemp = string.Format("//该函数：[{0}]无法生成.错误:[{1}]({2}->{3})",
                            objWebSrvFunctionsENEx.FunctionSignature,
                            objException.Message,
                            clsStackTrace.GetCurrClassFunctionByLevel(2),
                            clsStackTrace.GetCurrClassFunction());
                        strBuilder.Append("\r\n" + strTemp);
                    }
                }
                //strTemp = A_GeneFuncCode_Swift4Bak("Gen_4WS4Controller_Swift4Bak_SelfDefWs_IsFinished4WebService");
                //strBuilder.Append("\r\n" + strTemp);
              
                strBuilder.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strBuilder.ToString();
        }



        /// <summary>
        /// 根据关键字获取相应的记录的对象 
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Swift4Bak_GetRecordObjByKey()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据关键字获取相应的记录的对象");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">关键字的值</param>",
                objKeyField.PrivFuncName);
            strBuilder.Append("\r\n /// <returns>根据关键字获取的对象</returns>");
            strBuilder.AppendFormat("\r\n" + "public func GetObjBy{1}({2}: {3})",
                objPrjTabENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName,
                objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const values :  Dictionary < String, String > = Dictionary<String, String>();");

            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
            {
                strBuilder.AppendFormat("\r\n" + "values[\"{0}\"] = {0};",
                    objKeyField.PrivFuncName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "values[\"{0}\"] = String({0});",
                    objKeyField.PrivFuncName);
            }

            strBuilder.AppendFormat("\r\n" + "let obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "let obj{0}WS : cls{0}WS = cls{0}WS(strMethod: \"GetJSONObjBy{1}\",",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.Append("\r\n" + "mapParam: values,");
            strBuilder.AppendFormat("\r\n" + "pobj{0}EN: obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "queue.addOperation(obj{0}WS);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "theTimer = Timer.scheduledTimer(timeInterval: 0.1, target: self, selector: #selector(IsFinished4WebService), userInfo: nil, repeats: true);");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }


        public string Gen_4WS4Controller_Swift4Bak_GetFirstJSONObj()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取相应的第一条记录的对象");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">条件</strWhereCond>");
            strBuilder.Append("\r\n /// <returns>获取相应的记录的对象</returns>");
            strBuilder.AppendFormat("\r\n" + "public func GetFirst{0}(strWhereCond: String)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const values :  Dictionary < String, String > = Dictionary<String, String>();");
            strBuilder.Append("\r\n" + "values[\"strWhereCond\"] = strWhereCond;");
            strBuilder.AppendFormat("\r\n" + "let obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "let obj{0}WS : cls{0}WS = cls{0}WS(strMethod: \"GetFirstJSONObj\",",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "mapParam: values,");
            strBuilder.AppendFormat("\r\n" + "pobj{0}EN: obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "queue.addOperation(obj{0}WS);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "theTimer = Timer.scheduledTimer(timeInterval: 0.1, target: self, selector: #selector(IsFinished4WebService), userInfo: nil, repeats: true);");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }
        public string Gen_4WS4Controller_Swift4Bak_ByCommonFunction(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {
            string strMsg = "";
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取相应的第一条记录的对象");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");

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
                    strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">引用型参数,返回:{1}</param>",
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
                    strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">{1}</param>",
                        objWebSrvFuncParaEN.ParaName, objWebSrvFuncParaEN.ParaCnName);
                    if (objSelfDefDataTypeEN_Para != null)
                    {
                        sbParaList.AppendFormat("{1}: {0},",
                            objSelfDefDataTypeEN_Para.SwiftType,
                            objWebSrvFuncParaEN.ParaName);
                    }
                    else
                    {
                        sbParaList.AppendFormat("{1}: {0},",
                            objDataTypeAbbrEN.SwiftType,
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
            strBuilder.AppendFormat("\r\n /// <returns>返回{0}</returns>",
                    objWebSrvFunctionsENEx.ReturnValueDescription);

            strBuilder.AppendFormat("\r\n" + "public func {0}({1})",
                objWebSrvFunctionsENEx.FunctionName, sbParaList.ToString());
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const values :  Dictionary < String, String > = Dictionary<String, String>();");
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
                    strMsg = string.Format("Swift函数参数的不接受引用型参数。参数名：[{0}],数据类型：[{1}]没有处理,不能生成相应代码。",
                        objWebSrvFuncParaEN.ParaName,
                          objWebSrvFuncParaEN.ParameterType);
                    throw new Exception(strMsg);

                    //if (objDataTypeAbbrEN.IsNeedQuote == true)
                    //{
                    //    strBuilder.AppendFormat("\r\n" + "mapParam.put(\"{0}\", {0});",
                    //        objWebSrvFuncParaEN.ParaName);
                    //}
                    //else
                    //{
                    //    strBuilder.AppendFormat("\r\n" + "mapParam.put(\"{0}\", {0}.toString());",
                    //        objWebSrvFuncParaEN.ParaName);
                    //}
                }
                else
                {
                    if (objDataTypeAbbrEN.IsNeedQuote == true)
                    {
                        strBuilder.AppendFormat("\r\n" + "values[\"{0}\"] = {0};",
                                objWebSrvFuncParaEN.ParaName);
                    }
                    else
                    {
                        switch (objDataTypeAbbrEN.SwiftType)
                        {
                            case "Int":
                                strBuilder.AppendFormat("\r\n" + "values[\"{0}\"] = String({0});",
                                        objWebSrvFuncParaEN.ParaName);
                                //strBuilder.AppendFormat("\r\n" + "mapParam.put(\"{0}\", Integer.toString({0}));",
                                //    objWebSrvFuncParaEN.ParaName);
                                break;
                            default:
                                strMsg = string.Format("Swift类型：[{0}]没有在函数中被处理!({1})",
                                    objDataTypeAbbrEN.SwiftType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                        }
                    }
                }
            }
            //strBuilder.Append("\r\n" + "values[\"strWhereCond\"] = strWhereCond;");

            strBuilder.AppendFormat("\r\n" + "let obj{0}WS : {0}WS = {0}WS(strMethod: \"{1}\",",
                objWebSrvClassENEx.ClsName,
                objWebSrvFunctionsENEx.FunctionName);
            strBuilder.Append("\r\n" + "mapParam: values);");
            //strBuilder.AppendFormat("\r\n" + "pobj{0}EN: obj{0}EN);",
            //    objWebSrvFunctionsENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "queue.addOperation(obj{0}WS);",
                objWebSrvClassENEx.ClsName);
            strBuilder.Append("\r\n" + "theTimer = Timer.scheduledTimer(timeInterval: 0.1, target: self, selector: #selector(IsFinished4WebService), userInfo: nil, repeats: true);");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }


        public string Gen_Controller_Swift4Bak_btnGetJSONObjByKey_Click()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据关键字获取相应的记录的对象");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">参数列表</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "@IBAction func btnGetJSONObjByKey_Click(_ sender: Any) ",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "let iobj{0}GetObjBy{1} : icls{0}GetObjBy{1} = icls{0}GetObjBy{1}(pvcParent: self);",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetObjBy{1}.main();",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "class icls{0}GetObjBy{1} : NSObject, clsTableObjWS4ControllerDelegate",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const vcParent : UIViewController;");
            strBuilder.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "init(pvcParent : UIViewController)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "vcParent = pvcParent;");
            strBuilder.Append("\r\n" + "super.init();");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "func main()");
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
            {
                strBuilder.AppendFormat("\r\n" + "let {0} : {1} = \"{2}\";",
                    objKeyField.PrivFuncName,
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType,
                    objKeyField.ObjFieldTabENEx.DefaultValue4Test_Swift);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "let {0} : {1} = {2};",
                    objKeyField.PrivFuncName,
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType,
                    objKeyField.ObjFieldTabENEx.DefaultValue4Test_Swift);
            }
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.GetObjBy{1}({2}: {2});",
                objPrjTabENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//通过WebService执行GetRecordObjByKey,返回的事件函数,可能需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjByKey,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//通过WebService执行GetRecordObjByKey,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "func {0}(returnObject: NSObject, strClassName: String)",
                 clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjByKey,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let obj{0}EN : cls{0}EN = returnObject as!cls{0}EN;",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "let strInfo : String = \"根据关键字’01‘ 获取对象：\\(obj{0}EN.{1})!\"",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");

            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_Swift4Bak_btnGetFirstJSONObj_Click()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取相应的第一条记录的对象");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.Append("\r\n" + "@IBAction func btnGetFirstJSONObj_Click(_ sender: Any) {");

            strBuilder.AppendFormat("\r\n" + "let iobj{0}GetFirstObj : icls{0}GetFirstObj = icls{0}GetFirstObj(pvcParent: self);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetFirstObj.main();",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "class icls{0}GetFirstObj : NSObject, clsTableObjWS4ControllerDelegate",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const vcParent : UIViewController;");
            strBuilder.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "init(pvcParent : UIViewController)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "vcParent = pvcParent;");
            strBuilder.Append("\r\n" + "super.init();");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "func main()");
            strBuilder.Append("\r\n" + "{");


            strBuilder.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "let strWhereCond : String = \" 1=1 \";");
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.GetFirst{0}(strWhereCond: strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//通过WebService执行GetFirstJSONObj,返回的事件函数,可能需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetFirstJSONObj,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//通过WebService执行GetFirstJSONObj,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "func {0}(returnObject: NSObject, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetFirstJSONObj,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let obj{0}EN : cls{0}EN = returnObject as!cls{0}EN;",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "let strInfo : String = \"根据条件：‘1=1’ 获取第一个记录对象：\\(obj{0}EN.{1})!\"",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");


            strBuilder.Append("\r\n" + "};");


            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_Swift4Bak_ByCommonFunction(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 调用函数：[{0}]", objWebSrvFunctionsENEx.FunctionName);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "@IBAction func Invoke_{0}() ",
                objWebSrvFunctionsENEx.FunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let iobj{0} : icls{0} = icls{0}(pvcParent: self);",
                objWebSrvFunctionsENEx.FunctionName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}.main();",
                objWebSrvFunctionsENEx.FunctionName);

            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "class icls{0} : NSObject, clsTableObjWS4ControllerDelegate",
                objWebSrvFunctionsENEx.FunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const vcParent : UIViewController;");
            //strBuilder.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN = cls{0}EN();",
            //    objWebSrvFunctionsENEx.TabName);

            strBuilder.Append("\r\n" + "init(pvcParent : UIViewController)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "vcParent = pvcParent;");
            strBuilder.Append("\r\n" + "super.init();");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "func main()");
            strBuilder.Append("\r\n" + "{");


            strBuilder.AppendFormat("\r\n" + "let obj{0}WS4Controller : {0}WS4Controller = {0}WS4Controller();",
                objWebSrvClassENEx.ClsName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objWebSrvClassENEx.ClsName);
            string strMsg = "";
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
                    strMsg = string.Format("Swift函数参数的不接受引用型参数。参数名：[{0}],数据类型：[{1}]没有处理,不能生成相应代码。",
                       objWebSrvFuncParaEN.ParaName,
                         objWebSrvFuncParaEN.ParameterType);
                    throw new Exception(strMsg);
                }
                else
                {
                    if (objDataTypeAbbrEN.IsNeedQuote == true)
                    {
                        strBuilder.AppendFormat("\r\n" + " let {1} : {0} = \"{2}\";",
                            objDataTypeAbbrEN.SwiftType,
                            objWebSrvFuncParaEN.ParaName,
                            "0");
                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n" + " let {1} : {0} = {2};",
                            objDataTypeAbbrEN.SwiftType,
                            objWebSrvFuncParaEN.ParaName,
                            "0");
                    }
                    if (objSelfDefDataTypeEN_Para != null)
                    {
                        sbParaList.AppendFormat("{0} {1},",
                            objSelfDefDataTypeEN_Para.SwiftType,
                            objWebSrvFuncParaEN.ParaName);
                    }
                    else
                    {
                        sbParaList.AppendFormat("{0} {1},",
                            objDataTypeAbbrEN.SwiftType,
                            objWebSrvFuncParaEN.ParaName);
                    }
                    sbParaVarList.AppendFormat("{0}: {0},", objWebSrvFuncParaEN.ParaName);
                }
            }
            if (sbParaList.Length > 0)
            {
                sbParaList.Remove(sbParaList.Length - 1, 1);
                sbParaVarList.Remove(sbParaVarList.Length - 1, 1);
            }

            //  strBuilder.Append("\r\n" + "let strWhereCond : String = \" 1=1 \";");
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.{1}({2});",
                objWebSrvClassENEx.ClsName,
                objWebSrvFunctionsENEx.FunctionName,
                sbParaVarList.ToString());
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "//通过WebService执行{0},返回的事件函数,可能需要处理执行错误。",
                objWebSrvFunctionsENEx.FunctionName);
            strBuilder.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String, strFunctionName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "clsPubFun.myAlert(strInfo: objResponseData.faultString, vcObj: vcParent);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "//通过WebService执行函数:[{0}],返回的事件函数,这是正确返回,不需要处理执行错误。",
                objWebSrvFunctionsENEx.FunctionName);
            strBuilder.AppendFormat("\r\n" + "func {0}(strResult: String, strClassName: String, strFunctionName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "let obj{0}EN : cls{0}EN = returnObject as!cls{0}EN;",
            //    objWebSrvFunctionsENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "let strInfo : String = \"函数:[{0}]返回值为：\\(strResult)!\"",
                objWebSrvFunctionsENEx.FunctionName);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");


            strBuilder.Append("\r\n" + "};");


            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// 根据条件获取相应的记录对象列表 
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Swift4Bak_GetJSONObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取相应的记录对象列表");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">条件</strWhereCond>");
            strBuilder.Append("\r\n /// <returns>获取相应的记录的对象</returns>");
            strBuilder.AppendFormat("\r\n" + "public func GetJSONObjLst(strWhereCond: String)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const values :  Dictionary < String, String > = Dictionary<String, String>();");
            strBuilder.AppendFormat("\r\n" + "values[\"strWhereCond\"] = strWhereCond;");
            strBuilder.AppendFormat("\r\n" + "let obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "let obj{0}WS : cls{0}WS = cls{0}WS(strMethod: \"GetJSONObjLst\",",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "mapParam: values,");
            strBuilder.AppendFormat("\r\n" + "pobj{0}EN: obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "queue.addOperation(obj{0}WS);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "theTimer = Timer.scheduledTimer(timeInterval: 0.1, target: self, selector: #selector(IsFinished4WebService), userInfo: nil, repeats: true);");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// 根据条件获取相应的记录对象列表 
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Swift4Bak_GetTopJSONObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取相应的记录对象列表");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"intTopSize\">顶部记录数</strWhereCond>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">条件</strWhereCond>");
            strBuilder.Append("\r\n /// <returns>获取相应的记录的对象</returns>");
            strBuilder.AppendFormat("\r\n" + "public func GetTopJSONObjLst(intTopSize: Int, strWhereCond: String)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const values :  Dictionary < String, String > = Dictionary<String, String>();");
            strBuilder.AppendFormat("\r\n" + "values[\"intTopSize\"] = String(intTopSize);");
            strBuilder.AppendFormat("\r\n" + "values[\"strWhereCond\"] = strWhereCond;");
            strBuilder.AppendFormat("\r\n" + "let obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "let obj{0}WS : cls{0}WS = cls{0}WS(strMethod: \"GetTopJSONObjLst\",",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "mapParam: values,");
            strBuilder.AppendFormat("\r\n" + "pobj{0}EN: obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "queue.addOperation(obj{0}WS);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "theTimer = Timer.scheduledTimer(timeInterval: 0.1, target: self, selector: #selector(IsFinished4WebService), userInfo: nil, repeats: true);");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }



        public string Gen_Controller_Swift4Bak_btnGetJSONObjLst_Click()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取相应的对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "@IBAction func btnGetJSONObjLst_Click(_ sender: Any) ",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let iobj{0}GetJSONObjLst : icls{0}GetJSONObjLst = icls{0}GetJSONObjLst(pvcParent: self);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetJSONObjLst.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "class icls{0}GetJSONObjLst : NSObject, clsTableObjWS4ControllerDelegate",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const vcParent : UIViewController;");
            strBuilder.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "init(pvcParent : UIViewController)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "vcParent = pvcParent;");
            strBuilder.Append("\r\n" + "super.init();");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "func main()");
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "let strWhereCond : String = \" 1=1 \";");
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.GetJSONObjLst(strWhereCond: strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行GetRecordObjLst,返回的事件函数,可能需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLst, enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行GetRecordObjLst,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "func {0}(returnObjectList: NSObject, strClassName: String)",
                                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLst, enumDict4GC_DictKey2.conCorrectFinished));
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let arr{0}ObjLst : Array < cls{0}EN > = returnObjectList as!Array<cls{0}EN>;",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "let strInfo : String = \"共获取对象列表数：\\(arr{0}ObjLst.count)!\"",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strBuilder.Append("\r\n" + "};");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }


        public string Gen_Controller_Swift4Bak_btnGetTopJSONObjLst_Click()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取相应的顶部多条对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "@IBAction func btnGetTop{0}JSONObjLst_Click(_ sender: Any) ",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let iobj{0}GetTopJSONObjLst : icls{0}GetTopJSONObjLst = icls{0}GetTopJSONObjLst(pvcParent: self);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetTopJSONObjLst.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "class icls{0}GetTopJSONObjLst : NSObject, clsTableObjWS4ControllerDelegate",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const vcParent : UIViewController;");
            strBuilder.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "init(pvcParent : UIViewController)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "vcParent = pvcParent;");
            strBuilder.Append("\r\n" + "super.init();");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "func main()");
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "let intTopSize : Int = 2;");
            strBuilder.Append("\r\n" + "let strWhereCond : String = \" 1=1 \";");
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.GetTopJSONObjLst(intTopSize: intTopSize, strWhereCond: strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行GetTopRecordObjLst,返回的事件函数,可能需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetTopRecordJSONObjLst, enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行GetRecordObjLst,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "func {0}(returnObjectList: NSObject, strClassName: String)",
                                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetTopRecordJSONObjLst, enumDict4GC_DictKey2.conCorrectFinished));
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let arr{0}ObjLst : Array < cls{0}EN > = returnObjectList as!Array<cls{0}EN>;",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "let strInfo : String = \"共获取对象列表数：\\(arr{0}ObjLst.count)!\"",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strBuilder.Append("\r\n" + "};");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }


        /// <summary>
        /// 根据关键字获取相应的记录的对象 
        /// </summary>
        /// <returns></returns>
        public string Gen_Controller_Swift4Bak_btnIsExistRecord_Click()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 检查相应关键字的记录是否存在");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">发送者</param>");
            strBuilder.Append("\r\n /// <returns>返回是否存在</returns>");

            strBuilder.Append("\r\n" + "@IBAction func btnIsExistRecord_Click(_ sender: Any) {");


            strBuilder.Append("\r\n" + "let iobjIsExistRecord : iclsIsExistRecord = iclsIsExistRecord(pvcParent: self);");
            strBuilder.Append("\r\n" + "iobjIsExistRecord.main();");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "class iclsIsExistRecord : NSObject, clsTableObjWS4ControllerDelegate");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const vcParent : UIViewController;");
            strBuilder.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);


            strBuilder.Append("\r\n" + "init(pvcParent : UIViewController)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "vcParent = pvcParent;");
            strBuilder.Append("\r\n" + "super.init();");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "func main()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "let strWhereCond : String = \"{0} ='12'\";",
                objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.IsExistRecord(strWhereCond: strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行IsExistRecord,返回的事件函数,可能需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord, enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行IsExistRecord,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "func {0}(returnBool: Bool, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conCorrectFinished));
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "switch strClassName {");
            strBuilder.AppendFormat("\r\n" + "case \"cls{0}WS4Controller\":",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "if (returnBool == false)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let strInfo : String = \"根据条件：‘{0}='12'’ 不存在!\"",
                objKeyField.FldName);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let strInfo : String = \"根据条件：‘{0}='12'’ 存在!\"",
                objKeyField.FldName);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
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
        public string Gen_4WS4Controller_Swift4Bak_IsExistRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件在表中检查是否满足条件的记录");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">检查存在的条件</param>");
            strBuilder.Append("\r\n /// <returns>存在返回true,不存在返回：false</returns>");
            strBuilder.Append("\r\n" + "public func IsExistRecord(strWhereCond : String)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const values :  Dictionary < String, String > = Dictionary<String, String>();");
            strBuilder.Append("\r\n" + "values[\"strWhereCond\"] = strWhereCond;");
            strBuilder.AppendFormat("\r\n" + "let obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "let obj{0}WS : cls{0}WS = cls{0}WS(strMethod: \"IsExistRecord\",",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "mapParam: values,");
            strBuilder.AppendFormat("\r\n" + "pobj{0}EN: obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "queue.addOperation(obj{0}WS);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "theTimer = Timer.scheduledTimer(timeInterval: 0.1, target: self, selector: #selector(IsFinished4WebService), userInfo: nil, repeats: true);");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Swift4Bak_GetMaxStrId()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            //    strBuilder.Append("\r\n /// <param name = \"strWhereCond\">检查存在的条件</param>");
            strBuilder.Append("\r\n /// <returns>当前表关键字值的最大值,再加1</returns>");
            strBuilder.Append("\r\n" + "public func GetMaxStrId()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "let values :  Dictionary < String, String > = Dictionary<String, String>();");
            //    strBuilder.Append("\r\n" + "values[\"strWhereCond\"] = strWhereCond;");
            strBuilder.AppendFormat("\r\n" + "let obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "let obj{0}WS : cls{0}WS = cls{0}WS(strMethod: \"GetMaxStrId\",",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "mapParam: values,");
            strBuilder.AppendFormat("\r\n" + "pobj{0}EN: obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "queue.addOperation(obj{0}WS);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "theTimer = Timer.scheduledTimer(timeInterval: 0.1, target: self, selector: #selector(IsFinished4WebService), userInfo: nil, repeats: true);");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Swift4Bak_GetMaxStrIdByPrefix()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strPrefix\">关键字值的前缀</param>");
            strBuilder.Append("\r\n /// <returns>当前表关键字值的最大值,再加1</returns>");
            strBuilder.Append("\r\n" + "public func GetMaxStrIdByPrefix(strPrefix : String)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const values :  Dictionary < String, String > = Dictionary<String, String>();");
            strBuilder.Append("\r\n" + "values[\"strPrefix\"] = strPrefix;");
            strBuilder.AppendFormat("\r\n" + "let obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "let obj{0}WS : cls{0}WS = cls{0}WS(strMethod: \"GetMaxStrIdByPrefix\",",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "mapParam: values,");
            strBuilder.AppendFormat("\r\n" + "pobj{0}EN: obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "queue.addOperation(obj{0}WS);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "theTimer = Timer.scheduledTimer(timeInterval: 0.1, target: self, selector: #selector(IsFinished4WebService), userInfo: nil, repeats: true);");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// 根据关键字获取相应的记录的对象 
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Swift4Bak_IsFinished4WebService()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 调用WebService是否完成函数");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>获取的调用WebService是否完成函数返回的数据</returns>");
            strBuilder.Append("\r\n" + "func IsFinished4WebService()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "if (cls{0}WS.ResponseData.IsFinished == true)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "theTimer.invalidate();");
            strBuilder.AppendFormat("\r\n" + "let objResponseData : clsResponseData = clsResponseData(structResponseData: cls{0}WS.ResponseData);",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "let strResult = cls{0}WS.ResponseData.data;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "switch cls{0}WS.ResponseData.what ",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "case 1: //\"GetObjBy{1}\":",
                objPrjTabENEx.TabName,
                objKeyField.FldName);

            strBuilder.AppendFormat("\r\n" + "if (cls{0}WS.ResponseData.errorId > 0)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let strInfo : String = \"获取对象不成功!调用GetObjBy{1}函数出错。\\(cls{0}WS.ResponseData.faultString)\";",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.Append("\r\n" + "clsPubFun.myAlertIOS7(strInfo: strInfo);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = cls{0}BL.GetObjByJSONStr(strJSON: strResult!);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "objResponseData.returnObject = obj{0}EN;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjByKey,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate!.{2}!(returnObject: obj{0}EN, strClassName: \"{1}\");",
                 objPrjTabENEx.TabName,
                 objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjByKey,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "return;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "break;");
            strBuilder.AppendFormat("\r\n" + "case 2: //\"GetJSONObjLst\":",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "if (cls{0}WS.ResponseData.errorId > 0)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let strInfo : String = \"获取对象列表不成功!调用GetJSONObjLst函数出错。\\(cls{0}WS.ResponseData.faultString)\";",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "clsPubFun.myAlertIOS7(strInfo: strInfo);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const arr{0}ObjLst : Array < cls{0}EN > = Array<cls{0}EN>();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLst = cls{0}BL.GetObjLstByJSONStr(strJSON: strResult!);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "objResponseData.returnObjectList = arr{0}ObjLst as NSObject;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.GetRecordJSONObjLstFinished!(objResponseData: objResponseData, strClassName: \"{0}\");", objPrjTabENEx.ClsName);
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate!.GetRecordJSONObjLstCorrectFinished!(returnObjectList: arr{0}ObjLst as NSObject, strClassName: \"{1}\");",
                    objPrjTabENEx.TabName,
                 objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "return;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "break;");
            strBuilder.AppendFormat("\r\n" + "case 22: //\"GetTopJSONObjLst\":",
    objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "if (cls{0}WS.ResponseData.errorId > 0)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let strInfo : String = \"获取顶对象列表不成功!调用GetTopJSONObjLst函数出错。\\(cls{0}WS.ResponseData.faultString)\";",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "clsPubFun.myAlertIOS7(strInfo: strInfo);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const arr{0}ObjLst : Array < cls{0}EN > = Array<cls{0}EN>();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLst = cls{0}BL.GetObjLstByJSONStr(strJSON: strResult!);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "objResponseData.returnObjectList = arr{0}ObjLst as NSObject;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.GetTopRecordJSONObjLstFinished!(objResponseData: objResponseData, strClassName: \"{0}\");", objPrjTabENEx.ClsName);
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate!.GetTopRecordJSONObjLstCorrectFinished!(returnObjectList: arr{0}ObjLst as NSObject, strClassName: \"{1}\");",
                    objPrjTabENEx.TabName,
                 objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "return;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "break;");

            strBuilder.Append("\r\n" + "case 3: //\"AddNewRecord\":");
            strBuilder.AppendFormat("\r\n" + "if (cls{0}WS.ResponseData.errorId > 0)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "");
            strBuilder.AppendFormat("\r\n" + "let strInfo : String = \"添加不成功,调用AddNewRecord函数出错。\\(cls{0}WS.ResponseData.faultString)\";",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "clsPubFun.myAlertIOS7(strInfo: strInfo);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "let bolResult : Bool = clsPubFun.myBool(myObj: strResult as AnyObject);");
            strBuilder.Append("\r\n" + "objResponseData.returnBool = bolResult;");

            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.AddNewRecordByJSONFinished!(objResponseData: objResponseData, strClassName: \"{0}\");",
                objPrjTabENEx.ClsName);
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate!.AddNewRecordByJSONCorrectFinished!(returnBool: bolResult, strClassName: \"{0}\");",
                objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "return;");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "break;");
            strBuilder.Append("\r\n" + "case 4: //\"UpdateRecord\":");
            strBuilder.AppendFormat("\r\n" + "if (cls{0}WS.ResponseData.errorId > 0)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "let strInfo : String = \"修改不成功!调用UpdateRecord函数出错。\\(cls{0}WS.ResponseData.faultString)\";",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "clsPubFun.myAlertIOS7(strInfo: strInfo);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "let bolResult : Bool = clsPubFun.myBool(myObj: strResult as AnyObject);");
            strBuilder.Append("\r\n" + "objResponseData.returnBool = bolResult;");

            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.UpdateRecordByJSONFinished!(objResponseData: objResponseData, strClassName: \"{0}\");",
                objPrjTabENEx.ClsName);

            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate!.UpdateRecordByJSONCorrectFinished!(returnBool: bolResult, strClassName: \"{0}\");",
                objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "return;");

            strBuilder.Append("\r\n" + "}");


            strBuilder.Append("\r\n" + "break;");
            strBuilder.Append("\r\n" + "case 5: //\"DelRecord\":");

            strBuilder.AppendFormat("\r\n" + "if (cls{0}WS.ResponseData.errorId > 0)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let strInfo : String = \"删除不成功!调用DelRecord函数出错。\\(cls{0}WS.ResponseData.faultString)\";",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "clsPubFun.myAlertIOS7(strInfo: strInfo);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "let bolResult : Bool = clsPubFun.myBool(myObj: strResult as AnyObject);");
            strBuilder.Append("\r\n" + "objResponseData.returnBool = bolResult;");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conDelRecord,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate!.{1}!(returnBool: bolResult, strClassName: \"{0}\");",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conDelRecord,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "return;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "break;");
            strBuilder.AppendFormat("\r\n" + "case 6: //\"GetFirst{0}\":",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "if (cls{0}WS.ResponseData.errorId > 0)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let strInfo : String = \"获取第一条记录不成功!调用GetFirst{0}函数出错。\\(cls{0}WS.ResponseData.faultString)\";",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "clsPubFun.myAlertIOS7(strInfo: strInfo);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = cls{0}BL.GetObjByJSONStr(strJSON: strResult!);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "objResponseData.returnObject = obj{0}EN;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "//通过WebService执行GetFirstJSONObj,返回的事件函数,可能需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetFirstJSONObj,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "//通过WebService执行GetFirstJSONObj,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate!.{2}!(returnObject: obj{0}EN, strClassName: \"{1}\");",
                 objPrjTabENEx.TabName,
                 objPrjTabENEx.ClsName,
                 clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetFirstJSONObj,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "return;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "break;");
            strBuilder.Append("\r\n" + "case 7: //\"IsExistRecord\":");
            strBuilder.AppendFormat("\r\n" + "if (cls{0}WS.ResponseData.errorId > 0)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let strInfo : String = \"调用IsExistRecord函数出错。\\(cls{0}WS.ResponseData.faultString)\";",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "clsPubFun.myAlertIOS7(strInfo: strInfo);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "let bolResult : Bool = clsPubFun.myBool(myObj: strResult as AnyObject);");
            strBuilder.Append("\r\n" + "objResponseData.returnBool = bolResult;");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate!.{1}!(returnBool: bolResult, strClassName: \"{0}\");",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "return;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "break;");

            strBuilder.Append("\r\n" + "case 8: //\"GetMaxStrId\":");
            strBuilder.AppendFormat("\r\n" + "if (cls{0}WS.ResponseData.errorId > 0)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let strInfo : String = \"调用GetMaxStrId函数出错。\\(cls{0}WS.ResponseData.faultString)\";",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "clsPubFun.myAlertIOS7(strInfo: strInfo);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "let strResult : String = clsPubFun.myBool(myObj: strResult as AnyObject);");
            strBuilder.Append("\r\n" + "objResponseData.returnString = strResult!;");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate!.{1}!(returnString: strResult!, strClassName: \"{0}\");",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "return;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "break;");

            strBuilder.Append("\r\n" + "case 9: //\"GetMaxStrIdByPrefix\":");
            strBuilder.AppendFormat("\r\n" + "if (cls{0}WS.ResponseData.errorId > 0)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let strInfo : String = \"调用GetMaxStrIdByPrefix函数出错。\\(cls{0}WS.ResponseData.faultString)\";",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "clsPubFun.myAlertIOS7(strInfo: strInfo);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "let strResult : String = clsPubFun.myBool(myObj: strResult as AnyObject);");
            strBuilder.Append("\r\n" + "objResponseData.returnString = strResult!;");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrIdByPrefix,
                enumDict4GC_DictKey2.conFinished));
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate!.{1}!(returnString: strResult!, strClassName: \"{0}\");",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrIdByPrefix,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "return;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "break;");

            strBuilder.Append("\r\n" + "default:");
            strBuilder.Append("\r\n" + "break;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "print(strResult);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// 根据关键字获取相应的记录的对象 
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Swift4Bak_SelfDefWs_IsFinished4WebService()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 调用WebService是否完成函数");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>获取的调用WebService是否完成函数返回的数据</returns>");
            strBuilder.Append("\r\n" + "func IsFinished4WebService()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "if ({0}WS.ResponseData.IsFinished == true)",
                objWebSrvClassENEx.ClsName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "theTimer.invalidate();");
            strBuilder.AppendFormat("\r\n" + "let objResponseData : clsResponseData = clsResponseData(structResponseData: {0}WS.ResponseData);",
                objWebSrvClassENEx.ClsName);

            strBuilder.AppendFormat("\r\n" + "let strResult = {0}WS.ResponseData.data;",
                objWebSrvClassENEx.ClsName);
            strBuilder.AppendFormat("\r\n" + "switch {0}WS.ResponseData.what ",
                objWebSrvClassENEx.ClsName);
            strBuilder.Append("\r\n" + "{");
            int intIndex = 50;
            foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
            {
                if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                strBuilder.AppendFormat("\r\n" + "case {1}: //\"{0}\":",
                objWebSrvClassENEx.ClsName, intIndex);

                strBuilder.AppendFormat("\r\n" + "if ({0}WS.ResponseData.errorId > 0)",
                    objWebSrvClassENEx.ClsName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.AppendFormat("\r\n" + "let strInfo : String = \"调用[{0}]函数出错。\\({1}WS.ResponseData.faultString)\";",
                    objWebSrvFunctionsENEx.FunctionName,
                    objWebSrvClassENEx.ClsName);
                strBuilder.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo: strInfo);");
                strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{2}!(objResponseData: objResponseData, strClassName: \"{0}\", strFunctionName: \"{1}\");",
       objWebSrvClassENEx.ClsName,
       objWebSrvFunctionsENEx.FunctionName,
       clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
       enumDict4GC_DictKey2.conFinished));

                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "else");
                strBuilder.Append("\r\n" + "{");
                strBuilder.AppendFormat("\r\n" + "//var obj{0}EN : cls{0}EN;",
                    objWebSrvClassENEx.ClsName);
                strBuilder.AppendFormat("\r\n" + "//obj{0}EN = cls{0}BL.GetObjByJSONStr(strJSON: strResult);",
                    objWebSrvClassENEx.ClsName);
                strBuilder.AppendFormat("\r\n" + "//objResponseData.returnObject = obj{0}EN;",
                    objWebSrvClassENEx.ClsName);
                strBuilder.AppendFormat("\r\n" + "objResponseData.returnString = strResult!;",
                        objWebSrvClassENEx.ClsName);


                strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate!.{2}!(strResult: strResult!, strClassName: \"{0}\", strFunctionName: \"{1}\");",
                                      objWebSrvClassENEx.ClsName,
                                      objWebSrvFunctionsENEx.FunctionName,
                                      clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
                                        enumDict4GC_DictKey2.conCorrectFinished));

                strBuilder.Append("\r\n" + "return;");
                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "break;");
                intIndex++;
            }
            strBuilder.Append("\r\n" + "default:");
            strBuilder.Append("\r\n" + "break;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "print(strResult);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// 根据关键字获取相应的记录的对象 
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Swift4Bak_SelfDefWs_IsFinished4WebService_Swift4BakBaK20170814()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 调用WebService是否完成函数");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>获取的调用WebService是否完成函数返回的数据</returns>");
            strBuilder.Append("\r\n" + "func IsFinished4WebService()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "if ({0}WS.ResponseData.IsFinished == true)",
                objWebSrvClassENEx.ClsName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "theTimer.invalidate();");
            strBuilder.AppendFormat("\r\n" + "let objResponseData : clsResponseData = clsResponseData(structResponseData: {0}WS.ResponseData);",
                objWebSrvClassENEx.ClsName);

            strBuilder.AppendFormat("\r\n" + "let strResult = {0}WS.ResponseData.data;",
                objWebSrvClassENEx.ClsName);
            strBuilder.AppendFormat("\r\n" + "switch {0}WS.ResponseData.what ",
                objWebSrvClassENEx.ClsName);
            strBuilder.Append("\r\n" + "{");
            int intIndex = 50;
            foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
            {
                if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                strBuilder.AppendFormat("\r\n" + "case {1}: //\"{0}\":",
                objWebSrvClassENEx.ClsName, intIndex);

                strBuilder.AppendFormat("\r\n" + "if ({0}WS.ResponseData.errorId > 0)",
                    objWebSrvClassENEx.ClsName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.AppendFormat("\r\n" + "let strInfo : String = \"调用[{0}]函数出错。\\({1}WS.ResponseData.faultString)\";",
                    objWebSrvFunctionsENEx.FunctionName,
                    objWebSrvClassENEx.ClsName);
                strBuilder.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo: strInfo);");
                strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{2}!(objResponseData: objResponseData, strClassName: \"{0}\", strFunctionName: \"{1}\");",
       objWebSrvClassENEx.ClsName,
       objWebSrvFunctionsENEx.FunctionName,
       clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
       enumDict4GC_DictKey2.conFinished));

                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "else");
                strBuilder.Append("\r\n" + "{");
                strBuilder.AppendFormat("\r\n" + "//var obj{0}EN : cls{0}EN;",
                    objWebSrvClassENEx.ClsName);
                strBuilder.AppendFormat("\r\n" + "//obj{0}EN = cls{0}BL.GetObjByJSONStr(strJSON: strResult);",
                    objWebSrvClassENEx.ClsName);
                strBuilder.AppendFormat("\r\n" + "//objResponseData.returnObject = obj{0}EN;",
                    objWebSrvClassENEx.ClsName);
                strBuilder.AppendFormat("\r\n" + "objResponseData.returnString = strResult;",
                        objWebSrvClassENEx.ClsName);


                strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate!.{2}!(strResult: strResult, strClassName: \"{0}\", strFunctionName: \"{1}\");",
                                      objWebSrvClassENEx.ClsName,
                                      objWebSrvFunctionsENEx.FunctionName,
                                      clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
                                        enumDict4GC_DictKey2.conCorrectFinished));

                strBuilder.Append("\r\n" + "return;");
                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "break;");
                intIndex++;
            }
            strBuilder.Append("\r\n" + "default:");
            strBuilder.Append("\r\n" + "break;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "print(strResult);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }
     
        /// <summary>
        /// 通用的调用WebService函数 
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Swift4Bak_DelRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 通用的调用WebService函数");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">需要删除的关键字的值</param>",
                objKeyField.ObjFieldTabENEx.PrivPropName);
            strBuilder.Append("\r\n /// <returns>删除是否成功？</returns>");
            strBuilder.AppendFormat("\r\n" + "func DelRecord({0}: {1}) ",
                objKeyField.PrivFuncName,
                objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const values :  Dictionary < String, String > = Dictionary<String, String>();");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
            {
                strBuilder.AppendFormat("\r\n" + "values[\"{0}\"] = {0};",
                    objKeyField.PrivFuncName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "values[\"{0}\"] = String({0});",
                    objKeyField.PrivFuncName);
            }
            strBuilder.AppendFormat("\r\n" + "let obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "let obj{0}WS : cls{0}WS = cls{0}WS(strMethod: \"DelRecord\",",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "mapParam: values,");
            strBuilder.AppendFormat("\r\n" + "pobj{0}EN: obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "queue.addOperation(obj{0}WS);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "theTimer = Timer.scheduledTimer(timeInterval: 0.1, target: self, selector: #selector(IsFinished4WebService), userInfo: nil, repeats: true);");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_Swift4Bak_btnDelRecord_Click()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 删除记录");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\n" + "@IBAction func btnDelRecord_Click(_ sender: Any) {");

            strBuilder.Append("\r\n" + "let iobjDelRecord : iclsDelRecord = iclsDelRecord(pvcParent: self);");
            strBuilder.Append("\r\n" + "iobjDelRecord.main();");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "class iclsDelRecord : NSObject, clsTableObjWS4ControllerDelegate");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const vcParent : UIViewController;");
            strBuilder.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);


            strBuilder.Append("\r\n" + "init(pvcParent : UIViewController)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "vcParent = pvcParent;");
            strBuilder.Append("\r\n" + "super.init();");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "func main()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
            {
                strBuilder.AppendFormat("\r\n" + "let {0} : {1} = \"{2}\";",
                    objKeyField.PrivFuncName,
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType,
                    objKeyField.ObjFieldTabENEx.DefaultValue4Test_Swift);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "let {0} : {1} = {2};",
                    objKeyField.PrivFuncName,
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType,
                    objKeyField.ObjFieldTabENEx.DefaultValue4Test_Swift);
            }

            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.DelRecord({1}: {1});",
                objPrjTabENEx.TabName,
                objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "}");


            strBuilder.Append("\r\n" + "//通过WebService执行DelRecord,返回的事件函数,可能需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conDelRecord,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//通过WebService执行DelRecord,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "func {0}(returnBool: Bool, strClassName: String)",
                      clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conDelRecord,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "if (returnBool == true)");
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "let strInfo : String = \"删除记录成功!\"");
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");


            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "let strInfo : String = \"删除记录不成功!\"");
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "};");
            strBuilder.Append("\r\n" + "}");



            return strBuilder.ToString();
        }


        /// <summary>
        /// 继承Runnable类必须实现的【run】函数  
        /// </summary>
        /// <returns></returns>
        public string Gen_Controller_Swift4Bak_btnAddNewRecord_Click()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 添加新记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.Append("\r\n" + "@IBAction func btnAddNewRecord_Click(_ sender: Any) {");
            strBuilder.Append("\r\n" + "let iobjAddNewRecord : iclsAddNewRecord = iclsAddNewRecord(pvcParent: self);");
            strBuilder.Append("\r\n" + "iobjAddNewRecord.main();");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "class iclsAddNewRecord : NSObject, clsTableObjWS4ControllerDelegate");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const vcParent : UIViewController;");
            strBuilder.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "init(pvcParent : UIViewController)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "vcParent = pvcParent;");
            strBuilder.Append("\r\n" + "super.init();");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "func main()");
            strBuilder.Append("\r\n" + "{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                string strTemp = SetProperty4DefaultValue_Swift4(objField);
                strBuilder.Append(strTemp);
                //if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                //{
                //    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = \"{2}\";",
                //       objPrjTabENEx.TabName,
                //       objField.ObjFieldTabENEx.FldName,
                //       objField.ObjFieldTabENEx.DefaultValue4Test_Swift);
                //}
                //else
                //{
                //    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                //          objPrjTabENEx.TabName,
                //          objField.ObjFieldTabENEx.FldName,
                //          objField.ObjFieldTabENEx.DefaultValue4Test_Swift);
                //}
            }
            strBuilder.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "let strWhereCond : String = \"{1} = '\\(obj{0}EN.{1})'\";",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.IsExistRecord(strWhereCond: strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行IsExistRecord,返回的事件函数,可能需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                         clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "};");
            strBuilder.Append("\r\n" + "//通过WebService执行IsExistRecord,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "func {0}(returnBool: Bool, strClassName: String)",
               clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "if (returnBool == false)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.AddNewRecord(obj{0}EN: obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let strInfo : String = \"关键字为‘\\(obj{0}EN.{1})’的记录已经存在,不能再添加!\"",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "};");
            strBuilder.Append("\r\n" + "//通过WebService执行AddNewRecord,返回的事件函数,可能需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行AddNewRecord,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "func {0}(returnBool: Bool, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "if (returnBool == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "let strInfo : String = \"添加记录成功!\"");
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "let strInfo : String = \"添加记录不成功!\"");
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "};");
            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

        public string Gen_Controller_Swift4Bak_btnAddNewRecord4GetMaxStrId_Click()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 添加新记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.Append("\r\n" + "@IBAction func btnAddNewRecord4GetMaxStrId_Click(_ sender: Any) {");
            strBuilder.Append("\r\n" + "let iobjAddNewRecord4GetMaxStrId : iclsAddNewRecord4GetMaxStrId = iclsAddNewRecord4GetMaxStrId(pvcParent: self);");
            strBuilder.Append("\r\n" + "iobjAddNewRecord4GetMaxStrId.main();");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "class iclsAddNewRecord4GetMaxStrId : NSObject, clsTableObjWS4ControllerDelegate");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const vcParent : UIViewController;");
            strBuilder.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "init(pvcParent : UIViewController)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "vcParent = pvcParent;");
            strBuilder.Append("\r\n" + "super.init();");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "func main()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
           objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.GetMaxStrId();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//通过WebService执行GetMaxStrId,返回的事件函数,可能需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "};");
            strBuilder.Append("\r\n" + "//通过WebService执行GetMaxStrId,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "func {0}(returnString: String, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                if (objField.FieldTypeId == enumFieldType.KeyField_02)
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = returnString;",
                    objPrjTabENEx.TabName,
                    objField.ObjFieldTabENEx.FldName);
                }
                else
                {

                    string strTemp = SetProperty4DefaultValue_Swift4(objField);
                    strBuilder.Append(strTemp);
                    //if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                    //{
                    //    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = \"{2}\";",
                    //       objPrjTabENEx.TabName,
                    //       objField.ObjFieldTabENEx.FldName,
                    //       objField.ObjFieldTabENEx.DefaultValue4Test_Swift);
                    //}
                    //else
                    //{
                    //    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                    //          objPrjTabENEx.TabName,
                    //          objField.ObjFieldTabENEx.FldName,
                    //          objField.ObjFieldTabENEx.DefaultValue4Test_Swift);
                    //}
                }
            }
            strBuilder.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "let strWhereCond : String = \"{1} = '\\(obj{0}EN.{1})'\";",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.IsExistRecord(strWhereCond: strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行IsExistRecord,返回的事件函数,可能需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "};");
            strBuilder.Append("\r\n" + "//通过WebService执行IsExistRecord,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "func {0}(returnBool: Bool, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "if (returnBool == false)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.AddNewRecord(obj{0}EN: obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let strInfo : String = \"关键字为‘\\(obj{0}EN.{1})’的记录已经存在,不能再添加!\"",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "};");
            strBuilder.Append("\r\n" + "//通过WebService执行AddNewRecord,返回的事件函数,可能需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行AddNewRecord,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "func {0}(returnBool: Bool, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "if (returnBool == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "let strInfo : String = \"添加记录成功!\"");
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "let strInfo : String = \"添加记录不成功!\"");
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "};");
            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

        public string Gen_Controller_Swift4Bak_btnGetMaxStrId_Click()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 获取当前表关键字值的最大值,再加1,避免重复");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.Append("\r\n" + "@IBAction func btnGetMaxStrId_Click(_ sender: Any) {");
            strBuilder.Append("\r\n" + "let iobjGetMaxStrId : iclsGetMaxStrId = iclsGetMaxStrId(pvcParent: self);");
            strBuilder.Append("\r\n" + "iobjGetMaxStrId.main();");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "class iclsGetMaxStrId : NSObject, clsTableObjWS4ControllerDelegate");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const vcParent : UIViewController;");
            strBuilder.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "init(pvcParent : UIViewController)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "vcParent = pvcParent;");
            strBuilder.Append("\r\n" + "super.init();");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "func main()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
           objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.GetMaxStrId();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//通过WebService执行GetMaxStrId,返回的事件函数,可能需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "};");
            strBuilder.Append("\r\n" + "//通过WebService执行GetMaxStrId,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "func {0}(returnString: String, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "if (returnString == \"\")");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let strInfo : String = \"获取表{0}的最大关键字为空,不成功,请检查!\"",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let strInfo : String = \"获取表{0}的最大关键字为：\\(returnString)!\"",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "};");
            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

        public string Gen_Controller_Swift4Bak_btnGetMaxStrIdByPrefix_Click()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.Append("\r\n" + "@IBAction func btnGetMaxStrIdByPrefix_Click(_ sender: Any) {");
            strBuilder.Append("\r\n" + "let iobjGetMaxStrIdByPrefix : iclsGetMaxStrIdByPrefix = iclsGetMaxStrIdByPrefix(pvcParent: self);");
            strBuilder.Append("\r\n" + "iobjGetMaxStrIdByPrefix.main();");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "class iclsGetMaxStrIdByPrefix : NSObject, clsTableObjWS4ControllerDelegate");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const vcParent : UIViewController;");
            strBuilder.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "init(pvcParent : UIViewController)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "vcParent = pvcParent;");
            strBuilder.Append("\r\n" + "super.init();");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "func main()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
           objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "let strPrefix : String = \"2\";");
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.GetMaxStrIdByPrefix(strPrefix: strPrefix);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//通过WebService执行GetMaxStrIdByPrefix,返回的事件函数,可能需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrIdByPrefix,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "};");
            strBuilder.Append("\r\n" + "//通过WebService执行GetMaxStrIdByPrefix,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "func {0}(returnString: String, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrIdByPrefix,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "if (returnString == \"\")");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let strInfo : String = \"获取表{0}的最大关键字为空,不成功,请检查!\"",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let strInfo : String = \"获取表{0}的最大关键字为：\\(returnString)!\"",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "};");
            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

        /// <summary>
        /// 继承Runnable类必须实现的【run】函数
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Swift4Bak_AddNewRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 添加新记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的对象</param>",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "public func AddNewRecord(obj{0}EN : cls{0}EN)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "let values :  Dictionary < String, String > = Dictionary<String, String>();");
            strBuilder.AppendFormat("\r\n" + "let obj{0}WS : cls{0}WS = cls{0}WS(strMethod: \"AddNewRecordByJSON\",",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "mapParam: values,");
            strBuilder.AppendFormat("\r\n" + "pobj{0}EN: obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "queue.addOperation(obj{0}WS);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "theTimer = Timer.scheduledTimer(timeInterval: 0.1, target: self, selector: #selector(IsFinished4WebService), userInfo: nil, repeats: true);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

        /// <summary>
        /// 继承Runnable类必须实现的【run】
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Swift4Bak_UpdateRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 修改记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要修改的对象</param>",
    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "public func UpdateRecord(obj{0}EN : cls{0}EN)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "let values :  Dictionary < String, String > = Dictionary<String, String>();");

            strBuilder.AppendFormat("\r\n" + "let obj{0}WS : cls{0}WS = cls{0}WS(strMethod: \"UpdateRecordByJSON\",",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "mapParam: values,");
            strBuilder.AppendFormat("\r\n" + "pobj{0}EN: obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "queue.addOperation(obj{0}WS);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "theTimer = Timer.scheduledTimer(timeInterval: 0.1, target: self, selector: #selector(IsFinished4WebService), userInfo: nil, repeats: true);");
            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

        public string Gen_Controller_Swift4Bak_btnUpdateRecord_Click()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 修改记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\n" + "@IBAction func btnUpdateRecord_Click(_ sender: Any) {");
            strBuilder.Append("\r\n" + "let iobjUpdateRecord : iclsUpdateRecord = iclsUpdateRecord(pvcParent: self);");
            strBuilder.Append("\r\n" + "iobjUpdateRecord.main();");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "class iclsUpdateRecord : NSObject, clsTableObjWS4ControllerDelegate");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const vcParent : UIViewController;");
            strBuilder.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "init(pvcParent : UIViewController)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "vcParent = pvcParent;");
            strBuilder.Append("\r\n" + "super.init();");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "func main()");
            strBuilder.Append("\r\n" + "{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                string strTemp = SetProperty4DefaultValue_Swift4(objField);
                strBuilder.Append(strTemp);

                //if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                //{
                //    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = \"{2}\";",
                //       objPrjTabENEx.TabName,
                //       objField.ObjFieldTabENEx.FldName,
                //       objField.ObjFieldTabENEx.DefaultValue4Test_Swift);
                //}
                //else
                //{
                //    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                //          objPrjTabENEx.TabName,
                //          objField.ObjFieldTabENEx.FldName,
                //          objField.ObjFieldTabENEx.DefaultValue4Test_Swift);
                //}
            }
            strBuilder.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.UpdateRecord(obj{0}EN: obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行UpdateRecord,返回的事件函数,可能需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conUpdateRecordByJSON,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行UpdateRecord,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "func {0}(returnBool: Bool, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conUpdateRecordByJSON,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "if (returnBool == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "let strInfo : String = \"修改记录成功!\"");
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "let strInfo : String = \"修改记录不成功!\"");
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "};");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

    }
}
