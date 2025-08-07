
namespace AGC.Webform
{
    using System;
    using System.Data;
    using System.Drawing;
    using System.Collections;
    using System.Web;
    using System.Web.UI.WebControls;
    using System.Web.UI.HtmlControls;
    using com.taishsoft.commdb;
    using CommFunc4WebForm;
    using AGC.BusinessLogic;
    using AGC.FunClass;
    
    using AGC.BusinessLogicEx;
    using AGC.Entity;
    using System.Collections.Generic;
    using System.Linq;
    using com.taishsoft.common;
    using System.Text;
    using AGC.PureClass;
    using AGC.PureClassEx;

    /// <summary>
    ///		wucListRegionFlds 的摘要说明。
    /// </summary>
    public partial class wucListRegion4Preview : System.Web.UI.UserControl
    {

        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面


        }
        /// <summary>
        /// 设置标题
        /// </summary>
        public string Title
        {
            set
            {
                lblTitle.Text = value;
            }
        }

        public class ControlIdComparer : IEqualityComparer<ASPControlEx>
        {
            public bool Equals(ASPControlEx t1, ASPControlEx t2)
            {
                return (t1.CtrlId == t2.CtrlId);
            }
            public int GetHashCode(ASPControlEx t)
            {
                return t.ToString().GetHashCode();
            }
        }
        public void ShowControl4Regoin(string lngRegionId, string strPrjId, int intRecNum, bool bolInUse, string strCmPrjId)
        {
            clsViewRegionEN objViewRegion = clsViewRegionBL.GetObjByRegionIdCache(lngRegionId, clsPubVar.CurrCmPrjId);
            if (bolInUse == false)
            {
                lblTitle.Visible = false;
                lblTitleOutUse.Visible = true;
                if (string.IsNullOrEmpty(objViewRegion.ClsName) == false)
                {
                    lblTitleOutUse.Text = string.Format("列表区: <span class='text-secondary  font-weight-bold'>(类名:{0})</span>", objViewRegion.ClsName);
                }
                pnlControlLst.Controls.Clear();
                return;
            }
            else
            {
                lblTitle.Visible = true;
                if (string.IsNullOrEmpty(objViewRegion.ClsName) == false && lblTitle.Text.Contains("可视化"))
                {
                    lblTitle.Text = string.Format("可视化 <span class='text-secondary  font-weight-bold'>(类名:{0})</span>", objViewRegion.ClsName);
                }
                else
                {
                    lblTitle.Text = string.Format("列表区: <span class='text-secondary  font-weight-bold'>(类名:{0})</span>", objViewRegion.ClsName);
                }
                lblTitleOutUse.Visible = false;
     
            }

            pnlControlLst.Controls.Clear();
            //clsvDGRegionEN objvDGRegion = null;
            //try
            //{
            //    objvDGRegion = clsvDGRegionBL.GetObjByRegionId(lngRegionId);

            //}
            //catch (Exception objException)
            //{
            //    clsGeneralTab.LogErrorS(objException, clsStackTrace.GetCurrClassFunction());
            //    StringBuilder sbMsg = new StringBuilder();
            //    sbMsg.AppendFormat("在获取列表区域对象（GetObjByRegionId）时出错！区域Id：{0},出错信息：{1}。({2})",
            //        lngRegionId, objException.Message,
            //        clsStackTrace.GetCurrClassFunction());
            //    clsSysParaEN_Local.objLog4GCError.WriteDebugLog(sbMsg.ToString());
            //    throw new Exception(sbMsg.ToString());
            //}
            //int intRowNo = 0;
            //string strPrjId = "0116";// clsPubVar.CurrSelPrjId;
            ASPHtmlTableEx objTable = clsASPHtmlTableBLEx.GetObj4ListRegion();
            List<clsDGRegionFldsENEx> arrDGRegionFlds = clsDGRegionFldsBLEx.GetObjExLstByRegionIdEx1(lngRegionId, clsPubVar.CurrCmPrjId);
            //int intLen = arrDGRegionFlds.Count;

            //for (int i = 0; i<intLen; i++)
            //{
            //    clsDGRegionFldsENEx obj_i = arrDGRegionFlds[i];
            //    for (int j = 0; j<i; j++)
            //    {
            //        clsDGRegionFldsENEx obj_j = arrDGRegionFlds[j];
            //        if (obj_j.CtrlName == obj_i.CtrlName)
            //        {
            //            obj_j.CtrlName = string.Format("{0}_2", obj_j.CtrlName);
            //        }
            //    }
            //}
            ASPCheckBoxEx objAspCheckBox = new ASPCheckBoxEx();
            objAspCheckBox.IsCheckBox = true;
            
            objAspCheckBox.CtrlId = string.Format("chk{0}", vsRowNo++);
            //objAspCheckBox.Is4PureHtml = true;
            clsPubVar.objLog.WriteDebugLog(objAspCheckBox.CtrlId);
            clsASPControlBLEx.arrCtrlId = null;
            List<ASPControlEx> arrASPControlObjLst
                = arrDGRegionFlds
            
                .Select(x=>clsASPControlBLEx.GetControl_Asp(x, strCmPrjId))
                .ToList();

            arrASPControlObjLst.Insert(0, objAspCheckBox);

            IEnumerable<ASPControlEx> arrASPControlObjLst_All = arrASPControlObjLst.Select(clsASPControlBLEx.PackageTd);

            //把查询按钮加进来
            //ASPControlGroupEx objASPControlGroup = clsASPControlGroupBLEx.GetbtnQuery();
            //List<ASPControlGroupEx> arrButtonObjLst = new List<ASPControlGroupEx>();
            //arrButtonObjLst.Add(objASPControlGroup);
            //arrASPControlGroupObjLst = arrASPControlGroupObjLst.Union(arrButtonObjLst);
            //封装Td


            //int intCount = 0;
            ASPRowEx objRow = new ASPRowEx();
            objRow.RowType = "headrow";
            objTable.arrSubAspControlLst2.Add(objRow);
            foreach (ASPControlEx objInFor in arrASPControlObjLst_All)
            {
                objRow.arrSubAspControlLst2.Add(objInFor);
            }
            DataTable objDT = null;

            try
            {
                objDT = clsTablesBLEx.GetDataTableByTop(clsPubVar.CurrPrjDataBaseId, objViewRegion.TabName(), intRecNum, "1=1", "");
            }
            catch (Exception objException)
            {
                clsGeneralTab.LogErrorS(objException, clsStackTrace.GetCurrClassFunction());
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.AppendFormat("在获取表内容（GetDataTableByTabName）时出错！表名：{0},出错信息：{1}。({2})",
                    objViewRegion.TabName(), objException.Message,
                    clsStackTrace.GetCurrClassFunction());
                clsSysParaEN_Local.objLog4GCError.WriteDebugLog(sbMsg.ToString());
                throw new Exception(sbMsg.ToString());
            }
            foreach (DataRow objInFor in objDT.Rows)
            {
                ASPRowEx objRow_Data = new ASPRowEx();
                objRow_Data.RowType = "datarow";
                objRow_Data.objDataRow = objInFor;

                ASPCheckBoxEx objAspCheckBox1 = new ASPCheckBoxEx();
                objAspCheckBox1.IsCheckBox = true;
                objAspCheckBox1.CtrlId = string.Format("chk{0}", vsRowNo);
                List<ASPControlEx> arrASPControlObjLst1
                    = arrDGRegionFlds
                    
                    .Select(x=>clsASPControlBLEx.GetControl_Asp(x,strCmPrjId))
                    .ToList();
                arrASPControlObjLst1.ForEach(x=>x.CtrlId = string.Format("{0}{1}", x.CtrlId, vsRowNo));
                arrASPControlObjLst1.Insert(0, objAspCheckBox1);

                List<ASPControlEx> arrASPControlObjLst_All1 = arrASPControlObjLst1.Select(clsASPControlBLEx.PackageTd).ToList();
                               
                foreach (ASPControlEx objInFor_Sub in arrASPControlObjLst_All1)
                {
                    ASPControlEx objChk = objInFor_Sub.arrSubAspControlLst2[0];
                    
                    string strTypeName = objChk.GetType().ToString();
                    if (strTypeName == "AGC.PureClass.ASPCheckBoxEx")
                    {
                        clsPubVar.objLog.WriteDebugLog(objChk.CtrlId);
                    }

                    objRow_Data.arrSubAspControlLst2.Add(objInFor_Sub);
                }
                objTable.arrSubAspControlLst2.Add(objRow_Data);
                vsRowNo++;
            }
            HtmlGenericControl objDiv = new HtmlGenericControl("div");
            objTable.GeneHtmlControl(objDiv);
            pnlControlLst.Controls.Add(objDiv);
            divListRegion4Preview.Style["width"] = string.Format("{0}px", objViewRegion.Width);
        }
        public int vsRowNo
        {
            get
            {
                string strRowNo;
                strRowNo = (string)ViewState["RowNo"];
                if (strRowNo == null)
                {
                    return 0;
                }
                return int.Parse(strRowNo);
            }
            set
            {
                string strRowNo = value.ToString();
                ViewState.Add("RowNo", strRowNo);
            }
        }
    }
}