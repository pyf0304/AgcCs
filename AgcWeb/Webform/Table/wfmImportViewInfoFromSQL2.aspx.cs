//clsDBServer objDBServer = (clsDBServer)Session["objDBServer"];
//clsDBServer objDBServer = new clsDBServer();
//			Session.Add("objDBServer", objDBServer);
using System;
using System.IO;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
//using AutoGenFile;
using CommFunc4WebForm;
//using SqlSv;
using com.taishsoft.commdb;


using AGC.BusinessLogic;using AGC.FunClass;

using AGC.BusinessLogicEx;
using AGC.Entity;

using System.Collections.Generic;


using com.taishsoft.common;

namespace AGC
{
	/// <summary>
	/// WebForm1 的摘要说明。
	/// </summary>
	public partial class wfmImportViewInfoFromSQL2 : CommWebPageBase
	{
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// 在此处放置用户代码以初始化页面
			clsUsersEN objUser;
			string strIP;
			if (!IsPostBack)
			{
				objUser = (clsUsersEN)Session["objUser"];
				if (objUser == null) ReturnLoginView();
				if (objUser.qxdj <= 0) ReturnLoginView();
				txtUserId.Text = objUser.UserId;
				//CommProgramSet.clsComm objComm = new CommProgramSet.clsComm();
				strIP = Request.UserHostAddress.ToString();
				txtServer.Text = strIP;
//				clsDropDownList.BindDdl_ObjId(ddlObjId, PrjId);
				//以下代码是为DEBUG使用
				InitViewForDebug();
			}
		}
		private void InitViewForDebug()
		{
			if (CommFunc4WebForm.clsCommForWebForm.SystemStatus == "DEBUG")
			{
				txtServer.Text = ".";
				txtUserIdForMaster.Text = "pyf";
				txtPassWordForMaster.Text = "mm1234";
			}
		}
        //private string PrjId
        //{
        //    get
        //    {
        //        string strPrjId;
        //        strPrjId = (string)Session["P1rjId"];
        //        if (strPrjId==null) 
        //        {
        //            strPrjId = "";
        //            clsCommForWebForm.CheckPrjId(strPrjId, this);
        //        }
        //        return strPrjId;
        //    }
        //    set
        //    {
        //        string strPrjId = value;
        //        Session.Add("PrjId", strPrjId);
        //    }
        //}
		private clsUsersEN objUserBak
		{
			get
			{
				clsUsersEN pobjUser;
				pobjUser = (clsUsersEN)Session["objUser"];
				if (pobjUser==null) 
				{
					pobjUser = null;
				}
				return pobjUser;
			}
			set
			{
				clsUsersEN pobjUser = value;
				Session.Add("objUser", pobjUser);
			}
		}

		private string DBServer
		{
			get
			{
				string strDBServer;
				strDBServer = (string)Session["DBServer"];
				if (strDBServer==null) 
				{
					strDBServer = "";
				}
				return strDBServer;
			}
			set
			{
				string strDBServer = value;
				Session.Add("DBServer", strDBServer);
			}
		}

		private DataTable ViewDataTable
		{
			get
			{
				DataTable dtViewDataTable;
				dtViewDataTable = (DataTable)Session["ViewDataTable"];
				if (dtViewDataTable==null) 
				{
				}
				return dtViewDataTable;
			}
			set
			{
				DataTable dtViewDataTable = value;
				Session.Add("ViewDataTable", dtViewDataTable);
			}
		}

		private string UserIDForMaster
		{
			get
			{
				string strUserIDForMaster;
				strUserIDForMaster = (string)Session["UserIDForMaster"];
				if (strUserIDForMaster==null) 
				{
					strUserIDForMaster = "";
				}
				return strUserIDForMaster;
			}
			set
			{
				string strUserIDForMaster = value;
				Session.Add("UserIDForMaster", strUserIDForMaster);
			}
		}
		private string PassWordForMaster
		{
			get
			{
				string strPassWordForMaster;
				strPassWordForMaster = (string)Session["PassWordForMaster"];
				if (strPassWordForMaster==null) 
				{
					strPassWordForMaster = "";
				}
				return strPassWordForMaster;
			}
			set
			{
				string strPassWordForMaster = value;
				Session.Add("PassWordForMaster", strPassWordForMaster);
			}
		}

