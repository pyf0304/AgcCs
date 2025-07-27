using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AGC.Entity;
using com.taishsoft.commdb;
using AGC.BusinessLogic;
using AgcCommBase;
using com.taishsoft.datetime;


namespace AGC.BusinessLogicEx
{
    public partial class clsUserPrjGrantBLEx : clsUserPrjGrantBL
    {
        public static bool IsExistSameRec(string strUserId,    string strPrjId)
        {
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("UserId='{0}'", strUserId);
            sbCondition.AppendFormat(" and PrjId='{0}'", strPrjId);
            return  clsUserPrjGrantBL.IsExistRecord(sbCondition.ToString());
        }
        /// <summary>
        /// 获取某用户的项目数
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <returns>该用户的项目数</returns>
        public static int GetPrjCountByUserId(string strUserId)
        {
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("UserId='{0}'", strUserId);
            if (clsSysParaEN.bolIsUseXmlDataSource == true)
            {
                return clsSysParaEN.objSpecSqlForXml.funGetRecCount(clsUserPrjGrantEN._CurrTabName, sbCondition.ToString());
            }
            else
            {
                return clsUserPrjGrantBL.GetRecCountByCond(sbCondition.ToString());
            }
        }
        /// <summary>
        /// 获取某用户的按最后使用的项目
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <returns>该用户的项目数</returns>
        public static clsUserPrjGrantEN GetFirstObjByUserId(string strUserId)
        {
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.Append($"UserId='{strUserId}' order by {conUserPrjGrant.LastVisitedDate} desc");
            return  clsUserPrjGrantBL.GetFirstObj_S(sbCondition.ToString());
        }

