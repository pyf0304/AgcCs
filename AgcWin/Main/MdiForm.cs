using System;
using System.Diagnostics;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using AGC.Entity;
using AGC;
using Agc_CsWin.Main;
using Agc_CsWin.frm.Test;


using Agc_CsWin.frm.SystemSet;
using AGC4WApi;

//using ExcelImport;
//using EduAdmin;

namespace AGC_CSWin
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class MdiForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MenuStrip DataSynMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem menuItem84;
        private System.Windows.Forms.ToolStripMenuItem miImportExcelFile;
        private System.Windows.Forms.ToolStripMenuItem menuItem2;
        private ToolStripMenuItem menuItem10;
        private ToolStripMenuItem miProject_QUDI;
        private ToolStripMenuItem miSysPara;
        private ToolStripMenuItem menuItem13;
        private ToolStripMenuItem menuItem14;
        private ToolStripMenuItem menuItem15;
        private ToolStripMenuItem miImportSqlTable;
        private ToolStripMenuItem miUserRightManage;
        private ToolStripMenuItem menuItem21;
        private ToolStripMenuItem menuItem22;
        private ToolStripMenuItem menuItem23;
        private ToolStripMenuItem menuItem24;
        private ToolStripMenuItem menuItem25;
        private ToolStripMenuItem menuItem26;
        private ToolStripMenuItem menuItem27;
        private ToolStripMenuItem menuItem30;
        private ToolStripMenuItem menuItem31;
        private ToolStripMenuItem menuItem32;
        private ToolStripMenuItem menuItem11;
        private ToolStripMenuItem 项目数据库维护ToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem 转换方式维护ToolStripMenuItem;
        private ToolStripMenuItem 生成存储过程ToolStripMenuItem;
        private ToolStripMenuItem 数据同步导入V2ToolStripMenuItem;
        private ToolStripMenuItem 导入方式ToolStripMenuItem;
        private ToolStripMenuItem 导出系统设置ToolStripMenuItem;
        private ToolStripMenuItem 测试导入DllToolStripMenuItem;
        private ToolStripMenuItem 注销ToolStripMenuItem;
        private ToolStripMenuItem 代码路径设置ToolStripMenuItem;
        private ToolStripMenuItem 测试ToolStripMenuItem;
        private ToolStripMenuItem 表检查结果查看ToolStripMenuItem;
        private ToolStripMenuItem 测试转换翻译ToolStripMenuItem;
        private ToolStripMenuItem 测试即时编译ToolStripMenuItem;
        private ToolStripMenuItem 测试生成代码V7ToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem 生成界面代码NewToolStripMenuItem;
        private ToolStripMenuItem 代码主路径设置ToolStripMenuItem;
        private ToolStripMenuItem webService设置ToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem 生成WebSrv类相关代码ToolStripMenuItem;
        private ToolStripMenuItem 测试读工程信息ToolStripMenuItem;
        private ToolStripMenuItem 代码管理ToolStripMenuItem;
        private ToolStripMenuItem 代码管理ToolStripMenuItem1;
        private ToolStripMenuItem 项目文件管理ToolStripMenuItem;
        private ToolStripMenuItem 代码主路径设置本机ToolStripMenuItem;
        
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblPrjStatus;
        private ToolStripMenuItem 项目文件管理GvToolStripMenuItem;
        //private IContainer components;

        public MdiForm()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				//if (components != null) 
				//{
				//	components.Dispose();
				//}
			}
			base.Dispose( disposing );
		}

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
            this.DataSynMenuStrip = new System.Windows.Forms.MenuStrip();
            this.menuItem84 = new System.Windows.Forms.ToolStripMenuItem();
            this.miImportExcelFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miImportSqlTable = new System.Windows.Forms.ToolStripMenuItem();
            this.生成存储过程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据同步导入V2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.测试导入DllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.miProject_QUDI = new System.Windows.Forms.ToolStripMenuItem();
            this.项目数据库维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.表检查结果查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.项目文件管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.项目文件管理GvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.生成界面代码NewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.生成WebSrv类相关代码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.代码管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.代码管理ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem27 = new System.Windows.Forms.ToolStripMenuItem();
            this.导出系统设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.代码路径设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.代码主路径设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webService设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.代码主路径设置本机ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miUserRightManage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem21 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem22 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem23 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem24 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItem25 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem26 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.miSysPara = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem30 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem31 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem32 = new System.Windows.Forms.ToolStripMenuItem();
            this.转换方式维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入方式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.测试ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.测试转换翻译ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.测试即时编译ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.测试生成代码V7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.测试读工程信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblPrjStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.DataSynMenuStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataSynMenuStrip
            // 
            this.DataSynMenuStrip.Font = new System.Drawing.Font("宋体", 10.5F);
            this.DataSynMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem84,
            this.menuItem10,
            this.menuItem15,
            this.toolStripMenuItem1,
            this.toolStripMenuItem3,
            this.代码管理ToolStripMenuItem,
            this.menuItem11,
            this.miUserRightManage,
            this.miSysPara,
            this.menuItem2,
            this.注销ToolStripMenuItem});
            this.DataSynMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.DataSynMenuStrip.Name = "DataSynMenuStrip";
            this.DataSynMenuStrip.Size = new System.Drawing.Size(896, 24);
            this.DataSynMenuStrip.TabIndex = 0;
            this.DataSynMenuStrip.Text = "menuStrip1";
            // 
            // menuItem84
            // 
            this.menuItem84.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miImportExcelFile,
            this.miImportSqlTable,
            this.生成存储过程ToolStripMenuItem,
            this.数据同步导入V2ToolStripMenuItem,
            this.测试导入DllToolStripMenuItem});
            this.menuItem84.Name = "menuItem84";
            this.menuItem84.Size = new System.Drawing.Size(47, 20);
            this.menuItem84.Text = "导入";
            // 
            // miImportExcelFile
            // 
            this.miImportExcelFile.Name = "miImportExcelFile";
            this.miImportExcelFile.Size = new System.Drawing.Size(172, 22);
            this.miImportExcelFile.Text = "Excel导入界面";
            this.miImportExcelFile.Click += new System.EventHandler(this.menuItem85_Click);
            // 
            // miImportSqlTable
            // 
            this.miImportSqlTable.Name = "miImportSqlTable";
            this.miImportSqlTable.Size = new System.Drawing.Size(172, 22);
            this.miImportSqlTable.Text = "数据同步导入";
            this.miImportSqlTable.Visible = false;
            this.miImportSqlTable.Click += new System.EventHandler(this.menuItem19_Click);
            // 
            // 生成存储过程ToolStripMenuItem
            // 
            this.生成存储过程ToolStripMenuItem.Name = "生成存储过程ToolStripMenuItem";
            this.生成存储过程ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.生成存储过程ToolStripMenuItem.Text = "生成存储过程";
            this.生成存储过程ToolStripMenuItem.Click += new System.EventHandler(this.生成存储过程ToolStripMenuItem_Click);
            // 
            // 数据同步导入V2ToolStripMenuItem
            // 
            this.数据同步导入V2ToolStripMenuItem.Name = "数据同步导入V2ToolStripMenuItem";
            this.数据同步导入V2ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.数据同步导入V2ToolStripMenuItem.Text = "数据同步导入V2";
            this.数据同步导入V2ToolStripMenuItem.Click += new System.EventHandler(this.数据同步导入V2ToolStripMenuItem_Click);
            // 
            // 测试导入DllToolStripMenuItem
            // 
            this.测试导入DllToolStripMenuItem.Name = "测试导入DllToolStripMenuItem";
            this.测试导入DllToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.测试导入DllToolStripMenuItem.Text = "测试导入_Dll";
            this.测试导入DllToolStripMenuItem.Click += new System.EventHandler(this.测试导入DllToolStripMenuItem_Click);
            // 
            // menuItem10
            // 
            this.menuItem10.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miProject_QUDI,
            this.项目数据库维护ToolStripMenuItem});
            this.menuItem10.Name = "menuItem10";
            this.menuItem10.Size = new System.Drawing.Size(75, 20);
            this.menuItem10.Text = "项目维护";
            // 
            // miProject_QUDI
            // 
            this.miProject_QUDI.Name = "miProject_QUDI";
            this.miProject_QUDI.Size = new System.Drawing.Size(172, 22);
            this.miProject_QUDI.Text = "项目维护";
            this.miProject_QUDI.Click += new System.EventHandler(this.menuItem11_Click_1);
            // 
            // 项目数据库维护ToolStripMenuItem
            // 
            this.项目数据库维护ToolStripMenuItem.Name = "项目数据库维护ToolStripMenuItem";
            this.项目数据库维护ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.项目数据库维护ToolStripMenuItem.Text = "项目数据库维护";
            this.项目数据库维护ToolStripMenuItem.Click += new System.EventHandler(this.项目数据库维护ToolStripMenuItem_Click);
            // 
            // menuItem15
            // 
            this.menuItem15.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.表检查结果查看ToolStripMenuItem,
            this.项目文件管理ToolStripMenuItem,
            this.项目文件管理GvToolStripMenuItem});
            this.menuItem15.Name = "menuItem15";
            this.menuItem15.Size = new System.Drawing.Size(89, 20);
            this.menuItem15.Text = "项目表管理";
            this.menuItem15.Click += new System.EventHandler(this.menuItem15_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(172, 22);
            this.toolStripMenuItem2.Text = "生成项目表代码";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // 表检查结果查看ToolStripMenuItem
            // 
            this.表检查结果查看ToolStripMenuItem.Name = "表检查结果查看ToolStripMenuItem";
            this.表检查结果查看ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.表检查结果查看ToolStripMenuItem.Text = "表检查结果查看";
            this.表检查结果查看ToolStripMenuItem.Click += new System.EventHandler(this.表检查结果查看ToolStripMenuItem_Click);
            // 
            // 项目文件管理ToolStripMenuItem
            // 
            this.项目文件管理ToolStripMenuItem.Name = "项目文件管理ToolStripMenuItem";
            this.项目文件管理ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.项目文件管理ToolStripMenuItem.Text = "项目文件管理Lv";
            this.项目文件管理ToolStripMenuItem.Visible = false;
            this.项目文件管理ToolStripMenuItem.Click += new System.EventHandler(this.项目文件管理ToolStripMenuItem_Click);
            // 
            // 项目文件管理GvToolStripMenuItem
            // 
            this.项目文件管理GvToolStripMenuItem.Name = "项目文件管理GvToolStripMenuItem";
            this.项目文件管理GvToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.项目文件管理GvToolStripMenuItem.Text = "项目文件管理Gv";
            this.项目文件管理GvToolStripMenuItem.Click += new System.EventHandler(this.项目文件管理GvToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.生成界面代码NewToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(75, 20);
            this.toolStripMenuItem1.Text = "界面管理";
            // 
            // 生成界面代码NewToolStripMenuItem
            // 
            this.生成界面代码NewToolStripMenuItem.Name = "生成界面代码NewToolStripMenuItem";
            this.生成界面代码NewToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.生成界面代码NewToolStripMenuItem.Text = "生成界面代码";
            this.生成界面代码NewToolStripMenuItem.Click += new System.EventHandler(this.生成界面代码NewToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.生成WebSrv类相关代码ToolStripMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(103, 20);
            this.toolStripMenuItem3.Text = "WebSrv类信息";
            // 
            // 生成WebSrv类相关代码ToolStripMenuItem
            // 
            this.生成WebSrv类相关代码ToolStripMenuItem.Name = "生成WebSrv类相关代码ToolStripMenuItem";
            this.生成WebSrv类相关代码ToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.生成WebSrv类相关代码ToolStripMenuItem.Text = "生成WebSrv类相关代码";
            this.生成WebSrv类相关代码ToolStripMenuItem.Click += new System.EventHandler(this.生成WebSrv类相关代码ToolStripMenuItem_Click);
            // 
            // 代码管理ToolStripMenuItem
            // 
            this.代码管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.代码管理ToolStripMenuItem1});
            this.代码管理ToolStripMenuItem.Name = "代码管理ToolStripMenuItem";
            this.代码管理ToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.代码管理ToolStripMenuItem.Text = "代码管理";
            // 
            // 代码管理ToolStripMenuItem1
            // 
            this.代码管理ToolStripMenuItem1.Name = "代码管理ToolStripMenuItem1";
            this.代码管理ToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.代码管理ToolStripMenuItem1.Text = "代码管理";
            this.代码管理ToolStripMenuItem1.Click += new System.EventHandler(this.代码管理ToolStripMenuItem1_Click);
            // 
            // menuItem11
            // 
            this.menuItem11.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem27,
            this.导出系统设置ToolStripMenuItem,
            this.代码路径设置ToolStripMenuItem,
            this.代码主路径设置ToolStripMenuItem,
            this.webService设置ToolStripMenuItem,
            this.代码主路径设置本机ToolStripMenuItem});
            this.menuItem11.Name = "menuItem11";
            this.menuItem11.Size = new System.Drawing.Size(75, 20);
            this.menuItem11.Text = "系统设置";
            // 
            // menuItem27
            // 
            this.menuItem27.Name = "menuItem27";
            this.menuItem27.Size = new System.Drawing.Size(214, 22);
            this.menuItem27.Text = "用户项目选择";
            this.menuItem27.Click += new System.EventHandler(this.menuItem27_Click);
            // 
            // 导出系统设置ToolStripMenuItem
            // 
            this.导出系统设置ToolStripMenuItem.Name = "导出系统设置ToolStripMenuItem";
            this.导出系统设置ToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.导出系统设置ToolStripMenuItem.Text = "导出系统设置";
            this.导出系统设置ToolStripMenuItem.Click += new System.EventHandler(this.导出系统设置ToolStripMenuItem_Click);
            // 
            // 代码路径设置ToolStripMenuItem
            // 
            this.代码路径设置ToolStripMenuItem.Name = "代码路径设置ToolStripMenuItem";
            this.代码路径设置ToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.代码路径设置ToolStripMenuItem.Text = "代码路径设置";
            this.代码路径设置ToolStripMenuItem.Click += new System.EventHandler(this.代码路径设置ToolStripMenuItem_Click);
            // 
            // 代码主路径设置ToolStripMenuItem
            // 
            this.代码主路径设置ToolStripMenuItem.Name = "代码主路径设置ToolStripMenuItem";
            this.代码主路径设置ToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.代码主路径设置ToolStripMenuItem.Text = "代码主路径设置";
            this.代码主路径设置ToolStripMenuItem.Click += new System.EventHandler(this.代码主路径设置ToolStripMenuItem_Click);
            // 
            // webService设置ToolStripMenuItem
            // 
            this.webService设置ToolStripMenuItem.Name = "webService设置ToolStripMenuItem";
            this.webService设置ToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.webService设置ToolStripMenuItem.Text = "WebService设置";
            this.webService设置ToolStripMenuItem.Click += new System.EventHandler(this.webService设置ToolStripMenuItem_Click);
            // 
            // 代码主路径设置本机ToolStripMenuItem
            // 
            this.代码主路径设置本机ToolStripMenuItem.Name = "代码主路径设置本机ToolStripMenuItem";
            this.代码主路径设置本机ToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.代码主路径设置本机ToolStripMenuItem.Text = "代码主路径设置(本机)";
            this.代码主路径设置本机ToolStripMenuItem.Click += new System.EventHandler(this.代码主路径设置本机ToolStripMenuItem_Click);
            // 
            // miUserRightManage
            // 
            this.miUserRightManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem21,
            this.menuItem22,
            this.menuItem23,
            this.menuItem24,
            this.toolStripSeparator1,
            this.menuItem25,
            this.menuItem26,
            this.toolStripSeparator2});
            this.miUserRightManage.Name = "miUserRightManage";
            this.miUserRightManage.Size = new System.Drawing.Size(103, 20);
            this.miUserRightManage.Text = "用户权限管理";
            // 
            // menuItem21
            // 
            this.menuItem21.Name = "menuItem21";
            this.menuItem21.Size = new System.Drawing.Size(186, 22);
            this.menuItem21.Text = "部门信息维护";
            this.menuItem21.Click += new System.EventHandler(this.menuItem21_Click);
            // 
            // menuItem22
            // 
            this.menuItem22.Name = "menuItem22";
            this.menuItem22.Size = new System.Drawing.Size(186, 22);
            this.menuItem22.Text = "用户状态维护";
            this.menuItem22.Click += new System.EventHandler(this.menuItem22_Click);
            // 
            // menuItem23
            // 
            this.menuItem23.Name = "menuItem23";
            this.menuItem23.Size = new System.Drawing.Size(186, 22);
            this.menuItem23.Text = "用户角色维护";
            this.menuItem23.Click += new System.EventHandler(this.menuItem23_Click);
            // 
            // menuItem24
            // 
            this.menuItem24.Name = "menuItem24";
            this.menuItem24.Size = new System.Drawing.Size(186, 22);
            this.menuItem24.Text = "用户信息维护";
            this.menuItem24.Click += new System.EventHandler(this.menuItem24_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(183, 6);
            // 
            // menuItem25
            // 
            this.menuItem25.Name = "menuItem25";
            this.menuItem25.Size = new System.Drawing.Size(186, 22);
            this.menuItem25.Text = "用户角色关系维护";
            this.menuItem25.Click += new System.EventHandler(this.menuItem25_Click);
            // 
            // menuItem26
            // 
            this.menuItem26.Name = "menuItem26";
            this.menuItem26.Size = new System.Drawing.Size(186, 22);
            this.menuItem26.Text = "用户项目关系维护";
            this.menuItem26.Click += new System.EventHandler(this.menuItem26_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(183, 6);
            // 
            // miSysPara
            // 
            this.miSysPara.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem13,
            this.menuItem14,
            this.menuItem30,
            this.menuItem31,
            this.menuItem32,
            this.转换方式维护ToolStripMenuItem,
            this.导入方式ToolStripMenuItem});
            this.miSysPara.Name = "miSysPara";
            this.miSysPara.Size = new System.Drawing.Size(75, 20);
            this.miSysPara.Text = "系统参数";
            // 
            // menuItem13
            // 
            this.menuItem13.Name = "menuItem13";
            this.menuItem13.Size = new System.Drawing.Size(165, 22);
            this.menuItem13.Text = "数据库类型";
            this.menuItem13.Click += new System.EventHandler(this.menuItem13_Click);
            // 
            // menuItem14
            // 
            this.menuItem14.Name = "menuItem14";
            this.menuItem14.Size = new System.Drawing.Size(165, 22);
            this.menuItem14.Text = "Sql数据源类型";
            this.menuItem14.Click += new System.EventHandler(this.menuItem14_Click_1);
            // 
            // menuItem30
            // 
            this.menuItem30.Name = "menuItem30";
            this.menuItem30.Size = new System.Drawing.Size(165, 22);
            this.menuItem30.Text = "主键类型";
            this.menuItem30.Click += new System.EventHandler(this.menuItem30_Click);
            // 
            // menuItem31
            // 
            this.menuItem31.Name = "menuItem31";
            this.menuItem31.Size = new System.Drawing.Size(165, 22);
            this.menuItem31.Text = "记录排他方式";
            this.menuItem31.Click += new System.EventHandler(this.menuItem31_Click_1);
            // 
            // menuItem32
            // 
            this.menuItem32.Name = "menuItem32";
            this.menuItem32.Size = new System.Drawing.Size(165, 22);
            this.menuItem32.Text = "数据同步方式";
            this.menuItem32.Click += new System.EventHandler(this.menuItem32_Click_1);
            // 
            // 转换方式维护ToolStripMenuItem
            // 
            this.转换方式维护ToolStripMenuItem.Name = "转换方式维护ToolStripMenuItem";
            this.转换方式维护ToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.转换方式维护ToolStripMenuItem.Text = "转换方式维护";
            this.转换方式维护ToolStripMenuItem.Click += new System.EventHandler(this.转换方式维护ToolStripMenuItem_Click);
            // 
            // 导入方式ToolStripMenuItem
            // 
            this.导入方式ToolStripMenuItem.Name = "导入方式ToolStripMenuItem";
            this.导入方式ToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.导入方式ToolStripMenuItem.Text = "导入方式";
            this.导入方式ToolStripMenuItem.Click += new System.EventHandler(this.导入方式ToolStripMenuItem_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.测试ToolStripMenuItem,
            this.测试转换翻译ToolStripMenuItem,
            this.测试即时编译ToolStripMenuItem,
            this.测试生成代码V7ToolStripMenuItem,
            this.测试读工程信息ToolStripMenuItem});
            this.menuItem2.Name = "menuItem2";
            this.menuItem2.Size = new System.Drawing.Size(47, 20);
            this.menuItem2.Text = "帮助";
            // 
            // 测试ToolStripMenuItem
            // 
            this.测试ToolStripMenuItem.Name = "测试ToolStripMenuItem";
            this.测试ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.测试ToolStripMenuItem.Text = "测试";
            this.测试ToolStripMenuItem.Click += new System.EventHandler(this.测试ToolStripMenuItem_Click);
            // 
            // 测试转换翻译ToolStripMenuItem
            // 
            this.测试转换翻译ToolStripMenuItem.Name = "测试转换翻译ToolStripMenuItem";
            this.测试转换翻译ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.测试转换翻译ToolStripMenuItem.Text = "测试转换翻译";
            this.测试转换翻译ToolStripMenuItem.Click += new System.EventHandler(this.测试转换翻译ToolStripMenuItem_Click);
            // 
            // 测试即时编译ToolStripMenuItem
            // 
            this.测试即时编译ToolStripMenuItem.Name = "测试即时编译ToolStripMenuItem";
            this.测试即时编译ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.测试即时编译ToolStripMenuItem.Text = "测试即时编译";
            this.测试即时编译ToolStripMenuItem.Click += new System.EventHandler(this.测试即时编译ToolStripMenuItem_Click);
            // 
            // 测试生成代码V7ToolStripMenuItem
            // 
            this.测试生成代码V7ToolStripMenuItem.Name = "测试生成代码V7ToolStripMenuItem";
            this.测试生成代码V7ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.测试生成代码V7ToolStripMenuItem.Text = "测试生成代码V7";
            this.测试生成代码V7ToolStripMenuItem.Click += new System.EventHandler(this.测试生成代码V7ToolStripMenuItem_Click);
            // 
            // 测试读工程信息ToolStripMenuItem
            // 
            this.测试读工程信息ToolStripMenuItem.Name = "测试读工程信息ToolStripMenuItem";
            this.测试读工程信息ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.测试读工程信息ToolStripMenuItem.Text = "测试读工程信息";
            this.测试读工程信息ToolStripMenuItem.Click += new System.EventHandler(this.测试读工程信息ToolStripMenuItem_Click);
            // 
            // 注销ToolStripMenuItem
            // 
            this.注销ToolStripMenuItem.Name = "注销ToolStripMenuItem";
            this.注销ToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.注销ToolStripMenuItem.Text = "注销";
            this.注销ToolStripMenuItem.Click += new System.EventHandler(this.注销ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblPrjStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 399);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(896, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblPrjStatus
            // 
            this.lblPrjStatus.Name = "lblPrjStatus";
            this.lblPrjStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // MdiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 421);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.DataSynMenuStrip);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.DataSynMenuStrip;
            this.Name = "MdiForm";
            this.Text = "代码生成系统(WebApi)V20180524";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DataSynMenuStrip.ResumeLayout(false);
            this.DataSynMenuStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion



		private void Form1_Load(object sender, System.EventArgs e)
		{
            //clsSysParaEN.strUserId = "pyf";
            if (clsPubVar.bolIsDispMenu == false)
            {
                clsPubVar.objMainForm.DispMenu();
            }
            //clsProjectsEN objProjectEN = clsProjectsWApi.GetObjByPrjId(clsPubVar.CurrSelPrjId);
            SetTitle();
            SetPrjStatus();

        }
        public void SetPrjStatus()
        {
            string strStatus = "";
            if (string.IsNullOrEmpty(clsPubVar.CurrPrjDataBaseId) == false)
            {
                clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseWApi.GetObjByPrjDataBaseIdCache(clsPubVar.CurrPrjDataBaseId);
                //string strWebServiceSet = clsPubFun.GetWebServiceSet();
                strStatus = string.Format("工程：{0}({1}); 数据库：{2}({3}); 生成代码WebApi:{4} ",
                    clsPubVar.objCurrSelProjectEN.PrjName,
                    clsPubVar.objCurrSelProjectEN.PrjId,
                    objPrjDataBaseEN.PrjDataBaseName,
                    objPrjDataBaseEN.PrjDataBaseId,
                    clsSysPara4WebApi_Agc.strCurrIPAddressAndPort);
            }
            else
            {
                //string strWebServiceSet = clsPubFun.GetWebServiceSet();
                strStatus = string.Format("工程：{0}({1}); 数据库：{2}({3}); 生成代码WebApi:{4} ",
                    clsPubVar.objCurrSelProjectEN.PrjName,
                    clsPubVar.objCurrSelProjectEN.PrjId,
                    "无数据库",
                    "无数据库Id",
                    clsSysPara4WebApi_Agc.strCurrIPAddressAndPort);
            }
            lblPrjStatus.Text = strStatus;
            //            statusStrip1.Items.Add("测试状态");
        }

        public void SetTitle()
        {
            if (string.IsNullOrEmpty(clsPubVar.CurrPrjDataBaseId) == false)
            {
                clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseWApi.GetObjByPrjDataBaseIdCache(clsPubVar.CurrPrjDataBaseId);
                //string strWebServiceSet = clsPubFun.GetWebServiceSet();
                this.Text = string.Format("自动生成代码20250705 ",
                    clsPubVar.objCurrSelProjectEN.PrjName,
                    clsPubVar.objCurrSelProjectEN.PrjId,
                    objPrjDataBaseEN.PrjDataBaseName,
                    objPrjDataBaseEN.PrjDataBaseId,
                    clsSysPara4WebApi_Agc.strCurrIPAddressAndPort);
            }
            else
            {
                //string strWebServiceSet = clsPubFun.GetWebServiceSet();
                this.Text = string.Format("自动生成代码20250705",
                    clsPubVar.objCurrSelProjectEN.PrjName,
                    clsPubVar.objCurrSelProjectEN.PrjId,
                    "无数据库",
                    "无数据库Id",
                    clsSysPara4WebApi_Agc.strCurrIPAddressAndPort);
            }

        }

        private void menuItem6_Click(object sender, System.EventArgs e)
		{
            //frmSqlImport frm1 = new frmSqlImport();
            //frm1.Show();			
		}
		//成绩导入
		private void menuItem8_Click(object sender, System.EventArgs e)
		{
            //frmImportExcelWithTrans frm1 = new frmImportExcelWithTrans();
            //frm1.Show();	
		}

		private void menuItem85_Click(object sender, System.EventArgs e)
		{
            //frmDataImport_Excel frm1=new frmDataImport_Excel();
            //frm1.Show();
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
            //frmxlsDataImportTab_QD_LV frm1=new frmxlsDataImportTab_QD_LV();
            //frm1.Show();
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
            //frmxlsPrjField_QD_LV frm1=new frmxlsPrjField_QD_LV();
            //frm1.Show();
		}

		private void menuItem5_Click_1(object sender, System.EventArgs e)
		{
            //frmxlsFieldTabRela_QD_LV frm1=new frmxlsFieldTabRela_QD_LV();
            //frm1.Show();
		}


        private void menuItem9_Click(object sender, EventArgs e)
        {
            //frmSqlImport2 frm1 = new frmSqlImport2();
            //frm1.Show();	
        }

        private void menuItem11_Click_1(object sender, EventArgs e)
        {
            //frmProjects_QD_LV frm = new frmProjects_QD_LV();
            //frm.Show();
        }

        private void menuItem13_Click(object sender, EventArgs e)
        {
            //frmDataBaseType_QD_LV frm = new frmDataBaseType_QD_LV();
            //frm.Show();
        }

        private void menuItem14_Click_1(object sender, EventArgs e)
        {
            //frmSQLDSType_QD_LV frm = new frmSQLDSType_QD_LV();
            //frm.Show();
        }

        private void menuItem15_Click(object sender, EventArgs e)
        {
           
        }

        //private void menuItem16_Click(object sender, EventArgs e)
        //{
        //    frmPrjTab_QD_LV frm = new frmPrjTab_QD_LV();
        //    frm.Show();
        //}

        private void menuItem17_Click(object sender, EventArgs e)
        {
            //frmPrjField_QD_LV frm = new frmPrjField_QD_LV();
            //frm.Show();
        }

        private void menuItem18_Click_1(object sender, EventArgs e)
        {
            //frmTabFieldRela_QD_LV frm = new frmTabFieldRela_QD_LV();
            //frm.Show();
        }

        private void menuItem19_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(clsSysParaEN.CurrSelPrjId) == true)
            {
                MessageBox.Show("你没有同步项目，请选择一个同步项目！");
                return;
            }
            //frmDataImport frm = new frmDataImport();
            //frm.Show();
        }

        private void menuItem21_Click(object sender, EventArgs e)
        {
            //frmDepartmentInfo_QD_LV frm = new frmDepartmentInfo_QD_LV();
            //frm.Show();
        }

        private void menuItem22_Click(object sender, EventArgs e)
        {
            //frmUserState_QD_LV frm = new frmUserState_QD_LV();
            //frm.Show();
        }

        private void menuItem23_Click(object sender, EventArgs e)
        {
            //frmUserRoles_QD_LV frm = new frmUserRoles_QD_LV();
            //frm.Show();
        }

        private void menuItem24_Click(object sender, EventArgs e)
        {
            //frmUsers_QD_LV frm = new frmUsers_QD_LV();
            //frm.Show();
        }

        private void menuItem25_Click(object sender, EventArgs e)
        {
            //frmUserRoleRelation_QD_LV frm = new frmUserRoleRelation_QD_LV();
            //frm.Show();
        }

        private void menuItem26_Click(object sender, EventArgs e)
        {
            frmUserPrjGrant_QD_LV frm = new frmUserPrjGrant_QD_LV();
            frm.Show();
        }

        private void menuItem27_Click(object sender, EventArgs e)
        {
            frmUserPrjGrant_SelectPrj frm = new frmUserPrjGrant_SelectPrj();
            frm.objMdiForm = this;
            frm.ShowDialog();
        }

        private void menuItem30_Click(object sender, EventArgs e)
        {
            //frmPrimaryType_QD_LV frm = new frmPrimaryType_QD_LV();
            //frm.Show();
        }

        private void menuItem31_Click_1(object sender, EventArgs e)
        {
            //frmRecExclusiveWay_QD_LV frm = new frmRecExclusiveWay_QD_LV();
            //frm.Show();
        }

        private void menuItem32_Click_1(object sender, EventArgs e)
        {
            //frmDataSynchWay_QD_LV frm = new frmDataSynchWay_QD_LV();
            //frm.Show();
        }
        public void DispMenu()
        {
            if (clsSysParaEN.strUserRoleId == "00000001")
            {
                miUserRightManage.Visible = true;
                miSysPara.Visible = true;
                miProject_QUDI.Enabled = true;
            }
            else
            {
                miUserRightManage.Visible = false;
                miSysPara.Visible = false;
                miProject_QUDI.Enabled = false;
           
            }
            if (clsSysParaEN.strUserRoleId == "00000002")
            {
                miProject_QUDI.Enabled = false;
            }
            if (clsPubVar.objCurrSelProjectEN == null)
            {
                return;
            }
            //if (clsPubVar.objCurrSelProjectEN.DataSynchWayId == "0004")
            //{
            //    miImportExcelFile.Enabled = true;
            //    miImportSqlTable.Enabled = false;
            //}
            //else
            //{
                miImportSqlTable.Enabled = true;
                miImportExcelFile.Enabled = true;
            //}
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            //frmPrjTab_CheckConsistency frm = new frmPrjTab_CheckConsistency();
            //frm.Show();
        }

        private void menuItem6_Click_1(object sender, EventArgs e)
        {
            //frmPrjTab_Import frm = new frmPrjTab_Import();
            //frm.Show();
        }

        private void 项目数据库维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmPrjDataBase_QD_LV frm = new frmPrjDataBase_QD_LV();
            //frm.Show();
        }

        //private void 同步任务项维护ToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    new frmViewInfo_QD_LV().Show();
        //    //frmSynchTaskItem_QD_LV frm = new frmSynchTaskItem_QD_LV();
        //    //frm.Show();
        //}

        private void 调度维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmTaskScheduling_QD_LV frm = new frmTaskScheduling_QD_LV();
            //frm.Show();
        }

        private void 转换方式维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmTransWay_QD_LV frm = new frmTransWay_QD_LV();
            //frm.Show();
        }

        private void 生成存储过程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmGeneStoreProcedure frm = new frmGeneStoreProcedure();
            //frm.Show();

        }

        private void 数据同步导入V2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(clsSysParaEN.CurrSelPrjId) == true)
            {
                MessageBox.Show("你没有同步项目，请选择一个同步项目！");
                return;
            }
            //frmDataImportV2 frm = new frmDataImportV2();
            //frm.Show();
        }

        private void 导入方式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmImportType_QD_LV frm = new frmImportType_QD_LV();
            //frm.Show();
        }

        private void 导出系统设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmExportSysSet frm = new frmExportSysSet();
            //frm.Show();
        }

        private void 测试导入DllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmTestImportByDll frm1 = new frmTestImportByDll();
            //frm1.Show();
        }

        private void 调度任务关系维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new frmSchedulingTaskItemRela_QD_DGV().Show();
        }

        private void 注销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
        }

        private void 代码路径设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmUserCodePath_QD_LV().Show();
        }

        private void 测试ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmTest().Show();
        }

        private void 表检查结果查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmTabCheckResult_QD_LV().Show();
        }

        private void 测试转换翻译ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmTestWebService().Show();
        }

        private void 测试即时编译ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm即时编译().Show();
        }

        private void 测试生成代码V7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm扩展对象列表().Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new frmPrjTab_GeneCode().Show();
        }

        private void 生成界面代码NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmViewInfo_GeneCode().Show();
        }

        private void 代码主路径设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmUserCodePrjMainPath_QD_LV().Show();
        }

        private void webService设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWebServiceSet frm1 = new frmWebServiceSet();
            frm1.frmParentForm = this;
            //frm1.MdiParent = this;
            frm1.Show();
        }

        private void 生成WebSrv类相关代码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmWebSrvClass_GeneCode().Show();
        }

        private void 测试读工程信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm读取工程信息().Show();
        }

        private void 代码管理ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frmCMUserProject_QD_LV().Show();
        }

        private void 项目文件管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmFileResource_QD_LV().Show();
        }

        private void 项目文件管理GvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmFileResource_QD_DGV().Show();
        }

        private void 代码主路径设置本机ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmUserCodePrjMainPath_QD_LV_Machine().Show();
        }
    }
}
