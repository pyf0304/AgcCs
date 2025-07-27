
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
 框架-层名:Win界面层_UI_设计(WinViewCode_UI_Design)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
namespace AGC
{
 /// <summary>
 ///		frmFileResource_UI 的摘要说明。
 /// </summary>
partial class frmFileResource_UI
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
this.lblFileLength = new System.Windows.Forms.Label();
this.txtFileLength = new System.Windows.Forms.TextBox();
this.lblFileType = new System.Windows.Forms.Label();
this.txtFileType = new System.Windows.Forms.TextBox();
this.lblCreationTime = new System.Windows.Forms.Label();
this.txtCreationTime = new System.Windows.Forms.TextBox();
this.lblLastWriteTime = new System.Windows.Forms.Label();
this.txtLastWriteTime = new System.Windows.Forms.TextBox();
this.lblCheckDateTime = new System.Windows.Forms.Label();
this.txtCheckDateTime = new System.Windows.Forms.TextBox();
this.lblInUse = new System.Windows.Forms.Label();
this.chkInUse = new System.Windows.Forms.CheckBox();
this.lblIsExistFile = new System.Windows.Forms.Label();
this.chkIsExistFile = new System.Windows.Forms.CheckBox();
this.lblPrjId = new System.Windows.Forms.Label();
this.cboPrjId = new System.Windows.Forms.ComboBox();
this.lblCmPrjId = new System.Windows.Forms.Label();
this.cboCmPrjId = new System.Windows.Forms.ComboBox();
this.lblIpAddress = new System.Windows.Forms.Label();
this.txtIpAddress = new System.Windows.Forms.TextBox();
this.lblIdFtpResource = new System.Windows.Forms.Label();
this.txtIdFtpResource = new System.Windows.Forms.TextBox();
this.lblMemo = new System.Windows.Forms.Label();
this.txtMemo = new System.Windows.Forms.TextBox();
this.lblMsg = new System.Windows.Forms.Label();
this.btnOKUpd = new System.Windows.Forms.Button();
this.btnClose = new System.Windows.Forms.Button();
this.SuspendLayout();
//
// lblFileDirName
//
this.lblFileDirName.Location = new System.Drawing.Point(10, 10);
this.lblFileDirName.Name = "lblFileDirName";
this.lblFileDirName.Size = new System.Drawing.Size(70, 18);
this.lblFileDirName.TabIndex = 1;
this.lblFileDirName.Text = "文件目录名";
//
// txtFileDirName
//
this.txtFileDirName.Location = new System.Drawing.Point(90, 10);
this.txtFileDirName.Name = "txtFileDirName";
this.txtFileDirName.Size = new System.Drawing.Size(100, 20);
this.txtFileDirName.TabIndex = 2;
this.txtFileDirName.Text = "";
//
// lblFileName
//
this.lblFileName.Location = new System.Drawing.Point(260, 10);
this.lblFileName.Name = "lblFileName";
this.lblFileName.Size = new System.Drawing.Size(70, 18);
this.lblFileName.TabIndex = 3;
this.lblFileName.Text = "文件名";
//
// txtFileName
//
this.txtFileName.Location = new System.Drawing.Point(340, 10);
this.txtFileName.Name = "txtFileName";
this.txtFileName.Size = new System.Drawing.Size(100, 20);
this.txtFileName.TabIndex = 4;
this.txtFileName.Text = "";
//
// lblExtension
//
this.lblExtension.Location = new System.Drawing.Point(10, 40);
this.lblExtension.Name = "lblExtension";
this.lblExtension.Size = new System.Drawing.Size(70, 18);
this.lblExtension.TabIndex = 5;
this.lblExtension.Text = "扩展名";
//
// txtExtension
//
this.txtExtension.Location = new System.Drawing.Point(90, 40);
this.txtExtension.Name = "txtExtension";
this.txtExtension.Size = new System.Drawing.Size(100, 20);
this.txtExtension.TabIndex = 6;
this.txtExtension.Text = "";
//
// lblFileLength
//
this.lblFileLength.Location = new System.Drawing.Point(260, 40);
this.lblFileLength.Name = "lblFileLength";
this.lblFileLength.Size = new System.Drawing.Size(70, 18);
this.lblFileLength.TabIndex = 7;
this.lblFileLength.Text = "文件长度";
//
// txtFileLength
//
this.txtFileLength.Location = new System.Drawing.Point(340, 40);
this.txtFileLength.Name = "txtFileLength";
this.txtFileLength.Size = new System.Drawing.Size(100, 20);
this.txtFileLength.TabIndex = 8;
this.txtFileLength.Text = "";
//
// lblFileType
//
this.lblFileType.Location = new System.Drawing.Point(10, 70);
this.lblFileType.Name = "lblFileType";
this.lblFileType.Size = new System.Drawing.Size(70, 18);
this.lblFileType.TabIndex = 9;
this.lblFileType.Text = "文件类型";
//
// txtFileType
//
this.txtFileType.Location = new System.Drawing.Point(90, 70);
this.txtFileType.Name = "txtFileType";
this.txtFileType.Size = new System.Drawing.Size(100, 20);
this.txtFileType.TabIndex = 10;
this.txtFileType.Text = "";
//
// lblCreationTime
//
this.lblCreationTime.Location = new System.Drawing.Point(260, 70);
this.lblCreationTime.Name = "lblCreationTime";
this.lblCreationTime.Size = new System.Drawing.Size(70, 18);
this.lblCreationTime.TabIndex = 11;
this.lblCreationTime.Text = "建立时间";
//
// txtCreationTime
//
this.txtCreationTime.Location = new System.Drawing.Point(340, 70);
this.txtCreationTime.Name = "txtCreationTime";
this.txtCreationTime.Size = new System.Drawing.Size(100, 20);
this.txtCreationTime.TabIndex = 12;
this.txtCreationTime.Text = "";
//
// lblLastWriteTime
//
this.lblLastWriteTime.Location = new System.Drawing.Point(10, 100);
this.lblLastWriteTime.Name = "lblLastWriteTime";
this.lblLastWriteTime.Size = new System.Drawing.Size(70, 18);
this.lblLastWriteTime.TabIndex = 13;
this.lblLastWriteTime.Text = "修改日期";
//
// txtLastWriteTime
//
this.txtLastWriteTime.Location = new System.Drawing.Point(90, 100);
this.txtLastWriteTime.Name = "txtLastWriteTime";
this.txtLastWriteTime.Size = new System.Drawing.Size(100, 20);
this.txtLastWriteTime.TabIndex = 14;
this.txtLastWriteTime.Text = "";
//
// lblCheckDateTime
//
this.lblCheckDateTime.Location = new System.Drawing.Point(260, 100);
this.lblCheckDateTime.Name = "lblCheckDateTime";
this.lblCheckDateTime.Size = new System.Drawing.Size(70, 18);
this.lblCheckDateTime.TabIndex = 15;
this.lblCheckDateTime.Text = "CheckDateTime";
//
// txtCheckDateTime
//
this.txtCheckDateTime.Location = new System.Drawing.Point(340, 100);
this.txtCheckDateTime.Name = "txtCheckDateTime";
this.txtCheckDateTime.Size = new System.Drawing.Size(100, 20);
this.txtCheckDateTime.TabIndex = 16;
this.txtCheckDateTime.Text = "";
//
// chkInUse
//
this.chkInUse.Location = new System.Drawing.Point(10, 130);
this.chkInUse.Name = "chkInUse";
this.chkInUse.Size = new System.Drawing.Size(100, 20);
this.chkInUse.TabIndex = 17;
this.chkInUse.Text = "是否在用";
//
// chkIsExistFile
//
this.chkIsExistFile.Location = new System.Drawing.Point(260, 130);
this.chkIsExistFile.Name = "chkIsExistFile";
this.chkIsExistFile.Size = new System.Drawing.Size(100, 20);
this.chkIsExistFile.TabIndex = 18;
this.chkIsExistFile.Text = "是否存在文件";
//
// lblPrjId
//
this.lblPrjId.Location = new System.Drawing.Point(10, 160);
this.lblPrjId.Name = "lblPrjId";
this.lblPrjId.Size = new System.Drawing.Size(70, 18);
this.lblPrjId.TabIndex = 19;
this.lblPrjId.Text = "工程ID";
//
// cboPrjId
//
this.cboPrjId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
this.cboPrjId.Location = new System.Drawing.Point(90, 160);
this.cboPrjId.Name = "cboPrjId";
this.cboPrjId.Size = new System.Drawing.Size(100, 20);
this.cboPrjId.TabIndex = 20;
this.cboPrjId.Text = "";
//
// lblCmPrjId
//
this.lblCmPrjId.Location = new System.Drawing.Point(260, 160);
this.lblCmPrjId.Name = "lblCmPrjId";
this.lblCmPrjId.Size = new System.Drawing.Size(70, 18);
this.lblCmPrjId.TabIndex = 21;
this.lblCmPrjId.Text = "CM工程Id";
//
// cboCmPrjId
//
this.cboCmPrjId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
this.cboCmPrjId.Location = new System.Drawing.Point(340, 160);
this.cboCmPrjId.Name = "cboCmPrjId";
this.cboCmPrjId.Size = new System.Drawing.Size(100, 20);
this.cboCmPrjId.TabIndex = 22;
this.cboCmPrjId.Text = "";
//
// lblIpAddress
//
this.lblIpAddress.Location = new System.Drawing.Point(10, 190);
this.lblIpAddress.Name = "lblIpAddress";
this.lblIpAddress.Size = new System.Drawing.Size(70, 18);
this.lblIpAddress.TabIndex = 23;
this.lblIpAddress.Text = "服务器";
//
// txtIpAddress
//
this.txtIpAddress.Location = new System.Drawing.Point(90, 190);
this.txtIpAddress.Name = "txtIpAddress";
this.txtIpAddress.Size = new System.Drawing.Size(100, 20);
this.txtIpAddress.TabIndex = 24;
this.txtIpAddress.Text = "";
//
// lblIdFtpResource
//
this.lblIdFtpResource.Location = new System.Drawing.Point(260, 190);
this.lblIdFtpResource.Name = "lblIdFtpResource";
this.lblIdFtpResource.Size = new System.Drawing.Size(70, 18);
this.lblIdFtpResource.TabIndex = 25;
this.lblIdFtpResource.Text = "FTP资源流水号";
//
// txtIdFtpResource
//
this.txtIdFtpResource.Location = new System.Drawing.Point(340, 190);
this.txtIdFtpResource.Name = "txtIdFtpResource";
this.txtIdFtpResource.Size = new System.Drawing.Size(100, 20);
this.txtIdFtpResource.TabIndex = 26;
this.txtIdFtpResource.Text = "";
//
// lblMemo
//
this.lblMemo.Location = new System.Drawing.Point(10, 220);
this.lblMemo.Name = "lblMemo";
this.lblMemo.Size = new System.Drawing.Size(70, 18);
this.lblMemo.TabIndex = 27;
this.lblMemo.Text = "说明";
//
// txtMemo
//
this.txtMemo.Location = new System.Drawing.Point(90, 220);
this.txtMemo.Name = "txtMemo";
this.txtMemo.Size = new System.Drawing.Size(100, 20);
this.txtMemo.TabIndex = 28;
this.txtMemo.Text = "";
// 
// btnOKUpd
// 
this.btnOKUpd.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
this.btnOKUpd.Location = new System.Drawing.Point(125, 280);
this.btnOKUpd.Name = "btnOKUpd";
this.btnOKUpd.Size = new System.Drawing.Size(80, 30);
this.btnOKUpd.TabIndex = 29;
this.btnOKUpd.Text = "添加";
this.btnOKUpd.Click += new System.EventHandler(this.btnOKUpd_Click);
// 
// btnClose
// 
this.btnClose.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
this.btnClose.Location = new System.Drawing.Point(245, 280);
this.btnClose.Name = "btnClose";
this.btnClose.Size = new System.Drawing.Size(80, 30);
this.btnClose.TabIndex = 30;
this.btnClose.Text = "关闭";
this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
// 
// lblMsg
// 
this.lblMsg.Location = new System.Drawing.Point(125, 310);
this.lblMsg.Name = "lblMsg";
this.lblMsg.Size = new System.Drawing.Size(128, 16);
this.lblMsg.TabIndex = 31;
// 
// frmFileResource_UI
// 
this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
this.ClientSize = new System.Drawing.Size(530, 430);
this.Controls.Add(this.lblFileDirName);
this.Controls.Add(this.txtFileDirName);
this.Controls.Add(this.lblFileName);
this.Controls.Add(this.txtFileName);
this.Controls.Add(this.lblExtension);
this.Controls.Add(this.txtExtension);
this.Controls.Add(this.lblFileLength);
this.Controls.Add(this.txtFileLength);
this.Controls.Add(this.lblFileType);
this.Controls.Add(this.txtFileType);
this.Controls.Add(this.lblCreationTime);
this.Controls.Add(this.txtCreationTime);
this.Controls.Add(this.lblLastWriteTime);
this.Controls.Add(this.txtLastWriteTime);
this.Controls.Add(this.lblCheckDateTime);
this.Controls.Add(this.txtCheckDateTime);
this.Controls.Add(this.chkInUse);
this.Controls.Add(this.chkIsExistFile);
this.Controls.Add(this.lblPrjId);
this.Controls.Add(this.cboPrjId);
this.Controls.Add(this.lblCmPrjId);
this.Controls.Add(this.cboCmPrjId);
this.Controls.Add(this.lblIpAddress);
this.Controls.Add(this.txtIpAddress);
this.Controls.Add(this.lblIdFtpResource);
this.Controls.Add(this.txtIdFtpResource);
this.Controls.Add(this.lblMemo);
this.Controls.Add(this.txtMemo);
this.Controls.Add(this.btnClose);
this.Controls.Add(this.btnOKUpd);
this.Controls.Add(this.lblMsg);
this.Name = "frmFileResource_UI";
this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
this.Text = "frmFileResource_UI";
this.Load += new System.EventHandler(this.frmFileResource_UI_Load);
this.ResumeLayout(false);
}
#endregion
private System.Windows.Forms.Label lblFileDirName;
private System.Windows.Forms.TextBox txtFileDirName;
private System.Windows.Forms.Label lblFileName;
private System.Windows.Forms.TextBox txtFileName;
private System.Windows.Forms.Label lblExtension;
private System.Windows.Forms.TextBox txtExtension;
private System.Windows.Forms.Label lblFileLength;
private System.Windows.Forms.TextBox txtFileLength;
private System.Windows.Forms.Label lblFileType;
private System.Windows.Forms.TextBox txtFileType;
private System.Windows.Forms.Label lblCreationTime;
private System.Windows.Forms.TextBox txtCreationTime;
private System.Windows.Forms.Label lblLastWriteTime;
private System.Windows.Forms.TextBox txtLastWriteTime;
private System.Windows.Forms.Label lblCheckDateTime;
private System.Windows.Forms.TextBox txtCheckDateTime;
private System.Windows.Forms.Label lblInUse;
private System.Windows.Forms.CheckBox chkInUse;
private System.Windows.Forms.Label lblIsExistFile;
private System.Windows.Forms.CheckBox chkIsExistFile;
private System.Windows.Forms.Label lblPrjId;
private System.Windows.Forms.ComboBox cboPrjId;
private System.Windows.Forms.Label lblCmPrjId;
private System.Windows.Forms.ComboBox cboCmPrjId;
private System.Windows.Forms.Label lblIpAddress;
private System.Windows.Forms.TextBox txtIpAddress;
private System.Windows.Forms.Label lblIdFtpResource;
private System.Windows.Forms.TextBox txtIdFtpResource;
private System.Windows.Forms.Label lblMemo;
private System.Windows.Forms.TextBox txtMemo;
private System.Windows.Forms.Label lblMsg; 
private System.Windows.Forms.Button btnOKUpd;
private System.Windows.Forms.Button btnClose;
}
}