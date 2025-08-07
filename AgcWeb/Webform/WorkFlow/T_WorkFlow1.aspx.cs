using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AGC.FunClass;
using CommFunc4WebForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AgcMvc3.Webform.A_TestWorkFlow
{
    public partial class T_WorkFlow1 : System.Web.UI.Page
    {
        //string this.WorkFlowId = "0001";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.PrjId = "0001";
                this.WorkFlowId = "0001";
                clswf_PointBLEx.BindDdl_PointIdByPrjIdCache(ddlStartPoint, PrjId);
                clswf_PointBLEx.BindDdl_PointIdByPrjIdCache(ddlEndPoint, PrjId);
                clswf_WorkFlowBLEx.BindDdl_WorkFlowIdByPrjIdCache(ddlWorkFlowId, PrjId);

            }
        }

        protected void btnDispWorkFlow_Click(object sender, EventArgs e)
        {
            DispWorkFlow();
        }
        protected void DispWorkFlow()
        {
            //IEnumerable<clswf_StepPointRelaEN> arrwf_StepPointRela = clswf_StepPointRelaBLEx.GetObjLstByWorkFlowId(this.WorkFlowId);
            Table objTable = new Table();
            for (int iLevel = 0; iLevel < 100; iLevel++)
            {
                TableRow objRow = new TableRow();
                IEnumerable<clswf_PointEN> arrPoint_Sub = clswf_PointBLEx.GetObjLstByWorkFlowIdAndLevelNo(this.WorkFlowId, iLevel);
                if (arrPoint_Sub.Count() == 0) break;
                foreach (clswf_PointEN objInFor in arrPoint_Sub)
                {
                    Tuple<int , int> objT1 = clswf_StepPointRelaBLEx.GetInOutDegreeByWorkFlowIdAndPointIdCache(this.WorkFlowId, objInFor.PointId);
                    
                    TableCell objCell = new TableCell();

                    IEnumerable<clswf_PointEN> arrPrevPointObjLst = clswf_PointBLEx.GetPrevPointObjLst(this.WorkFlowId, objInFor.PointId);
                    StringBuilder sbMsg = new StringBuilder();
                    foreach (clswf_PointEN objInFor2 in arrPrevPointObjLst)
                    {
                        sbMsg.AppendFormat("{0}({1}),", objInFor2.PointName, objInFor2.PointId);
                    }
                    Label objLabel = new Label();
                    objLabel.Text = string.Format("<span class=\"text-dark\" style=\"font-size:12px;\">({0}=>)</span>" +
                        "<span class=\"text-info\" style=\"font-size:14px;\">{3}-{1}({2})(In:{4}, Out:{5})</span>", 
                        sbMsg.ToString(), 
                        objInFor.PointName, objInFor.PointId, iLevel, objT1.Item1, objT1.Item2);
                    objCell.Controls.Add(objLabel);
                    objRow.Cells.Add(objCell);
                }
                objTable.Rows.Add(objRow);
            }
            Panel1.Controls.Add(objTable);
        }

        protected void btnSetLevelNo_Click(object sender, EventArgs e)
        {
            if (clswf_WorkFlowBLEx.SetLevelNoByWorkFlowId(this.WorkFlowId))
            {
                clsCommonJsFunc.Alert(this, "设置层成功！");
            };
        }

        protected void btnCreateWorkFlow_Click(object sender, EventArgs e)
        {
            List<clsCodeTypeEN> arrCodeTypeObjLst = clsCodeTypeBL.GetObjLst("InUse='1' order by CodeTypeName");
            clswf_PointEN objwf_PointEN = clswf_PointBLEx.CreatePoint(PrjId, "起点", "NoTab", "StartPoint", clsCommonSession.UserId);

            arrCodeTypeObjLst.ForEach(x=> {
                string strPointName = string.Format("{0}-{1}", x.CodeTypeName, clsProgLangTypeBL.GetNameByProgLangTypeIdCache(x.ProgLangTypeId));
                clswf_PointBLEx.CreatePoint(PrjId, strPointName, clsCodeTypeEN._CurrTabName, x.CodeTypeId, clsCommonSession.UserId);
            });

//            clswf_ProcessBLEx.CreateProcess(PrjId, );
            clsCommonJsFunc.Alert(this, "建立工作流结点完成！");
        }

        protected void btnAddPrecess_Click(object sender, EventArgs e)
        {
            string strStartPoint = ddlStartPoint.SelectedValue;
            string strEndPoint = ddlEndPoint.SelectedValue;
            clswf_PointEN objwf_Point_Start = clswf_PointBLEx.GetObjByPointIdCache(PrjId, strStartPoint);
            clswf_PointEN objwf_Point_End = clswf_PointBLEx.GetObjByPointIdCache(PrjId, strEndPoint);
            string strProcessName = string.Format("{0}->{1}", objwf_Point_Start.PointName, objwf_Point_End.PointName);
        clswf_ProcessEN objwf_Process = clswf_ProcessBLEx.CreateProcess(PrjId, strProcessName, strStartPoint, strEndPoint, clsCommonSession.UserId);
            clswf_StepProcessRelaBLEx.CreateStepProcessRela(this.WorkFlowId, objwf_Process.ProcessId, clsCommonSession.UserId);
            if (objwf_Point_Start.PointName != "起点")
            {
                clswf_StepPointRelaBLEx.CreateStepPointRela(this.WorkFlowId, strStartPoint, enumwf_PointType.DataPoint_03, clsCommonSession.UserId);
            }
            if (objwf_Point_End.PointName != "终点")
            {
                clswf_StepPointRelaBLEx.CreateStepPointRela(this.WorkFlowId, strEndPoint, enumwf_PointType.DataPoint_03, clsCommonSession.UserId);
            }
            try
            {
                clswf_WorkFlowBLEx.SetLevelNoByWorkFlowId(this.WorkFlowId);
            }
            catch(Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
            }
            DispWorkFlow();
        }

        protected void btnInitWorkFlow_Click(object sender, EventArgs e)
        {
            if (ddlWorkFlowId.SelectedIndex <= 0) return;
            this.WorkFlowId = ddlWorkFlowId.SelectedValue;
            string strPointName = "起点";
            clsvwf_StepPointRelaEN objvwf_StepPointRela = clsvwf_StepPointRelaBLEx.GetObjByPointName(this.WorkFlowId, strPointName);
            if (objvwf_StepPointRela == null)
            {
                clswf_PointEN objwf_PointEN = clswf_PointBLEx.CreatePoint(PrjId, "起点", "NoTab", "StartPoint", clsCommonSession.UserId);
                clswf_StepPointRelaBLEx.CreateStepPointRela(this.WorkFlowId, objwf_PointEN.PointId, enumwf_PointType.StartPoint_01, clsCommonSession.UserId);
            }
            strPointName = "终点";
            clsvwf_StepPointRelaEN objvwf_StepPointRela_End = clsvwf_StepPointRelaBLEx.GetObjByPointName(this.WorkFlowId, strPointName);
            if (objvwf_StepPointRela_End == null)
            {
                clswf_PointEN objwf_PointEN = clswf_PointBLEx.CreatePoint(PrjId, "终点", "NoTab", "EndPoint", clsCommonSession.UserId);
                clswf_StepPointRelaBLEx.CreateStepPointRela(this.WorkFlowId, objwf_PointEN.PointId, enumwf_PointType.EndPoint_02, clsCommonSession.UserId);
            }

        }

        protected void chkLimitInWorkFlow_Start_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLimitInWorkFlow_Start.Checked == true)
            {
                clsvwf_StepPointRelaBLEx.BindDdl_PointIdByWorkFlowIdCache(ddlStartPoint, this.WorkFlowId);
            }
            else
            {
                clswf_PointBLEx.BindDdl_PointIdByPrjIdCache(ddlStartPoint, PrjId);
            }
        }

        protected void chkLimitInWorkFlow_End_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLimitInWorkFlow_End.Checked == true)
            {
                clsvwf_StepPointRelaBLEx.BindDdl_PointIdByWorkFlowIdCache(ddlEndPoint, this.WorkFlowId);
            }
            else
            {
                clswf_PointBLEx.BindDdl_PointIdByPrjIdCache(ddlEndPoint, PrjId);
            }
        }
        private string PrjId
        {
            get
            {
                string sSortBy;
                sSortBy = (string)ViewState["PrjId"];
                if (sSortBy == null)
                {
                    sSortBy = "";
                }
                return sSortBy;
            }
            set
            {
                string sSortBy = value;
                ViewState.Add("PrjId", sSortBy);
            }
        }
        private string WorkFlowId
        {
            get
            {
                string sSortBy;
                sSortBy = (string)ViewState["WorkFlowId"];
                if (sSortBy == null)
                {
                    sSortBy = "";
                }
                return sSortBy;
            }
            set
            {
                string sSortBy = value;
                ViewState.Add("WorkFlowId", sSortBy);
            }
        }
    }
}