		private void ReturnLoginView()
		{
			Session.Clear();
			string strMsg;
			strMsg = "对不起你的权限不够，请重新登录!";
			clsCommonJsFunc.Alert(this, strMsg);
            string ss = "<script language='javascript'> parent.window.location.href='Index.aspx'</script>";
			//			string ss = "<script language='javascript'> parent.main.location.href='index.htm'</script>";
			//			string ss = "<script language='javascript'> parent.window.location.href='main1.aspx' target='main';</script>";
			Response.Write(ss);
		}
		protected void btnGO_Click(object sender, System.EventArgs e)
		{
			clsDBServer objDBServer = new clsDBServer();
//			Session.Add("objDBServer", objDBServer);
			DataTable objDT;
			if (txtServer.Text.Trim()=="")
			{
				lblMsgForServer.Text = "服务器不能为空!";
				return ;
			}
			if (txtUserIdForMaster.Text.Trim()=="")
			{
				lblMsgForServer.Text = "数据库服务器中Master用户名不能为空!";
				return ;
			}
			objDBServer.UserId = txtUserId.Text;
			objDBServer.Server = txtServer.Text.Trim();
			objDBServer.UserIDForMaster = txtUserIdForMaster.Text.Trim();
			objDBServer.PassWordForMaster =txtPassWordForMaster.Text.Trim();
			objDBServer.DataBase = "master";
			clsSpecSQLforSql objSQL = new clsSpecSQLforSql(objDBServer.Server, objDBServer.DataBase, objDBServer.UserIDForMaster, objDBServer.PassWordForMaster);
			objDT = objSQL.getDataBases();
			ddlDatabase.DataSource = objDT;
			ddlDatabase.DataTextField = "name";
			ddlDatabase.DataBind();
			clsPubFun.SetButtonEnabled(btnGO2, true);
			txtUserIdForDB.Text = objDBServer.UserIDForMaster;
			txtPassWordForDB.Text = objDBServer.PassWordForMaster;
			objDBServer.PassWordForDB = objDBServer.PassWordForMaster;
			Session.Add("objDBServer", objDBServer);

		}

		protected void ddlTable_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			clsDBServer objDBServer = (clsDBServer)Session["objDBServer"];
			//生成类文件名和窗体文件名
			objDBServer.TabName = ddlTable.SelectedItem.Text.Trim();
			objDBServer.TabIndex = ddlTable.SelectedIndex;

