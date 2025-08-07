///生成与表相关的控件控制层代码
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using com.taishsoft.util;
using CommFunc4Win;
using AGC.Entity;
using System.Collections.Generic;
//using AGC.BusinessLogicEx;

using AGC4WApi;

namespace AGC_CSWin
{
    /// <summary>
    ///		frmUserPrjGrant_QD_LV 的摘要说明。
    /// </summary>
    public partial class frmUserPrjGrant_SelectPrj : System.Windows.Forms.Form, IBindListView
    {
        //clsUserPrjGrantEN objUserPrjGrant = null;
        public MdiForm objMdiForm = null;
        private System.Data.DataTable objDTUserPrjGrant = null;
        private clsListViewSorter objvUserPrjGrantSorter;
        private int intLastSelectedvUserPrjGrantColumIndex;
        public frmUserPrjGrant_SelectPrj()
        {
            // 该调用是 Windows.Forms 窗体设计器所必需的。
            InitializeComponent();

            // TODO: 在 InitializeComponent 调用后添加任何初始化
            objvUserPrjGrantSorter = new clsListViewSorter();
            //为ListViewItemSorter指定排序类
            this.lvvUserPrjGrant.ListViewItemSorter = objvUserPrjGrantSorter;
            objvUserPrjGrantSorter.SortOrder = SortOrder.Ascending;

        }
        private void frmUserPrjGrant_QD_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面
            ///1、为下拉框设置数据源，绑定列表数据
            this.SetAllComboBox();
            BindLv_vUserPrjGrant();

        }
        /// <summary>
        /// 下拉框的绑定函数
        /// </summary>
        private void SetAllComboBox()
        {
        }
        ///生成组合查询条件的代码
        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        public string CombineUserPrjGrantCondion()
        {
            ///使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            ///例如 1=1 && UserName = '张三'
            string strWhereCond = string.Format(" 1=1 and {0} = '{1}' And {2}='0001'",
                convUserPrjGrant.UserId,  clsSysParaEN.strUserId ,
                convUserPrjGrant.UseStateId);
            return strWhereCond;
        }
       
        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在ListView中。
        /// </summary>
        private void BindLv_vUserPrjGrant()
        {
            ///	操作步骤：(共4步)
            ///	1、组合界面条件串；
            ///	2、根据条件串获取该表满足条件的DataTable；
            ///	3、设置ListView的列头信息
            ///	4、设置ListView的Item信息。即把所有记录显示在ListView中
            ///		在本界面中是把状态显示在控件lblRecCount中。

            ListViewItem lvivUserPrjGrant;
            List<clsvUserPrjGrantEN> arrvUserPrjGrantObjList;
            ///	1、组合界面条件串；
            string strWhereCond = this.CombineUserPrjGrantCondion();	//  CombineUserPrjGrantCondion();
            ///	2、根据条件串获取该表满足条件的DataTable；
            //if (clsSysParaEN.bolIsUseXmlDataSource == true)
            //{
            //    arrvUserPrjGrantObjList = new clsvUserPrjGrantEx().GetObjLstForXml(strWhereCond);
            //}
            //else
            //{
                arrvUserPrjGrantObjList =  clsvUserPrjGrantWApi.GetObjLst(strWhereCond + " Order by VisitedNum Desc");
            //}
            ///	3、设置ListView的列头信息
            this.lvvUserPrjGrant.Items.Clear();//清除原来所有Item
            this.lvvUserPrjGrant.Columns.Clear();//清除原来所有列头信息
            this.lvvUserPrjGrant.Columns.Add("用户ID", 60, HorizontalAlignment.Left);
            this.lvvUserPrjGrant.Columns.Add("用户名", 60, HorizontalAlignment.Left);
            this.lvvUserPrjGrant.Columns.Add("项目名称", 240, HorizontalAlignment.Left);
            this.lvvUserPrjGrant.Columns.Add("角色名称", 100, HorizontalAlignment.Left);
            this.lvvUserPrjGrant.Columns.Add("访问数", 60, HorizontalAlignment.Left);
            this.lvvUserPrjGrant.Columns.Add("部门名", 80, HorizontalAlignment.Left);
            this.lvvUserPrjGrant.Columns.Add("用户状态", 100, HorizontalAlignment.Left);
            //this.lvvUserPrjGrant.Columns.Add("操作者Id", 100, HorizontalAlignment.Left);
            //this.lvvUserPrjGrant.Columns.Add("操作日期", 100, HorizontalAlignment.Left);
            this.lvvUserPrjGrant.Columns.Add("备注", 100, HorizontalAlignment.Left);
            this.lvvUserPrjGrant.View = View.Details;
            ///	4、设置ListView的Item信息。即把所有记录显示在ListView中
            foreach (clsvUserPrjGrantEN objvUserPrjGrant in arrvUserPrjGrantObjList)
            {
                lvivUserPrjGrant = new ListViewItem();
                lvivUserPrjGrant.Tag = objvUserPrjGrant.mId;
                lvivUserPrjGrant.Text = objvUserPrjGrant.UserId;
                lvivUserPrjGrant.SubItems.Add(objvUserPrjGrant.UserName);
                lvivUserPrjGrant.SubItems.Add(objvUserPrjGrant.PrjName);
                lvivUserPrjGrant.SubItems.Add(objvUserPrjGrant.RoleName);
                lvivUserPrjGrant.SubItems.Add(objvUserPrjGrant.VisitedNum.ToString());
                lvivUserPrjGrant.SubItems.Add(objvUserPrjGrant.DepartmentName);
                lvivUserPrjGrant.SubItems.Add(objvUserPrjGrant.UserStateName);
                //lvivUserPrjGrant.SubItems.Add(objvUserPrjGrant.OptId);
                //lvivUserPrjGrant.SubItems.Add(objvUserPrjGrant.OptDate);
                lvivUserPrjGrant.SubItems.Add(objvUserPrjGrant.Memo);
                this.lvvUserPrjGrant.Items.Add(lvivUserPrjGrant);
            }
            ///	4、设置记录数的状态，
            ///		在本界面中是把状态显示在控件txtRecCount中。
            this.lblRecNum.Text = "记录数：" + arrvUserPrjGrantObjList.Count.ToString();
        }
        private void btnQuery_Click(object sender, System.EventArgs e)
        {
            //把表记录的内容显示在ListView中
            BindLv_vUserPrjGrant();
        }
        /// <summary>
        /// 获取DataGrid中当前行的主键值
        /// </summary>
        /// <param name="objDataGrid">所单击的DataGrid</param>
        /// <returns>当前行的主键值</returns>
        private long GetCurrKey(DataGrid objDataGrid)
        {
            int intCurrRow = objDataGrid.CurrentRowIndex;
            string strmId = objDTUserPrjGrant.Rows[intCurrRow]["mId"].ToString();
            long lngmId = long.Parse(strmId);
            return lngmId;
        }
        /// <summary>
        /// 获取ListView中当前行的主键值
        /// </summary>
        /// <param name="objListViewItem">所单击的ListView</param>
        /// <returns>当前行的主键值</returns>
        private long GetCurrKey(ListViewItem objListViewItem)
        {
            string strKeyId = objListViewItem.Tag.ToString();
            return long.Parse(strKeyId);
        }
        /// <summary>
        /// 获取ListView中当前行的主键值
        /// </summary>
        /// <param name="objListView">所单击的ListView</param>
        /// <returns>当前行的主键值</returns>
        private long GetCurrKey(ListView objListView)
        {
            ListViewItem lviUserPrjGrant;
            if (objListView.SelectedItems.Count == 0) return 0;
            lviUserPrjGrant = objListView.SelectedItems[0];
            string strUserPrjGrantId = lviUserPrjGrant.Tag.ToString();
            long lngmId = long.Parse(strUserPrjGrantId);
            return lngmId;
        }
      
