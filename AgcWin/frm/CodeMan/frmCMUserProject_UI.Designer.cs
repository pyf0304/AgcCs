
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCMUserProjectDA1
 界面名:frmCMUserProject_QU_LV(00050261)
 生成代码版本:2019.11.08.1
 生成日期:2019/11/08 12:20:30
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:代码管理
 模块英文名:CodeMan
 框架-层名:Win界面层_UI_设计(WinViewCode_UI_Design)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
namespace AGC
{
 /// <summary>
 ///		frmCMUserProject_UI 的摘要说明。
 /// </summary>
partial class frmCMUserProject_UI
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
this.lblUserId = new System.Windows.Forms.Label();
this.cboUserId = new System.Windows.Forms.ComboBox();
this.lblCmPrjId = new System.Windows.Forms.Label();
this.cboCmPrjId = new System.Windows.Forms.ComboBox();
this.lblProjectPath = new System.Windows.Forms.Label();
this.txtProjectPath = new System.Windows.Forms.TextBox();
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
this.lblUserId.Text = "用户Id";
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
// lblCmPrjId
//
this.lblCmPrjId.Location = new System.Drawing.Point(260, 10);
this.lblCmPrjId.Name = "lblCmPrjId";
this.lblCmPrjId.Size = new System.Drawing.Size(70, 18);
this.lblCmPrjId.TabIndex = 3;
this.lblCmPrjId.Text = "CM工程";
//
// cboCmPrjId
//
this.cboCmPrjId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
this.cboCmPrjId.Location = new System.Drawing.Point(340, 10);
this.cboCmPrjId.Name = "cboCmPrjId";
this.cboCmPrjId.Size = new System.Drawing.Size(100, 20);
this.cboCmPrjId.TabIndex = 4;
this.cboCmPrjId.Text = "";
//
// lblProjectPath
//
this.lblProjectPath.Location = new System.Drawing.Point(10, 40);
this.lblProjectPath.Name = "lblProjectPath";
this.lblProjectPath.Size = new System.Drawing.Size(70, 18);
this.lblProjectPath.TabIndex = 5;
this.lblProjectPath.Text = "工程路径";
//
// txtProjectPath
//
this.txtProjectPath.Location = new System.Drawing.Point(90, 40);
this.txtProjectPath.Name = "txtProjectPath";
this.txtProjectPath.Size = new System.Drawing.Size(100, 20);
this.txtProjectPath.TabIndex = 6;
this.txtProjectPath.Text = "";
//
// lblUpdDate
//
this.lblUpdDate.Location = new System.Drawing.Point(260, 40);
this.lblUpdDate.Name = "lblUpdDate";
this.lblUpdDate.Size = new System.Drawing.Size(70, 18);
this.lblUpdDate.TabIndex = 7;
this.lblUpdDate.Text = "修改日期";
//
// txtUpdDate
//
this.txtUpdDate.Location = new System.Drawing.Point(340, 40);
this.txtUpdDate.Name = "txtUpdDate";
this.txtUpdDate.Size = new System.Drawing.Size(100, 20);
this.txtUpdDate.TabIndex = 8;
this.txtUpdDate.Text = "";
//
// lblUpdUserId
//
this.lblUpdUserId.Location = new System.Drawing.Point(10, 70);
this.lblUpdUserId.Name = "lblUpdUserId";
this.lblUpdUserId.Size = new System.Drawing.Size(70, 18);
this.lblUpdUserId.TabIndex = 9;
this.lblUpdUserId.Text = "修改用户Id";
//
// txtUpdUserId
//
this.txtUpdUserId.Location = new System.Drawing.Point(90, 70);
this.txtUpdUserId.Name = "txtUpdUserId";
this.txtUpdUserId.Size = new System.Drawing.Size(100, 20);
this.txtUpdUserId.TabIndex = 10;
this.txtUpdUserId.Text = "";
//
// lblMemo
//
this.lblMemo.Location = new System.Drawing.Point(260, 70);
this.lblMemo.Name = "lblMemo";
this.lblMemo.Size = new System.Drawing.Size(70, 18);
this.lblMemo.TabIndex = 11;
this.lblMemo.Text = "说明";
//
// txtMemo
//
this.txtMemo.Location = new System.Drawing.Point(340, 70);
this.txtMemo.Name = "txtMemo";
this.txtMemo.Size = new System.Drawing.Size(100, 20);
this.txtMemo.TabIndex = 12;
this.txtMemo.Text = "";
// 
// btnOKUpd
// 
this.btnOKUpd.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
this.btnOKUpd.Location = new System.Drawing.Point(125, 130);
this.btnOKUpd.Name = "btnOKUpd";
this.btnOKUpd.Size = new System.Drawing.Size(80, 30);
this.btnOKUpd.TabIndex = 13;
this.btnOKUpd.Text = "添加";
this.btnOKUpd.Click += new System.EventHandler(this.btnOKUpd_Click);
// 
// btnClose
// 
this.btnClose.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
this.btnClose.Location = new System.Drawing.Point(245, 130);
this.btnClose.Name = "btnClose";
this.btnClose.Size = new System.Drawing.Size(80, 30);
this.btnClose.TabIndex = 14;
this.btnClose.Text = "关闭";
this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
// 
// lblMsg
// 
this.lblMsg.Location = new System.Drawing.Point(125, 160);
this.lblMsg.Name = "lblMsg";
this.lblMsg.Size = new System.Drawing.Size(128, 16);
this.lblMsg.TabIndex = 15;
// 
// frmCMUserProject_UI
// 
this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
this.ClientSize = new System.Drawing.Size(530, 280);
this.Controls.Add(this.lblUserId);
this.Controls.Add(this.cboUserId);
this.Controls.Add(this.lblCmPrjId);
this.Controls.Add(this.cboCmPrjId);
this.Controls.Add(this.lblProjectPath);
this.Controls.Add(this.txtProjectPath);
this.Controls.Add(this.lblUpdDate);
this.Controls.Add(this.txtUpdDate);
this.Controls.Add(this.lblUpdUserId);
this.Controls.Add(this.txtUpdUserId);
this.Controls.Add(this.lblMemo);
this.Controls.Add(this.txtMemo);
this.Controls.Add(this.btnClose);
this.Controls.Add(this.btnOKUpd);
this.Controls.Add(this.lblMsg);
this.Name = "frmCMUserProject_UI";
this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
this.Text = "frmCMUserProject_UI";
this.Load += new System.EventHandler(this.frmCMUserProject_UI_Load);
this.ResumeLayout(false);
}
#endregion
private System.Windows.Forms.Label lblUserId;
private System.Windows.Forms.ComboBox cboUserId;
private System.Windows.Forms.Label lblCmPrjId;
private System.Windows.Forms.ComboBox cboCmPrjId;
private System.Windows.Forms.Label lblProjectPath;
private System.Windows.Forms.TextBox txtProjectPath;
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