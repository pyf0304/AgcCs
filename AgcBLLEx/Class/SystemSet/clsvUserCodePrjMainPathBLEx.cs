
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvUserCodePrjMainPathBLEx
表名:vUserCodePrjMainPath
生成代码版本:2017.05.06.1
生成日期:2017/05/07
生成者:
工程名称:AGC
工程ID:0005
模块中文名:系统设置
模块英文名:SystemSet
框架-层名:业务逻辑扩展层
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.05.05.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2016.12.13.01
== == == == == == == == == == == == 
*/
using AGC.BusinessLogic;
using AGC.DAL;
using AGC.Entity;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace AGC.BusinessLogicEx
{
    /// <summary>
    /// vUserCodePrjMainPath(vUserCodePrjMainPath)
    /// 数据源类型:SQL视图
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsvUserCodePrjMainPathBLEx : clsvUserCodePrjMainPathBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsvUserCodePrjMainPathDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsvUserCodePrjMainPathDAEx vUserCodePrjMainPathDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsvUserCodePrjMainPathDAEx();
                }
                return uniqueInstanceEx;
            }
        }


        /// <summary>
        /// 绑定基于Win的下拉框
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_ComboBoxBindFunction)
        /// </summary>
        /// <param name = "objComboBox">需要绑定当前表的下拉框</param>
        /// <param name = "strUserId">strUserId</param>
        /// <param name = "strPrjId">strPrjId</param>
        public static void BindCbo_UserCodePrjMainPathIdByUserIdEx(System.Windows.Forms.ComboBox objComboBox, 
            string strUserId, string strPrjId)
        {
            //为数据源为表的下拉框设置内容
            string strCondition = string.Format("{5} = '1' And {0}= '{1}' And  {2}='{3}' Order By {4}",
                  convUserCodePrjMainPath.UserId, strUserId,
                    convUserCodePrjMainPath.PrjId, strPrjId,
                    convUserCodePrjMainPath.AppOrderNum,
                    convUserCodePrjMainPath.AppIsVisible);

            System.Data.DataTable objDT = clsvUserCodePrjMainPathBL.GetDataTable(strCondition);
            clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN;
            //初始化一个对象列表
            List<clsvUserCodePrjMainPathEN> vUserCodePrjMainPathList = new List<clsvUserCodePrjMainPathEN>();
            //插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
            objvUserCodePrjMainPathEN = new clsvUserCodePrjMainPathEN();
            objvUserCodePrjMainPathEN.UserCodePrjMainPathId = "0";
            objvUserCodePrjMainPathEN.ApplicationTypeName = "请选择...";
            vUserCodePrjMainPathList.Add(objvUserCodePrjMainPathEN);
            //把DataTable中的所有项均加到对象列表中
            foreach (DataRow objRow in objDT.Rows)
            {
                objvUserCodePrjMainPathEN = new clsvUserCodePrjMainPathEN();
                objvUserCodePrjMainPathEN.UserCodePrjMainPathId = objRow[convUserCodePrjMainPath.UserCodePrjMainPathId].ToString();
                objvUserCodePrjMainPathEN.ApplicationTypeName =
                    objRow[convUserCodePrjMainPath.PrjId].ToString() + 
                    objRow[convUserCodePrjMainPath.ApplicationTypeName].ToString();
                vUserCodePrjMainPathList.Add(objvUserCodePrjMainPathEN);
            }
            //vUserCodePrjMainPathList.Sort((x, y) => {
            //    return x.ApplicationTypeName.CompareTo(y.ApplicationTypeName);
            //});
            //设置下拉框的数据源、以及设置值项、显示项
            objComboBox.ValueMember = convUserCodePrjMainPath.UserCodePrjMainPathId;
            objComboBox.DisplayMember = convUserCodePrjMainPath.ApplicationTypeName;
            objComboBox.DataSource = vUserCodePrjMainPathList;
            objComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// 绑定基于Win的下拉框
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_ComboBoxBindFunction)
        /// </summary>
        /// <param name = "objComboBox">需要绑定当前表的下拉框</param>
//        public static void BindCbo_UserCodePrjMainPathIdByUserIdEx(System.Windows.Forms.ComboBox objComboBox,
//            string strUserId, string strPrjId)
//        {
//            //为数据源为表的下拉框设置内容
//            string strCondition = string.Format("1 =1 And {0}= '{1}' And  {2}='{3}' Order By {6}",
//   convUserCodePrjMainPath.UserId, strUserId,
//convUserCodePrjMainPath.PrjId, strPrjId,
//      convUserCodePrjMainPath.UserCodePrjMainPathId);

