using System;
using System.Text;
using System.IO;
using com.taishsoft.file;

using System.Collections;
using com.taishsoft.common;using com.taishsoft.comm_db_obj;
using com.taishsoft.commexception;
using AGC.Entity;


using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using System.Collections.Generic;
using System.Reflection;
using AgcCommBase;
using System.Linq;
using AGC.PureClass;
using AGC.PureClassEx;

namespace AutoGCLib
{
    /// <summary>
    /// 自动生成界面控制层的代码类(Control of Mvc)
    /// </summary>
    public class NodeWCCCode4CSharp : AutoGC_Cs_CWeb_PubFun
    {

        #region 构造函数
        public NodeWCCCode4CSharp()
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            //InitPageSetup();
        }
        public NodeWCCCode4CSharp(string strViewId)
       : base("",strViewId, "", "")
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            //InitPageSetup();
        }
        public NodeWCCCode4CSharp(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
        : base(strTabId, strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            //InitPageSetup();
        }
        #endregion

        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            this.strBaseUrl = "../..";
            //public string A_GenCtlControlCodeforTab(clsViewInfoENEx objViewInfoENEx, ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
            //{
            //''该功能主要生成与表相关的控件代码,包括两个文件,;
            //一个是控件的界面文件, ;
            //另一个与之相关的界面类文件;
            //
            //CommProgramSet.clsComm objComm = new CommProgramSet.clsComm();
            if (objViewInfoENEx.arrEditRegionFldSet4InUse  ==  null || objViewInfoENEx.arrEditRegionFldSet4InUse.Count  ==  0)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有编辑区域,或者编辑区域没有字段。请检查!", strViewName);
                throw new clsDbObjException(sbMessage.ToString());
            }

            StringBuilder strCodeForCs = new StringBuilder();    ///用来存放与WebForm相关的类文件代码;
            //string strFolder;
            string strTemp;
            objViewInfoENEx.WebUserCtlClassName = this.ClsName;
            objViewInfoENEx.WebUserCtlCsFName = objViewInfoENEx.FolderName + this.ClsName + ".ascx.cs";
            objViewInfoENEx.FileName = objViewInfoENEx.WebUserCtlCsFName;
            objViewInfoENEx.ClsName = objViewInfoENEx.WebUserCtlClassName;
            
            strRe_ClsName = objViewInfoENEx.WebUserCtlClassName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), 
                objViewInfoENEx.WebUserCtlCsFName);

        
            

            try
            {
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objViewInfoENEx.CurrUserName, objViewInfoENEx));

                strCodeForCs.Append("\r\n" + "//生成与表相关的控件控制层代码");
                strCodeForCs.AppendFormat("\r\n" + "namespace {0}.Webform", objViewInfoENEx.NameSpace);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "using System;");
                strCodeForCs.Append("\r\n" + "using System.Data;");
                strCodeForCs.Append("\r\n" + "using System.Configuration;");
                strCodeForCs.Append("\r\n" + "using System.Collections;");
                strCodeForCs.Append("\r\n" + "using System.Collections.Generic;");
                
                strCodeForCs.Append("\r\n" + "using System.Web;");
                strCodeForCs.Append("\r\n" + "using System.Web.Security;");
                strCodeForCs.Append("\r\n" + "using System.Web.UI;");
                strCodeForCs.Append("\r\n" + "using System.Web.UI.WebControls;");
                strCodeForCs.Append("\r\n" + "using System.Web.UI.WebControls.WebParts;");
                strCodeForCs.Append("\r\n" + "using System.Web.UI.HtmlControls;");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.common;");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.datetime;");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "using CommFunc4WebForm;");
                

                strCodeForCs.AppendFormat("\r\n" + "using {0}.Entity;", objViewInfoENEx.NameSpace);
                strCodeForCs.AppendFormat("\r\n" + "using {0}.BusinessLogic;", objViewInfoENEx.NameSpace);
                strCodeForCs.AppendFormat("\r\n" + "using {0}.BusinessLogicEx;", objViewInfoENEx.NameSpace);

                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///		{0} 的摘要说明。", this.ClsName);
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public partial class  {0} : System.Web.UI.UserControl",
                    this.ClsName);
                strCodeForCs.Append("\r\n" + "{");

                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
              clsvFunction4GeneCodeBLEx.GetObjLstByViewInfoEx(objViewInfoENEx);

             
                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    string strFuncName = objvFunction4GeneCodeEN.FuncName;
                    if (strFuncName.Substring(0, 6) == "Print:")
                    {
                        strCodeForCs.Append("\r\n" + "");
                        strCodeForCs.Append("\r\n " + strFuncName.Substring(6));
                        continue;
                    }
                    try
                    {
                        strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                        if (string.IsNullOrEmpty(strTemp) == false)
                        {
                            strCodeForCs.Append("\r\n" + strTemp);
                        }
                    }
                    catch (Exception objException)
                    {
                        throw objException;
                    }
                }

              
                /////生成界面中下拉框的BIND函数,即添加下拉框列表项的函数;
                ///
                //strCodeForCs.Append("\r\n" + Gen_Wuc_CS_DdlBindFunction());
                //strCodeForCs.Append("\r\n" + Gen_Wuc_CS_SetBindDdl());
               
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                ////把生成写到文件中;
                ////检查该文件名的文件夹名,并判断是否存在;
                //strFolder = clsString.ParentDir_S(objViewInfoENEx.WebUserCtlCsFName);
                //if (System.IO.Directory.Exists(strFolder)  ==  false)
                //{
                //    Directory.CreateDirectory(strFolder);
                //}

                //if (clsSysParaEN_Local.IsBackupForGeneCode   ==  true)
                //{
                //    string strSimpleFileName = clsString.GetSimpleFName_S(objViewInfoENEx.WebUserCtlCsFName);
                //    string strFindFileFullFile = clsFile.FindFileFromFolder(objViewInfoENEx.BackupFolderName, strSimpleFileName);
                //    while (string.IsNullOrEmpty(strFindFileFullFile)  ==  false)
                //    {
                //        string strMsg = string.Format("文件:{0}已经存在!", strFindFileFullFile);
                //        throw new Exception(strMsg);
                //    }
                //}
                //clsFile.CreateFileByString(objViewInfoENEx.WebUserCtlCsFName, strCodeForCs.ToString());

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex,"");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 生成指定的函数
        /// </summary>
        /// <returns>返回生成的指定函数代码</returns>
        public string A_GenCode4Function(clsViewInfoENEx objViewInfoENEx, string strFuncId4GC)
        {
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp; //临时变量;
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
                strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
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
       

        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(NodeWCCCode4CSharp);
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
            clsViewRegionENEx obj = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.EditRegion_0003);
            if (obj != null && string.IsNullOrEmpty(obj.ClsName) == false)
            {
                this.ClsName = obj.ClsName;
                objViewInfoENEx.ClsName = this.ClsName;
            }
            else
            {
                this.ClsName = string.Format("wuc{0}", objViewInfoENEx.TabName_Out);
                objViewInfoENEx.ClsName = this.ClsName;
            }
        }
       
        public string Gen_Wuc_CS_DefFldProperty()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                IEnumerable<ASPControlEx> arrAspControl = objViewInfoENEx.arrEditRegionFldSet4InUse
                    .Where(x=>x.IsPrimaryKey_Identity() == false)
                    .Where(x => x.IsLogUpdDateOrUpdUser(objViewInfoENEx.PrjId) == false)
                    .Select(x=>clsASPControlBLEx.GetControl_Asp(x, objViewInfoENEx.PrjId));

                foreach (ASPControlEx objASPControlENEx in arrAspControl)
                {
                    strCodeForCs.Append(objASPControlENEx.GC_DefFldProperty());
                }

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_Wuc_CS_Page_Load()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 函数功能:页面导入,当页面开始运行时所发生的事件");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <param name = \"sender\"></param>");
                strCodeForCs.Append("\r\n /// <param name = \"e\"></param>");
                strCodeForCs.Append("\r\n" + "protected void Page_Load(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "// 在此处放置用户代码以初始化页面");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "");            
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        Func<clsEditRegionFldsENEx, ASPDropDownListEx> GetDdlObj = obj => clsASPDropDownListBLEx.GetDropDownLst_Asp(obj, new clsGetTabFieldObj());


        public string Gen_Wuc_CS_DdlBindFunction()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成仅有变量;
                List<string> arrDropDownTypeLst = new List<string> { enumCtlType.DropDownList_06, enumCtlType.DropDownList_Bool_18 };
                IEnumerable<clsEditRegionFldsENEx> arrERF4DropDownLst = objViewInfoENEx.arrEditRegionFldSet4InUse.Where(x => arrDropDownTypeLst.Contains(x.CtlTypeId));
                IEnumerable<ASPDropDownListEx> arrASPDropDownListObj 
                    = arrERF4DropDownLst.Select(GetDdlObj);

                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj)
                {
                    //strCodeForCs.Append(objInfor.GC_BindDdlFunc());

                }

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_Wuc_CS_SetBindDdl()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                List<string> arrDropDownTypeLst = new List<string> { enumCtlType.DropDownList_06, enumCtlType.DropDownList_Bool_18 };
                IEnumerable<clsEditRegionFldsENEx> arrERF4DropDownLst = objViewInfoENEx.arrEditRegionFldSet4InUse.Where(x => arrDropDownTypeLst.Contains(x.CtlTypeId));
                IEnumerable<ASPDropDownListEx> arrASPDropDownListObj = arrERF4DropDownLst.Select(GetDdlObj);

                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj)
                {
                    if (string.IsNullOrEmpty(objInfor.TabFeatureId4Ddl) == false)
                    {
                        var objTabFeature = clsTabFeatureBL.GetObjByTabFeatureIdCache(objInfor.TabFeatureId4Ddl, objInfor.PrjId);
                        var arrTabFeatureFlds = clsTabFeatureFldsBLEx.GetObjLstByTabFeatureIdCache(objTabFeature.TabFeatureId, objInfor.PrjId);
                        var arrTabFeatureFlds_Cond = arrTabFeatureFlds.Where(x => x.FieldTypeId == enumFieldType.ConditionField_16).ToList();
                        if (arrTabFeatureFlds_Cond.Count == 0)
                        {
                            objInfor.VarIdCond1 = "";
                            objInfor.VarIdCond2 = "";
                            objInfor.FldIdCond1 = "";
                            objInfor.FldIdCond2 = "";
                        }
                        else if (arrTabFeatureFlds_Cond.Count == 1)
                        {
                            objInfor.VarIdCond2 = "";
                            objInfor.FldIdCond2 = "";
                        }
                    }
                    //if (objInfor.CsType == "bool")
                    //{
                    strCodeForCs.AppendLine(objInfor.GC_SetBindDdl4Bool_TS4QueryEdit(this, this.strBaseUrl));
                    //}
                    //else
                    //{
                    //    strCodeForCs.Append(objInfor.GC_SetBindDdl());
                    //}
                }
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        //public bool AddImportClass(string strTabId, string strClassName, string strFuncName, string strImportObjType, string strBasePath)
        //{
        //    return clsPubFun4GC.AddImportClass(strTabId, strClassName, strFuncName, strImportObjType, strBasePath, arrImportClass, objPrjTabENEx.PrjId);
        //}
    }
}