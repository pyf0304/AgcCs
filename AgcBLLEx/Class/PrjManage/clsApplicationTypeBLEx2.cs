
using AGC.BusinessLogic;
using AGC.DAL;
using AGC.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace AGC.BusinessLogicEx
{
    public partial class clsApplicationTypeBLEx
    {
        public const int
            WINDOWSAPP = 1, //命令按钮
            DOTNETWEBAPP = 2, //检查框
            AspMvcAPP = 13, //检查框
            JAVAWEBAPP = 3, //检查框列表
            ANDROIDAPP = 5; //检查框列表

        public static List<string> GetProgLangTypeIdLst(int intApplicationTypeId)
        {
            clsApplicationTypeEN objApplicationTypeEN = clsApplicationTypeBL.GetObjByApplicationTypeIdCache(intApplicationTypeId);
            List<string> arrProgLangTypeId = new List<string>();
            if (string.IsNullOrEmpty(objApplicationTypeEN.ProgLangTypeId) == false)
            {
                arrProgLangTypeId.Add(objApplicationTypeEN.ProgLangTypeId);
            }
            if (string.IsNullOrEmpty(objApplicationTypeEN.ProgLangTypeId2) == false)
            {
                arrProgLangTypeId.Add(objApplicationTypeEN.ProgLangTypeId2);
            }
            if (string.IsNullOrEmpty(objApplicationTypeEN.ProgLangTypeId3) == false)
            {
                arrProgLangTypeId.Add(objApplicationTypeEN.ProgLangTypeId3);
            }
            return arrProgLangTypeId;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public static void BindDdl_ApplicationTypeIdExCache(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择[应用程序类型]...", "0");
            //string strCondition = string.Format("{0} = '1' Order By {1},{2}",
            //    conApplicationType.IsVisible,
            //    conApplicationType.VisitedNum,
            //    conApplicationType.OrderNum);
            List<clsApplicationTypeEN> arrObjLst = clsApplicationTypeBL.GetObjLstCache()
                .Where(x=>x.IsVisible == true)
                .OrderBy(x=>x.VisitedNum)
                .ThenBy(x=>x.OrderNum)
                .ToList();

            objDDL.DataValueField = conApplicationType.ApplicationTypeId;
            objDDL.DataTextField = conApplicationType.ApplicationTypeName;
            objDDL.DataSource = arrObjLst;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        /// <summary>
        /// 绑定基于Win的下拉框
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_ComboBoxBindFunction)
        /// </summary>
        /// <param name = "objComboBox">需要绑定当前表的下拉框</param>
        public static void BindCbo_ApplicationTypeIdEx(System.Windows.Forms.ComboBox objComboBox)
        {
            //为数据源为表的下拉框设置内容
            string strCondition = string.Format("{0} = '1' Order By {1}", conApplicationType.IsVisible, conApplicationType.OrderNum);
            System.Data.DataTable objDT = clsApplicationTypeBL.GetDataTable(strCondition);
            clsApplicationTypeEN objApplicationTypeEN;
            //初始化一个对象列表
            ArrayList ApplicationTypeList = new ArrayList();
            //插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
            objApplicationTypeEN = new clsApplicationTypeEN();
            objApplicationTypeEN.ApplicationTypeId = 0;
            objApplicationTypeEN.ApplicationTypeName = "请选择...";
            ApplicationTypeList.Add(objApplicationTypeEN);
            //把DataTable中的所有项均加到对象列表中
            foreach (DataRow objRow in objDT.Rows)
            {
                objApplicationTypeEN = new clsApplicationTypeEN();
                objApplicationTypeEN.ApplicationTypeId = int.Parse(objRow[conApplicationType.ApplicationTypeId].ToString());
                objApplicationTypeEN.ApplicationTypeName = objRow[conApplicationType.ApplicationTypeName].ToString();
                ApplicationTypeList.Add(objApplicationTypeEN);
            }
            //设置下拉框的数据源、以及设置值项、显示项
            objComboBox.ValueMember = conApplicationType.ApplicationTypeId;
            objComboBox.DisplayMember = conApplicationType.ApplicationTypeName;
            objComboBox.DataSource = ApplicationTypeList;
            objComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// 获取最大访问次数的AppTypeId
        /// </summary>
        /// <returns></returns>
        public static int GetAppTypeIdByMaxVisitedNum()
        {
            string strCondition = string.Format("{0} = '1' Order By {1},{2}",
    conApplicationType.IsVisible,
    conApplicationType.VisitedNum,
    conApplicationType.OrderNum);
            List<clsApplicationTypeEN> arrObjLst = clsApplicationTypeBL.GetObjLst(strCondition).OrderByDescending(x => x.VisitedNum).ToList();
            return arrObjLst[0].ApplicationTypeId;
        }

        ///生成绑定ListView的代码
        /// <summary>
        /// 函数功能:根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在ListView中。
        /// </summary>
        public static int BindLv_ApplicationType(System.Windows.Forms.ListView lvApplicationType, string strWhereCond)
        {
            //操作步骤:(共4步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	3、设置ListView的列头信息
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            //		在本界面中是把状态显示在控件lblRecCount中。

            System.Windows.Forms.ListViewItem lviApplicationType;
            List<clsApplicationTypeEN> arrApplicationTypeObjList;
            //	2、根据条件串获取该表满足条件的DataTable；
            arrApplicationTypeObjList = clsApplicationTypeBL.GetObjLst(strWhereCond);
            //	3、设置ListView的列头信息
            lvApplicationType.Items.Clear();//清除原来所有Item
            lvApplicationType.Columns.Clear();//清除原来所有列头信息
            lvApplicationType.Columns.Add("应用程序类型ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvApplicationType.Columns.Add("应用程序类型名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvApplicationType.Columns.Add("说明", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvApplicationType.View = System.Windows.Forms.View.Details;
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            foreach (clsApplicationTypeEN objApplicationType in arrApplicationTypeObjList)
            {
                lviApplicationType = new System.Windows.Forms.ListViewItem();
                lviApplicationType.Tag = objApplicationType.ApplicationTypeId;
                lviApplicationType.Text = objApplicationType.ApplicationTypeId.ToString("00");
                lviApplicationType.SubItems.Add(objApplicationType.ApplicationTypeName);
                lviApplicationType.SubItems.Add(objApplicationType.Memo);
                lvApplicationType.Items.Add(lviApplicationType);
            }
            //	4、设置记录数的状态,
            //		在本界面中是把状态显示在控件txtRecCount中。
            return arrApplicationTypeObjList.Count;
        }

        public static bool GoTop(List<string> arrKeyId)
        {
            try
            {
                bool bolResult = new clsApplicationTypeDAEx().GoTop(arrKeyId);
                bolResult = new clsApplicationTypeDAEx().ReOrder();

                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("置顶出错!\r\n" + objException.Message);
            }
        }

        public static bool GoBottom(List<string> arrKeyId)
        {
            try
            {
                bool bolResult = new clsApplicationTypeDAEx().GoBottom(arrKeyId);
                bolResult = new clsApplicationTypeDAEx().ReOrder();
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("置底出错!\r\n" + objException.Message);
            }
        }

        public static bool AdjustSequenceNumber(string strDirect, int intApplicationTypeId)
        {
            try
            {
                bool bolResult = new clsApplicationTypeDAEx().AdjustSequenceNumber(strDirect, intApplicationTypeId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("调整记录次序出错!\r\n" + objException.Message);
            }
        }
        public static bool ReOrder()
        {
            try
            {
                bool bolResult = new clsApplicationTypeDAEx().ReOrder();
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("重新调整所有记录次序出错!\r\n" + objException.Message);
            }

        }

        /// <summary>
        /// 递增访问次数
        /// </summary>
        /// <param name="intApplicationTypeId"></param>
        public static void IncreaseVisitedNum(int intApplicationTypeId)
        {
            clsApplicationTypeEN obj = clsApplicationTypeBL.GetObjByApplicationTypeId(intApplicationTypeId);
            obj.VisitedNum++;
            obj.Update();
        }
    }
}