//            System.Data.DataTable objDT = clsvUserCodePrjMainPathBL.GetDataTable(strCondition);
//            clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN;
//            //初始化一个对象列表
//            ArrayList vUserCodePrjMainPathList = new ArrayList();
//            //插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
//            objvUserCodePrjMainPathEN = new clsvUserCodePrjMainPathEN();
//            objvUserCodePrjMainPathEN.UserCodePrjMainPathId = "0";
//            objvUserCodePrjMainPathEN.ApplicationTypeName = "请选择...";
//            vUserCodePrjMainPathList.Add(objvUserCodePrjMainPathEN);
//            //把DataTable中的所有项均加到对象列表中
//            foreach (DataRow objRow in objDT.Rows)
//            {
//                objvUserCodePrjMainPathEN = new clsvUserCodePrjMainPathEN();
//                objvUserCodePrjMainPathEN.UserCodePrjMainPathId = objRow[convUserCodePrjMainPath.UserCodePrjMainPathId].ToString();
//                objvUserCodePrjMainPathEN.ApplicationTypeName =
//                          objRow[convUserCodePrjMainPath.PrjId].ToString() +
//                          objRow[convUserCodePrjMainPath.ApplicationTypeName].ToString();
//                vUserCodePrjMainPathList.Add(objvUserCodePrjMainPathEN);
//            }
//            //设置下拉框的数据源、以及设置值项、显示项
//            objComboBox.ValueMember = convUserCodePrjMainPath.UserCodePrjMainPathId;
//            objComboBox.DisplayMember = convUserCodePrjMainPath.ApplicationTypeName;
//            objComboBox.DataSource = vUserCodePrjMainPathList;
//            objComboBox.SelectedIndex = 0;
//        }


        /// <summary>
        /// 绑定基于Win的下拉框
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_ComboBoxBindFunction)
        /// </summary>
        /// <param name = "objComboBox">需要绑定当前表的下拉框</param>
        public static void BindCbo_UserCodePrjMainPathIdByPrjIdEx(System.Windows.Forms.ComboBox objComboBox,
             string strPrjId)
        {
            //为数据源为表的下拉框设置内容
            string strCondition = string.Format("1 =1 And {0}= '{1}' Order By {2}",   
                convUserCodePrjMainPath.PrjId, strPrjId,
                convUserCodePrjMainPath.UserCodePrjMainPathId);

            System.Data.DataTable objDT = clsvUserCodePrjMainPathBL.GetDataTable(strCondition);
            clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN;
            //初始化一个对象列表
            ArrayList vUserCodePrjMainPathList = new ArrayList();
            //插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
            objvUserCodePrjMainPathEN = new clsvUserCodePrjMainPathEN();
            objvUserCodePrjMainPathEN.UserCodePrjMainPathId = "0";
            objvUserCodePrjMainPathEN.ApplicationTypeName = "请选择...";
            vUserCodePrjMainPathList.Add(objvUserCodePrjMainPathEN);
            //把DataTable中的所有项均加到对象列表中
            foreach (DataRow objRow in objDT.Rows)
            {
                objvUserCodePrjMainPathEN = new clsvUserCodePrjMainPathEN();
                objvUserCodePrjMainPathEN.UserCodePrjMainPathId = objRow[convUserCodePrjMainPath.UserCodePrjMainPathId].ToString();
                objvUserCodePrjMainPathEN.ApplicationTypeName =
                                   objRow[convUserCodePrjMainPath.PrjId].ToString() +
                                   objRow[convUserCodePrjMainPath.ApplicationTypeName].ToString();
                vUserCodePrjMainPathList.Add(objvUserCodePrjMainPathEN);
            }
            //设置下拉框的数据源、以及设置值项、显示项
            objComboBox.ValueMember = convUserCodePrjMainPath.UserCodePrjMainPathId;
            objComboBox.DisplayMember = convUserCodePrjMainPath.ApplicationTypeName;
            objComboBox.DataSource = vUserCodePrjMainPathList;
            objComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public static void BindDdl_UserCodePrjMainPathIdByUserIdEx(System.Web.UI.WebControls.DropDownList objDDL, 
            string strUserId, string strPrjId)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");
            string strCondition = string.Format("1 =1 And {0}= '{1}' And  {2}='{3}' Order By {4}",
convUserCodePrjMainPath.UserId, strUserId,
convUserCodePrjMainPath.PrjId, strPrjId,
convUserCodePrjMainPath.UserCodePrjMainPathId);
            System.Data.DataTable objDT = clsvUserCodePrjMainPathBL.GetDataTable(strCondition);
            objDDL.DataValueField = convUserCodePrjMainPath.UserCodePrjMainPathId;
            objDDL.DataTextField = convUserCodePrjMainPath.ApplicationTypeName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

    }
}