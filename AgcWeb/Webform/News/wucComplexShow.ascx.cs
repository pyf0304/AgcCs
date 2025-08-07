using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using com.taishsoft.common;
using AGC.BusinessLogic;

namespace Webtaisoft.Web
{
    public partial class wucComplexShow : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                BindWebForm();

                BindMVC();

                BindCore();

                BindAndroid();

                BindIOS();

                BindWebService();

                Bindjavascript();

                Bindtypescript();

                BindWebApi();
            }
        }
        //绑定WebForm
        private void BindWebForm()
        {
            stuTopPara objTopPara = new stuTopPara();
            objTopPara.topSize = 7;
            objTopPara.whereCond = " NewsTypeId = 1 ";
            objTopPara.orderBy = " IsTop desc,  EditTime desc";
            DataTable dt = clsNewsBL.GetDataTable_Top(objTopPara);
            this.rpWebForm.DataSource = dt;
            this.rpWebForm.DataBind();
        }

        //绑定MVC
        private void BindMVC()
        {
            stuTopPara objTopPara = new stuTopPara();
            objTopPara.topSize = 7;
            objTopPara.whereCond = " NewsTypeId = 2 ";
            objTopPara.orderBy = " IsTop desc,  EditTime desc";
            DataTable dt = clsNewsBL.GetDataTable_Top(objTopPara);
            this.rpMVC.DataSource = dt;
            this.rpMVC.DataBind();
        }

        //绑定Core
        private void BindCore()
        {
            stuTopPara objTopPara = new stuTopPara();
            objTopPara.topSize = 7;
            objTopPara.whereCond = " NewsTypeId = 3 ";
            objTopPara.orderBy = " IsTop desc,  EditTime desc";
            DataTable dt = clsNewsBL.GetDataTable_Top(objTopPara);
            this.rpCore.DataSource = dt;
            this.rpCore.DataBind();

        }

        //绑定Android
        private void BindAndroid()
        {
            stuTopPara objTopPara = new stuTopPara();
            objTopPara.topSize = 7;
            objTopPara.whereCond = " NewsTypeId = 4 ";
            objTopPara.orderBy = " IsTop desc,  EditTime desc";
            DataTable dt = clsNewsBL.GetDataTable_Top(objTopPara);
            this.rpAndroid.DataSource = dt;
            this.rpAndroid.DataBind();

        }

        //绑定Android
        private void BindIOS()
        {
            stuTopPara objTopPara = new stuTopPara();
            objTopPara.topSize = 7;
            objTopPara.whereCond = " NewsTypeId = 5 ";
            objTopPara.orderBy = " IsTop desc,  EditTime desc";
            DataTable dt = clsNewsBL.GetDataTable_Top(objTopPara);
            this.rpIos.DataSource = dt;
            this.rpIos.DataBind();

        }

        //绑定WebService
        private void BindWebService()
        {
            stuTopPara objTopPara = new stuTopPara();
            objTopPara.topSize = 7;
            objTopPara.whereCond = " NewsTypeId = 6 ";
            objTopPara.orderBy = " IsTop desc,  EditTime desc";
            DataTable dt = clsNewsBL.GetDataTable_Top(objTopPara);
            this.rpWebService.DataSource = dt;
            this.rpWebService.DataBind();

        }

        //绑定WebService
        private void Bindjavascript()
        {
            stuTopPara objTopPara = new stuTopPara();
            objTopPara.topSize = 7;
            objTopPara.whereCond = " NewsTypeId = 7 ";
            objTopPara.orderBy = " IsTop desc,  EditTime desc";
            DataTable dt = clsNewsBL.GetDataTable_Top(objTopPara);
            this.rpjavascript.DataSource = dt;
            this.rpjavascript.DataBind();

        }

        //绑定WebService
        private void Bindtypescript()
        {
            stuTopPara objTopPara = new stuTopPara();
            objTopPara.topSize = 7;
            objTopPara.whereCond = " NewsTypeId = 8 ";
            objTopPara.orderBy = " IsTop desc,  EditTime desc";
            DataTable dt = clsNewsBL.GetDataTable_Top(objTopPara);
            this.rptypescript.DataSource = dt;
            this.rptypescript.DataBind();

        }


        //绑定WebApi
        private void BindWebApi()
        {
            stuTopPara objTopPara = new stuTopPara();
            objTopPara.topSize = 7;
            objTopPara.whereCond = " NewsTypeId = 9 ";
            objTopPara.orderBy = " IsTop desc,  EditTime desc";
            DataTable dt = clsNewsBL.GetDataTable_Top(objTopPara);
            this.rpWebApi.DataSource = dt;
            this.rpWebApi.DataBind();

        }
    }
}