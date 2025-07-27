namespace AGC_CSWin
{
    /// <summary>
    ///		frmUserPrjGrant_QD_LV 的摘要说明。
    /// </summary>
    partial class frmUserPrjGrant_SelectPrj
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.Container components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        #region 组件设计器生成的代码
        /// <summary> 
        /// 设计器支持所需的方法 - 不要使用代码编辑器 
        /// 修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSelectPrj = new System.Windows.Forms.Button();
            this.lblRecNum = new System.Windows.Forms.Label();
            this.lvvUserPrjGrant = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelectPrj
            // 
            this.btnSelectPrj.Location = new System.Drawing.Point(495, 411);
            this.btnSelectPrj.Name = "btnSelectPrj";
            this.btnSelectPrj.Size = new System.Drawing.Size(80, 26);
            this.btnSelectPrj.TabIndex = 11;
            this.btnSelectPrj.Text = "确定";
            this.btnSelectPrj.Click += new System.EventHandler(this.btnSelectPrj_Click);
            // 
            // lblRecNum
            // 
            this.lblRecNum.Location = new System.Drawing.Point(25, 411);
            this.lblRecNum.Name = "lblRecNum";
            this.lblRecNum.Size = new System.Drawing.Size(112, 16);
            this.lblRecNum.TabIndex = 13;
            this.lblRecNum.Text = "记录数：";
            // 
            // lvvUserPrjGrant
            // 
            this.lvvUserPrjGrant.FullRowSelect = true;
            this.lvvUserPrjGrant.Location = new System.Drawing.Point(28, 105);
            this.lvvUserPrjGrant.Name = "lvvUserPrjGrant";
            this.lvvUserPrjGrant.Size = new System.Drawing.Size(657, 289);
            this.lvvUserPrjGrant.TabIndex = 14;
            this.lvvUserPrjGrant.UseCompatibleStateImageBehavior = false;
            this.lvvUserPrjGrant.View = System.Windows.Forms.View.Details;
            this.lvvUserPrjGrant.DoubleClick += new System.EventHandler(this.lvvUserPrjGrant_DoubleClick);
            this.lvvUserPrjGrant.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvvUserPrjGrant_ColumnClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(171, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 38);
            this.label1.TabIndex = 15;
            this.label1.Text = "请选择一个工程使用系统";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(25, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "你可以对以下项目进行选择：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(591, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 26);
            this.button1.TabIndex = 17;
            this.button1.Text = "取消";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmUserPrjGrant_SelectPrj
            // 
            this.ClientSize = new System.Drawing.Size(728, 449);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectPrj);
            this.Controls.Add(this.lvvUserPrjGrant);
            this.Controls.Add(this.lblRecNum);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "frmUserPrjGrant_SelectPrj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户选择项目";
            this.Load += new System.EventHandler(this.frmUserPrjGrant_QD_Load);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Button btnSelectPrj;
        private System.Windows.Forms.Label lblRecNum;
        private System.Windows.Forms.ListView lvvUserPrjGrant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}