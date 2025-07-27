
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsCMUserProjectDA1
界面名:frmCMUserProject_QU_LV(00050261)
生成代码版本:2019.11.08.1
生成日期:2019/11/08 12:20:28
生成者:
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:代码管理
模块英文名:CodeMan
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

namespace AGC
{
    /// <summary>
    ///		frmCMUserProject_QD_DGV 的摘要说明。
    /// (AutoGCLib.WinViewCode_QD_Gv4CSharp:GeneCode)
    /// </summary>
    public partial class frmCMUserProject_QD_DGV : System.Windows.Forms.Form, IBindListView
    {
        clsCMUserProjectEN objCMUserProjectEN = null;
        private System.Data.DataTable objDTCMUserProject = null;
        public frmCMUserProject_QD_DGV()
        {
            // 该调用是 Windows.Forms 窗体设计器所必需的。
            InitializeComponent();

            // TODO: 在 InitializeComponent 调用后添加任何初始化

        }
        private void frmCMUserProject_QD_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面
            //1、为下拉框设置数据源,绑定列表数据
            this.SetAllComboBox();
            BindDgv_vCMUserProject();
            this.JudgebtnDelRec(); //用来判断删除按钮是否可用
            this.JudgebtnUpdate(); //用来判断修改按钮是否可用

        }
        /// <summary>
        /// 下拉框的绑定函数
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:Genfun_SetAllComboBox4Query)
        /// </summary>
        private void SetAllComboBox()
        {
            clsUsersWApi.BindCbo_UserId(this.cboUserId);
            clsCMProjectWApi.BindCbo_CMPrjId(this.cboCMPrjId, clsSysParaEN.CurrSelPrjId);
            clsProjectsWApi.BindCbo_PrjId(this.cboPrjId);
            clsApplicationTypeWApi.BindCbo_ApplicationTypeId(this.cboApplicationTypeId);
        }
        /// <summary>
        /// 查询区的控件属性
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:Genfun_ViewCtrlProperty4Query)
        /// </summary>
        public string UserId
        {
            get
            {
                if (cboUserId.SelectedValue.ToString() == "0")
                    return "";
                return cboUserId.SelectedValue.ToString();
            }
            set
            {
                if (value == "")
                {
                    cboUserId.SelectedValue = "0";
                }
                else
                {
                    cboUserId.SelectedValue = value;
                }
            }
        }

        /// <summary>
        /// 查询区的控件属性
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:Genfun_ViewCtrlProperty4Query)
        /// </summary>
        public string CMPrjId
        {
            get
            {
                if (cboCMPrjId.SelectedValue.ToString() == "0")
                    return "";
                return cboCMPrjId.SelectedValue.ToString();
            }
            set
            {
                if (value == "")
                {
                    cboCMPrjId.SelectedValue = "0";
                }
                else
                {
                    cboCMPrjId.SelectedValue = value;
                }
            }
        }

        /// <summary>
        /// 查询区的控件属性
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:Genfun_ViewCtrlProperty4Query)
        /// </summary>
        public string CMPrjName
        {
            get
            {
                return txtCMPrjName.Text.Trim();
            }
            set
            {
                txtCMPrjName.Text = value.ToString();
            }
        }

        /// <summary>
        /// 查询区的控件属性
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:Genfun_ViewCtrlProperty4Query)
        /// </summary>
        public string PrjId
        {
            get
            {
                if (cboPrjId.SelectedValue.ToString() == "0")
                    return "";
                return cboPrjId.SelectedValue.ToString();
            }
            set
            {
                if (value == "")
                {
                    cboPrjId.SelectedValue = "0";
                }
                else
                {
                    cboPrjId.SelectedValue = value;
                }
            }
        }

        /// <summary>
        /// 查询区的控件属性
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:Genfun_ViewCtrlProperty4Query)
        /// </summary>
        public int ApplicationTypeId
        {
            get
            {
                if (cboApplicationTypeId.SelectedValue.ToString() == "0")
                    return 0;
                return int.Parse(cboApplicationTypeId.SelectedValue.ToString());
            }
            set
            {
                if (value == 0)
                {
                    cboApplicationTypeId.SelectedValue = "0";
                }
                else
                {
                    cboApplicationTypeId.SelectedValue = value.ToString();
                }
            }
        }


        /// <summary>
        /// 清除用户自定义控件中，所有控件的值
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:Genfun_Clear4QryRegion)
        /// </summary>	
        public void Clear()
        {
            cboUserId.SelectedIndex = 0;
            cboCMPrjId.SelectedIndex = 0;
            txtCMPrjName.Text = "";
            cboPrjId.SelectedIndex = 0;
            cboApplicationTypeId.SelectedIndex = 0;
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
            cboUserId.SelectedIndex = 0;
            cboCMPrjId.SelectedIndex = 0;
            txtCMPrjName.Text = "";
            cboPrjId.SelectedIndex = 0;
            cboApplicationTypeId.SelectedIndex = 0;
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
            if (clsString.IsNumeric(cboApplicationTypeId.Text) == false)
            {
                strResult = "请输入正确的整型!";
                return false;
            }
            return true;
        }
        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:GenCombineCondition)
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        public string CombineCMUserProjectCondition()
        {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            string strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            if (this.cboUserId.SelectedValue.ToString() != "" && this.cboUserId.SelectedValue.ToString() != "0")
            {
                strWhereCond += string.Format(" And {0} = '{1}'", clsvCMUserProjectEN.con_UserId, this.cboUserId.SelectedValue);
            }
            if (this.cboCMPrjId.SelectedValue.ToString() != "" && this.cboCMPrjId.SelectedValue.ToString() != "0")
            {
                strWhereCond += string.Format(" And {0} = '{1}'", clsvCMUserProjectEN.con_CMPrjId, this.cboCMPrjId.SelectedValue);
            }
            if (this.txtCMPrjName.Text.Trim() != "")
            {
                strWhereCond += string.Format(" And {0} like '%{1}%'", clsvCMUserProjectEN.con_CMPrjName, this.txtCMPrjName.Text.Trim());
            }
            if (this.cboPrjId.SelectedValue.ToString() != "" && this.cboPrjId.SelectedValue.ToString() != "0")
            {
                strWhereCond += string.Format(" And {0} = '{1}'", clsvCMUserProjectEN.con_PrjId, this.cboPrjId.SelectedValue);
            }
            if (this.cboApplicationTypeId.SelectedValue.ToString() != "" && this.cboApplicationTypeId.SelectedValue.ToString() != "0")
            {
                strWhereCond += string.Format(" And {0} = '{1}'", clsvCMUserProjectEN.con_ApplicationTypeId, this.cboApplicationTypeId.SelectedValue);
            }
            return strWhereCond;
        }
        /// <summary>
        /// 函数功能:用来判断删除按钮是否可用。
        ///			 如果在LISTVIEW中选中记录就显示删除按钮,否则就不显示
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:gfunGenJudgebtnDelete4DataGridView)
        /// </summary>
        private void JudgebtnDelRec()
        {
            if (this.dgvvCMUserProject.SelectedRows.Count >= 1)
            {
                this.btnDelRec.Enabled = true;
                return;
            }
            else
            {
                this.btnDelRec.Enabled = false;
            }
            long lngKeyId = GetCurrKey(dgvvCMUserProject);
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
            if (this.dgvvCMUserProject.SelectedRows.Count >= 1)
            {
                this.btnUpdate.Enabled = true;
                return;
            }
            else
            {
                this.btnUpdate.Enabled = false;
            }
            long lngKeyId = GetCurrKey(dgvvCMUserProject);
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
        private void BindDgv_vCMUserProject()
        {
            //操作步骤:(共4步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	3、设置ListView的列头信息
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            //		在本界面中是把状态显示在控件lblRecCount中。

            ListViewItem lvivCMUserProject;
         List<clsvCMUserProjectEN> arrvCMUserProject;
            //	1、组合界面条件串；
            string strWhereCond = this.CombineCMUserProjectCondition(); // CombineCMUserProjectCondition();
            try
            {
                //	2、根据条件串获取该表满足条件的DataTable；
                arrvCMUserProject = clsvCMUserProjectWApi.GetObjLst(strWhereCond);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:WinI000017)获取数据不成功!(frmCMUserProject_QD_DGV: BindDgv_CMUserProject)错误信息:{0}.", objException.Message);
                MessageBox.Show(strMsg);
                lblMsg.Text = strMsg;
                return;
            }
            this.dgvvCMUserProject.AutoGenerateColumns = false;
            this.dgvvCMUserProject.DataSource = arrvCMUserProject;
            //	4、设置记录数的状态,
            //		在本界面中是把状态显示在控件txtRecCount中。
            this.lblRecNum.Text = "记录数:" + arrvCMUserProject.Count.ToString();
        }
        private void btnQuery_Click(object sender, System.EventArgs e)
        {
            //把表记录的内容显示在ListView中
            BindDgv_vCMUserProject();
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
            string strmId = objDTCMUserProject.Rows[intCurrRow]["mId"].ToString();
            long lngmId = long.Parse(strmId);
            return lngmId;
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
            string strmId = objDataGridView.CurrentRow.Cells["dgvcmId"].Value.ToString();
            if (strmId == "") return 0;
            long lngmId = long.Parse(strmId);
            return lngmId;
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
            string strmId = objDataGridViewRow.Cells["dgvcmId"].Value.ToString();
            long lngmId = long.Parse(strmId);
            return lngmId;
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
            ListViewItem lviCMUserProject;
            lviCMUserProject = ObjLstView.SelectedItems[0];
            string strCMUserProjectId = lviCMUserProject.Tag.ToString();
            long lngmId = long.Parse(strCMUserProjectId);
            return lngmId;
        }
        /// <summary>
        /// 获取ListView所给项的主键值
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:gfunGenGetCurrKey4ListView)
        /// </summary>
        /// <param name = "ObjLstView">所单击的ListView项</param>
        /// <returns>当前行的主键值</returns>
        private long GetCurrKey(ListViewItem ObjLstViewItem)
        {
            string strCMUserProjectId = ObjLstViewItem.Tag.ToString();
            long lngmId = long.Parse(strCMUserProjectId);
            return lngmId;
        }
        private void dgvvCMUserProject_Click(object sender, System.EventArgs e)
        {
            this.JudgebtnDelRec(); //用来判断删除按钮是否可用
            this.JudgebtnUpdate(); //用来判断修改按钮是否可用
        }
        private void dgvvCMUserProject_CellClick(object sender, DataGridViewCellEventArgs e)
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
            UpdateCMUserProjectRecord();
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
            frmCMUserProject_UI frm = new frmCMUserProject_UI();
            frm.iBindListView = this;
            frm.OperateType = "Add";
            frm.ShowDialog();
        }
        private void btnDelRec_Click(object sender, System.EventArgs e)
        {
            DeleteCMUserProjectRecord();
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
            string strWhereCond = this.CombineCMUserProjectCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;// clsCMUserProjectWApi.GetDataTable(strWhereCond);
            ArrayList arrCnName = new ArrayList();
            ArrayList arrColName = new ArrayList();
            //string strFileName = string.Format("vCMUserProject导出{0}.xls", clsDateTime.GetToday2(0));
            //string strFolderName;
            string strDownLoadFileName;
            arrColName.Add(clsvCMUserProjectEN.con_UserName); arrCnName.Add("用户名");
            arrColName.Add(clsvCMUserProjectEN.con_CMPrjName); arrCnName.Add("CM工程名");
            arrColName.Add(clsvCMUserProjectEN.con_PrjName); arrCnName.Add("工程名称");
            arrColName.Add(clsvCMUserProjectEN.con_ApplicationTypeSimName); arrCnName.Add("应用程序类型简称");
            arrColName.Add(clsvCMUserProjectEN.con_ProjectFileName); arrCnName.Add("工程文件名");
            arrColName.Add(clsvCMUserProjectEN.con_ProjectPath); arrCnName.Add("工程路径");
            arrColName.Add(clsvCMUserProjectEN.con_UpdDate); arrCnName.Add("修改日期");
            arrColName.Add(clsvCMUserProjectEN.con_Memo); arrCnName.Add("说明");
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
            objExcel.GetExcelFromDataTableByArrAndArray(objDT, arrColName, arrCnName, strDownLoadFileName);
            MessageBox.Show("导出Excel成功!,文件存放在:" + strDownLoadFileName);
        }
        /// <summary>
        /// 导出EXCEL的函数, 导出EXCEL时可以选择列
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:gfunGenExportExcel_SelColumns)
        /// </summary>
        private void ExportExcel_SelColumns()
        {
            //	1、组合界面条件串；
            string strWhereCond = this.CombineCMUserProjectCondition();
            //	2、设置表列数据字段名,以及表列标题
            ArrayList arrCnName = new ArrayList();
            ArrayList arrColName = new ArrayList();
            arrColName.Add(clsvCMUserProjectEN.con_UserName); arrCnName.Add("用户名");
            arrColName.Add(clsvCMUserProjectEN.con_CMPrjName); arrCnName.Add("CM工程名");
            arrColName.Add(clsvCMUserProjectEN.con_PrjName); arrCnName.Add("工程名称");
            arrColName.Add(clsvCMUserProjectEN.con_ApplicationTypeSimName); arrCnName.Add("应用程序类型简称");
            arrColName.Add(clsvCMUserProjectEN.con_ProjectFileName); arrCnName.Add("工程文件名");
            arrColName.Add(clsvCMUserProjectEN.con_ProjectPath); arrCnName.Add("工程路径");
            arrColName.Add(clsvCMUserProjectEN.con_UpdDate); arrCnName.Add("修改日期");
            arrColName.Add(clsvCMUserProjectEN.con_Memo); arrCnName.Add("说明");
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
            frm1.strTableName = "vCMUserProject";
            frm1.strTableChineseName = "vCMUserProject";
            frm1.strViewName = "CM用户工程维护";
            frm1.strWhereCondition = strWhereCond;
            frm1.Show();
        }

        /// <summary>
        /// 实现接口函数,通过子窗体调用,来实现本窗体(父窗体)的LISTVIEW重新绑定功能
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:gfunGenIBindListView_BindListView4DataGridView)
        /// </summary>
        void IBindListView.BindListView()
        {
            BindDgv_vCMUserProject();
        }
        /// <summary>
        /// 为修改记录做准备过程,把给定关键字的记录字段值显示在用户控件上    
        /// </summary>
        private void UpdateCMUserProjectRecord()
        {
            //主键变量
            long lngmId = 0;
            if (this.dgvvCMUserProject.SelectedRows.Count > 0)
            {
                //修改当前选择行的第1行
                lngmId = GetCurrKey(this.dgvvCMUserProject.SelectedRows[0]);
            }
            else
            {
                //修改当前行
                lngmId = GetCurrKey(this.dgvvCMUserProject);
            }
            if (lngmId == 0)
            {
                DialogResult result;
                result = MessageBox.Show("(errid:WinI000018)请选择一条记录!");
                return;
            }
            frmCMUserProject_UI frm = new frmCMUserProject_UI();
            frm.mId_key = lngmId;
            frm.iBindListView = this;
            frm.OperateType = "Update";
            frm.ShowDialog();
        }
        /// <summary>
        /// 根据给定关键字删除记录
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:GenDelRecordCode4DataGridView)
        /// </summary>
        /// <param name = "lngmId">给定关键字</param>
        private void DeleteCMUserProjectRecord()
        {
            //主键变量
            long lngmId = 0;
            DialogResult result;
            result = MessageBox.Show("你真的要删除该记录吗？", "确认删除", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (dgvvCMUserProject.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow objDGVR in this.dgvvCMUserProject.SelectedRows)
                    {
                        lngmId = GetCurrKey(objDGVR);
                        if (clsCMUserProjectWApi.DelRecord(lngmId) == 0)
                        {
                            string strMsg = string.Format("(errid:WinI000019)删除记录失败(For DataGridView)!(frmCMUserProject_QD_DGV: DeleteCMUserProjectRecord).");
                            MessageBox.Show(strMsg);
                            BindDgv_vCMUserProject();
                            return;
                        }
                    }
                }
                else
                {
                    lngmId = GetCurrKey(dgvvCMUserProject);
                    if (lngmId > 0)
                    {
                        if (clsCMUserProjectWApi.DelRecord(lngmId) == 0)
                        {
                            string strMsg = string.Format("(errid:WinI000020)删除记录失败!(frmCMUserProject_QD_DGV: DeleteCMUserProjectRecord).");
                            MessageBox.Show(strMsg);
                            BindDgv_vCMUserProject();
                            return;
                        }
                    }
                }
                MessageBox.Show("删除记录成功!");
                BindDgv_vCMUserProject();
            }
        }
    }
}