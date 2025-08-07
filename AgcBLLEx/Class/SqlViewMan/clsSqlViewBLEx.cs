using AGC.BusinessLogic;
using AGC.DAL;
using AGC.Entity;
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.sql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGC.BusinessLogicEx
{
    public class clsSqlViewBLEx : clsSqlViewBL
    {
        public List<clsPrjTabEN> arrPrjTabObjLst = null;
        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicCode)
        /// </summary>
        protected static int intFindFailCount = 0;

        //        Hashtable ht = new Hashtable(); //创建一个Hashtable实例
        //ht.Add("E","e");//添加keyvalue键值对
        //ht.Add("A","a");
        //ht.Add("C","c");
        //ht.Add("B","b");
        public static Hashtable htTabAliases = null;
        ///绑定下拉框的函数代码
        public static void BindDdl_SqlViewIdEx(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");
            System.Data.DataTable objDT = clsvSqlViewBL.GetDataTable(string.Format("PrjId = '{0}'", strPrjId));
            objDDL.DataValueField = "SqlViewId";
            objDDL.DataTextField =convSqlView.SqlViewName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        /// <summary>
        /// 从Sql服务器中导入Sql视图
        /// </summary>
        /// <param name = "strPrjId">工程Id</param>
        /// <param name = "strUserId">操作用户Id</param>
        /// <param name = "strPrjDataBaseId">工程数据库Id</param>
        /// <returns>是否成功</returns>
        public static bool ImportSqlViewFromSqlServer(string strPrjId, string strUserId, string strPrjDataBaseId)
        {
            string strCondition = string.Format("PrjId = '{0}'", strPrjId);
            string strCurrDate14 = clsDateTime.getTodayDateTimeStr(1);
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);

            List<clsSqlViewEN> arrSqlViewObjLst = clsSqlViewBL.GetObjLst(strCondition);
            foreach (clsSqlViewEN objSqlViewEN in arrSqlViewObjLst)
            {

                if (objPrjDataBase.DataBaseTypeId == "03") //ORACLE数据库
                {

                }
                else
                {
                    clsSpecSQLforSql objSQL = clsSQL_DataBaseBLEx.getSpecSQLByPrjDataBaseId(strPrjDataBaseId);
                    try
                    {
                        clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabIdCache(objSqlViewEN.RelaTabId, strPrjId);
                        string strViewText = clsSqlTabViewEx.GetViewText(objPrjTabEN.TabName, objSQL.ConnectionString, objPrjDataBase.DatabaseOwner);
                        objSqlViewEN.SqlViewText = strViewText;


                        if (strViewText.IndexOf("RIGHT OUTER") >= 0)
                        {
                            objSqlViewEN.ErrMsg = "在视图文本中存在【右连接】(RIGHT OUTER),在相关视图处理检查的功能上不能分析相关代码,目前为非法,请弃用【右连接】。";
                        }
                        else if (strViewText.IndexOf("RIGHT ") >= 0)
                        {
                            objSqlViewEN.ErrMsg = "在视图文本中可能存在【右连接】(RIGHT),在相关视图处理检查的功能上不能分析相关代码,目前为非法,请弃用【右连接】。";
                        }
                        objSqlViewEN.UpdDate = strCurrDate14;
                        objSqlViewEN.UpdUserId = strUserId;
                        objSqlViewEN.TextResouce = objPrjDataBase.IpAddress + ": " + objPrjDataBase.DataBaseName;
                        objSqlViewEN.TextResourceTypeId = "01";
                        clsSqlViewBL.UpdateBySql2(objSqlViewEN);
                    }
                    catch (Exception objException)
                    {
                        clsGeneralTab.LogErrorS(objException, "ImportSqlViewFromSqlServer");
                        StringBuilder sbMsg = new StringBuilder();
                        //sbMsg.AppendFormat("在获取表字段(GetColumns)时出错!表名:{0},出错信息:{1}。", strTabName, objException.Message);

                    }
                }
            }


            return true;
        }


        /// <summary>
        /// 从Sql服务器中导入Sql视图
        /// </summary>
        /// <param name = "strPrjId">工程Id</param>
        /// <param name = "strSqlViewId">Sql视图Id</param>
        /// <param name = "strUserId">操作用户Id</param>
        /// <param name = "strPrjDataBaseId">工程数据库Id</param>
        /// <returns>是否成功</returns>
        public static bool ImportSqlViewFromSqlServer(string strPrjId, string strSqlViewId, string strUserId, string strPrjDataBaseId)
        {
            string strCondition = string.Format("PrjId = '{0}' And SqlViewId = '{1}'", strPrjId, strSqlViewId);
            string strCurrDate14 = clsDateTime.getTodayDateTimeStr(1);
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            List<clsSqlViewEN> arrSqlViewObjLst = clsSqlViewBL.GetObjLst(strCondition);
            foreach (clsSqlViewEN objSqlViewEN in arrSqlViewObjLst)
            {

                if (objPrjDataBase.DataBaseTypeId == "03") //ORACLE数据库
                {

                }
                else
                {
                    clsSpecSQLforSql objSQL = clsSQL_DataBaseBLEx.getSpecSQLByPrjDataBaseId(strPrjDataBaseId);
                    try
                    {
                        clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabIdCache(objSqlViewEN.RelaTabId, strPrjId);

                        string strViewText = clsSqlTabViewEx.GetViewText(objPrjTabEN.TabName, objSQL.ConnectionString, objPrjDataBase.DatabaseOwner);
                        strViewText = strViewText.Replace("\r\nFROM", " FROM");
                        strViewText = strViewText.Replace("\r\nSELECT", " SELECT");
                        strViewText = strViewText.Replace("\r\nAS", " AS");
                        strViewText = strViewText.Replace("\r\nWHERE", " WHERE");
                        strViewText = strViewText.Replace("\r\nGROUP", " GROUP");
                        strViewText = strViewText.Replace("\r\nHAVING", " HAVING");

                        strViewText = strViewText.Replace("\r\n", "");
                        //bool bolIsExistRIGHT = false;
                        objSqlViewEN.ErrMsg = "";
                        if (strViewText.IndexOf("RIGHT OUTER") >= 0)
                        {
                            //bolIsExistRIGHT = true;
                            objSqlViewEN.ErrMsg = "在视图文本中存在【右连接】(RIGHT OUTER),在相关视图处理检查的功能上不能分析相关代码,目前为非法,请弃用【右连接】。";
                        }
                        else if (strViewText.IndexOf("RIGHT ") >= 0)
                        {
                            //bolIsExistRIGHT = true;
                            objSqlViewEN.ErrMsg = "在视图文本中可能存在【右连接】(RIGHT),在相关视图处理检查的功能上不能分析相关代码,目前为非法,请弃用【右连接】。";
                        }
                        objSqlViewEN.SqlViewText = strViewText;
                        objSqlViewEN.UpdDate = strCurrDate14;
                        objSqlViewEN.UpdUserId = strUserId;
                        objSqlViewEN.TextResouce = objPrjDataBase.IpAddress + ": " + objPrjDataBase.DataBaseName;
                        objSqlViewEN.TextResourceTypeId = "01";

                        clsSqlViewBL.UpdateBySql2(objSqlViewEN);
                    }
                    catch (Exception objException)
                    {
                        clsGeneralTab.LogErrorS(objException, "ImportSqlViewFromSqlServer");
                        StringBuilder sbMsg = new StringBuilder();
                        //sbMsg.AppendFormat("在获取表字段(GetColumns)时出错!表名:{0},出错信息:{1}。", strTabName, objException.Message);
                        throw objException;
                    }
                }
            }


            return true;
        }

        /// <summary>
        /// 从Sql服务器中导入Sql视图
        /// </summary>
        /// <param name = "strSqlViewId">Sql视图Id</param>
        /// <param name = "strPrjId">工程Id</param>
        /// <param name = "strUserId">操作用户Id</param>
        /// <param name = "strPrjDataBaseId">工程数据库Id</param>
        /// <returns>是否成功</returns>
        public static bool CreateView4Sql(string strSqlViewId, string strPrjId, string strUserId, string strPrjDataBaseId, bool bolIsTry)
        {


            string strCondition = string.Format("PrjId = '{0}'", strPrjId);
            string strCurrDate14 = clsDateTime.getTodayDateTimeStr(1);
            clsSqlViewEN objSqlViewEN = clsSqlViewBL.GetObjBySqlViewId(strSqlViewId);

            if (objSqlViewEN.PrjId != strPrjId)
            {
                clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(strPrjId);
                string strMsg = string.Format("建立视图时,传递进来的工程Id:{0}({1})和视图中工程Id不匹配,请检查!", objProject.PrjId, objProject.PrjName);
                throw new Exception(strMsg);
            }

            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);

            List<clsSqlViewEN> arrSqlViewObjLst = clsSqlViewBL.GetObjLst(strCondition);

            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabIdCache(objSqlViewEN.RelaTabId, strPrjId);

            string strSqlViewName = string.Format("{1}", objPrjDataBase.DatabaseOwner,
                objPrjTabEN.TabName);
            string strSqlViewName_Try = strSqlViewName + "_Try";
            string strSqlViewText = objSqlViewEN.SqlViewText4Gene.Replace("dbo.", objPrjDataBase.DatabaseOwner + ".");
            if (string.IsNullOrEmpty(strSqlViewText) == true)
            {
                return false;
            }
            if (bolIsTry == true)
            {
                strSqlViewText = strSqlViewText.Replace(strSqlViewName + " AS", strSqlViewName_Try + " AS");
            }
            if (objPrjDataBase.DataBaseTypeId == "03") //ORACLE数据库
            {

            }
            else
            {
                clsSpecSQLforSql objSQL = clsSQL_DataBaseBLEx.getSpecSQLByPrjDataBaseId(strPrjDataBaseId);
                try
                {

                    bool bolResult = false;
                    if (bolIsTry == true)
                    {
                        //生成尝试的视图
                        bolResult = clsSqlTabViewEx.CreateView(strSqlViewName_Try, strSqlViewText, objSQL.ConnectionString, objPrjDataBase.DatabaseOwner);
                        //删除尝试生成的视图
                        clsSqlTabViewEx.DeleteView(strSqlViewName_Try, objSQL.ConnectionString, objPrjDataBase.DatabaseOwner);
                    }
                    else
                    {

                        bolResult = clsSqlTabViewEx.CreateView(strSqlViewName, strSqlViewText, objSQL.ConnectionString, objPrjDataBase.DatabaseOwner);
                        objSqlViewEN.CreateDate = strCurrDate14;
                        objSqlViewEN.UpdUserId = strUserId;

                        clsSqlViewBL.UpdateBySql2(objSqlViewEN);
                        clsLog4CreateView4SqlBLEx.AddLog4CreateView4Sql(objSqlViewEN.SqlViewId, strPrjDataBaseId, strPrjId, strUserId);

                        string strCondition_Del = string.Format("TabId in (Select TabId from PrjTab where TabName = '{0}')",
                            objPrjTabEN.TabName);
                        clsTabCheckResultBL.DelTabCheckResultsByCond(strCondition_Del);
                    }
                }
                catch (Exception objException)
                {
                    clsGeneralTab.LogErrorS(objException, "CreateView4Sql");
                    StringBuilder sbMsg = new StringBuilder();
                    sbMsg.AppendFormat("在生成视图4Sql时出错(CreateView4Sql)!视图名:{0},出错信息:{1}。",
                        objPrjTabEN.TabName, objException.Message);
                    objSqlViewEN.ErrMsg = sbMsg.ToString();
                    try
                    {
                        clsSqlViewBL.CheckPropertyNew(objSqlViewEN);
                    }
                    catch (Exception objException1)
                    {
                        throw objException1;
                    }
                    clsSqlViewBL.UpdateBySql2(objSqlViewEN);
                    throw objException;
                }
            }



            return true;
        }



        /// <summary>
        /// 导入Sql视图,从本系统(代码生成系统)中。
        /// </summary>
        /// <param name = "strPrjId">工程Id</param>
        /// <param name = "strUserId">操作用户Id</param>
        /// <returns>是否成功</returns>
        public static bool ImportSqlView(string strPrjId, string strUserId)
        {
            string strCondition = string.Format("PrjId = '{0}' And SqlDsTypeId = '{1}' And TabStateId = '01'", strPrjId, clsSQLDSTypeENEx.SQLVIEW);
            string strCurrDate14 = clsDateTime.getTodayDateTimeStr(1);
            List<clsPrjTabEN> arrPrjTabObjLst = clsPrjTabBL.GetObjLst(strCondition);
            foreach (clsPrjTabEN objPrjTabEN in arrPrjTabObjLst)
            {
                string strCondition4View = string.Format("PrjId = '{0}' And SqlViewName = '{1}'", strPrjId, objPrjTabEN.TabName);
                clsSqlViewEN objSqlViewEN = null;
                bool bolIsExist = false;
                if (clsSqlViewBL.IsExistRecord(strCondition4View) == true)
                {
                    objSqlViewEN = clsSqlViewBL.GetFirstObj_S(strCondition4View);
                    bolIsExist = true;
                }
                else
                {
                    bolIsExist = false;
                    objSqlViewEN = new clsSqlViewEN();
                    objSqlViewEN.SqlViewId = clsSqlViewBL.GetMaxStrId_S();
                }

                objSqlViewEN.TextResouce = "无";
                objSqlViewEN.TextResourceTypeId = "00";
                objSqlViewEN.RelaTabId = objPrjTabEN.TabId;
                objSqlViewEN.PrjId = strPrjId;

                objSqlViewEN.UpdDate = strCurrDate14;
                objSqlViewEN.UpdUserId = strUserId;
                if (bolIsExist == true)
                {
                    clsSqlViewBL.UpdateBySql2(objSqlViewEN);
                }
                else
                {
                    clsSqlViewBL.AddNewRecordBySql2(objSqlViewEN);
                }
            }
            return true;
        }

        /// <summary>
        /// 导入Sql视图,从本系统(代码生成系统)中。
        /// </summary>
        /// <param name = "strPrjId">工程Id</param>
        /// <param name = "strUserId">操作用户Id</param>
        /// <returns>是否成功</returns>
        public static bool ImportSqlViewBySqlViewName(string strPrjId, string strSqlViewName, string strUserId)
        {
            string strCondition = string.Format("PrjId = '{0}' And TabName = '{2}' And SqlDsTypeId = '{1}'",
                strPrjId, clsSQLDSTypeENEx.SQLVIEW, strSqlViewName);
            string strCurrDate14 = clsDateTime.getTodayDateTimeStr(1);
            List<clsPrjTabEN> arrPrjTabObjLst = clsPrjTabBL.GetObjLst(strCondition);
            foreach (clsPrjTabEN objPrjTabEN in arrPrjTabObjLst)
            {
                string strCondition4View = string.Format("PrjId = '{0}' And {2} = '{1}'",
                    strPrjId, objPrjTabEN.TabId,
                    conSqlView.RelaTabId);
                clsSqlViewEN objSqlViewEN = null;
                bool bolIsExist = false;
                if (clsSqlViewBL.IsExistRecord(strCondition4View) == true)
                {
                    objSqlViewEN = clsSqlViewBL.GetFirstObj_S(strCondition4View);
                    bolIsExist = true;
                }
                else
                {
                    bolIsExist = false;
                    objSqlViewEN = new clsSqlViewEN();
                    objSqlViewEN.SqlViewId = clsSqlViewBL.GetMaxStrId_S();
                }


                objSqlViewEN.TextResouce = "无";
                objSqlViewEN.TextResourceTypeId = "00";
                objSqlViewEN.RelaTabId = objPrjTabEN.TabId;
                objSqlViewEN.PrjId = strPrjId;

                objSqlViewEN.UpdDate = strCurrDate14;
                objSqlViewEN.UpdUserId = strUserId;
                if (bolIsExist == true)
                {
                    clsSqlViewBL.UpdateBySql2(objSqlViewEN);
                }
                else
                {
                    clsSqlViewBL.AddNewRecordBySql2(objSqlViewEN);
                }
            }
            return true;
        }


        /// <summary>
        /// 生成Sql视图,即根据相关字段,以及相关表等,生成Sql视图文本
        /// </summary>
        /// <param name = "strSqlViewId">Sql视图Id</param>
        /// <param name = "strPrjId">工程Id</param>
        /// <param name = "strUserId">操作用户ID</param>
        /// <returns>是否成功</returns>
        public static bool GeneSqlView(string strSqlViewId, string strPrjId, string strPrjDataBaseId, string strUserId)
        {
            string strCurrDate14 = clsDateTime.getTodayDateTimeStr(1);
     

            htTabAliases = null;
            clsProjectsEN objProjectsEN = clsProjectsBL.GetObjByPrjIdCache(strPrjId);
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);

            clsSqlViewEN objSqlViewEN = clsSqlViewBL.GetObjBySqlViewId(strSqlViewId);

            string strCondition_SqlViewId = string.Format("SqlViewId = '{0}'", strSqlViewId);
            List<clsvSqlViewRelaTabEN> arrvSqlViewRelaTabObjLst = clsvSqlViewRelaTabBL.GetObjLstCache(strPrjId);
            arrvSqlViewRelaTabObjLst = arrvSqlViewRelaTabObjLst.Where(x=>x.SqlViewId == strSqlViewId).ToList();
            List<clsvSqlViewFldEN> arrvSqlViewFldObjLst = clsvSqlViewFldBL.GetObjLstCache(strPrjId);
            arrvSqlViewFldObjLst = arrvSqlViewFldObjLst.Where(x => x.SqlViewId == strSqlViewId).ToList();
            string strCondition_Temp = string.Format("TabId = '{0}' and {1}='0'", 
                objSqlViewEN.RelaTabId, conPrjTabFld.IsForExtendClass);
            int intRecNum4PrjTabFld = clsPrjTabFldBL.GetRecCountByCond(strCondition_Temp);
            clsPrjTabEN objPrjTabEN = null;
            if (arrvSqlViewFldObjLst.Count != intRecNum4PrjTabFld)
            {
                objPrjTabEN = clsPrjTabBL.GetObjByTabIdCache(objSqlViewEN.RelaTabId, strPrjId);

                string strMsg = string.Format("视图表:[{0}]的生成代码中字段数:[{1}]与视图字段数[{2}]不一样, 请检查!。",
                    objPrjTabEN.TabName,
                    intRecNum4PrjTabFld,
                    arrvSqlViewFldObjLst.Count());
                objSqlViewEN.ErrMsg = strMsg;
                objSqlViewEN.UpdDate = strCurrDate14;
                objSqlViewEN.UpdUserId = strUserId;
                clsSqlViewBL.UpdateBySql2(objSqlViewEN);
                clsvSqlViewFldBL.ReFreshThisCache();
                throw new Exception(strMsg);
            }
            //CREATE VIEW dbo.vUserRoles AS 
            //SELECT dbo.UserRoles.RoleId, dbo.UserRoles.RoleName, dbo.UserRoles.PrjId, dbo.UserRoles.Memo, dbo.Projects.PrjName, dbo.UserRoles.IsInUse 
            //    FROM dbo.UserRoles LEFT OUTER JOIN dbo.Projects ON dbo.UserRoles.PrjId = dbo.Projects.PrjId
            StringBuilder sbSqlViewText = new StringBuilder();
            objPrjTabEN = clsPrjTabBL.GetObjByTabIdCache(objSqlViewEN.RelaTabId, strPrjId);
            sbSqlViewText.AppendFormat("CREATE VIEW {0}.{1} AS", objPrjDataBase.DatabaseOwner,
                objPrjTabEN.TabName);

            sbSqlViewText.AppendFormat(" Select {0} {1}",
                objSqlViewEN.TopPercent, objSqlViewEN.DistinctFlag);
            foreach (clsvSqlViewFldEN objvSqlViewFldEN in arrvSqlViewFldObjLst)
            {
                clsvSqlViewRelaTabEN objvSqlViewRelaTabEN = arrvSqlViewRelaTabObjLst.Find(x=>x.RelaTabId == objvSqlViewFldEN.RelaTabId);
                StringBuilder sbFieldExpression = new StringBuilder();
                if (objvSqlViewRelaTabEN == null)//无相关表
                {
                    if (string.IsNullOrEmpty(objvSqlViewFldEN.FldExpression) == true)
                    {
                        string strMsg = string.Format("在视图:{0}中, 出现相关表和字段表达式同时为空的情况,请检查!({1}-{2})",
                            objPrjTabEN.TabName,
                            clsStackTrace.GetCurrClassFunctionByLevel(2),
                            clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                    }
                    if (string.IsNullOrEmpty(objvSqlViewFldEN.FieldAliases) == true)
                    {
                        //string strMsg = string.Format("在视图:{0}中, 出现相关表和字段别名同时为空的情况,请检查!({1}-{2})",
                        //    objPrjTabEN.TabName,
                        //    clsStackTrace.GetCurrClassFunctionByLevel(2),
                        //    clsStackTrace.GetCurrClassFunction());
                        //throw new Exception(strMsg);
                        string strFldExpression = objvSqlViewFldEN.FldExpression.Replace("dbo.", objPrjDataBase.DatabaseOwner + ".");
                        sbFieldExpression.Append($"{strFldExpression}");
                    }
                    else
                    {
                        string strFldExpression = objvSqlViewFldEN.FldExpression.Replace("dbo.", objPrjDataBase.DatabaseOwner + ".");
                        sbFieldExpression.AppendFormat("{0} AS {1}", strFldExpression, objvSqlViewFldEN.FieldAliases);
                    }
                }
                else  //有相关表
                {
                    if (objvSqlViewRelaTabEN.TabAliases.Equals(objvSqlViewRelaTabEN.TabName, StringComparison.InvariantCultureIgnoreCase) == true)//表别名为空
                    {
                        if (string.IsNullOrEmpty(objvSqlViewFldEN.FieldAliases) == true)//字段别名为空
                        {
                            sbFieldExpression.AppendFormat("{0}.{1}.{2}",
                                 objPrjDataBase.DatabaseOwner,
                                 objvSqlViewFldEN.TabName,
                                 objvSqlViewFldEN.FldName);
                        }
                        else//字段别名不为空
                        {
                            sbFieldExpression.AppendFormat("{0}.{1}.{2} AS {3}",
                               objPrjDataBase.DatabaseOwner,
                               objvSqlViewFldEN.TabName,
                               objvSqlViewFldEN.FldName,
                               objvSqlViewFldEN.FieldAliases);

                        }//(string.IsNullOrEmpty(objvSqlViewFldEN.FieldAliases)  ==  true)//字段别名为空
                    }
                    else//表别名不为空
                    {
                        if (string.IsNullOrEmpty(objvSqlViewFldEN.FieldAliases) == true)//字段别名为空
                        {
                            sbFieldExpression.AppendFormat("{0}.{1}", objvSqlViewRelaTabEN.TabAliases, objvSqlViewFldEN.FldName);
                        }
                        else//字段别名不为空
                        {
                            sbFieldExpression.AppendFormat("{0}.{1} AS {2}",
                               objvSqlViewRelaTabEN.TabAliases,
                               objvSqlViewFldEN.FldName,
                               objvSqlViewFldEN.FieldAliases);
                        }//(string.IsNullOrEmpty(objvSqlViewFldEN.FieldAliases)  ==  true)//字段别名为空

                    }//(string.IsNullOrEmpty(objvSqlViewRelaTabEN.TabAliases)  ==  true)
                }// if (objvSqlViewRelaTabEN  ==  null)
                sbSqlViewText.AppendFormat(" {0},", sbFieldExpression.ToString());
            }//  foreach (clsvSqlViewFldEN objvSqlViewFldEN in arrvSqlViewFldObjLst)

            //去除最后一个“,”
            sbSqlViewText.Remove(sbSqlViewText.Length - 1, 1);
            //处理主表
            foreach (clsvSqlViewRelaTabEN objvSqlViewRelaTabEN in arrvSqlViewRelaTabObjLst)
            {
                if (objvSqlViewRelaTabEN.SvRelaTabTypeId != "01") continue;
                if (objvSqlViewRelaTabEN.TabAliases.Equals(objvSqlViewRelaTabEN.TabName, StringComparison.InvariantCultureIgnoreCase) == true)
                {
                    sbSqlViewText.AppendFormat(" FROM {0}.{1}", objPrjDataBase.DatabaseOwner, objvSqlViewRelaTabEN.TabName);
                }
                else
                {
                    sbSqlViewText.AppendFormat(" FROM {0}.{1} AS {2} ",
                        objPrjDataBase.DatabaseOwner,
                        objvSqlViewRelaTabEN.TabName,
                        objvSqlViewRelaTabEN.TabAliases);
                }
            }

            //处理相关表
            foreach (clsvSqlViewRelaTabEN objvSqlViewRelaTabEN in arrvSqlViewRelaTabObjLst)
            {
                if (objvSqlViewRelaTabEN.SvRelaTabTypeId != "02") continue;
                StringBuilder sbTabRelation = new StringBuilder();
                switch (objvSqlViewRelaTabEN.TabRelationTypeId)
                {
                    case "01": // 左连接
                        sbTabRelation.Append(" LEFT OUTER JOIN ");
                        break;
                    case "02": // 右连接
                        sbTabRelation.Append(" RIGHT OUTER JOIN ");
                        break;
                    case "03": // 全连接
                        sbTabRelation.Append(" FULL OUTER JOIN ");
                        break;
                    case "04": // 内连接
                        sbTabRelation.Append(" INNER JOIN ");
                        break;

                    default: // 内连接
                        string strMsg = string.Format("在视图:{0}中, 相关表:{1}的连接类型不存在,请检查!({2}-{3})",
                            objPrjTabEN.TabName,
                            objvSqlViewRelaTabEN.TabName,
                            objvSqlViewRelaTabEN.TabRelationTypeName,
                            clsStackTrace.GetCurrClassFunctionByLevel(2),
                            clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);

                }
                if (objvSqlViewRelaTabEN.TabAliases.Equals(objvSqlViewRelaTabEN.TabName, StringComparison.InvariantCultureIgnoreCase) == true)
                {
                    sbTabRelation.AppendFormat(" {0}.{1} ", objPrjDataBase.DatabaseOwner, objvSqlViewRelaTabEN.TabName);
                }
                else
                {
                    sbTabRelation.AppendFormat(" {0}.{1} AS {2} ", objPrjDataBase.DatabaseOwner, objvSqlViewRelaTabEN.TabName, objvSqlViewRelaTabEN.TabAliases);
                }
                sbTabRelation.Append(" ON ");
                if (string.IsNullOrEmpty(objvSqlViewRelaTabEN.TabRelationText) == true)
                {
                    string strMsg = string.Format("在视图:{0}中, 相关表:{1}的表关系文本为空,不合法,请检查!({2}->{3})",
                                   objPrjTabEN.TabName,
                                   objvSqlViewRelaTabEN.TabName,
                                   clsStackTrace.GetCurrClassFunctionByLevel(2),
                                   clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                string strTabRelationText = objvSqlViewRelaTabEN.TabRelationText.Replace("ON ", "");
                strTabRelationText = strTabRelationText.Replace("dbo.", objPrjDataBase.DatabaseOwner + ".");
                sbTabRelation.AppendFormat(" {0} ", strTabRelationText);

                sbSqlViewText.AppendFormat(" {0} ", sbTabRelation.ToString());
            }
            if (string.IsNullOrEmpty(objSqlViewEN.WhereCondition) == false)
            {
                string strWhereCondition = objSqlViewEN.WhereCondition.Replace("dbo.", objPrjDataBase.DatabaseOwner + ".");

                if (strWhereCondition.IndexOf("where ", StringComparison.InvariantCultureIgnoreCase) >= 0)
                {
                    sbSqlViewText.AppendFormat(" {0}", strWhereCondition);
                }
                else
                {
                    sbSqlViewText.AppendFormat(" Where {0}", strWhereCondition);
                }
            }
            if (string.IsNullOrEmpty(objSqlViewEN.GroupBy) == false)
            {
                string strGroupBy = objSqlViewEN.GroupBy.Replace("dbo.", objPrjDataBase.DatabaseOwner + ".");
                if (strGroupBy.IndexOf("Group By ", StringComparison.InvariantCultureIgnoreCase) >= 0)
                {
                    sbSqlViewText.AppendFormat(" {0}", strGroupBy);
                }
                else
                {
                    sbSqlViewText.AppendFormat(" Group By {0}", strGroupBy);
                }
            }
            if (string.IsNullOrEmpty(objSqlViewEN.HavingStr) == false)
            {
                string strHavingStr = objSqlViewEN.HavingStr.Replace("dbo.", objPrjDataBase.DatabaseOwner + ".");
                if (strHavingStr.IndexOf("Having ", StringComparison.InvariantCultureIgnoreCase) >= 0)
                {
                    sbSqlViewText.AppendFormat(" {0}", strHavingStr);
                }
                else
                {
                    sbSqlViewText.AppendFormat(" Having {0}", strHavingStr);
                }
            }
            if (string.IsNullOrEmpty(objSqlViewEN.OrderBy) == false)
            {
                string strOrderBy = objSqlViewEN.OrderBy.Replace("dbo.", objPrjDataBase.DatabaseOwner + ".");
                if (strOrderBy.IndexOf("Order By ", StringComparison.InvariantCultureIgnoreCase) >= 0)
                {
                    sbSqlViewText.AppendFormat(" {0}", strOrderBy);
                }
                else
                {
                    sbSqlViewText.AppendFormat(" Order By {0}", strOrderBy);
                }
            }
            objSqlViewEN.SqlViewText4Gene = sbSqlViewText.ToString();
            objSqlViewEN.GeneCodeDate = strCurrDate14;
            objSqlViewEN.TextResourceTypeId = "02";
            clsSqlViewBL.UpdateBySql2(objSqlViewEN);
            return true;
        }

        /// <summary>
        /// 字段分析,即可视图文本中,分析可相关字段,以及相关表等
        /// </summary>
        /// <param name = "strSqlViewId">Sql视图Id</param>
        /// <param name = "strPrjId">工程Id</param>
        /// <param name = "strUserId">操作用户ID</param>
        /// <returns>是否成功</returns>
        public static bool FieldAnalysis(string strSqlViewId, string strPrjId, string strUserId)
        {
            string strCurrDate14 = clsDateTime.getTodayDateTimeStr(1);
     
            htTabAliases = null;

            clsSqlViewEN objSqlViewEN = clsSqlViewBL.GetObjBySqlViewIdCache(strSqlViewId, strPrjId);
            if (objSqlViewEN==null)
            {
                string strErrMsg = string.Format("SqlViewId={0} 的视图不存在。", strSqlViewId);
                throw new Exception(strErrMsg);
            }    
            int intLen_Text = objSqlViewEN.SqlViewText.Length;
            if (intLen_Text == 0)
            {
                objSqlViewEN.AnalysisDate = strCurrDate14;


                clsSqlViewBL.UpdateBySql2(objSqlViewEN);
                return true;
            }
            string strSqlViewText = objSqlViewEN.SqlViewText.Replace("\n\r", " ");
            

            strSqlViewText = strSqlViewText.Replace("\n", " ");
            strSqlViewText = strSqlViewText.Replace("\r", " ");
            strSqlViewText = strSqlViewText.Replace("\t", " ");
            strSqlViewText = strSqlViewText.Replace("  ", " ");
            strSqlViewText = strSqlViewText.Replace("  ", " ");

            int intCreateViewPos = strSqlViewText.IndexOf("CREATE VIEW");
            if (intCreateViewPos >0)
            {
                strSqlViewText = strSqlViewText.Substring(intCreateViewPos);
            }
            //if (string.IsNullOrEmpty(objSqlViewEN.ErrMsg)  ==  false)
            //{
            //    string strMsg = string.Format("在视图文本中存在错误:{0}, 请处理后再进行分析!", objSqlViewEN.ErrMsg);
            //    objSqlViewEN.ErrMsg = strMsg;
            //    clsSqlViewBL.UpdateBySql2(objSqlViewEN);
            //    throw new Exception(strMsg);
            //}
            if (strSqlViewText.IndexOf("RIGHT OUTER") >= 0)
            {
                objSqlViewEN.ErrMsg = "在视图文本中存在【右连接】(RIGHT OUTER),在相关视图处理检查的功能上不能分析相关代码,目前为非法,请弃用【右连接】。";

                clsSqlViewBL.UpdateBySql2(objSqlViewEN);
                throw new Exception(objSqlViewEN.ErrMsg);
            }
            else if (strSqlViewText.IndexOf("RIGHT ") >= 0)
            {
                objSqlViewEN.ErrMsg = "在视图文本中可能存在【右连接】(RIGHT),在相关视图处理检查的功能上不能分析相关代码,目前为非法,请弃用【右连接】。";

                clsSqlViewBL.UpdateBySql2(objSqlViewEN);
                throw new Exception(objSqlViewEN.ErrMsg);
            }

            List<string> lstFlag = new List<string>();
            lstFlag.Add("select ");
            lstFlag.Add("from ");
            lstFlag.Add("where ");
            lstFlag.Add("group by ");
            lstFlag.Add("having ");
            lstFlag.Add("order by ");

            List<string> lstWord = clsString.SplitStringBySplitFlagLst(strSqlViewText, lstFlag);
            List<string> lstWord2 = GetUnionLst(lstWord, "");
            //int intPos_Select = objSqlViewEN.SqlViewText.IndexOf(" select ", 0, StringComparison.InvariantCultureIgnoreCase);
            //int intPos_From = objSqlViewEN.SqlViewText.IndexOf(" from ", intPos_Select, StringComparison.InvariantCultureIgnoreCase);
            //int intPos_Where = objSqlViewEN.SqlViewText.IndexOf(" where ", intPos_From, StringComparison.InvariantCultureIgnoreCase);
            //string strText_Select = objSqlViewEN.SqlViewText.Substring(intPos_Select, intPos_From - intPos_Select);

            string strText_Select = lstWord2[1];
            string strText_From = lstWord2[2];
            string strText_Where = "";
            string strText_GroupBy = "";
            string strText_Having = "";
            string strText_OrderBy = "";

            for (int i = 2; i < lstWord2.Count; i++)
            {
                if (lstWord2[i].IndexOf("Where ", StringComparison.InvariantCultureIgnoreCase) >= 0)
                {
                    strText_Where = lstWord2[i];
                }
                else if (lstWord2[i].IndexOf("Group by ", StringComparison.InvariantCultureIgnoreCase) >= 0)
                {
                    strText_GroupBy = lstWord2[i];
                }
                else if (lstWord2[i].IndexOf("Having ", StringComparison.InvariantCultureIgnoreCase) >= 0)
                {
                    strText_Having = lstWord2[i];
                }
                else if (lstWord2[i].IndexOf("Order By ", StringComparison.InvariantCultureIgnoreCase) >= 0)
                {
                    strText_OrderBy = lstWord2[i];
                }
            }
            string strCondition_SqlViewId = string.Format("SqlViewId = '{0}'", objSqlViewEN.SqlViewId);
            clsSqlViewFldBL.DelSqlViewFldsByCond(strCondition_SqlViewId);
            clsSqlViewRelaTabBL.DelSqlViewRelaTabsByCond(strCondition_SqlViewId);
            clsvSqlViewFldBL.ReFreshThisCache(objSqlViewEN.PrjId);
            clsvSqlViewRelaTabBL.ReFreshThisCache(objSqlViewEN.PrjId);

            try
            {
                FieldAnalysis_From(strText_From, objSqlViewEN, strPrjId, strCurrDate14, strUserId);
            }
            catch (Exception objException)
            {
                objSqlViewEN.ErrMsg = objException.Message;

                clsSqlViewBL.UpdateBySql2(objSqlViewEN);
                throw objException;
            }
            string strTopPercent = "";
            int intPos_top = strText_Select.IndexOf(" top ", StringComparison.InvariantCultureIgnoreCase);
            if (intPos_top > 0)
            {
                int intPos_Percent = strText_Select.IndexOf("percent ", StringComparison.InvariantCultureIgnoreCase);

                strTopPercent = strText_Select.Substring(intPos_top, intPos_Percent - intPos_top + 7);
            }

            string strDistinctFlag = "";
            int intPos_Distinct = strText_Select.IndexOf("distinct ", StringComparison.InvariantCultureIgnoreCase);
            if (intPos_Distinct >= 0)
            {

                strDistinctFlag = strText_Select.Substring(intPos_Distinct, 8);
            }
            try
            {
                FieldAnalysis_Select(strText_Select, objSqlViewEN, strPrjId, strCurrDate14, strUserId);
            }
            catch (Exception objException)
            {
                objSqlViewEN.ErrMsg = objException.Message;

                clsSqlViewBL.UpdateBySql2(objSqlViewEN);
                throw objException;
            }
            objSqlViewEN.AnalysisDate = strCurrDate14;
            objSqlViewEN.TopPercent = strTopPercent;
            objSqlViewEN.DistinctFlag = strDistinctFlag;
            objSqlViewEN.WhereCondition = strText_Where;
            objSqlViewEN.GroupBy = strText_GroupBy;
            objSqlViewEN.HavingStr = strText_Having;
            objSqlViewEN.OrderBy = strText_OrderBy;
            objSqlViewEN.ErrMsg = "";
            clsSqlViewBL.UpdateBySql2(objSqlViewEN);
            return true;
        }
        /// <summary>
        /// 字段分析From部分
        /// </summary>
        /// <param name = "strText_From">From部分的文本</param>
        /// <param name = "objSqlViewEN">Sql视图对象</param>
        /// <param name = "strPrjId">工程Id</param>
        /// <param name = "strCurrDate14">当前日期</param>
        /// <param name = "strUserId">操作用户Id</param>
        /// <returns>是否成功</returns>
        public static bool FieldAnalysis_From(string strText_From, clsSqlViewEN objSqlViewEN, string strPrjId, string strCurrDate14, string strUserId)
        {
            //FROM         dbo.SqlView LEFT OUTER JOIN
            //              dbo.PrjTab ON dbo.SqlView.RelaTabId = dbo.PrjTab.TabId LEFT OUTER JOIN
            //              dbo.Projects ON dbo.SqlView.PrjId = dbo.Projects.PrjId LEFT OUTER JOIN
            //              dbo.TextResourceType ON dbo.SqlView.TextResourceTypeId = dbo.TextResourceType.TextResourceTypeId
            clsPrjTabEN objPrjTabEN2 = clsPrjTabBL.GetObjByTabIdCache(objSqlViewEN.RelaTabId, strPrjId);

            if (strText_From.IndexOf("FROM", StringComparison.InvariantCultureIgnoreCase) < 0)
            {
                string strMsg = string.Format("在视图:{1}中, From部分:{0}不合法,请检查!(2)->{3}", strText_From,
                    objPrjTabEN2.TabName,
                                   clsStackTrace.GetCurrClassFunctionByLevel(2),
                                   clsStackTrace.GetCurrClassFunction());
                objSqlViewEN.ErrMsg = strMsg;
                clsSqlViewBL.UpdateBySql2(objSqlViewEN);
                throw new Exception(strMsg);
            }

            List<string> lstFlag = new List<string>();
            lstFlag.Add("LEFT OUTER JOIN");
            lstFlag.Add("RIGHT OUTER JOIN");
            lstFlag.Add("FULL OUTER JOIN");
            lstFlag.Add("INNER JOIN");
            lstFlag.Add("from ");
            strText_From = strText_From.Replace("     ", " ");
            strText_From = strText_From.Replace("    ", " ");
            strText_From = strText_From.Replace("   ", " ");
            strText_From = strText_From.Replace("  ", " ");
            //strText_From = strText_From.Replace(" ", " ");


            List<string> lstWord = clsString.SplitStringBySplitFlagLst(strText_From, lstFlag);
            if (lstWord[0].IndexOf("FROM", StringComparison.InvariantCultureIgnoreCase) < 0)
            {
                string strMsg = string.Format("在视图:{1}中, From部分:{0}不合法,请检查!{2}->{3}", strText_From,
                    objPrjTabEN2.TabName,
                                   clsStackTrace.GetCurrClassFunctionByLevel(2),
                                   clsStackTrace.GetCurrClassFunction());
                objSqlViewEN.ErrMsg = strMsg;
                objSqlViewEN.UpdDate = strCurrDate14;
                objSqlViewEN.UpdUserId = strUserId;
                clsSqlViewBL.UpdateBySql2(objSqlViewEN);
                throw new Exception(strMsg);
            }

            int intOrderNum = 1;

            //获取主表
            int intPos_AS2 = lstWord[0].IndexOf(" AS ");
            string strMainTabName_Alias = "";
            if (intPos_AS2 > 0)
            {
                strMainTabName_Alias = lstWord[0].Substring(intPos_AS2 + 4);
                lstWord[0] = lstWord[0].Substring(0, intPos_AS2);
            }
            int intPos_Empty = lstWord[0].IndexOf(' ');
            string strMainTabNamePart = lstWord[0].Substring(intPos_Empty);
            string[] sstrPart = strMainTabNamePart.Split('.');
            string strMainTabName = "";
            if (sstrPart.Length == 1)
            {
                strMainTabName = sstrPart[0].Trim();
            }
            else if (sstrPart.Length == 2)
            {
                strMainTabName = sstrPart[1].Trim();
            }
            else if (sstrPart.Length > 2)
            {
                string strMsg = string.Format("在视图:{2}的FROM部分:{0}中,主表:{1}格式不正确,请检查!({3}->{4})", 
                    strText_From, strMainTabNamePart,
                    objPrjTabEN2.TabName,
                                   clsStackTrace.GetCurrClassFunctionByLevel(2),
                                   clsStackTrace.GetCurrClassFunction());
                objSqlViewEN.ErrMsg = strMsg;
                objSqlViewEN.UpdDate = strCurrDate14;
                objSqlViewEN.UpdUserId = strUserId;
                clsSqlViewBL.UpdateBySql2(objSqlViewEN);
                throw new Exception(strMsg);
            }

            clsPrjTabEN objPrjTabEN_Main = clsPrjTabBLEx.GetObjByTabNameExCache(strPrjId, strMainTabName);
            if (objPrjTabEN_Main == null)
            {
                string strMsg = string.Format("在视图:{1}中, 表名:[{0}]不存在,请检查!({2}->{3})", 
                    strMainTabName,
                    objPrjTabEN2.TabName,
                    clsStackTrace.GetCurrClassFunctionByLevel(2),
                    clsStackTrace.GetCurrClassFunction());
                objSqlViewEN.ErrMsg = strMsg;
                objSqlViewEN.UpdDate = strCurrDate14;
                objSqlViewEN.UpdUserId = strUserId;
                clsSqlViewBL.UpdateBySql2(objSqlViewEN);
                throw new Exception(strMsg);
            }
            clsSqlViewRelaTabEN objSqlViewRelaTabEN_Main = new clsSqlViewRelaTabEN();
            objSqlViewRelaTabEN_Main.SqlViewId = objSqlViewEN.SqlViewId;// Sql视图Id

            objSqlViewRelaTabEN_Main.TabId = objPrjTabEN_Main.TabId;// 表别名
            if (string.IsNullOrEmpty(strMainTabName_Alias) == false)
            {
                objSqlViewRelaTabEN_Main.TabAliases = strMainTabName_Alias;// 表别名
            }
            else
            {
                objSqlViewRelaTabEN_Main.TabAliases = strMainTabName;// 表别名
            }
            objSqlViewRelaTabEN_Main.SvRelaTabTypeId = "01";// Sql视图相关表类型Id
            objSqlViewRelaTabEN_Main.TabRelationTypeId = "00";// 表关系类型Id
            objSqlViewRelaTabEN_Main.TabRelationText = "";// 表关系文本
            objSqlViewRelaTabEN_Main.OrderNum = intOrderNum++;// OrderNum
            objSqlViewRelaTabEN_Main.PrjId = strPrjId;// 工程ID
            objSqlViewRelaTabEN_Main.UpdDate = strCurrDate14;// 修改日期
            objSqlViewRelaTabEN_Main.UpdUserId = strUserId;// 修改用户Id
            objSqlViewRelaTabEN_Main.Memo = "通过分析!";// 说明
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("1 = 1");
            sbCondition.AppendFormat(" and SqlViewId = '{0}'", objSqlViewRelaTabEN_Main.SqlViewId);

            sbCondition.AppendFormat(" and PrjId = '{0}'", objSqlViewRelaTabEN_Main.PrjId);
            sbCondition.AppendFormat(" and TabAliases = '{0}'", objSqlViewRelaTabEN_Main.TabAliases);

            if (clsSqlViewRelaTabBL.IsExistRecord(sbCondition.ToString()) == true)
            {
                objSqlViewRelaTabEN_Main.UpdateWithCondition(sbCondition.ToString());
            }
            else
            {
                objSqlViewRelaTabEN_Main.RelaTabId = clsSqlViewRelaTabBL.GetMaxStrId_S();// 相关表Id
                clsSqlViewRelaTabBL.AddNewRecordBySql2(objSqlViewRelaTabEN_Main);
            }
            for (int i = 1; i < lstWord.Count; i++)
            {
                string strWord = lstWord[i].Trim();//去除主表名后的部分
                string strTabRelationTypeId = "";
                string strReleTabName = "";
                List<string> lstFlag2 = new List<string>();
                lstFlag2.Add(" ON ");

                List<string> lstWord2 = clsString.SplitStringBySplitFlagLst(strWord, lstFlag2);

                if (lstWord2[0].IndexOf("LEFT OUTER JOIN", StringComparison.InvariantCultureIgnoreCase) >= 0)
                {
                    strTabRelationTypeId = "01"; // 左连接
                    strReleTabName = lstWord2[0].Substring("LEFT OUTER JOIN".Length).Trim();
                }
                else if (lstWord2[0].IndexOf("Right OUTER JOIN", StringComparison.InvariantCultureIgnoreCase) >= 0)
                {
                    strTabRelationTypeId = "02"; // 左连接
                    strReleTabName = lstWord2[0].Substring("Right OUTER JOIN".Length).Trim();
                }
                else if (lstWord2[0].IndexOf("FULL OUTER JOIN", StringComparison.InvariantCultureIgnoreCase) >= 0)
                {
                    strTabRelationTypeId = "03"; // 左连接
                    strReleTabName = lstWord2[0].Substring("FULL OUTER JOIN".Length).Trim();
                }
                else if (lstWord2[0].IndexOf("INNER JOIN", StringComparison.InvariantCultureIgnoreCase) >= 0)
                {
                    strTabRelationTypeId = "04"; // 左连接
                    strReleTabName = lstWord2[0].Substring("INNER JOIN".Length).Trim();
                }
                int intPos_AS = strReleTabName.IndexOf(" AS ", StringComparison.InvariantCultureIgnoreCase);
                string strTabAliases = "";
                if (intPos_AS > 0)
                {
                    strTabAliases = strReleTabName.Substring(intPos_AS + 3).Trim();
                    strReleTabName = strReleTabName.Substring(0, intPos_AS).Trim();
                }
                else
                {
                    strReleTabName = strReleTabName.Trim();
                    int intPos_Empty2 = strReleTabName.IndexOf(" ");
                    if (intPos_Empty2 > 0)
                    {
                        strTabAliases = strReleTabName.Substring(intPos_Empty2 + 1).Trim();
                        strReleTabName = strReleTabName.Substring(0, intPos_Empty2).Trim();
                    }
                }
                sstrPart = strReleTabName.Split('.');
                if (sstrPart.Length != 2)
                {
                    string strMsg = string.Format("在视图:{2}的FROM部分:{0}中,主表:{1}格式不正确,请检查!({3}->{4}", 
                        strText_From, strReleTabName,
                        objPrjTabEN_Main.TabName,
                                   clsStackTrace.GetCurrClassFunctionByLevel(2),
                                   clsStackTrace.GetCurrClassFunction());
                    objSqlViewEN.ErrMsg = strMsg;
                    objSqlViewEN.UpdDate = strCurrDate14;
                    objSqlViewEN.UpdUserId = strUserId;
                    clsSqlViewBL.UpdateBySql2(objSqlViewEN);
                    throw new Exception(strMsg);
                }
                string strReleTabName2 = sstrPart[1].Trim();
                clsPrjTabEN objPrjTabEN = clsPrjTabBLEx.GetObjByTabNameExCache(strPrjId, strReleTabName2);
                if (objPrjTabEN == null)
                {
                    string strMsg = string.Format("在视图:{1}中, 表名:{0}不存在,请检查!({2}->{3}", 
                        strReleTabName,
                        objPrjTabEN2.TabName,
                                   clsStackTrace.GetCurrClassFunctionByLevel(2),
                                   clsStackTrace.GetCurrClassFunction());
                    objSqlViewEN.ErrMsg = strMsg;
                    objSqlViewEN.UpdDate = strCurrDate14;
                    objSqlViewEN.UpdUserId = strUserId;
                    clsSqlViewBL.UpdateBySql2(objSqlViewEN);
                    throw new Exception(strMsg);
                }
                if (string.IsNullOrEmpty(strTabAliases) == true)
                {
                    strTabAliases = strReleTabName2;
                }
                if (string.IsNullOrEmpty(strTabAliases) == false)
                {
                    if (htTabAliases == null)
                    {
                        htTabAliases = new Hashtable();
                    }
                    htTabAliases.Add(strTabAliases, strReleTabName2);
                }

                clsSqlViewRelaTabEN objSqlViewRelaTabEN = new clsSqlViewRelaTabEN();
                objSqlViewRelaTabEN.SqlViewId = objSqlViewEN.SqlViewId;// Sql视图Id

                objSqlViewRelaTabEN.TabId = objPrjTabEN.TabId;// 表别名
                objSqlViewRelaTabEN.TabAliases = strTabAliases;// 表别名
                objSqlViewRelaTabEN.SvRelaTabTypeId = "02";// Sql视图相关表类型Id
                objSqlViewRelaTabEN.TabRelationTypeId = strTabRelationTypeId;// 表关系类型Id
                if (lstWord2.Count >= 2)
                {
                    objSqlViewRelaTabEN.TabRelationText = lstWord2[1];// 表关系文本
                }
                else
                {
                    objSqlViewRelaTabEN.TabRelationText = "";
                }
                objSqlViewRelaTabEN.OrderNum = intOrderNum++;// OrderNum
                objSqlViewRelaTabEN.PrjId = strPrjId;// 工程ID
                objSqlViewRelaTabEN.UpdDate = strCurrDate14;// 修改日期
                objSqlViewRelaTabEN.UpdUserId = strUserId;// 修改用户Id
                objSqlViewRelaTabEN.Memo = "通过分析!";// 说明

                sbCondition = new StringBuilder();
                sbCondition.AppendFormat("1 = 1");
                sbCondition.AppendFormat(" and SqlViewId = '{0}'", objSqlViewRelaTabEN.SqlViewId);
                //sbCondition.AppendFormat(" and RelaTabId = '{0}'", objSqlViewRelaTabEN.RelaTabId);
                sbCondition.AppendFormat(" and PrjId = '{0}'", objSqlViewRelaTabEN.PrjId);
                sbCondition.AppendFormat(" and TabAliases = '{0}'", objSqlViewRelaTabEN.TabAliases);

                if (clsSqlViewRelaTabBL.IsExistRecord(sbCondition.ToString()) == true)
                {
                    objSqlViewRelaTabEN.UpdateWithCondition(sbCondition.ToString());
                }
                else
                {
                    objSqlViewRelaTabEN.RelaTabId = clsSqlViewRelaTabBL.GetMaxStrId_S();// 相关表Id
                    clsSqlViewRelaTabBL.AddNewRecordBySql2(objSqlViewRelaTabEN);
                }
            }

            return true;
        }

        /// <summary>
        /// 字段分析Select部分
        /// </summary>
        /// <param name = "strText_Select">Select部分</param>
        /// <param name = "objSqlViewEN">Sql视图对象</param>
        /// <param name = "strPrjId">工程Id</param>
        /// <param name = "strCurrDate14">当前日期</param>
        /// <param name = "strUserId">操作用户Id</param>
        /// <returns>是否成功</returns>
        public static bool FieldAnalysis_Select(string strText_Select, clsSqlViewEN objSqlViewEN, string strPrjId, string strCurrDate14, string strUserId)
        {
            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabIdCache(objSqlViewEN.RelaTabId, strPrjId);

            int intLen_Head = "Select".Length;
            strText_Select = strText_Select.Substring(intLen_Head);
            //string strTopPercent = "";
            int intPos_top = strText_Select.IndexOf("top ", StringComparison.InvariantCultureIgnoreCase);
            if (intPos_top > 0)
            {
                int intPos_Percent = strText_Select.IndexOf("percent ", StringComparison.InvariantCultureIgnoreCase);
                strText_Select = strText_Select.Substring(intPos_Percent + 7);
            }

            int intPos_Distinct = strText_Select.IndexOf("distinct ", StringComparison.InvariantCultureIgnoreCase);
            if (intPos_Distinct >= 0)
            {
                strText_Select = strText_Select.Substring(intPos_Distinct + 8);
            }
            string strCondition_SqlViewId = string.Format("SqlViewId = '{0}'", objSqlViewEN.SqlViewId);
            List<clsvSqlViewRelaTabEN> arrvSqlViewRelaTabObjLst = clsvSqlViewRelaTabBL.GetObjLstCache(strPrjId);
            arrvSqlViewRelaTabObjLst = arrvSqlViewRelaTabObjLst.Where(x=>x.SqlViewId == objSqlViewEN.SqlViewId).ToList();
       

            string[] sstrFldExpress = strText_Select.Split(',');

            List<string> arrFldExpressLst = new List<string>();
            foreach (string sss in sstrFldExpress)
            {
                arrFldExpressLst.Add(sss);
            }
            List<string> arrFldExpressLst2 = GetUnionLst(arrFldExpressLst, ",");

            int intOrderNum = 1;
            foreach (string strFldExpress in arrFldExpressLst2)
            {

                clsSqlViewFldEN objSqlViewFldEN = new clsSqlViewFldEN();
                objSqlViewFldEN.SqlViewId = objSqlViewEN.SqlViewId;
                bool bolIsExistAS = false;
                int intPos_AS = strFldExpress.IndexOf(" AS ", StringComparison.InvariantCultureIgnoreCase);
                if (intPos_AS > 0)
                {
                    bolIsExistAS = true;
                }
                if (bolIsExistAS == true)
                {
                    string strFldExpress_Sub = strFldExpress.Trim();
                    List<string> lstFlag3 = new List<string>();
                    lstFlag3.Add(" AS ");

                    List<string> lstWord = clsString.SplitStringBySplitFlagLst(strFldExpress_Sub, lstFlag3);
                    List<string> lstWord2 = GetUnionLst(lstWord, "");
                    if (lstWord2.Count != 2)
                    {
                        string strMsg = string.Format("在视图:{1}的字段表达式部分:{0}中,格式不正确,请检查!({2}->{3})", 
                            strFldExpress,
                            objPrjTabEN.TabName,
                                   clsStackTrace.GetCurrClassFunctionByLevel(2),
                                   clsStackTrace.GetCurrClassFunction());
                        objSqlViewEN.ErrMsg = strMsg;
                        objSqlViewEN.UpdDate = strCurrDate14;
                        objSqlViewEN.UpdUserId = strUserId;
                        clsSqlViewBL.UpdateBySql2(objSqlViewEN);
                        throw new Exception(strMsg);
                    }
                    string strFieldAliases = lstWord2[1];
                    strFieldAliases = strFieldAliases.Substring(3).Trim();
                    string strFldExpressCutAS = lstWord2[0];
                    if (string.IsNullOrEmpty( strFldExpressCutAS) == true
                        || strFldExpressCutAS == "''")
                    {
                        strFldExpressCutAS = strFldExpress;
                    }
                    string[] sstrPart = strFldExpressCutAS.Split('.');
                    string strTabAliases = "";
                    if (strFldExpressCutAS.IndexOf("(") >= 0 || strFldExpressCutAS.IndexOf("case ", StringComparison.InvariantCultureIgnoreCase) >= 0)
                    {
                        strTabAliases = sstrPart[0].Trim();
                        objSqlViewFldEN.SqlViewId = objSqlViewEN.SqlViewId;// Sql视图Id
                        objSqlViewFldEN.RelaTabId = "";// 相关表Id
                        objSqlViewFldEN.FldId = "";// 字段ID
                        objSqlViewFldEN.FldExpression = strFldExpressCutAS;// 字段ID
                        if (strFldExpressCutAS == "ErrMsg" || 
                            strFieldAliases == "ErrMsg" 
                            || strFldExpress_Sub == "ErrMsg")
                        {
                            //string str = "";
                        }
                        objSqlViewFldEN.FieldAliases = strFieldAliases;// 字段别名
                        objSqlViewFldEN.Filters = "";// 筛选器
                        objSqlViewFldEN.OrderNum = intOrderNum++;// OrderNum
                        objSqlViewFldEN.PrjId = strPrjId;// 工程ID
                        objSqlViewFldEN.UpdDate = strCurrDate14;// 修改日期
                        objSqlViewFldEN.UpdUserId = strUserId;// 修改用户Id
                        objSqlViewFldEN.Memo = "通过分析!";// 说明
                        
                        StringBuilder sbCondition = new StringBuilder();
                        sbCondition.AppendFormat("1 = 1");
                        sbCondition.AppendFormat(" and SqlViewId = '{0}'", objSqlViewFldEN.SqlViewId);
                        sbCondition.AppendFormat(" and RelaTabId = '{0}'", objSqlViewFldEN.RelaTabId);
                        strFldExpressCutAS = strFldExpressCutAS.Replace("'", "''");
                        sbCondition.AppendFormat(" and FldExpression = '{0}'", strFldExpressCutAS);
                        sbCondition.AppendFormat(" and FldId = '{0}'", objSqlViewFldEN.FldId);
                        try
                        {
                            if (clsSqlViewFldBL.IsExistRecord(sbCondition.ToString()) == false)
                            {
                                clsSqlViewFldBL.AddNewRecordBySql2(objSqlViewFldEN);
                            }
                            else
                            {
                                objSqlViewFldEN.UpdateWithCondition(sbCondition.ToString());
                            }
                            clsvSqlViewFldBL.ReFreshThisCache();
                        }
                        catch (Exception objException)
                        {
                            throw objException;
                        }
                    }
                    else if (sstrPart.Length == 2)
                    {
                        strTabAliases = sstrPart[0].Trim();
//                        clsvSqlViewRelaTabEN objvSqlViewRelaTabEN = clsvSqlViewRelaTabBLEx.GetvSqlViewRelaTabObjByRelaTabIdCache(strTabAliases, arrvSqlViewRelaTabObjLst);
                        clsvSqlViewRelaTabEN objvSqlViewRelaTabEN = arrvSqlViewRelaTabObjLst.Find(x=>x.TabAliases == strTabAliases);
                        //if (htTabAliases !=  null && htTabAliases.Contains(sstrPart[0].Trim())  ==  true)
                        //{
                        //string strTabName = htTabAliases[sstrPart[0].Trim()].ToString();
                        //clsPrjTabEN objPrjTabEN = clsPrjTabBLEx.GetPrjTabObjByTabNameExCache(strTabName, strPrjId);
                        if (objvSqlViewRelaTabEN == null)
                        {
                            string strMsg = string.Format("在视图:{1}中, 表名:{0}不存在,请检查!({2}->{3})", 
                                strTabAliases, objvSqlViewRelaTabEN.SqlViewName,
                                   clsStackTrace.GetCurrClassFunctionByLevel(2),
                                   clsStackTrace.GetCurrClassFunction());
                            objSqlViewEN.ErrMsg = strMsg;
                            objSqlViewEN.UpdDate = strCurrDate14;
                            objSqlViewEN.UpdUserId = strUserId;
                            clsSqlViewBL.UpdateBySql2(objSqlViewEN);
                            throw new Exception(strMsg);
                        }
                        string strFldName = sstrPart[1];

                        clsvPrjTabFldEN objvPrjTabFldEN = clsvPrjTabFldBLEx.GetObjByFldNameExCache(strFldName, objvSqlViewRelaTabEN.TabId, strPrjId);
                        if (objvPrjTabFldEN == null)
                        {
                            string strMsg = string.Format("在视图:{1}中, 字段名:{0}不存在,请检查!({2}->{3})", 
                                strFldName,
                                objPrjTabEN.TabName,
                                   clsStackTrace.GetCurrClassFunctionByLevel(2),
                                   clsStackTrace.GetCurrClassFunction());
                            objSqlViewEN.ErrMsg = strMsg;
                            objSqlViewEN.UpdDate = strCurrDate14;
                            objSqlViewEN.UpdUserId = strUserId;
                            clsSqlViewBL.UpdateBySql2(objSqlViewEN);

                            throw new Exception(strMsg);
                        }
                        objSqlViewFldEN.SqlViewId = objSqlViewEN.SqlViewId;// Sql视图Id
                        objSqlViewFldEN.RelaTabId = objvSqlViewRelaTabEN.RelaTabId;// 相关表Id
                        objSqlViewFldEN.FldId = objvPrjTabFldEN.FldId;// 字段ID
                        objSqlViewFldEN.FldExpression = strFldExpress.Trim();// 字段ID

                        objSqlViewFldEN.FieldAliases = strFieldAliases;// 字段别名
                        objSqlViewFldEN.Filters = "";// 筛选器
                        objSqlViewFldEN.OrderNum = intOrderNum++;// OrderNum
                        objSqlViewFldEN.PrjId = strPrjId;// 工程ID
                        objSqlViewFldEN.UpdDate = strCurrDate14;// 修改日期
                        objSqlViewFldEN.UpdUserId = strUserId;// 修改用户Id
                        objSqlViewFldEN.Memo = "通过分析!";// 说明
                        StringBuilder sbCondition = new StringBuilder();
                        sbCondition.AppendFormat("1 = 1");
                        sbCondition.AppendFormat(" and SqlViewId = '{0}'", objSqlViewFldEN.SqlViewId);
                        sbCondition.AppendFormat(" and RelaTabId = '{0}'", objSqlViewFldEN.RelaTabId);
                        sbCondition.AppendFormat(" and FldExpression = '{0}'", objSqlViewFldEN.FldExpression);
                        sbCondition.AppendFormat(" and FldId = '{0}'", objSqlViewFldEN.FldId);
                        try
                        {
                            if (clsSqlViewFldBL.IsExistRecord(sbCondition.ToString()) == false)
                            {
                                clsSqlViewFldBL.AddNewRecordBySql2(objSqlViewFldEN);
                            }
                            else
                            {
                                objSqlViewFldEN.UpdateWithCondition(sbCondition.ToString());
                            }
                        }
                        catch (Exception objException)
                        {
                            throw objException;
                        }

                        //}
                    }
                    else if (sstrPart.Length == 3)
                    {
                        string strTabName = sstrPart[1];

                        clsvSqlViewRelaTabEN objvSqlViewRelaTabEN = clsvSqlViewRelaTabBLEx.GetvSqlViewRelaTabObjByRelaTabIdCache(strTabName, arrvSqlViewRelaTabObjLst);
                        //clsPrjTabEN objPrjTabEN = clsPrjTabBLEx.GetPrjTabObjByTabNameExCache(strTabName, strPrjId);
                        if (objvSqlViewRelaTabEN == null)
                        {
                            string strMsg = string.Format("在视图:{1}中, 表名:{0}不存在,请检查!({2}->{3})", 
                                strTabName,
                                objPrjTabEN.TabName,
                                   clsStackTrace.GetCurrClassFunctionByLevel(2),
                                   clsStackTrace.GetCurrClassFunction());
                            objSqlViewEN.ErrMsg = strMsg;
                            objSqlViewEN.UpdDate = strCurrDate14;
                            objSqlViewEN.UpdUserId = strUserId;
                            clsSqlViewBL.UpdateBySql2(objSqlViewEN);
                            throw new Exception(strMsg);
                        }
                        string strFldName = sstrPart[2];
                        clsvPrjTabFldEN objvPrjTabFldEN = clsvPrjTabFldBLEx.GetObjByFldNameExCache(strFldName, objvSqlViewRelaTabEN.TabId, strPrjId);
                        if (objvPrjTabFldEN == null)
                        {
                            string strMsg = string.Format("在视图:{1}中, 在表:{2}中,字段名:{0}不存在,请检查!({3}->{4})", 
                                strFldName,
                                objPrjTabEN.TabName, objvSqlViewRelaTabEN.TabName,
                                   clsStackTrace.GetCurrClassFunctionByLevel(2),
                                   clsStackTrace.GetCurrClassFunction());
                            objSqlViewEN.ErrMsg = strMsg;
                            objSqlViewEN.UpdDate = strCurrDate14;
                            objSqlViewEN.UpdUserId = strUserId;
                            clsSqlViewBL.UpdateBySql2(objSqlViewEN);
                            throw new Exception(strMsg);
                        }
                        objSqlViewFldEN.SqlViewId = objSqlViewEN.SqlViewId;// Sql视图Id
                        objSqlViewFldEN.RelaTabId = objvSqlViewRelaTabEN.RelaTabId;// 相关表Id
                        objSqlViewFldEN.FldId = objvPrjTabFldEN.FldId;// 字段ID
                        objSqlViewFldEN.FldExpression = strFldExpress;// 字段ID

                        objSqlViewFldEN.FieldAliases = strFieldAliases;// 字段别名
                        objSqlViewFldEN.Filters = "";// 筛选器
                        objSqlViewFldEN.OrderNum = intOrderNum++;// OrderNum
                        objSqlViewFldEN.PrjId = strPrjId;// 工程ID
                        objSqlViewFldEN.UpdDate = strCurrDate14;// 修改日期
                        objSqlViewFldEN.UpdUserId = strUserId;// 修改用户Id
                        objSqlViewFldEN.Memo = "通过分析!";// 说明
                        StringBuilder sbCondition = new StringBuilder();
                        sbCondition.AppendFormat("1 = 1");
                        sbCondition.AppendFormat(" and SqlViewId = '{0}'", objSqlViewFldEN.SqlViewId);
                        sbCondition.AppendFormat(" and RelaTabId = '{0}'", objSqlViewFldEN.RelaTabId);
                        sbCondition.AppendFormat(" and FldExpression = '{0}'", objSqlViewFldEN.FldExpression);
                        sbCondition.AppendFormat(" and FldId = '{0}'", objSqlViewFldEN.FldId);
                        try
                        {
                            if (clsSqlViewFldBL.IsExistRecord(sbCondition.ToString()) == false)
                            {
                                clsSqlViewFldBL.AddNewRecordBySql2(objSqlViewFldEN);
                            }
                            else
                            {
                                objSqlViewFldEN.UpdateWithCondition(sbCondition.ToString());
                            }
                        }
                        catch (Exception objException)
                        {
                            throw objException;
                        }
                    }
                    else
                    {
                        objSqlViewFldEN.SqlViewId = objSqlViewEN.SqlViewId;// Sql视图Id
                        objSqlViewFldEN.RelaTabId = "";// 相关表Id
                        objSqlViewFldEN.FldId = "";// 字段ID
                        objSqlViewFldEN.FldExpression = strFldExpressCutAS;// 字段ID

                        objSqlViewFldEN.FieldAliases = strFieldAliases;// 字段别名
                        objSqlViewFldEN.Filters = "";// 筛选器
                        objSqlViewFldEN.OrderNum = intOrderNum++;// OrderNum
                        objSqlViewFldEN.PrjId = strPrjId;// 工程ID
                        objSqlViewFldEN.UpdDate = strCurrDate14;// 修改日期
                        objSqlViewFldEN.UpdUserId = strUserId;// 修改用户Id
                        objSqlViewFldEN.Memo = "通过分析!";// 说明
                        string strFldExpressType = "variable";
                        if (strFldExpressCutAS.StartsWith("'") && strFldExpressCutAS.EndsWith("'"))
                        {
                            // 字符串被单引号包围，被认为是常量
                            Console.WriteLine("字符串是常量");
                            strFldExpressType = "constant";
                            var strTemp = strFldExpressCutAS;
                            strFldExpressCutAS = strTemp.Substring(1, strTemp.Length - 2);
                            objSqlViewFldEN.FldExpression = strFldExpressCutAS;// 字段ID
                        }
                        else
                        {
                            // 字符串不是被单引号包围，不是常量
                            Console.WriteLine("字符串不是常量");
                        }
                        objSqlViewFldEN.FldExpressionType = strFldExpressType;
                        StringBuilder sbCondition = new StringBuilder();
                        sbCondition.AppendFormat("1 = 1");
                        sbCondition.AppendFormat(" and SqlViewId = '{0}'", objSqlViewFldEN.SqlViewId);
                        sbCondition.AppendFormat(" and RelaTabId = '{0}'", objSqlViewFldEN.RelaTabId);
                        if (strFldExpressType != "constant")
                        {
                            strFldExpressCutAS = strFldExpressCutAS.Replace("'", "''");
                            sbCondition.AppendFormat(" and FldId = '{0}'", objSqlViewFldEN.FldId);
                            sbCondition.AppendFormat(" and FldExpression = '{0}'", strFldExpressCutAS);
                        }
                        
                        else
                        {
                            sbCondition.AppendFormat(" and FldExpressionType = 'constant'");
                            sbCondition.AppendFormat(" and FldExpression = '{0}'", strFldExpressCutAS);
                        }
                       
                        try
                        {
                            if (clsSqlViewFldBL.IsExistRecord(sbCondition.ToString()) == false)
                            {
                                clsSqlViewFldBL.AddNewRecordBySql2(objSqlViewFldEN);
                            }
                            else
                            {
                                objSqlViewFldEN.UpdateWithCondition(sbCondition.ToString());
                            }
                        }
                        catch (Exception objException)
                        {
                            throw objException;
                        }
                    }

                }
                else // 不含有AS
                {
                    string[] sstrPart = strFldExpress.Split('.');
                    if (arrvSqlViewRelaTabObjLst.Count == 1 && sstrPart.Length == 1)
                    {
                        //string strTabAliases = sstrPart[0].Trim();
                        clsvSqlViewRelaTabEN objvSqlViewRelaTabEN = arrvSqlViewRelaTabObjLst[0];// clsvSqlViewRelaTabBLEx.GetvSqlViewRelaTabObjByRelaTabIdCache(strTabAliases, arrvSqlViewRelaTabObjLst);
                        //if (htTabAliases !=  null && htTabAliases.Contains(sstrPart[0].Trim())  ==  true)
                        //{
                        //string strTabName = htTabAliases[sstrPart[0].Trim()].ToString();
                        //clsPrjTabEN objPrjTabEN = clsPrjTabBLEx.GetPrjTabObjByTabNameExCache(strTabName, strPrjId);
                        //if (objvSqlViewRelaTabEN  ==  null)
                        //{
                        //    string strMsg = string.Format("在视图:{1}中, 表名:{0}不存在,请检查!", strTabAliases, objSqlViewEN.SqlViewName);
                        //    throw new Exception(strMsg);
                        //}
                        string strFldName = sstrPart[0];

                        clsvPrjTabFldEN objvPrjTabFldEN = clsvPrjTabFldBLEx.GetObjByFldNameExCache(strFldName, objvSqlViewRelaTabEN.TabId, strPrjId);
                        if (objvPrjTabFldEN == null)
                        {
                            string strMsg = string.Format("在视图:{1}中, 字段名:{0}不存在,请检查!({2}->{3})", 
                                strFldName, objvSqlViewRelaTabEN.TabName,
                                   clsStackTrace.GetCurrClassFunctionByLevel(2),
                                   clsStackTrace.GetCurrClassFunction());
                            objSqlViewEN.ErrMsg = strMsg;
                            objSqlViewEN.UpdDate = strCurrDate14;
                            objSqlViewEN.UpdUserId = strUserId;
                            clsSqlViewBL.UpdateBySql2(objSqlViewEN);
                            throw new Exception(strMsg);
                        }
                        objSqlViewFldEN.SqlViewId = objSqlViewEN.SqlViewId;// Sql视图Id
                        objSqlViewFldEN.RelaTabId = objvSqlViewRelaTabEN.RelaTabId;// 相关表Id
                        objSqlViewFldEN.FldId = objvPrjTabFldEN.FldId;// 字段ID
                        objSqlViewFldEN.FldExpression = strFldExpress.Trim();// 字段ID

                        objSqlViewFldEN.FieldAliases = "";// 字段别名
                        objSqlViewFldEN.Filters = "";// 筛选器
                        objSqlViewFldEN.OrderNum = intOrderNum++;// OrderNum
                        objSqlViewFldEN.PrjId = strPrjId;// 工程ID
                        objSqlViewFldEN.UpdDate = strCurrDate14;// 修改日期
                        objSqlViewFldEN.UpdUserId = strUserId;// 修改用户Id
                        objSqlViewFldEN.Memo = "通过分析!";// 说明
                        StringBuilder sbCondition = new StringBuilder();
                        sbCondition.AppendFormat("1 = 1");
                        sbCondition.AppendFormat(" and SqlViewId = '{0}'", objSqlViewFldEN.SqlViewId);
                        sbCondition.AppendFormat(" and RelaTabId = '{0}'", objSqlViewFldEN.RelaTabId);
                        sbCondition.AppendFormat(" and FldExpression = '{0}'", objSqlViewFldEN.FldExpression);
                        sbCondition.AppendFormat(" and FldId = '{0}'", objSqlViewFldEN.FldId);
                        try
                        {
                            if (clsSqlViewFldBL.IsExistRecord(sbCondition.ToString()) == false)
                            {
                                clsSqlViewFldBL.AddNewRecordBySql2(objSqlViewFldEN);
                            }
                            else
                            {
                                objSqlViewFldEN.UpdateWithCondition(sbCondition.ToString());
                            }
                        }
                        catch (Exception objException)
                        {
                            throw objException;
                        }
                    }
                    else if (sstrPart.Length == 2)
                    {
                        string strTabAliases = sstrPart[0].Trim();
                        clsvSqlViewRelaTabEN objvSqlViewRelaTabEN = clsvSqlViewRelaTabBLEx.GetvSqlViewRelaTabObjByRelaTabIdCache(strTabAliases, arrvSqlViewRelaTabObjLst);
                        //if (htTabAliases !=  null && htTabAliases.Contains(sstrPart[0].Trim())  ==  true)
                        //{
                        //string strTabName = htTabAliases[sstrPart[0].Trim()].ToString();
                        //clsPrjTabEN objPrjTabEN = clsPrjTabBLEx.GetPrjTabObjByTabNameExCache(strTabName, strPrjId);
                        if (objvSqlViewRelaTabEN == null)
                        {
                            string strMsg = string.Format("在视图:{1}中, 表名:{0}不存在,请检查!({2}->{3})", 
                                strTabAliases,
                                objPrjTabEN.TabName,
                                   clsStackTrace.GetCurrClassFunctionByLevel(2),
                                   clsStackTrace.GetCurrClassFunction());
                            objSqlViewEN.ErrMsg = strMsg;
                            objSqlViewEN.UpdDate = strCurrDate14;
                            objSqlViewEN.UpdUserId = strUserId;
                            clsSqlViewBL.UpdateBySql2(objSqlViewEN);
                            throw new Exception(strMsg);
                        }
                        string strFldName = sstrPart[1];

                        clsvPrjTabFldEN objvPrjTabFldEN = clsvPrjTabFldBLEx.GetObjByFldNameExCache(strFldName, objvSqlViewRelaTabEN.TabId, strPrjId);
                        if (objvPrjTabFldEN == null)
                        {
                            string strMsg = string.Format("在视图:{1}中, 字段名:{0}不存在,请检查!({2}->{3})", 
                                strFldName,
                                objPrjTabEN.TabName,
                                   clsStackTrace.GetCurrClassFunctionByLevel(2),
                                   clsStackTrace.GetCurrClassFunction());
                            objSqlViewEN.ErrMsg = strMsg;
                            objSqlViewEN.UpdDate = strCurrDate14;
                            objSqlViewEN.UpdUserId = strUserId;
                            clsSqlViewBL.UpdateBySql2(objSqlViewEN);
                            throw new Exception(strMsg);
                        }
                        objSqlViewFldEN.SqlViewId = objSqlViewEN.SqlViewId;// Sql视图Id
                        objSqlViewFldEN.RelaTabId = objvSqlViewRelaTabEN.RelaTabId;// 相关表Id
                        objSqlViewFldEN.FldId = objvPrjTabFldEN.FldId;// 字段ID
                        objSqlViewFldEN.FldExpression = strFldExpress.Trim();// 字段ID

                        objSqlViewFldEN.FieldAliases = "";// 字段别名
                        objSqlViewFldEN.Filters = "";// 筛选器
                        objSqlViewFldEN.OrderNum = intOrderNum++;// OrderNum
                        objSqlViewFldEN.PrjId = strPrjId;// 工程ID
                        objSqlViewFldEN.UpdDate = strCurrDate14;// 修改日期
                        objSqlViewFldEN.UpdUserId = strUserId;// 修改用户Id
                        objSqlViewFldEN.Memo = "通过分析!";// 说明
                        StringBuilder sbCondition = new StringBuilder();
                        sbCondition.AppendFormat("1 = 1");
                        sbCondition.AppendFormat(" and SqlViewId = '{0}'", objSqlViewFldEN.SqlViewId);
                        sbCondition.AppendFormat(" and RelaTabId = '{0}'", objSqlViewFldEN.RelaTabId);
                        sbCondition.AppendFormat(" and FldExpression = '{0}'", objSqlViewFldEN.FldExpression);
                        sbCondition.AppendFormat(" and FldId = '{0}'", objSqlViewFldEN.FldId);
                        try
                        {
                            if (clsSqlViewFldBL.IsExistRecord(sbCondition.ToString()) == false)
                            {
                                clsSqlViewFldBL.AddNewRecordBySql2(objSqlViewFldEN);
                            }
                            else
                            {
                                objSqlViewFldEN.UpdateWithCondition(sbCondition.ToString());
                            }
                        }
                        catch (Exception objException)
                        {
                            throw objException;
                        }
                    }
                    else if (sstrPart.Length == 3)
                    {

                        string strTabName = sstrPart[1];
                        //clsPrjTabEN objPrjTabEN = clsPrjTabBLEx.GetPrjTabObjByTabNameExCache(strTabName, strPrjId);
                        clsvSqlViewRelaTabEN objvSqlViewRelaTabEN = clsvSqlViewRelaTabBLEx.GetvSqlViewRelaTabObjByRelaTabIdCache(strTabName, arrvSqlViewRelaTabObjLst);

                        if (objvSqlViewRelaTabEN == null)
                        {
                            string strMsg = string.Format("在视图:{1}中, 表名:{0}不存在,请检查!({2}->{3})", 
                                strTabName,
                                objPrjTabEN.TabName,
                                   clsStackTrace.GetCurrClassFunctionByLevel(2),
                                   clsStackTrace.GetCurrClassFunction());
                            objSqlViewEN.ErrMsg = strMsg;
                            objSqlViewEN.UpdDate = strCurrDate14;
                            objSqlViewEN.UpdUserId = strUserId;
                            clsSqlViewBL.UpdateBySql2(objSqlViewEN);
                            throw new Exception(strMsg);
                        }
                        string strFldName = sstrPart[2].Trim();
                        if (strFldName.Substring(0, 1) == "[")
                        {
                            strFldName = strFldName.Substring(1, strFldName.Length - 2);
                        }
                        clsvPrjTabFldEN objvPrjTabFldEN = clsvPrjTabFldBLEx.GetObjByFldNameExCache(strFldName, objvSqlViewRelaTabEN.TabId, strPrjId);
                        if (objvPrjTabFldEN == null)
                        {
                            string strMsg = string.Format("在表:{1}中, 字段名:{0}不存在,请检查!", strFldName, objvSqlViewRelaTabEN.TabName);

                            throw new Exception(strMsg);
                        }
                        objSqlViewFldEN.SqlViewId = objSqlViewEN.SqlViewId;// Sql视图Id
                        objSqlViewFldEN.RelaTabId = objvSqlViewRelaTabEN.RelaTabId;// 相关表Id
                        objSqlViewFldEN.FldId = objvPrjTabFldEN.FldId;// 字段ID
                        objSqlViewFldEN.FldExpression = strFldExpress;// 字段ID

                        objSqlViewFldEN.FieldAliases = "";// 字段别名
                        objSqlViewFldEN.Filters = "";// 筛选器
                        objSqlViewFldEN.OrderNum = intOrderNum++;// OrderNum
                        objSqlViewFldEN.PrjId = strPrjId;// 工程ID
                        objSqlViewFldEN.UpdDate = strCurrDate14;// 修改日期
                        objSqlViewFldEN.UpdUserId = strUserId;// 修改用户Id
                        objSqlViewFldEN.Memo = "通过分析!";// 说明

                        StringBuilder sbCondition = new StringBuilder();
                        sbCondition.AppendFormat("1 = 1");
                        sbCondition.AppendFormat(" and SqlViewId = '{0}'", objSqlViewFldEN.SqlViewId);
                        sbCondition.AppendFormat(" and RelaTabId = '{0}'", objSqlViewFldEN.RelaTabId);
                        sbCondition.AppendFormat(" and FldExpression = '{0}'", objSqlViewFldEN.FldExpression);
                        sbCondition.AppendFormat(" and FldId = '{0}'", objSqlViewFldEN.FldId);
                        try
                        {
                            if (clsSqlViewFldBL.IsExistRecord(sbCondition.ToString()) == false)
                            {
                                clsSqlViewFldBL.AddNewRecordBySql2(objSqlViewFldEN);
                            }
                            else
                            {
                                objSqlViewFldEN.UpdateWithCondition(sbCondition.ToString());
                            }
                        }
                        catch (Exception objException)
                        {
                            throw objException;
                        }
                    }
                    else
                    {
                        string strMsg = string.Format("在视图:{1}的字段表达式:{0}格式不正确,请检查!({2}->{3})", 
                            strFldExpress,
                            objPrjTabEN.TabName,
                                   clsStackTrace.GetCurrClassFunctionByLevel(2),
                                   clsStackTrace.GetCurrClassFunction());
                        objSqlViewEN.ErrMsg = strMsg;
                        objSqlViewEN.UpdDate = strCurrDate14;
                        objSqlViewEN.UpdUserId = strUserId;
                        clsSqlViewBL.UpdateBySql2(objSqlViewEN);
                        throw new Exception(strMsg);
                    }
                }
            }

            return true;
        }
        /// <summary>
        /// 合并字符串列表(List[string]),经分隔标志分隔后,分成多个字符串列表,把包含在“(”,“)”中的子字符串合并起来
        ///                                 这些不需要合并
        /// </summary>
        /// <param name = "lstWord">源字符串列表</param>
        /// <param name = "strJoinChar">源字符串列表</param>
        /// <returns>合并后的字符串列表</returns>
        public static List<string> GetUnionLst(List<string> lstWord, string strJoinChar)
        {
            List<string> lstWord2 = new List<string>();
            for (int i = 0; i < lstWord.Count; i++)
            {
                string strWord = lstWord[i];
                int intState = 0;
                if (strWord.IndexOf("(") >= 0)
                {
                    string strWordAll = "";
                    intState = 0;
                    int intPos_left = strWord.IndexOf("(");
                    int intNext_i = 0;
                    for (int j = i; j < lstWord.Count; j++)
                    {
                        strWord = lstWord[j];
                        int intPos_Char = 0;
                        while (intPos_Char < strWord.Length)
                        {
                            if (strWord.Substring(intPos_Char, 1) == "(")
                            {
                                intState++;
                            }
                            else if (strWord.Substring(intPos_Char, 1) == ")")
                            {
                                intState--;
                            }
                            intPos_Char++;
                        }
                        strWordAll += strWord + strJoinChar;
                        if (intState == 0)
                        {
                            intNext_i = j;
                            break;
                        }

                    }//for(int j = i
                    i = intNext_i;
                    if (string.IsNullOrEmpty(strJoinChar) == false)
                    {
                        strWordAll = strWordAll.Remove(strWordAll.Length - strJoinChar.Length);
                    }
                    lstWord2.Add(strWordAll.Trim());
                }
                else
                {
                    lstWord2.Add(strWord.Trim());
                }
            }

            return lstWord2;
        }

        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name = "lngmId">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        private static clsvSqlViewRelaTabEN GetvSqlViewRelaTabObjByRelaTabId(string strRelaTabId, List<clsvSqlViewRelaTabEN> arrvSqlViewRelaTabObjLst)
        {

            foreach (clsvSqlViewRelaTabEN objvSqlViewRelaTabEN in arrvSqlViewRelaTabObjLst)
            {
                if (objvSqlViewRelaTabEN.RelaTabId == strRelaTabId)
                {
                    return objvSqlViewRelaTabEN;
                }
            }
            return null;
        }


        /// <summary>
        /// 根据引用设置表或者视图的次序
        /// </summary>
        /// <param name = "strPrjId"></param>
        /// <returns></returns>
        public static string SetOrderNum4ReferNewBak20160901(string strPrjId)
        {
            int n;
            bool iswrong;
            int i;
            string strCondition = string.Format("PrjId = '{0}' Order By TabId", strPrjId);
            string strCurrDate14 = clsDateTime.getTodayDateTimeStr(1);
            clsSqlViewBLEx PP = new clsSqlViewBLEx();
            PP.arrPrjTabObjLst = clsPrjTabBL.GetObjLst(strCondition);
            n = PP.arrPrjTabObjLst.Count;
            int intIndex = 0;
            foreach (clsPrjTabEN objPrjTabEN in PP.arrPrjTabObjLst)
            {
                objPrjTabEN._IntTag = intIndex++;
            }

            PP.Init();
            PP.input(strPrjId);
            iswrong = PP.cal(n);
            i = 1;
            StringBuilder sbMsg = new StringBuilder();
            //if (iswrong  ==  true)
            //{
            //    Console.WriteLine("课程关系错误!\n");
            //}
            //else
            //{
            while (PP.ans[i].Count > 0)
            {
                sbMsg.AppendFormat("第{0}批课程:\r\n", i);
                while (PP.ans[i].Count > 0)
                {
                    int intIndex2 = PP.ans[i][PP.ans[i].Count - 1];

                    sbMsg.AppendFormat("{0}\r\n", intIndex2);
                    PP.ans[i].RemoveAt(PP.ans[i].Count - 1);

                }
                sbMsg.AppendFormat("");
                i++;
            }
            //}
            //Console.ReadLine();
            //List<clsSqlViewEN> arrSqlViewObjLst = clsSqlViewBL.GetObjLst(strCondition);
            return sbMsg.ToString();
        }
       
        public static clsSqlViewEN GetSqlViewObjByTabId(List<clsSqlViewEN> arrSqlViewObjLst, string strTabId)
        {
            foreach (clsSqlViewEN objSqlViewEN in arrSqlViewObjLst)
            {
                if (objSqlViewEN.RelaTabId == strTabId)
                {
                    return objSqlViewEN;
                }
            }
            return null;
        }

        /// <summary>
        /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
        /// (AGC.BusinessLogicEx.AutoGC6Cs_Business:Gen_4BL_GetRecNameByKeyCache)
        /// </summary>
        /// <param name = "strPrjId">项目Id</param>
        /// <param name = "strTabId">表id</param>
        /// <returns>根据关键字获取的名称</returns>
        public static string GetSqlViewIdByTabIdCache(string strPrjId, string strTabId)
        {
            string strCondition = string.Format("{0} = '{1}' Order By {2}",
                conSqlView.PrjId, strPrjId, conSqlView.SqlViewId);

            if (string.IsNullOrEmpty(strTabId) == true) return "";
            List<clsSqlViewEN> arrObjLstCache = clsSqlViewBL.GetObjLstCache(strPrjId);

            foreach (clsSqlViewEN objSqlViewEN in arrObjLstCache)
            {
                if (objSqlViewEN.RelaTabId == strTabId)
                {
                    intFindFailCount = 0;
                    return objSqlViewEN.SqlViewId;
                }
            }
            intFindFailCount++;
            // 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用

            CacheHelper.Remove(clsSqlViewEN._CurrTabName);
            if (intFindFailCount <= 2) return GetSqlViewIdByTabIdCache(strPrjId, strTabId);
            string strErrMsgForGetObjById = string.Format("在SqlView对象缓存列表中,找不到记录[strTabId = {0}][intFindFailCount = {1}](函数:{2})", strTabId, intFindFailCount, clsStackTrace.GetCurrFunction());
            clsLog.LogErrorS2("clsSqlViewBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
            throw new Exception(strErrMsgForGetObjById);

        }
        public static string GetSqlViewIdByTabId(string strTabId)
        {
            string strCondition = string.Format("{0} = '{1}' ",
                conSqlView.RelaTabId, strTabId, conSqlView.SqlViewId);

            if (string.IsNullOrEmpty(strTabId) == true) return "";
            return clsSqlViewBL.GetFirstID_S(strCondition);
        }

        /// <summary>
        /// 根据关键字获取相关表Id（RelaTabId）, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name = "strSqlViewId">所给的关键字</param>
        /// <returns>根据关键字获取的相关表Id（RelaTabId）</returns>
        private static string GetRelaTabIdBySqlViewId(string strSqlViewId)
        {
            List<string> arrRelaTabId = clsSqlViewBL.GetFldValue(conSqlView.RelaTabId,
                   string.Format("{0}='{1}'", conSqlView.SqlViewId, strSqlViewId));
            if (arrRelaTabId.Count > 0) return arrRelaTabId[0];
            return "";
        }
        /// <summary>
        /// 根据关键字获取相关表Id（RelaTabId）, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name = "strPrjId">项目Id</param>
        /// <param name = "strSqlViewId">strSqlViewId</param>
        /// <returns>根据关键字获取的相关表Id（RelaTabId）</returns>
        public static string GetRelaTabIdBySqlViewIdCache(string strPrjId, string strSqlViewId)
        {
            string strCondition = string.Format("{0} = '{1}' Order By {2}",
                conSqlView.PrjId, strPrjId, conSqlView.SqlViewId);

            if (string.IsNullOrEmpty(strSqlViewId) == true) return "";
            List<clsSqlViewEN> arrObjLstCache = clsSqlViewBL.GetObjLstCache(strPrjId);

            foreach (clsSqlViewEN objSqlViewEN in arrObjLstCache)
            {
                if (objSqlViewEN.SqlViewId == strSqlViewId)
                {
                    intFindFailCount = 0;
                    return objSqlViewEN.RelaTabId;
                }
            }
            intFindFailCount++;
            // 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用

            CacheHelper.Remove(clsSqlViewEN._CurrTabName);

            if (intFindFailCount == 1) return GetRelaTabIdBySqlViewIdCache(strPrjId, strSqlViewId);
            string strErrMsgForGetObjById = string.Format("在SqlView对象缓存列表中,找不到记录[strSqlViewId = {0}][intFindFailCount = {1}](函数:{2})", strSqlViewId, intFindFailCount, clsStackTrace.GetCurrFunction());
            clsLog.LogErrorS2("clsSqlViewBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
            throw new Exception(strErrMsgForGetObjById);

        }



        public static bool DelRecordEx(string strSqlViewId)
        {
            string strSQL = "";
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();

            //删除PrjTab本表中与当前对象有关的记录

            strSQL = strSQL + "Delete from SqlViewFld where SqlViewId = '" + strSqlViewId + "'";
            strSQL = strSQL + "Delete from SqlViewRelaTab where SqlViewId = '" + strSqlViewId + "'";
            strSQL = strSQL + "Delete from Log4CreateView4Sql where SqlViewId = '" + strSqlViewId + "'";
            strSQL = strSQL + "Delete from SqlView where SqlViewId = '" + strSqlViewId + "'";
            return objSQL.ExecSql(strSQL);
        }

        /// <summary>
        /// 功能:通过存储过程来插入记录
        /// </summary>
        /// <param name = "objElecDictEN">需要添加到数据库中的对象</param>
        /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
        public static bool p_Set_InitLog4CreateView4Sql(string strPrjId, string strPrjDataBaseId, string strUserId)
        {
            //通过存储过程来
            //直接使用
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsLog4CreateView4SqlDA.GetSpecSQLObj();

            ArrayList values = new ArrayList();
            values.Add(strPrjId);
            values.Add(strPrjDataBaseId);
            values.Add(strUserId);
            try
            {
                objSQL.ExecSP2("p_Set_InitLog4CreateView4Sql", values);
            }
            catch (Exception objException)
            {
                throw objException;
            }
            return true;
        }
        List<int>[] r = new List<int>[5001];
        //int[][] r = new int[101][100];
        int[] rk = new int[5001];
        //vector<int> ans[101];
        List<int>[] ans = new List<int>[5001];
        int[] num = new int[5001];
        //int flag;
        public void Init()
        {
            for (int i = 0; i < 5001; i++)
            {
                r[i] = new List<int>();
                ans[i] = new List<int>();
            }
        }
        public void input(string strPrjId)
        {
            int t1, t2;
            string strCondition = string.Format("PrjId = '{0}' Order By RelaTabId", strPrjId);

            List<clsvSqlViewRelaTabEN> arrSqlViewRelaTabENObjLst = clsvSqlViewRelaTabBL
                .GetObjLstCache(strPrjId)
                .OrderBy(x=>x.RelaTabId)
                .ToList();

            for (int i = arrSqlViewRelaTabENObjLst.Count - 1; i >= 0; i--)
            {
                clsvSqlViewRelaTabEN objSqlViewRelaTabEN = arrSqlViewRelaTabENObjLst[i];
                t1 = GetIndexByObj(objSqlViewRelaTabEN.RelaTabId4SqlView);
                t2 = GetIndexByObj(objSqlViewRelaTabEN.TabId);
                if (t1 == 0) continue;
                r[t1].Add(t2);
                rk[t1]++;
                num[t2]++;
            }

        }
        bool cal(int n)
        {
            int i;
            bool[] flag = new bool[5001];
            int count;
            //vector<int>::iterator it;

            p temp = new p();
            Queue<p> qu = new Queue<p>();
            //memset(flag, 0, sizeof(flag));
            count = n;

            for (i = 1; i <= n; i++)
            {
                if (num[i] == 0)
                {
                    temp = new p();
                    temp.st = 1;
                    temp.x = i;
                    qu.Enqueue(temp);
                    flag[i] = true;
                }
            }
            while (qu.Count > 0)
            {
                for (i = 0; i < rk[qu.Peek().x]; i++)
                {
                    num[r[qu.Peek().x][i]]--;
                    if (num[r[qu.Peek().x][i]] == 0 && flag[r[qu.Peek().x][i]] == false)
                    {
                        flag[r[qu.Peek().x][i]] = true;
                        temp = new p();
                        temp.st = qu.Peek().st + 1;
                        temp.x = r[qu.Peek().x][i];
                        qu.Enqueue(temp);
                    }
                }
                ans[qu.Peek().st].Add(qu.Peek().x);
                qu.Dequeue();
                count--;
            }

            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int GetIndexByObj(string strTabId)
        {
            foreach (clsPrjTabEN objPrjTabEN in arrPrjTabObjLst)
            {
                if (objPrjTabEN.TabId == strTabId)
                {
                    return objPrjTabEN._IntTag;
                }
            }
            return 0;
        }
        //static void Main(string[] args)
        //{
        //    int n;
        //    bool iswrong;
        //    int i;
        //    Console.WriteLine("请输入课程数量n(编号1-n):");
        //    string strInput = Console.ReadLine();
        //    n = int.Parse(strInput);
        //    //            scanf("%d", &n);
        //    Console.WriteLine("请输入课程关系(格式“A B”,表示要学B就必须先把A学掉。以“0 0”表示结束):\n");
        //    Program PP = new Program();
        //    PP.Init();
        //    PP.input();
        //    iswrong = PP.cal(n);
        //    i = 1;
        //    if (iswrong  ==  true)
        //    {
        //        Console.WriteLine("课程关系错误!\n");
        //    }
        //    else
        //    {
        //        while (PP.ans[i].Count > 0)
        //        {
        //            Console.WriteLine(string.Format("第{0}批课程:", i));
        //            while (PP.ans[i].Count > 0)
        //            {
        //                Console.WriteLine(PP.ans[i][PP.ans[i].Count - 1]);
        //                PP.ans[i].RemoveAt(PP.ans[i].Count - 1);
        //            }
        //            Console.WriteLine("");
        //            i++;
        //        }
        //    }
        //    Console.ReadLine();
        //    return;
        //}

    }
    class p
    {
        public int x;
        public int st;
    };
}
