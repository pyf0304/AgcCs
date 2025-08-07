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
using System.Data;
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
    partial class AppController4Swift4Base : clsGeneCodeBase4Tab
    {


        #region 构造函数

        public AppController4Swift4Base(string strTabId, string strPrjDataBaseId, string strPrjId)
          : base(strTabId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
        }
        #endregion

        /// <summary>
        /// 生成Web Service转换层代码--Swift4
        /// </summary>
        /// <returns></returns>
        public string A_GenController_Swift4(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
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
            string strTemp; ///临时变量;
            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
              clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
              objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                .OrderBy(x => x.OrderNum);



            objPrjTabENEx.ClsName = "cls" + objPrjTabENEx.TabName + "_Controller";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".swift";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName( objFuncModule, objPrjTabENEx);
            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".swift";

            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //
            try
            {
                //类名开始

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));



                strCodeForCs.AppendFormat("\r\n" + "import UIKit;",
                      objProjectsENEx.JavaPackageName,
                      objPrjTabENEx.TabName);


                strCodeForCs.Append("\r\n" + ""); //

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);

                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/**");
                strCodeForCs.AppendFormat("\r\n" + "* Created by {0} on {1}.",
                    objPrjTabENEx.UserId,
                    clsDateTime.getTodayStr(3));
                strCodeForCs.AppendFormat("\r\n" + "* 注意:1、该类必须与调用界面处于同一个包,否则调用不成功!", objPrjTabENEx.UserId, clsDateTime.getTodayStr(3));
                strCodeForCs.AppendFormat("\r\n" + "*      2、该文件和类最好不要直接使用,以免覆盖；");
                strCodeForCs.AppendFormat("\r\n" + "*      3、该类可以作为UIViewContraller界面的基类；");
                strCodeForCs.AppendFormat("\r\n" + "*      4、所有针对表:[{0}]的WebService函数操作的界面控制类都可以以此为基类；", objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "* 使用方法：1、可以建立另一文件、另一个类作为该类的扩展类,把单击事件(~_Click()函数)复制到扩展,并加上[override]；");
                strCodeForCs.AppendFormat("\r\n" + "*              例如：class vc{0}_QUDIEx : vc{0}_QUDI.", objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "*           2、可以建立另一文件、另一个类, 把该类的代码复制到另一方件中。");
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "class  cls{0}_Controller : NSObject",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");

                //生成所有的函数

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    if (strFuncName.IndexOf("Swift4_icls") > 0) continue;

                    if (strFuncName.IndexOf("Swift4_btnClick") > 0)
                    {
                        strTemp =  A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    else if (strFuncName.IndexOf("Swift4_Invoke") > 0)
                    {
                        strTemp =  A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    else
                    {
                        strTemp = A_GeneFuncCode_Swift4(strFuncName);
                    }
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }
                }

                strCodeForCs.Append("\r\n" + "}");
                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                     strFuncName = objvFunction4GeneCodeEN.FuncName;
                    if (strFuncName.IndexOf("Swift4_icls") < 0) continue;
                    if (strFuncName.IndexOf("Swift4_btnClick") > 0)
                    {
                        strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    else if (strFuncName.IndexOf("Swift4_icls") > 0)
                    {
                        strTemp = A_GeneFuncCode_Swift4_icls(strFuncName);
                    }
                    else if (strFuncName.IndexOf("Swift4_Invoke") > 0)
                    {
                        strTemp =  A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    else
                    {
                        strTemp = A_GeneFuncCode_Swift4(strFuncName);
                    }
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }
                }

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            
            }
            return strCodeForCs.ToString();
        }
        public string A_GenController_Swift4_Desk_top(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
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
            string strTemp; ///临时变量;
            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
              clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
              objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                .OrderBy(x => x.OrderNum);



            objPrjTabENEx.ClsName = "cls" + objPrjTabENEx.TabName + "_Controller";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".swift";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName( objFuncModule, objPrjTabENEx);
            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".swift";

            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //
            try
            {
                //类名开始

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));



                strCodeForCs.AppendFormat("\r\n" + "import Cocoa",
                      objProjectsENEx.JavaPackageName,
                      objPrjTabENEx.TabName);


                strCodeForCs.Append("\r\n" + ""); //

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);

                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/**");
                strCodeForCs.AppendFormat("\r\n" + "* Created by {0} on {1}.",
                    objPrjTabENEx.UserId,
                    clsDateTime.getTodayStr(3));
                strCodeForCs.AppendFormat("\r\n" + "* 注意:1、该类必须与调用界面处于同一个包,否则调用不成功!", objPrjTabENEx.UserId, clsDateTime.getTodayStr(3));
                strCodeForCs.AppendFormat("\r\n" + "*      2、该文件和类最好不要直接使用,以免覆盖；");
                strCodeForCs.AppendFormat("\r\n" + "*      3、该类可以作为UIViewContraller界面的基类；");
                strCodeForCs.AppendFormat("\r\n" + "*      4、所有针对表:[{0}]的WebService函数操作的界面控制类都可以以此为基类；", objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "* 使用方法：1、可以建立另一文件、另一个类作为该类的扩展类,把单击事件(~_Click()函数)复制到扩展,并加上[override]；");
                strCodeForCs.AppendFormat("\r\n" + "*              例如：class vc{0}_QUDIEx : vc{0}_QUDI.", objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "*           2、可以建立另一文件、另一个类, 把该类的代码复制到另一方件中。");
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "class  cls{0}_Controller : NSObject",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");

                //生成所有的函数

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    if (strFuncName.IndexOf("Swift4_Desk_top_icls") > 0) continue;

                    if (strFuncName.IndexOf("Swift4_Desk_top_btnClick") > 0)
                    {
                        strTemp =  A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    else if (strFuncName.IndexOf("Swift4_Desk_top_Invoke") > 0)
                    {
                        strTemp =  A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    else
                    {
                        strTemp = A_GeneFuncCode_Swift4(strFuncName);
                    }
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }
                }

                strCodeForCs.Append("\r\n" + "}");
                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    if (strFuncName.IndexOf("Swift4_icls") < 0) continue;
                    if (strFuncName.IndexOf("Swift4_btnClick") > 0)
                    {
                        strTemp =  A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    else if (strFuncName.IndexOf("Swift4_icls") > 0)
                    {
                        strTemp = A_GeneFuncCode_Swift4_icls(strFuncName);
                    }
                    else if (strFuncName.IndexOf("Swift4_Invoke") > 0)
                    {
                        strTemp =  A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    else
                    {
                        strTemp = A_GeneFuncCode_Swift4(strFuncName);
                    }
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }
                }

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
                
            }
            return strCodeForCs.ToString();
        }

        public string A_GenController_Swift4_UnitTest(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
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
            string strTemp; ///临时变量;
            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
              clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
              objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                .OrderBy(x => x.OrderNum);



            objPrjTabENEx.ClsName = "vc" + objPrjTabENEx.TabName + "_UnitTest";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".swift";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName( objFuncModule, objPrjTabENEx);
            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".swift";

            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //
            try
            {
                //类名开始

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));



                strCodeForCs.AppendFormat("\r\n" + "import UIKit;",
                      objProjectsENEx.JavaPackageName,
                      objPrjTabENEx.TabName);


                strCodeForCs.Append("\r\n" + ""); //

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);

                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/**");
                strCodeForCs.AppendFormat("\r\n" + "* Created by {0} on {1}.",
                    objPrjTabENEx.UserId,
                    clsDateTime.getTodayStr(3));
                strCodeForCs.AppendFormat("\r\n" + "* 注意:1、该类必须与调用界面处于同一个包,否则调用不成功!", objPrjTabENEx.UserId, clsDateTime.getTodayStr(3));
                strCodeForCs.AppendFormat("\r\n" + "*      2、该文件和类最好不要直接使用,以免覆盖；");
                strCodeForCs.AppendFormat("\r\n" + "*      3、该类可以作为UITableViewContraller文件的基类；");
                strCodeForCs.AppendFormat("\r\n" + "*      4、所有针对表:[{0}]的WebService函数操作的界面控制类都可以以此为基类；", objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "* 使用方法：1、可以建立另一文件、另一个类作为该类的扩展类,把单击事件(~_Click()函数)复制到扩展,并加上[override]；");
                strCodeForCs.AppendFormat("\r\n" + "*              例如：class vc{0}_QUDIEx : vc{0}_UnitTest.", objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "*           2、可以建立另一文件、另一个类, 把该类的代码复制到另一方件中。");
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "class vc{0}_UnitTest : UIViewController",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "@IBOutlet weak var lblResult: UILabel!");
                strCodeForCs.Append("\r\n" + "@IBOutlet weak var txtResult: UITextField!");


                strCodeForCs.Append("\r\n" + "override func viewDidLoad()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "super.viewDidLoad()");

                strCodeForCs.Append("\r\n" + "// Do any additional setup after loading the view.");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "override func didReceiveMemoryWarning()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "super.didReceiveMemoryWarning()");
                strCodeForCs.Append("\r\n" + "// Dispose of any resources that can be recreated.");
                strCodeForCs.Append("\r\n" + "}");

                //生成所有的函数


                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    if (strFuncName.IndexOf("Swift4_btnClick") > 0)
                    {
                        strTemp =  A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    else if (strFuncName.IndexOf("Swift4_icls") > 0)
                    {
                        strTemp = A_GeneFuncCode_Swift4_icls(strFuncName);
                    }
                    else if (strFuncName.IndexOf("Swift4_Invoke") > 0)
                    {
                        strTemp =  A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    else
                    {
                        strTemp = A_GeneFuncCode_Swift4(strFuncName);
                    }
                  
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }
                }

                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
                
            }
            return strCodeForCs.ToString();
        }
        public string A_GenController_Swift4_Desk_top_UnitTest(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
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
            string strTemp; ///临时变量;
            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
              clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
              objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                .OrderBy(x => x.OrderNum);



            objPrjTabENEx.ClsName = "vc" + objPrjTabENEx.TabName + "_UnitTest";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".swift";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName( objFuncModule, objPrjTabENEx);
            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".swift";

            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //
            try
            {
                //类名开始

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));



                strCodeForCs.AppendFormat("\r\n" + "import Cocoa",
                      objProjectsENEx.JavaPackageName,
                      objPrjTabENEx.TabName);


                strCodeForCs.Append("\r\n" + ""); //

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);

                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/**");
                strCodeForCs.AppendFormat("\r\n" + "* Created by {0} on {1}.",
                    objPrjTabENEx.UserId,
                    clsDateTime.getTodayStr(3));
                strCodeForCs.AppendFormat("\r\n" + "* 注意:1、该类必须与调用界面处于同一个包,否则调用不成功!", objPrjTabENEx.UserId, clsDateTime.getTodayStr(3));
                strCodeForCs.AppendFormat("\r\n" + "*      2、该文件和类最好不要直接使用,以免覆盖；");
                strCodeForCs.AppendFormat("\r\n" + "*      3、该类可以作为UITableViewContraller文件的基类；");
                strCodeForCs.AppendFormat("\r\n" + "*      4、所有针对表:[{0}]的WebService函数操作的界面控制类都可以以此为基类；", objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "* 使用方法：1、可以建立另一文件、另一个类作为该类的扩展类,把单击事件(~_Click()函数)复制到扩展,并加上[override]；");
                strCodeForCs.AppendFormat("\r\n" + "*              例如：class vc{0}_QUDIEx : vc{0}_UnitTest.", objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "*           2、可以建立另一文件、另一个类, 把该类的代码复制到另一方件中。");
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "class vc{0}_UnitTest : NSViewController",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "@IBOutlet weak var lblResult: NSTextField!");
                strCodeForCs.Append("\r\n" + "@IBOutlet weak var txtResult: NSTextField!");


                strCodeForCs.Append("\r\n" + "override func viewDidLoad()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "super.viewDidLoad()");

                strCodeForCs.Append("\r\n" + "// Do any additional setup after loading the view.");
                strCodeForCs.Append("\r\n" + "}");

                //strCodeForCs.Append("\r\n" + "override func didReceiveMemoryWarning()");
                //strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.Append("\r\n" + "super.didReceiveMemoryWarning()");
                //strCodeForCs.Append("\r\n" + "// Dispose of any resources that can be recreated.");
                //strCodeForCs.Append("\r\n" + "}");

                //生成所有的函数


                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    if (strFuncName.IndexOf("Swift4_Desk_top_btnClick") > 0)
                    {
                        strTemp =  A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    else if (strFuncName.IndexOf("Swift4_Desk_top_icls") > 0)
                    {
                        strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    else if (strFuncName.IndexOf("Swift4_Desk_top_Invoke") > 0)
                    {
                        strTemp =  A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    else
                    {
                        strTemp = A_GeneFuncCode_Swift4(strFuncName);
                    }

                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }
                }

                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
                
            }
            return strCodeForCs.ToString();
        }
          
      
        public string A_GenController_Swift4_Desk_top_UTScriptCS(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
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
            string strTemp; ///临时变量;
            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
              clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
              objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                .OrderBy(x => x.OrderNum);



            objPrjTabENEx.ClsName = "vc" + objPrjTabENEx.TabName + "_UTScript";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".swift";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName( objFuncModule, objPrjTabENEx);
            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".swift";

            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //
            try
            {
                //类名开始

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));



                strCodeForCs.AppendFormat("\r\n" + "import Cocoa",
                      objProjectsENEx.JavaPackageName,
                      objPrjTabENEx.TabName);


                strCodeForCs.Append("\r\n" + ""); //

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);

                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/**");
                strCodeForCs.AppendFormat("\r\n" + "* Created by {0} on {1}.",
                    objPrjTabENEx.UserId,
                    clsDateTime.getTodayStr(3));
                strCodeForCs.AppendFormat("\r\n" + "* 注意:1、该类必须与调用界面处于同一个包,否则调用不成功!", objPrjTabENEx.UserId, clsDateTime.getTodayStr(3));
                strCodeForCs.AppendFormat("\r\n" + "*      2、该文件和类最好不要直接使用,以免覆盖；");
                strCodeForCs.AppendFormat("\r\n" + "*      3、该类可以作为UITableViewContraller文件的基类；");
                strCodeForCs.AppendFormat("\r\n" + "*      4、所有针对表:[{0}]的WebService函数操作的界面控制类都可以以此为基类；", objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "* 使用方法：1、可以建立另一文件、另一个类作为该类的扩展类,把单击事件(~_Click()函数)复制到扩展,并加上[override]；");
                strCodeForCs.AppendFormat("\r\n" + "*              例如：class vc{0}_UTScriptEx : vc{0}_UTScript.", objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "*           2、可以建立另一文件、另一个类, 把该类的代码复制到另一方件中。");
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "class vc{0}_UTScript : NSViewController",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "@IBOutlet weak var lblResult: NSTextField!");
                strCodeForCs.Append("\r\n" + "@IBOutlet weak var txtResult: NSTextField!");
                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    //string strTemp = "";
                    if (strFuncName.IndexOf("Swift4_Desk_top_DeclareButton") > 0)
                    {
                        strTemp =  A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    else
                    {
                        strTemp = "";
                    }
                    //strTemp = A_GeneFuncCode_Java(strFuncName);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }
                }

                strCodeForCs.Append("\r\n" + "override func viewDidLoad()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "super.viewDidLoad()");

                strCodeForCs.Append("\r\n" + "// Do any additional setup after loading the view.");
                strCodeForCs.Append("\r\n" + "}");

                //strCodeForCs.Append("\r\n" + "override func didReceiveMemoryWarning()");
                //strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.Append("\r\n" + "super.didReceiveMemoryWarning()");
                //strCodeForCs.Append("\r\n" + "// Dispose of any resources that can be recreated.");
                //strCodeForCs.Append("\r\n" + "}");

                //生成所有的函数

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    //string strTemp = "";
                    if (strFuncName.IndexOf("Swift4_Desk_top_btnClick") > 0)
                    {
                        strTemp =  A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                        string strSource = string.Format("vc{0}_UnitTest", objPrjTabENEx.TabName);
                        string strTarget = string.Format("vc{0}_UTScript", objPrjTabENEx.TabName);

                        strTemp = strTemp.Replace(strSource, strTarget);
                    }
                    else
                    {
                        strTemp = "";
                    }
                    //strTemp = A_GeneFuncCode_Java(strFuncName);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }
                }


                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
                
            }
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 生成Web Service转换层代码--Swift4
        /// </summary>
        /// <returns></returns>
        public string A_GenController_Swift4_SelfDefWs(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
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
            string strTemp; ///临时变量;


            objWebSrvClassENEx.ClsName = "cls" + objWebSrvClassENEx.ClsName+ "4SD_Controller";
            //objWebSrvClassENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objWebSrvClassENEx.SimpleFileName = objWebSrvClassENEx.ClsName + ".swift";
            strRe_ClsName = objWebSrvClassENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objWebSrvClassENEx.FuncModuleAgcId, objWebSrvClassENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objWebSrvClassENEx.SimpleFileName);
            strClassFName = objWebSrvClassENEx.FolderName + objWebSrvClassENEx.ClsName + ".swift";

            objWebSrvClassENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objWebSrvClassENEx.PrjId); //
            try
            {
                //类名开始

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objWebSrvClassENEx.CurrUserName, objWebSrvClassENEx));



                strCodeForCs.AppendFormat("\r\n" + "import UIKit;",
                      objProjectsENEx.JavaPackageName);


                strCodeForCs.Append("\r\n" + ""); //

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})",
                    objWebSrvClassENEx.ClsName,
                    objWebSrvClassENEx.PageName);

                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/**");
                strCodeForCs.AppendFormat("\r\n" + "* Created by {0} on {1}.",
                    objWebSrvClassENEx.CurrUserName,
                    clsDateTime.getTodayStr(3));
                strCodeForCs.AppendFormat("\r\n" + "* 注意:1、该类必须与调用界面处于同一个包,否则调用不成功!", objWebSrvClassENEx.CurrUserName, clsDateTime.getTodayStr(3));
                strCodeForCs.AppendFormat("\r\n" + "*      2、该文件和类最好不要直接使用,以免覆盖；");
                strCodeForCs.AppendFormat("\r\n" + "*      3、该类可以作为UIViewContraller界面的基类；");
                strCodeForCs.AppendFormat("\r\n" + "*      4、所有针对类:[{0}]的WebService函数操作的界面控制类都可以以此为基类；", objWebSrvClassENEx.ClsName);
                strCodeForCs.AppendFormat("\r\n" + "* 使用方法：1、可以建立另一文件、另一个类作为该类的扩展类,把单击事件(~_Click()函数)复制到扩展,并加上[override]；");
                strCodeForCs.AppendFormat("\r\n" + "*              例如：class vc{0}Ex : vc{0}.", objWebSrvClassENEx.ClsName);
                strCodeForCs.AppendFormat("\r\n" + "*           2、可以建立另一文件、另一个类, 把该类的代码复制到另一方件中。");
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "class  cls{0}4SD_Controller : NSObject",
                    objWebSrvClassENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.Append("\r\n" + "@IBOutlet weak var lblResult: UILabel!");
                //strCodeForCs.Append("\r\n" + "@IBOutlet weak var txtResult: UITextField!");


                //strCodeForCs.Append("\r\n" + "override func viewDidLoad()");
                //strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.Append("\r\n" + "super.viewDidLoad()");

                //strCodeForCs.Append("\r\n" + "// Do any additional setup after loading the view.");
                //strCodeForCs.Append("\r\n" + "}");

                //strCodeForCs.Append("\r\n" + "override func didReceiveMemoryWarning()");
                //strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.Append("\r\n" + "super.didReceiveMemoryWarning()");
                //strCodeForCs.Append("\r\n" + "// Dispose of any resources that can be recreated.");
                //strCodeForCs.Append("\r\n" + "}");

                //生成所有函数的调用函数

                foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
                {
                    if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                    try
                    {
                        strTemp = Gen_Controller_Swift4_InvokeByCommonFunction(objWebSrvFunctionsENEx);
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

                //生成所有函数的内部类函数
                foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
                {
                    if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                    try
                    {
                        strTemp = Gen_Controller_Swift4_iclsByCommonFunction(objWebSrvFunctionsENEx);
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
              

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string A_GenController_Swift4_SelfDefWs4UnitTest(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
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
            string strTemp; ///临时变量;


            objWebSrvClassENEx.ClsName = "vc" + objWebSrvClassENEx.ClsName + "4SD_UnitTest";
            //objWebSrvClassENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objWebSrvClassENEx.SimpleFileName = objWebSrvClassENEx.ClsName + ".swift";
            strRe_ClsName = objWebSrvClassENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objWebSrvClassENEx.FuncModuleAgcId, objWebSrvClassENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objWebSrvClassENEx.SimpleFileName);
            strClassFName = objWebSrvClassENEx.FolderName + objWebSrvClassENEx.ClsName + ".swift";

            objWebSrvClassENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objWebSrvClassENEx.PrjId); //
            try
            {
                //类名开始

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objWebSrvClassENEx.CurrUserName, objWebSrvClassENEx));



                strCodeForCs.AppendFormat("\r\n" + "import UIKit;",
                      objProjectsENEx.JavaPackageName);


                strCodeForCs.Append("\r\n" + ""); //

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})",
                    objWebSrvClassENEx.ClsName,
                    objWebSrvClassENEx.PageName);

                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/**");
                strCodeForCs.AppendFormat("\r\n" + "* Created by {0} on {1}.",
                    objWebSrvClassENEx.CurrUserName,
                    clsDateTime.getTodayStr(3));
                strCodeForCs.AppendFormat("\r\n" + "* 注意:1、该类必须与调用界面处于同一个包,否则调用不成功!", objWebSrvClassENEx.CurrUserName, clsDateTime.getTodayStr(3));
                strCodeForCs.AppendFormat("\r\n" + "*      2、该文件和类最好不要直接使用,以免覆盖；");
                strCodeForCs.AppendFormat("\r\n" + "*      3、该类可以作为UITableViewContraller文件的基类；");
                strCodeForCs.AppendFormat("\r\n" + "*      4、所有针对类:[{0}]的WebService函数操作的界面控制类都可以以此为基类；", objWebSrvClassENEx.ClsName);
                strCodeForCs.AppendFormat("\r\n" + "* 使用方法：1、可以建立另一文件、另一个类作为该类的扩展类,把单击事件(~_Click()函数)复制到扩展,并加上[override]；");
                strCodeForCs.AppendFormat("\r\n" + "*              例如：class tvc{0}Ex : tvc{0}.", objWebSrvClassENEx.ClsName);
                strCodeForCs.AppendFormat("\r\n" + "*           2、可以建立另一文件、另一个类, 把该类的代码复制到另一方件中。");
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "class vc{0}4SD_UnitTest : UIViewController",
                    objWebSrvClassENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "@IBOutlet weak var lblResult: UILabel!");
                strCodeForCs.Append("\r\n" + "@IBOutlet weak var txtResult: UITextField!");


                strCodeForCs.Append("\r\n" + "override func viewDidLoad()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "super.viewDidLoad()");

                strCodeForCs.Append("\r\n" + "// Do any additional setup after loading the view.");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "override func didReceiveMemoryWarning()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "super.didReceiveMemoryWarning()");
                strCodeForCs.Append("\r\n" + "// Dispose of any resources that can be recreated.");
                strCodeForCs.Append("\r\n" + "}");

                //生成所有的函数

                foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
                {
                    if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                    try
                    {
                        strTemp = Gen_Controller_Swift4_btnClickByCommonFunction(objWebSrvFunctionsENEx);
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
        public string A_GenController_Swift4_SelfDefWs4UTScriptCS(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
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
            string strTemp; ///临时变量;


            objWebSrvClassENEx.ClsName = "vc" + objWebSrvClassENEx.ClsName + "4SD_UTScript";
            //objWebSrvClassENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objWebSrvClassENEx.SimpleFileName = objWebSrvClassENEx.ClsName + ".swift";
            strRe_ClsName = objWebSrvClassENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objWebSrvClassENEx.FuncModuleAgcId, objWebSrvClassENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objWebSrvClassENEx.SimpleFileName);
            strClassFName = objWebSrvClassENEx.FolderName + objWebSrvClassENEx.ClsName + ".swift";

            objWebSrvClassENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objWebSrvClassENEx.PrjId); //
            try
            {
                //类名开始

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objWebSrvClassENEx.CurrUserName, objWebSrvClassENEx));



                strCodeForCs.AppendFormat("\r\n" + "import UIKit;",
                      objProjectsENEx.JavaPackageName);


                strCodeForCs.Append("\r\n" + ""); //

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})",
                    objWebSrvClassENEx.ClsName,
                    objWebSrvClassENEx.PageName);

                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/**");
                strCodeForCs.AppendFormat("\r\n" + "* Created by {0} on {1}.",
                    objWebSrvClassENEx.CurrUserName,
                    clsDateTime.getTodayStr(3));
                strCodeForCs.AppendFormat("\r\n" + "* 注意:1、该类必须与调用界面处于同一个包,否则调用不成功!", objWebSrvClassENEx.CurrUserName, clsDateTime.getTodayStr(3));
                strCodeForCs.AppendFormat("\r\n" + "*      2、该文件和类最好不要直接使用,以免覆盖；");
                strCodeForCs.AppendFormat("\r\n" + "*      3、该类可以作为UITableViewContraller文件的基类；");
                strCodeForCs.AppendFormat("\r\n" + "*      4、所有针对类:[{0}]的WebService函数操作的界面控制类都可以以此为基类；", objWebSrvClassENEx.ClsName);
                strCodeForCs.AppendFormat("\r\n" + "* 使用方法：1、可以建立另一文件、另一个类作为该类的扩展类,把单击事件(~_Click()函数)复制到扩展,并加上[override]；");
                strCodeForCs.AppendFormat("\r\n" + "*              例如：class tvc{0}Ex : tvc{0}.", objWebSrvClassENEx.ClsName);
                strCodeForCs.AppendFormat("\r\n" + "*           2、可以建立另一文件、另一个类, 把该类的代码复制到另一方件中。");
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "class vc{0}4SD_UTScript : UIViewController",
                    objWebSrvClassENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "@IBOutlet weak var lblResult: UILabel!");
                strCodeForCs.Append("\r\n" + "@IBOutlet weak var txtResult: UITextField!");
                foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
                {
                    if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                    try
                    {
                        strTemp = Gen_Controller_Swift4_DeclareButtonByCommonFunction(objWebSrvFunctionsENEx);
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

                strCodeForCs.Append("\r\n" + "override func viewDidLoad()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "super.viewDidLoad()");

                strCodeForCs.Append("\r\n" + "// Do any additional setup after loading the view.");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "override func didReceiveMemoryWarning()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "super.didReceiveMemoryWarning()");
                strCodeForCs.Append("\r\n" + "// Dispose of any resources that can be recreated.");
                strCodeForCs.Append("\r\n" + "}");

                //生成所有的函数

                foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
                {
                    if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                    try
                    {
                        strTemp = Gen_Controller_Swift4_btnClickByCommonFunction(objWebSrvFunctionsENEx);
                        string strSource = string.Format("vc{0}4SD_UnitTest", objWebSrvClassENEx.ClsName);
                        string strTarget = string.Format("vc{0}4SD_UTScript", objWebSrvClassENEx.ClsName);

                        strTemp = strTemp.Replace(strSource, strTarget);

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
        /// 生成Web Service转换层代码--Swift2
        /// </summary>
        /// <returns></returns>
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
            string strTemp; ///临时变量;
            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
              clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
              objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                .OrderBy(x => x.OrderNum);


            objPrjTabENEx.ClsName = string.Format("cls{0}WS4Controller", objPrjTabENEx.TabName);
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".swift";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName( objFuncModule, objPrjTabENEx);
            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".swift";

            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //
            try
            {
                //类名开始
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));
                strCodeForCs.AppendFormat("\r\n" + "import Foundation",
                      objProjectsENEx.JavaPackageName,
                      objPrjTabENEx.TabName);

                strCodeForCs.Append("\r\n" + ""); //
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})",
                    objPrjTabENEx.TabCnName,
                    objPrjTabENEx.TabName);

                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/**");
                strCodeForCs.AppendFormat("\r\n" + "* Created by {0} on {1}.",
                    objPrjTabENEx.UserId,
                    clsDateTime.getTodayStr(3));
                strCodeForCs.AppendFormat("\r\n" + "* 注意:该类必须与调用界面处于同一个包,否则调用不成功!", objPrjTabENEx.UserId, clsDateTime.getTodayStr(3));
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "public class  {0} : NSObject",
                       objPrjTabENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "const objTableObjWS4ControllerDelegate : clsTableObjWS4ControllerDelegate?;");

                strCodeForCs.Append("\r\n" + "const queue : OperationQueue!");

                strCodeForCs.Append("\r\n" + "const theTimer: Timer!");
                strCodeForCs.Append("\r\n" + "override init()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "super.init();");
                strCodeForCs.Append("\r\n" + "queue = OperationQueue();");

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.AppendFormat("\r\n" + "init(strMethod : String, mapParam : Dictionary<String, String>, pobj{0}EN : cls{0}EN)",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "super.init();");
                strCodeForCs.Append("\r\n" + "queue = OperationQueue();");
                strCodeForCs.Append("\r\n" + "}");

                //生成所有的函数

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    if (strFuncName.IndexOf("Swift4_btnClick") > 0)
                    {
                        strTemp =  A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    else if (strFuncName.IndexOf("Swift4_icls") > 0)
                    {
                        strTemp = A_GeneFuncCode_Swift4_icls(strFuncName);
                    }
                    else if (strFuncName.IndexOf("Swift4_Invoke") > 0)
                    {
                        strTemp =  A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    else
                    {
                        strTemp = A_GeneFuncCode_Swift4(strFuncName);
                    }
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }
                }


                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
                
            }
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 生成Web Service转换层代码--Swift2
        /// </summary>
        /// <returns></returns>
        public string A_GenTableObjWSController_Swift4_SelfDefWs(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {

            objWebSrvClassENEx.CurrDate = clsDateTime.getTodayStr2(0);

            //让用户设置属性;
            //string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp; ///临时变量;
         
            objWebSrvClassENEx.ClsName = string.Format("{0}WS4Controller", objWebSrvClassENEx.ClsName);
            //objWebSrvClassENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objWebSrvClassENEx.SimpleFileName = objWebSrvClassENEx.ClsName + ".swift";
            strRe_ClsName = objWebSrvClassENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objWebSrvClassENEx.FuncModuleAgcId, objWebSrvClassENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objWebSrvClassENEx.SimpleFileName);
            strClassFName = objWebSrvClassENEx.FolderName + objWebSrvClassENEx.ClsName + ".swift";

            objWebSrvClassENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objWebSrvClassENEx.PrjId); //
            try
            {
                //类名开始
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objWebSrvClassENEx.CurrUserName, objWebSrvClassENEx));
                strCodeForCs.AppendFormat("\r\n" + "import UIKit;",
                      objProjectsENEx.JavaPackageName);

                strCodeForCs.Append("\r\n" + ""); //
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})",
                    objWebSrvClassENEx.ClsName,
                    objWebSrvClassENEx.PageName);

                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/**");
                strCodeForCs.AppendFormat("\r\n" + "* Created by {0} on {1}.",
                    objWebSrvClassENEx.CurrUserName,
                    clsDateTime.getTodayStr(3));
                strCodeForCs.AppendFormat("\r\n" + "* 注意:该类必须与调用界面处于同一个包,否则调用不成功!", objWebSrvClassENEx.CurrUserName, clsDateTime.getTodayStr(3));
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "public class  {0} : NSObject",
                       objWebSrvClassENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "const objTableObjWS4ControllerDelegate : clsTableObjWS4ControllerDelegate?;");

                strCodeForCs.Append("\r\n" + "const queue : OperationQueue!");

                strCodeForCs.Append("\r\n" + "const theTimer: Timer!");
                strCodeForCs.Append("\r\n" + "override init()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "super.init();");
                strCodeForCs.Append("\r\n" + "queue = OperationQueue();");

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.AppendFormat("\r\n" + "init(strMethod : String, mapParam : Dictionary<String, String>)",
                    objWebSrvClassENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "super.init();");
                strCodeForCs.Append("\r\n" + "queue = OperationQueue();");
                strCodeForCs.Append("\r\n" + "}");

                //生成所有的函数
                foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
                {
                    if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                    try
                    {
                        strTemp = Gen_4WS4Controller_Swift4_ByCommonFunction(objWebSrvFunctionsENEx);
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
                strTemp = A_GeneFuncCode_Swift4("Gen_4WS4Controller_Swift4_SelfDefWs_IsFinished4WebService");
                strCodeForCs.Append("\r\n" + strTemp);
               
                strCodeForCs.Append("\r\n" + "}");

                ////把生成写到文件中;
                ////检查该文件名的文件夹名,并判断是否存在;
                //strFolder = clsString.ParentDir_S(strClassFName);
                //if (System.IO.Directory.Exists(strFolder) == false)
                //{
                //    Directory.CreateDirectory(strFolder);
                //}

                //if (clsSysParaEN_Local.IsBackupForGeneCode  == true)
                //{
                //    string strSimpleFileName = clsString.GetSimpleFName_S(strClassFName);
                //    string strFindFileFullFile = clsFile.FindFileFromFolder(objWebSrvClassENEx.FolderName_Root, strSimpleFileName);
                //    while (string.IsNullOrEmpty(strFindFileFullFile) == false)
                //    {
                //        string strMsg = string.Format("文件:{0}已经存在!", strFindFileFullFile);
                //        throw new Exception(strMsg);

                //    }
                //}
                ////UTF8Encoding utf8 = new UTF8Encoding(false);
                //clsFile.CreateFileByString(strClassFName, strCodeForCs.ToString(), myEncoding);
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }



        public string A_GeneFuncCode_Swift4(string strFuncName)
        {
            try
            {
                switch (strFuncName)
                {
                    //case "btnGetFirstJSONObj_Click":
                    //    return btnGetFirstJSONObj_Click();

                    case "Gen_Controller_Swift4_btnGetFirstJSONObj_Click":
                    case "Gen_Controller_Swift4_btnGetFirstJSONObj_Click4tvc":
                        return Gen_Controller_Swift4_btnGetFirstJSONObj_Click();

                    case "Gen_Controller_Swift4_btnGetJSONObjByKey_Click":
                    case "Gen_Controller_Swift4_btnGetJSONObjByKey_Click4tvc":
                        return Gen_Controller_Swift4_btnGetJSONObjByKey_Click();


                    case "Gen_4WS4Controller_Swift4_GetFirstJSONObj":
                        return Gen_4WS4Controller_Swift4_GetFirstJSONObj();

                    case "Gen_4WS4Controller_Swift4_GetRecordObjByKey":
                        return Gen_4WS4Controller_Swift4_GetRecordObjByKey();

                    //case "IsFinished4WebService":
                    //    return IsFinished4WebService();
                    //case "IsFinished4WebService":
                    //    return IsFinished4WebService();


                    case "Gen_4WS4Controller_Swift4_IsFinished4WebService":                    
                        return Gen_4WS4Controller_Swift4_IsFinished4WebService();
                    case "Gen_4WS4Controller_Swift4_SelfDefWs_IsFinished4WebService":
                        return Gen_4WS4Controller_Swift4_SelfDefWs_IsFinished4WebService();

                    //case "Gen_4WS4Controller_1Swift4_SelfDefWs_IsFinished4WebService_Swift4":               
                    //    return Gen_4WS4Controller_Swift4_SelfDefWs_IsFinished4WebService_Swift4BaK20170814();

                    //case "btnDelRecord_Click":
                    //    return btnDelRecord_Click();

                    case "Gen_Controller_Swift4_btnDelRecord_Click":
                    case "Gen_Controller_Swift4_btnDelRecord_Click4tvc":
                        return Gen_Controller_Swift4_btnDelRecord_Click();
                    case "Gen_Controller_Swift4_btnReturnMainPage_Click":
                        return Gen_Controller_Swift4_btnReturnMainPage_Click();

                        
                    case "Gen_4WS4Controller_Swift4_DelRecord":                  
                        return Gen_4WS4Controller_Swift4_DelRecord();

                    //case "Gen_4Ws_run_Java":
                    //    return Gen_4Ws_run_Java();

                    //case "btnAddNewRecord_Click":
                    //    return btnAddNewRecord_Click();

                    case "Gen_Controller_Swift4_btnAddNewRecord_Click":
                    case "Gen_Controller_Swift4_btnAddNewRecord_Click4tvc":
                        return Gen_Controller_Swift4_btnAddNewRecord_Click();


                    case "Gen_Controller_Swift4_btnAddNewRecord4GetMaxStrId_Click":
                    case "Gen_Controller_Swift4_btnAddNewRecord4GetMaxStrId_Click4tvc":
                        return Gen_Controller_Swift4_btnAddNewRecord4GetMaxStrId_Click();
                    case "Gen_Controller_Swift4_btnGetMaxStrId_Click":
                    case "Gen_Controller_Swift4_btnGetMaxStrId_Click4tvc":
                        return Gen_Controller_Swift4_btnGetMaxStrId_Click();
                    case "Gen_Controller_Swift4_btnGetMaxStrIdByPrefix_Click":
                    case "Gen_Controller_Swift4_btnGetMaxStrIdByPrefix_Click4tvc":
                        return Gen_Controller_Swift4_btnGetMaxStrIdByPrefix_Click();

                    case "Gen_4WS4Controller_Swift4_AddNewRecord":
                        return Gen_4WS4Controller_Swift4_AddNewRecord();


                    //case "btnUpdateRecord_Click":
                    //    return btnUpdateRecord_Click();

                    case "Gen_Controller_Swift4_btnUpdateRecord_Click":
                    case "Gen_Controller_Swift4_btnUpdateRecord_Click4tvc":
                        return Gen_Controller_Swift4_btnUpdateRecord_Click();

                    case "Gen_4WS4Controller_Swift4_UpdateRecord":
                        return Gen_4WS4Controller_Swift4_UpdateRecord();

                    case "Gen_Controller_Swift4_btnIsExistRecord_Click":
                    case "Gen_Controller_Swift4_btnIsExistRecord_Click4tvc":
                        return Gen_Controller_Swift4_btnIsExistRecord_Click();

                    case "Gen_Controller_Swift4_btnGetRecCountByCond_Click":
                        return Gen_Controller_Swift4_btnGetRecCountByCond_Click();

                    case "Gen_4WS4Controller_Swift4_IsExistRecord":
                        return Gen_4WS4Controller_Swift4_IsExistRecord();

                    case "Gen_4WS4Controller_Swift4_GetRecCountByCond":
                        return Gen_4WS4Controller_Swift4_GetRecCountByCond();

                    case "Gen_4WS4Controller_Swift4_GetMaxStrId":
                        return Gen_4WS4Controller_Swift4_GetMaxStrId();

                    case "Gen_4WS4Controller_Swift4_GetMaxStrIdByPrefix":
                        return Gen_4WS4Controller_Swift4_GetMaxStrIdByPrefix();

                    //case "btnGetJSONObjLst_Click":
                    //    return btnGetJSONObjLst_Click();

                    case "Gen_Controller_Swift4_btnGetJSONObjLst_Click":
                    case "Gen_Controller_Swift4_btnGetJSONObjLst_Click4tvc":
                        return Gen_Controller_Swift4_btnGetJSONObjLst_Click();
                    case "Gen_Controller_Swift4_btnGetTopJSONObjLst_Click":
                    case "Gen_Controller_Swift4_btnGetTopJSONObjLst_Click4tvc":
                        return Gen_Controller_Swift4_btnGetTopJSONObjLst_Click();
                    case "Gen_Controller_Swift4_btnGetJSONObjLstByPager_Click":
                        return Gen_Controller_Swift4_btnGetJSONObjLstByPager_Click();
                    case "Gen_4WS4Controller_Swift4_GetJSONObjLst":
                        return Gen_4WS4Controller_Swift4_GetJSONObjLst();

                    case "Gen_4WS4Controller_Swift4_GetTopJSONObjLst":
                        return Gen_4WS4Controller_Swift4_GetTopJSONObjLst();

                    case "Gen_4WS4Controller_Swift4_GetJSONObjLstByPager":
                        return Gen_4WS4Controller_Swift4_GetJSONObjLstByPager();

                


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
        /// 根据关键字获取相应的记录的对象 
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Swift4_GetRecordObjByKey()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据关键字获取相应的记录的对象");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">关键字的值</param>",
                objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n /// <returns>根据关键字获取的对象</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public func GetObjBy{1}({2}: {3})",
                objPrjTabENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName,
                objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const values :  Dictionary < String, String > = Dictionary<String, String>();");

            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
            {
                strCodeForCs.AppendFormat("\r\n" + "values[\"{0}\"] = {0};",
                    objKeyField.PrivFuncName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "values[\"{0}\"] = String({0});",
                    objKeyField.PrivFuncName);
            }

            strCodeForCs.AppendFormat("\r\n" + "let obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS : cls{0}WS = cls{0}WS(strMethod: \"GetJSONObjBy{1}\",",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "mapParam: values,");
            strCodeForCs.AppendFormat("\r\n" + "pobj{0}EN: obj{0}EN);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "queue.addOperation(obj{0}WS);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "theTimer = Timer.scheduledTimer(timeInterval: 0.1, target: self, selector: #selector(IsFinished4WebService), userInfo: nil, repeats: true);");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        public string Gen_4WS4Controller_Swift4_GetFirstJSONObj()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取相应的第一条记录的对象");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">条件</strWhereCond>");
            strCodeForCs.Append("\r\n /// <returns>获取相应的记录的对象</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public func GetFirst{0}(strWhereCond: String)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const values :  Dictionary < String, String > = Dictionary<String, String>();");
            strCodeForCs.Append("\r\n" + "values[\"strWhereCond\"] = strWhereCond;");
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS : cls{0}WS = cls{0}WS(strMethod: \"GetFirstJSONObj\",",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "mapParam: values,");
            strCodeForCs.AppendFormat("\r\n" + "pobj{0}EN: obj{0}EN);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "queue.addOperation(obj{0}WS);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "theTimer = Timer.scheduledTimer(timeInterval: 0.1, target: self, selector: #selector(IsFinished4WebService), userInfo: nil, repeats: true);");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }
        public string Gen_4WS4Controller_Swift4_ByCommonFunction(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {
            string strMsg = "";
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取相应的第一条记录的对象");

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
            strCodeForCs.AppendFormat("\r\n /// <returns>返回{0}</returns>",
                    objWebSrvFunctionsENEx.ReturnValueDescription);

            strCodeForCs.AppendFormat("\r\n" + "public func {0}({1})",
                objWebSrvFunctionsENEx.FunctionName, sbParaList.ToString());
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const values :  Dictionary < String, String > = Dictionary<String, String>();");
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
                        strCodeForCs.AppendFormat("\r\n" + "values[\"{0}\"] = {0};",
                                objWebSrvFuncParaEN.ParaName);
                    }
                    else
                    {
                        switch (objDataTypeAbbrEN.SwiftType)
                        {
                            case "Int":
                                strCodeForCs.AppendFormat("\r\n" + "values[\"{0}\"] = String({0});",
                                        objWebSrvFuncParaEN.ParaName);
                                //strCodeForCs.AppendFormat("\r\n" + "mapParam.put(\"{0}\", Integer.toString({0}));",
                                //    objWebSrvFuncParaEN.ParaName);
                                break;
                            case "Float":
                                strCodeForCs.AppendFormat("\r\n" + "values[\"{0}\"] = String({0});",
                                        objWebSrvFuncParaEN.ParaName);
                                break;
                            case "Double":
                                strCodeForCs.AppendFormat("\r\n" + "values[\"{0}\"] = String({0});",
                                        objWebSrvFuncParaEN.ParaName);
                                break;
                            default:
                                strMsg = string.Format("Swift类型：[{0}]没有在函数中被处理!({1})",
                                    objDataTypeAbbrEN.SwiftType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                        }
                    }
                }
            }
            //strCodeForCs.Append("\r\n" + "values[\"strWhereCond\"] = strWhereCond;");

            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS : {0}WS = {0}WS(strMethod: \"{1}\",",
                objWebSrvClassENEx.ClsName,
                objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.Append("\r\n" + "mapParam: values);");
            //strCodeForCs.AppendFormat("\r\n" + "pobj{0}EN: obj{0}EN);",
            //    objWebSrvFunctionsENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "queue.addOperation(obj{0}WS);",
                objWebSrvClassENEx.ClsName);
            strCodeForCs.Append("\r\n" + "theTimer = Timer.scheduledTimer(timeInterval: 0.1, target: self, selector: #selector(IsFinished4WebService), userInfo: nil, repeats: true);");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        public string Gen_Controller_Swift4_btnGetJSONObjByKey_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据关键字获取相应的记录的对象");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">参数列表</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.AppendFormat("\r\n" + "@IBAction func btnGetJSONObjByKey_Click(_ sender: Any) ",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "let iobj{0}GetObjBy{1} : icls{0}GetObjBy{1} = icls{0}GetObjBy{1}(pvcParent: self);",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "iobj{0}GetObjBy{1}.main();",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "class icls{0}GetObjBy{1} : NSObject, clsTableObjWS4ControllerDelegate",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const vcParent : UIViewController;");
            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "init(pvcParent : UIViewController)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "vcParent = pvcParent;");
            strCodeForCs.Append("\r\n" + "super.init();");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "func main()");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
            {
                strCodeForCs.AppendFormat("\r\n" + "let {0} : {1} = \"{2}\";",
                    objKeyField.PrivFuncName,
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType,
                    objKeyField.ObjFieldTabENEx.DefaultValue4Test_Swift);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "let {0} : {1} = {2};",
                    objKeyField.PrivFuncName,
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType,
                    objKeyField.ObjFieldTabENEx.DefaultValue4Test_Swift);
            }
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.GetObjBy{1}({2}: {2});",
                objPrjTabENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "//通过WebService执行GetRecordObjByKey,返回的事件函数,可能需要处理执行错误。");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjByKey,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//可能发生比较严重的错误。例如：WebService的地址不正确、语法不正确等。");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: objResponseData.faultString, vcObj: vcParent);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "//通过WebService执行GetRecordObjByKey,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(returnObject: NSObject, strClassName: String)",
                 clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjByKey,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}EN : cls{0}EN = returnObject as!cls{0}EN;",
                objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"根据关键字’01‘ 获取对象：\\(obj{0}EN.{1})!\"",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_Controller_Swift4_btnGetFirstJSONObj_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取相应的第一条记录的对象");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.Append("\r\n" + "@IBAction func btnGetFirstJSONObj_Click(_ sender: Any) {");

            strCodeForCs.AppendFormat("\r\n" + "let iobj{0}GetFirstObj : icls{0}GetFirstObj = icls{0}GetFirstObj(pvcParent: self);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "iobj{0}GetFirstObj.main();",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "class icls{0}GetFirstObj : NSObject, clsTableObjWS4ControllerDelegate",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const vcParent : UIViewController;");
            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "init(pvcParent : UIViewController)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "vcParent = pvcParent;");
            strCodeForCs.Append("\r\n" + "super.init();");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "func main()");
            strCodeForCs.Append("\r\n" + "{");


            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "let strWhereCond : String = \" 1=1 \";");
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.GetFirst{0}(strWhereCond: strWhereCond);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "//通过WebService执行GetFirstJSONObj,返回的事件函数,可能需要处理执行错误。");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetFirstJSONObj,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//可能发生比较严重的错误。例如：WebService的地址不正确、语法不正确等。");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: objResponseData.faultString, vcObj: vcParent);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "//通过WebService执行GetFirstJSONObj,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(returnObject: NSObject, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetFirstJSONObj,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}EN : cls{0}EN = returnObject as!cls{0}EN;",
                objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"根据条件：‘1=1’ 获取第一个记录对象：\\(obj{0}EN.{1})!\"",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");


            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_Controller_Swift4_ByCommonFunction(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// 调用函数：[{0}]", objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.AppendFormat("\r\n" + "@IBAction func Invoke_{0}() ",
                objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let iobj{0} : icls{0} = icls{0}(pvcParent: self);",
                objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.AppendFormat("\r\n" + "iobj{0}.main();",
                objWebSrvFunctionsENEx.FunctionName);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "class icls{0} : NSObject, clsTableObjWS4ControllerDelegate",
                objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const vcParent : UIViewController;");
            //strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN = cls{0}EN();",
            //    objWebSrvFunctionsENEx.TabName);

            strCodeForCs.Append("\r\n" + "init(pvcParent : UIViewController)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "vcParent = pvcParent;");
            strCodeForCs.Append("\r\n" + "super.init();");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "func main()");
            strCodeForCs.Append("\r\n" + "{");


            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS4Controller : {0}WS4Controller = {0}WS4Controller();",
                objWebSrvClassENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
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
                        strCodeForCs.AppendFormat("\r\n" + " let {1} : {0} = \"{2}\";",
                            objDataTypeAbbrEN.SwiftType,
                            objWebSrvFuncParaEN.ParaName,
                            "0");
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + " let {1} : {0} = {2};",
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

            //  strCodeForCs.Append("\r\n" + "let strWhereCond : String = \" 1=1 \";");
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.{1}({2});",
                objWebSrvClassENEx.ClsName,
                objWebSrvFunctionsENEx.FunctionName,
                sbParaVarList.ToString());
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "//通过WebService执行{0},返回的事件函数,可能需要处理执行错误。",
                objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String, strFunctionName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//可能发生比较严重的错误。例如：WebService的地址不正确、语法不正确等。");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: objResponseData.faultString, vcObj: vcParent);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "//通过WebService执行函数:[{0}],返回的事件函数,这是正确返回,不需要处理执行错误。",
                objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.AppendFormat("\r\n" + "func {0}(strResult: String, strClassName: String, strFunctionName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "let obj{0}EN : cls{0}EN = returnObject as!cls{0}EN;",
            //    objWebSrvFunctionsENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"函数:[{0}]返回值为：\\(strResult)!\"",
                objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");


            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 根据条件获取相应的记录对象列表 
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Swift4_GetJSONObjLst()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取相应的记录对象列表");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">条件</strWhereCond>");
            strCodeForCs.Append("\r\n /// <returns>获取相应的记录的对象</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public func GetJSONObjLst(strWhereCond: String)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const values :  Dictionary < String, String > = Dictionary<String, String>();");
            strCodeForCs.AppendFormat("\r\n" + "values[\"strWhereCond\"] = strWhereCond;");
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS : cls{0}WS = cls{0}WS(strMethod: \"GetJSONObjLst\",",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "mapParam: values,");
            strCodeForCs.AppendFormat("\r\n" + "pobj{0}EN: obj{0}EN);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "queue.addOperation(obj{0}WS);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "theTimer = Timer.scheduledTimer(timeInterval: 0.1, target: self, selector: #selector(IsFinished4WebService), userInfo: nil, repeats: true);");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 根据条件获取相应的记录对象列表 
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Swift4_GetTopJSONObjLst()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取相应的记录对象列表");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"intTopSize\">顶部记录数</strWhereCond>");
            strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">条件</strWhereCond>");
            strCodeForCs.Append("\r\n /// <returns>获取相应的记录的对象</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public func GetTopJSONObjLst(intTopSize: Int, strWhereCond: String)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const values :  Dictionary < String, String > = Dictionary<String, String>();");
            strCodeForCs.AppendFormat("\r\n" + "values[\"intTopSize\"] = String(intTopSize);");
            strCodeForCs.AppendFormat("\r\n" + "values[\"strWhereCond\"] = strWhereCond;");
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS : cls{0}WS = cls{0}WS(strMethod: \"GetTopJSONObjLst\",",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "mapParam: values,");
            strCodeForCs.AppendFormat("\r\n" + "pobj{0}EN: obj{0}EN);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "queue.addOperation(obj{0}WS);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "theTimer = Timer.scheduledTimer(timeInterval: 0.1, target: self, selector: #selector(IsFinished4WebService), userInfo: nil, repeats: true);");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 根据条件获取相应的记录对象列表 
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Swift4_GetJSONObjLstByPager()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取相应的记录对象列表");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"intPageIndex\">页序号</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intPageSize\">页记录数</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">条件</strWhereCond>");
            strCodeForCs.Append("\r\n /// <param name = \"strOrderBy\">排序方式</param>");
            strCodeForCs.Append("\r\n /// <returns>获取相应的记录的对象</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public func GetJSONObjLstByPager(intPageIndex: Int, intPageSize: Int, strWhereCond: String, strOrderBy: String)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const values :  Dictionary < String, String > = Dictionary<String, String>();");
            strCodeForCs.AppendFormat("\r\n" + "values[\"intPageIndex\"] = String(intPageIndex);");
            strCodeForCs.AppendFormat("\r\n" + "values[\"intPageSize\"] = String(intPageSize);");
            strCodeForCs.AppendFormat("\r\n" + "values[\"strWhereCond\"] = strWhereCond;");
            strCodeForCs.AppendFormat("\r\n" + "values[\"strOrderBy\"] = strOrderBy;");
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS : cls{0}WS = cls{0}WS(strMethod: \"GetJSONObjLstByPager\",",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "mapParam: values,");
            strCodeForCs.AppendFormat("\r\n" + "pobj{0}EN: obj{0}EN);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "queue.addOperation(obj{0}WS);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "theTimer = Timer.scheduledTimer(timeInterval: 0.1, target: self, selector: #selector(IsFinished4WebService), userInfo: nil, repeats: true);");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        

        public string Gen_Controller_Swift4_btnGetJSONObjLst_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取相应的对象列表");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.AppendFormat("\r\n" + "@IBAction func btnGetJSONObjLst_Click(_ sender: Any) ",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let iobj{0}GetJSONObjLst : icls{0}GetJSONObjLst = icls{0}GetJSONObjLst(pvcParent: self);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "iobj{0}GetJSONObjLst.main();",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "class icls{0}GetJSONObjLst : NSObject, clsTableObjWS4ControllerDelegate",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const vcParent : UIViewController;");
            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "init(pvcParent : UIViewController)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "vcParent = pvcParent;");
            strCodeForCs.Append("\r\n" + "super.init();");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "func main()");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "let strWhereCond : String = \" 1=1 \";");
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.GetJSONObjLst(strWhereCond: strWhereCond);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//通过WebService执行GetRecordObjLst,返回的事件函数,可能需要处理执行错误。");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLst, enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//可能发生比较严重的错误。例如：WebService的地址不正确、语法不正确等。");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: objResponseData.faultString, vcObj: vcParent);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//通过WebService执行GetRecordObjLst,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(returnObjectList: NSObject, strClassName: String)",
                                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLst, enumDict4GC_DictKey2.conCorrectFinished));
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let arr{0}ObjLst : Array < cls{0}EN > = returnObjectList as!Array<cls{0}EN>;",
                objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"共获取对象列表数：\\(arr{0}ObjLst.count)!\"",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        public string Gen_Controller_Swift4_btnGetTopJSONObjLst_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取相应的顶部多条对象列表");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.AppendFormat("\r\n" + "@IBAction func btnGetTopJSONObjLst_Click(_ sender: Any) ",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let iobj{0}GetTopJSONObjLst : icls{0}GetTopJSONObjLst = icls{0}GetTopJSONObjLst(pvcParent: self);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "iobj{0}GetTopJSONObjLst.main();",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "class icls{0}GetTopJSONObjLst : NSObject, clsTableObjWS4ControllerDelegate",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const vcParent : UIViewController;");
            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "init(pvcParent : UIViewController)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "vcParent = pvcParent;");
            strCodeForCs.Append("\r\n" + "super.init();");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "func main()");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "let intTopSize : Int = 2;");
            strCodeForCs.Append("\r\n" + "let strWhereCond : String = \" 1=1 \";");
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.GetTopJSONObjLst(intTopSize: intTopSize, strWhereCond: strWhereCond);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//通过WebService执行GetTopRecordObjLst,返回的事件函数,可能需要处理执行错误。");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetTopRecordJSONObjLst, enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//可能发生比较严重的错误。例如：WebService的地址不正确、语法不正确等。");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: objResponseData.faultString, vcObj: vcParent);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//通过WebService执行GetRecordObjLst,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(returnObjectList: NSObject, strClassName: String)",
                                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetTopRecordJSONObjLst, enumDict4GC_DictKey2.conCorrectFinished));
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let arr{0}ObjLst : Array < cls{0}EN > = returnObjectList as!Array<cls{0}EN>;",
                objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"共获取对象列表数：\\(arr{0}ObjLst.count)!\"",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_Controller_Swift4_btnGetJSONObjLstByPager_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取相应的顶部多条对象列表");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.AppendFormat("\r\n" + "@IBAction func btnGetJSONObjLstByPager_Click(_ sender: Any) ",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let iobj{0}GetJSONObjLstByPager : icls{0}GetJSONObjLstByPager = icls{0}GetJSONObjLstByPager(pvcParent: self);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "iobj{0}GetJSONObjLstByPager.main();",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "class icls{0}GetJSONObjLstByPager : NSObject, clsTableObjWS4ControllerDelegate",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const vcParent : UIViewController;");
            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "init(pvcParent : UIViewController)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "vcParent = pvcParent;");
            strCodeForCs.Append("\r\n" + "super.init();");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "func main()");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
      
            strCodeForCs.Append("\r\n" + "let intPageIndex : Int = 2;");
            strCodeForCs.Append("\r\n" + "let intPageSize : Int = 2;");
            strCodeForCs.Append("\r\n" + "let strWhereCond : String = \" 1=1 \";");
            strCodeForCs.Append("\r\n" + "let strOrderBy : String = \" 1=1 \";");
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.GetJSONObjLstByPager(intPageIndex: intPageIndex, intPageSize:intPageSize, strWhereCond: strWhereCond, strOrderBy: strOrderBy );",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//通过WebService执行GetRecordObjLstByPager,返回的事件函数,可能需要处理执行错误。");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLstByPager, enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//可能发生比较严重的错误。例如：WebService的地址不正确、语法不正确等。");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: objResponseData.faultString, vcObj: vcParent);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//通过WebService执行GetRecordObjLstByPager,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(returnObjectList: NSObject, strClassName: String)",
                                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLstByPager, enumDict4GC_DictKey2.conCorrectFinished));
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let arr{0}ObjLst : Array < cls{0}EN > = returnObjectList as!Array<cls{0}EN>;",
                objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"共获取对象列表数：\\(arr{0}ObjLst.count)!\"",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 根据关键字获取相应的记录的对象 
        /// </summary>
        /// <returns></returns>
        public string Gen_Controller_Swift4_btnIsExistRecord_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 检查相应关键字的记录是否存在");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">发送者</param>");
            strCodeForCs.Append("\r\n /// <returns>返回是否存在</returns>");

            strCodeForCs.Append("\r\n" + "@IBAction func btnIsExistRecord_Click(_ sender: Any) {");


            strCodeForCs.Append("\r\n" + "let iobjIsExistRecord : iclsIsExistRecord = iclsIsExistRecord(pvcParent: self);");
            strCodeForCs.Append("\r\n" + "iobjIsExistRecord.main();");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "class iclsIsExistRecord : NSObject, clsTableObjWS4ControllerDelegate");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const vcParent : UIViewController;");
            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);


            strCodeForCs.Append("\r\n" + "init(pvcParent : UIViewController)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "vcParent = pvcParent;");
            strCodeForCs.Append("\r\n" + "super.init();");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "func main()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "let strWhereCond : String = \"{0} ='12'\";",
                objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.IsExistRecord(strWhereCond: strWhereCond);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//通过WebService执行IsExistRecord,返回的事件函数,可能需要处理执行错误。");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord, enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//可能发生比较严重的错误。例如：WebService的地址不正确、语法不正确等。");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: objResponseData.faultString, vcObj: vcParent);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//通过WebService执行IsExistRecord,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(returnBool: Bool, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conCorrectFinished));
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "switch strClassName {");
            strCodeForCs.AppendFormat("\r\n" + "case \"cls{0}WS4Controller\":",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "if (returnBool == false)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"根据条件：‘{0}='12'’ 不存在!\"",
                objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"根据条件：‘{0}='12'’ 存在!\"",
                objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.AppendFormat("\r\n" + "case \"cls{0}WS4Controller2\":",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "break;");

            strCodeForCs.Append("\r\n" + "default: ");

            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        /// <summary>
        /// 根据关键字获取相应的记录的对象 
        /// </summary>
        /// <returns></returns>
        public string Gen_Controller_Swift4_btnGetRecCountByCond_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 获取相应条件的记录数");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">发送者</param>");
            strCodeForCs.Append("\r\n /// <returns>获取相应条件的记录数</returns>");

            strCodeForCs.Append("\r\n" + "@IBAction func btnGetRecCountByCond_Click(_ sender: Any) {");


            strCodeForCs.Append("\r\n" + "let iobjGetRecCountByCond : iclsGetRecCountByCond = iclsGetRecCountByCond(pvcParent: self);");
            strCodeForCs.Append("\r\n" + "iobjGetRecCountByCond.main();");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "class iclsGetRecCountByCond : NSObject, clsTableObjWS4ControllerDelegate");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const vcParent : UIViewController;");
            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);


            strCodeForCs.Append("\r\n" + "init(pvcParent : UIViewController)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "vcParent = pvcParent;");
            strCodeForCs.Append("\r\n" + "super.init();");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "func main()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "let strWhereCond : String = \"{0} ='12'\";",
                objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.GetRecCountByCond(strWhereCond: strWhereCond);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//通过WebService执行GetRecCountByCond,返回的事件函数,可能需要处理执行错误。");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecCountByCond, enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//可能发生比较严重的错误。例如：WebService的地址不正确、语法不正确等。");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: objResponseData.faultString, vcObj: vcParent);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//通过WebService执行GetRecCountByCond,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(returnInt: Int, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecCountByCond,
                enumDict4GC_DictKey2.conCorrectFinished));
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"根据条件：‘1=1’的记录数：[\\(returnInt)]!\"",
                objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        /// <summary>
        /// 根据关键字获取相应的记录的对象
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Swift4_IsExistRecord()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件在表中检查是否满足条件的记录");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">检查存在的条件</param>");
            strCodeForCs.Append("\r\n /// <returns>存在返回true,不存在返回：false</returns>");
            strCodeForCs.Append("\r\n" + "public func IsExistRecord(strWhereCond : String)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const values :  Dictionary < String, String > = Dictionary<String, String>();");
            strCodeForCs.Append("\r\n" + "values[\"strWhereCond\"] = strWhereCond;");
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS : cls{0}WS = cls{0}WS(strMethod: \"IsExistRecord\",",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "mapParam: values,");
            strCodeForCs.AppendFormat("\r\n" + "pobj{0}EN: obj{0}EN);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "queue.addOperation(obj{0}WS);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "theTimer = Timer.scheduledTimer(timeInterval: 0.1, target: self, selector: #selector(IsFinished4WebService), userInfo: nil, repeats: true);");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 根据关键字获取相应的记录的对象
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Swift4_GetRecCountByCond()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件在表中获取记录数");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">获取记录数的条件</param>");
            strCodeForCs.Append("\r\n /// <returns>返回记录数</returns>");
            strCodeForCs.Append("\r\n" + "public func GetRecCountByCond(strWhereCond : String)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const values :  Dictionary < String, String > = Dictionary<String, String>();");
            strCodeForCs.Append("\r\n" + "values[\"strWhereCond\"] = strWhereCond;");
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS : cls{0}WS = cls{0}WS(strMethod: \"GetRecCountByCond\",",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "mapParam: values,");
            strCodeForCs.AppendFormat("\r\n" + "pobj{0}EN: obj{0}EN);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "queue.addOperation(obj{0}WS);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "theTimer = Timer.scheduledTimer(timeInterval: 0.1, target: self, selector: #selector(IsFinished4WebService), userInfo: nil, repeats: true);");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Swift4_GetMaxStrId()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            //    strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">检查存在的条件</param>");
            strCodeForCs.Append("\r\n /// <returns>当前表关键字值的最大值,再加1</returns>");
            strCodeForCs.Append("\r\n" + "public func GetMaxStrId()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "let values :  Dictionary < String, String > = Dictionary<String, String>();");
            //    strCodeForCs.Append("\r\n" + "values[\"strWhereCond\"] = strWhereCond;");
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS : cls{0}WS = cls{0}WS(strMethod: \"GetMaxStrId\",",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "mapParam: values,");
            strCodeForCs.AppendFormat("\r\n" + "pobj{0}EN: obj{0}EN);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "queue.addOperation(obj{0}WS);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "theTimer = Timer.scheduledTimer(timeInterval: 0.1, target: self, selector: #selector(IsFinished4WebService), userInfo: nil, repeats: true);");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Swift4_GetMaxStrIdByPrefix()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strPrefix\">关键字值的前缀</param>");
            strCodeForCs.Append("\r\n /// <returns>当前表关键字值的最大值,再加1</returns>");
            strCodeForCs.Append("\r\n" + "public func GetMaxStrIdByPrefix(strPrefix : String)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const values :  Dictionary < String, String > = Dictionary<String, String>();");
            strCodeForCs.Append("\r\n" + "values[\"strPrefix\"] = strPrefix;");
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS : cls{0}WS = cls{0}WS(strMethod: \"GetMaxStrIdByPrefix\",",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "mapParam: values,");
            strCodeForCs.AppendFormat("\r\n" + "pobj{0}EN: obj{0}EN);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "queue.addOperation(obj{0}WS);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "theTimer = Timer.scheduledTimer(timeInterval: 0.1, target: self, selector: #selector(IsFinished4WebService), userInfo: nil, repeats: true);");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        /// <summary>
        /// 根据关键字获取相应的记录的对象 
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Swift4_IsFinished4WebService()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 调用WebService是否完成函数");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns>获取的调用WebService是否完成函数返回的数据</returns>");
            strCodeForCs.Append("\r\n" + "@objc func IsFinished4WebService()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "if (cls{0}WS.ResponseData.IsFinished == true)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "theTimer.invalidate();");
            strCodeForCs.AppendFormat("\r\n" + "let objResponseData : clsResponseData = clsResponseData(structResponseData: cls{0}WS.ResponseData);",
                objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "let strResult = cls{0}WS.ResponseData.data;",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "switch cls{0}WS.ResponseData.what ",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "case 1: //\"GetObjBy{1}\":",
                objPrjTabENEx.TabName,
                objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n" + "if (cls{0}WS.ResponseData.errorId >= 2)",
                   objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//可能发生比较严重的错误。例如：WebService的地址不正确、语法不正确等。");
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
                    objPrjTabENEx.ClsName,
                    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjByKey,
                    enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "else if (cls{0}WS.ResponseData.errorId == 1)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"获取对象不成功!调用GetObjBy{1}函数出错。\\(cls{0}WS.ResponseData.faultString)\";",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
          //  strCodeForCs.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo: strInfo);");
            strCodeForCs.Append("\r\n" + "objResponseData.faultString = strInfo;");
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
    objPrjTabENEx.ClsName,
    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjByKey,
    enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN;",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "do");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "try obj{0}EN = cls{0}BL.GetObjByJSONStr(strJSON: strResult!);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "objResponseData.returnObject = obj{0}EN;",
    objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate!.{2}!(returnObject: obj{0}EN, strClassName: \"{1}\");",
                 objPrjTabENEx.TabName,
                 objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjByKey,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch let objError as NSError");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"获取对象不成功!调用GetObjBy{1}函数出错。\\(objError.localizedDescription)\";",
          objPrjTabENEx.TabName,
          objKeyField.FldName);
            //  strCodeForCs.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo: strInfo);");
            strCodeForCs.Append("\r\n" + "objResponseData.faultString = strInfo;");
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
    objPrjTabENEx.ClsName,
    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjByKey,
    enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.AppendFormat("\r\n" + "case 2: //\"GetJSONObjLst\":",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "if (cls{0}WS.ResponseData.errorId >= 2)",
          objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//可能发生比较严重的错误。例如：WebService的地址不正确、语法不正确等。");
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
                    objPrjTabENEx.ClsName,
                    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLst,
                    enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "else if (cls{0}WS.ResponseData.errorId == 1)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"获取对象列表不成功!调用GetJSONObjLst函数出错。\\(cls{0}WS.ResponseData.faultString)\";",
                objPrjTabENEx.TabName);
            //  strCodeForCs.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo: strInfo);");
            strCodeForCs.Append("\r\n" + "objResponseData.faultString = strInfo;");
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
objPrjTabENEx.ClsName,
clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLst,
enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst : Array < cls{0}EN > = Array<cls{0}EN>();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst = cls{0}BL.GetObjLstByJSONStr(strJSON: strResult!);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "objResponseData.returnObjectList = arr{0}ObjLst as NSObject;",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate!.{2}!(returnObjectList: arr{0}ObjLst as NSObject, strClassName: \"{1}\");",
                    objPrjTabENEx.TabName,
                 objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLst,
                enumDict4GC_DictKey2.conCorrectFinished));
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");

            strCodeForCs.Append("\r\n" + "case 3: //\"AddNewRecord\":");
            strCodeForCs.AppendFormat("\r\n" + "if (cls{0}WS.ResponseData.errorId >= 2)",
        objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//可能发生比较严重的错误。例如：WebService的地址不正确、语法不正确等。");
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
                    objPrjTabENEx.ClsName,
                    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
                    enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "else if (cls{0}WS.ResponseData.errorId == 1)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "");
            strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"添加不成功,调用AddNewRecord函数出错。\\(cls{0}WS.ResponseData.faultString)\";",
                objPrjTabENEx.TabName);
            //  strCodeForCs.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo: strInfo);");
            strCodeForCs.Append("\r\n" + "objResponseData.faultString = strInfo;");
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
             objPrjTabENEx.ClsName,
             clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
             enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "let bolResult : Bool = clsPubFun.myBool(myObj: strResult as AnyObject);");
            strCodeForCs.Append("\r\n" + "objResponseData.returnBool = bolResult;");

         
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate!.{1}!(returnBool: bolResult, strClassName: \"{0}\");",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
                enumDict4GC_DictKey2.conCorrectFinished)
                );
            strCodeForCs.Append("\r\n" + "return;");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "case 4: //\"UpdateRecord\":");
            strCodeForCs.AppendFormat("\r\n" + "if (cls{0}WS.ResponseData.errorId >= 2)",
        objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//可能发生比较严重的错误。例如：WebService的地址不正确、语法不正确等。");
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
                    objPrjTabENEx.ClsName,
                    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conUpdateRecordByJSON,
                    enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "else if (cls{0}WS.ResponseData.errorId == 1)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"修改不成功!调用UpdateRecord函数出错。\\(cls{0}WS.ResponseData.faultString)\";",
                objPrjTabENEx.TabName);
            //  strCodeForCs.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo: strInfo);");
            strCodeForCs.Append("\r\n" + "objResponseData.faultString = strInfo;");
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conUpdateRecordByJSON,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "let bolResult : Bool = clsPubFun.myBool(myObj: strResult as AnyObject);");
            strCodeForCs.Append("\r\n" + "objResponseData.returnBool = bolResult;");

            
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate!.{1}!(returnBool: bolResult, strClassName: \"{0}\");",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conUpdateRecordByJSON,
                enumDict4GC_DictKey2.conCorrectFinished));
            strCodeForCs.Append("\r\n" + "return;");

            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "case 5: //\"DelRecord\":");

            strCodeForCs.AppendFormat("\r\n" + "if (cls{0}WS.ResponseData.errorId >= 2)",
               objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//可能发生比较严重的错误。例如：WebService的地址不正确、语法不正确等。");
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
                    objPrjTabENEx.ClsName,
                    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conDelRecord,
                    enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "else if (cls{0}WS.ResponseData.errorId == 1)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"删除不成功!调用DelRecord函数出错。\\(cls{0}WS.ResponseData.faultString)\";",
                objPrjTabENEx.TabName);
            //  strCodeForCs.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo: strInfo);");
            strCodeForCs.Append("\r\n" + "objResponseData.faultString = strInfo;");
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
              objPrjTabENEx.ClsName,
              clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conDelRecord,
              enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "let bolResult : Bool = clsPubFun.myBool(myObj: strResult as AnyObject);");
            strCodeForCs.Append("\r\n" + "objResponseData.returnBool = bolResult;");
          

            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate!.{1}!(returnBool: bolResult, strClassName: \"{0}\");",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conDelRecord,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.AppendFormat("\r\n" + "case 6: //\"GetFirst{0}\":",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "if (cls{0}WS.ResponseData.errorId >= 2)",
          objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//可能发生比较严重的错误。例如：WebService的地址不正确、语法不正确等。");
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
                    objPrjTabENEx.ClsName,
                    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetFirstJSONObj,
                    enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "else if (cls{0}WS.ResponseData.errorId == 1)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"获取第一条记录不成功!调用GetFirst{0}函数出错。\\(cls{0}WS.ResponseData.faultString)\";",
                objPrjTabENEx.TabName);
            //  strCodeForCs.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo: strInfo);");
            strCodeForCs.Append("\r\n" + "objResponseData.faultString = strInfo;");
            strCodeForCs.Append("\r\n" + "//通过WebService执行GetFirstJSONObj,返回的事件函数,可能需要处理执行错误。");
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetFirstJSONObj,
                enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN;",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "do");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "try obj{0}EN = cls{0}BL.GetObjByJSONStr(strJSON: strResult!);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "objResponseData.returnObject = obj{0}EN;",
                objPrjTabENEx.TabName);       

            strCodeForCs.Append("\r\n" + "//通过WebService执行GetFirstJSONObj,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate!.{2}!(returnObject: obj{0}EN, strClassName: \"{1}\");",
                 objPrjTabENEx.TabName,
                 objPrjTabENEx.ClsName,
                 clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetFirstJSONObj,
                enumDict4GC_DictKey2.conCorrectFinished));
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch let objError as NSError");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"获取第一条记录不成功!调用GetFirst{0}函数出错。\\(objError.localizedDescription)\";",
              objPrjTabENEx.TabName);
            //  strCodeForCs.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo: strInfo);");
            strCodeForCs.Append("\r\n" + "objResponseData.faultString = strInfo;");
            strCodeForCs.Append("\r\n" + "//通过WebService执行GetFirstJSONObj,返回的事件函数,可能需要处理执行错误。");
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetFirstJSONObj,
                enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "case 7: //\"IsExistRecord\":");
            strCodeForCs.AppendFormat("\r\n" + "if (cls{0}WS.ResponseData.errorId >= 2)",
             objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//可能发生比较严重的错误。例如：WebService的地址不正确、语法不正确等。");
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
                    objPrjTabENEx.ClsName,
                    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                    enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "else if (cls{0}WS.ResponseData.errorId == 1)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"调用IsExistRecord函数出错。\\(cls{0}WS.ResponseData.faultString)\";",
                objPrjTabENEx.TabName);
            //  strCodeForCs.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo: strInfo);");
            strCodeForCs.Append("\r\n" + "objResponseData.faultString = strInfo;");
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
            objPrjTabENEx.ClsName,
            clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
            enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "let bolResult : Bool = clsPubFun.myBool(myObj: strResult as AnyObject);");
            strCodeForCs.Append("\r\n" + "objResponseData.returnBool = bolResult;");
        

            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate!.{1}!(returnBool: bolResult, strClassName: \"{0}\");",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");

            strCodeForCs.Append("\r\n" + "case 8: //\"GetMaxStrId\":");
            strCodeForCs.AppendFormat("\r\n" + "if (cls{0}WS.ResponseData.errorId >= 2)",
         objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//可能发生比较严重的错误。例如：WebService的地址不正确、语法不正确等。");
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
                    objPrjTabENEx.ClsName,
                    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                    enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "else if (cls{0}WS.ResponseData.errorId == 1)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"调用GetMaxStrId函数出错。\\(cls{0}WS.ResponseData.faultString)\";",
                objPrjTabENEx.TabName);
            //  strCodeForCs.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo: strInfo);");
            strCodeForCs.Append("\r\n" + "objResponseData.faultString = strInfo;");
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
             objPrjTabENEx.ClsName,
             clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
             enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "let strResult : String = clsPubFun.myBool(myObj: strResult as AnyObject);");
            strCodeForCs.Append("\r\n" + "objResponseData.returnString = strResult!;");
         

            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate!.{1}!(returnString: strResult!, strClassName: \"{0}\");",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");

            strCodeForCs.Append("\r\n" + "case 9: //\"GetMaxStrIdByPrefix\":");
            strCodeForCs.AppendFormat("\r\n" + "if (cls{0}WS.ResponseData.errorId >= 2)",
         objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//可能发生比较严重的错误。例如：WebService的地址不正确、语法不正确等。");
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
                    objPrjTabENEx.ClsName,
                    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrIdByPrefix,
                    enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "else if (cls{0}WS.ResponseData.errorId == 1)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"调用GetMaxStrIdByPrefix函数出错。\\(cls{0}WS.ResponseData.faultString)\";",
                objPrjTabENEx.TabName);
            //  strCodeForCs.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo: strInfo);");
            strCodeForCs.Append("\r\n" + "objResponseData.faultString = strInfo;");
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
             objPrjTabENEx.ClsName,
             clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrIdByPrefix,
             enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "let strResult : String = clsPubFun.myBool(myObj: strResult as AnyObject);");
            strCodeForCs.Append("\r\n" + "objResponseData.returnString = strResult!;");
         
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate!.{1}!(returnString: strResult!, strClassName: \"{0}\");",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrIdByPrefix,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.AppendFormat("\r\n" + "case 10: //\"GetTopJSONObjLst\":",
objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "if (cls{0}WS.ResponseData.errorId >= 2)",
           objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//可能发生比较严重的错误。例如：WebService的地址不正确、语法不正确等。");
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
                    objPrjTabENEx.ClsName,
                    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetTopRecordJSONObjLst,
                    enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "else if (cls{0}WS.ResponseData.errorId == 1)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"获取顶对象列表不成功!调用GetTopJSONObjLst函数出错。\\(cls{0}WS.ResponseData.faultString)\";",
                objPrjTabENEx.TabName);
            //  strCodeForCs.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo: strInfo);");
            strCodeForCs.Append("\r\n" + "objResponseData.faultString = strInfo;");
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
objPrjTabENEx.ClsName,
clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetTopRecordJSONObjLst,
enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst : Array < cls{0}EN > = Array<cls{0}EN>();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst = cls{0}BL.GetObjLstByJSONStr(strJSON: strResult!);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "objResponseData.returnObjectList = arr{0}ObjLst as NSObject;",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate!.{2}!(returnObjectList: arr{0}ObjLst as NSObject, strClassName: \"{1}\");",
                    objPrjTabENEx.TabName,
                 objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetTopRecordJSONObjLst,
                enumDict4GC_DictKey2.conCorrectFinished));
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");

            strCodeForCs.AppendFormat("\r\n" + "case 11: //\"GetJSONObjLstByPager\":",
objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "if (cls{0}WS.ResponseData.errorId >= 2)",
           objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//可能发生比较严重的错误。例如：WebService的地址不正确、语法不正确等。");
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
                    objPrjTabENEx.ClsName,
                    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLstByPager,
                    enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "else if (cls{0}WS.ResponseData.errorId == 1)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"获取分页对象列表不成功!调用GetJSONObjLstByPager函数出错。\\(cls{0}WS.ResponseData.faultString)\";",
                objPrjTabENEx.TabName);
            //  strCodeForCs.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo: strInfo);");
            strCodeForCs.Append("\r\n" + "objResponseData.faultString = strInfo;");
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
objPrjTabENEx.ClsName,
clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLstByPager,
enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst : Array < cls{0}EN > = Array<cls{0}EN>();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst = cls{0}BL.GetObjLstByJSONStr(strJSON: strResult!);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "objResponseData.returnObjectList = arr{0}ObjLst as NSObject;",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate!.{2}!(returnObjectList: arr{0}ObjLst as NSObject, strClassName: \"{1}\");",
                    objPrjTabENEx.TabName,
                 objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLstByPager,
                enumDict4GC_DictKey2.conCorrectFinished));
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "case 12: //\"GetRecCountByCond\":");
            strCodeForCs.AppendFormat("\r\n" + "if (cls{0}WS.ResponseData.errorId >= 2)",
             objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//可能发生比较严重的错误。例如：WebService的地址不正确、语法不正确等。");
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
                    objPrjTabENEx.ClsName,
                    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecCountByCond,
                    enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "else if (cls{0}WS.ResponseData.errorId == 1)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"调用GetRecCountByCond函数出错。\\(cls{0}WS.ResponseData.faultString)\";",
                objPrjTabENEx.TabName);
            //  strCodeForCs.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo: strInfo);");
            strCodeForCs.Append("\r\n" + "objResponseData.faultString = strInfo;");
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
            objPrjTabENEx.ClsName,
            clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecCountByCond,
            enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "let intResult : Int = Int(strResult!)!;");
            strCodeForCs.Append("\r\n" + "objResponseData.returnInt = intResult;");
            
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate!.{1}!(returnInt: intResult, strClassName: \"{0}\");",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecCountByCond,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");

            strCodeForCs.Append("\r\n" + "default:");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "print(strResult);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 根据关键字获取相应的记录的对象 
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Swift4_SelfDefWs_IsFinished4WebService()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 调用WebService是否完成函数");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns>获取的调用WebService是否完成函数返回的数据</returns>");
            strCodeForCs.Append("\r\n" + "@objc func IsFinished4WebService()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "if ({0}WS.ResponseData.IsFinished == true)",
                objWebSrvClassENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "theTimer.invalidate();");
            strCodeForCs.AppendFormat("\r\n" + "let objResponseData : clsResponseData = clsResponseData(structResponseData: {0}WS.ResponseData);",
                objWebSrvClassENEx.ClsName);

            strCodeForCs.AppendFormat("\r\n" + "let strResult = {0}WS.ResponseData.data;",
                objWebSrvClassENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "switch {0}WS.ResponseData.what ",
                objWebSrvClassENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            int intIndex = 50;
            foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
            {
                if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                strCodeForCs.AppendFormat("\r\n" + "case {1}: //\"{0}\":",
                objWebSrvFunctionsENEx.FunctionName, intIndex);

                strCodeForCs.AppendFormat("\r\n" + "if ({0}WS.ResponseData.errorId >= 2)",
                  objWebSrvClassENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//可能发生比较严重的错误。例如：WebService的地址不正确、语法不正确等。");
                strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{2}!(objResponseData: objResponseData, strClassName: \"{0}\", strFunctionName: \"{1}\");",
                        objWebSrvClassENEx.ClsName,
                        objWebSrvFunctionsENEx.FunctionName,
                        clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
                        enumDict4GC_DictKey2.conFinished));
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.AppendFormat("\r\n" + "else if ({0}WS.ResponseData.errorId == 1)",
                    objWebSrvClassENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"调用[{0}]函数出错。\\({1}WS.ResponseData.faultString)\";",
                    objWebSrvFunctionsENEx.FunctionName,
                    objWebSrvClassENEx.ClsName);
                //  strCodeForCs.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo: strInfo);");
                strCodeForCs.Append("\r\n" + "objResponseData.faultString = strInfo;");
                strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{2}!(objResponseData: objResponseData, strClassName: \"{0}\", strFunctionName: \"{1}\");",
       objWebSrvClassENEx.ClsName,
       objWebSrvFunctionsENEx.FunctionName,
       clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
       enumDict4GC_DictKey2.conFinished));

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "//var obj{0}EN : cls{0}EN;",
                    objWebSrvClassENEx.ClsName);
                strCodeForCs.AppendFormat("\r\n" + "//obj{0}EN = cls{0}BL.GetObjByJSONStr(strJSON: strResult);",
                    objWebSrvClassENEx.ClsName);
                strCodeForCs.AppendFormat("\r\n" + "//objResponseData.returnObject = obj{0}EN;",
                    objWebSrvClassENEx.ClsName);
                strCodeForCs.AppendFormat("\r\n" + "objResponseData.returnString = strResult!;",
                        objWebSrvClassENEx.ClsName);


                strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate!.{2}!(strResult: strResult!, strClassName: \"{0}\", strFunctionName: \"{1}\");",
                                      objWebSrvClassENEx.ClsName,
                                      objWebSrvFunctionsENEx.FunctionName,
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
          //  strCodeForCs.Append("\r\n" + "print(strResult);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 根据关键字获取相应的记录的对象 
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Swift4_SelfDefWs_IsFinished4WebService_Swift4BaK20170814()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 调用WebService是否完成函数");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns>获取的调用WebService是否完成函数返回的数据</returns>");
            strCodeForCs.Append("\r\n" + "func IsFinished4WebService()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "if ({0}WS.ResponseData.IsFinished == true)",
                objWebSrvClassENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "theTimer.invalidate();");
            strCodeForCs.AppendFormat("\r\n" + "let objResponseData : clsResponseData = clsResponseData(structResponseData: {0}WS.ResponseData);",
                objWebSrvClassENEx.ClsName);

            strCodeForCs.AppendFormat("\r\n" + "let strResult = {0}WS.ResponseData.data;",
                objWebSrvClassENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "switch {0}WS.ResponseData.what ",
                objWebSrvClassENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            int intIndex = 50;
            foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
            {
                if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                strCodeForCs.AppendFormat("\r\n" + "case {1}: //\"{0}\":",
                objWebSrvClassENEx.ClsName, intIndex);

                strCodeForCs.AppendFormat("\r\n" + "if ({0}WS.ResponseData.errorId > 0)",
                    objWebSrvClassENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"调用[{0}]函数出错。\\({1}WS.ResponseData.faultString)\";",
                    objWebSrvFunctionsENEx.FunctionName,
                    objWebSrvClassENEx.ClsName);
                strCodeForCs.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo: strInfo);");
                strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{2}!(objResponseData: objResponseData, strClassName: \"{0}\", strFunctionName: \"{1}\");",
       objWebSrvClassENEx.ClsName,
       objWebSrvFunctionsENEx.FunctionName,
       clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
       enumDict4GC_DictKey2.conFinished));

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "//var obj{0}EN : cls{0}EN;",
                    objWebSrvClassENEx.ClsName);
                strCodeForCs.AppendFormat("\r\n" + "//obj{0}EN = cls{0}BL.GetObjByJSONStr(strJSON: strResult);",
                    objWebSrvClassENEx.ClsName);
                strCodeForCs.AppendFormat("\r\n" + "//objResponseData.returnObject = obj{0}EN;",
                    objWebSrvClassENEx.ClsName);
                strCodeForCs.AppendFormat("\r\n" + "objResponseData.returnString = strResult;",
                        objWebSrvClassENEx.ClsName);


                strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate!.{2}!(strResult: strResult, strClassName: \"{0}\", strFunctionName: \"{1}\");",
                                      objWebSrvClassENEx.ClsName,
                                      objWebSrvFunctionsENEx.FunctionName,
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
            strCodeForCs.Append("\r\n" + "print(strResult);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }
      

        /// <summary>
        /// 通用的调用WebService函数 
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Swift4_DelRecord()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 通用的调用WebService函数");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">需要删除的关键字的值</param>",
                objKeyField.ObjFieldTabENEx.PrivPropName);
            strCodeForCs.Append("\r\n /// <returns>删除是否成功？</returns>");
            strCodeForCs.AppendFormat("\r\n" + "func DelRecord({0}: {1}) ",
                objKeyField.PrivFuncName,
                objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const values :  Dictionary < String, String > = Dictionary<String, String>();");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
            {
                strCodeForCs.AppendFormat("\r\n" + "values[\"{0}\"] = {0};",
                    objKeyField.PrivFuncName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "values[\"{0}\"] = String({0});",
                    objKeyField.PrivFuncName);
            }
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS : cls{0}WS = cls{0}WS(strMethod: \"DelRecord\",",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "mapParam: values,");
            strCodeForCs.AppendFormat("\r\n" + "pobj{0}EN: obj{0}EN);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "queue.addOperation(obj{0}WS);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "theTimer = Timer.scheduledTimer(timeInterval: 0.1, target: self, selector: #selector(IsFinished4WebService), userInfo: nil, repeats: true);");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_Controller_Swift4_btnDelRecord_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 删除记录");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\n" + "@IBAction func btnDelRecord_Click(_ sender: Any) {");

            strCodeForCs.Append("\r\n" + "let iobjDelRecord : iclsDelRecord = iclsDelRecord(pvcParent: self);");
            strCodeForCs.Append("\r\n" + "iobjDelRecord.main();");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "class iclsDelRecord : NSObject, clsTableObjWS4ControllerDelegate");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const vcParent : UIViewController;");
            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);


            strCodeForCs.Append("\r\n" + "init(pvcParent : UIViewController)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "vcParent = pvcParent;");
            strCodeForCs.Append("\r\n" + "super.init();");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "func main()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
            {
                strCodeForCs.AppendFormat("\r\n" + "let {0} : {1} = \"{2}\";",
                    objKeyField.PrivFuncName,
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType,
                    objKeyField.ObjFieldTabENEx.DefaultValue4Test_Swift);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "let {0} : {1} = {2};",
                    objKeyField.PrivFuncName,
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType,
                    objKeyField.ObjFieldTabENEx.DefaultValue4Test_Swift);
            }

            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.DelRecord({1}: {1});",
                objPrjTabENEx.TabName,
                objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.Append("\r\n" + "//通过WebService执行DelRecord,返回的事件函数,可能需要处理执行错误。");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conDelRecord,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//可能发生比较严重的错误。例如：WebService的地址不正确、语法不正确等。");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: objResponseData.faultString, vcObj: vcParent);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "//通过WebService执行DelRecord,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(returnBool: Bool, strClassName: String)",
                      clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conDelRecord,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (returnBool == true)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "let strInfo : String = \"删除记录成功!\"");
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "let strInfo : String = \"删除记录不成功!\"");
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");



            return strCodeForCs.ToString();
        }

        public string Gen_Controller_Swift4_btnReturnMainPage_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 返回到主页");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\n" + "@IBAction func btnReturnMainPage_Click(_ sender: AnyObject) {");
            
            strCodeForCs.Append("\r\n" + "let vc = UIStoryboard(name: \"Main\", bundle: nil).instantiateViewController(withIdentifier: \"First\") as UIViewController");
            
            strCodeForCs.Append("\r\n" + "self.present(vc, animated: true, completion: nil);");

            strCodeForCs.Append("\r\n" + "}");



            return strCodeForCs.ToString();
        }


        /// <summary>
        /// 继承Runnable类必须实现的【run】函数  
        /// </summary>
        /// <returns></returns>
        public string Gen_Controller_Swift4_btnAddNewRecord_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 添加新记录");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.Append("\r\n" + "@IBAction func btnAddNewRecord_Click(_ sender: Any) {");
            strCodeForCs.Append("\r\n" + "let iobjAddNewRecord : iclsAddNewRecord = iclsAddNewRecord(pvcParent: self);");
            strCodeForCs.Append("\r\n" + "iobjAddNewRecord.main();");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "class iclsAddNewRecord : NSObject, clsTableObjWS4ControllerDelegate");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const vcParent : UIViewController;");
            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "init(pvcParent : UIViewController)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "vcParent = pvcParent;");
            strCodeForCs.Append("\r\n" + "super.init();");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "func main()");
            strCodeForCs.Append("\r\n" + "{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                string strTemp = SetProperty4DefaultValue_Swift4(objField);
                strCodeForCs.Append(strTemp);
                //if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                //{
                //    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = \"{2}\";",
                //       objPrjTabENEx.TabName,
                //       objField.ObjFieldTabENEx.FldName,
                //       objField.ObjFieldTabENEx.DefaultValue4Test_Swift);
                //}
                //else
                //{
                //    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                //          objPrjTabENEx.TabName,
                //          objField.ObjFieldTabENEx.FldName,
                //          objField.ObjFieldTabENEx.DefaultValue4Test_Swift);
                //}
            }
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "let strWhereCond : String = \"{1} = '\\(obj{0}EN.{1})'\";",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.IsExistRecord(strWhereCond: strWhereCond);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//通过WebService执行IsExistRecord,返回的事件函数,可能需要处理执行错误。");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                         clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//可能发生比较严重的错误。例如：WebService的地址不正确、语法不正确等。");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: objResponseData.faultString, vcObj: vcParent);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//通过WebService执行IsExistRecord,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(returnBool: Bool, strClassName: String)",
               clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (returnBool == false)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.AddNewRecord(obj{0}EN: obj{0}EN);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"关键字为‘\\(obj{0}EN.{1})’的记录已经存在,不能再添加!\"",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//通过WebService执行AddNewRecord,返回的事件函数,可能需要处理执行错误。");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//可能发生比较严重的错误。例如：WebService的地址不正确、语法不正确等。");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: objResponseData.faultString, vcObj: vcParent);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//通过WebService执行AddNewRecord,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(returnBool: Bool, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (returnBool == true)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "let strInfo : String = \"添加记录成功!\"");
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "let strInfo : String = \"添加记录不成功!\"");
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }

        public string Gen_Controller_Swift4_btnAddNewRecord4GetMaxStrId_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 添加新记录");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.Append("\r\n" + "@IBAction func btnAddNewRecord4GetMaxStrId_Click(_ sender: Any) {");
            strCodeForCs.Append("\r\n" + "let iobjAddNewRecord4GetMaxStrId : iclsAddNewRecord4GetMaxStrId = iclsAddNewRecord4GetMaxStrId(pvcParent: self);");
            strCodeForCs.Append("\r\n" + "iobjAddNewRecord4GetMaxStrId.main();");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "class iclsAddNewRecord4GetMaxStrId : NSObject, clsTableObjWS4ControllerDelegate");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const vcParent : UIViewController;");
            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "init(pvcParent : UIViewController)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "vcParent = pvcParent;");
            strCodeForCs.Append("\r\n" + "super.init();");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "func main()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
           objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.GetMaxStrId();",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "//通过WebService执行GetMaxStrId,返回的事件函数,可能需要处理执行错误。");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//可能发生比较严重的错误。例如：WebService的地址不正确、语法不正确等。");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: objResponseData.faultString, vcObj: vcParent);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//通过WebService执行GetMaxStrId,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(returnString: String, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                if (objField.FieldTypeId == enumFieldType.KeyField_02)
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = returnString;",
                    objPrjTabENEx.TabName,
                    objField.ObjFieldTabENEx.FldName);
                }
                else
                {

                    string strTemp = SetProperty4DefaultValue_Swift4(objField);
                    strCodeForCs.Append(strTemp);
                    //if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                    //{
                    //    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = \"{2}\";",
                    //       objPrjTabENEx.TabName,
                    //       objField.ObjFieldTabENEx.FldName,
                    //       objField.ObjFieldTabENEx.DefaultValue4Test_Swift);
                    //}
                    //else
                    //{
                    //    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                    //          objPrjTabENEx.TabName,
                    //          objField.ObjFieldTabENEx.FldName,
                    //          objField.ObjFieldTabENEx.DefaultValue4Test_Swift);
                    //}
                }
            }
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "let strWhereCond : String = \"{1} = '\\(obj{0}EN.{1})'\";",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.IsExistRecord(strWhereCond: strWhereCond);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//通过WebService执行IsExistRecord,返回的事件函数,可能需要处理执行错误。");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//可能发生比较严重的错误。例如：WebService的地址不正确、语法不正确等。");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: objResponseData.faultString, vcObj: vcParent);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//通过WebService执行IsExistRecord,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(returnBool: Bool, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (returnBool == false)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.AddNewRecord(obj{0}EN: obj{0}EN);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"关键字为‘\\(obj{0}EN.{1})’的记录已经存在,不能再添加!\"",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//通过WebService执行AddNewRecord,返回的事件函数,可能需要处理执行错误。");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//可能发生比较严重的错误。例如：WebService的地址不正确、语法不正确等。");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: objResponseData.faultString, vcObj: vcParent);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//通过WebService执行AddNewRecord,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(returnBool: Bool, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (returnBool == true)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "let strInfo : String = \"添加记录成功!\"");
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "let strInfo : String = \"添加记录不成功!\"");
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }

        public string Gen_Controller_Swift4_btnGetMaxStrId_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 获取当前表关键字值的最大值,再加1,避免重复");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.Append("\r\n" + "@IBAction func btnGetMaxStrId_Click(_ sender: Any) {");
            strCodeForCs.Append("\r\n" + "let iobjGetMaxStrId : iclsGetMaxStrId = iclsGetMaxStrId(pvcParent: self);");
            strCodeForCs.Append("\r\n" + "iobjGetMaxStrId.main();");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "class iclsGetMaxStrId : NSObject, clsTableObjWS4ControllerDelegate");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const vcParent : UIViewController;");
            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "init(pvcParent : UIViewController)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "vcParent = pvcParent;");
            strCodeForCs.Append("\r\n" + "super.init();");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "func main()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
           objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.GetMaxStrId();",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "//通过WebService执行GetMaxStrId,返回的事件函数,可能需要处理执行错误。");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//可能发生比较严重的错误。例如：WebService的地址不正确、语法不正确等。");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: objResponseData.faultString, vcObj: vcParent);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//通过WebService执行GetMaxStrId,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(returnString: String, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (returnString == \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"获取表{0}的最大关键字为空,不成功,请检查!\"",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"获取表{0}的最大关键字为：\\(returnString)!\"",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }

        public string Gen_Controller_Swift4_btnGetMaxStrIdByPrefix_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.Append("\r\n" + "@IBAction func btnGetMaxStrIdByPrefix_Click(_ sender: Any) {");
            strCodeForCs.Append("\r\n" + "let iobjGetMaxStrIdByPrefix : iclsGetMaxStrIdByPrefix = iclsGetMaxStrIdByPrefix(pvcParent: self);");
            strCodeForCs.Append("\r\n" + "iobjGetMaxStrIdByPrefix.main();");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "class iclsGetMaxStrIdByPrefix : NSObject, clsTableObjWS4ControllerDelegate");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const vcParent : UIViewController;");
            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "init(pvcParent : UIViewController)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "vcParent = pvcParent;");
            strCodeForCs.Append("\r\n" + "super.init();");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "func main()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
           objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "let strPrefix : String = \"2\";");
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.GetMaxStrIdByPrefix(strPrefix: strPrefix);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "//通过WebService执行GetMaxStrIdByPrefix,返回的事件函数,可能需要处理执行错误。");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrIdByPrefix,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//可能发生比较严重的错误。例如：WebService的地址不正确、语法不正确等。");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: objResponseData.faultString, vcObj: vcParent);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//通过WebService执行GetMaxStrIdByPrefix,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(returnString: String, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrIdByPrefix,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (returnString == \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"获取表{0}的最大关键字为空,不成功,请检查!\"",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"获取表{0}的最大关键字为：\\(returnString)!\"",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 继承Runnable类必须实现的【run】函数
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Swift4_AddNewRecord()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 添加新记录");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的对象</param>",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.AppendFormat("\r\n" + "public func AddNewRecord(obj{0}EN : cls{0}EN)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "let values :  Dictionary < String, String > = Dictionary<String, String>();");
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS : cls{0}WS = cls{0}WS(strMethod: \"AddNewRecordByJSON\",",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "mapParam: values,");
            strCodeForCs.AppendFormat("\r\n" + "pobj{0}EN: obj{0}EN);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "queue.addOperation(obj{0}WS);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "theTimer = Timer.scheduledTimer(timeInterval: 0.1, target: self, selector: #selector(IsFinished4WebService), userInfo: nil, repeats: true);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 继承Runnable类必须实现的【run】
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Swift4_UpdateRecord()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 修改记录");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要修改的对象</param>",
    objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.AppendFormat("\r\n" + "public func UpdateRecord(obj{0}EN : cls{0}EN)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "let values :  Dictionary < String, String > = Dictionary<String, String>();");

            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS : cls{0}WS = cls{0}WS(strMethod: \"UpdateRecordByJSON\",",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "mapParam: values,");
            strCodeForCs.AppendFormat("\r\n" + "pobj{0}EN: obj{0}EN);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "queue.addOperation(obj{0}WS);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "theTimer = Timer.scheduledTimer(timeInterval: 0.1, target: self, selector: #selector(IsFinished4WebService), userInfo: nil, repeats: true);");
            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }

        public string Gen_Controller_Swift4_btnUpdateRecord_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 修改记录");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\n" + "@IBAction func btnUpdateRecord_Click(_ sender: Any) {");
            strCodeForCs.Append("\r\n" + "let iobjUpdateRecord : iclsUpdateRecord = iclsUpdateRecord(pvcParent: self);");
            strCodeForCs.Append("\r\n" + "iobjUpdateRecord.main();");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "class iclsUpdateRecord : NSObject, clsTableObjWS4ControllerDelegate");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const vcParent : UIViewController;");
            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "init(pvcParent : UIViewController)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "vcParent = pvcParent;");
            strCodeForCs.Append("\r\n" + "super.init();");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "func main()");
            strCodeForCs.Append("\r\n" + "{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                string strTemp = SetProperty4DefaultValue_Swift4(objField);
                strCodeForCs.Append(strTemp);

                //if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                //{
                //    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = \"{2}\";",
                //       objPrjTabENEx.TabName,
                //       objField.ObjFieldTabENEx.FldName,
                //       objField.ObjFieldTabENEx.DefaultValue4Test_Swift);
                //}
                //else
                //{
                //    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                //          objPrjTabENEx.TabName,
                //          objField.ObjFieldTabENEx.FldName,
                //          objField.ObjFieldTabENEx.DefaultValue4Test_Swift);
                //}
            }
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.UpdateRecord(obj{0}EN: obj{0}EN);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//通过WebService执行UpdateRecord,返回的事件函数,可能需要处理执行错误。");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conUpdateRecordByJSON,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//可能发生比较严重的错误。例如：WebService的地址不正确、语法不正确等。");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: objResponseData.faultString, vcObj: vcParent);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//通过WebService执行UpdateRecord,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(returnBool: Bool, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conUpdateRecordByJSON,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (returnBool == true)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "let strInfo : String = \"修改记录成功!\"");
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "let strInfo : String = \"修改记录不成功!\"");
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

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
                //Type t = typeof(WS_AccessHigh4Swift4);
                //MethodInfo mt = t.GetMethod(strFuncName, BindingFlags.Instance | BindingFlags.Public);

                //if (mt == null)
                //{
                //    string strMsg = string.Format("在类中没有相应的函数:{0}.(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                //    throw new Exception(strMsg);
                //}
                //else
                //{
                //    //                string str = (string)mt.Invoke(null, new object[] { "1234567890123"    });
                //    if (mt.GetParameters().Length == 0)
                //    {
                //        strCode = (string)mt.Invoke(this, null);
                //    }
                //    else if (mt.GetParameters().Length == 1)
                //    {
                //        strCode = (string)mt.Invoke(this, new object[] { objvFunction4GeneCodeEN });
                //    }
                //    //Console.WriteLine(str);
                //}

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
            this.ClsName = string.Format("cls{0}WS4Controller", objPrjTabENEx.TabName);
            objPrjTabENEx.ClsName = this.ClsName;
        }
    }
}
