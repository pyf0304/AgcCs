using AGC.BusinessLogic;
using AGC.DAL;
using AGC.Entity;
using CommonTable.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGC.BusinessLogicEx
{
    public partial class clsCtlTypeAbbrBLEx : clsCtlTypeAbbrBL
    {
        public const string
        BUTTONTYPE = "01", //命令按钮
        CHECKBOXTYPE = "02", //检查框
        CHECKBOXLISTTYPE = "03", //检查框列表
        DATAGRIDTYPE = "04", //数据表格
        DATALISTTYPE = "05", //数据列表
        DROPDOWNLISTTYPE = "06", //下拉框
        HYPERLINKTYPE = "07", //超链接
        IMAGETYPE = "08", //图像框
        IMAGEBUTTONTYPE = "09", //图像按钮
        LABELTYPE = "10", //标签框
        LINKBUTTONTYPE = "11", //链接按钮
        LISTBOXTYPE = "12", //列表框
        PANELTYPE = "13", //面板框
        RADIOBUTTONTYPE = "14", //单选钮
        RADIOBUTTONLISTTYPE = "15", //单选钮列表
        TEXTBOXTYPE = "16", //文本框
        RADIOBUTTONBOOLTYPE = "17", //文本框
        DROPDOWNLISTBOOLTYPE = "18"; //文本框


        /// <summary>
        /// 获取相关对象列表, 从缓存的对象列表中获取.
        /// </summary>
        /// <returns>获取相关对象列表</returns>
        public static List<clsCtlTypeAbbrEN> GetCtlTypeAbbrObjLstForBindDdl()
        {
            List<clsCtlTypeAbbrEN> arrObjLst_Cache = clsCtlTypeAbbrBL.GetObjLst_Cache();
            return arrObjLst_Cache;
        }

        /// <summary>
        /// 获取控件Id
        /// </summary>
        /// <param name="strCtlTypeId"></param>
        /// <param name="strFldName"></param>
        /// <returns></returns>
        public static string GetCtrlId(string strCtlTypeId, string strFldName)
        {
            K_CtlTypeId_CtlTypeAbbr objKey = strCtlTypeId;
            clsCtlTypeAbbrEN objCtlTypeAbbrEN = objKey.GetObj();
            string mstrCtrlId = objCtlTypeAbbrEN.CtlTypeAbbr + strFldName;
            return mstrCtrlId;

        }
        /// <summary>
        /// 根据控件Id获取FldName(字段名)
        /// </summary>
        /// <param name="strCtrlId">控件Id</param>
        /// <returns>FldName(字段名)</returns>
        public static string GetFldNameByCtrlId(string strCtrlId)
        {
            List<clsCtlTypeAbbrEN> arrCtlTypeAbbr = GetObjLst_Cache();
            foreach(clsCtlTypeAbbrEN objInFor in arrCtlTypeAbbr)
            {
                if (strCtrlId.IndexOf(objInFor.CtlTypeAbbr) != 0) continue;
                string strFldName = strCtrlId.Replace(objInFor.CtlTypeAbbr, "").Replace("_q", "");
                return strFldName;
            }
            return "";
        }

        public static List<clsCtlTypeAbbrEN> arrCtlTypeAbbrObjLst = null;
        //public const string 
        //    BUTTONTYPE                              = "01", //命令按钮
        //    CHECKBOXTYPE                            = "02", //检查框
        //    CHECKBOXLISTTYPE                        = "03", //检查框列表
        //    DATAGRIDTYPE                            = "04", //数据表格
        //    DATALISTTYPE                            = "05", //数据列表
        //    DROPDOWNLISTTYPE                        = "06", //下拉框
        //    HYPERLINKTYPE                           = "07", //超链接
        //    IMAGETYPE                               = "08", //图像框
        //    IMAGEBUTTONTYPE                         = "09", //图像按钮
        //    LABELTYPE                               = "10", //标签框
        //    LINKBUTTONTYPE                          = "11", //链接按钮
        //    LISTBOXTYPE                             = "12", //列表框
        //    PANELTYPE                               = "13", //面板框
        //    RADIOBUTTONTYPE                         = "14", //单选钮
        //    RADIOBUTTONLISTTYPE                     = "15", //单选钮列表
        //    TEXTBOXTYPE                             = "16", //文本框
        //    RADIOBUTTONBOOLTYPE                     = "17", //文本框
        //    DROPDOWNLISTBOOLTYPE                    = "18"; //文本框





        //public static System.Data.DataTable GetCtlTypeId()
        //{
        //    //获取某学院所有专业信息
        //    string strSQL = "select CtlTypeId, CtlTypeName from CtlTypeAbbr ";
        //    clsSpecSQLforSql mySql = new 1clsSpecSQLforSql();
        //    System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
        //    return objDT;
        //}
        //public static void BindCbo_CtlTypeId(System.Windows.Forms.ComboBox objComboBox)
        //{
        //    //为数据源为表的下拉框设置内容
        //    System.Data.DataTable objDT = GetCtlTypeId();
        //    clsCtlTypeAbbrEN objCtlTypeAbbr;
        //    //初始化一个对象列表
        //    ArrayList CtlTypeAbbrList = new ArrayList();
        //    //插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
        //    objCtlTypeAbbr = new clsCtlTypeAbbrEN();
        //    objCtlTypeAbbr.CtlTypeId = "0";
        //    objCtlTypeAbbr.CtlTypeName = "请选择...";
        //    CtlTypeAbbrList.Add(objCtlTypeAbbr);
        //    //把DataTable中的所有项均加到对象列表中
        //    foreach(DataRow objRow in objDT.Rows)
        //    {
        //        objCtlTypeAbbr = new clsCtlTypeAbbrEN();
        //        objCtlTypeAbbr.CtlTypeId = objRow["CtlTypeId"].ToString();
        //        objCtlTypeAbbr.CtlTypeName = objRow["CtlTypeName"].ToString();
        //        CtlTypeAbbrList.Add(objCtlTypeAbbr);
        //    }
        //    //设置下拉框的数据源、以及设置值项、显示项
        //    objComboBox.DataSource = CtlTypeAbbrList;
        //    objComboBox.ValueMember = "CtlTypeId";
        //    objComboBox.DisplayMember = "CtlTypeName";
        //    objComboBox.SelectedIndex = 0;
        //}

        //public static void BindDdl_CtlTypeId(System.Web.UI.WebControls.DropDownList objDDL)
        //{
        //    //为数据源于表的下拉框设置内容
        //    System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...","0");
        //    System.Data.DataTable objDT = GetCtlTypeId();
        //    objDDL.DataValueField = "CtlTypeId";
        //    objDDL.DataTextField = "CtlTypeName";
        //    objDDL.DataSource = objDT;
        //    objDDL.DataBind();
        //    objDDL.Items.Insert(0, li);
        //    objDDL.SelectedIndex = 0;
        //}


        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name = "strCtlTypeId">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsCtlTypeAbbrEN GetCtlTypeAbbrObjByCtlTypeId(string strCtlTypeId)
        {
            if (arrCtlTypeAbbrObjLst == null)
            {
                arrCtlTypeAbbrObjLst = clsCtlTypeAbbrBL.GetObjLst("1 = 1");
            }
            foreach (clsCtlTypeAbbrEN objCtlTypeAbbr in arrCtlTypeAbbrObjLst)
            {
                if (objCtlTypeAbbr.CtlTypeId == strCtlTypeId)
                {
                    return objCtlTypeAbbr;
                }
            }
            return null;
        }
    }
}
