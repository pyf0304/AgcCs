
/*-- -- -- -- -- -- -- -- -- -- --
类名:wfmQryRegionFldsB_QUDI
表名:QryRegionFlds
生成代码版本:2018.05.03.1
生成日期:2018/05/03 16:17:25
生成者:
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:区域管理
模块英文名:RegionManage
框架-层名:Web界面层
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.11.28.01
     2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/

using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;
using CommFunc4WebForm;
using CommonTable.Entity;
using CommonTable.BusinessLogic;
using AGC.Entity;
using AGC.BusinessLogic;using AGC.FunClass;

using AGC.BusinessLogicEx;
using AGC.Const;

namespace AGC.Webform
{
    /// <summary>
    /// wfmQryRegionFldsB_QUDI 的摘要说明。其中Q代表查询,U代表修改
    /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenQueryUpdDelInsRecControlCodeWithWuc4Gv)
    /// </summary>
    public partial class wfmQryRegionFldsB_QUDI : System.Web.UI.Page
    {

        #region 页面启动函数
        /// <summary>
        /// 函数功能:页面导入,当页面开始运行时所发生的事件
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPage_LoadCode)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面
            if (!IsPostBack)    ///如果本界面是初次被调用,而不是单击按钮事件所调用
            {

                vsViewName = "查询区域字段列表维护";
                vsTabName = string.Format("{0}", clsvQryRegionFldsEN._CurrTabName_S);
                //生成权限有关判断权限的代码
                //根据等级权限编号来确定用户可以使用什么功能,等级编号方式:1为最大2其次,依此类推
                switch (vsPotenceLevel)
                {
                    case "0":
                        Response.Redirect("../error.aspx");
                        break;
                    case "1":
                        Response.Redirect("../error.aspx");
                        break;
                    case "2":
                        Response.Redirect("../error.aspx");
                        break;
                    case "3":
                        Response.Redirect("../error.aspx");
                        break;
                    case "4":
                        Response.Redirect("../error.aspx");
                        break;
                    case "9":
                        break;
                    default:
                        Response.Redirect("../error.aspx");
                        break;
                }


                //1、为下拉框设置数据源,绑定列表数据
                wucQryRegionFldsB1.SetDdl_CtlTypeId();
                wucQryRegionFldsB1.SetDdl_DS_TabId(clsPubVar.CurrSelPrjId);
                wucQryRegionFldsB1.SetDdl_QueryOptionId();
                wucQryRegionFldsB1.SetDdl_DDLItemsOptionId();
                wucQryRegionFldsB1.SetDdl_DS_DataTextFieldId(clsPubVar.CurrSelPrjId);
                wucQryRegionFldsB1.SetDdl_DS_DataValueFieldId(clsPubVar.CurrSelPrjId);
                wucQryRegionFldsB1.SetDdl_UserId();
                clsFieldTabBLEx.BindDdl_FldIDEx(ddlFldID_q, clsPubVar.CurrSelPrjId);
                clsDataTypeAbbrBL.BindDdl_DataTypeId_Cache(ddlDataTypeId_q);
                clsViewInfoBLEx.BindDdl_ViewIdEx(ddlViewId_q, clsPubVar.CurrSelPrjId);
                clsCtlTypeAbbrBL.BindDdl_CtlTypeId_Cache(ddlCtlTypeId_q);
                clsPrjTabBLEx.BindDdl_TabIdByPrjIdEx(ddlDS_TabId_q, clsPubVar.CurrSelPrjId);
                clsQueryOptionBL.BindDdl_QueryOptionId_Cache(ddlQueryOptionId_q);
                wucvQryRegionFlds4Gv1.SetSortBy(string.Format("{0} Asc", clsvQryRegionFldsEN.con_QueryOptionName));
                //2、显示无条件的表内容在GridView中
                BindGv_vQryRegionFlds();
                //3、设置表控件中字控件的ReadOnly属性,
                // 使之只读,因为在修改功能中关键字是不能被修改的。
                DispQryRegionFldsListRegion();
                //设置逻辑层的公共函数，包含：缓存刷新函数
                //clsQryRegionFldsBL.objCommFun4BL = new clsCommFun4BL4QryRegionFlds();
            }
        }

        #endregion 页面启动函数


        #region 查询相关函数
        /// <summary>
        /// 函数功能:事件函数,当单击<查询>按钮时所发生的事件
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenbtnQuery_ClickCode)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnQuery_Click(object sender, System.EventArgs e)
        {
            //把GridView的当前页索引设置为0,即第1页。
            //当单击查询时,首先显示的是表记录内容的第一部分内容。
            wucvQryRegionFlds4Gv1.vsPageIndex = 1;
            //把表记录的内容显示在GridView中
            BindGv_vQryRegionFlds();
        }
        /// <summary>
        /// 函数功能:把查询数据绑定在GridView上。根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在GridView中。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenBindGridView4WucInPage)
        /// </summary>
        protected void BindGv_vQryRegionFlds()
        {
            //操作步骤:(共5步)
            //	1、组合界面条件串；
            //	2、调用控件中的绑定GridView函数;
            //	3、设置Gv控件的某些列不可见;

            try
            {
                //	1、组合界面条件串；
                string strWhereCond = CombinevQryRegionFldsCondition();
                //	2、调用控件中的绑定GridView函数；
                wucvQryRegionFlds4Gv1.BindGv_QryRegionFlds(strWhereCond);
                //	3、设置Gv控件的某些列不可见；
                wucvQryRegionFlds4Gv1.SetGvVisibility(convQryRegionFlds.DS_DataValueFieldName, false);
                wucvQryRegionFlds4Gv1.SetGvVisibility(convQryRegionFlds.DS_DataTextFieldName, false);
                wucvQryRegionFlds4Gv1.SetGvVisibility(convQryRegionFlds.DS_SQLStr, false);
                wucvQryRegionFlds4Gv1.SetGvVisibility(convQryRegionFlds.DS_CondStr, false);
                
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000019)绑定GridView出错!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }

        }

        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenCombineCondition)
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        protected string CombinevQryRegionFldsCondition()
        {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            string strWhereCond = string.Format(" {0} = '{1}' ", clsvQryRegionFldsEN.con_PrjId, clsPubVar.CurrSelPrjId);
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            clsvQryRegionFldsEN objvQryRegionFldsEN = new clsvQryRegionFldsEN();
            try
            {
                if (this.ddlFldID_q.SelectedValue != "" && this.ddlFldID_q.SelectedValue != "0")
                {
                    objvQryRegionFldsEN.FldId = this.ddlFldID_q.SelectedValue;
                    strWhereCond += string.Format(" And {0} = '{1}'", clsvQryRegionFldsEN.con_FldId, this.ddlFldID_q.SelectedValue);
                }
                if (this.txtFldName_q.Text.Trim() != "")
                {
                    objvQryRegionFldsEN.FldName = this.txtFldName_q.Text.Trim();
                    strWhereCond += string.Format(" And {0} like '%{1}%'", clsvQryRegionFldsEN.con_FldName, this.txtFldName_q.Text.Trim());
                }
                if (this.txtCaption_q.Text.Trim() != "")
                {
                    objvQryRegionFldsEN.LabelCaption = this.txtCaption_q.Text.Trim();
                    strWhereCond += string.Format(" And {0} like '%{1}%'", clsvQryRegionFldsEN.con_LabelCaption, this.txtCaption_q.Text.Trim());
                }
                if (this.ddlDataTypeId_q.SelectedValue != "" && this.ddlDataTypeId_q.SelectedValue != "0")
                {
                    objvQryRegionFldsEN.DataTypeId = this.ddlDataTypeId_q.SelectedValue;
                    strWhereCond += string.Format(" And {0} = '{1}'", clsvQryRegionFldsEN.con_DataTypeId, this.ddlDataTypeId_q.SelectedValue);
                }
                if (this.ddlViewId_q.SelectedValue != "" && this.ddlViewId_q.SelectedValue != "0")
                {
                    objvQryRegionFldsEN.ViewId = this.ddlViewId_q.SelectedValue;
                    strWhereCond += string.Format(" And {0} = '{1}'", clsvQryRegionFldsEN.con_ViewId, this.ddlViewId_q.SelectedValue);
                }
                if (this.ddlCtlTypeId_q.SelectedValue != "" && this.ddlCtlTypeId_q.SelectedValue != "0")
                {
                    objvQryRegionFldsEN.CtlTypeId = this.ddlCtlTypeId_q.SelectedValue;
                    strWhereCond += string.Format(" And {0} = '{1}'", clsvQryRegionFldsEN.con_CtlTypeId, this.ddlCtlTypeId_q.SelectedValue);
                }
                if (this.ddlDS_TabId_q.SelectedValue != "" && this.ddlDS_TabId_q.SelectedValue != "0")
                {
                    objvQryRegionFldsEN.DS_TabId = this.ddlDS_TabId_q.SelectedValue;
                    strWhereCond += string.Format(" And {0} = '{1}'", clsvQryRegionFldsEN.con_DS_TabId, this.ddlDS_TabId_q.SelectedValue);
                }
                if (this.ddlQueryOptionId_q.SelectedValue != "" && this.ddlQueryOptionId_q.SelectedValue != "0")
                {
                    objvQryRegionFldsEN.QueryOptionId = this.ddlQueryOptionId_q.SelectedValue;
                    strWhereCond += string.Format(" And {0} = '{1}'", clsvQryRegionFldsEN.con_QueryOptionId, this.ddlQueryOptionId_q.SelectedValue);
                }
                clsvQryRegionFldsBL.CheckProperty4Condition(objvQryRegionFldsEN);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:WebI000002)在组合查询条件(CombineQryRegionFldsCondition)时出错!请联系管理员!" + objException.Message);
                throw new Exception(strMsg);
            }
            return strWhereCond;
        }

        /// <summary>
        /// 专门用于记录GridView中的每页记录数
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPageSizeViewState)
        /// </summary>
        protected string PageSize
        {
            get
            {
                string strPageSize;
                strPageSize = (string)ViewState["PageSize"];
                if (strPageSize == null)
                {
                    strPageSize = "";
                }
                return strPageSize;
            }
            set
            {
                string strPageSize = value;
                ViewState.Add("PageSize", strPageSize);
            }
        }

        #endregion 查询相关函数



        #region 添加相关函数

        ///添加新记录的事件过程,建议在该过程中调用其他函数,不要在其中添加多行代码。
        protected void btnAddNewRec4Gv_Click(object sender, System.EventArgs e)
        {
            AddQryRegionFldsRecord();
        }
        /// <summary>
        /// 为插入记录做准备工作
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenAddRecordCode)
        /// </summary>
        protected void AddQryRegionFldsRecord()
        {
            btnOKUpd.Text = "确认添加";
            btnCancelQryRegionFldsEdit.Text = "取消添加";
            //wucQryRegionFldsB1.mId = clsQryRegionFldsBL.GetMaxStrId_S();
            DispEditQryRegionFldsRegion();
        }
        /// <summary>
        /// 插入记录存盘到数据表中
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenAddRecordSaveCode)
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        protected bool AddQryRegionFldsRecordSave()
        {
            //操作步骤:
            //1、检查控件中输入数据类型是否正确
            //2、定义对象并初始化对象
            //3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            //3.2、检查唯一性
            //4、把值从界面层传到逻辑层或数据实体层
            //5、检查传进去的对象属性是否合法
            //6、把数据实体层的数据存贮到数据库中
            //7、把新添的记录内容显示在GridView中
            string strMsg;  //专门用于传递信息的变量
            string strResult = " "; //用于传递在检验对象属性时结果值的变量
            clsQryRegionFldsEN objQryRegionFldsEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucQryRegionFldsB1.IsValid(ref strResult))
            {
                lblMsg_Edit.Text = "(errid:WebI000003)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsQryRegionFldsEN objQryRegionFldsEN;	//定义对象
            objQryRegionFldsEN = new clsQryRegionFldsEN();  //初始化新对象
                                                            //3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
                                                            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToQryRegionFldsClass(objQryRegionFldsEN);        //把界面的值传到
                                                                    //5.1、检查传进去的对象属性是否合法
            try
            {
                clsQryRegionFldsBL.CheckPropertyNew(objQryRegionFldsEN);
                //6、把数据实体层的数据存贮到数据库中
                clsQryRegionFldsBL.AddNewRecordBySql2(objQryRegionFldsEN);
            }
            catch (Exception objException)
            {
                strMsg = "(errid:WebI000005)添加记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg_Edit.Text = strMsg;
                return false;
            }
            strMsg = "添加记录成功!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsg_Edit.Text = "添加记录成功!";
            //7、把新添的记录内容显示在GridView中
            BindGv_vQryRegionFlds();
            DispQryRegionFldsListRegion();
            wucQryRegionFldsB1.Clear();     //清空控件中内容
                                            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelQryRegionFldsEdit.Text = "取消编辑";
            return true;
        }
        #endregion 添加相关函数


        #region 修改相关函数

        /// <summary>
        ///修改当前被选记录
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenbtnUpdate4Gv_Click4OneKeyword)
        /// </summary>
        protected void btnUpdate4Gv_Click(object sender, System.EventArgs e)
        {
            //1、显示该关键字的数据让用户修改该关键字记录；
            long lngmId = wucvQryRegionFlds4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;
            UpdateQryRegionFldsRecord(lngmId);
        }

        /// <summary>
        /// 函数功能:把以该关键字的记录内容显示在界面上,
        ///　　　   在这里是把值传到表控件中
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenShowDataCode)
        /// </summary>
        /// <param name = "lngmId">表记录的关键字,显示该表关键字的内容</param>
        protected void ShowData(long lngmId)
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
            if (clsQryRegionFldsBL.IsExist(lngmId) == false)        //检查该关键字的记录是否存在
            {
                string strMsg = "(errid:WebI000010)在表[QryRegionFlds]中,关键字为:[lngmId]的记录不存在!";
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            //3、用提供的关键字初始化一个类对象；
            clsQryRegionFldsEN objQryRegionFldsEN = new clsQryRegionFldsEN(lngmId);
            //4、获取类对象的所有属性；
            try
            {
                clsQryRegionFldsBL.GetQryRegionFlds(ref objQryRegionFldsEN);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000020)在显示数据时获取记录对象不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg_Edit.Text = strMsg;
                return;
            }
            Session.Add("objQryRegionFldsEN", objQryRegionFldsEN);
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
            GetDataFromQryRegionFldsClass(objQryRegionFldsEN);
        }
        /// <summary>
        /// 函数功能:把类对象的属性内容显示到界面上
        ///注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
        /// 如果在设置数据库时,就应该一级字段在前,二级字段在后
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenGetDataFromClass)
        /// </summary>
        /// <param name = "pobjQryRegionFldsEN">表实体类对象</param>
        protected void GetDataFromQryRegionFldsClass(clsQryRegionFldsEN pobjQryRegionFldsEN)
        {
            wucQryRegionFldsB1.RegionId = pobjQryRegionFldsEN.RegionId;// 区域Id
            wucQryRegionFldsB1.TabFldId = pobjQryRegionFldsEN.TabFldId;// 表字段ID
            wucQryRegionFldsB1.CtlTypeId = pobjQryRegionFldsEN.CtlTypeId;// 控件类型号
            wucQryRegionFldsB1.DS_TabId = pobjQryRegionFldsEN.DS_TabId;// 数据源表ID
            wucQryRegionFldsB1.QueryOptionId = pobjQryRegionFldsEN.QueryOptionId;// 查询方式Id
            wucQryRegionFldsB1.DDLItemsOptionId = pobjQryRegionFldsEN.DDLItemsOptionId;// 下拉框列表选项ID
            wucQryRegionFldsB1.DS_SQLStr = pobjQryRegionFldsEN.DS_SQLStr;// 数据源SQL串
            wucQryRegionFldsB1.DS_DataTextFieldId = pobjQryRegionFldsEN.DS_DataTextFieldId;// 数据源文本字段Id
            wucQryRegionFldsB1.DS_DataValueFieldId = pobjQryRegionFldsEN.DS_DataValueFieldId;// 数据源值字段Id
            wucQryRegionFldsB1.ItemsString = pobjQryRegionFldsEN.ItemsString;// 列表项串
            wucQryRegionFldsB1.DS_CondStr = pobjQryRegionFldsEN.DS_CondStr;// 数据源条件串
            wucQryRegionFldsB1.SeqNum = pobjQryRegionFldsEN.SeqNum;// 字段序号
            wucQryRegionFldsB1.UserId = pobjQryRegionFldsEN.UpdUser;// 用户ID
            wucQryRegionFldsB1.Memo = pobjQryRegionFldsEN.Memo;// 说明
            wucQryRegionFldsB1.UpdDate = pobjQryRegionFldsEN.UpdDate;// 修改日期
        }
        ///
        /// <summary>
        /// 事件函数:在Gv列表控件中，当GeidView行单击修改时发生的事件。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_Wuc4Gv_GvUpdateClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvQryRegionFlds4Gv1_GvUpdateClick(object sender, clsEventArgs4Update e)
        {
            long lngmId = long.Parse(e.KeyId);
            UpdateQryRegionFldsRecord(lngmId);
        }
        /// <summary>
        /// 为修改记录做准备过程,把给定关键字的记录字段值显示在用户控件上
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenUpdateRecordCode)
        /// </summary>
        protected void UpdateQryRegionFldsRecord(long lngmId)
        {
            //操作步骤:(总共2步)
            //1、显示该关键字记录的内容在界面上；
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；

            //1、显示该关键字记录的内容在界面上；
            ShowData(lngmId);
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            btnOKUpd.Enabled = true;
            btnOKUpd.Text = "确认修改";
            btnCancelQryRegionFldsEdit.Text = "取消修改";
            lblMsg_Edit.Text = "";
            DispEditQryRegionFldsRegion();
        }
        /// <summary>
        /// 修改记录存盘到数据表中
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenUpdateRecordSaveCode)
        /// </summary>
        /// <param name = "objQryRegionFldsEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        protected bool UpdateQryRegionFldsRecordSave(clsQryRegionFldsEN objQryRegionFldsEN)
        {
            //操作步骤:
            //1、检查控件中输入数据类型是否正确
            //2、把值从界面层传到逻辑层或数据实体层
            //3.1、检查传进去的对象属性是否合法
            //3.2、检查唯一性
            //4、把数据实体层的数据存贮到数据库中
            //5、把修改后的内容显示在GridView中
            string strMsg;  //专门用于传递信息的变量
            string strResult = " "; //用于传递在检验对象属性时结果值的变量
                                    //1、检查控件中输入数据类型是否正确
            if (!wucQryRegionFldsB1.IsValid(ref strResult))
            {
                lblMsg_Edit.Text = "(errid:WebI000011)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToQryRegionFldsClass(objQryRegionFldsEN);        //把界面的值传到
                                                                    //3.1、检查传进去的对象属性是否合法
            try
            {
                clsQryRegionFldsBL.CheckPropertyNew(objQryRegionFldsEN);
                //4、把数据实体层的数据存贮到数据库中
                clsQryRegionFldsBL.UpdateBySql2(objQryRegionFldsEN);
            }
            catch (Exception objException)
            {
                strMsg = "修改记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg_Edit.Text = strMsg;
                return false;
            }
            strMsg = "修改记录成功!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsg_Edit.Text = "修改记录成功!";
            //5、把修改后的内容显示在GridView中
            BindGv_vQryRegionFlds();
            DispQryRegionFldsListRegion();
            wucQryRegionFldsB1.Clear();//添空控件中的内容
                                       //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelQryRegionFldsEdit.Text = "取消编辑";
            //跳转到列表中刚刚的记录处,使用锚点功能。
            this.ClientScript.RegisterStartupScript(this.GetType(), "Go-Anchor", string.Format("this.location.href = '#A_QryRegionFlds{0}'", objQryRegionFldsEN.mId.ToString().Trim()), true);
            return true;
        }
        #endregion 修改相关函数


        #region 添加修改共用函数
        /// <summary>
        /// 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
        /// 具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenbtnOKUpd_ClickCode)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnOKUpd_Click(object sender, System.EventArgs e)
        {
            string strCommandText;
            clsQryRegionFldsEN objQryRegionFldsEN;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "添加":
                    AddQryRegionFldsRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    AddQryRegionFldsRecordSave();
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    objQryRegionFldsEN = (clsQryRegionFldsEN)Session["objQryRegionFldsEN"];
                    UpdateQryRegionFldsRecordSave(objQryRegionFldsEN);
                    break;
            }
        }
        /// <summary>
        /// 事件函数:取消编辑状态，退回到列表状态
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_btnCancelEdit_Click)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnCancelQryRegionFldsEdit_Click(object sender, EventArgs e)
        {
            DispQryRegionFldsListRegion();
        }
        /// <summary>
        /// 函数功能:把界面上的属性数据传到类对象中
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPutDataToClass)
        /// </summary>
        /// <param name = "pobjQryRegionFldsEN">数据传输的目的类对象</param>
        protected void PutDataToQryRegionFldsClass(clsQryRegionFldsEN pobjQryRegionFldsEN)
        {
            pobjQryRegionFldsEN.RegionId = wucQryRegionFldsB1.RegionId;// 区域Id
            pobjQryRegionFldsEN.TabFldId = wucQryRegionFldsB1.TabFldId;// 表字段ID
            pobjQryRegionFldsEN.CtlTypeId = wucQryRegionFldsB1.CtlTypeId;// 控件类型号
            pobjQryRegionFldsEN.DS_TabId = wucQryRegionFldsB1.DS_TabId;// 数据源表ID
            pobjQryRegionFldsEN.QueryOptionId = wucQryRegionFldsB1.QueryOptionId;// 查询方式Id
            pobjQryRegionFldsEN.DDLItemsOptionId = wucQryRegionFldsB1.DDLItemsOptionId;// 下拉框列表选项ID
            pobjQryRegionFldsEN.DS_SQLStr = wucQryRegionFldsB1.DS_SQLStr;// 数据源SQL串
            pobjQryRegionFldsEN.DS_DataTextFieldId = wucQryRegionFldsB1.DS_DataTextFieldId;// 数据源文本字段Id
            pobjQryRegionFldsEN.DS_DataValueFieldId = wucQryRegionFldsB1.DS_DataValueFieldId;// 数据源值字段Id
            pobjQryRegionFldsEN.ItemsString = wucQryRegionFldsB1.ItemsString;// 列表项串
            pobjQryRegionFldsEN.DS_CondStr = wucQryRegionFldsB1.DS_CondStr;// 数据源条件串
            pobjQryRegionFldsEN.SeqNum = wucQryRegionFldsB1.SeqNum;// 字段序号
            pobjQryRegionFldsEN.UpdUser = wucQryRegionFldsB1.UserId;// 用户ID
            pobjQryRegionFldsEN.Memo = wucQryRegionFldsB1.Memo;// 说明
            pobjQryRegionFldsEN.UpdDate = wucQryRegionFldsB1.UpdDate;// 修改日期
        }

        #endregion 添加修改共用函数


        #region 删除相关函数

        /// <summary>
        ///删除当前被选记录
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenbtnDelete4Gv_Click4OneKeyword)
        /// </summary>
        protected void btnDelete4Gv_Click(object sender, System.EventArgs e)
        {
            List<long> lstMId = wucvQryRegionFlds4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;
            lblMsg_List.Text = "";
            try
            {
                foreach (long lngmId in lstMId)
                {
                    clsQryRegionFldsBL.DelRecord(lngmId);
                }
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000021)删除记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg_Edit.Text = strMsg;
                return;
            }
            BindGv_vQryRegionFlds();
        }
        ///
        /// <summary>
        /// 事件函数:在Gv列表控件中，当GeidView行单击删除时发生的事件。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_Wuc4Gv_GvDeleteClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvQryRegionFlds4Gv1_GvDeleteClick(object sender, clsEventArgs4Delete e)
        {
            long lngmId = long.Parse(e.KeyId);
            DeleteQryRegionFldsRecord(lngmId);
        }
        /// <summary>
        /// 根据给定关键字删除记录
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDelRecordCode)
        /// </summary>
        /// <param name = "lngmId">给定关键字</param>
        protected void DeleteQryRegionFldsRecord(long lngmId)
        {
            try
            {
                clsQryRegionFldsBL.DelRecord(lngmId);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000022)删除记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg_Edit.Text = strMsg;
                return;
            }
            BindGv_vQryRegionFlds();
        }
        #endregion 删除相关函数


        #region 导出函数

        /// <summary>
        /// 事件函数:把查询条件的表记录，导出到Excel.
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnExportExcel4Gv_Click(object sender, System.EventArgs e)
        {
            //导出Excel函数
            ExportExcel();
        }


        /// <summary>
        /// 导出Excel。根据查询区组合的查询条件,从[vQryRegionFlds]表中获取记录集,最终导出到Excel
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenExportExcel)
        /// </summary>
        private void ExportExcel()
        {
            //	1、组合界面条件串；
            string strWhereCond = CombinevQryRegionFldsCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "QryRegionFlds信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add(clsvQryRegionFldsEN.con_QueryOptionName); arrCnName.Add("查询方式名称");
            arrColName.Add(clsvQryRegionFldsEN.con_FldId); arrCnName.Add("字段ID");
            arrColName.Add(clsvQryRegionFldsEN.con_FldName); arrCnName.Add("字段名");
            arrColName.Add(clsvQryRegionFldsEN.con_DataTypeName); arrCnName.Add("数据类型名称");
            arrColName.Add(clsvQryRegionFldsEN.con_LabelCaption); arrCnName.Add("标题");
            arrColName.Add(clsvQryRegionFldsEN.con_DataTypeId); arrCnName.Add("数据类型Id");
            arrColName.Add(clsvQryRegionFldsEN.con_PrjId); arrCnName.Add("工程ID");
            arrColName.Add(clsvQryRegionFldsEN.con_FieldTypeName); arrCnName.Add("字段类型");
            arrColName.Add(clsvQryRegionFldsEN.con_RegionId); arrCnName.Add("区域Id");
            arrColName.Add(clsvQryRegionFldsEN.con_RegionName); arrCnName.Add("区域名称");
            arrColName.Add(clsvQryRegionFldsEN.con_ViewId); arrCnName.Add("界面ID");
            arrColName.Add(clsvQryRegionFldsEN.con_ViewName); arrCnName.Add("界面名称");
            arrColName.Add(clsvQryRegionFldsEN.con_TabFldId); arrCnName.Add("表字段ID");
            arrColName.Add(clsvQryRegionFldsEN.con_CtlTypeId); arrCnName.Add("控件类型号");
            arrColName.Add(clsvQryRegionFldsEN.con_CtlTypeName); arrCnName.Add("控件类型名");
            arrColName.Add(clsvQryRegionFldsEN.con_CtlCnName); arrCnName.Add("控件类型中文名");
            arrColName.Add(clsvQryRegionFldsEN.con_CtlTypeAbbr); arrCnName.Add("控件类型缩写");
            arrColName.Add(clsvQryRegionFldsEN.con_DS_TabId); arrCnName.Add("数据源表ID");
            arrColName.Add(clsvQryRegionFldsEN.con_TabName); arrCnName.Add("表名");
            arrColName.Add(clsvQryRegionFldsEN.con_QueryOptionId); arrCnName.Add("查询方式Id");
            arrColName.Add(clsvQryRegionFldsEN.con_DDLItemsOptionId); arrCnName.Add("下拉框列表选项ID");
            arrColName.Add(clsvQryRegionFldsEN.con_DDLItemsOptionName); arrCnName.Add("下拉框列表选项名");
            arrColName.Add(clsvQryRegionFldsEN.con_DS_SQLStr); arrCnName.Add("数据源SQL串");
            arrColName.Add(clsvQryRegionFldsEN.con_DS_DataTextFieldId); arrCnName.Add("数据源文本字段Id");
            arrColName.Add(clsvQryRegionFldsEN.con_DS_DataValueFieldId); arrCnName.Add("数据源值字段Id");
            arrColName.Add(clsvQryRegionFldsEN.con_ItemsString); arrCnName.Add("列表项串");
            arrColName.Add(clsvQryRegionFldsEN.con_DS_CondStr); arrCnName.Add("数据源条件串");
            arrColName.Add(clsvQryRegionFldsEN.con_SeqNum); arrCnName.Add("字段序号");
            arrColName.Add(clsvQryRegionFldsEN.con_UpdUser); arrCnName.Add("修改用户");
            arrColName.Add(clsvQryRegionFldsEN.con_Memo); arrCnName.Add("说明");
            arrColName.Add(clsvQryRegionFldsEN.con_UpdDate); arrCnName.Add("修改日期");
            arrColName.Add(clsvQryRegionFldsEN.con_DS_TabName); arrCnName.Add("数据源表名");
            arrColName.Add(clsvQryRegionFldsEN.con_DS_DataValueFieldName); arrCnName.Add("DS_DataValueFieldName");
            arrColName.Add(clsvQryRegionFldsEN.con_DS_DataTextFieldName); arrCnName.Add("DS_DataTextFieldName");
            arrColName.Add(clsvQryRegionFldsEN.con_RelaTabId); arrCnName.Add("RelaTabId");
            strFolderName = clsSysParaEN.TempFileFolder;
            strDownLoadFileName = strFolderName + strFileName;
            //初始化需要导出的Excel文件,即复制标准Excel文件作为母版,复制不成功即不能导出
            if (clsPubVar.InitExcelFile(this, strFolderName, strDownLoadFileName) == false)
            {
                return;
            }
            try
            {
                //	2、根据条件串获取该表满足条件的DataTable；
                objDT = clsvQryRegionFldsBL.GetDataTable(strWhereCond);
                //用户Odbc的方式来导出Excel,在Web服务器不需要安装Excel,目前是Excel2003,如果希望2007,可以换下面一条语句。
                GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4Odbc(objDT, arrColName, arrCnName, strDownLoadFileName);
                //GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4OdbcExcel2007(objDT, arrColName, arrCnName, strDownLoadFileName);
                //GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr(objDT, arrColName, arrCnName, strDownLoadFileName);
            }
            catch (Exception objException)
            {
                seErrMessage = objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            clsCommForWebForm.DownLoadFile(strDownLoadFileName);
        }
        #endregion 导出函数


        #region 布局控制函数
        /// <summary>
        /// 布局控制函数,显示用于编辑的用户控件,并隐藏数据列表区
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDispListAndEditRegion)
        /// </summary>
        private void DispEditQryRegionFldsRegion()
        {
            divList.Visible = false;
            tabEditQryRegionFldsRegion.Visible = true;
        }
        /// <summary>
        /// 布局控制函数,显示数据列表区,并隐藏用于编辑的用户控件
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDispListAndEditRegion)
        /// </summary>
        private void DispQryRegionFldsListRegion()
        {
            divList.Visible = true;
            tabEditQryRegionFldsRegion.Visible = false;
        }
        #endregion 布局控制函数


        #region 错误处理函数

        /// <summary>
        /// Session属性:错误信息的Session属性,该Session传递给显示出错页面,显示相应的错误内容。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenErrMessageSession)
        /// </summary>
        protected string seErrMessage
        {
            get
            {
                string strErrMessage;
                strErrMessage = (string)Session["ErrMessage"];
                if (strErrMessage == null)
                {
                    strErrMessage = "";
                }
                return strErrMessage;
            }
            set
            {
                string strErrMessage = value;
                Session.Add("ErrMessage", strErrMessage);
            }
        }


        /// <summary>
        /// Session属性:返回链接串的Session属性,该Session用于告诉出错页面,哪一个页面是需要返回的页面。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenBackLinkStrSession)
        /// </summary>
        protected string seBackErrPageLinkStr
        {
            get
            {
                string strBackErrPageLinkStr;
                strBackErrPageLinkStr = (string)Session["BackErrPageLinkStr"];
                if (strBackErrPageLinkStr == null)
                {
                    strBackErrPageLinkStr = "";
                }
                return strBackErrPageLinkStr;
            }
            set
            {
                string strBackErrPageLinkStr = value;
                Session.Add("BackErrPageLinkStr", strBackErrPageLinkStr);
            }
        }

        #endregion 错误处理函数


        #region 权限处理函数

        /// <summary>
        /// ViewState属性:当前操作的界面功能名称
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPotenceRelaVar)
        /// </summary>
        protected string vsViewName
        {
            get
            {
                string sViewName;
                sViewName = (string)ViewState["ViewName"];
                if (sViewName == null)
                {
                    sViewName = "";
                }
                return sViewName;
            }
            set
            {
                string sViewName = value;
                ViewState.Add("ViewName", sViewName);
            }
        }
        /// <summary>
        /// ViewState属性:当前操作的导出表名称
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPotenceRelaVar)
        /// </summary>
        protected string vsTabName
        {
            get
            {
                string sTabName;
                sTabName = (string)ViewState["TabName"];
                if (sTabName == null)
                {
                    sTabName = "";
                }
                return sTabName;
            }
            set
            {
                string sTabName = value;
                ViewState.Add("TabName", sTabName);
            }
        }
        /// <summary>
        /// QueryString属性:通过QueryString传递过来的UserId参数。这里是样例,大家可以参考这个样例。
        /// 姓名:
        /// 日期:
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPotenceRelaVar)
        /// </summary>
        private string qsUserId
        {
            get
            {
                string strUserId = Request.QueryString["UserId"] ?? "".ToString();
                if ((strUserId != null) && (strUserId != ""))
                {
                    return strUserId;
                }
                else
                {
                    return "";
                }
            }
        }
        /// <summary>
        /// 与权限相关的界面编号
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPotenceRelaVar)
        /// </summary>
        protected const string ViewId4Potence = "00260203";     //界面编号


        /// <summary>
        /// ViewState属性:用于记录当前用户在当前界面的权限等级
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPotenceLevelProperty)
        /// </summary>
        protected string vsPotenceLevel
        {
            get
            {
                string sPotenceLevel;
                sPotenceLevel = (string)ViewState["PotenceLevel"];
                if (sPotenceLevel == null)
                {
                    //					sPotenceLevel = new General_Platform_Dll.MenuAndPotence().Get_PotenceLevel(ViewId4Potence);
                    sPotenceLevel = "9";
                    ViewState.Add("PotenceLevel", sPotenceLevel);
                }
                return sPotenceLevel;
            }
        }


        /// <summary>
        /// Session属性:登录的用户ID,用于检查用户权限
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenLoginUserSession)
        /// </summary>
        protected string seUserId
        {
            get
            {
                string strUserId;
                strUserId = (string)Session["UserId"];
                if (strUserId == null)
                {
                    strUserId = "";
                }
                return strUserId;
            }
            set
            {
                string strUserId = value;
                Session.Add("UserId", strUserId);
            }
        }
        ///protected clsUsersEN objUser
        ///{
        ///get
        ///{
        ///clsUsersEN pobjUser;
        ///pobjUser = (clsUsersEN)Session["objUser"];
        ///if (pobjUser == null) 
        ///{
        ///pobjUser = null;
        ///}
        ///return pobjUser;
        ///}
        ///set
        ///{
        ///clsUsersEN pobjUser = value;
        ///Session.Add("objUser", pobjUser);
        ///}
        ///}



        #endregion 权限处理函数

    }
}