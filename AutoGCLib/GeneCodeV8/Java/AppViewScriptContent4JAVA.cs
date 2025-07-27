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
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Web.UI.WebControls;
using TzCommWebServerCtrlLib;

namespace AutoGCLib
{
    /// <summary>
    /// 自动生成界面控制层的代码类(View of Mvc)
    /// </summary>
    public class AppViewScriptContent4JAVA : clsGeneCodeBase4View
    {
        private List<string> arrDdlBindTableLst = null;
       

        //		private objViewInfoENEx.FileName;		//生成的文件名；
        private List<AndroidControlEx> arrCtrlLst4List = null;//列表区域的控件集合
        private List<AndroidControlEx> arrCtrlLst4ListView = null;//列表区域的控件集合
        private List<AndroidControlEx> arrCtrlLst4Edit = null;//编辑区域的控件集合
        private List<AndroidControlEx> arrCtrlLst4Query = null;//查询区域的控件集合
        #region 构造函数
        public AppViewScriptContent4JAVA()
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            InitPageSetup();
        }
        public AppViewScriptContent4JAVA(string strViewId)
       : base( strViewId, "", "")
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            InitPageSetup();
        }
        public AppViewScriptContent4JAVA( string strViewId, string strPrjDataBaseId, string strPrjId)
        : base(strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            InitPageSetup();
        }
        /// <summary>
        /// 初始化页面设置
        /// </summary>
        public void InitPageSetup()
        {
            //intZIndex = 100;        ///控件焦点序号
            //intCurrLeft = 10;  ///控件的左边空;
            //intCurrTop = 10;
        }
        #endregion

      
     
        public string A_GenAppViewUC_QryScript(clsViewInfoENEx objViewInfoENEx, ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            //''该功能主要生成与表相关的控件代码,包括两个文件,;
            //一个是控件的界面文件, ;
            //另一个与之相关的界面类文件;
            //让用户设置属性;
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;

            objViewInfoENEx.WebUserCtlFName = objViewInfoENEx.FolderName + "uc_" + objViewInfoENEx.TabName + "_query.xml";
            objViewInfoENEx.FileName = objViewInfoENEx.WebUserCtlFName;
            objViewInfoENEx.ClsName = objViewInfoENEx.WebUserCtlFName;

            strRe_ClsName = objViewInfoENEx.WebUserCtlFName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebUserCtlFName.ToLower());
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objViewInfoENEx.PrjId); //
            try
            {
                ///生成插入记录的界面代码;
                ///      strCodeForCs.Append("\r\n" + "///生成与表相关的控件界面层代码");
                ///      

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
                objAndroidConstraintLayoutENEx.CtrlId = "clQuery";
                objAndroidConstraintLayoutENEx.context = string.Format("{0}.L7_UI.{1}.ac{2}_QUDI",
                    objProject.JavaPackageName, objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.TabName_In);
                //标题：查询条件
                AndroidTextViewEx objAndroidTextViewENEx_Title = new AndroidTextViewEx();
                objAndroidTextViewENEx_Title.CtrlId = "lblQueryTitle_q";
                objAndroidTextViewENEx_Title.Text = "查询条件";
                objAndroidTextViewENEx_Title.layout_width = "wrap_content";
                objAndroidTextViewENEx_Title.layout_height = "wrap_content";
                objAndroidTextViewENEx_Title.layout_marginTop = 8;

                objAndroidTextViewENEx_Title.layout_constraintStart_toStartOf = "parent";
                objAndroidTextViewENEx_Title.layout_constraintTop_toTopOf = "parent";
                objAndroidConstraintLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidTextViewENEx_Title);
                bool bolIsFirstField = true;//是否是第一个参数
                AndroidTextViewEx objAndroidTextViewENEx_Last = null;
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    AndroidTextViewEx objAndroidTextViewENEx = clsAndroidControlBLEx.GetAndroidTextViewObjByQryFld(objQryRegionFldsEx);
                    AndroidControlEx objAndroidControlENEx = clsAndroidControlBLEx.GetAndroidControlObjByQryFld(objQryRegionFldsEx);
                    objAndroidTextViewENEx.layout_constraintStart_toStartOf = "parent";
                    if (bolIsFirstField == true)
                    {
                        objAndroidTextViewENEx.layout_marginTop = 8;
                        objAndroidTextViewENEx.layout_constraintTop_toBottomOf = string.Format("@+id/lblQueryTitle_q", "parent");

                        objAndroidControlENEx.layout_marginTop = 8;
                        objAndroidControlENEx.layout_marginLeft = 8;
                        objAndroidControlENEx.layout_constraintLeft_toRightOf = string.Format("@+id/{0}", objAndroidTextViewENEx.CtrlId);
                        objAndroidControlENEx.layout_constraintTop_toBottomOf = string.Format("@+id/lblQueryTitle_q");
                        bolIsFirstField = false;
                    }
                    else
                    {
                        objAndroidTextViewENEx.layout_marginTop = 16 + 8;
                        objAndroidTextViewENEx.layout_constraintTop_toBottomOf = string.Format("@+id/{0}",
                            objAndroidTextViewENEx_Last.CtrlId);

                        objAndroidControlENEx.layout_marginTop = 16 + 8;
                        objAndroidControlENEx.layout_marginLeft = 8;
                        objAndroidControlENEx.layout_constraintTop_toBottomOf = string.Format("@+id/{0}",
                            objAndroidTextViewENEx_Last.CtrlId);
                        objAndroidControlENEx.layout_constraintLeft_toRightOf = string.Format("@+id/{0}",
                            objAndroidTextViewENEx.CtrlId);
                    }
                    objAndroidTextViewENEx_Last = objAndroidTextViewENEx;
                    objAndroidConstraintLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidTextViewENEx);
                    objAndroidConstraintLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidControlENEx);

                    switch (objQryRegionFldsEx.objCtlType.CtlTypeName)
                    {
                        case "CheckBox":
                            AndroidCheckBoxEx objAndroidCheckBoxENEx = (AndroidCheckBoxEx)clsAndroidControlBLEx.GetAndroidControlObjByQryFld(objQryRegionFldsEx);

                            break;
                        case "TextBox":
                            AndroidEditTextEx objAndroidEditTextENEx = (AndroidEditTextEx)clsAndroidControlBLEx.GetAndroidControlObjByQryFld(objQryRegionFldsEx);

                            break;
                        case "DropDownList":
                            AndroidSpinnerEx objAndroidSpinnerENEx = (AndroidSpinnerEx)clsAndroidControlBLEx.GetAndroidControlObjByQryFld(objQryRegionFldsEx);

                            break;

                        default:
                            string strMsg = string.Format("查询区域字段转换成安卓控件时,类型：[{0}]没有处理!({1})",
                           objQryRegionFldsEx.objCtlType.CtlTypeName, clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);
                    }

                }
                //            < Button
                //android: id = "@+id/btnQuery"
                //android: layout_width = "wrap_content"
                //android: layout_height = "wrap_content"
                //android: layout_marginTop = "10dp"
                //android: onClick = "btnQuery_Click"
                //android: text = "确定"
                //android: textSize = "12sp"
                //android: minHeight = "35dp"
                //app: layout_constraintStart_toStartOf = "parent"
                //app: layout_constraintTop_toBottomOf = "@+id/lbl{0}Name_q" />
                {
                    AndroidButtonEx objAndroidButtonENEx = new AndroidButtonEx();
                    objAndroidButtonENEx.CtrlId = string.Format("btnQuery");
                    objAndroidButtonENEx.OnClick = string.Format("btnQuery_Click");
                    objAndroidButtonENEx.Text = "查询";
                    objAndroidButtonENEx.layout_width = "wrap_content";
                    objAndroidButtonENEx.layout_height = "wrap_content";
                    objAndroidButtonENEx.layout_marginTop = 10;

                    objAndroidButtonENEx.mTextSize = "12sp";
                    objAndroidButtonENEx.minHeight = "35dp";
                    objAndroidButtonENEx.layout_constraintStart_toStartOf = "parent";
                    if (objAndroidTextViewENEx_Last == null)
                    {
                        objAndroidButtonENEx.layout_constraintTop_toTopOf = "parent";
                    }
                    else
                    {
                        objAndroidButtonENEx.layout_constraintTop_toBottomOf = string.Format("@+id/{0}", objAndroidTextViewENEx_Last.CtrlId);
                    }
                    //objAndroidTabHostENEx.arrSubAndroidControlLst2.Add(objAndroidLinearLayoutENEx);
                    objAndroidConstraintLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidButtonENEx);
                }
                {
                    AndroidButtonEx objAndroidButtonENEx_Cancel = new AndroidButtonEx();
                    objAndroidButtonENEx_Cancel.CtrlId = string.Format("btnCancelQuery");
                    objAndroidButtonENEx_Cancel.OnClick = string.Format("btnCancelQuery_Click");
                    objAndroidButtonENEx_Cancel.Text = "取消查询";
                    objAndroidButtonENEx_Cancel.layout_width = "wrap_content";
                    objAndroidButtonENEx_Cancel.layout_height = "wrap_content";
                    objAndroidButtonENEx_Cancel.layout_marginTop = 10;

                    objAndroidButtonENEx_Cancel.mTextSize = "12sp";
                    objAndroidButtonENEx_Cancel.minHeight = "35dp";
                    objAndroidButtonENEx_Cancel.layout_constraintLeft_toRightOf = "@+id/btnQuery";
                    if (objAndroidTextViewENEx_Last == null)
                    {
                        objAndroidButtonENEx_Cancel.layout_constraintTop_toTopOf = "parent";
                    }
                    else
                    {
                        objAndroidButtonENEx_Cancel.layout_constraintTop_toBottomOf = string.Format("@+id/{0}", objAndroidTextViewENEx_Last.CtrlId);
                    }
                    //objAndroidTabHostENEx.arrSubAndroidControlLst2.Add(objAndroidLinearLayoutENEx);
                    objAndroidConstraintLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidButtonENEx_Cancel);
                }
                //objAndroidConstraintLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidTextViewENEx);
                objAndroidConstraintLayoutENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }

            return strCodeForCs.ToString();
        }

        public string A_GenAppViewLvItemScript(clsViewInfoENEx objViewInfoENEx, string strTabName, ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            //''该功能主要生成与表相关的控件代码,包括两个文件,;
            //一个是控件的界面文件, ;
            //另一个与之相关的界面类文件;
            //让用户设置属性;
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;

            objViewInfoENEx.WebUserCtlFName = objViewInfoENEx.FolderName + "uc_" + strTabName + "_lvitem.xml";
            objViewInfoENEx.FileName = objViewInfoENEx.WebUserCtlFName;
            objViewInfoENEx.ClsName = objViewInfoENEx.WebUserCtlFName;

            strRe_ClsName = objViewInfoENEx.WebUserCtlFName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebUserCtlFName.ToLower());
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objViewInfoENEx.PrjId); //
            try
            {
                ///生成插入记录的界面代码;
                ///      strCodeForCs.Append("\r\n" + "///生成与表相关的控件界面层代码");
                ///      

                strCodeForCs.Append("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                AndroidLinearLayoutEx objAndroidLinearLayoutENEx = new AndroidLinearLayoutEx();
                objAndroidLinearLayoutENEx.android = "http://schemas.android.com/apk/res/android";
                objAndroidLinearLayoutENEx.layout_width = "match_parent";
                objAndroidLinearLayoutENEx.layout_height = "match_parent";
                //objAndroidLinearLayoutENEx.showIn = "@layout/ac_invoke_web_srv";
                //objAndroidLinearLayoutENEx.context = "com.taishsoft.TechnicalResearch.InvokeWebSrv";
                objAndroidLinearLayoutENEx.layout_behavior = "@string/appbar_scrolling_view_behavior";
                objAndroidLinearLayoutENEx.CtrlId = string.Format("llLvItem{0}", objViewInfoENEx.TabName_Out);
                //objAndroidLinearLayoutENEx.context = string.Format("{0}.L7_UI.{1}.ac{2}_QUDI",
                    //objProject.JavaPackageName, objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.TabName_In);
                //标题：查询条件
                //AndroidTextViewEx objAndroidTextViewENEx_Title = new AndroidTextViewEx();
                //objAndroidTextViewENEx_Title.CtrlId = "lblQueryTitle_q";
                //objAndroidTextViewENEx_Title.Text = "查询条件";
                //objAndroidTextViewENEx_Title.layout_width = "wrap_content";
                //objAndroidTextViewENEx_Title.layout_height = "wrap_content";
                //objAndroidTextViewENEx_Title.layout_marginTop = 8;

                //objAndroidTextViewENEx_Title.layout_constraintStart_toStartOf = "parent";
                //objAndroidTextViewENEx_Title.layout_constraintTop_toTopOf = "parent";



                //objAndroidLinearLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidTextViewENEx_Title);

                
                    AndroidCheckBoxEx objAndroidCheckBoxENEx_p = new AndroidCheckBoxEx();
                objAndroidCheckBoxENEx_p.CtrlId = string.Format("chkCheckRec");

                objAndroidCheckBoxENEx_p.layout_width = "30dp";
                objAndroidCheckBoxENEx_p.layout_height = "wrap_content";
                objAndroidCheckBoxENEx_p.layout_marginTop = 1;
                //        android: layout_centerVertical = "true"
                //android: focusable = "false"
                objAndroidCheckBoxENEx_p.scaleX = "0.6";
                objAndroidCheckBoxENEx_p.scaleY = "0.6";
                objAndroidCheckBoxENEx_p.Text = "";
//                objAndroidCheckBoxENEx.objDGRegionFldsENEx = objDGRegionFldsEx;
                objAndroidLinearLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidCheckBoxENEx_p);




                bool bolIsFirstField = true;//是否是第一个参数
                AndroidTextViewEx objAndroidTextViewENEx_Last = null;
                foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
                {
                    AndroidTextViewEx objAndroidTextViewENEx = clsAndroidControlBLEx.GetAndroidTextViewObjByDGFld(objDGRegionFldsEx);
                    //AndroidControlEx objAndroidControlENEx = clsAndroidControlBLEx.GetAndroidControlObjByDGFld(objDGRegionFldsEx);
                    if (bolIsFirstField == true)
                    {
                        objAndroidTextViewENEx.layout_marginTop = 1;
                        //objAndroidTextViewENEx.layout_constraintTop_toBottomOf = string.Format("@+id/lblQueryTitle_q", "parent");

                        bolIsFirstField = false;
                    }
                    else
                    {
                        objAndroidTextViewENEx.layout_marginTop = 1;
                        //objAndroidTextViewENEx.layout_constraintTop_toBottomOf = string.Format("@+id/{0}",
                        //    objAndroidTextViewENEx_Last.CtrlId);

                    }
                    objAndroidTextViewENEx_Last = objAndroidTextViewENEx;
                    objAndroidLinearLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidTextViewENEx);

                   
                }
                //            < Button
                //android: id = "@+id/btnQuery"
                //android: layout_width = "wrap_content"
                //android: layout_height = "wrap_content"
                //android: layout_marginTop = "10dp"
                //android: onClick = "btnQuery_Click"
                //android: text = "确定"
                //android: textSize = "12sp"
                //android: minHeight = "35dp"
                //app: layout_constraintStart_toStartOf = "parent"
                //app: layout_constraintTop_toBottomOf = "@+id/lbl{0}Name_q" />
                AndroidButtonEx objAndroidButtonENEx = new AndroidButtonEx();
                objAndroidButtonENEx.CtrlId = string.Format("btnUpdate");
                objAndroidButtonENEx.Style = "btnStyle4InListView_W2";

                objAndroidButtonENEx.OnClick = string.Format("btnUpdate_Click");
                objAndroidButtonENEx.Text = "修改";
                //objAndroidButtonENEx.layout_width = "wrap_content";
                //objAndroidButtonENEx.layout_height = "wrap_content";
                objAndroidButtonENEx.layout_marginTop = 1;

                //objAndroidButtonENEx.mTextSize = "12sp";
                objAndroidButtonENEx.minHeight = "35dp";
                //objAndroidButtonENEx.layout_constraintStart_toStartOf = "parent";
               
                //objAndroidTabHostENEx.arrSubAndroidControlLst2.Add(objAndroidLinearLayoutENEx);
                objAndroidLinearLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidButtonENEx);
                //objAndroidLinearLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidTextViewENEx);
                objAndroidLinearLayoutENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }

            return strCodeForCs.ToString();
        }

        public string A_GenAppViewLvHeadScript(clsViewInfoENEx objViewInfoENEx, string strTabName, ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            //''该功能主要生成与表相关的控件代码,包括两个文件,;
            //一个是控件的界面文件, ;
            //另一个与之相关的界面类文件;
            //让用户设置属性;
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;

            objViewInfoENEx.WebUserCtlFName = objViewInfoENEx.FolderName + "uc_" + strTabName + "_lvhead.xml";
            objViewInfoENEx.FileName = objViewInfoENEx.WebUserCtlFName;
            objViewInfoENEx.ClsName = objViewInfoENEx.WebUserCtlFName;

            strRe_ClsName = objViewInfoENEx.WebUserCtlFName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebUserCtlFName.ToLower());
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objViewInfoENEx.PrjId); //
            try
            {
                ///生成插入记录的界面代码;
                ///      strCodeForCs.Append("\r\n" + "///生成与表相关的控件界面层代码");
                ///      

                strCodeForCs.Append("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                AndroidLinearLayoutEx objAndroidLinearLayoutENEx = new AndroidLinearLayoutEx();
                objAndroidLinearLayoutENEx.android = "http://schemas.android.com/apk/res/android";
                objAndroidLinearLayoutENEx.layout_width = "match_parent";
                objAndroidLinearLayoutENEx.layout_height = "match_parent";
                //objAndroidLinearLayoutENEx.showIn = "@layout/ac_invoke_web_srv";
                //objAndroidLinearLayoutENEx.context = "com.taishsoft.TechnicalResearch.InvokeWebSrv";
                objAndroidLinearLayoutENEx.layout_behavior = "@string/appbar_scrolling_view_behavior";
                objAndroidLinearLayoutENEx.CtrlId = string.Format("llLvHead{0}", objViewInfoENEx.TabName_Out);
                //objAndroidLinearLayoutENEx.context = string.Format("{0}.L7_UI.{1}.ac{2}_QUDI",
                //objProject.JavaPackageName, objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.TabName_In);
                //标题：查询条件
                //AndroidTextViewEx objAndroidTextViewENEx_Title = new AndroidTextViewEx();
                //objAndroidTextViewENEx_Title.CtrlId = "lblQueryTitle_q";
                //objAndroidTextViewENEx_Title.Text = "查询条件";
                //objAndroidTextViewENEx_Title.layout_width = "wrap_content";
                //objAndroidTextViewENEx_Title.layout_height = "wrap_content";
                //objAndroidTextViewENEx_Title.layout_marginTop = 8;

                //objAndroidTextViewENEx_Title.layout_constraintStart_toStartOf = "parent";
                //objAndroidTextViewENEx_Title.layout_constraintTop_toTopOf = "parent";



                //objAndroidLinearLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidTextViewENEx_Title);


                AndroidCheckBoxEx objAndroidCheckBoxENEx_p = new AndroidCheckBoxEx();
                objAndroidCheckBoxENEx_p.CtrlId = string.Format("chkCheckRec");

                objAndroidCheckBoxENEx_p.layout_width = "30dp";
                objAndroidCheckBoxENEx_p.layout_height = "wrap_content";
                objAndroidCheckBoxENEx_p.layout_marginTop = 1;
                //        android: layout_centerVertical = "true"
                //android: focusable = "false"
                objAndroidCheckBoxENEx_p.scaleX = "0.6";
                objAndroidCheckBoxENEx_p.scaleY = "0.6";
                objAndroidCheckBoxENEx_p.Text = "";
                //                objAndroidCheckBoxENEx.objDGRegionFldsENEx = objDGRegionFldsEx;
                objAndroidLinearLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidCheckBoxENEx_p);




                bool bolIsFirstField = true;//是否是第一个参数
                AndroidTextViewEx objAndroidTextViewENEx_Last = null;
                foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
                {
                    AndroidTextViewEx objAndroidTextViewENEx = clsAndroidControlBLEx.GetAndroidTextViewObjByDGFld(objDGRegionFldsEx);
                    //AndroidControlEx objAndroidControlENEx = clsAndroidControlBLEx.GetAndroidControlObjByDGFld(objDGRegionFldsEx);
                    if (bolIsFirstField == true)
                    {
                        objAndroidTextViewENEx.layout_marginTop = 1;
                        //objAndroidTextViewENEx.layout_constraintTop_toBottomOf = string.Format("@+id/lblQueryTitle_q", "parent");

                        bolIsFirstField = false;
                    }
                    else
                    {
                        objAndroidTextViewENEx.layout_marginTop = 1;
                        //objAndroidTextViewENEx.layout_constraintTop_toBottomOf = string.Format("@+id/{0}",
                        //    objAndroidTextViewENEx_Last.CtrlId);

                    }
                    objAndroidTextViewENEx_Last = objAndroidTextViewENEx;
                    objAndroidLinearLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidTextViewENEx);
                }
             
                AndroidTextViewEx objAndroidTextViewENEx_Update = new AndroidTextViewEx();
                objAndroidTextViewENEx_Update.CtrlId = string.Format("tvUpdate");
                objAndroidTextViewENEx_Update.Style = "tvStyle4InListView_W2";

                objAndroidTextViewENEx_Update.Text = "修改";
                //objAndroidButtonENEx.layout_width = "wrap_content";
                //objAndroidButtonENEx.layout_height = "wrap_content";
                objAndroidTextViewENEx_Update.layout_marginTop = 1;

                //objAndroidButtonENEx.mTextSize = "12sp";
                objAndroidTextViewENEx_Update.minHeight = "35dp";
                //objAndroidButtonENEx.layout_constraintStart_toStartOf = "parent";

                //objAndroidTabHostENEx.arrSubAndroidControlLst2.Add(objAndroidLinearLayoutENEx);
                objAndroidLinearLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidTextViewENEx_Update);
                //objAndroidLinearLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidTextViewENEx);
                objAndroidLinearLayoutENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }

            return strCodeForCs.ToString();
        }

        public string A_GenAppViewUCEdtScript(clsViewInfoENEx objViewInfoENEx, ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            //''该功能主要生成与表相关的控件代码,包括两个文件,;
            //一个是控件的界面文件, ;
            //另一个与之相关的界面类文件;
            //让用户设置属性;
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;

            objViewInfoENEx.WebUserCtlFName = objViewInfoENEx.FolderName + "uc_" + objViewInfoENEx.TabName + "_edit.xml";
            objViewInfoENEx.FileName = objViewInfoENEx.WebUserCtlFName;
            objViewInfoENEx.ClsName = objViewInfoENEx.WebUserCtlFName;

            strRe_ClsName = objViewInfoENEx.WebUserCtlFName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebUserCtlFName.ToLower());
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objViewInfoENEx.PrjId); //
            try
            {
                ///生成插入记录的界面代码;
                ///      strCodeForCs.Append("\r\n" + "///生成与表相关的控件界面层代码");
                ///      

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
                objAndroidConstraintLayoutENEx.CtrlId = "clEdit";
                objAndroidConstraintLayoutENEx.context = string.Format("{0}.L7_UI.{1}.ac{2}_QUDI",
                    objProject.JavaPackageName, objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.TabName_In);
                //标题：查询条件
                AndroidTextViewEx objAndroidTextViewENEx_Title = new AndroidTextViewEx();
                objAndroidTextViewENEx_Title.CtrlId = "lblEditTitle";
                objAndroidTextViewENEx_Title.Text = "编辑区域";
                objAndroidTextViewENEx_Title.layout_width = "wrap_content";
                objAndroidTextViewENEx_Title.layout_height = "wrap_content";
                objAndroidTextViewENEx_Title.layout_marginTop = 8;

                objAndroidTextViewENEx_Title.layout_constraintStart_toStartOf = "parent";
                objAndroidTextViewENEx_Title.layout_constraintTop_toTopOf = "parent";
                objAndroidConstraintLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidTextViewENEx_Title);
                bool bolIsFirstField = true;//是否是第一个参数
                AndroidTextViewEx objAndroidTextViewENEx_Last = null;
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    AndroidTextViewEx objAndroidTextViewENEx = clsAndroidControlBLEx.GetAndroidTextViewObjByEditFld(objEditRegionFldsEx);
                    AndroidControlEx objAndroidControlENEx = clsAndroidControlBLEx.GetAndroidControlObjByEditFld(objEditRegionFldsEx);
                    objAndroidTextViewENEx.layout_constraintStart_toStartOf = "parent";
                    if (bolIsFirstField == true)
                    {
                        objAndroidTextViewENEx.layout_marginTop = 8;
                        objAndroidTextViewENEx.layout_constraintTop_toBottomOf = string.Format("@+id/lblEditTitle", "parent");

                        objAndroidControlENEx.layout_marginTop = 8;
                        objAndroidControlENEx.layout_marginLeft = 8;
                        objAndroidControlENEx.layout_constraintLeft_toRightOf = string.Format("@+id/{0}", objAndroidTextViewENEx.CtrlId);
                        objAndroidControlENEx.layout_constraintTop_toBottomOf = string.Format("@+id/lblEditTitle");
                        bolIsFirstField = false;
                    }
                    else
                    {
                        objAndroidTextViewENEx.layout_marginTop = 16 + 8;
                        objAndroidTextViewENEx.layout_constraintTop_toBottomOf = string.Format("@+id/{0}",
                            objAndroidTextViewENEx_Last.CtrlId);

                        objAndroidControlENEx.layout_marginTop = 16 + 8;
                        objAndroidControlENEx.layout_marginLeft = 8;
                        objAndroidControlENEx.layout_constraintTop_toBottomOf = string.Format("@+id/{0}",
                            objAndroidTextViewENEx_Last.CtrlId);
                        objAndroidControlENEx.layout_constraintLeft_toRightOf = string.Format("@+id/{0}",
                            objAndroidTextViewENEx.CtrlId);
                    }
                    objAndroidTextViewENEx_Last = objAndroidTextViewENEx;
                    objAndroidConstraintLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidTextViewENEx);
                    objAndroidConstraintLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidControlENEx);

                    switch (objEditRegionFldsEx.objCtlType.CtlTypeName)
                    {
                        case "CheckBox":
                            AndroidCheckBoxEx objAndroidCheckBoxENEx = (AndroidCheckBoxEx)clsAndroidControlBLEx.GetAndroidControlObjByEditFld(objEditRegionFldsEx);

                            break;
                        case "TextBox":
                            AndroidEditTextEx objAndroidEditTextENEx = (AndroidEditTextEx)clsAndroidControlBLEx.GetAndroidControlObjByEditFld(objEditRegionFldsEx);

                            break;
                        case "DropDownList":
                            AndroidSpinnerEx objAndroidSpinnerENEx = (AndroidSpinnerEx)clsAndroidControlBLEx.GetAndroidControlObjByEditFld(objEditRegionFldsEx);

                            break;

                        default:
                            string strMsg = string.Format("查询区域字段转换成安卓控件时,类型：[{0}]没有处理!({1})",
                           objEditRegionFldsEx.objCtlType.CtlTypeName, clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);
                    }

                }
                //           < Button
                //android: id = "@+id/btnOkUpd"
                //android: layout_width = "wrap_content"
                //android: layout_height = "wrap_content"
                //android: layout_marginTop = "10dp"
                //android: onClick = "btnOkUpd_Click"
                //android: text = "确定"
                //android: textSize = "12sp"
                //android: minHeight = "35dp"
                //app: layout_constraintStart_toStartOf = "parent"
                //app: layout_constraintTop_toBottomOf = "@+id/lblMemo" />
                AndroidButtonEx objAndroidButtonENEx = new AndroidButtonEx();
                objAndroidButtonENEx.CtrlId = string.Format("btnOkUpd");
                objAndroidButtonENEx.OnClick = string.Format("btnOkUpd_Click");
                objAndroidButtonENEx.Text = "确认编辑";
                objAndroidButtonENEx.layout_width = "wrap_content";
                objAndroidButtonENEx.layout_height = "wrap_content";
                objAndroidButtonENEx.layout_marginTop = 10;

                objAndroidButtonENEx.mTextSize = "12sp";
                objAndroidButtonENEx.minHeight = "35dp";
                objAndroidButtonENEx.layout_constraintStart_toStartOf = "parent";
                if (objAndroidTextViewENEx_Last == null)
                {
                    objAndroidButtonENEx.layout_constraintTop_toTopOf = "parent";
                }
                else
                {
                    objAndroidButtonENEx.layout_constraintTop_toBottomOf = string.Format("@+id/{0}", objAndroidTextViewENEx_Last.CtrlId);
                }
                //objAndroidTabHostENEx.arrSubAndroidControlLst2.Add(objAndroidLinearLayoutENEx);
                objAndroidConstraintLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidButtonENEx);
                AndroidButtonEx objAndroidButtonENEx_Cancel = new AndroidButtonEx();
                objAndroidButtonENEx_Cancel.CtrlId = string.Format("btnCancel");
                objAndroidButtonENEx_Cancel.OnClick = string.Format("btnCancel_Click");
                objAndroidButtonENEx_Cancel.Text = "放弃";
                objAndroidButtonENEx_Cancel.layout_width = "wrap_content";
                objAndroidButtonENEx_Cancel.layout_height = "wrap_content";
                objAndroidButtonENEx_Cancel.layout_marginTop = 10;

                objAndroidButtonENEx_Cancel.mTextSize = "12sp";
                objAndroidButtonENEx_Cancel.minHeight = "35dp";
                objAndroidButtonENEx_Cancel.layout_constraintLeft_toRightOf = "@+id/btnOkUpd";
                if (objAndroidTextViewENEx_Last == null)
                {
                    objAndroidButtonENEx_Cancel.layout_constraintTop_toTopOf = "parent";
                }
                else
                {
                    objAndroidButtonENEx_Cancel.layout_constraintTop_toBottomOf = string.Format("@+id/{0}", objAndroidTextViewENEx_Last.CtrlId);
                }
                //objAndroidTabHostENEx.arrSubAndroidControlLst2.Add(objAndroidLinearLayoutENEx);
                objAndroidConstraintLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidButtonENEx_Cancel);

                     

                 //objAndroidConstraintLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidTextViewENEx);
                 objAndroidConstraintLayoutENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }

            return strCodeForCs.ToString();
        }
        public string A_GenAppViewEdtScript(clsViewInfoENEx objViewInfoENEx, ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            //''该功能主要生成与表相关的控件代码,包括两个文件,;
            //一个是控件的界面文件, ;
            //另一个与之相关的界面类文件;
            //让用户设置属性;
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;

            objViewInfoENEx.WebUserCtlFName = objViewInfoENEx.FolderName + "ac_" + objViewInfoENEx.TabName + "_edit.xml";
            objViewInfoENEx.FileName = objViewInfoENEx.WebUserCtlFName;
            objViewInfoENEx.ClsName = objViewInfoENEx.WebUserCtlFName;

            strRe_ClsName = objViewInfoENEx.WebUserCtlFName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebUserCtlFName.ToLower());
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objViewInfoENEx.PrjId); //
            try
            {
                ///生成插入记录的界面代码;
                ///      strCodeForCs.Append("\r\n" + "///生成与表相关的控件界面层代码");
             
                strCodeForCs.Append("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                AndroidScrollViewEx objAndroidScrollViewENEx = new AndroidScrollViewEx();
                objAndroidScrollViewENEx.android = "http://schemas.android.com/apk/res/android";
                objAndroidScrollViewENEx.app = "http://schemas.android.com/apk/res-auto";
                objAndroidScrollViewENEx.tools = "http://schemas.android.com/tools";

                objAndroidScrollViewENEx.layout_width = "match_parent";
                objAndroidScrollViewENEx.layout_height = "match_parent";
                //objAndroidScrollViewENEx.showIn = "@layout/ac_invoke_web_srv";
                //objAndroidScrollViewENEx.context = "com.taishsoft.TechnicalResearch.InvokeWebSrv";
                objAndroidScrollViewENEx.layout_behavior = "@string/appbar_scrolling_view_behavior";
                objAndroidScrollViewENEx.CtrlId = "clEdit";
                objAndroidScrollViewENEx.context = string.Format("{0}.L7_UI.{1}.ac{2}_QUDI",
                    objProject.JavaPackageName, objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.TabName_In);

                AndroidLinearLayoutEx objAndroidLinearLayoutENEx = new AndroidLinearLayoutEx();
                objAndroidLinearLayoutENEx.android = "http://schemas.android.com/apk/res/android";
                objAndroidLinearLayoutENEx.layout_width = "match_parent";
                objAndroidLinearLayoutENEx.layout_height = "match_parent";
                //objAndroidLinearLayoutENEx.showIn = "@layout/ac_invoke_web_srv";
                //objAndroidLinearLayoutENEx.context = "com.taishsoft.TechnicalResearch.InvokeWebSrv";
                objAndroidLinearLayoutENEx.layout_behavior = "@string/appbar_scrolling_view_behavior";
                objAndroidLinearLayoutENEx.CtrlId = string.Format("llLvItem{0}", objViewInfoENEx.TabName_Out);
                objAndroidScrollViewENEx.arrSubAndroidControlLst2.Add(objAndroidLinearLayoutENEx);

                //标题行------------------------------
                {
                    AndroidRelativeLayoutEx objAndroidRelativeLayoutENEx = new AndroidRelativeLayoutEx();
                    objAndroidRelativeLayoutENEx.android = "http://schemas.android.com/apk/res/android";
                    objAndroidRelativeLayoutENEx.layout_width = "match_parent";
                    objAndroidRelativeLayoutENEx.layout_height = "match_parent";
                    //objAndroidRelativeLayoutENEx.showIn = "@layout/ac_invoke_web_srv";
                    //objAndroidRelativeLayoutENEx.context = "com.taishsoft.TechnicalResearch.InvokeWebSrv";
                    objAndroidRelativeLayoutENEx.layout_behavior = "@string/appbar_scrolling_view_behavior";
                    objAndroidRelativeLayoutENEx.CtrlId = string.Format("llLvItem{0}", objViewInfoENEx.TabName_Out);
                    objAndroidScrollViewENEx.arrSubAndroidControlLst2.Add(objAndroidRelativeLayoutENEx);

                    AndroidImageButtonEx objAndroidImageButtonENEx = new AndroidImageButtonEx();
                    objAndroidImageButtonENEx.CtrlId = string.Format("btnQuery");
                    objAndroidImageButtonENEx.OnClick = string.Format("btnQuery_Click");
                    objAndroidImageButtonENEx.Text = "查询";
                    objAndroidImageButtonENEx.layout_width = "wrap_content";
                    objAndroidImageButtonENEx.layout_height = "wrap_content";
                    objAndroidImageButtonENEx.layout_marginTop = 10;

                    objAndroidImageButtonENEx.mTextSize = "12sp";
                    objAndroidImageButtonENEx.minHeight = "35dp";
                    objAndroidImageButtonENEx.layout_constraintStart_toStartOf = "parent";

                    objAndroidImageButtonENEx.layout_constraintTop_toTopOf = "parent";
                    //objAndroidImageButtonENEx.layout_constraintTop_toBottomOf = string.Format("@+id/{0}", objAndroidTextViewENEx_Last.CtrlId);
                    //objAndroidTabHostENEx.arrSubAndroidControlLst2.Add(objAndroidLinearLayoutENEx);
                    objAndroidRelativeLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidImageButtonENEx);

                    AndroidTextViewEx objAndroidTextViewENEx_Title = new AndroidTextViewEx();
                    objAndroidTextViewENEx_Title.CtrlId = "lblEditTitle";
                    objAndroidTextViewENEx_Title.Text = "编辑区域";
                    objAndroidTextViewENEx_Title.layout_width = "wrap_content";
                    objAndroidTextViewENEx_Title.layout_height = "wrap_content";
                    objAndroidTextViewENEx_Title.layout_marginTop = 8;

                    objAndroidTextViewENEx_Title.layout_constraintStart_toStartOf = "parent";
                    objAndroidTextViewENEx_Title.layout_constraintTop_toTopOf = "parent";
                    objAndroidRelativeLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidTextViewENEx_Title);

                }
                //标题行===============================
                //编辑字段行---------------------------
                {
                    AndroidTableLayoutEx objAndroidTableLayoutENEx = new AndroidTableLayoutEx();
                    objAndroidTableLayoutENEx.android = "http://schemas.android.com/apk/res/android";
                    objAndroidTableLayoutENEx.layout_width = "match_parent";
                    objAndroidTableLayoutENEx.layout_height = "match_parent";
                    //objAndroidTableLayoutENEx.showIn = "@layout/ac_invoke_web_srv";
                    //objAndroidTableLayoutENEx.context = "com.taishsoft.TechnicalResearch.InvokeWebSrv";
                    objAndroidTableLayoutENEx.layout_behavior = "@string/appbar_scrolling_view_behavior";
                    objAndroidTableLayoutENEx.CtrlId = string.Format("llLvItem{0}", objViewInfoENEx.TabName_Out);
                    objAndroidScrollViewENEx.arrSubAndroidControlLst2.Add(objAndroidTableLayoutENEx);


                    //标题：查询条件

                    bool bolIsFirstField = true;//是否是第一个参数
                    AndroidTextViewEx objAndroidTextViewENEx_Last = null;


                    foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                    {
                        AndroidTableRowEx objAndroidTableRowENEx = new AndroidTableRowEx();
                        objAndroidTableRowENEx.android = "http://schemas.android.com/apk/res/android";
                        objAndroidTableRowENEx.layout_width = "match_parent";
                        objAndroidTableRowENEx.layout_height = "match_parent";
                        //objAndroidTableRowENEx.showIn = "@layout/ac_invoke_web_srv";
                        //objAndroidTableRowENEx.context = "com.taishsoft.TechnicalResearch.InvokeWebSrv";
                        objAndroidTableRowENEx.layout_behavior = "@string/appbar_scrolling_view_behavior";
                        objAndroidTableRowENEx.CtrlId = string.Format("llLvItem{0}", objViewInfoENEx.TabName_Out);
                        objAndroidTableLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidTableRowENEx);




                        AndroidTextViewEx objAndroidTextViewENEx = clsAndroidControlBLEx.GetAndroidTextViewObjByEditFld(objEditRegionFldsEx);
                        AndroidControlEx objAndroidControlENEx = clsAndroidControlBLEx.GetAndroidControlObjByEditFld(objEditRegionFldsEx);
                        objAndroidTextViewENEx.layout_constraintStart_toStartOf = "parent";
                        if (bolIsFirstField == true)
                        {
                            objAndroidTextViewENEx.layout_marginTop = 8;
                            objAndroidTextViewENEx.layout_constraintTop_toBottomOf = string.Format("@+id/lblEditTitle", "parent");

                            objAndroidControlENEx.layout_marginTop = 8;
                            objAndroidControlENEx.layout_marginLeft = 8;
                            objAndroidControlENEx.layout_constraintLeft_toRightOf = string.Format("@+id/{0}", objAndroidTextViewENEx.CtrlId);
                            objAndroidControlENEx.layout_constraintTop_toBottomOf = string.Format("@+id/lblEditTitle");
                            bolIsFirstField = false;
                        }
                        else
                        {
                            objAndroidTextViewENEx.layout_marginTop = 16 + 8;
                            objAndroidTextViewENEx.layout_constraintTop_toBottomOf = string.Format("@+id/{0}",
                                objAndroidTextViewENEx_Last.CtrlId);

                            objAndroidControlENEx.layout_marginTop = 16 + 8;
                            objAndroidControlENEx.layout_marginLeft = 8;
                            objAndroidControlENEx.layout_constraintTop_toBottomOf = string.Format("@+id/{0}",
                                objAndroidTextViewENEx_Last.CtrlId);
                            objAndroidControlENEx.layout_constraintLeft_toRightOf = string.Format("@+id/{0}",
                                objAndroidTextViewENEx.CtrlId);
                        }
                        objAndroidTextViewENEx_Last = objAndroidTextViewENEx;
                        objAndroidTableRowENEx.arrSubAndroidControlLst2.Add(objAndroidTextViewENEx);
                        objAndroidTableRowENEx.arrSubAndroidControlLst2.Add(objAndroidControlENEx);

                        switch (objEditRegionFldsEx.objCtlType.CtlTypeName)
                        {
                            case "CheckBox":
                                AndroidCheckBoxEx objAndroidCheckBoxENEx = (AndroidCheckBoxEx)clsAndroidControlBLEx.GetAndroidControlObjByEditFld(objEditRegionFldsEx);

                                break;
                            case "TextBox":
                                AndroidEditTextEx objAndroidEditTextENEx = (AndroidEditTextEx)clsAndroidControlBLEx.GetAndroidControlObjByEditFld(objEditRegionFldsEx);

                                break;
                            case "DropDownList":
                                AndroidSpinnerEx objAndroidSpinnerENEx = (AndroidSpinnerEx)clsAndroidControlBLEx.GetAndroidControlObjByEditFld(objEditRegionFldsEx);

                                break;

                            default:
                                string strMsg = string.Format("查询区域字段转换成安卓控件时,类型：[{0}]没有处理!({1})",
                               objEditRegionFldsEx.objCtlType.CtlTypeName, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                        }

                        AndroidTextViewEx objAndroidTextViewENEx_Line = new AndroidTextViewEx();
                        //objAndroidTextViewENEx_Line.CtrlId = "lblLine";
                        objAndroidTextViewENEx_Line.Text = "横线";
                        objAndroidTextViewENEx_Line.layout_width = "wrap_content";
                        objAndroidTextViewENEx_Line.layout_height = "wrap_content";
                        objAndroidTextViewENEx_Line.layout_marginTop = 8;

                        objAndroidTextViewENEx_Line.layout_constraintStart_toStartOf = "parent";
                        objAndroidTextViewENEx_Line.layout_constraintTop_toTopOf = "parent";
                        objAndroidTableLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidTextViewENEx_Line);
                    }
                             

                   
                }
                //编辑字段行=====================================
                //确定按钮行----------------------------------------
                {
                    AndroidTableLayoutEx objAndroidTableLayoutENEx = new AndroidTableLayoutEx();
                    objAndroidTableLayoutENEx.layout_width = "match_parent";
                    objAndroidTableLayoutENEx.layout_height = "match_parent";
                    //objAndroidTableLayoutENEx.showIn = "@layout/ac_invoke_web_srv";
                    //objAndroidTableLayoutENEx.context = "com.taishsoft.TechnicalResearch.InvokeWebSrv";
                    objAndroidTableLayoutENEx.layout_behavior = "@string/appbar_scrolling_view_behavior";
                    objAndroidTableLayoutENEx.CtrlId = string.Format("llLvItem{0}", objViewInfoENEx.TabName_Out);
                    objAndroidScrollViewENEx.arrSubAndroidControlLst2.Add(objAndroidTableLayoutENEx);


                    AndroidButtonEx objAndroidButtonENEx = new AndroidButtonEx();
                    objAndroidButtonENEx.CtrlId = string.Format("btnOkUpd");
                    objAndroidButtonENEx.OnClick = string.Format("btnOkUpd_Click");
                    objAndroidButtonENEx.Text = "确认编辑";
                    objAndroidButtonENEx.layout_width = "wrap_content";
                    objAndroidButtonENEx.layout_height = "wrap_content";
                    objAndroidButtonENEx.layout_marginTop = 10;

                    objAndroidButtonENEx.mTextSize = "12sp";
                    objAndroidButtonENEx.minHeight = "35dp";
                    objAndroidButtonENEx.layout_constraintStart_toStartOf = "parent";
                    objAndroidButtonENEx.layout_constraintTop_toTopOf = "parent";


                    //objAndroidTabHostENEx.arrSubAndroidControlLst2.Add(objAndroidLinearLayoutENEx);
                    objAndroidTableLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidButtonENEx);
                    AndroidButtonEx objAndroidButtonENEx_Cancel = new AndroidButtonEx();
                    objAndroidButtonENEx_Cancel.CtrlId = string.Format("btnCancel");
                    objAndroidButtonENEx_Cancel.OnClick = string.Format("btnCancel_Click");
                    objAndroidButtonENEx_Cancel.Text = "放弃";
                    objAndroidButtonENEx_Cancel.layout_width = "wrap_content";
                    objAndroidButtonENEx_Cancel.layout_height = "wrap_content";
                    objAndroidButtonENEx_Cancel.layout_marginTop = 10;

                    objAndroidButtonENEx_Cancel.mTextSize = "12sp";
                    objAndroidButtonENEx_Cancel.minHeight = "35dp";
                    objAndroidButtonENEx_Cancel.layout_constraintLeft_toRightOf = "@+id/btnOkUpd";
                
                        objAndroidButtonENEx_Cancel.layout_constraintTop_toTopOf = "parent";
                    //objAndroidTabHostENEx.arrSubAndroidControlLst2.Add(objAndroidLinearLayoutENEx);
                    objAndroidTableLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidButtonENEx_Cancel);

                    objAndroidScrollViewENEx.arrSubAndroidControlLst2.Add(objAndroidTableLayoutENEx);
                }
                //确定按钮行==================================
                //objAndroidScrollViewENEx.arrSubAndroidControlLst2.Add(objAndroidTextViewENEx);
                objAndroidScrollViewENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }

            return strCodeForCs.ToString();
        }



        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            //让用户设置属性;
            if (objViewInfoENEx.arrEditRegionFldSet4InUse == null || objViewInfoENEx.arrEditRegionFldSet4InUse.Count == 0)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有编辑区域,或者编辑区域没有字段。请检查!", strViewName);
                sbMessage.Append("\r\n当前界面的功能:查询(Q)、修改(U)、删除(D)、添加(I)。");
                throw new clsDbObjException(sbMessage.ToString());
            }
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;
            clsPubFun4BLEx.CheckDgStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.DgStyleId);
            clsPubFun4BLEx.CheckTitleStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.TitleStyleId);

            clsDataGridStyleEN objDGStyleEx = clsDataGridStyleBL.GetObjByDgStyleIdCache(objViewInfoENEx.objViewStyleEN.DgStyleId);

            objViewInfoENEx.WebFormName = "content_" + objViewInfoENEx.TabName + "_qudi";
            objViewInfoENEx.WebFormFName = objViewInfoENEx.FolderName + "content_" + objViewInfoENEx.TabName + "_qudi.xml";
            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;
            objViewInfoENEx.ClsName = objViewInfoENEx.WebFormName;

            strRe_ClsName = objViewInfoENEx.WebFormName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebFormFName.ToLower());

            try
            {
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

                //添加查询区域
                //< include layout = "@layout/uc_exam1type_query" />
                AndroidLinearLayoutEx objAndroidLinearLayoutENEx_Query = new AndroidLinearLayoutEx();
                //objAndroidLinearLayoutENEx.CtrlId = "txtAdd";
                objAndroidLinearLayoutENEx_Query.CtrlId = "llQuery";
                objAndroidLinearLayoutENEx_Query.layout_width = "wrap_content";
                objAndroidLinearLayoutENEx_Query.layout_height = "wrap_content";
                objAndroidLinearLayoutENEx_Query.layout_marginLeft = 0;
                objAndroidLinearLayoutENEx_Query.layout_marginTop = 1;
                objAndroidLinearLayoutENEx_Query.layout_constraintStart_toStartOf = string.Format("parent");
                objAndroidLinearLayoutENEx_Query.layout_constraintTop_toTopOf = string.Format("parent", objViewInfoENEx.TabName_Out);

                objAndroidLinearLayoutENEx_Query.orientation = "vertical";
                objAndroidConstraintLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidLinearLayoutENEx_Query);

                AndroidIncludeEx objAndroidIncludeENEx_Query = new AndroidIncludeEx();
                //objAndroidIncludeENEx.CtrlId = "txtAdd";
                objAndroidIncludeENEx_Query.CtrlId = "clQuery";
                objAndroidIncludeENEx_Query.layout = string.Format("uc_{0}_query", objViewInfoENEx.TabName.ToLower());
                objAndroidLinearLayoutENEx_Query.arrSubAndroidControlLst2.Add(objAndroidIncludeENEx_Query);

                //添加功能区域
                AndroidConstraintLayoutEx pobjAndroidConstraintLayoutENEx =
                            GetConstraintLayout4Function();
                objAndroidConstraintLayoutENEx.arrSubAndroidControlLst2.Add(pobjAndroidConstraintLayoutENEx);

                AndroidConstraintLayoutEx pobjAndroidConstraintLayoutENEx_Lv =
                          GetConstraintLayout4ListView(objViewInfoENEx.TabName_Out);
                objAndroidConstraintLayoutENEx.arrSubAndroidControlLst2.Add(pobjAndroidConstraintLayoutENEx_Lv);

               
                AndroidLinearLayoutEx objAndroidLinearLayoutENEx_Edit = new AndroidLinearLayoutEx();
                //objAndroidLinearLayoutENEx.CtrlId = "txtAdd";
                objAndroidLinearLayoutENEx_Edit.CtrlId = "llEdit";
                objAndroidLinearLayoutENEx_Edit.layout_width = "match_parent";
                objAndroidLinearLayoutENEx_Edit.layout_height = "match_parent";
                objAndroidLinearLayoutENEx_Edit.layout_marginLeft = 8;
                objAndroidLinearLayoutENEx_Edit.layout_marginTop = 16;
                objAndroidLinearLayoutENEx_Edit.layout_constraintStart_toStartOf = string.Format("parent");
                objAndroidLinearLayoutENEx_Edit.layout_constraintTop_toBottomOf = string.Format("@+id/clListView", objViewInfoENEx.TabName_Out);

                objAndroidLinearLayoutENEx_Edit.orientation = "vertical";
                objAndroidConstraintLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidLinearLayoutENEx_Edit);
                AndroidIncludeEx objAndroidIncludeENEx_Edit = new AndroidIncludeEx();
                //objAndroidIncludeENEx.CtrlId = "txtAdd";
                objAndroidIncludeENEx_Edit.CtrlId = "incEdit";
                objAndroidIncludeENEx_Edit.layout = string.Format("uc_{0}_edit", objViewInfoENEx.TabName_In.ToLower());
                objAndroidLinearLayoutENEx_Edit.arrSubAndroidControlLst2.Add(objAndroidIncludeENEx_Edit);

                //objAndroidConstraintLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidTextViewENEx);
                objAndroidConstraintLayoutENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 功能:单表的查询、修改、插入、删除
        /// </summary>
        /// <returns></returns>
        public string A_GenAppViewScriptCS(clsViewInfoENEx objViewInfoENEx, ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            //让用户设置属性;
            if (objViewInfoENEx.arrEditRegionFldSet4InUse == null || objViewInfoENEx.arrEditRegionFldSet4InUse.Count == 0)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有编辑区域,或者编辑区域没有字段。请检查!", strViewName);
                sbMessage.Append("\r\n当前界面的功能:查询(Q)、修改(U)、删除(D)、添加(I)。");
                throw new clsDbObjException(sbMessage.ToString());
            }
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;
            clsPubFun4BLEx.CheckDgStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.DgStyleId);
            clsPubFun4BLEx.CheckTitleStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.TitleStyleId);

            clsDataGridStyleEN objDGStyleEx = clsDataGridStyleBL.GetObjByDgStyleIdCache(objViewInfoENEx.objViewStyleEN.DgStyleId);

            objViewInfoENEx.WebFormName = "ac" + objViewInfoENEx.TabName + "_QUDI";
            objViewInfoENEx.WebFormFName = objViewInfoENEx.FolderName + "ac" + objViewInfoENEx.TabName + "_QUDI.java";
            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;
            objViewInfoENEx.ClsName = objViewInfoENEx.WebFormName;

            strRe_ClsName = objViewInfoENEx.WebFormName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebFormFName);
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objViewInfoENEx.PrjId); //
            try
            {
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate4Java(objViewInfoENEx.CurrUserName, objViewInfoENEx));

                //初始化列表区域的字段
                InitListRegion();
                InitEditRegion();
                InitQueryRegion();

                strCodeForCs.AppendFormat("\r\n" + "package {0}.L7_UI.{1};",
                       objProject.JavaPackageName, objFuncModule.FuncModuleEnName4GC());
                strCodeForCs.Append("\r\n" + "import android.app.Activity;");
                strCodeForCs.Append("\r\n" + "import android.content.Context;");
                strCodeForCs.Append("\r\n" + "import android.net.Uri;");
                strCodeForCs.Append("\r\n" + "import android.os.Bundle;");
                strCodeForCs.Append("\r\n" + "import android.view.View;");
                strCodeForCs.Append("\r\n" + "import android.view.inputmethod.InputMethodManager;");
                strCodeForCs.Append("\r\n" + "import android.widget.Button;");
                strCodeForCs.Append("\r\n" + "import android.widget.CheckBox;");
                strCodeForCs.Append("\r\n" + "import android.widget.HorizontalScrollView;");
                strCodeForCs.Append("\r\n" + "import android.widget.ListView;");
                strCodeForCs.Append("\r\n" + "import android.widget.Spinner;");
                strCodeForCs.Append("\r\n" + "import android.widget.TabHost;");
                strCodeForCs.Append("\r\n" + "import android.widget.EditText;");
                strCodeForCs.Append("\r\n" + "import android.widget.TextView;");
                strCodeForCs.Append("\r\n" + " import android.widget.LinearLayout;");
                strCodeForCs.Append("\r\n" + " import android.support.constraint.ConstraintLayout;");

                strCodeForCs.Append("\r\n" + "import com.taishsoft.R;");

                List<string> arrTabId4InOut = clsViewInfoBLEx.getRelaTabId4InOut(objViewInfoENEx.ViewId, objViewInfoENEx.PrjId);
                foreach (string strTabId in arrTabId4InOut)
                {
                    //if (strTabId == objViewInfoENEx.MainTabId) continue;
                    clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabIdCache(strTabId, objViewInfoENEx.PrjId);

                    clsFuncModule_AgcEN objFuncModule_AgcEN = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabEN.FuncModuleAgcId, objPrjTabEN.PrjId);
                    strCodeForCs.AppendFormat("\r\n" + "import {0}.GC.L0Entity.{2}.cls{1}EN;",
                  objProject.JavaPackageName,
                    objPrjTabEN.TabName, objFuncModule_AgcEN.FuncModuleEnName4GC()); //

                    strCodeForCs.AppendFormat("\r\n" + "import {0}.GC.L4_Controller4WS.{2}.cls{1}WS4Controller;",
                        objProject.JavaPackageName,
                          objPrjTabEN.TabName, objFuncModule_AgcEN.FuncModuleEnName4GC()); //
                    strCodeForCs.AppendFormat("\r\n" + "import {0}.GC.L5_Controller.{2}.cls{1}_Controller;",
                        objProject.JavaPackageName,
                          objPrjTabEN.TabName, objFuncModule_AgcEN.FuncModuleEnName4GC()); //
                }

              
                arrDdlBindTableLst = GetDdlBindTableLst(strCodeForCs);
                List<string> arrTabId4Ddl = clsViewInfoBLEx.getRelaTabId4Ddl_AllRegion2(objViewInfoENEx.ViewId, this.IsFstLcase, objViewInfoENEx.PrjId);
                foreach (string strTabId in arrTabId4Ddl)
                {
                    if (strTabId == objViewInfoENEx.MainTabId) continue;
                    clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabIdCache(strTabId, objViewInfoENEx.PrjId);

                    clsFuncModule_AgcEN objFuncModule_AgcEN = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabEN.FuncModuleAgcId, objPrjTabEN.PrjId);
                    strCodeForCs.AppendFormat("\r\n" + "import {0}.GC.L51_AppBusiness.{2}.ddlBind{1};",
                        objProject.JavaPackageName,
                          objPrjTabEN.TabName, objFuncModule_AgcEN.FuncModuleEnName4GC()); //
                }
                //foreach (string strDdlBindTableName in arrDdlBindTableLst)
                //{
                //    if (strDdlBindTableName == objViewInfoENEx.TabName) continue;
                //    clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabIdCache(objViewInfoENEx.tabid)
                //    clsFuncModule_AgcEN objFuncModule_AgcEN = clsFuncModule_AgcBL.GetObjByFuncModuleAgcId()
                //    strCodeForCs.AppendFormat("\r\n" + "import {0}.GC.L6_AppViewUnitTest.{2}.ddlBind{1};",
                //        objProject.JavaPackageName,
                //          strDdlBindTableName, objFuncModule.FuncModuleEnName4GC()); //
                //}
                strCodeForCs.AppendFormat("\r\n" + "import com.taishsoft.util.clsExecTask;");

                strCodeForCs.AppendFormat("\r\n" + "import com.taishsoft.util.Task;");
                strCodeForCs.AppendFormat("\r\n" + "import com.taishsoft.util.TaskQueue; ");
                if (objViewInfoENEx.TabName_Out != objViewInfoENEx.TabName)
                {
                    strCodeForCs.AppendFormat("\r\n" + "import {0}.GC.L0Entity.{2}.cls{1}EN;",
                        objProject.JavaPackageName,
                          objViewInfoENEx.TabName_Out, objFuncModule.FuncModuleEnName4GC()); //

                    strCodeForCs.AppendFormat("\r\n" + "import {0}.GC.L4_Controller4WS.{2}.cls{1}WS4Controller;",
                        objProject.JavaPackageName,
                          objViewInfoENEx.TabName_Out, objFuncModule.FuncModuleEnName4GC()); //
                    strCodeForCs.AppendFormat("\r\n" + "import {0}.GC.L5_Controller.{2}.cls{1}_Controller;",
                        objProject.JavaPackageName,
                          objViewInfoENEx.TabName_Out, objFuncModule.FuncModuleEnName4GC()); //
                }

                strCodeForCs.AppendFormat("\r\n" + "import com.taishsoft.util.clsDate;");
                strCodeForCs.AppendFormat("\r\n" + "import {0}.PubFun.clsPubFun;",
                                  objProject.JavaPackageName,
                                    objViewInfoENEx.TabName); //
                strCodeForCs.Append("\r\n" + "import com.taishsoft.util.clsParentObjDelegate; "); //
                strCodeForCs.Append("\r\n" + "import com.taishsoft.util.clsResponseData;"); //
                strCodeForCs.Append("\r\n" + "import com.taishsoft.commdb.clsTableObjWS4ControllerDelegate;"); 
                strCodeForCs.Append("\r\n" + "import java.util.ArrayList;");
                strCodeForCs.Append("\r\n" + "import java.util.Date;"); //
                strCodeForCs.Append("\r\n" + "import java.util.List;"); //

                strCodeForCs.Append("\r\n" + ""); //

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})", objViewInfoENEx.objMainPrjTab.TabCnName, objViewInfoENEx.TabName);

                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/**");
                strCodeForCs.AppendFormat("\r\n" + "* Created by {0} on {1}.",
                    objViewInfoENEx.CurrUserName,
                    clsDateTime.getTodayStr(3));
                strCodeForCs.AppendFormat("\r\n" + "* 注意:该类必须与调用界面处于同一个包,否则调用不成功!", objViewInfoENEx.CurrUserName, clsDateTime.getTodayStr(3));
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "public class  {0} extends Activity",
                    objViewInfoENEx.WebFormName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//用户任务式调用WebService的反调对象及执行任务的对象");
                strCodeForCs.Append("\r\n" + "private clsParentObjDelegate mobjParentObjDelegate_Task = null;");
                strCodeForCs.Append("\r\n" + "private iclsExecTaskEx iobjExecTaskEx = null;");

                strCodeForCs.Append("\r\n" + "//编辑模式：添加：Add,修改:Update");
                strCodeForCs.Append("\r\n" + "private TaskQueue mobjTaskQueue = null;");
                
                List <string> arrDdlBindObjLst = new List<string>();
                //为编辑区域、查询区域绑定下拉框
                Gen_DefDdlBindObj(objViewInfoENEx, strCodeForCs, arrDdlBindObjLst);

                strCodeForCs.Append("\r\n" + "//编辑模式：添加：Add,修改:Update");
                strCodeForCs.Append("\r\n" + " private String mstrOperateMode;");
                //当前修改的关键字
                strCodeForCs.AppendFormat("\r\n" + "private {0} {1};",
                    objViewInfoENEx.arrKeyPrjTabFldSet[0].ObjFieldTabENEx.objDataTypeAbbrEN.JavaType,
                    objViewInfoENEx.arrKeyPrjTabFldSet[0].ObjFieldTabENEx.PrivPropName);
                strCodeForCs.Append("\r\n" + "private String mstrKeyIdLst;");

                strCodeForCs.Append("\r\n" + "private TextView tvMsg;");
                strCodeForCs.Append("\r\n" + "private TabHost tabHost;");
                strCodeForCs.Append("\r\n" + "private Integer mintTotalRecCount = 0;//总记录数,用于获取分页对象列表");
                strCodeForCs.Append("\r\n" + "private Integer mintTotalPages = 5;//总序数,用于获取分页对象列表");
                strCodeForCs.Append("\r\n" + "private Integer mintPageIndex = 1;//页序号,第几页,用于获取分页对象列表");
                strCodeForCs.Append("\r\n" + "private Integer mintPageSize = 5;//每页记录数,用于获取分页对象列表.(数字太大,容易引进错误.)");
                strCodeForCs.Append("\r\n" + "private String mstrWhereCond =\" 1=1 \";//查询条件,用于获取分页对象列表");
                strCodeForCs.Append("\r\n" + "private String mstrOrderBy =\"\";//记录排序方式,用于获取分页对象列表");
                //strCodeForCs.Append("\r\n" + "    private LinearLayout llEdit;");
                //strCodeForCs.Append("\r\n" + "private ConstraintLayout clQuery;");
                //生成所有的函数
                List <clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst4CurrView = new List<clsvFunction4GeneCodeEN>();
                clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = null;
                //字段变量定义4Query
                objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncName4CodeCache("FieldVarDef4Query");
                arrvFunction4GeneCodeObjLst4CurrView.Add(objvFunction4GeneCodeEN);
                //字段变量定义4Edit
                objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncName4CodeCache("FieldVarDef4Edit");
                arrvFunction4GeneCodeObjLst4CurrView.Add(objvFunction4GeneCodeEN);

                //字段变量定义4List
                objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncName4CodeCache("FieldVarDef4List");
                arrvFunction4GeneCodeObjLst4CurrView.Add(objvFunction4GeneCodeEN);

                //onCreate函数
                objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncName4CodeCache("onCreate");
                arrvFunction4GeneCodeObjLst4CurrView.Add(objvFunction4GeneCodeEN);



                List<clsvPrjFeatureEN> arrvPrjFeatureObjLst =
                  clsvPrjFeatureBLEx.GetObjLstByViewId(objViewInfoENEx.ViewId, objViewInfoENEx.PrjId);
                foreach (clsvPrjFeatureEN objvPrjFeatureEN in arrvPrjFeatureObjLst)
                {
                    List<clsFeatureFuncRelaEN> arrFeatureFuncRelaObjLst = clsFeatureFuncRelaBLEx.GetObjLstByFeatureIdCacheEx(objvPrjFeatureEN.FeatureId);
//                    List<clsvFunction4CodeEN> arrvFunction4CodeObjLst4Feature = clsvFunction4CodeBLEx.GetObjLstByFeatureId(objvPrjFeatureEN.FeatureId);
                    foreach (clsFeatureFuncRelaEN objFeatureFuncRelaEN in arrFeatureFuncRelaObjLst)
                    {
                        if (string.IsNullOrEmpty(objFeatureFuncRelaEN.FuncId4GC) == true) continue;
                        clsvFunction4GeneCodeEN objvFunction4GeneCodeEN_In = clsvFunction4GeneCodeBL.GetObjByFuncId4GCCache(objFeatureFuncRelaEN.FuncId4GC);
                        clsPubConst.LangType ltLangType = clsPubConst.GetLangTypeByString(objvFunction4GeneCodeEN_In.ProgLangTypeName);
                        if (ltLangType != objViewInfoENEx.LangType) continue;
                        try
                        {
                            if (clsvFunction4GeneCodeBLEx.IsExistFuncNameInObjLst(arrvFunction4GeneCodeObjLst4CurrView, objvFunction4GeneCodeEN_In.FuncName) == false)
                            {
                                arrvFunction4GeneCodeObjLst4CurrView.Add(objvFunction4GeneCodeEN_In);
                            }
                        }
                        catch(Exception objException)
                        {
                            string strSS = objException.Message;
                        }
                    }
                }
                //lsg.Sort(delegate (SortGrid x, SortGrid y) {
                //         return y.IndexI.CompareTo(x.IndexI);
                //     });
                arrvFunction4GeneCodeObjLst4CurrView.Sort(delegate (clsvFunction4GeneCodeEN x, clsvFunction4GeneCodeEN y) {
                    return x.OrderNum.CompareTo(y.OrderNum);
                });

                int intIndex = 1;
                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN_In in arrvFunction4GeneCodeObjLst4CurrView)
                {
                    strCodeForCs.AppendFormat("\r\n" + "//生成函数：{0}、[{1}]", intIndex++, objvFunction4GeneCodeEN_In.FuncName);
                    A_GeneFuncCode(objvFunction4GeneCodeEN_In.FuncName, objViewInfoENEx, strCodeForCs, objViewInfoENEx.WebFormName);
                }
                strCodeForCs.Append("\r\n" + "}");


                //objAndroidConstraintLayoutENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        public string A_GenAppViewListViewAdapter(clsViewInfoENEx objViewInfoENEx, ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            //让用户设置属性;
            if (objViewInfoENEx.arrEditRegionFldSet4InUse == null || objViewInfoENEx.arrEditRegionFldSet4InUse.Count == 0)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有编辑区域,或者编辑区域没有字段。请检查!", strViewName);
                sbMessage.Append("\r\n当前界面的功能:查询(Q)、修改(U)、删除(D)、添加(I)。");
                throw new clsDbObjException(sbMessage.ToString());
            }
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;
            clsPubFun4BLEx.CheckDgStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.DgStyleId);
            clsPubFun4BLEx.CheckTitleStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.TitleStyleId);

            clsDataGridStyleEN objDGStyleEx = clsDataGridStyleBL.GetObjByDgStyleIdCache(objViewInfoENEx.objViewStyleEN.DgStyleId);

            objViewInfoENEx.WebFormName = "lv" + objViewInfoENEx.TabName_Out + "Adapter";
            objViewInfoENEx.WebFormFName = objViewInfoENEx.FolderName + "lv" + objViewInfoENEx.TabName_Out + "Adapter.java";
            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;
            objViewInfoENEx.ClsName = objViewInfoENEx.WebFormName;

            strRe_ClsName = objViewInfoENEx.WebFormName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebFormFName);
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objViewInfoENEx.PrjId); //
            try
            {
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate4Java(objViewInfoENEx.CurrUserName, objViewInfoENEx));

                //初始化列表区域的字段
                InitListRegion();
                InitEditRegion();
                InitQueryRegion();

                strCodeForCs.AppendFormat("\r\n" + "package {0}.L7_UI.{1};",
                       objProject.JavaPackageName, objFuncModule.FuncModuleEnName4GC());
                strCodeForCs.Append("\r\n" + "import android.app.Activity;");
                strCodeForCs.Append("\r\n" + "import android.content.Context;");
                strCodeForCs.Append("\r\n" + "import android.net.Uri;");
                strCodeForCs.Append("\r\n" + "import android.os.Bundle;");
                strCodeForCs.Append("\r\n" + "import android.view.LayoutInflater;");
                strCodeForCs.Append("\r\n" + "import android.view.View;");
                strCodeForCs.Append("\r\n" + "import android.view.ViewGroup;");
                strCodeForCs.Append("\r\n" + "import android.view.inputmethod.InputMethodManager;");
                strCodeForCs.Append("\r\n" + "import android.widget.ArrayAdapter;");
                strCodeForCs.Append("\r\n" + "import android.widget.Button;");
                strCodeForCs.Append("\r\n" + "import android.widget.CheckBox;");
                strCodeForCs.Append("\r\n" + "import android.widget.CompoundButton;");
                strCodeForCs.Append("\r\n" + "import android.widget.ListView;");
                strCodeForCs.Append("\r\n" + "import android.widget.Spinner;");
                strCodeForCs.Append("\r\n" + "import android.widget.TabHost;");
                strCodeForCs.Append("\r\n" + "import android.widget.EditText;");
                strCodeForCs.Append("\r\n" + "import android.widget.TextView;");
                strCodeForCs.Append("\r\n" + " import android.widget.LinearLayout;");
                strCodeForCs.Append("\r\n" + " import android.support.constraint.ConstraintLayout;");

                strCodeForCs.Append("\r\n" + "import com.taishsoft.R;");
                {
                  List<string> arrTabId4InOut = clsViewInfoBLEx.getRelaTabId4InOut(objViewInfoENEx.ViewId, objViewInfoENEx.PrjId);
                    foreach (string strTabId in arrTabId4InOut)
                    {
                        //if (strTabId == objViewInfoENEx.MainTabId) continue;
                        clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabIdCache(strTabId, objViewInfoENEx.PrjId);

                        clsFuncModule_AgcEN objFuncModule_AgcEN = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabEN.FuncModuleAgcId, objPrjTabEN.PrjId);
                        strCodeForCs.AppendFormat("\r\n" + "import {0}.GC.L0Entity.{2}.cls{1}EN;",
                      objProject.JavaPackageName,
                        objPrjTabEN.TabName, objFuncModule_AgcEN.FuncModuleEnName4GC()); //

                        strCodeForCs.AppendFormat("\r\n" + "import {0}.GC.L4_Controller4WS.{2}.cls{1}WS4Controller;",
                            objProject.JavaPackageName,
                              objPrjTabEN.TabName, objFuncModule_AgcEN.FuncModuleEnName4GC()); //
                        strCodeForCs.AppendFormat("\r\n" + "import {0}.GC.L5_Controller.{2}.cls{1}_Controller;",
                            objProject.JavaPackageName,
                              objPrjTabEN.TabName, objFuncModule_AgcEN.FuncModuleEnName4GC()); //
                    }                   
                }

                strCodeForCs.AppendFormat("\r\n" + "import com.taishsoft.util.clsDate;");
                strCodeForCs.AppendFormat("\r\n" + "import {0}.PubFun.clsPubFun;",
                                  objProject.JavaPackageName,
                                    objViewInfoENEx.TabName); //
                strCodeForCs.Append("\r\n" + "import com.taishsoft.util.clsResponseData;"); //
                strCodeForCs.Append("\r\n" + "import com.taishsoft.commdb.clsTableObjWS4ControllerDelegate;");
                strCodeForCs.Append("\r\n" + "import java.util.ArrayList;");
                strCodeForCs.Append("\r\n" + "import java.util.Date;"); //
                strCodeForCs.Append("\r\n" + "import java.util.List;"); //

                strCodeForCs.Append("\r\n" + ""); //

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})", objViewInfoENEx.objMainPrjTab.TabCnName, objViewInfoENEx.TabName);

                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/**");
                strCodeForCs.AppendFormat("\r\n" + "* Created by {0} on {1}.",
                    objViewInfoENEx.CurrUserName,
                    clsDateTime.getTodayStr(3));
                strCodeForCs.AppendFormat("\r\n" + "* 注意:该类必须与调用界面处于同一个包,否则调用不成功!", objViewInfoENEx.CurrUserName, clsDateTime.getTodayStr(3));
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "public class lv{0}Adapter extends ArrayAdapter<cls{0}EN>",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "private static boolean[] checks;//定义数组来保存CheckBox的状态");

                //strCodeForCs.Append("\r\n" + "private TextView tvExam1TypeId;");
                Gen_FieldVarDef4ListView(objViewInfoENEx, strCodeForCs);
                strCodeForCs.AppendFormat("\r\n" + "//private cls{0}ENEx obj{0}ENEx;",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "private cls{0}EN obj{0}EN;",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "private int resourceId;");
                strCodeForCs.Append("\r\n" + "private Context ctnParent;");

                strCodeForCs.AppendFormat("\r\n" + "public lv{0}Adapter(Context context, int textViewResourceId, List <cls{0}EN> objects)",
                   objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "super(context, textViewResourceId, objects);");
                strCodeForCs.Append("\r\n" + "ctnParent = context;");
                strCodeForCs.Append("\r\n" + "checks = new boolean[objects.size()];//初始化数组");
                strCodeForCs.Append("\r\n" + "// TODO Auto-generated constructor stub");
                strCodeForCs.Append("\r\n" + "/**");
                strCodeForCs.Append("\r\n" + "* 重写了父类的构造函数,用于将上下文,ListView子项布局的id和数据都传进来。");
                strCodeForCs.Append("\r\n" + "* **/");
                strCodeForCs.Append("\r\n" + "resourceId = textViewResourceId;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "@Override");
                strCodeForCs.Append("\r\n" + "public View getView(int position, View convertView, ViewGroup parent)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "// TODO Auto-generated method stub");
                strCodeForCs.Append("\r\n" + "//return super.getView(position, convertView, parent);");
                strCodeForCs.Append("\r\n" + "/**");
                strCodeForCs.Append("\r\n" + "* 重写getView方法,这个方法在每个子项被滚动到屏幕内的时候会被调用,在getView方法中");
                strCodeForCs.Append("\r\n" + "* ,首先通过getItem方法得到当前项的Fruit实例,然后使用LayoutInflater来为这个子项加载");
                strCodeForCs.Append("\r\n" + "* 我们传入的布局,接着调用View的findViewById方法分别获取到ImageView和TextView的实例,");
                strCodeForCs.Append("\r\n" + "* 并分别调用他们的setImageResource和setText方法来设置显示的图片和文字,最后返回布局");
                strCodeForCs.Append("\r\n" + "* **/");
                strCodeForCs.Append("\r\n" + "final int pos = position;//定义一个final的int类型pos用来记录点击的位置");

                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = getItem(position);//获取当前项的Fruit实例",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "//初始话ListView的子项布局");
                strCodeForCs.Append("\r\n" + "View view = LayoutInflater.from(getContext()).inflate(resourceId, null);");
                strCodeForCs.Append("\r\n" + "//ImageView fruitImage = (ImageView)view.findViewById(R.id.fruit_image);");
                Gen_FieldVarBind4ListView(objViewInfoENEx, strCodeForCs);
                strCodeForCs.Append("\r\n" + "Button btnUpdate = (Button)view.findViewById(R.id.btnUpdate);");
                //Gen_FieldVarBind4List(objViewInfoENEx, strCodeForCs);
                strCodeForCs.AppendFormat("\r\n" + "//fruitImage.setImageResource(obj{0}ENEx.getImageId());",
                    objViewInfoENEx.TabName_Out);
                Gen_LvFieldAssignment4List(objViewInfoENEx, strCodeForCs);
                strCodeForCs.AppendFormat("\r\n" + "btnUpdate.setTag(obj{0}EN.get{1}());",
                    objViewInfoENEx.TabName_Out,
                    objViewInfoENEx.arrKeyPrjTabFldSet[0].ObjFieldTabENEx.FldName);
                strCodeForCs.Append("\r\n" + "btnUpdate.setOnClickListener(new View.OnClickListener() {");
                strCodeForCs.Append("\r\n" + "@Override");
                strCodeForCs.Append("\r\n" + "public void onClick(View v)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "Button btn = (Button)v;");
                string strJavaType = objViewInfoENEx.arrKeyPrjTabFldSet[0].ObjFieldTabENEx.objDataTypeAbbrEN.JavaType;
                strCodeForCs.AppendFormat("\r\n" + "{1} {0} = {2};",
                    objViewInfoENEx.arrKeyPrjTabFldSet[0].ObjFieldTabENEx.PrivFuncName,
                    strJavaType,
                    AgcPubFun.getStringToOtherTypeCode4DataType4Java(strJavaType, "btn.getTag().toString()"));
                strCodeForCs.AppendFormat("\r\n" + "ac{0}_QUDI frm = (ac{0}_QUDI)ctnParent;",
                    objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "frm.UpdateRecord({0});",
                    objViewInfoENEx.arrKeyPrjTabFldSet[0].ObjFieldTabENEx.PrivFuncName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "});");
                strCodeForCs.Append("\r\n" + "CheckBox chkCheckRec = (CheckBox)view.findViewById(R.id.chkCheckRec);");
                strCodeForCs.Append("\r\n" + "chkCheckRec.setOnCheckedChangeListener(new CompoundButton.OnCheckedChangeListener()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "@Override");
                strCodeForCs.Append("\r\n" + "public void onCheckedChanged(CompoundButton buttonView, boolean isChecked)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "checks[pos] = isChecked;//当被选中时,将该位置的CheckBox的状态保存下来");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "});");
                strCodeForCs.Append("\r\n" + "return view;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "public static boolean[] getChecks()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return checks;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");

                //objAndroidConstraintLayoutENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        private AndroidConstraintLayoutEx GetConstraintLayout4Function()
        {
            AndroidConstraintLayoutEx objAndroidConstraintLayoutENEx = new AndroidConstraintLayoutEx();
            objAndroidConstraintLayoutENEx.CtrlId = string.Format("clFunction");

            objAndroidConstraintLayoutENEx.layout_width = "match_parent";
            objAndroidConstraintLayoutENEx.layout_height = "40dp";
            objAndroidConstraintLayoutENEx.layout_constraintStart_toStartOf = string.Format("parent");
            objAndroidConstraintLayoutENEx.layout_constraintTop_toBottomOf = string.Format("@+id/llQuery");

            //objAndroidConstraintLayoutENEx.orientation = "vertical";


            AndroidButtonEx objAndroidButtonENEx_Add = new AndroidButtonEx();
            objAndroidButtonENEx_Add.CtrlId = string.Format("btnAddNewRecord");
            objAndroidButtonENEx_Add.Style = "btnStyle4Function";
            objAndroidButtonENEx_Add.Text = string.Format("添加");
            objAndroidButtonENEx_Add.layout_width = "wrap_content";
            objAndroidButtonENEx_Add.layout_height = "wrap_content";
            objAndroidButtonENEx_Add.OnClick = "btnAddNewRecord_Click";

            objAndroidButtonENEx_Add.layout_constraintStart_toStartOf = "parent";

            objAndroidButtonENEx_Add.layout_marginTop = 2;

            objAndroidButtonENEx_Add.layout_constraintTop_toTopOf = string.Format("{0}", "parent");

            objAndroidConstraintLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidButtonENEx_Add);

            AndroidButtonEx objAndroidButtonENEx_Del = new AndroidButtonEx();
            objAndroidButtonENEx_Del.CtrlId = string.Format("btnDelRecordsByJSON");
            objAndroidButtonENEx_Del.Text = "删除";
            objAndroidButtonENEx_Del.Style = "btnStyle4Function";
            //objAndroidButtonENEx_Del.layout_width = "wrap_content";
            //            objAndroidButtonENEx_Del.layout_height = "wrap_content";
            objAndroidButtonENEx_Del.layout_marginLeft = 2;
            objAndroidButtonENEx_Del.layout_marginTop = 2;
            objAndroidButtonENEx_Del.OnClick = "btnDelRecordsByJSON_Click";

            objAndroidButtonENEx_Del.layout_constraintLeft_toRightOf = string.Format("@+id/btnAddNewRecord");
            objAndroidButtonENEx_Del.layout_constraintTop_toTopOf = string.Format("{0}", "parent");

            objAndroidConstraintLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidButtonENEx_Del);

            AndroidButtonEx objAndroidButtonENEx_Query = new AndroidButtonEx();
            objAndroidButtonENEx_Query.CtrlId = string.Format("btnShowQuery");
            objAndroidButtonENEx_Query.OnClick = string.Format("btnShowQuery_Click");
            objAndroidButtonENEx_Query.Text = "筛选";
            objAndroidButtonENEx_Query.Style = "btnStyle4Function";
            objAndroidButtonENEx_Query.layout_marginLeft = 2;
            objAndroidButtonENEx_Query.layout_marginTop = 2;
            //objAndroidButtonENEx_Query.layout_width = "wrap_content";
            //objAndroidButtonENEx_Query.layout_height = "wrap_content";
            //objAndroidButtonENEx_Query.mTextSize = "12sp";
            //objAndroidButtonENEx_Query.minHeight = "35dp";
            objAndroidButtonENEx_Query.layout_constraintTop_toTopOf = string.Format("{0}", "parent");

            objAndroidButtonENEx_Query.layout_constraintLeft_toRightOf = string.Format("@+id/btnDelRecordsByJSON");

            //objAndroidButtonENEx_Query.layout_constraintTop_toBottomOf = "@+id/txtNum2";

            //objAndroidTabHostENEx.arrSubAndroidControlLst2.Add(objAndroidConstraintLayoutENEx);
            objAndroidConstraintLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidButtonENEx_Query);

            AndroidTextViewEx objAndroidTextViewENEx = new AndroidTextViewEx();
            objAndroidTextViewENEx.CtrlId = "tvMsg";

            objAndroidTextViewENEx.Text = "返回结果"; 
            objAndroidTextViewENEx.Style = "tvStyle4Msg";
            objAndroidTextViewENEx.layout_width = "wrap_content";
            objAndroidTextViewENEx.layout_height = "wrap_content";
            objAndroidTextViewENEx.layout_marginLeft = 2;
            objAndroidTextViewENEx.layout_marginTop = 2;
            objAndroidTextViewENEx.layout_constraintLeft_toRightOf = "@+id/btnShowQuery";
            objAndroidTextViewENEx.layout_constraintTop_toTopOf = "parent";
            objAndroidConstraintLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidTextViewENEx);

            return objAndroidConstraintLayoutENEx;
        }

        private AndroidConstraintLayoutEx GetConstraintLayout4ListView(string strTabName)
        {
            AndroidConstraintLayoutEx objAndroidConstraintLayoutENEx = new AndroidConstraintLayoutEx();
            objAndroidConstraintLayoutENEx.CtrlId = string.Format("clListView");

            objAndroidConstraintLayoutENEx.layout_width = "match_parent";
            objAndroidConstraintLayoutENEx.layout_height = "470dp";
            objAndroidConstraintLayoutENEx.layout_constraintStart_toStartOf = "parent";
            objAndroidConstraintLayoutENEx.layout_constraintTop_toBottomOf = string.Format("@+id/clFunction");
            //objAndroidConstraintLayoutENEx.orientation = "vertical";
            //String strMsg = "";
            //添加列表区域
            //        < HorizontalScrollView
            //   android: id = "@+id/hsv{0}"
            //   android: layout_width = "match_parent"
            //   android: layout_height = "400dp"
            //   app: layout_constraintStart_toStartOf = "parent"
            //   app: layout_constraintTop_toBottomOf = "@+id/clEdit"
            //   android: scrollbars = "none" >

            //< ListView
            //   android: id = "@+id/lv{0}"
            //   android: layout_width = "match_parent"
            //   android: layout_height = "match_parent" />

            //</ HorizontalScrollView >
            AndroidLinearLayoutEx objAndroidLinearLayoutENEx_LvHead = new AndroidLinearLayoutEx();
            //objAndroidLinearLayoutENEx.CtrlId = "txtAdd";
            objAndroidLinearLayoutENEx_LvHead.CtrlId = "llLvHead";
            objAndroidLinearLayoutENEx_LvHead.layout_width = "wrap_content";
            objAndroidLinearLayoutENEx_LvHead.layout_height = "wrap_content";
            objAndroidLinearLayoutENEx_LvHead.layout_marginLeft = 0;
            objAndroidLinearLayoutENEx_LvHead.layout_marginTop = 1;
            objAndroidLinearLayoutENEx_LvHead.layout_constraintStart_toStartOf = string.Format("parent");
            objAndroidLinearLayoutENEx_LvHead.layout_constraintTop_toTopOf = string.Format("parent", strTabName);

            objAndroidLinearLayoutENEx_LvHead.orientation = "vertical";
            objAndroidConstraintLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidLinearLayoutENEx_LvHead);

            AndroidIncludeEx objAndroidIncludeENEx_LvHead = new AndroidIncludeEx();
            //objAndroidIncludeENEx.CtrlId = "txtAdd";
            objAndroidIncludeENEx_LvHead.CtrlId = "clLvHead";
            objAndroidIncludeENEx_LvHead.layout = string.Format("uc_{0}_lvhead", strTabName.ToLower());
            objAndroidLinearLayoutENEx_LvHead.arrSubAndroidControlLst2.Add(objAndroidIncludeENEx_LvHead);
            

            AndroidHorizontalScrollViewEx objAndroidHorizontalScrollViewENEx = new AndroidHorizontalScrollViewEx();
            objAndroidHorizontalScrollViewENEx.CtrlId = string.Format("hsv{0}", strTabName);
            objAndroidHorizontalScrollViewENEx.layout_width = "match_parent";
            objAndroidHorizontalScrollViewENEx.layout_height = "400dp";
            objAndroidHorizontalScrollViewENEx.layout_constraintStart_toStartOf = "parent";
            objAndroidHorizontalScrollViewENEx.layout_constraintTop_toBottomOf = string.Format("@+id/llLvHead");
            objAndroidConstraintLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidHorizontalScrollViewENEx);

            AndroidListViewEx objAndroidListViewENEx = new AndroidListViewEx();
            objAndroidListViewENEx.CtrlId = string.Format("lv{0}", strTabName);

            objAndroidListViewENEx.layout_width = "match_parent";
            objAndroidListViewENEx.layout_height = "match_parent";
            //objAndroidListViewENEx.orientation = "vertical";
            objAndroidHorizontalScrollViewENEx.arrSubAndroidControlLst2.Add(objAndroidListViewENEx);
            
            AndroidButtonEx objAndroidButtonENEx_PrevPage = new AndroidButtonEx();
            objAndroidButtonENEx_PrevPage.CtrlId = string.Format("btnPrevPage");
            objAndroidButtonENEx_PrevPage.Style = "btnStyle4InListView_W2";
            objAndroidButtonENEx_PrevPage.Tag = string.Format("btnPrevPage");
            objAndroidButtonENEx_PrevPage.Text = string.Format("上页");
            //objAndroidButtonENEx_PrevPage.layout_width = "wrap_content";
            //objAndroidButtonENEx_PrevPage.layout_height = "wrap_content";
            objAndroidButtonENEx_PrevPage.OnClick = "btnPageIndexChanged_Click";

            objAndroidButtonENEx_PrevPage.layout_constraintStart_toStartOf = "parent";

            objAndroidButtonENEx_PrevPage.layout_marginTop = 2;

            objAndroidButtonENEx_PrevPage.layout_constraintTop_toBottomOf = string.Format("@+id/hsv{0}", strTabName);

            objAndroidConstraintLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidButtonENEx_PrevPage);

            AndroidButtonEx objAndroidButtonENEx_NextPage = new AndroidButtonEx();
            objAndroidButtonENEx_NextPage.CtrlId = string.Format("btnNextPage");
            objAndroidButtonENEx_NextPage.Text = "下页";
            objAndroidButtonENEx_NextPage.Style = "btnStyle4InListView_W2";
            //objAndroidButtonENEx_NextPage.layout_width = "wrap_content";
            //            objAndroidButtonENEx_NextPage.layout_height = "wrap_content";
            objAndroidButtonENEx_NextPage.layout_marginLeft = 2;
            objAndroidButtonENEx_NextPage.layout_marginTop = 2;
            objAndroidButtonENEx_NextPage.OnClick = "btnPageIndexChanged_Click";

            objAndroidButtonENEx_NextPage.layout_constraintLeft_toRightOf = string.Format("@+id/btnPrevPage");
            objAndroidButtonENEx_NextPage.layout_constraintTop_toBottomOf = string.Format("@+id/hsv{0}", strTabName);

            objAndroidConstraintLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidButtonENEx_NextPage);

            AndroidButtonEx objAndroidButtonENEx_FirstPage = new AndroidButtonEx();
            objAndroidButtonENEx_FirstPage.CtrlId = string.Format("btnFirstPage");
            objAndroidButtonENEx_FirstPage.OnClick = string.Format("btnPageIndexChanged_Click");
            objAndroidButtonENEx_FirstPage.Text = "首页";
            objAndroidButtonENEx_FirstPage.Style = "btnStyle4InListView_W2";
            objAndroidButtonENEx_FirstPage.layout_marginLeft = 2;
            objAndroidButtonENEx_FirstPage.layout_marginTop = 2;
            //objAndroidButtonENEx_FirstPage.layout_width = "wrap_content";
            //objAndroidButtonENEx_FirstPage.layout_height = "wrap_content";
            //objAndroidButtonENEx_FirstPage.mTextSize = "12sp";
            //objAndroidButtonENEx_FirstPage.minHeight = "35dp";
            objAndroidButtonENEx_FirstPage.layout_constraintTop_toBottomOf = string.Format("@+id/hsv{0}", strTabName);

            objAndroidButtonENEx_FirstPage.layout_constraintLeft_toRightOf = string.Format("@+id/btnNextPage");
            objAndroidConstraintLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidButtonENEx_FirstPage);

            AndroidButtonEx objAndroidButtonENEx_LastPage = new AndroidButtonEx();
            objAndroidButtonENEx_LastPage.CtrlId = string.Format("btnLastPage");
            objAndroidButtonENEx_LastPage.OnClick = string.Format("btnPageIndexChanged_Click");
            objAndroidButtonENEx_LastPage.Text = "尾页";
            objAndroidButtonENEx_LastPage.Style = "btnStyle4InListView_W2";
            objAndroidButtonENEx_LastPage.layout_marginLeft = 2;
            objAndroidButtonENEx_LastPage.layout_marginTop = 2;
            //objAndroidButtonENEx_LastPage.layout_width = "wrap_content";
            //objAndroidButtonENEx_LastPage.layout_height = "wrap_content";
            //objAndroidButtonENEx_LastPage.mTextSize = "12sp";
            //objAndroidButtonENEx_LastPage.minHeight = "35dp";
            objAndroidButtonENEx_LastPage.layout_constraintTop_toBottomOf = string.Format("@+id/hsv{0}", strTabName);

            objAndroidButtonENEx_LastPage.layout_constraintLeft_toRightOf = string.Format("@+id/btnFirstPage");
            objAndroidConstraintLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidButtonENEx_LastPage);


            AndroidTextViewEx objAndroidTextViewENEx = new AndroidTextViewEx();
            objAndroidTextViewENEx.CtrlId = "tvPageStatus";
            objAndroidTextViewENEx.Text = "总共0页";
            objAndroidTextViewENEx.Style = "tvStyle4MsgInListView";
            objAndroidTextViewENEx.layout_width = "wrap_content";
            objAndroidTextViewENEx.layout_height = "wrap_content";
            objAndroidTextViewENEx.layout_marginLeft = 2;
            objAndroidTextViewENEx.layout_marginTop = 2;
            objAndroidTextViewENEx.layout_constraintLeft_toRightOf = "@+id/btnLastPage";
            objAndroidTextViewENEx.layout_constraintTop_toBottomOf = string.Format("@+id/hsv{0}", strTabName);

            objAndroidConstraintLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidTextViewENEx);
            
            return objAndroidConstraintLayoutENEx;
        }
    
   

        ///以下均是界面层内容(VIEW) == == = 

        public string A_GenViewCode_Web(clsViewInfoENEx objViewInfoENEx, ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            //switch ((enumViewTypeCodeTab)objViewInfoENEx.ViewTypeCode)
            //{
            //    case enumViewTypeCodeTab.Table_QUDI_4:// "0004":    //单表的QUDI
            //        return GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName);
            //    case enumViewTypeCodeTab.Table_QUDI4Android_21:// "0004":    //单表的QUDI
            //        return GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName);
            //    default:
            //        clsViewTypeCodeTabEN objViewTypeCodeTabEN = clsViewTypeCodeTabBL.GetObjByViewTypeCodeCache(objViewInfoENEx.ViewTypeCode);
            //        string strMsg = string.Format("界面类型：[{0}({1})]在函数:[{2}]中没有被处理,请联系管理员!",
            //            objViewTypeCodeTabEN.ViewTypeName,
            //            objViewInfoENEx.ViewTypeCode,
            //            clsStackTrace.GetCurrClassFunction());
            //        throw new Exception(strMsg);
            //}
            return "";
        }

      

        public bool DispDataGridRegionCtrl(System.Web.UI.WebControls.PlaceHolder phDataGridRegion, clsViewInfoENEx objViewInfoENEx)
        {

            Table objTable = new Table();//创建一个表格
            Table objTable4JumpPage = new Table();//创建一个表格
            objTable.BorderWidth = Unit.Parse("4");
            objTable.BorderColor = System.Drawing.Color.BurlyWood;

            objTable.Width = Unit.Parse("100%");
            TableRow tabRow;
            TableCell cell1;
            System.Web.UI.WebControls.Label lbl1;
            System.Web.UI.WebControls.TextBox txt1;
            System.Web.UI.WebControls.Button btn1;

            tabRow = new TableRow();//创建一行
            if (objViewInfoENEx.objViewRegion_List.IsRadio() || objViewInfoENEx.objViewRegion_List.IsCheck())
            {
                cell1 = new TableCell();//创建单元格,也就是第一列

                lbl1 = new Label();
                lbl1.Text = objViewInfoENEx.objInRelaTab.TabCnName + "列表";
                lbl1.CssClass = "h6";
                //				lbl1.Style.Add("position","absolute");
                //				lbl1.Style.Add("left","4px");
                //				lbl1.Style.Add("top","4px");
                cell1.Controls.Add(lbl1);
                lbl1 = new Label();
                lbl1.Text = "　　　　";
                lbl1.CssClass = "h6";
                cell1.Controls.Add(lbl1);
                btn1 = MakeButton("添加记录");
                cell1.Controls.Add(btn1);
                tabRow.Cells.Add(cell1);
                btn1 = MakeButton("修改记录");
                cell1.Controls.Add(btn1);
                tabRow.Cells.Add(cell1);
                btn1 = MakeButton("删除记录");
                cell1.Controls.Add(btn1);
                tabRow.Cells.Add(cell1);
                btn1 = MakeButton("导出Excel");
                cell1.Controls.Add(btn1);
                tabRow.Cells.Add(cell1);
                objTable.Rows.Add(tabRow);//添加到表格中
            }
            ///新建表行,专用于放Datagrid
            tabRow = new TableRow();//创建一行
            cell1 = new TableCell();//创建单元格,也就是第一列
            DataGrid dg = MakeGrid();
            cell1.Controls.Add(dg);
            cell1.HorizontalAlign = HorizontalAlign.Left;
            tabRow.Cells.Add(cell1);
            objTable.Rows.Add(tabRow);

            ///新建表行,专用于放跳页
            ///
            tabRow = new TableRow();//创建一行
            cell1 = new TableCell();//创建单元格,也就是第一列
                                    //cell1.Font.Name = "verdana";
                                    //cell1.Font.Size = FontUnit.Parse("x-small");
            cell1.CssClass = "NameLabel";
            cell1.BackColor = System.Drawing.Color.Plum;    // "#c0c0c0";
            cell1.Text = "共有记录:";
            tabRow.Cells.Add(cell1);

            cell1 = new TableCell();//创建单元格,也就是第一列
            lbl1 = MakeLabel("0");
            lbl1.Width = 16;
            cell1.Controls.Add(lbl1);
            tabRow.Cells.Add(cell1);

            cell1 = new TableCell();//创建单元格,也就是第一列
                                    //cell1.Font.Name = "verdana";
                                    //cell1.Font.Size = FontUnit.Parse("x-small");
            cell1.CssClass = "NameLabel";
            cell1.BackColor = System.Drawing.Color.Plum;    // "#c0c0c0";
            cell1.Text = "总页数:";
            tabRow.Cells.Add(cell1);

            cell1 = new TableCell();//创建单元格,也就是第一列
            lbl1 = MakeLabel("0");
            lbl1.Width = 16;
            cell1.Controls.Add(lbl1);
            tabRow.Cells.Add(cell1);

            cell1 = new TableCell();//创建单元格,也就是第一列
                                    //cell1.Font.Name = "verdana";
                                    //cell1.Font.Size = FontUnit.Parse("x-small");
            cell1.CssClass = "NameLabel";
            cell1.BackColor = System.Drawing.Color.Plum;    // "#c0c0c0";
            cell1.Text = "当前页:";
            tabRow.Cells.Add(cell1);

            cell1 = new TableCell();//创建单元格,也就是第一列
            lbl1 = MakeLabel("0");
            lbl1.Width = 16;
            cell1.Controls.Add(lbl1);
            tabRow.Cells.Add(cell1);

            cell1 = new TableCell();//创建单元格,也就是第一列
            btn1 = MakeButton("上一页");
            btn1.Width = 50;
            cell1.Controls.Add(btn1);
            tabRow.Cells.Add(cell1);

            cell1 = new TableCell();//创建单元格,也就是第一列
            btn1 = MakeButton("下一页");
            btn1.Width = 50;
            cell1.Controls.Add(btn1);
            tabRow.Cells.Add(cell1);

            cell1 = new TableCell();//创建单元格,也就是第一列
                                    //cell1.Font.Name = "verdana";
                                    //cell1.Font.Size = FontUnit.Parse("x-small");
            cell1.CssClass = "NameLabel";
            cell1.BackColor = System.Drawing.Color.Plum;    // "#c0c0c0";
            cell1.Text = "到第:";
            tabRow.Cells.Add(cell1);

            cell1 = new TableCell();//创建单元格,也就是第一列
            txt1 = MakeTextBox("1");
            txt1.Width = 35;
            cell1.Controls.Add(txt1);
            tabRow.Cells.Add(cell1);

            cell1 = new TableCell();//创建单元格,也就是第一列
            btn1 = MakeButton("确定");
            btn1.Width = 35;
            cell1.Controls.Add(btn1);
            tabRow.Cells.Add(cell1);

            objTable4JumpPage.Rows.Add(tabRow);

            tabRow = new TableRow();
            cell1 = new TableCell();//创建单元格,也就是第一列
            cell1.Controls.Add(objTable4JumpPage);
            tabRow.Cells.Add(cell1);
            objTable.Rows.Add(tabRow);
            phDataGridRegion.Controls.Add(objTable);
            //			phDataGridRegion.Controls.Add(objTable4JumpPage);

            return true;
        }
        public DataGrid MakeGrid()
        {

            DataGrid mygrid = new DataGrid();
            mygrid.CellPadding = 2;
            mygrid.Attributes.Add("align", "center");
            mygrid.CellSpacing = 0;
            mygrid.Width = 700;
            mygrid.BorderWidth = 1;
            mygrid.BorderColor = ColorTranslator.FromHtml("Black");
            mygrid.AutoGenerateColumns = false;
            mygrid.ForeColor = ColorTranslator.FromHtml("Black");
            mygrid.Font.Size = 9;
            mygrid.Font.Name = "宋体";
            mygrid.AllowSorting = true;
            if (objViewInfoENEx.objViewRegion_List.AllowPaging() == true)
            {
                mygrid.AllowPaging = true;
                mygrid.PageSize = objViewInfoENEx.objViewRegion_List.PageSize();
                mygrid.ShowFooter = true;
                mygrid.PagerStyle.Mode = PagerMode.NumericPages;
            }
            ///sort命令的事件处理器

            //			mygrid.SortCommand += new DataGridSortCommandEventHandler(Sort_Grid);

            ///设置headerstyle
            mygrid.HeaderStyle.BackColor = ColorTranslator.FromHtml("Gold");
            mygrid.HeaderStyle.ForeColor = ColorTranslator.FromHtml("Black");
            mygrid.HeaderStyle.Font.Name = "宋体";
            mygrid.HeaderStyle.Font.Size = 9;
            mygrid.HeaderStyle.Font.Bold = true;
            mygrid.HeaderStyle.HorizontalAlign = HorizontalAlign.Center;

            ///设置alternating style
            mygrid.AlternatingItemStyle.BackColor = ColorTranslator.FromHtml("Silver");
            mygrid.AlternatingItemStyle.ForeColor = ColorTranslator.FromHtml("Black");

            ///设置itemstyle
            mygrid.ItemStyle.HorizontalAlign = HorizontalAlign.Left;

            ///创建绑定列和属性
            int intColNo = 0;   //列序号
                                ///如果有单选按钮
            if (objViewInfoENEx.objViewRegion_List.IsRadio())
            {
                TemplateColumn tempCol = new TemplateColumn();
                ColumnTemplate_Radio myColTemp = new ColumnTemplate_Radio();

                ///设置模板列属性和ItemStyle模板
                tempCol.HeaderText = "选择";
                tempCol.HeaderStyle.HorizontalAlign = HorizontalAlign.Center;
                tempCol.ItemStyle.BackColor = ColorTranslator.FromHtml("#FFF778");
                tempCol.ItemStyle.HorizontalAlign = HorizontalAlign.Center;

                ///创建列模板。
                ///列模板从ITemplate继承
                tempCol.ItemTemplate = myColTemp;
                mygrid.Columns.AddAt(intColNo++, tempCol);

            }
            ///如果有复选按钮
            if (objViewInfoENEx.objViewRegion_List.IsCheck())
            {
                TemplateColumn tempCol = new TemplateColumn();
                ColumnTemplate_Chk myColTemp = new ColumnTemplate_Chk();

                ///设置模板列属性和ItemStyle模板
                tempCol.HeaderText = "全选";
                tempCol.HeaderStyle.HorizontalAlign = HorizontalAlign.Center;
                tempCol.ItemStyle.BackColor = ColorTranslator.FromHtml("#FFF778");
                tempCol.ItemStyle.HorizontalAlign = HorizontalAlign.Center;

                ///创建列模板。
                ///列模板从ITemplate继承
                tempCol.ItemTemplate = myColTemp;
                mygrid.Columns.AddAt(intColNo++, tempCol);

            }
            foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
            {
                BoundColumn boundCol = new BoundColumn();
                boundCol.HeaderText = objDGRegionFldsEx.HeaderText;
                boundCol.DataField = objDGRegionFldsEx.ObjFieldTabENEx.FldName;
                boundCol.SortExpression = objDGRegionFldsEx.ObjFieldTabENEx.FldName;
                mygrid.Columns.AddAt(intColNo++, boundCol);
                //					mygrid.Columns.AddAt(1, LastName);
            }

            if (objViewInfoENEx.objViewRegion_List.IsHaveUpdBtn())
            {
                ButtonColumn objButtonCol = new ButtonColumn();
                objButtonCol.HeaderText = "修改";
                objButtonCol.Text = "修改";
                //				objButtonCol.DataField = objViewCtlField.FldName;
                //				objButtonCol.SortExpression = objViewCtlField.FldName;
                objButtonCol.CommandName = "Update";
                mygrid.Columns.AddAt(intColNo++, objButtonCol);
            }

            if (objViewInfoENEx.objViewRegion_List.IsHaveDelBtn())
            {
                ButtonColumn objButtonCol = new ButtonColumn();
                objButtonCol.HeaderText = "删除";
                objButtonCol.Text = "删除";
                //				objButtonCol.DataField = objViewCtlField.FldName;
                //				objButtonCol.SortExpression = objViewCtlField.FldName;
                objButtonCol.CommandName = "Delete";
                mygrid.Columns.AddAt(intColNo++, objButtonCol);

                //				TemplateColumn tempCol = new TemplateColumn();
                //				ColumnTemplate myColTemp = new ColumnTemplate();
                //
                //				///设置模板列属性和ItemStyle模板
                //				tempCol.HeaderText = "删除";
                //				tempCol.HeaderStyle.HorizontalAlign = HorizontalAlign.Center;
                //				tempCol.ItemStyle.BackColor = ColorTranslator.FromHtml("#FFF778");
                //				tempCol.ItemStyle.HorizontalAlign = HorizontalAlign.Center;
                //				Button lb = new Button();
                //				lb.Text = "删除";
                //				///创建列模板。
                //				///列模板从ITemplate继承
                //				myColTemp.InstantiateIn(lb);
                //				tempCol.ItemTemplate = myColTemp;
                //				
                ////<asp:TemplateColumn>
                ////<ItemTemplate>
                ////<asp:Button id = "lbnDelete" runat = "Server" CommandName = "Delete" Text = "删除"></asp:Button>
                ////</ItemTemplate>
                ////</asp:TemplateColumn>
                ////
                //				mygrid.Columns.AddAt(intColNo++, tempCol);

            }
            if (objViewInfoENEx.objViewRegion_List.IsHaveDetailBtn())
            {
                ButtonColumn objButtonCol = new ButtonColumn();
                objButtonCol.HeaderText = "详细";
                objButtonCol.Text = "详细";
                //				objButtonCol.DataField = objViewCtlField.FldName;
                //				objButtonCol.SortExpression = objViewCtlField.FldName;
                objButtonCol.CommandName = "Update";
                mygrid.Columns.AddAt(intColNo++, objButtonCol);
            }

            mygrid.DataSource = MakeTestTable();

            mygrid.DataBind();
            return mygrid;
        }
        private DataView MakeTestTable()
        {
            // Create a new DataTable.
            System.Data.DataTable myDataTable = new DataTable("TestTable");
            // Declare variables for DataColumn and DataRow objects.
            DataColumn myDataColumn;
            DataRow myDataRow;
            foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
            {
                // Create new DataColumn, set DataType, ColumnName and add to DataTable.  
                myDataColumn = new DataColumn();
                myDataColumn.DataType = System.Type.GetType("System.String");
                myDataColumn.ColumnName = objDGRegionFldsEx.ObjFieldTabENEx.FldName;
                myDataColumn.ReadOnly = true;
                myDataColumn.Unique = false;
                // Add the Column to the DataColumnCollection.
                myDataTable.Columns.Add(myDataColumn);
            }
            for (int i = 0; i <= 2; i++)
            {
                myDataRow = myDataTable.NewRow();
                foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
                {
                    myDataRow[objDGRegionFldsEx.ObjFieldTabENEx.FldName] = i.ToString();
                }
                //				myDataRow["id"] = i;
                //				myDataRow["ParentItem"] = "ParentItem " + i;
                myDataTable.Rows.Add(myDataRow);
            }
            DataView myView = myDataTable.DefaultView;
            //myView.Sort = SortExpression;
            //Response.Write(sql);
            return myView;
        }

        public static Button MakeButton(string strButtonName)
        {
            System.Web.UI.WebControls.Button btn1;
            btn1 = new Button();
            btn1.Text = strButtonName;
            //btn1.Font.Name = "verdana";
            //btn1.Font.Size = FontUnit.Parse("x-small");
            btn1.CssClass = "btn btn-primary btn-sm";
            btn1.Width = 80;
            return btn1;
        }

        public static Label MakeLabel(string strLabelText)
        {
            System.Web.UI.WebControls.Label lbl1;
            lbl1 = new Label();
            lbl1.Text = strLabelText;
            lbl1.CssClass = "NameLabel";

            //lbl1.Font.Name = "verdana";
            //lbl1.Font.Size = FontUnit.Parse("x-small");
            lbl1.Width = 60;
            return lbl1;
        }
        public static TextBox MakeTextBox(string strTextBoxText)
        {
            System.Web.UI.WebControls.TextBox txt1;
            txt1 = new TextBox();
            txt1.Text = "";
            txt1.CssClass = "TextBox_Defa";
            //txt1.Font.Name = "verdana";
            //txt1.Font.Size = FontUnit.Parse("x-small");
            txt1.Width = 60;
            return txt1;
        }
        public static CheckBox MakeCheckBox(string strCheckBoxText)
        {
            System.Web.UI.WebControls.CheckBox chk1;
            chk1 = new CheckBox();
            chk1.Text = strCheckBoxText;
            chk1.CssClass = "Check_Defa";
            //chk1.Font.Name = "verdana";
            //chk1.Font.Size = FontUnit.Parse("x-small");
            chk1.Width = 100;
            return chk1;
        }


        public static bool DispEditRegionCtrl(System.Web.UI.WebControls.PlaceHolder phQryRegion, clsViewInfoENEx objViewInfoENEx)
        {
            int intColNum = objViewInfoENEx.objViewRegion_Edit.ColNum ?? 0;

            Table tb = new Table();//创建一个表格
            tb.BorderWidth = Unit.Parse("4");
            tb.BorderColor = System.Drawing.Color.BurlyWood;
            tb.Width = Unit.Parse("100%");
            int iCtlNum = 0;
            TableRow tr;
            TableCell cell1, cell2;
            System.Web.UI.WebControls.Label lbl1;
            System.Web.UI.WebControls.CheckBox chk1;
            System.Web.UI.WebControls.TextBox txt1;
            System.Web.UI.WebControls.DropDownList ddl1;
            System.Web.UI.WebControls.Button btn1;
            System.Web.UI.WebControls.Panel panel1;

            panel1 = new Panel();
            panel1.Width = 700;
            panel1.Height = 32;


            //	<asp:label id = "Label1" style = "z-index: 109; left: 0px; position: absolute; top: 1px" runat = "server"
            //	CssClass = "h6">编辑字段属性</asp:label></DIV>
            lbl1 = new Label();
            lbl1.Text = objViewInfoENEx.objInRelaTab.TabCnName + "字段属性";
            lbl1.CssClass = "h6";
            //lbl1.Style.Add("position", "absolute");
            //lbl1.Style.Add("left", "4px");
            //lbl1.Style.Add("top", "4px");
            lbl1.Width = 400;
            panel1.Controls.Add(lbl1);

            btn1 = new Button();
            btn1.Text = "添加";
            //btn1.Font.Name = "verdana";
            //btn1.Font.Size = FontUnit.Parse("x-small");
            btn1.CssClass = "btn btn-primary btn-sm";
            btn1.Width = 80;

            //<asp:Button id = "btnOKUpd" style = "z-index: 106; left: 720px; position: absolute; top: 0px" runat = "server"
            //												Font-Names = "verdana" Font-Size = "x-Small" Height = "24px" Width = "80px" Text = "添加"></asp:Button>

            //btn1.Style.Add("position","absolute");
            //btn1.Style.Add("left","620px");
            //btn1.Style.Add("top","4px");
            panel1.Controls.Add(btn1);

            tr = new TableRow();//创建一行
            cell1 = new TableCell();//创建单元格,也就是第一列
            cell1.Controls.Add(panel1);
            cell1.ColumnSpan = intColNum * 2;
            tr.Cells.Add(cell1);
            //			for(int i = 0; i<intColNum*2-1; i++)
            //			{
            //				cell1 = new TableCell();//创建单元格,也就是第一列
            //				tr.Cells.Add(cell1);   
            //			}
            tb.Rows.Add(tr);//添加到表格中


            tr = new TableRow();//创建一行
            bool bolIsEndRow = false;
            foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
            {
                if (iCtlNum % (intColNum * 2) == 0)
                {
                    tr = new TableRow();//创建一行
                    bolIsEndRow = false;
                }

                switch (objEditRegionFldsEx.objCtlType.CtlTypeName)
                {
                    case "CheckBox":
                        chk1 = new CheckBox();
                        chk1.Text = objEditRegionFldsEx.LabelCaption;
                        //chk1.Font.Name = "verdana";
                        //chk1.Font.Size = FontUnit.Parse("x-small");
                        lbl1.CssClass = "NameLabel";
                        chk1.Width = 100;
                        cell1 = new TableCell();//创建单元格,也就是第一列
                        cell1.Controls.Add(chk1);
                        tr.Cells.Add(cell1);
                        iCtlNum++;
                        cell2 = new TableCell();//创建单元格,也就是第一列
                        cell1.Text = "";
                        tr.Cells.Add(cell2);

                        break;
                    case "TextBox":
                        lbl1 = new Label();
                        lbl1.Text = objEditRegionFldsEx.LabelCaption;
                        //lbl1.Font.Name = "verdana";
                        //lbl1.Font.Size = FontUnit.Parse("x-small");
                        lbl1.CssClass = "NameLabel";
                        lbl1.Width = 60;
                        cell1 = new TableCell();//创建单元格,也就是第一列
                        cell1.Controls.Add(lbl1);
                        tr.Cells.Add(cell1);
                        iCtlNum++;
                        txt1 = new TextBox();
                        txt1.Text = "";
                        //txt1.Font.Name = "verdana";
                        //txt1.Font.Size = FontUnit.Parse("x-small");
                        txt1.CssClass = "TextBox_Defa";
                        txt1.Width = 60;
                        cell2 = new TableCell();//创建单元格,也就是第一列
                        cell2.Controls.Add(txt1);
                        tr.Cells.Add(cell2);
                        break;
                    case "DropDownList":
                        lbl1 = new Label();
                        lbl1.Text = objEditRegionFldsEx.LabelCaption;
                        //lbl1.Font.Name = "verdana";
                        //lbl1.Font.Size = FontUnit.Parse("x-small");
                        lbl1.CssClass = "NameLabel";
                        lbl1.Width = 60;
                        cell1 = new TableCell();//创建单元格,也就是第一列
                        cell1.Controls.Add(lbl1);
                        tr.Cells.Add(cell1);
                        iCtlNum++;
                        ddl1 = new DropDownList();
                        //							ddl1.Text = "";
                        //ddl1.Font.Name = "verdana";
                        //ddl1.Font.Size = FontUnit.Parse("x-small");
                        ddl1.CssClass = "DropDown_Defa";
                        ddl1.Width = 60;
                        cell2 = new TableCell();//创建单元格,也就是第一列
                        cell2.Controls.Add(ddl1);
                        tr.Cells.Add(cell2);
                        break;

                    default:
                        lbl1 = new Label();
                        lbl1.Text = objEditRegionFldsEx.LabelCaption;
                        //lbl1.Font.Name = "verdana";
                        //lbl1.Font.Size = FontUnit.Parse("x-small");
                        lbl1.Width = 60;
                        cell1 = new TableCell();//创建单元格,也就是第一列
                        cell1.Controls.Add(lbl1);
                        tr.Cells.Add(cell1);
                        iCtlNum++;
                        txt1 = new TextBox();
                        txt1.Text = "";
                        //txt1.Font.Name = "verdana";
                        //txt1.Font.Size = FontUnit.Parse("x-small");
                        txt1.Width = 60;
                        cell2 = new TableCell();//创建单元格,也就是第一列
                        cell2.Controls.Add(txt1);
                        tr.Cells.Add(cell2);
                        break;
                }

                if (iCtlNum % (intColNum * 2) == (intColNum * 2 - 1))
                {
                    tb.Rows.Add(tr);//添加到表格中
                    bolIsEndRow = true;
                }
                iCtlNum++;
            }
            if (bolIsEndRow == false)
            {
                tb.Rows.Add(tr);//添加到表格中
            }

            ///生成查询按钮的代码;
            //			strCodeForCs.Append("\r\n" + GenButton(objButtonStyle,"btnQuery","查询"));
            phQryRegion.Controls.Add(tb);


            return true;
        }
        //显示预览<Excel导出区域>的控件
        public static bool DispExcelExportRegionCtrl(System.Web.UI.WebControls.PlaceHolder phExcelExportRegion, clsViewInfoENEx objViewInfoENEx)
        {

            Table tb = new Table();//创建一个表格

            tb.BorderWidth = Unit.Parse("4");
            tb.BorderColor = System.Drawing.Color.BurlyWood;
            tb.Width = Unit.Parse("100%");
            TableRow tr;
            TableCell cell1;
            System.Web.UI.WebControls.Label lbl1;
            System.Web.UI.WebControls.CheckBox chk1;
            System.Web.UI.WebControls.Button btn1;
            int intColNum = objViewInfoENEx.objViewRegion_Query.ColNum ?? 0;
            int intIndex = 1;
            foreach (clsExcelExportRegionFldsENEx objExcelExportRegionFldsEx in objViewInfoENEx.arrExcelExportRegionFldSet)
            {
                tr = new TableRow();//创建一行
                                    //序号
                lbl1 = new Label();
                lbl1.Text = intIndex.ToString();
                //lbl1.Font.Name = "verdana";
                //lbl1.Font.Size = FontUnit.Parse("x-small");
                lbl1.CssClass = "NameLabel";
                lbl1.Width = 20;
                cell1 = new TableCell();//创建单元格,也就是第一列
                cell1.Controls.Add(lbl1);
                tr.Cells.Add(cell1);

                //复选框
                chk1 = new CheckBox();
                chk1.Text = "";
                //chk1.Font.Name = "verdana";
                //chk1.Font.Size = FontUnit.Parse("x-small");
                chk1.CssClass = "Check_Defa";
                chk1.Width = 30;
                cell1 = new TableCell();//创建单元格,也就是第一列
                cell1.Controls.Add(chk1);
                tr.Cells.Add(cell1);

                //字段名(列名)
                lbl1 = new Label();
                lbl1.Text = objExcelExportRegionFldsEx.ColCaption;
                //lbl1.Font.Name = "verdana";
                //lbl1.Font.Size = FontUnit.Parse("x-small");
                lbl1.CssClass = "NameLabel";
                lbl1.Width = 120;
                cell1 = new TableCell();//创建单元格,也就是第一列
                cell1.Controls.Add(lbl1);
                tr.Cells.Add(cell1);
                tb.Rows.Add(tr);//添加到表格中
                intIndex++;
            }
            //导出EXCEL的按钮
            tr = new TableRow();//创建一行
                                //空两格
            cell1 = new TableCell();//创建单元格,也就是第一列
            tr.Cells.Add(cell1);
            cell1 = new TableCell();//创建单元格,也就是第一列
            tr.Cells.Add(cell1);

            btn1 = new Button();
            btn1.Text = "导出Excel";
            //btn1.Font.Name = "verdana";
            //btn1.Font.Size = FontUnit.Parse("x-small");
            btn1.CssClass = "btn btn-primary btn-sm";
            btn1.Width = 80;
            cell1 = new TableCell();//创建单元格,也就是第一列
            cell1.Controls.Add(btn1);
            tr.Cells.Add(cell1);
            tb.Rows.Add(tr);//添加到表格中
                            ///生成查询按钮的代码;
            //			strCodeForCs.Append("\r\n" + GenButton(objButtonStyle,"btnQuery","查询"));
            phExcelExportRegion.Controls.Add(tb);


            return true;
        }
        //显示预览<ListView区域>的控件
        public static bool DispListViewRegionCtrl(System.Web.UI.WebControls.PlaceHolder phListViewRegion, clsViewInfoENEx objViewInfoENEx)
        {

            Table tb = new Table();//创建一个表格

            tb.BorderWidth = Unit.Parse("4");
            tb.BorderColor = System.Drawing.Color.BurlyWood;
            tb.Width = Unit.Parse("100%");
            TableRow tr, tabRow;
            TableCell cell1;
            System.Web.UI.WebControls.Label lbl1;
            System.Web.UI.WebControls.Button btn1;
            int intColNum = objViewInfoENEx.objViewRegion_Query.ColNum ?? 0;

            Table objTable = new Table();//创建一个表格

            tabRow = new TableRow();//创建一行

            cell1 = new TableCell();//创建单元格,也就是第一列
            lbl1 = new Label();
            lbl1.Text = objViewInfoENEx.objInRelaTab.TabCnName + "列表";
            lbl1.CssClass = "h6";
            //				lbl1.Style.Add("position","absolute");
            //				lbl1.Style.Add("left","4px");
            //				lbl1.Style.Add("top","4px");
            lbl1.CssClass = "NameLabel";
            cell1.Controls.Add(lbl1);
            lbl1 = new Label();
            lbl1.Text = "　　　　";
            lbl1.CssClass = "h6";
            cell1.Controls.Add(lbl1);
            btn1 = MakeButton("添加记录");
            cell1.Controls.Add(btn1);
            tabRow.Cells.Add(cell1);
            btn1 = MakeButton("修改记录");
            cell1.Controls.Add(btn1);
            tabRow.Cells.Add(cell1);
            btn1 = MakeButton("删除记录");
            cell1.Controls.Add(btn1);
            tabRow.Cells.Add(cell1);
            btn1 = MakeButton("导出Excel");
            cell1.Controls.Add(btn1);
            tabRow.Cells.Add(cell1);
            objTable.Rows.Add(tabRow);//添加到表格中


            int intIndex = 1;
            tr = new TableRow();//创建一行
            foreach (clsDGRegionFldsENEx ObjLstViewRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
            {
                //字段名(列名)
                lbl1 = new Label();
                lbl1.Text = ObjLstViewRegionFldsEx.HeaderText;
                //lbl1.Font.Name = "verdana";
                //lbl1.Font.Size = FontUnit.Parse("x-small");
                lbl1.CssClass = "NameLabel";
                lbl1.Font.Bold = true;
                lbl1.Width = 60;
                cell1 = new TableCell();//创建单元格,也就是第一列
                cell1.Controls.Add(lbl1);
                tr.Cells.Add(cell1);
                intIndex++;
            }
            tb.Rows.Add(tr);//添加到表格中
            for (int i = 0; i < 5; i++)
            {
                tr = new TableRow();//创建一行
                intIndex = 1;
                int intFldNum = objViewInfoENEx.arrDGRegionFldSet.Count;
                for (int j = 0; j < intFldNum; j++)
                {
                    //字段名(列名)
                    lbl1 = new Label();
                    lbl1.Text = intIndex.ToString();
                    //lbl1.Font.Name = "verdana";
                    //lbl1.Font.Size = FontUnit.Parse("x-small");
                    lbl1.CssClass = "NameLabel";
                    lbl1.Width = 60;
                    cell1 = new TableCell();//创建单元格,也就是第一列
                    cell1.Controls.Add(lbl1);
                    tr.Cells.Add(cell1);
                    intIndex++;
                }
                tb.Rows.Add(tr);//添加到表格中
            }

            phListViewRegion.Controls.Add(objTable);
            phListViewRegion.Controls.Add(tb);
            return true;
        }
        //显示预览查询区域的控件
        public static int DispQryRegionCtrl(System.Web.UI.WebControls.PlaceHolder phQryRegion, clsViewInfoENEx objViewInfoENEx)
        {
            int intRow = 0, intCol = 0; //当前行,当前列
            int iCtlNum = 0;
            Table tb = new Table();//创建一个表格

            tb.BorderWidth = Unit.Parse("4");
            tb.BorderColor = System.Drawing.Color.BurlyWood;
            tb.Width = Unit.Parse("100%");

            TableRow tr;
            TableCell cell1;//, cell2;
                            //System.Web.UI.WebControls.Label lbl1;
                            //System.Web.UI.WebControls.CheckBox chk1;
                            //System.Web.UI.WebControls.TextBox txt1;
                            //System.Web.UI.WebControls.DropDownList ddl1;
            System.Web.UI.WebControls.Button btn1;
            int intColNum = objViewInfoENEx.objViewRegion_Query.ColNum ?? 0;//该区域定义的列数
            tr = new TableRow();//创建一行
            //bool bolIsEndRow = false;
            foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
            {
                if (intCol == intColNum)
                {
                    cell1 = new TableCell();//创建单元格,也就是第一列

                    tr.Cells.Add(cell1);
                    intCol++;

                    intRow++;
                    tb.Rows.Add(tr);//添加到表格中

                    tr = new TableRow();//创建一行
                    intCol = 0;
                    //bolIsEndRow = false;
                }
                wccFieldGroup wcc = new wccFieldGroup();
                wcc.Caption = objQryRegionFldsEx.LabelCaption;
                wcc.wccfg_CaptionCss = "NameLabel";
                wcc.wccfg_TextBoxCss = "TextBox_Defa";
                wcc.wccfg_LinkButtonCss = "lkbtn";
                wcc.Attributes.Add("DelThisCtrlClick", "wccFieldGroup2_DelThisCtrlClick");
                //wcc.DelThisCtrlClick += new EventHandler(wccFieldGroup2_DelThisCtrlClick);
                wcc.CtlTypeName = objQryRegionFldsEx.objCtlType.CtlTypeName;
                cell1 = new TableCell();//创建单元格,也就是第一列
                cell1.Controls.Add(wcc);
                tr.Cells.Add(cell1);
                intCol++;


                iCtlNum++;
            }
            //为最后一行添加单元格,使最后单元格不缺
            while (intCol < intColNum)
            {
                cell1 = new TableCell();//创建单元格,也就是第一列

                tr.Cells.Add(cell1);
                intCol++;
            }

            //if (bolIsEndRow == false)
            //{
            //  intRow++;
            //  tb.Rows.Add(tr);//添加到表格中
            //}
            //tr = new TableRow();//创建一行

            btn1 = new Button();
            btn1.Text = "查询";
            //btn1.Font.Name = "verdana";
            //btn1.Font.Size = FontUnit.Parse("x-small");
            btn1.CssClass = "btn btn-primary btn-sm";
            btn1.Width = 80;
            cell1 = new TableCell();//创建单元格,也就是第一列
            cell1.Controls.Add(btn1);
            tr.Cells.Add(cell1);
            tb.Rows.Add(tr);//添加到表格中
            intRow++;
            ///生成查询按钮的代码;
            //			strCodeForCs.Append("\r\n" + GenButton(objButtonStyle,"btnQuery","查询"));
            phQryRegion.Controls.Add(tb);


            return intRow;
        }
        //显示预览<详细信息区域>的控件
        public static bool DispDetailRegionCtrl(System.Web.UI.WebControls.PlaceHolder phDetailRegion, clsViewInfoENEx objViewInfoENEx)
        {

            Table tb = new Table();//创建一个表格

            tb.BorderWidth = Unit.Parse("4");
            tb.BorderColor = System.Drawing.Color.BurlyWood;
            tb.Width = Unit.Parse("100%");
            int iCtlNum = 0;
            TableRow tr;
            TableCell cell1, cell2;
            System.Web.UI.WebControls.Label lbl1;
            System.Web.UI.WebControls.CheckBox chk1;
            System.Web.UI.WebControls.TextBox txt1;
            System.Web.UI.WebControls.DropDownList ddl1;
            System.Web.UI.WebControls.Button btn1;
            int intColNum = objViewInfoENEx.objViewRegion_Query.ColNum ?? 0;
            tr = new TableRow();//创建一行
            bool bolIsEndRow = false;
            foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
            {
                if (iCtlNum % (intColNum * 2) == 0)
                {
                    tr = new TableRow();//创建一行
                    bolIsEndRow = false;
                }

                switch (objQryRegionFldsEx.objCtlType.CtlTypeName)
                {
                    case "CheckBox":
                        chk1 = new CheckBox();
                        chk1.Text = objQryRegionFldsEx.LabelCaption;
                        //chk1.Font.Name = "verdana";
                        //chk1.Font.Size = FontUnit.Parse("x-small");
                        chk1.CssClass = "Check_Defa";
                        chk1.Width = 100;
                        cell1 = new TableCell();//创建单元格,也就是第一列
                        cell1.Controls.Add(chk1);
                        tr.Cells.Add(cell1);
                        iCtlNum++;
                        cell2 = new TableCell();//创建单元格,也就是第一列
                        cell1.Text = "";
                        tr.Cells.Add(cell2);

                        break;
                    case "TextBox":
                        lbl1 = new Label();
                        lbl1.Text = objQryRegionFldsEx.LabelCaption;
                        //lbl1.Font.Name = "verdana";
                        //lbl1.Font.Size = FontUnit.Parse("x-small");
                        lbl1.CssClass = "Label_Defa";
                        lbl1.Width = 60;
                        cell1 = new TableCell();//创建单元格,也就是第一列
                        cell1.Controls.Add(lbl1);
                        tr.Cells.Add(cell1);
                        iCtlNum++;
                        txt1 = new TextBox();
                        txt1.Text = "";
                        //txt1.Font.Name = "verdana";
                        //txt1.Font.Size = FontUnit.Parse("x-small");
                        txt1.CssClass = "TextBox_Defa";
                        txt1.Width = 60;
                        cell2 = new TableCell();//创建单元格,也就是第一列
                        cell2.Controls.Add(txt1);
                        tr.Cells.Add(cell2);
                        break;
                    case "DropDownList":
                        lbl1 = new Label();
                        lbl1.Text = objQryRegionFldsEx.LabelCaption;
                        //lbl1.Font.Name = "verdana";
                        //lbl1.Font.Size = FontUnit.Parse("x-small");
                        lbl1.CssClass = "NameLabel";
                        lbl1.Width = 60;
                        cell1 = new TableCell();//创建单元格,也就是第一列
                        cell1.Controls.Add(lbl1);
                        tr.Cells.Add(cell1);
                        iCtlNum++;
                        ddl1 = new DropDownList();
                        //							ddl1.Text = "";
                        //ddl1.Font.Name = "verdana";
                        //ddl1.Font.Size = FontUnit.Parse("x-small");
                        ddl1.CssClass = "DropDown_Defa";
                        ddl1.Width = 60;
                        cell2 = new TableCell();//创建单元格,也就是第一列
                        cell2.Controls.Add(ddl1);
                        tr.Cells.Add(cell2);
                        break;

                    default:
                        lbl1 = new Label();
                        lbl1.Text = objQryRegionFldsEx.LabelCaption;
                        //lbl1.Font.Name = "verdana";
                        //lbl1.Font.Size = FontUnit.Parse("x-small");
                        lbl1.CssClass = "NameLabel";
                        lbl1.Width = 60;
                        cell1 = new TableCell();//创建单元格,也就是第一列
                        cell1.Controls.Add(lbl1);
                        tr.Cells.Add(cell1);
                        iCtlNum++;
                        txt1 = new TextBox();
                        txt1.Text = "";
                        //txt1.Font.Name = "verdana";
                        //txt1.Font.Size = FontUnit.Parse("x-small");
                        txt1.CssClass = "TextBox_Defa";
                        txt1.Width = 60;
                        cell2 = new TableCell();//创建单元格,也就是第一列
                        cell2.Controls.Add(txt1);
                        tr.Cells.Add(cell2);
                        break;
                }

                if (iCtlNum % (intColNum * 2) == (intColNum * 2 - 1))
                {
                    tb.Rows.Add(tr);//添加到表格中
                    bolIsEndRow = true;
                }
                iCtlNum++;
            }

            if (bolIsEndRow == false)
            {
                tb.Rows.Add(tr);//添加到表格中
            }
            tr = new TableRow();//创建一行
                                //空几个单元格
            for (int i = 0; i < intColNum * 2 - 1; i++)
            {
                cell1 = new TableCell();//创建单元格,也就是第一列
                tr.Cells.Add(cell1);
            }
            btn1 = new Button();
            btn1.Text = "关闭";
            //btn1.Font.Name = "verdana";
            //btn1.Font.Size = FontUnit.Parse("x-small");
            btn1.CssClass = "btn btn-primary btn-sm";
            btn1.Width = 80;
            cell1 = new TableCell();//创建单元格,也就是第一列
            cell1.Controls.Add(btn1);
            tr.Cells.Add(cell1);
            tb.Rows.Add(tr);//添加到表格中
                            ///生成查询按钮的代码;
            //			strCodeForCs.Append("\r\n" + GenButton(objButtonStyle,"btnQuery","查询"));
            phDetailRegion.Controls.Add(tb);


            return true;
        }
        public void A_GeneFuncCode(string strFuncName, clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs, string strPageName)
        {
            try
            {
                switch (strFuncName)
                {
                    case "BindDdlInTaskQueue":
                        Gen_BindDdlInTaskQueue(objViewInfoENEx, strCodeForCs);
                        break;

                    case "onCreate":
                        Gen_onCreate(objViewInfoENEx, strCodeForCs);
                        break;
                    case "FieldVarDef4Query":
                        Gen_FieldVarDef4Query(objViewInfoENEx, strCodeForCs);
                        break;
                    case "FieldVarDef4Edit":
                        Gen_FieldVarDef4Edit(objViewInfoENEx, strCodeForCs);
                        break;
                    case "btnAddNewRecord_Click":
                        Gen_btnAddNewRecord_Click(objViewInfoENEx, strCodeForCs);
                        break;
                    case "btnCancel_Click":
                        Gen_btnCancel_Click(objViewInfoENEx, strCodeForCs);
                        break;
                    case "btnPageIndexChanged_Click":
                        Gen_btnPageIndexChanged_Click(objViewInfoENEx, strCodeForCs);
                        break;
                        
                    case "btnDelRecordsByJSON_Click":
                        Gen_btnDelRecordsByJSON_Click(objViewInfoENEx, strCodeForCs, objViewInfoENEx.TabName_In);
                        break;
                    case "AddNewRecord":
                        Gen_AddNewRecord(objViewInfoENEx, strCodeForCs, objViewInfoENEx.TabName_In);
                        break;
                    case "ShowEditRegion":
                        Gen_ShowEditRegion(objViewInfoENEx, strCodeForCs);
                        break;
                    case "ShowListViewRegion":
                        Gen_ShowListViewRegion(objViewInfoENEx, strCodeForCs, objViewInfoENEx.TabName_Out);
                        break;
                    case "FieldProperty4Edit":
                        Gen_FieldProperty4Edit(objViewInfoENEx, strCodeForCs);
                        break;
                    case "UpdateRecord":
                        Gen_UpdateRecord(objViewInfoENEx, strCodeForCs, objViewInfoENEx.TabName_In);
                        break;
                    case "Class4DelRecordsByJSONEx":
                        Gen_Class4DelRecordsByJSONEx(objViewInfoENEx, strCodeForCs);
                        break;
                    case "btnQuery_Click":
                        Gen_btnQuery_Click(objViewInfoENEx, strCodeForCs);
                        break;
                    case "BindLv_TabName":
                        Gen_BindLv_TabName(objViewInfoENEx, strCodeForCs, objViewInfoENEx.TabName_Out);
                        break;
                    case "Class4AddNewRecord4GetMaxStrIdEx":
                        Gen_Class4AddNewRecord4GetMaxStrIdEx(objViewInfoENEx, strCodeForCs);
                        break;
                    case "Class4GetMaxStrIdEx":
                        Gen_Class4GetMaxStrIdEx(objViewInfoENEx, strCodeForCs, objViewInfoENEx.TabName_In);
                        break;
                    case "Class4AddNewRecordEx":
                        Gen_Class4AddNewRecordEx(objViewInfoENEx, strCodeForCs);
                        break;
                    case "btnGetJSONObjByKey_Click":
                        Gen_btnGetJSONObjByKey_Click(objViewInfoENEx, strCodeForCs, objViewInfoENEx.TabName_In);
                        break;
                    case "HideEditRegion":
                        Gen_HideEditRegion(objViewInfoENEx, strCodeForCs);
                        break;
                    case "HideListViewRegion":
                        Gen_HideListViewRegion(objViewInfoENEx, strCodeForCs, objViewInfoENEx.TabName_Out);
                        break;
                    case "GetDataFromClass":
                        Gen_GetDataFromClass(objViewInfoENEx, strCodeForCs);
                        break;
                    case "PutDataToClass":
                        Gen_PutDataToClass(objViewInfoENEx, strCodeForCs);
                        break;
                    case "btnOkUpd_Click":
                        Gen_btnOkUpd_Click(objViewInfoENEx, strCodeForCs, objViewInfoENEx.TabName_In);
                        break;
                   
                    case "Class4GetObjByKeyIdEx":
                        Gen_Class4GetObjByKeyIdEx(objViewInfoENEx, strCodeForCs);
                        break;
                    case "Class4UpdateRecordEx":
                        Gen_Class4UpdateRecordEx(objViewInfoENEx, strCodeForCs);
                        break;
                    case "btnShowQuery_Click":
                        Gen_btnShowQuery_Click(objViewInfoENEx, strCodeForCs);
                        break;
                    case "ShowQueryRegion":
                        Gen_ShowQueryRegion(objViewInfoENEx, strCodeForCs);
                        break;
                    case "HideQueryRegion":
                        Gen_HideQueryRegion(objViewInfoENEx, strCodeForCs);
                        break;
                    case "CombineTabNameCondition":
                        Gen_CombineCondition(objViewInfoENEx, strCodeForCs);
                        break;
                    case "FieldProperty4Query":
                        Gen_FieldProperty4Query(objViewInfoENEx, strCodeForCs);
                        break;
                    case "Class4GetJSONObjLstEx":
                        Gen_Class4GetJSONObjLstEx(objViewInfoENEx, strCodeForCs, objViewInfoENEx.TabName_Out);
                        break;
                    case "FieldVarDef4List":
                        Gen_FieldVarDef4List(objViewInfoENEx, strCodeForCs);
                        break;
                    case "Class4GetJSONObjLstByPagerEx":
                        Gen_Class4GetJSONObjLstByPagerEx(objViewInfoENEx, strCodeForCs, objViewInfoENEx.TabName_Out, strPageName);
                        break;
                    case "ClearEditRegion":
                        Gen_ClearEditRegion(objViewInfoENEx, strCodeForCs);
                        break;
                    case "Class4GetRecCountByCondEx":
                        Gen_Class4GetRecCountByCondEx(objViewInfoENEx, strCodeForCs, objViewInfoENEx.TabName_Out);
                        break;
                    case "GetRecCountByCond":
                        Gen_GetRecCountByCond(objViewInfoENEx, strCodeForCs, objViewInfoENEx.TabName_Out);
                        break;
                    case "btnCancelQuery_Click":
                        Gen_btnCancelQuery_Click(objViewInfoENEx, strCodeForCs);
                        break;
                    case "AddTask":
                        Gen_AddTask(objViewInfoENEx, strCodeForCs);
                        break;

                    case "Gen_AppView_Java_onCreate":
                        Gen_onCreate(objViewInfoENEx, strCodeForCs);
                        break;
                    case "Gen_AppView_Java_FieldVarDef4Query":
                        Gen_FieldVarDef4Query(objViewInfoENEx, strCodeForCs);
                        break;
                    case "Gen_AppView_Java_FieldVarDef4Edit":
                        Gen_FieldVarDef4Edit(objViewInfoENEx, strCodeForCs);
                        break;
                    case "Gen_AppView_Java_btnAddNewRecord_Click":
                        Gen_btnAddNewRecord_Click(objViewInfoENEx, strCodeForCs);
                        break;
                    case "Gen_AppView_Java_btnCancel_Click":
                        Gen_btnCancel_Click(objViewInfoENEx, strCodeForCs);
                        break;
                    case "Gen_AppView_Java_btnPageIndexChanged_Click":
                        Gen_btnPageIndexChanged_Click(objViewInfoENEx, strCodeForCs);
                        break;

                    case "Gen_AppView_Java_btnDelRecordsByJSON_Click":
                        Gen_btnDelRecordsByJSON_Click(objViewInfoENEx, strCodeForCs, objViewInfoENEx.TabName_In);
                        break;
                    case "Gen_AppView_Java_AddNewRecord":
                        Gen_AddNewRecord(objViewInfoENEx, strCodeForCs, objViewInfoENEx.TabName_In);
                        break;
                    case "Gen_AppView_Java_ShowEditRegion":
                        Gen_ShowEditRegion(objViewInfoENEx, strCodeForCs);
                        break;
                    case "Gen_AppView_Java_ShowListViewRegion":
                        Gen_ShowListViewRegion(objViewInfoENEx, strCodeForCs, objViewInfoENEx.TabName_Out);
                        break;
                    case "Gen_AppView_Java_FieldProperty4Edit":
                        Gen_FieldProperty4Edit(objViewInfoENEx, strCodeForCs);
                        break;
                    case "Gen_AppView_Java_UpdateRecord":
                        Gen_UpdateRecord(objViewInfoENEx, strCodeForCs, objViewInfoENEx.TabName_In);
                        break;
                    case "Gen_AppView_Java_Class4DelRecordsByJSONEx":
                        Gen_Class4DelRecordsByJSONEx(objViewInfoENEx, strCodeForCs);
                        break;
                    case "Gen_AppView_Java_btnQuery_Click":
                        Gen_btnQuery_Click(objViewInfoENEx, strCodeForCs);
                        break;
                    case "Gen_AppView_Java_BindLv_TabName":
                        Gen_BindLv_TabName(objViewInfoENEx, strCodeForCs, objViewInfoENEx.TabName_Out);
                        break;
                    case "Gen_AppView_Java_Class4AddNewRecord4GetMaxStrIdEx":
                        Gen_Class4AddNewRecord4GetMaxStrIdEx(objViewInfoENEx, strCodeForCs);
                        break;
                    case "Gen_AppView_Java_Class4GetMaxStrIdEx":
                        Gen_Class4GetMaxStrIdEx(objViewInfoENEx, strCodeForCs, objViewInfoENEx.TabName_In);
                        break;
                    case "Gen_AppView_Java_Class4AddNewRecordEx":
                        Gen_Class4AddNewRecordEx(objViewInfoENEx, strCodeForCs);
                        break;
                    case "Gen_AppView_Java_btnGetJSONObjByKey_Click":
                        Gen_btnGetJSONObjByKey_Click(objViewInfoENEx, strCodeForCs, objViewInfoENEx.TabName_In);
                        break;
                    case "Gen_AppView_Java_HideEditRegion":
                        Gen_HideEditRegion(objViewInfoENEx, strCodeForCs);
                        break;
                    case "Gen_AppView_Java_HideListViewRegion":
                        Gen_HideListViewRegion(objViewInfoENEx, strCodeForCs, objViewInfoENEx.TabName_Out);
                        break;
                    case "Gen_AppView_Java_GetDataFromClass":
                        Gen_GetDataFromClass(objViewInfoENEx, strCodeForCs);
                        break;
                    case "Gen_AppView_Java_PutDataToClass":
                        Gen_PutDataToClass(objViewInfoENEx, strCodeForCs);
                        break;
                    case "Gen_AppView_Java_btnOkUpd_Click":
                        Gen_btnOkUpd_Click(objViewInfoENEx, strCodeForCs, objViewInfoENEx.TabName_In);
                        break;

                    case "Gen_AppView_Java_Class4GetObjByKeyIdEx":
                        Gen_Class4GetObjByKeyIdEx(objViewInfoENEx, strCodeForCs);
                        break;
                    case "Gen_AppView_Java_Class4ExecTaskEx":
                        Gen_Class4ExecTaskEx(objViewInfoENEx, strCodeForCs);
                        break;
                    case "Gen_AppView_Java_Class4UpdateRecordEx":
                        Gen_Class4UpdateRecordEx(objViewInfoENEx, strCodeForCs);
                        break;
                    case "Gen_AppView_Java_btnShowQuery_Click":
                        Gen_btnShowQuery_Click(objViewInfoENEx, strCodeForCs);
                        break;
                    case "Gen_AppView_Java_ShowQueryRegion":
                        Gen_ShowQueryRegion(objViewInfoENEx, strCodeForCs);
                        break;
                    case "Gen_AppView_Java_HideQueryRegion":
                        Gen_HideQueryRegion(objViewInfoENEx, strCodeForCs);
                        break;
                    case "Gen_AppView_Java_CombineTabNameCondition":
                        Gen_CombineCondition(objViewInfoENEx, strCodeForCs);
                        break;
                    case "Gen_AppView_Java_FieldProperty4Query":
                        Gen_FieldProperty4Query(objViewInfoENEx, strCodeForCs);
                        break;
                    case "Gen_AppView_Java_Class4GetJSONObjLstEx":
                        Gen_Class4GetJSONObjLstEx(objViewInfoENEx, strCodeForCs, objViewInfoENEx.TabName_Out);
                        break;
                    case "Gen_AppView_Java_FieldVarDef4List":
                        Gen_FieldVarDef4List(objViewInfoENEx, strCodeForCs);
                        break;
                    case "Gen_AppView_Java_Class4GetJSONObjLstByPagerEx":
                        Gen_Class4GetJSONObjLstByPagerEx(objViewInfoENEx, strCodeForCs, objViewInfoENEx.TabName_Out, strPageName);
                        break;
                    case "Gen_AppView_Java_ClearEditRegion":
                        Gen_ClearEditRegion(objViewInfoENEx, strCodeForCs);
                        break;
                    case "Gen_AppView_Java_Class4GetRecCountByCondEx":
                        Gen_Class4GetRecCountByCondEx(objViewInfoENEx, strCodeForCs, objViewInfoENEx.TabName_Out);
                        break;
                    case "Gen_AppView_Java_GetRecCountByCond":
                        Gen_GetRecCountByCond(objViewInfoENEx, strCodeForCs, objViewInfoENEx.TabName_Out);
                        break;
                    case "Gen_AppView_Java_btnCancelQuery_Click":
                        Gen_btnCancelQuery_Click(objViewInfoENEx, strCodeForCs);
                        break;
                    case "Gen_AppView_Java_AddTask":
                        Gen_AddTask(objViewInfoENEx, strCodeForCs);
                        break;
                    case "Gen_AppView_Java_btnGetJSONObjLst_Click":
                        Gen_btnGetJSONObjLst_Click(objViewInfoENEx, strCodeForCs, objViewInfoENEx.TabName_Out);
                        break;
                    case "Gen_AppView_Java_icls[TabName]_AddNewRecord":
                        Gen_Class4AddNewRecordEx(objViewInfoENEx, strCodeForCs);
                        break;
                    case "Gen_AppView_Java_icls[TabName]_UpdateRecord":
                        Gen_Class4UpdateRecordEx(objViewInfoENEx, strCodeForCs);
                        break;



                    case "Dispose":
                        
                        break;
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

        public void InitQueryRegion()
        {
            if (objViewInfoENEx.arrQryRegionFldSet == null || objViewInfoENEx.arrQryRegionFldSet.Count == 0)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有[查询]区域,或者[查询]区域没有字段。请检查!", strViewName);
                throw new clsDbObjException(sbMessage.ToString());
            }

            //			string strTemp ;     ///临时变量;
            //判断DataGrid是否需要排序
            //strCodeForCs.Append("\r\n" + "//查询区域中的输入控件:");
            if (arrCtrlLst4Query == null)
            {
                arrCtrlLst4Query = new List<AndroidControlEx>();
            }

            AndroidConstraintLayoutEx objAndroidConstraintLayoutENEx = new AndroidConstraintLayoutEx();
            objAndroidConstraintLayoutENEx.CtrlId = string.Format("clQuery", objViewInfoENEx.TabName_Out);
            objAndroidConstraintLayoutENEx.layout_width = "match_parent";
            objAndroidConstraintLayoutENEx.layout_height = "wrap_content";

            arrCtrlLst4Query.Add(objAndroidConstraintLayoutENEx);
            foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
            {
                AndroidControlEx objAndroidControlENEx = clsAndroidControlBLEx.GetAndroidControlObjByQryFld(objQryRegionFldsEx);
                arrCtrlLst4Query.Add(objAndroidControlENEx);
            }

        }
      
        public void Gen_FieldVarDef4Query(clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs)
        {

            if (arrCtrlLst4Query == null)
            {
                InitQueryRegion();
            }
            if (arrCtrlLst4Query.Count == 0)
            {
                return;
            }

            //			string strTemp ;     ///临时变量;
            //判断DataGrid是否需要排序
            strCodeForCs.Append("\r\n" + "//查询区域中的输入控件:");

            foreach (AndroidControlEx objAndroidControlENEx in arrCtrlLst4Query)
            {
                clsAndroidControlBLEx.Gen_FieldVarDef(objAndroidControlENEx, strCodeForCs);
            }     
        }
        public void InitEditRegion()
        {
            if (objViewInfoENEx.arrEditRegionFldSet4InUse == null || objViewInfoENEx.arrEditRegionFldSet4InUse.Count == 0)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有[编辑]区域,或者[编辑]区域没有字段。请检查!", strViewName);
                throw new clsDbObjException(sbMessage.ToString());
            }

            //			string strTemp ;     ///临时变量;
            //判断DataGrid是否需要排序
            if (arrCtrlLst4Edit == null)
            {
                arrCtrlLst4Edit = new List<AndroidControlEx>();
            }

            AndroidLinearLayoutEx objAndroidLinearLayoutENEx = new AndroidLinearLayoutEx();
            objAndroidLinearLayoutENEx.CtrlId = string.Format("llEdit", objViewInfoENEx.TabName_Out);
            objAndroidLinearLayoutENEx.layout_width = "match_parent";
            objAndroidLinearLayoutENEx.layout_height = "wrap_content";

            arrCtrlLst4Edit.Add(objAndroidLinearLayoutENEx);

            //strCodeForCs.Append("\r\n" + "//编辑区域中的输入控件:");
            foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
            {
                AndroidControlEx objAndroidControlENEx = clsAndroidControlBLEx.GetAndroidControlObjByEditFld(objEditRegionFldsEx);
                arrCtrlLst4Edit.Add(objAndroidControlENEx);
            }
        }

        public void Gen_FieldVarDef4Edit(clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs)
        {
            if (arrCtrlLst4Edit == null)
            {
                InitEditRegion();
            }
            if (arrCtrlLst4Edit.Count == 0)
            {
                return;
            }

            //			string strTemp ;     ///临时变量;
            //判断DataGrid是否需要排序

            strCodeForCs.Append("\r\n" + "//编辑区域中的输入控件:");
            foreach (AndroidControlEx objAndroidControlENEx in arrCtrlLst4Edit)
            {
                clsAndroidControlBLEx.Gen_FieldVarDef(objAndroidControlENEx, strCodeForCs);
            }
        }

        public void Gen_BindDdl(clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs)
        {
            if (arrCtrlLst4Edit == null)
            {
                InitEditRegion();
            }
            if (arrCtrlLst4Edit.Count == 0)
            {
                return;
            }

            //			string strTemp ;     ///临时变量;
            //判断DataGrid是否需要排序

            strCodeForCs.Append("\r\n" + "//绑定编辑区域中的下拉框控件:");
            foreach (AndroidControlEx objAndroidControlENEx in arrCtrlLst4Edit)
            {
                clsAndroidControlBLEx.Gen_BindDdl(objAndroidControlENEx, objViewInfoENEx, strCodeForCs);
            }
            strCodeForCs.Append("\r\n" + "//绑定查询区域中的下拉框控件:");
            if (arrCtrlLst4Query == null)
            {
                InitQueryRegion();
            }
            foreach (AndroidControlEx objAndroidControlENEx in arrCtrlLst4Query)
            {
                clsAndroidControlBLEx.Gen_BindDdl(objAndroidControlENEx, objViewInfoENEx, strCodeForCs);
            }

        }

        public void Gen_BindDdlInTaskQueue(clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs)
        {
            if (arrCtrlLst4Edit == null)
            {
                InitEditRegion();
            }
            if (arrCtrlLst4Edit.Count == 0)
            {
                return;
            }

            //			string strTemp ;     ///临时变量;
            //判断DataGrid是否需要排序

            strCodeForCs.Append("\r\n" + "//绑定编辑区域中的下拉框控件:");
            foreach (AndroidControlEx objAndroidControlENEx in arrCtrlLst4Edit)
            {
                //AndroidSpinnerEx objAndroidSpinnerENEx = objAndroidControlENEx as AndroidControlEx;
                //string strTabName_Ddl = objAndroidSpinnerENEx.objEditRegionFldsEx.objPrjTabFldENEx.ObjFieldTabENEx.CodeTabName;

               
                clsAndroidControlBLEx.Gen_BindDdlInTaskQueue(objAndroidControlENEx, objViewInfoENEx, strCodeForCs);
            }
            strCodeForCs.Append("\r\n" + "//绑定查询区域中的下拉框控件:");
            if (arrCtrlLst4Query == null)
            {
                InitQueryRegion();
            }
            foreach (AndroidControlEx objAndroidControlENEx in arrCtrlLst4Query)
            {
                clsAndroidControlBLEx.Gen_BindDdlInTaskQueue(objAndroidControlENEx, objViewInfoENEx, strCodeForCs);
            }
        }


        public void Gen_DefDdlBindObj(clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs, List<string> arrDdlBindObjLst)
        {
            if (arrCtrlLst4Edit == null)
            {
                InitEditRegion();
            }
            if (arrCtrlLst4Edit.Count == 0)
            {
                return;
            }

            //			string strTemp ;     ///临时变量;
            //判断DataGrid是否需要排序

            strCodeForCs.Append("\r\n" + "//绑定编辑区域中的下拉框控件:");
            foreach (AndroidControlEx objAndroidControlENEx in arrCtrlLst4Edit)
            {
                clsAndroidControlBLEx.Gen_DefDdlBindObj(objAndroidControlENEx, strCodeForCs, arrDdlBindObjLst);
            }
            strCodeForCs.Append("\r\n" + "//绑定查询区域中的下拉框控件:");
            foreach (AndroidControlEx objAndroidControlENEx in arrCtrlLst4Query)
            {
                clsAndroidControlBLEx.Gen_DefDdlBindObj(objAndroidControlENEx, strCodeForCs, arrDdlBindObjLst);
            }

        }

        public List<string> GetDdlBindTableLst(StringBuilder strCodeForCs)
        {
            List<string> arrDdlBindTableLst = new List<string>();
            if (arrCtrlLst4Edit == null || arrCtrlLst4Edit.Count == 0)
            {
                return arrDdlBindTableLst;
            }

            //			string strTemp ;     ///临时变量;
            //判断DataGrid是否需要排序

//            strCodeForCs.Append("\r\n" + "//绑定编辑区域中的下拉框控件:");
            foreach (AndroidControlEx objAndroidControlENEx in arrCtrlLst4Edit)
            {
                if (objAndroidControlENEx.objEditRegionFldsEN == null) continue;
                string strTabName = objAndroidControlENEx.objEditRegionFldsEN.ObjFieldTab_PC().CodeTabName();
                if (string.IsNullOrEmpty(strTabName) == true) continue;
                if (arrDdlBindTableLst.Contains(strTabName) == false) arrDdlBindTableLst.Add(strTabName);
            }
//            strCodeForCs.Append("\r\n" + "//绑定查询区域中的下拉框控件:");
            foreach (AndroidControlEx objAndroidControlENEx in arrCtrlLst4Query)
            {
                if (objAndroidControlENEx.objQryRegionFldsEN == null) continue;
                string strTabName = objAndroidControlENEx.objQryRegionFldsEN.ObjFieldTab_PC().CodeTabName();
                if (string.IsNullOrEmpty(strTabName) == true) continue;
                if (arrDdlBindTableLst.Contains(strTabName) == false) arrDdlBindTableLst.Add(strTabName);
            }
            return arrDdlBindTableLst;
        }

        public void Gen_FieldVarDef4List(clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs)
        {
            if (objViewInfoENEx.arrDGRegionFldSet == null || objViewInfoENEx.arrDGRegionFldSet.Count == 0)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有[列表]区域,或者[列表]区域没有字段。请检查!", strViewName);
                throw new clsDbObjException(sbMessage.ToString());
            }

            //			string strTemp ;     ///临时变量;
            //判断DataGrid是否需要排序

            strCodeForCs.Append("\r\n" + "//列表区域中的显示控件:");
            if (arrCtrlLst4List == null)
            {
                InitListRegion();
            }
            foreach (AndroidControlEx objAndroidControlENEx in arrCtrlLst4List)
            {
                clsAndroidControlBLEx.Gen_FieldVarDef(objAndroidControlENEx, strCodeForCs);
            }
            strCodeForCs.AppendFormat("\r\n" + "private List<cls{0}EN> arr{0}ENLst = new ArrayList<cls{0}EN>();",
                objViewInfoENEx.TabName_Out);

        }

        public void Gen_FieldVarDef4ListView(clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs)
        {
            if (objViewInfoENEx.arrDGRegionFldSet == null || objViewInfoENEx.arrDGRegionFldSet.Count == 0)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有[列表]区域,或者[列表]区域没有字段。请检查!", strViewName);
                throw new clsDbObjException(sbMessage.ToString());
            }

            //			string strTemp ;     ///临时变量;
            //判断DataGrid是否需要排序

            strCodeForCs.Append("\r\n" + "//列表区域中的显示控件:");
            foreach (AndroidControlEx objAndroidControlENEx in arrCtrlLst4ListView)
            {
                clsAndroidControlBLEx.Gen_FieldVarDef(objAndroidControlENEx, strCodeForCs);
            }
            //strCodeForCs.AppendFormat("\r\n" + "private List<cls{0}EN> arr{0}ENLst = new ArrayList<cls{0}EN>();",
            //    objViewInfoENEx.TabName_Out);

        }

        /// <summary>
        /// 初始化列表区域
        /// </summary>
        /// <param name="objViewInfoENEx"></param>
        /// <param name="strCodeForCs"></param>
        public void InitListRegion()
        {
            if (objViewInfoENEx.arrDGRegionFldSet == null || objViewInfoENEx.arrDGRegionFldSet.Count == 0)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有[列表]区域,或者[列表]区域没有字段。请检查!", strViewName);
                throw new clsDbObjException(sbMessage.ToString());
            }

            //			string strTemp ;     ///临时变量;
            //判断DataGrid是否需要排序

            //strCodeForCs.Append("\r\n" + "//列表区域中的输入控件:");
            if (arrCtrlLst4List == null)
            {
                arrCtrlLst4List = new List<AndroidControlEx>();
            }
            AndroidConstraintLayoutEx objAndroidConstraintLayoutENEx = new AndroidConstraintLayoutEx();
            objAndroidConstraintLayoutENEx.CtrlId = string.Format("clListView", objViewInfoENEx.TabName_Out);
            objAndroidConstraintLayoutENEx.layout_width = "200dp";
            objAndroidConstraintLayoutENEx.layout_height = "wrap_content";
            //objAndroidConstraintLayoutENEx.objDGRegionFldsENEx = objDGRegionFldsEx;
            arrCtrlLst4List.Add(objAndroidConstraintLayoutENEx);

            AndroidListViewEx objAndroidListViewENEx = new AndroidListViewEx();
            objAndroidListViewENEx.CtrlId = string.Format("lv{0}", objViewInfoENEx.TabName_Out);
            objAndroidListViewENEx.layout_width = "200dp";
            objAndroidListViewENEx.layout_height = "wrap_content";
            //objAndroidListViewENEx.objDGRegionFldsENEx = objDGRegionFldsEx;
            arrCtrlLst4List.Add(objAndroidListViewENEx);
            AndroidHorizontalScrollViewEx objAndroidHorizontalScrollViewENEx = new AndroidHorizontalScrollViewEx();
            objAndroidHorizontalScrollViewENEx.CtrlId = string.Format("hsv{0}", objViewInfoENEx.TabName_Out);
            objAndroidHorizontalScrollViewENEx.layout_width = "match_parent";
            objAndroidHorizontalScrollViewENEx.layout_height = "400dp";
            //objAndroidHorizontalScrollViewENEx.objDGRegionFldsENEx = objDGRegionFldsEx;
            arrCtrlLst4List.Add(objAndroidHorizontalScrollViewENEx);
            AndroidTextViewEx objAndroidTextViewENEx = new AndroidTextViewEx();
            objAndroidTextViewENEx.CtrlId = "tvPageStatus";
            objAndroidTextViewENEx.Text = "总共0页";
            objAndroidTextViewENEx.Style = "tvStyle4MsgInListView";
            objAndroidTextViewENEx.layout_width = "wrap_content";
            objAndroidTextViewENEx.layout_height = "wrap_content";
            objAndroidTextViewENEx.layout_marginLeft = 8;
            objAndroidTextViewENEx.layout_marginTop = 8;
            objAndroidTextViewENEx.layout_constraintLeft_toRightOf = "@+id/btnLastPage";
            objAndroidTextViewENEx.layout_constraintTop_toTopOf = "parent";
            arrCtrlLst4List.Add(objAndroidTextViewENEx);

            if (arrCtrlLst4ListView == null)
            {
                arrCtrlLst4ListView = new List<AndroidControlEx>();
            }

          
            //strCodeForCs.Append("\r\n" + "//编辑区域中的输入控件:");
            foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
            {
                AndroidControlEx objAndroidControlENEx = clsAndroidControlBLEx.GetAndroidTextViewObjByDGFld(objDGRegionFldsEx);
                arrCtrlLst4ListView.Add(objAndroidControlENEx);
            }

        }
     
        public void Gen_FieldVarBind4Edit(clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs)
        {
            if (arrCtrlLst4Edit == null || arrCtrlLst4Edit.Count == 0)
            {
                return;
            }

            //			string strTemp ;     ///临时变量;
            //判断DataGrid是否需要排序

            strCodeForCs.Append("\r\n" + "//编辑区域中的输入控件:");
            foreach (AndroidControlEx objAndroidControlENEx in arrCtrlLst4Edit)
            {
                clsAndroidControlBLEx.Gen_FieldVarBind(objAndroidControlENEx, strCodeForCs);
            }
        }
        //public void Gen_FieldVarDef4Query(clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs)
        //{
        //    if (objViewInfoENEx.arrQryRegionFldSet == null || objViewInfoENEx.arrQryRegionFldSet.Count == 0)
        //    {
        //        StringBuilder sbMessage = new StringBuilder();
        //        string strViewName = objViewInfoENEx.ViewName;
        //        sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有[查询]区域,或者[查询]区域没有字段。请检查!", strViewName);
        //        throw new clsDbObjException(sbMessage.ToString());
        //    }

        //    //			string strTemp ;     ///临时变量;
        //    //判断DataGrid是否需要排序
        //    strCodeForCs.Append("\r\n" + "//查询区域中的输入控件:");

        //    foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
        //    {
        //        AndroidControlEx objAndroidControlENEx = clsAndroidControlBLEx.GetAndroidControlObjByQryFld(objQryRegionFldsEx);
        //        clsAndroidControlBLEx.Gen_FieldVarBind(objAndroidControlENEx, strCodeForCs);
        //    }

        //}


        public void Gen_FieldVarBind4Query(clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs)
        {
            if (arrCtrlLst4Query == null)
            {
                InitQueryRegion();
            }
            if (arrCtrlLst4Query.Count == 0)
            {
                return;
            }

            //			string strTemp ;     ///临时变量;
            //判断DataGrid是否需要排序
            strCodeForCs.Append("\r\n" + "//查询区域中的输入控件:");
            
            foreach (AndroidControlEx objAndroidControlENEx in arrCtrlLst4Query)
            {
                clsAndroidControlBLEx.Gen_FieldVarBind(objAndroidControlENEx, strCodeForCs);
            }         

        }

        public void Gen_FieldVarBind4List(clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs)
        {
            if (objViewInfoENEx.arrQryRegionFldSet == null || objViewInfoENEx.arrQryRegionFldSet.Count == 0)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有[查询]区域,或者[查询]区域没有字段。请检查!", strViewName);
                throw new clsDbObjException(sbMessage.ToString());
            }

            //			string strTemp ;     ///临时变量;
            //判断DataGrid是否需要排序
            strCodeForCs.Append("\r\n" + "//列表区域中的显示控件:");
            if (arrCtrlLst4List == null)
            {
                InitListRegion();
            }
            foreach (AndroidControlEx objAndroidControlENEx in arrCtrlLst4List)
            { 
                clsAndroidControlBLEx.Gen_FieldVarBind(objAndroidControlENEx, strCodeForCs);
            }

        }

        public void Gen_FieldVarBind4ListView(clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs)
        {
            if (objViewInfoENEx.arrQryRegionFldSet == null || objViewInfoENEx.arrQryRegionFldSet.Count == 0)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有[查询]区域,或者[查询]区域没有字段。请检查!", strViewName);
                throw new clsDbObjException(sbMessage.ToString());
            }

            //			string strTemp ;     ///临时变量;
            //判断DataGrid是否需要排序
            strCodeForCs.Append("\r\n" + "//列表区域中的显示控件:");

            foreach (AndroidControlEx objAndroidControlENEx in arrCtrlLst4ListView)
            {
                clsAndroidControlBLEx.Gen_FieldVarBind4ListView(objAndroidControlENEx, strCodeForCs);
            }

        }

        public void Gen_LvFieldAssignment4List(clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs)
        {
            if (arrCtrlLst4ListView == null || arrCtrlLst4ListView.Count == 0)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有[查询]区域,或者[查询]区域没有字段。请检查!", strViewName);
                throw new clsDbObjException(sbMessage.ToString());
            }

            //			string strTemp ;     ///临时变量;
            //判断DataGrid是否需要排序
            strCodeForCs.Append("\r\n" + "//列表区域中的显示控件:");

            foreach (AndroidControlEx objAndroidControlENEx in arrCtrlLst4ListView)
            {
                clsAndroidControlBLEx.Gen_LvFieldAssignment(objAndroidControlENEx, objViewInfoENEx, strCodeForCs);
            }

        }
        public void Gen_GetRecCountAndBindLv(clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs)
        {
            strCodeForCs.Append("\r\n" + "AddTask(\"GetRecCountByCond\", null, null); ");
            strCodeForCs.AppendFormat("\r\n" + "AddTask(\"BindLv_{0}\", null, null);",
                objViewInfoENEx.TabName_Out);        
            strCodeForCs.Append("\r\n" + "mobjTaskQueue.ExecTask();");
        }
        public void Gen_onCreate(clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs)
        {

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 界面建立函数");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.Append("\r\n" + "protected void onCreate(Bundle savedInstanceState)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "super.onCreate(savedInstanceState);");
            string strLayOut = string.Format("ac_{0}_qudi", objViewInfoENEx.TabName).ToLower();
            strCodeForCs.AppendFormat("\r\n" + "setContentView(R.layout.{0});", strLayOut);
            
            strCodeForCs.AppendFormat("\r\n" + "iobjExecTaskEx = new iclsExecTaskEx();");
            strCodeForCs.AppendFormat("\r\n" + "mobjTaskQueue = new TaskQueue(iobjExecTaskEx);");
            strCodeForCs.AppendFormat("\r\n" + "mobjParentObjDelegate_Task = mobjTaskQueue.getParentObjDelegate();");


            strCodeForCs.Append("\r\n" + "tvMsg = (TextView)findViewById(R.id.tvMsg);");

            //为查询区域生成字段变量绑定的代码
            Gen_FieldVarBind4Query(objViewInfoENEx, strCodeForCs);
            //为编辑区域生成字段变量绑定的代码
            Gen_FieldVarBind4Edit(objViewInfoENEx, strCodeForCs);

            //为列表区域生成字段变量绑定的代码
            Gen_FieldVarBind4List(objViewInfoENEx, strCodeForCs);
            foreach(string strDdlTabName in arrDdlBindTableLst)
            {
                if (strDdlTabName == objViewInfoENEx.TabName) continue;
                strCodeForCs.AppendFormat("\r\n" + "mobjddlBind{0} = new ddlBind{0}(mobjTaskQueue.getParentObjDelegate()); ",
                    strDdlTabName);
            }
            //为编辑区域、查询区域绑定下拉框
            Gen_BindDdl(objViewInfoENEx, strCodeForCs);

            if (arrCtrlLst4List == null)
            {
                InitListRegion();
            }
            if (arrCtrlLst4List.Count > 0)
            {
                strCodeForCs.Append("\r\n" + "AddTask(\"GetRecCountByCond\", null, null); ");
                strCodeForCs.AppendFormat("\r\n" + "AddTask(\"BindLv_{0}\", null, null);",
                    objViewInfoENEx.TabName_Out);
                               
            }
            strCodeForCs.Append("\r\n" + "mobjTaskQueue.ExecTask();");

            if (arrCtrlLst4Query != null)
            {
                strCodeForCs.Append("\r\n" + "   HideQueryRegion(); ");
            }
            if (arrCtrlLst4Edit != null)
            {
                strCodeForCs.Append("\r\n" + "   HideEditRegion(); ");
            }
            strCodeForCs.Append("\r\n" + "}");
        }
             

        public void Gen_btnQuery_Click(clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs)
        {
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 查询记录单击事件");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\n" + "public void btnQuery_Click(View myView)");
            strCodeForCs.Append("\r\n" + "{");
      
            strCodeForCs.Append("\r\n" + "ShowListViewRegion();");
            strCodeForCs.Append("\r\n" + "GetRecCountByCond();");
            strCodeForCs.AppendFormat("\r\n" + "BindLv_{0}();", 
                objViewInfoENEx.TabName_Out);
            strCodeForCs.Append("\r\n" + "HideQueryRegion();");
            strCodeForCs.Append("\r\n" + "}");
        }

        public void Gen_btnAddNewRecord_Click(clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs)
        {
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 添加记录单击事件");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\n" + "public void btnAddNewRecord_Click(View myView)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "mstrOperateMode = \"Add\";");
            strCodeForCs.Append("\r\n" + "ShowEditRegion();");
            strCodeForCs.Append("\r\n" + "AddNewRecord();");
            strCodeForCs.Append("\r\n" + "}");
        }
        public void Gen_btnCancel_Click(clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs)
        {
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 取消编辑单击事件");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\n" + "public void btnCancel_Click(View myView)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "HideEditRegion();");
            strCodeForCs.Append("\r\n" + "ShowListViewRegion();");
            
            strCodeForCs.Append("\r\n" + "}");
        }

        public void Gen_btnCancelQuery_Click(clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs)
        {
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 取消编辑单击事件");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\n" + "public void btnCancelQuery_Click(View myView)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "HideQueryRegion();");
            strCodeForCs.Append("\r\n" + "HideEditRegion();");
            strCodeForCs.Append("\r\n" + "ShowListViewRegion();");

            strCodeForCs.Append("\r\n" + "}");
        }

        public void Gen_btnPageIndexChanged_Click(clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs)
        {
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 取消编辑单击事件");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\n" + "public void btnPageIndexChanged_Click(View myView)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "int intCtrlId = myView.getId();");
            strCodeForCs.Append("\r\n" + "String strInfo;");
            
            strCodeForCs.Append("\r\n" + "switch(intCtrlId)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "case R.id.btnPrevPage:");
            strCodeForCs.Append("\r\n" + "if (mintPageIndex>1) ");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "mintPageIndex = mintPageIndex-1;");
            strCodeForCs.Append("\r\n" + "AddTask(\"GetRecCountByCond\", null, null); ");
            strCodeForCs.AppendFormat("\r\n" + "AddTask(\"BindLv_{0}\", null, null);",
                objViewInfoENEx.TabName_Out);
            
        strCodeForCs.Append("\r\n" + "mobjTaskQueue.ExecTask();");

            strCodeForCs.AppendFormat("\r\n" + "  BindLv_{0}();",
                 objViewInfoENEx.TabName_Out);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "strInfo = \"显示信息：已经是第一页!\";");
            strCodeForCs.Append("\r\n" + "clsPubFun.ShowMessage(this, strInfo);");
           
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "case R.id.btnNextPage:");
            strCodeForCs.Append("\r\n" + "if (mintPageIndex<mintTotalPages) ");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "mintPageIndex = mintPageIndex + 1;");
            strCodeForCs.Append("\r\n" + "AddTask(\"GetRecCountByCond\", null, null); ");
            strCodeForCs.AppendFormat("\r\n" + "AddTask(\"BindLv_{0}\", null, null);",
                objViewInfoENEx.TabName_Out);

            strCodeForCs.Append("\r\n" + "mobjTaskQueue.ExecTask();");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "AddTask(\"GetRecCountByCond\", null, null); ");
            strCodeForCs.Append("\r\n" + "mobjTaskQueue.ExecTask();");
            strCodeForCs.Append("\r\n" + "strInfo = \"显示信息：已经是最后一页!\";");
            strCodeForCs.Append("\r\n" + "clsPubFun.ShowMessage(this, strInfo);");
           
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "case R.id.btnFirstPage:");
            strCodeForCs.Append("\r\n" + "if (mintPageIndex != 1) ");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "mintPageIndex = 1; ");

            strCodeForCs.Append("\r\n" + "AddTask(\"GetRecCountByCond\", null, null); ");
            strCodeForCs.AppendFormat("\r\n" + "AddTask(\"BindLv_{0}\", null, null);",
                objViewInfoENEx.TabName_Out);

            strCodeForCs.Append("\r\n" + "mobjTaskQueue.ExecTask();");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "strInfo = \"显示信息：已经是第一页!\";");
            strCodeForCs.Append("\r\n" + "clsPubFun.ShowMessage(this, strInfo);");
            
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "case R.id.btnLastPage:");
            strCodeForCs.Append("\r\n" + "if (mintPageIndex != mintTotalPages) ");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "mintPageIndex = mintTotalPages; ");

            strCodeForCs.Append("\r\n" + "AddTask(\"GetRecCountByCond\", null, null); ");
            strCodeForCs.AppendFormat("\r\n" + "AddTask(\"BindLv_{0}\", null, null);",
                objViewInfoENEx.TabName_Out);

            strCodeForCs.Append("\r\n" + "mobjTaskQueue.ExecTask();");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "AddTask(\"GetRecCountByCond\", null, null); ");
            strCodeForCs.Append("\r\n" + "mobjTaskQueue.ExecTask();");
            strCodeForCs.Append("\r\n" + "strInfo = \"显示信息：已经是最后一页!\";");
            strCodeForCs.Append("\r\n" + "clsPubFun.ShowMessage(this, strInfo);");
               
            
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
        }

        public void Gen_btnDelRecordsByJSON_Click(clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs, string strTabName)
        {
            strCodeForCs.Append("\r\n" + "/// <summary>");
            strCodeForCs.Append("\r\n" + "/// 删除记录");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "/// </summary>");
            strCodeForCs.Append("\r\n" + "/// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n" + "/// <returns></returns>");
            strCodeForCs.Append("\r\n" + "public void btnDelRecordsByJSON_Click(View myView)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "boolean[] checks = lv{0}Adapter.getChecks();", objViewInfoENEx.TabName_Out);
            strCodeForCs.Append("\r\n" + "StringBuilder sbMsg = new StringBuilder();");
            strCodeForCs.Append("\r\n" + "for (int i = 0; i < checks.length; i++)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (checks[i] == true)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = (cls{0}EN)lv{0}.getItemAtPosition(i);",
                objViewInfoENEx.TabName_Out);
            strCodeForCs.AppendFormat("\r\n" + "sbMsg.append(obj{0}EN.get{1}() + \",\");",
                objViewInfoENEx.TabName_Out,
                objViewInfoENEx.arrKeyPrjTabFldSet[0].ObjFieldTabENEx.FldName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "mstrKeyIdLst = sbMsg.toString();");
            strCodeForCs.AppendFormat("\r\n" + "{0}.icls{1}_DelRecordsByJSONEx iobj{1}_DelRecordsByJSON = new {0}.icls{1}_DelRecordsByJSONEx({0}.this);",
                objViewInfoENEx.WebFormName, strTabName);
            strCodeForCs.AppendFormat("\r\n" + "iobj{0}_DelRecordsByJSON.main();",
                objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");

        }
        public string Gen_Class4DelRecordsByJSONEx(clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs)
        {

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 删除记录");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.AppendFormat("\r\n" + "class icls{0}_DelRecordsByJSONEx extends cls{0}_Controller.icls{0}_DelRecordsByJSON",
                objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objViewInfoENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "public icls{0}_DelRecordsByJSONEx(Object pvcParent)",
    objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "super(pvcParent);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "@Override");

            strCodeForCs.Append("\r\n" + "public void main()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
                objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "String strKeyIdLst = mstrKeyIdLst;");
            clsDataTypeAbbrEN objDataTypeAbbrEN = objViewInfoENEx.arrKeyPrjTabFldSet[0].ObjFieldTabENEx.objDataTypeAbbrEN;


            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.DelRecordsByJSON(strKeyIdLst);",
                objViewInfoENEx.TabName,
                objViewInfoENEx.arrKeyPrjTabFldSet[0].ObjFieldTabENEx.PrivFuncName);

            strCodeForCs.Append("\r\n" + "}");



            strCodeForCs.Append("\r\n" + "//通过WebService执行DelRecordsByJSON,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(int returnInt, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conDelRecordsByJSON,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (returnInt > 0)");
            strCodeForCs.Append("\r\n" + "{");

            //绑定下拉框
            Gen_GetRecCountAndBindLv(objViewInfoENEx, strCodeForCs);

            strCodeForCs.Append("\r\n" + "String strInfo = String.format(\"删除记录成功,共删除%s条记录!\", returnInt);");
            strCodeForCs.Append("\r\n" + "tvMsg.setText(strInfo);");
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "String strInfo = String.format(\"删除记录不成功!\");");
            strCodeForCs.Append("\r\n" + "tvMsg.setText(strInfo);");
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "mobjParentObjDelegate_Task.NotifyFinished(\"{0}\", 1);", enumDict4GC_DictKey1.conDelRecordsByJSON);

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");



            return strCodeForCs.ToString();
        }
        public void Gen_btnShowQuery_Click(clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs)
        {
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 显示查询区域单击事件");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.Append("\r\n" + "  public void btnShowQuery_Click(View myView)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + " HideListViewRegion();");
            strCodeForCs.Append("\r\n" + " ShowQueryRegion();");        

            strCodeForCs.Append("\r\n" + "}");
        }

        public void Gen_ShowQueryRegion(clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs)
        {
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 显示查询区域以及相关操作");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.Append("\r\n" + " private void ShowQueryRegion()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "clQuery.setVisibility(View.VISIBLE);");
            strCodeForCs.Append("\r\n" + "}");
        }


        public void Gen_HideQueryRegion(clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs)
        {
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 隐藏查询区域以及相关操作");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.Append("\r\n" + " private void HideQueryRegion()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "clQuery.setVisibility(View.GONE);");
            strCodeForCs.Append("\r\n" + "}");
        }

        public void Gen_AddTask(clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs)
        {
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 向任务队列中添加任务");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strTaskName\">任务名称</param>");
            strCodeForCs.Append("\r\n /// <param name = \"objSpinner\">下拉框对象</param>");
            strCodeForCs.Append("\r\n /// <param name = \"objDdlBind\">下拉框绑定对象</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\n" + " private void AddTask(String strTaskName, Spinner objSpinner, Object objDdlBind)");
            strCodeForCs.Append("\r\n" + " {");
            strCodeForCs.Append("\r\n" + " Task objTask = new Task();");
            strCodeForCs.Append("\r\n" + " objTask.setTaskName(strTaskName);");
            strCodeForCs.Append("\r\n" + " objTask.setSpinner(objSpinner);");
            strCodeForCs.Append("\r\n" + " objTask.setActivity(this);");
            strCodeForCs.Append("\r\n" + " objTask.setDdlBind(objDdlBind);");
            strCodeForCs.Append("\r\n" + " objTask.setState(Task.State.NEW);");
            strCodeForCs.Append("\r\n" + " mobjTaskQueue.addTask(objTask);");
            strCodeForCs.Append("\r\n" + " }");

        }


        public void Gen_HideEditRegion(clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs)
        {
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 隐藏编辑区域以及相关操作");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.Append("\r\n" + " private void HideEditRegion()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + " llEdit.setVisibility(View.GONE);");
            strCodeForCs.Append("\r\n" + "}");
        }
        public void Gen_HideListViewRegion(clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs, string strTabName)
        {
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 隐藏ListView区域以及相关操作");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.Append("\r\n" + " private void HideListViewRegion()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + " clListView.setVisibility(View.GONE);", strTabName);
            strCodeForCs.Append("\r\n" + "}");
        }


        public void Gen_ShowEditRegion(clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs)
        {
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 显示编辑区域以及相关操作");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.Append("\r\n" + " private void ShowEditRegion()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + " llEdit.setVisibility(View.VISIBLE);");
            strCodeForCs.Append("\r\n" + "}");
        }

        public void Gen_ShowListViewRegion(clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs, string strTabName)
        {
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 显示编辑区域以及相关操作");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.Append("\r\n" + " private void ShowListViewRegion()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + " clListView.setVisibility(View.VISIBLE);", strTabName);
            strCodeForCs.Append("\r\n" + "}");
        }

        public void Gen_AddNewRecord(clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs, string strTabName)
        {
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 添加记录的初始化函数");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.Append("\r\n" + " private void AddNewRecord()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "HideListViewRegion();",
             objViewInfoENEx.WebFormName, strTabName);
            strCodeForCs.AppendFormat("\r\n" + "ShowEditRegion();",
                     objViewInfoENEx.WebFormName, strTabName);
            strCodeForCs.AppendFormat("\r\n" + "ClearEditRegion();",
                      objViewInfoENEx.WebFormName, strTabName);
            
            strCodeForCs.AppendFormat("\r\n" + "//{0}.icls{1}GetMaxStrIdEx iobj{1}GetMaxStrId = new {0}.icls{1}GetMaxStrIdEx({0}.this);",
                objViewInfoENEx.WebFormName   , strTabName );

            strCodeForCs.AppendFormat("\r\n" + "//iobj{0}GetMaxStrId.main();",
                objViewInfoENEx.TabName);

            strCodeForCs.Append("\r\n" + "}");
        }

        public string Gen_Class4AddNewRecord4GetMaxStrIdEx(clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs)
        {
           
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 添加新记录、获取最大值作为关键字的扩展类");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

          

            strCodeForCs.AppendFormat("\r\n" + "class icls{0}_AddNewRecord4GetMaxStrIdEx extends cls{0}_Controller.icls{0}_AddNewRecord4GetMaxStrId",
                objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objViewInfoENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "public icls{0}_AddNewRecord4GetMaxStrIdEx(Object pvcParent)",
    objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "super(pvcParent);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "@Override");

            strCodeForCs.Append("\r\n" + "public void main()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
           objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.GetMaxStrId();",
                objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "//通过WebService执行GetMaxStrId,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(String returnString, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");

            foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
            {
                if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02 
                    && objEditRegionFldsEx.PrimaryTypeId()== clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02)
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.set{1}(returnString);",
                    objViewInfoENEx.TabName,
                    objEditRegionFldsEx.FldName);
                }
                else
                {
                    if (objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType == "boolean")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.set{1}({2});",
                           objViewInfoENEx.TabName,
                           objEditRegionFldsEx.FldName,
                           objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue4Test_Java);
                    }
                    else if (objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType == "Date")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.set{1}({2});",
                           objViewInfoENEx.TabName,
                           objEditRegionFldsEx.FldName,
                           objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue4Test_Java);
                    }
                    else if (objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.set{1}(\"{2}\");",
                           objViewInfoENEx.TabName,
                           objEditRegionFldsEx.FldName,
                           objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue4Test_Java);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.set{1}({2});",
                              objViewInfoENEx.TabName,
                              objEditRegionFldsEx.FldName,
                              objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue4Test_Java);
                    }
                }
            }
            strCodeForCs.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
                objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "String strWhereCond =String.format(\"{1} = '%s'\", obj{0}EN.get{1}());",
                objViewInfoENEx.TabName,
                objViewInfoENEx.arrKeyPrjTabFldSet[0].ObjFieldTabENEx.FldName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.IsExistRecord(strWhereCond);",
                objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//通过WebService执行IsExistRecord,返回的事件函数,可能需要处理执行错误。");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(clsResponseData objResponseData, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//通过WebService执行IsExistRecord,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(boolean returnBool, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (returnBool == false)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
                objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.AddNewRecord(obj{0}EN);",
                objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "String strInfo = String.format(\"关键字为‘%s’的记录已经存在,不能再添加!\", obj{0}EN.get{1}());",
                objViewInfoENEx.TabName,
                objViewInfoENEx.arrKeyPrjTabFldSet[0].ObjFieldTabENEx.FldName);
            strCodeForCs.Append("\r\n" + "tvMsg.setText(strInfo);");
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strCodeForCs.AppendFormat("\r\n" + "mobjParentObjDelegate_Task.NotifyFinished(\"{0}\", 1);", enumDict4GC_DictKey1.conAddNewRecordByJSON);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//通过WebService执行AddNewRecord,返回的事件函数,可能需要处理执行错误。");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(clsResponseData objResponseData, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//通过WebService执行AddNewRecord,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(boolean returnBool, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (returnBool == true)");
            strCodeForCs.Append("\r\n" + "{");
            //绑定下拉框
            Gen_GetRecCountAndBindLv(objViewInfoENEx, strCodeForCs);
            strCodeForCs.Append("\r\n" + "String strInfo = String.format(\"添加记录成功!\");");
            strCodeForCs.Append("\r\n" + "tvMsg.setText(strInfo);");
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "String strInfo = String.format(\"添加记录不成功!\");");
            strCodeForCs.Append("\r\n" + "tvMsg.setText(strInfo);");
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }



       
        public void Gen_GetDataFromClass(clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs)
        {
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 把类对象的属性内容显示到界面上");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.AppendFormat("\r\n" + "protected void GetDataFrom{0}Class(cls{0}EN pobj{0}EN)",
                objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
            {
                if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                && objEditRegionFldsEx.PrimaryTypeId()== clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                switch (objEditRegionFldsEx.ObjFieldTabENEx.CsType())
                {
                    case "int":
                        strCodeForCs.AppendFormat("\r\n" + "this.set{0}(pobj{1}EN.get{0}());",
                            objEditRegionFldsEx.FldName ,
                            objViewInfoENEx.TabName);
                        strCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);
                        strCodeForCs.AppendFormat("" + "(说明:{3};字段类型:{0};字段长度:{1};,是否可空:{2})",
                        objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                        objEditRegionFldsEx.ObjFieldTabENEx.FldLength,
                        objEditRegionFldsEx.ObjFieldTabENEx.IsNull,
                        objEditRegionFldsEx.ObjFieldTabENEx.MemoInTab);
                        break;
                    default:
                        strCodeForCs.AppendFormat("\r\n" + "this.set{0}(pobj{1}EN.get{0}());",
                            objEditRegionFldsEx.FldName,
                            objViewInfoENEx.TabName);
                        strCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);
                        strCodeForCs.AppendFormat("" + "(说明:{3};字段类型:{0};字段长度:{1};,是否可空:{2})",
                        objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                        objEditRegionFldsEx.ObjFieldTabENEx.FldLength,
                        objEditRegionFldsEx.ObjFieldTabENEx.IsNull,
                        objEditRegionFldsEx.ObjFieldTabENEx.MemoInTab);
                        break;
                }
            }
      
            strCodeForCs.Append("\r\n" + "}");
        }

        public void Gen_ClearEditRegion(clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs)
        {
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 清空编辑区的控件内容");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.AppendFormat("\r\n" + "protected void ClearEditRegion()",
                objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
            {
                if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                && objEditRegionFldsEx.PrimaryTypeId()== clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                AndroidControlEx objAndroidControlENEx = clsAndroidControlBLEx.GetAndroidControlObjByEditFld(objEditRegionFldsEx);
                clsAndroidControlBLEx.Gen_ClearFieldCtrl4Edit(objAndroidControlENEx, strCodeForCs, objViewInfoENEx.PrjId);
            }
            strCodeForCs.Append("\r\n" + "}");
        }


        public void Gen_PutDataToClass(clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs)
        {
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 把界面上的属性数据传到类对象中");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.AppendFormat("\r\n" + "protected void PutDataTo{0}Class(cls{0}EN pobj{0}EN)",
                objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
            {
                if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                && objEditRegionFldsEx.PrimaryTypeId()== clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                switch (objEditRegionFldsEx.ObjFieldTabENEx.CsType())
                {
                    case "int":
                        strCodeForCs.AppendFormat("\r\n" + "pobj{1}EN.set{0}(this.get{0}());",
                            objEditRegionFldsEx.FldName,
                            objViewInfoENEx.TabName);
                        strCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);
                        strCodeForCs.AppendFormat("" + "(说明:{3};字段类型:{0};字段长度:{1};,是否可空:{2})",
                        objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                        objEditRegionFldsEx.ObjFieldTabENEx.FldLength,
                        objEditRegionFldsEx.ObjFieldTabENEx.IsNull,
                        objEditRegionFldsEx.ObjFieldTabENEx.MemoInTab);
                        break;
                    default:
                        strCodeForCs.AppendFormat("\r\n" + "pobj{1}EN.set{0}(this.get{0}());",
                            objEditRegionFldsEx.FldName,
                            objViewInfoENEx.TabName);
                        strCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);
                        strCodeForCs.AppendFormat("" + "(说明:{3};字段类型:{0};字段长度:{1};,是否可空:{2})",
                        objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                        objEditRegionFldsEx.ObjFieldTabENEx.FldLength,
                        objEditRegionFldsEx.ObjFieldTabENEx.IsNull,
                        objEditRegionFldsEx.ObjFieldTabENEx.MemoInTab);
                        break;
                }
            }
            strCodeForCs.Append("\r\n" + "}");
        }

        public void Gen_SetMsg(clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs)
        {
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 设置用于显示信息的控件");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.Append("\r\n" + " public void SetMsg(String strMsg)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + " tvMsg.setText(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
        }
      
        public void Gen_UpdateRecord(clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs, string strTabName)
        {
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 修改记录的初始化函数,即把关键字的相关对象内容显示在控件,供用户修改");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.AppendFormat("\r\n" + " public void UpdateRecord({0} {1})",
                objViewInfoENEx.arrKeyPrjTabFldSet[0].ObjFieldTabENEx.objDataTypeAbbrEN.JavaType,
                objViewInfoENEx.arrKeyPrjTabFldSet[0].ObjFieldTabENEx.PrivFuncName                );
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + " mstrOperateMode = \"Update\";");
            strCodeForCs.AppendFormat("\r\n" + "m{0} = {0};",
                objViewInfoENEx.arrKeyPrjTabFldSet[0].ObjFieldTabENEx.PrivFuncName);
            strCodeForCs.AppendFormat("\r\n" + "{0}.icls{1}GetObjBy{2}Ex iobj{1}GetObjBy{2} = new {0}.icls{1}GetObjBy{2}Ex({0}.this);",
                objViewInfoENEx.WebFormName, strTabName,
                 objViewInfoENEx.arrKeyPrjTabFldSet[0].ObjFieldTabENEx.FldName);
            strCodeForCs.AppendFormat("\r\n" + "iobj{0}GetObjBy{1}.main();",
                 objViewInfoENEx.TabName,
                 objViewInfoENEx.arrKeyPrjTabFldSet[0].ObjFieldTabENEx.FldName);
            strCodeForCs.Append("\r\n" + "ShowEditRegion();");
            strCodeForCs.Append("\r\n" + "HideListViewRegion();");
            strCodeForCs.Append("\r\n" + "}");
        }
      
        public void Gen_btnGetJSONObjByKey_Click(clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs, string strTabName)
        {
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据关键字获取相应的记录的对象");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.Append("\r\n" + "public void btnGetJSONObjByKey_Click(View myView)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "{0}.icls{1}GetObjBy{2}Ex iobj{1}GetObjBy{2} = new {0}.icls{1}GetObjBy{2}Ex({0}.this);",
                objViewInfoENEx.WebFormName, strTabName, 
                 objViewInfoENEx.arrKeyPrjTabFldSet[0].ObjFieldTabENEx.FldName               );

            strCodeForCs.AppendFormat("\r\n" + "iobj{0}GetObjBy{1}.main();",
                strTabName,
                 objViewInfoENEx.arrKeyPrjTabFldSet[0].ObjFieldTabENEx.FldName);
            strCodeForCs.Append("\r\n" + "}");
        }

        public string Gen_Class4GetObjByKeyIdEx(clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs)
        {
      
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据关键字获取相应的记录的对象的 扩展类");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">参数列表</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.AppendFormat("\r\n" + "class icls{0}GetObjBy{1}Ex extends cls{0}_Controller.icls{0}GetObjBy{1}",
                objViewInfoENEx.TabName,
                objViewInfoENEx.arrKeyPrjTabFldSet[0].ObjFieldTabENEx.FldName);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objViewInfoENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "public icls{0}GetObjBy{1}Ex(Object pvcParent)",
    objViewInfoENEx.TabName,
                objViewInfoENEx.arrKeyPrjTabFldSet[0].ObjFieldTabENEx.FldName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "super(pvcParent);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "@Override");

            strCodeForCs.Append("\r\n" + "public void main()");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
                objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objViewInfoENEx.TabName);
            //GC_GetInputValue4Para(objvFunction4GeneCodeEN, strCodeForCs);
            clsDataTypeAbbrEN objDataTypeAbbrEN = objViewInfoENEx.arrKeyPrjTabFldSet[0].ObjFieldTabENEx.objDataTypeAbbrEN;
            //clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;

            strCodeForCs.AppendFormat("\r\n" + "  {0} {1} = m{1};",
                objViewInfoENEx.arrKeyPrjTabFldSet[0].ObjFieldTabENEx.objDataTypeAbbrEN.JavaType,
                    objViewInfoENEx.arrKeyPrjTabFldSet[0].ObjFieldTabENEx.PrivFuncName);

            //if (objDataTypeAbbrEN.IsNeedQuote == true)
            //{
            //    strCodeForCs.AppendFormat("\r\n" + "{1} {0} = strKeyId;",
            //      objViewInfoENEx.arrKeyPrjTabFldSet[0].ObjFieldTabENEx.PrivFuncName,
            //      objViewInfoENEx.arrKeyPrjTabFldSet[0].ObjFieldTabENEx.objDataTypeAbbrEN.JavaType);

            //}
            //else
            //{
            //    switch (objDataTypeAbbrEN.DataTypeId)
            //    {
            //        case enumDataTypeAbbr.float_07:
            //            strCodeForCs.AppendFormat("\r\n" + "{0} {1} = Float.valueOf(strKeyId);",
            //                objDataTypeAbbrEN.JavaType,
            //                objViewInfoENEx.arrKeyPrjTabFldSet[0].ObjFieldTabENEx.PrivFuncName);
            //            break;
            //        case enumDataTypeAbbr.int_09:
            //            strCodeForCs.AppendFormat("\r\n" + "{0} {1} = Integer.valueOf(strKeyId);",
            //                objDataTypeAbbrEN.JavaType,
            //                objViewInfoENEx.arrKeyPrjTabFldSet[0].ObjFieldTabENEx.PrivFuncName);
            //            break;
            //        case enumDataTypeAbbr.money_11:
            //            strCodeForCs.AppendFormat("\r\n" + "{0} {1} = Double.valueOf(strKeyId);",
            //                objDataTypeAbbrEN.JavaType,
            //                objViewInfoENEx.arrKeyPrjTabFldSet[0].ObjFieldTabENEx.PrivFuncName);
            //            break;
            //        case enumDataTypeAbbr.bigint_01:
            //            strCodeForCs.AppendFormat("\r\n" + "{0} {1} = Long.valueOf(strKeyId);",
            //                objDataTypeAbbrEN.JavaType,
            //                objViewInfoENEx.arrKeyPrjTabFldSet[0].ObjFieldTabENEx.PrivFuncName);
            //            break;
            //        default:
            //            string strMsg = string.Format("数据类型：[{0}({1})](Java:{2})在函数中没有处理!({3})",
            //                objDataTypeAbbrEN.DataTypeName, objDataTypeAbbrEN.DataTypeId,
            //                objDataTypeAbbrEN.JavaType,
            //                clsStackTrace.GetCurrClassFunction());
            //            throw new Exception(strMsg);
            //    }
            //}
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.GetObjBy{1}({2});",
                objViewInfoENEx.TabName,
                objViewInfoENEx.arrKeyPrjTabFldSet[0].ObjFieldTabENEx.FldName,
                objViewInfoENEx.arrKeyPrjTabFldSet[0].ObjFieldTabENEx.PrivFuncName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "//通过WebService执行GetRecordObjByKey,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(Object returnObject, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjByKey,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = (cls{0}EN)returnObject;",
                objViewInfoENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n" + "String strKeyId = m{0};",
            //  objViewInfoENEx.arrKeyPrjTabFldSet[0].ObjFieldTabENEx.PrivFuncName);

            strCodeForCs.AppendFormat("\r\n" + "//String strKeyId = {0};",
                objViewInfoENEx.arrKeyPrjTabFldSet[0].ObjFieldTabENEx.PrivPropName);
            strCodeForCs.Append("\r\n" + "ShowEditRegion();");
            strCodeForCs.AppendFormat("\r\n" + "GetDataFrom{0}Class(obj{0}EN);",
                objViewInfoENEx.TabName_In);

            strCodeForCs.AppendFormat("\r\n" + "String strInfo = String.format(\"根据关键字:[%s]获取对象：%s!\", m{2}, obj{0}EN.get{1}());",
                objViewInfoENEx.TabName,
                objViewInfoENEx.arrKeyPrjTabFldSet[0].ObjFieldTabENEx.FldName,
                 objViewInfoENEx.arrKeyPrjTabFldSet[0].ObjFieldTabENEx.PrivFuncName);
            strCodeForCs.Append("\r\n" + "tvMsg.setText(strInfo);");
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "mobjParentObjDelegate_Task.NotifyFinished(\"{0}\", 1);", enumDict4GC_DictKey1.conGetRecordJSONObjByKey);

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

     

        public void Gen_btnOkUpd_Click(clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs, string strTabName)
        {
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 添加、修改的确认的事件函数");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.Append("\r\n" + " public void btnOkUpd_Click(View myView)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "InputMethodManager imm = (InputMethodManager)getSystemService(Context.INPUT_METHOD_SERVICE);");
            strCodeForCs.Append("\r\n" + "imm.toggleSoftInput(0, InputMethodManager.HIDE_NOT_ALWAYS);");
            strCodeForCs.Append("\r\n" + "if (mstrOperateMode == \"Add\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "{0}.icls{1}_AddNewRecordEx iobj{1}_AddNewRecord = new {0}.icls{1}_AddNewRecordEx({0}.this);",
                objViewInfoENEx.WebFormName, strTabName);
            strCodeForCs.AppendFormat("\r\n" + "iobj{0}_AddNewRecord.main();",
                strTabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (mstrOperateMode == \"Update\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "{0}.icls{1}_UpdateRecordEx iobj{1}_UpdateRecord = new {0}.icls{1}_UpdateRecordEx({0}.this);",
                objViewInfoENEx.WebFormName, strTabName);
            strCodeForCs.AppendFormat("\r\n" + "iobj{0}_UpdateRecord.main();",
                strTabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "tvMsg.setText(\"操作模式(mstrOperateMode)错误!\");");
            strCodeForCs.Append("\r\n" + "}");


            //strCodeForCs.AppendFormat("\r\n" + "{0}.icls{1}_AddNewRecord4GetMaxStrIdEx iobj{1}_AddNewRecord4GetMaxStrId = new {0}.icls{1}_AddNewRecord4GetMaxStrIdEx({0}.this);",
            //    objViewInfoENEx.WebFormName, strTabName);

            //strCodeForCs.AppendFormat("\r\n" + "iobj{0}_AddNewRecord4GetMaxStrId.main();",
            //    objViewInfoENEx.TabName);

            strCodeForCs.Append("\r\n" + "}");
        }


        /// <summary>
        /// 继承Runnable类必须实现的【run】函数  
        /// </summary>
        /// <returns></returns>
        public string Gen_Class4AddNewRecordEx(clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs)
        {
       
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 添加新记录的相关扩展类");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns></returns>");


            strCodeForCs.AppendFormat("\r\n" + "class icls{0}_AddNewRecordEx extends cls{0}_Controller.icls{0}_AddNewRecord",
                objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objViewInfoENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "public icls{0}_AddNewRecordEx(Object pvcParent)",
    objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "super(pvcParent);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "@Override");

            strCodeForCs.Append("\r\n" + "public void main()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "PutDataTo{0}Class(obj{0}EN);",
              objViewInfoENEx.TabName_In);
            strCodeForCs.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
                objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objViewInfoENEx.TabName);
            if (objViewInfoENEx.arrKeyPrjTabFldSet[0].PrimaryTypeId == enumPrimaryType.Identity_02)
            {
                strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.AddNewRecord(obj{0}EN);",
                    objViewInfoENEx.TabName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "String strWhereCond =String.format(\"{1} = '%s'\",obj{0}EN.get{1}());",
                    objViewInfoENEx.TabName,
                    objViewInfoENEx.arrKeyPrjTabFldSet[0].ObjFieldTabENEx.FldName);
                strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.IsExistRecord(strWhereCond);",
                    objViewInfoENEx.TabName);
            }
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//通过WebService执行IsExistRecord,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(boolean returnBool, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (returnBool == false)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
                objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.AddNewRecord(obj{0}EN);",
                objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "String strInfo = String.format(\"关键字为‘%s’的记录已经存在,不能再添加!\", obj{0}EN.get{1}());",
                objViewInfoENEx.TabName,
                objViewInfoENEx.arrKeyPrjTabFldSet[0].ObjFieldTabENEx.FldName);
            strCodeForCs.Append("\r\n" + "tvMsg.setText(strInfo);");
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//通过WebService执行AddNewRecord,返回的事件函数,可能需要处理执行错误。");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(clsResponseData objResponseData, String strClassName)",
               clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//通过WebService执行AddNewRecord,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(boolean returnBool, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (returnBool == true)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "HideEditRegion();");
            strCodeForCs.Append("\r\n" + "ShowListViewRegion();");
            if (arrCtrlLst4List == null)
            {
                InitListRegion();
            }
            if (arrCtrlLst4List.Count > 0)
            {
                //绑定下拉框
                Gen_GetRecCountAndBindLv(objViewInfoENEx, strCodeForCs);

            }
            strCodeForCs.Append("\r\n" + "String strInfo = String.format(\"添加记录成功!\");");
            strCodeForCs.Append("\r\n" + "tvMsg.setText(strInfo);");
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "String strInfo = String.format(\"添加记录不成功!\");");
            strCodeForCs.Append("\r\n" + "tvMsg.setText(strInfo);");
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "mobjParentObjDelegate_Task.NotifyFinished(\"{0}\", 1);", enumDict4GC_DictKey1.conAddNewRecordByJSON);

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 继承Runnable类必须实现的【run】函数  
        /// </summary>
        /// <returns></returns>
        public string Gen_Class4ExecTaskEx(clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs)
        {

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 添加新记录的相关扩展类");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\n" + "class iclsExecTaskEx extends clsExecTask");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.Append("\r\n" + "public void ExecTask(Task myTask)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "switch (myTask.getTaskName())");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "case \"GetRecCountByCond\":");
            strCodeForCs.Append("\r\n" + "GetRecCountByCond();");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.AppendFormat("\r\n" + "case \"BindLv_{0}\":", objViewInfoENEx.TabName_Out);
            strCodeForCs.AppendFormat("\r\n" + "BindLv_{0}();", objViewInfoENEx.TabName_Out);
            strCodeForCs.Append("\r\n" + "break;");
            Gen_BindDdlInTaskQueue(objViewInfoENEx, strCodeForCs);

            strCodeForCs.Append("\r\n" + "default:");
            strCodeForCs.Append("\r\n" + "String strMsg = String.format(\"所给任务名：[%s]没有被处理\", myTask.getTaskName());");
            strCodeForCs.Append("\r\n" + "System.out.println(strMsg); //输出异常信息");
            //  throw new Exception("AAA");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        public string Gen_Class4UpdateRecordEx(clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs)
        {
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 修改记录的相关扩展类");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.AppendFormat("\r\n" + "class icls{0}_UpdateRecordEx extends cls{0}_Controller.icls{0}_UpdateRecord",
                objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objViewInfoENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "public icls{0}_UpdateRecordEx(Object pvcParent)",
    objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "super(pvcParent);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "@Override");

            strCodeForCs.Append("\r\n" + "public void main()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "PutDataTo{0}Class(obj{0}EN);",
                objViewInfoENEx.TabName_In);

            strCodeForCs.AppendFormat("\r\n" + " obj{0}EN.set{1}({2});",
                objViewInfoENEx.TabName_In,
                objViewInfoENEx.arrKeyPrjTabFldSet[0].ObjFieldTabENEx.FldName,
                objViewInfoENEx.arrKeyPrjTabFldSet[0].ObjFieldTabENEx.PrivPropName);
            //foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
            //{
            //    if (objEditRegionFldsEx.objPrjTabFldENEx.FieldTypeId == enumFieldType.KeyField_02 && objEditRegionFldsEx.objPrjTabFldENEx.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            //    {
            //        continue;
            //    }
            //    if (objEditRegionFldsEx.objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType == "boolean")
            //    {
            //        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.set{1}({2});",
            //           objViewInfoENEx.TabName,
            //           objEditRegionFldsEx.objPrjTabFldENEx.FldName,
            //           objEditRegionFldsEx.objPrjTabFldENEx.ObjFieldTabENEx.DefaultValue4Test_Java);
            //    }
            //    else if (objEditRegionFldsEx.objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType == "Date")
            //    {
            //        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.set{1}({2});",
            //           objViewInfoENEx.TabName,
            //           objEditRegionFldsEx.objPrjTabFldENEx.FldName,
            //           objEditRegionFldsEx.objPrjTabFldENEx.ObjFieldTabENEx.DefaultValue4Test_Java);
            //    }
            //    else if (objEditRegionFldsEx.objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
            //    {
            //        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.set{1}(\"{2}\");",
            //           objViewInfoENEx.TabName,
            //           objEditRegionFldsEx.objPrjTabFldENEx.FldName,
            //           objEditRegionFldsEx.objPrjTabFldENEx.ObjFieldTabENEx.DefaultValue4Test_Java);
            //    }
            //    else
            //    {
            //        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.set{1}({2});",
            //              objViewInfoENEx.TabName,
            //              objEditRegionFldsEx.objPrjTabFldENEx.FldName,
            //              objEditRegionFldsEx.objPrjTabFldENEx.ObjFieldTabENEx.DefaultValue4Test_Java);
            //    }
            //}
            strCodeForCs.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
                objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.UpdateRecord(obj{0}EN);",
                objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//通过WebService执行UpdateRecord,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(boolean returnBool, String strClassName)",
                   clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conUpdateRecordByJSON,
                enumDict4GC_DictKey2.conCorrectFinished));
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (returnBool == true)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "HideEditRegion();");
            strCodeForCs.Append("\r\n" + "ShowListViewRegion();");
            if (arrCtrlLst4List == null)
            {
                InitListRegion();
            }
            if (arrCtrlLst4List.Count > 0)
            {
                //绑定下拉框
                Gen_GetRecCountAndBindLv(objViewInfoENEx, strCodeForCs);

            }
            strCodeForCs.Append("\r\n" + "String strInfo = String.format(\"修改记录成功!\");");
            strCodeForCs.Append("\r\n" + "tvMsg.setText(strInfo);");
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "String strInfo = String.format(\"修改记录不成功!\");");
            strCodeForCs.Append("\r\n" + "tvMsg.setText(strInfo);");
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "mobjParentObjDelegate_Task.NotifyFinished(\"{0}\", 1);", enumDict4GC_DictKey1.conUpdateRecordByJSON);


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_CombineCondition(clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs)
        {  

            try
            {
                ///生成仅有变量;

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 把所有的查询控件内容组合成一个条件串");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <returns>条件串(strWhereCond)</returns>");
                strCodeForCs.AppendFormat("\r\n" + "protected String Combine{0}Condition()", objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//使条件串的初值为\"1 = 1\",以便在该串的后面用\"and \"添加其他条件,");
                strCodeForCs.Append("\r\n" + "//例如 1 = 1 && UserName = '张三'");
                strCodeForCs.Append("\r\n" + "String strWhereCond = \" 1 = 1 \";");
                strCodeForCs.Append("\r\n" + "//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。");
        
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    switch (objQryRegionFldsEx.objCtlType.CtlTypeName) //objEditRegionFldsEx.objCtlType.CtlTypeName
                    {
                        case "Button":
                            break;
                        case "CheckBox":
                            strCodeForCs.AppendFormat("\r\n" + "if (this.get{0}() == true)",
                                        objQryRegionFldsEx.FldName + "_q");
                            strCodeForCs.Append("\r\n" + "{");
                    
                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += String.format(\" And %s = '1'\", cls{1}EN.con_{0});",
                                     objQryRegionFldsEx.FldName,
                                     objViewInfoENEx.TabName_Out,
                                     "{", "}");
                            strCodeForCs.Append("\r\n" + "}");

                            strCodeForCs.AppendFormat("\r\n" + "else");
                            strCodeForCs.Append("\r\n" + "{");
                    
                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += String.format(\" And %s = '0'\", cls{1}EN.con_{0});",
                                 objQryRegionFldsEx.FldName,
                                     objViewInfoENEx.TabName_Out,
                                    "{", "}");
                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        case "CheckBoxList":
                            break;
                        case "DataGrid":
                            break;
                        case "DataList":
                            break;
                        case "DropDownList": ///如果控件是下拉框;
                            if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                            {
                                strCodeForCs.AppendFormat("\r\n" + "String str{0} = this.get{0}_q();",
                              objQryRegionFldsEx.FldName,
                              objQryRegionFldsEx.CtrlId());
                                strCodeForCs.AppendFormat("\r\n" + "if (\"0\".equals(str{0}) == false)",
                                objQryRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "{");

                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += String.format(\" And %s = '1'\", cls{1}EN.con_{0}); ",
                                      objQryRegionFldsEx.FldName,
                                       objViewInfoENEx.TabName_Out,
                                      "{", "}");
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.AppendFormat("\r\n" + "else if (this.{0}_q.SelectedIndex == 2)",
                                objQryRegionFldsEx.CtrlId());
                                strCodeForCs.Append("\r\n" + "{");

                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += String.format(\" And %s = '0'\", cls{1}EN.con_{0});",
                                       objQryRegionFldsEx.FldName,
                                     objViewInfoENEx.TabName_Out,
                                      "{", "}");
                                strCodeForCs.Append("\r\n" + "}");

                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "String str{0} = this.get{0}_q();",
                           objQryRegionFldsEx.FldName,
                           objQryRegionFldsEx.CtrlId());
                                strCodeForCs.AppendFormat("\r\n" + "if (\"\".equals(str{0}) == false && \"0\".equals(str{0}) == false)",
                               objQryRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "{");

                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += String.format(\" And %s = '%s'\", cls{2}EN.con_{0}, str{0});",
                                objQryRegionFldsEx.FldName,
                                objQryRegionFldsEx.FldName + "_q",
                                objViewInfoENEx.TabName_Out,
                                "{", "}");
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            break;
                        case "HyperLink":
                            break;
                        case "Image":
                            break;
                        case "ImageButton":
                            break;
                        case "Label":
                            break;
                        case "Link1Button":
                            break;
                        case "ListBox":
                            break;
                        case "Panel":
                            break;
                        case "RadioButton":
                            break;
                        case "RadioButtonList":
                            break;
                        case "TextBox": ///如果控件类型是文本框;
                            if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() != "string"
                                && objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02)
                            {
                                objQryRegionFldsEx.QueryOptionId = enumQueryOption.EqualQuery_01;
                            }
                            if ((objQryRegionFldsEx.QueryOptionId == enumQueryOption.Known_00) ||
                            (objQryRegionFldsEx.QueryOptionId == enumQueryOption.EqualQuery_01)) ///相等查询;
                            {
                                strCodeForCs.AppendFormat("\r\n" + "String str{0} = {1}.getText().toString();",
                                  objQryRegionFldsEx.FldName,
                                  objQryRegionFldsEx.CtrlId());

                                strCodeForCs.AppendFormat("\r\n" + "if (\"\".equals(str{0}) == false)", objQryRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "{");
                              
                                if (objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += String.format(\" And %s = '%s'\", cls{2}EN.con_{0}, str{0});",
                                objQryRegionFldsEx.FldName,
                                objQryRegionFldsEx.FldName + "_q",
                                objViewInfoENEx.TabName_Out);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += String.format(\" And %s = %s\", cls{2}EN.con_{0}, str{0});",
                             objQryRegionFldsEx.FldName,
                             objQryRegionFldsEx.FldName + "_q",
                             objViewInfoENEx.TabName_Out);
                                }
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02) ///模糊查询;
                            {
                                strCodeForCs.AppendFormat("\r\n" + "String str{0} = {1}.getText().toString();",
                                 objQryRegionFldsEx.FldName,
                                 objQryRegionFldsEx.CtrlId());

                                strCodeForCs.AppendFormat("\r\n" + "if (\"\".equals(str{0}) == false)", objQryRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "{");
                                   strCodeForCs.AppendFormat("\r\n" + "strWhereCond += String.format(\" And %s like '%s%s'\", cls{2}EN.con_{0}, str{0},\"%\");",
                                   objQryRegionFldsEx.FldName,
                                     objQryRegionFldsEx.FldName + "_q",
                                     objViewInfoENEx.TabName_Out,
                                     "{", "}");
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.RangeQuery_03)
                            { ///范围查询;
                                strCodeForCs.AppendFormat("\r\n" + "String str{0} = {1}.getText().toString();",
                                        objQryRegionFldsEx.FldName,
                                         objQryRegionFldsEx.CtrlId());
                                strCodeForCs.AppendFormat("\r\n" + "if (\"\".equals(str{0}) == false)", objQryRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += String.format(\" And %s = '%s'\", cls{2}EN.con_{0}, str{0});",
                                objQryRegionFldsEx.FldName,
                                objQryRegionFldsEx.FldName + "_q",
                                objViewInfoENEx.TabName_Out,
                                "{", "}");
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "String str{0} = {1}.getText().toString();",
                                    objQryRegionFldsEx.FldName,
                                     objQryRegionFldsEx.CtrlId());
                                strCodeForCs.AppendFormat("\r\n" + "if (\"\".equals(str{0}) == false)", objQryRegionFldsEx.CtrlId());
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += String.format(\"And %s = '%s'\", cls{2}EN.con_{0}, str{0});",
                                     objQryRegionFldsEx.FldName,
                                      objQryRegionFldsEx.FldName + "_q",
                                      objViewInfoENEx.TabName_Out,
                                     "{", "}");
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            break;

                    }
                }              

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch(Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                //string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(clsProgLevelTypeENEx.WebInterfaceLevel,
                //  objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "CombineCondition", "(AndroidApp)在组合查询条件(Combine{0}Condition)时出错!请联系管理员!", "生成代码");

                strCodeForCs.AppendFormat("\r\n" + "String strMsg = String.format(\"(errid:{1})在组合查询条件(Combine{0}Condition)时出错!请联系管理员!\" + objException.getMessage());",
                   objViewInfoENEx.TabName, "999");
                strCodeForCs.Append("\r\n" + "//throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return strWhereCond;");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
                

        public void Gen_btnGetJSONObjLst_Click(clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs, string strTabName)
        {
            strCodeForCs.Append("\r\n" + "/// <summary>");
            strCodeForCs.Append("\r\n" + "/// 根据条件获取相应的对象列表");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "/// </summary>");
            strCodeForCs.Append("\r\n" + "/// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n" + "/// <returns></returns>");
            strCodeForCs.Append("\r\n" + "    public void btnGetJSONObjLst_Click(View myView)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "{0}.icls{1}GetJSONObjLstEx iobj{1}GetJSONObjLst = new {0}.icls{1}GetJSONObjLstEx({0}.this);",
                objViewInfoENEx.WebFormName, strTabName);
            strCodeForCs.AppendFormat("\r\n" + "iobj{0}GetJSONObjLst.main();",
                strTabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
        }

        public string Gen_Class4GetJSONObjLstEx(clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs, string strTabName)
        {
        
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取相应的记录对象列表的相关扩展类");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.AppendFormat("\r\n" + "public void btnGetJSONObjLst_Click(View myView) ",
                objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "icls{1}GetJSONObjLstEx iobj{1}GetJSONObjLst = new icls{1}GetJSONObjLstEx({0}.this);",
                objViewInfoENEx.WebFormName,   strTabName);
            strCodeForCs.AppendFormat("\r\n" + "iobj{0}GetJSONObjLst.main();",
                strTabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "class icls{0}GetJSONObjLstEx extends cls{0}_Controller.icls{0}GetJSONObjLst",
                strTabName);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                strTabName);

            strCodeForCs.AppendFormat("\r\n" + "public icls{0}GetJSONObjLstEx(Object pvcParent)",
    strTabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "super(pvcParent);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "@Override");

            strCodeForCs.Append("\r\n" + "public void main()");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
                strTabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                strTabName);
            //            strCodeForCs.Append("\r\n" + "String strWhereCond =\" 1=1 \";");

            strCodeForCs.AppendFormat("\r\n" + "String strWhereCond = Combine{0}Condition();",
           strTabName);

            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.GetJSONObjLst(strWhereCond);",
                strTabName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "//通过WebService执行GetRecordObjLst,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(Object returnObjectList, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLst,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLst = (List<cls{0}EN>)returnObjectList;",
                strTabName);

            strCodeForCs.AppendFormat("\r\n" + "//arr{0}ENExLst.clear();",
                strTabName);
            strCodeForCs.AppendFormat("\r\n" + "//for (cls{0}EN obj{0}EN : arr{0}ObjLst)",
                strTabName);
            strCodeForCs.Append("\r\n" + "//{");
            strCodeForCs.AppendFormat("\r\n" + "//cls{0}ENEx obj{0}ENEx = new cls{0}ENEx(obj{0}EN, R.drawable.aa1);",
                strTabName);
            strCodeForCs.AppendFormat("\r\n" + "//arr{0}ObjExLst.add(obj{0}ENEx);",
                strTabName);
            strCodeForCs.Append("\r\n" + "//}");
            strCodeForCs.AppendFormat("\r\n" + "lv{1}Adapter adapter4ListView = new lv{1}Adapter({0}.this,",
                 objViewInfoENEx.WebFormName, strTabName);
            strCodeForCs.AppendFormat("\r\n" + "R.layout.uc_{1}_lvitem, arr{0}ObjLst);",
                strTabName, strTabName.ToLower());

            strCodeForCs.AppendFormat("\r\n" + "//设置适配器");
            strCodeForCs.AppendFormat("\r\n" + "lv{0}.setAdapter(adapter4ListView);",
                strTabName);

            strCodeForCs.AppendFormat("\r\n" + "String strWhereCond = Combine{0}Condition();",
                strTabName);
            strCodeForCs.AppendFormat("\r\n" + "String strInfo = String.format(\"根据条件:[%s]共获取对象列表数：%s!\", strWhereCond, arr{0}ObjLst.size());",
                strTabName);
            strCodeForCs.Append("\r\n" + "tvMsg.setText(strInfo);");
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "mobjParentObjDelegate_Task.NotifyFinished(\"{0}\", 1);", enumDict4GC_DictKey1.conGetRecordJSONObjLst);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

            

        public void Gen_BindLv_TabName(clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs, string strTabName)
        {
            strCodeForCs.Append("\r\n" + "/// <summary>");
            strCodeForCs.Append("\r\n" + "/// 根据条件,绑定列表");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "/// </summary>");
            strCodeForCs.Append("\r\n" + "/// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n" + "/// <returns></returns>");
            strCodeForCs.AppendFormat("\r\n" + "  private void BindLv_{0}()",
                strTabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "{0}.icls{1}GetJSONObjLstByPagerEx iobj{1}GetJSONObjLstByPager = new {0}.icls{1}GetJSONObjLstByPagerEx({0}.this);",
                objViewInfoENEx.WebFormName, strTabName);
            strCodeForCs.AppendFormat("\r\n" + "iobj{0}GetJSONObjLstByPager.main();",
                strTabName);
            strCodeForCs.Append("\r\n" + "}");

        }

        /// <summary>
        /// 定义查询区的控件存取属性
        /// </summary>
        /// <returns></returns>
        public void Gen_FieldProperty4Query(clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs)
        {
            AndroidControlEx objAndroidControlENEx = null;
            ///定义类属性
            foreach (clsQryRegionFldsENEx objQryRegionFldsENEx in objViewInfoENEx.arrQryRegionFldSet)
            {
                try
                {
                    objAndroidControlENEx = clsAndroidControlBLEx.GetAndroidControlObjByQryFld(objQryRegionFldsENEx);
                    clsAndroidControlBLEx.Gen_GetValue4FieldCtrl4Qry(objAndroidControlENEx, strCodeForCs);

                    clsAndroidControlBLEx.Gen_SetValue4FieldCtrl4Qry(objAndroidControlENEx, strCodeForCs);

                    strCodeForCs.Append("\r\n");
                }
                catch(Exception objException)
                {
                    string strSS = objException.Message;
                    throw new Exception(strSS);
                }
            }
        }

        /// <summary>
        /// 定义列表区的控件存取属性
        /// </summary>
        /// <returns></returns>
        public void Gen_FieldProperty4List(clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs)
        {
            AndroidControlEx objAndroidControlENEx = null;
            ///定义类属性
            foreach (clsQryRegionFldsENEx objQryRegionFldsENEx in objViewInfoENEx.arrQryRegionFldSet)
            {
                try
                {
                    objAndroidControlENEx = clsAndroidControlBLEx.GetAndroidControlObjByQryFld(objQryRegionFldsENEx);
                    clsAndroidControlBLEx.Gen_GetValue4FieldCtrl4Qry(objAndroidControlENEx, strCodeForCs);

                    clsAndroidControlBLEx.Gen_SetValue4FieldCtrl4Qry(objAndroidControlENEx, strCodeForCs);

                    strCodeForCs.Append("\r\n");
                }
                catch (Exception objException)
                {
                    string strSS = objException.Message;
                    throw new Exception(strSS);
                }
            }
        }

        /// <summary>
        /// 定义查询区的控件存取属性
        /// </summary>
        /// <returns></returns>
        public void Gen_FieldProperty4Edit(clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs)
        {

            ///定义类属性
            foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
            {
                try
                {
                    AndroidControlEx objAndroidControlENEx = clsAndroidControlBLEx.GetAndroidControlObjByEditFld(objEditRegionFldsEx);
                    clsAndroidControlBLEx.Gen_GetValue4FieldCtrl4Edit(objAndroidControlENEx, strCodeForCs);

                    clsAndroidControlBLEx.Gen_SetValue4FieldCtrl4Edit(objAndroidControlENEx, strCodeForCs);

                    strCodeForCs.Append("\r\n");
                }
                catch(Exception objException)
                {
                    throw objException;
//                    string strSS = objException.Message;
                }
            }
        }

        public void Gen_Class4GetJSONObjLstByPagerEx(clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs, string strTabName, string strPageName)
        {
       
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取相应的分页对象列表");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.AppendFormat("\r\n" + "public void btnGetJSONObjLstByPager_Click(View myView) ",
                strTabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "icls{0}GetJSONObjLstByPagerEx iobj{0}GetJSONObjLstByPager = new icls{0}GetJSONObjLstByPagerEx({1}.this);",
              strTabName, strPageName);
            strCodeForCs.AppendFormat("\r\n" + "iobj{0}GetJSONObjLstByPager.main();",
                strTabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "class icls{0}GetJSONObjLstByPagerEx extends cls{0}_Controller.icls{0}GetJSONObjLstByPager",
                strTabName);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                strTabName);

            strCodeForCs.AppendFormat("\r\n" + "public icls{0}GetJSONObjLstByPagerEx(Object pvcParent)",
                strTabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "super(pvcParent);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "@Override");

            strCodeForCs.Append("\r\n" + "public void main()");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
                strTabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                strTabName);
            strCodeForCs.Append("\r\n" + "Integer intPageIndex = mintPageIndex;");
            strCodeForCs.Append("\r\n" + "Integer intPageSize = mintPageSize;");
            strCodeForCs.AppendFormat("\r\n" + "String strWhereCond = Combine{0}Condition();", strTabName);
            strCodeForCs.Append("\r\n" + "mstrWhereCond = strWhereCond;");
