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
using AGC.PureClass;

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
        public ISOButtonEx A_GeneFuncCode_Swift4_Desk_top_DefButton(string strFuncName, string strViewControllerID, ref int intY)
        {
            try
            {
                switch (strFuncName)
                {

                    case "Gen_Controller_Swift4_Desk_top_DefButtonGetFirstJSONObj":
                        return Gen_Controller_Swift4_Desk_top_DefButtonGetFirstJSONObj(strViewControllerID, ref intY);

                    case "Gen_Controller_Swift4_Desk_top_DefButtonGetJSONObjByKey":
                        return Gen_Controller_Swift4_Desk_top_DefButtonGetJSONObjByKey(strViewControllerID, ref intY);

                    case "Gen_Controller_Swift4_Desk_top_DefButtonDelRecord":
                        return Gen_Controller_Swift4_Desk_top_DefButtonDelRecord(strViewControllerID, ref intY);

                    case "Gen_Controller_Swift4_Desk_top_DefButtonAddNewRecord":
                        return Gen_Controller_Swift4_Desk_top_DefButtonAddNewRecord(strViewControllerID, ref intY);

                    case "Gen_Controller_Swift4_Desk_top_DefButtonAddNewRecord4GetMaxStrId":
                        return Gen_Controller_Swift4_Desk_top_DefButtonAddNewRecord4GetMaxStrId(strViewControllerID, ref intY);
                    case "Gen_Controller_Swift4_Desk_top_DefButtonGetMaxStrId":
                        return Gen_Controller_Swift4_Desk_top_DefButtonGetMaxStrId(strViewControllerID, ref intY);
                    case "Gen_Controller_Swift4_Desk_top_DefButtonGetMaxStrIdByPrefix":
                        return Gen_Controller_Swift4_Desk_top_DefButtonGetMaxStrIdByPrefix(strViewControllerID, ref intY);

                    case "Gen_Controller_Swift4_Desk_top_DefButtonUpdateRecord":
                        return Gen_Controller_Swift4_Desk_top_DefButtonUpdateRecord(strViewControllerID, ref intY);

                    case "Gen_Controller_Swift4_Desk_top_DefButtonIsExistRecord":
                        return Gen_Controller_Swift4_Desk_top_DefButtonIsExistRecord(strViewControllerID, ref intY);

                    case "Gen_Controller_Swift4_Desk_top_DefButtonGetRecCountByCond":
                        return Gen_Controller_Swift4_Desk_top_DefButtonGetRecCountByCond(strViewControllerID, ref intY);

                    case "Gen_Controller_Swift4_Desk_top_DefButtonGetJSONObjLst":
                        return Gen_Controller_Swift4_Desk_top_DefButtonGetJSONObjLst(strViewControllerID, ref intY);

                    case "Gen_Controller_Swift4_Desk_top_DefButtonGetTopJSONObjLst":
                        return Gen_Controller_Swift4_Desk_top_DefButtonGetTopJSONObjLst(strViewControllerID, ref intY);

                    case "Gen_Controller_Swift4_Desk_top_DefButtonGetJSONObjLstByPager":
                        return Gen_Controller_Swift4_Desk_top_DefButtonGetJSONObjLstByPager(strViewControllerID, ref intY);
                    //case "Gen_Controller_Swift4_Desk_top_DefButtontvMsg":
                    //    return Gen_Controller_Swift4_Desk_top_DefButtontvMsg(strViewControllerID, ref intY);
                        
                    default:
                        string strMsg = string.Format("功能名:{1}在Switch没有处理,请检查({0})",
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
        public ISOButtonEx Gen_Controller_Swift4_Desk_top_DefButtonAddNewRecord(string strViewControllerID, ref int intY)
        {
            intY += 30;
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "AddNewRecord";
            string strFunctionName_CN = "添加新记录";
            string strButtonId = AgcPubFun.getSwiftID();
            string strActionId = AgcPubFun.getSwiftID();
            ISOButtonEx objISOButtonEN = new ISOButtonEx();
            objISOButtonEN.IsoControlId = strButtonId;
            objISOButtonEN.IsoControlName = strFunctionName;
            objISOButtonEN.ParentViewControllerID = strViewControllerID;
            objISOButtonEN.Text = strFunctionName_CN;
            objISOButtonEN.y = intY;
            objISOButtonEN.x = 0;
            objISOButtonEN.Width = 130;
            objISOButtonEN.Height = 30;
            ISOActionEx objISOActionEN = new ISOActionEx();
            objISOActionEN.destination = strViewControllerID;
            objISOActionEN.EventFuncName = string.Format("btn{0}_Click", strFunctionName);
            objISOButtonEN.arrSubIsoControlLst2.Add(objISOActionEN);
            return objISOButtonEN;
     
        }

        public ISOButtonEx Gen_Controller_Swift4_Desk_top_DefButtonAddNewRecord4GetMaxStrId(string strViewControllerID, ref int intY)
        {
            intY += 30;
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "AddNewRecord4GetMaxStrId";
            string strFunctionName_CN = "添加新记录(获取最大关键字)";
            string strButtonId = AgcPubFun.getSwiftID();
            string strActionId = AgcPubFun.getSwiftID();
            ISOButtonEx objISOButtonEN = new ISOButtonEx();
            objISOButtonEN.IsoControlId = strButtonId;
            objISOButtonEN.IsoControlName = strFunctionName;
            objISOButtonEN.ParentViewControllerID = strViewControllerID;
            objISOButtonEN.Text = strFunctionName_CN;
            objISOButtonEN.y = intY;
            objISOButtonEN.x = 0;
            objISOButtonEN.Width = 130;
            objISOButtonEN.Height = 30;
            ISOActionEx objISOActionEN = new ISOActionEx();
            objISOActionEN.destination = strViewControllerID;
            objISOActionEN.EventFuncName = string.Format("btn{0}_Click", strFunctionName);
            objISOButtonEN.arrSubIsoControlLst2.Add(objISOActionEN);
            return objISOButtonEN;

            //return strBuilder.ToString();
        }

        public ISOButtonEx Gen_Controller_Swift4_Desk_top_DefButtonGetMaxStrId(string strViewControllerID, ref int intY)
        {
            intY += 30;
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetMaxStrId";
            string strFunctionName_CN = "获取最大关键字值";
            string strButtonId = AgcPubFun.getSwiftID();
            string strActionId = AgcPubFun.getSwiftID();

            ISOButtonEx objISOButtonEN = new ISOButtonEx();
            objISOButtonEN.IsoControlId = strButtonId;
            objISOButtonEN.IsoControlName = strFunctionName;
            objISOButtonEN.ParentViewControllerID = strViewControllerID;
            objISOButtonEN.Text = strFunctionName_CN;
            objISOButtonEN.y = intY;
            objISOButtonEN.x = 0;
            objISOButtonEN.Width = 130;
            objISOButtonEN.Height = 30;
            ISOActionEx objISOActionEN = new ISOActionEx();
            objISOActionEN.destination = strViewControllerID;
            objISOActionEN.EventFuncName = string.Format("btn{0}_Click", strFunctionName);
            objISOButtonEN.arrSubIsoControlLst2.Add(objISOActionEN);
            return objISOButtonEN;
        }

        public ISOButtonEx Gen_Controller_Swift4_Desk_top_DefButtonGetMaxStrIdByPrefix(string strViewControllerID, ref int intY)
        {
            intY += 30;
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetMaxStrIdByPrefix";
            string strFunctionName_CN = "获取最大关键字值,根据前缀";
            string strButtonId = AgcPubFun.getSwiftID();
            string strActionId = AgcPubFun.getSwiftID();
            ISOButtonEx objISOButtonEN = new ISOButtonEx();
            objISOButtonEN.IsoControlId = strButtonId;
            objISOButtonEN.IsoControlName = strFunctionName;
            objISOButtonEN.ParentViewControllerID = strViewControllerID;
            objISOButtonEN.Text = strFunctionName_CN;
            objISOButtonEN.y = intY;
            objISOButtonEN.x = 0;
            objISOButtonEN.Width = 130;
            objISOButtonEN.Height = 30;
            ISOActionEx objISOActionEN = new ISOActionEx();
            objISOActionEN.destination = strViewControllerID;
            objISOActionEN.EventFuncName = string.Format("btn{0}_Click", strFunctionName);
            objISOButtonEN.arrSubIsoControlLst2.Add(objISOActionEN);
            return objISOButtonEN;
        }

        public ISOButtonEx Gen_Controller_Swift4_Desk_top_DefButtonUpdateRecord(string strViewControllerID, ref int intY)
        {
            intY += 30;
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "UpdateRecord";
            string strFunctionName_CN = "修改记录";
            string strButtonId = AgcPubFun.getSwiftID();
            string strActionId = AgcPubFun.getSwiftID();

            ISOButtonEx objISOButtonEN = new ISOButtonEx();
            objISOButtonEN.IsoControlId = strButtonId;
            objISOButtonEN.IsoControlName = strFunctionName;
            objISOButtonEN.ParentViewControllerID = strViewControllerID;
            objISOButtonEN.Text = strFunctionName_CN;
            objISOButtonEN.y = intY;
            objISOButtonEN.x = 0;
            objISOButtonEN.Width = 130;
            objISOButtonEN.Height = 30;
            ISOActionEx objISOActionEN = new ISOActionEx();
            objISOActionEN.destination = strViewControllerID;
            objISOActionEN.EventFuncName = string.Format("btn{0}_Click", strFunctionName);
            objISOButtonEN.arrSubIsoControlLst2.Add(objISOActionEN);
            return objISOButtonEN;
        }

        public ISOButtonEx Gen_Controller_Swift4_Desk_top_DefButtonDelRecord(string strViewControllerID, ref int intY)
        {
            intY += 30;
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "DelRecord";
            string strFunctionName_CN = "删除记录";
            string strButtonId = AgcPubFun.getSwiftID();
            string strActionId = AgcPubFun.getSwiftID();

            ISOButtonEx objISOButtonEN = new ISOButtonEx();
            objISOButtonEN.IsoControlId = strButtonId;
            objISOButtonEN.IsoControlName = strFunctionName;
            objISOButtonEN.ParentViewControllerID = strViewControllerID;
            objISOButtonEN.Text = strFunctionName_CN;
            objISOButtonEN.y = intY;
            objISOButtonEN.x = 0;
            objISOButtonEN.Width = 130;
            objISOButtonEN.Height = 30;
            ISOActionEx objISOActionEN = new ISOActionEx();
            objISOActionEN.destination = strViewControllerID;
            objISOActionEN.EventFuncName = string.Format("btn{0}_Click", strFunctionName);
            objISOButtonEN.arrSubIsoControlLst2.Add(objISOActionEN);
            return objISOButtonEN;
        }
        /// <summary>
        /// 根据关键字获取相应的记录的对象 
        /// </summary>
        /// <returns></returns>
        public ISOButtonEx Gen_Controller_Swift4_Desk_top_DefButtonIsExistRecord(string strViewControllerID, ref int intY)
        {
            intY += 30;
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "IsExistRecord";
            string strFunctionName_CN = "检查是否存在记录";
            string strButtonId = AgcPubFun.getSwiftID();
            string strActionId = AgcPubFun.getSwiftID();

            ISOButtonEx objISOButtonEN = new ISOButtonEx();
            objISOButtonEN.IsoControlId = strButtonId;
            objISOButtonEN.IsoControlName = strFunctionName;
            objISOButtonEN.ParentViewControllerID = strViewControllerID;
            objISOButtonEN.Text = strFunctionName_CN;
            objISOButtonEN.y = intY;
            objISOButtonEN.x = 0;
            objISOButtonEN.Width = 130;
            objISOButtonEN.Height = 30;
            ISOActionEx objISOActionEN = new ISOActionEx();
            objISOActionEN.destination = strViewControllerID;
            objISOActionEN.EventFuncName = string.Format("btn{0}_Click", strFunctionName);
            objISOButtonEN.arrSubIsoControlLst2.Add(objISOActionEN);
            return objISOButtonEN;
        }

        public ISOButtonEx Gen_Controller_Swift4_Desk_top_DefButtonGetRecCountByCond(string strViewControllerID, ref int intY)
        {
            intY += 30;
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetRecCountByCond";
            string strFunctionName_CN = "根据条件获取记录数";
            string strButtonId = AgcPubFun.getSwiftID();
            string strActionId = AgcPubFun.getSwiftID();

            ISOButtonEx objISOButtonEN = new ISOButtonEx();
            objISOButtonEN.IsoControlId = strButtonId;
            objISOButtonEN.IsoControlName = strFunctionName;
            objISOButtonEN.ParentViewControllerID = strViewControllerID;
            objISOButtonEN.Text = strFunctionName_CN;
            objISOButtonEN.y = intY;
            objISOButtonEN.x = 0;
            objISOButtonEN.Width = 130;
            objISOButtonEN.Height = 30;
            ISOActionEx objISOActionEN = new ISOActionEx();
            objISOActionEN.destination = strViewControllerID;
            objISOActionEN.EventFuncName = string.Format("btn{0}_Click", strFunctionName);
            objISOButtonEN.arrSubIsoControlLst2.Add(objISOActionEN);
            return objISOButtonEN;
        }


        public ISOButtonEx Gen_Controller_Swift4_Desk_top_DefButtonGetJSONObjLst(string strViewControllerID, ref int intY)
        {
            intY += 30;
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetJSONObjLst";
            string strFunctionName_CN = "获取记录对象列表";
            string strButtonId = AgcPubFun.getSwiftID();
            string strActionId = AgcPubFun.getSwiftID();

            ISOButtonEx objISOButtonEN = new ISOButtonEx();
            objISOButtonEN.IsoControlId = strButtonId;
            objISOButtonEN.IsoControlName = strFunctionName;
            objISOButtonEN.ParentViewControllerID = strViewControllerID;
            objISOButtonEN.Text = strFunctionName_CN;
            objISOButtonEN.y = intY;
            objISOButtonEN.x = 0;
            objISOButtonEN.Width = 130;
            objISOButtonEN.Height = 30;
            ISOActionEx objISOActionEN = new ISOActionEx();
            objISOActionEN.destination = strViewControllerID;
            objISOActionEN.EventFuncName = string.Format("btn{0}_Click", strFunctionName);
            objISOButtonEN.arrSubIsoControlLst2.Add(objISOActionEN);
            return objISOButtonEN;
        }

        public ISOButtonEx Gen_Controller_Swift4_Desk_top_DefButtonGetTopJSONObjLst(string strViewControllerID, ref int intY)
        {
            intY += 30;
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetTopJSONObjLst";
            string strFunctionName_CN = "获取顶部记录对象列表";
            string strButtonId = AgcPubFun.getSwiftID();
            string strActionId = AgcPubFun.getSwiftID();

            ISOButtonEx objISOButtonEN = new ISOButtonEx();
            objISOButtonEN.IsoControlId = strButtonId;
            objISOButtonEN.IsoControlName = strFunctionName;
            objISOButtonEN.ParentViewControllerID = strViewControllerID;
            objISOButtonEN.Text = strFunctionName_CN;
            objISOButtonEN.y = intY;
            objISOButtonEN.x = 0;
            objISOButtonEN.Width = 130;
            objISOButtonEN.Height = 30;
            ISOActionEx objISOActionEN = new ISOActionEx();
            objISOActionEN.destination = strViewControllerID;
            objISOActionEN.EventFuncName = string.Format("btn{0}_Click", strFunctionName);
            objISOButtonEN.arrSubIsoControlLst2.Add(objISOActionEN);
            return objISOButtonEN;
        }

        public ISOButtonEx Gen_Controller_Swift4_Desk_top_DefButtonGetJSONObjLstByPager(string strViewControllerID, ref int intY)
        {
            intY += 30;
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetJSONObjLstByPager";
            string strFunctionName_CN = "获取分页记录对象列表";
            string strButtonId = AgcPubFun.getSwiftID();
            string strActionId = AgcPubFun.getSwiftID();

            ISOButtonEx objISOButtonEN = new ISOButtonEx();
            objISOButtonEN.IsoControlId = strButtonId;
            objISOButtonEN.IsoControlName = strFunctionName;
            objISOButtonEN.ParentViewControllerID = strViewControllerID;
            objISOButtonEN.Text = strFunctionName_CN;
            objISOButtonEN.y = intY;
            objISOButtonEN.x = 0;
            objISOButtonEN.Width = 130;
            objISOButtonEN.Height = 30;
            ISOActionEx objISOActionEN = new ISOActionEx();
            objISOActionEN.destination = strViewControllerID;
            objISOActionEN.EventFuncName = string.Format("btn{0}_Click", strFunctionName);
            objISOButtonEN.arrSubIsoControlLst2.Add(objISOActionEN);
            return objISOButtonEN;
        }

        public ISOButtonEx Gen_Controller_Swift4_Desk_top_DefButtonGetJSONObjByKey(string strViewControllerID, ref int intY)
        {
            intY += 30;
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetJSONObjByKey";
            string strFunctionName_CN = "根据关键字获取对象";
            string strButtonId = AgcPubFun.getSwiftID();
            string strActionId = AgcPubFun.getSwiftID();
            ISOButtonEx objISOButtonEN = new ISOButtonEx();
            objISOButtonEN.IsoControlId = strButtonId;
            objISOButtonEN.IsoControlName = strFunctionName;
            objISOButtonEN.ParentViewControllerID = strViewControllerID;
            objISOButtonEN.Text = strFunctionName_CN;
            objISOButtonEN.y = intY;
            objISOButtonEN.x = 0;
            objISOButtonEN.Width = 130;
            objISOButtonEN.Height = 30;
            ISOActionEx objISOActionEN = new ISOActionEx();
            objISOActionEN.destination = strViewControllerID;
            objISOActionEN.EventFuncName = string.Format("btn{0}_Click", strFunctionName);
            objISOButtonEN.arrSubIsoControlLst2.Add(objISOActionEN);
            return objISOButtonEN;
        }

        public ISOButtonEx Gen_Controller_Swift4_Desk_top_DefButtonGetFirstJSONObj(string strViewControllerID, ref int intY)
        {
            intY += 30;
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetFirstJSONObj";
            string strFunctionName_CN = "获取满足条件的第一条记录对象";
            string strButtonId = AgcPubFun.getSwiftID();
            string strActionId = AgcPubFun.getSwiftID();

            ISOButtonEx objISOButtonEN = new ISOButtonEx();
            objISOButtonEN.IsoControlId = strButtonId;
            objISOButtonEN.IsoControlName = strFunctionName;
            objISOButtonEN.ParentViewControllerID = strViewControllerID;
            objISOButtonEN.Text = strFunctionName_CN;
            objISOButtonEN.y = intY;
            objISOButtonEN.x = 0;
            objISOButtonEN.Width = 130;
            objISOButtonEN.Height = 30;
            ISOActionEx objISOActionEN = new ISOActionEx();
            objISOActionEN.destination = strViewControllerID;
            objISOActionEN.EventFuncName = string.Format("btn{0}_Click",  strFunctionName);
            objISOButtonEN.arrSubIsoControlLst2.Add(objISOActionEN);

            return objISOButtonEN;
        }


        public static ISOButtonEx GetISOButton4NavigitionBar_Swift4_Desk_top(
            string strText, 
            string strViewControllerID,
            string strEventFunc)
        {
           
            StringBuilder strBuilder = new StringBuilder();
            //string strFunctionName = "GetFirstJSONObj";
            //string strFunctionName_CN = "获取满足条件的第一条记录对象";
            string strButtonId = AgcPubFun.getSwiftID();
            
            ISOButtonEx objISOButtonEN = new ISOButtonEx();
            objISOButtonEN.IsoControlId = strButtonId;
            //objISOButtonEN.IsoControlName = strFunctionName;
            objISOButtonEN.ParentViewControllerID = strViewControllerID;
            objISOButtonEN.Text = strText;
            objISOButtonEN.y = 7;
            objISOButtonEN.x = 0;
            objISOButtonEN.Width = 130;
            objISOButtonEN.Height = 30;
            objISOButtonEN.mKey = "customView";
            ISOAutoresizingMaskEx objISOAutoresizingMaskEN = new ISOAutoresizingMaskEx();
        
            objISOButtonEN.arrSubIsoControlLst2.Add(objISOAutoresizingMaskEN);

            if (string .IsNullOrEmpty(strEventFunc) == false)
            {
                ISOActionEx objISOActionEN = new ISOActionEx();
                objISOActionEN.destination = strViewControllerID;
                objISOActionEN.EventFuncName = strEventFunc;
                objISOButtonEN.arrSubIsoControlLst2.Add(objISOActionEN);
            }
            return objISOButtonEN;
        }
        public string Gen_Controller_Swift4_Desk_top_DefButtontvMsg(string strViewControllerID, ref int intY)
        {
            intY += 30;
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetFirstJSONObj";
            //string strFunctionName_CN = "获取满足条件的第一条记录对象";
            strBuilder.AppendFormat("\r\n" + " <TextView android:id=\"@+id/tvMsg\"", strFunctionName);
            strBuilder.Append("\r\n" + "        android:layout_width=\"fill_parent\"");
            strBuilder.Append("\r\n" + "        android:layout_height=\"wrap_content\"");
            //strBuilder.AppendFormat("\r\n" + "        android:text=\"{0}\"",
            //    strFunctionName_CN);
            strBuilder.Append("\r\n" + "android:textSize=\"12sp\"");
            //strBuilder.Append("\r\n" + "android:minHeight=\"35dp\"");
            strBuilder.Append("\r\n" + "android:padding=\"10dip\"");
            strBuilder.Append("\r\n" + "        />");


            return strBuilder.ToString();
        }

        public ISOButtonEx Gen_Controller_Swift4_Desk_top_DefButtonByCommonFunction(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx, string strViewControllerID, ref int intY)
        {
            intY += 30;
            StringBuilder strBuilder = new StringBuilder();
            //string strFunctionName_CN = "获取满足条件的第一条记录对象";

            string strButtonId = AgcPubFun.getSwiftID();
            string strActionId = AgcPubFun.getSwiftID();
            
            ISOButtonEx objISOButtonEN = new ISOButtonEx();
            objISOButtonEN.IsoControlId = strButtonId;
            objISOButtonEN.IsoControlName = objWebSrvFunctionsENEx.FunctionName;
            objISOButtonEN.ParentViewControllerID = strViewControllerID;
            objISOButtonEN.Text = objWebSrvFunctionsENEx.FunctionName;
            objISOButtonEN.y = intY;
            objISOButtonEN.x = 0;
            objISOButtonEN.Width = 130;
            objISOButtonEN.Height = 30;
            ISOActionEx objISOActionEN = new ISOActionEx();
            objISOActionEN.destination = strViewControllerID;
            objISOActionEN.EventFuncName = string.Format("btn{0}_Click", objWebSrvFunctionsENEx.FunctionName);
            objISOButtonEN.arrSubIsoControlLst2.Add(objISOActionEN);
            return objISOButtonEN;

        }
    }
}
