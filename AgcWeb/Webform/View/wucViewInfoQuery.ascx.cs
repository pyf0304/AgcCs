namespace AGC.Webform
{
    using System;
    using System.Data;
    using System.Drawing;
    using System.Web;
    using System.Web.UI.WebControls;
    using System.Web.UI.HtmlControls;
    using CommFunc4WebForm;
    using AGC.BusinessLogic;using AGC.FunClass;
    
    using AGC.BusinessLogicEx;

    /// <summary>
    ///		wucViewInfoQuery 的摘要说明。
    /// </summary>
    public partial class wucViewInfoQuery : System.Web.UI.UserControl
	{

		protected void Page_Load(object sender, System.EventArgs e)
		{
			// 在此处放置用户代码以初始化页面
			tabHidden.Visible = false;
		}
        public string ApplicationTypeId
        {
            get
            {
                if (ddlApplicationTypeId.SelectedValue == "0")
                    return "";
                return ddlApplicationTypeId.SelectedValue;
            }
            set
            {
                if (value == "")
                {
                    ddlApplicationTypeId.SelectedValue = "0";
                }
                else
                {
                    ddlApplicationTypeId.SelectedValue = value;
                    if (ddlApplicationTypeId.SelectedIndex > 0)
                    {
                        string strApplicationTypeId = ddlApplicationTypeId.SelectedValue;

                    }
                }
            }
        }

		public string FuncModuleAgcId
		{
			get
			{
				if (ddlFuncModuleId.SelectedValue == "0")
				{
					return "";
				}
				return ddlFuncModuleId.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlFuncModuleId.SelectedValue = "0";
				}
				else
				{
					ddlFuncModuleId.SelectedValue = value;
				}
			}
		}

		public string ViewName
		{
			get
			{
				return txtViewName.Text.Trim();
			}
			set
			{
				txtViewName.Text = value.ToString();
			}
		}


		
		/// <summary>
		/// 把所有的查询控件内容组合成一个条件串
		/// </summary>
		/// <returns>条件串(strWhereCond)</returns>
		public string CombineCondition()
		{
			//使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
			//例如 1=1 and UserName = '张三'
			string strWhereCond=" 1=1 ";
			//如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
			if (this.txtViewName.Text.Trim()!="")
			{
				strWhereCond += " and ViewName like '" + this.txtViewName.Text.Trim()+"%'";
			}

			if (this.ddlFuncModuleId.SelectedValue!="" && this.ddlFuncModuleId.SelectedValue!="0")
			{
				strWhereCond += " And FuncModuleAgcId='" + this.ddlFuncModuleId.SelectedValue+"'";
			}
			if (this.txtMainTabName.Text.Trim()!="")
			{
				strWhereCond += " and MainTabName like '" + this.txtMainTabName.Text.Trim()+"%'";
			}
			if (this.txtDetailTabName.Text.Trim()!="")
			{
				strWhereCond += " and DetailTabName like '" + this.txtDetailTabName.Text.Trim()+"%'";
			}
			//			if (this.chkIsNeedSort._Checked==true)
			//				strWhereCond += " and ViewInfo.IsNeedSort='1'";
			//			else
			//				strWhereCond += " and ViewInfo.IsNeedSort='0'";
			//			if (this.chkIsNeedTransCode._Checked==true)
			//				strWhereCond += " and ViewInfo.IsNeedTransCode='1'";
			//			else
			//				strWhereCond += " and ViewInfo.IsNeedTransCode='0'";
			if (this.txtUserId.Text.Trim()!="")
			{
				strWhereCond += " and UserId='" + this.txtUserId.Text.Trim()+"'";
			}
			if (this.ddlPrjId.SelectedValue!="" && this.ddlPrjId.SelectedValue!="0")
			{
				strWhereCond += " and PrjId='" + this.ddlPrjId.SelectedValue+"'";
			}
            if (this.ddlApplicationTypeId.SelectedValue != "" && this.ddlApplicationTypeId.SelectedValue != "0")
            {
                strWhereCond += " And ApplicationTypeId='" + this.ddlApplicationTypeId.SelectedValue + "'";
            }

			return strWhereCond;
		}
		public void SetDdl_FuncModuleId(string strPrjId)
		{
			clsFuncModule_AgcBLEx.BindDdl_FuncModuleId(ddlFuncModuleId, strPrjId, clsPubVar.CurrPrjDataBaseId);
		}
		public void SetDdl_PrjId()
		{
			clsProjectsBLEx.BindDdl_PrjIdCacheEx(ddlPrjId);
		}
        protected void ddlApplicationTypeId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlApplicationTypeId.SelectedIndex > -1)
            {
                int strApplicationTypeId = int.Parse( ddlApplicationTypeId.SelectedValue);
            }

        }
}
}
