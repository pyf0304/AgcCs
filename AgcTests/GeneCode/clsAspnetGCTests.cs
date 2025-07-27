using Microsoft.VisualStudio.TestTools.UnitTesting;
using AGC.BusinessLogicEx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AGC.Entity;

namespace AGC.BusinessLogicEx.Tests
{
    [TestClass()]
    public class clsAspnetGCTests
    {
        [TestMethod()]
        public void ASPNETButton_GeneCodeTest()
        {
            //< asp:Button ID = "btnCancelExamTypeEdit" Style = "z-index: 107;"
            //                   runat = "server" Width = "100px" CssClass = "Button_Defa" Text = "取消编辑" OnClick = "btnCancelExamTypeEdit_Click" ></ asp:Button >

            StringBuilder sbCode = new StringBuilder();
            clsASPNETButtonENEx objASPNETButtonENEx = new clsASPNETButtonENEx();
            objASPNETButtonENEx.CtrlId = "btnAdd";
            objASPNETButtonENEx.OnClick = "btnAdd_Click";
            objASPNETButtonENEx.Text = "测试Add";
            objASPNETButtonENEx.Style = "z-index: 107;";
            objASPNETButtonENEx.CssClass = "Button_Defa";
            objASPNETButtonENEx.Width = 100;
            objASPNETButtonENEx.Height = 22;
            //objASPNETButtonENEx.mTextSize = "12sp";
            //objASPNETButtonENEx.minHeight = "35dp";
            //objASPNETButtonENEx.layout_constraintStart_toStartOf = "parent";
            //objASPNETButtonENEx.layout_constraintTop_toBottomOf = "@+id/txtNum2";
            clsASPNETButtonBLEx.GeneCode(objASPNETButtonENEx, sbCode);
            string ss = sbCode.ToString();

            //   Assert.Fail();
        }
        [TestMethod()]
        public void ASPNETLabel_GeneCodeTest()
        {
            StringBuilder sbCode = new StringBuilder();
            clsASPNETLabelENEx objASPNETLabelENEx = new clsASPNETLabelENEx();
            objASPNETLabelENEx.CtrlId = "lblAdd";
            //objASPNETLabelENEx.OnClick = "btnAdd_Click";
            objASPNETLabelENEx.Text = "测试Add";
            objASPNETLabelENEx.Width = 200;
            objASPNETLabelENEx.Height = 22;
            objASPNETLabelENEx.CssClass = "ErrMsg";
            //objASPNETLabelENEx.layout_constraintStart_toStartOf = "parent";
            //objASPNETLabelENEx.layout_constraintTop_toBottomOf = "@+id/lblNum2";
            clsASPNETLabelBLEx.GeneCode(objASPNETLabelENEx, sbCode);
            string ss = sbCode.ToString();
            Console.WriteLine(ss);
            //   Assert.Fail();
        }
        [TestMethod()]
        public void ASPNETTextBox_GeneCodeTest()
        {
            StringBuilder sbCode = new StringBuilder();
            clsASPNETTextBoxENEx objASPNETTextBoxENEx = new clsASPNETTextBoxENEx();
            objASPNETTextBoxENEx.CtrlId = "txtAdd";
            //objASPNETTextBoxENEx.OnClick = "btnAdd_Click";
            objASPNETTextBoxENEx.Text = "测试Add";
            objASPNETTextBoxENEx.Width = 100;
            objASPNETTextBoxENEx.Height = 22;
            objASPNETTextBoxENEx.CssClass = "TextBox_Defa";
            //objASPNETTextBoxENEx.layout_constraintStart_toStartOf = "parent";
            //objASPNETTextBoxENEx.layout_constraintTop_toBottomOf = "@+id/txtNum2";
            clsASPNETTextBoxBLEx.GeneCode(objASPNETTextBoxENEx, sbCode);
            string ss = sbCode.ToString();

            //   Assert.Fail();
        }
        [TestMethod()]
        public void ASPNETDropDownList_GeneCodeTest()
        {
            StringBuilder sbCode = new StringBuilder();
            clsASPNETDropDownListENEx objASPNETDropDownListENEx = new clsASPNETDropDownListENEx();
            objASPNETDropDownListENEx.CtrlId = "ddlTest1";
            //objASPNETDropDownListENEx.OnClick = "btnAdd_Click";
            objASPNETDropDownListENEx.Text = "测试Add";
            objASPNETDropDownListENEx.Width = 100;
            objASPNETDropDownListENEx.Height = 22;
            objASPNETDropDownListENEx.CssClass = "DropDownList_Defa";
            //objASPNETDropDownListENEx.layout_constraintStart_toStartOf = "parent";
            //objASPNETDropDownListENEx.layout_constraintTop_toBottomOf = "@+id/txtNum2";
            clsASPNETDropDownListBLEx.GeneCode(objASPNETDropDownListENEx, sbCode);
            string ss = sbCode.ToString();

            //   Assert.Fail();
        }
        [TestMethod()]
        public void AndroidConstraintLayout_GeneCodeTest()
        {
            StringBuilder sbCode = new StringBuilder();
            clsAndroidConstraintLayoutENEx objAndroidConstraintLayoutENEx = new clsAndroidConstraintLayoutENEx();
            objAndroidConstraintLayoutENEx.CtrlId = "txtAdd";
            objAndroidConstraintLayoutENEx.layout_width = "wrap_content";
            objAndroidConstraintLayoutENEx.layout_height = "wrap_content";
            objAndroidConstraintLayoutENEx.showIn = "@layout/ac_invoke_web_srv";
            objAndroidConstraintLayoutENEx.context = "com.taishsoft.TechnicalResearch.InvokeWebSrv";
            objAndroidConstraintLayoutENEx.layout_behavior = "@string/appbar_scrolling_view_behavior";


            clsAndroidConstraintLayoutBLEx.GeneCode(objAndroidConstraintLayoutENEx, sbCode);
            string ss = sbCode.ToString();

            //   Assert.Fail();
        }
        [TestMethod()]
        public void AndroidFile_GeneCodeTest()
        {
            StringBuilder sbCode = new StringBuilder();
            sbCode.Append(" <?xml version=\"1.0\" encoding=\"utf-8\" ?>");
               clsAndroidConstraintLayoutENEx objAndroidConstraintLayoutENEx = new clsAndroidConstraintLayoutENEx();
            objAndroidConstraintLayoutENEx.CtrlId = "txtAdd";
            objAndroidConstraintLayoutENEx.layout_width = "match_parent";
            objAndroidConstraintLayoutENEx.layout_height = "match_parent";
            //objAndroidConstraintLayoutENEx.showIn = "@layout/ac_invoke_web_srv";
            //objAndroidConstraintLayoutENEx.context = "com.taishsoft.TechnicalResearch.InvokeWebSrv";
            objAndroidConstraintLayoutENEx.layout_behavior = "@string/appbar_scrolling_view_behavior";

          
            clsAndroidTextViewENEx objAndroidTextViewENEx = new clsAndroidTextViewENEx();
            objAndroidTextViewENEx.CtrlId = "lblAdd";
            objAndroidTextViewENEx.OnClick = "btnAdd_Click";
            objAndroidTextViewENEx.Text = "测试Add";
            objAndroidTextViewENEx.layout_width = "wrap_content";
            objAndroidTextViewENEx.layout_height = "wrap_content";
            objAndroidTextViewENEx.layout_constraintStart_toStartOf = "parent";
            objAndroidTextViewENEx.layout_constraintTop_toTopOf = "parent";
            objAndroidConstraintLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidTextViewENEx);

