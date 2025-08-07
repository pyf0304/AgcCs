using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using com.taishsoft.comm_db_obj;
using com.taishsoft.commexception;
using com.taishsoft.common;
using com.taishsoft.datetime;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
    partial class AutoGC6_Controller : AutoGCPubFuncV6
    {

        /// <summary>
        /// 生成Web Service转换层代码
        /// </summary>
        /// <returns></returns>
        public string A_GenController_JavaScript( ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            this.CmPrjId = "没有赋值,请重新考虑!";
            string strFuncName = "";
            string strResult = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strResult = string.Format("当前表:[{0}]的字段数为0,无法生成通用逻辑层!({1})",
                       objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strResult = string.Format("当前表:[{0}]的关键字的个数为0,无法生成通用逻辑层!({1})",
                         objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            objPrjTabENEx.CurrDate = clsDateTime.getTodayStr2(0);

            //让用户设置属性;
            //string strFolder;
            string strClassFName;
            StringBuilder strBuilder = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp; ///临时变量;

            objPrjTabENEx.ClsName = "js" + objPrjTabENEx.TabName + "_Controller";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;
            
            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".js";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);

            //string strIsShare = objPrjTabENEx.IsShare == true ? "_1Share" : "";
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objPrjTabENEx.SimpleFileName); 
            
            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".js";

            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //
            clsFunction4CodeEN Re_objFunction4Code = new clsFunction4CodeEN();
            try
            {
                //类名开始

                strBuilder.Append(clsPubFun4GC.GenUserInfoAndDate(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));

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
                strBuilder.Append("\r\n" + " **/");

                strBuilder.Append("\r\n" + "const VirtualRootPath = getVirtualRootPath_web();//该函数存在于/js/PubFun/jsPubFun.js文件中");

                strBuilder.Append("\r\n" + "include(VirtualRootPath + \"/js/PubFun/tzDictionary.js\");");
                strBuilder.Append("\r\n" + "include(VirtualRootPath + \"/js/PubFun/tzResponseData.js\");");
                strBuilder.Append("\r\n" + "include(VirtualRootPath + \"/js/PubFun/jsPubFun.js\");");
                strBuilder.Append("\r\n" + "include(VirtualRootPath + \"/js/PubFun/jsPubVar.js\");");

                strBuilder.AppendFormat("\r\n" + "include(VirtualRootPath + \"/js/{1}/js{0}EN.js\");",
                    objPrjTabENEx.TabName,
                    objPrjTabENEx.ObjFuncModule.FuncModuleEnName4GC());
                strBuilder.AppendFormat("\r\n" + "include(VirtualRootPath + \"/js/{1}/js{0}BL.js\");",
                    objPrjTabENEx.TabName,
                    objPrjTabENEx.ObjFuncModule.FuncModuleEnName4GC());
                strBuilder.AppendFormat("\r\n" + "include(VirtualRootPath + \"/js/{1}/js{0}WS4Controller.js\");",
                                    objPrjTabENEx.TabName,
                                    objPrjTabENEx.ObjFuncModule.FuncModuleEnName4GC());
                
                strBuilder.AppendFormat("\r\n" + "const obj{0}EN;",
                        objPrjTabENEx.TabName);

                strBuilder.AppendFormat("\r\n" + "const cls{0}_Controller = function()",
                    objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "{");

                //生成所有的函数

                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                  clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId("this.CmPrjId"),
                  objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                .OrderBy(x => x.OrderNum);

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                 
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    if (strFuncName.IndexOf("JavaScript_icls") > 0) continue;

                    if (strFuncName.IndexOf("JavaScript_btnClick") > 0)
                    {
                        strTemp = A_GeneFuncCode_JavaScript_btnClick(strFuncName);
                    }
                    else if (strFuncName.IndexOf("JavaScript_Invoke") > 0)
                    {
                        strTemp = A_GeneFuncCode_JavaScript_Invoke(strFuncName);
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

                strBuilder.Append("\r\n" + "}");
                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                     strFuncName = objvFunction4GeneCodeEN.FuncName;
                    if (strFuncName.IndexOf("JavaScript_icls") < 0) continue;
                    if (strFuncName.IndexOf("JavaScript_btnClick") > 0)
                    {
                        strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    else if (strFuncName.IndexOf("JavaScript_icls") > 0)
                    {
                        strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    else if (strFuncName.IndexOf("JavaScript_Invoke") > 0)
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
                              
               
                //}
                ////UTF8Encoding utf8 = new UTF8Encoding(false);
                //clsFile.CreateFileByString(strClassFName, strBuilder.ToString(), myEncoding);
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
 
            }
            return strBuilder.ToString();
        }

        /// <summary>
        /// 生成Web Service转换层代码
        /// </summary>
        /// <returns></returns>
        public string A_GenController_JavaScript_SelfDefWs(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
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
            StringBuilder strBuilder = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp; ///临时变量;

            objWebSrvClassENEx.ClsName = "js" + objWebSrvClassENEx.ClsName + "4SD_Controller";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objWebSrvClassENEx.SimpleFileName = objWebSrvClassENEx.ClsName + ".js";
            strRe_ClsName = objWebSrvClassENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objWebSrvClassENEx.FuncModuleAgcId, objWebSrvClassENEx.PrjId);

            //string strIsShare = objPrjTabENEx.IsShare == true ? "_1Share" : "";
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objPrjTabENEx.SimpleFileName); 
            
            strClassFName = objWebSrvClassENEx.FolderName + objWebSrvClassENEx.ClsName + ".js";

            objWebSrvClassENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objWebSrvClassENEx.PrjId); //
            try
            {
                //类名开始

                strBuilder.Append(clsPubFun4GC.GenUserInfoAndDate(objWebSrvClassENEx.CurrUserName, objWebSrvClassENEx));

                strBuilder.Append("\r\n" + ""); //

                strBuilder.Append("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// {0}({1})", objWebSrvClassENEx.ClsName, objWebSrvClassENEx.ClsName);

                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.Append("\r\n" + "/**");
                strBuilder.AppendFormat("\r\n" + "* Created by {0} on {1}.",
                    objWebSrvClassENEx.CurrUserName,
                    clsDateTime.getTodayStr(3));
                strBuilder.AppendFormat("\r\n" + "* 注意:该类必须与调用界面处于同一个包,否则调用不成功!", objWebSrvClassENEx.CurrUserName, clsDateTime.getTodayStr(3));
                strBuilder.Append("\r\n" + " **/");

                strBuilder.Append("\r\n" + "const VirtualRootPath = getVirtualRootPath_web();//该函数存在于/js/PubFun/jsPubFun.js文件中");

                strBuilder.Append("\r\n" + "include(VirtualRootPath + \"/js/PubFun/tzDictionary.js\");");
                strBuilder.Append("\r\n" + "include(VirtualRootPath + \"/js/PubFun/tzResponseData.js\");");
                strBuilder.Append("\r\n" + "include(VirtualRootPath + \"/js/PubFun/jsPubFun.js\");");
                strBuilder.Append("\r\n" + "include(VirtualRootPath + \"/js/PubFun/jsPubVar.js\");");

                //strBuilder.AppendFormat("\r\n" + "include(VirtualRootPath + \"/js/{1}/js{0}EN.js\");",
                //    objWebSrvClassENEx.ClsName,
                //    objWebSrvClassENEx.ObjFuncModule.FuncModuleEnName4GC());
                //strBuilder.AppendFormat("\r\n" + "include(VirtualRootPath + \"/js/{1}/js{0}BL.js\");",
                //    objWebSrvClassENEx.ClsName,
                //    objWebSrvClassENEx.ObjFuncModule.FuncModuleEnName4GC());
                strBuilder.AppendFormat("\r\n" + "include(VirtualRootPath + \"/js/{1}/js{0}WS4SDController.js\");",
                                    objWebSrvClassENEx.ClsName,
                                    objWebSrvClassENEx.ObjFuncModule.FuncModuleEnName4GC());

                //strBuilder.AppendFormat("\r\n" + "const obj{0}EN;",
                //        objWebSrvClassENEx.ClsName);

                strBuilder.AppendFormat("\r\n" + "const cls{0}4SD_Controller = function()",
                    objWebSrvClassENEx.ClsName);
                strBuilder.Append("\r\n" + "{");
                
                //生成所有的函数
                foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
                {
                    if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                   
                    try
                    {
                        strTemp = Gen_Controller_JavaScript_InvokeByCommonFunction(objWebSrvFunctionsENEx);
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
                //生成所有的函数
                foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
                {
                    if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;

                    try
                    {
                        strTemp = Gen_Controller_JavaScript_iclsByCommonFunction(objWebSrvFunctionsENEx);
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

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strBuilder.ToString();
        }

        /// <summary>
        /// 生成Web Service转换层代码
        /// </summary>
        /// <returns></returns>
        public string A_GenController_JavaScript_UnitTest(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strFuncName = "";
            string strResult = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strResult = string.Format("当前表:[{0}]的字段数为0,无法生成通用逻辑层!({1})",
                       objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strResult = string.Format("当前表:[{0}]的关键字的个数为0,无法生成通用逻辑层!({1})",
                         objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            objPrjTabENEx.CurrDate = clsDateTime.getTodayStr2(0);

            //让用户设置属性;
            //string strFolder;
            string strClassFName;
            StringBuilder strBuilder = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp = ""; ///临时变量;

            objPrjTabENEx.ClsName = "js" + objPrjTabENEx.TabName + "_UnitTest";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".js";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);

            string strIsShare = objPrjTabENEx.IsShare == true ? "_Share" : "";
            strRe_FileNameWithModuleName = string.Format("{0}{2}\\{1}", objFuncModule.FuncModuleEnName4GC(), objPrjTabENEx.SimpleFileName, strIsShare); 
            
            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".js";

            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //
            try
            {
                //类名开始

                strBuilder.Append(clsPubFun4GC.GenUserInfoAndDate(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));

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
                strBuilder.Append("\r\n" + " **/");

                strBuilder.Append("\r\n" + "const VirtualRootPath = getVirtualRootPath_web();//该函数存在于/js/PubFun/jsPubFun.js文件中");

                strBuilder.Append("\r\n" + "include(VirtualRootPath + \"/js/PubFun/tzDictionary.js\");");
                strBuilder.Append("\r\n" + "include(VirtualRootPath + \"/js/PubFun/tzResponseData.js\");");
                strBuilder.Append("\r\n" + "include(VirtualRootPath + \"/js/PubFun/jsPubFun.js\");");
                strBuilder.Append("\r\n" + "include(VirtualRootPath + \"/js/PubFun/jsPubVar.js\");");

                strBuilder.AppendFormat("\r\n" + "include(VirtualRootPath + \"/js/{1}/js{0}EN.js\");",
                    objPrjTabENEx.TabName,
                    objPrjTabENEx.ObjFuncModule.FuncModuleEnName4GC());
                strBuilder.AppendFormat("\r\n" + "include(VirtualRootPath + \"/js/{1}/js{0}BL.js\");",
                    objPrjTabENEx.TabName,
                    objPrjTabENEx.ObjFuncModule.FuncModuleEnName4GC());
                strBuilder.AppendFormat("\r\n" + "include(VirtualRootPath + \"/js/{1}/js{0}WS4Controller.js\");",
                                    objPrjTabENEx.TabName,
                                    objPrjTabENEx.ObjFuncModule.FuncModuleEnName4GC());

                strBuilder.AppendFormat("\r\n" + "include(VirtualRootPath + \"/js/{1}/js{0}_Controller.js\");",
                                                    objPrjTabENEx.TabName,
                                                    objPrjTabENEx.ObjFuncModule.FuncModuleEnName4GC());

                strBuilder.AppendFormat("\r\n" + "const obj{0}EN;",
                        objPrjTabENEx.TabName);

                strBuilder.AppendFormat("\r\n" + "const ac{0}_UnitTest = function()",
                    objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "{");

                //生成所有的函数

                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                  clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId("this.CmPrjId"),
                  objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                .OrderBy(x => x.OrderNum);

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    if (strFuncName.IndexOf("JavaScript_btnClick") > 0)
                    {
                        strTemp = A_GeneFuncCode_JavaScript_btnClick(strFuncName);
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

        /// <summary>
        /// 生成Web Service转换层代码
        /// </summary>
        /// <returns></returns>
        public string A_GenController_JavaScript_SelfDefWs4UnitTest(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
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
            string strTemp = ""; ///临时变量;

            objWebSrvClassENEx.ClsName = "js" + objWebSrvClassENEx.ClsName + "4SD_UnitTest";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objWebSrvClassENEx.SimpleFileName = objWebSrvClassENEx.ClsName + ".js";
            strRe_ClsName = objWebSrvClassENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objWebSrvClassENEx.FuncModuleAgcId, objWebSrvClassENEx.PrjId);

            string strIsShare = objPrjTabENEx.IsShare == true ? "_Share" : "";
            strRe_FileNameWithModuleName = string.Format("{0}{2}\\{1}", objFuncModule.FuncModuleEnName4GC(), objPrjTabENEx.SimpleFileName, strIsShare);

            strClassFName = objWebSrvClassENEx.FolderName + objWebSrvClassENEx.ClsName + ".js";

            objWebSrvClassENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objWebSrvClassENEx.PrjId); //
            try
            {
                //类名开始

                strBuilder.Append(clsPubFun4GC.GenUserInfoAndDate(objWebSrvClassENEx.CurrUserName, objWebSrvClassENEx));

                strBuilder.Append("\r\n" + ""); //

                strBuilder.Append("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// {0}({1})", objWebSrvClassENEx.ClsName, objWebSrvClassENEx.ClsName);

                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.Append("\r\n" + "/**");
                strBuilder.AppendFormat("\r\n" + "* Created by {0} on {1}.",
                    objWebSrvClassENEx.CurrUserName,
                    clsDateTime.getTodayStr(3));
                strBuilder.AppendFormat("\r\n" + "* 注意:该类必须与调用界面处于同一个包,否则调用不成功!", objWebSrvClassENEx.CurrUserName, clsDateTime.getTodayStr(3));
                strBuilder.Append("\r\n" + " **/");

                strBuilder.Append("\r\n" + "const VirtualRootPath = getVirtualRootPath_web();//该函数存在于/js/PubFun/jsPubFun.js文件中");

                strBuilder.Append("\r\n" + "include(VirtualRootPath + \"/js/PubFun/tzDictionary.js\");");
                strBuilder.Append("\r\n" + "include(VirtualRootPath + \"/js/PubFun/tzResponseData.js\");");
                strBuilder.Append("\r\n" + "include(VirtualRootPath + \"/js/PubFun/jsPubFun.js\");");
                strBuilder.Append("\r\n" + "include(VirtualRootPath + \"/js/PubFun/jsPubVar.js\");");

                //strBuilder.AppendFormat("\r\n" + "include(VirtualRootPath + \"/js/{1}/js{0}EN.js\");",
                //    objWebSrvClassENEx.ClsName,
                //    objWebSrvClassENEx.ObjFuncModule.FuncModuleEnName4GC());
                //strBuilder.AppendFormat("\r\n" + "include(VirtualRootPath + \"/js/{1}/js{0}BL.js\");",
                //    objWebSrvClassENEx.ClsName,
                //    objWebSrvClassENEx.ObjFuncModule.FuncModuleEnName4GC());
                strBuilder.AppendFormat("\r\n" + "include(VirtualRootPath + \"/js/{1}/js{0}WS4SDController.js\");",
                                    objWebSrvClassENEx.ClsName,
                                    objWebSrvClassENEx.ObjFuncModule.FuncModuleEnName4GC());

                strBuilder.AppendFormat("\r\n" + "include(VirtualRootPath + \"/js/{1}/js{0}4SD_Controller.js\");",
                                                    objWebSrvClassENEx.ClsName,
                                                    objWebSrvClassENEx.ObjFuncModule.FuncModuleEnName4GC());

                //strBuilder.AppendFormat("\r\n" + "const obj{0}EN;",
                //        objWebSrvClassENEx.ClsName);

                strBuilder.AppendFormat("\r\n" + "const vc{0}4SD_UnitTest = function()",
                    objWebSrvClassENEx.ClsName);
                strBuilder.Append("\r\n" + "{");

                //生成所有的函数
                foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
                {
                    if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                    try
                    {
                        strTemp = Gen_Controller_JavaScript_btnClickByCommonFunction(objWebSrvFunctionsENEx);
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
        /// 生成Web Service转换层代码
        /// </summary>
        /// <returns></returns>
        public string A_GenController_JavaScript_UTScript(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strFuncName = "";
            string strResult = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strResult = string.Format("当前表:[{0}]的字段数为0,无法生成通用逻辑层!({1})",
                       objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strResult = string.Format("当前表:[{0}]的关键字的个数为0,无法生成通用逻辑层!({1})",
                         objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            objPrjTabENEx.CurrDate = clsDateTime.getTodayStr2(0);

            //让用户设置属性;
            //string strFolder;
            string strClassFName;
            StringBuilder strBuilder = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp = ""; ///临时变量;

            objPrjTabENEx.ClsName = objPrjTabENEx.TabName + "_UTScript";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".aspx";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);

            string strIsShare = objPrjTabENEx.IsShare == true ? "_Share" : "";
            strRe_FileNameWithModuleName = string.Format("{0}{2}\\{1}", objFuncModule.FuncModuleEnName4GC(), objPrjTabENEx.SimpleFileName, strIsShare); 
            
            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".aspx";

            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //
            try
            {
                //生成所有的函数

                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                  clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId("this.CmPrjId"),
                  objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                .OrderBy(x => x.OrderNum);

                //类名开始

                //strBuilder.Append(clsPubFun4GC.GenUserInfoAndDate(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));

                strBuilder.Append("\r\n" + ""); //
                strBuilder.AppendFormat("\r\n" + "<%@ Page Language=\"C#\" AutoEventWireup=\"true\" CodeBehind=\"{0}_UTScript.aspx.cs\" Inherits=\"{1}.Webform.{2}.{0}_UTScript\" %>",
                    objPrjTabENEx.TabName, objProject.PrjDomain,
                    objFuncModule.FuncModuleEnName4GC());

                strBuilder.Append("\r\n" + "<!DOCTYPE html>");

                strBuilder.Append("\r\n" + "<html xmlns=\"http://www.w3.org/1999/xhtml\">");
                strBuilder.Append("\r\n" + "<head runat=\"server\">");
                strBuilder.Append("\r\n" + "<meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\"/>");
                strBuilder.Append("\r\n" + "    <title></title>");
                strBuilder.Append("\r\n" + "   <script src=\"../../Js/PubFun/jsPubVar.js\"></script>");
                strBuilder.Append("\r\n" + "    <script src=\"../../Js/PubFun/jsPubFun.js\"></script>");
                strBuilder.Append("\r\n" + "    <script src=\"../../Js/PubFun/tzInclude.js\"></script>");
                strBuilder.Append("\r\n" + "    <script src=\"../../Js/PubFun/jsGetElement.js\"></script>");
                strBuilder.Append("\r\n" + "    <script src=\"../../Js/PubFun/TzCtrlCls.js\"></script>");
                strBuilder.AppendFormat("\r\n" + "<script src=\"../../Js/BaseInfo/js{0}_UnitTest.js\"></script>",
                    objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + " ");
                strBuilder.Append("\r\n" + "       <script>");
                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    if (strFuncName.IndexOf("JavaScript_InvokeFun") > 0)
                    {
                        strTemp = A_GeneFuncCode_JavaScript_InvokeFun(strFuncName);
                    }
                    else
                    {
                        strTemp = "";
                    }
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strBuilder.Append("\r\n" + strTemp);
                    }
                }

                strBuilder.Append("\r\n" + "  </script>");
                strBuilder.Append("\r\n" + "</head>");
                strBuilder.Append("\r\n" + "<body>");
                strBuilder.Append("\r\n" + "    <form id=\"form1\" runat=\"server\">");
                strBuilder.Append("\r\n" + "    <div>");
               
                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                 
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    if (strFuncName.IndexOf("JavaScript_DefButton") > 0)
                    {
                        strTemp = A_GeneFuncCode_JavaScript_DefButton(strFuncName);
                    }
                    else
                    {
                        strTemp = "";
                    }
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strBuilder.Append("\r\n" + strTemp);
                    }
                }
                strBuilder.Append("\r\n" + "    </div>");
                strBuilder.Append("\r\n" + "    </form>");
                strBuilder.Append("\r\n" + "</body>");
                strBuilder.Append("\r\n" + "</html>");
                
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
          
            }
            return strBuilder.ToString();
        }


        /// <summary>
        /// 生成Web Service转换层代码
        /// </summary>
        /// <returns></returns>
        public string A_GenController_JavaScript_SelfDefWs4UTScript(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
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
            string strTemp = ""; ///临时变量;

            objWebSrvClassENEx.ClsName = objWebSrvClassENEx.ClsName + "4SD_UTScript";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objWebSrvClassENEx.SimpleFileName = objWebSrvClassENEx.ClsName + ".aspx";
            strRe_ClsName = objWebSrvClassENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objWebSrvClassENEx.FuncModuleAgcId, objWebSrvClassENEx.PrjId);

            string strIsShare = objPrjTabENEx.IsShare == true ? "_Share" : "";
            strRe_FileNameWithModuleName = string.Format("{0}{2}\\{1}", objFuncModule.FuncModuleEnName4GC(), objPrjTabENEx.SimpleFileName, strIsShare);

            strClassFName = objWebSrvClassENEx.FolderName + objWebSrvClassENEx.ClsName + ".aspx";

            objWebSrvClassENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objWebSrvClassENEx.PrjId); //
            try
            {
              
                //strBuilder.Append(clsPubFun4GC.GenUserInfoAndDate(objWebSrvClassENEx.CurrUserName, objWebSrvClassENEx));

                strBuilder.Append("\r\n" + ""); //
                strBuilder.AppendFormat("\r\n" + "<%@ Page Language=\"C#\" AutoEventWireup=\"true\" CodeBehind=\"{0}4SD_UTScript.aspx.cs\" Inherits=\"{1}.Webform.{2}.{0}4SD_UTScript\" %>",
                    objWebSrvClassENEx.ClsName, objProject.PrjDomain,
                    objFuncModule.FuncModuleEnName4GC());

                strBuilder.Append("\r\n" + "<!DOCTYPE html>");

                strBuilder.Append("\r\n" + "<html xmlns=\"http://www.w3.org/1999/xhtml\">");
                strBuilder.Append("\r\n" + "<head runat=\"server\">");
                strBuilder.Append("\r\n" + "<meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\"/>");
                strBuilder.Append("\r\n" + "    <title></title>");
                strBuilder.Append("\r\n" + "   <script src=\"../../Js/PubFun/jsPubVar.js\"></script>");
                strBuilder.Append("\r\n" + "    <script src=\"../../Js/PubFun/jsPubFun.js\"></script>");
                strBuilder.Append("\r\n" + "    <script src=\"../../Js/PubFun/tzInclude.js\"></script>");
                strBuilder.Append("\r\n" + "    <script src=\"../../Js/PubFun/jsGetElement.js\"></script>");
                strBuilder.Append("\r\n" + "    <script src=\"../../Js/PubFun/TzCtrlCls.js\"></script>");
                strBuilder.AppendFormat("\r\n" + "<script src=\"../../Js/BaseInfo/js{0}4SD_UnitTest.js\"></script>",
                    objWebSrvClassENEx.ClsName);
                strBuilder.Append("\r\n" + " ");
                strBuilder.Append("\r\n" + "       <script>");
                foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
                {
                    if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                    try
                    {
                        strTemp = Gen_Controller_JavaScript_InvokeFunByCommonFunction(objWebSrvFunctionsENEx);

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
              

                strBuilder.Append("\r\n" + "  </script>");
                strBuilder.Append("\r\n" + "</head>");
                strBuilder.Append("\r\n" + "<body>");
                strBuilder.Append("\r\n" + "    <form id=\"form1\" runat=\"server\">");
                strBuilder.Append("\r\n" + "    <div>");

                foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
                {
                    if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                    try
                    {
                        strTemp = Gen_Controller_JavaScript_DefButtonByCommonFunction(objWebSrvFunctionsENEx);

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
         
                strBuilder.Append("\r\n" + "    </div>");
                strBuilder.Append("\r\n" + "    </form>");
                strBuilder.Append("\r\n" + "</body>");
                strBuilder.Append("\r\n" + "</html>");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strBuilder.ToString();
        }


        /// <summary>
        /// 生成Web Service转换层代码
        /// </summary>
        /// <returns></returns>
        public string A_GenController_JavaScript_UTScriptCS(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strResult = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strResult = string.Format("当前表:[{0}]的字段数为0,无法生成通用逻辑层!({1})",
                       objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strResult = string.Format("当前表:[{0}]的关键字的个数为0,无法生成通用逻辑层!({1})",
                         objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            objPrjTabENEx.CurrDate = clsDateTime.getTodayStr2(0);

            //让用户设置属性;
            //string strFolder;
            string strClassFName;
            StringBuilder strBuilder = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;


            objPrjTabENEx.ClsName = objPrjTabENEx.TabName + "_UTScript";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".aspx.cs";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);

            string strIsShare = objPrjTabENEx.IsShare == true ? "_Share" : "";
            strRe_FileNameWithModuleName = string.Format("{0}{2}\\{1}", objFuncModule.FuncModuleEnName4GC(), objPrjTabENEx.SimpleFileName, strIsShare); 
            
            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".aspx.cs";

            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //
            try
            {
                //生成所有的函数

                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                  clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId("this.CmPrjId"),
                  objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                .OrderBy(x => x.OrderNum);

                //类名开始

                //strBuilder.Append(clsPubFun4GC.GenUserInfoAndDate(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));

                strBuilder.Append("\r\n" + ""); //
                strBuilder.Append("\r\n" + "using System;");
                strBuilder.Append("\r\n" + "using System.Collections.Generic;");
                strBuilder.Append("\r\n" + "using System.Linq;");
                strBuilder.Append("\r\n" + "using System.Web;");
                strBuilder.Append("\r\n" + "using System.Web.UI;");
                strBuilder.Append("\r\n" + "using System.Web.UI.WebControls;");

                strBuilder.AppendFormat("\r\n" + "namespace {0}.Webform.{1}",
                    objProject.PrjDomain, objFuncModule.FuncModuleEnName4GC());
                strBuilder.Append("\r\n" + "{");
                strBuilder.AppendFormat("\r\n" + "public partial class  {0}_UTScript : System.Web.UI.Page",
                    objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "protected void Page_Load(object sender, EventArgs e)");
                strBuilder.Append("\r\n" + "{");

                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "}");
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
        /// 生成Web Service转换层代码
        /// </summary>
        /// <returns></returns>
        public string A_GenController_JavaScript_SelfDefWs4UTScriptCS(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
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


            objWebSrvClassENEx.ClsName = objWebSrvClassENEx.ClsName + "4SD_UTScript";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objWebSrvClassENEx.SimpleFileName = objWebSrvClassENEx.ClsName + ".aspx.cs";
            strRe_ClsName = objWebSrvClassENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objWebSrvClassENEx.FuncModuleAgcId, objWebSrvClassENEx.PrjId);

            string strIsShare = objPrjTabENEx.IsShare == true ? "_Share" : "";
            strRe_FileNameWithModuleName = string.Format("{0}{2}\\{1}", objFuncModule.FuncModuleEnName4GC(), objPrjTabENEx.SimpleFileName, strIsShare); 
            
            strClassFName = objWebSrvClassENEx.FolderName + objWebSrvClassENEx.ClsName + ".aspx.cs";

            objWebSrvClassENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objWebSrvClassENEx.PrjId); //
            try
            {

                //类名开始

                //strBuilder.Append(clsPubFun4GC.GenUserInfoAndDate(objWebSrvClassENEx.CurrUserName, objWebSrvClassENEx));

                strBuilder.Append("\r\n" + ""); //
                strBuilder.Append("\r\n" + "using System;");
                strBuilder.Append("\r\n" + "using System.Collections.Generic;");
                strBuilder.Append("\r\n" + "using System.Linq;");
                strBuilder.Append("\r\n" + "using System.Web;");
                strBuilder.Append("\r\n" + "using System.Web.UI;");
                strBuilder.Append("\r\n" + "using System.Web.UI.WebControls;");

                strBuilder.AppendFormat("\r\n" + "namespace {0}.Webform.{1}",
                    objProject.PrjDomain, objFuncModule.FuncModuleEnName4GC());
                strBuilder.Append("\r\n" + "{");
                strBuilder.AppendFormat("\r\n" + "public partial class  {0}4SD_UTScript : System.Web.UI.Page",
                    objWebSrvClassENEx.ClsName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "protected void Page_Load(object sender, EventArgs e)");
                strBuilder.Append("\r\n" + "{");

                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "}");
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
        /// 生成Web Service转换层代码
        /// </summary>
        /// <returns></returns>
        public string A_GenTableObjWSController_JavaScript( ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strFuncName = "";
            string strResult = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strResult = string.Format("当前表:[{0}]的字段数为0,无法生成通用逻辑层!({1})",
                      objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strResult = string.Format("当前表:[{0}]的关键字的个数为0,无法生成通用逻辑层!({1})",
                   objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            objPrjTabENEx.CurrDate = clsDateTime.getTodayStr2(0);

            //让用户设置属性;
            //string strFolder;
            string strClassFName;
            StringBuilder strBuilder = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp; ///临时变量;

            objPrjTabENEx.ClsName = string.Format("js{0}WS4Controller", objPrjTabENEx.TabName);
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;
            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".js";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);

            string strIsShare = objPrjTabENEx.IsShare == true ? "_Share" : "";
            strRe_FileNameWithModuleName = string.Format("{0}{2}\\{1}", objFuncModule.FuncModuleEnName4GC(), objPrjTabENEx.SimpleFileName, strIsShare);

            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".js";
            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //
            try
            {
                //类名开始

                strBuilder.Append(clsPubFun4GC.GenUserInfoAndDate(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));

                strBuilder.Append("\r\n" + ""); //

                strBuilder.Append("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// {0}({1})",
                    objPrjTabENEx.TabCnName,
                    objPrjTabENEx.TabName);

                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.Append("\r\n" + "/**");
                strBuilder.AppendFormat("\r\n" + "* Created by {0} on {1}.",
                    objPrjTabENEx.UserId,
                    clsDateTime.getTodayStr(3));
                strBuilder.AppendFormat("\r\n" + "* 注意:该类必须与调用界面处于同一个包,否则调用不成功!", objPrjTabENEx.UserId, clsDateTime.getTodayStr(3));
                strBuilder.Append("\r\n" + " **/");

                strBuilder.AppendFormat("\r\n" + "/// <reference path=\"js{0}WS.js\" />", objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "/// <reference path=\"../PubFun/jsPubFun.js\" />");
                strBuilder.Append("\r\n" + "/// <reference path=\"../PubFun/jsTableObjWS4ControllerDelegate.js\" />");
                strBuilder.Append("\r\n" + "/// <reference path=\"../PubFun/tzDictionary.js\" />");
                strBuilder.AppendFormat("\r\n" + "/// <reference path=\"js{0}EN.js\" />", objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n" + "/// <reference path=\"js{0}BL.js\" />", objPrjTabENEx.TabName);

                strBuilder.Append("\r\n" + "const VirtualRootPath = getVirtualRootPath_web();//该函数存在于/js/PubFun/jsPubFun.js文件中");
                
                strBuilder.Append("\r\n" + "include(VirtualRootPath + \"/js/PubFun/jsPubFun.js\");");
                strBuilder.Append("\r\n" + "include(VirtualRootPath + \"/js/PubFun/jsTableObjWS4ControllerDelegate.js\");");
                strBuilder.Append("\r\n" + "include(VirtualRootPath + \"/js/PubFun/tzDictionary.js\");");
                strBuilder.Append("\r\n" + "include(VirtualRootPath + \"/js/PubFun/jsPubVar.js\");");
                strBuilder.AppendFormat("\r\n" + "include(VirtualRootPath + \"/js/{1}/js{0}WS.js\");", 
                    objPrjTabENEx.TabName,
                    objPrjTabENEx.ObjFuncModule.FuncModuleEnName4GC());
                strBuilder.AppendFormat("\r\n" + "include(VirtualRootPath + \"/js/{1}/js{0}EN.js\");", 
                    objPrjTabENEx.TabName,
                    objPrjTabENEx.ObjFuncModule.FuncModuleEnName4GC());
                strBuilder.AppendFormat("\r\n" + "include(VirtualRootPath + \"/js/{1}/js{0}BL.js\");", 
                    objPrjTabENEx.TabName,
                    objPrjTabENEx.ObjFuncModule.FuncModuleEnName4GC());


                strBuilder.Append("\r\n" + "const objTableObjWS4ControllerDelegate;");
                strBuilder.Append("\r\n" + "const theTimer;");
                strBuilder.Append("\r\n" + "const ClassName;");
                strBuilder.AppendFormat("\r\n" + "const obj{0}BL;", objPrjTabENEx.TabName);
       
                strBuilder.AppendFormat("\r\n" + "const cls{0}WS4Controller = function()",
                       objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "{");     

                strBuilder.Append("\r\n" + "this.init = function()");
                strBuilder.Append("\r\n" + "{");
                strBuilder.AppendFormat("\r\n" + "ClsName =  \"cls{0}WS4Controller\";",
                    objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n" + "obj{0}BL = new cls{0}BL();", objPrjTabENEx.TabName);

                strBuilder.Append("\r\n" + "}");
                strBuilder.AppendFormat("\r\n" + "this.init = function(strMethod, mapParam, pobj{0}EN)",
                    objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.AppendFormat("\r\n" + "ClsName =  \"cls{0}WS4Controller\";",
                    objPrjTabENEx.TabName);
                    strBuilder.AppendFormat("\r\n" + "obj{0}BL = new cls{0}BL();", objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "}");

                //生成所有的函数

                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                  clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId("this.CmPrjId"),
                  objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                .OrderBy(x => x.OrderNum);

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;

                    strTemp = A_GeneFuncCode_JavaScript(strFuncName);
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

        /// <summary>
        /// 生成Web Service转换层代码
        /// </summary>
        /// <returns></returns>
        public string A_GenTableObjWSController_JavaScript_SelfDefWs(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
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
            StringBuilder strBuilder = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp; ///临时变量;

            objWebSrvClassENEx.ClsName = string.Format("js{0}WS4SDController", objWebSrvClassENEx.ClsName);
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;
            objWebSrvClassENEx.SimpleFileName = objWebSrvClassENEx.ClsName + ".js";
            strRe_ClsName = objWebSrvClassENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objWebSrvClassENEx.FuncModuleAgcId, objWebSrvClassENEx.PrjId);

            string strIsShare = objPrjTabENEx.IsShare == true ? "_Share" : "";
            strRe_FileNameWithModuleName = string.Format("{0}{2}\\{1}", objFuncModule.FuncModuleEnName4GC(), objPrjTabENEx.SimpleFileName, strIsShare);

            strClassFName = objWebSrvClassENEx.FolderName + objWebSrvClassENEx.ClsName + ".js";
            objWebSrvClassENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objWebSrvClassENEx.PrjId); //
            try
            {
                //类名开始

                strBuilder.Append(clsPubFun4GC.GenUserInfoAndDate(objWebSrvClassENEx.CurrUserName, objWebSrvClassENEx));

                strBuilder.Append("\r\n" + ""); //

                strBuilder.Append("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// {0}({1})",
                    objWebSrvClassENEx.ClsName,
                    objWebSrvClassENEx.ClsName);

                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.Append("\r\n" + "/**");
                strBuilder.AppendFormat("\r\n" + "* Created by {0} on {1}.",
                    objWebSrvClassENEx.CurrUserName,
                    clsDateTime.getTodayStr(3));
                strBuilder.AppendFormat("\r\n" + "* 注意:该类必须与调用界面处于同一个包,否则调用不成功!", objWebSrvClassENEx.CurrUserName, clsDateTime.getTodayStr(3));
                strBuilder.Append("\r\n" + " **/");

                strBuilder.AppendFormat("\r\n" + "/// <reference path=\"js{0}WS4SD.js\" />", objWebSrvClassENEx.ClsName);
                strBuilder.Append("\r\n" + "/// <reference path=\"../PubFun/jsPubFun.js\" />");
                strBuilder.Append("\r\n" + "/// <reference path=\"../PubFun/jsTableObjWS4ControllerDelegate.js\" />");
                strBuilder.Append("\r\n" + "/// <reference path=\"../PubFun/tzDictionary.js\" />");
                //strBuilder.AppendFormat("\r\n" + "/// <reference path=\"js{0}EN.js\" />", objWebSrvClassENEx.ClsName);
                //strBuilder.AppendFormat("\r\n" + "/// <reference path=\"js{0}BL.js\" />", objWebSrvClassENEx.ClsName);

                strBuilder.Append("\r\n" + "const VirtualRootPath = getVirtualRootPath_web();//该函数存在于/js/PubFun/jsPubFun.js文件中");

                strBuilder.Append("\r\n" + "include(VirtualRootPath + \"/js/PubFun/jsPubFun.js\");");
                strBuilder.Append("\r\n" + "include(VirtualRootPath + \"/js/PubFun/jsTableObjWS4ControllerDelegate.js\");");
                strBuilder.Append("\r\n" + "include(VirtualRootPath + \"/js/PubFun/tzDictionary.js\");");
                strBuilder.Append("\r\n" + "include(VirtualRootPath + \"/js/PubFun/jsPubVar.js\");");
                strBuilder.AppendFormat("\r\n" + "include(VirtualRootPath + \"/js/{1}/js{0}WS4SD.js\");",
                    objWebSrvClassENEx.ClsName,
                    objWebSrvClassENEx.ObjFuncModule.FuncModuleEnName4GC());
                //strBuilder.AppendFormat("\r\n" + "include(VirtualRootPath + \"/js/{1}/js{0}EN.js\");",
                //    objWebSrvClassENEx.ClsName,
                //    objWebSrvClassENEx.ObjFuncModule.FuncModuleEnName4GC());
                //strBuilder.AppendFormat("\r\n" + "include(VirtualRootPath + \"/js/{1}/js{0}BL.js\");",
                //    objWebSrvClassENEx.ClsName,
                //    objWebSrvClassENEx.ObjFuncModule.FuncModuleEnName4GC());


                strBuilder.Append("\r\n" + "const objTableObjWS4ControllerDelegate4SD;");
                //strBuilder.Append("\r\n" + "const theTimer;");
                strBuilder.Append("\r\n" + "const ClassName;");
                //strBuilder.AppendFormat("\r\n" + "const obj{0}BL;", objWebSrvClassENEx.ClsName);

                strBuilder.AppendFormat("\r\n" + "const cls{0}WS4SDController = function()",
                       objWebSrvClassENEx.ClsName);
                strBuilder.Append("\r\n" + "{");

                strBuilder.Append("\r\n" + "this.init = function()");
                strBuilder.Append("\r\n" + "{");
                strBuilder.AppendFormat("\r\n" + "ClsName =  \"cls{0}WS4SDController\";",
                    objWebSrvClassENEx.ClsName);
                //strBuilder.AppendFormat("\r\n" + "obj{0}BL = new cls{0}BL();", objWebSrvClassENEx.ClsName);

                strBuilder.Append("\r\n" + "}");
                strBuilder.AppendFormat("\r\n" + "this.init = function(strMethod, mapParam, pobj{0}EN)",
                    objWebSrvClassENEx.ClsName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.AppendFormat("\r\n" + "ClsName =  \"cls{0}WS4SDController\";",
                    objWebSrvClassENEx.ClsName);
                //strBuilder.AppendFormat("\r\n" + "obj{0}BL = new cls{0}BL();", objWebSrvClassENEx.ClsName);
                strBuilder.Append("\r\n" + "}");

                //生成所有的函数

                foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
                {
                    if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                    try
                    {
                        strTemp = Gen_4WS4Controller_JavaScript_ByCommonFunction(objWebSrvFunctionsENEx);
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
                strTemp = A_GeneFuncCode_JavaScript("Gen_4WS4Controller_JavaScript_SelfDefWS_IsFinished4WebService");
                strBuilder.Append("\r\n" + strTemp);

                strBuilder.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strBuilder.ToString();
        }

        public string A_GeneFuncCode_JavaScript(string strFuncName)
        {
            try
            {
                switch (strFuncName)
                {

                    //case "Gen_4Ws_GetRecordJSONObjByKey_S_Java":
                    //    return Gen_4Ws_GetRecordJSONObjByKey_S_Java();
                    case "btnGetFirstJSONObj_Click":
                        return btnGetFirstJSONObj_Click();

                    case "Gen_Controller_JavaScript_btnGetFirstJSONObj_Click":
                        return Gen_Controller_JavaScript_btnGetFirstJSONObj_Click();

                    case "Gen_Controller_JavaScript_btnGetJSONObjByKey_Click":
                        return Gen_Controller_JavaScript_btnGetJSONObjByKey_Click();


                    case "Gen_4WS4Controller_JavaScript_GetFirstJSONObj":
                        return Gen_4WS4Controller_JavaScript_GetFirstJSONObj();
                    case "Gen_4WS4Controller_JavaScript_GetRecordObjByKey":
                        return Gen_4WS4Controller_JavaScript_GetRecordObjByKey();
                                               

                    case "IsFinished4WebService":
                        return IsFinished4WebService();


                    case "Gen_4WS4Controller_JavaScript_IsFinished4WebService":
                        return Gen_4WS4Controller_JavaScript_IsFinished4WebService();

                    case "Gen_4WS4Controller_JavaScript_SelfDefWS_IsFinished4WebService":
                        return Gen_4WS4Controller_JavaScript_SelfDefWs_IsFinished4WebService();


                    case "btnDelRecord_Click":
                        return btnDelRecord_Click();

                    case "Gen_Controller_JavaScript_btnDelRecord_Click":
                        return Gen_Controller_JavaScript_btnDelRecord_Click();

                    case "Gen_4WS4Controller_JavaScript_DelRecord":
                        return Gen_4WS4Controller_JavaScript_DelRecord();

                    //case "Gen_4Ws_run_Java":
                    //    return Gen_4Ws_run_Java();

                    case "btnAddNewRecord_Click":
                        return btnAddNewRecord_Click();

                    case "Gen_Controller_JavaScript_btnAddNewRecord_Click":
                        return Gen_Controller_JavaScript_btnAddNewRecord_Click();

                    case "Gen_Controller_JavaScript_btnAddNewRecord4GetMaxStrId_Click":
                        return Gen_Controller_JavaScript_btnAddNewRecord4GetMaxStrId_Click();
                    case "Gen_Controller_JavaScript_btnGetMaxStrId_Click":
                        return Gen_Controller_JavaScript_btnGetMaxStrId_Click();
                    case "Gen_Controller_JavaScript_btnGetMaxStrIdByPrefix_Click":
                        return Gen_Controller_JavaScript_btnGetMaxStrIdByPrefix_Click();

                    case "Gen_4WS4Controller_JavaScript_AddNewRecord":
                        return Gen_4WS4Controller_JavaScript_AddNewRecord();


                    case "btnUpdateRecord_Click":
                        return btnUpdateRecord_Click();

                    case "Gen_Controller_JavaScript_btnUpdateRecord_Click":
                        return Gen_Controller_JavaScript_btnUpdateRecord_Click();

                    case "Gen_4WS4Controller_JavaScript_UpdateRecord":
                        return Gen_4WS4Controller_JavaScript_UpdateRecord();

                    case "Gen_Controller_JavaScript_btnIsExistRecord_Click":
                        return Gen_Controller_JavaScript_btnIsExistRecord_Click();

                    //case "btnIsExistRecord_Click":
                    //    return btnIsExistRecord_Click();

                    case "Gen_4WS4Controller_JavaScript_IsExistRecord":
                        return Gen_4WS4Controller_JavaScript_IsExistRecord();
                    case "Gen_4WS4Controller_JavaScript_GetRecCountByCond":
                        return Gen_4WS4Controller_JavaScript_GetRecCountByCond();
                        
                    case "Gen_4WS4Controller_JavaScript_GetMaxStrId":
                        return Gen_4WS4Controller_JavaScript_GetMaxStrId();

                    case "Gen_4WS4Controller_JavaScript_GetMaxStrIdByPrefix":
                        return Gen_4WS4Controller_JavaScript_GetMaxStrIdByPrefix();

                    case "btnGetJSONObjLst_Click":
                        return btnGetJSONObjLst_Click();

                    case "Gen_Controller_JavaScript_btnGetJSONObjLst_Click":
                        return Gen_Controller_JavaScript_btnGetJSONObjLst_Click();
                    case "Gen_Controller_JavaScript_btnGetTopJSONObjLst_Click":
                        return Gen_Controller_JavaScript_btnGetTopJSONObjLst_Click();


                    case "Gen_4WS4Controller_JavaScript_GetJSONObjLst":
                        return Gen_4WS4Controller_JavaScript_GetJSONObjLst();
                    case "Gen_4WS4Controller_JavaScript_GetTopJSONObjLst":
                        return Gen_4WS4Controller_JavaScript_GetTopJSONObjLst();
                    case "Gen_4WS4Controller_JavaScript_GetJSONObjLstByPager":
                        return Gen_4WS4Controller_JavaScript_GetJSONObjLstByPager();

                    case "ErrNo":
                        return gfunpErrNo();

                    case "GenDdlBindFunction":
                        return GenDdlBindFunction();

                    case "GenComboBoxBindFunction":
                        return GenComboBoxBindFunction();
                    case "GenBindListView":
                        return GenBindListView();

                                 
                    case "GetStrLen":
                        return GengetStrLen();
                    
                    default:
                        string strMsg = string.Format("功能名:{1}在Switch没有处理,请检查!({0})",
                             clsStackTrace.GetCurrClassFunction(), strFuncName);
                        throw new Exception(strMsg);
                        //            return "///该1函数不存在:" + strFuncName;
                }
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


        /// <summary>
        /// 继承Runnable类必须实现的【run】函数
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_JavaScript_AddNewRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 添加新记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的对象</param>",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "this.AddNewRecord = function(pobj{0}EN)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "if (pobj{0}EN.getIsCheckProperty() === false) ", objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const obj{0}BL = new cls{0}BL(); ", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}BL.CheckPropertyNew(pobj{0}EN); ", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (err)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strMsg = String.format(\"{0}。检查表对象字段属性时发生错误!\", err);");
            strBuilder.Append("\r\n" + "throw strMsg;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");


            strBuilder.Append("\r\n" + "const values = new Dictionary();");
            strBuilder.AppendFormat("\r\n" + "const obj{0}WS = new cls{0}WS();",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "obj{0}WS.init(\"AddNewRecordByJSON\", values, pobj{0}EN, IsFinished4WebService);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS.main();",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "//theTimer = setInterval(function(){IsFinished4WebService()}, 1000);");
            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

        /// <summary>
        /// 继承Runnable类必须实现的【run】
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_JavaScript_UpdateRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 修改记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要修改的对象</param>",
    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "this.UpdateRecord = function(pobj{0}EN)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "if (pobj{0}EN.getIsCheckProperty() === false) ", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const obj{0}BL = new cls{0}BL(); ", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}BL.CheckProperty4Update(pobj{0}EN); ", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (err)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strMsg = String.format(\"{0}。检查表对象字段属性时发生错误!\", err);");
            strBuilder.Append("\r\n" + "throw strMsg;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            
            strBuilder.Append("\r\n" + "const values = new Dictionary();");

            strBuilder.AppendFormat("\r\n" + "const obj{0}WS = new cls{0}WS();",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "obj{0}WS.init(\"UpdateRecordByJSON\", values, pobj{0}EN, IsFinished4WebService);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS.main();",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "//theTimer = setInterval(function(){IsFinished4WebService()}, 1000);");
            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

        /// <summary>
        /// 通用的调用WebService函数 
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_JavaScript_DelRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 通用的调用WebService函数");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">需要删除的关键字的值</param>",
                objKeyField.ObjFieldTabENEx.PrivPropName);
            strBuilder.Append("\r\n /// <returns>删除是否成功？</returns>");
            strBuilder.AppendFormat("\r\n" + "this.DelRecord = function({0}) ",
                objKeyField.PrivFuncName,
                objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const values = new Dictionary();");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
            {
                strBuilder.AppendFormat("\r\n" + "values.add(\"{0}\", {0});",
                    objKeyField.PrivFuncName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "values.add(\"{0}\", String({0}));",
                    objKeyField.PrivFuncName);
            }
            strBuilder.AppendFormat("\r\n" + "const pobj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);
    
            strBuilder.AppendFormat("\r\n" + "const obj{0}WS = new cls{0}WS();",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "obj{0}WS.init(\"DelRecord\", values, pobj{0}EN, IsFinished4WebService);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS.main();",
                objPrjTabENEx.TabName);


            strBuilder.Append("\r\n" + "//theTimer = setInterval(function(){IsFinished4WebService()}, 1000);");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_4WS4Controller_JavaScript_GetFirstJSONObj()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取相应的第一条记录的对象");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">条件</strWhereCond>");
            strBuilder.Append("\r\n /// <returns>获取相应的记录的对象</returns>");
            strBuilder.AppendFormat("\r\n" + "this.GetFirst{0} = function(strWhereCond)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const values = new Dictionary();");
            strBuilder.Append("\r\n" + "values.add(\"strWhereCond\", strWhereCond);");
            strBuilder.AppendFormat("\r\n" + "const pobj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);        

            strBuilder.AppendFormat("\r\n" + "const obj{0}WS = new cls{0}WS();",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "obj{0}WS.init(\"GetFirstJSONObj\", values, pobj{0}EN, IsFinished4WebService);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS.main();",
                objPrjTabENEx.TabName);


            strBuilder.Append("\r\n" + "//theTimer = setInterval(function(){IsFinished4WebService()}, 1000);");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }
        /// <summary>
        /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_JavaScript_GetMaxStrId()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            //    strBuilder.Append("\r\n /// <param name = \"strWhereCond\">检查存在的条件</param>");
            strBuilder.Append("\r\n /// <returns>当前表关键字值的最大值,再加1</returns>");
            strBuilder.Append("\r\n" + "this.GetMaxStrId = function()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const values = new Dictionary();");
            //    strBuilder.Append("\r\n" + "values.add(\"strWhereCond\", strWhereCond);");
            strBuilder.AppendFormat("\r\n" + "const pobj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "const obj{0}WS = new cls{0}WS();",
    objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "obj{0}WS.init(\"GetMaxStrId\", values, pobj{0}EN, IsFinished4WebService);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS.main();",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "//theTimer = setInterval(function(){IsFinished4WebService()}, 1000);");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_JavaScript_GetMaxStrIdByPrefix()
        {
            if (objKeyField.PrimaryTypeId != enumPrimaryType.StringAutoAddPrimaryKeyWithPrefix_06) return "";

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strPrefix\">关键字值的前缀</param>");
            strBuilder.Append("\r\n /// <returns>当前表关键字值的最大值,再加1</returns>");
            strBuilder.Append("\r\n" + "this.GetMaxStrIdByPrefix = function(strPrefix)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const values = new Dictionary();");
            strBuilder.Append("\r\n" + "values.add(\"strPrefix\", strPrefix);");
            strBuilder.AppendFormat("\r\n" + "const pobj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);
            
            strBuilder.AppendFormat("\r\n" + "const obj{0}WS = new cls{0}WS();",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "obj{0}WS.init(\"GetMaxStrIdByPrefix\", values, pobj{0}EN, IsFinished4WebService);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS.main();",
                objPrjTabENEx.TabName);


            strBuilder.Append("\r\n" + "//theTimer = setInterval(function(){IsFinished4WebService()}, 1000);");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// 根据关键字获取相应的记录的对象 
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_JavaScript_GetJSONObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取相应的记录对象列表");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">条件</strWhereCond>");
            strBuilder.Append("\r\n /// <returns>获取相应的记录的对象</returns>");
            strBuilder.AppendFormat("\r\n" + "this.GetJSONObjLst = function(strWhereCond)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const values = new Dictionary();");
            strBuilder.AppendFormat("\r\n" + "values.add(\"strWhereCond\", strWhereCond);");
            strBuilder.AppendFormat("\r\n" + "const pobj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "const obj{0}WS = new cls{0}WS();",
    objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "obj{0}WS.init(\"GetJSONObjLst\", values, pobj{0}EN, IsFinished4WebService);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS.main();",
                objPrjTabENEx.TabName);



            strBuilder.Append("\r\n" + "//theTimer = setInterval(function(){IsFinished4WebService()}, 1000);");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// 根据关键字获取相应的记录的对象 
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_JavaScript_GetTopJSONObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取顶部相应的记录对象列表");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"intTopSize\">顶部记录数</strWhereCond>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">条件</strWhereCond>");
            strBuilder.Append("\r\n /// <returns>获取相应的记录的对象</returns>");
            strBuilder.AppendFormat("\r\n" + "this.GetTopJSONObjLst = function(intTopSize, strWhereCond)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const values = new Dictionary();");
            strBuilder.AppendFormat("\r\n" + "values.add(\"intTopSize\", intTopSize);");
            strBuilder.AppendFormat("\r\n" + "values.add(\"strWhereCond\", strWhereCond);");
            strBuilder.AppendFormat("\r\n" + "const pobj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "const obj{0}WS = new cls{0}WS();",
    objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "obj{0}WS.init(\"GetTopJSONObjLst\", values, pobj{0}EN, IsFinished4WebService);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS.main();",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "//theTimer = setInterval(function(){IsFinished4WebService()}, 1000);");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// 根据关键字获取相应的记录的对象 
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_JavaScript_GetJSONObjLstByPager()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取顶部相应的记录对象列表");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"intPageIndex\">页序号</param>");
            strBuilder.Append("\r\n /// <param name = \"intPageSize\">页记录数</param>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">条件</param>");
            strBuilder.Append("\r\n /// <param name = \"strOrderBy\">排序方式</param>");
            strBuilder.Append("\r\n /// <returns>获取相应的记录的对象</returns>");
            strBuilder.AppendFormat("\r\n" + "this.GetJSONObjLstByPager = function(intPageIndex,intPageSize, strWhereCond, strOrderBy)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const values = new Dictionary();");
            strBuilder.AppendFormat("\r\n" + "values.add(\"intPageIndex\", intPageIndex);");
            strBuilder.AppendFormat("\r\n" + "values.add(\"intPageSize\", intPageSize);");
            strBuilder.AppendFormat("\r\n" + "values.add(\"strWhereCond\", strWhereCond);");
            strBuilder.AppendFormat("\r\n" + "values.add(\"strOrderBy\", strOrderBy);");
            strBuilder.AppendFormat("\r\n" + "const pobj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "const obj{0}WS = new cls{0}WS();",
    objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "obj{0}WS.init(\"GetJSONObjLstByPager\", values, pobj{0}EN, IsFinished4WebService);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS.main();",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "//theTimer = setInterval(function(){IsFinished4WebService()}, 1000);");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }



        /// <summary>
        /// 根据关键字获取相应的记录的对象 
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_JavaScript_GetRecordObjByKey()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据关键字获取相应的记录的对象");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">关键字的值</param>",
                objKeyField.PrivFuncName);
            strBuilder.Append("\r\n /// <returns>根据关键字获取的对象</returns>");
            strBuilder.AppendFormat("\r\n" + "this.GetObjBy{1} = function({2})",
                objPrjTabENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName,
                objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const values = new Dictionary();");

            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
            {
                strBuilder.AppendFormat("\r\n" + "values.add(\"{0}\", {0});",
                    objKeyField.PrivFuncName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "values.add(\"{0}\", String({0}));",
                    objKeyField.PrivFuncName);
            }

            strBuilder.AppendFormat("\r\n" + "const pobj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "const obj{0}WS = new cls{0}WS();",
    objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "obj{0}WS.init(\"GetJSONObjBy{1}\", values, pobj{0}EN, IsFinished4WebService);",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS.main();",
                objPrjTabENEx.TabName);


            strBuilder.Append("\r\n" + "//theTimer = setInterval(function(){IsFinished4WebService()}, 1000);");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// 根据关键字获取相应的记录的对象
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_JavaScript_IsExistRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件在表中检查是否满足条件的记录");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">检查存在的条件</param>");
            strBuilder.Append("\r\n /// <returns>存在返回true,不存在返回：false</returns>");
            strBuilder.Append("\r\n" + "this.IsExistRecord = function(strWhereCond)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const values = new Dictionary();");
            strBuilder.Append("\r\n" + "values.add(\"strWhereCond\", strWhereCond);");

            strBuilder.AppendFormat("\r\n" + "const pobj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "const obj{0}WS = new cls{0}WS();",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "obj{0}WS.init(\"IsExistRecord\", values, pobj{0}EN, IsFinished4WebService);",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS.main();",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "//theTimer = setInterval(function(){IsFinished4WebService()}, 1000);");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }
        public string Gen_4WS4Controller_JavaScript_GetRecCountByCond()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件在表中检查是否满足条件的记录");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">检查存在的条件</param>");
            strBuilder.Append("\r\n /// <returns>存在返回true,不存在返回：false</returns>");
            strBuilder.Append("\r\n" + "this.GetRecCountByCond = function(strWhereCond)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const values = new Dictionary();");
            strBuilder.Append("\r\n" + "values.add(\"strWhereCond\", strWhereCond);");

            strBuilder.AppendFormat("\r\n" + "const pobj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "const obj{0}WS = new cls{0}WS();",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "obj{0}WS.init(\"GetRecCountByCond\", values, pobj{0}EN, IsFinished4WebService);",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS.main();",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "//theTimer = setInterval(function(){IsFinished4WebService()}, 1000);");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }


        /// <summary>
        /// 根据关键字获取相应的记录的对象 
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_JavaScript_IsFinished4WebService()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 调用WebService是否完成函数");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>获取的调用WebService是否完成函数返回的数据</returns>");
            strBuilder.Append("\r\n" + "function IsFinished4WebService()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "let strInfo = \"\";");
            strBuilder.AppendFormat("\r\n" + "if (ResponseData.IsFinished === true)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//clearInterval(theTimer);");
            strBuilder.AppendFormat("\r\n" + "const obj{0}EN;",
              objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "const arr{0}ObjLst;",
                        objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "const bolResult;");
            strBuilder.Append("\r\n" + "const intResult;");

            strBuilder.AppendFormat("\r\n" + "const strResult = ResponseData.data;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "switch(ResponseData.what)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "case 1: //\"GetObjBy{1}\":",
                objPrjTabENEx.TabName,
                objKeyField.FldName);

            strBuilder.AppendFormat("\r\n" + "if (ResponseData.errorId > 0)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "strInfo = String.format(\"获取对象不成功!调用GetObjBy{1}函数出错。{{0}}\", ResponseData.faultString);",
                objPrjTabENEx.TabName,
                objKeyField.FldName, "{", "}");


            strBuilder.Append("\r\n" + "myShowErrorMsg(strInfo);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
          
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = obj{0}BL.GetObjByJSONStr(strResult);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "//obj{0}EN = JSON.Parse(strResult);",
                objPrjTabENEx.TabName);


            strBuilder.AppendFormat("\r\n" + "ResponseData.returnObject = obj{0}EN;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{1}(ResponseData, ClassName);",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjByKey,
                enumDict4GC_DictKey2.conFinished));
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{2}(obj{0}EN, ClassName);",
                 objPrjTabENEx.TabName,
                 objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjByKey,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "return;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "break;");
            strBuilder.AppendFormat("\r\n" + "case 2: //\"GetJSONObjLst\":",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "if (ResponseData.errorId > 0)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "strInfo = String.format(\"获取对象列表不成功!调用GetJSONObjLst函数出错。{{0}}\", ResponseData.faultString);",
                objPrjTabENEx.TabName, "{", "}");

            strBuilder.Append("\r\n" + "myShowErrorMsg(strInfo);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLst = new Array<cls{0}EN>();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLst = obj{0}BL.GetObjLstByJSONStr(strResult);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "//arr{0}ObjLst = JSON.Parse(strResult);",
     objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "ResponseData.returnObjectList = arr{0}ObjLst;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{1}(ResponseData, ClassName);", 
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLst,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{2}(arr{0}ObjLst, ClassName);",
                    objPrjTabENEx.TabName,
                 objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLst,
                enumDict4GC_DictKey2.conCorrectFinished));
            strBuilder.Append("\r\n" + "return;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "break;");


            strBuilder.Append("\r\n" + "case 3: //\"AddNewRecord\":");

            strBuilder.AppendFormat("\r\n" + "if (ResponseData.errorId > 0)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "");
            strBuilder.AppendFormat("\r\n" + "strInfo = String.format(\"添加不成功,调用AddNewRecord函数出错。{{0}}\", ResponseData.faultString);",
                objPrjTabENEx.TabName, "{", "}");

            strBuilder.Append("\r\n" + "myShowErrorMsg(strInfo);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "bolResult = myBool(strResult);");
            strBuilder.Append("\r\n" + "ResponseData.returnBool = bolResult;");

            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{1}(ResponseData, \"{0}\");",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{1}(bolResult, \"{0}\");",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "return;");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "break;");
            strBuilder.Append("\r\n" + "case 4: //\"UpdateRecord\":");
            strBuilder.AppendFormat("\r\n" + "if (ResponseData.errorId > 0)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "strInfo = String.format(\"修改不成功!调用UpdateRecord函数出错。{{0}}\", ResponseData.faultString);",
                objPrjTabENEx.TabName, "{", "}");

            strBuilder.Append("\r\n" + "myShowErrorMsg(strInfo);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "bolResult = myBool(strResult);");
            strBuilder.Append("\r\n" + "ResponseData.returnBool = bolResult;");

            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{1}(ResponseData, ClassName);",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conUpdateRecordByJSON,
                enumDict4GC_DictKey2.conFinished));


            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{1}(bolResult, ClassName);",
                objPrjTabENEx.ClsName,
                   clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conUpdateRecordByJSON,
                enumDict4GC_DictKey2.conCorrectFinished));
            strBuilder.Append("\r\n" + "return;");

            strBuilder.Append("\r\n" + "}");


            strBuilder.Append("\r\n" + "break;");
            strBuilder.Append("\r\n" + "case 5: //\"DelRecord\":");

            strBuilder.AppendFormat("\r\n" + "if (ResponseData.errorId > 0)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "strInfo = String.format(\"删除不成功!调用DelRecord函数出错。{{0}}\", ResponseData.faultString);",
                objPrjTabENEx.TabName, "{", "}");


            strBuilder.Append("\r\n" + "myShowErrorMsg(strInfo);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "bolResult = myBool(strResult);");
            strBuilder.Append("\r\n" + "ResponseData.returnBool = bolResult;");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{1}(ResponseData, ClassName);",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conDelRecord,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{1}(bolResult, ClassName);",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conDelRecord,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "return;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "break;");
            strBuilder.AppendFormat("\r\n" + "case 6: //\"GetFirst{0}\":",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "if (ResponseData.errorId > 0)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "strInfo = String.format(\"获取第一条记录不成功!调用GetFirst{0}函数出错。{{0}}\", ResponseData.faultString);",
                objPrjTabENEx.TabName, "{", "}");

            strBuilder.Append("\r\n" + "myShowErrorMsg(strInfo);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
      
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = obj{0}BL.GetObjByJSONStr(strResult);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "//obj{0}EN = JSON.Parse(strResult);",
objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "ResponseData.returnObject = obj{0}EN;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "//通过WebService执行GetFirstJSONObj,返回的事件函数,可能需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{1}(ResponseData, ClassName);",
                objPrjTabENEx.ClsName,
                    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetFirstJSONObj,
                enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "//通过WebService执行GetFirstJSONObj,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{2}(obj{0}EN, ClassName);",
                 objPrjTabENEx.TabName,
                 objPrjTabENEx.ClsName,
                   clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetFirstJSONObj,
                enumDict4GC_DictKey2.conCorrectFinished));
            strBuilder.Append("\r\n" + "return;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "break;");
            strBuilder.Append("\r\n" + "case 7: //\"IsExistRecord\":");
            strBuilder.AppendFormat("\r\n" + "if (ResponseData.errorId > 0)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "strInfo = String.format(\"调用IsExistRecord函数出错。{{0}}\", ResponseData.faultString);",
                objPrjTabENEx.TabName, "{", "}");

            strBuilder.Append("\r\n" + "myShowErrorMsg(strInfo);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "bolResult = myBool(strResult);");
            strBuilder.Append("\r\n" + "ResponseData.returnBool = bolResult;");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{1}(ResponseData, ClassName);",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conFinished));
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{1}(bolResult, ClassName);",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "return;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "break;");

            strBuilder.Append("\r\n" + "case 8: //\"GetMaxStrId\":");
            strBuilder.AppendFormat("\r\n" + "if (ResponseData.errorId > 0)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "strInfo = String.format(\"调用GetMaxStrId函数出错。{{0}}\", ResponseData.faultString);",
                objPrjTabENEx.TabName, "{", "}");

            strBuilder.Append("\r\n" + "myShowErrorMsg(strInfo);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "const strResult = clsPubFun.myBool(strResult);");
            strBuilder.Append("\r\n" + "ResponseData.returnString = strResult;");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{1}(ResponseData, ClassName);",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{1}(strResult, ClassName);",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "return;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "break;");

            strBuilder.Append("\r\n" + "case 9: //\"GetMaxStrIdByPrefix\":");
            strBuilder.AppendFormat("\r\n" + "if (ResponseData.errorId > 0)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "strInfo = String.format(\"调用GetMaxStrIdByPrefix函数出错。{{0}}\", ResponseData.faultString);",
                objPrjTabENEx.TabName, "{", "}");

            strBuilder.Append("\r\n" + "myShowErrorMsg(strInfo);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "const strResult = clsPubFun.myBool(strResult);");
            strBuilder.Append("\r\n" + "ResponseData.returnString = strResult;");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{1}(ResponseData, ClassName);",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrIdByPrefix,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{1}(strResult, ClassName);",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrIdByPrefix,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "return;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "break;");
            strBuilder.AppendFormat("\r\n" + "case 10: //\"GetTopJSONObjLst\":",
objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "if (ResponseData.errorId > 0)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "strInfo = String.format(\"获取顶部对象列表不成功!调用GetJSONObjLst函数出错。{{0}}\", ResponseData.faultString);",
                objPrjTabENEx.TabName, "{", "}");

            strBuilder.Append("\r\n" + "myShowErrorMsg(strInfo);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLst = new Array<cls{0}EN>();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLst = obj{0}BL.GetObjLstByJSONStr(strResult);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "//arr{0}ObjLst = JSON.parse(strResult);",
     objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "ResponseData.returnObjectList = arr{0}ObjLst;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{1}(ResponseData, ClassName);",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetTopRecordJSONObjLst,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{2}(arr{0}ObjLst, ClassName);",
                    objPrjTabENEx.TabName,
                 objPrjTabENEx.ClsName,
                 clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetTopRecordJSONObjLst,
                 enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "return;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "break;");

            strBuilder.AppendFormat("\r\n" + "case 11: //\"GetJSONObjLstByPager\":",
objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "if (ResponseData.errorId > 0)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "strInfo = String.format(\"获取分页对象列表不成功!调用GetJSONObjLstByPager函数出错。{{0}}\", ResponseData.faultString);",
                objPrjTabENEx.TabName, "{", "}");

            strBuilder.Append("\r\n" + "myShowErrorMsg(strInfo);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLst = new Array<cls{0}EN>();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLst = obj{0}BL.GetObjLstByJSONStr(strResult);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "//arr{0}ObjLst = JSON.parse(strResult);",
     objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "ResponseData.returnObjectList = arr{0}ObjLst;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{1}(ResponseData, ClassName);",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLstByPager,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{2}(arr{0}ObjLst, ClassName);",
                    objPrjTabENEx.TabName,
                 objPrjTabENEx.ClsName,
                 clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLstByPager,
                 enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "return;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "break;");
            strBuilder.Append("\r\n" + "case 12: //\"GetRecCountByCond\":");
            strBuilder.AppendFormat("\r\n" + "if (ResponseData.errorId > 0)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "strInfo = String.format(\"调用GetRecCountByCond函数出错。{{0}}\", ResponseData.faultString);",
                objPrjTabENEx.TabName, "{", "}");

            strBuilder.Append("\r\n" + "myShowErrorMsg(strInfo);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "intResult = parseInt(strResult);");
            strBuilder.Append("\r\n" + "ResponseData.returnBool = intResult;");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{1}(ResponseData, ClassName);",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecCountByCond,
                enumDict4GC_DictKey2.conFinished));
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{1}(intResult, ClassName);",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecCountByCond,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "return;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "break;");

            strBuilder.Append("\r\n" + "default:");
            strBuilder.Append("\r\n" + "break;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "myAlert(strResult);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// 根据关键字获取相应的记录的对象 
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_JavaScript_SelfDefWs_IsFinished4WebService()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 调用WebService是否完成函数");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>获取的调用WebService是否完成函数返回的数据</returns>");
            strBuilder.Append("\r\n" + "function IsFinished4WebService()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "let strInfo = \"\";");
            strBuilder.AppendFormat("\r\n" + "if (ResponseData.IsFinished === true)",
                objWebSrvClassENEx.ClsName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//clearInterval(theTimer);");
            strBuilder.AppendFormat("\r\n" + "const obj{0}EN;",
              objWebSrvClassENEx.ClsName);
            strBuilder.AppendFormat("\r\n" + "const arr{0}ObjLst;",
                        objWebSrvClassENEx.ClsName);
            strBuilder.Append("\r\n" + "const bolResult;");
            strBuilder.Append("\r\n" + "const intResult;");

            strBuilder.AppendFormat("\r\n" + "const strResult = ResponseData.data;",
                objWebSrvClassENEx.ClsName);
            strBuilder.AppendFormat("\r\n" + "switch(ResponseData.what)",
                objWebSrvClassENEx.ClsName);
            strBuilder.Append("\r\n" + "{");

            ////-----------------
            //strBuilder.AppendFormat("\r\n" + "case {1}: //\"{0}\":",
            //               objWebSrvFunctionsENEx.FunctionName,
            //               intIndex);
            //strBuilder.Append("\r\n" + " //获取传递的数据 ");
            //strBuilder.Append("\r\n" + " data = msg.getData();");
            ////                    int count = data.getInt("COUNT");
            //strBuilder.Append("\r\n" + "strResultValue = data.getString(\"strResultValue\");");
            //strBuilder.AppendFormat("\r\n" + " if ({0}WS4SD.objResponseData.errorId >= 2)",
            //        objWebSrvClassENEx.ClsName);
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + " objTableObjWS4ControllerDelegate.{1}(objResponseData, \"cls{0}WS4Controller\", \"{2}\");",
            //    objWebSrvClassENEx.ClsName,
            //   clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
            //enumDict4GC_DictKey2.conFinished),
            //   objWebSrvFunctionsENEx.FunctionName);

            //strBuilder.Append("\r\n" + "return;");
            //strBuilder.Append("\r\n" + "}");

            //strBuilder.AppendFormat("\r\n" + "else if ({0}WS4SD.objResponseData.errorId == 1)",
            //    objWebSrvClassENEx.ClsName);
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "String strInfo = String.format(\"调用{0}函数出错。%s\", {0}WS4SD.objResponseData.faultString);",
            //    objWebSrvClassENEx.ClsName);
            //strBuilder.Append("\r\n" + "objResponseData.faultString = strInfo;");
            //strBuilder.AppendFormat("\r\n" + " objTableObjWS4ControllerDelegate.{1}(objResponseData, \"{0}WS4Controller\", \"{2}\");",
            //     objWebSrvClassENEx.ClsName,
            //    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
            //    enumDict4GC_DictKey2.conFinished),
            //    objWebSrvFunctionsENEx.FunctionName);
            //strBuilder.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo);");
            //strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "else");
            //strBuilder.Append("\r\n" + "{");

            //strBuilder.AppendFormat("\r\n" + "objResponseData.returnString = strResultValue;");

            //strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{2}(strResultValue, \"{0}\", \"{1}\");",
            //     objWebSrvClassENEx.ClsName, objWebSrvFunctionsENEx.FunctionName,
            //     clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
            //     enumDict4GC_DictKey2.conCorrectFinished));

            //strBuilder.Append("\r\n" + "return;");
            //strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "break;");
            ////intIndex++;


            int intIndex = 50;
            foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
            {
                if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;

                strBuilder.AppendFormat("\r\n" + "case {1}: //\"{0}\":",
                                objWebSrvFunctionsENEx.FunctionName, intIndex);

                strBuilder.AppendFormat("\r\n" + "if (ResponseData.errorId > 0)",
                objWebSrvClassENEx.ClsName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.AppendFormat("\r\n" + "strInfo = String.format(\"获取对象不成功!调用{1}函数出错。{{0}}\", ResponseData.faultString);",
                    objWebSrvClassENEx.ClsName,
                    objWebSrvFunctionsENEx.FunctionName, "{", "}");

                strBuilder.Append("\r\n" + "myShowErrorMsg(strInfo);");
                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "else");
                strBuilder.Append("\r\n" + "{");


                strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate4SD.{1}(ResponseData, ClassName, \"{2}\");",
                    objWebSrvClassENEx.ClsName,
                    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
                    enumDict4GC_DictKey2.conFinished),
                    objWebSrvFunctionsENEx.FunctionName);
                strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate4SD.{1}(strResult, ClassName, \"{2}\");",
                     objWebSrvClassENEx.ClsName,
                     clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
                    enumDict4GC_DictKey2.conCorrectFinished),
                    objWebSrvFunctionsENEx.FunctionName);

                strBuilder.Append("\r\n" + "return;");
                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "break;");
                intIndex++;
            }
            strBuilder.Append("\r\n" + "default:");
            strBuilder.Append("\r\n" + "break;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "myAlert(strResult);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// 继承Runnable类必须实现的【run】函数  
        /// </summary>
        /// <returns></returns>
        public string Gen_Controller_JavaScript_btnAddNewRecord_Click()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 添加新记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.Append("\r\n" + "this.btnAddNewRecord_Click = function() {");
            strBuilder.AppendFormat("\r\n" + "const iobj{0}_AddNewRecord = new icls{0}_AddNewRecord();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}_AddNewRecord.main();",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "const icls{0}_AddNewRecord = function()",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "this.init = function()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "this.main = function()");
            strBuilder.Append("\r\n" + "{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                if (objField.JavaType == "boolean")
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.set{1}({2});",
                     objPrjTabENEx.TabName,
                     objField.ObjFieldTabENEx.FldName,
                     objField.ObjFieldTabENEx.DefaultValue4Test_Swift);
                    continue;
                }
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.set{1}(\"{2}\");",
                       objPrjTabENEx.TabName,
                       objField.ObjFieldTabENEx.FldName,
                       objField.ObjFieldTabENEx.DefaultValue4Test_Swift);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.set{1}({2});",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                          objField.ObjFieldTabENEx.DefaultValue4Test_Swift);
                }
            }
            strBuilder.AppendFormat("\r\n" + "const obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + " obj{0}WS4Controller.init();",
    objPrjTabENEx.TabName);


            strBuilder.Append("\r\n" + "objTableObjWS4ControllerDelegate = new clsTableObjWS4ControllerDelegate();");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{0} = function(objResponseData, strClassName) ",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "{0}_{1}4Add(objResponseData, strClassName);",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{0} = function(returnBool, strClassName) ",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conCorrectFinished));
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "{0}_{1}4Add(returnBool, strClassName);",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "const strWhereCond = String.format(\"{1} = '{{0}}'\", obj{0}EN.{1});",
                objPrjTabENEx.TabName,
                objKeyField.FldName, "{", "}");
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.IsExistRecord(strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行IsExistRecord,返回的事件函数,可能需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}4Add(objResponseData, strClassName)",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行IsExistRecord,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}4Add(returnBool, strClassName)",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "let strInfo = \"\";");

            strBuilder.Append("\r\n" + "if (returnBool === false)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + " obj{0}WS4Controller.init();",
    objPrjTabENEx.TabName);
            
            strBuilder.Append("\r\n" + "objTableObjWS4ControllerDelegate = new clsTableObjWS4ControllerDelegate();");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{0} = function(objResponseData, strClassName) ",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
                enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "{0}_{1}(objResponseData, strClassName);",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{0} = function(returnBool, strClassName) ",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
                enumDict4GC_DictKey2.conCorrectFinished));
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "{0}_{1}(returnBool, strClassName);",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//检查表对象的属性是否合法");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const obj{0}BL = new cls{0}BL();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}BL.CheckPropertyNew(obj{0}EN); ", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.AddNewRecord(obj{0}EN);",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (err)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "myShowErrorMsg(err);");
            strBuilder.Append("\r\n" + "return;");
            strBuilder.Append("\r\n" + "}");


            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "strInfo = String.format(\"关键字为‘{{0}}’的记录已经存在,不能再添加!\", obj{0}EN.{1});",
                objPrjTabENEx.TabName,
                objKeyField.FldName, "{", "}");



            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "myShowErrorMsg(strInfo);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行AddNewRecord,返回的事件函数,可能需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}(objResponseData, strClassName)",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行AddNewRecord,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}(returnBool, strClassName)",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strInfo = \"\";");

            strBuilder.Append("\r\n" + "if (returnBool === true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strInfo = \"添加记录成功!\";");
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "myAlert(strInfo);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strInfo = \"添加记录不成功!\";");
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "myShowErrorMsg(strInfo);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_btnAddNewRecord4GetMaxStrId_Click()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 添加新记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.Append("\r\n" + "this.btnAddNewRecord4GetMaxStrId_Click = function() {");
            strBuilder.AppendFormat("\r\n" + "const iobj{0}_AddNewRecord4GetMaxStrId = new icls{0}_AddNewRecord4GetMaxStrId();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}_AddNewRecord4GetMaxStrId.main();",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "const icls{0}_AddNewRecord4GetMaxStrId = function()",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "this.init = function()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "this.main = function()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const obj{0}WS4Controller = new cls{0}WS4Controller();",
           objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + " obj{0}WS4Controller.init();",
    objPrjTabENEx.TabName);


            strBuilder.Append("\r\n" + "objTableObjWS4ControllerDelegate = new clsTableObjWS4ControllerDelegate();");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{0} = function(objResponseData, strClassName) ",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "{0}_{1}(objResponseData, strClassName);",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{0} = function(returnBool, strClassName) ",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conCorrectFinished));
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "{0}_{1}(returnString, strClassName);",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.GetMaxStrId();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//通过WebService执行GetMaxStrId,返回的事件函数,可能需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}(objResponseData, strClassName)",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行GetMaxStrId,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}(returnString, strClassName)",
                objPrjTabENEx.TabName,
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
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                    {
                        strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = \"{2}\";",
                           objPrjTabENEx.TabName,
                           objField.ObjFieldTabENEx.FldName,
                           objField.ObjFieldTabENEx.DefaultValue4Test_Swift);
                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                              objPrjTabENEx.TabName,
                              objField.ObjFieldTabENEx.FldName,
                              objField.ObjFieldTabENEx.DefaultValue4Test_Swift);
                    }
                }
            }
            strBuilder.AppendFormat("\r\n" + "const obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + " obj{0}WS4Controller.init();",
    objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            
            strBuilder.AppendFormat("\r\n" + "const strWhereCond = String.format(\"{1} = '{{0}}'\", obj{0}EN.{1});",
                objPrjTabENEx.TabName,
                objKeyField.FldName, "{", "}");

            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.IsExistRecord(strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行IsExistRecord,返回的事件函数,可能需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}(objResponseData, strClassName)",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行IsExistRecord,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}(returnBool, strClassName)",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strInfo = \"\";");

            strBuilder.Append("\r\n" + "if (returnBool === false)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + " obj{0}WS4Controller.init();",
    objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.AddNewRecord(obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "strInfo = String.format(\"关键字为‘{{0}}’的记录已经存在,不能再添加!\", obj{0}EN.{1});",
                objPrjTabENEx.TabName,
                objKeyField.FldName, "{", "}");


            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "myShowErrorMsg(strInfo);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行AddNewRecord,返回的事件函数,可能需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}(objResponseData, strClassName)",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行AddNewRecord,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}(returnBool, strClassName)",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strInfo = \"\";");
            strBuilder.Append("\r\n" + "if (returnBool === true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strInfo = \"添加记录成功!\";");
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "myAlert(strInfo);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strInfo = \"添加记录不成功!\";");
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "myShowErrorMsg(strInfo);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_btnGetMaxStrId_Click()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 获取当前表关键字值的最大值,再加1,避免重复");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.Append("\r\n" + "this.btnGetMaxStrId_Click = function() {");
            strBuilder.AppendFormat("\r\n" + "const iobj{0}GetMaxStrId = new icls{0}GetMaxStrId();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetMaxStrId.main();",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "const icls{0}GetMaxStrId = function()",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "this.init = function()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "this.main = function()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const obj{0}WS4Controller = new cls{0}WS4Controller();",
           objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + " obj{0}WS4Controller.init();",
    objPrjTabENEx.TabName);


            strBuilder.Append("\r\n" + "objTableObjWS4ControllerDelegate = new clsTableObjWS4ControllerDelegate();");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{0} = function(objResponseData, strClassName) ",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "{0}_{1}(objResponseData, strClassName);",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{0} = function(returnString, strClassName) ",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conCorrectFinished));
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "{0}_{1}(returnString, strClassName);",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.GetMaxStrId();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//通过WebService执行GetMaxStrId,返回的事件函数,可能需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}(objResponseData, strClassName)",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行GetMaxStrId,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}(returnString, strClassName)",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strInfo = \"\";");
            strBuilder.Append("\r\n" + "if (returnString === \"\")");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "strInfo = \"获取表{0}的最大关键字为空,不成功,请检查!\";",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "myShowErrorMsg(strInfo);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "strInfo =String.format(\"获取表{0}的最大关键字为：{{0}}\", returnString);",
                objPrjTabENEx.TabName, "{", "}");


            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "myAlert(strInfo);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_btnGetMaxStrIdByPrefix_Click()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.Append("\r\n" + "this.btnGetMaxStrIdByPrefix_Click = function() {");
            strBuilder.AppendFormat("\r\n" + "const iobj{0}GetMaxStrIdByPrefix = new icls{0}GetMaxStrIdByPrefix();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetMaxStrIdByPrefix.main();",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "const icls{0}GetMaxStrIdByPrefix = function()",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "this.init = function()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "this.main = function()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const obj{0}WS4Controller = new cls{0}WS4Controller();",
           objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + " obj{0}WS4Controller.init();",
    objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "objTableObjWS4ControllerDelegate = new clsTableObjWS4ControllerDelegate();");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{0} = function(objResponseData, strClassName) ",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrIdByPrefix,
                enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "{0}_{1}(objResponseData, strClassName);",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrIdByPrefix,
               enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{0} = function(returnString, strClassName) ",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrIdByPrefix,
                enumDict4GC_DictKey2.conCorrectFinished));
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "{0}_{1}(returnString, strClassName);",
                objPrjTabENEx.TabName,
               clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrIdByPrefix,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "const strPrefix = \"2\";");
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.GetMaxStrIdByPrefix(strPrefix);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//通过WebService执行GetMaxStrIdByPrefix,返回的事件函数,可能需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}(objResponseData, strClassName)",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrIdByPrefix,
                enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行GetMaxStrIdByPrefix,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}(returnString, strClassName)",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrIdByPrefix,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "const strInfo = \"\";");

            strBuilder.Append("\r\n" + "if (returnString === \"\")");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "strInfo = \"获取表{0}的最大关键字为空,不成功,请检查!\";",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "myShowErrorMsg(strInfo);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "strInfo = String.format(\"获取表{0}的最大关键字为：{{0}}\", returnString);",
                objPrjTabENEx.TabName, "{", "}");
            

            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "myAlert(strInfo);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_btnUpdateRecord_Click()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 修改记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\n" + "this.btnUpdateRecord_Click = function() {");
            strBuilder.AppendFormat("\r\n" + "const iobj{0}_UpdateRecord = new icls{0}_UpdateRecord();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}_UpdateRecord.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "const icls{0}_UpdateRecord = function()",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "this.init = function()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "this.main = function()");
            strBuilder.Append("\r\n" + "{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                if (objField.JavaType == "boolean")
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.set{1}({2});",
                     objPrjTabENEx.TabName,
                     objField.ObjFieldTabENEx.FldName,
                     objField.ObjFieldTabENEx.DefaultValue4Test_Swift);
                    continue;
                }
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.set{1}(\"{2}\");",
                       objPrjTabENEx.TabName,
                       objField.ObjFieldTabENEx.FldName,
                       objField.ObjFieldTabENEx.DefaultValue4Test_Swift);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.set{1}({2});",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                          objField.ObjFieldTabENEx.DefaultValue4Test_Swift);
                }
            }
            strBuilder.AppendFormat("\r\n" + "const obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + " obj{0}WS4Controller.init();",
    objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "objTableObjWS4ControllerDelegate = new clsTableObjWS4ControllerDelegate();");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{0} = function(objResponseData, strClassName) ",
                  clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conUpdateRecordByJSON,
                enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}_{1}(objResponseData, strClassName);",
                objPrjTabENEx.TabName,
                      clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conUpdateRecordByJSON,
                enumDict4GC_DictKey2.conFinished));
            
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{0} = function(returnBool, strClassName) ",
                   clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conUpdateRecordByJSON,
                enumDict4GC_DictKey2.conCorrectFinished));
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}_{1}(returnBool, strClassName);",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conUpdateRecordByJSON,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//检查表对象的属性是否合法");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const obj{0}BL = new cls{0}BL();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}BL.CheckProperty4Update(obj{0}EN); ", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.UpdateRecord(obj{0}EN);",
                        objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (err)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "myShowErrorMsg(err);");
            strBuilder.Append("\r\n" + "return;");
            strBuilder.Append("\r\n" + "}");
       
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行UpdateRecord,返回的事件函数,可能需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}(objResponseData, strClassName)",
                objPrjTabENEx.TabName,
                      clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conUpdateRecordByJSON,
                enumDict4GC_DictKey2.conFinished));
            
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行UpdateRecord,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}(returnBool, strClassName)",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conUpdateRecordByJSON,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strInfo = \"\";");
            strBuilder.Append("\r\n" + "if (returnBool === true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strInfo = \"修改记录成功!\";");
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "myAlert(strInfo);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strInfo = \"修改记录不成功!\";");
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "myShowErrorMsg(strInfo);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_btnDelRecord_Click()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 删除记录");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\n" + "this.btnDelRecord_Click = function() {");

            strBuilder.AppendFormat("\r\n" + "const iobj{0}_DelRecord = new icls{0}_DelRecord();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}_DelRecord.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "const icls{0}_DelRecord = function()",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);


            strBuilder.Append("\r\n" + "this.init = function()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "this.main = function()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + " obj{0}WS4Controller.init();",
    objPrjTabENEx.TabName);


            strBuilder.Append("\r\n" + "objTableObjWS4ControllerDelegate = new clsTableObjWS4ControllerDelegate();");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{0} = function(objResponseData, strClassName) ",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conDelRecord,
                enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}_{1}(objResponseData, strClassName);",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conDelRecord,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{0} = function(returnBool, strClassName) ",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conDelRecord,
                enumDict4GC_DictKey2.conCorrectFinished));
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}_{1}(returnBool, strClassName);",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conDelRecord,
                enumDict4GC_DictKey2.conCorrectFinished));
   
            strBuilder.Append("\r\n" + "}");

            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
            {
                strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.DelRecord(\"{1}\");",
                    objPrjTabENEx.TabName,
                    objKeyField.ObjFieldTabENEx.DefaultValue4Test_Swift);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.DelRecord({1});",
                    objPrjTabENEx.TabName,
                    objKeyField.ObjFieldTabENEx.DefaultValue4Test_Swift);
            }
            strBuilder.Append("\r\n" + "}");


            strBuilder.Append("\r\n" + "//通过WebService执行DelRecord,返回的事件函数,可能需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}(objResponseData, strClassName)",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conDelRecord,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//通过WebService执行DelRecord,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}(returnBool, strClassName)",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conDelRecord,
                enumDict4GC_DictKey2.conCorrectFinished));
   
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strInfo = \"\";");
            strBuilder.Append("\r\n" + "if (returnBool === true)");
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "strInfo = \"删除记录成功!\";");
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "myAlert(strInfo);");


            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strInfo = \"删除记录不成功!\";");
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "myAlert(strInfo);");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");



            return strBuilder.ToString();
        }
        /// <summary>
        /// 根据关键字获取相应的记录的对象 
        /// </summary>
        /// <returns></returns>
        public string Gen_Controller_JavaScript_btnIsExistRecord_Click()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 检查相应关键字的记录是否存在");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">发送者</param>");
            strBuilder.Append("\r\n /// <returns>返回是否存在</returns>");

            strBuilder.Append("\r\n" + "this.btnIsExistRecord_Click = function() {");


            strBuilder.AppendFormat("\r\n" + "const iobj{0}_IsExistRecord = new icls{0}_IsExistRecord();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}_IsExistRecord.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "const icls{0}_IsExistRecord = function()",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);


            strBuilder.Append("\r\n" + "this.init = function()");
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "this.main = function()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + " obj{0}WS4Controller.init();",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "objTableObjWS4ControllerDelegate = new clsTableObjWS4ControllerDelegate();");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{0} = function(objResponseData, strClassName) ",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "{0}_{1}(objResponseData, strClassName);",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{0} = function(returnBool, strClassName) ",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conCorrectFinished));
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "{0}_{1}(returnBool, strClassName);",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "}");
            
            strBuilder.AppendFormat("\r\n" + "const strWhereCond = \"{0} ='12'\";",
                objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.IsExistRecord(strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行IsExistRecord,返回的事件函数,可能需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}(objResponseData, strClassName)",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行IsExistRecord,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}(returnBool, strClassName)",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strInfo = \"\";");
            strBuilder.Append("\r\n" + "switch (strClassName) {");
            strBuilder.AppendFormat("\r\n" + "case \"cls{0}WS4Controller\":",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "if (returnBool === false)");
            strBuilder.Append("\r\n" + "{");
            
            strBuilder.AppendFormat("\r\n" + "strInfo = \"根据条件：‘{0}='12'’ 不存在!\";",
                objKeyField.FldName);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "myAlert(strInfo);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "strInfo = \"根据条件：‘{0}='12'’ 存在!\";",
                objKeyField.FldName);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "myAlert(strInfo);");
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

        public string Gen_Controller_JavaScript_btnGetJSONObjLst_Click()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取相应的对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "this.btnGetJSONObjLst_Click = function() ",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const iobj{0}GetJSONObjLst = new icls{0}GetJSONObjLst();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetJSONObjLst.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "const icls{0}GetJSONObjLst = function()",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "this.init = function()");
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "this.main = function()");
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "const obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + " obj{0}WS4Controller.init();",
    objPrjTabENEx.TabName);


            strBuilder.Append("\r\n" + "objTableObjWS4ControllerDelegate = new clsTableObjWS4ControllerDelegate();");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{0} = function(objResponseData, strClassName) ",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLst,
                enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "{0}_{1}(objResponseData, strClassName);",
                objPrjTabENEx.TabName,
               clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLst,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{0} = function(returnObjectList, strClassName) ",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLst,
                enumDict4GC_DictKey2.conCorrectFinished));
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "{0}_{1}(returnObjectList, strClassName);",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLst,
                enumDict4GC_DictKey2.conCorrectFinished));
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "let strWhereCond = \" 1=1 \";");
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.GetJSONObjLst(strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行GetRecordObjLst,返回的事件函数,可能需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}(objResponseData, strClassName)",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLst,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行GetRecordObjLst,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}(returnObjectList, strClassName)",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLst,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strInfo = \"\";");
            strBuilder.AppendFormat("\r\n" + "const arr{0}ObjLst = returnObjectList;",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "strInfo = String.format(\"共获取对象列表数：{{0}}\", arr{0}ObjLst.length)",
                objPrjTabENEx.TabName, "{", "}");


            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "myAlert(strInfo);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_btnGetTopJSONObjLst_Click()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取相应的对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "this.btnGetTopJSONObjLst_Click = function() ",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const iobj{0}GetTopJSONObjLst = new icls{0}GetTopJSONObjLst();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetTopJSONObjLst.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "const icls{0}GetTopJSONObjLst = function()",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "this.init = function()");
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "this.main = function()");
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "const obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + " obj{0}WS4Controller.init();",
    objPrjTabENEx.TabName);


            strBuilder.Append("\r\n" + "objTableObjWS4ControllerDelegate = new clsTableObjWS4ControllerDelegate();");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{0} = function(objResponseData, strClassName) ",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetTopRecordJSONObjLst,
                enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "{0}_{1}(objResponseData, strClassName);",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetTopRecordJSONObjLst,
                enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{0} = function(returnObjectList, strClassName) ",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetTopRecordJSONObjLst,
                enumDict4GC_DictKey2.conCorrectFinished));
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "{0}_{1}(returnObjectList, strClassName);",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetTopRecordJSONObjLst,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "let strWhereCond = \" 1=1 \";");
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.GetTopJSONObjLst(strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行GetRecordObjLst,返回的事件函数,可能需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}(objResponseData, strClassName)",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetTopRecordJSONObjLst,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行GetRecordObjLst,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}(returnObjectList, strClassName)",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetTopRecordJSONObjLst,
                enumDict4GC_DictKey2.conCorrectFinished));
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strInfo = \"\";");
            strBuilder.AppendFormat("\r\n" + "const arr{0}ObjLst = returnObjectList;",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "strInfo = String.format(\"共获取对象列表数：{{0}}\", arr{0}ObjLst.length);",
                objPrjTabENEx.TabName, "{", "}");


            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "myAlert(strInfo);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_btnGetJSONObjByKey_Click()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据关键字获取相应的记录的对象");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">参数列表</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\n" + "this.btnGetJSONObjByKey_Click = function() {");

            strBuilder.AppendFormat("\r\n" + "const iobj{0}GetObjBy{1} = new icls{0}GetObjBy{1}();",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetObjBy{1}.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "const icls{0}GetObjBy{1} = function()",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "this.init = function()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "this.main = function()");
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "const obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + " obj{0}WS4Controller.init();",
    objPrjTabENEx.TabName);


            strBuilder.Append("\r\n" + "objTableObjWS4ControllerDelegate = new clsTableObjWS4ControllerDelegate();");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{0} = function(objResponseData, strClassName) ",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjByKey,
                enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "{0}_{1}(objResponseData, strClassName);",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjByKey,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{0} = function(returnObject, strClassName) ",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjByKey,
                enumDict4GC_DictKey2.conCorrectFinished));
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "{0}_{1}(returnObject, strClassName);",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjByKey,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "}");

            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
            {
                strBuilder.AppendFormat("\r\n" + "const {0} = \"{2}\";",
                    objKeyField.ObjFieldTabENEx.PrivPropName,
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType,
                    objKeyField.ObjFieldTabENEx.DefaultValue4Test_Swift);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "const {0} = {2};",
                    objKeyField.ObjFieldTabENEx.PrivPropName,
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType,
                    objKeyField.ObjFieldTabENEx.DefaultValue4Test_Swift);
            }
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.GetObjBy{1}({2});",
                objPrjTabENEx.TabName,
                objKeyField.FldName,
                objKeyField.ObjFieldTabENEx.PrivPropName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//通过WebService执行GetRecordObjByKey,返回的事件函数,可能需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}(objResponseData, strClassName)",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjByKey,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//通过WebService执行GetRecordObjByKey,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}(returnObject, strClassName)",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjByKey,
                enumDict4GC_DictKey2.conCorrectFinished));
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strInfo = \"\";");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = returnObject;",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "strInfo = String.format(\"根据关键字’01‘ 获取对象：{{0}};\", obj{0}EN.{1});",
                objPrjTabENEx.TabName,
                objKeyField.FldName, "{", "}");
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "myAlert(strInfo);");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_btnGetFirstJSONObj_Click()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取相应的第一条记录的对象");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.Append("\r\n" + "this.btnGetFirstJSONObj_Click = function() {");

            strBuilder.AppendFormat("\r\n" + "const iobj{0}GetFirstObj = new icls{0}GetFirstObj();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetFirstObj.main();",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "const icls{0}GetFirstObj = function()",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "this.init = function()");
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "this.main = function()");
            strBuilder.Append("\r\n" + "{");


            strBuilder.AppendFormat("\r\n" + "const obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + " obj{0}WS4Controller.init();",
    objPrjTabENEx.TabName);


            strBuilder.Append("\r\n" + "objTableObjWS4ControllerDelegate = new clsTableObjWS4ControllerDelegate();");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{0} = function(objResponseData, strClassName) ",
                    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetFirstJSONObj,
                enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "{0}_{1}(objResponseData, strClassName);",
                objPrjTabENEx.TabName,
                  clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetFirstJSONObj,
                enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{0} = function(returnObject, strClassName) ",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetFirstJSONObj,
                enumDict4GC_DictKey2.conCorrectFinished));
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "{0}_{1}(returnObject, strClassName);",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetFirstJSONObj,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "let strWhereCond = \" 1=1 \";");
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.GetFirst{0}(strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//通过WebService执行GetFirstJSONObj,返回的事件函数,可能需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}(objResponseData, strClassName)",
                objPrjTabENEx.TabName,
                  clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetFirstJSONObj,
                enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//通过WebService执行GetFirstJSONObj,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}(returnObject, strClassName)",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetFirstJSONObj,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strInfo = \"\";");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = returnObject;",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "strInfo = String.format(\"根据条件：‘1=1’ 获取第一个记录对象：{{0}}\", obj{0}EN.{1});",
                objPrjTabENEx.TabName,
                objKeyField.FldName, "{", "}");
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "myAlert(strInfo);");


            strBuilder.Append("\r\n" + "}");


            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }
        /// <summary>
        /// 根据关键字获取相应的记录的对象 
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_JavaScript_ByCommonFunction(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {
            string strMsg = "";
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// {0}", objWebSrvFunctionsENEx.FunctionName);
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
                        sbParaList.AppendFormat("{1},",
                            objSelfDefDataTypeEN_Para.JavaType,
                            objWebSrvFuncParaEN.ParaName);
                    }
                    else
                    {
                        sbParaList.AppendFormat("{1},",
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
            strBuilder.AppendFormat("\r\n /// <returns>返回{0}</returns>",
                     objWebSrvFunctionsENEx.ReturnValueDescription);

            strBuilder.AppendFormat("\r\n" + "this.{0} = function({1})",
                objWebSrvFunctionsENEx.FunctionName, sbParaList.ToString());
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const values = new Dictionary();");
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
                        strBuilder.AppendFormat("\r\n" + "values.add(\"{0}\", {0});",
                            objWebSrvFuncParaEN.ParaName);
                    }
                    else
                    {
                        switch (objDataTypeAbbrEN.JavaType)
                        {
                            case "int":
                                strBuilder.AppendFormat("\r\n" + "values.add(\"{0}\", {0});",
                                    objWebSrvFuncParaEN.ParaName);
                                break;
                            case "float":
                                strBuilder.AppendFormat("\r\n" + "values.add(\"{0}\", {0});",
                                    objWebSrvFuncParaEN.ParaName);
                                break;
                            case "double":
                                strBuilder.AppendFormat("\r\n" + "values.add(\"{0}\", {0});",
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

            strBuilder.AppendFormat("\r\n" + "const obj{0}WS4SD = new cls{0}WS4SD();",
                objWebSrvClassENEx.ClsName);
            //strBuilder.AppendFormat("obj{0}EN);",
            //    objWebSrvFunctionsENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4SD.init(\"{1}\", values, null, IsFinished4WebService);",
         objWebSrvClassENEx.ClsName,
         objWebSrvFunctionsENEx.FunctionName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4SD.main();",
                objWebSrvClassENEx.ClsName);
                   
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }
  
    }
}
