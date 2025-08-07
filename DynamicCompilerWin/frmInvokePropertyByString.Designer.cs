namespace DynamicCompilerWin
{
    partial class frmInvokePropertyByString
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDynCompAndExec = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnTestDynamicCompilerClass = new System.Windows.Forms.Button();
            this.btnTestCalc = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTestDynCompiler4CacheInit = new System.Windows.Forms.Button();
            this.btnTestCacheInit = new System.Windows.Forms.Button();
            this.btnInvokeFunctionByStrName = new System.Windows.Forms.Button();
            this.btnAddCacheInitFunction = new System.Windows.Forms.Button();
            this.btnExecCacheInitFunction = new System.Windows.Forms.Button();
            this.btnInvokePropByString = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDynCompAndExec
            // 
            this.btnDynCompAndExec.Location = new System.Drawing.Point(3, 3);
            this.btnDynCompAndExec.Name = "btnDynCompAndExec";
            this.btnDynCompAndExec.Size = new System.Drawing.Size(155, 27);
            this.btnDynCompAndExec.TabIndex = 0;
            this.btnDynCompAndExec.Text = "动态编译并执行";
            this.btnDynCompAndExec.UseVisualStyleBackColor = true;
            this.btnDynCompAndExec.Click += new System.EventHandler(this.btnDynCompAndExec_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(110, 311);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(70, 14);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "lblResult";
            // 
            // btnTestDynamicCompilerClass
            // 
            this.btnTestDynamicCompilerClass.Location = new System.Drawing.Point(3, 36);
            this.btnTestDynamicCompilerClass.Name = "btnTestDynamicCompilerClass";
            this.btnTestDynamicCompilerClass.Size = new System.Drawing.Size(155, 27);
            this.btnTestDynamicCompilerClass.TabIndex = 2;
            this.btnTestDynamicCompilerClass.Text = "测试动态编译类";
            this.btnTestDynamicCompilerClass.UseVisualStyleBackColor = true;
            this.btnTestDynamicCompilerClass.Click += new System.EventHandler(this.btnTestDynamicCompilerClass_Click);
            // 
            // btnTestCalc
            // 
            this.btnTestCalc.Location = new System.Drawing.Point(211, 36);
            this.btnTestCalc.Name = "btnTestCalc";
            this.btnTestCalc.Size = new System.Drawing.Size(119, 23);
            this.btnTestCalc.TabIndex = 3;
            this.btnTestCalc.Text = "测试计算类";
            this.btnTestCalc.UseVisualStyleBackColor = true;
            this.btnTestCalc.Click += new System.EventHandler(this.btnTestCalc_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "测试动态编译类-计算类";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTestDynCompiler4CacheInit
            // 
            this.btnTestDynCompiler4CacheInit.Location = new System.Drawing.Point(3, 102);
            this.btnTestDynCompiler4CacheInit.Name = "btnTestDynCompiler4CacheInit";
            this.btnTestDynCompiler4CacheInit.Size = new System.Drawing.Size(202, 27);
            this.btnTestDynCompiler4CacheInit.TabIndex = 5;
            this.btnTestDynCompiler4CacheInit.Text = "测试动态编译类-缓存初始化";
            this.btnTestDynCompiler4CacheInit.UseVisualStyleBackColor = true;
            this.btnTestDynCompiler4CacheInit.Click += new System.EventHandler(this.btnTestDynCompiler4CacheInit_Click);
            // 
            // btnTestCacheInit
            // 
            this.btnTestCacheInit.Location = new System.Drawing.Point(211, 102);
            this.btnTestCacheInit.Name = "btnTestCacheInit";
            this.btnTestCacheInit.Size = new System.Drawing.Size(144, 27);
            this.btnTestCacheInit.TabIndex = 6;
            this.btnTestCacheInit.Text = "测试缓存初始化";
            this.btnTestCacheInit.UseVisualStyleBackColor = true;
            this.btnTestCacheInit.Click += new System.EventHandler(this.btnTestCacheInit_Click);
            // 
            // btnInvokeFunctionByStrName
            // 
            this.btnInvokeFunctionByStrName.Location = new System.Drawing.Point(211, 69);
            this.btnInvokeFunctionByStrName.Name = "btnInvokeFunctionByStrName";
            this.btnInvokeFunctionByStrName.Size = new System.Drawing.Size(240, 27);
            this.btnInvokeFunctionByStrName.TabIndex = 7;
            this.btnInvokeFunctionByStrName.Text = "测试通过字符名称调用计算函数";
            this.btnInvokeFunctionByStrName.UseVisualStyleBackColor = true;
            this.btnInvokeFunctionByStrName.Click += new System.EventHandler(this.btnInvokeFunctionByStrName_Click);
            // 
            // btnAddCacheInitFunction
            // 
            this.btnAddCacheInitFunction.Location = new System.Drawing.Point(3, 135);
            this.btnAddCacheInitFunction.Name = "btnAddCacheInitFunction";
            this.btnAddCacheInitFunction.Size = new System.Drawing.Size(176, 27);
            this.btnAddCacheInitFunction.TabIndex = 8;
            this.btnAddCacheInitFunction.Text = "添加缓存初始化函数 ";
            this.btnAddCacheInitFunction.UseVisualStyleBackColor = true;
            this.btnAddCacheInitFunction.Click += new System.EventHandler(this.btnAddCacheInitFunction_Click);
            // 
            // btnExecCacheInitFunction
            // 
            this.btnExecCacheInitFunction.Location = new System.Drawing.Point(211, 135);
            this.btnExecCacheInitFunction.Name = "btnExecCacheInitFunction";
            this.btnExecCacheInitFunction.Size = new System.Drawing.Size(176, 27);
            this.btnExecCacheInitFunction.TabIndex = 9;
            this.btnExecCacheInitFunction.Text = "执行缓存初始化函数 ";
            this.btnExecCacheInitFunction.UseVisualStyleBackColor = true;
            this.btnExecCacheInitFunction.Click += new System.EventHandler(this.btnExecCacheInitFunction_Click);
            // 
            // btnInvokePropByString
            // 
            this.btnInvokePropByString.Location = new System.Drawing.Point(211, 168);
            this.btnInvokePropByString.Name = "btnInvokePropByString";
            this.btnInvokePropByString.Size = new System.Drawing.Size(211, 23);
            this.btnInvokePropByString.TabIndex = 10;
            this.btnInvokePropByString.Text = "通过字符串来访问属性名称";
            this.btnInvokePropByString.UseVisualStyleBackColor = true;
            this.btnInvokePropByString.Click += new System.EventHandler(this.btnInvokePropByString_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 14;
            this.listBox1.Location = new System.Drawing.Point(644, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(277, 438);
            this.listBox1.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btnExecCacheInitFunction, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnAddCacheInitFunction, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnInvokePropByString, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnTestCacheInit, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnTestCalc, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDynCompAndExec, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnTestDynamicCompilerClass, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnInvokeFunctionByStrName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnTestDynCompiler4CacheInit, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(590, 254);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // frmInvokePropertyByString
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 456);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblResult);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "frmInvokePropertyByString";
            this.Text = "frmTestDynamicCompiler2";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDynCompAndExec;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnTestDynamicCompilerClass;
        private System.Windows.Forms.Button btnTestCalc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTestDynCompiler4CacheInit;
        private System.Windows.Forms.Button btnTestCacheInit;
        private System.Windows.Forms.Button btnInvokeFunctionByStrName;
        private System.Windows.Forms.Button btnAddCacheInitFunction;
        private System.Windows.Forms.Button btnExecCacheInitFunction;
        private System.Windows.Forms.Button btnInvokePropByString;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}