//            strCodeForCs.Append("\r\n" + "String strWhereCond = mstrWhereCond;");

            strCodeForCs.Append("\r\n" + "String strOrderBy =mstrOrderBy;");
            //GC_GetInputValue4Para(objvFunction4GeneCodeEN, strCodeForCs);

            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.GetJSONObjLstByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);",
                strTabName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "//通过WebService执行GetRecordObjLstByPager,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(Object returnObjectList, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLstByPager,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLst = (List<cls{0}EN>)returnObjectList;",
                strTabName);
            strCodeForCs.AppendFormat("\r\n" + "//arr{0}ENExLst.clear();",
             strTabName);
            strCodeForCs.AppendFormat("\r\n" + "//for (cls{0}EN obj{0}EN : arr{0}ObjLst)",
                strTabName);
            strCodeForCs.Append("\r\n" + "//{");
            strCodeForCs.AppendFormat("\r\n" + "//cls{0}ENEx obj{0}ENEx = new cls{0}ENEx(obj{0}EN, R.drawable.aa1);",
                strTabName);
            strCodeForCs.AppendFormat("\r\n" + "//arr{0}ObjExLst.add(obj{0}ENEx);",
                strTabName);
            strCodeForCs.Append("\r\n" + "//}");
            strCodeForCs.AppendFormat("\r\n" + "lv{1}Adapter adapter4ListView = new lv{1}Adapter({0}.this,",
                 objViewInfoENEx.WebFormName, strTabName);
            strCodeForCs.AppendFormat("\r\n" + "R.layout.uc_{1}_lvitem, arr{0}ObjLst);",
                strTabName, strTabName.ToLower());

            strCodeForCs.AppendFormat("\r\n" + "//设置适配器");
            strCodeForCs.AppendFormat("\r\n" + "lv{0}.setAdapter(adapter4ListView);",
                strTabName);

            strCodeForCs.AppendFormat("\r\n" + "String strWhereCond = Combine{0}Condition();",
                strTabName);
          //  strCodeForCs.AppendFormat("\r\n" + "String strWhereCond = mstrWhereCond;");
            strCodeForCs.AppendFormat("\r\n" + "String strPageIndex = Integer.toString(mintPageIndex);");
            strCodeForCs.AppendFormat("\r\n" + "String strPageSize = Integer.toString(mintPageSize);");
            strCodeForCs.AppendFormat("\r\n" + " String strPageStatus = String.format(\"共%s条 %s条/页 共%s页 当前第%s页 \", mintTotalRecCount, mintPageSize, mintTotalPages, mintPageIndex);");
            strCodeForCs.AppendFormat("\r\n" + "   tvPageStatus.setText(strPageStatus);");
            strCodeForCs.AppendFormat("\r\n" + "//String strInfo = String.format(\"根据条件:[%s],每页记录数:[%s],第[%s]页,共获取分页对象列表数：%s!\", strWhereCond, strPageSize, strPageIndex, arr{0}ObjLst.size());",
                strTabName);
            strCodeForCs.Append("\r\n" + "//tvMsg.setText(strInfo);");
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "//clsPubFun.ShowMessage((Activity)vcParent, strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "mobjParentObjDelegate_Task.NotifyFinished(\"{0}\", 1);", enumDict4GC_DictKey1.conGetRecordJSONObjLstByPager);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            
        }
        public string Gen_Class4GetMaxStrIdEx(clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs, string strTabName)
        {
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 获取当前表关键字值的最大值,再加1,避免重复");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.Append("\r\n" + "public void btnGetMaxStrId_Click(View myView) {");
            strCodeForCs.AppendFormat("\r\n" + "icls{0}GetMaxStrIdEx iobj{0}GetMaxStrId = new icls{0}GetMaxStrIdEx({1}.this);",
                strTabName, objViewInfoENEx.WebFormName);
            strCodeForCs.AppendFormat("\r\n" + "iobj{0}GetMaxStrId.main();",
                strTabName);

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "class icls{0}GetMaxStrIdEx extends cls{0}_Controller.icls{0}GetMaxStrId",
                strTabName);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                strTabName);

            strCodeForCs.AppendFormat("\r\n" + "public icls{0}GetMaxStrIdEx(Object pvcParent)",
    strTabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "super(pvcParent);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "@Override");

            strCodeForCs.Append("\r\n" + "public void main()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
           strTabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                strTabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.GetMaxStrId();",
                strTabName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "//通过WebService执行GetMaxStrId,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(String returnString, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (returnString == \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "String strInfo = String.format(\"获取表{0}的最大关键字为空,不成功,请检查!\");",
                strTabName);

            strCodeForCs.Append("\r\n" + "tvMsg.setText(strInfo);");
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "mobjParentObjDelegate_Task.NotifyFinished(\"{0}\", 1);", enumDict4GC_DictKey1.conGetMaxStrId);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
            {
                if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                    && objEditRegionFldsEx.PrimaryTypeId()== clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02)
                {
                    //AndroidControlEx objAndroidControlENEx = clsAndroidControlBLEx.GetAndroidControlObjByEditFld(objEditRegionFldsEx);
                    
                    strCodeForCs.AppendFormat("\r\n" + "set{0}(returnString);",
                         objEditRegionFldsEx.FldName);
                }
            }
            strCodeForCs.AppendFormat("\r\n" + "String strInfo = String.format(\"获取表{0}的最大关键字为：%s!\", returnString);",
                strTabName);
            strCodeForCs.Append("\r\n" + "tvMsg.setText(strInfo);");
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }
        /// <summary>
        /// 根据关键字获取相应的记录的对象 
        /// </summary>
        /// <returns></returns>
        public string Gen_Class4GetRecCountByCondEx(clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs, string strTabName)
        {   
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 检查相应关键字的记录是否存在");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">发送者</param>");
            strCodeForCs.Append("\r\n /// <returns>返回是否存在</returns>");

            strCodeForCs.Append("\r\n" + "public void btnGetRecCountByCond_Click(View myView) {");


            strCodeForCs.AppendFormat("\r\n" + "icls{0}GetRecCountByCondEx iobj{0}GetRecCountByCond = new icls{0}GetRecCountByCondEx({1}.this);",
                strTabName, objViewInfoENEx.WebFormName);
            strCodeForCs.AppendFormat("\r\n" + "iobj{0}GetRecCountByCond.main();",
                strTabName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "class icls{0}GetRecCountByCondEx extends cls{0}_Controller.icls{0}GetRecCountByCond",
                strTabName);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                strTabName);
            strCodeForCs.AppendFormat("\r\n" + "public icls{0}GetRecCountByCondEx(Object pvcParent)",
                strTabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "super(pvcParent);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.Append("\r\n" + "public void main()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
                strTabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                strTabName);
            //strCodeForCs.AppendFormat("\r\n" + "String strWhereCond = \"{0} ='12'\";",
            //    objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "String strWhereCond = Combine{0}Condition();",
                    strTabName);
            strCodeForCs.AppendFormat("\r\n" + "mstrWhereCond = strWhereCond;",
          strTabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.GetRecCountByCond(strWhereCond);",
                strTabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//通过WebService执行GetRecCountByCond,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(int returnInt, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecCountByCond,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "mintTotalRecCount = returnInt;//总记录数,用于获取分页对象列表");
            strCodeForCs.Append("\r\n" + "mintTotalPages = mintTotalRecCount/mintPageSize + 1;//总页数,用于获取分页对象列表");


            strCodeForCs.AppendFormat("\r\n" + "String strInfo = String.format(\"根据条件:[%s]的记录数:[%s]!\", mstrWhereCond, returnInt);",
                objViewInfoENEx.arrKeyPrjTabFldSet[0].ObjFieldTabENEx.FldName);
            strCodeForCs.Append("\r\n" + "tvMsg.setText(strInfo);");
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.AppendFormat("\r\n" + "clsPubFun.ShowMessage(({1})vcParent, strInfo);",
                strTabName, objViewInfoENEx.WebFormName);
            strCodeForCs.AppendFormat("\r\n" + "mobjParentObjDelegate_Task.NotifyFinished(\"{0}\", 1);", enumDict4GC_DictKey1.conGetRecCountByCond);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 根据关键字获取相应的记录的对象 
        /// </summary>
        /// <returns></returns>
        public string Gen_GetRecCountByCond(clsViewInfoENEx objViewInfoENEx, StringBuilder strCodeForCs, string strTabName)
        {
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 检查相应关键字的记录是否存在");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">发送者</param>");
            strCodeForCs.Append("\r\n /// <returns>返回是否存在</returns>");

            strCodeForCs.Append("\r\n" + "public void GetRecCountByCond() {");


            strCodeForCs.AppendFormat("\r\n" + "icls{0}GetRecCountByCondEx iobj{0}GetRecCountByCond = new icls{0}GetRecCountByCondEx({1}.this);",
                strTabName, objViewInfoENEx.WebFormName);
            strCodeForCs.AppendFormat("\r\n" + "iobj{0}GetRecCountByCond.main();",
                strTabName);
            strCodeForCs.Append("\r\n" + "}");
            
            return strCodeForCs.ToString();
        }
        /// <summary>
        /// 生成指定的函数
        /// </summary>
        /// <returns>返回生成的指定函数代码</returns>
        public string A_GenCode4Function(clsViewInfoENEx objViewInfoENEx, string strFuncId4GC)
        {
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            
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
                 A_GeneFuncCode(strFuncName, objViewInfoENEx, strCodeForCs, objViewInfoENEx.WebFormName);
                //A_GeneFuncCode(objvFunction4CodeEN_In.FuncName4Code, objViewInfoENEx, strCodeForCs, objViewInfoENEx.WebFormName);

                //foreach (clsvFunction4CodeEN objvFunction4CodeEN_In in arrvFunction4CodeObjLst4CurrView)
                //{
                //    strCodeForCs.AppendFormat("\r\n" + "//生成函数：{0}、[{1}]", intIndex++, objvFunction4CodeEN_In.FuncName4Code);
                //    A_GeneFuncCode(objvFunction4CodeEN_In.FuncName4Code, objViewInfoENEx, strCodeForCs, objViewInfoENEx.WebFormName);
                //}
                //}

                //if (string.IsNullOrEmpty(strTemp) == false)
                //{
                //    strCodeForCs.Append("\r\n" + strTemp);
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

        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(AppViewScriptContent4JAVA);
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
            this.ClsName = string.Format("content_{0}_qudi", objViewInfoENEx.TabName);
            objViewInfoENEx.ClsName = this.ClsName;
        }
      
    }
}
