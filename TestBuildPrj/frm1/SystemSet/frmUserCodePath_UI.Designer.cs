
///----------------------
///生成代码版本：2012.01.02.1
///生成日期：2012/10/17
///生成者：潘以锋
///工程名称：AGC_CSV7
///工程ID：0005
///模块中文名：系统设置
///模块英文名：SystemSet
///注意：1、需要数据底层（PubDataBase.dll）的版本：2011.05.08.1
///       2、需要公共函数层（TzPubFunction.dll）的版本：2011.05.08.1
///========================
namespace AGC_CSV7
{
/// <summary>
///		frmUserCodePath_UI 的摘要说明。
/// </summary>
partial class frmUserCodePath_UI
{
/// <summary> 
/// 必需的设计器变量。
/// </summary>
private System.ComponentModel.Container components = null;

/// <summary> 
/// 清理所有正在使用的资源。
/// </summary>
protected override void Dispose( bool disposing )
{
if( disposing )
{
if(components != null)
{
components.Dispose();
}
}
base.Dispose( disposing );
}
#region 组件设计器生成的代码
/// <summary> 
/// 设计器支持所需的方法 - 不要使用代码编辑器 
/// 修改此方法的内容。
/// </summary>
private void InitializeComponent()
{
this.lblUserId = new System.Windows.Forms.Label();
this.cboUserId = new System.Windows.Forms.ComboBox();
this.lblPrjId = new System.Windows.Forms.Label();
this.cboPrjId = new System.Windows.Forms.ComboBox();
this.lblCodeTypeId = new System.Windows.Forms.Label();
this.cboCodeTypeId = new System.Windows.Forms.ComboBox();
this.lblCodePath = new System.Windows.Forms.Label();
this.txtCodePath = new System.Windows.Forms.TextBox();
this.lblUpdDate = new System.Windows.Forms.Label();
this.txtUpdDate = new System.Windows.Forms.TextBox();
this.lblUpdUserId = new System.Windows.Forms.Label();
this.txtUpdUserId = new System.Windows.Forms.TextBox();
this.lblMemo = new System.Windows.Forms.Label();
this.txtMemo = new System.Windows.Forms.TextBox();
this.lblMsg = new System.Windows.Forms.Label();
this.btnOKUpd = new System.Windows.Forms.Button();
this.btnClose = new System.Windows.Forms.Button();
this.SuspendLayout();
//
// lblUserId
//
this.lblUserId.Location = new System.Drawing.Point(10, 10);
this.lblUserId.Name = "lblUserId";
this.lblUserId.Size = new System.Drawing.Size(70, 18);
this.lblUserId.TabIndex = 1;
this.lblUserId.Text = "用户ID";
//
// cboUserId
//
this.cboUserId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
this.cboUserId.Location = new System.Drawing.Point(90, 10);
this.cboUserId.Name = "cboUserId";
this.cboUserId.Size = new System.Drawing.Size(100, 20);
this.cboUserId.TabIndex = 2;
this.cboUserId.Text = "";
//
// lblPrjId
//
this.lblPrjId.Location = new System.Drawing.Point(260, 10);
this.lblPrjId.Name = "lblPrjId";
this.lblPrjId.Size = new System.Drawing.Size(70, 18);
this.lblPrjId.TabIndex = 3;
this.lblPrjId.Text = "工程ID";
//
// cboPrjId
//
this.cboPrjId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
this.cboPrjId.Location = new System.Drawing.Point(340, 10);
this.cboPrjId.Name = "cboPrjId";
this.cboPrjId.Size = new System.Drawing.Size(100, 20);
this.cboPrjId.TabIndex = 4;
this.cboPrjId.Text = "";
//
// lblCodeTypeId
//
this.lblCodeTypeId.Location = new System.Drawing.Point(10, 40);
this.lblCodeTypeId.Name = "lblCodeTypeId";
this.lblCodeTypeId.Size = new System.Drawing.Size(70, 18);
this.lblCodeTypeId.TabIndex = 5;
this.lblCodeTypeId.Text = "代码类型Id";
//
// cboCodeTypeId
//
this.cboCodeTypeId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
this.cboCodeTypeId.Location = new System.Drawing.Point(90, 40);
this.cboCodeTypeId.Name = "cboCodeTypeId";
this.cboCodeTypeId.Size = new System.Drawing.Size(100, 20);
this.cboCodeTypeId.TabIndex = 6;
this.cboCodeTypeId.Text = "";
//
// lblCodePath
//
this.lblCodePath.Location = new System.Drawing.Point(260, 40);
this.lblCodePath.Name = "lblCodePath";
this.lblCodePath.Size = new System.Drawing.Size(70, 18);
this.lblCodePath.TabIndex = 7;
this.lblCodePath.Text = "代码路径";
//
// txtCodePath
//
this.txtCodePath.Location = new System.Drawing.Point(340, 40);
this.txtCodePath.Name = "txtCodePath";
this.txtCodePath.Size = new System.Drawing.Size(100, 20);
this.txtCodePath.TabIndex = 8;
this.txtCodePath.Text = "";
//
// lblUpdDate
//
this.lblUpdDate.Location = new System.Drawing.Point(10, 70);
this.lblUpdDate.Name = "lblUpdDate";
this.lblUpdDate.Size = new System.Drawing.Size(70, 18);
this.lblUpdDate.TabIndex = 9;
this.lblUpdDate.Text = "修改日期";
//
// txtUpdDate
//
this.txtUpdDate.Location = new System.Drawing.Point(90, 70);
this.txtUpdDate.Name = "txtUpdDate";
this.txtUpdDate.Size = new System.Drawing.Size(100, 20);
this.txtUpdDate.TabIndex = 10;
this.txtUpdDate.Text = "";
//
// lblUpdUserId
//
this.lblUpdUserId.Location = new System.Drawing.Point(260, 70);
this.lblUpdUserId.Name = "lblUpdUserId";
this.lblUpdUserId.Size = new System.Drawing.Size(70, 18);
this.lblUpdUserId.TabIndex = 11;
this.lblUpdUserId.Text = "修改用户Id";
//
// txtUpdUserId
//
this.txtUpdUserId.Location = new System.Drawing.Point(340, 70);
this.txtUpdUserId.Name = "txtUpdUserId";
this.txtUpdUserId.Size = new System.Drawing.Size(100, 20);
this.txtUpdUserId.TabIndex = 12;
this.txtUpdUserId.Text = "";
//
// lblMemo
//
this.lblMemo.Location = new System.Drawing.Point(10, 100);
this.lblMemo.Name = "lblMemo";
this.lblMemo.Size = new System.Drawing.Size(70, 18);
this.lblMemo.TabIndex = 13;
this.lblMemo.Text = "说明";
//
// txtMemo
//
this.txtMemo.Location = new System.Drawing.Point(90, 100);
this.txtMemo.Name = "txtMemo";
this.txtMemo.Size = new System.Drawing.Size(100, 20);
this.txtMemo.TabIndex = 14;
this.txtMemo.Text = "";
// 
// btnOKUpd
// 
this.btnOKUpd.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
this.btnOKUpd.Location = new System.Drawing.Point(125, 100);
this.btnOKUpd.Name = "btnOKUpd";
this.btnOKUpd.Size = new System.Drawing.Size(80, 30);
this.btnOKUpd.TabIndex = 15;
this.btnOKUpd.Text = "添加";
this.btnOKUpd.Click += new System.EventHandler(this.btnOKUpd_Click);
// 
// btnClose
// 
this.btnClose.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
this.btnClose.Location = new System.Drawing.Point(245, 100);
this.btnClose.Name = "btnClose";
this.btnClose.Size = new System.Drawing.Size(80, 30);
this.btnClose.TabIndex = 16;
this.btnClose.Text = "关闭";
this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
// 
// lblMsg
// 
this.lblMsg.Location = new System.Drawing.Point(125, 130);
this.lblMsg.Name = "lblMsg";
this.lblMsg.Size = new System.Drawing.Size(128, 16);
this.lblMsg.TabIndex = 17;
// 
// frmUserCodePath_UI
// 
this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
this.ClientSize = new System.Drawing.Size(530, 170);
this.Controls.Add(this.lblUserId);
this.Controls.Add(this.cboUserId);
this.Controls.Add(this.lblPrjId);
this.Controls.Add(this.cboPrjId);
this.Controls.Add(this.lblCodeTypeId);
this.Controls.Add(this.cboCodeTypeId);
this.Controls.Add(this.lblCodePath);
this.Controls.Add(this.txtCodePath);
this.Controls.Add(this.lblUpdDate);
this.Controls.Add(this.txtUpdDate);
this.Controls.Add(this.lblUpdUserId);
this.Controls.Add(this.txtUpdUserId);
this.Controls.Add(this.lblMemo);
this.Controls.Add(this.txtMemo);
this.Controls.Add(this.btnClose);
this.Controls.Add(this.btnOKUpd);
this.Controls.Add(this.lblMsg);
this.Name = "frmUserCodePath_UI";
this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
this.Text = "frmUserCodePath_UI";
this.Load += new System.EventHandler(this.frmUserCodePath_UI_Load);
this.ResumeLayout(false);
}
#endregion
private System.Windows.Forms.Label lblUserId;
private System.Windows.Forms.ComboBox cboUserId;
private System.Windows.Forms.Label lblPrjId;
private System.Windows.Forms.ComboBox cboPrjId;
private System.Windows.Forms.Label lblCodeTypeId;
private System.Windows.Forms.ComboBox cboCodeTypeId;
private System.Windows.Forms.Label lblCodePath;
private System.Windows.Forms.TextBox txtCodePath;
private System.Windows.Forms.Label lblUpdDate;
private System.Windows.Forms.TextBox txtUpdDate;
private System.Windows.Forms.Label lblUpdUserId;
private System.Windows.Forms.TextBox txtUpdUserId;
private System.Windows.Forms.Label lblMemo;
private System.Windows.Forms.TextBox txtMemo;
private System.Windows.Forms.Label lblMsg; 
private System.Windows.Forms.Button btnOKUpd;
private System.Windows.Forms.Button btnClose;
}
}