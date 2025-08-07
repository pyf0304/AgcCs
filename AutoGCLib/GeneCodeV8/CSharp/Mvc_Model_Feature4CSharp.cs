using System;
using System.Text;
using System.Data;
using System.Collections;
using System.IO;
using com.taishsoft.commexception;
using com.taishsoft.file;
using com.taishsoft.common;using com.taishsoft.comm_db_obj;


using AGC.Entity;

using AGC.BusinessLogic;
using com.taishsoft.datetime;
using AgcCommBase;
using AGC.BusinessLogicEx;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using AGC.PureClass;
using AGC.PureClassEx;

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
    partial class Mvc_Model_Feature4CSharp : clsGeneCodeBase4View
    {
        //int intZIndex;      ///控件焦点序号
        //float intCurrLeft;  ///控件的左边空;
        //float intCurrTop;  ///控件的顶面空;
        #region 构造函数
        public Mvc_Model_Feature4CSharp()
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            //InitPageSetup();
        }
        public Mvc_Model_Feature4CSharp(string strViewId)
       : base(strViewId, "", "")
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            //InitPageSetup();
        }
        public Mvc_Model_Feature4CSharp( string strViewId, string strPrjDataBaseId, string strPrjId)
        : base( strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            //InitPageSetup();
        }
        #endregion

           

        protected string GenRefDomainName()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成仅有变量;
                strCodeForCs.Append("\r\n" + "using System;");
                strCodeForCs.Append("\r\n" + "using System.Data;");
                strCodeForCs.Append("\r\n" + "using System.Configuration;");
                strCodeForCs.Append("\r\n" + "using System.Collections.Generic;");
                strCodeForCs.Append("\r\n" + "using System.Collections;");
                strCodeForCs.Append("\r\n" + "using System.Text;");
                strCodeForCs.Append("\r\n" + "using System.Web;");
                strCodeForCs.Append("\r\n" + "using System.Web.Mvc;");
                strCodeForCs.Append("\r\n" + "using System.Linq;");
                strCodeForCs.Append("\r\n" + "using System.Web.Security;");
                strCodeForCs.Append("\r\n" + "using System.Web.UI;");
                strCodeForCs.Append("\r\n" + "using System.Web.UI.WebControls;");
                strCodeForCs.Append("\r\n" + "using System.Web.UI.WebControls.WebParts;");
                strCodeForCs.Append("\r\n" + "using System.Web.UI.HtmlControls;");
                strCodeForCs.Append("\r\n" + "using System.ComponentModel;");
                strCodeForCs.Append("\r\n" + "using System.ComponentModel.DataAnnotations;");

                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.common;");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.datetime;");
                strCodeForCs.Append("\r\n" + "using CommFunc4WebForm;");

                clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objViewInfoENEx.PrjId); //

                strCodeForCs.AppendFormat("\r\n" + "using {0}.Entity;", objProject.PrjDomain);
                strCodeForCs.AppendFormat("\r\n" + "using {0}.BusinessLogic;", objProject.PrjDomain);
                strCodeForCs.AppendFormat("\r\n" + "using {0}.BusinessLogicEx;", objProject.PrjDomain);
                strCodeForCs.AppendFormat("\r\n" + "using {0};", objProject.PrjDomain);
                strCodeForCs.AppendFormat("\r\n" + "using {0}Mvc.Models.PubFun;", objProject.PrjDomain);
                strCodeForCs.AppendFormat("\r\n" + "using {0}Mvc.Models;", objProject.PrjDomain);
                
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();

        }


        /// <summary>
        /// 生成扩展模型代码－－Asp.NET Mvc
        /// </summary>
        /// <returns></returns>

        /// <summary>
        /// 生成扩展模型代码－－Asp.NET Mvc
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            this.objViewInfoENEx = objViewInfoENEx;


            if (objViewInfoENEx.arrEditRegionFldSet4InUse == null || objViewInfoENEx.arrEditRegionFldSet4InUse.Count == 0)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有编辑区域,或者编辑区域没有字段。请检查!", strViewName);
                throw new clsDbObjException(sbMessage.ToString());
            }

            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;

            objViewInfoENEx.MvcModel4FeatureName = string.Format("FeatureModel4{0}", objViewInfoENEx.TabName_In);

            objViewInfoENEx.WebUserCtlCsFName = string.Format("{0}{1}.cs",
                objViewInfoENEx.FolderName, objViewInfoENEx.MvcModel4FeatureName);
            objViewInfoENEx.FileName = objViewInfoENEx.WebUserCtlCsFName;
            objViewInfoENEx.ClsName = objViewInfoENEx.MvcModel4FeatureName;

            strRe_ClsName = objViewInfoENEx.MvcModel4FeatureName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebUserCtlCsFName);

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
        clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objViewInfoENEx.FunctionTemplateId,
             objViewInfoENEx.LangType, objViewInfoENEx.CodeTypeId, objViewInfoENEx.SqlDsTypeId);

            try
            {
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objViewInfoENEx.CurrUserName, objViewInfoENEx));

                strCodeForCs.Append("\r\n" + "//生成与主表相关的扩展模型代码");

                strCodeForCs.Append("\r\n" + GenRefDomainName());    //生成参考域名



                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.AppendFormat("\r\n" + "namespace {0}Mvc.Models", objViewInfoENEx.NameSpace);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///		{0} 的摘要说明。", objViewInfoENEx.MvcModelExName);
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "[Serializable]");
                strCodeForCs.AppendFormat("\r\n" + "public class  {0} ",
                    objViewInfoENEx.MvcModel4FeatureName);
                strCodeForCs.Append("\r\n" + "{");

                Func<clsViewFeatureFldsENEx, ASPControlEx> GetControl_Asp4SingleModel = obj => clsASPControlBLEx.GetControl_Asp(obj, "");

                IEnumerable<ASPControlEx> arrControls = objViewInfoENEx.arrViewFeatureFlds
                    .Select(GetControl_Asp4SingleModel)
                    .Distinct(new ControlIdComparer());
                strCodeForCs.Append("\r\n" + arrControls.GC_ViewModel());              

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(Mvc_Model_Feature4CSharp);
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
            this.ClsName = string.Format("QryModel4{0}", objViewInfoENEx.TabName);
            objViewInfoENEx.ClsName = this.ClsName;
        }
     
    }
}
