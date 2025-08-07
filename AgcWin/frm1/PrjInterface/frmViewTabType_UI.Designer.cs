
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:
 表名:ViewTabType
 生成代码版本:2018.04.05.1
 生成日期:2018/04/06 03:51:14
 生成者:
 工程名称:AGC
 工程ID:0005
 模块中文名:界面管理
 模块英文名:PrjInterface
 框架-层名:Win界面层
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2017.11.28.01
      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
namespace AGC
{
 /// <summary>
 ///		frmViewTabType_UI 的摘要说明。
 /// </summary>
partial class frmViewTabType_UI
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
this.lblViewTabTypeId = new System.Windows.Forms.Label();
this.txtViewTabTypeId = new System.Windows.Forms.TextBox();
this.lblViewTabTypeName = new System.Windows.Forms.Label();
this.txtViewTabTypeName = new System.Windows.Forms.TextBox();
this.lblTabTypeFunction = new System.Windows.Forms.Label();
this.txtTabTypeFunction = new System.Windows.Forms.TextBox();
this.lblMsg = new System.Windows.Forms.Label();
this.btnOKUpd = new System.Windows.Forms.Button();
this.btnClose = new System.Windows.Forms.Button();
this.SuspendLayout();
//
// lblViewTabTypeId
//
this.lblViewTabTypeId.Location = new System.Drawing.Point(10, 10);
this.lblViewTabTypeId.Name = "lblViewTabTypeId";
this.lblViewTabTypeId.Size = new System.Drawing.Size(70, 18);
this.lblViewTabTypeId.TabIndex = 1;
this.lblViewTabTypeId.Text = "界面表类型码";
//
// txtViewTabTypeId
//
this.txtViewTabTypeId.Location = new System.Drawing.Point(90, 10);
this.txtViewTabTypeId.Name = "txtViewTabTypeId";
this.txtViewTabTypeId.Size = new System.Drawing.Size(100, 20);
this.txtViewTabTypeId.TabIndex = 2;
this.txtViewTabTypeId.Text = "";
//
// lblViewTabTypeName
//
this.lblViewTabTypeName.Location = new System.Drawing.Point(260, 10);
this.lblViewTabTypeName.Name = "lblViewTabTypeName";
this.lblViewTabTypeName.Size = new System.Drawing.Size(70, 18);
this.lblViewTabTypeName.TabIndex = 3;
this.lblViewTabTypeName.Text = "ViewTabTypeName";
//
// txtViewTabTypeName
//
this.txtViewTabTypeName.Location = new System.Drawing.Point(340, 10);
this.txtViewTabTypeName.Name = "txtViewTabTypeName";
this.txtViewTabTypeName.Size = new System.Drawing.Size(100, 20);
this.txtViewTabTypeName.TabIndex = 4;
this.txtViewTabTypeName.Text = "";
//
// lblTabTypeFunction
//
this.lblTabTypeFunction.Location = new System.Drawing.Point(10, 40);
this.lblTabTypeFunction.Name = "lblTabTypeFunction";
this.lblTabTypeFunction.Size = new System.Drawing.Size(70, 18);
this.lblTabTypeFunction.TabIndex = 5;
this.lblTabTypeFunction.Text = "TabTypeFunction";
//
// txtTabTypeFunction
//
this.txtTabTypeFunction.Location = new System.Drawing.Point(90, 40);
this.txtTabTypeFunction.Name = "txtTabTypeFunction";
this.txtTabTypeFunction.Size = new System.Drawing.Size(100, 20);
this.txtTabTypeFunction.TabIndex = 6;
this.txtTabTypeFunction.Text = "";
// 
// btnOKUpd
// 
this.btnOKUpd.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
this.btnOKUpd.Location = new System.Drawing.Point(125, 100);
this.btnOKUpd.Name = "btnOKUpd";
this.btnOKUpd.Size = new System.Drawing.Size(80, 30);
this.btnOKUpd.TabIndex = 7;
this.btnOKUpd.Text = "添加";
this.btnOKUpd.Click += new System.EventHandler(this.btnOKUpd_Click);
// 
// btnClose
// 
this.btnClose.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
this.btnClose.Location = new System.Drawing.Point(245, 100);
this.btnClose.Name = "btnClose";
this.btnClose.Size = new System.Drawing.Size(80, 30);
this.btnClose.TabIndex = 8;
this.btnClose.Text = "关闭";
this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
// 
// lblMsg
// 
this.lblMsg.Location = new System.Drawing.Point(125, 130);
this.lblMsg.Name = "lblMsg";
this.lblMsg.Size = new System.Drawing.Size(128, 16);
this.lblMsg.TabIndex = 9;
// 
// frmViewTabType_UI
// 
this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
this.ClientSize = new System.Drawing.Size(530, 250);
this.Controls.Add(this.lblViewTabTypeId);
this.Controls.Add(this.txtViewTabTypeId);
this.Controls.Add(this.lblViewTabTypeName);
this.Controls.Add(this.txtViewTabTypeName);
this.Controls.Add(this.lblTabTypeFunction);
this.Controls.Add(this.txtTabTypeFunction);
this.Controls.Add(this.btnClose);
this.Controls.Add(this.btnOKUpd);
this.Controls.Add(this.lblMsg);
this.Name = "frmViewTabType_UI";
this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
this.Text = "frmViewTabType_UI";
this.Load += new System.EventHandler(this.frmViewTabType_UI_Load);
this.ResumeLayout(false);
}
#endregion
private System.Windows.Forms.Label lblViewTabTypeId;
private System.Windows.Forms.TextBox txtViewTabTypeId;
private System.Windows.Forms.Label lblViewTabTypeName;
private System.Windows.Forms.TextBox txtViewTabTypeName;
private System.Windows.Forms.Label lblTabTypeFunction;
private System.Windows.Forms.TextBox txtTabTypeFunction;
private System.Windows.Forms.Label lblMsg; 
private System.Windows.Forms.Button btnOKUpd;
private System.Windows.Forms.Button btnClose;
}
}