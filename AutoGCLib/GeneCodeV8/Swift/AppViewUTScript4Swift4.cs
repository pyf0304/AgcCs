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
using AgcCommBase;
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
    partial class AppViewUTScript4Swift4 : AppController4Swift4Base
    {


        #region 构造函数

        public AppViewUTScript4Swift4(string strTabId, string strPrjDataBaseId, string strPrjId)
          : base(strTabId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
        }
        #endregion

       
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
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
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            ISOButtonEx objISOButton_Temp = null; ///临时变量;

          
            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
              clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
              objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                .OrderBy(x => x.OrderNum);



            objPrjTabENEx.ClsName = "sb" + objPrjTabENEx.TabName + "_UTScript";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".storyboard";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName( objFuncModule, objPrjTabENEx);
            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".storyboard";

            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //
            try
            {
                //    //类名开始
                ISOstoryBoardEx objISOstoryBoardEN = new ISOstoryBoardEx();
                ISOsceneEx objISOsceneEN = new ISOsceneEx();
                objISOsceneEN.Text = string.Format("{0}-单元测试", objPrjTabENEx.TabName);

                objISOstoryBoardEN.arrSubIsoControlLst2.Add(objISOsceneEN);

                ISOviewControllerEx objISOviewControllerEN = new ISOviewControllerEx();
                string strViewControllerID = AgcCommBase.AgcPubFun.getSwiftID();
                objISOviewControllerEN.IsoControlId = strViewControllerID;
                objISOviewControllerEN.customClass = string.Format("vc{0}_UTScript", objPrjTabENEx.TabName);
                objISOviewControllerEN.customModule = objProject.IsoPrjName;//

                objISOsceneEN.arrSubIsoControlLst2.Add(objISOviewControllerEN);

                ISOviewControllerLayoutGuideEx objISOviewControllerLayoutGuideEN_Top = new ISOviewControllerLayoutGuideEx();
                objISOviewControllerLayoutGuideEN_Top.type = "top";
              
                ISOviewControllerLayoutGuideEx objISOviewControllerLayoutGuideEN_Bottom = new ISOviewControllerLayoutGuideEx();
                objISOviewControllerLayoutGuideEN_Bottom.type = "bottom";
                objISOviewControllerEN.arrSubIsoControlLst2.Add(objISOviewControllerLayoutGuideEN_Top);
                objISOviewControllerEN.arrSubIsoControlLst2.Add(objISOviewControllerLayoutGuideEN_Bottom);
                ISOviewEx objISOviewEN = new ISOviewEx();
                objISOviewControllerEN.arrSubIsoControlLst2.Add(objISOviewEN);
                ISOStackViewEx objISOStackViewEN = new ISOStackViewEx();
                objISOviewEN.arrSubIsoControlLst2.Add(objISOStackViewEN);
                int intY = 0;
                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    //string strTemp = "";
                    if (strFuncName.IndexOf("Swift4_DefButton") > 0)
                    {
                        objISOButton_Temp = A_GeneFuncCode_Swift4_DefButton(strFuncName, strViewControllerID, ref intY);
                        objISOStackViewEN.arrSubIsoControlLst2.Add(objISOButton_Temp);
                    }
                }
                ISOlabelEx objISOlabelEN = new ISOlabelEx();
                objISOlabelEN.Text = "结果";
                objISOlabelEN.x = 10;
                objISOlabelEN.y = 550;
                objISOlabelEN.Width = 50;
                objISOlabelEN.Height = 30;

                objISOviewEN.arrSubIsoControlLst2.Add(objISOlabelEN);

                ISOtextFieldEx objISOtextFieldEN = new ISOtextFieldEx();
                objISOtextFieldEN.x = 60;
                objISOtextFieldEN.y = 550;
                objISOtextFieldEN.Width = 150;
                objISOtextFieldEN.Height = 30;

                objISOviewEN.arrSubIsoControlLst2.Add(objISOtextFieldEN);
                ISOnavigationBarEx objISOnavigationBarEN = new ISOnavigationBarEx();
                objISOviewEN.arrSubIsoControlLst2.Add(objISOnavigationBarEN);

                ISONavigationItemEx objISOnavigationItemEN = new ISONavigationItemEx();
                objISOnavigationItemEN.Text = string.Format("{0}-单元测试", objPrjTabENEx.TabName);

                objISOnavigationBarEN.arrSubIsoControlLst2.Add(objISOnavigationItemEN);

                ISOBarButtonItemEx objISOBarButtonItemEN = new ISOBarButtonItemEx();
                objISOBarButtonItemEN.mKey = "leftBarButtonItem";

                objISOnavigationItemEN.arrSubIsoControlLst2.Add(objISOBarButtonItemEN);
                ISOButtonEx objISOButtonEN = GetISOButton4NavigitionBar_Swift4("返回", 
                    objISOviewControllerEN.IsoControlId, "btnReturnMainPage_Click");
                //ISOButtonEx objISOButtonEN =  new ISOButtonEx();
                //objISOButtonEN.Text = "返回";
                //objISOButtonEN.IsoControlName = "ReturnMainPage";
                //objISOButtonEN.x = 16;
                //objISOButtonEN.y = 7;

                //objISOButtonEN.Width = 30;
                //objISOButtonEN.Height = 30;
                objISOBarButtonItemEN.arrSubIsoControlLst2.Add(objISOButtonEN);

                //    strCodeForCs.Append("\r\n" + "<outlet property=\"txtResult\" destination=\"drJ-Oa-kPD\" id=\"wLA-Bq-AcF\"/>");
                ISOOutletEx objISOOutletEN = new ISOOutletEx();
                objISOOutletEN.property = "txtResult";
                objISOOutletEN.destination = objISOtextFieldEN.IsoControlId;
                objISOviewControllerEN.arrSubIsoControlLst2.Add(objISOOutletEN);

                ISOOutletEx objISOOutletEN2 = new ISOOutletEx();
                objISOOutletEN2.property = "lblResult";
                objISOOutletEN2.destination = objISOlabelEN.IsoControlId;
                objISOviewControllerEN.arrSubIsoControlLst2.Add(objISOOutletEN2);

                //objISOstoryBoardEN.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);             

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
                
            }
            return strCodeForCs.ToString();
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
        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(AppViewUTScript4Swift4);
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
            this.ClsName = string.Format("sb{0}_UTScript", objPrjTabENEx.TabName);
            objPrjTabENEx.ClsName = this.ClsName;
        }
    }
}
