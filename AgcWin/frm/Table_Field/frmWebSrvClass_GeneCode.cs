

using AGC.Entity;
using Agc_CsWin;
using AGC_CSWin;
using AGC4WApi;
using AgcCommBase;

using com.taishsoft.common;
using com.taishsoft.util;
using CommFunc4Win;


///----------------------
///生成代码版本：2012.01.02.1
///生成日期：2012/10/13
///生成者：潘以锋
///工程名称：AGC
///工程ID：0005
///模块中文名：字段、表维护
///模块英文名：Table_Field
///注意：1、需要数据底层（PubDataBase.dll）的版本：2011.05.08.1
///       2、需要公共函数层（TzPubFunction.dll）的版本：2011.05.08.1
///========================
//生成与表相关的控件控制层代码
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace AGC
{
    /// <summary>
    ///		frmWebSrvClass_QD_LV 的摘要说明。
    /// </summary>
    public partial class frmWebSrvClass_GeneCode : System.Windows.Forms.Form, IBindListView
    {
       
        //当前选中类为一个时所选的webSrvClassId
        private string mstrCurrWebSrvClassId = "";
        clsGeneCode_Local objGeneCode_Local = null;
        //clsWebSrvClassEN objWebSrvClassEN = null;
        private System.Data.DataTable objDTWebSrvClass = null;
        private clsListViewSorter objvWebSrvClassSorter;
        private int intLastSelectedvWebSrvClassColumIndex;
        private clsPubConst.LangType mltLangType = clsPubConst.LangType.CSharp;//语言类型
        private clsPubConst.DataBaseType mdbtDataBaseType = clsPubConst.DataBaseType.MsSql;//数据库类型
        public frmWebSrvClass_GeneCode()
        {
            // 该调用是 Windows.Forms 窗体设计器所必需的。
            InitializeComponent();

            // TODO: 在 InitializeComponent 调用后添加任何初始化
            objvWebSrvClassSorter = new clsListViewSorter();
            //为ListViewItemSorter指定排序类
            this.lvvWebSrvClass.ListViewItemSorter = objvWebSrvClassSorter;
            objvWebSrvClassSorter.SortOrder = SortOrder.Ascending;

        }
        private void frmWebSrvClass_QD_Load(object sender, System.EventArgs e)
        {
            //clsProjectsEN objProjectEN = clsProjectsWApi.GetObjByPrjId(clsPubVar.CurrSelPrjId);
            clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseWApi.GetObjByPrjDataBaseIdCache(clsPubVar.CurrPrjDataBaseId);
            try
            {
                clsWebSrvClassExWApi.p_Init_Log4GC_WebSrvClass(clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId);
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
                return;
            }
            this.Text = string.Format("项目表代码生成20250705----工程：{0}({1})  数据库：{2}({3})", clsPubVar.objCurrSelProjectEN.PrjName, clsPubVar.objCurrSelProjectEN.PrjId,
                                objPrjDataBaseEN.PrjDataBaseName, objPrjDataBaseEN.PrjDataBaseId);
            // 在此处放置用户代码以初始化页面
            //1、为下拉框设置数据源，绑定列表数据
            this.SetAllComboBox();
            rblProgLangTypeId.Value = enumProgLangTypeWA.CSharp_01;
            DispClassNameButton();
            //string strCharEncodingId = clsPubFun.GetCharEncodingIdByPrjUser(clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId);
            //cboCharEncodingId.SelectedValue = strCharEncodingId;
            string strCharEncodingId = clsPubFun.GetCharEncodingIdByLangTypeId(enumProgLangTypeWA.CSharp_01);
            cboCharEncodingId.SelectedValue = strCharEncodingId;

            //if (chkDispAllErrMsg.Checked == true)
            //{
            //    BindLv_vWebSrvClass_WithErrMsg();
            //}
            //else
            //{
            BindLv_vWebSrvClass(false);
            //}

        

        }
        /// <summary>
        /// 下拉框的绑定函数
        /// </summary>
        private void SetAllComboBox()
        {
        
            clsFuncModule_AgcExWApi.BindCbo_FuncModuleIdCache(this.cboFuncModuleId, clsPubVar.CurrSelPrjId);
            //this.BindCbo_SqlDsTypeId(this.cboSqlDsTypeId);
            //this.BindCbo_TabStateId(this.cboTabStateId);
            clsCharEncodingExWApi.BindCbo_CharEncodingIdCache(cboCharEncodingId);
            clsProgLangTypeExWApi.BindRbl_ProgLangTypeIdEx(rblProgLangTypeId);
            clsAppPageTypeWApi.BindCbo_AppPageTypeId(cboAppPageTypeId);
            cboAppPageTypeId.SelectedIndex = 1;
        }
        public string ClassName
        {
            get
            {
                return txtClassName.Text.Trim();
            }
            set
            {
                txtClassName.Text = value.ToString();
            }
        }

        public string ObjId
        {
            get
            {
                if (cboFuncModuleId.SelectedValue.ToString() == "0")
                    return "";
                return cboFuncModuleId.SelectedValue.ToString();
            }
            set
            {
                if (value == "")
                {
                    cboFuncModuleId.SelectedValue = "0";
                }
                else
                {
                    cboFuncModuleId.SelectedValue = value;
                }
            }
        }

        //public string SqlDsTypeId
        //{
        //    get
        //    {
        //        if (cboSqlDsTypeId.SelectedValue.ToString() == "0")
        //            return "";
        //        return cboSqlDsTypeId.SelectedValue.ToString();
        //    }
        //    set
        //    {
        //        if (value == "")
        //        {
        //            cboSqlDsTypeId.SelectedValue = "0";
        //        }
        //        else
        //        {
        //            cboSqlDsTypeId.SelectedValue = value;
        //        }
        //    }
        //}

  

        public void Clear()
        {
            txtClassName.Text = "";            
            cboFuncModuleId.SelectedIndex = 0;
            //cboSqlDsTypeId.SelectedIndex = 0;
         
        }
        /// <summary>
        /// 设置该控件在插入状态下的缺省值
        /// 一般规则：
        ///		1、如果是整型就默认为0；
        ///		2、如果是浮点型不默认为0.0；
        ///		3、如果是日期型就默认为当前的日期；
        ///		4、如果是位(bit)型就默认为false;
        ///		这些默认值可以再行修改
        /// </summary>
        public void SetDefaultValue()
        {
            txtClassName.Text = "";
          
            cboFuncModuleId.SelectedIndex = 0;
            //cboSqlDsTypeId.SelectedIndex = 0;
          
        }
        /// <summary>
        /// 校验自定义控件中自子控件的类型数值是否是合法正确的。
        /// 一般规则：
        ///		1、首先校验类型：整型、浮点型、日期型等，
        ///			这些代码由自动生成代码帮助生成
        ///		2、校验最值，即最大值和最小值等
        ///			这些代码由自动生成代码帮助生成
        ///		这些生成内容可以修改
        /// </summary>
        /// <returns></returns>
        public bool IsValid(ref string strResult)
        {
            return true;
        }
        /// <summary>
        /// 功能：获取当前月的字符串
        /// 月的格式：
        ///    月的字符串的格式有三种：
        ///		1、YYYYMM。	例如200501
        ///		2、YYYY-MM-DD	例如2005-01
        ///		3、YYYY/MM/DD	例如2005/01
        /// </summary>
        /// <param name="intFormat">月的格式，共有3种，传入参数0,1，2
        ///							参数不同，函数返回值就不同，
        ///							参见上面的月的格式
        ///	</param>
        /// <returns>返回当前月的字符串</returns>
        public string getCurrMonth(int intFormat)
        {
            string strCurrMonth;
            string strYear, strMonth;
            int intYear, intMonth;
            intYear = System.DateTime.Today.Year;
            intMonth = System.DateTime.Today.Month;
            strYear = intYear.ToString().Trim();
            if (intMonth > 9) strMonth = intMonth.ToString().Trim();
            else strMonth = "0" + intMonth.ToString().Trim();
            strCurrMonth = strYear + strMonth;
            switch (intFormat)
            {
                case 0:
                    strCurrMonth = strYear + strMonth;
                    break;
                case 1:
                    strCurrMonth = strYear + "-" + strMonth;
                    break;
                case 2:
                    strCurrMonth = strYear + "/" + strMonth;
                    break;
            }
            return strCurrMonth;
        }
        /// <summary>
        /// 功能：获取当前日期的字符串
        /// 日期格式：
        ///    日期的字符串的格式有三种：
        ///		1、YYYYMMDD。	例如20050120
        ///		2、YYYY-MM-DD	例如2005-01-20
        ///		3、YYYY/MM/DD	例如2005/01/20
        /// </summary>
        /// <param name="intFormat">日期格式，共有3种，传入参数0,1，2
        ///							参数不同，函数返回值就不同，
        ///							参见上面的日期格式
        ///	</param>
        /// <returns>返回当前日期的字符串</returns>
        public string getTodayStr(int intFormat)
        {
            string strToday;
            string strYear, strMonth, strDay;
            int intYear, intMonth, intDay;
            intYear = System.DateTime.Today.Year;
            intMonth = System.DateTime.Today.Month;
            intDay = System.DateTime.Today.Day;
            strYear = intYear.ToString().Trim();
            if (intMonth > 9) strMonth = intMonth.ToString().Trim();
            else strMonth = "0" + intMonth.ToString().Trim();
            if (intDay > 9) strDay = intDay.ToString().Trim();
            else strDay = "0" + intDay.ToString().Trim();
            strToday = strYear + strMonth + strDay;
            switch (intFormat)
            {
                case 0:
                    strToday = strYear + strMonth + strDay;
                    break;
                case 1:
                    strToday = strYear + "-" + strMonth + "-" + strDay;
                    break;
                case 2:
                    strToday = strYear + "/" + strMonth + "/" + strDay;
                    break;
            }
            return strToday;
        }
 
      
        /// <summary>
        /// 判断是否是数字
        /// </summary>
        /// <param name="strValue">需要判断的字符串</param>
        /// <returns>True/False</returns>
        public bool IsDigit(string strValue)
        {
            int intLen = strValue.Length;
            for (int i = 0; i < intLen; i++)
            {
                if (char.IsDigit(strValue, i) == false)
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// 判断是否是浮点型数值
        /// </summary>
        /// <param name="strValue">需要判断的字符串</param>
        /// <returns>True/False</returns>
        public bool IsFloat(string strValue)
        {
            int intPointNum = 0;
            char[] arrChar = strValue.ToCharArray();
            int intLen = strValue.Length;
            for (int i = 0; i < intLen; i++)
            {
                if (char.IsDigit(strValue, i) == true || arrChar[i] == '.')
                {
                }
                else
                {
                    return false;
                }
                if (arrChar[i] == '.') intPointNum++;
            }
            //检查总共有几个小数点，如果有多于1个小数点，就不正确
            if (intPointNum > 1) return false;
            return true;
        }
        /// <summary>
        /// 判断是否是整型数值
        /// </summary>
        /// <param name="strValue">需要判断的字符串</param>
        /// <returns>True/False</returns>
        public bool IsNumeric(string strValue)
        {
            int intLen = strValue.Length;
            for (int i = 0; i < intLen; i++)
            {
                if (char.IsDigit(strValue, i) == false)
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        public string CombineWebSrvClassCondion()
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 && UserName = '张三'
            string strWhereCond = string.Format(" 1=1 And {0}='{1}'", conWebSrvClass.PrjId, clsPubVar.CurrSelPrjId);
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            if (this.txtClassName.Text.Trim() != "")
            {
                strWhereCond += " And WebSrvClass.ClsName like '%" + this.txtClassName.Text.Trim() + "%'";
            }
          
            if (this.cboFuncModuleId.SelectedValue.ToString() != "" && this.cboFuncModuleId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And WebSrvClass.FuncModuleAgcId='" + this.cboFuncModuleId.SelectedValue + "'";
            }
            //if (this.cboSqlDsTypeId.SelectedValue.ToString() != "" && this.cboSqlDsTypeId.SelectedValue.ToString() != "0")
            //{
            //    strWhereCond += " And WebSrvClass.SqlDsTypeId='" + this.cboSqlDsTypeId.SelectedValue + "'";
            //}
           
            return strWhereCond;
        }
        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        public string CombineWebSrvClassCondion(bool bolIsWithClassName)
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 && UserName = '张三'
            string strWhereCond = string.Format(" 1=1 And {0}='{1}'", conWebSrvClass.PrjId, clsPubVar.CurrSelPrjId);
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            if (bolIsWithClassName == true)
            {
                if (this.txtClassName.Text.Trim() != "")
                {
                    strWhereCond += " And WebSrvClass.ClsName like '%" + this.txtClassName.Text.Trim() + "%'";
                }
                
                if (this.cboFuncModuleId.SelectedValue.ToString() != "" && this.cboFuncModuleId.SelectedValue.ToString() != "0")
                {
                    strWhereCond += " And WebSrvClass.FuncModuleAgcId='" + this.cboFuncModuleId.SelectedValue + "'";
                }
                //if (this.cboSqlDsTypeId.SelectedValue.ToString() != "" && this.cboSqlDsTypeId.SelectedValue.ToString() != "0")
                //{
                //    strWhereCond += " And WebSrvClass.SqlDsTypeId='" + this.cboSqlDsTypeId.SelectedValue + "'";
                //}
              
            }
            else
            {
                if (this.txtClassName.Text.Trim() != "")
                {
                    strWhereCond += " And ClassName like '%" + this.txtClassName.Text.Trim() + "%'";
                }
                
                if (this.cboFuncModuleId.SelectedValue.ToString() != "" && this.cboFuncModuleId.SelectedValue.ToString() != "0")
                {
                    strWhereCond += " And FuncModuleAgcId='" + this.cboFuncModuleId.SelectedValue + "'";
                }
                //if (this.cboSqlDsTypeId.SelectedValue.ToString() != "" && this.cboSqlDsTypeId.SelectedValue.ToString() != "0")
                //{
                //    strWhereCond += " And SqlDsTypeId='" + this.cboSqlDsTypeId.SelectedValue + "'";
                //}
               
            }
            return strWhereCond;
        }

        public string CombineWebSrvClassCondion4NoTimelyGeneCodeTabs(bool bolIsWithClassName)
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 && UserName = '张三'
            string strWhereCond = " ('20' + UpdDate>GeneCodeDate or GeneCodeDate is null or IsNeedGene='1') ";
            strWhereCond += string.Format(" And {0}='{1}'", conWebSrvClass.PrjId, clsPubVar.CurrSelPrjId);
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            if (bolIsWithClassName == true)
            {
                if (this.txtClassName.Text.Trim() != "")
                {
                    strWhereCond += " And WebSrvClass.ClsName like '%" + this.txtClassName.Text.Trim() + "%'";
                }
               
                if (this.cboFuncModuleId.SelectedValue.ToString() != "" && this.cboFuncModuleId.SelectedValue.ToString() != "0")
                {
                    strWhereCond += " And WebSrvClass.FuncModuleAgcId='" + this.cboFuncModuleId.SelectedValue + "'";
                }
                //if (this.cboSqlDsTypeId.SelectedValue.ToString() != "" && this.cboSqlDsTypeId.SelectedValue.ToString() != "0")
                //{
                //    strWhereCond += " And WebSrvClass.SqlDsTypeId='" + this.cboSqlDsTypeId.SelectedValue + "'";
                //}
               
            }
            else
            {
                if (this.txtClassName.Text.Trim() != "")
                {
                    strWhereCond += " And ClassName like '%" + this.txtClassName.Text.Trim() + "%'";
                }
               
                if (this.cboFuncModuleId.SelectedValue.ToString() != "" && this.cboFuncModuleId.SelectedValue.ToString() != "0")
                {
                    strWhereCond += " And FuncModuleAgcId='" + this.cboFuncModuleId.SelectedValue + "'";
                }
                //if (this.cboSqlDsTypeId.SelectedValue.ToString() != "" && this.cboSqlDsTypeId.SelectedValue.ToString() != "0")
                //{
                //    strWhereCond += " And SqlDsTypeId='" + this.cboSqlDsTypeId.SelectedValue + "'";
                //}
                
            }
            return strWhereCond;
        }

        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        public string CombineWebSrvClassCondion(string strClassName)
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 && UserName = '张三'
            string strWhereCond = string.Format(" 1=1 And {0}='{1}'", conWebSrvClass.PrjId, clsPubVar.CurrSelPrjId);
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            if (this.txtClassName.Text.Trim() != "")
            {
                strWhereCond += " And " + strClassName + ".ClsName like '%" + this.txtClassName.Text.Trim() + "%'";
            }
            
            if (this.cboFuncModuleId.SelectedValue.ToString() != "" && this.cboFuncModuleId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And " + strClassName + ".FuncModuleAgcId='" + this.cboFuncModuleId.SelectedValue + "'";
            }
            //if (this.cboSqlDsTypeId.SelectedValue.ToString() != "" && this.cboSqlDsTypeId.SelectedValue.ToString() != "0")
            //{
            //    strWhereCond += " And " + strClassName + ".SqlDsTypeId='" + this.cboSqlDsTypeId.SelectedValue + "'";
            //}
           
            return strWhereCond;
        }
      

        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在ListView中。
        /// </summary>
        private void BindLv_vWebSrvClass(bool bolIsDispTabs4TimelyGene)
        {
            //操作步骤：(共4步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	3、设置ListView的列头信息
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            //		在本界面中是把状态显示在控件lblRecCount中。

            ListViewItem lvivWebSrvClass;
            List<clsvWebSrvClass4GeneCodeEN> arrvWebSrvClassObjList;
            //	1、组合界面条件串；
            string strWhereCond = "";
            if (bolIsDispTabs4TimelyGene == true)
            {
                strWhereCond = this.CombineWebSrvClassCondion4NoTimelyGeneCodeTabs(false);
                strWhereCond += "[Exclude]or [/Exclude]";
            }
            else
            {
                strWhereCond = this.CombineWebSrvClassCondion(false);	//  CombineWebSrvClassCondion();
                //strWhereCond += "[Exclude]or [/Exclude]";
            }
            //	2、根据条件串获取该表满足条件的DataTable；
            try
            {
                arrvWebSrvClassObjList = clsvWebSrvClass4GeneCodeExWApi.GetObjLstByUserIdAndCondition(clsSysParaEN.strUserId, strWhereCond);
            }
            catch(Exception objException)
            {
                MessageBox.Show(objException.Message);
                return;
            }
            //	3、设置ListView的列头信息
            this.lvvWebSrvClass.Items.Clear();//清除原来所有Item
            this.lvvWebSrvClass.Columns.Clear();//清除原来所有列头信息
            //this.lvvWebSrvClass.Columns.Add("表ID", 100, HorizontalAlignment.Left);
            this.lvvWebSrvClass.Columns.Add("表名", 260, HorizontalAlignment.Left);
            this.lvvWebSrvClass.Columns.Add("表中文名", 120, HorizontalAlignment.Left);
            this.lvvWebSrvClass.Columns.Add("功能模块", 100, HorizontalAlignment.Left);

            this.lvvWebSrvClass.Columns.Add("函数数", 60, HorizontalAlignment.Left);
            this.lvvWebSrvClass.Columns.Add("修改日期", 100, HorizontalAlignment.Left);
            this.lvvWebSrvClass.Columns.Add("生成日期", 100, HorizontalAlignment.Left);
            this.lvvWebSrvClass.Columns.Add("需要生成?", 80, HorizontalAlignment.Left);
            this.lvvWebSrvClass.Columns.Add("版本", 100, HorizontalAlignment.Left);

            //this.lvvWebSrvClass.Columns.Add("错误信息", 100, HorizontalAlignment.Left);

            this.lvvWebSrvClass.View = View.Details;
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            foreach (clsvWebSrvClass4GeneCodeEN objvWebSrvClassEN in arrvWebSrvClassObjList)
            {
                lvivWebSrvClass = new ListViewItem();
                lvivWebSrvClass.Tag = objvWebSrvClassEN.WebSrvClassId;
                lvivWebSrvClass.Text = objvWebSrvClassEN.ClsName;
                //lvivWebSrvClass.SubItems.Add(objvWebSrvClassEN.ClsName);
                lvivWebSrvClass.SubItems.Add(objvWebSrvClassEN.WebSrvUrl);
                lvivWebSrvClass.SubItems.Add(objvWebSrvClassEN.FuncModuleName);

                lvivWebSrvClass.SubItems.Add(objvWebSrvClassEN.FuncNum.ToString());
                lvivWebSrvClass.SubItems.Add(objvWebSrvClassEN.UpdDate);
                lvivWebSrvClass.SubItems.Add(GetShortDate(objvWebSrvClassEN.GeneCodeDate));
                lvivWebSrvClass.SubItems.Add(objvWebSrvClassEN.IsNeedGene ? "需要" : "不");

                lvivWebSrvClass.SubItems.Add(objvWebSrvClassEN.VersionGeneCode);
               

                this.lvvWebSrvClass.Items.Add(lvivWebSrvClass);
            }
            //	4、设置记录数的状态，
            //		在本界面中是把状态显示在控件txtRecCount中。
            this.lblRecNum.Text = "记录数：" + arrvWebSrvClassObjList.Count.ToString();
        }
        private string GetShortDate(string strDate)
        {
            if (strDate.Length > 3 && strDate.Length < 13)
                return strDate.Substring(2);
            else if (strDate.Length > 13)
                return strDate.Substring(2, 10);
            else return strDate;
        }


        ///// <summary>
        ///// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        /////			 并显示在ListView中。
        ///// </summary>
        //private void BindLv_vWebSrvClass_WithErrMsg()
        //{
        //    //操作步骤：(共4步)
        //    //	1、组合界面条件串；
        //    //	2、根据条件串获取该表满足条件的DataTable；
        //    //	3、设置ListView的列头信息
        //    //	4、设置ListView的Item信息。即把所有记录显示在ListView中
        //    //		在本界面中是把状态显示在控件lblRecCount中。

        //    ListViewItem lvivWebSrvClass;
        //    List<clsvWebSrvClass4GeneCodeEN> arrvWebSrvClass4ErrMsgObjList;
        //    //	1、组合界面条件串；
        //    string strWhereCond = this.CombineWebSrvClassCondion(false);	//  CombineWebSrvClassCondion();
        //    //	2、根据条件串获取该表满足条件的DataTable；
        //    //strWhereCond += "[Exclude]or [/Exclude]";
        //    try
        //    {
        //        arrvWebSrvClass4ErrMsgObjList = clsvWebSrvClass4GeneCodeExWApi.GetObjLstByUserIdAndCondition(clsSysParaEN.strUserId, strWhereCond);
        //    }
        //    catch (Exception objException)
        //    {
        //        MessageBox.Show(objException.Message);
        //        return;
        //    }
        //    //	3、设置ListView的列头信息
        //    this.lvvWebSrvClass.Items.Clear();//清除原来所有Item
        //    this.lvvWebSrvClass.Columns.Clear();//清除原来所有列头信息
        //    this.lvvWebSrvClass.Columns.Add("表名", 260, HorizontalAlignment.Left);
        //    this.lvvWebSrvClass.Columns.Add("表中文名", 120, HorizontalAlignment.Left);
        //    this.lvvWebSrvClass.Columns.Add("功能模块", 100, HorizontalAlignment.Left);

        //    this.lvvWebSrvClass.Columns.Add("函数数", 60, HorizontalAlignment.Left);
        //    this.lvvWebSrvClass.Columns.Add("修改日期", 100, HorizontalAlignment.Left);
        //    this.lvvWebSrvClass.Columns.Add("生成日期", 100, HorizontalAlignment.Left);

        //    this.lvvWebSrvClass.Columns.Add("版本", 90, HorizontalAlignment.Left);

        //    this.lvvWebSrvClass.View = View.Details;
        //    //	4、设置ListView的Item信息。即把所有记录显示在ListView中
        //    foreach (clsvWebSrvClass4GeneCodeEN objvWebSrvClass4ErrMsgEN in arrvWebSrvClass4ErrMsgObjList)
        //    {
        //        lvivWebSrvClass = new ListViewItem();
        //        lvivWebSrvClass.Tag = objvWebSrvClass4ErrMsgEN.WebSrvClassId;
        //        lvivWebSrvClass.Text = objvWebSrvClass4ErrMsgEN.ClsName;
        //        //lvivWebSrvClass.SubItems.Add(objvWebSrvClass4ErrMsgEN.ClsName);
        //        lvivWebSrvClass.SubItems.Add(objvWebSrvClass4ErrMsgEN.WebSrvUrl);
        //        lvivWebSrvClass.SubItems.Add(objvWebSrvClass4ErrMsgEN.FuncModuleName);

        //        lvivWebSrvClass.SubItems.Add(objvWebSrvClass4ErrMsgEN.FuncNum.ToString());
        //        lvivWebSrvClass.SubItems.Add(objvWebSrvClass4ErrMsgEN.UpdDate);
        //        lvivWebSrvClass.SubItems.Add(GetShortDate(objvWebSrvClass4ErrMsgEN.GeneCodeDate));
        //        lvivWebSrvClass.SubItems.Add(GetShortDate(objvWebSrvClass4ErrMsgEN.VersionGeneCode));

        //        //lvivWebSrvClass.SubItems.Add(objvWebSrvClass4ErrMsgEN.ErrMsg);

        //        this.lvvWebSrvClass.Items.Add(lvivWebSrvClass);
        //    }
        //    //	4、设置记录数的状态，
        //    //		在本界面中是把状态显示在控件txtRecCount中。
        //    this.lblRecNum.Text = "记录数：" + arrvWebSrvClass4ErrMsgObjList.Count.ToString();
        //}

        private void btnQuery_Click(object sender, System.EventArgs e)
        {
            //把表记录的内容显示在ListView中
            //if (chkDispAllErrMsg.Checked == true)
            //{
            //    BindLv_vWebSrvClass_WithErrMsg();
            //}
            //else
            //{
                BindLv_vWebSrvClass(false);
            //}
        }
        /// <summary>
        /// 获取DataGrid中当前行的主键值
        /// </summary>
        /// <param name="objDataGrid">所单击的DataGrid</param>
        /// <returns>当前行的主键值</returns>
        private string GetCurrKey(DataGrid objDataGrid)
        {
            int intCurrRow = objDataGrid.CurrentRowIndex;
            string strWebSrvClassId = objDTWebSrvClass.Rows[intCurrRow]["WebSrvClassId"].ToString();
            return strWebSrvClassId;
        }
        /// <summary>
        /// 获取ListView中当前行的主键值
        /// </summary>
        /// <param name="objListView">所单击的ListView</param>
        /// <returns>当前行的主键值</returns>
        private string GetCurrKey(ListView objListView)
        {
            if (objListView.SelectedItems.Count == 0)
            {
                return "";
            }
            ListViewItem lviWebSrvClass;
            lviWebSrvClass = objListView.SelectedItems[0];
            string strWebSrvClassId = lviWebSrvClass.Tag.ToString();
            return strWebSrvClassId;
        }
        /// <summary>
        /// 获取ListView所给项的主键值
        /// </summary>
        /// <param name="objListView">所单击的ListView项</param>
        /// <returns>当前行的主键值</returns>
        private string GetCurrKey(ListViewItem objListViewItem)
        {
            string strWebSrvClassId = objListViewItem.Tag.ToString();
            return strWebSrvClassId;
        }
        private void lvvWebSrvClass_Click(object sender, System.EventArgs e)
        {


        }


        private void btnDelRec_Click(object sender, System.EventArgs e)
        {
            DeleteWebSrvClassRecord();
        }
        private void btnExportExcel4Dg_Click(object sender, System.EventArgs e)
        {
            ExportExcel_SelColumns();	//新的导出EXCEL方式，用户可以选择导出字段列
            //ExportExcel();	//原来的方式导出EXCEL，用户不能选择导出字段列
        }
        /// <summary>
        /// 导出EXCEL的函数
        /// </summary>
        private void ExportExcel()
        {
            //	1、组合界面条件串；
            string strWhereCond = this.CombineWebSrvClassCondion(true);
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;// clsWebSrvClassWApi.GetDataTable_WebSrvClass(strWhereCond);
            ArrayList arrCnName = new ArrayList();
            ArrayList arrColName = new ArrayList();
            //string strFileName = "WebSrvClass信息导出.xls";
            //string strFolderName;
            string strDownLoadFileName;
            arrColName.Add(convWebSrvClass.WebSrvClassId); arrCnName.Add("表ID");
            arrColName.Add(convWebSrvClass.ClsName); arrCnName.Add("表名");
            arrColName.Add(convWebSrvClass.WebSrvUrl); arrCnName.Add("表中文名");
            arrColName.Add(convWebSrvClass.FuncModuleAgcId); arrCnName.Add("功能模块Id");
            arrColName.Add(convWebSrvClass.FuncModuleName); arrCnName.Add("功能模块名称");
            arrColName.Add(convWebSrvClass.WebSrvUrl); arrCnName.Add("Web服务Url");
            arrColName.Add(convWebSrvClass.UpdDate); arrCnName.Add("修改日期");
            arrColName.Add(convWebSrvClass.FuncModuleEnName); arrCnName.Add("功能模块英文名称");
            arrColName.Add(convWebSrvClass.PrjId); arrCnName.Add("工程ID");
            arrColName.Add(convWebSrvClass.PrjName); arrCnName.Add("工程名称");
            arrColName.Add(convWebSrvClass.Memo); arrCnName.Add("说明");
            //strFolderName = Application.StartupPath + "\\TempFiles";
            //if (Directory.Exists(strFolderName) == false)
            //{
            //Directory.CreateDirectory(strFolderName);
            //}
            //strDownLoadFileName = strFolderName + "\\" + strFileName;
            System.Windows.Forms.SaveFileDialog objSaveFileDialog = new SaveFileDialog();
            objSaveFileDialog.DefaultExt = "xls";
            objSaveFileDialog.Filter = "Excle文件(*.xls)|*.xls|所有文件(*.*)|*.*";
            objSaveFileDialog.ShowDialog();
            strDownLoadFileName = objSaveFileDialog.FileName;
            if (strDownLoadFileName == "")
            {
                return;
            }
            GetExcelFromDataTable.clsGetExcelFromDataTable objExcel = new GetExcelFromDataTable.clsGetExcelFromDataTable();
            objExcel.GetExcelFromDataTableByArrAndArray(objDT, arrColName, arrCnName, strDownLoadFileName);
            MessageBox.Show("导出Excel成功!，文件存放在：" + strDownLoadFileName);
        }
        /// <summary>
        /// 导出EXCEL的函数, 导出EXCEL时可以选择列
        /// </summary>
        private void ExportExcel_SelColumns()
        {
            //	1、组合界面条件串；
            string strWhereCond = this.CombineWebSrvClassCondion(true);
            //	2、设置表列数据字段名，以及表列标题
            ArrayList arrCnName = new ArrayList();
            ArrayList arrColName = new ArrayList();
            arrColName.Add("WebSrvClassId"); arrCnName.Add("表ID");
            arrColName.Add("ClassName"); arrCnName.Add("表名");
            arrColName.Add("WebSrvUrl"); arrCnName.Add("表中文名");
            arrColName.Add("FuncModuleAgcId"); arrCnName.Add("功能模块Id");
            arrColName.Add("FuncModuleName"); arrCnName.Add("功能模块名称");
            arrColName.Add("ObjId"); arrCnName.Add("所属对象");
            arrColName.Add("ObjName"); arrCnName.Add("对象名称");
            arrColName.Add("TabStateId"); arrCnName.Add("表状态ID");
            arrColName.Add("TabStateName"); arrCnName.Add("表状态名称");
            arrColName.Add("FldNum"); arrCnName.Add("FldNum");
            arrColName.Add("KeyFldName"); arrCnName.Add("KeyFldName");
            arrColName.Add("PrimaryTypeId"); arrCnName.Add("主键类型ID");
            arrColName.Add("PrimaryTypeName"); arrCnName.Add("PrimaryTypeName");
            arrColName.Add("SqlDsTypeId"); arrCnName.Add("数据源类型");
            arrColName.Add("SqlDsTypeName"); arrCnName.Add("Sql数据源名");
            arrColName.Add("ErrMsg"); arrCnName.Add("错误信息");
            arrColName.Add("IsTabPrimary"); arrCnName.Add("是否作为表中主键");
            arrColName.Add("Owner"); arrCnName.Add("拥有者");
            arrColName.Add("RelaViewId"); arrCnName.Add("相关视图ID");
            arrColName.Add("UpdDate"); arrCnName.Add("修改日期");
            arrColName.Add("UpdUserId"); arrCnName.Add("修改用户Id");
            arrColName.Add("IsArchive"); arrCnName.Add("是否存档");
            arrColName.Add("IsChecked"); arrCnName.Add("是否核实");
            arrColName.Add("ClassName_B"); arrCnName.Add("表名_后备");
            arrColName.Add("IsNationStandard"); arrCnName.Add("是否国标");
            arrColName.Add("IsParaTab"); arrCnName.Add("是否参数表");
            arrColName.Add("IsNeedTransCode"); arrCnName.Add("是否需要转换代码");
            arrColName.Add("FldID"); arrCnName.Add("字段ID");
            arrColName.Add("FuncModuleEnName"); arrCnName.Add("功能模块英文名称");
            arrColName.Add("DataBaseName"); arrCnName.Add("数据库名");
            arrColName.Add("DatabaseOwner"); arrCnName.Add("数据库拥有者");
            arrColName.Add("DataBaseUserId"); arrCnName.Add("数据库的用户ID");
            arrColName.Add("PrjId"); arrCnName.Add("工程ID");
            arrColName.Add("PrjName"); arrCnName.Add("工程名称");
            arrColName.Add("Memo"); arrCnName.Add("说明");
            ArrayList arrExportExcelList = new ArrayList();
            clsExportField objExportField = null;
            int intColNum = arrColName.Count;
            for (int i = 0; i < intColNum; i++)
            {
                objExportField = new clsExportField();
                objExportField.FieldEnglishName = arrColName[i].ToString();
                objExportField.FieldChineseName = arrCnName[i].ToString();
                arrExportExcelList.Add(objExportField);
            }
            /// 3、调用公用的导出EXCEL的界面，选择列后再导出
            frmExportExcel frm1 = new frmExportExcel();
            frm1.arrExportExcelList = arrExportExcelList;
            frm1.strTableName = "vWebSrvClass";
            frm1.strTableChineseName = "vWebSrvClass";
            frm1.strViewName = "工程表维护";
            frm1.strWhereCondition = strWhereCond;
            frm1.Show();
        }

        /// <summary>
        /// 函数功能：LISTVIEW的列单击事件函数
        /// </summary>
        private void lvvWebSrvClass_ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
        {
            if (e.Column == this.objvWebSrvClassSorter.SortColumn)
            {

            }
            else
            {
                this.objvWebSrvClassSorter.SortColumn = e.Column;
            }

            if (this.objvWebSrvClassSorter.SortOrder == SortOrder.Ascending)
            {
                this.objvWebSrvClassSorter.SortOrder = SortOrder.Descending;
                if (intLastSelectedvWebSrvClassColumIndex == e.Column) //看是否重复点击一列
                {
                    this.lvvWebSrvClass.Columns[e.Column].Text = this.lvvWebSrvClass.Columns[e.Column].Text.Trim('▲', '▼') + "▼";
                    intLastSelectedvWebSrvClassColumIndex = e.Column;
                }
                else //如果点击另外一列了，那么前面点击的一列三角去掉
                {
                    this.lvvWebSrvClass.Columns[e.Column].Text = this.lvvWebSrvClass.Columns[e.Column].Text.Trim('▲', '▼') + "▼";
                    this.lvvWebSrvClass.Columns[intLastSelectedvWebSrvClassColumIndex].Text = this.lvvWebSrvClass.Columns[intLastSelectedvWebSrvClassColumIndex].Text.Trim('▼', '▲');
                    intLastSelectedvWebSrvClassColumIndex = e.Column;
                }
            }
            else if (this.objvWebSrvClassSorter.SortOrder == SortOrder.Descending) // ▲ ▼
            {
                this.objvWebSrvClassSorter.SortOrder = SortOrder.Ascending;
                if (intLastSelectedvWebSrvClassColumIndex == e.Column)
                {
                    this.lvvWebSrvClass.Columns[e.Column].Text = this.lvvWebSrvClass.Columns[e.Column].Text.Trim('▲', '▼') + "▲";
                    intLastSelectedvWebSrvClassColumIndex = e.Column;
                }
                else
                {
                    this.lvvWebSrvClass.Columns[e.Column].Text = this.lvvWebSrvClass.Columns[e.Column].Text.Trim('▲', '▼') + "▲";
                    this.lvvWebSrvClass.Columns[intLastSelectedvWebSrvClassColumIndex].Text = this.lvvWebSrvClass.Columns[intLastSelectedvWebSrvClassColumIndex].Text.Trim('▲', '▼');
                    intLastSelectedvWebSrvClassColumIndex = e.Column;
                }
            }
            else
            {
                return;
            }
            this.lvvWebSrvClass.Sort();
        }

        /// <summary>
        /// 实现接口函数，通过子窗体调用，来实现本窗体(父窗体)的LISTVIEW重新绑定功能
        /// </summary>
        void IBindListView.BindListView()
        {
            BindLv_vWebSrvClass(false);
        }

        ///删除记录过程代码for C#
        private void DeleteWebSrvClassRecord()
        {
            DialogResult result;
            result = MessageBox.Show("你真的要删除该记录吗？", "确认删除", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (ListViewItem lvi in this.lvvWebSrvClass.SelectedItems)
                {
                    string strWebSrvClassId = GetCurrKey(lvi);
                    if (clsWebSrvClassWApi.DelRecord(strWebSrvClassId) == 0)
                    {
                        MessageBox.Show("删除记录失败！");
                        BindLv_vWebSrvClass(false);
                        return;
                    }
                }
                MessageBox.Show("删除记录成功！");
                BindLv_vWebSrvClass(false);
            }
        }
             
        private void txtFileName4GenCode_Click(object sender, EventArgs e)
        {
            txtFileName4GenCode.SelectAll();
        }

        private void txtCode_Click(object sender, EventArgs e)
        {
            txtCode.SelectAll();
        }

        private void btnAllTableThreeLayer_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            //string strFileName = "";
            List<string> arrWebSrvClassIdLst = clsWebSrvClassWApi.GetFldValue("WebSrvClassId", string.Format("PrjId='{0}' And TabStateId='01'", clsPubVar.CurrSelPrjId));

            if (arrWebSrvClassIdLst.Count == 0)
            {
                lblMsg.Text = "当前工程中没有记录，请选择一个有效的工程!";
                MessageBox.Show(lblMsg.Text);
                return;
            }
            if (cboCharEncodingId.SelectedIndex <= 0)
            {
                lblMsg.Text = "请选择一个生成文件的字符编码!";
                MessageBox.Show(lblMsg.Text);
                return;
            }
            string strCharEncodingId = cboCharEncodingId.SelectedValue.ToString();

            //保存当前选择的字符编码
            //clsPubFun.SaveCharEncodingId4PrjUser(clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId, strCharEncodingId);


            int intCount = 0;
            List<string> arrErrorLst = new List<string>();
            foreach (string strWebSrvClassId in arrWebSrvClassIdLst)
            {
                try
                {
                    //string strClsName = "";
                    //string strCodePath = "";
                    //clsUserCodePathEN objUserCodePathEN = null;
                    //string strCodeText = "";
                    //string strCodeText_Sim = "";

                    //if (rbMsSql.Checked == true)
                    //{
                    //    //生成新版-实体层
                    //    objUserCodePathEN = clsUserCodePathExWApi.GetObjByCodeTypeIdCache("0001", clsPubVar.CurrSelPrjId);
                    //    strCodeText = clsWebSrvClassExWApi.GeneEntityLayer(strWebSrvClassId,
                    //       clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId, clsSysParaEN.strUserId,
                    //       clsSysParaEN.strUserName,
                    //       objUserCodePathEN.NewCodePath, objUserCodePathEN.NewCodePathBackup,
                    //   strCharEncodingId, mltLangType, mdbtDataBaseType, ref strClsName, ref strCodePath, ref strFileName, ref strCodeText_Sim);

                    //    // 生成新版-数据处理层
                    //    objUserCodePathEN = clsUserCodePathExWApi.GetObjByCodeTypeIdCache("0002", clsPubVar.CurrSelPrjId);
                    //    strCodeText = clsWebSrvClassExWApi.GeneDataLayer(strWebSrvClassId, clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId,
                    //        clsSysParaEN.strUserId,
                    //         clsSysParaEN.strUserName,
                    //          objUserCodePathEN.NewCodePath, objUserCodePathEN.NewCodePathBackup,
                    //    strCharEncodingId, mltLangType, mdbtDataBaseType, ref strClsName, ref strCodePath);

                    //    //生成新版-业务逻辑层
                    //    objUserCodePathEN = clsUserCodePathExWApi.GetObjByCodeTypeIdCache("0003", clsPubVar.CurrSelPrjId);
                    //    strCodeText = clsWebSrvClassExWApi.GeneLogicLayer(strWebSrvClassId, clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId,
                    //        clsSysParaEN.strUserId,
                    //         clsSysParaEN.strUserName,
                    //         objUserCodePathEN.NewCodePath, objUserCodePathEN.NewCodePathBackup,
                    //    strCharEncodingId, mltLangType, mdbtDataBaseType, ref strClsName, ref strCodePath);
                    //}
                    //else if (rbOracle.Checked == true)
                    //{
                    //    //生成新版-实体层
                    //    objUserCodePathEN = clsUserCodePathExWApi.GetObjByCodeTypeIdCache("0001", clsPubVar.CurrSelPrjId);
                    //    strCodeText = clsWebSrvClassExWApi.GeneEntityLayer(strWebSrvClassId,
                    //       clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId, clsSysParaEN.strUserId,
                    //       clsSysParaEN.strUserName,
                    //       objUserCodePathEN.NewCodePath, objUserCodePathEN.NewCodePathBackup,
                    //   strCharEncodingId, mltLangType, mdbtDataBaseType, ref strClsName, ref strCodePath, ref strFileName, ref strCodeText_Sim);

                    //    // 生成新版-数据处理层
                    //    objUserCodePathEN = clsUserCodePathExWApi.GetObjByCodeTypeIdCache("0002", clsPubVar.CurrSelPrjId);
                    //    strCodeText = clsWebSrvClassExWApi.GeneDataLayer(strWebSrvClassId, clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId,
                    //        clsSysParaEN.strUserId,
                    //         clsSysParaEN.strUserName,
                    //          objUserCodePathEN.NewCodePath, objUserCodePathEN.NewCodePathBackup,
                    //    strCharEncodingId, mltLangType, mdbtDataBaseType, ref strClsName, ref strCodePath);

                    //    //生成新版-业务逻辑层
                    //    objUserCodePathEN = clsUserCodePathExWApi.GetObjByCodeTypeIdCache("0003", clsPubVar.CurrSelPrjId);
                    //    strCodeText = clsWebSrvClassExWApi.GeneLogicLayer(strWebSrvClassId, clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId,
                    //        clsSysParaEN.strUserId,
                    //         clsSysParaEN.strUserName,
                    //         objUserCodePathEN.NewCodePath, objUserCodePathEN.NewCodePathBackup,
                    //    strCharEncodingId, mltLangType, mdbtDataBaseType, ref strClsName, ref strCodePath);
                    //}
                    //else if (rbMySql.Checked == true)
                    //{
                    //    //生成新版-实体层
                    //    objUserCodePathEN = clsUserCodePathExWApi.GetObjByCodeTypeIdCache("0001", clsPubVar.CurrSelPrjId);
                    //    strCodeText = clsWebSrvClassExWApi.GeneEntityLayer(strWebSrvClassId,
                    //       clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId, clsSysParaEN.strUserId,
                    //       clsSysParaEN.strUserName,
                    //       objUserCodePathEN.NewCodePath, objUserCodePathEN.NewCodePathBackup,
                    //     strCharEncodingId, mltLangType, mdbtDataBaseType, ref strClsName, ref strCodePath, ref strFileName, ref strCodeText_Sim);

                    //    // 生成新版-数据处理层
                    //    objUserCodePathEN = clsUserCodePathExWApi.GetObjByCodeTypeIdCache("0002", clsPubVar.CurrSelPrjId);
                    //    strCodeText = clsWebSrvClassExWApi.GeneDataLayer(strWebSrvClassId, clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId,
                    //        clsSysParaEN.strUserId,
                    //         clsSysParaEN.strUserName,
                    //          objUserCodePathEN.NewCodePath, objUserCodePathEN.NewCodePathBackup,
                    //     strCharEncodingId, mltLangType, mdbtDataBaseType, ref strClsName, ref strCodePath);

                    //    //生成新版-业务逻辑层
                    //    objUserCodePathEN = clsUserCodePathExWApi.GetObjByCodeTypeIdCache("0003", "01", clsPubVar.CurrSelPrjId);
                    //    strCodeText = clsWebSrvClassExWApi.GeneLogicLayer(strWebSrvClassId, clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId,
                    //        clsSysParaEN.strUserId,
                    //         clsSysParaEN.strUserName,
                    //         objUserCodePathEN.NewCodePath, objUserCodePathEN.NewCodePathBackup,
                    //    strCharEncodingId, mltLangType, mdbtDataBaseType, ref strClsName, ref strCodePath);
                    //}


                    //objUserCodePathEN = clsPubVar.GetObjByCodeTypeIdCache("0008");
                    //strCodeText = clsWebSrvClassExWApi.GeneClassExLayer(strWebSrvClassId, clsPubVar.objCurrSelProjectEN,
                    //clsSysParaEN.strUserId,
                    // clsSysParaEN.strUserName,
                    // objUserCodePathEN.NewCodePath, objUserCodePathEN.NewCodePathBackup,
                    // ref strClsName, ref strCodePath);
                    intCount++;
                }
                catch (Exception objException)
                {
                    arrErrorLst.Add(objException.Message);
                    lblMsg.Text = objException.Message;
                    //MessageBox.Show(objException.Message);
                    //ErrorInformationWApi.AddInformation("wfmWebSrvClass_QUDI3.aspx", "lbAllTableThreeLayer_Click", objException.Message, clsSysParaEN.strUserId);
                    return;
                } //显示生成代码区域
            }
            StringBuilder sbMsg = new StringBuilder();
            sbMsg.AppendFormat("生成表完成6！共计：{0}个表。\r\n", intCount);
            foreach (string strMsg in arrErrorLst)
            {
                sbMsg.AppendFormat("{0}\r\n", strMsg);
            }
            MessageBox.Show(sbMsg.ToString());
            BindLv_vWebSrvClass(false);


        }

        private void btnGeneAllCheckedTableThreeLayer_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            List<string> arrWebSrvClassIdLst = GetSelectedWebSrvClassId();
            if (arrWebSrvClassIdLst == null)
            {
                return;
            }
            if (cboCharEncodingId.SelectedIndex <= 0)
            {
                lblMsg.Text = "请选择一个生成文件的字符编码!";
                MessageBox.Show(lblMsg.Text);
                return;
            }
            string strCharEncodingId = cboCharEncodingId.SelectedValue.ToString();

            objGeneCode_Local = new clsGeneCode_Local();
            Thread t1 = new Thread(new ParameterizedThreadStart(objGeneCode_Local.GeneAllCheckedWebSrvClassThreeLayer));
            //Thread thread = new Thread(new ParameterizedThreadStart(message.ShowMessage));
            t1.IsBackground = true;
            GeneCodeParameters myGeneCodeParameters = new GeneCodeParameters();
            myGeneCodeParameters.arrWebSrvClassIdLst = arrWebSrvClassIdLst;
            myGeneCodeParameters.strCharEncodingId = strCharEncodingId;
            myGeneCodeParameters.strTypeParas = typeParas;
            myGeneCodeParameters.mltLangType = mltLangType;
            myGeneCodeParameters.mdbtDataBaseType = mdbtDataBaseType;
            t1.Start(myGeneCodeParameters);
            progressBar1.Minimum = 0;
            progressBar1.Maximum = arrWebSrvClassIdLst.Count;
            //progressBar2.Minimum = 0;
            //progressBar2.Maximum = arrWebSrvClassIdLst.Count;

            timer1.Enabled = true;
            timer1.Start();
            //}
            //catch(Exception objException)
            //{
            //    MessageBox.Show(objException.Message);
            //}

        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            progressBar1.Value = objGeneCode_Local.intCurrIndex;
            //try
            //{
            //    progressBar2.Value = objGeneCode_Local.mintErrorNum;
            //}
            //catch(Exception objException)
            //{
            //    clsPubVar.objLog.WriteDebugLog(objException.Message);
            //}
            lblStatus.Text = string.Format("总表数:{0}，当前生成数:{1}, 占:{2}%",
                objGeneCode_Local.intAllTabCount, objGeneCode_Local.intCurrIndex,
                objGeneCode_Local.intCurrIndex * 1.0 / objGeneCode_Local.intAllTabCount * 100);
            lblErrNum.Text = string.Format("出错次数:{0}", objGeneCode_Local.arrErrorLst.Count);

            if (objGeneCode_Local.bolIsFinished == true)
            {
                timer1.Enabled = false;
                
              
                //txtFileName4GenCode.Text = objGeneCode_Local.Re_ClsName;
                txtCodePath.Text = objGeneCode_Local.ClassFName;
                //if (string.IsNullOrEmpty(objGeneCode_Local.strCodeText) == false)
                //{
                //    tabControl1.SelectedIndex = 1;
                //}
                if (objGeneCode_Local.intSuccessCount == objGeneCode_Local.intAllTabCount)
                {
                    lblStatus.Text = string.Format("生成成功!");
                }
                else
                {
                    lblStatus.Text = string.Format("生成部分成功!共生成：{0}文件.",
                        objGeneCode_Local.intSuccessCount);
                }
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.AppendFormat("生成表完成7！共生成：{0}个表。\r\n", objGeneCode_Local.intSuccessCount);
                foreach (string strMsg in objGeneCode_Local.arrErrorLst)
                {
                    sbMsg.AppendFormat("{0}\r\n", strMsg);
                }
                BindLv_vWebSrvClass(false);
                MessageBox.Show(sbMsg.ToString());
            }
            else
            {
                //lblStatus.Text = "传输过程中...";
            }
            //if (isVerify)
            //    MessageBox.Show("上传成功");
            //else
            //    MessageBox.Show("上传失败");
        }

        private void chkDispAllErrMsg_CheckedChanged(object sender, EventArgs e)
        {
            //把表记录的内容显示在ListView中
            //if (chkDispAllErrMsg.Checked == true)
            //{
            //    BindLv_vWebSrvClass_WithErrMsg();
            //}
            //else
            //{
                BindLv_vWebSrvClass(false);
            //}
        }

     
        private void btnClearCache_Click(object sender, EventArgs e)
        {

            var bol1 = clsPubFun4WApi.ClearCache4GeneCode(clsPubVar.CurrSelPrjId);
            string strMsg = "";
            if (bol1 == true)
            {
                strMsg = string.Format("刷新WebApi后台数据成功！");
            }
            else
            {
                strMsg = string.Format("刷新WebApi后台数据不成功！");
            }
            MessageBox.Show(strMsg);
            ////clsFieldSet.arrFieldObjLst = null;
            ////clsFieldSet.arrFieldTabObjLst = null;
            //clsFieldTabExWApi.arrFieldTabENExObjLst4WinApp = null;
            //clsFieldTabExWApi.arrFieldTabENExObjLstOrderByFldId_Cache = null;
        }

        private void btnGenWebServiceCode_Click(object sender, EventArgs e)
        {
            List<string> arrWebSrvClassIdLst = GetSelectedWebSrvClassId();
            if (arrWebSrvClassIdLst == null)
            {
                return;
            }

            if (cboCharEncodingId.SelectedIndex <= 0)
            {
                lblMsg.Text = "请选择一个生成文件的字符编码!";
                MessageBox.Show(lblMsg.Text);
                return;
            }
            string strCharEncodingId = cboCharEncodingId.SelectedValue.ToString();
            //string strCodeTypeId = "0000";
            //保存当前选择的字符编码
            //clsPubFun.SaveCharEncodingId4PrjUser(clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId, strCharEncodingId);

            int intCount = 0;
            //string strCodeText = "";
            lblMsg.Text = "";
            Encoding myEncoding = clsString.GetEncodingObjByCharEncodingId(strCharEncodingId);
            clsPubConst.ClassName cnClassName = clsPubConst.ClassName.WS_Srv;
            //string strClassName = clsPubConst.GetClassNameStringByClassName(cnClassName);
            string strCodeTypeId = clsCodeTypeExWApi.GetCodeTypeIdByClassNameCache(cnClassName, mltLangType);
            clsPubConst.ClassName cnClassName4Front = clsPubConst.ClassName.WS_Srv4Front;
            string strCodeTypeId_Front = clsCodeTypeExWApi.GetCodeTypeIdByClassNameCache(cnClassName4Front, mltLangType);
            //string strViewId = "";
            clsGCResult objGCResult = null;
            string strRe_ClsName = "";
            string strRe_FileNameWithModuleName = "";
            string strClassFName = "";
            string strMachineName = Environment.MachineName;
            int intApplicationTypeId = 0;
            var strCmPrjId = "";//cboCmPrjId.SelectedValue.ToString();
            //string strUserCodePrjMainPathId = "";
            long lngCMProjectAppRelaId = 0;
            try
            {
                lngCMProjectAppRelaId = clsCMProjectAppRelaExWApi.getCMProjectAppRelaId(strCmPrjId, intApplicationTypeId, clsPubVar.CurrSelPrjId);

                //var objUserCodePrjMainPath = clsUserCodePrjMainPathExWApi.GetObjExByCMProjectAppRelaIdCache(lngCMProjectAppRelaId, clsPubVar.CurrSelPrjId, strMachineName, clsSysParaEN.strUserId);
                //strUserCodePrjMainPathId = objUserCodePrjMainPath.UserCodePrjMainPathId;
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
                return;
            }
            foreach (string strWebSrvClassId in arrWebSrvClassIdLst)
            {
                try
                {
                    clsvUserCodePathEN objUserCodePathEN = clsvUserCodePathExWApi.GetObjByClassName(lngCMProjectAppRelaId, strCodeTypeId, clsPubVar.CurrSelPrjId, strCmPrjId, clsSysParaEN.strUserId, strMachineName);
                    clsPubFun.AccessIsExistPath(objUserCodePathEN);

                    //strCodeText = clsAutoGeneCodeWS.GeneCode4SelfCreateWs(cnClassName, typeParas,
                    //    mltLangType, mdbtDataBaseType, strWebSrvClassId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId,
                    //    clsSysParaEN.strUserId, ref strRe_ClsName, ref strRe_FileNameWithModuleName);

                    clsGCPara objGCPara = new clsGCPara()
                    {
                        applicationTypeId = 0,// this.applicationTypeId,
                        codeTypeId = strCodeTypeId,
                        dataBaseType = clsPubConst.GetDataBaseTypeStrByDataBaseType(mdbtDataBaseType),
                        tabId = "",
                        viewId = "",
                        webSrvClassId = strWebSrvClassId,
                        gcUserId = clsSysParaEN.strUserId,
                        prjDataBaseId = clsPubVar.CurrPrjDataBaseId,
                        prjId = clsPubVar.CurrSelPrjId,
                        typeParas = ""
                    };

                    objGCResult = AutoGeneCodeWApi.GeneCode4SelfCreateWs(objGCPara);


                    if (string.IsNullOrEmpty(strRe_FileNameWithModuleName) == true)
                    {
                        string strMsg = string.Format("在生成[{0}]类时， 带模块名的文件名为空，请检查！({1})", cnClassName, clsStackTrace.GetCurrClassFunction());
                        MessageBox.Show(strMsg);
                        return;
                    }
                    strClassFName = string.Format("{0}\\{1}",
                        objUserCodePathEN.NewCodePath,
                        strRe_FileNameWithModuleName);
                    clsPubFun4WApi.SaveClassContentToFile(strClassFName, objGCResult.codeText,
                        objUserCodePathEN.NewCodePath,
                        objUserCodePathEN.NewCodePathBackup, myEncoding);


                    clsvUserCodePathEN objUserCodePathEN4Front = clsvUserCodePathExWApi.GetObjByClassName(lngCMProjectAppRelaId, strCodeTypeId, clsPubVar.CurrSelPrjId, strCmPrjId, clsSysParaEN.strUserId, strMachineName);
                    clsPubFun.AccessIsExistPath(objUserCodePathEN);

                    //string strCodeText4Front = clsAutoGeneCodeWS.GeneCode4SelfCreateWs(cnClassName4Front, typeParas,
                    //         mltLangType, mdbtDataBaseType, strWebSrvClassId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId,
                    //         clsSysParaEN.strUserId, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                    objGCPara = new clsGCPara()
                    {
                        applicationTypeId = 0,// this.applicationTypeId,
                        codeTypeId = strCodeTypeId_Front,
                        dataBaseType = clsPubConst.GetDataBaseTypeStrByDataBaseType(mdbtDataBaseType),
                        tabId = "",
                        viewId = "",
                        webSrvClassId = strWebSrvClassId,
                        gcUserId = clsSysParaEN.strUserId,
                        prjDataBaseId = clsPubVar.CurrPrjDataBaseId,
                        prjId = clsPubVar.CurrSelPrjId,
                        typeParas = ""
                    };

                    objGCResult = AutoGeneCodeWApi.GeneCode4SelfCreateWs(objGCPara);


                    if (string.IsNullOrEmpty(strRe_FileNameWithModuleName) == true)
                    {
                        string strMsg = string.Format("在生成[{0}]类时， 带模块名的文件名为空，请检查！({1})", cnClassName, clsStackTrace.GetCurrClassFunction());
                        MessageBox.Show(strMsg);
                        return;
                    }
                    strClassFName = string.Format("{0}\\{1}",
                        objUserCodePathEN4Front.CodePath,
                        strRe_FileNameWithModuleName);
                    clsPubFun4WApi.SaveClassContentToFile(strClassFName, objGCResult.codeText,
                        objUserCodePathEN4Front.CodePath,
                        objUserCodePathEN4Front.CodePathBackup, myEncoding);

                    //clsUserCodePathEN objUserCodePathEN = clsUserCodePathExWApi.GetObjByCodeTypeIdCache("0009", clsPubVar.CurrSelPrjId);

                    //strCodeText = clsWebSrvClassExWApi.GenWebServiceCode(strWebSrvClassId, clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId,
                    //    clsSysParaEN.strUserId,
                    //     clsSysParaEN.strUserName, objUserCodePathEN.NewCodePath, objUserCodePathEN.NewCodePathBackup,
                    //     strCharEncodingId, ref strClsName, ref strCodePath);
                    intCount++;
                }
                catch (Exception objException)
                {
                    lblMsg.Text = objException.Message;
                    MessageBox.Show(objException.Message);
                    return;
                }
            }
            if (intCount > 0)
            {
                if (objGCResult == null) return;
                txtCode.Text = objGCResult.codeText;
                txtFileName4GenCode.Text = strRe_ClsName;
                txtCodePath.Text = strClassFName;
                tabControl1.SelectedIndex = 1;//.TabPages[1].Focus();
                MessageBox.Show("生成表完成8！共计：" + intCount.ToString() + "个表。");
                BindLv_vWebSrvClass(false);
            }
        }

        private void btnGenWS_Access_Click(object sender, EventArgs e)
        {
            List<string> arrWebSrvClassIdLst = GetSelectedWebSrvClassId();
            if (arrWebSrvClassIdLst == null)
            {
                return;
            }

            if (cboCharEncodingId.SelectedIndex <= 0)
            {
                lblMsg.Text = "请选择一个生成文件的字符编码!";
                MessageBox.Show(lblMsg.Text);
                return;
            }
            string strMachineName = Environment.MachineName;
            string strCharEncodingId = cboCharEncodingId.SelectedValue.ToString();

            //保存当前选择的字符编码
            //clsPubFun.SaveCharEncodingId4PrjUser(clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId, strCharEncodingId);

            int intCount = 0;
        
            lblMsg.Text = "";

            Encoding myEncoding = clsString.GetEncodingObjByCharEncodingId(strCharEncodingId);
            clsPubConst.ClassName cnClassName = clsPubConst.ClassName.WS_Access;
            string strCodeTypeId = clsCodeTypeExWApi.GetCodeTypeIdByClassNameCache(cnClassName, mltLangType);
            //string strViewId = "";
            clsGCResult objGCResult = null;
         
            string strClassFName = "";
            int intApplicationTypeId = 0;
            var strCmPrjId = "";//cboCmPrjId.SelectedValue.ToString();
            long lngCMProjectAppRelaId = 0;
            try
            {
                lngCMProjectAppRelaId = clsCMProjectAppRelaExWApi.getCMProjectAppRelaId(strCmPrjId, intApplicationTypeId, clsPubVar.CurrSelPrjId);

                //var objUserCodePrjMainPath = clsUserCodePrjMainPathExWApi.GetObjExByCMProjectAppRelaIdCache(lngCMProjectAppRelaId, clsPubVar.CurrSelPrjId, strMachineName, 
                //    clsSysParaEN.strUserId);
                //strUserCodePrjMainPathId = objUserCodePrjMainPath.UserCodePrjMainPathId;
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
                return;
            }
            foreach (string strWebSrvClassId in arrWebSrvClassIdLst)
            {
                try
                {
                    clsvUserCodePathEN objUserCodePathEN = clsvUserCodePathExWApi.GetObjByClassName(lngCMProjectAppRelaId, strCodeTypeId, clsPubVar.CurrSelPrjId, strCmPrjId, clsSysParaEN.strUserId, strMachineName);
                    clsPubFun.AccessIsExistPath(objUserCodePathEN);

                    //strCodeText = clsAutoGeneCodeWS.GeneCode4SelfCreateWs(cnClassName, typeParas,
                    //    mltLangType, mdbtDataBaseType, strWebSrvClassId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId,
                    //    clsSysParaEN.strUserId, ref strRe_ClsName, ref strRe_FileNameWithModuleName);

                    clsGCPara objGCPara = new clsGCPara()
                    {
                        applicationTypeId = 0,// this.applicationTypeId,
                        codeTypeId = strCodeTypeId,
                        dataBaseType = clsPubConst.GetDataBaseTypeStrByDataBaseType(mdbtDataBaseType),
                        tabId = "",
                        viewId = "",
                        webSrvClassId = strWebSrvClassId,
                        gcUserId = clsSysParaEN.strUserId,
                        prjDataBaseId = clsPubVar.CurrPrjDataBaseId,
                        prjId = clsPubVar.CurrSelPrjId,
                        typeParas = ""
                    };

                    objGCResult = AutoGeneCodeWApi.GeneCode4SelfCreateWs(objGCPara);


                    if (string.IsNullOrEmpty(objGCResult.re_FileNameWithModuleName) == true)
                    {
                        string strMsg = string.Format("在生成[{0}]类时， 带模块名的文件名为空，请检查！({1})", cnClassName, clsStackTrace.GetCurrClassFunction());
                        MessageBox.Show(strMsg);
                        return;
                    }
                    strClassFName = string.Format("{0}\\{1}",
                        objUserCodePathEN.NewCodePath,
                        objGCResult.re_FileNameWithModuleName);
                    clsPubFun4WApi.SaveClassContentToFile(strClassFName, objGCResult.codeText,
                        objUserCodePathEN.NewCodePath,
                        objUserCodePathEN.NewCodePathBackup, myEncoding);


                    //clsUserCodePathEN objUserCodePathEN = clsUserCodePathExWApi.GetObjByCodeTypeIdCache("0010", clsPubVar.CurrSelPrjId);

                    //strCodeText = clsWebSrvClassExWApi.GenWS_Access(strWebSrvClassId, clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId,
                    //    clsSysParaEN.strUserId,
                    //     clsSysParaEN.strUserName, objUserCodePathEN.NewCodePath, objUserCodePathEN.NewCodePathBackup,
                    //     strCharEncodingId, mltLangType, mdbtDataBaseType, ref strClsName, ref strCodePath);
                    intCount++;
                }
                catch (Exception objException)
                {
                    lblMsg.Text = objException.Message;
                    MessageBox.Show(objException.Message);
                }
            }
            if (intCount > 0)
            {
                if (objGCResult == null) return;
                txtCode.Text = objGCResult.codeText;
                txtFileName4GenCode.Text = objGCResult.re_ClsName;
                txtCodePath.Text = strClassFName;
                tabControl1.SelectedIndex = 1;//.TabPages[1].Focus();
                MessageBox.Show("生成表完成9！共计：" + intCount.ToString() + "个表。");
                BindLv_vWebSrvClass(false);
            }

        }

        private void btnQueryNoTimelyGeneTabs_Click(object sender, EventArgs e)
        {
            BindLv_vWebSrvClass(true);
        }


        private void rbMsSql_CheckedChanged(object sender, EventArgs e)
        {
            GetDataBaseTypeByRadioButton();
        }

        private void GetDataBaseTypeByRadioButton()
        {
            if (rbMsSql.Checked == true)
            {
                mdbtDataBaseType = clsPubConst.DataBaseType.MsSql;

            }
            else if (rbMySql.Checked == true)
            {
                mdbtDataBaseType = clsPubConst.DataBaseType.MySql;

            }
            else
            {
                mdbtDataBaseType = clsPubConst.DataBaseType.Oracle;

            }
        }
        //private void GetLangTypeByRadioButton()
        //{
        //    if (rbDotNet.Checked == true)
        //    {
        //        mltLangType = clsPubConst.LangType.CSharp;
        //    }
        //    else if (rbJava.Checked == true)
        //    {
        //        mltLangType = clsPubConst.LangType.JAVA;
        //    }
        //    else if (rbSwift.Checked == true)
        //    {
        //        mltLangType = clsPubConst.LangType.Swift;
        //    }
        //    else if (rbSilverLight.Checked == true)
        //    {
        //        mltLangType = clsPubConst.LangType.SilverLight;
        //    }
        //    else if (rbJavaScript.Checked == true)
        //    {
        //        mltLangType = clsPubConst.LangType.JavaScript;
        //    }

        //}
        private void DispClassNameButton()
        {
            int intApplicationTypeId = 0;
            List<clsvCodeType_SimEN> arrCodeTypeObjList = clsCodeTypeExWApi.GetCodeTypeObjLstByApplicationType4Back(intApplicationTypeId,"");
            foreach (Control objControl in flpClassNameButtonList.Controls)
            {
                string strTypeName = objControl.GetType().ToString();
                if (strTypeName.IndexOf("Button") > 0)
                {
                    clsCodeTypeExWApi.IsCanVisible(arrCodeTypeObjList, objControl as Button);
                }
            }
        }

        private void rbOracle_CheckedChanged(object sender, EventArgs e)
        {
            GetDataBaseTypeByRadioButton();
        }

        private void rbMySql_CheckedChanged(object sender, EventArgs e)
        {
            GetDataBaseTypeByRadioButton();
        }

        private void lvvWebSrvClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGeneWS_AccessHigh_Click(object sender, EventArgs e)
        {
            List<string> arrWebSrvClassIdLst = GetSelectedWebSrvClassId();
            if (arrWebSrvClassIdLst == null)
            {
                return;
            }

            if (cboCharEncodingId.SelectedIndex <= 0)
            {
                lblMsg.Text = "请选择一个生成文件的字符编码!";
                MessageBox.Show(lblMsg.Text);
                return;
            }
            string strMachineName = Environment.MachineName;
            string strCharEncodingId = cboCharEncodingId.SelectedValue.ToString();

            //保存当前选择的字符编码
            //clsPubFun.SaveCharEncodingId4PrjUser(clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId, strCharEncodingId);

            int intCount = 0;
            lblMsg.Text = "";
            Encoding myEncoding = clsString.GetEncodingObjByCharEncodingId(strCharEncodingId);
            clsPubConst.ClassName cnClassName = clsPubConst.ClassName.WS_AccessHigh;
            string strCodeTypeId = clsCodeTypeExWApi.GetCodeTypeIdByClassNameCache(cnClassName, mltLangType);
            //string strViewId = "";
            clsGCResult objGCResult = null;
            
            string strClassFName = "";
            int intApplicationTypeId = 0;
            var strCmPrjId = "";//cboCmPrjId.SelectedValue.ToString();
            long lngCMProjectAppRelaId = 0;
            try
            {
                lngCMProjectAppRelaId = clsCMProjectAppRelaExWApi.getCMProjectAppRelaId(strCmPrjId, intApplicationTypeId, clsPubVar.CurrSelPrjId);

                //var objUserCodePrjMainPath = clsUserCodePrjMainPathExWApi.GetObjExByCMProjectAppRelaIdCache(lngCMProjectAppRelaId, clsPubVar.CurrSelPrjId, strMachineName, 
                //    clsSysParaEN.strUserId);
                //strUserCodePrjMainPathId = objUserCodePrjMainPath.UserCodePrjMainPathId;
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
                return;
            }
            foreach (string strWebSrvClassId in arrWebSrvClassIdLst)
            {
                try
                {
                    clsvUserCodePathEN objUserCodePathEN = clsvUserCodePathExWApi.GetObjByClassName(lngCMProjectAppRelaId, strCodeTypeId, clsPubVar.CurrSelPrjId, strCmPrjId, clsSysParaEN.strUserId, strMachineName);
                    clsPubFun.AccessIsExistPath(objUserCodePathEN);

                    //strCodeText = clsAutoGeneCodeWS.GeneCode4SelfCreateWs(cnClassName, typeParas,
                    //    mltLangType, mdbtDataBaseType, strWebSrvClassId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId,
                    //    clsSysParaEN.strUserId, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                    clsGCPara objGCPara = new clsGCPara()
                    {
                        applicationTypeId = 0,// this.applicationTypeId,
                        codeTypeId = strCodeTypeId,
                        dataBaseType = clsPubConst.GetDataBaseTypeStrByDataBaseType(mdbtDataBaseType),
                        tabId = "",
                        viewId = "",
                        webSrvClassId = strWebSrvClassId,
                        gcUserId = clsSysParaEN.strUserId,
                        prjDataBaseId = clsPubVar.CurrPrjDataBaseId,
                        prjId = clsPubVar.CurrSelPrjId,
                        typeParas = ""
                    };

                    objGCResult = AutoGeneCodeWApi.GeneCode4SelfCreateWs(objGCPara);

                    if (string.IsNullOrEmpty(objGCResult.re_FileNameWithModuleName) == true)
                    {
                        string strMsg = string.Format("在生成[{0}]类时， 带模块名的文件名为空，请检查！({1})", cnClassName, clsStackTrace.GetCurrClassFunction());
                        MessageBox.Show(strMsg);
                        return;
                    }
                    strClassFName = string.Format("{0}\\{1}",
                        objUserCodePathEN.NewCodePath,
                        objGCResult.re_FileNameWithModuleName);
                    clsPubFun4WApi.SaveClassContentToFile(strClassFName, objGCResult.codeText,
                        objUserCodePathEN.NewCodePath,
                        objUserCodePathEN.NewCodePathBackup, myEncoding);


                    //clsUserCodePathEN objUserCodePathEN = clsUserCodePathExWApi.GetObjByCodeTypeIdCache("0010", clsPubVar.CurrSelPrjId);

                    //strCodeText = clsWebSrvClassExWApi.GenWS_Access(strWebSrvClassId, clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId,
                    //    clsSysParaEN.strUserId,
                    //     clsSysParaEN.strUserName, objUserCodePathEN.NewCodePath, objUserCodePathEN.NewCodePathBackup,
                    //     strCharEncodingId, mltLangType, mdbtDataBaseType, ref strClsName, ref strCodePath);
                    intCount++;
                }
                catch (Exception objException)
                {
                    lblMsg.Text = objException.Message;
                    MessageBox.Show(objException.Message);
                }
            }
            if (intCount > 0)
            {
                if (objGCResult == null) return;
                txtCode.Text = objGCResult.codeText;
                txtFileName4GenCode.Text = objGCResult.re_ClsName;
                txtCodePath.Text = strClassFName;
                tabControl1.SelectedIndex = 1;//.TabPages[1].Focus();
                MessageBox.Show("生成表完成10！共计：" + intCount.ToString() + "个表。");
                BindLv_vWebSrvClass(false);
            }
        }

        private void btnGeneAppController_Click(object sender, EventArgs e)
        {
            List<string> arrWebSrvClassIdLst = GetSelectedWebSrvClassId();
            if (arrWebSrvClassIdLst == null)
            {
                return;
            }

            if (cboCharEncodingId.SelectedIndex <= 0)
            {
                lblMsg.Text = "请选择一个生成文件的字符编码!";
                MessageBox.Show(lblMsg.Text);
                return;
            }
            string strCharEncodingId = cboCharEncodingId.SelectedValue.ToString();

            //保存当前选择的字符编码
            //clsPubFun.SaveCharEncodingId4PrjUser(clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId, strCharEncodingId);

            int intCount = 0;
            lblMsg.Text = "";

            Encoding myEncoding = clsString.GetEncodingObjByCharEncodingId(strCharEncodingId);
            clsPubConst.ClassName cnClassName = clsPubConst.ClassName.AppController;
            string strCodeTypeId = clsCodeTypeExWApi.GetCodeTypeIdByClassNameCache(cnClassName, mltLangType);
            clsGCResult objGCResult = null;
            //string strViewId = "";
            //string strRe_ClsName = "";
            //string strRe_FileNameWithModuleName = "";
            string strClassFName = "";
            string strMachineName = Environment.MachineName;
            int intApplicationTypeId = 0;
            var strCmPrjId = "";//cboCmPrjId.SelectedValue.ToString();
            long lngCMProjectAppRelaId = 0;
            try
            {
                lngCMProjectAppRelaId = clsCMProjectAppRelaExWApi.getCMProjectAppRelaId(strCmPrjId, intApplicationTypeId, clsPubVar.CurrSelPrjId);
                //var objUserCodePrjMainPath = clsUserCodePrjMainPathExWApi.GetObjExByCMProjectAppRelaIdCache(lngCMProjectAppRelaId, clsPubVar.CurrSelPrjId, strMachineName, 
                //    clsSysParaEN.strUserId);
                //strUserCodePrjMainPathId = objUserCodePrjMainPath.UserCodePrjMainPathId;
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
                return;
            }
            foreach (string strWebSrvClassId in arrWebSrvClassIdLst)
            {
                try
                {
                    clsvUserCodePathEN objUserCodePathEN = clsvUserCodePathExWApi.GetObjByClassName(lngCMProjectAppRelaId, strCodeTypeId, clsPubVar.CurrSelPrjId, strCmPrjId, clsSysParaEN.strUserId, strMachineName);
                    clsPubFun.AccessIsExistPath(objUserCodePathEN);

                    //strCodeText = clsAutoGeneCodeWS.GeneCode4SelfCreateWs(cnClassName, typeParas,
                    //    mltLangType, mdbtDataBaseType, strWebSrvClassId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId,
                    //    clsSysParaEN.strUserId, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                    clsGCPara objGCPara = new clsGCPara()
                    {
                        applicationTypeId = 0,// this.applicationTypeId,
                        codeTypeId = strCodeTypeId,
                        dataBaseType = clsPubConst.GetDataBaseTypeStrByDataBaseType(mdbtDataBaseType),
                        tabId = "",
                        viewId = "",
                        webSrvClassId = strWebSrvClassId,
                        gcUserId = clsSysParaEN.strUserId,
                        prjDataBaseId = clsPubVar.CurrPrjDataBaseId,
                        prjId = clsPubVar.CurrSelPrjId,
                        typeParas = ""
                    };

                    objGCResult = AutoGeneCodeWApi.GeneCode4SelfCreateWs(objGCPara);
                    if (string.IsNullOrEmpty(objGCResult.re_FileNameWithModuleName) == true)
                    {
                        string strMsg = string.Format("在生成[{0}]类时， 带模块名的文件名为空，请检查！({1})", cnClassName, clsStackTrace.GetCurrClassFunction());
                        MessageBox.Show(strMsg);
                        return;
                    }
                    strClassFName = string.Format("{0}\\{1}",
                        objUserCodePathEN.NewCodePath,
                        objGCResult.re_FileNameWithModuleName);
                    clsPubFun4WApi.SaveClassContentToFile(strClassFName, objGCResult.codeText,
                        objUserCodePathEN.NewCodePath,
                        objUserCodePathEN.NewCodePathBackup, myEncoding);


                    //clsUserCodePathEN objUserCodePathEN = clsUserCodePathExWApi.GetObjByCodeTypeIdCache("0010", clsPubVar.CurrSelPrjId);

                    //strCodeText = clsWebSrvClassExWApi.GenWS_Access(strWebSrvClassId, clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId,
                    //    clsSysParaEN.strUserId,
                    //     clsSysParaEN.strUserName, objUserCodePathEN.NewCodePath, objUserCodePathEN.NewCodePathBackup,
                    //     strCharEncodingId, mltLangType, mdbtDataBaseType, ref strClsName, ref strCodePath);
                    intCount++;
                }
                catch (Exception objException)
                {
                    lblMsg.Text = objException.Message;
                    MessageBox.Show(objException.Message);
                }
            }
            if (intCount > 0)
            {
                if (objGCResult == null) return;
                txtCode.Text = objGCResult.codeText;
                txtFileName4GenCode.Text = objGCResult.re_ClsName;
                txtCodePath.Text = strClassFName;
                tabControl1.SelectedIndex = 1;//.TabPages[1].Focus();
                MessageBox.Show("生成表完成11！共计：" + intCount.ToString() + "个表。");
                BindLv_vWebSrvClass(false);
            }
        }

        private void btnGeneCommFun4BL_Click(object sender, EventArgs e)
        {
            List<string> arrWebSrvClassIdLst = GetSelectedWebSrvClassId();
            if (arrWebSrvClassIdLst == null)
            {
                return;
            }

            if (cboCharEncodingId.SelectedIndex <= 0)
            {
                lblMsg.Text = "请选择一个生成文件的字符编码!";
                MessageBox.Show(lblMsg.Text);
                return;
            }
            string strCharEncodingId = cboCharEncodingId.SelectedValue.ToString();

            //保存当前选择的字符编码
            //clsPubFun.SaveCharEncodingId4PrjUser(clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId, strCharEncodingId);

            int intCount = 0;
            lblMsg.Text = "";
   
            Encoding myEncoding = clsString.GetEncodingObjByCharEncodingId(strCharEncodingId);
            clsPubConst.ClassName cnClassName = clsPubConst.ClassName.CommFun4BL;
            string strCodeTypeId = clsCodeTypeExWApi.GetCodeTypeIdByClassNameCache(cnClassName, mltLangType);
            //string strViewId = "";
            clsGCResult objGCResult = null;
            string strClassFName = "";
            string strMachineName = Environment.MachineName;
            int intApplicationTypeId = 0;
            var strCmPrjId = "";//cboCmPrjId.SelectedValue.ToString();
            long lngCMProjectAppRelaId = 0;
            try
            {
                 lngCMProjectAppRelaId = clsCMProjectAppRelaExWApi.getCMProjectAppRelaId(strCmPrjId, intApplicationTypeId, clsPubVar.CurrSelPrjId);

                //var objUserCodePrjMainPath = clsUserCodePrjMainPathExWApi.GetObjExByCMProjectAppRelaIdCache(lngCMProjectAppRelaId, clsPubVar.CurrSelPrjId, strMachineName, 
                //    clsSysParaEN.strUserId);
                //strUserCodePrjMainPathId = objUserCodePrjMainPath.UserCodePrjMainPathId;
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
                return;
            }
            foreach (string strWebSrvClassId in arrWebSrvClassIdLst)
            {
                try
                {
                    clsvUserCodePathEN objUserCodePathEN = clsvUserCodePathExWApi.GetObjByClassName(lngCMProjectAppRelaId, strCodeTypeId, clsPubVar.CurrSelPrjId, strCmPrjId, clsSysParaEN.strUserId, strMachineName);
                    clsPubFun.AccessIsExistPath(objUserCodePathEN);

                    //strCodeText = clsAutoGeneCodeWS.GeneCode4SelfCreateWs(cnClassName, typeParas,
                    //    mltLangType, mdbtDataBaseType, strWebSrvClassId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId,
                    //    clsSysParaEN.strUserId, ref strRe_ClsName, ref strRe_FileNameWithModuleName);

                    clsGCPara objGCPara = new clsGCPara()
                    {
                        applicationTypeId = 0,// this.applicationTypeId,
                        codeTypeId = strCodeTypeId,
                        dataBaseType = clsPubConst.GetDataBaseTypeStrByDataBaseType(mdbtDataBaseType),
                        tabId = "",
                        viewId = "",
                        webSrvClassId = strWebSrvClassId,
                        gcUserId = clsSysParaEN.strUserId,
                        prjDataBaseId = clsPubVar.CurrPrjDataBaseId,
                        prjId = clsPubVar.CurrSelPrjId,
                        typeParas = ""
                    };

                    objGCResult = AutoGeneCodeWApi.GeneCode4SelfCreateWs(objGCPara);

                    if (string.IsNullOrEmpty(objGCResult.codeText) == true)
                    {
                        continue;
                    }
                    if (string.IsNullOrEmpty(objGCResult.re_FileNameWithModuleName) == true)
                    {
                        string strMsg = string.Format("在生成[{0}]类时， 带模块名的文件名为空，请检查！({1})", cnClassName, clsStackTrace.GetCurrClassFunction());
                        MessageBox.Show(strMsg);
                        return;
                    }
                    strClassFName = string.Format("{0}\\{1}",
                        objUserCodePathEN.NewCodePath,
                        objGCResult.re_FileNameWithModuleName);
                    clsvCodeType_SimEN objCodeTypeEN = clsvCodeType_SimWApi.GetObjByCodeTypeIdCache("0020");
                    if (objCodeTypeEN.IsDefaultOverride == true)
                    {
                        clsPubFun4WApi.SaveClassContentToFile(strClassFName, objGCResult.codeText,
                            objUserCodePathEN.NewCodePath,
                            objUserCodePathEN.NewCodePathBackup, myEncoding);
                    }
                    else
                    {
                        var c = clsPubFun4WApi.SaveClassContentToFile_NoCover(strClassFName, objGCResult.codeText,
                        objUserCodePathEN.NewCodePath, null, myEncoding);
                    }
                    //clsUserCodePathEN objUserCodePathEN = clsUserCodePathExWApi.GetObjByCodeTypeIdCache("0010", clsPubVar.CurrSelPrjId);

                    //strCodeText = clsWebSrvClassExWApi.GenWS_Access(strWebSrvClassId, clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId,
                    //    clsSysParaEN.strUserId,
                    //     clsSysParaEN.strUserName, objUserCodePathEN.NewCodePath, objUserCodePathEN.NewCodePathBackup,
                    //     strCharEncodingId, mltLangType, mdbtDataBaseType, ref strClsName, ref strCodePath);
                    intCount++;
                }
                catch (Exception objException)
                {
                    lblMsg.Text = objException.Message;
                    MessageBox.Show(objException.Message);
                }
            }
            if (intCount > 0)
            {
                if (objGCResult == null) return;
                txtCode.Text = objGCResult.codeText;
                txtFileName4GenCode.Text = objGCResult.re_ClsName;
                txtCodePath.Text = strClassFName;
                tabControl1.SelectedIndex = 1;//.TabPages[1].Focus();
                MessageBox.Show("生成表完成12！共计：" + intCount.ToString() + "个表。");
                BindLv_vWebSrvClass(false);
            }

        }

        private void btnGenDALExCode_Click(object sender, EventArgs e)
        {
            List<string> arrWebSrvClassIdLst = GetSelectedWebSrvClassId();
            if (arrWebSrvClassIdLst == null)
            {
                return;
            }
            if (cboCharEncodingId.SelectedIndex <= 0)
            {
                lblMsg.Text = "请选择一个生成文件的字符编码!";
                MessageBox.Show(lblMsg.Text);
                return;
            }
            string strCharEncodingId = cboCharEncodingId.SelectedValue.ToString();
            Encoding myEncoding = clsString.GetEncodingObjByCharEncodingId(strCharEncodingId);

            //保存当前选择的字符编码
            //clsPubFun.SaveCharEncodingId4PrjUser(clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId, strCharEncodingId);
            clsPubConst.ClassName cnClassName = clsPubConst.ClassName.DALExCode;
            string strCodeTypeId = clsCodeTypeExWApi.GetCodeTypeIdByClassNameCache(cnClassName, mltLangType);
            clsGCResult objGCResult = null;
            //string strViewId = "";
            string strClassFName = "";
            int intCount = 0;
    
            lblMsg.Text = "";
            string strMachineName = Environment.MachineName;
            int intApplicationTypeId = 0;
            var strCmPrjId = "";//cboCmPrjId.SelectedValue.ToString();
            long lngCMProjectAppRelaId = 0;
            try
            {
                lngCMProjectAppRelaId = clsCMProjectAppRelaExWApi.getCMProjectAppRelaId(strCmPrjId, intApplicationTypeId, clsPubVar.CurrSelPrjId);

                //var objUserCodePrjMainPath = clsUserCodePrjMainPathExWApi.GetObjExByCMProjectAppRelaIdCache(lngCMProjectAppRelaId, clsPubVar.CurrSelPrjId, strMachineName, 
                //    clsSysParaEN.strUserId);
                //strUserCodePrjMainPathId = objUserCodePrjMainPath.UserCodePrjMainPathId;
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
                return;
            }
            foreach (string strWebSrvClassId in arrWebSrvClassIdLst)
            {
                try
                {
                    clsvUserCodePathEN objUserCodePathEN = clsvUserCodePathExWApi.GetObjByClassName(lngCMProjectAppRelaId, strCodeTypeId, clsPubVar.CurrSelPrjId, strCmPrjId, clsSysParaEN.strUserId, strMachineName);
                    clsPubFun.AccessIsExistPath(objUserCodePathEN);

                    //strCodeText = clsAutoGeneCodeWS.GeneCode4SelfCreateWs(cnClassName, typeParas,
                    //    mltLangType, mdbtDataBaseType, strWebSrvClassId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId,
                    //    clsSysParaEN.strUserId, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                    clsGCPara objGCPara = new clsGCPara()
                    {
                        applicationTypeId = 0,// this.applicationTypeId,
                        codeTypeId = strCodeTypeId,
                        dataBaseType = clsPubConst.GetDataBaseTypeStrByDataBaseType(mdbtDataBaseType),
                        tabId = "",
                        viewId = "",
                        webSrvClassId = strWebSrvClassId,
                        gcUserId = clsSysParaEN.strUserId,
                        prjDataBaseId = clsPubVar.CurrPrjDataBaseId,
                        prjId = clsPubVar.CurrSelPrjId,
                        typeParas = ""
                    };

                    objGCResult = AutoGeneCodeWApi.GeneCode4SelfCreateWs(objGCPara);

                    strClassFName = string.Format("{0}\\{1}",
                        objUserCodePathEN.NewCodePath,
                        objGCResult.re_FileNameWithModuleName);
                    var c = clsPubFun4WApi.SaveClassContentToFile_NoCover(strClassFName, objGCResult.codeText,
                        objUserCodePathEN.NewCodePath, null, myEncoding);
                    //clsUserCodePathEN objUserCodePathEN = clsUserCodePathExWApi.GetObjByCodeTypeIdCache("0002", clsPubVar.CurrSelPrjId);

                    //if (rbMsSql.Checked == true)
                    //{
                    //    strCodeText = clsWebSrvClassExWApi.GeneDataLayer(strWebSrvClassId, clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId,
                    //        clsSysParaEN.strUserId,
                    //         clsSysParaEN.strUserName,
                    //          objUserCodePathEN.NewCodePath, objUserCodePathEN.NewCodePathBackup,
                    //       strCharEncodingId, mltLangType, mdbtDataBaseType, ref strClsName, ref strCodePath);
                    //}
                    //else if (rbOracle.Checked == true)
                    //{
                    //    strCodeText = clsWebSrvClassExWApi.GeneDataLayer_Ora(strWebSrvClassId, clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId,
                    //        clsSysParaEN.strUserId,
                    //         clsSysParaEN.strUserName,
                    //          objUserCodePathEN.NewCodePath, objUserCodePathEN.NewCodePathBackup,
                    //       strCharEncodingId, ref strClsName, ref strCodePath);
                    //}
                    //else if (rbMySql.Checked == true)
                    //{
                    //    strCodeText = clsWebSrvClassExWApi.GeneDataLayer(strWebSrvClassId, clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId,
                    //        clsSysParaEN.strUserId,
                    //         clsSysParaEN.strUserName,
                    //          objUserCodePathEN.NewCodePath, objUserCodePathEN.NewCodePathBackup,
                    //        strCharEncodingId, mltLangType, mdbtDataBaseType, ref strClsName, ref strCodePath);
                    //}
                    intCount++;
                }
                catch (Exception objException)
                {
                    lblMsg.Text = objException.Message;

                    MessageBox.Show(objException.Message);
                    return;
                }
            }
            if (intCount > 0)
            {
                if (objGCResult == null) return;
                txtCode.Text = objGCResult.codeText;
                txtFileName4GenCode.Text = objGCResult.re_ClsName;
                txtCodePath.Text = strClassFName;
                tabControl1.SelectedIndex = 1;//.TabPages[1].Focus();
                MessageBox.Show("生成表完成13！共计：" + intCount.ToString() + "个表。");
                BindLv_vWebSrvClass(false);
            }
        }
     
        private void progressBar2_Click(object sender, EventArgs e)
        {

        }
        private List<string> GetSelectedWebSrvClassId()
        {
            List<string> arrWebSrvClassIdLst = new List<string>();
            foreach (ListViewItem lvi in this.lvvWebSrvClass.SelectedItems)
            {
                string strWebSrvClassId = GetCurrKey(lvi);
                arrWebSrvClassIdLst.Add(strWebSrvClassId);
            }
            if (arrWebSrvClassIdLst.Count == 1)
            {
                mstrCurrWebSrvClassId = arrWebSrvClassIdLst[0];
            }
            if (arrWebSrvClassIdLst.Count == 0)
            {
                if (string.IsNullOrEmpty(mstrCurrWebSrvClassId) == false)
                {
                    arrWebSrvClassIdLst.Add(mstrCurrWebSrvClassId);
                }
                else
                {
                    lblMsg.Text = "没有选择记录，请选择一个有效的表记录!";
                    MessageBox.Show(lblMsg.Text);
                    return null;
                }
            }
            return arrWebSrvClassIdLst;
        }
        private void btnAppViewUnitTest_Click(object sender, EventArgs e)
        {
            List<string> arrWebSrvClassIdLst = GetSelectedWebSrvClassId();
            if (arrWebSrvClassIdLst == null)
            {
                return;
            }

            if (cboCharEncodingId.SelectedIndex <= 0)
            {
                lblMsg.Text = "请选择一个生成文件的字符编码!";
                MessageBox.Show(lblMsg.Text);
                return;
            }
            string strCharEncodingId = cboCharEncodingId.SelectedValue.ToString();

            //保存当前选择的字符编码
            //clsPubFun.SaveCharEncodingId4PrjUser(clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId, strCharEncodingId);
            string strCodeTypeId = "0000";
            int intCount = 0;
            lblMsg.Text = "";
            Encoding myEncoding = clsString.GetEncodingObjByCharEncodingId(strCharEncodingId);
            clsPubConst.ClassName cnClassName = clsPubConst.ClassName.AppViewUnitTest;
            clsGCResult objGCResult = null;
            string strClassFName = "";
            string strMachineName = Environment.MachineName;
            int intApplicationTypeId = 0;
            var strCmPrjId = "";//cboCmPrjId.SelectedValue.ToString();
            long lngCMProjectAppRelaId = 0;
            try
            {
                lngCMProjectAppRelaId = clsCMProjectAppRelaExWApi.getCMProjectAppRelaId(strCmPrjId, intApplicationTypeId, clsPubVar.CurrSelPrjId);

                //var objUserCodePrjMainPath = clsUserCodePrjMainPathExWApi.GetObjExByCMProjectAppRelaIdCache(lngCMProjectAppRelaId, clsPubVar.CurrSelPrjId, strMachineName, 
                //    clsSysParaEN.strUserId);
                //strUserCodePrjMainPathId = objUserCodePrjMainPath.UserCodePrjMainPathId;
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
                return;
            }
            foreach (string strWebSrvClassId in arrWebSrvClassIdLst)
            {
                try
                {
                    clsvUserCodePathEN objUserCodePathEN = clsvUserCodePathExWApi.GetObjByClassName(lngCMProjectAppRelaId, strCodeTypeId, clsPubVar.CurrSelPrjId, strCmPrjId, clsSysParaEN.strUserId, strMachineName);
                    clsPubFun.AccessIsExistPath(objUserCodePathEN);

                    //strCodeText = clsAutoGeneCodeWS.GeneCode4SelfCreateWs(cnClassName, typeParas,
                    //    mltLangType, mdbtDataBaseType, strWebSrvClassId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId,
                    //    clsSysParaEN.strUserId, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                    clsGCPara objGCPara = new clsGCPara()
                    {
                        applicationTypeId = 0,// this.applicationTypeId,
                        codeTypeId = strCodeTypeId,
                        dataBaseType = clsPubConst.GetDataBaseTypeStrByDataBaseType(mdbtDataBaseType),
                        tabId = "",
                        viewId = "",
                        webSrvClassId = strWebSrvClassId,
                        gcUserId = clsSysParaEN.strUserId,
                        prjDataBaseId = clsPubVar.CurrPrjDataBaseId,
                        prjId = clsPubVar.CurrSelPrjId,
                        typeParas = ""
                    };

                    objGCResult = AutoGeneCodeWApi.GeneCode4SelfCreateWs(objGCPara);

                    if (string.IsNullOrEmpty(objGCResult.re_FileNameWithModuleName) == true)
                    {
                        string strMsg = string.Format("在生成[{0}]类时， 带模块名的文件名为空，请检查！({1})", cnClassName, clsStackTrace.GetCurrClassFunction());
                        MessageBox.Show(strMsg);
                        return;
                    }
                    strClassFName = string.Format("{0}\\{1}",
                        objUserCodePathEN.NewCodePath,
                        objGCResult.re_FileNameWithModuleName);
                    clsPubFun4WApi.SaveClassContentToFile(strClassFName, objGCResult.codeText,
                        objUserCodePathEN.NewCodePath,
                        objUserCodePathEN.NewCodePathBackup, myEncoding);
                    intCount++;
                }
                catch (Exception objException)
                {
                    lblMsg.Text = objException.Message;
                    MessageBox.Show(objException.Message);
                }
            }
            if (intCount > 0)
            {
                if (objGCResult == null) return;
                txtCode.Text = objGCResult.codeText;
                txtFileName4GenCode.Text = objGCResult.re_ClsName;
                txtCodePath.Text = strClassFName;
                tabControl1.SelectedIndex = 1;//.TabPages[1].Focus();
                MessageBox.Show("生成表完成14！共计：" + intCount.ToString() + "个表。");
                BindLv_vWebSrvClass(false);
            }
        }

        private void btnAppViewUTScript_Click(object sender, EventArgs e)
        {
            List<string> arrWebSrvClassIdLst = GetSelectedWebSrvClassId();
            if (arrWebSrvClassIdLst == null)
            {
                return;
            }

            if (cboCharEncodingId.SelectedIndex <= 0)
            {
                lblMsg.Text = "请选择一个生成文件的字符编码!";
                MessageBox.Show(lblMsg.Text);
                return;
            }
            string strCharEncodingId = cboCharEncodingId.SelectedValue.ToString();

            //保存当前选择的字符编码
            //clsPubFun.SaveCharEncodingId4PrjUser(clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId, strCharEncodingId);

            int intCount = 0;
            lblMsg.Text = "";      
            Encoding myEncoding = clsString.GetEncodingObjByCharEncodingId(strCharEncodingId);
            clsPubConst.ClassName cnClassName = clsPubConst.ClassName.AppViewUTScript;
            string strCodeTypeId = clsCodeTypeExWApi.GetCodeTypeIdByClassNameCache(cnClassName, mltLangType);

            clsGCResult objGCResult = null;
            string strClassFName = "";
            string strMachineName = Environment.MachineName;
            int intApplicationTypeId = 0;
            var strCmPrjId = "";//cboCmPrjId.SelectedValue.ToString();
            long lngCMProjectAppRelaId = 0;
            try
            {
                lngCMProjectAppRelaId = clsCMProjectAppRelaExWApi.getCMProjectAppRelaId(strCmPrjId, intApplicationTypeId, clsPubVar.CurrSelPrjId);

                //var objUserCodePrjMainPath = clsUserCodePrjMainPathExWApi.GetObjExByCMProjectAppRelaIdCache(lngCMProjectAppRelaId, clsPubVar.CurrSelPrjId, strMachineName, 
                //    clsSysParaEN.strUserId);
                //strUserCodePrjMainPathId = objUserCodePrjMainPath.UserCodePrjMainPathId;
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
                return;
            }
            foreach (string strWebSrvClassId in arrWebSrvClassIdLst)
            {
                try
                {
                    clsvUserCodePathEN objUserCodePathEN = clsvUserCodePathExWApi.GetObjByClassName(lngCMProjectAppRelaId, strCodeTypeId, clsPubVar.CurrSelPrjId, strCmPrjId, clsSysParaEN.strUserId, strMachineName);
                    clsPubFun.AccessIsExistPath(objUserCodePathEN);

                    //strCodeText = clsAutoGeneCodeWS.GeneCode4SelfCreateWs(cnClassName, typeParas,
                    //    mltLangType, mdbtDataBaseType, strWebSrvClassId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId,
                    //    clsSysParaEN.strUserId, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                    clsGCPara objGCPara = new clsGCPara()
                    {
                        applicationTypeId = 0,// this.applicationTypeId,
                        codeTypeId = strCodeTypeId,
                        dataBaseType = clsPubConst.GetDataBaseTypeStrByDataBaseType(mdbtDataBaseType),
                        tabId = "",
                        viewId = "",
                        webSrvClassId = strWebSrvClassId,
                        gcUserId = clsSysParaEN.strUserId,
                        prjDataBaseId = clsPubVar.CurrPrjDataBaseId,
                        prjId = clsPubVar.CurrSelPrjId,
                        typeParas = ""
                    };

                    objGCResult = AutoGeneCodeWApi.GeneCode4SelfCreateWs(objGCPara);

                    if (string.IsNullOrEmpty(objGCResult.re_FileNameWithModuleName) == true)
                    {
                        string strMsg = string.Format("在生成[{0}]类时， 带模块名的文件名为空，请检查！({1})", cnClassName, clsStackTrace.GetCurrClassFunction());
                        MessageBox.Show(strMsg);
                        return;
                    }
                    strClassFName = string.Format("{0}\\{1}",
                        objUserCodePathEN.NewCodePath,
                        objGCResult.re_FileNameWithModuleName);
                    clsPubFun4WApi.SaveClassContentToFile(strClassFName, objGCResult.codeText,
                        objUserCodePathEN.NewCodePath,
                        objUserCodePathEN.NewCodePathBackup, myEncoding);
                    intCount++;
                }
                catch (Exception objException)
                {
                    lblMsg.Text = objException.Message;
                    MessageBox.Show(objException.Message);
                }
            }
            if (intCount > 0)
            {
                if (objGCResult == null) return;
                txtCode.Text = objGCResult.codeText;
                txtFileName4GenCode.Text = objGCResult.re_ClsName;
                txtCodePath.Text = strClassFName;
                tabControl1.SelectedIndex = 1;//.TabPages[1].Focus();
                MessageBox.Show("生成表完成15！共计：" + intCount.ToString() + "个表。");
                BindLv_vWebSrvClass(false);
            }
        }

        private void btnAppViewUTScriptCS_Click(object sender, EventArgs e)
        {
            List<string> arrWebSrvClassIdLst = GetSelectedWebSrvClassId();
            if (arrWebSrvClassIdLst == null)
            {
                return;
            }

            if (cboCharEncodingId.SelectedIndex <= 0)
            {
                lblMsg.Text = "请选择一个生成文件的字符编码!";
                MessageBox.Show(lblMsg.Text);
                return;
            }
            string strCharEncodingId = cboCharEncodingId.SelectedValue.ToString();

            //保存当前选择的字符编码
            //clsPubFun.SaveCharEncodingId4PrjUser(clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId, strCharEncodingId);

            int intCount = 0;
            lblMsg.Text = "";    
            Encoding myEncoding = clsString.GetEncodingObjByCharEncodingId(strCharEncodingId);
            clsPubConst.ClassName cnClassName = clsPubConst.ClassName.AppViewUTScriptCS;
            string strCodeTypeId = clsCodeTypeExWApi.GetCodeTypeIdByClassNameCache(cnClassName, mltLangType);

            clsGCResult objGCResult = null;
            string strClassFName = "";
            string strMachineName = Environment.MachineName;
            int intApplicationTypeId = 0;
            var strCmPrjId = "";//cboCmPrjId.SelectedValue.ToString();
            long lngCMProjectAppRelaId = 0;
            try
            {
                lngCMProjectAppRelaId = clsCMProjectAppRelaExWApi.getCMProjectAppRelaId(strCmPrjId, intApplicationTypeId, clsPubVar.CurrSelPrjId);

                //var objUserCodePrjMainPath = clsUserCodePrjMainPathExWApi.GetObjExByCMProjectAppRelaIdCache(lngCMProjectAppRelaId, clsPubVar.CurrSelPrjId, strMachineName, 
                //    clsSysParaEN.strUserId);
                //strUserCodePrjMainPathId = objUserCodePrjMainPath.UserCodePrjMainPathId;
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
                return;
            }
            foreach (string strWebSrvClassId in arrWebSrvClassIdLst)
            {
                try
                {
                    clsvUserCodePathEN objUserCodePathEN = clsvUserCodePathExWApi.GetObjByClassName(lngCMProjectAppRelaId, strCodeTypeId, clsPubVar.CurrSelPrjId, strCmPrjId, clsSysParaEN.strUserId, strMachineName);
                    clsPubFun.AccessIsExistPath(objUserCodePathEN);

                    //strCodeText = clsAutoGeneCodeWS.GeneCode4SelfCreateWs(cnClassName, typeParas,
                    //    mltLangType, mdbtDataBaseType, strWebSrvClassId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId,
                    //    clsSysParaEN.strUserId, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                    clsGCPara objGCPara = new clsGCPara()
                    {
                        applicationTypeId = 0,// this.applicationTypeId,
                        codeTypeId = strCodeTypeId,
                        dataBaseType = clsPubConst.GetDataBaseTypeStrByDataBaseType(mdbtDataBaseType),
                        tabId = "",
                        viewId = "",
                        webSrvClassId = strWebSrvClassId,
                        gcUserId = clsSysParaEN.strUserId,
                        prjDataBaseId = clsPubVar.CurrPrjDataBaseId,
                        prjId = clsPubVar.CurrSelPrjId,
                        typeParas = ""
                    };

                    objGCResult = AutoGeneCodeWApi.GeneCode4SelfCreateWs(objGCPara);
                    if (string.IsNullOrEmpty(objGCResult.re_FileNameWithModuleName) == true)
                    {
                        string strMsg = string.Format("在生成[{0}]类时， 带模块名的文件名为空，请检查！({1})", cnClassName, clsStackTrace.GetCurrClassFunction());
                        MessageBox.Show(strMsg);
                        return;
                    }
                    strClassFName = string.Format("{0}\\{1}",
                        objUserCodePathEN.NewCodePath,
                        objGCResult.re_FileNameWithModuleName);
                    clsPubFun4WApi.SaveClassContentToFile(strClassFName, objGCResult.codeText,
                        objUserCodePathEN.NewCodePath,
                        objUserCodePathEN.NewCodePathBackup, myEncoding);
                    intCount++;
                }
                catch (Exception objException)
                {
                    lblMsg.Text = objException.Message;
                    MessageBox.Show(objException.Message);
                }
            }
            if (intCount > 0)
            {
                if (objGCResult == null) return;
                txtCode.Text = objGCResult.codeText;
                txtFileName4GenCode.Text = objGCResult.re_ClsName;
                txtCodePath.Text = strClassFName;
                tabControl1.SelectedIndex = 1;//.TabPages[1].Focus();
                MessageBox.Show("生成表完成16！共计：" + intCount.ToString() + "个表。");
                BindLv_vWebSrvClass(false);
            }
        }

        private void rblProgLangTypeId_RadioItemSeleted(object sender, TzWinCtrlLib.TzRadioButtonList.SelectedEventArgs e)
        {
            string strCharEncodingId = clsPubFun.GetCharEncodingIdByLangTypeId(e.Value);
            cboCharEncodingId.SelectedValue = strCharEncodingId;
            
            GetLangTypeByRadioButton(e.Value);
            DispClassNameButton();
        }
        private void GetLangTypeByRadioButton(string strProgLangTypeId)
        {
            clsProgLangTypeEN objProgLangTypeEN = clsProgLangTypeWApi.GetObjByProgLangTypeId(strProgLangTypeId);
            mltLangType = clsPubConst.GetLangTypeByString(objProgLangTypeEN.ProgLangTypeName);
        }
        /// <summary>
        /// 当前所选择的类型参数：可有：界面类型、类型其他参数等
        /// </summary>
        protected string typeParas
        {
            get
            {
                string strTypeParas = "";

                if (cboAppPageTypeId.SelectedIndex > 0)
                {
                    string strAppPageTypeId = cboAppPageTypeId.SelectedValue.ToString();
                    clsAppPageTypeEN objAppPageTypeEN = clsAppPageTypeWApi.GetObjByAppPageTypeId(strAppPageTypeId);
                    strTypeParas = strTypeParas + string.Format("{0}|",
                        objAppPageTypeEN.AppPageTypeENName);
                    return strTypeParas;
                }
                return strTypeParas;
            }
        }
    }
}