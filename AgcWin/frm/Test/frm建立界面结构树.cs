using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AGC.Entity;
using AutoGCLib;
using AGC.PureClass;
//using AGC.BusinessLogicEx;
using AGC4WApi;
using AGC.PureClassEx;
using AGC.BusinessLogicEx;

namespace Agc_CsWin.frm.Test
{
    public partial class frm建立界面结构树 : Form
    {
        private ASPInterfaceEx objASPNETInterfaceENEx = null;
        public frm建立界面结构树()
        {
            InitializeComponent();
        }

        private void btnCreateInterfaceHtmlTree_Click(object sender, EventArgs e)
        {
            string strViewId = "01160002";
            string strViewName = "wfmSex_QUDI";
            string strCondition = string.Format("ViewName='{0}' And PrjId='{1}'", strViewName, "0116");
            strViewId = clsViewInfoWApi.GetFirstID(strCondition);

            clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
            //clsViewInfoExWApi.GetViewInfoEx(ref objViewInfoENEx, "0116");


            objASPNETInterfaceENEx = new ASPInterfaceEx();
            objASPNETInterfaceENEx.AspControlName = "TestView";
            ASPHeadEx objASPNETHeadENEx = new ASPHeadEx();
            objASPNETHeadENEx.AspControlName = "Head";
            objASPNETInterfaceENEx.arrSubAspControlLst2.Add(objASPNETHeadENEx);


            ASPBodyEx objASPNETBodyENEx = new ASPBodyEx();
            objASPNETBodyENEx.AspControlName = "Body";
            objASPNETInterfaceENEx.arrSubAspControlLst2.Add(objASPNETBodyENEx);

            ASPFormEx objASPNETFormENEx = new ASPFormEx();
            objASPNETFormENEx.AspControlName = "Form";
            objASPNETBodyENEx.arrSubAspControlLst2.Add(objASPNETFormENEx);

            ASPHtmlTableEx objASPNETHtmlTableENEx_Layout = clsASPHtmlTableBLEx.CreateLayout();

            objASPNETFormENEx.arrSubAspControlLst2.Add(objASPNETHtmlTableENEx_Layout);


            //建立查询区域－－－－－－－－－－－－－－－－－－－－－－－
            ASPRowEx objASPNETRowENEx_Query = new ASPRowEx();
            objASPNETRowENEx_Query.AspControlId = "trQueryRegion";
            objASPNETRowENEx_Query.AspControlName = "trQueryRegion";

            objASPNETHtmlTableENEx_Layout.arrSubAspControlLst2.Add(objASPNETRowENEx_Query);


            ASPColEx objASPNETColENEx_Query = new ASPColEx();
            objASPNETColENEx_Query.AspControlId = "tdQueryRegion";
            objASPNETColENEx_Query.AspControlName = "tdQueryRegion";
            objASPNETRowENEx_Query.arrSubAspControlLst2.Add(objASPNETColENEx_Query);
            ASPHtmlTableEx objASPNETHtmlTableENEx_QueryRegion = clsViewInfoBLEx.CreateQueryRegion(objViewInfoENEx);

            objASPNETColENEx_Query.arrSubAspControlLst2.Add(objASPNETHtmlTableENEx_QueryRegion);

            //建立查询区域＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝

            //建立功能区域－－－－－－－－－－－－－－－－－－－－－－－
            ASPRowEx objASPNETRowENEx_Func = new ASPRowEx();
            objASPNETRowENEx_Func.AspControlId = "trFeatureRegion";
            objASPNETRowENEx_Func.AspControlName = "trFeatureRegion";

            objASPNETHtmlTableENEx_Layout.arrSubAspControlLst2.Add(objASPNETRowENEx_Func);


            ASPColEx objASPNETColENEx_Func = new ASPColEx();
            objASPNETColENEx_Func.AspControlId = "tdFeatureRegion";
            objASPNETColENEx_Func.AspControlName = "tdFeatureRegion";
            objASPNETRowENEx_Func.arrSubAspControlLst2.Add(objASPNETColENEx_Func);
            ASPHtmlTableEx objASPNETHtmlTableENEx_FeatureRegion = clsViewInfoBLEx.CreateFeatureRegion(objViewInfoENEx);

            objASPNETColENEx_Func.arrSubAspControlLst2.Add(objASPNETHtmlTableENEx_FeatureRegion);

            //建立功能区域＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝


            //建立DG区域－－－－－－－－－－－－－－－－－－－－－－－
            ASPRowEx objASPNETRowENEx_DG = new ASPRowEx();
            objASPNETRowENEx_DG.AspControlId = "trDGRegion";
            objASPNETRowENEx_DG.AspControlName = "trDGRegion";

            objASPNETHtmlTableENEx_Layout.arrSubAspControlLst2.Add(objASPNETRowENEx_DG);


            ASPColEx objASPNETColENEx_DG = new ASPColEx();
            objASPNETColENEx_DG.AspControlId = "tdDGRegion";
            objASPNETColENEx_DG.AspControlName = "tdDGRegion";
            objASPNETRowENEx_DG.arrSubAspControlLst2.Add(objASPNETColENEx_DG);
            ASPHtmlTableEx objASPNETHtmlTableENEx_DGRegion = clsViewInfoBLEx.CreateDGRegion(objViewInfoENEx);

            objASPNETColENEx_DG.arrSubAspControlLst2.Add(objASPNETHtmlTableENEx_DGRegion);

            //建立DG区域＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝

            //建立编辑区域－－－－－－－－－－－－－－－－－－－－－－－
            ASPRowEx objASPNETRowENEx_Edit = new ASPRowEx();
            objASPNETRowENEx_Edit.AspControlId = "trEditRegion";
            objASPNETRowENEx_Edit.AspControlName = "trEditRegion";

            objASPNETHtmlTableENEx_Layout.arrSubAspControlLst2.Add(objASPNETRowENEx_Edit);


            ASPColEx objASPNETColENEx_Edit = new ASPColEx();
            objASPNETColENEx_Edit.AspControlId = "tdEditRegion";
            objASPNETColENEx_Edit.AspControlName = "tdEditRegion";
            objASPNETRowENEx_Edit.arrSubAspControlLst2.Add(objASPNETColENEx_Edit);
            ASPHtmlTableEx objASPNETHtmlTableENEx_EditRegion = clsASPHtmlTableBLEx.CreateEditRegion(objViewInfoENEx);

            objASPNETColENEx_Edit.arrSubAspControlLst2.Add(objASPNETHtmlTableENEx_EditRegion);

            //建立编辑区域＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝


            ShowTree(objASPNETInterfaceENEx);



            //clsASPFormEN objASPNETFormEN
        }
        private void ShowTree(ASPInterfaceEx objASPNETInterfaceENEx)
        {
            treeView1.Nodes.Clear();
            TreeNode tnRoot = new TreeNode();
            tnRoot.Text = objASPNETInterfaceENEx.AspControlName;
            treeView1.Nodes.Add(tnRoot);
            CreateSubNode(objASPNETInterfaceENEx, tnRoot);
        }

        private void CreateSubNode(ASPControlEx objASPNETControlENEx, TreeNode tnParentNode)
        {
            foreach (ASPControlEx objSubASPNETControlENEx in objASPNETControlENEx.arrSubAspControlLst2)
            {
                TreeNode tnNode = new TreeNode();
                string strType = objSubASPNETControlENEx.GetType().Name;
                tnNode.Text = string.Format("{0}({1})", objSubASPNETControlENEx.AspControlName, strType);
                tnParentNode.Nodes.Add(tnNode);
                CreateSubNode(objSubASPNETControlENEx, tnNode);
            }
        }

        private void btnGeneCode_Click(object sender, EventArgs e)
        {
            StringBuilder sbCode = new StringBuilder();
            try
            {
                //objASPNETInterfaceENEx.GeneCode(sbCode);
                textBox1.Text = sbCode.ToString();
            }
            catch(Exception objExcepiton)
            {
                textBox1.Text = sbCode.ToString();
                MessageBox.Show(objExcepiton.Message);
            }
        }
    }
}
