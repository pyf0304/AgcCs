
using AGC.Entity;
using AGC4WApi;
using AgcCommBase;
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.file;
using DDW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agc_CsWin.CommFunc
{
    public class clsPubClass4CM
    {
        public static clsCMClassEN GetClassByClassNode(ClassNode objClassNode, string strProgLangTypeId, 
            string strNameSpace, string strFullFileName, string strProjectPath, string strPrjId, string strUserId)
        {
            string strFilePath_Temp = clsFile.GetDirName_S(strFullFileName);
            string strFilePath = strFilePath_Temp.Replace(strProjectPath, "");
            if (string.IsNullOrEmpty(strFilePath) == true) strFilePath = "\\";
            string strSimpleFileName = clsFile.GetSimpleFName_S(strFullFileName);
            string strFileContent = clsFile.GetContentFromTextFile(strFullFileName);//.Replace(";", "；");

            Tuple<string, string> TableCodeTypeId = clsCodeTypeExWApi.GetCodeTypeIdByClassName(objClassNode.Name.Identifier, clsPubConst.LangType.CSharp);

            clsvPrjTab_SimEN objPrjTab = clsPrjTabExWApi.GetObjByTabNameExCache(strPrjId, TableCodeTypeId.Item1);
            string strFuncModuleId = "";
            if (objPrjTab != null)
            {
                strFuncModuleId = objPrjTab.FuncModuleAgcId;
            }

            clsCMClassEN objCMClass = new clsCMClassEN();
            objCMClass.SetClsName(objClassNode.Name.Identifier)
                     .SetIsOpen(true)
                     .SetProgLangTypeId(strProgLangTypeId)
                     .SetTabName(TableCodeTypeId.Item1)
                     .SetCodeTypeId(TableCodeTypeId.Item2)
                     .SetFuncModuleAgcId(strFuncModuleId)

                     .SetProjectPath(strProjectPath)
                     .SetFilePath(strFilePath)
                     .SetFileName(strSimpleFileName)
                     .SetNameSpace(strNameSpace)
                     .SetFileText(strFileContent)
                     .SetUserId(strUserId)
                     .SetPrjId(strPrjId)
                     .SetUpdDate(clsDateTime.getTodayDateTimeStr(0))
                     .SetUpdUser(clsSysParaEN_Local.strUserId);
            return objCMClass;
        }

        public static clsCMFunctionEN GetFunctionByMethodNode(MethodNode objMethodNode, string strCmClassId, string strProgLangTypeId, string strFullFileName, string strPrjId, string strUserId)
        {
            StringBuilder sbFuncType = new StringBuilder();
            objMethodNode.Type.ToSource(sbFuncType);

            StringBuilder sbFuncName = new StringBuilder();
            objMethodNode.Names.ToSource(sbFuncName);

            StringBuilder sbParams = new StringBuilder();
            objMethodNode.Params.ToSource(sbParams, ", ");
//            string strFuncComment = IdentNewLine(objMethodNode.DocComment);
            //string strFuncComment = objMethodNode.DocComment;
            string FunctionSignature = string.Format("{1}({2})",
                objMethodNode.Modifiers,
                objMethodNode.GenericIdentifier,
                sbParams);

            stuTextRange objTextRange = new stuTextRange(new stuTextPos(objMethodNode.StartToken.Line, objMethodNode.StartToken.Col),
                new stuTextPos(objMethodNode.EndToken.Line, objMethodNode.EndToken.Col));
         
             string strMethodContent = "";
            try
            {
                strMethodContent = clsFile.GetContentFromTextFileByRange(strFullFileName, objTextRange);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("分析函数内容出错。文件名:{0}, 函数名:{1}, 文件位置:{2},{3}-{4},{5}. 错误:{6}. (In {7})",
                    strFullFileName, sbFuncName, objMethodNode.StartToken.Line, objMethodNode.StartToken.Col, objMethodNode.EndToken.Line, objMethodNode.EndToken.Col,
                    objException.Message,      clsStackTrace.GetCurrClassFunction());
                clsPubVar4WApi.objLog4Error.WriteDebugLog(strMsg);
            }
            string strMethodComment = "";
            if (objMethodNode.StartPos4Comment != null)
            {
                stuTextRange objTextRange_Comment = new stuTextRange(new stuTextPos(objMethodNode.StartPos4Comment.Line,
                                objMethodNode.StartPos4Comment.Col),
                              new stuTextPos(objMethodNode.EndPos4Comment.Line, objMethodNode.EndPos4Comment.Col));
                strMethodComment = clsFile.GetContentFromTextFileByRange(strFullFileName, objTextRange_Comment);
            }


            clsCMFunctionEN objCMFunction = new clsCMFunctionEN();
            objCMFunction.SetFunctionName(sbFuncName.ToString())                      
                      .SetCmClassId(strCmClassId)
                      .SetFuncContent(strMethodContent)
                      .SetFuncComments(strMethodComment)
                      .SetReturnType(sbFuncType.ToString())
                      .SetFunctionSignature(FunctionSignature)
                      .SetFuncParaLst(sbParams.ToString())                      
                      .SetUpdDate(clsDateTime.getTodayDateTimeStr(0))
                      .SetUpdUser(clsSysParaEN_Local.strUserId);
            return objCMFunction;
        }

        public static clsCMFuncParaEN GetFuncParaByParamDeclNode(ParamDeclNode objParamDeclNode, string strProgLangTypeId, string strFullFileName, string strPrjId, string strUserId)
        {
            StringBuilder sbFuncType = new StringBuilder();
            objParamDeclNode.Type.ToSource(sbFuncType);


            string strParaComment = objParamDeclNode.DocComment;

            StringBuilder sbType = new StringBuilder();
            objParamDeclNode.Type.ToSource(sbType);
            //            string strFuncComment = IdentNewLine(objParamDeclNode.DocComment);
            string strFuncComment = objParamDeclNode.DocComment;
            clsDataTypeAbbrEN objDataTypeAbbr = clsDataTypeAbbrExWApi.GetObjByDataTypeNameCache(sbType.ToString(), strProgLangTypeId);
            string strDataTypeId = "99";
            if (objDataTypeAbbr != null) strDataTypeId = objDataTypeAbbr.DataTypeId;
            clsCMFuncParaEN objCMFuncPara = new clsCMFuncParaEN();
            objCMFuncPara.SetParaName(objParamDeclNode.Name)
                      .SetPrjId(strPrjId)
                      .SetParaCnName(objParamDeclNode.Name)
                      .SetDataTypeId(strDataTypeId)
                      .SetParameterType(sbType.ToString())
                      .SetParaComments(strParaComment)
                      .SetUpdDate(clsDateTime.getTodayDateTimeStr(0))
                      .SetUpdUser(clsSysParaEN_Local.strUserId);
            return objCMFuncPara;
        }



    }
}
