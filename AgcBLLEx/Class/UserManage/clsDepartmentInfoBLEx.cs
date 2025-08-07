using AGC.BusinessLogic;
using AGC.DAL;
using AGC.Entity;
using com.taishsoft.commdb;

using GeneralPlatform.Entity;
using GeneralPlatform4WApi;
using GP4WApi;
using SpecData;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI.WebControls;

namespace AGC.BusinessLogicEx
{
    public class clsDepartmentInfoBLEx: clsDepartmentInfoBL
    {
        public static System.Data.DataTable GetDepartmentId()
        {
            //获取某学院所有专业信息
            string strSQL = string.Format("select {1}, {2} from {0} where {3}='1' order by {2} ",
               clsDepartmentInfoEN._CurrTabName,
               conDepartmentInfo.DepartmentId,
               conDepartmentInfo.DepartmentName,
               conDepartmentInfo.InUse);
            clsSpecSQL mySql = new clsSpecSQL();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        ///绑定下拉框的函数代码
        public static void BindDdl_DepartmentIdEx(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetDepartmentId();
            objDDL.DataValueField = conDepartmentInfo.DepartmentId;
            objDDL.DataTextField = conDepartmentInfo.DepartmentName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        /// <summary>
        /// 把本地的学院Id(DepartmentId)转换为平台上的部门Id(DepartmentId)
        /// </summary>
        /// <param name="strDepartmentId">学院Id</param>
        /// <returns>统一平台上部门Id(DepartmentId)</returns>
        public static string GetDepartmentIdInGPByLocalId(string strDepartmentId)
        {
            string strDepartmentName = GetDepartmentNameByDepartmentId(strDepartmentId);
            if (string.IsNullOrEmpty(strDepartmentName) == true) return "";
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("DepartmentName='{0}'", strDepartmentName);
            List<clsQxDepartmentInfoEN> arrDepartmentInfoObjLst
                = clsQxDepartmentInfoWApi.GetObjLst(sbCondition.ToString());
            if (arrDepartmentInfoObjLst.Count == 0) return "";
            clsQxDepartmentInfoEN objDepartmentInfo4Plat = arrDepartmentInfoObjLst[0] as clsQxDepartmentInfoEN;
            return objDepartmentInfo4Plat.DepartmentId;
        }
        /// <summary>
        /// 根据学院Id获取学院名称
        /// </summary>
        /// <param name="strDepartmentId">学院Id</param>
        /// <returns></returns>
        public static string GetDepartmentNameByDepartmentId(string strDepartmentId)
        {
            clsDepartmentInfoEN objDepartmentInfoobj = clsDepartmentInfoBLEx.GetDepartmentInfoObjBDepartmentIdCache(strDepartmentId);
            if (objDepartmentInfoobj == null) return "";
            return objDepartmentInfoobj.DepartmentName;
        }
        /// <summary>
        /// 同步本地的一个部门到用户权限统一平台
        /// </summary>
        /// <param name="objDepartmentInfo4Local"></param>
        /// <returns></returns>
        public static bool SynchDepartmentToPlatform(clsDepartmentInfoEN objCollege4Local)
        {

            string strCurrDate = clsDateTime_Db.GetDataBaseDate8();
            clsQxDepartmentInfoEN objDepartmentInfo4Plat
                = new clsQxDepartmentInfoEN();
            objDepartmentInfo4Plat.DepartmentId = objCollege4Local.DepartmentId;
            objDepartmentInfo4Plat.DepartmentName = objCollege4Local.DepartmentName;
            //objDepartmentInfo4Plat.DepartmentId4Card = objCollege4Local.DepartmentId;
            objDepartmentInfo4Plat.DepartmentTypeId = ""; //objCollege4Local.DepartmentTypeId;
            //objDepartmentInfo4Plat.IsAcademy = true;// objCollege4Local.IsAcademy; ;
            objDepartmentInfo4Plat.OrderNum = objCollege4Local.OrderNum ?? 0;
            objDepartmentInfo4Plat.InUse = true;

            //objDepartmentInfo4Plat.SubjectTypeId = ""; //objCollege4Local.SubjectTypeId;
            objDepartmentInfo4Plat.UpDepartmentId = ""; //objCollege4Local.UpDepartmentId;
            objDepartmentInfo4Plat.Memo = "由教育高地平台导入到统一平台:" + strCurrDate;
            if (clsQxDepartmentInfoWApi.IsExist(objCollege4Local.DepartmentId) == false)
            {
                clsQxDepartmentInfoWApi.AddNewRecord(objDepartmentInfo4Plat);
            }
            else
            {
                clsQxDepartmentInfoWApi.UpdateRecord(objDepartmentInfo4Plat);

            }
            objCollege4Local.Memo = "已经同步到统一平台：" + strCurrDate;
            clsDepartmentInfoBL.UpdateBySql2(objCollege4Local);
            return true;
        }
        /// <summary>
        /// 根据学院名获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name="strid_College">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsDepartmentInfoEN GetDepartmentInfoObjBDepartmentNameCache(string strDepartmentName)
        {
            List<clsDepartmentInfoEN> arrObjLstCache = clsDepartmentInfoBL.GetObjLstCache();
                     
            foreach (clsDepartmentInfoEN objCollegeEN in arrObjLstCache)
            {
                if (objCollegeEN.DepartmentName == strDepartmentName)
                {
                    return objCollegeEN;
                }
            }
            return null;
        }


        /// <summary>
        /// 根据学院名获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name="strid_College">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsDepartmentInfoEN GetDepartmentInfoObjBDepartmentIdCache(string strDepartmentId)
        {
            List<clsDepartmentInfoEN> arrObjLstCache = clsDepartmentInfoBL.GetObjLstCache();

            foreach (clsDepartmentInfoEN objCollegeEN in arrObjLstCache)
            {
                if (objCollegeEN.DepartmentId == strDepartmentId)
                {
                    return objCollegeEN;
                }
            }
            return null;
        }
        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name="strid_College">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsDepartmentInfoEN GetDepartmentInfoObjByDepartmentName(string strDepartmentName)
        {
            List<clsDepartmentInfoEN> arrObjLstCache = clsDepartmentInfoBL.GetObjLstCache();

            foreach (clsDepartmentInfoEN objCollegeEN in arrObjLstCache)
            {
                if (objCollegeEN.DepartmentName.Equals(strDepartmentName, StringComparison.CurrentCultureIgnoreCase) == true)
                {
                    return objCollegeEN;
                }
            }
            return null;
        }


        public static bool Bindtv_Departments(TreeView objTV)
        {

            TreeNode tnRoot, tnDepartment;
            List<clsDepartmentInfoEN> arrDepartmentObjList = clsDepartmentInfoBL.GetObjLst(" InUse='1' order by OrderNum ");
            tnRoot = new TreeNode();
            tnRoot.Value = "root,root";
            tnRoot.Text = Entity.clsSysParaEN.strCompanyName;
            //			tnRoot.CheckBox=true;
            objTV.Nodes.Add(tnRoot);
            foreach (clsDepartmentInfoEN objDepartments in arrDepartmentObjList)
            {
                tnDepartment = new TreeNode();
                tnDepartment.Value = "Departments," + objDepartments.DepartmentId;
                tnDepartment.Text = objDepartments.DepartmentName + "(" + objDepartments.DepartmentId + ")";
                //				tnDepartment.CheckBox = true;
                tnRoot.ChildNodes.Add(tnDepartment);
            }

            return true;

        }

        /// <summary>
        /// 判断当前表中是否存在给定关键字值的记录
        /// </summary>
        /// <param name="strUserId">给定的关键字值</param>
        /// <returns>返回是否存在?</returns>
        public static bool IsExistEx(string strDepartmentId, clsSpecSQLforSql objSQL)
        {

            if (objSQL.IsExistRecord(clsDepartmentInfoEN._CurrTabName, "DepartmentId=" + "'" + strDepartmentId + "'"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
   
        /// <summary>
        /// 功能：设置多条部门为可用
        /// </summary>
        /// <param name="lstKey">给定的关键字值列表</param>
        /// <returns>设置是否成功?</returns>
        public static bool SetInUse(List<string> lstKey)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsDepartmentInfoDA.GetSpecSQLObj();
            string strSQL;
            string strKeyList;
            if (lstKey.Count == 0) return true;
            strKeyList = "";
            for (int i = 0; i < lstKey.Count; i++)
            {
                if (i == 0) strKeyList = strKeyList + "'" + lstKey[i].ToString() + "'";
                else strKeyList += "," + "'" + lstKey[i].ToString() + "'";
            }
            strSQL = "";
            //删除DepartmentInfo本表中与当前对象有关的记录
            strSQL = strSQL + string.Format("Update DepartmentInfo Set {0}='1' where DepartmentId in (" + strKeyList + ")",
                conDepartmentInfo.InUse);
            return objSQL.ExecSql(strSQL);
        }
        /// <summary>
        /// 功能：设置多条部门为可用
        /// </summary>
        /// <param name="lstKey">给定的关键字值列表</param>
        /// <returns>设置是否成功?</returns>
        public static bool SetNotInUse(List<string> lstKey)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsDepartmentInfoDA.GetSpecSQLObj();
            string strSQL;
            string strKeyList;
            if (lstKey.Count == 0) return true;
            strKeyList = "";
            for (int i = 0; i < lstKey.Count; i++)
            {
                if (i == 0) strKeyList = strKeyList + "'" + lstKey[i].ToString() + "'";
                else strKeyList += "," + "'" + lstKey[i].ToString() + "'";
            }
            strSQL = "";
            //删除DepartmentInfo本表中与当前对象有关的记录
            strSQL = strSQL + string.Format("Update DepartmentInfo Set {0}='0' where DepartmentId in (" + strKeyList + ")",
                conDepartmentInfo.InUse);
            return objSQL.ExecSql(strSQL);
        }
        /// <summary>
        /// 把一组记录移到最顶部
        /// </summary>
        /// <param name="arrKeyId">一组记录（关键字列表）</param>
        /// <returns></returns>
        public static bool GoTop(List<string> arrKeyId)
        {
            try
            {
                bool bolResult = new clsDepartmentInfoDAEx().GoTop(arrKeyId);
                bolResult = new clsDepartmentInfoDAEx().ReOrder();

                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("置顶出错！\r\n" + objException.Message);
            }
        }
        /// <summary>
        /// 把当前记录移到最顶部，第一条
        /// </summary>
        /// <param name="strKeyId">需要移动的记录（关键字）</param>
        /// <returns></returns>
        public static bool GoTop(string strKeyId)
        {
            try
            {
                List<string> arrKeyId = new List<string>();
                arrKeyId.Add(strKeyId);
                bool bolResult = new clsDepartmentInfoDAEx().GoTop(arrKeyId);
                bolResult = new clsDepartmentInfoDAEx().ReOrder();

                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("置顶出错！\r\n" + objException.Message);
            }
        }
        /// <summary>
        /// 把一组记录移到最后
        /// </summary>
        /// <param name="arrKeyId">一组记录（关键字列表）</param>
        /// <returns></returns>
        public static bool GoBottom(List<string> arrKeyId)
        {
            try
            {
                bool bolResult = new clsDepartmentInfoDAEx().GoBottom(arrKeyId);
                bolResult = new clsDepartmentInfoDAEx().ReOrder();

                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("置底出错！\r\n" + objException.Message);
            }
        }
        /// <summary>
        /// 把当前记录移到最后一条
        /// </summary>
        /// <param name="strKeyId">需要移动的记录（关键字）</param>
        /// <returns></returns>
        public static bool GoBottom(string strKeyId)
        {
            try
            {
                List<string> arrKeyId = new List<string>();
                arrKeyId.Add(strKeyId);
                bool bolResult = new clsDepartmentInfoDAEx().GoBottom(arrKeyId);
                bolResult = new clsDepartmentInfoDAEx().ReOrder();
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("置底出错！\r\n" + objException.Message);
            }
        }

        /// <summary>
        /// 调整次序
        /// </summary>
        /// <param name="strDirect">方向</param>
        /// <param name="strDepartmentId">需要调整的记录关键字(部门Id)</param>
        /// <returns></returns>
        public static bool AdjustSequenceNumber(string strDirect, string strDepartmentId)
        {
            try
            {
                bool bolResult = new clsDepartmentInfoDAEx().AdjustSequenceNumber(strDirect, strDepartmentId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("调整记录次序出错！\r\n" + objException.Message);
            }
        }
        /// <summary>
        /// 重序
        /// </summary>
        /// <returns></returns>
        public static bool ReOrder()
        {
            try
            {
                bool bolResult = new clsDepartmentInfoDAEx().ReOrder();
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("重新调整所有记录次序出错！\r\n" + objException.Message);
            }

        }

    }
}