        public static clsUserPrjGrantEN GetObjByCondition(string strUserId,
            string strPrjId)
        {
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("UserId='{0}'", strUserId);
            sbCondition.AppendFormat(" and PrjId='{0}'", strPrjId);
            return  clsUserPrjGrantBL.GetFirstObj_S(sbCondition.ToString());
        }
        //public bool GetUserPrjGrantForXml()
        //{
        //    string strCondition;
        //    System.Data.DataRow[] objDataRow;
        //    strCondition = " mId=" + mlngmId;
        //    objDataRow = clsSysParaEN.objSpecSqlForXml.GetDataRow(objViewInfoENEx.CurrTabName, strCondition);
        //    if (objDataRow.Length == 0)
        //    {
        //        objDataRow = null;
        //        return false;
        //    }
        //    mlngmId = Int32.Parse(objDataRow[0]["mId"].ToString().Trim());       //流水号
        //    mstrUserId = objDataRow[0]["UserId"].ToString().Trim();       //用户ID
        //    objViewInfoENEx.PrjId = objDataRow[0]["PrjId"].ToString().Trim();       //项目ID
        //    objViewInfoENEx.RoleId = objDataRow[0]["RoleId"].ToString().Trim();       //角色ID
        //    mintVisitedNum = TransNullToInt(objDataRow[0]["VisitedNum"].ToString().Trim());       //访问数
        //    objViewInfoENEx.OptId = objDataRow[0]["OptId"].ToString().Trim();       //操作者Id
        //    objViewInfoENEx.OptDate = objDataRow[0]["OptDate"].ToString().Trim();       //操作日期
        //    objViewInfoENEx.Memo = objDataRow[0]["Memo"].ToString().Trim();       //备注
        //    objDataRow = null;
        //    return true;
        //}
        /// <summary>
        /// 获取用户的登录信息
        /// </summary>
        /// <param name="lngMid"></param>
        /// <returns></returns>
        public static stuUserLoginInfo GetUserLoginInfo(long lngMid)
        {
            //long lngMid = long.Parse(strMid);
            stuUserLoginInfo objUserLoginInfo = new stuUserLoginInfo();
            clsvUserPrjGrantEN objUserPrjGrant = null;
            try
            {
                StringBuilder sbSql = new StringBuilder();
                sbSql.AppendFormat("Update {0} ", "UserPrjGrant");
                sbSql.AppendFormat(" Set VisitedNum = VisitedNum + 1, {1}='{2}' where Mid = {0} ",
                    lngMid,
                    conUserPrjGrant.LastVisitedDate,
                    clsDateTime.getTodayDateTimeStr(1));
                clsSpecSQLforSql objSql = new clsSpecSQLforSql();
                objSql.ExecSql(sbSql.ToString());
            }
            catch (Exception objException)
            {
                string strMsg = "修改访问次数不成功!\r\n" + objException.Message;
                throw new Exception(strMsg);
            }
            //clsPrjTabBLEx.arrPrjTabObjLst = null;
            //clsPrjTabBLEx.arrPrjViewObjLst = null;
            objUserPrjGrant = clsvUserPrjGrantBL.GetObjBymId(lngMid);

            new clsCommFun4BL4PrjTab().ReFreshCache(objUserPrjGrant.PrjId);

                    objUserLoginInfo.CurrSelPrjId = objUserPrjGrant.PrjId;
            objUserLoginInfo.CurrSelPrjName = objUserPrjGrant.PrjName;

            objUserLoginInfo.UserId = objUserPrjGrant.UserId;
            objUserLoginInfo.UserName = objUserPrjGrant.UserName;
    
            clsPubVar4BLEx.objLog4Error.WriteDebugLog(objUserLoginInfo.UserId);
            clsPubVar4BLEx.objLog4Error.WriteDebugLog(objUserLoginInfo.UserId + objUserLoginInfo.UserName);

            objUserLoginInfo.RoleId = objUserPrjGrant.RoleId;
            objUserLoginInfo.RoleName = objUserPrjGrant.RoleName;

            //设置默认的数据库
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objUserPrjGrant.PrjId);
            clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseEN = clsUserDefaPrjDataBaseBLEx.GetvUserDefaPrjDataBaseObjByPrjIdAndUserId(objUserLoginInfo.CurrSelPrjId,
                objUserLoginInfo.UserId);
            if (objvUserDefaPrjDataBaseEN != null)
            {
                objUserLoginInfo.CurrPrjDataBaseId = objvUserDefaPrjDataBaseEN.PrjDataBaseId;
                objUserLoginInfo.PrjDataBaseName = objvUserDefaPrjDataBaseEN.PrjDataBaseName;

                clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(objUserLoginInfo.CurrPrjDataBaseId);
                objUserLoginInfo.CurrDataBaseTypeId = objPrjDataBase.DataBaseTypeId;
                string strPrjDataBaseName;
                strPrjDataBaseName = objPrjDataBase.DataBaseName;
                objUserLoginInfo.PrjDataBaseName = strPrjDataBaseName;
            }
            else
            {
                string strDefaPrjDataBaseId = "";
                string strCondition = string.Format("PrjId='{0}'", objUserLoginInfo.CurrSelPrjId);
                clsProjectDatabaseRelEN objProjectDatabaseRelEN = clsProjectDatabaseRelBL.GetFirstObj_S(strCondition);
                if (objProjectDatabaseRelEN == null)
                {
                    string strMsg = string.Format("工程：{0}({1})没有设置相关数据库，请与管理员联系！", objProject.PrjName, objProject.PrjId);

                    throw new Exception(strMsg);
                }
                strDefaPrjDataBaseId = objProjectDatabaseRelEN.PrjDataBaseId;
                clsUserDefaPrjDataBaseBLEx.SetPrjDataBaseIdByPrjIdAndUserId(objUserLoginInfo.CurrSelPrjId, objUserLoginInfo.UserId, strDefaPrjDataBaseId);
                objUserLoginInfo.CurrPrjDataBaseId = strDefaPrjDataBaseId;
                clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(objUserLoginInfo.CurrPrjDataBaseId);
                objUserLoginInfo.CurrDataBaseTypeId = objPrjDataBase.DataBaseTypeId;
                string strPrjDataBaseName;
                strPrjDataBaseName = objPrjDataBase.DataBaseName;
                objUserLoginInfo.PrjDataBaseName = strPrjDataBaseName;
            }
            try
            {
                clsSqlViewBLEx.p_Set_InitLog4CreateView4Sql(objUserLoginInfo.CurrSelPrjId, objUserLoginInfo.CurrPrjDataBaseId, objUserLoginInfo.UserId);

                clsDataBaseModuleRelaBLEx.SetDefaDataBaseModuleRela(objProject.PrjId, objUserLoginInfo.CurrPrjDataBaseId, objUserLoginInfo.UserId);
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("wfmSelectProject", "dgUserPrjGrant_SelectedIndexChanged", objException.Message, objUserLoginInfo.UserId);
                throw objException;
            }
            //Response.Write("<script>alert('登陆成功！')</script>");
            //objUserPrjGrant.RoleId = objUserPrjGrant.RoleId;
            //Response.Redirect("../FrameSet.htm");  //在这里跳到自己工程的主框架界面

            //clsPubVar.objLog.WriteDebugLog(clsSysParaEN.getAllSysPara());
            //clsPubVar.objLog.WriteDebugLog(clsCommonSession.getAllCommonSession());
            return objUserLoginInfo;
        }