            clsAndroidEditTextENEx objAndroidEditTextENEx = new clsAndroidEditTextENEx();
            objAndroidEditTextENEx.CtrlId = "txtAdd";
            objAndroidEditTextENEx.OnClick = "btnAdd_Click";
            objAndroidEditTextENEx.Text = "测试Add";
            objAndroidEditTextENEx.inputType = "textPersonName";
            objAndroidEditTextENEx.ems = 10;

            objAndroidEditTextENEx.layout_width = "wrap_content";
            objAndroidEditTextENEx.layout_height = "wrap_content";
            objAndroidEditTextENEx.layout_constraintStart_toStartOf = "parent";
            objAndroidEditTextENEx.layout_constraintTop_toBottomOf = "@+id/lblAdd";

            objAndroidConstraintLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidEditTextENEx);


            clsAndroidButtonENEx objAndroidButtonENEx = new clsAndroidButtonENEx();
            objAndroidButtonENEx.CtrlId = "btnAdd";
            objAndroidButtonENEx.OnClick = "btnAdd_Click";
            objAndroidButtonENEx.Text = "测试Add";
            objAndroidButtonENEx.layout_width = "wrap_content";
            objAndroidButtonENEx.layout_height = "wrap_content";
            objAndroidButtonENEx.layout_constraintStart_toStartOf = "parent";
            objAndroidButtonENEx.layout_constraintTop_toBottomOf = "@+id/txtAdd";

            objAndroidConstraintLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidButtonENEx);

            clsAndroidConstraintLayoutBLEx.GeneCode(objAndroidConstraintLayoutENEx, sbCode);
            string ss = sbCode.ToString();

            //   Assert.Fail();
        }


        [TestMethod()]
        public void AndroidTabs_GeneCodeTest()
        {
            StringBuilder sbCode = new StringBuilder();
            sbCode.Append(" <?xml version=\"1.0\" encoding=\"utf-8\" ?>");
            clsAndroidConstraintLayoutENEx objAndroidConstraintLayoutENEx = new clsAndroidConstraintLayoutENEx();
            objAndroidConstraintLayoutENEx.CtrlId = "txtAdd";
            objAndroidConstraintLayoutENEx.layout_width = "match_parent";
            objAndroidConstraintLayoutENEx.layout_height = "match_parent";
            //objAndroidConstraintLayoutENEx.showIn = "@layout/ac_invoke_web_srv";
            //objAndroidConstraintLayoutENEx.context = "com.taishsoft.TechnicalResearch.InvokeWebSrv";
            objAndroidConstraintLayoutENEx.layout_behavior = "@string/appbar_scrolling_view_behavior";


            clsAndroidTextViewENEx objAndroidTextViewENEx = new clsAndroidTextViewENEx();
            objAndroidTextViewENEx.CtrlId = "lblAdd";
            objAndroidTextViewENEx.OnClick = "btnAdd_Click";
            objAndroidTextViewENEx.Text = "测试Add";
            objAndroidTextViewENEx.layout_width = "wrap_content";
            objAndroidTextViewENEx.layout_height = "wrap_content";
            objAndroidTextViewENEx.layout_constraintStart_toStartOf = "parent";
            objAndroidTextViewENEx.layout_constraintTop_toTopOf = "parent";
            objAndroidConstraintLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidTextViewENEx);

            clsAndroidEditTextENEx objAndroidEditTextENEx = new clsAndroidEditTextENEx();
            objAndroidEditTextENEx.CtrlId = "txtAdd";
            objAndroidEditTextENEx.OnClick = "btnAdd_Click";
            objAndroidEditTextENEx.Text = "测试Add";
            objAndroidEditTextENEx.inputType = "textPersonName";
            objAndroidEditTextENEx.ems = 10;

            objAndroidEditTextENEx.layout_width = "wrap_content";
            objAndroidEditTextENEx.layout_height = "wrap_content";
            objAndroidEditTextENEx.layout_constraintStart_toStartOf = "parent";
            objAndroidEditTextENEx.layout_constraintTop_toBottomOf = "@+id/lblAdd";

            objAndroidConstraintLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidEditTextENEx);


            clsAndroidButtonENEx objAndroidButtonENEx = new clsAndroidButtonENEx();
            objAndroidButtonENEx.CtrlId = "btnAdd";
            objAndroidButtonENEx.OnClick = "btnAdd_Click";
            objAndroidButtonENEx.Text = "测试Add";
            objAndroidButtonENEx.layout_width = "wrap_content";
            objAndroidButtonENEx.layout_height = "wrap_content";
            objAndroidButtonENEx.layout_constraintStart_toStartOf = "parent";
            objAndroidButtonENEx.layout_constraintTop_toBottomOf = "@+id/txtAdd";

            objAndroidConstraintLayoutENEx.arrSubAndroidControlLst2.Add(objAndroidButtonENEx);

            clsAndroidConstraintLayoutBLEx.GeneCode(objAndroidConstraintLayoutENEx, sbCode);
            string ss = sbCode.ToString();

            //   Assert.Fail();
        }
    }
}