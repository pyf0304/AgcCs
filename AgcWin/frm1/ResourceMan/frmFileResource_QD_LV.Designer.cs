
namespace AGC
{
 /// <summary>
 ///		frmFileResource_QD_LV 的摘要说明。
 /// </summary>
partial class frmFileResource_QD_LV
{
 /// <summary> 
 /// 必需的设计器变量。
 /// </summary>
private System.ComponentModel.Container components = null;

 /// <summary> 
 /// 清理所有正在使用的资源。
 /// </summary>
protected override void Dispose( bool disposing)
{
if( disposing)
{
if(components != null)
{
components.Dispose();
}
}
base.Dispose( disposing);
}
#region 组件设计器生成的代码
 /// <summary> 
 /// 设计器支持所需的方法 - 不要使用代码编辑器 
 /// 修改此方法的内容。
 /// </summary>
private void InitializeComponent()
{
            this.lblFileDirName = new System.Windows.Forms.Label();
            this.txtFileDirName = new System.Windows.Forms.TextBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblExtension = new System.Windows.Forms.Label();
            this.txtExtension = new System.Windows.Forms.TextBox();
            this.lblCmPrjId = new System.Windows.Forms.Label();
            this.cboCmPrjId = new System.Windows.Forms.ComboBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelRec = new System.Windows.Forms.Button();
            this.btnExportExcel4Dg = new System.Windows.Forms.Button();
            this.lblRecNum = new System.Windows.Forms.Label();
            this.lvvFileResource = new System.Windows.Forms.ListView();
            this.gbQueryCondition = new System.Windows.Forms.GroupBox();
            this.gbQueryCondition.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFileDirName
            // 
            this.lblFileDirName.Location = new System.Drawing.Point(10, 18);
            this.lblFileDirName.Name = "lblFileDirName";
            this.lblFileDirName.Size = new System.Drawing.Size(70, 18);
            this.lblFileDirName.TabIndex = 1;
            this.lblFileDirName.Text = "文件目录名";
            // 
            // txtFileDirName
            // 
            this.txtFileDirName.Location = new System.Drawing.Point(90, 18);
            this.txtFileDirName.Name = "txtFileDirName";
            this.txtFileDirName.Size = new System.Drawing.Size(164, 23);
            this.txtFileDirName.TabIndex = 2;
            // 
            // lblFileName
            // 
            this.lblFileName.Location = new System.Drawing.Point(260, 18);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(51, 18);
            this.lblFileName.TabIndex = 3;
            this.lblFileName.Text = "文件名";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(317, 18);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(187, 23);
            this.txtFileName.TabIndex = 4;
            // 
            // lblExtension
            // 
            this.lblExtension.Location = new System.Drawing.Point(510, 18);
            this.lblExtension.Name = "lblExtension";
            this.lblExtension.Size = new System.Drawing.Size(51, 18);
            this.lblExtension.TabIndex = 5;
            this.lblExtension.Text = "扩展名";
            // 
            // txtExtension
            // 
            this.txtExtension.Location = new System.Drawing.Point(567, 18);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(100, 23);
            this.txtExtension.TabIndex = 6;
            // 
            // lblCmPrjId
            // 
            this.lblCmPrjId.Location = new System.Drawing.Point(674, 19);
            this.lblCmPrjId.Name = "lblCmPrjId";
            this.lblCmPrjId.Size = new System.Drawing.Size(53, 18);
            this.lblCmPrjId.TabIndex = 7;
            this.lblCmPrjId.Text = "CM工程";
            // 
            // cboCmPrjId
            // 
            this.cboCmPrjId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCmPrjId.Location = new System.Drawing.Point(733, 18);
            this.cboCmPrjId.Name = "cboCmPrjId";
            this.cboCmPrjId.Size = new System.Drawing.Size(116, 22);
            this.cboCmPrjId.TabIndex = 8;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(855, 15);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(80, 26);
            this.btnQuery.TabIndex = 16;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.Location = new System.Drawing.Point(192, 70);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(128, 16);
            this.lblMsg.TabIndex = 11;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(496, 63);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 26);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(408, 63);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 26);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "添加";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelRec
            // 
            this.btnDelRec.Location = new System.Drawing.Point(576, 63);
            this.btnDelRec.Name = "btnDelRec";
            this.btnDelRec.Size = new System.Drawing.Size(80, 26);
            this.btnDelRec.TabIndex = 14;
            this.btnDelRec.Text = "删除记录";
            this.btnDelRec.Click += new System.EventHandler(this.btnDelRec_Click);
            // 
            // btnExportExcel4Dg
            // 
            this.btnExportExcel4Dg.Location = new System.Drawing.Point(664, 63);
            this.btnExportExcel4Dg.Name = "btnExportExcel4Dg";
            this.btnExportExcel4Dg.Size = new System.Drawing.Size(80, 26);
            this.btnExportExcel4Dg.TabIndex = 15;
            this.btnExportExcel4Dg.Text = "导出Excel";
            this.btnExportExcel4Dg.Click += new System.EventHandler(this.btnExportExcel4Dg_Click);
            // 
            // lblRecNum
            // 
            this.lblRecNum.Location = new System.Drawing.Point(941, 18);
            this.lblRecNum.Name = "lblRecNum";
            this.lblRecNum.Size = new System.Drawing.Size(112, 16);
            this.lblRecNum.TabIndex = 17;
            this.lblRecNum.Text = "记录数:";
            // 
            // lvvFileResource
            // 
            this.lvvFileResource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvvFileResource.HideSelection = false;
            this.lvvFileResource.Location = new System.Drawing.Point(0, 101);
            this.lvvFileResource.Name = "lvvFileResource";
            this.lvvFileResource.Size = new System.Drawing.Size(1184, 599);
            this.lvvFileResource.TabIndex = 18;
            this.lvvFileResource.UseCompatibleStateImageBehavior = false;
            this.lvvFileResource.View = System.Windows.Forms.View.Details;
            this.lvvFileResource.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvvFileResource_ColumnClick);
            this.lvvFileResource.Click += new System.EventHandler(this.lvvFileResource_Click);
            // 
            // gbQueryCondition
            // 
            this.gbQueryCondition.Controls.Add(this.lblFileDirName);
            this.gbQueryCondition.Controls.Add(this.txtFileDirName);
            this.gbQueryCondition.Controls.Add(this.lblFileName);
            this.gbQueryCondition.Controls.Add(this.txtFileName);
            this.gbQueryCondition.Controls.Add(this.lblExtension);
            this.gbQueryCondition.Controls.Add(this.txtExtension);
            this.gbQueryCondition.Controls.Add(this.lblCmPrjId);
            this.gbQueryCondition.Controls.Add(this.cboCmPrjId);
            this.gbQueryCondition.Controls.Add(this.btnExportExcel4Dg);
            this.gbQueryCondition.Controls.Add(this.btnQuery);
            this.gbQueryCondition.Controls.Add(this.btnUpdate);
            this.gbQueryCondition.Controls.Add(this.btnAdd);
            this.gbQueryCondition.Controls.Add(this.btnDelRec);
            this.gbQueryCondition.Controls.Add(this.lblMsg);
            this.gbQueryCondition.Controls.Add(this.lblRecNum);
            this.gbQueryCondition.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbQueryCondition.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbQueryCondition.Location = new System.Drawing.Point(0, 0);
            this.gbQueryCondition.Name = "gbQueryCondition";
            this.gbQueryCondition.Size = new System.Drawing.Size(1184, 101);
            this.gbQueryCondition.TabIndex = 19;
            this.gbQueryCondition.TabStop = false;
            this.gbQueryCondition.Text = "查询条件";
            // 
            // frmFileResource_QD_LV
            // 
            this.ClientSize = new System.Drawing.Size(1184, 700);
            this.Controls.Add(this.lvvFileResource);
            this.Controls.Add(this.gbQueryCondition);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "frmFileResource_QD_LV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFileResource_QD_LV";
            this.Load += new System.EventHandler(this.frmFileResource_QD_Load);
            this.gbQueryCondition.ResumeLayout(false);
            this.gbQueryCondition.PerformLayout();
            this.ResumeLayout(false);

}
#endregion
private System.Windows.Forms.Label lblFileDirName;
private System.Windows.Forms.TextBox txtFileDirName;
private System.Windows.Forms.Label lblFileName;
private System.Windows.Forms.TextBox txtFileName;
private System.Windows.Forms.Label lblExtension;
private System.Windows.Forms.TextBox txtExtension;
private System.Windows.Forms.Label lblCmPrjId;
private System.Windows.Forms.ComboBox cboCmPrjId;
private System.Windows.Forms.Button btnQuery;
private System.Windows.Forms.Label lblMsg; 
private System.Windows.Forms.Button btnUpdate;
private System.Windows.Forms.Button btnAdd;
private System.Windows.Forms.Button btnDelRec;
private System.Windows.Forms.Button btnExportExcel4Dg;
private System.Windows.Forms.Label lblRecNum;
private System.Windows.Forms.GroupBox gbQueryCondition;
private System.Windows.Forms.ListView lvvFileResource;
}
}