

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AGC.Webform
{
    public partial class wfmRegisterBak20170407 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Page.Title = clsMyConfig.spSiteName + " -- 用户注册";
            //clsCommonSession.MenuCss = "Index";

            if (!IsPostBack)
            {


            }
        }

        // 动态修改Page的Theme要在Page_PreInit方法中实现
        protected void Page_PreInit(object sender, System.EventArgs e)
        {
            //string theme = "";

            //if (clsCommonSession.Theme == "")
            //{
            //    theme = clsCommonSession.configThemes;
            //}
            //else
            //{
            //    theme = clsCommonSession.Theme;
            //}
            //Page.Theme = theme;
        }
    }
}