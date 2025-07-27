
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsCMUserProjectDA1
界面名:frmCMUserProject_QU_LV(00050261)
生成代码版本:2019.11.08.1
生成日期:2019/11/08 12:20:29
生成者:
工程名称:AGC
工程ID:0005
相关数据库:103.116.76.183,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:代码管理
模块英文名:CodeMan
框架-层名:Win界面层_UI(WinViewCode_UI)
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
using com.taishsoft.common;
using com.taishsoft.datetime;

using AGC.Entity;
using com.taishsoft.util;
using CommFunc4Win;
using AGC4WApi;

namespace AGC
{
    /// <summary>
    ///		frmCMUserProject_UI 的摘要说明。
    /// (AutoGCLib.WinViewCode_UI4CSharp:GeneCode)
    /// </summary>
    public partial class frmCMUserProject_UI : System.Windows.Forms.Form
    {
        clsCMUserProjectEN objCMUserProjectEN = null;
        private long mlngmId;       //用于传递关键字值的变量
        public string OperateType;
        public IBindListView iBindListView = null;
        public frmCMUserProject_UI()
        {
            // 该调用是 Windows.Forms 窗体设计器所必需的。
            InitializeComponent();

            // TODO: 在 InitializeComponent 调用后添加任何初始化

        }
        private void frmCMUserProject_UI_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面
            //1、为下拉框设置数据源,绑定列表数据
            this.SetAllComboBox();
            if (OperateType == "Update")
            {
                ShowData(mlngmId);
                btnOKUpd.Text = "确认修改";
            }
            else
            {
                AddCMUserProjectRecord();
            }

        }
        /// <summary>
        /// 下拉框的绑定函数
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:Genfun_SetAllComboBox4Edit)
        /// </summary>
        private void SetAllComboBox()
        {
            clsUsersWApi.BindCbo_UserId(this.cboUserId);
            clsCMProjectExWApi.BindCbo_CmPrjIdCacheEx(this.cboCmPrjId, clsSysParaEN.CurrSelPrjId);
        }
        /// <summary>
        /// 用户Id
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:Genfun_ViewCtrlProperty4Edit)
        /// </summary>
        public string UserId
        {
            get
            {
                if (cboUserId.Items.Count == 0)
                {
                    return "";
                }
                if (cboUserId.SelectedValue.ToString() == "0")
                    return "";
                return cboUserId.SelectedValue.ToString();
            }
            set
            {
                if (cboUserId.Items.Count > 0)
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
        }

        /// <summary>
        /// CM工程
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:Genfun_ViewCtrlProperty4Edit)
        /// </summary>
        public string CmPrjId
        {
            get
            {
                if (cboCmPrjId.Items.Count == 0)
                {
                    return "";
                }
                if (cboCmPrjId.SelectedValue.ToString() == "0")
                    return "";
                return cboCmPrjId.SelectedValue.ToString();
            }
            set
            {
                if (cboCmPrjId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        cboCmPrjId.SelectedValue = "0";
                    }
                    else
                    {
                        cboCmPrjId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// 工程路径
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:Genfun_ViewCtrlProperty4Edit)
        /// </summary>
        public string ProjectPath
        {
            get
            {
                return txtProjectPath.Text.Trim();
            }
            set
            {
                txtProjectPath.Text = value.ToString();
            }
        }

        /// <summary>
        /// 修改日期
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:Genfun_ViewCtrlProperty4Edit)
        /// </summary>
        public string UpdDate
        {
            get
            {
                return txtUpdDate.Text.Trim();
            }
            set
            {
                txtUpdDate.Text = value.ToString();
            }
        }

        /// <summary>
        /// 修改用户Id
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:Genfun_ViewCtrlProperty4Edit)
        /// </summary>
        public string UpdUserId
        {
            get
            {
                return txtUpdUserId.Text.Trim();
            }
            set
            {
                txtUpdUserId.Text = value.ToString();
            }
        }

        /// <summary>
        /// 说明
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:Genfun_ViewCtrlProperty4Edit)
        /// </summary>
        public string Memo
        {
            get
            {
                return txtMemo.Text.Trim();
            }
            set
            {
                txtMemo.Text = value.ToString();
            }
        }


        /// <summary>
        /// 清除用户自定义控件中，所有控件的值
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:Genfun_Clear4EditResion)
        /// </summary>	
        public void Clear()
        {
            cboUserId.SelectedIndex = 0;
            cboCmPrjId.SelectedIndex = 0;
            txtProjectPath.Text = "";
            txtUpdDate.Text = "";
            txtUpdUserId.Text = "";
            txtMemo.Text = "";
        }
        /// <summary>
        /// 设置该控件在插入状态下的缺省值
        /// 一般规则:
        ///		1、如果是整型就默认为0；
        ///		2、如果是浮点型不默认为0.0；
        ///		3、如果是日期型就默认为当前的日期；
        ///		4、如果是位(bit)型就默认为false;
        ///		这些默认值可以再行修改
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:Genfun_SetDefaultValue4EditRegion)
        /// </summary>
        public void SetDefaultValue()
        {
            cboUserId.SelectedIndex = 0;
            cboCmPrjId.SelectedIndex = 0;
            txtProjectPath.Text = "";
            txtUpdDate.Text = "";
            txtUpdUserId.Text = "";
            txtMemo.Text = "";
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

            return true;
        }

        /// <summary>
        /// 函数功能:把以该关键字的记录内容显示在界面上,
        ///　　　   在这里是把值传到表控件中
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:GenShowDataCode_Win)
        /// </summary>
        /// <param name = "lngmId">表记录的关键字,显示该表关键字的内容</param>
        private void ShowData(long lngmId)
        {
            //操作步骤:
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中

            //1、检查关键字是否为空；
            if (lngmId == 0) return;        //如果关键字为空就返回退出
                                            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            if (clsCMUserProjectWApi.IsExist(lngmId) == false)        //检查该关键字的记录是否存在
            {
                string strMsg = "(errid:WinI000012)在表[CMUserProject]中,关键字为:[lngmId]的记录不存在!";
                MessageBox.Show(strMsg);
                return;
            }
            //3、用提供的关键字初始化一个类对象；
            objCMUserProjectEN = clsCMUserProjectWApi.GetObjBymId(lngmId);
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
            GetDataFromCMUserProjectClass(objCMUserProjectEN);
        }
        /// <summary>
        /// 函数功能:把类对象的属性内容显示到界面上
        ///注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
        ///   如果在设置数据库时,就应该一级字段在前,二级字段在后
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:GenGetDataFromClass)
        /// </summary>
        /// <param name = "pobjCMUserProjectEN">表实体类对象</param>
        private void GetDataFromCMUserProjectClass(clsCMUserProjectEN pobjCMUserProjectEN)
        {
            ///注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
            ///   如果在设置数据库时,就应该一级字段在前,二级字段在后
            this.UserId = pobjCMUserProjectEN.UserId;
            this.CmPrjId = pobjCMUserProjectEN.CmPrjId;
            this.ProjectPath = pobjCMUserProjectEN.ProjectPath;
            this.UpdDate = pobjCMUserProjectEN.UpdDate;
            this.UpdUserId = pobjCMUserProjectEN.UpdUserId;
            this.Memo = pobjCMUserProjectEN.Memo;
        }
        /// <summary>
        /// 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
        ///      具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:GenbtnOKUpd_Click)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        private void btnOKUpd_Click(object sender, System.EventArgs e)
        {
            string strCommandText;
            Button btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "添加":
                    AddCMUserProjectRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    AddCMUserProjectRecordSave();
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    UpdateCMUserProjectRecordSave(objCMUserProjectEN);
                    break;
            }
        }
        private void PutDataToCMUserProjectClass(clsCMUserProjectEN pobjCMUserProjectEN)
        {
            pobjCMUserProjectEN.UserId = this.UserId;
            pobjCMUserProjectEN.CmPrjId = this.CmPrjId;
            pobjCMUserProjectEN.ProjectPath = this.ProjectPath;
            pobjCMUserProjectEN.UpdDate = this.UpdDate;
            pobjCMUserProjectEN.UpdUserId = this.UpdUserId;
            pobjCMUserProjectEN.Memo = this.Memo;
        }
        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
        public long mId_key
        {
            get
            {
                return mlngmId;
            }
            set
            {
                mlngmId = value;
            }
        }
        /// <summary>
        /// 为插入记录做准备工作
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:GenAddRecordCode)
        /// </summary>
        protected void AddCMUserProjectRecord()
        {
            btnOKUpd.Text = "确认添加";
            //this.mId = clsCMUserProjectWApi.GetMaxStrId_S();
            //DispEditCMUserProjectRegion();
        }
        /// <summary>
        /// 插入记录存盘到数据表中
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:GenAddRecordSaveCode)
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        private void AddCMUserProjectRecordSave()
        {
            //操作步骤:
            //1、检查控件中输入数据类型是否正确
            //2、定义对象并初始化对象
            //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            //4、把值从界面层传到逻辑层或数据实体层
            //5、检查传进去的对象属性是否合法
            //6、把数据实体层的数据存贮到数据库中
            //7、把新添的记录内容显示在GridView中
            string strMsg;  //专门用于传递信息的变量
            string strResult = " "; //用于传递在检验对象属性时结果值的变量
            //clsCMUserProjectEN objCMUserProject;
            //1、检查控件中输入数据类型是否正确
            if (!this.IsValid(ref strResult))
            {
                lblMsg.Text = "(errid:WinI000013)控件中输入数据类型不正确请检查!";
                return;
            }
            //2、初始化相关类对象
            objCMUserProjectEN = new clsCMUserProjectEN();  //初始化新对象
                                                            //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
                                                            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToCMUserProjectClass(objCMUserProjectEN);        //把界面的值传到
                                                                    //5、检查传进去的对象属性是否合法
            try
            {
                //objCMUserProjectEN.CheckPropertyNew();
                //6、把数据实体层的数据存贮到数据库中
                objCMUserProjectEN.AddNewRecord();
            }
            catch (Exception objException)
            {
                strMsg = string.Format("(errid:WinI000014)添加记录不成功!(frmCMUserProject_UI: AddCMUserProjectRecordSave)错误信息:{0}.", objException.Message);
                MessageBox.Show(strMsg);
                lblMsg.Text = strMsg;
                return;
            }
            strMsg = "添加记录成功!";
            MessageBox.Show(strMsg);
            lblMsg.Text = strMsg;
            //7、恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            //8、调用父窗体中函数BINDLISTVIEW()把父窗体中的LISTVIEW内容重新显示一下。
            iBindListView.BindListView();
        }
        /// <summary>
        /// 修改记录存盘到数据表中
        /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:GenUpdateRecordSaveCode)
        /// </summary>
        /// <param name = "objCMUserProjectEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        private void UpdateCMUserProjectRecordSave(clsCMUserProjectEN objCMUserProjectEN)
        {
            //操作步骤:
            //1、检查控件中输入数据类型是否正确
            //2、把值从界面层传到逻辑层或数据实体层
            //3、检查传进去的对象属性是否合法
            //4、把数据实体层的数据存贮到数据库中
            //5、把修改后的内容显示在GridView中
            string strMsg;  //专门用于传递信息的变量
            string strResult = " "; //用于传递在检验对象属性时结果值的变量
                                    //1、检查控件中输入数据类型是否正确
            if (!this.IsValid(ref strResult))
            {
                lblMsg.Text = "(errid:WinI000015)控件中输入数据类型不正确请检查!";
                return;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToCMUserProjectClass(objCMUserProjectEN);        //把界面的值传到
                                                                    //3、检查传进去的对象属性是否合法
            try
            {
                //objCMUserProjectEN.CheckPropertyNew();
                //6、把数据实体层的数据存贮到数据库中
                objCMUserProjectEN.Update();
            }
            catch (Exception objException)
            {
                strMsg = string.Format("(errid:WinI000016)修改记录不成功!(frmCMUserProject_UI: UpdateCMUserProjectRecordSave)错误信息:{0}.", objException.Message);
                MessageBox.Show(strMsg);
                lblMsg.Text = strMsg;
                return;
            }
            strMsg = "修改记录成功!";
            MessageBox.Show(strMsg);
            lblMsg.Text = strMsg;
            this.Close();
            //5、恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            //6、调用父窗体中函数BINDLISTVIEW()把父窗体中的LISTVIEW内容重新显示一下。
            iBindListView.BindListView();
        }
    }
}