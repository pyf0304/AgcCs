
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsFileResourceDA1
界面名:frmFileResource_QU_DGV(00050276)
生成代码版本:2020.05.09.1
生成日期:2020/05/10 00:56:42
生成者:
工程名称:AGC
工程ID:0005
相关数据库:tzar.tpddns.cn,19433AGC_CS12
PrjDataBaseId:0213
模块中文名:资源管理
模块英文名:ResourceMan
框架-层名:Win界面层_QD_Gv(WinViewCode_QD_Gv)
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


using AGC;
using AGC.Entity;
using com.taishsoft.common;
using com.taishsoft.datetime;
using AGC4WApi;
using AGC_CSWin;
using com.taishsoft.file;

using System.Linq;

namespace AGC
{
    /// <summary>
    ///		frmFileResource_QD_DGV 的摘要说明。
    /// (AutoGCLib.WinViewCode_QD_Gv4CSharp:GeneCode)
    /// </summary>
    public partial class frmFileResource_QD_DGV : System.Windows.Forms.Form, IBindListView
    {
        //clsFileResourceEN objFileResourceEN = null;
        private System.Data.DataTable objDTFileResource = null;
        public frmFileResource_QD_DGV()
        {
            // 该调用是 Windows.Forms 窗体设计器所必需的。
            InitializeComponent();

            // TODO: 在 InitializeComponent 调用后添加任何初始化

        }
        private void frmFileResource_QD_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面
            //1、为下拉框设置数据源,绑定列表数据
            this.SetAllComboBox();
            BindDgv_vFileResource();
            this.JudgebtnDelRec(); //用来判断删除按钮是否可用
            this.JudgebtnUpdate(); //用来判断修改按钮是否可用

        }
        /// <summary>
        /// 下拉框的绑定函数
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:Genfun_SetAllComboBox4Query)
        /// </summary>
        private void SetAllComboBox()
        {
            clsCMProjectExWApi.BindCbo_CmPrjIdCacheEx(this.cboCmPrjIdApp, clsPubVar.CurrSelPrjId);
            clsComboBox_Common.BindCbo_TrueAndFalse(cboIsCanDel);

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
                if (cboCmPrjIdApp.SelectedValue.ToString() == "0")
                    return "";
                return cboCmPrjIdApp.SelectedValue.ToString();
            }
            set
            {
                if (value == "")
                {
                    cboCmPrjIdApp.SelectedValue = "0";
                }
                else
                {
                    cboCmPrjIdApp.SelectedValue = value;
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
            cboCmPrjIdApp.SelectedIndex = 0;
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
            cboCmPrjIdApp.SelectedIndex = 0;
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
            string strWhereCond = " 1=1 ";
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
            if (this.cboCmPrjIdApp.SelectedValue.ToString() != "" && this.cboCmPrjIdApp.SelectedValue.ToString() != "0")
            {
                strWhereCond += string.Format(" And {0} = '{1}'", convFileResource.CmPrjId, this.cboCmPrjIdApp.SelectedValue);
            }
            if (this.cboIsCanDel.SelectedIndex == 1)
            {             
                strWhereCond += string.Format(" And {0} = '1'", convFileResource.IsCanDel);
            }
            else if (this.cboIsCanDel.SelectedIndex == 2)
            {             
                strWhereCond += string.Format(" And {0} = '0'", convFileResource.IsCanDel);
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
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:gfunGenJudgebtnDelete4DataGridView)
        /// </summary>
        private void JudgebtnDelRec()
        {
            if (this.dgvvFileResource.SelectedRows.Count >= 1)
            {
                this.btnDelRec.Enabled = true;
                return;
            }
            else
            {
                this.btnDelRec.Enabled = false;
            }
            long lngKeyId = GetCurrKey(dgvvFileResource);
            if (lngKeyId == 0)
            {
                this.btnDelRec.Enabled = false;
            }
            else
            {
                this.btnDelRec.Enabled = true;
            }
        }
        /// <summary>
        /// 函数功能:用来判断删除按钮是否可用。
        ///			 如果在LISTVIEW中选中记录就显示删除按钮,否则就不显示
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:gfunGenJudgebtnUpdate4DataGridView)
        /// </summary>
        private void JudgebtnUpdate()
        {
            if (this.dgvvFileResource.SelectedRows.Count >= 1)
            {
                this.btnUpdate.Enabled = true;
                return;
            }
            else
            {
                this.btnUpdate.Enabled = false;
            }
            long lngKeyId = GetCurrKey(dgvvFileResource);
            if (lngKeyId == 0)
            {
                this.btnUpdate.Enabled = false;
            }
            else
            {
                this.btnUpdate.Enabled = true;
            }
        }
        ///生成绑定DataGridView的代码
        /// <summary>
        /// 函数功能:根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在DataGridView中。
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:gfunGenBindDataGridView)
        /// </summary>
        private void BindDgv_vFileResource()
        {
            //操作步骤:(共4步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	3、设置ListView的列头信息
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            //		在本界面中是把状态显示在控件lblRecCount中。

            //ListViewItem lvivFileResource;
            List<clsvFileResourceEN> objDT;
            //	1、组合界面条件串；
            string strWhereCond = this.CombineFileResourceCondition();  // CombineFileResourceCondition();
            if (strWhereCond == " 1=1 ") return;
            try
            {
                //	2、根据条件串获取该表满足条件的DataTable；
                objDT = clsvFileResourceWApi.GetObjLst(strWhereCond);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:WinI000017)获取数据不成功!(frmFileResource_QD_DGV: BindDgv_FileResource)错误信息:{0}.", objException.Message);
                MessageBox.Show(strMsg);
                lblMsg.Text = strMsg;
                return;
            }
            this.dgvvFileResource.AutoGenerateColumns = false;
            this.dgvvFileResource.DataSource = objDT;
            //	4、设置记录数的状态,
            //		在本界面中是把状态显示在控件txtRecCount中。
            this.lblRecNum.Text = "记录数:" + objDT.Count.ToString();
        }
        private void btnQuery_Click(object sender, System.EventArgs e)
        {
            //把表记录的内容显示在ListView中
            BindDgv_vFileResource();
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
        /// 获取DataGrid中当前行的主键值
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:gfunGenGetCurrKey4DataGridView)
        /// </summary>
        /// <param name = "objDataGrid">所单击的DataGrid</param>
        /// <returns>当前行的主键值</returns>
        private long GetCurrKey(DataGridView objDataGridView)
        {
            if (objDataGridView.CurrentRow == null) return 0;
            string strfileResourceID = objDataGridView.CurrentRow.Cells["dgvcfileResourceID"].Value.ToString();
            if (strfileResourceID == "") return 0;
            long lngFileResourceID = long.Parse(strfileResourceID);
            return lngFileResourceID;
        }
        /// <summary>
        /// 获取DataGrid中当前行的主键值
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:gfunGenGetCurrKey4DataGridView)
        /// </summary>
        /// <param name = "objDataGrid">所单击的DataGrid</param>
        /// <returns>当前行的主键值</returns>
        private long GetCurrKey(DataGridViewRow objDataGridViewRow)
        {
            if (objDataGridViewRow == null) return 0;
            string strfileResourceID = objDataGridViewRow.Cells["dgvcFileResourceID"].Value.ToString();
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
        private void dgvvFileResource_Click(object sender, System.EventArgs e)
        {
            this.JudgebtnDelRec(); //用来判断删除按钮是否可用
            this.JudgebtnUpdate(); //用来判断修改按钮是否可用
        }
        private void dgvvFileResource_CellClick(object sender, DataGridViewCellEventArgs e)
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
        /// 实现接口函数,通过子窗体调用,来实现本窗体(父窗体)的LISTVIEW重新绑定功能
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:gfunGenIBindListView_BindListView4DataGridView)
        /// </summary>
        void IBindListView.BindListView()
        {
            BindDgv_vFileResource();
        }
        /// <summary>
        /// 为修改记录做准备过程,把给定关键字的记录字段值显示在用户控件上
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:GenUpdateRecordCode4DataGridView)
        /// </summary>
        private void UpdateFileResourceRecord()
        {
            //主键变量
            long lngFileResourceID = 0;
            if (this.dgvvFileResource.SelectedRows.Count > 0)
            {
                //修改当前选择行的第1行
                lngFileResourceID = GetCurrKey(this.dgvvFileResource.SelectedRows[0]);
            }
            else
            {
                //修改当前行
                lngFileResourceID = GetCurrKey(this.dgvvFileResource);
            }
            if (lngFileResourceID == 0)
            {
                DialogResult result;
                result = MessageBox.Show("(errid:WinI000018)请选择一条记录!");
                return;
            }
            frmFileResource_UI frm = new frmFileResource_UI();
            frm.FileResourceID_key = lngFileResourceID;
            frm.iBindListView = this;
            frm.OperateType = "Update";
            frm.ShowDialog();
        }
        /// <summary>
        /// 根据给定关键字删除记录
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:GenDelRecordCode4DataGridView)
        /// </summary>
        /// <param name = "lngFileResourceID">给定关键字</param>
        private void DeleteFileResourceRecord()
        {
            //主键变量
            long lngFileResourceID = 0;
            DialogResult result;
            result = MessageBox.Show("你真的要删除该记录吗？", "确认删除", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (dgvvFileResource.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow objDGVR in this.dgvvFileResource.SelectedRows)
                    {
                        lngFileResourceID = GetCurrKey(objDGVR);
                        if (clsFileResourceWApi.DelRecord(lngFileResourceID) == 0)
                        {
                            string strMsg = string.Format("(errid:WinI000019)删除记录失败(For DataGridView)!(frmFileResource_QD_DGV: DeleteFileResourceRecord).");
                            MessageBox.Show(strMsg);
                            BindDgv_vFileResource();
                            return;
                        }
                    }
                }
                else
                {
                    lngFileResourceID = GetCurrKey(dgvvFileResource);
                    if (lngFileResourceID > 0)
                    {
                        if (clsFileResourceWApi.DelRecord(lngFileResourceID) == 0)
                        {
                            string strMsg = string.Format("(errid:WinI000020)删除记录失败!(frmFileResource_QD_DGV: DeleteFileResourceRecord).");
                            MessageBox.Show(strMsg);
                            BindDgv_vFileResource();
                            return;
                        }
                    }
                }
                MessageBox.Show("删除记录成功!");
                BindDgv_vFileResource();
            }
        }

        private void btnDelFile4Prj_Click(object sender, EventArgs e)
        {
            if (cboCmPrjIdApp.SelectedIndex<=0)
            {
                MessageBox.Show("请选择代码工程！");
                cboCmPrjIdApp.Focus();
                return;
            }
            
            string strCondition = string.Format("{0}='{1}' and {2}='1'", 
                conFileResource.CmPrjId, CmPrjId, 
                conFileResource.IsCanDel);
            List<clsFileResourceEN> arrFileResource = clsFileResourceWApi.GetObjLst(strCondition);
            int intCount = 0;
            foreach(clsFileResourceEN objInFor in arrFileResource)
            {
                string strFileName = string.Format("{0}\\{1}", objInFor.FileDirName, objInFor.FileName);
                if (File.Exists(strFileName) == true)
                {
                    File.Delete(strFileName);
                }
                try
                {
                    clsFileResourceWApi.DelRecord(objInFor.FileResourceID);
                }
                catch (Exception objException)
                {
                    Console.WriteLine(objException);
                    string strCondition1 = string.Format("{0}={1}", conFileResource.FileResourceID, objInFor.FileResourceID);
                    var Arr = new List<string>() { objInFor.FileResourceID.ToString() };
                    clsFileResourceWApi.DelFileResources(Arr);
                }
                intCount++;

            }
            BindDgv_vFileResource();
            string strMsg = string.Format("在工程中删除了：{0}个文件。", intCount);
            MessageBox.Show(strMsg);
            
        }

        private void btnReadPrjFileInfo_Click(object sender, EventArgs e)
        {
            //string strPhysicalDir = @"E:\AspNetCore\AgcSpa\AgcSpa";            
            lblMsg.Text = "";
            if (cboCmPrjIdApp.SelectedIndex <= 0)
            {
                MessageBox.Show("请选择一个CmPrjId");
                cboCmPrjIdApp.Focus();
                return;
            }
            string strCMProjectAppRelaId = cboCmPrjIdApp.SelectedValue.ToString();
            long lngCMProjectAppRelaId = long.Parse(strCMProjectAppRelaId);
            string strPhysicalDir = lblFilePath.Text;
            if (string.IsNullOrEmpty( strPhysicalDir) == true)
            {
                //clsCMProjectEN objCMProject = clsCMProjectWApi.GetObjByCmPrjIdCache(strCmPrjId);
                string strCondtion = new clsUserCodePrjMainPathEN()
                        .SetUserId(clsSysParaEN_Local.strUserId, "=")
                        .SetCMProjectAppRelaId(lngCMProjectAppRelaId, "=")
                        .SetPrjId(clsPubVar.CurrSelPrjId, "=")
                        
                        .GetCombineCondition();
                clsUserCodePrjMainPathEN objUserCodePrjMainPath = clsUserCodePrjMainPathWApi.GetFirstObj(strCondtion);
                clsApplicationTypeEN objApp = clsApplicationTypeWApi.GetObjByApplicationTypeIdCache(objUserCodePrjMainPath.ApplicationTypeId());
                lblMsg.Text = string.Format("当前CmPrjId对应的主项目为：{0}, 没有相关的用户[{1}]路径，请检查！", objApp.ApplicationTypeName, clsSysParaEN_Local.strUserId);
                MessageBox.Show(lblMsg.Text);
                return;
            }
            FileCollection objFileColl = new FileCollection();
            var arrFileResExcludePathObjLst = clsFileResExcludePathWApi.GetObjLstCache();
            var arrExcludeDirName = arrFileResExcludePathObjLst.Select(x=>x.ExcludeDirName);
            clsFile.GetFileListEx(strPhysicalDir, objFileColl);
            string strServerIp = "111";
            int intCount = 0;
            foreach (UserFile objUserFile in objFileColl.FileLst)
            {
                bool bolIsInclude = false;
                foreach (string strExcludeDirName in arrExcludeDirName)
                {
                    if (objUserFile.FullDirName.Contains(strExcludeDirName) == true)
                    {
                        bolIsInclude = true;
                        break;
                    }
                }
                if (bolIsInclude == true) continue;
                var objCmCMProjectAppRela = clsCMProjectAppRelaWApi.GetObjByCMProjectAppRelaIdCache(lngCMProjectAppRelaId, clsPubVar.CurrSelPrjId);

                //FileAttributes objFileAttr = File.GetAttributes(strFileName);
                clsFileResourceEN objFileResource = new clsFileResourceEN();
                objFileResource.FileDirName = objUserFile.FullDirName;
                objFileResource.IpAddress = strServerIp;
                objFileResource.FileName = objUserFile.FileName;
                objFileResource.FileLength = objUserFile.FileSize;
                //objFileResource.UpdDate = strCurrDateTime;
                objFileResource.UpdUser = clsSysParaEN_Local.strUserId;
                objFileResource.Extension = objUserFile.Extension;
                objFileResource.CreationTime = clsDateTime.getDateStr(objUserFile.CreationTime, 1);
                objFileResource.LastWriteTime = clsDateTime.getDateStr(objUserFile.CreationTime, 1);
                objFileResource.IsExistFile = true;
                objFileResource.PrjId = clsPubVar.CurrSelPrjId;
                objFileResource.CmPrjId = objCmCMProjectAppRela.CmPrjId;
                string strCondtion = new clsFileResourceEN()
                    .SetPrjId(objFileResource.PrjId, "=")
                    .SetCmPrjId(objFileResource.CmPrjId, "=")
                    .SetFileDirName(objFileResource.FileDirName, "=")
                    .SetFileName(objFileResource.FileName, "=")
                    .GetCombineCondition();
                try
                {
                    if (clsFileResourceWApi.IsExistRecord(strCondtion) == false)
                    {
                        clsFileResourceWApi.AddNewRecord(objFileResource);
                        intCount++;
                    }
                }
                catch(Exception obj)
                {
                    var objCmProject = clsCMProjectWApi.GetObjByCmPrjIdCache(objCmCMProjectAppRela.CmPrjId);
                    string strMsg0 = string.Format("导入文件出错！错误：[{0}].前CmPrjId：{1}，请检查！(in {2})", obj.Message, objCmProject.CmPrjName,  clsStackTrace.GetCurrClassFunction());
                    MessageBox.Show(strMsg0);
                    return;
                    //continue;
                }

            }
            string strMsg = string.Format("共导入:{0}个文件。", intCount);
            MessageBox.Show(strMsg);
        }

        private void cboCmPrjId_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strMachineName = Environment.MachineName;
            lblMsg.Text = "";
            if (cboCmPrjIdApp.SelectedIndex <= 0) return;
            
            string strCMProjectAppRelaId = cboCmPrjIdApp.SelectedValue.ToString();
            long lngCMProjectAppRelaId = long.Parse(strCMProjectAppRelaId);
                        
            string strCondtion = new clsUserCodePrjMainPathEN()
                  .SetUserId(clsSysParaEN_Local.strUserId, "=")
             .SetCMProjectAppRelaId(lngCMProjectAppRelaId, "=")
             .SetPrjId(clsPubVar.CurrSelPrjId, "=")
             
             .GetCombineCondition();
            clsUserCodePrjMainPathEN objUserCodePrjMainPath = clsUserCodePrjMainPathWApi.GetFirstObj(strCondtion);
            if (objUserCodePrjMainPath == null)
            {
                var objCmCMProjectAppRela = clsCMProjectAppRelaWApi.GetObjByCMProjectAppRelaIdCache(objUserCodePrjMainPath.CMProjectAppRelaId, objUserCodePrjMainPath.PrjId);

                
                lblMsg.Text = string.Format("当前CmPrjId对应的主项目为：{0}, 没有相关的用户[{1}]路径，请检查！", objCmCMProjectAppRela.ApplicationTypeName(), clsSysParaEN_Local.strUserId);
                MessageBox.Show(lblMsg.Text);
                return;
            }
            clsUserCodePrjMainPathENEx objUserCodePrjMainPathEx = clsUserCodePrjMainPathExWApi.CopyToExByMachineName(objUserCodePrjMainPath, strMachineName, clsPubVar.CurrSelPrjId);
            lblFilePath.Text = objUserCodePrjMainPathEx.CodePath;
            BindDgv_vFileResource();
        }
    }
}