        /// <summary>
        /// 函数功能：事件函数，当单击<确定修改>时发生的事件函数，
        ///           具体功能为把界面内容同步数据库中，把界面内容保存到数据库中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            UpdateUserPrjGrantRecord();
        }
        /// <summary>
        /// 函数功能：事件函数，当单击<确定修改>时发生的事件函数，
        ///           具体功能为把界面内容同步数据库中，把界面内容保存到数据库中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            frmUserPrjGrant_UI frm = new frmUserPrjGrant_UI();
            frm.iBindListView = this;
            frm.OperateType = "Add";
            frm.ShowDialog();
        }
        private void btnDelRec_Click(object sender, System.EventArgs e)
        {
            DeleteUserPrjGrantRecord();
        }
       
 
        /// <summary>
        /// 函数功能：LISTVIEW的列单击事件函数
        /// </summary>
        private void lvvUserPrjGrant_ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
        {
            if (e.Column == this.objvUserPrjGrantSorter.SortColumn)
            {

            }
            else
            {
                this.objvUserPrjGrantSorter.SortColumn = e.Column;
            }

            if (this.objvUserPrjGrantSorter.SortOrder == SortOrder.Ascending)
            {
                this.objvUserPrjGrantSorter.SortOrder = SortOrder.Descending;
                if (intLastSelectedvUserPrjGrantColumIndex == e.Column) //看是否重复点击一列
                {
                    this.lvvUserPrjGrant.Columns[e.Column].Text = this.lvvUserPrjGrant.Columns[e.Column].Text.Trim('▲', '▼') + "▼";
                    intLastSelectedvUserPrjGrantColumIndex = e.Column;
                }
                else //如果点击另外一列了，那么前面点击的一列三角去掉
                {
                    this.lvvUserPrjGrant.Columns[e.Column].Text = this.lvvUserPrjGrant.Columns[e.Column].Text.Trim('▲', '▼') + "▼";
                    this.lvvUserPrjGrant.Columns[intLastSelectedvUserPrjGrantColumIndex].Text = this.lvvUserPrjGrant.Columns[intLastSelectedvUserPrjGrantColumIndex].Text.Trim('▼', '▲');
                    intLastSelectedvUserPrjGrantColumIndex = e.Column;
                }
            }
            else if (this.objvUserPrjGrantSorter.SortOrder == SortOrder.Descending) // ▲ ▼
            {
                this.objvUserPrjGrantSorter.SortOrder = SortOrder.Ascending;
                if (intLastSelectedvUserPrjGrantColumIndex == e.Column)
                {
                    this.lvvUserPrjGrant.Columns[e.Column].Text = this.lvvUserPrjGrant.Columns[e.Column].Text.Trim('▲', '▼') + "▲";
                    intLastSelectedvUserPrjGrantColumIndex = e.Column;
                }
                else
                {
                    this.lvvUserPrjGrant.Columns[e.Column].Text = this.lvvUserPrjGrant.Columns[e.Column].Text.Trim('▲', '▼') + "▲";
                    this.lvvUserPrjGrant.Columns[intLastSelectedvUserPrjGrantColumIndex].Text = this.lvvUserPrjGrant.Columns[intLastSelectedvUserPrjGrantColumIndex].Text.Trim('▲', '▼');
                    intLastSelectedvUserPrjGrantColumIndex = e.Column;
                }
            }
            else
            {
                return;
            }
            this.lvvUserPrjGrant.Sort();
        }

        /// <summary>
        /// 实现接口函数，通过子窗体调用，来实现本窗体(父窗体)的LISTVIEW重新绑定功能
        /// </summary>
        void IBindListView.BindListView()
        {
            BindLv_vUserPrjGrant();
        }
        ///生成修改记录准备过程代码 for C#
        private void UpdateUserPrjGrantRecord()
        {
            if (this.lvvUserPrjGrant.SelectedItems.Count != 1)
            {
                DialogResult result;
                result = MessageBox.Show("请选择一条记录！");
                return;
            }
            frmUserPrjGrant_UI frm = new frmUserPrjGrant_UI();
            string strKeyId = this.lvvUserPrjGrant.SelectedItems[0].Tag.ToString();
            frm.mId_key = long.Parse(strKeyId);
            frm.iBindListView = this;
            frm.OperateType = "Update";
            frm.ShowDialog();
        }
        ///删除记录过程代码for C#
        private void DeleteUserPrjGrantRecord()
        {
            DialogResult result;
            result = MessageBox.Show("你真的要删除该记录吗？", "确认删除", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (ListViewItem lvi in this.lvvUserPrjGrant.SelectedItems)
                {
                    long lngmId = GetCurrKey(lvi);
                    if (clsUserPrjGrantWApi.DelRecord(lngmId) == 0)
                    {
                        MessageBox.Show("删除记录失败！");
                        BindLv_vUserPrjGrant();
                        return;
                    }
                }
                MessageBox.Show("删除记录成功！");
                BindLv_vUserPrjGrant();
            }
        }

        private void btnSelectPrj_Click(object sender, EventArgs e)
        {
            SelectProject();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvvUserPrjGrant_DoubleClick(object sender, EventArgs e)
        {
            SelectProject();
        }
        private void SelectProject()
        {
            long lngmId = GetCurrKey(lvvUserPrjGrant);
            if (lngmId == 0) return;
            clsUserPrjGrantEN objUserPrjGrant = clsUserPrjGrantWApi.GetObjBymId(lngmId);
            //if (clsSysParaEN.bolIsUseXmlDataSource == true)
            //{
            //    objUserPrjGrant.GetUserPrjGrantForXml();
            //}
            //else
            //{
            //    objUserPrjGrant.GetUserPrjGrant();
            //}
            //clsFieldSetEN.arrFieldObjLst = null;
            //clsFieldSetEN.arrFieldTabObjLst = null;
            clsPubVar.arrUserCodePathENObjLst = null;
            clsSysParaEN.CurrSelPrjId = objUserPrjGrant.PrjId;
            clsSysParaEN.strUserRoleId = objUserPrjGrant.RoleId;
            clsPubVar.CurrSelPrjId = objUserPrjGrant.PrjId;
            clsPubVar.CurrPrjDataBaseId = clsUserDefaPrjDataBaseExWApi.GetPrjDataBaseIdByPrjIdAndUserId(clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId);
               
            clsPubVar.objCurrSelProjectEN = clsProjectsWApi.GetObjByPrjId( clsSysParaEN.CurrSelPrjId);
                  
            if (clsSysParaEN.bolIsUseXmlDataSource == false)
            {
                clsUserLogExWApi.SetUsedLog(clsSysParaEN.strUserId, "Project", clsPubVar.CurrSelPrjId);
                try
                {
                    //访问数增1
                    objUserPrjGrant.VisitedNum++;
                    objUserPrjGrant.sfUpdFldSetStr = objUserPrjGrant.getsfUpdFldSetStr();
                    objUserPrjGrant.Update();
                }
                catch (Exception objException)
                {
                    MessageBox.Show("修改访问次数不成功!\r\n" + objException.Message);
                }
            }
            if (clsPubVar.objMainForm == null)
            {
                clsPubVar.objMainForm = new MdiForm();
            }

            clsPubVar.objMainForm.DispMenu();
            clsPubVar.bolIsDispMenu = true;
            if (objMdiForm != null)
            {
                objMdiForm.SetPrjStatus();
            }
            this.Close();
        }
    }
}