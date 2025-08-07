using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TzCommWebServerCtrlLib;
using System.Collections;

namespace AGC.Webform
{
    public partial class wfmTestWccFieldGroup : System.Web.UI.Page
    {
        //生成权限等级的属性
        private List<string> arrObjLst
        {
            get
            {
                List<string> sarrObjLst;
                sarrObjLst = (List<string>)ViewState["arrObjLst"];
                if (sarrObjLst == null)
                {
                    //					sarrObjLst=new General_Platform_Dll.MenuAndPotence().Get_arrObjLst(ViewId4Potence);
                    sarrObjLst = null;
                    ViewState.Add("arrObjLst", sarrObjLst);
                }
                return sarrObjLst;
            }
            set
            {
                List<string> sarrObjLst = value;
                ViewState.Add("arrObjLst", sarrObjLst);
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                 List<string> arrObjLst1 = new List<string>();
                 arrObjLst1.Add("AA");
                 arrObjLst1.Add("BB");
                 arrObjLst1.Add("CC");
                arrObjLst = arrObjLst1;
            }
            ShowObj();
            //wccFieldGroup a2 = new wccFieldGroup();
            //    a2.DelThisCtrlClick += new EventHandler(wccFieldGroup2_DelThisCtrlClick);
            //    phQueryRegion.Controls.Add(a2);
            //}
        }
        private void ShowObj()
        {
           
            foreach (string strObj in arrObjLst)
            {
                wccFieldGroup a1 = new wccFieldGroup();
                a1.DelThisCtrlClick += new EventHandler(wccFieldGroup2_DelThisCtrlClick);
                a1.Caption = strObj;
                a1.ID = strObj;
                phQueryRegion.Controls.Add(a1);

            }
        }

        protected void wccFieldGroup2_DelThisCtrlClick(object sender, EventArgs e)
        {
            wccFieldGroup thisCtrl = (wccFieldGroup)sender;
            string strId = thisCtrl.ID;
            //thisCtrl.Visible = false;
            string strCaption = thisCtrl.Caption;
            arrObjLst.Remove(strCaption);
            foreach (Control ctrl in phQueryRegion.Controls)
            {
                wccFieldGroup thisCtrl1 = (wccFieldGroup)ctrl;
                if (thisCtrl1.ID == strId)
                {
                    phQueryRegion.Controls.Remove(ctrl);
                }
            }
            //this.Controls.Remove(thisCtrl);
        }
    }
}