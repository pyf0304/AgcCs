
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsFileResourceDA1
界面名:frmFileResource_QU_DGV(00050276)
生成代码版本:2020.05.09.1
生成日期:2020/05/10 00:56:41
生成者:
工程名称:AGC
工程ID:0005
相关数据库:tzar.tpddns.cn,19433AGC_CS12
PrjDataBaseId:0213
模块中文名:资源管理
模块英文名:ResourceMan
框架-层名:Win界面层_QD(WinViewCode_QD)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
     2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
//生成与表相关的控件控制层代码
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using com.taishsoft.util;
using CommFunc4Win;
//using com.taishsoft.commdb;
using com.taishsoft.common;

using AGC.Entity;
using AGC.BusinessLogic;
using AGC4WApi;
using AGC_CSWin;

namespace AGC
{
    /// <summary>
    ///		frmFileResource_QD_LV 的摘要说明。
    /// (AutoGCLib.WinViewCode_QD4CSharp:A_GenQueryDelAffitUpdInsRecCodeWithLV_NoContral_Net2005)
    /// </summary>
    public partial class frmFileResource_QD_LV : System.Windows.Forms.Form, IBindListView
    {
        //clsFileResourceEN objFileResourceEN = null;
        private System.Data.DataTable objDTFileResource = null;
        private clsListViewSorter objvFileResourceSorter;
        private int intLastSelectedvFileResourceColumIndex;
        public frmFileResource_QD_LV()
        {
            // 该调用是 Windows.Forms 窗体设计器所必需的。
            InitializeComponent();

            // TODO: 在 InitializeComponent 调用后添加任何初始化
            objvFileResourceSorter = new clsListViewSorter();
            //为ListViewItemSorter指定排序类
            this.lvvFileResource.ListViewItemSorter = objvFileResourceSorter;
            objvFileResourceSorter.SortOrder = SortOrder.Ascending;

        }
        private void frmFileResource_QD_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面
            //1、为下拉框设置数据源,绑定列表数据
            this.SetAllComboBox();
            BindLv_vFileResource();
            this.JudgebtnDelRec(); //用来判断删除按钮是否可用
            this.JudgebtnUpdate(); //用来判断修改按钮是否可用

        }
        /// <summary>
        /// 下拉框的绑定函数
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:Genfun_SetAllComboBox4Query)
        /// </summary>
        private void SetAllComboBox()
        {
            clsCMProjectExWApi.BindCbo_CmPrjIdCacheEx(this.cboCmPrjId, clsPubVar.CurrSelPrjId);
        }
        /// <summary>
        /// 查询区的控件属性
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:Genfun_ViewCtrlProperty4Query)
        /// </summary>
        public string FileDirName
        {
            get
            {
                return txtFileDirName.Text.Trim();
            }
            set
            {
                txtFileDirName.Text = value.ToString();
            }
        }

        /// <summary>
        /// 查询区的控件属性
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:Genfun_ViewCtrlProperty4Query)
        /// </summary>
        public string FileName
        {
            get
            {
                return txtFileName.Text.Trim();
            }
            set
            {
                txtFileName.Text = value.ToString();
            }
        }

        /// <summary>
        /// 查询区的控件属性
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:Genfun_ViewCtrlProperty4Query)
        /// </summary>
        public string Extension
        {
            get
            {
                return txtExtension.Text.Trim();
            }
            set
            {
                txtExtension.Text = value.ToString();
            }
        }

        /// <summary>
        /// 查询区的控件属性
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:Genfun_ViewCtrlProperty4Query)
        /// </summary>
        public string CmPrjId
        {
            get
            {
                if (cboCmPrjId.SelectedValue.ToString() == "0")
                    return "";
                return cboCmPrjId.SelectedValue.ToString();
            }
            set
            {
                if (value == "")
                {
                    cboCmPrjId.SelectedValue = "0";
                }
                else
                {
                    cboCmPrjId.SelectedValue = value;
                }
            }
        }

        /// <summary>
        /// 查询区的控件属性
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:Genfun_ViewCtrlProperty4Query)
        /// </summary>
        //public string CmPrjName
        //{
        //    get
        //    {
        //        return txtCmPrjName.Text.Trim();
        //    }
        //    set
        //    {
        //        txtCmPrjName.Text = value.ToString();
        //    }
        //}


        /// <summary>
        /// 清除用户自定义控件中，所有控件的值
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:Genfun_Clear4QryRegion)
        /// </summary>	
        public void Clear()
        {
            txtFileDirName.Text = "";
            txtFileName.Text = "";
            txtExtension.Text = "";
            cboCmPrjId.SelectedIndex = 0;
            //txtCmPrjName.Text = "";
        }
        /// <summary>
        /// 设置该控件在插入状态下的缺省值
        /// 一般规则:
        ///		1、如果是整型就默认为0；
        ///		2、如果是浮点型不默认为0.0；
        ///		3、如果是日期型就默认为当前的日期；
        ///		4、如果是位(bit)型就默认为false;
        ///		这些默认值可以再行修改
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:Genfun_SetDefaultValue4QryRegion)
        /// </summary>
        public void SetDefaultValue()
        {
            txtFileDirName.Text = "";
            txtFileName.Text = "";
            txtExtension.Text = "";
            cboCmPrjId.SelectedIndex = 0;
            //txtCmPrjName.Text = "";
        }
        /// <summary>
        /// 校验自定义控件中自子控件的类型数值是否是合法正确的。
        /// 一般规则:
        ///		1、首先校验类型:整型、浮点型、日期型等,
        ///			这些代码由自动生成代码帮助生成
        ///		2、校验最值,即最大值和最小值等
        ///			这些代码由自动生成代码帮助生成
        ///		这些生成内容可以修改
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:Genfun_IsValid)
        /// </summary>
        /// <returns></returns>
        public bool IsValid(ref string strResult)
        {
            return true;
        }
        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:GenCombineCondition)
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        public string CombineFileResourceCondition()
        {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            string strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            if (this.txtFileDirName.Text.Trim() != "")
            {
                strWhereCond += string.Format(" And {0} like '%{1}%'", convFileResource.FileDirName, this.txtFileDirName.Text.Trim());
            }
            if (this.txtFileName.Text.Trim() != "")
            {
                strWhereCond += string.Format(" And {0} like '%{1}%'", convFileResource.FileName, this.txtFileName.Text.Trim());
            }
            if (this.txtExtension.Text.Trim() != "")
            {
                strWhereCond += string.Format(" And {0} like '%{1}%'", convFileResource.Extension, this.txtExtension.Text.Trim());
            }
            if (this.cboCmPrjId.SelectedValue.ToString() != "" && this.cboCmPrjId.SelectedValue.ToString() != "0")
            {
                strWhereCond += string.Format(" And {0} = '{1}'", convFileResource.CmPrjId, this.cboCmPrjId.SelectedValue);
            }
            //if (this.txtCmPrjName.Text.Trim() != "")
            //{
            //    strWhereCond += string.Format(" And {0} like '%{1}%'", convFileResource.CmPrjName, this.txtCmPrjName.Text.Trim());
            //}
            return strWhereCond;
        }
        /// <summary>
        /// 函数功能:用来判断删除按钮是否可用。
        ///			 如果在LISTVIEW中选中记录就显示删除按钮,否则就不显示
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:gfunGenJudgebtnDelete)
        /// </summary>
        private void JudgebtnDelRec()
        {
            if (this.lvvFileResource.SelectedItems.Count >= 1)
            {
                this.btnDelRec.Enabled = true;
            }
            else
            {
                this.btnDelRec.Enabled = false;
            }
        }
        /// <summary>
        /// 函数功能:用来判断删除按钮是否可用。
        ///			 如果在LISTVIEW中选中记录就显示删除按钮,否则就不显示
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:gfunGenJudgebtnUpdate)
        /// </summary>
        private void JudgebtnUpdate()
        {
            if (this.lvvFileResource.SelectedItems.Count >= 1)
            {
                this.btnUpdate.Enabled = true;
            }
            else
            {
                this.btnUpdate.Enabled = false;
            }
        }
        /// <summary>
        /// 函数功能:根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在ListView中。
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:gfunGenBindListView)
        /// </summary>
        private void BindLv_vFileResource()
        {
            //操作步骤:(共4步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	3、设置ListView的列头信息
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            //		在本界面中是把状态显示在控件lblRecCount中。

            ListViewItem lvivFileResource;
            List<clsvFileResourceEN> arrvFileResourceObjLst;
            //	1、组合界面条件串；
            string strWhereCond = this.CombineFileResourceCondition();  // CombineFileResourceCondition();
                                                                        //	2、根据条件串获取该表满足条件的DataTable；
            try
            {
                arrvFileResourceObjLst = clsvFileResourceWApi.GetObjLst(strWhereCond);
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
                return;
            }
            //	3、设置ListView的列头信息
            this.lvvFileResource.Items.Clear();//清除原来所有Item
            this.lvvFileResource.Columns.Clear();//清除原来所有列头信息
            this.lvvFileResource.Columns.Add("流水", 100, HorizontalAlignment.Left);
            this.lvvFileResource.Columns.Add("文件目录名", 100, HorizontalAlignment.Left);
            this.lvvFileResource.Columns.Add("文件名", 100, HorizontalAlignment.Left);
            this.lvvFileResource.Columns.Add("扩展名", 100, HorizontalAlignment.Left);
            this.lvvFileResource.Columns.Add("文件长度", 100, HorizontalAlignment.Left);
            this.lvvFileResource.Columns.Add("文件类型", 100, HorizontalAlignment.Left);
            this.lvvFileResource.Columns.Add("建立时间", 100, HorizontalAlignment.Left);
            this.lvvFileResource.Columns.Add("修改日期", 100, HorizontalAlignment.Left);
            this.lvvFileResource.Columns.Add("是否在用", 100, HorizontalAlignment.Left);
            this.lvvFileResource.Columns.Add("CM工程名", 100, HorizontalAlignment.Left);
            this.lvvFileResource.Columns.Add("修改日期", 100, HorizontalAlignment.Left);
            this.lvvFileResource.Columns.Add("修改者", 100, HorizontalAlignment.Left);
            this.lvvFileResource.View = View.Details;
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            foreach (clsvFileResourceEN objvFileResourceEN in arrvFileResourceObjLst)
            {
                lvivFileResource = new ListViewItem();
                lvivFileResource.Tag = objvFileResourceEN.FileResourceID;
                lvivFileResource.Text = objvFileResourceEN.FileResourceID.ToString();
                lvivFileResource.SubItems.Add(objvFileResourceEN.FileDirName);
                lvivFileResource.SubItems.Add(objvFileResourceEN.FileName);
                lvivFileResource.SubItems.Add(objvFileResourceEN.Extension);
                lvivFileResource.SubItems.Add(objvFileResourceEN.FileLength.ToString());
                lvivFileResource.SubItems.Add(objvFileResourceEN.FileType);
                lvivFileResource.SubItems.Add(objvFileResourceEN.CreationTime);
                lvivFileResource.SubItems.Add(objvFileResourceEN.LastWriteTime);
                lvivFileResource.SubItems.Add(objvFileResourceEN.InUse.ToString());
                lvivFileResource.SubItems.Add(objvFileResourceEN.CmPrjName);
                lvivFileResource.SubItems.Add(objvFileResourceEN.UpdDate);
                lvivFileResource.SubItems.Add(objvFileResourceEN.UpdUser);
                this.lvvFileResource.Items.Add(lvivFileResource);
            }
            //	4、设置记录数的状态,
            //		在本界面中是把状态显示在控件txtRecCount中。
            this.lblRecNum.Text = "记录数:" + arrvFileResourceObjLst.Count.ToString();
        }
        private void btnQuery_Click(object sender, System.EventArgs e)
        {
            //把表记录的内容显示在ListView中
            BindLv_vFileResource();
        }
        /// <summary>
        /// 获取DataGrid中当前行的主键值
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:gfunGenGetCurrKey4DataGrid)
        /// </summary>
        /// <param name = "objDataGrid">所单击的DataGrid</param>
        /// <returns>当前行的主键值</returns>
        private long GetCurrKey(DataGrid objDataGrid)
        {
            int intCurrRow = objDataGrid.CurrentRowIndex;
            string strfileResourceID = objDTFileResource.Rows[intCurrRow]["FileResourceID"].ToString();
            long lngFileResourceID = long.Parse(strfileResourceID);
            return lngFileResourceID;
        }
        /// <summary>
        /// 获取ListView中当前行的主键值
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:gfunGenGetCurrKey4ListView)
        /// </summary>
        /// <param name = "ObjLstView">所单击的ListView</param>
        /// <returns>当前行的主键值</returns>
        private long GetCurrKey(ListView ObjLstView)
        {
            if (ObjLstView.SelectedItems.Count == 0)
            {
                return 0;
            }
            ListViewItem lviFileResource;
            lviFileResource = ObjLstView.SelectedItems[0];
            string strFileResourceId = lviFileResource.Tag.ToString();
            long lngFileResourceID = long.Parse(strFileResourceId);
            return lngFileResourceID;
        }
        /// <summary>
        /// 获取ListView所给项的主键值
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:gfunGenGetCurrKey4ListView)
        /// </summary>
        /// <param name = "ObjLstView">所单击的ListView项</param>
        /// <returns>当前行的主键值</returns>
        private long GetCurrKey(ListViewItem ObjLstViewItem)
        {
            string strFileResourceId = ObjLstViewItem.Tag.ToString();
            long lngFileResourceID = long.Parse(strFileResourceId);
            return lngFileResourceID;
        }
        private void lvvFileResource_Click(object sender, System.EventArgs e)
        {
            this.JudgebtnDelRec(); //用来判断删除按钮是否可用
            this.JudgebtnUpdate(); //用来判断修改按钮是否可用
        }
        /// <summary>
        /// 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
        ///      具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:Gen_btnUpdate_Click)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            UpdateFileResourceRecord();
        }
        /// <summary>
        /// 函数功能:事件函数,当单击<添加>时发生的事件函数,
        ///      具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:Gen_btnAdd_Click)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            frmFileResource_UI frm = new frmFileResource_UI();
            frm.iBindListView = this;
            frm.OperateType = "Add";
            frm.ShowDialog();
        }
        private void btnDelRec_Click(object sender, System.EventArgs e)
        {
            DeleteFileResourceRecord();
        }
        private void btnExportExcel4Dg_Click(object sender, System.EventArgs e)
        {
            ExportExcel_SelColumns();   //新的导出EXCEL方式,用户可以选择导出字段列
                                        //ExportExcel();	//原来的方式导出EXCEL,用户不能选择导出字段列
        }
        /// <summary>
        /// 导出EXCEL的函数
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:gfunGenExportExcel)
        /// </summary>
        private void ExportExcel()
        {
            //	1、组合界面条件串；
            string strWhereCond = this.CombineFileResourceCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            List<clsFileResourceEN> objDT = clsFileResourceWApi.GetObjLst(strWhereCond);
            ArrayList arrCnName = new ArrayList();
            ArrayList arrColName = new ArrayList();
            //string strFileName = string.Format("v文件资源导出{0}.xls", clsDateTime.GetToday2(0));
            //string strFolderName;
            string strDownLoadFileName;
            arrColName.Add(convFileResource.FileDirName); arrCnName.Add("文件目录名");
            arrColName.Add(convFileResource.FileName); arrCnName.Add("文件名");
            arrColName.Add(convFileResource.Extension); arrCnName.Add("扩展名");
            arrColName.Add(convFileResource.FileLength); arrCnName.Add("文件长度");
            arrColName.Add(convFileResource.FileType); arrCnName.Add("文件类型");
            arrColName.Add(convFileResource.CreationTime); arrCnName.Add("建立时间");
            arrColName.Add(convFileResource.LastWriteTime); arrCnName.Add("修改日期");
            arrColName.Add(convFileResource.InUse); arrCnName.Add("是否在用");
            arrColName.Add(convFileResource.IsExistFile); arrCnName.Add("是否存在文件");
            arrColName.Add(convFileResource.PrjName); arrCnName.Add("工程名称");
            arrColName.Add(convFileResource.CmPrjName); arrCnName.Add("CM工程名");
            arrColName.Add(convFileResource.UpdDate); arrCnName.Add("修改日期");
            arrColName.Add(convFileResource.UpdUser); arrCnName.Add("修改者");
            arrColName.Add(convFileResource.Memo); arrCnName.Add("说明");
            //strFolderName = Application.StartupPath + "\\TempFiles";
            //if (Directory.Exists(strFolderName) == false)
            //{
            //Directory.CreateDirectory(strFolderName);
            //}
            //strDownLoadFileName = strFolderName + "\\" + strFileName;
            System.Windows.Forms.SaveFileDialog objSaveFileDialog = new SaveFileDialog();
            objSaveFileDialog.DefaultExt = "xls";
            objSaveFileDialog.Filter = "Excle文件(*.xls)|*.xls|所有文件(*.*)|*.*";
            objSaveFileDialog.ShowDialog();
            strDownLoadFileName = objSaveFileDialog.FileName;
            if (strDownLoadFileName == "")
            {
                return;
            }
            GetExcelFromDataTable.clsGetExcelFromDataTable objExcel = new GetExcelFromDataTable.clsGetExcelFromDataTable();
            //objExcel.GetExcelFromDataTableByArrAndArray(objDT, arrColName, arrCnName, strDownLoadFileName);
            MessageBox.Show("导出Excel成功!,文件存放在:" + strDownLoadFileName);
        }
        /// <summary>
        /// 导出EXCEL的函数, 导出EXCEL时可以选择列
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:gfunGenExportExcel_SelColumns)
        /// </summary>
        private void ExportExcel_SelColumns()
        {
            //	1、组合界面条件串；
            string strWhereCond = this.CombineFileResourceCondition();
            //	2、设置表列数据字段名,以及表列标题
            ArrayList arrCnName = new ArrayList();
            ArrayList arrColName = new ArrayList();
            arrColName.Add(convFileResource.FileDirName); arrCnName.Add("文件目录名");
            arrColName.Add(convFileResource.FileName); arrCnName.Add("文件名");
            arrColName.Add(convFileResource.Extension); arrCnName.Add("扩展名");
            arrColName.Add(convFileResource.FileLength); arrCnName.Add("文件长度");
            arrColName.Add(convFileResource.FileType); arrCnName.Add("文件类型");
            arrColName.Add(convFileResource.CreationTime); arrCnName.Add("建立时间");
            arrColName.Add(convFileResource.LastWriteTime); arrCnName.Add("修改日期");
            arrColName.Add(convFileResource.InUse); arrCnName.Add("是否在用");
            arrColName.Add(convFileResource.IsExistFile); arrCnName.Add("是否存在文件");
            arrColName.Add(convFileResource.PrjName); arrCnName.Add("工程名称");
            arrColName.Add(convFileResource.CmPrjName); arrCnName.Add("CM工程名");
            arrColName.Add(convFileResource.UpdDate); arrCnName.Add("修改日期");
            arrColName.Add(convFileResource.UpdUser); arrCnName.Add("修改者");
            arrColName.Add(convFileResource.Memo); arrCnName.Add("说明");
            ArrayList arrExportExcelList = new ArrayList();
            clsExportField objExportField = null;
            int intColNum = arrColName.Count;
            for (int i = 0; i < intColNum; i++)
            {
                objExportField = new clsExportField();
                objExportField.FieldEnglishName = arrColName[i].ToString();
                objExportField.FieldChineseName = arrCnName[i].ToString();
                arrExportExcelList.Add(objExportField);
            }
            /// 3、调用公用的导出EXCEL的界面,选择列后再导出
            frmExportExcel frm1 = new frmExportExcel();
            frm1.arrExportExcelList = arrExportExcelList;
            frm1.strTableName = "vFileResource";
            frm1.strTableChineseName = "v文件资源";
            frm1.strViewName = "文件资源-维护";
            frm1.strWhereCondition = strWhereCond;
            frm1.Show();
        }

        /// <summary>
        /// 函数功能:LISTVIEW的列单击事件函数
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:gfunGenListView_ColumnClick)
        /// </summary>
        private void lvvFileResource_ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
        {
            if (e.Column == this.objvFileResourceSorter.SortColumn)
            {

            }
            else
            {
                this.objvFileResourceSorter.SortColumn = e.Column;
            }

            if (this.objvFileResourceSorter.SortOrder == SortOrder.Ascending)
            {
                this.objvFileResourceSorter.SortOrder = SortOrder.Descending;
                if (intLastSelectedvFileResourceColumIndex == e.Column) //看是否重复点击一列
                {
                    this.lvvFileResource.Columns[e.Column].Text = this.lvvFileResource.Columns[e.Column].Text.Trim('▲', '▼') + "▼";
                    intLastSelectedvFileResourceColumIndex = e.Column;
                }
                else //如果点击另外一列了,那么前面点击的一列三角去掉
                {
                    this.lvvFileResource.Columns[e.Column].Text = this.lvvFileResource.Columns[e.Column].Text.Trim('▲', '▼') + "▼";
                    this.lvvFileResource.Columns[intLastSelectedvFileResourceColumIndex].Text = this.lvvFileResource.Columns[intLastSelectedvFileResourceColumIndex].Text.Trim('▼', '▲');
                    intLastSelectedvFileResourceColumIndex = e.Column;
                }
            }
            else if (this.objvFileResourceSorter.SortOrder == SortOrder.Descending) // ▲ ▼
            {
                this.objvFileResourceSorter.SortOrder = SortOrder.Ascending;
                if (intLastSelectedvFileResourceColumIndex == e.Column)
                {
                    this.lvvFileResource.Columns[e.Column].Text = this.lvvFileResource.Columns[e.Column].Text.Trim('▲', '▼') + "▲";
                    intLastSelectedvFileResourceColumIndex = e.Column;
                }
                else
                {
                    this.lvvFileResource.Columns[e.Column].Text = this.lvvFileResource.Columns[e.Column].Text.Trim('▲', '▼') + "▲";
                    this.lvvFileResource.Columns[intLastSelectedvFileResourceColumIndex].Text = this.lvvFileResource.Columns[intLastSelectedvFileResourceColumIndex].Text.Trim('▲', '▼');
                    intLastSelectedvFileResourceColumIndex = e.Column;
                }
            }
            else
            {
                return;
            }
            this.lvvFileResource.Sort();
        }

        /// <summary>
        /// 实现接口函数,通过子窗体调用,来实现本窗体(父窗体)的LISTVIEW重新绑定功能
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:gfunGenIBindListView_BindListView)
        /// </summary>
        void IBindListView.BindListView()
        {
            BindLv_vFileResource();
        }
        /// <summary>
        /// 为修改记录做准备过程,把给定关键字的记录字段值显示在用户控件上
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:GenUpdateRecordCode)
        /// </summary>
        private void UpdateFileResourceRecord()
        {
            if (this.lvvFileResource.SelectedItems.Count != 1)
            {
                DialogResult result;
                result = MessageBox.Show("(errid:WinI000001)请选择一条记录!");
                return;
            }
            frmFileResource_UI frm = new frmFileResource_UI();
            string strKeyId = this.lvvFileResource.SelectedItems[0].Tag.ToString();
            frm.FileResourceID_key = long.Parse(strKeyId);
            frm.iBindListView = this;
            frm.OperateType = "Update";
            frm.ShowDialog();
        }
        /// <summary>
        /// 根据给定关键字删除记录
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:GenDelRecordCode)
        /// </summary>
        /// <param name = "lngFileResourceID">给定关键字</param>
        private void DeleteFileResourceRecord()
        {
            DialogResult result;
            result = MessageBox.Show("你真的要删除该记录吗？", "确认删除", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (ListViewItem lvi in this.lvvFileResource.SelectedItems)
                {
                    long lngFileResourceID = GetCurrKey(lvi);
                    try
                    {
                        if (clsFileResourceWApi.DelRecord(lngFileResourceID) > 0)
                        {
                        }
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("(errid:WinI000002)删除记录失败!(frmFileResource_QD_LV: DeleteFileResourceRecord)错误信息:{0}.", objException.Message);
                        MessageBox.Show(strMsg);
                        BindLv_vFileResource();
                        return;
                    }
                }
                MessageBox.Show("删除记录成功!");
                BindLv_vFileResource();
            }
        }
    }
}