        public static stuUserLoginInfo GetUserLoginInfo(string strUserId, string strPrjId)
        {
            //long lngMid = long.Parse(strMid);
            stuUserLoginInfo objUserLoginInfo = new stuUserLoginInfo();
            clsvUserPrjGrantEN objUserPrjGrant = null;
            try
            {
                StringBuilder sbSql = new StringBuilder();
                sbSql.AppendFormat("Update {0} ", "UserPrjGrant");
                sbSql.Append($" Set VisitedNum = VisitedNum + 1, {conUserPrjGrant.LastVisitedDate}='{clsDateTime.getTodayDateTimeStr(1)}' where UserId = '{strUserId}' and PrjId= '{strPrjId}' "                    );
                clsSpecSQLforSql objSql = new clsSpecSQLforSql();
                objSql.ExecSql(sbSql.ToString());
            }
            catch (Exception objException)
            {
                string strMsg = "修改访问次数不成功!\r\n" + objException.Message;
                throw new Exception(strMsg);
            }
            //clsPrjTabBLEx.arrPrjTabObjLst = null;
            //clsPrjTabBLEx.arrPrjViewObjLst = null;
string strWhere = $" UserId = '{strUserId}' and PrjId= '{strPrjId}' ";

            objUserPrjGrant = clsvUserPrjGrantBL.GetFirstObj_S(strWhere);

            new clsCommFun4BL4PrjTab().ReFreshCache(objUserPrjGrant.PrjId);

            objUserLoginInfo.CurrSelPrjId = objUserPrjGrant.PrjId;
            objUserLoginInfo.CurrSelPrjName = objUserPrjGrant.PrjName;

            objUserLoginInfo.UserId = objUserPrjGrant.UserId;
            objUserLoginInfo.UserName = objUserPrjGrant.UserName;

            clsPubVar4BLEx.objLog4Error.WriteDebugLog(objUserLoginInfo.UserId);
            clsPubVar4BLEx.objLog4Error.WriteDebugLog(objUserLoginInfo.UserId + objUserLoginInfo.UserName);

            objUserLoginInfo.RoleId = objUserPrjGrant.RoleId;
            objUserLoginInfo.RoleName = objUserPrjGrant.RoleName;

            //设置默认的数据库
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objUserPrjGrant.PrjId);
            clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseEN = clsUserDefaPrjDataBaseBLEx.GetvUserDefaPrjDataBaseObjByPrjIdAndUserId(objUserLoginInfo.CurrSelPrjId,
                objUserLoginInfo.UserId);
            if (objvUserDefaPrjDataBaseEN != null)
            {
                objUserLoginInfo.CurrPrjDataBaseId = objvUserDefaPrjDataBaseEN.PrjDataBaseId;
                objUserLoginInfo.PrjDataBaseName = objvUserDefaPrjDataBaseEN.PrjDataBaseName;

                clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(objUserLoginInfo.CurrPrjDataBaseId);
                objUserLoginInfo.CurrDataBaseTypeId = objPrjDataBase.DataBaseTypeId;
                string strPrjDataBaseName;
                strPrjDataBaseName = objPrjDataBase.DataBaseName;
                objUserLoginInfo.PrjDataBaseName = strPrjDataBaseName;
            }
            else
            {
                string strDefaPrjDataBaseId = "";
                string strCondition = string.Format("PrjId='{0}'", objUserLoginInfo.CurrSelPrjId);
                clsProjectDatabaseRelEN objProjectDatabaseRelEN = clsProjectDatabaseRelBL.GetFirstObj_S(strCondition);
                if (objProjectDatabaseRelEN == null)
                {
                    string strMsg = string.Format("工程：{0}({1})没有设置相关数据库，请与管理员联系！", objProject.PrjName, objProject.PrjId);

                    throw new Exception(strMsg);
                }
                strDefaPrjDataBaseId = objProjectDatabaseRelEN.PrjDataBaseId;
                clsUserDefaPrjDataBaseBLEx.SetPrjDataBaseIdByPrjIdAndUserId(objUserLoginInfo.CurrSelPrjId, objUserLoginInfo.UserId, strDefaPrjDataBaseId);
                objUserLoginInfo.CurrPrjDataBaseId = strDefaPrjDataBaseId;
                clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(objUserLoginInfo.CurrPrjDataBaseId);
                objUserLoginInfo.CurrDataBaseTypeId = objPrjDataBase.DataBaseTypeId;
                string strPrjDataBaseName;
                strPrjDataBaseName = objPrjDataBase.DataBaseName;
                objUserLoginInfo.PrjDataBaseName = strPrjDataBaseName;
            }
            try
            {
                clsSqlViewBLEx.p_Set_InitLog4CreateView4Sql(objUserLoginInfo.CurrSelPrjId, objUserLoginInfo.CurrPrjDataBaseId, objUserLoginInfo.UserId);

                clsDataBaseModuleRelaBLEx.SetDefaDataBaseModuleRela(objProject.PrjId, objUserLoginInfo.CurrPrjDataBaseId, objUserLoginInfo.UserId);
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("wfmSelectProject", "dgUserPrjGrant_SelectedIndexChanged", objException.Message, objUserLoginInfo.UserId);
                throw objException;
            }
            //Response.Write("<script>alert('登陆成功！')</script>");
            //objUserPrjGrant.RoleId = objUserPrjGrant.RoleId;
            //Response.Redirect("../FrameSet.htm");  //在这里跳到自己工程的主框架界面

            //clsPubVar.objLog.WriteDebugLog(clsSysParaEN.getAllSysPara());
            //clsPubVar.objLog.WriteDebugLog(clsCommonSession.getAllCommonSession());
            return objUserLoginInfo;
        }

    }
}