			string strCurrTabName;
			strCurrTabName = ddlTable.SelectedItem.Text.Trim();;
            chkSelAll.Checked = false;
            lblMsgForOK.Text = "";
			BindDg_TabFields(strCurrTabName); //显示当前表的所有字段在DATAGRID中
		}

		private void BindDg_TabFields(string strTabName)
		{
			clsDBServer objDBServer = (clsDBServer)Session["objDBServer"];
			clsSpecSQLforSql objSqlSvr ;
			DataTable objDT;
			objSqlSvr = new clsSpecSQLforSql(objDBServer.Server, objDBServer.DataBase, objDBServer.UserIDForDB, objDBServer.PassWordForDB);
			string strOwner = txtUserIdForDB.Text.Trim();

			objDT = objSqlSvr.GetColumns(strTabName,strOwner);
			ViewDataTable = objDT;

			dgTabFields.DataSource = objDT;
			dgTabFields.DataBind();
		}


		protected void btnGO2_Click(object sender, System.EventArgs e)
		{
			clsDBServer objDBServer = (clsDBServer)Session["objDBServer"];

			DataTable objDT;

			if (ddlDatabase.SelectedItem.Text.Trim()=="")
			{
				return ;
			}
			if (txtUserIdForDB.Text.Trim()=="")
			{
				lblMsgForDB.Text = "数据库服务器中数据库用户名不能为空!";
				return ;
			}
			objDBServer.DataBase = ddlDatabase.SelectedItem.Text.Trim();
			objDBServer.UserIDForDB = txtUserIdForDB.Text.Trim();
			objDBServer.PassWordForDB =txtPassWordForDB.Text.Trim();
			if (objDBServer.PassWordForDB=="") objDBServer.PassWordForDB = objDBServer.PassWordForMaster;
			Session.Add("objDBServer", objDBServer);
			clsSpecSQLforSql objSQL = new clsSpecSQLforSql(objDBServer.Server, objDBServer.DataBase, objDBServer.UserIDForDB, objDBServer.PassWordForDB);
			objDT = objSQL.getViews();
			ddlTable.DataSource = objDT;
			ddlTable.DataTextField = "name";
			ddlTable.DataValueField = "id";
			ddlTable.DataBind();
			objDT = null;
			Session.Add("objDBServer", objDBServer);
		}

		private void Button1_Click(object sender, System.EventArgs e)
		{
			string strIP;
			strIP = Request.UserHostAddress.ToString();
		}



		protected void txtPassWordForDB_TextChanged(object sender, System.EventArgs e)
		{
			if (txtPassWordForDB.Text.Length>0) 
				clsPubFun.SetButtonEnabled(btnGO2, true);
		}

		protected void LinkButton2_Click(object sender, System.EventArgs e)
		{
			clsDBServer objDBServer = (clsDBServer)Session["objDBServer"];
			string ss = txtServer.Text.Trim();
			Session.Add("objDBServer", objDBServer);
			Response.Redirect("wfmJspCode.aspx?IP=" + ss + "&DataBase=aa");
		}

		protected void chkIsIdentical_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chkIsIdentical.Checked == true)
			{
				txtPassWordForDB.Enabled = false;
				txtUserIdForDB.Enabled = false;
			}
			else
			{
				txtPassWordForDB.Enabled = true;
				txtUserIdForDB.Enabled = true;
			}
			
		}

		protected void chkSelAll_CheckedChanged(object sender, System.EventArgs e)
		{
			this.Set_DataGridAllChecked(this.dgTabFields,this.chkSelAll);		
		}
		private void Set_DataGridAllChecked(DataGrid objDg,CheckBox objCkb)
		{
			if(objCkb==null || objDg.Items.Count==0 )
			{
				return;
			}
			else 
			{
				foreach(DataGridItem di in objDg.Items)
				{
					CheckBox cb=(CheckBox)di.FindControl("ckb1");
					if(cb!=null )
					{
						cb.Checked=objCkb.Checked;
					}
				}

			}
		}

		protected void btnOkAdd_Click(object sender, System.EventArgs e)
		{
			//操作步骤：
			//1、添加视图下拉框中的视图对象，在添加时需要检查是否重复；
			//2、再向该视图对象表中添加相关字段。
			//3、向视图表中添加该视图；
			//4、在视图表字段中添加相关字段。
			///
			ArrayList objArr=new ArrayList();
			string strSqlViewName;
			string strSqlViewId;
			//string strObjId;
			strSqlViewName = ddlTable.SelectedItem.Text;
            string strFuncModuleId = "";
            string strRelaTabName = clsPrjTabBLEx.GetReleTabNameByViewName(strSqlViewName);
            string strCondition = string.Format("TabName='{0}' And PrjId='{1}'", strRelaTabName, clsPubVar.CurrSelPrjId);

            clsPrjTabEN objRelePrjTab = clsPrjTabBL.GetFirstObj_S(strCondition);
            strFuncModuleId = objRelePrjTab.FuncModuleAgcId;

            try
			{
				lblMsg1.Text = "";
                //1、添加视图下拉框中的视图对象，在添加时需要检查是否重复；
                //            if (clsPrjObjectsBLEx.AddRecord(clsPubVar.CurrSelPrjId, objUser.UserId, strSqlViewName) == false)
                //{
                //	return ;
                //}
                //            strObjId = clsPrjObjectsBLEx.GetObjId(clsPubVar.CurrSelPrjId, strSqlViewName);
                ////删除原对象下的所有字段
                //if (clsPrjObjectsBLEx.DelObjFld(strObjId) == false)
                //{
                //	lblMsgForOK.Text = "删除对象相关字段不成功!";
                //	return ;
                //};
                List<string> arrFldIdLst = null;
                //2、再向该视图表中添加相关字段。
                if (chkSelAll.Checked == true)
				{
                    arrFldIdLst= this.ImportFldToFieldTab(ViewDataTable, clsPubVar.CurrSelPrjId);
				}
				else
				{
                    arrFldIdLst= this.ImportFldToFieldTab(this.dgTabFields, clsPubVar.CurrSelPrjId);
				}
                //3、向视图表中添加该视图；
                string strTabId = clsPrjTabBLEx.AddRecord(clsPubVar.CurrSelPrjId,
                    ddlDatabase.SelectedItem.Text, strSqlViewName, strSqlViewName, strSqlViewName, "02", strFuncModuleId, clsCommonSession.UserId);
                if (string.IsNullOrEmpty(strTabId) == true)
				{
					return ;
				}
				//4、在视图表字段中添加相关字段。
                strSqlViewId = clsPrjTabBLEx.GetTabId(clsPubVar.CurrSelPrjId, strSqlViewName);
				//删除视图下所有相关字段
				if (clsPrjTabBLEx.DelPrjTabFld_Hard(strSqlViewId) == false)
				{
					lblMsgForOK.Text = "删除视图相关字段不成功!";
					return ;
				}
                if (arrFldIdLst != null)
                {
                    foreach (string strFldId in arrFldIdLst)
                    {
                        clsPrjTabFldBLEx.Add_FieldTabToPrjTabFld(strTabId, strFldId, clsCommonSession.UserId);                        
                    }

                    Response.Write("<script>alert('所选字段添加成功！！')</script>");

                }
            }
			catch(Exception objException)
			{
				
				string strMsg = objException.Message;
				clsCommonJsFunc.Alert(this, strMsg);
				lblMsg1.Text = strMsg;
				//				clsCommonSession.seErrMessage = objException.Message;
				//				clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;	//"../GenCode/wfmGenViewCode_WebV5.aspx";
				//				clsPubFun4Web.AccessError(this, conCurrPageName);
			}
		}

        ///导入字段到表FieldTab中
        private List<string> ImportFldToFieldTab(DataGrid objDg, string strPrjId)
		{
            //clsFieldTabBLEx objFieldTabEN;
            List<string> arrFldIdLst = new List<string>();
            clsFieldTabENEx objFieldTabEN;
			string strTypeName;
			string strFldName;
			string strMsg;
			if(objDg.Items.Count==0)
			{
                return null;
			}
			else 
			{
				foreach(DataGridItem di in objDg.Items)
				{
					CheckBox cb=(CheckBox)di.FindControl("ckb1");
					if(cb!=null && cb.Checked)
					{
                        objFieldTabEN = new clsFieldTabENEx();
						///工程ID
                        objFieldTabEN.PrjId = clsPubVar.CurrSelPrjId;
						strFldName = di.Cells[1].Text;
                        ///转换类型名称
                        strTypeName = di.Cells[2].Text;
                        clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBLEx.GetObjByName(strTypeName);

                        if (objDataTypeAbbrEN == null)
                        {
                            throw new Exception(string.Format("Sql Server中数据类型名:{0}不存在,请检查!", strTypeName));
                        }
                     
                        ///检查是否存在相同的字段名
                        if (clsFieldTabBLEx.IsExistSameFldName(clsPubVar.CurrSelPrjId, strFldName, objDataTypeAbbrEN.DataTypeId) == true)
						{
                            objFieldTabEN.FldId = clsFieldTabBLEx.GetFldId(clsPubVar.CurrSelPrjId, strFldName, objDataTypeAbbrEN.DataTypeId);
							//clsFldObjTabBLEx.CreateFldObjRelation(strObjId, objFieldTabEN.FldId);
						}
						else
						{
                            objFieldTabEN.FldId = clsFieldTabBL.GetMaxStrIdByPrefix_S(clsPubVar.CurrSelPrjId);
							objFieldTabEN.FldName= strFldName;
                            objFieldTabEN.DataTypeId = objDataTypeAbbrEN.DataTypeId;
							objFieldTabEN.IsNull= di.Cells[4].Text=="YES"? true:false;
							objFieldTabEN.IsPrimaryKey=false;
							objFieldTabEN.FldLength=int.Parse( di.Cells[3].Text);
							objFieldTabEN.Caption = strFldName;
							objFieldTabEN.IsOnlyOne = false;
                            if (clsFieldTabBLEx.AddNewRecordEx(objFieldTabEN) == false)
							{

								strMsg = "添加不成功!";
								clsCommonJsFunc.Alert(this, strMsg);
								lblMsgForOK.Text = "添加记录不成功!";
							}
							else
							{
								strMsg = "添加记录成功!";
								//				clsCommonJsFunc.Alert(this, strMsg);
								lblMsgForOK.Text = "添加记录成功!";
							}
							//clsFldObjTabBLEx.CreateFldObjRelation(strObjId, objFieldTabEN.FldId);
						}
                        arrFldIdLst.Add(objFieldTabEN.FldId);

                    }
				}

			}
            return arrFldIdLst;
		}

		///导入字段到表FieldTab中
		private List<string> ImportFldToFieldTab(DataTable objDT, string strPrjId)
		{
            //clsFieldTabBLEx objFieldTabEN;
            List<string> arrFldIdLst = new List<string>();
            clsFieldTabENEx objFieldTabEN;
			string strTypeName;
			string strFldName;
			int intFldLength;
			bool bolIsNull;
			string strMsg;
			if(objDT.Rows.Count==0)
			{
				return null;
			}
			else 
			{
				foreach(DataRow row in objDT.Rows)
				{
					strFldName = row["Column_Name"].ToString();
					strTypeName = row["Type_Name"].ToString();
					intFldLength = int.Parse( row["length"].ToString());
					bolIsNull= row["Is_Nullable"].ToString()=="YES"? true:false;
                    clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBLEx.GetObjByName(strTypeName);

                    if (objDataTypeAbbrEN == null)
                    {
                        throw new Exception(string.Format("Sql Server中数据类型名:{0}不存在,请检查!", strTypeName));
                    }
                    objFieldTabEN = new clsFieldTabENEx();
					///工程ID
                    objFieldTabEN.PrjId = clsPubVar.CurrSelPrjId;
					///检查是否存在相同的字段名
                    if (clsFieldTabBLEx.IsExistSameFldName(clsPubVar.CurrSelPrjId, strFldName, objDataTypeAbbrEN.DataTypeId) == true)
					{
                        objFieldTabEN.FldId = clsFieldTabBLEx.GetFldId(clsPubVar.CurrSelPrjId, strFldName, objDataTypeAbbrEN.DataTypeId);
						//clsFldObjTabBLEx.CreateFldObjRelation(strObjId, objFieldTabEN.FldId);
					}
					else
					{
                        objFieldTabEN.FldId = clsFieldTabBL.GetMaxStrIdByPrefix_S(clsPubVar.CurrSelPrjId);
						objFieldTabEN.FldName= strFldName;
						///转换类型名称
                        List<string> arrID = new List<string>();
						arrID = clsDataTypeAbbrBL.GetPrimaryKeyID_S("DataTypeName = '" + strTypeName + "'");
						objFieldTabEN.DataTypeId=arrID[0].ToString();
						objFieldTabEN.IsNull= bolIsNull;
						objFieldTabEN.IsPrimaryKey=false;
						objFieldTabEN.FldLength=intFldLength;
						objFieldTabEN.Caption = strFldName;
						objFieldTabEN.IsOnlyOne = false;
                        if (clsFieldTabBLEx.AddNewRecordEx(objFieldTabEN) == false)
						{

							strMsg = "添加不成功!";
							clsCommonJsFunc.Alert(this, strMsg);
							lblMsgForOK.Text = "添加记录不成功!";
						}
						else
						{
							strMsg = "添加记录成功!";
							//				clsCommonJsFunc.Alert(this, strMsg);
							lblMsgForOK.Text = "添加记录成功!";
						}
						//clsFldObjTabBLEx.CreateFldObjRelation(strObjId, objFieldTabEN.FldId);
					}
                    arrFldIdLst.Add(objFieldTabEN.FldId);

                }
			}
            return arrFldIdLst;
		}

		
		protected void lbReturnFieldTab_Click(object sender, System.EventArgs e)
		{
            JumpOtherPages("wfmPrjTab_QUDI3.aspx");
		}

		protected void dgTabFields_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//操作步骤：（共2步）
			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页

			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			this.dgTabFields.CurrentPageIndex=e.NewPageIndex;
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页
			string strCurrTabName;
			strCurrTabName = ddlTable.SelectedItem.Text.Trim();;
			BindDg_TabFields(strCurrTabName);
		}

        #region 处理父页面信息以及跳转到其他页面

        public override void InitParentPageInfo()
        {
            switch (qsParentPage)
            {
                case "wfmPrjTab_QUDI3.aspx":


                    break;
                case "":
                    break;
                default:
                    clsCommonJsFunc.Alert(this, string.Format("父页面名称：[{0}]在({1})中没有处理！", qsParentPage, 
                        clsStackTrace.GetCurrClassFunction()));
                    break;
            }

        }
        public override void ReturnParentPage()
        {
            string strCurrPageName = string.Format("{0}|{1}", conCurrPageName, vsParentPage);

            switch (qsParentPage)
            {
                case "wfmPrjTab_QUDI3.aspx":

                    clsPubFun4Web.JumpToPrjTab_QUDI3(this, strCurrPageName);
                    break;
                case "wfmEditTabAndObjectFields.aspx":

                    clsPubFun4Web.JumpToPrjTab_QUDI3(this, strCurrPageName);
                   
                    break;
                case "wfmTabCheckResultB_QUDI.aspx":

                    Response.Redirect("../LogManage/wfmTabCheckResultB_QUDI.aspx");
                    break;
                case "":
                    break;
                default:
                    clsCommonJsFunc.Alert(this, string.Format("父页面名称：[{0}]在({1})中没有处理！", qsParentPage, clsStackTrace.GetCurrClassFunction()));
                    break;
            }

        }
        /// <summary>
        /// 跳转到其他页面
        /// </summary>
        /// <param name="strPageName"></param>
        public override void JumpOtherPages(string strPageName)
        {
            string strCurrPageName = string.Format("{0}|{1}", conCurrPageName, vsParentPage);
            switch (strPageName)
            {
                case "wfmPrjTab_QUDI3.aspx":

                    clsPubFun4Web.JumpToPrjTab_QUDI3(this, strCurrPageName);
                    break;
                case "":
                    break;
                default:
                    clsCommonJsFunc.Alert(this, string.Format("父页面名称：[{0}]在({1})中没有处理！", qsParentPage, clsStackTrace.GetCurrClassFunction()));
                    break;
            }
        }
        #endregion 处理父页面信息

        /// <summary>
        /// 常量:当前页面名称
        /// </summary>
        public override string conCurrPageName
        {
            get
            {
                return "wfmPrjTab_CheckConsistency.aspx";
            }
        }
    }
}
