using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using AGC.DAL;
using AGC.Entity;

using System.Data;
using System.Web.UI.WebControls;
using AGC.BusinessLogic;
using com.taishsoft.commdb;

namespace AGC.BusinessLogicEx
{

    public static class clsFuncModule_AgcBLEx_Static
    {
        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// </summary>
        /// <param name = "objFuncModule_AgcEN">源对象</param>   
        public static string FuncModuleEnName4GC(this clsFuncModule_AgcEN objFuncModule_AgcEN)
        {
            string strFuncModuleEnName4GC = objFuncModule_AgcEN.FuncModuleEnName;
            return strFuncModuleEnName4GC;
        }
    }
    public partial class clsFuncModule_AgcBLEx : clsFuncModule_AgcBL
    {
        public new static bool GoTop(List<string> arrKeyId, string strPrjId)
        {
            try
            {
                bool bolResult = new clsFuncModuleDAEx().GoTop(arrKeyId);
                bolResult = new clsFuncModuleDAEx().ReOrder(strPrjId);

                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("置顶出错!\r\n" + objException.Message);
            }
        }

        public new static bool GoBottom(List<string> arrKeyId, string strPrjId)
        {
            try
            {
                bool bolResult = new clsFuncModuleDAEx().GoBottom(arrKeyId);
                bolResult = new clsFuncModuleDAEx().ReOrder(strPrjId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("置底出错!\r\n" + objException.Message);
            }
        }

        public static bool AdjustSequenceNumber(string strDirect, string strFuncModuleId)
        {
            try
            {
                bool bolResult = new clsFuncModuleDAEx().AdjustSequenceNumber(strDirect, strFuncModuleId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("调整记录次序出错!\r\n" + objException.Message);
            }
        }
        public new static bool ReOrder(string strPrjId)
        {
            try
            {
                bool bolResult = new clsFuncModuleDAEx().ReOrder(strPrjId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("重新调整所有记录次序出错!\r\n" + objException.Message);
            }

        }

        public static void BindCbo_FuncModuleId(System.Windows.Forms.ComboBox objComboBox, string strPrjId)
        {
            //为数据源为表的下拉框设置内容
            string strCondition = string.Format("PrjId = '{0}' And UseStateId = '0001' Order by FuncModuleName", strPrjId);
            System.Data.DataTable objDT = new clsFuncModule_AgcDA().GetDataTable_FuncModule_Agc(strCondition);
            clsFuncModule_AgcEN objFuncModuleEN;
            //初始化一个对象列表
            ArrayList FuncModuleList = new ArrayList();
            //插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
            objFuncModuleEN = new clsFuncModule_AgcEN();
            objFuncModuleEN.FuncModuleAgcId = "0";
            objFuncModuleEN.FuncModuleName = "请选择...";
            FuncModuleList.Add(objFuncModuleEN);
            //把DataTable中的所有项均加到对象列表中
            foreach (DataRow objRow in objDT.Rows)
            {
                objFuncModuleEN = new clsFuncModule_AgcEN();
                objFuncModuleEN.FuncModuleAgcId = objRow["FuncModuleAgcId"].ToString();
                objFuncModuleEN.FuncModuleName = objRow["FuncModuleName"].ToString();
                FuncModuleList.Add(objFuncModuleEN);
            }
            //设置下拉框的数据源、以及设置值项、显示项
            objComboBox.DataSource = FuncModuleList;
            objComboBox.ValueMember = "FuncModuleAgcId";
            objComboBox.DisplayMember = "FuncModuleName";
            objComboBox.SelectedIndex = 0;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="objDDL"></param>
        /// <param name="strPrjId"></param>
        public static void BindDdl_FuncModuleIdExCache(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            string strCondition = string.Format("PrjId = '{0}' And UseStateId = '0001' Order by FuncModuleName", strPrjId);
            IEnumerable<clsFuncModule_AgcEN> arrObjLst = clsFuncModule_AgcBL.GetObjLstCache(strPrjId)
                .OrderBy(x => x.FuncModuleName);

            objDDL.DataValueField = "FuncModuleAgcId";
            objDDL.DataTextField = "FuncModuleName";
            objDDL.DataSource = arrObjLst;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }


        /// <summary>
        /// 获取当前表满足条件的第一条记录的关键字值
        /// </summary>
        /// <param name = "strPrjId">strPrjId</param>
        /// <returns>返回的第一条记录的关键字值</returns>
        public static string GetMaxStrIdEx_S(string strPrjId)
        {
            string strMaxFuncModuleId;
            try
            {
                strMaxFuncModuleId = clsFuncModuleDAEx.GetMaxStrIdEx(strPrjId);
                return strMaxFuncModuleId;
            }
            catch (Exception objException)
            {
                throw new Exception("获取First关键字出错!\r\n" + objException.Message);
            }
        }



        //public static System.Data.DataTable GetFuncModuleId(string strCurrSelPrjId, string strPrjDataBaseId)
        //{
        //    //获取某学院所有专业信息
        //    string strSQL = string.Format("select FuncModuleAgcId, FuncModuleName from FuncModule_Agc where UseStateId='0001' And PrjId ='{0}'", strCurrSelPrjId);
        //    strSQL += string.Format(" And FuncModuleAgcId in (Select FuncModuleAgcId From DataBaseModuleRela where PrjId='{0}' And PrjDataBaseId='{1}' And IsVisible='1')",
        //        strCurrSelPrjId, strPrjDataBaseId);
        //    strSQL += " Order by FuncModuleName";
        //    clsSpecSQLforSql mySql = new clsSpecSQLforSql();
        //    System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
        //    return objDT;
        //}

        public static void BindDdl_FuncModuleId(System.Web.UI.WebControls.DropDownList objDDL, string strCurrSelPrjId, string strPrjDataBaseId)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            //            System.Data.DataTable objDT = GetFuncModuleId(strCurrSelPrjId, strPrjDataBaseId);
            List<clsFuncModule_AgcEN> arrFuncModule_AgcObjLst_Sel = GetAllFuncModule_AgcObjLstCacheEx(strCurrSelPrjId, strPrjDataBaseId);
            objDDL.DataValueField = "FuncModuleAgcId";
            objDDL.DataTextField = "FuncModuleName";
            objDDL.DataSource = arrFuncModule_AgcObjLst_Sel;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }


        /// <summary>
        /// 从缓存中获取所有正在使用的工程对象列表.
        /// </summary>
        /// <returns>从缓存中获取所有正在使用的工程对象列表</returns>
        public static List<clsFuncModule_AgcEN> GetAllFuncModule_AgcObjLstCacheEx(string strPrjId, string strPrjDataBaseId)
        {
            List<string> arrFuncModuleAgcIdLst = clsDataBaseModuleRelaBLEx.GetAllFuncModuleAgcIdLstCacheEx(strPrjDataBaseId, strPrjId);

            //string strWhereCond = string.Format("1 = 1 order by {0}", clsFuncModule_AgcEN.con_FuncModuleName);
            //if (clsFuncModule_AgcBL.arrFuncModule_AgcObjLstCache == null)
            //{
            //    clsFuncModule_AgcBL.arrFuncModule_AgcObjLstCache = new clsFuncModule_AgcDA().GetObjLst(strWhereCond);
            //}
            List<clsFuncModule_AgcEN> arrObjLstCache = clsFuncModule_AgcBL.GetObjLstCache(strPrjId);

            IEnumerable<clsFuncModule_AgcEN> arrFuncModule_AgcObjLst_Sel1 =
                from objFuncModule_AgcEN in arrObjLstCache
                where objFuncModule_AgcEN.PrjId == strPrjId
                && objFuncModule_AgcEN.UseStateId == "0001"
                 && arrFuncModuleAgcIdLst.Contains(objFuncModule_AgcEN.FuncModuleAgcId) == true
                select objFuncModule_AgcEN;


            List<clsFuncModule_AgcEN> arrFuncModule_AgcObjLst_Sel = new List<clsFuncModule_AgcEN>();
            foreach (clsFuncModule_AgcEN obj in arrFuncModule_AgcObjLst_Sel1)
            {
                arrFuncModule_AgcObjLst_Sel.Add(obj);
            }

            return arrFuncModule_AgcObjLst_Sel;
        }


    }
}
